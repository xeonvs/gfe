''' <summary>
''' ������ ��� ������� � ���������� ���������� ���
''' </summary> 
Public Module modSettings

    ''' <summary>
    ''' ������ ����� ������� ���
    ''' </summary>    
    Public AppRun As String = My.Application.Info.DirectoryPath

    ''' <summary>
    ''' ����������� � ����� � ������
    ''' </summary>
    ''' <remarks>���������-�������</remarks>
    Public PatchSeparator As String = System.IO.Path.DirectorySeparatorChar

    ''' <summary>
    ''' True ���� ������ ���� ��������� ��� mono
    ''' </summary>
    ''' <remarks></remarks>
    Public IsMonoRun As Boolean = False

    ''' <summary>
    ''' True ���� ������ ���� ��������� �� ��������� Unix
    ''' </summary>
    ''' <remarks></remarks>
    Public IsUnixRun As Boolean = False

    ''' <summary>
    ''' ������ ����� � �������� � ��������������� ��������
    ''' </summary>
    Public ModulesPath As String = AppRun

    ''' <summary>
    ''' ������ ���� � �������� �� ����������
    ''' </summary>
    Public SmilesPath As String = AppRun & PatchSeparator & "smilez"

    ''' <summary>
    ''' �������������� ������ ����������
    ''' </summary>
    ''' <remarks>�������� ������ � ��� ������������ �������.</remarks>
    Public sAppInfoString As String

    ''' <summary>
    ''' �������������� �������� ��
    ''' </summary>
    ''' <remarks></remarks>
    Public bRecodeDesc As Boolean = True

#Region "Functions"
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
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\GFE\" & OptionPath, OptionName, Value)
    End Sub
#End Region

End Module
