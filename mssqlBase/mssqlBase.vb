Option Explicit On
Imports System.Data
Imports System.Text
Imports System.Data.SqlClient

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
    Private serverCodePage As Integer
    Private sqlConn As SqlConnection
    Private unixtime As Date = DateTime.Parse("01.01.1970 00:00:00")

#Region "Operators and params"
    Dim msgCount As New SqlCommand("dbo.[GetMessageCount]")
    Dim hdrCommand As New SqlCommand("GetMessageHeaders")
    Dim msgCommand As New SqlCommand("GetMessage")
    Dim echoNameParam As New SqlParameter("@echo", DbType.String)
    Dim msgNumParam As New SqlParameter("@msgnum", DbType.Int32)
    
    Dim lrGetCommand As New SqlCommand("SELECT LastreadMsgId From Areas WHERE AreaName LIKE @echo")
    Dim lrSetCommand As New SqlCommand("UPDATE Areas SET LastreadMsgId = @msgnum  WHERE AreaName LIKE @echo")

#End Region

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

        If sqlConn.State Then
            sqlConn.Open()
        End If

        If hdrCommand.Parameters.Count = 0 Then
            hdrCommand.CommandType = CommandType.StoredProcedure
            hdrCommand.Parameters.Add(echoNameParam)
            hdrCommand.Parameters.Add(msgNumParam)
        End If

        Dim dr As SqlDataReader
        hdrCommand.Connection = sqlConn        
        hdrCommand.Parameters(0).Value = strEchoName
        hdrCommand.Parameters(1).Value = NumberMessage
        dr = hdrCommand.ExecuteReader
        dr.Read()
            'dr("column_name") - весьма медленный метод
        'исспользование в циклах dr.GetOrdinal("column_name") значительно эффективнее
        msgFrom = dr("fromname")
        msgFromAddr = dr("fromaddr")
        msgTo = dr("toname")
        msgToAddr = dr("toaddr")
        If serverCodePage <> Encoding.Default.CodePage Then
            msgSubj = Encoding.GetEncoding(serverCodePage).GetString(Encoding.Default.GetBytes(dr("subject")))
        Else
            msgSubj = dr("subject")
        End If
        msgDateArrived = DateTime.Parse(dr("msgdate")).Subtract(unixtime).TotalSeconds
        msgDateWritten = msgDateArrived
        msgFlags = dr("attr")
        msgReplayTo = dr("replayid")

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

    ''' <summary>
    ''' Отображает\сохраняет статус последнего прочитанного письма.
    ''' </summary>
    ''' <param name="msgNumber"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetLastReadMsgNum(Optional ByVal msgNumber As Integer = 0) As Integer Implements IDatabases.GetLastReadMsgNum
        If IsNothing(sqlConn) Then
            Exit Function
        End If

        If sqlConn.State = ConnectionState.Closed Then
            sqlConn.Open()
        End If

        If msgNumber = 0 Then
            'read
            Try
                If lrGetCommand.Parameters.Count = 0 Then
                    lrGetCommand.Parameters.Add(echoNameParam)
                End If
                lrGetCommand.Connection = sqlConn
                lrGetCommand.Parameters(0).Value = strEchoName
                Return CInt(lrGetCommand.ExecuteScalar())
            Catch ex As Exception
                Return -1
            End Try
        Else
            'write
            Try
                If lrSetCommand.Parameters.Count = 0 Then
                    lrSetCommand.Parameters.Add(echoNameParam)
                    lrSetCommand.Parameters.Add(msgNumParam)
                End If
                lrSetCommand.Parameters(0).Value = strEchoName
                lrSetCommand.Parameters(1).Value = msgNumber
                lrSetCommand.Connection = sqlConn
                lrSetCommand.ExecuteNonQuery()
                Return 0
            Catch ex As Exception
                Return -1
            End Try
        End If

    End Function

    Public Sub GetMessageByNum(ByVal NumberMessage As Integer) Implements IDatabases.GetMessageByNum
        If IsNothing(sqlConn) Then
            Exit Sub
        End If

        If sqlConn.State = ConnectionState.Closed Then
            sqlConn.Open()            
        End If

        If msgCommand.Parameters.Count = 0 Then
            msgCommand.CommandType = CommandType.StoredProcedure
            msgCommand.Parameters.Add(echoNameParam)
            msgCommand.Parameters.Add(msgNumParam)
        End If

        Dim dr As SqlDataReader
        msgCommand.Connection = sqlConn
        msgCommand.Parameters(0).Value = strEchoName
        msgCommand.Parameters(1).Value = NumberMessage
        dr = msgCommand.ExecuteReader
        dr.Read()
        'dr("column_name") - весьма медленный метод
        'исспользование в циклах dr.GetOrdinal("column_name") значительно эффективнее
        If serverCodePage <> Encoding.Default.CodePage Then
            msgText = Encoding.GetEncoding(serverCodePage).GetString(Encoding.Default.GetBytes(dr("messagetext")))
        Else
            msgText = dr("messagetext")
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
            If IsNothing(sqlConn) Then
                sqlConn = New SqlConnection(EchoPath)
            End If

            If sqlConn.State = ConnectionState.Closed Then
                sqlConn.Open()
            End If

            Try
                If msgCount.Parameters.Count = 0 Then
                    msgCount.Parameters.Add(echoNameParam)                    
                End If

                msgCount.Parameters(0).Value = strEchoName
                msgCount.Connection = sqlConn
                msgCount.CommandType = CommandType.StoredProcedure
                Dim ret As Integer = CInt(msgCount.ExecuteScalar())
                Return CInt(msgCount.ExecuteScalar())
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
            Return msgText
        End Get
        Set(ByVal value As String)
            msgText = value
        End Set
    End Property

    Public Sub OpenDB() Implements IDatabases.OpenDB
        Try
            sqlConn = New SqlConnection(strDBname)
            sqlConn.Open()
            'Dim cmd As New SqlCommand("SHOW SERVER_ENCODING;", sqlConn)
            'serverCodePage = CInt(CStr(cmd.ExecuteScalar()).Replace("WIN", ""))
            serverCodePage = 1251
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
            Return vbNullString
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
