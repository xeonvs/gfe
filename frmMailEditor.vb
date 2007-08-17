Option Explicit On
Option Strict Off

Imports System.Data

''' <summary>
''' Форма редактора сообщений. Представляет собой сомостоятельный объект для манипулирования сообщением к конкретной эхе.
''' </summary>
Public Class frmMailEditor
    Dim myEcho As IDatabases                        'Интерфейс к текущей базе
    Dim myMode As ReplayMode = ReplayMode.NewMail   'Режим работы с базой
    Dim myMessageNumber As Integer                  'Номер сообщения

    Private Sub exitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitToolStripMenuItem.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Указывает на текущую эху с которой работет редактор
    ''' </summary>
    ''' <value>Интерфейс к текущей эхе</value>
    Public Property CurrentEcho() As IDatabases
        Get
            Return myEcho
        End Get
        Set(ByVal value As IDatabases)
            myEcho = value
        End Set
    End Property

    ''' <summary>
    ''' Указывает текущий режим работы данного окна редактора
    ''' </summary>
    Public Property EditorMode() As ReplayMode
        Get
            Return myMode
        End Get
        Set(ByVal value As ReplayMode)
            myMode = value
        End Set
    End Property

    ''' <summary>
    ''' Указывает на текущий номер письма
    ''' </summary>
    ''' <remarks>Для нового письма должно хранить -1</remarks>
    Public Property CurrentMessageNumber() As Integer
        Get
            Return myMessageNumber
        End Get
        Set(ByVal value As Integer)
            myMessageNumber = value
        End Set
    End Property

    Private Sub frmMailEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.LoadSmiles()

        Select Case Me.EditorMode
            Case ReplayMode.NewMail
                Me.Text = Me.Tag.ToString & "::New Mail"

            Case ReplayMode.ViewMails
                Me.Text = Me.Tag.ToString & "::View Mail"
                Me.DisplayMessage()

            Case Else
                Me.Close()
        End Select
    End Sub

    ''' <summary>
    ''' Нажатие кнопки с смайликом
    ''' </summary> 
    Public Sub Smiles_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        rtfMessage.SelectedText = " " & sender.Tag.ToString
    End Sub

    ''' <summary>
    ''' Загружает в тулбар смайлы из XML
    ''' </summary>    
    Private Sub LoadSmiles()

        Me.ToolStripSmiles.Items.Clear()
        For i As Integer = 0 To dsSmiles.Tables(0).Rows.Count - 1
            Dim tlbBtn As New ToolStripButton("", Image.FromFile(SmilesPath & dsSmiles.Tables(0).Rows(i).Item("Path").ToString), AddressOf Me.Smiles_Click)

            tlbBtn.Name = "Smile" & dsSmiles.Tables(0).Rows(i).Item("Id").ToString
            tlbBtn.Tag = dsSmiles.Tables(0).Rows(i).Item("Smile").ToString
            tlbBtn.ToolTipText = tlbBtn.Tag.ToString
            tlbBtn.AutoSize = True
            tlbBtn.ImageAlign = ContentAlignment.MiddleCenter
            tlbBtn.ImageScaling = ToolStripItemImageScaling.None

            Me.ToolStripSmiles.Items.AddRange(New Windows.Forms.ToolStripItem() {tlbBtn})
        Next

        Me.ToolStripSmiles.Update()

    End Sub

    Private Sub DisplayMessage()

        newToolStripButton.Enabled = False
        cutToolStripButton.Enabled = False
        pasteToolStripButton.Enabled = False
        newToolStripMenuItem.Enabled = False
        cutToolStripMenuItem.Enabled = False
        pasteToolStripMenuItem.Enabled = False
        ToolStripSmiles.Enabled = False

        rtfMessage.Clear()

        myEcho.GetHeadesByNum(myMessageNumber)
        myEcho.GetMessageByNum(myMessageNumber)

        Me.Text &= "::" & myEcho.Subject
        If myEcho.MessageText.Length <> 0 Then
            rtfMessage.Text = myEcho.MessageText
        End If

        modCommon.ReplaceSmiles(Me.rtfMessage)

        rtfMessage.ReadOnly = True

    End Sub

    Private Sub SendToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendToolStripMenuItem.Click
        myEcho.WriteMessage()
    End Sub
End Class