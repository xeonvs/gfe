Option Strict Off
Option Explicit On
Module modPlugins
	
	Public Plugins() As Object 'Глобальный массив плугинов
	
	'----Функции для реализации работы с плугинами----
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Private Declare Function CreateThread Lib "kernel32" (ByRef anyThread As Any, ByVal lngSize As Integer, ByVal lngStart As Integer, ByVal lngValue As Integer, ByVal lngFlags As Integer, ByRef lngThread As Integer) As Integer
	
	Private Declare Function LoadLibraryA Lib "kernel32" (ByVal strName As String) As Integer
	
	Private Declare Function GetProcAddress Lib "kernel32" (ByVal lngModule As Integer, ByVal strName As String) As Integer
	
	Private Declare Function FreeLibrary Lib "kernel32" (ByVal lngModule As Integer) As Integer
	
	Private Declare Function CloseHandle Lib "kernel32" (ByVal lngHandle As Integer) As Integer
	
	Private Declare Function WaitForSingleObject Lib "kernel32" (ByVal lngHandle As Integer, ByVal lngTime As Integer) As Integer
	'------------
	
	'Регистрация плугинов
	Public Function RegPlugin(ByVal strReg As String, ByVal lngLoad As Integer) As Integer
		On Error GoTo errHandler
		
		GetAttr(strReg)
		
		RegPlugin = LoadLibraryA(strReg)
		lngLoad = CreateThread(0, 0, GetProcAddress(RegPlugin, IIf(lngLoad, "DllRegisterServer", "DllUnregisterServer")), 0, 0, 0)
		WaitForSingleObject(lngLoad, 10000)
		CloseHandle(lngLoad)
		FreeLibrary(RegPlugin)
		
		Exit Function
		
errHandler: 
		Select Case Err.Number
			Case 53
				MsgBox("RegPlugin Error!" & vbCrLf & "File " & strReg & " not Found!", MsgBoxStyle.Exclamation, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				Exit Function
			Case Else
				MsgBox("RegPlugin Error #" & Err.Number & vbCrLf & "Description: " & Err.Description, MsgBoxStyle.Critical, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
		End Select
	End Function
	
	'регистрирует все остальные плугины кроме AddrBook.dll
	Public Sub RegisterAllPlugins()
		On Error GoTo reg
		Dim strPlugin As String
		Dim pCnt As Integer
		
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		strPlugin = Dir(VB6.GetPath & "\Plugins\*.dll")
		
		While Len(strPlugin) <> 0
			If InStr(1, strPlugin, "AddrBook.dll", CompareMethod.Text) = 0 Then
				'UPGRADE_ISSUE: As Object was removed from ReDim Plugins(pCnt) statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1056"'
				ReDim Preserve Plugins(pCnt)
				Plugins(pCnt) = CreateObject(Left(strPlugin, Len(strPlugin) - 4) & ".clsPlugin")
				'UPGRADE_WARNING: Couldn't resolve default property of object Plugins().frmMainForm. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				Plugins(pCnt).frmMainForm = frmMain.DefInstance
				'UPGRADE_WARNING: Couldn't resolve default property of object Plugins().frmMailEditorForm. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				Plugins(pCnt).frmMailEditorForm = frmMailEditor.DefInstance
				pCnt = pCnt + 1
			End If
			'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			strPlugin = Dir()
		End While
		
		Exit Sub
		
reg: 
		Select Case Err.Number
			Case 429, -2147024770 'Если плагин не зарегистрирован - зарегистрируем!
				modPlugins.RegPlugin(VB6.GetPath & "\Plugins\" & strPlugin, True)
				Resume 
			Case Else
				MsgBox("RegPlugin Error #" & Err.Number & vbCrLf & "Description: " & Err.Description, MsgBoxStyle.Critical, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
		End Select
	End Sub
End Module