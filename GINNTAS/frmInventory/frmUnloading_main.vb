Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmUnloading_main
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=add ,2=Edit

    Private Sub frmUnloading_main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmUnloading_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialFormType1(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        'Initial_frm()
        Show_Data()
    End Sub

    Private Sub frmUnloading_main_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub

    Private Sub Initial_frm()
        frm_work = 0
        DataGridView1.Left = (Me.Width * 8) / 100
        DataGridView1.Width = Me.Width - (DataGridView1.Left * 3)
        DataGridView1.Top = 150
        DataGridView1.Height = (Me.Height / 2) + (DataGridView1.Height / 2)

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
    End Sub


    Public Sub Show_Data()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        sql_str = _
          "select U.RECEIPT_NO,U.UNLOAD_TYPE,S.DESCRIPTION,U.TRANSPORT_UNIT,U.PRODUCT_ID,U.FROM_PLANT," & _
            "U.TEMP_SCHEDULE,U.API_SCHEDULE,U.GROSS_SCHEDULE_QTY,U.NET_SCHEDULE_QTY," & _
            "U.TEMP_TOPLANT,U.API_TOPLANT,U.GROSS_TOPLANT_QTY,U.NET_TOPLANT_QTY," & _
            "U.GROSS_UNLOAD_QTY,U.NET_UNLOAD_QTY,U.TANK_UNLOAD," & _
            "U.TIME_START_UNLOAD,U.TIME_STOP_UNLOAD,U.REFERENCE," & _
            "U.IS_EOD,U.EOD_DATE,U.UPDATE_DATE , U.UPDATED_BY " & _
        "from OIL_UNLOAD U,STATUS_DESC S " & _
        "where trunc(U.EOD_DATE,'dd')=to_date('" & Format(dtpDateShow.value, "dd/MM/yyyy") & "','dd/mm/yyyy') " & _
            "and U.UNLOAD_TYPE=S.STATUS_NUMBER " & _
            "and ((S.T_NAME='OIL_UNLOAD' and S.COLUMNS_NAME='UNLOAD_TYPE') or S.T_NAME is null) " & _
        "order by U.RECEIPT_NO"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView1.RowCount = 0
            txtTotalRecord.Text = dt.Rows.Count
            Do While dt.Rows.Count > i
                DataGridView1.RowCount = DataGridView1.RowCount + 1
                DataGridView1.Rows.Item(i).Height = Grid_Height
                DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("RECEIPT_NO")), "", dt.Rows(i).Item("RECEIPT_NO").ToString)
                DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION").ToString)
                DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TRANSPORT_UNIT")), "", dt.Rows(i).Item("TRANSPORT_UNIT").ToString)
                DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PRODUCT_ID")), "", dt.Rows(i).Item("PRODUCT_ID").ToString)
                DataGridView1.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("FROM_PLANT")), "", dt.Rows(i).Item("FROM_PLANT").ToString)
                DataGridView1.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TEMP_SCHEDULE")), "", dt.Rows(i).Item("TEMP_SCHEDULE").ToString)
                DataGridView1.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("API_SCHEDULE")), "", dt.Rows(i).Item("API_SCHEDULE").ToString)
                DataGridView1.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("GROSS_SCHEDULE_QTY")), "", dt.Rows(i).Item("GROSS_SCHEDULE_QTY").ToString)
                DataGridView1.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("NET_SCHEDULE_QTY")), "", dt.Rows(i).Item("NET_SCHEDULE_QTY").ToString)
                DataGridView1.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TEMP_TOPLANT")), "", dt.Rows(i).Item("TEMP_TOPLANT").ToString)
                DataGridView1.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("API_TOPLANT")), "", dt.Rows(i).Item("API_TOPLANT").ToString)
                DataGridView1.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("GROSS_TOPLANT_QTY")), "", dt.Rows(i).Item("GROSS_TOPLANT_QTY").ToString)
                DataGridView1.Item(12, i).Value = IIf(IsDBNull(dt.Rows(i).Item("NET_TOPLANT_QTY")), "", dt.Rows(i).Item("NET_TOPLANT_QTY").ToString)
                DataGridView1.Item(13, i).Value = IIf(IsDBNull(dt.Rows(i).Item("GROSS_UNLOAD_QTY")), "", dt.Rows(i).Item("GROSS_UNLOAD_QTY").ToString)
                DataGridView1.Item(14, i).Value = IIf(IsDBNull(dt.Rows(i).Item("NET_UNLOAD_QTY")), "", dt.Rows(i).Item("NET_UNLOAD_QTY").ToString)
                DataGridView1.Item(15, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TANK_UNLOAD")), "", dt.Rows(i).Item("TANK_UNLOAD").ToString)
                DataGridView1.Item(16, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TIME_START_UNLOAD")), "", dt.Rows(i).Item("TIME_START_UNLOAD").ToString)
                DataGridView1.Item(17, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TIME_STOP_UNLOAD")), "", dt.Rows(i).Item("TIME_STOP_UNLOAD").ToString)
                DataGridView1.Item(18, i).Value = IIf(IsDBNull(dt.Rows(i).Item("REFERENCE")), "", dt.Rows(i).Item("REFERENCE").ToString)
                DataGridView1.Item(19, i).Value = IIf(IsDBNull(dt.Rows(i).Item("IS_EOD")), "", IIf(dt.Rows(i).Item("IS_EOD").ToString = "1", " ใช่", " ไม่ใช่"))
                DataGridView1.Item(20, i).Value = IIf(IsDBNull(dt.Rows(i).Item("EOD_DATE")), "", dt.Rows(i).Item("EOD_DATE").ToString)
                DataGridView1.Item(21, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
                DataGridView1.Item(22, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing

    End Sub

    Private Function appendZero(ByVal codeColour As String) As String
        Dim i As Integer = 6 - codeColour.Length
        While (i <> 0)
            codeColour = "0" + codeColour
            i = i - 1
        End While
        Return codeColour
    End Function

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex = -1 Then
            Return
        End If
        Dim txt_Card_ID As String
        txt_Card_ID = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
    End Sub
    Private Sub Delete()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        sql_str = " delete OIL_UNLOAD U  "
        sql_str = sql_str & " where U.RECEIPT_NO = '" + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + "' "
        If Oradb.ExeSQL(sql_str) Then
            MessageBox.Show("ได้ทำการลบข้อมูลเรียบร้อย", "System TAS")
            Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
    End Sub

#Region "Menu Event"

    Private Sub UcMenuRefresh_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuRefresh.OnClickMnuText
        Show_Data()
    End Sub

    Private Sub UcMenuAdd_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuAdd.OnClickMnuText
        frmfrmUnloading_sub.Close()
        frmfrmUnloading_sub.setFrmWork(1)
        frmfrmUnloading_sub.Show()
    End Sub

    Private Sub UcMenuEdit_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuEdit.OnClickMnuText
        Dim id As String
        id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        'MessageBox.Show(id)
        frmfrmUnloading_sub.Close()
        frmfrmUnloading_sub.setFrmWork(2)
        frmfrmUnloading_sub.setPkId(id)
        frmfrmUnloading_sub.Show()
    End Sub

    Private Sub UcMenuDelete_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuDelete.OnClickMnuText
        Dim result As Integer = MessageBox.Show("ต้องการลบหมายเลขตั๋ว : " + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + " ?", "System TAS", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            Delete()
        End If
    End Sub

    Private Sub UcMenuSacrch_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuSacrch.OnClickMnuText
        frmFind.InitialFormFind(DataGridView1)
        frmFind.ShowDialog()
    End Sub
#End Region

    Private Sub dtpDateShow_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpDateShow.ValueChanged
        Show_Data()
    End Sub

    Private Sub UcHeader1_Load(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub TableLayoutPanel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub
    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub
    Private Sub UcMenuSacrch_Load(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub UcFooter1_Load(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub Panel3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub UcMenuAdd_Load(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub label1_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub txtTotalRecord_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub pnlFooter_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub
    Private Sub Panel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub
    Private Sub UcMenuDelete_Load(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub UcMenuEdit_Load(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub UcMenuRefresh_Load(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub Panel4_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

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