Public Class frmMMIProcessSetTemp

    Dim P_ComputerName As String = System.Net.Dns.GetHostName
    Private Meter_no As String
    Private Sub cmdSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSet.Click
        Dim i As Long
        If MsgBox("Are you sure?", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If

        With MSGridConfig
            For i = 0 To MSGridConfig.RowCount - 1
                If MSGridConfig.Rows(i).Cells(3).Value <> "" Then
                    Call SaveData("TEMP_SLOP_BITUMEN", CLng(Trim(MSGridConfig.Rows(i).Cells(0).Value.ToString)), Trim(MSGridConfig.Rows(i).Cells(3).Value.ToString))
                End If
            Next
        End With
        MsgBox("Setting configuration successful ", vbInformation, "Setting")
    End Sub
    Private Sub SaveData(ByVal iconfig_name As String, ByVal iconfig_no As Long, ByVal iValue As String)
        Dim strSQL As String
        strSQL = "begin " & _
                                  " steqi.WRITE_CONFIG_PLC_SETTING( '" & _
                                 iconfig_name & _
                                "'," & _
                                 iconfig_no & _
                                ",'" & _
                                iValue & _
                                "','" & _
                                 mUserName & _
                                "','" & _
                                 P_ComputerName & "'); " & _
                                 "end;"
        If Oradb.ExeSQL(strSQL) Then

        End If
    End Sub

    Private Sub frmMMIProcessSetLevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Caption = "Config Pressure of Meter" & Meter_no
        Call InitialValue()
    End Sub

    Private Sub InitialValue()


        '------------


        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        strSQL = "select t.* " & _
                " from steqi.view_config_temp_slop_setting t" & _
                " Where t.CONFIG_NAME='TEMP_SLOP_BITUMEN' " & _
                " order by t.CONFIG_NAME "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            MSGridConfig.RowCount = 0
            Do While dt.Rows.Count > i
                MSGridConfig.RowCount = MSGridConfig.RowCount + 1
                MSGridConfig.Rows.Item(i).Height = Grid_Height
                MSGridConfig.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("config_no")), "", dt.Rows(i).Item("config_no").ToString)
                MSGridConfig.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DEVICE_NAME")), "", dt.Rows(i).Item("DEVICE_NAME").ToString)
                MSGridConfig.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("current_value")), "", dt.Rows(i).Item("current_value").ToString)
                MSGridConfig.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("unit")), "", dt.Rows(i).Item("unit").ToString)
                'MSGridConfig.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PERMISSIVE_NAME")), "", dt.Rows(i).Item("PERMISSIVE_NAME").ToString)
                'MSGridConfig.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PERMISSIVE_NAME")), "", dt.Rows(i).Item("PERMISSIVE_NAME").ToString)
                i = i + 1
            Loop
        Else
            MSGridConfig.RowCount = 1

        End If
        mDataSet = Nothing
    End Sub

    Public Sub GetMeterNo(ByVal iMeterNo As String)
        Meter_no = iMeterNo
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Call InitialValue()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        Dim i As Integer = 0
        ' MSGridConfig.RowCount = 0
        Do While MSGridConfig.RowCount > i
            'MSGridConfig.RowCount = MSGridConfig.RowCount + 1
            'MSGridConfig.Rows.Item(i).Height = Grid_Height
            MSGridConfig.Item(3, i).Value = ""

            i += 1
        Loop

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class