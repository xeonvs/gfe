Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmMailEditor
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
	Public WithEvents _cmdSmile_0 As GoldButton
	Public WithEvents _cmdSmile_1 As GoldButton
	Public WithEvents _cmdSmile_2 As GoldButton
	Public WithEvents _cmdSmile_3 As GoldButton
	Public WithEvents _cmdSmile_4 As GoldButton
	Public WithEvents _cmdSmile_5 As GoldButton
	Public WithEvents _cmdSmile_6 As GoldButton
	Public WithEvents _cmdSmile_7 As GoldButton
	Public WithEvents _cmdSmile_8 As GoldButton
	Public WithEvents _cmdSmile_9 As GoldButton
	Public WithEvents _cmdSmile_10 As GoldButton
	Public WithEvents _cmdSmile_11 As GoldButton
	Public WithEvents _cmdSmile_12 As GoldButton
	Public WithEvents _cmdSmile_13 As GoldButton
	Public WithEvents _cmdSmile_14 As GoldButton
	Public WithEvents _cmdSmile_15 As GoldButton
	Public WithEvents _cmdSmile_16 As GoldButton
	Public WithEvents _cmdSmile_17 As GoldButton
	Public WithEvents _cmdSmile_18 As GoldButton
	Public WithEvents fraSmiles As System.Windows.Forms.GroupBox
	Public WithEvents imgButtons As AxMSComctlLib.AxImageList
	Public WithEvents StatusBar As AxMSComctlLib.AxStatusBar
	Public WithEvents rtfMessage As AxRichTextLib.AxRichTextBox
	Public WithEvents ToolBar As AxMSComctlLib.AxToolbar
	Public WithEvents cmdOrigin As GoldButton
	Public WithEvents txtFrom As System.Windows.Forms.ComboBox
	Public WithEvents ToolButton As AxMSComctlLib.AxImageList
	Public WithEvents cboToAddress As System.Windows.Forms.ComboBox
	Public WithEvents _cmdFlag_0 As GoldButton
	Public WithEvents _cmdFlag_1 As GoldButton
	Public WithEvents _cmdFlag_2 As GoldButton
	Public WithEvents _cmdFlag_3 As GoldButton
	Public WithEvents _cmdFlag_4 As GoldButton
	Public WithEvents _cmdFlag_6 As GoldButton
	Public WithEvents _cmdFlag_7 As GoldButton
	Public WithEvents _cmdFlag_8 As GoldButton
	Public WithEvents _cmdFlag_9 As GoldButton
	Public WithEvents _cmdFlag_10 As GoldButton
	Public WithEvents _cmdFlag_11 As GoldButton
	Public WithEvents _cmdFlag_15 As GoldButton
	Public WithEvents _cmdFlag_5 As GoldButton
	Public WithEvents _lblFlg_12 As System.Windows.Forms.Label
	Public WithEvents _lblFlg_11 As System.Windows.Forms.Label
	Public WithEvents _lblFlg_10 As System.Windows.Forms.Label
	Public WithEvents _lblFlg_9 As System.Windows.Forms.Label
	Public WithEvents _lblFlg_8 As System.Windows.Forms.Label
	Public WithEvents _lblFlg_7 As System.Windows.Forms.Label
	Public WithEvents _lblFlg_6 As System.Windows.Forms.Label
	Public WithEvents _lblFlg_5 As System.Windows.Forms.Label
	Public WithEvents _lblFlg_4 As System.Windows.Forms.Label
	Public WithEvents _lblFlg_3 As System.Windows.Forms.Label
	Public WithEvents _lblFlg_2 As System.Windows.Forms.Label
	Public WithEvents _lblFlg_1 As System.Windows.Forms.Label
	Public WithEvents _lblFlg_0 As System.Windows.Forms.Label
	Public WithEvents lblFlags As System.Windows.Forms.Label
	Public WithEvents fraFlags As System.Windows.Forms.GroupBox
	Public WithEvents cboAddress As System.Windows.Forms.ComboBox
	Public WithEvents txtSubj As System.Windows.Forms.TextBox
	Public WithEvents txtTo As System.Windows.Forms.TextBox
	Public WithEvents lblSubj As System.Windows.Forms.Label
	Public WithEvents lblTo As System.Windows.Forms.Label
	Public WithEvents lblFrom As System.Windows.Forms.Label
	Public WithEvents Picture1 As System.Windows.Forms.Panel
	Public WithEvents CoolBar1 As AxComCtl3.AxCoolBar
	Public WithEvents cmdFlag As GoldButtonArray
	Public WithEvents cmdSmile As GoldButtonArray
	Public WithEvents lblFlg As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents mnuAltRFilePlain As System.Windows.Forms.MenuItem
	Public WithEvents mnuAltRFileCitat As System.Windows.Forms.MenuItem
	Public WithEvents mnuAltRFileUUE As System.Windows.Forms.MenuItem
	Public WithEvents mnuAltR As System.Windows.Forms.MenuItem
	Public MainMenu1 As System.Windows.Forms.MainMenu
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMailEditor))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.fraSmiles = New System.Windows.Forms.GroupBox
		Me._cmdSmile_0 = New GoldButton
		Me._cmdSmile_1 = New GoldButton
		Me._cmdSmile_2 = New GoldButton
		Me._cmdSmile_3 = New GoldButton
		Me._cmdSmile_4 = New GoldButton
		Me._cmdSmile_5 = New GoldButton
		Me._cmdSmile_6 = New GoldButton
		Me._cmdSmile_7 = New GoldButton
		Me._cmdSmile_8 = New GoldButton
		Me._cmdSmile_9 = New GoldButton
		Me._cmdSmile_10 = New GoldButton
		Me._cmdSmile_11 = New GoldButton
		Me._cmdSmile_12 = New GoldButton
		Me._cmdSmile_13 = New GoldButton
		Me._cmdSmile_14 = New GoldButton
		Me._cmdSmile_15 = New GoldButton
		Me._cmdSmile_16 = New GoldButton
		Me._cmdSmile_17 = New GoldButton
		Me._cmdSmile_18 = New GoldButton
		Me.imgButtons = New AxMSComctlLib.AxImageList
		Me.StatusBar = New AxMSComctlLib.AxStatusBar
		Me.rtfMessage = New AxRichTextLib.AxRichTextBox
		Me.CoolBar1 = New AxComCtl3.AxCoolBar
		Me.ToolBar = New AxMSComctlLib.AxToolbar
		Me.Picture1 = New System.Windows.Forms.Panel
		Me.cmdOrigin = New GoldButton
		Me.txtFrom = New System.Windows.Forms.ComboBox
		Me.ToolButton = New AxMSComctlLib.AxImageList
		Me.cboToAddress = New System.Windows.Forms.ComboBox
		Me.fraFlags = New System.Windows.Forms.GroupBox
		Me._cmdFlag_0 = New GoldButton
		Me._cmdFlag_1 = New GoldButton
		Me._cmdFlag_2 = New GoldButton
		Me._cmdFlag_3 = New GoldButton
		Me._cmdFlag_4 = New GoldButton
		Me._cmdFlag_6 = New GoldButton
		Me._cmdFlag_7 = New GoldButton
		Me._cmdFlag_8 = New GoldButton
		Me._cmdFlag_9 = New GoldButton
		Me._cmdFlag_10 = New GoldButton
		Me._cmdFlag_11 = New GoldButton
		Me._cmdFlag_15 = New GoldButton
		Me._cmdFlag_5 = New GoldButton
		Me._lblFlg_12 = New System.Windows.Forms.Label
		Me._lblFlg_11 = New System.Windows.Forms.Label
		Me._lblFlg_10 = New System.Windows.Forms.Label
		Me._lblFlg_9 = New System.Windows.Forms.Label
		Me._lblFlg_8 = New System.Windows.Forms.Label
		Me._lblFlg_7 = New System.Windows.Forms.Label
		Me._lblFlg_6 = New System.Windows.Forms.Label
		Me._lblFlg_5 = New System.Windows.Forms.Label
		Me._lblFlg_4 = New System.Windows.Forms.Label
		Me._lblFlg_3 = New System.Windows.Forms.Label
		Me._lblFlg_2 = New System.Windows.Forms.Label
		Me._lblFlg_1 = New System.Windows.Forms.Label
		Me._lblFlg_0 = New System.Windows.Forms.Label
		Me.lblFlags = New System.Windows.Forms.Label
		Me.cboAddress = New System.Windows.Forms.ComboBox
		Me.txtSubj = New System.Windows.Forms.TextBox
		Me.txtTo = New System.Windows.Forms.TextBox
		Me.lblSubj = New System.Windows.Forms.Label
		Me.lblTo = New System.Windows.Forms.Label
		Me.lblFrom = New System.Windows.Forms.Label
		Me.cmdFlag = New GoldButtonArray(components)
		Me.cmdSmile = New GoldButtonArray(components)
		Me.lblFlg = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.MainMenu1 = New System.Windows.Forms.MainMenu
		Me.mnuAltR = New System.Windows.Forms.MenuItem
		Me.mnuAltRFilePlain = New System.Windows.Forms.MenuItem
		Me.mnuAltRFileCitat = New System.Windows.Forms.MenuItem
		Me.mnuAltRFileUUE = New System.Windows.Forms.MenuItem
		CType(Me.imgButtons, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.StatusBar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.rtfMessage, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ToolButton, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CoolBar1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdFlag, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdSmile, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblFlg, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Редактор::"
		Me.ClientSize = New System.Drawing.Size(514, 419)
		Me.Location = New System.Drawing.Point(1, 16)
		Me.Icon = CType(resources.GetObject("frmMailEditor.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
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
		Me.Name = "frmMailEditor"
		Me.fraSmiles.Size = New System.Drawing.Size(55, 235)
		Me.fraSmiles.Location = New System.Drawing.Point(456, 154)
		Me.fraSmiles.TabIndex = 42
		Me.fraSmiles.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSmiles.BackColor = System.Drawing.SystemColors.Control
		Me.fraSmiles.Enabled = True
		Me.fraSmiles.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSmiles.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSmiles.Visible = True
		Me.fraSmiles.Name = "fraSmiles"
		Me._cmdSmile_0.Size = New System.Drawing.Size(22, 18)
		Me._cmdSmile_0.Location = New System.Drawing.Point(6, 12)
		Me._cmdSmile_0.TabIndex = 43
		Me._cmdSmile_0.Name = "_cmdSmile_0"
		Me._cmdSmile_1.Size = New System.Drawing.Size(22, 17)
		Me._cmdSmile_1.Location = New System.Drawing.Point(30, 12)
		Me._cmdSmile_1.TabIndex = 44
		Me._cmdSmile_1.Name = "_cmdSmile_1"
		Me._cmdSmile_2.Size = New System.Drawing.Size(22, 17)
		Me._cmdSmile_2.Location = New System.Drawing.Point(6, 30)
		Me._cmdSmile_2.TabIndex = 45
		Me._cmdSmile_2.Name = "_cmdSmile_2"
		Me._cmdSmile_3.Size = New System.Drawing.Size(22, 17)
		Me._cmdSmile_3.Location = New System.Drawing.Point(30, 30)
		Me._cmdSmile_3.TabIndex = 46
		Me._cmdSmile_3.Name = "_cmdSmile_3"
		Me._cmdSmile_4.Size = New System.Drawing.Size(22, 17)
		Me._cmdSmile_4.Location = New System.Drawing.Point(6, 48)
		Me._cmdSmile_4.TabIndex = 47
		Me._cmdSmile_4.Name = "_cmdSmile_4"
		Me._cmdSmile_5.Size = New System.Drawing.Size(22, 23)
		Me._cmdSmile_5.Location = New System.Drawing.Point(30, 48)
		Me._cmdSmile_5.TabIndex = 48
		Me._cmdSmile_5.Name = "_cmdSmile_5"
		Me._cmdSmile_6.Size = New System.Drawing.Size(22, 17)
		Me._cmdSmile_6.Location = New System.Drawing.Point(6, 66)
		Me._cmdSmile_6.TabIndex = 49
		Me._cmdSmile_6.Name = "_cmdSmile_6"
		Me._cmdSmile_7.Size = New System.Drawing.Size(22, 17)
		Me._cmdSmile_7.Location = New System.Drawing.Point(30, 72)
		Me._cmdSmile_7.TabIndex = 50
		Me._cmdSmile_7.Name = "_cmdSmile_7"
		Me._cmdSmile_8.Size = New System.Drawing.Size(22, 17)
		Me._cmdSmile_8.Location = New System.Drawing.Point(6, 84)
		Me._cmdSmile_8.TabIndex = 51
		Me._cmdSmile_8.Name = "_cmdSmile_8"
		Me._cmdSmile_9.Size = New System.Drawing.Size(22, 17)
		Me._cmdSmile_9.Location = New System.Drawing.Point(30, 90)
		Me._cmdSmile_9.TabIndex = 52
		Me._cmdSmile_9.Name = "_cmdSmile_9"
		Me._cmdSmile_10.Size = New System.Drawing.Size(22, 17)
		Me._cmdSmile_10.Location = New System.Drawing.Point(6, 102)
		Me._cmdSmile_10.TabIndex = 53
		Me._cmdSmile_10.Name = "_cmdSmile_10"
		Me._cmdSmile_11.Size = New System.Drawing.Size(22, 17)
		Me._cmdSmile_11.Location = New System.Drawing.Point(30, 108)
		Me._cmdSmile_11.TabIndex = 54
		Me._cmdSmile_11.Name = "_cmdSmile_11"
		Me._cmdSmile_12.Size = New System.Drawing.Size(22, 17)
		Me._cmdSmile_12.Location = New System.Drawing.Point(6, 120)
		Me._cmdSmile_12.TabIndex = 55
		Me._cmdSmile_12.Name = "_cmdSmile_12"
		Me._cmdSmile_13.Size = New System.Drawing.Size(22, 17)
		Me._cmdSmile_13.Location = New System.Drawing.Point(30, 126)
		Me._cmdSmile_13.TabIndex = 56
		Me._cmdSmile_13.Name = "_cmdSmile_13"
		Me._cmdSmile_14.Size = New System.Drawing.Size(22, 17)
		Me._cmdSmile_14.Location = New System.Drawing.Point(6, 138)
		Me._cmdSmile_14.TabIndex = 57
		Me._cmdSmile_14.Name = "_cmdSmile_14"
		Me._cmdSmile_15.Size = New System.Drawing.Size(22, 17)
		Me._cmdSmile_15.Location = New System.Drawing.Point(30, 144)
		Me._cmdSmile_15.TabIndex = 58
		Me._cmdSmile_15.Name = "_cmdSmile_15"
		Me._cmdSmile_16.Size = New System.Drawing.Size(40, 23)
		Me._cmdSmile_16.Location = New System.Drawing.Point(6, 162)
		Me._cmdSmile_16.TabIndex = 59
		Me._cmdSmile_16.Name = "_cmdSmile_16"
		Me._cmdSmile_17.Size = New System.Drawing.Size(31, 17)
		Me._cmdSmile_17.Location = New System.Drawing.Point(12, 186)
		Me._cmdSmile_17.TabIndex = 60
		Me._cmdSmile_17.Name = "_cmdSmile_17"
		Me._cmdSmile_18.Size = New System.Drawing.Size(46, 19)
		Me._cmdSmile_18.Location = New System.Drawing.Point(6, 204)
		Me._cmdSmile_18.TabIndex = 61
		Me._cmdSmile_18.Name = "_cmdSmile_18"
		imgButtons.OcxState = CType(resources.GetObject("imgButtons.OcxState"), System.Windows.Forms.AxHost.State)
		Me.imgButtons.Location = New System.Drawing.Point(460, 60)
		Me.imgButtons.Name = "imgButtons"
		StatusBar.OcxState = CType(resources.GetObject("StatusBar.OcxState"), System.Windows.Forms.AxHost.State)
		Me.StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.StatusBar.Size = New System.Drawing.Size(514, 25)
		Me.StatusBar.Location = New System.Drawing.Point(0, 394)
		Me.StatusBar.TabIndex = 7
		Me.StatusBar.Name = "StatusBar"
		rtfMessage.OcxState = CType(resources.GetObject("rtfMessage.OcxState"), System.Windows.Forms.AxHost.State)
		Me.rtfMessage.Size = New System.Drawing.Size(449, 228)
		Me.rtfMessage.Location = New System.Drawing.Point(5, 160)
		Me.rtfMessage.TabIndex = 0
		Me.rtfMessage.Name = "rtfMessage"
		CoolBar1.OcxState = CType(resources.GetObject("CoolBar1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.CoolBar1.Dock = System.Windows.Forms.DockStyle.Top
		Me.CoolBar1.Size = New System.Drawing.Size(514, 167)
		Me.CoolBar1.Location = New System.Drawing.Point(0, 0)
		Me.CoolBar1.TabIndex = 6
		Me.CoolBar1.Name = "CoolBar1"
		ToolBar.OcxState = CType(resources.GetObject("ToolBar.OcxState"), System.Windows.Forms.AxHost.State)
		Me.ToolBar.Size = New System.Drawing.Size(498, 36)
		Me.ToolBar.Location = New System.Drawing.Point(12, 0)
		Me.ToolBar.TabIndex = 40
		Me.ToolBar.Name = "ToolBar"
		Me.Picture1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Picture1.Size = New System.Drawing.Size(498, 129)
		Me.Picture1.Location = New System.Drawing.Point(12, 38)
		Me.Picture1.TabIndex = 8
		Me.Picture1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture1.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture1.BackColor = System.Drawing.SystemColors.Control
		Me.Picture1.CausesValidation = True
		Me.Picture1.Enabled = True
		Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture1.TabStop = True
		Me.Picture1.Visible = True
		Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Picture1.Name = "Picture1"
		Me.cmdOrigin.Size = New System.Drawing.Size(36, 31)
		Me.cmdOrigin.Location = New System.Drawing.Point(445, 90)
		Me.cmdOrigin.TabIndex = 41
		Me.cmdOrigin.Name = "cmdOrigin"
		Me.txtFrom.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.txtFrom.Size = New System.Drawing.Size(266, 22)
		Me.txtFrom.Location = New System.Drawing.Point(40, 10)
		Me.txtFrom.TabIndex = 1
		Me.txtFrom.BackColor = System.Drawing.SystemColors.Window
		Me.txtFrom.CausesValidation = True
		Me.txtFrom.Enabled = True
		Me.txtFrom.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFrom.IntegralHeight = True
		Me.txtFrom.Cursor = System.Windows.Forms.Cursors.Default
		Me.txtFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFrom.Sorted = False
		Me.txtFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.txtFrom.TabStop = True
		Me.txtFrom.Visible = True
		Me.txtFrom.Name = "txtFrom"
		ToolButton.OcxState = CType(resources.GetObject("ToolButton.OcxState"), System.Windows.Forms.AxHost.State)
		Me.ToolButton.Location = New System.Drawing.Point(450, 0)
		Me.ToolButton.Name = "ToolButton"
		Me.cboToAddress.Size = New System.Drawing.Size(113, 21)
		Me.cboToAddress.Location = New System.Drawing.Point(320, 34)
		Me.cboToAddress.TabIndex = 4
		Me.ToolTip1.SetToolTip(Me.cboToAddress, "Адрес получателя")
		Me.cboToAddress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboToAddress.BackColor = System.Drawing.SystemColors.Window
		Me.cboToAddress.CausesValidation = True
		Me.cboToAddress.Enabled = True
		Me.cboToAddress.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboToAddress.IntegralHeight = True
		Me.cboToAddress.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboToAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboToAddress.Sorted = False
		Me.cboToAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboToAddress.TabStop = True
		Me.cboToAddress.Visible = True
		Me.cboToAddress.Name = "cboToAddress"
		Me.fraFlags.Size = New System.Drawing.Size(425, 44)
		Me.fraFlags.Location = New System.Drawing.Point(10, 80)
		Me.fraFlags.TabIndex = 9
		Me.fraFlags.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraFlags.BackColor = System.Drawing.SystemColors.Control
		Me.fraFlags.Enabled = True
		Me.fraFlags.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraFlags.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraFlags.Visible = True
		Me.fraFlags.Name = "fraFlags"
		Me._cmdFlag_0.Size = New System.Drawing.Size(18, 16)
		Me._cmdFlag_0.Location = New System.Drawing.Point(45, 8)
		Me._cmdFlag_0.TabIndex = 10
		Me._cmdFlag_0.Name = "_cmdFlag_0"
		Me._cmdFlag_1.Size = New System.Drawing.Size(18, 16)
		Me._cmdFlag_1.Location = New System.Drawing.Point(75, 8)
		Me._cmdFlag_1.TabIndex = 11
		Me._cmdFlag_1.Name = "_cmdFlag_1"
		Me._cmdFlag_2.Size = New System.Drawing.Size(17, 16)
		Me._cmdFlag_2.Location = New System.Drawing.Point(105, 8)
		Me._cmdFlag_2.TabIndex = 12
		Me._cmdFlag_2.Name = "_cmdFlag_2"
		Me._cmdFlag_3.Size = New System.Drawing.Size(18, 16)
		Me._cmdFlag_3.Location = New System.Drawing.Point(132, 8)
		Me._cmdFlag_3.TabIndex = 13
		Me._cmdFlag_3.Name = "_cmdFlag_3"
		Me._cmdFlag_4.Size = New System.Drawing.Size(17, 16)
		Me._cmdFlag_4.Location = New System.Drawing.Point(160, 8)
		Me._cmdFlag_4.TabIndex = 14
		Me._cmdFlag_4.Name = "_cmdFlag_4"
		Me._cmdFlag_6.Size = New System.Drawing.Size(18, 16)
		Me._cmdFlag_6.Location = New System.Drawing.Point(213, 8)
		Me._cmdFlag_6.TabIndex = 15
		Me._cmdFlag_6.Name = "_cmdFlag_6"
		Me._cmdFlag_7.Size = New System.Drawing.Size(18, 16)
		Me._cmdFlag_7.Location = New System.Drawing.Point(240, 8)
		Me._cmdFlag_7.TabIndex = 16
		Me._cmdFlag_7.Name = "_cmdFlag_7"
		Me._cmdFlag_8.Size = New System.Drawing.Size(18, 16)
		Me._cmdFlag_8.Location = New System.Drawing.Point(270, 8)
		Me._cmdFlag_8.TabIndex = 17
		Me._cmdFlag_8.Name = "_cmdFlag_8"
		Me._cmdFlag_9.Size = New System.Drawing.Size(18, 16)
		Me._cmdFlag_9.Location = New System.Drawing.Point(298, 8)
		Me._cmdFlag_9.TabIndex = 18
		Me._cmdFlag_9.Name = "_cmdFlag_9"
		Me._cmdFlag_10.Size = New System.Drawing.Size(17, 16)
		Me._cmdFlag_10.Location = New System.Drawing.Point(327, 8)
		Me._cmdFlag_10.TabIndex = 19
		Me._cmdFlag_10.Name = "_cmdFlag_10"
		Me._cmdFlag_11.Size = New System.Drawing.Size(18, 16)
		Me._cmdFlag_11.Location = New System.Drawing.Point(355, 8)
		Me._cmdFlag_11.TabIndex = 20
		Me._cmdFlag_11.Name = "_cmdFlag_11"
		Me._cmdFlag_15.Size = New System.Drawing.Size(18, 16)
		Me._cmdFlag_15.Location = New System.Drawing.Point(401, 8)
		Me._cmdFlag_15.TabIndex = 21
		Me._cmdFlag_15.Name = "_cmdFlag_15"
		Me._cmdFlag_5.Size = New System.Drawing.Size(18, 16)
		Me._cmdFlag_5.Location = New System.Drawing.Point(185, 8)
		Me._cmdFlag_5.TabIndex = 22
		Me._cmdFlag_5.Name = "_cmdFlag_5"
		Me._lblFlg_12.Text = "Pvt"
		Me._lblFlg_12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me._lblFlg_12.Size = New System.Drawing.Size(17, 14)
		Me._lblFlg_12.Location = New System.Drawing.Point(185, 24)
		Me._lblFlg_12.TabIndex = 36
		Me.ToolTip1.SetToolTip(Me._lblFlg_12, "Личное сообщение")
		Me._lblFlg_12.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFlg_12.BackColor = System.Drawing.SystemColors.Control
		Me._lblFlg_12.Enabled = True
		Me._lblFlg_12.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFlg_12.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFlg_12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFlg_12.UseMnemonic = True
		Me._lblFlg_12.Visible = True
		Me._lblFlg_12.AutoSize = True
		Me._lblFlg_12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFlg_12.Name = "_lblFlg_12"
		Me._lblFlg_11.Text = "Typ"
		Me._lblFlg_11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me._lblFlg_11.Size = New System.Drawing.Size(20, 14)
		Me._lblFlg_11.Location = New System.Drawing.Point(400, 24)
		Me._lblFlg_11.TabIndex = 35
		Me.ToolTip1.SetToolTip(Me._lblFlg_11, "Тип сообщения: Включен - Echomail; Выключен - Netmail")
		Me._lblFlg_11.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFlg_11.BackColor = System.Drawing.SystemColors.Control
		Me._lblFlg_11.Enabled = True
		Me._lblFlg_11.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFlg_11.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFlg_11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFlg_11.UseMnemonic = True
		Me._lblFlg_11.Visible = True
		Me._lblFlg_11.AutoSize = True
		Me._lblFlg_11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFlg_11.Name = "_lblFlg_11"
		Me._lblFlg_10.Text = "Frq"
		Me._lblFlg_10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me._lblFlg_10.Size = New System.Drawing.Size(18, 14)
		Me._lblFlg_10.Location = New System.Drawing.Point(357, 24)
		Me._lblFlg_10.TabIndex = 34
		Me.ToolTip1.SetToolTip(Me._lblFlg_10, "Файловый запрос")
		Me._lblFlg_10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFlg_10.BackColor = System.Drawing.SystemColors.Control
		Me._lblFlg_10.Enabled = True
		Me._lblFlg_10.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFlg_10.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFlg_10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFlg_10.UseMnemonic = True
		Me._lblFlg_10.Visible = True
		Me._lblFlg_10.AutoSize = True
		Me._lblFlg_10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFlg_10.Name = "_lblFlg_10"
		Me._lblFlg_9.Text = "Att"
		Me._lblFlg_9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me._lblFlg_9.Size = New System.Drawing.Size(16, 14)
		Me._lblFlg_9.Location = New System.Drawing.Point(329, 24)
		Me._lblFlg_9.TabIndex = 33
		Me.ToolTip1.SetToolTip(Me._lblFlg_9, "Прицелен файл")
		Me._lblFlg_9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFlg_9.BackColor = System.Drawing.SystemColors.Control
		Me._lblFlg_9.Enabled = True
		Me._lblFlg_9.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFlg_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFlg_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFlg_9.UseMnemonic = True
		Me._lblFlg_9.Visible = True
		Me._lblFlg_9.AutoSize = True
		Me._lblFlg_9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFlg_9.Name = "_lblFlg_9"
		Me._lblFlg_8.Text = "Hld"
		Me._lblFlg_8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me._lblFlg_8.Size = New System.Drawing.Size(17, 14)
		Me._lblFlg_8.Location = New System.Drawing.Point(299, 24)
		Me._lblFlg_8.TabIndex = 32
		Me.ToolTip1.SetToolTip(Me._lblFlg_8, "Задержать письмо")
		Me._lblFlg_8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFlg_8.BackColor = System.Drawing.SystemColors.Control
		Me._lblFlg_8.Enabled = True
		Me._lblFlg_8.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFlg_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFlg_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFlg_8.UseMnemonic = True
		Me._lblFlg_8.Visible = True
		Me._lblFlg_8.AutoSize = True
		Me._lblFlg_8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFlg_8.Name = "_lblFlg_8"
		Me._lblFlg_7.Text = "ReR"
		Me._lblFlg_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me._lblFlg_7.Size = New System.Drawing.Size(21, 14)
		Me._lblFlg_7.Location = New System.Drawing.Point(268, 24)
		Me._lblFlg_7.TabIndex = 31
		Me.ToolTip1.SetToolTip(Me._lblFlg_7, "Это подтверждение о прочтении")
		Me._lblFlg_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFlg_7.BackColor = System.Drawing.SystemColors.Control
		Me._lblFlg_7.Enabled = True
		Me._lblFlg_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFlg_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFlg_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFlg_7.UseMnemonic = True
		Me._lblFlg_7.Visible = True
		Me._lblFlg_7.AutoSize = True
		Me._lblFlg_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFlg_7.Name = "_lblFlg_7"
		Me._lblFlg_6.Text = "RqA"
		Me._lblFlg_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me._lblFlg_6.Size = New System.Drawing.Size(22, 14)
		Me._lblFlg_6.Location = New System.Drawing.Point(239, 24)
		Me._lblFlg_6.TabIndex = 30
		Me.ToolTip1.SetToolTip(Me._lblFlg_6, "Путь письма будет прослежен")
		Me._lblFlg_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFlg_6.BackColor = System.Drawing.SystemColors.Control
		Me._lblFlg_6.Enabled = True
		Me._lblFlg_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFlg_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFlg_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFlg_6.UseMnemonic = True
		Me._lblFlg_6.Visible = True
		Me._lblFlg_6.AutoSize = True
		Me._lblFlg_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFlg_6.Name = "_lblFlg_6"
		Me._lblFlg_5.Text = "RqR"
		Me._lblFlg_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me._lblFlg_5.Size = New System.Drawing.Size(21, 14)
		Me._lblFlg_5.Location = New System.Drawing.Point(212, 24)
		Me._lblFlg_5.TabIndex = 29
		Me.ToolTip1.SetToolTip(Me._lblFlg_5, "Требуется подтверждение о почтении")
		Me._lblFlg_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFlg_5.BackColor = System.Drawing.SystemColors.Control
		Me._lblFlg_5.Enabled = True
		Me._lblFlg_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFlg_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFlg_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFlg_5.UseMnemonic = True
		Me._lblFlg_5.Visible = True
		Me._lblFlg_5.AutoSize = True
		Me._lblFlg_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFlg_5.Name = "_lblFlg_5"
		Me._lblFlg_4.Text = "Dir"
		Me._lblFlg_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me._lblFlg_4.Size = New System.Drawing.Size(15, 14)
		Me._lblFlg_4.Location = New System.Drawing.Point(160, 24)
		Me._lblFlg_4.TabIndex = 28
		Me.ToolTip1.SetToolTip(Me._lblFlg_4, "Отправить напрямую")
		Me._lblFlg_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFlg_4.BackColor = System.Drawing.SystemColors.Control
		Me._lblFlg_4.Enabled = True
		Me._lblFlg_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFlg_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFlg_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFlg_4.UseMnemonic = True
		Me._lblFlg_4.Visible = True
		Me._lblFlg_4.AutoSize = True
		Me._lblFlg_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFlg_4.Name = "_lblFlg_4"
		Me._lblFlg_3.Text = "Crh"
		Me._lblFlg_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me._lblFlg_3.Size = New System.Drawing.Size(20, 14)
		Me._lblFlg_3.Location = New System.Drawing.Point(132, 24)
		Me._lblFlg_3.TabIndex = 27
		Me.ToolTip1.SetToolTip(Me._lblFlg_3, "Послать немедленно")
		Me._lblFlg_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFlg_3.BackColor = System.Drawing.SystemColors.Control
		Me._lblFlg_3.Enabled = True
		Me._lblFlg_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFlg_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFlg_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFlg_3.UseMnemonic = True
		Me._lblFlg_3.Visible = True
		Me._lblFlg_3.AutoSize = True
		Me._lblFlg_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFlg_3.Name = "_lblFlg_3"
		Me._lblFlg_2.Text = "Snt"
		Me._lblFlg_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me._lblFlg_2.Size = New System.Drawing.Size(18, 14)
		Me._lblFlg_2.Location = New System.Drawing.Point(105, 25)
		Me._lblFlg_2.TabIndex = 26
		Me.ToolTip1.SetToolTip(Me._lblFlg_2, "Письмо уже отправлено")
		Me._lblFlg_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFlg_2.BackColor = System.Drawing.SystemColors.Control
		Me._lblFlg_2.Enabled = True
		Me._lblFlg_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFlg_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFlg_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFlg_2.UseMnemonic = True
		Me._lblFlg_2.Visible = True
		Me._lblFlg_2.AutoSize = True
		Me._lblFlg_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFlg_2.Name = "_lblFlg_2"
		Me._lblFlg_1.Text = "K/s"
		Me._lblFlg_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me._lblFlg_1.Size = New System.Drawing.Size(17, 14)
		Me._lblFlg_1.Location = New System.Drawing.Point(75, 24)
		Me._lblFlg_1.TabIndex = 25
		Me.ToolTip1.SetToolTip(Me._lblFlg_1, "Удалить после посылки")
		Me._lblFlg_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFlg_1.BackColor = System.Drawing.SystemColors.Control
		Me._lblFlg_1.Enabled = True
		Me._lblFlg_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFlg_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFlg_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFlg_1.UseMnemonic = True
		Me._lblFlg_1.Visible = True
		Me._lblFlg_1.AutoSize = True
		Me._lblFlg_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFlg_1.Name = "_lblFlg_1"
		Me._lblFlg_0.Text = "Loc"
		Me._lblFlg_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me._lblFlg_0.Size = New System.Drawing.Size(20, 14)
		Me._lblFlg_0.Location = New System.Drawing.Point(45, 24)
		Me._lblFlg_0.TabIndex = 24
		Me.ToolTip1.SetToolTip(Me._lblFlg_0, "Письмо было написано здесь")
		Me._lblFlg_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblFlg_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblFlg_0.Enabled = True
		Me._lblFlg_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblFlg_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblFlg_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblFlg_0.UseMnemonic = True
		Me._lblFlg_0.Visible = True
		Me._lblFlg_0.AutoSize = True
		Me._lblFlg_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblFlg_0.Name = "_lblFlg_0"
		Me.lblFlags.Text = "Флаги"
		Me.lblFlags.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.lblFlags.Size = New System.Drawing.Size(34, 14)
		Me.lblFlags.Location = New System.Drawing.Point(5, 12)
		Me.lblFlags.TabIndex = 23
		Me.lblFlags.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblFlags.BackColor = System.Drawing.SystemColors.Control
		Me.lblFlags.Enabled = True
		Me.lblFlags.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblFlags.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFlags.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFlags.UseMnemonic = True
		Me.lblFlags.Visible = True
		Me.lblFlags.AutoSize = True
		Me.lblFlags.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblFlags.Name = "lblFlags"
		Me.cboAddress.Size = New System.Drawing.Size(113, 21)
		Me.cboAddress.Location = New System.Drawing.Point(320, 9)
		Me.cboAddress.TabIndex = 2
		Me.ToolTip1.SetToolTip(Me.cboAddress, "Адрес отправителя")
		Me.cboAddress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboAddress.BackColor = System.Drawing.SystemColors.Window
		Me.cboAddress.CausesValidation = True
		Me.cboAddress.Enabled = True
		Me.cboAddress.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboAddress.IntegralHeight = True
		Me.cboAddress.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboAddress.Sorted = False
		Me.cboAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboAddress.TabStop = True
		Me.cboAddress.Visible = True
		Me.cboAddress.Name = "cboAddress"
		Me.txtSubj.AutoSize = False
		Me.txtSubj.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.txtSubj.Size = New System.Drawing.Size(390, 19)
		Me.txtSubj.Location = New System.Drawing.Point(40, 58)
		Me.txtSubj.TabIndex = 5
		Me.ToolTip1.SetToolTip(Me.txtSubj, "Тема письма")
		Me.txtSubj.AcceptsReturn = True
		Me.txtSubj.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSubj.BackColor = System.Drawing.SystemColors.Window
		Me.txtSubj.CausesValidation = True
		Me.txtSubj.Enabled = True
		Me.txtSubj.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSubj.HideSelection = True
		Me.txtSubj.ReadOnly = False
		Me.txtSubj.Maxlength = 0
		Me.txtSubj.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSubj.MultiLine = False
		Me.txtSubj.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSubj.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSubj.TabStop = True
		Me.txtSubj.Visible = True
		Me.txtSubj.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSubj.Name = "txtSubj"
		Me.txtTo.AutoSize = False
		Me.txtTo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.txtTo.Size = New System.Drawing.Size(266, 19)
		Me.txtTo.Location = New System.Drawing.Point(40, 35)
		Me.txtTo.TabIndex = 3
		Me.txtTo.AcceptsReturn = True
		Me.txtTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTo.BackColor = System.Drawing.SystemColors.Window
		Me.txtTo.CausesValidation = True
		Me.txtTo.Enabled = True
		Me.txtTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTo.HideSelection = True
		Me.txtTo.ReadOnly = False
		Me.txtTo.Maxlength = 0
		Me.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTo.MultiLine = False
		Me.txtTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTo.TabStop = True
		Me.txtTo.Visible = True
		Me.txtTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTo.Name = "txtTo"
		Me.lblSubj.Text = "Тема:"
		Me.lblSubj.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.lblSubj.Size = New System.Drawing.Size(31, 14)
		Me.lblSubj.Location = New System.Drawing.Point(1, 60)
		Me.lblSubj.TabIndex = 39
		Me.lblSubj.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSubj.BackColor = System.Drawing.SystemColors.Control
		Me.lblSubj.Enabled = True
		Me.lblSubj.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSubj.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSubj.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSubj.UseMnemonic = True
		Me.lblSubj.Visible = True
		Me.lblSubj.AutoSize = True
		Me.lblSubj.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSubj.Name = "lblSubj"
		Me.lblTo.Text = "Кому:"
		Me.lblTo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.lblTo.Size = New System.Drawing.Size(31, 14)
		Me.lblTo.Location = New System.Drawing.Point(1, 38)
		Me.lblTo.TabIndex = 38
		Me.lblTo.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTo.BackColor = System.Drawing.SystemColors.Control
		Me.lblTo.Enabled = True
		Me.lblTo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTo.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTo.UseMnemonic = True
		Me.lblTo.Visible = True
		Me.lblTo.AutoSize = True
		Me.lblTo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTo.Name = "lblTo"
		Me.lblFrom.Text = "От:"
		Me.lblFrom.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.lblFrom.Size = New System.Drawing.Size(16, 14)
		Me.lblFrom.Location = New System.Drawing.Point(16, 12)
		Me.lblFrom.TabIndex = 37
		Me.lblFrom.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblFrom.BackColor = System.Drawing.SystemColors.Control
		Me.lblFrom.Enabled = True
		Me.lblFrom.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblFrom.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFrom.UseMnemonic = True
		Me.lblFrom.Visible = True
		Me.lblFrom.AutoSize = True
		Me.lblFrom.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblFrom.Name = "lblFrom"
		Me.mnuAltR.Text = "mnuAltR"
		Me.mnuAltR.Visible = False
		Me.mnuAltR.Checked = False
		Me.mnuAltR.Enabled = True
		Me.mnuAltR.MDIList = False
		Me.mnuAltRFilePlain.Text = "Файл как &простой текст"
		Me.mnuAltRFilePlain.Checked = False
		Me.mnuAltRFilePlain.Enabled = True
		Me.mnuAltRFilePlain.Visible = True
		Me.mnuAltRFilePlain.MDIList = False
		Me.mnuAltRFileCitat.Text = "Файл как &цитированный текст"
		Me.mnuAltRFileCitat.Checked = False
		Me.mnuAltRFileCitat.Enabled = True
		Me.mnuAltRFileCitat.Visible = True
		Me.mnuAltRFileCitat.MDIList = False
		Me.mnuAltRFileUUE.Text = "Файл закодироваать в виде &UUE"
		Me.mnuAltRFileUUE.Checked = False
		Me.mnuAltRFileUUE.Enabled = True
		Me.mnuAltRFileUUE.Visible = True
		Me.mnuAltRFileUUE.MDIList = False
		Me.Controls.Add(fraSmiles)
		Me.Controls.Add(imgButtons)
		Me.Controls.Add(StatusBar)
		Me.Controls.Add(rtfMessage)
		Me.Controls.Add(CoolBar1)
		Me.fraSmiles.Controls.Add(_cmdSmile_0)
		Me.fraSmiles.Controls.Add(_cmdSmile_1)
		Me.fraSmiles.Controls.Add(_cmdSmile_2)
		Me.fraSmiles.Controls.Add(_cmdSmile_3)
		Me.fraSmiles.Controls.Add(_cmdSmile_4)
		Me.fraSmiles.Controls.Add(_cmdSmile_5)
		Me.fraSmiles.Controls.Add(_cmdSmile_6)
		Me.fraSmiles.Controls.Add(_cmdSmile_7)
		Me.fraSmiles.Controls.Add(_cmdSmile_8)
		Me.fraSmiles.Controls.Add(_cmdSmile_9)
		Me.fraSmiles.Controls.Add(_cmdSmile_10)
		Me.fraSmiles.Controls.Add(_cmdSmile_11)
		Me.fraSmiles.Controls.Add(_cmdSmile_12)
		Me.fraSmiles.Controls.Add(_cmdSmile_13)
		Me.fraSmiles.Controls.Add(_cmdSmile_14)
		Me.fraSmiles.Controls.Add(_cmdSmile_15)
		Me.fraSmiles.Controls.Add(_cmdSmile_16)
		Me.fraSmiles.Controls.Add(_cmdSmile_17)
		Me.fraSmiles.Controls.Add(_cmdSmile_18)
		Me.CoolBar1.Controls.Add(ToolBar)
		Me.CoolBar1.Controls.Add(Picture1)
		Me.Picture1.Controls.Add(cmdOrigin)
		Me.Picture1.Controls.Add(txtFrom)
		Me.Picture1.Controls.Add(ToolButton)
		Me.Picture1.Controls.Add(cboToAddress)
		Me.Picture1.Controls.Add(fraFlags)
		Me.Picture1.Controls.Add(cboAddress)
		Me.Picture1.Controls.Add(txtSubj)
		Me.Picture1.Controls.Add(txtTo)
		Me.Picture1.Controls.Add(lblSubj)
		Me.Picture1.Controls.Add(lblTo)
		Me.Picture1.Controls.Add(lblFrom)
		Me.fraFlags.Controls.Add(_cmdFlag_0)
		Me.fraFlags.Controls.Add(_cmdFlag_1)
		Me.fraFlags.Controls.Add(_cmdFlag_2)
		Me.fraFlags.Controls.Add(_cmdFlag_3)
		Me.fraFlags.Controls.Add(_cmdFlag_4)
		Me.fraFlags.Controls.Add(_cmdFlag_6)
		Me.fraFlags.Controls.Add(_cmdFlag_7)
		Me.fraFlags.Controls.Add(_cmdFlag_8)
		Me.fraFlags.Controls.Add(_cmdFlag_9)
		Me.fraFlags.Controls.Add(_cmdFlag_10)
		Me.fraFlags.Controls.Add(_cmdFlag_11)
		Me.fraFlags.Controls.Add(_cmdFlag_15)
		Me.fraFlags.Controls.Add(_cmdFlag_5)
		Me.fraFlags.Controls.Add(_lblFlg_12)
		Me.fraFlags.Controls.Add(_lblFlg_11)
		Me.fraFlags.Controls.Add(_lblFlg_10)
		Me.fraFlags.Controls.Add(_lblFlg_9)
		Me.fraFlags.Controls.Add(_lblFlg_8)
		Me.fraFlags.Controls.Add(_lblFlg_7)
		Me.fraFlags.Controls.Add(_lblFlg_6)
		Me.fraFlags.Controls.Add(_lblFlg_5)
		Me.fraFlags.Controls.Add(_lblFlg_4)
		Me.fraFlags.Controls.Add(_lblFlg_3)
		Me.fraFlags.Controls.Add(_lblFlg_2)
		Me.fraFlags.Controls.Add(_lblFlg_1)
		Me.fraFlags.Controls.Add(_lblFlg_0)
		Me.fraFlags.Controls.Add(lblFlags)
		Me.cmdFlag.SetIndex(_cmdFlag_0, CType(0, Short))
		Me.cmdFlag.SetIndex(_cmdFlag_1, CType(1, Short))
		Me.cmdFlag.SetIndex(_cmdFlag_2, CType(2, Short))
		Me.cmdFlag.SetIndex(_cmdFlag_3, CType(3, Short))
		Me.cmdFlag.SetIndex(_cmdFlag_4, CType(4, Short))
		Me.cmdFlag.SetIndex(_cmdFlag_6, CType(6, Short))
		Me.cmdFlag.SetIndex(_cmdFlag_7, CType(7, Short))
		Me.cmdFlag.SetIndex(_cmdFlag_8, CType(8, Short))
		Me.cmdFlag.SetIndex(_cmdFlag_9, CType(9, Short))
		Me.cmdFlag.SetIndex(_cmdFlag_10, CType(10, Short))
		Me.cmdFlag.SetIndex(_cmdFlag_11, CType(11, Short))
		Me.cmdFlag.SetIndex(_cmdFlag_15, CType(15, Short))
		Me.cmdFlag.SetIndex(_cmdFlag_5, CType(5, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_0, CType(0, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_1, CType(1, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_2, CType(2, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_3, CType(3, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_4, CType(4, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_5, CType(5, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_6, CType(6, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_7, CType(7, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_8, CType(8, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_9, CType(9, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_10, CType(10, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_11, CType(11, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_12, CType(12, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_13, CType(13, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_14, CType(14, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_15, CType(15, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_16, CType(16, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_17, CType(17, Short))
		Me.cmdSmile.SetIndex(_cmdSmile_18, CType(18, Short))
		Me.lblFlg.SetIndex(_lblFlg_12, CType(12, Short))
		Me.lblFlg.SetIndex(_lblFlg_11, CType(11, Short))
		Me.lblFlg.SetIndex(_lblFlg_10, CType(10, Short))
		Me.lblFlg.SetIndex(_lblFlg_9, CType(9, Short))
		Me.lblFlg.SetIndex(_lblFlg_8, CType(8, Short))
		Me.lblFlg.SetIndex(_lblFlg_7, CType(7, Short))
		Me.lblFlg.SetIndex(_lblFlg_6, CType(6, Short))
		Me.lblFlg.SetIndex(_lblFlg_5, CType(5, Short))
		Me.lblFlg.SetIndex(_lblFlg_4, CType(4, Short))
		Me.lblFlg.SetIndex(_lblFlg_3, CType(3, Short))
		Me.lblFlg.SetIndex(_lblFlg_2, CType(2, Short))
		Me.lblFlg.SetIndex(_lblFlg_1, CType(1, Short))
		Me.lblFlg.SetIndex(_lblFlg_0, CType(0, Short))
		CType(Me.lblFlg, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdSmile, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdFlag, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CoolBar1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ToolButton, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.rtfMessage, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.StatusBar, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.imgButtons, System.ComponentModel.ISupportInitialize).EndInit()
		Me.mnuAltR.Index = 0
		MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuAltR})
		Me.mnuAltRFilePlain.Index = 0
		Me.mnuAltRFileCitat.Index = 1
		Me.mnuAltRFileUUE.Index = 2
		mnuAltR.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuAltRFilePlain, Me.mnuAltRFileCitat, Me.mnuAltRFileUUE})
		Me.Menu = MainMenu1
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmMailEditor
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmMailEditor
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmMailEditor()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
	Private Declare Function OemToChar Lib "user32"  Alias "OemToCharA"(ByVal lpszSrc As String, ByVal lpszDst As String) As Integer
	
	Private Enum Flash
		Off = 0
		Onn = 1
	End Enum
	
	'тип хранящий в себе пары замен
	'лежат замены Replace(0) что заменяем, Replace(1) на что заменяем
	Private Structure Replacment
		'UPGRADE_NOTE: Replace was upgraded to Replace_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Replace_Renamed() As String
	End Structure
	
	'тип хранящий в себе сочетание клавиш и действие
	Private Structure HotKeyAct
		Dim Key As Integer
		Dim mask As Integer
		Dim Action As String
	End Structure
	
	Private Const MeMinWidth As Integer = 510
	Private Const MeMinHeight As Integer = 300
	
	Private dx, dy As Short 'размеры формы
	Private sEchos() As String 'тут храниться список эх по которым нада разослать мессаг
	Private OldAddr As String 'адрес находящийся по загрузке в комбобоксе
	Public txtChangeFlag As Boolean 'флаг изменения текста
	Private NetmailKsFlag As Boolean 'флаг запроса удаления письма в нетмейле
	Private Replaces() As Replacment 'Список замен
	Private BookMailParam() As String 'параметры письма из адресной книги
	Private BookShow As Boolean 'Флаг указывающий на то, что в данный момент грузится из книги
	Private HotKeys() As HotKeyAct 'Список ключивых клавиш и действий
	
	'получает список выбранных эх
	Public WriteOnly Property SelectedEchos() As String()
		Set(ByVal Value() As String)
			sEchos = VB6.CopyArray(Value)
		End Set
	End Property
	
	'получает ориджин для замены
	Public WriteOnly Property Origin() As String
		Set(ByVal Value As String)
			On Error GoTo errHandler
			Dim RegEx As New VBScript_RegExp_55.RegExp ' РегЭкспы
			Dim colMatches As VBScript_RegExp_55.MatchCollection ' коллекция этих образцов
			
			RegEx.MultiLine = True ' многострочный текст
			RegEx.[Global] = True ' будем проходить всю строку
			RegEx.IgnoreCase = True ' игнорируем регистр символов
			
			'выкусываем все ориджины. Прикольный паттерн, вобщем он ищет ориджин в котором есть (адрес).
			RegEx.Pattern = "\s* Origin:(.*?)\s\((\d+:\d+/\d+\.{0,1}\d*)"
			colMatches = RegEx.Execute(rtfMessage.Text) 'получаем результат
			'типа мы не трогаем чужие ориджины, меняем только свой. он всегда последний
			'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			colMatches = RegEx.Execute(colMatches.item(colMatches.Count - 1).Value) 'получаем результат
			
			'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			rtfMessage.Text = Replace(rtfMessage.Text, colMatches.item(0).SubMatches(0), " " & Value & " ")
			
			HighlightTextPlain((Me.rtfMessage), TransferMessage.base, False)
			
			'UPGRADE_NOTE: Object colMatches may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
			colMatches = Nothing
			'UPGRADE_NOTE: Object RegEx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
			RegEx = Nothing
			
			txtChangeFlag = False
			Exit Property
			
errHandler: 
			
			Select Case Err.Number
				
				Case Else
					ErrorMessage(Err.Number, Err.Description, "frmMailEditor::Origin")
			End Select
			
		End Set
	End Property
	
	'выгружает форму из другой формы
	Public Sub UnloadMe()
		Me.Close()
	End Sub
	
	'UPGRADE_WARNING: Event cboAddress.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	'UPGRADE_WARNING: ComboBox event cboAddress.Change was upgraded to cboAddress.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2074"'
	Private Sub cboAddress_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAddress.TextChanged
		Static NotFirstFlag As Boolean
		
		txtChangeFlag = NotFirstFlag
		NotFirstFlag = True
		
	End Sub
	
	'UPGRADE_WARNING: Event cboAddress.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub cboAddress_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAddress.SelectedIndexChanged
		On Error GoTo errHandler
		Dim RegEx As New VBScript_RegExp_55.RegExp 'регэкспы
		Dim colMatches As VBScript_RegExp_55.MatchCollection ' коллекция этих образцов
		
		RegEx.IgnoreCase = True ' игнорируем регистр символов
		RegEx.Pattern = "\d+:\d+/\d+\.{0,1}\d*" 'шаблон для выборки 4D адреса из 5D
		colMatches = RegEx.Execute(cboAddress.Text) 'получаем результат
		
		'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		rtfMessage.Text = Replace(rtfMessage.Text, OldAddr, colMatches.item(0).Value)
		'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		OldAddr = colMatches.item(0).Value
		
		HighlightTextPlain((Me.rtfMessage), TransferMessage.base, False)
		txtChangeFlag = False
		
		'UPGRADE_NOTE: Object colMatches may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		colMatches = Nothing
		'UPGRADE_NOTE: Object RegEx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		RegEx = Nothing
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::cboAddress_Click")
		End Select
		
	End Sub
	
	Private Sub cboAddress_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cboAddress.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		'F2- Save Message
		If KeyCode = System.Windows.Forms.Keys.F2 Then
			WriteMessage()
			
			System.Windows.Forms.Application.DoEvents()
		End If
		
		'quit
		If KeyCode = System.Windows.Forms.Keys.Escape Then
			Me.Close()
		End If
		
	End Sub
	
	'UPGRADE_WARNING: Event cboToAddress.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	'UPGRADE_WARNING: ComboBox event cboToAddress.Change was upgraded to cboToAddress.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2074"'
	Private Sub cboToAddress_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboToAddress.TextChanged
		Static NotFirstFlag As Boolean
		
		txtChangeFlag = NotFirstFlag
		NotFirstFlag = True
		
	End Sub
	
	Private Sub cboToAddress_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cboToAddress.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		'F2- Save Message
		If KeyCode = System.Windows.Forms.Keys.F2 Then
			WriteMessage()
			
			System.Windows.Forms.Application.DoEvents()
		End If
		
		'quit
		If KeyCode = System.Windows.Forms.Keys.Escape Then
			Me.Close()
		End If
		
	End Sub
	
	Private Sub cmdFlag_Click(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles cmdFlag.Click
		Dim Index As Short = cmdFlag.GetIndex(Sender)
		
		If Index <> 15 Then '11й флажок используем только для индикации
			If cmdFlag(Index).Picture.equals(imgButtons.ListImages.item(1).Picture) Then
				'соответственно выставляем нужный флаг
				cmdFlag(Index).Picture = imgButtons.ListImages.item(2).Picture
				cmdFlag(Index).PictureDown = imgButtons.ListImages.item(1).Picture
			Else
				'соответственно выставляем нужный флаг
				cmdFlag(Index).Picture = imgButtons.ListImages.item(1).Picture
				cmdFlag(Index).PictureDown = imgButtons.ListImages.item(2).Picture
			End If
		End If
		
		System.Windows.Forms.Application.DoEvents()
	End Sub
	
	Private Sub cmdNdlSelect_Click()
		MsgBox("Not Worked Yet! Try latter.", MsgBoxStyle.Information + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
	End Sub
	
	Private Sub cmdOrigin_Click(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles cmdOrigin.Click
		frmDisplayOrigins.DefInstance.SetBounds(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + (VB6.PixelsToTwipsX(cmdOrigin.Left) - VB6.PixelsToTwipsX(frmDisplayOrigins.DefInstance.Width)) + 1.45 * VB6.PixelsToTwipsX(cmdOrigin.Width)), VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 2 * VB6.PixelsToTwipsY(cmdOrigin.Top)), 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
		frmDisplayOrigins.DefInstance.Parent_Renamed = Me
		
		If frmDisplayOrigins.DefInstance.Visible = False Then
			frmDisplayOrigins.DefInstance.ShowDialog()
		End If
		
	End Sub
	
	Private Sub cmdSmile_Click(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles cmdSmile.Click
		Dim Index As Short = cmdSmile.GetIndex(Sender)
		LockWindowUpdate(rtfMessage.hWnd)
		rtfMessage.SelLength = 0
		
		Select Case Index
			
			Case 0
				rtfMessage.SelText = " :)"
				
			Case 1
				rtfMessage.SelText = " ;)"
				
			Case 2
				rtfMessage.SelText = " :("
				
			Case 3
				rtfMessage.SelText = " :`("
				
			Case 4
				rtfMessage.SelText = " :D"
				
			Case 5
				rtfMessage.SelText = " :\"
				
			Case 6
				rtfMessage.SelText = " 8)"
				
			Case 7
				rtfMessage.SelText = " xx("
				
			Case 8
				rtfMessage.SelText = " :P"
				
			Case 9
				rtfMessage.SelText = " :O"
				
			Case 10
				rtfMessage.SelText = " lol"
				
			Case 11
				rtfMessage.SelText = " %)"
				
			Case 12
				rtfMessage.SelText = " :]"
				
			Case 13
				rtfMessage.SelText = " :o)"
				
			Case 14
				rtfMessage.SelText = " :["
				
			Case 15
				rtfMessage.SelText = " beer"
				
			Case 16
				rtfMessage.SelText = " tnx!"
				
			Case 17
				rtfMessage.SelText = " :*"
				
			Case 18
				rtfMessage.SelText = " O:-)"
				
		End Select
		
		LockWindowUpdate(0)
		
	End Sub
	
	Private Sub CoolBar1_HeightChanged(ByVal eventSender As System.Object, ByVal eventArgs As AxComCtl3.__CoolBar_HeightChangedEvent) Handles CoolBar1.HeightChanged
		CalcSize()
	End Sub
	
	Private Sub ReadFonts()
		On Error GoTo errHandler
		Dim cl() As String
		
		'Шрифт окна редактора
		cl = Split(GetGFEOption("Fonts", "EditorWindowFont", "Times - Regular - 8pt"), " - ")
		rtfMessage.Font = VB6.FontChangeName(rtfMessage.Font, cl(0))
		
		If InStr(1, cl(1), " ") <> 0 Then 'сочитание стилей
			rtfMessage.Font = VB6.FontChangeBold(rtfMessage.Font, True)
			rtfMessage.Font = VB6.FontChangeItalic(rtfMessage.Font, True)
		Else
			
			If InStr(1, cl(1), "Bold", CompareMethod.Text) <> 0 Then
				rtfMessage.Font = VB6.FontChangeBold(rtfMessage.Font, True)
			Else
				rtfMessage.Font = VB6.FontChangeBold(rtfMessage.Font, False)
			End If
			
			If InStr(1, cl(1), "Italic", CompareMethod.Text) <> 0 Then
				rtfMessage.Font = VB6.FontChangeItalic(rtfMessage.Font, True)
			Else
				rtfMessage.Font = VB6.FontChangeItalic(rtfMessage.Font, False)
			End If
		End If
		
		rtfMessage.Font = VB6.FontChangeSize(rtfMessage.Font, CDec(Mid(cl(2), 1, Len(cl(2)) - 2)))
		
		'From
		cl = Split(GetGFEOption("Fonts", "FromFont", "Arial - Bold - 8pt"), " - ")
		txtFrom.Font = VB6.FontChangeName(txtFrom.Font, cl(0))
		
		If InStr(1, cl(1), " ") <> 0 Then 'сочитание стилей
			txtFrom.Font = VB6.FontChangeBold(txtFrom.Font, True)
			txtFrom.Font = VB6.FontChangeItalic(txtFrom.Font, True)
		Else
			
			If InStr(1, cl(1), "Bold", CompareMethod.Text) <> 0 Then
				txtFrom.Font = VB6.FontChangeBold(txtFrom.Font, True)
			Else
				txtFrom.Font = VB6.FontChangeBold(txtFrom.Font, False)
			End If
			
			If InStr(1, cl(1), "Italic", CompareMethod.Text) <> 0 Then
				txtFrom.Font = VB6.FontChangeItalic(txtFrom.Font, True)
			Else
				txtFrom.Font = VB6.FontChangeItalic(txtFrom.Font, False)
			End If
		End If
		
		txtFrom.Font = VB6.FontChangeSize(txtFrom.Font, CDec(Mid(cl(2), 1, Len(cl(2)) - 2)))
		
		'To
		cl = Split(GetGFEOption("Fonts", "ToFont", "Arial - Bold - 8pt"), " - ")
		txtTo.Font = VB6.FontChangeName(txtTo.Font, cl(0))
		
		If InStr(1, cl(1), " ") <> 0 Then 'сочитание стилей
			txtTo.Font = VB6.FontChangeBold(txtTo.Font, True)
			txtTo.Font = VB6.FontChangeItalic(txtTo.Font, True)
		Else
			
			If InStr(1, cl(1), "Bold", CompareMethod.Text) <> 0 Then
				txtTo.Font = VB6.FontChangeBold(txtTo.Font, True)
			Else
				txtTo.Font = VB6.FontChangeBold(txtTo.Font, False)
			End If
			
			If InStr(1, cl(1), "Italic", CompareMethod.Text) <> 0 Then
				txtTo.Font = VB6.FontChangeItalic(txtTo.Font, True)
			Else
				txtTo.Font = VB6.FontChangeItalic(txtTo.Font, False)
			End If
		End If
		
		txtTo.Font = VB6.FontChangeSize(txtTo.Font, CDec(Mid(cl(2), 1, Len(cl(2)) - 2)))
		
		'Subj
		cl = Split(GetGFEOption("Fonts", "SubjFont", "Arial - Bold Italic - 8pt"), " - ")
		txtSubj.Font = VB6.FontChangeName(txtSubj.Font, cl(0))
		
		If InStr(1, cl(1), " ") <> 0 Then 'сочитание стилей
			txtSubj.Font = VB6.FontChangeBold(txtSubj.Font, True)
			txtSubj.Font = VB6.FontChangeItalic(txtSubj.Font, True)
		Else
			
			If InStr(1, cl(1), "Bold", CompareMethod.Text) <> 0 Then
				txtSubj.Font = VB6.FontChangeBold(txtSubj.Font, True)
			Else
				txtSubj.Font = VB6.FontChangeBold(txtSubj.Font, False)
			End If
			
			If InStr(1, cl(1), "Italic", CompareMethod.Text) <> 0 Then
				txtSubj.Font = VB6.FontChangeItalic(txtSubj.Font, True)
			Else
				txtSubj.Font = VB6.FontChangeItalic(txtSubj.Font, False)
			End If
		End If
		
		txtSubj.Font = VB6.FontChangeSize(txtSubj.Font, CDec(Mid(cl(2), 1, Len(cl(2)) - 2)))
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::ReadFonts")
		End Select
		
	End Sub
	
	Private Sub frmMailEditor_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		On Error GoTo errHandler
		Dim i As Integer
		Dim smileFlag As Boolean
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim msgs() As String
		Dim str_Renamed As String
		
		'init
		modCommonDialog.hwndOwner = Me.Handle.ToInt32
		
		'перезагрузка смайлов
		Call modTextWork.LoadSmiles()
		
		dx = VB6.TwipsPerPixelX
		dy = VB6.TwipsPerPixelY
		
		Me.Top = VB6.TwipsToPixelsY(CSng(GetGFEOption("Screen\Editor", "Y", CStr(VB6.PixelsToTwipsY(Me.Top)))))
		Me.Left = VB6.TwipsToPixelsX(CSng(GetGFEOption("Screen\Editor", "X", CStr(VB6.PixelsToTwipsX(Me.Left)))))
		Me.Width = VB6.TwipsToPixelsX(CSng(GetGFEOption("Screen\Editor", "Width", CStr(VB6.PixelsToTwipsX(Me.Width)))))
		Me.Height = VB6.TwipsToPixelsY(CSng(GetGFEOption("Screen\Editor", "Height", CStr(VB6.PixelsToTwipsY(Me.Height)))))
		Me.WindowState = CInt(GetGFEOption("Screen\Editor", "WindowState", CStr(Me.WindowState)))
		
		Picture1_Resize(Picture1, New System.EventArgs())
		ReadFonts()
		
		smileFlag = True
		
		'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.BaseType. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Select Case TransferMessage.base.BaseType
			
			Case "JAM" 'jam
				cboToAddress.Visible = False 'в эхомейле нет адреса получателя
				
				If TransferMessage.Mode <> modCommon.ReplayMode.NewMail And TransferMessage.Mode <> modCommon.ReplayMode.BookMail Then
					'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.GetMessageByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					TransferMessage.base.GetMessageByNum(TransferMessage.CurrentMail)
					'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.GetHeadesByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					TransferMessage.base.GetHeadesByNum(TransferMessage.CurrentMail)
				End If
				
			Case "MSG" 'netmail
				
				If TransferMessage.Mode <> modCommon.ReplayMode.NewMail And TransferMessage.Mode <> modCommon.ReplayMode.BookMail Then
					cboToAddress.Visible = True 'тута есть этот адрес
					'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.GetMessageByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					TransferMessage.base.GetMessageByNum(TransferMessage.CurrentMail)
					'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.GetHeadesByNumAll. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					TransferMessage.base.GetHeadesByNumAll(TransferMessage.CurrentMail) '- попользуем медленный метод
					'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.FromAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					cboToAddress.Text = TransferMessage.base.FromAddr 'добавляем тут адрес получателя
				End If
				
			Case "SQU" 'squish
				cboToAddress.Visible = False 'в эхомейле нет адреса получателя
				
				If TransferMessage.Mode <> modCommon.ReplayMode.NewMail And TransferMessage.Mode <> modCommon.ReplayMode.BookMail Then
					'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.GetMessageByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					TransferMessage.base.GetMessageByNum(TransferMessage.CurrentMail)
					'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.GetHeadesByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					TransferMessage.base.GetHeadesByNum(TransferMessage.CurrentMail)
				End If
				
		End Select
		
		If TransferMessage.Mode <> modCommon.ReplayMode.NewMail And TransferMessage.Mode <> modCommon.ReplayMode.BookMail Then
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.Message. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			msgs = Split(TransferMessage.base.Message, vbCr)
		End If
		
		'если у нас просмотр мессага, то ненадо грузить наши данные
		If TransferMessage.Mode <> modCommon.ReplayMode.ViewMails Then
			'подгружаем наши настройки из реестра
			'загружаем адреса и ака
			cboAddress.Items.Add(GetGFEOption("Options", "MainAddress"))
			
			If Len(frmMain.DefInstance.EchoList.SelectedItem.SubItems(3)) <> 0 Then
				cboAddress.Text = frmMain.DefInstance.EchoList.SelectedItem.SubItems(3)
			Else
				cboAddress.Text = GetGFEOption("Options", "MainAddress")
			End If
			
			i = 0
			While Len(GetGFEOption("Options", "AkA" & i)) <> 0
				cboAddress.Items.Add(GetGFEOption("Options", "AkA" & i))
				i = i + 1
			End While
			i = 0
			txtFrom.Text = GetGFEOption("Options", "UserName0")
			While Len(GetGFEOption("Options", "UserName" & i)) <> 0
				txtFrom.Items.Add(GetGFEOption("Options", "UserName" & i))
				i = i + 1
			End While
		Else
			'запрещаем некоторые кнопочки
			ToolBar.Buttons(1).Enabled = False 'sent
			ToolBar.Buttons(3).Enabled = False 'cut
			ToolBar.Buttons(5).Enabled = False 'paste
			ToolBar.Buttons(7).Enabled = False 'undo
		End If
		
		Select Case TransferMessage.Mode
			
			Case modCommon.ReplayMode.NewMail
				txtTo.Text = "All"
				txtSubj.Text = ""
				rtfMessage.Text = ""
				Me.Text = "Редактор::[" & frmMain.DefInstance.EchoList.SelectedItem.Text & "]::Новое Письмо"
				
			Case modCommon.ReplayMode.ReplayFrom
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.From. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				txtTo.Text = TransferMessage.base.From
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.Subj. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				txtSubj.Text = TransferMessage.base.Subj
				'цетируем мессаг
				str_Renamed = Citat(msgs)
				Me.Text = "Редактор::[" & frmMain.DefInstance.EchoList.SelectedItem.Text & "]::Ответ к " & txtTo.Text
				smileFlag = False
				
			Case modCommon.ReplayMode.ReplayFromNotCit
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.From. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				txtTo.Text = TransferMessage.base.From
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.Subj. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				txtSubj.Text = TransferMessage.base.Subj
				Me.Text = "Редактор::[" & frmMain.DefInstance.EchoList.SelectedItem.Text & "]::Ответ к " & txtTo.Text
				smileFlag = False
				
			Case modCommon.ReplayMode.ReplayOtherArea
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.From. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				txtTo.Text = TransferMessage.base.From
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.Subj. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				txtSubj.Text = TransferMessage.base.Subj
				'цетируем мессаг
				str_Renamed = Citat(msgs)
				Me.Text = "Редактор::[" & frmMain.DefInstance.EchoList.SelectedItem.Text & "]::Ответ к " & txtTo.Text & " в другую область"
				smileFlag = False
				
				'выставляем АКА области из которой прешел мессаг.
				'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.EchosCount. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				For i = 1 To clsEchos.EchosCount
					
					'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoNameByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					If InStr(1, str_Renamed, clsEchos.GetEchoNameByNum(i), CompareMethod.Text) > 0 Then
						'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoAkAByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						cboAddress.Text = clsEchos.GetEchoAkAByNum(i)
						Exit For
					End If
					
				Next i
				
			Case modCommon.ReplayMode.ReplayTo
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.rTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				txtTo.Text = TransferMessage.base.rTo
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.Subj. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				txtSubj.Text = TransferMessage.base.Subj
				'цетируем мессаг
				str_Renamed = Citat(msgs)
				Me.Text = "Редактор::[" & frmMain.DefInstance.EchoList.SelectedItem.Text & "]::Ответ к " & txtTo.Text
				smileFlag = False
				
			Case modCommon.ReplayMode.BookMail
				txtSubj.Text = ""
				txtTo.Text = BookMailParam(0)
				cboToAddress.Text = BookMailParam(1)
				Me.Text = "Редактор::[" & frmMain.DefInstance.EchoList.SelectedItem.Text & "]::Новое письмо к " & BookMailParam(1)
				
			Case modCommon.ReplayMode.MailForward
				txtTo.Text = "All"
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.Subj. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				txtSubj.Text = TransferMessage.base.Subj
				
				For i = 0 To UBound(msgs)
					
					If InStr(1, msgs(i), Chr(1), CompareMethod.Binary) = 0 And Len(msgs(i)) <> 0 Then
						str_Renamed = str_Renamed & msgs(i) & vbCrLf
					End If
					
				Next i
				
				Me.Text = "Редактор::[" & frmMain.DefInstance.EchoList.SelectedItem.Text & "]::Пересылка письма"
				smileFlag = False
				
			Case modCommon.ReplayMode.MailMoving
				smileFlag = False
				
			Case modCommon.ReplayMode.MailCopying
				smileFlag = False
				
			Case modCommon.ReplayMode.MailChange
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.From. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				txtFrom.Text = TransferMessage.base.From
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.FromAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				cboAddress.Text = TransferMessage.base.FromAddr
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.rToAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				cboToAddress.Text = TransferMessage.base.rToAddr
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.rTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				txtTo.Text = TransferMessage.base.rTo
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.Subj. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				txtSubj.Text = TransferMessage.base.Subj
				
				For i = 0 To UBound(msgs)
					
					If InStr(1, msgs(i), Chr(1), CompareMethod.Binary) = 0 And Len(msgs(i)) <> 0 Then
						str_Renamed = str_Renamed & msgs(i) & vbCrLf
					End If
					
				Next i
				
				Me.Text = "Редактор::[" & frmMain.DefInstance.EchoList.SelectedItem.Text & "]::Изменение письма"
				smileFlag = False
				
			Case Else
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.From. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				txtFrom.Text = TransferMessage.base.From
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.FromAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				cboAddress.Text = TransferMessage.base.FromAddr
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.rToAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				cboToAddress.Text = TransferMessage.base.rToAddr
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.rTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				txtTo.Text = TransferMessage.base.rTo
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.Subj. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				txtSubj.Text = TransferMessage.base.Subj
				
				For i = 0 To UBound(msgs)
					
					If InStr(1, msgs(i), Chr(1), CompareMethod.Binary) = 0 And Len(msgs(i)) <> 0 Then
						str_Renamed = str_Renamed & msgs(i) & vbCrLf
					End If
					
				Next i
				
				Me.Text = "Редактор::[" & frmMain.DefInstance.EchoList.SelectedItem.Text & "]::Просмотр письма от " & txtFrom.Text & " к " & txtTo.Text
				
		End Select
		
		i = 0
		
		If TransferMessage.Mode <> modCommon.ReplayMode.NewMail Then
			If Len(str_Renamed) > 3 Then
				If TransferMessage.Mode = modCommon.ReplayMode.ReplayFrom Or TransferMessage.Mode = modCommon.ReplayMode.ReplayTo Then
					rtfMessage.Text = str_Renamed
					InsertHeader()
					'запоминаем позицию конца текущего темплейта(для этого находим второй crlf)
					i = InStr(InStr(1, rtfMessage.Text, vbCrLf) + 1, rtfMessage.Text, vbCrLf) + 2
					InsertFooter()
				ElseIf TransferMessage.Mode <> modCommon.ReplayMode.ViewMails Then 
					rtfMessage.Text = str_Renamed
					InsertHeader()
					i = Len(rtfMessage.Text) - 70 'запоминаем позицию конца текущего темплейта
					InsertFooter()
				Else
					rtfMessage.Text = str_Renamed
				End If
				
			Else
				rtfMessage.Text = ""
				InsertHeader()
				rtfMessage.Text = rtfMessage.Text
				InsertFooter()
			End If
			
			HighlightTextPlain((Me.rtfMessage), TransferMessage.base, smileFlag)
			
			txtChangeFlag = False
		Else
			'читаем цветовые настройки
			rtfMessage.SelColor = GetGFEOption("Options", "MainTextColor", CStr(0))
			rtfMessage.BackColor = System.Drawing.ColorTranslator.FromOle(CInt(GetGFEOption("Options", "BackMessageColor", CStr(&HFFFFFF))))
			InsertHeader()
			rtfMessage.Text = rtfMessage.Text
			InsertFooter()
		End If
		
		'перемещаем курсор куда на нужное место
		If TransferMessage.Mode = modCommon.ReplayMode.MailForward Or TransferMessage.Mode = modCommon.ReplayMode.ReplayFrom Or TransferMessage.Mode = modCommon.ReplayMode.ReplayTo Then
			rtfMessage.SelStart = i
		Else
			rtfMessage.SelStart = InStr(1, rtfMessage.Text, vbCrLf & vbCrLf & vbCrLf) + 2
		End If
		
		rtfMessage.SelLength = 0
		
		If Not BookShow Then
			Me.Show()
		End If
		
		System.Windows.Forms.Application.DoEvents()
		
		'читаем список заммен
		i = 1
		While Len(GetGFEOption("Options\Replacments", "Replacment" & i)) <> 0
			ReDim Preserve Replaces(i)
			Replaces(i).Replace_Renamed = Split(GetGFEOption("Options\Replacments", "Replacment" & i, "Н H"), " ")
			i = i + 1
		End While
		
		'читаем сочетания клавиш
		i = 0
		While Len(GetGFEOption("Options\HotKeys", "Key" & CStr(i))) <> 0
			ReDim Preserve HotKeys(i)
			str_Renamed = GetGFEOption("Options\HotKeys", "Key" & CStr(i), "")
			
			If InStr(1, str_Renamed, "ctrl", CompareMethod.Text) <> 0 Then
				HotKeys(i).mask = VB6.ShiftConstants.CtrlMask
			ElseIf InStr(1, str_Renamed, "shift", CompareMethod.Text) <> 0 Then 
				HotKeys(i).mask = VB6.ShiftConstants.ShiftMask
			Else
				HotKeys(i).mask = -1
			End If
			
			HotKeys(i).Key = Asc(Trim(VB.Right(str_Renamed, 1)))
			HotKeys(i).Action = GetGFEOption("Options\HotKeys", "Action" & CStr(i), "")
			i = i + 1
		End While
		
		'Проверяем AKA при ответе на нетмыльное письмо
		'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.BaseType. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If TransferMessage.base.BaseType = "MSG" And (TransferMessage.Mode = modCommon.ReplayMode.ReplayFrom Or TransferMessage.Mode = modCommon.ReplayMode.ReplayFromNotCit Or TransferMessage.Mode = modCommon.ReplayMode.ReplayTo) Then
			
			SetCurrentOurNetMailAKA((cboToAddress.Text))
			
		End If
		
		'Устанавливаем город
		StatusBar.Panels(1).Text = "Письмо из города " & addr2city((cboAddress.Text))
		StatusBar.Panels(2).Text = "В город " & addr2city(cboToAddress.Text)
		
		Sleep(50)
		rtfMessage.Locked = True
		
		System.Windows.Forms.Application.DoEvents()
		
		DoBulbs()
		
		rtfMessage.Locked = False
		
		If TransferMessage.Mode = modCommon.ReplayMode.ViewMails Then
			txtChangeFlag = False 'сбрасываем флаг изменения
		End If
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::Form_Load")
		End Select
		
	End Sub
	
	'Управляет лампочками-флагами
	Private Sub DoBulbs()
		On Error GoTo errHandler
		Dim i As Integer
		
		Flash(5, Flash.Onn)
		
		For i = 0 To 6
			Flash(6 - i, Flash.Onn)
			Flash(i + 5, Flash.Onn)
		Next i
		
		'Flash 5, Off
		For i = 0 To 6
			'Устанавливаем по умолчанию доступность всех флагов и их выключенное состояние
			cmdFlag(i + 5).Enabled = True
			cmdFlag(6 - i).Enabled = True
			Flash(6 - i, Flash.Off)
			Flash(i + 5, Flash.Off)
		Next i
		
		If TransferMessage.Mode = modCommon.ReplayMode.NewMail Then
			
			'для нового письма загружаем флаги по умолчанию
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.BaseType. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Select Case TransferMessage.base.BaseType
				
				Case "JAM"
					'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					TransferMessage.base.MessageFlags = jamBase.MSG_ATTRIBUTE.MSG_TYPEECHO Or jamBase.MSG_ATTRIBUTE.Msg_Local
					
				Case "MSG"
					'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					TransferMessage.base.MessageFlags = GetGFEOption("Options", "Netmail Flags", CStr(msgBase.MSG_ATTRIBUTES.Msg_Kill Or msgBase.MSG_ATTRIBUTES.Msg_Private Or msgBase.MSG_ATTRIBUTES.Msg_Local))
					
				Case "SQU"
					'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					TransferMessage.base.MessageFlags = 0
			End Select
			
		ElseIf TransferMessage.Mode = modCommon.ReplayMode.ViewMails Then 
			
			For i = 0 To 6
				'если у нас  просмотр письма то мы должны запретить изменение статуса флажка
				cmdFlag(i + 5).Enabled = False
				cmdFlag(6 - i).Enabled = False
			Next i
			
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If (TransferMessage.base.MessageFlags And jamBase.MSG_ATTRIBUTE.MSG_TYPEECHO) <> jamBase.MSG_ATTRIBUTE.MSG_TYPEECHO Then
			
			'разбор флажков нетмейла - извращенная конструкция... нада наверно написать проще...
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And msgBase.MSG_ATTRIBUTES.Msg_Private) = msgBase.MSG_ATTRIBUTES.Msg_Private Then
				Flash(5, Flash.Onn)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And msgBase.MSG_ATTRIBUTES.Msg_Crash) = msgBase.MSG_ATTRIBUTES.Msg_Crash Then
				Flash(3, Flash.Onn)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And msgBase.MSG_ATTRIBUTES.Msg_Read) = msgBase.MSG_ATTRIBUTES.Msg_Read Then
				'
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And msgBase.MSG_ATTRIBUTES.Msg_Sent) = msgBase.MSG_ATTRIBUTES.Msg_Sent Then
				Flash(2, Flash.Onn)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And msgBase.MSG_ATTRIBUTES.Msg_File) = msgBase.MSG_ATTRIBUTES.Msg_File Then
				Flash(10, Flash.Onn)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And msgBase.MSG_ATTRIBUTES.Msg_Transit) = msgBase.MSG_ATTRIBUTES.Msg_Transit Then
				'
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And msgBase.MSG_ATTRIBUTES.Msg_Orphan) = msgBase.MSG_ATTRIBUTES.Msg_Orphan Then
				'
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And msgBase.MSG_ATTRIBUTES.Msg_Kill) = msgBase.MSG_ATTRIBUTES.Msg_Kill Then
				Flash(1, Flash.Onn)
				NetmailKsFlag = True
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And msgBase.MSG_ATTRIBUTES.Msg_Local) = msgBase.MSG_ATTRIBUTES.Msg_Local Then
				Flash(0, Flash.Onn)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And msgBase.MSG_ATTRIBUTES.Msg_Hold) = msgBase.MSG_ATTRIBUTES.Msg_Hold Then
				Flash(9, Flash.Onn)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And msgBase.MSG_ATTRIBUTES.Msg_FReq) = msgBase.MSG_ATTRIBUTES.Msg_FReq Then
				Flash(11, Flash.Onn)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And msgBase.MSG_ATTRIBUTES.Msg_RReq) = msgBase.MSG_ATTRIBUTES.Msg_RReq Then
				Flash(6, Flash.Onn)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And msgBase.MSG_ATTRIBUTES.Msg_IsRR) = msgBase.MSG_ATTRIBUTES.Msg_IsRR Then
				Flash(8, Flash.Onn)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And msgBase.MSG_ATTRIBUTES.Msg_AReq) = msgBase.MSG_ATTRIBUTES.Msg_AReq Then
				Flash(7, Flash.Onn)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And msgBase.MSG_ATTRIBUTES.Msg_FUpsReq) = msgBase.MSG_ATTRIBUTES.Msg_FUpsReq Then
				'
			End If
			
		Else
			'echomail
			Flash(0, Flash.Onn)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And jamBase.MSG_ATTRIBUTE.Msg_Local) = jamBase.MSG_ATTRIBUTE.Msg_Local Then
				Flash(0, Flash.Onn)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And jamBase.MSG_ATTRIBUTE.MSG_KILLSENT) = jamBase.MSG_ATTRIBUTE.MSG_KILLSENT Then
				Flash(1, Flash.Onn)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And jamBase.MSG_ATTRIBUTE.Msg_Sent) = jamBase.MSG_ATTRIBUTE.Msg_Sent Then
				Flash(2, Flash.Onn)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And jamBase.MSG_ATTRIBUTE.Msg_Private) = jamBase.MSG_ATTRIBUTE.Msg_Private Then
				Flash(5, Flash.Onn)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If (TransferMessage.base.MessageFlags And jamBase.MSG_ATTRIBUTE.Msg_Hold) = jamBase.MSG_ATTRIBUTE.Msg_Hold Then
				Flash(9, Flash.Onn)
			End If
			
			Flash(15, Flash.Onn)
			
			System.Windows.Forms.Application.DoEvents()
			
		End If
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::DoBulbs")
		End Select
		
	End Sub
	
	Private Sub Flash(ByVal Number As Short, ByRef state As Flash)
		
		If state = Flash.Onn Then
			cmdFlag(Number).Enabled = True
			cmdFlag(Number).Picture = imgButtons.ListImages.item(1).Picture
			cmdFlag(Number).PictureDown = imgButtons.ListImages.item(2).Picture
		Else
			cmdFlag(Number).Picture = imgButtons.ListImages.item(2).Picture
			cmdFlag(Number).PictureDown = imgButtons.ListImages.item(1).Picture
		End If
		
		Sleep(30)
		
		System.Windows.Forms.Application.DoEvents()
		
	End Sub
	
	'UPGRADE_WARNING: Form event frmMailEditor.QueryUnload has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
	Private Sub frmMailEditor_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
		Dim Cancel As Short = eventArgs.Cancel
		On Error GoTo errHandler
		Dim msg As Integer
		
		'UPGRADE_ISSUE: Unable to determine which constant to upgrade vbNormal to. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2049"'
		If Me.WindowState = vbNormal Then
			PutGFEOption("Screen\Editor", "X", Str(VB6.PixelsToTwipsX(Me.Left)))
			PutGFEOption("Screen\Editor", "Y", Str(VB6.PixelsToTwipsY(Me.Top)))
			PutGFEOption("Screen\Editor", "Width", Str(VB6.PixelsToTwipsX(Me.Width)))
			PutGFEOption("Screen\Editor", "Height", Str(VB6.PixelsToTwipsY(Me.Height)))
		End If
		
		PutGFEOption("Screen\Editor", "WindowState", Str(Me.WindowState))
		
		If txtChangeFlag = True Then
			HighlightTextPlain(rtfMessage)
			txtChangeFlag = False
			msg = MsgBox("Письмо измененено." & vbCrLf & "Выйти без отправки?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - MailEditor")
			
			If msg = MsgBoxResult.Yes Then
				GoTo EventExitSub
			End If
			
			If msg = MsgBoxResult.No Then
				txtChangeFlag = True
				Cancel = 1
			End If
		End If
		
		GoTo EventExitSub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::Form_QueryUnload")
		End Select
		
EventExitSub: 
		eventArgs.Cancel = Cancel
	End Sub
	
	'UPGRADE_WARNING: Event frmMailEditor.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub frmMailEditor_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		CalcSize()
	End Sub
	
	Private Sub CalcSize()
		On Error GoTo errHandler
		
		If Me.WindowState = System.Windows.Forms.FormWindowState.Minimized Then
			Exit Sub
		End If
		
		If VB6.PixelsToTwipsX(Me.Width) < MeMinWidth * dx And Me.WindowState <> System.Windows.Forms.FormWindowState.Maximized Then
			Me.Width = VB6.TwipsToPixelsX(MeMinWidth * dx)
		End If
		
		If VB6.PixelsToTwipsY(Me.Height) < MeMinHeight * dy And Me.WindowState <> System.Windows.Forms.FormWindowState.Maximized Then
			Me.Height = VB6.TwipsToPixelsY(MeMinHeight * dy)
		End If
		
		If VB6.PixelsToTwipsY(Me.ClientRectangle.Height) - VB6.PixelsToTwipsY(CoolBar1.Height) - VB6.PixelsToTwipsY(StatusBar.Height) > 0 Then
			rtfMessage.Visible = True
			rtfMessage.SetBounds(0, CoolBar1.Height, VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.ClientRectangle.Width) - 900), VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.ClientRectangle.Height) - VB6.PixelsToTwipsY(CoolBar1.Height) - VB6.PixelsToTwipsY(StatusBar.Height)))
			fraSmiles.Visible = True
			fraSmiles.SetBounds(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(rtfMessage.Width) + 50), VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(rtfMessage.Top) - 100), VB6.TwipsToPixelsX(825), VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.ClientRectangle.Height) - VB6.PixelsToTwipsY(CoolBar1.Height) - VB6.PixelsToTwipsY(StatusBar.Height) + 100))
		Else
			rtfMessage.Visible = False
		End If
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::Form_Load")
		End Select
		
	End Sub
	
	Public Sub mnuAltRFileCitat_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAltRFileCitat.Popup
		mnuAltRFileCitat_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuAltRFileCitat_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAltRFileCitat.Click
		On Error GoTo errHandler
		Dim File, txt As String
		Dim ff As Integer
		Dim strs() As String
		
		'Вставляем файл в текст
		modCommonDialog.OpenDialogTitle = "Выберете файл для вставки c цетированием..."
		modCommonDialog.Filter_Renamed = "All Files (*.*)|*.*|"
		modCommonDialog.Flags = cdlOFNReadOnly
		modCommonDialog.FilterIndex = 1
		File = modCommonDialog.ShowOpen
		
		If Len(File) = 0 Then
			Exit Sub
		End If
		
		'обработка
		ff = FreeFile
		FileOpen(ff, File, OpenMode.Binary)
		txt = Space(LOF(ff))
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, txt)
		FileClose(ff)
		
		strs = Split(txt, vbCrLf)
		
		txt = "---Past Here---" & vbCrLf
		
		For ff = 0 To UBound(strs)
			txt = txt & " > " & strs(ff) & vbCrLf
		Next ff
		
		rtfMessage.SelText = txt & "---End Here---"
		HighlightTextPlain((Me.rtfMessage), TransferMessage.base, False)
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::mnuAltRFileCitat_Click")
		End Select
		
	End Sub
	
	Public Sub mnuAltRFilePlain_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAltRFilePlain.Popup
		mnuAltRFilePlain_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuAltRFilePlain_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAltRFilePlain.Click
		On Error GoTo errHandler
		Dim File, txt As String
		Dim ff As Integer
		
		'Вставляем файл в текст
		modCommonDialog.OpenDialogTitle = "Выберете файл для вставки..."
		modCommonDialog.Filter_Renamed = "All Files (*.*)|*.*|"
		modCommonDialog.Flags = cdlOFNReadOnly
		modCommonDialog.FilterIndex = 1
		File = modCommonDialog.ShowOpen
		
		If Len(File) = 0 Then
			Exit Sub
		End If
		
		'обработка
		ff = FreeFile
		FileOpen(ff, File, OpenMode.Binary)
		txt = Space(LOF(ff))
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, txt)
		FileClose(ff)
		
		txt = "---Past Here---" & vbCrLf & txt & vbCrLf & "---End Here---"
		rtfMessage.SelText = txt
		HighlightTextPlain((Me.rtfMessage), TransferMessage.base, False)
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::mnuAltRFilePlain_Click")
		End Select
		
	End Sub
	
	Public Sub mnuAltRFileUUE_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAltRFileUUE.Popup
		mnuAltRFileUUE_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuAltRFileUUE_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAltRFileUUE.Click
		On Error GoTo errHandler
		
		rtfMessage.SelLength = 0
		rtfMessage.SelText = EncodeFileToOneSectionUUE(Me.Handle.ToInt32)
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::mnuAltRFileUUE_Click")
		End Select
		
	End Sub
	
	Private Sub Picture1_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Picture1.Resize
		On Error Resume Next
		
		fraFlags.SetBounds(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Width) \ 2 - (VB6.PixelsToTwipsX(fraFlags.Width) \ 2) - (30 * dx)), 0, 0, 0, Windows.Forms.BoundsSpecified.X)
		cboToAddress.SetBounds(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Picture1.ClientRectangle.Width) - VB6.PixelsToTwipsX(cboToAddress.Width) - (20 * dx)), 0, 0, 0, Windows.Forms.BoundsSpecified.X)
		cboAddress.SetBounds(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Picture1.ClientRectangle.Width) - VB6.PixelsToTwipsX(cboAddress.Width) - (10 * dx)), 0, 0, 0, Windows.Forms.BoundsSpecified.X)
		cboToAddress.SetBounds(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Picture1.ClientRectangle.Width) - VB6.PixelsToTwipsX(cboToAddress.Width) - (10 * dx)), 0, 0, 0, Windows.Forms.BoundsSpecified.X)
		
		txtSubj.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Picture1.ClientRectangle.Width) - VB6.PixelsToTwipsX(lblSubj.Width) - (20 * dx))
		
		txtFrom.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(cboAddress.Left) - (50 * dx))
		txtTo.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(cboToAddress.Left) - (50 * dx))
		cmdOrigin.SetBounds(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(txtSubj.Left) + VB6.PixelsToTwipsX(txtSubj.Width) - VB6.PixelsToTwipsX(cmdOrigin.Width)), 0, 0, 0, Windows.Forms.BoundsSpecified.X)
		
		System.Windows.Forms.Application.DoEvents()
		
	End Sub
	
	Private Sub rtfMessage_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles rtfMessage.Change
		Static NotFirstFlag As Boolean
		
		txtChangeFlag = NotFirstFlag
		NotFirstFlag = True
		
	End Sub
	
	Private Sub rtfMessage_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles rtfMessage.ClickEvent
		On Error GoTo errHandler
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim RegEx As New VBScript_RegExp_55.RegExp
		Dim str_Renamed As String
		Dim colMatches As VBScript_RegExp_55.MatchCollection ' коллекция этих образцов
		
		RegEx.IgnoreCase = True 'игнорируем регистр символов
		RegEx.Pattern = "\d+:\d+/\d+\.{0,1}\d*" 'шаблон для выборки 4D адреса из 5D
		
		str_Renamed = RichWordClick(rtfMessage)
		
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
		
		System.Windows.Forms.Application.DoEvents()
		'UPGRADE_NOTE: Object RegEx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		RegEx = Nothing
		'UPGRADE_NOTE: Object colMatches may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		colMatches = Nothing
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 91
				MsgBox("Плагин AddrBook.dll не зарегистрирован или не найден.", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::rtfMessage_Click")
		End Select
		
	End Sub
	
	Private Sub rtfMessage_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxRichTextLib.DRichTextEvents_KeyDownEvent) Handles rtfMessage.KeyDownEvent
		On Error GoTo errHandler
		Dim i As Integer
		
		'пока пусть так будет
		If eventArgs.Shift = VB6.ShiftConstants.CtrlMask Then
			
			For i = 0 To UBound(HotKeys)
				
				If eventArgs.KeyCode = HotKeys(i).Key Then
					LockWindowUpdate(rtfMessage.hWnd)
					rtfMessage.SelLength = 0
					rtfMessage.SelText = HotKeys(i).Action
					LockWindowUpdate(0)
				End If
				
			Next i
			
		End If
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 9
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::rtfMessage_KeyDown")
		End Select
		
	End Sub
	
	Private Sub rtfMessage_KeyUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxRichTextLib.DRichTextEvents_KeyUpEvent) Handles rtfMessage.KeyUpEvent
		On Error GoTo errHandler
		Dim sttl, stpl As Integer
		
		'key Alt+R - Paste File
		If eventArgs.KeyCode = System.Windows.Forms.Keys.R And eventArgs.Shift = VB6.ShiftConstants.AltMask Then
			'UPGRADE_ISSUE: Form method frmMailEditor.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			PopupMenu(mnuAltR)
		End If
		
		'ctrl+Y - Cut Line
		If eventArgs.KeyCode = System.Windows.Forms.Keys.Y And eventArgs.Shift = VB6.ShiftConstants.CtrlMask Then
			
			'находим начало новой строки
			sttl = rtfMessage.SelStart
			stpl = sttl
			While Mid(rtfMessage.Text, sttl, 1) <> vbLf And sttl > 0
				sttl = sttl - 1
			End While
			
			While Mid(rtfMessage.Text, stpl, 1) <> vbCr And stpl < Len(rtfMessage.Text)
				stpl = stpl + 1
			End While
			
			rtfMessage.SelStart = sttl
			rtfMessage.SelLength = (stpl + 1) - sttl
			rtfMessage.SelText = ""
			
		End If
		
		'ctrl+U(Z) - Undelete line
		If (eventArgs.KeyCode = System.Windows.Forms.Keys.U Or eventArgs.KeyCode = System.Windows.Forms.Keys.Z) And eventArgs.Shift = VB6.ShiftConstants.CtrlMask Then
			modCommon.SendMessage(rtfMessage.hWnd, EM_UNDO, 0, 0)
			rtfMessage.SelLength = 0
		End If
		
		'F2- Save Message
		If eventArgs.KeyCode = System.Windows.Forms.Keys.F2 Then
			WriteMessage()
		End If
		
		'quit
		If eventArgs.KeyCode = System.Windows.Forms.Keys.Escape Then
			Me.Close()
		End If
		
		'shift+ins
		If eventArgs.Shift = VB6.ShiftConstants.ShiftMask And eventArgs.KeyCode = System.Windows.Forms.Keys.Insert Then
			LockWindowUpdate(rtfMessage.hWnd)
			sttl = rtfMessage.SelStart
			rtfMessage.SelStart = 0
			'UPGRADE_ISSUE: Clipboard method Clipboard.GetText was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
			rtfMessage.SelLength = Len(Clipboard.GetText)
			rtfMessage.SelColor = msgMainTextColor
			rtfMessage.BackColor = System.Drawing.ColorTranslator.FromOle(msgBackColor)
			rtfMessage.SelStart = sttl
			rtfMessage.SelLength = 0
			rtfMessage.Focus()
			LockWindowUpdate(0)
		End If
		
		System.Windows.Forms.Application.DoEvents()
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::rtfMessage_KeyUp")
		End Select
		
	End Sub
	
	Private Sub rtfMessage_MouseMoveEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxRichTextLib.DRichTextEvents_MouseMoveEvent) Handles rtfMessage.MouseMoveEvent
		On Error GoTo errHandler
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim RegEx As New VBScript_RegExp_55.RegExp
		Dim str_Renamed As String
		
		RegEx.IgnoreCase = True ' игнорируем регистр символов
		RegEx.Pattern = "\d+:\d+/\d+\.{0,1}\d*" 'шаблон для выборки 4D адреса из 5D
		
		str_Renamed = RichWordOver(rtfMessage, eventArgs.X, eventArgs.Y)
		
		If RegEx.Test(str_Renamed) Then
			rtfMessage.MouseIcon = VB6.LoadResPicture(1, VB6.LoadResConstants.ResCursor)
			'UPGRADE_ISSUE: RichTextLib.RichTextBox property rtfMessage.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2036"'
			rtfMessage.MousePointer = RichTextLib.MousePointerConstants.rtfCustom
		Else
			'UPGRADE_ISSUE: RichTextLib.RichTextBox property rtfMessage.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2036"'
			rtfMessage.MousePointer = RichTextLib.MousePointerConstants.rtfDefault
		End If
		
		System.Windows.Forms.Application.DoEvents()
		
		'UPGRADE_NOTE: Object RegEx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		RegEx = Nothing
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::rtfMessage_MouseMove")
		End Select
		
	End Sub
	
	Private Sub rtfMessage_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxRichTextLib.DRichTextEvents_KeyPressEvent) Handles rtfMessage.KeyPressEvent
		On Error GoTo errHandler
		Dim i, o As Integer
		
		If eventArgs.KeyAscii = System.Windows.Forms.Keys.Space Then
			i = rtfMessage.SelStart
			
			If i > 0 Then
				While Mid(rtfMessage.Text, i, 1) <> vbLf And i > 1
					i = i - 1
				End While
			Else
				i = 1
			End If
			
			'тут длинна строки и если она больше 78 символов, надо переносить
			If ((rtfMessage.SelStart - i) + 1) >= 78 Then
				i = rtfMessage.SelStart
				o = i
				While Mid(rtfMessage.Text, i, 1) <> " " And i > 1
					i = i - 1
				End While
				
				LockWindowUpdate(rtfMessage.hWnd)
				rtfMessage.Text = Mid(rtfMessage.Text, 1, i) & vbCrLf & Mid(rtfMessage.Text, i + 1, Len(rtfMessage.Text))
				rtfMessage.SelStart = o + 3
				
				HighlightTextPlain((Me.rtfMessage), TransferMessage.base, False)
				rtfMessage.Focus()
				rtfMessage.SelStart = o + 3
				
				'отменяем последний введенный пробел и засылаем новый.
				eventArgs.KeyAscii = 0
				
				LockWindowUpdate(0)
				
				System.Windows.Forms.SendKeys.Send(" ")
				
			End If
			
			StatusBar.Panels(1).Text = "Стр: " & GetLineCount(True) & " Кол: " & (rtfMessage.SelStart - i) + 1
			
			'LockWindowUpdate Me.hWnd
			'i = rtfMessage.SelStart
			'HingliteText me.rtfMessage, TransferMessage.base
			'rtfMessage.SetFocus
			'rtfMessage.SelStart = i
			'LockWindowUpdate 0
			
			System.Windows.Forms.Application.DoEvents()
		End If
		
		'какой класный код. :) и никаких процедур вызывать не надо.
		If eventArgs.KeyAscii = System.Windows.Forms.Keys.Return Then
			rtfMessage.SelLength = 0
			rtfMessage.SelColor = msgMainTextColor
			rtfMessage.BackColor = System.Drawing.ColorTranslator.FromOle(msgBackColor)
			
			System.Windows.Forms.Application.DoEvents()
		End If
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::rtfMessage_KeyPress")
		End Select
		
	End Sub
	
	Private Sub Toolbar_ButtonClick(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComctlLib.IToolbarEvents_ButtonClickEvent) Handles Toolbar.ButtonClick
		On Error GoTo errHandler
		Dim msg As MessageSaveFields
		Dim vt As String
		
		vt = GetGFEOption("Options", "MailListView", "TreeView")
		
		Select Case eventArgs.Button.Index
			
			Case 1
				'send
				WriteMessage()
				
			Case 3
				
				'cut
				If rtfMessage.SelLength <> 0 Then
					'UPGRADE_ISSUE: Clipboard method Clipboard.SetText was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
					Clipboard.SetText(rtfMessage.SelText)
					rtfMessage.SelText = ""
				End If
				
			Case 4
				
				'copy
				If rtfMessage.SelLength <> 0 Then
					'UPGRADE_ISSUE: Clipboard method Clipboard.SetText was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
					Clipboard.SetText(rtfMessage.SelText)
				Else
					'UPGRADE_ISSUE: Clipboard method Clipboard.SetText was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
					Clipboard.SetText(rtfMessage.Text)
				End If
				
			Case 5
				'paste
				'UPGRADE_ISSUE: Clipboard method Clipboard.GetText was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
				rtfMessage.SelText = Clipboard.GetText
				HighlightTextPlain((Me.rtfMessage),  , False)
				
			Case 6
				'paste file
				mnuAltRFilePlain_Click(mnuAltRFilePlain, New System.EventArgs())
				
			Case 8
				'undo
				modCommon.SendMessage(rtfMessage.hWnd, EM_UNDO, 0, 0)
				
			Case 10
				
				'save as
				If frmMain.DefInstance.EchoList.SelectedItem.SubItems(1) = "0" Then
					'cancel
					Exit Sub
				End If
				
				With msg
					.From = txtFrom.Text
					.FromAddr = cboAddress.Text
					.To_Renamed = txtTo.Text
					.ToAddr = cboToAddress.Text
					.Subject = txtSubj.Text
					.AKA = frmMain.DefInstance.EchoList.SelectedItem.SubItems(3)
					.Description = frmMain.DefInstance.EchoList.SelectedItem.SubItems(2)
					.EchoName = frmMain.DefInstance.EchoList.SelectedItem.Text
					'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.DateArrived. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					.DateArrived = sUnixDate(TransferMessage.base.DateArrived)
					'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.DateWritten. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					.DateWritten = sUnixDate(TransferMessage.base.DateWritten)
					
					Select Case vt
						
						Case "TreeView"
							.MessageNumber = Mid(frmMain.DefInstance.MailList.SelectedItem.Tag, 2, Len(frmMain.DefInstance.MailList.SelectedItem.Tag) - 2)
							
						Case "ListView"
							.MessageNumber = Mid(frmMain.DefInstance.MailList2.SelectedItem.Tag, 2, Len(frmMain.DefInstance.MailList2.SelectedItem.Tag) - 2)
					End Select
					
					.TotalMessages = frmMain.DefInstance.EchoList.SelectedItem.SubItems(1)
				End With
				
				EditorSaveMessage(rtfMessage, msg)
		End Select
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::Toolbar_ButtonClick")
		End Select
		
	End Sub
	
	'клик на подменю
	Private Sub ToolBar_ButtonMenuClick(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComctlLib.IToolbarEvents_ButtonMenuClickEvent) Handles ToolBar.ButtonMenuClick
		On Error GoTo errHandler
		Dim msg As MessageSaveFields
		Dim vt As String
		
		Select Case eventArgs.ButtonMenu.Parent.Index
			
			Case 6 'paste file
				
				Select Case eventArgs.ButtonMenu.Index
					
					Case 1 'txt
						'TextPlain
						mnuAltRFilePlain_Click(mnuAltRFilePlain, New System.EventArgs())
						
					Case 2 'rtf
						'TextQuote
						mnuAltRFileCitat_Click(mnuAltRFileCitat, New System.EventArgs())
						
					Case 3 'html
						'TextUUE
						mnuAltRFileUUE_Click(mnuAltRFileUUE, New System.EventArgs())
				End Select
				
				HighlightTextPlain((Me.rtfMessage),  , False)
				
			Case 10 'save as
				vt = GetGFEOption("Options", "MailListView", "TreeView")
				
				If frmMain.DefInstance.EchoList.SelectedItem.SubItems(1) = "0" Then
					'cancel
					Exit Sub
				End If
				
				With msg
					.From = txtFrom.Text
					.FromAddr = cboAddress.Text
					.To_Renamed = txtTo.Text
					.ToAddr = cboToAddress.Text
					.Subject = txtSubj.Text
					.AKA = frmMain.DefInstance.EchoList.SelectedItem.SubItems(3)
					.Description = frmMain.DefInstance.EchoList.SelectedItem.SubItems(2)
					.EchoName = frmMain.DefInstance.EchoList.SelectedItem.Text
					'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.DateArrived. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					.DateArrived = sUnixDate(TransferMessage.base.DateArrived)
					'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.DateWritten. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					.DateWritten = sUnixDate(TransferMessage.base.DateWritten)
					
					Select Case vt
						
						Case "TreeView"
							.MessageNumber = Mid(frmMain.DefInstance.MailList.SelectedItem.Tag, 2, Len(frmMain.DefInstance.MailList.SelectedItem.Tag) - 2)
							
						Case "ListView"
							.MessageNumber = Mid(frmMain.DefInstance.MailList2.SelectedItem.Tag, 2, Len(frmMain.DefInstance.MailList2.SelectedItem.Tag) - 2)
					End Select
					
					.TotalMessages = frmMain.DefInstance.EchoList.SelectedItem.SubItems(1)
				End With
				
				Select Case eventArgs.ButtonMenu.Index
					
					Case 1 'txt
						'SaveText
						EditorSaveMessage(rtfMessage, msg, modTextWork.SaveMessageType.SaveText)
						
					Case 2 'rtf
						'SaveRTF
						EditorSaveMessage(rtfMessage, msg, modTextWork.SaveMessageType.SaveRTF)
						
					Case 3 'html
						'SaveHTML
						EditorSaveMessage(rtfMessage, msg, modTextWork.SaveMessageType.SaveHTML)
				End Select
		End Select
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::ToolBar_ButtonMenuClick")
		End Select
		
	End Sub
	
	'заменяет символы в мессаге в соответствии со списком замен
	Private Function ReplaceCharsInText() As String
		Dim i As Integer
		Dim txt As String
		
		txt = rtfMessage.Text
		
		For i = 1 To UBound(Replaces)
			txt = Replace(txt, Replaces(i).Replace_Renamed(0), Replaces(i).Replace_Renamed(1))
		Next i
		
		ReplaceCharsInText = txt
		
	End Function
	
	'UPGRADE_WARNING: Event txtFrom.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	'UPGRADE_WARNING: ComboBox event txtFrom.Change was upgraded to txtFrom.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2074"'
	Private Sub txtFrom_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFrom.TextChanged
		Static NotFirstFlag As Boolean
		
		txtChangeFlag = NotFirstFlag
		NotFirstFlag = True
		
	End Sub
	
	Private Sub txtFrom_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtFrom.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		'F2- Save Message
		If KeyCode = System.Windows.Forms.Keys.F2 Then
			WriteMessage()
			
			System.Windows.Forms.Application.DoEvents()
		End If
		
		'quit
		If KeyCode = System.Windows.Forms.Keys.Escape Then
			Me.Close()
		End If
		
		'enter
		If KeyCode = System.Windows.Forms.Keys.Return Then
			Me.rtfMessage.Focus()
		End If
		
	End Sub
	
	'UPGRADE_WARNING: Event txtSubj.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtSubj_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSubj.TextChanged
		Static NotFirstFlag As Boolean
		
		txtChangeFlag = NotFirstFlag
		NotFirstFlag = True
		
	End Sub
	
	Private Sub txtSubj_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtSubj.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		'F2- Save Message
		If KeyCode = System.Windows.Forms.Keys.F2 Then
			WriteMessage()
			
			System.Windows.Forms.Application.DoEvents()
		End If
		
		'quit
		If KeyCode = System.Windows.Forms.Keys.Escape Then
			Me.Close()
		End If
		
		'enter
		If KeyCode = System.Windows.Forms.Keys.Return Then
			Me.rtfMessage.Focus()
		End If
		
	End Sub
	
	'UPGRADE_WARNING: Event txtTo.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtTo_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTo.TextChanged
		Static NotFirstFlag As Boolean
		
		txtChangeFlag = NotFirstFlag
		NotFirstFlag = True
		
		If InStr(1, txtTo.Text, "areafix", CompareMethod.Text) <> 0 Or InStr(1, txtTo.Text, "filefix", CompareMethod.Text) <> 0 Or InStr(1, txtTo.Text, "allfix", CompareMethod.Text) <> 0 Then
			rtfMessage.Text = vbCrLf & vbCrLf & "--- " & GetGFEOption("Options\Template", "TirLine", System.Reflection.Assembly.GetExecutingAssembly.GetName.Name) & vbCrLf
		End If
		
	End Sub
	
	'вставляет шаблон заголовка в новый мессаг.
	Private Sub InsertHeader()
		On Error GoTo errHandler
		
		rtfMessage.Text = ParseTemplate((rtfMessage.Text)) 'обрабатываем шаблон.
		
		'HighlightTextPlain me.rtfMessage, TransferMessage.base, False
		txtChangeFlag = False
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::InsertHeader")
		End Select
		
	End Sub
	
	'вставляет шаблон низа в новый мессаг.
	Private Sub InsertFooter()
		On Error GoTo errHandler
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim str_Renamed, tmp As String
		Dim strs() As String
		Dim ff As Integer
		Dim RegEx As New VBScript_RegExp_55.RegExp 'регэкспы
		Dim colMatches As VBScript_RegExp_55.MatchCollection ' коллекция этих образцов
		
		RegEx.IgnoreCase = True ' игнорируем регистр символов
		RegEx.Pattern = "\d+:\d+/\d+\.{0,1}\d*" 'шаблон для выборки 4D адреса из 5D
		colMatches = RegEx.Execute(cboAddress.Text) 'получаем результат
		
		'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		OldAddr = colMatches.item(0).Value
		
		'Загружаем Подпись письма вместе с макросами которые будут парсится в Шаблоне.
		str_Renamed = Replace(GetGFEOption("Options\Template", "Signature", "Пока,@TFName!!! С вами был,есть и будет:@CName"), "\n", vbCrLf,  ,  , CompareMethod.Text) & vbCrLf
		
		If Len(getNP) <> 0 Then
			str_Renamed = str_Renamed & "... " & getNP & vbCrLf
		Else
			tmp = GetGFEOption("Options\Template", "TagLine", vbNullString)
			
			If Len(tmp) <> 0 Then
				str_Renamed = str_Renamed & "... " & tmp & vbCrLf
			End If
		End If
		
		On Error Resume Next
		ff = FreeFile
		FileOpen(ff, VB6.GetPath & "\Origin.txt", OpenMode.Binary)
		tmp = Space(LOF(ff))
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(ff, tmp)
		FileClose(ff)
		
		Randomize(VB.Timer())
		
		If Len(tmp) = 0 Then
			tmp = "...CONNECT 220 Вольт/MNP5/V42Bis =:-E"
			
		Else
			strs = Split(tmp, vbCrLf)
			tmp = strs(CInt(UBound(strs) * Rnd()))
			OemToChar(tmp, tmp)
			
		End If
		
		On Error GoTo errHandler
		
		str_Renamed = str_Renamed & "--- " & GetGFEOption("Options\Template", "TirLine", System.Reflection.Assembly.GetExecutingAssembly.GetName.Name) & vbCrLf
		
		If Len(" * Origin: " & tmp & " (" & OldAddr & ")") <= 79 Then
			str_Renamed = str_Renamed & " * Origin: " & tmp & " (" & OldAddr & ")"
		Else
			tmp = Mid(tmp, 1, Len(tmp) - Len(" * Origin: " & tmp & " (" & OldAddr & ")"))
			str_Renamed = str_Renamed & " * Origin: " & tmp & " (" & OldAddr & ")"
		End If
		
		'заканчиваем темплейт
		rtfMessage.Text = rtfMessage.Text & str_Renamed
		
		Call ParseTemplateMacros()
		
		HighlightTextPlain((Me.rtfMessage), TransferMessage.base, False)
		txtChangeFlag = False
		
		'UPGRADE_NOTE: Object colMatches may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		colMatches = Nothing
		'UPGRADE_NOTE: Object RegEx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		RegEx = Nothing
		Erase strs
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::InsertFooter")
		End Select
		
	End Sub
	
	'функция парсит текст в соответствии с макросами.
	'параметр Text должен принимать уже отквоченный текст
	'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Private Function ParseTemplate(ByRef Text_Renamed As String) As String
		On Error GoTo errHandler
		Dim Template As String
		Dim mMode As Integer
		Dim strQuote, strGreeting, strChanged, strMoved As String
		
		mMode = TransferMessage.Mode
		
		'Read Template
		strGreeting = Replace(GetGFEOption("Options\Template", "Greeting", "Glad To Read You, @TFName !"), "\n", vbCrLf,  ,  , CompareMethod.Text) & vbCrLf & vbCrLf
		strChanged = Replace(GetGFEOption("Options\Template", "Changed", "*** Изменено непреднамеренно @CName ***"), "\n", vbCrLf,  ,  , CompareMethod.Text) & vbCrLf & vbCrLf
		strQuote = Replace(GetGFEOption("Options\Template", "Quote", "Стучал как-то по клаве некто @OName и достучался он до @DName:"), "\n", vbCrLf,  ,  , CompareMethod.Text) & vbCrLf & vbCrLf
		strMoved = Replace(GetGFEOption("Options\Template", "Moved", "*** Ответ на мессагу закинутую и зачитанную до битиков в арию @OEcho"), "\n", vbCrLf,  ,  , CompareMethod.Text) & vbCrLf & vbCrLf
		
		'строки с цитированием
		Select Case mMode
			
			Case modCommon.ReplayMode.ReplayFrom, modCommon.ReplayMode.ReplayTo
				Template = strGreeting
				Template = Template & strQuote & Text_Renamed & vbCrLf
				
			Case modCommon.ReplayMode.MailForward
				Template = strGreeting
				Template = Template & "*---------------------------------------------------------------------" & vbCrLf
				Template = Template & "* Forwarded by @CName (@CAddr)" & vbCrLf
				Template = Template & "* Area : @OEcho (@ODesc)" & vbCrLf
				'Template = Template & "* From : @OName, @OAddr (@ODate @OTime)" & vbCrLf
				Template = Template & "* From : @OName, @OAddr (@ODate)" & vbCrLf
				Template = Template & "* To   : @DName" & vbCrLf
				Template = Template & "* Subj : @Subject" & vbCrLf
				Template = Template & "*---------------------------------------------------------------------" & vbCrLf
				Template = Template & Text_Renamed
				
			Case modCommon.ReplayMode.ReplayOtherArea
				Template = strGreeting
				Template = Template & strMoved & Text_Renamed & vbCrLf
				
			Case modCommon.ReplayMode.MailChange
				Template = strGreeting
				Template = Template & strChanged & Text_Renamed & vbCrLf
				
			Case Else
				Template = strGreeting
				Template = Template & vbCrLf & vbCrLf & Text_Renamed
				
		End Select
		
		ParseTemplate = Template
		
		Exit Function
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::ParseTemplate")
				ParseTemplate = Template
		End Select
		
	End Function
	
	Private Sub ParseTemplateMacros()
		On Error GoTo errHandler
		Dim RegEx As New VBScript_RegExp_55.RegExp ' РегЭкспы
		Dim colMatches As VBScript_RegExp_55.MatchCollection ' коллекция этих образцов
		Dim tmp, Template, tt As String
		Dim bd As Object
		Dim mMode As Integer
		
		mMode = TransferMessage.Mode
		Template = rtfMessage.Text
		bd = TransferMessage.base
		
		'Options
		RegEx.MultiLine = True ' многострочный текст
		RegEx.[Global] = True ' будем проходить всю строку
		RegEx.IgnoreCase = True ' игнорируем регистр символов
		
		'Parsing macros
		'
		'Macroses
		'
		'"@CName"     имя отправителя
		'"@CAddr"     адрес отправителя
		'"@CDate"     дата написания письма
		'-"@CTime"     время написания письма
		'"@TFName"    имя получателя
		'"@DName"     имя получателя мессага
		'"@OName"     имя отправителя мессага
		'"@OAddr"     адрес отправителя мессага
		'"@OEcho"     имя эхи
		'"@ODesc"     описание эхи
		'"@ODate"     ориганальная дата письма
		'"@Subject"   Тема письма
		
		If LCase(frmMain.DefInstance.EchoList.SelectedItem.Text) <> "netmail" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoDescriptionByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			tmp = clsEchos.GetEchoDescriptionByNum(Mid(frmMain.DefInstance.EchoList.SelectedItem.Key, 2, Len(frmMain.DefInstance.EchoList.SelectedItem.Text)))
		Else
			tmp = "NetMail Area"
		End If
		
		RegEx.Pattern = "@ODesc"
		Template = RegEx.Replace(Template, tmp) 'описание эхи тут уже в правельной кодировке
		RegEx.Pattern = "@OEcho"
		Template = RegEx.Replace(Template, frmMain.DefInstance.EchoList.SelectedItem.Text)
		
		If mMode <> modCommon.ReplayMode.MailForward Then
			RegEx.Pattern = "@OName" 'от кого - имя
			Template = RegEx.Replace(Template, txtFrom.Text)
			RegEx.Pattern = "@OAddr" 'от кого - адрес
			Template = RegEx.Replace(Template, cboAddress.Text)
		Else
			RegEx.Pattern = "@CAddr" 'от кого - адрес
			Template = RegEx.Replace(Template, cboAddress.Text)
			RegEx.Pattern = "@OAddr"
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.FromAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Template = RegEx.Replace(Template, TransferMessage.base.FromAddr)
		End If
		
		RegEx.Pattern = "@CName" 'от кого - имя
		Template = RegEx.Replace(Template, GetGFEOption("Options", "UserName0"))
		RegEx.Pattern = "@CAddr" 'от кого - адрес
		Template = RegEx.Replace(Template, GetGFEOption("Options", "MainAddress"))
		RegEx.Pattern = "@TFName" 'от кого - имя
		Template = RegEx.Replace(Template, txtTo.Text)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object bd.DateWritten. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If bd.DateWritten <= 0 Then
			tmp = CStr(Today)
			tt = CStr(TimeOfDay)
			
			RegEx.Pattern = "\d{1,2}[\.\\-]\d{1,2}[\.\\-]\d{1,4}" 'выражение для формата даты
			colMatches = RegEx.Execute(tmp) 'получаем результат
			
			RegEx.Pattern = "@ODate" 'отдельно стоящая замена
			'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Template = RegEx.Replace(Template, colMatches.item(0).Value) 'заряжаем новый паттерн
			'UPGRADE_NOTE: Object colMatches may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
			colMatches = Nothing
			
		Else
			
			'UPGRADE_WARNING: Couldn't resolve default property of object bd.BaseType. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			If InStr(1, bd.BaseType, "MSG", CompareMethod.Text) <> 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object bd.DateWritten. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				tmp = sUnixDate(bd.DateWritten, True)
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object bd.DateWritten. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				tmp = sUnixDate(bd.DateWritten)
			End If
			
			tt = VB.Right(tmp, 8)
			Template = Replace(Template, "@ODate", Replace(tmp, " " & tt, vbNullString,  ,  , CompareMethod.Text),  ,  , CompareMethod.Text)
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object bd.GetHeadesByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		bd.GetHeadesByNum(TransferMessage.CurrentMail)
		
		RegEx.Pattern = "\d{1,2}:\d{1,2}:\d{1,2}" 'выражение для формата времени
		colMatches = RegEx.Execute(tt) 'получаем результат
		RegEx.Pattern = "@OTime" 'отдельно стоящая замена
		'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().Value. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Template = RegEx.Replace(Template, colMatches.item(0).Value) 'заряжаем новый паттерн
		'UPGRADE_NOTE: Object colMatches may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		colMatches = Nothing
		
		RegEx.Pattern = "@OName"
		'UPGRADE_WARNING: Couldn't resolve default property of object bd.From. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Template = RegEx.Replace(Template, bd.From)
		RegEx.Pattern = "@DName"
		'UPGRADE_WARNING: Couldn't resolve default property of object bd.rTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Template = RegEx.Replace(Template, bd.rTo)
		
		RegEx.Pattern = "@Subject"
		Template = RegEx.Replace(Template, txtSubj.Text)
		
		'UPGRADE_NOTE: Object bd may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		bd = Nothing
		
		'строки без цитирования
		If mMode = modCommon.ReplayMode.ReplayFromNotCit Then
			'null?
		End If
		
		'UPGRADE_NOTE: Object RegEx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		RegEx = Nothing
		'UPGRADE_NOTE: Object colMatches may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		colMatches = Nothing
		
		rtfMessage.Text = Template
		
		Exit Sub
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::ParseTemplateMacros")
				rtfMessage.Text = Template
		End Select
		
	End Sub
	
	'UPGRADE_NOTE: Text was upgraded to Text_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Private Function Citat(ByRef Text_Renamed() As String) As String
		On Error GoTo errHandler
		Dim RegEx As New VBScript_RegExp_55.RegExp ' РегЭкспы
		Dim colMatches As VBScript_RegExp_55.MatchCollection ' коллекция этих образцов
		Dim aMatch As VBScript_RegExp_55.Match ' один из совпавших образцов
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim str_Renamed As String
		Dim i, j As Integer
		Dim Words() As String
		Dim db As Object
		Dim frFnLn, myFnLn, toFnLn As String 'мои буквы и буквы кого цетируем, и получатель исходного
		Dim tmp As String
		Const MaxStrLen As Integer = 78 ' максимальная длянна строки
		
		RegEx.MultiLine = True ' многострочный текст
		RegEx.[Global] = True ' будем проходить всю строку
		RegEx.IgnoreCase = False ' не игнорируем регистр символов
		
		'Буквы имени и фамилии от кого цетируем
		RegEx.Pattern = "(.)(\w+)(.)" 'весьма хитрый паттерн. (см. в modTextWork)
		colMatches = RegEx.Execute(txtFrom.Text)
		
		For	Each aMatch In colMatches ' проходим по всей коллекции
			'UPGRADE_WARNING: Couldn't resolve default property of object aMatch.SubMatches(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			myFnLn = myFnLn & aMatch.SubMatches(0)
		Next aMatch
		
		db = TransferMessage.base
		'UPGRADE_WARNING: Couldn't resolve default property of object db.GetHeadesByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		db.GetHeadesByNum(TransferMessage.CurrentMail)
		
		If TransferMessage.Mode <> modCommon.ReplayMode.ReplayTo Then
			
			'RegEx.Pattern = "(.)(\w+)(.)"'тут уже он загружен
			'UPGRADE_WARNING: Couldn't resolve default property of object db.From. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			colMatches = RegEx.Execute(db.From)
			
			For	Each aMatch In colMatches
				'UPGRADE_WARNING: Couldn't resolve default property of object aMatch.SubMatches(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				frFnLn = frFnLn & aMatch.SubMatches(0)
			Next aMatch
			
			'UPGRADE_WARNING: Couldn't resolve default property of object db.rTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			colMatches = RegEx.Execute(db.rTo)
			
			For	Each aMatch In colMatches
				'UPGRADE_WARNING: Couldn't resolve default property of object aMatch.SubMatches(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				toFnLn = toFnLn & aMatch.SubMatches(0)
			Next aMatch
			
		Else
			
			RegEx.Pattern = "(.)(\w+)(.)"
			'UPGRADE_WARNING: Couldn't resolve default property of object db.rTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			colMatches = RegEx.Execute(db.rTo)
			
			For	Each aMatch In colMatches
				'UPGRADE_WARNING: Couldn't resolve default property of object aMatch.SubMatches(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				frFnLn = frFnLn & aMatch.SubMatches(0)
			Next aMatch
			
			'UPGRADE_WARNING: Couldn't resolve default property of object db.From. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			colMatches = RegEx.Execute(db.From)
			
			For	Each aMatch In colMatches
				'UPGRADE_WARNING: Couldn't resolve default property of object aMatch.SubMatches(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				toFnLn = toFnLn & aMatch.SubMatches(0)
			Next aMatch
			
		End If
		
		frFnLn = Replace(Replace(frFnLn, ")", "\)"), "(", "\(")
		toFnLn = Replace(Replace(toFnLn, ")", "\)"), "(", "\(")
		
		For i = 0 To UBound(Text_Renamed)
			
			If InStr(1, Text_Renamed(i), Chr(1), CompareMethod.Binary) = 0 And Len(Text_Renamed(i)) <> 0 Then
				'если уже ессть наша цитата и чужая, то увиличиваем число галочек
				RegEx.Pattern = myFnLn & ">"
				Text_Renamed(i) = RegEx.Replace(Text_Renamed(i), myFnLn & ">")
				RegEx.Pattern = frFnLn & ">"
				Text_Renamed(i) = RegEx.Replace(Text_Renamed(i), frFnLn & ">>")
				RegEx.Pattern = toFnLn & ">"
				Text_Renamed(i) = RegEx.Replace(Text_Renamed(i), toFnLn & ">>")
				
				'проверяем, есть ли уже цитата в строчке или нет, если нет, то цетируем строчку
				RegEx.Pattern = "(" & myFnLn & ">|" & frFnLn & ">|" & toFnLn & ">)"
				
				If Not RegEx.Test(Text_Renamed(i)) Then
					If Len(" " & frFnLn & "> " & Text_Renamed(i)) > MaxStrLen Then
						'тут перенос длинных строк по словам
						Words = Split(Text_Renamed(i), " ")
						j = 0 : tmp = ""
						While j <= UBound(Words)
							
							If Len(tmp) + Len(Words(j)) < MaxStrLen - Len(Words(j)) Then
								tmp = tmp & Words(j) & " "
							Else
								str_Renamed = str_Renamed & " " & frFnLn & "> " & tmp & vbCrLf 'тестовая замена my на fr
								tmp = " " & Words(j) & " "
							End If
							
							j = j + 1
						End While
						str_Renamed = str_Renamed & " " & frFnLn & "> " & tmp & vbCrLf
					Else
						'если тут у нас есть строчка вида "XX>(n шт.) " то нужно увеличить эти скобочки
						RegEx.Pattern = "\s(\w\w)(>+)\s"
						colMatches = RegEx.Execute(Text_Renamed(i))
						
						If colMatches.Count > 0 Then
							'UPGRADE_WARNING: Couldn't resolve default property of object colMatches.item().SubMatches. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							tmp = colMatches.item(0).SubMatches(0) & colMatches.item(0).SubMatches(1) 'здесь будет строчка "XX>>>"
							str_Renamed = str_Renamed & " " & Replace(Text_Renamed(i), tmp, tmp & "> ") & vbCrLf
						Else
							'str = str & " " & myFnLn & "> " & Text(i) & vbCrLf
							str_Renamed = str_Renamed & " " & Replace(Replace(frFnLn, "\)", ")"), "\(", "(") & "> " & Text_Renamed(i) & vbCrLf
						End If
						
					End If
					
				Else
					
					'тут тоже надо наверно вставить перенос
					If VB.Left(Text_Renamed(i), 1) <> " " Then
						str_Renamed = str_Renamed & " " & Text_Renamed(i) & vbCrLf
					Else
						str_Renamed = str_Renamed & Text_Renamed(i) & vbCrLf
					End If
				End If
				
			End If
			
		Next i
		
		Citat = str_Renamed
		'UPGRADE_NOTE: Object db may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		db = Nothing
		'UPGRADE_NOTE: Object RegEx may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		RegEx = Nothing
		'UPGRADE_NOTE: Object colMatches may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		colMatches = Nothing
		
		Exit Function
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::Citat")
		End Select
		
	End Function
	
	Public Sub ShowFromAddrBook(ByRef MailParam() As String)
		On Error GoTo errHandler
		
		Select Case MailParam(2)
			
			Case "EchoMail"
				'выбираем эхи
				frmEchoSelect.DefInstance.Parent_Renamed = Me
				frmEchoSelect.DefInstance.SelectEcho = False
				frmEchoSelect.DefInstance.ShowDialog()
				'теперь у нас есть список эх в которые помещать мессаг.
				
				'исспользуем этот код для отлова выхода из формы.
				Err.Clear()
				
				If Err.Number = 0 And Len(sEchos(0)) <> 0 Then
					
					'тут исспользуется фиктивная база на которую указывает 0 в CurrentMail
					With TransferMessage
						.base = New jamBase
						.BaseType = "JAM"
						.CurrentMail = 0
						.Mode = modCommon.ReplayMode.BookMail
						'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						.base.MessageFlags = jamBase.MSG_ATTRIBUTE.MSG_TYPEECHO Or jamBase.MSG_ATTRIBUTE.Msg_Local
					End With
					
					System.Windows.Forms.Application.DoEvents()
					BookMailParam = VB6.CopyArray(MailParam)
					
					BookShow = True
					'тут вызываем редактирование
					Me.ShowDialog()
					
					If Not BookShow Then
						MsgBox("Mail Sended.", MsgBoxStyle.Information, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - Debug Mode")
					End If
					
				End If
				
			Case "NetMail"
				
				'единственный случай когда исспользуем реальную базу
				With TransferMessage
					.base = New msgBase
					'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.DBName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					.base.DBName = GetGFEOption("Options", "Netmail Dir", "C:\T-Mail\Mail")
					.BaseType = "MSG"
					.CurrentMail = 0 'тут 0 указывает на новое письмо
					.Mode = modCommon.ReplayMode.BookMail
					'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.OpenDB. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					.base.OpenDB()
					'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					.base.MessageFlags = GetGFEOption("Options", "Netmail Flags", CStr(msgBase.MSG_ATTRIBUTES.Msg_Kill Or msgBase.MSG_ATTRIBUTES.Msg_Private Or msgBase.MSG_ATTRIBUTES.Msg_Local))
				End With
				
				System.Windows.Forms.Application.DoEvents()
				BookMailParam = VB6.CopyArray(MailParam)
				
				BookShow = True
				'тут вызываем редактирование
				Me.ShowDialog()
				
				If Not BookShow Then
					MsgBox("Mail Sended.", MsgBoxStyle.Information, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - Debug Mode")
				End If
				
		End Select
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::ShowFromAddrBook")
		End Select
		
	End Sub
	
	'создает семафор
	Private Sub CreateFlag()
		On Error GoTo errHandler
		Dim flg As String
		Dim ff As Integer
		
		ff = FreeFile
		flg = GetGFEOption("Options", "Semaphore")
		
		If Len(flg) <> 0 Then
			FileOpen(ff, flg, OpenMode.Output)
			FileClose(ff)
		End If
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::CreateFlag")
		End Select
		
	End Sub
	
	Private Function GetLineCount(ByRef Current As Boolean) As Integer
		On Error GoTo errHandler
		Dim z() As String
		Dim i, curr As Integer
		
		If Current Then
			'возвращает текущую строчку
			z = Split(rtfMessage.Text, vbCrLf)
			
			For i = 0 To UBound(z)
				curr = curr + Len(z(i)) + 2
				
				If curr >= rtfMessage.SelStart Then
					GetLineCount = i + 1
					Exit For
				End If
				
			Next i
			
		Else
			'возвращает общее число строк
			z = Split(rtfMessage.Text, vbCrLf)
			GetLineCount = UBound(z) + 1
		End If
		
		Exit Function
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::GetLineCount")
		End Select
		
	End Function
	
	'Записывает мессаг в базу
	Private Sub WriteMessage()
		On Error GoTo errHandler
		Dim db As jamBase
		Dim mdb As msgBase
		Dim vt As String
		Dim cnt As Integer
		Dim ndeEl As MSComctlLib.ListItem
		Dim ndeTV As MSComctlLib.Node
		Dim i As Integer
		Dim ecAka As String
		
		If Len(txtTo.Text) = 0 Then
			MsgBox("Поле ""Кому"" не должно быть пустым!", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
			Exit Sub
		End If
		
		If Len(txtFrom.Text) = 0 Then
			MsgBox("Поле ""От"" не должно быть пустым!", MsgBoxStyle.Exclamation + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
			Exit Sub
		End If
		
		If Len(txtSubj.Text) = 0 Then
			If MsgBox("Тема письма не заполнена! Продолжить?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.ApplicationModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name) = MsgBoxResult.No Then
				Exit Sub
			End If
		End If
		
		vt = GetGFEOption("Options", "MailListView", "TreeView") 'текущей режим
		
		Dim msg As New msgBase
		Dim dbb As Object
		Dim LI As MSComctlLib.ListItem
		'UPGRADE_NOTE: ddb was upgraded to ddb_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim ddb_Renamed As Object
		If (TransferMessage.Mode <> modCommon.ReplayMode.ReplayOtherArea) And (TransferMessage.Mode <> modCommon.ReplayMode.MailForward) And (TransferMessage.Mode <> modCommon.ReplayMode.BookMail) Then
			
			'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.BaseType. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Select Case TransferMessage.base.BaseType
				
				Case "JAM"
					
					db = TransferMessage.base
					
					db.From = txtFrom.Text
					db.FromAddr = cboAddress.Text
					db.rTo = txtTo.Text
					
					If TransferMessage.Mode <> modCommon.ReplayMode.NewMail Then
						'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.rToAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						db.rToAddr = TransferMessage.base.rToAddr
						db.ReplayTo = TransferMessage.CurrentMail
					Else
						db.rToAddr = cboAddress.Text
						db.ReplayTo = 0
					End If
					
					db.Subj = txtSubj.Text
					db.MessageFlags = jamBase.MSG_ATTRIBUTE.MSG_TYPEECHO + jamBase.MSG_ATTRIBUTE.Msg_Local
					'выполняем приведение мессага к стандартному виду и его запись
					db.Message = Replace(ReplaceCharsInText(), vbCrLf, vbCr)
					
					If db.WriteMessage = -1 Then
						Exit Sub
					End If
					
					cnt = db.MessageCount
					'UPGRADE_NOTE: Object db may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
					db = Nothing
					
					Select Case vt
						
						Case "TreeView"
							ndeTV = frmMain.DefInstance.MailList.Nodes.Add( , 4,  , cnt & ":" & txtSubj.Text, 1)
							
							With ndeTV
								.let_Tag("r" & CStr(cnt) & "r")
							End With
							
						Case "ListView"
							ndeEl = frmMain.DefInstance.MailList2.ListItems.Add( ,  , cnt & ":" & txtSubj.Text, 1, 1)
							
							With ndeEl
								.let_Tag("r" & CStr(cnt) & "r")
								.SubItems(1) = txtFrom.Text
								.SubItems(2) = txtTo.Text
							End With
							
					End Select
					
					'UPGRADE_NOTE: Object ndeEl may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
					ndeEl = Nothing
					'UPGRADE_NOTE: Object ndeTV may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
					ndeTV = Nothing
					
				Case "MSG"
					
					mdb = TransferMessage.base
					
					mdb.From = txtFrom.Text
					mdb.FromAddr = cboAddress.Text
					mdb.rTo = txtTo.Text
					mdb.rToAddr = cboToAddress.Text 'TransferMessage.Base.rToAddr
					mdb.Subj = txtSubj.Text
					mdb.MessageFlags = CInt(GetGFEOption("Options", "Netmail Flags", CStr(msgBase.MSG_ATTRIBUTES.Msg_Private + msgBase.MSG_ATTRIBUTES.Msg_Local + jamBase.MSG_ATTRIBUTE.MSG_KILLSENT)))
					mdb.ReplayTo = TransferMessage.CurrentMail
					mdb.Message = Replace(rtfMessage.Text, vbCrLf, vbCr)
					
					If mdb.WriteMessage = -1 Then
						Exit Sub
					End If
					
					cnt = mdb.MessageCount
					
					'UPGRADE_NOTE: Object mdb may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
					mdb = Nothing
					
					Select Case vt
						
						Case "TreeView"
							ndeTV = frmMain.DefInstance.MailList.Nodes.Add( , 4,  , cnt & ":" & txtSubj.Text, 1)
							
							With ndeTV
								.let_Tag("N" & CStr(cnt) & "N")
							End With
							
						Case "ListView"
							ndeEl = frmMain.DefInstance.MailList2.ListItems.Add( ,  , cnt & ":" & txtSubj.Text, 1, 1)
							
							With ndeEl
								.let_Tag("N" & CStr(cnt) & "N")
								.SubItems(1) = txtFrom.Text
								.SubItems(2) = txtTo.Text
							End With
							
					End Select
					
					'UPGRADE_NOTE: Object ndeEl may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
					ndeEl = Nothing
					'UPGRADE_NOTE: Object ndeTV may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
					ndeTV = Nothing
					
				Case "SQU"
					
					db = TransferMessage.base
					
					db.From = txtFrom.Text
					db.FromAddr = cboAddress.Text
					db.rTo = txtTo.Text
					
					If TransferMessage.Mode <> modCommon.ReplayMode.NewMail Then
						'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.rToAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						db.rToAddr = TransferMessage.base.rToAddr
						db.ReplayTo = TransferMessage.CurrentMail
					Else
						db.rToAddr = cboAddress.Text
						db.ReplayTo = 0
					End If
					
					db.Subj = txtSubj.Text
					db.MessageFlags = jamBase.MSG_ATTRIBUTE.MSG_TYPEECHO + jamBase.MSG_ATTRIBUTE.Msg_Local
					db.Message = Replace(rtfMessage.Text, vbCrLf, vbCr)
					
					If db.WriteMessage = -1 Then
						Exit Sub
					End If
					
					'UPGRADE_NOTE: Object db may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
					db = Nothing
					
			End Select
			
		ElseIf (TransferMessage.Mode <> modCommon.ReplayMode.BookMail) Then 
			
			HighlightTextPlain(rtfMessage)
			txtChangeFlag = False
			
			'выбираем эхи
			frmEchoSelect.DefInstance.Parent_Renamed = Me
			frmEchoSelect.DefInstance.SelectEcho = True
			frmEchoSelect.DefInstance.ShowDialog()
			
			If Len(sEchos(0)) <> 0 Then
				
				For i = 0 To UBound(sEchos)
					
					If LCase(sEchos(i)) <> "netmail" Then
						
						'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoFileByName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						Select Case LCase(VB.Right(clsEchos.GetEchoFileByName(sEchos(i)), 3))
							
							Case "jhr"
								ddb_Renamed = New jamBase
								
							Case "sqd"
								'Set ddb = New sqBase
						End Select
						
						'UPGRADE_WARNING: Couldn't resolve default property of object ddb_Renamed.DBName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoFileByName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						ddb_Renamed.DBName = clsEchos.GetEchoFileByName(sEchos(i))
						'UPGRADE_WARNING: Couldn't resolve default property of object ddb_Renamed.From. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						ddb_Renamed.From = txtFrom.Text
						
						'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoNumByName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoAkAByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						ecAka = clsEchos.GetEchoAkAByNum(clsEchos.GetEchoNumByName(sEchos(i)))
						
						If cboAddress.Text <> ecAka Then
							If MsgBox("Вы действительно хотите исспользовать АКА: " & cboAddress.Text & vbCrLf & "для эхи с АКА: " & ecAka & " ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name) = MsgBoxResult.Yes Then
								'UPGRADE_WARNING: Couldn't resolve default property of object ddb_Renamed.FromAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								ddb_Renamed.FromAddr = cboAddress.Text
							Else
								'UPGRADE_WARNING: Couldn't resolve default property of object ddb_Renamed.FromAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								ddb_Renamed.FromAddr = ecAka
							End If
							
						Else
							'UPGRADE_WARNING: Couldn't resolve default property of object ddb_Renamed.FromAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
							ddb_Renamed.FromAddr = cboAddress.Text
						End If
						
						'UPGRADE_WARNING: Couldn't resolve default property of object ddb_Renamed.rTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						ddb_Renamed.rTo = txtTo.Text
						'UPGRADE_WARNING: Couldn't resolve default property of object ddb_Renamed.rToAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						ddb_Renamed.rToAddr = vbNullString 'Echomail адрес не требуется
						'UPGRADE_WARNING: Couldn't resolve default property of object ddb_Renamed.Subj. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						ddb_Renamed.Subj = txtSubj.Text
						'UPGRADE_WARNING: Couldn't resolve default property of object ddb_Renamed.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						ddb_Renamed.MessageFlags = jamBase.MSG_ATTRIBUTE.MSG_TYPEECHO + jamBase.MSG_ATTRIBUTE.Msg_Local
						'UPGRADE_WARNING: Couldn't resolve default property of object ddb_Renamed.ReplayTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						ddb_Renamed.ReplayTo = 0
						'UPGRADE_WARNING: Couldn't resolve default property of object ddb_Renamed.Message. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						ddb_Renamed.Message = Replace(rtfMessage.Text, vbCrLf, vbCr)
						
						'UPGRADE_WARNING: Couldn't resolve default property of object ddb_Renamed.WriteMessage. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						If ddb_Renamed.WriteMessage = -1 Then
							Exit Sub
						End If
						
						'UPGRADE_NOTE: Object ddb_Renamed may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
						ddb_Renamed = Nothing
						
					Else
						
						msg.DBName = GetGFEOption("Options", "Netmail Dir", "C:\T-Mail\Mail")
						msg.From = txtFrom.Text
						msg.FromAddr = cboAddress.Text
						msg.rTo = txtTo.Text
						'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.rToAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						msg.rToAddr = TransferMessage.base.rToAddr
						msg.Subj = txtSubj.Text
						msg.MessageFlags = CInt(GetGFEOption("Options", "Netmail Flags", CStr(msgBase.MSG_ATTRIBUTES.Msg_Private + msgBase.MSG_ATTRIBUTES.Msg_Local + jamBase.MSG_ATTRIBUTE.MSG_KILLSENT)))
						msg.ReplayTo = TransferMessage.CurrentMail
						msg.Message = Replace(rtfMessage.Text, vbCrLf, vbCr)
						
						If msg.WriteMessage = -1 Then
							Exit Sub
						End If
						
						'UPGRADE_NOTE: Object msg may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
						msg = Nothing
						
					End If
					
				Next i
				
			Else
				'если пользователь не выбрал эху, то просто выходим нафик...
				txtChangeFlag = True 'Устанавливаем флаг изменения, мож он еще подумает
				Me.Close() 'Спросим что он надумал
				Exit Sub 'выйдем нафсякий случай
			End If '<> "" - т.е. что-то выбрали
			
		Else
			
			'bookmail
			Select Case BookMailParam(2)
				
				Case "EchoMail"
					
					If Len(sEchos(0)) <> 0 Then
						
						For i = 0 To UBound(sEchos)
							
							If LCase(sEchos(i)) <> "netmail" Then 'пока обойдемся без нетмыла
								
								'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoFileByName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								Select Case LCase(VB.Right(clsEchos.GetEchoFileByName(sEchos(i)), 3))
									
									Case "jhr"
										dbb = New jamBase
										
									Case "sqd"
										'Set dbb = New sqBase
								End Select
								
								'вытащим ака для эхи
								LI = frmMain.DefInstance.EchoList.FindItem(sEchos(i))
								
								'UPGRADE_WARNING: Couldn't resolve default property of object dbb.DBName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoFileByName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								dbb.DBName = clsEchos.GetEchoFileByName(sEchos(i))
								'UPGRADE_WARNING: Couldn't resolve default property of object dbb.From. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								dbb.From = txtFrom.Text
								'UPGRADE_WARNING: Couldn't resolve default property of object dbb.FromAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								dbb.FromAddr = LI.SubItems(3) 'подставляем АКА чтоб не иметь проблем в эхе
								'UPGRADE_WARNING: Couldn't resolve default property of object dbb.rTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								dbb.rTo = txtTo.Text
								'UPGRADE_WARNING: Couldn't resolve default property of object dbb.rToAddr. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								dbb.rToAddr = ""
								'UPGRADE_WARNING: Couldn't resolve default property of object dbb.Subj. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								dbb.Subj = txtSubj.Text
								'UPGRADE_WARNING: Couldn't resolve default property of object dbb.MessageFlags. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								dbb.MessageFlags = jamBase.MSG_ATTRIBUTE.MSG_TYPEECHO + jamBase.MSG_ATTRIBUTE.Msg_Local
								'UPGRADE_WARNING: Couldn't resolve default property of object dbb.ReplayTo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								dbb.ReplayTo = 0
								'UPGRADE_WARNING: Couldn't resolve default property of object dbb.Message. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								dbb.Message = Replace(rtfMessage.Text, vbCrLf, vbCr)
								
								'UPGRADE_WARNING: Couldn't resolve default property of object dbb.WriteMessage. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
								If dbb.WriteMessage = -1 Then
									Exit Sub
								End If
								
								'UPGRADE_NOTE: Object dbb may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
								dbb = Nothing
								'UPGRADE_NOTE: Object LI may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
								LI = Nothing
								
								BookShow = False
								
							End If
							
						Next i
						
						txtChangeFlag = False 'Сбрасываем флаг изменения
						Me.Close()
						Exit Sub 'выйдем нафсякий случай
					Else
						'если пользователь не выбрал эху, то просто выходим нафик...
						txtChangeFlag = True 'Устанавливаем флаг изменения, мож он еще подумает
						Me.Close() 'Спросим что он надумал
						Exit Sub 'выйдем нафсякий случай
					End If '<> "" - т.е. что-то выбрали
					
				Case "NetMail"
					
					mdb = TransferMessage.base
					
					mdb.From = txtFrom.Text
					mdb.FromAddr = cboAddress.Text
					mdb.rTo = txtTo.Text
					mdb.rToAddr = cboToAddress.Text
					mdb.Subj = txtSubj.Text
					mdb.MessageFlags = CInt(GetGFEOption("Options", "Netmail Flags", CStr(msgBase.MSG_ATTRIBUTES.Msg_Private + msgBase.MSG_ATTRIBUTES.Msg_Local + jamBase.MSG_ATTRIBUTE.MSG_KILLSENT)))
					mdb.ReplayTo = TransferMessage.CurrentMail
					mdb.Message = Replace(rtfMessage.Text, vbCrLf, vbCr)
					
					If mdb.WriteMessage = -1 Then
						Exit Sub
					End If
					
					'UPGRADE_NOTE: Object mdb may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
					mdb = Nothing
					
			End Select
			
		End If
		
		HighlightTextPlain((Me.rtfMessage), TransferMessage.base, False)
		txtChangeFlag = False 'сбрасываем флаг изменения текста
		
		'Если установлен флажок удаления письма в нетмыле, то спросим.
		If NetmailKsFlag Then
			If MsgBox("Сообщение сохранено." & vbCrLf & "Удалить оригинал письма?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name) = MsgBoxResult.Yes Then
				'UPGRADE_WARNING: Couldn't resolve default property of object TransferMessage.base.DeleteMessageByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				TransferMessage.base.DeleteMessageByNum(TransferMessage.CurrentMail - 1)
			End If
			
		Else
			MsgBox("Сообщение сохранено.", MsgBoxStyle.Information, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " - Debug Mode")
		End If
		
		frmMain.DefInstance.EchoList.SelectedItem.SubItems(1) = CStr(CDbl(frmMain.DefInstance.EchoList.SelectedItem.SubItems(1)) + 1) 'увеличиваем счетчик писем
		CreateFlag() 'записали мессаг создаем флажок
		Me.Close()
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::WriteMessage")
		End Select
		
	End Sub
	
	Private Sub txtTo_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtTo.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		On Error GoTo errHandler
		
		'F2- Save Message
		If KeyCode = System.Windows.Forms.Keys.F2 Then
			WriteMessage()
		End If
		
		System.Windows.Forms.Application.DoEvents()
		
		'quit
		If KeyCode = System.Windows.Forms.Keys.Escape Then
			Me.Close()
		End If
		
		'enter
		If KeyCode = System.Windows.Forms.Keys.Return Then
			Me.rtfMessage.Focus()
		End If
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::txtTo_KeyUp")
		End Select
		
	End Sub
	
	Private Sub SetCurrentOurNetMailAKA(ByRef AKA As String)
		On Error GoTo errHandler
		Dim i As Integer
		
		i = InStr(1, AKA, "/") - 1
		
		If i > 0 Then
			AKA = Mid(AKA, 1, i)
			
			For i = 0 To cboAddress.Items.Count
				
				If InStr(1, VB6.GetItemString(cboAddress, i), AKA, CompareMethod.Text) <> 0 Then
					cboAddress.Text = VB6.GetItemString(cboAddress, i)
					Exit For
				End If
				
			Next i
			
		End If
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmMailEditor::SetCurrentOurNetMailAKA")
		End Select
		
	End Sub
End Class