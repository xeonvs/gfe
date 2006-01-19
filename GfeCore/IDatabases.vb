
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
    Sub GetMessageByNum(ByRef NumberMessage As Integer)

    ''' <summary>
    ''' ���������� ���� ��������� �� ������
    ''' </summary>
    Function GetMessageDumpByNum(ByRef NumberMessage As Integer) As String

    ''' <summary>
    ''' ��������� ��������� ������ �� ������
    ''' </summary>
    Sub GetHeadesByNum(ByRef NumberMessage As Integer)

    ''' <summary>
    ''' ��������� ��������� ������ �� ������
    ''' </summary>
    ''' <remarks>������������� ��� ���������� ������</remarks>
    Sub GetHeadesByNumForTree(ByRef NumberMessage As Integer)

    ''' <summary>
    ''' ��������� ��� ��������� ��������� ������
    ''' </summary>
    ''' <remarks>����� ��������� �����</remarks>
    Sub GetHeadesByNumAll(ByRef NumberMessage As Integer)

    ''' <summary>
    ''' ���������� ����� ���������� ������������ �������
    ''' </summary>
    ''' <param name="msgNumber">���� �� 0 �� ���������� ����������</param>
    Function GetLastReadMsgNum(Optional ByRef msgNumber As Integer = 0) As Integer

    ''' <summary>
    ''' ���������� ������ � ��������.
    ''' </summary>
    ''' <param name="NumberMessage"></param>
    Function GetMessageKlugeByNum(ByRef NumberMessage As Integer) As String

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
    Sub DeleteMessageByNum(ByRef NumberMessage As Integer)

    ''' <summary>
    ''' ������������� ������ ��������� � ����� ����
    ''' </summary>
    ''' <param name="Status">��� �������� -1 ���������� ������ �������� �������</param>
    ''' <remarks>�������� �� �� ����� ���������</remarks>
    Function MessageStatus(ByRef NumberMessage As Integer, Optional ByRef Status As Integer = -1) As Integer

End Interface

