<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmStart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.picModules = New System.Windows.Forms.PictureBox
        Me.TimerUnload = New System.Windows.Forms.Timer(Me.components)
        Me.picEchoName = New System.Windows.Forms.PictureBox
        CType(Me.picModules, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEchoName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picModules
        '
        Me.picModules.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.picModules.ErrorImage = Nothing
        Me.picModules.InitialImage = Nothing
        Me.picModules.Location = New System.Drawing.Point(0, 206)
        Me.picModules.Name = "picModules"
        Me.picModules.Size = New System.Drawing.Size(540, 80)
        Me.picModules.TabIndex = 0
        Me.picModules.TabStop = False
        '
        'TimerUnload
        '
        Me.TimerUnload.Interval = 5000
        '
        'picEchoName
        '
        Me.picEchoName.BackColor = System.Drawing.Color.Transparent
        Me.picEchoName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picEchoName.ErrorImage = Nothing
        Me.picEchoName.InitialImage = Nothing
        Me.picEchoName.Location = New System.Drawing.Point(304, 8)
        Me.picEchoName.Name = "picEchoName"
        Me.picEchoName.Size = New System.Drawing.Size(224, 16)
        Me.picEchoName.TabIndex = 3
        Me.picEchoName.TabStop = False
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImage = Gfe.My.Resources.Resources.About
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(540, 286)
        Me.ControlBox = False
        Me.Controls.Add(Me.picEchoName)
        Me.Controls.Add(Me.picModules)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStart"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStart"
        Me.TopMost = True
        CType(Me.picModules, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEchoName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picModules As System.Windows.Forms.PictureBox
    Friend WithEvents TimerUnload As System.Windows.Forms.Timer
    Friend WithEvents picEchoName As System.Windows.Forms.PictureBox
End Class
