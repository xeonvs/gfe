Option Strict Off
Option Explicit On
Module mListviewMacros
	
	
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Public Declare Sub MoveMemory Lib "kernel32"  Alias "RtlMoveMemory"(ByRef pDest As Any, ByRef pSource As Any, ByVal dwLength As Integer)
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Public Declare Function SendMessage Lib "user32"  Alias "SendMessageA"(ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Any) As Integer ' <---
	
	Private Const LVM_GETSUBITEMRECT As Double = (mListviewDefs.LVMessages.LVM_FIRST + 56)
	
	' Returns the low 16-bit integer from a 32-bit long integer
	
	Public Function LOWORD(ByRef dwValue As Integer) As Short
		MoveMemory(LOWORD, dwValue, 2)
	End Function
	
	' Returns the low 16-bit integer from a 32-bit long integer
	
	Public Function HIWORD(ByRef dwValue As Integer) As Short
		'UPGRADE_ISSUE: VarPtr function is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1040"'
		MoveMemory(HIWORD, VarPtr(dwValue) + 2, 2)
	End Function
	
	' Combines two integers into a long integer
	
	Public Function MAKELONG(ByRef wLow As Integer, ByRef wHigh As Integer) As Integer
		MAKELONG = wLow
		'UPGRADE_ISSUE: VarPtr function is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1040"'
		MoveMemory(VarPtr(MAKELONG) + 2, wHigh, 2)
	End Function
	
	' Combines two integers into a long integer
	
	Public Function MAKELPARAM(ByRef wLow As Integer, ByRef wHigh As Integer) As Integer
		MAKELPARAM = MAKELONG(wLow, wHigh)
	End Function
	
	' =============================================================================
	
	Public Function ListView_GetBkColor(ByRef hWnd As Integer) As Integer
		ListView_GetBkColor = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_GETBKCOLOR, 0, 0)
	End Function
	
	Public Function ListView_SetBkColor(ByRef hWnd As Integer, ByRef clrBk As Integer) As Boolean
		ListView_SetBkColor = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_SETBKCOLOR, 0, clrBk)
	End Function
	
	Public Function ListView_GetImageList(ByRef hWnd As Integer, ByRef iImageList As mListviewDefs.LVSIL_Flags) As Integer
		ListView_GetImageList = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_GETIMAGELIST, iImageList, 0)
	End Function
	
	Public Function ListView_SetImageList(ByRef hWnd As Integer, ByRef himl As Integer, ByRef iImageList As Integer) As Integer
		ListView_SetImageList = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_SETIMAGELIST, iImageList, himl)
	End Function
	
	Public Function ListView_GetItemCount(ByRef hWnd As Integer) As Integer
		ListView_GetItemCount = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_GETITEMCOUNT, 0, 0)
	End Function
	
	Public Function ListView_GetItem(ByRef hWnd As Integer, ByRef pitem As LVITEM) As Boolean
		'UPGRADE_WARNING: Couldn't resolve default property of object pitem. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		ListView_GetItem = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_GETITEM, 0, pitem)
	End Function
	
	Public Function ListView_SetItem(ByRef hWnd As Integer, ByRef pitem As LVITEM) As Boolean
		'UPGRADE_WARNING: Couldn't resolve default property of object pitem. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		ListView_SetItem = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_SETITEM, 0, pitem)
	End Function
	
	Public Function ListView_InsertItem(ByRef hWnd As Integer, ByRef pitem As LVITEM) As Integer
		'UPGRADE_WARNING: Couldn't resolve default property of object pitem. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		ListView_InsertItem = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_INSERTITEM, 0, pitem)
	End Function
	
	Public Function ListView_DeleteItem(ByRef hWnd As Integer, ByRef i As Integer) As Boolean
		ListView_DeleteItem = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_DELETEITEM, i, 0)
	End Function
	
	Public Function ListView_DeleteAllItems(ByRef hWnd As Integer) As Boolean
		ListView_DeleteAllItems = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_DELETEALLITEMS, 0, 0)
	End Function
	
	Public Function ListView_GetCallbackMask(ByRef hWnd As Integer) As Integer ' LVStyles
		ListView_GetCallbackMask = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_GETCALLBACKMASK, 0, 0)
	End Function
	
	Public Function ListView_SetCallbackMask(ByRef hWnd As Integer, ByRef mask As mListviewDefs.LVStyles) As Boolean
		ListView_SetCallbackMask = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_SETCALLBACKMASK, mask, 0)
	End Function
	
	Public Function ListView_GetNextItem(ByRef hWnd As Integer, ByRef i As Integer, ByRef Flags As mListviewDefs.LVNI_Flags) As Integer
		ListView_GetNextItem = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_GETNEXTITEM, i, MAKELPARAM(Flags, 0))
	End Function
	
	Public Function ListView_FindItem(ByRef hWnd As Integer, ByRef iStart As Object, ByRef plvfi As LVFINDINFO) As Integer
		'UPGRADE_WARNING: Couldn't resolve default property of object plvfi. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		ListView_FindItem = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_FINDITEM, iStart, plvfi)
	End Function
	
	Public Function ListView_GetItemRect(ByRef hWnd As Integer, ByRef i As Integer, ByRef prc As RECT, ByRef code As mListviewDefs.LVIR_Flags) As Boolean
		prc.Left_Renamed = code
		'UPGRADE_WARNING: Couldn't resolve default property of object prc. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		ListView_GetItemRect = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_GETITEMRECT, i, prc)
	End Function
	
	Public Function ListView_SetItemPosition(ByRef hwndLV As Integer, ByRef i As Integer, ByRef x As Integer, ByRef y As Integer) As Boolean
		ListView_SetItemPosition = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_SETITEMPOSITION, i, MAKELPARAM(x, y))
	End Function
	
	Public Function ListView_GetItemPosition(ByRef hwndLV As Integer, ByRef i As Integer, ByRef ppt As POINTAPI) As Boolean
		'UPGRADE_WARNING: Couldn't resolve default property of object ppt. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		ListView_GetItemPosition = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_GETITEMPOSITION, i, ppt)
	End Function
	
	Public Function ListView_GetStringWidth(ByRef hwndLV As Integer, ByRef psz As String) As Integer
		ListView_GetStringWidth = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_GETSTRINGWIDTH, 0, psz)
	End Function
	
	Public Function ListView_HitTest(ByRef hwndLV As Integer, ByRef pinfo As LVHITTESTINFO) As Integer
		'UPGRADE_WARNING: Couldn't resolve default property of object pinfo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		ListView_HitTest = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_HITTEST, 0, pinfo)
	End Function
	
	Public Function ListView_EnsureVisible(ByRef hwndLV As Integer, ByRef i As Integer, ByRef fPartialOK As Boolean) As Boolean
		ListView_EnsureVisible = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_ENSUREVISIBLE, i, MAKELPARAM(System.Math.Abs(CInt(fPartialOK)), 0))
	End Function
	
	Public Function ListView_Scroll(ByRef hwndLV As Integer, ByRef dx As Integer, ByRef dy As Integer) As Boolean
		ListView_Scroll = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_SCROLL, dx, dy)
	End Function
	
	Public Function ListView_RedrawItems(ByRef hwndLV As Integer, ByRef iFirst As Object, ByRef iLast As Object) As Boolean
		ListView_RedrawItems = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_REDRAWITEMS, iFirst, iLast)
	End Function
	
	Public Function ListView_Arrange(ByRef hwndLV As Integer, ByRef code As mListviewDefs.LVA_Flags) As Boolean
		ListView_Arrange = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_ARRANGE, code, 0)
	End Function
	
	Public Function ListView_EditLabel(ByRef hwndLV As Integer, ByRef i As Integer) As Integer
		ListView_EditLabel = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_EDITLABEL, i, 0)
	End Function
	
	Public Function ListView_GetEditControl(ByRef hwndLV As Integer) As Integer
		ListView_GetEditControl = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_GETEDITCONTROL, 0, 0)
	End Function
	
	Public Function ListView_GetColumn(ByRef hWnd As Integer, ByRef iCol As Integer, ByRef pcol As LVCOLUMN) As Boolean
		'UPGRADE_WARNING: Couldn't resolve default property of object pcol. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		ListView_GetColumn = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_GETCOLUMN, iCol, pcol)
	End Function
	
	Public Function ListView_SetColumn(ByRef hWnd As Integer, ByRef iCol As Integer, ByRef pcol As LVCOLUMN) As Boolean
		'UPGRADE_WARNING: Couldn't resolve default property of object pcol. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		ListView_SetColumn = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_SETCOLUMN, iCol, pcol)
	End Function
	
	Public Function ListView_InsertColumn(ByRef hWnd As Integer, ByRef iCol As Integer, ByRef pcol As LVCOLUMN) As Integer
		'UPGRADE_WARNING: Couldn't resolve default property of object pcol. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		ListView_InsertColumn = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_INSERTCOLUMN, iCol, pcol)
	End Function
	
	Public Function ListView_DeleteColumn(ByRef hWnd As Integer, ByRef iCol As Integer) As Boolean
		ListView_DeleteColumn = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_DELETECOLUMN, iCol, 0)
	End Function
	
	Public Function ListView_GetColumnWidth(ByRef hWnd As Integer, ByRef iCol As Integer) As Integer
		ListView_GetColumnWidth = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_GETCOLUMNWIDTH, iCol, 0)
	End Function
	
	Public Function ListView_SetColumnWidth(ByRef hWnd As Integer, ByRef iCol As Integer, ByRef cx As Integer) As Boolean
		ListView_SetColumnWidth = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_SETCOLUMNWIDTH, iCol, MAKELPARAM(cx, 0))
	End Function
	
#If (WIN32_IE >= &H300) Then
	'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression (WIN32_IE >= &H300) did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
	
	Public Function ListView_GetHeader(hWnd As Long) As Long
	ListView_GetHeader = SendMessage(hWnd, LVM_GETHEADER, 0, 0)
	End Function
	'
#End If
	
	Public Function ListView_CreateDragImage(ByRef hWnd As Integer, ByRef i As Integer, ByRef lpptUpLeft As POINTAPI) As Integer
		'UPGRADE_WARNING: Couldn't resolve default property of object lpptUpLeft. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		ListView_CreateDragImage = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_CREATEDRAGIMAGE, i, lpptUpLeft)
	End Function
	
	Public Function ListView_GetViewRect(ByRef hWnd As Integer, ByRef prc As RECT) As Boolean
		'UPGRADE_WARNING: Couldn't resolve default property of object prc. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		ListView_GetViewRect = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_GETVIEWRECT, 0, prc)
	End Function
	
	Public Function ListView_GetTextColor(ByRef hWnd As Integer) As Integer
		ListView_GetTextColor = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_GETTEXTCOLOR, 0, 0)
	End Function
	
	Public Function ListView_SetTextColor(ByRef hWnd As Integer, ByRef clrText As Integer) As Boolean
		ListView_SetTextColor = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_SETTEXTCOLOR, 0, clrText)
	End Function
	
	Public Function ListView_GetTextBkColor(ByRef hWnd As Integer) As Integer
		ListView_GetTextBkColor = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_GETTEXTBKCOLOR, 0, 0)
	End Function
	
	Public Function ListView_SetTextBkColor(ByRef hWnd As Integer, ByRef clrTextBk As Integer) As Boolean
		ListView_SetTextBkColor = SendMessage(hWnd, mListviewDefs.LVMessages.LVM_SETTEXTBKCOLOR, 0, clrTextBk)
	End Function
	
	Public Function ListView_GetTopIndex(ByRef hwndLV As Integer) As Integer
		ListView_GetTopIndex = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_GETTOPINDEX, 0, 0)
	End Function
	
	Public Function ListView_GetCountPerPage(ByRef hwndLV As Integer) As Integer
		'Only fully visible items are counted.
		ListView_GetCountPerPage = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_GETCOUNTPERPAGE, 0, 0)
	End Function
	
	Public Function ListView_GetOrigin(ByRef hwndLV As Integer, ByRef ppt As POINTAPI) As Boolean
		'UPGRADE_WARNING: Couldn't resolve default property of object ppt. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		ListView_GetOrigin = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_GETORIGIN, 0, ppt)
	End Function
	
	Public Function ListView_Update(ByRef hwndLV As Integer, ByRef i As Integer) As Boolean
		ListView_Update = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_UPDATE, i, 0)
	End Function
	
	Public Function ListView_SetItemState(ByRef hwndLV As Integer, ByRef i As Integer, ByRef state As mListviewDefs.LVITEM_state, ByRef mask As mListviewDefs.LVITEM_state) As Boolean
		Dim lvi As LVITEM
		lvi.state = state
		lvi.stateMask = mask
		'UPGRADE_WARNING: Couldn't resolve default property of object lvi. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		ListView_SetItemState = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_SETITEMSTATE, i, lvi)
	End Function
	
	Public Function ListView_GetItemState(ByRef hwndLV As Integer, ByRef i As Integer, ByRef mask As mListviewDefs.LVITEM_state) As Integer ' LVITEM_state
		ListView_GetItemState = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_GETITEMSTATE, i, mask)
	End Function
	
#If (WIN32_IE >= &H300) Then
	'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression (WIN32_IE >= &H300) did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
	
	Public Function ListView_GetCheckState(hwndLV As Long, iIndex As Long) As Long   ' updated
	Dim dwState As Long
	dwState = SendMessage(hwndLV, LVM_GETITEMSTATE, ByVal iIndex, ByVal LVIS_STATEIMAGEMASK)
	ListView_GetCheckState = (dwState \ 2 ^ 12) - 1
	'((((UINT)(SendMessage(hwndLV, LVM_GETITEMSTATE, ByVal i, LVIS_STATEIMAGEMASK))) >> 12) -1)
	End Function
	'
#End If
	
	Public Sub ListView_GetItemText(ByRef hwndLV As Integer, ByRef i As Integer, ByRef iSubItem As Integer, ByRef pszText As Integer, ByRef cchTextMax As Integer)
		Dim lvi As LVITEM
		lvi.iSubItem = iSubItem
		lvi.cchTextMax = cchTextMax
		lvi.pszText = pszText
		'UPGRADE_WARNING: Couldn't resolve default property of object lvi. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_GETITEMTEXT, i, lvi)
		pszText = lvi.pszText ' fills pszText w/ pointer
	End Sub
	
	Public Sub ListView_SetItemText(ByRef hwndLV As Integer, ByRef i As Integer, ByRef iSubItem As Integer, ByRef pszText As Integer)
		Dim lvi As LVITEM
		lvi.iSubItem = iSubItem
		lvi.pszText = pszText
		'UPGRADE_WARNING: Couldn't resolve default property of object lvi. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_SETITEMTEXT, i, lvi)
	End Sub
	
	Public Sub ListView_SetItemCount(ByRef hwndLV As Integer, ByRef cItems As Integer)
		SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_SETITEMCOUNT, cItems, 0)
	End Sub
	
#If (WIN32_IE >= &H300) Then
	'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression (WIN32_IE >= &H300) did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
	
	Public Sub ListView_SetItemCountEx(hwndLV As Long, cItems As Long, dwFlags As Long)
	SendMessage hwndLV, LVM_SETITEMCOUNT, ByVal cItems, ByVal dwFlags
	End Sub
	'
#End If
	
	Public Function ListView_SortItems(ByRef hwndLV As Integer, ByRef pfnCompare As Integer, ByRef lParamSort As Integer) As Boolean
		ListView_SortItems = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_SORTITEMS, lParamSort, pfnCompare)
	End Function
	
	Public Sub ListView_SetItemPosition32(ByRef hwndLV As Integer, ByRef i As Integer, ByRef x As Integer, ByRef y As Integer)
		Dim ptNewPos As POINTAPI
		ptNewPos.x = x
		ptNewPos.y = y
		'UPGRADE_WARNING: Couldn't resolve default property of object ptNewPos. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_SETITEMPOSITION32, i, ptNewPos)
	End Sub
	
	Public Function ListView_GetSelectedCount(ByRef hwndLV As Integer) As Integer
		ListView_GetSelectedCount = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_GETSELECTEDCOUNT, 0, 0)
	End Function
	
	Public Function ListView_GetItemSpacing(ByRef hwndLV As Integer, ByRef fSmall As Boolean) As Integer
		ListView_GetItemSpacing = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_GETITEMSPACING, fSmall, 0)
	End Function
	
	Public Function ListView_GetISearchString(ByRef hwndLV As Integer, ByRef lpsz As String) As Boolean
		ListView_GetISearchString = SendMessage(hwndLV, mListviewDefs.LVMessages.LVM_GETISEARCHSTRING, 0, lpsz)
	End Function
	
	' =============================================================
	' the next three macros are user-defined
	
	' Returns the index of the item that is selected and has the focus rectangle
	
	Public Function ListView_GetSelectedItem(ByRef hwndLV As Integer) As Integer
		ListView_GetSelectedItem = ListView_GetNextItem(hwndLV, -1, mListviewDefs.LVNI_Flags.LVNI_FOCUSED Or mListviewDefs.LVNI_Flags.LVNI_SELECTED)
	End Function
	
	' Selects the specified item and gives it the focus rectangle.
	' does not de-select any currently selected items
	
	Public Function ListView_SetSelectedItem(ByRef hwndLV As Integer, ByRef i As Integer) As Boolean
		ListView_SetSelectedItem = ListView_SetItemState(hwndLV, i, mListviewDefs.LVITEM_state.LVIS_FOCUSED Or mListviewDefs.LVITEM_state.LVIS_SELECTED, mListviewDefs.LVITEM_state.LVIS_FOCUSED Or mListviewDefs.LVITEM_state.LVIS_SELECTED)
	End Function
	
	' Selects all listview items. The item with the focus rectangle maintains it.
	
	Public Function ListView_SelectAll(ByRef hwndLV As Integer) As Boolean
		ListView_SelectAll = ListView_SetItemState(hwndLV, -1, mListviewDefs.LVITEM_state.LVIS_SELECTED, mListviewDefs.LVITEM_state.LVIS_SELECTED)
	End Function
	
	Public Function ListView_GetSubItemRect(ByRef hWnd As Integer, ByRef iItem As Integer, ByRef iSubItem As Integer, ByRef code As Integer, ByRef prc As RECT) As Boolean
		prc.Top = iSubItem
		prc.Left_Renamed = code
		'UPGRADE_WARNING: Couldn't resolve default property of object prc. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		ListView_GetSubItemRect = SendMessage(hWnd, LVM_GETSUBITEMRECT, iItem, prc)
	End Function
	
	' ==============================================================
#If (WIN32_IE >= &H300) Then
	'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression (WIN32_IE >= &H300) did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
	'
	' // -1 for cx and cy means we'll use the default (system settings)
	' // 0 for cx or cy means use the current setting (allows you to change just one param)
	Public Function ListView_SetIconSpacing(hwndLV As Long, cx As Long, cy As Long) As Long
	ListView_SetIconSpacing = SendMessage(hwndLV, LVM_SETICONSPACING, 0, ByVal MAKELONG(cx, cy))
	End Function
	
	Public Function ListView_SetExtendedListViewStyle(hwndLV As Long, dw As Long) As Long
	ListView_SetExtendedListViewStyle = SendMessage(hwndLV, LVM_SETEXTENDEDLISTVIEWSTYLE, 0, ByVal dw)
	End Function
	
	Public Function ListView_GetExtendedListViewStyle(hwndLV As Long) As Long
	ListView_GetExtendedListViewStyle = SendMessage(hwndLV, LVM_GETEXTENDEDLISTVIEWSTYLE, 0, 0)
	End Function
	
	Public Function ListView_SubItemHitTest(hWnd As Long, plvhti As LVHITTESTINFO) As Long
	ListView_SubItemHitTest = SendMessage(hWnd, LVM_SUBITEMHITTEST, 0, plvhti)
	End Function
	
	Public Function ListView_SetColumnOrderArray(hWnd As Long, iCount As Long, lpiArray As Long) As Boolean
	ListView_SetColumnOrderArray = SendMessage(hWnd, LVM_SETCOLUMNORDERARRAY, ByVal iCount, lpiArray)
	End Function
	
	Public Function ListView_GetColumnOrderArray(hWnd As Long, iCount As Long, lpiArray As Long) As Boolean
	ListView_GetColumnOrderArray = SendMessage(hWnd, LVM_GETCOLUMNORDERARRAY, ByVal iCount, lpiArray)
	End Function
	
	Public Function ListView_SetHotItem(hWnd As Long, i As Long) As Long
	ListView_SetHotItem = SendMessage(hWnd, LVM_SETHOTITEM, ByVal i, 0)
	End Function
	
	Public Function ListView_GetHotItem(hWnd As Long) As Long
	ListView_GetHotItem = SendMessage(hWnd, LVM_GETHOTITEM, 0, 0)
	End Function
	
	Public Function ListView_SetHotCursor(hWnd As Long, hcur As Long) As Long
	ListView_SetHotCursor = SendMessage(hWnd, LVM_SETHOTCURSOR, 0, ByVal hcur)
	End Function
	
	Public Function ListView_GetHotCursor(hWnd As Long) As Long
	ListView_GetHotCursor = SendMessage(hWnd, LVM_GETHOTCURSOR, 0, 0)
	End Function
	
	Public Function ListView_ApproximateViewRect(hWnd As Long, iWidth As Long, _
	                                                                      iHeight As Long, iCount As Long) As Long
	ListView_ApproximateViewRect = SendMessage(hWnd, _
	                                                                          LVM_APPROXIMATEVIEWRECT, _
	                                                                          ByVal iCount, _
	                                                                          ByVal MAKELPARAM(iWidth, iHeight))
	End Function
	'
#End If ' ' WIN32_IE >= &H300
	'
	
	' ==============================================================
#If (WIN32_IE >= &H400) Then
	'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression (WIN32_IE >= &H400) did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
	
	Public Function ListView_SetUnicodeFormat(hWnd As Long, fUnicode As Boolean) As Boolean
	ListView_SetUnicodeFormat = SendMessage(hWnd, LVM_SETUNICODEFORMAT, ByVal fUnicode, 0)
	End Function
	
	Public Function ListView_GetUnicodeFormat(hWnd As Long) As Boolean
	ListView_GetUnicodeFormat = SendMessage(hWnd, LVM_GETUNICODEFORMAT, 0, 0)
	End Function
	
	Public Function ListView_SetExtendedListViewStyleEx(hwndLV As Long, dwMask As Long, dw As Long) As Long
	ListView_SetExtendedListViewStyleEx = SendMessage(hwndLV, LVM_SETEXTENDEDLISTVIEWSTYLE, _
	                                                                                    ByVal dwMask, ByVal dw)
	End Function
	
	Public Function ListView_SetWorkAreas(hWnd As Long, nWorkAreas As Long, prc() As RECT) As Boolean
	ListView_SetWorkAreas = SendMessage(hWnd, LVM_SETWORKAREAS, ByVal nWorkAreas, prc(0))
	End Function
	
	Public Function ListView_GetWorkAreas(hWnd As Long, nWorkAreas, prc() As RECT) As Boolean
	ListView_GetWorkAreas = SendMessage(hWnd, LVM_GETWORKAREAS, ByVal nWorkAreas, prc(0))
	End Function
	
	Public Function ListView_GetNumberOfWorkAreas(hWnd As Long, pnWorkAreas As Long) As Boolean
	ListView_GetNumberOfWorkAreas = SendMessage(hWnd, LVM_GETNUMBEROFWORKAREAS, 0, pnWorkAreas)
	End Function
	
	Public Function ListView_GetSelectionMark(hWnd As Long) As Long
	ListView_GetSelectionMark = SendMessage(hWnd, LVM_GETSELECTIONMARK, 0, 0)
	End Function
	
	Public Function ListView_SetSelectionMark(hWnd As Long, i As Long) As Long
	ListView_SetSelectionMark = SendMessage(hWnd, LVM_SETSELECTIONMARK, 0, ByVal i)
	End Function
	
	Public Function ListView_SetHoverTime(hwndLV As Long, dwHoverTimeMs As Long) As Long
	ListView_SetHoverTime = SendMessage(hwndLV, LVM_SETHOVERTIME, 0, ByVal dwHoverTimeMs)
	End Function
	
	Public Function ListView_GetHoverTime(hwndLV As Long) As Long
	ListView_GetHoverTime = SendMessage(hwndLV, LVM_GETHOVERTIME, 0, 0)
	End Function
	
	Public Function ListView_SetToolTips(hwndLV As Long, hwndNewHwnd As Long) As Long
	ListView_SetToolTips = SendMessage(hwndLV, LVM_SETTOOLTIPS, ByVal hwndNewHwnd, 0)
	End Function
	
	Public Function ListView_GetToolTips(hwndLV As Long) As Long
	ListView_GetToolTips = SendMessage(hwndLV, LVM_GETTOOLTIPS, 0, 0)
	End Function
	
	Public Function ListView_SetBkImage(hWnd As Long, plvbki As LVBKIMAGE) As Boolean
	ListView_SetBkImage = SendMessage(hWnd, LVM_SETBKIMAGE, 0, plvbki)
	End Function
	
	Public Function ListView_GetBkImage(hWnd As Long, plvbki As LVBKIMAGE) As Boolean
	ListView_GetBkImage = SendMessage(hWnd, LVM_GETBKIMAGE, 0, plvbki)
	End Function
	
#End If ' WIN32_IE >= &H400
End Module