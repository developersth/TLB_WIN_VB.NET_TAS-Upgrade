
Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmUnInvTank

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
                "select   t.tank_id  , t.tank_name ,t.base_product_id ,t.status  ,t.close_type ,t.descrpition ," & _
                " t.open_date , t.close_date, t.o_tank_type, t.o_is_enabled, t.o_temp, t.o_api60f, t.o_levels, t.o_gross, t.o_net, t.o_avariable, t.o_room, t.o_density " & _
                " ,t.c_tank_type, t.c_is_enabled, t.c_temp , t.c_api60f ,t.c_levels , t.c_gross , t.c_net , t.c_avariable , t.c_room ,t.c_density ,t.descrpition" & _
                " from hsl.inv_tank t   " & _
                "where  to_date( t.eod_date,'DD/MM/YYYY') = to_date('" & Format(dtpDateShow.Value, "dd/MM/yyyy") & "','dd/mm/yyyy') " & _
                " order by tank_id ,tank_name,t.base_product_id "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView1.RowCount = 0
            txtTotalRecord.Text = dt.Rows.Count
            Do While dt.Rows.Count > i
                DataGridView1.RowCount = DataGridView1.RowCount + 1
                DataGridView1.Rows.Item(i).Height = Grid_Height
                DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("tank_id")), "", dt.Rows(i).Item("tank_id").ToString)
                DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("tank_name")), "", dt.Rows(i).Item("tank_name").ToString)
                DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("base_product_id")), "", dt.Rows(i).Item("base_product_id").ToString)
                DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("status")), "", dt.Rows(i).Item("status").ToString)
                DataGridView1.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("close_type")), "", dt.Rows(i).Item("close_type").ToString)
                DataGridView1.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("open_date")), "", dt.Rows(i).Item("open_date").ToString)
                DataGridView1.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("o_tank_type")), "", dt.Rows(i).Item("o_tank_type").ToString)
                DataGridView1.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("o_is_enabled")), "", dt.Rows(i).Item("o_is_enabled").ToString)
                DataGridView1.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("o_temp")), "", dt.Rows(i).Item("o_temp").ToString)
                DataGridView1.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("o_levels")), "", dt.Rows(i).Item("o_levels").ToString)
                DataGridView1.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("o_gross")), "", dt.Rows(i).Item("o_gross").ToString)
                DataGridView1.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("o_net")), "", dt.Rows(i).Item("o_net").ToString)
                DataGridView1.Item(12, i).Value = IIf(IsDBNull(dt.Rows(i).Item("o_avariable")), "", dt.Rows(i).Item("o_avariable").ToString)
                DataGridView1.Item(13, i).Value = IIf(IsDBNull(dt.Rows(i).Item("o_room")), "", dt.Rows(i).Item("o_room").ToString)
                DataGridView1.Item(14, i).Value = IIf(IsDBNull(dt.Rows(i).Item("o_api60f")), "", dt.Rows(i).Item("o_api60f").ToString)
                DataGridView1.Item(15, i).Value = IIf(IsDBNull(dt.Rows(i).Item("o_density")), "", dt.Rows(i).Item("o_density").ToString)
                DataGridView1.Item(16, i).Value = IIf(IsDBNull(dt.Rows(i).Item("close_date")), "", dt.Rows(i).Item("close_date").ToString)
                DataGridView1.Item(17, i).Value = IIf(IsDBNull(dt.Rows(i).Item("c_tank_type")), "", dt.Rows(i).Item("c_tank_type").ToString)
                DataGridView1.Item(18, i).Value = IIf(IsDBNull(dt.Rows(i).Item("c_is_enabled")), "", dt.Rows(i).Item("c_is_enabled").ToString)
                DataGridView1.Item(19, i).Value = IIf(IsDBNull(dt.Rows(i).Item("c_temp")), "", dt.Rows(i).Item("c_temp").ToString)
                DataGridView1.Item(20, i).Value = IIf(IsDBNull(dt.Rows(i).Item("c_levels")), "", dt.Rows(i).Item("c_levels").ToString)
                DataGridView1.Item(21, i).Value = IIf(IsDBNull(dt.Rows(i).Item("c_gross")), "", dt.Rows(i).Item("c_gross").ToString)
                DataGridView1.Item(22, i).Value = IIf(IsDBNull(dt.Rows(i).Item("c_net")), "", dt.Rows(i).Item("c_net").ToString)
                DataGridView1.Item(23, i).Value = IIf(IsDBNull(dt.Rows(i).Item("c_avariable")), "", dt.Rows(i).Item("c_avariable").ToString)
                DataGridView1.Item(24, i).Value = IIf(IsDBNull(dt.Rows(i).Item("c_room")), "", dt.Rows(i).Item("c_room").ToString)
                DataGridView1.Item(25, i).Value = IIf(IsDBNull(dt.Rows(i).Item("c_api60f")), "", dt.Rows(i).Item("c_api60f").ToString)
                DataGridView1.Item(26, i).Value = IIf(IsDBNull(dt.Rows(i).Item("c_density")), "", dt.Rows(i).Item("c_density").ToString)
                DataGridView1.Item(27, i).Value = IIf(IsDBNull(dt.Rows(i).Item("descrpition")), "", dt.Rows(i).Item("descrpition").ToString)
                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing

    End Sub

    Private Sub dtpDateShow_ValueChanged(sender As System.Object, e As System.EventArgs)
        Show_Data()
    End Sub

    Private Sub UcMenuRefresh_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64)
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