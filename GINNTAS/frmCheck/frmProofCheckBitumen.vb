Public Class frmProofCheckBitumen
    Private Sub ShowGridTimeLoad()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer


        sql_str = " select TO_CHAR(t.t_start,'HH24:MI:SS') as ""เวลาเข้า"",TO_CHAR(t.t_stop,'HH24:MI:SS') as ""เวลาออก"",(t.weight_out-t.weight_in)/1000 as ""จำนวน(Mton)"",t.tu_id||'/'||t.tu_id1 as ""ทะเบียน""  " & _
                  " from view_oil_load_headers t,tas.view_oil_load_lines l " & _
                  " where to_date(t.creation_date) = to_date( '" & Format(dtpDay.Value & ",'dd/mm/yyyy''") & "','dd/mm/yyyy') " & _
                  " and t.cancel_status = 0 " & _
                  " and t.load_header_no = l.Load_Header_No " & _
                  " and l.PRODUCT = '50001 - Bitumen 60/70' " & _
                  "  order by t.t_start "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            DataGridView1.RowCount = 0
            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
                For i = 0 To DataGridView1.ColumnCount - 1
                    Dim col As New DataGridViewColumn
                    col = DataGridView1.Columns(i)
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Next
            End If
        End If
        mDataSet = Nothing
    End Sub

    Private Sub frmProofCheckBitumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDay.Value = Date.Now
        ShowGridTimeLoad()
    End Sub


    Private Sub dtpDay_ValueChanged(sender As Object, e As EventArgs) Handles dtpDay.ValueChanged
        ShowGridTimeLoad()
    End Sub
End Class