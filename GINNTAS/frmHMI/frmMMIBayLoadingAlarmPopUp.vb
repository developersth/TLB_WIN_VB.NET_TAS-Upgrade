Public Class frmMMIBayLoadingAlarmPopUp
    Public vMeter_No As String
    Private Sub frmMMIBayLoadingAlramPopUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "# Alaram Meter#"
        ShowGridData()
        txtMeterName.Text = vMeter_No
    End Sub
    Private Sub ShowGridData()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = _
        "select t.* " & _
        " from steqi.accuload_alarm_status t " & _
        " where t.meter_no = '" & vMeter_No & "' AND t.status = '1' "
        Try
            If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                i = 0
                MSGridAlarm.RowCount = 0
                Do While dt.Rows.Count > i

                    MSGridAlarm.RowCount = MSGridAlarm.RowCount + 1
                    MSGridAlarm.Item(0, i).Value = (i + 1).ToString()
                    MSGridAlarm.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ALARM_GROUP")), "", dt.Rows(i).Item("ALARM_GROUP").ToString)
                    MSGridAlarm.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("alarm_name")), "", dt.Rows(i).Item("alarm_name").ToString)

                    i = i + 1

                Loop
            Else
            End If
        Catch ex As Exception

        End Try

        mDataSet = Nothing
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        ShowGridData()
    End Sub
End Class