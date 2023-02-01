Public Class frmCommunication

    Dim vMeter As String
    Private Sub frmCommunication_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowCommunication()
    End Sub


    Private Sub ShowCommunication()

        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim vTotal As Integer
        vTotal = 0
        strSQL = _
                "select t.DEVICE_NAME,t.DESCRIPTION " & _
                " from steqi.view_communication_status t"
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            MsGrid.RowCount = 0
            vTotal = dt.Rows.Count
            txtCommfail.Text = vTotal.ToString
            Do While vTotal > i
                MsGrid.RowCount = MsGrid.RowCount + 1
                MsGrid.Rows.Item(i).Height = Grid_Height
                MsGrid.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DEVICE_NAME")), "", dt.Rows(i).Item("DEVICE_NAME").ToString)
                MsGrid.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION").ToString)
                i = i + 1
            Loop
        Else
            MsGrid.RowCount = 1

        End If
        mDataSet = Nothing
    End Sub

    Private Sub cmdRefresh_Click(sender As System.Object, e As System.EventArgs) Handles cmdRefresh.Click
        ShowCommunication()
    End Sub

    Private Sub cmdClose_Click(sender As System.Object, e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmResetMeter_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class