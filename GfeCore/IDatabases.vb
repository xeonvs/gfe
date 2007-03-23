
''' <summary>
''' ��������c ���������� ������ � ��������� ����� �����
''' </summary>
Public Interface IDatabases
    Inherits IDisposable
    Inherits IDatabasesTypes    
    Inherits IModuleInfo

    ''' <summary>
    ''' ��� ����
    ''' </summary>
    ReadOnly Property BaseType() As IDatabases.enmBaseType

    ''' <summary>
    ''' ����������� ������
    ''' </summary>
    Property From() As String

    ''' <summary>
    ''' ����� �����������
    ''' </summary>
    Property FromAddr() As String

    ''' <summary>
    ''' ���������� ������
    ''' </summary>
    Property [To]() As String

    ''' <summary>
    ''' ����� ���������� ������
    ''' </summary>
    Property ToAddr() As String

    ''' <summary>
    ''' ���� ��������� ������
    ''' </summary>
    ''' <value>�������� � UnixTime</value>
    Property DateWritten() As Integer

    ''' <summary>
    ''' ���� �������� ������.
    ''' </summary>
    ''' <value>�������� � UnixTime</value>
    Property DateArrived() As Integer

    ''' <summary>
    ''' ���� ������
    ''' </summary>
    Property Subject() As String

    ''' <summary>
    ''' ����� ������
    ''' </summary>
    Property MessageText() As String

    ''' <summary>
    ''' ����� ������
    ''' </summary>
    Property MessageFlags() As Integer

    ''' <summary>
    ''' ���������� ����� ��������� �� ������� ������ �������� �������
    ''' </summary>
    Property ReplayTo() As Integer

    ''' <summary>
    ''' ���������� ����� ������� ��������� � �������� �������
    ''' </summary>
    Property ReplayFirst() As Integer

    ''' <summary>
    ''' ���������� ����� ������� � ��������� ������� �������
    ''' </summary>
    Property ReplayNext() As Integer

    ''' <summary>
    ''' ���������� ������ ������� �������
    ''' </summary>
    ''' <remarks>������������� ������ ��� SQUISH ����</remarks>
    Property ReplayNextS() As String

    ''' <summary>
    ''' ������ ���� � ���� ���� ���������
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Property DBName() As String

    ''' <summary>
    ''' ��� �������� ��� 
    ''' </summary>
    Property EchoName() As String

    ''' <summary>
    ''' ����� ��������� � ���
    ''' </summary>
    Property MessageCount() As Integer

    ''' <summary>
    ''' ���������� ����� ��������� �� ����� ���
    ''' </summary>
    ''' <param name="EchoPath">������ ����</param>
    ReadOnly Property MessageCountByEcho(ByVal EchoPath As String) As Integer

    ''' <summary>
    ''' ��������� ����� ��������� �� ������
    ''' </summary>
    Sub GetMessageByNum(ByVal NumberMessage As Integer)

    ''' <summary>
    ''' ���������� ���� ��������� �� ������
    ''' </summary>
    Function GetMessageDumpByNum(ByVal NumberMessage As Integer) As String

    ''' <summary>
    ''' ��������� ��������� ������ �� ������
    ''' </summary>
    Sub GetHeadesByNum(ByVal NumberMessage As Integer)

    ''' <summary>
    ''' ��������� ��������� ������ �� ������
    ''' </summary>
    ''' <remarks>������������� ��� ���������� ������</remarks>
    Sub GetHeadesByNumForTree(ByVal NumberMessage As Integer)

    ''' <summary>
    ''' ��������� ��� ��������� ��������� ������
    ''' </summary>
    ''' <remarks>����� ��������� �����</remarks>
    Sub GetHeadesByNumAll(ByVal NumberMessage As Integer)

    ''' <summary>
    ''' ���������� ����� ���������� ������������ �������
    ''' </summary>
    ''' <param name="msgNumber">���� �� 0 �� ���������� ����������</param>
    Function GetLastReadMsgNum(Optional ByVal msgNumber As Integer = 0) As Integer

    ''' <summary>
    ''' ���������� ������ � ��������.
    ''' </summary>
    ''' <param name="NumberMessage"></param>
    Function GetMessageKlugeByNum(ByVal NumberMessage As Integer) As String

    ''' <summary>
    ''' ��������� ���� ���������
    ''' </summary>
    Sub OpenDB()

    ''' <summary>
    ''' ��������� ��������� � ����
    ''' </summary>
    Function WriteMessage() As Integer

    ''' <summary>
    ''' ������� ��������� �� ����
    ''' </summary>
    Sub DeleteMessageByNum(ByVal NumberMessage As Integer)

    ''' <summary>
    ''' ������������� ������ ��������� � ����� ����
    ''' </summary>
    ''' <param name="Status">��� �������� -1 ���������� ������ �������� �������</param>
    ''' <remarks>�������� �� �� ����� ���������</remarks>
    Function MessageStatus(ByVal NumberMessage As Integer, Optional ByVal Status As Integer = -1) As Integer

End Interface

