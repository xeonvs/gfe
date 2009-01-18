Option Explicit On

Imports System.Reflection
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data

''' <summary>
''' �������� ������� ������ � �������
''' </summary>
Public Enum ReplayMode As Integer
    NewMail = 0          '����� ������
    ReplayFrom = 1       '����� �����������
    ReplayTo = 2         '����� ����������� ���������
    ReplayFromNotCit = 3 '����� ��� �����������
    ReplayOtherArea = 4  '����� � ������ ���
    MailForward = 5      '��������� ������
    MailMoving = 6       '�����������
    MailCopying = 7      '�����������
    MailChange = 8       '���������
    BookMail = 9         '������ �� �������� �����
    ViewMails = 99       '��������
End Enum

''' <summary>
''' �������� ����� ������ ����������
''' </summary>
Module modCommon

    Public clsEchos As New EasyEchosSupport.clsEchoNames                    '��������� ������� � ������� ��
    Public Bases As New Dictionary(Of IDatabases.enmBaseType, System.Type)  '�������������� ����
    Public dsSmiles As New DataSet("mySmiles")                              'DataSet �� ����������

    ''' <summary>
    ''' ��������� ������� ��� ������ � ������ ���������.
    ''' </summary>
    ''' <remarks>����������� ������ �� ������ ������ ������� ��������� ����� .Database</remarks>
    Public Sub LoadDatabaseModules()
        Dim di As New DirectoryInfo(AppRun)
        Dim modules() As FileInfo = di.GetFiles("*Base.dll")
        Dim a As Assembly

        For Each fModule As FileInfo In modules
            Dim cModule As String = fModule.Name
            Dim ModuleName As String = cModule.Replace(".dll", "")

            Try
                a = Assembly.LoadFrom(cModule)
                Dim mytypes As Type() = a.GetTypes()
                Dim flags As BindingFlags = BindingFlags.NonPublic Or BindingFlags.Public Or BindingFlags.Static Or _
                                            BindingFlags.Instance Or BindingFlags.DeclaredOnly
                Dim dbtype As IDatabases.enmBaseType = IDatabasesTypes.enmBaseType.Unknown

                For Each t As Type In mytypes
                    If t.FullName.IndexOf(ModuleName + ".Database") <> -1 Then
                        Dim mi As MethodInfo() = t.GetMethods(flags)
                        Dim obj As Object = Activator.CreateInstance(t)

                        For Each m As MethodInfo In mi
                            If m.Name.IndexOf("get_BaseType") <> -1 Then
                                dbtype = m.Invoke(obj, Nothing)
                            End If
                        Next
                        If dbtype <> IDatabasesTypes.enmBaseType.Unknown And t.IsPublic = True Then
                            Try
                                Bases.Add(dbtype, t)
                            Catch ex As ArgumentException
                                '������� ���������� ��� ���� ������ ������-�� ����.
                            End Try
                        Else
                            'errroooorrrr
                        End If
                    End If
                Next
            Catch ex As FileLoadException
                MsgBox("������ ��� �������� ������ ���� " & cModule & vbCrLf & "��������� ��� ���.", MsgBoxStyle.Exclamation, Application.ProductName)
            End Try
        Next
    End Sub

    ''' <summary>
    ''' ��������� ��������� �������.
    ''' </summary>
    ''' <remarks>����������� ������ �� ������ ������ ������� ��������� �����-���������� ���������� IModule</remarks>
    Public Sub LoadOtherModules()
        '
    End Sub

    ''' <summary>
    ''' ��������� �������� �� XML ���������.
    ''' </summary>    
    Public Sub CreateSmilesDataset()
        With dsSmiles.Tables.Add("Smiles")
            With .Columns.Add("Id", GetType(Integer))
                .AutoIncrement = True
                .AllowDBNull = False
            End With
            .Columns.Add("Smile", GetType(String)).AllowDBNull = False
            .Columns.Add("Path", GetType(String)).AllowDBNull = False
            .PrimaryKey = New DataColumn() {.Columns("Id")}
        End With

        Try
            dsSmiles.ReadXml(SmilesPath & GfeCore.PatchSeparator & "smilez.xml")
        Catch
            '����� ��������� ���?
        End Try

    End Sub

    ''' <summary>
    ''' �������� �������� �� �� �������� � RTF
    ''' </summary>
    ''' <param name="rtf">������ �� ������ ���� Windows.Forms.RichTextBox</param>    
    Public Sub ReplaceSmiles(ByRef rtf As Windows.Forms.RichTextBox)
        Dim smile, path As String
        Dim st, fn As Integer
        Dim MyBitmap As Bitmap, clip As DataObject
        'Dim MyFormat As DataFormats.Format = DataFormats.GetFormat(DataFormats.Bitmap)

        '��������� �����
        'clip = My.Computer.Clipboard.GetDataObject()

        For i As Integer = 0 To dsSmiles.Tables("Smiles").Rows.Count - 1
            Dim row As DataRow = dsSmiles.Tables("Smiles").Rows(i)
            smile = CType(row("Smile"), String)
            path = CType(row("Path"), String)

            st = InStr(rtf.Text, smile, CompareMethod.Text) '��������� �����
            If st <> 0 Then
#If DEBUG Then
                Console.WriteLine("load smile: " & SmilesPath & PatchSeparator & path)
#End If
                Try
                    MyBitmap = Bitmap.FromFile(SmilesPath & PatchSeparator & path)

                Catch ex As FileNotFoundException
                    MsgBox("���� & " & SmilesPath & PatchSeparator & path & "�� ������", MsgBoxStyle.Exclamation, GfeCore.sAppInfoString)
                    MyBitmap = Nothing

                Catch ex As Exception
                    Console.WriteLine(ex.Message & vbCrLf & ex.Source)
                    MyBitmap = Nothing

                End Try

                Try                    
                    If Not MyBitmap Is Nothing Then
                        My.Computer.Clipboard.Clear()
                        My.Computer.Clipboard.SetImage(MyBitmap)
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.Message & vbCrLf & ex.Source)
                End Try

            End If

            While st <> 0
                fn = st + smile.Length + 1  '������
                rtf.SelectionStart = st - 1
                rtf.SelectionLength = smile.Length

                If My.Computer.Clipboard.ContainsImage Then
                    'If rtf.CanPaste(DataFormats.GetFormat(DataFormats.Bitmap)) Then
                    rtf.Paste()
                    'Else
                    'MessageBox.Show("The data format that you attempted to paste is not supported by this control.")
                    'End If
#If DEBUG Then
                Else
                    Console.WriteLine("No img in clipboard")
#End If
                End If

                st = InStr(fn, rtf.Text, smile, CompareMethod.Text)
            End While
        Next

        'My.Computer.Clipboard.SetDataObject(clip)

    End Sub

    ''' <summary>
    ''' �������� �������� �� �� �������� � HTML ����.
    ''' </summary>
    ''' <param name="html">C����� � HTML �����</param>    
    Public Sub ReplaceSmiles(ByRef html As String)
        Dim smile, path As String
        Dim Match As Match, MatchResults As MatchCollection
        Dim cc As Integer, tmp As String

        For i As Integer = 0 To dsSmiles.Tables("Smiles").Rows.Count - 1
            Dim row As DataRow = dsSmiles.Tables("Smiles").Rows(i)
            smile = CType(row("Smile"), String) '���������� � �������
            path = "<img src=""file://" & SmilesPath & PatchSeparator & CType(row("Path"), String) & """>"

            MatchResults = Regex.Matches(html, "[^le|\d+?|pp](" & Regex.Escape(smile) & "+)", RegexOptions.Multiline Or RegexOptions.Compiled)
            For j As Integer = 0 To MatchResults.Count - 1
                Match = MatchResults.Item(j)
                cc = Match.Groups.Item(1).Value.Length - 1

                While Match.Groups.Item(1).Value.Substring(cc, 1) = smile.Substring(smile.Length - 1, 1)
                    cc -= 1
                End While

                tmp = ""
                cc = Match.Groups.Item(1).Value.Length - 1 - cc
                While cc > 0
                    tmp &= path
                    cc -= 1
                End While

                html = Replace(html, Match.Groups.Item(1).Value, tmp, , 1)

            Next

        Next
    End Sub

    ''' <summary>
    '''  ���������� ���� � ������� ��������� ��� html
    ''' </summary>
    ''' <param name="intColor">Windows 32bit Color</param>
    ''' <returns>���������� ������ ������������ HTML ����</returns>    
    Public Function Win32ColorToHtml(ByVal intColor As Integer) As String
        Return ColorTranslator.ToHtml(ColorTranslator.FromWin32(intColor))
    End Function

End Module
