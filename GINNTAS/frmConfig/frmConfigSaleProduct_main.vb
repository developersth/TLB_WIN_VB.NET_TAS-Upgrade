Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmConfigSaleProduct_main
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=add ,2=Edit

    Private Sub frmConfigSaleProduct_main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmConfigSaleProduct_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        'Initial_frm()
        Show_Data()
    End Sub

    Private Sub frmConfigSaleProduct_main_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
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
        "select S.SALE_PRODUCT_ID,S.SALE_PRODUCT_NAME,S.PRODUCT_MAP_OILSYS,S.SALE_PRODUCT_CODE,S.GROUP_NAME, " & _
        "S.DESCRIPTION,S.BASE_PRODUCT_ID,S.IS_METER_LOAD, S.UPDATE_DATE, S.UPDATED_BY, " & _
        "S.IS_WEIGHT_PROCESS ,S.IS_LOAD_PROCESS,S.IS_ENABLE,s.is_check_tare_wieght,s.unit " & _
        " from SALE_PRODUCT S " & _
        "order by S.SALE_PRODUCT_ID"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView1.RowCount = 0
            txtTotalRecord.Text = dt.Rows.Count
            Do While dt.Rows.Count > i
                DataGridView1.RowCount = DataGridView1.RowCount + 1
                DataGridView1.Rows.Item(i).Height = Grid_Height

                DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT_ID")), "", dt.Rows(i).Item("SALE_PRODUCT_ID").ToString)
                DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT_NAME")), "", dt.Rows(i).Item("SALE_PRODUCT_NAME").ToString)
                DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT_CODE")), "", dt.Rows(i).Item("SALE_PRODUCT_CODE").ToString)

                DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PRODUCT_MAP_OILSYS")), "", dt.Rows(i).Item("PRODUCT_MAP_OILSYS").ToString)
                DataGridView1.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION").ToString)
                DataGridView1.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLE")), "", IIf(dt.Rows(i).Item("IS_ENABLE").ToString = 1, "สามารถใช้งานได้", "หยุดการใช้งาน"))

                DataGridView1.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("IS_WEIGHT_PROCESS")), "", IIf(dt.Rows(i).Item("IS_WEIGHT_PROCESS").ToString = 1, "ต้องชั่งน้ำหนัก", "ไม่ต้องชั่งน้ำหนัก"))
                DataGridView1.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UNIT")), "", dt.Rows(i).Item("UNIT").ToString)
                DataGridView1.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("IS_LOAD_PROCESS")), "", IIf(dt.Rows(i).Item("IS_LOAD_PROCESS").ToString = 1, "มีกระบวนการจ่าย", "ไม่มีกระบวนการจ่าย"))

                DataGridView1.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("BASE_PRODUCT_ID")), "", dt.Rows(i).Item("BASE_PRODUCT_ID").ToString)
                DataGridView1.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("IS_METER_LOAD")), "", IIf(dt.Rows(i).Item("IS_METER_LOAD").ToString = 1, "มีมิเตอร์จ่าย", "ไม่มีมิเตอร์จ่าย"))
                DataGridView1.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("is_check_tare_wieght")), "", IIf(dt.Rows(i).Item("is_check_tare_wieght").ToString = 1, "ตรวจสอบ", "ไม่ตรวจสอบ"))

                DataGridView1.Item(12, i).Value = IIf(IsDBNull(dt.Rows(i).Item("GROUP_NAME")), "", dt.Rows(i).Item("GROUP_NAME").ToString)
                DataGridView1.Item(13, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", Format(dt.Rows(i).Item("UPDATE_DATE"), "dd/MM/yyyy HH:mm:ss"))
                DataGridView1.Item(14, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)

                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
        dt = Nothing
    End Sub

    Private Function appendZero(ByVal codeColour As String) As String
        Dim i As Integer = 6 - codeColour.Length
        While (i <> 0)
            codeColour = "0" + codeColour
            i = i - 1
        End While
        Return codeColour
    End Function

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Delete()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        sql_str = " DELETE FROM SALE_PRODUCT    "
        sql_str = sql_str & " WHERE  SALE_PRODUCT_ID = '" + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + "' "
        If Oradb.ExeSQL(sql_str) Then
            MessageBox.Show("ได้ทำการลบข้อมูลเรียบร้อย", "System TAS")
            Show_Data()
        Else
            MessageBox.Show("ไม่สามารถลบข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
    End Sub
#Region "Menu Event"

    Private Sub UcMenuRefresh_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuRefresh.OnClickMnuText
        Show_Data()
    End Sub

    Private Sub UcMenuAdd_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuAdd.OnClickMnuText
        frmConfigSaleProduct_sub.Close()
        frmConfigSaleProduct_sub.setFrmWork(1)
        frmConfigSaleProduct_sub.ShowDialog()
    End Sub

    Private Sub UcMenuEdit_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuEdit.OnClickMnuText
        Dim id As String
        id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        frmConfigSaleProduct_sub.Close()
        frmConfigSaleProduct_sub.setFrmWork(2)
        frmConfigSaleProduct_sub.setPkId(id)
        frmConfigSaleProduct_sub.ShowDialog()
    End Sub

    Private Sub UcMenuDelete_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuDelete.OnClickMnuText
        Dim result As Integer = MessageBox.Show("ต้องการลบข้อมูล : " + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + " หรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
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

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

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
    Private Sub UcBack1_Click(sender As Object, e As EventArgs) Handles UcBack1.Click, MyBase.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UcBack1_MouseHover(sender As Object, e As EventArgs) Handles UcBack1.MouseHover, MyBase.MouseHover
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("Back1")
    End Sub

    Private Sub UcBack1_MouseLeave(sender As Object, e As EventArgs) Handles UcBack1.MouseLeave, MyBase.MouseLeave
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("back")
    End Sub
End Class

