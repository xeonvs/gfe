Option Strict Off
Option Explicit On
Friend Class frmEchoSelect
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
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents lstEchos As System.Windows.Forms.CheckedListBox
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents lblEcho As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEchoSelect))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.lstEchos = New System.Windows.Forms.CheckedListBox
		Me.cmdOk = New System.Windows.Forms.Button
		Me.lblEcho = New System.Windows.Forms.Label
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Выбор Конференций"
		Me.ClientSize = New System.Drawing.Size(236, 453)
		Me.Location = New System.Drawing.Point(3, 25)
		Me.Icon = CType(resources.GetObject("frmEchoSelect.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmEchoSelect"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "&Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(51, 26)
		Me.cmdCancel.Location = New System.Drawing.Point(140, 420)
		Me.cmdCancel.TabIndex = 3
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.lstEchos.Size = New System.Drawing.Size(226, 394)
		Me.lstEchos.Location = New System.Drawing.Point(5, 20)
		Me.lstEchos.TabIndex = 1
		Me.lstEchos.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstEchos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstEchos.BackColor = System.Drawing.SystemColors.Window
		Me.lstEchos.CausesValidation = True
		Me.lstEchos.Enabled = True
		Me.lstEchos.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstEchos.IntegralHeight = True
		Me.lstEchos.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstEchos.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstEchos.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstEchos.Sorted = False
		Me.lstEchos.TabStop = True
		Me.lstEchos.Visible = True
		Me.lstEchos.MultiColumn = False
		Me.lstEchos.Name = "lstEchos"
		Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOk.Text = "&Ok"
		Me.cmdOk.Size = New System.Drawing.Size(51, 26)
		Me.cmdOk.Location = New System.Drawing.Point(40, 420)
		Me.cmdOk.TabIndex = 0
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.lblEcho.Text = "Выбор конференции:"
		Me.lblEcho.Size = New System.Drawing.Size(107, 13)
		Me.lblEcho.Location = New System.Drawing.Point(5, 5)
		Me.lblEcho.TabIndex = 2
		Me.lblEcho.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEcho.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblEcho.BackColor = System.Drawing.SystemColors.Control
		Me.lblEcho.Enabled = True
		Me.lblEcho.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblEcho.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblEcho.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblEcho.UseMnemonic = True
		Me.lblEcho.Visible = True
		Me.lblEcho.AutoSize = True
		Me.lblEcho.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblEcho.Name = "lblEcho"
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(lstEchos)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(lblEcho)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmEchoSelect
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmEchoSelect
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmEchoSelect()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
	Private frmParent As System.Windows.Forms.Form
	Private flg As Boolean
	
	'получает родительскую форму
	'UPGRADE_NOTE: Parent was upgraded to Parent_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Public WriteOnly Property Parent_Renamed() As System.Windows.Forms.Form
		Set(ByVal Value As System.Windows.Forms.Form)
			frmParent = Value
		End Set
	End Property
	
	'Получает флаг разрешения выбора эхи
	Public WriteOnly Property SelectEcho() As Boolean
		Set(ByVal Value As Boolean)
			flg = Value
		End Set
	End Property
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Dim ec(0) As String
		'UPGRADE_ISSUE: Control SelectedEchos could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
		frmParent.SelectedEchos = VB6.CopyArray(ec)
		Me.Close()
	End Sub
	
	Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
		Dim i As Integer
		Dim ec() As String
		Dim k As Integer
		
		k = 0
		ReDim ec(0)
		For i = 0 To lstEchos.Items.Count - 1
			If lstEchos.GetItemChecked(i) = True Then
				ReDim Preserve ec(k)
				ec(k) = VB6.GetItemString(lstEchos, i)
				k = k + 1
			End If
		Next i
		
		'UPGRADE_ISSUE: Control SelectedEchos could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
		frmParent.SelectedEchos = VB6.CopyArray(ec)
		Me.Close()
		
	End Sub
	
	Private Sub frmEchoSelect_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim ECNum As Integer
		Dim idx As Integer
		
		On Error Resume Next
		
		'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.EchosCount. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		For ECNum = 1 To clsEchos.EchosCount
			'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoNameByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			lstEchos.Items.Add(clsEchos.GetEchoNameByNum(ECNum))
			If flg Then
				'если у нас в первых 3х строчках встречается имя эхи и это не текущая то выделяем ее
				'UPGRADE_WARNING: Couldn't resolve default property of object clsEchos.GetEchoNameByNum. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				'UPGRADE_ISSUE: Control rtfMessage could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2072"'
				If frmParent.rtfMessage.Find(clsEchos.GetEchoNameByNum(ECNum),  ,  , RichTextLib.FindConstants.rtfNoHighlight) <> -1 And frmMain.DefInstance.EchoList.SelectedItem.Text <> clsEchos.GetEchoNameByNum(ECNum) Then
					lstEchos.SetItemChecked(idx, True)
					flg = False
					System.Windows.Forms.Application.DoEvents()
				End If
				idx = idx + 1
			End If
		Next 
		
		System.Windows.Forms.Application.DoEvents()
		
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) \ 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) \ 2)
		
		
	End Sub
End Class