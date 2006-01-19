Option Strict Off
Option Explicit On
Module modFind
	
	Dim numIt As Integer
	Dim Stopped As Boolean
	
	'����� ������� ������ ���������� ��������� ��� ���������
	Public Sub InitFindList(ByRef List As AxMSComctlLib.AxListView)
		List.ListItems.Clear()
		numIt = 0
		Stopped = False
		
		System.Windows.Forms.Application.DoEvents()
	End Sub
	
	Public Sub FindBase(ByRef base As jamBase, ByRef fndStr As String, ByRef List As AxMSComctlLib.AxListView, ByRef Echo As String, ByRef fndTheme As Boolean, ByRef fndMessage As Boolean, ByRef fndTo As Boolean, ByRef fndFrom As Boolean, ByRef OnlyOne As Boolean)
		
		Dim MNum As Integer
		Dim LI As MSComctlLib.ListItem
		
		For MNum = 1 To base.MessageCount
			
			If Stopped = True Then Exit For
			
			'��� ��� ����������!!!
			If fndMessage = True Then
				base.GetMessageByNum(MNum)
				
				If InStr(1, base.Message, fndStr, CompareMethod.Text) <> 0 Then
					base.GetHeadesByNum(MNum) '� ������ ���� � ������ ������ ����
					'������� �����, �� ������ ����� ���� Subj
					'����� �������� ��� � ������ ��������� �����
					
					numIt = numIt + 1 '����� !!!�����������!!! ������ ���� ��� �������
					'�.�. ��� ��������� ���������� �� ������ ����
					'� ��� ��������� ������ �� ������ �� ����� �����
					'���������� ���������� ������ � ����� => �����
					'������ �������������� ������!!!!
					
					LI = List.ListItems.Add( , "r" & CStr(numIt), Echo)
					LI.SubItems(1) = MNum & ":" & base.Subj
					LI.SubItems(2) = base.DBName
					LI.let_Tag(MNum)
					
					If OnlyOne = True Then Exit For
				End If
				
			Else
				base.GetHeadesByNum(MNum) '������ � ����� ������ ����� ������� ��
				
				If fndTheme = True Then
					If InStr(1, base.Subj, fndStr, CompareMethod.Text) <> 0 Then
						numIt = numIt + 1 '����� !!!�����������!!! ������ ���� ��� �������
						LI = List.ListItems.Add( , "r" & CStr(numIt), Echo)
						LI.SubItems(1) = MNum & ":" & base.Subj
						LI.SubItems(2) = base.DBName
						LI.let_Tag(MNum)
						
						If OnlyOne = True Then Exit For
					End If
					
				ElseIf fndFrom = True Then 
					
					If InStr(1, base.From, fndStr, CompareMethod.Text) <> 0 Then
						numIt = numIt + 1 '����� !!!�����������!!! ������ ���� ��� �������
						LI = List.ListItems.Add( , "r" & CStr(MNum), Echo)
						LI.SubItems(1) = MNum & ":" & base.Subj
						LI.SubItems(2) = base.DBName
						LI.let_Tag(MNum)
						
						If OnlyOne = True Then Exit For
					End If
					
				ElseIf fndTo = True Then 
					
					If InStr(1, base.rTo, fndStr, CompareMethod.Text) <> 0 Then
						numIt = numIt + 1 '����� !!!�����������!!! ������ ���� ��� �������
						LI = List.ListItems.Add( , "r" & CStr(MNum), Echo)
						LI.SubItems(1) = MNum & ":" & base.Subj
						LI.SubItems(2) = base.DBName
						LI.let_Tag(MNum)
						
						If OnlyOne = True Then Exit For
					End If
				End If
			End If
			
			If MNum Mod 100 = 0 Then
				
				System.Windows.Forms.Application.DoEvents()
				Sleep(1)
			End If
			
		Next MNum
		
	End Sub
	
	Public Sub StopSearch()
		Stopped = True
	End Sub
	
	Public Function SearchStopped() As Boolean
		SearchStopped = Stopped
	End Function
End Module