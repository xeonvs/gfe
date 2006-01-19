Option Strict Off
Option Explicit On
Module modCommonDialog
	
	Public Const cdlOFNReadOnly As Integer = 1
	Public Const cdlOFNHideReadOnly As Integer = 4
	Public Const cdlCFBoth As Integer = 3
	Private Const MAX_PATH As Integer = 260
	Private Const SHGFI_DISPLAYNAME As Integer = &H200s
	Private Const SHGFI_EXETYPE As Integer = &H2000s
	Private Const SHGFI_SYSICONINDEX As Integer = &H4000s 'system icon index
	Private Const SHGFI_LARGEICON As Integer = &H0s 'large icon
	Private Const SHGFI_SMALLICON As Integer = &H1s 'small icon
	Private Const SHGFI_SHELLICONSIZE As Integer = &H4s
	Private Const SHGFI_TYPENAME As Integer = &H400s
	Private Const BASIC_SHGFI_FLAGS As Integer = SHGFI_TYPENAME Or SHGFI_SHELLICONSIZE Or SHGFI_DISPLAYNAME Or SHGFI_EXETYPE
	Private Const BOLD_FONTTYPE As Integer = &H100s
	Private Const CF_ENABLETEMPLATE As Integer = &H10
	Private Const CF_ENABLEHOOK As Integer = &H8
	Private Const CF_APPLY As Integer = &H200
	Private Const CF_SCREENFONTS As Integer = &H1s
	Private Const CF_INITTOLOGFONTSTRUCT As Integer = &H40
	Private Const CF_EFFECTS As Integer = &H100
	Private Const CF_PALETTE As Integer = 9
	Private Const LF_FACESIZE As Integer = 32
	Private Const LF_FULLFACESIZE As Integer = 64
	Private Const CC_RGBINIT As Integer = &H1s
	
	Private Structure LOGFONT
		Dim lfHeight As Integer
		Dim lfWidth As Integer
		Dim lfEscapement As Integer
		Dim lfOrientation As Integer
		Dim lfWeight As Integer
		Dim lfItalic As Byte
		Dim lfUnderline As Byte
		Dim lfStrikeOut As Byte
		Dim lfCharSet As Byte
		Dim lfOutPrecision As Byte
		Dim lfClipPrecision As Byte
		Dim lfQuality As Byte
		Dim lfPitchAndFamily As Byte
		<VBFixedArray(LF_FACESIZE)> Dim lfFaceName() As Byte
		
		'UPGRADE_TODO: "Initialize" must be called to initialize instances of this structure. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1026"'
		Public Sub Initialize()
			ReDim lfFaceName(LF_FACESIZE)
		End Sub
	End Structure
	
	Private Structure ChooseColor
		Dim lStructSize As Integer
		Dim hwndOwner As Integer
		Dim hInstance As Integer
		Dim rgbResult As Integer
		Dim lpCustColors As String
		Dim Flags As Integer
		Dim lCustData As Integer
		Dim lpfnHook As Integer
		Dim lpTemplateName As String
	End Structure
	
	Private Structure ChooseFont
		Dim lStructSize As Integer
		Dim hwndOwner As Integer
		Dim hdc As Integer
		Dim lpLogFont As Integer
		Dim iPointSize As Integer
		Dim Flags As Integer
		Dim rgbColors As Integer
		Dim lCustData As Integer
		Dim lpfnHook As Integer
		Dim lpTemplateName As String
		Dim hInstance As Integer
		Dim lpszStyle As String
		Dim nFontType As Short
		Dim MISSING_ALIGNMENT As Short
		Dim nSizeMin As Integer
		Dim nSizeMax As Integer
	End Structure
	
	Private Structure BrowseInfo
		Dim hwndOwner As Integer
		Dim pIDLRoot As Integer
		Dim pszDisplayName As Integer
		Dim lpszTitle As Integer
		Dim ulFlags As Integer
		Dim lpfnCallback As Integer
		Dim lParam As Integer
		Dim iImage As Integer
	End Structure
	
	Private Structure OPENFILENAME
		Dim lStructSize As Integer
		Dim hwndOwner As Integer
		Dim hInstance As Integer
		Dim lpstrFilter As String
		Dim lpstrCustomFilter As String
		Dim nMaxCustFilter As Integer
		Dim nFilterIndex As Integer
		Dim lpstrFile As String
		Dim nMaxFile As Integer
		Dim lpstrFileTitle As String
		Dim nMaxFileTitle As Integer
		Dim lpstrInitialDir As String
		Dim lpstrTitle As String
		Dim Flags As Integer
		Dim nFileOffset As Short
		Dim nFileExtension As Short
		Dim lpstrDefExt As String
		Dim lCustData As Integer
		Dim lpfnHook As Integer
		Dim lpTemplateName As String
	End Structure
	
	Private Structure SHFILEINFO
		Dim hIcon As Integer
		Dim iIcon As Integer
		Dim dwAttributes As Integer
		<VBFixedString(260),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=260)> Public szDisplayName As String
		<VBFixedString(80),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=80)> Public szTypeName As String
	End Structure
	
	'UPGRADE_WARNING: Structure ChooseColor may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function ChooseColor_Renamed Lib "comdlg32.dll"  Alias "ChooseColorA"(ByRef pChoosecolor As ChooseColor) As Integer
	
	'UPGRADE_WARNING: Structure ChooseFont may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function ChooseFont_Renamed Lib "comdlg32.dll"  Alias "ChooseFontA"(ByRef pChoosefont As ChooseFont) As Integer
	
	'UPGRADE_WARNING: Structure SHFILEINFO may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function SHGetFileInfo Lib "shell32.dll"  Alias "SHGetFileInfoA"(ByVal pszPath As String, ByVal dwFileAttributes As Integer, ByRef psfi As SHFILEINFO, ByVal cbSizeFileInfo As Integer, ByVal uFlags As Integer) As Integer
	
	'UPGRADE_WARNING: Structure OPENFILENAME may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function GetSaveFileName Lib "comdlg32.dll"  Alias "GetSaveFileNameA"(ByRef pOpenfilename As OPENFILENAME) As Integer
	
	'UPGRADE_WARNING: Structure OPENFILENAME may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function GetOpenFileName Lib "comdlg32.dll"  Alias "GetOpenFileNameA"(ByRef pOpenfilename As OPENFILENAME) As Integer
	
	Private Declare Function CommDlgExtendedError Lib "comdlg32.dll" () As Integer
	
	Private Declare Function lstrcat Lib "kernel32"  Alias "lstrcatA"(ByVal lpString1 As String, ByVal lpString2 As String) As Integer
	
	'UPGRADE_WARNING: Structure BrowseInfo may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function SHBrowseForFolder Lib "shell32" (ByRef lpbi As BrowseInfo) As Integer
	
	Private Declare Function SHGetPathFromIDList Lib "shell32" (ByVal pidList As Integer, ByVal lpBuffer As String) As Integer
	
	Private Declare Sub CoTaskMemFree Lib "ole32.dll" (ByVal hMem As Integer)
	
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Private Declare Sub CopyMem Lib "kernel32"  Alias "RtlMoveMemory"(ByRef lpvDest As Any, ByVal lpvSource As String, ByVal cbCopy As Integer)
	
	Private shinfo As SHFILEINFO
	Public hwndOwner As Integer
	'UPGRADE_NOTE: Filter was upgraded to Filter_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
	Public Filter_Renamed As String
	Public FilterIndex As Integer
	Public OpenDialogTitle As String
	Public Flags As Integer
	Public SaveDialogTitle As String
	Public FolderDialogTitle As String
	Public ShowDirsOnly As Boolean
	
	Function ShowFont(ByRef fntDefault As System.Drawing.Font, ByRef nColor As Integer) As System.Drawing.Font
		'UPGRADE_WARNING: Arrays in structure lg may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1063"'
		Dim lFlags As Integer
		Dim lg As LOGFONT
		Dim cf As ChooseFont
		
		ShowFont = System.Windows.Forms.Control.DefaultFont.Clone()
		lFlags = lFlags Or CF_SCREENFONTS
		lFlags = (lFlags Or CF_INITTOLOGFONTSTRUCT) And Not (CF_APPLY Or CF_ENABLEHOOK Or CF_ENABLETEMPLATE)
		lFlags = lFlags Or CF_EFFECTS
		lg.lfHeight = -(fntDefault.SizeInPoints * ((1440 / 72) / VB6.TwipsPerPixelY))
		'UPGRADE_ISSUE: Font property fntDefault.Weight was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
		lg.lfWeight = fntDefault.Weight
		lg.lfItalic = fntDefault.Italic
		lg.lfUnderline = fntDefault.Underline
		lg.lfStrikeOut = fntDefault.StrikeOut
		StrToBytes(lg.lfFaceName, (fntDefault.Name))
		
		cf.hInstance = VB6.GetHInstance.ToInt32
		cf.hwndOwner = hwndOwner
		'UPGRADE_ISSUE: VarPtr function is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1040"'
		cf.lpLogFont = VarPtr(lg)
		cf.iPointSize = fntDefault.SizeInPoints * 10
		cf.Flags = lFlags
		cf.rgbColors = nColor
		cf.lStructSize = Len(cf)
		
		If ChooseFont_Renamed(cf) Then
			lFlags = cf.Flags
			ShowFont = VB6.FontChangeBold(ShowFont, cf.nFontType And BOLD_FONTTYPE)
			ShowFont = VB6.FontChangeItalic(ShowFont, lg.lfItalic)
			ShowFont = VB6.FontChangeStrikeOut(ShowFont, lg.lfStrikeOut)
			ShowFont = VB6.FontChangeUnderline(ShowFont, lg.lfUnderline)
			'UPGRADE_ISSUE: Font property ShowFont.Weight was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2064"'
			ShowFont.Weight = lg.lfWeight
			ShowFont = VB6.FontChangeSize(ShowFont, cf.iPointSize / 10)
			ShowFont = VB6.FontChangeName(ShowFont, BytesToStr(lg.lfFaceName))
			nColor = cf.rgbColors
		Else
			'UPGRADE_NOTE: Object ShowFont may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
			ShowFont = Nothing
		End If
		
	End Function
	
	Function ShowColor(Optional ByRef InitColor As Integer = 0) As Integer
		Dim cd As ChooseColor
		
		'UPGRADE_ISSUE: LenB function is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1040"'
		cd.lStructSize = LenB(cd)
		cd.hwndOwner = hwndOwner
		cd.hInstance = VB6.GetHInstance.ToInt32
		cd.lpCustColors = New String(Chr(0), 8 * 16)
		cd.Flags = CC_RGBINIT
		cd.rgbResult = InitColor
		If ChooseColor_Renamed(cd) Then
			ShowColor = cd.rgbResult
		Else
			ShowColor = -1
		End If
		
	End Function
	
	Function ShowFolder(Optional ByRef InitDir As String = vbNullString) As String
		Dim lRes As Integer
		Dim sTemp As String
		Dim iPos As Short
		Dim bi As BrowseInfo
		
		With bi
			.hwndOwner = hwndOwner
			.lpszTitle = lstrcat(FolderDialogTitle, "")
			.ulFlags = System.Math.Abs(CInt(ShowDirsOnly))
		End With
		lRes = SHBrowseForFolder(bi)
		If lRes Then
			sTemp = New String(vbNullChar, MAX_PATH)
			SHGetPathFromIDList(lRes, sTemp)
			CoTaskMemFree(lRes)
			iPos = InStr(sTemp, vbNullChar)
			If iPos Then sTemp = Left(sTemp, iPos - 1)
		End If
		ShowFolder = sTemp
		
	End Function
	
	Function ShowOpen(Optional ByRef InitDir As String = vbNullString, Optional ByVal InitFile As String = vbNullString) As String
		Dim OFN As OPENFILENAME
		Dim sFilter As String
		Dim nRes As Integer
		
		sFilter = ConvertFilter(Filter_Renamed)
		OFN.hInstance = VB6.GetHInstance.ToInt32
		OFN.hwndOwner = hwndOwner
		
		If InitFile <> vbNullString Then
			OFN.lpstrFile = InitFile & New String(vbNullChar, MAX_PATH - Len(InitFile))
		Else
			OFN.lpstrFile = New String(vbNullChar, MAX_PATH)
		End If
		
		OFN.lpstrTitle = OpenDialogTitle & Chr(0)
		OFN.lpstrFilter = sFilter
		OFN.nFilterIndex = FilterIndex
		OFN.Flags = Flags
		OFN.lpstrInitialDir = CleanPath(InitDir) & Chr(0)
		OFN.nMaxFile = MAX_PATH
		'UPGRADE_ISSUE: LenB function is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1040"'
		OFN.lStructSize = LenB(OFN)
		
		nRes = GetOpenFileName(OFN)
		If nRes Then
			ShowOpen = Replace(Trim(OFN.lpstrFile), Chr(0), "")
		Else
			ShowOpen = ""
		End If
		
	End Function
	
	Function ShowSave(Optional ByVal InitDir As String = vbNullString, Optional ByVal InitFile As String = vbNullString) As String
		Dim OFN As OPENFILENAME
		Dim sFilter As String
		Dim nRes As Integer
		sFilter = ConvertFilter(Filter_Renamed)
		OFN.hInstance = VB6.GetHInstance.ToInt32
		OFN.hwndOwner = hwndOwner
		
		If InitFile <> vbNullString Then
			OFN.lpstrFile = InitFile & New String(vbNullChar, MAX_PATH - Len(InitFile))
		Else
			OFN.lpstrFile = New String(vbNullChar, MAX_PATH)
		End If
		
		OFN.lpstrFilter = sFilter
		OFN.Flags = Flags
		OFN.nFilterIndex = FilterIndex
		OFN.lpstrTitle = SaveDialogTitle & Chr(0)
		OFN.lpstrInitialDir = CleanPath(InitDir) & Chr(0)
		OFN.nMaxFile = MAX_PATH
		'UPGRADE_ISSUE: LenB function is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1040"'
		OFN.lStructSize = LenB(OFN)
		
		nRes = GetSaveFileName(OFN)
		If nRes Then
			ShowSave = Replace(Trim(OFN.lpstrFile), Chr(0), "") & GetFilterExtByIndex()
		Else
			ShowSave = ""
		End If
	End Function
	
	'Misc Functions
	Private Sub StrToBytes(ByRef ab() As Byte, ByRef s As String)
		Dim cab As Integer
		If GetCount(ab) < 0 Then
			'UPGRADE_ISSUE: Constant vbFromUnicode was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
			'UPGRADE_TODO: Code was upgraded to use System.Text.UnicodeEncoding.Unicode.GetBytes() which may not have the same behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1059"'
			ab = System.Text.UnicodeEncoding.Unicode.GetBytes(StrConv(s, vbFromUnicode))
		Else
			cab = UBound(ab) - LBound(ab) + 1
			If Len(s) < cab Then s = s & New String(Chr(0), cab - Len(s))
			CopyMem(ab(LBound(ab)), s, cab)
		End If
	End Sub
	
	Private Function BytesToStr(ByRef ab() As Byte) As String
		'UPGRADE_ISSUE: Constant vbUnicode was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
		BytesToStr = StrConv(System.Text.UnicodeEncoding.Unicode.GetString(ab), vbUnicode)
	End Function
	
	Private Function GetCount(ByRef arr As Object) As Short
		On Error Resume Next
		Dim nCount As Short
		nCount = UBound(arr)
		If Err.Number Then
			Err.Clear()
			GetCount = -1
		Else
			GetCount = nCount
		End If
	End Function
	
	Private Function ConvertFilter(ByVal sFilter As Object) As String
		Dim sTemp As String
		Dim i As Short
		'UPGRADE_WARNING: Couldn't resolve default property of object sFilter. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		sTemp = sFilter
		For i = 1 To Len(sTemp)
			If Mid(sTemp, i, 1) = "|" Then Mid(sTemp, i, 1) = vbNullChar
		Next i
		ConvertFilter = sTemp
	End Function
	
	Public Function GetFileTitle(ByVal FileName As String) As String
		Dim shinfo As SHFILEINFO
		Dim sTemp As String
		'UPGRADE_ISSUE: LenB function is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1040"'
		SHGetFileInfo(FileName, 0, shinfo, LenB(shinfo), &H200s)
		sTemp = shinfo.szDisplayName
		If InStr(sTemp, vbNullChar) Then sTemp = Left(sTemp, InStr(sTemp, vbNullChar) - 1)
		GetFileTitle = sTemp
	End Function
	
	Public Function GetFileIcon(ByVal FileName As String) As Integer
		Dim shinfo As SHFILEINFO
		Dim hIcon As String
		'UPGRADE_ISSUE: LenB function is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1040"'
		hIcon = CStr(SHGetFileInfo(FileName, 0, shinfo, LenB(shinfo), SHGFI_SMALLICON))
		GetFileIcon = CInt(hIcon)
	End Function
	
	Private Function CleanPath(ByVal fPath As String) As String
		Dim i As Integer
		
		i = Len(fPath)
		If i = 0 Then
			CleanPath = ""
			Exit Function
		End If
		
		While Mid(fPath, i, 1) <> "\"
			i = i - 1
		End While
		CleanPath = Mid(fPath, 1, i)
	End Function
	
	Private Function GetFilterExtByIndex() As String
		Dim ffls() As String
		Dim i As Integer
		
		ffls = Split(Filter_Renamed, "|")
		If FilterIndex > 1 Then
			GetFilterExtByIndex = Replace(ffls(FilterIndex + 1), "*", "")
		End If
	End Function
End Module