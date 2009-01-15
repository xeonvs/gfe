''' <summary>
''' Модуль для доступа к глобальным настройкам ГФЕ
''' </summary> 
Public Module modSettings

    ''' <summary>
    ''' Полный пусть запуска ГФЕ
    ''' </summary>    
    Public AppRun As String = My.Application.Info.DirectoryPath

    ''' <summary>
    ''' Разделитель в путях к файлам
    ''' </summary>
    ''' <remarks>Платформо-зависим</remarks>
    Public PatchSeparator As String = System.IO.Path.DirectorySeparatorChar

    ''' <summary>
    ''' True если запуск кода произошел под mono
    ''' </summary>
    ''' <remarks></remarks>
    Public IsMonoRun As Boolean = False

    ''' <summary>
    ''' True если запуск кода произошел на платформе Unix
    ''' </summary>
    ''' <remarks></remarks>
    Public IsUnixRun As Boolean = False

    ''' <summary>
    ''' Полный пусть к каталогу с дополнительными модулями
    ''' </summary>
    Public ModulesPath As String = AppRun

    ''' <summary>
    ''' Полный путь к каталогу со смайликами
    ''' </summary>
    Public SmilesPath As String = AppRun & PatchSeparator & "smilez"

    ''' <summary>
    ''' Информационная строка приложения
    ''' </summary>
    ''' <remarks>Содержит версию и тип операционной системы.</remarks>
    Public sAppInfoString As String

    ''' <summary>
    ''' Перекодировать описания эх
    ''' </summary>
    ''' <remarks></remarks>
    Public bRecodeDesc As Boolean = True

#Region "Functions"
    ''' <summary>
    ''' Возвращает опцию из реестра
    ''' </summary>
    ''' <param name="OptionPath">Путь к нужному ключу</param>
    ''' <param name="OptionName">Имя ключа</param>
    ''' <param name="DefaultValue">Значение по умолчинию</param>
    ''' <returns>Значение параметра в строке</returns>
    ''' <remarks>пока только из реестра</remarks>
    Public Function GetGFEOption(ByVal OptionPath As String, _
                                 ByVal OptionName As String, _
                                   Optional ByVal DefaultValue As String = "") As String
        'Note: данный код является workaraund, т.к. DefaultValue не возвращается в класссе
        Dim ret As Object = My.Computer.Registry.GetValue _
                ("HKEY_CURRENT_USER\SOFTWARE\GFE\" & OptionPath, OptionName, DefaultValue)
        If IsNothing(ret) Then
            Return DefaultValue
        Else
            Return CStr(ret)
        End If
    End Function

    ''' <summary>
    ''' Сохраняет опцию в реестр
    ''' </summary>
    ''' <param name="OptionPath">Путь к нужному ключу</param>
    ''' <param name="OptionName">Имя ключа</param>
    ''' <remarks>пока только из реестра</remarks>
    Public Sub PutGFEOption(ByVal OptionPath As String, _
                            ByVal OptionName As String, _
                            ByVal Value As String)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\GFE\" & OptionPath, OptionName, Value)
    End Sub
#End Region

End Module
