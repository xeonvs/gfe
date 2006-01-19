Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class msgBase
	'Класс для работы с *.msg базой 2003 (c) Max `Xeon` Irgiznov
	
	'прекодировка windows to dos
	Private Declare Function CharToOem Lib "user32"  Alias "CharToOemA"(ByVal lpszSrc As String, ByVal lpszDst As String) As Integer
	
	'прекодировка dos to windows
	Private Declare Function OemToChar Lib "user32"  Alias "OemToCharA"(ByVal lpszSrc As String, ByVal lpszDst As String) As Integer
	
	'флаги сообщения
	Public Enum MSG_ATTRIBUTES
		Msg_Private = &H1s '/*+Pvt - Личное                            */
		Msg_Crash = &H2s '/*+Cra - Высокопpиоpитетное                */
		Msg_Read = &H4s '/* Rec - Пpочитано полyчателем             */
		Msg_Sent = &H8s '/* Snt - Послано                           */
		Msg_File = &H10s '/*+Att - Файлатач                          */
		Msg_Transit = &H20s '/* Trs - Тpанзитное                        */
		Msg_Orphan = &H40s '/* Orp - Полyчатель не сyществyет          */
		Msg_Kill = &H80s '/* K/s - Удалить после отсылки             */
		Msg_Local = &H100s '/* Loc - Создано на данном yзле            */
		Msg_Hold = &H200s '/* Hld - Отсылка по входящемy звонкy       */
		Msg_FReq = &H800s '/* FRq - Запpос файла                      */
		Msg_RReq = &H1000s '/*+RRq - Запpос подтвеpждения пpиема       */
		Msg_IsRR = &H2000s '/*+RRc - Подтвеpждение пpиема              */
		Msg_AReq = &H4000s '/*+ARq - Audit request ???                 */
		Msg_FUpsReq = &H8000s '/* URq - Запpос обновления файла           */
	End Enum
	
	'заголовок файлов *.msg
	Private Structure MessageHeader
		<VBFixedString(36),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=36)> Public FromUserName As String
		<VBFixedString(36),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=36)> Public ToUserName As String
		<VBFixedString(72),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=72)> Public Subject As String
		<VBFixedString(20),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=20)> Public DateTime As String
		Dim TimedRead As Short
		Dim DestNode As Short
		Dim OrigNode As Short
		Dim Cost As Short
		Dim OrigNet As Short
		Dim DestNet As Short
		Dim Date_written As Integer
		Dim Date_arrived As Integer
		Dim ReplyTo As Short
		Dim Attribute As Short
		Dim ReplyNext As Short
		'далее идет текст мессага оканчивающийся нулем.
	End Structure
	
	'делаем комплекс представляющий из себя один мессаг
	Private Structure MsgColl
		Dim Header As MessageHeader
		<VBFixedArray(1)> Dim zone() As Short 'Зона письма: 0-orig, 1-dest
		Dim FileName As String
		'UPGRADE_NOTE: Date was upgraded to Date_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Date_Renamed As Date
		
		'UPGRADE_TODO: "Initialize" must be called to initialize instances of this structure. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1026"'
		Public Sub Initialize()
			ReDim zone(1)
		End Sub
	End Structure
	
	Private Messages() As MsgColl 'все загруженные заголовки мессаг
	'UPGRADE_WARNING: Lower bound of array Months was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1033"'
	Private Months(12) As String 'Сокращенные названия месяцов.
	
	'~~~~~~~~~~~~~~~~~~~~~переменные для свойств
	Private strDBname As String 'local copy
	Private strEchoName As String 'local copy
	Private numMessages As Integer 'local copy
	Private msgFrom As String 'local copy
	Private msgFromAddr As String 'local copy
	Private msgTo As String 'local copy
	Private msgToAddr As String 'local copy
	Private msgDateTime As String 'local copy
	Private msgDateWritten As Integer 'local copy
	Private msgDateArrived As Integer 'local copy
	Private msgSubj As String 'local copy
	Private msgText As String 'local copy
	Private msgFlags As Integer 'local copy
	Private msgReplayTo As Integer 'local copy
	Private msgReplayNext As Integer 'local copy
	'~~~~~~~~~~~~~~~~~~~~~
	
	'~~~.BaseType - возвращает тип базы
	Public ReadOnly Property BaseType() As String
		Get
			BaseType = "MSG"
		End Get
	End Property
	
	'проперти для получения мессага
	'возвращает раскодированную структуру одного сообщения
	
	Public Property From() As String
		Get
			From = msgFrom
		End Get
		Set(ByVal Value As String)
			msgFrom = Value
		End Set
	End Property
	
	
	Public Property FromAddr() As String
		Get
			FromAddr = msgFromAddr
		End Get
		Set(ByVal Value As String)
			msgFromAddr = Value
		End Set
	End Property
	
	
	Public Property rTo() As String
		Get
			rTo = msgTo
		End Get
		Set(ByVal Value As String)
			msgTo = Value
		End Set
	End Property
	
	
	Public Property rToAddr() As String
		Get
			rToAddr = msgToAddr
		End Get
		Set(ByVal Value As String)
			msgToAddr = Value
		End Set
	End Property
	
	
	Public Property DateWritten() As Integer
		Get
			DateWritten = msgDateWritten
		End Get
		Set(ByVal Value As Integer)
			msgDateWritten = Value
		End Set
	End Property
	
	
	Public Property DateArrived() As Integer
		Get
			DateArrived = msgDateArrived
		End Get
		Set(ByVal Value As Integer)
			msgDateArrived = Value
		End Set
	End Property
	
	
	Public Property Subj() As String
		Get
			Subj = msgSubj
		End Get
		Set(ByVal Value As String)
			msgSubj = Value
		End Set
	End Property
	
	
	Public Property Message() As String
		Get
			Message = msgText
		End Get
		Set(ByVal Value As String)
			msgText = Value
		End Set
	End Property
	
	
	Public Property MessageFlags() As Integer
		Get
			MessageFlags = msgFlags
		End Get
		Set(ByVal Value As Integer)
			msgFlags = Value
		End Set
	End Property
	
	
	Public Property ReplayTo() As Integer
		Get
			ReplayTo = msgReplayTo
		End Get
		Set(ByVal Value As Integer)
			msgReplayTo = Value
		End Set
	End Property
	
	
	Public Property ReplayNext() As Integer
		Get
			ReplayNext = msgReplayNext
		End Get
		Set(ByVal Value As Integer)
			msgReplayNext = Value
		End Set
	End Property
	
	
	Public Property ReplayFirst() As Integer
		Get
			ReplayFirst = 0 'null
		End Get
		Set(ByVal Value As Integer)
			'null
		End Set
	End Property
	
	
	Public Property ReplayNextS() As String
		Get
			ReplayNextS = ""
		End Get
		Set(ByVal Value As String)
			'null action
		End Set
	End Property
	'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
	
	'~~~.DBName - Устанавливает\получает путь базы для работы
	
	'~~~.DBName - Устанавливает\получает путь базы для работы
	Public Property DBName() As String
		Get
			DBName = strDBname
		End Get
		Set(ByVal Value As String)
			strDBname = Value
		End Set
	End Property
	
	'~~~.EchoName Устанавливает\получает имя текущей конференции
	
	'~~~.EchoName Устанавливает\получает имя текущей конференции
	Public Property EchoName() As String
		Get
			EchoName = strEchoName
		End Get
		Set(ByVal Value As String)
			strEchoName = Value
		End Set
	End Property
	
	'~~~.MessageCountByEchoName - возвращает число мессаг в области
	Public ReadOnly Property MessageCountByEcho(ByVal Echo As String) As Integer
		Get
			On Error GoTo errHandler
			Dim RegEx As New VBScript_RegExp_55.RegExp
			Dim fs As New Scripting.FileSystemObject
			Dim LFiles As Scripting.Files
			Dim sfld As Scripting.File
			Dim numm As Integer
			
			LFiles = fs.GetFolder(Echo).Files
			
			numm = 1
			
			'задаем шаблон для регекспов
			RegEx.Pattern = PtrnKonv("*.msg")
			RegEx.IgnoreCase = True
			
			For	Each sfld In LFiles
				
				'тестим файл регекспом
				If RegEx.Test(sfld.Name) Then
					numm = numm + 1
				End If
				
			Next sfld
			
			MessageCountByEcho = numm - 1
			LFiles = Nothing
			Exit Property
errHandler: 
			
			Select Case Err.Number
				
				Case 76
					MsgBox("Ошибка!" & vbCrLf & "Путь к Netmail области не найден!", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
					
				Case -2147024770
					MsgBox("Ошибка инициализации FileSystemObject!", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
					
				Case Else
					ErrorMessage(Err.Number, Err.Description, "msgBase::MessageCountByEcho")
			End Select
			
		End Get
	End Property
	
	'~~~.MessageCount - возвращает число мессаг в области(пока еще и тех которые не отпуржены)
	Public ReadOnly Property MessageCount() As Integer
		Get
			MessageCount = numMessages
		End Get
	End Property
	
	'~~~.GetMessageByNum - возвращает мессаг по его номеру
	Public Sub GetMessageByNum(ByRef NumberMessage As Integer)
		On Error GoTo errHandler
		Dim tmp, FileN As String
		Dim ff As Short
		
		'своеобразная обработка ошибок, когда нам не нужен этот метод мы вызаваем его с 0 параметром
		If NumberMessage = 0 Then
			Exit Sub
		ElseIf numMessages <= 0 Then 
			Exit Sub
		ElseIf NumberMessage > numMessages Then 
			Exit Sub
		End If
		
		ff = FreeFile : FileN = strDBname & "\" & Messages(NumberMessage).FileName
		FileOpen(ff, FileN, OpenMode.Binary)
		tmp = Space(LOF(ff) - 190)
		Seek(ff, 191)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, tmp) 'читаем текст
		FileClose(ff)
		
		msgText = Space(Len(tmp))
		OemToChar(tmp, msgText)
		msgText = Trim(msgText)
		
		msgText = Replace(msgText, vbLf, vbCrLf)
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 76
				MsgBox("Ошибка!" & vbCrLf & "Путь к Netmail области не найден!", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "msgBase::GetMessageByNum")
		End Select
		
	End Sub
	
	'~~~.GetMessageSourceByNum возвращает дамп мессага по номеру
	Public Function GetMessageDumpByNum(ByRef NumberMessage As Integer) As String
		On Error GoTo errHandler
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim tmp, str_Renamed, txt As String
		Dim ff As Integer
		Dim rArr() As Byte
		Dim hdr As MessageHeader
		
		'своеобразная обработка ошибок, когда нам не нужен этот метод мы вызаваем его с 0 параметром
		If NumberMessage = 0 Then
			Exit Function
		ElseIf numMessages <= 0 Then 
			Exit Function
		ElseIf NumberMessage > numMessages Then 
			Exit Function
		End If
		
		str_Renamed = "Hexdump of Fido/Opus-style message header and text" & vbCrLf
		str_Renamed = str_Renamed & "------------------------------------------------------------------------------" & vbCrLf & vbCrLf
		
		'дамп заголовка письма
		With Messages(NumberMessage).Header
			str_Renamed = str_Renamed & "File" & vbTab & vbTab & ": " & strDBname & "\" & Messages(NumberMessage).FileName & vbCrLf
			str_Renamed = str_Renamed & "From" & vbTab & vbTab & ": " & Replace(.FromUserName, Chr(0), "") & vbCrLf
			str_Renamed = str_Renamed & "To" & vbTab & vbTab & ": " & Replace(.ToUserName, Chr(0), "") & vbCrLf
			str_Renamed = str_Renamed & "Subject" & vbTab & vbTab & ": " & Replace(.Subject, Chr(0), "") & vbCrLf
			str_Renamed = str_Renamed & "DateTime" & vbTab & ": " & Replace(.DateTime, Chr(0), "") & vbCrLf
			str_Renamed = str_Renamed & "OrigAddr" & vbTab & vbTab & ": " & .OrigNet & "/" & .OrigNode & vbCrLf
			str_Renamed = str_Renamed & "DestAddr" & vbTab & ": " & .DestNet & "/" & .DestNode & vbCrLf
			str_Renamed = str_Renamed & "Reply" & vbTab & vbTab & ": " & .ReplyTo & vbTab & "See : " & .ReplyNext & vbCrLf
			str_Renamed = str_Renamed & "TimesRead" & vbTab & ": " & .TimedRead & vbTab & "Cost: " & .Cost & vbCrLf
			str_Renamed = str_Renamed & "Attribute" & vbTab & vbTab & ": " & .Attribute & " (" & Hex(.Attribute) & "h)" & vbCrLf
			str_Renamed = str_Renamed & "Written" & vbTab & vbTab & ": " & sUnixDate(.Date_written) & " (" & Hex(.Date_written) & "h)" & vbCrLf
			str_Renamed = str_Renamed & "Arrived" & vbTab & vbTab & ": " & sUnixDate(.Date_arrived) & " (" & Hex(.Date_arrived) & "h)" & vbCrLf & vbCrLf
		End With
		
		ff = FreeFile
		'Hexdump of message header:
		str_Renamed = str_Renamed & "Hexdump of message header:" & vbCrLf
		ReDim rArr(Len(hdr))
		FileOpen(ff, strDBname & "\" & Messages(NumberMessage).FileName, OpenMode.Binary)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, rArr)
		
		tmp = DumpByteArray(rArr)
		txt = Space(Len(tmp))
		OemToChar(tmp, txt)
		txt = Trim(txt)
		
		str_Renamed = str_Renamed & Replace(txt, vbLf, vbCrLf) & vbCrLf & vbCrLf
		
		'text
		str_Renamed = str_Renamed & "Hexdump message text:" & vbCrLf
		Seek(ff, Len(hdr) + 1)
		ReDim rArr(LOF(ff) - Len(hdr))
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, rArr)
		
		tmp = DumpByteArray(rArr)
		txt = Space(Len(tmp))
		OemToChar(tmp, txt)
		txt = Trim(txt)
		
		str_Renamed = str_Renamed & Replace(txt, vbLf, vbCrLf) & vbCrLf & vbCrLf
		FileClose(ff)
		
		'done
		GetMessageDumpByNum = str_Renamed
		Exit Function
		
errHandler: 
		
		Select Case Err.Number
			
			Case 76
				MsgBox("Ошибка!" & vbCrLf & "Путь к Netmail области не найден!", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "msgBase::GetMessageDumpByNum")
		End Select
		
	End Function
	
	'~~~.OpenDB - открывает базу сообщений и загружает их в память
	Public Sub OpenDB()
		On Error GoTo errHandler
		Dim hdr As MessageHeader
		Dim ff As Short
		Dim RegEx As New VBScript_RegExp_55.RegExp
		Dim RegExMsg As New VBScript_RegExp_55.RegExp
		Dim fs As New Scripting.FileSystemObject
		Dim LFiles As Scripting.Files
		Dim sfld As Scripting.File
		Dim txt As String
		Dim colMatches As VBScript_RegExp_55.MatchCollection ' коллекция этих образцов
		
		LFiles = fs.GetFolder(strDBname).Files
		
		numMessages = 1
		
		'задаем шаблон для регекспов
		RegEx.Pattern = PtrnKonv("*.msg")
		RegEx.IgnoreCase = True
		RegExMsg.IgnoreCase = True
		RegExMsg.[Global] = True
		RegExMsg.MultiLine = True
		
		For	Each sfld In LFiles
			
			'тестим файл регекспом
			If RegEx.Test(sfld.Name) And sfld.Size <> 0 Then
				
				ff = FreeFile
				FileOpen(ff, sfld.Path, OpenMode.Binary)
				'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
				FileGet(ff, hdr) 'читаем заголовок
				'UPGRADE_WARNING: Array Messages may need to have individual elements initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1042"'
				ReDim Preserve Messages(numMessages)
				'UPGRADE_WARNING: Couldn't resolve default property of object Messages().Header. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				Messages(numMessages).Header = hdr
				Messages(numMessages).FileName = LCase(sfld.Name)
				Messages(numMessages).Date_Renamed = sfld.DateCreated
				
				'забираем зону из текста письма(если зона неизвестна, то предположим чтоона равна 2)
				txt = Space(LOF(ff) - 190)
				Seek(ff, 191)
				'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
				FileGet(ff, txt) 'читаем текст
				'MSGID: 2:5151/36.20@FigoNet    - "MSGID:\s(\d+):(\d+)/\d+\..*"
				'INTL 2:5151/36 2:5151/36.20    - "INTL\s(\d+):(\d+)/\d+\s.*"
				RegExMsg.Pattern = "MSGID:\s(\d+):(\d+)/\d+\.{0,1}\d*"
				colMatches = RegExMsg.Execute(txt)
				
				If colMatches.Count <> 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					Messages(numMessages).zone(0) = CShort(colMatches.item(0).SubMatches(0))
				Else
					Messages(numMessages).zone(0) = 2
				End If
				
				RegExMsg.Pattern = "INTL\s(\d+):(\d+)/\d+\s.*"
				colMatches = RegExMsg.Execute(txt)
				
				If colMatches.Count <> 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					Messages(numMessages).zone(1) = CShort(colMatches.item(0).SubMatches(0))
				Else
					Messages(numMessages).zone(1) = 2
				End If
				
				'UPGRADE_NOTE: Object colMatches may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
				colMatches = Nothing
				
				numMessages = numMessages + 1
				FileClose(1)
				
			End If
			
		Next sfld
		
		numMessages = numMessages - 1
		'UPGRADE_NOTE: Object LFiles may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		LFiles = Nothing
		
		SortByDate()
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 76
				MsgBox("Ошибка!" & vbCrLf & "Путь к Netmail области не найден!", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "msgBase::OpenDB")
		End Select
		
	End Sub
	
	'~~~.GetHeadersByNum - возвращает поля мессага по его номеру
	Public Sub GetHeadesByNum(ByRef NumberMessage As Integer)
		On Error GoTo errHandler
		Dim tmp As String
		
		'своеобразная обработка ошибок, когда нам не нужен этот метод мы вызаваем его с 0 параметром
		If NumberMessage = 0 Then
			Exit Sub
		ElseIf numMessages <= 0 Then 
			Exit Sub
		ElseIf NumberMessage > numMessages Then 
			Exit Sub
		End If
		
		msgFrom = Messages(NumberMessage).Header.FromUserName
		msgFromAddr = CStr(Messages(NumberMessage).zone(0)) & ":" & Messages(NumberMessage).Header.OrigNet & "/" & Messages(NumberMessage).Header.OrigNode
		msgTo = Messages(NumberMessage).Header.ToUserName
		msgToAddr = CStr(Messages(NumberMessage).zone(1)) & ":" & Messages(NumberMessage).Header.DestNet & "/" & Messages(NumberMessage).Header.DestNode
		msgSubj = Messages(NumberMessage).Header.Subject
		msgFlags = Messages(NumberMessage).Header.Attribute
		msgDateTime = Messages(NumberMessage).Header.DateTime
		msgDateArrived = Messages(NumberMessage).Header.Date_arrived
		msgDateWritten = Messages(NumberMessage).Header.Date_written
		msgReplayTo = Messages(NumberMessage).Header.ReplyTo
		msgReplayNext = Messages(NumberMessage).Header.ReplyNext
		
		'конвертим
		tmp = Space(Len(msgFrom))
		OemToChar(msgFrom, tmp)
		msgFrom = Mid(tmp, 1, InStr(1, tmp, Chr(0), CompareMethod.Binary) - 1)
		tmp = Space(Len(msgTo))
		OemToChar(msgTo, tmp)
		msgTo = Mid(tmp, 1, InStr(1, tmp, Chr(0), CompareMethod.Binary) - 1)
		tmp = Space(Len(msgSubj))
		OemToChar(msgSubj, tmp)
		msgSubj = Mid(tmp, 1, InStr(1, tmp, Chr(0), CompareMethod.Binary) - 1)
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "msgBase::GetHeadesByNum")
		End Select
		
	End Sub
	
	'~~~.GetHeadersByNumForTree - возвращает поля мессага по его номеру Для построения дерева.
	Public Sub GetHeadesByNumForTree(ByRef NumberMessage As Integer)
		On Error GoTo errHandler
		Dim tmp As String
		
		'своеобразная обработка ошибок, когда нам не нужен этот метод мы вызаваем его с 0 параметром
		If NumberMessage = 0 Then
			Exit Sub
		ElseIf numMessages <= 0 Then 
			Exit Sub
		ElseIf NumberMessage > numMessages Then 
			Exit Sub
		End If
		
		msgReplayTo = Messages(NumberMessage).Header.ReplyTo
		msgReplayNext = Messages(NumberMessage).Header.ReplyNext
		msgSubj = Messages(NumberMessage).Header.Subject
		msgFrom = Messages(NumberMessage).Header.FromUserName
		
		tmp = Space(Len(msgSubj))
		OemToChar(msgSubj, tmp)
		msgSubj = Mid(tmp, 1, InStr(1, tmp, Chr(0), CompareMethod.Binary) - 1)
		tmp = Space(Len(msgFrom))
		OemToChar(msgFrom, tmp)
		msgFrom = Mid(tmp, 1, InStr(1, tmp, Chr(0), CompareMethod.Binary) - 1)
		Exit Sub
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "msgBase::GetHeadesByNumForTree")
		End Select
		
	End Sub
	
	'~~~.GetHeadersByNumAll - возвращает поля мессага по его номеру, медленный метод из-за обрашения к телу мессага.
	Public Sub GetHeadesByNumAll(ByRef NumberMessage As Integer)
		On Error GoTo errHandler
		Dim tmp, FileN As String
		Dim ff As Short
		Dim ns, i, nf As Integer
		Dim txts() As String
		Dim dd, tpt, fpt, fd As String
		
		'своеобразная обработка ошибок, когда нам не нужен этот метод мы вызаваем его с 0 параметром
		If NumberMessage = 0 Then
			Exit Sub
		ElseIf numMessages <= 0 Then 
			Exit Sub
		ElseIf NumberMessage > numMessages Then 
			Exit Sub
		End If
		
		ff = FreeFile : FileN = strDBname & "\" & Messages(NumberMessage).FileName
		tmp = Space(FileLen(FileN) - 190)
		FileOpen(ff, FileN, OpenMode.Binary)
		Seek(ff, 191)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, tmp) 'читаем текст
		FileClose(ff)
		
		txts = Split(tmp, vbCr)
		
		'теперь соберем адреса в целую конструкцию используя кладжи в тексте
		'"TOPT " - TO Point Number
		'"FMPT " - From Point Number
		'"MSGID: " - From ID
		'"REPLY: " - To ID
		For i = 0 To UBound(txts)
			ns = InStr(1, txts(i), Chr(1) & "TOPT ")
			
			If ns <> 0 Then
				tpt = Mid(txts(i), ns + 6, Len(txts(i)))
			ElseIf InStr(1, txts(i), Chr(1) & "FMPT ") <> 0 Then 
				fpt = Mid(txts(i), InStr(1, txts(i), Chr(1) & "FMPT ") + 6, Len(txts(i)))
			End If
			
			nf = InStr(1, txts(i), Chr(1) & "MSGID: ")
			
			If nf <> 0 Then
				nf = InStr(nf + 1, txts(i), " ") + 1
				dd = Mid(txts(i), nf, InStr(nf, txts(i), ":") - nf)
			End If
			
			nf = InStr(1, txts(i), Chr(1) & "REPLY: ")
			
			If nf <> 0 Then
				nf = InStr(nf + 1, txts(i), " ") + 1
				fd = Mid(txts(i), nf, InStr(nf, txts(i), ":") - nf)
			End If
			
		Next i
		
		msgFrom = Messages(NumberMessage).Header.FromUserName
		
		If Len(fpt) = 0 Then
			fpt = "0" 'если у нас нодовый адрес
		End If
		
		msgFromAddr = dd & ":" & Messages(NumberMessage).Header.OrigNet & "/" & Messages(NumberMessage).Header.OrigNode & "." & fpt
		msgTo = Messages(NumberMessage).Header.ToUserName
		
		If Len(tpt) = 0 Then
			tpt = "0" 'если у нас нодовый адрес
		End If
		
		msgToAddr = fd & ":" & Messages(NumberMessage).Header.DestNet & "/" & Messages(NumberMessage).Header.DestNode & "." & tpt
		msgSubj = Messages(NumberMessage).Header.Subject
		msgFlags = Messages(NumberMessage).Header.Attribute
		msgDateTime = Messages(NumberMessage).Header.DateTime
		msgDateArrived = Messages(NumberMessage).Header.Date_arrived
		msgDateWritten = Messages(NumberMessage).Header.Date_written
		msgReplayTo = Messages(NumberMessage).Header.ReplyTo
		msgReplayNext = Messages(NumberMessage).Header.ReplyNext
		
		'конвертим
		tmp = Space(Len(msgFrom))
		OemToChar(msgFrom, tmp)
		msgFrom = Mid(tmp, 1, InStr(1, tmp, Chr(0), CompareMethod.Binary) - 1)
		tmp = Space(Len(msgTo))
		OemToChar(msgTo, tmp)
		msgTo = Mid(tmp, 1, InStr(1, tmp, Chr(0), CompareMethod.Binary) - 1)
		tmp = Space(Len(msgSubj))
		OemToChar(msgSubj, tmp)
		msgSubj = Mid(tmp, 1, InStr(1, tmp, Chr(0), CompareMethod.Binary) - 1)
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 76
				MsgBox("Ошибка!" & vbCrLf & "Путь к Netmail области не найден!", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "msgBase::GetHeadesByNumAll")
		End Select
		
	End Sub
	
	'~~~.DeleteMessageByNum
	Public Sub DeleteMessageByNum(ByRef NumberMessage As Integer)
		On Error GoTo errHandler
		Dim i As Integer
		
		'своеобразная обработка ошибок, когда нам не нужен этот метод мы вызаваем его с 0 параметром
		If NumberMessage = 0 Then
			Exit Sub
		ElseIf numMessages <= 0 Then 
			Exit Sub
		ElseIf NumberMessage > numMessages Then 
			Exit Sub
		End If
		
		For i = NumberMessage To numMessages - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object Messages(i). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Messages(i) = Messages(i + 1)
		Next 
		
		'удаляем на диске
		Kill(strDBname & "\" & CStr(Messages(NumberMessage).FileName))
		
		'удаляем в памяти
		ReDim Preserve Messages(numMessages - 1)
		numMessages = numMessages - 1
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 76
				MsgBox("Ошибка!" & vbCrLf & "Путь к Netmail области не найден!", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "msgBase::DeleteMessageByNum")
		End Select
		
	End Sub
	
	'~~~.WriteMessage - Пишет сообщение в выбранную базу. Возвращает -1 в случае неудачи.
	Public Function WriteMessage() As Integer
		On Error GoTo errHandler
		Dim msg As MessageHeader
		Dim CRC As New clsCRC32
		Dim lFrom, lSubj, lTo As String
		Dim txt, tmp, intl As String
		Dim ff As Short
		Dim zzf, zzt As Integer
		Dim RegEx As New VBScript_RegExp_55.RegExp ' регэкспы
		Dim colMatches As VBScript_RegExp_55.MatchCollection ' коллекция этих образцов
		
		'дополнительные проверки данных
		If Len(msgToAddr) = 0 Or Len(msgFromAddr) = 0 Then
			MsgBox("Адрес получателя или отправителя не должены быть пустыми!", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
			WriteMessage = -1
			Exit Function
		End If
		
		RegEx.IgnoreCase = True ' игнорируем регистр символов
		RegEx.[Global] = True
		
		tmp = Space(Len(msgSubj))
		CharToOem(msgSubj, tmp)
		lSubj = tmp & Chr(0)
		
		tmp = Space(Len(msgFrom))
		CharToOem(msgFrom, tmp)
		lFrom = tmp & Chr(0)
		
		tmp = Space(Len(msgTo))
		CharToOem(msgTo, tmp)
		lTo = tmp & Chr(0)
		
		tmp = Space(Len(msgText))
		CharToOem(msgText, tmp)
		txt = tmp & Chr(0)
		
		msg.Attribute = msgFlags
		msg.Date_arrived = 0
		msg.Date_written = GetTime80
		msg.DateTime = CStr(VB.Day(Now)) & " " & Months(Month(Now)) & " " & Right(CStr(Year(Now)), 2) & "  " & CStr(TimeOfDay)
		
		RegEx.Pattern = "(\d+):(\d+)/(\d+)\.{0,1}(\d*)" 'шаблон для выборки по полям 4D адреса из 5D
		colMatches = RegEx.Execute(msgToAddr) 'получаем результат для адреса получателя
		
		If colMatches.Count <> 1 Then
			MsgBox("Адрес получателя должен соответствовать формату!", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
			WriteMessage = -1
			Exit Function
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		msg.DestNet = colMatches.item(0).SubMatches(1)
		'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		msg.DestNode = colMatches.item(0).SubMatches(2)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		intl = colMatches.item(0).SubMatches(0) & ":" & msg.DestNet & "/" & msg.DestNode
		'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		zzt = colMatches.item(0).SubMatches(0)
		
		RegEx.Pattern = "(\d+):(\d+)/(\d+)\.{0,1}(\d*)" 'шаблон для выборки по полям 4D адреса из 5D
		colMatches = RegEx.Execute(msgFromAddr) 'получаем результат для адреса отправителя
		
		If colMatches.Count <> 1 Then
			MsgBox("Адрес отправителя должен соответствовать формату!", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
			WriteMessage = -1
			Exit Function
		End If
		
		msg.FromUserName = lFrom
		'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		msg.OrigNet = colMatches.item(0).SubMatches(1)
		'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		msg.OrigNode = colMatches.item(0).SubMatches(2)
		'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		intl = intl & " " & colMatches.item(0).SubMatches(0) & ":" & msg.OrigNet & "/" & msg.OrigNode
		'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		zzf = colMatches.item(0).SubMatches(0)
		
		msg.ReplyNext = 0
		msg.ReplyTo = 0
		msg.Subject = lSubj
		msg.TimedRead = 0
		msg.ToUserName = lTo
		
		'в txt еще надо покласть кладжи.
		txt = Chr(1) & "CHRS: CP866 2" & vbCr & txt
		txt = Chr(1) & "PID: " & System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & vbCr & txt
		txt = Chr(1) & "MSGID: " & msgFromAddr & " " & LCase(Hex(CRC.GetStringCRC32(msgFromAddr & msgDateWritten))) & vbCr & txt
		txt = Chr(1) & "REPLY: " & msgToAddr & " " & LCase(Hex(CRC.GetStringCRC32(msgToAddr & msgDateWritten))) & vbCr & txt
		
		'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If colMatches.item(0).SubMatches(3) <> "0" And Len(colMatches.item(0).SubMatches(3)) <> 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			txt = Chr(1) & "FMPT " & colMatches.item(0).SubMatches(3) & vbCr & txt
		End If
		
		RegEx.Pattern = "(\d+)/(\d+)\.{0,1}(\d*)" 'шаблон для выборки 4D адреса из 5D
		colMatches = RegEx.Execute(msgToAddr) 'получаем результат
		
		'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If colMatches.item(0).SubMatches(2) <> "0" And Len(colMatches.item(0).SubMatches(2)) <> 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			txt = Chr(1) & "TOPT " & colMatches.item(0).SubMatches(2) & vbCr & txt
		End If
		
		txt = Chr(1) & "INTL " & intl & vbCr & txt & vbCr
		
		ff = FreeFile
		
		'Open strDBname & "\" & Mid$(Messages(UBound(Messages)).FileName, 1, InStr(1, Messages(UBound(Messages)).FileName, ".") - 1) + 1 & ".msg" For Binary As #ff
		tmp = GetNextFileName() 'имя файла для записи
		FileOpen(ff, strDBname & "\" & tmp, OpenMode.Binary)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, msg) 'заголовок
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, txt) 'текст с кладжами
		FileClose(ff)
		
		numMessages = numMessages + 1
		'UPGRADE_WARNING: Array Messages may need to have individual elements initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1042"'
		ReDim Preserve Messages(numMessages)
		
		With Messages(numMessages)
			.FileName = tmp
			'UPGRADE_WARNING: Couldn't resolve default property of object Messages().Header. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			.Header = msg
			.Date_Renamed = Now
			.zone(0) = zzf
			.zone(1) = zzt
		End With
		
		'UPGRADE_NOTE: Object RegEx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		RegEx = Nothing
		'UPGRADE_NOTE: Object colMatches may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		colMatches = Nothing
		'UPGRADE_NOTE: Object CRC may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		CRC = Nothing
		
		Exit Function
		
errHandler: 
		
		Select Case Err.Number
			
			Case 76
				MsgBox("Ошибка!" & vbCrLf & "Путь к Netmail области не найден!", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				WriteMessage = -1
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "msgBase::WriteMessage")
				WriteMessage = -1
		End Select
		
	End Function
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Private Sub Class_Initialize_Renamed()
		Months(1) = "Jan"
		Months(2) = "Feb"
		Months(3) = "Mar"
		Months(4) = "Apr"
		Months(5) = "May"
		Months(6) = "Jun"
		Months(7) = "Jul"
		Months(8) = "Aug"
		Months(9) = "Sep"
		Months(10) = "Oct"
		Months(11) = "Nov"
		Months(12) = "Dec"
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
	
	'UPGRADE_NOTE: Class_Terminate was upgraded to Class_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Private Sub Class_Terminate_Renamed()
		
		System.Windows.Forms.Application.DoEvents()
		Erase Messages
		
		System.Windows.Forms.Application.DoEvents()
	End Sub
	Protected Overrides Sub Finalize()
		Class_Terminate_Renamed()
		MyBase.Finalize()
	End Sub
	
	'функция конструирует шаблон.
	Private Function PtrnKonv(ByRef Ptrn As String) As String
		On Error GoTo errHandler
		Dim RegEx As New VBScript_RegExp_55.RegExp
		Dim str1, onstr As String
		
		str1 = Ptrn
		
		RegEx.IgnoreCase = True
		RegEx.[Global] = True
		
		RegEx.Pattern = "\*"
		onstr = "[a-z0-9_]+"
		onstr = "\w+"
		str1 = RegEx.Replace(str1, onstr)
		
		RegEx.Pattern = "\."
		onstr = "\."
		str1 = RegEx.Replace(str1, onstr)
		
		PtrnKonv = "^" & str1 & "$"
		
		'UPGRADE_NOTE: Object RegEx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		RegEx = Nothing
		Exit Function
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "msgBase::PtrnKonv")
		End Select
		
	End Function
	
	Private Sub SortByDate()
		On Error GoTo errHandler
		'UPGRADE_WARNING: Arrays in structure TempVal may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1063"'
		Dim TempVal As MsgColl
		Dim GapSize, i, CurPos As Integer
		Dim LastRow, FirstRow, NumRows As Integer
		
		If numMessages <= 0 Then
			Exit Sub
		End If
		
		FirstRow = LBound(Messages) + 1
		LastRow = UBound(Messages)
		NumRows = LastRow - FirstRow + 2
		
		Do 
			GapSize = GapSize * 3 + 1
		Loop Until GapSize > NumRows
		
		Do 
			GapSize = GapSize \ 3
			
			For i = (GapSize + FirstRow) To LastRow
				CurPos = i
				'UPGRADE_WARNING: Couldn't resolve default property of object TempVal. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				TempVal = Messages(i)
				
				Do While Messages(CurPos - GapSize).Date_Renamed > TempVal.Date_Renamed
					'UPGRADE_WARNING: Couldn't resolve default property of object Messages(CurPos). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					Messages(CurPos) = Messages(CurPos - GapSize)
					CurPos = CurPos - GapSize
					
					If (CurPos - GapSize) < FirstRow Then
						Exit Do
					End If
					
				Loop 
				
				'UPGRADE_WARNING: Couldn't resolve default property of object Messages(CurPos). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				Messages(CurPos) = TempVal
			Next i
			
		Loop Until GapSize = 1
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "msgBase::SortByDate")
		End Select
		
	End Sub
	
	'~~~.GetLastReadMsgNum Получает LastRead информацию из файла
	Public Function GetLastReadMsgNum() As Integer
		On Error GoTo errHandler
		Dim lr As Short
		Dim ff As Integer
		Dim i As Integer
		Dim tlr As String
		
		If numMessages <= 0 Then
			Exit Function
		End If
		
		ff = FreeFile
		FileOpen(ff, strDBname & "\lastread", OpenMode.Binary)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, lr)
		FileClose(ff)
		
		'в lr будет имя файла с мессагом
		tlr = CStr(lr) & ".msg"
		
		For i = 1 To UBound(Messages)
			
			If Messages(i).FileName = tlr Then
				GetLastReadMsgNum = i
				Exit Function
			End If
			
		Next i
		
		GetLastReadMsgNum = 1
		
		Exit Function
		
errHandler: 
		
		Select Case Err.Number
			
			Case 9
				
				'типа у нас фиктивный нетмыл
			Case 76
				
				'MsgBox "Ошибка!" & vbCrLf & "Путь к Netmail области не найден!", vbCritical + vbSystemModal, App.Title
				'типа у нас фиктивный нетмыл
			Case Else
				ErrorMessage(Err.Number, Err.Description, "msgBase::GetLastReadMsgNum")
		End Select
		
	End Function
	
	'~~~.GetMessageKlugeByNum - Возвращает кладжи письма разделенные CrLf
	Public Function GetMessageKlugeByNum(ByRef msgNumber As Integer) As String
		GetMessageKlugeByNum = vbNullString
	End Function
	
	'шеснадцатиричный дамп байтового массива.
	Private Function DumpByteArray(ByRef arr() As Byte, Optional ByRef lStartPoint As Integer = 0) As String
		On Error GoTo errHandler
		Dim sOutput, str64bit As String
		Dim i, j As Integer
		
		For i = 0 To UBound(arr) - 8 Step 16
			str64bit = vbNullString
			sOutput = sOutput & vbCrLf & Right("000" & Hex(lStartPoint + i), 16) & vbTab
			
			For j = i To i + 15
				
				If j <= UBound(arr) Then
					sOutput = sOutput & Right("0" & Hex(arr(j)), 2) & " "
					
					If arr(j) < 32 Then
						str64bit = str64bit & "."
					Else
						str64bit = str64bit & Chr(arr(j))
					End If
					
				Else
					sOutput = sOutput & Right("0" & Hex(0), 2) & " "
					str64bit = str64bit & "."
				End If
				
			Next j
			
			System.Windows.Forms.Application.DoEvents()
			sOutput = sOutput & vbTab & str64bit
		Next i
		
		DumpByteArray = sOutput
		Exit Function
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "msgBase::DumpByteArray")
		End Select
		
	End Function
	
	Private Function GetNextFileName() As String
		On Error GoTo errHandler
		Dim fs As New Scripting.FileSystemObject
		Dim LFiles As Scripting.Files
		Dim sfld As Scripting.File
		Dim tnm As String
		Dim maxnam, tm As Integer
		
		LFiles = fs.GetFolder(strDBname).Files
		
		For	Each sfld In LFiles
			tnm = sfld.Name
			
			If InStr(1, tnm, ".msg", CompareMethod.Text) <> 0 Then
				tm = CInt(LCase(Left(tnm, Len(tnm) - 4)))
				
				If maxnam < tm Then
					maxnam = tm
				End If
			End If
			
		Next sfld
		
		'UPGRADE_NOTE: Object LFiles may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		LFiles = Nothing
		
		GetNextFileName = CStr(maxnam + 1) & ".msg"
		
		Exit Function
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "msgBase::GetNextFileName")
		End Select
		
	End Function
	
	Private Sub SaveErrorDump(ByRef Message As String)
		On Error Resume Next
		Dim ff As Integer
		
		ff = FreeFile
		FileOpen(ff, VB6.GetPath & "\msgBaseDump_" & CStr(VB.Timer()) & ".txt", OpenMode.Binary)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, Message)
		FileClose(ff)
		
	End Sub
End Class