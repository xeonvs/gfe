Option Strict Off
Option Explicit On
Friend Class frmDecodeUUE
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
	Public WithEvents Subclass1 As AxSubclassCtl.AxSubclass
	Public WithEvents lstFoundedFiles As AxMSComctlLib.AxListView
	Public WithEvents cmdScan As System.Windows.Forms.Button
	Public WithEvents prgFind As AxMSComctlLib.AxProgressBar
	Public WithEvents stbProgress As AxMSComctlLib.AxStatusBar
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdDecode As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDecodeUUE))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.Subclass1 = New AxSubclassCtl.AxSubclass
		Me.lstFoundedFiles = New AxMSComctlLib.AxListView
		Me.cmdScan = New System.Windows.Forms.Button
		Me.prgFind = New AxMSComctlLib.AxProgressBar
		Me.stbProgress = New AxMSComctlLib.AxStatusBar
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cmdDecode = New System.Windows.Forms.Button
		CType(Me.Subclass1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lstFoundedFiles, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.prgFind, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.stbProgress, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Выберете файл для Декодирования"
		Me.ClientSize = New System.Drawing.Size(351, 292)
		Me.Location = New System.Drawing.Point(3, 29)
		Me.Icon = CType(resources.GetObject("frmDecodeUUE.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmDecodeUUE"
		Subclass1.OcxState = CType(resources.GetObject("Subclass1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Subclass1.Location = New System.Drawing.Point(150, 180)
		Me.Subclass1.Name = "Subclass1"
		lstFoundedFiles.OcxState = CType(resources.GetObject("lstFoundedFiles.OcxState"), System.Windows.Forms.AxHost.State)
		Me.lstFoundedFiles.Size = New System.Drawing.Size(341, 220)
		Me.lstFoundedFiles.Location = New System.Drawing.Point(5, 5)
		Me.lstFoundedFiles.TabIndex = 5
		Me.lstFoundedFiles.Name = "lstFoundedFiles"
		Me.cmdScan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdScan.Text = "&Scan"
		Me.cmdScan.Size = New System.Drawing.Size(66, 26)
		Me.cmdScan.Location = New System.Drawing.Point(25, 230)
		Me.cmdScan.TabIndex = 4
		Me.cmdScan.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdScan.BackColor = System.Drawing.SystemColors.Control
		Me.cmdScan.CausesValidation = True
		Me.cmdScan.Enabled = True
		Me.cmdScan.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdScan.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdScan.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdScan.TabStop = True
		Me.cmdScan.Name = "cmdScan"
		prgFind.OcxState = CType(resources.GetObject("prgFind.OcxState"), System.Windows.Forms.AxHost.State)
		Me.prgFind.Size = New System.Drawing.Size(266, 21)
		Me.prgFind.Location = New System.Drawing.Point(0, 269)
		Me.prgFind.TabIndex = 3
		Me.prgFind.Name = "prgFind"
		stbProgress.OcxState = CType(resources.GetObject("stbProgress.OcxState"), System.Windows.Forms.AxHost.State)
		Me.stbProgress.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.stbProgress.Size = New System.Drawing.Size(351, 26)
		Me.stbProgress.Location = New System.Drawing.Point(0, 266)
		Me.stbProgress.TabIndex = 2
		Me.stbProgress.Name = "stbProgress"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "&Отмена"
		Me.cmdCancel.Size = New System.Drawing.Size(71, 26)
		Me.cmdCancel.Location = New System.Drawing.Point(250, 230)
		Me.cmdCancel.TabIndex = 1
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdDecode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdDecode.Text = "&Decode"
		Me.cmdDecode.Size = New System.Drawing.Size(71, 26)
		Me.cmdDecode.Location = New System.Drawing.Point(145, 230)
		Me.cmdDecode.TabIndex = 0
		Me.cmdDecode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDecode.BackColor = System.Drawing.SystemColors.Control
		Me.cmdDecode.CausesValidation = True
		Me.cmdDecode.Enabled = True
		Me.cmdDecode.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdDecode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDecode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdDecode.TabStop = True
		Me.cmdDecode.Name = "cmdDecode"
		Me.Controls.Add(Subclass1)
		Me.Controls.Add(lstFoundedFiles)
		Me.Controls.Add(cmdScan)
		Me.Controls.Add(prgFind)
		Me.Controls.Add(stbProgress)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdDecode)
		CType(Me.stbProgress, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.prgFind, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lstFoundedFiles, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Subclass1, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmDecodeUUE
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmDecodeUUE
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmDecodeUUE()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	
	Private brush As Integer
	Private bChkBack As Integer
	Private bChkFront As Integer
	
	Dim db As Object
	
	'получает родительскую форму
	Public WriteOnly Property base() As Object
		Set(ByVal Value As Object)
			db = Value
		End Set
	End Property
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	Private Sub cmdDecode_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDecode.Click
		On Error GoTo errHandler
		Dim i As Integer
		Dim stCount As Integer
		
		stCount = lstFoundedFiles.ListItems.Count
		
		For i = 0 To lstFoundedFiles.ListItems.Count
			If States(i) Then
				modUUCode.SaveFile(i - 1, db)
			End If
		Next i
		
		Exit Sub
		
errHandler: 
		Select Case Err.Number
			Case Else
				ErrorMessage(Err.Number, Err.Description, "frmDecodeUUE::cmdDecode_Click")
		End Select
	End Sub
	
	Private Sub cmdScan_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdScan.Click
		modUUCode.FindUUE(db)
		
		lstFoundedFiles.CtlRefresh()
		System.Windows.Forms.Application.DoEvents()
		lstFoundedFiles.CtlRefresh()
		
	End Sub
	
	Private Sub frmDecodeUUE_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim bb As LOGBRUSH
		
		prgFind.Height = stbProgress.Height - 4
		
		bb.lbColor = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)
		brush = CreateBrushIndirect(bb)
		bb.lbColor = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
		bChkBack = CreateBrushIndirect(bb)
		bb.lbColor = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White)
		bChkFront = CreateBrushIndirect(bb)
		
		'добавляем все вручную, т.к. так корректнее обработка
		lstFoundedFiles.ColumnHeaders.Add( ,  , "")
		lstFoundedFiles.ColumnHeaders.item(1).Width = 16
		lstFoundedFiles.ColumnHeaders.Add( ,  , "Имя Файла")
		lstFoundedFiles.ColumnHeaders.item(2).Width = 190
		lstFoundedFiles.ColumnHeaders.Add( ,  , "Получено в %")
		lstFoundedFiles.ColumnHeaders.item(3).Width = 130
		
		cmdDecode.Enabled = False
		
		With Subclass1
			.set_hWnd(Me.Handle.ToInt32)
			.set_Messages(WM_NOTIFY, True)
		End With
		
		System.Windows.Forms.Application.DoEvents()
		
	End Sub
	
	'UPGRADE_WARNING: Form event frmDecodeUUE.Unload has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
	Private Sub frmDecodeUUE_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
		'UPGRADE_NOTE: Object db may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		db = Nothing
	End Sub
	
	Private Sub lstFoundedFiles_ItemClick(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComctlLib.ListViewEvents_ItemClickEvent) Handles lstFoundedFiles.ItemClick
		
		If eventArgs.item.SubItems(2) = "100%" Then
			States(eventArgs.item.Index) = Not (States(eventArgs.item.Index))
			ListView_Update((lstFoundedFiles.hWnd), (eventArgs.item.Index))
			lstFoundedFiles.CtlRefresh()
		End If
		
	End Sub
	
	Private Sub Subclass1_WndProcEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxSubclassCtl.__Subclass_WndProcEvent) Handles Subclass1.WndProcEvent
		Dim tMessage As NMHDR
		Dim lCode As Integer
		Dim tLVRedrawMessage As NMLVCUSTOMDRAW
		Dim rcbb, rc, rcchk As RECT
		Dim txt As String
		Dim cval As Single
		
		Select Case eventArgs.msg
			
			Case WM_NOTIFY
				
				'UPGRADE_WARNING: Couldn't resolve default property of object tMessage. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
				MoveMemory(tMessage, eventArgs.lParam, Len(tMessage))
				lCode = tMessage.code
				
				Select Case lCode
					Case mListviewDefs.WinNotifications.NM_CUSTOMDRAW
						
						If tMessage.hwndFrom <> lstFoundedFiles.hWnd Then
							eventArgs.Result = Subclass1.CallWndProc(eventArgs.msg, eventArgs.wParam, eventArgs.lParam)
							Exit Sub
						End If
						
						'UPGRADE_WARNING: Couldn't resolve default property of object tLVRedrawMessage. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
						MoveMemory(tLVRedrawMessage, eventArgs.lParam, Len(tLVRedrawMessage))
						
						Select Case tLVRedrawMessage.nmcmd.dwDrawStage
							
							Case CDDS_PREPAINT
								eventArgs.Result = CDRF_NOTIFYITEMDRAW
								Exit Sub
								
							Case (CDDS_ITEMPREPAINT)
								
								With tLVRedrawMessage
									
									ListView_GetSubItemRect(.nmcmd.hdr.hwndFrom, .nmcmd.dwItemSpec - 1, 2, mListviewDefs.LVIR_Flags.LVIR_BOUNDS, rc)
									
									'структуру обязательно надо локально скопировать если хотим менять ее размеры
									'UPGRADE_WARNING: Couldn't resolve default property of object rc. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
									'UPGRADE_WARNING: Couldn't resolve default property of object rcbb. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
									MoveMemory(rcbb, rc, Len(rc))
									
									'Счаззз будым рисовать чекбоксъ
									ListView_GetSubItemRect(.nmcmd.hdr.hwndFrom, .nmcmd.dwItemSpec - 1, 0, mListviewDefs.LVIR_Flags.LVIR_BOUNDS, rcchk)
									DrawChk(.nmcmd.hdc, rcchk, States(.nmcmd.dwItemSpec))
									
									'теперь напишем текст
									'сначала в 2ом сабитеме
									txt = Space(60)
									'UPGRADE_ISSUE: StrPtr function is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1040"'
									ListView_GetItemText(.nmcmd.hdr.hwndFrom, .nmcmd.dwItemSpec - 1, 2, StrPtr(txt), 60)
									'UPGRADE_ISSUE: Constant vbUnicode was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
									txt = Trim(Replace(StrConv(txt, vbUnicode), Chr(0), ""))
									
									If Len(txt) = 0 Then
										cval = 0
									Else
										cval = (100 - Val(Replace(Replace(txt, ",", "."), "%", ""))) * 0.01
									End If
									
									'нарисуем прямоугольник прогреса
									rcbb.Right_Renamed = rcbb.Right_Renamed - CShort(cval * (rcbb.Right_Renamed - rcbb.Left_Renamed))
									FillRect(.nmcmd.hdc, rcbb, brush)
									
									'теперь напишем текст
									rc.Left_Renamed = rc.Left_Renamed + 2 'поправка
									DrawText(.nmcmd.hdc, txt, Len(txt), rc, DT_CENTER Or DT_VCENTER)
									
									'теперь в 1ом сабытеме
									txt = Space(60)
									ListView_GetSubItemRect(.nmcmd.hdr.hwndFrom, .nmcmd.dwItemSpec - 1, 1, mListviewDefs.LVIR_Flags.LVIR_BOUNDS, rc)
									'UPGRADE_ISSUE: StrPtr function is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1040"'
									ListView_GetItemText(.nmcmd.hdr.hwndFrom, .nmcmd.dwItemSpec - 1, 1, StrPtr(txt), 60)
									'UPGRADE_ISSUE: Constant vbUnicode was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2070"'
									txt = Trim(Replace(StrConv(txt, vbUnicode), Chr(0), ""))
									
									rc.Left_Renamed = rc.Left_Renamed + 2 'поправка
									DrawText(.nmcmd.hdc, txt, Len(txt), rc, DT_LEFT Or DT_VCENTER)
									
									'и устанавливаем цвет текста
									SetTextColor(.nmcmd.hdc, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red))
									
									'сохраняем все изменения
									'UPGRADE_WARNING: Couldn't resolve default property of object tLVRedrawMessage. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
									MoveMemory(eventArgs.lParam, tLVRedrawMessage, Len(tLVRedrawMessage))
									eventArgs.Result = CDRF_SKIPDEFAULT
									
								End With
								
								Exit Sub
								
						End Select
					Case Else
						eventArgs.Result = Subclass1.CallWndProc(eventArgs.msg, eventArgs.wParam, eventArgs.lParam)
						Exit Sub
				End Select
		End Select
	End Sub
	
	'state=false - unckecked, state=true checked
	Private Sub DrawChk(ByRef hdc As Integer, ByRef rc As RECT, ByRef state As Boolean)
		Dim rcbb As RECT
		
		'UPGRADE_WARNING: Couldn't resolve default property of object rc. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_WARNING: Couldn't resolve default property of object rcbb. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		MoveMemory(rcbb, rc, Len(rc))
		
		With rcbb
			.Top = .Top + 1
			.Right_Renamed = .Left_Renamed + 14
			
			'рисуем фон
			FillRect(hdc, rcbb, bChkBack)
			
			'тепрь внутренний прямоугольник
			.Left_Renamed = .Left_Renamed + 2
			.Right_Renamed = .Right_Renamed - 2
			.Top = .Top + 2
			.Bottom = .Bottom - 2
			
			FillRect(hdc, rcbb, bChkFront)
			
			'ну и нарисуем галку если оно надо
			If state Then
				MoveToEx(hdc, .Left_Renamed + 1, .Top + 4, 0)
				LineTo(hdc, rcbb.Left_Renamed + 3.5, rcbb.Bottom - 2)
				LineTo(hdc, rcbb.Left_Renamed + 9, rcbb.Top)
				Sleep(1)
			Else
				System.Windows.Forms.Application.DoEvents()
			End If
			
		End With
		
	End Sub
End Class