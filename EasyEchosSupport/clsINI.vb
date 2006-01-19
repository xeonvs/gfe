Option Strict Off
Option Explicit On

''' <summary>
''' ����� ������������� ������ � INI ������
''' </summary>
Friend Class clsINI
    '*************************************************************************
    '*                    ����� ��� ������ � INI-�������                     *
    '*-----------------------------------------------------------------------*
    '*       ��������:                                                       *
    '*  AddSection     - ��������� ����� ������                              *
    '*  AddValue       - ��������� ����� �������� � ������                   *
    '*  Filename       - ��� �����. ���� ���� ����������, �� �����������.    *
    '*  RemoveSection  - ������� ������                                      *
    '*  RemoveValue    - ������� �������� �� ������                          *
    '*  SectionExists  - ���������� True, ���� ������ ����������             *
    '*  SectionName    - ���������� ��� ������ �� �� ������                  *
    '*  SectionsCount  - ���������� ���������� ������                        *
    '*  UpdateFile     - ��������� ����                                      *
    '*  Value          - ����������/������������� �������� ���������         *
    '*  ValueExists    - ���������� True, ���� �������� ����������           *
    '*  ValueName      - ���������� ��� ��������� �� ��� ������              *
    '*  ValuesCount    - ���������� ���������� ���������� � �������� ������  *
    '*-----------------------------------------------------------------------*
    '*************************************************************************

    ' ��� ������� ���������� True, ���� ��� ������

    Private mFilename As String

    Private AllSections() As tSection

    Private Structure tValue
        Dim Name As String
        Dim cntValue As String
    End Structure

    Private Structure tSection
        Dim Name As String
        Dim Values() As tValue
    End Structure

    ''' <summary>
    ''' ������� ������ �� INI �����
    ''' </summary> 
    Public Function RemoveSection(ByVal Section As String) As Boolean
        Dim i, a As Integer
        Dim uSN As String
        uSN = UCase(Section)
        ' �������� ���� ������
        For i = 1 To UBound(AllSections)
            If UCase(AllSections(i).Name) = uSN Then
                ' ������ ������ ����, �������� ��������� "����"
                For a = i To UBound(AllSections) - 1
                    'UPGRADE_WARNING: Couldn't resolve default property of object AllSections(a). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    AllSections(a) = AllSections(a + 1)
                Next a
                ' �������
                ReDim Preserve AllSections(UBound(AllSections) - 1)
                RemoveSection = True
                Exit Function
            End If
        Next i
    End Function

    ''' <summary>
    ''' ��������� ������� ������ � INI �����
    ''' </summary> 
    Public ReadOnly Property SectionExists(ByVal Section As String) As Boolean
        Get
            Dim i As Integer
            Dim uSN As String
            uSN = UCase(Section)
            ' ������ ���������� �� ����� ������� � ���������, ���� �� ��������
            For i = 1 To UBound(AllSections)
                If UCase(AllSections(i).Name) = uSN Then
                    ' ����!
                    Return True
                    Exit Property
                End If
            Next i
        End Get
    End Property

    Public ReadOnly Property ValueExists(ByVal Section As String, ByVal ValueName As String) As Boolean
        Get
            Dim i, a As Integer
            Dim uSN, uVN As String
            uSN = UCase(Section)
            uVN = UCase(ValueName)
            ' �������� ���� ������
            For i = 1 To UBound(AllSections)
                If UCase(AllSections(i).Name) = uSN Then
                    ' ������ ������, ������ ���� � ��� ��������
                    For a = 1 To UBound(AllSections(i).Values)
                        If AllSections(i).Values(a).Name = uVN Then
                            ' ������� ��������
                            Return True
                            Exit Property
                        End If
                    Next a
                    Exit Property
                End If
            Next i
        End Get
    End Property

    Public ReadOnly Property ValueName(ByVal Section As String, ByVal Index As Integer) As String
        Get
            ' ����������: ���� �������� ��� ������ ������� �� �����, �� ��������
            ' ������ vbNullChar - ������ � ������� �����
            Dim uSN As String
            Dim i As Integer
            uSN = UCase(Section)
            ' �������� ���� ������
            For i = 1 To UBound(AllSections)
                If UCase(AllSections(i).Name) = uSN Then
                    '������ ������
                    If Index > 0 And Index <= UBound(AllSections(i).Values) Then
                        ' ������ ��������
                        Return AllSections(i).Values(Index).Name
                        Exit Property
                    Else
                        ' ������ ��� ������ ���������...
                        Return vbNullChar
                    End If
                    Exit Property
                End If
            Next i
            Return vbNullChar
        End Get
    End Property

    Public ReadOnly Property ValuesCount(ByVal Section As String) As Integer
        Get
            ' ����������: ���� ������ �� �������, �������� ������
            ' �������� -1.
            Dim uSN As String
            Dim i As Integer
            uSN = UCase(Section)
            ' �������� ���� ������
            For i = 1 To UBound(AllSections)
                If UCase(AllSections(i).Name) = uSN Then
                    ' ������ ������
                    Return UBound(AllSections(i).Values)
                    Exit Property
                End If
            Next i
            Return -1
        End Get
    End Property


    Default Public Property Value(ByVal Section As String, ByVal ValueName As String) As String
        Get
            ' ����������: ���� �������� ������ �� �����, �� ��������
            ' ������ vbNullChar - ������ � ������� �����
            Dim i, a As Integer
            Dim uVN, uSN As String
            uSN = UCase(Section)
            uVN = UCase(ValueName)
            ' �������� ���� ������
            For i = 1 To UBound(AllSections)
                If UCase(AllSections(i).Name) = uSN Then
                    ' �������� ���� ���������� � ������
                    For a = 1 To UBound(AllSections(i).Values)
                        If UCase(AllSections(i).Values(a).Name) = uVN Then
                            ' ����� ������ ��������
                            Return AllSections(i).Values(a).cntValue
                            Exit Property
                        End If
                    Next
                    Return vbNullChar
                    Exit Property
                End If
            Next i
            Return vbNullChar
        End Get
        Set(ByVal Value As String)
            Dim i, a As Integer
            Dim uVN, uSN As String
            uSN = UCase(Section)
            uVN = UCase(ValueName)
            ' �������� ���� ������
            For i = 1 To UBound(AllSections)
                If UCase(AllSections(i).Name) = uSN Then
                    ' �������� ���������� � ������
                    For a = 1 To UBound(AllSections(i).Values)
                        If UCase(AllSections(i).Values(a).Name) = uVN Then
                            ' ����� ��������, ��������� ��� ��������...
                            AllSections(i).Values(a).cntValue = Value
                            Exit Property
                        End If
                    Next
                    ' �� ����� ��������, ��������� �����...
                    With AllSections(i)
                        ReDim Preserve .Values(UBound(.Values) + 1)
                        .Values(UBound(.Values)).cntValue = Value
                        .Values(UBound(.Values)).Name = ValueName
                    End With
                    Exit Property
                End If
            Next i
            ' �� ����� �������������� ������, ��������� �����...
            ReDim Preserve AllSections(UBound(AllSections) + 1)
            With AllSections(UBound(AllSections))
                .Name = Section
                ReDim .Values(1)
                .Values(1).Name = ValueName
                .Values(1).cntValue = Value
            End With
        End Set
    End Property

    Public ReadOnly Property SectionName(ByVal Index As Integer) As String
        Get
            ' ����� ��� ������: �������� - �������� �� ������ � �������
            ' ������� � ������� ����� ������.
            ' ����������: ���� ������ ������� �� �����, �� ��������
            ' ������ vbNullChar - ������ � ������� �����
            If Index > 0 And Index <= UBound(AllSections) Then
                Return AllSections(Index).Name
            Else
                Return vbNullChar
            End If
        End Get
    End Property

    Public ReadOnly Property SectionsCount() As Integer
        Get
            Return UBound(AllSections)
        End Get
    End Property

    Public Property FileName() As String
        Get
            Return mFilename
        End Get
        Set(ByVal Value As String)
            Dim v, s, t As Integer
            Dim l As String
            mFilename = Value
            ReDim AllSections(0)
            ' ���� � �������?

            If Len(Dir(mFilename)) = 0 Then
                ' ���� ���, ��...
                Exit Property
            End If

            ' ��������� ����
            FileOpen(1, mFilename, OpenMode.Input, OpenAccess.Read, OpenShare.LockWrite)
            Do While Not EOF(1)
                l = LineInput(1)
                ' ����������� ����?
                t = InStr(1, l, ";")
                l = LTrim(RTrim(l))
                ' ���������������� ��� ������
                If t = 1 Or Len(l) = 0 Then GoTo skip_line
                ' ����������� � ����� ������
                If t > 1 Then l = Left(l, t - 1)
                If Left(l, 1) = "[" Then
                    ' ����� ������
                    t = InStr(1, l, "]")
                    If t < 3 Then GoTo skip_line
                    l = Mid(l, 2, t - 2)
                    ' ������ ����� �� ���� ������
                    s = s + 1
                    ' ����� � ����� ������ ���� ���
                    v = 0
                    ReDim Preserve AllSections(s)
                    AllSections(s).Name = l
                    ReDim AllSections(s).Values(0)
                Else
                    ' ����� �������� � ������
                    ' ���� ������ �� ���� ������� �� ����� ������ - ����������
                    If s = 0 Then GoTo skip_line
                    ' ��������� ������ �� �������� ��������� � �� ��� ��������
                    t = InStr(1, l, "=")
                    If t < 2 Then GoTo skip_line
                    v = v + 1
                    ' ��������� ��������
                    With AllSections(s)
                        ReDim Preserve .Values(v)
                        .Values(v).Name = Left(l, t - 1)
                        If t < Len(l) Then .Values(v).cntValue = Mid(l, t + 1, Len(l) - t)
                    End With
                End If
skip_line:
            Loop
            FileClose(1)
        End Set
    End Property

    Public Function UpdateFile() As Boolean
        ' ��� ����� �� ������ - ���� ���������-��? :)
        If Len(mFilename) = 0 Then Exit Function
        Dim i, a As Integer
        FileOpen(1, mFilename, OpenMode.Output, OpenAccess.Write, OpenShare.LockWrite)
        For i = 1 To UBound(AllSections)
            ' ������ ���� ������
            With AllSections(i)
                PrintLine(1, "[" & .Name & "]")
                ' ������ ���� ���������� � ������
                For a = 1 To UBound(.Values)
                    PrintLine(1, .Values(a).Name & "=" & .Values(a).cntValue)
                Next a
            End With
            PrintLine(1, vbNullString)
        Next i
        FileClose(1)
        UpdateFile = True
    End Function

    Public Function RemoveValue(ByVal Section As String, ByVal ValueName As String) As Boolean
        Dim a, i, c As Integer
        Dim uVN, uSN As String
        uSN = UCase(Section)
        uVN = UCase(ValueName)
        ' ������� ���� ������
        For i = 1 To UBound(AllSections)
            If UCase(AllSections(i).Name) = uSN Then
                ' ������ ������ ����
                For a = 1 To UBound(AllSections(i).Values)
                    If UCase(AllSections(i).Values(a).Name) = uVN Then
                        ' ������ �������� ����
                        With AllSections(i)
                            ' ����� ���������� "����" �� ����
                            For c = a To UBound(.Values) - 1
                                'UPGRADE_WARNING: Couldn't resolve default property of object AllSections().Values(a). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                .Values(a) = .Values(a + 1)
                            Next c
                            ' �������� ���������
                            ReDim Preserve .Values(UBound(.Values) - 1)
                            RemoveValue = True
                            Exit Function
                        End With
                    End If
                Next
                Exit Function
            End If
        Next i
    End Function

    Public Function AddValue(ByVal Section As String, ByVal ValueName As String, Optional ByVal lValue As String = vbNullString) As Boolean
        Dim uSN, uVN As String
        Dim i, a As Integer
        uSN = UCase(Section)
        uVN = UCase(ValueName)
        ' ����������-�� ��� ������...

add_value:
        For i = 1 To UBound(AllSections)
            If UCase(AllSections(i).Name) = uSN Then
                ' ���� ������ ������!
                For a = 1 To UBound(AllSections(i).Values)
                    If UCase(AllSections(i).Values(a).Name) = uVN Then
                        ' ����� ������ ��� ����
                        Exit Function
                    End If
                Next a
                ' ��������� ����� ��������
                With AllSections(i)
                    ReDim Preserve .Values(UBound(.Values) + 1)
                    .Values(UBound(.Values)).Name = ValueName
                    .Values(UBound(.Values)).cntValue = lValue
                End With
                AddValue = True
                Exit Function
            End If
        Next

        ' ������ ����� ���, ���������...
        AddSection(Section)
        GoTo add_value

    End Function

    Public Function AddSection(ByVal Section As String) As Boolean
        Dim uSN As String
        Dim i As Integer
        uSN = UCase(Section)
        For i = 1 To UBound(AllSections)
            If UCase(AllSections(i).Name) = uSN Then
                ' ��� ����� ������ ����...
                Exit Function
            End If
        Next i
        ' ��������� ������� � ������� ������
        ReDim Preserve AllSections(UBound(AllSections) + 1)
        With AllSections(UBound(AllSections))
            .Name = Section
            ReDim .Values(0)
        End With
        AddSection = True
    End Function

    Public Sub New()
        MyBase.New()
        ReDim AllSections(0)
    End Sub

    Protected Overrides Sub Finalize()
        Erase AllSections
        MyBase.Finalize()
    End Sub
End Class