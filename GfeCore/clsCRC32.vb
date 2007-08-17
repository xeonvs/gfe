Option Strict Off
Option Explicit On

Imports System.Text

Public Class clsCRC32

    Private CRCTable(255) As Integer

    Public Sub New()
        MyBase.New()
        Dim Ind, Ind2 As Integer
        Dim CRC, Bit As Integer

        Const Polynomial As Integer = &HEDB88320

        For Ind = 0 To 255
            CRC = Ind

            For Ind2 = 0 To 7
                Bit = CRC And &H1S
                CRC = ((CRC And &HFFFFFFFE) \ &H2S) And &H7FFFFFFF

                If Bit = &H1S Then CRC = CRC Xor Polynomial
            Next Ind2

            CRCTable(Ind) = CRC
        Next Ind
    End Sub

    Private Function AddCRC(ByRef ByteAry() As Byte, ByVal CRC As Integer) As Integer

        Dim Ind As Integer

        For Ind = 0 To UBound(ByteAry)
            CRC = (((CRC And &HFFFFFF00) \ &H100S) And &HFFFFFF) Xor CRCTable((CRC And &HFFS) Xor ByteAry(Ind))
        Next Ind

        Return CRC

    End Function

    Public Function InvertCRC(ByVal CRC As Integer) As Integer

        CRC = CRC Xor &HFFFFFFFF

        Return CRC

    End Function

    Public Function GetStringCRC32(ByRef str As String) As Integer
        Dim CRC As Integer
        Dim BAry() As Byte

        BAry = System.Text.UnicodeEncoding.Unicode.GetBytes(str)
        CRC = AddCRC(BAry, &HFFFFFFFF)
        CRC = InvertCRC(CRC)

        Return CRC

    End Function

    Public Sub StringToByteArray(ByVal StringIn As String, ByRef ByteArray() As Byte)
        If Len(StringIn) = 0 Then Exit Sub
        ByteArray = Encoding.Default.GetBytes(StringIn)
    End Sub

    Public Sub ByteArrayToString(ByRef ByteArray() As Byte, ByRef StringOut As String)
        If LBound(ByteArray) > 0 Then Exit Sub 'lBound MUST be 0

        StringOut = Encoding.Default.GetString(ByteArray)

    End Sub
End Class