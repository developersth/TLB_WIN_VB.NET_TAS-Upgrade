Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Imports System.Drawing.Printing
Imports System.IO
Imports System.Threading

Public Class frmrptProductDelivery
    Public LoadNo As String
    Dim ReportID() As Long
    Dim DateStart As String
    Dim TimeStart As String
    Dim DateEnd As String
    Dim TimeEnd As String
    Dim PrinterNameGovProject As String
    Private Sub FindDataTime()
        DTPTimeEnd.Value = DateTime.Now()
        DateStart = Format(dtpChoosDate.Value, "dd/MM/yyyy")
        TimeStart = Format(DTPTimeStart.Value, "HH:mm:ss")
        DateEnd = Format(dtpChoosDateEnd.Value, "dd/MM/yyyy")
        TimeEnd = Format(DTPTimeEnd.Value, "HH:mm:ss")
        DateStart = DateStart & " " & TimeStart
        DateEnd = DateEnd & " " & TimeEnd

        Call ShowGridData(DateStart, DateEnd)
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
    Private Sub ShowGridData(ByVal iDateStart As String, ByVal iDateEnd As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim showdate As String = String.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now)

        sql_str =
           "SELECT DISTINCT " &
            "T.LOAD_HEADER_NO,SHIPMENT_NO,T.TU_ID, " &
            "T.DRIVER_NAME,T.LOAD_STATUS,T.GOV_PROJECT,T.GOV_PRINT_NO " &
            "FROM RPT.DAILY_LOADING_DETAIL T " &
            "WHERE T.EOD_DATE Between " &
            " to_date('" & iDateStart & "','dd/mm/yyyy hh24:mi:ss') and " &
            " to_date('" & iDateEnd & "','dd/mm/yyyy hh24:mi:ss') " &
            "and T.LOAD_STATUS >=54 " &
            "and T.cancel_status=0 " &
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
                msGridLoad.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_NAME")), "", dt.Rows(i).Item("DRIVER_NAME").ToString)
                msGridLoad.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOAD_STATUS")), "", dt.Rows(i).Item("LOAD_STATUS").ToString)
                msGridLoad.Item(6, i).Value = IIf(IIf(IsDBNull(dt.Rows(i).Item("GOV_PROJECT")), "", dt.Rows(i).Item("GOV_PROJECT").ToString) = 1, "ผ่าน", "")
                msGridLoad.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("GOV_PRINT_NO")), "", dt.Rows(i).Item("GOV_PRINT_NO").ToString)

                i = i + 1

            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub CmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRefresh.Click
        FindDataTime()
    End Sub

    Private Sub frmrptProductDelivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FindDataTime()
        Show_fixGrindColor()
    End Sub
    Private Sub SqlParameter(LoadHeader_NO As String)
        Dim strSQL As String
        strSQL =
                               "select t.*" &
                              " from rpt.VIEW_DELIV_HEADER t " &
                              " where t.LOAD_HEADER_NO=" + LoadHeader_NO
        frmShowReportDelivery.strSQL = strSQL
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim index As Integer = msGridLoad.CurrentRow.Index
        If msGridLoad.Rows.Count <= 0 Or msGridLoad.CurrentRow.Index < 0 Then Exit Sub
        Dim load_no As String = msGridLoad.Rows(index).Cells(1).Value.ToString()
        ShowReport(load_no)
    End Sub
    Private Sub ShowReport(ByVal iLoad_no)
        P_GEN_DELIVERY_REPORT(iLoad_no)
        With frmrptMainShow
            .load_no = iLoad_no
            .report_id = "52010040"
            .Show()
        End With
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        Dim index As Integer = msGridLoad.CurrentRow.Index
        If msGridLoad.Rows.Count <= 0 Or msGridLoad.CurrentRow.Index < 0 Then Exit Sub
        P_GEN_DELIVERY_REPORT(msGridLoad.Rows(index).Cells(1).Value)
        If MsgBox("ท่านต้องการพิมพ์หมายเลข Load No. " & msGridLoad.Rows(index).Cells(1).Value & " หรือไม่", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If
        Call DirectPrinter("52010040", "", msGridLoad.Rows(index).Cells(1).Value, )
    End Sub


    Private Sub PrintFile(ByVal filePath As String, ByVal printerName As String)
        Try
            Dim process As Process = New Process()
            process.StartInfo.FileName = filePath
            process.StartInfo.Verb = "PrintTo"
            process.StartInfo.Arguments = """" & printerName & """"
            process.Start()
            process.WaitForInputIdle()
            Thread.Sleep(5000)

            If False = process.CloseMainWindow() Then
                process.Kill()
            End If

        Catch
        End Try
    End Sub


    Private Sub cmdPreadyAttach_Click(sender As Object, e As EventArgs) Handles cmdPreadyAttach.Click
        Dim index As Integer = msGridLoad.CurrentRow.Index
        If msGridLoad.Rows.Count <= 0 Or msGridLoad.CurrentRow.Index < 0 Then Exit Sub
        P_GEN_DELIVERY_REPORT(msGridLoad.Rows(index).Cells(1).Value)
        If MsgBox("ท่านต้องการพิมพ์หมายเลข Load No. " & msGridLoad.Rows(index).Cells(1).Value & " หรือไม่", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If
        Call DirectPrinter("52010057", "", msGridLoad.Rows(index).Cells(1).Value, )
    End Sub

    Private Sub cmdPrintAttach_Click(sender As Object, e As EventArgs) Handles cmdPrintAttach.Click
        Dim index As Integer = msGridLoad.CurrentRow.Index
        If msGridLoad.Rows.Count <= 0 Or msGridLoad.CurrentRow.Index < 0 Then Exit Sub
        P_GEN_DELIVERY_REPORT(msGridLoad.Rows(index).Cells(1).Value)
        With frmrptMainShow
            .load_no = msGridLoad.Rows(index).Cells(1).Value.ToString()
            .report_id = "52010057"
            .Show()
        End With
    End Sub

    Private Sub msGridLoad_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles msGridLoad.CellDoubleClick
        Dim index As Integer = msGridLoad.CurrentRow.Index
        If msGridLoad.Rows.Count <= 0 Or msGridLoad.CurrentRow.Index < 0 Then Exit Sub
        Dim load_no As String = msGridLoad.Rows(index).Cells(1).Value
        ShowReport(load_no)
    End Sub
    Private Sub P_GEN_DELIVERY_REPORT(LoadNO As String)
        Dim strSQL As String
        strSQL = " "
        strSQL = strSQL & " Begin "
        strSQL = strSQL & " RPT.GEN_DELIVERY_REPORT(" & Convert.ToInt32(LoadNO) & ");End;"
        If Oradb.ExeSQL(strSQL) Then
        End If
    End Sub

End Class