Public Class ucPermissive
    Dim txt As New Collection
    Public Sub ShowData(ByVal MeterNo As Integer)
        Dim strSQL As String
        Dim i As Integer
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        mDataSet = Nothing
        strSQL = _
                  " select " & _
                  "  t.ARM_SIDE_A,t.ARM_SIDE_B ,t.ARM_LEFT_ACTIVE,t.ARM_RIGHT_ACTIVE" & _
                  " ,t.PRESSURE_DIFF_ALARM,t.TEMP_1_ALARM,t.TEMP_NAME1,t.TEMPERATURE1,t.FV_CONTROL ,t.FLOW_ACTIVE,t.ARM_DOWN_A,t.ARM_DOWN_B,t.EARTH_A,t.EARTH_B,t.OVERSFILL_A,t.OVERSFILL_B,t.ESD ,t.PREMISSIVE_A,t.PREMISSIVE_B  " & _
                  " ,t.BALL_VALVE_A,t.BALL_VALVE_B " & _
                  " from  steqi.view_mmi_processflow_meter t " & _
                  " where  t.meter_no ='" & Trim(MeterNo) & "'"

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            i = 0
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("ARM_SIDE_A")), 0, dt.Rows(i).Item("ARM_SIDE_A")), txt(1 + 0))
                Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("BALL_VALVE_A")), 0, dt.Rows(i).Item("BALL_VALVE_A")), txt(1 + 1))
                Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("ARM_DOWN_A")), 0, dt.Rows(i).Item("ARM_DOWN_A")), txt(1 + 2))
                Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("EARTH_A")), 0, dt.Rows(i).Item("EARTH_A")), txt(1 + 3))
                Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("OVERSFILL_A")), 0, dt.Rows(i).Item("OVERSFILL_A")), txt(1 + 4))
                Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("PREMISSIVE_A")), 0, dt.Rows(i).Item("PREMISSIVE_A")), txt(1 + 5))

                Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("ARM_SIDE_B")), 0, dt.Rows(i).Item("ARM_SIDE_B")), txt(1 + 6))
                Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("BALL_VALVE_B")), 0, dt.Rows(i).Item("BALL_VALVE_B")), txt(1 + 7))
                Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("ARM_DOWN_B")), 0, dt.Rows(i).Item("ARM_DOWN_B")), txt(1 + 8))
                Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("EARTH_B")), 0, dt.Rows(i).Item("EARTH_B")), txt(1 + 9))
                Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("OVERSFILL_B")), 0, dt.Rows(i).Item("OVERSFILL_B")), txt(1 + 10))
                Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("PREMISSIVE_B")), 0, dt.Rows(i).Item("PREMISSIVE_B")), txt(1 + 11))

            End If
        End If
        mDataSet = Nothing

    End Sub
    Private Sub SaftGarudingAc(ByVal iValue As Integer, ByVal txt As TextBox)
        If iValue = 0 Then
            txt.BackColor = Color.Red
        Else
            txt.BackColor = Color.GreenYellow
        End If
    End Sub

    Private Sub ucPermissive_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitailTextbox()
    End Sub
    Private Sub InitailTextbox()
        txt.Add(TextBox1)
        txt.Add(TextBox2)
        txt.Add(TextBox3)
        txt.Add(TextBox4)
        txt.Add(TextBox5)
        txt.Add(TextBox6)
        txt.Add(TextBox7)
        txt.Add(TextBox8)
        txt.Add(TextBox9)
        txt.Add(TextBox10)
        txt.Add(TextBox11)
        txt.Add(TextBox12)
    End Sub


    Private Sub TextBox11_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox12_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox12.TextChanged

    End Sub
End Class
