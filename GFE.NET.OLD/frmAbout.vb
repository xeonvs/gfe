Option Strict Off
Option Explicit On
Friend Class frmAbout
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
	Public WithEvents cmdCheckUpdate As System.Windows.Forms.Button
	Public WithEvents _picTab_3 As System.Windows.Forms.Panel
	Public WithEvents txtComputer As System.Windows.Forms.TextBox
	Public WithEvents lblProperties As System.Windows.Forms.Label
	Public WithEvents _picTab_2 As System.Windows.Forms.Panel
	Public WithEvents txtModules As System.Windows.Forms.TextBox
	Public WithEvents lblModules As System.Windows.Forms.Label
	Public WithEvents lblLicense As System.Windows.Forms.Label
	Public WithEvents lblMail As System.Windows.Forms.Label
	Public WithEvents lblUrl As System.Windows.Forms.Label
	Public WithEvents lblLaw As System.Windows.Forms.Label
	Public WithEvents linLaw As System.Windows.Forms.Label
	Public WithEvents lblCopyright As System.Windows.Forms.Label
	Public WithEvents lblVersionBuild As System.Windows.Forms.Label
	Public WithEvents lblProject As System.Windows.Forms.Label
	Public WithEvents imaLogo As System.Windows.Forms.PictureBox
	Public WithEvents _picTab_1 As System.Windows.Forms.Panel
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents tabAbout As AxMSComctlLib.AxTabStrip
	Public WithEvents picTab As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAbout))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.cmdCheckUpdate = New System.Windows.Forms.Button
		Me._picTab_3 = New System.Windows.Forms.Panel
		Me._picTab_2 = New System.Windows.Forms.Panel
		Me.txtComputer = New System.Windows.Forms.TextBox
		Me.lblProperties = New System.Windows.Forms.Label
		Me._picTab_1 = New System.Windows.Forms.Panel
		Me.txtModules = New System.Windows.Forms.TextBox
		Me.lblModules = New System.Windows.Forms.Label
		Me.lblLicense = New System.Windows.Forms.Label
		Me.lblMail = New System.Windows.Forms.Label
		Me.lblUrl = New System.Windows.Forms.Label
		Me.lblLaw = New System.Windows.Forms.Label
		Me.linLaw = New System.Windows.Forms.Label
		Me.lblCopyright = New System.Windows.Forms.Label
		Me.lblVersionBuild = New System.Windows.Forms.Label
		Me.lblProject = New System.Windows.Forms.Label
		Me.imaLogo = New System.Windows.Forms.PictureBox
		Me.cmdOk = New System.Windows.Forms.Button
		Me.tabAbout = New AxMSComctlLib.AxTabStrip
		Me.picTab = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(components)
		CType(Me.tabAbout, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picTab, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "About Gold Fido Explorer 1.0"
		Me.ClientSize = New System.Drawing.Size(446, 308)
		Me.Location = New System.Drawing.Point(3, 29)
		Me.Icon = CType(resources.GetObject("frmAbout.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmAbout"
		Me.cmdCheckUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCheckUpdate.Text = "&CheckUpdate"
		Me.cmdCheckUpdate.Size = New System.Drawing.Size(81, 26)
		Me.cmdCheckUpdate.Location = New System.Drawing.Point(10, 275)
		Me.cmdCheckUpdate.TabIndex = 16
		Me.cmdCheckUpdate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCheckUpdate.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCheckUpdate.CausesValidation = True
		Me.cmdCheckUpdate.Enabled = True
		Me.cmdCheckUpdate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCheckUpdate.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCheckUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCheckUpdate.TabStop = True
		Me.cmdCheckUpdate.Name = "cmdCheckUpdate"
		Me._picTab_3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me._picTab_3.ForeColor = System.Drawing.SystemColors.ActiveCaption
		Me._picTab_3.Size = New System.Drawing.Size(416, 226)
		Me._picTab_3.Location = New System.Drawing.Point(15, 36)
		Me._picTab_3.TabIndex = 12
		Me._picTab_3.Visible = False
		Me._picTab_3.Dock = System.Windows.Forms.DockStyle.None
		Me._picTab_3.BackColor = System.Drawing.SystemColors.Control
		Me._picTab_3.CausesValidation = True
		Me._picTab_3.Enabled = True
		Me._picTab_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._picTab_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picTab_3.TabStop = True
		Me._picTab_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._picTab_3.Name = "_picTab_3"
		Me._picTab_2.Size = New System.Drawing.Size(416, 226)
		Me._picTab_2.Location = New System.Drawing.Point(15, 36)
		Me._picTab_2.TabIndex = 3
		Me._picTab_2.Visible = False
		Me._picTab_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picTab_2.Dock = System.Windows.Forms.DockStyle.None
		Me._picTab_2.BackColor = System.Drawing.SystemColors.Control
		Me._picTab_2.CausesValidation = True
		Me._picTab_2.Enabled = True
		Me._picTab_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picTab_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._picTab_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picTab_2.TabStop = True
		Me._picTab_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._picTab_2.Name = "_picTab_2"
		Me.txtComputer.AutoSize = False
		Me.txtComputer.BackColor = System.Drawing.SystemColors.Control
		Me.txtComputer.Size = New System.Drawing.Size(406, 201)
		Me.txtComputer.Location = New System.Drawing.Point(5, 20)
		Me.txtComputer.ReadOnly = True
		Me.txtComputer.MultiLine = True
		Me.txtComputer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtComputer.TabIndex = 5
		Me.txtComputer.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtComputer.AcceptsReturn = True
		Me.txtComputer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtComputer.CausesValidation = True
		Me.txtComputer.Enabled = True
		Me.txtComputer.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtComputer.HideSelection = True
		Me.txtComputer.Maxlength = 0
		Me.txtComputer.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtComputer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtComputer.TabStop = True
		Me.txtComputer.Visible = True
		Me.txtComputer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtComputer.Name = "txtComputer"
		Me.lblProperties.Text = "Computer properties:"
		Me.lblProperties.Size = New System.Drawing.Size(97, 13)
		Me.lblProperties.Location = New System.Drawing.Point(5, 5)
		Me.lblProperties.TabIndex = 4
		Me.lblProperties.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProperties.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblProperties.BackColor = System.Drawing.SystemColors.Control
		Me.lblProperties.Enabled = True
		Me.lblProperties.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblProperties.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblProperties.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblProperties.UseMnemonic = True
		Me.lblProperties.Visible = True
		Me.lblProperties.AutoSize = True
		Me.lblProperties.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblProperties.Name = "lblProperties"
		Me._picTab_1.Size = New System.Drawing.Size(416, 226)
		Me._picTab_1.Location = New System.Drawing.Point(15, 35)
		Me._picTab_1.TabIndex = 2
		Me._picTab_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._picTab_1.Dock = System.Windows.Forms.DockStyle.None
		Me._picTab_1.BackColor = System.Drawing.SystemColors.Control
		Me._picTab_1.CausesValidation = True
		Me._picTab_1.Enabled = True
		Me._picTab_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picTab_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._picTab_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picTab_1.TabStop = True
		Me._picTab_1.Visible = True
		Me._picTab_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._picTab_1.Name = "_picTab_1"
		Me.txtModules.AutoSize = False
		Me.txtModules.BackColor = System.Drawing.SystemColors.Control
		Me.txtModules.Size = New System.Drawing.Size(247, 43)
		Me.txtModules.Location = New System.Drawing.Point(156, 36)
		Me.txtModules.ReadOnly = True
		Me.txtModules.MultiLine = True
		Me.txtModules.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtModules.TabIndex = 15
		Me.txtModules.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtModules.AcceptsReturn = True
		Me.txtModules.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtModules.CausesValidation = True
		Me.txtModules.Enabled = True
		Me.txtModules.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtModules.HideSelection = True
		Me.txtModules.Maxlength = 0
		Me.txtModules.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtModules.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtModules.TabStop = True
		Me.txtModules.Visible = True
		Me.txtModules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtModules.Name = "txtModules"
		Me.lblModules.Text = "Рабочие Модули:"
		Me.lblModules.Size = New System.Drawing.Size(43, 31)
		Me.lblModules.Location = New System.Drawing.Point(110, 42)
		Me.lblModules.TabIndex = 14
		Me.lblModules.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblModules.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblModules.BackColor = System.Drawing.SystemColors.Control
		Me.lblModules.Enabled = True
		Me.lblModules.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblModules.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblModules.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblModules.UseMnemonic = True
		Me.lblModules.Visible = True
		Me.lblModules.AutoSize = False
		Me.lblModules.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblModules.Name = "lblModules"
		Me.lblLicense.Text = "License to:"
		Me.lblLicense.Size = New System.Drawing.Size(291, 49)
		Me.lblLicense.Location = New System.Drawing.Point(110, 102)
		Me.lblLicense.TabIndex = 13
		Me.lblLicense.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLicense.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLicense.BackColor = System.Drawing.SystemColors.Control
		Me.lblLicense.Enabled = True
		Me.lblLicense.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLicense.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLicense.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLicense.UseMnemonic = True
		Me.lblLicense.Visible = True
		Me.lblLicense.AutoSize = False
		Me.lblLicense.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLicense.Name = "lblLicense"
		Me.lblMail.Text = "gfe_project@mail.ru"
		Me.lblMail.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.lblMail.ForeColor = System.Drawing.SystemColors.ActiveCaption
		Me.lblMail.Size = New System.Drawing.Size(111, 15)
		Me.lblMail.Location = New System.Drawing.Point(290, 210)
		Me.lblMail.TabIndex = 11
		Me.lblMail.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMail.BackColor = System.Drawing.SystemColors.Control
		Me.lblMail.Enabled = True
		Me.lblMail.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMail.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMail.UseMnemonic = True
		Me.lblMail.Visible = True
		Me.lblMail.AutoSize = True
		Me.lblMail.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMail.Name = "lblMail"
		Me.lblUrl.Text = "http://gfe.h10.ru/"
		Me.lblUrl.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.lblUrl.ForeColor = System.Drawing.SystemColors.ActiveCaption
		Me.lblUrl.Size = New System.Drawing.Size(95, 16)
		Me.lblUrl.Location = New System.Drawing.Point(105, 210)
		Me.lblUrl.TabIndex = 10
		Me.lblUrl.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUrl.BackColor = System.Drawing.SystemColors.Control
		Me.lblUrl.Enabled = True
		Me.lblUrl.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUrl.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUrl.UseMnemonic = True
		Me.lblUrl.Visible = True
		Me.lblUrl.AutoSize = True
		Me.lblUrl.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUrl.Name = "lblUrl"
		Me.lblLaw.Text = "Данная програма защищена законом об авторских правах. Исспользование какой либо ее части или идеи в любых целях без согласия автора запрещено!"
		Me.lblLaw.Size = New System.Drawing.Size(291, 51)
		Me.lblLaw.Location = New System.Drawing.Point(110, 160)
		Me.lblLaw.TabIndex = 9
		Me.lblLaw.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblLaw.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblLaw.BackColor = System.Drawing.SystemColors.Control
		Me.lblLaw.Enabled = True
		Me.lblLaw.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblLaw.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblLaw.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblLaw.UseMnemonic = True
		Me.lblLaw.Visible = True
		Me.lblLaw.AutoSize = False
		Me.lblLaw.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblLaw.Name = "lblLaw"
		Me.linLaw.BackColor = System.Drawing.SystemColors.GrayText
		Me.linLaw.Visible = True
		Me.linLaw.Location = New System.Drawing.Point(110, 155)
		Me.linLaw.Width = 290
		Me.linLaw.Height = 1
		Me.linLaw.Name = "linLaw"
		Me.lblCopyright.Text = "Copyright © 2003 Visual Studio BBS™"
		Me.lblCopyright.Size = New System.Drawing.Size(180, 13)
		Me.lblCopyright.Location = New System.Drawing.Point(110, 84)
		Me.lblCopyright.TabIndex = 8
		Me.lblCopyright.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCopyright.BackColor = System.Drawing.SystemColors.Control
		Me.lblCopyright.Enabled = True
		Me.lblCopyright.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCopyright.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblCopyright.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCopyright.UseMnemonic = True
		Me.lblCopyright.Visible = True
		Me.lblCopyright.AutoSize = True
		Me.lblCopyright.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCopyright.Name = "lblCopyright"
		Me.lblVersionBuild.Text = "Version: 1.0 (Build 600)"
		Me.lblVersionBuild.Size = New System.Drawing.Size(109, 13)
		Me.lblVersionBuild.Location = New System.Drawing.Point(110, 20)
		Me.lblVersionBuild.TabIndex = 7
		Me.lblVersionBuild.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVersionBuild.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVersionBuild.BackColor = System.Drawing.SystemColors.Control
		Me.lblVersionBuild.Enabled = True
		Me.lblVersionBuild.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVersionBuild.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVersionBuild.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVersionBuild.UseMnemonic = True
		Me.lblVersionBuild.Visible = True
		Me.lblVersionBuild.AutoSize = True
		Me.lblVersionBuild.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVersionBuild.Name = "lblVersionBuild"
		Me.lblProject.Text = "Gold Fido Explorer 1.0"
		Me.lblProject.Size = New System.Drawing.Size(104, 13)
		Me.lblProject.Location = New System.Drawing.Point(110, 5)
		Me.lblProject.TabIndex = 6
		Me.lblProject.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProject.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblProject.BackColor = System.Drawing.SystemColors.Control
		Me.lblProject.Enabled = True
		Me.lblProject.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblProject.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblProject.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblProject.UseMnemonic = True
		Me.lblProject.Visible = True
		Me.lblProject.AutoSize = True
		Me.lblProject.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblProject.Name = "lblProject"
		Me.imaLogo.Size = New System.Drawing.Size(98, 88)
		Me.imaLogo.Location = New System.Drawing.Point(5, 5)
		Me.imaLogo.Image = CType(resources.GetObject("imaLogo.Image"), System.Drawing.Image)
		Me.imaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.imaLogo.Enabled = True
		Me.imaLogo.Cursor = System.Windows.Forms.Cursors.Default
		Me.imaLogo.Visible = True
		Me.imaLogo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.imaLogo.Name = "imaLogo"
		Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOk.Text = "OK"
		Me.cmdOk.Size = New System.Drawing.Size(66, 26)
		Me.cmdOk.Location = New System.Drawing.Point(370, 275)
		Me.cmdOk.TabIndex = 1
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		tabAbout.OcxState = CType(resources.GetObject("tabAbout.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tabAbout.Size = New System.Drawing.Size(426, 256)
		Me.tabAbout.Location = New System.Drawing.Point(10, 10)
		Me.tabAbout.TabIndex = 0
		Me.tabAbout.Name = "tabAbout"
		Me.Controls.Add(cmdCheckUpdate)
		Me.Controls.Add(_picTab_3)
		Me.Controls.Add(_picTab_2)
		Me.Controls.Add(_picTab_1)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(tabAbout)
		Me._picTab_2.Controls.Add(txtComputer)
		Me._picTab_2.Controls.Add(lblProperties)
		Me._picTab_1.Controls.Add(txtModules)
		Me._picTab_1.Controls.Add(lblModules)
		Me._picTab_1.Controls.Add(lblLicense)
		Me._picTab_1.Controls.Add(lblMail)
		Me._picTab_1.Controls.Add(lblUrl)
		Me._picTab_1.Controls.Add(lblLaw)
		Me._picTab_1.Controls.Add(linLaw)
		Me._picTab_1.Controls.Add(lblCopyright)
		Me._picTab_1.Controls.Add(lblVersionBuild)
		Me._picTab_1.Controls.Add(lblProject)
		Me._picTab_1.Controls.Add(imaLogo)
		Me.picTab.SetIndex(_picTab_3, CType(3, Short))
		Me.picTab.SetIndex(_picTab_2, CType(2, Short))
		Me.picTab.SetIndex(_picTab_1, CType(1, Short))
		CType(Me.picTab, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tabAbout, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmAbout
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmAbout
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmAbout()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
	Private Const DT_CALCRECT As Integer = &H400s
	Private Const DT_CENTER As Integer = &H1s
	Private Const DT_LEFT As Integer = &H0s
	Private Const DT_RIGHT As Integer = &H2s
	Private Const DT_WORDBREAK As Integer = &H10s
	Private Const SW_SHOWMAXIMIZED As Short = 3
	Dim EndingFlag As Boolean
	
	Private Sub cmdCheckUpdate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCheckUpdate.Click
		Call modCommon.CheckUpdate()
	End Sub
	
	Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
		Me.Close()
	End Sub
	
	Private Sub frmAbout_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		On Error Resume Next
		Dim pCnt, i As Integer
		Dim strDsc As String
		
		lblProject.Text = "Gold Fido Explorer " & System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMajorPart & "." & System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMinorPart
		'UPGRADE_ISSUE: App property App.Revision was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		lblVersionBuild.Text = "Version: " & System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMajorPart & "." & System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMinorPart & " (Build " & App.Revision & ")"
		
		'сделаем вот так, в pCnt будет -1 если плугины не найдены
		Err.Clear()
		pCnt = UBound(Plugins)
		If Err.Number <> 0 Then
			pCnt = -1
		End If
		
		'проходим по всем плугинам
		'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.About. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		strDsc = "1. " & clsEchos.About & vbCrLf
		For i = 0 To pCnt
			'UPGRADE_WARNING: Couldn't resolve default property of object Plugins().About. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			strDsc = strDsc & i + 2 & ". " & Plugins(i).About & vbCrLf
		Next i
		'UPGRADE_WARNING: Couldn't resolve default property of object AddrBk.About. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		strDsc = strDsc & i + 2 & ". " & AddrBk.About
		txtModules.Text = strDsc
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) \ 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) \ 2)
		
		System.Windows.Forms.Application.DoEvents()
		
	End Sub
	
	Private Sub frmAbout_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	'UPGRADE_WARNING: Form event frmAbout.QueryUnload has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
	Private Sub frmAbout_Closing(ByVal eventSender As System.Object, ByVal eventArgs As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
		Dim Cancel As Short = eventArgs.Cancel
		EndingFlag = True
		eventArgs.Cancel = Cancel
	End Sub
	
	Private Sub lblMail_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblMail.Click
		ShellExecute(0, "open", "mailto:" & lblMail.Text & "?subject=GFE_Question ", "", "", SW_SHOWMAXIMIZED)
	End Sub
	
	Private Sub lblMail_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblMail.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Me.Cursor = System.Windows.Forms.Cursors.Help
	End Sub
	
	Private Sub lblUrl_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblUrl.Click
		ShellExecute(0, "open", lblUrl.Text, "", "", SW_SHOWMAXIMIZED)
	End Sub
	
	Private Sub lblUrl_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles lblUrl.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		'UPGRADE_ISSUE: Form property frmAbout.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Me.MouseIcon = Me.Icon
		'UPGRADE_ISSUE: Form property frmAbout.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2036"'
		Me.Cursor = vbCustom
	End Sub
	
	Private Sub picTab_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles picTab.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim Index As Short = picTab.GetIndex(eventSender)
		Select Case Index
			Case 1
				Me.Cursor = System.Windows.Forms.Cursors.Default
		End Select
	End Sub
	
	Private Sub picTab_Paint(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.PaintEventArgs) Handles picTab.Paint
		Dim Index As Short = picTab.GetIndex(eventSender)
		Select Case Index
			Case 1
				lblLicense.Text = "This Product Licensed to:" & vbCrLf & GetString(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows NT\CurrentVersion", "RegisteredOwner", "Vasya Pupkin") & " - " & GetString(HKEY_LOCAL_MACHINE, "SOFTWARE\Microsoft\Windows NT\CurrentVersion", "RegisteredOrganization", "Pupkinz Inc.")
				
			Case 2
				If GetSysInfo = False Then
					Exit Sub
				End If
				txtComputer.Text = "The OS Codename =" & OS_CodeName & vbCrLf & "The Type of OS = Windows " & modSystemInfo.OS_Type & vbCrLf & "The OS Version = " & OS_Version & vbCrLf & "The OS Build = " & OS_Build & vbCrLf & "The OS ServicePack = " & OS_ServicePack & vbCrLf & vbCrLf & "The # of CPUs installed = " & CPU_Count & vbCrLf & "The Type of CPU = " & CPU_Type & vbCrLf & "The CPU Speed = " & CPU_Speed & vbCrLf & vbCrLf & "The Installed RAM = " & CPU_RAM
		End Select
	End Sub
	
	Private Sub tabAbout_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tabAbout.ClickEvent
		Dim a As Short
		If Not tabAbout.SelectedItem Is Nothing Then
			For a = 1 To picTab.Count
				If a = tabAbout.SelectedItem.Index Then
					picTab(a).Visible = True
					If a = 3 Then
						EndingFlag = False
						RunScroll()
					End If
				Else
					picTab(a).Visible = False
					EndingFlag = True
				End If
			Next 
		End If
	End Sub
	
	Private Sub RunScroll()
		On Error GoTo errHandler
		Dim LastFrameTime As Integer
		Const IntervalTime As Integer = 20
		Dim rT As Integer
		Dim DrawingRect As RECT
		Dim RectHeight As Integer
		Dim ScrollText As String
		
		'get text
		rT = FreeFile
		FileOpen(rT, VB6.GetPath & "\WhatsNew.txt", OpenMode.Binary)
		ScrollText = Space(LOF(rT))
		'UPGRADE_WARNING: Get was upgraded to FileGet and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		FileGet(rT, ScrollText)
		FileClose(rT)
		
		ScrollText = New String(" ", (59 - Len(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)) \ 2) & System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & vbCrLf & ScrollText
		
		'UPGRADE_ISSUE: PictureBox property picTab.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		rT = DrawText(picTab(3).hdc, ScrollText, -1, DrawingRect, DT_CALCRECT)
		
		If rT = 0 Then 'err
			ApiErrorLookup(GetLastError, "frmAbout::RunScroll")
			MsgBox("Error Scrolling Text", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name)
			EndingFlag = True
		Else
			DrawingRect.Top = picTab(3).ClientRectangle.Height
			DrawingRect.Left_Renamed = 0
			DrawingRect.Right_Renamed = picTab(3).ClientRectangle.Width
			RectHeight = DrawingRect.Bottom
			DrawingRect.Bottom = DrawingRect.Bottom + picTab(3).ClientRectangle.Height
		End If
		
		Do While Not EndingFlag
			
			If GetTickCount() - LastFrameTime >= IntervalTime Then
				
				'UPGRADE_ISSUE: PictureBox method picTab.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
				picTab(3).Cls()
				'UPGRADE_ISSUE: PictureBox property picTab.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
				DrawText(picTab(3).hdc, ScrollText, -1, DrawingRect, DT_LEFT) 'Or DT_WORDBREAK
				
				DrawingRect.Top = DrawingRect.Top - 1
				DrawingRect.Bottom = DrawingRect.Bottom - 1
				
				If DrawingRect.Top < -(RectHeight) Then 'time to reset
					DrawingRect.Top = picTab(3).ClientRectangle.Height
					DrawingRect.Bottom = RectHeight + picTab(3).ClientRectangle.Height
				End If
				
				picTab(3).Refresh()
				
				LastFrameTime = GetTickCount()
			End If
			System.Windows.Forms.Application.DoEvents()
			Sleep(10)
		Loop 
		
		Exit Sub
errHandler: 
		Select Case Err.Number
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmAbout::RunScroll")
		End Select
	End Sub
End Class