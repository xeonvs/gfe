Option Strict Off
Option Explicit On
Module modErrors
	
	Public Declare Function GetLastError Lib "kernel32" () As Integer
	
	Private Const FORMAT_MESSAGE_ALLOCATE_BUFFER As Integer = &H100s
	Private Const FORMAT_MESSAGE_FROM_SYSTEM As Integer = &H1000s
	Private Const LANG_NEUTRAL As Integer = &H0s
	Private Const SUBLANG_DEFAULT As Integer = &H1s
	Private Declare Sub SetLastError Lib "kernel32" (ByVal dwErrCode As Integer)
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Private Declare Function FormatMessage Lib "kernel32"  Alias "FormatMessageA"(ByVal dwFlags As Integer, ByRef lpSource As Any, ByVal dwMessageId As Integer, ByVal dwLanguageId As Integer, ByVal lpBuffer As String, ByVal nSize As Integer, ByRef Arguments As Integer) As Integer
	
	Public Sub ApiErrorLookup(ByRef ErrorCode As Integer, ByRef Location As String)
		Dim Buffer, retStr As String
		
		If Not IsNumeric(ErrorCode) Or ErrorCode = 0 Then Exit Sub 'пусть будет на всякий случай
		
		Buffer = New String(Chr(0), 200)
		
		SetLastError(ErrorCode)
		FormatMessage(FORMAT_MESSAGE_FROM_SYSTEM, 0, GetLastError, LANG_NEUTRAL, Buffer, 200, 0)
		
		Buffer = Left(Buffer, InStr(1, Buffer, Chr(0)) - 1)
		If Len(Buffer) = 0 Then
			Buffer = "There is no error description for this code. Refer to msdn.microsoft.com to know what it means."
		End If
		
		retStr = "Error #" & ErrorCode & " in " & Location & vbCrLf & "Description: " & Buffer
		
		MsgBox(retStr, MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
		
		
	End Sub
	
	Public Sub ErrorMessage(ByRef ErrNumber As Integer, ByRef Description As String, ByRef Where As String, Optional ByRef Coment As String = "")
		LockWindowUpdate(0)
		If Len(Coment) <> 0 Then
			MsgBox("Error #" & ErrNumber & vbCrLf & "Location: " & Where & vbCrLf & "Description: " & Description & vbCrLf & "Info: " & Coment, MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
		Else
			MsgBox("Error #" & ErrNumber & vbCrLf & "Location: " & Where & vbCrLf & "Description: " & Description, MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
		End If
	End Sub
End Module