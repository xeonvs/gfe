'Copyright M. Irgiznov 2006-2009
Public Module Utils
    Public Sub Initialize()
        Dim t As Type, p As Integer, tmpVer As String

        t = Type.GetType("Mono.Runtime")
        If IsNothing(t) Then
            'Console.WriteLine("No mono!")
            IsMonoRun = False
        Else
            'Console.WriteLine("Mono!")
            IsMonoRun = True
        End If

        tmpVer = System.Reflection.Assembly.GetExecutingAssembly().FullName
        tmpVer = Mid$(tmpVer, InStr(tmpVer, "Version=") + 8, InStr(InStr(tmpVer, "Version="), tmpVer, ",") - (InStr(tmpVer, "Version=") + 8))

        p = Environment.OSVersion.Platform
        If (p = 4 Or p = 128) Then
            sAppInfoString = "GFE.NET for Unix v" & tmpVer
            IsUnixRun = True
        Else
            sAppInfoString = "GFE.NET for windows v" & tmpVer
            IsUnixRun = False
        End If
    End Sub

    ''' <summary>
    ''' Запуск Shell-команды
    ''' </summary>
    ''' <param name="ComLine">Командная строка</param>
    ''' <param name="DefaultDir">Рабочий каталог</param>
    ''' <param name="ShowFlag">Флаг видимости дочернего окна</param>
    ''' <returns>Возвращает True в случае успеха и False в случае неудачи</returns>
    ''' <remarks>Время ожидания ответа комманды 600000мсек</remarks>
    Public Function CmdShell(ByRef ComLine As String, ByRef DefaultDir As String, ByRef ShowFlag As AppWinStyle) As Boolean
        Dim proc As New Diagnostics.Process
        Try
            proc.StartInfo.FileName = ComLine
            proc.StartInfo.WorkingDirectory = DefaultDir
            proc.StartInfo.WindowStyle = ShowFlag
            proc.Start()
            proc.WaitForExit(600000)
            Return True
        Catch
            Return False
        End Try
    End Function

End Module
