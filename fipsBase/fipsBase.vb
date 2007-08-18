Option Explicit On

Imports System.IO
Imports System.Drawing
Imports System.Text

Public Class Database
    Implements IDatabases

#Region "Private members"
    '~~~~~~~~~~~~~~~~~~~~~переменные для свойств
    Private strDBname As String         'local copy
    Private strEchoName As String       'local copy
    Private numMessages As Integer      'local copy
    Private msgFrom As String           'local copy
    Private msgFromAddr As String       'local copy
    Private msgTo As String             'local copy
    Private msgToAddr As String         'local copy
    Private msgDateWritten As Integer   'local copy
    Private msgDateArrived As Integer   'local copy
    Private msgSubj As String           'local copy
    Private msgText As String = ""      'local copy
    Private msgFlags As Integer         'local copy
    Private msgReplayTo As Integer      'local copy
    Private msgReplayFirst As Integer   'local copy
    Private msgReplayNext As Integer    'local copy
    Private bolDefault As Boolean

    Private EchoID As Integer 'Номер записи об текущей эхе в areas.wwd
    Private Kluges As String  'Кладжи текущего письма
    Private SeenBy As String  'SeenBy's текущего письма

    'Main Streams
    Private fsH As FileStream   'Headers stream 
    Private fsT As FileStream   'Texts stream    
    Private brH As BinaryReader 'Read headers
    Private brT As BinaryReader 'Read texts
    Private wrH As BinaryWriter 'Write headers
    Private wrT As BinaryWriter 'Write texts
    Private ffsT As String      'filename for texts

    Private enc As Encoding = Encoding.GetEncoding(866)
    Private dtUNIX_DATE As Date = DateTime.Parse("01.01.1970 00:00:00")

#End Region
#Region "FIPS Structure"
    Private Structure AreaRecord
        Dim Index As Integer 'Порядковый номер области в списке (уникален)
        Dim StructLen As Integer 'Длина записи (всегда равна 562)
        Dim Status As Integer 'Статус области
        <VBFixedString(129)> Dim Description As String 'Описание области
        <VBFixedString(101)> Dim Echotag As String 'Название области
        <VBFixedString(128)> Dim FileName As String 'Имя файла заголовков и писем без расширения
        Dim Lastread As Integer 'Индекс последнего прочитанного письма
        Dim Hheader As Integer 'Указатель на файл заголовков (используется во время работы программы)
        Dim Hmessage As Integer 'Указатель на файл базы писем (используется во время работы программы)
        <VBFixedString(21)> Dim AKA As String 'Ваш АКА для этой области
        <VBFixedString(31)> Dim UpLink As String 'Ваш аплинк для этой области
        <VBFixedString(12)> Dim Group As String 'Группа, к которой относится эта область
        Dim Membership As Integer '
        Dim PurgeAgeCreate As Integer 'Данные, используемые пуржером при работе
        Dim PurgeAgeRecipt As Integer
        Dim PurgeMaxNum As Integer
        Dim PurgeFlagCreate As Integer
        Dim PurgeFlagAgeRecipt As Integer
        Dim PurgeFlagNrmails As Integer
        Dim NumberOfMails As Integer 'Число сообщений в базе писем этой области
        Dim NumberOfAlreadyRead As Integer 'Число уже прочитанных сообщений
        Dim LocalMail As Integer 'Флаг неэкспортируемой области
        Dim AdditionalDays As Integer 'Дополнительное число дней для непрочитанных писем, используемое пуржером для автоматической чистки базы
        Dim AreaCreationDate As Integer 'Дата создания области
        <VBFixedString(68)> Dim NoName As String 'Внутренние неспользуемые данные
        'Длина одной записи = 562
    End Structure

    Private Structure HdrRecord
        <VBFixedString(72)> Dim Subject As String 'Поле "Тема" заголовка письма
        <VBFixedString(20)> Dim DateTime As String 'Дата и время создания письма в виде символьной строки в формате, принятом в сети FidoNet
        <VBFixedString(36)> Dim ToName As String 'Поле "Кому" заголовка письма
        <VBFixedString(36)> Dim FromName As String 'Поле "От кого" заголовка письма
        Dim StrucLen As Integer 'Размер структуры файла заголовков и должен быть равен 238
        Dim Status As Integer ' Статус письма (см. константы статуса письма)
        Dim MailID As Integer ' Идентификатор письма, используемый тоссером
        Dim ReciptTime As Integer 'Дата и время тоссинга
        Dim offset As Integer 'Смещение  первого символа текста сообщения (кладж MagicID) в файле базы писем
        Dim TextLen As Integer 'Длина текста сообщения в файле базы писем (включая все кладжи)
        Dim Index As Integer 'Порядковый номер этого сообщения в базе писем (0, 1, 2 и т. д.)
        Dim Filler As Short 'Пустое поле
        Dim Attrib As Short 'Атрибуты письма (см. константы атрибутов письма)
        Dim Cost As Short 'Пустое поле
        Dim OrigZone As Short 'Номер зоны отправителя (обычно 2)
        Dim OrigNet As Short 'Номер сети отправителя
        Dim OrigNode As Short 'Номер узла отправителя
        Dim OrigPoint As Short 'Номер поинта отправителя
        Dim DestZone As Short 'Номер зоны получателя (обычно 2)
        Dim DestNet As Short 'Номер сети получателя
        Dim DestNode As Short 'Номер узла получателя
        Dim DestPoint As Short 'Номер поинта получателя
        Dim ReplyID As Integer 'Идентификатор ответа  ReplyID (устанавливается и используется тоссером)
        Dim NestLevel As Integer 'Временное поле, используемое для построения связанного списка ответов
        Dim UnixTime As Integer 'Время создания письма в формате, принятом в UNIX
        Dim ZoneNet As Integer 'Старшие 16 бит содержат номер зоны, младшие 16 бит - номер сети получателя
        Dim node As Integer 'Номер узла получателя (для тех писем, у которых установлен флаг письма DB_Mail_Route_to_Boss)
        Dim MailText As Integer 'String * 4 'Указатель на начало текста (может быть nil)
    End Structure

    Private Structure MessRecord
        'MagicID(15) As Byte 'Это идентификатор начала заголовка нового сообщения, представляет собой
        'массив из 16 байт, содержащий постоянную последовательность
        '0xfe, 0xaf, 0xfe, 0xaf, 0xfe, 0xaf, 0xfe, 0xaf, 0x04, 0x03, 0x02, 0x01, 0x01, 0x02, 0x03, 0x04
        <VBFixedArray(16)> Dim MagicID() As Byte
        Dim Version As Integer 'Номер версии формата базы и должен быть равен 0х01
        <VBFixedString(20)> Public EchoTag As String 'Название области
        <VBFixedString(72)> Public Subject As String 'Поле "Тема" заголовка письма
        <VBFixedString(20)> Public DateTime As String 'Дата и время создания письма в виде символьной строки в формате, принятом в сети FidoNet
        <VBFixedString(36)> Public ToName As String 'Поле "Кому" заголовка письма
        <VBFixedString(36)> Public FromName As String 'Поле "От кого" заголовка письма
        Dim StrucLen As Integer 'Размер структуры файла заголовков и должен быть равен 278
        Dim Status As Integer 'Статус письма (см. константы статуса письма)
        Dim MailID As Integer 'Идентификатор письма, используемый тосеером
        Dim ReciptTime As Integer 'Дата и время тоссинга
        Dim offset As Integer 'Смещение  первого символа текста сообщения (кладж MagicID) в файле базы писем
        Dim TextLen As Integer 'Длина текста сообщения в файле базы писем (включая все кладжи)
        Dim Index As Integer 'Порядковый номер этого сообщения в базе писем (0, 1, 2 и т. д.)
        Dim Filler As Short 'Пустое поле
        Dim Attrib As Short 'Атрибуты письма (см. константы аттрибутов письма)
        Dim Cost As Short 'Пустое поле
        Dim OrigZone As Short 'Номер зоны отправителя (обычно 2)
        Dim OrigNet As Short 'Номер сети отправителя
        Dim OrigNode As Short 'Номер узла отправителя
        Dim OrigPoint As Short 'Номер поинта отправителя
        Dim DestZone As Short 'Номер зоны получателя (обычно 2)
        Dim DestNet As Short 'Номер сети получателя
        Dim DestNode As Short 'Номер узла получателя
        Dim DestPoint As Short 'Номер поинта получателя
        Dim ReplyID As Integer 'Идентификатор ответа  ReplyID (устанавливается и используется тоссером)
        Dim NestLevel As Integer 'Временное поле, используемое для построения связанного списка ответов
        Dim UnixTime As Integer 'Время создания письма в формате, принятом в UNIX
        Dim ZoneNet As Integer 'Старшие 16 бит содержат номер зоны, младшие 16 бит - номер сети получателя
        Dim node As Integer 'Номер узла получателя (для тех писем, у которых установлен флаг письма DB_Mail_Route_to_Boss)
        Dim MailText As Integer 'String * 4 'Указатель на начало текста (может быть nil)

        Public Sub Initialize()
            ReDim MagicID(16)
        End Sub
    End Structure

    Private Enum MessStatus
        stDB_DELETED = &H1 'Письмо помечено на удаление
        stDB_MARKED_FOR_PURGE = &H2 'Письмо помечено для пурженья
        stDB_AREA_LOCKED = &H4 'Область заблокирована
        stDB_MAIL_STATUS_READ = &H8 'Письмо прочитано
        stDB_AREA_MODIFIED = &H10 'Область необходимо пересканировать на предмет обнаружения новых сообщений
        stDB_MAIL_STATUS_CREATED_MAIL = &H20 'Созданное сообщение
        stDB_MAIL_STATUS_SCANNED = &H40S 'Письмо просканировано
        stDB_MAIL_NEVER_DELETE = &H80 'Письмо помечено как неудаляемое
        stDB_MAIL_ROUTE_TO_BOSS = &H100 'Отправить письмо прямо боссу
        stDB_DUPE_MAIL = &H200 'Это копия имеющегося письма (дуп)
        stDB_FROZEN_MAIL = &H400 'Письмо помечено как "Отложенное"
        stDB_USERMARKED = &H800 'Письмо помечено пользователем
        stDB_ANSWERED = &H1000 'На это письмо есть ответ
        stDB_CONVERTED = &H2000 'Письмо было сконвертировано
    End Enum

    Private Enum MessAttrib
        atMSGPRIVATE = &H1 'Частное письмо
        atMSGCRASH = &H2 'Отправить немедленно
        atMSGRECD = &H4 'Письмо получено
        atMSGSENT = &H8 'Отправлено удачно
        atMSGFILE = &H10 'К письму прикреплен аттач
        atMSGFWD = &H20 'Письмо было отфорваржено
        atMSGORPHAN = &H40 'Неизвестна нода-получатель
        atMSGKILL = &H80 'Удалить после отправки
        atMSGLOCAL = &H100 'Сообщение написано на Вашей станции
        atMSGXX1 = &H200 '
        atMSGXX2 = &H400 '
        atMSGFRQ = &H800 'Файловый запрос
        atMSGRRQ = &H1000 'Запрос принят
        atMSGCPT = &H2000 'Письмо - подтверждение приема
        atMSGARQ = &H4000 'Запрос пути следования
        atMSGURQ = &H8000 'Обновление запроса
    End Enum
#End Region

    Public ReadOnly Property BaseType() As GfeCore.IDatabasesTypes.enmBaseType Implements GfeCore.IDatabases.BaseType
        Get
            Return IDatabasesTypes.enmBaseType.FIPS
        End Get
    End Property
    Public Property DateArrived() As Integer Implements GfeCore.IDatabases.DateArrived
        Get
            Return msgDateArrived
        End Get
        Set(ByVal value As Integer)
            msgDateArrived = value
        End Set
    End Property
    Public Property DateWritten() As Integer Implements GfeCore.IDatabases.DateWritten
        Get
            Return msgDateWritten
        End Get
        Set(ByVal value As Integer)
            msgDateWritten = value
        End Set
    End Property
    Public Property DBName() As String Implements GfeCore.IDatabases.DBName
        Get
            Return strDBname
        End Get
        Set(ByVal value As String)
            strDBname = value
        End Set
    End Property
    Public Sub DeleteMessageByNum(ByVal NumberMessage As Integer) Implements GfeCore.IDatabases.DeleteMessageByNum
        '
    End Sub
    Public Property EchoName() As String Implements GfeCore.IDatabases.EchoName
        Get
            Return strEchoName
        End Get
        Set(ByVal value As String)
            strEchoName = value
        End Set
    End Property
    Public Property From() As String Implements GfeCore.IDatabases.From
        Get
            Return msgFrom
        End Get
        Set(ByVal value As String)
            msgFrom = value
        End Set
    End Property
    Public Property FromAddr() As String Implements GfeCore.IDatabases.FromAddr
        Get
            Return msgFromAddr
        End Get
        Set(ByVal value As String)
            msgFromAddr = value
        End Set
    End Property
    Public Sub GetHeadesByNum(ByVal NumberMessage As Integer) Implements GfeCore.IDatabases.GetHeadesByNum
        If NumberMessage > numMessages Then
            Exit Sub
        ElseIf NumberMessage = 0 Then
            Exit Sub
        End If

        'забираем заголовки        
        fsH.Seek((NumberMessage - 1) * 238, SeekOrigin.Begin)
        msgSubj = enc.GetString(brH.ReadBytes(72), 0, 72).Replace(Chr(0), "")
        fsH.Seek(20, SeekOrigin.Current) 'Seek to ToName
        msgTo = enc.GetString(brH.ReadBytes(36), 0, 36).Replace(Chr(0), "")
        msgFrom = enc.GetString(brH.ReadBytes(36), 0, 36).Replace(Chr(0), "")
        If brH.ReadInt32 <> 238 Then
            'errr
            Exit Sub
        End If
        fsH.Seek(8, SeekOrigin.Current) 'Seek to ReciptTime
        msgDateArrived = brH.ReadInt32
        fsH.Seek(14, SeekOrigin.Current) 'Seek to Attrib
        msgFlags = CInt(brH.ReadInt16)
        fsH.Seek(2, SeekOrigin.Current) 'Seek to OrigZone
        msgFromAddr = CStr(brH.ReadInt16) & ":" & CStr(brH.ReadInt16) & "/" & CStr(brH.ReadInt16) & "." & CStr(brH.ReadInt16)
        msgToAddr = CStr(brH.ReadInt16) & ":" & CStr(brH.ReadInt16) & "/" & CStr(brH.ReadInt16) & "." & CStr(brH.ReadInt16)
        msgReplayTo = brH.ReadInt32
        fsH.Seek(4, SeekOrigin.Current) 'Seek to UnixTime
        msgDateWritten = brH.ReadInt32
       
    End Sub
    Public Sub GetHeadesByNumAll(ByVal NumberMessage As Integer) Implements GfeCore.IDatabases.GetHeadesByNumAll

    End Sub
    Public Sub GetHeadesByNumForTree(ByVal NumberMessage As Integer) Implements GfeCore.IDatabases.GetHeadesByNumForTree

    End Sub
    Public Function GetLastReadMsgNum(Optional ByVal msgNumber As Integer = 0) As Integer Implements GfeCore.IDatabases.GetLastReadMsgNum

    End Function
    Public Sub GetMessageByNum(ByVal NumberMessage As Integer) Implements GfeCore.IDatabases.GetMessageByNum
        Dim msgTxtOffset, msgTxtLen As Integer
        Dim TxtArray() As String
        If NumberMessage > numMessages Then
            Exit Sub
        ElseIf NumberMessage = 0 Then
            Exit Sub
        End If

        'забираем заголовки        
        fsH.Seek((NumberMessage - 1) * 238 + 180, SeekOrigin.Begin) 'Seek to offset
        msgTxtOffset = brH.ReadInt32
        msgTxtLen = brH.ReadInt32

        If msgTxtLen > fsT.Length Or msgTxtOffset > fsT.Length Then
            'err
            Exit Sub
        End If

        'тексты
        fsT.Seek(msgTxtOffset + 278, SeekOrigin.Begin)
        TxtArray = enc.GetString(brT.ReadBytes(msgTxtLen), 0, msgTxtLen).Split(vbCr)

        msgText = ""

        For i As Integer = 0 To TxtArray.Length - 1

            If Left(TxtArray(i), 1) = Chr(1) Then
                Kluges = Kluges & TxtArray(i) & vbCrLf
            ElseIf Left(TxtArray(i).ToUpper, 8) = "SEEN-BY:" Then

                For n As Integer = i To TxtArray.Length - 1
                    SeenBy = SeenBy & TxtArray(n) & vbCrLf
                Next

                Exit For

            Else
                msgText = msgText & TxtArray(i) & vbCr
            End If

        Next

    End Sub
    Public Function GetMessageDumpByNum(ByVal NumberMessage As Integer) As String Implements GfeCore.IDatabases.GetMessageDumpByNum
        Return ""
    End Function
    Public Function GetMessageKlugeByNum(ByVal NumberMessage As Integer) As String Implements GfeCore.IDatabases.GetMessageKlugeByNum
        Me.GetMessageByNum(NumberMessage)
        Return Kluges
    End Function
    Public Property MessageCount() As Integer Implements GfeCore.IDatabases.MessageCount
        Get
            Return Me.MessageCountByEcho(strDBname)
        End Get
        Set(ByVal value As Integer)
            numMessages = value
        End Set
    End Property
    Public ReadOnly Property MessageCountByEcho(ByVal EchoPath As String) As Integer Implements GfeCore.IDatabases.MessageCountByEcho
        Get
            ' TODO: данный код требует переписки с учетом файловых потоков, 
            ' а также с целью избавиться от цикла.
            Dim ech, aaf, ech2 As String
            Dim ff As Integer
            Dim arRec() As AreaRecord

            aaf = Mid(EchoPath, 1, InStrRev(EchoPath, "\")) & "areas.wwd"
            ech = Replace(Mid(EchoPath, InStrRev(EchoPath, "\") + 1, EchoPath.Length), ".hdr", "", , , CompareMethod.Text)

            ff = FreeFile()
            FileOpen(ff, aaf, OpenMode.Binary)
            ReDim arRec((LOF(ff) / 562) - 1)
            FileGet(ff, arRec) 'читаем все сразу
            FileClose(ff)

            ech2 = ech & Chr(0) & Space(128 - Len(ech) - 1)
            ech = ech & New String(Chr(0), 128 - Len(ech))

            For ff = 0 To UBound(arRec)

                If arRec(ff).FileName = ech Or arRec(ff).FileName = ech2 Then
                    Return arRec(ff).NumberOfMails
                End If

            Next

            Return 0

        End Get
    End Property
    Public Property MessageFlags() As Integer Implements GfeCore.IDatabases.MessageFlags
        Get
            Return msgFlags
        End Get
        Set(ByVal value As Integer)
            msgFlags = value
        End Set
    End Property
    Public Function MessageStatus(ByVal NumberMessage As Integer, Optional ByVal Status As Integer = -1) As Integer Implements GfeCore.IDatabases.MessageStatus

    End Function
    Public Property MessageText() As String Implements GfeCore.IDatabases.MessageText
        Get
            Return msgText
        End Get
        Set(ByVal value As String)
            msgText = value
        End Set
    End Property
    Public Sub OpenDB() Implements GfeCore.IDatabases.OpenDB
        ffsT = Mid$(DBName, 1, InStr(DBName, ".hdr", CompareMethod.Text)) & "mes"

        numMessages = Me.MessageCountByEcho(strDBname)
        EchoID = GetAreaIdByEchoPath(strDBname)
        strEchoName = GetEchoNameByEchoPath(strDBname)

        Try
            fsH = New FileStream(strDBname, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            brH = New BinaryReader(fsH)
            wrH = New BinaryWriter(fsH)
        Catch e As System.IO.FileNotFoundException
            MsgBox("Файл заголовков: " & strDBname & " не найден.")
            Exit Sub
        Catch
            Exit Sub
        End Try

        Try
            fsT = New FileStream(ffsT, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)
            brT = New BinaryReader(fsT)
            wrT = New BinaryWriter(fsT)
        Catch e As System.IO.FileNotFoundException
            MsgBox("Файл текстов: " & ffsT & " не найден.")
            Exit Sub
        Catch
            Exit Sub
        End Try

    End Sub
    Public Property ReplayFirst() As Integer Implements GfeCore.IDatabases.ReplayFirst
        Get
            Return msgReplayFirst
        End Get
        Set(ByVal value As Integer)
            msgReplayFirst = value
        End Set
    End Property
    Public Property ReplayNext() As Integer Implements GfeCore.IDatabases.ReplayNext
        Get
            Return msgReplayNext
        End Get
        Set(ByVal value As Integer)
            msgReplayNext = value
        End Set
    End Property
    Public Property ReplayNextS() As String Implements GfeCore.IDatabases.ReplayNextS
        Get
            Return ""
        End Get
        Set(ByVal value As String)
            'null for msg
        End Set
    End Property
    Public Property ReplayTo() As Integer Implements GfeCore.IDatabases.ReplayTo
        Get
            Return msgReplayTo
        End Get
        Set(ByVal value As Integer)
            msgReplayTo = value
        End Set
    End Property
    Public Property Subject() As String Implements GfeCore.IDatabases.Subject
        Get
            Return msgSubj
        End Get
        Set(ByVal value As String)
            msgSubj = value
        End Set
    End Property
    Public Property [To]() As String Implements GfeCore.IDatabases.To
        Get
            Return msgTo
        End Get
        Set(ByVal value As String)
            msgTo = value
        End Set
    End Property
    Public Property ToAddr() As String Implements GfeCore.IDatabases.ToAddr
        Get
            Return msgToAddr
        End Get
        Set(ByVal value As String)
            msgToAddr = value
        End Set
    End Property
    Public Function WriteMessage() As Integer Implements GfeCore.IDatabases.WriteMessage

    End Function

    'конструктор "по умолчанию"
    Sub New()
        bolDefault = True
    End Sub

    'Создает экземпляр класса и сразу загружает базу
    Public Sub New(ByVal DbPath As String)
        strDBname = DbPath
        OpenDB()
    End Sub

#Region "Private methods"

    ''' <summary>
    ''' Возвращает порядковый номер записи в файле areas.wwd идентифицирующий заданную область
    ''' </summary>
    ''' <param name="EchoPath">Полный путь к файлу с эхой</param>
    ''' <returns>Порядковый номер</returns>
    ''' <remarks>Вернет -1 если эха не найдена</remarks>
    Private Function GetAreaIdByEchoPath(ByVal EchoPath As String) As Integer
        Dim ech, aaf, ech2 As String
        Dim ff As Integer
        Dim arRec() As AreaRecord

        Try

            aaf = Mid(EchoPath, 1, InStrRev(EchoPath, "\")) & "areas.wwd"
            ech = Replace(Mid(EchoPath, InStrRev(EchoPath, "\") + 1, EchoPath.Length), ".hdr", "", , , CompareMethod.Text)

            ff = FreeFile()
            FileOpen(ff, aaf, OpenMode.Binary)
            ReDim arRec((LOF(ff) / 562) - 1)
            FileGet(ff, arRec) 'читаем все сразу
            FileClose(ff)

            ech2 = ech & Chr(0) & Space(128 - Len(ech) - 1)
            ech = ech & New String(Chr(0), 128 - Len(ech))

            For ff = 0 To UBound(arRec)

                If arRec(ff).FileName = ech Or arRec(ff).FileName = ech2 Then
                    Return ff
                    'strEchoName = arRec(ff).Echotag
                End If

            Next

        Catch
            '
        End Try

        Return -1

    End Function

    ''' <summary>
    ''' Возвращает текущее имя эхи
    ''' </summary>
    ''' <param name="EchoPath"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetEchoNameByEchoPath(ByVal EchoPath As String) As String
        Dim ech, aaf, ech2 As String
        Dim ff As Integer
        Dim arRec() As AreaRecord

        Try

            aaf = Mid(EchoPath, 1, InStrRev(EchoPath, "\")) & "areas.wwd"
            ech = Replace(Mid(EchoPath, InStrRev(EchoPath, "\") + 1, EchoPath.Length), ".hdr", "", , , CompareMethod.Text)

            ff = FreeFile()
            FileOpen(ff, aaf, OpenMode.Binary)
            ReDim arRec((LOF(ff) / 562) - 1)
            FileGet(ff, arRec) 'читаем все сразу
            FileClose(ff)

            ech2 = ech & Chr(0) & Space(128 - Len(ech) - 1)
            ech = ech & New String(Chr(0), 128 - Len(ech))

            For ff = 0 To UBound(arRec)

                If arRec(ff).FileName = ech Or arRec(ff).FileName = ech2 Then
                    Return arRec(ff).Echotag
                End If

            Next

        Catch
            '
        End Try

        Return ""

    End Function

#End Region

#Region "ModuleInfo"
    Public Function GetModuleIcon() As System.Drawing.Image Implements GfeCore.IDatabases.GetModuleIcon
        Return My.Resources.ModuleIcon.ToBitmap
    End Function

    Public ReadOnly Property Description() As String Implements GfeCore.IModuleInfo.Description
        Get
            Return "FIPS Module"
        End Get
    End Property

    Public ReadOnly Property Name() As String Implements GfeCore.IModuleInfo.Name
        Get
            Return "fipsBase"
        End Get
    End Property
#End Region

    Private disposed As Boolean = False

    ' IDisposable
    Private Overloads Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposed Then
            If disposing Then
                Try
                    If Not bolDefault Then
                        wrH.Close()
                        wrT.Close()
                        brH.Close()
                        brT.Close()
                        fsT.Close()
                        fsH.Close()
                    End If
                Catch
                Finally
                    brH = Nothing
                    brT = Nothing
                    wrH = Nothing
                    wrT = Nothing
                    fsH = Nothing
                    fsT = Nothing
                    MyBase.Finalize()
                End Try
            End If

            ' TODO: put code to free unmanaged resources here
        End If
        Me.disposed = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Overloads Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overrides Sub Finalize()
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(False)
        MyBase.Finalize()
    End Sub
#End Region

End Class
