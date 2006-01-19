Option Strict Off
Option Explicit On
Friend Class GoldButton
	Inherits System.Windows.Forms.UserControl
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
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
	Friend WithEvents pBtnPicDn As System.Windows.Forms.PictureBox
	Friend WithEvents pBtnPicHov As System.Windows.Forms.PictureBox
	Friend WithEvents pBtnPicDis As System.Windows.Forms.PictureBox
	Friend WithEvents pBtnPic As System.Windows.Forms.PictureBox
	Friend WithEvents pSkinPic As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(GoldButton))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.pBtnPicDn = New System.Windows.Forms.PictureBox
		Me.pBtnPicHov = New System.Windows.Forms.PictureBox
		Me.pBtnPicDis = New System.Windows.Forms.PictureBox
		Me.pBtnPic = New System.Windows.Forms.PictureBox
		Me.pSkinPic = New System.Windows.Forms.PictureBox
		Me.ClientSize = New System.Drawing.Size(111, 114)
		MyBase.Location = New System.Drawing.Point(0, 0)
		MyBase.Name = "GoldButton"
		Me.pBtnPicDn.Size = New System.Drawing.Size(17, 17)
		Me.pBtnPicDn.Location = New System.Drawing.Point(14, 82)
		Me.pBtnPicDn.TabIndex = 4
		Me.pBtnPicDn.TabStop = False
		Me.pBtnPicDn.Visible = False
		Me.pBtnPicDn.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pBtnPicDn.Dock = System.Windows.Forms.DockStyle.None
		Me.pBtnPicDn.BackColor = System.Drawing.SystemColors.Control
		Me.pBtnPicDn.CausesValidation = True
		Me.pBtnPicDn.Enabled = True
		Me.pBtnPicDn.ForeColor = System.Drawing.SystemColors.ControlText
		Me.pBtnPicDn.Cursor = System.Windows.Forms.Cursors.Default
		Me.pBtnPicDn.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.pBtnPicDn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.pBtnPicDn.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.pBtnPicDn.Name = "pBtnPicDn"
		Me.pBtnPicHov.Size = New System.Drawing.Size(17, 17)
		Me.pBtnPicHov.Location = New System.Drawing.Point(14, 58)
		Me.pBtnPicHov.TabIndex = 3
		Me.pBtnPicHov.TabStop = False
		Me.pBtnPicHov.Visible = False
		Me.pBtnPicHov.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pBtnPicHov.Dock = System.Windows.Forms.DockStyle.None
		Me.pBtnPicHov.BackColor = System.Drawing.SystemColors.Control
		Me.pBtnPicHov.CausesValidation = True
		Me.pBtnPicHov.Enabled = True
		Me.pBtnPicHov.ForeColor = System.Drawing.SystemColors.ControlText
		Me.pBtnPicHov.Cursor = System.Windows.Forms.Cursors.Default
		Me.pBtnPicHov.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.pBtnPicHov.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.pBtnPicHov.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.pBtnPicHov.Name = "pBtnPicHov"
		Me.pBtnPicDis.Size = New System.Drawing.Size(17, 17)
		Me.pBtnPicDis.Location = New System.Drawing.Point(14, 34)
		Me.pBtnPicDis.TabIndex = 2
		Me.pBtnPicDis.TabStop = False
		Me.pBtnPicDis.Visible = False
		Me.pBtnPicDis.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pBtnPicDis.Dock = System.Windows.Forms.DockStyle.None
		Me.pBtnPicDis.BackColor = System.Drawing.SystemColors.Control
		Me.pBtnPicDis.CausesValidation = True
		Me.pBtnPicDis.Enabled = True
		Me.pBtnPicDis.ForeColor = System.Drawing.SystemColors.ControlText
		Me.pBtnPicDis.Cursor = System.Windows.Forms.Cursors.Default
		Me.pBtnPicDis.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.pBtnPicDis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.pBtnPicDis.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.pBtnPicDis.Name = "pBtnPicDis"
		Me.pBtnPic.Size = New System.Drawing.Size(17, 17)
		Me.pBtnPic.Location = New System.Drawing.Point(14, 10)
		Me.pBtnPic.TabIndex = 1
		Me.pBtnPic.TabStop = False
		Me.pBtnPic.Visible = False
		Me.pBtnPic.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pBtnPic.Dock = System.Windows.Forms.DockStyle.None
		Me.pBtnPic.BackColor = System.Drawing.SystemColors.Control
		Me.pBtnPic.CausesValidation = True
		Me.pBtnPic.Enabled = True
		Me.pBtnPic.ForeColor = System.Drawing.SystemColors.ControlText
		Me.pBtnPic.Cursor = System.Windows.Forms.Cursors.Default
		Me.pBtnPic.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.pBtnPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.pBtnPic.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.pBtnPic.Name = "pBtnPic"
		Me.pSkinPic.BackColor = System.Drawing.Color.Black
		Me.pSkinPic.Size = New System.Drawing.Size(65, 91)
		Me.pSkinPic.Location = New System.Drawing.Point(38, 10)
		Me.pSkinPic.TabIndex = 0
		Me.pSkinPic.TabStop = False
		Me.pSkinPic.Visible = False
		Me.pSkinPic.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.pSkinPic.Dock = System.Windows.Forms.DockStyle.None
		Me.pSkinPic.CausesValidation = True
		Me.pSkinPic.Enabled = True
		Me.pSkinPic.ForeColor = System.Drawing.SystemColors.ControlText
		Me.pSkinPic.Cursor = System.Windows.Forms.Cursors.Default
		Me.pSkinPic.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.pSkinPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.pSkinPic.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.pSkinPic.Name = "pSkinPic"
		Me.Controls.Add(pBtnPicDn)
		Me.Controls.Add(pBtnPicHov)
		Me.Controls.Add(pBtnPicDis)
		Me.Controls.Add(pBtnPic)
		Me.Controls.Add(pSkinPic)
	End Sub
#End Region 
	Public Event PictureDownChange()
	Public Event OnDownChange()
	Public Event PictureDisabledChange()
	Public Event EnabledChange()
	Public Event DownColorChange()
	Public Event FontChange()
	Public Event SkinPictureChange()
	Public Event CaptionChange()
	Public Event OnUpChange()
	Public Event PictureChange()
	Public Event PictureHoverChange()
	Public Event HoverColorChange()
	Public Event StyleChange()
	Public Event UseMaskColorChange()
	Public Event PictureBackColorChange()
	Public Event ToolTipTextChange()
	Public Event SkinDisabledTextChange()
	Public Event OnHoverChange()
	Public Event SkinHighlightChange()
	Public Event MaskColorChange()
	Public Event ForeColorChange()
	Public Event AlignmentChange()
	'=====================================
	'== Gold Button v1.2 by Night Wolf ===
	'=====================================
	
	
	Private Structure RECT
		'UPGRADE_NOTE: Left was upgraded to Left_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Left_Renamed As Integer
		'UPGRADE_NOTE: TOp was upgraded to TOp_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim TOp_Renamed As Integer
		'UPGRADE_NOTE: Right was upgraded to Right_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Right_Renamed As Integer
		'UPGRADE_NOTE: Bottom was upgraded to Bottom_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Bottom_Renamed As Integer
	End Structure
	
	Private Declare Function GetPixel Lib "gdi32" (ByVal hdc As Integer, ByVal x As Integer, ByVal y As Integer) As Integer
	Private Declare Function SetPixel Lib "gdi32" (ByVal hdc As Integer, ByVal x As Integer, ByVal y As Integer, ByVal crColor As Integer) As Integer
	
	Private Declare Function SetCapture Lib "USER32" (ByVal hWnd As Integer) As Integer
	Private Declare Function GetCapture Lib "USER32" () As Integer
	Private Declare Function ReleaseCapture Lib "USER32" () As Integer
	Private Declare Function SetTextColor Lib "gdi32" (ByVal hdc As Integer, ByVal crColor As Integer) As Integer
	Private Declare Function BitBlt Lib "gdi32" (ByVal hDestDC As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hSrcDC As Integer, ByVal xSrc As Integer, ByVal ySrc As Integer, ByVal dwRop As Integer) As Integer
	
	Private Declare Function OleTranslateColor Lib "oleaut32.dll" (ByVal lOleColor As Integer, ByVal lHPalette As Integer, ByRef lColorRef As Integer) As Integer
	
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function FillRect Lib "USER32" (ByVal hdc As Integer, ByRef lpRect As RECT, ByVal hBrush As Integer) As Integer
	Private Declare Function GetSysColorBrush Lib "USER32" (ByVal nIndex As Integer) As Integer
	
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function DrawEdge Lib "USER32" (ByVal hdc As Integer, ByRef qrc As RECT, ByVal Edge As Integer, ByVal grfFlags As Integer) As Integer
	
	Private Const BDR_RAISED As Short = &H5s
	Private Const BDR_RAISEDINNER As Short = &H4s
	Private Const BDR_RAISEDOUTER As Short = &H1s
	Private Const BDR_SUNKEN As Short = &HAs
	Private Const BDR_SUNKENINNER As Short = &H8s
	Private Const BDR_SUNKENOUTER As Short = &H2s
	Private Const BF_BOTTOM As Short = &H8s
	Private Const BF_LEFT As Short = &H1s
	Private Const BF_RIGHT As Short = &H4s
	Private Const BF_TOP As Short = &H2s
	Private Const BF_RECT As Boolean = (BF_LEFT Or BF_TOP Or BF_RIGHT Or BF_BOTTOM)
	
	'UPGRADE_WARNING: Structure RECT may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function DrawText Lib "USER32"  Alias "DrawTextA"(ByVal hdc As Integer, ByVal lpStr As String, ByVal nCount As Integer, ByRef lpRect As RECT, ByVal wFormat As Integer) As Integer
	
	Private Const DT_VCENTER As Integer = &H4
	Private Const DT_SINGLELINE As Integer = &H20
	Private Const DT_WORD_ELLIPSIS As Integer = &H40000
	Private Const DT_CALCRECT As Short = &H400s
	Private Const DT_LEFT As Short = &H0s
	Private Const DT_RIGHT As Short = &H2s
	Private Const DT_CENTER As Short = &H1s
	Private Const DT_BOTTOM As Short = &H8s
	Private Const DT_TOP As Short = &H0s
	
	'Events
	Shadows Event Click(ByVal Sender As System.Object, ByVal e As System.EventArgs)
	Shadows Event MouseEnter(ByVal Sender As System.Object, ByVal e As System.EventArgs)
	Event MouseExit(ByVal Sender As System.Object, ByVal e As System.EventArgs)
	<System.Runtime.InteropServices.ProgId("MouseDownEventArgs_NET.MouseDownEventArgs")> Public NotInheritable Class MouseDownEventArgs
		Inherits System.EventArgs
		Public Button As Short
		Public Shift As Short
		Public x As Single
		Public y As Single
		Public Sub New(ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single)
			MyBase.New()
			Me.Button = Button
			Me.Shift = Shift
			Me.x = x
			Me.y = y
		End Sub
	End Class
	Shadows Event MouseDown(ByVal Sender As System.Object, ByVal e As MouseDownEventArgs)
	<System.Runtime.InteropServices.ProgId("MouseMoveEventArgs_NET.MouseMoveEventArgs")> Public NotInheritable Class MouseMoveEventArgs
		Inherits System.EventArgs
		Public Button As Short
		Public Shift As Short
		Public x As Single
		Public y As Single
		Public Sub New(ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single)
			MyBase.New()
			Me.Button = Button
			Me.Shift = Shift
			Me.x = x
			Me.y = y
		End Sub
	End Class
	Shadows Event MouseMove(ByVal Sender As System.Object, ByVal e As MouseMoveEventArgs)
	<System.Runtime.InteropServices.ProgId("MouseUpEventArgs_NET.MouseUpEventArgs")> Public NotInheritable Class MouseUpEventArgs
		Inherits System.EventArgs
		Public Button As Short
		Public Shift As Short
		Public x As Single
		Public y As Single
		Public Sub New(ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single)
			MyBase.New()
			Me.Button = Button
			Me.Shift = Shift
			Me.x = x
			Me.y = y
		End Sub
	End Class
	Shadows Event MouseUp(ByVal Sender As System.Object, ByVal e As MouseUpEventArgs)
	<System.Runtime.InteropServices.ProgId("OLECompleteDragEventArgs_NET.OLECompleteDragEventArgs")> Public NotInheritable Class OLECompleteDragEventArgs
		Inherits System.EventArgs
		Public Effect As Integer
		Public Sub New(ByRef Effect As Integer)
			MyBase.New()
			Me.Effect = Effect
		End Sub
	End Class
	Event OLECompleteDrag(ByVal Sender As System.Object, ByVal e As OLECompleteDragEventArgs)
	'UPGRADE_ISSUE: DataObject object was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2068"'
	<System.Runtime.InteropServices.ProgId("OLEDragOverEventArgs_NET.OLEDragOverEventArgs")> Public NotInheritable Class OLEDragOverEventArgs
		Inherits System.EventArgs
		Public Data As DataObject
		Public Effect As Integer
		Public Button As Short
		Public Shift As Short
		Public x As Single
		Public y As Single
		Public state As Short
		Public Sub New(ByRef Data As DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single, ByRef state As Short)
			MyBase.New()
			Me.Data = Data
			Me.Effect = Effect
			Me.Button = Button
			Me.Shift = Shift
			Me.x = x
			Me.y = y
			Me.state = state
		End Sub
	End Class
	Event OLEDragOver(ByVal Sender As System.Object, ByVal e As OLEDragOverEventArgs)
	'UPGRADE_ISSUE: DataObject object was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2068"'
	<System.Runtime.InteropServices.ProgId("OLEDragDropEventArgs_NET.OLEDragDropEventArgs")> Public NotInheritable Class OLEDragDropEventArgs
		Inherits System.EventArgs
		Public Data As DataObject
		Public Effect As Integer
		Public Button As Short
		Public Shift As Short
		Public x As Single
		Public y As Single
		Public Sub New(ByRef Data As DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single)
			MyBase.New()
			Me.Data = Data
			Me.Effect = Effect
			Me.Button = Button
			Me.Shift = Shift
			Me.x = x
			Me.y = y
		End Sub
	End Class
	Event OLEDragDrop(ByVal Sender As System.Object, ByVal e As OLEDragDropEventArgs)
	<System.Runtime.InteropServices.ProgId("OLEGiveFeedbackEventArgs_NET.OLEGiveFeedbackEventArgs")> Public NotInheritable Class OLEGiveFeedbackEventArgs
		Inherits System.EventArgs
		Public Effect As Integer
		Public DefaultCursors As Boolean
		Public Sub New(ByRef Effect As Integer, ByRef DefaultCursors As Boolean)
			MyBase.New()
			Me.Effect = Effect
			Me.DefaultCursors = DefaultCursors
		End Sub
	End Class
	Event OLEGiveFeedback(ByVal Sender As System.Object, ByVal e As OLEGiveFeedbackEventArgs)
	'UPGRADE_ISSUE: DataObject object was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2068"'
	<System.Runtime.InteropServices.ProgId("OLESetDataEventArgs_NET.OLESetDataEventArgs")> Public NotInheritable Class OLESetDataEventArgs
		Inherits System.EventArgs
		Public Data As DataObject
		Public DataFormat As Short
		Public Sub New(ByRef Data As DataObject, ByRef DataFormat As Short)
			MyBase.New()
			Me.Data = Data
			Me.DataFormat = DataFormat
		End Sub
	End Class
	Event OLESetData(ByVal Sender As System.Object, ByVal e As OLESetDataEventArgs)
	'UPGRADE_ISSUE: DataObject object was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2068"'
	<System.Runtime.InteropServices.ProgId("OLEStartDragEventArgs_NET.OLEStartDragEventArgs")> Public NotInheritable Class OLEStartDragEventArgs
		Inherits System.EventArgs
		Public Data As DataObject
		Public AllowedEffects As Integer
		Public Sub New(ByRef Data As DataObject, ByRef AllowedEffects As Integer)
			MyBase.New()
			Me.Data = Data
			Me.AllowedEffects = AllowedEffects
		End Sub
	End Class
	Event OLEStartDrag(ByVal Sender As System.Object, ByVal e As OLEStartDragEventArgs)
	
	Public Enum eStyle
		bsNormal
		bsSkin
	End Enum
	
	Public Enum eAlignment
		alLeft
		alRight
		alCenter
	End Enum
	
	Public Enum eEdgeUp
		bsSoftUp = &H4s
		bsDefaultUp = &H5s
		bsNoneUp = 0
	End Enum
	
	Public Enum eEdgeDn
		bsSoftDn = &H2s
		bsDefaultDn = &HAs
	End Enum
	
	Dim m_Pushed As eEdgeDn
	Dim m_UnPushed As eEdgeUp
	Dim m_Hover As eEdgeUp
	Dim m_Font As System.Drawing.Font
	Dim m_Style As eStyle
	Dim m_Caption As String
	Dim m_Enabled As Boolean
	Dim m_Align As eAlignment
	Dim m_HClr As System.Drawing.Color
	Dim m_FClr As System.Drawing.Color
	Dim m_DClr As System.Drawing.Color
	Dim m_SDClr As System.Drawing.Color
	Dim m_SHClr As System.Drawing.Color
	Dim m_PBClr As System.Drawing.Color
	Dim m_MClr As System.Drawing.Color
	Dim m_Mask As Boolean
	
	Dim iStatus As Short
	Dim fins As Boolean
	Dim ToolTip As String
	
	Private Function TranslateColor(ByVal clr As System.Drawing.Color, Optional ByRef hPal As Integer = 0) As Integer
		If OleTranslateColor(System.Drawing.ColorTranslator.ToOle(clr), hPal, TranslateColor) Then
			TranslateColor = -1
		End If
	End Function
	
	Private Sub DrawSkinBack(ByRef I As Integer)
		Dim x, y As Integer
		For x = 2 To ClientRectangle.Width - 2 Step 19
			For y = 2 To VB6.PixelsToTwipsY(ClientRectangle.Height) - 2 Step 19
				'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
				'UPGRADE_ISSUE: PictureBox property pSkinPic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
				'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
				BitBlt(hdc, x, y, 19, 19, pSkinPic.hdc, 3, 23 * I + 2, vbSrcCopy)
			Next y
		Next x
	End Sub
	
	Private Sub DrawSkin(ByRef I As Object)
		Dim x, y As Integer
		For x = 2 To ClientRectangle.Width Step 19
			'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
			'UPGRADE_WARNING: Couldn't resolve default property of object I. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_ISSUE: PictureBox property pSkinPic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			BitBlt(hdc, x, 0, 19, 2, pSkinPic.hdc, 2, 23 * I, vbSrcCopy)
		Next x
		For y = 2 To VB6.PixelsToTwipsY(ClientRectangle.Height) Step 19
			'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
			'UPGRADE_WARNING: Couldn't resolve default property of object I. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_ISSUE: PictureBox property pSkinPic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			BitBlt(hdc, 0, y, 2, 19, pSkinPic.hdc, 0, 23 * I + 2, vbSrcCopy)
		Next y
		For x = 2 To ClientRectangle.Width Step 19
			'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
			'UPGRADE_WARNING: Couldn't resolve default property of object I. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_ISSUE: PictureBox property pSkinPic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			BitBlt(hdc, x, VB6.PixelsToTwipsY(ClientRectangle.Height) - 2, 19, 2, pSkinPic.hdc, 2, 23 * (I + 1) - 2, vbSrcCopy)
		Next x
		For y = 2 To VB6.PixelsToTwipsY(ClientRectangle.Height) Step 19
			'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
			'UPGRADE_WARNING: Couldn't resolve default property of object I. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_ISSUE: PictureBox property pSkinPic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			BitBlt(hdc, ClientRectangle.Width - 2, y, 2, 19, pSkinPic.hdc, 80, 23 * I + 2, vbSrcCopy)
		Next y
		'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
		'UPGRADE_WARNING: Couldn't resolve default property of object I. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_ISSUE: PictureBox property pSkinPic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		BitBlt(hdc, 0, 0, 2, 2, pSkinPic.hdc, 0, 23 * I, vbSrcCopy)
		'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
		'UPGRADE_WARNING: Couldn't resolve default property of object I. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_ISSUE: PictureBox property pSkinPic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		BitBlt(hdc, ClientRectangle.Width - 2, 0, 2, 2, pSkinPic.hdc, 80, 23 * I, vbSrcCopy)
		'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
		'UPGRADE_WARNING: Couldn't resolve default property of object I. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_ISSUE: PictureBox property pSkinPic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		BitBlt(hdc, 0, VB6.PixelsToTwipsY(ClientRectangle.Height) - 2, 2, 2, pSkinPic.hdc, 0, 23 * (I + 1) - 2, vbSrcCopy)
		'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
		'UPGRADE_WARNING: Couldn't resolve default property of object I. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_ISSUE: PictureBox property pSkinPic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		BitBlt(hdc, ClientRectangle.Width - 2, VB6.PixelsToTwipsY(ClientRectangle.Height) - 2, 2, 2, pSkinPic.hdc, 80, 23 * (I + 1) - 2, vbSrcCopy)
	End Sub
	
	Private Sub Render(Optional ByVal bPressed As Boolean = False, Optional ByVal bHover As Boolean = False)
		Dim lFlags As Integer
		Dim rct As RECT ' Button Rect
		Dim rT As RECT ' Text Rect
		Dim hBr As Integer ' Background brush
		Dim lPicX As Integer
		Dim tx As Integer
		
		'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		DrawText(hdc, m_Caption, Len(m_Caption), rct, DT_CALCRECT)
		tx = rct.Right_Renamed
		
		'Fill background with ButtonFace Color, we do this
		'instead of clearing(CLS command) the usrecontrol.
		hBr = GetSysColorBrush(15)
		rct.TOp_Renamed = 0
		rct.Left_Renamed = 0
		rct.Right_Renamed = ClientRectangle.Width
		rct.Bottom_Renamed = VB6.PixelsToTwipsY(ClientRectangle.Height)
		'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		FillRect(hdc, rct, hBr)
		
		
		'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		If m_Style = eStyle.bsNormal Or (m_Style = eStyle.bsSkin And IsNothing(pSkinPic.Image)) Then
			'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			FillRect(hdc, rct, hBr)
		ElseIf m_Style = eStyle.bsSkin Then 
			If bHover And bPressed = False Then
				If m_Hover = eEdgeUp.bsDefaultUp Then
					DrawSkinBack(3)
				ElseIf m_Hover = eEdgeUp.bsNoneUp Then 
					DrawSkinBack(0)
				ElseIf m_Hover = eEdgeUp.bsSoftUp Then 
					DrawSkinBack(1)
				End If
			Else
				If m_Pushed = eEdgeDn.bsDefaultDn Then
					DrawSkinBack(4)
				ElseIf m_Pushed = eEdgeDn.bsSoftDn Then 
					DrawSkinBack(2)
				End If
			End If
		End If
		'Draw Text
		'UPGRADE_ISSUE: LSet cannot assign one type to another. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1002"'
		rT = LSet(rct)
		If m_Align = eAlignment.alLeft Then
			lFlags = DT_LEFT
			lPicX = 4
		ElseIf m_Align = eAlignment.alRight Then 
			lFlags = DT_RIGHT
			If tx + pBtnPic.ClientRectangle.Width + 10 >= ClientRectangle.Width Then
				lPicX = 4
			Else
				lPicX = ClientRectangle.Width - tx - pBtnPic.ClientRectangle.Width - 6
			End If
		ElseIf m_Align = eAlignment.alCenter Then 
			lFlags = DT_CENTER
			If tx + pBtnPic.ClientRectangle.Width + 10 >= ClientRectangle.Width Then
				lPicX = 4
			Else
				lPicX = (ClientRectangle.Width - tx) / 2 - pBtnPic.ClientRectangle.Width + 6
			End If
		End If
		
		If m_Enabled = False Then
			'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			SetTextColor(hdc, IIf((m_Style = eStyle.bsSkin And Not IsNothing(pSkinPic.Image)), TranslateColor(m_SHClr), TranslateColor(System.Drawing.SystemColors.ControlLightLight)))
			rT.TOp_Renamed = 3.5
			rT.Bottom_Renamed = rct.Bottom_Renamed - 2
			'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			If Not IsNothing(pBtnPic.Image) Or Not IsNothing(pBtnPicHov.Image) Or Not IsNothing(pBtnPicDn.Image) Or Not IsNothing(pBtnPicDis.Image) Then
				rT.Left_Renamed = pBtnPic.ClientRectangle.Width + 8
			Else
				rT.Left_Renamed = 5
			End If
			rT.Right_Renamed = rct.Right_Renamed - 3
			'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			DrawText(hdc, m_Caption, Len(m_Caption), rT, lFlags Or DT_SINGLELINE Or DT_WORD_ELLIPSIS Or DT_VCENTER)
			
			'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			SetTextColor(hdc, IIf((m_Style = eStyle.bsSkin And Not IsNothing(pSkinPic.Image)), TranslateColor(m_SDClr), TranslateColor(System.Drawing.SystemColors.ControlDark)))
			rT.TOp_Renamed = 2
			rT.Bottom_Renamed = rct.Bottom_Renamed - 2
			'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			If Not IsNothing(pBtnPic.Image) Or Not IsNothing(pBtnPicHov.Image) Or Not IsNothing(pBtnPicDn.Image) Or Not IsNothing(pBtnPicDis.Image) Then
				rT.Left_Renamed = pBtnPic.ClientRectangle.Width + 7
			Else
				rT.Left_Renamed = 4
			End If
			rT.Right_Renamed = rct.Right_Renamed - 4
			'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			DrawText(hdc, m_Caption, Len(m_Caption), rT, lFlags Or DT_SINGLELINE Or DT_WORD_ELLIPSIS Or DT_VCENTER)
		Else
			rT.TOp_Renamed = 1 - CShort(bPressed)
			rT.Bottom_Renamed = rct.Bottom_Renamed - 1 - CShort(bPressed)
			'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			If Not IsNothing(pBtnPic.Image) Or Not IsNothing(pBtnPicHov.Image) Or Not IsNothing(pBtnPicDn.Image) Or Not IsNothing(pBtnPicDis.Image) Then
				rT.Left_Renamed = pBtnPic.ClientRectangle.Width + 7 - CShort(bPressed)
			Else
				rT.Left_Renamed = 4
			End If
			rT.Right_Renamed = rct.Right_Renamed - 4 - CShort(bPressed)
			'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			DrawText(hdc, m_Caption, Len(m_Caption), rT, lFlags Or DT_SINGLELINE Or DT_WORD_ELLIPSIS Or DT_VCENTER)
		End If
		
		'Draw Image
		'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		If Not IsNothing(pBtnPic.Image) Or Not IsNothing(pBtnPicHov.Image) Or Not IsNothing(pBtnPicDn.Image) Or Not IsNothing(pBtnPicDis.Image) Then
			If m_Enabled Then
				If bHover Then
					'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
					If Not IsNothing(pBtnPicHov.Image) Then
						'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
						'UPGRADE_ISSUE: PictureBox property pBtnPicHov.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
						'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
						BitBlt(hdc, lPicX, (VB6.PixelsToTwipsY(ClientRectangle.Height) - pBtnPicHov.ClientRectangle.Height) / 2 + 0.5, pBtnPicHov.ClientRectangle.Width, pBtnPicHov.ClientRectangle.Height, pBtnPicHov.hdc, 0, 0, vbSrcCopy)
					Else
						'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
						If Not IsNothing(pBtnPic.Image) Then
							'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
							'UPGRADE_ISSUE: PictureBox property pBtnPic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
							'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
							BitBlt(hdc, lPicX, (VB6.PixelsToTwipsY(ClientRectangle.Height) - pBtnPic.ClientRectangle.Height) / 2 + 0.5, pBtnPic.ClientRectangle.Width, pBtnPic.ClientRectangle.Height, pBtnPic.hdc, 0, 0, vbSrcCopy)
						End If
					End If
				Else
					If bPressed Then
						'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
						If Not IsNothing(pBtnPicDn.Image) Then
							'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
							'UPGRADE_ISSUE: PictureBox property pBtnPicDn.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
							'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
							BitBlt(hdc, lPicX - CShort(bPressed), (VB6.PixelsToTwipsY(ClientRectangle.Height) - pBtnPicDn.ClientRectangle.Height) / 2 + 0.5 - CShort(bPressed), pBtnPicDn.ClientRectangle.Width, pBtnPicDn.ClientRectangle.Height, pBtnPicDn.hdc, 0, 0, vbSrcCopy)
						Else
							'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
							If Not IsNothing(pBtnPicHov.Image) Then
								'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
								'UPGRADE_ISSUE: PictureBox property pBtnPicHov.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
								'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
								BitBlt(hdc, lPicX - CShort(bPressed), (VB6.PixelsToTwipsY(ClientRectangle.Height) - pBtnPicHov.ClientRectangle.Height) / 2 + 0.5 - CShort(bPressed), pBtnPicHov.ClientRectangle.Width, pBtnPicHov.ClientRectangle.Height, pBtnPicHov.hdc, 0, 0, vbSrcCopy)
							Else
								'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
								If Not IsNothing(pBtnPic.Image) Then
									'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
									'UPGRADE_ISSUE: PictureBox property pBtnPic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
									'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
									BitBlt(hdc, lPicX - CShort(bPressed), (VB6.PixelsToTwipsY(ClientRectangle.Height) - pBtnPic.ClientRectangle.Height) / 2 + 0.5 - CShort(bPressed), pBtnPic.ClientRectangle.Width, pBtnPic.ClientRectangle.Height, pBtnPic.hdc, 0, 0, vbSrcCopy)
								End If
							End If
						End If
					Else
						'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
						If Not IsNothing(pBtnPic.Image) Then
							'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
							'UPGRADE_ISSUE: PictureBox property pBtnPic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
							'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
							BitBlt(hdc, lPicX, (VB6.PixelsToTwipsY(ClientRectangle.Height) - pBtnPic.ClientRectangle.Height) / 2 + 0.5, pBtnPic.ClientRectangle.Width, pBtnPic.ClientRectangle.Height, pBtnPic.hdc, 0, 0, vbSrcCopy)
						End If
					End If
				End If
			Else
				'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
				If IsNothing(pBtnPicDis.Image) Then
					'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
					If Not IsNothing(pBtnPic.Image) Then
						'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
						'UPGRADE_ISSUE: PictureBox property pBtnPic.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
						'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
						BitBlt(hdc, lPicX, (VB6.PixelsToTwipsY(ClientRectangle.Height) - pBtnPic.ClientRectangle.Height) / 2 + 0.5, pBtnPic.ClientRectangle.Width, pBtnPic.ClientRectangle.Height, pBtnPic.hdc, 0, 0, vbSrcCopy)
					End If
				Else
					'UPGRADE_ISSUE: Constant vbSrcCopy was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
					'UPGRADE_ISSUE: PictureBox property pBtnPicDis.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
					'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
					BitBlt(hdc, lPicX, (VB6.PixelsToTwipsY(ClientRectangle.Height) - pBtnPicDis.ClientRectangle.Height) / 2 + 0.5, pBtnPicDis.ClientRectangle.Width, pBtnPicDis.ClientRectangle.Height, pBtnPicDis.hdc, 0, 0, vbSrcCopy)
				End If
			End If
		End If
		
		'Draw Edge
		If bHover And bPressed = False Then
			'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			If m_Style = eStyle.bsNormal Or (m_Style = eStyle.bsSkin And IsNothing(pSkinPic.Image)) Then
				'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
				DrawEdge(hdc, rct, m_Hover, BF_RECT)
			ElseIf m_Style = eStyle.bsSkin Then 
				If m_Hover = eEdgeUp.bsDefaultUp Then
					DrawSkin(3)
				ElseIf m_Hover = eEdgeUp.bsNoneUp Then 
					DrawSkin(0)
				ElseIf m_Hover = eEdgeUp.bsSoftUp Then 
					DrawSkin(1)
				End If
			End If
		Else
			'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			If m_Style = eStyle.bsNormal Or (m_Style = eStyle.bsSkin And IsNothing(pSkinPic.Image)) Then
				'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
				DrawEdge(hdc, rct, IIf(bPressed, m_Pushed, m_UnPushed), BF_RECT)
			ElseIf m_Style = eStyle.bsSkin Then 
				If bPressed = False Then
					If m_UnPushed = eEdgeUp.bsDefaultUp Then
						DrawSkin(3)
					ElseIf m_UnPushed = eEdgeUp.bsNoneUp Then 
						DrawSkin(0)
					ElseIf m_UnPushed = eEdgeUp.bsSoftUp Then 
						DrawSkin(1)
					End If
				Else
					If m_Pushed = eEdgeDn.bsDefaultDn Then
						DrawSkin(4)
					ElseIf m_Pushed = eEdgeDn.bsSoftDn Then 
						DrawSkin(2)
					End If
				End If
			End If
		End If
		If m_UnPushed = eEdgeUp.bsNoneUp Then
			If Not DesignMode = False Then
				'UPGRADE_ISSUE: UserControl method UserControl.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
				MyBase.Line (0, VB6.PixelsToTwipsY(ClientRectangle.Height) - 1) - (ClientRectangle.Width - 1, 0), System.Drawing.ColorTranslator.ToOle(System.Drawing.SystemColors.ControlDark), B
			End If
		End If
		Refresh()
	End Sub
	
	Private Sub GoldButton_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Leave
		'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		SetTextColor(hdc, TranslateColor(m_FClr))
		Render()
		fins = False
		iStatus = 0
	End Sub
	
	Private Sub GoldButton_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		RaiseEvent MouseDown(Me, New MouseDownEventArgs(Button, Shift, x, y))
		If Button = 1 Then
			'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			SetTextColor(hdc, TranslateColor(m_DClr))
			Render(True)
			iStatus = 1
		End If
	End Sub
	
	Private Sub GoldButton_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim ret As Integer
		Dim rct As RECT
		
		If Button = VB6.MouseButtonConstants.LeftButton Then
			If iStatus = 1 Then
				If GetCapture() <> Handle.ToInt32 Then
					ret = SetCapture(Handle.ToInt32)
					'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
					SetTextColor(hdc, TranslateColor(m_DClr))
					Render(True)
				End If
				If x > 0 And x < ClientRectangle.Width And y > 0 And y < VB6.PixelsToTwipsY(ClientRectangle.Height) Then
					'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
					SetTextColor(hdc, TranslateColor(m_DClr))
					Render(True)
				Else
					'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
					SetTextColor(hdc, TranslateColor(m_HClr))
					Render( , True)
				End If
			Else
			End If
		Else
			If x < 0 Or x > ClientRectangle.Width Or y < 0 Or y > VB6.PixelsToTwipsY(ClientRectangle.Height) Then
				fins = False
				ret = ReleaseCapture()
				RaiseEvent MouseExit(Me, Nothing)
				'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
				SetTextColor(hdc, TranslateColor(m_FClr))
				Render()
			Else
				If fins = False Then
					fins = True
					ret = SetCapture(MyBase.Handle.ToInt32)
					RaiseEvent MouseEnter(Me, Nothing)
					'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
					SetTextColor(hdc, TranslateColor(m_HClr))
					Render( , True)
				End If
			End If
		End If
		RaiseEvent MouseMove(Me, New MouseMoveEventArgs(Button, Shift, x, y))
	End Sub
	
	Private Sub GoldButton_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		If Button = 1 Then
			If iStatus = 1 Then
				If x > 0 And x < ClientRectangle.Width And y > 0 And y < VB6.PixelsToTwipsY(ClientRectangle.Height) Then
					fins = False
					'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
					SetTextColor(hdc, TranslateColor(m_FClr))
					Render()
					RaiseEvent Click(Me, Nothing)
					iStatus = 0
				Else
					'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
					SetTextColor(hdc, TranslateColor(m_FClr))
					Render()
					iStatus = 0
					fins = False
				End If 'XY Pos
			End If 'iStatus
		End If 'Mouse Button
		'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		SetTextColor(hdc, TranslateColor(m_FClr))
		Render()
		iStatus = 0
		fins = False
		RaiseEvent MouseUp(Me, New MouseUpEventArgs(Button, Shift, x, y))
	End Sub
	
	'UPGRADE_WARNING: UserControl Event UserControl.OLECompleteDrag was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2050"'
	Private Sub UserControl_OLECompleteDrag(ByRef Effect As Integer)
		RaiseEvent OLECompleteDrag(Me, New OLECompleteDragEventArgs(Effect))
	End Sub
	
	'UPGRADE_ISSUE: DataObject object was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2068"'
	'UPGRADE_WARNING: UserControl Event UserControl.OLEDragDrop was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2050"'
	Private Sub UserControl_OLEDragDrop(ByRef Data As DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single)
		RaiseEvent OLEDragDrop(Me, New OLEDragDropEventArgs(Data, Effect, Button, Shift, x, y))
	End Sub
	
	'UPGRADE_ISSUE: DataObject object was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2068"'
	'UPGRADE_WARNING: UserControl Event UserControl.OLEDragOver was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2050"'
	Private Sub UserControl_OLEDragOver(ByRef Data As DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single, ByRef state As Short)
		RaiseEvent OLEDragOver(Me, New OLEDragOverEventArgs(Data, Effect, Button, Shift, x, y, state))
	End Sub
	
	'UPGRADE_WARNING: UserControl Event UserControl.OLEGiveFeedback was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2050"'
	Private Sub UserControl_OLEGiveFeedback(ByRef Effect As Integer, ByRef DefaultCursors As Boolean)
		RaiseEvent OLEGiveFeedback(Me, New OLEGiveFeedbackEventArgs(Effect, DefaultCursors))
	End Sub
	
	'UPGRADE_ISSUE: DataObject object was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2068"'
	'UPGRADE_WARNING: UserControl Event UserControl.OLESetData was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2050"'
	Private Sub UserControl_OLESetData(ByRef Data As DataObject, ByRef DataFormat As Short)
		RaiseEvent OLESetData(Me, New OLESetDataEventArgs(Data, DataFormat))
	End Sub
	
	'UPGRADE_ISSUE: DataObject object was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2068"'
	'UPGRADE_WARNING: UserControl Event UserControl.OLEStartDrag was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2050"'
	Private Sub UserControl_OLEStartDrag(ByRef Data As DataObject, ByRef AllowedEffects As Integer)
		RaiseEvent OLEStartDrag(Me, New OLEStartDragEventArgs(Data, AllowedEffects))
	End Sub
	
	Private Sub GoldButton_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		RefreshIt()
	End Sub
	
	
	Public Property Caption() As String
		Get
			Caption = m_Caption
		End Get
		Set(ByVal Value As String)
			m_Caption = Value
			RaiseEvent CaptionChange()
			RefreshIt()
		End Set
	End Property
	
	
	Public Shadows Property Enabled() As Boolean
		Get
			Return m_Enabled
		End Get
		Set(ByVal Value As Boolean)
			m_Enabled = Value
			RaiseEvent EnabledChange()
			MyBase.Enabled = m_Enabled
			RefreshIt()
		End Set
	End Property
	
	
	Public Property Alignment() As eAlignment
		Get
			Alignment = m_Align
		End Get
		Set(ByVal Value As eAlignment)
			m_Align = Value
			RaiseEvent AlignmentChange()
			RefreshIt()
		End Set
	End Property
	
	
	Public Property HoverColor() As System.Drawing.Color
		Get
			HoverColor = m_HClr
		End Get
		Set(ByVal Value As System.Drawing.Color)
			m_HClr = Value
			RaiseEvent HoverColorChange()
		End Set
	End Property
	
	
	Public Overrides Property ForeColor() As System.Drawing.Color
		Get
			Return m_FClr
		End Get
		Set(ByVal Value As System.Drawing.Color)
			m_FClr = Value
			RaiseEvent ForeColorChange()
			RefreshIt()
		End Set
	End Property
	
	
	Public Property DownColor() As System.Drawing.Color
		Get
			DownColor = m_DClr
		End Get
		Set(ByVal Value As System.Drawing.Color)
			m_DClr = Value
			RaiseEvent DownColorChange()
		End Set
	End Property
	
	
	Public Property SkinDisabledText() As System.Drawing.Color
		Get
			SkinDisabledText = m_SDClr
		End Get
		Set(ByVal Value As System.Drawing.Color)
			m_SDClr = Value
			RaiseEvent SkinDisabledTextChange()
			RefreshIt()
		End Set
	End Property
	
	
	Public Property SkinHighlight() As System.Drawing.Color
		Get
			SkinHighlight = m_SHClr
		End Get
		Set(ByVal Value As System.Drawing.Color)
			m_SHClr = Value
			RaiseEvent SkinHighlightChange()
			RefreshIt()
		End Set
	End Property
	
	
	Public Overrides Property Font() As System.Drawing.Font
		Get
			Font = m_Font
		End Get
		Set(ByVal Value As System.Drawing.Font)
			m_Font = Value
			MyBase.Font = m_Font
			RaiseEvent FontChange()
			RefreshIt()
		End Set
	End Property
	
	
	Public Property OnDown() As eEdgeDn
		Get
			OnDown = m_Pushed
		End Get
		Set(ByVal Value As eEdgeDn)
			m_Pushed = Value
			RaiseEvent OnDownChange()
		End Set
	End Property
	
	
	Public Property OnUp() As eEdgeUp
		Get
			OnUp = m_UnPushed
		End Get
		Set(ByVal Value As eEdgeUp)
			m_UnPushed = Value
			RaiseEvent OnUpChange()
			RefreshIt()
		End Set
	End Property
	
	
	Public Property OnHover() As eEdgeUp
		Get
			OnHover = m_Hover
		End Get
		Set(ByVal Value As eEdgeUp)
			m_Hover = Value
			RaiseEvent OnHoverChange()
		End Set
	End Property
	
	
	Public Property SkinPicture() As System.Drawing.Image
		Get
			SkinPicture = pSkinPic.Image
		End Get
		Set(ByVal Value As System.Drawing.Image)
			pSkinPic.Image = Value
			RaiseEvent SkinPictureChange()
			RefreshIt()
		End Set
	End Property
	
	
	Public Property Picture() As System.Drawing.Image
		Get
			Picture = pBtnPic.Image
		End Get
		Set(ByVal Value As System.Drawing.Image)
			pBtnPic.Image = Value
			RaiseEvent PictureChange()
			'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			If Not IsNothing(pBtnPic.Image) Then
				MaskPicture(pBtnPic)
			End If
			RefreshIt()
		End Set
	End Property
	
	
	Public Property PictureHover() As System.Drawing.Image
		Get
			PictureHover = pBtnPicHov.Image
		End Get
		Set(ByVal Value As System.Drawing.Image)
			pBtnPicHov.Image = Value
			RaiseEvent PictureHoverChange()
			'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			If Not IsNothing(pBtnPicHov.Image) Then
				MaskPicture(pBtnPicHov)
			End If
			RefreshIt()
		End Set
	End Property
	
	
	Public Property PictureDown() As System.Drawing.Image
		Get
			PictureDown = pBtnPicDn.Image
		End Get
		Set(ByVal Value As System.Drawing.Image)
			pBtnPicDn.Image = Value
			RaiseEvent PictureDownChange()
			'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			If Not IsNothing(pBtnPicDn.Image) Then
				MaskPicture(pBtnPicDn)
			End If
			RefreshIt()
		End Set
	End Property
	
	
	Public Property PictureDisabled() As System.Drawing.Image
		Get
			PictureDisabled = pBtnPicDis.Image
		End Get
		Set(ByVal Value As System.Drawing.Image)
			pBtnPicDis.Image = Value
			RaiseEvent PictureDisabledChange()
			'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			If Not IsNothing(pBtnPicDis.Image) Then
				MaskPicture(pBtnPicDis)
			End If
			RefreshIt()
		End Set
	End Property
	
	
	Public Property PictureBackColor() As System.Drawing.Color
		Get
			PictureBackColor = m_PBClr
		End Get
		Set(ByVal Value As System.Drawing.Color)
			m_PBClr = Value
			RaiseEvent PictureBackColorChange()
			'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
			If Not IsNothing(pBtnPic.Image) Then
				MaskPicture(pBtnPic)
			End If
			RefreshIt()
		End Set
	End Property
	
	
	Public Property MaskColor() As System.Drawing.Color
		Get
			MaskColor = m_MClr
		End Get
		Set(ByVal Value As System.Drawing.Color)
			m_MClr = Value
			RaiseEvent MaskColorChange()
			MaskPicture(pBtnPic)
			MaskPicture(pBtnPicDn)
			MaskPicture(pBtnPicDis)
			MaskPicture(pBtnPicHov)
			RefreshIt()
		End Set
	End Property
	
	
	Public Property Style() As eStyle
		Get
			Style = m_Style
		End Get
		Set(ByVal Value As eStyle)
			m_Style = Value
			RaiseEvent StyleChange()
			RefreshIt()
		End Set
	End Property
	
	
	Public Property ToolTipText() As String
		Get
			ToolTipText = ToolTip
		End Get
		Set(ByVal Value As String)
			ToolTip = Value
			RaiseEvent ToolTipTextChange()
			ToolTip1.SetToolTip(pBtnPic, ToolTip)
			ToolTip1.SetToolTip(pBtnPicDn, ToolTip)
			ToolTip1.SetToolTip(pBtnPicDis, ToolTip)
			ToolTip1.SetToolTip(pBtnPicHov, ToolTip)
		End Set
	End Property
	
	
	Public Property UseMaskColor() As Boolean
		Get
			UseMaskColor = m_Mask
		End Get
		Set(ByVal Value As Boolean)
			m_Mask = Value
			RaiseEvent UseMaskColorChange()
			MaskPicture(pBtnPic)
			MaskPicture(pBtnPicDn)
			MaskPicture(pBtnPicDis)
			MaskPicture(pBtnPicHov)
			RefreshIt()
		End Set
	End Property
	
	Private Sub RefreshIt()
		'UPGRADE_ISSUE: UserControl property GoldButton.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		SetTextColor(hdc, TranslateColor(m_FClr))
		Render()
	End Sub
	
	'UPGRADE_WARNING: UserControl Event UserControl.InitProperties was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2050"'
	Private Sub UserControl_InitProperties()
		'UPGRADE_ISSUE: UserControl property GoldButton.Extender was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Extender.Name. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		m_Caption = Extender.Name
		m_Enabled = True
		m_Align = eAlignment.alCenter
		m_HClr = System.Drawing.ColorTranslator.FromOle(RGB(0, 0, 255))
		m_FClr = System.Drawing.SystemColors.ControlText
		m_DClr = m_HClr
		m_SDClr = System.Drawing.SystemColors.ControlDark
		m_SHClr = System.Drawing.SystemColors.ControlLightLight
		m_PBClr = System.Drawing.SystemColors.Control
		m_UnPushed = eEdgeUp.bsSoftUp
		m_Pushed = eEdgeDn.bsDefaultDn
		m_Hover = eEdgeUp.bsDefaultUp
		m_Style = eStyle.bsNormal
		m_MClr = System.Drawing.SystemColors.Control
		m_Mask = False
		'UPGRADE_ISSUE: AmbientProperties property Ambient.Font was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		m_Font = Ambient.Font
		Width = VB6.TwipsToPixelsX(1075)
		Height = VB6.TwipsToPixelsY(375)
	End Sub
	
	'UPGRADE_WARNING: PropertyBag object was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup6003"'
	'UPGRADE_WARNING: UserControl Event ReadProperties is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup6002"'
	Private Sub UserControl_ReadProperties(ByRef PropBag As PropertyBag)
		'UPGRADE_ISSUE: UserControl property GoldButton.Extender was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Extender.Name. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		m_Caption = PropBag.ReadProperty("Caption", Extender.Name)
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		m_Enabled = PropBag.ReadProperty("Enabled", True)
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		m_Align = PropBag.ReadProperty("Alignment", eAlignment.alLeft)
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		m_HClr = System.Drawing.ColorTranslator.FromOle(PropBag.ReadProperty("HoverColor", RGB(0, 0, 255)))
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		m_FClr = System.Drawing.ColorTranslator.FromOle(PropBag.ReadProperty("ForeColor", System.Drawing.ColorTranslator.ToOle(System.Drawing.SystemColors.ControlText)))
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		m_DClr = System.Drawing.ColorTranslator.FromOle(PropBag.ReadProperty("DownColor", m_HClr))
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		m_SDClr = System.Drawing.ColorTranslator.FromOle(PropBag.ReadProperty("SkinDisabledText", 0))
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		m_SHClr = System.Drawing.ColorTranslator.FromOle(PropBag.ReadProperty("SkinHighlight", 0))
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		m_PBClr = System.Drawing.ColorTranslator.FromOle(PropBag.ReadProperty("PictureBackColor", System.Drawing.ColorTranslator.ToOle(System.Drawing.SystemColors.Control)))
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		m_UnPushed = PropBag.ReadProperty("OnUp", eEdgeUp.bsSoftUp)
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		m_Pushed = PropBag.ReadProperty("OnDown", eEdgeDn.bsDefaultDn)
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		m_Hover = PropBag.ReadProperty("OnHover", eEdgeUp.bsSoftUp)
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		m_Style = PropBag.ReadProperty("Style", eStyle.bsNormal)
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		m_MClr = System.Drawing.ColorTranslator.FromOle(PropBag.ReadProperty("MaskColor", System.Drawing.ColorTranslator.ToOle(System.Drawing.SystemColors.Control)))
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		m_Mask = PropBag.ReadProperty("UseMaskColor", False)
		'ToolTip = PropBag.ReadProperty("ToolTipText")
		
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		pSkinPic.Image = PropBag.ReadProperty("SkinPicture", Nothing)
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		pBtnPic.Image = PropBag.ReadProperty("Picture", Nothing)
		'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		If Not IsNothing(pBtnPic.Image) Then
			MaskPicture(pBtnPic)
		End If
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		pBtnPicHov.Image = PropBag.ReadProperty("PictureHover", Nothing)
		'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		If Not IsNothing(pBtnPicHov.Image) Then
			MaskPicture(pBtnPicHov)
		End If
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		pBtnPicDn.Image = PropBag.ReadProperty("PictureDown", Nothing)
		'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		If Not IsNothing(pBtnPicDn.Image) Then
			MaskPicture(pBtnPicDn)
		End If
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object PropBag.ReadProperty(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		pBtnPicDis.Image = PropBag.ReadProperty("PictureDisabled", Nothing)
		'UPGRADE_WARNING: IsEmpty was upgraded to IsNothing and has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
		If Not IsNothing(pBtnPicDis.Image) Then
			MaskPicture(pBtnPicDis)
		End If
		'UPGRADE_ISSUE: AmbientProperties property Ambient.Font was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_ISSUE: PropertyBag method PropBag.ReadProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		m_Font = PropBag.ReadProperty("Font", Ambient.Font)
		MyBase.Font = m_Font
		
		MyBase.Enabled = m_Enabled
		
		RefreshIt()
	End Sub
	
	'UPGRADE_WARNING: PropertyBag object was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup6003"'
	'UPGRADE_WARNING: UserControl Event WriteProperties is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup6002"'
	Private Sub UserControl_WriteProperties(ByRef PropBag As PropertyBag)
		'UPGRADE_ISSUE: UserControl property GoldButton.Extender was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Extender.Name. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("Caption", m_Caption, Extender.Name)
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("Enabled", m_Enabled, True)
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("Alignment", m_Align, eAlignment.alLeft)
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("HoverColor", m_HClr, RGB(0, 0, 255))
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("ForeColor", m_FClr, TranslateColor(System.Drawing.SystemColors.ControlText))
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("DownColor", m_DClr, m_HClr)
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("SkinDisabledText", m_SDClr, 0)
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("SkinHighlight", m_SHClr, 0)
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("PictureBackColor", m_PBClr, System.Drawing.ColorTranslator.ToOle(System.Drawing.SystemColors.Control))
		'UPGRADE_ISSUE: AmbientProperties property Ambient.Font was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("Font", m_Font, Ambient.Font)
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("OnUp", m_UnPushed, eEdgeUp.bsSoftUp)
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("OnDown", m_Pushed, eEdgeDn.bsDefaultDn)
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("OnHover", m_Hover, eEdgeUp.bsSoftUp)
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("Style", m_Style, eStyle.bsNormal)
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("SkinPicture", pSkinPic.Image, Nothing)
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("Picture", pBtnPic.Image, Nothing)
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("PictureDisabled", pBtnPicDis.Image, Nothing)
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("PictureHover", pBtnPicHov.Image, Nothing)
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("PictureDown", pBtnPicDn.Image, Nothing)
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("MaskColor", m_MClr, System.Drawing.ColorTranslator.ToOle(System.Drawing.SystemColors.Control))
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("UseMaskColor", m_Mask, False)
		'UPGRADE_ISSUE: PropertyBag method PropBag.WriteProperty was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		Call PropBag.WriteProperty("ToolTipText", ToolTip)
	End Sub
	
	Private Sub MaskPicture(ByRef pb As System.Windows.Forms.PictureBox)
		Dim x, y As Integer
		If m_Mask Then
			'UPGRADE_ISSUE: PictureBox method pb.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			pb.Cls()
			For x = 0 To VB6.PixelsToTwipsX(pb.ClientRectangle.Width)
				For y = 0 To VB6.PixelsToTwipsY(pb.ClientRectangle.Height)
					'UPGRADE_ISSUE: PictureBox property pb.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
					If GetPixel(pb.hdc, x, y) = System.Drawing.ColorTranslator.ToOle(m_MClr) Then
						'UPGRADE_ISSUE: PictureBox property pb.hdc was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
						SetPixel(pb.hdc, x, y, TranslateColor(m_PBClr))
					End If
				Next y
			Next x
		Else
			'UPGRADE_ISSUE: PictureBox method pb.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			pb.Cls()
		End If
	End Sub
End Class