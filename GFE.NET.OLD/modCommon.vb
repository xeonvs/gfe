Option Strict Off
Option Explicit On
Module modCommon
	
	'#Const bDEBUG = True
	
	Public Structure msg
		Dim hWnd As Integer
		Dim Message As Integer
		Dim wParam As Integer
		Dim lParam As Integer
		Dim time As Integer
		Dim pt As POINTAPI
	End Structure
	
	'функция "правельной" задержки
	Public Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)
	
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Public Declare Function SendMessage Lib "user32"  Alias "SendMessageA"(ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Any) As Integer
	
	'UPGRADE_WARNING: Structure msg may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Public Declare Function PeekMessage Lib "user32"  Alias "PeekMessageA"(ByRef lpMsg As msg, ByVal hWnd As Integer, ByVal wMsgFilterMin As Integer, ByVal wMsgFilterMax As Integer, ByVal wRemoveMsg As Integer) As Integer
	
	'UPGRADE_WARNING: Structure msg may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Public Declare Function TranslateMessage Lib "user32" (ByRef lpMsg As msg) As Integer
	
	'UPGRADE_WARNING: Structure msg may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Public Declare Function DispatchMessage Lib "user32"  Alias "DispatchMessageA"(ByRef lpMsg As msg) As Integer
	
	Public Declare Function GetTickCount Lib "kernel32" () As Integer
	
	Public Declare Function ShellExecute Lib "shell32.dll"  Alias "ShellExecuteA"(ByVal hWnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
	
	'UPGRADE_WARNING: Structure POINTAPI may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Public Declare Function GetCursorPos Lib "user32" (ByRef lpPoint As POINTAPI) As Integer
	
	Private Declare Function FindWindow Lib "user32"  Alias "FindWindowA"(ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
	
	Private Declare Function GetWindowText Lib "user32"  Alias "GetWindowTextA"(ByVal hWnd As Integer, ByVal lpString As String, ByVal cch As Integer) As Integer
	
	Public Declare Function GetDC Lib "user32" (ByVal hWnd As Integer) As Integer
	
	'UPGRADE_WARNING: Structure LOGBRUSH may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Public Declare Function CreateBrushIndirect Lib "gdi32" (ByRef lpLogBrush As LOGBRUSH) As Integer
	
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Public Declare Function FillRect Lib "user32" (ByVal hdc As Integer, ByRef lpRect As RECT, ByVal hBrush As Integer) As Integer
	
	Public Declare Function MoveToEx Lib "gdi32" (ByVal hdc As Integer, ByVal X As Integer, ByVal Y As Integer, ByRef lpPoint As Integer) As Integer
	
	Public Declare Function LineTo Lib "gdi32" (ByVal hdc As Integer, ByVal X As Integer, ByVal Y As Integer) As Integer
	
	Public Declare Function LockWindowUpdate Lib "user32" (ByVal hwndLock As Integer) As Integer
	
	Public Declare Function lStrLen Lib "kernel32"  Alias "lstrlenA"(ByVal lpString As String) As Integer
	
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	'UPGRADE_WARNING: Structure IUnknown may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function URLDownloadToFile Lib "urlmon"  Alias "URLDownloadToFileA"(ByVal pCaller As stdole.IUnknown, ByVal szURL As String, ByVal szFileName As String, ByVal dwReserved As Integer, ByVal lpfnCB As Any) As Integer
	
	'-print
	
	Private Structure CharRange
		Dim cpMin As Integer ' First character of range (0 for start of doc)
		Dim cpMax As Integer ' Last character of range (-1 for end of doc)
	End Structure
	
	Private Structure FormatRange
		Dim hdc As Integer ' Actual DC to draw on
		Dim hdcTarget As Integer ' Target DC for determining text formatting
		Dim rc As RECT ' Region of the DC to draw to (in twips)
		Dim rcPage As RECT ' Region of the entire DC (page size) (in twips)
		Dim chrg As CharRange ' Range of text to draw (see above declaration)
	End Structure
	
	Private Const LOGPIXELSX As Short = 88
	
	Private Const LOGPIXELSY As Short = 90
	
	Private Const PHYSICALOFFSETX As Integer = 112
	
	Private Const PHYSICALOFFSETY As Integer = 113
	
	Private Const WM_USER As Integer = &H400s
	
	Private Const EM_FORMATRANGE As Integer = WM_USER + 57
	
	Private Declare Function GetDeviceCaps Lib "gdi32" (ByVal hdc As Integer, ByVal nIndex As Integer) As Integer
	
	'---------------------------
	
	'---XP Style---
	'UPGRADE_WARNING: Structure CommonControlsEx may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function InitCommonControlsEx Lib "Comctl32.dll" (ByRef iccex As CommonControlsEx) As Boolean
	
	Private Structure CommonControlsEx
		Dim dwSize As Integer
		Dim dwICC As Integer
	End Structure
	
	Private Const ICC_BAR_CLASSES As Integer = &H4s
	
	Private Const ICC_COOL_CLASSES As Integer = &H400s
	
	Private Const ICC_USEREX_CLASSES As Integer = &H200 '// comboex
	
	Private Const ICC_WIN95_CLASSES As Integer = &HFF
	'---End---
	
	'----drawings
	Public Structure LOGBRUSH
		Dim lbStyle As Integer
		Dim lbColor As Integer
		Dim lbHatch As Integer
	End Structure
	'-----end-----
	
	'Process Execute Control Constants
	Public Const SW_HIDE As Integer = 0
	
	Public Const SW_NORMAL As Integer = 1
	
	Public Const SW_SHOWMINIMIZED As Integer = 2
	
	Public Const SW_SHOWMAXIMIZED As Integer = 3
	
	Public Const SW_MAXIMIZE As Integer = 3
	
	Public Const SW_SHOW As Integer = 5
	
	Public Const SW_MINIMIZE As Integer = 6
	
	Public Const SW_SHOWMINNOACTIVE As Integer = 7
	
	Public Const SW_RESTORE As Integer = 9
	
	Public Const WM_HSCROLL As Integer = &H114s
	
	Public Const WM_VSCROLL As Integer = &H115s
	
	Public Const WM_KEYDOWN As Integer = &H100s
	
	Public Const WM_KEYUP As Integer = &H101s
	
	Public Const WM_SYSKEYDOWN As Integer = &H104s
	
	Public Const WM_SYSKEYUP As Integer = &H105s
	
	Public Const WM_PASTE As Integer = &H302s
	
	'Scroll Control
	Public Const SB_ENDSCROLL As Integer = 8
	
	Public Const SB_LEFT As Integer = 6 'Scrolls to the upper left.
	
	Public Const SB_RIGHT As Integer = 7 'Scrolls to the upper right.
	
	Public Const SB_PAGELEFT As Integer = 2
	
	Public Const SB_PAGERIGHT As Integer = 3
	
	Public Const SB_LINELEFT As Integer = 0 'Scrolls left by the width of the window.
	
	Public Const SB_LINERIGHT As Integer = 1 'Scrolls right by the width of the window.
	
	Public Const SB_LINEDOWN As Integer = 1
	
	Public Const SB_LINEUP As Integer = 0
	
	Public Const MAX_PATH As Integer = 260
	
	'message query
	Public Const PM_NOYIELD As Integer = &H2s
	
	Public Const PM_NOREMOVE As Integer = &H0s
	
	Public Const PM_REMOVE As Integer = &H1s
	
	'Структура для передачи параметров текущей базы между формами
	Public Structure tMessage
		Dim Mode As ReplayMode
		Dim base As Object
		Dim BaseType As String
		Dim CurrentMail As Integer
	End Structure
	
	Public TransferMessage As tMessage
	
	'Режимы передачи базы/мессага
	Public Enum ReplayMode
		NewMail = 0 'Новое письмо
		ReplayFrom = 1 'Ответ отправителю
		ReplayTo = 2 'Ответ отправителю исходного
		ReplayFromNotCit = 3 'Ответ без цитирования
		ReplayOtherArea = 4 'Ответ в другую эху
		MailForward = 5 'Пересылка письма
		MailMoving = 6 'Перемещение
		MailCopying = 7 'Копирование
		MailChange = 8 'Изменение
		BookMail = 9 'Письмо из адресной книги
		ViewMails = 99 'Просмотр
	End Enum
	
	Public Enum code
		Win = 1
		Dos = 2
		Koi = 3
		Iso = 5
	End Enum
	
	Public AddrBk As Object 'Доступ к адресной книге(переделка для позднего связывания)
	'Global AddrBk As New  AddrBook.clsAddress
	'Global clsEchos As New EasyEchosSupport.clsEchoNames
	Public clsEchos As Object
	
	Public rdb As Object 'создаем объект доступа к внешней базе состояний мессаг
	
	Public rdb_ext As Integer 'Флаг исспользования внешней библиотеки поддержки базы прочитанных писем.
	
	'~~~~~~~~~~settings ~~~~~~~~~~~~~
	Public msgModeratorColor As Integer
	Public msgRulesColor As Integer
	Public msgMainTextColor As Integer
	Public msgBackColor As Integer
	Public msgAlienCitatColor As Integer
	Public msgMyCitatColor As Integer
	Public msgTaglineColor As Integer
	Public msgTirlineColor As Integer
	Public msgOriginColor As Integer
	Public msgMyMessagesColor As Integer
	'~~~~~~~~~~~~~~~~~
	
	'UPGRADE_NOTE: Main was upgraded to Main_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Public Sub Main_Renamed()
		On Error Resume Next
		
		Dim tIccex As CommonControlsEx
		
		With tIccex
			'UPGRADE_ISSUE: LenB function is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1040"'
			.dwSize = LenB(tIccex)
			'.dwICC = ICC_BAR_CLASSES
			.dwICC = ICC_COOL_CLASSES
		End With
		
		'We need to make this call to make sure the common controls are loaded
		InitCommonControlsEx(tIccex)
		
		'Time inits
		Mod_UnixTime.InitModule()
		
		'подключим библиотеку поддержки эх
		clsEchos = CreateObject("EasyEchosSupport.clsEchoNames")
		
		Select Case Err.Number
			
			Case -2147024770
				MsgBox("EasyEchosSupport.dll Error!" & vbCrLf & "Библиотека EasyEchos не зарегистрирована!" & vbCrLf & "Нажмите Ok для регистрации.", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				Err.Clear()
				GetAttr(VB6.GetPath & "\EasyEchosSupport.dll")
				
				Select Case Err.Number
					
					Case 0
						modPlugins.RegPlugin(VB6.GetPath & "\EasyEchosSupport.dll", True)
						clsEchos = CreateObject("EasyEchosSupport.clsEchoNames")
						
					Case 53
						MsgBox("RegDll Error!" & vbCrLf & "Файл " & VB6.GetPath & "\EasyEchosSupport.dll не найден!", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
						GoTo rgplg
						
					Case Else
						MsgBox("EasyEchosSupport.dll Error #" & Err.Number & vbCrLf & "Description: " & Err.Description, MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
						GoTo rgplg
				End Select
				
			Case 429
				GetAttr(VB6.GetPath & "\EasyEchosSupport.dll")
				
				If Err.Number = 53 Then
					MsgBox("RegDll Error!" & vbCrLf & "Файл " & VB6.GetPath & "\EasyEchosSupport.dll не найден!", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
					GoTo rgplg
				End If
				
				MsgBox("EasyEchosSupport.dll Error!" & vbCrLf & "Библиотека EasyEchos не зарегистрирована!" & vbCrLf & "Нажмите Ok для регистрации.", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				modPlugins.RegPlugin(VB6.GetPath & "\EasyEchosSupport.dll", True)
				clsEchos = CreateObject("EasyEchosSupport.clsEchoNames")
		End Select
		
rgplg: 
		
		rdb_ext = CInt(GetGFEOption("Options", "ReadBaseExt", "0"))
		
		'подключим библиотеку поддержки базы состояний
		rdb = CreateObject("rdbBase.clsReadDb")
		
		Select Case Err.Number
			
			Case -2147024770
				MsgBox("rdbBase.dll Error!" & vbCrLf & "Библиотека rdbBase не зарегистрирована!" & vbCrLf & "Нажмите Ok для регистрации.", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				Err.Clear()
				GetAttr(VB6.GetPath & "\rdbBase.dll")
				
				Select Case Err.Number
					
					Case 0
						modPlugins.RegPlugin(VB6.GetPath & "\rdbBase.dll", True)
						rdb = CreateObject("rdbBase.clsReadDb")
						
					Case 53
						MsgBox("RegDll Error!" & vbCrLf & "Файл " & VB6.GetPath & "\rdbBase.dll не найден!", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
						GoTo regoth
						
					Case Else
						MsgBox("rdbBase.dll Error #" & Err.Number & vbCrLf & "Description: " & Err.Description, MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
						GoTo regoth
				End Select
				
			Case 429
				GetAttr(VB6.GetPath & "\rdbBase.dll")
				
				If Err.Number = 53 Then
					MsgBox("RegDll Error!" & vbCrLf & "Файл " & VB6.GetPath & "\rdbBase.dll не найден!", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
					GoTo regoth
				End If
				
				MsgBox("EasyEchosSupport.dll Error!" & vbCrLf & "Библиотека EasyEchos не зарегистрирована!" & vbCrLf & "Нажмите Ok для регистрации.", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				modPlugins.RegPlugin(VB6.GetPath & "\rdbBase.dll", True)
				rdb = CreateObject("rdbBase.clsReadDb")
		End Select
		
regoth: 
		
		'т.к адресная книга является "нечестным" плугином(объектом) то _
		'ее зарегистрируем отдельно от всех остальных.
		AddrBk = CreateObject("AddrBook.clsAddress")
		
		Select Case Err.Number
			
			Case 0
				Call RegisterAllPlugins() 'зарегистрируем наши плугины
				frmMain.DefInstance.mnuPlugins(0).Enabled = True
				frmMain.DefInstance.mnuPlugins(0).Text = "AddrBook"
				
			Case -2147024770
				MsgBox("AddrBook.Dll Error!" & vbCrLf & "Плугин не зарегистрирован! Нажмите Ok для регистрации.", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - Debug Mode")
				Err.Clear()
				GetAttr(VB6.GetPath & "\Plugins\AddrBook.Dll")
				
				Select Case Err.Number
					
					Case 0
						modPlugins.RegPlugin(VB6.GetPath & "\Plugins\AddrBook.Dll", True)
						AddrBk = CreateObject("AddrBook.clsAddress")
						frmMain.DefInstance.mnuPlugins(0).Text = "AddrBook"
						frmMain.DefInstance.mnuPlugins(0).Enabled = True
						
					Case 53
						MsgBox("RegDll Error!" & vbCrLf & "Файл " & VB6.GetPath & "\Plugins\AddrBook.Dll не найден!", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
						frmMain.DefInstance.mnuPlugins(0).Text = "AddrBook"
						frmMain.DefInstance.mnuPlugins(0).Enabled = False
						
					Case Else
						MsgBox("AddrBook.Dll Error #" & Err.Number & vbCrLf & "Description: " & Err.Description, MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - Debug Mode")
						Call RegisterAllPlugins()
						frmMain.DefInstance.mnuPlugins(0).Enabled = False
						frmMain.DefInstance.mnuPlugins(0).Text = "AddrBook"
						GoTo noaddr
				End Select
				
				Call RegisterAllPlugins()
				GoTo noaddr
				
			Case 429
				GetAttr(VB6.GetPath & "\Plugins\AddrBook.Dll")
				
				If Err.Number = 53 Then
					MsgBox("RegDll Error!" & vbCrLf & "Файл " & VB6.GetPath & "\Plugins\AddrBook.Dll не найден!", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
					GoTo noaddr
				End If
				
				MsgBox("AddrBook.Dll Error!" & vbCrLf & "Плугин не зарегистрирован! Нажмите Ok для регистрации.", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - Debug Mode")
				modPlugins.RegPlugin(VB6.GetPath & "\Plugins\AddrBook.Dll", True)
				AddrBk = CreateObject("AddrBook.clsAddress")
				Call RegisterAllPlugins()
				frmMain.DefInstance.mnuPlugins(0).Text = "AddrBook"
				
			Case Else
				MsgBox("Error #" & Err.Number & vbCrLf & "Description: " & Err.Description, MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - Debug Mode")
				Call RegisterAllPlugins()
				frmMain.DefInstance.mnuPlugins(0).Enabled = False
				frmMain.DefInstance.mnuPlugins(0).Text = "AddrBook"
				GoTo noaddr
		End Select
		
		'установки для адресной книги
		'UPGRADE_WARNING: Couldn't resolve default property of object AddrBk.DBName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		AddrBk.DBName = VB6.GetPath & "\addr.db" 'Открываем базу
		'UPGRADE_WARNING: Couldn't resolve default property of object AddrBk.EditorForm. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		AddrBk.EditorForm = frmMailEditor.DefInstance
		'UPGRADE_WARNING: Couldn't resolve default property of object AddrBk.MainForm. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		AddrBk.MainForm = frmMain.DefInstance
		'------
		
noaddr: 
		
		On Error GoTo errHandler
		
		System.Windows.Forms.Application.DoEvents()
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "modCommon::Main")
		End Select
		
	End Sub
	
	'Импортирует конфиг голдеда в реестр
	Public Sub ImportGedCfg(ByRef gdPath As String)
		On Error GoTo errHandler
		'нужные нам переменные
		Dim UserName() As String ' Имя пользователя
		Dim Address As String 'Адрес системы
		Dim AKA() As String ' AkA  системы
		Dim Semaphore As String ' Флаг при создании письма
		Dim AreaDef As String 'Netmail area
		'~~~~~~~~~~~~~~~~~
		
		Dim tmp As String
		Dim ff As Integer
		Dim sta, stp As Integer
		Dim m, n, i As Integer
		
		ff = FreeFile
		FileOpen(ff, gdPath, OpenMode.Input)
		While Not EOF(ff)
			tmp = LineInput(ff)
			
			If Mid(tmp, 1, 1) <> ";" Then
				sta = InStr(1, tmp, "USERNAME ", CompareMethod.Text)
				
				If sta <> 0 Then
					sta = 9 : stp = 1
					While Mid(tmp, stp, 1) <> ";" And stp < Len(tmp)
						stp = stp + 1
					End While
					ReDim Preserve UserName(n)
					UserName(n) = Trim(Mid(tmp, sta, stp + 1))
					n = n + 1
				End If 'username
				
				sta = InStr(1, tmp, "ADDRESS ", CompareMethod.Text)
				
				If sta <> 0 Then
					sta = InStr(1, tmp, ":", CompareMethod.Text)
					stp = InStr(sta, tmp, " ", CompareMethod.Text)
					
					If stp = 0 Then stp = Len(tmp)
					While Mid(tmp, sta, 1) <> " "
						sta = sta - 1
					End While
					Address = Mid(tmp, sta + 1, stp - sta + 1)
				End If 'address
				
				sta = InStr(1, tmp, "AKA ", CompareMethod.Text)
				
				If sta <> 0 Then
					sta = 4 : stp = 1
					While Mid(tmp, stp, 1) <> ";" And stp < Len(tmp)
						stp = stp + 1
					End While
					
					If InStr(1, tmp, "AKA ", CompareMethod.Text) < 3 Then
						ReDim Preserve AKA(m)
						AKA(m) = Trim(Mid(tmp, sta, stp + 1))
						m = m + 1
					End If
				End If 'aka
				
				sta = InStr(1, tmp, "Semaphore ECHOSCAN ", CompareMethod.Text)
				
				If sta <> 0 Then
					sta = 19
					stp = 1
					While Mid(tmp, stp, 1) <> ";" And stp < Len(tmp)
						stp = stp + 1
					End While
					Semaphore = Trim(Mid(tmp, sta, stp - sta))
				End If 'Semaphore
				
				sta = InStr(1, tmp, "AREADEF NETMAIL ", CompareMethod.Text)
				
				If sta <> 0 Then
					sta = 16
					stp = 1
					While Mid(tmp, stp, 1) <> ";" And stp <= Len(tmp)
						stp = stp + 1
					End While
					AreaDef = Mid(tmp, sta + 1, stp - sta - 1)
				End If 'areadef
				
			End If '<>";"
			
		End While
		FileClose(ff)
		
		'username
		For i = 0 To UBound(UserName)
			PutGFEOption("Options", "UserName" & i, UserName(i))
		Next 
		
		'address
		PutGFEOption("Options", "MainAddress", Address)
		
		'aka
		For i = 0 To UBound(AKA)
			PutGFEOption("Options", "AkA" & i, AKA(i))
		Next 
		
		'Semaphore
		PutGFEOption("Options", "Semaphore", Semaphore)
		'areadef
		'PutGFEOption "Options", "areadef" & i, AreaDef
		
		'ставим флажок что унастройки импортированы
		PutGFEOption("Options", "Imported", CStr(1))
		'okay use gotovo
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 53
				MsgBox("Import Error!" & vbCrLf & "File " & gdPath & " not Found!", MsgBoxStyle.Exclamation, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				Exit Sub
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "modCommon::ImportCfg")
		End Select
		
	End Sub
	
	'десятично-двоичное переобразование
	Public Function dec2bin(ByRef dec As Integer) As String
		Dim tmp As Integer
		
		If dec = 0 Then
			dec2bin = "0"
			Exit Function
		End If
		
		While dec > 0
			tmp = dec \ 2
			dec2bin = dec - tmp * 2 & dec2bin
			dec = tmp
		End While
		
	End Function
	
	'двоично-десятичное переобразование
	Public Function bin2dec(ByRef bin As String) As Integer
		Dim tmp, i As Integer
		
		If Len(bin) = 0 Then
			bin2dec = 0
			Exit Function
		End If
		
		tmp = CInt(Mid(bin, 1, 1))
		i = 2
		While i <= Len(bin)
			tmp = tmp * 2 + CShort(Mid(bin, i, 1))
			i = i + 1
		End While
		bin2dec = tmp
		
	End Function
	
	'UPGRADE_NOTE: hex was upgraded to hex_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Public Function hex2dec(ByRef hex_Renamed As String) As Integer
		hex2dec = CInt("&H" & hex_Renamed)
	End Function
	
	Public Sub ViewMail(ByRef bd As Object, ByRef numm As Integer, Optional ByRef Mode As ReplayMode = ReplayMode.ViewMails)
		On Error GoTo errHandler
		
		With TransferMessage
			.Mode = Mode 'mode=1 - replay
			.base = bd
			.CurrentMail = numm
		End With
		
		'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.DBName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If Len(TransferMessage.base.DBName) <> 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.rToAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_WARNING: Couldn't resolve default property of object bd.FromAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			TransferMessage.base.rToAddr = bd.FromAddr
			frmMailEditor.DefInstance.Show()
		End If
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "modCommon::ViewMail")
		End Select
		
	End Sub
	
	'Функция формирует строку now playing and uptime
	Public Function getNP() As String
		On Error GoTo errHandler
		Dim hWnd, r As Integer
		Dim np, tmp As String
		Dim nowt As Integer
		Dim hh, ss, mm, dd As Single
		
		hWnd = FindWindow("Winamp v1.x", vbNullString)
		
		If hWnd <> 0 And CInt(GetGFEOption("Options", "NpEnabled", "0")) = 1 Then
			'винамп нашелси
			np = Space(255)
			r = GetWindowText(hWnd, np, 255)
			np = Mid(np, 1, r)
			
			If Mid(np, Len(np) - 3, 4) > "A" Then
				If InStr(1, np, "[Stopped]", CompareMethod.Text) = 0 Then
					np = Mid(np, InStr(1, np, ".") + 2, InStr(InStr(1, np, ".") + 2, np, "Winamp") - 8) 'подкрутить чтобы была только песня без номера
				Else
					np = GetGFEOption("Options", "Stopped", "Winamp Stopped")
					np = ""
					
					If Len(np) = 0 Then np = "Winamp [Stoped]"
				End If
				
			Else
				np = GetGFEOption("Options", "Stopped", "Winamp Stopped")
				np = ""
				
				If Len(np) = 0 Then np = "Winamp [Stoped]"
			End If ' > "A"
		End If
		
		tmp = GetGFEOption("Options", "NpPrefix", "np:")
		
		If Len(tmp) = 0 Then tmp = "np:"
		np = tmp & " " & np & " " ' Adding "np: blah-blah"
		tmp = ""
		
		tmp = GetGFEOption("Options", "Uptime", "Uptime:")
		
		If Len(tmp) = 0 Then tmp = "uptime:"
		'get uptime system
		nowt = GetTickCount
		ss = nowt / 1000 'number of seconds
		hh = ss / 3600 'number of hours
		mm = Int((hh - Int(hh)) * 60) 'number of minutes
		ss = System.Math.Abs(Int((mm - ((hh - Int(hh)) * 60)) * 60))
		hh = Int(hh)
		dd = hh / 24 ' number of days
		hh = Int((dd - Int(dd)) * 24)
		dd = Int(dd)
		
		If hWnd = 0 And CInt(GetGFEOption("Options", "UptimeEnabled", "1")) <> 0 Then
			'винамп не нашелси
			np = GetGFEOption("Options", "NotLoading", "Winamp Not Found!") & " "
		End If
		
		If CInt(GetGFEOption("Options", "NpEnabled", "0")) = 1 Then
			np = np & tmp & " " & dd & " days " & hh & ":" & mm & ":" & ss ' Adding "np: blah-blah uptime blah blah "
		Else
			np = ""
		End If
		
		getNP = np
		Exit Function
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "modCommon::getNP")
		End Select
		
	End Function
	
	'Перекодировка текста.
	'UPGRADE_NOTE: Char was upgraded to Char_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Public Function ReCode(ByRef Char_Renamed As String, ByRef Src As code, ByRef Dest As code) As String
		Const wDos As String = "°±Ііґµ¶·ё№є»јЅѕїАБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧрЩЪЫЬЭЮЯтуфхцчшщсыьэюяШъЂЃ‚ѓ„…†‡€‰Љ‹ЊЌЋЏђ‘’“”•–—™љ›њќћџ ЎўЈ¤Ґ¦§Ё©Є«¬­®Їабвгдежзийклмноп"
		Const wIso As String = "°±Ііґµ¶·ё№є»јЅѕїАБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧўЩЪЫЬЭЮЯтуфхцчшщсыьэюяШъ°±Ііґµ¶·ё№є»јЅѕїАБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдежзийклмноп"
		Const wKoi As String = "ђ‘’Ѓ‡Іґ§¦µЎЁ®­¬ѓ„‰€†ЂЉЇ°«Ґ»ё± ѕ№є¶·Є©ў¤Ѕі…‚ЌЊЋЏ‹™“›џ—њћЈ–љќ”їј•бвчздецъйклмнопртуфхжигюыэящшьасБВЧЗДЕЦЪЙКЛМНОПРТУФХЖИГЮЫЭЯЩШЬАС"
		Const wWin As String = "ЂЃ‚ѓ„…†‡€‰Љ‹ЊЌЋЏђ‘’“”•–—™љ›њќћџ ЎўЈ¤Ґ¦§Ё©Є«¬­®Ї°±Ііґµ¶·ё№є»јЅѕїАБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдежзийклмнопрстуфхцчшщъыьэюя"
		Const NotRecodedChar As String = "?"
		
		If Src = Dest Then
			ReCode = Char_Renamed
			Exit Function
		End If
		
		Dim ss, t, tt, ch As String
		Dim i, a As Integer
		
		If Src = code.Win Then
			t = Char_Renamed
		Else
			
			Select Case Src
				
				Case code.Koi : ss = wKoi
					
				Case code.Dos : ss = wDos
					
				Case code.Iso : ss = wIso
			End Select
			
			For i = 1 To Len(Char_Renamed)
				ch = Mid(Char_Renamed, i, 1)
				
				If Asc(ch) < 128 Then
					t = t & ch
				Else
					a = InStr(1, ss, ch, CompareMethod.Binary)
					
					If a = 0 Then
						t = t & NotRecodedChar
					Else
						t = t & Mid(wWin, a, 1)
					End If
				End If
				
			Next i
			
		End If
		
		If Dest = code.Win Then
			ReCode = t
		Else
			
			Select Case Dest
				
				Case code.Koi : ss = wKoi
					
				Case code.Dos : ss = wDos
					
				Case code.Iso : ss = wIso
			End Select
			
			For i = 1 To Len(Char_Renamed)
				ch = Mid(t, i, 1)
				
				If Asc(ch) < 128 Then
					tt = tt & ch
				Else
					a = InStr(1, wWin, ch, CompareMethod.Binary)
					
					If a = 0 Then
						tt = tt & NotRecodedChar
					Else
						tt = tt & Mid(ss, a, 1)
					End If
				End If
				
			Next i
			
			ReCode = tt
		End If
		
	End Function
	
	Private Sub ShellSort(ByRef vArray As Object)
		Dim TempVal As Object
		Dim GapSize, i, CurPos As Integer
		Dim LastRow, FirstRow, NumRows As Integer
		FirstRow = LBound(vArray)
		LastRow = UBound(vArray)
		NumRows = LastRow - FirstRow + 1
		
		Do 
			GapSize = GapSize * 3 + 1
		Loop Until GapSize > NumRows
		
		Do 
			GapSize = GapSize \ 3
			
			For i = (GapSize + FirstRow) To LastRow
				CurPos = i
				'UPGRADE_WARNING: Couldn't resolve default property of object vArray(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				'UPGRADE_WARNING: Couldn't resolve default property of object TempVal. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				TempVal = vArray(i)
				
				Do While CompareResult(vArray(CurPos - GapSize), TempVal)
					'UPGRADE_WARNING: Couldn't resolve default property of object vArray(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					vArray(CurPos) = vArray(CurPos - GapSize)
					CurPos = CurPos - GapSize
					
					If (CurPos - GapSize) < FirstRow Then Exit Do
				Loop 
				
				'UPGRADE_WARNING: Couldn't resolve default property of object TempVal. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				'UPGRADE_WARNING: Couldn't resolve default property of object vArray(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				vArray(CurPos) = TempVal
			Next 
			
		Loop Until GapSize = 1
		
	End Sub
	
	Private Function CompareResult(ByRef Value1 As Object, ByRef Value2 As Object) As Boolean
		'UPGRADE_WARNING: Couldn't resolve default property of object Value2. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Value1. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		CompareResult = (Value1 > Value2)
	End Function
	
	Public Sub CustomDoEvents(Optional ByRef hWnd As Integer = 0)
		Dim pmsg As msg
		
		If PeekMessage(pmsg, hWnd, 0, 0, PM_NOYIELD Or PM_NOREMOVE) <> 0 Then
			
			System.Windows.Forms.Application.DoEvents()
		End If
		
	End Sub
	
	'Возвращает True если файл существует
	Public Function FileExists(ByRef FileName As String) As Boolean
		On Error Resume Next
		Dim ff As Integer
		
		ff = FreeFile
		FileOpen(ff, FileName, OpenMode.Input)
		
		If Err.Number <> 0 Then
			FileExists = False
			Exit Function
		End If
		
		FileClose(ff)
		
		FileExists = True
		
	End Function
	
	'Напечатать содержимое RichTextBox'a с отступами в 1 дюйм (1440 twips) от края листа
	Public Sub PrintRTF(ByRef rtf As AxRichTextLib.AxRichTextBox, Optional ByRef LeftMarginWidth As Integer = 1440, Optional ByRef TopMarginHeight As Integer = 1440, Optional ByRef RightMarginWidth As Integer = 1440, Optional ByRef BottomMarginHeight As Integer = 1440)
		Dim LeftMargin, LeftOffset, TopOffset, TopMargin As Integer
		Dim RightMargin, NextCharPosition, BottomMargin As Integer
		Dim rcDrawTo, rcPage As RECT
		Dim TextLength, NextCharPos As Integer
		Dim fr As FormatRange
		
		NextCharPos = 0
		
		'UPGRADE_ISSUE: Constant vbPRPQHigh was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
		'UPGRADE_ISSUE: Printer property Printer.PrintQuality was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		Printer.PrintQuality = vbPRPQHigh
		'UPGRADE_ISSUE: Constant vbTwips was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
		'UPGRADE_ISSUE: Printer property Printer.ScaleMode was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		Printer.ScaleMode = vbTwips
		
		'А тут мы определяем доступную область печати в твипах
		'UPGRADE_ISSUE: Printer property Printer.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		LeftOffset = GetDeviceCaps(Printer.hDC, PHYSICALOFFSETX) / GetDeviceCaps(Printer.hDC, LOGPIXELSX) * 1440
		'UPGRADE_ISSUE: Printer property Printer.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		TopOffset = GetDeviceCaps(Printer.hDC, PHYSICALOFFSETY) / GetDeviceCaps(Printer.hDC, LOGPIXELSY) * 1440
		
		'Считаем левый, верхний, правый и нижний отступы
		LeftMargin = LeftMarginWidth - LeftOffset
		TopMargin = TopMarginHeight - TopOffset
		'UPGRADE_ISSUE: Printer property Printer.Width was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		RightMargin = (Printer.Width - RightMarginWidth) - LeftOffset
		'UPGRADE_ISSUE: Printer property Printer.Height was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		BottomMargin = (Printer.Height - BottomMarginHeight) - TopOffset
		
		'Устанавливаем область печати на одной странице
		rcPage.Left_Renamed = 0
		rcPage.Top = 0
		'UPGRADE_ISSUE: Printer property Printer.ScaleWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		rcPage.Right_Renamed = Printer.ScaleWidth
		'UPGRADE_ISSUE: Printer property Printer.ScaleHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		rcPage.Bottom = Printer.ScaleHeight
		
		'Устанавливаем область на которой мы будем печатать.
		'Это уже относится к области печати.
		rcDrawTo.Left_Renamed = LeftMargin
		rcDrawTo.Top = TopMargin
		rcDrawTo.Right_Renamed = RightMargin
		rcDrawTo.Bottom = BottomMargin
		
		'Считаем сколько нам печатать текста
		TextLength = Len(rtf.Text)
		
		'Дальше мы печатаем каждую страницу в документе, пока не прекратился весь текст
		Do 
			' Set up the print instructions
			'UPGRADE_ISSUE: Printer property Printer.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
			fr.hdc = Printer.hDC ' Use the same DC for measuring and rendering
			'UPGRADE_ISSUE: Printer property Printer.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
			fr.hdcTarget = Printer.hDC ' Point at Printer hDC
			fr.chrg.cpMin = NextCharPos ' Вычисляем начало печати
			fr.chrg.cpMax = -1 ' и конец печати
			'UPGRADE_WARNING: Couldn't resolve default property of object fr.rc. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			fr.rc = rcDrawTo ' Indicate the area on page to draw to
			'UPGRADE_WARNING: Couldn't resolve default property of object fr.rcPage. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			fr.rcPage = rcPage ' Indicate entire size of page
			'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2068"'
			'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
			Printer.Print(Space(1)) ' Определяем заново hDC
			
			'Печатем при помощи посылки EM_FORMATRANGE сообщения
			'UPGRADE_WARNING: Couldn't resolve default property of object fr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			NextCharPosition = SendMessage(rtf.hWnd, EM_FORMATRANGE, True, fr)
			
			'Если все сделано, то выходим
			If NextCharPos <= 0 Or NextCharPos >= TextLength Then Exit Do
			' Переключаемся на следующую страницу
			'UPGRADE_ISSUE: Printer method Printer.NewPage was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
			Printer.NewPage()
		Loop 
		
		'Завершаем печать
		'UPGRADE_ISSUE: Printer method Printer.EndDoc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		Printer.EndDoc()
		SendMessage(rtf.hWnd, EM_FORMATRANGE, False, CInt(0))
		
	End Sub
	
	Public Function GetGFEOption(ByRef OptionPath As String, ByRef OptionName As String, Optional ByRef DefaultValue As String = vbNullString) As String
		GetGFEOption = Registry.GetString(HKEY_CURRENT_USER, "SOFTWARE\GFE\" & OptionPath, OptionName, DefaultValue)
	End Function
	
	Public Sub PutGFEOption(ByRef OptionPath As String, ByRef OptionName As String, ByRef Value As String)
		Registry.SaveString(HKEY_CURRENT_USER, "SOFTWARE\GFE\" & OptionPath, OptionName, Value)
	End Sub
	
	'TODO: Сделать проверку по модулям. в update.txt построчно - "modulename|size|build|date|md5"
	'а вообще надо сделать нормальный "апдейтер"
	Public Sub CheckUpdate()
		On Error GoTo errHandler
		
		Dim ff As Integer
		Dim uBuild, uDate, tmpPath As String
		Const gfeUpdateInf As String = "http://gfe.h10.ru/downloads/update.txt"
		Const gfeUpdate As String = "http://gfe.h10.ru/downloads/gfe.lite.rar"
		
		'перекачиваем апдейтовый файл
		tmpPath = VB6.GetPath & "\tmp"
		
		MkDir(tmpPath)
		Kill(tmpPath & "\*")
		
		If URLDownloadToFile(Nothing, gfeUpdateInf, VB6.GetPath & "\update.txt", 0, 0) <> 0 Then
			MsgBox("Ошибка закачки файла: " & gfeUpdateInf, MsgBoxStyle.Critical, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
			Exit Sub
		End If
		
		ff = FreeFile
		FileOpen(ff, tmpPath & "\update.txt", OpenMode.Input, OpenAccess.Read)
		uDate = LineInput(ff)
		uBuild = LineInput(ff)
		FileClose(ff)
		
		'TODO: заменить на более красивую проверку - как вариант больше/меньше
		'UPGRADE_ISSUE: App property App.Revision was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		If uBuild <> (System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMajorPart & "." & System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMinorPart & "." & App.Revision) Then
			If MsgBox("Доступно обновление - билд: " & uBuild & " от " & uDate & vbCrLf & "Закачать?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name) = MsgBoxResult.Yes Then
				If URLDownloadToFile(Nothing, gfeUpdate, tmpPath & "\gfe.lite.rar", 0, 0) <> 0 Then
					MsgBox("Ошибка закачки файла: " & gfeUpdate, MsgBoxStyle.Critical, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
					Exit Sub
				End If
				
				MsgBox("Скачено успешно в " & tmpPath & "\gfe.lite.rar", MsgBoxStyle.Information, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				'TODO: распаковку и замену.
				
			Else
				Exit Sub
			End If
			
		Else
			MsgBox("Обновлений нет.", MsgBoxStyle.Information, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
			
		End If
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 53, 75
				Resume Next
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "modCommon::CheckUpdate")
				
		End Select
		
	End Sub
End Module