
''' <summary>
''' Интерфейc определяет доступ к различным базам писем
''' </summary>
Public Interface IDatabases
    Inherits IDisposable
    Inherits IDatabasesTypes    
    Inherits IModuleInfo

    ''' <summary>
    ''' Тип базы
    ''' </summary>
    ReadOnly Property BaseType() As IDatabases.enmBaseType

    ''' <summary>
    ''' Отправитель письма
    ''' </summary>
    Property From() As String

    ''' <summary>
    ''' Адрес отправителя
    ''' </summary>
    Property FromAddr() As String

    ''' <summary>
    ''' Получатель письма
    ''' </summary>
    Property [To]() As String

    ''' <summary>
    ''' Адрес получателя письма
    ''' </summary>
    Property ToAddr() As String

    ''' <summary>
    ''' Дата написания письма
    ''' </summary>
    ''' <value>значение в UnixTime</value>
    Property DateWritten() As Integer

    ''' <summary>
    ''' Дата доставки письма.
    ''' </summary>
    ''' <value>значение в UnixTime</value>
    Property DateArrived() As Integer

    ''' <summary>
    ''' Тема Письма
    ''' </summary>
    Property Subject() As String

    ''' <summary>
    ''' Текст письма
    ''' </summary>
    Property MessageText() As String

    ''' <summary>
    ''' Флаги письма
    ''' </summary>
    Property MessageFlags() As Integer

    ''' <summary>
    ''' Возвращает номер сообщения на которое данное является ответом
    ''' </summary>
    Property ReplayTo() As Integer

    ''' <summary>
    ''' Возвращает номер первого сообщения в цепочкие ответов
    ''' </summary>
    Property ReplayFirst() As Integer

    ''' <summary>
    ''' Возвращает номер мессага в следующей цепочке ответов
    ''' </summary>
    Property ReplayNext() As Integer

    ''' <summary>
    ''' Возвращает полную цепочку ответов
    ''' </summary>
    ''' <remarks>Действительно только для SQUISH базы</remarks>
    Property ReplayNextS() As String

    ''' <summary>
    ''' Полный путь и файл базы сообщений
    ''' </summary>
    ''' <value></value>
    ''' <remarks></remarks>
    Property DBName() As String

    ''' <summary>
    ''' Имя открытой эхи 
    ''' </summary>
    Property EchoName() As String

    ''' <summary>
    ''' Число сообщений в эхе
    ''' </summary>
    Property MessageCount() As Integer

    ''' <summary>
    ''' Возвращает число сообщений по имени эхи
    ''' </summary>
    ''' <param name="EchoPath">Полный путь</param>
    ReadOnly Property MessageCountByEcho(ByVal EchoPath As String) As Integer

    ''' <summary>
    ''' Загружает текст сообщения по номеру
    ''' </summary>
    Sub GetMessageByNum(ByVal NumberMessage As Integer)

    ''' <summary>
    ''' Возвращает Дамп сообщения по номеру
    ''' </summary>
    Function GetMessageDumpByNum(ByVal NumberMessage As Integer) As String

    ''' <summary>
    ''' Загружает Заголовки письма по номеру
    ''' </summary>
    Sub GetHeadesByNum(ByVal NumberMessage As Integer)

    ''' <summary>
    ''' Загружает Заголовки письма по номеру
    ''' </summary>
    ''' <remarks>Исспользуется при построении дерева</remarks>
    Sub GetHeadesByNumForTree(ByVal NumberMessage As Integer)

    ''' <summary>
    ''' Загружает все возможные заголовки письма
    ''' </summary>
    ''' <remarks>Очень медленный метод</remarks>
    Sub GetHeadesByNumAll(ByVal NumberMessage As Integer)

    ''' <summary>
    ''' Возвращает номер последнего прочитанного мессага
    ''' </summary>
    ''' <param name="msgNumber">Если не 0 то записывает информацию</param>
    Function GetLastReadMsgNum(Optional ByVal msgNumber As Integer = 0) As Integer

    ''' <summary>
    ''' Возвращает письмо с кладжами.
    ''' </summary>
    ''' <param name="NumberMessage"></param>
    Function GetMessageKlugeByNum(ByVal NumberMessage As Integer) As String

    ''' <summary>
    ''' Открывает базу сообщений
    ''' </summary>
    Sub OpenDB()

    ''' <summary>
    ''' Сохраняет сообщение в базу
    ''' </summary>
    Function WriteMessage() As Integer

    ''' <summary>
    ''' Удаляет сообщение из базы
    ''' </summary>
    Sub DeleteMessageByNum(ByVal NumberMessage As Integer)

    ''' <summary>
    ''' Устанавливает статус сообщения в нутры базы
    ''' </summary>
    ''' <param name="Status">при значении -1 возвращает статус текущего мессага</param>
    ''' <remarks>Работает не со всеми тоссерами</remarks>
    Function MessageStatus(ByVal NumberMessage As Integer, Optional ByVal Status As Integer = -1) As Integer

End Interface

