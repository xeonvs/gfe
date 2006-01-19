Option Strict Off
Option Explicit On
Module mListviewDefs
	
	
	Public Const WC_LISTVIEW As String = "SysListView32"
	
	
	Public Enum LVStyles
		LVS_ICON = &H0s
		LVS_REPORT = &H1s
		LVS_SMALLICON = &H2s
		LVS_LIST = &H3s
		LVS_TYPEMASK = &H3s
		LVS_SINGLESEL = &H4s
		LVS_SHOWSELALWAYS = &H8s
		LVS_SORTASCENDING = &H10s
		LVS_SORTDESCENDING = &H20s
		LVS_SHAREIMAGELISTS = &H40s
		LVS_NOLABELWRAP = &H80s
		LVS_AUTOARRANGE = &H100s
		LVS_EDITLABELS = &H200s
		LVS_OWNERDATA = &H1000s
		LVS_NOSCROLL = &H2000s
		LVS_TYPESTYLEMASK = &HFC00s
		LVS_ALIGNTOP = &H0s
		LVS_ALIGNLEFT = &H800s
		LVS_ALIGNMASK = &HC00s
		LVS_OWNERDRAWFIXED = &H400s
		LVS_NOCOLUMNHEADER = &H4000s
		LVS_NOSORTHEADER = &H8000
	End Enum ' LVStyles
	
	' ============================================
	' Messages
	
	Public Enum LVMessages
		LVM_FIRST = &H1000s
		LVM_GETBKCOLOR = (LVMessages.LVM_FIRST + 0)
		LVM_SETBKCOLOR = (LVMessages.LVM_FIRST + 1)
		LVM_GETIMAGELIST = (LVMessages.LVM_FIRST + 2)
		LVM_SETIMAGELIST = (LVMessages.LVM_FIRST + 3)
		LVM_GETITEMCOUNT = (LVMessages.LVM_FIRST + 4)
#If UNICODE Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression UNICODE did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
		LVM_GETITEM = (LVM_FIRST + 75)
		LVM_SETITEM = (LVM_FIRST + 76)
		LVM_INSERTITEM = (LVM_FIRST + 77)
#Else
		LVM_GETITEM = (LVMessages.LVM_FIRST + 5)
		LVM_SETITEM = (LVMessages.LVM_FIRST + 6)
		LVM_INSERTITEM = (LVMessages.LVM_FIRST + 7)
#End If
		LVM_DELETEITEM = (LVMessages.LVM_FIRST + 8)
		LVM_DELETEALLITEMS = (LVMessages.LVM_FIRST + 9)
		LVM_GETCALLBACKMASK = (LVMessages.LVM_FIRST + 10)
		LVM_SETCALLBACKMASK = (LVMessages.LVM_FIRST + 11)
		LVM_GETNEXTITEM = (LVMessages.LVM_FIRST + 12)
#If UNICODE Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression UNICODE did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
		LVM_FINDITEM = (LVM_FIRST + 83)
#Else
		LVM_FINDITEM = (LVMessages.LVM_FIRST + 13)
#End If
		LVM_GETITEMRECT = (LVMessages.LVM_FIRST + 14)
		LVM_SETITEMPOSITION = (LVMessages.LVM_FIRST + 15)
		LVM_GETITEMPOSITION = (LVMessages.LVM_FIRST + 16)
#If UNICODE Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression UNICODE did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
		LVM_GETSTRINGWIDTH = (LVM_FIRST + 87)
#Else
		LVM_GETSTRINGWIDTH = (LVMessages.LVM_FIRST + 17)
#End If
		LVM_HITTEST = (LVMessages.LVM_FIRST + 18)
		LVM_ENSUREVISIBLE = (LVMessages.LVM_FIRST + 19)
		LVM_SCROLL = (LVMessages.LVM_FIRST + 20)
		LVM_REDRAWITEMS = (LVMessages.LVM_FIRST + 21)
		LVM_ARRANGE = (LVMessages.LVM_FIRST + 22)
#If UNICODE Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression UNICODE did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
		LVM_EDITLABEL = (LVM_FIRST + 118)
#Else
		LVM_EDITLABEL = (LVMessages.LVM_FIRST + 23)
#End If
		LVM_GETEDITCONTROL = (LVMessages.LVM_FIRST + 24)
#If UNICODE Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression UNICODE did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
		LVM_GETCOLUMN = (LVM_FIRST + 95)
		LVM_SETCOLUMN = (LVM_FIRST + 96)
		LVM_INSERTCOLUMN = (LVM_FIRST + 97)
#Else
		LVM_GETCOLUMN = (LVMessages.LVM_FIRST + 25)
		LVM_SETCOLUMN = (LVMessages.LVM_FIRST + 26)
		LVM_INSERTCOLUMN = (LVMessages.LVM_FIRST + 27)
#End If
		LVM_DELETECOLUMN = (LVMessages.LVM_FIRST + 28)
		LVM_GETCOLUMNWIDTH = (LVMessages.LVM_FIRST + 29)
		LVM_SETCOLUMNWIDTH = (LVMessages.LVM_FIRST + 30)
#If (WIN32_IE >= &H300) Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression (WIN32_IE >= &H300) did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
		LVM_GETHEADER = (LVM_FIRST + 31)
#End If
		LVM_CREATEDRAGIMAGE = (LVMessages.LVM_FIRST + 33)
		LVM_GETVIEWRECT = (LVMessages.LVM_FIRST + 34)
		LVM_GETTEXTCOLOR = (LVMessages.LVM_FIRST + 35)
		LVM_SETTEXTCOLOR = (LVMessages.LVM_FIRST + 36)
		LVM_GETTEXTBKCOLOR = (LVMessages.LVM_FIRST + 37)
		LVM_SETTEXTBKCOLOR = (LVMessages.LVM_FIRST + 38)
		LVM_GETTOPINDEX = (LVMessages.LVM_FIRST + 39)
		LVM_GETCOUNTPERPAGE = (LVMessages.LVM_FIRST + 40)
		LVM_GETORIGIN = (LVMessages.LVM_FIRST + 41)
		LVM_UPDATE = (LVMessages.LVM_FIRST + 42)
		LVM_SETITEMSTATE = (LVMessages.LVM_FIRST + 43)
		LVM_GETITEMSTATE = (LVMessages.LVM_FIRST + 44)
#If UNICODE Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression UNICODE did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
		LVM_GETITEMTEXT = (LVM_FIRST + 115)
		LVM_SETITEMTEXT = (LVM_FIRST + 116)
#Else
		LVM_GETITEMTEXT = (LVMessages.LVM_FIRST + 45)
		LVM_SETITEMTEXT = (LVMessages.LVM_FIRST + 46)
#End If
		LVM_SETITEMCOUNT = (LVMessages.LVM_FIRST + 47)
		LVM_SORTITEMS = (LVMessages.LVM_FIRST + 48)
		LVM_SETITEMPOSITION32 = (LVMessages.LVM_FIRST + 49)
		LVM_GETSELECTEDCOUNT = (LVMessages.LVM_FIRST + 50)
		LVM_GETITEMSPACING = (LVMessages.LVM_FIRST + 51)
#If UNICODE Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression UNICODE did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
		LVM_GETISEARCHSTRING = (LVM_FIRST + 117)
#Else
		LVM_GETISEARCHSTRING = (LVMessages.LVM_FIRST + 52)
#End If
#If (WIN32_IE >= &H300) Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression (WIN32_IE >= &H300) did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
		LVM_SETICONSPACING = (LVM_FIRST + 53)
		LVM_SETEXTENDEDLISTVIEWSTYLE = (LVM_FIRST + 54)
		LVM_GETEXTENDEDLISTVIEWSTYLE = (LVM_FIRST + 55)
		
		LVM_GETSUBITEMRECT = (LVM_FIRST + 56)
		LVM_SUBITEMHITTEST = (LVM_FIRST + 57)
		LVM_SETCOLUMNORDERARRAY = (LVM_FIRST + 58)
		LVM_GETCOLUMNORDERARRAY = (LVM_FIRST + 59)
		LVM_SETHOTITEM = (LVM_FIRST + 60)
		LVM_GETHOTITEM = (LVM_FIRST + 61)
		LVM_SETHOTCURSOR = (LVM_FIRST + 62)
		LVM_GETHOTCURSOR = (LVM_FIRST + 63)
		LVM_APPROXIMATEVIEWRECT = (LVM_FIRST + 64)
#End If ' // WIN32_IE >= &H300
#If (WIN32_IE >= &H400) Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression (WIN32_IE >= &H400) did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
		LVM_SETWORKAREAS = (LVM_FIRST + 65)
		LVM_GETWORKAREAS = (LVM_FIRST + 70)
		LVM_GETNUMBEROFWORKAREAS = (LVM_FIRST + 73)
		LVM_GETSELECTIONMARK = (LVM_FIRST + 66)
		LVM_SETSELECTIONMARK = (LVM_FIRST + 67)
		LVM_SETHOVERTIME = (LVM_FIRST + 71)
		LVM_GETHOVERTIME = (LVM_FIRST + 72)
		LVM_SETTOOLTIPS = (LVM_FIRST + 74)
		LVM_GETTOOLTIPS = (LVM_FIRST + 78)
		#If UNICODE Then 
		LVM_SETBKIMAGE = (LVM_FIRST + 138)
		LVM_GETBKIMAGE = (LVM_FIRST + 139)
		#Else
		LVM_SETBKIMAGE = (LVM_FIRST + 68)
		LVM_GETBKIMAGE = (LVM_FIRST + 69)
		#End If
#End If ' // WIN32_IE >= &H400
#If (WIN32_IE >= &H400) Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression (WIN32_IE >= &H400) did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
		LVM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT
		LVM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT
#End If
	End Enum ' LVMessages
	
	
	Public Const LV_MAX_WORKAREAS As Short = 16
	
	' LVM_GETIMAGELIST wParam
	Public Enum LVSIL_Flags
		LVSIL_NORMAL = 0
		LVSIL_SMALL = 1
		LVSIL_STATE = 2
	End Enum
	
	' LVM_GETNEXTITEM flags
	Public Enum LVNI_Flags
		LVNI_ALL = &H0s
		LVNI_FOCUSED = &H1s
		LVNI_SELECTED = &H2s
		LVNI_CUT = &H4s
		LVNI_DROPHILITED = &H8s
		LVNI_ABOVE = &H100s
		LVNI_BELOW = &H200s
		LVNI_TOLEFT = &H400s
		LVNI_TORIGHT = &H800s
	End Enum
	
	' LVM_GETITEMRECT rct.Left
	Public Enum LVIR_Flags
		LVIR_BOUNDS = 0
		LVIR_ICON = 1
		LVIR_LABEL = 2
		LVIR_SELECTBOUNDS = 3
	End Enum
	
	' LVM_ARRANGE wParam
	Public Enum LVA_Flags
		LVA_DEFAULT = &H0s
		LVA_ALIGNLEFT = &H1s
		LVA_ALIGNTOP = &H2s
		LVA_SNAPTOGRID = &H5s
	End Enum
	
	' ============================================
	' Structures and their flags
	
	Public Structure LVITEM ' was LV_ITEM
		Dim mask As LVITEM_mask
		Dim iItem As Integer
		Dim iSubItem As Integer
		Dim state As LVITEM_state
		Dim stateMask As Integer
		Dim pszText As Integer ' if String, must be pre-allocated
		Dim cchTextMax As Integer
		Dim iImage As Integer
		Dim lParam As Integer
		Dim iIndent As Integer
	End Structure
	
	Public Const I_INDENTCALLBACK As Short = (-1) ' iIndent, 4.70
	
	Public Enum LVITEM_mask
		LVIF_TEXT = &H1s
		LVIF_IMAGE = &H2s
		LVIF_PARAM = &H4s
		LVIF_STATE = &H8s
		LVIF_INDENT = &H10s
		LVIF_NORECOMPUTE = &H800s
		LVIF_DI_SETITEM = &H1000s ' NMLVDISPINFO notification
	End Enum
	
	Public Enum LVITEM_state
		LVIS_FOCUSED = &H1s
		LVIS_SELECTED = &H2s
		LVIS_CUT = &H4s
		LVIS_DROPHILITED = &H8s
		LVIS_ACTIVATING = &H20s
		LVIS_OVERLAYMASK = &HF00s
		LVIS_STATEIMAGEMASK = &HF000s
	End Enum
	
	Public Structure POINTAPI
		Dim x As Integer
		Dim y As Integer
	End Structure
	
	Public Structure RECT ' rc
		'UPGRADE_NOTE: Left was upgraded to Left_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Left_Renamed As Integer
		Dim Top As Integer
		'UPGRADE_NOTE: Right was upgraded to Right_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Right_Renamed As Integer
		Dim Bottom As Integer
	End Structure
	
	
	Public Structure LVFINDINFO ' was LV_FINDINFO
		Dim flags As LVFINDINFO_flags
		Dim psz As Integer ' if String, must be pre-allocated
		Dim lParam As Integer
		Dim pt As POINTAPI
		Dim vkDirection As Integer
	End Structure
	
	Public Enum LVFINDINFO_flags
		LVFI_PARAM = &H1s
		LVFI_STRING = &H2s
		LVFI_PARTIAL = &H8s
		LVFI_WRAP = &H20s
		LVFI_NEARESTXY = &H40s
	End Enum
	
	Public Structure LVHITTESTINFO ' was LV_HITTESTINFO
		Dim pt As POINTAPI
		Dim flags As LVHITTESTINFO_flags
		Dim iItem As Integer
		Dim iSubItem As Integer ' this is was NOT in win95.  valid only for LVM_SUBITEMHITTEST
	End Structure
	
	Public Enum LVHITTESTINFO_flags
		LVHT_NOWHERE = &H1s ' in LV client area, but not over item
		LVHT_ONITEMICON = &H2s
		LVHT_ONITEMLABEL = &H4s
		LVHT_ONITEMSTATEICON = &H8s
		LVHT_ONITEM = (LVHITTESTINFO_flags.LVHT_ONITEMICON Or LVHITTESTINFO_flags.LVHT_ONITEMLABEL Or LVHITTESTINFO_flags.LVHT_ONITEMSTATEICON)
		' outside the LV's client area
		LVHT_ABOVE = &H8s
		LVHT_BELOW = &H10s
		LVHT_TORIGHT = &H20s
		LVHT_TOLEFT = &H40s
	End Enum
	
	Public Structure LVCOLUMN ' was LV_COLUMN
		Dim mask As LVCOLUMN_mask
		Dim fmt As LVCOLUMN_fmt
		Dim cx As Integer
		Dim pszText As Integer ' if String, must be pre-allocated
		Dim cchTextMax As Integer
		Dim iSubItem As Integer
		Dim iImage As Integer
		Dim iOrder As Integer
	End Structure
	
	Public Enum LVCOLUMN_mask
		LVCF_FMT = &H1s
		LVCF_WIDTH = &H2s
		LVCF_TEXT = &H4s
		LVCF_SUBITEM = &H8s
		LVCF_IMAGE = &H10s
		LVCF_ORDER = &H20s
	End Enum
	
	Public Enum LVCOLUMN_fmt
		LVCFMT_LEFT = &H0s
		LVCFMT_RIGHT = &H1s
		LVCFMT_CENTER = &H2s
		LVCFMT_JUSTIFYMASK = &H3s
		LVCFMT_IMAGE = &H800s
		LVCFMT_BITMAP_ON_RIGHT = &H1000s
		LVCFMT_COL_HAS_IMAGES = &H8000
	End Enum
	
	Public Enum LVM_SETCOLUMNWIDTH_lParam
		LVSCW_AUTOSIZE = -1
		LVSCW_AUTOSIZE_USEHEADER = -2
	End Enum
	
	' // these flags only apply to LVS_OWNERDATA listviews in report or list mode
	Public Enum LVM_SETITEMCOUNT_lParam
		LVSICF_NOINVALIDATEALL = &H1s
		LVSICF_NOSCROLL = &H2s
	End Enum
	
	Public Enum LVM_SETEXTENDEDLISTVIEWSTYLE_lParam
		LVS_EX_GRIDLINES = &H1s
		LVS_EX_SUBITEMIMAGES = &H2s
		LVS_EX_CHECKBOXES = &H4s
		LVS_EX_TRACKSELECT = &H8s
		LVS_EX_HEADERDRAGDROP = &H10s
		LVS_EX_FULLROWSELECT = &H20s ' // applies to report mode only
		LVS_EX_ONECLICKACTIVATE = &H40s
		LVS_EX_TWOCLICKACTIVATE = &H80s
		LVS_EX_FLATSB = &H100s
		LVS_EX_REGIONAL = &H200s
		LVS_EX_INFOTIP = &H400s ' listview does InfoTips for you
		LVS_EX_UNDERLINEHOT = &H800s
		LVS_EX_UNDERLINECOLD = &H1000s
		LVS_EX_MULTIWORKAREAS = &H2000s
	End Enum
	
	Public Structure LVBKIMAGE
		Dim ulFlags As LVBKIMAGE_ulFlags
		Dim hbm As Integer
		Dim pszImage As Integer ' if String, must be pre-allocated
		Dim cchImageMax As Integer
		Dim xOffsetPercent As Integer
		Dim yOffsetPercent As Integer
	End Structure
	
	Public Enum LVBKIMAGE_ulFlags
		LVBKIF_SOURCE_NONE = &H0s
		LVBKIF_SOURCE_HBITMAP = &H1s
		LVBKIF_SOURCE_URL = &H2s
		LVBKIF_SOURCE_MASK = &H3s
		LVBKIF_STYLE_NORMAL = &H0s
		LVBKIF_STYLE_TILE = &H10s
		LVBKIF_STYLE_MASK = &H10s
	End Enum
	
	' ============================================
	' Notifications
	Public Enum LVNotifications
		LVN_FIRST = -100 ' &HFFFFFF9C   ' (0U-100U)
		LVN_LAST = -199 ' &HFFFFFF39   ' (0U-199U)
		' lParam points to:
		LVN_ITEMCHANGING = (LVNotifications.LVN_FIRST - 0) ' NMLISTVIEW, ?, rtn T/F
		LVN_ITEMCHANGED = (LVNotifications.LVN_FIRST - 1) ' NMLISTVIEW, ?
		LVN_INSERTITEM = (LVNotifications.LVN_FIRST - 2) ' NMLISTVIEW, iItem
		LVN_DELETEITEM = (LVNotifications.LVN_FIRST - 3) ' NMLISTVIEW, iItem
		LVN_DELETEALLITEMS = (LVNotifications.LVN_FIRST - 4) ' NMLISTVIEW, iItem = -1, rtn T/F
		LVN_COLUMNCLICK = (LVNotifications.LVN_FIRST - 8) ' NMLISTVIEW, iItem = -1, iSubItem = column
		LVN_BEGINDRAG = (LVNotifications.LVN_FIRST - 9) ' NMLISTVIEW, iItem
		LVN_BEGINRDRAG = (LVNotifications.LVN_FIRST - 11) ' NMLISTVIEW, iItem
#If (WIN32_IE >= &H300) Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression (WIN32_IE >= &H300) did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
		LVN_ODCACHEHINT = (LVN_FIRST - 13)           ' NMLVCACHEHINT
		LVN_ITEMACTIVATE = (LVN_FIRST - 14)           ' v4.70 = NMHDR, v4.71 = NMITEMACTIVATE
		LVN_ODSTATECHANGED = (LVN_FIRST - 15)  ' NMLVODSTATECHANGE, rtn T/F
#End If ' // WIN32_IE >= &H300
#If (WIN32_IE >= &H400) Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression (WIN32_IE >= &H400) did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
		LVN_HOTTRACK = (LVN_FIRST - 21)                 ' NMLISTVIEW, see docs, rtn T/F
#End If
#If UNICODE Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression UNICODE did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
		LVN_BEGINLABELEDIT = (LVN_FIRST - 75)
		LVN_ENDLABELEDIT = (LVN_FIRST - 76)
		LVN_GETDISPINFO = (LVN_FIRST - 77)
		LVN_SETDISPINFO = (LVN_FIRST - 78)
		#If (WIN32_IE >= &H300) Then 
		LVN_ODFINDITEM = (LVN_FIRST - 79)             ' NMLVFINDITEM
		#End If   ' (WIN32_IE >= &H300)
		#If (WIN32_IE >= &H400) Then 
		LVN_GETINFOTIP = (LVN_FIRST - 58)              ' NMLVGETINFOTIP
		#End If  ' (WIN32_IE >= &H400)
#Else
		LVN_BEGINLABELEDIT = (LVNotifications.LVN_FIRST - 5) ' NMLVDISPINFO, iItem, rtn T/F
		LVN_ENDLABELEDIT = (LVNotifications.LVN_FIRST - 6) ' NMLVDISPINFO, see docs
		LVN_GETDISPINFO = (LVNotifications.LVN_FIRST - 50) ' NMLVDISPINFO, see docs
		LVN_SETDISPINFO = (LVNotifications.LVN_FIRST - 51) ' NMLVDISPINFO, see docs
#If (WIN32_IE >= &H300) Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression (WIN32_IE >= &H300) did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
		LVN_ODFINDITEM = (LVN_FIRST - 52)             ' NMLVFINDITEM
#End If ' (WIN32_IE >= &H300)
#If (WIN32_IE >= &H400) Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression (WIN32_IE >= &H400) did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
		LVN_GETINFOTIP = (LVN_FIRST - 57)             ' NMLVGETINFOTIP
#End If ' (WIN32_IE >= &H400)
#End If ' UNICODE
		LVN_KEYDOWN = (LVNotifications.LVN_FIRST - 55) ' NMLVKEYDOWN
#If (WIN32_IE >= &H300) Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression (WIN32_IE >= &H300) did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1035"'
		LVN_MARQUEEBEGIN = (LVN_FIRST - 56)       ' NMLISTVIEW, rtn T/F
#End If
	End Enum ' LVNotifications
	
	Public Structure NMHDR
		Dim hwndFrom As Integer ' Window handle of control sending message
		Dim idFrom As Integer ' Identifier of control sending message
		'UPGRADE_NOTE: code was upgraded to code_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim code_Renamed As Integer ' Specifies the notification code
	End Structure
	
	Public Structure NMLISTVIEW ' was NM_LISTVIEW
		Dim hdr As NMHDR
		Dim iItem As Integer
		Dim iSubItem As Integer
		Dim uNewState As LVITEM_state
		Dim uOldState As LVITEM_state
		Dim uChanged As LVITEM_mask
		Dim ptAction As POINTAPI
		Dim lParam As Integer
	End Structure
	
	'// NMITEMACTIVATE is used instead of NMLISTVIEW in IE >= 0x400
	'// therefore all the fields are the same except for extra uKeyFlags
	'// they are used to store key flags at the time of the single click with
	'// delayed activation - because by the time the timer goes off a user may
	'// not hold the keys (shift, ctrl) any more
	Public Structure NMITEMACTIVATE
		Dim hdr As NMHDR
		Dim iItem As Integer
		Dim iSubItem As Integer
		Dim uNewState As Integer
		Dim uOldState As Integer
		Dim uChanged As Integer
		Dim ptAction As POINTAPI
		Dim lParam As Integer
		Dim uKeyFlags As Integer
	End Structure
	
	'// key flags stored in uKeyFlags
	Public Enum NMITEMACTIVATE_uKeyFlags
		LVKF_ALT = &H1s
		LVKF_CONTROL = &H2s
		LVKF_SHIFT = &H4s
	End Enum
	
	Public Structure NMCUSTOMDRAWINFO
		Dim hdr As NMHDR
		Dim dwDrawStage As Integer
		Dim hdc As Integer
		Dim rc As RECT
		Dim dwItemSpec As Integer
		Dim iItemState As Integer
		Dim lItemlParam As Integer
	End Structure
	
	Public Structure DRAWITEMSTRUCT
		Dim CtlType As Integer
		Dim CtlID As Integer
		Dim itemID As Integer
		Dim itemAction As Integer
		Dim itemState As Integer
		Dim hwndItem As Integer
		Dim hdc As Integer
		Dim rcItem As RECT
		Dim ItemData As Integer
	End Structure
	
	Public Structure NMLVCUSTOMDRAW
		Dim nmcmd As NMCUSTOMDRAWINFO
		Dim clrText As Integer
		Dim clrTextBk As Integer
		Dim iSubItem As Short
	End Structure
	
	
	Public Structure NMLVCACHEHINT
		Dim hdr As NMHDR
		Dim iFrom As Integer
		Dim iTo As Integer
	End Structure
	
	Public Structure NMLVFINDITEM ' was NM_LVFINDITEM
		Dim hdr As NMHDR
		Dim iStart As Integer
		Dim lvfi As LVFINDINFO
	End Structure
	
	Public Structure NMODSTATECHANGE ' was NM_ODSTATECHANGE
		Dim hdr As NMHDR
		Dim iFrom As Integer
		Dim iTo As Integer
		Dim uNewState As Integer
		Dim uOldState As Integer
	End Structure
	
	Public Structure NMLVDISPINFO ' was LV_DISPINFO
		Dim hdr As NMHDR
		Dim item As LVITEM
	End Structure
	
	Public Structure NMLVKEYDOWN ' was LV_KEYDOWN
		Dim hdr As NMHDR
		Dim wVKey As Short ' can't be KeyCodeConstants, enums are Longs!
		Dim flags As Integer ' Always zero.
	End Structure
	
	Public Structure NMLVGETINFOTIP
		Dim hdr As NMHDR
		Dim dwFlags As Integer
		Dim pszText As Integer ' if String, must be pre-allocated
		Dim cchTextMax As Integer
		Dim iItem As Integer
		Dim iSubItem As Integer
		Dim lParam As Integer
	End Structure
	
	' // NMLVGETINFOTIPA.dwFlag values ("A" ?)
	Public Const LVGIT_UNFOLDED As Short = &H1s
	
	
	
	
	
	
	Public Const WM_NOTIFY As Integer = &H4Es
	'
	' Custom Draw Messages
	'
	Public Const CDDS_PREPAINT As Integer = &H1s
	Public Const CDDS_POSTPAINT As Integer = &H2s
	Public Const CDDS_PREERASE As Integer = &H3s
	Public Const CDDS_POSTERASE As Integer = &H4s
	Public Const CDDS_ITEM As Integer = &H10000
	Public Const CDDS_ITEMPREPAINT As Integer = CDDS_ITEM Or CDDS_PREPAINT
	Public Const CDDS_ITEMPOSTPAINT As Integer = CDDS_ITEM Or CDDS_POSTPAINT
	Public Const CDDS_ITEMPREERASE As Integer = CDDS_ITEM Or CDDS_PREERASE
	Public Const CDDS_ITEMPOSTERASE As Integer = CDDS_ITEM Or CDDS_POSTERASE
	Public Const CDDS_SUBITEM As Integer = &H20000
	
	Public Const CDRF_DODEFAULT As Integer = &H0s
	Public Const CDRF_NEWFONT As Integer = &H2s
	Public Const CDRF_SKIPDEFAULT As Integer = &H4s
	Public Const CDRF_NOTIFYPOSTPAINT As Integer = &H10s
	Public Const CDRF_NOTIFYITEMDRAW As Integer = &H20s
	Public Const CDRF_NOTIFYSUBITEMDRAW As Short = &H20s ' flags are the same, we can distinguish by context
	Public Const CDRF_NOTIFYPOSTERASE As Integer = &H40s
	Public Const CDRF_NOTIFYITEMERASE As Integer = &H80s
	
	Public Enum WinNotifications
		NM_FIRST = -0 ' (0U- 0U) ' // generic to all controls
		NM_LAST = -99 ' (0U- 99U)
		NM_OUTOFMEMORY = (WinNotifications.NM_FIRST - 1)
		NM_CLICK = (WinNotifications.NM_FIRST - 2)
		NM_DBLCLK = (WinNotifications.NM_FIRST - 3)
		NM_RETURN = (WinNotifications.NM_FIRST - 4)
		NM_RCLICK = (WinNotifications.NM_FIRST - 5)
		NM_RDBLCLK = (WinNotifications.NM_FIRST - 6)
		NM_SETFOCUS = (WinNotifications.NM_FIRST - 7)
		NM_KILLFOCUS = (WinNotifications.NM_FIRST - 8)
		NM_CUSTOMDRAW = (WinNotifications.NM_FIRST - 12)
		NM_HOVER = (WinNotifications.NM_FIRST - 13)
	End Enum
End Module