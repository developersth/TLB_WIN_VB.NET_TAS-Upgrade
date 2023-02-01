Imports Oracle.DataAccess.Client
Imports System.Data
Imports System.Drawing

Public Class frmUtlOverrideCR
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=Billing ,2=Gate_IN ,3=BAY ,4=Bay_Cancel ,5=Gate_OUT

    Private Sub frmUtlOverrideCR_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmUtlOverrideCR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        'If Me.Height > 768 Then
        '    GroupMain.Top = 150
        'End If
        Visible_Menu_Sub()
        Initial_frm()
    End Sub

    Private Sub frmUtlOverrideCR_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub

    Private Sub Initial_frm()
        Dim vLeft As Integer = 106
        Dim vTop As Integer = 43
        frm_work = 0
        'DataGridView1.Left = (Me.Width * 8) / 100
        'DataGridView1.Width = Me.Width - (DataGridView1.Left * 3)
        'DataGridView1.Top = 210
        'DataGridView1.Height = (Me.Height / 2) + (DataGridView1.Height / 2)

        'UcInsert1.Left = (DataGridView1.Left * 1.5) + DataGridView1.Width
        'UcInsert1.Top = DataGridView1.Top
        'UcEdit1.Left = UcInsert1.Left
        'UcEdit1.Top = UcInsert1.Top + 100
        'UcDelete1.Left = UcInsert1.Left
        'UcDelete1.Top = UcInsert1.Top + 200
        'UcSearch1.Left = UcInsert1.Left
        'UcSearch1.Top = UcInsert1.Top + 300
        'UcReflesh1.Left = UcInsert1.Left
        'UcReflesh1.Top = UcInsert1.Top + 400


        Group_Billing.Left = vLeft
        Group_Billing.Top = vTop
        Group_Billing.BackColor = Color.FromKnownColor(KnownColor.Control)

        Group_Gate.Left = vLeft
        Group_Gate.Top = vTop
        Group_Gate.BackColor = Color.FromKnownColor(KnownColor.Control)

        Group_Bay.Left = vLeft
        Group_Bay.Top = vTop
        Group_Bay.BackColor = Color.FromKnownColor(KnownColor.Control)

        Group_BayCancel.Left = vLeft
        Group_BayCancel.Top = vTop
        Group_BayCancel.BackColor = Color.FromKnownColor(KnownColor.Control)

        Dim Allctrl = From ctrl In Me.Panel1.Controls.OfType(Of UserControl)()

        For Each ctrl As ucMenutxtSub In Allctrl
            Dim vPad = New Padding()
            vPad = ctrl.MenuTextMargin
            vPad.Left = 10
            ctrl.MenuTextMargin = vPad
        Next
        Allctrl = Nothing

        Dim allCtrl_Group As Object
        allCtrl_Group = New GroupBox
        allCtrl_Group = From ctrl In Me.Panel2.Controls.OfType(Of GroupBox)()
        For Each ctrl As GroupBox In allCtrl_Group
            ctrl.Dock = DockStyle.Fill
        Next
        allCtrl_Group = Nothing
    End Sub

    Private Sub Visible_Menu_Sub()
        Dim allCtrl_Group As Object
        allCtrl_Group = New GroupBox
        allCtrl_Group = From ctrl In Me.Panel2.Controls.OfType(Of GroupBox)()
        For Each ctrl As GroupBox In allCtrl_Group
            If ctrl.Visible Then
                ctrl.Visible = False
                'ctrl.BackColor = Color.DimGray
            End If
        Next
        allCtrl_Group = Nothing
    End Sub

    Private Sub ClearDataBilling()
        CbCrId.Items.Clear()
        cbCardBil.Items.Clear()
        cbCardBil.Text = ""
        cbTail.Items.Clear()
        cbTail.Text = ""
        cbTUHead.Items.Clear()
        cbTUHead.Text = ""
        cbDriverBil.Items.Clear()
        cbDriverBil.Text = ""
        TxtDriverName.Text = ""
        TxtDriverSurname.Text = ""
        txtDo.Text = ""
        txtSealNumber.Text = ""
        DTPdate.Value = Date.Today
        DTPTime.Value = Now
    End Sub

    Private Sub ClearDataGate()
        CbGateCR.Items.Clear()
        CbGateCR.Text = ""
        CbVehicleCard.Items.Clear()
        CbVehicleCard.Text = ""
        txtVehicleName.Text = ""
        txtTuName.Text = ""
        txtGateDriverName.Text = ""
        txtGateLoad.Text = ""
        txtGateShipment.Text = ""
        DTPGateDate.Value = Date.Today
        DTPGateTime.Value = Now
    End Sub

    Private Sub ClearDataBay()
        cbBay.Items.Clear()
        cbBay.Text = ""
        CbBayCrId.Items.Clear()
        CbBayCrId.Text = ""
        CbBayVehicleId.Items.Clear()
        CbBayVehicleId.Text = ""
        txtBayVehicle.Text = ""
        txtBayTu.Text = ""
        txtBayDriverCard.Text = ""
        txtBayDriverName.Text = ""
        txtBayLoadNo.Text = ""
        txtBayShipment.Text = ""
        ChkBypass.Checked = False
        DTPBayDate.Value = Date.Today
        DTPBayTime.Value = Now
    End Sub

    Private Sub ClearDataBayCancel()
        CbBayCancelCrId.Items.Clear()
        CbBayCancelCrId.Text = ""
        CbBayCancelVehicleId.Items.Clear()
        CbBayCancelVehicleId.Text = ""
        txtBayCancelVehicle.Text = ""
        txtBayCancelTu.text = ""
        txtBayCancelDriverCard.Text = ""
        txtBayCancelName.Text = ""
        txtBayCancelLoad.Text = ""
        txtBayCancelShipment.Text = ""
        DTPDateCancel.Value = Date.Today
        DTPTimeCancel.Value = Now
    End Sub

    Private Sub InitialCombo(ByVal Index As Long)
        Select Case Index
            Case 1
                Call InitialCBbilling()
            Case 2
                Call InitialCBGate()
            Case 3
                Call InitialcbBay()
            Case 4
                Call InitialComboBayCancel()
            Case 5
                Call InitialComboGateOut()
        End Select
    End Sub

    Function InitialCB(ByVal sql_str As String, ByVal colName As String, ByVal cb As System.Object) As Boolean
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
            Return True
        End If
        mDataSet = Nothing
        Return True
    End Function

    Private Sub InitialCBbilling()
        Dim sql_str As String
        sql_str = " SELECT C.CARD_NO FROM TAS.CARD C,TAS.TRANSPORT_UNIT T  WHERE C.CARD_TYPE=0  AND C.IS_ENABLED=1  AND C.TU_NUMBER=T.TU_NUMBER(+)  "
        sql_str = sql_str & " AND NOT EXISTS(SELECT  H.TU_CARD_NO FROM OIL_LOAD_ENTRYCARD H WHERE C.CARD_NO=H.TU_CARD_NO) ORDER BY C.CARD_NO "
        InitialCB(sql_str, "CARD_NO", cbCardBil)

        sql_str = "SELECT D.DRIVER_ID, D.FIRST_NAME ||' '|| D.LAST_NAME  AS DRIVERNAME ,D.FIRST_NAME ||' '|| D.LAST_NAME ||' _'||D.DRIVER_ID AS DRIVER FROM DRIVER D  ORDER BY D.FIRST_NAME,D.LAST_NAME,D.DRIVER_ID "
        InitialCB(sql_str, "DRIVER", cbDriverBil)

        sql_str = " SELECT C.CARD_READER_ID ||'   '|| C.CARD_READER_NAME AS CARD_READER "
        sql_str = sql_str & " FROM CARD_READER C WHERE C.CARD_READER_TYPE=2 ORDER BY C.CARD_READER_ID"
        InitialCB(sql_str, "CARD_READER", CbCrId)

        sql_str = " SELECT T.TU_ID,T.TU_NUMBER,T.TU_ID||' - '||T.TU_NUMBER AS TUNAME "
        sql_str = sql_str & " FROM TRANSPORT_UNIT T ORDER BY T.TU_ID,T.TU_NUMBER "
        InitialCB(sql_str, "TUNAME", cbTUHead)
        InitialCB(sql_str, "TUNAME", cbTail)
    End Sub

    Private Sub InitialCBGate()
        Dim sql_str As String
        sql_str = " SELECT C.CARD_READER_ID ||'   '|| C.CARD_READER_NAME AS CARD_READER "
        sql_str = sql_str & " FROM CARD_READER C WHERE C.CARD_READER_TYPE=2 ORDER BY C.CARD_READER_ID"
        InitialCB(sql_str, "CARD_READER", CbGateCR)

        sql_str = " SELECT DISTINCT  T.TU_CARD_NO FROM OIL_LOAD_HEADERS T"
        sql_str = sql_str & " WHERE T.LOAD_STATUS=13 AND T.CANCEL_STATUS=0 ORDER BY T.TU_CARD_NO "
        InitialCB(sql_str, "TU_CARD_NO", CbVehicleCard)
    End Sub

    Private Sub InitialcbBay()
        Dim sql_str As String
        sql_str = " SELECT C.CARD_READER_ID ||'   '|| C.CARD_READER_NAME AS CARD_READER "
        sql_str = sql_str & " FROM CARD_READER C WHERE C.CARD_READER_TYPE=4 ORDER BY C.CARD_READER_ID"
        InitialCB(sql_str, "CARD_READER", CbBayCrId)

        sql_str = " SELECT DISTINCT  T.TU_CARD_NO FROM OIL_LOAD_HEADERS T"
        sql_str = sql_str & " WHERE T.LOAD_STATUS IN (21,31,54) AND T.CANCEL_STATUS=0 ORDER BY T.TU_CARD_NO ASC"
        InitialCB(sql_str, "TU_CARD_NO", CbBayVehicleId)

        sql_str = " SELECT B.BAY_NO ||'   '|| B.ISLAND_NO AS BAY"
        sql_str = sql_str & " FROM BAY B  WHERE B.IS_ENABLED = 1 AND B.IS_LOCKED = 0  ORDER BY B.BAY_NO"
        InitialCB(sql_str, "BAY", cbBay)
    End Sub

    Private Sub InitialComboBayCancel()
        Dim sql_str As String
        sql_str = " SELECT C.CARD_READER_ID ||'   '|| C.CARD_READER_NAME AS CARD_READER "
        sql_str = sql_str & " FROM CARD_READER C WHERE C.CARD_READER_TYPE=4 ORDER BY C.CARD_READER_ID"
        InitialCB(sql_str, "CARD_READER", CbBayCancelCrId)

        sql_str = " SELECT DISTINCT  T.TU_CARD_NO FROM OIL_LOAD_HEADERS T"
        sql_str = sql_str & " WHERE T.LOAD_STATUS IN (51,52,53) AND T.CANCEL_STATUS=0 ORDER BY T.TU_CARD_NO ASC"
        InitialCB(sql_str, "TU_CARD_NO", CbBayCancelVehicleId)

        sql_str = " SELECT B.BAY_NO ||'   '|| B.ISLAND_NO AS BAY"
        sql_str = sql_str & " FROM BAY B  WHERE B.IS_ENABLED = 1 AND B.IS_LOCKED = 0  ORDER BY B.BAY_NO"
        InitialCB(sql_str, "BAY", CmbBayCancel)
    End Sub

    Private Sub InitialComboGateOut()
        Dim sql_str As String
        sql_str = " SELECT C.CARD_READER_ID ||'   '|| C.CARD_READER_NAME AS CARD_READER "
        sql_str = sql_str & " FROM CARD_READER C WHERE C.CARD_READER_TYPE=5 ORDER BY C.CARD_READER_ID,C.CARD_READER_NAME"
        InitialCB(sql_str, "CARD_READER", CbGateCR)

        sql_str = " SELECT DISTINCT  T.TU_CARD_NO FROM OIL_LOAD_HEADERS T"
        sql_str = sql_str & " WHERE T.LOAD_STATUS IN (55,71) AND T.CANCEL_STATUS=0 ORDER BY T.TU_CARD_NO ASC"
        InitialCB(sql_str, "TU_CARD_NO", CbVehicleCard)
    End Sub

    Private Sub cbBay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub CbBayCancelCrId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbBayCancelCrId.KeyPress
        e.Handled = True
    End Sub

    Private Sub CbBayCancelVehicleId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbBayCancelVehicleId.KeyPress
        e.Handled = True
    End Sub

    Private Sub CbBayCrId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbBayCrId.KeyPress
        e.Handled = True
    End Sub

    Private Sub CbBayVehicleId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbBayVehicleId.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbCardBil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbCardBil.KeyPress
        e.Handled = True
    End Sub

    Private Sub CbCrId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbCrId.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbDriverBil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub CbGateCR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbGateCR.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbTail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cbTUHead_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub CbVehicleCard_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbVehicleCard.KeyPress
        e.Handled = True
    End Sub

    Private Sub ChkBypass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub CmbBayCancel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cbTUHead_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTUHead.SelectedIndexChanged
        GetDriver()
        GetTuTail()
    End Sub

#Region "ProcessBilling"
    Private Function ProcessBilling() As Boolean
        Dim vTuH() As String
        Dim vTuT() As String
        Dim vTu1 As String
        Dim vTu2 As String
        If cbCardBil.Text = "" Then
            MsgBox("ไม่สามารถสร้างการจ่ายได้ กรุณาตรวจสอบหมายเลขบัตร", vbInformation, "System TAS")
            Return False
        End If
        If CheckCard(cbCardBil.Text) Then
            MsgBox("ไม่พบหมายเลขบัตร  " & cbCardBil.Text & " ในฐานข้อมูล  ", vbCritical, "System TAS")
            Return False
        End If
        If cbTUHead.Text.Trim = "" Then
            MsgBox("คุณใส่ข้อมูลไม่ครบ", vbCritical, "System TAS")
            Return False
        End If
        If CheckTruckheader(cbTUHead.Text) Then
            MsgBox("ไม่พบหมายทะเบียนหัวลาก  " & cbTUHead.Text & " ในฐานข้อมูล  ", vbCritical, "System TAS")
            Return False
        End If
        If cbTail.Text <> "" Then
            If CheckTruckTail(cbTail.Text) Then
                MsgBox("ไม่พบหมายเลขทะเบียนตัวพ่วง " & cbTail.Text & " ในฐานข้อมูล  ", "System TAS")
                Return False
            End If
        End If
        If txtDo.Text.Trim = "" Then
            MsgBox("ไม่สามารถสร้างการจ่ายได้ กรุณาป้อนหมายเลข  Do ", vbCritical, "System TAS")
            Return False
        End If

        If txtSealNumber.Text.Trim = "" Then
            MsgBox("ไม่สามารถสร้างการจ่ายได้ กรุณาป้อนหมายเลข Seal", vbCritical, "System TAS")
            Return False
        End If

        If cbTUHead.Text <> "" Then
            vTuH = Split(cbTUHead.Text, " - ")
            vTu1 = vTuH(1)
            If cbTail.Text <> "" Then
                vTuT = Split(cbTail.Text, " - ")
                vTu2 = vTuT(1)
            Else
                vTu2 = "0"
            End If
        Else
            MsgBox("ไม่สามารถสร้างการจ่ายได้ กรุณาตรวจสอบทะเบียนหัวลาก", vbInformation, "System TAS")
            'MessageBox.Show("ไม่สามารถสร้างการจ่ายได้ กรุณาตรวจสอบทะเบียนหัวลาก", "System TAS")
            Return False
        End If

        If Not runProcVehicle(vTu1, vTu2, GetIdDriver(cbDriverBil)) Then
            Return False
        End If

        Dim result As Integer = MessageBox.Show("ท่านต้องการ Override เครื่องอ่านบัตรที่ห้องขายหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return False
        End If

        Call SaveData(mUserName, mComputerName)
        Return True
    End Function

    Private Function CheckCard(ByVal iCard As String) As Boolean
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        sql_str = " SELECT * "
        sql_str = sql_str & " FROM TAS.CARD C  "
        sql_str = sql_str & " WHERE C.CARD_NO ='" & Trim(iCard) & "' "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Do While dt.Rows.Count > i
                mDataSet = Nothing
                Return False
            Loop
            Return True
        End If
        mDataSet = Nothing
        Return True
    End Function

    Private Function CheckTruckheader(ByVal iTruckH As String) As Boolean
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        Dim tmpStr() As String
        Dim tmp1 As String = ""
        Dim tmp2 As String
        If InStr(1, iTruckH, " - ") > 0 Then
            tmpStr = Split(iTruckH, " - ")
            iTruckH = tmpStr(1)
            tmp2 = tmpStr(0)

            sql_str = " SELECT * "
            sql_str = sql_str & " FROM TAS.TRANSPORT_UNIT T "
            sql_str = sql_str & " WHERE T.TU_NUMBER ='" & Trim(iTruckH) & "' "
        Else
            iTruckH = iTruckH
            sql_str = " SELECT * "
            sql_str = sql_str & " FROM TAS.TRANSPORT_UNIT T "
            sql_str = sql_str & " WHERE T.TU_ID ='" & Trim(iTruckH) & "' "
        End If

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Do While dt.Rows.Count > i
                mDataSet = Nothing
                Return False
            Loop
            Return True
        End If
        mDataSet = Nothing
        Return True
    End Function

    Private Function CheckTruckTail(ByVal iTruckT As String) As Boolean
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        Dim tmpStr() As String
        Dim tmp1 As String = ""
        Dim tmp2 As String
        If InStr(1, iTruckT, " - ") > 0 Then
            tmpStr = Split(iTruckT, " - ")
            iTruckT = tmpStr(1)
            tmp2 = tmpStr(0)

            sql_str = " SELECT * "
            sql_str = sql_str & " FROM TAS.TRANSPORT_UNIT T "
            sql_str = sql_str & " WHERE T.TU_NUMBER ='" & Trim(iTruckT) & "' "
        Else
            iTruckT = iTruckT
            sql_str = " SELECT * "
            sql_str = sql_str & " FROM TAS.TRANSPORT_UNIT T "
            sql_str = sql_str & " WHERE T.TU_ID ='" & Trim(iTruckT) & "' "
        End If
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Do While dt.Rows.Count > i
                mDataSet = Nothing
                Return False
            Loop
            Return True
        End If
        mDataSet = Nothing
        Return True
    End Function

    Private Function GetIdDriver(ByVal iCb As ComboBox) As String
        Dim tmpDriver() As String
        If InStr(1, iCb.Text, "_") > 0 Then
            tmpDriver = Split(iCb.Text, "_")
            GetIdDriver = tmpDriver(1)
        Else
            GetIdDriver = "0"
        End If
    End Function

    Function GetSealCount() As Integer
        Dim strSQL As String
        Dim tmpSeal As Integer
        Dim tmpTu1() As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        tmpSeal = 0
        If cbTUHead.Text <> "" Then
            If cbTUHead.Text.IndexOf("-") > 0 Then
                tmpTu1 = cbTUHead.Text.Split("-")
                strSQL = _
                        " select t.fix_seal " & _
                         " from tas.transport_unit t" & _
                         " where t.tu_number ='" & Trim(tmpTu1(1)) & "' "
                If Oradb.OpenDys(strSQL, "TableName", mDataSet) Then
                    dt = mDataSet.Tables(0)
                    tmpSeal = IIf(IsDBNull(dt.Rows(0).Item("fix_seal")), 0, Convert.ToInt16(dt.Rows(0).Item("fix_seal")))
                End If
            End If
        End If
        If cbTail.Text <> "" Then
            If cbTail.Text.IndexOf("-") > 0 Then
                tmpTu1 = cbTail.Text.Split("-")
                strSQL = _
                        " select t.fix_seal " & _
                         " from tas.transport_unit t" & _
                         " where t.tu_number ='" & Trim(tmpTu1(1)) & "' "
                If Oradb.OpenDys(strSQL, "TableName", mDataSet) Then
                    dt = mDataSet.Tables(0)
                    tmpSeal = tmpSeal + IIf(IsDBNull(dt.Rows(0).Item("fix_seal")), 0, Convert.ToInt16(dt.Rows(0).Item("fix_seal")))
                End If
            End If
        End If
        dt = Nothing
        mDataSet = Nothing
        Return tmpSeal
    End Function
#End Region

#Region "ProcessGate"
    Private Function ProcessGate() As Boolean
        If CbGateCR.Text = "" Or CbVehicleCard.Text = "" Then
            MsgBox("คุณใส่ข้อมูลไม่ครบ", vbCritical, "System TAS")
            Return False
        End If

        If MsgBox("ท่านต้องการ Override เครื่องอ่านบัตรที่ทางเข้าหรือไม่ ?", vbInformation + vbYesNo) = vbNo Then
            Return False
        End If

        Dim strDateStart = DTPGateDate.Value.ToString.Split(" ")
        Dim dateStart = strDateStart(0)
        Dim strTimeStart = DTPGateTime.Value.ToString.Split(" ")
        Dim timeStart = strTimeStart(1)
        Dim dtpChoosDate = dateStart & " " & timeStart

        If txtGateDriverName.Text.Trim = "" Then
            Return False
        End If
        Call SaveEntrance(Mid(CbGateCR.Text, 1, 7), Trim(Mid(txtGateDriverName.Text, 1, InStr(1, txtGateDriverName.Text, " "))), 1, dtpChoosDate, mUserName, mComputerName)
        Return True
    End Function


    Private Function SaveEntrance(ByVal icard_reader_id As Long, ByVal idriver_id As Long, ByVal ioverride_card As Long, ByVal idatetime_active As String, ByVal ij_user As String, ByVal ij_computer As String) As Boolean
        Dim bRet As Boolean = False
        Dim sql_str As String
        If frm_work = 5 Then
            Call SaveEntranceCheckTU(CLng(CbVehicleCard.Text), icard_reader_id, 1, idatetime_active, ij_user, ij_computer)
            Return bRet
        Else
            sql_str = "BEGIN "
            sql_str = sql_str & " LOAD.ENTRANCE_CHECK_DRIVER("
            sql_str = sql_str & idriver_id & "," & ioverride_card & "," & icard_reader_id & ", "
            sql_str = sql_str & " to_date('" & idatetime_active & "','DD/MM/YYYY HH24:MI:SS') ,"
            sql_str = sql_str & "'" & ij_user & "','" & ij_computer & "',"
            sql_str = sql_str & ":ret_driver,:ret_check,:ret_msg); "
            sql_str = sql_str & "END;"
        End If

        Dim Oraparam As New COraParameter
        Dim RET_DRIVER As Object
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_DRIVER", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_CHECK", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With

        If Oradb.ExeSQL(sql_str, Oraparam) Then
            RET_DRIVER = Oraparam.GetOraclParamValue("RET_DRIVER")
            RET_CHECK = Oraparam.GetOraclParamValue("RET_CHECK")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            If RET_CHECK <> 0 Then
                MsgBox(RET_MSG, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "เกิดข้อผิดพลาด")
                Oraparam.RemoveOracleParam()
                Oraparam = Nothing
                Return bRet
            End If
            'MsgBox(RET_MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Call SaveEntranceCheckTU(CLng(CbVehicleCard.Text), icard_reader_id, 1, idatetime_active, ij_user, ij_computer)
            bRet = True
        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function

    Private Function SaveEntranceCheckTU(ByVal itu_card_no As Long, ByVal icard_reader_id As Long, ByVal ioverride_card As Long, ByVal idatetime_active As String, ByVal ij_user As String, ByVal ij_computer As String) As Boolean
        Dim bRet As Boolean = False
        Dim sql_str As String
        If frm_work = 5 Then
            sql_str = "BEGIN "
            sql_str = sql_str & " LOAD.EXIT_CHECK_TU("
            sql_str = sql_str & itu_card_no & "," & icard_reader_id & "," & ioverride_card & ", "
            sql_str = sql_str & " to_date('" & idatetime_active & "','DD/MM/YYYY HH24:MI:SS') ,"
            sql_str = sql_str & "'" & ij_user & "','" & ij_computer & "',"
            sql_str = sql_str & ":ret_cr_det,:ret_type,:ret_check,:ret_msg,:ret_cr_msg); "
            sql_str = sql_str & "END;"

        Else
            sql_str = "BEGIN "
            sql_str = sql_str & " LOAD.ENTRANCE_CHECK_TU("
            sql_str = sql_str & itu_card_no & "," & icard_reader_id & "," & ioverride_card & ", "
            sql_str = sql_str & " to_date('" & idatetime_active & "','DD/MM/YYYY HH24:MI:SS') ,"
            sql_str = sql_str & "'" & ij_user & "','" & ij_computer & "',"
            sql_str = sql_str & ":ret_cr_det,:ret_type,:ret_check,:ret_msg,:ret_cr_msg); "
            sql_str = sql_str & "END;"
        End If

        Dim Oraparam As New COraParameter
        Dim RET_CR_DET As Object
        Dim RET_TYPE As Object
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        Dim RET_CR_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_CR_DET", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_TYPE", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_CHECK", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_CR_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With

        If Oradb.ExeSQL(sql_str, Oraparam) Then
            RET_CR_DET = Oraparam.GetOraclParamValue("RET_CR_DET")
            RET_TYPE = Oraparam.GetOraclParamValue("RET_TYPE")
            RET_CHECK = Oraparam.GetOraclParamValue("RET_CHECK")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            RET_CR_MSG = Oraparam.GetOraclParamValue("RET_CR_MSG")

            If RET_CHECK <> 0 Then
                MsgBox(RET_MSG, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "เกิดข้อผิดพลาด")
                Oraparam.RemoveOracleParam()
                Oraparam = Nothing
                Return bRet
            End If
            MsgBox(RET_MSG, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ระบบแจ้งว่า")
            bRet = True
        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function
#End Region

#Region "ProcessBayIn"
    Private Function ProcessBayIn() As Boolean
        Dim bRet As Boolean = False
        Dim BayNumber() As String
        Dim ChkBox As Long

        If CbBayCrId.Text = "" Or CbBayVehicleId.Text = "" Or cbBay.Text = "" Then
            MsgBox("ไม่สามารถบันทึกข้อมูลได้ เนื่องจากคุณใส่ข้อมูลไม่ครบ ", vbCritical, "พบข้อผิดพลาด")
            Return bRet
        End If
        If MsgBox("คุณค้องการ Override เครื่องอ่านบัตรที่โรงจ่ายเพื่อรูดบัตรเข้าหรือไม่ ?", vbInformation + vbYesNo) = vbNo Then
            Return bRet
        End If

        If ChkBypass.Checked = True Then
            ChkBox = 1
        Else
            ChkBox = 0
        End If

        BayNumber = Split(cbBay.Text, " ")
        Dim strDateStart = DTPBayDate.Value.ToString.Split(" ")
        Dim dateStart = strDateStart(0)
        Dim strTimeStart = DTPBayTime.Value.ToString.Split(" ")
        Dim timeStart = strTimeStart(1)
        Dim dtpChoosDate = dateStart & " " & timeStart

        'Call SaveLoadCheckTu(CLng(CbBayVehicleId.Text), Mid(CbBayCrId.Text, 1, 7), 1, ChkBox, dtpChoosDate, BayNumber(0), mUserName, mComputerName)
        bRet = SaveLoadCheckTu(CLng(CbBayVehicleId.Text), Mid(CbBayCrId.Text, 1, 7), 1, ChkBox, dtpChoosDate, BayNumber(0), mUserName, mComputerName)
        Return bRet
    End Function

    Private Function SaveLoadCheckTu(ByVal itu_card_no As Long, ByVal icard_reader_id As Long, ByVal ioverride_card As Long, ByVal iby_pass As Long, ByVal idatetime_active As String, ByVal ibay_no As Long, ByVal ij_user As String, ByVal ij_computer As String) As Boolean
        Dim bRet As Boolean = False
        Dim sql_str As String

        sql_str = "BEGIN "
        sql_str = sql_str & " LOAD.LOAD_CHECK_TU("
        sql_str = sql_str & itu_card_no & "," & icard_reader_id & "," & ioverride_card & ", "
        sql_str = sql_str & iby_pass & ", "
        sql_str = sql_str & " to_date('" & idatetime_active & "','DD/MM/YYYY HH24:MI:SS') ,"
        sql_str = sql_str & ibay_no & ",'" & ij_user & "','" & ij_computer & "',"
        sql_str = sql_str & ":ret_load_type,:ret_check,:ret_msg,:ret_cr_msg); "
        sql_str = sql_str & "END;"

        Dim Oraparam As New COraParameter
        Dim RET_LOAD_TYPE As Object
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        Dim RET_CR_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_LOAD_TYPE", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_CHECK", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_CR_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With

        If Oradb.ExeSQL(sql_str, Oraparam) Then
            RET_LOAD_TYPE = Oraparam.GetOraclParamValue("RET_LOAD_TYPE")
            RET_CHECK = Oraparam.GetOraclParamValue("RET_CHECK")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            RET_CR_MSG = Oraparam.GetOraclParamValue("RET_CR_MSG")

            If RET_CHECK <> 0 Then
                MsgBox(RET_MSG, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "เกิดข้อผิดพลาด")
                Oraparam.RemoveOracleParam()
                Oraparam = Nothing
                Return bRet
            End If
            MsgBox(RET_MSG, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ระบบแจ้งว่า")
            bRet = True
        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function
#End Region

#Region "ProcessCancelBay"
    Private Function ProcessCancelBay() As Boolean
        Dim bRet As Boolean = False
        Dim BayNumber() As String

        If CbBayCancelCrId.Text.Trim = "" Or CbBayCancelVehicleId.Text.Trim = "" Then
            MsgBox("ไม่สามารถบันทึกข้อมูลได้ เนื่องจากคุณใส่ข้อมูลไม่ครบ ", vbCritical, "พบข้อผิดพลาด")
            Return bRet
        End If
        If CmbBayCancel.Text.Trim = "" Then
            MsgBox("ไม่สามารถบันทึกข้อมูลได้ เนื่องจากคุณยังไม่ได้เลือก Bay ", vbCritical, "พบข้อผิดพลาด")
            Return bRet
        End If
        If MsgBox("คุณต้องการ Override เครื่องอ่านบัตรที่โรงจ่ายเพื่อยกเลิกการจ่ายหรือไม่ ? ", vbInformation + vbYesNo) = vbNo Then
            Return bRet
        End If

        BayNumber = Split(CmbBayCancel.Text, " ")
        Dim strDateStart = DTPDateCancel.Value.ToString.Split(" ")
        Dim dateStart = strDateStart(0)
        Dim strTimeStart = DTPTimeCancel.Value.ToString.Split(" ")
        Dim timeStart = strTimeStart(1)
        Dim dtpChoosDate = dateStart & " " & timeStart

        bRet = SaveLoadCheckTu(CLng(CbBayCancelVehicleId.Text), Mid(CbBayCancelCrId.Text, 1, 7), 1, 0, dtpChoosDate, BayNumber(0), mUserName, mComputerName)
        Return bRet
    End Function
#End Region

#Region " Call Proc"

    Function runProcVehicle(ByVal iNumber1 As String, ByVal iNumber2 As String, ByVal IDriverID As String) As Boolean
        Dim bRet As Boolean = False
        Dim sql_str As String
        sql_str = "BEGIN "
        sql_str = sql_str & " LOAD.REGISTOR_CHECK_VEHICLE("
        sql_str = sql_str & iNumber1 & "," & iNumber2 & "," & IDriverID & ","
        sql_str = sql_str & ":ret_vehicle,:ret_checked,:retu_msg); "
        sql_str = sql_str & "END;"

        Dim Oraparam As New COraParameter
        Dim RET_VEHICLE As Object
        Dim RET_CHECKED As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_VEHICLE", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_CHECKED", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With

        If Oradb.ExeSQL(sql_str, Oraparam) Then
            RET_VEHICLE = Oraparam.GetOraclParamValue("RET_VEHICLE")
            RET_CHECKED = Oraparam.GetOraclParamValue("RET_CHECKED")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            If RET_CHECKED <> 0 Then
                MsgBox(RET_MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                bRet = False
            Else
                bRet = True
            End If
        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing

        Return bRet
    End Function

    Function SaveData(ByVal JUser As String, ByVal jComputer As String) As Boolean
        Dim vTuH() As String
        Dim vTuT() As String
        Dim vTu1 As String
        Dim vTu2 As String

        If cbTUHead.Text <> "" Then
            vTuH = Split(cbTUHead.Text, " - ")
            vTu1 = vTuH(1)
            If cbTail.Text <> "" Then
                vTuT = Split(cbTail.Text, " - ")
                vTu2 = vTuT(1)
            Else
                vTu2 = "0"
            End If
        Else
            MsgBox("ไม่สามารถสร้างการจ่ายได้ กรุณาตรวจสอบทะเบียนหัวลาก", vbInformation)
            Return False
        End If
        If CbCrId.Text = "" Then
            CbCrId.Text = "00000000"
        End If

        Dim strDate = DTPdate.Value.ToString.Split(" ")
        Dim dateRequire = strDate(0)
        Dim strTime = DTPTime.Value.ToString.Split(" ")
        Dim timeRequire = strTime(1)
        Dim dateTimeRequire As String = dateRequire & " " & timeRequire

        SaveData = SaveCreateLoad(CLng(Trim(cbCardBil.Text)), CLng(Trim(vTu1)), CLng(Trim(vTu2)), CLng(Mid(CbCrId.Text, 1, 7)), 1, dateTimeRequire, JUser, jComputer)
    End Function

    Function SaveCreateLoad(ByVal itu_card_no As Long, ByVal itu1 As Long, ByVal itu2 As Long, ByVal icard_reader_id As Long, ByVal ioverride_card As Long, ByVal idatetime_active As String, ByVal ij_user As String, ByVal ij_computer As String) As Boolean
        Dim bRet As Boolean = False
        Dim drivID As String = ""
        Dim sql_str As String
        sql_str = "BEGIN "
        sql_str = sql_str & " LOAD.REGISTOR_CHECK_TU("
        sql_str = sql_str & itu_card_no & "," & itu1 & "," & itu2 & ","
        sql_str = sql_str & icard_reader_id & ", "
        sql_str = sql_str & ioverride_card & ",to_date('" & idatetime_active & "','DD/MM/YYYY HH24:MI:SS') ,"
        sql_str = sql_str & "'" & ij_user & "','" & ij_computer & "',"
        sql_str = sql_str & ":ret_vehicle_number,:ret_tuid,:ret_tuid1,:ret_check,:ret_msg); "
        sql_str = sql_str & "END;"

        Dim Oraparam As New COraParameter
        Dim RET_VEHICLE_NUMBER As Object
        Dim RET_TUID As Object
        Dim RET_TUID1 As Object
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_VEHICLE_NUMBER", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_TUID", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_TUID1", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_CHECK", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With

        If Oradb.ExeSQL(sql_str, Oraparam) Then
            RET_VEHICLE_NUMBER = Oraparam.GetOraclParamValue("RET_VEHICLE_NUMBER")
            RET_TUID = Oraparam.GetOraclParamValue("RET_TUID")
            RET_TUID1 = Oraparam.GetOraclParamValue("RET_TUID1")
            RET_CHECK = Oraparam.GetOraclParamValue("RET_CHECK")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            If RET_CHECK >= 0 Then
                'If RET_CHECK <> 0 Then
                '    MsgBox(RET_MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                '    Oraparam.RemoveOracleParam()
                '    Oraparam = Nothing
                '    Return bRet
                'End If

                If cbDriverBil.Text = "" Then
                    MsgBox("ไม่พบรหัสพนักงานขับรถ กรุณาเลือกพนักงานขับรถอีกครั้ง", vbInformation)
                    bRet = False
                Else
                    If InStr(1, Trim(cbDriverBil.Text), " _") > 0 Then
                        drivID = Mid(cbDriverBil.Text, InStr(1, cbDriverBil.Text, " _") + 2, Len(cbDriverBil.Text) - InStr(1, cbDriverBil.Text, " _"))
                    Else
                        MsgBox("รูปแบบของข้อมูลไม่ถูดต้อง กรุณาเลือกอีกครั้ง ", vbInformation)
                        bRet = False
                    End If
                End If
                bRet = SaveCheckDriver(RET_VEHICLE_NUMBER.ToString, drivID, 1, idatetime_active, ij_user, ij_computer, itu_card_no, itu1, itu2, icard_reader_id)
            Else
                bRet = False
                MsgBox(RET_MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            End If
        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function

    Function SaveCheckDriver(ByVal ivehicle_number As String, ByVal idriver_id As String, ByVal ioverride_card As Long, ByVal idatetime_active As String, ByVal ij_user As String, ByVal ij_computer As String, ByVal itu_card_no As Long, ByVal ituID1 As Long, ByVal ituID2 As Long, ByVal icard_reader_id As Long) As Boolean
        Dim bRet As Boolean = False
        Dim ido_no_count As Long
        Dim i As Long
        Dim arCountDo() As String

        arCountDo = Split(txtDo.Text, ",")
        For i = 0 To UBound(arCountDo)
            ido_no_count = i + 1
        Next i

        Dim sql_str As String
        sql_str = "BEGIN "
        sql_str = sql_str & " LOAD.REGISTOR_CHECK_DRIVER('"
        sql_str = sql_str & ivehicle_number & "'," & idriver_id & ","
        sql_str = sql_str & ioverride_card & ", "
        sql_str = sql_str & " to_date('" & idatetime_active & "','DD/MM/YYYY HH24:MI:SS') ,"
        sql_str = sql_str & "'" & ij_user & "','" & ij_computer & "',"
        sql_str = sql_str & ":ret_driver,:ret_check,:ret_msg); "
        sql_str = sql_str & "END;"

        Dim Oraparam As New COraParameter
        Dim RET_DRIVER As Object
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_DRIVER", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_CHECK", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With

        If Oradb.ExeSQL(sql_str, Oraparam) Then
            RET_DRIVER = Oraparam.GetOraclParamValue("RET_DRIVER")
            RET_CHECK = Oraparam.GetOraclParamValue("RET_CHECK")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            If RET_CHECK <> 0 Then
                MsgBox(RET_MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                Oraparam.RemoveOracleParam()
                Oraparam = Nothing
                Return False
            End If
            bRet = SaveRegCreateLoad(itu_card_no, ituID1, ituID2, idriver_id, ivehicle_number, ido_no_count, ioverride_card, icard_reader_id, idatetime_active, ij_user, ij_computer)
            'bRet = True
        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function

    Function SaveRegCreateLoad(ByVal itu_card_no As Long, ByVal ituID1 As Long, ByVal ituID2 As Long, ByVal idriver_id As Long, ByVal ivehicle_number As String, ByVal ido_no_count As Long, ByVal ioverride_card As Long, ByVal icard_reader_id As Long, ByVal idatetime_active As String, ByVal ij_user As String, ByVal ij_computer As String) As Boolean
        Dim bRet As Boolean = False
        Dim sql_str As String
        Dim ido_no_list As String
        Dim vLoadNo As String
        ido_no_list = txtDo.Text
        sql_str = "BEGIN "
        sql_str = sql_str & " LOAD.REGISTOR_CREATE_LOAD("
        sql_str = sql_str & itu_card_no & "," & ituID1 & "," & ituID2 & "," & idriver_id & ",'" & ivehicle_number & "',"
        sql_str = sql_str & ido_no_count & " ,'" & ido_no_list & "',1," & icard_reader_id & " ,"
        sql_str = sql_str & " to_date('" & idatetime_active & "','DD/MM/YYYY HH24:MI:SS') ,"
        sql_str = sql_str & "'" & ij_user & "','" & ij_computer & "',"
        sql_str = sql_str & ":ret_load_no,:ret_check,:ret_msg); "
        sql_str = sql_str & "END;"

        Dim Oraparam As New COraParameter
        Dim RET_LOAD_NO As Object
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_LOAD_NO", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_CHECK", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With

        If Oradb.ExeSQL(sql_str, Oraparam) Then
            RET_LOAD_NO = Oraparam.GetOraclParamValue("RET_LOAD_NO")
            RET_CHECK = Oraparam.GetOraclParamValue("RET_CHECK")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            If RET_CHECK >= 0 Then
                vLoadNo = RET_LOAD_NO.ToString()
                If SaveSeal(Trim(vLoadNo), 1, Trim(txtSealNumber.Text), 1) Then
                    Call UpdateSealLoadHeader(vLoadNo)
                    Call UpdateSealControl(vLoadNo)
                    txtSealNumber.Text = ""
                End If
                'If MsgBox("สร้างการจ่ายของรถทะเบียน  " & Mid(cbTUHead.Text, InStr(1, cbTUHead.Text, "--") + 1, Len(cbTUHead)) & " เรียบร้อยแล้ว" _
                '     & vbCrLf & vbCrLf & "ต้องการพิมพ์ใบแนะนำการเติมหรือไม่ ?", vbInformation + vbYesNo) = vbYes Then
                If MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว ต้องการพิมพ์ใบแนะนำการเติมหรือไม่ ?", vbInformation + vbYesNo) = vbYes Then
                    PrintReport(vLoadNo)
                End If
                bRet = True
            Else

                MsgBox(RET_MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                'Oraparam.RemoveOracleParam()
                'Oraparam = Nothing
                'Return bRet
                bRet = False
            End If
            'Call SaveRegCreateLoad(itu_card_no, ituID1, ituID2, idriver_id, ivehicle_number, ido_no_count, ioverride_card, icard_reader_id, idatetime_active, ij_user, ij_computer)
            'bRet = True
        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function

    Private Function SaveSeal(ByVal iLoad_no As String, ByVal iauto_seal As Long, ByVal iseal_number As String, ByVal ioverride_card As Long) As Boolean
        Dim bRet As Boolean = False
        Dim sql_str As String
        sql_str = "BEGIN "
        sql_str = sql_str & " LOAD.REGISTOR_UPDATE_SEAL ('"
        sql_str = sql_str & iLoad_no & "'," & iauto_seal & ",'"
        sql_str = sql_str & iseal_number & "', "
        sql_str = sql_str & ioverride_card & ",sysdate ,"
        sql_str = sql_str & "'" & mUserName & "','" & mComputerName & "',"
        sql_str = sql_str & ":ret_check,:ret_msg); "
        sql_str = sql_str & "END;"


        Dim Oraparam As New COraParameter
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_CHECK", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With

        If Oradb.ExeSQL(sql_str, Oraparam) Then
            RET_CHECK = Oraparam.GetOraclParamValue("RET_CHECK")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            If RET_CHECK <> 0 Then
                MsgBox(RET_MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                Oraparam.RemoveOracleParam()
                Oraparam = Nothing
                Return bRet
            End If
            MsgBox(RET_MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            bRet = True
        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function

#End Region

    Private Sub UpdateSealLoadHeader(ByVal ILoadNo As String)
        Dim strSQL As String

        'strSQL = _
        '                " Update tas.oil_load_headers t set  t.Seal_use= " & SealCount & "," & _
        '                " t.seal_number='" & Trim(txtSealNumber) & "'" & _
        '                "  Where t.load_header_no='" & ILoadNo & "'"
        'ExecuteSQL(strSQL)
    End Sub

    Private Sub UpdateSealControl(ByVal ILoadNo As String)
        Dim strSQL As String
        Dim StrTmp() As String
        Dim str1 As String
        Dim str2 As String


        'strSQL = _
        '                "Update tas.seal_control t SET t.load_last_no='" & Trim(ILoadNo) & "' ," & _
        '                " t.seal_no='" & Trim(SealLast) & "'" & _
        '                " Where t.id=1 "
        'ExecuteSQL(strSQL)
    End Sub

    Private Sub PrintReport(ByVal pLoadNo As Long)

        Dim rptFileName As String

        Try
            rptFileName = GetReportFileName(52010029)
            
            With frmrptShowReport
                .mRptFileName = rptFileName
                .mParameter = pLoadNo
                '.ShowReport(strSQL)
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GetDriver()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim tmpTransUnit() As String
        Dim tmp1 As String

        If cbTUHead.Text = "" Then Exit Sub
        tmpTransUnit = Split(cbTUHead.Text, "-")
        tmp1 = Trim(tmpTransUnit(1))

        sql_str = " SELECT V.VEHICLE_NUMBER ,DM.DRIVER_ID ,D.FIRST_NAME ,D.LAST_NAME ,D.FIRST_NAME ||' '|| D.LAST_NAME ||' _'||D.DRIVER_ID AS DRIVER "
        sql_str = sql_str & " FROM TAS.VEHICLE V, TAS.DRIVER_MAPPING DM, TAS.DRIVER D, TAS.OIL_LOAD_HEADERS OH "
        sql_str = sql_str & " WHERE V.VEHICLE_NUMBER = DM.VEHICLE_NUMBER "
        sql_str = sql_str & " AND D.DRIVER_ID = DM.DRIVER_ID AND V.VEHICLE_NUMBER = OH.VEHICLE_NUMBER(+) AND D.DRIVER_ID = OH.DRIVER_ID AND OH.CANCEL_STATUS=0 "
        sql_str = sql_str & " AND V.TU_NUMBER='" & tmp1 & "'   ORDER BY OH.CREATION_DATE  DESC "

        cbDriverBil.Text = ""

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                cbDriverBil.Text = IIf(IsDBNull(dt.Rows(i).Item("DRIVER")), "", dt.Rows(i).Item("DRIVER").ToString)
                TxtDriverName.Text = IIf(IsDBNull(dt.Rows(i).Item("FIRST_NAME")), "", dt.Rows(i).Item("FIRST_NAME").ToString)
                TxtDriverSurname.Text = IIf(IsDBNull(dt.Rows(i).Item("LAST_NAME")), "", dt.Rows(i).Item("LAST_NAME").ToString)
                'drivID = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_ID")), "", dt.Rows(i).Item("DRIVER_ID").ToString)
            End If

        End If
        mDataSet = Nothing
    End Sub

    Private Sub GetTuTail()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim tmpTransUnit() As String
        Dim tmp1 As String
        Dim tmp2 As String = ""
        cbTail.Text = ""
        If cbTUHead.Text = "" Then Exit Sub
        tmpTransUnit = Split(cbTUHead.Text, " - ")
        tmp1 = Trim(tmpTransUnit(1))

        sql_str = " SELECT  T.TU_NUMBER1 FROM VEHICLE T"
        sql_str = sql_str & " WHERE T.TU_NUMBER = '" & tmp1 & "'  ORDER BY T.CREATION_DATE DESC"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                tmp2 = IIf(IsDBNull(dt.Rows(i).Item("TU_NUMBER1")), "", dt.Rows(i).Item("TU_NUMBER1").ToString)
            End If
        End If

        If tmp2 = "" Then Exit Sub

        sql_str = " SELECT T.TU_ID,T.TU_NUMBER,T.TU_ID||' - '||T.TU_NUMBER AS TUNAME "
        sql_str = sql_str & " FROM TAS.TRANSPORT_UNIT T "
        sql_str = sql_str & " WHERE T.TU_NUMBER = '" & tmp2 & "' "

        cbTail.Text = ""
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            cbTail.Text = IIf(IsDBNull(dt.Rows(i).Item("TUNAME")), "", dt.Rows(i).Item("TUNAME").ToString)
        End If

        mDataSet = Nothing
    End Sub

    Private Sub b_AddDo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmLoadDoList.frm_Request_txtdo = 1
        frmLoadDoList.Show()
    End Sub

    Private Sub b_cmdCalSeal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmUtlAddSeal.frm_Request = 1
        frmUtlAddSeal.txtSealAmount.Text = GetSealCount()
        frmUtlAddSeal.Show()
    End Sub

    Private Sub CbVehicleCard_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbVehicleCard.SelectedIndexChanged
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        If CbVehicleCard.Text = "" Then Exit Sub

        If frm_work = 5 Then
            sql_str = "SELECT O.LOAD_HEADER_NO ,O.SHIPMENT_NO,"
            sql_str = sql_str & " O.TU_CARD_NO,O.DRIVER_ID,O.TU_ID,O.TU_ID1,O.TU_CARD_NO1,O.TU_NUMBER1,O.DRIVER_NAME "
            sql_str = sql_str & " FROM TAS.OIL_LOAD_HEADERS O "
            sql_str = sql_str & " WHERE O.TU_CARD_NO = " & CbVehicleCard.Text & " AND O.CANCEL_STATUS=0  "
            sql_str = sql_str & " AND O.LOAD_STATUS IN (54,55,71)"
        Else
            sql_str = "SELECT O.LOAD_HEADER_NO ,O.SHIPMENT_NO,"
            sql_str = sql_str & " O.TU_CARD_NO,O.DRIVER_ID,O.TU_ID,O.TU_ID1,O.TU_CARD_NO1,O.TU_NUMBER1,O.DRIVER_NAME "
            sql_str = sql_str & " FROM TAS.OIL_LOAD_HEADERS O  , TAS.OIL_LOAD_ENTRYCARD C "
            sql_str = sql_str & " WHERE  O.LOAD_HEADER_NO = C.LOAD_HEADER_NO  AND  C.TU_CARD_NO=" & CbVehicleCard.Text & " AND O.LOAD_STATUS=13  AND O.CANCEL_STATUS=0  "
        End If

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                txtVehicleName.Text = IIf(IsDBNull(dt.Rows(i).Item("TU_ID")), "", dt.Rows(i).Item("TU_ID").ToString)
                txtTuName.Text = IIf(IsDBNull(dt.Rows(i).Item("TU_ID1")), "", dt.Rows(i).Item("TU_ID1").ToString)
                txtGateDriverName.Text = dt.Rows(i).Item("DRIVER_ID").ToString & " " & dt.Rows(i).Item("DRIVER_NAME").ToString
                txtGateShipment.Text = IIf(IsDBNull(dt.Rows(i).Item("SHIPMENT_NO")), "", dt.Rows(i).Item("SHIPMENT_NO").ToString)
                txtGateLoad.Text = IIf(IsDBNull(dt.Rows(i).Item("LOAD_HEADER_NO")), "", dt.Rows(i).Item("LOAD_HEADER_NO").ToString)
            Else
                txtVehicleName.Text = ""
                txtTuName.Text = ""
                txtGateDriverName.Text = ""
                txtGateShipment.Text = ""
                txtGateLoad.Text = ""
            End If
        End If
        mDataSet = Nothing
    End Sub

    Private Sub CbBayVehicleId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbBayVehicleId.SelectedIndexChanged
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        If CbBayVehicleId.Text = "" Then Exit Sub

        sql_str = "SELECT O.LOAD_HEADER_NO ,O.SHIPMENT_NO,"
        sql_str = sql_str & " O.TU_CARD_NO,O.DRIVER_ID,O.TU_ID,O.TU_ID1,O.TU_CARD_NO1,O.TU_NUMBER1,O.DRIVER_NAME "
        sql_str = sql_str & " FROM TAS.OIL_LOAD_HEADERS O "
        sql_str = sql_str & " WHERE O.TU_CARD_NO = " & CbBayVehicleId.Text & " AND O.CANCEL_STATUS=0  "
        sql_str = sql_str & " AND O.LOAD_STATUS IN (21,31,54)"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                txtBayVehicle.Text = IIf(IsDBNull(dt.Rows(i).Item("TU_ID")), "", dt.Rows(i).Item("TU_ID").ToString)
                txtBayTu.Text = IIf(IsDBNull(dt.Rows(i).Item("TU_ID1")), "", dt.Rows(i).Item("TU_ID1").ToString)
                txtBayDriverCard.Text = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_ID")), "", dt.Rows(i).Item("DRIVER_ID").ToString)
                txtBayDriverName.Text = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_NAME")), "", dt.Rows(i).Item("DRIVER_NAME").ToString)
                txtBayShipment.Text = IIf(IsDBNull(dt.Rows(i).Item("SHIPMENT_NO")), "", dt.Rows(i).Item("SHIPMENT_NO").ToString)
                txtBayLoadNo.Text = IIf(IsDBNull(dt.Rows(i).Item("LOAD_HEADER_NO")), "", dt.Rows(i).Item("LOAD_HEADER_NO").ToString)
            Else
                txtBayVehicle.Text = ""
                txtBayTu.Text = ""
                txtBayDriverCard.Text = ""
                txtBayDriverName.Text = ""
                txtBayShipment.Text = ""
                txtBayLoadNo.Text = ""
            End If
        End If
        mDataSet = Nothing
    End Sub

    Private Sub CbBayCancelVehicleId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbBayCancelVehicleId.SelectedIndexChanged
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        If CbBayCancelVehicleId.Text = "" Then Exit Sub

        sql_str = "SELECT O.LOAD_HEADER_NO ,O.SHIPMENT_NO,"
        sql_str = sql_str & " O.TU_CARD_NO,O.DRIVER_ID,O.TU_ID,O.TU_ID1,O.TU_CARD_NO1,O.TU_NUMBER1,O.DRIVER_NAME "
        sql_str = sql_str & " FROM TAS.OIL_LOAD_HEADERS O "
        sql_str = sql_str & " WHERE O.TU_CARD_NO = " & CbBayCancelVehicleId.Text & " AND O.CANCEL_STATUS=0  "
        sql_str = sql_str & " AND O.LOAD_STATUS IN (51,52,53)"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                txtBayCancelVehicle.Text = IIf(IsDBNull(dt.Rows(i).Item("TU_ID")), "", dt.Rows(i).Item("TU_ID").ToString)
                txtBayCancelTu.Text = IIf(IsDBNull(dt.Rows(i).Item("TU_ID1")), "", dt.Rows(i).Item("TU_ID1").ToString)
                txtBayCancelDriverCard.Text = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_ID")), "", dt.Rows(i).Item("DRIVER_ID").ToString)
                txtBayCancelName.Text = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_NAME")), "", dt.Rows(i).Item("DRIVER_NAME").ToString)
                txtBayCancelShipment.Text = IIf(IsDBNull(dt.Rows(i).Item("SHIPMENT_NO")), "", dt.Rows(i).Item("SHIPMENT_NO").ToString)
                txtBayCancelLoad.Text = IIf(IsDBNull(dt.Rows(i).Item("LOAD_HEADER_NO")), "", dt.Rows(i).Item("LOAD_HEADER_NO").ToString)
            Else
                txtBayCancelVehicle.Text = ""
                txtBayCancelTu.Text = ""
                txtBayCancelDriverCard.Text = ""
                txtBayCancelName.Text = ""
                txtBayCancelShipment.Text = ""
                txtBayCancelLoad.Text = ""
            End If
        End If

        sql_str = "SELECT B.BAY_NO,B.BAY_NAME,B.ISLAND_NO "
        sql_str = sql_str & " FROM TAS.BAY B "
        sql_str = sql_str & " WHERE B.LAST_LOAD_NO=" & txtBayCancelLoad.Text
        sql_str = sql_str & " AND B.BAY_ACTIVE=1 "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                CmbBayCancel.Text = dt.Rows(i).Item("BAY_NO").ToString & "    " & dt.Rows(i).Item("ISLAND_NO").ToString
            End If
        End If

        mDataSet = Nothing
    End Sub


    Private Sub UcMenub_Billing_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMenub_Billing.OnClickMnuText
        Visible_Menu_Sub()
        ClearDataBilling()
        InitialCombo(1)
        CbCrId.SelectedIndex = 0
        frm_work = 1
        Group_Billing.Visible = True
        Group_Billing.Text = UcMenub_Billing.MenuText
    End Sub

    Private Sub UcMenub_Gate_IN_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMenub_Gate_IN.OnClickMnuText
        Visible_Menu_Sub()
        ClearDataGate()
        InitialCombo(2)
        frm_work = 2
        Group_Gate.Visible = True
        Group_Gate.Text = UcMenub_Gate_IN.MenuText
    End Sub

    Private Sub UcMenub_BAY_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMenub_BAY.OnClickMnuText
        Visible_Menu_Sub()
        ClearDataBay()
        InitialCombo(3)
        frm_work = 3
        Group_Bay.Visible = True
        Group_Bay.Text = UcMenub_BAY.MenuText
    End Sub

    Private Sub UcMenub_BAY_Cancel_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMenub_BAY_Cancel.OnClickMnuText
        Visible_Menu_Sub()
        ClearDataBayCancel()
        InitialCombo(4)
        frm_work = 4
        Group_BayCancel.Visible = True
        Group_BayCancel.Text = UcMenub_BAY_Cancel.MenuText
    End Sub

    Private Sub UcMenub_Gate_OUT_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMenub_Gate_OUT.OnClickMnuText
        Visible_Menu_Sub()
        ClearDataGate()
        InitialCombo(5)
        frm_work = 5
        Group_Gate.Visible = True
        Group_Gate.Text = UcMenub_Gate_OUT.MenuText
    End Sub

    Private Sub UcMenub_Save_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMenub_Save.OnClickMnuText
        Select Case frm_work
            Case 1 : ProcessBilling()
            Case 2 : ProcessGate()
            Case 3 : ProcessBayIn()
            Case 4 : ProcessCancelBay()
            Case 5 : ProcessGate()
        End Select
        Visible_Menu_Sub()
    End Sub

    Private Sub UcMenub_Cancel_OnClickMnuText(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMenub_Cancel.OnClickMnuText
        Visible_Menu_Sub()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PrintReport(510176158)
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