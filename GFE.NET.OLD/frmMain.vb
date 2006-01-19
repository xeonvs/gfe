Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmMain
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'For the start-up form, the first instance created is the default instance.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents MailList2 As AxMSComctlLib.AxListView
	Public WithEvents picShow As System.Windows.Forms.PictureBox
	Public WithEvents cmdUUEDec As GoldButton
	Public WithEvents picDec As System.Windows.Forms.PictureBox
	Public WithEvents flFromAddr As System.Windows.Forms.Label
	Public WithEvents flFrom As System.Windows.Forms.Label
	Public WithEvents hfTo As System.Windows.Forms.Label
	Public WithEvents MailHead As System.Windows.Forms.GroupBox
	Public WithEvents MailViewer As AxRichTextLib.AxRichTextBox
	Public WithEvents MailViewerC As System.Windows.Forms.Panel
	Public WithEvents ImageList3 As AxMSComctlLib.AxImageList
	Public WithEvents ImageList2 As AxMSComctlLib.AxImageList
	Public WithEvents SpliterTimer As System.Windows.Forms.Timer
	Public WithEvents StatusBar As AxMSComctlLib.AxStatusBar
	Public WithEvents ImageList1 As AxMSComctlLib.AxImageList
	Public WithEvents NavigationToolBar As AxMSComctlLib.AxToolbar
	Public WithEvents CoolBar As AxComCtl3.AxCoolBar
	Public WithEvents MailList As AxMSComctlLib.AxTreeView
	Public WithEvents EchoList As AxMSComctlLib.AxListView
	Public WithEvents ProgressBar As AxMSComctlLib.AxProgressBar
	Public WithEvents Shape1 As System.Windows.Forms.Label
	Public WithEvents PrBar As System.Windows.Forms.Panel
	Public WithEvents Picture1 As System.Windows.Forms.Panel
	Public WithEvents Splitter1 As System.Windows.Forms.PictureBox
	Public WithEvents Splitter2 As System.Windows.Forms.PictureBox
	Public WithEvents mnuPlugins As Microsoft.VisualBasic.Compatibility.VB6.MenuItemArray
	Public WithEvents mnuOptions As System.Windows.Forms.MenuItem
	Public WithEvents h1 As System.Windows.Forms.MenuItem
	Public WithEvents mncExit As System.Windows.Forms.MenuItem
	Public WithEvents mnFile As System.Windows.Forms.MenuItem
	Public WithEvents mnuFindLetter As System.Windows.Forms.MenuItem
	Public WithEvents mnEdit As System.Windows.Forms.MenuItem
	Public WithEvents mnStandartToolbar As System.Windows.Forms.MenuItem
	Public WithEvents H2 As System.Windows.Forms.MenuItem
	Public WithEvents mncToolBarNotTitle As System.Windows.Forms.MenuItem
	Public WithEvents mncToolBarRightTitle As System.Windows.Forms.MenuItem
	Public WithEvents mncToolBarBottomTitle As System.Windows.Forms.MenuItem
	Public WithEvents mncToolBarView As System.Windows.Forms.MenuItem
	Public WithEvents mnToolBars As System.Windows.Forms.MenuItem
	Public WithEvents mncTreeMailList As System.Windows.Forms.MenuItem
	Public WithEvents mncListMailList As System.Windows.Forms.MenuItem
	Public WithEvents mnMailList As System.Windows.Forms.MenuItem
	Public WithEvents mnView As System.Windows.Forms.MenuItem
	Public WithEvents mnuNewMessage As System.Windows.Forms.MenuItem
	Public WithEvents mnuEditMessage As System.Windows.Forms.MenuItem
	Public WithEvents mnuDeleteMessage As System.Windows.Forms.MenuItem
	Public WithEvents h3 As System.Windows.Forms.MenuItem
	Public WithEvents mnuReplyNotCit As System.Windows.Forms.MenuItem
	Public WithEvents mnuReplyQuote As System.Windows.Forms.MenuItem
	Public WithEvents mnuReplyAnotherEcho As System.Windows.Forms.MenuItem
	Public WithEvents mnuAnswer As System.Windows.Forms.MenuItem
	Public WithEvents mnuForwardMessage As System.Windows.Forms.MenuItem
	Public WithEvents mnuCopyMessage As System.Windows.Forms.MenuItem
	Public WithEvents mnuTransferMssage As System.Windows.Forms.MenuItem
	Public WithEvents h4 As System.Windows.Forms.MenuItem
	Public WithEvents mnuPrintMessage As System.Windows.Forms.MenuItem
	Public WithEvents mnuMessages As System.Windows.Forms.MenuItem
	Public WithEvents _mnuPlugins_0 As System.Windows.Forms.MenuItem
	Public WithEvents mnuPlugin As System.Windows.Forms.MenuItem
	Public WithEvents mnuAbout As System.Windows.Forms.MenuItem
	Public WithEvents mnuCheckUpdate As System.Windows.Forms.MenuItem
	Public WithEvents mnuHelp As System.Windows.Forms.MenuItem
	Public WithEvents mcRefresh As System.Windows.Forms.MenuItem
	Public WithEvents x1 As System.Windows.Forms.MenuItem
	Public WithEvents mcOpenMail As System.Windows.Forms.MenuItem
	Public WithEvents mcChange As System.Windows.Forms.MenuItem
	Public WithEvents mcSaveMessage As System.Windows.Forms.MenuItem
	Public WithEvents H11 As System.Windows.Forms.MenuItem
	Public WithEvents mcCopyMail As System.Windows.Forms.MenuItem
	Public WithEvents mcForwardMail As System.Windows.Forms.MenuItem
	Public WithEvents mcMoveMail As System.Windows.Forms.MenuItem
	Public WithEvents h12 As System.Windows.Forms.MenuItem
	Public WithEvents mcCreateMail As System.Windows.Forms.MenuItem
	Public WithEvents mcDeleteMail As System.Windows.Forms.MenuItem
	Public WithEvents h14 As System.Windows.Forms.MenuItem
	Public WithEvents mcDumpMail As System.Windows.Forms.MenuItem
	Public WithEvents mcShowKluge As System.Windows.Forms.MenuItem
	Public WithEvents mcTerminalFont As System.Windows.Forms.MenuItem
	Public WithEvents MailContext As System.Windows.Forms.MenuItem
	Public MainMenu1 As System.Windows.Forms.MainMenu
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.MailList2 = New AxMSComctlLib.AxListView
		Me.picShow = New System.Windows.Forms.PictureBox
		Me.MailViewerC = New System.Windows.Forms.Panel
		Me.MailHead = New System.Windows.Forms.GroupBox
		Me.cmdUUEDec = New GoldButton
		Me.picDec = New System.Windows.Forms.PictureBox
		Me.flFromAddr = New System.Windows.Forms.Label
		Me.flFrom = New System.Windows.Forms.Label
		Me.hfTo = New System.Windows.Forms.Label
		Me.MailViewer = New AxRichTextLib.AxRichTextBox
		Me.ImageList3 = New AxMSComctlLib.AxImageList
		Me.ImageList2 = New AxMSComctlLib.AxImageList
		Me.SpliterTimer = New System.Windows.Forms.Timer(components)
		Me.StatusBar = New AxMSComctlLib.AxStatusBar
		Me.CoolBar = New AxComCtl3.AxCoolBar
		Me.NavigationToolBar = New AxMSComctlLib.AxToolbar
		Me.ImageList1 = New AxMSComctlLib.AxImageList
		Me.MailList = New AxMSComctlLib.AxTreeView
		Me.EchoList = New AxMSComctlLib.AxListView
		Me.Picture1 = New System.Windows.Forms.Panel
		Me.PrBar = New System.Windows.Forms.Panel
		Me.ProgressBar = New AxMSComctlLib.AxProgressBar
		Me.Shape1 = New System.Windows.Forms.Label
		Me.Splitter1 = New System.Windows.Forms.PictureBox
		Me.Splitter2 = New System.Windows.Forms.PictureBox
		Me.mnuPlugins = New Microsoft.VisualBasic.Compatibility.VB6.MenuItemArray(components)
		Me.MainMenu1 = New System.Windows.Forms.MainMenu
		Me.mnFile = New System.Windows.Forms.MenuItem
		Me.mnuOptions = New System.Windows.Forms.MenuItem
		Me.h1 = New System.Windows.Forms.MenuItem
		Me.mncExit = New System.Windows.Forms.MenuItem
		Me.mnEdit = New System.Windows.Forms.MenuItem
		Me.mnuFindLetter = New System.Windows.Forms.MenuItem
		Me.mnView = New System.Windows.Forms.MenuItem
		Me.mnToolBars = New System.Windows.Forms.MenuItem
		Me.mnStandartToolbar = New System.Windows.Forms.MenuItem
		Me.H2 = New System.Windows.Forms.MenuItem
		Me.mncToolBarView = New System.Windows.Forms.MenuItem
		Me.mncToolBarNotTitle = New System.Windows.Forms.MenuItem
		Me.mncToolBarRightTitle = New System.Windows.Forms.MenuItem
		Me.mncToolBarBottomTitle = New System.Windows.Forms.MenuItem
		Me.mnMailList = New System.Windows.Forms.MenuItem
		Me.mncTreeMailList = New System.Windows.Forms.MenuItem
		Me.mncListMailList = New System.Windows.Forms.MenuItem
		Me.mnuMessages = New System.Windows.Forms.MenuItem
		Me.mnuNewMessage = New System.Windows.Forms.MenuItem
		Me.mnuEditMessage = New System.Windows.Forms.MenuItem
		Me.mnuDeleteMessage = New System.Windows.Forms.MenuItem
		Me.h3 = New System.Windows.Forms.MenuItem
		Me.mnuAnswer = New System.Windows.Forms.MenuItem
		Me.mnuReplyNotCit = New System.Windows.Forms.MenuItem
		Me.mnuReplyQuote = New System.Windows.Forms.MenuItem
		Me.mnuReplyAnotherEcho = New System.Windows.Forms.MenuItem
		Me.mnuTransferMssage = New System.Windows.Forms.MenuItem
		Me.mnuForwardMessage = New System.Windows.Forms.MenuItem
		Me.mnuCopyMessage = New System.Windows.Forms.MenuItem
		Me.h4 = New System.Windows.Forms.MenuItem
		Me.mnuPrintMessage = New System.Windows.Forms.MenuItem
		Me.mnuPlugin = New System.Windows.Forms.MenuItem
		Me._mnuPlugins_0 = New System.Windows.Forms.MenuItem
		Me.mnuHelp = New System.Windows.Forms.MenuItem
		Me.mnuAbout = New System.Windows.Forms.MenuItem
		Me.mnuCheckUpdate = New System.Windows.Forms.MenuItem
		Me.MailContext = New System.Windows.Forms.MenuItem
		Me.mcRefresh = New System.Windows.Forms.MenuItem
		Me.x1 = New System.Windows.Forms.MenuItem
		Me.mcOpenMail = New System.Windows.Forms.MenuItem
		Me.mcChange = New System.Windows.Forms.MenuItem
		Me.mcSaveMessage = New System.Windows.Forms.MenuItem
		Me.H11 = New System.Windows.Forms.MenuItem
		Me.mcCopyMail = New System.Windows.Forms.MenuItem
		Me.mcForwardMail = New System.Windows.Forms.MenuItem
		Me.mcMoveMail = New System.Windows.Forms.MenuItem
		Me.h12 = New System.Windows.Forms.MenuItem
		Me.mcCreateMail = New System.Windows.Forms.MenuItem
		Me.mcDeleteMail = New System.Windows.Forms.MenuItem
		Me.h14 = New System.Windows.Forms.MenuItem
		Me.mcDumpMail = New System.Windows.Forms.MenuItem
		Me.mcShowKluge = New System.Windows.Forms.MenuItem
		Me.mcTerminalFont = New System.Windows.Forms.MenuItem
		CType(Me.MailList2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MailViewer, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImageList3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImageList2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.StatusBar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.NavigationToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CoolBar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.MailList, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EchoList, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ProgressBar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.mnuPlugins, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Gold Fido Explorer"
		Me.ClientSize = New System.Drawing.Size(647, 532)
		Me.Location = New System.Drawing.Point(11, 57)
		Me.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Icon = CType(resources.GetObject("frmMain.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmMain"
		MailList2.OcxState = CType(resources.GetObject("MailList2.OcxState"), System.Windows.Forms.AxHost.State)
		Me.MailList2.Size = New System.Drawing.Size(417, 137)
		Me.MailList2.Location = New System.Drawing.Point(264, 48)
		Me.MailList2.TabIndex = 14
		Me.MailList2.Visible = False
		Me.MailList2.Name = "MailList2"
		Me.picShow.Size = New System.Drawing.Size(55, 55)
		Me.picShow.Location = New System.Drawing.Point(564, 180)
		Me.picShow.TabIndex = 15
		Me.picShow.Visible = False
		Me.picShow.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picShow.Dock = System.Windows.Forms.DockStyle.None
		Me.picShow.BackColor = System.Drawing.SystemColors.Control
		Me.picShow.CausesValidation = True
		Me.picShow.Enabled = True
		Me.picShow.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picShow.Cursor = System.Windows.Forms.Cursors.Default
		Me.picShow.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picShow.TabStop = True
		Me.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picShow.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picShow.Name = "picShow"
		Me.MailViewerC.ForeColor = System.Drawing.SystemColors.WindowText
		Me.MailViewerC.Size = New System.Drawing.Size(401, 233)
		Me.MailViewerC.Location = New System.Drawing.Point(152, 210)
		Me.MailViewerC.TabIndex = 7
		Me.MailViewerC.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MailViewerC.Dock = System.Windows.Forms.DockStyle.None
		Me.MailViewerC.BackColor = System.Drawing.SystemColors.Control
		Me.MailViewerC.CausesValidation = True
		Me.MailViewerC.Enabled = True
		Me.MailViewerC.Cursor = System.Windows.Forms.Cursors.Default
		Me.MailViewerC.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.MailViewerC.TabStop = True
		Me.MailViewerC.Visible = True
		Me.MailViewerC.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.MailViewerC.Name = "MailViewerC"
		Me.MailHead.Text = "Тема Письма"
		Me.MailHead.Size = New System.Drawing.Size(383, 61)
		Me.MailHead.Location = New System.Drawing.Point(0, 0)
		Me.MailHead.TabIndex = 9
		Me.MailHead.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MailHead.BackColor = System.Drawing.SystemColors.Control
		Me.MailHead.Enabled = True
		Me.MailHead.ForeColor = System.Drawing.SystemColors.ControlText
		Me.MailHead.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.MailHead.Visible = True
		Me.MailHead.Name = "MailHead"
		Me.cmdUUEDec.Size = New System.Drawing.Size(16, 16)
		Me.cmdUUEDec.Location = New System.Drawing.Point(348, 42)
		Me.cmdUUEDec.TabIndex = 17
		Me.cmdUUEDec.Visible = 0
		Me.cmdUUEDec.Name = "cmdUUEDec"
		Me.picDec.Size = New System.Drawing.Size(16, 16)
		Me.picDec.Location = New System.Drawing.Point(366, 43)
		Me.picDec.Image = CType(resources.GetObject("picDec.Image"), System.Drawing.Image)
		Me.picDec.TabIndex = 16
		Me.ToolTip1.SetToolTip(Me.picDec, "Появление этого значка символизирует наличие картинки в письме")
		Me.picDec.Visible = False
		Me.picDec.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.picDec.Dock = System.Windows.Forms.DockStyle.None
		Me.picDec.BackColor = System.Drawing.SystemColors.Control
		Me.picDec.CausesValidation = True
		Me.picDec.Enabled = True
		Me.picDec.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picDec.Cursor = System.Windows.Forms.Cursors.Default
		Me.picDec.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picDec.TabStop = True
		Me.picDec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picDec.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picDec.Name = "picDec"
		Me.flFromAddr.Text = "Адрес"
		Me.flFromAddr.Size = New System.Drawing.Size(37, 15)
		Me.flFromAddr.Location = New System.Drawing.Point(200, 16)
		Me.flFromAddr.TabIndex = 12
		Me.flFromAddr.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.flFromAddr.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.flFromAddr.BackColor = System.Drawing.SystemColors.Control
		Me.flFromAddr.Enabled = True
		Me.flFromAddr.ForeColor = System.Drawing.SystemColors.ControlText
		Me.flFromAddr.Cursor = System.Windows.Forms.Cursors.Default
		Me.flFromAddr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.flFromAddr.UseMnemonic = True
		Me.flFromAddr.Visible = True
		Me.flFromAddr.AutoSize = True
		Me.flFromAddr.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.flFromAddr.Name = "flFromAddr"
		Me.flFrom.Text = "От кого"
		Me.flFrom.Size = New System.Drawing.Size(185, 17)
		Me.flFrom.Location = New System.Drawing.Point(8, 16)
		Me.flFrom.TabIndex = 11
		Me.flFrom.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.flFrom.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.flFrom.BackColor = System.Drawing.SystemColors.Control
		Me.flFrom.Enabled = True
		Me.flFrom.ForeColor = System.Drawing.SystemColors.ControlText
		Me.flFrom.Cursor = System.Windows.Forms.Cursors.Default
		Me.flFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.flFrom.UseMnemonic = True
		Me.flFrom.Visible = True
		Me.flFrom.AutoSize = False
		Me.flFrom.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.flFrom.Name = "flFrom"
		Me.hfTo.Text = "Кому"
		Me.hfTo.ForeColor = System.Drawing.Color.FromARGB(0, 0, 192)
		Me.hfTo.Size = New System.Drawing.Size(28, 15)
		Me.hfTo.Location = New System.Drawing.Point(8, 32)
		Me.hfTo.TabIndex = 10
		Me.hfTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.hfTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.hfTo.BackColor = System.Drawing.SystemColors.Control
		Me.hfTo.Enabled = True
		Me.hfTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.hfTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.hfTo.UseMnemonic = True
		Me.hfTo.Visible = True
		Me.hfTo.AutoSize = True
		Me.hfTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.hfTo.Name = "hfTo"
		MailViewer.OcxState = CType(resources.GetObject("MailViewer.OcxState"), System.Windows.Forms.AxHost.State)
		Me.MailViewer.Size = New System.Drawing.Size(401, 152)
		Me.MailViewer.Location = New System.Drawing.Point(0, 73)
		Me.MailViewer.TabIndex = 8
		Me.MailViewer.Name = "MailViewer"
		ImageList3.OcxState = CType(resources.GetObject("ImageList3.OcxState"), System.Windows.Forms.AxHost.State)
		Me.ImageList3.Location = New System.Drawing.Point(72, 304)
		Me.ImageList3.Name = "ImageList3"
		ImageList2.OcxState = CType(resources.GetObject("ImageList2.OcxState"), System.Windows.Forms.AxHost.State)
		Me.ImageList2.Location = New System.Drawing.Point(448, 104)
		Me.ImageList2.Name = "ImageList2"
		Me.SpliterTimer.Interval = 40
		Me.SpliterTimer.Enabled = True
		StatusBar.OcxState = CType(resources.GetObject("StatusBar.OcxState"), System.Windows.Forms.AxHost.State)
		Me.StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.StatusBar.Size = New System.Drawing.Size(647, 25)
		Me.StatusBar.Location = New System.Drawing.Point(0, 507)
		Me.StatusBar.TabIndex = 2
		Me.StatusBar.Name = "StatusBar"
		CoolBar.OcxState = CType(resources.GetObject("CoolBar.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CoolBar.Dock = System.Windows.Forms.DockStyle.Top
		Me.CoolBar.Size = New System.Drawing.Size(647, 36)
		Me.CoolBar.Location = New System.Drawing.Point(0, 0)
		Me.CoolBar.TabIndex = 1
		Me.CoolBar.Name = "CoolBar"
		NavigationToolBar.OcxState = CType(resources.GetObject("NavigationToolBar.OcxState"), System.Windows.Forms.AxHost.State)
		Me.NavigationToolBar.Size = New System.Drawing.Size(641, 36)
		Me.NavigationToolBar.Location = New System.Drawing.Point(2, 0)
		Me.NavigationToolBar.TabIndex = 3
		Me.NavigationToolBar.Name = "NavigationToolBar"
		ImageList1.OcxState = CType(resources.GetObject("ImageList1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.ImageList1.Location = New System.Drawing.Point(464, -10)
		Me.ImageList1.Name = "ImageList1"
		MailList.OcxState = CType(resources.GetObject("MailList.OcxState"), System.Windows.Forms.AxHost.State)
		Me.MailList.Size = New System.Drawing.Size(409, 113)
		Me.MailList.Location = New System.Drawing.Point(222, 48)
		Me.MailList.TabIndex = 0
		Me.MailList.Visible = False
		Me.MailList.Name = "MailList"
		EchoList.OcxState = CType(resources.GetObject("EchoList.OcxState"), System.Windows.Forms.AxHost.State)
		Me.EchoList.Size = New System.Drawing.Size(143, 441)
		Me.EchoList.Location = New System.Drawing.Point(0, 64)
		Me.EchoList.TabIndex = 13
		Me.EchoList.Name = "EchoList"
		Me.Picture1.BackColor = System.Drawing.SystemColors.Window
		Me.Picture1.Size = New System.Drawing.Size(401, 105)
		Me.Picture1.Location = New System.Drawing.Point(150, 65)
		Me.Picture1.TabIndex = 4
		Me.Picture1.Visible = False
		Me.Picture1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture1.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture1.CausesValidation = True
		Me.Picture1.Enabled = True
		Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture1.TabStop = True
		Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Picture1.Name = "Picture1"
		Me.PrBar.BackColor = System.Drawing.SystemColors.Window
		Me.PrBar.ForeColor = System.Drawing.SystemColors.WindowText
		Me.PrBar.Size = New System.Drawing.Size(241, 49)
		Me.PrBar.Location = New System.Drawing.Point(32, 24)
		Me.PrBar.TabIndex = 5
		Me.PrBar.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.PrBar.Dock = System.Windows.Forms.DockStyle.None
		Me.PrBar.CausesValidation = True
		Me.PrBar.Enabled = True
		Me.PrBar.Cursor = System.Windows.Forms.Cursors.Default
		Me.PrBar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PrBar.TabStop = True
		Me.PrBar.Visible = True
		Me.PrBar.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.PrBar.Name = "PrBar"
		ProgressBar.OcxState = CType(resources.GetObject("ProgressBar.OcxState"), System.Windows.Forms.AxHost.State)
		Me.ProgressBar.Size = New System.Drawing.Size(193, 17)
		Me.ProgressBar.Location = New System.Drawing.Point(24, 16)
		Me.ProgressBar.TabIndex = 6
		Me.ProgressBar.Name = "ProgressBar"
		Me.Shape1.Size = New System.Drawing.Size(209, 33)
		Me.Shape1.Location = New System.Drawing.Point(16, 8)
		Me.Shape1.BackColor = System.Drawing.Color.Transparent
		Me.Shape1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Shape1.Visible = True
		Me.Shape1.Name = "Shape1"
		Me.Splitter1.Size = New System.Drawing.Size(137, 337)
		Me.Splitter1.Location = New System.Drawing.Point(72, 88)
		Me.Splitter1.Cursor = System.Windows.Forms.Cursors.SizeWE
		Me.Splitter1.Enabled = True
		Me.Splitter1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Splitter1.Visible = True
		Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Splitter1.Name = "Splitter1"
		Me.Splitter2.Size = New System.Drawing.Size(393, 49)
		Me.Splitter2.Location = New System.Drawing.Point(144, 160)
		Me.Splitter2.Cursor = System.Windows.Forms.Cursors.SizeNS
		Me.Splitter2.Enabled = True
		Me.Splitter2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.Splitter2.Visible = True
		Me.Splitter2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Splitter2.Name = "Splitter2"
		Me.mnFile.Text = "&Файл"
		Me.mnFile.Checked = False
		Me.mnFile.Enabled = True
		Me.mnFile.Visible = True
		Me.mnFile.MDIList = False
		Me.mnuOptions.Text = "&Настройки"
		Me.mnuOptions.Shortcut = System.Windows.Forms.Shortcut.CtrlO
		Me.mnuOptions.Checked = False
		Me.mnuOptions.Enabled = True
		Me.mnuOptions.Visible = True
		Me.mnuOptions.MDIList = False
		Me.h1.Text = "-"
		Me.h1.Checked = False
		Me.h1.Enabled = True
		Me.h1.Visible = True
		Me.h1.MDIList = False
		Me.mncExit.Text = "&Выход"
		Me.mncExit.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
		Me.mncExit.Checked = False
		Me.mncExit.Enabled = True
		Me.mncExit.Visible = True
		Me.mncExit.MDIList = False
		Me.mnEdit.Text = "П&равка"
		Me.mnEdit.Checked = False
		Me.mnEdit.Enabled = True
		Me.mnEdit.Visible = True
		Me.mnEdit.MDIList = False
		Me.mnuFindLetter.Text = "&Поиск Писем"
		Me.mnuFindLetter.Shortcut = System.Windows.Forms.Shortcut.CtrlF
		Me.mnuFindLetter.Checked = False
		Me.mnuFindLetter.Enabled = True
		Me.mnuFindLetter.Visible = True
		Me.mnuFindLetter.MDIList = False
		Me.mnView.Text = "В&ид"
		Me.mnView.Checked = False
		Me.mnView.Enabled = True
		Me.mnView.Visible = True
		Me.mnView.MDIList = False
		Me.mnToolBars.Text = "Панели инструментов"
		Me.mnToolBars.Checked = False
		Me.mnToolBars.Enabled = True
		Me.mnToolBars.Visible = True
		Me.mnToolBars.MDIList = False
		Me.mnStandartToolbar.Text = "Стандартная"
		Me.mnStandartToolbar.Checked = False
		Me.mnStandartToolbar.Enabled = True
		Me.mnStandartToolbar.Visible = True
		Me.mnStandartToolbar.MDIList = False
		Me.H2.Text = "-"
		Me.H2.Checked = False
		Me.H2.Enabled = True
		Me.H2.Visible = True
		Me.H2.MDIList = False
		Me.mncToolBarView.Text = "Вид"
		Me.mncToolBarView.Enabled = False
		Me.mncToolBarView.Checked = False
		Me.mncToolBarView.Visible = True
		Me.mncToolBarView.MDIList = False
		Me.mncToolBarNotTitle.Text = "Без надписей"
		Me.mncToolBarNotTitle.Checked = True
		Me.mncToolBarNotTitle.Enabled = True
		Me.mncToolBarNotTitle.Visible = True
		Me.mncToolBarNotTitle.MDIList = False
		Me.mncToolBarRightTitle.Text = "Надписи сбоку"
		Me.mncToolBarRightTitle.Checked = False
		Me.mncToolBarRightTitle.Enabled = True
		Me.mncToolBarRightTitle.Visible = True
		Me.mncToolBarRightTitle.MDIList = False
		Me.mncToolBarBottomTitle.Text = "Надписи внизу"
		Me.mncToolBarBottomTitle.Checked = False
		Me.mncToolBarBottomTitle.Enabled = True
		Me.mncToolBarBottomTitle.Visible = True
		Me.mncToolBarBottomTitle.MDIList = False
		Me.mnMailList.Text = "Список писем"
		Me.mnMailList.Checked = False
		Me.mnMailList.Enabled = True
		Me.mnMailList.Visible = True
		Me.mnMailList.MDIList = False
		Me.mncTreeMailList.Text = "Деревовидный"
		Me.mncTreeMailList.Checked = True
		Me.mncTreeMailList.Enabled = True
		Me.mncTreeMailList.Visible = True
		Me.mncTreeMailList.MDIList = False
		Me.mncListMailList.Text = "Обычный"
		Me.mncListMailList.Checked = False
		Me.mncListMailList.Enabled = True
		Me.mncListMailList.Visible = True
		Me.mncListMailList.MDIList = False
		Me.mnuMessages.Text = "Сообщение"
		Me.mnuMessages.Checked = False
		Me.mnuMessages.Enabled = True
		Me.mnuMessages.Visible = True
		Me.mnuMessages.MDIList = False
		Me.mnuNewMessage.Text = "Новое Сообщение"
		Me.mnuNewMessage.Shortcut = System.Windows.Forms.Shortcut.F2
		Me.mnuNewMessage.Checked = False
		Me.mnuNewMessage.Enabled = True
		Me.mnuNewMessage.Visible = True
		Me.mnuNewMessage.MDIList = False
		Me.mnuEditMessage.Text = "Изменить"
		Me.mnuEditMessage.Enabled = False
		Me.mnuEditMessage.Checked = False
		Me.mnuEditMessage.Visible = True
		Me.mnuEditMessage.MDIList = False
		Me.mnuDeleteMessage.Text = "Удалить"
		Me.mnuDeleteMessage.Enabled = False
		Me.mnuDeleteMessage.Shortcut = System.Windows.Forms.Shortcut.Del
		Me.mnuDeleteMessage.Checked = False
		Me.mnuDeleteMessage.Visible = True
		Me.mnuDeleteMessage.MDIList = False
		Me.h3.Text = "-"
		Me.h3.Checked = False
		Me.h3.Enabled = True
		Me.h3.Visible = True
		Me.h3.MDIList = False
		Me.mnuAnswer.Text = "Ответить"
		Me.mnuAnswer.Checked = False
		Me.mnuAnswer.Enabled = True
		Me.mnuAnswer.Visible = True
		Me.mnuAnswer.MDIList = False
		Me.mnuReplyNotCit.Text = "Без цитирования"
		Me.mnuReplyNotCit.Enabled = False
		Me.mnuReplyNotCit.Checked = False
		Me.mnuReplyNotCit.Visible = True
		Me.mnuReplyNotCit.MDIList = False
		Me.mnuReplyQuote.Text = "С цитированием"
		Me.mnuReplyQuote.Enabled = False
		Me.mnuReplyQuote.Shortcut = System.Windows.Forms.Shortcut.F4
		Me.mnuReplyQuote.Checked = False
		Me.mnuReplyQuote.Visible = True
		Me.mnuReplyQuote.MDIList = False
		Me.mnuReplyAnotherEcho.Text = "В другую Эху"
		Me.mnuReplyAnotherEcho.Enabled = False
		Me.mnuReplyAnotherEcho.Checked = False
		Me.mnuReplyAnotherEcho.Visible = True
		Me.mnuReplyAnotherEcho.MDIList = False
		Me.mnuTransferMssage.Text = "Переместить"
		Me.mnuTransferMssage.Checked = False
		Me.mnuTransferMssage.Enabled = True
		Me.mnuTransferMssage.Visible = True
		Me.mnuTransferMssage.MDIList = False
		Me.mnuForwardMessage.Text = "Переслать"
		Me.mnuForwardMessage.Enabled = False
		Me.mnuForwardMessage.Checked = False
		Me.mnuForwardMessage.Visible = True
		Me.mnuForwardMessage.MDIList = False
		Me.mnuCopyMessage.Text = "Скопировать"
		Me.mnuCopyMessage.Enabled = False
		Me.mnuCopyMessage.Checked = False
		Me.mnuCopyMessage.Visible = True
		Me.mnuCopyMessage.MDIList = False
		Me.h4.Text = "-"
		Me.h4.Checked = False
		Me.h4.Enabled = True
		Me.h4.Visible = True
		Me.h4.MDIList = False
		Me.mnuPrintMessage.Text = "Печать"
		Me.mnuPrintMessage.Enabled = False
		Me.mnuPrintMessage.Checked = False
		Me.mnuPrintMessage.Visible = True
		Me.mnuPrintMessage.MDIList = False
		Me.mnuPlugin.Text = "&Plugins"
		Me.mnuPlugin.Checked = False
		Me.mnuPlugin.Enabled = True
		Me.mnuPlugin.Visible = True
		Me.mnuPlugin.MDIList = False
		Me._mnuPlugins_0.Text = ""
		Me._mnuPlugins_0.Checked = False
		Me._mnuPlugins_0.Enabled = True
		Me._mnuPlugins_0.Visible = True
		Me._mnuPlugins_0.MDIList = False
		Me.mnuHelp.Text = "&Помощь"
		Me.mnuHelp.Checked = False
		Me.mnuHelp.Enabled = True
		Me.mnuHelp.Visible = True
		Me.mnuHelp.MDIList = False
		Me.mnuAbout.Text = "&О Программе..."
		Me.mnuAbout.Checked = False
		Me.mnuAbout.Enabled = True
		Me.mnuAbout.Visible = True
		Me.mnuAbout.MDIList = False
		Me.mnuCheckUpdate.Text = "&Проверить обновление"
		Me.mnuCheckUpdate.Checked = False
		Me.mnuCheckUpdate.Enabled = True
		Me.mnuCheckUpdate.Visible = True
		Me.mnuCheckUpdate.MDIList = False
		Me.MailContext.Text = "MailContext"
		Me.MailContext.Visible = False
		Me.MailContext.Checked = False
		Me.MailContext.Enabled = True
		Me.MailContext.MDIList = False
		Me.mcRefresh.Text = "Обновить"
		Me.mcRefresh.Checked = False
		Me.mcRefresh.Enabled = True
		Me.mcRefresh.Visible = True
		Me.mcRefresh.MDIList = False
		Me.x1.Text = "-"
		Me.x1.Checked = False
		Me.x1.Enabled = True
		Me.x1.Visible = True
		Me.x1.MDIList = False
		Me.mcOpenMail.Text = "Открыть"
		Me.mcOpenMail.Enabled = False
		Me.mcOpenMail.Checked = False
		Me.mcOpenMail.Visible = True
		Me.mcOpenMail.MDIList = False
		Me.mcChange.Text = "Изменить"
		Me.mcChange.Enabled = False
		Me.mcChange.Checked = False
		Me.mcChange.Visible = True
		Me.mcChange.MDIList = False
		Me.mcSaveMessage.Text = "Сохранить"
		Me.mcSaveMessage.Enabled = False
		Me.mcSaveMessage.Checked = False
		Me.mcSaveMessage.Visible = True
		Me.mcSaveMessage.MDIList = False
		Me.H11.Text = "-"
		Me.H11.Checked = False
		Me.H11.Enabled = True
		Me.H11.Visible = True
		Me.H11.MDIList = False
		Me.mcCopyMail.Text = "Копировать"
		Me.mcCopyMail.Enabled = False
		Me.mcCopyMail.Checked = False
		Me.mcCopyMail.Visible = True
		Me.mcCopyMail.MDIList = False
		Me.mcForwardMail.Text = "Переслать"
		Me.mcForwardMail.Enabled = False
		Me.mcForwardMail.Checked = False
		Me.mcForwardMail.Visible = True
		Me.mcForwardMail.MDIList = False
		Me.mcMoveMail.Text = "Переместить"
		Me.mcMoveMail.Enabled = False
		Me.mcMoveMail.Checked = False
		Me.mcMoveMail.Visible = True
		Me.mcMoveMail.MDIList = False
		Me.h12.Text = "-"
		Me.h12.Checked = False
		Me.h12.Enabled = True
		Me.h12.Visible = True
		Me.h12.MDIList = False
		Me.mcCreateMail.Text = "Создать"
		Me.mcCreateMail.Enabled = False
		Me.mcCreateMail.Checked = False
		Me.mcCreateMail.Visible = True
		Me.mcCreateMail.MDIList = False
		Me.mcDeleteMail.Text = "Удалить"
		Me.mcDeleteMail.Enabled = False
		Me.mcDeleteMail.Checked = False
		Me.mcDeleteMail.Visible = True
		Me.mcDeleteMail.MDIList = False
		Me.h14.Text = "-"
		Me.h14.Checked = False
		Me.h14.Enabled = True
		Me.h14.Visible = True
		Me.h14.MDIList = False
		Me.mcDumpMail.Text = "Дамп Письма"
		Me.mcDumpMail.Enabled = False
		Me.mcDumpMail.Checked = False
		Me.mcDumpMail.Visible = True
		Me.mcDumpMail.MDIList = False
		Me.mcShowKluge.Text = "Кладжи"
		Me.mcShowKluge.Checked = False
		Me.mcShowKluge.Enabled = True
		Me.mcShowKluge.Visible = True
		Me.mcShowKluge.MDIList = False
		Me.mcTerminalFont.Text = "Terminal Font"
		Me.mcTerminalFont.Checked = False
		Me.mcTerminalFont.Enabled = True
		Me.mcTerminalFont.Visible = True
		Me.mcTerminalFont.MDIList = False
		Me.Controls.Add(MailList2)
		Me.Controls.Add(picShow)
		Me.Controls.Add(MailViewerC)
		Me.Controls.Add(ImageList3)
		Me.Controls.Add(ImageList2)
		Me.Controls.Add(StatusBar)
		Me.Controls.Add(CoolBar)
		Me.Controls.Add(MailList)
		Me.Controls.Add(EchoList)
		Me.Controls.Add(Picture1)
		Me.Controls.Add(Splitter1)
		Me.Controls.Add(Splitter2)
		Me.MailViewerC.Controls.Add(MailHead)
		Me.MailViewerC.Controls.Add(MailViewer)
		Me.MailHead.Controls.Add(cmdUUEDec)
		Me.MailHead.Controls.Add(picDec)
		Me.MailHead.Controls.Add(flFromAddr)
		Me.MailHead.Controls.Add(flFrom)
		Me.MailHead.Controls.Add(hfTo)
		Me.CoolBar.Controls.Add(NavigationToolBar)
		Me.NavigationToolBar.Controls.Add(ImageList1)
		Me.Picture1.Controls.Add(PrBar)
		Me.PrBar.Controls.Add(ProgressBar)
		Me.PrBar.Controls.Add(Shape1)
		Me.mnuPlugins.SetIndex(_mnuPlugins_0, CType(0, Short))
		CType(Me.mnuPlugins, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ProgressBar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EchoList, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MailList, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CoolBar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.NavigationToolBar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.StatusBar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImageList2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImageList3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MailViewer, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MailList2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.mnFile.Index = 0
		Me.mnEdit.Index = 1
		Me.mnView.Index = 2
		Me.mnuMessages.Index = 3
		Me.mnuPlugin.Index = 4
		Me.mnuHelp.Index = 5
		Me.MailContext.Index = 6
		MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnFile, Me.mnEdit, Me.mnView, Me.mnuMessages, Me.mnuPlugin, Me.mnuHelp, Me.MailContext})
		Me.mnuOptions.Index = 0
		Me.h1.Index = 1
		Me.mncExit.Index = 2
		mnFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuOptions, Me.h1, Me.mncExit})
		Me.mnuFindLetter.Index = 0
		mnEdit.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuFindLetter})
		Me.mnToolBars.Index = 0
		Me.mnMailList.Index = 1
		mnView.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnToolBars, Me.mnMailList})
		Me.mnStandartToolbar.Index = 0
		Me.H2.Index = 1
		Me.mncToolBarView.Index = 2
		mnToolBars.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnStandartToolbar, Me.H2, Me.mncToolBarView})
		Me.mncToolBarNotTitle.Index = 0
		Me.mncToolBarRightTitle.Index = 1
		Me.mncToolBarBottomTitle.Index = 2
		mncToolBarView.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mncToolBarNotTitle, Me.mncToolBarRightTitle, Me.mncToolBarBottomTitle})
		Me.mncTreeMailList.Index = 0
		Me.mncListMailList.Index = 1
		mnMailList.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mncTreeMailList, Me.mncListMailList})
		Me.mnuNewMessage.Index = 0
		Me.mnuEditMessage.Index = 1
		Me.mnuDeleteMessage.Index = 2
		Me.h3.Index = 3
		Me.mnuAnswer.Index = 4
		Me.mnuTransferMssage.Index = 5
		Me.h4.Index = 6
		Me.mnuPrintMessage.Index = 7
		mnuMessages.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuNewMessage, Me.mnuEditMessage, Me.mnuDeleteMessage, Me.h3, Me.mnuAnswer, Me.mnuTransferMssage, Me.h4, Me.mnuPrintMessage})
		Me.mnuReplyNotCit.Index = 0
		Me.mnuReplyQuote.Index = 1
		Me.mnuReplyAnotherEcho.Index = 2
		mnuAnswer.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuReplyNotCit, Me.mnuReplyQuote, Me.mnuReplyAnotherEcho})
		Me.mnuForwardMessage.Index = 0
		Me.mnuCopyMessage.Index = 1
		mnuTransferMssage.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuForwardMessage, Me.mnuCopyMessage})
		Me._mnuPlugins_0.Index = 0
		mnuPlugin.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me._mnuPlugins_0})
		Me.mnuAbout.Index = 0
		Me.mnuCheckUpdate.Index = 1
		mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuAbout, Me.mnuCheckUpdate})
		Me.mcRefresh.Index = 0
		Me.x1.Index = 1
		Me.mcOpenMail.Index = 2
		Me.mcChange.Index = 3
		Me.mcSaveMessage.Index = 4
		Me.H11.Index = 5
		Me.mcCopyMail.Index = 6
		Me.mcForwardMail.Index = 7
		Me.mcMoveMail.Index = 8
		Me.h12.Index = 9
		Me.mcCreateMail.Index = 10
		Me.mcDeleteMail.Index = 11
		Me.h14.Index = 12
		Me.mcDumpMail.Index = 13
		Me.mcShowKluge.Index = 14
		Me.mcTerminalFont.Index = 15
		MailContext.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mcRefresh, Me.x1, Me.mcOpenMail, Me.mcChange, Me.mcSaveMessage, Me.H11, Me.mcCopyMail, Me.mcForwardMail, Me.mcMoveMail, Me.h12, Me.mcCreateMail, Me.mcDeleteMail, Me.h14, Me.mcDumpMail, Me.mcShowKluge, Me.mcTerminalFont})
		Me.Menu = MainMenu1
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmMain
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmMain
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmMain()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
	Dim dx, dy As Short
	Dim frmELWidth As Short 'Ширина фрейма с названиями эх
	Dim frmTVHeight As Short 'Высота фрейма с письмами
	Dim Splitter1Resize, Splitter2Resize As Boolean
	Dim MOldX, MOldY As Short
	
	Const frmMinELWidth As Integer = 3 'px
	Const frmMinTVHeight As Integer = 3 'px
	Const BorderSize As Integer = 3 'Ширина бордюра в px
	
	Dim jbd As New jamBase 'создаем объект доступа
	Dim msg As New msgBase 'создаем объект доступа
	Dim squ As New sqBase 'создаем объект доступа
	
	Dim flg As Boolean 'Cancel flag
	Dim num As Integer
	Dim MsgN() As Integer 'Хранит порядковые номера мессаг при добавлении
	Dim sEchos() As String 'тут храниться список эх
	Dim mOldCount As Integer 'Тут хранится число мессаг которое есть в эхе, исспользуется при рефреше.
	
	Dim MLStr As String 'а это способ отображения списка писем  - [ListView|TreeView] эту переменную не стоит изменять через события меню, т.к. при построении списка писемпользователь может изменить вид отображения меню
	
	Private Enum ShowType
		MainForm = 0 'в гравной форме
		EditorForm = 1 'в окне редактора
	End Enum
	
	'in subitems(4)
	Private Enum BaseType
		Netmail = 1 'MSG база
		Squish = 2 'Squish Base
		Jam = 3 'JAM база
	End Enum
	
	'получает список выбранных эх
	Public WriteOnly Property SelectedEchos() As String()
		Set(ByVal Value() As String)
			sEchos = VB6.CopyArray(Value)
		End Set
	End Property
	
	'Возвращает полный путь к файлу с текущей выбранной эхой
	Public ReadOnly Property CurrentEchoFile() As String
		Get
			'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoFileByName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			CurrentEchoFile = clsEchos.GetEchoFileByName(EchoList.SelectedItem.Text)
		End Get
	End Property
	
	Private Sub ReadSettings()
		On Error GoTo errHandler
		Dim bs As String
		Dim cl() As String
		
		msgModeratorColor = CInt(GetGFEOption("Options", "msgModeratorColor", CStr(&HFF00)))
		msgRulesColor = CInt(GetGFEOption("Options", "msgRulesColor", CStr(&H40FF00)))
		msgAlienCitatColor = CInt(GetGFEOption("Options", "AlienCitatColor", CStr(&HFFFF)))
		msgMainTextColor = CInt(GetGFEOption("Options", "MainTextColor", CStr(&HC0C0C0)))
		msgBackColor = CInt(GetGFEOption("Options", "BackMessageColor", CStr(0)))
		msgMyCitatColor = CInt(GetGFEOption("Options", "MyCitatColor", CStr(&HFFFFFF)))
		msgMyMessagesColor = CInt(GetGFEOption("Options", "MyMessagesColor", CStr(&H80000002)))
		msgTaglineColor = CInt(GetGFEOption("Options", "TaglineColor", CStr(&HFFFFFF)))
		msgTirlineColor = CInt(GetGFEOption("Options", "TirlineColor", CStr(&HFFs)))
		msgOriginColor = CInt(GetGFEOption("Options", "OriginColor", CStr(&HFFFFFF)))
		
		'загрузка фонтов
		cl = Split(GetGFEOption("Fonts", "EcholistFont", "Times New Roman - Regular - 8pt"), " - ")
		EchoList.Font = VB6.FontChangeName(EchoList.Font, cl(0))
		
		If InStr(1, cl(1), " ") <> 0 Then 'сочитание стилей
			EchoList.Font = VB6.FontChangeBold(EchoList.Font, True)
			EchoList.Font = VB6.FontChangeItalic(EchoList.Font, True)
		Else			
            If InStr(1, cl(1), "Bold", CompareMethod.Text) <> 0 Then
                EchoList.Font = VB6.FontChangeBold(EchoList.Font, True)
            Else
                EchoList.Font = VB6.FontChangeBold(EchoList.Font, False)
            End If

            If InStr(1, cl(1), "Italic", CompareMethod.Text) <> 0 Then
                EchoList.Font = VB6.FontChangeItalic(EchoList.Font, True)
            Else
                EchoList.Font = VB6.FontChangeItalic(EchoList.Font, False)
            End If
		End If
		
		EchoList.Font = VB6.FontChangeSize(EchoList.Font, CDec(Mid(cl(2), 1, Len(cl(2)) - 2)))
		
		cl = Split(GetGFEOption("Fonts", "TreeViewFont", "MS Sans Serif - Regular - 8pt"), " - ")
		MailList.Font = VB6.FontChangeName(MailList.Font, cl(0))
		MailList2.Font = VB6.FontChangeName(MailList2.Font, cl(0))
		
		If InStr(1, cl(1), " ") <> 0 Then 'сочитание стилей
			MailList.Font = VB6.FontChangeBold(MailList.Font, True)
			MailList.Font = VB6.FontChangeItalic(MailList.Font, True)
			MailList2.Font = VB6.FontChangeBold(MailList2.Font, True)
			MailList2.Font = VB6.FontChangeItalic(MailList2.Font, True)
		Else
			
			If InStr(1, cl(1), "Bold", CompareMethod.Text) <> 0 Then
				MailList.Font = VB6.FontChangeBold(MailList.Font, True)
				MailList2.Font = VB6.FontChangeBold(MailList2.Font, True)
			Else
                MailList.Font = VB6.FontChangeBold(MailList.Font, False)
				MailList2.Font = VB6.FontChangeBold(MailList2.Font, False)
			End If
			
			If InStr(1, cl(1), "Italic", CompareMethod.Text) <> 0 Then
				MailList.Font = VB6.FontChangeItalic(MailList.Font, True)
				MailList2.Font = VB6.FontChangeItalic(MailList2.Font, True)
			Else
				MailList.Font = VB6.FontChangeItalic(MailList.Font, False)
				MailList2.Font = VB6.FontChangeItalic(MailList2.Font, False)
			End If
		End If
		
		MailList.Font = VB6.FontChangeSize(MailList.Font, CDec(Mid(cl(2), 1, Len(cl(2)) - 2)))
		MailList2.Font = VB6.FontChangeSize(MailList2.Font, CDec(Mid(cl(2), 1, Len(cl(2)) - 2)))
		
		cl = Split(GetGFEOption("Fonts", "MainTextViewFont", "MS Sans Serif - Regular - 8pt"), " - ")
		MailViewer.Font = VB6.FontChangeName(MailViewer.Font, cl(0))
		
		If InStr(1, cl(1), " ") <> 0 Then 'сочитание стилей
			MailViewer.Font = VB6.FontChangeBold(MailViewer.Font, True)
			MailViewer.Font = VB6.FontChangeItalic(MailViewer.Font, True)
		Else
			
			If InStr(1, cl(1), "Bold", CompareMethod.Text) <> 0 Then
				MailViewer.Font = VB6.FontChangeBold(MailViewer.Font, True)
			Else
				MailViewer.Font = VB6.FontChangeBold(MailViewer.Font, False)
			End If
			
			If InStr(1, cl(1), "Italic", CompareMethod.Text) <> 0 Then
				MailViewer.Font = VB6.FontChangeItalic(MailViewer.Font, True)
			Else
				MailViewer.Font = VB6.FontChangeItalic(MailViewer.Font, False)
			End If
		End If
		
		MailViewer.Font = VB6.FontChangeSize(MailViewer.Font, CDec(Mid(cl(2), 1, Len(cl(2)) - 2)))
		
		bs = GetGFEOption("Options", "MailListView", "TreeView")
		
		Select Case bs
			
			Case "TreeView"
				mncTreeMailList.Checked = True
				mncListMailList.Checked = False
				MailList.Visible = True
				MailList2.Visible = False
				
			Case "ListView"
				mncTreeMailList.Checked = False
				mncListMailList.Checked = True
				MailList.Visible = False
				MailList2.Visible = True
				
		End Select
		
		MailViewer.CtlRefresh()
		MailList.CtlRefresh()
		MailList2.CtlRefresh()
		
		Erase cl
		
		System.Windows.Forms.Application.DoEvents()
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::ReadSettings")
		End Select
		
	End Sub
	
	Public Sub LoadEchoList()
		Dim LI As MSComctlLib.ListItem
		Dim netmC As Integer
		Dim sumnew, sum, optC As Integer
		Dim ECNum As Integer
		Dim nmSel As Boolean
		Dim lrEcho As String
		Static fl As Boolean
		
		If Not fl Then
			
			EchoList.ListItems.Clear()
			
			System.Windows.Forms.Application.DoEvents()
			
			LockWindowUpdate(EchoList.hWnd) 'ставим залочку
			
			lrEcho = GetGFEOption("LastRead", "Echo", "Netmail")
			nmSel = True
			
			'если неймей должен быть на верху:
			If LCase(GetGFEOption("Options", "NetmailPosition", "Bottom")) = "top" Then
				netmC = 0
				While Len(GetGFEOption("Options", "Netmail Dir" & netmC)) <> 0
					LI = EchoList.ListItems.Add( , "r" & CStr(clsEchos.EchosCount + 1 + netmC), GetGFEOption("Options", "Netmail Name" & netmC, "Netmail" & netmC),  , 1)
					LI.let_Tag(GetGFEOption("Options", "Netmail Dir" & netmC, "C:\T-Mail\Mail"))
					LI.SubItems(1) = CStr(msg.MessageCountByEcho((LI.Tag)))
					LI.SubItems(2) = "Netmail Area"
					LI.ToolTipText = "Netmail Area"
					LI.SubItems(3) = GetGFEOption("Options", "MainAddress")
					LI.SubItems(4) = CStr(1)
					sum = sum + CDbl(LI.SubItems(1))
					
					netmC = netmC + 1
				End While
				
				'проверяем есть ли новые письма и если есть выделяем их жирным шрифтом
				optC = CInt(GetGFEOption("LastRead\Echos", (LI.Text), LI.SubItems(1)))
				
				If optC < CDbl(LI.SubItems(1)) Then
					'добавились
					LI.Bold = True
					sumnew = sumnew + (CDbl(LI.SubItems(1)) - optC)
				Else
					'удалились
				End If
				
				PutGFEOption("LastRead\Echos", (LI.Text), LI.SubItems(1))
				
			End If
			
			System.Windows.Forms.Application.DoEvents()
			
			For ECNum = 1 To clsEchos.EchosCount

                If Not (clsEchos Is Nothing) Then

                    LI = EchoList.ListItems.Add(, "r" & CStr(ECNum), clsEchos.GetEchoNameByNum(ECNum), , 1)
                    frmStart.DefInstance.lblEcho.Text = clsEchos.GetEchoNameByNum(ECNum)

                    Select Case clsEchos.GetEchoTypeByNum(ECNum)

                        Case BaseType.Jam
                            LI.SubItems(1) = CStr(jbd.MessageCountByEcho(clsEchos.GetEchoFileByNum(ECNum)))

                        Case BaseType.Squish
                            LI.SubItems(1) = CStr(squ.MessageCountByEcho(clsEchos.GetEchoFileByNum(ECNum)))

                        Case BaseType.Netmail
                            'тут это для наглядности
                    End Select

                    LI.SubItems(2) = clsEchos.GetEchoDescriptionByNum(ECNum)
                    LI.SubItems(3) = clsEchos.GetEchoAkAByNum(ECNum)
                    LI.SubItems(4) = clsEchos.GetEchoTypeByNum(ECNum)
                    LI.ToolTipText = clsEchos.GetEchoDescriptionByNum(ECNum)

                    'проверяем есть ли новые письма и если есть выделяем их жирным шрифтом
                    optC = CInt(GetGFEOption("LastRead\Echos", (LI.Text), LI.SubItems(1)))

                    If optC < CDbl(LI.SubItems(1)) Then
                        'добавились письма
                        LI.Bold = True
                        sumnew = sumnew + (CDbl(LI.SubItems(1)) - optC)
                    Else
                        'письма удалились
                    End If

                    PutGFEOption("LastRead\Echos", (LI.Text), LI.SubItems(1))

                    System.Windows.Forms.Application.DoEvents()

                    If Not (clsEchos Is Nothing) Then
                        If lrEcho = clsEchos.GetEchoNameByNum(ECNum) Then
                            LI.Selected = True
                            LI.EnsureVisible()
                            nmSel = False
                        End If

                        sum = sum + CDbl(LI.SubItems(1))

                    End If

                Else
                    Exit Sub
                End If

            Next
			
			'или посденей эхой
			If LCase(GetGFEOption("Options", "NetmailPosition", "Bottom")) = "bottom" Then
				netmC = 0
				While Len(GetGFEOption("Options", "Netmail Dir" & netmC)) <> 0
					LI = EchoList.ListItems.Add( , "r" & CStr(ECNum + netmC), GetGFEOption("Options", "Netmail Name" & netmC, "Netmail" & netmC),  , 1)
					LI.let_Tag(GetGFEOption("Options", "Netmail Dir" & netmC, "C:\T-Mail\Mail"))
					LI.SubItems(1) = CStr(msg.MessageCountByEcho((LI.Tag)))
					LI.SubItems(2) = "Netmail Area"
					LI.ToolTipText = "Netmail Area"
					LI.SubItems(3) = GetGFEOption("Options", "MainAddress")
					LI.SubItems(4) = CStr(1)
					sum = sum + CDbl(LI.SubItems(1))
					
					netmC = netmC + 1
				End While
				
				'проверяем есть ли новые письма и если есть выделяем их жирным шрифтом
				optC = CInt(GetGFEOption("LastRead\Echos", (LI.Text), LI.SubItems(1)))
				
				If optC < CDbl(LI.SubItems(1)) Then
					'добавились
					LI.Bold = True
					sumnew = sumnew + (CDbl(LI.SubItems(1)) - optC)
				Else
					'удалились
				End If
				
				PutGFEOption("LastRead\Echos", (LI.Text), LI.SubItems(1))
				
				If nmSel Then
					LI.Selected = True
					LI.EnsureVisible()
				End If
			End If
			
			frmStart.DefInstance.lblEcho.Text = "Netmail"
			StatusBar.Panels(1).Text = "Новых " & CStr(sumnew) & ", всего " & CStr(sum) & " писем в " & CStr(clsEchos.EchosCount + 1) & " эхах"
			
			System.Windows.Forms.Application.DoEvents()
			
			LI = Nothing
			fl = True
			
			LockWindowUpdate(0) 'снимаем залочку
			
		End If
	End Sub
	
	Private Sub cmdUUEDec_Click(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles cmdUUEDec.Click
		On Error GoTo errHandler
		Dim strdata, msgText, SaveFile As String
		Dim fn, st, ff As Integer
		Dim RegEx As New VBScript_RegExp_55.RegExp ' РегЭкспы
		Dim colMatches As VBScript_RegExp_55.MatchCollection ' коллекция этих образцов
		Dim aMatch As VBScript_RegExp_55.Match ' один из совпавших образцов
		
		RegEx.MultiLine = True ' многострочный текст
		RegEx.[Global] = True ' будем проходить всю строку
		RegEx.IgnoreCase = True ' игнорируем регистр символов
		
		Select Case EchoList.SelectedItem.SubItems(4)
			
			Case CStr(BaseType.Jam)
				msgText = jbd.Message
				
			Case CStr(BaseType.Netmail)
				msgText = msg.Message
				
			Case CStr(BaseType.Squish)
				msgText = squ.Message
		End Select
		
		'поищем формат в виде begin 6xx filename
		RegEx.Pattern = "(begin 6\d\d) (\w.+?)\s"
		colMatches = RegEx.Execute(msgText)
		
		If colMatches.Count > 0 Then
			'единичная секция присутствует
			aMatch = colMatches.item(0)
			st = aMatch.FirstIndex + Len(aMatch.Value) + 1
			fn = InStr(st, msgText, "end" & vbCr, CompareMethod.Text) - 1
			
			'есть ли конец у секции?
			If fn < 0 Then
				strdata = DecodeUUEData(Replace(Mid(msgText, st, fn - st), vbCr, vbCrLf))
				msgText = vbNullString
				
				modCommonDialog.hwndOwner = Me.Handle.ToInt32
				modCommonDialog.SaveDialogTitle = "Сохранение раскодированного UUE файла..."
				modCommonDialog.Filter_Renamed = "All Files (*.*)|*.*|"
				modCommonDialog.Flags = cdlOFNHideReadOnly
				modCommonDialog.FilterIndex = 1
				
				'UPGRADE_WARNING: Couldn't resolve default property of object aMatch.SubMatches(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				SaveFile = modCommonDialog.ShowSave(VB6.GetPath & "\", CStr(aMatch.SubMatches(1)))
				
				If Len(SaveFile) <> 0 Then
					ff = FreeFile
					FileOpen(ff, SaveFile, OpenMode.Binary)
					'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
					FilePut(ff, strdata)
					FileClose(ff)
				End If
			End If 'fn < 0
		End If 'colm > 0
		
		'UPGRADE_NOTE: Object colMatches may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		colMatches = Nothing
		'UPGRADE_NOTE: Object aMatch may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		aMatch = Nothing
		'UPGRADE_NOTE: Object RegEx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		RegEx = Nothing
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::cmdUUEDec_Click")
		End Select
		
	End Sub
	
	Public Sub EchoList_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComctlLib.ListViewEvents_MouseUpEvent) Handles EchoList.MouseUpEvent
		On Error GoTo errHandler
		Static prg As Boolean
		
		Select Case eventArgs.Button
			
			Case VB6.MouseButtonConstants.LeftButton
				'перезагрузка смайлов
				Call modTextWork.LoadSmiles()
				
				'помечаем эху как прочитанную
				EchoList.SelectedItem.Bold = False
				
				System.Windows.Forms.Application.DoEvents()
				
				If Not prg Then
					prg = True
					
					Call DefaultState()
					
					num = 1
					
					Select Case EchoList.SelectedItem.SubItems(4)
						
						Case CStr(BaseType.Jam)
							
							If rdb_ext = 1 Then
								'UPGRADE_WARNING: Couldn't resolve default property of object rdb.DBName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								rdb.DBName = Me.CurrentEchoFile()
							End If
							
							jbd.DBName = Me.CurrentEchoFile()
							jbd.OpenDB()
							num = jbd.GetLastReadMsgNum
							
							If num < 0 And num <> -30920 And num <> -1444879 Then
								'MsgBox "Error! " & num, vbCritical, App.Title & " - frmMain::EchoList_Click"
								Exit Sub
							End If
							
							If jbd.MessageCount >= 1 Then
								'а нужна ли тут теперь эта проверка?
								'If jbd.MessageCount > CLng(EchoList.SelectedItem.SubItems(1)) Then
								'при загрузке эхи произошла ошибка и счетчик писем теперь имеет левое значение
								'нужно его исправить
								'   jbd.MessageCount = CLng(EchoList.SelectedItem.SubItems(1))
								'End If
								mOldCount = jbd.MessageCount
								'UPGRADE_WARNING: Lower bound of array MsgN was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1033"'
								ReDim MsgN(jbd.MessageCount + 10)
								ShowMail(num)
								
								If flg Then
									flg = False
								Else
									flg = True
								End If
								
								CreateMailList(BaseType.Jam)
								
								If num = 0 Then num = 1
								If num <= jbd.MessageCount And MsgN(num) > 0 Then
									
									Select Case MLStr
										
										Case "TreeView"
											MailList.Nodes(MsgN(num)).Selected = True
											MailList.SelectedItem.EnsureVisible()
											
										Case "ListView"
											MailList2.ListItems(MsgN(1)).Selected = False 'отключае выделение по умолчанию для 1го мессага
											MailList2.ListItems(MsgN(num)).Selected = True
											MailList2.SelectedItem.EnsureVisible()
									End Select
									
								End If
								
								'разрешаем пользоваться контекстным меню
								mcOpenMail.Enabled = True
								mcChange.Enabled = True
								mcCopyMail.Enabled = True
								mcForwardMail.Enabled = True
								mcMoveMail.Enabled = True
								mcCreateMail.Enabled = True
								mcDeleteMail.Enabled = True
								mcDumpMail.Enabled = True
								mcSaveMessage.Enabled = True
								
							Else
								Call DefaultState()
								
							End If
							
						Case CStr(BaseType.Netmail)
							
							'кликнули на нетмейле
							If rdb_ext = 1 Then
								'UPGRADE_WARNING: Couldn't resolve default property of object rdb.DBName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								rdb.DBName = EchoList.SelectedItem.Tag & "\" & "netmail.rdb"
							End If
							
							'UPGRADE_WARNING: Couldn't resolve default property of object EchoList.SelectedItem.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							msg.DBName = EchoList.SelectedItem.Tag
							msg.OpenDB()
							
							If msg.MessageCount <> 0 Then
								num = msg.GetLastReadMsgNum
								mOldCount = num 'запоминаем для рефреша
								'UPGRADE_WARNING: Lower bound of array MsgN was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1033"'
								ReDim MsgN(msg.MessageCount)
								ShowMail(num,  , BaseType.Netmail)
								CreateMailList(BaseType.Netmail)
								
								If num <= msg.MessageCount Then
									
									Select Case MLStr
										
										Case "TreeView"
											MailList.Nodes(MsgN(num)).Selected = True
											MailList.SelectedItem.EnsureVisible()
											
										Case "ListView"
											MailList2.ListItems(MsgN(num)).Selected = True
											MailList2.SelectedItem.EnsureVisible()
									End Select
									
								End If
								
								'разрешаем пользоваться контекстным меню
								mcOpenMail.Enabled = True
								mcChange.Enabled = True
								mcCopyMail.Enabled = True
								mcForwardMail.Enabled = True
								mcMoveMail.Enabled = True
								mcCreateMail.Enabled = True
								mcDeleteMail.Enabled = True
								mcDumpMail.Enabled = True
								mcSaveMessage.Enabled = True
							Else
								Call DefaultState()
								
							End If
							
						Case CStr(BaseType.Squish)
							
							If rdb_ext = 1 Then
								'UPGRADE_WARNING: Couldn't resolve default property of object rdb.DBName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								rdb.DBName = Me.CurrentEchoFile()
							End If
							
							squ.DBName = Me.CurrentEchoFile()
							squ.OpenDB()
							
							If squ.MessageCount >= 1 Then
								mOldCount = squ.MessageCount
								'UPGRADE_WARNING: Lower bound of array MsgN was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1033"'
								ReDim MsgN(squ.MessageCount + 10)
								ShowMail(num,  , BaseType.Squish)
								
								If flg Then
									flg = False
								Else
									flg = True
								End If
								
								CreateMailList(BaseType.Squish)
								
								num = squ.GetLastReadMsgNum
								
								If num = 0 Then num = 1
								If num <= squ.MessageCount Then
									
									Select Case MLStr
										
										Case "TreeView"
											MailList.Nodes(MsgN(num)).Selected = True
											MailList.SelectedItem.EnsureVisible()
											
										Case "ListView"
											MailList2.ListItems(MsgN(num)).Selected = True
											MailList2.SelectedItem.EnsureVisible()
									End Select
									
								End If
								
								'разрешаем пользоваться контекстным меню
								mcOpenMail.Enabled = True
								mcChange.Enabled = True
								mcCopyMail.Enabled = True
								mcForwardMail.Enabled = True
								mcMoveMail.Enabled = True
								mcCreateMail.Enabled = True
								mcDeleteMail.Enabled = True
								mcDumpMail.Enabled = True
								mcSaveMessage.Enabled = True
								
							Else
								Call DefaultState()
								
							End If
							
					End Select
					
				End If
				
				System.Windows.Forms.Application.DoEvents()
				mnuReplyNotCit.Enabled = True
				mnuReplyQuote.Enabled = True
				mnuReplyAnotherEcho.Enabled = True
				mnuForwardMessage.Enabled = True
				mnuCopyMessage.Enabled = True
				mnuEditMessage.Enabled = True
				
				prg = False
				
			Case VB6.MouseButtonConstants.RightButton
				
				'display conf info
				With frmAreaInfo.DefInstance
					
					'infos
					.AreaName = EchoList.SelectedItem.Text
					'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoNumByName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoUplinkByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					.AreaUplink = clsEchos.GetEchoUplinkByNum(clsEchos.GetEchoNumByName(EchoList.SelectedItem.Text))
					
					Select Case CInt(EchoList.SelectedItem.SubItems(4))
						
						Case BaseType.Netmail
							'UPGRADE_WARNING: Couldn't resolve default property of object EchoList.SelectedItem.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							.AreaPath = EchoList.SelectedItem.Tag
							.AreaType = "Netmail"
							
						Case BaseType.Jam
							'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoFileByName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							.AreaPath = clsEchos.GetEchoFileByName(EchoList.SelectedItem.Text)
							.AreaType = "Jam"
							
						Case BaseType.Squish
							'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoFileByName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							.AreaPath = clsEchos.GetEchoFileByName(EchoList.SelectedItem.Text)
							.AreaType = "Squish"
							
						Case Else
							.AreaType = "Хрень :)"
							
					End Select
					
					.Top = VB6.TwipsToPixelsY(EchoList.SelectedItem.Top + VB6.PixelsToTwipsY(EchoList.Top) * 3)
					.Left = VB6.TwipsToPixelsX(EchoList.ColumnHeaders(1).Width * 0.125)
					
					If VB6.PixelsToTwipsY(.Top) > VB6.PixelsToTwipsY(.Top) - VB6.PixelsToTwipsY(.Height) Then .Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(.Top) - VB6.PixelsToTwipsY(.Height))
					If VB6.PixelsToTwipsY(.Top) < VB6.PixelsToTwipsY(.Height) Then .Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(.Top) + VB6.PixelsToTwipsY(.Height))
					VB6.ShowForm(frmAreaInfo.DefInstance, VB6.FormShowConstants.Modal, Me)
				End With
				
		End Select
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::EchoList_MouseUp")
		End Select
		
	End Sub
	
	'устанавливает состояние по умолчанию для всех контролов
	Private Sub DefaultState()
		
		Select Case MLStr
			
			Case "TreeView"
				LockWindowUpdate(MailList.hWnd) 'ставим залочку
				MailList.Nodes.Clear()
				
			Case "ListView"
				LockWindowUpdate(MailList2.hWnd)
				MailList2.ListItems.Clear()
				
		End Select
		
		MailViewer.Text = ""
		flFrom.Text = "От кого: "
		hfTo.Text = "Кому: "
		MailHead.Text = "Письма отсутствуют"
		flFromAddr.Text = "Адрес: "
		
		LockWindowUpdate(0) 'снимаем залочку
		
	End Sub
	
	Private Sub EchoList_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles EchoList.DblClick
		Sleep(250)
	End Sub
	
	Private Sub EchoList_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComctlLib.ListViewEvents_KeyDownEvent) Handles EchoList.KeyDownEvent
		On Error GoTo errHandler
		Dim lType As String
		Dim oldNum As Integer
		
		If EchoList.SelectedItem.SubItems(1) = "0" Then
			
			'отвечать просто неначто, но таки можно создавать письмо
			If eventArgs.KeyCode = System.Windows.Forms.Keys.F2 Or eventArgs.KeyCode = System.Windows.Forms.Keys.Insert Then
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						ViewMail(jbd, num, modCommon.ReplayMode.NewMail)
						
					Case CStr(BaseType.Netmail)
						ViewMail(msg, num, modCommon.ReplayMode.NewMail)
						
					Case CStr(BaseType.Squish)
						'ненужно пока включать
						'ViewMail squ, num, NewMail
				End Select
				
			End If
			
			Exit Sub
		End If
		
		lType = GetGFEOption("Options", "MailListView", "TreeView")
		
		Select Case eventArgs.KeyCode
			
			Case System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.NumPad4
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						
						If num > 1 Then
							num = num - 1
							ShowMail(num,  , BaseType.Jam)
							oldNum = num + 1
						End If
						
					Case CStr(BaseType.Netmail)
						
						If num > 1 Then
							num = num - 1
							ShowMail(num,  , BaseType.Netmail)
							oldNum = num + 1
						End If
						
					Case CStr(BaseType.Squish)
						
						If num > 1 Then
							num = num - 1
							ShowMail(num,  , BaseType.Squish)
							oldNum = num + 1
						End If
						
				End Select
				
			Case System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.NumPad6
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						
						If num < jbd.MessageCount Then
							num = num + 1
							ShowMail(num,  , BaseType.Jam)
							oldNum = num - 1
						End If
						
					Case CStr(BaseType.Netmail)
						
						If num < msg.MessageCount Then
							num = num + 1
							ShowMail(num,  , BaseType.Netmail)
							oldNum = num - 1
						End If
						
					Case CStr(BaseType.Squish)
						
						If num < squ.MessageCount Then
							num = num + 1
							ShowMail(num,  , BaseType.Squish)
							oldNum = num - 1
						End If
						
				End Select
				
			Case System.Windows.Forms.Keys.F2
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						ViewMail(jbd, num, modCommon.ReplayMode.NewMail)
						
					Case CStr(BaseType.Netmail)
						ViewMail(msg, num, modCommon.ReplayMode.NewMail)
						
					Case CStr(BaseType.Squish)
						'ненужно пока включать
						'ViewMail squ, num, NewMail
				End Select
				
			Case System.Windows.Forms.Keys.F4
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						ViewMail(jbd, num, modCommon.ReplayMode.ReplayFrom)
						
					Case CStr(BaseType.Netmail)
						ViewMail(msg, num, modCommon.ReplayMode.ReplayFrom)
						
					Case CStr(BaseType.Squish)
						'ненужно пока включать
						'ViewMail squ, num, ReplayFrom
				End Select
				
			Case System.Windows.Forms.Keys.Return
				EchoList_MouseUpEvent(EchoList, New AxMSComctlLib.ListViewEvents_MouseUpEvent(VB6.MouseButtonConstants.LeftButton, 0, 0, 0))
				
			Case System.Windows.Forms.Keys.NumPad8 'vbKeyUp
				modCommon.SendMessage(MailViewer.hWnd, WM_VSCROLL, SB_LINEUP, 0)
				
			Case System.Windows.Forms.Keys.NumPad2 'vbKeyDown
				modCommon.SendMessage(MailViewer.hWnd, WM_VSCROLL, SB_LINEDOWN, 0)
				
		End Select
		
		Select Case lType
			
			Case "TreeView"
				MailList.Nodes(MsgN(num)).Selected = True
				MailList.Nodes(MsgN(num)).EnsureVisible()
				MailList.Nodes(MsgN(num)).Image = 2
				
			Case "ListView"
				MailList2.ListItems(MsgN(num)).Selected = True
				MailList2.ListItems(MsgN(num)).EnsureVisible()
				MailList2.ListItems(MsgN(num)).SmallIcon = 2
				
				If oldNum <> 0 Then
					MailList2.ListItems(MsgN(oldNum)).Selected = False
				End If
				
		End Select
		
		System.Windows.Forms.Application.DoEvents()
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::EchoList_KeyDown")
		End Select
		
	End Sub
	
	Private Sub frmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		On Error GoTo errHandler
		Dim Path As String
		Dim optC As Integer
		
		Call modCommon.Main_Renamed()
		
		App.Title = "GoldFidoExplorer " & CStr(System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMajorPart) & "." & CStr(System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMinorPart) & " build " & CStr(App.Revision)
		Me.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name
		
		Splitter1Resize = False
		Splitter2Resize = False
		
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width) > 0 And Me.WindowState <> System.Windows.Forms.FormWindowState.Maximized Then
			'        Me.left = (Screen.Width - Me.Width) \ 2
			Me.Left = VB6.TwipsToPixelsX(CSng(GetGFEOption("Screen\Main", "X", CStr((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) \ 2))))
		End If
		
		If VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height) > 0 And Me.WindowState <> System.Windows.Forms.FormWindowState.Maximized Then
			'        Me.top = (Screen.Height - Me.Height) \ 2
			Me.Top = VB6.TwipsToPixelsY(CSng(GetGFEOption("Screen\Main", "Y", CStr((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) \ 2))))
		End If
		
		If Me.WindowState <> System.Windows.Forms.FormWindowState.Maximized Then
			Me.Width = VB6.TwipsToPixelsX(CSng(GetGFEOption("Screen\Main", "Width", CStr(VB6.PixelsToTwipsX(Me.Width)))))
			Me.Height = VB6.TwipsToPixelsY(CSng(GetGFEOption("Screen\Main", "Height", CStr(VB6.PixelsToTwipsY(Me.Height)))))
			Me.WindowState = CInt(GetGFEOption("Screen\Main", "WindowState", CStr(Me.WindowState)))
		End If
		
		dx = VB6.TwipsPerPixelX
		dy = VB6.TwipsPerPixelY
		
		'Читаем из реестра размеры фреймов главного окна
		frmELWidth = CSng(GetGFEOption("Screen\Main", "ELSplitter", CStr(235 * dx)))
		frmTVHeight = CSng(GetGFEOption("Screen\Main", "TVSplitter", CStr(200 * dy)))
		'Читаем размеры колонок для "обычного" режима просмотра
		MailList2.ColumnHeaders.item(1).Width = CSng(GetGFEOption("Screen\Main", "wcSubj", CStr(4000)))
		MailList2.ColumnHeaders.item(2).Width = CSng(GetGFEOption("Screen\Main", "wcFrom", CStr(1800)))
		MailList2.ColumnHeaders.item(3).Width = CSng(GetGFEOption("Screen\Main", "wcTo", CStr(1800)))
		
		CalcSize()
		
		frmStart.DefInstance.OnTop = True
		Call frmStart.DefInstance.Show()
		
		Me.Show()
		
		Path = GetGFEOption("Options", "cfgMsgBase", "")
		optC = 0
		While Len(Path) = 0
			frmOptions.DefInstance.ShowDialog()
			Path = GetGFEOption("Options", "cfgMsgBase", vbNullString)
			
			If Len(Path) = 0 Then
				MsgBox("Путь к файлу конфикурации Базы Писем не должен Пустым!", MsgBoxStyle.Exclamation, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
			End If
			
			If optC > 0 Then
				Path = "Fictive"
				frmOptions.DefInstance.Close()
				Me.Close()
				Exit Sub
			End If
			
			optC = optC + 1
		End While
		
		'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.ConfigFile. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		clsEchos.ConfigFile = Path
		'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.ParseConfig. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		clsEchos.ParseConfig()
		
		ReadSettings() 'читаем настройки
		LoadEchoList() 'читаем список эх
		
		MailViewer.SelColor = msgMainTextColor
		MailViewer.BackColor = System.Drawing.ColorTranslator.FromOle(msgBackColor)
		
		System.Windows.Forms.Application.DoEvents()
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::Form_Load")
		End Select
		
	End Sub
	
	Private Sub flFrom_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles flFrom.Click
		On Error Resume Next
		
		If LCase(flFrom.Text) <> "от кого" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object AddrBk.FindContact. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If AddrBk.FindContact( , Mid(flFrom.Text, 9)) Then
				'такой контакт уже есть
				'UPGRADE_WARNING: Couldn't resolve default property of object AddrBk.DisplayContacts. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				AddrBk.DisplayContacts(Mid(flFromAddr.Text, 1, InStr(1, flFromAddr.Text, " ") - 1))
			Else
				'нету
				'UPGRADE_WARNING: Couldn't resolve default property of object AddrBk.DisplayAddContacts. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				AddrBk.DisplayAddContacts(Mid(flFromAddr.Text, 1, InStr(1, flFromAddr.Text, " ") - 1), Mid(flFrom.Text, 9))
			End If
			
			If Err.Number = 91 Then
				MsgBox("Плугин AddrBook.dll не зарегистрирован или не найден.", MsgBoxStyle.Exclamation, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
			End If
		End If
		
	End Sub
	
	Private Sub flFrom_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles flFrom.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		If LCase(flFrom.Text) <> "от кого" Then
			
			With flFrom
				'UPGRADE_ISSUE: Label property flFrom.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
				.MouseIcon = VB6.LoadResPicture(1, VB6.LoadResConstants.ResCursor)
				'UPGRADE_ISSUE: Label property flFrom.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2036"'
				.Cursor = vbCustom
			End With
			
		End If
		
	End Sub
	
	Private Sub hfTo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles hfTo.Click
		On Error Resume Next
		
		If LCase(hfTo.Text) <> "кому" And LCase(Trim(Mid(hfTo.Text, 7))) <> "all" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object AddrBk.FindContact. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If AddrBk.FindContact( , Mid(hfTo.Text, 7)) Then
				'такой контакт уже есть
				'UPGRADE_WARNING: Couldn't resolve default property of object AddrBk.DisplayContacts. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				AddrBk.DisplayContacts( , Mid(hfTo.Text, 7))
			Else
				'нету
				'UPGRADE_WARNING: Couldn't resolve default property of object AddrBk.DisplayAddContacts. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				AddrBk.DisplayAddContacts( , Mid(hfTo.Text, 7))
			End If
			
			If Err.Number = 91 Then
				MsgBox("Плугин AddrBook.dll не зарегистрирован или не найден.", MsgBoxStyle.Exclamation, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
			End If
		End If
		
	End Sub
	
	Private Sub hfTo_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles hfTo.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		If LCase(hfTo.Text) <> "кому" And LCase(Trim(Mid(hfTo.Text, 7))) <> "all" Then
			
			With hfTo
				'UPGRADE_ISSUE: Label property hfTo.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
				.MouseIcon = VB6.LoadResPicture(1, VB6.LoadResConstants.ResCursor)
				'UPGRADE_ISSUE: Label property hfTo.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2036"'
				.Cursor = vbCustom
			End With
			
		End If
		
	End Sub
	
	Private Sub CalcSize()
		Dim fh, fw As Short
		Dim brdX, brdY As Short
		
		brdX = BorderSize * dx
		brdY = BorderSize * dy
		
		fh = VB6.PixelsToTwipsY(Me.ClientRectangle.Height)
		fw = VB6.PixelsToTwipsX(Me.ClientRectangle.Width)
		
		System.Windows.Forms.Application.DoEvents()
		
		If Me.WindowState = System.Windows.Forms.FormWindowState.Minimized Then
			Exit Sub
		End If
		
		'Кое-какие проверки для реализации сплиттера
		If frmELWidth <= frmMinELWidth * dx Then
			frmELWidth = frmMinELWidth * dx
			
			If EchoList.Visible = True Then EchoList.Visible = False
			'Splitter1Resize = False
		Else
			
			If EchoList.Visible = False Then EchoList.Visible = True
		End If
		
		If frmTVHeight > fh - VB6.PixelsToTwipsY(NavigationToolBar.Height) - VB6.PixelsToTwipsY(StatusBar.Height) - (brdY * 2) Then
			frmTVHeight = fh - VB6.PixelsToTwipsY(NavigationToolBar.Height) - VB6.PixelsToTwipsY(StatusBar.Height) - (brdY * 2)
		End If
		
		If frmTVHeight <= frmMinTVHeight * dy Then
			frmTVHeight = frmMinTVHeight * dy
			
			If Picture1.Visible = True Then
				Picture1.Visible = False
				MailList.Visible = False
				MailList2.Visible = False
			End If
			
			System.Windows.Forms.Application.DoEvents()
		Else
			
			If Picture1.Visible = False Then
				Picture1.Visible = True
				MailList.Visible = True
				MailList2.Visible = True
			End If
		End If
		
		System.Windows.Forms.Application.DoEvents()
		
		EchoList.SetBounds(0, CoolBar.Height, VB6.TwipsToPixelsX(frmELWidth), 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y Or Windows.Forms.BoundsSpecified.Width)
		
		If fh - VB6.PixelsToTwipsY(StatusBar.Height) - VB6.PixelsToTwipsY(CoolBar.Height) < 0 Then
			EchoList.Height = 0
			Splitter1.Height = 0
		Else
			EchoList.Height = VB6.TwipsToPixelsY(fh - VB6.PixelsToTwipsY(StatusBar.Height) - VB6.PixelsToTwipsY(CoolBar.Height))
			Splitter1.SetBounds(VB6.TwipsToPixelsX(frmELWidth), CoolBar.Height, VB6.TwipsToPixelsX(brdX + dx), VB6.TwipsToPixelsY(fh - VB6.PixelsToTwipsY(StatusBar.Height) - VB6.PixelsToTwipsY(CoolBar.Height)))
		End If
		
		System.Windows.Forms.Application.DoEvents()
		
		If fw - frmELWidth - brdX >= 0 Then
			
			MailList.SetBounds(VB6.TwipsToPixelsX(frmELWidth + brdX), CoolBar.Height, VB6.TwipsToPixelsX(fw - frmELWidth - brdX), VB6.TwipsToPixelsY(frmTVHeight))
			
			'Ресайзим MailList2 - это для недеревовидного отображения списка писем
			MailList2.SetBounds(VB6.TwipsToPixelsX(frmELWidth + brdX), CoolBar.Height, VB6.TwipsToPixelsX(fw - frmELWidth - brdX), VB6.TwipsToPixelsY(frmTVHeight))
			
			System.Windows.Forms.Application.DoEvents()
			
			Picture1.SetBounds(VB6.TwipsToPixelsX(frmELWidth + brdX), CoolBar.Height, VB6.TwipsToPixelsX(fw - frmELWidth - brdX), VB6.TwipsToPixelsY(frmTVHeight))
			
		End If
		
		System.Windows.Forms.Application.DoEvents()
		
		PrBar.SetBounds(VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(Picture1.ClientRectangle.Width) - VB6.PixelsToTwipsX(PrBar.Width)) \ 2), VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(Picture1.ClientRectangle.Height) - VB6.PixelsToTwipsY(PrBar.Height)) \ 2), 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
		
		MailViewerC.SetBounds(VB6.TwipsToPixelsX(frmELWidth + brdX), VB6.TwipsToPixelsY(frmTVHeight + VB6.PixelsToTwipsY(CoolBar.Height) + brdY), 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
		
		System.Windows.Forms.Application.DoEvents()
		
		If fh - VB6.PixelsToTwipsY(CoolBar.Height) - VB6.PixelsToTwipsY(StatusBar.Height) - frmTVHeight - brdY < 0 Then
			MailViewerC.Height = 0
		Else
			MailViewerC.Height = VB6.TwipsToPixelsY(fh - VB6.PixelsToTwipsY(CoolBar.Height) - VB6.PixelsToTwipsY(StatusBar.Height) - frmTVHeight - brdY)
		End If
		
		System.Windows.Forms.Application.DoEvents()
		
		If fw - frmELWidth - brdX < 0 Then
			MailViewerC.Width = 0
		Else
			Splitter2.SetBounds(VB6.TwipsToPixelsX(frmELWidth + brdX), VB6.TwipsToPixelsY(frmTVHeight + VB6.PixelsToTwipsY(CoolBar.Height) - dy), VB6.TwipsToPixelsX(fw - frmELWidth - brdX), VB6.TwipsToPixelsY(brdY + (dy * 2)))
			MailViewerC.Width = VB6.TwipsToPixelsX(fw - frmELWidth - brdX)
		End If
		
		System.Windows.Forms.Application.DoEvents()
		
	End Sub
	
	'UPGRADE_WARNING: Form event frmMain.QueryUnload has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
	Private Sub frmMain_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
		Dim Cancel As Short = eventArgs.Cancel
		On Error Resume Next
		Dim GotoVal As Integer
		Dim Gointo As Integer
		
		'Проверку не убирать!!!!!!!
		If Me.WindowState = vbNormal Then
            PutGFEOption("Screen\Main", "X", Str(VB6.PixelsToTwipsX(Me.Left)))
            PutGFEOption("Screen\Main", "Y", Str(VB6.PixelsToTwipsY(Me.Top)))
            PutGFEOption("Screen\Main", "Width", Str(VB6.PixelsToTwipsX(Me.Width)))
            PutGFEOption("Screen\Main", "Height", Str(VB6.PixelsToTwipsY(Me.Height)))
        End If
		
		PutGFEOption("Screen\Main", "WindowState", Str(Me.WindowState))
		PutGFEOption("Screen\Main", "ELSplitter", Str(frmELWidth))
		PutGFEOption("Screen\Main", "TVSplitter", Str(frmTVHeight))
		
		'listwiew columns
		PutGFEOption("Screen\Main", "wcSubj", CStr(MailList2.ColumnHeaders.item(1).Width))
		PutGFEOption("Screen\Main", "wcFrom", CStr(MailList2.ColumnHeaders.item(2).Width))
		PutGFEOption("Screen\Main", "wcTo", CStr(MailList2.ColumnHeaders.item(3).Width))
		
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		GotoVal = VB6.PixelsToTwipsY(Me.Height) / 2
		
		For Gointo = 1 To GotoVal
			
			System.Windows.Forms.Application.DoEvents()
			Me.SetBounds(Me.Left, VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) \ 2), Me.Width, VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Height) - 300))
			
			If VB6.PixelsToTwipsY(Me.Height) <= 500 Then Exit For
		Next Gointo
		
horiz: 
		Me.Height = VB6.TwipsToPixelsY(30)
		GotoVal = VB6.PixelsToTwipsX(Me.Width) / 2
		
		For Gointo = 1 To GotoVal
			
			System.Windows.Forms.Application.DoEvents()
			Me.SetBounds(VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) \ 2), Me.Top, VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Width) - 300), 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y Or Windows.Forms.BoundsSpecified.Width)
			
			If VB6.PixelsToTwipsX(Me.Width) <= 2000 Then Exit For
		Next Gointo
		
		'скрываем форму и начинаем процесс очистки классов
		Me.Hide()
		PutGFEOption("LastRead", "Echo", EchoList.SelectedItem.Text)
		
		eventArgs.Cancel = Cancel
	End Sub
	
	'UPGRADE_WARNING: Event frmMain.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub frmMain_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		CalcSize()
	End Sub
	
	Private Sub CoolBar_HeightChanged(ByVal eventSender As System.Object, ByVal eventArgs As AxComCtl3.__CoolBar_HeightChangedEvent) Handles CoolBar.HeightChanged
		CalcSize()
	End Sub
	
	'UPGRADE_WARNING: Form event frmMain.Unload has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
	Private Sub frmMain_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
		On Error GoTo errHandler
		Dim msgc, ECNum As Integer
		Dim Proc As String
		Dim frm As System.Windows.Forms.Form
		
		'проверяем не установлен ли повальный запуск процессов
		Proc = GetGFEOption("Options\Process", "ExtProcess")
		
		If GetGFEOption("Options\Process", "AllowExternal", "0") = "1" Then
			
			Select Case GetGFEOption("Options\Process", "StartUpType", "1") = "1"
				
				Case CBool("0") 'always
					
					'запустим процесс
					If Len(Proc) <> 0 Then
						ShellExecute(Me.Handle.ToInt32, vbNullString, Proc, GetGFEOption("Options\Process", "ExtProcessParams", vbNullString), vbNullString, SW_SHOWMINNOACTIVE)
						
						System.Windows.Forms.Application.DoEvents()
					End If
					
				Case CBool("1") 'change
					
					'проверяем изменения в эхе и запускаем процесссы.
					'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.EchosCount. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					For ECNum = 1 To clsEchos.EchosCount
						
						'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoTypeByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						Select Case clsEchos.GetEchoTypeByNum(ECNum)
							
							Case BaseType.Netmail
								
								'тут это для наглядности
							Case BaseType.Jam
								'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoFileByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								msgc = jbd.MessageCountByEcho(clsEchos.GetEchoFileByNum(ECNum))
								
							Case BaseType.Squish
								'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoFileByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								msgc = squ.MessageCountByEcho(clsEchos.GetEchoFileByNum(ECNum))
						End Select
						
						'проверяем есть ли новые письма и если есть и разрешен запуск процесса, то
						'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoNameByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						If CDbl(GetGFEOption("LastRead\Echos", clsEchos.GetEchoNameByNum(ECNum), CStr(msgc))) < msgc Then
							
							'запустим процесс
							If Len(Proc) <> 0 Then
								ShellExecute(Me.Handle.ToInt32, vbNullString, Proc, GetGFEOption("Options\Process", "ExtProcessParams", vbNullString), vbNullString, SW_SHOWMINNOACTIVE)
								
								System.Windows.Forms.Application.DoEvents()
							End If
							
							'и выйдем т.к. обычно после этого делать нечего
							Exit For
						End If
						
					Next ECNum
					
			End Select
			
		End If
		
		'Ищем не закрытые формы редактора и выгружаем их.
		'UPGRADE_ISSUE: Forms collection was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2068"'
		For	Each frm In Forms
			
			Select Case frm.Name
				
				Case "frmMailEditor"
					Call frmMailEditor.DefInstance.UnloadMe()
					
				Case "frmStart"
					'будет в этом списке в случае когда на форме кликнули досрочно
					Call frmStart.DefInstance.UnloadMe()
			End Select
			
		Next frm
		
		'UPGRADE_NOTE: Object jbd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		jbd = Nothing
		'UPGRADE_NOTE: Object msg may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		msg = Nothing
		'UPGRADE_NOTE: Object squ may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		squ = Nothing
		'UPGRADE_NOTE: Object AddrBk may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		AddrBk = Nothing
		'UPGRADE_NOTE: Object clsEchos may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		clsEchos = Nothing
		'и кладем плугины
		
		On Error Resume Next
		msgc = UBound(Plugins)
		
		If Err.Number <> 0 Then
			msgc = -1
		End If
		
		For ECNum = 0 To msgc
			'UPGRADE_NOTE: Object Plugins() may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
			Plugins(ECNum) = Nothing
			mnuPlugins.Unload(ECNum + 1)
		Next ECNum
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::Form_Unload")
		End Select
		
	End Sub
	
	Private Sub MailList_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MailList.DblClick
		On Error GoTo errHandler
		Dim nodeCurrent As MSComctlLib.Node
		Dim Key As String
		
		nodeCurrent = MailList.SelectedItem
		
		If Not nodeCurrent Is Nothing Then
			'UPGRADE_WARNING: Couldn't resolve default property of object nodeCurrent.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Key = nodeCurrent.Tag
			nodeCurrent.Image = 2
			
			Select Case Mid(Key, 1, 1)
				
				Case "r", "c" 'Echomail
					num = CInt(Mid(Key, 2, Len(Key) - 2))
					ShowMail(num, ShowType.EditorForm, BaseType.Jam)
					
				Case "N" 'Netmail
					ShowMail(num, ShowType.EditorForm, BaseType.Netmail)
					
				Case "S" 'Squish
					ShowMail(num, ShowType.EditorForm, BaseType.Squish)
			End Select
			
		End If
		
		'UPGRADE_NOTE: Object nodeCurrent may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		nodeCurrent = Nothing
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 91
				EchoList_MouseUpEvent(EchoList, New AxMSComctlLib.ListViewEvents_MouseUpEvent(VB6.MouseButtonConstants.LeftButton, 0, 0, 0))
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::MailList_DblClick")
		End Select
		
	End Sub
	
	Private Sub MailList_KeyUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComctlLib.ITreeViewEvents_KeyUpEvent) Handles MailList.KeyUpEvent
		On Error GoTo errHandler
		Dim Key As String
		
		'UPGRADE_WARNING: Couldn't resolve default property of object MailList.SelectedItem.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Key = MailList.SelectedItem.Tag
		MailList.SelectedItem.Image = 2
		num = CInt(Mid(Key, 2, Len(Key) - 2))
		
		Select Case eventArgs.KeyCode
			
			Case System.Windows.Forms.Keys.Up
				
				Select Case Mid(Key, 1, 1)
					
					Case "r", "c" 'Echomail
						ShowMail(num)
						
					Case "N" 'Netmail
						ShowMail(num,  , BaseType.Netmail)
						
					Case "S" 'Squish
						ShowMail(num,  , BaseType.Squish)
				End Select
				
			Case System.Windows.Forms.Keys.Down
				
				'Key = MailList.SelectedItem.Tag
				'num = Val(Mid$(Key, 2, Len(Key) - 2))
				Select Case Mid(Key, 1, 1)
					
					Case "r", "c" 'Echomail
						ShowMail(num)
						
					Case "N" 'Netmail
						ShowMail(num,  , BaseType.Netmail)
						
					Case "S" 'Squish
						ShowMail(num,  , BaseType.Squish)
				End Select
		End Select
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 91
				EchoList_MouseUpEvent(EchoList, New AxMSComctlLib.ListViewEvents_MouseUpEvent(VB6.MouseButtonConstants.LeftButton, 0, 0, 0))
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::MailList_KeyUp")
		End Select
		
	End Sub
	
	Private Sub MailList2_DblClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MailList2.DblClick
		On Error GoTo errHandler
		Dim Current As MSComctlLib.ListItem
		Dim Key As String
		
		Current = MailList2.SelectedItem
		
		If Not Current Is Nothing Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Current.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Key = Current.Tag
			Current.SmallIcon = 2
			
			Select Case Mid(Key, 1, 1)
				
				Case "r", "c" 'Echomail
					num = CInt(Mid(Key, 2, Len(Key) - 2))
					ShowMail(num, ShowType.EditorForm, BaseType.Jam)
					
				Case "N" 'Netmail
					ShowMail(num, ShowType.EditorForm, BaseType.Netmail)
					
				Case "S" 'Squish
					ShowMail(num, ShowType.EditorForm, BaseType.Squish)
			End Select
			
		End If
		
		'UPGRADE_NOTE: Object Current may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		Current = Nothing
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 91
				EchoList_MouseUpEvent(EchoList, New AxMSComctlLib.ListViewEvents_MouseUpEvent(VB6.MouseButtonConstants.LeftButton, 0, 0, 0))
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::MailList2_DblClick")
		End Select
		
	End Sub
	
	Public Sub MailList_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MailList.ClickEvent
		On Error GoTo errHandler
		Dim nodeCurrent As MSComctlLib.Node
		Dim Key As String
		
		nodeCurrent = MailList.SelectedItem
		
		If Not nodeCurrent Is Nothing Then
			'UPGRADE_WARNING: Couldn't resolve default property of object nodeCurrent.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Key = nodeCurrent.Tag
			nodeCurrent.Image = 2
			num = CInt(Mid(Key, 2, Len(Key) - 2))
			
			Select Case Mid(Key, 1, 1)
				
				Case "r", "c" 'Echomail
					ShowMail(num)
					
				Case "N" 'Netmail
					ShowMail(num,  , BaseType.Netmail)
					
				Case "S" 'Squish
					ShowMail(num,  , BaseType.Squish)
			End Select
			
		End If
		
		'UPGRADE_NOTE: Object nodeCurrent may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		nodeCurrent = Nothing
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 91
				EchoList_MouseUpEvent(EchoList, New AxMSComctlLib.ListViewEvents_MouseUpEvent(VB6.MouseButtonConstants.LeftButton, 0, 0, 0))
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::MailList_Click")
		End Select
		
	End Sub
	
	Public Sub MailList2_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MailList2.ClickEvent
		On Error GoTo errHandler
		
		Dim Current As MSComctlLib.ListItem
		Dim Key As String
		
		Current = MailList2.SelectedItem
		
		If Not Current Is Nothing Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Current.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Key = Current.Tag
			Current.SmallIcon = 2
			num = CInt(Mid(Key, 2, Len(Key) - 2))
			
			Select Case Mid(Key, 1, 1)
				
				Case "r", "c" 'Echomail
					ShowMail(num)
					
				Case "N" 'Netmail
					ShowMail(num,  , BaseType.Netmail)
					
				Case "S" 'Squish
					ShowMail(num,  , BaseType.Squish)
			End Select
			
		End If
		
		'UPGRADE_NOTE: Object Current may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		Current = Nothing
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 91
				EchoList_MouseUpEvent(EchoList, New AxMSComctlLib.ListViewEvents_MouseUpEvent(VB6.MouseButtonConstants.LeftButton, 0, 0, 0))
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::MailList2_Click")
		End Select
		
	End Sub
	
	Private Sub MailList_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComctlLib.ITreeViewEvents_KeyDownEvent) Handles MailList.KeyDownEvent
		On Error GoTo errHandler
		Dim Key As String
		Dim pmsg As msg
		
		'UPGRADE_WARNING: Couldn't resolve default property of object MailList.SelectedItem.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Key = MailList.SelectedItem.Tag
		MailList.SelectedItem.Image = 2
		num = CInt(Mid(Key, 2, Len(Key) - 2))
		
		While PeekMessage(pmsg, MailList.hWnd, 0, 0, PM_REMOVE) <> 0
			
			System.Windows.Forms.Application.DoEvents()
		End While
		
		Select Case eventArgs.KeyCode
			
			Case System.Windows.Forms.Keys.Up
				
				Select Case Mid(Key, 1, 1)
					
					Case "r", "c" 'Echomail
						ShowMail(num)
						
					Case "N" 'Netmail
						ShowMail(num,  , BaseType.Netmail)
						
					Case "S" 'Squish
						ShowMail(num,  , BaseType.Squish)
				End Select
				
			Case System.Windows.Forms.Keys.Down
				
				'Key = MailList.SelectedItem.Tag
				'num = Val(Mid$(Key, 2, Len(Key) - 2))
				Select Case Mid(Key, 1, 1)
					
					Case "r", "c" 'Echomail
						ShowMail(num)
						
					Case "N" 'Netmail
						ShowMail(num,  , BaseType.Netmail)
						
					Case "S" 'Squish
						ShowMail(num,  , BaseType.Squish)
				End Select
				
			Case System.Windows.Forms.Keys.F5
				EchoList_MouseUpEvent(EchoList, New AxMSComctlLib.ListViewEvents_MouseUpEvent(VB6.MouseButtonConstants.LeftButton, 0, 0, 0))
				
			Case System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.Insert
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						ViewMail(jbd, num, modCommon.ReplayMode.NewMail)
						
					Case CStr(BaseType.Netmail)
						ViewMail(msg, num, modCommon.ReplayMode.NewMail)
						
					Case CStr(BaseType.Squish)
						'ненужно пока включать
						'ViewMail squ, num, NewMail
				End Select
				
			Case System.Windows.Forms.Keys.F4
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						ViewMail(jbd, num, modCommon.ReplayMode.ReplayFrom)
						
					Case CStr(BaseType.Netmail)
						ViewMail(msg, num, modCommon.ReplayMode.ReplayFrom)
						
					Case CStr(BaseType.Squish)
						'ненужно пока включать
						'ViewMail squ, num, ReplayFrom
				End Select
				
			Case System.Windows.Forms.Keys.Delete
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						jbd.DeleteMessageByNum(CInt(Mid(MailList.SelectedItem.Tag, 2, Len(MailList.SelectedItem.Tag) - 2)))
						MailList.SelectedItem.Image = 4
						
					Case CStr(BaseType.Netmail)
						msg.DeleteMessageByNum(CInt(Mid(MailList.SelectedItem.Tag, 2, Len(MailList.SelectedItem.Tag) - 2)))
						MailList.SelectedItem.Image = 4
						
					Case CStr(BaseType.Squish)
						'ненужно пока включать
						'squ.DeleteMessageByNum Val(Mid$(MailList.SelectedItem.Tag, 2, Len(MailList.SelectedItem.Tag) - 2))
				End Select
				
				'Case vbKey1, vbKey2, vbKey3, vbKey4, vbKey5, vbKey6, vbKey7, vbKey8, vbKey9, vbKey0
				'        MsgBox "Digit"
				
			Case System.Windows.Forms.Keys.NumPad8 'vbKeyUp
				modCommon.SendMessage(MailViewer.hWnd, WM_VSCROLL, SB_LINEUP, 0)
				
			Case System.Windows.Forms.Keys.NumPad2 'vbKeyDown
				modCommon.SendMessage(MailViewer.hWnd, WM_VSCROLL, SB_LINEDOWN, 0)
				
		End Select
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 91
				EchoList_MouseUpEvent(EchoList, New AxMSComctlLib.ListViewEvents_MouseUpEvent(VB6.MouseButtonConstants.LeftButton, 0, 0, 0))
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::MailList_KeyUp")
		End Select
		
	End Sub
	
	Private Sub MailList_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComctlLib.ITreeViewEvents_MouseUpEvent) Handles MailList.MouseUpEvent
		
		If eventArgs.Button = VB6.MouseButtonConstants.RightButton Then
			mcSaveMessage.Enabled = False 'тут это пока ненадо
			'UPGRADE_ISSUE: Form method frmMain.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			PopupMenu(MailContext,  ,  ,  , mcOpenMail)
		End If
		
	End Sub
	
	Private Sub MailList2_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComctlLib.ListViewEvents_MouseUpEvent) Handles MailList2.MouseUpEvent
		
		If eventArgs.Button = VB6.MouseButtonConstants.RightButton Then
			'UPGRADE_ISSUE: Form method frmMain.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			PopupMenu(MailContext,  ,  ,  , mcOpenMail)
		End If
		
	End Sub
	
	Private Sub MailList2_KeyUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComctlLib.ListViewEvents_KeyUpEvent) Handles MailList2.KeyUpEvent
		On Error GoTo errHandler
		Dim Key As String
		
		'UPGRADE_WARNING: Couldn't resolve default property of object MailList2.SelectedItem.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Key = MailList2.SelectedItem.Tag
		
		If MailList2.SelectedItem.SmallIcon <> 4 Then
			MailList2.SelectedItem.SmallIcon = 2
		End If
		
		num = CInt(Mid(Key, 2, Len(Key) - 2))
		
		Select Case eventArgs.KeyCode
			
			Case System.Windows.Forms.Keys.Up
				
				Select Case Mid(Key, 1, 1)
					
					Case "r", "c" 'Echomail
						ShowMail(num)
						
					Case "N" 'Netmail
						ShowMail(num,  , BaseType.Netmail)
						
					Case "S" 'squish
						ShowMail(num,  , BaseType.Squish)
				End Select
				
			Case System.Windows.Forms.Keys.Down
				
				Select Case Mid(Key, 1, 1)
					
					Case "r", "c" 'Echomail
						ShowMail(num)
						
					Case "N" 'Netmail
						ShowMail(num,  , BaseType.Netmail)
						
					Case "S" 'squish
						ShowMail(num,  , BaseType.Squish)
				End Select
				
			Case System.Windows.Forms.Keys.Add '+
				
				Select Case Mid(Key, 1, 1)
					
					Case "r", "c" 'Echomail
						jbd.GetHeadesByNumForTree(num)
						
						If jbd.ReplayFirst > 0 Then
							MailList2.ListItems(MsgN(num)).Selected = False
							num = jbd.ReplayFirst
							ShowMail(num)
							MailList2.ListItems(MsgN(num)).Selected = True
							MailList2.ListItems(MsgN(num)).EnsureVisible()
						End If
						
					Case "N" 'Netmail
						
						'
					Case "S" 'squish
						'
				End Select
				
			Case System.Windows.Forms.Keys.Subtract '-
				
				Select Case Mid(Key, 1, 1)
					
					Case "r", "c" 'Echomail
						jbd.GetHeadesByNumForTree(num)
						
						If jbd.ReplayTo > 0 Then
							MailList2.ListItems(MsgN(num)).Selected = False
							num = jbd.ReplayTo
							ShowMail(num)
							MailList2.ListItems(MsgN(num)).Selected = True
							MailList2.ListItems(MsgN(num)).EnsureVisible()
						End If
						
					Case "N" 'Netmail
						
						'
					Case "S" 'squish
						'
				End Select
				
			Case System.Windows.Forms.Keys.Multiply '*
				
				Select Case Mid(Key, 1, 1)
					
					Case "r", "c" 'Echomail
						jbd.GetHeadesByNumForTree(num)
						
						If jbd.ReplayNext > 0 Then
							MailList2.ListItems(MsgN(num)).Selected = False
							num = jbd.ReplayNext
							ShowMail(num)
							MailList2.ListItems(MsgN(num)).Selected = True
							MailList2.ListItems(MsgN(num)).EnsureVisible()
						End If
						
					Case "N" 'Netmail
						
						'
					Case "S" 'squish
						'
				End Select
				
		End Select
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 91
				EchoList_MouseUpEvent(EchoList, New AxMSComctlLib.ListViewEvents_MouseUpEvent(VB6.MouseButtonConstants.LeftButton, 0, 0, 0))
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::MailList2_KeyUp")
		End Select
		
	End Sub
	
	Private Sub MailList2_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComctlLib.ListViewEvents_KeyDownEvent) Handles MailList2.KeyDownEvent
		On Error GoTo errHandler
		Dim pmsg As msg
		Dim Key As String
		
		'UPGRADE_WARNING: Couldn't resolve default property of object MailList2.SelectedItem.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Key = MailList2.SelectedItem.Tag
		
		If MailList2.SelectedItem.SmallIcon <> 4 Then
			MailList2.SelectedItem.SmallIcon = 2
		End If
		
		num = CInt(Mid(Key, 2, Len(Key) - 2))
		
		While PeekMessage(pmsg, MailList2.hWnd, 0, 0, PM_REMOVE) <> 0
			
			System.Windows.Forms.Application.DoEvents()
		End While
		
		Select Case eventArgs.KeyCode
			
			Case System.Windows.Forms.Keys.F5
				EchoList_MouseUpEvent(EchoList, New AxMSComctlLib.ListViewEvents_MouseUpEvent(VB6.MouseButtonConstants.LeftButton, 0, 0, 0))
				
			Case System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.Insert
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						ViewMail(jbd, num, modCommon.ReplayMode.NewMail)
						
					Case CStr(BaseType.Netmail)
						ViewMail(msg, num, modCommon.ReplayMode.NewMail)
						
					Case CStr(BaseType.Squish)
						'ненужно пока включать
						'ViewMail squ, num, NewMail
				End Select
				
			Case System.Windows.Forms.Keys.F4
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						ViewMail(jbd, num, modCommon.ReplayMode.ReplayFrom)
						
					Case CStr(BaseType.Netmail)
						ViewMail(msg, num, modCommon.ReplayMode.ReplayFrom)
						
					Case CStr(BaseType.Squish)
						'ненужно пока включать
						'ViewMail squ, num, ReplayFrom
				End Select
				
			Case System.Windows.Forms.Keys.Delete
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						jbd.DeleteMessageByNum(CInt(Mid(MailList2.SelectedItem.Tag, 2, Len(MailList2.SelectedItem.Tag) - 2)))
						MailList2.SelectedItem.SmallIcon = 4
						
					Case CStr(BaseType.Netmail)
						msg.DeleteMessageByNum(CInt(Mid(MailList2.SelectedItem.Tag, 2, Len(MailList2.SelectedItem.Tag) - 2)))
						MailList2.SelectedItem.SmallIcon = 4
						
					Case CStr(BaseType.Squish)
						'ненужно пока включать
						'squ.DeleteMessageByNum Val(Mid$(MailList2.SelectedItem.Tag, 2, Len(MailList2.SelectedItem.Tag) - 2))
				End Select
				
				'Case vbKey1, vbKey2, vbKey3, vbKey4, vbKey5, vbKey6, vbKey7, vbKey8, vbKey9, vbKey0
				'        MsgBox "Digit"
				
			Case System.Windows.Forms.Keys.NumPad8 'vbKeyUp
				modCommon.SendMessage(MailViewer.hWnd, WM_VSCROLL, SB_LINEUP, 0)
				
			Case System.Windows.Forms.Keys.NumPad2 'vbKeyDown
				modCommon.SendMessage(MailViewer.hWnd, WM_VSCROLL, SB_LINEDOWN, 0)
				
		End Select
		
		System.Windows.Forms.Application.DoEvents()
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 91
				EchoList_MouseUpEvent(EchoList, New AxMSComctlLib.ListViewEvents_MouseUpEvent(VB6.MouseButtonConstants.LeftButton, 0, 0, 0))
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::MailList2_KeyUp")
		End Select
		
	End Sub
	
	Private Sub MailViewer_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MailViewer.ClickEvent
		On Error GoTo errHandler
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim RegEx As New VBScript_RegExp_55.RegExp
		Dim str_Renamed As String
		Dim colMatches As VBScript_RegExp_55.MatchCollection ' коллекция этих образцов
		
		RegEx.IgnoreCase = True 'игнорируем регистр символов
		RegEx.Pattern = "\d+:\d+/\d+\.{0,1}\d*" 'шаблон для выборки 4D адреса из 5D
		
		str_Renamed = RichWordClick(MailViewer)
		
		If RegEx.Test(str_Renamed) Then
			colMatches = RegEx.Execute(str_Renamed)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_WARNING: Couldn't resolve default property of object AddrBk.FindContact. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If AddrBk.FindContact(CStr(colMatches.item(0).Value)) Then
				'есть
				'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				'UPGRADE_WARNING: Couldn't resolve default property of object AddrBk.DisplayContacts. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				AddrBk.DisplayContacts(CStr(colMatches.item(0).Value))
			Else
				
				'нет
				'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				If MsgBox("Контакт с адресом: " & CStr(colMatches.item(0).Value) & " не найден!" & vbCrLf & "Добавить?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name) = MsgBoxResult.Yes Then
					'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					'UPGRADE_WARNING: Couldn't resolve default property of object AddrBk.DisplayAddContacts. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					AddrBk.DisplayAddContacts(CStr(colMatches.item(0).Value))
				End If
			End If
		End If
		
		'UPGRADE_NOTE: Object RegEx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		RegEx = Nothing
		'UPGRADE_NOTE: Object colMatches may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		colMatches = Nothing
		
		System.Windows.Forms.Application.DoEvents()
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 91
				MsgBox("Плагин AddrBook.dll не зарегистрирован или не найден.", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::MailViewer_Click")
		End Select
		
	End Sub
	
	Private Sub MailViewer_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxRichTextLib.DRichTextEvents_KeyDownEvent) Handles MailViewer.KeyDownEvent
		
		Select Case eventArgs.KeyCode
			
			Case System.Windows.Forms.Keys.NumPad8 'vbKeyUp
				modCommon.SendMessage(MailViewer.hWnd, WM_VSCROLL, SB_LINEUP, 0)
				
			Case System.Windows.Forms.Keys.NumPad2 'vbKeyDown
				modCommon.SendMessage(MailViewer.hWnd, WM_VSCROLL, SB_LINEDOWN, 0)
				
		End Select
		
	End Sub
	
	Private Sub MailViewer_KeyUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxRichTextLib.DRichTextEvents_KeyUpEvent) Handles MailViewer.KeyUpEvent
		On Error GoTo errHandler
		Dim Key As String
		
		Select Case GetGFEOption("Options", "MailListView", "TreeView")
			
			Case "ListView"
				'UPGRADE_WARNING: Couldn't resolve default property of object MailList2.SelectedItem.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				Key = MailList2.SelectedItem.Tag
				num = CInt(Mid(Key, 2, Len(Key) - 2))
				
				Select Case eventArgs.KeyCode
					
					Case System.Windows.Forms.Keys.Add '+
						
						Select Case Mid(Key, 1, 1)
							
							Case "r", "c" 'Echomail
								jbd.GetHeadesByNumForTree(num)
								
								If jbd.ReplayFirst > 0 Then
									MailList2.ListItems(MsgN(num)).Selected = False
									num = jbd.ReplayFirst
									ShowMail(num)
									MailList2.ListItems(MsgN(num)).Selected = True
									MailList2.ListItems(MsgN(num)).EnsureVisible()
								End If
								
							Case "N" 'Netmail
								
								'
							Case "S" 'squish
								'
						End Select
						
					Case System.Windows.Forms.Keys.Subtract '-
						
						Select Case Mid(Key, 1, 1)
							
							Case "r", "c" 'Echomail
								jbd.GetHeadesByNumForTree(num)
								
								If jbd.ReplayTo > 0 Then
									MailList2.ListItems(MsgN(num)).Selected = False
									num = jbd.ReplayTo
									ShowMail(num)
									MailList2.ListItems(MsgN(num)).Selected = True
									MailList2.ListItems(MsgN(num)).EnsureVisible()
								End If
								
							Case "N" 'Netmail
								
								'
							Case "S" 'squish
								'
						End Select
						
					Case System.Windows.Forms.Keys.Multiply '*
						
						Select Case Mid(Key, 1, 1)
							
							Case "r", "c" 'Echomail
								jbd.GetHeadesByNumForTree(num)
								
								If jbd.ReplayNext > 0 Then
									MailList2.ListItems(MsgN(num)).Selected = False
									num = jbd.ReplayNext
									ShowMail(num)
									MailList2.ListItems(MsgN(num)).Selected = True
									MailList2.ListItems(MsgN(num)).EnsureVisible()
								End If
								
							Case "N" 'Netmail
								
								'
							Case "S" 'squish
								'
						End Select
						
				End Select
		End Select
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::MailViewer_KeyUp")
		End Select
		
	End Sub
	
	Private Sub MailViewer_MouseMoveEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxRichTextLib.DRichTextEvents_MouseMoveEvent) Handles MailViewer.MouseMoveEvent
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim RegEx As New VBScript_RegExp_55.RegExp
		Dim str_Renamed As String
		
		RegEx.IgnoreCase = True ' игнорируем регистр символов
		RegEx.Pattern = "\d+:\d+/\d+\.{0,1}\d*" 'шаблон для выборки 4D адреса из 5D
		
		str_Renamed = RichWordOver(MailViewer, eventArgs.X, eventArgs.Y)
		
		If RegEx.Test(str_Renamed) Then
			MailViewer.MouseIcon = VB6.LoadResPicture(1, VB6.LoadResConstants.ResCursor)
			'UPGRADE_ISSUE: RichTextLib.RichTextBox property MailViewer.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2036"'
			MailViewer.MousePointer = RichTextLib.MousePointerConstants.rtfCustom
		Else
			'UPGRADE_ISSUE: RichTextLib.RichTextBox property MailViewer.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2036"'
			MailViewer.MousePointer = RichTextLib.MousePointerConstants.rtfDefault
		End If
		
		'UPGRADE_NOTE: Object RegEx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		RegEx = Nothing
		
		System.Windows.Forms.Application.DoEvents()
		
	End Sub
	
	Private Sub MailViewerC_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MailViewerC.Resize
		Dim dt As Integer
		
		'to be faster
		dt = VB6.PixelsToTwipsX(MailViewerC.ClientRectangle.Width) - 2 * VB6.TwipsPerPixelX
		
		If dt < 0 Then
			dt = 0
		End If
		
		MailHead.SetBounds(0, 0, VB6.TwipsToPixelsX(dt), 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y Or Windows.Forms.BoundsSpecified.Width)
		MailViewer.SetBounds(MailViewer.Left, MailViewer.Top, MailViewerC.ClientRectangle.Width, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y Or Windows.Forms.BoundsSpecified.Width)
		
		'iconbar
		picDec.SetBounds(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(MailViewerC.ClientRectangle.Width) - VB6.PixelsToTwipsX(picDec.Width) - VB6.TwipsPerPixelX * 3), picDec.Top, 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
		cmdUUEDec.SetBounds(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(MailViewerC.ClientRectangle.Width) - VB6.PixelsToTwipsX(picDec.Width) - VB6.PixelsToTwipsX(cmdUUEDec.Width) - VB6.TwipsPerPixelX * 5), VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(cmdUUEDec.Top)), 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
		
		dt = VB6.PixelsToTwipsY(MailViewerC.ClientRectangle.Height) - VB6.PixelsToTwipsY(MailHead.Height)
		
		If dt < 0 Then
			dt = 0
		End If
		
		MailViewer.SetBounds(MailViewer.Left, MailViewer.Top, MailViewer.Width, VB6.TwipsToPixelsY(dt))
		MailViewer.SetBounds(0, VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(MailHead.Height) + 50), 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
		
	End Sub
	
	Public Sub mcChange_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcChange.Popup
		mcChange_Click(eventSender, eventArgs)
	End Sub
	Public Sub mcChange_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcChange.Click
		Dim LItem As Object
		
		Select Case GetGFEOption("Options", "MailListView", "TreeView")
			
			Case "TreeView"
				LItem = MailList.SelectedItem
				
			Case "ListView"
				LItem = MailList2.SelectedItem
		End Select
		
		Select Case EchoList.SelectedItem.SubItems(4)
			
			Case CStr(BaseType.Jam)
				'UPGRADE_WARNING: Couldn't resolve default property of object LItem.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				ViewMail(jbd, Val(Mid(LItem.Tag, 2, Len(LItem.Tag) - 2)), modCommon.ReplayMode.MailChange)
				
			Case CStr(BaseType.Netmail)
				'UPGRADE_WARNING: Couldn't resolve default property of object LItem.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				ViewMail(msg, Val(Mid(LItem.Tag, 2, Len(LItem.Tag) - 2)), modCommon.ReplayMode.MailChange)
				
			Case CStr(BaseType.Squish)
				'ненужно пока включать
				'ViewMail squ, Val(Mid$(LItem.Tag, 2, Len(LItem.Tag) - 2)), MailChange
		End Select
		
		'UPGRADE_NOTE: Object LItem may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		LItem = Nothing
		
	End Sub
	
	Public Sub mcCreateMail_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcCreateMail.Popup
		mcCreateMail_Click(eventSender, eventArgs)
	End Sub
	Public Sub mcCreateMail_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcCreateMail.Click
		Dim LItem As Object
		
		Select Case GetGFEOption("Options", "MailListView", "TreeView")
			
			Case "TreeView"
				LItem = MailList.SelectedItem
				
			Case "ListView"
				LItem = MailList2.SelectedItem
		End Select
		
		Select Case EchoList.SelectedItem.SubItems(4)
			
			Case CStr(BaseType.Jam)
				'UPGRADE_WARNING: Couldn't resolve default property of object LItem.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				ViewMail(jbd, CInt(Mid(LItem.Tag, 2, Len(LItem.Tag) - 2)), modCommon.ReplayMode.NewMail)
				
			Case CStr(BaseType.Netmail)
				'UPGRADE_WARNING: Couldn't resolve default property of object LItem.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				ViewMail(msg, CInt(Mid(LItem.Tag, 2, Len(LItem.Tag) - 2)), modCommon.ReplayMode.NewMail)
				
			Case CStr(BaseType.Squish)
				'ненужно пока включать
				'ViewMail squ, Val(Mid$(LItem.Tag, 2, Len(LItem.Tag) - 2)), NewMail
		End Select
		
		'UPGRADE_NOTE: Object LItem may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		LItem = Nothing
		
	End Sub
	
	Public Sub mcDeleteMail_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcDeleteMail.Popup
		mcDeleteMail_Click(eventSender, eventArgs)
	End Sub
	Public Sub mcDeleteMail_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcDeleteMail.Click
		Dim LItem As Object
		Dim VType As String
		
		VType = GetGFEOption("Options", "MailListView", "TreeView")
		
		Select Case VType
			
			Case "TreeView"
				LItem = MailList.SelectedItem
				
			Case "ListView"
				LItem = MailList2.SelectedItem
		End Select
		
		Select Case EchoList.SelectedItem.SubItems(4)
			
			Case CStr(BaseType.Jam)
				
				If MsgBox("Удалить письмо?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name) = MsgBoxResult.Yes Then
					EchoList.SelectedItem.SubItems(1) = CStr(CDbl(EchoList.SelectedItem.SubItems(1)) - 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object LItem.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					jbd.DeleteMessageByNum(CInt(Mid(LItem.Tag, 2, Len(LItem.Tag) - 2)))
					
					Select Case VType
						
						Case "TreeView"
							'UPGRADE_WARNING: Couldn't resolve default property of object LItem.Image. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							LItem.Image = 4
							
						Case "ListView"
							'UPGRADE_WARNING: Couldn't resolve default property of object LItem.SmallIcon. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							LItem.SmallIcon = 4
					End Select
					
				End If
				
			Case CStr(BaseType.Netmail)
				
				If MsgBox("Удалить письмо?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name) = MsgBoxResult.Yes Then
					EchoList.SelectedItem.SubItems(1) = CStr(CDbl(EchoList.SelectedItem.SubItems(1)) - 1)
					'UPGRADE_WARNING: Couldn't resolve default property of object LItem.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					msg.DeleteMessageByNum(CInt(Mid(LItem.Tag, 2, Len(LItem.Tag) - 2)))
					
					Select Case VType
						
						Case "TreeView"
							'UPGRADE_WARNING: Couldn't resolve default property of object LItem.Image. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							LItem.Image = 4
							
						Case "ListView"
							'UPGRADE_WARNING: Couldn't resolve default property of object LItem.SmallIcon. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							LItem.SmallIcon = 4
					End Select
					
				End If
				
			Case CStr(BaseType.Squish)
				'ненужно пока включать
		End Select
		
		'UPGRADE_NOTE: Object LItem may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		LItem = Nothing
		
	End Sub
	
	Public Sub mcCopyMail_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcCopyMail.Popup
		mcCopyMail_Click(eventSender, eventArgs)
	End Sub
	Public Sub mcCopyMail_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcCopyMail.Click
		On Error GoTo errHandler
		
		Select Case GetGFEOption("Options", "MailListView", "TreeView")
			
			Case "TreeView"
				MoveCopyMessage(CInt(Mid(MailList.SelectedItem.Tag, 2, Len(MailList.SelectedItem.Tag) - 2)), 0)
				
			Case "ListView"
				MoveCopyMessage(CInt(Mid(MailList2.SelectedItem.Tag, 2, Len(MailList2.SelectedItem.Tag) - 2)), 0)
		End Select
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::mcCopyMail_Click")
		End Select
		
	End Sub
	
	Public Sub mcDumpMail_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcDumpMail.Popup
		mcDumpMail_Click(eventSender, eventArgs)
	End Sub
	Public Sub mcDumpMail_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcDumpMail.Click
		
		mcDumpMail.Checked = Not mcDumpMail.Checked
		
		System.Windows.Forms.Application.DoEvents()
		
	End Sub
	
	Public Sub mcForwardMail_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcForwardMail.Popup
		mcForwardMail_Click(eventSender, eventArgs)
	End Sub
	Public Sub mcForwardMail_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcForwardMail.Click
		
		Select Case EchoList.SelectedItem.SubItems(4)
			
			Case CStr(BaseType.Jam)
				ViewMail(jbd, num, modCommon.ReplayMode.MailForward)
				
			Case CStr(BaseType.Netmail)
				ViewMail(msg, num, modCommon.ReplayMode.MailForward)
				
			Case CStr(BaseType.Squish)
				ViewMail(squ, num, modCommon.ReplayMode.MailForward)
		End Select
		
	End Sub
	
	Public Sub mcMoveMail_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcMoveMail.Popup
		mcMoveMail_Click(eventSender, eventArgs)
	End Sub
	Public Sub mcMoveMail_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcMoveMail.Click
		On Error GoTo errHandler
		
		Select Case GetGFEOption("Options", "MailListView", "TreeView")
			
			Case "TreeView"
				MoveCopyMessage(CInt(Mid(MailList.SelectedItem.Tag, 2, Len(MailList.SelectedItem.Tag) - 2)), 0) '1- должна быть тут по умолчанию
				
			Case "ListView"
				MoveCopyMessage(CInt(Mid(MailList2.SelectedItem.Tag, 2, Len(MailList2.SelectedItem.Tag) - 2)), 0) '1- должна быть тут по умолчанию
		End Select
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::mcMoveMail_Click")
		End Select
		
	End Sub
	
	Public Sub mcOpenMail_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcOpenMail.Popup
		mcOpenMail_Click(eventSender, eventArgs)
	End Sub
	Public Sub mcOpenMail_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcOpenMail.Click
		On Error GoTo errHandler
		Dim LItem As Object
		
		Select Case GetGFEOption("Options", "MailListView", "TreeView")
			
			Case "TreeView"
				LItem = MailList.SelectedItem
				
			Case "ListView"
				LItem = MailList2.SelectedItem
		End Select
		
		Select Case EchoList.SelectedItem.SubItems(4)
			
			Case CStr(BaseType.Jam)
				'UPGRADE_WARNING: Couldn't resolve default property of object LItem.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				ViewMail(jbd, CInt(Mid(LItem.Tag, 2, Len(LItem.Tag) - 2)), modCommon.ReplayMode.ViewMails)
				
			Case CStr(BaseType.Netmail)
				'UPGRADE_WARNING: Couldn't resolve default property of object LItem.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				ViewMail(msg, CInt(Mid(LItem.Tag, 2, Len(LItem.Tag) - 2)), modCommon.ReplayMode.ViewMails)
				
			Case CStr(BaseType.Squish)
				'UPGRADE_WARNING: Couldn't resolve default property of object LItem.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				ViewMail(squ, CInt(Mid(LItem.Tag, 2, Len(LItem.Tag) - 2)), modCommon.ReplayMode.ViewMails)
		End Select
		
		'UPGRADE_NOTE: Object LItem may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		LItem = Nothing
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::mcOpenMail_Click")
		End Select
		
	End Sub
	
	Public Sub mcRefresh_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcRefresh.Popup
		mcRefresh_Click(eventSender, eventArgs)
	End Sub
	Public Sub mcRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcRefresh.Click
		
		If EchoList.SelectedItem.Text <> "Netmail" Then
			If mOldCount = jbd.MessageCount Then
				Exit Sub
			End If
			
		Else
			
			If mOldCount = msg.MessageCount Then
				Exit Sub
			End If
		End If
		
		EchoList_MouseUpEvent(EchoList, New AxMSComctlLib.ListViewEvents_MouseUpEvent(VB6.MouseButtonConstants.LeftButton, 0, 0, 0))
	End Sub
	
	Public Sub mcSaveMessage_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcSaveMessage.Popup
		mcSaveMessage_Click(eventSender, eventArgs)
	End Sub
	Public Sub mcSaveMessage_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcSaveMessage.Click
		On Error GoTo errHandler
		Dim i As Integer
		Dim bcItm As Boolean
		Dim strFile, tpl As String
		Dim retQ As MsgBoxResult
		Dim db As Object
		Dim tmp As String
		Dim j As Integer
		Dim msgFields As MessageSaveFields
		Dim ff As Integer
		
		retQ = MsgBox("Сохранять в один файл(Да), в файлы с именем по полю subj писем(Нет)?", MsgBoxStyle.YesNoCancel, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
		
		If retQ = MsgBoxResult.Cancel Then
			Exit Sub
		ElseIf retQ = MsgBoxResult.Yes Then 
			modCommonDialog.OpenDialogTitle = "Выберете файл для сохранения..."
			modCommonDialog.Filter_Renamed = "All Files (*.*)|*.*|Text Files(*.txt)|*.txt|"
			modCommonDialog.Flags = cdlOFNReadOnly
			modCommonDialog.FilterIndex = 1
			strFile = modCommonDialog.ShowSave(VB6.GetPath)
		Else 'vbNo
			modCommonDialog.FolderDialogTitle = "Выбор папки для сохранения"
			strFile = modCommonDialog.ShowFolder(vbNullString)
		End If
		
		If Len(strFile) = 0 Then
			Exit Sub
		End If
		
		Select Case GetGFEOption("Options", "MailListView", "TreeView")
			
			Case "TreeView"
				
				'nothing
			Case "ListView"
				
				For i = 1 To MailList2.ListItems.Count
					bcItm = MailList2.ListItems(i).Selected
					
					If bcItm Then
						'save
						'UPGRADE_WARNING: Couldn't resolve default property of object MailList2.ListItems().Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						tmp = MailList2.ListItems(i).Tag
						num = CInt(Mid(tmp, 2, Len(tmp) - 2))
						
						Select Case Mid(tmp, 1, 1)
							
							Case "r", "c" 'Echomail
								db = jbd
								
							Case "N" 'Netmail
								db = msg
								
							Case "S" 'Squish
								db = squ
						End Select
						
						'UPGRADE_WARNING: Couldn't resolve default property of object db.GetMessageByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						db.GetMessageByNum(num)
						'UPGRADE_WARNING: Couldn't resolve default property of object db.GetHeadesByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						db.GetHeadesByNum(num)
						
						With msgFields
							.AKA = Me.EchoList.SelectedItem.SubItems(3)
							'UPGRADE_WARNING: Couldn't resolve default property of object db.DateArrived. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							.DateArrived = Mod_UnixTime.sUnixDate(db.DateArrived)
							'UPGRADE_WARNING: Couldn't resolve default property of object db.DateWritten. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							.DateWritten = Mod_UnixTime.sUnixDate(db.DateWritten)
							.Description = Me.EchoList.SelectedItem.SubItems(2)
							.EchoName = Me.EchoList.SelectedItem.Text
							'UPGRADE_WARNING: Couldn't resolve default property of object db.From. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							.From = db.From
							'UPGRADE_WARNING: Couldn't resolve default property of object db.FromAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							.FromAddr = db.FromAddr
							.MessageNumber = CStr(num)
							'UPGRADE_WARNING: Couldn't resolve default property of object db.Subj. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							.Subject = db.Subj
							'UPGRADE_WARNING: Couldn't resolve default property of object db.rTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							.To_Renamed = db.rTo
							'UPGRADE_WARNING: Couldn't resolve default property of object db.rToAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							.ToAddr = db.rToAddr
							'UPGRADE_WARNING: Couldn't resolve default property of object db.MessageCount. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							.TotalMessages = db.MessageCount
						End With
						
						'Header
						tpl = vbNullString
						tpl = "- " & msgFields.Description & "(" & msgFields.AKA & ") ------------------------------ " & msgFields.EchoName & " -" & vbCrLf
						tpl = tpl & "Msg   : " & msgFields.MessageNumber & " из " & msgFields.TotalMessages & vbCrLf
						tpl = tpl & "From : " & msgFields.From & "                    " & msgFields.FromAddr & "      " & msgFields.DateWritten & vbCrLf
						tpl = tpl & "To      : " & msgFields.To_Renamed & "                    " & msgFields.ToAddr & "      " & msgFields.DateArrived & vbCrLf
						tpl = tpl & "Subj   : " & msgFields.Subject & vbCrLf
						tpl = tpl & "-------------------------------------------------------------------------------" & vbCrLf
						
						'UPGRADE_WARNING: Couldn't resolve default property of object db.Message. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						tpl = tpl & db.Message & vbCrLf
						
						ff = FreeFile
						
						If retQ = MsgBoxResult.Yes Then
							'one file
							FileOpen(ff, strFile, OpenMode.Append)
							PrintLine(ff, tpl)
							FileClose(ff)
						Else
							'subj file
							msgFields.Subject = Replace(Replace(Replace(Replace(Replace(msgFields.Subject, "|", vbNullString), ">", vbNullString), "<", vbNullString), ":", vbNullString), "\", vbNullString)
							
							If Len(msgFields.Subject) = 0 Then
								msgFields.Subject = "No_subject"
							End If
							
							j = 0
							tmp = strFile & "\" & msgFields.Subject & ".txt"
							While FileExists(tmp)
								tmp = strFile & "\" & msgFields.Subject & "_" & CStr(j) & ".txt"
								j = j + 1
							End While
							FileOpen(ff, tmp, OpenMode.Binary)
							'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
							FilePut(ff, tpl)
							FileClose(ff)
						End If
						
					End If
					
				Next i
				
				MsgBox("Сохранение выполнено успешно.", MsgBoxStyle.Information, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
		End Select
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::mcSaveMessage_Click")
		End Select
		
	End Sub
	
	Public Sub mcShowKluge_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcShowKluge.Popup
		mcShowKluge_Click(eventSender, eventArgs)
	End Sub
	Public Sub mcShowKluge_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcShowKluge.Click
		mcShowKluge.Checked = Not mcShowKluge.Checked
	End Sub
	
	Public Sub mcTerminalFont_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcTerminalFont.Popup
		mcTerminalFont_Click(eventSender, eventArgs)
	End Sub
	Public Sub mcTerminalFont_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mcTerminalFont.Click
		Dim cl() As String
		
		If mcTerminalFont.Checked Then
			cl = Split(GetGFEOption("Fonts", "MainTextViewFont", "MS Sans Serif - Regular - 8pt"), " - ")
			MailViewer.Font = VB6.FontChangeName(MailViewer.Font, cl(0))
			
			If InStr(1, cl(1), " ") <> 0 Then 'сочитание стилей
				MailViewer.Font = VB6.FontChangeBold(MailViewer.Font, True)
				MailViewer.Font = VB6.FontChangeItalic(MailViewer.Font, True)
			Else
				
				If InStr(1, cl(1), "Bold", CompareMethod.Text) <> 0 Then
					MailViewer.Font = VB6.FontChangeBold(MailViewer.Font, True)
				Else
					MailViewer.Font = VB6.FontChangeBold(MailViewer.Font, False)
				End If
				
				If InStr(1, cl(1), "Italic", CompareMethod.Text) <> 0 Then
					MailViewer.Font = VB6.FontChangeItalic(MailViewer.Font, True)
				Else
					MailViewer.Font = VB6.FontChangeItalic(MailViewer.Font, False)
				End If
			End If
			
			MailViewer.Font = VB6.FontChangeSize(MailViewer.Font, CDec(Mid(cl(2), 1, Len(cl(2)) - 2)))
			mcTerminalFont.Checked = False
			MailViewer.Font = VB6.FontChangeGdiCharSet(MailViewer.Font, 204)
		Else
			mcTerminalFont.Checked = True
			MailViewer.Font = VB6.FontChangeBold(MailViewer.Font, False)
			MailViewer.Font = VB6.FontChangeItalic(MailViewer.Font, False)
			'UPGRADE_WARNING: Only TrueType and OpenType fonts are supported in Windows Forms. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2045"'
			MailViewer.Font = VB6.FontChangeName(MailViewer.Font, "Terminal")
			MailViewer.Font = VB6.FontChangeSize(MailViewer.Font, 9)
			MailViewer.Font = VB6.FontChangeGdiCharSet(MailViewer.Font, 204)
		End If
		
		System.Windows.Forms.Application.DoEvents()
		
	End Sub
	
	Public Sub mncExit_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mncExit.Popup
		mncExit_Click(eventSender, eventArgs)
	End Sub
	Public Sub mncExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mncExit.Click
		Me.Close()
	End Sub
	
	Public Sub mncListMailList_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mncListMailList.Popup
		mncListMailList_Click(eventSender, eventArgs)
	End Sub
	Public Sub mncListMailList_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mncListMailList.Click
		PutGFEOption("Options", "MailListView", "ListView")
		mncTreeMailList.Checked = False
		mncListMailList.Checked = True
		
		flg = False
		
		If Not (EchoList.SelectedItem Is Nothing) Then
			EchoList_MouseUpEvent(EchoList, New AxMSComctlLib.ListViewEvents_MouseUpEvent(VB6.MouseButtonConstants.LeftButton, 0, 0, 0))
		End If
		
	End Sub
	
	Public Sub mncToolBarBottomTitle_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mncToolBarBottomTitle.Popup
		mncToolBarBottomTitle_Click(eventSender, eventArgs)
	End Sub
	Public Sub mncToolBarBottomTitle_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mncToolBarBottomTitle.Click
		
		mncToolBarNotTitle.Checked = False
		mncToolBarRightTitle.Checked = False
		mncToolBarBottomTitle.Checked = True
		NavigationToolBar.TextAlignment = MSComctlLib.ToolbarTextAlignConstants.tbrTextAlignBottom
		
	End Sub
	
	Public Sub mncToolBarNotTitle_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mncToolBarNotTitle.Popup
		mncToolBarNotTitle_Click(eventSender, eventArgs)
	End Sub
	Public Sub mncToolBarNotTitle_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mncToolBarNotTitle.Click
		
		mncToolBarNotTitle.Checked = True
		mncToolBarRightTitle.Checked = False
		mncToolBarBottomTitle.Checked = False
		
	End Sub
	
	Public Sub mncToolBarRightTitle_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mncToolBarRightTitle.Popup
		mncToolBarRightTitle_Click(eventSender, eventArgs)
	End Sub
	Public Sub mncToolBarRightTitle_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mncToolBarRightTitle.Click
		
		mncToolBarNotTitle.Checked = False
		mncToolBarRightTitle.Checked = True
		mncToolBarBottomTitle.Checked = False
		NavigationToolBar.TextAlignment = MSComctlLib.ToolbarTextAlignConstants.tbrTextAlignRight
		'CoolBar.Bands(1).Height = NavigationToolBar.Height
		
	End Sub
	
	Public Sub mncTreeMailList_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mncTreeMailList.Popup
		mncTreeMailList_Click(eventSender, eventArgs)
	End Sub
	Public Sub mncTreeMailList_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mncTreeMailList.Click
		PutGFEOption("Options", "MailListView", "TreeView")
		mncTreeMailList.Checked = True
		mncListMailList.Checked = False
		
		flg = False
		
		If Not (EchoList.SelectedItem Is Nothing) Then
			EchoList_MouseUpEvent(EchoList, New AxMSComctlLib.ListViewEvents_MouseUpEvent(VB6.MouseButtonConstants.LeftButton, 0, 0, 0))
		End If
		
	End Sub
	
	Public Sub mnuAbout_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAbout.Popup
		mnuAbout_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAbout.Click
		frmAbout.DefInstance.ShowDialog()
	End Sub
	
	Public Sub mnuCheckUpdate_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCheckUpdate.Popup
		mnuCheckUpdate_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuCheckUpdate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCheckUpdate.Click
		Call modCommon.CheckUpdate()
	End Sub
	
	Public Sub mnuCopyMessage_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCopyMessage.Popup
		mnuCopyMessage_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuCopyMessage_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuCopyMessage.Click
		On Error GoTo errHandler
		
		Select Case GetGFEOption("Options", "MailListView", "TreeView")
			
			Case "TreeView"
				MoveCopyMessage(CInt(Mid(MailList.SelectedItem.Tag, 2, Len(MailList.SelectedItem.Tag) - 2)), 0)
				
			Case "ListView"
				MoveCopyMessage(CInt(Mid(MailList2.SelectedItem.Tag, 2, Len(MailList2.SelectedItem.Tag) - 2)), 0)
		End Select
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 91
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::mnuCopyMessage_Click")
		End Select
		
	End Sub
	
	Public Sub mnuEditMessage_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditMessage.Popup
		mnuEditMessage_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuEditMessage_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEditMessage.Click
		On Error GoTo errHandler
		Dim LItem As Object
		
		Select Case GetGFEOption("Options", "MailListView", "TreeView")
			
			Case "TreeView"
				LItem = MailList.SelectedItem
				
			Case "ListView"
				LItem = MailList2.SelectedItem
		End Select
		
		Select Case EchoList.SelectedItem.SubItems(4)
			
			Case CStr(BaseType.Jam)
				'UPGRADE_WARNING: Couldn't resolve default property of object LItem.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				ViewMail(jbd, CInt(Mid(LItem.Tag, 2, Len(LItem.Tag) - 2)), modCommon.ReplayMode.MailChange)
				
			Case CStr(BaseType.Netmail)
				'UPGRADE_WARNING: Couldn't resolve default property of object LItem.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				ViewMail(msg, CInt(Mid(LItem.Tag, 2, Len(LItem.Tag) - 2)), modCommon.ReplayMode.MailChange)
				
			Case CStr(BaseType.Squish)
				'ненужно пока включать
				'ViewMail squ, clng(Mid$(LItem.Tag, 2, Len(LItem.Tag) - 2)), MailChange
		End Select
		
		'UPGRADE_NOTE: Object LItem may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		LItem = Nothing
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 91
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::mnuNewMessage_Click")
		End Select
		
	End Sub
	
	Public Sub mnuFindLetter_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFindLetter.Popup
		mnuFindLetter_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuFindLetter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFindLetter.Click
		frmFindDialog.DefInstance.Show()
	End Sub
	
	Public Sub mnuForwardMessage_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuForwardMessage.Popup
		mnuForwardMessage_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuForwardMessage_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuForwardMessage.Click
		On Error GoTo errHandler
		
		Select Case EchoList.SelectedItem.SubItems(4)
			
			Case CStr(BaseType.Jam)
				ViewMail(jbd, num, modCommon.ReplayMode.MailForward)
				
			Case CStr(BaseType.Netmail)
				ViewMail(msg, num, modCommon.ReplayMode.MailForward)
				
			Case CStr(BaseType.Squish)
				ViewMail(squ, num, modCommon.ReplayMode.MailForward)
		End Select
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::mnuForwardMessage_Click")
		End Select
		
	End Sub
	
	Public Sub mnuNewMessage_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuNewMessage.Popup
		mnuNewMessage_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuNewMessage_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuNewMessage.Click
		On Error GoTo errHandler
		
		Select Case EchoList.SelectedItem.SubItems(4)
			
			Case CStr(BaseType.Jam)
				ViewMail(jbd, num, modCommon.ReplayMode.NewMail)
				
			Case CStr(BaseType.Netmail)
				ViewMail(msg, num, modCommon.ReplayMode.NewMail)
				
			Case CStr(BaseType.Squish)
				'ненужно пока включать
				'ViewMail squ, num, NewMail
		End Select
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::mnuNewMessage_Click")
		End Select
		
	End Sub
	
	Public Sub mnuOptions_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuOptions.Popup
		mnuOptions_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuOptions_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuOptions.Click
		frmOptions.DefInstance.ShowDialog()
		
		'перечитываем настройки
		frmMain_Load(Me, New System.EventArgs())
	End Sub
	
	Public Sub mnuPlugins_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPlugins.Popup
		mnuPlugins_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuPlugins_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPlugins.Click
		Dim Index As Short = mnuPlugins.GetIndex(eventSender)
		On Error GoTo errHandler
		
		If Index <> 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Plugins().MenuExecute. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Plugins(Index - 1).MenuExecute() 'выполняем действия
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object AddrBk.DisplayContacts. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			AddrBk.DisplayContacts()
		End If
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 91
				MsgBox("Плугин " & mnuPlugins(Index).Text & " некорректно зарегистрирован или не найден.", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::mnuPlugins_Click")
		End Select
		
	End Sub
	
	Public Sub mnuReplyAnotherEcho_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuReplyAnotherEcho.Popup
		mnuReplyAnotherEcho_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuReplyAnotherEcho_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuReplyAnotherEcho.Click
		On Error GoTo errHandler
		
		Select Case EchoList.SelectedItem.SubItems(4)
			
			Case CStr(BaseType.Jam)
				ViewMail(jbd, num, modCommon.ReplayMode.ReplayOtherArea)
				
			Case CStr(BaseType.Netmail)
				ViewMail(msg, num, modCommon.ReplayMode.ReplayOtherArea)
				
			Case CStr(BaseType.Squish)
				'ненужно пока включать
				'ViewMail squ, num,ReplayOtherArea
		End Select
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::mnuReplyAnotherEcho_Click")
		End Select
		
	End Sub
	
	Public Sub mnuReplyNotCit_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuReplyNotCit.Popup
		mnuReplyNotCit_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuReplyNotCit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuReplyNotCit.Click
		On Error GoTo errHandler
		
		Select Case EchoList.SelectedItem.SubItems(4)
			
			Case CStr(BaseType.Jam)
				ViewMail(jbd, num, modCommon.ReplayMode.ReplayFromNotCit)
				
			Case CStr(BaseType.Netmail)
				ViewMail(msg, num, modCommon.ReplayMode.ReplayFromNotCit)
				
			Case CStr(BaseType.Squish)
				'ненужно пока включать
				'ViewMail squ, num, ReplayFromNotCit
		End Select
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::mnuReplyNotCit_Click")
		End Select
		
	End Sub
	
	Public Sub mnuReplyQuote_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuReplyQuote.Popup
		mnuReplyQuote_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuReplyQuote_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuReplyQuote.Click
		On Error GoTo errHandler
		
		Select Case EchoList.SelectedItem.SubItems(4)
			
			Case CStr(BaseType.Jam)
				ViewMail(jbd, num, modCommon.ReplayMode.ReplayFrom)
				
			Case CStr(BaseType.Netmail)
				ViewMail(msg, num, modCommon.ReplayMode.ReplayFrom)
				
			Case CStr(BaseType.Squish)
				'ненужно пока включать
				'ViewMail squ, num, ReplayFrom
		End Select
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::mnuReplyQuote_Click")
		End Select
		
	End Sub
	
	Private Sub NavigationToolBar_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComctlLib.IToolbarEvents_ButtonClickEvent) Handles NavigationToolBar.ButtonClick
		On Error GoTo errHandler
		Dim ListType As String
		
		If num = 0 And eventArgs.Button.Index <> 4 And eventArgs.Button.Index <> 19 And eventArgs.Button.Index <> 13 And eventArgs.Button.Index <> 14 Then
			Exit Sub 'выходим если не выбрана ни одна эха и пользователь не нажал поиск
		End If
		
		ListType = GetGFEOption("Options", "MailListView", "TreeView")
		
		Select Case eventArgs.Button.Index
			
			Case 1 'previous
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						
						If num > 1 Then
							num = num - 1
							ShowMail(num,  , BaseType.Jam)
							
							Select Case ListType
								
								Case "TreeView"
									MailList.Nodes(MsgN(num)).Selected = True
									MailList.Nodes(MsgN(num)).EnsureVisible()
									MailList.Nodes(MsgN(num)).Image = 2
									
								Case "ListView"
									MailList2.ListItems(MsgN(num)).Selected = True
									MailList2.ListItems(MsgN(num)).EnsureVisible()
									MailList2.ListItems(MsgN(num + 1)).Selected = False
									MailList2.ListItems(MsgN(num + 1)).SmallIcon = 2
							End Select
							
						End If
						
					Case CStr(BaseType.Netmail)
						
						If num > 1 Then
							num = num - 1
							ShowMail(num,  , BaseType.Netmail)
							
							Select Case ListType
								
								Case "TreeView"
									MailList.Nodes(MsgN(num)).Selected = True
									MailList.Nodes(MsgN(num)).EnsureVisible()
									MailList.Nodes(MsgN(num)).Image = 2
									
								Case "ListView"
									MailList2.ListItems(MsgN(num)).Selected = True
									MailList2.ListItems(MsgN(num)).EnsureVisible()
									MailList2.ListItems(MsgN(num + 1)).Selected = False
									MailList2.ListItems(MsgN(num + 1)).SmallIcon = 2
							End Select
							
						End If
						
					Case CStr(BaseType.Squish)
						
						If num > 1 Then
							num = num - 1
							ShowMail(num,  , BaseType.Squish)
							
							Select Case ListType
								
								Case "TreeView"
									MailList.Nodes(MsgN(num)).Selected = True
									MailList.Nodes(MsgN(num)).EnsureVisible()
									MailList.Nodes(MsgN(num)).Image = 2
									
								Case "ListView"
									MailList2.ListItems(MsgN(num)).Selected = True
									MailList2.ListItems(MsgN(num)).EnsureVisible()
									MailList2.ListItems(MsgN(num + 1)).Selected = False
									MailList2.ListItems(MsgN(num + 1)).SmallIcon = 2
							End Select
							
						End If
						
				End Select
				
			Case 2 'next
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						
						If num < jbd.MessageCount Then
							num = num + 1
							ShowMail(num,  , BaseType.Jam)
							
							Select Case ListType
								
								Case "TreeView"
									MailList.Nodes(MsgN(num)).Selected = True
									MailList.Nodes(MsgN(num)).EnsureVisible()
									
								Case "ListView"
									MailList2.ListItems(MsgN(num)).Selected = True
									MailList2.ListItems(MsgN(num)).EnsureVisible()
									MailList2.ListItems(MsgN(num - 1)).Selected = False
							End Select
							
						End If
						
					Case CStr(BaseType.Netmail)
						
						If num < msg.MessageCount Then
							num = num + 1
							ShowMail(num,  , BaseType.Netmail)
							
							Select Case ListType
								
								Case "TreeView"
									MailList.Nodes(MsgN(num)).Selected = True
									MailList.Nodes(MsgN(num)).EnsureVisible()
									
								Case "ListView"
									MailList2.ListItems(MsgN(num)).Selected = True
									MailList2.ListItems(MsgN(num)).EnsureVisible()
									MailList2.ListItems(MsgN(num - 1)).Selected = False
							End Select
							
						End If
						
					Case CStr(BaseType.Squish)
						
						If num < squ.MessageCount Then
							num = num + 1
							ShowMail(num,  , BaseType.Squish)
							
							Select Case ListType
								
								Case "TreeView"
									MailList.Nodes(MsgN(num)).Selected = True
									MailList.Nodes(MsgN(num)).EnsureVisible()
									
								Case "ListView"
									MailList2.ListItems(MsgN(num)).Selected = True
									MailList2.ListItems(MsgN(num)).EnsureVisible()
									MailList2.ListItems(MsgN(num - 1)).Selected = False
							End Select
							
						End If
						
				End Select
				
			Case 4 'Find
				frmFindDialog.DefInstance.Show()
				
			Case 6 'ReplayFrom
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						ViewMail(jbd, num, modCommon.ReplayMode.ReplayFrom)
						
					Case CStr(BaseType.Netmail)
						ViewMail(msg, num, modCommon.ReplayMode.ReplayFrom)
						
					Case CStr(BaseType.Squish)
						'ненужно пока включать
						'ViewMail squ, num, ReplayFrom
				End Select
				
			Case 7 'ReplayTo
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						ViewMail(jbd, num, modCommon.ReplayMode.ReplayTo)
						
					Case CStr(BaseType.Netmail)
						ViewMail(msg, num, modCommon.ReplayMode.ReplayTo)
						
					Case CStr(BaseType.Squish)
						'ненужно пока включать
						'ViewMail squ, num, ReplayTo
				End Select
				
			Case 8 'ReplayFromNotCit
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						ViewMail(jbd, num, modCommon.ReplayMode.ReplayFromNotCit)
						
					Case CStr(BaseType.Netmail)
						ViewMail(msg, num, modCommon.ReplayMode.ReplayFromNotCit)
						
					Case CStr(BaseType.Squish)
						'ненужно пока включать
						'ViewMail squ, num, ReplayFromNotCit
				End Select
				
			Case 9 'ReplayOtherArea
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						ViewMail(jbd, num, modCommon.ReplayMode.ReplayOtherArea)
						
					Case CStr(BaseType.Netmail)
						ViewMail(msg, num, modCommon.ReplayMode.ReplayOtherArea)
						
					Case CStr(BaseType.Squish)
						'ненужно пока включать
						'ViewMail squ, num,ReplayOtherArea
				End Select
				
			Case 11 'Delete
				EchoList.SelectedItem.SubItems(1) = CStr(CDbl(EchoList.SelectedItem.SubItems(1)) - 1)
				
				Select Case ListType
					
					Case "TreeView"
						
						Select Case EchoList.SelectedItem.SubItems(4)
							
							Case CStr(BaseType.Jam)
								jbd.DeleteMessageByNum(Val(Mid(MailList.SelectedItem.Tag, 2, Len(MailList.SelectedItem.Tag) - 2)))
								MailList.SelectedItem.Image = 4
								
							Case CStr(BaseType.Netmail)
								msg.DeleteMessageByNum(Val(Mid(MailList.SelectedItem.Tag, 2, Len(MailList.SelectedItem.Tag) - 2)))
								MailList.SelectedItem.Image = 4
								
							Case CStr(BaseType.Squish)
								'ненужно пока включать
								'squ.DeleteMessageByNum Val(Mid$(MailList.SelectedItem.Tag, 2, Len(MailList.SelectedItem.Tag) - 2))
						End Select
						
					Case "ListView"
						
						Select Case EchoList.SelectedItem.SubItems(4)
							
							Case CStr(BaseType.Jam)
								jbd.DeleteMessageByNum(Val(Mid(MailList2.SelectedItem.Tag, 2, Len(MailList2.SelectedItem.Tag) - 2)))
								MailList2.SelectedItem.SmallIcon = 4
								
							Case CStr(BaseType.Netmail)
								msg.DeleteMessageByNum(Val(Mid(MailList2.SelectedItem.Tag, 2, Len(MailList2.SelectedItem.Tag) - 2)))
								MailList2.SelectedItem.SmallIcon = 4
								
							Case CStr(BaseType.Squish)
								'ненужно пока включать
								'squ.DeleteMessageByNum Val(Mid$(MailList2.SelectedItem.Tag, 2, Len(MailList2.SelectedItem.Tag) - 2))
								'MailList2.SelectedItem.SmallIcon = 4
						End Select
				End Select
				
			Case 13 'newmail
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						ViewMail(jbd, num, modCommon.ReplayMode.NewMail)
						
					Case CStr(BaseType.Netmail)
						ViewMail(msg, num, modCommon.ReplayMode.NewMail)
						
					Case CStr(BaseType.Squish)
						'ненужно пока включать
						'ViewMail squ, num, NewMail
				End Select
				
			Case 14 'MultiMail
				SendMultiEchoMail()
				
			Case 16 'font +
				LockWindowUpdate(MailViewer.hWnd) 'ставим залочку
				MailViewer.SelStart = 0
				MailViewer.SelLength = Len(MailViewer.Text)
				MailViewer.SelFontSize = MailViewer.SelFontSize + 2
				MailViewer.SelStart = 0
				LockWindowUpdate(0)
				
			Case 17 'font -
				LockWindowUpdate(MailViewer.hWnd) 'ставим залочку
				MailViewer.SelStart = 0
				MailViewer.SelLength = Len(MailViewer.Text)
				MailViewer.SelFontSize = MailViewer.SelFontSize - 2
				MailViewer.SelStart = 0
				LockWindowUpdate(0)
				
			Case 19 'addrbook
				On Error Resume Next
				'UPGRADE_WARNING: Couldn't resolve default property of object AddrBk.DisplayContacts. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				AddrBk.DisplayContacts()
				
				If Err.Number = 91 Then
					MsgBox("Плугин AddrBook.dll не зарегистрирован или не найден.", MsgBoxStyle.Exclamation, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				End If
				
				On Error GoTo errHandler
				
			Case 21 'FindUUE
				
				Select Case EchoList.SelectedItem.SubItems(4)
					
					Case CStr(BaseType.Jam)
						'UPGRADE_WARNING: Couldn't resolve default property of object frmDecodeUUE.base. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						frmDecodeUUE.DefInstance.base = jbd
						frmDecodeUUE.DefInstance.ShowDialog()
						
					Case CStr(BaseType.Netmail)
						'UPGRADE_WARNING: Couldn't resolve default property of object frmDecodeUUE.base. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						frmDecodeUUE.DefInstance.base = msg
						frmDecodeUUE.DefInstance.ShowDialog()
						
					Case CStr(BaseType.Squish)
						'ненужно пока включать
						'frmDecodeUUE.base = squ
						'frmDecodeUUE.Show vbModal
				End Select
				
			Case 22 'Refresh
				EchoList_MouseUpEvent(EchoList, New AxMSComctlLib.ListViewEvents_MouseUpEvent(VB6.MouseButtonConstants.LeftButton, 0, 0, 0))
				
			Case 24
				PrintDemo()
				
		End Select
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::ToolBar_ButtonClick")
		End Select
		
	End Sub
	
	Private Sub CreateMailList(Optional ByRef base As BaseType = BaseType.Jam)
		On Error GoTo errHandler
		Dim ndeChild, ndeParent, ndeOldParent As MSComctlLib.Node
		Dim b, a, msgid As Integer
		Dim Subj As String
		Dim Refs() As MSComctlLib.Node
		Dim Nums() As Integer
		Dim RefsCount As Integer
		Dim ndeEl As MSComctlLib.ListItem
		Dim sysOp As String
		Dim msgCurCnt As Integer
		Dim squReplays() As String
		
		sysOp = GetGFEOption("Options", "UserName0", "SysOp")
		
		If Picture1.Visible = True Then
			MLStr = GetGFEOption("Options", "MailListView", "TreeView")
			MailList.Visible = False
			MailList2.Visible = False
			
			'        Select Case MLStr
			'            Case "TreeView"
			'                MailList.Visible = False
			'            Case "ListView"
			'                MailList2.Visible = False
			'        End Select
			
			System.Windows.Forms.Application.DoEvents()
		End If
		
		NavigationToolBar.Buttons(1).Enabled = False
		NavigationToolBar.Buttons(2).Enabled = False
		
		Select Case MLStr
			
			Case "TreeView"
				'---------------------------------------------------------------------------------------
				LockWindowUpdate(MailList.hWnd) 'ставим залочку
				
				MailList.Nodes.Clear()
				RefsCount = 0
				msgid = 1
				
				Select Case base
					
					Case BaseType.Jam
						
						If jbd.MessageCount - 1 > 0 Then
							ProgressBar.Max = jbd.MessageCount - 1
						End If
						
						msgCurCnt = jbd.MessageCount
						
						For a = 1 To msgCurCnt
							
							If flg = False Then
								Exit For
							End If
							
							If a Mod 2000 = 0 Then
								ProgressBar.Value = a - 1
								System.Windows.Forms.Application.DoEvents()
							End If
							
							jbd.GetHeadesByNumForTree(a)
							
							If jbd.ReplayTo = 0 Then
								'это сообщение не является ответом ни на одно сообщение
								ndeParent = MailList.Nodes.Add( , 4,  , CStr(a) & ":" & jbd.Subj, 1)
								ndeParent.let_Tag("r" & CStr(a) & "r")
								
								If rdb_ext = 1 Then
									'UPGRADE_WARNING: Couldn't resolve default property of object rdb.GetMessageStatusByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
									If rdb.GetMessageStatusByNum(a) = 1 Then
										ndeParent.Image = 2
									End If
									
								Else
									
									If jbd.MessageStatus(a) = 1 Then
										ndeParent.Image = 2
									End If
								End If
								
								'здесь присваеваем по номеру мессага его порядковый номер добовления
								MsgN(a) = msgid
								msgid = msgid + 1
								
								'---------------------------
								'Выделение цветом в случае если это RULES и удаленные письма
								'Обработка идет только у сообщений которые
								' не являются ответами, обычно правила публикуются
								' самостоятельно
								If (InStr(1, jbd.From, "Moderator", CompareMethod.Text) <> 0) Then
									ndeParent.ForeColor = System.Convert.ToUInt32(msgModeratorColor)
									ndeParent.Bold = True
									ndeParent.Image = 3
									
									'в последствии дополнительно выделяются рулеса.
									'смысла нет проверять рулеса отдельно. т.к. их от "не модератора" не бывает
									Subj = jbd.Subj
									
									If (InStr(1, Subj, "Rules", CompareMethod.Text) <> 0) Then
										ndeParent.ForeColor = System.Convert.ToUInt32(msgRulesColor)
										ndeParent.Bold = True
										ndeParent.Image = 3
									ElseIf (InStr(1, Subj, "Offtopic", CompareMethod.Text) <> 0) Then 
										ndeParent.ForeColor = System.Convert.ToUInt32(msgRulesColor)
										ndeParent.Bold = True
										ndeParent.Image = 3
									ElseIf (InStr(1, Subj, "Пpавила", CompareMethod.Text) <> 0) Then 
										ndeParent.ForeColor = System.Convert.ToUInt32(msgRulesColor)
										ndeParent.Bold = True
										ndeParent.Image = 3
									ElseIf (InStr(1, Subj, "Правила", CompareMethod.Text) <> 0) Then 
										ndeParent.ForeColor = System.Convert.ToUInt32(msgRulesColor)
										ndeParent.Bold = True
										ndeParent.Image = 3
									End If
									
								ElseIf (InStr(1, jbd.From, "[DEL]", CompareMethod.Text) <> 0) Then 
									ndeParent.ForeColor = System.Convert.ToUInt32(msgMainTextColor)
									ndeParent.Image = 4
								ElseIf (InStr(1, jbd.From, sysOp, CompareMethod.Text) <> 0) Or (InStr(1, jbd.rTo, sysOp, CompareMethod.Text) <> 0) Then 
									ndeParent.ForeColor = System.Convert.ToUInt32(msgMyMessagesColor)
									ndeParent.Image = 3
								End If
								
								'------------------------------
								
								ndeOldParent = ndeParent
								
								b = jbd.ReplayFirst
								
								If (b > 0) And (b <= msgCurCnt) Then
									'есть ответы на это письмо добавляем его в "КОРНЕВУХУ"
									
									RefsCount = 0
									
									Do 
										Do 
											jbd.GetHeadesByNumForTree(b)
											
											ndeChild = MailList.Nodes.Add(ndeParent, 4,  , CStr(b) & ":" & jbd.Subj, 2)
											ndeChild.let_Tag("c" & CStr(b) & "c")
											
											If rdb_ext = 1 Then
												'UPGRADE_WARNING: Couldn't resolve default property of object rdb.GetMessageStatusByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
												If rdb.GetMessageStatusByNum(a) = 1 Then
													ndeChild.Image = 2
												End If
												
											Else
												
												If jbd.MessageStatus(a) = 1 Then
													ndeChild.Image = 2
												End If
											End If
											
											'здесь присваеваем по номеру мессага его порядковый номер добавления
											MsgN(b) = msgid
											msgid = msgid + 1
											
											'---------------------------
											'Выделение цветом
											If (InStr(1, jbd.From, "Moderator", CompareMethod.Text) <> 0) Then
												ndeChild.ForeColor = System.Convert.ToUInt32(msgModeratorColor)
												ndeChild.Bold = True
												ndeChild.Image = 3
												
												Subj = jbd.Subj
												
												If (InStr(1, Subj, "Rules", CompareMethod.Text) <> 0) Then
													ndeChild.ForeColor = System.Convert.ToUInt32(msgRulesColor)
													ndeChild.Bold = True
													ndeChild.Image = 3
												ElseIf (InStr(1, Subj, "Offtopic", CompareMethod.Text) <> 0) Then 
													ndeChild.ForeColor = System.Convert.ToUInt32(msgRulesColor)
													ndeChild.Bold = True
													ndeChild.Image = 3
												ElseIf (InStr(1, Subj, "Пpавила", CompareMethod.Text) <> 0) Then 
													ndeChild.ForeColor = System.Convert.ToUInt32(msgRulesColor)
													ndeChild.Bold = True
													ndeChild.Image = 3
												ElseIf (InStr(1, Subj, "Правила", CompareMethod.Text) <> 0) Then 
													ndeChild.ForeColor = System.Convert.ToUInt32(msgRulesColor)
													ndeChild.Bold = True
													ndeChild.Image = 3
												End If
												
											ElseIf (InStr(1, jbd.From, "[DEL]", CompareMethod.Text) <> 0) Then 
												ndeChild.ForeColor = System.Convert.ToUInt32(msgMainTextColor)
												ndeChild.Image = 4
											ElseIf (InStr(1, jbd.From, sysOp, CompareMethod.Text) <> 0) Or (InStr(1, jbd.rTo, sysOp, CompareMethod.Text) <> 0) Then 
												ndeChild.ForeColor = System.Convert.ToUInt32(msgMyMessagesColor)
												ndeChild.Image = 3
											End If
											
											'------------------------------
											
											'У этого сообщения есть ответ
											If (jbd.ReplayNext <> 0) Then
												RefsCount = RefsCount + 1
												'UPGRADE_WARNING: Lower bound of array Refs was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1033"'
												ReDim Preserve Refs(RefsCount)
												'UPGRADE_WARNING: Lower bound of array Nums was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1033"'
												ReDim Preserve Nums(RefsCount)
												'Запоминаем его
												Refs(RefsCount) = ndeParent
												Nums(RefsCount) = b
											End If
											
											'переходим на более глубинный уровень
											ndeParent = ndeChild
											b = jbd.ReplayFirst
											
										Loop Until (b = 0) Or (b > msgCurCnt) 'Есть ответы на это письмо
										
										If RefsCount >= 1 Then
											ndeParent = Refs(RefsCount)
											b = Nums(RefsCount)
											jbd.GetHeadesByNumForTree(b)
											b = jbd.ReplayNext
											
											If Nums(RefsCount) = b Then
												'если мы ссылаемся сами на себя то выходим.
												Exit Do
											End If
										End If
										
										RefsCount = RefsCount - 1
										
										If RefsCount >= 1 Then
											'UPGRADE_WARNING: Lower bound of array Refs was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1033"'
											ReDim Preserve Refs(RefsCount)
											'UPGRADE_WARNING: Lower bound of array Nums was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1033"'
											ReDim Preserve Nums(RefsCount)
										End If
										
									Loop Until RefsCount < 0
									
								End If
							End If
							
						Next 
						
					Case BaseType.Netmail
						
						If msg.MessageCount - 1 > 0 Then
							ProgressBar.Max = msg.MessageCount - 1
						End If
						
						For a = 1 To msg.MessageCount
							
							If flg = False Then
								Exit For
							End If
							
							If a Mod 2000 = 0 Then
								ProgressBar.Value = a - 1
								System.Windows.Forms.Application.DoEvents()
							End If
							
							msg.GetHeadesByNumForTree(a)
							ndeParent = MailList.Nodes.Add( , 4,  , a & ":" & msg.Subj, 1)
							ndeParent.let_Tag("N" & CStr(a) & "N")
							
							If rdb_ext = 1 Then
								'UPGRADE_WARNING: Couldn't resolve default property of object rdb.GetMessageStatusByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								If rdb.GetMessageStatusByNum(a) = 1 Then
									ndeParent.Image = 2
								End If
								
							Else
								'not supported yet
							End If
							
							MsgN(a) = a
						Next 
						
					Case BaseType.Squish
						
						If squ.MessageCount - 1 > 0 Then
							ProgressBar.Max = squ.MessageCount - 1
						End If
						
						For a = 1 To squ.MessageCount
							
							If flg = False Then
								Exit For
							End If
							
							If a Mod 2000 = 0 Then
								ProgressBar.Value = a - 1
								System.Windows.Forms.Application.DoEvents()
							End If
							
							squ.GetHeadesByNumForTree(a)
							ndeParent = MailList.Nodes.Add( , 4,  , a & ":" & squ.Subj, 1)
							ndeParent.let_Tag("S" & CStr(a) & "S")
							
							If rdb_ext = 1 Then
								'UPGRADE_WARNING: Couldn't resolve default property of object rdb.GetMessageStatusByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								If rdb.GetMessageStatusByNum(a) = 1 Then
									ndeParent.Image = 2
								End If
								
							Else
								'not supported yet
							End If
							
							'здесь присваеваем по номеру мессага его порядковый номер добовления
							MsgN(a) = msgid
							msgid = msgid + 1
							ndeOldParent = ndeParent
							
							If Len(squ.ReplayNextS) <> 0 Then
								squReplays = Split(Trim(squ.ReplayNextS), " ",  , CompareMethod.Text)
								b = CInt(squReplays(0))
								
								ndeChild = MailList.Nodes.Add(ndeParent, 4,  , CStr(b) & ":" & squ.Subj, 2)
								ndeChild.let_Tag("S" & CStr(b) & "S")
								
								'здесь присваеваем по номеру мессага его порядковый номер добавления
								MsgN(b) = msgid
								msgid = msgid + 1
								'дальше уже нужно проверять все реплееи и сроить "дерево"
								
							End If
							
						Next 
						
				End Select
				
				If Picture1.Visible = True Then
					MailList.Visible = True
					
					System.Windows.Forms.Application.DoEvents()
				End If
				
				flg = False
				
				LockWindowUpdate(0) 'снимаем залочку
				
				'уничтожение ссылок на объекты
				'UPGRADE_NOTE: Object ndeParent may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
				ndeParent = Nothing
				'UPGRADE_NOTE: Object ndeChild may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
				ndeChild = Nothing
				'UPGRADE_NOTE: Object ndeOldParent may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
				ndeOldParent = Nothing
				Erase Refs
				Erase Nums
				
			Case "ListView"
				'------------------------------------------------
				LockWindowUpdate(MailList2.hWnd)
				MailList2.ListItems.Clear()
				
				RefsCount = 0
				msgid = 1
				
				Select Case base
					
					Case BaseType.Jam
						
						If jbd.MessageCount - 1 > 0 Then
							ProgressBar.Max = jbd.MessageCount - 1
						End If
						
						For a = 1 To jbd.MessageCount
							
							If flg = False Then
								Exit For
							End If
							
							If a Mod 2000 = 0 Then
								ProgressBar.Value = a
								System.Windows.Forms.Application.DoEvents()
							End If
							
							jbd.GetHeadesByNum(a)
							MsgN(a) = a
							
							ndeEl = MailList2.ListItems.Add( ,  , a & ":" & jbd.Subj, 1, 1)
							ndeEl.let_Tag("r" & CStr(a) & "r")
							ndeEl.ToolTipText = "From: " & jbd.FromAddr
							ndeEl.SubItems(1) = jbd.From
							ndeEl.SubItems(2) = jbd.rTo
							'ndeEl.SubItems(3) = sUnixDate(jbd.DateWritten)
							'ndeEl.SubItems(4) = sUnixDate(jbd.DateArrived)
							
							If rdb_ext = 1 Then
								'UPGRADE_WARNING: Couldn't resolve default property of object rdb.GetMessageStatusByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								If rdb.GetMessageStatusByNum(a) = 1 Then
									ndeEl.SmallIcon = 2
								End If
								
							Else
								
								If jbd.MessageStatus(a) = 1 Then
									ndeEl.SmallIcon = 2
								End If
							End If
							
							'---------------------------
							'Выделение цветом
							If (InStr(1, jbd.From, "Moderator", CompareMethod.Text) <> 0) Then
								ndeEl.ForeColor = System.Convert.ToUInt32(msgModeratorColor)
								ndeEl.Bold = True
								ndeEl.SmallIcon = 3
								'сейчас получается так, что "награды" и "писки" модератора выделяются первыми
								'в последствии дополнительно выделяются рулеса.
								'смысла нет проверять рулеса отдельно. т.к. их от не модератора не бывает
								Subj = jbd.Subj
								
								If (InStr(1, Subj, "Rules", CompareMethod.Text) <> 0) Then
									ndeEl.ForeColor = System.Convert.ToUInt32(msgRulesColor)
									ndeEl.Bold = True
									ndeEl.SmallIcon = 3
								ElseIf (InStr(1, Subj, "Offtopic", CompareMethod.Text) <> 0) Then 
									ndeEl.ForeColor = System.Convert.ToUInt32(msgRulesColor)
									ndeEl.Bold = True
									ndeEl.SmallIcon = 3
								ElseIf (InStr(1, Subj, "Пpавила", CompareMethod.Text) <> 0) Then 
									ndeEl.ForeColor = System.Convert.ToUInt32(msgRulesColor)
									ndeEl.Bold = True
									ndeEl.SmallIcon = 3
								ElseIf (InStr(1, Subj, "Правила", CompareMethod.Text) <> 0) Then 
									ndeEl.ForeColor = System.Convert.ToUInt32(msgRulesColor)
									ndeEl.Bold = True
									ndeEl.SmallIcon = 3
								End If
								
							ElseIf (InStr(1, jbd.From, "[DEL]", CompareMethod.Text) <> 0) Then 
								ndeEl.ForeColor = System.Convert.ToUInt32(msgMainTextColor)
								ndeEl.SmallIcon = 4
							ElseIf (InStr(1, jbd.From, sysOp, CompareMethod.Text) <> 0) Or (InStr(1, jbd.rTo, sysOp, CompareMethod.Text) <> 0) Then 
								ndeEl.ForeColor = System.Convert.ToUInt32(msgMyMessagesColor)
								ndeEl.SmallIcon = 3
							End If
							
							'------------------------------
						Next a
						
					Case BaseType.Netmail
						
						If msg.MessageCount - 1 > 0 Then
							ProgressBar.Max = msg.MessageCount - 1
						End If
						
						For a = 1 To msg.MessageCount
							
							If flg = False Then
								Exit For
							End If
							
							If a Mod 2000 = 0 Then
								ProgressBar.Value = a - 1
								System.Windows.Forms.Application.DoEvents()
							End If
							
							msg.GetHeadesByNum(a)
							ndeEl = MailList2.ListItems.Add( ,  , a & ":" & msg.Subj, 1, 1)
							ndeEl.let_Tag("N" & CStr(a) & "N")
							ndeEl.ToolTipText = "From: " & msg.FromAddr
							ndeEl.SubItems(1) = msg.From
							ndeEl.SubItems(2) = msg.rTo
							
							If rdb_ext = 1 Then
								'UPGRADE_WARNING: Couldn't resolve default property of object rdb.GetMessageStatusByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								If rdb.GetMessageStatusByNum(a) = 1 Then
									ndeEl.SmallIcon = 2
								End If
								
							Else
								'not supported yet
							End If
							
							MsgN(a) = a
						Next a
						
					Case BaseType.Squish
						
						If squ.MessageCount - 1 > 0 Then
							ProgressBar.Max = squ.MessageCount - 1
						End If
						
						For a = 1 To squ.MessageCount
							
							If flg = False Then
								Exit For
							End If
							
							If a Mod 2000 = 0 Then
								ProgressBar.Value = a - 1
								System.Windows.Forms.Application.DoEvents()
							End If
							
							squ.GetHeadesByNum(a)
							ndeEl = MailList2.ListItems.Add( ,  , a & ":" & squ.Subj, 1, 1)
							ndeEl.let_Tag("S" & CStr(a) & "S")
							ndeEl.ToolTipText = "From: " & squ.FromAddr
							ndeEl.SubItems(1) = squ.From
							ndeEl.SubItems(2) = squ.rTo
							
							If rdb_ext = 1 Then
								'UPGRADE_WARNING: Couldn't resolve default property of object rdb.GetMessageStatusByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								If rdb.GetMessageStatusByNum(a) = 1 Then
									ndeEl.SmallIcon = 2
								End If
								
							Else
								'not supported yet
							End If
							
							MsgN(a) = a
						Next a
						
				End Select
				
				If Picture1.Visible = True Then
					MailList2.Visible = True
					
					System.Windows.Forms.Application.DoEvents()
				End If
				
				flg = False
				LockWindowUpdate(0)
				
		End Select
		
		NavigationToolBar.Buttons(1).Enabled = True
		NavigationToolBar.Buttons(2).Enabled = True
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::CreateMailList")
		End Select
		
	End Sub
	
	Private Sub NavigationToolBar_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComctlLib.IToolbarEvents_MouseUpEvent) Handles NavigationToolBar.MouseUpEvent
		
		If eventArgs.Button = VB6.MouseButtonConstants.RightButton Then
			'UPGRADE_ISSUE: Form method frmMain.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			PopupMenu(mncToolBarView)
		End If
		
	End Sub
	
	Private Sub SpliterTimer_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SpliterTimer.Tick
		Static Mpnt As POINTAPI
		
		If Splitter1Resize = True Then
			GetCursorPos(Mpnt)
			frmELWidth = frmELWidth + ((Mpnt.X - MOldX) * dx)
			MOldX = Mpnt.X
			MOldY = Mpnt.Y
			CalcSize()
		End If
		
		If Splitter2Resize = True Then
			GetCursorPos(Mpnt)
			frmTVHeight = frmTVHeight + ((Mpnt.Y - MOldY) * dy)
			MOldX = Mpnt.X
			MOldY = Mpnt.Y
			CalcSize()
		End If
		
	End Sub
	
	Private Sub Splitter1_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Splitter1.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim MCpnt As POINTAPI
		
		Splitter1Resize = True
		GetCursorPos(MCpnt)
		MOldX = MCpnt.X
		MOldY = MCpnt.Y
		
	End Sub
	
	Private Sub Splitter1_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Splitter1.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Splitter1Resize = False
	End Sub
	
	Private Sub Splitter2_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Splitter2.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim MCpnt As POINTAPI
		
		Splitter2Resize = True
		GetCursorPos(MCpnt)
		MOldX = MCpnt.X
		MOldY = MCpnt.Y
		
	End Sub
	
	Private Sub Splitter2_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Splitter2.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Splitter2Resize = False
	End Sub
	
	Private Sub ShowMail(ByRef numm As Integer, Optional ByRef Display As ShowType = ShowType.MainForm, Optional ByRef base As BaseType = BaseType.Jam)
		On Error GoTo errHandler
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim msgs() As String
		Dim i, r As Integer
		Dim str_Renamed, tmpStr As String
		
		ReadSettings()
		
		Select Case base
			
			Case BaseType.Jam
				
				Call jbd.MessageStatus(numm, 1)
				
				If Display = ShowType.MainForm Then
					jbd.GetHeadesByNum(numm)
					
					If Not mcTerminalFont.Checked Then
						jbd.GetMessageByNum(numm)
						
						If mcShowKluge.Checked Then
							MailViewer.Text = jbd.GetMessageKlugeByNum(numm) & vbCrLf & Replace(jbd.Message, vbCr, vbCrLf)
						Else
							MailViewer.Text = Replace(jbd.Message, vbCr, vbCrLf)
						End If
						
					Else
						jbd.GetMessageByNum(numm, False)
						
						'tmpStr = Space$(Len(jbd.Message))
						'CharToOem jbd.Message, tmpStr
						If mcShowKluge.Checked Then
							MailViewer.Text = CStr(jbd.GetMessageKlugeByNum(numm) & vbCrLf & MailViewer.Text = jbd.Message)
						Else
							MailViewer.Text = CStr(MailViewer.Text = jbd.Message)
						End If
						
						tmpStr = vbNullString
					End If
					
					flFrom.Text = "От кого: " & jbd.From
					
					flFromAddr.Text = jbd.FromAddr & " (" & addr2city((jbd.FromAddr)) & ")"
					hfTo.Text = "Кому: " & jbd.rTo
					
					If Len(Trim(jbd.Subj)) <> 0 Then
						MailHead.Text = jbd.Subj & " [ " & CStr(numm) & " из " & CStr(jbd.MessageCount) & " ]  " & sUnixDate(jbd.DateWritten)
					Else
						MailHead.Text = "Письмо без названия" & " [ " & CStr(numm) & " из " & CStr(jbd.MessageCount) & " ] " & sUnixDate(jbd.DateWritten)
					End If
					
					HighlightTextPlain(MailViewer, jbd)
				Else
					'показываем в форме редактора
					ViewMail(jbd, num)
				End If
				
				r = jbd.GetLastReadMsgNum(num) 'вызываем запись мессага
				
				If r < 0 Then
					'произошла ошибка
					MsgBox("Error In Save LastRead!" & r, MsgBoxStyle.Critical, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				End If
				
			Case BaseType.Netmail
				
				If Display = ShowType.MainForm Then
					msg.GetHeadesByNumAll(numm)
					msg.GetMessageByNum(numm)
					msgs = Split(msg.Message, vbCr)
					
					For i = 0 To UBound(msgs)
						
						If InStr(1, msgs(i), Chr(1), CompareMethod.Binary) = 0 Then
							str_Renamed = str_Renamed & msgs(i) & vbCrLf
						End If
						
					Next i
					
					flFrom.Text = "От кого: " & msg.From
					flFromAddr.Text = msg.FromAddr & " (" & addr2city((msg.FromAddr)) & ")"
					hfTo.Text = "Кому: " & msg.rTo
					
					If Len(Trim(msg.Subj)) <> 0 Then
						MailHead.Text = msg.Subj & " [ " & numm & " из " & msg.MessageCount & " ] " & sUnixDate(msg.DateWritten, True)
					Else
						MailHead.Text = "Письмо без названия" & " [ " & numm & " из " & msg.MessageCount & " ] " & sUnixDate(msg.DateWritten, True)
					End If
					
					If InStr(1, msg.Subj, "Poll", CompareMethod.Text) = 0 Then
						If mcShowKluge.Checked Then
							MailViewer.Text = msg.GetMessageKlugeByNum(numm) & vbCrLf & str_Renamed
						Else
							MailViewer.Text = str_Renamed
						End If
						
						HighlightTextPlain(MailViewer, msg)
					Else
						MailViewer.Text = ""
					End If
					
				Else
					'показываем в форме редакторе
					ViewMail(msg, num)
				End If
				
			Case BaseType.Squish
				
				If Display = ShowType.MainForm Then
					squ.GetHeadesByNum(numm)
					squ.GetMessageByNum(numm)
					msgs = Split(squ.Message, vbCr)
					
					For i = 0 To UBound(msgs)
						
						If InStr(1, msgs(i), Chr(1), CompareMethod.Binary) = 0 Then
							str_Renamed = str_Renamed & msgs(i) & vbCrLf
						End If
						
					Next i
					
					flFrom.Text = "От кого: " & squ.From
					flFromAddr.Text = squ.FromAddr & " (" & addr2city((squ.FromAddr)) & ")"
					hfTo.Text = "Кому: " & squ.rTo
					
					If Len(Trim(squ.Subj)) <> 0 Then
						MailHead.Text = squ.Subj & " [ " & numm & " из " & squ.MessageCount & " ] " & sUnixDate(squ.DateWritten, True)
					Else
						MailHead.Text = "Письмо без названия" & " [ " & numm & " из " & squ.MessageCount & " ] " & sUnixDate(squ.DateWritten, True)
					End If
					
					If InStr(1, squ.Subj, "Poll", CompareMethod.Text) = 0 Then
						If mcShowKluge.Checked Then
							MailViewer.Text = squ.GetMessageKlugeByNum(numm) & vbCrLf & str_Renamed
						Else
							MailViewer.Text = str_Renamed
						End If
						
						HighlightTextPlain(MailViewer, squ)
					Else
						MailViewer.Text = ""
					End If
					
				Else
					'показываем в форме редакторе
					ViewMail(squ, num)
				End If
				
		End Select
		
		Erase msgs
		
		If mcDumpMail.Checked Then
			
			Select Case EchoList.SelectedItem.SubItems(4)
				
				Case CStr(BaseType.Jam)
					MailViewer.Text = jbd.GetMessageDumpByNum(numm)
					
				Case CStr(BaseType.Netmail)
					MailViewer.Text = msg.GetMessageDumpByNum(numm)
					
				Case CStr(BaseType.Squish)
					'пока не включаем, этого метода нет
					'MailViewer.Text = squ.GetMessageDumpByNum(numm)
			End Select
			
		Else
			'работаем с UUE(только односекционными) в письме, если не включен дамп
			
			tmpStr = MailViewer.Text
			
			If True Then 'если разрешен декодинг мессаг в картинки то делаем это. Пока по умолчанию включено всегда
				picShow.Image = DecodePicture((MailViewer.Text))
				
				If CDbl(CObj(picShow.Image)) <> 0 Then 'если у нас нашлось что вставлять
					picShow.Refresh()
					
					'UPGRADE_ISSUE: Clipboard method Clipboard.Clear was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
					Clipboard.Clear()
					'UPGRADE_ISSUE: Clipboard method Clipboard.SetData was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
					Clipboard.SetData(picShow.Image)
					
					LockWindowUpdate(MailViewer.hWnd)
					MailViewer.Locked = False
					
					If InStr(1, MailViewer.Text, "section 1 of 1", CompareMethod.Text) <> 0 Then
						MailViewer.SelStart = InStr(1, MailViewer.Text, "section 1 of 1", CompareMethod.Text) - 1
					ElseIf InStr(1, MailViewer.Text, "begin 644 ", CompareMethod.Text) <> 0 Then 
						MailViewer.SelStart = InStr(1, MailViewer.Text, "begin 644 ", CompareMethod.Text) - 1
					End If
					
					MailViewer.SelLength = InStr(MailViewer.SelStart, MailViewer.Text, "end" & vbCrLf, CompareMethod.Text) - MailViewer.SelStart + 2
					modCommon.SendMessage(MailViewer.hWnd, WM_PASTE, 0, 0)
					MailViewer.SelStart = 0
					MailViewer.SelLength = 0
					MailViewer.Locked = True
					LockWindowUpdate(0)
					picDec.Visible = True
				Else
					picDec.Visible = False
				End If 'pic<>0
			End If 'picture uue
			
			'данные
			If True Then
				LockWindowUpdate(MailViewer.hWnd)
				
				If CheckDataUUE(tmpStr) Then
					cmdUUEDec.Visible = True
				Else
					cmdUUEDec.Visible = False
				End If
				
				LockWindowUpdate(0)
			End If 'data uue
			
		End If 'dump
		
		System.Windows.Forms.Application.DoEvents()
		
		Exit Sub
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::ShowMail")
		End Select
		
	End Sub
	
	'Копирует(0)/Перемещает(1) мессаг в указанную область
	Private Sub MoveCopyMessage(ByRef NumberMessage As Integer, Optional ByRef Mode As Integer = 0)
		On Error GoTo errHandler
		Dim src_bd As Object
		Dim i As Integer
		
		'выбираем эхи
		frmEchoSelect.DefInstance.Parent_Renamed = Me
		frmEchoSelect.DefInstance.ShowDialog()
		
		If Len(sEchos(0)) = 0 Then
			Exit Sub
		End If
		
		'делаем ссылку на наши базы
		Select Case EchoList.SelectedItem.SubItems(4)
			
			Case CStr(BaseType.Jam)
				src_bd = jbd
				
			Case CStr(BaseType.Netmail)
				src_bd = msg
				
			Case CStr(BaseType.Squish)
				src_bd = squ
		End Select
		
		Dim dest_mbd As New msgBase
		Dim dest_jbd As New jamBase
		Dim dest_sbd As New sqBase
		For i = 0 To UBound(sEchos)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoFileByName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Select Case LCase(VB.Right(clsEchos.GetEchoFileByName(sEchos(i)), 3))
				
				Case "msg"
					
					dest_mbd.DBName = GetGFEOption("Options", "Netmail Dir", "C:\T-Mail\Mail")
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.From. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_mbd.From = src_bd.From
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.FromAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_mbd.FromAddr = src_bd.FromAddr
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.rTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_mbd.rTo = src_bd.rTo
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.rToAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_mbd.rToAddr = src_bd.rToAddr
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.Subj. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_mbd.Subj = src_bd.Subj
					dest_mbd.MessageFlags = CInt(GetGFEOption("Options", "Netmail Flags", CStr(msgBase.MSG_ATTRIBUTES.Msg_Private + msgBase.MSG_ATTRIBUTES.Msg_Local + jamBase.MSG_ATTRIBUTE.MSG_KILLSENT)))
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.ReplayTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_mbd.ReplayTo = src_bd.ReplayTo
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.DateWritten. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_mbd.DateWritten = src_bd.DateWritten
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.DateArrived. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_mbd.DateArrived = src_bd.DateArrived
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.Message. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_mbd.Message = src_bd.Message
					Call dest_mbd.WriteMessage()
					'UPGRADE_NOTE: Object dest_mbd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
					dest_mbd = Nothing
					
				Case "jhr"
					
					'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoFileByName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_jbd.DBName = clsEchos.GetEchoFileByName(sEchos(i))
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.From. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_jbd.From = src_bd.From
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.FromAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_jbd.FromAddr = src_bd.FromAddr
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.rTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_jbd.rTo = src_bd.rTo
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.rToAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_jbd.rToAddr = src_bd.rToAddr
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.Subj. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_jbd.Subj = src_bd.Subj
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_jbd.MessageFlags = src_bd.MessageFlags
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.ReplayTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_jbd.ReplayTo = src_bd.ReplayTo
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.DateWritten. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_jbd.DateWritten = src_bd.DateWritten
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.DateArrived. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_jbd.DateArrived = src_bd.DateArrived
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.Message. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_jbd.Message = src_bd.Message
					Call dest_jbd.WriteMessage()
					'UPGRADE_NOTE: Object dest_jbd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
					dest_jbd = Nothing
					
				Case "sqd"
					
					'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoFileByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_sbd.DBName = clsEchos.GetEchoFileByNum(sEchos(i))
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.From. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_sbd.From = src_bd.From
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.FromAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_sbd.FromAddr = src_bd.FromAddr
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.rTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_sbd.rTo = src_bd.rTo
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.rToAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_sbd.rToAddr = src_bd.rToAddr
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.Subj. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_sbd.Subj = src_bd.Subj
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_sbd.MessageFlags = src_bd.MessageFlags
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.ReplayTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_sbd.ReplayTo = src_bd.ReplayTo
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.DateWritten. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_sbd.DateWritten = src_bd.DateWritten
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.DateArrived. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_sbd.DateArrived = src_bd.DateArrived
					'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.Message. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					dest_sbd.Message = src_bd.Message
					Call dest_sbd.WriteMessage()
					'UPGRADE_NOTE: Object dest_sbd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
					dest_sbd = Nothing
					
			End Select
			
		Next i
		
		If Mode = 1 Then 'удаляем исходный мессаг.
			'UPGRADE_WARNING: Couldn't resolve default property of object src_bd.DeleteMessageByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			src_bd.DeleteMessageByNum(NumberMessage)
			MsgBox("Перемещение успешно выполнено!", MsgBoxStyle.Information + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
		Else
			MsgBox("Копирование успешно выполнено!", MsgBoxStyle.Information + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
		End If
		
		'UPGRADE_NOTE: Object src_bd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		src_bd = Nothing
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 9
				Exit Sub
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::MoveCopyMessage")
		End Select
		
	End Sub
	
	Private Function GetVisibleListItems(ByRef LV As AxMSComctlLib.AxListView) As Integer
		On Error GoTo errHandler
		Dim i As Integer
		
		LV.Visible = True
		
		For i = 1 To ListView_GetCountPerPage((LV.hWnd)) + 10
			LV.ListItems.Add( ,  , "zZzzZzzZ")
		Next i
		
		System.Windows.Forms.Application.DoEvents()
		LV.Visible = False
		
		GetVisibleListItems = ListView_GetCountPerPage((LV.hWnd)) + 1
		LV.ListItems.Clear()
		
		Exit Function
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::GetVisibleListItems")
		End Select
		
	End Function
	
	Private Sub SendMultiEchoMail()
		On Error GoTo errHandler
		
		Dim MailParam(2) As String 'пока только 2а парамтра передаем 0 - To 1 - Addr 2 - mType
		'начинаем заполнять параметры для передачи
		MailParam(0) = "All"
		MailParam(1) = ""
		MailParam(2) = "EchoMail"
		
		'вызываем метод загрузки формы с параметрами(аналог параметризованного конструктора New в VB.NET)
		frmMailEditor.DefInstance.ShowFromAddrBook(MailParam)
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMain::SendMultiEchoMail")
		End Select
		
	End Sub
	
	Private Sub PrintDemo()
		Dim tpl As String
		Dim LI As Object
		Dim db As Object
		Dim tmp As String
		Dim msgFields As MessageSaveFields
		
		Select Case GetGFEOption("Options", "MailListView", "TreeView")
			
			Case "TreeView"
				LI = MailList.SelectedItem
				
			Case "ListView"
				LI = MailList2.SelectedItem
		End Select
		
		'UPGRADE_WARNING: Couldn't resolve default property of object LI.Tag. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		tmp = LI.Tag
		num = CInt(Mid(tmp, 2, Len(tmp) - 2))
		
		Select Case Mid(tmp, 1, 1)
			
			Case "r", "c" 'Echomail
				db = jbd
				
			Case "N" 'Netmail
				db = msg
				
			Case "S" 'Squish
				db = squ
		End Select
		
		'UPGRADE_WARNING: Couldn't resolve default property of object db.GetMessageByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		db.GetMessageByNum(num)
		'UPGRADE_WARNING: Couldn't resolve default property of object db.GetHeadesByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		db.GetHeadesByNum(num)
		
		With msgFields
			.AKA = Me.EchoList.SelectedItem.SubItems(3)
			'UPGRADE_WARNING: Couldn't resolve default property of object db.DateArrived. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			.DateArrived = Mod_UnixTime.sUnixDate(db.DateArrived)
			'UPGRADE_WARNING: Couldn't resolve default property of object db.DateWritten. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			.DateWritten = Mod_UnixTime.sUnixDate(db.DateWritten)
			.Description = Me.EchoList.SelectedItem.SubItems(2)
			.EchoName = Me.EchoList.SelectedItem.Text
			'UPGRADE_WARNING: Couldn't resolve default property of object db.From. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			.From = db.From
			'UPGRADE_WARNING: Couldn't resolve default property of object db.FromAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			.FromAddr = db.FromAddr
			.MessageNumber = CStr(num)
			'UPGRADE_WARNING: Couldn't resolve default property of object db.Subj. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			.Subject = db.Subj
			'UPGRADE_WARNING: Couldn't resolve default property of object db.rTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			.To_Renamed = db.rTo
			'UPGRADE_WARNING: Couldn't resolve default property of object db.rToAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			.ToAddr = db.rToAddr
			'UPGRADE_WARNING: Couldn't resolve default property of object db.MessageCount. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			.TotalMessages = db.MessageCount
		End With
		
		'Header
		tpl = vbNullString
		tpl = "- " & msgFields.Description & "(" & msgFields.AKA & ") ------------------------------ " & msgFields.EchoName & " -" & vbCrLf
		tpl = tpl & "Msg   : " & msgFields.MessageNumber & " из " & msgFields.TotalMessages & vbCrLf
		tpl = tpl & "From : " & msgFields.From & "                    " & msgFields.FromAddr & "      " & msgFields.DateWritten & vbCrLf
		tpl = tpl & "To      : " & msgFields.To_Renamed & "                    " & msgFields.ToAddr & "      " & msgFields.DateArrived & vbCrLf
		tpl = tpl & "Subj   : " & msgFields.Subject & vbCrLf
		tpl = tpl & "-------------------------------------------------------------------------------" & vbCrLf
		
		'UPGRADE_WARNING: Couldn't resolve default property of object db.Message. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		frmPrint.DefInstance.MailViewer.Text = tpl & db.Message
		ReplaceSmiles((frmPrint.DefInstance.MailViewer))
		'frmPrint.MailViewer.BackColor = vbWhite
		'frmPrint.MailViewer.SelStart = 0
		'frmPrint.MailViewer.SelLength = Len(frmPrint.MailViewer.Text)
		'frmPrint.MailViewer.SelColor = vbBlack
		'frmPrint.MailViewer.SelLength = 0
		frmPrint.DefInstance.ShowDialog()
		
	End Sub
End Class