Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Drawing.Printing

Module mFunction

    Public AlarmMssg As String
    Public Function GetComputerName() As String
        Dim ComputerName As String
        ComputerName = System.Net.Dns.GetHostName
        Return ComputerName
    End Function
    Private Sub GetScreenResolution(ByRef pHeight As Integer, ByRef pWidth As Integer)
        Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height

        pHeight = intY
        pWidth = intX
    End Sub

    Public Sub SetScreenResulotion()
        'fSize.Height = SystemParameters.PrimaryScreenHeight
        'fSize.Width = SystemParameters.PrimaryScreenWidth
        Dim value As String
        Dim sfilename As String
        Try


            sfilename = GetCurrDirectory() & "/config.ini"
            If My.Computer.FileSystem.FileExists(sfilename) Then
                'fSize.Height = 768
                'fSize.Width = 1024
                value = mIni.INIRead(sfilename, "ScreenResolution", "Height")
                If value = "default" Then
                    GetScreenResolution(fSize.Height, fSize.Width)
                Else
                    fSize.Height = Convert.ToSingle(value)
                End If

                value = mIni.INIRead(sfilename, "ScreenResolution", "Width")
                If value = "default" Then
                    GetScreenResolution(fSize.Height, fSize.Width)
                Else
                    fSize.Width = Convert.ToSingle(value)
                End If
            Else
                GetScreenResolution(fSize.Height, fSize.Width)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function GetCurrDirectory() As String
        Dim sDirectory As String
        sDirectory = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName 'Environment.CurrentDirectory()

        Return sDirectory
    End Function

    Public Function GetStatusDatabase() As Boolean
        Return Oradb.ConnectStatus
    End Function

    Public Function GetCurrentMenu() As String
        Dim sMenu As String
        For Each s As String In mMenuStack
            sMenu = Convert.ToString(s) & " \ " & sMenu
        Next
        sMenu = sMenu.Trim()
        sMenu = sMenu.Substring(0, sMenu.Length - 1)
        Return sMenu
    End Function

    Public Function GetReportFileName(ByVal pReportID As Double) As String
        Dim strSQL As String = "select t.REPORT_PATH,t.IS_ENABLED" &
                             " from REPORT_SETTING t" &
                             " where t.REPORT_ID=" & pReportID

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim bRet As String = ""
        If Oradb.OpenDys(strSQL, "TableName", mDataSet) Then
            dt = mDataSet.Tables("TableName")
            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("IS_ENABLED") = 1 Then
                    bRet = dt.Rows(0).Item("REPORT_PATH").ToString
                Else
                    MsgBox("รายงานหมายเลข " & pReportID & " หยุดใช้งาน", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("ไม่พบข้อมูลรายงานหมายเลข " & pReportID, MsgBoxStyle.Information)
            End If
        End If
        Return bRet
    End Function

    Public Sub PushForm(ByVal pF As Form)
        mForm.Push(pF)
    End Sub

    Public Sub PopForm()
        Dim f As Form

        mMenuStack.Pop()
        f = mForm.Pop
        'f.Visible = False
        f.ShowInTaskbar = True
        f.Show()
        f.WindowState = FormWindowState.Normal
        'f.Visible = True
    End Sub

    Public Function OpenForm(ByVal pScreenID As Int16, ByVal pTitleName As String) As Boolean
        Try
            mScreenID = pScreenID
            Select Case pScreenID
                Case 100
                    mMenuStack.Push(pTitleName)
                    frmMasterData.Show()
                    frmMasterData.FormScreenID = pScreenID
                    frmMasterData.lblTitleName.Text = GetCurrentMenu()
                    Return True
                Case 101
                    'PushForm(frmMasterData)
                    mMenuStack.Push(pTitleName)
                    frmConfigBaseProduct_main.Show()
                    frmConfigBaseProduct_main.FormScreenID = pScreenID
                    frmConfigBaseProduct_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 102
                    mMenuStack.Push(pTitleName)
                    frmConfigTank_main.Show()
                    frmConfigTank_main.FormScreenID = pScreenID
                    frmConfigTank_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 103
                    mMenuStack.Push(pTitleName)
                    frmConfigSaleProduct_main.Show()
                    frmConfigSaleProduct_main.FormScreenID = pScreenID
                    frmConfigSaleProduct_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 104
                    mMenuStack.Push(pTitleName)
                    frmConfigIsland_main.Show()
                    frmConfigIsland_main.FormScreenID = pScreenID
                    frmConfigIsland_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 105
                    mMenuStack.Push(pTitleName)
                    frmConfigPump_main.Show()
                    frmConfigPump_main.FormScreenID = pScreenID
                    frmConfigPump_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 106
                    mMenuStack.Push(pTitleName)
                    frmConfigMeter_main.Show()
                    frmConfigMeter_main.FormScreenID = pScreenID
                    frmConfigMeter_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 107
                    mMenuStack.Push(pTitleName)
                    frmConfigBay_main.Show()
                    frmConfigBay_main.FormScreenID = pScreenID
                    frmConfigBay_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 108
                    mMenuStack.Push(pTitleName)
                    frmConfigReportSetting_main.Show()
                    frmConfigReportSetting_main.FormScreenID = pScreenID
                    frmConfigReportSetting_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 109
                    mMenuStack.Push(pTitleName)
                    frmConfigReportHeaders_main.Show()
                    frmConfigReportHeaders_main.FormScreenID = pScreenID
                    frmConfigReportHeaders_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 110
                    mMenuStack.Push(pTitleName)
                    frmConfigCardReader_main.Show()
                    frmConfigCardReader_main.FormScreenID = pScreenID
                    frmConfigCardReader_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 111
                    mMenuStack.Push(pTitleName)
                    frmConfigPrinters_main.Show()
                    frmConfigPrinters_main.FormScreenID = pScreenID
                    frmConfigPrinters_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 112
                    mMenuStack.Push(pTitleName)
                    frmConfigCommport_main.Show()
                    frmConfigCommport_main.FormScreenID = pScreenID
                    frmConfigCommport_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True

                Case 200
                    'mMenuStack.Push(pTitleName)
                    'frmLoadingSystem.Show()
                    'frmLoadingSystem.FormScreenID = pScreenID
                    'frmLoadingSystem.lblTitleName.Text = GetCurrentMenu()
                    'Return True
                Case 201
                    mMenuStack.Push(pTitleName)
                    frmProofJournal.Show()
                    frmProofJournal.FormScreenID = pScreenID
                    frmProofJournal.UcHeader1.MenuText = GetCurrentMenu()
                    'frmProofJournal.WindowState = FormWindowState.Normal
                    Return True
                Case 202
                    mMenuStack.Push(pTitleName)
                    frmProofQueue.Show()
                    frmProofQueue.FormScreenID = pScreenID
                    frmProofQueue.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 203
                    mMenuStack.Push(pTitleName)
                    frmProofLoading.Show()
                    frmProofLoading.FormScreenID = pScreenID
                    frmProofLoading.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 204
                    mMenuStack.Push(pTitleName)
                    frmProofLoadIncomplete.Show()
                    frmProofLoadIncomplete.FormScreenID = pScreenID
                    frmProofLoadIncomplete.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 205
                    mMenuStack.Push(pTitleName)
                    frmProofLoadingComplete.Show()
                    frmProofLoadingComplete.FormScreenID = pScreenID
                    frmProofLoadingComplete.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 206
                    mMenuStack.Push(pTitleName)
                    frmProofSendDataErp.Show()
                    frmProofSendDataErp.FormScreenID = pScreenID
                    frmProofSendDataErp.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 207
                    mMenuStack.Push(pTitleName)
                    frmProofSAPTAS.Show()
                    frmProofSAPTAS.FormScreenID = pScreenID
                    frmProofSAPTAS.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 208
                    mMenuStack.Push(pTitleName)
                    frmProofSumOrder.Show()
                    frmProofSumOrder.FormScreenID = pScreenID
                    frmProofSumOrder.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 209
                    mMenuStack.Push(pTitleName)
                    frmProofMonitorTank.Show()
                    frmProofMonitorTank.FormScreenID = pScreenID
                    frmProofMonitorTank.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 210
                    'mMenuStack.Push(pTitleName)
                    frmDeviceEven.Show()
                    'Return True

                Case 301
                    frmMMINetworkStatus.Close()
                    mMenuStack.Push(pTitleName)
                    frmMMINetworkStatus.FormScreenID = pScreenID
                    frmMMINetworkStatus.ShowDialog()
                    'frmMMINetwork.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 302
                    mMenuStack.Push(pTitleName)
                    frmMMITank.Show()
                    frmMMITank.FormScreenID = pScreenID
                    frmMMITank.UcHeader1.MenuText = GetCurrentMenu()
                    'frmMMITank.WindowState = FormWindowState.Normal
                    Return True
                Case 303
                    mMenuStack.Push(pTitleName)
                    frmMMIOverView.Show()
                    frmMMIOverView.FormScreenID = pScreenID
                    frmMMIOverView.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 304
                    mMenuStack.Push(pTitleName)
                    frmMMIBayLoading.Show()
                    frmMMIBayLoading.FormScreenID = pScreenID
                    frmMMIBayLoading.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 305
                    mMenuStack.Push(pTitleName)
                    frmMMIPumpReceive.Show()
                    frmMMIPumpReceive.FormScreenID = pScreenID
                    frmMMIPumpReceive.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 306
                    mMenuStack.Push(pTitleName)
                    frmMMIPumpBay.Show()
                    frmMMIPumpBay.FormScreenID = pScreenID
                    frmMMIPumpBay.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 307
                    mMenuStack.Push(pTitleName)
                    frmMMIPlantLayout.Show()
                    frmMMIPlantLayout.FormScreenID = pScreenID
                    frmMMIPlantLayout.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 308
                    mMenuStack.Push(pTitleName)
                    frmMMIMonitorMeter.Show()
                    frmMMIMonitorMeter.FormScreenID = pScreenID
                    frmMMIMonitorMeter.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 309
                    mMenuStack.Push(pTitleName)
                    frmMMIProcessFlowTLB.Show()
                    frmMMIProcessFlowTLB.FormScreenID = pScreenID
                    frmMMIProcessFlowTLB.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 310
                    mMenuStack.Push(pTitleName)
                    frmMMIWeighBridge.Show()
                    frmMMIWeighBridge.FormScreenID = pScreenID
                    frmMMIWeighBridge.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 311
                    mMenuStack.Push(pTitleName)
                    frmMMIProcessSlop.Show()
                    frmMMIProcessSlop.FormScreenID = pScreenID
                    frmMMIProcessSlop.UcHeader1.MenuText = GetCurrentMenu()
                    Return True

                Case 400
                    'mMenuStack.Push(pTitleName)
                    'frmMasterData.Show()
                    'frmMasterData.FormScreenID = pScreenID
                    'frmMasterData.lblTitleName.Text = GetCurrentMenu()
                    'Return True
                Case 401
                    'PushForm(frmMasterData)
                    mMenuStack.Push(pTitleName)
                    'frmMainCustomer_main.Show()
                    frmMainCustomer_main.FormScreenID = pScreenID
                    frmMainCustomer_main.UcHeader1.MenuText = GetCurrentMenu()
                    frmMainCustomer_main.Show()
                    Return True
                Case 402
                    mMenuStack.Push(pTitleName)
                    frmMainCarrier_main.Show()
                    frmMainCarrier_main.FormScreenID = pScreenID
                    frmMainCarrier_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 403
                    mMenuStack.Push(pTitleName)
                    frmMainTransportUnit_main.Show()
                    frmMainTransportUnit_main.FormScreenID = pScreenID
                    frmMainTransportUnit_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 404
                    mMenuStack.Push(pTitleName)
                    frmMainVehicle_main.Show()
                    frmMainVehicle_main.FormScreenID = pScreenID
                    frmMainVehicle_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 405
                    mMenuStack.Push(pTitleName)
                    frmMainDriver_main.Show()
                    frmMainDriver_main.FormScreenID = pScreenID
                    frmMainDriver_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 406
                    mMenuStack.Push(pTitleName)
                    frmMainCard_main.Show()
                    frmMainCard_main.FormScreenID = pScreenID
                    frmMainCard_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 407
                    mMenuStack.Push(pTitleName)
                    frmMainShipTo_main.Show()
                    frmMainShipTo_main.FormScreenID = pScreenID
                    frmMainShipTo_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True

                Case 500
                    'mMenuStack.Push(pTitleName)
                    'frmMasterData.Show()
                    'frmMasterData.FormScreenID = pScreenID
                    'frmMasterData.lblTitleName.Text = GetCurrentMenu()
                    'Return True
                Case 501
                    'PushForm(frmMasterData)
                    mMenuStack.Push(pTitleName)
                    frmLoadDO.Show()
                    frmLoadDO.FormScreenID = pScreenID
                    frmLoadDO.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 502
                    'PushForm(frmMasterData)
                    mMenuStack.Push(pTitleName)
                    frmLoadLoading.Show()
                    frmLoadLoading.FormScreenID = pScreenID
                    frmLoadLoading.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 503
                    'PushForm(frmMasterData)
                    mMenuStack.Push(pTitleName)
                    frmLoadSeal.Show()
                    frmLoadSeal.FormScreenID = pScreenID
                    frmLoadSeal.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 504
                    'PushForm(frmMasterData)
                    mMenuStack.Push(pTitleName)
                    frmLoadWeight.Show()
                    frmLoadWeight.FormScreenID = pScreenID
                    frmLoadWeight.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 505
                    'PushForm(frmMasterData)
                    mMenuStack.Push(pTitleName)
                    frmLoadTopUp.Show()
                    frmLoadTopUp.FormScreenID = pScreenID
                    frmLoadTopUp.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 506
                    'PushForm(frmMasterData)
                    mMenuStack.Push(pTitleName)
                    frmLoadCustomerQuota.Show()
                    frmLoadCustomerQuota.FormScreenID = pScreenID
                    frmLoadCustomerQuota.UcHeader1.MenuText = GetCurrentMenu()
                    Return True

                Case 600
                    'mMenuStack.Push(pTitleName)
                    'frmMasterData.Show()
                    'frmMasterData.FormScreenID = pScreenID
                    'frmMasterData.lblTitleName.Text = GetCurrentMenu()
                    'Return True
                Case 601
                    'PushForm(frmMasterData)
                    mMenuStack.Push(pTitleName)
                    frmUnloading_main.Show()
                    frmUnloading_main.FormScreenID = pScreenID
                    frmUnloading_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 602
                    'PushForm(frmMasterData)
                    mMenuStack.Push(pTitleName)
                    frmUnInvTank.Show()
                    frmUnInvTank.FormScreenID = pScreenID
                    frmUnInvTank.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 603
                    'PushForm(frmMasterData)
                    mMenuStack.Push(pTitleName)
                    frmUnInMeter.Show()
                    frmUnInMeter.FormScreenID = pScreenID
                    frmUnInMeter.UcHeader1.MenuText = GetCurrentMenu()
                    Return True

                Case 800
                    'mMenuStack.Push(pTitleName)
                    'frmMasterData.Show()
                    'frmMasterData.FormScreenID = pScreenID
                    'frmMasterData.lblTitleName.Text = GetCurrentMenu()
                    'Return True
                Case 801
                    'PushForm(frmMasterData)
                    mMenuStack.Push(pTitleName)
                    frmUtlUsers_main.Show()
                    frmUtlUsers_main.FormScreenID = pScreenID
                    frmUtlUsers_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 802
                    'PushForm(frmMasterData)
                    mMenuStack.Push(pTitleName)
                    frmUtlSecurity.Show()
                    frmUtlSecurity.FormScreenID = pScreenID
                    frmUtlSecurity.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 803
                    'PushForm(frmMasterData)
                    mMenuStack.Push(pTitleName)
                    frmUtlOverrideCR.Show()
                    frmUtlOverrideCR.FormScreenID = pScreenID
                    frmUtlOverrideCR.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 804
                    mMenuStack.Push(pTitleName)
                    frmUtlReportEditor.Show()
                    frmUtlReportEditor.FormScreenID = pScreenID
                    'frmUtlReportEditor.lblTitleName.Text = GetCurrentMenu()
                    Return True
                Case 805
                    mMenuStack.Push(pTitleName)
                    FrmUtlChangPsw.Show()
                    FrmUtlChangPsw.FormScreenID = pScreenID
                    Return True
                Case 806
                    'PushForm(frmMasterData)
                    mMenuStack.Push(pTitleName)
                    frmUtlWeighBridge_main.Show()
                    frmUtlWeighBridge_main.FormScreenID = pScreenID
                    frmUtlWeighBridge_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 807
                    'PushForm(frmMasterData)
                    mMenuStack.Push(pTitleName)
                    frmUtlTasConfig_main.Show()
                    frmUtlTasConfig_main.FormScreenID = pScreenID
                    frmUtlTasConfig_main.UcHeader1.MenuText = GetCurrentMenu()
                    Return True
                Case 808
                    'PushForm(frmMasterData)
                    mMenuStack.Push(pTitleName)
                    frmUtlEndOfday.Show()
                    frmUtlEndOfday.FormScreenID = pScreenID
                    'frmUtlEndOfday.lblTitleName.Text = GetCurrentMenu()
                    Return True
                Case 809
                    'PushForm(frmMasterData)
                    'mMenuStack.Push(pTitleName)
                    'frmLoadCreateLoad.Show()
                    'frmLoadCreateLoad.FormScreenID = pScreenID
                    'frmLoadCreateLoad.UcHeader1.Text = GetCurrentMenu()
                    frmLoadLoading_sub.Close()
                    frmLoadLoading_sub.ShowDialog()
                    'frmLoadCreateLoad.FormScreenID = pScreenID
                    Return True
                Case Else
                    MsgBox("Missing Screen ID[" & pScreenID & "]", vbCritical + vbOKOnly)
                    Return False
            End Select
        Catch ex As Exception
            mLog.WriteErrMessage(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Public Function CloseForm(ByVal pScreenID As Long, ByVal pTitleName As String) As Boolean
        Try
            Select Case pScreenID
                Case 100
                    PopForm()
                    Return True
                    'mForm.Push(frmMain)
                    'mMenuStack.Push(pTitleName)
                    'frmMasterData.Show()
                    'frmMasterData.FormScreenID = pScreenID
                    'frmMasterData.lblTitleName.Text = GetCurrentMenu()
                Case 101
                    PopForm()
                    Return True
                Case 102
                    PopForm()
                    Return True
                Case 103
                    PopForm()
                    Return True
                Case 104
                    PopForm()
                    Return True
                Case 105
                    PopForm()
                    Return True
                Case 106
                    PopForm()
                    Return True
                Case 107
                    PopForm()
                    Return True
                Case 108
                    PopForm()
                    Return True
                Case 109
                    PopForm()
                    Return True
                Case 110
                    PopForm()
                    Return True
                Case 111
                    PopForm()
                    Return True
                Case 112
                    PopForm()
                    Return True


                Case 200
                    PopForm()
                    Return True
                Case 201
                    PopForm()
                    Return True
                Case 202
                    PopForm()
                    Return True
                Case 203
                    PopForm()
                    Return True
                Case 204
                    PopForm()
                    Return True
                Case 205
                    PopForm()
                    Return True
                Case 206
                    PopForm()
                    Return True
                Case 207
                    PopForm()
                    Return True
                Case 208
                    PopForm()
                    Return True
                Case 209
                    PopForm()
                    Return True
                Case 210
                    PopForm()
                    Return True

                Case 300
                    PopForm()
                    Return True
                Case 301
                    PopForm()
                    Return True
                Case 302
                    PopForm()
                    Return True
                Case 303
                    PopForm()
                    Return True
                Case 304
                    PopForm()
                    Return True
                Case 305
                    PopForm()
                    Return True
                Case 306
                    PopForm()
                    Return True
                Case 307
                    PopForm()
                    Return True
                Case 308
                    PopForm()
                    Return True
                Case 309
                    PopForm()
                    Return True
                Case 310
                    PopForm()
                    Return True
                Case 311
                    PopForm()
                    Return True


                Case 400
                    PopForm()
                    Return True
                Case 401
                    PopForm()
                    Return True
                Case 402
                    PopForm()
                    Return True
                Case 403
                    PopForm()
                    Return True
                Case 404
                    PopForm()
                    Return True
                Case 405
                    PopForm()
                    Return True
                Case 406
                    PopForm()
                    Return True
                Case 407
                    PopForm()
                    Return True

                Case 500
                    PopForm()
                    Return True
                Case 501
                    PopForm()
                    Return True
                Case 502
                    PopForm()
                    Return True
                Case 503
                    PopForm()
                    Return True
                Case 504
                    PopForm()
                    Return True
                Case 505
                    PopForm()
                    Return True
                Case 506
                    PopForm()
                    Return True

                Case 600
                    PopForm()
                    Return True
                Case 601
                    PopForm()
                    Return True
                Case 602
                    PopForm()
                    Return True
                Case 603
                    PopForm()
                    Return True

                Case 800
                    PopForm()
                    Return True
                Case 801
                    PopForm()
                    Return True
                Case 802
                    PopForm()
                    Return True
                Case 803
                    PopForm()
                    Return True
                Case 804
                    PopForm()
                    Return True
                Case 805
                    PopForm()
                    Return True
                Case 806
                    PopForm()
                    Return True
                Case 807
                    PopForm()
                    Return True
                Case 808
                    PopForm()
                    Return True
                Case 809
                    PopForm()
                    Return True

                Case Else
                    MsgBox("Missing Screen ID[" & pScreenID & "]", vbCritical + vbOKOnly)
                    Return False
            End Select
        Catch ex As Exception
            mLog.WriteErrMessage(ex.Message)
            Return False
        End Try
    End Function

#Region "form property"

    Public Sub CheckFormResize(ByRef f As Form)
        'SetScreenResulotion()
        If fSize = Nothing Then Exit Sub
        If f.WindowState = FormWindowState.Minimized Then Exit Sub
        f.Size = New System.Drawing.Size(fSize.Width, fSize.Height)
        CheckFormCenterScreen(f)

    End Sub

    Public Sub CheckFormCenterScreen(ByRef frm As Form)
        Dim boundWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim boundHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim x As Integer = boundWidth - frm.Width
        Dim y As Integer = boundHeight - frm.Height
        frm.Location = New System.Drawing.Point(x / 2, y / 2)
    End Sub

    Public Sub ResizeFormControls(ByRef f As Form)

        Dim RW As Double = (f.Width - CW) / CW ' Ratio change of width
        Dim RH As Double = (f.Height - CH) / CH ' Ratio change of height

        For Each Ctrl As Control In f.Controls
            If TypeOf (Ctrl) Is UserControl Then
            Else

                Ctrl.Width += CInt(Ctrl.Width * RW)
                Ctrl.Height += CInt(Ctrl.Height * RH)
                Ctrl.Left += CInt(Ctrl.Left * RW)
                Ctrl.Top += CInt(Ctrl.Top * RH)
            End If
        Next

        CW = f.Width
        CH = f.Height
    End Sub

    'Public Sub InitialFormMnuType1(ByRef f As Form, ByRef pTitleName As String)
    '    f.BackgroundImageLayout = ImageLayout.Stretch
    '    f.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\BG_SUB.png")
    '    'TitleName
    '    InitialTitleName(f, pTitleName)
    '    f.Text = My.Application.Info.ProductName
    '    InitialUcMnu(f)
    'End Sub

    Public Sub InitialFormConfig(ByRef f As Form, ByVal pTitleName As String)
        'f.BackgroundImageLayout = ImageLayout.Stretch
        'f.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\BG_SUB.png")
        'TitleName
        Dim allLabel = From lbl In f.Controls.OfType(Of Label)()
                       Where lbl.Name = "lblTitleName"
        For Each lbl As Label In allLabel
            lbl.ForeColor = Color.WhiteSmoke
            lbl.BackColor = Color.Transparent

            'lbl.Text = GetCurrentMenu()
            'lbl.Left = f.Width - lbl.Width
            lbl.Width = f.Width / 2
            lbl.Left = f.Width / 2
            lbl.Top = (75 * f.Height) / 1080
        Next
        allLabel = Nothing

        Dim ucClosed_All = From ucClosed In f.Controls.OfType(Of UserControl)()
                           Where ucClosed.Name = "UcClose1"
        For Each ucClosed As UserControl In ucClosed_All
            ucClosed.Left = f.Width - ucClosed.Width
            ucClosed.Top = 0
            ucClosed.Height = (65 * f.Height) / 1080
            ucClosed.Width = (65 * f.Width) / 1920
        Next
        ucClosed_All = Nothing

        Dim UcMinimize_All = From UcMinimize In f.Controls.OfType(Of UserControl)()
                             Where UcMinimize.Name = "UcMinimize1"
        For Each UcMinimize As UserControl In UcMinimize_All
            UcMinimize.Left = f.Width - (UcMinimize.Width * 2)
            UcMinimize.Top = 0
            UcMinimize.Height = (65 * f.Height) / 1080
            UcMinimize.Width = (65 * f.Width) / 1920
        Next
        UcMinimize_All = Nothing

        Dim ucStatus_All = From ucStatus In f.Controls.OfType(Of UserControl)() Where ucStatus.Name = "UcStatus1"
        For Each ucStatus As UserControl In ucStatus_All
            ucStatus.Height = 60
            ucStatus.Dock = DockStyle.Bottom
        Next
        ucStatus_All = Nothing

        Dim Allctrl = From ctrl In f.Controls.OfType(Of DataGridView)() Where ctrl.Name = "DataGridView1"

        For Each ctrl As DataGridView In Allctrl
            With ctrl
                .Width = 806
                .Height = 534
                .Left = 33
                .Top = 133
                .Anchor = AnchorStyles.Left + AnchorStyles.Right = AnchorStyles.Bottom + AnchorStyles.Top
                .RowHeadersVisible = False
                .CellBorderStyle = DataGridViewCellBorderStyle.None
            End With
            For i As Integer = 0 To ctrl.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = ctrl.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
        Next
        Allctrl = Nothing

        'InitialSplitContainer(f)
        Dim gr As Graphics
        Dim bm As Bitmap
        'Dim tempBG As Bitmap

        Dim allSpli = From ctrl In f.Controls.OfType(Of SplitContainer)()

        For Each ctrl As SplitContainer In allSpli
            Dim src_rect As Rectangle
            Dim dst_rect As Rectangle

            With ctrl
                '.Visible = False
                .SplitterDistance = 200
                .SplitterWidth = 4
                .Left = 0
                .Top = 100
                .Width = f.Width
                '.Height = 600
                .Anchor = AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top
            End With

            ctrl.Panel2.Padding = New Padding(8)
            'tempBG = New Bitmap(f.Width, f.Height)
            'tempBG = f.BackgroundImage

            'tempBG.Save(GetCurrDirectory() & "\110.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

            bm = New Bitmap(ctrl.Width, ctrl.Height)
            gr = ctrl.CreateGraphics
            gr = Graphics.FromImage(bm)
            gr.SmoothingMode = SmoothingMode.HighQuality
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality
            'src_rect = New Rectangle(ctrl.Left * 96 / 72, ctrl.Top * 96 / 72, ctrl.Width * 96 / 72, ctrl.Height * 96 / 72)
            'dst_rect = New Rectangle(0, 0, ctrl.Width * 96 / 72, ctrl.Height * 96 / 72)
            src_rect = New Rectangle(ConvertPixelToPoint(ctrl.Left, f.BackgroundImage.HorizontalResolution) _
                                         , ConvertPixelToPoint(ctrl.Top, f.BackgroundImage.VerticalResolution) _
                                         , ConvertPixelToPoint(ctrl.Width, f.BackgroundImage.HorizontalResolution) _
                                         , ConvertPixelToPoint(ctrl.Height, f.BackgroundImage.VerticalResolution))
            dst_rect = New Rectangle(0 _
                                         , 0 _
                                         , ConvertPixelToPoint(ctrl.Width, f.BackgroundImage.HorizontalResolution) _
                                         , ConvertPixelToPoint(ctrl.Height, f.BackgroundImage.VerticalResolution))

            gr.DrawImage(f.BackgroundImage, dst_rect, src_rect, GraphicsUnit.Point)
            ctrl.BackgroundImage = bm

            'bm.Save(GetCurrDirectory() & "\111.bmp", System.Drawing.Imaging.ImageFormat.Bmp)
            'bm.Dispose()
            'gr.Dispose()
            'tempBG.Dispose()

            'Panel(1)
            'tempBG = New Bitmap(ctrl.Width, ctrl.Height)
            'tempBG = ctrl.BackgroundImage
            bm = New Bitmap(ctrl.SplitterDistance, ctrl.Height)

            gr = Graphics.FromImage(bm)
            gr.SmoothingMode = SmoothingMode.HighQuality
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality

            'src_rect = New Rectangle(ctrl.Left, ctrl.Top, ctrl.SplitterDistance, ctrl.Height)
            'dst_rect = New Rectangle(0, 0, ctrl.SplitterDistance, ctrl.Height)
            src_rect = New Rectangle(ConvertPixelToPoint(ctrl.Left, ctrl.BackgroundImage.HorizontalResolution) _
                                     , ConvertPixelToPoint(ctrl.Top, ctrl.BackgroundImage.VerticalResolution) _
                                     , ConvertPixelToPoint(ctrl.SplitterDistance, ctrl.BackgroundImage.HorizontalResolution) _
                                     , ConvertPixelToPoint(ctrl.Height, ctrl.BackgroundImage.VerticalResolution))
            dst_rect = New Rectangle(0 _
                                     , 0 _
                                     , ConvertPixelToPoint(ctrl.SplitterDistance, ctrl.BackgroundImage.HorizontalResolution) _
                                     , ConvertPixelToPoint(ctrl.Height, ctrl.BackgroundImage.VerticalResolution))

            'gr.DrawImage(tempBG, dst_rect, src_rect, GraphicsUnit.Point)
            gr.DrawImage(ctrl.BackgroundImage, 0, 0, bm.Width, bm.Height)
            'bm.Save(GetCurrDirectory() & "\112.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

            ctrl.Panel1.BackgroundImage = bm

            'bm.Dispose()
            'gr.Dispose()
            'tempBG.Dispose()
            'ctrl.Panel1.BackColor = Color.Transparent

            Dim allUC = From uc In ctrl.Panel1.Controls.OfType(Of UserControl)() Order By uc.Tag
            For Each u As UserControl In allUC
                If u.Name.ToLower.IndexOf("ucmenutxtsub") > -1 Then 'And u.Visible = True Then

                End If
            Next

            'Panel2
            'tempBG = New Bitmap(ctrl.Width, ctrl.Height)
            'tempBG = ctrl.BackgroundImage
            bm = New Bitmap(ctrl.Width - (ctrl.SplitterDistance + ctrl.SplitterWidth - ctrl.Left), ctrl.Height)
            gr = Graphics.FromImage(bm)
            gr.SmoothingMode = SmoothingMode.HighQuality
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality
            gr.DrawImage(ctrl.BackgroundImage, 0, 0, bm.Width, bm.Height)
            ctrl.Panel2.BackgroundImage = bm

            bm = Nothing
            gr.Dispose()
            'gr = Nothing
            'tempBG = Nothing

            'ctrl.Panel2.BackColor = Color.Transparent

            Dim AllDGV = From dgv In ctrl.Panel2.Controls.OfType(Of DataGridView)() 'Where ctrl.Name = "DataGridView1"

            For Each dgv As DataGridView In AllDGV
                With dgv
                    .Width = 806
                    .Height = 534
                    .Left = 33
                    .Top = 133
                    '.Anchor = AnchorStyles.Left + AnchorStyles.Right = AnchorStyles.Bottom + AnchorStyles.Top
                    .Dock = DockStyle.Fill
                    .RowHeadersVisible = False
                    .CellBorderStyle = DataGridViewCellBorderStyle.None
                End With
                For i As Integer = 0 To dgv.ColumnCount - 1
                    Dim col As New DataGridViewColumn
                    col = dgv.Columns(i)
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Next
            Next
            AllDGV = Nothing
            'ctrl.Visible = True
        Next
    End Sub

    Public Sub InitialFormDatabase(ByRef f As Form, ByVal pTitleName As String)
        'f.BackgroundImageLayout = ImageLayout.Stretch
        'f.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\BG_SUB.png")
        'TitleName
        Dim allLabel = From lbl In f.Controls.OfType(Of Label)()
                       Where lbl.Name = "lblTitleName"
        For Each lbl As Label In allLabel
            lbl.ForeColor = Color.WhiteSmoke
            lbl.BackColor = Color.Transparent

            'lbl.Text = GetCurrentMenu()
            'lbl.Left = f.Width - lbl.Width
            lbl.Width = f.Width / 2
            lbl.Left = f.Width / 2
            lbl.Top = (75 * f.Height) / 1080
        Next
        allLabel = Nothing

        Dim ucClosed_All = From ucClosed In f.Controls.OfType(Of UserControl)()
                           Where ucClosed.Name = "UcClose1"
        For Each ucClosed As UserControl In ucClosed_All
            ucClosed.Left = f.Width - ucClosed.Width
            ucClosed.Top = 0
            ucClosed.Height = (65 * f.Height) / 1080
            ucClosed.Width = (65 * f.Width) / 1920
        Next
        ucClosed_All = Nothing

        Dim UcMinimize_All = From UcMinimize In f.Controls.OfType(Of UserControl)()
                             Where UcMinimize.Name = "UcMinimize1"
        For Each UcMinimize As UserControl In UcMinimize_All
            UcMinimize.Left = f.Width - (UcMinimize.Width * 2)
            UcMinimize.Top = 0
            UcMinimize.Height = (65 * f.Height) / 1080
            UcMinimize.Width = (65 * f.Width) / 1920
        Next
        UcMinimize_All = Nothing

        Dim ucStatus_All = From ucStatus In f.Controls.OfType(Of UserControl)() Where ucStatus.Name = "UcStatus1"
        For Each ucStatus As UserControl In ucStatus_All
            ucStatus.Height = 60
            ucStatus.Dock = DockStyle.Bottom
        Next
        ucStatus_All = Nothing

        Dim Allctrl = From ctrl In f.Controls.OfType(Of DataGridView)() Where ctrl.Name = "DataGridView1"

        For Each ctrl As DataGridView In Allctrl
            With ctrl
                .Width = 806
                .Height = 534
                .Left = 33
                .Top = 133
                .Anchor = AnchorStyles.Left + AnchorStyles.Right = AnchorStyles.Bottom + AnchorStyles.Top
                .RowHeadersVisible = False
                .CellBorderStyle = DataGridViewCellBorderStyle.None
            End With
            For i As Integer = 0 To ctrl.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = ctrl.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
        Next
        Allctrl = Nothing

        'InitialSplitContainer(f)
        Dim gr As Graphics
        Dim bm As Bitmap

        Dim allSpli = From ctrl In f.Controls.OfType(Of SplitContainer)()

        For Each ctrl As SplitContainer In allSpli
            Dim src_rect As Rectangle
            Dim dst_rect As Rectangle

            With ctrl
                '.Visible = False
                .SplitterDistance = 200
                .SplitterWidth = 4
                .Left = 0
                .Top = 100
                .Width = f.Width
                '.Height = 600
                .Anchor = AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top
            End With

            ctrl.Panel2.Padding = New Padding(8)

            'tempBG.Save(GetCurrDirectory() & "\110.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

            bm = New Bitmap(ctrl.Width, ctrl.Height)
            gr = ctrl.CreateGraphics
            gr = Graphics.FromImage(bm)
            gr.SmoothingMode = SmoothingMode.HighQuality
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality
            'src_rect = New Rectangle(ctrl.Left * 96 / 72, ctrl.Top * 96 / 72, ctrl.Width * 96 / 72, ctrl.Height * 96 / 72)
            'dst_rect = New Rectangle(0, 0, ctrl.Width * 96 / 72, ctrl.Height * 96 / 72)
            src_rect = New Rectangle(ConvertPixelToPoint(ctrl.Left, f.BackgroundImage.HorizontalResolution) _
                                         , ConvertPixelToPoint(ctrl.Top, f.BackgroundImage.VerticalResolution) _
                                         , ConvertPixelToPoint(ctrl.Width, f.BackgroundImage.HorizontalResolution) _
                                         , ConvertPixelToPoint(ctrl.Height, f.BackgroundImage.VerticalResolution))
            dst_rect = New Rectangle(0 _
                                         , 0 _
                                         , ConvertPixelToPoint(ctrl.Width, f.BackgroundImage.HorizontalResolution) _
                                         , ConvertPixelToPoint(ctrl.Height, f.BackgroundImage.VerticalResolution))

            gr.DrawImage(f.BackgroundImage, dst_rect, src_rect, GraphicsUnit.Point)
            ctrl.BackgroundImage = bm

            'bm.Save(GetCurrDirectory() & "\111.bmp", System.Drawing.Imaging.ImageFormat.Bmp)
            'bm.Dispose()
            'gr.Dispose()
            'tempBG.Dispose()

            'Panel(1)
            bm = New Bitmap(ctrl.SplitterDistance, ctrl.Height)

            gr = Graphics.FromImage(bm)
            gr.SmoothingMode = SmoothingMode.HighQuality
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality

            'src_rect = New Rectangle(ctrl.Left, ctrl.Top, ctrl.SplitterDistance, ctrl.Height)
            'dst_rect = New Rectangle(0, 0, ctrl.SplitterDistance, ctrl.Height)
            src_rect = New Rectangle(ConvertPixelToPoint(ctrl.Left, ctrl.BackgroundImage.HorizontalResolution) _
                                     , ConvertPixelToPoint(ctrl.Top, ctrl.BackgroundImage.VerticalResolution) _
                                     , ConvertPixelToPoint(ctrl.SplitterDistance, ctrl.BackgroundImage.HorizontalResolution) _
                                     , ConvertPixelToPoint(ctrl.Height, ctrl.BackgroundImage.VerticalResolution))
            dst_rect = New Rectangle(0 _
                                     , 0 _
                                     , ConvertPixelToPoint(ctrl.SplitterDistance, ctrl.BackgroundImage.HorizontalResolution) _
                                     , ConvertPixelToPoint(ctrl.Height, ctrl.BackgroundImage.VerticalResolution))

            'gr.DrawImage(tempBG, dst_rect, src_rect, GraphicsUnit.Point)
            gr.DrawImage(ctrl.BackgroundImage, 0, 0, bm.Width, bm.Height)
            'bm.Save(GetCurrDirectory() & "\112.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

            ctrl.Panel1.BackgroundImage = bm

            'bm.Dispose()
            'gr.Dispose()
            'tempBG.Dispose()
            'ctrl.Panel1.BackColor = Color.Transparent

            Dim allUC = From uc In ctrl.Panel1.Controls.OfType(Of UserControl)() Order By uc.Tag
            For Each u As UserControl In allUC
                If u.Name.ToLower.IndexOf("ucmenutxtsub") > -1 Then 'And u.Visible = True Then

                End If
            Next

            'Panel2
            bm = New Bitmap(ctrl.Width - (ctrl.SplitterDistance + ctrl.SplitterWidth - ctrl.Left), ctrl.Height)
            gr = Graphics.FromImage(bm)
            gr.SmoothingMode = SmoothingMode.HighQuality
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality
            gr.DrawImage(ctrl.BackgroundImage, 0, 0, bm.Width, bm.Height)
            ctrl.Panel2.BackgroundImage = bm

            bm = Nothing
            gr.Dispose()
            'ctrl.Panel2.BackColor = Color.Transparent

            Dim AllDGV = From dgv In ctrl.Panel2.Controls.OfType(Of DataGridView)() 'Where ctrl.Name = "DataGridView1"

            For Each dgv As DataGridView In AllDGV
                With dgv
                    .Width = 806
                    .Height = 534
                    .Left = 33
                    .Top = 133
                    '.Anchor = AnchorStyles.Left + AnchorStyles.Right = AnchorStyles.Bottom + AnchorStyles.Top
                    .Dock = DockStyle.Fill
                    .RowHeadersVisible = False
                    .CellBorderStyle = DataGridViewCellBorderStyle.None
                End With
                For i As Integer = 0 To dgv.ColumnCount - 1
                    Dim col As New DataGridViewColumn
                    col = dgv.Columns(i)
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Next
            Next
            AllDGV = Nothing
            'ctrl.Visible = True
        Next
    End Sub

    Public Sub InitialFormUtility(ByRef f As Form, ByVal pTitleName As String)
        'f.BackgroundImageLayout = ImageLayout.Stretch
        'f.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\BG_SUB.png")
        'TitleName
        Dim allLabel = From lbl In f.Controls.OfType(Of Label)()
                       Where lbl.Name = "lblTitleName"
        For Each lbl As Label In allLabel
            lbl.ForeColor = Color.WhiteSmoke
            lbl.BackColor = Color.Transparent

            'lbl.Text = GetCurrentMenu()
            'lbl.Left = f.Width - lbl.Width
            lbl.Width = f.Width / 2
            lbl.Left = f.Width / 2
            lbl.Top = (75 * f.Height) / 1080
        Next
        allLabel = Nothing

        Dim ucClosed_All = From ucClosed In f.Controls.OfType(Of UserControl)()
                           Where ucClosed.Name = "UcClose1"
        For Each ucClosed As UserControl In ucClosed_All
            ucClosed.Left = f.Width - ucClosed.Width
            ucClosed.Top = 0
            ucClosed.Height = (65 * f.Height) / 1080
            ucClosed.Width = (65 * f.Width) / 1920
        Next
        ucClosed_All = Nothing

        Dim UcMinimize_All = From UcMinimize In f.Controls.OfType(Of UserControl)()
                             Where UcMinimize.Name = "UcMinimize1"
        For Each UcMinimize As UserControl In UcMinimize_All
            UcMinimize.Left = f.Width - (UcMinimize.Width * 2)
            UcMinimize.Top = 0
            UcMinimize.Height = (65 * f.Height) / 1080
            UcMinimize.Width = (65 * f.Width) / 1920
        Next
        UcMinimize_All = Nothing

        Dim ucStatus_All = From ucStatus In f.Controls.OfType(Of UserControl)() Where ucStatus.Name = "UcStatus1"
        For Each ucStatus As UserControl In ucStatus_All
            ucStatus.Height = 60
            ucStatus.Dock = DockStyle.Bottom
        Next
        ucStatus_All = Nothing

        Dim Allctrl = From ctrl In f.Controls.OfType(Of DataGridView)() Where ctrl.Name = "DataGridView1"

        For Each ctrl As DataGridView In Allctrl
            With ctrl
                .Width = 806
                .Height = 534
                .Left = 33
                .Top = 133
                .Anchor = AnchorStyles.Left + AnchorStyles.Right = AnchorStyles.Bottom + AnchorStyles.Top
                .RowHeadersVisible = False
                .CellBorderStyle = DataGridViewCellBorderStyle.None
            End With
            For i As Integer = 0 To ctrl.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = ctrl.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
        Next
        Allctrl = Nothing

        'InitialSplitContainer(f)
        Dim gr As Graphics
        Dim bm As Bitmap
        'Dim tempBG As Bitmap

        Dim allSpli = From ctrl In f.Controls.OfType(Of SplitContainer)()

        For Each ctrl As SplitContainer In allSpli
            Dim src_rect As Rectangle
            Dim dst_rect As Rectangle

            With ctrl
                '.Visible = False
                .SplitterDistance = 220
                .SplitterWidth = 4
                .Left = 0
                .Top = 100
                .Width = f.Width
                '.Height = 600
                .Anchor = AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top
            End With

            ctrl.Panel2.Padding = New Padding(8)
            'tempBG = New Bitmap(f.Width, f.Height)
            'tempBG = f.BackgroundImage

            'tempBG.Save(GetCurrDirectory() & "\110.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

            bm = New Bitmap(ctrl.Width, ctrl.Height)
            gr = ctrl.CreateGraphics
            gr = Graphics.FromImage(bm)
            gr.SmoothingMode = SmoothingMode.HighQuality
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality
            'src_rect = New Rectangle(ctrl.Left * 96 / 72, ctrl.Top * 96 / 72, ctrl.Width * 96 / 72, ctrl.Height * 96 / 72)
            'dst_rect = New Rectangle(0, 0, ctrl.Width * 96 / 72, ctrl.Height * 96 / 72)
            src_rect = New Rectangle(ConvertPixelToPoint(ctrl.Left, f.BackgroundImage.HorizontalResolution) _
                                         , ConvertPixelToPoint(ctrl.Top, f.BackgroundImage.VerticalResolution) _
                                         , ConvertPixelToPoint(ctrl.Width, f.BackgroundImage.HorizontalResolution) _
                                         , ConvertPixelToPoint(ctrl.Height, f.BackgroundImage.VerticalResolution))
            dst_rect = New Rectangle(0 _
                                         , 0 _
                                         , ConvertPixelToPoint(ctrl.Width, f.BackgroundImage.HorizontalResolution) _
                                         , ConvertPixelToPoint(ctrl.Height, f.BackgroundImage.VerticalResolution))

            gr.DrawImage(f.BackgroundImage, dst_rect, src_rect, GraphicsUnit.Point)
            ctrl.BackgroundImage = bm

            'bm.Save(GetCurrDirectory() & "\111.bmp", System.Drawing.Imaging.ImageFormat.Bmp)
            'bm.Dispose()
            'gr.Dispose()
            'tempBG.Dispose()

            'Panel(1)
            bm = New Bitmap(ctrl.SplitterDistance, ctrl.Height)

            gr = Graphics.FromImage(bm)
            gr.SmoothingMode = SmoothingMode.HighQuality
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality

            'src_rect = New Rectangle(ctrl.Left, ctrl.Top, ctrl.SplitterDistance, ctrl.Height)
            'dst_rect = New Rectangle(0, 0, ctrl.SplitterDistance, ctrl.Height)
            src_rect = New Rectangle(ConvertPixelToPoint(ctrl.Left, ctrl.BackgroundImage.HorizontalResolution) _
                                     , ConvertPixelToPoint(ctrl.Top, ctrl.BackgroundImage.VerticalResolution) _
                                     , ConvertPixelToPoint(ctrl.SplitterDistance, ctrl.BackgroundImage.HorizontalResolution) _
                                     , ConvertPixelToPoint(ctrl.Height, ctrl.BackgroundImage.VerticalResolution))
            dst_rect = New Rectangle(0 _
                                     , 0 _
                                     , ConvertPixelToPoint(ctrl.SplitterDistance, ctrl.BackgroundImage.HorizontalResolution) _
                                     , ConvertPixelToPoint(ctrl.Height, ctrl.BackgroundImage.VerticalResolution))

            'gr.DrawImage(tempBG, dst_rect, src_rect, GraphicsUnit.Point)
            gr.DrawImage(ctrl.BackgroundImage, 0, 0, bm.Width, bm.Height)
            'bm.Save(GetCurrDirectory() & "\112.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

            ctrl.Panel1.BackgroundImage = bm

            'bm.Dispose()
            'gr.Dispose()
            'tempBG.Dispose()
            'ctrl.Panel1.BackColor = Color.Transparent

            Dim allUC = From uc In ctrl.Panel1.Controls.OfType(Of UserControl)() Order By uc.Tag
            For Each u As UserControl In allUC
                If u.Name.ToLower.IndexOf("ucmenutxtsub") > -1 Then 'And u.Visible = True Then

                End If
            Next

            'Panel2

            bm = New Bitmap(ctrl.Width - (ctrl.SplitterDistance + ctrl.SplitterWidth - ctrl.Left), ctrl.Height)
            gr = Graphics.FromImage(bm)
            gr.SmoothingMode = SmoothingMode.HighQuality
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality
            gr.DrawImage(ctrl.BackgroundImage, 0, 0, bm.Width, bm.Height)
            ctrl.Panel2.BackgroundImage = bm

            bm = Nothing
            gr.Dispose()
            'ctrl.Panel2.BackColor = Color.Transparent

            Dim AllDGV = From dgv In ctrl.Panel2.Controls.OfType(Of DataGridView)() 'Where ctrl.Name = "DataGridView1"

            For Each dgv As DataGridView In AllDGV
                With dgv
                    .Width = 806
                    .Height = 534
                    .Left = 33
                    .Top = 133
                    '.Anchor = AnchorStyles.Left + AnchorStyles.Right = AnchorStyles.Bottom + AnchorStyles.Top
                    .Dock = DockStyle.Fill
                    .RowHeadersVisible = False
                    .CellBorderStyle = DataGridViewCellBorderStyle.None
                End With
                For i As Integer = 0 To dgv.ColumnCount - 1
                    Dim col As New DataGridViewColumn
                    col = dgv.Columns(i)
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Next
            Next
            AllDGV = Nothing
            'ctrl.Visible = True
        Next
    End Sub

    Public Sub InitialFormType1(ByRef f As Form, ByVal pTitleName As String)
        'f.BackgroundImageLayout = ImageLayout.Stretch
        'f.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\BG_SUB.png")
        'TitleName
        Dim allLabel = From lbl In f.Controls.OfType(Of Label)()
                       Where lbl.Name = "lblTitleName"
        For Each lbl As Label In allLabel
            lbl.ForeColor = Color.WhiteSmoke
            lbl.BackColor = Color.Transparent

            'lbl.Text = GetCurrentMenu()
            'lbl.Left = f.Width - lbl.Width
            lbl.Width = f.Width / 2
            lbl.Left = f.Width / 2
            lbl.Top = (75 * f.Height) / 1080
        Next
        allLabel = Nothing

        Dim ucClosed_All = From ucClosed In f.Controls.OfType(Of UserControl)()
                           Where ucClosed.Name = "UcClose1"
        For Each ucClosed As UserControl In ucClosed_All
            ucClosed.Left = f.Width - ucClosed.Width
            ucClosed.Top = 0
            ucClosed.Height = (65 * f.Height) / 1080
            ucClosed.Width = (65 * f.Width) / 1920
        Next
        ucClosed_All = Nothing

        Dim UcMinimize_All = From UcMinimize In f.Controls.OfType(Of UserControl)()
                             Where UcMinimize.Name = "UcMinimize1"
        For Each UcMinimize As UserControl In UcMinimize_All
            UcMinimize.Left = f.Width - (UcMinimize.Width * 2)
            UcMinimize.Top = 0
            UcMinimize.Height = (65 * f.Height) / 1080
            UcMinimize.Width = (65 * f.Width) / 1920
        Next
        UcMinimize_All = Nothing

        Dim ucStatus_All = From ucStatus In f.Controls.OfType(Of UserControl)() Where ucStatus.Name = "UcStatus1"
        For Each ucStatus As UserControl In ucStatus_All
            ucStatus.Height = 60
            ucStatus.Dock = DockStyle.Bottom
        Next
        ucStatus_All = Nothing

        Dim Allctrl = From ctrl In f.Controls.OfType(Of DataGridView)() 'Where ctrl.Name = "DataGridView1"

        For Each ctrl As DataGridView In Allctrl
            With ctrl
                .Width = 806
                .Height = 534
                .Left = 33
                .Top = 133
                .Anchor = AnchorStyles.Left + AnchorStyles.Right = AnchorStyles.Bottom + AnchorStyles.Top
                .RowHeadersVisible = False
                .CellBorderStyle = DataGridViewCellBorderStyle.None
            End With
            For i As Integer = 0 To ctrl.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = ctrl.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
        Next
        Allctrl = Nothing

        Dim objUC() As UserControl
        Dim vIndex As Integer = 0
        Dim AllUC = From uc In f.Controls.OfType(Of UserControl)()
                    Where uc.Name = "UcReflesh1" Or uc.Name = "UcInsert1" Or uc.Name = "UcDelete1" Or uc.Name = "UcSearch1" Or uc.Name = "UcEdit1"

        ReDim objUC(AllUC.Count - 1)
        For Each uc As UserControl In AllUC
            objUC(vIndex) = uc
            objUC(vIndex).Width = 91
            objUC(vIndex).Height = 99
            objUC(vIndex).Anchor = AnchorStyles.Left + AnchorStyles.Top
            vIndex += 1
        Next
        vIndex = 0
        objUC = Nothing

        'InitialSplitContainer(f)
    End Sub

    Public Sub InitialFormType2(ByRef f As Form, ByVal pTitleName As String)
        'f.BackgroundImageLayout = ImageLayout.Stretch
        'f.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\BG_SUB.png")
        'TitleName
        InitialTitleName(f, pTitleName)
        f.Text = My.Application.Info.ProductName
        'InitialSplitContainer(f)
        InitialUcMnu(f)
        f.UseWaitCursor = False
    End Sub

    Private Sub InitialSplitContainer(ByRef f As Form)

        Dim gr As Graphics
        Dim bm As Bitmap
        Dim tempBG As Bitmap

        Dim allSpli = From ctrl In f.Controls.OfType(Of SplitContainer)()

        For Each ctrl As SplitContainer In allSpli
            Dim src_rect As Rectangle
            Dim dst_rect As Rectangle

            With ctrl
                '.Visible = False
                .SplitterDistance = 244
                .SplitterWidth = 4
                .Left = 0
                .Top = 100
                .Width = f.Width
                .Height = 600
                .Anchor = AnchorStyles.Bottom + AnchorStyles.Left + AnchorStyles.Right + AnchorStyles.Top
            End With

            ctrl.Panel2.Padding = New Padding(8)
            tempBG = New Bitmap(f.Width, f.Height)
            tempBG = f.BackgroundImage

            'tempBG.Save(GetCurrDirectory() & "\110.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

            bm = New Bitmap(ctrl.Width, ctrl.Height)
            gr = ctrl.CreateGraphics
            gr = Graphics.FromImage(bm)
            gr.SmoothingMode = SmoothingMode.HighQuality
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality
            'src_rect = New Rectangle(ctrl.Left * 96 / 72, ctrl.Top * 96 / 72, ctrl.Width * 96 / 72, ctrl.Height * 96 / 72)
            'dst_rect = New Rectangle(0, 0, ctrl.Width * 96 / 72, ctrl.Height * 96 / 72)
            src_rect = New Rectangle(ConvertPixelToPoint(ctrl.Left, tempBG.HorizontalResolution) _
                                         , ConvertPixelToPoint(ctrl.Top, tempBG.VerticalResolution) _
                                         , ConvertPixelToPoint(ctrl.Width, tempBG.HorizontalResolution) _
                                         , ConvertPixelToPoint(ctrl.Height, tempBG.VerticalResolution))
            dst_rect = New Rectangle(0 _
                                         , 0 _
                                         , ConvertPixelToPoint(ctrl.Width, tempBG.HorizontalResolution) _
                                         , ConvertPixelToPoint(ctrl.Height, tempBG.VerticalResolution))

            gr.DrawImage(tempBG, dst_rect, src_rect, GraphicsUnit.Point)
            ctrl.BackgroundImage = bm

            'bm.Save(GetCurrDirectory() & "\111.bmp", System.Drawing.Imaging.ImageFormat.Bmp)
            'bm.Dispose()
            'gr.Dispose()
            'tempBG.Dispose()

            'Panel(1)
            tempBG = New Bitmap(ctrl.Width, ctrl.Height)
            tempBG = ctrl.BackgroundImage
            bm = New Bitmap(ctrl.SplitterDistance, ctrl.Height)

            gr = Graphics.FromImage(bm)
            gr.SmoothingMode = SmoothingMode.HighQuality
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality

            'src_rect = New Rectangle(ctrl.Left, ctrl.Top, ctrl.SplitterDistance, ctrl.Height)
            'dst_rect = New Rectangle(0, 0, ctrl.SplitterDistance, ctrl.Height)
            src_rect = New Rectangle(ConvertPixelToPoint(ctrl.Left, bm.HorizontalResolution) _
                                     , ConvertPixelToPoint(ctrl.Top, bm.VerticalResolution) _
                                     , ConvertPixelToPoint(ctrl.SplitterDistance, bm.HorizontalResolution) _
                                     , ConvertPixelToPoint(ctrl.Height, bm.VerticalResolution))
            dst_rect = New Rectangle(0 _
                                     , 0 _
                                     , ConvertPixelToPoint(ctrl.SplitterDistance, bm.HorizontalResolution) _
                                     , ConvertPixelToPoint(ctrl.Height, bm.VerticalResolution))

            'gr.DrawImage(tempBG, dst_rect, src_rect, GraphicsUnit.Point)
            gr.DrawImage(tempBG, 0, 0, bm.Width, bm.Height)
            'bm.Save(GetCurrDirectory() & "\112.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

            ctrl.Panel1.BackgroundImage = bm

            'bm.Dispose()
            'gr.Dispose()
            'tempBG.Dispose()
            'ctrl.Panel1.BackColor = Color.Transparent

            Dim allUC = From uc In ctrl.Panel1.Controls.OfType(Of UserControl)()
            For Each u As UserControl In allUC
                If u.Name.IndexOf("UcMnu") > -1 Then 'And u.Visible = True Then
                    bm = New Bitmap(u.Width, u.Height)

                    ' Associate a Graphics object with the Bitmap
                    gr = Graphics.FromImage(bm)
                    ' Define source and destination rectangles.
                    src_rect = New Rectangle(u.Left, u.Top, u.Width,
                        u.Height)
                    dst_rect = New Rectangle(0, 0, u.Width, u.Height)

                    ' Copy that part of the image.
                    gr.DrawImage(ctrl.Panel1.BackgroundImage, dst_rect, src_rect, GraphicsUnit.Pixel)
                    ' Display the result.
                    u.BackgroundImage = bm

                    bm.Dispose()
                    gr.Dispose()
                End If
            Next

            'Panel2
            tempBG = New Bitmap(ctrl.Width, ctrl.Height)
            tempBG = ctrl.BackgroundImage
            bm = New Bitmap(ctrl.Width - (ctrl.SplitterDistance + ctrl.SplitterWidth - ctrl.Left), ctrl.Height)
            gr = Graphics.FromImage(bm)
            gr.SmoothingMode = SmoothingMode.HighQuality
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic
            gr.PixelOffsetMode = PixelOffsetMode.HighQuality
            gr.DrawImage(tempBG, 0, 0, bm.Width, bm.Height)
            ctrl.Panel2.BackgroundImage = bm

            bm = Nothing
            gr = Nothing
            tempBG = Nothing
            'ctrl.Panel2.BackColor = Color.Transparent

            Dim AllDGV = From dgv In ctrl.Panel2.Controls.OfType(Of DataGridView)() 'Where ctrl.Name = "DataGridView1"

            For Each dgv As DataGridView In AllDGV
                With dgv
                    .Width = 806
                    .Height = 534
                    .Left = 33
                    .Top = 133
                    '.Anchor = AnchorStyles.Left + AnchorStyles.Right = AnchorStyles.Bottom + AnchorStyles.Top
                    .Dock = DockStyle.Fill
                    .RowHeadersVisible = False
                    .CellBorderStyle = DataGridViewCellBorderStyle.None
                End With
                For i As Integer = 0 To dgv.ColumnCount - 1
                    Dim col As New DataGridViewColumn
                    col = dgv.Columns(i)
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Next
            Next
            AllDGV = Nothing
            'ctrl.Visible = True
        Next
    End Sub

    Private Sub InitialTitleName(ByRef f As Form, ByVal pTitleName As String)
        'TitleName
        Dim allLabel = From lbl In f.Controls.OfType(Of Label)()
                       Where lbl.Name = "lblTitleName"
        For Each lbl As Label In allLabel
            lbl.ForeColor = Color.WhiteSmoke
            lbl.BackColor = Color.Transparent

            'lbl.Text = GetCurrentMenu()
            'lbl.Left = 67
            'lbl.Top = 80
        Next
    End Sub

    Public Sub InitialFormMain(ByRef f As Form, ByVal pTitleName As String)

        'f.BackgroundImageLayout = ImageLayout.Stretch
        'f.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\BG_MAIN.png")

        'TitleName
        Dim allLabel = From lbl In f.Controls.OfType(Of Label)()
                       Where lbl.Name = "lblTitleName"
        For Each lbl As Label In allLabel
            lbl.ForeColor = Color.WhiteSmoke
            lbl.BackColor = Color.Transparent

            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.AutoSize = True
            lbl.Anchor = AnchorStyles.Right + AnchorStyles.Top

            'lbl.Text = GetCurrentMenu()
            'lbl.Left = f.Width - lbl.Width
            'lbl.Width = f.Width / 2
            lbl.Left = f.Width / 2
            lbl.Top = (75 * f.Height) / 1080
        Next
        f.Text = My.Application.Info.ProductName

        Dim ucStatus_All = From ucStatus In f.Controls.OfType(Of UserControl)() Where ucStatus.Name = "UcStatus1"
        For Each ucStatus As UserControl In ucStatus_All
            ucStatus.Height = 60
            ucStatus.Dock = DockStyle.Bottom
            'ucStatus.Left = 0
            'ucStatus.Width = f.Width
            'ucStatus.Height = (70 * f.Height) / 1080
            'ucStatus.Top = f.Height - ucStatus.Height
        Next

        Dim ucClosed_All = From ucClosed In f.Controls.OfType(Of UserControl)()
                           Where ucClosed.Name = "UcClose1"
        For Each ucClosed As UserControl In ucClosed_All
            ucClosed.Left = f.Width - ucClosed.Width
            ucClosed.Top = 0
            ucClosed.Height = (65 * f.Height) / 1080
            ucClosed.Width = (65 * f.Width) / 1920
        Next

        Dim UcMinimize_All = From UcMinimize In f.Controls.OfType(Of UserControl)()
                             Where UcMinimize.Name = "UcMinimize1"
        For Each UcMinimize As UserControl In UcMinimize_All
            UcMinimize.Left = f.Width - (UcMinimize.Width * 2)
            UcMinimize.Top = 0
            UcMinimize.Height = (65 * f.Height) / 1080
            UcMinimize.Width = (65 * f.Width) / 1920
        Next
        InitialUcMnu(f)
        'InitialSplitContainer(f)
    End Sub

    Public Sub InitialForm(ByRef f As Form, ByVal pTitleName As String)
        'f.BackgroundImageLayout = ImageLayout.Stretch
        'f.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\BG_SUB.png")

        'TitleName
        Dim allLabel = From lbl In f.Controls.OfType(Of Label)()
                       Where lbl.Name = "lblTitleName"
        For Each lbl As Label In allLabel
            lbl.ForeColor = Color.WhiteSmoke
            lbl.BackColor = Color.Transparent

            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.AutoSize = False
            lbl.Width = f.Width / 2
            lbl.Left = f.Width - lbl.Width - 14

            lbl.Top = (75 * f.Height) / 1080
        Next
        allLabel = Nothing
        f.Text = My.Application.Info.ProductName

        Dim ucStatus_All = From ucStatus In f.Controls.OfType(Of UserControl)() Where ucStatus.Name = "UcStatus1"
        For Each ucStatus As UserControl In ucStatus_All
            ucStatus.Height = 60
            ucStatus.Dock = DockStyle.Bottom

        Next
        ucStatus_All = Nothing

        Dim ucClosed_All = From ucClosed In f.Controls.OfType(Of UserControl)()
                           Where ucClosed.Name = "UcClose1"
        For Each ucClosed As UserControl In ucClosed_All
            ucClosed.Left = f.Width - ucClosed.Width
            ucClosed.Top = 0
            ucClosed.Height = (65 * f.Height) / 1080
            ucClosed.Width = (65 * f.Width) / 1920
        Next
        ucClosed_All = Nothing

        Dim UcMinimize_All = From UcMinimize In f.Controls.OfType(Of UserControl)()
                             Where UcMinimize.Name = "UcMinimize1"
        For Each UcMinimize As UserControl In UcMinimize_All
            UcMinimize.Left = f.Width - (UcMinimize.Width * 2)
            UcMinimize.Top = 0
            UcMinimize.Height = (65 * f.Height) / 1080
            UcMinimize.Width = (65 * f.Width) / 1920
        Next
        UcMinimize_All = Nothing

        Dim ctrlDGV = From ctrl In f.Controls.OfType(Of DataGridView)() 'Where ctrl.Name = "DataGridView1"

        For Each ctrl As DataGridView In ctrlDGV
            With ctrl
                '.Width = 806
                '.Height = 534
                '.Left = 33
                '.Top = 133
                .Anchor = AnchorStyles.Left + AnchorStyles.Right = AnchorStyles.Bottom + AnchorStyles.Top
                .RowHeadersVisible = True
                .CellBorderStyle = DataGridViewCellBorderStyle.None
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .DefaultCellStyle.ForeColor = Color.Black
            End With
            For i As Integer = 0 To ctrl.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = ctrl.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
        Next
        ctrlDGV = Nothing

        Dim allCtrl As Object

        allCtrl = From ctrl In f.Controls.OfType(Of DataGridView)()

        allCtrl = Nothing

        'Initial ucMnu
        allCtrl = Nothing
        InitialUcMnu(f)
        'InitialSplitContainer(f)
    End Sub

    Private Sub InitialUcMnu(ByRef f As Form)
        Dim allUc = From uc In f.Controls.OfType(Of UserControl)()

        'Draw Image background
        For Each u As UserControl In allUc
            If u.Name.IndexOf("UcMnu") > -1 Or u.Name.IndexOf("ucMenutxt") > -1 Then

                Dim bm As New Bitmap(u.Width, u.Height)

                ' Associate a Graphics object with the Bitmap
                Using gr As Graphics = Graphics.FromImage(bm)
                    ' Define source and destination rectangles.
                    Dim src_rect As New Rectangle(u.Left, u.Top, u.Width,
                        u.Height)
                    Dim dst_rect As New Rectangle(0, 0, u.Width, u.Height)

                    ' Copy that part of the image.
                    gr.DrawImage(f.BackgroundImage, dst_rect, src_rect,
                        GraphicsUnit.Pixel)
                End Using

                ' Display the result.
                u.BackgroundImage = bm

                bm = Nothing
                bm.Dispose()
            End If
        Next
    End Sub

    Private Sub DrawString(ByRef f As Form)
        Dim formGraphics As System.Drawing.Graphics = f.CreateGraphics()
        Dim drawString As String = "Sample Text"
        Dim drawFont As New System.Drawing.Font("Arial", 16)
        'Dim drawFont As New System.Drawing.Font
        Dim drawBrush As New _
           System.Drawing.SolidBrush(System.Drawing.Color.WhiteSmoke)
        Dim x As Single = 360.0
        Dim y As Single = 80.0
        Dim drawFormat As New System.Drawing.StringFormat

        formGraphics.DrawString(drawString, drawFont, drawBrush, _
            x, y, drawFormat)
        drawFont.Dispose()
        drawBrush.Dispose()
        formGraphics.Dispose()
    End Sub

    Private Function ResizeBitmap(ByRef pBitmap As Bitmap, ByVal pWidth As Integer, ByVal pHeight As String) As Bitmap
        'make a blank bitmap the correct size  
        Dim vWidth, vHeight As Integer
        vWidth = pWidth : vHeight = pHeight
        Dim NewBitmap As New Bitmap(vWidth, vHeight)

        'make an instance of graphics that will draw on "NewBitmap"  

        Dim BitmpGraphics As Graphics = Graphics.FromImage(NewBitmap)

        'work out the scale factor  

        Dim scaleFactorX As Integer = pBitmap.Width / pWidth

        Dim scaleFactorY As Integer = pBitmap.Height / pHeight

        'resize the graphics  

        BitmpGraphics.ScaleTransform(scaleFactorX, scaleFactorY)

        'draw the bitmap to NewBitmap  
        BitmpGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic
        BitmpGraphics.DrawImage(pBitmap, 0, 0)

        Return NewBitmap

    End Function

    Function ConvertPixelToPoint(ByVal pPixel As Single, ByVal pDPI As Single) As Integer
        '•There are 72 points in an inch (that is what a point is, 1/72 of an inch)
        '•on a system set for 150dpi, there are 150 pixels per inch.
        '•1 in = 72pt = 150px (for 150dpi setting)

        'points = (pixels / 96) * 72 on a standard XP/Vista/7 machine (factory defaults)
        'points = (pixels / 72) * 72 on a standard Mac running OSX (Factory defaults)
        'Windows runs as default at 96dpi (display) Macs run as default at 72 dpi (display)
        'Ex: 14 horizontal points = (14 * DpiX) / 72 pixels
        Return pPixel * pDPI / 72
    End Function
#End Region

    'Public Sub ExitProgram()
    '    'UcStatus1.StopThread()
    '    Oradb.Dispose()

    '    mMenuStack.Clear()
    '    mForm.Clear()
    '    'Me.Close()
    '    mLog = Nothing
    '    End
    'End Sub

    Public Sub OpenPictureDriver(ByRef pSource As String)
        Dim openFileDialog1 As New OpenFileDialog()
        With openFileDialog1
            .Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg"
            .Multiselect = False
        End With
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            pSource = openFileDialog1.FileName.ToString()
        End If
    End Sub

    Public Function CopyPictureDriver(ByVal pSorce As String _
                                      , ByVal pNewFileName As String) As Boolean
        Try
            Dim vDest As String = GetPathPictureDriver()
            Dim vFileExtention As String = System.IO.Path.GetExtension(pSorce)
            Dim vFileName As String = System.IO.Path.GetFileName(pSorce)
            If Not Directory.Exists(vDest) Then
                Directory.CreateDirectory(vDest)
            End If
            System.IO.File.Copy(pSorce, vDest & pNewFileName & vFileExtention, True)
            DeletePictureDriver(vDest & pNewFileName & vFileExtention)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            mLog.WriteErrMessage(ex.Message)
            Return False
        End Try
    End Function

    Public Function DeletePictureDriver(ByVal pSorce As String)
        Try
            My.Computer.FileSystem.DeleteFile(pSorce, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            mLog.WriteErrMessage(ex.Message)
            Return False
        End Try
    End Function

    Public Function chk_null_txt(ByVal db As Object) As String
        If IsDBNull(db) Then
            Return ""
        Else
            Return db
        End If
    End Function

    Public Function txt_num(ByVal str As String) As String 'text box number only
        If Trim(str) <> "" Then
            Try
                Dim tmp As Long = CLng(Trim(str))
                Return Trim(str)
            Catch ex As Exception
                MsgBox("สามารถใส่ได้เฉพาะตัวเลขเท่านั้น")
                Return ""
            End Try
        End If
        Return Trim(str)
    End Function

    Public Function FDateTime(ByVal vDate As Object) As Object
        If IsDBNull(vDate) Then
            FDateTime = ""
        Else
            FDateTime = Format(vDate, "dd/MM/yyyy HH:mm:ss")
        End If
    End Function

    Public Function FDate(ByVal vDate As Object) As Object
        If IsDBNull(vDate) Then
            FDate = ""
        Else
            FDate = Format(vDate, "dd/MM/yyyy")
        End If
    End Function

    Public Function Datenn(ByVal Datein As Object)
        If IsDBNull(Datein) Then
            Datenn = "Null"
        Else
            Datenn = "to_date('" & Datein & "','dd/mm/yyyy')"
        End If
    End Function

    Public Function CurrencyOnly(ByVal TargetTextBox As TextBox, ByVal CurrentChar As Char) As Boolean
        If IsNumeric(CurrentChar) = True Then
            Return False
        End If

        If CBool(((Convert.ToString(CurrentChar) = "." AndAlso CBool(InStr(TargetTextBox.Text, "."))))) Then
            Return True
        End If

        If Convert.ToString(CurrentChar) = "." OrElse CurrentChar = vbBack Then
            Return False
        End If

        Return True
    End Function

    Public Sub resolution(ByRef f As Form, ByRef zoom As Double)

        Exit Sub
        Dim listLable As New Collection
        Dim listObj As New Collection
        '------ Match Label and obj ---------------
        Dim lbl
        Dim betweenX
        Dim betweenY
        'For Each box In f.Controls.OfType(Of GroupBox)()
        For Each lbl In f.Controls.OfType(Of Label)()
            For Each obj In f.Controls
                betweenX = obj.location.x - (lbl.location.x + lbl.Size.Width)
                betweenY = lbl.location.y - obj.location.y
                If (betweenX < 17 And betweenX > 0) And (betweenY < 5 And betweenY > -5) Then
                    listLable.Add(lbl)
                    listObj.Add(obj)
                End If
            Next
        Next
        'Next

        For Each box In f.Controls.OfType(Of GroupBox)()
            For Each lbl In box.Controls.OfType(Of Label)()
                For Each obj In box.Controls
                    betweenX = obj.location.x - (lbl.location.x + lbl.Size.Width)
                    betweenY = lbl.location.y - obj.location.y
                    If (betweenX < 17 And betweenX > 0) And (betweenY < 5 And betweenY > -5) Then
                        listLable.Add(lbl)
                        listObj.Add(obj)
                    End If
                Next
            Next
        Next
        '-------- end Match Label and obj --------

        Dim defaultWidhtScreen As Integer = 1024
        Dim defaultHeightScreen As Integer = 768
        Dim percentW As Double = 0
        Dim percentH As Double = 0
        percentW = ((f.Size.Width) / defaultWidhtScreen) * zoom
        percentH = ((f.Size.Height) / defaultHeightScreen) * zoom

        For Each ctrl In f.Controls.OfType(Of GroupBox)()
            ctrl.Size = New Size(ctrl.Size.Width * percentW, ctrl.Size.Height * percentH)
            ctrl.Location = New Point(ctrl.Location.X * percentW, ctrl.Location.Y * percentH)
            For Each xObject As Object In ctrl.Controls
                xObject.Size = New Size(xObject.Size.Width * percentW, xObject.Size.Height * percentH)
                xObject.Location = New Point(xObject.Location.X * percentW, xObject.Location.Y * percentH)
            Next
        Next

        Dim b As Boolean
        For Each ctrl1 In f.Controls
            b = True
            For Each ctrl2 In f.Controls.OfType(Of GroupBox)()
                If ctrl1.name = ctrl2.Name Then
                    b = False
                End If
                For Each xObject As Object In ctrl2.Controls
                    If ctrl1.name = ctrl2.Name Then
                        b = False
                    End If
                Next
            Next
            If ctrl1.name = "UcClose1" Or ctrl1.name = "UcMinimize1" Or ctrl1.name = "UcStatus1" Or ctrl1.name = "lblTitleName" Then
                b = False
            End If
            If b Then
                ctrl1.Size = New Size(ctrl1.Size.Width * percentW, ctrl1.Size.Height * percentH)
                ctrl1.Location = New Point(ctrl1.Location.X * percentW, ctrl1.Location.Y * percentH)
            End If
        Next


        '-----------  cal position label and obj --------------
        Dim n = 1
        For Each lable In listLable
            lable.Location = New Point(listObj(n).Location.X - lable.size.Width, lable.Location.Y)
            n += 1
        Next
        '----------- End cal position Label and obj ------------ 

        For Each ctrl In f.Controls.OfType(Of ucProgressOverView)()
            'ctrl.updateProgress()
        Next
    End Sub

    Private Sub CHECK_AUTHORIZE_SCREEN(mUserName As String, mScreenID As Long, p3 As Integer)
        Throw New NotImplementedException
    End Sub
    Public Function GetVersion() As String
        Return "Version " & My.Application.Info.Version.ToString()
    End Function
    Public Function GetAppPath() As String
        Return New FileInfo(Application.ExecutablePath).DirectoryName
    End Function
    Function GetPrinterName(ByVal Report_ID As String) As String
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        GetPrinterName = ""
        sql_str = " SELECT T.PRINTER_NAME FROM  TAS.PRINTER_TAS T
                    INNER JOIN TAS.REPORT_SETTING R
                    ON R.PRINTER_ID = T.PRINTER_ID 
                    AND R.REPORT_ID= " & Report_ID
        If Oradb.OpenDys(sql_str, "tbName", mDataSet) Then
            dt = mDataSet.Tables("tbName")
            If dt.Rows.Count > 0 Then
                GetPrinterName = dt.Rows(0)("PRINTER_NAME").ToString()
            End If
        End If
    End Function
    Public Function DirectPrinter(ByVal iReport_ID As String, Optional ByVal iSQL As String = "", Optional ByVal iParam1 As String = "", Optional ByVal iParam2 As String = "", Optional ByVal iParam3 As String = "") As Boolean
        Dim path As String = GetAppPath()
        Dim PrinterName As String
        Dim rptFileName As String
        Dim dt As DataTable

        Try
            PrinterName = GetPrinterName(iReport_ID)
            rptFileName = path & "\Report Files\" & GetReportFileName(iReport_ID)
            Select Case iReport_ID
                'การจ่ายกับกรมทางหลวงเรียงตามบริษัทประจำวัน
                Case Is = "52010049"
                    Using rpt As ReportDocument = New ReportDocument()
                        Dim printerSettings As PrinterSettings = New PrinterSettings()
                        printerSettings.PrinterName = PrinterName
                        dt = CRService.Query_TBL(iSQL)
                        rpt.Load(rptFileName)
                        rpt.SetDataSource(dt)
                        rpt.SetParameterValue(0, iParam1)
                        If printerSettings.IsValid Then
                            rpt.PrintOptions.PrinterName = PrinterName
                            rpt.PrintToPrinter(1, False, 0, 0)
                        End If
                    End Using
               'การจ่ายกับกรมทางหลวงทั้งหมดประจำวัน
                Case Is = "52010059"
                    Using rpt As ReportDocument = New ReportDocument()
                        Dim printerSettings As PrinterSettings = New PrinterSettings()
                        printerSettings.PrinterName = PrinterName
                        dt = CRService.Query_TBL(iSQL)
                        rpt.Load(rptFileName)
                        rpt.SetDataSource(dt)
                        rpt.SetParameterValue(0, iParam1)
                        If printerSettings.IsValid Then
                            rpt.PrintOptions.PrinterName = PrinterName
                            rpt.PrintToPrinter(1, False, 0, 0)
                        End If
                    End Using

                'รายงานการจ่ายทางรถบรรทุก
                Case Is = "52010007"
                    Using rpt As ReportDocument = New ReportDocument()
                        Dim printerSettings As PrinterSettings = New PrinterSettings()
                        printerSettings.PrinterName = PrinterName
                        dt = CRService.DAILY_LOADING_DETAIL(iParam1)
                        rpt.Load(rptFileName)
                        rpt.SetDataSource(dt)
                        rpt.SetParameterValue(0, CType(iParam1, Integer))
                        If printerSettings.IsValid Then
                            rpt.PrintOptions.PrinterName = PrinterName
                            rpt.PrintToPrinter(1, False, 0, 0)
                        End If
                    End Using

                'รายงานใบกำกับสินค้า-Delivery Receive(Manual)
                Case Is = "52010040"
                    Using rpt As ReportDocument = New ReportDocument()
                        Dim printerSettings As PrinterSettings = New PrinterSettings()
                        printerSettings.PrinterName = PrinterName
                        dt = CRService.VIEW_DELIV_HEADER(iParam1)
                        Dim dtLine As DataTable = CRService.VIEW_DELIV_LINE(iParam1)
                        Dim dtSumLine As DataTable = CRService.VIEW_DELIV_SUM_LINE(iParam1)
                        rpt.Load(rptFileName)
                        rpt.SetDataSource(dt)
                        rpt.Subreports(0).SetDataSource(dtLine)
                        rpt.Subreports(1).SetDataSource(dtSumLine)
                        rpt.SetParameterValue(0, CType(iParam1, Integer))
                        If printerSettings.IsValid Then
                            rpt.PrintOptions.PrinterName = PrinterName
                            rpt.PrintToPrinter(1, False, 0, 0)
                        End If
                        dtLine = Nothing
                        dtSumLine = Nothing
                    End Using

               'รายงานแนบกรมทางหลวง
                Case Is = "52010057"
                    Using rpt As ReportDocument = New ReportDocument()
                        Dim printerSettings As PrinterSettings = New PrinterSettings()
                        printerSettings.PrinterName = PrinterName
                        dt = CRService.VIEW_GOV_PROJECT_ATTACHAS(iParam1)
                        rpt.Load(rptFileName)
                        rpt.SetDataSource(dt)
                        rpt.SetParameterValue(0, CType(iParam1, Integer))

                        If printerSettings.IsValid Then
                            rpt.PrintOptions.PrinterName = PrinterName
                            rpt.PrintToPrinter(1, False, 0, 0)
                        End If
                    End Using

                'รายงาน ใบชั่งน้ำหนัก
                Case Is = "52010031"
                    Using rpt As ReportDocument = New ReportDocument()
                        Dim printerSettings As PrinterSettings = New PrinterSettings()
                        printerSettings.PrinterName = PrinterName
                        dt = CRService.VIEW_DATA_WEIGHT(iParam1)
                        rpt.Load(rptFileName)
                        rpt.SetDataSource(dt)
                        rpt.SetParameterValue(0, CType(iParam1, Integer))

                        If printerSettings.IsValid Then
                            rpt.PrintOptions.PrinterName = PrinterName
                            rpt.PrintToPrinter(1, False, 0, 0)
                        End If
                    End Using

            End Select

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด " & ex.Message)
            Return False
        Finally
            dt = Nothing
        End Try
        Return True
    End Function
End Module
