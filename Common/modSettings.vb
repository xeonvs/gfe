
''' <summary>
''' ������ ��� ������� � ���������� ���������� ���
''' </summary> 
Module modSettings

    ''' <summary>
    ''' ������ ����� ������� ���
    ''' </summary>    
    Public AppRun As String = Application.StartupPath
    ''' <summary>
    ''' ������ ����� � �������� � ��������������� ��������
    ''' </summary>
    Public ModulesPath As String = AppRun
    ''' <summary>
    ''' ������ ���� � �������� �� ����������
    ''' </summary>
    Public SmilesPath As String = AppRun & "\smilez"

    ''' <summary>
    ''' ���������� ����� �� �������
    ''' </summary>
    ''' <param name="OptionPath">���� � ������� �����</param>
    ''' <param name="OptionName">��� �����</param>
    ''' <param name="DefaultValue">�������� �� ���������</param>
    ''' <returns>�������� ��������� � ������</returns>
    ''' <remarks>���� ������ �� �������</remarks>
    Public Function GetGFEOption(ByVal OptionPath As String, _
                                 ByVal OptionName As String, _
                                   Optional ByVal DefaultValue As String = "") As String
        'Note: ������ ��� �������� workaraund, �.�. DefaultValue �� ������������ � �������
        Dim ret As Object = My.Computer.Registry.GetValue _
                ("HKEY_CURRENT_USER\SOFTWARE\GFE\" & OptionPath, OptionName, DefaultValue)
        If IsNothing(ret) Then
            Return DefaultValue
        Else
            Return CStr(ret)
        End If
    End Function

    ''' <summary>
    ''' ��������� ����� � ������
    ''' </summary>
    ''' <param name="OptionPath">���� � ������� �����</param>
    ''' <param name="OptionName">��� �����</param>
    ''' <remarks>���� ������ �� �������</remarks>
    Public Sub PutGFEOption(ByVal OptionPath As String, _
                            ByVal OptionName As String, _
                            ByVal Value As String)
        'Registry.SaveString(HKEY_CURRENT_USER, "SOFTWARE\GFE\" & OptionPath, OptionName, Value)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\GFE\" & OptionPath, OptionName, Value)
    End Sub

End Module
