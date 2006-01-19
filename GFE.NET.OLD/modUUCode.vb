Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Module modUUCode
	
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Private Declare Sub RtlMoveMemory Lib "kernel32.dll" (ByRef dst As Any, ByRef Src As Any, ByVal cb As Integer)
	
	Private Declare Function GetTempPath Lib "kernel32"  Alias "GetTempPathA"(ByVal nBufferLength As Integer, ByVal lpBuffer As String) As Integer
	
	Private Declare Function GetTempFileName Lib "kernel32"  Alias "GetTempFileNameA"(ByVal lpszPath As String, ByVal lpPrefixString As String, ByVal wUnique As Integer, ByVal lpTempFileName As String) As Integer
	
	Public States() As Boolean 'массив состояний чекбоксов на форме
	Private Decoded() As String 'массив с подготовленными для декодинга секциями
	
	'Takes sets of 4 characters (ASCII) and returns sets of 3 characters (binary)
	Public Function DecodeString(ByVal InString As String, ByVal Bytes As Integer) As String
		On Error Resume Next
		Dim OutString As String
		Dim i As Integer
		Dim UnCodedArray() As Byte
		Dim CodedArray() As Byte
		
		'Convert the string to an array of bytes
		StringToByteArray(InString, UnCodedArray)
		
		'Set up the array to recieve the decoded bytes
		ReDim CodedArray((Len(InString) / 4) * 3)
		
		For i = 0 To (Len(InString) / 4) - 1 'For i = 0 to 14
			'Check for characters that should be spaces and convert them back
			If (UnCodedArray(i * 4 + 0) = 96) Then UnCodedArray(i * 4 + 0) = 32
			If (UnCodedArray(i * 4 + 1) = 96) Then UnCodedArray(i * 4 + 1) = 32
			If (UnCodedArray(i * 4 + 2) = 96) Then UnCodedArray(i * 4 + 2) = 32
			If (UnCodedArray(i * 4 + 3) = 96) Then UnCodedArray(i * 4 + 3) = 32
			
			'Decode the 3 bytes
			CodedArray(i * 3 + 0) = ((UnCodedArray(i * 4 + 0) - 32) * 4) + ((UnCodedArray(i * 4 + 1) - 32) \ 16) 'Calculate the 3 chars
			CodedArray(i * 3 + 1) = ((UnCodedArray(i * 4 + 1) Mod 16) * 16) + ((UnCodedArray(i * 4 + 2) - 32) \ 4)
			CodedArray(i * 3 + 2) = ((UnCodedArray(i * 4 + 2) Mod 4) * 64) + (UnCodedArray(i * 4 + 3) - 32)
		Next i
		ByteArrayToString(CodedArray, OutString)
		DecodeString = Left(OutString, Bytes)
		
	End Function
	
	'Takes sets of 3 characters (binary) and returns sets of 4 characters (ASCII)
	Public Function EncodeString(ByVal InString As String) As String
		Dim OutString As String
		Dim i As Short
		Dim UnCodedArray() As Byte
		Dim CodedArray() As Byte
		
		'Pad will null characters if necessary
		If Len(InString) Mod 3 <> 0 Then
			InString = InString & New String(Chr(0), 3 - Len(InString) Mod 3)
		End If
		
		'Convert string to a byte array. This is MUCH faster than the Asc/Chr combo.
		StringToByteArray(InString, UnCodedArray)
		
		'Make sure our output array is the correct size
		ReDim CodedArray(((Len(InString) / 3) * 4) - 1)
		
		For i = 0 To (Len(InString) / 3) - 1
			'Encode 4 bytes at a time
			CodedArray(i * 4 + 0) = UnCodedArray(i * 3 + 0) \ 4 + 32
			CodedArray(i * 4 + 1) = ((UnCodedArray(i * 3 + 0) Mod 4) * 16) + (UnCodedArray(i * 3 + 1) \ 16 + 32)
			CodedArray(i * 4 + 2) = ((UnCodedArray(i * 3 + 1) Mod 16) * 4) + (UnCodedArray(i * 3 + 2) \ 64 + 32)
			CodedArray(i * 4 + 3) = (UnCodedArray(i * 3 + 2) Mod 64) + 32
			
			'Check for spaces and eliminate them
			If CodedArray(i * 4 + 0) = 32 Then CodedArray(i * 4 + 0) = 96
			If CodedArray(i * 4 + 1) = 32 Then CodedArray(i * 4 + 1) = 96
			If CodedArray(i * 4 + 2) = 32 Then CodedArray(i * 4 + 2) = 96
			If CodedArray(i * 4 + 3) = 32 Then CodedArray(i * 4 + 3) = 96
		Next i
		ByteArrayToString(CodedArray, OutString)
		EncodeString = OutString
	End Function
	
	'Converts a string to an array of bytes. Just like Asc() on every character.
	Private Sub StringToByteArray(ByVal StringIn As String, ByRef ByteArray() As Byte)
		Dim lBytes As Integer
		
		If Len(StringIn) = 0 Then Exit Sub
		lBytes = Len(StringIn)
		ReDim ByteArray(lBytes - 1)
		
		RtlMoveMemory(ByteArray(0), StringIn, lBytes)
	End Sub
	
	'Converts an array of bytes to a string.
	Private Sub ByteArrayToString(ByRef ByteArray() As Byte, ByRef StringOut As String)
		Dim lBytes As Integer
		
		If LBound(ByteArray) > 0 Then Exit Sub 'lBound MUST be 0
		lBytes = UBound(ByteArray) + 1
		StringOut = New String(Chr(0), lBytes)
		
		RtlMoveMemory(StringOut, ByteArray(0), lBytes)
	End Sub
	
	'Функция находит UUE в эхе и строит список файлов и список по секциям.
	Public Sub FindUUE(ByRef db As Object)
		On Error GoTo errHandler
		
		Const сNst As Short = 25 'число строк сканирования
		Const сKst As Short = 10 'число строк сканирования по символу
		
		Dim nFiles, xNst, counter, cntX As Integer
		Dim k, i, j, nn As Integer
		Dim fNam As String
		Dim mText() As String
		Dim nUUE() As Integer
		Dim txt As String
		Dim Sections() As String ' Массив с секциями найденного файла
		Dim RegEx As New VBScript_RegExp_55.RegExp ' РегЭкспы
		Dim colMatches As VBScript_RegExp_55.MatchCollection ' коллекция этих образцов
		Dim LI As MSComctlLib.ListItem
		
		RegEx.MultiLine = True ' многострочный текст
		RegEx.[Global] = True ' будем проходить всю строку
		RegEx.IgnoreCase = True ' игнорируем регистр символов
		
		frmDecodeUUE.DefInstance.cmdDecode.Enabled = False
		frmDecodeUUE.DefInstance.cmdCancel.Enabled = False
		frmDecodeUUE.DefInstance.cmdScan.Enabled = False
		
		'UPGRADE_WARNING: Couldn't resolve default property of object db.MessageCount. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		frmDecodeUUE.DefInstance.prgFind.Max = db.MessageCount
		frmDecodeUUE.DefInstance.stbProgress.Panels(2).Text = "Поиск..."
		
		nn = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object db.MessageCount. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		For i = 1 To db.MessageCount
			'UPGRADE_WARNING: Couldn't resolve default property of object db.GetMessageByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			db.GetMessageByNum(i)
			'UPGRADE_WARNING: Couldn't resolve default property of object db.Message. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			mText = Split(db.Message, vbCr) 'разбиваем текс построчно
			k = 0 'счетчик строк с символом "M" в первой позиции
			If UBound(mText) < сNst Then
				xNst = UBound(mText)
			Else
				xNst = сNst
			End If
			For j = 0 To xNst
				If (LCase(Mid(mText(j), 1, 7)) = "section" And InStr(1, mText(j), " of ", CompareMethod.Text) <> 0) Or InStr(1, mText(j), "begin 664", CompareMethod.Text) <> 0 Then
					'это ююк, запоминаем номер
					ReDim Preserve nUUE(nn)
					nUUE(nn) = i
					nn = nn + 1
					Exit For
				ElseIf Mid(mText(j), 1, 1) = "M" Then 
					'что-то похожее на ююк
					k = k + 1
				End If
				If k >= сKst Then
					'это ююк, запоминаем номер
					ReDim Preserve nUUE(nn)
					nUUE(nn) = i
					nn = nn + 1
					Exit For
				End If
			Next j
			If i Mod 10 = 0 Then
				frmDecodeUUE.DefInstance.prgFind.Value = i
				frmDecodeUUE.DefInstance.prgFind.CtlRefresh()
				System.Windows.Forms.Application.DoEvents()
			End If
		Next i
		
		If nn = 0 Then
			'нету тут ююков
			frmDecodeUUE.DefInstance.prgFind.Value = 0
			frmDecodeUUE.DefInstance.prgFind.CtlRefresh()
			frmDecodeUUE.DefInstance.stbProgress.Panels(2).Text = "Не найдено!"
			frmDecodeUUE.DefInstance.cmdDecode.Enabled = True
			frmDecodeUUE.DefInstance.cmdCancel.Enabled = True
			frmDecodeUUE.DefInstance.cmdScan.Enabled = True
			System.Windows.Forms.Application.DoEvents()
			Exit Sub
		End If
		
		'поехали обрабатывать найденные письма
		frmDecodeUUE.DefInstance.prgFind.Value = 0
		frmDecodeUUE.DefInstance.prgFind.Max = UBound(nUUE) + 1
		frmDecodeUUE.DefInstance.prgFind.CtlRefresh()
		frmDecodeUUE.DefInstance.stbProgress.Panels(2).Text = "Сборка секций..."
		System.Windows.Forms.Application.DoEvents()
		
		
		
		'паттерн для нахождания строки с секцией. Примеры:
		'section 1 of 60 of file screenshot.j < uuencoded by UU Wizard v1.64.63 >
		'-  Part 2 of 3:
		'-section 1 of uuencode 5.20 of file qv_p251.rar    by R.E.M.
		'
		RegEx.Pattern = "section (\d+) of (\d+) of file (\w.+?)\s"
		'                          0        1              2
		
		counter = UBound(nUUE) 'запоминаем число секций
		ReDim States(counter)
		
		nFiles = 0
		
		While counter > 0 'Пока все секции не раскодированы
			'внешний цикл поиска секции файла
			For i = 0 To UBound(nUUE)
				If nUUE(i) <> 0 Then
					'найдена нераскодированнная секция
					'UPGRADE_WARNING: Couldn't resolve default property of object db.GetMessageByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					db.GetMessageByNum(nUUE(i))
					'UPGRADE_WARNING: Couldn't resolve default property of object db.Message. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					txt = db.Message 'текст мессага
					
					colMatches = RegEx.Execute(txt)
					If colMatches.Count = 0 Then 'это письмо с единственной секцией
						'это ююк и он в одной секции
						ReDim Preserve Decoded(nFiles)
						'Decoded(nFiles) = txt 'сохраняем сам ююк
						Decoded(nFiles) = CStr(nUUE(i)) 'сохраняем номер письма
						'UPGRADE_WARNING: Couldn't resolve default property of object db.GetHeadesByNumForTree. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						db.GetHeadesByNumForTree(nUUE(i))
						
						LI = frmDecodeUUE.DefInstance.lstFoundedFiles.ListItems.Add
						'UPGRADE_WARNING: Couldn't resolve default property of object db.Subj. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						LI.SubItems(1) = db.Subj
						LI.SubItems(2) = "100%"
						
						nFiles = nFiles + 1
						'код для FlexGrig
						'frmDecodeUUE.fg.Rows = nFiles + 1
						'frmDecodeUUE.fg.TextMatrix(nFiles, 1) = db.Subj
						'frmDecodeUUE.fg.TextMatrix(nFiles, 2) = 100 & "%"
						'frmDecodeUUE.fg.Cell(flexcpFloodPercent, nFiles, 2, nFiles, 2) = 100
						
						counter = counter - 1
						nUUE(i) = 0
						System.Windows.Forms.Application.DoEvents()
						Exit For
					End If
					
					'определяем массив с секциями+1 про запас
					'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					ReDim Preserve Sections(colMatches.item(0).SubMatches(1) + 1)
					'Sections(colMatches.Item(0).SubMatches(0)) = txt 'записываем найденную секцию
					'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					Sections(colMatches.item(0).SubMatches(0)) = CStr(nUUE(i)) 'записываем номер найденную секцию
					'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					fNam = colMatches.item(0).SubMatches(2) 'имя нашего файла
					counter = counter - 1
					nUUE(i) = 0
					For j = 0 To UBound(nUUE) 'ищем все остальные секции
						If nUUE(j) <> 0 Then
							'теперь будем писать остальные секции
							'UPGRADE_WARNING: Couldn't resolve default property of object db.GetMessageByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							db.GetMessageByNum(nUUE(j))
							'UPGRADE_WARNING: Couldn't resolve default property of object db.Message. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							txt = db.Message 'текст мессага
							
							colMatches = RegEx.Execute(txt)
							If colMatches.Count <> 0 Then 'это письмо с секцией
								'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								If fNam = colMatches.item(0).SubMatches(2) Then
									'Sections(colMatches.Item(0).SubMatches(0)) = txt
									'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
									Sections(colMatches.item(0).SubMatches(0)) = CStr(nUUE(j))
									counter = counter - 1
									nUUE(j) = 0
									System.Windows.Forms.Application.DoEvents()
								End If
							End If
						End If
					Next j
					
					'сохраняем ююк в виде строки 123,321,x,322 - где х отсутствующая секция
					txt = "" : cntX = 0
					For k = 1 To UBound(Sections)
						System.Windows.Forms.Application.DoEvents()
						If Len(Sections(k)) <> 0 Then
							If k <> UBound(Sections) Then
								txt = txt & CStr(Sections(k)) & ","
							Else
								txt = txt & CStr(Sections(k))
							End If
						Else
							If k <> UBound(Sections) Then
								txt = txt & "x,"
								cntX = cntX + 1
							Else
								txt = txt & "x"
								cntX = cntX + 1
							End If
						End If
					Next k
					
					LI = frmDecodeUUE.DefInstance.lstFoundedFiles.ListItems.Add
					LI.SubItems(1) = fNam
					LI.SubItems(2) = CStr(System.Math.Round((UBound(Sections) - cntX) / UBound(Sections) * 100, 2)) & "%"
					'DoEvents
					
					'for flexgrid
					'frmDecodeUUE.fg.Rows = nFiles + 1
					'frmDecodeUUE.fg.TextMatrix(nFiles, 1) = fNam
					'frmDecodeUUE.fg.TextMatrix(nFiles, 2) = Round((UBound(sections) - cntX) / UBound(sections) * 100, 2) & "%"
					'frmDecodeUUE.fg.Cell(flexcpFloodPercent, nFiles, 2, nFiles, 2) = Round((UBound(sections) - cntX) / UBound(sections) * 100, 2)
					
					'эту строчку исспользуем для отладки
					'txt = txt & " complite: " & Int((UBound(Sections) - cntX) / UBound(Sections) * 100) & "%"
					
					ReDim Preserve Decoded(nFiles)
					Decoded(nFiles) = txt
					nFiles = nFiles + 1
					'nUUE(i) = 0
					System.Windows.Forms.Application.DoEvents()
				End If
				
				If i Mod 100 = 0 Then
					frmDecodeUUE.DefInstance.prgFind.Value = i
					frmDecodeUUE.DefInstance.prgFind.CtlRefresh()
					System.Windows.Forms.Application.DoEvents()
				End If
				
			Next i
		End While
		
		'определяем массив состояний
		frmDecodeUUE.DefInstance.cmdDecode.Enabled = True
		
		frmDecodeUUE.DefInstance.prgFind.Value = frmDecodeUUE.DefInstance.prgFind.Max
		frmDecodeUUE.DefInstance.prgFind.CtlRefresh()
		frmDecodeUUE.DefInstance.stbProgress.Panels(2).Text = "Выполнено"
		frmDecodeUUE.DefInstance.cmdDecode.Enabled = True
		frmDecodeUUE.DefInstance.cmdCancel.Enabled = True
		frmDecodeUUE.DefInstance.cmdScan.Enabled = True
		System.Windows.Forms.Application.DoEvents()
		
		'UPGRADE_NOTE: Object colMatches may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		colMatches = Nothing
		'UPGRADE_NOTE: Object RegEx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		RegEx = Nothing
		
		Exit Sub
		
errHandler: 
		Select Case Err.Number
			Case Else
				ErrorMessage(Err.Number, Err.Description, "modUUCode::FindUUE")
		End Select
	End Sub
	
	'сохраняет выбранный итем в файл
	Public Sub SaveFile(ByRef SectionId As Integer, ByRef db As Object)
		On Error GoTo errHandler
		Dim sec() As String
		Dim i, st As Integer
		Dim txt As String
		Dim strs() As String
		Dim uue, fName As String
		Dim Bytes As Integer
		
		'проверяем не единственная ли секция
		If InStr(1, Decoded(SectionId), ",", CompareMethod.Text) <> 0 Then
			sec = Split(Decoded(SectionId), ",")
		Else
			ReDim sec(0)
			sec(0) = Decoded(SectionId)
		End If
		
		For i = 0 To UBound(sec)
			If sec(i) <> "x" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object db.GetMessageByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				db.GetMessageByNum(CInt(sec(i)))
				'UPGRADE_WARNING: Couldn't resolve default property of object db.Message. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				txt = txt & db.Message & vbCrLf
			Else
				'иначе смысла нет его трогать
				Exit Sub
			End If
		Next i
		
		Erase sec 'экономим память
		
		strs = Split(txt, vbCr) : txt = ""
		For i = 0 To UBound(strs)
			If Len(strs(i)) <> 0 Then
				If InStr(1, strs(i), "begin 644 ", CompareMethod.Text) <> 0 Then
					st = InStr(11, strs(i), " ", CompareMethod.Text)
					If st <> 0 Then
						fName = LCase(Mid(strs(i), 11, InStr(st, strs(i), " ", CompareMethod.Text) - st))
					Else
						fName = LCase(Mid(strs(i), 11, Len(strs(i))))
					End If
				ElseIf InStr(1, strs(i), " file ", CompareMethod.Text) <> 0 Then 
					st = InStr(1, strs(i), " file ", CompareMethod.Text) + 6
					If st <> 6 Then
						fName = LCase(Mid(strs(i), st, InStr(st, strs(i), " ", CompareMethod.Text) - st))
					Else
						fName = LCase(Mid(strs(i), 6, Len(strs(i))))
					End If
				End If
				
				If Asc(Mid(strs(i), 1, 1)) = Len(strs(i)) + 16 And Len(strs(i)) > 2 Then
					'строка с ююком
					Bytes = Asc(Left(strs(i), 1)) - 32
					uue = Right(strs(i), Len(strs(i)) - 1)
					txt = txt & DecodeString(uue, Bytes)
				End If
				If Mid(strs(i), 1, 1) = "`" Then
					If Mid(strs(i - 1), 1, 1) <> "M" Then
						'неполная строчка, иногда кривые UUE кодеры вставляют не верный 1й символ
						Bytes = Asc(Left(strs(i - 1), 1)) - 32
						uue = Right(strs(i - 1), Len(strs(i - 1)) - 1)
						txt = txt & DecodeString(uue, Bytes)
					End If
				End If
			End If
		Next i
		
		Erase strs
		st = FreeFile
		FileOpen(st, fName, OpenMode.Binary)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(st, txt)
		FileClose(st)
		
		System.Windows.Forms.Application.DoEvents()
		MsgBox("Сохранение " & fName & vbCrLf & "выполнено", MsgBoxStyle.Information, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - Debug")
		
		Exit Sub
		
errHandler: 
		Select Case Err.Number
			Case Else
				ErrorMessage(Err.Number, Err.Description, "modUUCode::SaveFile")
		End Select
	End Sub
	
	'Декодирует строку содержащую УУЕ коды и возвращает результат
	Public Function DecodeUUEData(ByRef UUEString As String) As String
		On Error GoTo errHandler
		Dim i As Integer
		Dim tmp As String
		Dim strs() As String
		
		strs = Split(UUEString, vbCrLf)
		For i = 0 To UBound(strs)
			If Len(strs(i)) <> 0 Then
				
				If Asc(Mid(strs(i), 1, 1)) = Len(strs(i)) + 16 And Len(strs(i)) > 2 Then
					'строка с ююком
					tmp = tmp & DecodeString(Right(strs(i), Len(strs(i)) - 1), Asc(Left(strs(i), 1)) - 32)
				End If
				If Mid(strs(i), 1, 1) = "`" Then
					If Mid(strs(i - 1), 1, 1) <> "M" Then
						'неполная строчка, иногда кривые UUE кодеры вставляют не верный 1й символ
						tmp = tmp & DecodeString(Right(strs(i - 1), Len(strs(i - 1)) - 1), Asc(Left(strs(i - 1), 1)) - 32)
					End If
				End If
			End If
		Next i
		
		DecodeUUEData = tmp
		Exit Function
		
errHandler: 
		Select Case Err.Number
			Case Else
				ErrorMessage(Err.Number, Err.Description, "modUUCode::DecodeUUEData")
		End Select
	End Function
	
	'проверяет письмо на наличие одно-секционного закодированного рисунка и декодирует его
	'возврашает указатель на загруженную в память картинку
	Public Function DecodePicture(ByRef MessageText As String) As System.Drawing.Image
		On Error GoTo errHandler
		'DecodePictureToTmpFile(mailviewer.Text)
		Dim st, ns, i As Integer
		Dim strs() As String
		Dim buff As String
		
		buff = Space(MAX_PATH)
		GetTempPath(MAX_PATH, buff)
		i = GetTempFileName(buff, "gfe", VB.Timer(), buff)
		buff = Mid(buff, 1, InStr(1, buff, Chr(0), CompareMethod.Binary) - 1)
		
		ns = InStr(1, MessageText, "section 1 of 1", CompareMethod.Text)
		If ns = 0 Then
			'рискнем найти единственную секцию
			ns = InStr(1, MessageText, "begin 644 ", CompareMethod.Text)
		End If
		If ns <> 0 Then
			'тут есть одна секция
			st = InStr(ns, MessageText, ".jpg", CompareMethod.Text)
			If st = 0 Then
				'поробуем еще чтонибудь из форматов найти
				st = InStr(ns, MessageText, ".jpeg", CompareMethod.Text)
				If st = 0 Then
					st = InStr(ns, MessageText, ".gif", CompareMethod.Text)
					If st = 0 Then
						st = InStr(ns, MessageText, ".png", CompareMethod.Text)
						If st = 0 Then
							st = InStr(ns, MessageText, ".bmp", CompareMethod.Text)
						End If
					End If
				End If
			End If
			If st <> 0 Then
				If ns < InStr(st, MessageText, vbCr) Then
					'секция принадлежит *.jpg файлу, в st начало данных(первый байт секции), в ns конец
					st = InStr(InStr(ns, MessageText, "begin 644 ", CompareMethod.Text), MessageText, vbCrLf)
					If st = 0 Then
						'errrrr buuuggzzz
						Exit Function
					End If
					ns = InStr(st, MessageText, "end" & vbCrLf, CompareMethod.Text)
					If ns = 0 Then
						'errrrr buuuggzzz
						Exit Function
					End If
					
					FileOpen(1, buff, OpenMode.Binary)
					'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
					FilePut(1, DecodeUUEData(Mid(MessageText, st + 2, (ns - 2) - (st + 2))))
					FileClose(1)
					
					DecodePicture = System.Drawing.Image.FromFile(buff)
					Kill(buff) 'загрузили так прибьем на радостях
				End If ' ns <> instr
			End If ' st  <> 0
			
		End If 'section
		Exit Function
		
errHandler: 
		Select Case Err.Number
			Case Else
				ErrorMessage(Err.Number, Err.Description, "modUUCode::DecodePicture")
		End Select
	End Function
	
	'проверяет письмо на наличие одно-секционного UUE содержащего не изображение
	Public Function CheckDataUUE(ByRef MegssageText As String) As Boolean
		On Error GoTo errHandler
		Dim RegEx As New VBScript_RegExp_55.RegExp ' РегЭкспы
		Dim colMatches As VBScript_RegExp_55.MatchCollection ' коллекция этих образцов
		Dim aMatch As VBScript_RegExp_55.Match ' один из совпавших образцов
		
		RegEx.MultiLine = True ' многострочный текст
		RegEx.[Global] = True ' будем проходить всю строку
		RegEx.IgnoreCase = True ' игнорируем регистр символов
		
		'поищем теперь формат в виде begin 6xx
		RegEx.Pattern = "(begin 6\d\d) (\w.+?)\s"
		colMatches = RegEx.Execute(MegssageText)
		If colMatches.Count > 0 Then
			'единичная секция присутствует
			aMatch = colMatches.item(0)
			'выгрызание ююка
			'rtf.SelStart = aMatch.FirstIndex
			'rtf.SelLength = InStr(aMatch.FirstIndex, rtf.Text, "end" & vbCrLf, vbTextCompare) - aMatch.FirstIndex + 2
			'rtf.SelText = vbNullString
			CheckDataUUE = True
			'UPGRADE_WARNING: Couldn't resolve default property of object aMatch.SubMatches(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			frmMain.DefInstance.cmdUUEDec.Tag = aMatch.SubMatches(1)
		Else
			'ничего не нашлось
			CheckDataUUE = False
		End If
		
		'UPGRADE_NOTE: Object colMatches may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		colMatches = Nothing
		'UPGRADE_NOTE: Object aMatch may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		aMatch = Nothing
		'UPGRADE_NOTE: Object RegEx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		RegEx = Nothing
		
		Exit Function
		
errHandler: 
		Select Case Err.Number
			Case Else
				ErrorMessage(Err.Number, Err.Description, "modUUCode::CheckDataUUE")
		End Select
	End Function
	
	'кодирует бинарный файл в односекционный ЮЮК. Передается hwnd родительской формы
	Public Function EncodeFileToOneSectionUUE(ByRef CallOwner As Integer) As String
		On Error GoTo errHandler
		Dim tmp, encFile, struue As String
		Dim j, ff, i, flen As Integer
		Const MaxFileSize As Integer = 8192 ' file size in bytes
		
		modCommonDialog.hwndOwner = CallOwner
		modCommonDialog.OpenDialogTitle = "Выберете файл для вставки..."
		modCommonDialog.Filter_Renamed = "All Files (*.*)|*.*|"
		modCommonDialog.Flags = cdlOFNHideReadOnly
		modCommonDialog.FilterIndex = 1
		
		encFile = modCommonDialog.ShowOpen
		If Len(encFile) = 0 Then
			EncodeFileToOneSectionUUE = vbNullString
			Exit Function
		End If
		
		flen = FileLen(encFile)
		If flen > MaxFileSize Then
			EncodeFileToOneSectionUUE = "Слишком большой файл!"
			Exit Function
		End If
		
		ff = FreeFile
		tmp = Space(flen)
		FileOpen(ff, encFile, OpenMode.Binary)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, tmp)
		FileClose(ff)
		
		EncodeFileToOneSectionUUE = vbNullString
		For i = 1 To flen Step 45
			struue = EncodeString(Mid(tmp, i, 45))
			If Len(struue) + 17 <> 77 Then
				EncodeFileToOneSectionUUE = EncodeFileToOneSectionUUE & Chr(flen - i + 33) & struue & vbCrLf
			Else
				EncodeFileToOneSectionUUE = EncodeFileToOneSectionUUE & Chr(Len(struue) + 17) & struue & vbCrLf
			End If
			
		Next i
		
		tmp = vbNullString
		i = Len(encFile)
		While Mid(encFile, i, 1) <> "\" And i > 0
			i = i - 1
		End While
		
		EncodeFileToOneSectionUUE = "begin 644 " & Mid(encFile, i + 1, Len(encFile)) & vbCrLf & EncodeFileToOneSectionUUE & "`" & vbCrLf & "end"
		
		Exit Function
		
errHandler: 
		Select Case Err.Number
			Case Else
				ErrorMessage(Err.Number, Err.Description, "modUUCode::EncodeFileToOneSectionUUE")
		End Select
	End Function
End Module