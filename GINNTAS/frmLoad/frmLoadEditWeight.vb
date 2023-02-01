
Public Class frmLoadEditWeight
    Dim check_status As Integer

    Private Sub frmLoadEditWeight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearData()
        Initial_frm()
        Show_Data()
    End Sub

    Private Sub Show_Data()
        Dim row As Integer = frmLoadWeight.DataGridView_Headers.CurrentRow.Index

        txtloadNo.Text = frmLoadWeight.DataGridView_Headers.Item(0, row).Value()
        txtShipmentNo.Text = frmLoadWeight.DataGridView_Headers.Item(1, row).Value()
        txtTruckNo.Text = frmLoadWeight.DataGridView_Headers.Item(3, row).Value()
        txtTuNo.Text = frmLoadWeight.DataGridView_Headers.Item(4, row).Value()
        txtWeightIn.Text = frmLoadWeight.DataGridView_Headers.Item(5, row).Value()
        txtWeightOut.Text = frmLoadWeight.DataGridView_Headers.Item(6, row).Value()
        CmbCard_Reader.SelectedIndex = 0

        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "SELECT T.LOAD_STATUS "
        sql_str = sql_str & " FROM TAS.OIL_LOAD_HEADERS T "
        sql_str = sql_str & " WHERE T.LOAD_HEADER_NO = " & txtloadNo.Text

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            check_status = (IIf(IsDBNull(dt.Rows(i).Item("LOAD_STATUS")), "", dt.Rows(i).Item("LOAD_STATUS").ToString))
        End If
        mDataSet = Nothing

        If check_status = "21" Then
            txtWeightOut.Visible = False
        End If
        If check_status = "54" Or check_status = "55" Then
            txtWeightOut.Visible = True
            txtWeightIn.ReadOnly = True
            txtWeightIn.BackColor = Color.LightGreen
        End If

    End Sub

    Private Sub Initial_frm()
        InitialCB()
    End Sub

    Private Sub ClearData()
        txtloadNo.Text = ""
        txtShipmentNo.Text = ""
        txtTruckNo.Text = ""
        txtTuNo.Text = ""
        CmbCard_Reader.Items.Clear()
        txtWeightIn.Text = "0"
        txtWeightOut.Text = "0"
    End Sub

    Private Sub InitialCB()
        Dim sql_str As String
        sql_str = " SELECT C.CARD_READER_ID FROM TAS.CARD_READER C  WHERE C.CARD_READER_TYPE=3  ORDER BY C.CARD_READER_ID "
        InitialCB(sql_str, "CARD_READER_ID", CmbCard_Reader)
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

    Private Sub CmbCard_Reader_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbCard_Reader.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtWeightIn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWeightIn.KeyPress
        e.Handled = CurrencyOnly(txtWeightIn, e.KeyChar)
    End Sub

    Private Sub txtWeightOut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWeightOut.KeyPress
        e.Handled = CurrencyOnly(txtWeightOut, e.KeyChar)
    End Sub

    Private Sub b_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Save.Click
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim itu_card_no, ioverride_card, ioverride_weight As Long
        Dim in_weight, out_weight As Long

        sql_str = "SELECT T.LOAD_STATUS,T.TU_CARD_NO "
        sql_str = sql_str & " FROM TAS.OIL_LOAD_HEADERS T "
        sql_str = sql_str & " WHERE T.LOAD_HEADER_NO = " & txtloadNo.Text

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            check_status = (IIf(IsDBNull(dt.Rows(i).Item("LOAD_STATUS")), "", dt.Rows(i).Item("LOAD_STATUS").ToString))
            itu_card_no = (IIf(IsDBNull(dt.Rows(i).Item("TU_CARD_NO")), "", dt.Rows(i).Item("TU_CARD_NO").ToString))
        End If
        mDataSet = Nothing

        If check_status = "21" Then
            If txtWeightIn.Text.Trim = "0" Or txtWeightIn.Text.Trim = "" Then
                MsgBox("คุณยังไม่ได้ป้อนน้ำหนักชั่งเข้า", vbCritical, "พบข้อผิดพลาด")
                Exit Sub
            Else
                ioverride_weight = CLng(txtWeightIn.Text)
                ioverride_card = 1
            End If
        End If

        If check_status = "54" Or check_status = "55" Then
            If txtWeightOut.Text.Trim = "0" Or txtWeightOut.Text.Trim = "" Then
                MsgBox("คุณยังไม่ได้ป้อนน้ำหนักชั่งเข้า", vbCritical, "พบข้อผิดพลาด")
                Exit Sub
            End If

            in_weight = txtWeightIn.Text
            out_weight = txtWeightOut.Text

            If out_weight <= in_weight Then
                MsgBox("น้ำหนักชั่งออกต้องมีมากกว่าน้ำหนักชั่งเข้า", vbCritical, "พบข้อผิดพลาด")
                Exit Sub
            Else
                ioverride_weight = CLng(txtWeightOut.Text)
                ioverride_card = 1
            End If
        End If

        If CmbCard_Reader.Text.Trim = "" Then
            MsgBox("คุณยังไมได้เลือก Card Reader", vbCritical, "พบข้อผิดพลาด")
            Exit Sub
        End If

        If MsgBox("คุณต้องการ บันทึกข้อมูลน้ำหนักใช่หรือไม่ ?", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        Else

            sql_str = "BEGIN "
            sql_str = sql_str & " LOAD.WEIGHT_CHECK_TU("
            sql_str = sql_str & itu_card_no & "," & Trim(CmbCard_Reader.Text) & "," & ioverride_card & ",'" & ioverride_weight & "', "
            sql_str = sql_str & " to_date('" & Now & "','DD/MM/YYYY HH24:MI:SS') ,"
            sql_str = sql_str & "'" & mUserName & "','" & mComputerName & "',"
            sql_str = sql_str & ":ret_load_no,:ret_weight_type,:ret_check,:ret_msg,:ret_cr_msg); "
            sql_str = sql_str & "END;"


            Dim Oraparam As New COraParameter
            Dim RET_LOAD_NO As Object
            Dim RET_WEIGHT_TYPE As Object
            Dim RET_CHECK As Object
            Dim RET_MSG As Object
            Dim RET_CR_MSG As Object
            With Oraparam
                .CreateOracleParamOutput("RET_LOAD_NO", COracle._OracleDbType.OraInt32)
                .CreateOracleParamOutput("RET_WEIGHT_TYPE", COracle._OracleDbType.OraInt32)
                .CreateOracleParamOutput("RET_CHECK", COracle._OracleDbType.OraInt32)
                .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
                .CreateOracleParamOutput("RET_CR_MSG", COracle._OracleDbType.OraVarchar2, 512)
            End With

            If Oradb.ExeSQL(sql_str, Oraparam) Then
                RET_LOAD_NO = Oraparam.GetOraclParamValue("RET_LOAD_NO")
                RET_WEIGHT_TYPE = Oraparam.GetOraclParamValue("RET_WEIGHT_TYPE")
                RET_CHECK = Oraparam.GetOraclParamValue("RET_CHECK")
                RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
                RET_CR_MSG = Oraparam.GetOraclParamValue("RET_CR_MSG")

                If RET_CHECK <> 0 Then
                    MsgBox(RET_MSG, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "เกิดข้อผิดพลาด")
                    Oraparam.RemoveOracleParam()
                    Oraparam = Nothing
                    Exit Sub
                End If
                'MsgBox(RET_MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            End If

            Oraparam.RemoveOracleParam()
            Oraparam = Nothing

            frmLoadWeight.Show_frm()
            Me.Close()
        End If
    End Sub

    Private Sub b_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Cancel.Click
        Me.Close()
    End Sub

    Private Sub CmbCard_Reader_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCard_Reader.Click
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "SELECT V.WEIGHT_VALUE "
        sql_str = sql_str & " FROM STEQI.VIEW_WEIGHT_VALUE V "
        sql_str = sql_str & " WHERE V.CARD_READER_ID = " & CmbCard_Reader.Text

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0

            If check_status = "21" Then
                txtWeightIn.Text = IIf(IsDBNull(dt.Rows(i).Item("WEIGHT_VALUE")), "", dt.Rows(i).Item("WEIGHT_VALUE").ToString)
            End If
            If check_status = "54" Or check_status = "55" Then
                txtWeightOut.Text = IIf(IsDBNull(dt.Rows(i).Item("WEIGHT_VALUE")), "", dt.Rows(i).Item("WEIGHT_VALUE").ToString)
            End If
        End If
        mDataSet = Nothing
    End Sub

    Private Sub b_Refresh_weight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Refresh_weight.Click
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "SELECT V.WEIGHT_VALUE "
        sql_str = sql_str & " FROM STEQI.VIEW_WEIGHT_VALUE V "
        sql_str = sql_str & " WHERE V.CARD_READER_ID = " & CmbCard_Reader.Text

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0

            If check_status = "21" Then
                txtWeightIn.Text = IIf(IsDBNull(dt.Rows(i).Item("WEIGHT_VALUE")), "", dt.Rows(i).Item("WEIGHT_VALUE").ToString)
            End If
            If check_status = "54" Or check_status = "55" Then
                txtWeightOut.Text = IIf(IsDBNull(dt.Rows(i).Item("WEIGHT_VALUE")), "", dt.Rows(i).Item("WEIGHT_VALUE").ToString)
            End If
        End If
        mDataSet = Nothing
    End Sub

End Class