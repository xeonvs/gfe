
''' <summary>
''' ��������� ���������� ������� ���� ������ ��� ��������� ��
''' </summary>
Public Interface IDatabasesTypes
    ''' <summary>
    ''' ������������ ��������� ����� ���
    ''' </summary>
    Enum enmBaseType
        QBBS = 0        'notfound descr.
        Fido = 1        'MSG base
        Squish = 2      'Squish base
        Jam = 3         'JAM base
        Passthru = 7    'Pasthru base
        FIPS = 9        'FIPS BASE
        SQL = 10        'PostgreSQL Base
        Unknown = -1    'Unknown base
    End Enum

    ''' <summary>
    ''' �������� Netmail ���������
    ''' </summary>    
    Enum MSG_ATTRIBUTE
        Msg_Private = &H1S      '/*+Pvt - ������                        */
        Msg_Crash = &H2S        '/*+Cra - �������p��p�������            */
        Msg_Read = &H4S         '/* Rec - �p������� ���y�������         */
        Msg_Sent = &H8S         '/* Snt - �������                       */
        Msg_File = &H10S        '/*+Att - ��������                      */
        Msg_Transit = &H20S     '/* Trs - �p��������                    */
        Msg_Orphan = &H40S      '/* Orp - ���y������ �� �y�����y��      */
        Msg_Kill = &H80S        '/* K/s - ������� ����� �������         */
        Msg_Local = &H100S      '/* Loc - ������� �� ������ y���        */
        Msg_Hold = &H200S       '/* Hld - ������� �� ��������y �����y   */
        Msg_FReq = &H800S       '/* FRq - ���p�� �����                  */
        Msg_RReq = &H1000S      '/*+RRq - ���p�� ������p������ �p����   */
        Msg_IsRR = &H2000S      '/*+RRc - ������p������ �p����          */
        Msg_AReq = &H4000S      '/*+ARq - Audit request ???             */
        Msg_FUpsReq = &H8000S   '/* URq - ���p�� ���������� �����       */
    End Enum

    ''' <summary>
    ''' �������� ��������� � JAM ����
    ''' </summary>
    Enum JAM_ATTRIBUTE
        MSG_Local = &H1S            ' Msg created locally
        MSG_Intransit = &H2S        ' Msg is in-transit
        MSG_Private = &H4S          ' Private
        MSG_Read = &H8S             ' Read by addressee
        MSG_Sent = &H10S            ' Sent to remote
        MSG_Killsent = &H20S        ' Kill when sent
        MSG_Archivesent = &H40S     ' Archive when sent
        MSG_Hold = &H80S            ' Hold for pick-up
        MSG_Crash = &H100S          ' Crash
        MSG_Immediate = &H200S      ' Send Msg now, ignore restrictions
        MSG_Direct = &H400S         ' Send directly to destination
        MSG_Gate = &H800S           ' Send via gateway
        MSG_Filerequest = &H1000S   ' File request
        MSG_Fileattach = &H2000S    ' File(s) attached to Msg
        MSG_Truncfile = &H4000S     ' Truncate file(s) when sent
        MSG_Killfile = &H8000S      ' Delete file(s) when sent
        MSG_Receiptreq = &H10000    ' Return receipt requested
        MSG_Confirmreq = &H20000    ' Confirmation receipt requested
        MSG_Orphan = &H40000        ' Unknown destination
        MSG_Encrypt = &H80000       ' Msg text is encrypted
        MSG_�ompress = &H100000     ' Msg text is compressed
        MSG_Escaped = &H200000      ' Msg text is seven bit ASCII
        MSG_Fpu = &H400000          ' Force pickup
        MSG_Typelocal = &H800000    ' Msg is for local use only
        MSG_Typeecho = &H1000000    ' Msg is for conference distribution
        MSG_Typenet = &H2000000     ' Msg is direct network mail
        MSG_Nodisp = &H20000000     ' Msg may not be displayed to user
        MSG_Locked = &H40000000     ' Msg is locked, no editing possible
        MSG_Deleted = &H80000000    ' Msg is deleted
    End Enum

    ''' <summary>
    ''' �������� ��������� � FIPS ����
    ''' </summary>
    Enum FIPS_ATTRIBUTE
        atMSGPRIVATE = &H1 '������� ������
        atMSGCRASH = &H2 '��������� ����������
        atMSGRECD = &H4 '������ ��������
        atMSGSENT = &H8 '���������� ������
        atMSGFILE = &H10 '� ������ ���������� �����
        atMSGFWD = &H20 '������ ���� ������������
        atMSGORPHAN = &H40 '���������� ����-����������
        atMSGKILL = &H80 '������� ����� ��������
        atMSGLOCAL = &H100 '��������� �������� �� ����� �������
        atMSGXX1 = &H200 '
        atMSGXX2 = &H400 '
        atMSGFRQ = &H800 '�������� ������
        atMSGRRQ = &H1000 '������ ������
        atMSGCPT = &H2000 '������ - ������������� ������
        atMSGARQ = &H4000 '������ ���� ����������
        atMSGURQ = &H8000 '���������� �������
    End Enum

    ''' <summary>
    ''' �������� ��������� � Sqish ����
    ''' </summary>
    Enum SQ_ATTRIBUTE
        MSG_PRIVATE = &H1   '������� ������
        MSG_CRASH = &H2     '��������� ����������
        MSG_RECD = &H4      '������ ��������
        MSG_SENT = &H8      '���������� ������
        MSG_FILE = &H10     '� ������ ���������� �����
        MSG_FWD = &H20      '������ ���� ������������
        MSG_ORPHAN = &H40   '���������� ����-����������
        MSG_KILL = &H80     '������� ����� ��������
        MSG_LOCAL = &H100   '��������� �������� �� ����� �������
        MSG_XX1 = &H200     'Hold
        MSG_XX2 = &H400     'Reserved
        MSG_FRQ = &H800     '�������� ������
        MSG_RRQ = &H1000    '������ ������
        MSG_CPT = &H2000    '������ - ������������� ������
        MSG_ARQ = &H4000    '������ ���� ����������
        MSG_URQ = &H8000    '���������� �������
        MSG_SCAN = &H10000L 'Squish scanned
        MSG_UMSG = &H20000L 'Valid xmsg.umsg
    End Enum

End Interface
