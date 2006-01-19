Option Strict Off
Option Explicit On
Friend Class frmFindDialog
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
	Public WithEvents opCurrentMail As System.Windows.Forms.RadioButton
	Public WithEvents opAllEchos As System.Windows.Forms.RadioButton
	Public WithEvents opCurrentEcho As System.Windows.Forms.RadioButton
	Public WithEvents opRegExpSearch As System.Windows.Forms.RadioButton
	Public WithEvents opLogicSearch As System.Windows.Forms.RadioButton
	Public WithEvents ProgressBar1 As AxMSComctlLib.AxProgressBar
	Public WithEvents StatusBar1 As AxMSComctlLib.AxStatusBar
	Public WithEvents chkAdvancedSearch As System.Windows.Forms.CheckBox
	Public WithEvents cboEchos As System.Windows.Forms.ComboBox
	Public WithEvents chkGoToFirstFind As System.Windows.Forms.CheckBox
	Public WithEvents fraEchos As System.Windows.Forms.GroupBox
	Public WithEvents chkMessageFind As System.Windows.Forms.CheckBox
	Public WithEvents chkToFind As System.Windows.Forms.CheckBox
	Public WithEvents chkFromFind As System.Windows.Forms.CheckBox
	Public WithEvents chkTheamFind As System.Windows.Forms.CheckBox
	Public WithEvents frmChecked As System.Windows.Forms.GroupBox
	Public WithEvents cboFind As System.Windows.Forms.ComboBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents frmOp1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdBeginFind As System.Windows.Forms.Button
	Public WithEvents cmdStopFind As System.Windows.Forms.Button
	Public WithEvents cmdGo As System.Windows.Forms.Button
	Public WithEvents cmdView As System.Windows.Forms.Button
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents ImageList1 As AxMSComctlLib.AxImageList
	Public WithEvents FindList As AxMSComctlLib.AxListView
	Public WithEvents frmFindList As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFindDialog))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.opCurrentMail = New System.Windows.Forms.RadioButton
		Me.opAllEchos = New System.Windows.Forms.RadioButton
		Me.opCurrentEcho = New System.Windows.Forms.RadioButton
		Me.opRegExpSearch = New System.Windows.Forms.RadioButton
		Me.opLogicSearch = New System.Windows.Forms.RadioButton
		Me.ProgressBar1 = New AxMSComctlLib.AxProgressBar
		Me.StatusBar1 = New AxMSComctlLib.AxStatusBar
		Me.frmOp1 = New System.Windows.Forms.GroupBox
		Me.chkAdvancedSearch = New System.Windows.Forms.CheckBox
		Me.cboEchos = New System.Windows.Forms.ComboBox
		Me.chkGoToFirstFind = New System.Windows.Forms.CheckBox
		Me.fraEchos = New System.Windows.Forms.GroupBox
		Me.frmChecked = New System.Windows.Forms.GroupBox
		Me.chkMessageFind = New System.Windows.Forms.CheckBox
		Me.chkToFind = New System.Windows.Forms.CheckBox
		Me.chkFromFind = New System.Windows.Forms.CheckBox
		Me.chkTheamFind = New System.Windows.Forms.CheckBox
		Me.cboFind = New System.Windows.Forms.ComboBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.cmdBeginFind = New System.Windows.Forms.Button
		Me.cmdStopFind = New System.Windows.Forms.Button
		Me.frmFindList = New System.Windows.Forms.GroupBox
		Me.cmdGo = New System.Windows.Forms.Button
		Me.cmdView = New System.Windows.Forms.Button
		Me.cmdClose = New System.Windows.Forms.Button
		Me.ImageList1 = New AxMSComctlLib.AxImageList
		Me.FindList = New AxMSComctlLib.AxListView
		CType(Me.ProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.StatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.FindList, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Поиск"
		Me.ClientSize = New System.Drawing.Size(503, 268)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.Icon = CType(resources.GetObject("frmFindDialog.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmFindDialog"
		Me.opCurrentMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.opCurrentMail.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.opCurrentMail.Text = "&Текущее письмо"
		Me.opCurrentMail.Size = New System.Drawing.Size(111, 13)
		Me.opCurrentMail.Location = New System.Drawing.Point(160, 145)
		Me.opCurrentMail.TabIndex = 26
		Me.opCurrentMail.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.opCurrentMail.BackColor = System.Drawing.SystemColors.Control
		Me.opCurrentMail.CausesValidation = True
		Me.opCurrentMail.Enabled = True
		Me.opCurrentMail.ForeColor = System.Drawing.SystemColors.ControlText
		Me.opCurrentMail.Cursor = System.Windows.Forms.Cursors.Default
		Me.opCurrentMail.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.opCurrentMail.Appearance = System.Windows.Forms.Appearance.Normal
		Me.opCurrentMail.TabStop = True
		Me.opCurrentMail.Checked = False
		Me.opCurrentMail.Visible = True
		Me.opCurrentMail.Name = "opCurrentMail"
		Me.opAllEchos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.opAllEchos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.opAllEchos.Text = "Во всех эх&ах"
		Me.opAllEchos.Size = New System.Drawing.Size(111, 17)
		Me.opAllEchos.Location = New System.Drawing.Point(160, 178)
		Me.opAllEchos.TabIndex = 25
		Me.opAllEchos.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.opAllEchos.BackColor = System.Drawing.SystemColors.Control
		Me.opAllEchos.CausesValidation = True
		Me.opAllEchos.Enabled = True
		Me.opAllEchos.ForeColor = System.Drawing.SystemColors.ControlText
		Me.opAllEchos.Cursor = System.Windows.Forms.Cursors.Default
		Me.opAllEchos.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.opAllEchos.Appearance = System.Windows.Forms.Appearance.Normal
		Me.opAllEchos.TabStop = True
		Me.opAllEchos.Checked = False
		Me.opAllEchos.Visible = True
		Me.opAllEchos.Name = "opAllEchos"
		Me.opCurrentEcho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.opCurrentEcho.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.opCurrentEcho.Text = "Текущая &эха"
		Me.opCurrentEcho.Size = New System.Drawing.Size(111, 17)
		Me.opCurrentEcho.Location = New System.Drawing.Point(160, 161)
		Me.opCurrentEcho.TabIndex = 24
		Me.opCurrentEcho.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.opCurrentEcho.BackColor = System.Drawing.SystemColors.Control
		Me.opCurrentEcho.CausesValidation = True
		Me.opCurrentEcho.Enabled = True
		Me.opCurrentEcho.ForeColor = System.Drawing.SystemColors.ControlText
		Me.opCurrentEcho.Cursor = System.Windows.Forms.Cursors.Default
		Me.opCurrentEcho.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.opCurrentEcho.Appearance = System.Windows.Forms.Appearance.Normal
		Me.opCurrentEcho.TabStop = True
		Me.opCurrentEcho.Checked = False
		Me.opCurrentEcho.Visible = True
		Me.opCurrentEcho.Name = "opCurrentEcho"
		Me.opRegExpSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.opRegExpSearch.Text = "Поиск по р&егулярному выражению"
		Me.opRegExpSearch.Size = New System.Drawing.Size(289, 17)
		Me.opRegExpSearch.Location = New System.Drawing.Point(15, 85)
		Me.opRegExpSearch.TabIndex = 23
		Me.opRegExpSearch.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.opRegExpSearch.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.opRegExpSearch.BackColor = System.Drawing.SystemColors.Control
		Me.opRegExpSearch.CausesValidation = True
		Me.opRegExpSearch.Enabled = True
		Me.opRegExpSearch.ForeColor = System.Drawing.SystemColors.ControlText
		Me.opRegExpSearch.Cursor = System.Windows.Forms.Cursors.Default
		Me.opRegExpSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.opRegExpSearch.Appearance = System.Windows.Forms.Appearance.Normal
		Me.opRegExpSearch.TabStop = True
		Me.opRegExpSearch.Checked = False
		Me.opRegExpSearch.Visible = True
		Me.opRegExpSearch.Name = "opRegExpSearch"
		Me.opLogicSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.opLogicSearch.Text = "Поиск использованием &логических операций"
		Me.opLogicSearch.Size = New System.Drawing.Size(297, 17)
		Me.opLogicSearch.Location = New System.Drawing.Point(15, 101)
		Me.opLogicSearch.TabIndex = 22
		Me.opLogicSearch.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.opLogicSearch.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.opLogicSearch.BackColor = System.Drawing.SystemColors.Control
		Me.opLogicSearch.CausesValidation = True
		Me.opLogicSearch.Enabled = True
		Me.opLogicSearch.ForeColor = System.Drawing.SystemColors.ControlText
		Me.opLogicSearch.Cursor = System.Windows.Forms.Cursors.Default
		Me.opLogicSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.opLogicSearch.Appearance = System.Windows.Forms.Appearance.Normal
		Me.opLogicSearch.TabStop = True
		Me.opLogicSearch.Checked = False
		Me.opLogicSearch.Visible = True
		Me.opLogicSearch.Name = "opLogicSearch"
		ProgressBar1.OcxState = CType(resources.GetObject("ProgressBar1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.ProgressBar1.Size = New System.Drawing.Size(89, 17)
		Me.ProgressBar1.Location = New System.Drawing.Point(306, 452)
		Me.ProgressBar1.TabIndex = 15
		Me.ProgressBar1.Name = "ProgressBar1"
		StatusBar1.OcxState = CType(resources.GetObject("StatusBar1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.StatusBar1.Size = New System.Drawing.Size(503, 25)
		Me.StatusBar1.Location = New System.Drawing.Point(0, 243)
		Me.StatusBar1.TabIndex = 5
		Me.StatusBar1.Name = "StatusBar1"
		Me.frmOp1.Size = New System.Drawing.Size(385, 241)
		Me.frmOp1.Location = New System.Drawing.Point(0, 0)
		Me.frmOp1.TabIndex = 4
		Me.frmOp1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frmOp1.BackColor = System.Drawing.SystemColors.Control
		Me.frmOp1.Enabled = True
		Me.frmOp1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frmOp1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frmOp1.Visible = True
		Me.frmOp1.Name = "frmOp1"
		Me.chkAdvancedSearch.Text = "&Расширенный поиск"
		Me.chkAdvancedSearch.Enabled = False
		Me.chkAdvancedSearch.Size = New System.Drawing.Size(289, 17)
		Me.chkAdvancedSearch.Location = New System.Drawing.Point(16, 67)
		Me.chkAdvancedSearch.TabIndex = 21
		Me.chkAdvancedSearch.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkAdvancedSearch.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkAdvancedSearch.BackColor = System.Drawing.SystemColors.Control
		Me.chkAdvancedSearch.CausesValidation = True
		Me.chkAdvancedSearch.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkAdvancedSearch.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkAdvancedSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkAdvancedSearch.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkAdvancedSearch.TabStop = True
		Me.chkAdvancedSearch.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkAdvancedSearch.Visible = True
		Me.chkAdvancedSearch.Name = "chkAdvancedSearch"
		Me.cboEchos.Size = New System.Drawing.Size(241, 21)
		Me.cboEchos.Location = New System.Drawing.Point(72, 40)
		Me.cboEchos.TabIndex = 16
		Me.cboEchos.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboEchos.BackColor = System.Drawing.SystemColors.Window
		Me.cboEchos.CausesValidation = True
		Me.cboEchos.Enabled = True
		Me.cboEchos.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboEchos.IntegralHeight = True
		Me.cboEchos.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboEchos.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboEchos.Sorted = False
		Me.cboEchos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboEchos.TabStop = True
		Me.cboEchos.Visible = True
		Me.cboEchos.Name = "cboEchos"
		Me.chkGoToFirstFind.Text = "Сразу переходить к &найденному сообщению"
		Me.chkGoToFirstFind.Size = New System.Drawing.Size(297, 17)
		Me.chkGoToFirstFind.Location = New System.Drawing.Point(15, 216)
		Me.chkGoToFirstFind.TabIndex = 13
		Me.chkGoToFirstFind.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkGoToFirstFind.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkGoToFirstFind.BackColor = System.Drawing.SystemColors.Control
		Me.chkGoToFirstFind.CausesValidation = True
		Me.chkGoToFirstFind.Enabled = True
		Me.chkGoToFirstFind.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkGoToFirstFind.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkGoToFirstFind.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkGoToFirstFind.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkGoToFirstFind.TabStop = True
		Me.chkGoToFirstFind.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkGoToFirstFind.Visible = True
		Me.chkGoToFirstFind.Name = "chkGoToFirstFind"
		Me.fraEchos.Text = "Поиск    "
		Me.fraEchos.ForeColor = System.Drawing.Color.Blue
		Me.fraEchos.Size = New System.Drawing.Size(133, 89)
		Me.fraEchos.Location = New System.Drawing.Point(152, 120)
		Me.fraEchos.TabIndex = 12
		Me.fraEchos.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraEchos.BackColor = System.Drawing.SystemColors.Control
		Me.fraEchos.Enabled = True
		Me.fraEchos.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraEchos.Visible = True
		Me.fraEchos.Name = "fraEchos"
		Me.frmChecked.Text = "Проверять    "
		Me.frmChecked.ForeColor = System.Drawing.Color.Blue
		Me.frmChecked.Size = New System.Drawing.Size(132, 89)
		Me.frmChecked.Location = New System.Drawing.Point(16, 120)
		Me.frmChecked.TabIndex = 7
		Me.frmChecked.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frmChecked.BackColor = System.Drawing.SystemColors.Control
		Me.frmChecked.Enabled = True
		Me.frmChecked.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frmChecked.Visible = True
		Me.frmChecked.Name = "frmChecked"
		Me.chkMessageFind.Text = "Те&кст письма"
		Me.chkMessageFind.Size = New System.Drawing.Size(103, 17)
		Me.chkMessageFind.Location = New System.Drawing.Point(8, 64)
		Me.chkMessageFind.TabIndex = 11
		Me.chkMessageFind.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkMessageFind.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkMessageFind.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkMessageFind.BackColor = System.Drawing.SystemColors.Control
		Me.chkMessageFind.CausesValidation = True
		Me.chkMessageFind.Enabled = True
		Me.chkMessageFind.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkMessageFind.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkMessageFind.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkMessageFind.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkMessageFind.TabStop = True
		Me.chkMessageFind.Visible = True
		Me.chkMessageFind.Name = "chkMessageFind"
		Me.chkToFind.Text = "П&оле ""Кому"""
		Me.chkToFind.Size = New System.Drawing.Size(103, 17)
		Me.chkToFind.Location = New System.Drawing.Point(8, 48)
		Me.chkToFind.TabIndex = 10
		Me.chkToFind.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkToFind.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkToFind.BackColor = System.Drawing.SystemColors.Control
		Me.chkToFind.CausesValidation = True
		Me.chkToFind.Enabled = True
		Me.chkToFind.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkToFind.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkToFind.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkToFind.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkToFind.TabStop = True
		Me.chkToFind.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkToFind.Visible = True
		Me.chkToFind.Name = "chkToFind"
		Me.chkFromFind.Text = "&Поле ""От кого"""
		Me.chkFromFind.Size = New System.Drawing.Size(103, 17)
		Me.chkFromFind.Location = New System.Drawing.Point(8, 32)
		Me.chkFromFind.TabIndex = 9
		Me.chkFromFind.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkFromFind.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkFromFind.BackColor = System.Drawing.SystemColors.Control
		Me.chkFromFind.CausesValidation = True
		Me.chkFromFind.Enabled = True
		Me.chkFromFind.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkFromFind.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkFromFind.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkFromFind.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkFromFind.TabStop = True
		Me.chkFromFind.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkFromFind.Visible = True
		Me.chkFromFind.Name = "chkFromFind"
		Me.chkTheamFind.Text = "Те&му письма"
		Me.chkTheamFind.Size = New System.Drawing.Size(103, 17)
		Me.chkTheamFind.Location = New System.Drawing.Point(8, 16)
		Me.chkTheamFind.TabIndex = 8
		Me.chkTheamFind.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkTheamFind.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkTheamFind.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkTheamFind.BackColor = System.Drawing.SystemColors.Control
		Me.chkTheamFind.CausesValidation = True
		Me.chkTheamFind.Enabled = True
		Me.chkTheamFind.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkTheamFind.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkTheamFind.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkTheamFind.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkTheamFind.TabStop = True
		Me.chkTheamFind.Visible = True
		Me.chkTheamFind.Name = "chkTheamFind"
		Me.cboFind.Size = New System.Drawing.Size(241, 21)
		Me.cboFind.Location = New System.Drawing.Point(72, 16)
		Me.cboFind.TabIndex = 6
		Me.cboFind.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboFind.BackColor = System.Drawing.SystemColors.Window
		Me.cboFind.CausesValidation = True
		Me.cboFind.Enabled = True
		Me.cboFind.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboFind.IntegralHeight = True
		Me.cboFind.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboFind.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboFind.Sorted = False
		Me.cboFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboFind.TabStop = True
		Me.cboFind.Visible = True
		Me.cboFind.Name = "cboFind"
		Me.Label2.Text = "В эхе"
		Me.Label2.Size = New System.Drawing.Size(57, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 40)
		Me.Label2.TabIndex = 17
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "Что искать"
		Me.Label1.Size = New System.Drawing.Size(57, 13)
		Me.Label1.Location = New System.Drawing.Point(8, 19)
		Me.Label1.TabIndex = 14
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = True
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.cmdBeginFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBeginFind.Text = "На&чать поиск"
		Me.cmdBeginFind.Size = New System.Drawing.Size(103, 25)
		Me.cmdBeginFind.Location = New System.Drawing.Point(392, 16)
		Me.cmdBeginFind.TabIndex = 3
		Me.cmdBeginFind.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBeginFind.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBeginFind.CausesValidation = True
		Me.cmdBeginFind.Enabled = True
		Me.cmdBeginFind.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBeginFind.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBeginFind.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBeginFind.TabStop = True
		Me.cmdBeginFind.Name = "cmdBeginFind"
		Me.cmdStopFind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdStopFind.Text = "&Стоп"
		Me.cmdStopFind.Enabled = False
		Me.cmdStopFind.Size = New System.Drawing.Size(103, 25)
		Me.cmdStopFind.Location = New System.Drawing.Point(392, 48)
		Me.cmdStopFind.TabIndex = 2
		Me.cmdStopFind.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdStopFind.BackColor = System.Drawing.SystemColors.Control
		Me.cmdStopFind.CausesValidation = True
		Me.cmdStopFind.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdStopFind.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdStopFind.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdStopFind.TabStop = True
		Me.cmdStopFind.Name = "cmdStopFind"
		Me.frmFindList.Text = "Список писем содержащих текст"
		Me.frmFindList.ForeColor = System.Drawing.Color.Blue
		Me.frmFindList.Size = New System.Drawing.Size(513, 217)
		Me.frmFindList.Location = New System.Drawing.Point(0, 248)
		Me.frmFindList.TabIndex = 0
		Me.frmFindList.Visible = False
		Me.frmFindList.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frmFindList.BackColor = System.Drawing.SystemColors.Control
		Me.frmFindList.Enabled = True
		Me.frmFindList.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frmFindList.Name = "frmFindList"
		Me.cmdGo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdGo.Text = "Пере&йти"
		Me.cmdGo.Size = New System.Drawing.Size(113, 25)
		Me.cmdGo.Location = New System.Drawing.Point(55, 185)
		Me.cmdGo.TabIndex = 20
		Me.cmdGo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdGo.BackColor = System.Drawing.SystemColors.Control
		Me.cmdGo.CausesValidation = True
		Me.cmdGo.Enabled = True
		Me.cmdGo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdGo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdGo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdGo.TabStop = True
		Me.cmdGo.Name = "cmdGo"
		Me.cmdView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdView.Text = "Пр&осмотреть"
		Me.cmdView.Size = New System.Drawing.Size(113, 25)
		Me.cmdView.Location = New System.Drawing.Point(183, 185)
		Me.cmdView.TabIndex = 19
		Me.cmdView.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdView.BackColor = System.Drawing.SystemColors.Control
		Me.cmdView.CausesValidation = True
		Me.cmdView.Enabled = True
		Me.cmdView.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdView.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdView.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdView.TabStop = True
		Me.cmdView.Name = "cmdView"
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClose.Text = "&Закрыть"
		Me.cmdClose.Size = New System.Drawing.Size(113, 25)
		Me.cmdClose.Location = New System.Drawing.Point(311, 185)
		Me.cmdClose.TabIndex = 18
		Me.cmdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.TabStop = True
		Me.cmdClose.Name = "cmdClose"
		ImageList1.OcxState = CType(resources.GetObject("ImageList1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.ImageList1.Location = New System.Drawing.Point(384, 56)
		Me.ImageList1.Name = "ImageList1"
		FindList.OcxState = CType(resources.GetObject("FindList.OcxState"), System.Windows.Forms.AxHost.State)
		Me.FindList.Size = New System.Drawing.Size(497, 161)
		Me.FindList.Location = New System.Drawing.Point(8, 16)
		Me.FindList.TabIndex = 1
		Me.FindList.Name = "FindList"
		Me.Controls.Add(opCurrentMail)
		Me.Controls.Add(opAllEchos)
		Me.Controls.Add(opCurrentEcho)
		Me.Controls.Add(opRegExpSearch)
		Me.Controls.Add(opLogicSearch)
		Me.Controls.Add(ProgressBar1)
		Me.Controls.Add(StatusBar1)
		Me.Controls.Add(frmOp1)
		Me.Controls.Add(cmdBeginFind)
		Me.Controls.Add(cmdStopFind)
		Me.Controls.Add(frmFindList)
		Me.frmOp1.Controls.Add(chkAdvancedSearch)
		Me.frmOp1.Controls.Add(cboEchos)
		Me.frmOp1.Controls.Add(chkGoToFirstFind)
		Me.frmOp1.Controls.Add(fraEchos)
		Me.frmOp1.Controls.Add(frmChecked)
		Me.frmOp1.Controls.Add(cboFind)
		Me.frmOp1.Controls.Add(Label2)
		Me.frmOp1.Controls.Add(Label1)
		Me.frmChecked.Controls.Add(chkMessageFind)
		Me.frmChecked.Controls.Add(chkToFind)
		Me.frmChecked.Controls.Add(chkFromFind)
		Me.frmChecked.Controls.Add(chkTheamFind)
		Me.frmFindList.Controls.Add(cmdGo)
		Me.frmFindList.Controls.Add(cmdView)
		Me.frmFindList.Controls.Add(cmdClose)
		Me.frmFindList.Controls.Add(ImageList1)
		Me.frmFindList.Controls.Add(FindList)
		CType(Me.FindList, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ImageList1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.StatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmFindDialog
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmFindDialog
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmFindDialog()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
	Dim jbd2 As New jamBase
	Dim dx, dy As Short
	
	Private Const brdButtonDX As Integer = 10 'px
	Private Const MinFormWidth As Integer = 500 'px
	Private Const MinFormHeight As Integer = 320 'px
	Private Const NormalFormHeight As Integer = 450 'px
	Private Const MinFindListHeight As Integer = 80 'px
	Private Const frmBorder As Integer = 4 'px
	
	Dim fndTheam, fndMessage As Boolean
	Dim fndTo, fndFrom As Boolean
	Dim fndOneOnly As Boolean
	
	Dim OldFindText As String
	Dim OldTxtFind As Boolean
	Dim StartFindText As Integer
	
	Private Sub cboFind_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cboFind.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 And Len(cboFind.Text) <> 0 Then
			cmdBeginFind_Click(cmdBeginFind, New System.EventArgs())
		End If
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event chkAdvancedSearch.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub chkAdvancedSearch_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAdvancedSearch.CheckStateChanged
		If chkAdvancedSearch.CheckState = 0 Then
			opRegExpSearch.Enabled = False
			opLogicSearch.Enabled = False
		Else
			opRegExpSearch.Enabled = True
			opLogicSearch.Enabled = True
		End If
	End Sub
	
	Private Sub cmdBeginFind_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBeginFind.Click
		Dim ECNum As Integer
		Dim msgtxt As String
		Dim a As Integer
		Dim sc As Integer
		Dim es As Boolean
		Dim cs As String
		Dim MaxTopSearch As Integer
		
		MaxTopSearch = 10
		If frmChecked.Enabled = True Then
			If Len(cboFind.Text) = 0 Then
				msgtxt = "Введите пожалуйста текст для поиска в поле ""Что искать"", после этого нажмите кнопку ""Начать поиск""."
				MsgBox(msgtxt, MsgBoxStyle.OKOnly + MsgBoxStyle.Exclamation, "Поиск невозможен")
				cboFind.Focus()
				Exit Sub
			End If
			
			If (chkToFind.CheckState = 0) And (chkTheamFind.CheckState = 0) And (chkFromFind.CheckState = 0) And (chkMessageFind.CheckState = 0) Then
				msgtxt = "Выберите пожалуйста области для поиска. Это можно сделать путем установки флажков ""проверять"" ""тему письма"", ""текст письма"" и другие, после этого нажмите кнопку ""Начать поиск""."
				MsgBox(msgtxt, MsgBoxStyle.OKOnly + MsgBoxStyle.Exclamation, "Поиск невозможен")
				chkTheamFind.Focus()
				Exit Sub
			End If
		End If
		
		'--------------------------------------------------------------------------
		es = False '(Exist String = False - строка не сущестсвует в реестре)
		sc = CInt(GetGFEOption("Search\top", "count", "0"))
		For a = 1 To sc
			cs = GetGFEOption("Search\top", "s" & Str(a), "")
			If Len(cs) = 0 Then Exit For 'Опа! Какой-то юзер лазил в реестр!
			If cboFind.Text = cs Then
				es = True
				Exit For
			End If
		Next a
		If es = False Then
			PutGFEOption("Search\top", "s" & Str(sc + 1), (cboFind.Text))
			PutGFEOption("Search\top", "count", Str(sc + 1))
			cboFind.Items.Add((cboFind.Text))
			
			If sc + 1 > MaxTopSearch Then
				For a = sc + 1 - MaxTopSearch To sc + 1
					cs = GetGFEOption("Search\top", "s" & Str(a), "")
					If Len(cs) = 0 Then Exit For
					PutGFEOption("Search\top", "s" & Str(a - sc - MaxTopSearch), (cboFind.Text))
				Next a
				PutGFEOption("Search\top", "count", Str(MaxTopSearch))
			End If
			cs = cboFind.Text
			LoadTopSearchList()
			cboFind.Text = cs
		End If
		'--------------------------------------------------------------------------
		
		If opCurrentMail.Checked = True Then
			a = frmMain.DefInstance.MailViewer.Find(cboFind.Text, StartFindText)
			If a = -1 Then
				msgtxt = "В тексте текущего письма не было найдено """ & cboFind.Text & """."
				MsgBox(msgtxt, MsgBoxStyle.OKOnly + MsgBoxStyle.Exclamation, "Достигнут конец письма")
				Exit Sub
			Else
				Me.Close()
			End If
		End If
		
		cmdBeginFind.Enabled = False
		cmdStopFind.Enabled = True
		cmdGo.Enabled = False
		cmdView.Enabled = False
		
		System.Windows.Forms.Application.DoEvents()
		
		OldFindText = cboFind.Text 'Запоминаем, чтобы какой-нить юзер
		'после окончания поиска, загадив
		'cboFind смог-таки перейти на
		'найденное письмо и найти
		'в нем искомый текст
		OldTxtFind = chkMessageFind.CheckState 'и это тоже
		
		
		'Можно ли это считать извращением, когда интеггеровский тип
		'мы переливаем в Булевский? (Во всяком случае такая конструкция
		'работает)
		
		fndMessage = chkMessageFind.CheckState
		fndTo = chkToFind.CheckState
		fndFrom = chkFromFind.CheckState
		fndTheam = chkTheamFind.CheckState
		fndOneOnly = chkGoToFirstFind.CheckState
		
		InitFindList(FindList) 'иницилизируем поиск
		'кроме этого процедура очищает FindList
		
		If (Me.WindowState = 0) And (chkGoToFirstFind.CheckState = 0) Then
			Me.Height = VB6.TwipsToPixelsY(NormalFormHeight * dy)
		End If
		
		StatusBar1.Panels(1).Text = "Подготовка к сканированию..."
		
		'Что бы при поиске окно раскрывалось без тормозов
		System.Windows.Forms.Application.DoEvents()
		
		If opAllEchos.Checked = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.EchosCount. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			For ECNum = 1 To clsEchos.EchosCount
				'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoFileByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				jbd2.DBName = clsEchos.GetEchoFileByNum(ECNum)
				jbd2.OpenDB()
				'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoNameByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				StatusBar1.Panels(1).Text = "Сканируется: " & clsEchos.GetEchoNameByNum(ECNum) & "..."
				
				System.Windows.Forms.Application.DoEvents()
				
				'ищщем в базе
				'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoNameByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				FindBase(jbd2, (cboFind.Text), FindList, clsEchos.GetEchoNameByNum(ECNum), fndTheam, fndMessage, fndTo, fndFrom, fndOneOnly)
				
				If SearchStopped = True Then Exit For
				If (fndOneOnly = True) And (FindList.ListItems.Count > 0) Then
					Exit For
				End If
			Next 
		End If
		
		If opCurrentEcho.Checked = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoFileByName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			jbd2.DBName = clsEchos.GetEchoFileByName(cboEchos.Text)
			jbd2.OpenDB()
			StatusBar1.Panels(1).Text = "Сканируется: " & cboEchos.Text & "..."
			System.Windows.Forms.Application.DoEvents()
			'ищщем в базе
			FindBase(jbd2, (cboFind.Text), FindList, (cboEchos.Text), fndTheam, fndMessage, fndTo, fndFrom, fndOneOnly)
		End If
		
		'UPGRADE_NOTE: Object jbd2 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		jbd2 = Nothing
		
		cmdStopFind.Enabled = False
		cmdBeginFind.Enabled = True
		
		If FindList.ListItems.Count > 0 Then
			cmdGo.Enabled = True
			cmdView.Enabled = True
			FindList.ListItems.item(1).Selected = True
			If FindList.Visible Then FindList.Focus()
		End If
		
		If SearchStopped = False Then
			StatusBar1.Panels(1).Text = "Поиск окончен"
		End If
		
		If fndOneOnly = True Then
			If FindList.ListItems.Count > 0 Then
				FindList.ListItems(1).Selected = True
				cmdGo_Click(cmdGo, New System.EventArgs())
			End If
		End If
		
	End Sub
	
	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		cmdStopFind_Click(cmdStopFind, New System.EventArgs())
		System.Windows.Forms.Application.DoEvents()
		Me.Close()
	End Sub
	
	Private Sub cmdGo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGo.Click
		Dim a, b As Integer
		Dim MLStr As String
		Dim LI As MSComctlLib.ListItem
		MLStr = GetGFEOption("Options", "MailListView", "TreeView")
		
		Me.Hide()
		
		For a = 1 To frmMain.DefInstance.EchoList.ListItems.Count
			If frmMain.DefInstance.EchoList.ListItems(a).Text = FindList.SelectedItem.Text Then
				frmMain.DefInstance.EchoList.ListItems(a).Selected = True
				System.Windows.Forms.Application.DoEvents()
				frmMain.DefInstance.EchoList_MouseUpEvent(frmMain.DefInstance.EchoList, New AxMSComctlLib.ListViewEvents_MouseUpEvent(VB6.MouseButtonConstants.LeftButton, 0, 0, 0))
				System.Windows.Forms.Application.DoEvents()
				
				Select Case MLStr
					Case "TreeView"
						For b = 1 To frmMain.DefInstance.MailList.Nodes.Count
							'FLT = FindList.SelectedItem.ListSubItems(1).Text
							'FLTLen = Len(FLT)
							
							'If Len(frmMain.MailList.Nodes(b).Text) - FLTLen + 1 > 0 Then
							'If Mid$(frmMain.MailList.Nodes(b).Text, Len(frmMain.MailList.Nodes(b).Text) - FLTLen + 1, FLTLen) = FLT Then
							If frmMain.DefInstance.MailList.Nodes(b).Text = FindList.SelectedItem.ListSubItems(1).Text Then
								frmMain.DefInstance.MailList.Nodes(b).Selected = True
								System.Windows.Forms.Application.DoEvents()
								frmMain.DefInstance.MailList_ClickEvent(frmMain.DefInstance.MailList, New System.EventArgs())
								System.Windows.Forms.Application.DoEvents()
								
								If OldTxtFind = True Then
									frmMain.DefInstance.MailViewer.Find(OldFindText)
								End If
								Exit For
							End If
							'End If
						Next b
					Case "ListView"
						'Вот за что я люблю ListView :)
						'Можно я хотябы заполню различия в коде ремарками... :)))
						LI = frmMain.DefInstance.MailList2.FindItem(FindList.SelectedItem.ListSubItems(1).Text)
						LI.EnsureVisible()
						LI.Selected = True
						System.Windows.Forms.Application.DoEvents()
						'правельнее писать так
						If frmMain.DefInstance.MailList2.Visible Then
							frmMain.DefInstance.MailList2.Focus()
						End If
						System.Windows.Forms.Application.DoEvents()
						frmMain.DefInstance.MailList2_ClickEvent(frmMain.DefInstance.MailList2, New System.EventArgs())
						System.Windows.Forms.Application.DoEvents()
						
						If OldTxtFind = True Then
							frmMain.DefInstance.MailViewer.Find(OldFindText) 'Ищем теперь в тексте
						End If
				End Select
				Me.Close()
				System.Windows.Forms.Application.DoEvents()
				Exit For
			End If
		Next a
		'UPGRADE_NOTE: Object LI may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		LI = Nothing
	End Sub
	
	Private Sub cmdStopFind_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdStopFind.Click
		
		cmdStopFind.Enabled = False
		cmdBeginFind.Enabled = True
		System.Windows.Forms.Application.DoEvents()
		
		StopSearch()
		StatusBar1.Panels(1).Text = "Поиск приостановлен"
		System.Windows.Forms.Application.DoEvents()
		
	End Sub
	
	Private Sub cmdView_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdView.Click
		
		jbd2.DBName = FindList.SelectedItem.SubItems(2)
		jbd2.OpenDB()
		ViewMail(jbd2, FindList.SelectedItem.Tag, modCommon.ReplayMode.ViewMails)
		frmMailEditor.DefInstance.rtfMessage.SelStart = frmMailEditor.DefInstance.rtfMessage.Find(cboFind.Text)
		frmMailEditor.DefInstance.rtfMessage.SelLength = Len(cboFind.Text)
		frmMailEditor.DefInstance.rtfMessage.SelBold = True
		frmMailEditor.DefInstance.txtChangeFlag = False 'сбрасываем флаг, т.к. это просмотр
		'UPGRADE_NOTE: Object jbd2 may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		jbd2 = Nothing
		
	End Sub
	
	Private Sub frmFindDialog_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim a As Integer
		Dim EL As MSComctlLib.ListItem
		
		StartFindText = 0
		
		dx = VB6.TwipsPerPixelX
		dy = VB6.TwipsPerPixelY
		Me.Width = VB6.TwipsToPixelsX(MinFormWidth * dx)
		Me.Height = VB6.TwipsToPixelsY(MinFormHeight * dy)
		
		cmdGo.Enabled = False
		cmdView.Enabled = False
		
		chkAdvancedSearch.CheckState = System.Windows.Forms.CheckState.Unchecked
		opLogicSearch.Checked = True
		opRegExpSearch.Enabled = False
		opLogicSearch.Enabled = False
		
		
		
		For a = 1 To frmMain.DefInstance.EchoList.ListItems.Count
			cboEchos.Items.Add(frmMain.DefInstance.EchoList.ListItems(a).Text)
		Next a
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) \ 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) \ 2)
		Me.Show()
		
		EL = frmMain.DefInstance.EchoList.SelectedItem
		
		LoadTopSearchList()
		
		If frmMain.DefInstance.MailViewer.SelLength > 0 Then
			cboFind.Text = frmMain.DefInstance.MailViewer.SelText
			opCurrentMail.Checked = True
			StartFindText = frmMain.DefInstance.MailViewer.SelStart + frmMain.DefInstance.MailViewer.SelLength
			chkMessageFind.CheckState = System.Windows.Forms.CheckState.Checked
			chkGoToFirstFind.CheckState = System.Windows.Forms.CheckState.Checked
			If Not EL Is Nothing Then
				cboEchos.Text = EL.Text
			End If
		ElseIf Not EL Is Nothing Then 
			cboEchos.Text = EL.Text
			opCurrentEcho.Checked = True
		End If
		
		System.Windows.Forms.Application.DoEvents()
		
	End Sub
	
	Private Sub LoadTopSearchList()
		Dim a As Integer
		Dim sc As Integer
		Dim bs As String
		
		cboFind.Items.Clear()
		sc = CInt(GetGFEOption("Search\top", "count", "0"))
		For a = 1 To sc
			bs = GetGFEOption("Search\top", "s" & Str(a), "")
			If Len(bs) = 0 Then
				'Кто лазил в реестр?!
				Exit For
			End If
			cboFind.Items.Add((bs))
		Next a
		
		
	End Sub
	
	'UPGRADE_WARNING: Event frmFindDialog.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub frmFindDialog_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		CalcSize()
	End Sub
	
	Private Sub CalcSize()
		
		If Me.WindowState <> 1 Then
			If VB6.PixelsToTwipsX(Me.Width) < MinFormWidth * dx Then Me.Width = VB6.TwipsToPixelsX(MinFormWidth * dx)
			If VB6.PixelsToTwipsY(Me.Height) < MinFormHeight * dy Then
				Me.Height = VB6.TwipsToPixelsY(MinFormHeight * dy)
				frmFindList.Visible = False
			Else
				frmFindList.Visible = True
			End If
			
			frmOp1.Top = 0
			frmOp1.Left = 0
			frmOp1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmFindDialog.DefInstance.ClientRectangle.Width) - VB6.PixelsToTwipsX(cmdBeginFind.Width) - (brdButtonDX * dx * 2))
			
			cboFind.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmOp1.Width) - VB6.PixelsToTwipsX(Label1.Width) - (20 * dx))
			cboEchos.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmOp1.Width) - VB6.PixelsToTwipsX(Label1.Width) - (20 * dx))
			
			cmdBeginFind.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmFindDialog.DefInstance.ClientRectangle.Width) - VB6.PixelsToTwipsX(cmdBeginFind.Width) - (brdButtonDX * dx))
			cmdStopFind.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmFindDialog.DefInstance.ClientRectangle.Width) - VB6.PixelsToTwipsX(cmdBeginFind.Width) - (brdButtonDX * dx))
			
			
			If VB6.PixelsToTwipsY(frmFindDialog.DefInstance.ClientRectangle.Height) - VB6.PixelsToTwipsY(frmOp1.Height) - VB6.PixelsToTwipsY(StatusBar1.Height) - (5 * dy) > MinFindListHeight * dx Then
				frmFindList.Left = 0
				frmFindList.Top = frmOp1.Height
				frmFindList.Width = frmFindDialog.DefInstance.ClientRectangle.Width
				frmFindList.Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(frmFindDialog.DefInstance.ClientRectangle.Height) - VB6.PixelsToTwipsY(frmOp1.Height) - VB6.PixelsToTwipsY(StatusBar1.Height) - (5 * dy))
				
				FindList.Left = VB6.TwipsToPixelsX(frmBorder * dx)
				FindList.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(frmFindDialog.DefInstance.ClientRectangle.Width) - (frmBorder * dx * 2))
				
				FindList.Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(frmFindDialog.DefInstance.ClientRectangle.Height) - VB6.PixelsToTwipsY(frmOp1.Height) - VB6.PixelsToTwipsY(StatusBar1.Height) - (55 * dy))
				
				cmdGo.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(frmFindDialog.DefInstance.ClientRectangle.Height) - VB6.PixelsToTwipsY(frmOp1.Height) - VB6.PixelsToTwipsY(StatusBar1.Height) - (36 * dy))
				cmdView.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(frmFindDialog.DefInstance.ClientRectangle.Height) - VB6.PixelsToTwipsY(frmOp1.Height) - VB6.PixelsToTwipsY(StatusBar1.Height) - (36 * dy))
				cmdClose.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(frmFindDialog.DefInstance.ClientRectangle.Height) - VB6.PixelsToTwipsY(frmOp1.Height) - VB6.PixelsToTwipsY(StatusBar1.Height) - (36 * dy))
				
				cmdGo.Visible = True
				cmdView.Visible = True
				cmdClose.Visible = True
				FindList.Visible = True
				frmFindList.Visible = True
			Else
				cmdGo.Visible = False
				cmdView.Visible = False
				cmdClose.Visible = False
				
				FindList.Visible = False
				frmFindList.Visible = False
			End If
			
			ProgressBar1.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Height) - (dx * 20))
			
		End If
		System.Windows.Forms.Application.DoEvents()
		
	End Sub
	
	'UPGRADE_WARNING: Event opAllEchos.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub opAllEchos_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles opAllEchos.CheckedChanged
		If eventSender.Checked Then
			cboEchos.Enabled = False
			
			frmChecked.Enabled = True
			chkTheamFind.Enabled = True
			chkFromFind.Enabled = True
			chkToFind.Enabled = True
			chkMessageFind.Enabled = True
			
		End If
	End Sub
	
	'UPGRADE_WARNING: Event opCurrentEcho.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub opCurrentEcho_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles opCurrentEcho.CheckedChanged
		If eventSender.Checked Then
			cboEchos.Enabled = True
			
			frmChecked.Enabled = True
			chkTheamFind.Enabled = True
			chkFromFind.Enabled = True
			chkToFind.Enabled = True
			chkMessageFind.Enabled = True
			
		End If
	End Sub
	
	'UPGRADE_WARNING: Event opCurrentMail.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub opCurrentMail_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles opCurrentMail.CheckedChanged
		If eventSender.Checked Then
			
			cboEchos.Enabled = False
			
			frmChecked.Enabled = False
			chkTheamFind.Enabled = False
			chkFromFind.Enabled = False
			chkToFind.Enabled = False
			chkMessageFind.Enabled = False
			
		End If
	End Sub
End Class