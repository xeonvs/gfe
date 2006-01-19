Option Strict Off
Option Explicit On
Module Mod_UnixTime
	
	Private Structure SYSTEMTIME ' 16 Bytes
		Dim wYear As Short
		Dim wMonth As Short
		Dim wDayOfWeek As Short
		Dim wDay As Short
		Dim wHour As Short
		Dim wMinute As Short
		Dim wSecond As Short
		Dim wMilliseconds As Short
	End Structure
	
	Private Structure TIME_ZONE_INFORMATION
		Dim Bias As Integer
		<VBFixedArray(31)> Dim StandardName() As Short
		Dim StandardDate As SYSTEMTIME
		Dim StandardBias As Integer
		<VBFixedArray(31)> Dim DaylightName() As Short
		Dim DaylightDate As SYSTEMTIME
		Dim DaylightBias As Integer
		
		'UPGRADE_TODO: "Initialize" must be called to initialize instances of this structure. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1026"'
		Public Sub Initialize()
			ReDim StandardName(31)
			ReDim DaylightName(31)
		End Sub
	End Structure
	
	'UPGRADE_WARNING: Structure TIME_ZONE_INFORMATION may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function GetTimeZoneInformation Lib "kernel32" (ByRef lpTimeZoneInformation As TIME_ZONE_INFORMATION) As Integer
	'UPGRADE_WARNING: Structure SYSTEMTIME may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function GetDateFormat Lib "kernel32"  Alias "GetDateFormatA"(ByVal Locale As Integer, ByVal dwFlags As Integer, ByRef lpDate As SYSTEMTIME, ByVal lpFormat As String, ByVal lpDateStr As String, ByVal cchDate As Integer) As Integer
	'UPGRADE_WARNING: Structure SYSTEMTIME may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function GetTimeFormat Lib "kernel32"  Alias "GetTimeFormatA"(ByVal Locale As Integer, ByVal dwFlags As Integer, ByRef lpTime As SYSTEMTIME, ByVal lpFormat As String, ByVal lpTimeStr As String, ByVal cchTime As Integer) As Integer
	
	Public Structure tm
		Dim tm_sec As Integer ' seconds (0 - 59)
		Dim tm_min As Integer ' minutes (0 - 59)
		Dim tm_hour As Integer ' hours (0 - 23)
		Dim tm_mday As Integer ' day of month (1 - 31)
		Dim tm_mon As Integer ' month of year (0 - 11)
		Dim tm_year As Integer ' year - 1900
		Dim tm_wday As Integer ' day of week (Sunday = 0), Not used
		Dim tm_yday As Integer ' day of year (0 - 365), Not used
		Dim tm_isdst As Integer ' Daylight Savings Time (0, 1), Not used
	End Structure
	
	'inits
	Private lSecPerYear(1) As Integer ' [0] = normal year, [1] = leap year
	Private lSecPerMonth(11) As Integer
	Private Const lSecPerDay As Integer = 86400 ' 60*60*24
	Private Const lSecPerHour As Integer = 3600 ' 60 * 60
	Private Const DATE_LONGDATE As Short = &H2s '  use long date picture
	
	Public Sub InitModule()
		
		lSecPerYear(0) = 31536000
		lSecPerYear(1) = 31622400
		
		lSecPerMonth(0) = 2678400
		lSecPerMonth(1) = 2419200
		lSecPerMonth(2) = 2678400
		lSecPerMonth(3) = 2592000
		lSecPerMonth(4) = 2678400
		lSecPerMonth(5) = 2592000
		lSecPerMonth(6) = 2678400
		lSecPerMonth(7) = 2678400
		lSecPerMonth(8) = 2592000
		lSecPerMonth(9) = 2678400
		lSecPerMonth(10) = 2592000
		lSecPerMonth(11) = 2678400
		
	End Sub
	
	'---end inits---
	Public Function sUnixDate(ByVal lValue As Integer, Optional ByRef NetmailTime As Boolean = False) As String
		On Error GoTo errHandler
		
		' Now for the LocalTime function. Take
		'     the long value representing the number
		' of seconds since January 1, 1970 and c
		'     reate a useable time structure from it.
		' Return a formatted string DD.MM.YYYY H
		'     H:MM:SS
		'Если NetMailTime=1 то тогда считаем начиная с 101 года
		'UPGRADE_NOTE: Year was upgraded to Year_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Year_Renamed As Integer
		'UPGRADE_NOTE: Month was upgraded to Month_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Month_Renamed As Integer
		'UPGRADE_NOTE: Day was upgraded to Day_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Day_Renamed As Integer
		'UPGRADE_NOTE: Hour was upgraded to Hour_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Hour_Renamed As Integer
		'UPGRADE_NOTE: Minute was upgraded to Minute_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Minute_Renamed As Integer
		'UPGRADE_NOTE: Second was upgraded to Second_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Second_Renamed As Integer
		Dim Temp As Integer
		Dim cTime As SYSTEMTIME
		Dim ret As Integer
		Dim fStr As String
		
		' starting point
		If NetmailTime Then
			Year_Renamed = 101
		Else
			Year_Renamed = 70
		End If
		' Calculate the year
		
		Do While (lValue > 0)
			Temp = isLeapYear(Year_Renamed)
			
			If (lValue - lSecPerYear(Temp)) > 0 Then
				lValue = lValue - lSecPerYear(Temp)
				Year_Renamed = Year_Renamed + 1
			Else
				Exit Do
			End If
		Loop 
		'Debug.Print "Year = " & Year
		' Calculate the month
		Month_Renamed = 1
		
		Do While (lValue > 0)
			Temp = secsInMonth(Year_Renamed, Month_Renamed)
			
			If (lValue - Temp) > 0 Then
				lValue = lValue - Temp
				Month_Renamed = Month_Renamed + 1
			Else
				Exit Do
			End If
		Loop 
		'Debug.Print "Month = " & Month
		' Now calculate day
		Day_Renamed = 1
		
		Do While (lValue > 0)
			
			If (lValue - lSecPerDay) > 0 Then
				lValue = lValue - lSecPerDay
				Day_Renamed = Day_Renamed + 1
			Else
				Exit Do
			End If
		Loop 
		'Debug.Print "Day = " & Day
		' Now calculate Hour
		Hour_Renamed = 0
		
		Do While (lValue > 0)
			
			If (lValue - lSecPerHour) > 0 Then
				lValue = lValue - lSecPerHour
				Hour_Renamed = Hour_Renamed + 1
			Else
				Exit Do
			End If
		Loop 
		'Debug.Print "Hour = " & Hour
		Minute_Renamed = Int(lValue / 60)
		'Debug.Print "Minute = " & Minute
		Second_Renamed = lValue Mod 60
		'Debug.Print "Second = " & Second
		' Standard date format is YYYY/MM/DD HH:
		'     MM:SS
		'If Year < 100 Then
		Year_Renamed = Year_Renamed + 1900
		'sUnixDate = Month & "/" & Day & "/" & Year & ", " & Hour & ":" & Minute & ":" & Second
		
		If Minute_Renamed = 60 Then Minute_Renamed = 59
		If Second_Renamed = 60 Then Second_Renamed = 59
		
		If Month_Renamed <= 0 Then Month_Renamed = 1
		If Hour_Renamed < 0 Then Hour_Renamed = 0
		If Minute_Renamed < 0 Then Minute_Renamed = 0
		If Second_Renamed < 0 Then Second_Renamed = 0
		
		With cTime
			.wDay = CShort(Day_Renamed)
			.wDayOfWeek = 0
			.wHour = CShort(Hour_Renamed)
			.wMilliseconds = 0
			.wMinute = CShort(Minute_Renamed)
			.wMonth = CShort(Month_Renamed)
			.wSecond = CShort(Second_Renamed)
			.wYear = CShort(Year_Renamed)
		End With
		
		fStr = New String(Chr(0), 255)
		ret = GetDateFormat(0, DATE_LONGDATE, cTime, vbNullString, fStr, 254)
		If ret <> 0 Then
			sUnixDate = Left(fStr, ret - 1)
		Else
			Err.Raise(999, "Mod_UnixTime", "GetDateFormat Error!")
			ApiErrorLookup(GetLastError, "Mod_UnixTime::sUnixDate::GetDateFormat")
			sUnixDate = vbNullString
			Exit Function
		End If
		
		fStr = New String(Chr(0), 255)
		ret = GetTimeFormat(0, 0, cTime, "hh:mm:ss", fStr, 254)
		If ret <> 0 Then
			sUnixDate = sUnixDate & " " & Left(fStr, ret - 1)
		Else
			Err.Raise(999, "Mod_UnixTime", "GetTimeFormat Error!")
			ApiErrorLookup(GetLastError, "Mod_UnixTime::sUnixDate::GetTimeFormat")
			sUnixDate = vbNullString
			Exit Function
		End If
		
		Exit Function
		
		Exit Function
		
errHandler: 
		Select Case Err.Number
			Case Else
				ErrorMessage(Err.Number, Err.Description, "Mod_UnixTime::sUnixDate")
		End Select
	End Function
	
	'UPGRADE_NOTE: Year was upgraded to Year_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Private Function isLeapYear(ByRef Year_Renamed As Integer) As Short
		' Determine if given ANSI datetime struct represents a leap year
		' Private function: assumes valid parameters
		If (((Year_Renamed + 1900) Mod 4 = 0 And Not ((Year_Renamed + 1900) Mod 100)) Or (Year_Renamed + 1900) Mod 400 = 0) Then
			isLeapYear = 1 ' its a leap year
		Else
			isLeapYear = 0 ' Not a leap year
		End If
	End Function
	
	'UPGRADE_NOTE: Month was upgraded to Month_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	'UPGRADE_NOTE: Year was upgraded to Year_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Private Function secsInMonth(ByRef Year_Renamed As Integer, ByRef Month_Renamed As Integer) As Integer
		' Return total number of seconds in the  given month
		' Private function: assumes valid parameters
		Dim lResult As Integer
		
		' Compute result
		lResult = lSecPerMonth(Month_Renamed - 1)
		
		If (isLeapYear(Year_Renamed) And Month_Renamed = 2) Then
			lResult = lResult + 86400 ' its February In a leap year
		End If
		secsInMonth = lResult
	End Function
	
	
	'UPGRADE_NOTE: Year was upgraded to Year_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Private Function secsInYears(ByRef Year_Renamed As Integer) As Double
		' Return sum of seconds for years since
		'     Jan 1, 1970 00:00
		' up to but excluding the given year.
		' Private function: assumes valid parame
		'     ters
		Dim lResult As Integer
		Dim thisYear As Integer
		Dim Temp As Integer
		lResult = 0
		
		If (Year_Renamed > 97) Then
			' shorten summation iterations for typic
			'     al cases
			lResult = 883612800 ' seconds To Jan 1,1998 00:00:00
			thisYear = 98
		Else
			' sum all years since 1970
			thisYear = 70
		End If
		' Sum total seconds since Jan 1, 1970 00
		'     :00
		
		
		While (thisYear < Year_Renamed)
			'for ( ; thisYear < year; thisYear++
			'     )
			Temp = isLeapYear(thisYear)
			lResult = lResult + lSecPerYear(Temp)
			thisYear = thisYear + 1
		End While
		secsInYears = lResult
	End Function
	
	
	Private Function GetLocalTZ(Optional ByRef strTZName As String = "") As Integer
		'UPGRADE_WARNING: Arrays in structure objTimeZone may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1063"'
		Dim objTimeZone As TIME_ZONE_INFORMATION
		Dim lngResult As Integer
		Dim i As Integer
		lngResult = GetTimeZoneInformation(objTimeZone)
		
		
		Select Case lngResult
			Case 0, 1 'use standard time
				GetLocalTZ = -(objTimeZone.Bias + objTimeZone.StandardBias) * 60 'into minutes
				
				
				For i = 0 To 31
					If objTimeZone.StandardName(i) = 0 Then Exit For
					strTZName = strTZName & Chr(objTimeZone.StandardName(i))
				Next 
			Case 2 'use daylight savings time
				GetLocalTZ = -(objTimeZone.Bias + objTimeZone.DaylightBias) * 60 'into minutes
				
				
				For i = 0 To 31
					If objTimeZone.DaylightName(i) = 0 Then Exit For
					strTZName = strTZName & Chr(objTimeZone.DaylightName(i))
				Next 
		End Select
	End Function
	
	Public Function GetTime() As Double
		Dim TheDate As Date 'target date
		Dim SecondsToTarget As Integer
		'set target date.
		TheDate = CDate("01/01/1970")
		'compute # of seconds left to target date
		SecondsToTarget = DateDiff(Microsoft.VisualBasic.DateInterval.Second, Now, TheDate)
		'iResult = (GetLocalTZ / 30) * 30
		GetTime = CDbl(Mid(CStr(SecondsToTarget), 2)) '- GetLocalTZ
		'6 * 6 = 36 | 60 * 60 = 3600
	End Function
	
	Public Function GetTime80() As Double
		Dim TheDate As Date 'target date
		Dim SecondsToTarget As Integer
		'set target date.
		TheDate = CDate("01/01/1980")
		'compute # of seconds left to target date
		SecondsToTarget = DateDiff(Microsoft.VisualBasic.DateInterval.Second, Now, TheDate)
		'iResult = (GetLocalTZ / 30) * 30
		GetTime80 = CDbl(Mid(CStr(SecondsToTarget), 2)) '- GetLocalTZ
		'6 * 6 = 36 | 60 * 60 = 3600
	End Function
End Module