
Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmUnInMeter

    Public FormScreenID As Long
    Dim frm_work As Integer = 0

    Private Sub frmUnInMeter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        resolution(Me, 1)
        Show_Data()

    End Sub
    Private Sub frmUnInMeter_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub
    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub
    Public Sub Show_Data()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        sql_str = _
                "select  t.meter_no ,  t.status,t.base_product_id,t.close_type  ,t.open_date , t.close_date ,t.open_gross_tot , t.close_gross_tot , t.open_gst_tot , t.close_gst_tot ,t.open_gsv_tot , t.close_gsv_tot  ,t.DESCRPITION   " & _
                "from hsl.inv_meter t " & _
                " where to_date(t.eod_date,'dd/mm/yyyy') =to_date('" & Format(dtpDateShow.Value, "dd/MM/yyyy") & "','dd/mm/yyyy')" & _
                " and  t.close_type =2  order by t.meter_no "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView1.RowCount = 0
            txtTotalRecord.Text = dt.Rows.Count
            Do While dt.Rows.Count > i
                DataGridView1.RowCount = DataGridView1.RowCount + 1
                DataGridView1.Rows.Item(i).Height = Grid_Height
                DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Meter_no")), "", dt.Rows(i).Item("Meter_no").ToString)
                DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("base_product_id")), "", dt.Rows(i).Item("base_product_id").ToString)
                DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Status")), "", dt.Rows(i).Item("Status").ToString)
                DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("close_type")), "", dt.Rows(i).Item("close_type").ToString)
                DataGridView1.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("open_date")), "", dt.Rows(i).Item("open_date").ToString)
                DataGridView1.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("open_gross_tot")), "", dt.Rows(i).Item("open_gross_tot").ToString)
                DataGridView1.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("open_gst_tot")), "", dt.Rows(i).Item("open_gst_tot").ToString)
                DataGridView1.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("open_gsv_tot")), "", dt.Rows(i).Item("open_gsv_tot").ToString)
                DataGridView1.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("close_date")), "", dt.Rows(i).Item("close_date").ToString)
                DataGridView1.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("close_gross_tot")), "", dt.Rows(i).Item("close_gross_tot").ToString)
                DataGridView1.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("close_gst_tot")), "", dt.Rows(i).Item("close_gst_tot").ToString)
                DataGridView1.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("close_gsv_tot")), "", dt.Rows(i).Item("close_gsv_tot").ToString)
                DataGridView1.Item(12, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DESCRPITION")), "", dt.Rows(i).Item("DESCRPITION").ToString)

                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing

    End Sub

    Private Sub dtpDateShow_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpDateShow.ValueChanged
        Show_Data()
    End Sub

    Private Sub UcMenuRefresh_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuRefresh.OnClickMnuText
        Show_Data()
    End Sub
    Private Sub UcHeader1_CloseButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.CloseButtonClick
        Me.Close()
    End Sub

    Private Sub UcHeader1_MinimizeButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.MinimizeButtonClick
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub UcBack1_Click(sender As Object, e As EventArgs) Handles UcBack1.Click
        Me.Close()
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