Public Class frmProofMonitorLoadProduct
    Dim Sale_Product As String
    Private Sub InitailProduct()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim pColor As String
        sql_str = "select  s.sale_product_id as ""รหัส"",t.base_product_id as ""ชื่อผลิตภัณฑ์"" , t.color_code As ""สีผลิตภัณฑ์"" " & _
                          " from tas.base_product t , tas.sale_product s" & _
                          " Where t.base_product_id = s.sale_product_code(+) " & _
                          " order by s.sale_product_id"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            'MsGridProduct.RowCount = 0
            'If dt.Rows.Count > 0 Then
            '    Do While dt.Rows.Count > i

            '        MsGridProduct.RowCount = MsGridProduct.RowCount + 1
            '        MsGridProduct.Rows.Item(i).Height = Grid_Height
            '        pColor = IIf(IsDBNull(dt.Rows(i).Item("color_code")), "", dt.Rows(i).Item("color_code").ToString)
            '        MsGridProduct.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("base_product_id")), "", dt.Rows(i).Item("base_product_id").ToString)
            '        MsGridProduct.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("sale_product_id")), "", dt.Rows(i).Item("sale_product_id").ToString)
            '        MsGridProduct.Rows(i).Cells(0).Style.BackColor = ColorTranslator.FromHtml("#" + appendZero(Hex(pColor).ToString()))
            '        i = i + 1
            '    Loop
            'End If
            MsGridProduct.DataSource = dt
            For i = 0 To MsGridProduct.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = MsGridProduct.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                For z = 0 To MsGridProduct.Rows.Count - 1
                    pColor = MsGridProduct.Rows(z).Cells(2).Value
                    If pColor <> "" Then
                        MsGridProduct.Rows(z).Cells(2).Style.BackColor = ColorTranslator.FromHtml("#" + appendZero(Hex(pColor).ToString()))
                    End If
                Next
            Next
            If MsGridProduct.RowCount > 0 Then
                Sale_Product = MsGridProduct.Rows(0).Cells(0).Value
                ShowGridTimeLoad(MsGridProduct.Rows(0).Cells(0).Value, Format(dtpDay.Value, "dd/MM/yyyy"))
            End If
        End If
        mDataSet = Nothing
    End Sub

    Private Sub ShowGridTimeLoad(iSaleProduct As String, iDate As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer


        sql_str = "select  t.load_header_no , min(t.tu_card_no) as tu_card ,min( decode( t.tu_id1,NULL,t.tu_id,t.tu_id||'/'||t.tu_id1)) as car_no" & _
                        " ,min(t.driver_name) as driver_name  , decode(min(ol.unit),'KG',min(t.t_weightin),min(ol.t_start)  )  as t_start, " & _
                        " case when min( t.calculate_mothod )=1 then " & _
                        " case when  count(t.load_header_no) > 1 then  (sum(t.weight_out)-sum(t.weight_in))/count(t.load_header_no) " & _
                        " Else  sum (t.weight_out) - sum(t.weight_in)  End  Else sum (ol.loaded_vol30c)  End as Net  ," & _
                        " decode(min(ol.unit),'KG',min(t.t_weightout),min(t.t_stop))   as t_stop, min(ol.base_product_id) as  base_product_id , sum(ol.advice) as ordert   ,min(ol.tank_name) as tank_name" & _
                        ",decode(max(t.calculate_mothod),1,'Kg','Litre') as UnitSale  from tas.oil_load_headers t , tas.oil_load_lines  ol " & _
                        " Where t.LOAD_HEADER_NO = ol.LOAD_HEADER_NO " & _
                        " and trunc(t.eod_date) = to_date( '" & Trim(iDate) & "','dd/mm/yyyy') " & _
                        " and ol.sale_product_id='" & Trim(iSaleProduct) & "' " & _
                        " and t.cancel_status =0 " & _
                        " group by t.load_header_no , ol.sale_product_id " & _
                        " order by min(t.t_start) "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            MsGridHeader.RowCount = 0
            If dt.Rows.Count > 0 Then
                With MsGridHeader
                    For i = 0 To dt.Rows.Count - 1
                        .RowCount = .RowCount + 1
                        .Rows.Item(i).Height = Grid_Height
                        .Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOAD_HEADER_NO")), "", dt.Rows(i).Item("LOAD_HEADER_NO").ToString)
                        .Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("car_no")), "", dt.Rows(i).Item("car_no"))
                        .Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("driver_name")), "", dt.Rows(i).Item("driver_name").ToString)
                        .Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ordert")), "", dt.Rows(i).Item("ordert").ToString)
                        .Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Net")), "", dt.Rows(i).Item("Net").ToString)
                        .Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UnitSale")), "", dt.Rows(i).Item("UnitSale").ToString)
                        .Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("T_START")), "", dt.Rows(i).Item("T_START").ToString)
                        .Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("T_STOP")), "", dt.Rows(i).Item("T_STOP").ToString)
                        .Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("tank_name")), "", dt.Rows(i).Item("tank_name").ToString)
                    Next i
                End With

            End If
        End If
        mDataSet = Nothing
    End Sub
    Private Function appendZero(ByVal codeColour As String) As String
        Dim i As Integer = 6 - codeColour.Length
        While (i <> 0)
            codeColour = "0" + codeColour
            i = i - 1
        End While
        Return codeColour
    End Function

    Private Sub frmProofMonitorLoadProduct_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDay.Value = Date.Now
        InitailProduct()
    End Sub

    Private Sub MsGridProduct_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MsGridProduct.CellClick
        Try
            If Not MsGridProduct.Item(0, MsGridProduct.CurrentRow.Index).Value.Equals("") Then
                Sale_Product = MsGridProduct.Item(0, MsGridProduct.CurrentRow.Index).Value
                If MsGridProduct.RowCount > 0 And Sale_Product <> "" Then
                    ShowGridTimeLoad(Sale_Product, Format(dtpDay.Value, "dd/MM/yyyy"))
                End If
            Else
                MsGridHeader.RowCount = 0
            End If

        Catch ex As Exception
            MsGridHeader.RowCount = 0
        End Try
       
    End Sub

    Private Sub b_Refresh_Click(sender As System.Object, e As System.EventArgs) Handles b_Refresh.Click
        If Sale_Product <> "" Then
            ShowGridTimeLoad(Sale_Product, Format(dtpDay.Value, "dd/MM/yyyy"))
        End If
    End Sub

    Private Sub dtpDay_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpDay.ValueChanged
        If Sale_Product <> "" Then
            ShowGridTimeLoad(Sale_Product, Format(dtpDay.Value, "dd/MM/yyyy"))
        End If
    End Sub
End Class