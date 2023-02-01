
Imports Oracle.DataAccess.Client
Imports System.Data
Imports System.IO

Public Class frmMMITank

    Public FormScreenID As Long
    Dim dtt As DataTable
    Dim toggleAlarm As Boolean
    Dim swAlarm As Boolean
    Dim B_ScanTime As Boolean
    Dim Connect_Status As Long
    Dim ImgClickLeftMenu As Image
    Dim strSqlTank
    Dim frm_work As Integer = 0

    Private Sub frmMMITank_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmMMITank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        resolution(Me, 1)

        TimerScan.Interval = 1000
        TimerScan.Enabled = True
        B_ScanTime = True

        toggleAlarm = True
        TimerAlarm.Interval = 200
        TimerAlarm.Enabled = True

        InitialCombo()
        cbTankName.Items.Add("ALL")
        showTable()
        showTank(1)

        intTankName()
    End Sub

    Sub showTable()
        Dim strSQL2
        If cbProductType.Text = "ALL" Then

            strSQL2 = _
              "select T.TANK_NAME,T.BASE_PRODUCT,S.DESCRIPTION,T.IS_ENABLED,T.CONNECT_STATUS," & _
              "T.TANK_HIGH,T.TANK_CAPACITY,T.LEVEL_LL,T.LEVEL_L,T.LEVEL_H,T.LEVEL_HH," & _
              "T.LEVELS,T.GROSS,T.NET,T.AVARIABLE,T.ROOM,T.TEMP, T.DEN15C ,T.API_60F,T.VCF,T.WIA,T.FWL," & _
              "T.ALARM_LEVEL_HH,T.ALARM_LEVEL_H,T.ALARM_LEVEL_L,T.ALARM_LEVEL_LL,P.COLOR_CODE,VCF30C " & _
              "from VIEW_MAP_TANK T,STATUS_DESC S,BASE_PRODUCT P " & _
              "where T.TANK_TYPE=S.STATUS_VARCHAR " & _
              "and ((S.T_NAME='TANK' and S.COLUMNS_NAME='TANK_TYPE') or S.T_NAME is null) " & _
              "and T.BASE_PRODUCT=P.BASE_PRODUCT_ID(+) " & _
              " ORDER BY T.BASE_PRODUCT,T.TANK_NAME "

            ' " and    T.BASE_PRODUCT  IN (  select a.BASE_PRODUCT_ID from BASE_PRODUCT a )   " & _
        Else
            strSQL2 = _
              "select T.TANK_NAME,T.BASE_PRODUCT,S.DESCRIPTION,T.IS_ENABLED,T.CONNECT_STATUS," & _
              "T.TANK_HIGH,T.TANK_CAPACITY,T.LEVEL_LL,T.LEVEL_L,T.LEVEL_H,T.LEVEL_HH," & _
              "T.LEVELS,T.GROSS,T.NET,T.AVARIABLE,T.ROOM,T.TEMP, T.DEN15C ,T.API_60F,T.VCF,T.WIA,T.FWL," & _
              "T.ALARM_LEVEL_HH,T.ALARM_LEVEL_H,T.ALARM_LEVEL_L,T.ALARM_LEVEL_LL,P.COLOR_CODE,VCF30C " & _
              "from VIEW_MAP_TANK T,STATUS_DESC S,BASE_PRODUCT P " & _
              "where T.TANK_TYPE=S.STATUS_VARCHAR " & _
              "and ((S.T_NAME='TANK' and S.COLUMNS_NAME='TANK_TYPE') or S.T_NAME is null) " & _
              "and T.BASE_PRODUCT='" & cbProductType.Text & "'" & _
                "and T.BASE_PRODUCT=P.BASE_PRODUCT_ID(+) "
            If cbTankName.Text <> "ALL" Then
                strSQL2 &= "and  t.TANK_ID='" & cbTankId.Text & "'"
            End If
            strSQL2 &= " ORDER BY T.BASE_PRODUCT,T.TANK_NAME "
            End If
        DataGridView1.RowCount = 0
        DataGridView1.RowCount = DataGridView1.RowCount + 9
        DataGridView1.Item(0, 0).Value = "กลุ่มผลิตภัณฑ์"
        DataGridView1.Item(0, 1).Value = "ชื่อถัง"
        DataGridView1.Item(0, 2).Value = "ความสูงของถัง"
        DataGridView1.Item(0, 3).Value = "ระดับน้ำมัน"
        DataGridView1.Item(0, 4).Value = "High High Level"
        DataGridView1.Item(0, 5).Value = "High Level"
        DataGridView1.Item(0, 6).Value = "Low Low Level"
        DataGridView1.Item(0, 7).Value = "Low Level"
        DataGridView1.Item(0, 8).Value = "Color"

        DataGridView1.Rows.Item(0).Height = Grid_Height
        DataGridView1.Rows.Item(1).Height = Grid_Height
        DataGridView1.Rows.Item(2).Height = Grid_Height
        DataGridView1.Rows.Item(3).Height = Grid_Height
        DataGridView1.Rows.Item(4).Height = Grid_Height
        DataGridView1.Rows.Item(5).Height = Grid_Height
        DataGridView1.Rows.Item(6).Height = Grid_Height
        DataGridView1.Rows.Item(7).Height = Grid_Height
        DataGridView1.Rows.Item(8).Height = Grid_Height

        DataGridView1.RowHeadersVisible = False

        DataGridView1.ColumnCount = 1
        Dim mDataSet2 As New DataSet
        Dim dtG As DataTable

        If Oradb.OpenDys(strSQL2, "TableName2", mDataSet2) Then
            dtG = mDataSet2.Tables("TableName2")
            Dim i As Integer = 0
            Do While dtG.Rows.Count > i


                DataGridView1.ColumnCount = DataGridView1.ColumnCount + 1
                DataGridView1.Item(i + 1, 0).Value = IIf(IsDBNull(dtG.Rows(i).Item("BASE_PRODUCT")), "", dtG.Rows(i).Item("BASE_PRODUCT").ToString)
                DataGridView1.Item(i + 1, 1).Value = IIf(IsDBNull(dtG.Rows(i).Item("TANK_NAME")), "", dtG.Rows(i).Item("TANK_NAME").ToString)
                DataGridView1.Item(i + 1, 2).Value = IIf(IsDBNull(dtG.Rows(i).Item("TANK_HIGH")), "", dtG.Rows(i).Item("TANK_HIGH").ToString)
                DataGridView1.Item(i + 1, 3).Value = IIf(IsDBNull(dtG.Rows(i).Item("LEVELS")), "", dtG.Rows(i).Item("LEVELS").ToString)
                DataGridView1.Item(i + 1, 4).Value = IIf(IsDBNull(dtG.Rows(i).Item("LEVEL_HH")), "", dtG.Rows(i).Item("LEVEL_HH").ToString)
                DataGridView1.Item(i + 1, 5).Value = IIf(IsDBNull(dtG.Rows(i).Item("LEVEL_H")), "", dtG.Rows(i).Item("LEVEL_H").ToString)
                DataGridView1.Item(i + 1, 6).Value = IIf(IsDBNull(dtG.Rows(i).Item("LEVEL_LL")), "", dtG.Rows(i).Item("LEVEL_LL").ToString)
                DataGridView1.Item(i + 1, 7).Value = IIf(IsDBNull(dtG.Rows(i).Item("LEVEL_L")), "", dtG.Rows(i).Item("LEVEL_L").ToString)

                If i Mod 2 = 0 Then
                    DataGridView1.Item(i + 1, 0).Style.BackColor = Color.LightBlue
                    DataGridView1.Item(i + 1, 1).Style.BackColor = Color.LightBlue
                    DataGridView1.Item(i + 1, 2).Style.BackColor = Color.LightBlue
                    DataGridView1.Item(i + 1, 3).Style.BackColor = Color.LightBlue
                    DataGridView1.Item(i + 1, 4).Style.BackColor = Color.LightBlue
                    DataGridView1.Item(i + 1, 5).Style.BackColor = Color.LightBlue
                    DataGridView1.Item(i + 1, 6).Style.BackColor = Color.LightBlue
                    DataGridView1.Item(i + 1, 7).Style.BackColor = Color.LightBlue
                End If

                If IIf(IsDBNull(dtG.Rows(i).Item("COLOR_CODE")), "", dtG.Rows(i).Item("COLOR_CODE").ToString) <> "" Then
                    DataGridView1.Item(i + 1, 8).Value = Hex(IIf(IsDBNull(dtG.Rows(i).Item("COLOR_CODE")), "", dtG.Rows(i).Item("COLOR_CODE").ToString))
                    DataGridView1.Item(i + 1, 8).Style.BackColor = ColorTranslator.FromHtml("#" + updateColorCode(DataGridView1.Item(i + 1, 8).Value).ToString())
                    'Dim d As Integer = dtG.Rows(i).Item("COLOR_CODE")
                    'DataGridView1.Item(i + 1, 8).Style.BackColor = Color.FromArgb(d)
                Else
                    DataGridView1.Item(i + 1, 8).Style.BackColor = Color.Black
                End If
                If i = 0 Then
                    showDetail(DataGridView1.Item(i + 1, 1).Value)
                End If
                i = i + 1
            Loop
           
        End If
        Me.DataGridView1.Columns("A").Frozen = True
        DataGridView1.Item(0, 0).Style.BackColor = Color.DodgerBlue
        DataGridView1.Item(0, 1).Style.BackColor = Color.CornflowerBlue
        DataGridView1.Item(0, 2).Style.BackColor = Color.DodgerBlue
        DataGridView1.Item(0, 3).Style.BackColor = Color.CornflowerBlue
        DataGridView1.Item(0, 4).Style.BackColor = Color.DodgerBlue
        DataGridView1.Item(0, 5).Style.BackColor = Color.CornflowerBlue
        DataGridView1.Item(0, 6).Style.BackColor = Color.DodgerBlue
        DataGridView1.Item(0, 7).Style.BackColor = Color.CornflowerBlue
        DataGridView1.Item(0, 8).Style.BackColor = Color.DodgerBlue

    End Sub

    Private Function updateColorCode(ByVal codeColour As String) As String
        If codeColour = "" Then
            codeColour = "FFFFFF"
        End If
        Dim i As Integer = 6 - codeColour.Length
        While (i <> 0)
            codeColour = "0" + codeColour
            i = i - 1
        End While

        Dim newCode = codeColour(4) + codeColour(5) + codeColour(2) + codeColour(3) + codeColour(0) + codeColour(1)

        Return newCode
    End Function

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub


    Private Sub DataGridView2_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex = -1 Or DataGridView1.CurrentCell.ColumnIndex = 0 Then
            Exit Sub


        End If
        showTank(DataGridView1.CurrentCell.ColumnIndex)
        showDetail(DataGridView1.Item(DataGridView1.CurrentCell.ColumnIndex, 1).Value)
    End Sub

    Sub showTank(ByVal i As Integer)

        Dim tankHigh
        Dim levels
        Dim levelLL
        Dim levelL
        Dim levelH
        Dim levelHH
        Dim Color
        lblTankName.Text = "ชื่อถัง : " & DataGridView1.Item(i, 1).Value
        tankHigh = DataGridView1.Item(i, 2).Value
        levels = DataGridView1.Item(i, 3).Value
        levelLL = DataGridView1.Item(i, 4).Value
        levelL = DataGridView1.Item(i, 5).Value
        levelH = DataGridView1.Item(i, 6).Value
        levelHH = DataGridView1.Item(i, 7).Value
        Color = DataGridView1.Item(i, 8).Value

        If tankHigh <> "" Then
            UcTank1.updateProgrssOil(CType(tankHigh, Integer), CType(tankHigh, Integer), CType(levels, Integer))
            UcTank1.updateLine(CType(levelLL, Integer), CType(levelL, Integer), CType(levelHH, Integer), CType(levelH, Integer))
            UcTank1.setColorOil(CType(Color, String))
        End If
    End Sub



    Private Sub cbProductType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProductType.SelectedIndexChanged

        showTable()
        intTankName()
    End Sub

    Private Sub InitialCombo()

        Dim strSQL = _
        "select T.BASE_PRODUCT_NAME, T.BASE_PRODUCT_ID " & _
        "from BASE_PRODUCT T " & _
        "order by T.BASE_PRODUCT_NAME"
        assignDropDown(strSQL, "BASE_PRODUCT_ID", cbProductType)
    End Sub

    Function assignDropDown(ByVal sql_str As String, ByVal colName As String, ByVal cb As System.Object) As Boolean
        cb.Items.Clear()
        If "BASE_PRODUCT_ID" = colName Then

            cbProductType.Items.Add("ALL")
            cbProductType.SelectedIndex = 0

        End If
        If "TANK_NAME" = colName Then
            cbTankName.Items.Add("ALL")
            cbTankName.SelectedIndex = 0
        End If

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Dim temCb As String
            Do While dt.Rows.Count > i
                temCb = IIf(IsDBNull(dt.Rows(i).Item(colName)), "", dt.Rows(i).Item(colName).ToString)
                If Not cb.Items.Contains(temCb) Then
                    cb.Items.Add(temCb)
                End If
                i = i + 1
            Loop

        End If

        mDataSet = Nothing
        Return True
    End Function


    Sub showDetail(ByVal tankID)
        lblAlarmDisplay.BackColor = Color.White

        Dim strSQL2 = "select T.TANK_NAME,T.BASE_PRODUCT,S.DESCRIPTION,T.IS_ENABLED,T.CONNECT_STATUS," & _
                "T.TANK_HIGH,T.TANK_CAPACITY,T.LEVEL_LL,T.LEVEL_L,T.LEVEL_H,T.LEVEL_HH," & _
                "T.LEVELS,T.GROSS,T.NET,T.AVARIABLE,T.ROOM,T.TEMP, T.DEN15C ,T.API_60F,T.VCF,T.WIA,T.FWL," & _
                "T.ALARM_LEVEL_HH,T.ALARM_LEVEL_H,T.ALARM_LEVEL_L,T.ALARM_LEVEL_LL,P.COLOR_CODE,VCF30C " & _
                "from VIEW_MAP_TANK T,STATUS_DESC S,BASE_PRODUCT P " & _
               "where T.TANK_TYPE=S.STATUS_VARCHAR " & _
                "and ((S.T_NAME='TANK' and S.COLUMNS_NAME='TANK_TYPE') or S.T_NAME is null) " & _
                "and T.BASE_PRODUCT=P.BASE_PRODUCT_ID(+) " & _
                "and T.TANK_NAME='" & tankId & "'"
        Dim mDataSet2 As New DataSet
        Dim dtG As DataTable

        If Oradb.OpenDys(strSQL2, "TableName2", mDataSet2) Then
            dtG = mDataSet2.Tables("TableName2")
            Dim i As Integer = 0
            If dtG.Rows.Count > i Then

                lblLevels.Text = IIf(IsDBNull(dtG.Rows(i).Item("LEVELS")), "", dtG.Rows(i).Item("LEVELS").ToString)
                lblTankHigh.Text = IIf(IsDBNull(dtG.Rows(i).Item("TANK_HIGH")), "", dtG.Rows(i).Item("TANK_HIGH").ToString)

                'DataGridView1.Item(0, 0).Value = "ประเภทถัง"
                lblTankType.Text = IIf(IsDBNull(dtG.Rows(i).Item("DESCRIPTION")), "", dtG.Rows(i).Item("DESCRIPTION").ToString)

                'DataGridView1.Item(0, 1).Value = "สถานะการใช้งาน"
                lblEnabled.Text = IIf(IsDBNull(dtG.Rows(i).Item("IS_ENABLED")), "", IIf(dtG.Rows(i).Item("IS_ENABLED") = 1, "สามารถใช้งานได้", "หยุดใช้งาน"))

                'DataGridView1.Item(0, 2).Value = "ความจุของถัง"
                lblTankCapacity.Text = IIf(IsDBNull(dtG.Rows(i).Item("TANK_CAPACITY")), "", dtG.Rows(i).Item("TANK_CAPACITY").ToString)
                'DataGridView1.Item(2, 2).Value = " Litre"

                'DataGridView1.Item(0, 3).Value = "อุณหภูมิ"
                lblTemp.Text = IIf(IsDBNull(dtG.Rows(i).Item("TEMP")), "", dtG.Rows(i).Item("TEMP").ToString)
                ' DataGridView1.Item(2, 3).Value = " C'"

                'DataGridView1.Item(0, 4).Value = "ค่าDEN15C"
                lblDEN15C.Text = IIf(IsDBNull(dtG.Rows(i).Item("DEN15C")), "", dtG.Rows(i).Item("DEN15C").ToString)
                ' DataGridView1.Item(2, 4).Value = " Kg/M3"

                'DataGridView1.Item(0, 5).Value = "ค่าVCF30C"
                lblVCF.Text = IIf(IsDBNull(dtG.Rows(i).Item("VCF30C")), "", dtG.Rows(i).Item("VCF30C").ToString)


                'DataGridView1.Item(0, 6).Value = "Weight In Air"
                lbWeightInAir.Text = IIf(IsDBNull(dtG.Rows(i).Item("WIA")), "", dtG.Rows(i).Item("WIA").ToString)
                'DataGridView1.Item(2, 6).Value = " Kg"

                ' DataGridView1.Item(0, 7).Value = "FWL"
                lbFWL.Text = IIf(IsDBNull(dtG.Rows(i).Item("FWL")), "", dtG.Rows(i).Item("FWL").ToString)
                'DataGridView1.Item(2, 7).Value = " mm."

                'DataGridView1.Item(0, 8).Value = "ปริมาณน้ำมันOBS"
                lblGross.Text = IIf(IsDBNull(dtG.Rows(i).Item("GROSS")), "", dtG.Rows(i).Item("GROSS").ToString)
                'DataGridView1.Item(2, 8).Value = " Litre."


                'DataGridView1.Item(0, 9).Value = "ปริมาณน้ำมัน30'C"
                lblNet.Text = IIf(IsDBNull(dtG.Rows(i).Item("NET")), "", dtG.Rows(i).Item("NET").ToString)
                'DataGridView1.Item(2, 9).Value = " Litre."

                'DataGridView1.Item(0, 10).Value = "ปริมาณน้ำมันที่สามารถจ่ายได้"
                lblAvailable.Text = IIf(IsDBNull(dtG.Rows(i).Item("AVARIABLE")), "", dtG.Rows(i).Item("AVARIABLE").ToString)
                'DataGridView1.Item(2, 10).Value = " Litre."

                'DataGridView1.Item(0, 11).Value = "ปริมาณน้ำมันที่สามารถรับได้"
                lblRoom.Text = IIf(IsDBNull(dtG.Rows(i).Item("ROOM")), "", dtG.Rows(i).Item("ROOM").ToString)
                'DataGridView1.Item(2, 11).Value = " Litre."

                'DataGridView1.Item(0, 12).Value = "Alarm"
                lblAlarmDisplay.Text = IIf(IsDBNull(dtG.Rows(i).Item("ROOM")), "", dtG.Rows(i).Item("ROOM").ToString)
                'DataGridView1.Item(2, 12).Value = " Litre."

                Dim statusAlarm
                If IIf(IsDBNull(dtG.Rows(i).Item("IS_ENABLED")), "", dtG.Rows(i).Item("IS_ENABLED")) = 1 Then
                    Select Case 1
                        Case Val(IIf(IsDBNull(dtG.Rows(i).Item("ALARM_LEVEL_HH")), "", dtG.Rows(i).Item("ALARM_LEVEL_HH").ToString))
                            If Val(IIf(IsDBNull(dtG.Rows(i).Item("ALARM_LEVEL_HH")), "", dtG.Rows(i).Item("ALARM_LEVEL_HH").ToString)) = 0 Then Exit Sub
                            statusAlarm = 1
                            lblAlarmDisplay.Text = "ระดับน้ำมันสูงมาก"
                        Case Val(IIf(IsDBNull(dtG.Rows(i).Item("ALARM_LEVEL_LL")), "", dtG.Rows(i).Item("ALARM_LEVEL_LL").ToString))
                            statusAlarm = 1
                            lblAlarmDisplay.Text = "ระดับน้ำมันต่ำมาก"
                        Case Val(IIf(IsDBNull(dtG.Rows(i).Item("ALARM_LEVEL_H")), "", dtG.Rows(i).Item("ALARM_LEVEL_H").ToString))
                            statusAlarm = 1
                            lblAlarmDisplay.Text = "ระดับน้ำมันสูง"
                        Case Val(IIf(IsDBNull(dtG.Rows(i).Item("ALARM_LEVEL_L")), "", dtG.Rows(i).Item("ALARM_LEVEL_L").ToString))
                            statusAlarm = 1
                            lblAlarmDisplay.Text = "ระดับน้ำมันต่ำ"
                        Case Else
                            statusAlarm = 0
                            lblAlarmDisplay.Text = "ไม่มีสัญญาญเตือน"
                    End Select
                    If statusAlarm = 1 Then
                        lblAlarmDisplay.BackColor = Color.Red
                    End If
                End If

                i = i + 1
            End If
        End If

    End Sub

    Sub intTankName()
        Dim strSQL
        'cbTankName.Clear()
        If cbProductType.Text = "ALL" Then
            strSQL = _
              "select T.TANK_ID,T.TANK_NAME " & _
              "from VIEW_MAP_TANK T " & _
              " order by T.TANK_ID"
        Else

            strSQL =
            "select T.TANK_ID,T.TANK_NAME  " & _
            "from VIEW_MAP_TANK T  " & _
            " where T.BASE_PRODUCT in ( " & _
            "   Select B.Base_Product_Id " & _
            "   from BASE_PRODUCT B " & _
            "   where B.BASE_PRODUCT_ID='" & cbProductType.Text & "' " & _
            ")  " & _
            "order by T.TANK_ID "
        End If

        assignDropDown(strSQL, "TANK_NAME", cbTankName)
        assignDropDown(strSQL, "TANK_ID", cbTankId)
    End Sub
    Private Sub cbTankName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTankName.SelectedIndexChanged
        Dim i = cbTankName.SelectedIndex
        cbTankId.SelectedIndex = i - 1
        showTable()
    End Sub
    Private Sub UcHeader1_CloseButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.CloseButtonClick
        Try
            Me.Close()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub UcHeader1_MinimizeButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.MinimizeButtonClick
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub UcBack1_Click(sender As Object, e As EventArgs) Handles UcBack1.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub UcBack1_MouseHover(sender As Object, e As EventArgs) Handles UcBack1.MouseHover
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("Back1")
    End Sub

    Private Sub UcBack1_MouseLeave(sender As Object, e As EventArgs) Handles UcBack1.MouseLeave
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("back")
    End Sub

    Private Sub UcBack1_Load(sender As System.Object, e As System.EventArgs) Handles UcBack1.Load

    End Sub

End Class