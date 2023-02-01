Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Drawing.Printing
Public Class frmrptWeight
    'Dim iNameSerhch As String
    'Dim itxtSerch As String
    Private mDataGridFind As DataGridView
    Private frm As Form
    Dim mRowIndex As Integer
    Private Sub frmrptWeight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowGridData()
        Show_fixGrindColor()
        cbSerch.SelectedIndex = 0
        cbProduct.SelectedIndex = 0
    End Sub
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

        If cbProduct.Text = "ALL" Then
            sql_str = "SELECT DISTINCT " & _
                              "T.LOAD_HEADER_NO,SHIPMENT_NO,T.TU_ID, " & _
                              "T.WEIGHT_IN,T.WEIGHT_OUT " & _
                              "FROM RPT.VIEW_DATA_WEIGHT T " & _
                              "WHERE TO_CHAR(T.T_WEIGHTIN,'DD/MM/YYYY') ='" & Format(MVDate.SelectionRange.Start()) & "' " & _
                             "ORDER BY T.LOAD_HEADER_NO ASC"
        ElseIf cbProduct.Text = "Slack wax" Then
            sql_str = "SELECT DISTINCT " & _
                              "T.LOAD_HEADER_NO,SHIPMENT_NO,T.TU_ID, " & _
                              "T.WEIGHT_IN,T.WEIGHT_OUT " & _
                              "FROM RPT.VIEW_DATA_WEIGHT T " & _
                              "WHERE TO_CHAR(T.T_WEIGHTIN,'DD/MM/YYYY') ='" & Format(MVDate.SelectionRange.Start()) & "' " & _
                              "AND  t.SALE_PRODUCT_NAME in ('Slack wax 500','Slack wax 150','Slack wax BS') " & _
                              "ORDER BY T.LOAD_HEADER_NO ASC"
        ElseIf cbProduct.Text = "Extract" Then
            sql_str = "SELECT DISTINCT " & _
                              "T.LOAD_HEADER_NO,SHIPMENT_NO,T.TU_ID, " & _
                              "T.WEIGHT_IN,T.WEIGHT_OUT " & _
                              "FROM RPT.VIEW_DATA_WEIGHT T " & _
                              "WHERE TO_CHAR(T.T_WEIGHTIN,'DD/MM/YYYY') ='" & Format(MVDate.SelectionRange.Start()) & "' " & _
                               "AND  t.SALE_PRODUCT_NAME in ('Extract 500N','Extract 150BS','Extract  150N') " & _
                             "ORDER BY T.LOAD_HEADER_NO ASC"
        ElseIf cbProduct.Text = "Bitumen" Then
            sql_str = "SELECT DISTINCT " & _
                              "T.LOAD_HEADER_NO,SHIPMENT_NO,T.TU_ID, " & _
                              "T.WEIGHT_IN,T.WEIGHT_OUT " & _
                              "FROM RPT.VIEW_DATA_WEIGHT T " & _
                              "WHERE TO_CHAR(T.T_WEIGHTIN,'DD/MM/YYYY') ='" & Format(MVDate.SelectionRange.Start()) & "' " & _
                              "AND  t.SALE_PRODUCT_NAME in ('Bitumen 60/70','Bitumen 40/50') " & _
                              "ORDER BY T.LOAD_HEADER_NO ASC"
        ElseIf cbProduct.Text = "Aroma" Then
            sql_str = "SELECT DISTINCT " & _
                              "T.LOAD_HEADER_NO,SHIPMENT_NO,T.TU_ID, " & _
                              "T.WEIGHT_IN,T.WEIGHT_OUT " & _
                              "FROM RPT.VIEW_DATA_WEIGHT T " & _
                              "WHERE TO_CHAR(T.T_WEIGHTIN,'DD/MM/YYYY') ='" & Format(MVDate.SelectionRange.Start()) & "' " & _
                              "AND  t.SALE_PRODUCT_NAME = 'Aroma_Solvate' " & _
                              "ORDER BY T.LOAD_HEADER_NO ASC"
        Else
            Exit Sub

        End If


        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            msGridLoad.RowCount = 0
            txtCount.Text = dt.Rows.Count
            Do While dt.Rows.Count > i

                msGridLoad.RowCount = msGridLoad.RowCount + 1
                'msGridLoad.Rows.Item(i).Height = Grid_Height
                msGridLoad.Item(0, i).Value = (i + 1).ToString()

                msGridLoad.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOAD_HEADER_NO")), "", dt.Rows(i).Item("LOAD_HEADER_NO").ToString)
                msGridLoad.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SHIPMENT_NO")), "", dt.Rows(i).Item("SHIPMENT_NO").ToString)

                msGridLoad.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TU_ID")), "", dt.Rows(i).Item("TU_ID").ToString)
                msGridLoad.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("WEIGHT_IN")), "", dt.Rows(i).Item("WEIGHT_IN").ToString)
                msGridLoad.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("WEIGHT_OUT")), "", dt.Rows(i).Item("WEIGHT_OUT").ToString)

                i = i + 1

            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub
    Private Sub ShowGridDataSerch(ByVal itxtSerch, ByVal iNameSerhch)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        MessageBox.Show("AND T." & iNameSerhch.ToString() & " LIKE (%" & itxtSerch.ToString() & ")")

        sql_str = "SELECT DISTINCT " & _
                  "T.LOAD_HEADER_NO,SHIPMENT_NO,T.TU_ID, " & _
                  "T.WEIGHT_IN,T.WEIGHT_OUT " & _
                  "FROM RPT.VIEW_DATA_WEIGHT T " & _
                  "WHERE TO_CHAR(T.T_WEIGHTIN,'DD/MM/YYYY') ='" & Format(MVDate.SelectionRange.Start()) & "' " & _
                  "AND T.LOAD_HEADER_NO LIKE ('%5101%') " & _
                  "ORDER BY T.LOAD_HEADER_NO ASC"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            msGridLoad.RowCount = 0
            txtCount.Text = dt.Rows.Count
            Do While dt.Rows.Count > i

                msGridLoad.RowCount = msGridLoad.RowCount + 1
                'msGridLoad.Rows.Item(i).Height = Grid_Height
                msGridLoad.Item(0, i).Value = (i + 1).ToString()

                msGridLoad.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOAD_HEADER_NO")), "", dt.Rows(i).Item("LOAD_HEADER_NO").ToString)
                msGridLoad.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SHIPMENT_NO")), "", dt.Rows(i).Item("SHIPMENT_NO").ToString)

                msGridLoad.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TU_ID")), "", dt.Rows(i).Item("TU_ID").ToString)
                msGridLoad.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("WEIGHT_IN")), "", dt.Rows(i).Item("WEIGHT_IN").ToString)
                msGridLoad.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("WEIGHT_OUT")), "", dt.Rows(i).Item("WEIGHT_OUT").ToString)

                i = i + 1

            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub


    Private Sub MVDate_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MVDate.DateChanged
        ShowGridData()
    End Sub

    Private Sub msGridLoad_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msGridLoad.DoubleClick
        Dim index As Integer = msGridLoad.CurrentRow.Index
        'frmrptShowReport.mParameter = msGridLoad.Rows(index).Cells(1).Value
        'frmrptShowReport.mRptFileName = "Weight InOut.rpt"
        'frmrptShowReport.Show()
        Show_Report(msGridLoad.Rows(index).Cells(1).Value)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        If msGridLoad.RowCount = 0 Then
            Exit Sub
        End If
        Dim index As Integer = msGridLoad.CurrentRow.Index
        'frmrptShowReport.mParameter = msGridLoad.Rows(index).Cells(1).Value
        'frmrptShowReport.mRptFileName = "Weight InOut.rpt"
        'frmrptShowReport.Show()
        Show_Report(msGridLoad.Rows(index).Cells(1).Value)
    End Sub

    Private Sub Show_Report(iLoadNo As String)
        With frmrptMainShow
            .report_id = "52010031"
            .load_no = iLoadNo
            .Show()
        End With
    End Sub
    Private Sub cmdSerch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSerch.Click
        Dim txtCombo As String
        txtCombo = ""
        If (cbSerch.SelectedIndex = 0) Then
            txtCombo = "LOAD_HEADER_NO"
        ElseIf (cbSerch.SelectedIndex = 1) Then
            txtCombo = "SHIPMENT_NO"
        ElseIf (cbSerch.SelectedIndex = 2) Then
            txtCombo = "TU_ID"
        End If
        ShowGridDataSerch(txtLoadNoClk, txtCombo)
    End Sub

    Private Sub cbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduct.SelectedIndexChanged
        ShowGridData()
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        If msGridLoad.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = msGridLoad.CurrentRow.Index
        If MsgBox("ท่านต้องการพิมพ์รายงานใบชั่งน้ำหนัก หรือไม่", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If
        'DirectPrint("Weight InOut.rpt", msGridLoad.Rows(index).Cells(1).Value)
        DirectPrinter("52010031", "", msGridLoad.Rows(index).Cells(1).Value.ToString())
    End Sub


    Public Function App_Path() As String
        App_Path = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
    End Function

    Private Sub btPrinterAll_Click(sender As Object, e As EventArgs) Handles btPrinterAll.Click
        If msGridLoad.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = msGridLoad.CurrentRow.Index
        If MsgBox("ท่านต้องการพิมพ์รายงานใบชั่งน้ำหนัก หรือไม่", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If
        For j As Integer = 0 To msGridLoad.RowCount - 1
            DirectPrinter("52010031", "", msGridLoad.Rows(index).Cells(1).Value.ToString())
        Next j
    End Sub
End Class