

Public Class frmProofEditLine
    Dim pLoad_No As String
    Dim pComp_No As String
    Dim pLine_No As String
    Dim pStatus_Batch As String

    Private Sub frmProofEditLine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        Initial_frm()
        InitialCB_Bay()
        ShowDataHead()
        ShowGridLineBatch()
    End Sub

    Public Sub GetDataLineBatch(ByVal ILoadNo As String, ByVal iComp As String, ByVal iLineNo As String, ByVal iStatusBatch As String)
        Dim psta() As String
        psta = Split(iStatusBatch, "-")
        pStatus_Batch = psta(0).Trim
        pLoad_No = ILoadNo
        pComp_No = iComp
        pLine_No = iLineNo

        InitialCB_Status()
    End Sub

    Private Sub b_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Close.Click
        Me.Close()
    End Sub

    Private Sub cbBay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbBay.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbMeterNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbMeterNo.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbStatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbStatus.KeyPress
        e.Handled = True
    End Sub

    Private Sub Initial_frm()
        'InitialCB_Bay()
    End Sub

    Private Sub Clear_frm()
        txtComp.Text = ""
        txtBatchNo.Text = ""
        txtLoadNo.Text = ""
        txtTruckName.Text = ""
        txtTailerName.Text = ""
        txtDriver.Text = ""
        DataGridView_LineBatch.Rows.Clear()
        DataGridView_SumBatch.Rows.Clear()
    End Sub

    Private Sub InitialCB_Bay()
        Dim sql_str As String
        sql_str = " SELECT B.BAY_NO  "
        sql_str = sql_str & " FROM BAY B "
        sql_str = sql_str & " ORDER BY  B.BAY_NO "
        initialCB(sql_str, "BAY_NO", cbBay)
    End Sub

    Private Sub InitialCB_Status()
        Dim sql_str As String
        sql_str = " SELECT S.TYPE_ID,S.TYPE_NAME,S.TYPE_ID||'-'||S.TYPE_NAME AS TYPE  "
        sql_str = sql_str & " FROM V_BATCH_STATUS S "
        sql_str = sql_str & " ORDER BY  S.TYPE_ID "
        initialCB(sql_str, "TYPE", cbStatus)
    End Sub

    Function initialCB(ByVal sql_str As String, ByVal colName As String, ByVal cb As System.Object) As Boolean
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
        mDataSet = Nothing
        Return True
    End Function

    Private Sub ShowDataHead()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0

        sql_str = " SELECT T.LOAD_HEADER_NO,"
        sql_str = sql_str & " T.TU_ID, T.TU_ID1, VS.TYPE_NAME AS LOAD_STATUS, T.DRIVER_NAME "
        sql_str = sql_str & " FROM OIL_LOAD_HEADERS T ,TAS.V_LOAD_STATUS  VS "
        sql_str = sql_str & " WHERE T.LOAD_STATUS = VS.TYPE_ID "
        sql_str = sql_str & " AND  T.LOAD_HEADER_NO ='" & pLoad_No & "' "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > i Then
                txtComp.Text = pComp_No
                txtBatchNo.Text = pLine_No
                txtLoadNo.Text = pLoad_No
                txtTruckName.Text = IIf(IsDBNull(dt.Rows(i).Item("TU_ID")), "", dt.Rows(i).Item("TU_ID").ToString)
                txtTailerName.Text = IIf(IsDBNull(dt.Rows(i).Item("TU_ID1")), "", dt.Rows(i).Item("TU_ID1").ToString)
                txtDriver.Text = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_NAME")), "", dt.Rows(i).Item("DRIVER_NAME").ToString)
            Else
                txtComp.Text = ""
                txtBatchNo.Text = ""
                txtLoadNo.Text = ""
                txtTruckName.Text = ""
                txtTailerName.Text = ""
                txtDriver.Text = ""
            End If
        End If
        mDataSet = Nothing
    End Sub

    Private Sub cbBay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBay.SelectedIndexChanged
        InitialCB_MeterNO(cbBay.Text)
    End Sub

    Private Sub InitialCB_MeterNO(ByVal iBay As String)
        Dim sql_str As String
        sql_str = " SELECT M.METER_NO  "
        sql_str = sql_str & " FROM METER M,BAY B "
        sql_str = sql_str & " WHERE M.ISLAND_NO=B.ISLAND_NO AND B.BAY_NO = '" & iBay & "'"
        sql_str = sql_str & " ORDER BY  M.METER_NO "
        cbMeterNo.Items.Clear()
        initialCB(sql_str, "METER_NO", cbMeterNo)
    End Sub

    Private Sub b_AddLMeter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_AddLMeter.Click
        If cbBay.Text.Trim = "" Or cbMeterNo.Text.Trim = "" Then
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " คุณยังไม่ได้เลือก Bay หรือ Meter No กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            Exit Sub
        End If

        If MsgBox("คุณต้องการเพิ่ม Load Count ?", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If

        If AddLoadMeter() Then
            ShowGridLineBatch()
            initial_Tamk_Gridview(DataGridView_LineBatch.Item(7, DataGridView_LineBatch.CurrentRow.Index).Value)
            initial_Combobox_Grid()
            MsgBox("เพิ่ม Load Count Meter เรียบร้อยแล้ว ", vbInformation)
        Else
            MsgBox("เพิ่ม Load Count Meter ไม่สำเร็จ  ", vbCritical)
        End If
    End Sub

    Private Sub b_RefreshGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_RefreshGrid.Click
        ShowGridLineBatch()
        If DataGridView_LineBatch.Rows.Count > 0 Then
            initial_Tamk_Gridview(DataGridView_LineBatch.Item(7, DataGridView_LineBatch.CurrentRow.Index).Value)
            initial_Combobox_Grid()
        End If

    End Sub

    Private Sub b_DeleteLoadMeter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_DeleteLoadMeter.Click
        If DeleteLoadMeter Then
            GetLoadCount()
            MsgBox("ลบ Load Count Meter เรียบร้อยแล้ว ", vbInformation)
        End If
    End Sub

    Private Sub GetLoadCount()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0

        sql_str = " SELECT  T.LOAD_COUNT   FROM TAS.OIL_LOAD_LINES T  WHERE T.LOAD_HEADER_NO ='" & txtLoadNo.Text.Trim & "'   AND T.BATCH_NO ='" & txtBatchNo.Text.Trim & "'"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            lbl_rec.Text = dt.Rows.Count
            If dt.Rows.Count > i Then
                lbl_rec.Text = dt.Rows.Count
            Else
                lbl_rec.Text = 0
            End If
        End If
        mDataSet = Nothing
    End Sub

    Private Function DeleteLoadMeter() As Boolean
        Dim sql_str As String
        DeleteLoadMeter = False
        If MsgBox("คุณแน่ใจว่าต้องการลย LoadCount  ?", vbInformation + vbYesNo) = vbNo Then
            Exit Function
        End If

        If DataGridView_LineBatch.RowCount = 0 Then
            MsgBox("ไม่สามารถลบข้อมูลได้ ต้องมีอย่างน้อย 1 Load Meter ")
        End If

        Dim mDataSet As New DataSet

        sql_str = " DELETE FROM TAS.OIL_LOAD_METERS T"
        sql_str = sql_str & " WHERE T.LOAD_HEADER_NO = '" & txtLoadNo.Text.Trim & "' AND T.BATCH_NO ='" & txtBatchNo.Text.Trim & "' "
        sql_str = sql_str & " AND T.LOAD_COUNT = '" & DataGridView_LineBatch.Item(0, DataGridView_LineBatch.CurrentRow.Index).Value & "' AND T.METER = '" & DataGridView_LineBatch.Item(1, DataGridView_LineBatch.CurrentRow.Index).Value & "' "
        If Oradb.ExeSQL(sql_str) Then
            'MessageBox.Show("ได้ทำการลบข้อมูลเรียบร้อย", "System TAS")

            sql_str = " UPDATE TAS.OIL_LOAD_LINES L"
            sql_str = sql_str & " SET L.LOAD_COUNT = '" & DataGridView_LineBatch.RowCount - 1 & "' "
            sql_str = sql_str & " WHERE L.LOAD_HEADER_NO = '" & txtLoadNo.Text.Trim & "' AND L.BATCH_NO ='" & txtBatchNo.Text.Trim & "' "
            Oradb.ExeSQL(sql_str)

            DataGridView_LineBatch.RowCount = DataGridView_LineBatch.Rows.Count - 1

            DeleteLoadMeter = True
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If

    End Function

    Private Sub ShowGridLineBatch()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0

        sql_str = " select  t.override_batch,t.description,t.load_count , t.compartment_no,  "
        sql_str = sql_str & " t.base_product_id ,t.preset,t.loaded_gross,t.loaded_net,t.bay_no , "
        sql_str = sql_str & "  t.meter,t.meter_no,t.temp ,t.api60f ,t.tank_name,t.batch_status,t.DESITY15C, "
        sql_str = sql_str & " t.tot_gross_start , t.tot_gross_stop,t.loaded_vol15c "
        sql_str = sql_str & " FROM TAS.OIL_LOAD_METERS T "
        sql_str = sql_str & " Where t.LOAD_HEADER_NO = " & pLoad_No & " "
        sql_str = sql_str & " and t.batch_no =" & pLine_No & " "
        sql_str = sql_str & " and t.compartment_no =" & pComp_No & " "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            lbl_rec.Text = dt.Rows.Count
            DataGridView_LineBatch.RowCount = 0
            Do While dt.Rows.Count > i
                DataGridView_LineBatch.RowCount = DataGridView_LineBatch.RowCount + 1
                DataGridView_LineBatch.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("load_count")), "", dt.Rows(i).Item("load_count").ToString)
                DataGridView_LineBatch.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Meter")), "", dt.Rows(i).Item("Meter").ToString)
                DataGridView_LineBatch.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("base_product_id")), "", dt.Rows(i).Item("base_product_id").ToString)
                DataGridView_LineBatch.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("preset")), "", dt.Rows(i).Item("preset").ToString)
                DataGridView_LineBatch.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("loaded_gross")), "", dt.Rows(i).Item("loaded_gross").ToString)
                DataGridView_LineBatch.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("loaded_net")), "", dt.Rows(i).Item("loaded_net").ToString)
                DataGridView_LineBatch.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("bay_no")), "", dt.Rows(i).Item("bay_no").ToString)
                DataGridView_LineBatch.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Meter_no")), "", dt.Rows(i).Item("Meter_no").ToString)
                DataGridView_LineBatch.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Temp")), "", dt.Rows(i).Item("Temp").ToString)
                DataGridView_LineBatch.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DESITY15C")), "", dt.Rows(i).Item("DESITY15C").ToString)
                DataGridView_LineBatch.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("tank_name")), "", dt.Rows(i).Item("tank_name").ToString)
                DataGridView_LineBatch.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("batch_status")), "", dt.Rows(i).Item("batch_status").ToString)
                'If Column6.Items.IndexOf(IIf(IsDBNull(dt.Rows(i).Item("tank_name")), "", dt.Rows(i).Item("tank_name").ToString)) = -1 Then
                '    Column6.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("tank_name")), "", dt.Rows(i).Item("tank_name").ToString))
                'End If
                'DataGridView_LineBatch.Rows(i).Cells("DataGridViewTextBoxColumn12").Value = IIf(IsDBNull(dt.Rows(i).Item("tank_name")), "", dt.Rows(i).Item("tank_name").ToString)

                If Column6.Items.IndexOf(IIf(IsDBNull(dt.Rows(i).Item("batch_status")), "", dt.Rows(i).Item("batch_status").ToString)) = -1 Then
                    Column6.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("batch_status")), "", dt.Rows(i).Item("batch_status").ToString))
                End If
                DataGridView_LineBatch.Rows(i).Cells("Column6").Value = IIf(IsDBNull(dt.Rows(i).Item("batch_status")), "", dt.Rows(i).Item("batch_status").ToString)

                DataGridView_LineBatch.Item(12, i).Value = IIf(IsDBNull(dt.Rows(i).Item("tot_gross_start")), "", dt.Rows(i).Item("tot_gross_start").ToString)
                DataGridView_LineBatch.Item(13, i).Value = IIf(IsDBNull(dt.Rows(i).Item("tot_gross_stop")), "", dt.Rows(i).Item("tot_gross_stop").ToString)
                DataGridView_LineBatch.Item(14, i).Value = IIf(IsDBNull(dt.Rows(i).Item("override_batch")), "", dt.Rows(i).Item("override_batch").ToString)
                DataGridView_LineBatch.Item(15, i).Value = IIf(IsDBNull(dt.Rows(i).Item("description")), "", dt.Rows(i).Item("description").ToString)
                DataGridView_LineBatch.Item(16, i).Value = "Y"

                i = i + 1
            Loop
        End If
        mDataSet = Nothing
    End Sub

    Private Function AddLoadMeter() As Boolean
        Dim bRet As Boolean = False
        Dim sql_str As String

        sql_str = "BEGIN "
        sql_str = sql_str & " load.BATCH_CHECK_COMPARTMENT_1("
        sql_str = sql_str & cbBay.Text.Trim
        sql_str = sql_str & ",'" & cbMeterNo.Text.Trim & "',"
        sql_str = sql_str & "" & txtLoadNo.Text & ","
        sql_str = sql_str & "" & txtComp.Text & ","
        sql_str = sql_str & ":RET_BATCH_NO"
        sql_str = sql_str & ",:RET_LOAD_COUNT"
        sql_str = sql_str & ",:RET_RECIPES_NO"
        sql_str = sql_str & ",:RET_PRESET"
        sql_str = sql_str & ",:RET_DESITY15C"
        sql_str = sql_str & ",:RET_WRITE_VCF30"
        sql_str = sql_str & ",:RET_VCF30C"
        sql_str = sql_str & ",:RET_CHECK"
        sql_str = sql_str & ",:RET_MSG); "
        sql_str = sql_str & "END;"

        Dim Oraparam As New COraParameter
        Dim RET_BATCH_NO As Object
        Dim RET_LOAD_COUNT As Object
        Dim RET_RECIPES_NO As Object
        Dim RET_PRESET As Object
        Dim RET_DESITY15C As Object
        Dim RET_WRITE_VCF30 As Object
        Dim RET_VCF30C As Object
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_BATCH_NO", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_LOAD_COUNT", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_RECIPES_NO", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_PRESET", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_DESITY15C", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_WRITE_VCF30", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_VCF30C", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_CHECK", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With

        If Oradb.ExeSQL(sql_str, Oraparam) Then
            RET_BATCH_NO = Oraparam.GetOraclParamValue("RET_BATCH_NO")
            RET_LOAD_COUNT = Oraparam.GetOraclParamValue("RET_LOAD_COUNT")
            RET_RECIPES_NO = Oraparam.GetOraclParamValue("RET_RECIPES_NO")
            RET_PRESET = Oraparam.GetOraclParamValue("RET_PRESET")
            RET_DESITY15C = Oraparam.GetOraclParamValue("RET_DESITY15C")
            RET_WRITE_VCF30 = Oraparam.GetOraclParamValue("RET_WRITE_VCF30")
            RET_VCF30C = Oraparam.GetOraclParamValue("RET_VCF30C")
            RET_CHECK = Oraparam.GetOraclParamValue("RET_CHECK")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")

            If RET_CHECK <> 0 Then
                MsgBox(RET_MSG, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "เกิดข้อผิดพลาด")
                Oraparam.RemoveOracleParam()
                Oraparam = Nothing
                Return bRet
            Else
                MsgBox(RET_MSG, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "TAS SYSTEM")
            End If

            bRet = True
        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function

    Private Sub initial_Tamk_Gridview(ByRef iMeter As String)
        Dim cboCol1 As DataGridViewComboBoxColumn
        cboCol1 = DataGridView_LineBatch.Columns.Item(10)

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        Dim sql_str As String

        sql_str = "SELECT  MT.METER_NO, T.TANK_NAME "
        sql_str = sql_str & " FROM TAS.METER_TANK MT, TAS.TANK T "
        sql_str = sql_str & " WHERE  MT.TANK_ID = T.TANK_ID (+)"
        sql_str = sql_str & " AND MT.METER_NO ='" & iMeter & "'   ORDER BY MT.METER_NO"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            cboCol1.Items.Clear()
            Do While dt.Rows.Count > i
                cboCol1.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("TANK_NAME")), "", dt.Rows(i).Item("TANK_NAME").ToString))
                i = i + 1
            Loop

        End If
        mDataSet = Nothing
    End Sub

    Private Sub initial_Combobox_Grid()
        Dim i As Integer = 0

        'Dim cboCol3 As DataGridViewComboBoxColumn

        'cboCol3 = DataGridView_LineBatch.Columns.Item(11)
        'cboCol3.Items.Clear()
        'i = 1
        Try
            'Do While i < 7
            '    cboCol3.Items.Add(i)
            '    i = i + 1
            'Loop
      

            Dim cboCol2 As DataGridViewComboBoxColumn
            cboCol2 = DataGridView_LineBatch.Columns.Item(14)
            cboCol2.Items.Clear()
            i = 0
            Do While i < 3
                cboCol2.Items.Add(i)
                i = i + 1
            Loop

            Dim cboCol1 As DataGridViewComboBoxColumn
            cboCol1 = DataGridView_LineBatch.Columns.Item(16)
            cboCol1.Items.Clear()
            cboCol1.Items.Add("Y")
            cboCol1.Items.Add("N")

            Dim cboCol3 As DataGridViewComboBoxColumn
            cboCol3 = DataGridView_LineBatch.Columns.Item(11)
            cboCol3.Items.Clear()
            i = 1
            Do While i < 7
                cboCol3.Items.Add(i)
                i = i + 1
            Loop

        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub DataGridView_LineBatch_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DataGridView_LineBatch.DataError
        If e.Context = DataGridViewDataErrorContexts.Formatting Or e.Context = DataGridViewDataErrorContexts.PreferredSize Then
            e.ThrowException = False
        End If
    End Sub

    Private Sub DataGridView_LineBatch_EditingControlShowing(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView_LineBatch.EditingControlShowing
        Select Case DataGridView_LineBatch.CurrentCell.ColumnIndex
            Case 10
                Dim comboboxTank As ComboBox = e.Control
                RemoveHandler comboboxTank.SelectedIndexChanged, AddressOf comboboxTank_SelectedIndexChanged
                AddHandler comboboxTank.SelectedIndexChanged, AddressOf comboboxTank_SelectedIndexChanged
        End Select
    End Sub

    Private Sub comboboxTank_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If sender.text <> "" Then
            DataGridView_LineBatch.Item(9, DataGridView_LineBatch.CurrentCell.RowIndex).Value = ShowDensity(sender.text)
        End If
    End Sub

    Private Function ShowDensity(ByVal tank_name As String) As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim sql_str As String
        Dim GetDen As String = ""

        sql_str = "SELECT  T.DEN15C_OVERRIDE ,T.TEMP_OVERRIDE "
        sql_str = sql_str & " FROM TAS.TANK T "
        sql_str = sql_str & " WHERE T.TANK_NAME ='" & tank_name & "'"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                GetDen = IIf(IsDBNull(dt.Rows(0).Item("DEN15C_OVERRIDE") / 1000), "", (dt.Rows(0).Item("DEN15C_OVERRIDE") / 1000).ToString)
            End If
        End If
        Return GetDen
        mDataSet = Nothing
    End Function


    Private Sub b_Sum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Sum.Click
        Dim i As Integer
        If DataGridView_SumBatch.RowCount = 0 Then
            DataGridView_SumBatch.RowCount = DataGridView_SumBatch.RowCount + 1
            DataGridView_SumBatch.Item(0, 0).Value = DataGridView_LineBatch.Item(2, 0).Value
            DataGridView_SumBatch.Item(1, 0).Value = DataGridView_LineBatch.Item(3, 0).Value
            DataGridView_SumBatch.Item(9, 0).Value = DataGridView_LineBatch.Item(11, 0).Value
            DataGridView_SumBatch.Item(13, 0).Value = DataGridView_LineBatch.Item(15, 0).Value

            Dim vSumLoadGross, vSumLoadNet As Double
            vSumLoadGross = 0
            vSumLoadNet = 0

            For i = 0 To DataGridView_LineBatch.Rows.Count - 1
                If DataGridView_LineBatch.Item(4, i).Value = "" Or DataGridView_LineBatch.Item(5, i).Value = "" Then
                    MsgBox("ค่า Load Gross หรือ Load Net ไม่สามารถเป็นช่องว่างได้ กรูณาตรวจสอบ  ", vbCritical)
                    Exit Sub
                End If

                If DataGridView_LineBatch.Item(5, i).Value = "" Then
                    MsgBox("ท่านยังไม่ได้เลือก Meter กรูณาตรวจสอบ  ", vbCritical)
                    Exit Sub
                End If

                If DataGridView_LineBatch.Rows.Count = 1 Then
                    vSumLoadGross = CDbl(DataGridView_LineBatch.Item(4, i).Value)
                    vSumLoadNet = CDbl(DataGridView_LineBatch.Item(5, i).Value)
                Else
                    vSumLoadGross = vSumLoadGross + CDbl(DataGridView_LineBatch.Item(4, i).Value)
                    vSumLoadNet = vSumLoadNet + CDbl(DataGridView_LineBatch.Item(5, i).Value)
                End If
            Next i

            DataGridView_SumBatch.Item(2, 0).Value = vSumLoadGross
            DataGridView_SumBatch.Item(3, 0).Value = vSumLoadGross

            DataGridView_SumBatch.Item(4, 0).Value = DataGridView_LineBatch.Item(6, 0).Value
            DataGridView_SumBatch.Item(5, 0).Value = DataGridView_LineBatch.Item(7, 0).Value
            DataGridView_SumBatch.Item(6, 0).Value = DataGridView_LineBatch.Item(8, 0).Value
            DataGridView_SumBatch.Item(7, 0).Value = DataGridView_LineBatch.Item(9, 0).Value
            DataGridView_SumBatch.Item(8, 0).Value = DataGridView_LineBatch.Item(10, 0).Value
            DataGridView_SumBatch.Item(9, 0).Value = DataGridView_LineBatch.Item(11, 0).Value
            DataGridView_SumBatch.Item(12, 0).Value = DataGridView_LineBatch.Item(14, 0).Value
            DataGridView_SumBatch.Item(10, 0).Value = DataGridView_LineBatch.Item(12, 0).Value
            DataGridView_SumBatch.Item(11, 0).Value = DataGridView_LineBatch.Item(13, 0).Value
        Else
            DataGridView_SumBatch.RowCount = 0
        End If

    End Sub

    Private Sub b_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Save.Click
        If cbBay.Text.Trim = "" Or cbMeterNo.Text.Trim = "" Or cbStatus.Text.Trim = "" Then
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " คุณยังไม่ได้เลือก Bay หรือ Meter No กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            Exit Sub
        End If

        Dim i As Integer
        Dim Grid_Edit As Integer = 0
        For i = 0 To DataGridView_LineBatch.Rows.Count - 1
            If DataGridView_LineBatch.Item(16, i).Value = "Y" Then
                Grid_Edit = Grid_Edit + 1
            End If
        Next

        If Grid_Edit = 0 Then
            MessageBox.Show("ไม่พบข้อมูลที่ต้องการบันทึก " & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            Exit Sub
        End If

        If MsgBox("คุณต้องการบันทึกข้อมูลหรือไม่ ?", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If

        For i = 0 To DataGridView_LineBatch.Rows.Count - 1
            If DataGridView_LineBatch.Item(16, i).Value = "Y" Then
                OverrideLoadMeter(CLng(txtBatchNo.Text.Trim), DataGridView_LineBatch.Item(1, i).Value, DataGridView_LineBatch.Item(6, i).Value, DataGridView_LineBatch.Item(7, i).Value,
                                  IIf(DataGridView_LineBatch.Item(8, i).Value = "", 0, CDbl(DataGridView_LineBatch.Item(8, i).Value)), CDbl(DataGridView_LineBatch.Item(9, i).Value) * 1000, CDbl(DataGridView_LineBatch.Item(4, i).Value), CDbl(DataGridView_LineBatch.Item(5, i).Value),
                                  CDbl(DataGridView_LineBatch.Item(12, i).Value), CDbl(DataGridView_LineBatch.Item(13, i).Value), DataGridView_LineBatch.Item(15, i).Value, DataGridView_LineBatch.Item(10, i).Value, CLng(DataGridView_LineBatch.Item(11, i).Value),
                                  CLng(DataGridView_LineBatch.Item(14, i).Value), mUserName, mComputerName, 0, CLng(DataGridView_LineBatch.Item(0, i).Value))
            End If
        Next

        Dim StatusBatch() As String
        StatusBatch = Split(cbStatus.Text, "-")
        If pOverrideBatchValue(txtLoadNo.Text.Trim, txtBatchNo.Text.Trim, CLng(Trim(StatusBatch(0)))) Then
            MessageBox.Show("ได้ทำการบันทึกข้อมูลเรียบร้อยแล้ว ", "System TAS")
            frmProofLoadIncomplete.Showdata_GridMain()

            Me.Close()
        End If

    End Sub

    Private Function OverrideLoadMeter(ByVal pBatchno As Long, ByVal pMeterCount As Long, ByVal pBayName As String, ByVal pMeter As String, ByVal pTemp As Double, ByVal pDen15C As Double, ByVal pLoaded As Double, _
    ByVal pLoadedNet As Double, ByVal pStartTOT As Double, ByVal pStopTOT As Double, ByVal pDesc As String, ByVal pTank As String, ByVal pBatchstatus As Long, ByVal pOvrStatus As Long, _
    ByVal pUser As String, ByVal pComputer As String, ByVal pTypeupdate As Long, ByVal pLoadCount As Long) As Boolean

        Dim bRet As Boolean = False
        Dim sql_str As String

        sql_str = "BEGIN "
        sql_str = sql_str & " LOAD.OVERRIDE_BATCH_LOADMETER("
        sql_str = sql_str & pBatchno & ","
        sql_str = sql_str & pMeterCount & ""
        sql_str = sql_str & "," & pBayName & ","
        sql_str = sql_str & "'" & pMeter & "',"
        sql_str = sql_str & pTemp & ","
        sql_str = sql_str & (pDen15C) & ","
        sql_str = sql_str & pLoaded & ","
        sql_str = sql_str & pLoadedNet
        sql_str = sql_str & "," & pStartTOT & ","
        sql_str = sql_str & pStopTOT & ",'"
        sql_str = sql_str & pDesc
        sql_str = sql_str & "','" & pTank & "',"
        sql_str = sql_str & pBatchstatus & ","
        sql_str = sql_str & pOvrStatus & ",'"
        sql_str = sql_str & pUser
        sql_str = sql_str & "','" & pComputer & "','"
        sql_str = sql_str & pTypeupdate
        sql_str = sql_str & "','" & pLoadCount & "',"
        sql_str = sql_str & ":iREVAL); "
        sql_str = sql_str & "END;"

        Dim Oraparam As New COraParameter
        Dim iREVAL As Object
        With Oraparam
            .CreateOracleParamOutput("iREVAL", COracle._OracleDbType.OraInt32)
        End With

        If Oradb.ExeSQL(sql_str, Oraparam) Then
            iREVAL = Oraparam.GetOraclParamValue("iREVAL")
            bRet = True
        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function

    Private Function pOverrideBatchValue(ByVal pLoadNo As Long, ByVal pBatchno As String, ByVal pStatus As Long) As Boolean
        Dim bRet As Boolean = False
        Dim sql_str As String

        On Error Resume Next

        sql_str = "BEGIN "
        sql_str = sql_str & " LOAD.OVERRIDE_BATCH_LOADLINES("
        sql_str = sql_str & pLoadNo
        sql_str = sql_str & ",'" & pBatchno & "',"
        sql_str = sql_str & "'" & pStatus & "',"
        sql_str = sql_str & ":iREVAL); "
        sql_str = sql_str & "END;"

        Dim Oraparam As New COraParameter
        Dim iREVAL As Object
        With Oraparam
            .CreateOracleParamOutput("iREVAL", COracle._OracleDbType.OraInt32)
        End With

        If Oradb.ExeSQL(sql_str, Oraparam) Then
            iREVAL = Oraparam.GetOraclParamValue("iREVAL")
            bRet = True
        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet

    End Function

End Class