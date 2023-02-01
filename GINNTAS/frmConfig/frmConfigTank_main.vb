Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmConfigTank_main
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=add ,2=Edit

    Private Sub frmConfigTank_main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmConfigTank_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub frmConfigTank_main_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
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
        Dim i, j, k As Integer


        sql_str = _
        "select T.TANK_ID,T.TANK_NAME,T.BASE_PRODUCT,S.DESCRIPTION,T.MAPPING_ID," & _
        "T.TANK_HIGH,T.TANK_CAPACITY,T.LEVEL_LL,T.LEVEL_L,T.LEVEL_H,T.LEVEL_HH," & _
        "T.IS_ENABLED,T.UPDATE_DATE,T.UPDATED_BY,T.Bypass_Esd_HH,T.Bypass_Esd_LL " & _
        "from VIEW_MAP_TANK T,STATUS_DESC S " & _
        "where T.TANK_TYPE=S.STATUS_VARCHAR(+) " & _
        "and ((S.T_NAME='TANK' and S.COLUMNS_NAME='TANK_TYPE') or S.T_NAME is null) " & _
        "order by T.BASE_PRODUCT,T.TANK_NAME"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            j = 0
            k = 0
            DataGridView1.RowCount = 0
            txtTotalRecord.Text = dt.Rows.Count
            Do While dt.Rows.Count > i

                DataGridView1.RowCount = DataGridView1.RowCount + 1
                DataGridView1.Rows.Item(i).Height = Grid_Height
                DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TANK_ID")), "", dt.Rows(i).Item("TANK_ID").ToString)
                DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TANK_NAME")), "", dt.Rows(i).Item("TANK_NAME").ToString)
                DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("BASE_PRODUCT")), "", dt.Rows(i).Item("BASE_PRODUCT").ToString)
                DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION").ToString)
                DataGridView1.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("MAPPING_ID")), "", dt.Rows(i).Item("MAPPING_ID").ToString)
                DataGridView1.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TANK_HIGH")), "", dt.Rows(i).Item("TANK_HIGH").ToString)
                DataGridView1.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TANK_CAPACITY")), "", dt.Rows(i).Item("TANK_CAPACITY").ToString)
                DataGridView1.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LEVEL_LL")), "", dt.Rows(i).Item("LEVEL_LL").ToString)
                DataGridView1.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LEVEL_L")), "", dt.Rows(i).Item("LEVEL_L").ToString)
                DataGridView1.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LEVEL_H")), "", dt.Rows(i).Item("LEVEL_H").ToString)
                DataGridView1.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LEVEL_HH")), "", dt.Rows(i).Item("LEVEL_HH").ToString)
                DataGridView1.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", IIf(dt.Rows(i).Item("IS_ENABLED").ToString = 1, "สามารถใช้งานได้", "หยุดการใช้งาน"))
                DataGridView1.Item(12, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", Format(dt.Rows(i).Item("UPDATE_DATE"), "dd/MM/yyyy HH:mm:ss"))
                DataGridView1.Item(13, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
                Dim z As Integer
                If IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION").ToString) = "ถังรับ" Then
                    j = j + 1
                    'lbl_DO_No_Use.Text = j

                    For z = 0 To DataGridView1.Columns.Count - 1
                        DataGridView1.Rows(i).Cells(z).Style.ForeColor = Color.Black
                    Next
                Else
                    k = k + 1
                    'lbl_DO_Use.Text = k

                    For z = 0 To DataGridView1.Columns.Count - 1
                        DataGridView1.Rows(i).Cells(z).Style.ForeColor = Color.Red
                    Next
                End If
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

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

    End Sub
    Private Sub Delete()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        sql_str = " DELETE FROM TANK    "
        sql_str = sql_str & " WHERE  TANK_ID = '" + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + "' "
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
        frmConfigTank_sub.Close()
        frmConfigTank_sub.setFrmWork(1)
        frmConfigTank_sub.ShowDialog()
    End Sub

    Private Sub UcMenuEdit_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuEdit.OnClickMnuText
        Dim id As String
        id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        frmConfigTank_sub.Close()
        frmConfigTank_sub.setFrmWork(2)
        frmConfigTank_sub.setPkId(id)
        frmConfigTank_sub.ShowDialog()
    End Sub

    Private Sub UcMenuDelete_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuDelete.OnClickMnuText
        Dim result As Integer = MessageBox.Show("ต้องการลบข้อมูลของหมายเลขถัง : " + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + " หรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            Delete()
        End If
    End Sub

    Private Sub UcMenuSacrch_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuSacrch.OnClickMnuText
        frmFind.Close()
        frmFind.InitialFormFind(DataGridView1)
        frmFind.ShowDialog()
    End Sub
#End Region
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

