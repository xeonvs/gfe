Option Strict Off
Option Explicit On
Friend Class frmDisplayOrigins
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
	Public WithEvents lstOrigins As System.Windows.Forms.ListBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDisplayOrigins))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.lstOrigins = New System.Windows.Forms.ListBox
		Me.ControlBox = False
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.ClientSize = New System.Drawing.Size(396, 287)
		Me.Location = New System.Drawing.Point(3, 3)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmDisplayOrigins"
		Me.lstOrigins.Size = New System.Drawing.Size(386, 280)
		Me.lstOrigins.Location = New System.Drawing.Point(5, 5)
		Me.lstOrigins.TabIndex = 0
		Me.lstOrigins.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstOrigins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstOrigins.BackColor = System.Drawing.SystemColors.Window
		Me.lstOrigins.CausesValidation = True
		Me.lstOrigins.Enabled = True
		Me.lstOrigins.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstOrigins.IntegralHeight = True
		Me.lstOrigins.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstOrigins.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstOrigins.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstOrigins.Sorted = False
		Me.lstOrigins.TabStop = True
		Me.lstOrigins.Visible = True
		Me.lstOrigins.MultiColumn = False
		Me.lstOrigins.Name = "lstOrigins"
		Me.Controls.Add(lstOrigins)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmDisplayOrigins
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmDisplayOrigins
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmDisplayOrigins()
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
	
	Dim frmParent As System.Windows.Forms.Form
	
	'получает родительскую форму
	'UPGRADE_NOTE: Parent was upgraded to Parent_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Public WriteOnly Property Parent_Renamed() As System.Windows.Forms.Form
		Set(ByVal Value As System.Windows.Forms.Form)
			frmParent = Value
		End Set
	End Property
	
	Private Sub frmDisplayOrigins_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 27 Then
			Me.Close()
		End If
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub frmDisplayOrigins_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim txt As String
		Dim ff As Integer
		Dim tmp As String
		
		On Error GoTo noor
		ff = FreeFile
		FileOpen(ff, VB6.GetPath & "\origin.txt", OpenMode.Input)
		While Not EOF(ff)
			txt = LineInput(ff)
			tmp = Space(Len(txt))
			OemToChar(txt, tmp) 'перекодируем дос кодировку в виндовс
			txt = tmp
			lstOrigins.Items.Add(txt)
		End While
		FileClose(ff)
		System.Windows.Forms.Application.DoEvents()
		Exit Sub
noor: 
		lstOrigins.Items.Add("No Origin!")
		System.Windows.Forms.Application.DoEvents()
	End Sub
	
	'UPGRADE_WARNING: Event lstOrigins.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub lstOrigins_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstOrigins.SelectedIndexChanged
		'UPGRADE_ISSUE: Control Origin could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
		frmParent.Origin = lstOrigins.Text
		Me.Close()
	End Sub
	
	Private Sub lstOrigins_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles lstOrigins.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 27 Then
			Me.Close()
		End If
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
End Class