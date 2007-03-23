Option Explicit On

Public Class Database
    Implements IDatabases

#Region "API"
    'Private Declare Sub RtlMoveMemory Lib "kernel32.dll" (ByRef dst As Any, ByRef Src As Any, ByVal cb As Integer)
    Private Declare Function CreateFile Lib "kernel32" Alias "CreateFileA" (ByVal lpFileName As String, ByVal dwDesiredAccess As Integer, ByVal dwShareMode As Integer, ByVal lpSecurityAttributes As Integer, ByVal dwCreationDisposition As Integer, ByVal dwFlagsAndAttributes As Integer, ByVal hTemplateFile As Integer) As Integer
    Private Declare Function ReadFile Lib "kernel32" (ByVal hFile As Integer, ByRef lpBuffer As Integer, ByVal nNumberOfBytesToRead As Integer, ByVal lpNumberOfBytesRead As Integer, ByVal lpOverlapped As Integer) As Integer
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

    '~~~~~~~~~~~~~~~~~~~~~���������� ��� �������
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
        msgFrom = "Xeon"
        msgTo = "All"
        msgSubj = "Squish TeZt"
    End Sub

    Public Sub GetHeadesByNumAll(ByVal NumberMessage As Integer) Implements GfeCore.IDatabases.GetHeadesByNumAll

    End Sub

    Public Sub GetHeadesByNumForTree(ByVal NumberMessage As Integer) Implements GfeCore.IDatabases.GetHeadesByNumForTree

    End Sub

    Public Function GetLastReadMsgNum(Optional ByVal msgNumber As Integer = 0) As Integer Implements GfeCore.IDatabases.GetLastReadMsgNum

    End Function

    Public Sub GetMessageByNum(ByVal NumberMessage As Integer) Implements GfeCore.IDatabases.GetMessageByNum

    End Sub

    Public Function GetMessageDumpByNum(ByVal NumberMessage As Integer) As String Implements GfeCore.IDatabases.GetMessageDumpByNum
        Return ""
    End Function

    Public Function GetMessageKlugeByNum(ByVal NumberMessage As Integer) As String Implements GfeCore.IDatabases.GetMessageKlugeByNum
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
            Dim ff, hDb As Integer

            hDb = CreateFile(EchoPath, GENERIC_READ, FILE_SHARE_READ, 0, OPEN_EXISTING, 0, 0)

            If hDb < 0 Then
                'err.Number = GetLastError() '���� ��������
                'ApiErrorLookup(GetLastError, "sqBase::MessageCountByEcho")
                Exit Property '�� ���� �������...
            End If

            '���������
            If SetFilePointer(hDb, 4, 0, FILE_BEGIN) = 0 Then
                'ApiErrorLookup(GetLastError, "sqBase::MessageCountByEcho")
                CloseHandle(hDb)
                MessageCountByEcho = 0
                Exit Property
            End If

            ReadFile(hDb, ff, 4, 0, 0)

            If ReadFile(hDb, ff, 4, 0, 0) = 0 Then
                'ApiErrorLookup(GetLastError, "sqBase::MessageCountByEcho")
                CloseHandle(hDb)
                MessageCountByEcho = 0
                Exit Property
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
            Return ""
        End Get
        Set(ByVal value As String)
            msgText = value
        End Set
    End Property

    Public Sub OpenDB() Implements GfeCore.IDatabases.OpenDB

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

    '����������� "�� ���������"
    Sub New()
        bolDefault = True
    End Sub

    '������� ��������� ������ � ����� ��������� ����
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
