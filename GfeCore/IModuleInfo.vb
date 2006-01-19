
''' <summary>
''' Интерфейс Информации о Модуле
''' </summary>
Public Interface IModuleInfo

    ''' <summary>
    ''' Ворвращает иконку ассоциированную с модулем
    ''' </summary>
    Function GetModuleIcon() As System.Drawing.Image
    ''' <summary>
    ''' Возвращает описание модуля
    ''' </summary>
    ReadOnly Property Description() As String
    ''' <summary>
    ''' Возвращает Имя модуля
    ''' </summary>
    ReadOnly Property Name() As String

End Interface
