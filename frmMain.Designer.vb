<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.EchoList = New System.Windows.Forms.ListView
        Me.ColumnHeadeEchos = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeaderMails = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeaderDescription = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeaderAkA = New System.Windows.Forms.ColumnHeader
        Me.ImagesEchoList = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.MailList = New System.Windows.Forms.ListView
        Me.ColumnHeaderSubj = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeaderFrom = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeaderTo = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeaderWrDate = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeaderArDate = New System.Windows.Forms.ColumnHeader
        Me.MessageContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItemCreate = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItemEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemSave = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItemCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemForward = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemMove = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItemDump = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItemKluges = New System.Windows.Forms.ToolStripMenuItem
        Me.HtmlMailViewer = New System.Windows.Forms.WebBrowser
        Me.MailHead = New System.Windows.Forms.GroupBox
        Me.lblFromAddr = New System.Windows.Forms.Label
        Me.lblTo = New System.Windows.Forms.Label
        Me.lblFrom = New System.Windows.Forms.Label
        Me.MainMenu = New System.Windows.Forms.MenuStrip
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
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
        Me.toolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.customizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.optionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.contentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.indexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.searchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabelEchos = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripProgressBar = New System.Windows.Forms.ToolStripProgressBar
        Me.ToolStripMain = New System.Windows.Forms.ToolStrip
        Me.cutToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.saveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.printToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.copyToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.pasteToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.helpToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.GFEToolStrip = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.GFEToolStripButtonDeleteMessage = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.GFEToolStripButtonNewMessage = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.MessageContextMenu.SuspendLayout()
        Me.MailHead.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStripMain.SuspendLayout()
        Me.GFEToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EchoList)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(632, 347)
        Me.SplitContainer1.SplitterDistance = 167
        Me.SplitContainer1.TabIndex = 5
        Me.SplitContainer1.Text = "SplitContainer1"
        '
        'EchoList
        '
        Me.EchoList.AllowDrop = True
        Me.EchoList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeadeEchos, Me.ColumnHeaderMails, Me.ColumnHeaderDescription, Me.ColumnHeaderAkA})
        Me.EchoList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EchoList.FullRowSelect = True
        Me.EchoList.LabelWrap = False
        Me.EchoList.Location = New System.Drawing.Point(0, 0)
        Me.EchoList.MultiSelect = False
        Me.EchoList.Name = "EchoList"
        Me.EchoList.Size = New System.Drawing.Size(167, 347)
        Me.EchoList.SmallImageList = Me.ImagesEchoList
        Me.EchoList.TabIndex = 0
        Me.EchoList.UseCompatibleStateImageBehavior = False
        Me.EchoList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeadeEchos
        '
        Me.ColumnHeadeEchos.Text = "Эхи"
        Me.ColumnHeadeEchos.Width = 128
        '
        'ColumnHeaderMails
        '
        Me.ColumnHeaderMails.Text = "Письма"
        '
        'ColumnHeaderDescription
        '
        Me.ColumnHeaderDescription.Text = "Описание"
        Me.ColumnHeaderDescription.Width = 10
        '
        'ColumnHeaderAkA
        '
        Me.ColumnHeaderAkA.Text = "AkA"
        Me.ColumnHeaderAkA.Width = 0
        '
        'ImagesEchoList
        '
        Me.ImagesEchoList.ImageStream = CType(resources.GetObject("ImagesEchoList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImagesEchoList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImagesEchoList.Images.SetKeyName(0, "Sphere_Mail.ico")
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.MailList)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.HtmlMailViewer)
        Me.SplitContainer2.Panel2.Controls.Add(Me.MailHead)
        Me.SplitContainer2.Size = New System.Drawing.Size(461, 347)
        Me.SplitContainer2.SplitterDistance = 126
        Me.SplitContainer2.TabIndex = 6
        Me.SplitContainer2.Text = "SplitContainer2"
        '
        'MailList
        '
        Me.MailList.AllowColumnReorder = True
        Me.MailList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderSubj, Me.ColumnHeaderFrom, Me.ColumnHeaderTo, Me.ColumnHeaderWrDate, Me.ColumnHeaderArDate})
        Me.MailList.ContextMenuStrip = Me.MessageContextMenu
        Me.MailList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MailList.FullRowSelect = True
        Me.MailList.HideSelection = False
        Me.MailList.Location = New System.Drawing.Point(0, 0)
        Me.MailList.Name = "MailList"
        Me.MailList.ShowGroups = False
        Me.MailList.Size = New System.Drawing.Size(461, 126)
        Me.MailList.TabIndex = 1
        Me.MailList.UseCompatibleStateImageBehavior = False
        Me.MailList.View = System.Windows.Forms.View.Details
        Me.MailList.VirtualListSize = 10
        '
        'ColumnHeaderSubj
        '
        Me.ColumnHeaderSubj.Text = "Тема"
        Me.ColumnHeaderSubj.Width = 260
        '
        'ColumnHeaderFrom
        '
        Me.ColumnHeaderFrom.Text = "От"
        Me.ColumnHeaderFrom.Width = 110
        '
        'ColumnHeaderTo
        '
        Me.ColumnHeaderTo.Text = "Кому"
        Me.ColumnHeaderTo.Width = 110
        '
        'ColumnHeaderWrDate
        '
        Me.ColumnHeaderWrDate.Text = "Написано"
        Me.ColumnHeaderWrDate.Width = 115
        '
        'ColumnHeaderArDate
        '
        Me.ColumnHeaderArDate.Text = "Получено"
        Me.ColumnHeaderArDate.Width = 115
        '
        'MessageContextMenu
        '
        Me.MessageContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemCreate, Me.ToolStripMenuItemOpen, Me.ToolStripSeparator17, Me.ToolStripMenuItemEdit, Me.ToolStripMenuItemSave, Me.ToolStripMenuItemDelete, Me.ToolStripSeparator16, Me.ToolStripMenuItemCopy, Me.ToolStripMenuItemForward, Me.ToolStripMenuItemMove, Me.ToolStripSeparator18, Me.ToolStripMenuItemDump, Me.ToolStripMenuItemKluges})
        Me.MessageContextMenu.Name = "MessageContextMenu"
        Me.MessageContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MessageContextMenu.ShowCheckMargin = True
        Me.MessageContextMenu.Size = New System.Drawing.Size(174, 242)
        '
        'ToolStripMenuItemCreate
        '
        Me.ToolStripMenuItemCreate.Image = CType(resources.GetObject("ToolStripMenuItemCreate.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemCreate.Name = "ToolStripMenuItemCreate"
        Me.ToolStripMenuItemCreate.Size = New System.Drawing.Size(173, 22)
        Me.ToolStripMenuItemCreate.Text = "&Создать"
        '
        'ToolStripMenuItemOpen
        '
        Me.ToolStripMenuItemOpen.Image = CType(resources.GetObject("ToolStripMenuItemOpen.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemOpen.Name = "ToolStripMenuItemOpen"
        Me.ToolStripMenuItemOpen.Size = New System.Drawing.Size(173, 22)
        Me.ToolStripMenuItemOpen.Text = "&Открыть"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(170, 6)
        '
        'ToolStripMenuItemEdit
        '
        Me.ToolStripMenuItemEdit.Image = CType(resources.GetObject("ToolStripMenuItemEdit.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemEdit.Name = "ToolStripMenuItemEdit"
        Me.ToolStripMenuItemEdit.Size = New System.Drawing.Size(173, 22)
        Me.ToolStripMenuItemEdit.Text = "&Изменить"
        '
        'ToolStripMenuItemSave
        '
        Me.ToolStripMenuItemSave.Image = CType(resources.GetObject("ToolStripMenuItemSave.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemSave.Name = "ToolStripMenuItemSave"
        Me.ToolStripMenuItemSave.Size = New System.Drawing.Size(173, 22)
        Me.ToolStripMenuItemSave.Text = "Со&хранить"
        '
        'ToolStripMenuItemDelete
        '
        Me.ToolStripMenuItemDelete.Image = CType(resources.GetObject("ToolStripMenuItemDelete.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemDelete.Name = "ToolStripMenuItemDelete"
        Me.ToolStripMenuItemDelete.Size = New System.Drawing.Size(173, 22)
        Me.ToolStripMenuItemDelete.Text = "&Удалить"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(170, 6)
        '
        'ToolStripMenuItemCopy
        '
        Me.ToolStripMenuItemCopy.Name = "ToolStripMenuItemCopy"
        Me.ToolStripMenuItemCopy.Size = New System.Drawing.Size(173, 22)
        Me.ToolStripMenuItemCopy.Text = "&Копировать"
        '
        'ToolStripMenuItemForward
        '
        Me.ToolStripMenuItemForward.Name = "ToolStripMenuItemForward"
        Me.ToolStripMenuItemForward.Size = New System.Drawing.Size(173, 22)
        Me.ToolStripMenuItemForward.Text = "&Переслать"
        '
        'ToolStripMenuItemMove
        '
        Me.ToolStripMenuItemMove.Name = "ToolStripMenuItemMove"
        Me.ToolStripMenuItemMove.Size = New System.Drawing.Size(173, 22)
        Me.ToolStripMenuItemMove.Text = "П&ереместить"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(170, 6)
        '
        'ToolStripMenuItemDump
        '
        Me.ToolStripMenuItemDump.Image = CType(resources.GetObject("ToolStripMenuItemDump.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemDump.Name = "ToolStripMenuItemDump"
        Me.ToolStripMenuItemDump.Size = New System.Drawing.Size(173, 22)
        Me.ToolStripMenuItemDump.Text = "&Дамп"
        '
        'ToolStripMenuItemKluges
        '
        Me.ToolStripMenuItemKluges.Image = CType(resources.GetObject("ToolStripMenuItemKluges.Image"), System.Drawing.Image)
        Me.ToolStripMenuItemKluges.Name = "ToolStripMenuItemKluges"
        Me.ToolStripMenuItemKluges.Size = New System.Drawing.Size(173, 22)
        Me.ToolStripMenuItemKluges.Text = "Клад&жи"
        '
        'HtmlMailViewer
        '
        Me.HtmlMailViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HtmlMailViewer.IsWebBrowserContextMenuEnabled = False
        Me.HtmlMailViewer.Location = New System.Drawing.Point(0, 64)
        Me.HtmlMailViewer.MinimumSize = New System.Drawing.Size(20, 20)
        Me.HtmlMailViewer.Name = "HtmlMailViewer"
        Me.HtmlMailViewer.Size = New System.Drawing.Size(465, 149)
        Me.HtmlMailViewer.TabIndex = 8
        Me.HtmlMailViewer.Url = New System.Uri("about:blank", System.UriKind.Absolute)
        '
        'MailHead
        '
        Me.MailHead.Controls.Add(Me.lblFromAddr)
        Me.MailHead.Controls.Add(Me.lblTo)
        Me.MailHead.Controls.Add(Me.lblFrom)
        Me.MailHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.MailHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MailHead.Location = New System.Drawing.Point(0, 0)
        Me.MailHead.Name = "MailHead"
        Me.MailHead.Size = New System.Drawing.Size(461, 64)
        Me.MailHead.TabIndex = 7
        Me.MailHead.TabStop = False
        Me.MailHead.Text = "Письма Отсутствуют"
        '
        'lblFromAddr
        '
        Me.lblFromAddr.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFromAddr.AutoSize = True
        Me.lblFromAddr.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblFromAddr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblFromAddr.Location = New System.Drawing.Point(189, 16)
        Me.lblFromAddr.Name = "lblFromAddr"
        Me.lblFromAddr.Size = New System.Drawing.Size(47, 13)
        Me.lblFromAddr.TabIndex = 9
        Me.lblFromAddr.Text = "Адрес:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblTo.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTo.Location = New System.Drawing.Point(8, 40)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(41, 13)
        Me.lblTo.TabIndex = 10
        Me.lblTo.Text = "Кому:"
        '
        'lblFrom
        '
        Me.lblFrom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFrom.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(8, 16)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(123, 16)
        Me.lblFrom.TabIndex = 8
        Me.lblFrom.Text = "От Кого:"
        '
        'MainMenu
        '
        Me.MainMenu.AllowItemReorder = True
        Me.MainMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.MainMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.editToolStripMenuItem, Me.toolsToolStripMenuItem, Me.helpToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(3, 50)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MainMenu.Size = New System.Drawing.Size(219, 24)
        Me.MainMenu.Stretch = False
        Me.MainMenu.TabIndex = 2
        Me.MainMenu.Text = "MainMenuStrip"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripMenuItem, Me.openToolStripMenuItem, Me.toolStripSeparator, Me.saveToolStripMenuItem, Me.saveAsToolStripMenuItem, Me.toolStripSeparator1, Me.printToolStripMenuItem, Me.printPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.fileToolStripMenuItem.Text = "&Файл"
        '
        'newToolStripMenuItem
        '
        Me.newToolStripMenuItem.Image = CType(resources.GetObject("newToolStripMenuItem.Image"), System.Drawing.Image)
        Me.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
        Me.newToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.newToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.newToolStripMenuItem.Text = "&New"
        '
        'openToolStripMenuItem
        '
        Me.openToolStripMenuItem.Image = CType(resources.GetObject("openToolStripMenuItem.Image"), System.Drawing.Image)
        Me.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
        Me.openToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.openToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.openToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(157, 6)
        '
        'saveToolStripMenuItem
        '
        Me.saveToolStripMenuItem.Image = CType(resources.GetObject("saveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveToolStripMenuItem.Name = "saveToolStripMenuItem"
        Me.saveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.saveToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.saveToolStripMenuItem.Text = "&Save"
        '
        'saveAsToolStripMenuItem
        '
        Me.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem"
        Me.saveAsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.saveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(157, 6)
        '
        'printToolStripMenuItem
        '
        Me.printToolStripMenuItem.Image = CType(resources.GetObject("printToolStripMenuItem.Image"), System.Drawing.Image)
        Me.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printToolStripMenuItem.Name = "printToolStripMenuItem"
        Me.printToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.printToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.printToolStripMenuItem.Text = "&Печать"
        '
        'printPreviewToolStripMenuItem
        '
        Me.printPreviewToolStripMenuItem.Image = CType(resources.GetObject("printPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem"
        Me.printPreviewToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.printPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(157, 6)
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.exitToolStripMenuItem.Text = "&Выход"
        '
        'editToolStripMenuItem
        '
        Me.editToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.undoToolStripMenuItem, Me.redoToolStripMenuItem, Me.toolStripSeparator3, Me.cutToolStripMenuItem, Me.copyToolStripMenuItem, Me.pasteToolStripMenuItem, Me.toolStripSeparator4, Me.selectAllToolStripMenuItem})
        Me.editToolStripMenuItem.Name = "editToolStripMenuItem"
        Me.editToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.editToolStripMenuItem.Text = "&Правка"
        '
        'undoToolStripMenuItem
        '
        Me.undoToolStripMenuItem.Name = "undoToolStripMenuItem"
        Me.undoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.undoToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.undoToolStripMenuItem.Text = "&Отменить"
        '
        'redoToolStripMenuItem
        '
        Me.redoToolStripMenuItem.Name = "redoToolStripMenuItem"
        Me.redoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.redoToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.redoToolStripMenuItem.Text = "&Повторить"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(182, 6)
        '
        'cutToolStripMenuItem
        '
        Me.cutToolStripMenuItem.Image = CType(resources.GetObject("cutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cutToolStripMenuItem.Name = "cutToolStripMenuItem"
        Me.cutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cutToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.cutToolStripMenuItem.Text = "&Вырезать"
        '
        'copyToolStripMenuItem
        '
        Me.copyToolStripMenuItem.Image = CType(resources.GetObject("copyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
        Me.copyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.copyToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.copyToolStripMenuItem.Text = "&Копировать"
        '
        'pasteToolStripMenuItem
        '
        Me.pasteToolStripMenuItem.Image = CType(resources.GetObject("pasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
        Me.pasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.pasteToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.pasteToolStripMenuItem.Text = "Вст&авить"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(182, 6)
        '
        'selectAllToolStripMenuItem
        '
        Me.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem"
        Me.selectAllToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.selectAllToolStripMenuItem.Text = "Выбрать В&се"
        '
        'toolsToolStripMenuItem
        '
        Me.toolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.customizeToolStripMenuItem, Me.optionsToolStripMenuItem})
        Me.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem"
        Me.toolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.toolsToolStripMenuItem.Text = "&Tools"
        '
        'customizeToolStripMenuItem
        '
        Me.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem"
        Me.customizeToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.customizeToolStripMenuItem.Text = "&Customize"
        '
        'optionsToolStripMenuItem
        '
        Me.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem"
        Me.optionsToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.optionsToolStripMenuItem.Text = "&Параметры"
        '
        'helpToolStripMenuItem
        '
        Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.contentsToolStripMenuItem, Me.indexToolStripMenuItem, Me.searchToolStripMenuItem, Me.toolStripSeparator5, Me.aboutToolStripMenuItem})
        Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
        Me.helpToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.helpToolStripMenuItem.Text = "&Справка"
        '
        'contentsToolStripMenuItem
        '
        Me.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem"
        Me.contentsToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.contentsToolStripMenuItem.Text = "&Справка GFE"
        '
        'indexToolStripMenuItem
        '
        Me.indexToolStripMenuItem.Name = "indexToolStripMenuItem"
        Me.indexToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.indexToolStripMenuItem.Text = "&Индекс"
        '
        'searchToolStripMenuItem
        '
        Me.searchToolStripMenuItem.Name = "searchToolStripMenuItem"
        Me.searchToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.searchToolStripMenuItem.Text = "&Поиск"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(147, 6)
        '
        'aboutToolStripMenuItem
        '
        Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
        Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.aboutToolStripMenuItem.Text = "&О программе"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.StatusStrip)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.AutoScroll = True
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(632, 347)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(632, 446)
        Me.ToolStripContainer1.TabIndex = 7
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStripMain)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.GFEToolStrip)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MainMenu)
        '
        'StatusStrip
        '
        Me.StatusStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelEchos, Me.ToolStripProgressBar})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 25)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabelEchos
        '
        Me.ToolStripStatusLabelEchos.Name = "ToolStripStatusLabelEchos"
        Me.ToolStripStatusLabelEchos.Size = New System.Drawing.Size(133, 20)
        Me.ToolStripStatusLabelEchos.Text = "ToolStripStatusLabelEchos"
        '
        'ToolStripProgressBar
        '
        Me.ToolStripProgressBar.Margin = New System.Windows.Forms.Padding(10, 5, 2, 5)
        Me.ToolStripProgressBar.Name = "ToolStripProgressBar"
        Me.ToolStripProgressBar.Size = New System.Drawing.Size(100, 15)
        '
        'ToolStripMain
        '
        Me.ToolStripMain.AllowItemReorder = True
        Me.ToolStripMain.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cutToolStripButton, Me.saveToolStripButton, Me.printToolStripButton, Me.toolStripSeparator6, Me.copyToolStripButton, Me.pasteToolStripButton, Me.toolStripSeparator7, Me.helpToolStripButton})
        Me.ToolStripMain.Location = New System.Drawing.Point(3, 0)
        Me.ToolStripMain.Name = "ToolStripMain"
        Me.ToolStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStripMain.Size = New System.Drawing.Size(162, 25)
        Me.ToolStripMain.TabIndex = 3
        Me.ToolStripMain.Text = "ToolStripMain"
        '
        'cutToolStripButton
        '
        Me.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cutToolStripButton.Image = CType(resources.GetObject("cutToolStripButton.Image"), System.Drawing.Image)
        Me.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cutToolStripButton.Name = "cutToolStripButton"
        Me.cutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.cutToolStripButton.Text = "C&ut"
        '
        'saveToolStripButton
        '
        Me.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.saveToolStripButton.Image = CType(resources.GetObject("saveToolStripButton.Image"), System.Drawing.Image)
        Me.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveToolStripButton.Name = "saveToolStripButton"
        Me.saveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.saveToolStripButton.Text = "&Save"
        '
        'printToolStripButton
        '
        Me.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.printToolStripButton.Image = CType(resources.GetObject("printToolStripButton.Image"), System.Drawing.Image)
        Me.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printToolStripButton.Name = "printToolStripButton"
        Me.printToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.printToolStripButton.Text = "&Print"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'copyToolStripButton
        '
        Me.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.copyToolStripButton.Image = CType(resources.GetObject("copyToolStripButton.Image"), System.Drawing.Image)
        Me.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.copyToolStripButton.Name = "copyToolStripButton"
        Me.copyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.copyToolStripButton.Text = "&Copy"
        '
        'pasteToolStripButton
        '
        Me.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.pasteToolStripButton.Image = CType(resources.GetObject("pasteToolStripButton.Image"), System.Drawing.Image)
        Me.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pasteToolStripButton.Name = "pasteToolStripButton"
        Me.pasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.pasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'helpToolStripButton
        '
        Me.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.helpToolStripButton.Image = CType(resources.GetObject("helpToolStripButton.Image"), System.Drawing.Image)
        Me.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.helpToolStripButton.Name = "helpToolStripButton"
        Me.helpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.helpToolStripButton.Text = "He&lp"
        '
        'GFEToolStrip
        '
        Me.GFEToolStrip.AllowItemReorder = True
        Me.GFEToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.GFEToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator8, Me.ToolStripButton3, Me.ToolStripSeparator9, Me.ToolStripButton5, Me.ToolStripButton14, Me.ToolStripButton15, Me.ToolStripButton13, Me.ToolStripSeparator10, Me.GFEToolStripButtonDeleteMessage, Me.ToolStripSeparator11, Me.GFEToolStripButtonNewMessage, Me.ToolStripButton7, Me.ToolStripSeparator12, Me.ToolStripButton8, Me.ToolStripButton9, Me.ToolStripSeparator13, Me.ToolStripButton10, Me.ToolStripSeparator14, Me.ToolStripButton11, Me.ToolStripButton12})
        Me.GFEToolStrip.Location = New System.Drawing.Point(3, 25)
        Me.GFEToolStrip.Name = "GFEToolStrip"
        Me.GFEToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.GFEToolStrip.Size = New System.Drawing.Size(399, 25)
        Me.GFEToolStrip.TabIndex = 4
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton14.Text = "ToolStripButton14"
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), System.Drawing.Image)
        Me.ToolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton15.Text = "ToolStripButton15"
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton13.Text = "ToolStripButton13"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'GFEToolStripButtonDeleteMessage
        '
        Me.GFEToolStripButtonDeleteMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GFEToolStripButtonDeleteMessage.Image = CType(resources.GetObject("GFEToolStripButtonDeleteMessage.Image"), System.Drawing.Image)
        Me.GFEToolStripButtonDeleteMessage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GFEToolStripButtonDeleteMessage.Name = "GFEToolStripButtonDeleteMessage"
        Me.GFEToolStripButtonDeleteMessage.Size = New System.Drawing.Size(23, 22)
        Me.GFEToolStripButtonDeleteMessage.Text = "ToolStripButton4"
        Me.GFEToolStripButtonDeleteMessage.ToolTipText = "Удалить"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'GFEToolStripButtonNewMessage
        '
        Me.GFEToolStripButtonNewMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GFEToolStripButtonNewMessage.Image = CType(resources.GetObject("GFEToolStripButtonNewMessage.Image"), System.Drawing.Image)
        Me.GFEToolStripButtonNewMessage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GFEToolStripButtonNewMessage.Name = "GFEToolStripButtonNewMessage"
        Me.GFEToolStripButtonNewMessage.Size = New System.Drawing.Size(23, 22)
        Me.GFEToolStripButtonNewMessage.Text = "ToolStripButton6"
        Me.GFEToolStripButtonNewMessage.ToolTipText = "Новое Письмо"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "ToolStripButton7"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "ToolStripButton8"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.Text = "ToolStripButton9"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton10.Text = "ToolStripButton10"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton11.Text = "ToolStripButton11"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton12.Text = "ToolStripButton12"
        '
        'ToolTip
        '
        Me.ToolTip.IsBalloon = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 446)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "GFE"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.MessageContextMenu.ResumeLayout(False)
        Me.MailHead.ResumeLayout(False)
        Me.MailHead.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStripMain.ResumeLayout(False)
        Me.ToolStripMain.PerformLayout()
        Me.GFEToolStrip.ResumeLayout(False)
        Me.GFEToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EchoList As System.Windows.Forms.ListView
    Friend WithEvents MailList As System.Windows.Forms.ListView
    Friend WithEvents MailHead As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeadeEchos As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderMails As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderAkA As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderSubj As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderFrom As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderTo As System.Windows.Forms.ColumnHeader
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents openToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
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
    Friend WithEvents toolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents customizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents optionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents contentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents indexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents searchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents GFEToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabelEchos As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents saveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents printToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents copyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents pasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents helpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImagesEchoList As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GFEToolStripButtonDeleteMessage As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GFEToolStripButtonNewMessage As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton14 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton15 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblFromAddr As System.Windows.Forms.Label
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ColumnHeaderWrDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeaderArDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents MessageContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItemOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItemCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemForward As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemMove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItemCreate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItemDump As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemKluges As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HtmlMailViewer As System.Windows.Forms.WebBrowser

End Class
