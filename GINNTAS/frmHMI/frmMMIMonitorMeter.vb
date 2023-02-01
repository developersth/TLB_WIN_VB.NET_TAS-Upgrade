Imports Oracle.DataAccess.Client
Imports System.Data
Public Class frmMMIMonitorMeter
    Dim frm_work As Integer = 0  '1=add ,2=Edit
    Public FormScreenID As Long
    Dim Gross As Long
    Dim strSQL As String, Rectot As Long

    Const ReportIDIntro = 52010030

    Private Sub frmLoadDO_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub cbProduct_Click()
        MSGridMeter.Visible = False
        Call ShowFlexGrid(cbProduct.Text)
        MSGridMeter.Visible = True
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub

    Private Sub ShowFlexGrid(ByVal product As String)

        Dim StatusConect As Long
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        If product <> "ALL" Then
            sql_str = "select * from tas.view_mmi_monitor_meter v" & _
                            " where v.base_product_id= '" & cbProduct.Text & "'" & _
                            " order by v.meter_no,v.meter"

        Else
            sql_str = "select * from tas.view_mmi_monitor_meter v" & _
                    " order by v.meter_no"
        End If

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            lbl_rec.Text = dt.Rows.Count
            i = 0
            MSGridMeter.RowCount = 0
            MSGridMeter.Columns(3).Visible = False
            lbl_rec.Text = dt.Rows.Count
            Do While dt.Rows.Count > i

                MSGridMeter.RowCount = MSGridMeter.RowCount + 1
           
                Gross = IIf(IsDBNull(dt.Rows(i).Item("GROSS_DELIVERY")), 0, dt.Rows(i).Item("GROSS_DELIVERY"))
                MSGridMeter.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("METER_NO")), "", dt.Rows(i).Item("METER_NO").ToString)
                MSGridMeter.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("base_product_id")), "", dt.Rows(i).Item("base_product_id").ToString)
                MSGridMeter.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("island_no")), "", dt.Rows(i).Item("island_no").ToString)

                If IIf(IsDBNull(dt.Rows(i).Item("color_code")), "", dt.Rows(i).Item("color_code").ToString) <> "" Then
                    MSGridMeter.Item(3, i).Value = Hex(IIf(IsDBNull(dt.Rows(i).Item("color_code")), "", dt.Rows(i).Item("color_code").ToString))
                    MSGridMeter.Item(3, i).Style.BackColor = ColorTranslator.FromHtml("#" + updateColorCode(MSGridMeter.Item(3, i).Value).ToString())
                Else
                    MSGridMeter.Item(3, i).Style.BackColor = Color.Black
                End If



                MSGridMeter.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("STEP_PROCESS")), "", dt.Rows(i).Item("STEP_PROCESS").ToString)


                StatusConect = IIf(IsDBNull(dt.Rows(i).Item("connect_status")), "", dt.Rows(i).Item("connect_status").ToString)
                If StatusConect = 1 Then
                    MSGridMeter.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CURRENT_FLOWRATE")), "", dt.Rows(i).Item("CURRENT_FLOWRATE").ToString)
                    MSGridMeter.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CURRENT_PRESET")), "", dt.Rows(i).Item("CURRENT_PRESET").ToString)
                    MSGridMeter.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("fv_control")), "", dt.Rows(i).Item("fv_control").ToString)
                    MSGridMeter.Item(8, i).Value = Gross
                    MSGridMeter.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("NET_15C_DELIVERY")), "", dt.Rows(i).Item("NET_15C_DELIVERY").ToString)
                    MSGridMeter.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("NET_30C_DELIVERY")), "", dt.Rows(i).Item("NET_30C_DELIVERY").ToString)
                    MSGridMeter.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CURRENT_TEMPERTURE")), "", dt.Rows(i).Item("CURRENT_TEMPERTURE").ToString)
                    MSGridMeter.Item(12, i).Value = IIf(IsDBNull(dt.Rows(i).Item("mass_air_delivery")), "", dt.Rows(i).Item("mass_air_delivery").ToString)
                    MSGridMeter.Item(13, i).Value = IIf(IsDBNull(dt.Rows(i).Item("mass_vac_delivery")), "", dt.Rows(i).Item("mass_vac_delivery").ToString)
                    MSGridMeter.Item(14, i).Value = IIf(IsDBNull(dt.Rows(i).Item("gross_totalizer")), "", dt.Rows(i).Item("gross_totalizer").ToString)
                    MSGridMeter.Item(15, i).Value = IIf(IsDBNull(dt.Rows(i).Item("net_15c_totalizer")), "", dt.Rows(i).Item("net_15c_totalizer").ToString)
                    MSGridMeter.Item(16, i).Value = IIf(IsDBNull(dt.Rows(i).Item("mass_totalizer")), "", dt.Rows(i).Item("mass_totalizer").ToString)

                    MSGridMeter.Item(17, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ENQUIRE_STATUS")), "", dt.Rows(i).Item("ENQUIRE_STATUS").ToString)
                    MSGridMeter.Item(18, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ALARM_SYSTEM_STATUS")), "", dt.Rows(i).Item("ALARM_SYSTEM_STATUS").ToString)
                    MSGridMeter.Item(19, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ALARM_PRODUCT_STATUS")), "", dt.Rows(i).Item("ALARM_PRODUCT_STATUS").ToString)
                    MSGridMeter.Item(20, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ALARM_ARM_STATUS")), "", dt.Rows(i).Item("ALARM_ARM_STATUS").ToString)
                    MSGridMeter.Item(21, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ALARM_METER_STATUS")), "", dt.Rows(i).Item("ALARM_METER_STATUS").ToString)
                    MSGridMeter.Item(22, i).Value = IIf(IsDBNull(dt.Rows(i).Item("MODE_ACTIVE")), "", dt.Rows(i).Item("MODE_ACTIVE").ToString)
                    MSGridMeter.Item(23, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)

                Else
                    Call AddDataToGrid(i)
                End If

                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing

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

    Private Sub AddDataToGrid(ByVal rowe As Integer)
        Dim i As Integer
        Try
            For i = 5 To 21
                MSGridMeter.Item(i, rowe).Value = "??????"
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ShowRefresh(ByVal product As String)

        Dim StatusConect As Long
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        If product <> "ALL" Then
            sql_str = "select * from tas.view_mmi_monitor_meter v" & _
                            " where v.base_product_id= '" & cbProduct.Text & "'" & _
                            " order by v.meter_no,v.meter"

        Else
            sql_str = "select * from tas.view_mmi_monitor_meter v" & _
                    " order by v.meter_no"

        End If

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            lbl_rec.Text = dt.Rows.Count
            i = 0
            MSGridMeter.RowCount = 0
            lbl_rec.Text = dt.Rows.Count
            Do While dt.Rows.Count > i

                MSGridMeter.RowCount = MSGridMeter.RowCount + 1
                MSGridMeter.Rows.Item(i).Height = Grid_Height

                Gross = IIf(IsDBNull(dt.Rows(i).Item("GROSS_DELIVERY")), 0, dt.Rows(i).Item("GROSS_DELIVERY"))
                MSGridMeter.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("METER_NO")), "", dt.Rows(i).Item("METER_NO").ToString)
                MSGridMeter.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("base_product_id")), "", dt.Rows(i).Item("base_product_id").ToString)
                MSGridMeter.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("island_no")), "", dt.Rows(i).Item("island_no").ToString)

                MSGridMeter.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("STEP_PROCESS")), "", dt.Rows(i).Item("STEP_PROCESS").ToString)
                StatusConect = IIf(IsDBNull(dt.Rows(i).Item("connect_status")), "", dt.Rows(i).Item("connect_status").ToString)
                If StatusConect = 1 Then
                    MSGridMeter.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CURRENT_FLOWRATE")), "", dt.Rows(i).Item("CURRENT_FLOWRATE").ToString)
                    MSGridMeter.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CURRENT_PRESET")), "", dt.Rows(i).Item("CURRENT_PRESET").ToString)
                    MSGridMeter.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("fv_control")), "", dt.Rows(i).Item("fv_control").ToString)
                    MSGridMeter.Item(8, i).Value = Gross
                    MSGridMeter.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("NET_15C_DELIVERY")), "", dt.Rows(i).Item("NET_15C_DELIVERY").ToString)
                    MSGridMeter.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("NET_30C_DELIVERY")), "", dt.Rows(i).Item("NET_30C_DELIVERY").ToString)
                    MSGridMeter.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CURRENT_TEMPERTURE")), "", dt.Rows(i).Item("CURRENT_TEMPERTURE").ToString)
                    MSGridMeter.Item(12, i).Value = IIf(IsDBNull(dt.Rows(i).Item("mass_air_delivery")), "", dt.Rows(i).Item("mass_air_delivery").ToString)
                    MSGridMeter.Item(13, i).Value = IIf(IsDBNull(dt.Rows(i).Item("mass_vac_delivery")), "", dt.Rows(i).Item("mass_vac_delivery").ToString)
                    MSGridMeter.Item(14, i).Value = IIf(IsDBNull(dt.Rows(i).Item("gross_totalizer")), "", dt.Rows(i).Item("gross_totalizer").ToString)
                    MSGridMeter.Item(15, i).Value = IIf(IsDBNull(dt.Rows(i).Item("net_15c_totalizer")), "", dt.Rows(i).Item("net_15c_totalizer").ToString)
                    MSGridMeter.Item(16, i).Value = IIf(IsDBNull(dt.Rows(i).Item("mass_totalizer")), "", dt.Rows(i).Item("mass_totalizer").ToString)

                    MSGridMeter.Item(17, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ENQUIRE_STATUS")), "", dt.Rows(i).Item("ENQUIRE_STATUS").ToString)
                    MSGridMeter.Item(18, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ALARM_SYSTEM_STATUS")), "", dt.Rows(i).Item("ALARM_SYSTEM_STATUS").ToString)
                    MSGridMeter.Item(19, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ALARM_PRODUCT_STATUS")), "", dt.Rows(i).Item("ALARM_PRODUCT_STATUS").ToString)
                    MSGridMeter.Item(20, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ALARM_ARM_STATUS")), "", dt.Rows(i).Item("ALARM_ARM_STATUS").ToString)
                    MSGridMeter.Item(21, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ALARM_METER_STATUS")), "", dt.Rows(i).Item("ALARM_METER_STATUS").ToString)
                    MSGridMeter.Item(22, i).Value = IIf(IsDBNull(dt.Rows(i).Item("MODE_ACTIVE")), "", dt.Rows(i).Item("MODE_ACTIVE").ToString)
                    MSGridMeter.Item(23, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
                Else
                    Call AddDataToGrid(i)
                End If

                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing

    End Sub

    Private Sub InitialCombo()

        Dim strSQL = " select BASE_PRODUCT_ID " & _
                    " from BASE_PRODUCT " & _
                    " group by BASE_PRODUCT_ID"
        assignDropDown(strSQL, "BASE_PRODUCT_ID", cbProduct)
    End Sub


    Function assignDropDown(ByVal sql_str As String, ByVal colName As String, ByVal cb As System.Object) As Boolean
        cb.Items.Clear()
        If "BASE_PRODUCT_ID" = colName Then

            cbProduct.Items.Add("ALL")
            cbProduct.SelectedIndex = 0
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

    Private Sub frmMMIMonitorMeter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        resolution(Me, 1)

        Call InitialCombo()
        Call ShowFlexGrid("ALL")
        'tScan.Interval = 3000
        'tScan.Enabled = True

    End Sub

    Private Sub cbProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProduct.SelectedIndexChanged
        ShowFlexGrid(cbProduct.Text)
    End Sub

    Private Function sql_query() As String


        If cbProduct.Text <> "ALL" Then

            strSQL = "SELECT * " &
                                  "FROM RPT.VIEW_MONITOR_METER  " &
                                  "WHERE base_product_id='" & cbProduct.Text & "'" &
                                  " order by meter_no,meter"
        Else
            strSQL = "SELECT * " &
                                  "FROM RPT.VIEW_MONITOR_METER  " &
                                  "order by base_product_id,meter_no"
        End If
        Return strSQL
    End Function

    Private Sub UcMenuPrint_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuPrint.OnClickMnuText

        'frmrptShowReport.mParameter = 52010030
        'frmrptShowReport.ValueParameter = -1
        'frmrptShowReport.mRptFileName = "MonitorMeter.rpt"
        'frmrptShowReport.Show()

        Try
            With frmrptMainShow
                .sql_query = sql_query()
                .report_id = "52010030"
                .Show()
            End With


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tScan_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call ShowRefresh(cbProduct.Text)
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