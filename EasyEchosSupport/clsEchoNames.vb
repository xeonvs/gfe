Option Strict Off
Option Explicit On

Imports System.Text

''' <summary>
''' ����� ��������������� ������ � ������ ��
''' </summary>
''' <remarks>� �������� ��� ���������������� � ��� ���. ���������� ���������� ��� ��������� � ����� ���������</remarks>
Public Class clsEchoNames
    Implements IDatabasesTypes

    '������������ dos to windows
    'Private Declare Auto Function OemToChar Lib "user32" ( _
    '                ByVal lpszSrc As String, ByVal lpszDst As String _
    ') As Integer

    '~~~~~~~~~Fastecho types
    Private Const EH_AKAS As Short = &H7S

    Private Structure ExtensionHeader
        Dim Type As Short '/* EH_...                           */
        <VBFixedString(4), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=4)> Public rr() As Char
        Dim Offset As Integer '/* length of field excluding header */
    End Structure

    Private Structure AkA
        Dim zone As Short
        Dim net As Short
        Dim node As Short
        Dim Point As Short
        <VBFixedString(28), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=28)> Public Domain() As Char
        Dim Pointnet As Short
        Dim flags As Integer '/* unused       */
    End Structure

    Private Structure Info
        Dim AkA As Byte     '* 0 ... CONFIG.AkaCnt                   */ ����� ��������� 8�� ���
        Dim Group As Byte   '* 0 ... CONFIG.GroupCnt                 */ ����� ��������� 8�� ���
    End Structure

    '������� ����
    Private Structure flags
        Dim Storage_aType As Byte   '����� ������ 4 ��� ��� Storage � ��������� 4pe ��� aType
        Dim Origin_resv As Byte     '* # of origin line ����� ������ 5�� ���, resv ���������
    End Structure

    Private Structure Area
        <VBFixedString(52), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=52)> Public Name() As Char
        Dim Board As Short      '* 1-200 Hudson, others reserved/special */
        Dim Conference As Short '* 0 ... CONFIG.MaxAreas-1               */
        Dim Read_sec As Short
        Dim Write_sec As Short
        Dim Info As Info
        Dim flags As flags
        Dim AdvFalgs As Short
        Dim resv1 As Short
        Dim Seenbys As Integer '* LSB = Aka0, MSB = Aka31           */
        Dim resv2 As Integer
        Dim Days As Short       'short
        Dim Messages As Short   'short
        Dim Recvdays As Short   'short
        <VBFixedString(56), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=56)> Public Path() As Char
        <VBFixedString(52), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst:=52)> Public Desc() As Char
    End Structure

    'fips
    Private Structure AreaRecord
        Dim Index As Int32 '���������� ����� ������� � ������ (��������)
        Dim StructLen As Int32 '����� ������ (������ ����� 562)
        Dim Status As Int32 '������ �������
        <VBFixedString(129)> Dim Description As String  '�������� �������
        <VBFixedString(101)> Dim Echotag As String   '�������� �������
        <VBFixedString(128)> Dim FileName As String '��� ����� ���������� � ����� ��� ����������
        Dim Lastread As Int32 '������ ���������� ������������ ������
        Dim Hheader As Int32 '��������� �� ���� ���������� (������������ �� ����� ������ ���������)
        Dim Hmessage As Int32 '��������� �� ���� ���� ����� (������������ �� ����� ������ ���������)
        <VBFixedString(21)> Dim AKA As String '��� ��� ��� ���� �������
        <VBFixedString(31)> Dim UpLink As String '��� ������ ��� ���� �������
        <VBFixedString(12)> Dim Group As String '������, � ������� ��������� ��� �������
        Dim Membership As Int32 '
        Dim PurgeAgeCreate As Int32 '������, ������������ �������� ��� ������
        Dim PurgeAgeRecipt As Int32
        Dim PurgeMaxNum As Int32
        Dim PurgeFlagCreate As Int32
        Dim PurgeFlagAgeRecipt As Int32
        Dim PurgeFlagNrmails As Int32
        Dim NumberOfMails As Int32 '����� ��������� � ���� ����� ���� �������
        Dim NumberOfAlreadyRead As Int32 '����� ��� ����������� ���������
        Dim LocalMail As Int32 '���� ���������������� �������
        Dim AdditionalDays As Int32 '�������������� ����� ���� ��� ������������� �����, ������������ �������� ��� �������������� ������ ����
        Dim AreaCreationDate As Int32  '���� �������� �������
        'OriginIndex As Byte '������ ��������
        <VBFixedString(68)> Shared NoName() As Char  '���������� ������������� ������
        '����� ����� ������ = 562        
    End Structure

    '~~~~~~~~~~~~~~~
    Private Structure EchoRefType
        Dim EName As String         '��� ���
        Dim EFile As String         '���� �� ���� � ��� ����� ����
        Dim Description As String   '�������� ���
        Dim GroupNum As Integer     '������
        Dim AkA As String           '��� ������������� ��� ��� �� ���������
        Dim EchoType As IDatabasesTypes.enmBaseType '��� ���
        Dim Uplink As String        '���� ���
        Dim Downlinks() As String   '��������� ��� ���
    End Structure

    Private EchoRefs() As EchoRefType
    Private EchoRefsCount As Integer

    Private TossersNames() As String    '��� ��������, ������ ��� Id �������
    Private strCfgName As String        '���� �������
    Private lngCurTosser As Integer     '�������� ������� ������
    Private enc As Encoding = Encoding.GetEncoding(866) '���������

    ''' <summary>
    ''' ����������� "�� ���������"
    ''' </summary>
    Public Sub New()
        MyBase.New()

        ReDim TossersNames(6)
        TossersNames(0) = "Areas.bbs"
        TossersNames(1) = "FastEcho 1.46.1"
        TossersNames(2) = "HPT 1.x"
        TossersNames(3) = "BBToss 2.50"
        TossersNames(4) = "FIPS"
        TossersNames(5) = "squish.cfg"
        TossersNames(6) = "DRIM Tosser"
        'end tossers

    End Sub
    ''' <summary>
    ''' ���������� ������ ����������.
    ''' </summary>
    Public ReadOnly Property About() As String
        Get
            Return "EasyEchosSupport " & CStr(My.Application.Info.Version.Major) & "." & CStr(My.Application.Info.Version.Minor) & " build " & CStr(My.Application.Info.Version.Revision)
        End Get
    End Property
    ''' <summary>
    ''' ��������/������������� ������� ���� ������������
    ''' </summary>
    Public Property ConfigFile() As String
        Get
            Return strCfgName
        End Get
        Set(ByVal Value As String)
            strCfgName = Value
        End Set
    End Property
    ''' <summary>
    ''' ���������� ��� ������� �� ��� Id
    ''' </summary>
    ''' <param name="id">����� �������</param>
    Public ReadOnly Property TosserName(ByVal id As Integer) As String
        Get

            If id >= 0 And id <= UBound(TossersNames) Then
                Return TossersNames(id)
            Else
                Return "-1"
            End If

        End Get
    End Property
    ''' <summary>
    ''' ���������� ���-�� �������������� ��������
    ''' </summary>
    Public ReadOnly Property TosserCount() As Integer
        Get
            Return UBound(TossersNames)
        End Get
    End Property
    ''' <summary>
    ''' ���������� Id ���������� ������� ��� ������� ������� ��������� �����������
    ''' </summary>
    ''' <param name="FileToAnalyze">���� ������������ � ������ �����</param>
    Public ReadOnly Property TosserHeuristicAnalyzer(ByVal FileToAnalyze As String) As Integer
        Get

            'not inplemented
            Select Case LCase(Mid(FileToAnalyze, Len(FileToAnalyze) - 2, 3))

                Case "bbs"
                    Return 0

                Case "cfg"
                    Return 1

                Case "con"
                    Return 2

                Case "ini"
                    Return 3

                Case "wwd"
                    Return 4

                Case Else

                    If InStr(1, FileToAnalyze, GfeCore.PatchSeparator & "hpt", CompareMethod.Text) <> 0 Then
                        Return 2
                    ElseIf InStr(1, FileToAnalyze, GfeCore.PatchSeparator & "bbt", CompareMethod.Text) <> 0 Then
                        Return 3
                    Else
                        Return 0
                    End If

            End Select

        End Get
    End Property

    ''' <summary>
    ''' ���������� Id �������� ������� �������
    ''' </summary>
    Public ReadOnly Property CurrentTosserType() As String
        Get
            Return TossersNames(lngCurTosser)
        End Get
    End Property
    '-------------------

    ''' <summary>
    ''' ���������� ���-�� ��
    ''' </summary>
    ''' <remarks>����� ��� ������ �� ����� :(</remarks>
    Public ReadOnly Property EchosCount() As Integer
        Get
            Return EchoRefsCount
        End Get
    End Property
    ''' <summary>
    ''' ����������� ������ ���� � ���� ���������� �������������� �� �� �����
    ''' </summary>
    ''' <param name="EchoName">��� ���</param>
    Public ReadOnly Property GetEchoFileByName(ByVal EchoName As String) As String
        Get
            Dim i As Integer

            For i = 1 To EchoRefsCount

                If EchoName = EchoRefs(i).EName Then
                    Return EchoRefs(i).EFile                    
                End If

            Next i

            Return vbNullString
        End Get
    End Property
    ''' <summary>
    ''' ����������� ������ ���� � ���� � �������������� �� �� ������
    ''' </summary>
    ''' <param name="Number">���������� ����� ���</param>
    ''' <remarks>� ������ ������ ��� ���������� �����, � �� ����� � �������</remarks>
    Public ReadOnly Property GetEchoFileByNum(ByVal Number As Integer) As String
        Get

            If Number > 0 And Number <= EchoRefsCount Then
                Return EchoRefs(Number).EFile
            Else
                Return vbNullString
            End If

        End Get
    End Property
    ''' <summary>
    ''' ����������� ������ ���� � ���� � �������������� �� �� ������
    ''' </summary>
    ''' <param name="Number">���������� ����� ���</param>
    ''' <remarks>��� GetEchoFileByNum</remarks>
    Public ReadOnly Property GetEchoNameByNum(ByVal Number As Integer) As String
        Get

            If Number > 0 And Number <= EchoRefsCount Then
                Return EchoRefs(Number).EName
            Else
                Return vbNullString
            End If

        End Get
    End Property
    ''' <summary>
    ''' ����������� �������� �� ������ ���
    ''' </summary>
    ''' <param name="Number">���������� ����� ���</param>
    ''' <remarks>��. GetEchoFileByNum</remarks>
    Public ReadOnly Property GetEchoDescriptionByNum(ByVal Number As Integer) As String
        Get

            If Number > 0 And Number <= EchoRefsCount Then
                If GfeCore.bRecodeDesc Then
                    Return Encoding.GetEncoding(866).GetString(Encoding.Default.GetBytes(EchoRefs(Number).Description))
                Else
                    Return EchoRefs(Number).Description
                End If
            Else
                Return vbNullString
            End If

        End Get
    End Property
    ''' <summary>
    ''' ���������� ������ ��� �� �� ������
    ''' </summary>
    ''' <value>���������� ����� ������</value>
    ''' <remarks>������ ����������</remarks>
    Public ReadOnly Property GetEchoGroupByNum(ByVal Number As Integer) As Integer
        Get

            If Number > 0 And Number <= EchoRefsCount Then
                Return EchoRefs(Number).GroupNum
            Else
                Return -1
            End If

        End Get
    End Property
    ''' <summary>
    ''' ����������� aka �� ������ ���
    ''' </summary>
    ''' <param name="Number">���������� ����� ���</param>
    ''' <remarks>��� GetEchoFileByNum</remarks>
    Public ReadOnly Property GetEchoAkAByNum(ByVal Number As Integer) As String
        Get

            If Number > 0 And Number <= EchoRefsCount Then
                Return EchoRefs(Number).AkA
            Else
                Return vbNullString
            End If

        End Get
    End Property
    ''' <summary>
    ''' ����������� ��� ��� �� ������    
    ''' </summary>
    ''' <param name="Number">���������� ����� ���</param>
    ''' <value>��� ���� ������ ������������ � IDatabasesTypes</value>
    ''' <remarks>��� GetEchoFileByNum</remarks>
    Public ReadOnly Property GetEchoTypeByNum(ByVal Number As Integer) As IDatabasesTypes.enmBaseType
        Get

            If Number > 0 And Number <= EchoRefsCount Then
                Return EchoRefs(Number).EchoType
            Else
                Return IDatabasesTypes.enmBaseType.Unknown
            End If

        End Get
    End Property
    ''' <summary>
    ''' ���������� ����� ��� �� �� �����
    ''' </summary>
    ''' <param name="EchoName">����������������� ��� ���</param>
    ''' <value>����������� �����</value>
    ''' <remarks>��� GetEchoFileByNum</remarks>
    Public ReadOnly Property GetEchoNumByName(ByVal EchoName As String) As Integer
        Get
            Dim i As Integer

            For i = 1 To EchoRefsCount

                If EchoName = EchoRefs(i).EName Then
                    Return i                    
                End If

            Next i

            '� ������ ������� ���������� -1
            Return -1
        End Get
    End Property
    ''' <summary>
    ''' ���������� ������� ��� ��� �� ������
    ''' </summary>
    ''' <param name="Number">���������� ����� ���</param>
    ''' <value>����� �������</value>
    ''' <remarks>��� GetEchoFileByNum</remarks>
    Public ReadOnly Property GetEchoUplinkByNum(ByVal Number As Integer) As String
        Get

            If Number > 0 And Number <= EchoRefsCount Then
                Return EchoRefs(Number).Uplink
            End If

            Return vbNullString

        End Get
    End Property
    ''' <summary>
    ''' ���������� ���� ����������� ������ ���
    ''' </summary>
    ''' <param name="Number">���������� ����� ���</param>
    ''' <value>������ � �������� ����������� ������������ crlf</value>
    ''' <remarks>��� GetEchoFileByNum</remarks>
    Public ReadOnly Property GetEchoDownlinksByNum(ByVal Number As Integer) As String
        Get

            If Number > 0 And Number <= EchoRefsCount Then
                Return Join(EchoRefs(Number).Downlinks, vbCrLf)
            End If

            Return vbNullString

        End Get
    End Property

    ''''''''''''
    '����������
    ''''''''''''

    ''' <summary>
    ''' ��������� �����, ������ ������ � ������������� ���������� ���������.
    ''' </summary>    
    Public Sub ParseConfig()
        Dim tid As String = String.Empty
        '������� ���� � ����������� ���������.
        ReadRegistry(My.Computer.Registry.CurrentUser, "SOFTWARE\GFE\Options", "TosserId", tid, "unknown")
        Select Case CShort(tid)

            Case 0
                ReadAreasBBS()
                lngCurTosser = 0

            Case 1
                ReadFastechoCfg()
                lngCurTosser = 1

            Case 2
                ReadHPTCfg()
                lngCurTosser = 2

            Case 3
                ReadBBTossCfg()
                lngCurTosser = 3

            Case 4
                ReadFIPSCfg()
                lngCurTosser = 4

            Case 5
                ReadSQUISHCfg()
                lngCurTosser = 5

            Case 6
                ReadDRIMCfg()
                lngCurTosser = 6

            Case Else
                MsgBox("������ � ��������� �������" & vbCrLf & "HCU\SOFTWARE\GFE\Options\TosserId" & vbCrLf & "��������� ��������� ���� �������������.", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, My.Application.Info.Title)
        End Select

        SortEchoByGroup() '������ �������� ����� �������� ��� ������� ����� ��.

    End Sub

    ''' <summary>
    ''' ��������� � ���������
    ''' </summary>
    ''' <param name="ec"></param>
    Private Sub AddEchoToList(ByRef ec As EchoRefType)
        EchoRefsCount = EchoRefsCount + 1
        ReDim Preserve EchoRefs(EchoRefsCount)
        EchoRefs(EchoRefsCount) = ec
    End Sub

    ''' <summary>
    ''' ������ ������ �� �� ������������ ����� Areas.bbs
    ''' </summary>
    Private Sub ReadAreasBBS()
        On Error GoTo errHandler
        Dim bbsFile As String
        Dim j, i, ff As Integer
        Dim rows() As String
        Dim cols() As String ' ������ � �������
        Dim ec As EchoRefType

        ReDim EchoRefs(1)

        ff = FreeFile()
        bbsFile = Space(FileLen(strCfgName))
        FileOpen(ff, strCfgName, OpenMode.Binary)
        FileGet(ff, bbsFile)
        FileClose(ff)

        'main loop
        rows = Split(bbsFile, vbCrLf)
        bbsFile = ""

        For i = 0 To UBound(rows)
            '��� ���������� ������ 0 � 1 �������
            rows(i) = Trim(rows(i))

            If Len(rows(i)) > 1 Then
                If Mid(rows(i), 1, 1) <> ";" And (Mid(rows(i), 1, 1) = "!" Or Mid(rows(i), 1, 1) = "$") Then

                    cols = Split(rows(i), " ")

                    '���� ��� ���, �.�. ����� �������� ��������� � ����� ������ �� ������� �������
                    For j = 1 To UBound(cols)

                        If Len(cols(j)) <> 0 Then
                            Exit For
                        End If

                    Next j

                    ec.EFile = Trim(Mid(cols(0), 2, Len(cols(0))))
                    ec.EName = Trim(cols(j))

                    Select Case Mid(cols(0), 1, 1)

                        Case "!" 'JAM
                            ec.EchoType = IDatabasesTypes.enmBaseType.Jam
                            ec.EFile = CStr(ec.EFile) & ".jhr" '����� ������� ������� ����������
                            AddEchoToList(ec)

                        Case "$" 'Squish
                            ec.EchoType = IDatabasesTypes.enmBaseType.Squish
                            ec.EFile = CStr(ec.EFile) & ".sqd"
                            AddEchoToList(ec)

                        Case "P" 'Pasthru
                            '�� �������������
                    End Select

                End If
            End If

        Next i

        Exit Sub
errHandler:

        Select Case Err.Number

            Case 53
                MsgBox("������ ������ ������������ Areas.bbs!" & vbCrLf & "���� " & strCfgName & " �� ������!", MsgBoxStyle.Exclamation, My.Application.Info.Title)

            Case Else
                ErrorMessage(Err.Number, Err.Description, "EchoNamesRead::ReadEchos")
        End Select

    End Sub

    ''' <summary>
    ''' ������ ������ �� �� ������� FastEcho 1.46.1
    ''' </summary>
    Private Sub ReadFastechoCfg()
        On Error GoTo errHandler
        Dim hdr As Area '��������� �������� ����.
        Dim ac, Offset, ff As Integer
        Dim ec As EchoRefType
        Dim ect As Short
        Dim buf As String
        Dim tmp As String
        Dim akas(31) As AkA
        Dim tAkA As AkA

        ff = FreeFile()
        FileOpen(ff, strCfgName, OpenMode.Binary)
        '����������� ���
        Offset = 1
        ac = 0
        buf = Space$(1000)
        While Offset < FileLen(strCfgName) - Len(hdr) - 1
            Seek(ff, Offset)
            FileGet(ff, buf)

            If InStr(1, buf, "fido", CompareMethod.Text) Then

                Seek(ff, Offset + InStr(1, buf, "fido", CompareMethod.Text) - 9)
                While ac <= 31
                    FileGet(ff, tAkA)

                    If tAkA.net <> 0 Then
                        akas(ac) = tAkA
                    End If

                    ac += 1
                    Offset = Offset + InStr(1, buf, tAkA.Domain, CompareMethod.Text) - 9 + Len(tAkA)
                    Seek(ff, Offset)
                End While
                Offset = FileLen(strCfgName) - Len(hdr) - 1
            End If

            Offset += 1000
        End While

        '�������� ����������� ���
        Offset = FileLen(strCfgName) - Len(hdr) + 1
        While Offset > 0
            Seek(ff, Offset)
            FileGet(ff, hdr)
            Offset = Offset - Len(hdr)
            ec.EFile = Trim(Replace(hdr.Path, Chr(0), " "))

            'ect = bin2dec(Mid$(dec2bin(CLng(hdr.flags.Storage_aType)), 1, 4))  '4x4
            ect = (hdr.flags.Storage_aType And 15)
            '��� ������� 4� ������ ���� ������� ���
            'ect = (hdr.flags.Storage_aType And 65520) \ 16

            '���� ��� �� ��������� ���, � ��������� �����
            If Len(ec.EFile) <> 0 Then
                If ect <> IDatabasesTypes.enmBaseType.Passthru And InStr(1, hdr.Path, GfeCore.PatchSeparator) <> 0 And ((Asc(Mid(hdr.Path, 1, 1)) >= 48 Or Asc(Mid(hdr.Path, 1, 1)) <= 57) And (Asc(Mid(hdr.Path, 1, 1)) >= 65)) And hdr.resv1 = 0 Then

                    ec.EName = Trim(Replace(hdr.Name, Chr(0), " "))
                    'ec.Description = Trim(Replace(hdr.Desc, Chr(0), " "))
                    'tmp = Space(Len(ec.Description))
                    'OemToChar(ec.Description, tmp)
                    tmp = enc.GetString(Encoding.Default.GetBytes(hdr.Desc))

                    ec.Description = tmp
                    ec.GroupNum = bin2dec(Mid(dec2bin(CInt(hdr.Info.Group)), 8, 8))
                    ac = hdr.Info.AkA '����� ���`���

                    If ac > 255 Then
                        ac -= 255
                    End If

                    ec.AkA = akas(ac).zone & ":" & akas(ac).net & "/" & akas(ac).node & "." & akas(ac).Point & "@" & Trim(Replace(akas(ac).Domain, Chr(0), " "))

                    Select Case ect

                        Case IDatabasesTypes.enmBaseType.Jam
                            ec.EchoType = IDatabasesTypes.enmBaseType.Jam
                            ec.EFile = ec.EFile & ".jhr" '����� ������� ������� ����������

                        Case IDatabasesTypes.enmBaseType.Squish
                            ec.EchoType = IDatabasesTypes.enmBaseType.Squish
                            ec.EFile = ec.EFile & ".sqd"

                        Case Else
                            ec.EchoType = IDatabasesTypes.enmBaseType.Jam  '��� ����������� ����� ���
                            ec.EFile = ec.EFile & ".jhr"
                    End Select

                    AddEchoToList(ec)
                End If
            End If

        End While
        FileClose(ff)

        Exit Sub

errHandler:

        Select Case Err.Number

            Case 53
                MsgBox("������ ������ ������������ Fastecho!" & vbCrLf & "���� " & strCfgName & " �� ������!", MsgBoxStyle.Exclamation, My.Application.Info.Title)

            Case Else
                ErrorMessage(Err.Number, Err.Description, "EchoNamesRead::ReadFastechoCfg")
        End Select

    End Sub

    ''' <summary>
    ''' ������ ������ �� �� ������� Husky Portable Tosser 1.4
    ''' </summary>
    ''' <remarks>������ 1.4 � ������</remarks>
    Private Sub ReadHPTCfg()
        Dim strs() As String
        Dim cols() As String
        Dim ns, j, i, k As Integer
        Dim ec As EchoRefType

        strs = Split(Replace(ConstructHPTConfig(strCfgName), vbCr, ""), vbLf)

        For i = 0 To UBound(strs)

            strs(i) = Replace(Replace(Replace(Replace(strs(i), vbTab, " "), vbLf, " "), vbCr, ""), Chr(0), "")

            '���� ������ �� ������, �� ������ � ���� ���� �� ��������� ����� ������������ ������
            If Mid(strs(i), 1, 1) <> "#" And Len(Trim(strs(i))) <> 0 Then
                If InStr(1, strs(i), "Passthrough ", CompareMethod.Text) = 0 And _
                   (InStr(1, strs(i), "EchoArea ", CompareMethod.Text) <> 0 Or _
                    InStr(1, strs(i), "LocalArea ", CompareMethod.Text) <> 0) Then

                    cols = Split(strs(i), " ")

                    '���� ��� ���, �.�. ����� �������� ������� ��������� � ����� ������ �� ������� �������
                    For j = 1 To UBound(cols)

                        If Len(cols(j)) <> 0 Then
                            Exit For
                        End If

                    Next j

                    ec.EName = cols(j).Trim

                    '���� � ����
                    For k = j + 1 To UBound(cols)

                        If Len(cols(k)) <> 0 Then
                            Exit For
                        End If

                    Next k

                    ec.EFile = cols(k).Trim

                    '��� ����
                    ns = InStr(1, strs(i), "-b ", CompareMethod.Text) + 3

                    If ns > 3 Then

                        Select Case LCase(Trim(Mid(strs(i), ns, InStr(ns, strs(i), " ", CompareMethod.Text) - ns + 1)))

                            Case "jam"
                                ec.EchoType = IDatabasesTypes.enmBaseType.Jam
                                ec.EFile = ec.EFile & ".jhr" '����� ������� ������� ����������

                            Case "squish"
                                ec.EchoType = IDatabasesTypes.enmBaseType.Squish
                                ec.EFile = ec.EFile & ".sqd"
                        End Select

                    Else
                        '�� ������� ����� ���� ����
                        ec.EchoType = IDatabasesTypes.enmBaseType.Jam
                        ec.EFile = ec.EFile & ".jhr"
                    End If

                    '������
                    ns = InStr(1, strs(i), "-g ", CompareMethod.Text) + 3

                    If ns > 3 Then
                        ec.GroupNum = Asc(Mid(strs(i), ns, 1).Trim.ToUpper) - Asc("A")
                    Else
                        ec.GroupNum = 0
                    End If

                    '��������
                    ns = InStr(1, strs(i), "-d """, CompareMethod.Text) + 4

                    If ns > 4 Then
                        ec.Description = Trim(Mid(strs(i), ns, InStr(ns, strs(i), """", CompareMethod.Text) - ns))
                    Else
                        ec.Description = "No Description"
                    End If

                    '���
                    ns = InStr(1, strs(i), "-a ", CompareMethod.Text) + 3

                    If ns > 3 Then
                        If (InStr(ns, strs(i), " ", CompareMethod.Text) - ns) > 0 Then
                            ec.AkA = Mid(strs(i), ns, InStr(ns, strs(i), " ", CompareMethod.Text) - ns).Trim
                        Else
                            ec.AkA = Mid(strs(i), ns, Len(strs(i))).Trim
                        End If

                    Else
                        ReadRegistry(My.Computer.Registry.CurrentUser, "SOFTWARE\GFE\Options", "MainAddress", ec.AkA.ToString, "unknown")

                        'ec.AkA = GetString(HKEY_CURRENT_USER, "SOFTWARE\GFE\Options", "MainAddress", "unknown")
                    End If

                    '������
                    ns = 0

                    For j = 1 To UBound(cols)

                        If Len(cols(j)) <> 0 Then

                            If Me.IsAdressString(cols(j)) Then
                                k = InStr(1, strs(i), "-a ") + Len(cols(j)) ' �� �������� ��� ����� �������, �� �� ���� ������

                                If InStr(k, strs(i), "-a " & cols(j), CompareMethod.Text) = 0 And InStr(1, cols(j), "@") = 0 Then

                                    '��� �� AKA �������
                                    If ns = 0 Then
                                        '��� ������.
                                        ns = 1
                                        ec.Uplink = cols(j)
                                    Else
                                        ReDim Preserve ec.Downlinks(ns)
                                        ec.Downlinks(ns) = cols(j)
                                        ns += 1
                                    End If
                                End If
                            End If
                        End If

                    Next j

                    '��� �����, ���������
                    AddEchoToList(ec)
                End If 'instr
            End If 'len

        Next i
    End Sub

    ''' <summary>
    ''' ������ ������ �� �� ������� BBToss 2.50
    ''' </summary>
    Private Sub ReadBBTossCfg()
        On Error GoTo errHandler
        Dim ini As New clsINI
        Dim i As Integer
        Dim bt As String
        Dim ec As EchoRefType

        ini.FileName = strCfgName

        For i = 1 To ini.SectionsCount

            With ec
                .EName = ini.SectionName(i)
                bt = UCase(ini.Value(.EName, "Basetyp"))

                If bt <> "P" Then
                    .AkA = ini.Value(.EName, "Mainaka")
                    .Description = ini.Value(.EName, "Desc")

                    Select Case bt

                        Case "J"
                            .EchoType = IDatabasesTypes.enmBaseType.Jam
                            .EFile = ini.Value(.EName, "Path") & ".jhr"

                        Case "S"
                            .EchoType = IDatabasesTypes.enmBaseType.Squish
                            .EFile = ini.Value(.EName, "Path") & ".sqd"

                        Case Else
                            .EchoType = IDatabasesTypes.enmBaseType.Passthru
                            .EFile = "."
                    End Select

                    .GroupNum = Asc(UCase(ini.Value(.EName, "Group"))) - Asc("A")
                    AddEchoToList(ec)
                End If

            End With

        Next i

        ini = Nothing

        Exit Sub
errHandler:
        Select Case Err.Number
            Case 53
                MsgBox("������ ������ ������������ BBToss!" & vbCrLf & "���� " & strCfgName & " �� ������!", MsgBoxStyle.Exclamation, My.Application.Info.Title)

            Case Else
                ErrorMessage(Err.Number, Err.Description, "EchoNamesRead::ReadBBTossCfg")

        End Select

        ini = Nothing

    End Sub

    ''' <summary>
    '''������ ������ �� �� ������������ FIPS
    ''' </summary>
    ''' <remarks >��� ������, ����������</remarks>
    Public Sub ReadFIPSCfg()
        Dim i As Integer, strPath As String
        Dim AreasFile As Integer
        Dim ec As EchoRefType, arRec As AreaRecord

        strPath = Replace$(strCfgName, "areas.wwd", "", , , vbTextCompare)
        AreasFile = FreeFile()

        Try
            FileOpen(AreasFile, strCfgName, OpenMode.Binary)
        Catch ex As IO.IOException
            MsgBox("������ �������� " + strCfgName, MsgBoxStyle.Exclamation)
            Exit Sub
        End Try

        For i = 0 To (LOF(AreasFile) / 562) - 1
            Seek(AreasFile, i * 562 + 1)
            FileGet(AreasFile, arRec)

            With ec
                .EName = CutOfNullChar(arRec.Echotag)
                .Description = CutOfNullChar(arRec.Description)
                .EFile = strPath + CutOfNullChar(arRec.FileName) + ".hdr"
                .AkA = CutOfNullChar(arRec.AKA)
                .EchoType = IDatabasesTypes.enmBaseType.FIPS
                .GroupNum = 0
                .Uplink = CutOfNullChar(arRec.UpLink)
                '���� �� ���������, ��������� ���������.
            End With

            AddEchoToList(ec)

        Next

        FileClose(AreasFile)

    End Sub

    ''' <summary>
    ''' ������ ������������ �� suish.cfg
    ''' </summary>
    Public Sub ReadSQUISHCfg()
        On Error GoTo errHandler

        Dim strs() As String
        Dim cols() As String
        Dim tmp As String
        Dim ns, j, i, k, ff As Integer
        Dim ec As EchoRefType

        ff = FreeFile()
        FileOpen(ff, strCfgName, OpenMode.Binary)
        tmp = Space(LOF(ff))
        FileGet(ff, tmp)
        FileClose(ff)

        strs = Split(Replace(tmp, vbCr, ""), vbLf)
        tmp = vbNullString

        For i = 0 To UBound(strs)

            strs(i) = Replace(Replace(Replace(strs(i), vbTab, " "), vbCr, ""), Chr(0), "")

            '���� ������ �� ������, �� ������ � ���� ���� �� ��������� ����� ������������ ������
            If Mid(strs(i), 1, 1) <> ";" And Len(Trim(strs(i))) <> 0 Then
                If InStr(1, strs(i), "EchoArea", CompareMethod.Text) <> 0 Or _
                   InStr(1, strs(i), "LocalArea", CompareMethod.Text) <> 0 Or _
                   InStr(1, strs(i), "BadArea", CompareMethod.Text) <> 0 Or _
                   InStr(1, strs(i), "DupeArea", CompareMethod.Text) <> 0 Then

                    cols = Split(strs(i), " ")

                    '���� ��� ���, �.�. ����� �������� ������� ��������� � ����� ������ �� ������� �������
                    For j = 1 To UBound(cols)

                        If Len(cols(j)) <> 0 Then
                            Exit For
                        End If

                    Next j

                    ec.EName = Trim(cols(j))

                    '���� � ����
                    For k = j + 1 To UBound(cols)

                        If Len(cols(k)) <> 0 Then
                            Exit For
                        End If

                    Next k

                    ec.EFile = Trim(cols(k)) & ".sqd"
                    ec.EchoType = IDatabasesTypes.enmBaseType.Squish

                    '�������
                    '��������
                    ns = InStr(1, strs(i), "-$n", CompareMethod.Text) + 3

                    If ns > 3 Then
                        If InStr(ns, strs(i), " -", CompareMethod.Text) = 0 Then
                            ec.Description = Replace(Trim(Mid(strs(i), ns, Len(strs(i)))), """", "")
                        Else
                            ec.Description = Replace(Trim(Mid(strs(i), ns, InStr(ns, strs(i), " -", CompareMethod.Text) - ns)), """", "")
                        End If

                        'tmp = Space$(Len(ec.Description))
                        'OemToChar ec.Description, tmp
                        'ec.Description = tmp
                    Else
                        ec.Description = "No Description"
                    End If

                    '������
                    ns = InStr(1, strs(i), "-$g", CompareMethod.Text) + 3

                    If ns > 3 Then
                        ec.GroupNum = Asc(UCase(Trim(Mid(strs(i), ns, 1)))) - Asc("A")
                    Else
                        ec.GroupNum = 0
                    End If

                    '���
                    ns = InStr(1, strs(i), "-p", CompareMethod.Text) + 2

                    If ns > 2 Then
                        If (InStr(ns, strs(i), " ", CompareMethod.Text) - ns) > 0 Then
                            ec.AkA = Trim(Mid(strs(i), ns, InStr(ns, strs(i), " ", CompareMethod.Text) - ns))
                        Else
                            ec.AkA = Trim(Mid(strs(i), ns, Len(strs(i))))
                        End If

                    Else
                        ReadRegistry(My.Computer.Registry.CurrentUser, "SOFTWARE\GFE\Options", "MainAddress", ec.AkA.ToString, "unknown")
                        'ec.AkA = GetString(HKEY_CURRENT_USER, "SOFTWARE\GFE\Options", "MainAddress", "unknown")
                    End If

                    '������
                    ''''''''''''''

                    '��� �����, ���������
                    AddEchoToList(ec)
                End If
            End If

        Next i

        Exit Sub

errHandler:

        Select Case Err.Number

            Case 53
                MsgBox("������ ������ ������������ SQUISH!" & vbCrLf & "���� " & strCfgName & " �� ������!", MsgBoxStyle.Exclamation, My.Application.Info.Title)

            Case Else
                ErrorMessage(Err.Number, Err.Description, "EchoNamesRead::ReadSQUISHCfg")
        End Select

    End Sub

    ''' <summary>
    ''' ������ ������������ DRIM Tosser
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ReadDRIMCfg()
        Dim cIni As New clsINI
        Dim ec As EchoRefType, tType As Integer

        If Not My.Computer.FileSystem.FileExists(strCfgName) Then
            Return
        End If

        cIni.FileName = strCfgName

        If cIni.Value("Common", "TosserType").Length <> 0 Then
            tType = CInt(cIni.Value("Common", "TosserType"))
        End If

        '��� DRIMTosser �������������� ������ SQL ������ �� ������ ������.
        Select Case tType
            Case 1, 2, 3, 7
            Case 9 'FIPS
                '�������� strCfgName=Msgbase=..... � ��������
                'ReadFIPSCfg()
            Case 10 'SQL
                Try
                    Dim connStr As String = Replace(cIni.Value("Paths", "Msgbase"), "|", ";")
                    Dim sqlConn, Command, dr As Object

                    If InStr(connStr, "Server=", CompareMethod.Text) <> 0 Then
                        sqlConn = New Npgsql.NpgsqlConnection(connStr)
                        Command = New Npgsql.NpgsqlCommand("SELECT * FROM ""Areas"";", sqlConn)
                    ElseIf InStr(connStr, "data source=", CompareMethod.Text) <> 0 Then
                        sqlConn = New SqlClient.SqlConnection(connStr)
                        Command = New SqlClient.SqlCommand("SELECT * FROM Areas;", sqlConn)
                    End If

                    sqlConn.Open()

                    dr = Command.ExecuteReader()
                    While dr.Read()
                        With ec
                            .EName = dr("AreaName").ToString
                            .EFile = connStr
                            .AkA = dr("AKA").ToString.Replace(vbLf, "")
                            .Description = dr("Description").ToString
                            .EchoType = IDatabasesTypes.enmBaseType.SQL
                        End With

                        AddEchoToList(ec) '��������� � ����

                    End While

                    sqlConn.Close()

                Catch ex As Npgsql.NpgsqlException
                    MsgBox("������ ����������� ��:: " & ex.Message, MsgBoxStyle.Critical)

                Catch ex As Exception

                Finally
                    cIni = Nothing
                End Try
            Case Else
                '�� �������������� ��� �������
                cIni = Nothing
        End Select
    End Sub

#Region "��������������� �������"

    ''' <summary>
    ''' ������������ ������ HPT ������ � ���������.
    ''' </summary>
    ''' <returns>���������� ������ HPT ������ � ������ ������</returns>
    Private Function ConstructHPTConfig(ByRef baseConfig As String) As String
        Dim rootBuff, tmp As String
        Dim ff As Integer
        Dim strt, fn As Integer
        Dim fname As String

        ff = FreeFile()
        FileOpen(ff, baseConfig, OpenMode.Binary)
        rootBuff = Space(LOF(ff))
        FileGet(ff, rootBuff)
        FileClose(ff)

        Do
            strt = InStr(strt + 1, rootBuff, "include ", CompareMethod.Text)

            If strt = 0 Then
                Exit Do
            End If

            fn = InStr(strt, rootBuff, vbLf)
            fname = Replace(Mid(rootBuff, strt + 8, fn - (strt + 8)), vbCrLf, "")

            If InStr(1, fname, ";") = 0 And InStr(1, fname, "$") = 0 And _
               InStr(1, fname, ")") = 0 And InStr(1, fname, ",") = 0 And _
               InStr(1, fname, "(") = 0 Then

                ff = FreeFile()
                FileOpen(ff, fname, OpenMode.Binary)
                tmp = Space(LOF(ff))
                FileGet(ff, tmp)
                FileClose(ff)

                rootBuff = rootBuff & tmp

            Else
                strt = fn
            End If

        Loop Until strt = 0

        Return rootBuff

    End Function

    ''' <summary>
    ''' ��������� �� ������� �������������� ������������ �� ������ ������ ������.
    ''' </summary>
    ''' <remarks>� ������ ������ ��� ������ ������������� ���������� �����</remarks>
    Private Sub SortEchoByGroupS()
        Dim TempVal As EchoRefType
        Dim GapSize, i, CurPos As Integer
        Dim LastRow, FirstRow, NumRows As Integer

        SortEchoByName()

        FirstRow = LBound(EchoRefs)
        LastRow = UBound(EchoRefs)
        NumRows = LastRow - FirstRow + 1

        Do
            GapSize = GapSize * 3 + 1
        Loop Until GapSize > NumRows

        Do
            GapSize = GapSize \ 3

            For i = (GapSize + FirstRow) To LastRow
                CurPos = i
                TempVal = EchoRefs(i)

                Do While EchoRefs(CurPos - GapSize).GroupNum > TempVal.GroupNum
                    EchoRefs(CurPos) = EchoRefs(CurPos - GapSize)
                    CurPos = CurPos - GapSize

                    If (CurPos - GapSize) < FirstRow Then
                        Exit Do
                    End If

                Loop

                EchoRefs(CurPos) = TempVal
            Next i

        Loop Until GapSize = 1

    End Sub

    ''' <summary>
    ''' ��������� �� ������
    ''' </summary>
    Private Sub SortEchoByNameS()
        Dim TempVal As EchoRefType
        Dim GapSize, i, CurPos As Integer
        Dim LastRow, FirstRow, NumRows As Integer

        FirstRow = LBound(EchoRefs)
        LastRow = UBound(EchoRefs)
        NumRows = LastRow - FirstRow + 1

        Do
            GapSize = GapSize * 3 + 1
        Loop Until GapSize > NumRows

        Do
            GapSize = GapSize \ 3

            For i = (GapSize + FirstRow) To LastRow
                CurPos = i
                TempVal = EchoRefs(i)

                Do While UCase(EchoRefs(CurPos - GapSize).EName) > UCase(TempVal.EName)
                    EchoRefs(CurPos) = EchoRefs(CurPos - GapSize)
                    CurPos = CurPos - GapSize

                    If (CurPos - GapSize) < FirstRow Then
                        Exit Do
                    End If

                Loop

                EchoRefs(CurPos) = TempVal
            Next i

        Loop Until GapSize = 1

    End Sub

    ''' <summary>
    ''' ������� ����������
    ''' </summary>
    Private Sub SortEchoByGroup()
        Dim i, j As Integer
        Dim tEC As EchoRefType

        SortEchoByName()

        For i = 1 To EchoRefsCount
            For j = i To EchoRefsCount

                If EchoRefs(i).GroupNum > EchoRefs(j).GroupNum Then
                    tEC = EchoRefs(i)
                    EchoRefs(i) = EchoRefs(j)
                    EchoRefs(j) = tEC
                End If

            Next j
        Next i

    End Sub

    ''' <summary>
    ''' ��������� �� ������
    ''' </summary>
    Private Sub SortEchoByName()
        Dim i, j As Integer
        Dim tEC As EchoRefType

        For i = 1 To EchoRefsCount
            For j = i To EchoRefsCount

                If UCase(EchoRefs(i).EName) > UCase(EchoRefs(j).EName) Then
                    tEC = EchoRefs(i)
                    EchoRefs(i) = EchoRefs(j)
                    EchoRefs(j) = tEC
                End If

            Next j
        Next i

    End Sub

    ''' <summary>
    ''' ����������� �������� �������������� ������ � FTN ������
    ''' </summary>
    ''' <param name="sAdress">����������� ������</param>
    ''' <returns>���������� TRUE ���� ������ �������� �������</returns>
    Public Function IsAdressString(ByVal sAdress As String) As Boolean
        Dim StartPos, EndPos As Integer
        Dim flag As Integer
        Dim tStr As String

        If Len(sAdress) = 0 Or InStr(1, sAdress, ":") = 0 Then
            IsAdressString = False
            Exit Function
        End If

        'zone
        StartPos = InStr(1, sAdress, ":") - 1
        tStr = Left(sAdress, StartPos)

        If Len(tStr) <> 0 Then
            flag = 1
        Else
            IsAdressString = False
            Exit Function
        End If

        'net
        StartPos = InStr(1, sAdress, ":") + 1
        EndPos = InStr(1, sAdress, "/")

        If EndPos > 0 Then
            tStr = Mid(sAdress, StartPos, EndPos - StartPos)

            If Len(tStr) <> 0 Then
                flag = 2
            End If

        Else
            Exit Function
        End If

        'node
        StartPos = InStr(1, sAdress, "/") + 1
        EndPos = InStr(1, sAdress, ".")

        If EndPos <= StartPos Then
            tStr = Mid(sAdress, StartPos)

            If Len(tStr) <> 0 Then
                flag = 3
            End If

        Else
            tStr = Mid(sAdress, StartPos, EndPos - StartPos)

            If Len(tStr) <> 0 Then
                flag = 3
            End If
        End If

        If flag = 3 Then
            IsAdressString = True
        Else
            IsAdressString = False
        End If

    End Function

    ''' <summary>
    ''' ���������-�������� ���������������
    ''' </summary>
    ''' <param name="dec">���������� �����</param>
    ''' <returns>�������� ����� � ������</returns>
    Private Function dec2bin(ByRef dec As Long) As String
        Dim tmp As Long, str As String

        If dec = 0 Then
            dec2bin = "00000000"
            Exit Function
        End If

        While dec > 0
            tmp = dec \ 2
            str = (dec - tmp * 2) & str
            dec = tmp
        End While

        Return str

    End Function

    ''' <summary>
    ''' �������-���������� ���������������
    ''' </summary>
    ''' <param name="bin">������ � �������� ������</param>
    ''' <returns>������� �����</returns>
    Private Function bin2dec(ByRef bin As String) As Long
        Dim tmp, i As Long

        If Len(bin) = 0 Then
            bin2dec = 0
            Exit Function
        End If

        tmp = CInt(Mid(bin, 1, 1))
        i = 2
        While i <= Len(bin)
            tmp = tmp * 2 + CLng(Mid(bin, i, 1))
            i += 1
        End While

        Return tmp

    End Function

    Private Function CutOfNullChar(ByVal sString As String, _
                                    Optional ByVal bNotTrimString As Boolean = True) As String

        If InStr(1, sString, vbNullChar) <> 0 Then
            sString = Left$(sString, InStr(1, sString, vbNullChar) - 1)
        End If

        CutOfNullChar = IIf(bNotTrimString, Trim$(sString), sString)
    End Function

    Private Sub ErrorMessage(ByRef ErrNumber As Integer, ByRef Description As String, ByRef Where As String)
        MsgBox("������ #" & ErrNumber & vbCrLf & _
               "�: " & Where & vbCrLf & _
               "��������: " & Description, _
               MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, My.Application.Info.Title)
    End Sub

    Protected Overrides Sub Finalize()
        Erase TossersNames
        MyBase.Finalize()
    End Sub

#End Region

End Class
