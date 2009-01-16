Public Class frmOptions

    Dim WithEvents opt As RadioButton
    Dim tid As Integer

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        PutGFEOption("Options", "cfgMsgBase", (txtBasePath.Text))
        PutGFEOption("Options", "TosserId", tid)
    End Sub

    Private Sub cmdOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpen.Click
        Dim dlg As New OpenFileDialog

        dlg.Filter = "All Files (*.*)|*.*|Config Files(*.cfg)|*.cfg|Areas Files(*.bbs)|*.bbs|Configure Files(*.conf)|*.conf|Ini Files(*.ini)|*.ini"
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtBasePath.Text = dlg.FileName
            tid = clsEchos.TosserHeuristicAnalyzer(txtBasePath.Text)
            Try
                CType(Me.Controls.Find("OptTid" & tid, True)(0), RadioButton).Checked = True
            Catch
                '
            End Try
        End If
    End Sub

    Private Sub frmOptions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dy As Integer = 19
        For i As Integer = 1 To clsEchos.TosserCount
            opt = New RadioButton
            opt.Name = "OptTid" & i
            opt.Text = clsEchos.TosserName(i)
            opt.Location = New System.Drawing.Point(6, dy)
            opt.Size = New System.Drawing.Size(150, 23)
            opt.Tag = i
            AddHandler opt.CheckedChanged, AddressOf opt_CheckedChanged
            grpTossers.Controls.Add(opt)
            dy += 19
        Next

        tid = GetGFEOption("Options", "TosserId", "0")
        Try
            CType(Me.Controls.Find("OptTid" & tid, True)(0), RadioButton).Checked = True
        Catch
            '
        End Try
    End Sub

    Private Sub opt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rb As RadioButton = CType(sender, RadioButton)
        tid = rb.Tag
    End Sub
End Class