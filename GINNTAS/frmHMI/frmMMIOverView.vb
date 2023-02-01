
Imports Oracle.DataAccess.Client
Imports System.Data





Public Class frmMMIOverView
    Public FormScreenID As Long
    Dim frm_work As Integer = 0

    Dim txtLoadNo As New Collection
    Dim txtVechicleCardNo As New Collection
    Dim txtVechicle As New Collection
    Dim txtDriver As New Collection
    Dim UcProgressOverView As New Collection
    Dim UcMMIview As New Collection
    Dim UcMMIOverView As New Collection

    Dim sumAdvice = 0
    Dim sumCapacity = 0
    Const MAX_BAY = 4
    Const MAX_ISLAND = 2
    Dim checkIniPrgress(MAX_BAY - 1) As Boolean

    Private Sub frmMMIOverView_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    'Private Sub UcMinimize1_OnCilckMin() Handles UcMinimize1.OnCilckMin
    '    Me.WindowState = FormWindowState.Minimized
    'End Sub

    'Private Sub UcClose1_OnClickClose() Handles UcClose1.OnClickClose
    '    Me.Close()
    'End Sub

    Private Sub frmMMIOverView_main_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub


    Private Sub frmMMIOverView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim oldMeH = Me.Size.Height
        'Dim oleMeW = Me.Size.Width
        ' lblTitleName.Text = "โรงจ่ายนำมัน Over View"
        'SetScreenResulotion()
        'CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()

        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        ' Initial_frm()


        txtLoadNo.Add(txtLoadNo0)
        txtLoadNo.Add(txtLoadNo1)
        txtLoadNo.Add(txtLoadNo2)
        txtLoadNo.Add(txtLoadNo3)

        txtVechicleCardNo.Add(txtVechicleCardNo0)
        txtVechicleCardNo.Add(txtVechicleCardNo1)
        txtVechicleCardNo.Add(txtVechicleCardNo2)
        txtVechicleCardNo.Add(txtVechicleCardNo3)

        txtVechicle.Add(txtVechicle0)
        txtVechicle.Add(txtVechicle1)
        txtVechicle.Add(txtVechicle2)
        txtVechicle.Add(txtVechicle3)

        txtDriver.Add(txtDriver0)
        txtDriver.Add(txtDriver1)
        txtDriver.Add(txtDriver2)
        txtDriver.Add(txtDriver3)

        resolution(Me, 1)
        'resolution(Me, oldMeH, oleMeW)
        'UcMMIview1.Visible = False

        Dim i = 1, j = 1


        '----
        i = 1
        j = 1
        UcMMIOverView1.Visible = False
        Do While i <= MAX_ISLAND
            UcMMIOverView.Add(New UcMMIOverView())
            If i = 1 Then
                UcMMIOverView(i).location = New Point(UcMMIOverView1.Location.X, UcMMIOverView1.Location.Y)

            Else
                UcMMIOverView(i).location = New Point(UcMMIOverView(i - 1).Location.X + UcMMIOverView(i - 1).Size.Width + 10, UcMMIOverView1.Location.Y)
            End If
            UcMMIOverView(i).size = New Size(UcMMIOverView1.Size.Width, UcMMIOverView1.Size.Height)
            UcMMIOverView(i).createUcOverView(UcMMIOverView1.Size, i)
            Me.Controls.Add(UcMMIOverView(i))
            i += 1
        Loop
        '---
        'UcMMIOverView1.createUcOverView(UcMMIOverView1.Size)
        InitailMeter()
        InitCheckvalue()
        ClearText()
        CheckBayStatus()
        Timer1.Enabled = True
        Timer1.Interval = 3000


    End Sub


    Private Sub InitailMeter()
        Dim i, j As Long
        Dim strSQL As String
        Dim tempMeter = "- -"
        i = 1
        Do While i <= MAX_ISLAND
            strSQL = _
            "select  m.meter_no " & _
            " from tas.meter m " & _
            " Where m.island_no = " & (i) & " " & _
            " order by m.meter_no "

            j = 0
            '-------------
            Dim mDataSet As New DataSet
            Dim dt As DataTable
            If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                Do While dt.Rows.Count > j

                    tempMeter = IIf(IsDBNull(dt.Rows(j).Item("Meter_no")), "- -", dt.Rows(j).Item("Meter_no").ToString)
                    'MessageBox.Show(tempMeter)
                    'UcMMIview(i).InitailMeter(tempMeter)
                    UcMMIOverView(i).InitailMeter(tempMeter)

                    j = j + 1
                Loop
            End If
        mDataSet = Nothing
        '------------
        i += 1
        Loop

    End Sub

    Private Sub InitCheckvalue()
        Dim i As Long
        For i = 0 To MAX_BAY - 1
            checkIniPrgress(i) = True
        Next i
    End Sub

    Private Sub ClearText()
        Dim i As Integer
        For i = 1 To MAX_BAY
            txtLoadNo(i).Text = "- -"
            txtVechicleCardNo(i).Text = "- -"
            txtVechicle(i).Text = "- -"
            txtDriver(i).Text = "- -"
        Next i
    End Sub

    Private Sub ShowDetail(ByVal ILoadNo As String, ByVal Bay As Integer)
        Dim strSQL As String
        If ILoadNo = 0 Then Exit Sub

        strSQL = "  select   case when  t.tu_id1 is  null then   t.tu_id  else   t.tu_id ||'/'|| t.tu_id1  end as tu_idN ,t.* from tas.oil_load_headers  t "
        strSQL = strSQL & " where t.load_header_no ='" & ILoadNo & "' "

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then

                txtLoadNo(Bay).Text = IIf(IsDBNull(dt.Rows(0).Item("LOAD_HEADER_NO")), "- -", dt.Rows(0).Item("LOAD_HEADER_NO").ToString)
                txtVechicleCardNo(Bay).Text = IIf(IsDBNull(dt.Rows(0).Item("tu_card_no")), "- -", dt.Rows(0).Item("tu_card_no").ToString)
                txtVechicle(Bay).Text = IIf(IsDBNull(dt.Rows(0).Item("tu_idN")), "- -", dt.Rows(0).Item("tu_idN").ToString)
                txtDriver(Bay).Text = IIf(IsDBNull(dt.Rows(0).Item("driver_name")), "- -", dt.Rows(0).Item("driver_name").ToString)
            End If
        End If
        mDataSet = Nothing
        '------------
    End Sub

    Public Sub CheckBayStatus()
        Dim i As Integer
        For i = 0 To MAX_BAY - 1
            GetBayActiveOrNot(i + 1)
        Next i
    End Sub

    Private Sub GetBayActiveOrNot(ByVal iBay As Integer)
        Dim strSQL As String

        strSQL = "select   b.bay_no,b.last_load_no ,b.bay_active "
        strSQL = strSQL & " from tas.bay   b "
        strSQL = strSQL & "where  b.bay_no = " & iBay & " "
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then


                Dim bay_active = CType(IIf(IsDBNull(dt.Rows(0).Item("bay_active")), "0", dt.Rows(0).Item("bay_active").ToString), Integer)
                If bay_active = 1 Then
                    Call ShowDetail(CType(IIf(IsDBNull(dt.Rows(0).Item("Last_load_no")), "0", dt.Rows(0).Item("Last_load_no").ToString), Integer), iBay)
                    Call ShowProgress(IIf(IsDBNull(dt.Rows(0).Item("Last_load_no")), "0", dt.Rows(0).Item("Last_load_no").ToString), iBay, True)
                Else
                    ClearTextNoLoad(iBay)
                    Call ShowProgress(IIf(IsDBNull(dt.Rows(0).Item("Last_load_no")), "0", dt.Rows(0).Item("Last_load_no").ToString), iBay, False)
                    checkIniPrgress(iBay - 1) = True
                End If
                ShowTube(CType(IIf(IsDBNull(dt.Rows(0).Item("Last_load_no")), "0", dt.Rows(0).Item("Last_load_no").ToString), Integer), iBay)
                'UcMMIOverView(1).ShowTube(21, 1, True)
            End If
        End If
        mDataSet = Nothing
    End Sub


    Private Sub ShowTube(iLoad_no As String, iBay As Integer)
        Dim rack = 1
        Dim strSQL As String
        If iBay = 3 Or iBay = 4 Then
            rack = 2
        End If
        strSQL = " select  ol.batch_status ,ol.meter_no "
        strSQL = strSQL & " from  tas.oil_load_lines  ol "
        strSQL = strSQL & " where ol.load_header_no ='" & iLoad_no & "'"
        strSQL = strSQL & " Group by  ol.meter_no ,ol.Batch_status "
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i = 0
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                If CType(IIf(IsDBNull(dt.Rows(0).Item("batch_status")), "0", dt.Rows(0).Item("batch_status").ToString), Integer) = 3 Or CType(IIf(IsDBNull(dt.Rows(0).Item("batch_status")), "0", dt.Rows(0).Item("batch_status").ToString), Integer) = 4 Then
                    UcMMIOverView(rack).ShowTube(CType(IIf(IsDBNull(dt.Rows(0).Item("meter_no")), "0", dt.Rows(0).Item("meter_no").ToString), Integer), iBay, True)
                Else
                    'MessageBox.Show(IIf(IsDBNull(dt.Rows(0).Item("meter_no")), "0", dt.Rows(0).Item("meter_no").ToString))
                    UcMMIOverView(rack).ShowTube(CType(IIf(IsDBNull(dt.Rows(0).Item("meter_no")), "0", dt.Rows(0).Item("meter_no").ToString), Integer), iBay, False)
                End If

            End If
        End If
        mDataSet = Nothing
    End Sub


    Private Sub ClearTextNoLoad(ByVal iBay As Integer)
        txtLoadNo(iBay).Text = "- -"
        txtVechicleCardNo(iBay).Text = "- -"
        txtVechicle(iBay).Text = "- - "
        txtDriver(iBay).Text = "- -"
    End Sub


    Private Sub ShowProgress(ByVal iLoad_no As String, ByVal iBay As Integer, ByVal sEna As Boolean)
        Dim vSide As Integer
        If iBay Mod 2 = 0 Then
            vSide = iBay Mod 2
            vSide = vSide + 1
        Else
            vSide = iBay Mod 2
            vSide = vSide - 1
        End If
        If iLoad_no = 0 Then Exit Sub
        If iBay < 3 Then
            If sEna Then
                If checkIniPrgress(iBay - 1) Then
                    Call InitailProgress(iLoad_no, 0, vSide, sEna)
                    checkIniPrgress(iBay - 1) = False
                End If
                Call RunProgress(iLoad_no, 0, vSide)
            Else
                Call ClearProgress(0, vSide, sEna)
            End If
        Else
            If sEna Then
                If checkIniPrgress(iBay - 1) Then
                    Call InitailProgress(iLoad_no, 1, vSide, sEna)
                    checkIniPrgress(iBay - 1) = False
                End If
                Call RunProgress(iLoad_no, 1, vSide)
            Else
                Call ClearProgress(1, vSide, sEna)
            End If
        End If

    End Sub


    Private Sub RunProgress(ByVal iLoad_no As String, ByVal iSland As Integer, ByVal iBay As Integer)
        Dim strSQL As String
        strSQL = " select   sum(t.loaded_gross) as   Sumloaded_gross "
        strSQL = strSQL & " from oil_load_lines t  where t.load_header_no ='" & iLoad_no & "' "

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                'UcMMIview(iSland + 1).updateProgrss(iBay + 1, sumCapacity, sumAdvice, CType(IIf(IsDBNull(dt.Rows(0).Item("Sumloaded_gross")), "0", dt.Rows(0).Item("Sumloaded_gross").ToString), Integer))
                UcMMIOverView(iSland + 1).updateProgrss(iBay + 1, sumCapacity, sumAdvice, CType(IIf(IsDBNull(dt.Rows(0).Item("Sumloaded_gross")), "0", dt.Rows(0).Item("Sumloaded_gross").ToString), Integer))
            End If
        End If
        mDataSet = Nothing
    End Sub



    Private Sub InitailProgress(ByVal iLoad_no As String, ByVal iIsland As Integer, ByVal iSide As Integer, ByVal sEna As Boolean)

        Dim strSQL As String
        strSQL = "select  sum(t.compament_capacity) as sumCapacity , sum(t.advice) as sumAdvice , sum(t.preset) as sumPreset "
        strSQL = strSQL & " from oil_load_lines t  where t.load_header_no ='" & iLoad_no & "'"
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                sumAdvice = IIf(IsDBNull(dt.Rows(0).Item("sumAdvice")), "0", dt.Rows(0).Item("sumAdvice").ToString)
                sumCapacity = IIf(IsDBNull(dt.Rows(0).Item("sumCapacity")), "- -", dt.Rows(0).Item("sumCapacity").ToString)
            End If
        End If
        mDataSet = Nothing

    End Sub

    Private Sub ClearProgress(ByVal iSland As Integer, ByVal iSide As Integer, ByVal sEna As Boolean)
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        InitCheckvalue()
        ClearText()
        CheckBayStatus()
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
