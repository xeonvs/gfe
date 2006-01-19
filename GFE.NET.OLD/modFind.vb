Option Strict Off
Option Explicit On
Module modFind
	
	Dim numIt As Integer
	Dim Stopped As Boolean
	
	'перед началом поиска необходимо запустить эту процедуру
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
			
			'¬от это структурка!!!
			If fndMessage = True Then
				base.GetMessageByNum(MNum)
				
				If InStr(1, base.Message, fndStr, CompareMethod.Text) <> 0 Then
					base.GetHeadesByNum(MNum) '¬ случае если в тексте письма есть
					'искомое слово, мы должны знать поле Subj
					'чтобы добавить его в список найденных писем
					
					numIt = numIt + 1 '«десь !!!ќЅя«ј“≈Ћ№Ќќ!!! должна быть эта строчка
					'т.к. эта процедура вызываетс€ по разным эхам
					'а два найденных письма из разных эх могут иметь
					'одинаковые пор€дковые номера в базах => будет
					'ошибка Ќ≈”Ќ» јЋ№Ќќ—“»  Ћё„≈…!!!!
					
					LI = List.ListItems.Add( , "r" & CStr(numIt), Echo)
					LI.SubItems(1) = MNum & ":" & base.Subj
					LI.SubItems(2) = base.DBName
					LI.let_Tag(MNum)
					
					If OnlyOne = True Then Exit For
				End If
				
			Else
				base.GetHeadesByNum(MNum) '“еперь в любом случае нужно вызвать ее
				
				If fndTheme = True Then
					If InStr(1, base.Subj, fndStr, CompareMethod.Text) <> 0 Then
						numIt = numIt + 1 '«десь !!!ќЅя«ј“≈Ћ№Ќќ!!! должна быть эта строчка
						LI = List.ListItems.Add( , "r" & CStr(numIt), Echo)
						LI.SubItems(1) = MNum & ":" & base.Subj
						LI.SubItems(2) = base.DBName
						LI.let_Tag(MNum)
						
						If OnlyOne = True Then Exit For
					End If
					
				ElseIf fndFrom = True Then 
					
					If InStr(1, base.From, fndStr, CompareMethod.Text) <> 0 Then
						numIt = numIt + 1 '«десь !!!ќЅя«ј“≈Ћ№Ќќ!!! должна быть эта строчка
						LI = List.ListItems.Add( , "r" & CStr(MNum), Echo)
						LI.SubItems(1) = MNum & ":" & base.Subj
						LI.SubItems(2) = base.DBName
						LI.let_Tag(MNum)
						
						If OnlyOne = True Then Exit For
					End If
					
				ElseIf fndTo = True Then 
					
					If InStr(1, base.rTo, fndStr, CompareMethod.Text) <> 0 Then
						numIt = numIt + 1 '«десь !!!ќЅя«ј“≈Ћ№Ќќ!!! должна быть эта строчка
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