

Imports Oracle.DataAccess.Client
Imports System.Data
Public Class frmMMIWeighBridge
    Public FormScreenID As Long

    Dim ChkScanData As Integer
    Dim bScan As Boolean
    Dim FramOld As Integer
    Const MAX_BAY = 4
    Const MAX_ISLAND = 2
    Const WEIGHT_ID = 7100301
    Dim checkIniPrgress(MAX_BAY - 1) As Boolean

    Dim frm_work As Integer = 0  '1=add ,2=Edit
    Private Sub frmLoadDO_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub
    Private Sub frmMMIWeighBridge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()

        Dim i As Integer
        'Call InitializeForm(Me, 3, "Weigh Bridge")

        bScan = True
        FrameAcive(0)
        FrameFireAcive(0)
        ClearText()
        tTimeScan.Interval = 3000
        tTimeScan.Enabled = True
        ChkScanData = 0
        FramOld = 0

        resolution(Me, 1)

    End Sub
    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub
    Private Sub GetWeight(ByVal iWightId As String)
        Dim strSQL As String
        strSQL = _
                  " select  t.WEIGHT_VALUE " & _
                  " from steqi.view_weight_value   t " & _
                  " where t.WEIGHT_BRIDGE_ID ='" & Trim(iWightId) & "'" & _
                  " order by  t.WEIGHT_BRIDGE_ID "

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim j = 0
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > j Then
               If dt.Rows.Count > j Then
                    lblWeightValue.Text = "น้ำหนักเครื่องชั่ง :   " & IIf(IsDBNull(dt.Rows(j).Item("WEIGHT_VALUE")), "??", dt.Rows(j).Item("WEIGHT_VALUE").ToString) & " Kg"
                End If

            End If
        End If
        mDataSet = Nothing
    End Sub

    Private Sub FrameAcive(ByVal indexFrame As Integer)
        aniWeightBridge.Image = My.Resources.ResourceManager.GetObject("WeightBridge_" & indexFrame)
    End Sub

    Private Sub FrameFireAcive(ByVal indexFrame As Integer)
        'AniFire.Frame = 0
        AniFire.Image = My.Resources.ResourceManager.GetObject("trafficWeight_0")
        'AniFire.Stop()
        If indexFrame = 3 Then
            'AniFire.Frame = 2
            AniFire.Image = My.Resources.ResourceManager.GetObject("trafficWeight_2")
        End If
        If indexFrame = 0 Then
            'AniFire.Frame = 2
            AniFire.Image = My.Resources.ResourceManager.GetObject("trafficWeight_2")
        End If
        'AniFire.Frame = indexFrame

        AniFire.Image = My.Resources.ResourceManager.GetObject("trafficWeight_" & indexFrame)
        'trafficWeight_0
    End Sub

    Private Sub ClearText()
        txtLoadNo.Text = ""
        txtVechicleCardNo.Text = ""
        txtVechicleCardNo.Text = ""
        txtDriver.Text = ""
        txtTypeTruck.Text = ""
        txtCarrier.Text = ""
        txtSeal.Text = ""
        txtCarExp.Text = ""
        txtTareWeight.Text = ""
        txtWeightTuchCard.Text = ""
        txtWeightOut.Text = ""
        lblTypeWeight.Text = lblTypeWeight.Text & " "
    End Sub

    Private Sub GetDataWeight()
        Dim strSQL = _
                        " select " & _
                        " load_header_no, vehicle_card_no, vehicle_name, driver_name, " & _
                        " veicle_type,carrier_name, seal_count, seal_number, tare_weight, " & _
                        " vehicle_expire , weight_wipe_card, weight_type, card_reader_name,WEIGHT_TYPE" & _
                        " from  gac.tmp_dataweight t "
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim j = 0
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > j Then

                lblTypeWeight.Text = ""
                ChkScanData = 1
                txtLoadNo.Text = IIf(IsDBNull(dt.Rows(j).Item("LOAD_HEADER_NO")), "", dt.Rows(j).Item("LOAD_HEADER_NO").ToString)
                txtVechicleCardNo.Text = IIf(IsDBNull(dt.Rows(j).Item("vehicle_card_no")), "", dt.Rows(j).Item("vehicle_card_no").ToString)
                txtVechicle.Text = IIf(IsDBNull(dt.Rows(j).Item("vehicle_name")), "", dt.Rows(j).Item("vehicle_name").ToString)
                txtDriver.Text = IIf(IsDBNull(dt.Rows(j).Item("driver_name")), "", dt.Rows(j).Item("driver_name").ToString)
                txtTypeTruck.Text = IIf(IsDBNull(dt.Rows(j).Item("veicle_type")), "", dt.Rows(j).Item("veicle_type").ToString)
                txtCarrier.Text = IIf(IsDBNull(dt.Rows(j).Item("Carrier_name")), "", dt.Rows(j).Item("Carrier_name").ToString)
                txtSeal.Text = IIf(IsDBNull(dt.Rows(j).Item("seal_count")), "", dt.Rows(j).Item("seal_count").ToString)
                txtCarExp.Text = IIf(IsDBNull(dt.Rows(j).Item("vehicle_expire")), "", dt.Rows(j).Item("vehicle_expire").ToString)
                txtTareWeight.Text = IIf(IsDBNull(dt.Rows(j).Item("tare_weight")), "", dt.Rows(j).Item("tare_weight").ToString)
                txtWeightTuchCard.Text = IIf(IsDBNull(dt.Rows(j).Item("weight_wipe_card")), "", dt.Rows(j).Item("weight_wipe_card").ToString)

                lblTypeWeight.Text = IIf(IsDBNull(dt.Rows(j).Item("WEIGHT_TYPE") = 1), "ชั่งเข้า", "ชั่งออก")
                If IIf(IsDBNull(dt.Rows(j).Item("WEIGHT_TYPE")), 0, dt.Rows(j).Item("WEIGHT_TYPE")) = 1 Then
                    txtWeightOut.Text = ""
                    txtWeightTuchCard.Text = IIf(IsDBNull(dt.Rows(j).Item("weight_wipe_card")), "", dt.Rows(j).Item("weight_wipe_card").ToString)
                Else
                    txtWeightTuchCard.Text = ""
                    txtWeightTuchCard.Text = GetWeightIn(Trim(txtLoadNo.Text))
                    txtWeightOut.Text = IIf(IsDBNull(dt.Rows(j).Item("weight_wipe_card")), "", dt.Rows(j).Item("weight_wipe_card").ToString)
                End If

            End If
        End If
        mDataSet = Nothing
    End Sub
    Private Function GetWeightIn(ByVal iLoad_no As String) As String

        GetWeightIn = ""
        If iLoad_no = "" Then Exit Function
        Dim strSQL = _
                     " select  t.weight_in  from tas.oil_load_headers t " & _
                     " where t.load_header_no ='" & Trim(iLoad_no) & "' "

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim j = 0
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > j Then
                GetWeightIn = IIf(IsDBNull(dt.Rows(j).Item("weight_in")), "", dt.Rows(j).Item("weight_in").ToString)
            End If
        End If
        mDataSet = Nothing
    End Function
    Private Sub tTimeScan_Timer()
        If bScan Then
            GetWeight(WEIGHT_ID)
            GetStatusInfared(WEIGHT_ID)
            GetStatusFire(WEIGHT_ID)
            If ChkScanData = 0 Then
                GetDataWeight()
            End If
        End If
    End Sub

    Private Sub GetStatusInfared(ByVal WeightId As String)
        Dim strSQL = _
                    " select  t.INFRARED_1 , t.INFRARED_2 ,t.INFRARED_3 ,t.INFRARED_STATUS " & _
                    " from steqi.view_wb_infrared t " & _
                    " where t.WEIGHT_BRIDGE_ID ='" & Trim(WeightId) & "'"
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim j = 0
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > j Then
                FrameAcive(GetPosCar(IIf(IsDBNull(dt.Rows(j).Item("INFRARED_3")), 0, dt.Rows(j).Item("INFRARED_3")), IIf(IsDBNull(dt.Rows(j).Item("INFRARED_2")), 0, dt.Rows(j).Item("INFRARED_2")), IIf(IsDBNull(dt.Rows(j).Item("INFRARED_1")), 0, dt.Rows(j).Item("INFRARED_1"))))
                j = j + 1
            End If
        End If
        mDataSet = Nothing
    End Sub


    Private Function GetPosCar(ByVal iPos1 As Integer, ByVal iPos2 As Integer, ByVal iPos3 As Integer) As Integer
        Dim vNumber As Integer
        If (iPos1 = 0) And (iPos2 = 0) And (iPos3 = 0) Then
            vNumber = 0
            ChkScanData = 0
        End If
        If (iPos1 = 0) And (iPos2 = 0) And (iPos3 = 1) Then
            vNumber = 5
        End If
        If (iPos1 = 0) And (iPos2 = 1) And (iPos3 = 0) Then
            vNumber = 3
            ChkScanData = 0
        End If
        If (iPos1 = 0) And (iPos2 = 1) And (iPos3 = 1) Then
            vNumber = 4
        End If
        If (iPos1 = 1) And (iPos2 = 0) And (iPos3 = 0) Then
            vNumber = 1
        End If
        If (iPos1 = 1) And (iPos2 = 0) And (iPos3 = 1) Then
            vNumber = 1
        End If
        If (iPos1 = 1) And (iPos2 = 1) And (iPos3 = 0) Then
            vNumber = 2
        End If
        If (iPos1 = 1) And (iPos2 = 1) And (iPos3 = 1) Then
            vNumber = 3
        End If

        Return vNumber
    End Function


    Private Sub GetStatusFire(ByVal WeightId As String)
        Dim strSQL = _
                " select  t.LAMP1_STATUS , t.LAMP2_STATUS  " & _
                " from steqi.view_wb_infrared t " & _
                " where t.WEIGHT_BRIDGE_ID ='" & Trim(WeightId) & "'"
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim j = 0
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > j Then
                FrameFireAcive(TakeFireGreenYew(IIf(IsDBNull(dt.Rows(j).Item("LAMP2_STATUS")), 0, CType(dt.Rows(j).Item("LAMP2_STATUS"), Integer)), IIf(IsDBNull(dt.Rows(j).Item("LAMP1_STATUS")), 0, CType(dt.Rows(j).Item("LAMP1_STATUS"), Integer))))
            End If
        End If
        mDataSet = Nothing
    End Sub


    Private Function TakeFireGreenYew(ByVal iPos1 As Integer, ByVal iPos2 As Integer) As Integer
        Dim vNumber As Integer
        If (iPos1 = 0) And (iPos2 = 0) Then
            vNumber = 0
        End If
        If (iPos1 = 1) And (iPos2 = 0) Then
            vNumber = 1
        End If
        If (iPos1 = 0) And (iPos2 = 1) Then
            vNumber = 2
        End If
        If (iPos1 = 1) And (iPos2 = 1) Then
            vNumber = 3
        End If
        Return vNumber
    End Function

    Private Sub AniFire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMMIwbLampTest.GetWeightID(WEIGHT_ID)
        frmMMIwbLampTest.Show()
    End Sub

    Private Sub tTimeScan_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tTimeScan.Tick
        tTimeScan_Timer()
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