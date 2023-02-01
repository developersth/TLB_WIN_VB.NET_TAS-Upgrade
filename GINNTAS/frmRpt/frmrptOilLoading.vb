Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Drawing.Printing
Public Class frmrptOilLoading
    Public LoadNo As String
    Dim ReportID() As Long
    Dim DateStart As String
    Dim TimeStart As String
    Dim DateEnd As String
    Dim TimeEnd As String
    Private Sub frmrptOilLoading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DTPTimeStart.Value = Format(DTPTimeStart, "hh:mm:ss")
        'DTPTimeEnd.Value = Format(Now, "hh:mm:ss")
        cbProduct.SelectedIndex = 0
        FindDataTime()
        Show_fixGrindColor()

    End Sub
    Private Sub FindDataTime()
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

        'DateStart = "15/11/2014 00:00:00"
        'DateSEnd = "01/04/2015 22:00:00"
        If cbProduct.Text = "ALL" Then
            sql_str = _
         "SELECT H.LOAD_HEADER_NO,H.SHIPMENT_NO,H.LOAD_STATUS||' - '||S.DESCRIPTION as STATUS,H.TRIP_NO,H.TU_CARD_NO,H.VEHICLE_ID,H.TU_ID," & _
         "H.DRIVER_NAME,H.SEAL_NUMBER,H.T_BILLING,H.LOCKED,H.LOAD_STATUS,H.CANCEL_STATUS," & _
         "H.T_START,H.T_STOP,H.CARRIER_NAME " & _
         "FROM OIL_LOAD_HEADERS H,STATUS_DESC S " & _
         "WHERE H.T_BILLING Between  to_date('" & iDateStart & "','dd/mm/yyyy hh24:mi:ss') and to_date('" & iDateEnd & "','dd/mm/yyyy hh24:mi:ss') " & _
         "AND H.LOAD_STATUS >=54 " & _
         "AND H.LOAD_STATUS=S.STATUS_NUMBER(+) " & _
         "AND ((S.T_NAME='OIL_LOAD_HEADERS' AND S.COLUMNS_NAME='LOAD_STATUS') OR S.T_NAME is null) " & _
         "ORDER BY H.LOAD_STATUS DESC,H.LOAD_HEADER_NO DESC"
        ElseIf cbProduct.Text = "Base Oil" Then
            sql_str = _
         "SELECT distinct H.LOAD_HEADER_NO,H.SHIPMENT_NO,H.LOAD_STATUS||' - '||S.DESCRIPTION as STATUS,H.TRIP_NO,H.TU_CARD_NO,H.VEHICLE_ID,H.TU_ID," & _
         "H.DRIVER_NAME,H.SEAL_NUMBER,H.T_BILLING,H.LOCKED,H.LOAD_STATUS,H.CANCEL_STATUS," & _
         "H.T_START,H.T_STOP,H.CARRIER_NAME " & _
         "FROM OIL_LOAD_HEADERS H,STATUS_DESC S,rpt.daily_loading_detail r  " & _
         "WHERE H.T_BILLING Between  to_date('" & iDateStart & "','dd/mm/yyyy hh24:mi:ss') and to_date('" & iDateEnd & "','dd/mm/yyyy hh24:mi:ss') " & _
         "AND H.LOAD_STATUS >=54 " & _
         "AND H.LOAD_STATUS=S.STATUS_NUMBER(+) " & _
         "AND ((S.T_NAME='OIL_LOAD_HEADERS' AND S.COLUMNS_NAME='LOAD_STATUS') OR S.T_NAME is null) " & _
         "and h.load_header_no = r.load_header_no " & _
         "and r.sale_product_code in ('500N','150N','150BS') " & _
         "ORDER BY H.LOAD_STATUS DESC,H.LOAD_HEADER_NO DESC"
        ElseIf cbProduct.Text = "Bitument" Then
            sql_str = _
          "SELECT distinct H.LOAD_HEADER_NO,H.SHIPMENT_NO,H.LOAD_STATUS||' - '||S.DESCRIPTION as STATUS,H.TRIP_NO,H.TU_CARD_NO,H.VEHICLE_ID,H.TU_ID," & _
          "H.DRIVER_NAME,H.SEAL_NUMBER,H.T_BILLING,H.LOCKED,H.LOAD_STATUS,H.CANCEL_STATUS," & _
          "H.T_START,H.T_STOP,H.CARRIER_NAME " & _
          "FROM OIL_LOAD_HEADERS H,STATUS_DESC S,rpt.daily_loading_detail r " & _
          "WHERE H.T_BILLING Between  to_date('" & iDateStart & "','dd/mm/yyyy hh24:mi:ss') and to_date('" & iDateEnd & "','dd/mm/yyyy hh24:mi:ss') " & _
          "AND H.LOAD_STATUS >=54 " & _
          "AND H.LOAD_STATUS=S.STATUS_NUMBER(+) " & _
          "AND ((S.T_NAME='OIL_LOAD_HEADERS' AND S.COLUMNS_NAME='LOAD_STATUS') OR S.T_NAME is null) " & _
           "and h.load_header_no = r.load_header_no " & _
         "and r.sale_product_code in ('BITUMEN') " & _
          "ORDER BY H.LOAD_STATUS DESC,H.LOAD_HEADER_NO DESC"
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
                msGridLoad.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_NAME")), "", dt.Rows(i).Item("DRIVER_NAME").ToString)
                msGridLoad.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOAD_STATUS")), "", dt.Rows(i).Item("LOAD_STATUS").ToString)

                i = i + 1

            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub CmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRefresh.Click
        FindDataTime()
    End Sub

    Private Sub msGridLoad_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msGridLoad.DoubleClick
        Dim index As Integer = msGridLoad.CurrentRow.Index
        ShowReport(msGridLoad.Rows(index).Cells(1).Value.ToString(), "52010007")

    End Sub
    Private Sub ShowReport(ByVal iLoad_no As String, ByVal iReportID As String)
        With frmrptMainShow
            .load_no = iLoad_no
            .report_id = iReportID
            .Show()
        End With
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        Dim index As Integer = msGridLoad.CurrentRow.Index
        ShowReport(msGridLoad.Rows(index).Cells(1).Value.ToString(), "52010007")
    End Sub


    Private Sub cbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduct.SelectedIndexChanged
        FindDataTime()
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click

        If msGridLoad.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = msGridLoad.CurrentRow.Index
        If MsgBox("ท่านต้องการพิมพ์รายงานการจ่าย หรือไม่", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If
        DirectPrinter("52010007", "", msGridLoad.Rows(index).Cells(1).Value)
    End Sub


    Public Function App_Path() As String
        App_Path = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
    End Function

    Private Sub cmdPrintAll_Click(sender As Object, e As EventArgs) Handles cmdPrintAll.Click
        If msGridLoad.Rows.Count <= 0 Then Exit Sub
        If MsgBox("ท่านต้องการพิมพ์รายงานการจ่าย หรือไม่", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If
        For j As Integer = 0 To msGridLoad.RowCount - 1
            DirectPrinter("52010007", "", msGridLoad.Rows(j).Cells(1).Value)
        Next j

    End Sub
End Class