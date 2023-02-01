Public Class frmProofCheckBitument

    Private Sub Show_Data(iDate As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        sql_str = _
                    " select TO_CHAR( DECODE(T.CALCULATE_MOTHOD,1,t.T_WEIGHTIN,t.t_start),'HH24:MI:SS') as ""เวลาเข้า""," & _
                    " TO_CHAR(DECODE(T.CALCULATE_MOTHOD,1,T.T_WEIGHTOUT,T.T_STOP),'HH24:MI:SS') as ""เวลาออก"",(t.weight_out-t.weight_in)/1000 as ""จำนวน(Mton)"" " & _
                    ",t.tu_id||'/'||t.tu_id1 as ""ทะเบียน"" " & _
                    " from tas.oil_load_headers t,tas.view_oil_load_lines l " & _
                    " where to_date(t.creation_date) = to_date('" & iDate & "','dd/MM/yyyy')" & _
                    " and t.cancel_status = 0 " & _
                    " and t.load_header_no = l.Load_Header_No " & _
                    " and l.PRODUCT in ('50001 - Bitumen 60/70','50021 - Bitumen 40/50') " & _
                    " and t.load_status >= 55 " & _
                    " order by ""เวลาเข้า"" "
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0

            DataGridView1.DataSource = dt
            If dt.Rows.Count > 0 Then
                For i = 0 To DataGridView1.RowCount - 1
                    Dim row As New DataGridViewRow
                    Dim col As New DataGridViewColumn
                    row = DataGridView1.Rows(i)
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    DataGridView1.Rows(i).Cells(0).Value = i + 1
                Next
            End If

        End If
        mDataSet = Nothing
    End Sub

    Private Sub frmProofCheckBitument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDay.Value = Date.Now
        Show_Data(Format(dtpDay.Value, "dd/MM/yyyy"))
    End Sub

    Private Sub dtpDay_ValueChanged(sender As Object, e As EventArgs) Handles dtpDay.ValueChanged

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


        For i = 0 To DataGridView1.RowCount - 1
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
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

    Private Sub btExport_OnClickMnuText(ucName As String, ucScreenID As Long) Handles btExport.OnClickMnuText
        Export_Excel()
    End Sub

    Private Sub btRefresh_OnClickMnuText(ucName As String, ucScreenID As Long) Handles btRefresh.OnClickMnuText
        Show_Data(Format(dtpDay.Value, "dd/MM/yyyy"))
    End Sub
End Class