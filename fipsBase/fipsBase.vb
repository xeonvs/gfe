Option Explicit On

Public Class Database
    Implements IDatabases

#Region "API"
#End Region

    '~~~~~~~~~~~~~~~~~~~~~переменные дл€ свойств
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
            Return IDatabasesTypes.enmBaseType.FIPS
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

    Public Sub DeleteMessageByNum(ByRef NumberMessage As Integer) Implements GfeCore.IDatabases.DeleteMessageByNum

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

    Public Sub GetHeadesByNum(ByRef NumberMessage As Integer) Implements GfeCore.IDatabases.GetHeadesByNum
        msgFrom = "Xeon"
        msgTo = "All"
        msgSubj = "FIPS TeZt"
    End Sub

    Public Sub GetHeadesByNumAll(ByRef NumberMessage As Integer) Implements GfeCore.IDatabases.GetHeadesByNumAll

    End Sub

    Public Sub GetHeadesByNumForTree(ByRef NumberMessage As Integer) Implements GfeCore.IDatabases.GetHeadesByNumForTree

    End Sub

    Public Function GetLastReadMsgNum(Optional ByRef msgNumber As Integer = 0) As Integer Implements GfeCore.IDatabases.GetLastReadMsgNum

    End Function

    Public Sub GetMessageByNum(ByRef NumberMessage As Integer) Implements GfeCore.IDatabases.GetMessageByNum

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
            Return 0
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

    'конструктор "по умолчанию"
    Sub New()
        bolDefault = True
    End Sub

    '—оздает экземпл€р класса и сразу загружает базу
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
            Return "FIPS Module"
        End Get
    End Property

    Public ReadOnly Property Name() As String Implements GfeCore.IModuleInfo.Name
        Get
            Return "fipsBase"
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
