Option Strict Off
Option Explicit On
Friend Class frmAreaInfo
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
	Public WithEvents lblPathL As System.Windows.Forms.Label
	Public WithEvents lblUplinkL As System.Windows.Forms.Label
	Public WithEvents lblEchoPath As System.Windows.Forms.Label
	Public WithEvents lblUplink As System.Windows.Forms.Label
	Public WithEvents lblEchoTypeL As System.Windows.Forms.Label
	Public WithEvents lblEchoType As System.Windows.Forms.Label
	Public WithEvents fraAreaInfo As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAreaInfo))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.fraAreaInfo = New System.Windows.Forms.GroupBox
		Me.lblPathL = New System.Windows.Forms.Label
		Me.lblUplinkL = New System.Windows.Forms.Label
		Me.lblEchoPath = New System.Windows.Forms.Label
		Me.lblUplink = New System.Windows.Forms.Label
		Me.lblEchoTypeL = New System.Windows.Forms.Label
		Me.lblEchoType = New System.Windows.Forms.Label
		Me.ControlBox = False
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.ClientSize = New System.Drawing.Size(312, 116)
		Me.Location = New System.Drawing.Point(1, 1)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmAreaInfo"
		Me.fraAreaInfo.Size = New System.Drawing.Size(297, 105)
		Me.fraAreaInfo.Location = New System.Drawing.Point(8, 4)
		Me.fraAreaInfo.TabIndex = 0
		Me.fraAreaInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraAreaInfo.BackColor = System.Drawing.SystemColors.Control
		Me.fraAreaInfo.Enabled = True
		Me.fraAreaInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraAreaInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraAreaInfo.Visible = True
		Me.fraAreaInfo.Name = "fraAreaInfo"
		Me.lblPathL.Text = "Путь:"
		Me.lblPathL.Size = New System.Drawing.Size(27, 13)
		Me.lblPathL.Location = New System.Drawing.Point(8, 24)
		Me.lblPathL.TabIndex = 6
		Me.lblPathL.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPathL.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblPathL.BackColor = System.Drawing.SystemColors.Control
		Me.lblPathL.Enabled = True
		Me.lblPathL.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPathL.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPathL.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPathL.UseMnemonic = True
		Me.lblPathL.Visible = True
		Me.lblPathL.AutoSize = True
		Me.lblPathL.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPathL.Name = "lblPathL"
		Me.lblUplinkL.Text = "Аплинк:"
		Me.lblUplinkL.Size = New System.Drawing.Size(40, 13)
		Me.lblUplinkL.Location = New System.Drawing.Point(128, 48)
		Me.lblUplinkL.TabIndex = 5
		Me.lblUplinkL.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUplinkL.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUplinkL.BackColor = System.Drawing.SystemColors.Control
		Me.lblUplinkL.Enabled = True
		Me.lblUplinkL.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblUplinkL.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUplinkL.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUplinkL.UseMnemonic = True
		Me.lblUplinkL.Visible = True
		Me.lblUplinkL.AutoSize = True
		Me.lblUplinkL.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblUplinkL.Name = "lblUplinkL"
		Me.lblEchoPath.BackColor = System.Drawing.Color.Transparent
		Me.lblEchoPath.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblEchoPath.Size = New System.Drawing.Size(249, 17)
		Me.lblEchoPath.Location = New System.Drawing.Point(40, 24)
		Me.lblEchoPath.TabIndex = 4
		Me.lblEchoPath.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEchoPath.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblEchoPath.Enabled = True
		Me.lblEchoPath.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblEchoPath.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblEchoPath.UseMnemonic = True
		Me.lblEchoPath.Visible = True
		Me.lblEchoPath.AutoSize = False
		Me.lblEchoPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblEchoPath.Name = "lblEchoPath"
		Me.lblUplink.BackColor = System.Drawing.Color.Transparent
		Me.lblUplink.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblUplink.Size = New System.Drawing.Size(113, 17)
		Me.lblUplink.Location = New System.Drawing.Point(176, 48)
		Me.lblUplink.TabIndex = 3
		Me.lblUplink.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUplink.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblUplink.Enabled = True
		Me.lblUplink.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblUplink.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblUplink.UseMnemonic = True
		Me.lblUplink.Visible = True
		Me.lblUplink.AutoSize = False
		Me.lblUplink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblUplink.Name = "lblUplink"
		Me.lblEchoTypeL.Text = "Тип:"
		Me.lblEchoTypeL.Size = New System.Drawing.Size(22, 13)
		Me.lblEchoTypeL.Location = New System.Drawing.Point(11, 48)
		Me.lblEchoTypeL.TabIndex = 2
		Me.lblEchoTypeL.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEchoTypeL.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblEchoTypeL.BackColor = System.Drawing.SystemColors.Control
		Me.lblEchoTypeL.Enabled = True
		Me.lblEchoTypeL.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblEchoTypeL.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblEchoTypeL.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblEchoTypeL.UseMnemonic = True
		Me.lblEchoTypeL.Visible = True
		Me.lblEchoTypeL.AutoSize = True
		Me.lblEchoTypeL.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblEchoTypeL.Name = "lblEchoTypeL"
		Me.lblEchoType.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblEchoType.BackColor = System.Drawing.Color.Transparent
		Me.lblEchoType.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lblEchoType.Size = New System.Drawing.Size(81, 17)
		Me.lblEchoType.Location = New System.Drawing.Point(40, 48)
		Me.lblEchoType.TabIndex = 1
		Me.lblEchoType.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEchoType.Enabled = True
		Me.lblEchoType.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblEchoType.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblEchoType.UseMnemonic = True
		Me.lblEchoType.Visible = True
		Me.lblEchoType.AutoSize = False
		Me.lblEchoType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblEchoType.Name = "lblEchoType"
		Me.Controls.Add(fraAreaInfo)
		Me.fraAreaInfo.Controls.Add(lblPathL)
		Me.fraAreaInfo.Controls.Add(lblUplinkL)
		Me.fraAreaInfo.Controls.Add(lblEchoPath)
		Me.fraAreaInfo.Controls.Add(lblUplink)
		Me.fraAreaInfo.Controls.Add(lblEchoTypeL)
		Me.fraAreaInfo.Controls.Add(lblEchoType)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmAreaInfo
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmAreaInfo
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmAreaInfo()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
	Private Enum BaseType
		Netmail = 1 'MSG база
		Squish = 2 'Squish Base
		Jam = 3 'JAM база
	End Enum
	
	Public WriteOnly Property AreaName() As String
		Set(ByVal Value As String)
			fraAreaInfo.Text = Value
		End Set
	End Property
	
	Public WriteOnly Property AreaPath() As String
		Set(ByVal Value As String)
			lblEchoPath.Text = Value
		End Set
	End Property
	
	Public WriteOnly Property AreaUplink() As String
		Set(ByVal Value As String)
			lblUplink.Text = Value
		End Set
	End Property
	
	Public WriteOnly Property AreaType() As String
		Set(ByVal Value As String)
			lblEchoType.Text = Value
		End Set
	End Property
	
	Private Sub frmAreaInfo_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		
		Select Case KeyCode
			
			Case System.Windows.Forms.Keys.Escape
				Me.Close()
				
		End Select
		
	End Sub
	
	Private Sub frmAreaInfo_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Me.Close()
	End Sub
	
	'UPGRADE_WARNING: Frame Event fraAreaInfo.MouseUp was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2050"'
	Private Sub fraAreaInfo_MouseUp(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single)
		Me.Close()
	End Sub
End Class