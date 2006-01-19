Option Strict Off
Option Explicit On
Friend Class clsCRC32
	
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Private Declare Sub RtlMoveMemory Lib "kernel32.dll" (ByRef dst As Any, ByRef Src As Any, ByVal cb As Integer)
	
	Dim CRCTable(255) As Integer
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Private Sub Class_Initialize_Renamed()
		Dim Ind, Ind2 As Integer
		Dim CRC, Bit As Integer
		
		Const Polynomial As Integer = &HEDB88320
		
		For Ind = 0 To 255
			CRC = Ind
			
			For Ind2 = 0 To 7
				Bit = CRC And &H1s
				CRC = ((CRC And &HFFFFFFFE) \ &H2s) And &H7FFFFFFF
				
				If Bit = &H1s Then CRC = CRC Xor Polynomial
			Next Ind2
			
			CRCTable(Ind) = CRC
		Next Ind
		
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
	
	Private Function AddCRC(ByRef ByteAry() As Byte, ByVal CRC As Integer) As Integer
		
		Dim Ind As Integer
		
		For Ind = 0 To UBound(ByteAry)
			CRC = (((CRC And &HFFFFFF00) \ &H100s) And &HFFFFFF) Xor CRCTable((CRC And &HFFs) Xor ByteAry(Ind))
		Next Ind
		
		AddCRC = CRC
		
	End Function
	
	Public Function InvertCRC(ByVal CRC As Integer) As Integer
		
		CRC = CRC Xor &HFFFFFFFF
		InvertCRC = CRC
		
	End Function
	
	'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Public Function GetStringCRC32(ByRef str_Renamed As String) As Integer
		Dim CRC As Integer
		Dim BAry() As Byte
		
		'UPGRADE_TODO: Code was upgraded to use System.Text.UnicodeEncoding.Unicode.GetBytes() which may not have the same behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1059"'
		BAry = System.Text.UnicodeEncoding.Unicode.GetBytes(str_Renamed)
		CRC = AddCRC(BAry, &HFFFFFFFF)
		CRC = InvertCRC(CRC)
		GetStringCRC32 = CRC
		
	End Function
	
	'Converts a string to an array of bytes. Just like Asc() on every character.
	Public Sub StringToByteArray(ByVal StringIn As String, ByRef ByteArray() As Byte)
		Dim lBytes As Integer
		
		If Len(StringIn) = 0 Then Exit Sub
		lBytes = Len(StringIn)
		ReDim ByteArray(lBytes - 1)
		
		RtlMoveMemory(ByteArray(0), StringIn, lBytes)
		
	End Sub
	
	'Converts an array of bytes to a string.
	Public Sub ByteArrayToString(ByRef ByteArray() As Byte, ByRef StringOut As String)
		Dim lBytes As Integer
		
		If LBound(ByteArray) > 0 Then Exit Sub 'lBound MUST be 0
		lBytes = UBound(ByteArray) + 1
		StringOut = New String(Chr(0), lBytes)
		
		RtlMoveMemory(StringOut, ByteArray(0), lBytes)
		
	End Sub
End Class