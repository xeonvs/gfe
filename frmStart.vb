Option Explicit On
Option Strict Off

Imports System.Drawing

''' <summary>
''' Заставка при запуске.
''' </summary>
Public Class frmStart

    Private Const moduleImageSize As Integer = 32
    Private Const moduleItemWidth As Integer = 48
    Private Const moduleTopShift As Integer = 8
    Private Const moduleBottomShift As Integer = 8
    Private Const moduleItemHeight As Integer = 100 - moduleTopShift - moduleBottomShift
    Private Const moduleInterval As Integer = 8
    Private msg As String

    ''' <summary>
    ''' Обновляет имя текущей сканируемой эхи
    ''' </summary> 
    Public Property RefreshEchoName() As String
        Get
            Return msg
        End Get
        Set(ByVal value As String)
            msg = value
            picEchoName.Refresh()
        End Set
    End Property

    Private Sub picModules_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picModules.MouseClick
        Me.Close()
    End Sub

    Private Sub picModules_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picModules.Paint
        Dim x As Double = moduleInterval
        Dim cdb As IDatabases

        'databases
        For Each item As [Enum] In Bases.Keys
            cdb = Activator.CreateInstance(Bases.Item(item))
            DrawModuleItem(cdb, e.Graphics, New Rectangle(x, moduleTopShift, moduleItemWidth, moduleItemHeight))
            x += moduleInterval + moduleItemWidth
        Next

    End Sub

    Private Sub DrawModuleItem(ByVal info As Object, ByVal graphics As Graphics, ByVal rectangle As Rectangle)
        Dim img As Image = info.GetModuleIcon()

        If Not img Is Nothing Then
            graphics.DrawImage(img, _
             CSng(rectangle.Left + (rectangle.Width - moduleImageSize) / 2), _
              rectangle.Top, moduleImageSize, moduleImageSize)

            Dim sf As StringFormat = New StringFormat()
            sf.Alignment = StringAlignment.Center

            graphics.DrawString(info.Description, picModules.Font, Brushes.White, _
                    New Rectangle( _
                                    rectangle.Left, _
                                    rectangle.Top + moduleImageSize, _
                                    rectangle.Width, rectangle.Height - moduleImageSize), _
                    sf)
        End If
    End Sub

    Private Sub TimerUnload_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerUnload.Tick
        Me.Close()
    End Sub

    Private Sub frmStart_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Me.Close()
    End Sub

    Private Sub frmStart_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TimerUnload.Enabled = True
        Application.DoEvents()
    End Sub

    Private Sub frmStart_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Me.Close()
    End Sub

    Private Sub picEchoName_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picEchoName.Paint
        e.Graphics.DrawString(msg, Font, Brushes.WhiteSmoke, _
                        New Rectangle(0, 0, picEchoName.Width, picEchoName.Width))
    End Sub
End Class