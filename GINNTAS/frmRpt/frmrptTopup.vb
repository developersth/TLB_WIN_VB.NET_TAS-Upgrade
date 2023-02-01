Public Class frmrptTopup
    Private Sub Show_fixGrindColor()
        With msGridLoad
            .ColumnHeadersDefaultCellStyle.BackColor = Color.LightPink
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumBlue
            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .RowHeadersDefaultCellStyle.BackColor = Color.LightPink
            .RowHeadersDefaultCellStyle.SelectionBackColor = Color.LightPink
            .RowHeadersDefaultCellStyle.SelectionForeColor = Color.LightPink
            .AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGreen
            .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Yellow
            .AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Maroon
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.SelectionBackColor = Color.Yellow
            .DefaultCellStyle.SelectionForeColor = Color.Maroon
        End With
    End Sub
    Private Sub ShowGridData()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer


        sql_str = "select t.topup_no,t.shipment_no,t.load_header_no,t.compartment_no,t.island_name,t.sale_product_id,t.sale_product_name," & _
                        "t.preset,t.meter_no,t.t_start,t.t_stop,t.creation_date,t.created_by,t.update_date,t.updated_by,t.driver_name,t.carrier_name," & _
                        "t.vehicle_number , t.vehicle_type, t.vehicle_id, t.customer_name, t.shipto_name,t.description" & _
                        " from oil_topup_lines t" & _
                        " where t.cancel_status=0  and  TO_CHAR(T.creation_date,'DD/MM/YYYY') ='" & MVDate.SelectionRange.Start() & "' " & _
                        " order by t.topup_no asc"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            msGridLoad.RowCount = 0
            txtCount.Text = dt.Rows.Count
            Do While dt.Rows.Count > i

                msGridLoad.RowCount = msGridLoad.RowCount + 1
                'msGridLoad.Rows.Item(i).Height = Grid_Height
                msGridLoad.Item(0, i).Value = (i + 1).ToString()

                msGridLoad.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("topup_no")), "", dt.Rows(i).Item("topup_no").ToString)
                msGridLoad.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SHIPMENT_NO")), "", dt.Rows(i).Item("SHIPMENT_NO").ToString)

                msGridLoad.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("load_header_no")), "", dt.Rows(i).Item("load_header_no").ToString)
                msGridLoad.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("compartment_no")), "", dt.Rows(i).Item("compartment_no").ToString)
                msGridLoad.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("island_name")), "", dt.Rows(i).Item("island_name").ToString)


                msGridLoad.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("preset")), "", dt.Rows(i).Item("preset").ToString)
                msGridLoad.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("sale_product_id")), "", dt.Rows(i).Item("sale_product_id").ToString)
                msGridLoad.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("preset")), "", dt.Rows(i).Item("preset").ToString)

                msGridLoad.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Meter_no")), "", dt.Rows(i).Item("Meter_no").ToString)
                msGridLoad.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("T_START")), "", dt.Rows(i).Item("T_START").ToString)

                msGridLoad.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("t_stop")), "", dt.Rows(i).Item("t_stop").ToString)
                msGridLoad.Item(12, i).Value = IIf(IsDBNull(dt.Rows(i).Item("driver_name")), "", dt.Rows(i).Item("driver_name").ToString)
                msGridLoad.Item(13, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Carrier_name")), "", dt.Rows(i).Item("Carrier_name").ToString)

                msGridLoad.Item(14, i).Value = IIf(IsDBNull(dt.Rows(i).Item("vehicle_number")), "", dt.Rows(i).Item("vehicle_number").ToString)
                msGridLoad.Item(15, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Vehicle_Type")), "", dt.Rows(i).Item("Vehicle_Type").ToString)
                msGridLoad.Item(16, i).Value = IIf(IsDBNull(dt.Rows(i).Item("vehicle_id")), "", dt.Rows(i).Item("vehicle_id").ToString)

                msGridLoad.Item(17, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Customer_name")), "", dt.Rows(i).Item("Customer_name").ToString)
                msGridLoad.Item(18, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ShipTo_name")), "", dt.Rows(i).Item("ShipTo_name").ToString)
                msGridLoad.Item(19, i).Value = IIf(IsDBNull(dt.Rows(i).Item("update_date")), "", dt.Rows(i).Item("update_date").ToString)
                msGridLoad.Item(20, i).Value = IIf(IsDBNull(dt.Rows(i).Item("created_by")), "", dt.Rows(i).Item("created_by").ToString)

                msGridLoad.Item(21, i).Value = IIf(IsDBNull(dt.Rows(i).Item("description")), "", dt.Rows(i).Item("description").ToString)

                i = i + 1

            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub frmrptTopup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Show_fixGrindColor()
        ShowGridData()
    End Sub

    Private Sub MVDate_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MVDate.DateChanged
        ShowGridData()
    End Sub
    Private Sub msGridLoad_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msGridLoad.DoubleClick
        Dim index As Integer = msGridLoad.CurrentRow.Index
        frmrptShowReport.mParameter = msGridLoad.Rows(index).Cells(3).Value
        frmrptShowReport.mRptFileName = "Detail Oil Topup.rpt"
        frmrptShowReport.Show()

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        Dim index As Integer = msGridLoad.CurrentRow.Index
        frmrptShowReport.mParameter = msGridLoad.Rows(index).Cells(3).Value
        frmrptShowReport.mRptFileName = "Detail Oil Topup.rpt"
        frmrptShowReport.Show()
    End Sub
End Class