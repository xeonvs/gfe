Option Strict Off
Option Explicit On
Module mod3StateTreeViewFunctions
	
	'Initialize the ImageList
	'Note: to have an ImageList available, you must place it on a form
	Sub InitImageList(ByRef imglstCurrent As AxMSComctlLib.AxImageList)
		On Error GoTo HandleError
		
		'Load images into the list and relate them to the appropriate key
		'Assumes bmps are in current directory
		'You could use other bitmaps here
		With imglstCurrent.ListImages
			.Add(1, "None", VB6.ImageToIPictureDisp(VB6.LoadResPicture("None", VB6.LoadResConstants.ResBitmap)))
			.Add(2, "Some", VB6.ImageToIPictureDisp(VB6.LoadResPicture("Some", VB6.LoadResConstants.ResBitmap)))
			.Add(3, "All", VB6.ImageToIPictureDisp(VB6.LoadResPicture("All", VB6.LoadResConstants.ResBitmap)))
		End With
		Exit Sub
		
HandleError: 
		MsgBox("Error reading checkbox state bitmaps", MsgBoxStyle.Exclamation + MsgBoxStyle.SystemModal, System.Reflection.Assembly.GetExecutingAssembly.GetName.Name & " mod3State::InitImageList")
	End Sub
	
	'Processes state change to a checkbox of the node passed
	Sub ProcessStateChange(ByRef nodeCurrent As MSComctlLib.Node)
		'If box is not checked or part checked, then make it all
		If nodeCurrent.Image = "None" Or nodeCurrent.Image = "Some" Then
			nodeCurrent.Image = "All"
		Else
			'If checkbox is all right now, then make it none
			nodeCurrent.Image = "None"
		End If
		'Update parent and child nodes
		CheckChildren(nodeCurrent)
		CheckParent(nodeCurrent)
	End Sub
	
	Sub CheckParent(ByRef nodeSource As MSComctlLib.Node)
		Dim nodeCurrent As MSComctlLib.Node
		Dim boolAllChecked As Boolean
		Dim boolAllUnchecked As Boolean
		
		'Check if node is a root, if so, exit
		If nodeSource._ObjectDefault = nodeSource.Root._ObjectDefault Then Exit Sub
		
		boolAllUnchecked = True
		boolAllChecked = True
		
		'Loop through sibling to see their state
		nodeCurrent = nodeSource.FirstSibling
		Do While Not nodeCurrent Is Nothing
			Select Case nodeCurrent.Image
				Case "Some"
					'If there are "Some" siblings, then the parent will be "Some" too
					boolAllUnchecked = False
					boolAllChecked = False
					Exit Do
				Case "All"
					boolAllUnchecked = False
				Case "None"
					boolAllChecked = False
				Case Else
					'Error
			End Select
			nodeCurrent = nodeCurrent.Next
		Loop 
		If boolAllChecked Then
			If boolAllUnchecked Then
				'Oops - error
			Else
				'If all siblings are set to "All" then parent is "All"
				nodeSource.Parent.Image = "All"
			End If
		Else
			If boolAllUnchecked Then
				'If all siblings are set to "None", then parent in "None"
				nodeSource.Parent.Image = "None"
			Else
				'If there is a mix, then parent is "Some"
				nodeSource.Parent.Image = "Some"
			End If
		End If
		'If we are not at root node, then do a recursive call
		If nodeSource.Parent._ObjectDefault <> nodeSource.Root._ObjectDefault Then
			CheckParent(nodeSource.Parent)
		End If
	End Sub
	
	'Process children state change
	Sub CheckChildren(ByRef nodeSource As MSComctlLib.Node)
		Dim nodeCurrent As MSComctlLib.Node
		'Grab first child
		nodeCurrent = nodeSource.Child
		Do While Not nodeCurrent Is Nothing
			'Set child to the same value as parent
			If nodeSource.Image = "All" Then
				nodeCurrent.Image = "All"
			Else
				nodeCurrent.Image = "None"
			End If
			'Do a recursive call to process the children of the nodeCurrent
			CheckChildren(nodeCurrent)
			'Move to next child
			nodeCurrent = nodeCurrent.Next
		Loop 
	End Sub
End Module