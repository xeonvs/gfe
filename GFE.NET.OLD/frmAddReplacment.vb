Option Strict Off
Option Explicit On
Friend Class frmAddReplacment
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
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents txtOnWhat As System.Windows.Forms.TextBox
	Public WithEvents txtWhat As System.Windows.Forms.TextBox
	Public WithEvents lblOnWhat As System.Windows.Forms.Label
	Public WithEvents lblWhat As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAddReplacment))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.txtOnWhat = New System.Windows.Forms.TextBox
		Me.txtWhat = New System.Windows.Forms.TextBox
		Me.lblOnWhat = New System.Windows.Forms.Label
		Me.lblWhat = New System.Windows.Forms.Label
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Замены символов"
		Me.ClientSize = New System.Drawing.Size(156, 121)
		Me.Location = New System.Drawing.Point(3, 25)
		Me.Icon = CType(resources.GetObject("frmAddReplacment.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmAddReplacment"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "&Отмена"
		Me.cmdCancel.Size = New System.Drawing.Size(51, 21)
		Me.cmdCancel.Location = New System.Drawing.Point(85, 95)
		Me.cmdCancel.TabIndex = 5
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOk.Text = "&Ok"
		Me.cmdOk.Size = New System.Drawing.Size(51, 21)
		Me.cmdOk.Location = New System.Drawing.Point(15, 95)
		Me.cmdOk.TabIndex = 4
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.txtOnWhat.AutoSize = False
		Me.txtOnWhat.Size = New System.Drawing.Size(146, 19)
		Me.txtOnWhat.Location = New System.Drawing.Point(5, 65)
		Me.txtOnWhat.TabIndex = 3
		Me.txtOnWhat.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtOnWhat.AcceptsReturn = True
		Me.txtOnWhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtOnWhat.BackColor = System.Drawing.SystemColors.Window
		Me.txtOnWhat.CausesValidation = True
		Me.txtOnWhat.Enabled = True
		Me.txtOnWhat.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtOnWhat.HideSelection = True
		Me.txtOnWhat.ReadOnly = False
		Me.txtOnWhat.Maxlength = 0
		Me.txtOnWhat.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtOnWhat.MultiLine = False
		Me.txtOnWhat.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtOnWhat.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtOnWhat.TabStop = True
		Me.txtOnWhat.Visible = True
		Me.txtOnWhat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtOnWhat.Name = "txtOnWhat"
		Me.txtWhat.AutoSize = False
		Me.txtWhat.Size = New System.Drawing.Size(146, 19)
		Me.txtWhat.Location = New System.Drawing.Point(5, 25)
		Me.txtWhat.TabIndex = 2
		Me.txtWhat.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWhat.AcceptsReturn = True
		Me.txtWhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtWhat.BackColor = System.Drawing.SystemColors.Window
		Me.txtWhat.CausesValidation = True
		Me.txtWhat.Enabled = True
		Me.txtWhat.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtWhat.HideSelection = True
		Me.txtWhat.ReadOnly = False
		Me.txtWhat.Maxlength = 0
		Me.txtWhat.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtWhat.MultiLine = False
		Me.txtWhat.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtWhat.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtWhat.TabStop = True
		Me.txtWhat.Visible = True
		Me.txtWhat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtWhat.Name = "txtWhat"
		Me.lblOnWhat.Text = "На какой символ заменяем:"
		Me.lblOnWhat.Size = New System.Drawing.Size(146, 13)
		Me.lblOnWhat.Location = New System.Drawing.Point(5, 50)
		Me.lblOnWhat.TabIndex = 1
		Me.lblOnWhat.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblOnWhat.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblOnWhat.BackColor = System.Drawing.SystemColors.Control
		Me.lblOnWhat.Enabled = True
		Me.lblOnWhat.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblOnWhat.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblOnWhat.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblOnWhat.UseMnemonic = True
		Me.lblOnWhat.Visible = True
		Me.lblOnWhat.AutoSize = True
		Me.lblOnWhat.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblOnWhat.Name = "lblOnWhat"
		Me.lblWhat.Text = "Какой символ заменяем:"
		Me.lblWhat.Size = New System.Drawing.Size(130, 13)
		Me.lblWhat.Location = New System.Drawing.Point(5, 10)
		Me.lblWhat.TabIndex = 0
		Me.lblWhat.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWhat.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblWhat.BackColor = System.Drawing.SystemColors.Control
		Me.lblWhat.Enabled = True
		Me.lblWhat.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWhat.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWhat.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWhat.UseMnemonic = True
		Me.lblWhat.Visible = True
		Me.lblWhat.AutoSize = True
		Me.lblWhat.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWhat.Name = "lblWhat"
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(txtOnWhat)
		Me.Controls.Add(txtWhat)
		Me.Controls.Add(lblOnWhat)
		Me.Controls.Add(lblWhat)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmAddReplacment
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmAddReplacment
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmAddReplacment()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
	Public id As Short
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
		Select Case id
			Case 0
				frmOptions.DefInstance.lstReplacments.ListItems.Add( ,  , txtWhat.Text).SubItems(1) = txtOnWhat.Text
			Case Else
				frmOptions.DefInstance.lstReplacments.ListItems.Item(id).Default = txtWhat.Text
				frmOptions.DefInstance.lstReplacments.ListItems.Item(id).SubItems(1) = txtOnWhat.Text
		End Select
		Me.Close()
	End Sub
End Class