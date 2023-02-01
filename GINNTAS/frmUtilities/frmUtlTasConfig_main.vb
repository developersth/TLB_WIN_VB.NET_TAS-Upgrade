Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmUtlTasConfig_main
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=add ,2=Edit

    Private Sub frmUtlTasConfig_main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmUtlTasConfig_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub frmUtlTasConfig_main_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
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
        MSGridMain.Left = (Me.Width * 8) / 100
        MSGridMain.Width = Me.Width - (MSGridMain.Left * 3)
        MSGridMain.Top = 150
        MSGridMain.Height = (Me.Height / 2) + (MSGridMain.Height / 2)

        'UcInsert1.Left = (MSGridMain.Left * 1.5) + MSGridMain.Width
        'UcInsert1.Top = MSGridMain.Top
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
                " select  t.CONFIG_ID,t.DESCRIPTION,t.CONFIG_DATA," & _
                " t.VARIABLE_TYPE,t. UNIT_DESC,t.UPDATE_DATE,t.UPDATED_BY " & _
                " From TAS.TAS_CONFIG  t  where t.edit_status=1 Order by t.CONFIG_ID"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            MSGridMain.RowCount = 0
            txtTotalRecord.Text = dt.Rows.Count
            Do While dt.Rows.Count > i
                MSGridMain.RowCount = MSGridMain.RowCount + 1
                MSGridMain.Rows.Item(i).Height = Grid_Height

                MSGridMain.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CONFIG_ID")), "", dt.Rows(i).Item("CONFIG_ID").ToString)
                MSGridMain.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION").ToString)
                MSGridMain.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CONFIG_DATA")), "", dt.Rows(i).Item("CONFIG_DATA").ToString)
                MSGridMain.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("VARIABLE_TYPE")), "", dt.Rows(i).Item("VARIABLE_TYPE").ToString)
                If dt.Rows(i).Item("VARIABLE_TYPE").ToString = "BOOLEAN" Then
                    If dt.Rows(i).Item("CONFIG_DATA").ToString = "0" Then
                        MSGridMain.Item(3, i).Value = "False"
                        frmUtlTasConfig_sub.OptEnabled.Enabled = False
                    Else
                        MSGridMain.Item(3, i).Value = "True"
                        frmUtlTasConfig_sub.OptEnabled.Enabled = True
                    End If
                End If
                MSGridMain.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UNIT_DESC")), "", dt.Rows(i).Item("UNIT_DESC").ToString)
                MSGridMain.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
                MSGridMain.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
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

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MSGridMain.CellClick

    End Sub

    Private Sub Delete()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        sql_str = " DELETE FROM PRINTER_TAS    "
        sql_str = sql_str & " WHERE  PRINTER_ID = '" + MSGridMain.Item(0, MSGridMain.CurrentRow.Index).Value.ToString + "' "
        If Oradb.ExeSQL(sql_str) Then
            Call AddJournal(0, FormScreenID, 100, mUserName, 111203, Trim(MSGridMain.Item(0, MSGridMain.CurrentRow.Index).Value.ToString), Trim(MSGridMain.Item(1, MSGridMain.CurrentRow.Index).Value.ToString))

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
        frmUtlTasConfig_sub.setFrmWork(1)
        frmUtlTasConfig_sub.Show()
    End Sub

    Private Sub UcMenuEdit_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuEdit.OnClickMnuText
        Dim id As String
        Dim Value As String
        id = MSGridMain.Item(0, MSGridMain.CurrentRow.Index).Value
        Value = MSGridMain.Item(3, MSGridMain.CurrentRow.Index).Value
        frmUtlTasConfig_sub.setFrmWork(2)
        frmUtlTasConfig_sub.setPkId(id)
        frmUtlTasConfig_sub.setPkValue(Value)
        frmUtlTasConfig_sub.Show()
    End Sub

    Private Sub UcMenuDelete_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuDelete.OnClickMnuText
        Dim result As Integer = MessageBox.Show("ต้องการลบข้อมูลของเครื่องพิมพ์ : " + MSGridMain.Item(0, MSGridMain.CurrentRow.Index).Value.ToString + " หรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            Delete()
        End If
    End Sub

    Private Sub UcMenuSacrch_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuSacrch.OnClickMnuText
        frmFind.InitialFormFind(MSGridMain)
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
