
Public Class UcFlowLoadingTLB

    'Option Explicit
    Dim vScan_Time As Boolean
    Dim BayCount As Integer
    Dim inDexBay As Integer
    Dim vMeter(100) As String
    Dim Meter As String

    Dim txt As New Collection
    Private mBay() As Long
    Public tThrLock As New Object

    Public Sub GetDetailFlowLineMeter(ByVal Index As Integer)
        Dim strSQL As String
        Dim i As Integer

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Try
            Meter = vMeter(Index)
            'MessageBox.Show("--->" + vMeter(Index))
            strSQL =
                      " select " &
                      " t.METER_NO , t.BASE_PRODUCT_ID, t.Sale_Product_Id,t.CONNECT_STATUS, t.BATCHING_ACTIVE, t.FLOW_RATE " &
                      " ,t.TEMPERATURE,t.PRESSURE,t.LOAD_HEADER_NO,t.BATCH_NO,t.TU_CARD_NO,t.VEHICLE_NUMBER,t.VEHICLE,t.driver_name ,t.Compartment_No " &
                      " ,t.TANK_ID,t.TANK_NAME,t.ADVICE,t.DENSITY_15C,t.LOADED_GROSS,t.PERCENT_LOADED ,t.compament_capacity" &
                      " ,t.BATCH_STATUS_NUM,t.BATCH_STATUS,t.PLC_CONNECT_STATUS,t.PUMP_SEL_SPARE,t.PUMP_NAME" &
                      " ,t.PUMP_MODE,t.PUMP_RUN,t.TEMP_NAME,t.PRESSURE_NAME,t.FV_NAME,t.ARM_SIDE_A,t.ARM_SIDE_B ,t.ARM_LEFT_ACTIVE,t.ARM_RIGHT_ACTIVE" &
                      " ,t.PRESSURE_DIFF_ALARM,t.TEMP_1_ALARM,t.TEMP_NAME1,t.TEMPERATURE1,t.FV_CONTROL ,t.FLOW_ACTIVE,t.ARM_DOWN_A,t.ARM_DOWN_B,t.EARTH_A,t.EARTH_B,t.OVERSFILL_A,t.OVERSFILL_B,t.ESD ,t.PREMISSIVE_A,t.PREMISSIVE_B  " &
                      " ,t.BALL_VALVE_A,t.BALL_VALVE_B " &
                      " from  steqi.view_mmi_processflow_meter t " &
                      " where  t.meter_no ='" & Trim(vMeter(Index)) & "'"

            If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                i = 0
                dt = mDataSet.Tables("TableName1")
                If dt.Rows.Count > 0 Then

                    If Index <= 3 Then   ' Base Oil
                        AniBllVale.Visible = True
                        cmdSetLevel.Text = "Set Pressure"
                        If CInt(IIf(IsDBNull(dt.Rows(i).Item("FLOW_ACTIVE")), 0, dt.Rows(i).Item("FLOW_ACTIVE"))) = 1 Then
                            ControlPicGreen(1)
                        Else
                            ControlPicGreen(0)
                        End If
                        If Not IIf(IsDBNull(dt.Rows(i).Item("BATCH_STATUS_NUM")), 0, dt.Rows(i).Item("BATCH_STATUS_NUM")) Then
                            If CInt(IIf(IsDBNull(dt.Rows(i).Item("BATCH_STATUS_NUM")), 0, dt.Rows(i).Item("BATCH_STATUS_NUM"))) = 3 Or CInt(IIf(IsDBNull(dt.Rows(i).Item("BATCH_STATUS_NUM")), 0, dt.Rows(i).Item("BATCH_STATUS_NUM"))) = 4 Then
                                ControlPicShow(1)
                            Else
                                ControlPicShow(0)
                            End If
                        Else
                            ControlPicShow(0)
                        End If

                        If CInt(IIf(IsDBNull(dt.Rows(i).Item("PUMP_RUN")), "0", dt.Rows(i).Item("PUMP_RUN").ToString)) = 0 Then
                            ControlAniGifPump(1)
                        Else
                            ControlAniGifPump(2)
                        End If

                        txt(1 + 9).text = IIf(IsDBNull(dt.Rows(i).Item("PRESSURE_NAME")), "-", dt.Rows(i).Item("PRESSURE_NAME").ToString)
                        txt(1 + 10).text = IIf(IsDBNull(dt.Rows(i).Item("Pressure")), "0", dt.Rows(i).Item("Pressure").ToString)
                        Call GetPressureOrTemp(IIf(IsDBNull(dt.Rows(i).Item("PRESSURE_DIFF_ALARM")), 0, dt.Rows(i).Item("PRESSURE_DIFF_ALARM")), 0)
                    Else  ' Bitumen

                        AniBllVale.Visible = False
                        cmdSetLevel.Text = "Set Temp"
                        'IIf(IsDBNull(dt.Rows(i).Item("FLOW_ACTIVE")), 0, dt.Rows(i).Item("FLOW_ACTIVE"))
                        If CInt(IIf(IsDBNull(dt.Rows(i).Item("FLOW_ACTIVE")), 0, dt.Rows(i).Item("FLOW_ACTIVE"))) = 1 Then
                            ControlPicGreen(2)
                            ControlAniGifPump(2)
                        Else
                            ControlPicGreen(0)
                            ControlAniGifPump(1)
                        End If
                        If Not IIf(IsDBNull(dt.Rows(i).Item("BATCH_STATUS_NUM")), 0, dt.Rows(i).Item("BATCH_STATUS_NUM")) Then
                            If CInt(IIf(IsDBNull(dt.Rows(i).Item("BATCH_STATUS_NUM")), 0, dt.Rows(i).Item("BATCH_STATUS_NUM"))) = 3 Or CInt(IIf(IsDBNull(dt.Rows(i).Item("BATCH_STATUS_NUM")), 0, dt.Rows(i).Item("BATCH_STATUS_NUM"))) = 4 Then
                                ControlPicShow(3)
                            Else
                                ControlPicShow(2)
                            End If
                        Else
                            ControlPicShow(2)
                        End If

                        txt(1 + 9).text = IIf(IsDBNull(dt.Rows(i).Item("TEMP_NAME1")), "-", dt.Rows(i).Item("TEMP_NAME1").ToString)
                        txt(1 + 10).text = IIf(IsDBNull(dt.Rows(i).Item("TEMPERATURE1")), "0", dt.Rows(i).Item("TEMPERATURE1").ToString)
                        Call GetPressureOrTemp(IIf(IsDBNull(dt.Rows(i).Item("TEMP_1_ALARM")), "0", dt.Rows(i).Item("TEMP_1_ALARM").ToString), 1)
                        '           
                    End If

                    ''IIf(IsDBNull(dt.Rows(i).Item("ARM_SIDE_A")) = 1, dt.Rows(i).Item("BALL_VALVE_A"), dt.Rows(i).Item("BALL_VALVE_B"))
                    If IIf(CInt(IsDBNull(dt.Rows(i).Item("ARM_SIDE_A"))) = 1, CInt(dt.Rows(i).Item("BALL_VALVE_A")), CInt(dt.Rows(i).Item("BALL_VALVE_B"))) Then
                        ConTrolAniGifBallVale(2)
                    Else
                        ConTrolAniGifBallVale(1)
                    End If
                    ''Call ESD(CInt(Oratemp!ESD), cmdESD)

                    'IIf(IsDBNull(dt.Rows(i).Item("PREMISSIVE_B")), 0, dt.Rows(i).Item("PREMISSIVE_B"))
                    Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("ARM_SIDE_A")), 0, dt.Rows(i).Item("ARM_SIDE_A")), txt(1 + 18))
                    Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("BALL_VALVE_A")), 0, dt.Rows(i).Item("BALL_VALVE_A")), txt(1 + 19))
                    Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("ARM_DOWN_A")), 0, dt.Rows(i).Item("ARM_DOWN_A")), txt(1 + 20))
                    Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("EARTH_A")), 0, dt.Rows(i).Item("EARTH_A")), txt(1 + 21))
                    Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("OVERSFILL_A")), 0, dt.Rows(i).Item("OVERSFILL_A")), txt(1 + 22))
                    Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("PREMISSIVE_A")), 0, dt.Rows(i).Item("PREMISSIVE_A")), txt(1 + 23))


                    Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("ARM_SIDE_B")), 0, dt.Rows(i).Item("ARM_SIDE_B")), txt(1 + 24))
                    Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("BALL_VALVE_B")), 0, dt.Rows(i).Item("BALL_VALVE_B")), txt(1 + 25))
                    Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("ARM_DOWN_B")), 0, dt.Rows(i).Item("ARM_DOWN_B")), txt(1 + 26))
                    Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("EARTH_B")), 0, dt.Rows(i).Item("EARTH_B")), txt(1 + 27))
                    Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("OVERSFILL_B")), 0, dt.Rows(i).Item("OVERSFILL_B")), txt(1 + 28))
                    Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("PREMISSIVE_B")), 0, dt.Rows(i).Item("PREMISSIVE_B")), txt(1 + 29))


                    'IIf(IsDBNull(dt.Rows(i).Item("PUMP_NAME")), "-", dt.Rows(i).Item("PUMP_NAME").ToString)
                    txt(1 + 5).text = IIf(IsDBNull(dt.Rows(i).Item("FV_CONTROL")), "0", dt.Rows(i).Item("FV_CONTROL").ToString)
                    txt(1 + 16).text = "ช่องเติม : " & IIf(IsDBNull(dt.Rows(i).Item("COMPARTMENT_NO")), "-", dt.Rows(i).Item("COMPARTMENT_NO").ToString)
                    txt(1 + 4).text = IIf(IsDBNull(dt.Rows(i).Item("batch_status")), "??", dt.Rows(i).Item("batch_status").ToString)
                    '                    txt(1+10) = Format(IIf(IsNull(Oratemp!PRESSURE), "0", Oratemp!PRESSURE), "0#.00")
                    txt(1 + 8).text = IIf(IsDBNull(dt.Rows(i).Item("TEMPERATURE")), "0", dt.Rows(i).Item("TEMPERATURE").ToString)
                    'Format(IIf(IsNull(Oratemp!TEMPERATURE), "0", Oratemp!TEMPERATURE), "0#.00")
                    txt(1 + 6).text = IIf(IsDBNull(dt.Rows(i).Item("FLOW_RATE")), "0", dt.Rows(i).Item("FLOW_RATE").ToString)
                    'Format(IIf(IsNull(Oratemp!FLOW_RATE), "0", Oratemp!FLOW_RATE), "000#.0")
                    GetMeterValue(Trim(vMeter(Index)))

                    txt(1 + 0).text = IIf(IsDBNull(dt.Rows(i).Item("tank_name")), "??", dt.Rows(i).Item("tank_name").ToString)
                    txt(1 + 17).text = "LoadNo :" & IIf(IsDBNull(dt.Rows(i).Item("LOAD_HEADER_NO")), "0", dt.Rows(i).Item("LOAD_HEADER_NO").ToString)
                    txt(1 + 13).text = "CardNo :" & IIf(IsDBNull(dt.Rows(i).Item("tu_card_no")), "0", dt.Rows(i).Item("tu_card_no").ToString)
                    txt(1 + 14).text = "ทะเบียน :" & IIf(IsDBNull(dt.Rows(i).Item("vehicle")), "-", dt.Rows(i).Item("vehicle").ToString)
                    txt(1 + 15).text = "ชื่อพขร :" & IIf(IsDBNull(dt.Rows(i).Item("driver_name")), "-", dt.Rows(i).Item("driver_name").ToString)
                    txt(1 + 2).text = IIf(IsDBNull(dt.Rows(i).Item("base_product_id")), "-", dt.Rows(i).Item("base_product_id").ToString)
                    txt(1 + 3).text = IIf(IsDBNull(dt.Rows(i).Item("PUMP_NAME")), "-", dt.Rows(i).Item("PUMP_NAME").ToString)
                    '                    txt(1+9) = IIf(IsNull(Oratemp!PRESSURE_NAME), "-", Oratemp!PRESSURE_NAME)


                    'IIf(IsDBNull(dt.Rows(i).Item("DENSITY_15C")), "0", dt.Rows(i).Item("DENSITY_15C").ToString)
                    txt(1 + 7).text = IIf(IsDBNull(dt.Rows(i).Item("TEMP_NAME")), "-", dt.Rows(i).Item("TEMP_NAME").ToString)
                    txt(1 + 11).text = IIf(IsDBNull(dt.Rows(i).Item("FV_NAME")), "-", dt.Rows(i).Item("FV_NAME").ToString)
                    txt(1 + 1).text = "Den15C:" & IIf(IsDBNull(dt.Rows(i).Item("DENSITY_15C")), "0", dt.Rows(i).Item("DENSITY_15C").ToString)
                    'Format(IIf(IsNull(Oratemp!DENSITY_15C), "0", Oratemp!DENSITY_15C), "0#.00")
                    'close Balvave

                    If vScan_Time Then
                        i = 0

                        If Index >= 4 Then
                            'AniBllVale.Visible = False
                            'IIf(IsDBNull(dt.Rows(i).Item("ARM_LEFT_ACTIVE")), 0, dt.Rows(i).Item("ARM_LEFT_ACTIVE"))
                            If IIf(IsDBNull(dt.Rows(i).Item("ARM_LEFT_ACTIVE")), 0, dt.Rows(i).Item("ARM_LEFT_ACTIVE")) = 0 Then
                                Label1.Visible = False  ' ½Ñè§¢ÇÒ
                                Label2.Location = New Point(Label1.Location.X, Label1.Location.Y)

                                TextBox19.Visible = False
                                TextBox20.Visible = False
                                TextBox21.Visible = False
                                TextBox22.Visible = False
                                TextBox23.Visible = False
                                TextBox24.Visible = False

                                TextBox26.Visible = False

                                TextBox25.Location = New Point(TextBox19.Location.X, TextBox19.Location.Y)
                                'TextBox26.Location = New Point(TextBox20.Location.X, TextBox20.Location.Y)
                                TextBox27.Location = New Point(TextBox20.Location.X, TextBox20.Location.Y)
                                TextBox28.Location = New Point(TextBox21.Location.X, TextBox21.Location.Y)
                                TextBox29.Location = New Point(TextBox22.Location.X, TextBox22.Location.Y)
                                TextBox30.Location = New Point(TextBox23.Location.X, TextBox23.Location.Y)
                            Else
                                'AniBllVale.Visible = False
                                Label2.Visible = False  '  «éÒÂ
                                'Label2.Location = New Point(Label1.Location.X, Label1.Location.Y)

                                TextBox25.Visible = False
                                TextBox26.Visible = False
                                TextBox27.Visible = False
                                TextBox28.Visible = False
                                TextBox29.Visible = False
                                TextBox30.Visible = False

                                TextBox20.Visible = False


                                TextBox24.Location = New Point(TextBox23.Location.X, TextBox23.Location.Y)
                                TextBox23.Location = New Point(TextBox22.Location.X, TextBox22.Location.Y)
                                TextBox22.Location = New Point(TextBox21.Location.X, TextBox21.Location.Y)
                                TextBox21.Location = New Point(TextBox20.Location.X, TextBox20.Location.Y)
                            End If
                            ' 
                            vScan_Time = False
                        Else
                            'AniBllVale.Visible = True
                        End If
                        ''HideText(True)
                        '                Call InitailProgress(CLng(IIf(IsNull(Oratemp!advice), "0", Oratemp!advice)), CLng(IIf(IsNull(Oratemp!advice), "0", Oratemp!advice)), IIf(IsNull(Oratemp!sale_product_id), "0", Oratemp!sale_product_id))
                    End If


                    'IIf(IsDBNull(dt.Rows(i).Item("tank_name")), 0, dt.Rows(i).Item("tank_name")))
                    ''
                    InitailProgress(IIf(IsDBNull(dt.Rows(i).Item("advice")), 0, dt.Rows(i).Item("advice")), IIf(IsDBNull(dt.Rows(i).Item("loaded_gross")), 0, dt.Rows(i).Item("loaded_gross")), dt.Rows(i).Item("base_product_id"))


                    InitailProgressTank(IIf(IsDBNull(dt.Rows(i).Item("tank_name")), 0, dt.Rows(i).Item("tank_name")))
                    ''Call InitailProgress(CLng(IIf(IsNull(Oratemp!advice), "0", Oratemp!advice)), CLng(IIf(IsNull(Oratemp!advice), "0", Oratemp!advice)), IIf(IsNull(Oratemp!sale_product_id), "0", Oratemp!sale_product_id))
                    ''Call RunProgress(CLng(IIf(IsNull(Oratemp!loaded_gross), "0", Oratemp!loaded_gross)))


                    vScan_Time = False

                    UcProgressLevelTank.Parent = AniGiflow
                    AniGifFlowGreen.Parent = AniGiflow
                    AniGifFlowGreen.Location = New Point(0, 0)

                End If
            Else
                If Index >= 4 Then
                    ControlPicShow(2)
                Else
                    ControlPicShow(0)
                End If
                'HideText(False)
                vScan_Time = True
            End If
            GroupBox1.Visible = True
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try
        'GroupBox1.Visible = False
        mDataSet = Nothing
    End Sub

    Private Sub GetActiveBay()
        Dim indexMeter = 1
        Try
            If indexMeter <= 6 Then
                GetDetailFlowLineMeter(CInt(indexMeter))
                indexMeter = indexMeter + 1
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub UcFlowLoading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        txt.Add(TextBox13)
        txt.Add(TextBox14)
        txt.Add(TextBox15)

        txt.Add(TextBox16)
        txt.Add(TextBox17)
        txt.Add(TextBox18)
        txt.Add(TextBox19)
        txt.Add(TextBox20)

        txt.Add(TextBox21)
        txt.Add(TextBox22)
        txt.Add(TextBox23)
        txt.Add(TextBox24)
        txt.Add(TextBox25)

        txt.Add(TextBox26)
        txt.Add(TextBox27)
        txt.Add(TextBox28)
        txt.Add(TextBox29)
        txt.Add(TextBox30)

        txt.Add(TextBox31)


        If inDexBay >= 4 Then
            ControlPicShow(2)
            cmdSetLevel.Text = "Set Temp"
        Else
            ControlPicShow(0)
            cmdSetLevel.Text = "Set Pressure"
        End If
        'ControlAniGifPump(0)
        ConTrolAniGifBallVale(0)
        ControlPicGreen(0)
        'GetMeterCount()
        vScan_Time = True
        'resolution(Me, 1)
    End Sub

    Private Sub SaftGarudingAc(ByVal iValue As Integer, ByVal txt As TextBox)
        If iValue = 0 Then
            txt.BackColor = Color.Red
        Else
            txt.BackColor = Color.FromArgb(76, 175, 80)
        End If
    End Sub

    Private Sub InitailProgressTank(ByVal iTank As String)
        Dim strSQL As String
        Dim i As Integer

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        mDataSet = Nothing


        strSQL =
                        " select " &
                        " t.base_product , t.tank_high,t.tank_capacity " &
                        " ,t.level_l , t.level_h , t.level_ll , t.level_hh ,t.levels " &
                        " from tas.view_map_tank_data t " &
                        " where t.tank_name = '" & Trim(iTank) & "' " &
                        " order by t.tank_id "


        ''---------------------------

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            i = 0
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                '
                UcProgressLevelTank.updateProgrssOil(IIf(IsDBNull(dt.Rows(i).Item("tank_high")), 0, dt.Rows(i).Item("tank_high")), IIf(IsDBNull(dt.Rows(i).Item("tank_high")), 0, dt.Rows(i).Item("tank_high")), IIf(IsDBNull(dt.Rows(i).Item("levels")), 0, dt.Rows(i).Item("levels")))

            End If
        Else
        End If
        mDataSet = Nothing

    End Sub
    Function SetProgressColor(ProductID As String) As String
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        SetProgressColor = ""
        strSQL =
                  " select S.COLOR_CODE " &
                  " from base_product S,view_sale_base_product P " &
                  " where S.BASE_PRODUCT_ID=P.BASE_PRODUCT_ID " &
                  " and P.BASE_PRODUCT_ID='" & ProductID & "'"
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                SetProgressColor = dt.Rows(0).Item("COLOR_CODE").ToString
            End If

        End If

        mDataSet = Nothing
    End Function

    Private Sub InitailProgress(ByVal iAdvice As Long, ByVal iLoadGross As Long, ByVal iSalePrduct As String)
        Dim pColor As String
        vScan_Time = True
        UcProgress.Visible = True
        'UcProgress.VisibeLabel(False)
        pColor = SetProgressColor(iSalePrduct)
        UcProgress.updateProgrssOil(iAdvice, iAdvice, iLoadGross)
        If Not pColor.Equals("") Then
            UcProgress.SetColor(pColor)
            UcProgressLevelTank.SetColor(pColor)
        End If


        'SetLimitBar(CDbl(iAdvice), CDbl(iLoadGross))
    End Sub

    Public Sub SetMeter(ByVal iIndex As Integer, ByVal iMeterNo As String)
        vMeter(iIndex) = iMeterNo
        inDexBay = iIndex
        'MessageBox.Show(vMeter(iIndex))
        txtMeter.Text = "Meter No." & iMeterNo
    End Sub

    Private Sub GetMeterCount()

        '-------------------
        Dim strSQL As String
        Dim dt As DataTable
        strSQL = " select count (*)  as vCount   from  tas.meter"
        dt = Oradb.Query_TBL(strSQL)
        If dt.Rows.Count > 0 Then
            ReDim Preserve vMeter(IIf(IsDBNull(dt.Rows(0).Item("vCount")), 0, dt.Rows(0).Item("vCount")))
        End If
    End Sub

    Private Sub cmdSetLevel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetLevel.Click
        'MessageBox.Show(vMeter(inDexBay))
        If inDexBay <= 3 Then
            frmMMIProcessSetLevel.GetMeterNo(Trim(vMeter(inDexBay)))
            frmMMIProcessSetLevel.Show()
        Else
            frmMMIProcessSetTemp.Show()
        End If

    End Sub

    Private Sub cmdESD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdESD.Click
        frmMMIPermissive.GetPermissiveMeter(Meter)
        frmMMIPermissive.Show()
    End Sub

    Public Sub ControlPicGreen(ByVal indexFrame As Integer)
        'AniGifFlowGreen.Image = Nothing
        If indexFrame = 0 Then
            AniGifFlowGreen.Image = Nothing
        ElseIf indexFrame = 1 Then
            AniGifFlowGreen.Image = My.Resources.ResourceManager.GetObject("MMIProcessFlow2")
        Else
            AniGifFlowGreen.Image = My.Resources.ResourceManager.GetObject("MMIProcessFlow1")
        End If

    End Sub
    Public Sub ControlPicShow(ByVal indexFrame As Integer)
        AniGiflow.Image = My.Resources.ResourceManager.GetObject("ProcessFlow_tran_" & indexFrame)

    End Sub

    Private Sub ConTrolAniGifBallVale(ByVal iFrame As Integer)
        AniBllVale.Image = My.Resources.ResourceManager.GetObject("BallVale" & iFrame)
        'AniBllVale.Image = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\BallVale-" & iFrame & ".gif")
    End Sub

    Private Sub ControlAniGifPump(ByVal iFrame As Integer)
        AniPump.Image = My.Resources.ResourceManager.GetObject("pumpAfect_" & iFrame)
    End Sub
    Private Sub GetPressureOrTemp(ByVal iAlarm As Integer, ByVal iProduct As Integer) ' iProduct  0 = BaseOil  , 1 = Bitument
        If iProduct = 0 Then
            Select Case iAlarm
                Case -2
                    TextBox31.Text = "Pressure LowLow  Alarm  " : TextBox31.BackColor = Color.Red
                Case -1
                    TextBox31.Text = "Pressure  Low  Alarm  " : TextBox31.BackColor = Color.Red
                Case 0
                    TextBox31.Text = "Pressure Normal" : TextBox31.BackColor = Color.GreenYellow
                Case 1
                    TextBox31.Text = "Pressure High  Alarm  " : TextBox31.BackColor = Color.Red
                Case 2
                    TextBox31.Text = "Pressure HighHigh  Alarm  " : TextBox31.BackColor = Color.Red
            End Select
        Else
            Select Case iAlarm
                Case -2
                    TextBox31.Text = "Temp LowLow  Alarm  " : TextBox31.BackColor = Color.Red
                Case -1
                    TextBox31.Text = "Temp  Low  Alarm  " : TextBox31.BackColor = Color.Red
                Case 0
                    TextBox31.Text = "Temp Normal" : TextBox31.BackColor = Color.GreenYellow
                Case 1
                    TextBox31.Text = "Temp High  Alarm  " : TextBox31.BackColor = Color.Red
                Case 2
                    TextBox31.Text = "Temp HighHigh  Alarm  " : TextBox31.BackColor = Color.Red
            End Select
        End If
    End Sub

    Private Sub GetMeterValue(ByVal iMeter As String)

        Dim strSQL As String

        Dim i As Integer

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        mDataSet = Nothing


        strSQL =
                      "select  * " &
                      " from tas.view_mmi_bay_meter a" &
                      " Where A.METER_NO ='" & iMeter & "' " &
                      " Order by A.METER_NO "

        ''---------------------------

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            i = 0
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                txt(12 + 1).text = "ArmSide: " & IIf(IsDBNull(dt.Rows(i).Item("meter_pos")), "??", (IIf(dt.Rows(i).Item("meter_pos").ToString = "LEFT", "A", "B")))
            End If
        Else
        End If
        mDataSet = Nothing

    End Sub


    Private Sub tScan_Tick(sender As System.Object, e As System.EventArgs) Handles tScan.Tick
        'GetActiveBay()
    End Sub


End Class
