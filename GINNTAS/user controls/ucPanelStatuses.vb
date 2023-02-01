Public Class ucPanelStatuses
    Dim AlarmMsg As String
    Private Sub tScanTime_Tick(sender As System.Object, e As System.EventArgs) Handles tScanTime.Tick
        Call InitialObject(ShowAlarm, AlarmMssg, ShowComm, ShowAlarmMeter)
    End Sub
    Public Sub InitialObject(iAlarm As Long, AlarmMssg As String, Comm As Long, Meter As Long)
        AlarmAlarm(iAlarm, AlarmMssg)
    End Sub
    Private Sub AlarmAlarm(iAlarm As Long, AlarmMssg As String)
        If iAlarm = 1 Then
            ' UcBtnAlarm.MenuImage = My.Resources.ResourceManager.GetObject("mnubg_n1")
            UcBtnAlarm.MenuImage = Image.FromFile(GetCurrDirectory() & "\pictures\mnubg_n1.gif")
            UcBtnAlarm.MenuBackColor = Color.Red
            txtAlarmMsg.Text = AlarmMssg
        Else
            UcBtnAlarm.MenuImage = My.Resources.ResourceManager.GetObject("mnubg_n")
            UcBtnAlarm.MenuBackColor = Color.Black
            txtAlarmMsg.Text = AlarmMssg
        End If
    End Sub
    Public Function ShowAlarm() As Long
        Dim strSQL As String, i As Long, j As Long
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        strSQL = _
        " select T.* " & _
        " from TAS.VIEW_PANEL T"
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            If dt.Rows.Count > i Then
                j = IIf(IsDBNull(dt.Rows(i).Item("ALARM_STATUS")), "", dt.Rows(i).Item("ALARM_STATUS").ToString)
                If j = 1 Then
                    ShowAlarm = 1
                    AlarmMssg = dt.Rows(i).Item("ALARM_CURRENT").ToString
                Else
                    ShowAlarm = 0
                    AlarmMssg = "- -"
                End If
            End If
        End If

        mDataSet = Nothing
    End Function
    'Public ShowComm     As Long
    'Public ShowAlarmMeter     As Long
    Public Function ShowAlarmMeter() As Long
        Dim i As Long
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        strSQL = _
        " select steqi.GET_MONITOR_ALARM_METER as Load " & _
        " from dual "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            If dt.Rows.Count > i Then
                If (dt.Rows(i).Item("Load")) = "1" Then
                    ShowAlarmMeter = 1
                Else
                    ShowAlarmMeter = 0
                End If
            End If
        End If
        mDataSet = Nothing
        Return ShowAlarmMeter
    End Function

    Public Function ShowComm() As Long
        Dim i As Long
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        strSQL = _
        " select steqi.GET_MONITOR_COMM as Comm " & _
        " from dual "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            If dt.Rows.Count > i Then
                If (dt.Rows(i).Item("Comm")) >= "1" Then
                    ShowComm = 1
                Else
                    ShowComm = 0
                End If
            End If
        End If
        mDataSet = Nothing
        Return ShowComm
    End Function


    Private Sub btnComm_Click(sender As System.Object, e As System.EventArgs)
        frmCommunication.Show()
    End Sub

    Private Sub btnMeter_Click(sender As System.Object, e As System.EventArgs)
        frmMeterAlarm.Show()
    End Sub

    Private Sub btnAlarm_Click(sender As System.Object, e As System.EventArgs)
        frmScanAlarm.Show()
    End Sub

    Private Sub UcMnuText3_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64)
        frmMeterAlarm.Show()
    End Sub

    Private Sub UcBtnAlarm_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcBtnAlarm.OnClickMnuText
        frmScanAlarm.Show()
    End Sub
End Class
