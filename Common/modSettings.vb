
''' <summary>
''' Модуль для доступа к глобальным настройкам ГФЕ
''' </summary> 
Module modSettings

    ''' <summary>
    ''' Полный пусть запуска ГФЕ
    ''' </summary>    
    Public AppRun As String = Application.StartupPath
    ''' <summary>
    ''' Полный пусть к каталогу с дополнительными модулями
    ''' </summary>
    Public ModulesPath As String = AppRun
    ''' <summary>
    ''' Полный путь к каталогу со смайликами
    ''' </summary>
    Public SmilesPath As String = AppRun & "\smilez"

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
        'Registry.SaveString(HKEY_CURRENT_USER, "SOFTWARE\GFE\" & OptionPath, OptionName, Value)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\GFE\" & OptionPath, OptionName, Value)
    End Sub

End Module
