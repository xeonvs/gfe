<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMailEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMailEditor))
        Me.ToolStripContainer = New System.Windows.Forms.ToolStripContainer
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBoxFlags = New System.Windows.Forms.GroupBox
        Me.cmdOrgin = New System.Windows.Forms.Button
        Me.cboFromAddr = New System.Windows.Forms.ComboBox
        Me.txtSubj = New System.Windows.Forms.TextBox
        Me.txtTo = New System.Windows.Forms.TextBox
        Me.txtFrom = New System.Windows.Forms.TextBox
        Me.lblSubj = New System.Windows.Forms.Label
        Me.lblTo = New System.Windows.Forms.Label
        Me.lblFrom = New System.Windows.Forms.Label
        Me.rtfMessage = New System.Windows.Forms.RichTextBox
        Me.ToolStripSmiles = New System.Windows.Forms.ToolStrip
        Me.MainMenu = New System.Windows.Forms.MenuStrip
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.saveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.printToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.printPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.editToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.undoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.redoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.pasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.selectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripStandart = New System.Windows.Forms.ToolStrip
        Me.newToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.saveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.printToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.cutToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.copyToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.pasteToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolTipMailEditor = New System.Windows.Forms.ToolTip(Me.components)
        Me.cboToAddr = New System.Windows.Forms.ComboBox
        Me.ToolStripContainer.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.ContentPanel.SuspendLayout()
        Me.ToolStripContainer.RightToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.ToolStripStandart.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer
        '
        '
        'ToolStripContainer.BottomToolStripPanel
        '
        Me.ToolStripContainer.BottomToolStripPanel.Controls.Add(Me.StatusStrip)
        '
        'ToolStripContainer.ContentPanel
        '
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.Panel1)
        Me.ToolStripContainer.ContentPanel.Controls.Add(Me.rtfMessage)
        Me.ToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer.Name = "ToolStripContainer"
        '
        'ToolStripContainer.RightToolStripPanel
        '
        Me.ToolStripContainer.RightToolStripPanel.Controls.Add(Me.ToolStripSmiles)
        Me.ToolStripContainer.RightToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStripContainer.Size = New System.Drawing.Size(616, 432)
        Me.ToolStripContainer.TabIndex = 0
        Me.ToolStripContainer.Text = "ToolStripContainer1"
        '
        'ToolStripContainer.TopToolStripPanel
        '
        Me.ToolStripContainer.TopToolStripPanel.Controls.Add(Me.MainMenu)
        Me.ToolStripContainer.TopToolStripPanel.Controls.Add(Me.ToolStripStandart)
        '
        'StatusStrip
        '
        Me.StatusStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.StatusStrip.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip.Size = New System.Drawing.Size(616, 23)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel1.Controls.Add(Me.GroupBoxFlags)
        Me.Panel1.Controls.Add(Me.cmdOrgin)
        Me.Panel1.Controls.Add(Me.cboToAddr)
        Me.Panel1.Controls.Add(Me.cboFromAddr)
        Me.Panel1.Controls.Add(Me.txtSubj)
        Me.Panel1.Controls.Add(Me.txtTo)
        Me.Panel1.Controls.Add(Me.txtFrom)
        Me.Panel1.Controls.Add(Me.lblSubj)
        Me.Panel1.Controls.Add(Me.lblTo)
        Me.Panel1.Controls.Add(Me.lblFrom)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 128)
        Me.Panel1.TabIndex = 1
        '
        'GroupBoxFlags
        '
        Me.GroupBoxFlags.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBoxFlags.Location = New System.Drawing.Point(85, 80)
        Me.GroupBoxFlags.Name = "GroupBoxFlags"
        Me.GroupBoxFlags.Size = New System.Drawing.Size(336, 40)
        Me.GroupBoxFlags.TabIndex = 9
        Me.GroupBoxFlags.TabStop = False
        Me.GroupBoxFlags.Text = "Флаги"
        '
        'cmdOrgin
        '
        Me.cmdOrgin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOrgin.FlatAppearance.BorderSize = 0
        Me.cmdOrgin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOrgin.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdOrgin.Location = New System.Drawing.Point(473, 96)
        Me.cmdOrgin.Name = "cmdOrgin"
        Me.cmdOrgin.Size = New System.Drawing.Size(75, 23)
        Me.cmdOrgin.TabIndex = 8
        Me.cmdOrgin.Text = "Origin"
        '
        'cboFromAddr
        '
        Me.cboFromAddr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFromAddr.FormattingEnabled = True
        Me.cboFromAddr.Location = New System.Drawing.Point(436, 8)
        Me.cboFromAddr.Name = "cboFromAddr"
        Me.cboFromAddr.Size = New System.Drawing.Size(114, 21)
        Me.cboFromAddr.TabIndex = 6
        '
        'txtSubj
        '
        Me.txtSubj.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubj.Location = New System.Drawing.Point(48, 56)
        Me.txtSubj.Name = "txtSubj"
        Me.txtSubj.Size = New System.Drawing.Size(503, 20)
        Me.txtSubj.TabIndex = 5
        '
        'txtTo
        '
        Me.txtTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTo.Location = New System.Drawing.Point(48, 32)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(382, 20)
        Me.txtTo.TabIndex = 4
        '
        'txtFrom
        '
        Me.txtFrom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFrom.Location = New System.Drawing.Point(48, 8)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(382, 20)
        Me.txtFrom.TabIndex = 3
        '
        'lblSubj
        '
        Me.lblSubj.AutoSize = True
        Me.lblSubj.Location = New System.Drawing.Point(8, 64)
        Me.lblSubj.Name = "lblSubj"
        Me.lblSubj.Size = New System.Drawing.Size(33, 13)
        Me.lblSubj.TabIndex = 2
        Me.lblSubj.Text = "Тема:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(8, 40)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(32, 13)
        Me.lblTo.TabIndex = 1
        Me.lblTo.Text = "Кому:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(24, 16)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(19, 13)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "От:"
        '
        'rtfMessage
        '
        Me.rtfMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtfMessage.Location = New System.Drawing.Point(0, 128)
        Me.rtfMessage.Name = "rtfMessage"
        Me.rtfMessage.Size = New System.Drawing.Size(1837, 788)
        Me.rtfMessage.TabIndex = 0
        Me.rtfMessage.Text = ""
        '
        'ToolStripSmiles
        '
        Me.ToolStripSmiles.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripSmiles.Location = New System.Drawing.Point(25, 0)
        Me.ToolStripSmiles.Name = "ToolStripSmiles"
        Me.ToolStripSmiles.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStripSmiles.Size = New System.Drawing.Size(25, 111)
        Me.ToolStripSmiles.TabIndex = 0
        '
        'MainMenu
        '
        Me.MainMenu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MainMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.editToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MainMenu.Size = New System.Drawing.Size(616, 24)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripMenuItem, Me.toolStripSeparator, Me.saveToolStripMenuItem, Me.saveAsToolStripMenuItem, Me.toolStripSeparator1, Me.printToolStripMenuItem, Me.printPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Text = "&File"
        '
        'newToolStripMenuItem
        '
        Me.newToolStripMenuItem.Image = CType(resources.GetObject("newToolStripMenuItem.Image"), System.Drawing.Image)
        Me.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
        Me.newToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.newToolStripMenuItem.Text = "&New"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        '
        'saveToolStripMenuItem
        '
        Me.saveToolStripMenuItem.Image = CType(resources.GetObject("saveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveToolStripMenuItem.Name = "saveToolStripMenuItem"
        Me.saveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.saveToolStripMenuItem.Text = "&Save"
        '
        'saveAsToolStripMenuItem
        '
        Me.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem"
        Me.saveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        '
        'printToolStripMenuItem
        '
        Me.printToolStripMenuItem.Image = CType(resources.GetObject("printToolStripMenuItem.Image"), System.Drawing.Image)
        Me.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printToolStripMenuItem.Name = "printToolStripMenuItem"
        Me.printToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.printToolStripMenuItem.Text = "&Print"
        '
        'printPreviewToolStripMenuItem
        '
        Me.printPreviewToolStripMenuItem.Image = CType(resources.GetObject("printPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem"
        Me.printPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Text = "E&xit"
        '
        'editToolStripMenuItem
        '
        Me.editToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.undoToolStripMenuItem, Me.redoToolStripMenuItem, Me.toolStripSeparator3, Me.cutToolStripMenuItem, Me.copyToolStripMenuItem, Me.pasteToolStripMenuItem, Me.toolStripSeparator4, Me.selectAllToolStripMenuItem})
        Me.editToolStripMenuItem.Name = "editToolStripMenuItem"
        Me.editToolStripMenuItem.Text = "&Edit"
        '
        'undoToolStripMenuItem
        '
        Me.undoToolStripMenuItem.Name = "undoToolStripMenuItem"
        Me.undoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.undoToolStripMenuItem.Text = "&Undo"
        '
        'redoToolStripMenuItem
        '
        Me.redoToolStripMenuItem.Name = "redoToolStripMenuItem"
        Me.redoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.redoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        '
        'cutToolStripMenuItem
        '
        Me.cutToolStripMenuItem.Image = CType(resources.GetObject("cutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cutToolStripMenuItem.Name = "cutToolStripMenuItem"
        Me.cutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cutToolStripMenuItem.Text = "Cu&t"
        '
        'copyToolStripMenuItem
        '
        Me.copyToolStripMenuItem.Image = CType(resources.GetObject("copyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
        Me.copyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.copyToolStripMenuItem.Text = "&Copy"
        '
        'pasteToolStripMenuItem
        '
        Me.pasteToolStripMenuItem.Image = CType(resources.GetObject("pasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
        Me.pasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.pasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        '
        'selectAllToolStripMenuItem
        '
        Me.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem"
        Me.selectAllToolStripMenuItem.Text = "Select &All"
        '
        'ToolStripStandart
        '
        Me.ToolStripStandart.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripStandart.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripButton, Me.saveToolStripButton, Me.printToolStripButton, Me.toolStripSeparator6, Me.cutToolStripButton, Me.copyToolStripButton, Me.pasteToolStripButton, Me.toolStripSeparator7})
        Me.ToolStripStandart.Location = New System.Drawing.Point(0, 24)
        Me.ToolStripStandart.Name = "ToolStripStandart"
        Me.ToolStripStandart.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStripStandart.Size = New System.Drawing.Size(192, 25)
        Me.ToolStripStandart.TabIndex = 1
        Me.ToolStripStandart.Text = "ToolStrip2"
        '
        'newToolStripButton
        '
        Me.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newToolStripButton.Image = CType(resources.GetObject("newToolStripButton.Image"), System.Drawing.Image)
        Me.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newToolStripButton.Name = "newToolStripButton"
        Me.newToolStripButton.Text = "&New"
        '
        'saveToolStripButton
        '
        Me.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.saveToolStripButton.Image = CType(resources.GetObject("saveToolStripButton.Image"), System.Drawing.Image)
        Me.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveToolStripButton.Name = "saveToolStripButton"
        Me.saveToolStripButton.Text = "&Save"
        '
        'printToolStripButton
        '
        Me.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.printToolStripButton.Image = CType(resources.GetObject("printToolStripButton.Image"), System.Drawing.Image)
        Me.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printToolStripButton.Name = "printToolStripButton"
        Me.printToolStripButton.Text = "&Print"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        '
        'cutToolStripButton
        '
        Me.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cutToolStripButton.Image = CType(resources.GetObject("cutToolStripButton.Image"), System.Drawing.Image)
        Me.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cutToolStripButton.Name = "cutToolStripButton"
        Me.cutToolStripButton.Text = "C&ut"
        '
        'copyToolStripButton
        '
        Me.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.copyToolStripButton.Image = CType(resources.GetObject("copyToolStripButton.Image"), System.Drawing.Image)
        Me.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.copyToolStripButton.Name = "copyToolStripButton"
        Me.copyToolStripButton.Text = "&Copy"
        '
        'pasteToolStripButton
        '
        Me.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.pasteToolStripButton.Image = CType(resources.GetObject("pasteToolStripButton.Image"), System.Drawing.Image)
        Me.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pasteToolStripButton.Name = "pasteToolStripButton"
        Me.pasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        '
        'cboToAddr
        '
        Me.cboToAddr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboToAddr.FormattingEnabled = True
        Me.cboToAddr.Location = New System.Drawing.Point(436, 32)
        Me.cboToAddr.Name = "cboToAddr"
        Me.cboToAddr.Size = New System.Drawing.Size(114, 21)
        Me.cboToAddr.TabIndex = 7
        Me.cboToAddr.Visible = False
        '
        'frmMailEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 432)
        Me.Controls.Add(Me.ToolStripContainer)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "frmMailEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMailEditor"
        Me.ToolStripContainer.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer.RightToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer.RightToolStripPanel.PerformLayout()
        Me.ToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer.ResumeLayout(False)
        Me.ToolStripContainer.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.ToolStripStandart.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer As System.Windows.Forms.ToolStripContainer
    Friend WithEvents rtfMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStandart As System.Windows.Forms.ToolStrip
    Friend WithEvents newToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents saveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents printToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents copyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents pasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTipMailEditor As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripSmiles As System.Windows.Forms.ToolStrip
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents saveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents saveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents printToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents printPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents editToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents undoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents redoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents copyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents selectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblSubj As System.Windows.Forms.Label
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents cboFromAddr As System.Windows.Forms.ComboBox
    Friend WithEvents txtSubj As System.Windows.Forms.TextBox
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxFlags As System.Windows.Forms.GroupBox
    Friend WithEvents cmdOrgin As System.Windows.Forms.Button
    Friend WithEvents cboToAddr As System.Windows.Forms.ComboBox
End Class
