Option Explicit On
Imports System.Data
Imports Npgsql
Imports System.Text

Public Class Database
    Implements IDatabases

    '~~~~~~~~~~~~~~~~~~~~~переменные для свойств
    Private strDBname As String         'local copy
    Private strEchoName As String       'local copy
    Private numMessages As Integer      'local copy
    Private msgFrom As String = ""      'local copy
    Private msgFromAddr As String = ""  'local copy
    Private msgTo As String = ""        'local copy
    Private msgToAddr As String = ""    'local copy
    Private msgDateWritten As Integer   'local copy
    Private msgDateArrived As Integer   'local copy
    Private msgSubj As String = ""      'local copy
    Private msgText As String = ""      'local copy
    Private msgFlags As Integer         'local copy
    Private msgReplayTo As Integer      'local copy
    Private msgReplayFirst As Integer   'local copy
    Private msgReplayNext As Integer    'local copy
    Private bolDefault As Boolean
    Private sqlConn As NpgsqlConnection
    Private unixtime As Date = DateTime.Parse("01.01.1970 00:00:00")

    Public ReadOnly Property BaseType() As IDatabasesTypes.enmBaseType Implements IDatabases.BaseType
        Get
            Return IDatabasesTypes.enmBaseType.SQL
        End Get
    End Property
    Public Property DateArrived() As Integer Implements IDatabases.DateArrived
        Get
            Return msgDateArrived
        End Get
        Set(ByVal value As Integer)
            msgDateArrived = value
        End Set
    End Property
    Public Property DateWritten() As Integer Implements IDatabases.DateWritten
        Get
            Return msgDateWritten
        End Get
        Set(ByVal value As Integer)
            msgDateWritten = value
        End Set
    End Property
    ''' <summary>
    ''' Строка подключения к БД
    ''' </summary>
    ''' <value>
    ''' Server:                     Address/Name of Postgresql Server;
    ''' Port:                       Port to connect to;
    ''' Protocol:                   Protocol version to use, instead of automatic; Integer 2 or 3;
    ''' Database:                   Database name. Defaults to user name if not specified;
    ''' User Id:                    User name;
    ''' Password:                   Password for clear text authentication;
    ''' SSL:                        True or False. Controls whether to attempt a secure connection. Default = False;
    ''' Pooling:                    True or False. Controls whether connection pooling is used. Default = True;
    ''' MinPoolSize:                Min size of connection pool. Default: 1;
    ''' MaxPoolSize:                Max size of connection pool. Default: 20;
    ''' Encoding:                   Encoding to be used; Can be ASCII or UNICODE. Default is ASCII. Use UNICODE if you are having problems with accents.
    ''' Timeout:                    Time to wait for connection open in seconds. Default is 15.
    ''' CommandTimeout:             Time to wait for command to finish execution before throw an exception. In seconds. Default is 20.
    ''' Sslmode:                    Mode for ssl connection control. 
    ''' ConnectionLifeTime:         Time to wait before closing unused connections in the pool in seconds. Default is 15.
    ''' SyncNotification:           Specifies if Npgsql should use synchronous notifications
    ''' Encoding can be ASCII or UNICODE. If your application uses characters with accents and with default settings it doesn't work, try changing that.
    ''' Min pool size when specified will make NpgsqlConnection pre allocates this number of connections with the server.
    ''' Sslmode can be one of the following values: 
    '''  Prefer - If it is possible to connect using ssl, it will be used.
    ''' Require - If an ssl connection cannot be made, an exception is thrown.
    ''' Allow - Not supported yet, just connects without ssl.
    ''' Disable - No ssl connection is done.
    ''' Default is Disable.
    ''' </value>
    ''' <returns></returns>
    ''' <remarks>example: "Server=127.0.0.1;Port=5432;User Id=joe;Password=secret;Database=joedata;"</remarks>
    Public Property DBName() As String Implements IDatabases.DBName
        Get
            Return strDBname
        End Get
        Set(ByVal value As String)
            strDBname = value
        End Set
    End Property
    Public Sub DeleteMessageByNum(ByVal NumberMessage As Integer) Implements IDatabases.DeleteMessageByNum
        '
    End Sub
    Public Property EchoName() As String Implements IDatabases.EchoName
        Get
            Return strEchoName
        End Get
        Set(ByVal value As String)
            strEchoName = value
        End Set
    End Property
    Public Property From() As String Implements IDatabases.From
        Get
            Return msgFrom
        End Get
        Set(ByVal value As String)
            msgFrom = value
        End Set
    End Property
    Public Property FromAddr() As String Implements IDatabases.FromAddr
        Get
            Return msgFromAddr
        End Get
        Set(ByVal value As String)
            msgFromAddr = value
        End Set
    End Property

    Public Sub GetHeadesByNum(ByVal NumberMessage As Integer) Implements IDatabases.GetHeadesByNum
        If IsNothing(sqlConn) Then
            Exit Sub
        End If

        If sqlConn.State = ConnectionState.Closed Then
            sqlConn.Open()
        End If

        Dim Command As New NpgsqlCommand("""GetMessageHeaders""(:echo,:msg);", sqlConn), dr As NpgsqlDataReader
        Command.CommandType = CommandType.StoredProcedure
        Command.Parameters.Add(New NpgsqlParameter("echo", DbType.String))
        Command.Parameters.Add(New NpgsqlParameter("msg", DbType.Int32))
        Command.Parameters(0).Value = strEchoName
        Command.Parameters(1).Value = NumberMessage
        dr = Command.ExecuteReader
        dr.Read()
        With Me
            'dr("column_name") - весьма медленный метод
            'исспользование в циклах dr.GetOrdinal("column_name") значительно эффективнее
            .From = dr("fromname")
            .FromAddr = dr("fromaddr")
            .To = dr("toname")
            .ToAddr = dr("toaddr")
            .Subject = Encoding.GetEncoding(866).GetString(Encoding.Default.GetBytes(dr("subject")))
            .DateArrived = DateTime.Parse(dr("msgdate")).Subtract(unixtime).TotalSeconds
            .DateWritten = .DateArrived
            .MessageFlags = dr("attr")
            .ReplayTo = dr("replayid")
        End With
    End Sub

    Public Sub GetHeadesByNumAll(ByVal NumberMessage As Integer) Implements IDatabases.GetHeadesByNumAll
        If IsNothing(sqlConn) Then
            Exit Sub
        End If

    End Sub

    Public Sub GetHeadesByNumForTree(ByVal NumberMessage As Integer) Implements IDatabases.GetHeadesByNumForTree
        If IsNothing(sqlConn) Then
            Exit Sub
        End If

    End Sub

    Public Function GetLastReadMsgNum(Optional ByVal msgNumber As Integer = 0) As Integer Implements IDatabases.GetLastReadMsgNum
        If IsNothing(sqlConn) Then
            Exit Function
        End If

    End Function

    Public Sub GetMessageByNum(ByVal NumberMessage As Integer) Implements IDatabases.GetMessageByNum
        If IsNothing(sqlConn) Then
            Exit Sub
        End If

    End Sub

    Public Function GetMessageDumpByNum(ByVal NumberMessage As Integer) As String Implements IDatabases.GetMessageDumpByNum
        Return ""
    End Function

    Public Function GetMessageKlugeByNum(ByVal NumberMessage As Integer) As String Implements IDatabases.GetMessageKlugeByNum
        Return ""
    End Function

    Public Property MessageCount() As Integer Implements IDatabases.MessageCount
        Get
            Return Me.MessageCountByEcho(strEchoName)
        End Get
        Set(ByVal value As Integer)
            numMessages = value
        End Set
    End Property

    Public ReadOnly Property MessageCountByEcho(ByVal EchoPath As String) As Integer Implements IDatabases.MessageCountByEcho
        Get
            Dim Command As NpgsqlCommand, result As Object

            If IsNothing(sqlConn) Then
                sqlConn = New NpgsqlConnection(EchoPath)
            End If

            If sqlConn.State = ConnectionState.Closed Then
                sqlConn.Open()
            End If

            Try
                Command = New NpgsqlCommand("""GetMessageCount""('" & strEchoName & "')", sqlConn)
                Command.CommandType = CommandType.StoredProcedure
                result = Command.ExecuteScalar()                
                Return CInt(result)
            Catch ex As Exception
                '
            End Try            
        End Get
    End Property

    Public Property MessageFlags() As Integer Implements IDatabases.MessageFlags
        Get
            Return msgFlags
        End Get
        Set(ByVal value As Integer)
            msgFlags = value
        End Set
    End Property

    Public Function MessageStatus(ByVal NumberMessage As Integer, Optional ByVal Status As Integer = -1) As Integer Implements IDatabases.MessageStatus

    End Function

    Public Property MessageText() As String Implements IDatabases.MessageText
        Get
            Return ""
        End Get
        Set(ByVal value As String)
            msgText = value
        End Set
    End Property

    Public Sub OpenDB() Implements IDatabases.OpenDB
        Try
            sqlConn = New NpgsqlConnection(strDBname)
        Catch ex As Exception

        End Try
    End Sub

    Public Property ReplayFirst() As Integer Implements IDatabases.ReplayFirst
        Get
            Return msgReplayFirst
        End Get
        Set(ByVal value As Integer)
            msgReplayFirst = value
        End Set
    End Property
    Public Property ReplayNext() As Integer Implements IDatabases.ReplayNext
        Get
            Return msgReplayNext
        End Get
        Set(ByVal value As Integer)
            msgReplayNext = value
        End Set
    End Property
    Public Property ReplayNextS() As String Implements IDatabases.ReplayNextS
        Get
            Return ""
        End Get
        Set(ByVal value As String)
            'null for msg
        End Set
    End Property
    Public Property ReplayTo() As Integer Implements IDatabases.ReplayTo
        Get
            Return msgReplayTo
        End Get
        Set(ByVal value As Integer)
            msgReplayTo = value
        End Set
    End Property
    Public Property Subject() As String Implements IDatabases.Subject
        Get
            Return msgSubj
        End Get
        Set(ByVal value As String)
            msgSubj = value
        End Set
    End Property
    Public Property [To]() As String Implements IDatabases.To
        Get
            Return msgTo
        End Get
        Set(ByVal value As String)
            msgTo = value
        End Set
    End Property
    Public Property ToAddr() As String Implements IDatabases.ToAddr
        Get
            Return msgToAddr
        End Get
        Set(ByVal value As String)
            msgToAddr = value
        End Set
    End Property

    Public Function WriteMessage() As Integer Implements IDatabases.WriteMessage

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
    ''' <param name="DbPath">Строка подключения к базе</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal DbPath As String)
        strDBname = DbPath
        OpenDB()
    End Sub

#Region "ModuleInfo"
    Public Function GetModuleIcon() As System.Drawing.Image Implements IDatabases.GetModuleIcon
        Return My.Resources.ModuleIcon.ToBitmap
    End Function

    Public ReadOnly Property Description() As String Implements IModuleInfo.Description
        Get
            Return "PostgreSQL Base Module"
        End Get
    End Property

    Public ReadOnly Property Name() As String Implements IModuleInfo.Name
        Get
            Return "pgsqlBase"
        End Get
    End Property
#End Region

#Region " IDisposable Support "
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
