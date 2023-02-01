
Imports System.Data
Imports System.Threading
Public Class frmLoadLoading
    Public FormScreenID As Long
    Dim frm_work As Integer = 0  '1=add ,2=Edit
    Public RemarkCancelOK As Boolean

    Private Sub frmLoadDO_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmLoadLoading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        If frm_work = 1 Then
            Me.Text = "Loading # Add"
        ElseIf frm_work = 2 Then
        End If

        Initial_frm()
        assignDropDown()
        Show_Data()
        resolution(Me, 1)
    End Sub

    Private Sub frmLoadLoading_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub

    Private Sub Initial_frm()
        PickerDate_Start.Value = Date.Today
        PickerTime_Start.Value = Convert.ToDateTime(PickerTime_Start.Value.Date.ToLongDateString & " " & "00:00:00")
        PickerDate_Stop.Value = Date.Today
        PickerTime_Stop.Value = Now

        cmbStatus.Text = "ALL"
        tas.BackColor = Color.Coral
        oe.BackColor = Color.PaleGoldenrod
        sap.BackColor = Color.Lime
    End Sub

    Public Sub Show_Data()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i, j As Integer

        Dim strDateStart = PickerDate_Start.Value.ToString.Split(" ")
        Dim dateStart = strDateStart(0)
        Dim strTimeStart = PickerTime_Start.Value.ToString.Split(" ")
        Dim timeStart = strTimeStart(1)
        Dim strDateEnd = PickerDate_Stop.Value.ToString.Split(" ")
        Dim dateEnd = strDateEnd(0)
        Dim strTimeEnd = PickerTime_Stop.Value.ToString.Split(" ")
        Dim timeEnd = strTimeEnd(1)

        Dim dtpChoosDate = dateStart & " " & timeStart
        Dim dtpTodate = dateEnd & " " & timeEnd

        Dim strCBStatus, s
        If cmbStatus.Text = "" Or Trim(cmbStatus.Text) = "ALL" Then
            strCBStatus = ""
        Else
            s = Split(cmbStatus.Text, " - ")
            strCBStatus = " and t.status_number=" & s(0) & " "
        End If

        sql_str = "select  t.* from view_truck_loading t"
        sql_str = sql_str & " where t.columns_name='LOAD_STATUS'   " & strCBStatus & "  "
        sql_str = sql_str & " and  trunc(t.EOD_DATE) BETWEEN to_date('" & dateStart & "','dd/mm/yyyy ') AND to_date('" & dateEnd & "','dd/mm/yyyy ')  "
        sql_str = sql_str & " and t.status_number=t.load_status "
        sql_str = sql_str & "  and t.status_send=t.type_id "
        sql_str = sql_str & " order by t.""Load No."" desc"

        If Oradb.OpenDys(sql_str, "view_truck_loading", mDataSet) Then
            dt = mDataSet.Tables("view_truck_loading")
            'MSGridHeader.RowCount = 0
            MSGridHeader.DataSource = dt
            txtToHeader.Text = dt.Rows.Count
            If dt.Rows.Count > 0 Then
                'Do While dt.Rows.Count > i
                For i = 0 To MSGridHeader.ColumnCount - 1
                    Dim col As New DataGridViewColumn
                    col = MSGridHeader.Columns(i)
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Next
                For i = 0 To MSGridHeader.Rows.Count - 1
                    MSGridHeader.Item(0, i).Value = i + 1

                    Dim strSourceType = MSGridHeader.Rows(i).Cells(3).Value.ToString
                    If strSourceType = "TAS" Then
                        'TAS
                        MSGridHeader.Rows(i).Cells(3).Style.BackColor = Color.Coral
                    ElseIf strSourceType = "OE" Then
                        'OE
                        MSGridHeader.Rows(i).Cells(3).Style.BackColor = Color.PaleGoldenrod
                    ElseIf strSourceType = "SAP" Then
                        'SAP
                        MSGridHeader.Rows(i).Cells(3).Style.BackColor = Color.Lime
                    End If

                    Dim StatusSAP() As String = Split(MSGridHeader.Rows(i).Cells(5).Value.ToString, "-")
                    If (MSGridHeader.Rows(i).Cells(23).Value.ToString = "ยกเลิก") Then
                        For j = 0 To MSGridHeader.Columns.Count - 1
                            MSGridHeader.Rows(i).Cells(j).Style.ForeColor = Color.Red
                        Next
                    ElseIf StatusSAP(0) = "1" Then
                        For j = 0 To MSGridHeader.Columns.Count - 1
                            MSGridHeader.Rows(i).Cells(j).Style.ForeColor = Color.Green
                        Next
                    Else
                        For j = 0 To MSGridHeader.Columns.Count - 1
                            MSGridHeader.Rows(i).Cells(j).Style.ForeColor = Color.Black
                        Next
                    End If
                Next
            Else
            End If
        End If
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub

    Function assignDropDown() As Boolean
        Dim sql_str As String
        sql_str = _
        "select TYPE_ID,TYPE_NAME " & _
        "from v_load_status  " & _
        "order by TYPE_ID "
        assignDropDown(sql_str, "TYPE_ID", "TYPE_NAME", cmbStatus)
        Return True
    End Function

    Function assignDropDown(ByVal sql_str As String, ByVal colName As String, ByVal cb As System.Object) As Boolean
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Dim temCb As String
            Do While dt.Rows.Count > i
                temCb = IIf(IsDBNull(dt.Rows(i).Item(colName)), "", dt.Rows(i).Item(colName).ToString)
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

    Function assignDropDown(ByVal sql_str As String, ByVal colName1 As String, ByVal colName2 As String, ByVal cb As System.Object) As Boolean
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Dim temCb As String
            cb.Items.Add("ALL")
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

    Private Sub ShowFlexGridLine(ByVal LoadNo As Long)
        Dim strSQL As String

        strSQL = "SELECT L.SHIPMENT_NO,L.BATCH_NO,L.DO_NO,L.COMPARTMENT_NO,L.FLOWRATE_AVG,"
        strSQL = strSQL & " L.TOT_GROSS_START,L.TOT_GROSS_STOP,L.TU_ID,L.METER_NO, "
        strSQL = strSQL & " L.SALE_PRODUCT_ID||' - '||L.SALE_PRODUCT_NAME as PRODUCT,L.PRESET,L.LOADED_GROSS,"
        strSQL = strSQL & " L.METER_NO,L.TEMP,L.API60F,L.VCF30C,"
        strSQL = strSQL & " L.LOADED_NET,L.T_START,L.UNIT,L.DESITY15C,L.LOADED_VOLOBS,L.LOADED_VOL15C,L.LOADED_VOL30C,L.LOADED_MASS,"
        strSQL = strSQL & " L.T_STOP,L.TANK_NAME,L.T_START,L.T_STOP,L.DESCRIPTION"
        strSQL = strSQL & " FROM OIL_LOAD_LINES L"
        strSQL = strSQL & " WHERE L.LOAD_HEADER_NO=" & LoadNo & "  ORDER BY L.COMPARTMENT_NO"

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            MSGridLine.RowCount = 0
            Do While dt.Rows.Count > i
                MSGridLine.RowCount = MSGridLine.RowCount + 1
                'MSGridLine.Item(0, i).Value = i
                MSGridLine.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("COMPARTMENT_NO")), "", dt.Rows(i).Item("COMPARTMENT_NO").ToString)
                MSGridLine.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DO_NO")), "", dt.Rows(i).Item("DO_NO").ToString)
                MSGridLine.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("BATCH_NO")), "", dt.Rows(i).Item("BATCH_NO").ToString)
                MSGridLine.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TU_ID")), "", dt.Rows(i).Item("TU_ID").ToString)
                MSGridLine.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PRODUCT")), "", dt.Rows(i).Item("PRODUCT").ToString)
                MSGridLine.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("METER_NO")), "", dt.Rows(i).Item("METER_NO").ToString)
                MSGridLine.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("FLOWRATE_AVG")), "", dt.Rows(i).Item("FLOWRATE_AVG").ToString)
                MSGridLine.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TANK_NAME")), "", dt.Rows(i).Item("TANK_NAME").ToString)
                MSGridLine.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PRESET")), "", dt.Rows(i).Item("PRESET").ToString)
                MSGridLine.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UNIT")), "", dt.Rows(i).Item("UNIT").ToString)
                MSGridLine.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TEMP")), "", dt.Rows(i).Item("TEMP").ToString)
                MSGridLine.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DESITY15C")), "", dt.Rows(i).Item("DESITY15C").ToString)
                MSGridLine.Item(12, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOADED_GROSS")), "", dt.Rows(i).Item("LOADED_GROSS").ToString())
                MSGridLine.Item(13, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOADED_VOLOBS")), "", dt.Rows(i).Item("LOADED_VOLOBS").ToString)
                MSGridLine.Item(14, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOADED_VOL15C")), "", dt.Rows(i).Item("LOADED_VOL15C").ToString)
                MSGridLine.Item(15, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOADED_VOL30C")), "", dt.Rows(i).Item("LOADED_VOL30C").ToString)
                MSGridLine.Item(16, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOADED_MASS")), "", dt.Rows(i).Item("LOADED_MASS").ToString)
                MSGridLine.Item(17, i).Value = IIf(IsDBNull(dt.Rows(i).Item("VCF30C")), "", dt.Rows(i).Item("VCF30C").ToString)
                MSGridLine.Item(18, i).Value = IIf(IsDBNull(dt.Rows(i).Item("T_START")), "", dt.Rows(i).Item("T_START").ToString)
                MSGridLine.Item(19, i).Value = IIf(IsDBNull(dt.Rows(i).Item("T_STOP")), "", dt.Rows(i).Item("T_STOP").ToString)
                MSGridLine.Item(20, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION").ToString)

                i = i + 1
            Loop
            textTotLine.Text = i
        Else
        End If
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing

    End Sub

    Private Sub MSGridHeader_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MSGridHeader.CellClick
        If MSGridHeader.RowCount > 0 Then
            Dim index As Integer = MSGridHeader.CurrentRow.Index
            ShowFlexGridLine(MSGridHeader.Rows(index).Cells(1).Value.ToString)

        End If
    End Sub

    Private Sub b_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Search.Click
        Dim strColume As String
        If MSGridHeader.Rows.Count <= 0 Then Exit Sub
        With MSGridHeader
            strColume = .Item(1, .CurrentRow.Index).Value
        End With
        frmFind.Close()
        frmFind.InitialFormFind(MSGridHeader, 1)
        frmFind.ShowDialog()

    End Sub

    Private Sub b_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub b_Add_Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'frmLoadCreateLoad.FormScreenID = Me.FormScreenID
        'frmLoadCreateLoad.ShowDialog()
    End Sub

    Private Sub b_Edit_Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'frmLoadCreateLoad.AE_LoadNo = MSGridHeader.Rows(MSGridHeader.CurrentRow.Index).Cells(1).Value.ToString()
        'frmLoadCreateLoad.ShowDialog()
    End Sub

    Private Sub b_Del_Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub b_edit_Seal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub b_CreateShipment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub b_BypassShipment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub b_Send_to_SAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub b_Resend_All_to_SAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub b_Export_file_to_Oilsys_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStatus.SelectedIndexChanged
        Show_Data()
    End Sub

    Private Sub CancelLoadHeader(ByVal pLoadNo As String, ByVal pComment As String, ByVal pUser As String, ByVal pComputer As String)
        Dim strSQL As String
        Dim vCheck As Long
        On Error Resume Next

        strSQL = "BEGIN "
        strSQL = strSQL & " LOAD.cancel_load_header("
        strSQL = strSQL & pLoadNo
        strSQL = strSQL & ",'"
        strSQL = strSQL & pComment
        strSQL = strSQL & "','"
        strSQL = strSQL & pUser
        strSQL = strSQL & "','"
        strSQL = strSQL & pComputer
        strSQL = strSQL & "',:iRET_CHECK"
        strSQL = strSQL & ",:iRET_MSG); "
        strSQL = strSQL & "END;"

        Dim Oraparam As New COraParameter
        Dim iRET_CHECK As Object
        Dim iRET_MSG As Object
        With Oraparam

            .CreateOracleParamOutput("iRET_CHECK", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("iRET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With

        If Oradb.ExeSQL(strSQL, Oraparam) Then
            vCheck = IIf((Oraparam.GetOraclParamValue("iRET_CHECK").value >= 0), True, False)
            If vCheck Then
                MsgBox(Oraparam.GetOraclParamValue("iRET_MSG").value, vbInformation)
            Else
                MsgBox(Oraparam.GetOraclParamValue("iRET_MSG").value, vbCritical, "เกิดข้อผิดพลาด")
            End If
        End If

    End Sub

    Private Sub UpdateSealControlCancle(ByVal ILoadNo As String)
        On Error Resume Next
        Dim strSQL As String

        strSQL = "UPDATE TAS.seal_control t SET t.load_last_no='" & Trim(ILoadNo) & "' ,"
        strSQL = strSQL & " t.seal_no='" & 1 & "'"
        strSQL = strSQL & " Where t.id=1 "
        Oradb.ExeSQL(strSQL)
    End Sub

    Private Sub CreateShipment()
        Dim strSQL As String
        Dim vCheck As Boolean
        If MSGridHeader.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = MSGridHeader.CurrentRow.Index
        Dim pLoadNo As String = Trim(MSGridHeader.Rows(index).Cells(1).Value.ToString)

        If MsgBox("คุณต้องการ Resent ขอ Shipment หมายเลข Load No " & pLoadNo & " ? ", vbOKCancel + vbInformation) = vbCancel Then Exit Sub

        If Trim(MSGridHeader.Rows(index).Cells(23).Value.ToString) = "ยกเลิก" Then
            MsgBox("ไม่สามารถ Resent ขอ Shipment ได้ เนื่องจากหมายเลข Load " & Trim(MSGridHeader.Rows(index).Cells(1).Value.ToString) & " ถูกยกเลิกไปแล้ว ", vbCritical, "ระบบแจ้งว่า")
            Exit Sub
        End If

        strSQL = "BEGIN "
        strSQL = strSQL & " LOAD.SHIPMENT_RECREATE("
        strSQL = strSQL & pLoadNo
        strSQL = strSQL & ",'"
        strSQL = strSQL & mUserName
        strSQL = strSQL & "','"
        strSQL = strSQL & mComputerName
        strSQL = strSQL & "',:iRET_CHECK"
        strSQL = strSQL & ",:iRET_MSG); "
        strSQL = strSQL & "END;"

        Dim Oraparam As New COraParameter
        With Oraparam

            .CreateOracleParamOutput("iRET_CHECK", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("iRET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With

        If Oradb.ExeSQL(strSQL, Oraparam) Then
            vCheck = IIf((Oraparam.GetOraclParamValue("iRET_CHECK").value >= 0), True, False)
            If vCheck Then
                MsgBox(Oraparam.GetOraclParamValue("iRET_MSG").value, vbInformation)
            Else
                MsgBox(Oraparam.GetOraclParamValue("iRET_MSG").value, vbCritical, "เกิดข้อผิดพลาด")
            End If
        End If
    End Sub

    Private Sub BypassShipment()
        Dim strSQL As String
        Dim vCheck As Boolean
        If MSGridHeader.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = MSGridHeader.CurrentRow.Index
        Dim pLoadNo As String = Trim(MSGridHeader.Rows(index).Cells(1).Value.ToString)

        If MsgBox("คำแตือน เมื่อคุณทำการ Bypass Shipment  คุณจะไม่ได้หมายเลข Shipment จากระบบ SAP  หากคุณยังยืนว่าคุณต้องการที่จะ Bypass Shipment หมายเลข Load No " & pLoadNo & " ให้กดปุ่ม OK ", vbOKCancel + vbInformation) = vbCancel Then Exit Sub

        If Trim(MSGridHeader.Rows(index).Cells(23).Value.ToString) = "ยกเลิก" Then
            MsgBox("ไม่สามารถ Bypass Shipment ได้ เนื่องจากหมายเลข Load " & Trim(MSGridHeader.Rows(index).Cells(1).Value.ToString) & " ถูกยกเลิกไปแล้ว ", vbCritical, "ระบบแจ้งว่า")
            Exit Sub
        End If

        strSQL = "BEGIN "
        strSQL = strSQL & " LOAD.SHIPMENT_BYPASS("
        strSQL = strSQL & pLoadNo
        strSQL = strSQL & ",'"
        strSQL = strSQL & mUserName
        strSQL = strSQL & "','"
        strSQL = strSQL & mComputerName
        strSQL = strSQL & "',:iRET_CHECK"
        strSQL = strSQL & ",:iRET_MSG); "
        strSQL = strSQL & "END;"

        Dim Oraparam As New COraParameter
        With Oraparam

            .CreateOracleParamOutput("iRET_CHECK", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("iRET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With

        If Oradb.ExeSQL(strSQL, Oraparam) Then
            vCheck = IIf((Oraparam.GetOraclParamValue("iRET_CHECK").value >= 0), True, False)
            If vCheck Then
                MsgBox(Oraparam.GetOraclParamValue("iRET_MSG").value, vbInformation)
            Else
                MsgBox(Oraparam.GetOraclParamValue("iRET_MSG").value, vbCritical, "เกิดข้อผิดพลาด")
            End If
        End If
    End Sub

    Private Sub CompleteShipment()
        Dim strSQL As String
        If MSGridHeader.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = MSGridHeader.CurrentRow.Index
        Dim pLoadNo As String = Trim(MSGridHeader.Rows(index).Cells(1).Value.ToString)

        If MsgBox("คุณต้องการ Resend ส่งกลับ SAP หมายเลข Load No " & pLoadNo & " ? ", vbOKCancel + vbInformation) = vbCancel Then Exit Sub

        If Trim(MSGridHeader.Rows(index).Cells(23).Value.ToString) = "ยกเลิก" Then
            MsgBox("ไม่สามารถ Resend ส่งกลับ SAP ได้ เนื่องจากหมายเลข Load " & Trim(MSGridHeader.Rows(index).Cells(1).Value.ToString) & " ถูกยกเลิกไปแล้ว ", vbCritical, "ระบบแจ้งว่า")
            Exit Sub
        End If

        strSQL = "BEGIN "
        strSQL = strSQL & " OILSYS.RESEND_LOAD("
        strSQL = strSQL & pLoadNo
        strSQL = strSQL & "); "
        strSQL = strSQL & "END;"

        If Oradb.ExeSQL(strSQL) Then
            MsgBox("SEND SAP LOAD NO : " & pLoadNo & " COMPLETE", vbInformation)
        End If
    End Sub

    Private Sub CompleteAllShipment()
        Dim strSQL As String
        Dim pLoadNo As String
        Dim itxtTotHeader, i As Long
        If MsgBox("คุณต้องการ Resend ALL ส่งกลับ SAP", vbOKCancel + vbInformation) = vbCancel Then Exit Sub

        With MSGridHeader
            itxtTotHeader = Val(txtToHeader.Text) - 1
            For i = 1 To itxtTotHeader
                pLoadNo = Trim(MSGridHeader.Rows(i).Cells(1).Value.ToString)
                If Trim(MSGridHeader.Rows(i).Cells(23).Value.ToString) <> "ยกเลิก" Then
                    strSQL = "BEGIN  OILSYS.RESEND_LOAD( " & pLoadNo & "); end;"
                    Oradb.ExeSQL(strSQL)
                End If
            Next i
        End With
        MsgBox("RESEND ALL SAP COMPLETED", vbInformation)
    End Sub




    'Private Sub b_Refresh_Click_1(sender As System.Object, e As System.EventArgs) Handles b_Refresh.Click

    'End Sub

    'Private Sub cmbStatus_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cmbStatus.SelectedIndexChanged

    'End Sub

    Private Sub UcMenuRefresh_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64)
        Show_Data()
    End Sub

    Private Sub UcMenuAdd_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMenuAdd.OnClickMnuText
        'frmLoadLoading_sub.Close()
        'frmLoadLoading_sub.ShowDialog()
        frmLoadCreateLoad.Close()
        frmLoadCreateLoad.ShowDialog()
    End Sub

    Private Sub UcMenuEdit_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMenuEdit.OnClickMnuText
        If MSGridHeader.Rows.Count <= 0 Then Exit Sub
        'frmLoadLoading_sub.Close()
        'frmLoadLoading_sub.AELoadNo = MSGridHeader.Rows(MSGridHeader.CurrentRow.Index).Cells(1).Value.ToString()
        'frmLoadLoading_sub.ShowDialog()
        frmUtlShowdetial.Close()
        frmUtlShowdetial.GetLoadNo(Val(MSGridHeader.Rows(MSGridHeader.CurrentRow.Index).Cells(1).Value.ToString()))
        frmUtlShowdetial.ShowDialog()
    End Sub

    Private Sub UcMenuDelete_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMenuDelete.OnClickMnuText
        If MSGridHeader.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = MSGridHeader.CurrentRow.Index
        Dim txtLoadNoClk As String = Trim(MSGridHeader.Rows(index).Cells(1).Value.ToString)

        If Trim(MSGridHeader.Rows(index).Cells(23).Value.ToString) = "ยกเลิก" Then
            MsgBox("ไม่สามารถยกเลิกได้เพราะว่า หมายเลข Load " & Trim(MSGridHeader.Rows(index).Cells(1).Value.ToString) & " ถูกยกเลิกไปแล้ว ", vbCritical, "ระบบแจ้งว่า")
            Exit Sub
        End If

        If MsgBox("คุณต้องการยกเลิกการจ่าย หมายเลข " & txtLoadNoClk & " ?", vbOKCancel + vbInformation) = vbOK Then
            frmRemark.Close()
            frmRemark.SetLoadNo(txtLoadNoClk)
            frmRemark.ShowDialog()
            If RemarkCancelOK = True Then
                Exit Sub
            End If
            Call CancelLoadHeader(txtLoadNoClk, "-", mUserName, mComputerName)
            'Call UpdateSealControlCancle(txtLoadNoClk)
            Show_Data()
        End If
    End Sub

    Private Sub UcMenu_edit_Seal_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMenu_edit_Seal.OnClickMnuText
        If MSGridHeader.Rows.Count <= 0 Then Exit Sub
        frmLoadEditSeal.Close()
        frmLoadEditSeal.iCase = 1
        frmLoadEditSeal.ShowDialog()
    End Sub
    Private Sub UcMenuEditCoq_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMenuEditCoq.OnClickMnuText
        If MSGridHeader.Rows.Count <= 0 Then Exit Sub
        frmLoadEditGOVCOQ.Close()
        frmLoadEditGOVCOQ.ShowDialog()
    End Sub

    Private Sub UcMenutxt_CreateShipment_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMenutxt_CreateShipment.OnClickMnuText
        CreateShipment()
    End Sub

    Private Sub UcMenutxt_BypassShipment_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMenutxt_BypassShipment.OnClickMnuText
        BypassShipment()
        Show_Data()
    End Sub

    Private Sub UcMenutxt_Send_to_SAP_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMenutxt_Send_to_SAP.OnClickMnuText
        CompleteShipment()
        Show_Data()
    End Sub

    Private Sub UcMenutxt_Resend_All_to_SAP_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMenutxt_Resend_All_to_SAP.OnClickMnuText
        CompleteAllShipment()
        Show_Data()
    End Sub

    Private Sub UcMenucmdPrint_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMenucmdPrint.OnClickMnuText

        Dim index As Integer = MSGridHeader.CurrentRow.Index
        Dim rptFileName As String

        Try
            'rptFileName = GetReportFileName(52010062)
            'frmrptShowReport.Close()
            With frmrptMainShow
                .load_no = MSGridHeader.Rows(index).Cells(1).Value
                .report_id = "52010062"
                .Show()
            End With


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MSGridHeader_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MSGridHeader.CellDoubleClick
        'Dim index As Integer = MSGridHeader.CurrentRow.Index
        'Dim rptFileName As String

        'Try
        '    rptFileName = GetReportFileName(52010062)
        '    ' frmrptShowReport.Close()
        '    With frmrptShowReport
        '        .mRptFileName = rptFileName
        '        .mParameter = MSGridHeader.Rows(index).Cells(1).Value
        '        '.ShowReport(strSQL)
        '        Thread.Sleep(1000)
        '        .Show()
        '    End With
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        If MSGridHeader.Rows.Count <= 0 Then Exit Sub
        frmUtlShowdetial.Close()
        frmUtlShowdetial.GetLoadNo(Val(MSGridHeader.Rows(MSGridHeader.CurrentRow.Index).Cells(1).Value.ToString()))
        frmUtlShowdetial.ShowDialog()
    End Sub

    Private Sub UcHeader1_CloseButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles UcHeader1.CloseButtonClick
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UcHeader1_MinimizeButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles UcHeader1.MinimizeButtonClick
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub UcBack1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UcBack1.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub UcBack1_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles UcBack1.MouseHover
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("Back1")
    End Sub

    Private Sub UcBack1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles UcBack1.MouseLeave
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("back")
    End Sub

    Private Sub UcBack1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcBack1.Load

    End Sub

    Private Sub MSGridHeader_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MSGridHeader.KeyUp
        If MSGridHeader.RowCount > 0 Then
            Dim index As Integer = MSGridHeader.CurrentRow.Index
            ShowFlexGridLine(MSGridHeader.Rows(index).Cells(1).Value.ToString)

        End If
    End Sub

    Private Sub MSGridHeader_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MSGridHeader.KeyDown
        If MSGridHeader.RowCount > 0 Then
            Dim index As Integer = MSGridHeader.CurrentRow.Index
            ShowFlexGridLine(MSGridHeader.Rows(index).Cells(1).Value.ToString)

        End If
    End Sub

    Private Sub UcMenuRefresh_OnClickMnuText_1(ByVal ucName As String, ByVal ucScreenID As Long) Handles UcMenuRefresh.OnClickMnuText
        Show_Data()
    End Sub

    Private Sub oe_Click(ByVal sender As Object, ByVal e As EventArgs) Handles oe.Click
        If MSGridHeader.Rows.Count <= 0 Then Exit Sub
        frmLoadMixEdit.Close()
        frmLoadMixEdit.InitialCBbilling(Val(MSGridHeader.Rows(MSGridHeader.CurrentRow.Index).Cells(1).Value.ToString()))
        frmLoadMixEdit.ShowDialog()
        Show_Data()
    End Sub

    Private Sub UcMenuWeightEdit_OnClickMnuText(ByVal ucName As String, ByVal ucScreenID As Long) Handles UcMenuWeightEdit.OnClickMnuText
        If MSGridHeader.Rows.Count <= 0 Then Exit Sub
        frmMixEditWeight.Load_No = Val(MSGridHeader.Rows(MSGridHeader.CurrentRow.Index).Cells(1).Value.ToString())
        frmMixEditWeight.ChkStatusWeghtEdit(Val(MSGridHeader.Rows(MSGridHeader.CurrentRow.Index).Cells(1).Value.ToString()))
        frmMixEditWeight.ShowDialog()
    End Sub

    Private Sub UcMenuDiff_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMenuDiff.OnClickMnuText
        frmLoadCheckDiff.ShowDialog()
    End Sub

    Private Sub UcMenutxt_Export_file_to_Oilsys_OnClickMnuText(ucName As String, ucScreenID As Long) Handles UcMenutxt_Export_file_to_Oilsys.OnClickMnuText
        Export_Excel()
    End Sub
    Private Sub Export_Excel()
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim vFileTime As String
        Dim vFileDate As String
        Dim i As Integer
        Dim j As Integer
        vFileTime = Format(Now, "Hmmss")
        vFileDate = Format(Date.Now, "ddMMyyyy")
        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        For i = 0 To MSGridHeader.RowCount - 1
            For j = 0 To MSGridHeader.ColumnCount - 1
                For k As Integer = 1 To MSGridHeader.Columns.Count
                    xlWorkSheet.Cells(1, k) = MSGridHeader.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = MSGridHeader(j, i).Value.ToString()
                Next
            Next
        Next
        Try
            xlWorkSheet.SaveAs("D:\excel\" & vFileDate & "_" & vFileTime & ".xlsx")
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
            'MsgBox("You can find the file D:\excel\vbexcel.xlsx")

            Process.Start("D:\excel\" & vFileDate & "_" & vFileTime & ".xlsx")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub PickerDate_Start_ValueChanged(sender As Object, e As EventArgs) Handles PickerDate_Start.ValueChanged
        'Show_Data()

    End Sub

    Private Sub PickerTime_Start_ValueChanged(sender As Object, e As EventArgs) Handles PickerTime_Start.ValueChanged
        'Show_Data()
    End Sub

    Private Sub PickerDate_Stop_ValueChanged(sender As Object, e As EventArgs) Handles PickerDate_Stop.ValueChanged
        'Show_Data()
    End Sub

    Private Sub PickerTime_Stop_ValueChanged(sender As Object, e As EventArgs) Handles PickerTime_Stop.ValueChanged
        'Show_Data()
    End Sub
End Class