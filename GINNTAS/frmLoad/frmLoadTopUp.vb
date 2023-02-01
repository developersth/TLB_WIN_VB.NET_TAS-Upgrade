Public Class frmLoadTopUp
    Public FormScreenID As Long

    Private Sub frmLoadTopUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        Clear_frm()
        Initial_frm()
        Showdata_GridMain()

        resolution(Me, 1)
    End Sub

    Private Sub frmLoadCustomerQuota_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmLoadCustomerQuota_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub

    Private Sub Initial_frm()
        PickerDate_TopUp.Value = Date.Today
    End Sub

    Private Sub Clear_frm()
        txtToHeader.Text = 0
        MSGridHeader.RowCount = 0
        MSGridLine.RowCount = 0
    End Sub

    Public Sub Show_frm()
        Clear_frm()
        Initial_frm()
        Showdata_GridMain()
    End Sub

    Public Sub Showdata_GridMain()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim vDate = Format(PickerDate_TopUp.Value, "dd/MM/yyyy")

        sql_str = "select t.topup_no,t.shipment_no,t.load_header_no,t.do_no,t.compartment_no,t.bay_name As island_name ,t.sale_product_id,t.sale_product_name,t.close_load," & _
                    "t.preset,t.meter_no,t.t_start,t.t_stop,t.creation_date,t.created_by,t.update_date,t.updated_by,t.driver_name,t.carrier_name," & _
                    "t.vehicle_number , t.vehicle_type, t.vehicle_id, t.customer_name, t.shipto_name,t.description,t.batch_status,t.cancel_status" & _
                    " from oil_topup_lines t" & _
                    " where t.cancel_status=0  and  to_char(t.creation_date,'DD/MM/YYYY') =" & "'" & vDate & "'" & _
                    " order by t.topup_no"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            MSGridHeader.RowCount = 0
            txtToHeader.Text = dt.Rows.Count
            Do While dt.Rows.Count > i

                MSGridHeader.RowCount = MSGridHeader.RowCount + 1
                MSGridHeader.Rows.Item(i).Height = Grid_Height
                MSGridHeader.Item(0, i).Value = i + 1
                MSGridHeader.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("topup_no")), "", dt.Rows(i).Item("topup_no").ToString)
                MSGridHeader.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("shipment_no")), "", dt.Rows(i).Item("shipment_no").ToString)
                MSGridHeader.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("load_header_no")), "", dt.Rows(i).Item("load_header_no").ToString)

                MSGridHeader.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("do_no")), "", dt.Rows(i).Item("do_no").ToString)
                MSGridHeader.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("batch_status")), "", dt.Rows(i).Item("batch_status").ToString)
                MSGridHeader.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("cancel_status")), "", dt.Rows(i).Item("cancel_status").ToString)

                MSGridHeader.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("compartment_no")), "", dt.Rows(i).Item("compartment_no").ToString)
                MSGridHeader.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("island_name")), "", dt.Rows(i).Item("island_name").ToString)
                MSGridHeader.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("sale_product_id")), "", dt.Rows(i).Item("sale_product_id").ToString)

                MSGridHeader.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("sale_product_name")), "", dt.Rows(i).Item("sale_product_name").ToString)
                MSGridHeader.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("preset")), "", dt.Rows(i).Item("preset").ToString)
                MSGridHeader.Item(12, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Meter_no")), "", dt.Rows(i).Item("Meter_no").ToString)

                MSGridHeader.Item(13, i).Value = IIf(IsDBNull(dt.Rows(i).Item("T_START")), "", dt.Rows(i).Item("T_START").ToString)
                MSGridHeader.Item(14, i).Value = IIf(IsDBNull(dt.Rows(i).Item("t_stop")), "", dt.Rows(i).Item("t_stop").ToString)
                MSGridHeader.Item(15, i).Value = IIf(IsDBNull(dt.Rows(i).Item("driver_name")), "", dt.Rows(i).Item("driver_name").ToString)

                MSGridHeader.Item(16, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Carrier_name")), "", dt.Rows(i).Item("Carrier_name").ToString)
                MSGridHeader.Item(17, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Vehicle_Number")), "", dt.Rows(i).Item("Vehicle_Number").ToString)
                MSGridHeader.Item(18, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Vehicle_Type")), "", dt.Rows(i).Item("Vehicle_Type").ToString)

                MSGridHeader.Item(19, i).Value = IIf(IsDBNull(dt.Rows(i).Item("vehicle_id")), "", dt.Rows(i).Item("vehicle_id").ToString)
                MSGridHeader.Item(20, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Customer_name")), "", dt.Rows(i).Item("Customer_name").ToString)
                MSGridHeader.Item(21, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ShipTo_name")), "", dt.Rows(i).Item("ShipTo_name").ToString)

                MSGridHeader.Item(22, i).Value = IIf(IsDBNull(dt.Rows(i).Item("update_date")), "", dt.Rows(i).Item("update_date").ToString)
                MSGridHeader.Item(23, i).Value = IIf(IsDBNull(dt.Rows(i).Item("created_by")), "", dt.Rows(i).Item("created_by").ToString)
                MSGridHeader.Item(24, i).Value = IIf(IsDBNull(dt.Rows(i).Item("description")), "", dt.Rows(i).Item("description").ToString)
                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    'Private Sub DataGridView_Headers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Headers.CellClick
    'Dim strColume As String
    'If DataGridView_Headers.Rows.Count <= 0 Or DataGridView_Headers.CurrentRow.Index < 0 Then Exit Sub
    'With DataGridView_Headers
    '    strColume = .Item(0, .CurrentRow.Index).Value
    '    Call ShowtoMSGridLines(strColume)
    'End With
    'End Sub
    
   
    Private Sub UcMenuAdd_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuAdd.OnClickMnuText
        frmLoadTopUp_sub.setFrmWork(1)
        frmLoadTopUp_sub.Show()
    End Sub

    Private Sub b_Search_Click(sender As System.Object, e As System.EventArgs) Handles b_Search.Click
        frmFind.Close()
        frmFind.InitialFormFind(MSGridHeader)
        frmFind.ShowDialog()
    End Sub

    Private Sub UcMenuRefresh_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuRefresh.OnClickMnuText
        Clear_frm()
        Showdata_GridMain()
    End Sub

   
    Private Sub MSGridHeader_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MSGridHeader.CellClick
        Dim strColume As String
        If MSGridHeader.Rows.Count <= 0 Or MSGridHeader.CurrentRow.Index < 0 Then Exit Sub
        With MSGridHeader
            strColume = .Item(1, .CurrentRow.Index).Value
            Call ShowtoMSGridLines(strColume)
        End With
    End Sub
    Private Sub ShowtoMSGridLines(ByRef LoadTopUpNo As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = _
                  "select  t.topup_no,t.tu_id,t.compartment_no, t.sale_product_name,t.preset, t.unit,t.batch_status,t.island_no,t.meter_no,t.temp,t.desity15c,t.loaded_gross," & _
                  "t.loaded_volobs , t.loaded_vol15c, t.loaded_vol30c, t.loaded_mass, t.vcf30c, t.tank_name, t.t_start, t.t_stop, t.description" & _
                  " from oil_topup_lines t" & _
                  " where t.topup_no=" & LoadTopUpNo

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            MSGridLine.RowCount = 0
            Do While dt.Rows.Count > i

                MSGridLine.RowCount = MSGridLine.RowCount + 1
                MSGridLine.Rows.Item(i).Height = Grid_Height

                MSGridLine.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("topup_no")), "", dt.Rows(i).Item("topup_no").ToString)
                MSGridLine.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TU_ID")), "", dt.Rows(i).Item("TU_ID").ToString)
                MSGridLine.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("COMPARTMENT_NO")), "", dt.Rows(i).Item("COMPARTMENT_NO").ToString)
                MSGridLine.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("sale_product_name")), "", dt.Rows(i).Item("sale_product_name").ToString)
                MSGridLine.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("preset")), "", dt.Rows(i).Item("preset").ToString)
                MSGridLine.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("unit")), "", dt.Rows(i).Item("unit").ToString)
                MSGridLine.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("batch_status")), "", dt.Rows(i).Item("batch_status").ToString)
                MSGridLine.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("island_no")), "", dt.Rows(i).Item("island_no").ToString)
                MSGridLine.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("METER_NO")), "", dt.Rows(i).Item("METER_NO").ToString)
                MSGridLine.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TEMP")), "", dt.Rows(i).Item("TEMP").ToString)
                MSGridLine.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DESITY15C")), "", dt.Rows(i).Item("DESITY15C").ToString)
                MSGridLine.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOADED_GROSS")), "", dt.Rows(i).Item("LOADED_GROSS").ToString())
                MSGridLine.Item(12, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOADED_VOLOBS")), "", dt.Rows(i).Item("LOADED_VOLOBS").ToString)
                MSGridLine.Item(13, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOADED_VOL15C")), "", dt.Rows(i).Item("LOADED_VOL15C").ToString)
                MSGridLine.Item(14, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOADED_VOL30C")), "", dt.Rows(i).Item("LOADED_VOL30C").ToString)
                MSGridLine.Item(15, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOADED_MASS")), "", dt.Rows(i).Item("LOADED_MASS").ToString)
                MSGridLine.Item(16, i).Value = IIf(IsDBNull(dt.Rows(i).Item("VCF30C")), "", dt.Rows(i).Item("VCF30C").ToString)
                MSGridLine.Item(17, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TANK_NAME")), "", dt.Rows(i).Item("TANK_NAME").ToString)
                MSGridLine.Item(18, i).Value = IIf(IsDBNull(dt.Rows(i).Item("T_START")), "", dt.Rows(i).Item("T_START").ToString)
                MSGridLine.Item(19, i).Value = IIf(IsDBNull(dt.Rows(i).Item("T_STOP")), "", dt.Rows(i).Item("T_STOP").ToString)
                MSGridLine.Item(20, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION").ToString)

                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub UcMenuEdit_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuEdit.OnClickMnuText
        Dim id As String
        If MSGridHeader.Rows.Count <= 0 Then Exit Sub
        id = MSGridHeader.Item(1, MSGridHeader.CurrentRow.Index).Value
        frmLoadTopUp_sub.setFrmWork(2)
        frmLoadTopUp_sub.setPkId(id)
        frmLoadTopUp_sub.Show()
    End Sub

    Private Sub UcMenuDelete_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuDelete.OnClickMnuText
        If MSGridHeader.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = MSGridHeader.CurrentRow.Index
        Dim txtLoadNoClk As String = Trim(MSGridHeader.Rows(index).Cells(1).Value.ToString)

        If Trim(MSGridHeader.Rows(index).Cells(23).Value.ToString) = "ยกเลิก" Then
            MsgBox("ไม่สามารถยกเลิกได้เพราะว่า หมายเลข Topup No " & Trim(MSGridHeader.Rows(index).Cells(1).Value.ToString) & " ถูกยกเลิกไปแล้ว ", vbCritical, "ระบบแจ้งว่า")
            Exit Sub
        End If

        If MsgBox("คุณต้องการยกเลิก TOPUP หมายเลข " & txtLoadNoClk & " ?", vbOKCancel + vbInformation) = vbOK Then

            Call CancelLoadHeader(txtLoadNoClk)
            Showdata_GridMain()
        End If
    End Sub
    Private Sub CancelLoadHeader(ByVal iTopupNo)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        sql_str = _
            "UPDATE OIL_TOPUP_LINES T SET " & _
                "T.CANCEL_STATUS=1, " & _
                "T.UPDATE_DATE=sysdate," & _
                "T.UPDATED_BY='" & mUserName & "'," & _
                "T.J_COMPUTER='" & mComputerName & "' " & _
                " WHERE T.TOPUP_NO=" & Val(iTopupNo)


        If Oradb.ExeSQL(sql_str) Then
            'Call AddJournal(JournalType.Jevent, 505, 100, mUserName, 505203, iTopupNo.Text, CbLoadNo.Text, txtTuid.Text)
            MsgBox("ยกเลิกข้อมูลเรียบร้อยแล้ว", vbInformation, "ระบบแจ้งว่า")
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If

    End Sub
    Private Sub CloseLoadHeader(ByVal iTopupNo)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        sql_str = _
            "UPDATE OIL_TOPUP_LINES T SET " & _
                "T.CLOSE_LOAD =1, " & _
                "T.UPDATE_DATE=sysdate," & _
                "T.UPDATED_BY='" & mUserName & "'," & _
                "T.J_COMPUTER='" & mComputerName & "' " & _
                " WHERE T.TOPUP_NO=" & Val(iTopupNo)


        If Oradb.ExeSQL(sql_str) Then
            'Call AddJournal(JournalType.Jevent, 505, 100, mUserName, 505203, iTopupNo.Text, CbLoadNo.Text, txtTuid.Text)
            MsgBox("ปิดการใช้งานข้อมูลเรียบร้อยแล้ว", vbInformation, "ระบบแจ้งว่า")
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If

    End Sub
    Private Sub UcHeader1_CloseButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.CloseButtonClick
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UcHeader1_MinimizeButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.MinimizeButtonClick
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub UcBack1_Click(sender As Object, e As EventArgs) Handles UcBack1.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub UcBack1_MouseHover(sender As Object, e As EventArgs) Handles UcBack1.MouseHover
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("Back1")
    End Sub

    Private Sub UcBack1_MouseLeave(sender As Object, e As EventArgs) Handles UcBack1.MouseLeave
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("back")
    End Sub

    Private Sub UcBack1_Load(sender As System.Object, e As System.EventArgs) Handles UcBack1.Load

    End Sub


    Private Sub UcMenu_Close_OnClickMnuText(ucName As String, ucScreenID As Long) Handles UcMenu_Close.OnClickMnuText
        Dim index As Integer = MSGridHeader.CurrentRow.Index
        Dim txtLoadNoClk As String = Trim(MSGridHeader.Rows(index).Cells(1).Value.ToString)
        If MSGridHeader.Rows.Count <= 0 Then Exit Sub
        If MsgBox("คุณต้องการปิดการใช้งานหมายเลข TOPUP " & txtLoadNoClk & " ?", vbOKCancel + vbInformation) = vbOK Then
            Call CloseLoadHeader(txtLoadNoClk)
            Showdata_GridMain()
        End If
    End Sub


    Private Sub UcMenuPrint_Report_OnClickMnuText(ucName As String, ucScreenID As Long) Handles UcMenuPrint_Report.OnClickMnuText
        If MSGridHeader.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = MSGridHeader.CurrentRow.Index
        Dim txtLoadNoClk As String = Trim(MSGridHeader.Rows(index).Cells(1).Value.ToString)
        frmrptShowReport.mParameter = txtLoadNoClk
        frmrptShowReport.mRptFileName = "Detail Oil Topup.rpt"
        frmrptShowReport.Show()
    End Sub
End Class