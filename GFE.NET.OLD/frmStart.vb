Option Strict Off
Option Explicit On
Friend Class frmStart
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
	Public WithEvents tmrUnload As System.Windows.Forms.Timer
	Public WithEvents lblEcho As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmStart))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.tmrUnload = New System.Windows.Forms.Timer(components)
		Me.lblEcho = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.BackColor = System.Drawing.SystemColors.ControlDark
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Text = "GFE"
		Me.ClientSize = New System.Drawing.Size(540, 242)
		Me.Location = New System.Drawing.Point(0, 0)
		Me.BackgroundImage = CType(resources.GetObject("frmStart.BackgroundImage"), System.Drawing.Image)
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmStart"
		Me.tmrUnload.Enabled = False
		Me.tmrUnload.Interval = 5000
		Me.lblEcho.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblEcho.Text = "RU.VISUAL.BASIC"
		Me.lblEcho.ForeColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.lblEcho.Size = New System.Drawing.Size(276, 16)
		Me.lblEcho.Location = New System.Drawing.Point(252, 5)
		Me.lblEcho.TabIndex = 0
		Me.lblEcho.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEcho.BackColor = System.Drawing.Color.Transparent
		Me.lblEcho.Enabled = True
		Me.lblEcho.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblEcho.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblEcho.UseMnemonic = True
		Me.lblEcho.Visible = True
		Me.lblEcho.AutoSize = False
		Me.lblEcho.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblEcho.Name = "lblEcho"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.Label1.Text = "Label1"
		Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.FromARGB(203, 193, 146)
		Me.Label1.Size = New System.Drawing.Size(160, 17)
		Me.Label1.Location = New System.Drawing.Point(368, 143)
		Me.Label1.TabIndex = 1
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.Label2.Text = "Label1"
		Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.Black
		Me.Label2.Size = New System.Drawing.Size(161, 17)
		Me.Label2.Location = New System.Drawing.Point(369, 145)
		Me.Label2.TabIndex = 2
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Enabled = True
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.Label3.Text = "Label1"
		Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.Label3.Size = New System.Drawing.Size(161, 17)
		Me.Label3.Location = New System.Drawing.Point(370, 146)
		Me.Label3.TabIndex = 3
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Enabled = True
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Controls.Add(lblEcho)
		Me.Controls.Add(Label1)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label3)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmStart
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmStart
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmStart()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
	Private Const SWP_NOSIZE As Integer = &H1s
	Private Const SWP_NOMOVE As Integer = &H2s
	Private Const SWP_NOZORDER As Integer = &H4s
	Private Const SWP_NOREDRAW As Integer = &H8s
	Private Const SWP_NOACTIVATE As Integer = &H10s
	Private Const SWP_FRAMECHANGED As Integer = &H20s '  The frame changed: send WM_NCCALCSIZE
	Private Const SWP_SHOWWINDOW As Integer = &H40s
	Private Const SWP_HIDEWINDOW As Integer = &H80s
	Private Const SWP_NOCOPYBITS As Integer = &H100s
	Private Const SWP_NOOWNERZORDER As Integer = &H200s '  Don't do owner Z ordering
	Private Const SWP_DRAWFRAME As Integer = SWP_FRAMECHANGED
	Private Const SWP_NOREPOSITION As Integer = SWP_NOOWNERZORDER
	
	Private Const HWND_TOP As Integer = 0
	Private Const HWND_BOTTOM As Integer = 1
	Private Const HWND_TOPMOST As Integer = -1
	Private Const HWND_NOTOPMOST As Integer = -2
	
	Private Declare Function SetWindowPos Lib "user32" (ByVal hWnd As Integer, ByVal hWndInsertAfter As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
	
	Private Declare Function DrawIcon Lib "user32" (ByVal hdc As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal hIcon As Integer) As Integer
	'-------End------------
	
	Private mbOnTop As Boolean
	
	'~~~.OnTop
	
	Public Property OnTop() As Boolean
		Get
			OnTop = mbOnTop
		End Get
		Set(ByVal Value As Boolean)
			
			If Value Then
				SetWindowPos(Handle.ToInt32, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOSIZE)
			Else
				SetWindowPos(Handle.ToInt32, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOSIZE)
			End If
			
			mbOnTop = Value
		End Set
	End Property
	
	Private Sub frmStart_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Click
		Me.Close()
	End Sub
	
	Private Sub frmStart_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Me.Close()
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub frmStart_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		On Error GoTo errHandler
		Dim i, ret, pCnt As Integer
		Dim px As Integer
		
		Const stTop As Integer = 205
		
		If mbOnTop Then
			Exit Sub
		End If
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) \ 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) \ 2)
		
		'UPGRADE_ISSUE: App property App.Revision was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		Label1.Text = "Build " & App.Revision
		'UPGRADE_ISSUE: App property App.Revision was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		Label2.Text = "Build " & App.Revision
		'UPGRADE_ISSUE: App property App.Revision was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
		Label3.Text = "Build " & App.Revision
		
		'адресная книга у нас отдельный объект косвенно относящийся к плугинам, _
		'обработаем его отдельно.
		'On Error Resume Next
		'UPGRADE_WARNING: Couldn't resolve default property of object AddrBk.ThumbImg. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_ISSUE: Form property frmStart.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		ret = DrawIcon(Me.hdc, 5, stTop, AddrBk.ThumbImg)
		System.Windows.Forms.Application.DoEvents()
		Err.Clear()
		'сделаем вот так, в pCnt будет -1 если плугины не найдены
		pCnt = UBound(Plugins)
		If Err.Number <> 0 Then
			pCnt = -1
		End If
		
		px = 42 ' 5 + 32 + 5 'начальная позиция + ширина иконки + шаг
		
		'проходим по всем плугинам,иконки идут с шагом 5px по горизонтали
		For i = 0 To pCnt
			'UPGRADE_WARNING: Couldn't resolve default property of object Plugins().ThumbImg. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_ISSUE: Form property frmStart.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			ret = DrawIcon(Me.hdc, px, stTop, Plugins(i).ThumbImg)
			frmMain.DefInstance.mnuPlugins.Load(i + 1)
			'UPGRADE_WARNING: Couldn't resolve default property of object Plugins(i).MenuItemString. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			frmMain.DefInstance.mnuPlugins(i + 1).Text = Plugins(i).MenuItemString
			frmMain.DefInstance.mnuPlugins(i + 1).Enabled = True
			'UPGRADE_WARNING: Couldn't resolve default property of object Plugins().Work. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Call Plugins(i).Work() 'плугин уже инициализирован теперь запускается в работу
			px = px + 37 '32+5
			System.Windows.Forms.Application.DoEvents()
		Next i
		'On Error GoTo 0
		
		tmrUnload.Enabled = True
		System.Windows.Forms.Application.DoEvents()
		Exit Sub
		
errHandler: 
		Select Case Err.Number
			Case 9
				'ignore
			Case 91
				'ignore
				Resume Next
			Case 360
				'ignore
			Case 438, 480
				'ignore
				Resume Next
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmStart::Form_Load")
				Resume Next
		End Select
	End Sub
	
	Private Sub tmrUnload_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrUnload.Tick
		Me.Close()
	End Sub
	
	'выгружает форму из другой формы
	Public Sub UnloadMe()
		Me.Close()
	End Sub
End Class