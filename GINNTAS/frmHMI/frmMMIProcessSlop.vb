
Imports Oracle.DataAccess.Client
Imports System.Data
Public Class frmMMIProcessSlop
    ' Option Explicit
    Dim vPage As Integer
    Dim indexMeter As Integer
    Dim MeterCount As Long
    Public FormScreenID As Long


    Private Sub frmMMIProcessSlop_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub


    Private Sub frmMMIProcessSlop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()


        InitialFrom()

        resolution(Me, 1)
    End Sub
    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub

    Private Sub InitialFrom()

        '=======================================================

        Dim strSQL As String
        strSQL = " select  t.* ,s.CURRENT_VALUE as SCALED_MAX " & _
                            " from steqi.view_mmi_processflow_slop t ,steqi.view_config_temp_slop_setting s   " & _
                            " Where t.SLOP_ID = 1 and s.CONFIG_NO = 1 "



        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")



            lblPN_Level.Text = IIf(IsDBNull(dt.Rows(i).Item("PUMP_NAME_SLOP_BASEOIL")), "", dt.Rows(i).Item("PUMP_NAME_SLOP_BASEOIL").ToString)
            lblValue.Text = IIf(IsDBNull(dt.Rows(i).Item("LEVEL_SLOP_BASEOIL")), "", dt.Rows(i).Item("LEVEL_SLOP_BASEOIL").ToString) & "  mm"
            lblLevelName.Text = IIf(IsDBNull(dt.Rows(i).Item("LEVEL_NAME_SLOP_BASEOIL")), "", dt.Rows(i).Item("LEVEL_NAME_SLOP_BASEOIL").ToString)

            lblPN_temp.Text = IIf(IsDBNull(dt.Rows(i).Item("PUMP_NAME_SLOP_BITUMEN")), "", dt.Rows(i).Item("PUMP_NAME_SLOP_BITUMEN").ToString)
            lbltemp.Text = IIf(IsDBNull(dt.Rows(i).Item("TEMP_SLOP_BITUMEN")), "", dt.Rows(i).Item("TEMP_SLOP_BITUMEN").ToString)
            lblTempName.Text = IIf(IsDBNull(dt.Rows(i).Item("TEMP_NAME_SLOP_BITUMEN")), "", dt.Rows(i).Item("TEMP_NAME_SLOP_BITUMEN").ToString)


            lblTempLL.Text = IIf(IsDBNull(dt.Rows(i).Item("TLL_SET_SLOP_BITUMEN")), "", dt.Rows(i).Item("TLL_SET_SLOP_BITUMEN").ToString)
            lblTempL.Text = IIf(IsDBNull(dt.Rows(i).Item("TL_SET_SLOP_BITUMEN")), "", dt.Rows(i).Item("TL_SET_SLOP_BITUMEN").ToString)
            lblTempH.Text = IIf(IsDBNull(dt.Rows(i).Item("TH_SET_SLOP_BITUMEN")), "", dt.Rows(i).Item("TH_SET_SLOP_BITUMEN").ToString)
            lblTempHH.Text = IIf(IsDBNull(dt.Rows(i).Item("THH_SETSLOP_BITUMEN")), "", dt.Rows(i).Item("THH_SETSLOP_BITUMEN").ToString)

            Select Case IIf(IsDBNull(dt.Rows(i).Item("LEVEL_ALARM_SLOP_BASEOIL")), 0, dt.Rows(i).Item("LEVEL_ALARM_SLOP_BASEOIL"))
                Case 2
                    lblLevelAlram.Text = "High High Alarm"
                    'statusPump1.Image = My.Resources.ResourceManager.GetObject("RR")
                    'statusPump1.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\RR.png")
                    statusPump1.Visible = False
                    lblLevelAlram.BackColor = Color.Red
                Case 1
                    lblLevelAlram.Text = "High Alarm"
                    lblLevelAlram.BackColor = Color.Red

                    'statusPump1.Image = My.Resources.ResourceManager.GetObject("RR")
                    ' statusPump1.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\RR.png")
                    statusPump1.Visible = False
                Case -1
                    lblLevelAlram.Text = "Low Alarm"
                    lblLevelAlram.BackColor = Color.Red
                Case -2
                    lblLevelAlram.Text = "Low Low Alarm"
                    lblLevelAlram.BackColor = Color.Red

                    'statusPump1.Image = My.Resources.ResourceManager.GetObject("RR")
                    'statusPump1.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\RR.png")
                    statusPump1.Visible = False
                Case Else
                    lblLevelAlram.Text = "Normal"
                    lblLevelAlram.BackColor = Color.GreenYellow ''&H8000000F
                    'statusPump1.Image = My.Resources.ResourceManager.GetObject("GG")
                    'statusPump1.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\GG.png")
                    statusPump1.Visible = True
            End Select


            Select Case IIf(IsDBNull(dt.Rows(i).Item("TEMP_ALARM_SLOP_BITUMEN")), 0, dt.Rows(i).Item("TEMP_ALARM_SLOP_BITUMEN"))
                Case 2
                    lblAlramTemp.Text = "High High Alarm"
                    lblAlramTemp.BackColor = Color.Red
                    'statusPump2.Image = My.Resources.ResourceManager.GetObject("RR")
                    'statusPump2.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\GG.png")
                    statusPump2.Visible = False
                Case 1
                    lblAlramTemp.Text = "High Alarm"
                    lblAlramTemp.BackColor = Color.Red
                    'statusPump2.Image = My.Resources.ResourceManager.GetObject("RR")
                    'statusPump2.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\RR.png")
                    statusPump2.Visible = False
                Case -1
                    lblAlramTemp.Text = "Low Alarm"
                    lblAlramTemp.BackColor = Color.Red
                    'statusPump2.Image = My.Resources.ResourceManager.GetObject("RR")
                    'statusPump2.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\RR.png")
                    statusPump2.Visible = False
                Case -2
                    lblAlramTemp.Text = "Low Low Alarm"
                    lblAlramTemp.BackColor = Color.Red
                    'statusPump2.Image = My.Resources.ResourceManager.GetObject("RR")
                    'statusPump2.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\RR.png")
                    statusPump2.Visible = False
                Case Else
                    lblAlramTemp.Text = "Normal"
                    lblAlramTemp.BackColor = Color.GreenYellow
                    'statusPump2.Image = My.Resources.ResourceManager.GetObject("GG")
                    'statusPump2.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\RR.png")
                    statusPump2.Visible = True
            End Select



            If IIf(IsDBNull(dt.Rows(i).Item("PUMP_SLOP_BASEOIL")), 0, dt.Rows(i).Item("PUMP_SLOP_BASEOIL")) Then
                'anigifPump.Image = My.Resources.ResourceManager.GetObject("pumpAfect_2")
                anigifPump.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\pumpAfect-2.gif")
            Else
                'anigifPump.Image = My.Resources.ResourceManager.GetObject("pumpAfect_1")
                anigifPump.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\pumpAfect-1.gif")
            End If

            If IIf(IsDBNull(dt.Rows(i).Item("PUMP_SLOP_BITUMEN")), 0, dt.Rows(i).Item("PUMP_SLOP_BITUMEN")) Then
                'anigifTemp.Image = My.Resources.ResourceManager.GetObject("pumpAfect_2")
                anigifTemp.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\pumpAfect-2.gif")
            Else
                'anigifTemp.Image = My.Resources.ResourceManager.GetObject("pumpAfect_1")
                anigifTemp.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\pumpAfect-1.gif")
            End If


            lblLevelLL.Text = IIf(IsDBNull(dt.Rows(i).Item("LLL_SET_SLOP_BASEOIL")), "", dt.Rows(i).Item("LLL_SET_SLOP_BASEOIL").ToString)
            lblLevelL.Text = IIf(IsDBNull(dt.Rows(i).Item("LL_SET_SLOP_BASEOIL")), "", dt.Rows(i).Item("LL_SET_SLOP_BASEOIL").ToString)
            lblLevelH.Text = IIf(IsDBNull(dt.Rows(i).Item("LH_SET_SLOP_BASEOIL")), "", dt.Rows(i).Item("LH_SET_SLOP_BASEOIL").ToString)
            lblLevelHH.Text = IIf(IsDBNull(dt.Rows(i).Item("LHH_SET_SLOP_BASEOIL")), "", dt.Rows(i).Item("LHH_SET_SLOP_BASEOIL").ToString)



            Dim levelOil = IIf(IsDBNull(dt.Rows(i).Item("LEVEL_SLOP_BASEOIL")), "", dt.Rows(i).Item("LEVEL_SLOP_BASEOIL").ToString)
            Dim h = IIf(IsDBNull(dt.Rows(i).Item("LEVEL_HIGH")), "", dt.Rows(i).Item("LEVEL_HIGH"))
            UcTank2.updateProgrssOil(CType(h * 100, Integer), CType(h * 100, Integer), CType(levelOil * 100, Integer))
            UcTank2.updateLine(CType(lblLevelLL.Text, Integer), CType(lblLevelL.Text, Integer), CType(lblLevelHH.Text, Integer), CType(lblLevelH.Text, Integer))



            Dim scaledMax = IIf(IsDBNull(dt.Rows(i).Item("SCALED_MAX")), "", dt.Rows(i).Item("SCALED_MAX").ToString)

            '  UcTank3.updateProgrssOil(CType(scaledMax, Integer), CType(scaledMax, Integer), CType(lbltemp.Text, Double))
            'UcTank3.updateLine(CType(lblTempLL.Text, Integer), CType(lblTempL.Text, Integer), CType(lblTempHH.Text, Integer), CType(lblTempH.Text, Integer))

            lbltemp.Text = lbltemp.Text & ("  C  ")
        Else
            lblPN_Level.Text = "????"
            lblLevelAlram.Text = "????"
            lblValue.Text = "????"
            lblLevelName.Text = "????"

            lblPN_temp.Text = "????"
            lblAlramTemp.Text = "????"
            lbltemp.Text = "????"
            lblTempName.Text = "????"
            'anigifPump.Image = My.Resources.ResourceManager.GetObject("pumpAfect_0")
            'anigifTemp.Image = My.Resources.ResourceManager.GetObject("pumpAfect_0")
            anigifPump.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\pumpAfect-0.gif")
            anigifTemp.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\pumpAfect-0.gif")

        End If
        mDataSet = Nothing


    End Sub


    Private Sub cmdSetLevel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetLevel.Click
        If Not P_CHECK_SCREEN_AUTHORIZE(mUserName, 311, 1) Then Exit Sub
        frmMMISlopLevel.Show()
    End Sub

    Private Sub cmdSetTemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetTemp.Click
        If Not P_CHECK_SCREEN_AUTHORIZE(mUserName, 311, 2) Then Exit Sub
        frmMMISlopTemp.Show()
    End Sub

    Private Sub Time_Scan_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerScan.Tick, TimerAlarm.Tick
        Call InitialFrom()
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