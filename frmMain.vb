Option Explicit On

''' <summary>
''' Главная форма
''' </summary>
Public Class frmMain    

    Dim curEcho As IDatabases
    Dim ItemSelection As ListViewItemSelectionChangedEventArgs
    Dim ItemSelectionRange As ListViewVirtualItemsSelectionRangeChangedEventArgs

    Dim msgModeratorColor, msgRulesColor, msgMainTextColor As Integer
    Dim msgBackColor, msgAlienCitatColor, msgMyCitatColor As Integer
    Dim msgTaglineColor, msgTirlineColor, msgMyMessagesColor As Integer
    Dim msgOriginColor As Integer
    

    Private Sub ReadSettings()
        
        msgModeratorColor = CInt(GetGFEOption("Options", "msgModeratorColor", CStr(&HFF00)))
        msgRulesColor = CInt(GetGFEOption("Options", "msgRulesColor", CStr(&H40FF00)))
        msgAlienCitatColor = CInt(GetGFEOption("Options", "AlienCitatColor", CStr(&HFFFF)))
        msgMainTextColor = CInt(GetGFEOption("Options", "MainTextColor", CStr(&HC0C0C0)))
        msgBackColor = CInt(GetGFEOption("Options", "BackMessageColor", CStr(0)))
        msgMyCitatColor = CInt(GetGFEOption("Options", "MyCitatColor", CStr(&HFFFFFF)))
        msgMyMessagesColor = CInt(GetGFEOption("Options", "MyMessagesColor", CStr(&H80000002)))
        msgTaglineColor = CInt(GetGFEOption("Options", "TaglineColor", CStr(&HFFFFFF)))
        msgTirlineColor = CInt(GetGFEOption("Options", "TirlineColor", CStr(&HFFS)))
        msgOriginColor = CInt(GetGFEOption("Options", "OriginColor", CStr(&HFFFFFF)))

        Me.Left = CInt(GetGFEOption("Screen\Main", "X", "0")) / 15
        Me.Top = CInt(GetGFEOption("Screen\Main", "Y", "0")) / 15

        If Me.WindowState <> FormWindowState.Maximized Then
            Me.Width = CInt(GetGFEOption("Screen\Main", "Width", CStr(Me.Width * 15))) / 15
            Me.Height = CInt(GetGFEOption("Screen\Main", "Height", CStr(Me.Height * 15))) / 15
            Select Case CInt(GetGFEOption("Screen\Main", "WindowState", Me.WindowState))
                Case FormWindowState.Minimized
                    Me.WindowState = FormWindowState.Minimized

                Case FormWindowState.Maximized
                    Me.WindowState = FormWindowState.Maximized

                Case Else
                    Me.WindowState = FormWindowState.Normal

            End Select
        End If

        If Me.Left = 0 And Me.Top = 0 Then
            Me.StartPosition = FormStartPosition.CenterScreen
        End If

        'тулбары
        GFEToolStrip.Top = CInt(GetGFEOption("Screen\Main", "GFEToolStrip_Top", "24"))
        GFEToolStrip.Left = CInt(GetGFEOption("Screen\Main", "GFEToolStrip_Left", "160"))
        ToolStripMain.Top = CInt(GetGFEOption("Screen\Main", "ToolStripMain_Top", "24"))
        ToolStripMain.Left = CInt(GetGFEOption("Screen\Main", "ToolStripMain_Left", "0"))
        MainMenu.Top = CInt(GetGFEOption("Screen\Main", "MainMenu_Top", "0"))
        MainMenu.Left = CInt(GetGFEOption("Screen\Main", "MainMenu_Left", "0"))

        'сплитеры
        SplitContainer1.SplitterDistance = CInt(GetGFEOption("Screen\Main", "SplitContainer1", "210"))
        SplitContainer2.SplitterDistance = CInt(GetGFEOption("Screen\Main", "SplitContainer2", "165"))

        'списки писем и эх
        For i As Integer = 0 To MailList.Columns.Count - 1
            MailList.Columns.Item(i).Width = CInt(GetGFEOption("Screen\Main", "MailListColumns" + i.ToString, "60"))
        Next
        For i As Integer = 0 To EchoList.Columns.Count - 1
            EchoList.Columns.Item(i).Width = CInt(GetGFEOption("Screen\Main", "EchoListColumns" + i.ToString, "60"))
        Next

        Application.DoEvents()

    End Sub

    Public Sub LoadEchoList()
        Static fl As Boolean
        Dim LI As ListViewItem
        Dim ECNum, netmC, sumnew, sum, optC As Integer
        Dim nmSel As Boolean
        Dim lrEcho As String
        Dim cdb As IDatabases

        Dim Path As String = GetGFEOption("Options", "cfgMsgBase", "")

        If Path Is Nothing Then
            Exit Sub
        ElseIf Path.Length = 0 Then
            Exit Sub
        End If

        If Not fl Then

            clsEchos.ConfigFile = Path
            clsEchos.ParseConfig()

            EchoList.Items.Clear()
            Application.DoEvents()

            lrEcho = GetGFEOption("LastRead", "Echo", "Netmail")
            nmSel = True

            'если неймей должен быть на верху:
            If LCase(GetGFEOption("Options", "NetmailPosition", "Bottom")) = "top" Then
                netmC = 0
                While Len(GetGFEOption("Options", "Netmail Dir" & netmC)) <> 0
                    cdb = Activator.CreateInstance(Bases.Item(IDatabases.enmBaseType.Fido))
                    LI = New ListViewItem(GetGFEOption("Options", "Netmail Name" & netmC, "Netmail" & netmC), 0)
                    LI.Tag = GetGFEOption("Options", "Netmail Dir" & netmC, "C:\T-Mail\Mail")
                    LI.SubItems.Add(CStr(cdb.MessageCountByEcho((LI.Tag))))
                    LI.SubItems.Add("Netmail Area")
                    LI.ToolTipText = "Netmail Area"
                    LI.SubItems.Add(GetGFEOption("Options", "MainAddress"))
                    LI.SubItems.Add("1").Name = "ecType"

                    sum = sum + CDbl(LI.SubItems(1).Text)
                    netmC = netmC + 1

                    'проверяем есть ли новые письма и если есть выделяем их жирным шрифтом
                    optC = CInt(GetGFEOption("LastRead\Echos", (LI.Text), LI.SubItems(1).Text))

                    If optC < CDbl(LI.SubItems(1).Text) Then
                        'добавились                    
                        LI.Font = New Font(LI.Font, LI.Font.Style Or FontStyle.Bold)
                        sumnew = sumnew + (CDbl(LI.SubItems(1).Text) - optC)
                    Else
                        'удалились
                    End If

                    EchoList.Items.Add(LI)
                    PutGFEOption("LastRead\Echos", (LI.Text), LI.SubItems(1).Text)

                    If nmSel Then
                        LI.Selected = True
                        LI.EnsureVisible()
                    End If

                End While

            End If

            Application.DoEvents()

            ToolStripProgressBar.Minimum = 1
            ToolStripProgressBar.Maximum = clsEchos.EchosCount


            For ECNum = 1 To clsEchos.EchosCount

                If Not (clsEchos Is Nothing) Then

                    LI = New ListViewItem(clsEchos.GetEchoNameByNum(ECNum), 0)
                    frmStart.RefreshEchoName = clsEchos.GetEchoNameByNum(ECNum)

                    'подключаем базу требуемого типа и получаем список мессаг
                    Try
                        cdb = Activator.CreateInstance(Bases.Item(clsEchos.GetEchoTypeByNum(ECNum)))
                    Catch ex As KeyNotFoundException
                        MsgBox("Выбранный тип (" & clsEchos.GetEchoTypeByNum(ECNum).ToString & ") базы не поддерживается или ошибка загрузки модуля базы.", MsgBoxStyle.Critical)
                        Exit For
                    End Try

                    LI.SubItems.Add(CStr(cdb.MessageCountByEcho(clsEchos.GetEchoFileByNum(ECNum))))
                    LI.SubItems.Add(clsEchos.GetEchoDescriptionByNum(ECNum))
                    LI.SubItems.Add(clsEchos.GetEchoAkAByNum(ECNum))
                    LI.SubItems.Add(clsEchos.GetEchoTypeByNum(ECNum)).Name = "ecType"
                    LI.ToolTipText = clsEchos.GetEchoDescriptionByNum(ECNum)

                    'проверяем есть ли новые письма и если есть выделяем их жирным шрифтом
                    optC = CInt(GetGFEOption("LastRead\Echos", (LI.Text), LI.SubItems(1).Text))

                    If optC < CDbl(LI.SubItems(1).Text) Then
                        'добавились письма
                        LI.Font = New Font(LI.Font, LI.Font.Style Or FontStyle.Bold)
                        sumnew = sumnew + (CDbl(LI.SubItems(1).Text) - optC)
                    Else
                        'письма удалились
                    End If

                    EchoList.Items.Add(LI)

                    PutGFEOption("LastRead\Echos", (LI.Text), LI.SubItems(1).Text)

                    Application.DoEvents()

                    If Not (clsEchos Is Nothing) Then
                        If lrEcho = clsEchos.GetEchoNameByNum(ECNum) Then
                            LI.Selected = True
                            LI.EnsureVisible()
                            nmSel = False
                        End If

                        sum = sum + CDbl(LI.SubItems(1).Text)
                        ToolStripProgressBar.Value = ECNum

                    End If

                Else
                    Exit Sub
                End If

            Next

            'или посденей эхой
            If LCase(GetGFEOption("Options", "NetmailPosition", "Bottom")) = "bottom" Then
                netmC = 0
                While Len(GetGFEOption("Options", "Netmail Dir" & netmC)) <> 0
                    cdb = Activator.CreateInstance(Bases.Item(IDatabases.enmBaseType.Fido))
                    LI = New ListViewItem(GetGFEOption("Options", "Netmail Name" & netmC, "Netmail" & netmC), 0)
                    LI.Tag = GetGFEOption("Options", "Netmail Dir" & netmC, "C:\T-Mail\Mail")
                    LI.SubItems.Add(CStr(cdb.MessageCountByEcho((LI.Tag))))
                    LI.SubItems.Add("Netmail Area")
                    LI.ToolTipText = "Netmail Area"
                    LI.SubItems.Add(GetGFEOption("Options", "MainAddress"))
                    LI.SubItems.Add("1").Name = "ecType"

                    sum = sum + CDbl(LI.SubItems(1).Text)

                    netmC = netmC + 1

                    'проверяем есть ли новые письма и если есть выделяем их жирным шрифтом
                    optC = CInt(GetGFEOption("LastRead\Echos", (LI.Text), LI.SubItems(1).Text))

                    If optC < CDbl(LI.SubItems(1).Text) Then
                        'добавились
                        LI.Font = New Font(LI.Font, LI.Font.Style Or FontStyle.Bold)
                        sumnew = sumnew + (CDbl(LI.SubItems(1).Text) - optC)
                    Else
                        'удалились
                    End If

                    EchoList.Items.Add(LI)
                    PutGFEOption("LastRead\Echos", (LI.Text), LI.SubItems(1).Text)

                    If nmSel Then
                        LI.Selected = True
                        LI.EnsureVisible()
                    End If
                End While
            End If

            frmStart.RefreshEchoName = "Netmail"

            ToolStripStatusLabelEchos.Text = "Новых " & CStr(sumnew) & ", всего " & CStr(sum) & " писем в " & CStr(clsEchos.EchosCount + 1) & " эхах"

            Application.DoEvents()
            Try
                If Not cdb Is Nothing Then
                    cdb.Dispose()
                    cdb = Nothing
                End If
            Catch
                '
            End Try

            LI = Nothing
            fl = True

        End If

    End Sub

    Private Sub exitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Application.DoEvents()

        PutGFEOption("Screen\Main", "WindowState", CStr(Me.WindowState))

        If Me.WindowState = vbNormal Then
            PutGFEOption("Screen\Main", "X", Str(Me.Left * 15))
            PutGFEOption("Screen\Main", "Y", Str(Me.Top * 15))            
        End If

        PutGFEOption("Screen\Main", "Width", Str(Me.Width * 15))
        PutGFEOption("Screen\Main", "Height", Str(Me.Height * 15))

        'тулбары
        PutGFEOption("Screen\Main", "GFEToolStrip_Top", GFEToolStrip.Top)
        PutGFEOption("Screen\Main", "GFEToolStrip_Left", GFEToolStrip.Left)
        PutGFEOption("Screen\Main", "ToolStripMain_Top", ToolStripMain.Top)
        PutGFEOption("Screen\Main", "ToolStripMain_Left", ToolStripMain.Left)
        PutGFEOption("Screen\Main", "MainMenu_Top", MainMenu.Top)
        PutGFEOption("Screen\Main", "MainMenu_Left", MainMenu.Left)

        'сплитеры
        PutGFEOption("Screen\Main", "SplitContainer1", SplitContainer1.SplitterDistance)
        PutGFEOption("Screen\Main", "SplitContainer2", SplitContainer2.SplitterDistance)

        'Колонки списка писем
        For i As Integer = 0 To MailList.Columns.Count - 1
            PutGFEOption("Screen\Main", "MailListColumns" + i.ToString, MailList.Columns.Item(i).Width)
        Next

        'Колонки списка эх
        For i As Integer = 0 To EchoList.Columns.Count - 1
            PutGFEOption("Screen\Main", "EchoListColumns" + i.ToString, EchoList.Columns.Item(i).Width)
        Next
        
        Me.Hide()
        If EchoList.SelectedItems.Count <> 0 Then
            PutGFEOption("LastRead", "Echo", EchoList.SelectedItems.Item(0).Text)
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Visible = False
        Me.Text = "GoldFidoExplorer " & My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor.ToString & " build " & CStr(My.Application.Info.Version.Revision)
        ToolStripStatusLabelEchos.Text = "Новых 0, всего 0 писем в 0 эхах"        
        
        ReadSettings() 'читаем настройки

        modCommon.LoadDatabaseModules()
        modCommon.CreateSmilesDataset()

#If Not Debug Then
        frmStart.Show() 'заставочка
#End If
        Me.Show()

        EchoList.BeginUpdate()
        LoadEchoList() 'читаем список эх
        EchoList.EndUpdate()    

    End Sub
    
    Private Sub MailList_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles MailList.ItemSelectionChanged        
        DisplayMessage(e.ItemIndex + 1)
        ItemSelection = e
    End Sub
    
    Private Sub MailList_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MailList.MouseDoubleClick
        Dim frmMlEd As New frmMailEditor

        frmMlEd.CurrentEcho = curEcho
        frmMlEd.Tag = EchoList.SelectedItems.Item(0).Text
        frmMlEd.EditorMode = ReplayMode.ViewMails

        If frmMlEd.CurrentEcho.BaseType = IDatabasesTypes.enmBaseType.Fido Then
            frmMlEd.CurrentEcho.DBName = EchoList.SelectedItems.Item(0).Tag
        Else
            frmMlEd.CurrentEcho.DBName = clsEchos.GetEchoFileByNum(clsEchos.GetEchoNumByName(EchoList.SelectedItems.Item(0).Text))
        End If

        frmMlEd.CurrentMessageNumber = ItemSelection.ItemIndex + 1
        Try
            frmMlEd.Show()
        Catch
            '
        End Try
    End Sub

    Private Sub MailList_RetrieveVirtualItem(ByVal sender As Object, ByVal e As System.Windows.Forms.RetrieveVirtualItemEventArgs) Handles MailList.RetrieveVirtualItem
        'перед отображением необходимо установить общее число через VirtualListSize
        'тут подгружаются итемы.        
        Dim cNum As Integer = e.ItemIndex + 1
        curEcho.GetHeadesByNum(cNum)

        e.Item = New ListViewItem(cNum.ToString & ": " & curEcho.Subject)
        e.Item.Name = "Subj" + cNum.ToString
        e.Item.SubItems.Add(curEcho.From).Name = "From" + cNum.ToString
        e.Item.SubItems.Add(curEcho.To).Name = "To" + cNum.ToString
        e.Item.SubItems.Add(CStr(DateAdd("s", curEcho.DateWritten, #1/1/1970#)))
        e.Item.SubItems.Add(CStr(DateAdd("s", curEcho.DateArrived, #1/1/1970#)))

    End Sub

    Private Sub MailList_SearchForVirtualItem(ByVal sender As Object, ByVal e As System.Windows.Forms.SearchForVirtualItemEventArgs) Handles MailList.SearchForVirtualItem
        Debug.Print("MailList_SearchForVirtualItem")
    End Sub

    Private Sub MailList_VirtualItemsSelectionRangeChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewVirtualItemsSelectionRangeChangedEventArgs) Handles MailList.VirtualItemsSelectionRangeChanged
        ItemSelectionRange = e
    End Sub

    Private Sub GFEToolStripButtonNewMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GFEToolStripButtonNewMessage.Click
        Dim flg As Boolean = False, frm As Form

        ' А нужен ли тут код проверки на одновременное написание нескольких писем в одну эху?
        ' технически проблем с написанием не должно быть, если в методе сохранения письма обновлять информацию о эхе.
        For Each frm In Application.OpenForms
            If frm.Tag = EchoList.SelectedItems.Item(0).Text Then
                flg = True
                Exit For
            End If
        Next

        If Not flg Then
            Dim frmMlEd As New frmMailEditor

            frmMlEd.CurrentEcho = GetEchoInterface(EchoList.SelectedItems.Item(0).Text) 'Создание дефолтного класса
            frmMlEd.Tag = EchoList.SelectedItems.Item(0).Text
            frmMlEd.EditorMode = ReplayMode.NewMail

            If frmMlEd.CurrentEcho.BaseType = IDatabasesTypes.enmBaseType.Fido Then
                frmMlEd.CurrentEcho.DBName = EchoList.SelectedItems.Item(0).Tag
            Else
                frmMlEd.CurrentEcho.DBName = clsEchos.GetEchoFileByNum(clsEchos.GetEchoNumByName(EchoList.SelectedItems.Item(0).Text))
            End If
            frmMlEd.CurrentMessageNumber = frmMlEd.CurrentEcho.MessageCount + 1
            Try
                frmMlEd.Show()
            Catch
                '
            End Try
        Else
            frm.Activate()
        End If

    End Sub

    Private Sub aboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutToolStripMenuItem.Click
        frmStart.Show() 'заставочка        
    End Sub

    Private Sub optionsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optionsToolStripMenuItem.Click
        MessageBox.Show("Не реализовано!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub DisplayMessage_rtf(ByVal MessageNumber As Integer)
        'MailViewer.Clear()

        curEcho.GetHeadesByNum(MessageNumber)
        curEcho.GetMessageByNum(MessageNumber)

        lblFrom.Text = "От кого: " & curEcho.From
        lblFromAddr.Text = curEcho.FromAddr '& " (" & addr2city(msg.FromAddr) & ")"
        lblTo.Text = "Кому: " & curEcho.To

        If curEcho.Subject.Length > 0 Then
            MailHead.Text = curEcho.Subject & " [ " & MessageNumber & " из " & curEcho.MessageCount & " ] " & CStr(DateAdd("s", curEcho.DateWritten, #1/1/1970#))
        Else
            MailHead.Text = "Письмо без названия [ " & MessageNumber & " из " & curEcho.MessageCount & " ] " & CStr(DateAdd("s", curEcho.DateWritten, #1/1/1970#))
        End If

        If curEcho.MessageText.Length <> 0 Then
            'MailViewer.ReadOnly = False
            'MailViewer.Text = curEcho.MessageText
            'modCommon.ReplaceSmiles(Me.MailViewer)
            'MailViewer.ReadOnly = True
        End If

    End Sub

    Private Sub DisplayMessage(ByVal MessageNumber As Integer)
        curEcho.GetHeadesByNum(MessageNumber)
        curEcho.GetMessageByNum(MessageNumber)

        lblFrom.Text = "От кого: " & curEcho.From
        lblFromAddr.Text = curEcho.FromAddr '& " (" & addr2city(msg.FromAddr) & ")"
        lblTo.Text = "Кому: " & curEcho.To

        If curEcho.Subject.Length > 0 Then
            MailHead.Text = curEcho.Subject & " [ " & MessageNumber & " из " & curEcho.MessageCount & " ] " & CStr(DateAdd("s", curEcho.DateWritten, #1/1/1970#))
        Else
            MailHead.Text = "Письмо без названия [ " & MessageNumber & " из " & curEcho.MessageCount & " ] " & CStr(DateAdd("s", curEcho.DateWritten, #1/1/1970#))
        End If

        If curEcho.MessageText.Length <> 0 Then
            'Note: В свойствах URL WebBrowser прописано about:blank
            Dim myHtml As HtmlDocument = HtmlMailViewer.Document
            Dim htm As String

            myHtml.Body.Style = "border-style: none; " & _
                                "margin: 2px; " & _
                                "background-color: " & Win32ColorToHtml(msgBackColor) & "; " & _
                                "color: " & Win32ColorToHtml(msgMainTextColor)
            
            htm = "<font size=""2"" color=""" & Win32ColorToHtml(msgMainTextColor) & """>" & curEcho.MessageText & "</font>"
            htm = htm.Replace(vbCr, "<br>" & vbCrLf)

            'заполняем текстом
            modCommon.ReplaceSmiles(htm)
            myHtml.Body.InnerHtml = htm
        End If

    End Sub

    ''' <summary>
    ''' Проверяет выделен ли диапазон сообщений
    ''' </summary>
    ''' <returns>Возвращает TRUE если выделен диапазон</returns>
    Private Function IsSelectedRange() As Boolean        
        If MailList.SelectedIndices.Count <> 1 Then
            If Not ItemSelectionRange Is Nothing Then
                Return True
            End If
        Else
            If Not ItemSelection Is Nothing Then
                Return False
            End If
        End If
    End Function

    Private Sub EchoList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles EchoList.DoubleClick
        Dim lr As Integer

        Try
            If Not curEcho Is Nothing Then
                curEcho.Dispose()
                curEcho = Nothing
            End If
            GC.Collect()
        Catch
            '?
        End Try

        'Загрузка начинается только при отрисовке списка.
        MailList.VirtualListSize = 0
        MailList.VirtualMode = True        

        curEcho = GetEchoInterface(EchoList.SelectedItems.Item(0).Text)
        ' проверка на Netmail
        If curEcho.BaseType = IDatabasesTypes.enmBaseType.Fido Then
            curEcho.DBName = EchoList.SelectedItems.Item(0).Tag
            MailList.VirtualListSize = curEcho.MessageCountByEcho(EchoList.SelectedItems.Item(0).Tag)

        Else
            Dim ecNum As Integer = clsEchos.GetEchoNumByName(EchoList.SelectedItems.Item(0).Text)
            curEcho.DBName = clsEchos.GetEchoFileByNum(ecNum)
            MailList.VirtualListSize = curEcho.MessageCountByEcho(clsEchos.GetEchoFileByNum(ecNum))

        End If

        curEcho.OpenDB()

        lr = curEcho.GetLastReadMsgNum() - 1
        If lr < 0 Then
            lr = 0
        End If
        
        If MailList.VirtualListSize <> 0 Then
            MailList.Items(lr).Selected = True
            MailList.Items(lr).EnsureVisible()
            DisplayMessage(lr + 1)
            MailList.Focus()
        Else
            MailList.Items.Clear()
            MailHead.Text = "Писем нет"
        End If

    End Sub

    Private Function GetEchoInterface(ByVal EchoName As String) As IDatabases
        Dim ecNum As Integer = clsEchos.GetEchoNumByName(EchoName)

        ' проверка на Netmail
        If ecNum = -1 Then
            Return Activator.CreateInstance(Bases.Item(IDatabasesTypes.enmBaseType.Fido))
        Else
            Return Activator.CreateInstance(Bases.Item(clsEchos.GetEchoTypeByNum(ecNum)))
        End If

    End Function

    Private Sub EchoList_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EchoList.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter
                EchoList_DoubleClick(sender, System.EventArgs.Empty)

            Case Keys.Escape
                MailList.VirtualListSize = 0
                MailList.Refresh()                
                MailList.VirtualMode = False

        End Select

    End Sub

    Private Sub ToolStripMenuItemKluges_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemKluges.Click
        ToolStripMenuItemKluges.Checked = Not ToolStripMenuItemKluges.Checked
    End Sub

    Private Sub ToolStripMenuItemDump_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripMenuItemDump.Click
        ToolStripMenuItemDump.Checked = Not ToolStripMenuItemDump.Checked
        If ToolStripMenuItemKluges.Checked Then
            ToolStripMenuItemKluges.Checked = False
        End If
    End Sub

End Class