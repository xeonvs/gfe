Option Strict Off
Option Explicit On
Module Registry
	
	' -----------------
	' ADVAPI32
	' -----------------
	' function prototypes, constants, and type definitions
	' for Windows 32-bit Registry API
	
	Public Const HKEY_CLASSES_ROOT As Integer = &H80000000
	Public Const HKEY_CURRENT_USER As Integer = &H80000001
	Public Const HKEY_LOCAL_MACHINE As Integer = &H80000002
	Public Const HKEY_USERS As Integer = &H80000003
	Public Const HKEY_PERFORMANCE_DATA As Integer = &H80000004
	Public Const ERROR_SUCCESS As Integer = 0
	
	' Registry API prototypes
	
	Declare Function RegCloseKey Lib "advapi32.dll" (ByVal hKey As Integer) As Integer
	Declare Function RegCreateKey Lib "advapi32.dll"  Alias "RegCreateKeyA"(ByVal hKey As Integer, ByVal lpSubKey As String, ByRef phkResult As Integer) As Integer
	Declare Function RegDeleteKey Lib "advapi32.dll"  Alias "RegDeleteKeyA"(ByVal hKey As Integer, ByVal lpSubKey As String) As Integer
	Declare Function RegDeleteValue Lib "advapi32.dll"  Alias "RegDeleteValueA"(ByVal hKey As Integer, ByVal lpValueName As String) As Integer
	Declare Function RegOpenKey Lib "advapi32.dll"  Alias "RegOpenKeyA"(ByVal hKey As Integer, ByVal lpSubKey As String, ByRef phkResult As Integer) As Integer
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Declare Function RegQueryValueEx Lib "advapi32.dll"  Alias "RegQueryValueExA"(ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByRef lpData As Any, ByRef lpcbData As Integer) As Integer
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Declare Function RegSetValueEx Lib "advapi32.dll"  Alias "RegSetValueExA"(ByVal hKey As Integer, ByVal lpValueName As String, ByVal Reserved As Integer, ByVal dwType As Integer, ByRef lpData As Any, ByVal cbData As Integer) As Integer
	Public Const REG_SZ As Short = 1 ' Unicode nul terminated string
	Public Const REG_DWORD As Short = 4 ' 32-bit number
	
	Public Sub SaveKey(ByRef hKey As Integer, ByRef strPath As String)
		Dim keyhand, r As Integer
		r = RegCreateKey(hKey, strPath, keyhand)
		r = RegCloseKey(keyhand)
	End Sub
	
	'UPGRADE_NOTE: default was upgraded to default_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Public Function GetString(ByRef hKey As Integer, ByRef strPath As String, ByRef strValue As String, Optional ByRef default_Renamed As String = "") As String
		Dim r As Integer
		Dim keyhand As Integer
		Dim lResult As Integer
		Dim strBuf As String
		Dim lDataBufSize As Integer
		Dim intZeroPos As Short
		Dim lValueType As Integer
		r = RegOpenKey(hKey, strPath, keyhand)
		lResult = RegQueryValueEx(keyhand, strValue, 0, lValueType, 0, lDataBufSize)
		If lValueType = REG_SZ Then
			strBuf = New String(" ", lDataBufSize)
			lResult = RegQueryValueEx(keyhand, strValue, 0, 0, strBuf, lDataBufSize)
			If lResult = ERROR_SUCCESS Then
				intZeroPos = InStr(strBuf, Chr(0))
				If intZeroPos > 0 Then
					GetString = Left(strBuf, intZeroPos - 1)
				Else
					GetString = strBuf
				End If
			End If
		End If
		If Len(GetString) = 0 And Len(default_Renamed) <> 0 Then
			GetString = default_Renamed
		End If
		r = RegCloseKey(keyhand)
	End Function
	
	Public Sub SaveString(ByRef hKey As Integer, ByRef strPath As String, ByRef strValue As String, ByRef strdata As String)
		Dim keyhand As Integer
		Dim r As Integer
		r = RegCreateKey(hKey, strPath, keyhand)
		r = RegSetValueEx(keyhand, strValue, 0, REG_SZ, strdata, Len(strdata))
		r = RegCloseKey(keyhand)
	End Sub
	
	
	Public Function GetdWord(ByVal hKey As Integer, ByVal strPath As String, ByVal strValueName As String) As Integer
		Dim lResult As Integer
		Dim lValueType As Integer
		Dim lBuf As Integer
		Dim lDataBufSize As Integer
		Dim r As Integer
		Dim keyhand As Integer
		
		r = RegOpenKey(hKey, strPath, keyhand)
		
		' Get length/data type
		lDataBufSize = 4
		
		lResult = RegQueryValueEx(keyhand, strValueName, 0, lValueType, lBuf, lDataBufSize)
		
		If lResult = ERROR_SUCCESS Then
			If lValueType = REG_DWORD Then
				GetdWord = lBuf
			End If
			'Else
			'    Call errlog("GetDWORD-" & strPath, False)
		End If
		
		r = RegCloseKey(keyhand)
		
	End Function
	
	Public Function SaveDword(ByVal hKey As Integer, ByVal strPath As String, ByVal strValueName As String, ByVal lData As Integer) As Object
		Dim lResult As Integer
		Dim keyhand As Integer
		Dim r As Integer
		r = RegCreateKey(hKey, strPath, keyhand)
		lResult = RegSetValueEx(keyhand, strValueName, 0, REG_DWORD, lData, 4)
		'If lResult <> error_success Then Call errlog("SetDWORD", False)
		r = RegCloseKey(keyhand)
	End Function
	
	Public Function DeleteKey(ByVal hKey As Integer, ByVal strKey As String) As Object
		Dim r As Integer
		r = RegDeleteKey(hKey, strKey)
	End Function
	
	Public Function DeleteValue(ByVal hKey As Integer, ByVal strPath As String, ByVal strValue As String) As Object
		Dim keyhand, r As Integer
		r = RegOpenKey(hKey, strPath, keyhand)
		r = RegDeleteValue(keyhand, strValue)
		r = RegCloseKey(keyhand)
	End Function
End Module