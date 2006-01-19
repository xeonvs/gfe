Option Strict Off
Option Explicit On
Module modTextWork
	'Constants and API`s
	
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Public Declare Function DrawText Lib "user32"  Alias "DrawTextA"(ByVal hdc As Integer, ByVal lpStr As String, ByVal nCount As Integer, ByRef lpRect As RECT, ByVal wFormat As Integer) As Integer
	
	Public Declare Function SetTextColor Lib "gdi32" (ByVal hdc As Integer, ByVal crColor As Integer) As Integer
	
	'прекодировка windows to dos
	Public Declare Function CharToOem Lib "user32"  Alias "CharToOemA"(ByVal lpszSrc As String, ByVal lpszDst As String) As Integer
	
	'прекодировка dos to windows
	Public Declare Function OemToChar Lib "user32"  Alias "OemToCharA"(ByVal lpszSrc As String, ByVal lpszDst As String) As Integer
	
	'Text Aligin
	Public Const DT_LEFT As Integer = &H0s
	Public Const DT_CENTER As Integer = &H1s
	Public Const DT_RIGHT As Integer = &H2s
	Public Const DT_VCENTER As Integer = &H4s
	Public Const DT_BOTTOM As Integer = &H8s
	Public Const DT_TOP As Integer = &H0s
	
	'Text control
	Public Const EM_CHARFROMPOS As Integer = &HD7s
	Public Const EM_UNDO As Integer = &HC7s
	
	Public Enum SaveMessageType
		SaveText = 0
		SaveRTF = 1
		SaveHTML = 3
	End Enum
	
	Public Structure MessageSaveFields
		Dim Description As String ' - описание эхи
		Dim AKA As String ' - aka
		Dim EchoName As String ' - echoname
		Dim MessageNumber As String ' - текущий номер письма
		Dim TotalMessages As String ' - всего писем
		Dim From As String ' - от кого
		Dim FromAddr As String ' - от кого, адрес
		Dim DateWritten As String ' - дата написания
		'UPGRADE_NOTE: To was upgraded to To_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim To_Renamed As String ' - кому
		Dim ToAddr As String ' - кому адрес
		Dim DateArrived As String ' - дата получения
		Dim Subject As String ' - сабж
	End Structure
	
	Private SmileRows() As String 'загруженные строки со смайлами
	
	'---------End-------------------
	
	' Для выделения текста неообходимо задать в качестве параметров:
	'
	' rtf - RichTextBox с текстом
	' Base - база с открытым сообщением, она может быть как
	'        MSG так и JAM
	'        (главное чтобы интерфейсы баз совпадали в нужных местах, пока это
	'         условие выполняется)
	Public Sub HighlightTextPlain(ByRef rtf As AxRichTextLib.AxRichTextBox, Optional ByRef base As Object = Nothing, Optional ByRef ParseSmiles As Boolean = True)
		On Error GoTo errHandler
		
		Dim flg As Boolean
		Dim tmpStart As Integer
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim str_Renamed, txt As String
		Dim frFnLn, toFnLn As String
		Dim RegEx As New VBScript_RegExp_55.RegExp ' РегЭкспы
		Dim colMatches As VBScript_RegExp_55.MatchCollection ' коллекция этих образцов
		Dim colMatchesC As VBScript_RegExp_55.MatchCollection ' коллекция этих образцов
		Dim aMatch As VBScript_RegExp_55.Match ' один из совпавших образцов
		
		RegEx.MultiLine = True ' многострочный текст
		RegEx.[Global] = True ' будем проходить всю строку
		RegEx.IgnoreCase = False ' не игнорируем регистр символов
		
		txt = rtf.Text
		
		rtf.Font = VB6.FontChangeGdiCharSet(rtf.Font, 204)
		rtf.Visible = False
		tmpStart = rtf.SelStart
		rtf.SelStart = 0
		rtf.SelLength = Len(txt)
		rtf.SelColor = msgMainTextColor
		rtf.BackColor = System.Drawing.ColorTranslator.FromOle(msgBackColor)
		rtf.SelStart = tmpStart
		
		If Not base Is Nothing Then
			'UPGRADE_WARNING: Couldn't resolve default property of object base.From. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If InStr(1, base.From, "[DEL]", CompareMethod.Text) <> 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object base.From. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				base.From = Replace(base.From, "[DEL]", "",  ,  , CompareMethod.Text)
				'UPGRADE_WARNING: Couldn't resolve default property of object base.rTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				base.rTo = Replace(base.rTo, "[DEL]", "",  ,  , CompareMethod.Text)
				'Exit Sub 'можно делать так вместо выше указанных строк
			End If
			
			'Забираем буковки
			RegEx.Pattern = "(.)(\w+)(.)" 'весьма хитрый паттерн. Он базово разделяет на слова(по пробелу) от которых оставлено слева 1 символ. нам интересны только эти символы
			'UPGRADE_WARNING: Couldn't resolve default property of object base.From. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			colMatches = RegEx.Execute(base.From)
			
			For	Each aMatch In colMatches ' проходим по всей коллекции
				'UPGRADE_WARNING: Couldn't resolve default property of object aMatch.SubMatches(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				frFnLn = frFnLn & aMatch.SubMatches(0)
			Next aMatch
			
			'UPGRADE_WARNING: Couldn't resolve default property of object base.rTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			colMatches = RegEx.Execute(base.rTo)
			
			For	Each aMatch In colMatches ' проходим по всей коллекции
				'UPGRADE_WARNING: Couldn't resolve default property of object aMatch.SubMatches(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				toFnLn = toFnLn & aMatch.SubMatches(0)
			Next aMatch
			
			frFnLn = Replace(Replace(frFnLn & ">", ")", "\)"), "(", "\(")
			toFnLn = Replace(Replace(toFnLn & ">", ")", "\)"), "(", "\(")
		End If
		
		'начинаем обработку текста
		
		'все фидошные адреса подчеркиваем
		RegEx.Pattern = "\d+:\d+/\d+\.{0,1}\d*" 'шаблон для выборки 4D адреса из 5D
		colMatches = RegEx.Execute(txt)
		
		For	Each aMatch In colMatches ' проходим по всей коллекции
			rtf.SelStart = aMatch.FirstIndex
			rtf.SelLength = aMatch.Length
			rtf.SelColor = msgOriginColor
			rtf.SelUnderline = True
		Next aMatch
		
		'это таглайн
		RegEx.Pattern = "\n\.\.\. (.*)\n" '...
		colMatches = RegEx.Execute(txt)
		
		For	Each aMatch In colMatches ' проходим по всей коллекции
			'начало и конец строчки
			rtf.SelStart = aMatch.FirstIndex
			rtf.SelLength = aMatch.Length
			rtf.SelColor = msgTirlineColor
		Next aMatch
		
		'это тирлайн
		RegEx.Pattern = "\n--- (.*)\n" '---
		colMatches = RegEx.Execute(txt)
		
		For	Each aMatch In colMatches ' проходим по всей коллекции
			'начало и конец строчки
			rtf.SelStart = aMatch.FirstIndex
			rtf.SelLength = aMatch.Length
			rtf.SelColor = msgTaglineColor
		Next aMatch
		
		'это ориджин
		RegEx.Pattern = "\s\* Origin:(.*)\)"
		colMatches = RegEx.Execute(txt)
		
		For	Each aMatch In colMatches ' проходим по всей коллекции
			'начало и конец строчки
			rtf.SelStart = aMatch.FirstIndex
			rtf.SelLength = aMatch.Length
			rtf.SelColor = msgOriginColor
		Next aMatch
		
		' _blah-blah-blah_
		RegEx.Pattern = "\s_(.*)_\s"
		colMatches = RegEx.Execute(txt)
		
		For	Each aMatch In colMatches ' проходим по всей коллекции
			'rtf.Text = Replace$(rtf.Text, aMatch.Value, " " & aMatch.SubMatches(0) & " ") 'заменит _
			'аа_ на просто ааа        'начало и конец строчки
			rtf.SelStart = aMatch.FirstIndex
			rtf.SelLength = aMatch.Length
			rtf.SelColor = msgOriginColor
			rtf.SelBold = True
		Next aMatch
		
		' *blah-blah-blah*
		RegEx.Pattern = "\s\*(.*)\*\s"
		colMatches = RegEx.Execute(txt)
		
		For	Each aMatch In colMatches ' проходим по всей коллекции
			'rtf.Text = Replace$(rtf.Text, aMatch.Value, " " & aMatch.SubMatches(0) & " ") 'заменит *ааа* на просто ааа
			'начало и конец строчки
			rtf.SelStart = aMatch.FirstIndex
			rtf.SelLength = aMatch.Length
			rtf.SelColor = msgOriginColor
			rtf.SelBold = True
		Next aMatch
		
		' /blah-blah-blah/
		RegEx.Pattern = "\s\/(.*)\/\s"
		colMatches = RegEx.Execute(txt)
		
		For	Each aMatch In colMatches ' проходим по всей коллекции
			'rtf.Text = Replace$(rtf.Text, aMatch.Value, " " & aMatch.SubMatches(0) & " ") 'заменит *ааа* на просто ааа
			'начало и конец строчки
			rtf.SelStart = aMatch.FirstIndex
			rtf.SelLength = aMatch.Length
			rtf.SelColor = msgOriginColor
			rtf.SelItalic = True
			rtf.SelBold = True
		Next aMatch
		
		'делаем подсветку строк
		'RegEx.Pattern = "(.*)\n" 'этот регексп дает все строчки
		'RegEx.Pattern = "\n.{0,4}>(.*)\r" 'а этот дает только строчки с цитатами
		RegEx.Pattern = ".{0,4}>(.*)\n" 'а этот дает только строчки с цитатами(более правельный вариант)
		colMatches = RegEx.Execute(txt)
		
		For	Each aMatch In colMatches ' проходим по всей коллекции строк. каждый матч это очередная строка
			'начало и конец строчки
			str_Renamed = aMatch.Value
			
			rtf.SelStart = aMatch.FirstIndex
			rtf.SelLength = aMatch.Length
			flg = False
			
			RegEx.Pattern = frFnLn
			
			If RegEx.Test(str_Renamed) Then
				RegEx.Pattern = ">+"
				colMatchesC = RegEx.Execute(str_Renamed)
				
				'UPGRADE_WARNING: Couldn't resolve default property of object colMatchesC().Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				If Len(colMatchesC(0).Value) Mod 2 <> 0 Then
					rtf.SelColor = msgAlienCitatColor
				Else
					rtf.SelColor = msgMyCitatColor
				End If
				
				flg = True
			End If
			
			RegEx.Pattern = toFnLn
			
			If RegEx.Test(str_Renamed) Then
				RegEx.Pattern = ">+"
				colMatchesC = RegEx.Execute(str_Renamed)
				
				'UPGRADE_WARNING: Couldn't resolve default property of object colMatchesC().Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				If Len(colMatchesC(0).Value) Mod 2 <> 0 Then
					rtf.SelColor = msgAlienCitatColor
				Else
					rtf.SelColor = msgMyCitatColor
				End If
				
				flg = True
			End If
			
			If Not flg Then
				RegEx.Pattern = ">+"
				colMatchesC = RegEx.Execute(str_Renamed)
				
				'UPGRADE_WARNING: Couldn't resolve default property of object colMatchesC().Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				If Len(colMatchesC(0).Value) Mod 2 <> 0 Then
					rtf.SelColor = msgMyCitatColor
				Else
					rtf.SelColor = msgAlienCitatColor
				End If
			End If
			
		Next aMatch
		
		'smiles
		If ParseSmiles Then
			ReplaceSmiles(rtf)
		End If
		
		'end
		'UPGRADE_NOTE: Object colMatchesC may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		colMatchesC = Nothing
		'UPGRADE_NOTE: Object colMatches may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		colMatches = Nothing
		'UPGRADE_NOTE: Object aMatch may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		aMatch = Nothing
		'UPGRADE_NOTE: Object RegEx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		RegEx = Nothing
		
		LockWindowUpdate(0)
		rtf.SelStart = tmpStart
		rtf.Visible = True
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 0
				Resume 
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "modTextWork::HingliteText")
		End Select
		
	End Sub
	
	Public Sub HighlightSample(ByRef rtf As AxRichTextLib.AxRichTextBox, ByRef colors() As Integer)
		Dim st, i, fn As Integer
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim txt, str_Renamed, tmp As String
		Dim strs() As String
		
		txt = rtf.Text
		strs = Split(txt, vbCrLf)
		
		rtf.Visible = False
		rtf.SelStart = 0
		rtf.SelLength = Len(txt)
		rtf.SelColor = colors(0)
		rtf.BackColor = System.Drawing.ColorTranslator.FromOle(colors(1))
		
		For i = 0 To UBound(strs)
			str_Renamed = strs(i)
			
			If Mid(str_Renamed, 1, 4) = "... " Then 'это таглайн
				rtf.SelStart = InStr(1, txt, "... ", CompareMethod.Text) - 1
				rtf.SelLength = Len(str_Renamed)
				rtf.SelColor = colors(5)
			End If
			
			If Mid(str_Renamed, 1, 4) = "--- " Then 'это тирлайн
				rtf.SelStart = InStr(1, txt, "--- ", CompareMethod.Text) - 1
				rtf.SelLength = Len(str_Renamed)
				rtf.SelColor = colors(4)
			End If
			
			If Mid(str_Renamed, 1, 4) = " * O" Then 'это ориджин
				rtf.SelStart = InStr(1, txt, " * O", CompareMethod.Text) - 1
				rtf.SelLength = Len(str_Renamed)
				rtf.SelColor = colors(6)
			End If
			
			If InStr(1, str_Renamed, ">") <> 0 Then
				If Mid(str_Renamed, InStr(1, str_Renamed, ">") + 1, 1) = ">" Then
					tmp = "XX"
					tmp = UCase(Mid(tmp, 1, 1) & Mid(tmp, InStr(1, tmp, " ") + 1, 1))
					
					If InStr(1, str_Renamed, tmp & ">>") <> 0 Then
						'это строчка от автора письма
						rtf.SelStart = InStr(1, txt, str_Renamed, CompareMethod.Text) - 1
						rtf.SelLength = Len(str_Renamed)
						rtf.SelColor = colors(2)
					ElseIf InStr(1, str_Renamed, ">>") <> 0 Then 
						rtf.SelStart = InStr(1, txt, str_Renamed, CompareMethod.Text) - 1
						rtf.SelLength = Len(str_Renamed)
						rtf.SelColor = colors(3)
					End If
					
				Else
					st = InStr(1, str_Renamed, ">")
					fn = InStr(st + 1, str_Renamed, ">")
					
					If fn - st > 2 Then
						If InStr(st + 1, str_Renamed, " ") <> 0 Then
							'цитата с XX>
							rtf.SelStart = InStr(1, txt, str_Renamed, CompareMethod.Text) - 1
							rtf.SelLength = Len(str_Renamed)
							rtf.SelColor = colors(2)
						End If
						
					Else
						
						If InStr(1, txt, str_Renamed) - 1 > 0 And Len(str_Renamed) > 1 Then
							If Mid(txt, InStr(1, txt, str_Renamed) - 1, 1) = vbLf Then
								'цитата с >
								rtf.SelStart = InStr(1, txt, str_Renamed, CompareMethod.Text) - 1
								rtf.SelLength = Len(str_Renamed)
								rtf.SelColor = colors(3)
							End If
						End If
					End If
				End If
			End If
			
		Next 
		
		rtf.SelStart = 0
		rtf.Visible = True
	End Sub
	
	'Функция возвращает True если необходима перекодировка в виндовс текст
	Public Function OEMRecoding(ByRef Text As String) As Boolean
		Dim frq(255) As Single
		Dim i As Integer
		Dim tmp As String
		
		If Len(Text) = 0 Then Exit Function
		
		For i = 1 To Len(Text)
			tmp = Mid(Text, i, 1)
			frq(Asc(tmp)) = frq(Asc(tmp)) + 1
		Next 
		
		For i = 0 To 255
			frq(i) = (frq(i) / Len(Text)) * 100
		Next 
		
		OEMRecoding = True 'Псевдографика отсутствует
		
		For i = 180 To 255
			
			If frq(i) >= 7.1 Then
				'Debug.Print frq(i); i
				OEMRecoding = False
				Exit For
			End If
			
		Next 
		
	End Function
	
	'Возвращает имя города(страны) по адресу
	Public Function addr2city(ByRef Address As String) As String
		Dim RegEx As New VBScript_RegExp_55.RegExp ' РегЭкспы
		Dim colMatches As VBScript_RegExp_55.MatchCollection ' коллекция этих образцов
		Dim aMatch As VBScript_RegExp_55.Match ' один из совпавших образцов
		Dim patt1, patt2 As String ' паттерны
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim str_Renamed As String
		Dim ff As Integer
		
		RegEx.MultiLine = True ' немногострочный текст
		RegEx.[Global] = True ' будем проходить всю строку
		RegEx.IgnoreCase = False ' не игнорируем регистр символов
		
		If Len(Address) = 0 Then
			addr2city = "Unknown City"
			'UPGRADE_NOTE: Object RegEx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
			RegEx = Nothing
			'UPGRADE_NOTE: Object colMatches may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
			colMatches = Nothing
			Exit Function
		End If
		
		'отсекаем номер поинта
		If InStr(1, Address, ".") <> 0 Then
			Address = Mid(Address, 1, InStr(1, Address, ".") - 1)
		End If
		
		'если у нас в адресе случайно нет ноды(например региональный адрес) то это надо обработать.
		If InStr(1, Address, "/") - 1 > 0 Then
			patt1 = Mid(Address, 1, InStr(1, Address, "/") - 1) & "(.*?)\s*=\s*(.*?)\n" 'определяет зону:сеть и "= Город"
			patt2 = Mid(Address, InStr(1, Address, "/"), Len(Address) - InStr(1, Address, "/") + 1) 'определяет узел "/node"
		Else
			patt1 = Address & "(.*?)\s*=\s*(.*?)\n" 'определяет зону:сеть и "= Город"
			patt2 = "" 'определяет узел "/node"
		End If
		
		RegEx.Pattern = patt1
		ff = FreeFile
		On Error Resume Next
		FileOpen(ff, VB6.GetPath & "\city.txt", OpenMode.Binary)
		str_Renamed = Space(LOF(ff))
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, str_Renamed)
		FileClose(ff)
		
		
		str_Renamed = str_Renamed & vbCrLf
		
		If RegEx.Test(str_Renamed) Then
			colMatches = RegEx.Execute(str_Renamed)
			
			' проходим по всей коллекции
			For	Each aMatch In colMatches
				
				'UPGRADE_WARNING: Couldn't resolve default property of object aMatch.SubMatches(0). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				If aMatch.SubMatches(0) = patt2 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object aMatch.SubMatches(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					addr2city = Replace(aMatch.SubMatches(1), vbCr, "")
					Exit For
				End If
				
			Next aMatch
			
			If Len(addr2city) = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				addr2city = Replace(colMatches.item(0).SubMatches(1), vbCr, "")
			End If
			
		Else
			addr2city = "Unknown City"
		End If
		
		'UPGRADE_NOTE: Object RegEx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		RegEx = Nothing
		'UPGRADE_NOTE: Object colMatches may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		colMatches = Nothing
		'UPGRADE_NOTE: Object aMatch may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		aMatch = Nothing
		
	End Function
	
	'Дает слово над которым находится курсор
	Public Function RichWordOver(ByRef rch As AxRichTextLib.AxRichTextBox, ByRef X As Single, ByRef Y As Single) As String
		Dim pt As POINTAPI
		Dim pos As Integer
		Dim start_pos As Integer
		Dim end_pos As Integer
		Dim ch As String
		Dim txt As String
		Dim txtlen As Integer
		
		' Convert the position to pixels.
		pt.X = X \ VB6.TwipsPerPixelX
		pt.Y = Y \ VB6.TwipsPerPixelY
		
		' Get the character number
		'UPGRADE_WARNING: Couldn't resolve default property of object pt. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		pos = modCommon.SendMessage(rch.hWnd, EM_CHARFROMPOS, 0, pt)
		
		If pos <= 0 Then Exit Function
		
		' Find the start of the word.
		txt = rch.Text
		
		For start_pos = pos To 1 Step -1
			ch = Mid(rch.Text, start_pos, 1)
			
			If ch = " " Or ch = vbLf Then
				Exit For
			End If
			
		Next start_pos
		
		start_pos = start_pos + 1
		
		' Find the end of the word.
		txtlen = Len(txt)
		
		For end_pos = pos To txtlen
			ch = Mid(txt, end_pos, 1)
			
			If ch = " " Or ch = vbLf Then
				Exit For
			End If
			
		Next end_pos
		
		end_pos = end_pos - 1
		
		If start_pos <= end_pos Then RichWordOver = Mid(txt, start_pos, end_pos - start_pos + 1)
	End Function
	
	'Дает слово на котором кликнули
	Public Function RichWordClick(ByRef rch As AxRichTextLib.AxRichTextBox) As String
		Dim pos1 As Integer
		Dim pos2 As Integer
		Dim txt As String
		Dim txtlen As Integer
		
		' Find the beginning of the word.
		pos1 = rch.SelStart
		txt = rch.Text
		
		If Len(txt) = 0 Then
			Exit Function
		End If
		
		If pos1 > 1 Then
			
			Do While Mid(txt, pos1, 1) <> " "
				pos1 = pos1 - 1
				
				If pos1 <= 1 Then Exit Do
			Loop 
			
			If pos1 > 1 Then pos1 = pos1 + 1
		End If
		
		' Find the end of the word.
		pos2 = pos1
		
		If pos2 = 0 Then Exit Function
		txtlen = Len(txt)
		
		Do While Mid(txt, pos2, 1) <> " "
			pos2 = pos2 + 1
			
			If pos2 > txtlen Then Exit Do
		Loop 
		
		If pos2 <= txtlen Then pos2 = pos2 - 1
		
		txt = Mid(txt, pos1, pos2 - pos1 + 1)
		
		RichWordClick = txt
		
	End Function
	
	'Сохраняет мессаг в файл с соответствующим типом.
	Public Sub EditorSaveMessage(ByRef rtf As AxRichTextLib.AxRichTextBox, ByRef msgFields As MessageSaveFields, Optional ByRef SaveType As SaveMessageType = SaveMessageType.SaveText)
		On Error GoTo errHandler
		Dim ourText, ssFile, tpl As String
		Dim ff As Integer
		Dim tmp As String
		
		tpl = "- " & msgFields.Description & "(" & msgFields.AKA & ") ------------------------------ " & msgFields.EchoName & " -" & vbCrLf
		tpl = tpl & "Msg   : " & msgFields.MessageNumber & " из " & msgFields.TotalMessages & vbCrLf
		tpl = tpl & "From : " & msgFields.From & "                    " & msgFields.FromAddr & "      " & msgFields.DateWritten & vbCrLf
		tpl = tpl & "To      : " & msgFields.To_Renamed & "                    " & msgFields.ToAddr & "      " & msgFields.DateArrived & vbCrLf
		tpl = tpl & "Subj   : " & msgFields.Subject & vbCrLf
		tpl = tpl & "-------------------------------------------------------------------------------" & vbCrLf
		
		modCommonDialog.SaveDialogTitle = "Сохранить сообщение как...."
		modCommonDialog.Flags = cdlOFNHideReadOnly
		modCommonDialog.FilterIndex = 2
		
		Select Case SaveType
			
			Case SaveMessageType.SaveText
				modCommonDialog.Filter_Renamed = "All Files (*.*)|*.*|Text Files(*.txt)|*.txt|"
				ssFile = modCommonDialog.ShowSave(VB6.GetPath)
				
				If Len(ssFile) = 0 Then
					Exit Sub
				End If
				
				ourText = tpl & rtf.Text
				
			Case SaveMessageType.SaveRTF
				modCommonDialog.Filter_Renamed = "All Files (*.*)|*.*|RichText Files(*.rtf)|*.rtf|"
				ssFile = modCommonDialog.ShowSave(VB6.GetPath)
				
				If Len(ssFile) = 0 Then
					Exit Sub
				End If
				
				LockWindowUpdate(rtf.hWnd)
				tmp = rtf.Text
				rtf.Text = tpl & rtf.Text
				HighlightTextPlain(rtf)
				ourText = rtf.TextRTF
				rtf.Text = tmp
				HighlightTextPlain(rtf)
				LockWindowUpdate(0)
				
			Case SaveMessageType.SaveHTML
				'not implemented
				Exit Sub
		End Select
		
		ff = FreeFile
		FileOpen(ff, ssFile, OpenMode.Binary)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, ourText)
		FileClose(ff)
		
		MsgBox("Сообщение успешно сохранено.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "modTextWork::EditorSaveMessage")
		End Select
		
	End Sub
	
	'возвращает цвет в формате пригодном для html
	Private Function LongColorToRGB(ByRef Color As Integer) As String
		Dim g, r, b As String
		
		r = Hex(Color And &HFFs)
		g = Hex((Color \ &H100s) And &HFFs)
		b = Hex((Color \ &H10000) And &HFFs)
		
		If Len(r) = 1 Then
			r = "0" & r
		End If
		
		If Len(g) = 1 Then
			g = "0" & g
		End If
		
		If Len(b) = 1 Then
			b = "0" & b
		End If
		
		LongColorToRGB = "#" & r & g & b
		
	End Function
	
	Public Sub LoadSmiles()
		On Error GoTo errHandler
		Dim ff As Integer
		Dim tmp As String
		
		ff = FreeFile
		FileOpen(ff, VB6.GetPath & "\smilez\defsmile.txt", OpenMode.Binary)
		tmp = Space(LOF(ff))
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, tmp)
		FileClose(ff)
		
		Erase SmileRows
		
		If Len(tmp) = 0 Then
			ReDim SmileRows(0)
			SmileRows(0) = "nothing"
			Exit Sub
		End If
		
		SmileRows = Split(tmp, vbCrLf)
		tmp = vbNullString
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 53
				ReDim SmileRows(0)
				SmileRows(0) = "nothing"
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "modTextWork::LoadSmiles")
		End Select
		
	End Sub
	
	Public Sub ReplaceSmiles(ByRef rtf As AxRichTextLib.AxRichTextBox)
		On Error GoTo errHandler
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim tmp, str_Renamed As String
		Dim smilerow() As String
		Dim i, st As Integer
		Dim sst As String
		Dim sLen As Integer
		
		str_Renamed = rtf.Text
		
		If SmileRows(0) <> "nothing" Then
			
			For i = 0 To UBound(SmileRows)
				
				If Len(SmileRows(i)) <> 0 And InStr(1, SmileRows(i), "_") <> 0 Then
					smilerow = Split(SmileRows(i), "_")
					'0 - slile, 1 - file
					sst = " " & smilerow(0) 'смайлы начинаются с пробела
					sLen = Len(sst)
					tmp = Replace(smilerow(1), "*", VB6.GetPath)
					
					st = InStr(1, str_Renamed, sst)
					While st <> 0
						
						ReplaceSm(rtf, sst, tmp, st + sLen + 1)
						
						str_Renamed = Replace(str_Renamed, sst, Space(sLen),  , 1)
						st = st + sLen
						While Mid(str_Renamed, st, 1) <> " " And st < Len(str_Renamed) And Mid(sst, sLen, 1) = Mid(str_Renamed, st, 1)
							st = st + 1
							
							ReplaceSm(rtf, Mid(sst, sLen, 1), tmp, st + 2, st - Len(tmp))
							str_Renamed = Replace(str_Renamed, Mid(sst, sLen, 1), " ",  , 1)
							
						End While
						st = InStr(1, str_Renamed, sst)
					End While
				End If
				
			Next i
			
			Exit Sub
			
		End If
		
		'no smiles
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "modTextWork::ReplaceSmiles")
		End Select
		
	End Sub
	
	Private Sub ReplaceSm(ByRef rtf As AxRichTextLib.AxRichTextBox, ByRef Smile As String, ByRef File As String, ByRef vEnd As Integer, Optional ByRef Start As Integer = 0)
		LockWindowUpdate(rtf.hWnd)
		
		'UPGRADE_ISSUE: PictureBox method picShow.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		frmMain.picShow.Cls()
		frmMain.DefInstance.picShow.Image = System.Drawing.Image.FromFile(File)
		'UPGRADE_ISSUE: Clipboard method Clipboard.Clear was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		Clipboard.Clear()
		'UPGRADE_ISSUE: Clipboard method Clipboard.SetData was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		Clipboard.SetData(frmMain.DefInstance.picShow.Image)
		
		If rtf.Name = "MailViewer" Then
			rtf.Locked = False
		End If
		
		rtf.Find(Smile, Start, vEnd)
		modCommon.SendMessage(rtf.hWnd, WM_PASTE, 0, 0)
		
		If rtf.Name = "MailViewer" Then
			rtf.Locked = True
		End If
		
		'UPGRADE_ISSUE: Clipboard method Clipboard.Clear was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		Clipboard.Clear()
		LockWindowUpdate(0)
		
	End Sub
End Module