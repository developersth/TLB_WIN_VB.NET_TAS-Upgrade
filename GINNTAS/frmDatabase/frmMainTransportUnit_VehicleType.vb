Public Class frmMainTransportUnit_VehicleType

    Private Sub frmMainTransportUnit_VehicleType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_Data()
    End Sub
    Public Sub Show_Data()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str =
           "select t.status_varchar as ""รหัสประเภทรถ"",t.description as ""ชื่อประเภทรถ"" " &
           " from status_desc t" &
           " where t.columns_name='TU_TYPE'" &
            " order by t.status_varchar"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView1.DataSource = dt
            For i = 0 To DataGridView1.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = DataGridView1.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            Next
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub btRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click
        Show_Data()
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        frmMainTransportUnit_VehicleType_sub.Close()
        frmMainTransportUnit_VehicleType_sub.setFrmWork(1)
        frmMainTransportUnit_VehicleType_sub.ShowDialog()
    End Sub

    Private Sub btEdit_Click(sender As Object, e As EventArgs) Handles btEdit.Click
        If DataGridView1.RowCount <= 0 Then Exit Sub
        Dim id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString
        frmMainTransportUnit_VehicleType_sub.Close()
        frmMainTransportUnit_VehicleType_sub.setFrmWork(2)
        frmMainTransportUnit_VehicleType_sub.setPkId(id)
        frmMainTransportUnit_VehicleType_sub.ShowDialog()
    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        If DataGridView1.RowCount <= 0 Then Exit Sub
        Dim result As Integer = MessageBox.Show("ต้องการลบข้อมูล : " + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + " หรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            Delete()
        End If
    End Sub
    Private Sub Delete()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim index = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString

        sql_str = " DELETE FROM STATUS_DESC    "
        sql_str = sql_str & " WHERE  STATUS_VARCHAR = '" + index + "' "
        sql_str = sql_str & "AND COLUMNS_NAME = 'TU_TYPE'"
        If Oradb.ExeSQL(sql_str) Then
            MessageBox.Show("ได้ทำการลบข้อมูลเรียบร้อย", "System TAS")
            Show_Data()
        Else
            MessageBox.Show("ไม่สามารถลบข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
    End Sub
End Class