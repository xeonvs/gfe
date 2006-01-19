Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class jamBase
	'Класс для работы с JAM базой 2003 (c) Max `Xeon` Irgiznov
	
	'--------------------File And Memory Functions--------------------
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Private Declare Sub RtlMoveMemory Lib "kernel32.dll" (ByRef dst As Any, ByRef Src As Any, ByVal cb As Integer)
	'ByRef lpSecurityAttributes As SECURITY_ATTRIBUTES,
	Private Declare Function CreateFile Lib "kernel32"  Alias "CreateFileA"(ByVal lpFileName As String, ByVal dwDesiredAccess As Integer, ByVal dwShareMode As Integer, ByVal lpSecurityAttributes As Integer, ByVal dwCreationDisposition As Integer, ByVal dwFlagsAndAttributes As Integer, ByVal hTemplateFile As Integer) As Integer
	
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Private Declare Function ReadFile Lib "kernel32" (ByVal hFile As Integer, ByRef lpBuffer As Any, ByVal nNumberOfBytesToRead As Integer, ByRef lpNumberOfBytesRead As Integer, ByVal lpOverlapped As Integer) As Integer
	
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Private Declare Function WriteFile Lib "kernel32" (ByVal hFile As Integer, ByRef lpBuffer As Any, ByVal nNumberOfBytesToWrite As Integer, ByRef lpNumberOfBytesWritten As Integer, ByVal lpOverlapped As Integer) As Integer
	
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
	
	Private Declare Function GetLastError Lib "kernel32" () As Integer
	
	'-----Прекорировки
	'прекодировка bytes to unicode
	Private Declare Function MultiByteToWideChar Lib "kernel32" (ByVal CodePage As Integer, ByVal dwFlags As Integer, ByRef lpMultiByteStr As Byte, ByVal cchMultiByte As Integer, ByVal lpWideCharStr As Integer, ByVal cchWideChar As Integer) As Integer
	
	'прекодировка string to unicode
	Private Declare Function MultiByteToWideCharS Lib "kernel32"  Alias "MultiByteToWideChar"(ByVal CodePage As Integer, ByVal dwFlags As Integer, ByVal lpMultiByteStr As String, ByVal cchMultiByte As Integer, ByVal lpWideCharStr As Integer, ByVal cchWideChar As Integer) As Integer
	
	Private Const CP_ACP As Short = 0
	Private Const CP_OEMCP As Short = 1
	'----------
	
	'----Конец АПИ функций
	
	'заголовок файла *.jhr
	Private Structure JamHdrType 'offsset
		<VBFixedString(4),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=4)> Public Signature As String '0
		Dim Created As Integer '4
		Dim ModCounter As Integer '8
		Dim ActiveMsgs As Integer '12
		Dim PwdCrc As Integer '16
		Dim BaseMsgNum As Integer '20
		Dim HighWaterMark As Integer '24
		<VBFixedString(996),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=996)> Public RSRVD As String '28
	End Structure
	
	'заголовок мессаг файла *.jhr
	Private Structure JamMsgHdrType
		<VBFixedString(4),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=4)> Public Signature As String
		Dim Rev As Short
		Dim Resvd As Short
		Dim SubfieldLen As Integer
		Dim TimesRead As Integer
		Dim MSGIDcrc As Integer
		Dim REPLYcrc As Integer
		Dim ReplyTo As Integer
		Dim ReplyFirst As Integer
		Dim ReplyNext As Integer
		Dim DateWritten As Integer '40 byte
		Dim DateRcvd As Integer
		Dim DateArrived As Integer
		Dim MsgNum As Integer
		Dim Attr1 As Integer
		Dim Attr2 As Integer
		Dim TextOfs As Integer
		Dim TextLen As Integer
		Dim PwdCrc As Integer
		Dim Cost As Integer
	End Structure
	
	'подполя сообщения в заголовке
	Private Structure JamSubFieldType
		Dim LoId As Short
		Dim HiId As Short
		Dim DataLen As Integer
		'Data As String * 82
	End Structure
	
	'Записи в файле *.JDX
	Private Structure JamIdxType
		Dim MsgToCrc As Integer
		Dim HdrLoc As Integer 'The record number (+BaseMsgNum)
	End Structure
	
	'Записи в файле *.JLR
	Private Structure Lastread
		Dim UserCrc As Integer 'CRC-32 of user name (lowercase)
		Dim UserId As Integer 'Unique UserID
		Dim LastReadMsg As Integer 'Last read message number
		Dim HighReadMsg As Integer 'Highest read message number
	End Structure
	
	'субполя в коллекции сообщений
	Private Structure SubField
		Dim LoId As Integer
		Dim Data As String
	End Structure
	
	Private Const MAX_SUBFIELDLEN_NORMAL As Integer = 768 'Максимально возможная длинна суб-поля
	
	Public Enum MSG_ATTRIBUTE
		Msg_Local = &H1s ' Msg created locally
		MSG_INTRANSIT = &H2s ' Msg is in-transit
		Msg_Private = &H4s ' Private
		Msg_Read = &H8s ' Read by addressee
		Msg_Sent = &H10s ' Sent to remote
		MSG_KILLSENT = &H20s ' Kill when sent
		MSG_ARCHIVESENT = &H40s ' Archive when sent
		Msg_Hold = &H80s ' Hold for pick-up
		Msg_Crash = &H100s ' Crash
		MSG_IMMEDIATE = &H200s ' Send Msg now, ignore restrictions
		MSG_DIRECT = &H400s ' Send directly to destination
		MSG_GATE = &H800s ' Send via gateway
		MSG_FILEREQUEST = &H1000s ' File request
		MSG_FILEATTACH = &H2000s ' File(s) attached to Msg
		MSG_TRUNCFILE = &H4000s ' Truncate file(s) when sent
		MSG_KILLFILE = &H8000s ' Delete file(s) when sent
		MSG_RECEIPTREQ = &H10000 ' Return receipt requested
		MSG_CONFIRMREQ = &H20000 ' Confirmation receipt requested
		Msg_Orphan = &H40000 ' Unknown destination
		MSG_ENCRYPT = &H80000 ' Msg text is encrypted
		MSG_COMPRESS = &H100000 ' Msg text is compressed
		MSG_ESCAPED = &H200000 ' Msg text is seven bit ASCII
		MSG_FPU = &H400000 ' Force pickup
		MSG_TYPELOCAL = &H800000 ' Msg is for local use only
		MSG_TYPEECHO = &H1000000 ' Msg is for conference distribution
		MSG_TYPENET = &H2000000 ' Msg is direct network mail
		MSG_NODISP = &H20000000 ' Msg may not be displayed to user
		MSG_LOCKED = &H40000000 ' Msg is locked, no editing possible
		MSG_DELETED = &H80000000 ' Msg is deleted
	End Enum
	
	'коллекция сообщений из заголовочного файла
	Private Structure msgCollection
		Dim MsgHdr As JamMsgHdrType 'заголовок сообщения
		Dim MessageOffset As Integer 'Смещение в файле заголовков
		Dim SubField() As SubField 'массив подполей
		Dim SubFieldCount As Integer 'число подполей
	End Structure
	
	Private Messages() As msgCollection 'Загруженный заголовочный файл
	
	'~~~~~~~~~~~~~~~~~~~~~переменные для свойств
	Private strDBname As String 'local copy
	Private strEchoName As String 'local copy
	Private numMessages As Integer 'local copy
	Private msgFrom As String 'local copy
	Private msgFromAddr As String 'local copy
	Private msgTo As String 'local copy
	Private msgToAddr As String 'local copy
	Private msgDateWritten As Integer 'local copy
	Private msgDateArrived As Integer 'local copy
	Private msgSubj As String 'local copy
	Private msgText As String 'local copy
	Private msgFlags As Integer 'local copy
	Private msgReplayTo As Integer 'local copy
	Private msgReplayFirst As Integer 'local copy
	Private msgReplayNext As Integer 'local copy
	'~~~~~~~~~~~~~~~~~~~~~
	
	'~~~.BaseType - возвращает тип базы
	Public ReadOnly Property BaseType() As String
		Get
			BaseType = "JAM"
		End Get
	End Property
	
	'проперти для получения мессага
	'возвращает раскодированную структуру одного сообщения
	'~~~~~~~~~~~~~~~~~~~~~
	
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
			
			If InStr(1, msgSubj, "?koi8-r", CompareMethod.Text) <> 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object DeCode(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				Subj = DeCode(msgSubj)
			Else
				Subj = msgSubj
			End If
			
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
	
	
	Public Property ReplayFirst() As Integer
		Get
			ReplayFirst = msgReplayFirst
		End Get
		Set(ByVal Value As Integer)
			msgReplayFirst = Value
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
	
	
	Public Property ReplayNextS() As String
		Get
			ReplayNextS = ""
		End Get
		Set(ByVal Value As String)
			'null action
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
	
	'~~~.MessageCount возвращает число мессаг в области
	
	'~~~.MessageCount возвращает число мессаг в области
	Public Property MessageCount() As Integer
		Get
			MessageCount = numMessages
		End Get
		Set(ByVal Value As Integer)
			numMessages = Value
		End Set
	End Property
	
	'~~~.MessageCountByEchoName возвращает число мессаг в области
	Public ReadOnly Property MessageCountByEcho(ByVal Echo As String) As Integer
		Get
			Dim ff, hDb As Integer
			
			hDb = CreateFile(Echo, GENERIC_READ, FILE_SHARE_READ, 0, OPEN_EXISTING, 0, 0)
			
			If hDb < 0 Then
				'база не существует, создаем ее
				'CreateDefaultBase Echo
				MessageCountByEcho = 0
				Exit Property
			End If
			
			'считываем
			If SetFilePointer(hDb, 12, 0, FILE_BEGIN) = 0 Then
				ApiErrorLookup(GetLastError, "jamBase::MessageCountByEcho")
				CloseHandle(hDb)
				MessageCountByEcho = 0
				Exit Property
			End If
			
			If ReadFile(hDb, ff, 4, 0, 0) = 0 Then
				ApiErrorLookup(GetLastError, "jamBase::MessageCountByEcho")
				CloseHandle(hDb)
				MessageCountByEcho = 0
				Exit Property
			End If
			
			If ff <= 0 Then
				
				'проверяем на корректность базу
				If GetFileSize(hDb, 0) < 1024 Then
					'база битая делаем ее дефолтной.
					CloseHandle(hDb)
					CreateDefaultBase(Echo)
					MessageCountByEcho = 0
					Exit Property
				Else
					ff = 0
				End If
			End If
			
			CloseHandle(hDb)
			
			MessageCountByEcho = ff
			
		End Get
	End Property
	
	'~~~.GetMessageByNum - возвращает мессаг по его номеру
	Public Sub GetMessageByNum(ByRef NumberMessage As Integer, Optional ByRef ReCode As Boolean = True)
		Dim txt() As Byte
		Dim tmp As String
		Dim ff, hDb As Integer
		
		'своеобразная обработка ошибок, когда нам не нужен этот метод мы вызаваем его с 0 параметром
		If NumberMessage = 0 Then
			Exit Sub
		End If
		
		hDb = CreateFile(Mid(strDBname, 1, InStr(1, strDBname, ".jhr")) & "jdt", GENERIC_READ, FILE_SHARE_READ, 0, OPEN_EXISTING, 0, 0)
		
		If hDb < 0 Then
			ApiErrorLookup(GetLastError, "jamBase::GetMessageByNum")
			Exit Sub
		End If
		
		'считываем
		SetFilePointer(hDb, Messages(NumberMessage).MsgHdr.TextOfs, 0, FILE_BEGIN)
		
		ff = Messages(NumberMessage).MsgHdr.TextLen
		ReDim txt(ff)
		
		If ReadFile(hDb, txt(0), ff, 0, 0) = 0 Then
			ApiErrorLookup(GetLastError, "jamBase::GetMessageByNum")
			CloseHandle(hDb)
			Exit Sub
		End If
		
		CloseHandle(hDb)
		
		tmp = Space(ff)
		
		If ReCode Then
			'перекодируем дос кодировку в виндовс
			'UPGRADE_ISSUE: StrPtr function is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1040"'
			MultiByteToWideChar(CP_OEMCP, 0, txt(0), ff, StrPtr(tmp), ff)
		Else
			'UPGRADE_ISSUE: StrPtr function is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1040"'
			MultiByteToWideChar(CP_ACP, 0, txt(0), ff, StrPtr(tmp), ff)
		End If
		
		msgText = tmp
		
	End Sub
	
	'~~~.GetMessageSourceByNum возвращает дамп мессага по номеру
	Public Function GetMessageDumpByNum(ByRef NumberMessage As Integer) As String
		On Error GoTo errHandler
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim tmp, str_Renamed, txt As String
		Dim ff, i As Integer
		Dim hdr As JamHdrType
		Dim msg As JamMsgHdrType
		Dim idx As JamIdxType
		Dim lr As Lastread
		Dim rArr() As Byte
		
		'своеобразная обработка ошибок, когда нам не нужен этот метод мы вызаваем его с 0 параметром
		If NumberMessage > numMessages Then
			Exit Function
		End If
		
		If NumberMessage = 0 Then
			Exit Function
		End If
		
		str_Renamed = "Hexdump of JAM message header, subfields and text" & vbCrLf
		str_Renamed = str_Renamed & "------------------------------------------------------------------------------" & vbCrLf & vbCrLf
		
		'дамп заголовка письма
		With Messages(NumberMessage).MsgHdr
			
			str_Renamed = str_Renamed & "Msgbase" & vbTab & vbTab & ": " & strDBname & vbCrLf
			str_Renamed = str_Renamed & "Signature" & vbTab & ": " & Left(.Signature, 3) & vbCrLf
			str_Renamed = str_Renamed & "Revision" & vbTab & vbTab & ": " & .Rev & vbCrLf
			str_Renamed = str_Renamed & "ReservedWord" & vbTab & ": " & .Resvd & vbCrLf
			str_Renamed = str_Renamed & "SubfieldLen" & vbTab & ": " & .SubfieldLen & vbCrLf
			str_Renamed = str_Renamed & "TimesRead" & vbTab & ": " & .TimesRead & vbCrLf
			str_Renamed = str_Renamed & "MSGIDcrc" & vbTab & ": " & Hex(.MSGIDcrc) & "h" & vbCrLf
			str_Renamed = str_Renamed & "REPLYcrc" & vbTab & ": " & Hex(.REPLYcrc) & "h" & vbCrLf
			str_Renamed = str_Renamed & "ReplyTo" & vbTab & vbTab & ": " & .ReplyTo & vbCrLf
			str_Renamed = str_Renamed & "Reply1st" & vbTab & ": " & .ReplyFirst & vbCrLf
			str_Renamed = str_Renamed & "ReplyNext" & vbTab & ": " & .ReplyNext & vbCrLf
			str_Renamed = str_Renamed & "DateWritten" & vbTab & ": " & sUnixDate(.DateWritten) & " (" & Hex(.DateWritten) & "h)" & vbCrLf
			str_Renamed = str_Renamed & "DateReceived" & vbTab & ": " & sUnixDate(.DateRcvd) & " (" & Hex(.DateRcvd) & "h)" & vbCrLf
			str_Renamed = str_Renamed & "DateProcessed" & vbTab & ": " & sUnixDate(.DateArrived) & " (" & Hex(.DateArrived) & "h)" & vbCrLf
			str_Renamed = str_Renamed & "MessageNumber" & vbTab & ": " & .MsgNum & vbCrLf
			str_Renamed = str_Renamed & "Attribute" & vbTab & ": " & Hex(.Attr1) & "h (" & dec2bin(.Attr1) & "b)" & vbCrLf
			str_Renamed = str_Renamed & "Attribute2" & vbTab & ": " & Hex(.Attr2) & "h (" & dec2bin(.Attr2) & "b)" & vbCrLf
			str_Renamed = str_Renamed & "Offset" & vbTab & vbTab & ": " & .TextOfs & vbCrLf
			str_Renamed = str_Renamed & "TxtLen" & vbTab & vbTab & ": " & .TextLen & vbCrLf
			str_Renamed = str_Renamed & "PasswordCRC" & vbTab & ": " & Hex(.PwdCrc) & "h" & vbCrLf
			str_Renamed = str_Renamed & "Cost" & vbTab & vbTab & ": " & .Cost & vbCrLf & vbCrLf
		End With
		
		ff = FreeFile
		
		'Index record
		FileOpen(ff, Mid(strDBname, 1, InStr(1, strDBname, ".jhr")) & "jdx", OpenMode.Binary)
		Seek(ff, (NumberMessage - 1) * Len(idx) + 1)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, idx)
		FileClose(ff)
		str_Renamed = str_Renamed & "Index Record:" & vbCrLf & vbCrLf
		str_Renamed = str_Renamed & "UserCrc" & vbTab & vbTab & ": " & Hex(idx.MsgToCrc) & "h" & vbCrLf
		str_Renamed = str_Renamed & "HeaderOffset" & vbTab & ": " & Hex(idx.HdrLoc) & "h (" & idx.HdrLoc & ")" & vbCrLf & vbCrLf
		
		'Lastread Record
		FileOpen(ff, Mid(strDBname, 1, InStr(1, strDBname, ".jhr")) & "jlr", OpenMode.Binary)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, lr)
		FileClose(ff)
		str_Renamed = str_Renamed & "Lastread Record:" & vbCrLf & vbCrLf
		str_Renamed = str_Renamed & "UserCrc" & vbTab & vbTab & ": " & Hex(lr.UserCrc) & "h" & vbCrLf
		str_Renamed = str_Renamed & "UserId" & vbTab & vbTab & ": " & Hex(lr.UserId) & "h" & vbCrLf
		str_Renamed = str_Renamed & "Lastread" & vbTab & ": " & lr.LastReadMsg & vbCrLf
		str_Renamed = str_Renamed & "Highread" & vbTab & ": " & lr.HighReadMsg & vbCrLf & vbCrLf
		
		'Base Header
		FileOpen(ff, strDBname, OpenMode.Binary)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, hdr)
		FileClose(ff)
		str_Renamed = str_Renamed & "Base Header:" & vbCrLf & vbCrLf
		str_Renamed = str_Renamed & "DateCreated" & vbTab & ": " & sUnixDate(hdr.Created) & "(" & Hex(hdr.Created) & "h)" & vbCrLf
		str_Renamed = str_Renamed & "ModCounter" & vbTab & ": " & hdr.ModCounter & vbCrLf
		str_Renamed = str_Renamed & "ActiveMsgs" & vbTab & ": " & hdr.ActiveMsgs & vbCrLf
		str_Renamed = str_Renamed & "PasswordCRC" & vbTab & ": " & Hex(hdr.PwdCrc) & "h" & vbCrLf
		str_Renamed = str_Renamed & "BaseMsgNum" & vbTab & ": " & hdr.BaseMsgNum & vbCrLf
		str_Renamed = str_Renamed & "HighWaterMark" & vbTab & ": " & hdr.HighWaterMark & vbCrLf & vbCrLf
		
		'Subfield
		str_Renamed = str_Renamed & "Subfields:" & vbCrLf & vbCrLf
		
		For i = 1 To Messages(NumberMessage).SubFieldCount
			'00002 [ 12]: "Max Irgiznov"
			txt = Messages(NumberMessage).SubField(i).Data
			tmp = CStr(Messages(NumberMessage).SubField(i).LoId)
			While Len(tmp) < 5
				tmp = "0" & tmp
			End While
			str_Renamed = str_Renamed & tmp
			
			tmp = CStr(Len(txt))
			While Len(tmp) < 3
				tmp = " " & tmp
			End While
			
			If Len(CStr(Len(txt))) = 1 Then tmp = " " & tmp
			str_Renamed = str_Renamed & "  [" & tmp & "]:  " & txt & vbCrLf
		Next 
		
		str_Renamed = str_Renamed & vbCrLf
		
		'hexdump subfield
		ReDim rArr(Messages(NumberMessage).MsgHdr.SubfieldLen)
		FileOpen(ff, strDBname, OpenMode.Binary)
		Seek(ff, Messages(NumberMessage).MessageOffset + 1) 'читаем только субполя
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, rArr)
		str_Renamed = str_Renamed & DumpByteArray(rArr) & vbCrLf & vbCrLf
		
		'hexdump msgheader
		ReDim rArr(Len(msg))
		Seek(ff, Messages(NumberMessage).MessageOffset - Len(msg) + 1)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, rArr)
		str_Renamed = str_Renamed & "Hexdump of message header:" & vbCrLf
		str_Renamed = str_Renamed & DumpByteArray(rArr) & vbCrLf & vbCrLf
		
		FileClose(ff)
		
		'hexdump text
		str_Renamed = str_Renamed & "Hexdump message text:" & vbCrLf
		
		'определяем массивчик под байтики
		ReDim rArr(Messages(NumberMessage).MsgHdr.TextLen)
		
		FileOpen(ff, Mid(strDBname, 1, InStr(1, strDBname, ".jhr")) & "jdt", OpenMode.Binary)
		Seek(ff, Messages(NumberMessage).MsgHdr.TextOfs + 1)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, rArr)
		FileClose(ff)
		
		'делаем дамп и перекодируем дос кодировку в виндовс
		txt = DumpByteArray(rArr)
		tmp = Space(Len(txt))
		'UPGRADE_ISSUE: StrPtr function is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1040"'
		MultiByteToWideCharS(CP_OEMCP, 0, txt, Len(txt), StrPtr(tmp), Len(txt))
		
		str_Renamed = str_Renamed & tmp & vbCrLf
		
		'done
		GetMessageDumpByNum = str_Renamed
		Exit Function
		
errHandler: 
		
		Select Case Err.Number
			
			Case 76
				MsgBox("Ошибка!" & vbCrLf & "Путь к JAM области не найден!", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - jamBase::GetMessageDumpByNum")
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "jamBase::GetMessageDumpByNum", "сообщение №" & NumberMessage)
		End Select
		
	End Function
	
	'~~~.GetHeadersByNum - возвращает поля мессага по его номеру
	Public Sub GetHeadesByNum(ByRef NumberMessage As Integer)
		On Error GoTo errHandler
		Dim i, nc As Short
		Dim tmp As String
		
		'своеобразная обработка ошибок, когда нам не нужен этот метод мы вызаваем его с 0 параметром
		If NumberMessage > numMessages Then
			Exit Sub
		ElseIf Messages(NumberMessage).MessageOffset = 0 Then 
			Exit Sub
		End If
		
		If NumberMessage = 0 Then
			Exit Sub
		End If
		
		msgFlags = Messages(NumberMessage).MsgHdr.Attr1
		msgDateArrived = Messages(NumberMessage).MsgHdr.DateArrived
		msgDateWritten = Messages(NumberMessage).MsgHdr.DateWritten
		msgReplayTo = Messages(NumberMessage).MsgHdr.ReplyTo
		msgReplayFirst = Messages(NumberMessage).MsgHdr.ReplyFirst
		msgReplayNext = Messages(NumberMessage).MsgHdr.ReplyNext
		
		'Сделаем также как в ..ByNumForTree
		If Messages(NumberMessage).SubField(1).LoId = 2 Then
			msgFrom = Messages(NumberMessage).SubField(1).Data
			nc = 1
			
			If Messages(NumberMessage).SubField(2).LoId = 3 Then
				msgTo = Messages(NumberMessage).SubField(2).Data
				nc = 2
				
				If Messages(NumberMessage).SubField(3).LoId = 6 Then
					msgSubj = Messages(NumberMessage).SubField(3).Data
					nc = 3
					
					If Messages(NumberMessage).SubField(4).LoId = 4 Then
						tmp = Messages(NumberMessage).SubField(4).Data
						msgFromAddr = vbNullString
						
						If InStr(1, tmp, "@") <> 0 And Len(msgFromAddr) = 0 Then
							msgFromAddr = Mid(tmp, 1, InStr(1, tmp, "@") - 1)
						ElseIf InStr(1, tmp, "/") <> 0 And Len(msgFromAddr) = 0 Then 
							msgFromAddr = Mid(tmp, 1, InStr(InStr(1, tmp, "/"), tmp, " ") - 1)
						End If
						
						nc = 4
						
						If Len(msgFromAddr) = 0 Then
							
							'адрес искать в 2000 ключе с полем REPLYTO:
							For i = nc + 1 To Messages(NumberMessage).SubFieldCount
								
								Select Case Messages(NumberMessage).SubField(i).LoId
									
									Case 2000
										'ID=2000, Name=FTSKLUDGE
										'тут будет адрес реплея на сообщение из интернета
										tmp = Messages(NumberMessage).SubField(i).Data
										
										If Len(msgFromAddr) = 0 And InStr(1, tmp, "REPLYTO") <> 0 Then
											msgFromAddr = Mid(tmp, InStr(9, tmp, ":") - 1, InStr(9, tmp, " ") + 1)
										End If
										
								End Select
								
							Next i
							
						End If
					End If
				End If
			End If
		End If
		
		If nc = 4 Then
			'все нашли выходим
			Exit Sub
		End If
		
		For i = nc + 1 To Messages(NumberMessage).SubFieldCount
			
			Select Case Messages(NumberMessage).SubField(i).LoId
				
				Case 0
					
					'ID=0, Name=OADDRESS
				Case 1
					
					'ID=1, Name=DADDRESS
				Case 2
					'ID=2, Name=SENDERNAME
					msgFrom = Messages(NumberMessage).SubField(i).Data
					
				Case 3
					'ID=3, Name=RECEIVERNAME
					msgTo = Messages(NumberMessage).SubField(i).Data
					
				Case 4
					'ID=4, Name=MSGID
					tmp = Messages(NumberMessage).SubField(i).Data
					msgFromAddr = vbNullString
					
					If InStr(1, tmp, "@") <> 0 And Len(msgFromAddr) = 0 Then
						msgFromAddr = Mid(tmp, 1, InStr(1, tmp, "@") - 1)
					ElseIf InStr(1, tmp, "/") <> 0 And Len(msgFromAddr) = 0 Then 
						
						If InStr(InStr(1, tmp, "/"), tmp, " ") - 1 > 0 Then
							msgFromAddr = Mid(tmp, 1, InStr(InStr(1, tmp, "/"), tmp, " ") - 1)
						End If
					End If
					
				Case 5
					
					'ID=5, Name=REPLYID
				Case 6
					'ID=6, Name=SUBJECT
					msgSubj = Messages(NumberMessage).SubField(i).Data
					
				Case 7
					
					'ID=7, Name=PID
				Case 8
					
					'ID=8, Name=TRACE
				Case 9
					
					'ID=9, JAMSFLD_ENCLFILE
				Case 10
					
					'ID=10, JAMSFLD_ENCLFWALIAS
				Case 11
					
					'ID=11, JAMSFLD_ENCLFREQ
				Case 12
					
					'ID=12, JAMSFLD_ENCLFILEWC
				Case 13
					
					'ID=13, JAMSFLD_ENCLINDFILE
				Case 1000
					
					'ID=1000, EMBINDAT
				Case 2000
					'ID=2000, Name=FTSKLUDGE
					'тут будет адрес реплея на сообщение из интернета
					tmp = Messages(NumberMessage).SubField(i).Data
					
					If Len(msgFromAddr) = 0 And InStr(1, tmp, "REPLYTO") <> 0 Then
						msgFromAddr = Mid(tmp, InStr(9, tmp, ":") - 1, InStr(9, tmp, " ") + 1)
					End If
					
				Case 2001
					
					'ID=2001, Name=SEENBY2D
				Case 2002
					
					'ID=2002, Name=PATH2D
				Case 2003
					
					'ID=2003, FLAGS
				Case 2004
					
					'ID=2004, TZUTCINFO
				Case Else
					'какято хрень в служебных полях
			End Select
			
		Next i
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 0
				
			Case Else
				SaveErrorDump(Me.GetMessageDumpByNum(NumberMessage))
				ErrorMessage(Err.Number, Err.Description, "jamBase::GetHeadersByNum", "сообщение №" & NumberMessage)
		End Select
		
	End Sub
	
	'~~~.GetHeadersByNumForTree - возвращает поля мессага по его номеру Для построения дерева.
	Public Sub GetHeadesByNumForTree(ByRef NumberMessage As Integer)
		On Error GoTo errHandler
		Dim i, flg As Short
		
		'своеобразная обработка ошибок, когда нам не нужен этот метод мы вызаваем его с 0 параметром
		If NumberMessage > numMessages Then
			Exit Sub
		End If
		
		If NumberMessage = 0 Then
			Exit Sub
		End If
		
		msgReplayTo = Messages(NumberMessage).MsgHdr.ReplyTo
		msgReplayFirst = Messages(NumberMessage).MsgHdr.ReplyFirst
		msgReplayNext = Messages(NumberMessage).MsgHdr.ReplyNext
		
		'т.к. мы заранее не знаем в каком месте лежат нужные поля _
		'поэтому пойдем на двойную проверку. проверим заголовки в 1м и 3м _
		'элементе и если не найдены искомые, то делаем перебор.
		
		If Messages(NumberMessage).SubField(1).LoId = 2 Then
			'ID=2, Name=SENDERNAME
			msgFrom = Messages(NumberMessage).SubField(1).Data
			flg = 1
			
			If Messages(NumberMessage).SubField(3).LoId = 6 And flg = 1 Then
				'ID=6, Name=SUBJECT
				msgSubj = Messages(NumberMessage).SubField(3).Data
				'здесь представлен самый быстрый вариант перекодировки.
				'Dim rr As Long, tp As String
				'rr = Len(msgSubj)
				'tp = Space$(rr)
				'MultiByteToWideCharS CP_OEMCP, 0&, msgSubj, rr, StrPtr(tp), rr
				'msgSubj = tp
				
				'все нашли выходим
				Exit Sub
				'flg = 2
			End If
		End If
		
		'облом. будем искать. (с)
		'flg = 0
		For i = flg + 1 To Messages(NumberMessage).SubFieldCount
			
			If Messages(NumberMessage).SubField(i).LoId = 2 Then
				'ID=2, Name=SENDERNAME
				msgFrom = Messages(NumberMessage).SubField(i).Data
				flg = flg + 1
			ElseIf Messages(NumberMessage).SubField(i).LoId = 6 Then 
				'ID=6, Name=SUBJECT
				msgSubj = Messages(NumberMessage).SubField(i).Data
				flg = flg + 1
			End If
			
			If flg >= 2 Then
				Exit For
			End If
			
		Next i
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 0
				
			Case Else
				SaveErrorDump(Me.GetMessageDumpByNum(NumberMessage))
				ErrorMessage(Err.Number, Err.Description, "jamBase::GetHeadersByNumForTree", "сообщение №" & NumberMessage)
		End Select
		
	End Sub
	
	Public Sub GetHeadesByNumAll(ByRef NumberMessage As Integer)
		'в джам базе не исспользуется
	End Sub
	
	'~~~.GetLastReadMsgNum Получает LastRead информацию из файла если msgnumber<>0 то пишем в файл
	Public Function GetLastReadMsgNum(Optional ByRef msgNumber As Integer = 0) As Integer
		On Error GoTo errHandler
		Dim ff As Integer
		Dim lr As Lastread
		Dim hdr As JamHdrType
		
		'если номер сообщения не задан, то читаем ластрид
		If msgNumber = 0 Then
			ff = FreeFile
			
			FileOpen(ff, Mid(strDBname, 1, InStr(1, strDBname, ".jhr")) & "jlr", OpenMode.Binary)
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			FileGet(ff, lr)
			FileClose(ff)
			
			FileOpen(ff, strDBname, OpenMode.Binary)
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			FileGet(ff, hdr)
			FileClose(ff)
			
			If Err.Number = 0 Then
				If lr.LastReadMsg <= lr.HighReadMsg And lr.LastReadMsg <> 0 Then
					GetLastReadMsgNum = lr.LastReadMsg - hdr.BaseMsgNum + 1
					
					If GetLastReadMsgNum > hdr.ActiveMsgs Then
						GetLastReadMsgNum = hdr.ActiveMsgs
					End If
					
				Else
					
					If hdr.ActiveMsgs <= numMessages Then
						GetLastReadMsgNum = hdr.ActiveMsgs
					Else
						GetLastReadMsgNum = numMessages
					End If
				End If
				
				'возвращает номер последнего прочитанного мессага или 0 если вообще не читали.
			Else
				GetLastReadMsgNum = -1 * Err.Number
			End If
			
		Else
			'иначе мы пишем в него. возвращаем 0 в случае успеха операции
			'в случаее ошибки возвращает ее номер со знаком -
			ff = FreeFile
			
			FileOpen(ff, strDBname, OpenMode.Binary)
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			FileGet(ff, hdr)
			FileClose(ff)
			
			FileOpen(ff, Mid(strDBname, 1, InStr(1, strDBname, ".jhr")) & "jlr", OpenMode.Binary)
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			FileGet(ff, lr)
			FileClose(ff)
			
			lr.LastReadMsg = hdr.BaseMsgNum + msgNumber - 1
			
			FileOpen(ff, Mid(strDBname, 1, InStr(1, strDBname, ".jhr")) & "jlr", OpenMode.Binary)
			'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			FilePut(ff, lr)
			FileClose(ff)
			
			If Err.Number = 0 Then
				GetLastReadMsgNum = 0
			Else
				GetLastReadMsgNum = -1 * Err.Number
			End If
			
		End If
		
		Exit Function
		
errHandler: 
		
		Select Case Err.Number
			
			Case 76
				MsgBox("Ошибка!" & vbCrLf & "Путь к JAM области не найден!", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - jamBase::GetLastReadMsgNum")
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "jamBase::GetLastReadMsgNum")
		End Select
		
	End Function
	
	'~~~.GetMessageKlugeByNum - Возвращает кладжи письма разделенные CrLf
	Public Function GetMessageKlugeByNum(ByRef NumberMessage As Integer) As String
		On Error GoTo errHandler
		Dim i As Integer
		Dim tmp, Kluges As String
		
		'своеобразная обработка ошибок, когда нам не нужен этот метод мы вызаваем его с 0 параметром
		If NumberMessage > numMessages Then
			Exit Function
		End If
		
		If NumberMessage = 0 Then
			Exit Function
		End If
		
		Kluges = vbNullString
		
		For i = 1 To Messages(NumberMessage).SubFieldCount
			
			Select Case Messages(NumberMessage).SubField(i).LoId
				
				Case 4 'msgid
					Kluges = Kluges & "@MSGID: " & Messages(NumberMessage).SubField(i).Data & vbCrLf
					
				Case 5 'replay
					Kluges = Kluges & "@REPLY: " & Messages(NumberMessage).SubField(i).Data & vbCrLf
					
				Case 2000 'others
					tmp = Messages(NumberMessage).SubField(i).Data
					
					If InStr(1, tmp, "PID: ", CompareMethod.Text) <> 0 Or InStr(1, tmp, "TID: ", CompareMethod.Text) <> 0 Or InStr(1, tmp, "AREA:", CompareMethod.Text) <> 0 Or InStr(1, tmp, "CHRS: ", CompareMethod.Text) <> 0 Then
						Kluges = Kluges & "@" & Messages(NumberMessage).SubField(i).Data & vbCrLf
					End If
					
			End Select
			
		Next i
		
		GetMessageKlugeByNum = Kluges
		
		Exit Function
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				SaveErrorDump(Me.GetMessageDumpByNum(NumberMessage))
				ErrorMessage(Err.Number, Err.Description, "jamBase::GetMessageKlugeByNum", "сообщение №" & NumberMessage)
		End Select
		
	End Function
	
	'~~~.OpenDB - открывает базу сообщений и загружает их в память
	Public Sub OpenDB()
		On Error GoTo errHandler
		Dim hJdx, hJhr, lngLong As Integer
		Dim bytFile() As Byte
		Dim sIdx As String
		Dim er, idxSize, offsetHeader, jhrSize, rplFrst As Integer
		Dim num, am As Integer
		Dim nn As String
		Dim i, rr, nbr, ss, dl As Integer
		Dim warnFlag As Boolean
		
		Dim hdr As JamHdrType 'Заголовок Базы
		Dim msg As JamMsgHdrType 'Заголовок мессага
		Dim fie As JamSubFieldType 'Единичное субполе
		Dim idx() As JamIdxType 'индексная записи
		Dim PreCreateFields As Integer
		
		Dim sigJAM As String 'Сигнатура базы\письма
		sigJAM = "JAM" & Chr(0)
		
		warnFlag = False 'Отключим по умолчанию сообщение об ошибке в субполях
		
		sIdx = Mid(strDBname, 1, InStr(1, strDBname, ".jhr")) & "jdx"
		
		hJhr = CreateFile(strDBname, GENERIC_READ, FILE_SHARE_READ, 0, OPEN_EXISTING, 0, 0)
		
		If hJhr < 0 Then
			er = GetLastError
			
			If er <> 0 Then
				ApiErrorLookup(er, "jamBase::OpenDB")
				numMessages = 0
				Exit Sub 'на пока покатит...
			Else
				CloseHandle(hJhr)
				MsgBox("Ошибка совместного доступа к базе.", MsgBoxStyle.Exclamation, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				numMessages = 0
				Exit Sub
			End If
		End If
		
		jhrSize = GetFileSize(hJhr, lngLong) 'в bytes
		
		ReDim bytFile(jhrSize)
		
		'считываем файл в массив байтов
		rr = ReadFile(hJhr, bytFile(0), jhrSize, nbr, 0)
		
		'загрузка индексов
		hJdx = CreateFile(sIdx, GENERIC_READ, FILE_SHARE_READ, 0, OPEN_EXISTING, 0, 0)
		
		If hJdx < 0 Then
			ApiErrorLookup(GetLastError, "jamBase::OpenDB")
			numMessages = 0
			CloseHandle(hJdx)
			Exit Sub 'на пока покатит...
		End If
		
		idxSize = GetFileSize(hJdx, lngLong) 'в bytes
		
		'определяем число записей и считываем их (1/len(idx)=0.125)
		ReDim idx(idxSize * 0.125)
		'UPGRADE_WARNING: Couldn't resolve default property of object idx(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		rr = ReadFile(hJdx, idx(0), idxSize, nbr, 0)
		
		CloseHandle(hJdx)
		CloseHandle(hJhr)
		
		System.Windows.Forms.Application.DoEvents()
		
		'понеслась обработка
		'читаем заголовок. Незабываем, что все начинается с 0
		'UPGRADE_WARNING: Couldn't resolve default property of object hdr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		RtlMoveMemory(hdr, bytFile(0), Len(hdr))
		
		am = hdr.ActiveMsgs
		
		If am <= 0 Then
			numMessages = 0
			Exit Sub
		End If
		
		ReDim Messages(am)
		
		num = 1 'тут реально исспользуется число индексных записей а не кол-во активных мессагов
		
		For rr = 0 To (idxSize * 0.125)
			
			'читаем данные мессага, len(msg)=76
			offsetHeader = idx(rr).HdrLoc
			
			If offsetHeader > 0 And offsetHeader < jhrSize Then
				
				'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				RtlMoveMemory(msg, bytFile(offsetHeader), 76)
				
				If UCase(msg.Signature) = sigJAM Then
					
					If num > am Then
						am = num
						ReDim Preserve Messages(am)
					End If
					
					'пишем мессаг
					'RtlMoveMemory Messages(num).MsgHdr, bytFile(offsetHeader), 76
					offsetHeader = offsetHeader + 76
					'UPGRADE_WARNING: Couldn't resolve default property of object Messages().MsgHdr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					Messages(num).MsgHdr = msg
					
					Messages(num).MessageOffset = offsetHeader
					
					'данная конструкция фиксит письма с "левыми" реплеями.
					rplFrst = Messages(num).MsgHdr.ReplyFirst - 1
					
					If rplFrst > am Then
						Messages(num).MsgHdr.ReplyFirst = rplFrst - hdr.BaseMsgNum + 1
					ElseIf rplFrst = num Then 
						'Возникают иногда глюки когда мессаг сам на себя ссылается
						Messages(num).MsgHdr.ReplyFirst = num - 1
					ElseIf rplFrst = Messages(num).MsgHdr.ReplyNext And rplFrst <> 0 Then 
						'пока пусть будет тут.
						'Возникают иногда глюки когда мессаг ссылается на одинаковые дочерние мессаги.
						Messages(num).MsgHdr.ReplyNext = 0
					ElseIf rplFrst < 0 Then 
						Messages(num).MsgHdr.ReplyFirst = 0
					Else
						Messages(num).MsgHdr.ReplyFirst = rplFrst
					End If
					
					If Messages(num).MsgHdr.ReplyNext > am Then
						Messages(num).MsgHdr.ReplyNext = Messages(num).MsgHdr.ReplyNext - hdr.BaseMsgNum + 1
					End If
					
					If Messages(num).MsgHdr.ReplyTo > am Then
						Messages(num).MsgHdr.ReplyTo = Messages(num).MsgHdr.ReplyTo - hdr.BaseMsgNum + 1
					End If
					
					If num Mod 1000 = 0 Then
						
						System.Windows.Forms.Application.DoEvents()
					End If
					
					'Избавимся от лишних редимов определив массив с запасом
					PreCreateFields = 15
					ReDim Messages(num).SubField(PreCreateFields)
					
					er = Messages(num).MsgHdr.SubfieldLen
					ss = 0
					i = 1
					
					Do 
						'читаем данные субполей
						'UPGRADE_WARNING: Couldn't resolve default property of object fie. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						RtlMoveMemory(fie, bytFile(offsetHeader), 8)
						offsetHeader = offsetHeader + 8
						
						dl = fie.DataLen
						
						If (dl > MAX_SUBFIELDLEN_NORMAL Or dl < 0) Then
							If warnFlag Then
								MsgBox("Поврежден основной файл в районе письма #" & num & vbCrLf & "Размер суб-поля вне интервала 0.." & MAX_SUBFIELDLEN_NORMAL & " байт!" & vbCrLf & "Дальнейшая работа с базой не рекомендуется!", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
							End If
							
							dl = er - ss - 8 'обрезаем по длинне субполей
						End If
						
						nn = Space(dl)
						
						'структуру тут копировать ненадо, можно сразу передать указатель
						'UPGRADE_ISSUE: StrPtr function is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1040"'
						MultiByteToWideChar(CP_OEMCP, 0, bytFile(offsetHeader), dl, StrPtr(nn), dl) 'приводим сразу к нормальному виду.
						
						'добавляем данные с ключем индентификатором
						If i > PreCreateFields Then
							'Избавимся от лишних редимов определив массив с запасом
							ReDim Preserve Messages(num).SubField(i + 5)
							PreCreateFields = PreCreateFields + 5
						End If
						
						Messages(num).SubField(i).LoId = fie.LoId
						
						'если встречается удаленный мессаг то добавим в его сабж [DEL] subj [DEL]
						If (fie.LoId = 6) Then
							If ((Messages(num).MsgHdr.Attr1 And MSG_ATTRIBUTE.MSG_DELETED) = MSG_ATTRIBUTE.MSG_DELETED) Or (Messages(num).MsgHdr.Attr1 = 0) Then
								nn = "[DEL] " & nn & " [DEL]"
							End If
						End If
						
						Messages(num).SubField(i).Data = nn
						i = i + 1 'next field count
						ss = ss + 8 + dl 'next field offset
						
						offsetHeader = offsetHeader + dl
						
					Loop Until Not (ss < er)
					
					Messages(num).SubFieldCount = i - 1 'запоминаем число подполей для быстрого доступа
					num = num + 1
				End If
			End If 'offsetHeader > 0 And offsetHeader < jhrSize
			
			'следующий мессаг
			
		Next rr
		
		numMessages = num - 1
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 5
				Exit Sub
				
			Case 75 'access denide
				
				'Добавим метод err чтобы отслеживать ошибки
			Case Else
				ErrorMessage(Err.Number, Err.Description, "jamBase::OpenDB")
		End Select
		
	End Sub
	
	'~~~.WriteMessage - Пишет сообщение в выбранную базу. Возвращает -1 в случае неудачи.
	Public Function WriteMessage() As Integer
		On Error GoTo errHandler
		Dim msg As JamMsgHdrType 'заголовок мессага
		Dim rmsg As JamMsgHdrType 'заголовок мессага
		Dim hdr As JamHdrType 'заголовок
		Dim idx As JamIdxType 'индекс
		Dim fie() As JamSubFieldType 'пишется в файл на каждое подполе за ней сразу идет блок данных по подполю
		Dim datf() As String
		Dim i, cntFie, sIdx As Integer
		Dim tmp As String
		Dim CRC As New clsCRC32
		Dim rOffset, ff, inOffset, sLen As Integer
		Dim lTo, lSubj, lFrom, lText As String
		
		'дополнительные проверки данных
		If Len(msgFromAddr) = 0 Then
			MsgBox("Адрес  отправителя не должен быть пустыми!", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
			WriteMessage = -1
			Exit Function
		End If
		
		If Len(msgFrom) = 0 Then
			MsgBox("Имя отправителя не должно быть пустым!", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
			WriteMessage = -1
			Exit Function
		End If
		
		If Len(msgTo) = 0 Then
			If MsgBox("Имя получателя не должно быть пустым! Продолжить?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name) = MsgBoxResult.No Then
				WriteMessage = -1
				Exit Function
			End If
			
			msgTo = "All"
		End If
		
		ff = FreeFile
		inOffset = FileLen(Mid(strDBname, 1, InStr(1, strDBname, ".jhr")) & "jdt") + 1
		
		'преобразовываем в нормальный вид
		
		tmp = Space(Len(msgText))
		CharToOem(msgText, tmp)
		lText = tmp & vbCr & Chr(&HDs) 'дописываем в конец
		
		FileOpen(ff, Mid(strDBname, 1, InStr(1, strDBname, ".jhr")) & "jdt", OpenMode.Binary)
		Seek(ff, inOffset)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, lText)
		FileClose(ff)
		
		tmp = Space(Len(msgSubj))
		CharToOem(msgSubj, tmp)
		lSubj = tmp
		
		tmp = Space(Len(msgFrom))
		CharToOem(msgFrom, tmp)
		lFrom = tmp
		
		tmp = Space(Len(msgTo))
		CharToOem(msgTo, tmp)
		lTo = tmp
		
		'добавляем субполя
		
		If Len(msgToAddr) = 0 Then
			cntFie = 8
		Else
			cntFie = 9
		End If
		
		'UPGRADE_WARNING: Lower bound of array fie was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1033"'
		ReDim fie(cntFie) 'пишется в файл на каждое подполе за ней сразу идет блок данных по подполю
		'UPGRADE_WARNING: Lower bound of array datf was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1033"'
		ReDim datf(cntFie)
		
		'ID=0, Name=OADDRESS
		fie(1).LoId = 0
		fie(1).DataLen = Len(msgFromAddr)
		datf(1) = msgFromAddr
		
		'ID=1, Name=DADDRESS
		fie(2).LoId = 1
		fie(2).DataLen = Len(msgToAddr)
		datf(2) = msgToAddr
		
		'ID=2, Name=SENDERNAME
		fie(3).LoId = 2
		fie(3).DataLen = Len(lFrom)
		datf(3) = lFrom
		
		'ID=3, Name=RECEIVERNAME
		fie(4).LoId = 3
		fie(4).DataLen = Len(lTo)
		datf(4) = lTo
		
		'ID=4, Name=MSGID (addr + id)
		sLen = GetTime
		fie(5).LoId = 4
		datf(5) = msgFromAddr & " " & LCase(Hex(CRC.GetStringCRC32(LCase(msgFromAddr & sLen))))
		fie(5).DataLen = Len(datf(5))
		
		'ID=6, Name=SUBJECT msgSubj
		fie(6).LoId = 6
		fie(6).DataLen = Len(lSubj)
		datf(6) = lSubj
		
		'ID=7, Name=PID
		fie(7).LoId = 7
		datf(7) = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " betta5"
		fie(7).DataLen = Len(datf(7))
		
		'ID=2000, Name=FTSKLUDGE
		fie(8).LoId = 2000
		fie(8).DataLen = Len("CHRS: CP866 2")
		datf(8) = "CHRS: CP866 2"
		
		'ID=5, Name=REPLYID
		sLen = GetTime
		fie(9).LoId = 5
		
		If cntFie = 9 Then
			If msgReplayTo <> 0 Then
				
				For i = 1 To Messages(msgReplayTo).SubFieldCount
					
					If Messages(msgReplayTo).SubField(i).LoId = 4 Then
						datf(9) = Messages(msgReplayTo).SubField(i).Data
						Exit For
					End If
					
				Next i
				
			Else
				datf(9) = msgToAddr & " " & LCase(Hex(CRC.GetStringCRC32(LCase(msgToAddr & sLen))))
			End If
			
			fie(9).DataLen = Len(datf(9))
			sLen = fie(9).DataLen
		End If
		
		sLen = sLen + Len(fie(1)) * cntFie + fie(1).DataLen + fie(2).DataLen + fie(3).DataLen + fie(4).DataLen + fie(5).DataLen + fie(6).DataLen + fie(7).DataLen + fie(8).DataLen
		
		'получаем заголовок файла для определения BaseMsgNum
		'Нас отсюда также интересует поле ActiveMsgs в нем будет лежать номер добавленного мессага
		
		FileOpen(ff, strDBname, OpenMode.Binary)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, hdr)
		hdr.ActiveMsgs = hdr.ActiveMsgs + 1
		hdr.ModCounter = hdr.ModCounter + 1
		'If hdr.BaseMsgNum = 1 Then
		'   hdr.HighWaterMark = numMessages
		'Else
		'   hdr.HighWaterMark = hdr.BaseMsgNum + numMessages
		'End If
		Seek(ff, 1)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, hdr)
		FileClose(ff)
		
		If hdr.ActiveMsgs > 0 Then
			'по данному офсету нас интересует номер последнего мессага
			FileOpen(ff, Mid(strDBname, 1, InStr(1, strDBname, ".jhr")) & "jdx", OpenMode.Binary)
			sIdx = LOF(ff) - Len(idx) + 1
			
			Do 
				
				If sIdx >= 0 Then
					Seek(ff, sIdx)
					'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
					FileGet(ff, idx)
					sIdx = sIdx - Len(idx)
				End If
				
			Loop Until idx.HdrLoc > 0 Or sIdx <= 0
			
			If sIdx <> -7 Then 'в том случае если база нулевая
				rOffset = idx.HdrLoc + 1
			Else
				rOffset = 1024
			End If
			
			FileClose(ff)
			
			'забираем заголовок последнего мессага
			FileOpen(ff, strDBname, OpenMode.Binary)
			Seek(ff, rOffset)
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			FileGet(ff, rmsg)
			FileClose(ff)
			
			msg.MsgNum = rmsg.MsgNum + 1
			
		Else
			msg.MsgNum = 1
		End If
		
		numMessages = numMessages + 1
		ReDim Preserve Messages(numMessages + 1) 'маленький запас
		
		'конструируем заголовок
		msg.Attr1 = msgFlags
		msg.DateArrived = 0
		msg.DateRcvd = 0
		msg.DateWritten = GetTime
		msg.MSGIDcrc = CRC.GetStringCRC32(Mid(datf(5), InStr(1, datf(5), " ") + 1, Len(datf(5))))
		msg.PwdCrc = -1
		
		If msgReplayTo <> 0 Then
			msg.REPLYcrc = CRC.GetStringCRC32(LCase(CStr(msgReplayTo)))
		Else
			msg.REPLYcrc = -1
		End If
		
		msg.Rev = 1
		msg.ReplyTo = msgReplayTo ' помещаем данный номер в письмо с этим Id
		msg.ReplyFirst = 0
		msg.ReplyNext = 0
		msg.Signature = "JAM" & Chr(0)
		msg.SubfieldLen = sLen
		msg.TextLen = Len(msgText)
		msg.TextOfs = inOffset - 1
		msg.TimesRead = 1
		
		'Устанавливаем реплеи только в том случае если ссылаемся на неудаленный мессаг
		
		If msg.ReplyTo <> 0 And ((Messages(msgReplayTo).MsgHdr.Attr1 And MSG_ATTRIBUTE.MSG_DELETED) <> MSG_ATTRIBUTE.MSG_DELETED) Then
			'есть ответ читаем индексный файл, чтобы найти смещение в заголовочном файле
			FileOpen(ff, Mid(strDBname, 1, InStr(1, strDBname, ".jhr")) & "jdx", OpenMode.Binary)
			Seek(ff, (msg.ReplyTo - 1) * Len(idx) + 1)
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			FileGet(ff, idx)
			rOffset = idx.HdrLoc + 1
			FileClose(ff)
			
			'забираем заголовок мессага на который ответили
			FileOpen(ff, strDBname, OpenMode.Binary)
			Seek(ff, rOffset)
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			FileGet(ff, rmsg)
			
			If rmsg.ReplyFirst = 0 Then
				rmsg.ReplyFirst = msg.MsgNum
			Else
				
				'если у нас текущее письмо не занято, то отвечаем новым письмом
				If rmsg.MsgNum = GetReplayNextForAnswer(msg.ReplyTo, ff) Then
					rmsg.ReplyNext = msg.MsgNum
				Else
					FileOpen(ff + 1, Mid(strDBname, 1, InStr(1, strDBname, ".jhr")) & "jdx", OpenMode.Binary)
					Seek(ff + 1, (rmsg.ReplyNext - 1) * Len(idx) + 1)
					'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
					FileGet(ff + 1, idx)
					rOffset = idx.HdrLoc + 1
					FileClose(ff + 1)
					
					Seek(ff, rOffset)
					'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
					FileGet(ff, rmsg)
					rmsg.ReplyNext = msg.MsgNum
				End If
			End If
			
			Seek(ff, rOffset)
			'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			FilePut(ff, rmsg)
			FileClose(ff)
		Else
			msg.ReplyTo = 0
		End If
		
		'пишем получившийся итог в коллекцию
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Messages().MsgHdr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Messages(numMessages).MsgHdr = msg
		Messages(numMessages).SubFieldCount = 8
		Messages(numMessages).MessageOffset = inOffset
		
		For i = 1 To 8
			ReDim Preserve Messages(numMessages).SubField(i)
			Messages(numMessages).SubField(i).LoId = fie(i).LoId
			Messages(numMessages).SubField(i).Data = datf(i)
		Next i
		
		'все готово для записи в файл пишем msg, и fie(i) + datf(i)
		inOffset = FileLen(strDBname) + 1
		FileOpen(ff, strDBname, OpenMode.Binary)
		Seek(ff, inOffset)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, msg)
		'кладем субполя
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, fie(3)) '2
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, datf(3))
		
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, fie(1)) '0
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, datf(1))
		
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, fie(4)) '3
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, datf(4))
		
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, fie(2)) '1
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, datf(2))
		
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, fie(6)) '6
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, datf(6))
		
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, fie(5)) '4
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, datf(5))
		
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, fie(7)) '7
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, datf(7))
		
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, fie(8)) '2000
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, datf(8))
		
		If cntFie = 9 Then
			'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			FilePut(ff, fie(9)) '5
			'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			FilePut(ff, datf(9))
		End If
		
		FileClose(ff)
		
		'теперь еще нада поправить индексный файл...
		'чтобы в нем запись указывала на новый заголовок
		FileOpen(ff, Mid(strDBname, 1, InStr(1, strDBname, ".jhr")) & "jdx", OpenMode.Binary)
		idx.MsgToCrc = CRC.GetStringCRC32(LCase(msgTo))
		idx.HdrLoc = inOffset - 1
		Seek(ff, (numMessages - 1) * Len(idx) + 1)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, idx)
		FileClose(ff)
		
		i = InStr(1, strDBname, ".jhr")
		While Mid(strDBname, i, 1) <> "\"
			i = i - 1
		End While
		
		'дописываем файл echomail.jam строчку: путь к базе без расширения и число=hdr.basemsgnum+numbermessage - 1
		'это действительно только для Fastecho, HPT например ожидает увидеть только "символьное" имя эхи. :\
		FileOpen(ff, Mid(strDBname, 1, i) & "echomail.jam", OpenMode.Append)
		PrintLine(ff, Mid(strDBname, 1, InStr(1, strDBname, ".jhr") - 1) & " " & hdr.BaseMsgNum + numMessages - 1)
		'Print #ff, resolve(strDBname)  ' - may be in HPT
		FileClose(ff)
		
		'Ставим ластрид на новый мессаг
		i = Me.GetLastReadMsgNum(numMessages - 1) 'вызываем запись мессага, новый мессаг метим нечитанным
		
		If i < 0 Then
			'произошла ошибка
			MsgBox("Error In Save LastRead! " & i, MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - jamBase::WriteMessage")
		End If
		
		'UPGRADE_NOTE: Object CRC may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		CRC = Nothing
		Exit Function
		
errHandler: 
		
		Select Case Err.Number
			
			Case 76
				
				'MsgBox "Ошибка!" & vbCrLf & "Путь к JAM области не найден!", vbCritical + vbSystemModal, App.Title
			Case Else
				ErrorMessage(Err.Number, Err.Description, "jamBase::WriteMessage")
				WriteMessage = -1
		End Select
		
	End Function
	
	'Возвращает первое письмо в интересующей нас цепочке ответов где поле RaplayNext=0
	Private Function GetReplayNextForAnswer(ByRef NumberMessage As Integer, ByRef FileNum As Integer) As Integer
		On Error GoTo errHandler
		Dim stOffset, ff As Integer
		Dim rmsg As JamMsgHdrType 'заголовок мессага
		Dim idx As JamIdxType 'индекс
		
		ff = FreeFile
		
		'определяем стартовый офсет мссага
		FileOpen(ff, Mid(strDBname, 1, InStr(1, strDBname, ".jhr")) & "jdx", OpenMode.Binary)
		Seek(ff, (NumberMessage - 1) * Len(idx) + 1)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, idx)
		stOffset = idx.HdrLoc + 1
		
		'теперь перебираем все мессаги в цепочке ответов и ищем тот мессаг у которого _
		'ReplayNext еще не занят
		
		Seek(FileNum, stOffset)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(FileNum, rmsg)
		While rmsg.ReplyNext <> 0
			
			If rmsg.ReplyNext <> 0 Then
				Seek(ff, (rmsg.ReplyNext - 1) * Len(idx) + 1)
				'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
				FileGet(ff, idx)
				stOffset = idx.HdrLoc + 1
			End If
			
			Seek(FileNum, stOffset)
			'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			FileGet(FileNum, rmsg)
		End While
		
		FileClose(ff)
		
		GetReplayNextForAnswer = rmsg.MsgNum
		Exit Function
errHandler: 
		
		Select Case Err.Number
			
			Case 76
				MsgBox("Ошибка!" & vbCrLf & "Путь к JAM области не найден!", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - jamBase::GetReplayNextForAnswer")
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "jamBase::GetReplayNextForAnswer")
		End Select
		
	End Function
	
	'~~~.DeleteMessageByNum
	Public Sub DeleteMessageByNum(ByRef NumberMessage As Integer)
		On Error GoTo errHandler
		Dim ff, i As Integer
		Dim msg As JamMsgHdrType
		Dim rmsg As JamMsgHdrType 'заголовок мессага
		Dim hdr As JamHdrType
		Dim idx As JamIdxType 'индекс
		
		ff = FreeFile
		FileOpen(ff, strDBname, OpenMode.Binary)
		'в заголовке уменьшаем .ActiveMsgs
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, hdr)
		hdr.ActiveMsgs = hdr.ActiveMsgs - 1
		hdr.HighWaterMark = hdr.HighWaterMark - 1
		hdr.ModCounter = hdr.ModCounter + 1
		
		'приводим базу к дефолтному виду
		If hdr.ActiveMsgs < 0 Then
			hdr.ActiveMsgs = 0
		End If
		
		If hdr.HighWaterMark < 0 Then
			hdr.HighWaterMark = 0
		End If
		
		Seek(ff, 1)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, hdr)
		
		'меняем флаг в заголовке мессага
		Seek(ff, Messages(NumberMessage).MessageOffset)
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, msg)
		'UPGRADE_WARNING: Couldn't resolve default property of object rmsg. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		rmsg = msg 'копируем экземпляр заголовка для дольнейшего пользованиния
		msg.Attr1 = msg.Attr1 Or MSG_ATTRIBUTE.MSG_DELETED
		'msg.TextLen = 0
		'msg.TextOfs = 0
		msg.REPLYcrc = -1
		msg.ReplyFirst = 0
		msg.ReplyNext = 0
		msg.ReplyTo = 0
		Seek(ff, Messages(NumberMessage).MessageOffset)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, msg)
		FileClose(ff)
		
		FileOpen(ff, Mid(strDBname, 1, InStr(1, strDBname, ".jhr")) & "jdx", OpenMode.Binary)
		idx.MsgToCrc = -1
		idx.HdrLoc = -1
		Seek(ff, (NumberMessage - 1) * Len(idx) + 1)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, idx)
		FileClose(ff) 'jdx
		
		'меняем флаг в памяти
		Messages(NumberMessage).MsgHdr.Attr1 = Messages(NumberMessage).MsgHdr.Attr1 Or MSG_ATTRIBUTE.MSG_DELETED
		
		'выходим из функции. больне по дереву менять нигде ничего не будем.
		Exit Sub
		
		FileOpen(ff, strDBname, OpenMode.Binary)
		
		'а еще нада прибить все реплеи на данный мессаг
		For i = 1 To UBound(Messages)
			
			If (Messages(i).MsgHdr.Attr1 And MSG_ATTRIBUTE.MSG_DELETED) <> MSG_ATTRIBUTE.MSG_DELETED Then
				If Messages(i).MsgHdr.ReplyTo = NumberMessage Then
					'delete
					Seek(ff, Messages(i).MessageOffset)
					'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
					FileGet(ff, msg)
					msg.ReplyTo = 0
					Seek(ff, Messages(i).MessageOffset)
					'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
					FilePut(ff, msg)
				End If
				
				If Messages(i).MsgHdr.ReplyNext = NumberMessage Then
					'delete
					Seek(ff, Messages(i).MessageOffset)
					'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
					FileGet(ff, msg)
					msg.ReplyNext = 0
					Seek(ff, Messages(i).MessageOffset)
					'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
					FilePut(ff, msg)
				End If
				
				If Messages(i).MsgHdr.ReplyFirst = NumberMessage Then
					'delete
					Seek(ff, Messages(i).MessageOffset)
					'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
					FileGet(ff, msg)
					msg.ReplyFirst = 0
					Seek(ff, Messages(i).MessageOffset)
					'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
					FilePut(ff, msg)
				End If
			End If
			
		Next i
		
		FileClose(ff)
		
		Exit Sub
		
errHandler: 
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Err.NumberMessage. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Select Case Err.NumberMessage
			
			Case 76
				MsgBox("Ошибка!" & vbCrLf & "Путь к JAM области не найден!", MsgBoxStyle.Critical + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - jamBase::DeleteMessageByNum")
				
			Case Else
				SaveErrorDump(Me.GetMessageDumpByNum(NumberMessage))
				ErrorMessage(Err.Number, Err.Description, "jamBase::DeleteMessageByNum", "сообщение №" & NumberMessage)
		End Select
		
	End Sub
	
	'функция декодирует ESC последовательность
	Private Function DeCode(ByRef Text As String) As Object
		On Error GoTo errHandler
		Dim RegEx As New VBScript_RegExp_55.RegExp ' РегЭкспы
		Dim colMatches As VBScript_RegExp_55.MatchCollection ' коллекция этих образцов
		Dim aMatch As VBScript_RegExp_55.Match ' один из совпавших образцов
		
		RegEx.[Global] = True
		RegEx.Pattern = "=([0-9a-fA-F]{2})"
		colMatches = RegEx.Execute(Text)
		
		For	Each aMatch In colMatches ' проходим по всей коллекции
			Text = Replace(Text, aMatch.Value, Chr(hex2dec(aMatch.SubMatches(0))))
		Next aMatch
		
		DeCode = ReCode(Text, modCommon.code.Koi, modCommon.code.Win)
		Exit Function
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "jamBase::DeCode")
		End Select
		
	End Function
	
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
				ErrorMessage(Err.Number, Err.Description, "jamBase::DumpByteArray")
		End Select
		
	End Function
	
	'cоздает пустую базу
	Private Sub CreateDefaultBase(ByRef FullDbName As String)
		On Error GoTo errHandler
		Dim hdr As JamHdrType
		Dim ff As Integer
		
		With hdr
			.Signature = "JAM"
			.Created = GetTime
		End With
		
		ff = FreeFile
		FileOpen(ff, FullDbName, OpenMode.Binary)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, hdr)
		FileClose(ff)
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "jamBase::CreateDefaultBase")
		End Select
		
	End Sub
	
	Private Sub SaveErrorDump(ByRef Message As String)
		On Error Resume Next
		Dim ff As Integer
		
		ff = FreeFile
		FileOpen(ff, VB6.GetPath & "\jamBaseDump_" & CStr(VB.Timer()) & ".txt", OpenMode.Binary)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FilePut(ff, Message)
		FileClose(ff)
		
	End Sub
	
	Private Function GetOffsetByNum(ByRef NumberMessage As Integer) As Integer
		Dim idx As JamIdxType
		Dim jdxHandle As Integer
		Dim sIdx As String
		
		If NumberMessage > numMessages And NumberMessage <= 0 And Len(strDBname) = 0 Then
			Exit Function
		End If
		
		sIdx = Mid(strDBname, 1, InStr(1, strDBname, ".jhr")) & "jdx"
		
		'открытие индексов
		jdxHandle = CreateFile(sIdx, GENERIC_READ, FILE_SHARE_READ, 0, OPEN_EXISTING, 0, 0)
		
		If jdxHandle < 0 Then
			ApiErrorLookup(GetLastError, "jamBase::GetOffsetByNum")
			numMessages = 0
			Exit Function 'на пока покатит...
		End If
		
		If SetFilePointer(jdxHandle, (NumberMessage - 1) * 8, 0, FILE_BEGIN) = 0 Then
			ApiErrorLookup(GetLastError, "JAM::GetOffsetByNum")
			CloseHandle(jdxHandle)
			Exit Function
		End If
		
		'загрузка записи
		'UPGRADE_WARNING: Couldn't resolve default property of object idx. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If ReadFile(jdxHandle, idx, 8, 0, 0) = 0 Then
			ApiErrorLookup(GetLastError, "JAM::GetOffsetByNum")
			CloseHandle(jdxHandle)
			Exit Function
		End If
		
		CloseHandle(jdxHandle)
		
		GetOffsetByNum = idx.HdrLoc
		
	End Function
	
	'Изменяет статус мессага на прочитанный(1) и непрочитанный(0), -1 прочитать статус
	Public Function MessageStatus(ByRef NumberMessage As Integer, Optional ByRef Status As Integer = -1) As Integer
		Dim msg As JamMsgHdrType
		Dim jhrHandle As Integer
		
		If NumberMessage > numMessages Or NumberMessage <= 0 Or Len(strDBname) = 0 Then
			Exit Function
		End If
		
		'открытие заголовков
		jhrHandle = CreateFile(strDBname, GENERIC_READ Or GENERIC_WRITE, FILE_SHARE_READ, 0, OPEN_EXISTING, 0, 0)
		
		If jhrHandle < 0 Then
			ApiErrorLookup(GetLastError, "jamBase::ChangeMessageStatus")
			numMessages = 0
			Exit Function 'на пока покатит...
		End If
		
		If SetFilePointer(jhrHandle, Messages(NumberMessage).MessageOffset - Len(msg), 0, FILE_BEGIN) = 0 Then
			ApiErrorLookup(GetLastError, "JAM::ChangeMessageStatus")
			CloseHandle(jhrHandle)
			Exit Function
		End If
		
		'загрузка записи
		'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If ReadFile(jhrHandle, msg, Len(msg), 0, 0) = 0 Then
			ApiErrorLookup(GetLastError, "JAM::ChangeMessageStatus")
			CloseHandle(jhrHandle)
			Exit Function
		End If
		
		'если у нас только чтение
		If Status <> -1 Then
			msg.Resvd = Status
			
			If SetFilePointer(jhrHandle, Messages(NumberMessage).MessageOffset - Len(msg), 0, FILE_BEGIN) = 0 Then
				ApiErrorLookup(GetLastError, "JAM::ChangeMessageStatus")
				CloseHandle(jhrHandle)
				Exit Function
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object msg. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If WriteFile(jhrHandle, msg, Len(msg), 0, 0) = 0 Then
				ApiErrorLookup(GetLastError, "JAM::ChangeMessageStatus")
				CloseHandle(jhrHandle)
				Exit Function
			End If
			
		Else
			MessageStatus = msg.Resvd
		End If
		
		CloseHandle(jhrHandle)
		
	End Function
End Class