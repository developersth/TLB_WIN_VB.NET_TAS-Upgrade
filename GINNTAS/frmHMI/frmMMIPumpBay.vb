
Imports Oracle.DataAccess.Client
Imports System.Data
Imports System.IO

Public Class frmMMIPumpBay

    Public FormScreenID As Long
    Dim frm_work As Integer = 0
    Dim B_ScanTime As Boolean
    Dim ListPumpId As New Collection
    Dim ListPumpName As New Collection
    Dim ListProductId As New Collection
    Dim ListStatusRun As New Collection
    Dim ListStatusAlarm As New Collection
    Dim ListProduct As New Collection

    Dim ListGroupBox As New Collection


    Dim ArrayListPumpId(100) As String
    Dim ArrayListPumpName(100) As String
    Dim ArrayListProductId(100) As String
    Dim ArrayListStatusRun(100) As String
    Dim ArrayListStatusAlarm(100) As String


    Dim countPump = 18
    Dim firstPumpInPage = 1

    Private Sub frmMMIPumpBay_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmMMIPumpBay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        resolution(Me, 1)
        addList()
        InitialCombo()
        TimerStatus.Start()

        'InitialPicture()
    End Sub
    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub
    Private Sub InitialCombo()

        Dim strSQL =
            "select distinct v.PRODUCT_ID from view_map_pump v" &
            " where v.PUMP_TYPE='L'"
        assignDropDown(strSQL, "PRODUCT_ID", CmbProduct)

    End Sub
    Private Sub InitialPicture()
        statusRun1.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\PumpRunR.png")
        statusRun2.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\PumpRunR.png")
        statusRun3.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\PumpRunR.png")
        statusRun4.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\PumpRunR.png")
        statusRun5.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\PumpRunR.png")
        statusRun6.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\PumpRunR.png")

        statusAlarm1.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\PumpRunR.png")
        statusAlarm2.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\PumpRunR.png")
        statusAlarm3.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\PumpRunR.png")
        statusAlarm4.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\PumpRunR.png")
        statusAlarm5.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\PumpRunR.png")
        statusAlarm6.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\PumpRunR.png")
        picLeft.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowGreenLeft.png")
        picRight.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowGreenRight.png")

    End Sub

    Sub addList()


        ListGroupBox.Add(g1)
        ListGroupBox.Add(g2)
        ListGroupBox.Add(g3)
        ListGroupBox.Add(g4)
        ListGroupBox.Add(g5)
        ListGroupBox.Add(g6)

        ListPumpId.Add(TxtPumpId1)
        ListPumpId.Add(TxtPumpId2)
        ListPumpId.Add(TxtPumpId3)
        ListPumpId.Add(txtPumpId4)
        ListPumpId.Add(txtPumpId5)
        ListPumpId.Add(txtPumpId6)

        ListPumpName.Add(txtPumpName1)
        ListPumpName.Add(txtPumpName2)
        ListPumpName.Add(txtPumpName3)
        ListPumpName.Add(txtPumpName4)
        ListPumpName.Add(txtPumpName5)
        ListPumpName.Add(txtPumpName6)


        ListProductId.Add(txtProductId1)
        ListProductId.Add(txtProductId2)
        ListProductId.Add(txtProductId3)
        ListProductId.Add(txtProductId4)
        ListProductId.Add(txtProductId5)
        ListProductId.Add(txtProductId6)


        ListStatusRun.Add(statusRun1)
        ListStatusRun.Add(statusRun2)
        ListStatusRun.Add(statusRun3)
        ListStatusRun.Add(statusRun4)
        ListStatusRun.Add(statusRun5)
        ListStatusRun.Add(statusRun6)

        ListStatusAlarm.Add(statusAlarm1)
        ListStatusAlarm.Add(statusAlarm2)
        ListStatusAlarm.Add(statusAlarm3)
        ListStatusAlarm.Add(statusAlarm4)
        ListStatusAlarm.Add(statusAlarm5)
        ListStatusAlarm.Add(statusAlarm6)

    End Sub
    Function assignDropDown(ByVal sql_str As String, ByVal colName As String, ByVal cb As System.Object) As Boolean
        cb.Items.Clear()
        If "PRODUCT_ID" = colName Then

            CmbProduct.Items.Add("ALL")
            CmbProduct.SelectedIndex = 0
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

        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
        Return True
    End Function

    Public Sub setStatus(ByVal i As Integer, ByVal stateRun As Integer, ByVal stateAlarm As Integer)
        If stateRun = "1" Then
            'ListStatusRun(i).Image = My.Resources.ResourceManager.GetObject("GG")
            ListStatusRun(i).Image = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\PumpRunG.png")
        Else
            'ListStatusRun(i).Image = My.Resources.ResourceManager.GetObject("Grey")
            ListStatusRun(i).Image = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\PumpRunR.png")
        End If

        If stateAlarm = "1" Then
            'ListStatusAlarm(i).Image = My.Resources.ResourceManager.GetObject("RR")
            ListStatusRun(i).Image = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\PumpRunR.png")
        Else
            'ListStatusAlarm(i).Image = My.Resources.ResourceManager.GetObject("Grey")
            ListStatusAlarm(i).Image = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\PumpRunGrey.png")
        End If

    End Sub


    Sub intialData()

        Dim strSQL

        Dim strSqlCondition = ""
        If r2.Checked = True Then
            strSqlCondition &= " And STATUS_RUN = 1 "
        End If
        If r3.Checked = True Then
            strSqlCondition &= " And STATUS_RUN = 0 "
        End If
        If a2.Checked = True Then
            strSqlCondition &= " And STATUS_ALARM = 1 "
        End If
        If a3.Checked = True Then
            strSqlCondition &= " And STATUS_ALARM = 0 "
        End If
        If CmbProduct.Text = "ALL" Then
            strSQL =
                "select P.PUMP_ID,P.PUMP_NAME,P.PRODUCT_ID,P.POS_X,P.POS_Y,P.STATUS_RUN,P.STATUS_ALARM " &
                "from VIEW_MAP_PUMP P " &
                "where 1=1 " &
                strSqlCondition &
                "AND   P.PUMP_TYPE='L' " &
                "order by P.MAPPING_ID"
        Else
            strSQL =
               "select P.PUMP_ID,P.PUMP_NAME,P.PRODUCT_ID,P.POS_X,P.POS_Y,P.STATUS_RUN,P.STATUS_ALARM " &
               "from VIEW_MAP_PUMP P " &
               "where  P.PUMP_TYPE='L'  " &
               strSqlCondition &
               "AND P.PRODUCT_ID ='" & CmbProduct.Text & "' " &
               "order by P.MAPPING_ID"
        End If
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        If Oradb.OpenDys(strSQL, "TableName2", mDataSet) Then
            dt = mDataSet.Tables("TableName2")
            Dim i As Integer = 0
            Do While dt.Rows.Count > i
                ArrayListPumpId(i) = (IIf(IsDBNull(dt.Rows(i).Item("PUMP_ID")), "", dt.Rows(i).Item("PUMP_ID").ToString))
                ArrayListPumpName(i) = (IIf(IsDBNull(dt.Rows(i).Item("PUMP_NAME")), "", dt.Rows(i).Item("PUMP_NAME").ToString))
                ArrayListProductId(i) = (IIf(IsDBNull(dt.Rows(i).Item("PRODUCT_ID")), "", dt.Rows(i).Item("PRODUCT_ID").ToString))
                ArrayListStatusRun(i) = (IIf(IsDBNull(dt.Rows(i).Item("STATUS_RUN")), "0", dt.Rows(i).Item("STATUS_RUN").ToString))
                ArrayListStatusAlarm(i) = (IIf(IsDBNull(dt.Rows(i).Item("STATUS_ALARM")), "0", dt.Rows(i).Item("STATUS_ALARM").ToString))
                i += 1
            Loop
            countPump = i
        End If
        txtCountPump.Text = countPump
        firstPumpInPage = 1
        initialDeta()
        lblPreviousPump.Visible = False
        'picLeft.Image = My.Resources.ResourceManager.GetObject("arrowWhiteLeft")
        picLeft.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowWhiteLeft.png")
        picLeft.Visible = False
        If firstPumpInPage + 5 < countPump Then
            'picRight.Image = My.Resources.ResourceManager.GetObject("arrowGreenRight")
            picRight.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowGreenRight.png")
            picRight.Visible = True
            lblNextPump.Visible = True
        Else
            'picRight.Image = My.Resources.ResourceManager.GetObject("arrowWhiteRight")
            picRight.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowGreenRight.png")
            picRight.Visible = False
            lblNextPump.Visible = False
        End If

        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub

    Private Sub CmbProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProduct.SelectedIndexChanged
        TimerStatus.Stop()
        r1.Checked = True
        a1.Checked = True
        intialData()
        TimerStatus.Start()
    End Sub

    Sub initialDeta()
        clearData()

        Dim i As Integer = 1
        Dim no As Integer = firstPumpInPage - 1
        Do While no < countPump And i < 7
            ListPumpId(i).text = ArrayListPumpId(i - 1)
            ListPumpName(i).text = ArrayListPumpName(i - 1)
            ListProductId(i).text = ArrayListProductId(i - 1)
            setStatus(i, ArrayListStatusRun(i - 1), ArrayListStatusAlarm(i - 1))
            i += 1
            no += 1
        Loop


        Dim j As Integer = 1
        Do While j <= 6
            ListGroupBox(j).text = "No. " & (firstPumpInPage + j - 1)
            If firstPumpInPage + j - 1 <= countPump Then
                ListGroupBox(j).BackColor = Color.CadetBlue
                ListGroupBox(j).visible = True
            Else
                'ListGroupBox(j).BackColor = Color.Transparent
                ListGroupBox(j).visible = False
            End If
            j += 1
        Loop

    End Sub



    Private Sub Right_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If firstPumpInPage + 5 < countPump Then
            'picRight.Image = My.Resources.ResourceManager.GetObject("arrowGreenRight")
            picRight.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowGreenRight.png")
            picRight.Visible = True
            lblNextPump.Visible = True
        Else
            picRight.Image = My.Resources.ResourceManager.GetObject("arrowWhiteRight")
            picRight.Visible = False
            lblNextPump.Visible = False
        End If
    End Sub

    Private Sub Right_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If firstPumpInPage + 5 < countPump Then
            'picRight.Image = My.Resources.ResourceManager.GetObject("arrowGreenRightHover")
            picRight.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowGreenRightHover.png")
            picRight.Visible = True
            lblNextPump.Visible = True
        Else
            'picRight.Image = My.Resources.ResourceManager.GetObject("arrowWhiteRight")
            picRight.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowWhiteRight.png")
            picRight.Visible = False
            lblNextPump.Visible = False
        End If
    End Sub

    Private Sub Right_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If firstPumpInPage + 5 < countPump Then
            firstPumpInPage += 6
            'picLeft.Image = My.Resources.ResourceManager.GetObject("arrowGreenLeft")
            'picRight.Image = My.Resources.ResourceManager.GetObject("arrowGreenRight")
            picLeft.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowGreenLeft.png")
            picRight.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowGreenRight.png")
            picRight.Visible = True
            picLeft.Visible = True
            lblNextPump.Visible = True
            lblPreviousPump.Visible = True
            initialDeta()
        Else
            'picRight.Image = My.Resources.ResourceManager.GetObject("arrowWhiteRight")
            picRight.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowGreenRight.png")
            picRight.Visible = False
            lblNextPump.Visible = False
        End If
    End Sub

    Private Sub picLeft_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLeft.MouseMove
        If firstPumpInPage > 1 Then
            'picLeft.Image = My.Resources.ResourceManager.GetObject("arrowGreenLeftHover")
            picLeft.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowGreenLeftHover.png")
            picLeft.Visible = True
            lblPreviousPump.Visible = True
        Else
            'picLeft.Image = My.Resources.ResourceManager.GetObject("arrowWhiteLeft")
            picRight.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowGreenRight.png")
            picLeft.Visible = False
            lblPreviousPump.Visible = False
        End If
    End Sub

    Private Sub picLeft_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If firstPumpInPage > 1 Then
            'picLeft.Image = My.Resources.ResourceManager.GetObject("arrowGreenLeft")
            picLeft.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowGreenLeft.png")
            picLeft.Visible = True
            lblPreviousPump.Visible = True
        Else
            'picLeft.Image = My.Resources.ResourceManager.GetObject("arrowWhiteLeft")
            picLeft.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowGreenLeft.png")
            picLeft.Visible = False
            lblPreviousPump.Visible = False
        End If
    End Sub


    Private Sub picLeft_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'picLeft.Image = My.Resources.ResourceManager.GetObject("arrowGreenLeft")
        picLeft.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowGreenLeft.png")
        If firstPumpInPage > 1 Then
            firstPumpInPage -= 6
            'picRight.Image = My.Resources.ResourceManager.GetObject("arrowGreenRight")
            'picLeft.Image = My.Resources.ResourceManager.GetObject("arrowGreenLeft")
            picRight.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowGreenRight.png")
            picLeft.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowGreenLeft.png")
            picLeft.Visible = True
            picRight.Visible = True
            lblNextPump.Visible = True
            lblPreviousPump.Visible = True
            initialDeta()
        Else
            'picLeft.Image = My.Resources.ResourceManager.GetObject("arrowWhiteLeft")
            picLeft.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\arrowGreenLeft.png")
            picLeft.Visible = False
            lblPreviousPump.Visible = False
        End If

    End Sub


    Private Sub r1L_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r1.CheckedChanged
        intialData()
    End Sub

    Private Sub r2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r2.CheckedChanged
        intialData()
    End Sub

    Private Sub r3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles r3.CheckedChanged
        intialData()
    End Sub

    Private Sub a1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a1.CheckedChanged
        intialData()
    End Sub

    Private Sub a2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a2.CheckedChanged
        intialData()
    End Sub

    Private Sub a3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a3.CheckedChanged
        intialData()
    End Sub
    Sub clearData()
        Dim i As Integer = 1
        Do While i <= 6
            ListPumpId(i).text = ""
            ListPumpName(i).text = ""
            ListProductId(i).text = ""
            setStatus(i, "0", "0")
            i += 1
        Loop
    End Sub

    Private Sub picLeft_MouseMove(sender As Object, e As MouseEventArgs) Handles picLeft.MouseMove

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

    Private Sub TimerStatus_Tick(sender As Object, e As EventArgs) Handles TimerStatus.Tick
        r1.Checked = True
        a1.Checked = True
        intialData()
    End Sub
End Class