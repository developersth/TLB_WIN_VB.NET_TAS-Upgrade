Imports Oracle.DataAccess.Client
Imports System.Data
Imports System.Threading

Public Class frmLoadCreateLoad
    Public FormScreenID As Long
    Dim frm_work As Integer = 0  '1=add ,2=Edit
    Public RemarkCancelOK As Boolean

    Dim Do_no As String
    Dim SealCount As String
    Dim SealCountAuto As String
    Dim ChkAutoSeal As Boolean
    Dim SealNumber As String
    Public SealLast As String
    Dim drivID As String
    Dim ScreenID As Long
    Dim Load_no As String
    Public AE_LoadNo As String
    Const INTRO_RPT_ID = 52010029

    Private Sub frmLoadCreateLoad_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ' CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmLoadCreateLoad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SetScreenResulotion()
        'CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        If frm_work = 1 Then
            Me.Text = "Loading # Add"
        ElseIf frm_work = 2 Then
        End If
        ClearForm()
        InitialCBbilling()
        'InitailExciseName()
        'Initial_frm()
        'resolution(Me, 1)
    End Sub

    Private Sub frmLoadCreateLoad_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        ' CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub

    Private Sub Initial_frm()

    End Sub

    Private Sub ClearForm()
        cbCardBil.Items.Clear()
        cbCardBil.Text = ""
        cbTail.Items.Clear()
        cbTail.Text = ""
        cbDriverBil.Items.Clear()
        cbTUHead.Items.Clear()
        cbTUHead.Text = ""
        cbDriverBil.Text = ""
        txtDo.Text = ""
        txtSealNumber.Text = ""
        msGridComp.Rows.Clear()
        txtTotalComp.Text = ""
        txtSumCapComp.Text = ""
        txtSealCount.Text = ""
    End Sub

    Public Sub InitialCBbilling()
        '        txtSealNumber = ""
        Dim t1 As Thread = New Thread(New ThreadStart(AddressOf InitialComboBox))
        t1.Start()
        'Call Initialcbcard()
        'Call InitialcbDriver()
        ''Call Initialcard_reader()
        'Call InitialTransport()
    End Sub
    Private Sub InitialComboBox()
        Thread.Sleep(1000)
        Me.Invoke(CType(Sub()
                            Call Initialcbcard()
                            Call InitialcbDriver()
                            Call InitialTransport()
                        End Sub, MethodInvoker))

    End Sub

    Private Sub Initialcbcard()
        Dim strSQL As String
        Dim tmpCard As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        tmpCard = ""
        tmpCard = cbCardBil.Text
        strSQL = " select c.card_no from tas.card c,tas.transport_unit t  where c.card_type=0  and c.is_enabled=1and c.tu_number=t.tu_number(+)  " &
                               " and not exists(select  h.tu_card_no " &
                               " from  oil_load_entrycard  h where c.card_no=h.tu_card_no  ) order by c.card_no "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            With cbCardBil
                .Items.Clear()
                For Each dr As DataRow In dt.Rows
                    .Items.Add(dr.Item("card_no").ToString())
                Next
            End With
        End If
        cbCardBil.Text = tmpCard
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub

    Private Sub InitialcbDriver()
        Dim strSQL As String
        Dim tmpDriver As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        tmpDriver = cbDriverBil.Text
        strSQL = " select d.driver_id, d.first_name ||' '|| d.last_name  as DriverName,d.first_name ||' '|| d.last_name||' _'||d.driver_id as driver  from driver d order by d.first_name,d.last_name,d.driver_id"
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            With cbDriverBil
                .Items.Clear()
                For Each dr As DataRow In dt.Rows
                    .Items.Add(dr.Item("driver").ToString())
                Next
            End With
        End If
        cbDriverBil.Text = tmpDriver
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub

    Private Sub InitialTransport()
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim tmpTUheader As String
        Dim tmpTUtail As String
        Dim dt As DataTable

        tmpTUheader = cbTUHead.Text
        tmpTUtail = cbTail.Text
        strSQL =
             "select T.TU_ID,T.TU_NUMBER,T.TU_ID||' _'||T.TU_NUMBER AS TuNAME " &
             " from TRANSPORT_UNIT T order by T.Tu_Id,T.TU_NUMBER "
        cbTUHead.Items.Clear()
        cbTail.Items.Clear()
        cmbTmpTuTail.Items.Clear()
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            cbTail.Items.Add("")
            For Each dr As DataRow In dt.Rows
                cbTUHead.Items.Add(IIf(IsDBNull(dr.Item("TuNAME")), "", Trim(dr.Item("TuNAME"))))
                cbTail.Items.Add(IIf(IsDBNull(dr.Item("TuNAME")), "", Trim(dr.Item("TuNAME"))))
            Next
        End If
        cbTUHead.Text = tmpTUheader
        cbTail.Text = tmpTUtail
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub
    Private Sub InitailExciseName()
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        strSQL =
             "select t.description from tas.status_desc t" &
             " where t.t_name = 'EXCISE' "

        cbExciseName.Items.Clear()
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            For Each dr As DataRow In dt.Rows
                cbExciseName.Items.Add(IIf(IsDBNull(dr.Item("description")), "", Trim(dr.Item("description"))))
            Next
            cbExciseName.SelectedIndex = 0
        End If

        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub

    Private Sub ClearDataBilling()
        cbCardBil.Items.Clear()
        cbTail.SelectedIndex = -1
        cbTUHead.SelectedIndex = -1
        cbDriverBil.Items.Clear()
        TxtDriverName.Text = ""
        TxtDriverSurname.Text = ""
        txtDo.Text = ""
    End Sub

    Private Function CheckVehicle(ByVal TuNumber As String) As Boolean
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        strSQL = "select t.tu_id from transport_unit t where t.tu_id='" & Trim(TuNumber) & "' "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            mDataSet = Nothing
            If dt.Rows.Count > 0 Then
                Return True
            End If
        End If
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
        Return False
    End Function

    Private Function ProcessBilling() As Boolean
        Dim d As String
        Dim vTuH() As String
        Dim vTuT() As String
        Dim vTu1 As String
        Dim vTu2 As String
        Dim CRID As Long

        If cbCardBil.Text = "" Then
            MsgBox("ไม่สามารถสร้างการจ่ายได้ กรุณาตรวจสอบหมายเลขบัตร", vbInformation)
            Return False
        End If

        If Not CheckCard(cbCardBil.Text) Then
            'MsgBox("ไม่พบหมายเลขบัตร  " & cbCardBil.Text & " ในฐานข้อมูล  ")
            Return False
        End If

        If cbTUHead.Text = "" Then
            MsgBox("คุณใส่ข้อมูลไม่ครบ", vbCritical, "คำเตือน")
            Return False
        End If

        If Not CheckTruckheader(cbTUHead.Text) Then
            MsgBox("ไม่พบหมายทะเบียนหัวลาก  " & cbTUHead.Text & " ในฐานข้อมูล  ")
            Return False
        End If

        If cbTail.Text <> "" Then
            If Not CheckTruckTail(cbTail.Text) Then
                MsgBox("ไม่พบหมายทะเบียนตัวพ่วง " & cbTail.Text & " ในฐานข้อมูล  ")
                Return False
            End If
        End If

        If txtDo.Text = "" Then
            MsgBox("ไม่สามารถสร้างการจ่ายได้ กรุณาป้อนหมายเลข  Do ")
            Return False
        End If

        If txtSealNumber.Text = "" Then
            MsgBox("ไม่สามารถสร้างการจ่ายได้ กรุณาป้อนหมายเลข Seal")
            Return False
        End If

        If cbTUHead.Text <> "" Then
            vTuH = Split(cbTUHead.Text, "_")
            vTu1 = vTuH(1)
            If cbTail.Text <> "" Then
                vTuT = Split(cbTail.Text, "_")
                vTu2 = vTuT(1)
            Else
                vTu2 = "0"
            End If
        Else
            MsgBox("ไม่สามารถสร้างการจ่ายได้ กรุณาตรวจสอบทะเบียนหัวลาก", vbInformation)
            Return False
        End If
        If Not runProcVehicle(vTu1, vTu2, GetIdDriver(cbDriverBil)) Then
            Return False
        End If
        If MsgBox("ท่านต้องการสร้างการจ่ายหรือไม่?", vbInformation + vbYesNo) = vbNo Then
            Return False
        End If

        CRID = 0
        d = Format(DTPdate.Value, "dd/MM/yyyy") & " " & Format(DTPTime.Value, "HH:mm:ss")


        If SaveCreateLoad(CLng(Trim(cbCardBil.Text)), CLng(Trim(vTu1)), CLng(Trim(vTu2)), CRID, 1, d, mUserName, mComputerName) Then
            Return True
        End If
        Return False
    End Function

    Private Function runProcVehicle(ByVal iNumber1 As String, ByVal iNumber2 As String, ByVal IDriverID As String) As Boolean
        Dim strSQL As String
        Dim Oraparam As New COraParameter
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        Dim bRet As Boolean = False

        strSQL = "begin " &
                          " load.registor_check_vehicle(" &
                          iNumber1 & "," & iNumber2 & "," & IDriverID & "," &
                          ":ret_vehicle,:RET_CHECK,:RET_MSG); " &
                          "end;"

        With Oraparam
            .CreateOracleParamOutput("ret_vehicle", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_CHECK", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With
        If Oradb.ExeSQL(strSQL, Oraparam) Then
            RET_CHECK = Oraparam.GetOraclParamValue("RET_CHECK")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            If RET_CHECK = -1 Then
                bRet = False
                MsgBox(RET_MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Else
                bRet = True
            End If
        End If
        Oraparam.RemoveOracleParam()
        Oraparam = Nothing

        Return bRet
    End Function

    Private Function SaveCreateLoad(ByVal itu_card_no As Long, ByVal itu1 As Long, ByVal itu2 As Long, ByVal icard_reader_id As Long, ByVal ioverride_card As Long, ByVal idatetime_active As String, ByVal ij_user As String, ByVal ij_computer As String) As Boolean
        Dim strSQL As String
        Dim tmpDriverId() As String
        Dim Oraparam As New COraParameter
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        Dim bRet As Boolean = False

        strSQL = "begin " &
                        " load.Registor_check_tu(" &
                        itu_card_no & "," & itu1 & "," & itu2 & "," &
                        icard_reader_id & ", " &
                       ioverride_card & ",to_date('" & idatetime_active & "','DD/MM/YYYY HH24:MI:SS') ," &
                        "'" & ij_user & "','" & ij_computer & "'," &
                        ":ret_vehicle_number,:ret_tuid,:ret_tuid1,:ret_check,:ret_msg); " &
                        "end;"
        With Oraparam
            .CreateOracleParamOutput("ret_vehicle_number", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("ret_tuid", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("ret_tuid1", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("ret_check", COracle._OracleDbType.OraInt16)
            .CreateOracleParamOutput("ret_msg", COracle._OracleDbType.OraVarchar2, 512)
        End With
        If Oradb.ExeSQL(strSQL, Oraparam) Then
            RET_CHECK = Oraparam.GetOraclParamValue("ret_check")
            RET_MSG = Oraparam.GetOraclParamValue("ret_msg")
            If RET_CHECK = -1 Then
                bRet = False
                MsgBox(RET_MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Else
                bRet = True
            End If
        End If
        If bRet Then
            If cbDriverBil.Text = "" Or CheckDriver(cbDriverBil.Text) Then
                MsgBox("ไม่พบรหัสพนักงานขับรถ กรุณาเลือกพนักงานขับรถอีกครั้ง", vbInformation)
                bRet = False
            Else
                If InStr(1, Trim(cbDriverBil.Text), "_") > 0 Then
                    tmpDriverId = Split(cbDriverBil.Text, "_")
                Else
                    MsgBox("รูบแบบของข้อมูลไม่ถูกต้องกรุณาเลือกอีกครั้ง ", vbInformation)
                    bRet = False
                End If
            End If
        End If
        If bRet Then

            'bRet = SaveCheckDriver(Oraparam.GetOraclParamValue("ret_vehicle_number"), tmpDriverId(1), 1, idatetime_active, ij_user, ij_computer, itu_card_no, itu1, itu2, icard_reader_id)
            bRet = SaveCheckDriver(Oraparam.GetOraclParamValue("ret_vehicle_number").ToString(), tmpDriverId(1).ToString(), 1, idatetime_active, ij_user, ij_computer, itu_card_no, itu1, itu2, icard_reader_id)
        End If
        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function

    Public Function SaveCheckDriver(ByVal ivehicle_number As String, ByVal idriver_id As String, ByVal ioverride_card As Long, ByVal idatetime_active As String, ByVal ij_user As String, ByVal ij_computer As String, ByVal itu_card_no As Long, ByVal ituID1 As Long, ByVal ituID2 As Long, ByVal icard_reader_id As Long) As Boolean
        Dim bRet As Boolean = False
        Dim Oraparam As New COraParameter
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        Dim strSQL As String
        Dim ido_no_count As Long
        Dim i As Long
        Dim arCountDo() As String

        arCountDo = Split(txtDo.Text, ",")
        For i = 0 To UBound(arCountDo)
            ido_no_count = i + 1
        Next i
        strSQL = "begin " &
                         " load.Registor_check_Driver('" &
                         ivehicle_number & "'," & idriver_id & "," &
                         ioverride_card & ", " &
                         " to_date('" & idatetime_active & "','DD/MM/YYYY HH24:MI:SS') ," &
                         "'" & ij_user & "','" & ij_computer & "'," &
                         ":ret_driver,:ret_check,:ret_msg); " &
                         "end;"
        With Oraparam
            .CreateOracleParamOutput("ret_driver", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("ret_check", COracle._OracleDbType.OraInt16)
            .CreateOracleParamOutput("ret_msg", COracle._OracleDbType.OraVarchar2, 512)
        End With
        If Oradb.ExeSQL(strSQL, Oraparam) Then
            RET_CHECK = Oraparam.GetOraclParamValue("ret_check")
            RET_MSG = Oraparam.GetOraclParamValue("ret_msg")
            If RET_CHECK = -1 Then
                bRet = False
                MsgBox(RET_MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Else
                bRet = True
            End If
        End If
        If bRet Then
            bRet = SaveRegCreateLoad(itu_card_no, ituID1, ituID2, idriver_id, ivehicle_number, ido_no_count, ioverride_card, icard_reader_id, idatetime_active, ij_user, ij_computer)
        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function

    Public Function SaveRegCreateLoad(ByVal itu_card_no As Long, ByVal ituID1 As Long, ByVal ituID2 As Long, ByVal idriver_id As Long, ByVal ivehicle_number As String, ByVal ido_no_count As Long, ByVal ioverride_card As Long, ByVal icard_reader_id As Long, ByVal idatetime_active As String, ByVal ij_user As String, ByVal ij_computer As String) As Boolean
        Dim bRet As Boolean = False
        Dim Oraparam As New COraParameter
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        Dim strSQL As String
        Dim ido_no_list As String
        Dim vLoadNo As String
        ido_no_list = txtDo.Text
        strSQL = "begin " &
                         " load.Registor_Create_Load(" &
                          itu_card_no & "," & ituID1 & "," & ituID2 & "," & idriver_id & ",'" & ivehicle_number & "'," &
                          ido_no_count & " ,'" & ido_no_list & "',1," & icard_reader_id & " ," &
                          " to_date('" & idatetime_active & "','DD/MM/YYYY HH24:MI:SS') ," &
                           "'" & ij_user & "','" & ij_computer & "'," &
                         ":ret_load_no,:ret_check,:ret_msg); " &
                         "end;"
        With Oraparam
            .CreateOracleParamOutput("ret_load_no", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("ret_check", COracle._OracleDbType.OraInt16)
            .CreateOracleParamOutput("ret_msg", COracle._OracleDbType.OraVarchar2, 512)
        End With

        If Oradb.ExeSQL(strSQL, Oraparam) Then
            RET_CHECK = Oraparam.GetOraclParamValue("ret_check")
            RET_MSG = Oraparam.GetOraclParamValue("ret_msg")
            If RET_CHECK = -1 Then
                bRet = False
                MsgBox(RET_MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Else
                bRet = True
            End If
        End If
        If bRet Then
            vLoadNo = Oraparam.GetOraclParamValue("ret_load_no").ToString()
            Load_no = vLoadNo
            txtSealNumber.Text = Replace(txtSealNumber.Text, Chr(32), "")
            If SaveSeal(Trim(vLoadNo), 1, Trim(txtSealNumber.Text), 1) Then
                bRet = True
                Call UpdateSealLoadHeader(vLoadNo)
                Call UpdateSealControl(vLoadNo, Trim(txtSealNumber.Text))
                'Call UpdateSealExcise(vLoadNo)
                'Call UpdateExciseName(vLoadNo)
                Call AddJournal(JournalType.Jevent, Me.FormScreenID, 100, mUserName, 809201, vLoadNo)
            Else
                bRet = False
            End If
            frmUtlShowdetial.Close()
            frmUtlShowdetial.GetLoadNo(Val(vLoadNo))
            frmUtlShowdetial.ShowDialog()
            frmLoadLoading.Show_Data()
            Me.Close()
            'If MessageBox.Show("สร้างการจ่ายของรถทะเบียน  " & Mid(cbTUHead.Text, 1, InStr(1, cbTUHead.Text, "_") - 1) & " เรียบร้อยแล้ว") Then

            'End If
        End If
        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function

    Private Function SaveSeal(ByVal iLoad_no As String, ByVal iauto_seal As Long, ByVal iseal_number As String, ByVal ioverride_card As Long) As Boolean
        Dim bRet As Boolean = False
        Dim Oraparam As New COraParameter
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        Dim strSQL As String
        'Dim Oseal_number() As String

        'Oseal_number = Split(Trim(iseal_number), "-")
        strSQL =
                    "begin " &
                    " load.Registor_Update_Seal ('" &
                    iLoad_no & "'," & iauto_seal & ",'" &
                    iseal_number & "', " &
                    ioverride_card & ",sysdate ," &
                    "'" & mUserName & "','" & mComputerName & "'," &
                    ":ret_check,:ret_msg); " &
                    "end;"

        With Oraparam
            .CreateOracleParamOutput("ret_check", COracle._OracleDbType.OraInt16)
            .CreateOracleParamOutput("ret_msg", COracle._OracleDbType.OraVarchar2, 512)
        End With

        If Oradb.ExeSQL(strSQL, Oraparam) Then
            RET_CHECK = Oraparam.GetOraclParamValue("ret_check")
            RET_MSG = Oraparam.GetOraclParamValue("ret_msg")
            If RET_CHECK = -1 Then
                bRet = False
                MsgBox(RET_MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Else
                bRet = True
            End If
        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function

    Private Sub UpdateSealLoadHeader(ByVal ILoadNo As String)
        Dim strSQL As String
        If ChkAutoSeal Then
            SealCount = SealCountAuto
        Else
            SealCount = txtSealCount.Text
        End If
        If SealCount = "" Then
            SealCount = 0
        End If

        strSQL =
                        " Update tas.oil_load_headers t set  t.Seal_use= " & SealCount & "," &
                        " t.seal_number='" & Trim(txtSealNumber.Text) & "'" &
                        "  Where t.load_header_no='" & ILoadNo & "'"
        Try
            Oradb.ExeSQL(strSQL)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub UpdateSealExcise(ByVal ILoadNo As String)
        Dim strSQL As String
        Dim mDataSet As New DataSet

        Dim StatusExcise As Integer
        If RadioTlb.Checked = True Then
            StatusExcise = 0
        Else
            StatusExcise = 1
        End If
        strSQL = _
                      " Update tas.oil_load_headers t SET t.seal_type =" & StatusExcise & _
                      " Where t.load_header_no= '" & ILoadNo & "'"
        Try
            Oradb.ExeSQL(strSQL)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub UpdateExciseName(ByVal ILoadNo As String)
        Dim strSQL As String
        strSQL = _
                      " Update tas.oil_load_headers t SET t.excise_name ='" & cbExciseName.Text.Trim & "'" & _
                      " Where t.load_header_no= '" & ILoadNo & "'"
        Try
            Oradb.ExeSQL(strSQL)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateSealControl(ByVal ILoadNo As String, ByVal Iseal_number As String)
        Dim strSQL As String
        Dim StrTmp() As String
        'Dim Oseal_number() As String
        'Dim str1 As String
        'Dim str2 As String
        'Oseal_number = Split(Trim(Iseal_number), "-")
        If Not (SealLast = "") Then
            strSQL = _
                            "Update tas.seal_control t SET t.load_last_no='" & Trim(ILoadNo) & "' ," & _
                            " t.seal_no='" & Trim(SealLast) & "'" & _
                            " Where t.id=1 "
            Try
                Oradb.ExeSQL(strSQL)
            Catch ex As Exception

            End Try
        Else
            strSQL = _
                           "Update tas.seal_control t SET t.load_last_no='" & Trim(ILoadNo) & "' ," & _
                           " t.seal_no='" & Trim(Iseal_number) & "'" & _
                           " Where t.id=1 "
            Try
                Oradb.ExeSQL(strSQL)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Function CheckCard(ByVal iCard As String) As Boolean
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        strSQL = _
                        " select * " & _
                        " from tas.card t  " & _
                        " where t.card_no ='" & Trim(iCard) & "' "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            mDataSet = Nothing
            If dt.Rows.Count > 0 Then
                Return True
            End If
        End If
        mDataSet = Nothing
        Return False
    End Function

    Private Function CheckTruckheader(ByVal iTruckH As String) As Boolean
        Dim strSQL As String
        Dim tmpStr() As String
        Dim tmp1 As String
        Dim tmp2 As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim bRet As Boolean = False

        If InStr(1, iTruckH, "_") > 0 Then
            tmpStr = Split(Trim(iTruckH), "_")
            iTruckH = tmpStr(1)
            tmp2 = tmpStr(0)
            strSQL = _
                        " select * " & _
                        " from tas.transport_unit  t " & _
                        " where t.tu_number ='" & Trim(iTruckH) & "' "
        Else
            iTruckH = iTruckH
            strSQL = _
                        " select * " & _
                        " from tas.transport_unit  t " & _
                        " where t.tu_id ='" & Trim(iTruckH) & "' "
        End If
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                bRet = True
            End If
        End If
        mDataSet = Nothing
        Return bRet
    End Function

    Private Function CheckTruckTail(ByVal iTruckT As String) As Boolean
        Dim strSQL As String
        Dim tmpStr() As String
        Dim tmp1 As String
        Dim tmp2 As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim bRet As Boolean = False

        If InStr(1, iTruckT, "_") > 0 Then
            tmpStr = Split(Trim(iTruckT), "_")
            iTruckT = tmpStr(1)
            tmp2 = tmpStr(0)
            strSQL = _
                        " select * " & _
                        " from tas.transport_unit  t " & _
                        " where t.tu_number ='" & Trim(iTruckT) & "' "
        Else
            iTruckT = iTruckT
            strSQL = _
                        " select * " & _
                        " from tas.transport_unit  t " & _
                        " where t.tu_id ='" & Trim(iTruckT) & "' "
        End If
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                bRet = True
            End If
        End If
        mDataSet = Nothing
        Return bRet
    End Function

    Private Function GetIdDriver(ByVal iCb As ComboBox) As String
        Dim tmpDriver() As String
        If InStr(1, iCb.Text, " _") > 0 Then
            tmpDriver = Split(iCb.Text, "_")
            Return tmpDriver(1)
        Else
            Return "0"
        End If
    End Function

    Private Function CheckDriver(ByVal iDriver As String) As Boolean
        Dim strSQL As String
        Dim tmpStr() As String
        Dim tmp1 As String
        Dim tmp2 As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim bRet As Boolean = False

        If InStr(1, iDriver, "_") > 0 Then
            tmpStr = Split(Trim(iDriver), "_")
            iDriver = tmpStr(0)
            tmp2 = tmpStr(1)
            strSQL = _
                            " select  * " & _
                            " from tas.driver t " & _
                            " where t.driver_id ='" & Trim(tmp2) & "' "
        Else
            iDriver = iDriver
            strSQL = _
                            " select  * " & _
                            " from tas.driver t " & _
                            " where t.first_name||' '||t.last_name  ='" & Trim(iDriver) & "' "
        End If

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                bRet = False
            End If
        End If
        mDataSet = Nothing
        Return bRet
    End Function

    Private Sub GetDriver()
        Dim strSQL As String
        Dim tmpTransUnit() As String
        Dim tmp1 As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        If cbTUHead.Text = "" Then Exit Sub
        tmpTransUnit = Split(Trim(cbTUHead.Text), "_")
        tmp1 = Trim(tmpTransUnit(1))

        strSQL = _
                    " select v.vehicle_number,dm.driver_id ,d.first_name,d.last_name , d.first_name ||' '|| d.last_name||' _'||d.driver_id as driver " & _
                    " from tas.vehicle v , tas.driver_mapping  dm , tas.driver d    ,tas.oil_load_headers  oh  " & _
                    " Where v.Vehicle_Number = dm.Vehicle_Number " & _
                    " and d.driver_id = dm.driver_id   and v.vehicle_number = oh.vehicle_number (+)   and d.driver_id = oh.driver_id  and oh.cancel_status =0 " & _
                    " and v.tu_number='" & tmp1 & "'   order by oh.creation_date  desc "

        cbDriverBil.Text = ""
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                cbDriverBil.Text = IIf(IsDBNull(dt.Rows(0).Item("driver")), "", dt.Rows(0).Item("driver").ToString())
                TxtDriverName.Text = IIf(IsDBNull(dt.Rows(0).Item("first_name")), "", dt.Rows(0).Item("first_name").ToString())
                TxtDriverSurname.Text = IIf(IsDBNull(dt.Rows(0).Item("last_name")), "", dt.Rows(0).Item("last_name").ToString())
            End If
        End If

        mDataSet = Nothing
    End Sub

    Private Sub GetTuTail()
        Dim strSQL As String
        Dim tmpTransUnit() As String
        Dim tmp1 As String
        Dim tmp2 As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        cbTail.Text = ""
        If cbTUHead.Text = "" Then Exit Sub
        tmpTransUnit = Split(cbTUHead.Text, "_")
        tmp1 = Trim(tmpTransUnit(1))

        'Update By Jakapong
        strSQL = _
                        " select  t.tu_number1   from vehicle t" & _
                        "   where t.tu_number ='" & tmp1 & "'  order by t.update_date desc "

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                tmp2 = Trim(IIf(IsDBNull(dt.Rows(0).Item("tu_number1")), "", dt.Rows(0).Item("tu_number1").ToString()))
            End If
        End If
        If tmp2 = "" Then Exit Sub


        strSQL = _
                        " select T.TU_ID,T.TU_NUMBER,T.TU_ID||' _'||T.TU_NUMBER AS TuNAME " & _
                        " from tas.transport_unit t " & _
                        "  Where t.tu_number = '" & tmp2 & "' "

        cbTail.Text = ""
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                cbTail.Text = IIf(IsDBNull(dt.Rows(0).Item("TuNAME")), "", dt.Rows(0).Item("TuNAME"))
            End If
        End If
        mDataSet = Nothing
    End Sub

    Private Sub GetDetalComp()
        Dim strSQL As String
        Dim i As Integer
        Dim ValCompTruck As Long
        Dim ValCompTailer As Long
        Dim StringCompTruck As String
        Dim StringCompTailer As String
        Dim CompTruck() As String
        Dim CompTailer() As String
        Dim vTu1 As String
        Dim vTu11 As String
        Dim vTu2 As String
        Dim vTu22 As String
        Dim vTu_id1() As String
        Dim vTu_id2() As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        On Error Resume Next

        msGridComp.Rows.Clear()

        txtTotalComp.Text = "0"
        txtSumCapComp.Text = "0"
        txtSealCount.Text = "0"
        txtSealCount.Text = GetCountSeal()

        If cbTUHead.Text = "" Then
            vTu1 = "0"
        Else
            vTu_id1 = Split(Trim(cbTUHead.Text), " _")
            vTu1 = vTu_id1(1)
            vTu11 = vTu_id1(0)
        End If

        If cbTail.Text = "" Then
            vTu2 = "0"
        Else
            vTu_id2 = Split(Trim(cbTail.Text), " _")
            vTu2 = vTu_id2(1)
            vTu22 = vTu_id2(0)
        End If
        strSQL = "select t.compartments,t.comp_1,comp_2,comp_3,comp_4 , " & _
                        " comp_5,comp_6,comp_7,comp_8,comp_9,comp_10,comp_11,comp_12, " & _
                        " comp_13,comp_14,comp_15,comp_16,comp_17,comp_18,comp_19,comp_20 " & _
                        " from transport_unit t " & _
                        " Where t.TU_NUMBER = " & Trim(vTu1) & ""

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            msGridComp.RowCount = 0
            If dt.Rows.Count > 0 Then
                ValCompTruck = IIf(IsDBNull(dt.Rows(0).Item("compartments")), 0, dt.Rows(0).Item("compartments"))
                StringCompTruck = dt.Rows(0).Item("comp_1") & "," & dt.Rows(0).Item("comp_2") & "," & dt.Rows(0).Item("comp_3") & ","
                StringCompTruck = StringCompTruck & dt.Rows(0).Item("comp_4") & "," & dt.Rows(0).Item("comp_5") & "," & dt.Rows(0).Item("comp_6") & ","
                StringCompTruck = StringCompTruck & dt.Rows(0).Item("comp_7") & "," & dt.Rows(0).Item("comp_8") & "," & dt.Rows(0).Item("comp_9") & ","
                StringCompTruck = StringCompTruck & dt.Rows(0).Item("comp_10") & "," & dt.Rows(0).Item("comp_11") & "," & dt.Rows(0).Item("comp_12") & ","
                StringCompTruck = StringCompTruck & dt.Rows(0).Item("comp_13") & "," & dt.Rows(0).Item("comp_14") & "," & dt.Rows(0).Item("comp_15") & ","
                StringCompTruck = StringCompTruck & dt.Rows(0).Item("comp_16") & "," & dt.Rows(0).Item("comp_17") & "," & dt.Rows(0).Item("comp_18") & ","
                StringCompTruck = StringCompTruck & dt.Rows(0).Item("comp_19") & "," & dt.Rows(0).Item("comp_20")
                CompTruck = Split(StringCompTruck, ",")
                'msGridComp.Item(0, 0).Value = i + 1

                With msGridComp
                    For i = 0 To UBound(CompTruck)
                        If CompTruck(i) <> 0 Then
                            .RowCount = .RowCount + 1
                            If .Rows.Count > 0 Then
                                .Item(0, i).Value = i + 1
                                .Item(1, i).Value = vTu11
                                .Item(2, i).Value = CompTruck(i)
                            End If

                        End If
                    Next i
                End With
            End If
        End If

        If cbTail.Text <> "" Then
            strSQL = "select t.compartments,t.comp_1,comp_2,comp_3,comp_4 , " & _
            " comp_5,comp_6,comp_7,comp_8,comp_9,comp_10,comp_11,comp_12, " & _
            " comp_13,comp_14,comp_15,comp_16,comp_17,comp_18,comp_19,comp_20 " & _
            " from transport_unit t" & _
            " Where t.TU_NUMBER =" & Trim(vTu2) & ""
            Oradb.OpenDys(strSQL, "TableName1", mDataSet)
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                '                        If Oratemp!compartments <= 0 Or Oratemp!compartments = Null Then Exit Sub
                ValCompTailer = IIf(IsDBNull(dt.Rows(0).Item("compartments")), 0, dt.Rows(0).Item("compartments"))
                StringCompTailer = dt.Rows(0).Item("comp_1") & "," & dt.Rows(0).Item("comp_2") & "," & dt.Rows(0).Item("comp_3") & ","
                StringCompTailer = StringCompTailer & dt.Rows(0).Item("comp_4") & "," & dt.Rows(0).Item("comp_5") & "," & dt.Rows(0).Item("comp_6") & ","
                StringCompTailer = StringCompTailer & dt.Rows(0).Item("comp_7") & "," & dt.Rows(0).Item("comp_8") & "," & dt.Rows(0).Item("comp_9") & ","
                StringCompTailer = StringCompTailer & dt.Rows(0).Item("comp_10") & "," & dt.Rows(0).Item("comp_11") & "," & dt.Rows(0).Item("comp_12") & ","
                StringCompTailer = StringCompTailer & dt.Rows(0).Item("comp_13") & "," & dt.Rows(0).Item("comp_14") & "," & dt.Rows(0).Item("comp_15") & ","
                StringCompTailer = StringCompTailer & dt.Rows(0).Item("comp_16") & "," & dt.Rows(0).Item("comp_17") & "," & dt.Rows(0).Item("comp_18") & ","
                StringCompTailer = StringCompTailer & dt.Rows(0).Item("comp_19") & "," & dt.Rows(0).Item("comp_20")
                CompTailer = Split(StringCompTailer, ",")
                With msGridComp
                    For i = 0 To UBound(CompTailer)
                        If CompTailer(i) <> 0 Then
                            ''.Rows.Add(.Rows.Count + 1)
                            '.RowCount = .RowCount + 1
                            'If .Rows.Count > 1 Then
                            '    .Rows.Add(.Rows.Count + 1)
                            'End If

                            '.Item(0, .Rows.Count + 1).Value = .RowCount + 1
                            '.Item(1, .Rows.Count + 1).Value = vTu22
                            '.Item(2, .Rows.Count + 1).Value = CompTailer(i)
                            .RowCount = .RowCount + 1
                            If .Rows.Count > 0 Then
                                .Item(0, .Rows.Count - 1).Value = .Rows.Count
                                .Item(1, .Rows.Count - 1).Value = vTu22
                                .Item(2, .Rows.Count - 1).Value = CompTailer(i)
                            End If
                        End If
                    Next i

                End With
            End If
        End If
        With msGridComp
            For i = 0 To .Rows.Count - 1
                txtSumCapComp.Text = Val(txtSumCapComp.Text) + Val(.Item(2, i).Value)
                'txtSumCapComp = Val(txtSumCapComp) + Val(.TextMatrix(i, 2))
            Next i
            txtTotalComp.Text = .Item(0, .Rows.Count - 1).Value
            'txtTotalComp.Text = .TextMatrix(.Rows - 1, 0)
        End With

    End Sub

    Private Function GetCountSeal() As Integer
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim Oraparam As New COraParameter
        Dim tmpSeal As Integer
        Dim tmpTu1() As String
        tmpSeal = 0
        Dim i As Integer = 0
        Dim dt As DataTable
        If cbTUHead.Text <> "" Then
            If InStr(1, cbTUHead.Text, "_") > 0 Then
                tmpTu1 = Split(cbTUHead.Text, "_")
                strSQL = " select t.fix_seal "
                strSQL = strSQL & " from tas.transport_unit t"
                strSQL = strSQL & " where t.tu_number ='" & Trim(tmpTu1(1)) & "' "


                If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                    dt = mDataSet.Tables("TableName1")
                    If dt.Rows.Count > 0 Then
                        tmpSeal = CInt(IIf(IsDBNull(dt.Rows(i).Item("fix_seal")), "", dt.Rows(i).Item("fix_seal").ToString))
                    End If
                End If
            End If
        End If
        If cbTail.Text <> "" Then
            If InStr(1, cbTail.Text, "_") > 0 Then
                tmpTu1 = Split(cbTail.Text, "_")
                strSQL = " select t.fix_seal "
                strSQL = strSQL & " from tas.transport_unit t"
                strSQL = strSQL & " where t.tu_number ='" & Trim(tmpTu1(1)) & "' "
                If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                    dt = mDataSet.Tables("TableName1")
                    If dt.Rows.Count > 0 Then
                        tmpSeal = tmpSeal + CInt(IIf(IsDBNull(dt.Rows(i).Item("fix_seal")), "", dt.Rows(i).Item("fix_seal").ToString))
                    End If
                End If
            End If
        End If


        If tmpSeal <> 0 Then
            GetCountSeal = tmpSeal
        Else
            GetCountSeal = 1
        End If
        frmUtlAddSeal.txtSealAmount.Text = GetCountSeal
    End Function

    Private Sub AddDo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDo.Click
        frmLoadDoList.Close()
        frmLoadDoList.frm_Request_txtdo = 0
        frmLoadDoList.ShowDialog()
    End Sub

    Private Sub cbCardBil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case Keys.Enter
                With dfindIncombo
                    .textKeyword.Text = cbCardBil.Text
                    .textKeyword.SelectionStart = Len(cbCardBil.Text)
                End With
        End Select
    End Sub

    Private Sub cbTail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If CheckHeadTail() Then
            MsgBox("ทะเบียนหัวลาก กับ ทะเบียนตัวพ่วงเป็นชื่อเดียวกัน", vbInformation)
            cbTail.Text = ""
            Exit Sub
            Select Case Asc(e.KeyChar)
                Case Keys.Enter
                    With dfindIncombo
                        .textKeyword.Text = cbTail.Text
                        .textKeyword.SelectionStart = Len(cbTail.Text)
                    End With
            End Select
        End If
    End Sub

    Private Function CheckHeadTail() As Boolean
        If Trim(cbTUHead.Text) = Trim(cbTail.Text) Then
            Return True
        End If
        Return False
    End Function

    Private Sub cbTUHead_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        GetDriver()
        GetTuTail()
        GetDetalComp()
    End Sub

    Private Sub cbTUHead_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case Keys.Enter
                With dfindIncombo
                    .textKeyword.Text = cbTUHead.Text
                    .textKeyword.SelectionStart = Len(cbTUHead.Text)
                End With
                cmdFindVechicle_Click(Nothing, Nothing)
        End Select
    End Sub

    Private Sub cmdCalSeal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCalSeal.Click
        frmUtlAddSeal.Close()
        GetCountSeal()
        frmUtlAddSeal.ShowDialog()
        'With frmUtlAddSeal
        '    ChkAutoSeal = True
        '    .txtSealAmount.Text = GetCountSeal()
        '    .ShowDialog()
        '    SealCountAuto = .GetSealCount
        '    SealLast = .GetSealLast
        '    txtSealNumber.Text = .GetSealNumber
        'End With
    End Sub

    Private Sub cmdFineCard_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdFineCard.Click
        'Initialcbcard()
        'dfindIncombo.AddComboToGrid(cbCardBil, Me, cbCardBil.SelectedIndex)
        dfindIncombo.Show()
        dfindIncombo.FindData(4, cbCardBil)
    End Sub

    Private Sub CmdFindDriver_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdFindDriver.Click
        'InitialcbDriver()
        'dfindIncombo.AddComboToGrid(cbDriverBil, Me, cbDriverBil.SelectedIndex)
        dfindIncombo.Show()
        dfindIncombo.FindData(1, cbDriverBil)
    End Sub

    Private Sub cmdFindVechicle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdFindVechicle.Click
        'InitialTransport()
        'dfindIncombo.AddComboToGrid(cbTUHead, Me, cbTUHead.SelectedIndex)
        dfindIncombo.Show()
        dfindIncombo.FindData(3, cbTUHead)
    End Sub

    Private Sub CmdFindVechcle2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdFindVechcle2.Click
        'InitialTransport()
        'dfindIncombo.AddComboToGrid(cbTail, Me, cbTail.SelectedIndex)
        dfindIncombo.Show()
        dfindIncombo.FindData(2, cbTail)
    End Sub
    Public Function GetSealLast()
        GetSealLast = SealLast
    End Function
    Private Sub cmdOldDetailVechicle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOldDetailVechicle.Click

        If cbTUHead.Text <> "" Then
            frmLoadOldDataVechicle.Close()
            With frmLoadOldDataVechicle
                .GetTuID(cbTUHead.Text)
            End With
            frmLoadOldDataVechicle.ShowDialog()
        End If
    End Sub

    Private Sub cmdrefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdrefresh.Click
        InitialCBbilling()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        If ProcessBilling() Then
            SealNumber = ""
            SealLast = ""
            SealCount = ""
            ChkAutoSeal = False
            Me.Close()
        End If
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdEditComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Load_no = "" Then
            MsgBox("ไม่ข้อมูลที่ต้องการแก้ไข ", vbInformation)
            Exit Sub
        End If

        'If Not P_HasConnected Then Exit Sub
        'ScreenID = 502
        'If Not GetAutherizeStatus(ScreenID, 0) Then Exit Sub
        'P_CurScreenID = ScreenID
        'With frmLoadLoading
        '    .Show() : Me.Hide()
        '    Call .GetParameterFrmCreate(Load_no, 1)
        '    .ImgLeftMenu_Click(2)
        'End With
    End Sub

    Private Sub CmdAddCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAddCard.Click
        If OpenForm(406, "Card") Then
            PushForm(Me)
            'Me.Hide()
        End If
    End Sub

    Private Sub CmdAdtruck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdtruck.Click
        If OpenForm(403, "Truck Oil") Then
            PushForm(Me)
            ' Me.Hide()
        End If
    End Sub

    Private Sub Cmdtruck1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmdtruck1.Click
        If OpenForm(403, "Truck Oil") Then
            PushForm(Me)
            'Me.Hide()
        End If
    End Sub

    Private Sub CmdAddDriver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAddDriver.Click
        If OpenForm(405, "Driver") Then
            PushForm(Me)
            'Me.Hide()
        End If
    End Sub

    Private Sub CmdAddDo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAddDo.Click
        If OpenForm(501, "Delivery Order") Then
            PushForm(Me)
            ' Me.Hide()
        End If
    End Sub

    Private Sub CmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDelete.Click

        cbCardBil.Text = ""
        cbTUHead.Text = ""
        cbTail.Text = ""
        cbDriverBil.Text = ""
        txtDo.Text = ""
        txtSealNumber.Text = ""

        txtTotalComp.Text = "0"
        txtSumCapComp.Text = "0"
        txtSealCount.Text = "0"
        ChkAutoSeal = False
        msGridComp = Nothing

        OvercbCardBil = ""
        OvercbTUHead = ""
        OvercbTail = ""
        OvercbDriverBil = ""
        OvertxtDo = ""
        OvertxtSealNumber = ""
    End Sub
    Private Sub UcHeader1_CloseButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub UcHeader1_MinimizeButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub UcBack1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub UcBack1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbCardBil_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCardBil.SelectedIndexChanged
        'SelectTruckOil()
        'SelectTuTail()
    End Sub
    Private Sub SelectTruckOil()
        Dim strSQL As String

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        strSQL = _
                     " select c.card_no,t.tu_number,t.tu_id,v.vehicle_id,v.tu_number1 " & _
                     " from card c,tas.transport_unit t,tas.vehicle v " & _
                     " where t.tu_number = c.tu_number " & _
                     " and t.tu_id = v.vehicle_id " & _
                     " and c.card_no = '" & Trim(cbCardBil.Text) & "'"

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                cbTUHead.Text = ""
                cbTUHead.Text = dt.Rows(0).Item("tu_id").ToString & "_" & dt.Rows(0).Item("tu_number").ToString
                cbTail.Text = dt.Rows(0).Item("tu_number1").ToString
            Else
                cbTUHead.Text = ""
                cbTail.Text = ""
                cbDriverBil.Text = ""
            End If
        End If
    End Sub
    Private Sub SelectTuTail()
        Dim strSQL As String

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        strSQL = _
                     " select t.tu_number,t.tu_id from tas.transport_unit t " & _
                     " where t.tu_number = '" & Trim(cbTail.Text) & "'"

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                cbTail.Text = ""
                cbTail.Text = dt.Rows(0).Item("tu_id").ToString & "_" & dt.Rows(0).Item("tu_number").ToString
            Else
                cbTail.Text = ""
            End If
        End If
    End Sub

    Private Sub cbTail_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTail.SelectedIndexChanged
        GetDetalComp()
    End Sub

    Private Sub cbTUHead_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTUHead.SelectedValueChanged

    End Sub

    Private Sub cmdCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCopy.Click
        OvercbCardBil = cbCardBil.Text
        OvercbTUHead = cbTUHead.Text
        OvercbTail = cbTail.Text
        OvercbDriverBil = cbDriverBil.Text
        'Over = DTPdate.Value
        'vClipOverride.cTime = DTPTime.Value
        OvertxtDo = txtDo.Text
        OvertxtSealNumber = txtSealNumber.Text
    End Sub

    Private Sub cmdPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPaste.Click
        cbTUHead.Text = OvercbTUHead
        cbTail.Text = OvercbTail
        cbDriverBil.Text = OvercbDriverBil
        txtDo.Text = OvertxtDo
        txtSealNumber.Text = OvertxtSealNumber
        cbCardBil.Text = OvercbCardBil
    End Sub

    Private Sub txtDo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDo.TextChanged
        CheckDoDetail()
        'SelectTruckDetail()
    End Sub
    Function CheckDoDetail() As Boolean
        Dim vCheck As Boolean = False
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim arrDo = Split(txtDo.Text, ",")
        Try

            strSQL = _
                " select t.tu_number,t.tu_id,v.vehicle_id,v.tu_number1,dr.first_name||'  '||dr.last_name ||'_'||  dr.driver_id    as  driver_Name " & _
                " from do_header d,tas.transport_unit t,tas.vehicle v,tas.driver dr " & _
                " where t.tu_number = d.truck_id1 " & _
                " and t.tu_id = v.vehicle_id " & _
                " and d.driver_id = dr.driver_id " & _
                " and d.do_NO = '" & Trim(arrDo(0)) & "'"

            If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                vCheck = True
                dt = mDataSet.Tables("TableName1")
                If dt.Rows.Count > 0 Then
                    cbTUHead.Text = ""
                    cbTUHead.Text = dt.Rows(0).Item("tu_id").ToString & " _" & dt.Rows(0).Item("tu_number").ToString
                    ' cbTail.Text = dt.Rows(0).Item("tu_number1").ToString
                    'cbDriverBil.Text = dt.Rows(0).Item("driver_Name").ToString
                    CheckCardNO(Trim(dt.Rows(0).Item("tu_number").ToString))
                Else
                    cbCardBil.Text = ""
                    'cbTUHead.Text = ""
                    'cbTail.Text = ""
                    'cbDriverBil.Text = ""
                End If
            End If
        Catch ex As Exception

        End Try
        Return vCheck
    End Function
    Private Sub CheckCardNO(ByVal tu_number As String)
        Dim vCheck As Boolean = False
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Try
            sql_str = " select c.card_no,c.tu_number,c.card_no,t.tu_id  from tas.card c,tas.transport_unit t  where c.card_type=0  and c.is_enabled=1and c.tu_number=t.tu_number(+)  "
            sql_str = sql_str & " and not exists(select  h.tu_card_no "
            sql_str = sql_str & " from  oil_load_entrycard  h where c.card_no=h.tu_card_no  ) "
            sql_str = sql_str & " and  c.tu_number = '" & tu_number & "' "
            sql_str = sql_str & " order by c.card_no "
            If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                If dt.Rows.Count > 0 Then
                    cbCardBil.Text = ""
                    cbCardBil.Text = Trim(dt.Rows(0).Item("card_no"))
                Else
                    cbCardBil.Text = ""
                    'cbTUHead.Text = ""
                    'cbTail.Text = ""
                    'cbDriverBil.Text = ""
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancle.Click
        Me.Close()
    End Sub

    Private Sub cbTUHead_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTUHead.SelectedIndexChanged
        GetDriver()
        GetTuTail()
        GetDetalComp()
        'cbDriverBil.Text = ""
        'Dim strSQL As String
        ''Dim Oratemp As OraDynaset
        'Dim tmpTransUnit() As String
        'Dim tmp1, tmp2 As String

        'If cbTUHead.Text = "" Then Exit Sub
        'If CheckHeadTail() Then
        '    MsgBox(" ทะเบียนหัวลาก กับ ทะเบียนตัวพ่วงเป็นชื่อเดียวกัน ", vbInformation)
        '    cbTail.Text = ""
        '    Exit Sub
        'End If
        'tmpTransUnit = Split(cbTUHead.Text, "_")
        'tmp1 = Trim(tmpTransUnit(1))


        'strSQL = _
        ' " select v.vehicle_number,dm.driver_id ,d.first_name,d.last_name , d.first_name ||' '|| d.last_name||' _'||d.driver_id as driver  " & _
        ' " from tas.vehicle v , tas.driver_mapping  dm , tas.driver d " & _
        ' " Where v.Vehicle_Number = dm.Vehicle_Number  " & _
        '" and d.driver_id = dm.driver_id " & _
        '" and v.tu_number='" & tmp1 & "' "

        'Dim mDataSet As New DataSet
        'Dim dt As DataTable
        'Dim i As Integer = 0
        'Dim TxtDriverName = ""
        'If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
        '    dt = mDataSet.Tables("TableName1")
        '    If dt.Rows.Count > 0 Then
        '        cbDriverBil.Text = ""
        '        cbDriverBil.Text = IIf(IsDBNull(dt.Rows(i).Item("driver")), "", dt.Rows(i).Item("driver").ToString)
        '        TxtDriverName = Trim(Mid(cbDriverBil.Text, 1, (InStr(1, cbDriverBil.Text, "_")) - 1))
        '    End If

        '    'Return True
        'End If
        'mDataSet = Nothing
        'GetTuTail()
        'GetDetalComp()
    End Sub
    Private Sub SelectTruckDetail()
        'cbTu_Tail.Text = ""
        cbDriverBil.Text = ""
        Dim strSQL As String
        'Dim Oratemp As OraDynaset
        Dim tmpTransUnit() As String
        Dim tmp1, tmp2 As String

        If cbTUHead.Text = "" Then Exit Sub
        If CheckHeadTail() Then
            MsgBox(" ทะเบียนหัวลาก กับ ทะเบียนตัวพ่วงเป็นชื่อเดียวกัน ", vbInformation)
            cbTail.Text = ""
            Exit Sub
        End If
        tmpTransUnit = Split(cbTUHead.Text, "_")
        tmp1 = Trim(tmpTransUnit(1))


        strSQL = _
         " select v.vehicle_number,dm.driver_id ,d.first_name,d.last_name , d.first_name ||' '|| d.last_name||' _'||d.driver_id as driver  " & _
         " from tas.vehicle v , tas.driver_mapping  dm , tas.driver d " & _
         " Where v.Vehicle_Number = dm.Vehicle_Number  " & _
        " and d.driver_id = dm.driver_id " & _
        " and v.tu_number='" & tmp1 & "' "

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        Dim TxtDriverName = ""
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                cbDriverBil.Text = ""
                cbDriverBil.Text = IIf(IsDBNull(dt.Rows(i).Item("driver")), "", dt.Rows(i).Item("driver").ToString)
                TxtDriverName = Trim(Mid(cbDriverBil.Text, 1, (InStr(1, cbDriverBil.Text, "_")) - 1))
            End If

            'Return True
        End If
        mDataSet = Nothing
        'GetTuTail()
        'GetDetalComp()
    End Sub


    Private Sub btEditVolumeDo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btEditVolumeDo.Click
        If txtDo.Text <> "" Then
            frmLoadEditVolumeDo.Do_NO = txtDo.Text
            frmLoadEditVolumeDo.ShowDialog()
        End If
    End Sub
End Class