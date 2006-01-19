Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class sqBase
	
	'(************************************************************************** _
	'Description: _
	'Squish has four files: _
	'*.SQL   - the lastread pointers are stored for the user. The lastus00.dat _
	'file has the user's record number. Seek to it and read a word _
	'to get lastread value for the user for the message base. _
	'*.SQI   - is a index of LIVE MESSAGES in the Squish *.SQD file. It _
	'basically stores the 'unique' message id for each message, _
	'the offset of the SQUISH messahe header (sqhdr) and the _
	'HASH of the TOWHOM user's name. _
	'*.SQD   - has all the mail. The basic layout is: _
	'BASE_RECORD _
	'then for each message _
	'SQUISH MESSAGE HEADER _
	'CONTROL INFORMATION   Where all ^A stuff is stored _
	'TEXT MESSAGE          may not always be null terminated _
	'The base record will tell you where the first squish msg header _
	'is at, and each msg header will point to the next or prev one. _
	'In addition, the base record also will point to the first FREE _
	'(one that was marked deleted) Squish Message Header and so on. _
	'So from the base record, you can get a "Doublely linked list" _
	'of both the live messages and free messages. _
	'*.SQB  - something to do with dupe checking and I think it's for the _
	'squish mail processor. Not discussed or used in the this API. _
	'*****************************************************************************)
	Private Const SQHDRID As Integer = &HAFAE4453
	Private Const ID_HIDX As Short = &H9FEEs
	Private Const LINKNEXT As Short = 0
	Private Const LINKPREV As Short = 1
	Private Const NULLFRAME As Short = 0
	Private Const SQMSG_FROM_SIZE As Short = 36
	Private Const SQMSG_TO_SIZE As Short = 36
	Private Const SQMSG_SUBJ_SIZE As Short = 72
	Private Const MAX_REPLY As Short = 9 '(* Max number of stored replies to one msg  *)
	'UMSGID = long
	
	'Address
	Private Structure Address
		Dim zone As Short
		Dim net As Short
		Dim node As Short
		Dim Point As Short
	End Structure
	
	'/* Frame types for sqhdr.frame_type */
	Private Enum sqFrameType
		FRAME_NORMAL = &H0s '/* Normal text frame */
		FRAME_free = &H1s '/* Part of the free chain */
		FRAME_LZSS = &H2s '/* Not implemented */
		FRAME_UPDATE = &H3s '/* Frame is being updated by another task */
	End Enum
	
	'/* Header block at offset 0 of <area>.SQD */
	Private Structure sqBase
		'UPGRADE_NOTE: len was upgraded to len_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim len_Renamed As Short '/* LENGTH OF THIS STRUCTURE! */           /*   0 */
		Dim rsvd1 As Short '/* reserved */                            /*   2 */
		Dim num_msg As Integer '/* Number of messages in area */          /*   4 */
		Dim high_msg As Integer '/* Highest msg in area. Same as num_msg*/ /*   8 */
		Dim skip_msg As Integer '/* Skip killing first x msgs in area */   /*  12 */
		Dim high_water As Integer '/* Msg# (not umsgid) of HWM */            /*  16 */
		Dim uid As Integer '/* Number of the next UMSGID to use */    /*  20 */
		<VBFixedString(79),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=79)> Public base As String '/* Base name of SquishFile */             /*  24 */
		Dim begin_frame As Integer '/* Offset of first frame in file */       /* 104 */
		Dim last_frame As Integer '/* Offset to last frame in file */        /* 108 */
		Dim free_frame As Integer '/* Offset of first FREE frame in file */  /* 112 */
		Dim last_free_frame As Integer '/* Offset of last free frame in file */   /* 116 */
		Dim end_frame As Integer '/* Pointer to end of file */              /* 120 */
		Dim max_msg As Integer '/* Max # of msgs to keep in area */       /* 124 */
		Dim keep_days As Short '/* Max age of msgs in area (SQPack) */    /* 128 */
		Dim sz_sqhdr As Short '/* sizeof(SQHDR) */                       /* 130 */
		<VBFixedArray(124)> Dim rsvd2() As Byte '/* Reserved by Squish for future use*/    /* 132 */
		'/* total: 256 */
		
		'UPGRADE_TODO: "Initialize" must be called to initialize instances of this structure. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1026"'
		Public Sub Initialize()
			ReDim rsvd2(124)
		End Sub
	End Structure
	
	'* Squish frame header.  This comes before each and every message in a _
	'* Squish message base.
	Private Structure sqfhdr
		Dim id As Integer '/* sqhdr.id must always equal SQHDRID */
		Dim next_frame As Integer '/* Next frame in the linked list */
		Dim prev_frame As Integer '/* Prior frame in the linked list */
		Dim frame_length As Integer '/* Length of this frame */
		Dim msg_length As Integer '/* Length used in this frame by XMSG, ctrl and text */
		Dim clen As Integer '/* Length used in this frame by ctrl info only */
		Dim frame_type As Short '/* Type of frame -- see above FRAME_XXXX */
		Dim rsvd As Short '/* Reserved for future use */
	End Structure
	
	'But right after each frame header, follows the squish message header, _
	'then the control info, then the text.
	Private Structure sqMhdr
		Dim Attr As Integer ' 0
		<VBFixedString(SQMSG_FROM_SIZE),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=SQMSG_FROM_SIZE)> Public FromWho As String ' 4
		<VBFixedString(SQMSG_TO_SIZE),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=SQMSG_TO_SIZE)> Public ToWho As String ' 40
		<VBFixedString(SQMSG_SUBJ_SIZE),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=SQMSG_SUBJ_SIZE)> Public Subj As String ' 76
		Dim OrigAddr As Address ' 148
		Dim DestAddr As Address ' 156 (* Origination and destination addresses *)
		Dim Date_written As Integer ' 164 (* When user wrote the msg (UTC) *)
		Dim Date_arrived As Integer ' 168 (* When msg arrived on-line (UTC) *)
		Dim utc_ofs As Short ' 172 (* Minutes offset from UTC of message writer *)
		Dim ReplyTo As Integer ' 174
		<VBFixedArray(MAX_REPLY)> Dim Replies() As Integer ' 178
		Dim uMsgId As Integer ' 214
		<VBFixedString(20),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=20)> Public azdate As String ' 238 (* ASCII date *)
		
		'UPGRADE_TODO: "Initialize" must be called to initialize instances of this structure. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1026"'
		Public Sub Initialize()
			ReDim Replies(MAX_REPLY)
		End Sub
	End Structure
	
	'Each SQD file has a SQI FILES.  The message number YOU see (the user) _
	'in MAX is really the counter starting from 1 of each record in SQI. _
	'But the TRUE UNIQUE Message ID is in umsgid. The ofs value will _
	'point to the frame header in SQD.  These files are small and you _
	'may read them into a array SqiPtrArrayType using the functions _
	'below.
	
	Private Structure sqidxtype
		Dim ofs As Integer '(* Offset of frame header *)
		Dim uMsgId As Integer '(* Unique message identifier *)
		Dim hash As Integer '(* 'To' name hash value *)
	End Structure
	'----end squish api
	
	'--------------------File And Memory Functions--------------------
	Private Declare Function CreateFile Lib "kernel32"  Alias "CreateFileA"(ByVal lpFileName As String, ByVal dwDesiredAccess As Integer, ByVal dwShareMode As Integer, ByVal lpSecurityAttributes As Integer, ByVal dwCreationDisposition As Integer, ByVal dwFlagsAndAttributes As Integer, ByVal hTemplateFile As Integer) As Integer
	
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Private Declare Function ReadFile Lib "kernel32" (ByVal hFile As Integer, ByRef lpBuffer As Any, ByVal nNumberOfBytesToRead As Integer, ByRef lpNumberOfBytesRead As Integer, ByVal lpOverlapped As Integer) As Integer
	
	Private Declare Function SetFilePointer Lib "kernel32" (ByVal hFile As Integer, ByVal lDistanceToMove As Integer, ByRef lpDistanceToMoveHigh As Integer, ByVal dwMoveMethod As Integer) As Integer
	
	Private Declare Function GetFileSize Lib "kernel32" (ByVal hFile As Integer, ByRef lpFileSizeHigh As Integer) As Integer
	
	Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Integer) As Integer
	
	Private Const GENERIC_ALL As Integer = &H10000000
	Private Const GENERIC_EXECUTE As Integer = &H20000000
	Private Const GENERIC_READ As Integer = &H80000000
	Private Const GENERIC_WRITE As Integer = &H40000000
	Private Const FILE_SHARE_READ As Short = &H1s
	Private Const FILE_SHARE_WRITE As Short = &H2s
	Private Const CREATE_ALWAYS As Short = 2
	Private Const CREATE_NEW As Short = 1
	Private Const OPEN_EXISTING As Short = 3
	Private Const FILE_BEGIN As Short = 0
	Private Const FILE_END As Short = 2
	Private Const FILE_CURRENT As Short = 1
	'--------------------------
	
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Private Declare Sub RtlMoveMemory Lib "kernel32.dll" (ByRef dst As Any, ByRef Src As Any, ByVal cb As Integer)
	Private Declare Function GetLastError Lib "kernel32" () As Integer
	
	'-----Прекорировки
	'прекодировка bytes to unicode
	Private Declare Function MultiByteToWideChar Lib "kernel32" (ByVal CodePage As Integer, ByVal dwFlags As Integer, ByRef lpMultiByteStr As Byte, ByVal cchMultiByte As Integer, ByVal lpWideCharStr As Integer, ByVal cchWideChar As Integer) As Integer
	
	'прекодировка string to unicode
	Private Declare Function MultiByteToWideCharS Lib "kernel32"  Alias "MultiByteToWideChar"(ByVal CodePage As Integer, ByVal dwFlags As Integer, ByVal lpMultiByteStr As String, ByVal cchMultiByte As Integer, ByVal lpWideCharStr As Integer, ByVal cchWideChar As Integer) As Integer
	
	Private Const CP_ACP As Short = 0
	Private Const CP_OEMCP As Short = 1
	'----------
	
	'коллекция сообщений из файла базы
	Private Structure msgCollection
		'UPGRADE_WARNING: Arrays in structure MsgHdr may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1063"'
		Dim MsgHdr As sqMhdr 'Заголовок сообщения
		Dim TextOffset As Integer 'Смещение в файле
		Dim TextLen As Integer 'Длинна сообщения
		
		'UPGRADE_TODO: "Initialize" must be called to initialize instances of this structure. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1026"'
		Public Sub Initialize()
			MsgHdr.Initialize()
		End Sub
	End Structure
	
	Private Messages() As msgCollection 'Загруженный файл базы
	
	'~~~~~~~~~~~~~~~~~~~~~переменные для свойств
	Private strDBname As String 'local copy
	Private strEchoName As String 'local copy
	Private numMessages As Integer 'local copy
	Private msgFrom As String 'local copy
	Private msgFromAddr As String 'local copy
	Private msgTo As String 'local copy
	Private msgToAddr As String 'local copy
	Private msgDateWritten As String 'local copy
	Private msgDateArrived As String 'local copy
	Private msgSubj As String 'local copy
	Private msgText As String 'local copy
	Private msgFlags As Integer 'local copy
	Private msgReplayTo As Integer 'local copy
	Private msgReplayNext As Integer 'local copy
	Private msgReplayNextS As String 'local copy
	'~~~~~~~~~~~~~~~~~~~~~
	
	'~~~.BaseType - возвращает тип базы
	Public ReadOnly Property BaseType() As String
		Get
			BaseType = "SQU"
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
			DateWritten = CInt(msgDateWritten)
		End Get
		Set(ByVal Value As Integer)
			msgDateWritten = CStr(Value)
		End Set
	End Property
	
	
	Public Property DateArrived() As Integer
		Get
			DateArrived = CInt(msgDateArrived)
		End Get
		Set(ByVal Value As Integer)
			msgDateArrived = CStr(Value)
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
			ReplayNextS = msgReplayNextS 'возвращает строку реплеев разделенную пробелами
		End Get
		Set(ByVal Value As String)
			msgReplayNextS = Value
		End Set
	End Property
	'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
	
	'~~~.DBName Устанавливает\получает имя базы для работы
	
	'~~~.DBName Устанавливает\получает имя базы для работы
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
	
	'~~~.MessageCount возвращает число мессаг в области(пока еще и тех которые не отпуржены)
	Public ReadOnly Property MessageCount() As Integer
		Get
			MessageCount = numMessages
		End Get
	End Property
	
	'~~~.MessageCountByEchoName возвращает число мессаг в области
	Public ReadOnly Property MessageCountByEcho(ByVal Echo As String) As Integer
		Get
			Dim ff, hDb As Integer
			
			hDb = CreateFile(Echo, GENERIC_READ, FILE_SHARE_READ, 0, OPEN_EXISTING, 0, 0)
			
			If hDb < 0 Then
				'err.Number = GetLastError() 'пока отключим
				ApiErrorLookup(GetLastError, "sqBase::MessageCountByEcho")
				Exit Property 'на пока покатит...
			End If
			
			'считываем
			If SetFilePointer(hDb, 4, 0, FILE_BEGIN) = 0 Then
				ApiErrorLookup(GetLastError, "sqBase::MessageCountByEcho")
				CloseHandle(hDb)
				MessageCountByEcho = 0
				Exit Property
			End If
			
			ReadFile(hDb, ff, 4, 0, 0)
			
			If ReadFile(hDb, ff, 4, 0, 0) = 0 Then
				ApiErrorLookup(GetLastError, "sqBase::MessageCountByEcho")
				CloseHandle(hDb)
				MessageCountByEcho = 0
				Exit Property
			End If
			
			CloseHandle(hDb)
			
			MessageCountByEcho = ff
			
		End Get
	End Property
	
	'~~~.GetMessageByNum - возвращает мессаг по его номеру
	Public Sub GetMessageByNum(ByRef NumberMessage As Integer)
		On Error GoTo errHandler
		Dim txt As String
		Dim ff As Integer
		Dim tmp As String
		
		If NumberMessage > numMessages Then
			Exit Sub
		End If
		
		If NumberMessage = 0 Then
			Exit Sub
		End If
		
		ff = FreeFile
		FileOpen(ff, strDBname, OpenMode.Binary)
		txt = Space(Messages(NumberMessage).TextLen)
		Seek(ff, Messages(NumberMessage).TextOffset + 1)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, txt)
		FileClose(ff)
		
		System.Windows.Forms.Application.DoEvents()
		
		tmp = Space(Len(txt))
		'перекодируем дос кодировку в виндовс
		'UPGRADE_ISSUE: StrPtr function is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1040"'
		MultiByteToWideCharS(CP_OEMCP, 0, txt, Len(txt), StrPtr(tmp), Len(txt))
		msgText = Replace(tmp, Chr(0), "")
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 76
				MsgBox("Ошибка!" & vbCrLf & "Путь к Squish области не найден!", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - sqBase::GetMessageDumpByNum")
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "sqBase::GetMessageByNum")
		End Select
		
	End Sub
	
	'~~~.GetMessageSourceByNum возвращает дамп мессага по номеру
	Public Function GetMessageDumpByNum(ByRef NumberMessage As Integer) As String
		'
	End Function
	
	'~~~.GetHeadersByNum - возвращает поля мессага по его номеру
	Public Sub GetHeadesByNum(ByRef NumberMessage As Integer)
		On Error Resume Next
		Dim i As Integer
		
		'своеобразная обработка ошибок, когда нам не нужен этот метод мы вызаваем его с 0 параметром
		If NumberMessage > numMessages Then
			Exit Sub
		End If
		
		If NumberMessage = 0 Then
			Exit Sub
		End If
		
		msgFlags = Messages(NumberMessage).MsgHdr.Attr
		msgFrom = Replace(Messages(NumberMessage).MsgHdr.FromWho, Chr(0), "")
		msgFromAddr = Messages(NumberMessage).MsgHdr.OrigAddr.zone & ":" & Messages(NumberMessage).MsgHdr.OrigAddr.net & "/" & Messages(NumberMessage).MsgHdr.OrigAddr.node & "." & Messages(NumberMessage).MsgHdr.OrigAddr.Point
		msgTo = Replace(Messages(NumberMessage).MsgHdr.ToWho, Chr(0), "")
		msgToAddr = Messages(NumberMessage).MsgHdr.DestAddr.zone & ":" & Messages(NumberMessage).MsgHdr.DestAddr.net & "/" & Messages(NumberMessage).MsgHdr.DestAddr.node & "." & Messages(NumberMessage).MsgHdr.DestAddr.Point
		msgDateWritten = CStr(Messages(NumberMessage).MsgHdr.Date_written)
		msgDateArrived = CStr(Messages(NumberMessage).MsgHdr.Date_arrived)
		msgSubj = Replace(Messages(NumberMessage).MsgHdr.Subj, Chr(0), "")
		msgReplayTo = Messages(NumberMessage).MsgHdr.ReplyTo
		msgReplayNext = Messages(NumberMessage).MsgHdr.Replies(0)
		
		msgReplayNextS = ""
		
		For i = 1 To MAX_REPLY
			msgReplayNextS = msgReplayNextS & " " & Messages(NumberMessage).MsgHdr.Replies(i)
		Next i
		
	End Sub
	
	'~~~.GetHeadersByNumForTree - возвращает поля мессага по его номеру Для построения дерева.
	Public Sub GetHeadesByNumForTree(ByRef NumberMessage As Integer)
		Dim repl, i, tmpN As Integer
		
		'своеобразная обработка ошибок, когда нам не нужен этот метод мы вызаваем его с 0 параметром
		If NumberMessage > numMessages Then
			Exit Sub
		End If
		
		If NumberMessage = 0 Then
			Exit Sub
		End If
		
		msgReplayNextS = vbNullString
		tmpN = Messages(1).MsgHdr.uMsgId
		
		msgFrom = Replace(Messages(NumberMessage).MsgHdr.FromWho, Chr(0), "")
		msgSubj = Replace(Messages(NumberMessage).MsgHdr.Subj, Chr(0), "")
		msgReplayTo = Messages(NumberMessage).MsgHdr.ReplyTo
		msgReplayNext = Messages(NumberMessage).MsgHdr.Replies(0)
		
		If msgReplayTo <> 0 Then
			msgReplayTo = msgReplayTo - tmpN
		End If
		
		For i = 0 To MAX_REPLY
			repl = Messages(NumberMessage).MsgHdr.Replies(i) - tmpN
			
			If repl >= 0 Then
				msgReplayNextS = CStr(repl) & " " & msgReplayNextS
			End If
			
		Next i
		
	End Sub
	
	'~~~.GetLastReadMsgNum Получает LastRead информацию из файла если msgnumber<>0 то пишем в файл
	Public Function GetLastReadMsgNum(Optional ByRef msgNumber As Integer = 0) As Integer
		
		'если номер сообщения не задан, то читаем ластрид
		If msgNumber = 0 Then
			'
		Else
			'иначе мы пишем в него. возвращаем 0 в случае успеха операции
			'в случаее ошибки возвращает ее номер со знаком -
		End If
		
	End Function
	
	'~~~.GetMessageKlugeByNum - Возвращает кладжи письма разделенные CrLf
	Public Function GetMessageKlugeByNum(ByRef msgNumber As Integer) As String
		GetMessageKlugeByNum = vbNullString
	End Function
	
	'~~~.OpenDB - открывает базу сообщений и загружает их в память
	Public Sub OpenDB()
		On Error GoTo errHandler
		Dim lngLong, hDisk, fSize As Integer
		Dim bytFile() As Byte
		Dim offsetHeader As Integer
		Dim num, am As Integer
		Dim nn As String
		Dim nbr, rr As Integer
		
		Dim hdr As sqBase
		Dim fhdr As sqfhdr
		
		hDisk = CreateFile(strDBname, GENERIC_READ, FILE_SHARE_READ, 0, OPEN_EXISTING, 0, 0)
		
		If hDisk < 0 Then
			ApiErrorLookup(GetLastError, "Squish::OpenDB")
			Exit Sub 'на пока покатит...
		End If
		
		fSize = GetFileSize(hDisk, lngLong) 'в bytes
		
		ReDim bytFile(fSize)
		
		'считываем файл в массив байтов
		rr = ReadFile(hDisk, bytFile(0), fSize, nbr, 0)
		CloseHandle(hDisk)
		
		'понеслась обработка
		
		'читаем заголовок. Незабываем, что все начинается с 0
		'UPGRADE_WARNING: Couldn't resolve default property of object hdr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RtlMoveMemory(hdr, bytFile(0), Len(hdr))
		
		am = hdr.num_msg
		'UPGRADE_WARNING: Array Messages may need to have individual elements initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1042"'
		ReDim Messages(am)
		
		num = 1
		offsetHeader = hdr.begin_frame 'стартовый фрейм
		
		While num <= am
			
			'читаем фрейм с мессагом
			If offsetHeader < fSize Then
				
				'UPGRADE_WARNING: Couldn't resolve default property of object fhdr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				RtlMoveMemory(fhdr, bytFile(offsetHeader), Len(fhdr))
				offsetHeader = offsetHeader + Len(fhdr)
				
				'UPGRADE_WARNING: Untranslated statement in OpenDB. Please check source code.
				
			End If
			
			offsetHeader = fhdr.next_frame 'слудующий фрейм
			
			num = num + 1
		End While
		numMessages = num - 1
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 75 'access denide
				
				'Добавим метод err чтобы отслеживать ошибки
			Case Else
				ErrorMessage(Err.Number, Err.Description, "sqBase::OpenDB")
		End Select
		
	End Sub
	
	'~~~.WriteMessage - Пишет сообщение в выбранную базу. Возвращает -1 в случае неудачи.
	Public Function WriteMessage() As Integer
		WriteMessage = -1
	End Function
	
	'~~~.DeleteMessageByNum
	Public Sub DeleteMessageByNum(ByRef NumberMessage As Integer)
		
		If NumberMessage > numMessages Then
			Exit Sub
		End If
		
		If NumberMessage = 0 Then
			Exit Sub
		End If
		
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
	
	'шеснадцатиричный дамп байтового массива.
	Private Function DumpByteArray(ByRef arr() As Byte, Optional ByRef lStartPoint As Integer = 0) As String
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
		
	End Function
	
	Private Sub SaveErrorDump(ByRef Message As String)
		On Error Resume Next
		Dim ff As Integer
		
		ff = FreeFile
		FileOpen(ff, VB6.GetPath & "\squBaseDump_" & CStr(VB.Timer()) & ".txt", OpenMode.Binary)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, Message)
		FileClose(ff)
		
	End Sub
End Class