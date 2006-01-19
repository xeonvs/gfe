Option Strict Off
Option Explicit On
Module modSystemInfo
	
	
	'=============================================================================================================
	'
	' modCPUInfo Module
	' -----------------
	'
	' Description : This module is meant to give you easy access to the vitals of the computer and operating
	'               system (OS) that the program is running on.  This module gives you easy access to the following
	'               things:
	'                 - The Type of OS          (Win95, WinNT, etc)
	'                 - The OS Version          (3.51, 4.0, etc)
	'                 - The OS Build            (1381, etc)
	'                 - The OS ServicePack      (Win95B, WinNT SP6, etc)
	'                 - The # of CPUs installed (1, 2, etc)
	'                 - The Type of CPU         (386, 486, Pentium, etc)
	'                 - The CPU Speed           (350 MHz, etc)  -  Not always available
	'                 - The Installed RAM       (16MB, etc)
	'
	' Example Use :
	'
	'  If GetSysInfo = False Then
	'    Exit Sub
	'  End If
	'
	'  MsgBox "Your computer information :" & Chr(13) & Chr(13) & _
	''         "The Type of OS = Windows " & OS_Type & Chr(13) & _
	''         "The OS Version = " & OS_Version & Chr(13) & _
	''         "The OS Build = " & OS_Build & Chr(13) & _
	''         "The OS ServicePack = " & OS_ServicePack & Chr(13) & _
	''         "The # of CPUs installed = " & CPU_Count & Chr(13) & _
	''         "The Type of CPU = " & CPU_Type & Chr(13) & _
	''         "The CPU Speed = " & CPU_Speed & Chr(13) & _
	''         "The Installed RAM = " & CPU_RAM
	'
	'=============================================================================================================
	
	' Type for getting OS information
	Private Structure OSVERSIONINFO
		Dim dwOSVersionInfoSize As Integer ' Specifies the size, in bytes, of this data structure. Set this member to sizeof(OSVERSIONINFO) before calling the GetVersionEx function.
		Dim dwMajorVersion As Integer ' Identifies the major version number of the operating system. For example, for Windows NT version 3.51, the major version number is 3; and for Windows NT version 4.0, the major version number is 4.
		Dim dwMinorVersion As Integer ' Identifies the minor version number of the operating system. For example, for Windows NT version 3.51, the minor version number is 51; and for Windows NT version 4.0, the minor version number is 0.
		Dim dwBuildNumber As Integer ' Windows 95 : Identifies the build number of the operating system in the low-order word. The high-order word contains the major and minor version numbers.
		' Windows NT : Identifies the build number of the operating system.
		Dim dwPlatformId As Integer ' Identifies the operating system platform. (See Constants)
		<VBFixedString(128),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr,SizeConst:=128)> Public szCSDVersion As String ' Windows 95 : Contains a null-terminated string that provides arbitrary additional information about the operating system.
		' Windows NT : Contains a null-terminated string, such as "Service Pack 3", that indicates the latest Service Pack installed on the system. If no Service Pack has been installed, the string is empty.
	End Structure
	
	' Type for getting CPU information
	Private Structure SYSTEM_INFO
		Dim dwOemID As Integer ' An obsolete member that is retained for compatibility with previous versions of Windows NT. Beginning with Windows NT 3.51 and the initial release of Windows 95, use the wProcessorArchitecture branch of the union.
		' Windows 95: The system always sets this member to zero, the value defined for PROCESSOR_ARCHITECTURE_INTEL.
		Dim dwPageSize As Integer ' Specifies the system’s processor architecture (See Constants)
		Dim lpMinimumApplicationAddress As Integer ' Pointer to the lowest memory address accessible to applications and dynamic-link libraries (DLLs).
		Dim lpMaximumApplicationAddress As Integer ' Pointer to the highest memory address accessible to applications and DLLs.
		Dim dwActiveProcessorMask As Integer ' Specifies a mask representing the set of processors configured into the system. Bit 0 is processor 0; bit 31 is processor 31.
		Dim dwNumberOrfProcessors As Integer ' Specifies the number of processors in the system.
		Dim dwProcessorType As Integer ' Windows 95 : Specifies the type of processor in the system (See Constants)
		' Windows NT : This member is no longer relevant, but is retained for compatibility with Windows 95 and previous versions of Windows NT. Use the wProcessorArchitecture, wProcessorLevel, and wProcessorRevision members to determine the type of processor.
		Dim dwAllocationGranularity As Integer ' Specifies the granularity with which virtual memory is allocated. For example, a VirtualAlloc request to allocate 1 byte will reserve an address space of dwAllocationGranularity bytes. This value was hard coded as 64K in the past, but other hardware architectures may require different values.
		Dim dwReserved As Integer ' Reserved for future use.
	End Structure
	
	' Type for getting RAM / Memory information
	Private Structure MEMORYSTATUS
		Dim dwLength As Integer ' Indicates the size of the structure. The calling process should set this member prior to calling GlobalMemoryStatus.
		Dim dwMemoryLoad As Integer ' Specifies a number between 0 and 100 that gives a general idea of current memory utilization, in which 0 indicates no memory use and 100 indicates full memory use.
		Dim dwTotalPhys As Integer ' Indicates the total number of bytes of physical memory.
		Dim dwAvailPhys As Integer ' Indicates the number of bytes of physical memory available.
		Dim dwTotalPageFile As Integer ' Indicates the total number of bytes that can be stored in the paging file. Note that this number does not represent the actual physical size of the paging file on disk.
		Dim dwAvailPageFile As Integer ' Indicates the number of bytes available in the paging file.
		Dim dwTotalVirtual As Integer ' Indicates the total number of bytes that can be described in the user mode portion of the virtual address space of the calling process.
		Dim dwAvailVirtual As Integer ' Indicates the number of bytes of unreserved and uncommitted memory in the user mode portion of the virtual address space of the calling process.
	End Structure
	
	' OS Type Enumerations
	Public Enum OSTypes
		OS_Unknown = 0 ' "Unknown"
		OS_Win32 = 32 ' "Win 32"
		OS_Win95 = 95 ' "Windows 95"
		OS_Win98 = 98 ' "Windows 98"
		OS_WinNT_351 = 351 ' "Windows NT 3.51"
		OS_WinNT_40 = 40 ' "Windows NT 4.0"
		OS_Win2000 = 2000 ' "Windows 2000"
		OS_WinXP = 510 ' "Windows XP"
		OS_Win2003 = 2003 ' "Windows 2003"
	End Enum
	
	' Registry Key Enumerations
	Private Enum RegistryKeys
		HKEY_CLASSES_ROOT = &H80000000
		HKEY_CURRENT_CONFIG = &H80000005
		HKEY_CURRENT_USER = &H80000001
		HKEY_DYN_DATA = &H80000006
		HKEY_LOCAL_MACHINE = &H80000002
		HKEY_PERFORMANCE_DATA = &H80000004
		HKEY_USERS = &H80000003
	End Enum
	
	' General Constants
	Private Const ERROR_SUCCESS As Short = 0
	
	' SYSTEM_INFO.dwProcessorType Constants
	Private Const PROCESSOR_INTEL_386 As Integer = 386
	Private Const PROCESSOR_INTEL_486 As Integer = 486
	Private Const PROCESSOR_INTEL_PENTIUM As Integer = 586
	Private Const PROCESSOR_MIPS_R4000 As Integer = 4000 ' Windows NT / R4101 & R3910 for Windows CE
	Private Const PROCESSOR_ALPHA_21064 As Integer = 21064 ' Windows NT
	Private Const PROCESSOR_PPC_601 As Integer = 601 ' Windows NT
	Private Const PROCESSOR_PPC_603 As Integer = 603 ' Windows NT
	Private Const PROCESSOR_PPC_604 As Integer = 604 ' Windows NT
	Private Const PROCESSOR_PPC_620 As Integer = 620 ' Windows NT
	Private Const PROCESSOR_HITACHI_SH3 As Integer = 10003 ' Windows CE
	Private Const PROCESSOR_HITACHI_SH3E As Integer = 10004 ' Windows CE
	Private Const PROCESSOR_HITACHI_SH4 As Integer = 10005 ' Windows CE
	Private Const PROCESSOR_MOTOROLA_821 As Integer = 821 ' Windows CE
	Private Const PROCESSOR_SHx_SH3 As Integer = 103 ' Windows CE
	Private Const PROCESSOR_SHx_SH4 As Integer = 104 ' Windows CE
	Private Const PROCESSOR_STRONGARM As Integer = 2577 ' Windows CE - 0xA11
	Private Const PROCESSOR_ARM720 As Integer = 1824 ' Windows CE - 0x720
	Private Const PROCESSOR_ARM820 As Integer = 2080 ' Windows CE - 0x820
	Private Const PROCESSOR_ARM920 As Integer = 2336 ' Windows CE - 0x920
	Private Const PROCESSOR_ARM_7TDMI As Integer = 70001 ' Windows CE
	
	' OSVERSIONINFO.dwPlatformId Constants
	Private Const VER_PLATFORM_WIN32s As Integer = 0
	Private Const VER_PLATFORM_WIN32_WINDOWS As Integer = 1
	Private Const VER_PLATFORM_WIN32_NT As Integer = 2
	
	' RegQueryValueEx Constants
	Private Const REG_BINARY As Integer = 3 ' Binary data in any form.
	Private Const REG_DWORD As Integer = 4 ' A 32-bit number.
	Private Const REG_DWORD_LITTLE_ENDIAN As Integer = 4 ' A 32-bit number in little-endian format (same as REG_DWORD). In little-endian format, the most significant byte of a word is the high-order byte. This is the most common format for computers running Windows NT and Windows 95.
	Private Const REG_DWORD_BIG_ENDIAN As Integer = 5 ' A 32-bit number in big-endian format. In big-endian format, the most significant byte of a word is the low-order byte.
	Private Const REG_EXPAND_SZ As Integer = 2 ' A null-terminated string that contains unexpanded references to environment variables (for example, “%PATH%”). It will be a Unicode or ANSI string depending on whether you use the Unicode or ANSI functions.
	Private Const REG_LINK As Integer = 6 ' A Unicode symbolic link.
	Private Const REG_MULTI_SZ As Integer = 7 ' An array of null-terminated strings, terminated by two null characters.
	Private Const REG_NONE As Integer = 0 ' No defined value type.
	Private Const REG_RESOURCE_LIST As Integer = 8 ' A device-driver resource list.
	Private Const REG_SZ As Integer = 1 ' A null-terminated string. It will be a Unicode or ANSI string depending on whether you use the Unicode or ANSI functions.
	
	' Declare Variables
	Public OS_CodeName As String
	Public OS_Type As OSTypes
	Public OS_Version As String
	Public OS_Build As String
	Public OS_ServicePack As String
	Public CPU_Count As Integer
	Public CPU_Type As String
	Public CPU_Speed As String
	Public CPU_RAM As String
	
	' Windows API Declarations
	'UPGRADE_WARNING: Structure SYSTEM_INFO may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Sub GetSystemInfo Lib "kernel32" (ByRef lpSystemInfo As SYSTEM_INFO)
	'UPGRADE_WARNING: Structure MEMORYSTATUS may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Sub GlobalMemoryStatus Lib "kernel32" (ByRef lpBuffer As MEMORYSTATUS)
	'UPGRADE_WARNING: Structure OSVERSIONINFO may require marshalling attributes to be passed as an argument in this Declare statement. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
	Private Declare Function GetVersionEx Lib "kernel32"  Alias "GetVersionExA"(ByRef lpVersionInformation As OSVERSIONINFO) As Integer
	Private Declare Function RegCloseKey Lib "advapi32.dll" (ByVal hKey As Integer) As Integer
	Private Declare Function RegOpenKey Lib "advapi32.dll"  Alias "RegOpenKeyA"(ByVal hKey As Integer, ByVal lpSubKey As String, ByRef phkResult As Integer) As Integer
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1016"'
	Private Declare Function RegQueryValueEx Lib "advapi32.dll"  Alias "RegQueryValueExA"(ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByRef lpData As Any, ByRef lpcbData As Integer) As Integer
	
	' Function that gets all the information about the OS and the CPU and stores it in variables
	Public Function GetSysInfo() As Boolean
		On Error Resume Next
		
		Dim SysInfo As SYSTEM_INFO
		Dim Memory As MEMORYSTATUS
		Dim TempSpeed As Integer
		
		' Get the OS information to determine how to get the CPU information
		If GetOSInfo = False Then
			Exit Function
		End If
		
		' Get the CPU information
		GetSystemInfo(SysInfo)
		
		With SysInfo
			
			' Get how many CPUs the system has
			CPU_Count = .dwNumberOrfProcessors
			
			' Get what kind of CPU it is
			Select Case .dwProcessorType
				Case PROCESSOR_INTEL_386
					CPU_Type = "Intel 80386"
				Case PROCESSOR_INTEL_486
					CPU_Type = "Intel 80486"
				Case PROCESSOR_INTEL_PENTIUM
					CPU_Type = "Intel Pentium"
				Case PROCESSOR_MIPS_R4000
					CPU_Type = "MIPS R4000"
				Case PROCESSOR_ALPHA_21064
					CPU_Type = "ALPHA 21064"
				Case PROCESSOR_PPC_601
					CPU_Type = "PPC 601"
				Case PROCESSOR_PPC_603
					CPU_Type = "PPC 603"
				Case PROCESSOR_PPC_604
					CPU_Type = "PPC 604"
				Case PROCESSOR_PPC_620
					CPU_Type = "PPC 620"
				Case PROCESSOR_HITACHI_SH3
					CPU_Type = "HITACHI SH3"
				Case PROCESSOR_HITACHI_SH3E
					CPU_Type = "HITACHI SH3E"
				Case PROCESSOR_HITACHI_SH4
					CPU_Type = "HITACHI SH4"
				Case PROCESSOR_MOTOROLA_821
					CPU_Type = "MOTOROLA 821"
				Case PROCESSOR_SHx_SH3
					CPU_Type = "SHx SH3"
				Case PROCESSOR_SHx_SH4
					CPU_Type = "SHx SH4"
				Case PROCESSOR_STRONGARM
					CPU_Type = "STRONGARM"
				Case PROCESSOR_ARM720
					CPU_Type = "ARM 720"
				Case PROCESSOR_ARM820
					CPU_Type = "ARM 820"
				Case PROCESSOR_ARM920
					CPU_Type = "ARM 920"
				Case PROCESSOR_ARM_7TDMI
					CPU_Type = "ARM 7TDMI"
				Case Else
					CPU_Type = "Unknown - " & CStr(.dwProcessorType)
			End Select
		End With
		
		' Find Processor Speed (if it's available)
		TempSpeed = GetRegDWORD(RegistryKeys.HKEY_LOCAL_MACHINE, "HARDWARE\DESCRIPTION\System\CentralProcessor\0", "~MHz")
		CPU_Speed = CStr(TempSpeed) & " MHz"
		
		' Get how much total ram is on the user's computer
		Memory.dwLength = Len(Memory)
		GlobalMemoryStatus(Memory)
		CPU_RAM = FormatFileSize(Memory.dwTotalPhys)
		
		GetSysInfo = True
		
	End Function
	
	' Function to gets the windows information only
	Public Function GetOSInfo() As Boolean
		On Error GoTo errHandler
		
		Dim OSinfo As OSVERSIONINFO
		Dim PID As String
		
		' Setup the variable to be passed
		With OSinfo
			.dwOSVersionInfoSize = Len(OSinfo) '148
			.szCSDVersion = Space(128)
		End With
		
		' Get the OS info and store it in the OSInfo variable
		If GetVersionEx(OSinfo) = 0 Then
			MsgBox("An error occured while trying to get the OS version and information." & Chr(13) & "Click OK to continue.", MsgBoxStyle.OKOnly + MsgBoxStyle.Exclamation, "  Error  -  GetVersionEx")
			GetOSInfo = False
			Exit Function
		End If
		
		' Take the information retrieved and store it in variables that can be easily used
		With OSinfo
			Select Case .dwPlatformId
				Case VER_PLATFORM_WIN32s
					PID = "Win 32"
					OS_Type = OSTypes.OS_Win32
				Case VER_PLATFORM_WIN32_WINDOWS
					If .dwMinorVersion = 0 Then
						PID = "Windows 95"
						OS_Type = OSTypes.OS_Win95
					ElseIf .dwMinorVersion = 10 Then 
						PID = "Windows 98"
						OS_Type = OSTypes.OS_Win98
					End If
				Case VER_PLATFORM_WIN32_NT
					If .dwMajorVersion = 3 Then
						PID = "Windows NT 3.51"
						OS_Type = OSTypes.OS_WinNT_351
					ElseIf .dwMajorVersion = 4 Then 
						PID = "Windows NT 4.0"
						OS_Type = OSTypes.OS_WinNT_40
					ElseIf .dwMajorVersion = 5 Then 
						If .dwMinorVersion = 1 Then
							PID = "Windows XP"
							OS_Type = OSTypes.OS_WinXP
						ElseIf .dwMinorVersion = 2 Then 
							PID = "Windows 2003"
							OS_Type = OSTypes.OS_Win2003
						Else
							PID = "Windows 2000"
							OS_Type = OSTypes.OS_Win2000
						End If
					End If
				Case Else
					PID = "Unknown"
					OS_Type = OSTypes.OS_Unknown
			End Select
			
			OS_Version = CStr(.dwMajorVersion) & "." & CStr(.dwMinorVersion)
			OS_Build = CStr(.dwBuildNumber)
			OS_ServicePack = Trim(.szCSDVersion)
			
			If InStr(OS_ServicePack, Chr(0)) = 0 Then
				If Len(OS_ServicePack) = 0 Then
					OS_ServicePack = ""
				End If
			Else
				OS_ServicePack = Left(OS_ServicePack, InStr(OS_ServicePack, Chr(0)) - 1)
			End If
			
		End With
		
		OS_CodeName = PID
		GetOSInfo = True
		
		Exit Function
		
errHandler: 
		
		If Err.Number = 0 Then
			Resume Next
		ElseIf Err.Number = 20 Then 
			Resume Next
		Else
			MsgBox(Err.Source & " caused the following error while getting the OS version:" & Chr(13) & Chr(13) & "Error Number = " & CStr(Err.Number) & Chr(13) & "Error Description = " & Err.Description, MsgBoxStyle.OKOnly + MsgBoxStyle.Exclamation, "  Error  -  " & Err.Description)
			Err.Clear()
			GetOSInfo = False
			Exit Function
		End If
		
	End Function
	
	' Function that retrieves a STRING from the Windows Registry
	Private Function GetRegString(ByVal TheKey As RegistryKeys, ByVal TheSubKey As String, ByVal TheValue As String) As String
		On Error Resume Next
		
		Dim KeyHandle As Integer
		Dim TempString As String
		Dim BufferSize As Integer
		Dim KeyType As Integer
		
		' Open the key
		RegOpenKey(TheKey, TheSubKey, KeyHandle)
		
		' Find the type of key and the size of the registry entry
		RegQueryValueEx(KeyHandle, TheValue, 0, KeyType, 0, BufferSize)
		If KeyType = REG_SZ Then
			TempString = New String(" ", BufferSize)
			
			' Get the value of the registry entry
			If RegQueryValueEx(KeyHandle, TheValue, 0, 0, TempString, BufferSize) = ERROR_SUCCESS Then
				If InStr(TempString, Chr(0)) <> 0 Then
					GetRegString = Left(TempString, InStr(TempString, Chr(0)) - 1)
				Else
					GetRegString = TempString
				End If
			End If
		End If
		
		' Close the key
		RegCloseKey(KeyHandle)
		
	End Function
	
	' Function that retrieves a LONG from the Windows Registry
	Private Function GetRegDWORD(ByVal TheKey As RegistryKeys, ByVal TheSubKey As String, ByVal TheValue As String) As Integer
		On Error Resume Next
		
		Dim KeyType As Integer
		Dim TempLong As Integer
		Dim KeyHandle As Integer
		
		' Open the key
		RegOpenKey(TheKey, TheSubKey, KeyHandle)
		
		' Get the registry entry and type
		If RegQueryValueEx(KeyHandle, TheValue, 0, KeyType, TempLong, 4) = ERROR_SUCCESS Then
			If KeyType = REG_DWORD Then
				GetRegDWORD = TempLong
			End If
		End If
		
		' Close the key
		RegCloseKey(KeyHandle)
		
	End Function
	
	' Function that formats the file size in bytes into KB/MB/GB
	Private Function FormatFileSize(ByVal TheSize_BYTEs As Integer) As String
		On Error Resume Next
		
		Const KB As Integer = 1024
		Const MB As Integer = KB * KB
		Dim FormatSoFar As String
		
		' Return size of file in kilobytes.
		If TheSize_BYTEs = -1 Then
			FormatFileSize = "0.0KB (0 bytes)"
		ElseIf TheSize_BYTEs < KB Then 
			FormatSoFar = VB6.Format(TheSize_BYTEs, "#,##0") & " bytes"
		Else
			Select Case TheSize_BYTEs \ KB
				Case Is < 10
					FormatSoFar = VB6.Format(TheSize_BYTEs / KB, "0.00") & "KB"
				Case Is < 100
					FormatSoFar = VB6.Format(TheSize_BYTEs / KB, "0.0") & "KB"
				Case Is < 1000
					FormatSoFar = VB6.Format(TheSize_BYTEs / KB, "0.0") & "KB"
				Case Is < 10000
					FormatSoFar = VB6.Format(TheSize_BYTEs / MB, "0.00") & "MB"
				Case Is < 100000
					FormatSoFar = VB6.Format(TheSize_BYTEs / MB, "0.0") & "MB"
				Case Is < 1000000
					FormatSoFar = VB6.Format(TheSize_BYTEs / MB, "0.0") & "MB"
				Case Is < 10000000
					FormatSoFar = VB6.Format(TheSize_BYTEs / MB / KB, "0.00") & "GB"
			End Select
			FormatSoFar = FormatSoFar & " (" & VB6.Format(TheSize_BYTEs, "#,##0") & " bytes)"
		End If
		
		FormatFileSize = FormatSoFar
		
	End Function
End Module