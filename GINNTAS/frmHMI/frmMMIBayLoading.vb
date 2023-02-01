
Imports System.Data
Public Class frmMMIBayLoading
    Public FormScreenID As Long

    Public Meter_Name As String
    Dim CBay As Long, TempBay As Integer
    Dim lblBayNo(7) As String
    Dim ChkClickGrid
    Dim Row_New As Integer
    'Dim UcProgress As New Collection
    Public TopUP, Compartment, LoadHeader As String, ChackBatchstatus As Long
    Dim MeterChange As String
    Dim P_ComputerName As String = System.Net.Dns.GetHostName
    Dim CPicture As Boolean, Gross As Long
    Dim tempI As Integer
    'Dim ProgressBar As New Collection
    Public mBayName As String
    Dim Row_Old As Integer
    Dim buttonBay As New Collection
    Dim mBayNo
    Dim vMeter As String
    'Dim strRootPathPic = AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 11)

    Private Sub Initial_frm()
        mBayName = "1"
        mBayNo = "1"
        lblBayNum.Text = "BAY NO. " & CType(mBayName, String)
        InitialSQLQueury()

        InitialDataHeaders(1)
        InitialDataLines(1)
        InitialMeter(1)
        AlarmType()
        Row_New = 0
        ChkClickGrid = 0
        CPicture = True
        InitialBayNumber()
        selectBay(mBayNo, mBayName)
        'UcPermissive1.ShowData(Trim(Meter_Name))
    End Sub

    Private Sub frmMMIBayLoading_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        If FormScreenID <> 0 Then
            CloseForm(FormScreenID, "")
        End If
    End Sub

    Private Sub frmMMIBayLoading_main_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

#Region "Menu Event"
    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub
#End Region

    Private Sub frmMMIBayLoading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        Initial_frm()
        resolution(Me, 0.97)
        tScan1.Enabled = True
        tScan1.Interval = 2000
        tScan2.Start()

    End Sub

    Private Sub InitialBayNumber()

        Dim strSQL =
            "select B.BAY_NO,B.BAY_NAME from view_bay_mmi_loading B " &
            "order by B.BAY_NO"

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim j = 0
        'UcButtonBay1.Width = 60
        'UcButtonBay1.Height = 30
        Dim xlocation As Integer = 2
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Do While dt.Rows.Count > j
                Dim nButtonBay = New ucButtonBay()
                'pnlHeader.Controls.Add(nButtonBay)
                'nButtonBay.Size = New Size(60, 25)
                'nButtonBay.Location = New Point(2 + UcHeader1.Location.X + UcButtonBay1.Size.Width * j, UcHeader1.Location.Y - UcButtonBay1.Size.Height)
                nButtonBay.Location = New Point(2 + UcButtonBay1.Location.X + UcButtonBay1.Size.Width * j, 2)
                nButtonBay.Text = IIf(IsDBNull(dt.Rows(j).Item("BAY_NAME")), "- -", dt.Rows(j).Item("BAY_NAME").ToString)

                nButtonBay.createButtonBay(UcButtonBay1.Size.Width, UcButtonBay1.Size.Height _
                                           , IIf(IsDBNull(dt.Rows(j).Item("BAY_NO")), "- -" _
                                           , dt.Rows(j).Item("BAY_NO").ToString), IIf(IsDBNull(dt.Rows(j).Item("BAY_NAME")) _
                                           , "- -", dt.Rows(j).Item("BAY_NAME").ToString))

                pnlHeader.Controls.Add(nButtonBay)
                buttonBay.Add(nButtonBay)

                'Dim btnButtonbay As Button = New Button()
                'btnButtonbay.Name = IIf(IsDBNull(dt.Rows(j).Item("BAY_NAME")), "- -", dt.Rows(j).Item("BAY_NAME").ToString)
                'btnButtonbay.Text = IIf(IsDBNull(dt.Rows(j).Item("BAY_NO")), "- -", dt.Rows(j).Item("BAY_NO").ToString)
                'btnButtonbay.Location = New Point(xlocation + UcButtonBay1.Size.Width, UcHeader1.Height + 4)
                'btnButtonbay.BringToFront()
                'btnButtonbay.Size = New Size(UcButtonBay1.Size.Height, UcButtonBay1.Size.Width)
                'Me.pnlHeader.Controls.Add(btnButtonbay)
                'xlocation = xlocation + 20
                j = j + 1
            Loop
        End If


        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub
    Private Sub btnSelect_Click(sender As System.Object, e As System.EventArgs)
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.Green
    End Sub
    Private Sub PainSelGrid(ByVal iRow_new As Integer, ByVal iMsgrid As DataGridView)
        Dim i As Integer
        If iRow_new = 0 Then Exit Sub
        With iMsgrid
            If Row_Old <> 0 Then
                For i = 0 To iMsgrid.ColumnCount - 1
                    'iMsgrid.Item(i, Row_Old).Style.BackColor = Color.White

                Next i
            End If
            For i = 0 To iMsgrid.ColumnCount - 1
                'iMsgrid.Item(i, Row_Old).Style.BackColor = Color.Yellow
            Next i
            Row_Old = iRow_new
        End With
    End Sub

    Private Sub initialMeterDiscription()
        lblMeterPreset.Text = ""
        lblMeterLoaded.Text = ""
        lblFlowRate.Text = ""
        lblMeterTOT.Text = ""
        CmdEnable.Text = ""
        CmdLock.Text = ""
        CmdLoad.Text = ""
    End Sub

    Private Sub InitialDataHeaders(ByVal BayName As String)
        Dim strSQL As String
        strSQL = "select H.* "
        strSQL = strSQL & " from OIL_TEMP_LOAD_HEADERS H "
        strSQL = strSQL & "where H.LOAD_STATUS in (51,52,53,54,55) "
        strSQL = strSQL & "and H.CANCEL_STATUS=0 "
        strSQL = strSQL & "and H.LOAD_HEADER_NO= (select B.LAST_LOAD_NO  from BAY B where B.BAY_ACTIVE = 1 and B.BAY_NAME='" & BayName & "') "

        Dim mDataSet As New DataSet
        Dim i As Integer = 0
        Dim dt As DataTable
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet, False) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                btClear.Text = IIf(IsDBNull(dt.Rows(i).Item("TU_CARD_NO")), "", dt.Rows(i).Item("TU_CARD_NO").ToString)
                lblCardTran.Text = IIf(IsDBNull(dt.Rows(i).Item("TU_CARD_NO1")), "", dt.Rows(i).Item("TU_CARD_NO1").ToString)
                lblTruckName.Text = IIf(IsDBNull(dt.Rows(i).Item("TU_ID")), "", dt.Rows(i).Item("TU_ID").ToString)
                lblTruckTran.Text = IIf(IsDBNull(dt.Rows(i).Item("TU_ID1")), "", dt.Rows(i).Item("TU_ID1").ToString)
                lblDriverName.Text = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_NAME")), "", dt.Rows(i).Item("DRIVER_NAME").ToString)
                lblDriverID.Text = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_CODE")), "", dt.Rows(i).Item("DRIVER_CODE").ToString)
                lblloadNo.Text = IIf(IsDBNull(dt.Rows(i).Item("LOAD_HEADER_NO")), "", dt.Rows(i).Item("LOAD_HEADER_NO").ToString)
                lblShipment.Text = IIf(IsDBNull(dt.Rows(i).Item("SHIPMENT_NO")), "", dt.Rows(i).Item("SHIPMENT_NO").ToString)
                lblCarrierName.Text = IIf(IsDBNull(dt.Rows(i).Item("CARRIER_NAME")), "", dt.Rows(i).Item("CARRIER_NAME").ToString)
                lblVehicle.Text = IIf(IsDBNull(dt.Rows(i).Item("Vehicle_Number")), "", dt.Rows(i).Item("Vehicle_Number").ToString)
                lblVehicleMapType.Text = IIf(IsDBNull(dt.Rows(i).Item("VEHICLE_MAP_TYPE")), "", dt.Rows(i).Item("VEHICLE_MAP_TYPE").ToString)

                Dim dateTimeStart = IIf(IsDBNull(dt.Rows(i).Item("T_START")), "", dt.Rows(i).Item("T_START").ToString)
                Dim strTimeStart = dateTimeStart.Split(" ")
                If Trim(dateTimeStart) <> "" Then
                    txtStartT.Text = strTimeStart(1)
                End If
                Dim dateTimeStop = IIf(IsDBNull(dt.Rows(i).Item("T_STOP")), "", dt.Rows(i).Item("T_STOP").ToString)
                Dim strTimeStop = dateTimeStop.Split(" ")
                If Trim(dateTimeStop) <> "" Then
                    txtStopT.Text = strTimeStop(1)
                End If
                If IsDBNull(dt.Rows(i).Item("T_STOP")) Or IsDBNull(dt.Rows(i).Item("T_START")) Then
                    txtTotLoad.Text = ""
                Else
                    calTime()
                End If
                CmdLoadLocked.Text = IIf(IsDBNull(dt.Rows(i).Item("loading_locked")), "", IIf(dt.Rows(i).Item("loading_locked") = 1, "Lock การจ่าย", "Unlock การจ่าย"))
                CmdLoadLocked.BackColor = IIf(IsDBNull(dt.Rows(i).Item("loading_locked")), "", IIf(dt.Rows(i).Item("loading_locked") = 1, Color.Red, Color.Green))

            Else
                lblCarrierName.Text = ""
                btClear.Text = ""
                lblCardTran.Text = ""
                'lblTruckName = ""
                lblTruckTran.Text = ""
                lblDriverName.Text = ""
                lblDriverID.Text = ""
                lblloadNo.Text = ""
                lblShipment.Text = ""
                lblVehicle.Text = ""
                lblVehicleMapType.Text = ""
                txtStartT.Text = ""
                txtStopT.Text = ""
                txtTotLoad.Text = ""
                txtCompartment.Text = ""
            End If
        End If
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub

    Sub calTime()
        Dim ss0, ss1, ss
        Dim mm0, mm1, mm
        Dim hh0, hh1, hh
        Dim strTimeStop = txtStopT.Text.Split(":")
        hh1 = strTimeStop(0)
        mm1 = strTimeStop(1)
        ss1 = strTimeStop(2)

        Dim strTimeStart = txtStartT.Text.Split(":")
        hh0 = strTimeStart(0)
        mm0 = strTimeStart(1)
        ss0 = strTimeStart(2)

        ss1 = ss1 - ss0
        If ss1 < 0 Then

            mm1 = mm1 - 1
            ss1 = ss1 + 60
        End If

        mm1 = mm1 - mm0
        If mm1 < 0 Then

            hh1 = hh1 - 1
            mm1 = mm1 + 60
        End If
        hh1 = hh1 - hh0

        If hh1 < 10 Then
            hh = "0" & hh1
        Else
            hh = hh1
        End If
        If mm1 < 10 Then
            mm = "0" & hh1
        Else
            mm = mm1
        End If
        If ss1 < 10 Then
            ss = "0" & hh1
        Else
            ss = ss1
        End If

        txtTotLoad.Text = hh & ":" & mm & ":" & ss

    End Sub

    Private Sub InitialSQLQueury()
        Dim strSQL As String, i As Integer
        strSQL = "select B.BAY_NO, B.BAY_ACTIVE,B.BAY_NAME "
        strSQL = strSQL & "from view_bay_mmi_loading B where B.BAY_NO > " & mBayName & " "
        strSQL = strSQL & "order by B.BAY_NO"
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                For i = 0 To lblBayNo.Length - 1
                    lblBayNo(i) = IIf(IsDBNull(dt.Rows(0).Item("BAY_NAME")), "- -", dt.Rows(0).Item("BAY_NAME").ToString)
                Next
            End If
        End If
        mDataSet = Nothing

    End Sub

    Private Sub InitialDataLines(ByVal bayNo As String)
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim pColor As String
        Try
            'For i = i + 1 To 10
            '    UcProgress(i).Visible = False
            'Next i

            strSQL = "select L.COMPARTMENT_NO,L.SALE_PRODUCT_ID,L.SALE_PRODUCT_NAME,L.ADVICE,L.PRESET,L.LOADED_GROSS,L.UNIT, "
            strSQL = strSQL & "L.TEMP,L.API60F,L.BATCH_STATUS,S.DESCRIPTION,L.METER_NAME,L.SHIPMENT_REF,L.TU_ID,L.COMPAMENT_CAPACITY,L.LOAD_HEADER_NO, "
            strSQL = strSQL & "L.TOT_GROSS_START,L.TOT_GROSS_STOP,L.T_START,L.T_STOP,L.METER_NO,L.VALUE_TOPUP,V.BASE_PRODUCT_ID,L.BATCH_STATUS,L.desity15c  "
            strSQL = strSQL & "from OIL_TEMP_LOAD_LINES L,STATUS_DESC S,SALE_PRODUCT V "
            strSQL = strSQL & "where L.BATCH_STATUS=S.STATUS_NUMBER and V.SALE_PRODUCT_ID=L.SALE_PRODUCT_ID "
            strSQL = strSQL & "and ((S.T_NAME='OIL_LOAD_LINES' and S.COLUMNS_NAME='BATCH_STATUS') or S.T_NAME is null) "
            strSQL = strSQL & "and L.CANCEL_STATUS=0 "
            strSQL = strSQL & "and L.LOAD_HEADER_NO="
            strSQL = strSQL & "(select H.LOAD_HEADER_NO from OIL_TEMP_LOAD_HEADERS H "
            strSQL = strSQL & "where H.LOAD_STATUS in (51,52,53,54,55) "
            strSQL = strSQL & "and H.CANCEL_STATUS=0 "
            strSQL = strSQL & "and H.LOAD_HEADER_NO="
            strSQL = strSQL & "(select B.LAST_LOAD_NO from BAY B "
            strSQL = strSQL & "where b.BAY_ACTIVE=1 "
            strSQL = strSQL & "and B.BAY_No='" & bayNo & "')) Order by L.COMPARTMENT_NO"
            If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                i = 0
                DataGridLoading.RowCount = 0
                UcTruck1.ucTruckTotalCompartment = dt.Rows.Count
                If dt.Rows.Count > 0 Then
                    txtCompartment.Text = dt.Rows.Count
                End If
                Do While dt.Rows.Count > i
                    DataGridLoading.RowCount = DataGridLoading.RowCount + 1
                    DataGridLoading.Rows.Item(i).Height = Grid_Height
                    DataGridLoading.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("COMPARTMENT_NO")), "", dt.Rows(i).Item("COMPARTMENT_NO").ToString)
                    DataGridLoading.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("BASE_PRODUCT_ID")), "", dt.Rows(i).Item("BASE_PRODUCT_ID").ToString)
                    DataGridLoading.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("METER_NO")), "", dt.Rows(i).Item("METER_NO").ToString)
                    DataGridLoading.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PRESET")), "", dt.Rows(i).Item("PRESET").ToString)
                    DataGridLoading.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("VALUE_TOPUP")), "", dt.Rows(i).Item("VALUE_TOPUP").ToString)
                    DataGridLoading.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOADED_GROSS")), "", dt.Rows(i).Item("LOADED_GROSS").ToString)
                    DataGridLoading.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UNIT")), "", dt.Rows(i).Item("UNIT").ToString)
                    DataGridLoading.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TEMP")), "", dt.Rows(i).Item("TEMP").ToString)
                    DataGridLoading.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("desity15c")), "", dt.Rows(i).Item("desity15c").ToString())
                    DataGridLoading.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION").ToString)
                    DataGridLoading.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT_NAME")), "", dt.Rows(i).Item("SALE_PRODUCT_NAME").ToString)
                    DataGridLoading.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("BATCH_STATUS")), "", dt.Rows(i).Item("BATCH_STATUS").ToString)
                    Dim capacity = CType(IIf(IsDBNull(dt.Rows(i).Item("COMPAMENT_CAPACITY")), "0", dt.Rows(i).Item("COMPAMENT_CAPACITY").ToString), Integer)
                    Dim advice = CType(IIf(IsDBNull(dt.Rows(i).Item("ADVICE")), "0", dt.Rows(i).Item("ADVICE").ToString), Integer)
                    Dim loadedGross = CType(IIf(IsDBNull(dt.Rows(i).Item("LOADED_GROSS")), "0", dt.Rows(i).Item("LOADED_GROSS").ToString), Integer)
                    UcTruck1.SetCompartmentCapacity(i + 1, capacity)
                    UcTruck1.SetCompartmentAdvice(i + 1, advice)
                    UcTruck1.SetCompartmentValue(i + 1, loadedGross)
                    pColor = SetProgressColor(dt.Rows(i).Item("BASE_PRODUCT_ID").ToString)
                    If Not pColor.Equals("") Then
                        UcTruck1.SetCompartmentColor(i + 1, Convert.ToDouble(pColor))
                    End If
                    i = i + 1
                    'UcProgress(i).updateProgrssOil(capacity, advice, loadedGross)
                    'UcProgress(i).Visible = True
                    'tempI = i
                Loop

                If i = 0 Then
                    'CmdTruckDlide.Visible = False
                    lblStatus.Visible = False
                    PanelShow.Visible = False
                Else

                    'CmdTruckDlide.Visible = True
                    lblStatus.Visible = True
                    PanelShow.Visible = True
                    'PanelPicTruck.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\TRUCK-01.png")
                    'PanelPicTruck.BackgroundImageLayout = ImageLayout.Stretch
                    If Not (lblTruckTran.Text = "") Then
                        lblStatus.Text = "หัวรถพ่วง"
                    Else
                        lblStatus.Text = "หัวรถเดี่ยว"
                    End If
                    'txtCompartment.Text = tempI & " ช่องเติม"
                End If
                'Dim n
                'For n = 0 + 1 To i
                '    UcProgress(n).Visible = True
                'Next n
                'For i = i + 1 To 10
                '    UcProgress(i).Visible = False
                'Next i
            Else
            End If
            'mDataSet = Nothing

        Catch ex As Exception

        End Try
        'If lblTruckTran.Text = "" Then
        '    CmdTruckDlide.Visible = False
        'Else
        '    CmdTruckDlide.Visible = True
        'End If
        'txtCompartment.Text = tempI & " ช่องเติม"
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub
    Function SetProgressColor(ProductID As String) As String
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        SetProgressColor = ""
        'If ProductID = "" Then
        '    Progress.SetColorProgress &H0
        'Else
        strSQL =
             "select S.COLOR_CODE " &
            "from base_product S,view_sale_base_product P " &
            "where S.BASE_PRODUCT_ID=P.BASE_PRODUCT_ID " &
            " and P.BASE_PRODUCT_ID='" & ProductID & "'"
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                SetProgressColor = dt.Rows(0).Item("COLOR_CODE").ToString
            End If

        End If

        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Function
    Private Sub RunningMeters()
        Dim strSQL As String, strSQLL As String, strSQLLL As String
        Dim mDataSet As New DataSet
        Dim dtAccu As DataTable, dtMeter As DataTable
        Dim strDataMeter As String
        strDataMeter = Meter_Name
        If strDataMeter = "" Then
            GoTo ExitFunc
        End If
        strSQL =
               "select  * " &
               " from steqi.accuload_value a" &
               " Where A.METER_NO ='" & strDataMeter & "' " &
               " Order by A.METER_NO "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet, False) Then
            dtAccu = mDataSet.Tables(0)
            If dtAccu.Rows.Count = 0 Then
                GoTo ExitFunc
            End If
            strSQLL =
                      "select t.meter_no,t.base_product_id,t.* " &
                      "  from meter t" &
                      " where t.meter_no='" & strDataMeter & "'"
            If Not Oradb.OpenDys(strSQLL, "TableName1", mDataSet) Then
                GoTo ExitFunc
            End If
            dtMeter = mDataSet.Tables(0)
            If IsDBNull(dtAccu.Rows(0).Item("GROSS_DELIVERY")) = True Then
                GoTo ExitFunc
            Else
                Gross = CLng(dtAccu.Rows(0).Item("GROSS_DELIVERY"))
            End If

            lblMeterPreset.Text = IIf(IsDBNull(dtAccu.Rows(0).Item("current_preset")), "", dtAccu.Rows(0).Item("current_preset"))
            lblMeterLoaded.Text = Gross
            lblMeterName.Text = dtAccu.Rows(0).Item("Meter_no") & " : " '& OraProduct!base_product_id
            lblFlowRate.Text = IIf(IsDBNull(dtAccu.Rows(0).Item("CURRENT_FLOWRATE")), "", dtAccu.Rows(0).Item("CURRENT_FLOWRATE"))
            lblMeterTOT.Text = IIf(IsDBNull(dtAccu.Rows(0).Item("gross_totalizer")), "", dtAccu.Rows(0).Item("gross_totalizer"))
            lblMeterName.Text = lblMeterName.Text & dtMeter.Rows(0).Item("base_product_id")
            CmdEnable.Text = IIf(IsDBNull(dtMeter.Rows(0).Item("IS_ENABLED")), "", IIf((dtMeter.Rows(0).Item("IS_ENABLED") = 1), "Enable Meter", "Disable Meter"))
            CmdEnable.BackColor = IIf(IsDBNull(dtMeter.Rows(0).Item("IS_ENABLED")), "", IIf((dtMeter.Rows(0).Item("IS_ENABLED") = 1), Color.FromArgb(76, 175, 80), Color.Red))
            CmdLock.Text = IIf(IsDBNull(dtMeter.Rows(0).Item("IS_LOCKED")), "", IIf((dtMeter.Rows(0).Item("IS_LOCKED") = 1), "Lock Meter", "Unlock Meter"))
            CmdLock.BackColor = IIf(IsDBNull(dtMeter.Rows(0).Item("IS_LOCKED")), "", IIf((dtMeter.Rows(0).Item("IS_LOCKED") = 1), Color.Red, Color.FromArgb(76, 175, 80)))
            CmdLoad.Text = IIf(IsDBNull(dtMeter.Rows(0).Item("TOP_UP_ACTIVE")), "", IIf((dtMeter.Rows(0).Item("TOP_UP_ACTIVE") = 1), "Topup", "Loading"))
            CmdLoad.BackColor = IIf(IsDBNull(dtMeter.Rows(0).Item("TOP_UP_ACTIVE")), "", IIf((dtMeter.Rows(0).Item("TOP_UP_ACTIVE") = 1), Color.Red, Color.FromArgb(76, 175, 80)))

            strSQL =
                  "select t.meter_no,t.enquire_no,t.status" &
                  " from steqi.accuload_enquire_status t " &
                  " where t.meter_no='" & strDataMeter & "'" &
                  " and t.enquire_no=9"

            If Not Oradb.OpenDys(strSQL, "TableName3", mDataSet) Then
                GoTo ExitFunc
            End If
            dtMeter = mDataSet.Tables("TableName3")
            If dtMeter.Rows(0).Item("Status") = 1 Then
                If Not lblMeterAlarm.Visible Then lblMeterAlarm.Visible = True
                If Not picMeterAlarm.Visible Then picMeterAlarm.Visible = True
            Else
                If lblMeterAlarm.Visible Then
                    lblMeterAlarm.Visible = False
                    picMeterAlarm.Visible = False
                End If
            End If

            'Call AlarmType()
        End If
        dtAccu = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
ExitFunc:

        mDataSet = Nothing
        dtAccu = Nothing
        dtMeter = Nothing


    End Sub

    Private Sub RunningScanMeter(ByVal bayNo As Integer)
        Static i As Integer

        Dim strSQL As String
        Dim cond As String = String.Empty
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        Try

            If bayNo.Equals(1) Or bayNo.Equals(3) Or bayNo.Equals(5) Then
                DataGridAlarm.Visible = True
                DataGridAlarmB.Visible = False
            ElseIf bayNo.Equals(2) Or bayNo.Equals(4) Then
                DataGridAlarm.Visible = False
                DataGridAlarmB.Visible = True


            End If

            Dim Islano As String = String.Empty
            If TempBay <> bayNo Then
                TempBay = bayNo
            Else
                'GoTo Err_Func
            End If
            'If bayNo < 3 Then
            '    Islano = 1
            'Else
            '    Islano = 2
            'End If
            '*****************Edit Kritsadee Select Island No. 16/03/21***************
            strSQL = String.Format("select B.ISLAND_NO from BAY B where B.BAY_NO= {0} AND ROWNUM =1", bayNo)
            dt = Oradb.Query_TBL(strSQL)
            If (dt.Rows.Count > 0) Then
                Islano = dt.Rows(0).Item("ISLAND_NO").ToString()
            End If
            '*************************************************************************

            '***********check bay = 5
            If (bayNo.Equals(5)) Then
                strSQL = String.Format("select * from tas.view_mmi_bay_meter t Where t.meter_no = {0}  order by t.meter_no ", 12)
            Else
                strSQL = String.Format("select * from tas.view_mmi_bay_meter t Where t.ISLAND_NO = {0} {1}  order by t.meter_no ", Islano, cond)
            End If


            If Oradb.OpenDys(strSQL, "TableName1", mDataSet, False) Then
                dt = mDataSet.Tables("TableName1")
                If dt.Rows.Count = 0 Then
                    DataGridMeter.Rows.Clear()
                    DataGridAlarm.Rows.Clear()
                    DataGridAlarmB.Rows.Clear()
                End If

                With DataGridMeter
                    'If i <= 0 Then
                    '    .Rows.Add(Rectot)
                    'End If
                    For i = 0 To dt.Rows.Count - 1
                        Gross = CLng(Val(dt.Rows(i)("GROSS_DELIVERY")))
                        .Item(0, i).Value = IIf(IsDBNull(dt.Rows(i)("METER_NO")), "", dt.Rows(i)("METER_NO"))
                        .Item(1, i).Value = IIf(IsDBNull(dt.Rows(i)("METER_GROUP")), "", dt.Rows(i)("METER_GROUP"))
                        .Item(2, i).Value = IIf(IsDBNull(dt.Rows(i)("base_product_id")), "", dt.Rows(i)("base_product_id"))
                        If dt.Rows(i)("ALARM_ON") = 1 Then
                            '.Row = i + 1 : .col = 3
                            .Item(3, i).Style.BackColor = Color.Red
                        Else
                            .Item(3, i).Style.BackColor = Color.White
                        End If

                        'If IsDBNull(dt.Rows(i).Item("color_code")) Then
                        '    '.Row = i + 1 : .col = 4
                        '    '.CellBackColor = 0 : .CellForeColor = &HFFFFFF
                        '    .Item(4, i).Style.BackColor = System.Drawing.Color.FromArgb(0 Or &HFF000000)
                        '    .Item(4, i).Style.ForeColor = System.Drawing.Color.FromArgb(&HFFFFFF Or &HFF000000)

                        '    .Text = Hex(.Item(4, i).Style.BackColor)
                        'Else
                        '    '.Row = i + 1 : .col = 4
                        '    .Item(4, i).Style.BackColor = System.Drawing.Color.FromArgb(CInt(dt.Rows(i).Item("color_code")))
                        '    .Item(4, i).Style.ForeColor = System.Drawing.Color.FromArgb(&HFFFFFF - dt.Rows(i).Item("color_code"))
                        '    .Item(4, i).Value = Hex(.Item(4, i).Style.BackColor.ToArgb)
                        'End If
                        .Item(5, i).Value = IIf(IsDBNull(dt.Rows(i)("STEP_PROCESS")), "", dt.Rows(i)("STEP_PROCESS"))
                        .Item(6, i).Value = IIf(IsDBNull(dt.Rows(i)("CURRENT_FLOWRATE")), "", dt.Rows(i)("CURRENT_FLOWRATE"))
                        .Item(7, i).Value = IIf(IsDBNull(dt.Rows(i)("CURRENT_PRESET")), "", dt.Rows(i)("CURRENT_PRESET"))
                        .Item(8, i).Value = IIf(IsDBNull(dt.Rows(i)("fv_control")), "", dt.Rows(i)("fv_control"))
                        .Item(9, i).Value = CLng(Val(dt.Rows(i)("GROSS_DELIVERY")))
                        .Item(10, i).Value = IIf(IsDBNull(dt.Rows(i)("NET_15C_DELIVERY")), "", dt.Rows(i)("NET_15C_DELIVERY"))
                        .Item(11, i).Value = IIf(IsDBNull(dt.Rows(i)("NET_30C_DELIVERY")), "", dt.Rows(i)("NET_30C_DELIVERY"))
                        .Item(12, i).Value = IIf(IsDBNull(dt.Rows(i)("CURRENT_TEMPERTURE")), "", dt.Rows(i)("CURRENT_TEMPERTURE"))
                        .Item(13, i).Value = IIf(IsDBNull(dt.Rows(i)("mass_air_delivery")), "", dt.Rows(i)("mass_air_delivery"))
                        .Item(14, i).Value = IIf(IsDBNull(dt.Rows(i)("mass_vac_delivery")), "", dt.Rows(i)("mass_vac_delivery"))
                        .Item(15, i).Value = IIf(IsDBNull(dt.Rows(i)("ENQUIRE_STATUS")), "", dt.Rows(i)("ENQUIRE_STATUS"))
                        .Item(16, i).Value = IIf(IsDBNull(dt.Rows(i)("gross_totalizer")), "", dt.Rows(i)("gross_totalizer"))
                        .Item(17, i).Value = IIf(IsDBNull(dt.Rows(i)("net_15c_totalizer")), "", dt.Rows(i)("net_15c_totalizer"))
                        .Item(18, i).Value = IIf(IsDBNull(dt.Rows(i)("mass_totalizer")), "", dt.Rows(i)("mass_totalizer"))
                        .Item(19, i).Value = IIf(IsDBNull(dt.Rows(i)("MODE_ACTIVE")), "", dt.Rows(i)("MODE_ACTIVE"))
                        'dt.Rows(i).MoveNext()
                    Next
                End With
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, CStr(MsgBoxStyle.Critical))
            dt = Nothing
            mDataSet.Dispose()
            mDataSet = Nothing
        End Try
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing

    End Sub

    Private Sub RunningScanDataLines()
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        Dim vMeter As String
        strSQL = "select L.COMPARTMENT_NO,L.SALE_PRODUCT_ID,L.SALE_PRODUCT_NAME,L.ADVICE,L.PRESET,L.LOADED_GROSS,L.UNIT, "
        strSQL = strSQL & "L.TEMP,L.API60F,L.BATCH_STATUS,S.DESCRIPTION,L.METER_NAME,L.SHIPMENT_REF,L.TU_ID,L.COMPAMENT_CAPACITY,L.LOAD_HEADER_NO, "
        strSQL = strSQL & "L.TOT_GROSS_START,L.TOT_GROSS_STOP,L.T_START,L.T_STOP,L.METER_NO,L.VALUE_TOPUP,V.BASE_PRODUCT_ID,L.BATCH_STATUS,L.desity15c  "
        strSQL = strSQL & "from OIL_TEMP_LOAD_LINES L,STATUS_DESC S,SALE_PRODUCT V "
        strSQL = strSQL & "where L.BATCH_STATUS=S.STATUS_NUMBER and V.SALE_PRODUCT_ID=L.SALE_PRODUCT_ID "
        strSQL = strSQL & "and ((S.T_NAME='OIL_LOAD_LINES' and S.COLUMNS_NAME='BATCH_STATUS') or S.T_NAME is null) "
        strSQL = strSQL & "and L.CANCEL_STATUS=0 "
        strSQL = strSQL & "and L.LOAD_HEADER_NO="
        strSQL = strSQL & "(select H.LOAD_HEADER_NO from OIL_TEMP_LOAD_HEADERS H "
        strSQL = strSQL & "where H.LOAD_STATUS in (51,52,53,54,55) "
        strSQL = strSQL & "and H.CANCEL_STATUS=0 "
        strSQL = strSQL & "and H.LOAD_HEADER_NO="
        strSQL = strSQL & "(select B.LAST_LOAD_NO from BAY B "
        strSQL = strSQL & "where b.BAY_ACTIVE=1 "
        strSQL = strSQL & "and B.BAY_No='" & mBayNo & "')) Order by L.COMPARTMENT_NO"
        If Not Oradb.OpenDys(strSQL, "TableName1", mDataSet, False) Then
            GoTo Err_Func
        End If
        dt = mDataSet.Tables("TableName1")
        Try
            With DataGridLoading
                '.Visible = False
                '.Rows = Rectot + 1

                If dt.Rows.Count = 0 Then
                    .Rows.Clear()
                    If PanelShow.Visible Then
                        PanelShow.Visible = False
                        InitialDataLines(mBayNo)
                    End If
                Else
                    If Not PanelShow.Visible Then
                        PanelShow.Visible = False
                        InitialDataLines(mBayNo)
                    End If
                End If
                For i = 0 To dt.Rows.Count - 1
                    .Item(0, i).Value = IIf(IsDBNull(dt.Rows(i)("COMPARTMENT_NO")), "", dt.Rows(i)("COMPARTMENT_NO"))
                    .Item(1, i).Value = IIf(IsDBNull(dt.Rows(i)("BASE_PRODUCT_ID")), "", dt.Rows(i)("BASE_PRODUCT_ID"))
                    .Item(2, i).Value = IIf(IsDBNull(dt.Rows(i)("METER_NO")), "", dt.Rows(i)("METER_NO"))
                    .Item(3, i).Value = IIf(IsDBNull(dt.Rows(i)("PRESET")), "", Format(dt.Rows(i)("PRESET"), "###,##0"))
                    .Item(4, i).Value = IIf(IsDBNull(dt.Rows(i)("VALUE_TOPUP")), "", dt.Rows(i)("VALUE_TOPUP"))
                    .Item(5, i).Value = IIf(IsDBNull(dt.Rows(i)("LOADED_GROSS")), "", Format(dt.Rows(i)("LOADED_GROSS"), "###,##0.0"))
                    .Item(6, i).Value = IIf(IsDBNull(dt.Rows(i)("UNIT")), "", dt.Rows(i)("UNIT"))
                    .Item(7, i).Value = IIf(IsDBNull(dt.Rows(i)("TEMP")), "", Format(dt.Rows(i)("TEMP"), "#,##0.00"))
                    .Item(8, i).Value = IIf(IsDBNull(dt.Rows(i)("desity15c")), "", Format(dt.Rows(i)("desity15c"), "#,##0.0000"))
                    .Item(9, i).Value = IIf(IsDBNull(dt.Rows(i)("DESCRIPTION")), "", dt.Rows(i)("DESCRIPTION"))
                    .Item(10, i).Value = IIf(IsDBNull(dt.Rows(i)("SALE_PRODUCT_NAME")), "", dt.Rows(i)("SALE_PRODUCT_NAME"))
                    .Item(.ColumnCount - 1, i).Value = IIf(IsDBNull(dt.Rows(i)("BATCH_STATUS")), "", dt.Rows(i)("BATCH_STATUS"))

                    Dim capacity = CType(IIf(IsDBNull(dt.Rows(i).Item("COMPAMENT_CAPACITY")), "0", dt.Rows(i).Item("COMPAMENT_CAPACITY").ToString), Integer)
                    Dim advice = CType(IIf(IsDBNull(dt.Rows(i).Item("ADVICE")), "0", dt.Rows(i).Item("ADVICE").ToString), Integer)
                    Dim loadedGross = CType(IIf(IsDBNull(dt.Rows(i).Item("LOADED_GROSS")), "0", dt.Rows(i).Item("LOADED_GROSS").ToString), Integer)
                    UcTruck1.SetCompartmentValue(i + 1, loadedGross)
                    'UcProgress(i + 1).updateProgrssOil(capacity, advice, loadedGross)
                Next
                '.Visible = True

            End With
        Catch ex As Exception
            mDataSet = Nothing
            dt = Nothing
        End Try
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
        'Exit Sub
Err_Func:
        mDataSet = Nothing
        dt = Nothing
    End Sub

    Private Sub RunningScanDataHeaders()
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        strSQL =
            "select H.* " &
            " from OIL_TEMP_LOAD_HEADERS H " &
            "where H.LOAD_STATUS in (51,52,53,54,55) " &
                "and H.CANCEL_STATUS=0 " &
                "and H.LOAD_HEADER_NO= (select B.LAST_LOAD_NO  from BAY B where B.BAY_ACTIVE = 1 and B.BAY_NAME='" & mBayName & "') "

        If Not Oradb.OpenDys(strSQL, "TableName1", mDataSet, False) Then
            GoTo Err_Func
        End If
        dt = mDataSet.Tables(0)
        If dt.Rows.Count > 0 Then
            btClear.Text = IIf(IsDBNull(dt.Rows(i)("TU_CARD_NO")), "", dt.Rows(i)("TU_CARD_NO"))
            lblCardTran.Text = IIf(IsDBNull(dt.Rows(i)("TU_CARD_NO1")), "", dt.Rows(i)("TU_CARD_NO1"))
            lblTruckName.Text = IIf(IsDBNull(dt.Rows(i)("TU_ID")), "", dt.Rows(i)("TU_ID"))
            lblTruckTran.Text = IIf(IsDBNull(dt.Rows(i)("TU_ID1")), "", dt.Rows(i)("TU_ID1"))
            lblDriverName.Text = IIf(IsDBNull(dt.Rows(i)("DRIVER_NAME")), "", dt.Rows(i)("DRIVER_NAME"))
            lblDriverID.Text = IIf(IsDBNull(dt.Rows(i)("DRIVER_CODE")), "", dt.Rows(i)("DRIVER_CODE"))
            lblloadNo.Text = IIf(IsDBNull(dt.Rows(i)("LOAD_HEADER_NO")), "", dt.Rows(i)("LOAD_HEADER_NO"))
            lblShipment.Text = IIf(IsDBNull(dt.Rows(i)("SHIPMENT_NO")), "", dt.Rows(i)("SHIPMENT_NO"))
            lblVehicle.Text = IIf(IsDBNull(dt.Rows(i)("Vehicle_Number")), "", dt.Rows(i)("Vehicle_Number"))
            lblVehicleMapType.Text = IIf(IsDBNull(dt.Rows(i)("VEHICLE_MAP_TYPE")), "", dt.Rows(i)("VEHICLE_MAP_TYPE"))
            lblCarrierName.Text = IIf(IsDBNull(dt.Rows(i)("CARRIER_NAME")), "", dt.Rows(i)("CARRIER_NAME"))
            CmdLoadLocked.Text = IIf(IsDBNull(dt.Rows(i)("loading_locked")), "", IIf((dt.Rows(i)("loading_locked") = 1), "Lock การจ่าย", "Unlock การจ่าย"))
            CmdLoadLocked.BackColor = IIf(IsDBNull(dt.Rows(i)("loading_locked")), "", IIf((dt.Rows(i)("loading_locked") = 1), Color.Red, Color.Green))
        Else
            lblCarrierName.Text = ""
            btClear.Text = ""
            lblCardTran.Text = ""
            lblTruckName.Text = ""
            lblTruckTran.Text = ""
            lblDriverName.Text = ""
            lblDriverID.Text = ""
            lblloadNo.Text = ""
            lblShipment.Text = ""
            lblVehicle.Text = ""
            lblVehicleMapType.Text = ""
            CmdLoadLocked.Text = ""
        End If
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
Err_Func:
        mDataSet = Nothing
        dt = Nothing
    End Sub

    Private Sub AlarmType()

        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer

        '*****************check Bayno = 5 เนื่องจากระบบ โปรเจคเพิ่ม Bay ใหม่ 500N ใช้ Meter ตัวเดิม*************
        If (mBayNo = 5) Then
            lblSide.Text = "Side C"

            strSQL = "select  T.METER_NO,T.PERMISSIVE_ID,T.PERMISSIVE_NAME,T.STATUS"
            strSQL = strSQL & " from steqi.view_config_permissive_c t"
            strSQL = strSQL & " where T.METER_NO= '" & Meter_Name & "'  order by  t.PERMISSIVE_ID "
        Else
            lblSide.Text = "Side A"
            strSQL = "select  T.METER_NO,T.PERMISSIVE_ID,T.PERMISSIVE_NAME,T.STATUS"
            strSQL = strSQL & " from steqi.view_config_permissive_a t"
            strSQL = strSQL & " where T.METER_NO= '" & Meter_Name & "'  order by  t.PERMISSIVE_ID "
        End If


        If Oradb.OpenDys(strSQL, "TableName1", mDataSet, False) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            j = 0
            k = 0
            DataGridAlarm.RowCount = 0
            Do While dt.Rows.Count > i
                DataGridAlarm.RowCount = DataGridAlarm.RowCount + 1
                DataGridAlarm.Rows.Item(i).Height = Grid_Height
                DataGridAlarm.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PERMISSIVE_ID")), "", dt.Rows(i).Item("PERMISSIVE_ID").ToString)
                DataGridAlarm.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PERMISSIVE_NAME")), "", dt.Rows(i).Item("PERMISSIVE_NAME").ToString)
                Dim z As Integer
                If IIf(IsDBNull(dt.Rows(i).Item("STATUS")), "0", dt.Rows(i).Item("STATUS").ToString) = "0" Then
                    j = j + 1
                    'lbl_DO_No_Use.Text = j

                    For z = 0 To DataGridAlarm.Columns.Count - 1
                        DataGridAlarm.Rows(i).Cells(z).Style.ForeColor = Color.Red 'Red

                    Next
                Else
                    k = k + 1
                    'lbl_DO_Use.Text = k

                    For z = 0 To DataGridAlarm.Columns.Count - 1
                        DataGridAlarm.Rows(i).Cells(z).Style.ForeColor = Color.Lime 'Green
                    Next
                End If
                i = i + 1
            Loop
        Else
            DataGridAlarm.RowCount = 1

        End If
        mDataSet = Nothing


        strSQL = "select  T.METER_NO,T.PERMISSIVE_ID,T.PERMISSIVE_NAME,T.STATUS "
        strSQL = strSQL & " from steqi.view_config_permissive_b t"
        strSQL = strSQL & " where T.METER_NO= '" & Meter_Name & "'  order by  t.PERMISSIVE_ID "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            j = 0
            k = 0
            DataGridAlarmB.RowCount = 0
            Do While dt.Rows.Count > i
                DataGridAlarmB.RowCount = DataGridAlarmB.RowCount + 1
                DataGridAlarmB.Rows.Item(i).Height = Grid_Height
                DataGridAlarmB.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PERMISSIVE_ID")), "", dt.Rows(i).Item("PERMISSIVE_ID").ToString)
                DataGridAlarmB.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PERMISSIVE_NAME")), "", dt.Rows(i).Item("PERMISSIVE_NAME").ToString)

                If IIf(IsDBNull(dt.Rows(i).Item("STATUS")), "0", dt.Rows(i).Item("STATUS").ToString) = "0" Then
                    j = j + 1
                    'lbl_DO_No_Use.Text = j

                    For z = 0 To DataGridAlarmB.Columns.Count - 1
                        DataGridAlarmB.Rows(i).Cells(z).Style.ForeColor = Color.Red
                    Next
                Else
                    k = k + 1
                    'lbl_DO_Use.Text = k

                    For z = 0 To DataGridAlarmB.Columns.Count - 1
                        DataGridAlarmB.Rows(i).Cells(z).Style.ForeColor = Color.Lime
                    Next
                End If
                i = i + 1
            Loop
        Else
            DataGridAlarmB.RowCount = 1
        End If
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub
    'Public Sub ShowData(ByVal MeterNo As Integer)
    '    Dim strSQL As String
    '    Dim i As Integer
    '    Dim mDataSet As New DataSet
    '    Dim dt As DataTable
    '    mDataSet = Nothing
    '    'MessageBox.Show("--->" + vMeter(Index))
    '    strSQL = _
    '              " select " & _
    '              "  t.ARM_SIDE_A,t.ARM_SIDE_B ,t.ARM_LEFT_ACTIVE,t.ARM_RIGHT_ACTIVE" & _
    '              " ,t.PRESSURE_DIFF_ALARM,t.TEMP_1_ALARM,t.TEMP_NAME1,t.TEMPERATURE1,t.FV_CONTROL ,t.FLOW_ACTIVE,t.ARM_DOWN_A,t.ARM_DOWN_B,t.EARTH_A,t.EARTH_B,t.OVERSFILL_A,t.OVERSFILL_B,t.ESD ,t.PREMISSIVE_A,t.PREMISSIVE_B  " & _
    '              " ,t.BALL_VALVE_A,t.BALL_VALVE_B " & _
    '              " from  steqi.view_mmi_processflow_meter t " & _
    '              " where  t.meter_no ='" & Trim(MeterNo) & "'"

    '    If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
    '        i = 0
    '        dt = mDataSet.Tables("TableName1")
    '        If dt.Rows.Count > 0 Then
    '            DataGridAlarmB.RowCount = 0
    '            Do While dt.Rows.Count > i
    '                DataGridView1.RowCount = DataGridAlarmB.RowCount + 1
    '                DataGridView1.Rows.Item(i).Height = Grid_Height
    '                DataGridView1.Item(0, 0).Value = 1
    '                DataGridView1.Item(1, 0).Value = IIf(IsDBNull(dt.Rows(i).Item("ARM_SIDE_A")), "", dt.Rows(i).Item("PERMISSIVE_ID").ToString)
    '                DataGridView1.Item(1, 1).Value = IIf(IsDBNull(dt.Rows(i).Item("BALL_VALVE_A")), "", dt.Rows(i).Item("BALL_VALVE_A")).ToString
    '                DataGridView1.Item(1, 2).Value = IIf(IsDBNull(dt.Rows(i).Item("ARM_DOWN_A")), "", dt.Rows(i).Item("ARM_DOWN_A")).ToString
    '                DataGridView1.Item(1, 3).Value = IIf(IsDBNull(dt.Rows(i).Item("EARTH_A")), "", dt.Rows(i).Item("EARTH_A")).ToString
    '                DataGridView1.Item(1, 4).Value = IIf(IsDBNull(dt.Rows(i).Item("OVERSFILL_A")), "", dt.Rows(i).Item("OVERSFILL_A")).ToString
    '                DataGridView1.Item(1, 5).Value = IIf(IsDBNull(dt.Rows(i).Item("PREMISSIVE_A")), "", dt.Rows(i).Item("PREMISSIVE_A")).ToString

    '                'Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("ARM_SIDE_B")), 0, dt.Rows(i).Item("ARM_SIDE_B")), txt(1 + 7))
    '                'Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("BALL_VALVE_B")), 0, dt.Rows(i).Item("BALL_VALVE_B")), txt(1 + 8))
    '                'Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("ARM_DOWN_B")), 0, dt.Rows(i).Item("ARM_DOWN_B")), txt(1 + 9))
    '                'Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("EARTH_B")), 0, dt.Rows(i).Item("EARTH_B")), txt(1 + 10))
    '                'Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("OVERSFILL_B")), 0, dt.Rows(i).Item("OVERSFILL_B")), txt(1 + 11))
    '                'Call SaftGarudingAc(IIf(IsDBNull(dt.Rows(i).Item("PREMISSIVE_B")), 0, dt.Rows(i).Item("PREMISSIVE_B")), txt(1 + 12))
    '                i = i + 1
    '            Loop
    '        End If
    '    End If
    '    mDataSet = Nothing

    'End Sub
    Private Sub InitialMeter(ByVal bayNo As Integer)
        Dim Islano As String
        Dim vMeter As String

        If TempBay <> bayNo Then
            TempBay = bayNo
        Else
            Exit Sub
        End If



        'If bayNo < 3 Then
        '    Islano = 1
        'Else
        '    Islano = 2
        'End If

        Dim strSQL As String
        Dim cond As String = String.Empty
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        strSQL = "select B.ISLAND_NO from BAY B where B.BAY_NO= @P1 AND ROWNUM =1"
        strSQL = strSQL.Replace("@P1", bayNo)

        dt = Oradb.Query_TBL(strSQL)
        If (dt.Rows.Count > 0) Then
            Islano = CType(dt.Rows(0).Item("ISLAND_NO"), String)
        End If

        '***********check bay = 5********************************************
        If (bayNo.Equals(5)) Then
            strSQL = String.Format("select * from tas.view_mmi_bay_meter t Where t.meter_no = {0}  order by t.meter_no ", 12)
        Else
            strSQL = String.Format("select * from tas.view_mmi_bay_meter t Where t.ISLAND_NO = {0} {1}  order by t.meter_no ", Islano, cond)
        End If

        '*******************************************************************
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridMeter.Rows.Clear()
            DataGridMeter.RowCount = 0
            Do While dt.Rows.Count > i
                DataGridMeter.RowCount = DataGridMeter.RowCount + 1
                DataGridMeter.Rows.Item(i).Height = Grid_Height
                DataGridMeter.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("METER_NO")), "", dt.Rows(i).Item("METER_NO").ToString)
                DataGridMeter.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("METER_GROUP")), "", dt.Rows(i).Item("METER_GROUP").ToString)
                DataGridMeter.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("base_product_id")), "", dt.Rows(i).Item("base_product_id").ToString)
                If IIf(IsDBNull(dt.Rows(i).Item("ALARM_ON")), "", dt.Rows(i).Item("ALARM_ON").ToString) = "1" Then
                    DataGridMeter.Item(3, i).Style.BackColor = Color.Red
                End If
                Dim colour As String
                colour = dt.Rows(i).Item("COLOR_CODE").ToString()
                DataGridMeter.Item(4, i).Value = appendZero(Hex(colour).ToString())
                DataGridMeter.Item(4, i).Style.BackColor = ColorTranslator.FromHtml("#" + appendZero(Hex(colour).ToString()))
                DataGridMeter.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("STEP_PROCESS")), "", dt.Rows(i).Item("STEP_PROCESS").ToString)
                DataGridMeter.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CURRENT_FLOWRATE")), "", dt.Rows(i).Item("CURRENT_FLOWRATE").ToString)
                DataGridMeter.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CURRENT_PRESET")), "", dt.Rows(i).Item("CURRENT_PRESET").ToString)
                DataGridMeter.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("fv_control")), "", dt.Rows(i).Item("fv_control").ToString)
                DataGridMeter.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("GROSS_DELIVERY")), "", dt.Rows(i).Item("GROSS_DELIVERY").ToString)
                DataGridMeter.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("NET_15C_DELIVERY")), "", dt.Rows(i).Item("NET_15C_DELIVERY").ToString)
                DataGridMeter.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("NET_30C_DELIVERY")), "", dt.Rows(i).Item("NET_30C_DELIVERY").ToString)
                DataGridMeter.Item(12, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CURRENT_TEMPERTURE")), "", dt.Rows(i).Item("CURRENT_TEMPERTURE").ToString)
                DataGridMeter.Item(13, i).Value = IIf(IsDBNull(dt.Rows(i).Item("mass_air_delivery")), "", dt.Rows(i).Item("mass_air_delivery").ToString)
                DataGridMeter.Item(14, i).Value = IIf(IsDBNull(dt.Rows(i).Item("mass_vac_delivery")), "", dt.Rows(i).Item("mass_vac_delivery").ToString)
                DataGridMeter.Item(15, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ENQUIRE_STATUS")), "", dt.Rows(i).Item("ENQUIRE_STATUS").ToString)
                DataGridMeter.Item(16, i).Value = IIf(IsDBNull(dt.Rows(i).Item("gross_totalizer")), "", dt.Rows(i).Item("gross_totalizer").ToString)
                DataGridMeter.Item(17, i).Value = IIf(IsDBNull(dt.Rows(i).Item("net_15c_totalizer")), "", dt.Rows(i).Item("net_15c_totalizer").ToString)
                DataGridMeter.Item(18, i).Value = IIf(IsDBNull(dt.Rows(i).Item("mass_totalizer")), "", dt.Rows(i).Item("mass_totalizer").ToString)
                DataGridMeter.Item(19, i).Value = IIf(IsDBNull(dt.Rows(i).Item("MODE_ACTIVE")), "", dt.Rows(i).Item("MODE_ACTIVE").ToString)
                If i = 0 Then
                    lblMeterPreset.Text = IIf(IsDBNull(dt.Rows(i).Item("current_preset")), "", dt.Rows(i).Item("current_preset").ToString)
                    lblMeterLoaded.Text = IIf(IsDBNull(dt.Rows(i).Item("GROSS_DELIVERY")), "", dt.Rows(i).Item("GROSS_DELIVERY").ToString)
                    lblFlowRate.Text = IIf(IsDBNull(dt.Rows(i).Item("CURRENT_FLOWRATE")), "", dt.Rows(i).Item("CURRENT_FLOWRATE").ToString)
                    lblMeterTOT.Text = IIf(IsDBNull(dt.Rows(i).Item("gross_totalizer")), "", dt.Rows(i).Item("gross_totalizer").ToString)
                    lblMeterName.Text = IIf(IsDBNull(dt.Rows(i).Item("Meter_no")) And IsDBNull(dt.Rows(i).Item("base_product_id")), "", dt.Rows(i).Item("Meter_no").ToString & " : " & dt.Rows(i).Item("base_product_id").ToString)
                    Meter_Name = IIf(IsDBNull(dt.Rows(i).Item("Meter_no")), "", dt.Rows(i).Item("Meter_no").ToString)
                    CmdEnable.Text = IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", IIf(dt.Rows(i).Item("IS_ENABLED") = 1, "Enable Meter", "Disable Meter"))
                    CmdEnable.BackColor = IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", IIf(dt.Rows(i).Item("IS_ENABLED") = 1, Color.FromArgb(76, 175, 80), Color.Red))
                    CmdLock.Text = IIf(IsDBNull(dt.Rows(i).Item("IS_LOCKED")), "", IIf(dt.Rows(i).Item("IS_LOCKED") = 1, "Lock Meter", "Unlock Meter"))
                    CmdLock.BackColor = IIf(IsDBNull(dt.Rows(i).Item("IS_LOCKED")), "", IIf(dt.Rows(i).Item("IS_LOCKED") = 1, Color.Red, Color.FromArgb(76, 175, 80)))
                    CmdLoad.Text = IIf(IsDBNull(dt.Rows(i).Item("TOP_UP_ACTIVE")), "", IIf(dt.Rows(i).Item("TOP_UP_ACTIVE") = 1, "Topup", "Loading"))
                    CmdLoad.BackColor = IIf(IsDBNull(dt.Rows(i).Item("TOP_UP_ACTIVE")), "", IIf(dt.Rows(i).Item("TOP_UP_ACTIVE") = 1, Color.Red, Color.FromArgb(76, 175, 80)))
                End If
                i = i + 1
            Loop


        Else
            DataGridMeter.RowCount = 1
            DataGridAlarm.RowCount = 1
            DataGridAlarmB.RowCount = 1
            lblMeterPreset.Text = ""
            lblMeterLoaded.Text = ""
            lblFlowRate.Text = ""
            lblMeterTOT.Text = ""
            lblMeterName.Text = ""
            Meter_Name = ""
            CmdEnable.Text = ""
            CmdLock.Text = ""
            CmdLoad.Text = ""
            Exit Sub
        End If
        mDataSet = Nothing
        dt = Nothing
    End Sub
    Private Function GetRowIndex(ByVal iMeter As String)
        Dim i As Integer
        Dim r As Integer

        r = -1

        With DataGridMeter
            For i = 0 To .RowCount - 1
                If DataGridMeter.Item(0, i).Value.Equals(iMeter) Then
                    r = i
                    Exit For
                End If
            Next i
        End With

        GetRowIndex = r
    End Function
    Private Function BGRtoRGB(ByVal codeColour As String) As String
        Dim i As Integer = 6 - codeColour.Length
        While (i <> 0)
            codeColour = "0" + codeColour
            i = i - 1
        End While
        Dim sortRGB = codeColour(5) & codeColour(4) & codeColour(3) & codeColour(2) & codeColour(1) & codeColour(0)
        Return sortRGB
    End Function
    Private Function appendZero(ByVal codeColour As String) As String
        Dim i As Integer = 6 - codeColour.Length
        While (i <> 0)
            codeColour = "0" + codeColour
            i = i - 1
        End While
        Return codeColour
    End Function

    Private Sub MSGridMeter_Click()
        Dim strSQL As String
        'Dim Oratemp As OraDynaset, OraProduct As OraDynaset, OraRunAlarm As OraDynaset
        Dim strData As String
        If (DataGridMeter.Rows.Count > 0) Then
            Meter_Name = DataGridMeter.Item(0, DataGridMeter.CurrentRow.Index).Value
            strData = Meter_Name
        End If

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        strSQL = "select  * "
        strSQL = strSQL & " from steqi.accuload_value a"
        strSQL = strSQL & " Where A.METER_NO ='" & strData & "' "
        strSQL = strSQL & " Order by A.METER_NO "
        Dim tempMeterNo = ""
        Dim tempMeterLoaded = ""
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            i = 0
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                lblMeterLoaded.Text = CLng(IIf(IsDBNull(dt.Rows(i).Item("GROSS_DELIVERY")), "", dt.Rows(i).Item("GROSS_DELIVERY").ToString))
                tempMeterNo = IIf(IsDBNull(dt.Rows(i).Item("Meter_no")), "", dt.Rows(i).Item("Meter_no").ToString)
                tempMeterLoaded = lblMeterLoaded.Text
                lblFlowRate.Text = IIf(IsDBNull(dt.Rows(i).Item("CURRENT_FLOWRATE")), "", dt.Rows(i).Item("CURRENT_FLOWRATE").ToString)
                lblMeterTOT.Text = IIf(IsDBNull(dt.Rows(i).Item("gross_totalizer")), "", dt.Rows(i).Item("gross_totalizer").ToString)
            End If
        Else
        End If
        mDataSet = Nothing

        strSQL = "select t.meter_no,t.base_product_id,t.* "
        strSQL = strSQL & "  from meter t"
        strSQL = strSQL & " where t.meter_no='" & strData & "'"
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            i = 0
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                lblMeterName.Text = tempMeterNo & " : " & IIf(IsDBNull(dt.Rows(i).Item("base_product_id")), "", dt.Rows(i).Item("base_product_id").ToString)
                CmdEnable.Text = IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", IIf(dt.Rows(i).Item("IS_ENABLED") = 1, "Enable Meter", "Disable Meter"))
                CmdEnable.BackColor = IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", IIf(dt.Rows(i).Item("IS_ENABLED") = 1, Color.FromArgb(76, 175, 80), Color.Red))

                CmdLock.Text = IIf(IsDBNull(dt.Rows(i).Item("IS_LOCKED")), "", IIf(dt.Rows(i).Item("IS_LOCKED") = 1, "Lock Meter", "Unlock Meter"))
                CmdLock.BackColor = IIf(IsDBNull(dt.Rows(i).Item("IS_LOCKED")), "", IIf(dt.Rows(i).Item("IS_LOCKED") = 1, Color.Red, Color.FromArgb(76, 175, 80)))
                CmdLoad.Text = IIf(IsDBNull(dt.Rows(i).Item("TOP_UP_ACTIVE")), "", IIf(dt.Rows(i).Item("TOP_UP_ACTIVE") = 1, "Topup", "Loading"))
                CmdLoad.BackColor = IIf(IsDBNull(dt.Rows(i).Item("TOP_UP_ACTIVE")), "", IIf(dt.Rows(i).Item("TOP_UP_ACTIVE") = 1, Color.Red, Color.FromArgb(76, 175, 80)))

            End If
        Else
        End If
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
        AlarmType()
        'UcPermissive1.ShowData(Trim(Meter_Name))
    End Sub

    Private Sub cmdResetAlarmMeter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResetAlarmMeter.Click
        If Not P_CHECK_SCREEN_AUTHORIZE(mUserName, 304, 4) Then Exit Sub
        If RunProcResetAlarmMeter(Meter_Name) Then
            MsgBox("ทำการ Reset Alarm ชอง Meter :" & Meter_Name & " เรียบร้อยแล้ว")
        End If
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

        mDataSet.Dispose()
        mDataSet = Nothing
    End Function

    Private Sub cmdStartBatch_Click()

        'If Not GetAutherizeStatus(P_CurScreenID, 7) Then Exit Sub
        If ChkClickGrid = 1 Then
            If RunProcStartBatch() Then
                MsgBox("START BACTH  COMPLETE ", vbInformation)
                ChkClickGrid = 0
                Call ClearSelGrid(Row_New, DataGridMeter)
            End If
        Else
            MsgBox("ท่านยังไม่ได้เลือกช่องเติมที่ต้องการ  START BACTH กรุณาเลือกช่องเติมก่อน", vbInformation)
            Exit Sub
        End If
    End Sub

    Private Sub ClearSelGrid(ByVal iRow As Integer, ByVal iMsgrid As DataGridView)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Do While iMsgrid.Rows.Count > i
            iMsgrid.Rows.Item(i).Height = Grid_Height
            iMsgrid.Item(0, i).Style.BackColor = Color.White
            For j = 0 To iMsgrid.ColumnCount - 1
                iMsgrid.Item(i, Row_Old).Style.BackColor = Color.White
            Next j
            i = i + 1
        Loop

    End Sub

    Private Function RunProcStartBatch() As Boolean
        Dim strSQL As String
        RunProcStartBatch = False
        If MsgBox("ท่านต้องการ START BATCH ช่องเติมที่ " & Compartment & " ของทะเบียนรถ " & lblTruckName.Text & "หรือไม่", vbInformation + vbYesNo) = vbNo Then
            Call ClearSelGrid(Row_New, DataGridLoading)
            Return False
        End If

        strSQL = ""
        strSQL = strSQL & "begin "
        strSQL = strSQL & " load.P_CRBAY_COMMAND_START ("
        strSQL = strSQL & Trim(lblloadNo.Text) & "," & Trim(Compartment) & ","
        strSQL = strSQL & Trim(mBayNo) & ", "
        strSQL = strSQL & ":ret_check,:ret_msg,:ret_cr_msg); "
        strSQL = strSQL & "end;"


        Dim bRet As Boolean = False
        Dim Oraparam As New COraParameter
        Dim ret_cr_msg As Object
        Dim ret_check As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("ret_check", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("ret_msg", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("ret_cr_msg", COracle._OracleDbType.OraVarchar2, 512)
        End With
        If Oradb.ExeSQL(strSQL, Oraparam) Then
            ret_cr_msg = Oraparam.GetOraclParamValue("ret_cr_msg")
            ret_check = Oraparam.GetOraclParamValue("ret_check")
            RET_MSG = Oraparam.GetOraclParamValue("ret_msg")
            If ret_check = 0 Then
                MsgBox(Oraparam.GetOraclParamValue("ret_msg").ToString, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                bRet = True
            Else
                MsgBox(Oraparam.GetOraclParamValue("ret_msg").ToString, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                bRet = False
            End If
            '---------------

            'RunProcStartBatch = IIf((Oraparam.GetOraclParamValue("ret_check") >= 0), True, False)
            'If Not RunProcStartBatch Then
            '    MsgBox(IIf(Oraparam.GetOraclParamValue("retu_msg").ToString, "", Oraparam.GetOraclParamValue("retu_msg").ToString), vbCritical, "??????????????")
            'End If

        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function
    Private Function RunProcEndBatch() As Boolean
        Dim strSQL As String
        RunProcEndBatch = False
        If MsgBox("ท่านต้องการ END BATCH หมายเลข Load NO " & lblloadNo.Text & " ของทะเบียนรถ " & lblTruckName.Text & "หรือไม่", vbInformation + vbYesNo) = vbNo Then
            Call ClearSelGrid(Row_New, DataGridLoading)
            Return False
        End If

        strSQL = ""
        strSQL = strSQL & "begin "
        strSQL = strSQL & " Load.P_CRBAY_COMMAND_END ("
        strSQL = strSQL & Trim(lblloadNo.Text) & "," & Trim(mBayNo) & ","
        strSQL = strSQL & ":ret_check,:ret_msg,:ret_cr_msg); "
        strSQL = strSQL & "end;"

        Dim bRet As Boolean = False
        Dim Oraparam As New COraParameter
        Dim ret_cr_msg As Object
        Dim ret_check As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("ret_check", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("ret_msg", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("ret_cr_msg", COracle._OracleDbType.OraVarchar2, 512)
        End With
        If Oradb.ExeSQL(strSQL, Oraparam) Then
            ret_cr_msg = Oraparam.GetOraclParamValue("ret_cr_msg")
            ret_check = Oraparam.GetOraclParamValue("ret_check")
            RET_MSG = Oraparam.GetOraclParamValue("ret_msg")
            If ret_check = 0 Then
                MsgBox(Oraparam.GetOraclParamValue("ret_msg").ToString, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                bRet = True
            Else
                MsgBox(Oraparam.GetOraclParamValue("ret_msg").ToString, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                bRet = False
            End If

        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function
    Private Function RunProcStopBatch()
        Dim strSQL As String
        RunProcStopBatch = False
        If MsgBox("ท่านต้องการ STOP  BATCH  ของรถทะเบียน " & lblTruckName.Text & "หรือไม่", vbInformation + vbYesNo) = vbNo Then
            Call ClearSelGrid(Row_New, DataGridLoading)
            Return False
        End If
        strSQL = ""
        strSQL = strSQL & "begin "
        strSQL = strSQL & " load.P_CRBAY_COMMAND_STOP ("
        strSQL = strSQL & Trim(lblloadNo.Text) & ","
        strSQL = strSQL & Trim(mBayNo) & ", "
        strSQL = strSQL & ":ret_check,:ret_msg,:ret_cr_msg); "
        strSQL = strSQL & "end;"


        Dim bRet As Boolean = False
        Dim Oraparam As New COraParameter
        Dim ret_cr_msg As Object
        Dim ret_check As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("ret_check", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("ret_msg", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("ret_cr_msg", COracle._OracleDbType.OraVarchar2, 512)
        End With
        If Oradb.ExeSQL(strSQL, Oraparam) Then
            ret_cr_msg = Oraparam.GetOraclParamValue("ret_cr_msg")
            ret_check = Oraparam.GetOraclParamValue("ret_check")
            RET_MSG = Oraparam.GetOraclParamValue("ret_msg")
            If ret_check = 0 Then
                MsgBox(Oraparam.GetOraclParamValue("ret_msg").ToString, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                bRet = True
            Else
                MsgBox(Oraparam.GetOraclParamValue("ret_msg").ToString, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                bRet = False
            End If
            '---------------

            'RunProcStopBatch = IIf((Oraparam.GetOraclParamValue("RET_CHECKE") >= 0), True, False)
            'If Not RunProcStartBatch() Then
            '    MsgBox(IIf(Oraparam.GetOraclParamValue("retu_msg").ToString, "", Oraparam.GetOraclParamValue("retu_msg").ToString), vbCritical, "??????????????")
            'End If

        End If
        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function

    Private Sub cmdLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLock.Click

        Dim strSQL As String
        Dim StatusCaption As String = ""
        If Not P_CHECK_SCREEN_AUTHORIZE(mUserName, 304, 1) Then Exit Sub
        'If Not GetAutherizeStatus(P_CurScreenID, 1) Then Exit Sub
        If CmdLock.Text = "Lock Meter" Then
            StatusCaption = "Unlock Meter"
        ElseIf CmdLock.Text = "Unlock Meter" Then
            StatusCaption = "Lock Meter"
        End If

        If MsgBox("ท่านต้องการแก้ไขเป็น " & StatusCaption & "   หรือไม่", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        Else
            If CmdLock.Text = "Lock Meter" Then
                strSQL = " Update METER M SET  M.IS_LOCKED = 0 "
                strSQL = strSQL & " Where M.meter_no ='" & Meter_Name & "' "
                Oradb.ExeSQL(strSQL)

                CmdLock.Text = "Unlock Meter"
                CmdLock.BackColor = Color.GreenYellow
            ElseIf CmdLock.Text = "Unlock Meter" Then
                strSQL = " Update tas.meter m SET m.IS_LOCKED = '1' "
                strSQL = strSQL & " Where m.meter_no ='" & Meter_Name & "' "
                Oradb.ExeSQL(strSQL)
                CmdLock.Text = "Lock Meter"
                CmdLock.BackColor = Color.Red
            Else
            End If
        End If
        'Oradb = Nothing
    End Sub

    Private Sub CmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLoad.Click
        Dim strSQL As String
        Dim StatusCaption As String = ""

        If Not P_CHECK_SCREEN_AUTHORIZE(mUserName, 304, 2) Then Exit Sub
        'If Not GetAutherizeStatus(P_CurScreenID, 2) Then Exit Sub

        If CmdLoad.Text = "Topup" Then
            StatusCaption = "Loading"
        ElseIf CmdLoad.Text = "Loading" Then
            StatusCaption = "Topup"
        End If

        If MsgBox("ท่านต้องการแก้ไขเป็น  " & StatusCaption & "   หรือไม่", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        Else
            If CmdLoad.Text = "Topup" Then
                strSQL = " Update METER M SET M.TOP_UP_ACTIVE = 0 "
                strSQL = strSQL & " Where M.meter_no ='" & Meter_Name & "' "
                Oradb.ExeSQL(strSQL)
                CmdLoad.Text = "Loading"
                CmdLoad.BackColor = Color.GreenYellow
            ElseIf CmdLoad.Text = "Loading" Then
                strSQL = " Update tas.meter m SET m.TOP_UP_ACTIVE = '1' "
                strSQL = strSQL & " Where m.meter_no ='" & Meter_Name & "' "
                Oradb.ExeSQL(strSQL)
                CmdLoad.Text = "Topup"
                CmdLock.BackColor = Color.Red
            Else
            End If
        End If
        'mOradb = Nothing
    End Sub

    Private Sub CmdEnable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEnable.Click

        Dim strSQL As String
        Dim StatusCaption As String = ""
        If Not P_CHECK_SCREEN_AUTHORIZE(mUserName, 304, 3) Then Exit Sub
        'If Not GetAutherizeStatus(P_CurScreenID, 3) Then Exit Sub
        If CmdEnable.Text = "Enable Meter" Then
            StatusCaption = "Disable Meter"
        ElseIf CmdEnable.Text = "Disable Meter" Then
            StatusCaption = "Enable Meter"
        End If

        If MsgBox("ท่านต้องการแก้ไขเป็น  " & StatusCaption & "   หรือไม่", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        Else
            If CmdEnable.Text = "Enable Meter" Then
                strSQL = " Update METER M SET M.IS_ENABLED = 0 "
                strSQL = strSQL & " Where M.meter_no ='" & Meter_Name & "' "
                Oradb.ExeSQL(strSQL)
                CmdEnable.Text = "Disable Meter"
                CmdEnable.BackColor = Color.Red
            ElseIf CmdEnable.Text = "Disable Meter" Then
                strSQL = " Update tas.meter m SET m.is_enabled = '1' "
                strSQL = strSQL & " Where m.meter_no ='" & Meter_Name & "' "
                Oradb.ExeSQL(strSQL)
                CmdEnable.Text = "Enable"
                CmdEnable.BackColor = Color.GreenYellow
            Else
            End If
        End If
        'Oradb = Nothing
    End Sub

    Public Sub GetMeterChange(ByVal iMeter As String)
        MeterChange = iMeter
        If RunProcSetUpMeter() Then
            MsgBox(" SetUp Meter  Complete   ", vbInformation)
        End If
    End Sub

    Private Function RunProcSetUpMeter() As Boolean
        Dim strSQL As String
        RunProcSetUpMeter = False
        If MeterChange = "" Or lblloadNo.Text = "" Or Compartment = "" Then
            MsgBox("ข้อมูลไม่สมบูรณ์   Set Up มิเตอร์ ไม่สำเร็จ ", vbInformation)
            Exit Function
        End If
        If MsgBox("ท่านต้องการ Setup Meter ของรถทะเบียน " & lblTruckName.Text & "หรือไม่", vbInformation + vbYesNo) = vbNo Then
            Exit Function
        End If
        'InitailParaProcSetupMeter()
        strSQL = ""
        strSQL = strSQL & "begin "
        strSQL = strSQL & " load.LOAD_SAVE_METER ("
        strSQL = strSQL & Trim(lblloadNo.Text) & "," & Trim(Compartment) & ","
        strSQL = strSQL & Trim(mBayName) & ", "
        strSQL = strSQL & "'" & Trim(MeterChange) & "'"
        strSQL = strSQL & ",:ret_check,:ret_msg,:ret_cr_msg); "
        strSQL = strSQL & "end;"
        'RunProcSetUpMeter = ExecuteSQL(strSQL)
        'If RunProcSetUpMeter Then
        '    RunProcSetUpMeter = IIf((OraDb.Parameters("RET_CHECK").value = 0), True, False)
        '    If Not RunProcSetUpMeter Then
        '        MsgBox(IIf(IsDBNull(OraDb.Parameters("RET_MSG").value), "", OraDb.Parameters("RET_MSG").value), vbCritical, "??????????????")
        '        Exit Function
        '    End If
        'End If
        'RemoveParaProcSetupMeter()

        Dim bRet As Boolean = False
        Dim Oraparam As New COraParameter
        Dim ret_cr_msg As Object
        Dim ret_check As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("ret_check", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("ret_msg", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("ret_cr_msg", COracle._OracleDbType.OraVarchar2, 512)
        End With
        If Oradb.ExeSQL(strSQL, Oraparam) Then
            ret_cr_msg = Oraparam.GetOraclParamValue("ret_cr_msg")
            ret_check = Oraparam.GetOraclParamValue("ret_check")
            RET_MSG = Oraparam.GetOraclParamValue("ret_msg")
            If ret_check = 0 Then
                MsgBox(Oraparam.GetOraclParamValue("ret_msg").ToString, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                bRet = True
            Else
                MsgBox(Oraparam.GetOraclParamValue("ret_msg").ToString, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                bRet = False
            End If
            '---------------

            'RunProcSetUpMeter = IIf((Oraparam.GetOraclParamValue("RET_CHECKE") >= 0), True, False)
            'If Not RunProcSetUpMeter() Then
            '    MsgBox(IIf(Oraparam.GetOraclParamValue("retu_msg").ToString, "", Oraparam.GetOraclParamValue("retu_msg").ToString), vbCritical, "??????????????")
            'End If

        End If
        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function

    Private Sub cmdClearBay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim ij_computer As String, ij_user As String, ibay_name As String
        Dim strSQL As String, Clear As Long
        On Error GoTo Err_Func
        If Not P_CHECK_SCREEN_AUTHORIZE(mUserName, 304, 5) Then Exit Sub
        'If Not GetAutherizeStatus(P_CurScreenID, 5) Then Exit Sub
        ij_user = "TAS.SYSTEM_USER"
        ij_computer = P_ComputerName
        If mBayName = "" Then
            Exit Sub
        Else
            strSQL = "select t.bay_active,t.bay_name from view_bay_mmi_loading t "
            strSQL = strSQL & "Where t.bay_name = '" & mBayName & "'  "

            Dim mDataSet As New DataSet
            Dim i As Integer = 0
            Dim dt As DataTable
            If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                If dt.Rows.Count > 0 Then
                    Clear = IIf(IsDBNull(dt.Rows(i).Item("bay_active")), "", dt.Rows(i).Item("bay_active").ToString)
                End If
            End If
            mDataSet = Nothing


            If Clear = 1 Then
                ibay_name = mBayName
                If MsgBox("ท่านต้องการ Clear Bay " & mBayName & "หรือไม่", vbInformation + vbYesNo) = vbNo Then
                    Exit Sub
                Else
                    strSQL = "begin "
                    strSQL = strSQL & "LOAD.load_clear_bay_active('"
                    strSQL = strSQL & ibay_name & "','" & ij_user & "','" & ij_computer & "'); "
                    strSQL = strSQL & "end;"
                    Oradb.ExeSQL(strSQL)
                End If
            End If
        End If
        'mOradb = Nothing

Err_Func:
    End Sub

    Private Sub CmdLoadLocked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLoadLocked.Click

        Dim strSQL As String
        Dim StatusCaption As String = ""

        ' If Not GetAutherizeStatus(P_CurScreenID, 6) Then Exit Sub

        If CmdLoadLocked.Text = "" Then
            Exit Sub
        End If

        If CmdLoadLocked.Text = "Unlock การจ่าย" Then
            StatusCaption = "Unlock การจ่าย"
            CmdLoadLocked.Text = "Unlock การจ่าย"
        Else
            StatusCaption = "Lock การจ่าย"
            CmdLoadLocked.Text = "Lock การจ่าย"
        End If

        If MsgBox("ท่านต้องการแก้ไขเป็น   " & StatusCaption & "   หรือไม่", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        Else
            If CmdLoadLocked.Text = "Lock การจ่าย" Then
                CmdLoadLocked.BackColor = Color.Red
                strSQL = " Update oil_load_headers o SET o.loading_locked = 0 "
                strSQL = strSQL & " Where o.load_header_no ='" & lblloadNo.Text & "' "
                Oradb.ExeSQL(strSQL)
            ElseIf CmdLoadLocked.Text = "Unlock การจ่าย" Then
                CmdLoadLocked.BackColor = Color.Green
                strSQL = " Update oil_load_headers o SET o.loading_locked = '1' "
                strSQL = strSQL & " Where o.load_header_no ='" & lblloadNo.Text & "' "
                Oradb.ExeSQL(strSQL)
            Else
            End If
        End If

    End Sub

    Private Sub CmdTruckDlide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim i As Long
        If Not (lblTruckTran.Text = "") Then
            For i = 1 To tempI
                'UcProgress(i).Visible = CPicture
                'lblPercent(i).Visible = False
            Next i
            For i = 6 To tempI
                'UcProgress(i).Visible = Not CPicture
                'lblPercent(i).Visible = False
            Next i
            If CPicture = False Then
                CmdTruckDlide.Text = "<<"
                lblStatus.Text = "หางพ่วง"


                'PicTruck.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\Truck2.bmp")
                'PicTruck.BackgroundImageLayout = ImageLayout.Stretch
                CPicture = True
            Else
                CmdTruckDlide.Text = ">>"
                lblStatus.Text = "หัวรถพ่วง"

                'PicTruck.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\Truck1.bmp")
                'PicTruck.BackgroundImageLayout = ImageLayout.Stretch
                CPicture = False
            End If
        Else
            lblStatus.Text = "หัวรถเดี่ยว"
        End If

    End Sub

    'Dim oldBay As Integer
    Sub changeBay(ByVal index)
        InitialDataHeaders(index)
        InitialDataLines(index)
        InitialMeter(index)
        AlarmType()
        CPicture = True
        'UcPermissive1.ShowData(Trim(Meter_Name))
        'oldBay.BackColor = Color.WhiteSmoke
    End Sub

    Public Sub selectBay(ByVal bNo, ByVal bName)
        'changeBay(bNo)
        mBayNo = bNo
        mBayName = bName
        'BayNo.Text = bNo
        lblBayNum.Text = "BAY NO." & CType(bName, String)
        Dim i = 1
        Do While (buttonBay.Count + 1 > i)
            buttonBay(i).setWhiteButtion()
            i += 1
        Loop
        buttonBay(CType(bNo, Integer)).setGreenButtion()

        'setWhiteButtion()
        InitialDataHeaders(mBayName)
        InitialDataLines(mBayNo)
        InitialMeter(mBayNo)
        AlarmType()
        CPicture = True
    End Sub

    Private Sub cmdStopBatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStopBatch.Click
        If Not P_CHECK_SCREEN_AUTHORIZE(mUserName, 304, 8) Then Exit Sub
        ' If Not GetAutherizeStatus(P_CurScreenID, 8) Then Exit Sub
        If ChkClickGrid = 1 Then
            If RunProcStopBatch() Then
                MsgBox("STOP BATCH COMPLETE ", vbInformation)
                Call ClearSelGrid(Row_New, DataGridLoading)
            End If
        Else
            MsgBox("ท่านยังไม่ได้เลือกช่องเติมที่ต้องการ STOP BATCH กรุณาเลือกช่องเติมก่อน", vbInformation)
            Exit Sub
        End If

    End Sub

    Private Sub cmdStartBatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStartBatch.Click
        If Not P_CHECK_SCREEN_AUTHORIZE(mUserName, 304, 7) Then Exit Sub
        'If Not GetAutherizeStatus(P_CurScreenID, 7) Then Exit Sub
        If ChkClickGrid = 1 Then
            If RunProcStartBatch() Then
                MsgBox("START BATCH COMPLETE ", vbInformation)
                ChkClickGrid = 0
                Call ClearSelGrid(Row_New, DataGridLoading)
            End If
        Else
            MsgBox("ท่านยังไม่ได้เลือกช่องเติมที่ต้องการ  START BATCH กรุณาเลือกช่องเติมก่อน", vbInformation)
            Exit Sub
        End If

    End Sub

    Private Sub cmdSetUpMeter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSetUpMeter.Click

        'If Not GetAutherizeStatus(P_CurScreenID, 9) Then Exit Sub
        If Not P_CHECK_SCREEN_AUTHORIZE(mUserName, 304, 9) Then Exit Sub
        If ChkClickGrid = 1 Then
            frmMMIMeterSetup.ShowDialog()
            ChkClickGrid = 0
            Call ClearSelGrid(Row_New, DataGridLoading)
        Else
            MsgBox("ท่านยังไม่ได้เลือกช่องเติมที่ต้องการเปลี่ยนมิเตอร์ กรุณาเลือกช่องเติมก่อน", vbInformation)
            Exit Sub
        End If
    End Sub

    Private Sub CmdTopUP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTopUP.Click
        If P_CHECK_SCREEN_AUTHORIZE(mUserName, 304, 10) Then
            'If Not GetAutherizeStatus(P_CurScreenID, 10) Then Exit Sub
            If TopUP = "" Or ChackBatchstatus = 3 Or ChackBatchstatus = 4 Or ChackBatchstatus = 6 Then
                MsgBox(" Batch Status ไม่อยู่ในสถานะ  (พร้อมจ่าย,เริ่มต้น,การเติมไม่สมบูรณ์)", vbCritical)
                Exit Sub
            Else
                frmMMIBayLoadingTopUP.OldTopup = TopUP
                frmMMIBayLoadingTopUP.Compartment = Compartment
                frmMMIBayLoadingTopUP.LoadHeader = LoadHeader
                frmMMIBayLoadingTopUP.Show()
            End If
        End If

    End Sub

    Private Sub DataGridMeter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MSGridMeter_Click()
    End Sub

    Private Sub DataGridLoading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'With DataGridLoading
        '    If DataGridLoading.CurrentRow.Index = 0 Then
        '        TopUP = ""
        '    Else
        '        Row_New = DataGridLoading.CurrentRow.Index
        '        Call PainSelGrid(Row_New, DataGridLoading)
        '        ChkClickGrid = 1
        '        Compartment = Trim(DataGridLoading.Item(0, Row_New).Value)
        '        TopUP = DataGridLoading.Item(4, Row_New).Value
        '        ChackBatchstatus = Trim(DataGridLoading.Item(DataGridLoading.ColumnCount - 1, Row_New).Value)
        '        LoadHeader = lblloadNo.Text
        '        Call frmMMIMeterSetup.GetBaseProductName(Trim(DataGridLoading.Item(1, Row_New).Value), Trim(DataGridLoading.Item(0, Row_New).Value), LoadHeader, Trim(DataGridLoading.Item(2, Row_New).Value))
        '    End If
        'End With
    End Sub

    Private Sub DataGridLoading_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridLoading.CellClick
        If e.RowIndex >= 0 Then
            Row_New = DataGridLoading.CurrentRow.Index
            Call PainSelGrid(Row_New, DataGridLoading)
            ChkClickGrid = 1
            Compartment = Trim(DataGridLoading.Item(0, Row_New).Value)
            TopUP = DataGridLoading.Item(4, Row_New).Value
            ChackBatchstatus = Trim(DataGridLoading.Item(DataGridLoading.ColumnCount - 1, Row_New).Value)
            LoadHeader = lblloadNo.Text
            Call frmMMIMeterSetup.GetBaseProductName(Trim(DataGridLoading.Item(1, Row_New).Value), Trim(DataGridLoading.Item(0, Row_New).Value), LoadHeader, Trim(DataGridLoading.Item(2, Row_New).Value))
        Else
            TopUP = ""
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tScan1.Tick
        'selectBay(CType(BayName, Integer), CType(BayName, Integer))

        RunningScanMeter(CType(mBayNo, Integer))
        RunningScanDataHeaders()
        RunningScanDataLines()
        RunningMeters()

        'เลือก Meter อัตโนมัติเมื่อมีการโหลด
        'If DataGridLoading.RowCount > 0 Then
        '    vMeter = DataGridLoading.Rows(0).Cells(2).Value.ToString()
        '    '  DataGridMeter.ClearSelection()
        '    DataGridMeter.CurrentCell = DataGridMeter.Item(0, GetRowIndex(vMeter))
        '    If GetRowIndex(vMeter) > 0 Then
        '        DataGridMeter.FirstDisplayedScrollingRowIndex = GetRowIndex(vMeter) - 1
        '    Else
        '        DataGridMeter.FirstDisplayedScrollingRowIndex = GetRowIndex(vMeter)
        '    End If
        '    MSGridMeter_Click()
        'End If
        MSGridMeter_Click()
    End Sub

    'Private Sub UcButtonBay1_OnClickButtonBay(ByVal BayNo As System.String, ByVal BayName As System.String) Handles UcButtonBay1.OnClickButtonBay
    '    mBayNo = BayNo
    '    mBayName = BayName
    '    InitialDataHeaders(mBayName)
    '    InitialDataLines(mBayNo)
    '    InitialMeter(mBayNo)
    '    AlarmType()
    'End Sub

    Private Sub lblMeterAlarm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim csA As New frmMMIBayLoadingAlarmPopUp
        Dim strMeter_no = lblMeterName.Text.Split(" ")
        If strMeter_no(0) = "" Then
            Exit Sub
        End If
        frmMMIBayLoadingAlarmPopUp.vMeter_No = strMeter_no(0)
        frmMMIBayLoadingAlarmPopUp.ShowDialog()
    End Sub


    Private Sub DataGridAlarmB_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        'If e.RowIndex > 0 Then
        '    Dim vIndex As Integer = DataGridAlarmB.CurrentRow.Index()
        '    tScan2.Stop()
        'Else
        '    tScan2.Start()
        'End If
    End Sub

    Private Sub DataGridAlarm_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.RowIndex > 0 Then
            '    Dim vIndex As Integer = DataGridAlarm.CurrentRow.Index()
            '    tScan2.Stop()
            'Else
            '    tScan2.Start()
        End If
    End Sub


    Private Sub tScan2_Tick(sender As System.Object, e As System.EventArgs) Handles tScan2.Tick
        Call AlarmType()
        'UcPermissive1.ShowData(Trim(Meter_Name))
    End Sub

    Private Sub picMeterAlarm_Click(sender As System.Object, e As System.EventArgs)
        Dim csA As New frmMMIBayLoadingAlarmPopUp
        Dim strMeter_no = lblMeterName.Text.Split(" ")
        If strMeter_no(0) = "" Then
            Exit Sub
        End If
        frmMMIBayLoadingAlarmPopUp.vMeter_No = strMeter_no(0)
        frmMMIBayLoadingAlarmPopUp.Show()
    End Sub
    Private Sub UcHeader1_MinimizeButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.MinimizeButtonClick
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcHeader1_CloseButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.CloseButtonClick
        Me.Close()
    End Sub
    Private Sub UcBack1_Click(sender As Object, e As EventArgs) Handles UcBack1.Click
        Me.Close()
    End Sub

    Private Sub btnClearBay_Click(sender As Object, e As EventArgs) Handles btnClearBay.Click
        ClearBayActive()
    End Sub



    Private Sub UcBack1_MouseHover(sender As Object, e As EventArgs) Handles UcBack1.MouseHover
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("Back1")
    End Sub

    Private Sub UcBack1_MouseLeave(sender As Object, e As EventArgs) Handles UcBack1.MouseLeave
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("back")
    End Sub

    Private Sub ClearBayActive()
        Dim ij_computer As String, ij_user As String, ibay_name As String
        Dim strSQL As String, Clear As Long
        'On Error GoTo Err_Func
        If Not P_CHECK_SCREEN_AUTHORIZE(mUserName, 304, 5) Then Exit Sub
        'If Not GetAutherizeStatus(P_CurScreenID, 5) Then Exit Sub
        ij_user = "TAS.SYSTEM_USER"
        ij_computer = P_ComputerName
        If mBayName = "" Then
            Exit Sub
        Else
            strSQL = "select t.bay_active,t.bay_name from view_bay_mmi_loading t "
            strSQL = strSQL & "Where t.bay_name = '" & mBayName & "'  "

            Dim mDataSet As New DataSet
            Dim i As Integer = 0
            Dim dt As DataTable
            If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                If dt.Rows.Count > 0 Then
                    Clear = IIf(IsDBNull(dt.Rows(i).Item("bay_active")), "", dt.Rows(i).Item("bay_active").ToString)
                End If
            End If
            mDataSet = Nothing


            If Clear = 1 Then
                ibay_name = mBayName
                If MsgBox("ท่านต้องการ Clear Bay " & mBayName & "หรือไม่", vbInformation + vbYesNo) = vbNo Then
                    Exit Sub
                Else
                    strSQL = "begin "
                    strSQL = strSQL & "LOAD.load_clear_bay_active('"
                    strSQL = strSQL & ibay_name & "','" & ij_user & "','" & ij_computer & "'); "
                    strSQL = strSQL & "end;"
                    Oradb.ExeSQL(strSQL)
                End If
            End If
        End If
    End Sub
    Private Sub CmdEndtransaction_Click(sender As Object, e As EventArgs) Handles CmdEndtransaction.Click
        If ChkClickGrid = 1 Then
            If RunProcEndBatch() Then
                MsgBox("START END BATCH COMPLETE ", vbInformation)
                ChkClickGrid = 0
                Call ClearSelGrid(Row_New, DataGridLoading)
            End If
        Else
            MsgBox("ท่านยังไม่ได้เลือกช่องเติมที่ต้องการ  START END BATCH กรุณาเลือกช่องเติมก่อน", vbInformation)
            Exit Sub
        End If
    End Sub


    Private Sub UcMenuEdit_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64)
        Dim ij_computer As String, ij_user As String, ibay_name As String
        Dim strSQL As String, Clear As Long
        'On Error GoTo Err_Func
        If Not P_CHECK_SCREEN_AUTHORIZE(mUserName, 304, 5) Then Exit Sub
        'If Not GetAutherizeStatus(P_CurScreenID, 5) Then Exit Sub
        ij_user = "TAS.SYSTEM_USER"
        ij_computer = P_ComputerName
        If mBayName = "" Then
            Exit Sub
        Else
            strSQL = "select t.bay_active,t.bay_name from view_bay_mmi_loading t "
            strSQL = strSQL & "Where t.bay_name = '" & mBayName & "'  "

            Dim mDataSet As New DataSet
            Dim i As Integer = 0
            Dim dt As DataTable
            If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                If dt.Rows.Count > 0 Then
                    Clear = IIf(IsDBNull(dt.Rows(i).Item("bay_active")), "", dt.Rows(i).Item("bay_active").ToString)
                End If
            End If
            mDataSet = Nothing


            If Clear = 1 Then
                ibay_name = mBayName
                If MsgBox("ท่านต้องการ Clear Bay " & mBayName & "หรือไม่", vbInformation + vbYesNo) = vbNo Then
                    Exit Sub
                Else
                    strSQL = "begin "
                    strSQL = strSQL & "LOAD.load_clear_bay_active('"
                    strSQL = strSQL & ibay_name & "','" & ij_user & "','" & ij_computer & "'); "
                    strSQL = strSQL & "end;"
                    Oradb.ExeSQL(strSQL)
                End If
            End If
        End If
        'mOradb = Nothing
    End Sub


End Class