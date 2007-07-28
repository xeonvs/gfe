Option Explicit On

Imports System.IO
Imports System.Drawing
Imports System.Text

Public Class Database
    Implements IDatabases

#Region "API"
    'Private Declare Sub RtlMoveMemory Lib "kernel32.dll" (ByRef dst As Any, ByRef Src As Any, ByVal cb As Integer)
    Private Declare Function CreateFile Lib "kernel32" Alias "CreateFileA" (ByVal lpFileName As String, ByVal dwDesiredAccess As Integer, ByVal dwShareMode As Integer, ByVal lpSecurityAttributes As Integer, ByVal dwCreationDisposition As Integer, ByVal dwFlagsAndAttributes As Integer, ByVal hTemplateFile As Integer) As Integer
    Private Declare Function ReadFile Lib "kernel32" (ByVal hFile As Integer, ByRef lpBuffer As Integer, ByVal nNumberOfBytesToRead As Integer, ByRef lpNumberOfBytesRead As Integer, ByVal lpOverlapped As Integer) As Integer
    Private Declare Function SetFilePointer Lib "kernel32" (ByVal hFile As Integer, ByVal lDistanceToMove As Integer, ByRef lpDistanceToMoveHigh As Integer, ByVal dwMoveMethod As Integer) As Integer
    Private Declare Function GetFileSize Lib "kernel32" (ByVal hFile As Integer, ByRef lpFileSizeHigh As Integer) As Integer
    Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Integer) As Integer

    Private Const GENERIC_ALL As Integer = &H10000000
    Private Const GENERIC_EXECUTE As Integer = &H20000000
    Private Const GENERIC_READ As Integer = &H80000000
    Private Const GENERIC_WRITE As Integer = &H40000000
    Private Const FILE_SHARE_READ As Short = &H1S
    Private Const FILE_SHARE_WRITE As Short = &H2S
    Private Const CREATE_ALWAYS As Short = 2
    Private Const CREATE_NEW As Short = 1
    Private Const OPEN_EXISTING As Short = 3
    Private Const FILE_BEGIN As Short = 0
    Private Const FILE_END As Short = 2
    Private Const FILE_CURRENT As Short = 1
#End Region

#Region "Private members"
    '~~~~~~~~~~~~~~~~~~~~~переменные для свойств
    Private strDBname As String 'local copy
    Private strEchoName As String 'local copy
    Private numMessages As Integer 'local copy
    Private msgFrom As String 'local copy
    Private msgFromAddr As String 'local copy
    Private msgTo As String 'local copy
    Private msgToAddr As String 'local copy
    Private msgDateWritten As Integer 'local copy
    Private msgDateArrived As Integer 'local copy
    Private msgSubj As String 'local copy
    Private msgText As String 'local copy
    Private msgFlags As Integer 'local copy
    Private msgReplayTo As Integer 'local copy
    Private msgReplayFirst As Integer 'local copy
    Private msgReplayNext As Integer 'local copy
    Private bolDefault As Boolean

    'Main Streams
    Private fsH As FileStream   'Headers stream 
    Private fsT As FileStream   'Texts stream    
    Private brH As BinaryReader 'Read headers
    Private brT As BinaryReader 'Read texts
    Private wrH As BinaryWriter 'Write headers
    Private wrT As BinaryWriter 'Write texts
    Private fsI As FileStream   'Index
    Private brI As BinaryReader 'Index reader
    Private ffsT As String      'filename for texts
    Private ffsL As String      'filename for lastread
    Private ffsI As String      'filename for index
    '~~~~~~~~~~~~~~~~~~~~~
    Private targetEncoding As Encoding = Encoding.GetEncoding(866)

#End Region

#Region "Sample Jam Base Structure"
    'заголовок файла *.jhr
    Private Structure JamHdrType 'offsset
        <VBFixedString(4)> Dim Signature As String '0
        Dim Created As Integer '4
        Dim ModCounter As Integer '8
        Dim ActiveMsgs As Integer '12
        Dim PwdCrc As Integer '16
        Dim BaseMsgNum As Integer '20
        Dim HighWaterMark As Integer '24
        <VBFixedString(996)> Public RSRVD As String '28
    End Structure

    'заголовок мессаг файла *.jhr
    Private Structure JamMsgHdrType
        <VBFixedString(4)> Dim Signature As String  '0
        Dim Rev As Short            '4
        Dim Resvd As Short          '6
        Dim SubfieldLen As Integer  '8
        Dim TimesRead As Integer    '12
        Dim MSGIDcrc As Integer     '16
        Dim REPLYcrc As Integer     '20
        Dim ReplyTo As Integer      '24
        Dim ReplyFirst As Integer   '28
        Dim ReplyNext As Integer    '32
        Dim DateWritten As Integer  '36
        Dim DateRcvd As Integer     '40
        Dim DateArrived As Integer  '44
        Dim MsgNum As Integer       '48
        Dim Attr1 As Integer        '52
        Dim Attr2 As Integer        '56
        Dim TextOfs As Integer      '60
        Dim TextLen As Integer      '64
        Dim PwdCrc As Integer       '68
        Dim Cost As Integer         '72
    End Structure

    'Записи в файле *.JDX
    Private Structure JamJdxType
        Dim MsgToCrc As Integer '0
        Dim HdrLoc As Integer 'The record number (+BaseMsgNum)  '4
    End Structure

    'Записи в файле *.JLR
    Private Structure JamJlrType
        Dim UserCrc As Integer 'CRC-32 of user name (lowercase) 0
        Dim UserId As Integer 'Unique UserID 4
        Dim LastReadMsg As Integer 'Last read message number 8
        Dim HighReadMsg As Integer 'Highest read message number 12
    End Structure

    'подполя сообщения в заголовке
    Private Structure JamSubFieldType
        Dim LoId As Short   '0
        Dim HiId As Short   '2
        Dim DataLen As Integer  '4
        'Data As String * 82
    End Structure

    'субполя в коллекции сообщений
    Private Structure SubField
        Dim LoId As Integer '0 
        Dim Data As String  '4
    End Structure

#End Region

    Public ReadOnly Property BaseType() As GfeCore.IDatabasesTypes.enmBaseType Implements GfeCore.IDatabases.BaseType
        Get
            Return IDatabasesTypes.enmBaseType.Jam
        End Get
    End Property
    Public Property DateArrived() As Integer Implements GfeCore.IDatabases.DateArrived
        Get
            Return msgDateArrived
        End Get
        Set(ByVal value As Integer)
            msgDateArrived = value
        End Set
    End Property
    Public Property DateWritten() As Integer Implements GfeCore.IDatabases.DateWritten
        Get
            Return msgDateWritten
        End Get
        Set(ByVal value As Integer)
            msgDateWritten = value
        End Set
    End Property
    Public Property DBName() As String Implements GfeCore.IDatabases.DBName
        Get
            Return strDBname
        End Get
        Set(ByVal value As String)
            strDBname = value
        End Set
    End Property
    Public Sub DeleteMessageByNum(ByVal NumberMessage As Integer) Implements GfeCore.IDatabases.DeleteMessageByNum

    End Sub
    Public Property EchoName() As String Implements GfeCore.IDatabases.EchoName
        Get
            Return strEchoName
        End Get
        Set(ByVal value As String)
            strEchoName = value
        End Set
    End Property
    Public Property From() As String Implements GfeCore.IDatabases.From
        Get
            Return msgFrom
        End Get
        Set(ByVal value As String)
            msgFrom = value
        End Set
    End Property
    Public Property FromAddr() As String Implements GfeCore.IDatabases.FromAddr
        Get
            Return msgFromAddr
        End Get
        Set(ByVal value As String)
            msgFromAddr = value
        End Set
    End Property
    ''' <summary>
    '''  Возвращает раскодированные заголовки письма
    ''' </summary>
    ''' <param name="NumberMessage">Номер нужного письма</param>
    Public Sub GetHeadesByNum(ByVal NumberMessage As Integer) Implements GfeCore.IDatabases.GetHeadesByNum
        If NumberMessage > numMessages Then
            Exit Sub
        ElseIf NumberMessage = 0 Then
            Exit Sub
        End If

        Dim sublen, ss, dl, loid As Integer
        Dim nn As String = ""

        'забираем заголовки
        fsH.Seek(GetMessageOffsetFromIndex(NumberMessage - 1) + 8, SeekOrigin.Begin)
        sublen = brH.ReadInt32
        fsH.Seek(12, SeekOrigin.Current)
        msgReplayTo = brH.ReadInt32
        msgReplayFirst = brH.ReadInt32
        msgReplayNext = brH.ReadInt32
        msgDateWritten = brH.ReadInt32
        fsH.Seek(4, SeekOrigin.Current)
        msgDateArrived = brH.ReadInt32
        fsH.Seek(4, SeekOrigin.Current)
        msgFlags = brH.ReadInt32

        'subs
        fsH.Seek(20, SeekOrigin.Current)
        ss = 0
        Do
            loid = brH.ReadInt16
            fsH.Seek(2, SeekOrigin.Current)
            dl = brH.ReadInt32
            If dl < sublen Then
                nn = targetEncoding.GetString(brH.ReadBytes(dl), 0, dl)
            End If
            Select Case loid
                Case 0
                    'ID=0, Name=OADDRESS
                    msgFromAddr = nn

                Case 1
                    'ID=1, Name=DADDRESS
                    msgToAddr = nn

                Case 2
                    msgFrom = nn

                Case 3
                    'ID=3, Name=RECEIVERNAME
                    msgTo = nn

                Case 4
                    'ID=4, Name=MSGID
                    If InStr(1, nn, "@") <> 0 Then
                        msgFromAddr = Mid$(nn, 1, InStr(1, nn, "@") - 1)
                    ElseIf InStr(1, nn, "/") <> 0 Then
                        msgFromAddr = Mid$(nn, 1, InStr(InStr(1, nn, "/"), nn, " ") - 1)
                    End If

                    'Case 5
                    'ID=5, Name=REPLYID
                Case 6
                    'если встречается удаленный мессаг то добавим в его сабж [DEL] subj [DEL]
                    'If ((msgFlags And MSG_ATTRIBUTE.MSG_DELETED) = MSG_ATTRIBUTE.MSG_DELETED) Or (msgFlags = 0) Then
                    'msgSubj = "[DEL] " & nn & " [DEL]"
                    'Else
                    msgSubj = nn
                    'End If

                    'Case 7
                    'ID=7, Name=PID

                    'Case 8
                    'ID=8, Name=TRACE

                    'Case 9
                    'ID=9, JAMSFLD_ENCLFILE

                    'Case 10
                    'ID=10, JAMSFLD_ENCLFWALIAS

                    'Case 11
                    'ID=11, JAMSFLD_ENCLFREQ

                    'Case 12
                    'ID=12, JAMSFLD_ENCLFILEWC

                    'Case 13
                    'ID=13, JAMSFLD_ENCLINDFILE

                    'Case 1000
                    'ID=1000, EMBINDAT

                Case 2000
                    'ID=2000, Name=FTSKLUDGE
                    'тут будет адрес реплея на сообщение из интернета
                    If msgFromAddr = "" Then
                        If InStr(1, nn, "REPLYTO") <> 0 Then
                            msgFromAddr = Mid$(nn, InStr(9, nn, ":") - 1, InStr(9, nn, " ") + 1)
                        End If
                    End If

                    'Case 2001
                    'ID=2001, Name=SEENBY2D

                    'Case 2002
                    'ID=2002, Name=PATH2D

                    'Case 2003
                    'ID=2003, FLAGS

                    'Case 2004
                    'ID=2004, TZUTCINFO

                Case Else
                    'какято хрень в служебных полях
            End Select

            ss += 8 + dl 'next field offset

        Loop Until Not (ss < sublen)

    End Sub
    ''' <summary>
    '''  Возвращает полные раскодированные заголовки письма
    ''' </summary>
    ''' <param name="NumberMessage"></param>
    ''' <remarks>в джам базе не исспользуется</remarks>
    Public Sub GetHeadesByNumAll(ByVal NumberMessage As Integer) Implements GfeCore.IDatabases.GetHeadesByNumAll

    End Sub
    Public Sub GetHeadesByNumForTree(ByVal NumberMessage As Integer) Implements GfeCore.IDatabases.GetHeadesByNumForTree
        'msgReplayTo
        'msgReplayFirst
        'msgReplayNext
        'msgSubj
        'msgFrom
    End Sub
    Public Function GetLastReadMsgNum(Optional ByVal msgNumber As Integer = 0) As Integer Implements GfeCore.IDatabases.GetLastReadMsgNum
        Dim fsL As Stream
        Dim brL As BinaryReader, bwL As BinaryWriter
        Dim msgn As Integer

        Try
            fsL = New FileStream(ffsL, FileMode.Open)
            brL = New BinaryReader(fsL)
        Catch e As System.IO.FileNotFoundException
            MsgBox("Файл " & ffsL & " не найден.", MsgBoxStyle.Exclamation)
            Exit Function
        Catch
            Exit Function
        End Try

        If msgNumber = 0 Then
            If fsL.Length <> 0 Then
                fsL.Seek(8, SeekOrigin.Begin)
                msgn = brL.ReadInt32
            End If

        Else 'сохраняем состояние
            If fsL.Length <> 0 Then
                bwL = New BinaryWriter(fsL)
                fsL.Seek(8, SeekOrigin.Begin)
                bwL.Write(msgNumber)
                msgn = msgNumber
            End If
        End If

        fsL.Close()
        bwL = Nothing
        brL = Nothing
        fsL = Nothing

        If msgn > 0 And msgn <= numMessages Then
            Return msgn
        Else
            Return -1
        End If

    End Function

    Public Sub GetMessageByNum(ByVal NumberMessage As Integer) Implements GfeCore.IDatabases.GetMessageByNum
        If NumberMessage > numMessages Then
            Exit Sub
        ElseIf NumberMessage = 0 Then
            Exit Sub
        End If

        fsH.Seek(GetMessageOffsetFromIndex(NumberMessage - 1) + 60, SeekOrigin.Begin)
        Dim textoffset As Integer = brH.ReadInt32
        Dim TextLen As Integer = brH.ReadInt32

        fsT.Seek(textoffset, SeekOrigin.Begin)

        msgText = targetEncoding.GetString(brT.ReadBytes(TextLen), 0, TextLen)

    End Sub

    Public Function GetMessageDumpByNum(ByVal NumberMessage As Integer) As String Implements GfeCore.IDatabases.GetMessageDumpByNum
        Return ""
    End Function

    Public Function GetMessageKlugeByNum(ByVal NumberMessage As Integer) As String Implements GfeCore.IDatabases.GetMessageKlugeByNum
        Return ""
    End Function

    Public Property MessageCount() As Integer Implements GfeCore.IDatabases.MessageCount
        Get
            Return numMessages
        End Get
        Set(ByVal value As Integer)
            numMessages = value
        End Set
    End Property

    Public ReadOnly Property MessageCountByEcho(ByVal EchoPath As String) As Integer Implements GfeCore.IDatabases.MessageCountByEcho
        Get
            Dim ff, hDb As Integer

            hDb = CreateFile(EchoPath, GENERIC_READ, FILE_SHARE_READ, 0, OPEN_EXISTING, 0, 0)

            If hDb < 0 Then
                'база не существует, создаем ее
                'CreateDefaultBase Echo
                MessageCountByEcho = 0
                Exit Property
            End If

            'считываем
            If SetFilePointer(hDb, 12, 0, FILE_BEGIN) = 0 Then
                'ApiErrorLookup(GetLastError, "jamBase::MessageCountByEcho")
                CloseHandle(hDb)
                MessageCountByEcho = 0
                Exit Property
            End If

            If ReadFile(hDb, ff, 4, 0, 0) = 0 Then
                'ApiErrorLookup(GetLastError, "jamBase::MessageCountByEcho")
                CloseHandle(hDb)
                MessageCountByEcho = 0
                Exit Property
            End If

            If ff <= 0 Then

                'проверяем на корректность базу
                If GetFileSize(hDb, 0) < 1024 Then
                    'база битая делаем ее дефолтной.
                    CloseHandle(hDb)
                    'CreateDefaultBase(Echo)
                    MessageCountByEcho = 0
                    Exit Property
                Else
                    ff = 0
                End If
            End If

            CloseHandle(hDb)

            MessageCountByEcho = ff

        End Get
    End Property

    Public Property MessageFlags() As Integer Implements GfeCore.IDatabases.MessageFlags
        Get
            Return msgFlags
        End Get
        Set(ByVal value As Integer)
            msgFlags = value
        End Set
    End Property

    Public Function MessageStatus(ByVal NumberMessage As Integer, Optional ByVal Status As Integer = -1) As Integer Implements GfeCore.IDatabases.MessageStatus

    End Function

    Public Property MessageText() As String Implements GfeCore.IDatabases.MessageText
        Get
            Return msgText
        End Get
        Set(ByVal value As String)
            msgText = value
        End Set
    End Property

    Public Sub OpenDB() Implements GfeCore.IDatabases.OpenDB
        ffsT = Mid$(DBName, 1, InStr(DBName, ".jhr", CompareMethod.Text)) & "jdt"
        ffsL = Mid$(DBName, 1, InStr(DBName, ".jhr", CompareMethod.Text)) & "jlr"
        ffsI = Mid$(DBName, 1, InStr(DBName, ".jhr", CompareMethod.Text)) & "jdx"

        numMessages = Me.MessageCountByEcho(strDBname)

        Try
            fsH = New FileStream(strDBname, FileMode.Open, FileAccess.ReadWrite, FileShare.Read)
            brH = New BinaryReader(fsH)
            wrH = New BinaryWriter(fsH)
        Catch e As System.IO.FileNotFoundException
            MsgBox("Файл заголовков: " & strDBname & " не найден.")
            Exit Sub
        Catch
            Exit Sub
        End Try

        Try
            fsT = New FileStream(ffsT, FileMode.Open, FileAccess.ReadWrite, FileShare.Read)
            brT = New BinaryReader(fsT)
            wrT = New BinaryWriter(fsT)
        Catch e As System.IO.FileNotFoundException
            MsgBox("Файл текстов: " & ffsT & " не найден.")
            Exit Sub
        Catch
            Exit Sub
        End Try

        Try
            fsI = New FileStream(ffsI, FileMode.Open)
            brI = New BinaryReader(fsI)
        Catch e As System.IO.FileNotFoundException
            MsgBox("Файл индексов: " & ffsT & " не найден.")
            Exit Sub
        Catch
            Exit Sub
        End Try
    End Sub

    Public Property ReplayFirst() As Integer Implements GfeCore.IDatabases.ReplayFirst
        Get
            Return msgReplayFirst
        End Get
        Set(ByVal value As Integer)
            msgReplayFirst = value
        End Set
    End Property

    Public Property ReplayNext() As Integer Implements GfeCore.IDatabases.ReplayNext
        Get
            Return msgReplayNext
        End Get
        Set(ByVal value As Integer)
            msgReplayNext = value
        End Set
    End Property

    Public Property ReplayNextS() As String Implements GfeCore.IDatabases.ReplayNextS
        Get
            Return ""
        End Get
        Set(ByVal value As String)
            'null for jam
        End Set
    End Property

    Public Property ReplayTo() As Integer Implements GfeCore.IDatabases.ReplayTo
        Get
            Return msgReplayTo
        End Get
        Set(ByVal value As Integer)
            msgReplayTo = value
        End Set
    End Property

    Public Property Subject() As String Implements GfeCore.IDatabases.Subject
        Get
            If InStr(1, msgSubj, "?koi8-r", CompareMethod.Text) <> 0 Then
                Return DeCode(msgSubj)
            Else
                Return msgSubj
            End If

        End Get
        Set(ByVal value As String)
            msgSubj = value
        End Set
    End Property

    Public Property [To]() As String Implements GfeCore.IDatabases.To
        Get
            Return msgTo
        End Get
        Set(ByVal value As String)
            msgTo = value
        End Set
    End Property

    Public Property ToAddr() As String Implements GfeCore.IDatabases.ToAddr
        Get
            Return msgToAddr
        End Get
        Set(ByVal value As String)
            msgToAddr = value
        End Set
    End Property

    Public Function WriteMessage() As Integer Implements GfeCore.IDatabases.WriteMessage

    End Function

    ''' <summary>
    ''' конструктор "по умолчанию"
    ''' </summary>
    Sub New()
        bolDefault = True
    End Sub

    ''' <summary>
    ''' Создает экземпляр класса и сразу загружает базу
    ''' </summary>
    Public Sub New(ByVal DbPath As String)
        strDBname = DbPath
        OpenDB()
    End Sub

#Region "ModuleInfo"
    Public Function GetModuleIcon() As System.Drawing.Image Implements GfeCore.IDatabases.GetModuleIcon
        Return My.Resources.ModuleIcon.ToBitmap
    End Function

    Public ReadOnly Property Description() As String Implements GfeCore.IModuleInfo.Description
        Get
            Return "Jam Module"
        End Get
    End Property

    Public ReadOnly Property Name() As String Implements GfeCore.IModuleInfo.Name
        Get
            Return "jamBase"
        End Get
    End Property
#End Region

#Region "Private methods"
    ''' <summary>
    '''  Получает из индексного файла смещение интересующего нас письма
    ''' </summary>
    Private Function GetMessageOffsetFromIndex(ByVal NumberMessage As Integer) As Integer
        Try
            Dim idx As Integer = NumberMessage * 8 + 4 '+4 в данном случае первая запись структуры
            Dim offset As Integer = -1

            Try
                fsI.Seek(idx, SeekOrigin.Begin)
                While offset = -1
                    offset = brI.ReadInt32()
                    fsI.Seek(4, SeekOrigin.Current)
                End While
            Catch ex As IOException
                'сделать реверсивный поиск.
            End Try

            Return offset

        Catch ex As IOException
            Return -1
        End Try
    End Function

    ''' <summary>
    ''' 'Возвращает первое письмо в интересующей нас цепочке ответов где поле RaplayNext=0
    ''' </summary>
    Private Function GetReplayNextForAnswer(ByVal NumberMessage As Integer, ByVal FileNum As Integer) As Integer

    End Function

    ''' <summary>
    ''' функция декодирует ESC последовательность
    ''' </summary>
    Private Function DeCode(ByVal Text As String) As String
        Dim RegEx As New RegularExpressions.Regex("=([0-9a-fA-F]{2})", RegularExpressions.RegexOptions.Compiled Or _
                                                                       RegularExpressions.RegexOptions.IgnoreCase Or _
                                                                       RegularExpressions.RegexOptions.Multiline)
        Dim colmatches As RegularExpressions.MatchCollection = RegEx.Matches(Text)
        Dim ret As String = Replace(Text, "=?koi8-r?q?", "", , , CompareMethod.Text).Replace("?=", "")

        For Each aMatch As RegularExpressions.Match In colmatches ' проходим по всей коллекции
            ret = ret.Replace(aMatch.Value, Chr(CInt("&H" & aMatch.Groups(1).Value)))
        Next aMatch

        Dim dec As Encoding = Encoding.GetEncoding("koi8-r")
        Dim src As Byte() = Encoding.Default.GetBytes(ret)
        ret = dec.GetString(src)

        Return ret

    End Function

#End Region


    Private disposed As Boolean = False

    ' IDisposable
    Private Overloads Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposed Then
            If disposing Then
                Try
                    If Not bolDefault Then
                        wrH.Close()
                        wrT.Close()
                        brH.Close()
                        brT.Close()
                        fsT.Close()
                        fsH.Close()
                        brI.Close()
                        fsI.Close()
                    End If
                Catch
                Finally
                    brH = Nothing
                    brT = Nothing
                    wrH = Nothing
                    wrT = Nothing
                    fsH = Nothing
                    fsT = Nothing
                    brI = Nothing
                    fsI = Nothing
                    MyBase.Finalize()
                End Try
            End If
            ' TODO: put code to free unmanaged resources here
        End If
        Me.disposed = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Overloads Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overrides Sub Finalize()
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(False)
        MyBase.Finalize()
    End Sub
#End Region

End Class
