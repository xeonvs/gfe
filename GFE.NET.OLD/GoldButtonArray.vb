Option Strict Off
Option Explicit On
Imports System.Windows.Forms
Imports System.ComponentModel
Imports Microsoft.VisualBasic.Compatibility.VB6

<ProvideProperty("Index", GetType(GoldButton))> Friend Class GoldButtonArray
	Inherits BaseControlArray
	Implements IExtenderProvider
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal Container As IContainer)
		MyBase.New(Container)
	End Sub
	
	Public Event [MouseHover] As System.EventHandler
	Public Event [SystemColorsChanged] As System.EventHandler
	
	Public Event [Resize] As System.EventHandler
	Public Event [Enter] As System.EventHandler
	Public Event [Leave] As System.EventHandler
	Public Event [LostFocus] As System.EventHandler
	Public Event [GotFocus] As System.EventHandler
	Public Event [Validating] As System.ComponentModel.CancelEventHandler
	Public Event [OLEDragDrop] As GoldButton.OLEDragDropEventHandler
	Public Event [OLEGiveFeedback] As GoldButton.OLEGiveFeedbackEventHandler
	Public Event [OLECompleteDrag] As GoldButton.OLECompleteDragEventHandler
	Public Event [MouseDown] As GoldButton.MouseDownEventHandler
	Public Event [OLESetData] As GoldButton.OLESetDataEventHandler
	Public Event [MouseUp] As GoldButton.MouseUpEventHandler
	Public Event [MouseExit] As System.EventHandler
	Public Event [Click] As System.EventHandler
	Public Event [OLEDragOver] As GoldButton.OLEDragOverEventHandler
	Public Event [MouseMove] As GoldButton.MouseMoveEventHandler
	Public Event [OLEStartDrag] As GoldButton.OLEStartDragEventHandler
	Public Event [MouseEnter] As System.EventHandler
	
	Public Function CanExtend(ByVal Target As Object) As Boolean Implements IExtenderProvider.CanExtend
		If TypeOf Target Is GoldButton Then
			Return BaseCanExtend(Target)
		End If
	End Function
	
	Public Function GetIndex(ByVal o As GoldButton) As Short
		Return BaseGetIndex(o)
	End Function
	
	Public Sub SetIndex(ByVal o As GoldButton, ByVal Index As Short)
		BaseSetIndex(o, Index)
	End Sub
	
	Public Function ShouldSerializeIndex(ByVal o As GoldButton) As Boolean
		Return BaseShouldSerializeIndex(o)
	End Function
	
	Public Sub ResetIndex(ByVal o As GoldButton)
		BaseResetIndex(o)
	End Sub
	
	Public Default ReadOnly Property Item(ByVal Index As Short) As GoldButton
		Get
			Item = CType(BaseGetItem(Index), GoldButton)
		End Get
	End Property
	
	Protected Overrides Sub HookUpControlEvents(ByVal o As Object)
		
		Dim ctl As GoldButton
		ctl = CType(o, GoldButton)
		
		If Not IsNothing(ResizeEvent) Then
			addHandler ctl.Resize, New System.EventHandler(AddressOf HandleResize)
		End If
		
		If Not IsNothing(EnterEvent) Then
			addHandler ctl.Enter, New System.EventHandler(AddressOf HandleEnter)
		End If
		
		If Not IsNothing(LeaveEvent) Then
			addHandler ctl.Leave, New System.EventHandler(AddressOf HandleLeave)
		End If
		
		If Not IsNothing(LostFocusEvent) Then
			addHandler ctl.LostFocus, New System.EventHandler(AddressOf HandleLostFocus)
		End If
		
		If Not IsNothing(GotFocusEvent) Then
			addHandler ctl.GotFocus, New System.EventHandler(AddressOf HandleGotFocus)
		End If
		
		If Not IsNothing(ValidatingEvent) Then
			addHandler ctl.Validating, New System.ComponentModel.CancelEventHandler(AddressOf HandleValidating)
		End If
		
		If Not IsNothing(OLEDragDropEvent) Then
			addHandler ctl.OLEDragDrop, New GoldButton.OLEDragDropEventHandler(AddressOf HandleOLEDragDrop)
		End If
		
		If Not IsNothing(OLEGiveFeedbackEvent) Then
			addHandler ctl.OLEGiveFeedback, New GoldButton.OLEGiveFeedbackEventHandler(AddressOf HandleOLEGiveFeedback)
		End If
		
		If Not IsNothing(OLECompleteDragEvent) Then
			addHandler ctl.OLECompleteDrag, New GoldButton.OLECompleteDragEventHandler(AddressOf HandleOLECompleteDrag)
		End If
		
		If Not IsNothing(MouseDownEvent) Then
			addHandler ctl.MouseDown, New GoldButton.MouseDownEventHandler(AddressOf HandleMouseDown)
		End If
		
		If Not IsNothing(OLESetDataEvent) Then
			addHandler ctl.OLESetData, New GoldButton.OLESetDataEventHandler(AddressOf HandleOLESetData)
		End If
		
		If Not IsNothing(MouseUpEvent) Then
			addHandler ctl.MouseUp, New GoldButton.MouseUpEventHandler(AddressOf HandleMouseUp)
		End If
		
		If Not IsNothing(MouseExitEvent) Then
			addHandler ctl.MouseExit, New GoldButton.MouseExitEventHandler(AddressOf HandleMouseExit)
		End If
		
		If Not IsNothing(ClickEvent) Then
			addHandler ctl.Click, New GoldButton.ClickEventHandler(AddressOf HandleClick)
		End If
		
		If Not IsNothing(OLEDragOverEvent) Then
			addHandler ctl.OLEDragOver, New GoldButton.OLEDragOverEventHandler(AddressOf HandleOLEDragOver)
		End If
		
		If Not IsNothing(MouseMoveEvent) Then
			addHandler ctl.MouseMove, New GoldButton.MouseMoveEventHandler(AddressOf HandleMouseMove)
		End If
		
		If Not IsNothing(OLEStartDragEvent) Then
			addHandler ctl.OLEStartDrag, New GoldButton.OLEStartDragEventHandler(AddressOf HandleOLEStartDrag)
		End If
		
		If Not IsNothing(MouseEnterEvent) Then
			addHandler ctl.MouseEnter, New GoldButton.MouseEnterEventHandler(AddressOf HandleMouseEnter)
		End If
		
	End Sub
	
	Private Sub HandleResize(ByVal sender As Object, ByVal e As System.EventArgs)
		RaiseEvent [Resize](sender, e)
	End Sub
	
	Private Sub HandleEnter(ByVal sender As Object, ByVal e As System.EventArgs)
		RaiseEvent [Enter](sender, e)
	End Sub
	
	Private Sub HandleLeave(ByVal sender As Object, ByVal e As System.EventArgs)
		RaiseEvent [Leave](sender, e)
	End Sub
	
	Private Sub HandleLostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
		RaiseEvent [LostFocus](sender, e)
	End Sub
	
	Private Sub HandleGotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
		RaiseEvent [GotFocus](sender, e)
	End Sub
	
	Private Sub HandleValidating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
		RaiseEvent [Validating](sender, e)
	End Sub
	
	Private Sub HandleOLEDragDrop(ByVal sender As Object, ByVal e As GoldButton.OLEDragDropEventArgs)
		RaiseEvent [OLEDragDrop](sender, e)
	End Sub
	
	Private Sub HandleOLEGiveFeedback(ByVal sender As Object, ByVal e As GoldButton.OLEGiveFeedbackEventArgs)
		RaiseEvent [OLEGiveFeedback](sender, e)
	End Sub
	
	Private Sub HandleOLECompleteDrag(ByVal sender As Object, ByVal e As GoldButton.OLECompleteDragEventArgs)
		RaiseEvent [OLECompleteDrag](sender, e)
	End Sub
	
	Private Sub HandleMouseDown(ByVal sender As Object, ByVal e As GoldButton.MouseDownEventArgs)
		RaiseEvent [MouseDown](sender, e)
	End Sub
	
	Private Sub HandleOLESetData(ByVal sender As Object, ByVal e As GoldButton.OLESetDataEventArgs)
		RaiseEvent [OLESetData](sender, e)
	End Sub
	
	Private Sub HandleMouseUp(ByVal sender As Object, ByVal e As GoldButton.MouseUpEventArgs)
		RaiseEvent [MouseUp](sender, e)
	End Sub
	
	Private Sub HandleMouseExit(ByVal sender As Object, ByVal e As System.EventArgs)
		RaiseEvent [MouseExit](sender, e)
	End Sub
	
	Private Sub HandleClick(ByVal sender As Object, ByVal e As System.EventArgs)
		RaiseEvent [Click](sender, e)
	End Sub
	
	Private Sub HandleOLEDragOver(ByVal sender As Object, ByVal e As GoldButton.OLEDragOverEventArgs)
		RaiseEvent [OLEDragOver](sender, e)
	End Sub
	
	Private Sub HandleMouseMove(ByVal sender As Object, ByVal e As GoldButton.MouseMoveEventArgs)
		RaiseEvent [MouseMove](sender, e)
	End Sub
	
	Private Sub HandleOLEStartDrag(ByVal sender As Object, ByVal e As GoldButton.OLEStartDragEventArgs)
		RaiseEvent [OLEStartDrag](sender, e)
	End Sub
	
	Private Sub HandleMouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
		RaiseEvent [MouseEnter](sender, e)
	End Sub
	
	
	Protected Overrides Function GetControlInstanceType() As System.Type
		Return GetType(GoldButton)
	End Function
	
End Class