Option Explicit On

Imports System.IO
Imports System.Text

Public Class Database
    Implements IDatabases

    'заголовок файлов *.msg
    Private Structure MessageHeader
        <VBFixedString(36)> Public FromUserName As String   '0
        <VBFixedString(36)> Public ToUserName As String     '36
        <VBFixedString(72)> Public Subject As String        '72
        <VBFixedString(20)> Public DateTime As String       '144
        Dim TimedRead As Short                              '164
        Dim DestNode As Short                               '166
        Dim OrigNode As Short                               '168
        Dim Cost As Short                                   '170
        Dim OrigNet As Short                                '172
        Dim DestNet As Short                                '174
        Dim Date_Written As Integer                         '176
        Dim Date_Arrived As Integer                         '180
        Dim ReplyTo As Short                                '184
        Dim Attribute As Short                              '186
        Dim ReplyNext As Short                              '188
        'далее идет текст мессага оканчивающийся нулем.
    End Structure

    '~~~~~~~~~~~~~~~~~~~~~переменные для свойств
    Private strDBname As String         'local copy
    Private strEchoName As String       'local copy
    Private numMessages As Integer      'local copy
    Private msgFrom As String           'local copy
    Private msgFromAddr As String       'local copy
    Private msgTo As String             'local copy
    Private msgToAddr As String         'local copy
    Private msgDateTime As String       'local copy
    Private msgDateWritten As Integer   'local copy
    Private msgDateArrived As Integer   'local copy
    Private msgSubj As String           'local copy
    Private msgText As String = ""      'local copy
    Private msgFlags As Integer         'local copy
    Private msgReplayTo As Integer      'local copy
    Private msgReplayFirst As Integer   'local copy
    Private msgReplayNext As Integer    'local copy
    Private bolDefault As Boolean

    Private targetEncoding As Encoding = Encoding.GetEncoding(866)
    Private Messages As String()    'имена файлов с мессагами

    Public ReadOnly Property BaseType() As GfeCore.IDatabasesTypes.enmBaseType Implements GfeCore.IDatabases.BaseType
        Get
            Return IDatabasesTypes.enmBaseType.Fido
        End Get
    End Property

    Public Property DateArrived() As Integer Implements GfeCore.IDatabases.DateArrived
        Get
            Return DateDiff(DateInterval.Second, #1/1/1970#, DateValue(msgDateTime))
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

    Public Sub DeleteMessageByNum(ByRef NumberMessage As Integer) Implements GfeCore.IDatabases.DeleteMessageByNum

    End Sub

    Public Property EchoName() As String Implements GfeCore.IDatabases.EchoName
        Get
            Return strDBname
        End Get
        Set(ByVal value As String)
            strDBname = value
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

    Public Sub GetHeadesByNum(ByRef NumberMessage As Integer) Implements GfeCore.IDatabases.GetHeadesByNum
        If NumberMessage > numMessages Then
            Exit Sub
        ElseIf NumberMessage = 0 Then
            Exit Sub
        End If

        Dim fsM As Stream
        Dim brM As BinaryReader

        Try
            fsM = New FileStream(strDBname & "\" & Messages(NumberMessage - 1), FileMode.Open)
            brM = New BinaryReader(fsM)
        Catch e As System.IO.FileNotFoundException
            MsgBox("Файл " & strDBname & "\" & Messages(NumberMessage - 1) & " не найден.", MsgBoxStyle.Exclamation)
            Exit Sub
        Catch
            Exit Sub
            '
        End Try

        msgFrom = targetEncoding.GetString(brM.ReadBytes(36), 0, 36).Replace(Chr(0), "")
        msgTo = targetEncoding.GetString(brM.ReadBytes(36), 0, 36).Replace(Chr(0), "")
        msgSubj = targetEncoding.GetString(brM.ReadBytes(72), 0, 72).Replace(Chr(0), "")
        msgDateTime = targetEncoding.GetString(brM.ReadBytes(20), 0, 20).Replace(Chr(0), "")
        fsM.Seek(2, SeekOrigin.Current)

        Dim DestNode As Integer = brM.ReadInt16
        Dim OrigNode As Integer = brM.ReadInt16
        fsM.Seek(2, SeekOrigin.Current)
        Dim OrigNet As Integer = brM.ReadInt16
        Dim DestNet As Integer = brM.ReadInt16

        msgFromAddr = "2" & ":" & OrigNet & "/" & OrigNode
        msgToAddr = "2" & ":" & DestNet & "/" & DestNode
        msgDateWritten = brM.ReadInt32
        msgDateArrived = brM.ReadInt32
        msgReplayTo = brM.ReadInt16
        msgFlags = brM.ReadInt16
        msgReplayNext = brM.ReadInt16

        fsM.Close()
        fsM = Nothing

    End Sub

    Public Sub GetHeadesByNumAll(ByRef NumberMessage As Integer) Implements GfeCore.IDatabases.GetHeadesByNumAll

    End Sub

    Public Sub GetHeadesByNumForTree(ByRef NumberMessage As Integer) Implements GfeCore.IDatabases.GetHeadesByNumForTree
        If NumberMessage > numMessages Then
            Exit Sub
        ElseIf NumberMessage = 0 Then
            Exit Sub
        End If

        Dim fsM As Stream
        Dim brM As BinaryReader

        Try
            fsM = New FileStream(strDBname & "\" & Messages(NumberMessage - 1), FileMode.Open)
            brM = New BinaryReader(fsM)
        Catch e As System.IO.FileNotFoundException
            MsgBox("Файл " & strDBname & "\" & Messages(NumberMessage - 1) & " не найден.", MsgBoxStyle.Exclamation)
            Exit Sub
        Catch
            Exit Sub
            '
        End Try

        msgFrom = targetEncoding.GetString(brM.ReadBytes(36), 0, 36).Replace(Chr(0), "")
        msgTo = targetEncoding.GetString(brM.ReadBytes(36), 0, 36).Replace(Chr(0), "")
        msgSubj = targetEncoding.GetString(brM.ReadBytes(72), 0, 72).Replace(Chr(0), "")
        fsM.Seek(40, SeekOrigin.Current)
        msgReplayTo = brM.ReadInt16
        fsM.Seek(2, SeekOrigin.Current)
        msgReplayNext = brM.ReadInt16

        fsM.Close()
        fsM = Nothing

    End Sub

    Public Function GetLastReadMsgNum(Optional ByRef msgNumber As Integer = 0) As Integer Implements GfeCore.IDatabases.GetLastReadMsgNum

    End Function

    Public Sub GetMessageByNum(ByRef NumberMessage As Integer) Implements GfeCore.IDatabases.GetMessageByNum
        If NumberMessage > numMessages Then
            Exit Sub
        ElseIf NumberMessage = 0 Then
            Exit Sub
        End If

        Dim fsM As Stream
        Dim brM As BinaryReader

        Try
            fsM = New FileStream(strDBname & "\" & Messages(NumberMessage - 1), FileMode.Open)
            brM = New BinaryReader(fsM)
        Catch e As System.IO.FileNotFoundException
            MsgBox("Файл " & strDBname & "\" & Messages(NumberMessage - 1) & " не найден.", MsgBoxStyle.Exclamation)
            Exit Sub
        Catch
            Exit Sub
            '
        End Try

        fsM.Seek(190, SeekOrigin.Begin)
        msgText = targetEncoding.GetString(brM.ReadBytes(fsM.Length - 190), 0, fsM.Length - 190).Replace(Chr(0), "")

        fsM.Close()
        fsM = Nothing

    End Sub

    Public Function GetMessageDumpByNum(ByRef NumberMessage As Integer) As String Implements GfeCore.IDatabases.GetMessageDumpByNum
        Return ""
    End Function

    Public Function GetMessageKlugeByNum(ByRef NumberMessage As Integer) As String Implements GfeCore.IDatabases.GetMessageKlugeByNum
        Return ""
    End Function

    Public Property MessageCount() As Integer Implements GfeCore.IDatabases.MessageCount
        Get
            Return Me.MessageCountByEcho(strDBname)
        End Get
        Set(ByVal value As Integer)
            numMessages = value
        End Set
    End Property

    Public ReadOnly Property MessageCountByEcho(ByVal EchoPath As String) As Integer Implements GfeCore.IDatabases.MessageCountByEcho
        Get
            Try
                Dim DirZ As New DirectoryInfo(EchoPath)
                Dim msgs As FileInfo() = DirZ.GetFiles("*.msg")
                Dim i As Integer

                ReDim Messages(msgs.Length)
                For Each msg As FileInfo In msgs
                    Messages(i) = msg.Name
                    i += 1
                Next

                Return msgs.Length


            Catch ex As DirectoryNotFoundException
                MsgBox("Каталог " & EchoPath & " не найден!", MsgBoxStyle.Exclamation, My.Application.Info.Title)

            Catch ex As Exception
                MsgBox("Ошибка: " & ex.Message & vbCrLf & "Где-то в " & ex.Source, MsgBoxStyle.Exclamation, My.Application.Info.Title)
            End Try

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

    Public Function MessageStatus(ByRef NumberMessage As Integer, Optional ByRef Status As Integer = -1) As Integer Implements GfeCore.IDatabases.MessageStatus

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
        numMessages = Me.MessageCountByEcho(strDBname)

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

    ''' <summary >
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
            Return "Netmail Module"
        End Get
    End Property

    Public ReadOnly Property Name() As String Implements GfeCore.IModuleInfo.Name
        Get
            Return "msgBase"
        End Get
    End Property
#End Region

    Private disposed As Boolean = False

    ' IDisposable
    Private Overloads Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposed Then
            If disposing Then
                ' TODO: put code to dispose managed resources
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
