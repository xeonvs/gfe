
''' <summary>
''' ��������� ���������� � ������
''' </summary>
Public Interface IModuleInfo

    ''' <summary>
    ''' ���������� ������ ��������������� � �������
    ''' </summary>
    Function GetModuleIcon() As System.Drawing.Image
    ''' <summary>
    ''' ���������� �������� ������
    ''' </summary>
    ReadOnly Property Description() As String
    ''' <summary>
    ''' ���������� ��� ������
    ''' </summary>
    ReadOnly Property Name() As String

End Interface
