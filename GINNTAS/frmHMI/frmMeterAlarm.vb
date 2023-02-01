Public Class frmMeterAlarm

    Public Meter_no As String
    Dim Product_no As String
    Private Sub frmMeterAlarm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowMeterAlarm()
    End Sub

    Private Sub ShowMeterAlarm()

        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim vTotal As Integer
        vTotal = 0
        strSQL = "select t.* " & _
                 " from steqi.view_meter_alarm t"

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            MsGrid.RowCount = 0
            vTotal = dt.Rows.Count

            Do While vTotal > i
                MsGrid.RowCount = MsGrid.RowCount + 1
                MsGrid.Rows.Item(i).Height = Grid_Height
                MsGrid.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("METER_NO")), "", dt.Rows(i).Item("METER_NO").ToString)
                MsGrid.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("BASE_PRODUCT_ID")), "", dt.Rows(i).Item("BASE_PRODUCT_ID").ToString)
                i = i + 1
            Loop
        Else
            MsGrid.RowCount = 1

        End If
        mDataSet = Nothing
    End Sub

    Private Sub cmdRefresh_Click(sender As System.Object, e As System.EventArgs) Handles cmdRefresh.Click
        ShowMeterAlarm()
    End Sub

    Private Sub cmdClose_Click(sender As System.Object, e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmShowMeterAlarm_Click(sender As System.Object, e As System.EventArgs) Handles cmShowMeterAlarm.Click
        If Meter_no = "" Then
            Exit Sub
        End If
        frmMMIBayLoadingAlarmPopUp.Show()
    End Sub

    Private Sub cmResetMeter_Click(sender As System.Object, e As System.EventArgs) Handles cmResetMeter.Click
        If Meter_no = "" Then Exit Sub
        If RunProcResetAlarmMeter(Meter_no) Then
            MsgBox("ทำการ Reset Alarm ชอง Meter :" & Meter_no & " เรียบร้อยแล้ว")
        End If
        Call ShowMeterAlarm()
    End Sub
    Private Function RunProcResetAlarmMeter(ByVal iMeter As String) As Boolean
        Dim strSQL As String
        RunProcResetAlarmMeter = False
        If iMeter = "" Then Exit Function
        strSQL = ""
        strSQL = strSQL & "begin "
        strSQL = strSQL & " load.BATCH_SET_RESET_ALARM ('" & Trim(iMeter) & "'); "
        strSQL = strSQL & "end;"
        Dim mDataSet As New DataSet
        Dim tempMeterLoaded = ""
        RunProcResetAlarmMeter = Oradb.OpenDys(strSQL, "TableName1", mDataSet)
        mDataSet = Nothing

    End Function
End Class