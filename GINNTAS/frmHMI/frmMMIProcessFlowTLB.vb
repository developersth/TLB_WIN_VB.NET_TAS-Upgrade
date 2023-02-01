Imports System.Data
Imports System.Threading

Public Class frmMMIProcessFlowTLB

    Public FormScreenID As Long
    Dim frm_work As Integer = 0

    Dim B_ScanTime As Boolean, strPumpSelect As String
    Dim PicSelect As PictureBox
    Dim ProductColor(0 To 5) As Long
    Dim vPage As Integer
    Dim indexMeter As Integer
    Dim MeterCount As Long
    Dim UcFlowLoading As New Collection
    Dim vRun As Thread



    Private Sub frmMMIProcessFlowTLB_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        'UcStatus1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub
    Private Sub frmMMIProcessFlowTLB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        vPage = 1
        indexMeter = 0
        'InitialForm(Me, lblTitleName.Text)
        SetScreenResulotion()
        CheckFormResize(Me)
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        GetMeterCount()
        InitailFlowMeter()
        GetActiveBay()
        Time_Scan.Start()
    End Sub

    Private Sub GetMeterCount()

        Dim strSQL As String
        Dim i As Integer
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        mDataSet = Nothing

        strSQL = " select count (*)  as coutMeter   from  tas.meter t "

        ''---------------------------
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            i = 0
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                MeterCount = IIf(IsDBNull(dt.Rows(i).Item("coutMeter")), 0, dt.Rows(i).Item("coutMeter"))
            End If
        Else
        End If
        mDataSet = Nothing

    End Sub

    Private Sub InitailFlowMeter()
        Dim i As Integer
        'UcFlowLoading(0).Move(360, 1620, 14610, 3210)
        For i = 1 To MeterCount
            If i <> 0 Then
                UcFlowLoading.Add(New UcFlowLoading())
                'UcFlowLoading(i).visible = False
                'UcFlowLoading(i).BringToFront()
                pnlShowData.Controls.Add(UcFlowLoading(i))
                'Load(UcFlowLoading(i))
                Select Case i
                    Case 1, 5, 9, 13, 17, 21
                        'UcFlowLoading(i).Move(UcFlowLoading(0).Left, UcFlowLoading(0).Top, UcFlowLoading(0).Width, UcFlowLoading(0).Height)
                        UcFlowLoading(i).location = New Point(UcFlowLoadingTLB1.Location.X, UcFlowLoadingTLB1.Location.Y)
                    Case Else
                        'UcFlowLoading(i).Move(UcFlowLoading(i - 1).Left, UcFlowLoading(i - 1).Top + UcFlowLoading(i - 1).Height, UcFlowLoading(i - 1).Width, UcFlowLoading(i - 1).Height)
                        UcFlowLoading(i).location = New Point(UcFlowLoading(i - 1).Location.X, UcFlowLoading(i - 1).Location.Y + +UcFlowLoadingTLB1.Size.Height)
                End Select
            End If
            If vPage = 1 And i < 5 Then
                UcFlowLoading(i).Visible = True
            End If
        Next i
        InitailMeter()
    End Sub
    Private Sub InitailMeter()
        Dim strSQL As String
        Dim i As Integer
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        mDataSet = Nothing

        strSQL = " select t.meter_no   from  tas.meter t "

        ''---------------------------
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            i = 0
            dt = mDataSet.Tables("TableName1")
            Do While dt.Rows.Count > i

                UcFlowLoading(i + 1).SetMeter(i, IIf(IsDBNull(dt.Rows(i).Item("Meter_no")), "??", dt.Rows(i).Item("Meter_no")))
                If i > 3 Then
                    UcFlowLoading(i + 1).ControlPicShow(2)

                Else
                    UcFlowLoading(i + 1).ControlPicShow(0)
                End If
                i += 1
            Loop
        Else
        End If
        mDataSet = Nothing

    End Sub

    Private Sub GetActiveBay()
        Try
            For index = 0 To UcFlowLoading.Count - 1
                UcFlowLoading(indexMeter + 1).GetDetailFlowLineMeter(CInt(indexMeter))
                indexMeter = index + 1
                If (indexMeter = UcFlowLoading.Count) Then
                    indexMeter = 0
                End If
            Next

            'If indexMeter <= UcFlowLoading.Count - 1 Then
            'UcFlowLoading(indexMeter + 1).GetDetailFlowLineMeter(CInt(indexMeter))
            'indexMeter = indexMeter + 1
            'If indexMeter = UcFlowLoading.Count Then
            '    indexMeter = 0
            'End If
            'End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmMMIProcessFlow_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmMMIProcessFlow_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub


    Private Sub CmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBack.Click
        ShowFlow()
        vPage = vPage - 1
        indexMeter = 0
        CmdBack.Enabled = False
        CmdNext.Enabled = True
        If vPage = 0 Then
            vPage = 1
        End If
        ClikPage(vPage)
    End Sub
    Private Sub ShowFlow()
        Dim i As Integer
        For i = 0 To MeterCount - 1
            UcFlowLoading(i + 1).Visible = True
        Next i
    End Sub


    Private Sub ClikPage(ByVal iPage As Integer)
        Dim i As Integer
        For i = 0 To UcFlowLoading.Count - 1
            UcFlowLoading(i + 1).Visible = False
            If iPage = 1 Then
                Select Case i
                    Case 0 To 3
                        UcFlowLoading(i + 1).Visible = True
                    Case Else
                        UcFlowLoading(i + 1).Visible = False
                End Select
            ElseIf iPage = 2 Then
                Select Case i
                    Case 4 To 7
                        UcFlowLoading(i + 1).Visible = True
                    Case Else
                        UcFlowLoading(i + 1).Visible = False
                End Select
            ElseIf iPage = 3 Then
                Select Case i
                    Case 8 To 11
                        UcFlowLoading(i + 1).Visible = True
                    Case Else
                        UcFlowLoading(i + 1).Visible = False
                End Select
            End If
        Next i
    End Sub

    Private Sub CmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNext.Click
        Dim i As Long
        ShowFlow()
        vPage = vPage + 1
        indexMeter = 4
        CmdBack.Enabled = True
        CmdNext.Enabled = False
        If vPage > 2 Then
            vPage = 2
        End If
        ClikPage(vPage)
        For i = 0 To UcFlowLoading.Count - 1
            If i > 3 Then
                UcFlowLoading(i + 1).ControlPicShow(2)
            Else
                UcFlowLoading(i + 1).ControlPicShow(0)
            End If
        Next
    End Sub

    Private Sub Time_Scan_Tick(sender As System.Object, e As System.EventArgs) Handles Time_Scan.Tick
        GetActiveBay()
    End Sub
    Private Sub UcHeader1_CloseButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.CloseButtonClick
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UcHeader1_MinimizeButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.MinimizeButtonClick
        WindowState = FormWindowState.Minimized
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
#Region "thread"
    Dim tExit As Boolean
    Dim tThread As Thread

    Private Sub StartThread()
        tThread = New Thread(AddressOf RunProcess)
        tThread.Name = "Network"
        tThread.Start()
    End Sub

    Private Sub RunProcess()
        While (1)
            Try
                SyncLock (UcFlowLoadingTLB1.tThrLock)
                    If tExit Then Exit While
                    GetActiveBay()
                    Application.DoEvents()
                End SyncLock
                Thread.Sleep(1000)
            Catch ex As Exception

            End Try
        End While
    End Sub
#End Region
End Class

