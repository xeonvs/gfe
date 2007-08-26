Option Explicit On

Imports System.IO
Imports System.Text

Public Class Database
    Implements IDatabases

#Region "Sample Squish Structure"
    'Description: _
    'Squish has four files: _
    '*.SQL   - the lastread pointers are stored for the user. The lastus00.dat _
    'file has the user's record number. Seek to it and read a word _
    'to get lastread value for the user for the message base. _
    '*.SQI   - is a index of LIVE MESSAGES in the Squish *.SQD file. It _
    'basically stores the 'unique' message id for each message, _
    'the offset of the SQUISH messahe header (sqhdr) and the _
    'HASH of the TOWHOM user's name. _
    '*.SQD   - has all the mail. The basic layout is: _
    'BASE_RECORD _
    'then for each message _
    'SQUISH MESSAGE HEADER _
    'CONTROL INFORMATION   Where all ^A stuff is stored _
    'TEXT MESSAGE          may not always be null terminated _
    'The base record will tell you where the first squish msg header _
    'is at, and each msg header will point to the next or prev one. _
    'In addition, the base record also will point to the first FREE _
    '(one that was marked deleted) Squish Message Header and so on. _
    'So from the base record, you can get a "Doublely linked list" _
    'of both the live messages and free messages. _
    '*.SQB  - something to do with dupe checking and I think it's for the _
    'squish mail processor. Not discussed or used in the this API. _
    '*****************************************************************************)
    Private Const SQHDRID As Integer = &HAFAE4453
    Private Const ID_HIDX As Short = &H9FEES
    Private Const LINKNEXT As Short = 0
    Private Const LINKPREV As Short = 1
    Private Const NULLFRAME As Short = 0
    Private Const SQMSG_FROM_SIZE As Short = 36
    Private Const SQMSG_TO_SIZE As Short = 36
    Private Const SQMSG_SUBJ_SIZE As Short = 72
    Private Const MAX_REPLY As Short = 8 '(* Max number of stored replies to one msg  *)
    'UMSGID = long

    'Address
    Private Structure Address
        Dim zone As Short
        Dim net As Short
        Dim node As Short
        Dim Point As Short
    End Structure

    '/* Frame types for sqhdr.frame_type */
    Private Enum sqFrameType
        FRAME_NORMAL = &H0S     '/* Normal text frame */
        FRAME_free = &H1S       '/* Part of the free chain */
        FRAME_LZSS = &H2S       '/* Not implemented */
        FRAME_UPDATE = &H3S     '/* Frame is being updated by another task */
    End Enum

    '/* Header block at offset 0 of <area>.SQD */
    Private Structure sqBaseHdr
        Dim Len As Short                '/* LENGTH OF THIS STRUCTURE! */           /*   0 */
        Dim Rsvd1 As Short              '/* reserved */                            /*   2 */
        Dim Num_msg As Integer          '/* Number of messages in area */          /*   4 */
        Dim High_msg As Integer         '/* Highest msg in area. Same as num_msg*/ /*   8 */
        Dim Skip_msg As Integer         '/* Skip killing first x msgs in area */   /*  12 */
        Dim High_water As Integer       '/* Msg# (not umsgid) of HWM */            /*  16 */
        Dim Uid As Integer              '/* Number of the next UMSGID to use */    /*  20 */
        <VBFixedString(79)> Dim base As String '/* Base name of SquishFile */      /*  24 */
        Dim Begin_frame As Integer      '/* Offset of first frame in file */       /* 104 */
        Dim Last_frame As Integer       '/* Offset to last frame in file */        /* 108 */
        Dim Free_frame As Integer       '/* Offset of first FREE frame in file */  /* 112 */
        Dim Last_free_frame As Integer  '/* Offset of last free frame in file */   /* 116 */
        Dim End_frame As Integer        '/* Pointer to end of file */              /* 120 */
        Dim Max_msg As Integer          '/* Max # of msgs to keep in area */       /* 124 */
        Dim Keep_days As Short          '/* Max age of msgs in area (SQPack) */    /* 128 */
        Dim Sz_sqhdr As Short           '/* sizeof(SQHDR) */                       /* 130 */
        <VBFixedString(124)> Dim rsvd2 As String  '/* Reserved by Squish for future use*/    /* 132 */
        '/* total: 256 */
    End Structure

    '* Squish frame header.  This comes before each and every message in a _
    '* Squish message base.
    Private Structure sqFrameHdr
        Dim Id As Integer           '/* sqhdr.id must always equal SQHDRID */               /*   0 */
        Dim Next_frame As Integer   '/* Next frame in the linked list */                    /*   4 */
        Dim Prev_frame As Integer   '/* Prior frame in the linked list */                   /*   8 */
        Dim Frame_length As Integer '/* Length of this frame */                             /*  12 */
        Dim Msg_length As Integer   '/* Length used in this frame by XMSG, ctrl and text */ /*  16 */
        Dim Clen As Integer         '/* Length used in this frame by ctrl info only */      /*  20 */
        Dim Frame_type As Short     '/* Type of frame -- see above FRAME_XXXX */            /*  24 */
        Dim Rsvd As Short           '/* Reserved for future use */                          /*  26 */
        '/* total: 28 */
    End Structure

    'But right after each frame header, follows the squish message header, _
    'then the control info, then the text.
    Private Structure sqMessageHdr
        Dim Attr As Integer                                     ' 0
        <VBFixedString(SQMSG_FROM_SIZE)> Dim FromWho As String  ' 4
        <VBFixedString(SQMSG_TO_SIZE)> Dim ToWho As String      ' 40
        <VBFixedString(SQMSG_SUBJ_SIZE)> Dim Subj As String     ' 76
        Dim OrigAddr As Address                                 ' 148
        Dim DestAddr As Address                                 ' 156 (* Origination and destination addresses *)
        Dim Date_written As Integer                             ' 164 (* When user wrote the msg (UTC) *)
        Dim Date_arrived As Integer                             ' 168 (* When msg arrived on-line (UTC) *)
        Dim utc_ofs As Short                                    ' 172 (* Minutes offset from UTC of message writer *)
        Dim ReplyTo As Integer                                  ' 174
        <VBFixedArray(MAX_REPLY)> Dim Replies() As Integer      ' 178
        Dim uMsgId As Integer                                   ' 214
        <VBFixedString(20)> Public azdate As String             ' 238 (* ASCII date *)

        Public Sub Initialize()
            ReDim Replies(MAX_REPLY) 'Zero based
        End Sub
    End Structure

    'Each SQD file has a SQI FILES.  The message number YOU see (the user) _
    'in MAX is really the counter starting from 1 of each record in SQI. _
    'But the TRUE UNIQUE Message ID is in umsgid. The ofs value will _
    'point to the frame header in SQD.  These files are small and you _
    'may read them into a array SqiPtrArrayType using the functions _
    'below.
    Private Structure sqIdxType
        Dim Offset As Integer      '(* Offset of frame header *)       /*   0 */
        Dim uMsgId As Integer   '(* Unique message identifier *)    /*   4 */
        Dim Hash As Integer     '(* 'To' name hash value *)         /*   8 */
        '/* total: 12 */
    End Structure

#End Region

#Region "Private members"
    '~~~~~~~~~~~~~~~~~~~~~переменные для свойств
    Private strDBname As String         'local copy
    Private strEchoName As String       'local copy
    Private numMessages As Integer      'local copy
    Private msgFrom As String           'local copy
    Private msgFromAddr As String       'local copy
    Private msgTo As String             'local copy
    Private msgToAddr As String         'local copy
    Private msgDateWritten As Integer   'local copy
    Private msgDateArrived As Integer   'local copy
    Private msgSubj As String           'local copy
    Private msgText As String = ""      'local copy
    Private msgFlags As Integer         'local copy
    Private msgReplayTo As Integer      'local copy
    Private msgReplayFirst As Integer   'local copy
    Private msgReplayNext As Integer    'local copy
    Private bolDefault As Boolean
    Private fsH As FileStream   'Headers stream 
    Private fsT As FileStream   'Texts stream    
    Private brH As BinaryReader 'Read headers
    Private brT As BinaryReader 'Read texts
    Private wrH As BinaryWriter 'Write headers
    Private wrT As BinaryWriter 'Write texts
    Private fsI As FileStream   'Index
    Private brI As BinaryReader 'Index reader

    Private ffsI As String      'filename for index
    Private ffsL As String      'filename for lastread
    Private FrameOffsets() As sqIdxType 'Offset Cache
    Private enc As Encoding = Encoding.GetEncoding(866)
    Private dtUNIX_DATE As Date = DateTime.Parse("01.01.1970 00:00:00")
    Private Kluges As String  'Кладжи текущего письма
    Private SeenBy As String  'SeenBy's текущего письма

#End Region

    Public ReadOnly Property BaseType() As GfeCore.IDatabasesTypes.enmBaseType Implements GfeCore.IDatabases.BaseType
        Get
            Return IDatabasesTypes.enmBaseType.Squish
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
    Public Sub GetHeadesByNum(ByVal NumberMessage As Integer) Implements GfeCore.IDatabases.GetHeadesByNum
        If NumberMessage > numMessages Then
            Exit Sub
        ElseIf NumberMessage = 0 Then
            Exit Sub
        End If
        Try
            fsH.Seek(FrameOffsets(NumberMessage - 1).Offset + 28, SeekOrigin.Begin) 'Seek to message header
            msgFlags = brH.ReadInt32
            msgFrom = enc.GetString(brH.ReadBytes(SQMSG_FROM_SIZE), 0, SQMSG_FROM_SIZE).Replace(Chr(0), "")
            msgTo = enc.GetString(brH.ReadBytes(SQMSG_TO_SIZE), 0, SQMSG_TO_SIZE).Replace(Chr(0), "")
            msgSubj = enc.GetString(brH.ReadBytes(SQMSG_SUBJ_SIZE), 0, SQMSG_SUBJ_SIZE).Replace(Chr(0), "")
            msgFromAddr = CStr(brH.ReadInt16) & ":" & CStr(brH.ReadInt16) & "/" & CStr(brH.ReadInt16) & "." & CStr(brH.ReadInt16)
            msgToAddr = CStr(brH.ReadInt16) & ":" & CStr(brH.ReadInt16) & "/" & CStr(brH.ReadInt16) & "." & CStr(brH.ReadInt16)
            msgDateWritten = brH.ReadInt32
            msgDateArrived = brH.ReadInt32
            'msgReplayTo = brH.ReadInt32
            'msgReplayTo = GetReplayNumberByuMsgId(msgReplayTo)
            'msgReplayFirst = brH.ReadInt32
            'msgReplayFirst = GetReplayNumberByuMsgId(ReplayFirst)
            'msgdate = enc.GetString(brH.ReadBytes(20), 0, 20).Replace(Chr(0), "")
        Catch ex As Exception
            MsgBox("Ошибка чтения заголовков сообщений" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Public Sub GetHeadesByNumAll(ByVal NumberMessage As Integer) Implements GfeCore.IDatabases.GetHeadesByNumAll

    End Sub
    Public Sub GetHeadesByNumForTree(ByVal NumberMessage As Integer) Implements GfeCore.IDatabases.GetHeadesByNumForTree

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
                msgn = GetMessageNumberBYuMsgId(brL.ReadInt32)
            End If

        Else 'сохраняем состояние
            If fsL.Length <> 0 Then
                bwL = New BinaryWriter(fsL)
                msgNumber = FrameOffsets(msgNumber - 1).uMsgId
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
        End If
        If NumberMessage = 0 Then
            Exit Sub
        End If

        Dim flen As Integer, strs() As String, tmp As String = ""

        Try
            fsH.Seek(FrameOffsets(NumberMessage - 1).Offset + 12, SeekOrigin.Begin) 'Seek to frame_length
            flen = brH.ReadInt32
            fsH.Seek(12 + 238, SeekOrigin.Current) 'To message text
            tmp = enc.GetString(brH.ReadBytes(flen - 238), 0, flen - 238).Replace(Chr(0), vbCr)
        Catch ex As Exception
            MsgBox("Ошибка чтения текста сообщений" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        End Try

        msgText = ""
        strs = tmp.Split(vbCr)
        For flen = 0 To strs.Length - 1
            If strs(flen) <> "" Then                
                If strs(flen).Substring(0, 1) = CStr(Chr(1)) Then
                    Kluges &= strs(flen) & vbCr
                ElseIf strs(flen).Length > 8 Then
                    If strs(flen).Substring(0, 8) = "SEEN-BY:" Then
                        SeenBy &= strs(flen) & vbCr
                    Else
                        msgText &= strs(flen) & vbCr
                    End If
                End If
            Else
                msgText &= vbCr
            End If
        Next
       
    End Sub
    Public Function GetMessageDumpByNum(ByVal NumberMessage As Integer) As String Implements GfeCore.IDatabases.GetMessageDumpByNum
        Return ""
    End Function
    Public Function GetMessageKlugeByNum(ByVal NumberMessage As Integer) As String Implements GfeCore.IDatabases.GetMessageKlugeByNum
        Return Kluges & vbCrLf & SeenBy
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
            Dim num As Integer
            Dim fs As Stream
            Dim br As BinaryReader

            Try
                fs = New FileStream(EchoPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
                br = New BinaryReader(fs)

                If fs.Length <> 0 Then
                    fs.Seek(4, SeekOrigin.Begin)
                    num = br.ReadInt32
                End If

            Catch e As System.IO.FileNotFoundException
                MsgBox("Файл " & EchoPath & " не найден.", MsgBoxStyle.Exclamation)
                Return 0
            Catch ex As Exception
                MsgBox("Ошибка чтения! " & ex.Message, MsgBoxStyle.Exclamation)
                Return 0
            End Try

            br = Nothing
            fs.Close()

            If num > 0 Then
                Return num
            Else
                Return 0
            End If

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

        ffsI = Mid$(DBName, 1, InStr(DBName, ".sqd", CompareMethod.Text)) & "sqi"
        ffsL = Mid$(DBName, 1, InStr(DBName, ".sqd", CompareMethod.Text)) & "sql"
        numMessages = Me.MessageCountByEcho(strDBname)

        Try
            fsH = New FileStream(strDBname, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            brH = New BinaryReader(fsH)
            wrH = New BinaryWriter(fsH)
        Catch e As System.IO.FileNotFoundException
            MsgBox("Файл заголовков: " & strDBname & " не найден.")
            Exit Sub
        Catch
            Exit Sub
        End Try

        Try
            fsI = New FileStream(ffsI, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            brI = New BinaryReader(fsI)
        Catch e As System.IO.FileNotFoundException
            MsgBox("Файл индексов: " & ffsI & " не найден.")
            Exit Sub
        Catch ex As Exception
            MsgBox("OpenDB::" & ex.Message)
            Exit Sub
        End Try

        'Кешируем индексы для быстрого поиска сообщения\фрейма по номеру
        Me.CacheSqIndex()

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
            'null for msg
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
            Return msgSubj
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
    ''' <remarks></remarks>
    Sub New()
        bolDefault = True
    End Sub

    ''' <summary>
    ''' Создает экземпляр класса и сразу загружает базу
    ''' </summary>
    ''' <param name="DbPath"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal DbPath As String)
        strDBname = DbPath
        OpenDB()
    End Sub

#Region "Private methods"

    ''' <summary>
    ''' Кеширует индексы фреймов для быстрого поиска сообщения по номеру
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CacheSqIndex()
        Dim i, n, offset, msguid, hash As Integer
        Dim frtype As Short

        While i < fsI.Length \ 12
            offset = brI.ReadInt32
            msguid = brI.ReadInt32
            hash = brI.ReadInt32

            fsH.Seek(offset + 24, SeekOrigin.Begin)     'To Frame_type
            frtype = brH.ReadInt16

            If frtype = sqFrameType.FRAME_NORMAL Then
                ReDim Preserve FrameOffsets(n)
                With FrameOffsets(n)
                    .Offset = offset
                    .uMsgId = msguid
                    .Hash = hash
                End With
                n += 1
            End If

            i += 1
        End While
    End Sub

    ''' <summary>
    ''' Возвращает порядковый номер мессага по его uMsgId из кеша
    ''' </summary>
    ''' <param name="uMsgId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetMessageNumberBYuMsgId(ByVal uMsgId As Integer) As Integer

        If uMsgId > 0 Then
            For i As Integer = 0 To FrameOffsets.Length - 1
                If FrameOffsets(i).uMsgId = uMsgId Then
                    Return i + 1
                    Exit Function
                End If
            Next
        End If

        Return 0

    End Function

#End Region

#Region "ModuleInfo"
    Public Function GetModuleIcon() As System.Drawing.Image Implements GfeCore.IDatabases.GetModuleIcon
        Return My.Resources.ModuleIcon.ToBitmap
    End Function

    Public ReadOnly Property Description() As String Implements GfeCore.IModuleInfo.Description
        Get
            Return "Squish Module"
        End Get
    End Property

    Public ReadOnly Property Name() As String Implements GfeCore.IModuleInfo.Name
        Get
            Return "squBase"
        End Get
    End Property
#End Region

    Private disposed As Boolean = False

    ' IDisposable
    Private Overloads Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposed Then
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
