Option Strict Off
Option Explicit On
Friend Class frmOptions
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
	Public WithEvents txtSignature As System.Windows.Forms.TextBox
	Public WithEvents txtTagLine As System.Windows.Forms.TextBox
	Public WithEvents txtTirLine As System.Windows.Forms.TextBox
	Public WithEvents lblSignature As System.Windows.Forms.Label
	Public WithEvents lblTagLine As System.Windows.Forms.Label
	Public WithEvents lblTirLine As System.Windows.Forms.Label
	Public WithEvents fraMsgFooter As System.Windows.Forms.GroupBox
	Public WithEvents txtMoved As System.Windows.Forms.TextBox
	Public WithEvents txtQuote As System.Windows.Forms.TextBox
	Public WithEvents txtChanged As System.Windows.Forms.TextBox
	Public WithEvents txtGreeting As System.Windows.Forms.TextBox
	Public WithEvents lblMoved As System.Windows.Forms.Label
	Public WithEvents lblQuote As System.Windows.Forms.Label
	Public WithEvents lblChanged As System.Windows.Forms.Label
	Public WithEvents lblGreeting As System.Windows.Forms.Label
	Public WithEvents fraMsgHeader As System.Windows.Forms.GroupBox
	Public WithEvents _op_9 As System.Windows.Forms.Panel
	Public WithEvents txtDragHKey As System.Windows.Forms.TextBox
	Public WithEvents cboHotKey As System.Windows.Forms.ComboBox
	Public WithEvents _txtKeyAction_0 As System.Windows.Forms.TextBox
	Public WithEvents _lblActions_0 As System.Windows.Forms.Label
	Public WithEvents fraKeyActions As System.Windows.Forms.GroupBox
	Public WithEvents lblHotkeySample As System.Windows.Forms.Label
	Public WithEvents lblAddHK As System.Windows.Forms.Label
	Public WithEvents fraHotkeys As System.Windows.Forms.GroupBox
	Public WithEvents _op_8 As System.Windows.Forms.Panel
	Public WithEvents _optStartupType_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optStartupType_1 As System.Windows.Forms.RadioButton
	Public WithEvents fraStartType As System.Windows.Forms.GroupBox
	Public WithEvents _cmdSelectProcess_0 As System.Windows.Forms.Button
	Public WithEvents txtExtProcess As System.Windows.Forms.TextBox
	Public WithEvents chkExtProcess As System.Windows.Forms.CheckBox
	Public WithEvents txtExtProcessParams As System.Windows.Forms.TextBox
	Public WithEvents lblParams As System.Windows.Forms.Label
	Public WithEvents fraExtProcess As System.Windows.Forms.GroupBox
	Public WithEvents _op_7 As System.Windows.Forms.Panel
	Public WithEvents txtExample As System.Windows.Forms.TextBox
	Public WithEvents lblExample As System.Windows.Forms.Label
	Public WithEvents fraExample As System.Windows.Forms.GroupBox
	Public WithEvents chkUptimeEnabled As System.Windows.Forms.CheckBox
	Public WithEvents chkNpEnabled As System.Windows.Forms.CheckBox
	Public WithEvents fraControlNp As System.Windows.Forms.GroupBox
	Public WithEvents txtNotLoading As System.Windows.Forms.TextBox
	Public WithEvents txtUptime As System.Windows.Forms.TextBox
	Public WithEvents txtStopped As System.Windows.Forms.TextBox
	Public WithEvents txtNpPrefix As System.Windows.Forms.TextBox
	Public WithEvents lblWinamp As System.Windows.Forms.Label
	Public WithEvents lblUptime As System.Windows.Forms.Label
	Public WithEvents lblStopped As System.Windows.Forms.Label
	Public WithEvents lblPrefix As System.Windows.Forms.Label
	Public WithEvents fraNp As System.Windows.Forms.GroupBox
	Public WithEvents _op_6 As System.Windows.Forms.Panel
	Public WithEvents _cmdSelectFont_6 As System.Windows.Forms.Button
	Public WithEvents _cmdSelectFont_5 As System.Windows.Forms.Button
	Public WithEvents _cmdSelectFont_4 As System.Windows.Forms.Button
	Public WithEvents _cmdSelectFont_3 As System.Windows.Forms.Button
	Public WithEvents _cmdSelectFont_2 As System.Windows.Forms.Button
	Public WithEvents _cmdSelectFont_1 As System.Windows.Forms.Button
	Public WithEvents _cmdSelectFont_0 As System.Windows.Forms.Button
	Public WithEvents lblSubjFont As System.Windows.Forms.Label
	Public WithEvents lblSubj As System.Windows.Forms.Label
	Public WithEvents lblToFont As System.Windows.Forms.Label
	Public WithEvents lblTO As System.Windows.Forms.Label
	Public WithEvents lblFromFont As System.Windows.Forms.Label
	Public WithEvents lblFrom As System.Windows.Forms.Label
	Public WithEvents lblEditorWindowFont As System.Windows.Forms.Label
	Public WithEvents lblEditorFont As System.Windows.Forms.Label
	Public WithEvents lblMainTextViewFont As System.Windows.Forms.Label
	Public WithEvents lblMainViewer As System.Windows.Forms.Label
	Public WithEvents lblTreeViewFont As System.Windows.Forms.Label
	Public WithEvents lblTreeFont As System.Windows.Forms.Label
	Public WithEvents lblEcholistFont As System.Windows.Forms.Label
	Public WithEvents lblEchoFont As System.Windows.Forms.Label
	Public WithEvents fraFonts As System.Windows.Forms.GroupBox
	Public WithEvents _op_5 As System.Windows.Forms.Panel
	Public WithEvents cmdAddSymbol As System.Windows.Forms.Button
	Public WithEvents cmdDelSymbol As System.Windows.Forms.Button
	Public WithEvents cmdEditSymbol As System.Windows.Forms.Button
	Public WithEvents fraReplacmentsButtons As System.Windows.Forms.GroupBox
	Public WithEvents lstReplacments As AxMSComctlLib.AxListView
	Public WithEvents fraReplacments As System.Windows.Forms.GroupBox
	Public WithEvents _op_4 As System.Windows.Forms.Panel
	Public WithEvents tabsImages As AxMSComctlLib.AxImageList
	Public WithEvents _chkFlags_0 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFlags_1 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFlags_2 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFlags_3 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFlags_4 As System.Windows.Forms.CheckBox
	Public WithEvents _chkFlags_5 As System.Windows.Forms.CheckBox
	Public WithEvents lvNetmailDirs As AxMSComctlLib.AxListView
	Public WithEvents _optNetmailPosition_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optNetmailPosition_0 As System.Windows.Forms.RadioButton
	Public WithEvents fraNetmailPosition As System.Windows.Forms.GroupBox
	Public WithEvents fraFlags As System.Windows.Forms.GroupBox
	Public WithEvents lblPathNm As System.Windows.Forms.Label
	Public WithEvents _op_3 As System.Windows.Forms.Panel
	Public WithEvents cmdAddColor As System.Windows.Forms.Button
	Public WithEvents cmdDelColor As System.Windows.Forms.Button
	Public WithEvents rtfSample As AxRichTextLib.AxRichTextBox
	Public WithEvents fraSemple As System.Windows.Forms.GroupBox
	Public WithEvents cboColorsSheme As System.Windows.Forms.ComboBox
	Public WithEvents fraColors As System.Windows.Forms.GroupBox
	Public WithEvents cmdMyMsgs As System.Windows.Forms.Button
	Public WithEvents cmdRules As System.Windows.Forms.Button
	Public WithEvents cmdModerator As System.Windows.Forms.Button
	Public WithEvents lblMyMsgs As System.Windows.Forms.Label
	Public WithEvents lblMsgModeraror As System.Windows.Forms.Label
	Public WithEvents lblRules As System.Windows.Forms.Label
	Public WithEvents _fraMsgColors_0 As System.Windows.Forms.GroupBox
	Public WithEvents cmdOriginColor As System.Windows.Forms.Button
	Public WithEvents cmdTirlineColor As System.Windows.Forms.Button
	Public WithEvents cmdTaglineColor As System.Windows.Forms.Button
	Public WithEvents cmdAlienCitat As System.Windows.Forms.Button
	Public WithEvents cmdMyCitat As System.Windows.Forms.Button
	Public WithEvents cmdMainText As System.Windows.Forms.Button
	Public WithEvents cmdBackMessageColor As System.Windows.Forms.Button
	Public WithEvents lblOriginColor As System.Windows.Forms.Label
	Public WithEvents lblTirlineColor As System.Windows.Forms.Label
	Public WithEvents lblTaglineColor As System.Windows.Forms.Label
	Public WithEvents lblMainText As System.Windows.Forms.Label
	Public WithEvents lblMyCitat As System.Windows.Forms.Label
	Public WithEvents lblAlienCitat As System.Windows.Forms.Label
	Public WithEvents lblBackMessageColor As System.Windows.Forms.Label
	Public WithEvents _fraMsgColors_1 As System.Windows.Forms.GroupBox
	Public WithEvents _op_2 As System.Windows.Forms.Panel
	Public WithEvents _optTosser_0 As System.Windows.Forms.RadioButton
	Public WithEvents fraTosser As System.Windows.Forms.GroupBox
	Public WithEvents cmdSelectBase As System.Windows.Forms.Button
	Public WithEvents txtBasePath As System.Windows.Forms.TextBox
	Public WithEvents fraBase As System.Windows.Forms.GroupBox
	Public WithEvents _cmdDel_1 As System.Windows.Forms.Button
	Public WithEvents _cmdDel_0 As System.Windows.Forms.Button
	Public WithEvents _cmdAdd_1 As System.Windows.Forms.Button
	Public WithEvents _cmdAdd_0 As System.Windows.Forms.Button
	Public WithEvents cmdSelectSemaphore As System.Windows.Forms.Button
	Public WithEvents txtSemaphore As System.Windows.Forms.TextBox
	Public WithEvents cboAkAs As System.Windows.Forms.ComboBox
	Public WithEvents cboNames As System.Windows.Forms.ComboBox
	Public WithEvents txtMainAddress As System.Windows.Forms.TextBox
	Public WithEvents lblSemaphore As System.Windows.Forms.Label
	Public WithEvents lblAkAs As System.Windows.Forms.Label
	Public WithEvents lblAddress As System.Windows.Forms.Label
	Public WithEvents lblName As System.Windows.Forms.Label
	Public WithEvents fraMainSetup As System.Windows.Forms.GroupBox
	Public WithEvents _op_1 As System.Windows.Forms.Panel
	Public WithEvents opTabStrip As AxMSComctlLib.AxTabStrip
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdApply As System.Windows.Forms.Button
	Public WithEvents cmdImportConfig As System.Windows.Forms.Button
	Public WithEvents chkFlags As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents cmdAdd As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents cmdDel As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents cmdSelectFont As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents cmdSelectProcess As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents fraMsgColors As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
	Public WithEvents lblActions As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents op As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	Public WithEvents optNetmailPosition As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents optStartupType As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents optTosser As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents txtKeyAction As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents mnuPopupNetmailAdd As System.Windows.Forms.MenuItem
	Public WithEvents mnuPopupNetmailChange As System.Windows.Forms.MenuItem
	Public WithEvents mnuPopupNetmailDelete As System.Windows.Forms.MenuItem
	Public WithEvents mnuPopupNetmail As System.Windows.Forms.MenuItem
	Public MainMenu1 As System.Windows.Forms.MainMenu
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmOptions))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me._op_9 = New System.Windows.Forms.Panel
		Me.fraMsgFooter = New System.Windows.Forms.GroupBox
		Me.txtSignature = New System.Windows.Forms.TextBox
		Me.txtTagLine = New System.Windows.Forms.TextBox
		Me.txtTirLine = New System.Windows.Forms.TextBox
		Me.lblSignature = New System.Windows.Forms.Label
		Me.lblTagLine = New System.Windows.Forms.Label
		Me.lblTirLine = New System.Windows.Forms.Label
		Me.fraMsgHeader = New System.Windows.Forms.GroupBox
		Me.txtMoved = New System.Windows.Forms.TextBox
		Me.txtQuote = New System.Windows.Forms.TextBox
		Me.txtChanged = New System.Windows.Forms.TextBox
		Me.txtGreeting = New System.Windows.Forms.TextBox
		Me.lblMoved = New System.Windows.Forms.Label
		Me.lblQuote = New System.Windows.Forms.Label
		Me.lblChanged = New System.Windows.Forms.Label
		Me.lblGreeting = New System.Windows.Forms.Label
		Me._op_8 = New System.Windows.Forms.Panel
		Me.fraHotkeys = New System.Windows.Forms.GroupBox
		Me.txtDragHKey = New System.Windows.Forms.TextBox
		Me.cboHotKey = New System.Windows.Forms.ComboBox
		Me.fraKeyActions = New System.Windows.Forms.GroupBox
		Me._txtKeyAction_0 = New System.Windows.Forms.TextBox
		Me._lblActions_0 = New System.Windows.Forms.Label
		Me.lblHotkeySample = New System.Windows.Forms.Label
		Me.lblAddHK = New System.Windows.Forms.Label
		Me._op_7 = New System.Windows.Forms.Panel
		Me._optStartupType_0 = New System.Windows.Forms.RadioButton
		Me._optStartupType_1 = New System.Windows.Forms.RadioButton
		Me.fraExtProcess = New System.Windows.Forms.GroupBox
		Me.fraStartType = New System.Windows.Forms.GroupBox
		Me._cmdSelectProcess_0 = New System.Windows.Forms.Button
		Me.txtExtProcess = New System.Windows.Forms.TextBox
		Me.chkExtProcess = New System.Windows.Forms.CheckBox
		Me.txtExtProcessParams = New System.Windows.Forms.TextBox
		Me.lblParams = New System.Windows.Forms.Label
		Me._op_6 = New System.Windows.Forms.Panel
		Me.fraNp = New System.Windows.Forms.GroupBox
		Me.fraExample = New System.Windows.Forms.GroupBox
		Me.txtExample = New System.Windows.Forms.TextBox
		Me.lblExample = New System.Windows.Forms.Label
		Me.fraControlNp = New System.Windows.Forms.GroupBox
		Me.chkUptimeEnabled = New System.Windows.Forms.CheckBox
		Me.chkNpEnabled = New System.Windows.Forms.CheckBox
		Me.txtNotLoading = New System.Windows.Forms.TextBox
		Me.txtUptime = New System.Windows.Forms.TextBox
		Me.txtStopped = New System.Windows.Forms.TextBox
		Me.txtNpPrefix = New System.Windows.Forms.TextBox
		Me.lblWinamp = New System.Windows.Forms.Label
		Me.lblUptime = New System.Windows.Forms.Label
		Me.lblStopped = New System.Windows.Forms.Label
		Me.lblPrefix = New System.Windows.Forms.Label
		Me._op_5 = New System.Windows.Forms.Panel
		Me._cmdSelectFont_6 = New System.Windows.Forms.Button
		Me._cmdSelectFont_5 = New System.Windows.Forms.Button
		Me._cmdSelectFont_4 = New System.Windows.Forms.Button
		Me._cmdSelectFont_3 = New System.Windows.Forms.Button
		Me._cmdSelectFont_2 = New System.Windows.Forms.Button
		Me._cmdSelectFont_1 = New System.Windows.Forms.Button
		Me._cmdSelectFont_0 = New System.Windows.Forms.Button
		Me.fraFonts = New System.Windows.Forms.GroupBox
		Me.lblSubjFont = New System.Windows.Forms.Label
		Me.lblSubj = New System.Windows.Forms.Label
		Me.lblToFont = New System.Windows.Forms.Label
		Me.lblTO = New System.Windows.Forms.Label
		Me.lblFromFont = New System.Windows.Forms.Label
		Me.lblFrom = New System.Windows.Forms.Label
		Me.lblEditorWindowFont = New System.Windows.Forms.Label
		Me.lblEditorFont = New System.Windows.Forms.Label
		Me.lblMainTextViewFont = New System.Windows.Forms.Label
		Me.lblMainViewer = New System.Windows.Forms.Label
		Me.lblTreeViewFont = New System.Windows.Forms.Label
		Me.lblTreeFont = New System.Windows.Forms.Label
		Me.lblEcholistFont = New System.Windows.Forms.Label
		Me.lblEchoFont = New System.Windows.Forms.Label
		Me._op_4 = New System.Windows.Forms.Panel
		Me.fraReplacmentsButtons = New System.Windows.Forms.GroupBox
		Me.cmdAddSymbol = New System.Windows.Forms.Button
		Me.cmdDelSymbol = New System.Windows.Forms.Button
		Me.cmdEditSymbol = New System.Windows.Forms.Button
		Me.fraReplacments = New System.Windows.Forms.GroupBox
		Me.lstReplacments = New AxMSComctlLib.AxListView
		Me.tabsImages = New AxMSComctlLib.AxImageList
		Me._op_3 = New System.Windows.Forms.Panel
		Me._chkFlags_0 = New System.Windows.Forms.CheckBox
		Me._chkFlags_1 = New System.Windows.Forms.CheckBox
		Me._chkFlags_2 = New System.Windows.Forms.CheckBox
		Me._chkFlags_3 = New System.Windows.Forms.CheckBox
		Me._chkFlags_4 = New System.Windows.Forms.CheckBox
		Me._chkFlags_5 = New System.Windows.Forms.CheckBox
		Me.lvNetmailDirs = New AxMSComctlLib.AxListView
		Me._optNetmailPosition_1 = New System.Windows.Forms.RadioButton
		Me._optNetmailPosition_0 = New System.Windows.Forms.RadioButton
		Me.fraNetmailPosition = New System.Windows.Forms.GroupBox
		Me.fraFlags = New System.Windows.Forms.GroupBox
		Me.lblPathNm = New System.Windows.Forms.Label
		Me._op_2 = New System.Windows.Forms.Panel
		Me.cmdAddColor = New System.Windows.Forms.Button
		Me.cmdDelColor = New System.Windows.Forms.Button
		Me.fraSemple = New System.Windows.Forms.GroupBox
		Me.rtfSample = New AxRichTextLib.AxRichTextBox
		Me.fraColors = New System.Windows.Forms.GroupBox
		Me.cboColorsSheme = New System.Windows.Forms.ComboBox
		Me._fraMsgColors_0 = New System.Windows.Forms.GroupBox
		Me.cmdMyMsgs = New System.Windows.Forms.Button
		Me.cmdRules = New System.Windows.Forms.Button
		Me.cmdModerator = New System.Windows.Forms.Button
		Me.lblMyMsgs = New System.Windows.Forms.Label
		Me.lblMsgModeraror = New System.Windows.Forms.Label
		Me.lblRules = New System.Windows.Forms.Label
		Me._fraMsgColors_1 = New System.Windows.Forms.GroupBox
		Me.cmdOriginColor = New System.Windows.Forms.Button
		Me.cmdTirlineColor = New System.Windows.Forms.Button
		Me.cmdTaglineColor = New System.Windows.Forms.Button
		Me.cmdAlienCitat = New System.Windows.Forms.Button
		Me.cmdMyCitat = New System.Windows.Forms.Button
		Me.cmdMainText = New System.Windows.Forms.Button
		Me.cmdBackMessageColor = New System.Windows.Forms.Button
		Me.lblOriginColor = New System.Windows.Forms.Label
		Me.lblTirlineColor = New System.Windows.Forms.Label
		Me.lblTaglineColor = New System.Windows.Forms.Label
		Me.lblMainText = New System.Windows.Forms.Label
		Me.lblMyCitat = New System.Windows.Forms.Label
		Me.lblAlienCitat = New System.Windows.Forms.Label
		Me.lblBackMessageColor = New System.Windows.Forms.Label
		Me._op_1 = New System.Windows.Forms.Panel
		Me._optTosser_0 = New System.Windows.Forms.RadioButton
		Me.fraTosser = New System.Windows.Forms.GroupBox
		Me.fraBase = New System.Windows.Forms.GroupBox
		Me.cmdSelectBase = New System.Windows.Forms.Button
		Me.txtBasePath = New System.Windows.Forms.TextBox
		Me.fraMainSetup = New System.Windows.Forms.GroupBox
		Me._cmdDel_1 = New System.Windows.Forms.Button
		Me._cmdDel_0 = New System.Windows.Forms.Button
		Me._cmdAdd_1 = New System.Windows.Forms.Button
		Me._cmdAdd_0 = New System.Windows.Forms.Button
		Me.cmdSelectSemaphore = New System.Windows.Forms.Button
		Me.txtSemaphore = New System.Windows.Forms.TextBox
		Me.cboAkAs = New System.Windows.Forms.ComboBox
		Me.cboNames = New System.Windows.Forms.ComboBox
		Me.txtMainAddress = New System.Windows.Forms.TextBox
		Me.lblSemaphore = New System.Windows.Forms.Label
		Me.lblAkAs = New System.Windows.Forms.Label
		Me.lblAddress = New System.Windows.Forms.Label
		Me.lblName = New System.Windows.Forms.Label
		Me.opTabStrip = New AxMSComctlLib.AxTabStrip
		Me.cmdOK = New System.Windows.Forms.Button
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdApply = New System.Windows.Forms.Button
		Me.cmdImportConfig = New System.Windows.Forms.Button
		Me.chkFlags = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(components)
		Me.cmdAdd = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.cmdDel = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.cmdSelectFont = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.cmdSelectProcess = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.fraMsgColors = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(components)
		Me.lblActions = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.op = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(components)
		Me.optNetmailPosition = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.optStartupType = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.optTosser = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.txtKeyAction = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.MainMenu1 = New System.Windows.Forms.MainMenu
		Me.mnuPopupNetmail = New System.Windows.Forms.MenuItem
		Me.mnuPopupNetmailAdd = New System.Windows.Forms.MenuItem
		Me.mnuPopupNetmailChange = New System.Windows.Forms.MenuItem
		Me.mnuPopupNetmailDelete = New System.Windows.Forms.MenuItem
		CType(Me.lstReplacments, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.tabsImages, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lvNetmailDirs, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.rtfSample, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.opTabStrip, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.chkFlags, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdAdd, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdDel, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdSelectFont, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdSelectProcess, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.fraMsgColors, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lblActions, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.op, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optNetmailPosition, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optStartupType, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optTosser, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtKeyAction, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Настройки"
		Me.ClientSize = New System.Drawing.Size(511, 313)
		Me.Location = New System.Drawing.Point(-13, -24)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmOptions"
		Me._op_9.Size = New System.Drawing.Size(479, 213)
		Me._op_9.Location = New System.Drawing.Point(16, 56)
		Me._op_9.TabIndex = 125
		Me._op_9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._op_9.Dock = System.Windows.Forms.DockStyle.None
		Me._op_9.BackColor = System.Drawing.SystemColors.Control
		Me._op_9.CausesValidation = True
		Me._op_9.Enabled = True
		Me._op_9.ForeColor = System.Drawing.SystemColors.ControlText
		Me._op_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._op_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._op_9.TabStop = True
		Me._op_9.Visible = True
		Me._op_9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._op_9.Name = "_op_9"
		Me.fraMsgFooter.Text = "Низ"
		Me.fraMsgFooter.Size = New System.Drawing.Size(473, 89)
		Me.fraMsgFooter.Location = New System.Drawing.Point(0, 120)
		Me.fraMsgFooter.TabIndex = 127
		Me.fraMsgFooter.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraMsgFooter.BackColor = System.Drawing.SystemColors.Control
		Me.fraMsgFooter.Enabled = True
		Me.fraMsgFooter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraMsgFooter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraMsgFooter.Visible = True
		Me.fraMsgFooter.Name = "fraMsgFooter"
		Me.txtSignature.AutoSize = False
		Me.txtSignature.Size = New System.Drawing.Size(409, 19)
		Me.txtSignature.Location = New System.Drawing.Point(56, 16)
		Me.txtSignature.TabIndex = 139
		Me.txtSignature.Text = "Пока,@TFName!!! С вами был,есть и будет:@CName"
		Me.ToolTip1.SetToolTip(Me.txtSignature, "Подпись сообщения")
		Me.txtSignature.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSignature.AcceptsReturn = True
		Me.txtSignature.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSignature.BackColor = System.Drawing.SystemColors.Window
		Me.txtSignature.CausesValidation = True
		Me.txtSignature.Enabled = True
		Me.txtSignature.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSignature.HideSelection = True
		Me.txtSignature.ReadOnly = False
		Me.txtSignature.Maxlength = 0
		Me.txtSignature.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSignature.MultiLine = False
		Me.txtSignature.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSignature.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSignature.TabStop = True
		Me.txtSignature.Visible = True
		Me.txtSignature.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSignature.Name = "txtSignature"
		Me.txtTagLine.AutoSize = False
		Me.txtTagLine.Size = New System.Drawing.Size(409, 19)
		Me.txtTagLine.Location = New System.Drawing.Point(56, 64)
		Me.txtTagLine.TabIndex = 131
		Me.txtTagLine.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTagLine.AcceptsReturn = True
		Me.txtTagLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTagLine.BackColor = System.Drawing.SystemColors.Window
		Me.txtTagLine.CausesValidation = True
		Me.txtTagLine.Enabled = True
		Me.txtTagLine.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTagLine.HideSelection = True
		Me.txtTagLine.ReadOnly = False
		Me.txtTagLine.Maxlength = 0
		Me.txtTagLine.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTagLine.MultiLine = False
		Me.txtTagLine.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTagLine.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTagLine.TabStop = True
		Me.txtTagLine.Visible = True
		Me.txtTagLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTagLine.Name = "txtTagLine"
		Me.txtTirLine.AutoSize = False
		Me.txtTirLine.Size = New System.Drawing.Size(409, 19)
		Me.txtTirLine.Location = New System.Drawing.Point(56, 40)
		Me.txtTirLine.Maxlength = 73
		Me.txtTirLine.TabIndex = 129
		Me.txtTirLine.Text = "GoldFidoExplorer (http://gfe.h10.ru/)"
		Me.txtTirLine.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTirLine.AcceptsReturn = True
		Me.txtTirLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTirLine.BackColor = System.Drawing.SystemColors.Window
		Me.txtTirLine.CausesValidation = True
		Me.txtTirLine.Enabled = True
		Me.txtTirLine.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTirLine.HideSelection = True
		Me.txtTirLine.ReadOnly = False
		Me.txtTirLine.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTirLine.MultiLine = False
		Me.txtTirLine.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTirLine.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTirLine.TabStop = True
		Me.txtTirLine.Visible = True
		Me.txtTirLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTirLine.Name = "txtTirLine"
		Me.lblSignature.Text = "Подпись:"
		Me.lblSignature.Size = New System.Drawing.Size(47, 13)
		Me.lblSignature.Location = New System.Drawing.Point(8, 16)
		Me.lblSignature.TabIndex = 138
		Me.lblSignature.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSignature.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSignature.BackColor = System.Drawing.SystemColors.Control
		Me.lblSignature.Enabled = True
		Me.lblSignature.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSignature.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSignature.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSignature.UseMnemonic = True
		Me.lblSignature.Visible = True
		Me.lblSignature.AutoSize = True
		Me.lblSignature.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSignature.Name = "lblSignature"
		Me.lblTagLine.Text = "Таглайн:"
		Me.lblTagLine.Size = New System.Drawing.Size(45, 13)
		Me.lblTagLine.Location = New System.Drawing.Point(8, 64)
		Me.lblTagLine.TabIndex = 130
		Me.lblTagLine.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTagLine.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTagLine.BackColor = System.Drawing.SystemColors.Control
		Me.lblTagLine.Enabled = True
		Me.lblTagLine.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTagLine.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTagLine.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTagLine.UseMnemonic = True
		Me.lblTagLine.Visible = True
		Me.lblTagLine.AutoSize = True
		Me.lblTagLine.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTagLine.Name = "lblTagLine"
		Me.lblTirLine.Text = "Тирлайн:"
		Me.lblTirLine.Size = New System.Drawing.Size(46, 13)
		Me.lblTirLine.Location = New System.Drawing.Point(8, 40)
		Me.lblTirLine.TabIndex = 128
		Me.lblTirLine.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTirLine.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTirLine.BackColor = System.Drawing.SystemColors.Control
		Me.lblTirLine.Enabled = True
		Me.lblTirLine.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTirLine.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTirLine.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTirLine.UseMnemonic = True
		Me.lblTirLine.Visible = True
		Me.lblTirLine.AutoSize = True
		Me.lblTirLine.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTirLine.Name = "lblTirLine"
		Me.fraMsgHeader.Text = "Верх"
		Me.fraMsgHeader.Size = New System.Drawing.Size(473, 113)
		Me.fraMsgHeader.Location = New System.Drawing.Point(0, 0)
		Me.fraMsgHeader.TabIndex = 126
		Me.fraMsgHeader.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraMsgHeader.BackColor = System.Drawing.SystemColors.Control
		Me.fraMsgHeader.Enabled = True
		Me.fraMsgHeader.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraMsgHeader.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraMsgHeader.Visible = True
		Me.fraMsgHeader.Name = "fraMsgHeader"
		Me.txtMoved.AutoSize = False
		Me.txtMoved.Size = New System.Drawing.Size(385, 19)
		Me.txtMoved.Location = New System.Drawing.Point(80, 88)
		Me.txtMoved.TabIndex = 141
		Me.txtMoved.Text = "*** Ответ на мессагу закинутую и зачитанную до битиков в арию @OEcho "
		Me.txtMoved.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMoved.AcceptsReturn = True
		Me.txtMoved.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMoved.BackColor = System.Drawing.SystemColors.Window
		Me.txtMoved.CausesValidation = True
		Me.txtMoved.Enabled = True
		Me.txtMoved.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMoved.HideSelection = True
		Me.txtMoved.ReadOnly = False
		Me.txtMoved.Maxlength = 0
		Me.txtMoved.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMoved.MultiLine = False
		Me.txtMoved.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMoved.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMoved.TabStop = True
		Me.txtMoved.Visible = True
		Me.txtMoved.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMoved.Name = "txtMoved"
		Me.txtQuote.AutoSize = False
		Me.txtQuote.Size = New System.Drawing.Size(385, 19)
		Me.txtQuote.Location = New System.Drawing.Point(80, 64)
		Me.txtQuote.TabIndex = 137
		Me.txtQuote.Text = "Стучал как-то по клаве некто @OName и достучался он до @DName:"
		Me.txtQuote.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtQuote.AcceptsReturn = True
		Me.txtQuote.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtQuote.BackColor = System.Drawing.SystemColors.Window
		Me.txtQuote.CausesValidation = True
		Me.txtQuote.Enabled = True
		Me.txtQuote.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtQuote.HideSelection = True
		Me.txtQuote.ReadOnly = False
		Me.txtQuote.Maxlength = 0
		Me.txtQuote.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtQuote.MultiLine = False
		Me.txtQuote.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtQuote.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtQuote.TabStop = True
		Me.txtQuote.Visible = True
		Me.txtQuote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtQuote.Name = "txtQuote"
		Me.txtChanged.AutoSize = False
		Me.txtChanged.Size = New System.Drawing.Size(385, 19)
		Me.txtChanged.Location = New System.Drawing.Point(80, 40)
		Me.txtChanged.TabIndex = 135
		Me.txtChanged.Text = "*** Изменено непреднамеренно @CName ***"
		Me.ToolTip1.SetToolTip(Me.txtChanged, "Вставляется при изменении письма (Макрос @CName - Имя того кто изменяет)")
		Me.txtChanged.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtChanged.AcceptsReturn = True
		Me.txtChanged.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtChanged.BackColor = System.Drawing.SystemColors.Window
		Me.txtChanged.CausesValidation = True
		Me.txtChanged.Enabled = True
		Me.txtChanged.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtChanged.HideSelection = True
		Me.txtChanged.ReadOnly = False
		Me.txtChanged.Maxlength = 0
		Me.txtChanged.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtChanged.MultiLine = False
		Me.txtChanged.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtChanged.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtChanged.TabStop = True
		Me.txtChanged.Visible = True
		Me.txtChanged.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtChanged.Name = "txtChanged"
		Me.txtGreeting.AutoSize = False
		Me.txtGreeting.Size = New System.Drawing.Size(385, 19)
		Me.txtGreeting.Location = New System.Drawing.Point(80, 16)
		Me.txtGreeting.Maxlength = 255
		Me.txtGreeting.TabIndex = 133
		Me.txtGreeting.Text = "Glad To Read You, @TFName !"
		Me.ToolTip1.SetToolTip(Me.txtGreeting, "Текст приветствия. (Макрос @TFName - имя получателя письма)")
		Me.txtGreeting.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGreeting.AcceptsReturn = True
		Me.txtGreeting.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtGreeting.BackColor = System.Drawing.SystemColors.Window
		Me.txtGreeting.CausesValidation = True
		Me.txtGreeting.Enabled = True
		Me.txtGreeting.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtGreeting.HideSelection = True
		Me.txtGreeting.ReadOnly = False
		Me.txtGreeting.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtGreeting.MultiLine = False
		Me.txtGreeting.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtGreeting.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtGreeting.TabStop = True
		Me.txtGreeting.Visible = True
		Me.txtGreeting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtGreeting.Name = "txtGreeting"
		Me.lblMoved.Text = "Перемещение:"
		Me.lblMoved.Size = New System.Drawing.Size(76, 13)
		Me.lblMoved.Location = New System.Drawing.Point(0, 88)
		Me.lblMoved.TabIndex = 140
		Me.lblMoved.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMoved.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMoved.BackColor = System.Drawing.Color.Transparent
		Me.lblMoved.Enabled = True
		Me.lblMoved.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMoved.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMoved.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMoved.UseMnemonic = True
		Me.lblMoved.Visible = True
		Me.lblMoved.AutoSize = True
		Me.lblMoved.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMoved.Name = "lblMoved"
		Me.lblQuote.Text = "Цитирование:"
		Me.lblQuote.Size = New System.Drawing.Size(70, 13)
		Me.lblQuote.Location = New System.Drawing.Point(8, 64)
		Me.lblQuote.TabIndex = 136
		Me.lblQuote.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblQuote.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblQuote.BackColor = System.Drawing.SystemColors.Control
		Me.lblQuote.Enabled = True
		Me.lblQuote.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblQuote.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblQuote.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblQuote.UseMnemonic = True
		Me.lblQuote.Visible = True
		Me.lblQuote.AutoSize = True
		Me.lblQuote.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblQuote.Name = "lblQuote"
		Me.lblChanged.Text = "Изменение:"
		Me.lblChanged.Size = New System.Drawing.Size(61, 13)
		Me.lblChanged.Location = New System.Drawing.Point(16, 40)
		Me.lblChanged.TabIndex = 134
		Me.lblChanged.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblChanged.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblChanged.BackColor = System.Drawing.SystemColors.Control
		Me.lblChanged.Enabled = True
		Me.lblChanged.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblChanged.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblChanged.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblChanged.UseMnemonic = True
		Me.lblChanged.Visible = True
		Me.lblChanged.AutoSize = True
		Me.lblChanged.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblChanged.Name = "lblChanged"
		Me.lblGreeting.Text = "Приветствие:"
		Me.lblGreeting.Size = New System.Drawing.Size(69, 13)
		Me.lblGreeting.Location = New System.Drawing.Point(8, 16)
		Me.lblGreeting.TabIndex = 132
		Me.lblGreeting.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGreeting.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblGreeting.BackColor = System.Drawing.SystemColors.Control
		Me.lblGreeting.Enabled = True
		Me.lblGreeting.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblGreeting.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblGreeting.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblGreeting.UseMnemonic = True
		Me.lblGreeting.Visible = True
		Me.lblGreeting.AutoSize = True
		Me.lblGreeting.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblGreeting.Name = "lblGreeting"
		Me._op_8.Size = New System.Drawing.Size(479, 213)
		Me._op_8.Location = New System.Drawing.Point(16, 56)
		Me._op_8.TabIndex = 110
		Me._op_8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._op_8.Dock = System.Windows.Forms.DockStyle.None
		Me._op_8.BackColor = System.Drawing.SystemColors.Control
		Me._op_8.CausesValidation = True
		Me._op_8.Enabled = True
		Me._op_8.ForeColor = System.Drawing.SystemColors.ControlText
		Me._op_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._op_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._op_8.TabStop = True
		Me._op_8.Visible = True
		Me._op_8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._op_8.Name = "_op_8"
		Me.fraHotkeys.Size = New System.Drawing.Size(475, 207)
		Me.fraHotkeys.Location = New System.Drawing.Point(0, 0)
		Me.fraHotkeys.TabIndex = 111
		Me.fraHotkeys.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraHotkeys.BackColor = System.Drawing.SystemColors.Control
		Me.fraHotkeys.Enabled = True
		Me.fraHotkeys.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraHotkeys.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraHotkeys.Visible = True
		Me.fraHotkeys.Name = "fraHotkeys"
		Me.txtDragHKey.AutoSize = False
		Me.txtDragHKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtDragHKey.BackColor = System.Drawing.SystemColors.Control
		Me.txtDragHKey.Size = New System.Drawing.Size(55, 19)
		Me.txtDragHKey.Location = New System.Drawing.Point(400, 54)
		Me.txtDragHKey.ReadOnly = True
		Me.txtDragHKey.TabIndex = 114
		Me.txtDragHKey.Text = "Drag"
		Me.ToolTip1.SetToolTip(Me.txtDragHKey, "Перетащите сочетание клавиш в соседнюю область.")
		Me.txtDragHKey.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDragHKey.AcceptsReturn = True
		Me.txtDragHKey.CausesValidation = True
		Me.txtDragHKey.Enabled = True
		Me.txtDragHKey.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDragHKey.HideSelection = True
		Me.txtDragHKey.Maxlength = 0
		Me.txtDragHKey.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDragHKey.MultiLine = False
		Me.txtDragHKey.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDragHKey.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDragHKey.TabStop = True
		Me.txtDragHKey.Visible = True
		Me.txtDragHKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtDragHKey.Name = "txtDragHKey"
		Me.cboHotKey.Size = New System.Drawing.Size(91, 21)
		Me.cboHotKey.Location = New System.Drawing.Point(368, 18)
		Me.cboHotKey.Items.AddRange(New Object(){"Ctrl + 0", "Ctrl + 1", "Ctrl + 2", "Ctrl + 3", "Ctrl + 4", "Ctrl + 5", "Ctrl + 6", "Ctrl + 7", "Ctrl + 8", "Ctrl + 9"})
		Me.cboHotKey.TabIndex = 113
		Me.ToolTip1.SetToolTip(Me.cboHotKey, "Выберете сочетание и перетащите его в соседнюю область.")
		Me.cboHotKey.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboHotKey.BackColor = System.Drawing.SystemColors.Window
		Me.cboHotKey.CausesValidation = True
		Me.cboHotKey.Enabled = True
		Me.cboHotKey.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboHotKey.IntegralHeight = True
		Me.cboHotKey.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboHotKey.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboHotKey.Sorted = False
		Me.cboHotKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboHotKey.TabStop = True
		Me.cboHotKey.Visible = True
		Me.cboHotKey.Name = "cboHotKey"
		Me.fraKeyActions.Size = New System.Drawing.Size(331, 183)
		Me.fraKeyActions.Location = New System.Drawing.Point(12, 12)
		Me.fraKeyActions.TabIndex = 112
		Me.ToolTip1.SetToolTip(Me.fraKeyActions, "Перетащите сюда сочетание клавиш для исспользования в редакторе.")
		Me.fraKeyActions.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraKeyActions.BackColor = System.Drawing.SystemColors.Control
		Me.fraKeyActions.Enabled = True
		Me.fraKeyActions.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraKeyActions.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraKeyActions.Visible = True
		Me.fraKeyActions.Name = "fraKeyActions"
		Me._txtKeyAction_0.AutoSize = False
		Me._txtKeyAction_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtKeyAction_0.Size = New System.Drawing.Size(103, 19)
		Me._txtKeyAction_0.Location = New System.Drawing.Point(42, 12)
		Me._txtKeyAction_0.TabIndex = 117
		Me.ToolTip1.SetToolTip(Me._txtKeyAction_0, "Текст который будет вставлен в редакторе по данному сочетанию клавиш.")
		Me._txtKeyAction_0.Visible = False
		Me._txtKeyAction_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtKeyAction_0.AcceptsReturn = True
		Me._txtKeyAction_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtKeyAction_0.CausesValidation = True
		Me._txtKeyAction_0.Enabled = True
		Me._txtKeyAction_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtKeyAction_0.HideSelection = True
		Me._txtKeyAction_0.ReadOnly = False
		Me._txtKeyAction_0.Maxlength = 0
		Me._txtKeyAction_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtKeyAction_0.MultiLine = False
		Me._txtKeyAction_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtKeyAction_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtKeyAction_0.TabStop = True
		Me._txtKeyAction_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtKeyAction_0.Name = "_txtKeyAction_0"
		Me._lblActions_0.Text = "Ctrl + x"
		Me._lblActions_0.Size = New System.Drawing.Size(32, 13)
		Me._lblActions_0.Location = New System.Drawing.Point(6, 12)
		Me._lblActions_0.TabIndex = 116
		Me.ToolTip1.SetToolTip(Me._lblActions_0, "Для удаления  данного сочетания кликните правой кнопкой.")
		Me._lblActions_0.Visible = False
		Me._lblActions_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._lblActions_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._lblActions_0.BackColor = System.Drawing.SystemColors.Control
		Me._lblActions_0.Enabled = True
		Me._lblActions_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._lblActions_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._lblActions_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._lblActions_0.UseMnemonic = True
		Me._lblActions_0.AutoSize = True
		Me._lblActions_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._lblActions_0.Name = "_lblActions_0"
		Me.lblHotkeySample.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblHotkeySample.Text = "Подсказка: для удаления сочетания кликните правой кнопрой мыши на сочетании."
		Me.lblHotkeySample.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblHotkeySample.Size = New System.Drawing.Size(115, 93)
		Me.lblHotkeySample.Location = New System.Drawing.Point(354, 104)
		Me.lblHotkeySample.TabIndex = 118
		Me.lblHotkeySample.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHotkeySample.BackColor = System.Drawing.SystemColors.Control
		Me.lblHotkeySample.Enabled = True
		Me.lblHotkeySample.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblHotkeySample.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblHotkeySample.UseMnemonic = True
		Me.lblHotkeySample.Visible = True
		Me.lblHotkeySample.AutoSize = False
		Me.lblHotkeySample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblHotkeySample.Name = "lblHotkeySample"
		Me.lblAddHK.Text = "<--"
		Me.lblAddHK.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.lblAddHK.Size = New System.Drawing.Size(27, 18)
		Me.lblAddHK.Location = New System.Drawing.Point(368, 54)
		Me.lblAddHK.TabIndex = 115
		Me.ToolTip1.SetToolTip(Me.lblAddHK, "Перетащите сочетание клавиш в соседнюю область.")
		Me.lblAddHK.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAddHK.BackColor = System.Drawing.SystemColors.Control
		Me.lblAddHK.Enabled = True
		Me.lblAddHK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAddHK.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAddHK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAddHK.UseMnemonic = True
		Me.lblAddHK.Visible = True
		Me.lblAddHK.AutoSize = True
		Me.lblAddHK.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAddHK.Name = "lblAddHK"
		Me._op_7.Size = New System.Drawing.Size(477, 213)
		Me._op_7.Location = New System.Drawing.Point(16, 56)
		Me._op_7.TabIndex = 84
		Me._op_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._op_7.Dock = System.Windows.Forms.DockStyle.None
		Me._op_7.BackColor = System.Drawing.SystemColors.Control
		Me._op_7.CausesValidation = True
		Me._op_7.Enabled = True
		Me._op_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._op_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._op_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._op_7.TabStop = True
		Me._op_7.Visible = True
		Me._op_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._op_7.Name = "_op_7"
		Me._optStartupType_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optStartupType_0.Text = "Всегда"
		Me._optStartupType_0.Size = New System.Drawing.Size(126, 16)
		Me._optStartupType_0.Location = New System.Drawing.Point(20, 100)
		Me._optStartupType_0.TabIndex = 109
		Me._optStartupType_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optStartupType_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optStartupType_0.BackColor = System.Drawing.SystemColors.Control
		Me._optStartupType_0.CausesValidation = True
		Me._optStartupType_0.Enabled = True
		Me._optStartupType_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optStartupType_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optStartupType_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optStartupType_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optStartupType_0.TabStop = True
		Me._optStartupType_0.Checked = False
		Me._optStartupType_0.Visible = True
		Me._optStartupType_0.Name = "_optStartupType_0"
		Me._optStartupType_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optStartupType_1.Text = "При изменениях в базе"
		Me._optStartupType_1.Size = New System.Drawing.Size(138, 16)
		Me._optStartupType_1.Location = New System.Drawing.Point(20, 128)
		Me._optStartupType_1.TabIndex = 108
		Me._optStartupType_1.Checked = True
		Me._optStartupType_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optStartupType_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optStartupType_1.BackColor = System.Drawing.SystemColors.Control
		Me._optStartupType_1.CausesValidation = True
		Me._optStartupType_1.Enabled = True
		Me._optStartupType_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optStartupType_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optStartupType_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optStartupType_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optStartupType_1.TabStop = True
		Me._optStartupType_1.Visible = True
		Me._optStartupType_1.Name = "_optStartupType_1"
		Me.fraExtProcess.Size = New System.Drawing.Size(468, 207)
		Me.fraExtProcess.Location = New System.Drawing.Point(0, 0)
		Me.fraExtProcess.TabIndex = 101
		Me.fraExtProcess.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraExtProcess.BackColor = System.Drawing.SystemColors.Control
		Me.fraExtProcess.Enabled = True
		Me.fraExtProcess.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraExtProcess.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraExtProcess.Visible = True
		Me.fraExtProcess.Name = "fraExtProcess"
		Me.fraStartType.Size = New System.Drawing.Size(154, 71)
		Me.fraStartType.Location = New System.Drawing.Point(6, 82)
		Me.fraStartType.TabIndex = 107
		Me.ToolTip1.SetToolTip(Me.fraStartType, "Запуск внешнего процесса")
		Me.fraStartType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraStartType.BackColor = System.Drawing.SystemColors.Control
		Me.fraStartType.Enabled = True
		Me.fraStartType.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraStartType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraStartType.Visible = True
		Me.fraStartType.Name = "fraStartType"
		Me._cmdSelectProcess_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._cmdSelectProcess_0.Size = New System.Drawing.Size(19, 19)
		Me._cmdSelectProcess_0.Location = New System.Drawing.Point(440, 30)
		Me._cmdSelectProcess_0.Image = CType(resources.GetObject("_cmdSelectProcess_0.Image"), System.Drawing.Image)
		Me._cmdSelectProcess_0.TabIndex = 105
		Me.ToolTip1.SetToolTip(Me._cmdSelectProcess_0, "Выбрать обработчик внешнего процесса")
		Me._cmdSelectProcess_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSelectProcess_0.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSelectProcess_0.CausesValidation = True
		Me._cmdSelectProcess_0.Enabled = True
		Me._cmdSelectProcess_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSelectProcess_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSelectProcess_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSelectProcess_0.TabStop = True
		Me._cmdSelectProcess_0.Name = "_cmdSelectProcess_0"
		Me.txtExtProcess.AutoSize = False
		Me.txtExtProcess.Size = New System.Drawing.Size(430, 19)
		Me.txtExtProcess.Location = New System.Drawing.Point(5, 30)
		Me.txtExtProcess.TabIndex = 104
		Me.txtExtProcess.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExtProcess.AcceptsReturn = True
		Me.txtExtProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtExtProcess.BackColor = System.Drawing.SystemColors.Window
		Me.txtExtProcess.CausesValidation = True
		Me.txtExtProcess.Enabled = True
		Me.txtExtProcess.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExtProcess.HideSelection = True
		Me.txtExtProcess.ReadOnly = False
		Me.txtExtProcess.Maxlength = 0
		Me.txtExtProcess.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExtProcess.MultiLine = False
		Me.txtExtProcess.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExtProcess.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExtProcess.TabStop = True
		Me.txtExtProcess.Visible = True
		Me.txtExtProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtExtProcess.Name = "txtExtProcess"
		Me.chkExtProcess.Text = "&Запуск внешнего процесса при выходе программы."
		Me.chkExtProcess.Size = New System.Drawing.Size(297, 17)
		Me.chkExtProcess.Location = New System.Drawing.Point(5, 10)
		Me.chkExtProcess.TabIndex = 103
		Me.chkExtProcess.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkExtProcess.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkExtProcess.BackColor = System.Drawing.SystemColors.Control
		Me.chkExtProcess.CausesValidation = True
		Me.chkExtProcess.Enabled = True
		Me.chkExtProcess.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkExtProcess.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkExtProcess.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkExtProcess.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkExtProcess.TabStop = True
		Me.chkExtProcess.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkExtProcess.Visible = True
		Me.chkExtProcess.Name = "chkExtProcess"
		Me.txtExtProcessParams.AutoSize = False
		Me.txtExtProcessParams.Size = New System.Drawing.Size(345, 19)
		Me.txtExtProcessParams.Location = New System.Drawing.Point(114, 55)
		Me.txtExtProcessParams.TabIndex = 102
		Me.txtExtProcessParams.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExtProcessParams.AcceptsReturn = True
		Me.txtExtProcessParams.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtExtProcessParams.BackColor = System.Drawing.SystemColors.Window
		Me.txtExtProcessParams.CausesValidation = True
		Me.txtExtProcessParams.Enabled = True
		Me.txtExtProcessParams.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExtProcessParams.HideSelection = True
		Me.txtExtProcessParams.ReadOnly = False
		Me.txtExtProcessParams.Maxlength = 0
		Me.txtExtProcessParams.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExtProcessParams.MultiLine = False
		Me.txtExtProcessParams.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExtProcessParams.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExtProcessParams.TabStop = True
		Me.txtExtProcessParams.Visible = True
		Me.txtExtProcessParams.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtExtProcessParams.Name = "txtExtProcessParams"
		Me.lblParams.Text = "Параметры запуска:"
		Me.lblParams.Size = New System.Drawing.Size(106, 13)
		Me.lblParams.Location = New System.Drawing.Point(5, 56)
		Me.lblParams.TabIndex = 106
		Me.lblParams.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblParams.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblParams.BackColor = System.Drawing.SystemColors.Control
		Me.lblParams.Enabled = True
		Me.lblParams.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblParams.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblParams.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblParams.UseMnemonic = True
		Me.lblParams.Visible = True
		Me.lblParams.AutoSize = True
		Me.lblParams.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblParams.Name = "lblParams"
		Me._op_6.Size = New System.Drawing.Size(477, 211)
		Me._op_6.Location = New System.Drawing.Point(16, 56)
		Me._op_6.TabIndex = 62
		Me._op_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._op_6.Dock = System.Windows.Forms.DockStyle.None
		Me._op_6.BackColor = System.Drawing.SystemColors.Control
		Me._op_6.CausesValidation = True
		Me._op_6.Enabled = True
		Me._op_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._op_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._op_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._op_6.TabStop = True
		Me._op_6.Visible = True
		Me._op_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._op_6.Name = "_op_6"
		Me.fraNp.Size = New System.Drawing.Size(464, 196)
		Me.fraNp.Location = New System.Drawing.Point(6, 5)
		Me.fraNp.TabIndex = 63
		Me.fraNp.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraNp.BackColor = System.Drawing.SystemColors.Control
		Me.fraNp.Enabled = True
		Me.fraNp.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraNp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraNp.Visible = True
		Me.fraNp.Name = "fraNp"
		Me.fraExample.Size = New System.Drawing.Size(305, 61)
		Me.fraExample.Location = New System.Drawing.Point(150, 112)
		Me.fraExample.TabIndex = 75
		Me.fraExample.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraExample.BackColor = System.Drawing.SystemColors.Control
		Me.fraExample.Enabled = True
		Me.fraExample.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraExample.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraExample.Visible = True
		Me.fraExample.Name = "fraExample"
		Me.txtExample.AutoSize = False
		Me.txtExample.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtExample.Enabled = False
		Me.txtExample.Size = New System.Drawing.Size(295, 19)
		Me.txtExample.Location = New System.Drawing.Point(5, 30)
		Me.txtExample.TabIndex = 76
		Me.txtExample.Text = "np: Winamp Stopped Uptime: 0 days 12:34:43"
		Me.txtExample.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExample.AcceptsReturn = True
		Me.txtExample.BackColor = System.Drawing.SystemColors.Window
		Me.txtExample.CausesValidation = True
		Me.txtExample.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExample.HideSelection = True
		Me.txtExample.ReadOnly = False
		Me.txtExample.Maxlength = 0
		Me.txtExample.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExample.MultiLine = False
		Me.txtExample.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExample.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExample.TabStop = True
		Me.txtExample.Visible = True
		Me.txtExample.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtExample.Name = "txtExample"
		Me.lblExample.Text = "Пример:"
		Me.lblExample.Size = New System.Drawing.Size(43, 13)
		Me.lblExample.Location = New System.Drawing.Point(5, 15)
		Me.lblExample.TabIndex = 77
		Me.lblExample.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblExample.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblExample.BackColor = System.Drawing.SystemColors.Control
		Me.lblExample.Enabled = True
		Me.lblExample.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblExample.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblExample.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblExample.UseMnemonic = True
		Me.lblExample.Visible = True
		Me.lblExample.AutoSize = True
		Me.lblExample.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblExample.Name = "lblExample"
		Me.fraControlNp.Size = New System.Drawing.Size(131, 61)
		Me.fraControlNp.Location = New System.Drawing.Point(10, 112)
		Me.fraControlNp.TabIndex = 72
		Me.fraControlNp.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraControlNp.BackColor = System.Drawing.SystemColors.Control
		Me.fraControlNp.Enabled = True
		Me.fraControlNp.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraControlNp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraControlNp.Visible = True
		Me.fraControlNp.Name = "fraControlNp"
		Me.chkUptimeEnabled.Text = "Разрешить Uptime"
		Me.chkUptimeEnabled.Size = New System.Drawing.Size(116, 16)
		Me.chkUptimeEnabled.Location = New System.Drawing.Point(5, 40)
		Me.chkUptimeEnabled.TabIndex = 74
		Me.chkUptimeEnabled.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkUptimeEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkUptimeEnabled.BackColor = System.Drawing.SystemColors.Control
		Me.chkUptimeEnabled.CausesValidation = True
		Me.chkUptimeEnabled.Enabled = True
		Me.chkUptimeEnabled.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkUptimeEnabled.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkUptimeEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkUptimeEnabled.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkUptimeEnabled.TabStop = True
		Me.chkUptimeEnabled.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkUptimeEnabled.Visible = True
		Me.chkUptimeEnabled.Name = "chkUptimeEnabled"
		Me.chkNpEnabled.Text = "Разрешить NP"
		Me.chkNpEnabled.Size = New System.Drawing.Size(116, 16)
		Me.chkNpEnabled.Location = New System.Drawing.Point(5, 15)
		Me.chkNpEnabled.TabIndex = 73
		Me.chkNpEnabled.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkNpEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkNpEnabled.BackColor = System.Drawing.SystemColors.Control
		Me.chkNpEnabled.CausesValidation = True
		Me.chkNpEnabled.Enabled = True
		Me.chkNpEnabled.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkNpEnabled.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkNpEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkNpEnabled.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkNpEnabled.TabStop = True
		Me.chkNpEnabled.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkNpEnabled.Visible = True
		Me.chkNpEnabled.Name = "chkNpEnabled"
		Me.txtNotLoading.AutoSize = False
		Me.txtNotLoading.Size = New System.Drawing.Size(305, 16)
		Me.txtNotLoading.Location = New System.Drawing.Point(150, 75)
		Me.txtNotLoading.TabIndex = 71
		Me.txtNotLoading.Text = "Winamp Not Found!"
		Me.txtNotLoading.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNotLoading.AcceptsReturn = True
		Me.txtNotLoading.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtNotLoading.BackColor = System.Drawing.SystemColors.Window
		Me.txtNotLoading.CausesValidation = True
		Me.txtNotLoading.Enabled = True
		Me.txtNotLoading.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNotLoading.HideSelection = True
		Me.txtNotLoading.ReadOnly = False
		Me.txtNotLoading.Maxlength = 0
		Me.txtNotLoading.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNotLoading.MultiLine = False
		Me.txtNotLoading.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNotLoading.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNotLoading.TabStop = True
		Me.txtNotLoading.Visible = True
		Me.txtNotLoading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNotLoading.Name = "txtNotLoading"
		Me.txtUptime.AutoSize = False
		Me.txtUptime.Size = New System.Drawing.Size(305, 16)
		Me.txtUptime.Location = New System.Drawing.Point(150, 55)
		Me.txtUptime.TabIndex = 70
		Me.txtUptime.Text = "Uptime:"
		Me.txtUptime.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUptime.AcceptsReturn = True
		Me.txtUptime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtUptime.BackColor = System.Drawing.SystemColors.Window
		Me.txtUptime.CausesValidation = True
		Me.txtUptime.Enabled = True
		Me.txtUptime.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtUptime.HideSelection = True
		Me.txtUptime.ReadOnly = False
		Me.txtUptime.Maxlength = 0
		Me.txtUptime.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUptime.MultiLine = False
		Me.txtUptime.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtUptime.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUptime.TabStop = True
		Me.txtUptime.Visible = True
		Me.txtUptime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUptime.Name = "txtUptime"
		Me.txtStopped.AutoSize = False
		Me.txtStopped.Size = New System.Drawing.Size(305, 16)
		Me.txtStopped.Location = New System.Drawing.Point(150, 35)
		Me.txtStopped.TabIndex = 69
		Me.txtStopped.Text = "Winamp Stopped"
		Me.txtStopped.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStopped.AcceptsReturn = True
		Me.txtStopped.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtStopped.BackColor = System.Drawing.SystemColors.Window
		Me.txtStopped.CausesValidation = True
		Me.txtStopped.Enabled = True
		Me.txtStopped.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStopped.HideSelection = True
		Me.txtStopped.ReadOnly = False
		Me.txtStopped.Maxlength = 0
		Me.txtStopped.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStopped.MultiLine = False
		Me.txtStopped.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStopped.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStopped.TabStop = True
		Me.txtStopped.Visible = True
		Me.txtStopped.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStopped.Name = "txtStopped"
		Me.txtNpPrefix.AutoSize = False
		Me.txtNpPrefix.Size = New System.Drawing.Size(305, 16)
		Me.txtNpPrefix.Location = New System.Drawing.Point(150, 15)
		Me.txtNpPrefix.TabIndex = 68
		Me.txtNpPrefix.Text = "np:"
		Me.txtNpPrefix.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNpPrefix.AcceptsReturn = True
		Me.txtNpPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtNpPrefix.BackColor = System.Drawing.SystemColors.Window
		Me.txtNpPrefix.CausesValidation = True
		Me.txtNpPrefix.Enabled = True
		Me.txtNpPrefix.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNpPrefix.HideSelection = True
		Me.txtNpPrefix.ReadOnly = False
		Me.txtNpPrefix.Maxlength = 0
		Me.txtNpPrefix.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNpPrefix.MultiLine = False
		Me.txtNpPrefix.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNpPrefix.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNpPrefix.TabStop = True
		Me.txtNpPrefix.Visible = True
		Me.txtNpPrefix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNpPrefix.Name = "txtNpPrefix"
		Me.lblWinamp.Text = "Winamp Not Loaded String:"
		Me.lblWinamp.Size = New System.Drawing.Size(131, 13)
		Me.lblWinamp.Location = New System.Drawing.Point(10, 76)
		Me.lblWinamp.TabIndex = 67
		Me.lblWinamp.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWinamp.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWinamp.BackColor = System.Drawing.SystemColors.Control
		Me.lblWinamp.Enabled = True
		Me.lblWinamp.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWinamp.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWinamp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWinamp.UseMnemonic = True
		Me.lblWinamp.Visible = True
		Me.lblWinamp.AutoSize = True
		Me.lblWinamp.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWinamp.Name = "lblWinamp"
		Me.lblUptime.Text = "Uptime String:"
		Me.lblUptime.Size = New System.Drawing.Size(66, 13)
		Me.lblUptime.Location = New System.Drawing.Point(77, 56)
		Me.lblUptime.TabIndex = 66
		Me.lblUptime.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUptime.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUptime.BackColor = System.Drawing.SystemColors.Control
		Me.lblUptime.Enabled = True
		Me.lblUptime.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUptime.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUptime.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUptime.UseMnemonic = True
		Me.lblUptime.Visible = True
		Me.lblUptime.AutoSize = True
		Me.lblUptime.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUptime.Name = "lblUptime"
		Me.lblStopped.Text = "Stoped String:"
		Me.lblStopped.Size = New System.Drawing.Size(67, 13)
		Me.lblStopped.Location = New System.Drawing.Point(76, 36)
		Me.lblStopped.TabIndex = 65
		Me.lblStopped.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStopped.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblStopped.BackColor = System.Drawing.SystemColors.Control
		Me.lblStopped.Enabled = True
		Me.lblStopped.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblStopped.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblStopped.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblStopped.UseMnemonic = True
		Me.lblStopped.Visible = True
		Me.lblStopped.AutoSize = True
		Me.lblStopped.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblStopped.Name = "lblStopped"
		Me.lblPrefix.Text = "Np Prefix:"
		Me.lblPrefix.Size = New System.Drawing.Size(46, 13)
		Me.lblPrefix.Location = New System.Drawing.Point(80, 15)
		Me.lblPrefix.TabIndex = 64
		Me.lblPrefix.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrefix.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPrefix.BackColor = System.Drawing.SystemColors.Control
		Me.lblPrefix.Enabled = True
		Me.lblPrefix.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPrefix.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPrefix.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPrefix.UseMnemonic = True
		Me.lblPrefix.Visible = True
		Me.lblPrefix.AutoSize = True
		Me.lblPrefix.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPrefix.Name = "lblPrefix"
		Me._op_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._op_5.Size = New System.Drawing.Size(476, 213)
		Me._op_5.Location = New System.Drawing.Point(16, 56)
		Me._op_5.TabIndex = 46
		Me._op_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._op_5.Dock = System.Windows.Forms.DockStyle.None
		Me._op_5.BackColor = System.Drawing.SystemColors.Control
		Me._op_5.CausesValidation = True
		Me._op_5.Enabled = True
		Me._op_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._op_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._op_5.TabStop = True
		Me._op_5.Visible = True
		Me._op_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._op_5.Name = "_op_5"
		Me._cmdSelectFont_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSelectFont_6.Size = New System.Drawing.Size(16, 16)
		Me._cmdSelectFont_6.Location = New System.Drawing.Point(440, 155)
		Me._cmdSelectFont_6.TabIndex = 98
		Me.ToolTip1.SetToolTip(Me._cmdSelectFont_6, "Выбор шрифта")
		Me._cmdSelectFont_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSelectFont_6.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSelectFont_6.CausesValidation = True
		Me._cmdSelectFont_6.Enabled = True
		Me._cmdSelectFont_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSelectFont_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSelectFont_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSelectFont_6.TabStop = True
		Me._cmdSelectFont_6.Name = "_cmdSelectFont_6"
		Me._cmdSelectFont_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSelectFont_5.Size = New System.Drawing.Size(16, 16)
		Me._cmdSelectFont_5.Location = New System.Drawing.Point(440, 135)
		Me._cmdSelectFont_5.TabIndex = 97
		Me.ToolTip1.SetToolTip(Me._cmdSelectFont_5, "Выбор шрифта")
		Me._cmdSelectFont_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSelectFont_5.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSelectFont_5.CausesValidation = True
		Me._cmdSelectFont_5.Enabled = True
		Me._cmdSelectFont_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSelectFont_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSelectFont_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSelectFont_5.TabStop = True
		Me._cmdSelectFont_5.Name = "_cmdSelectFont_5"
		Me._cmdSelectFont_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSelectFont_4.Size = New System.Drawing.Size(16, 16)
		Me._cmdSelectFont_4.Location = New System.Drawing.Point(440, 115)
		Me._cmdSelectFont_4.TabIndex = 96
		Me.ToolTip1.SetToolTip(Me._cmdSelectFont_4, "Выбор шрифта")
		Me._cmdSelectFont_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSelectFont_4.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSelectFont_4.CausesValidation = True
		Me._cmdSelectFont_4.Enabled = True
		Me._cmdSelectFont_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSelectFont_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSelectFont_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSelectFont_4.TabStop = True
		Me._cmdSelectFont_4.Name = "_cmdSelectFont_4"
		Me._cmdSelectFont_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSelectFont_3.Size = New System.Drawing.Size(16, 16)
		Me._cmdSelectFont_3.Location = New System.Drawing.Point(440, 95)
		Me._cmdSelectFont_3.TabIndex = 95
		Me.ToolTip1.SetToolTip(Me._cmdSelectFont_3, "Выбор шрифта")
		Me._cmdSelectFont_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSelectFont_3.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSelectFont_3.CausesValidation = True
		Me._cmdSelectFont_3.Enabled = True
		Me._cmdSelectFont_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSelectFont_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSelectFont_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSelectFont_3.TabStop = True
		Me._cmdSelectFont_3.Name = "_cmdSelectFont_3"
		Me._cmdSelectFont_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSelectFont_2.Size = New System.Drawing.Size(16, 16)
		Me._cmdSelectFont_2.Location = New System.Drawing.Point(440, 75)
		Me._cmdSelectFont_2.TabIndex = 94
		Me.ToolTip1.SetToolTip(Me._cmdSelectFont_2, "Выбор шрифта")
		Me._cmdSelectFont_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSelectFont_2.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSelectFont_2.CausesValidation = True
		Me._cmdSelectFont_2.Enabled = True
		Me._cmdSelectFont_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSelectFont_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSelectFont_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSelectFont_2.TabStop = True
		Me._cmdSelectFont_2.Name = "_cmdSelectFont_2"
		Me._cmdSelectFont_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSelectFont_1.Size = New System.Drawing.Size(16, 16)
		Me._cmdSelectFont_1.Location = New System.Drawing.Point(440, 55)
		Me._cmdSelectFont_1.TabIndex = 93
		Me.ToolTip1.SetToolTip(Me._cmdSelectFont_1, "Выбор шрифта")
		Me._cmdSelectFont_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSelectFont_1.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSelectFont_1.CausesValidation = True
		Me._cmdSelectFont_1.Enabled = True
		Me._cmdSelectFont_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSelectFont_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSelectFont_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSelectFont_1.TabStop = True
		Me._cmdSelectFont_1.Name = "_cmdSelectFont_1"
		Me._cmdSelectFont_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdSelectFont_0.Size = New System.Drawing.Size(16, 16)
		Me._cmdSelectFont_0.Location = New System.Drawing.Point(440, 35)
		Me._cmdSelectFont_0.TabIndex = 92
		Me.ToolTip1.SetToolTip(Me._cmdSelectFont_0, "Выбор шрифта")
		Me._cmdSelectFont_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdSelectFont_0.BackColor = System.Drawing.SystemColors.Control
		Me._cmdSelectFont_0.CausesValidation = True
		Me._cmdSelectFont_0.Enabled = True
		Me._cmdSelectFont_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdSelectFont_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdSelectFont_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdSelectFont_0.TabStop = True
		Me._cmdSelectFont_0.Name = "_cmdSelectFont_0"
		Me.fraFonts.Text = "Шрифты"
		Me.fraFonts.ForeColor = System.Drawing.Color.Blue
		Me.fraFonts.Size = New System.Drawing.Size(459, 205)
		Me.fraFonts.Location = New System.Drawing.Point(8, 0)
		Me.fraFonts.TabIndex = 47
		Me.fraFonts.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraFonts.BackColor = System.Drawing.SystemColors.Control
		Me.fraFonts.Enabled = True
		Me.fraFonts.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraFonts.Visible = True
		Me.fraFonts.Name = "fraFonts"
		Me.lblSubjFont.Text = "Arial - Bold Italic - 8pt"
		Me.lblSubjFont.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.lblSubjFont.Size = New System.Drawing.Size(283, 15)
		Me.lblSubjFont.Location = New System.Drawing.Point(150, 151)
		Me.lblSubjFont.TabIndex = 61
		Me.lblSubjFont.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSubjFont.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSubjFont.BackColor = System.Drawing.SystemColors.Control
		Me.lblSubjFont.Enabled = True
		Me.lblSubjFont.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSubjFont.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSubjFont.UseMnemonic = True
		Me.lblSubjFont.Visible = True
		Me.lblSubjFont.AutoSize = False
		Me.lblSubjFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblSubjFont.Name = "lblSubjFont"
		Me.lblSubj.Text = "В Поле ""ТЕМА"":"
		Me.lblSubj.ForeColor = System.Drawing.Color.FromARGB(128, 64, 0)
		Me.lblSubj.Size = New System.Drawing.Size(82, 13)
		Me.lblSubj.Location = New System.Drawing.Point(64, 151)
		Me.lblSubj.TabIndex = 60
		Me.lblSubj.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSubj.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSubj.BackColor = System.Drawing.SystemColors.Control
		Me.lblSubj.Enabled = True
		Me.lblSubj.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSubj.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSubj.UseMnemonic = True
		Me.lblSubj.Visible = True
		Me.lblSubj.AutoSize = True
		Me.lblSubj.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSubj.Name = "lblSubj"
		Me.lblToFont.Text = "Arial - Bold - 8pt"
		Me.lblToFont.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.lblToFont.Size = New System.Drawing.Size(283, 15)
		Me.lblToFont.Location = New System.Drawing.Point(150, 131)
		Me.lblToFont.TabIndex = 59
		Me.lblToFont.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblToFont.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblToFont.BackColor = System.Drawing.SystemColors.Control
		Me.lblToFont.Enabled = True
		Me.lblToFont.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblToFont.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblToFont.UseMnemonic = True
		Me.lblToFont.Visible = True
		Me.lblToFont.AutoSize = False
		Me.lblToFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblToFont.Name = "lblToFont"
		Me.lblTO.Text = "В поле ""КОМУ"":"
		Me.lblTO.ForeColor = System.Drawing.Color.FromARGB(128, 64, 0)
		Me.lblTO.Size = New System.Drawing.Size(82, 13)
		Me.lblTO.Location = New System.Drawing.Point(64, 131)
		Me.lblTO.TabIndex = 58
		Me.lblTO.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTO.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTO.BackColor = System.Drawing.SystemColors.Control
		Me.lblTO.Enabled = True
		Me.lblTO.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTO.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTO.UseMnemonic = True
		Me.lblTO.Visible = True
		Me.lblTO.AutoSize = True
		Me.lblTO.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTO.Name = "lblTO"
		Me.lblFromFont.Text = "Arial - Bold - 8pt"
		Me.lblFromFont.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.lblFromFont.Size = New System.Drawing.Size(283, 15)
		Me.lblFromFont.Location = New System.Drawing.Point(150, 111)
		Me.lblFromFont.TabIndex = 57
		Me.lblFromFont.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFromFont.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblFromFont.BackColor = System.Drawing.SystemColors.Control
		Me.lblFromFont.Enabled = True
		Me.lblFromFont.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFromFont.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFromFont.UseMnemonic = True
		Me.lblFromFont.Visible = True
		Me.lblFromFont.AutoSize = False
		Me.lblFromFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblFromFont.Name = "lblFromFont"
		Me.lblFrom.Text = "В поле ""ОТ"":"
		Me.lblFrom.ForeColor = System.Drawing.Color.FromARGB(128, 64, 0)
		Me.lblFrom.Size = New System.Drawing.Size(65, 13)
		Me.lblFrom.Location = New System.Drawing.Point(81, 112)
		Me.lblFrom.TabIndex = 56
		Me.lblFrom.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFrom.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblFrom.BackColor = System.Drawing.SystemColors.Control
		Me.lblFrom.Enabled = True
		Me.lblFrom.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFrom.UseMnemonic = True
		Me.lblFrom.Visible = True
		Me.lblFrom.AutoSize = True
		Me.lblFrom.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblFrom.Name = "lblFrom"
		Me.lblEditorWindowFont.Text = "MS Sans Serif - Regular - 8pt"
		Me.lblEditorWindowFont.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.lblEditorWindowFont.Size = New System.Drawing.Size(283, 15)
		Me.lblEditorWindowFont.Location = New System.Drawing.Point(150, 91)
		Me.lblEditorWindowFont.TabIndex = 55
		Me.lblEditorWindowFont.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEditorWindowFont.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblEditorWindowFont.BackColor = System.Drawing.SystemColors.Control
		Me.lblEditorWindowFont.Enabled = True
		Me.lblEditorWindowFont.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblEditorWindowFont.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblEditorWindowFont.UseMnemonic = True
		Me.lblEditorWindowFont.Visible = True
		Me.lblEditorWindowFont.AutoSize = False
		Me.lblEditorWindowFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblEditorWindowFont.Name = "lblEditorWindowFont"
		Me.lblEditorFont.Text = "В окне редактора:"
		Me.lblEditorFont.ForeColor = System.Drawing.Color.FromARGB(128, 64, 0)
		Me.lblEditorFont.Size = New System.Drawing.Size(93, 13)
		Me.lblEditorFont.Location = New System.Drawing.Point(53, 91)
		Me.lblEditorFont.TabIndex = 54
		Me.lblEditorFont.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEditorFont.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblEditorFont.BackColor = System.Drawing.SystemColors.Control
		Me.lblEditorFont.Enabled = True
		Me.lblEditorFont.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblEditorFont.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblEditorFont.UseMnemonic = True
		Me.lblEditorFont.Visible = True
		Me.lblEditorFont.AutoSize = True
		Me.lblEditorFont.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblEditorFont.Name = "lblEditorFont"
		Me.lblMainTextViewFont.Text = "MS Sans Serif - Regular - 8pt"
		Me.lblMainTextViewFont.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.lblMainTextViewFont.Size = New System.Drawing.Size(283, 15)
		Me.lblMainTextViewFont.Location = New System.Drawing.Point(150, 71)
		Me.lblMainTextViewFont.TabIndex = 53
		Me.lblMainTextViewFont.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMainTextViewFont.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMainTextViewFont.BackColor = System.Drawing.SystemColors.Control
		Me.lblMainTextViewFont.Enabled = True
		Me.lblMainTextViewFont.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMainTextViewFont.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMainTextViewFont.UseMnemonic = True
		Me.lblMainTextViewFont.Visible = True
		Me.lblMainTextViewFont.AutoSize = False
		Me.lblMainTextViewFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblMainTextViewFont.Name = "lblMainTextViewFont"
		Me.lblMainViewer.Text = "В главном окне просмотра:"
		Me.lblMainViewer.ForeColor = System.Drawing.Color.FromARGB(128, 64, 0)
		Me.lblMainViewer.Size = New System.Drawing.Size(141, 13)
		Me.lblMainViewer.Location = New System.Drawing.Point(5, 71)
		Me.lblMainViewer.TabIndex = 52
		Me.lblMainViewer.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMainViewer.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMainViewer.BackColor = System.Drawing.SystemColors.Control
		Me.lblMainViewer.Enabled = True
		Me.lblMainViewer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMainViewer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMainViewer.UseMnemonic = True
		Me.lblMainViewer.Visible = True
		Me.lblMainViewer.AutoSize = True
		Me.lblMainViewer.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMainViewer.Name = "lblMainViewer"
		Me.lblTreeViewFont.Text = "MS Sans Serif - Regular - 8pt"
		Me.lblTreeViewFont.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.lblTreeViewFont.Size = New System.Drawing.Size(283, 15)
		Me.lblTreeViewFont.Location = New System.Drawing.Point(150, 51)
		Me.lblTreeViewFont.TabIndex = 51
		Me.lblTreeViewFont.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTreeViewFont.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTreeViewFont.BackColor = System.Drawing.SystemColors.Control
		Me.lblTreeViewFont.Enabled = True
		Me.lblTreeViewFont.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTreeViewFont.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTreeViewFont.UseMnemonic = True
		Me.lblTreeViewFont.Visible = True
		Me.lblTreeViewFont.AutoSize = False
		Me.lblTreeViewFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblTreeViewFont.Name = "lblTreeViewFont"
		Me.lblTreeFont.Text = "В дереве сообщений:"
		Me.lblTreeFont.ForeColor = System.Drawing.Color.FromARGB(128, 64, 0)
		Me.lblTreeFont.Size = New System.Drawing.Size(109, 13)
		Me.lblTreeFont.Location = New System.Drawing.Point(37, 51)
		Me.lblTreeFont.TabIndex = 50
		Me.lblTreeFont.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTreeFont.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTreeFont.BackColor = System.Drawing.SystemColors.Control
		Me.lblTreeFont.Enabled = True
		Me.lblTreeFont.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTreeFont.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTreeFont.UseMnemonic = True
		Me.lblTreeFont.Visible = True
		Me.lblTreeFont.AutoSize = True
		Me.lblTreeFont.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTreeFont.Name = "lblTreeFont"
		Me.lblEcholistFont.Text = "Times New Roman - Regular - 8pt"
		Me.lblEcholistFont.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.lblEcholistFont.Size = New System.Drawing.Size(283, 16)
		Me.lblEcholistFont.Location = New System.Drawing.Point(150, 30)
		Me.lblEcholistFont.TabIndex = 49
		Me.lblEcholistFont.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEcholistFont.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblEcholistFont.BackColor = System.Drawing.Color.Transparent
		Me.lblEcholistFont.Enabled = True
		Me.lblEcholistFont.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblEcholistFont.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblEcholistFont.UseMnemonic = True
		Me.lblEcholistFont.Visible = True
		Me.lblEcholistFont.AutoSize = False
		Me.lblEcholistFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblEcholistFont.Name = "lblEcholistFont"
		Me.lblEchoFont.Text = "В списке эх:"
		Me.lblEchoFont.ForeColor = System.Drawing.Color.FromARGB(128, 64, 0)
		Me.lblEchoFont.Size = New System.Drawing.Size(63, 13)
		Me.lblEchoFont.Location = New System.Drawing.Point(83, 31)
		Me.lblEchoFont.TabIndex = 48
		Me.lblEchoFont.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEchoFont.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblEchoFont.BackColor = System.Drawing.SystemColors.Control
		Me.lblEchoFont.Enabled = True
		Me.lblEchoFont.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblEchoFont.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblEchoFont.UseMnemonic = True
		Me.lblEchoFont.Visible = True
		Me.lblEchoFont.AutoSize = True
		Me.lblEchoFont.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblEchoFont.Name = "lblEchoFont"
		Me._op_4.Size = New System.Drawing.Size(481, 207)
		Me._op_4.Location = New System.Drawing.Point(16, 56)
		Me._op_4.TabIndex = 45
		Me._op_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._op_4.Dock = System.Windows.Forms.DockStyle.None
		Me._op_4.BackColor = System.Drawing.SystemColors.Control
		Me._op_4.CausesValidation = True
		Me._op_4.Enabled = True
		Me._op_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._op_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._op_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._op_4.TabStop = True
		Me._op_4.Visible = True
		Me._op_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._op_4.Name = "_op_4"
		Me.fraReplacmentsButtons.Size = New System.Drawing.Size(97, 201)
		Me.fraReplacmentsButtons.Location = New System.Drawing.Point(368, 0)
		Me.fraReplacmentsButtons.TabIndex = 121
		Me.fraReplacmentsButtons.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraReplacmentsButtons.BackColor = System.Drawing.SystemColors.Control
		Me.fraReplacmentsButtons.Enabled = True
		Me.fraReplacmentsButtons.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraReplacmentsButtons.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraReplacmentsButtons.Visible = True
		Me.fraReplacmentsButtons.Name = "fraReplacmentsButtons"
		Me.cmdAddSymbol.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdAddSymbol.Text = "&Добавить"
		Me.cmdAddSymbol.Size = New System.Drawing.Size(61, 36)
		Me.cmdAddSymbol.Location = New System.Drawing.Point(16, 24)
		Me.cmdAddSymbol.Image = CType(resources.GetObject("cmdAddSymbol.Image"), System.Drawing.Image)
		Me.cmdAddSymbol.TabIndex = 124
		Me.cmdAddSymbol.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAddSymbol.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAddSymbol.CausesValidation = True
		Me.cmdAddSymbol.Enabled = True
		Me.cmdAddSymbol.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAddSymbol.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAddSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAddSymbol.TabStop = True
		Me.cmdAddSymbol.Name = "cmdAddSymbol"
		Me.cmdDelSymbol.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdDelSymbol.Text = "&Удалить"
		Me.cmdDelSymbol.Size = New System.Drawing.Size(61, 36)
		Me.cmdDelSymbol.Location = New System.Drawing.Point(16, 144)
		Me.cmdDelSymbol.Image = CType(resources.GetObject("cmdDelSymbol.Image"), System.Drawing.Image)
		Me.cmdDelSymbol.TabIndex = 123
		Me.ToolTip1.SetToolTip(Me.cmdDelSymbol, "Удалить")
		Me.cmdDelSymbol.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDelSymbol.BackColor = System.Drawing.SystemColors.Control
		Me.cmdDelSymbol.CausesValidation = True
		Me.cmdDelSymbol.Enabled = True
		Me.cmdDelSymbol.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdDelSymbol.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDelSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdDelSymbol.TabStop = True
		Me.cmdDelSymbol.Name = "cmdDelSymbol"
		Me.cmdEditSymbol.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdEditSymbol.Text = "&Изменить"
		Me.cmdEditSymbol.Size = New System.Drawing.Size(61, 36)
		Me.cmdEditSymbol.Location = New System.Drawing.Point(16, 80)
		Me.cmdEditSymbol.Image = CType(resources.GetObject("cmdEditSymbol.Image"), System.Drawing.Image)
		Me.cmdEditSymbol.TabIndex = 122
		Me.cmdEditSymbol.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdEditSymbol.BackColor = System.Drawing.SystemColors.Control
		Me.cmdEditSymbol.CausesValidation = True
		Me.cmdEditSymbol.Enabled = True
		Me.cmdEditSymbol.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdEditSymbol.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdEditSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdEditSymbol.TabStop = True
		Me.cmdEditSymbol.Name = "cmdEditSymbol"
		Me.fraReplacments.Size = New System.Drawing.Size(353, 201)
		Me.fraReplacments.Location = New System.Drawing.Point(8, 0)
		Me.fraReplacments.TabIndex = 119
		Me.fraReplacments.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraReplacments.BackColor = System.Drawing.SystemColors.Control
		Me.fraReplacments.Enabled = True
		Me.fraReplacments.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraReplacments.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraReplacments.Visible = True
		Me.fraReplacments.Name = "fraReplacments"
		lstReplacments.OcxState = CType(resources.GetObject("lstReplacments.OcxState"), System.Windows.Forms.AxHost.State)
		Me.lstReplacments.Size = New System.Drawing.Size(277, 189)
		Me.lstReplacments.Location = New System.Drawing.Point(40, 8)
		Me.lstReplacments.TabIndex = 120
		Me.lstReplacments.Name = "lstReplacments"
		tabsImages.OcxState = CType(resources.GetObject("tabsImages.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tabsImages.Location = New System.Drawing.Point(496, 296)
		Me.tabsImages.Name = "tabsImages"
		Me._op_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._op_3.Size = New System.Drawing.Size(477, 207)
		Me._op_3.Location = New System.Drawing.Point(16, 56)
		Me._op_3.TabIndex = 38
		Me._op_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._op_3.Dock = System.Windows.Forms.DockStyle.None
		Me._op_3.BackColor = System.Drawing.SystemColors.Control
		Me._op_3.CausesValidation = True
		Me._op_3.Enabled = True
		Me._op_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._op_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._op_3.TabStop = True
		Me._op_3.Visible = True
		Me._op_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._op_3.Name = "_op_3"
		Me._chkFlags_0.Text = "Pvt"
		Me._chkFlags_0.Size = New System.Drawing.Size(41, 16)
		Me._chkFlags_0.Location = New System.Drawing.Point(72, 184)
		Me._chkFlags_0.TabIndex = 148
		Me.ToolTip1.SetToolTip(Me._chkFlags_0, "Личное сообщение")
		Me._chkFlags_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFlags_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFlags_0.BackColor = System.Drawing.SystemColors.Control
		Me._chkFlags_0.CausesValidation = True
		Me._chkFlags_0.Enabled = True
		Me._chkFlags_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFlags_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFlags_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFlags_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFlags_0.TabStop = True
		Me._chkFlags_0.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFlags_0.Visible = True
		Me._chkFlags_0.Name = "_chkFlags_0"
		Me._chkFlags_1.Text = "Cra"
		Me._chkFlags_1.Size = New System.Drawing.Size(41, 16)
		Me._chkFlags_1.Location = New System.Drawing.Point(132, 184)
		Me._chkFlags_1.TabIndex = 147
		Me.ToolTip1.SetToolTip(Me._chkFlags_1, "Высокоприоритетное сообщение")
		Me._chkFlags_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFlags_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFlags_1.BackColor = System.Drawing.SystemColors.Control
		Me._chkFlags_1.CausesValidation = True
		Me._chkFlags_1.Enabled = True
		Me._chkFlags_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFlags_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFlags_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFlags_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFlags_1.TabStop = True
		Me._chkFlags_1.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFlags_1.Visible = True
		Me._chkFlags_1.Name = "_chkFlags_1"
		Me._chkFlags_2.Text = "Rec"
		Me._chkFlags_2.Size = New System.Drawing.Size(41, 16)
		Me._chkFlags_2.Location = New System.Drawing.Point(187, 184)
		Me._chkFlags_2.TabIndex = 146
		Me.ToolTip1.SetToolTip(Me._chkFlags_2, "Прочитано получателем")
		Me._chkFlags_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFlags_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFlags_2.BackColor = System.Drawing.SystemColors.Control
		Me._chkFlags_2.CausesValidation = True
		Me._chkFlags_2.Enabled = True
		Me._chkFlags_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFlags_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFlags_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFlags_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFlags_2.TabStop = True
		Me._chkFlags_2.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFlags_2.Visible = True
		Me._chkFlags_2.Name = "_chkFlags_2"
		Me._chkFlags_3.Text = "K/s"
		Me._chkFlags_3.Size = New System.Drawing.Size(41, 16)
		Me._chkFlags_3.Location = New System.Drawing.Point(242, 184)
		Me._chkFlags_3.TabIndex = 145
		Me.ToolTip1.SetToolTip(Me._chkFlags_3, "Удалить после отправки")
		Me._chkFlags_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFlags_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFlags_3.BackColor = System.Drawing.SystemColors.Control
		Me._chkFlags_3.CausesValidation = True
		Me._chkFlags_3.Enabled = True
		Me._chkFlags_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFlags_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFlags_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFlags_3.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFlags_3.TabStop = True
		Me._chkFlags_3.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFlags_3.Visible = True
		Me._chkFlags_3.Name = "_chkFlags_3"
		Me._chkFlags_4.Text = "Loc"
		Me._chkFlags_4.Size = New System.Drawing.Size(41, 16)
		Me._chkFlags_4.Location = New System.Drawing.Point(297, 184)
		Me._chkFlags_4.TabIndex = 144
		Me.ToolTip1.SetToolTip(Me._chkFlags_4, "Сообщение создано на локальной системе")
		Me._chkFlags_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFlags_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFlags_4.BackColor = System.Drawing.SystemColors.Control
		Me._chkFlags_4.CausesValidation = True
		Me._chkFlags_4.Enabled = True
		Me._chkFlags_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFlags_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFlags_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFlags_4.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFlags_4.TabStop = True
		Me._chkFlags_4.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFlags_4.Visible = True
		Me._chkFlags_4.Name = "_chkFlags_4"
		Me._chkFlags_5.Text = "Hld"
		Me._chkFlags_5.Size = New System.Drawing.Size(41, 16)
		Me._chkFlags_5.Location = New System.Drawing.Point(357, 184)
		Me._chkFlags_5.TabIndex = 143
		Me.ToolTip1.SetToolTip(Me._chkFlags_5, "Задержать отправку сообщения")
		Me._chkFlags_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._chkFlags_5.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._chkFlags_5.BackColor = System.Drawing.SystemColors.Control
		Me._chkFlags_5.CausesValidation = True
		Me._chkFlags_5.Enabled = True
		Me._chkFlags_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._chkFlags_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._chkFlags_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._chkFlags_5.Appearance = System.Windows.Forms.Appearance.Normal
		Me._chkFlags_5.TabStop = True
		Me._chkFlags_5.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._chkFlags_5.Visible = True
		Me._chkFlags_5.Name = "_chkFlags_5"
		lvNetmailDirs.OcxState = CType(resources.GetObject("lvNetmailDirs.OcxState"), System.Windows.Forms.AxHost.State)
		Me.lvNetmailDirs.Size = New System.Drawing.Size(305, 152)
		Me.lvNetmailDirs.Location = New System.Drawing.Point(160, 0)
		Me.lvNetmailDirs.TabIndex = 142
		Me.lvNetmailDirs.Name = "lvNetmailDirs"
		Me._optNetmailPosition_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optNetmailPosition_1.Text = "Внизу"
		Me._optNetmailPosition_1.Size = New System.Drawing.Size(133, 16)
		Me._optNetmailPosition_1.Location = New System.Drawing.Point(16, 128)
		Me._optNetmailPosition_1.TabIndex = 87
		Me._optNetmailPosition_1.Checked = True
		Me._optNetmailPosition_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optNetmailPosition_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optNetmailPosition_1.BackColor = System.Drawing.SystemColors.Control
		Me._optNetmailPosition_1.CausesValidation = True
		Me._optNetmailPosition_1.Enabled = True
		Me._optNetmailPosition_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optNetmailPosition_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optNetmailPosition_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optNetmailPosition_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optNetmailPosition_1.TabStop = True
		Me._optNetmailPosition_1.Visible = True
		Me._optNetmailPosition_1.Name = "_optNetmailPosition_1"
		Me._optNetmailPosition_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optNetmailPosition_0.Text = "Вверху"
		Me._optNetmailPosition_0.Size = New System.Drawing.Size(133, 16)
		Me._optNetmailPosition_0.Location = New System.Drawing.Point(16, 104)
		Me._optNetmailPosition_0.TabIndex = 86
		Me._optNetmailPosition_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optNetmailPosition_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optNetmailPosition_0.BackColor = System.Drawing.SystemColors.Control
		Me._optNetmailPosition_0.CausesValidation = True
		Me._optNetmailPosition_0.Enabled = True
		Me._optNetmailPosition_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optNetmailPosition_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optNetmailPosition_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optNetmailPosition_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optNetmailPosition_0.TabStop = True
		Me._optNetmailPosition_0.Checked = False
		Me._optNetmailPosition_0.Visible = True
		Me._optNetmailPosition_0.Name = "_optNetmailPosition_0"
		Me.fraNetmailPosition.Text = "Позиция в списке Эх"
		Me.fraNetmailPosition.Size = New System.Drawing.Size(146, 61)
		Me.fraNetmailPosition.Location = New System.Drawing.Point(5, 88)
		Me.fraNetmailPosition.TabIndex = 85
		Me.fraNetmailPosition.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraNetmailPosition.BackColor = System.Drawing.SystemColors.Control
		Me.fraNetmailPosition.Enabled = True
		Me.fraNetmailPosition.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraNetmailPosition.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraNetmailPosition.Visible = True
		Me.fraNetmailPosition.Name = "fraNetmailPosition"
		Me.fraFlags.Text = "Флаги нового письма по умолчанию"
		Me.fraFlags.ForeColor = System.Drawing.Color.Blue
		Me.fraFlags.Size = New System.Drawing.Size(455, 46)
		Me.fraFlags.Location = New System.Drawing.Point(8, 160)
		Me.fraFlags.TabIndex = 40
		Me.fraFlags.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraFlags.BackColor = System.Drawing.SystemColors.Control
		Me.fraFlags.Enabled = True
		Me.fraFlags.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraFlags.Visible = True
		Me.fraFlags.Name = "fraFlags"
		Me.lblPathNm.Text = "Пути к NetMail директориям:"
		Me.lblPathNm.Size = New System.Drawing.Size(145, 13)
		Me.lblPathNm.Location = New System.Drawing.Point(5, 0)
		Me.lblPathNm.TabIndex = 39
		Me.lblPathNm.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPathNm.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPathNm.BackColor = System.Drawing.SystemColors.Control
		Me.lblPathNm.Enabled = True
		Me.lblPathNm.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPathNm.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPathNm.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPathNm.UseMnemonic = True
		Me.lblPathNm.Visible = True
		Me.lblPathNm.AutoSize = True
		Me.lblPathNm.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPathNm.Name = "lblPathNm"
		Me._op_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._op_2.Size = New System.Drawing.Size(480, 209)
		Me._op_2.Location = New System.Drawing.Point(16, 56)
		Me._op_2.TabIndex = 9
		Me._op_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._op_2.Dock = System.Windows.Forms.DockStyle.None
		Me._op_2.BackColor = System.Drawing.SystemColors.Control
		Me._op_2.CausesValidation = True
		Me._op_2.Enabled = True
		Me._op_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._op_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._op_2.TabStop = True
		Me._op_2.Visible = True
		Me._op_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._op_2.Name = "_op_2"
		Me.cmdAddColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAddColor.Text = "&Add"
		Me.cmdAddColor.Size = New System.Drawing.Size(43, 18)
		Me.cmdAddColor.Location = New System.Drawing.Point(318, 48)
		Me.cmdAddColor.TabIndex = 91
		Me.cmdAddColor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAddColor.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAddColor.CausesValidation = True
		Me.cmdAddColor.Enabled = True
		Me.cmdAddColor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAddColor.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAddColor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAddColor.TabStop = True
		Me.cmdAddColor.Name = "cmdAddColor"
		Me.cmdDelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdDelColor.Text = "&Del"
		Me.cmdDelColor.Size = New System.Drawing.Size(43, 18)
		Me.cmdDelColor.Location = New System.Drawing.Point(384, 50)
		Me.cmdDelColor.TabIndex = 90
		Me.cmdDelColor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDelColor.BackColor = System.Drawing.SystemColors.Control
		Me.cmdDelColor.CausesValidation = True
		Me.cmdDelColor.Enabled = True
		Me.cmdDelColor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdDelColor.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDelColor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdDelColor.TabStop = True
		Me.cmdDelColor.Name = "cmdDelColor"
		Me.fraSemple.Text = "Пример"
		Me.fraSemple.ForeColor = System.Drawing.Color.Blue
		Me.fraSemple.Size = New System.Drawing.Size(161, 113)
		Me.fraSemple.Location = New System.Drawing.Point(300, 80)
		Me.fraSemple.TabIndex = 43
		Me.fraSemple.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSemple.BackColor = System.Drawing.SystemColors.Control
		Me.fraSemple.Enabled = True
		Me.fraSemple.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSemple.Visible = True
		Me.fraSemple.Name = "fraSemple"
		rtfSample.OcxState = CType(resources.GetObject("rtfSample.OcxState"), System.Windows.Forms.AxHost.State)
		Me.rtfSample.Size = New System.Drawing.Size(151, 94)
		Me.rtfSample.Location = New System.Drawing.Point(5, 14)
		Me.rtfSample.TabIndex = 44
		Me.rtfSample.Name = "rtfSample"
		Me.fraColors.Text = "Цветовая схема сообщения"
		Me.fraColors.ForeColor = System.Drawing.Color.Blue
		Me.fraColors.Size = New System.Drawing.Size(157, 64)
		Me.fraColors.Location = New System.Drawing.Point(300, 8)
		Me.fraColors.TabIndex = 32
		Me.fraColors.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraColors.BackColor = System.Drawing.SystemColors.Control
		Me.fraColors.Enabled = True
		Me.fraColors.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraColors.Visible = True
		Me.fraColors.Name = "fraColors"
		Me.cboColorsSheme.Size = New System.Drawing.Size(127, 21)
		Me.cboColorsSheme.Location = New System.Drawing.Point(12, 14)
		Me.cboColorsSheme.TabIndex = 33
		Me.cboColorsSheme.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboColorsSheme.BackColor = System.Drawing.SystemColors.Window
		Me.cboColorsSheme.CausesValidation = True
		Me.cboColorsSheme.Enabled = True
		Me.cboColorsSheme.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboColorsSheme.IntegralHeight = True
		Me.cboColorsSheme.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboColorsSheme.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboColorsSheme.Sorted = False
		Me.cboColorsSheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboColorsSheme.TabStop = True
		Me.cboColorsSheme.Visible = True
		Me.cboColorsSheme.Name = "cboColorsSheme"
		Me._fraMsgColors_0.Text = "Список Сообщений"
		Me._fraMsgColors_0.ForeColor = System.Drawing.Color.Blue
		Me._fraMsgColors_0.Size = New System.Drawing.Size(289, 65)
		Me._fraMsgColors_0.Location = New System.Drawing.Point(8, 8)
		Me._fraMsgColors_0.TabIndex = 19
		Me.ToolTip1.SetToolTip(Me._fraMsgColors_0, "Подсветка заголовков сообщений в дереве")
		Me._fraMsgColors_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraMsgColors_0.BackColor = System.Drawing.SystemColors.Control
		Me._fraMsgColors_0.Enabled = True
		Me._fraMsgColors_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraMsgColors_0.Visible = True
		Me._fraMsgColors_0.Name = "_fraMsgColors_0"
		Me.cmdMyMsgs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdMyMsgs.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.cmdMyMsgs.Size = New System.Drawing.Size(17, 17)
		Me.cmdMyMsgs.Location = New System.Drawing.Point(162, 42)
		Me.cmdMyMsgs.TabIndex = 99
		Me.cmdMyMsgs.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMyMsgs.CausesValidation = True
		Me.cmdMyMsgs.Enabled = True
		Me.cmdMyMsgs.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdMyMsgs.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdMyMsgs.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdMyMsgs.TabStop = True
		Me.cmdMyMsgs.Name = "cmdMyMsgs"
		Me.cmdRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRules.BackColor = System.Drawing.Color.FromARGB(255, 128, 0)
		Me.cmdRules.Size = New System.Drawing.Size(17, 17)
		Me.cmdRules.Location = New System.Drawing.Point(8, 40)
		Me.cmdRules.TabIndex = 21
		Me.cmdRules.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdRules.CausesValidation = True
		Me.cmdRules.Enabled = True
		Me.cmdRules.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRules.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRules.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRules.TabStop = True
		Me.cmdRules.Name = "cmdRules"
		Me.cmdModerator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdModerator.BackColor = System.Drawing.Color.Green
		Me.cmdModerator.Size = New System.Drawing.Size(17, 17)
		Me.cmdModerator.Location = New System.Drawing.Point(8, 16)
		Me.cmdModerator.TabIndex = 20
		Me.cmdModerator.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdModerator.CausesValidation = True
		Me.cmdModerator.Enabled = True
		Me.cmdModerator.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdModerator.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdModerator.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdModerator.TabStop = True
		Me.cmdModerator.Name = "cmdModerator"
		Me.lblMyMsgs.Text = "Мои Сообщения"
		Me.lblMyMsgs.Size = New System.Drawing.Size(82, 13)
		Me.lblMyMsgs.Location = New System.Drawing.Point(186, 45)
		Me.lblMyMsgs.TabIndex = 100
		Me.lblMyMsgs.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMyMsgs.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMyMsgs.BackColor = System.Drawing.SystemColors.Control
		Me.lblMyMsgs.Enabled = True
		Me.lblMyMsgs.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMyMsgs.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMyMsgs.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMyMsgs.UseMnemonic = True
		Me.lblMyMsgs.Visible = True
		Me.lblMyMsgs.AutoSize = True
		Me.lblMyMsgs.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMyMsgs.Name = "lblMyMsgs"
		Me.lblMsgModeraror.Text = "Сообщения (Ко)Модератора"
		Me.lblMsgModeraror.Size = New System.Drawing.Size(142, 13)
		Me.lblMsgModeraror.Location = New System.Drawing.Point(32, 20)
		Me.lblMsgModeraror.TabIndex = 23
		Me.lblMsgModeraror.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMsgModeraror.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMsgModeraror.BackColor = System.Drawing.SystemColors.Control
		Me.lblMsgModeraror.Enabled = True
		Me.lblMsgModeraror.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMsgModeraror.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMsgModeraror.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMsgModeraror.UseMnemonic = True
		Me.lblMsgModeraror.Visible = True
		Me.lblMsgModeraror.AutoSize = True
		Me.lblMsgModeraror.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMsgModeraror.Name = "lblMsgModeraror"
		Me.lblRules.Text = "Правила конференции"
		Me.lblRules.Size = New System.Drawing.Size(115, 13)
		Me.lblRules.Location = New System.Drawing.Point(32, 45)
		Me.lblRules.TabIndex = 22
		Me.lblRules.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRules.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblRules.BackColor = System.Drawing.SystemColors.Control
		Me.lblRules.Enabled = True
		Me.lblRules.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblRules.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRules.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRules.UseMnemonic = True
		Me.lblRules.Visible = True
		Me.lblRules.AutoSize = True
		Me.lblRules.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblRules.Name = "lblRules"
		Me._fraMsgColors_1.Text = "Просмотр Сообщения"
		Me._fraMsgColors_1.ForeColor = System.Drawing.Color.Blue
		Me._fraMsgColors_1.Size = New System.Drawing.Size(289, 113)
		Me._fraMsgColors_1.Location = New System.Drawing.Point(8, 80)
		Me._fraMsgColors_1.TabIndex = 10
		Me._fraMsgColors_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._fraMsgColors_1.BackColor = System.Drawing.SystemColors.Control
		Me._fraMsgColors_1.Enabled = True
		Me._fraMsgColors_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._fraMsgColors_1.Visible = True
		Me._fraMsgColors_1.Name = "_fraMsgColors_1"
		Me.cmdOriginColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOriginColor.BackColor = System.Drawing.SystemColors.ControlLight
		Me.cmdOriginColor.Size = New System.Drawing.Size(17, 17)
		Me.cmdOriginColor.Location = New System.Drawing.Point(160, 85)
		Me.cmdOriginColor.TabIndex = 80
		Me.cmdOriginColor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOriginColor.CausesValidation = True
		Me.cmdOriginColor.Enabled = True
		Me.cmdOriginColor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOriginColor.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOriginColor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOriginColor.TabStop = True
		Me.cmdOriginColor.Name = "cmdOriginColor"
		Me.cmdTirlineColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdTirlineColor.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.cmdTirlineColor.Size = New System.Drawing.Size(17, 17)
		Me.cmdTirlineColor.Location = New System.Drawing.Point(160, 50)
		Me.cmdTirlineColor.TabIndex = 79
		Me.cmdTirlineColor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdTirlineColor.CausesValidation = True
		Me.cmdTirlineColor.Enabled = True
		Me.cmdTirlineColor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdTirlineColor.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdTirlineColor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdTirlineColor.TabStop = True
		Me.cmdTirlineColor.Name = "cmdTirlineColor"
		Me.cmdTaglineColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdTaglineColor.BackColor = System.Drawing.SystemColors.ControlLight
		Me.cmdTaglineColor.Size = New System.Drawing.Size(17, 17)
		Me.cmdTaglineColor.Location = New System.Drawing.Point(160, 15)
		Me.cmdTaglineColor.TabIndex = 78
		Me.cmdTaglineColor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdTaglineColor.CausesValidation = True
		Me.cmdTaglineColor.Enabled = True
		Me.cmdTaglineColor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdTaglineColor.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdTaglineColor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdTaglineColor.TabStop = True
		Me.cmdTaglineColor.Name = "cmdTaglineColor"
		Me.cmdAlienCitat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAlienCitat.BackColor = System.Drawing.Color.Yellow
		Me.cmdAlienCitat.Size = New System.Drawing.Size(17, 17)
		Me.cmdAlienCitat.Location = New System.Drawing.Point(8, 88)
		Me.cmdAlienCitat.TabIndex = 14
		Me.cmdAlienCitat.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAlienCitat.CausesValidation = True
		Me.cmdAlienCitat.Enabled = True
		Me.cmdAlienCitat.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAlienCitat.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAlienCitat.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAlienCitat.TabStop = True
		Me.cmdAlienCitat.Name = "cmdAlienCitat"
		Me.cmdMyCitat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdMyCitat.BackColor = System.Drawing.Color.FromARGB(128, 255, 128)
		Me.cmdMyCitat.Size = New System.Drawing.Size(17, 17)
		Me.cmdMyCitat.Location = New System.Drawing.Point(8, 64)
		Me.cmdMyCitat.TabIndex = 13
		Me.cmdMyCitat.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMyCitat.CausesValidation = True
		Me.cmdMyCitat.Enabled = True
		Me.cmdMyCitat.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdMyCitat.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdMyCitat.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdMyCitat.TabStop = True
		Me.cmdMyCitat.Name = "cmdMyCitat"
		Me.cmdMainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdMainText.BackColor = System.Drawing.Color.Black
		Me.cmdMainText.Size = New System.Drawing.Size(17, 17)
		Me.cmdMainText.Location = New System.Drawing.Point(8, 16)
		Me.cmdMainText.TabIndex = 12
		Me.cmdMainText.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMainText.CausesValidation = True
		Me.cmdMainText.Enabled = True
		Me.cmdMainText.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdMainText.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdMainText.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdMainText.TabStop = True
		Me.cmdMainText.Name = "cmdMainText"
		Me.cmdBackMessageColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBackMessageColor.BackColor = System.Drawing.Color.White
		Me.cmdBackMessageColor.Size = New System.Drawing.Size(17, 17)
		Me.cmdBackMessageColor.Location = New System.Drawing.Point(8, 40)
		Me.cmdBackMessageColor.TabIndex = 11
		Me.cmdBackMessageColor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdBackMessageColor.CausesValidation = True
		Me.cmdBackMessageColor.Enabled = True
		Me.cmdBackMessageColor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBackMessageColor.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBackMessageColor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBackMessageColor.TabStop = True
		Me.cmdBackMessageColor.Name = "cmdBackMessageColor"
		Me.lblOriginColor.Text = "Цвет Ориджина"
		Me.lblOriginColor.Size = New System.Drawing.Size(80, 13)
		Me.lblOriginColor.Location = New System.Drawing.Point(185, 90)
		Me.lblOriginColor.TabIndex = 83
		Me.lblOriginColor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblOriginColor.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblOriginColor.BackColor = System.Drawing.SystemColors.Control
		Me.lblOriginColor.Enabled = True
		Me.lblOriginColor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblOriginColor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblOriginColor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblOriginColor.UseMnemonic = True
		Me.lblOriginColor.Visible = True
		Me.lblOriginColor.AutoSize = True
		Me.lblOriginColor.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblOriginColor.Name = "lblOriginColor"
		Me.lblTirlineColor.Text = "Цвет Таглайна (...)"
		Me.lblTirlineColor.Size = New System.Drawing.Size(94, 13)
		Me.lblTirlineColor.Location = New System.Drawing.Point(185, 55)
		Me.lblTirlineColor.TabIndex = 82
		Me.lblTirlineColor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTirlineColor.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTirlineColor.BackColor = System.Drawing.SystemColors.Control
		Me.lblTirlineColor.Enabled = True
		Me.lblTirlineColor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTirlineColor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTirlineColor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTirlineColor.UseMnemonic = True
		Me.lblTirlineColor.Visible = True
		Me.lblTirlineColor.AutoSize = True
		Me.lblTirlineColor.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTirlineColor.Name = "lblTirlineColor"
		Me.lblTaglineColor.Text = "Цвет Тирлайна (---)"
		Me.lblTaglineColor.Size = New System.Drawing.Size(95, 13)
		Me.lblTaglineColor.Location = New System.Drawing.Point(185, 20)
		Me.lblTaglineColor.TabIndex = 81
		Me.lblTaglineColor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTaglineColor.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblTaglineColor.BackColor = System.Drawing.SystemColors.Control
		Me.lblTaglineColor.Enabled = True
		Me.lblTaglineColor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblTaglineColor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTaglineColor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTaglineColor.UseMnemonic = True
		Me.lblTaglineColor.Visible = True
		Me.lblTaglineColor.AutoSize = True
		Me.lblTaglineColor.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTaglineColor.Name = "lblTaglineColor"
		Me.lblMainText.Text = "Основной Текст"
		Me.lblMainText.Size = New System.Drawing.Size(83, 13)
		Me.lblMainText.Location = New System.Drawing.Point(32, 20)
		Me.lblMainText.TabIndex = 18
		Me.lblMainText.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMainText.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMainText.BackColor = System.Drawing.SystemColors.Control
		Me.lblMainText.Enabled = True
		Me.lblMainText.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMainText.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMainText.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMainText.UseMnemonic = True
		Me.lblMainText.Visible = True
		Me.lblMainText.AutoSize = True
		Me.lblMainText.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMainText.Name = "lblMainText"
		Me.lblMyCitat.Text = "Цитаты автора"
		Me.lblMyCitat.Size = New System.Drawing.Size(76, 13)
		Me.lblMyCitat.Location = New System.Drawing.Point(32, 65)
		Me.lblMyCitat.TabIndex = 17
		Me.lblMyCitat.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMyCitat.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMyCitat.BackColor = System.Drawing.SystemColors.Control
		Me.lblMyCitat.Enabled = True
		Me.lblMyCitat.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMyCitat.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMyCitat.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMyCitat.UseMnemonic = True
		Me.lblMyCitat.Visible = True
		Me.lblMyCitat.AutoSize = True
		Me.lblMyCitat.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMyCitat.Name = "lblMyCitat"
		Me.lblAlienCitat.Text = "Цитирование автора"
		Me.lblAlienCitat.Size = New System.Drawing.Size(105, 13)
		Me.lblAlienCitat.Location = New System.Drawing.Point(32, 90)
		Me.lblAlienCitat.TabIndex = 16
		Me.lblAlienCitat.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAlienCitat.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAlienCitat.BackColor = System.Drawing.SystemColors.Control
		Me.lblAlienCitat.Enabled = True
		Me.lblAlienCitat.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAlienCitat.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAlienCitat.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAlienCitat.UseMnemonic = True
		Me.lblAlienCitat.Visible = True
		Me.lblAlienCitat.AutoSize = True
		Me.lblAlienCitat.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAlienCitat.Name = "lblAlienCitat"
		Me.lblBackMessageColor.Text = "Цвет фона"
		Me.lblBackMessageColor.Size = New System.Drawing.Size(54, 13)
		Me.lblBackMessageColor.Location = New System.Drawing.Point(32, 40)
		Me.lblBackMessageColor.TabIndex = 15
		Me.lblBackMessageColor.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBackMessageColor.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblBackMessageColor.BackColor = System.Drawing.SystemColors.Control
		Me.lblBackMessageColor.Enabled = True
		Me.lblBackMessageColor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblBackMessageColor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblBackMessageColor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblBackMessageColor.UseMnemonic = True
		Me.lblBackMessageColor.Visible = True
		Me.lblBackMessageColor.AutoSize = True
		Me.lblBackMessageColor.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblBackMessageColor.Name = "lblBackMessageColor"
		Me._op_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._op_1.Size = New System.Drawing.Size(478, 215)
		Me._op_1.Location = New System.Drawing.Point(16, 56)
		Me._op_1.TabIndex = 4
		Me._op_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._op_1.Dock = System.Windows.Forms.DockStyle.None
		Me._op_1.BackColor = System.Drawing.SystemColors.Control
		Me._op_1.CausesValidation = True
		Me._op_1.Enabled = True
		Me._op_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._op_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._op_1.TabStop = True
		Me._op_1.Visible = True
		Me._op_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._op_1.Name = "_op_1"
		Me._optTosser_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTosser_0.Text = "Areas.bbs"
		Me._optTosser_0.Size = New System.Drawing.Size(133, 16)
		Me._optTosser_0.Location = New System.Drawing.Point(282, 30)
		Me._optTosser_0.TabIndex = 89
		Me._optTosser_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optTosser_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optTosser_0.BackColor = System.Drawing.SystemColors.Control
		Me._optTosser_0.CausesValidation = True
		Me._optTosser_0.Enabled = True
		Me._optTosser_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optTosser_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optTosser_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optTosser_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optTosser_0.TabStop = True
		Me._optTosser_0.Checked = False
		Me._optTosser_0.Visible = True
		Me._optTosser_0.Name = "_optTosser_0"
		Me.fraTosser.Text = "Эхопроцессор/Тип Файла"
		Me.fraTosser.Size = New System.Drawing.Size(184, 198)
		Me.fraTosser.Location = New System.Drawing.Point(270, 10)
		Me.fraTosser.TabIndex = 88
		Me.fraTosser.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraTosser.BackColor = System.Drawing.SystemColors.Control
		Me.fraTosser.Enabled = True
		Me.fraTosser.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraTosser.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraTosser.Visible = True
		Me.fraTosser.Name = "fraTosser"
		Me.fraBase.Text = "Файл Конфигурации Эхопроцессора"
		Me.fraBase.ForeColor = System.Drawing.Color.Blue
		Me.fraBase.Size = New System.Drawing.Size(259, 50)
		Me.fraBase.Location = New System.Drawing.Point(5, 158)
		Me.fraBase.TabIndex = 35
		Me.fraBase.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraBase.BackColor = System.Drawing.SystemColors.Control
		Me.fraBase.Enabled = True
		Me.fraBase.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraBase.Visible = True
		Me.fraBase.Name = "fraBase"
		Me.cmdSelectBase.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdSelectBase.Size = New System.Drawing.Size(19, 19)
		Me.cmdSelectBase.Location = New System.Drawing.Point(233, 20)
		Me.cmdSelectBase.Image = CType(resources.GetObject("cmdSelectBase.Image"), System.Drawing.Image)
		Me.cmdSelectBase.TabIndex = 37
		Me.ToolTip1.SetToolTip(Me.cmdSelectBase, "Выбрать файл со списком эхоконференций")
		Me.cmdSelectBase.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSelectBase.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSelectBase.CausesValidation = True
		Me.cmdSelectBase.Enabled = True
		Me.cmdSelectBase.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSelectBase.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSelectBase.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSelectBase.TabStop = True
		Me.cmdSelectBase.Name = "cmdSelectBase"
		Me.txtBasePath.AutoSize = False
		Me.txtBasePath.Size = New System.Drawing.Size(226, 19)
		Me.txtBasePath.Location = New System.Drawing.Point(5, 20)
		Me.txtBasePath.TabIndex = 36
		Me.txtBasePath.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBasePath.AcceptsReturn = True
		Me.txtBasePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtBasePath.BackColor = System.Drawing.SystemColors.Window
		Me.txtBasePath.CausesValidation = True
		Me.txtBasePath.Enabled = True
		Me.txtBasePath.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtBasePath.HideSelection = True
		Me.txtBasePath.ReadOnly = False
		Me.txtBasePath.Maxlength = 0
		Me.txtBasePath.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtBasePath.MultiLine = False
		Me.txtBasePath.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtBasePath.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtBasePath.TabStop = True
		Me.txtBasePath.Visible = True
		Me.txtBasePath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtBasePath.Name = "txtBasePath"
		Me.fraMainSetup.Text = "Основные настройки"
		Me.fraMainSetup.ForeColor = System.Drawing.Color.Blue
		Me.fraMainSetup.Size = New System.Drawing.Size(259, 137)
		Me.fraMainSetup.Location = New System.Drawing.Point(5, 10)
		Me.fraMainSetup.TabIndex = 5
		Me.fraMainSetup.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraMainSetup.BackColor = System.Drawing.SystemColors.Control
		Me.fraMainSetup.Enabled = True
		Me.fraMainSetup.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraMainSetup.Visible = True
		Me.fraMainSetup.Name = "fraMainSetup"
		Me._cmdDel_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._cmdDel_1.Size = New System.Drawing.Size(21, 21)
		Me._cmdDel_1.Location = New System.Drawing.Point(231, 63)
		Me._cmdDel_1.Image = CType(resources.GetObject("_cmdDel_1.Image"), System.Drawing.Image)
		Me._cmdDel_1.TabIndex = 42
		Me.ToolTip1.SetToolTip(Me._cmdDel_1, "Удалить текущую АКА")
		Me._cmdDel_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdDel_1.BackColor = System.Drawing.SystemColors.Control
		Me._cmdDel_1.CausesValidation = True
		Me._cmdDel_1.Enabled = True
		Me._cmdDel_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdDel_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdDel_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdDel_1.TabStop = True
		Me._cmdDel_1.Name = "_cmdDel_1"
		Me._cmdDel_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._cmdDel_0.Size = New System.Drawing.Size(21, 21)
		Me._cmdDel_0.Location = New System.Drawing.Point(231, 37)
		Me._cmdDel_0.Image = CType(resources.GetObject("_cmdDel_0.Image"), System.Drawing.Image)
		Me._cmdDel_0.TabIndex = 41
		Me.ToolTip1.SetToolTip(Me._cmdDel_0, "Удалить текущее имя")
		Me._cmdDel_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdDel_0.BackColor = System.Drawing.SystemColors.Control
		Me._cmdDel_0.CausesValidation = True
		Me._cmdDel_0.Enabled = True
		Me._cmdDel_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdDel_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdDel_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdDel_0.TabStop = True
		Me._cmdDel_0.Name = "_cmdDel_0"
		Me._cmdAdd_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._cmdAdd_1.Size = New System.Drawing.Size(21, 21)
		Me._cmdAdd_1.Location = New System.Drawing.Point(210, 63)
		Me._cmdAdd_1.Image = CType(resources.GetObject("_cmdAdd_1.Image"), System.Drawing.Image)
		Me._cmdAdd_1.TabIndex = 31
		Me.ToolTip1.SetToolTip(Me._cmdAdd_1, "Добавить АКА")
		Me._cmdAdd_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdAdd_1.BackColor = System.Drawing.SystemColors.Control
		Me._cmdAdd_1.CausesValidation = True
		Me._cmdAdd_1.Enabled = True
		Me._cmdAdd_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdAdd_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdAdd_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdAdd_1.TabStop = True
		Me._cmdAdd_1.Name = "_cmdAdd_1"
		Me._cmdAdd_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._cmdAdd_0.Size = New System.Drawing.Size(21, 21)
		Me._cmdAdd_0.Location = New System.Drawing.Point(210, 37)
		Me._cmdAdd_0.Image = CType(resources.GetObject("_cmdAdd_0.Image"), System.Drawing.Image)
		Me._cmdAdd_0.TabIndex = 30
		Me.ToolTip1.SetToolTip(Me._cmdAdd_0, "Добавить имя")
		Me._cmdAdd_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdAdd_0.BackColor = System.Drawing.SystemColors.Control
		Me._cmdAdd_0.CausesValidation = True
		Me._cmdAdd_0.Enabled = True
		Me._cmdAdd_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdAdd_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdAdd_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdAdd_0.TabStop = True
		Me._cmdAdd_0.Name = "_cmdAdd_0"
		Me.cmdSelectSemaphore.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdSelectSemaphore.Size = New System.Drawing.Size(19, 19)
		Me.cmdSelectSemaphore.Location = New System.Drawing.Point(234, 105)
		Me.cmdSelectSemaphore.Image = CType(resources.GetObject("cmdSelectSemaphore.Image"), System.Drawing.Image)
		Me.cmdSelectSemaphore.TabIndex = 29
		Me.ToolTip1.SetToolTip(Me.cmdSelectSemaphore, "Выбрать флаг")
		Me.cmdSelectSemaphore.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSelectSemaphore.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSelectSemaphore.CausesValidation = True
		Me.cmdSelectSemaphore.Enabled = True
		Me.cmdSelectSemaphore.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSelectSemaphore.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSelectSemaphore.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSelectSemaphore.TabStop = True
		Me.cmdSelectSemaphore.Name = "cmdSelectSemaphore"
		Me.txtSemaphore.AutoSize = False
		Me.txtSemaphore.Size = New System.Drawing.Size(225, 19)
		Me.txtSemaphore.Location = New System.Drawing.Point(7, 105)
		Me.txtSemaphore.TabIndex = 28
		Me.txtSemaphore.Text = "c:\t-mail\flags\netmail.t-m"
		Me.txtSemaphore.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSemaphore.AcceptsReturn = True
		Me.txtSemaphore.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSemaphore.BackColor = System.Drawing.SystemColors.Window
		Me.txtSemaphore.CausesValidation = True
		Me.txtSemaphore.Enabled = True
		Me.txtSemaphore.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSemaphore.HideSelection = True
		Me.txtSemaphore.ReadOnly = False
		Me.txtSemaphore.Maxlength = 0
		Me.txtSemaphore.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSemaphore.MultiLine = False
		Me.txtSemaphore.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSemaphore.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSemaphore.TabStop = True
		Me.txtSemaphore.Visible = True
		Me.txtSemaphore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSemaphore.Name = "txtSemaphore"
		Me.cboAkAs.Size = New System.Drawing.Size(165, 21)
		Me.cboAkAs.Location = New System.Drawing.Point(42, 63)
		Me.cboAkAs.TabIndex = 25
		Me.cboAkAs.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboAkAs.BackColor = System.Drawing.SystemColors.Window
		Me.cboAkAs.CausesValidation = True
		Me.cboAkAs.Enabled = True
		Me.cboAkAs.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboAkAs.IntegralHeight = True
		Me.cboAkAs.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboAkAs.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboAkAs.Sorted = False
		Me.cboAkAs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboAkAs.TabStop = True
		Me.cboAkAs.Visible = True
		Me.cboAkAs.Name = "cboAkAs"
		Me.cboNames.Size = New System.Drawing.Size(165, 21)
		Me.cboNames.Location = New System.Drawing.Point(42, 37)
		Me.cboNames.TabIndex = 24
		Me.cboNames.Text = "cboNames"
		Me.cboNames.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboNames.BackColor = System.Drawing.SystemColors.Window
		Me.cboNames.CausesValidation = True
		Me.cboNames.Enabled = True
		Me.cboNames.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboNames.IntegralHeight = True
		Me.cboNames.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboNames.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboNames.Sorted = False
		Me.cboNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboNames.TabStop = True
		Me.cboNames.Visible = True
		Me.cboNames.Name = "cboNames"
		Me.txtMainAddress.AutoSize = False
		Me.txtMainAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtMainAddress.Size = New System.Drawing.Size(156, 19)
		Me.txtMainAddress.Location = New System.Drawing.Point(96, 16)
		Me.txtMainAddress.TabIndex = 6
		Me.txtMainAddress.Text = "2:5051/36.999"
		Me.txtMainAddress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMainAddress.AcceptsReturn = True
		Me.txtMainAddress.BackColor = System.Drawing.SystemColors.Window
		Me.txtMainAddress.CausesValidation = True
		Me.txtMainAddress.Enabled = True
		Me.txtMainAddress.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMainAddress.HideSelection = True
		Me.txtMainAddress.ReadOnly = False
		Me.txtMainAddress.Maxlength = 0
		Me.txtMainAddress.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMainAddress.MultiLine = False
		Me.txtMainAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMainAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMainAddress.TabStop = True
		Me.txtMainAddress.Visible = True
		Me.txtMainAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMainAddress.Name = "txtMainAddress"
		Me.lblSemaphore.Text = "Флаг нового письма:"
		Me.lblSemaphore.Size = New System.Drawing.Size(110, 13)
		Me.lblSemaphore.Location = New System.Drawing.Point(7, 91)
		Me.lblSemaphore.TabIndex = 27
		Me.lblSemaphore.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSemaphore.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblSemaphore.BackColor = System.Drawing.SystemColors.Control
		Me.lblSemaphore.Enabled = True
		Me.lblSemaphore.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblSemaphore.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblSemaphore.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblSemaphore.UseMnemonic = True
		Me.lblSemaphore.Visible = True
		Me.lblSemaphore.AutoSize = True
		Me.lblSemaphore.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblSemaphore.Name = "lblSemaphore"
		Me.lblAkAs.Text = "AKA:"
		Me.lblAkAs.Size = New System.Drawing.Size(24, 13)
		Me.lblAkAs.Location = New System.Drawing.Point(13, 67)
		Me.lblAkAs.TabIndex = 26
		Me.lblAkAs.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAkAs.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAkAs.BackColor = System.Drawing.SystemColors.Control
		Me.lblAkAs.Enabled = True
		Me.lblAkAs.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAkAs.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAkAs.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAkAs.UseMnemonic = True
		Me.lblAkAs.Visible = True
		Me.lblAkAs.AutoSize = True
		Me.lblAkAs.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAkAs.Name = "lblAkAs"
		Me.lblAddress.Text = "Основной Адрес:"
		Me.lblAddress.Size = New System.Drawing.Size(87, 13)
		Me.lblAddress.Location = New System.Drawing.Point(8, 17)
		Me.lblAddress.TabIndex = 8
		Me.lblAddress.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAddress.BackColor = System.Drawing.SystemColors.Control
		Me.lblAddress.Enabled = True
		Me.lblAddress.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAddress.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAddress.UseMnemonic = True
		Me.lblAddress.Visible = True
		Me.lblAddress.AutoSize = True
		Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAddress.Name = "lblAddress"
		Me.lblName.Text = "Имя:"
		Me.lblName.Size = New System.Drawing.Size(25, 13)
		Me.lblName.Location = New System.Drawing.Point(13, 40)
		Me.lblName.TabIndex = 7
		Me.lblName.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblName.BackColor = System.Drawing.SystemColors.Control
		Me.lblName.Enabled = True
		Me.lblName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblName.UseMnemonic = True
		Me.lblName.Visible = True
		Me.lblName.AutoSize = True
		Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblName.Name = "lblName"
		opTabStrip.OcxState = CType(resources.GetObject("opTabStrip.OcxState"), System.Windows.Forms.AxHost.State)
		Me.opTabStrip.Size = New System.Drawing.Size(492, 265)
		Me.opTabStrip.Location = New System.Drawing.Point(8, 8)
		Me.opTabStrip.TabIndex = 3
		Me.opTabStrip.Name = "opTabStrip"
		Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOK.Text = "&Ok"
		Me.cmdOK.Size = New System.Drawing.Size(76, 25)
		Me.cmdOK.Location = New System.Drawing.Point(204, 280)
		Me.cmdOK.TabIndex = 0
		Me.cmdOK.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOK.CausesValidation = True
		Me.cmdOK.Enabled = True
		Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOK.TabStop = True
		Me.cmdOK.Name = "cmdOK"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton = Me.cmdCancel
		Me.cmdCancel.Text = "&Отмена"
		Me.cmdCancel.Size = New System.Drawing.Size(76, 25)
		Me.cmdCancel.Location = New System.Drawing.Point(294, 280)
		Me.cmdCancel.TabIndex = 2
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdApply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdApply.Text = "&Принять"
		Me.cmdApply.Size = New System.Drawing.Size(76, 25)
		Me.cmdApply.Location = New System.Drawing.Point(384, 280)
		Me.cmdApply.TabIndex = 1
		Me.cmdApply.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdApply.BackColor = System.Drawing.SystemColors.Control
		Me.cmdApply.CausesValidation = True
		Me.cmdApply.Enabled = True
		Me.cmdApply.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdApply.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdApply.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdApply.TabStop = True
		Me.cmdApply.Name = "cmdApply"
		Me.cmdImportConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdImportConfig.Text = "&Import..."
		Me.cmdImportConfig.Size = New System.Drawing.Size(76, 25)
		Me.cmdImportConfig.Location = New System.Drawing.Point(30, 280)
		Me.cmdImportConfig.TabIndex = 34
		Me.ToolTip1.SetToolTip(Me.cmdImportConfig, "Импортировать конфигурацию из Golded")
		Me.cmdImportConfig.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdImportConfig.BackColor = System.Drawing.SystemColors.Control
		Me.cmdImportConfig.CausesValidation = True
		Me.cmdImportConfig.Enabled = True
		Me.cmdImportConfig.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdImportConfig.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdImportConfig.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdImportConfig.TabStop = True
		Me.cmdImportConfig.Name = "cmdImportConfig"
		Me.mnuPopupNetmail.Text = "mnuPopupNetmail"
		Me.mnuPopupNetmail.Visible = False
		Me.mnuPopupNetmail.Checked = False
		Me.mnuPopupNetmail.Enabled = True
		Me.mnuPopupNetmail.MDIList = False
		Me.mnuPopupNetmailAdd.Text = "Добавить"
		Me.mnuPopupNetmailAdd.Checked = False
		Me.mnuPopupNetmailAdd.Enabled = True
		Me.mnuPopupNetmailAdd.Visible = True
		Me.mnuPopupNetmailAdd.MDIList = False
		Me.mnuPopupNetmailChange.Text = "Изменить"
		Me.mnuPopupNetmailChange.Enabled = False
		Me.mnuPopupNetmailChange.Checked = False
		Me.mnuPopupNetmailChange.Visible = True
		Me.mnuPopupNetmailChange.MDIList = False
		Me.mnuPopupNetmailDelete.Text = "Удалить"
		Me.mnuPopupNetmailDelete.Checked = False
		Me.mnuPopupNetmailDelete.Enabled = True
		Me.mnuPopupNetmailDelete.Visible = True
		Me.mnuPopupNetmailDelete.MDIList = False
		Me.Controls.Add(_op_9)
		Me.Controls.Add(_op_8)
		Me.Controls.Add(_op_7)
		Me.Controls.Add(_op_6)
		Me.Controls.Add(_op_5)
		Me.Controls.Add(_op_4)
		Me.Controls.Add(tabsImages)
		Me.Controls.Add(_op_3)
		Me.Controls.Add(_op_2)
		Me.Controls.Add(_op_1)
		Me.Controls.Add(opTabStrip)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdApply)
		Me.Controls.Add(cmdImportConfig)
		Me._op_9.Controls.Add(fraMsgFooter)
		Me._op_9.Controls.Add(fraMsgHeader)
		Me.fraMsgFooter.Controls.Add(txtSignature)
		Me.fraMsgFooter.Controls.Add(txtTagLine)
		Me.fraMsgFooter.Controls.Add(txtTirLine)
		Me.fraMsgFooter.Controls.Add(lblSignature)
		Me.fraMsgFooter.Controls.Add(lblTagLine)
		Me.fraMsgFooter.Controls.Add(lblTirLine)
		Me.fraMsgHeader.Controls.Add(txtMoved)
		Me.fraMsgHeader.Controls.Add(txtQuote)
		Me.fraMsgHeader.Controls.Add(txtChanged)
		Me.fraMsgHeader.Controls.Add(txtGreeting)
		Me.fraMsgHeader.Controls.Add(lblMoved)
		Me.fraMsgHeader.Controls.Add(lblQuote)
		Me.fraMsgHeader.Controls.Add(lblChanged)
		Me.fraMsgHeader.Controls.Add(lblGreeting)
		Me._op_8.Controls.Add(fraHotkeys)
		Me.fraHotkeys.Controls.Add(txtDragHKey)
		Me.fraHotkeys.Controls.Add(cboHotKey)
		Me.fraHotkeys.Controls.Add(fraKeyActions)
		Me.fraHotkeys.Controls.Add(lblHotkeySample)
		Me.fraHotkeys.Controls.Add(lblAddHK)
		Me.fraKeyActions.Controls.Add(_txtKeyAction_0)
		Me.fraKeyActions.Controls.Add(_lblActions_0)
		Me._op_7.Controls.Add(_optStartupType_0)
		Me._op_7.Controls.Add(_optStartupType_1)
		Me._op_7.Controls.Add(fraExtProcess)
		Me.fraExtProcess.Controls.Add(fraStartType)
		Me.fraExtProcess.Controls.Add(_cmdSelectProcess_0)
		Me.fraExtProcess.Controls.Add(txtExtProcess)
		Me.fraExtProcess.Controls.Add(chkExtProcess)
		Me.fraExtProcess.Controls.Add(txtExtProcessParams)
		Me.fraExtProcess.Controls.Add(lblParams)
		Me._op_6.Controls.Add(fraNp)
		Me.fraNp.Controls.Add(fraExample)
		Me.fraNp.Controls.Add(fraControlNp)
		Me.fraNp.Controls.Add(txtNotLoading)
		Me.fraNp.Controls.Add(txtUptime)
		Me.fraNp.Controls.Add(txtStopped)
		Me.fraNp.Controls.Add(txtNpPrefix)
		Me.fraNp.Controls.Add(lblWinamp)
		Me.fraNp.Controls.Add(lblUptime)
		Me.fraNp.Controls.Add(lblStopped)
		Me.fraNp.Controls.Add(lblPrefix)
		Me.fraExample.Controls.Add(txtExample)
		Me.fraExample.Controls.Add(lblExample)
		Me.fraControlNp.Controls.Add(chkUptimeEnabled)
		Me.fraControlNp.Controls.Add(chkNpEnabled)
		Me._op_5.Controls.Add(_cmdSelectFont_6)
		Me._op_5.Controls.Add(_cmdSelectFont_5)
		Me._op_5.Controls.Add(_cmdSelectFont_4)
		Me._op_5.Controls.Add(_cmdSelectFont_3)
		Me._op_5.Controls.Add(_cmdSelectFont_2)
		Me._op_5.Controls.Add(_cmdSelectFont_1)
		Me._op_5.Controls.Add(_cmdSelectFont_0)
		Me._op_5.Controls.Add(fraFonts)
		Me.fraFonts.Controls.Add(lblSubjFont)
		Me.fraFonts.Controls.Add(lblSubj)
		Me.fraFonts.Controls.Add(lblToFont)
		Me.fraFonts.Controls.Add(lblTO)
		Me.fraFonts.Controls.Add(lblFromFont)
		Me.fraFonts.Controls.Add(lblFrom)
		Me.fraFonts.Controls.Add(lblEditorWindowFont)
		Me.fraFonts.Controls.Add(lblEditorFont)
		Me.fraFonts.Controls.Add(lblMainTextViewFont)
		Me.fraFonts.Controls.Add(lblMainViewer)
		Me.fraFonts.Controls.Add(lblTreeViewFont)
		Me.fraFonts.Controls.Add(lblTreeFont)
		Me.fraFonts.Controls.Add(lblEcholistFont)
		Me.fraFonts.Controls.Add(lblEchoFont)
		Me._op_4.Controls.Add(fraReplacmentsButtons)
		Me._op_4.Controls.Add(fraReplacments)
		Me.fraReplacmentsButtons.Controls.Add(cmdAddSymbol)
		Me.fraReplacmentsButtons.Controls.Add(cmdDelSymbol)
		Me.fraReplacmentsButtons.Controls.Add(cmdEditSymbol)
		Me.fraReplacments.Controls.Add(lstReplacments)
		Me._op_3.Controls.Add(_chkFlags_0)
		Me._op_3.Controls.Add(_chkFlags_1)
		Me._op_3.Controls.Add(_chkFlags_2)
		Me._op_3.Controls.Add(_chkFlags_3)
		Me._op_3.Controls.Add(_chkFlags_4)
		Me._op_3.Controls.Add(_chkFlags_5)
		Me._op_3.Controls.Add(lvNetmailDirs)
		Me._op_3.Controls.Add(_optNetmailPosition_1)
		Me._op_3.Controls.Add(_optNetmailPosition_0)
		Me._op_3.Controls.Add(fraNetmailPosition)
		Me._op_3.Controls.Add(fraFlags)
		Me._op_3.Controls.Add(lblPathNm)
		Me._op_2.Controls.Add(cmdAddColor)
		Me._op_2.Controls.Add(cmdDelColor)
		Me._op_2.Controls.Add(fraSemple)
		Me._op_2.Controls.Add(fraColors)
		Me._op_2.Controls.Add(_fraMsgColors_0)
		Me._op_2.Controls.Add(_fraMsgColors_1)
		Me.fraSemple.Controls.Add(rtfSample)
		Me.fraColors.Controls.Add(cboColorsSheme)
		Me._fraMsgColors_0.Controls.Add(cmdMyMsgs)
		Me._fraMsgColors_0.Controls.Add(cmdRules)
		Me._fraMsgColors_0.Controls.Add(cmdModerator)
		Me._fraMsgColors_0.Controls.Add(lblMyMsgs)
		Me._fraMsgColors_0.Controls.Add(lblMsgModeraror)
		Me._fraMsgColors_0.Controls.Add(lblRules)
		Me._fraMsgColors_1.Controls.Add(cmdOriginColor)
		Me._fraMsgColors_1.Controls.Add(cmdTirlineColor)
		Me._fraMsgColors_1.Controls.Add(cmdTaglineColor)
		Me._fraMsgColors_1.Controls.Add(cmdAlienCitat)
		Me._fraMsgColors_1.Controls.Add(cmdMyCitat)
		Me._fraMsgColors_1.Controls.Add(cmdMainText)
		Me._fraMsgColors_1.Controls.Add(cmdBackMessageColor)
		Me._fraMsgColors_1.Controls.Add(lblOriginColor)
		Me._fraMsgColors_1.Controls.Add(lblTirlineColor)
		Me._fraMsgColors_1.Controls.Add(lblTaglineColor)
		Me._fraMsgColors_1.Controls.Add(lblMainText)
		Me._fraMsgColors_1.Controls.Add(lblMyCitat)
		Me._fraMsgColors_1.Controls.Add(lblAlienCitat)
		Me._fraMsgColors_1.Controls.Add(lblBackMessageColor)
		Me._op_1.Controls.Add(_optTosser_0)
		Me._op_1.Controls.Add(fraTosser)
		Me._op_1.Controls.Add(fraBase)
		Me._op_1.Controls.Add(fraMainSetup)
		Me.fraBase.Controls.Add(cmdSelectBase)
		Me.fraBase.Controls.Add(txtBasePath)
		Me.fraMainSetup.Controls.Add(_cmdDel_1)
		Me.fraMainSetup.Controls.Add(_cmdDel_0)
		Me.fraMainSetup.Controls.Add(_cmdAdd_1)
		Me.fraMainSetup.Controls.Add(_cmdAdd_0)
		Me.fraMainSetup.Controls.Add(cmdSelectSemaphore)
		Me.fraMainSetup.Controls.Add(txtSemaphore)
		Me.fraMainSetup.Controls.Add(cboAkAs)
		Me.fraMainSetup.Controls.Add(cboNames)
		Me.fraMainSetup.Controls.Add(txtMainAddress)
		Me.fraMainSetup.Controls.Add(lblSemaphore)
		Me.fraMainSetup.Controls.Add(lblAkAs)
		Me.fraMainSetup.Controls.Add(lblAddress)
		Me.fraMainSetup.Controls.Add(lblName)
		Me.chkFlags.SetIndex(_chkFlags_0, CType(0, Short))
		Me.chkFlags.SetIndex(_chkFlags_1, CType(1, Short))
		Me.chkFlags.SetIndex(_chkFlags_2, CType(2, Short))
		Me.chkFlags.SetIndex(_chkFlags_3, CType(3, Short))
		Me.chkFlags.SetIndex(_chkFlags_4, CType(4, Short))
		Me.chkFlags.SetIndex(_chkFlags_5, CType(5, Short))
		Me.cmdAdd.SetIndex(_cmdAdd_1, CType(1, Short))
		Me.cmdAdd.SetIndex(_cmdAdd_0, CType(0, Short))
		Me.cmdDel.SetIndex(_cmdDel_1, CType(1, Short))
		Me.cmdDel.SetIndex(_cmdDel_0, CType(0, Short))
		Me.cmdSelectFont.SetIndex(_cmdSelectFont_6, CType(6, Short))
		Me.cmdSelectFont.SetIndex(_cmdSelectFont_5, CType(5, Short))
		Me.cmdSelectFont.SetIndex(_cmdSelectFont_4, CType(4, Short))
		Me.cmdSelectFont.SetIndex(_cmdSelectFont_3, CType(3, Short))
		Me.cmdSelectFont.SetIndex(_cmdSelectFont_2, CType(2, Short))
		Me.cmdSelectFont.SetIndex(_cmdSelectFont_1, CType(1, Short))
		Me.cmdSelectFont.SetIndex(_cmdSelectFont_0, CType(0, Short))
		Me.cmdSelectProcess.SetIndex(_cmdSelectProcess_0, CType(0, Short))
		Me.fraMsgColors.SetIndex(_fraMsgColors_0, CType(0, Short))
		Me.fraMsgColors.SetIndex(_fraMsgColors_1, CType(1, Short))
		Me.lblActions.SetIndex(_lblActions_0, CType(0, Short))
		Me.op.SetIndex(_op_9, CType(9, Short))
		Me.op.SetIndex(_op_8, CType(8, Short))
		Me.op.SetIndex(_op_7, CType(7, Short))
		Me.op.SetIndex(_op_6, CType(6, Short))
		Me.op.SetIndex(_op_5, CType(5, Short))
		Me.op.SetIndex(_op_4, CType(4, Short))
		Me.op.SetIndex(_op_3, CType(3, Short))
		Me.op.SetIndex(_op_2, CType(2, Short))
		Me.op.SetIndex(_op_1, CType(1, Short))
		Me.optNetmailPosition.SetIndex(_optNetmailPosition_1, CType(1, Short))
		Me.optNetmailPosition.SetIndex(_optNetmailPosition_0, CType(0, Short))
		Me.optStartupType.SetIndex(_optStartupType_0, CType(0, Short))
		Me.optStartupType.SetIndex(_optStartupType_1, CType(1, Short))
		Me.optTosser.SetIndex(_optTosser_0, CType(0, Short))
		Me.txtKeyAction.SetIndex(_txtKeyAction_0, CType(0, Short))
		CType(Me.txtKeyAction, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.optTosser, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.optStartupType, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.optNetmailPosition, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.op, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lblActions, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.fraMsgColors, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdSelectProcess, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdSelectFont, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdDel, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdAdd, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.chkFlags, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.opTabStrip, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.rtfSample, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lvNetmailDirs, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tabsImages, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lstReplacments, System.ComponentModel.ISupportInitialize).EndInit()
		Me.mnuPopupNetmail.Index = 0
		MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuPopupNetmail})
		Me.mnuPopupNetmailAdd.Index = 0
		Me.mnuPopupNetmailChange.Index = 1
		Me.mnuPopupNetmailDelete.Index = 2
		mnuPopupNetmail.MenuItems.AddRange(New System.Windows.Forms.MenuItem(){Me.mnuPopupNetmailAdd, Me.mnuPopupNetmailChange, Me.mnuPopupNetmailDelete})
		Me.Menu = MainMenu1
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmOptions
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmOptions
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmOptions()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
	Private Structure ColorSheme 'Структура используется для удобства передачи параметров
		Dim cmdModerator As Integer
		Dim cmdRules As Integer
		Dim cmdMainText As Integer
		Dim cmdBackMessageColor As Integer
		Dim cmdAlienCitat As Integer
		Dim cmdMyCitat As Integer
		Dim cmdTaglineColor As Integer
		Dim cmdTirlineColor As Integer
		Dim cmdOriginColor As Integer
		Dim cmdMyMsgs As Integer
	End Structure
	
	Dim colors() As ColorSheme
	Dim Flags As Integer
	Dim HKeyscnt As Integer 'Number of hot keys
	
	'UPGRADE_WARNING: Event cboAkAs.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub cboAkAs_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboAkAs.SelectedIndexChanged
		cmdApply.Enabled = True
	End Sub
	
	Private Sub cboAkAs_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cboAkAs.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		cmdApply.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Event cboColorsSheme.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub cboColorsSheme_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboColorsSheme.SelectedIndexChanged
		On Error GoTo errHandler
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim str_Renamed As String
		Dim i As Integer
		
		str_Renamed = cboColorsSheme.Text
		
		For i = 0 To cboColorsSheme.Items.Count
			
			If VB6.GetItemString(cboColorsSheme, i) = str_Renamed Then
				SetColors(i)
				cmdApply.Enabled = True
				Exit For
			End If
			
		Next 
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::cboColorsSheme_Click")
		End Select
		
	End Sub
	
	'UPGRADE_WARNING: Event cboHotKey.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub cboHotKey_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboHotKey.SelectedIndexChanged
		
		If Len(txtDragHKey.Text) <> 0 Then
			txtDragHKey.Text = cboHotKey.Text
		Else
			txtDragHKey.Text = "Drag"
		End If
		
	End Sub
	
	Private Sub cboHotKey_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cboHotKey.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'LockWindowUpdate cboHotKey.hWnd
	End Sub
	
	Private Sub cboHotKey_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cboHotKey.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		cboHotKey.Text = ""
		'LockWindowUpdate 0
	End Sub
	
	'UPGRADE_WARNING: Event cboNames.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub cboNames_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboNames.SelectedIndexChanged
		On Error GoTo errHandler
		Dim olditm As String
		Dim i As Integer
		
		olditm = VB6.GetItemString(cboNames, 0)
		
		If cboNames.Items.Count = 0 Then
			VB6.SetItemString(cboNames, 0, cboNames.Text)
		Else
			
			For i = 0 To cboNames.Items.Count - 1
				
				If InStr(1, VB6.GetItemString(cboNames, i), cboNames.Text, CompareMethod.Binary) <> 0 Then
					VB6.SetItemString(cboNames, 0, VB6.GetItemString(cboNames, i))
					VB6.SetItemString(cboNames, i, olditm)
					cboNames.Text = VB6.GetItemString(cboNames, 0)
					Exit For
				End If
				
			Next 
			
		End If
		
		cmdApply.Enabled = True
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::cboNames_Click")
		End Select
		
	End Sub
	
	Private Sub cboNames_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cboNames.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		cmdApply.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Event chkExtProcess.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub chkExtProcess_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkExtProcess.CheckStateChanged
		On Error GoTo errHandler
		
		Select Case chkExtProcess.CheckState
			
			Case 0
				PutGFEOption("Options\Process", "AllowExternal", "0")
				
			Case 1
				PutGFEOption("Options\Process", "AllowExternal", "1")
		End Select
		
		cmdApply.Enabled = True
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::chkExtProcess_Click")
		End Select
		
	End Sub
	
	'UPGRADE_WARNING: Event chkFlags.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub chkFlags_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkFlags.CheckStateChanged
		Dim Index As Short = chkFlags.GetIndex(eventSender)
		On Error GoTo errHandler
		
		Select Case Index
			
			Case 0
				
				If chkFlags(0).CheckState = 1 Then
					Flags = Flags Or msgBase.MSG_ATTRIBUTES.Msg_Private
				Else
					Flags = Flags - msgBase.MSG_ATTRIBUTES.Msg_Private
				End If
				
			Case 1
				
				If chkFlags(1).CheckState = 1 Then
					Flags = Flags Or msgBase.MSG_ATTRIBUTES.Msg_Crash
				Else
					Flags = Flags - msgBase.MSG_ATTRIBUTES.Msg_Crash
				End If
				
			Case 2
				
				If chkFlags(2).CheckState = 1 Then
					Flags = Flags Or msgBase.MSG_ATTRIBUTES.Msg_Read
				Else
					Flags = Flags - msgBase.MSG_ATTRIBUTES.Msg_Read
				End If
				
			Case 3
				
				If chkFlags(3).CheckState = 1 Then
					Flags = Flags Or msgBase.MSG_ATTRIBUTES.Msg_Kill
				Else
					Flags = Flags - msgBase.MSG_ATTRIBUTES.Msg_Kill
				End If
				
			Case 4
				
				If chkFlags(4).CheckState = 1 Then
					Flags = Flags Or msgBase.MSG_ATTRIBUTES.Msg_Local
				Else
					Flags = Flags - msgBase.MSG_ATTRIBUTES.Msg_Local
				End If
				
			Case 5
				
				If chkFlags(5).CheckState = 1 Then
					Flags = Flags Or msgBase.MSG_ATTRIBUTES.Msg_Hold
				Else
					Flags = Flags - msgBase.MSG_ATTRIBUTES.Msg_Hold
				End If
				
		End Select
		
		cmdApply.Enabled = True
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::chkFlags_Click")
		End Select
		
	End Sub
	
	'UPGRADE_WARNING: Event chkNpEnabled.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub chkNpEnabled_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkNpEnabled.CheckStateChanged
		cmdApply.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Event chkUptimeEnabled.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub chkUptimeEnabled_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkUptimeEnabled.CheckStateChanged
		cmdApply.Enabled = True
	End Sub
	
	Private Sub cmdAdd_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAdd.Click
		Dim Index As Short = cmdAdd.GetIndex(eventSender)
		'0- name, 1- aka
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim str_Renamed As String
		
		Select Case Index
			
			Case 0
				str_Renamed = InputBox("Введите дополнительное имя", System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				
				If Len(str_Renamed) <> 0 Then
					cboNames.Items.Add(str_Renamed)
					cmdApply.Enabled = True
				End If
				
			Case 1
				str_Renamed = InputBox("Введите дополнительное AkA", System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
				
				If Len(str_Renamed) <> 0 Then
					cboAkAs.Items.Add(str_Renamed)
					cmdApply.Enabled = True
				End If
				
		End Select
		
	End Sub
	
	Private Sub cmdAddColor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAddColor.Click
		On Error GoTo errHandler
		Dim ColorName As String
		Dim i As Integer
		Dim flg As Boolean
		
		ColorName = InputBox("Введите название темы", System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
		
		If Len(ColorName) <> 0 Then
			
			For i = 0 To cboColorsSheme.Items.Count
				
				If LCase(VB6.GetItemString(cboColorsSheme, i)) = LCase(ColorName) Then
					MsgBox("Тема уже существует!", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
					flg = True
					Exit For
				End If
				
			Next 
			
			If flg = False Then
				'добавляем
				cboColorsSheme.Items.Add(ColorName)
				i = UBound(colors) + 1
				ReDim Preserve colors(i)
				FillColors(i)
				cmdApply.Enabled = True
			End If
		End If
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::cmdAddColor_Click")
		End Select
		
	End Sub
	
	Private Sub cmdApply_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdApply.Click
		SaveSettings()
	End Sub
	
	Private Sub cmdBackMessageColor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBackMessageColor.Click
		Dim colors(6) As Integer
		Dim ret As Integer
		
		ret = modCommonDialog.ShowColor((System.Drawing.ColorTranslator.ToOle(cmdBackMessageColor.BackColor)))
		
		If ret <> -1 Then
			cmdBackMessageColor.BackColor = System.Drawing.ColorTranslator.FromOle(ret)
			cmdBackMessageColor.Refresh()
			cmdApply.Enabled = True
		Else
			Exit Sub
		End If
		
		colors(0) = System.Drawing.ColorTranslator.ToOle(cmdMainText.BackColor)
		colors(1) = System.Drawing.ColorTranslator.ToOle(cmdBackMessageColor.BackColor)
		colors(2) = System.Drawing.ColorTranslator.ToOle(cmdMyCitat.BackColor)
		colors(3) = System.Drawing.ColorTranslator.ToOle(cmdAlienCitat.BackColor)
		colors(4) = System.Drawing.ColorTranslator.ToOle(cmdTaglineColor.BackColor)
		colors(5) = System.Drawing.ColorTranslator.ToOle(cmdTirlineColor.BackColor)
		colors(6) = System.Drawing.ColorTranslator.ToOle(cmdOriginColor.BackColor)
		
		HighlightSample(rtfSample, colors)
		
	End Sub
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	Private Sub cmdDel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDel.Click
		Dim Index As Short = cmdDel.GetIndex(eventSender)
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim str_Renamed As String
		Dim i As Integer
		
		Select Case Index
			
			Case 0
				'имя
				str_Renamed = cboNames.Text
				
				For i = 0 To cboNames.Items.Count
					
					If str_Renamed = VB6.GetItemString(cboNames, i) Then
						cboNames.Items.RemoveAt(i)
						DeleteValue(HKEY_CURRENT_USER, "SOFTWARE\GFE\Options", "UserName" & i)
						Exit For
					End If
					
				Next i
				
			Case 1
				'aka
				str_Renamed = cboAkAs.Text
				
				For i = 0 To cboAkAs.Items.Count
					
					If str_Renamed = VB6.GetItemString(cboAkAs, i) Then
						cboAkAs.Items.RemoveAt(i)
						DeleteValue(HKEY_CURRENT_USER, "SOFTWARE\GFE\Options", "AkA" & i)
						Exit For
					End If
					
				Next i
				
		End Select
		
		cmdApply.Enabled = True
	End Sub
	
	Private Sub cmdDelColor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelColor.Click
		On Error GoTo errHandler
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim str_Renamed As String
		Dim i As Integer
		str_Renamed = cboColorsSheme.Text
		
		For i = 0 To cboColorsSheme.Items.Count
			
			If VB6.GetItemString(cboColorsSheme, i) = str_Renamed Then
				DeleteValue(HKEY_CURRENT_USER, "SOFTWARE\GFE\Options\Shemes", "ShemeName" & i)
				DeleteValue(HKEY_CURRENT_USER, "SOFTWARE\GFE\Options\Shemes", "Sheme" & i)
				cboColorsSheme.Items.RemoveAt(i)
				Exit For
			End If
			
		Next 
		
		cmdApply.Enabled = True
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::cmdDelColor_Click")
		End Select
		
	End Sub
	
	Private Sub cmdAddSymbol_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAddSymbol.Click
		frmAddReplacment.DefInstance.id = 0
		frmAddReplacment.DefInstance.ShowDialog()
		cmdApply.Enabled = True
	End Sub
	
	Private Sub cmdDelSymbol_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelSymbol.Click
		On Error GoTo errHandler
		lstReplacments.ListItems.Remove((lstReplacments.SelectedItem.Index))
		
		System.Windows.Forms.Application.DoEvents()
		DeleteValue(HKEY_CURRENT_USER, "SOFTWARE\GFE\Options\Replacments", "Replacment" & lstReplacments.SelectedItem.Index + 1)
		cmdApply.Enabled = True
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::cmdDelSymbol_Click")
		End Select
		
	End Sub
	
	Private Sub cmdEditSymbol_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEditSymbol.Click
		On Error GoTo errHandler
		frmAddReplacment.DefInstance.id = lstReplacments.SelectedItem.Index
		frmAddReplacment.DefInstance.txtWhat.Text = lstReplacments.ListItems.item(frmAddReplacment.DefInstance.id).Text
		frmAddReplacment.DefInstance.txtOnWhat.Text = lstReplacments.ListItems.item(frmAddReplacment.DefInstance.id).SubItems(1)
		frmAddReplacment.DefInstance.ShowDialog()
		cmdApply.Enabled = True
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::cmdEditSymbol_Click")
		End Select
		
	End Sub
	
	Private Sub cmdImportConfig_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdImportConfig.Click
		On Error Resume Next
		Dim ret As String
		modCommonDialog.OpenDialogTitle = "Import GoldED Configuration..."
		modCommonDialog.Filter_Renamed = "All Files (*.*)|*.*|Config Files(*.cfg)|*.cfg|Ini Files(*.ini)|*.ini|"
		modCommonDialog.Flags = cdlOFNHideReadOnly
		modCommonDialog.FilterIndex = 2
		ret = modCommonDialog.ShowOpen
		
		If Len(ret) <> 0 Then
			ImportGedCfg(ret)
			
			frmOptions_Load(Me, New System.EventArgs())
			cmdApply.Enabled = True
		End If
		
	End Sub
	
	Private Sub cmdMyMsgs_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMyMsgs.Click
		On Error GoTo errHandler
		Dim ret As Integer
		
		ret = modCommonDialog.ShowColor((System.Drawing.ColorTranslator.ToOle(cmdMyMsgs.BackColor)))
		
		If ret <> -1 Then
			cmdMyMsgs.BackColor = System.Drawing.ColorTranslator.FromOle(ret)
			cmdMyMsgs.Refresh()
			cmdApply.Enabled = True
		End If
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::cmdMyMsgs_Click")
		End Select
		
	End Sub
	
	Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
		SaveSettings()
		Me.Close()
	End Sub
	
	Private Sub cmdOriginColor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOriginColor.Click
		On Error Resume Next
		Dim colors(6) As Integer
		Dim ret As Integer
		
		ret = modCommonDialog.ShowColor((System.Drawing.ColorTranslator.ToOle(cmdOriginColor.BackColor)))
		
		If ret <> -1 Then
			cmdOriginColor.BackColor = System.Drawing.ColorTranslator.FromOle(ret)
			cmdOriginColor.Refresh()
			cmdApply.Enabled = True
		Else
			Exit Sub
		End If
		
		colors(0) = System.Drawing.ColorTranslator.ToOle(cmdMainText.BackColor)
		colors(1) = System.Drawing.ColorTranslator.ToOle(cmdBackMessageColor.BackColor)
		colors(2) = System.Drawing.ColorTranslator.ToOle(cmdMyCitat.BackColor)
		colors(3) = System.Drawing.ColorTranslator.ToOle(cmdAlienCitat.BackColor)
		colors(4) = System.Drawing.ColorTranslator.ToOle(cmdTaglineColor.BackColor)
		colors(5) = System.Drawing.ColorTranslator.ToOle(cmdTirlineColor.BackColor)
		colors(6) = System.Drawing.ColorTranslator.ToOle(cmdOriginColor.BackColor)
		
		HighlightSample(rtfSample, colors)
		
	End Sub
	
	Private Sub cmdSelectBase_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSelectBase.Click
		'процедура требует логической доработки.
		On Error Resume Next
		Dim ret As String
		
		modCommonDialog.OpenDialogTitle = "Select MsgBase Configuration..."
		modCommonDialog.Filter_Renamed = "All Files (*.*)|*.*|Config Files(*.cfg)|*.cfg|Areas Files(*.bbs)|*.bbs|Configure Files(*.conf)|*.conf|Ini Files(*.ini)|*.ini|"
		modCommonDialog.Flags = cdlOFNHideReadOnly
		modCommonDialog.FilterIndex = 1
		ret = modCommonDialog.ShowOpen((txtBasePath.Text))
		
		If Len(ret) <> 0 Then
			txtBasePath.Text = ret
			cmdApply.Enabled = True
			'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.TosserHeuristicAnalyzer. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			optTosser(clsEchos.TosserHeuristicAnalyzer(txtBasePath.Text)).Checked = True
		End If
		
	End Sub
	
	Private Sub cmdSelectFont_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSelectFont.Click
		Dim Index As Short = cmdSelectFont.GetIndex(eventSender)
		
		modCommonDialog.Flags = cdlCFBoth 'Or cdlCFEffects
		
		Select Case Index
			
			Case 0
				lblEcholistFont.Text = GetFontString(lblEcholistFont)
				
			Case 1
				lblTreeViewFont.Text = GetFontString(lblTreeViewFont)
				
			Case 2
				lblMainTextViewFont.Text = GetFontString(lblMainTextViewFont)
				
			Case 3
				lblEditorWindowFont.Text = GetFontString(lblEditorWindowFont)
				
			Case 4
				lblFromFont.Text = GetFontString(lblFromFont)
				
			Case 5
				lblToFont.Text = GetFontString(lblToFont)
				
			Case 6
				lblSubjFont.Text = GetFontString(lblSubjFont)
				
		End Select
		
		cmdApply.Enabled = True
	End Sub
	
	Private Function GetFontString(ByRef srcControl As System.Windows.Forms.Label) As String
		On Error Resume Next
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim str_Renamed As String
		Dim ret As System.Drawing.Font
		ret = modCommonDialog.ShowFont(srcControl.Font, (System.Drawing.ColorTranslator.ToOle(srcControl.ForeColor)))
		
		str_Renamed = ret.Name & " - "
		
		If Err.Number = 91 Then
			GetFontString = "Times New Roman - Regular - 8pt"
			Exit Function
		End If
		
		On Error GoTo errHandler
		
		srcControl.Font = VB6.FontChangeName(srcControl.Font, ret.Name)
		srcControl.Refresh()
		srcControl.Font = VB6.FontChangeBold(srcControl.Font, ret.Bold)
		srcControl.Font = VB6.FontChangeItalic(srcControl.Font, ret.Italic)
		srcControl.Font = VB6.FontChangeName(srcControl.Font, ret.Name)
		srcControl.Font = VB6.FontChangeSize(srcControl.Font, ret.SizeInPoints)
		srcControl.Refresh()
		
		If ret.Bold = True And ret.Italic = False Then
			str_Renamed = str_Renamed & "Bold - "
		End If
		
		If ret.Italic = True And ret.Bold = False Then
			str_Renamed = str_Renamed & "Italic - "
		End If
		
		If ret.Italic = True And ret.Bold = True Then
			str_Renamed = str_Renamed & "Bold Italic - "
		End If
		
		If ret.Italic = False And ret.Bold = False Then
			str_Renamed = str_Renamed & "Regular - "
		End If
		
		GetFontString = str_Renamed & Int(ret.SizeInPoints) & "pt"
		
		System.Windows.Forms.Application.DoEvents()
		Exit Function
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::GetFontString")
		End Select
		
	End Function
	
	Private Sub SetFontAttr(ByRef lblObject As System.Windows.Forms.Label)
		On Error GoTo errHandler
		Dim cl() As String
		cl = Split(lblObject.Text, " - ")
		
		lblObject.Font = VB6.FontChangeName(lblObject.Font, cl(0))
		
		If InStr(1, cl(1), " ") <> 0 Then 'сочитание стилей
			lblObject.Font = VB6.FontChangeBold(lblObject.Font, True)
			lblObject.Font = VB6.FontChangeItalic(lblObject.Font, True)
		Else
			
			If InStr(1, cl(1), "Bold", CompareMethod.Text) <> 0 Then
				lblObject.Font = VB6.FontChangeBold(lblObject.Font, True)
			End If
			
			If InStr(1, cl(1), "Italic", CompareMethod.Text) <> 0 Then
				lblObject.Font = VB6.FontChangeItalic(lblObject.Font, True)
			End If
		End If
		
		lblObject.Font = VB6.FontChangeSize(lblObject.Font, CDec(Mid(cl(2), 1, Len(cl(2)) - 2)))
		lblObject.Refresh()
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::SetFontAttr")
		End Select
		
	End Sub
	
	Private Sub cmdSelectProcess_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSelectProcess.Click
		Dim Index As Short = cmdSelectProcess.GetIndex(eventSender)
		Dim ret As String
		
		Select Case Index
			
			Case 0
				modCommonDialog.OpenDialogTitle = "Выберете скрипт или приложение..."
				modCommonDialog.Filter_Renamed = "All Files (*.*)|*.*|"
				modCommonDialog.Flags = cdlOFNHideReadOnly
				modCommonDialog.FilterIndex = 1
				ret = modCommonDialog.ShowOpen((txtExtProcess.Text))
				
				If Len(ret) <> 0 Then
					txtExtProcess.Text = ret
					cmdApply.Enabled = True
				End If
				
		End Select
		
	End Sub
	
	Private Sub cmdSelectSemaphore_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSelectSemaphore.Click
		Dim ret As String
		
		modCommonDialog.SaveDialogTitle = "Создание флага нового письма..."
		modCommonDialog.Filter_Renamed = "All Files (*.*)|*.*|"
		modCommonDialog.Flags = cdlOFNHideReadOnly
		modCommonDialog.FilterIndex = 1
		ret = modCommonDialog.ShowSave((txtSemaphore.Text))
		
		If Len(ret) <> 0 Then
			txtSemaphore.Text = ret
			cmdApply.Enabled = True
		End If
		
	End Sub
	
	Private Sub cmdTaglineColor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTaglineColor.Click
		Dim colors(7) As Integer
		Dim ret As Integer
		
		ret = modCommonDialog.ShowColor((System.Drawing.ColorTranslator.ToOle(cmdTaglineColor.BackColor)))
		
		If ret <> -1 Then
			cmdTaglineColor.BackColor = System.Drawing.ColorTranslator.FromOle(ret)
			cmdTaglineColor.Refresh()
			cmdApply.Enabled = True
		Else
			Exit Sub
		End If
		
		colors(0) = System.Drawing.ColorTranslator.ToOle(cmdMainText.BackColor)
		colors(1) = System.Drawing.ColorTranslator.ToOle(cmdBackMessageColor.BackColor)
		colors(2) = System.Drawing.ColorTranslator.ToOle(cmdMyCitat.BackColor)
		colors(3) = System.Drawing.ColorTranslator.ToOle(cmdAlienCitat.BackColor)
		colors(4) = System.Drawing.ColorTranslator.ToOle(cmdTaglineColor.BackColor)
		colors(5) = System.Drawing.ColorTranslator.ToOle(cmdTirlineColor.BackColor)
		colors(6) = System.Drawing.ColorTranslator.ToOle(cmdOriginColor.BackColor)
		
		HighlightSample(rtfSample, colors)
	End Sub
	
	Private Sub cmdTirlineColor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTirlineColor.Click
		Dim colors(6) As Integer
		Dim ret As Integer
		
		ret = modCommonDialog.ShowColor((System.Drawing.ColorTranslator.ToOle(cmdTirlineColor.BackColor)))
		
		If ret <> -1 Then
			cmdTirlineColor.BackColor = System.Drawing.ColorTranslator.FromOle(ret)
			cmdTirlineColor.Refresh()
			cmdApply.Enabled = True
		Else
			Exit Sub
		End If
		
		colors(0) = System.Drawing.ColorTranslator.ToOle(cmdMainText.BackColor)
		colors(1) = System.Drawing.ColorTranslator.ToOle(cmdBackMessageColor.BackColor)
		colors(2) = System.Drawing.ColorTranslator.ToOle(cmdMyCitat.BackColor)
		colors(3) = System.Drawing.ColorTranslator.ToOle(cmdAlienCitat.BackColor)
		colors(4) = System.Drawing.ColorTranslator.ToOle(cmdTaglineColor.BackColor)
		colors(5) = System.Drawing.ColorTranslator.ToOle(cmdTirlineColor.BackColor)
		colors(6) = System.Drawing.ColorTranslator.ToOle(cmdOriginColor.BackColor)
		
		HighlightSample(rtfSample, colors)
		
	End Sub
	
	Private Sub frmOptions_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		modCommonDialog.hwndOwner = Me.Handle.ToInt32
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) \ 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) \ 2)
		
		opTabStrip_ClickEvent(opTabStrip, New System.EventArgs())
		
		ReadSettings()
		
		cmdApply.Enabled = False
		
		System.Windows.Forms.Application.DoEvents()
	End Sub
	
	Private Sub ReadSettings()
		On Error GoTo errHandler
		Dim i, Y As Integer
		Dim tmp As String
		Dim LI As MSComctlLib.ListItem
		Dim tc() As String
		Dim Color(9) As Integer 'N-1
		
		rtfSample.Text = "Основной текст" & vbCrLf
		rtfSample.Text = rtfSample.Text & "XX>>Цитаты автора" & vbCrLf
		rtfSample.Text = rtfSample.Text & "ZZ>>>Цитирование автора " & vbCrLf
		rtfSample.Text = rtfSample.Text & "--- Тирлайн" & vbCrLf
		rtfSample.Text = rtfSample.Text & "... Таглайн" & vbCrLf
		rtfSample.Text = rtfSample.Text & " * Origin: Нету тут его (xx:xxxx/xx)"
		
		If GetGFEOption("Options", "Imported", CStr(0)) = "0" Then
			cmdImportConfig.Visible = True
		Else
			cmdImportConfig.Visible = False
			Err.Clear()
		End If
		
		i = 0 : cboNames.Items.Clear()
		While Len(GetGFEOption("Options", "UserName" & i)) <> 0
			cboNames.Items.Add(CStr(GetGFEOption("Options", "UserName" & i)))
			i = i + 1
		End While
		
		txtMainAddress.Text = GetGFEOption("Options", "MainAddress")
		Err.Clear()
		
		i = 0 : cboAkAs.Items.Clear()
		While Len(GetGFEOption("Options", "AkA" & i)) <> 0
			cboAkAs.Items.Add(GetGFEOption("Options", "AkA" & i))
			i = i + 1
		End While
		Err.Clear()
		
		cboNames.Text = VB6.GetItemString(cboNames, 0)
		cboAkAs.Text = VB6.GetItemString(cboAkAs, 0)
		
		txtSemaphore.Text = GetGFEOption("Options", "Semaphore")
		
		i = 0 : ReDim Preserve colors(i) : cboColorsSheme.Items.Clear()
		
		Do 
			ReDim Preserve colors(i)
			cboColorsSheme.Items.Add(GetGFEOption("Options\Shemes", "ShemeName" & i, "Golded"))
			tmp = GetGFEOption("Options\Shemes", "Sheme" & i, "65535 0 12632256 255 16777215 4259584 16777215 255 16777215 -2147483646")
			
			tc = Split(tmp, " ")
			
			If UBound(tc) <> 9 Then
				ReDim Preserve tc(9)
				tc(9) = "-2147483646"
			End If
			
			With colors(i)
				.cmdAlienCitat = CInt(tc(0))
				.cmdBackMessageColor = CInt(tc(1))
				.cmdMainText = CInt(tc(2))
				.cmdModerator = CInt(tc(3))
				.cmdMyCitat = CInt(tc(4))
				.cmdRules = CInt(tc(5))
				.cmdTaglineColor = CInt(tc(6))
				.cmdTirlineColor = CInt(tc(7))
				.cmdOriginColor = CInt(tc(8))
				.cmdMyMsgs = CInt(tc(9))
			End With
			
			i = i + 1
		Loop Until GetGFEOption("Options\Shemes", "ShemeName" & i) = ""
		
		tmp = GetGFEOption("Options", "DefaultColorSheme", CStr(0))
		
		For i = 0 To cboColorsSheme.Items.Count
			
			If tmp = CStr(i) Then
				cboColorsSheme.Text = GetGFEOption("Options\Shemes", "ShemeName" & i, "Golded")
				SetColors(i)
				Exit For
			End If
			
		Next i
		
		Err.Clear()
		'End If 'глюк, когда настройки якобы не сохранялись
		
		i = 1 : lstReplacments.ListItems.Clear()
		
		Do 
			LI = lstReplacments.ListItems.Add( ,  , Mid(GetGFEOption("Options\Replacments", "Replacment" & i, "Н H"), 1, 1))
			LI.SubItems(1) = Mid(GetGFEOption("Options\Replacments", "Replacment" & i, "Н H"), 3, 1)
			'UPGRADE_NOTE: Object LI may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
			LI = Nothing
			i = i + 1
		Loop Until GetGFEOption("Options\Replacments", "Replacment" & i) = ""
		
		txtBasePath.Text = GetGFEOption("Options", "cfgMsgBase", "")
		
		'Me.Show
		'loading tossers
		'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.TosserName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		optTosser(0).Text = clsEchos.TosserName(0)
		Y = VB6.PixelsToTwipsY(optTosser(0).Top)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.TosserCount. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		For i = 1 To clsEchos.TosserCount
			Y = Y + 300
			optTosser.Load(i)
			'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.TosserName. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			optTosser(i).Text = clsEchos.TosserName(i)
			optTosser(i).SetBounds(VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(optTosser(0).Left)), VB6.TwipsToPixelsY(Y), 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
			'UPGRADE_WARNING: OptionButton method optTosser.ZOrder has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
			VB6.ZOrder(optTosser(i), (0))
			optTosser(i).Visible = True
			
			System.Windows.Forms.Application.DoEvents()
		Next i
		
		optTosser(CShort(GetGFEOption("Options", "TosserId", "0"))).Checked = True
		
		'Netmail Directories
		i = 0
		While Len(GetGFEOption("Options", "Netmail Dir" & i)) <> 0
			LI = lvNetmailDirs.ListItems.Add( ,  , GetGFEOption("Options", "Netmail Name" & i, "Netmail" & i))
			LI.SubItems(1) = GetGFEOption("Options", "Netmail Dir" & i, "C:\T-Mail\Mail")
			LI.let_Tag(CStr(i))
			i = i + 1
		End While
		
		Select Case LCase(GetGFEOption("Options", "NetmailPosition", "Bottom"))
			
			Case "top"
				optNetmailPosition(0).Checked = True
				optNetmailPosition(1).Checked = False
				
			Case "bottom"
				optNetmailPosition(0).Checked = False
				optNetmailPosition(1).Checked = True
		End Select
		
		'вызываем процедурку расстановки флажков
		Flags = 0
		CheckedFlags(CInt(GetGFEOption("Options", "Netmail Flags", CStr(msgBase.MSG_ATTRIBUTES.Msg_Kill Or msgBase.MSG_ATTRIBUTES.Msg_Private Or msgBase.MSG_ATTRIBUTES.Msg_Local))))
		
		'загрузка фонтов
		lblEcholistFont.Text = GetGFEOption("Fonts", "EcholistFont", "Times New Roman - Regular - 8pt")
		lblTreeViewFont.Text = GetGFEOption("Fonts", "TreeViewFont", "MS Sans Serif - Regular - 8pt")
		lblMainTextViewFont.Text = GetGFEOption("Fonts", "MainTextViewFont", "MS Sans Serif - Regular - 8pt")
		lblEditorWindowFont.Text = GetGFEOption("Fonts", "EditorWindowFont", "Times - Regular - 8pt")
		lblFromFont.Text = GetGFEOption("Fonts", "FromFont", "Arial - Bold - 8pt")
		lblToFont.Text = GetGFEOption("Fonts", "ToFont", "Arial - Bold - 8pt")
		lblSubjFont.Text = GetGFEOption("Fonts", "SubjFont", "Arial - Bold Italic - 8pt")
		
		SetFontAttr(lblEcholistFont)
		SetFontAttr(lblTreeViewFont)
		SetFontAttr(lblMainTextViewFont)
		SetFontAttr(lblEditorWindowFont)
		SetFontAttr(lblFromFont)
		SetFontAttr(lblToFont)
		SetFontAttr(lblSubjFont)
		
		'устанавливаем цветовую схему
		Color(0) = System.Drawing.ColorTranslator.ToOle(cmdMainText.BackColor)
		Color(1) = System.Drawing.ColorTranslator.ToOle(cmdBackMessageColor.BackColor)
		Color(2) = System.Drawing.ColorTranslator.ToOle(cmdMyCitat.BackColor)
		Color(3) = System.Drawing.ColorTranslator.ToOle(cmdAlienCitat.BackColor)
		Color(4) = System.Drawing.ColorTranslator.ToOle(cmdTaglineColor.BackColor)
		Color(5) = System.Drawing.ColorTranslator.ToOle(cmdTirlineColor.BackColor)
		Color(6) = System.Drawing.ColorTranslator.ToOle(cmdOriginColor.BackColor)
		HighlightSample(rtfSample, Color)
		
		'загрузка NP
		txtNpPrefix.Text = GetGFEOption("Options", "NpPrefix", "np:")
		txtStopped.Text = GetGFEOption("Options", "Stopped", "Winamp Stopped")
		txtUptime.Text = GetGFEOption("Options", "Uptime", "Uptime:")
		txtNotLoading.Text = GetGFEOption("Options", "NotLoading", "Winamp Not Found!")
		chkNpEnabled.CheckState = CInt(GetGFEOption("Options", "NpEnabled", "0"))
		chkUptimeEnabled.CheckState = CInt(GetGFEOption("Options", "UptimeEnabled", "1"))
		
		'process
		txtExtProcess.Text = GetGFEOption("Options\Process", "ExtProcess")
		txtExtProcessParams.Text = GetGFEOption("Options\Process", "ExtProcessParams")
		chkExtProcess.CheckState = CInt(GetGFEOption("Options\Process", "AllowExternal", "0"))
		
		Select Case CInt(GetGFEOption("Options\Process", "StartUpType", "1"))
			
			Case 0 'always
				optStartupType(0).Checked = True
				optStartupType(1).Checked = False
				
			Case 1 'change only
				optStartupType(0).Checked = False
				optStartupType(1).Checked = True
		End Select
		
		'HotKeys
		If Len(GetGFEOption("Options\HotKeys", "Count", "")) <> 0 Then
			
			HKeyscnt = CInt(GetGFEOption("Options\HotKeys", "Count", "0"))
			lblActions(0).Text = GetGFEOption("Options\HotKeys", "Key0", "Ctrl + x")
			txtKeyAction(0).Text = GetGFEOption("Options\HotKeys", "Action0", "")
			txtKeyAction(0).Visible = True
			lblActions(0).Visible = True
			i = 1
			While Len(GetGFEOption("Options\HotKeys", "Key" & CStr(i))) <> 0
				
				lblActions.Load(i)
				txtKeyAction.Load(i)
				
				If i < 5 Then
					txtKeyAction(i).Left = VB6.TwipsToPixelsX(txtKeyAction(0).Left)
					txtKeyAction(i).Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(txtKeyAction(i - 1).Top) + VB6.PixelsToTwipsY(txtKeyAction(0).Height) + 100)
					lblActions(i).Top = VB6.TwipsToPixelsY(txtKeyAction(i).Top)
					lblActions(i).Left = VB6.TwipsToPixelsX(lblActions(0).Left)
				Else
					txtKeyAction(i).Left = VB6.TwipsToPixelsX(3150)
					txtKeyAction(i).Top = VB6.TwipsToPixelsY(txtKeyAction(i - 5).Top)
					lblActions(i).Left = VB6.TwipsToPixelsX(2610)
					lblActions(i).Top = VB6.TwipsToPixelsY(txtKeyAction(i).Top)
				End If
				
				lblActions(i).Text = GetGFEOption("Options\HotKeys", "Key" & CStr(i), "Ctrl + x")
				txtKeyAction(i).Text = GetGFEOption("Options\HotKeys", "Action" & CStr(i), "")
				txtKeyAction(i).Visible = True
				lblActions(i).Visible = True
				i = i + 1
			End While
			
		End If
		
		'Template
		'top
		txtGreeting.Text = GetGFEOption("Options\Template", "Greeting", "Glad To Read You, @TFName !")
		txtChanged.Text = GetGFEOption("Options\Template", "Changed", "*** Изменено непреднамеренно @CName ***")
		txtQuote.Text = GetGFEOption("Options\Template", "Quote", "Стучал как-то по клаве некто @OName и достучался он до @DName:")
		txtMoved.Text = GetGFEOption("Options\Template", "Moved", "*** Ответ на мессагу закинутую и зачитанную до битиков в арию @OEcho")
		'down
		txtSignature.Text = GetGFEOption("Options\Template", "Signature", "Пока,@TFName!!! С вами был,есть и будет:@CName")
		txtTagLine.Text = GetGFEOption("Options\Template", "TagLine", vbNullString)
		txtTirLine.Text = GetGFEOption("Options\Template", "TirLine", System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::ReadSettings")
		End Select
		
	End Sub
	
	Private Sub SaveSettings()
		Dim i As Integer
		Dim tmp As String
		Dim tmpc As ColorSheme
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim str_Renamed As String
		
		'On Error GoTo nomain
		On Error GoTo errHandler
		
		'If GetGFEOption("Options", "Imported", 0) = "1" Then
		
		'usernames
		If cboNames.Items.Count = 0 Then
			PutGFEOption("Options", "UserName0", (cboNames.Text))
		Else
			
			For i = 0 To cboNames.Items.Count - 1
				PutGFEOption("Options", "UserName" & i, VB6.GetItemString(cboNames, i))
			Next 
			
		End If
		
		'address
		PutGFEOption("Options", "MainAddress", (txtMainAddress.Text))
		
		'aka
		If cboAkAs.Items.Count = 0 Then
			PutGFEOption("Options", "AkA0", (cboAkAs.Text))
		Else
			
			For i = 0 To cboAkAs.Items.Count - 1
				PutGFEOption("Options", "AkA" & i, VB6.GetItemString(cboAkAs, i))
			Next 
			
		End If
		
		'Semaphore
		PutGFEOption("Options", "Semaphore", (txtSemaphore.Text))
		
		'shemes
		For i = 0 To cboColorsSheme.Items.Count - 1
			
			If cboColorsSheme.Text = VB6.GetItemString(cboColorsSheme, i) Then
				FillColors(i)
			End If
			
			If cboColorsSheme.Items.Count <> 0 Then
				PutGFEOption("Options\Shemes", "ShemeName" & i, VB6.GetItemString(cboColorsSheme, i))
			Else
				FillColors(i)
				PutGFEOption("Options\Shemes", "ShemeName" & i, (cboColorsSheme.Text))
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object tmpc. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			tmpc = colors(i)
			tmp = tmpc.cmdAlienCitat & " " & tmpc.cmdBackMessageColor & " " & tmpc.cmdMainText & " " & tmpc.cmdModerator & " " & tmpc.cmdMyCitat & " " & tmpc.cmdRules & " " & tmpc.cmdTaglineColor & " " & tmpc.cmdTirlineColor & " " & tmpc.cmdOriginColor & " " & tmpc.cmdMyMsgs
			
			PutGFEOption("Options\Shemes", "Sheme" & i, tmp)
		Next 
		
		'okay main setup complite
		'End If 'глюк, когда настройки якобы не сохранялись
		
nomain: 
		
		'normal control
		On Error GoTo errHandler
		
		'netmail
		For i = 0 To lvNetmailDirs.ListItems.Count - 1
			PutGFEOption("Options", "Netmail Name" & i, (lvNetmailDirs.ListItems.item(i + 1).Text))
			PutGFEOption("Options", "Netmail Dir" & i, lvNetmailDirs.ListItems.item(i + 1).SubItems(1))
		Next i
		
		PutGFEOption("Options", "cfgMsgBase", (txtBasePath.Text))
		PutGFEOption("Options", "Netmail Flags", CStr(Flags))
		
		If optNetmailPosition(0).Checked = True Then
			PutGFEOption("Options", "NetmailPosition", "Top")
		Else
			PutGFEOption("Options", "NetmailPosition", "Bottom")
		End If
		
		'color
		str_Renamed = cboColorsSheme.Text
		
		For i = 0 To cboColorsSheme.Items.Count
			
			If VB6.GetItemString(cboColorsSheme, i) = str_Renamed Then
				PutGFEOption("Options", "DefaultColorSheme", CStr(i))
				PutGFEOption("Options", "AlienCitatColor", CStr(System.Drawing.ColorTranslator.ToOle(cmdAlienCitat.BackColor)))
				PutGFEOption("Options", "MainTextColor", CStr(System.Drawing.ColorTranslator.ToOle(cmdMainText.BackColor)))
				PutGFEOption("Options", "MainTextColor", CStr(System.Drawing.ColorTranslator.ToOle(cmdMainText.BackColor)))
				PutGFEOption("Options", "BackMessageColor", CStr(System.Drawing.ColorTranslator.ToOle(cmdBackMessageColor.BackColor)))
				PutGFEOption("Options", "MyCitatColor", CStr(System.Drawing.ColorTranslator.ToOle(cmdMyCitat.BackColor)))
				PutGFEOption("Options", "MyMessagesColor", CStr(System.Drawing.ColorTranslator.ToOle(cmdMyMsgs.BackColor)))
				PutGFEOption("Options", "RulesColor", CStr(System.Drawing.ColorTranslator.ToOle(cmdRules.BackColor)))
				PutGFEOption("Options", "TaglineColor", CStr(System.Drawing.ColorTranslator.ToOle(cmdTaglineColor.BackColor)))
				PutGFEOption("Options", "TirlineColor", CStr(System.Drawing.ColorTranslator.ToOle(cmdTirlineColor.BackColor)))
				PutGFEOption("Options", "OriginColor", CStr(System.Drawing.ColorTranslator.ToOle(cmdOriginColor.BackColor)))
				'okay color setup complite
				Exit For
			End If
			
		Next 
		
		For i = 1 To lstReplacments.ListItems.Count
			PutGFEOption("Options\Replacments", "Replacment" & i, lstReplacments.ListItems.item(i).Text & " " & lstReplacments.ListItems.item(i).SubItems(1))
		Next i
		
		'fonts
		PutGFEOption("Fonts", "EcholistFont", (lblEcholistFont.Text))
		PutGFEOption("Fonts", "TreeViewFont", (lblTreeViewFont.Text))
		PutGFEOption("Fonts", "MainTextViewFont", (lblMainTextViewFont.Text))
		PutGFEOption("Fonts", "EditorWindowFont", (lblEditorWindowFont.Text))
		PutGFEOption("Fonts", "FromFont", (lblFromFont.Text))
		PutGFEOption("Fonts", "ToFont", (lblToFont.Text))
		PutGFEOption("Fonts", "SubjFont", (lblSubjFont.Text))
		
		'np
		PutGFEOption("Options", "NpPrefix", (txtNpPrefix.Text))
		PutGFEOption("Options", "Stopped", (txtStopped.Text))
		PutGFEOption("Options", "Uptime", (txtUptime.Text))
		PutGFEOption("Options", "NotLoading", (txtNotLoading.Text))
		PutGFEOption("Options", "NpEnabled", CStr(chkNpEnabled.CheckState))
		PutGFEOption("Options", "UptimeEnabled", CStr(chkUptimeEnabled.CheckState))
		
		'Processes
		PutGFEOption("Options\Process", "ExtProcess", (txtExtProcess.Text))
		PutGFEOption("Options\Process", "ExtProcessParams", (txtExtProcessParams.Text))
		
		For i = 0 To optStartupType.Count - 1
			
			If optStartupType(i).Checked Then
				PutGFEOption("Options\Process", "StartUpType", CStr(i))
			End If
			
		Next i
		
		'Hotkeys
		If lblActions(0).Visible Then
			DeleteKey(HKEY_CURRENT_USER, "SOFTWARE\GFE\Options\HotKeys")
			PutGFEOption("Options\HotKeys", "Count", CStr(HKeyscnt))
			
			For i = 0 To lblActions.Count - 1
				PutGFEOption("Options\HotKeys", "Key" & CStr(i), lblActions(i).Text)
				PutGFEOption("Options\HotKeys", "Action" & CStr(i), txtKeyAction(i).Text)
			Next i
			
		Else
			DeleteKey(HKEY_CURRENT_USER, "SOFTWARE\GFE\Options\HotKeys")
		End If
		
		'Template
		'top
		PutGFEOption("Options\Template", "Greeting", (txtGreeting.Text))
		PutGFEOption("Options\Template", "Changed", (txtChanged.Text))
		PutGFEOption("Options\Template", "Quote", (txtQuote.Text))
		PutGFEOption("Options\Template", "Moved", (txtMoved.Text))
		'down
		PutGFEOption("Options\Template", "Signature", (txtSignature.Text))
		PutGFEOption("Options\Template", "TagLine", (txtTagLine.Text))
		PutGFEOption("Options\Template", "TirLine", (txtTirLine.Text))
		
		cmdApply.Enabled = False
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::SaveSettings")
		End Select
		
	End Sub
	
	Private Sub cmdAlienCitat_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAlienCitat.Click
		On Error GoTo errHandler
		Dim colors(6) As Integer
		Dim ret As Integer
		
		ret = modCommonDialog.ShowColor((System.Drawing.ColorTranslator.ToOle(cmdAlienCitat.BackColor)))
		
		If ret <> -1 Then
			cmdAlienCitat.BackColor = System.Drawing.ColorTranslator.FromOle(ret)
			cmdAlienCitat.Refresh()
			cmdApply.Enabled = True
		Else
			Exit Sub
		End If
		
		colors(0) = System.Drawing.ColorTranslator.ToOle(cmdMainText.BackColor)
		colors(1) = System.Drawing.ColorTranslator.ToOle(cmdBackMessageColor.BackColor)
		colors(2) = System.Drawing.ColorTranslator.ToOle(cmdMyCitat.BackColor)
		colors(3) = System.Drawing.ColorTranslator.ToOle(cmdAlienCitat.BackColor)
		colors(4) = System.Drawing.ColorTranslator.ToOle(cmdTaglineColor.BackColor)
		colors(5) = System.Drawing.ColorTranslator.ToOle(cmdTirlineColor.BackColor)
		colors(6) = System.Drawing.ColorTranslator.ToOle(cmdOriginColor.BackColor)
		HighlightSample(rtfSample, colors)
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case 32755
				'cancel
				Exit Sub
				
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::cmdAlienCitat_Click")
		End Select
		
	End Sub
	
	Private Sub cmdMainText_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMainText.Click
		On Error GoTo errHandler
		Dim colors(6) As Integer
		Dim ret As Integer
		
		ret = modCommonDialog.ShowColor((System.Drawing.ColorTranslator.ToOle(cmdMainText.BackColor)))
		
		If ret <> -1 Then
			cmdMainText.BackColor = System.Drawing.ColorTranslator.FromOle(ret)
			cmdMainText.Refresh()
			cmdApply.Enabled = True
		Else
			Exit Sub
		End If
		
		colors(0) = System.Drawing.ColorTranslator.ToOle(cmdMainText.BackColor)
		colors(1) = System.Drawing.ColorTranslator.ToOle(cmdBackMessageColor.BackColor)
		colors(2) = System.Drawing.ColorTranslator.ToOle(cmdMyCitat.BackColor)
		colors(3) = System.Drawing.ColorTranslator.ToOle(cmdAlienCitat.BackColor)
		colors(4) = System.Drawing.ColorTranslator.ToOle(cmdTaglineColor.BackColor)
		colors(5) = System.Drawing.ColorTranslator.ToOle(cmdTirlineColor.BackColor)
		colors(6) = System.Drawing.ColorTranslator.ToOle(cmdOriginColor.BackColor)
		
		HighlightSample(rtfSample, colors)
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::cmdMainText_Click")
		End Select
		
	End Sub
	
	Private Sub cmdModerator_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdModerator.Click
		On Error GoTo errHandler
		Dim ret As Integer
		
		ret = modCommonDialog.ShowColor((System.Drawing.ColorTranslator.ToOle(cmdModerator.BackColor)))
		
		If ret <> -1 Then
			cmdModerator.BackColor = System.Drawing.ColorTranslator.FromOle(ret)
			cmdModerator.Refresh()
			cmdApply.Enabled = True
		Else
			Exit Sub
		End If
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::cmdModerator_Click")
		End Select
		
	End Sub
	
	Private Sub cmdMyCitat_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMyCitat.Click
		On Error GoTo errHandler
		Dim colors(6) As Integer
		Dim ret As Integer
		
		ret = modCommonDialog.ShowColor((System.Drawing.ColorTranslator.ToOle(cmdMyCitat.BackColor)))
		
		If ret <> -1 Then
			cmdMyCitat.BackColor = System.Drawing.ColorTranslator.FromOle(ret)
			cmdMyCitat.Refresh()
			cmdApply.Enabled = True
		Else
			Exit Sub
		End If
		
		colors(0) = System.Drawing.ColorTranslator.ToOle(cmdMainText.BackColor)
		colors(1) = System.Drawing.ColorTranslator.ToOle(cmdBackMessageColor.BackColor)
		colors(2) = System.Drawing.ColorTranslator.ToOle(cmdMyCitat.BackColor)
		colors(3) = System.Drawing.ColorTranslator.ToOle(cmdAlienCitat.BackColor)
		colors(4) = System.Drawing.ColorTranslator.ToOle(cmdTaglineColor.BackColor)
		colors(5) = System.Drawing.ColorTranslator.ToOle(cmdTirlineColor.BackColor)
		colors(6) = System.Drawing.ColorTranslator.ToOle(cmdOriginColor.BackColor)
		
		HighlightSample(rtfSample, colors)
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::cmdMyCitat_Click")
		End Select
		
	End Sub
	
	Private Sub cmdRules_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRules.Click
		On Error GoTo errHandler
		Dim ret As Integer
		
		ret = modCommonDialog.ShowColor((System.Drawing.ColorTranslator.ToOle(cmdRules.BackColor)))
		
		If ret <> -1 Then
			cmdRules.BackColor = System.Drawing.ColorTranslator.FromOle(ret)
			cmdRules.Refresh()
			cmdApply.Enabled = True
		Else
			Exit Sub
		End If
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::cmdRules_Click")
		End Select
		
	End Sub
	
	'UPGRADE_WARNING: Form event frmOptions.Unload has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
	Private Sub frmOptions_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
		Dim i As Integer
		
		If HKeyscnt <> 0 Then
			
			For i = 1 To lblActions.Count - 1
				lblActions.Unload(i)
				txtKeyAction.Unload(i)
			Next i
			
		End If
		
		HKeyscnt = 0
		
	End Sub
	
	'UPGRADE_WARNING: Frame Event fraHotkeys.MouseMove was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2050"'
	Private Sub fraHotkeys_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single)
		
		'UPGRADE_WARNING: Form1 property Me.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
		If Me.Cursor <> System.Windows.Forms.Cursors.Default Then
			Me.Cursor = System.Windows.Forms.Cursors.Default
			
			System.Windows.Forms.Application.DoEvents()
		End If
		
	End Sub
	
	'UPGRADE_WARNING: Frame Event fraKeyActions.DragDrop was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2050"'
	Private Sub fraKeyActions_DragDrop(ByRef Source As System.Windows.Forms.Control, ByRef X As Single, ByRef Y As Single)
		Dim HKtxt As String
		Dim ldxl, topdyc, ldxt, tdy As Integer
		
		If Source.Name = "txtDragHKey" Then
			
			HKtxt = Source.Text
			topdyc = VB6.PixelsToTwipsY(txtKeyAction(0).Height) + 100
			
			If InStr(1, HKtxt, "drag", CompareMethod.Text) = 0 Then
				If HKeyscnt > 9 Then
					Exit Sub
				End If
				
				For tdy = 1 To lblActions.Count
					
					If LCase(lblActions(tdy - 1).Text) = LCase(HKtxt) Then
						'MsgBox "Данное сочетание клавиш уже присутствует!", vbExclamation, App.Title
						Me.Cursor = System.Windows.Forms.Cursors.No
						Exit Sub
					End If
					
				Next tdy
				
				If HKeyscnt = 0 Then
					lblActions(0).Text = HKtxt
					lblActions(0).Visible = True
					txtKeyAction(0).Visible = True
					HKeyscnt = 1
				Else
					
					'add new control
					If HKeyscnt < 5 Then
						ldxt = VB6.PixelsToTwipsX(txtKeyAction(0).Left)
						ldxl = VB6.PixelsToTwipsX(lblActions(0).Left)
						tdy = VB6.PixelsToTwipsY(txtKeyAction(HKeyscnt - 1).Top) + topdyc
					Else
						ldxt = 3150
						ldxl = 2610
						tdy = VB6.PixelsToTwipsY(txtKeyAction(HKeyscnt - 5).Top)
					End If
					
					txtKeyAction.Load(HKeyscnt)
					
					With txtKeyAction(HKeyscnt)
						.Left = VB6.TwipsToPixelsX(ldxt)
						.Top = VB6.TwipsToPixelsY(tdy)
						.Visible = True
					End With
					
					lblActions.Load(HKeyscnt)
					
					With lblActions(HKeyscnt)
						.Text = HKtxt
						.Left = VB6.TwipsToPixelsX(ldxl)
						.Top = VB6.TwipsToPixelsY(tdy)
						.Visible = True
					End With
					
					HKeyscnt = HKeyscnt + 1
				End If
				
				System.Windows.Forms.Application.DoEvents()
			End If
		End If
		
	End Sub
	
	Private Sub lblActions_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblActions.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim Index As Short = lblActions.GetIndex(eventSender)
		lblActions(Index).Cursor = System.Windows.Forms.Cursors.Cross
	End Sub
	
	Private Sub lblActions_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblActions.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim Index As Short = lblActions.GetIndex(eventSender)
		
		If Button = VB6.MouseButtonConstants.RightButton Then
			
			'remove label
			If lblActions.Count = 1 Then
				lblActions(0).Text = "Ctrl + x"
				lblActions(0).Visible = False
				txtKeyAction(0).Visible = False
				HKeyscnt = 0
			Else
				'count > 1
				txtKeyAction(Index).Text = txtKeyAction(txtKeyAction.Count - 1).Text
				lblActions(Index).Text = lblActions(lblActions.Count - 1).Text
				txtKeyAction.Unload(lblActions.Count - 1)
				lblActions.Unload(lblActions.Count - 1)
				HKeyscnt = HKeyscnt - 1
			End If
		End If
		
		System.Windows.Forms.Application.DoEvents()
	End Sub
	
	Private Sub lvNetmailDirs_MouseUpEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComctlLib.ListViewEvents_MouseUpEvent) Handles lvNetmailDirs.MouseUpEvent
		
		Select Case eventArgs.Button
			
			Case VB6.MouseButtonConstants.RightButton
				'UPGRADE_ISSUE: Form method frmOptions.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
				PopupMenu(mnuPopupNetmail)
		End Select
		
	End Sub
	
	Public Sub mnuPopupNetmailAdd_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPopupNetmailAdd.Popup
		mnuPopupNetmailAdd_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuPopupNetmailAdd_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPopupNetmailAdd.Click
		Dim LI As MSComctlLib.ListItem
		Dim ret, ret1 As String
		
		modCommonDialog.FolderDialogTitle = "Выбор папки содержащую Netmail..."
		
		If Not (lvNetmailDirs.SelectedItem Is Nothing) Then
			ret1 = lvNetmailDirs.SelectedItem.SubItems(1)
			ret = modCommonDialog.ShowFolder(ret1)
		Else
			ret = modCommonDialog.ShowFolder
		End If
		
		If Len(ret) <> 0 Then
			ret1 = vbNullString
			
			ret1 = InputBox("Имя нетмейла", System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Netmail")
			
			If Len(ret1) = 0 Then
				ret1 = "Netmail"
			End If
			
			LI = lvNetmailDirs.ListItems.Add( ,  , ret1)
			LI.SubItems(1) = ret
			
			cmdApply.Enabled = True
		End If
		
	End Sub
	
	Public Sub mnuPopupNetmailChange_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPopupNetmailChange.Popup
		mnuPopupNetmailChange_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuPopupNetmailChange_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPopupNetmailChange.Click
		
		If Not (lvNetmailDirs.SelectedItem Is Nothing) Then
			'modCommonDialog.FolderDialogTitle = "Выбор папки содержащую Netmail..."
		End If
		
	End Sub
	
	Public Sub mnuPopupNetmailDelete_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPopupNetmailDelete.Popup
		mnuPopupNetmailDelete_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuPopupNetmailDelete_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPopupNetmailDelete.Click
		
		If Not (lvNetmailDirs.SelectedItem Is Nothing) Then
			If Len(lvNetmailDirs.SelectedItem.Tag) <> 0 Then
				DeleteValue(HKEY_CURRENT_USER, "SOFTWARE\GFE\Options\", "Netmail Dir" & lvNetmailDirs.SelectedItem.Tag)
				DeleteValue(HKEY_CURRENT_USER, "SOFTWARE\GFE\Options\", "Netmail Name" & lvNetmailDirs.SelectedItem.Tag)
				lvNetmailDirs.ListItems.Remove((lvNetmailDirs.SelectedItem.Index))
			End If
		End If
		
	End Sub
	
	Private Sub opTabStrip_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles opTabStrip.ClickEvent
		On Error GoTo errHandler
		Dim a As Short
		
		If Not opTabStrip.SelectedItem Is Nothing Then
			
			For a = 1 To op.Count
				
				If a = opTabStrip.SelectedItem.Index Then
					op(a).Visible = True
				Else
					op(a).Visible = False
				End If
				
			Next 
			
		End If
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::opTabStrip_Click")
		End Select
		
	End Sub
	
	Private Sub FillColors(ByRef num As Integer)
		On Error GoTo errHandler
		
		With colors(num)
			.cmdModerator = System.Drawing.ColorTranslator.ToOle(cmdModerator.BackColor)
			.cmdRules = System.Drawing.ColorTranslator.ToOle(cmdRules.BackColor)
			.cmdMainText = System.Drawing.ColorTranslator.ToOle(cmdMainText.BackColor)
			.cmdBackMessageColor = System.Drawing.ColorTranslator.ToOle(cmdBackMessageColor.BackColor)
			.cmdAlienCitat = System.Drawing.ColorTranslator.ToOle(cmdAlienCitat.BackColor)
			.cmdMyCitat = System.Drawing.ColorTranslator.ToOle(cmdMyCitat.BackColor)
			.cmdTaglineColor = System.Drawing.ColorTranslator.ToOle(cmdTaglineColor.BackColor)
			.cmdTirlineColor = System.Drawing.ColorTranslator.ToOle(cmdTirlineColor.BackColor)
			.cmdOriginColor = System.Drawing.ColorTranslator.ToOle(cmdOriginColor.BackColor)
			.cmdMyMsgs = System.Drawing.ColorTranslator.ToOle(cmdMyMsgs.BackColor)
		End With
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::FillColors")
		End Select
		
	End Sub
	
	Private Sub SetColors(ByRef num As Integer)
		On Error GoTo errHandler
		Dim Color(6) As Integer
		
		With colors(num)
			cmdModerator.BackColor = System.Drawing.ColorTranslator.FromOle(.cmdModerator)
			cmdModerator.Refresh()
			cmdRules.BackColor = System.Drawing.ColorTranslator.FromOle(.cmdRules)
			cmdRules.Refresh()
			cmdMainText.BackColor = System.Drawing.ColorTranslator.FromOle(.cmdMainText)
			cmdMainText.Refresh()
			cmdBackMessageColor.BackColor = System.Drawing.ColorTranslator.FromOle(.cmdBackMessageColor)
			cmdBackMessageColor.Refresh()
			cmdAlienCitat.BackColor = System.Drawing.ColorTranslator.FromOle(.cmdAlienCitat)
			cmdAlienCitat.Refresh()
			cmdMyCitat.BackColor = System.Drawing.ColorTranslator.FromOle(.cmdMyCitat)
			cmdMyCitat.Refresh()
			cmdTaglineColor.BackColor = System.Drawing.ColorTranslator.FromOle(.cmdTaglineColor)
			cmdTaglineColor.Refresh()
			cmdTirlineColor.BackColor = System.Drawing.ColorTranslator.FromOle(.cmdTirlineColor)
			cmdTaglineColor.Refresh()
			cmdOriginColor.BackColor = System.Drawing.ColorTranslator.FromOle(.cmdOriginColor)
			cmdTaglineColor.Refresh()
		End With
		
		'refresh
		Color(0) = System.Drawing.ColorTranslator.ToOle(cmdMainText.BackColor)
		Color(1) = System.Drawing.ColorTranslator.ToOle(cmdBackMessageColor.BackColor)
		Color(2) = System.Drawing.ColorTranslator.ToOle(cmdMyCitat.BackColor)
		Color(3) = System.Drawing.ColorTranslator.ToOle(cmdAlienCitat.BackColor)
		Color(4) = System.Drawing.ColorTranslator.ToOle(cmdTaglineColor.BackColor)
		Color(5) = System.Drawing.ColorTranslator.ToOle(cmdTirlineColor.BackColor)
		Color(6) = System.Drawing.ColorTranslator.ToOle(cmdOriginColor.BackColor)
		HighlightSample(rtfSample, Color)
		
		System.Windows.Forms.Application.DoEvents()
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::SetColors")
		End Select
		
	End Sub
	
	Private Sub CheckedFlags(ByRef flg As Integer)
		On Error GoTo errHandler
		
		If (flg And msgBase.MSG_ATTRIBUTES.Msg_Private) = msgBase.MSG_ATTRIBUTES.Msg_Private Then
			chkFlags(0).CheckState = System.Windows.Forms.CheckState.Checked
		End If
		
		If (flg And msgBase.MSG_ATTRIBUTES.Msg_Crash) = msgBase.MSG_ATTRIBUTES.Msg_Crash Then
			chkFlags(1).CheckState = System.Windows.Forms.CheckState.Checked
		End If
		
		If (flg And msgBase.MSG_ATTRIBUTES.Msg_Read) = msgBase.MSG_ATTRIBUTES.Msg_Read Then
			chkFlags(2).CheckState = System.Windows.Forms.CheckState.Checked
		End If
		
		If (flg And msgBase.MSG_ATTRIBUTES.Msg_Kill) = msgBase.MSG_ATTRIBUTES.Msg_Kill Then
			chkFlags(3).CheckState = System.Windows.Forms.CheckState.Checked
		End If
		
		If (flg And msgBase.MSG_ATTRIBUTES.Msg_Local) = msgBase.MSG_ATTRIBUTES.Msg_Local Then
			chkFlags(4).CheckState = System.Windows.Forms.CheckState.Checked
		End If
		
		If (flg And msgBase.MSG_ATTRIBUTES.Msg_Hold) = msgBase.MSG_ATTRIBUTES.Msg_Hold Then
			chkFlags(5).CheckState = System.Windows.Forms.CheckState.Checked
		End If
		
		Exit Sub
		
errHandler: 
		
		Select Case Err.Number
			
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmOptions::CheckedFlags")
		End Select
		
	End Sub
	
	'UPGRADE_WARNING: Event optNetmailPosition.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub optNetmailPosition_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optNetmailPosition.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optNetmailPosition.GetIndex(eventSender)
			cmdApply.Enabled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optStartupType.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub optStartupType_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optStartupType.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optStartupType.GetIndex(eventSender)
			cmdApply.Enabled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optTosser.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub optTosser_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optTosser.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optTosser.GetIndex(eventSender)
			PutGFEOption("Options", "TosserId", CStr(Index))
			cmdApply.Enabled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtBasePath.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtBasePath_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtBasePath.TextChanged
		cmdApply.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Event txtChanged.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtChanged_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtChanged.TextChanged
		cmdApply.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Event txtExtProcess.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtExtProcess_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtExtProcess.TextChanged
		cmdApply.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Event txtExtProcessParams.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtExtProcessParams_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtExtProcessParams.TextChanged
		cmdApply.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Event txtGreeting.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtGreeting_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtGreeting.TextChanged
		cmdApply.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Event txtMainAddress.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtMainAddress_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMainAddress.TextChanged
		cmdApply.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Event txtMoved.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtMoved_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMoved.TextChanged
		cmdApply.Enabled = True
	End Sub
	
	Private Sub txtNetmailPath_Change()
		cmdApply.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Event txtNotLoading.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtNotLoading_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtNotLoading.TextChanged
		PutGFEOption("Options", "NotLoading", (txtNotLoading.Text))
		txtExample.Text = getNP
	End Sub
	
	'UPGRADE_WARNING: Event txtNpPrefix.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtNpPrefix_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtNpPrefix.TextChanged
		PutGFEOption("Options", "NpPrefix", (txtNpPrefix.Text))
		txtExample.Text = getNP
	End Sub
	
	'UPGRADE_WARNING: Event txtQuote.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtQuote_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtQuote.TextChanged
		cmdApply.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Event txtSemaphore.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtSemaphore_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSemaphore.TextChanged
		cmdApply.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Event txtSignature.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtSignature_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSignature.TextChanged
		cmdApply.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Event txtStopped.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtStopped_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtStopped.TextChanged
		PutGFEOption("Options", "Stopped", (txtStopped.Text))
		txtExample.Text = getNP
	End Sub
	
	'UPGRADE_WARNING: Event txtTagLine.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtTagLine_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTagLine.TextChanged
		cmdApply.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Event txtTirLine.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtTirLine_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtTirLine.TextChanged
		cmdApply.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Event txtUptime.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtUptime_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUptime.TextChanged
		PutGFEOption("Options", "Uptime", (txtUptime.Text))
		txtExample.Text = getNP
	End Sub
End Class