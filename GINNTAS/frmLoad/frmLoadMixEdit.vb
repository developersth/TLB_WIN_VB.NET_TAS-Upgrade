Public Class frmLoadMixEdit

  
    Private Sub frmLoadMixEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
    End Sub

    Private Sub UcMenuRefresh_OnClickMnuText(ucName As String, ucScreenID As Long) Handles UcMenuRefresh.OnClickMnuText
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
    End Sub

    Private Sub UcMenutxtSub1_OnClickMnuText(ucName As String, ucScreenID As Long) Handles UcMenutxtSub1.OnClickMnuText
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
        GroupBox3.Enabled = False
        GroupBox4.Enabled = False
    End Sub

    Private Sub UcMenutxtSub2_OnClickMnuText(ucName As String, ucScreenID As Long) Handles UcMenutxtSub2.OnClickMnuText
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = True
        GroupBox4.Enabled = False
    End Sub
    Public Sub InitialCBbilling(ByVal iLoad_no As String)
        Call Initialcbcard()
        txtCardBilOle.Text = getOldCard(iLoad_no)
        txtLoad_No.Text = iLoad_no
        'ChangDriver
        initailCbDriver()
        txtDriveOld.Text = getOldDriver(iLoad_no)
        'ChangTu
        initailCbCar()
        txtTuHeadOld.Text = getOldTu(iLoad_no)
        cbTuHead.Text = getOldTu(iLoad_no)
        'txtTuHeadNew.Text = txtTuHeadOld.Text
        txtTuTailOld.Text = getOldTu1(iLoad_no)
        cbTuTail.Text = getOldTu1(iLoad_no)
        txtStatusOld.Text = getOldStatus(iLoad_no)
        ' txtTuTailNew.Text = txtTuTailOld.Text
    End Sub
    Private Function getOldTu(iLoad_no As String) As String
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim TRUCK_ID1 As String
        strSQL = _
                    " select T.TU_NUMBER  " & _
                    " from OIL_LOAD_HEADERS T where T.load_header_no='" & Trim(iLoad_no) & "'  "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                TRUCK_ID1 = IIf(IsDBNull(dt.Rows(0).Item("TU_NUMBER").ToString), "", dt.Rows(0).Item("TU_NUMBER").ToString)
                strSQL = _
                    "select T.TU_ID,T.TU_NUMBER,T.TU_ID||' - '||T.TU_NUMBER AS TuNAME " & _
                    " from TRANSPORT_UNIT T where TU_NUMBER = '" & TRUCK_ID1 & "' "
                If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                    dt = mDataSet.Tables("TableName1")
                    getOldTu = IIf(IsDBNull(dt.Rows(0).Item("tUname").ToString), "", dt.Rows(0).Item("tUname").ToString)
                End If
            Else
                getOldTu = ""
            End If
        End If
        mDataSet = Nothing
    End Function
    Private Function getOldTu1(iLoad_no As String) As String
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim TRUCK_ID1 As String
        strSQL = _
                    " select T.TU_NUMBER1  " & _
                    " from OIL_LOAD_HEADERS T where T.load_header_no='" & Trim(iLoad_no) & "'  "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                TRUCK_ID1 = IIf(IsDBNull(dt.Rows(0).Item("TU_NUMBER1").ToString), "", dt.Rows(0).Item("TU_NUMBER1").ToString)
                strSQL = _
                    "select T.TU_ID,T.TU_NUMBER,T.TU_ID||' - '||T.TU_NUMBER AS TuNAME " & _
                    " from TRANSPORT_UNIT T where TU_NUMBER = '" & TRUCK_ID1 & "' "
                If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                    dt = mDataSet.Tables("TableName1")
                    If dt.Rows.Count > 0 Then
                        getOldTu1 = IIf(IsDBNull(dt.Rows(0).Item("tUname").ToString), "", dt.Rows(0).Item("tUname").ToString)
                    Else
                        getOldTu1 = ""
                    End If
                End If
            Else
                getOldTu1 = ""
            End If
        End If
        mDataSet = Nothing
    End Function
    Private Sub initailCbCar()
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        strSQL = _
             "select T.TU_ID,T.TU_NUMBER,T.TU_ID||' - '||T.TU_NUMBER AS TuNAME " & _
             " from TRANSPORT_UNIT T order by T.Tu_Id,T.TU_NUMBER "
 
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                With cbTuHead
                    .Items.Clear()
                    For Each dr As DataRow In dt.Rows
                        .Items.Add(dr.Item("tUname").ToString())
                    Next
                End With
                With cbTuTail
                    .Items.Clear()
                    For Each dr As DataRow In dt.Rows
                        .Items.Add(dr.Item("tUname").ToString())
                    Next
                End With
            End If
        End If
        mDataSet = Nothing

    End Sub
    Private Sub ChangeDriver(iLoad_no As String)
        initailCbDriver()
        txtDriveOld.Text = getOldDriver(iLoad_no)
    End Sub
    Private Function getOldDriver(iLoad_no As String) As String
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        strSQL = _
                    " select  t.driver_name from oil_load_headers t " & _
                    " where t.load_header_no='" & Trim(iLoad_no) & "' "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                getOldDriver = IIf(IsDBNull(dt.Rows(0).Item("driver_name").ToString), "-", dt.Rows(0).Item("driver_name").ToString)
            End If
        End If
        mDataSet = Nothing
    End Function
    Private Sub initailCbDriver()
        Dim strSQL As String
        Dim tmpCard As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        strSQL = "select d.driver_id, d.first_name ||' '|| d.last_name  as DriverName,d.first_name ||' '|| d.last_name||' _'||d.driver_id as driver from driver   d  "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            With cbDrive
                .Items.Clear()
                For Each dr As DataRow In dt.Rows
                    .Items.Add(dr.Item("driver").ToString())
                Next
            End With
        End If
        mDataSet = Nothing
    End Sub
    Private Function getOldCard(iLoad_no As String) As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim strSQL As String
        getOldCard = "-"
        strSQL = _
                    "select  t.tu_card_no " & _
                    " from tas.oil_load_headers  t " & _
                    " where t.load_header_no='" & Trim(iLoad_no) & "' " & _
                    " and t.cancel_status=0 "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                getOldCard = dt.Rows(0).Item("tu_card_no").ToString()
            End If
        End If
        mDataSet = Nothing
    End Function
    Private Sub Initialcbcard()
        Dim strSQL As String
        Dim tmpCard As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        tmpCard = ""
        tmpCard = cbCardBil.Text
        strSQL = " select c.card_no from tas.card c,tas.transport_unit t  where c.card_type=0  and c.is_enabled=1and c.tu_number=t.tu_number(+)  " & _
                               " and not exists(select  h.tu_card_no " & _
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
        mDataSet = Nothing
    End Sub
    Private Function getOldStatus(iLoad_no As String) As String
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim vLoadStatus As String = String.Empty
        strSQL =
                    " select T.LOAD_STATUS  " &
                    " from OIL_LOAD_HEADERS T where T.load_header_no='" & Trim(iLoad_no) & "'  "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                vLoadStatus = IIf(IsDBNull(dt.Rows(0).Item("LOAD_STATUS").ToString), "", dt.Rows(0).Item("LOAD_STATUS").ToString)
            End If
        End If
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing

        Return vLoadStatus
    End Function
    Private Sub btCardSave_Click(sender As Object, e As EventArgs) Handles btCardSave.Click
        P_ChangeCard(txtLoad_No.Text)
    End Sub

    Private Sub P_ChangeCard(iLoad_no As String)
        Dim strSQL As String
        If cbCardBil.Text = "" Or cbCardBil.Text = "-" Then
            MsgBox("ท่านยังไม่ใส่หมายเลขบัตร", vbInformation)
            Exit Sub
        End If
        If Not ChkCardInDB(Trim(cbCardBil.Text)) Then
            MsgBox("ไม่พบหมายเลขบัตร หรืออาจจะอยู่ในกระบวนการจ่าย กรุณาเลือกใหม่อีกครั้ง", vbInformation)
            Exit Sub
        End If
        If MsgBox("ท่านต้องการบันทึกข้อมูลหรือไม่", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If

        strSQL = "begin  tas.PROC_CHANGE_LOAD_CARD( '" & iLoad_no & "','" & Trim(cbCardBil.Text) & "'); end;"
        If Oradb.ExeSQL(strSQL) Then
            txtCardBilNew.Text = getOldCard(iLoad_no)
            MsgBox("complete ")
            Call AddJournal(JournalType.Jevent, 502, 100, mUserName, 502212, Trim(iLoad_no), Trim(txtCardBilOle.Text), Trim(txtCardBilNew.Text))
        End If
    End Sub
    Private Function ChkCardInDB(iCard As String) As Boolean
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        strSQL = _
                    " select c.card_no from tas.card c,tas.transport_unit t  where c.card_type=0  and c.is_enabled=1and c.tu_number=t.tu_number(+)  " & _
                    " and not exists(select  h.tu_card_no " & _
                    " from  oil_load_entrycard  h where c.card_no=h.tu_card_no  )  and c.card_no ='" & Trim(iCard) & "' order by c.card_no "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                ChkCardInDB = True
            End If
        End If
        mDataSet = Nothing
    End Function

    Private Sub btCardCancel_Click(sender As Object, e As EventArgs) Handles btCardCancel.Click
        GroupBox1.Enabled = False
    End Sub

    Private Sub btDriverCancel_Click(sender As Object, e As EventArgs) Handles btDriverCancel.Click
        GroupBox2.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btTuCancel.Click
        GroupBox3.Enabled = False
    End Sub

    Private Sub btDriverSave_Click(sender As Object, e As EventArgs) Handles btDriverSave.Click
        P_ChangeDriver(txtLoad_No.Text)
    End Sub
    Private Sub P_ChangeDriver(iLoad_no As String)
        Dim strSQL As String
        Dim tmpDriver() As String

        If cbDrive.Text = "" Or cbDrive.Text = "-" Then
            MsgBox("ไม่พบพนักงานขับรถ กรุณาเลือกพนักงานขับรถ", vbInformation)
            Exit Sub
        End If
        If InStr(cbDrive.Text, "_") = 0 Then
            MsgBox("รูปแบบข้อมูลไม่ถูกต้อง กรุณาเลือกข้อมูลจากลิสท์", vbInformation)
            Exit Sub
        End If

        tmpDriver = Split(cbDrive.Text, "_")
        If Not ChkDriverInDB(tmpDriver(1)) Then
            MsgBox("'ไม่พบพนักขับรถชื่อ '" & tmpDriver(0) & "'กรุณาเลือกใหม่อีกครั้ง'", vbInformation)
            Exit Sub
        End If
        If MsgBox("ท่านต้องการบันทึกข้อมูลหรือไม่?", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If

        strSQL = "begin  tas.PROC_CHANGE_LOAD_DRIVER( '" & iLoad_no & "','" & Trim(tmpDriver(1)) & "'); end;"
        If Oradb.ExeSQL(strSQL) Then
            txtDriveNew.Text = getOldDriver(iLoad_no)
            MsgBox("complete ")
            Call AddJournal(JournalType.Jevent, 502, 100, mUserName, 502213, Trim(txtLoad_No.Text), Trim(txtDriveOld.Text), Trim(txtDriveNew.Text))
        End If
    End Sub
    Private Function ChkDriverInDB(IDriverID As String) As Boolean
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        ChkDriverInDB = False
        strSQL = _
                    " select d.first_name " & _
                    " from tas.driver    d " & _
                    " where  d.driver_id = '" & Trim(IDriverID) & "' "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                ChkDriverInDB = True
            End If
        End If
        mDataSet = Nothing
    End Function
    Private Sub btTuSave_Click(sender As Object, e As EventArgs) Handles btTuSave.Click
        ProcChangeCar(txtLoad_No.Text)
    End Sub
    Private Sub ProcChangeCar(iLoad_no As String)
        Dim strSQL As String
        Dim sArray() As String
        Dim sArray1() As String
        Dim mTu As String
        Dim mTu1 As String

        If cbTuHead.Text = "" Then
            MsgBox("ไม่พบหมายเลขทะเบียนที่ต้องการเปลี่ยน ", vbInformation)
            Exit Sub
        End If

        If MsgBox("ท่านต้องการบันทึกข้อมูลหรือไม่?", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If

        mTu = ""
        mTu1 = ""
        If Len(cbTuHead.Text) > 0 Then
            sArray = Split(cbTuHead.Text, " - ")
            mTu = sArray(1)
        End If

        If Len(cbTuTail.Text) > 0 Then
            sArray1 = Split(cbTuTail.Text, " - ")
            mTu1 = sArray1(1)
        End If

        strSQL = "begin  tas.PROC_CHANGE_VEHICLE( '" & iLoad_no & "','" & Trim(mTu) & "','" & Trim(mTu1) & "'); end;"
        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("complete ")
            txtTuHeadNew.Text = cbTuHead.Text
            txtTuTailNew.Text = cbTuTail.Text
        End If

    End Sub

    Private Sub UcMenutxtSub3_OnClickMnuText(ucName As String, ucScreenID As Long) Handles UcMenutxtSub3.OnClickMnuText
        Call ForceBaseOilComPlete(txtLoad_No.Text)
    End Sub
    Private Sub ForceBaseOilComPlete(iLoad_no As String)
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        If MsgBox("ท่านแน่ใจว่าต้องการอัพเดทสถานะเป็นเติมสมบูรณ์ของ Load No " & iLoad_no & " หรือไม่ ?", vbYesNo) = vbNo Then
            Exit Sub
        End If
        strSQL =
                        " select  t.is_weight_process , t.is_load_process , t.cancel_status , t.load_status " &
                        " from tas.oil_load_headers t " &
                        " where  t.load_header_no ='" & Trim(iLoad_no) & "' "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                If CInt(dt.Rows(0).Item("cancel_status")) = 0 And CInt(dt.Rows(0).Item("load_status")) = 54 Then
                    If UpdateStatus(CLng(iLoad_no)) Then
                        MsgBox("Update สถานะเติมสมบูรณ์แล้ว")
                        Call AddJournal(JournalType.Jevent, 502, 100, mUserName, 502211, Trim(iLoad_no))
                    End If
                Else
                    MsgBox("ไม่สามารถ Update สถานะได้")
                    Exit Sub
                End If
            End If
        End If
        mDataSet = Nothing
    End Sub
    Private Sub ForceLoadStatus(iLoad_no As String, iStatus As String)
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        If MsgBox("ท่านแน่ใจว่าต้องการอัพเดทสถานะ Load No " & iLoad_no & " หรือไม่ ?", vbYesNo) = vbNo Then
            Exit Sub
        End If
        strSQL =
                        " select  t.is_weight_process , t.is_load_process , t.cancel_status , t.load_status " &
                        " from tas.oil_load_headers t " &
                        " where  t.load_header_no ='" & Trim(iLoad_no) & "' "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                If CInt(dt.Rows(0).Item("cancel_status")) = 0 Then
                    If UpdateLoadStatus(CLng(iLoad_no), CInt(iStatus)) Then
                        MsgBox("Update สถานะเติมสมบูรณ์แล้ว")
                        Call AddJournal(JournalType.Jevent, 502, 100, mUserName, 502211, Trim(iLoad_no))
                    End If
                Else
                    MsgBox("ไม่สามารถ Update สถานะได้")
                    Exit Sub
                End If
            End If
        End If
        mDataSet = Nothing
    End Sub
    Private Function UpdateStatus(ILoadNo As Long) As Boolean
        Dim strSQL As String
        strSQL =
                        "begin " &
                        " load.OVERRIDE_LOAD_HEADER_COMPLETE (" &
                        ILoadNo & ",'" & mUserName & "','" & mComputerName & "'); " &
                        "end;"
        UpdateStatus = Oradb.ExeSQL(strSQL)
    End Function
    Private Function UpdateLoadStatus(iLoadNo As Long, iStatus As Integer) As Boolean
        Dim strSQL As String
        strSQL =
                        "begin " &
                        " TAS.P_FORCE_LOAD_STATUS(" &
                        iLoadNo & "," & iStatus & ",'" & mUserName & "','" & mComputerName & "',:ret_check,:ret_msg); " &
                        "end;"

        Dim Oraparam As New COraParameter
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_CHECK", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With
        Dim bRet As Boolean = False
        If Oradb.ExeSQL(strSQL, Oraparam) Then
            RET_CHECK = Oraparam.GetOraclParamValue("RET_CHECK")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            If Oraparam.GetOraclParamValue("RET_CHECK") = 0 Then
                MsgBox(Oraparam.GetOraclParamValue("RET_MSG").ToString, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                bRet = True
            Else
                MsgBox(Oraparam.GetOraclParamValue("RET_MSG").ToString, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                bRet = False
            End If

        End If
        Return bRet
    End Function

    Private Sub btLoadSave_Click(sender As Object, e As EventArgs) Handles btLoadSave.Click
        Dim tmpLoadStatus() As String



        tmpLoadStatus = Split(cmbStatusNew.Text, "-")
        ForceLoadStatus(txtLoad_No.Text, tmpLoadStatus(0))

    End Sub
    Function assignDropDown() As Boolean
        Dim sql_str As String
        sql_str =
        "select TYPE_ID,TYPE_NAME " &
        "from v_load_status  " &
        "order by TYPE_ID "
        assignDropDown(sql_str, "TYPE_ID", "TYPE_NAME", cmbStatusNew)
        Return True
    End Function
    Function assignDropDown(ByVal sql_str As String, ByVal colName1 As String, ByVal colName2 As String, ByVal cb As System.Object) As Boolean
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Dim temCb As String
            Do While dt.Rows.Count > i
                temCb = IIf(IsDBNull(dt.Rows(i).Item(colName1)), "", dt.Rows(i).Item(colName1).ToString) & " - " & IIf(IsDBNull(dt.Rows(i).Item(colName2)), "", dt.Rows(i).Item(colName2).ToString)
                If Not cb.Items.Contains(temCb) Then
                    cb.Items.Add(temCb)
                End If
                i = i + 1
            Loop
            Return True
        End If
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
        Return True
    End Function

    Private Sub UcMenutxtSub4_OnClickMnuText(ucName As String, ucScreenID As Long) Handles UcMenutxtSub4.OnClickMnuText
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        GroupBox4.Enabled = True
        assignDropDown()
    End Sub


End Class