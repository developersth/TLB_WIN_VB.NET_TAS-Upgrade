Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmProofSendDataErp
    Public FormScreenID As Long
    Dim frm_work As Integer = 0  '1=add ,2=Edit
    Dim dateTimeStart As String
    Dim dateTimeEnd As String


    Private Sub frmProofSendDataErp_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmProofSendDataErp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oldMeH = Me.Size.Height
        Dim oleMeW = Me.Size.Width
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()

        Clear_frm()
        Initial_frm()
        Showdata_GridMain()
        resolution(Me, 1)
    End Sub

    Private Sub frmProofSendDataErp_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub

    Private Sub Initial_frm()
        dtpChoosDate.Value = Date.Today
        DTPTimeStart.Value = Convert.ToDateTime(DTPTimeStart.Value.Date.ToLongDateString & " " & "00:00:00")
        DTPTimeEnd.Value = Date.Today
        PickerTime_Stop.Value = Now
    End Sub

    Private Sub Clear_frm()
        txtTotHeader.Text = 0
    End Sub

    Public Sub Showdata_GridMain()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        Dim strDateStart = dtpChoosDate.Value.ToString.Split(" ")
        Dim dateStart = strDateStart(0)
        Dim strTime = DTPTimeStart.Value.ToString.Split(" ")
        Dim timeStart = strTime(1)
        dateTimeStart = dateStart & " " & timeStart

        Dim strDateEnd = DTPTimeEnd.Value.ToString.Split(" ")
        Dim dateEnd = strDateEnd(0)
        Dim strTimeEnd = PickerTime_Stop.Value.ToString.Split(" ")
        Dim timeEnd = strTimeEnd(1)
        dateTimeEnd = dateEnd & " " & timeEnd

        sql_str = _
            " select * from netsys.do_interface_head t " & _
            " WHERE t.delivery_date  Between  to_date('" & dateTimeStart & "','dd/mm/yyyy hh24:mi:ss') and to_date('" & dateTimeEnd & "','dd/mm/yyyy hh24:mi:ss') " & _
           " order by t.delivery_order"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0

            DataGridView_Headers.DataSource = dt
            txtTotHeader.Text = dt.Rows.Count
            For i = 0 To DataGridView_Headers.ColumnCount - 1
                Dim col As New DataGridViewColumn

                col = DataGridView_Headers.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub DataGridView_Headers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim strColume As String
        If DataGridView_Headers.Rows.Count <= 0 Or DataGridView_Headers.CurrentRow.Index < 0 Then Exit Sub
        With DataGridView_Headers
            strColume = .Item(0, .CurrentRow.Index).Value
            Call ShowtoMSGridLines(strColume)
        End With
    End Sub


    Private Sub ShowtoMSGridLines(ByRef Delivery_order As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        Dim strDateStart = dtpChoosDate.Value.ToString.Split(" ")
        Dim dateStart = strDateStart(0)
        Dim strTime = DTPTimeStart.Value.ToString.Split(" ")
        Dim timeStart = strTime(1)
        dateTimeStart = dateStart & " " & timeStart

        Dim strDateEnd = DTPTimeEnd.Value.ToString.Split(" ")
        Dim dateEnd = strDateEnd(0)
        Dim strTimeEnd = PickerTime_Stop.Value.ToString.Split(" ")
        Dim timeEnd = strTimeEnd(1)
        dateTimeEnd = dateEnd & " " & timeEnd

        sql_str = _
            " select * from netsys.do_interface_detail t " & _
            " WHERE t.delivery_order = " & Delivery_order & _
           " order by t.delivery_order"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0

            DataGridView_Line.DataSource = dt
            txtTotLine.Text = dt.Rows.Count
            For i = 0 To DataGridView_Line.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = DataGridView_Headers.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub b_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Showdata_GridMain()
    End Sub

    Private Sub UcMenuRefresh_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64)
        DataGridView_Line.Rows.Clear()
        Call Showdata_GridMain()
    End Sub

    Private Sub UcMenuRefresh_OnClickMnuText_1(ucName As System.String, ucScreenID As System.Int64)
        DataGridView_Line.Rows.Clear()
        Call Showdata_GridMain()
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