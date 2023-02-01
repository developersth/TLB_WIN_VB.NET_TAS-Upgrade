Public Class frmScanAlarm
    Enum AlarmPageName
        PLC = 0
        COMM = 1
        METER = 2
        TAS = 3
    End Enum

    Public AlarmMsgCurrent As String
    Dim SelAlarmID As String
    Dim rowSelectPLCAlarm As Integer = -1
    Dim rowSelectCommAlarm As Integer = -1
    Dim rowSelectMeterAlarm As Integer = -1
    Dim rowSelectTasAlarm As Integer = -1
    'Dim vMeter As String
    Public Meter_no As String
    Dim alarmPage As AlarmPageName
    Dim alarmMsg As String

    Private Sub frmScanAlarm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'tScan.Start()
        tScan.Interval = 3000
        alarmPage = AlarmPageName.PLC
        ShowPLCAlarm()
        ShowCommunication()
        ShowMeterAlarm()
        ShowAlarmTAS()
        SetActiveTabPage()
        tScan.Enabled = True
    End Sub
    Sub SetActiveTabPage()
        If MsGrid.Rows.Count > 0 And AlarmMsgCurrent <> String.Empty Then
            For Each r As DataGridViewRow In MsGrid.Rows
                If AlarmMsgCurrent.IndexOf(r.Cells(2).Value.ToString) >= 0 Then
                    Me.Tap.SelectedTab = Tap.TabPages(0)
                    Return
                End If
            Next
        End If
        If MsGridComm.Rows.Count > 0 And AlarmMsgCurrent <> String.Empty Then
            For Each r As DataGridViewRow In MsGridComm.Rows
                If AlarmMsgCurrent.IndexOf(r.Cells(2).Value.ToString) >= 0 Then
                    Me.Tap.SelectedTab = Tap.TabPages(1)
                    Return
                End If
            Next
        End If
        If MsGridMeter.Rows.Count > 0 And AlarmMsgCurrent <> String.Empty Then
            For Each r As DataGridViewRow In MsGridMeter.Rows
                If AlarmMsgCurrent.IndexOf(r.Cells(2).Value.ToString) >= 0 Then
                    Me.Tap.SelectedTab = Tap.TabPages(2)
                    Return
                End If
            Next
        End If
        If MsGridTAS.Rows.Count > 0 And AlarmMsgCurrent <> String.Empty Then
            For Each r As DataGridViewRow In MsGridTAS.Rows
                If AlarmMsgCurrent.IndexOf(r.Cells(2).Value.ToString) >= 0 Then
                    Me.Tap.SelectedTab = Tap.TabPages(3)
                    Return
                End If
            Next
        End If
    End Sub
    Private Sub ShowAlarm()
        Select Case alarmPage
            Case AlarmPageName.PLC
                ShowPLCAlarm()
            Case AlarmPageName.METER
                ShowMeterAlarm()
            Case AlarmPageName.COMM
                ShowCommunication()
            Case AlarmPageName.TAS
                ShowAlarmTAS()
        End Select
    End Sub
    Private Sub ShowAlarmTAS()

        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim vTotal As Integer
        vTotal = 0
        strSQL = _
                "select T.* " & _
                " from TAS.VIEW_ALARM_TAS T" & _
                " order by  t.alarm_date desc"
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            MsGridTAS.RowCount = 0
            vTotal = dt.Rows.Count
            txtTotolAlarm.Text = vTotal.ToString
            Do While vTotal > i
                MsGridTAS.RowCount = MsGridTAS.RowCount + 1
                MsGridTAS.Rows.Item(i).Height = Grid_Height
                MsGridTAS.Item(0, i).Value = (i + 1).ToString()
                MsGridTAS.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("alarm_date")), "", dt.Rows(i).Item("alarm_date").ToString)
                MsGridTAS.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("alarm_message")), "", dt.Rows(i).Item("alarm_message").ToString)
                MsGridTAS.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("alarm_id")), "", dt.Rows(i).Item("alarm_id").ToString)
                If dt.Rows(i).Item("ack") = 1 Then
                    MsGridTAS.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ack_date")), "", dt.Rows(i).Item("ack_date").ToString)
                    For z = 0 To MsGrid.Columns.Count - 1
                        MsGridTAS.Rows(i).Cells(z).Style.ForeColor = Color.Green
                    Next
                Else
                    MsGridTAS.Item(4, i).Value = ""
                End If
                MsGridTAS.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("j_computer")), "", dt.Rows(i).Item("j_computer").ToString)
                i = i + 1
            Loop
        Else
            MsGridTAS.RowCount = 1

        End If
        If MsGridTAS.AutoSizeRowsMode <> DataGridViewAutoSizeRowsMode.AllCells Then
            MsGridTAS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End If
        If MsGridTAS.Rows.Count > 0 Then
            If MsGridTAS.AutoSizeColumnsMode <> DataGridViewAutoSizeColumnsMode.Fill And Me.WindowState = FormWindowState.Normal Then
                MsGridTAS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
            If rowSelectTasAlarm >= 0 Then
                If rowSelectTasAlarm >= MsGridMeter.Rows.Count Then
                    rowSelectTasAlarm = MsGridMeter.Rows.Count - 1
                End If
                'MsGrid.ClearSelection()
                MsGridTAS.Rows(rowSelectTasAlarm).Selected = True
            End If
        Else
            If MsGridTAS.AutoSizeColumnsMode <> DataGridViewAutoSizeColumnsMode.ColumnHeader Then
                MsGridTAS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
            End If
        End If
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub
    Private Sub ShowPLCAlarm()

        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim vTotal As Integer
        vTotal = 0
        strSQL = _
                "select T.* " & _
                " from TAS.VIEW_ALARM_PLC T" & _
                " order by  t.alarm_id desc "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            MsGrid.RowCount = 0
            vTotal = dt.Rows.Count
            txtTotolAlarm.Text = vTotal.ToString
            Do While vTotal > i
                MsGrid.RowCount = MsGrid.RowCount + 1
                MsGrid.Rows.Item(i).Height = Grid_Height
                MsGrid.Item(0, i).Value = (i + 1).ToString()
                MsGrid.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("alarm_date")), "", dt.Rows(i).Item("alarm_date").ToString)
                MsGrid.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("alarm_message")), "", dt.Rows(i).Item("alarm_message").ToString)
                MsGrid.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("alarm_id")), "", dt.Rows(i).Item("alarm_id").ToString)
                If dt.Rows(i).Item("ack") = 1 Then
                    MsGrid.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ack_date")), "", dt.Rows(i).Item("ack_date").ToString)
                    For j As Integer = 0 To MsGrid.Columns.Count - 1
                        MsGrid.Rows(i).Cells(j).Style.ForeColor = Color.Green
                    Next
                Else
                    MsGrid.Item(4, i).Value = ""
                    For j As Integer = 0 To MsGrid.Columns.Count - 1
                        MsGrid.Rows(i).Cells(j).Style.ForeColor = Color.Red
                    Next
                End If
                MsGrid.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("j_computer")), "", dt.Rows(i).Item("j_computer").ToString)
                i = i + 1
            Loop
        Else
            MsGrid.RowCount = 1
        End If
        If MsGrid.AutoSizeRowsMode <> DataGridViewAutoSizeRowsMode.AllCells Then
            MsGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End If
        If MsGrid.Rows.Count > 0 Then
            If MsGrid.AutoSizeColumnsMode <> DataGridViewAutoSizeColumnsMode.Fill And Me.WindowState = FormWindowState.Normal Then
                MsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
            MsGrid.ScrollBars = ScrollBars.Horizontal
            If rowSelectPLCAlarm >= 0 Then
                If rowSelectPLCAlarm >= MsGrid.Rows.Count Then
                    rowSelectPLCAlarm = MsGrid.Rows.Count - 1
                End If
                'MsGrid.ClearSelection()
                MsGrid.Rows(rowSelectPLCAlarm).Selected = True
            End If
        Else
            If MsGrid.AutoSizeColumnsMode <> DataGridViewAutoSizeColumnsMode.ColumnHeader Then
                MsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
            End If
        End If
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub
    Private Sub ShowMeterAlarm()
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim vTotal As Integer
        vTotal = 0
        txtTotalMeter.Text = vTotal

        'strSQL = _
        '         " select t.* " & _
        '         " from steqi.accuload_alarm_status t " & _
        '         " where  t.status = '1' " & _
        '        " order by  t.meter_no "

        'If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
        '    dt = mDataSet.Tables("TableName1")
        '    i = 0
        '    MsGridMeter.RowCount = 0
        '    vTotal = dt.Rows.Count
        '    txtTotalMeter.Text = vTotal
        '    Do While vTotal > i
        '        MsGridMeter.RowCount = MsGridMeter.RowCount + 1
        '        MsGridMeter.Rows.Item(i).Height = Grid_Height
        '        MsGridMeter.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("METER_NO")), "", dt.Rows(i).Item("METER_NO").ToString)
        '        MsGridMeter.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ALARM_GROUP")), "", dt.Rows(i).Item("ALARM_GROUP").ToString)
        '        MsGridMeter.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("alarm_name")), "", dt.Rows(i).Item("alarm_name").ToString)
        '        i = i + 1
        '    Loop
        'Else
        '    MsGridMeter.RowCount = 1

        'End If

        strSQL = _
                "select T.* " & _
                " from TAS.VIEW_ALARM_METER T" & _
                " order by  t.alarm_id desc "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            MsGridMeter.RowCount = 0
            vTotal = dt.Rows.Count
            txtTotolAlarm.Text = vTotal.ToString
            Do While vTotal > i
                MsGridMeter.RowCount = MsGridMeter.RowCount + 1
                MsGridMeter.Rows.Item(i).Height = Grid_Height
                MsGridMeter.Item(0, i).Value = (i + 1).ToString()
                MsGridMeter.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("alarm_date")), "", dt.Rows(i).Item("alarm_date").ToString)
                MsGridMeter.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("alarm_message")), "", dt.Rows(i).Item("alarm_message").ToString)
                MsGridMeter.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("alarm_id")), "", dt.Rows(i).Item("alarm_id").ToString)
                If dt.Rows(i).Item("ack") = 1 Then
                    MsGridMeter.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ack_date")), "", dt.Rows(i).Item("ack_date").ToString)
                    For j As Integer = 0 To MsGridMeter.Columns.Count - 1
                        MsGridMeter.Rows(i).Cells(j).Style.ForeColor = Color.Green
                    Next
                Else
                    MsGridMeter.Item(4, i).Value = ""
                    For j As Integer = 0 To MsGridMeter.Columns.Count - 1
                        MsGridMeter.Rows(i).Cells(j).Style.ForeColor = Color.Red
                    Next
                End If
                MsGridMeter.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("j_computer")), "", dt.Rows(i).Item("j_computer").ToString)
                i = i + 1
            Loop
        Else
            MsGridMeter.RowCount = 1
        End If
        If MsGridMeter.AutoSizeRowsMode <> DataGridViewAutoSizeRowsMode.AllCells Then
            MsGridMeter.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End If
        If MsGridMeter.Rows.Count > 0 Then
            If MsGridMeter.AutoSizeColumnsMode <> DataGridViewAutoSizeColumnsMode.Fill And Me.WindowState = FormWindowState.Normal Then
                MsGridMeter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
            If rowSelectMeterAlarm >= 0 Then
                If rowSelectMeterAlarm >= MsGridMeter.Rows.Count Then
                    rowSelectMeterAlarm = MsGridMeter.Rows.Count - 1
                End If
                'MsGrid.ClearSelection()
                MsGridMeter.Rows(rowSelectMeterAlarm).Selected = True
            End If
        Else
            If MsGridMeter.AutoSizeColumnsMode <> DataGridViewAutoSizeColumnsMode.ColumnHeader Then
                MsGridMeter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
            End If
        End If
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub
    Private Sub ShowCommunication()
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim vTotal As Integer
        vTotal = 0
        'strSQL = " select t.DEVICE_NAME,t.DESCRIPTION " & _
        '        " from steqi.view_communication_status t"

        'If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
        '    dt = mDataSet.Tables("TableName1")
        '    i = 0
        '    MsGridComm.RowCount = 0
        '    txtComm.Text = dt.Rows.Count
        '    vTotal = dt.Rows.Count
        '    Do While vTotal > i
        '        MsGridComm.RowCount = MsGridComm.RowCount + 1
        '        MsGridComm.Rows.Item(i).Height = Grid_Height
        '        MsGridComm.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DEVICE_NAME")), "", dt.Rows(i).Item("DEVICE_NAME").ToString)
        '        MsGridComm.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION").ToString)
        '        i = i + 1
        '    Loop
        'Else
        '    MsGridComm.RowCount = 1
        'End If

        strSQL = _
                "select T.* " & _
                " from TAS.VIEW_ALARM_COMM T" & _
                " order by  t.alarm_id desc "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            MsGridComm.RowCount = 0
            vTotal = dt.Rows.Count
            txtTotolAlarm.Text = vTotal.ToString
            Do While vTotal > i
                MsGridComm.RowCount = MsGridComm.RowCount + 1
                MsGridComm.Rows.Item(i).Height = Grid_Height
                MsGridComm.Item(0, i).Value = (i + 1).ToString()
                MsGridComm.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("alarm_date")), "", dt.Rows(i).Item("alarm_date").ToString)
                MsGridComm.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("alarm_message")), "", dt.Rows(i).Item("alarm_message").ToString)
                MsGridComm.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("alarm_id")), "", dt.Rows(i).Item("alarm_id").ToString)
                If dt.Rows(i).Item("ack") = 1 Then
                    MsGridComm.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ack_date")), "", dt.Rows(i).Item("ack_date").ToString)
                    For j As Integer = 0 To MsGridComm.Columns.Count - 1
                        MsGridComm.Rows(i).Cells(j).Style.ForeColor = Color.Green
                    Next
                Else
                    MsGridComm.Item(4, i).Value = ""
                    For j As Integer = 0 To MsGridComm.Columns.Count - 1
                        MsGridComm.Rows(i).Cells(j).Style.ForeColor = Color.Red
                    Next
                End If
                MsGridComm.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("j_computer")), "", dt.Rows(i).Item("j_computer").ToString)
                i = i + 1
            Loop
        Else
            MsGridComm.RowCount = 1
        End If

        If MsGridComm.AutoSizeRowsMode <> DataGridViewAutoSizeRowsMode.AllCells Then
            MsGridComm.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End If
        If MsGridComm.Rows.Count > 0 Then
            If MsGridComm.AutoSizeColumnsMode <> DataGridViewAutoSizeColumnsMode.Fill And Me.WindowState = FormWindowState.Normal Then
                MsGridComm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
            If rowSelectCommAlarm >= 0 Then
                'MsGrid.ClearSelection()
                If rowSelectCommAlarm >= MsGridComm.Rows.Count Then
                    rowSelectCommAlarm = MsGridComm.Rows.Count - 1
                End If
                If MsGridComm.Rows(rowSelectCommAlarm).Selected = False Then
                    MsGridComm.Rows(rowSelectCommAlarm).Selected = True
                End If
            End If
        Else
            If MsGridComm.AutoSizeColumnsMode <> DataGridViewAutoSizeColumnsMode.ColumnHeader Then
                MsGridComm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
            End If
        End If
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub
    Sub SetAlarmID()
        Dim vIndex As Integer
        Select Case alarmPage
            Case AlarmPageName.COMM
                If MsGridComm.Rows.Count = 0 Then
                    SelAlarmID = -1
                    Return
                End If

                vIndex = MsGridComm.CurrentRow.Index
                If vIndex >= 0 Then
                    SelAlarmID = MsGridComm.Rows(vIndex).Cells(3).Value
                    alarmMsg = MsGridComm.Rows(vIndex).Cells(2).Value
                End If
            Case AlarmPageName.METER
                If MsGridMeter.Rows.Count = 0 Then
                    SelAlarmID = -1
                    Return
                End If

                vIndex = MsGridMeter.CurrentRow.Index
                If vIndex >= 0 Then
                    SelAlarmID = MsGridMeter.Rows(vIndex).Cells(3).Value
                    alarmMsg = MsGridMeter.Rows(vIndex).Cells(2).Value
                End If
            Case AlarmPageName.PLC
                If MsGrid.Rows.Count = 0 Then
                    SelAlarmID = -1
                    Return
                End If

                vIndex = MsGrid.CurrentRow.Index
                If vIndex >= 0 Then
                    SelAlarmID = MsGrid.Rows(vIndex).Cells(3).Value
                    alarmMsg = MsGrid.Rows(vIndex).Cells(2).Value
                End If
            Case AlarmPageName.TAS
                If MsGridTAS.Rows.Count = 0 Then
                    SelAlarmID = -1
                    Return
                End If

                vIndex = MsGridTAS.CurrentRow.Index
                If vIndex >= 0 Then
                    SelAlarmID = MsGridTAS.Rows(vIndex).Cells(3).Value
                    alarmMsg = MsGridTAS.Rows(vIndex).Cells(2).Value
                End If
        End Select
    End Sub
    Private Sub cmdAck_Click(sender As System.Object, e As System.EventArgs) Handles cmdAck.Click
        tScan.Enabled = False
        SetAlarmID()
        If Val(SelAlarmID) > 0 Then
            'tScan.Enabled = False
            If MsgBox("ท่านต้องการ Ack. Alarm " & alarmMsg & " ใช่หรือไม่ ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = vbYes Then
                Me.Cursor = Cursors.WaitCursor
                Call SetACK(SelAlarmID)
                System.Threading.Thread.Sleep(300)
                ShowAlarm()
                Me.Cursor = Cursors.Default
            End If
        Else
            If SelAlarmID <> -1 Then
                MsgBox("ท่านยังไม่ได้เลือก Alarm ที่ต้องการ Acknowledge.", MsgBoxStyle.Information)
            End If
        End If
        tScan.Enabled = True
    End Sub
    Private Sub MsGrid_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MsGrid.CellClick
        tScan.Enabled = False
        If e.RowIndex >= 0 Then
            rowSelectPLCAlarm = e.RowIndex
            MsGrid.Rows(rowSelectPLCAlarm).Selected = True
            SelAlarmID = MsGrid.Rows(rowSelectPLCAlarm).Cells(3).Value
            'tScan.Enabled = True
        Else
            'tScan.Enabled = True
            rowSelectPLCAlarm = -1
        End If
        tScan.Enabled = True
    End Sub

    Private Sub MsGridComm_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MsGridComm.CellClick
        tScan.Enabled = False
        If e.RowIndex > 0 Then
            rowSelectCommAlarm = e.RowIndex
            MsGridComm.Rows(rowSelectCommAlarm).Selected = True
            SelAlarmID = MsGridComm.Rows(rowSelectCommAlarm).Cells(3).Value
        Else
            rowSelectCommAlarm = -1
        End If
        tScan.Enabled = True
    End Sub

    Private Sub MsGridMeter_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MsGridMeter.CellClick
        tScan.Enabled = False
        If e.RowIndex > 0 Then
            rowSelectMeterAlarm = e.RowIndex
            MsGridMeter.Rows(rowSelectMeterAlarm).Selected = True
            SelAlarmID = MsGridMeter.Rows(rowSelectMeterAlarm).Cells(3).Value
        Else
            rowSelectMeterAlarm = -1
        End If
        tScan.Enabled = True
    End Sub

    Public Sub SetACK(ByVal AlarmID As String)
        Dim StrSQL As String
        'Dim mDataSet As New DataSet
        StrSQL = "begin P_ACK_ALARM(0," & AlarmID & ",'" & mUserName & "','" & mComputerName & "'); end; "
        Oradb.ExeSQL(StrSQL)
        SelAlarmID = 0
        'Oradb.OpenDys(StrSQL, "TableName1", mDataSet)
        'mDataSet = Nothing
    End Sub
    Public Sub SetACKALL()
        'Dim StrSQL As String
        'Dim mDataSet As New DataSet
        'StrSQL = "begin P_ACK_ALARM(1,0); end; "
        'Oradb.ExeSQL(StrSQL)
        'Oradb.OpenDys(StrSQL, "TableName1", mDataSet)
        'mDataSet = Nothing
        Select Case alarmPage
            Case AlarmPageName.COMM
                For i As Integer = 0 To MsGridComm.Rows.Count - 1
                    SetACK(MsGridComm.Rows(i).Cells(3).Value)
                Next
            Case AlarmPageName.METER
                For i As Integer = 0 To MsGridMeter.Rows.Count - 1
                    SetACK(MsGridMeter.Rows(i).Cells(3).Value)
                Next
            Case AlarmPageName.PLC
                For i As Integer = 0 To MsGrid.Rows.Count - 1
                    SetACK(MsGrid.Rows(i).Cells(3).Value)
                Next
            Case AlarmPageName.TAS
                For i As Integer = 0 To MsGridTAS.Rows.Count - 1
                    SetACK(MsGridTAS.Rows(i).Cells(3).Value)
                Next
        End Select
    End Sub
    Public Sub SetClear()
        Dim StrSQL As String
        'Dim mDataSet As New DataSet
        StrSQL = "begin P_CLAER_ALARM(1,0); end; "
        Oradb.ExeSQL(StrSQL)
        'Oradb.OpenDys(StrSQL, "TableName1", mDataSet)
        'mDataSet = Nothing
    End Sub
    Private Sub tScan_Tick(sender As System.Object, e As System.EventArgs) Handles tScan.Tick
        ShowAlarm()
        'ShowCommunication()
        'ShowMeterAlarm()
    End Sub
    Private Sub cmdAckAll_Click(sender As System.Object, e As System.EventArgs) Handles cmdAckAll.Click
        'If MsGrid.RowCount > 0 Then
        '    SetACKALL()
        'End If
        If MsgBox("ท่านต้องการ Ack. Alarm ทั้งหมดใช่หรือไม่ ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = vbYes Then
            Me.Cursor = Cursors.WaitCursor
            SetACKALL()
            System.Threading.Thread.Sleep(300)
            ShowAlarm()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub cmdClearAll_Click(sender As System.Object, e As System.EventArgs) Handles cmdClearAll.Click
        Call SetClear()
    End Sub

    'Private Sub cmShowMeterAlarm_Click(sender As System.Object, e As System.EventArgs)
    '    If Meter_no = "" Then
    '        Exit Sub
    '    End If
    '    frmMMIBayLoadingAlarmPopUp.vMeter_No = Meter_no
    '    frmMMIBayLoadingAlarmPopUp.Show()
    'End Sub

    'Private Sub cmResetMeter_Click(sender As System.Object, e As System.EventArgs)
    '    If Meter_no = "" Then Exit Sub
    '    If RunProcResetAlarmMeter(Meter_no) Then
    '        MsgBox("ทำการ Reset Alarm ของ Meter :" & Meter_no & " เรียบร้อยแล้ว")
    '    End If
    '    Call ShowMeterAlarm()
    'End Sub
    Private Function RunProcResetAlarmMeter(ByVal iMeter As String) As Boolean
        Dim strSQL As String
        RunProcResetAlarmMeter = False
        If iMeter = "" Then Exit Function
        strSQL = ""
        strSQL = strSQL & "begin "
        strSQL = strSQL & " load.BATCH_SET_RESET_ALARM ('" & Trim(iMeter) & "'); "
        strSQL = strSQL & "end;"
        'Dim mDataSet As New DataSet
        Dim tempMeterLoaded = ""
        'RunProcResetAlarmMeter = Oradb.OpenDys(strSQL, "TableName1", mDataSet)
        RunProcResetAlarmMeter = Oradb.ExeSQL(strSQL)
        'mDataSet = Nothing

    End Function

    'Private Sub cmdCloseComm_Click(sender As System.Object, e As System.EventArgs)
    '    Me.Close()
    'End Sub

    'Private Sub cmdRefreshMeter_Click(sender As System.Object, e As System.EventArgs)
    '    ShowMeterAlarm()
    'End Sub

    Private Sub cmdClose_Click(sender As System.Object, e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub btRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click

        MsGrid.ClearSelection()
        MsGridComm.ClearSelection()
        MsGridMeter.ClearSelection()
        MsGridTAS.ClearSelection()
        ShowAlarm()
    End Sub

    Private Sub Tap_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tap.SelectedIndexChanged
        Dim t As TabControl
        t = sender
        Select Case t.SelectedIndex
            Case 0
                alarmPage = AlarmPageName.PLC
            Case 1
                alarmPage = AlarmPageName.COMM
            Case 2
                alarmPage = AlarmPageName.METER
            Case 3
                alarmPage = AlarmPageName.TAS
        End Select
        ShowAlarm()
    End Sub

    Private Sub frmScanAlarm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Maximized Then
            If MsGrid.AutoSizeColumnsMode <> DataGridViewAutoSizeColumnsMode.DisplayedCells Then
                MsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            End If
            If MsGridComm.AutoSizeColumnsMode <> DataGridViewAutoSizeColumnsMode.DisplayedCells Then
                MsGridComm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            End If
            If MsGridMeter.AutoSizeColumnsMode <> DataGridViewAutoSizeColumnsMode.DisplayedCells Then
                MsGridMeter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            End If
        Else
            If Me.WindowState = FormWindowState.Normal Then
                MsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                MsGridComm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                MsGridMeter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If
        End If
    End Sub
End Class