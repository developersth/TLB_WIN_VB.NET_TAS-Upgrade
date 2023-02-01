Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmConfigBaseProduct_main
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=add ,2=Edit

    Private Sub frmConfigBaseProduct_main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmConfigBaseProduct_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        'Initial_frm()
        Show_Data()
        InitialFind()
    End Sub

    Private Sub frmConfigBaseProduct_main_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
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

        gbSerach.Top = DataGridView1.Top - 80
        gbSerach.Left = Me.Width - gbSerach.Width
    End Sub

    Public Sub Show_Data()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "select B.BASE_PRODUCT_ID,B.BASE_PRODUCT_NAME,B.BASE_PRODUCT_CODE,"
        sql_str = sql_str & "B.COLOR_CODE ,B.QUOTA_QTY,B.IS_QUOTA, B.UPDATE_DATE, B.UPDATED_BY "
        sql_str = sql_str & "from BASE_PRODUCT B "
        sql_str = sql_str & "order by B.BASE_PRODUCT_ID"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView1.RowCount = 0
            Do While dt.Rows.Count > i

                DataGridView1.RowCount = DataGridView1.RowCount + 1
                DataGridView1.Rows.Item(i).Height = Grid_Height
                DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("BASE_PRODUCT_ID")), "", dt.Rows(i).Item("BASE_PRODUCT_ID").ToString)
                DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("BASE_PRODUCT_NAME")), "", dt.Rows(i).Item("BASE_PRODUCT_NAME").ToString)
                If IsDBNull(dt.Rows(i).Item("COLOR_CODE")) Then
                    DataGridView1.Item(2, i).Value = 0
                    DataGridView1.Item(2, i).Style.BackColor = Color.Black
                Else
                    Dim colour As String
                    colour = dt.Rows(i).Item("COLOR_CODE").ToString()
                    DataGridView1.Item(2, i).Value = appendZero(Hex(colour).ToString())
                    DataGridView1.Item(2, i).Style.BackColor = ColorTranslator.FromHtml("#" + appendZero(Hex(colour).ToString()))
                End If
                DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("QUOTA_QTY")), "", dt.Rows(i).Item("QUOTA_QTY").ToString)
                DataGridView1.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("IS_QUOTA")), "", dt.Rows(i).Item("IS_QUOTA").ToString)
                DataGridView1.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
                DataGridView1.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
                i = i + 1
            Loop
        Else
        End If
        dt = Nothing
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

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = True
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.RowIndex = -1 Then
            Return
        End If
        Dim txt_Card_ID As String
        txt_Card_ID = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub Delete()
        Dim sql_str As String
        'Dim mDataSet As New DataSet
        sql_str = " DELETE FROM BASE_PRODUCT "
        sql_str = sql_str & " WHERE BASE_PRODUCT_ID = '" + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + "' "
        If Oradb.ExeSQL(sql_str) Then
            MessageBox.Show("ได้ทำการลบข้อมูลเรียบร้อย", "System TAS")
            Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
    End Sub

    Private Sub bCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gbSerach.Visible = False
    End Sub

    Private Sub bSerach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ckFind.Checked Then
            If Find(txt_Serach.Text.Trim, 0) = False Then
                MessageBox.Show("ไม่พบข้อมูลของ   " & txt_Serach.Text & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            End If
        Else
            If Find(txt_Serach.Text.Trim, DataGridView1.CurrentRow.Index) = False Then
                MessageBox.Show("ไม่พบข้อมูลของ   " & txt_Serach.Text & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            End If
        End If

    End Sub

    Private Function Find(ByVal StrSearchString As String, ByVal intRow As Integer) As Boolean
        Dim intcount As Integer = 0

        For Each Row As DataGridViewRow In DataGridView1.Rows
            DataGridView1.Rows(intcount).Selected = False
            intcount += 1
        Next Row

        intcount = intRow
        For Each Row As DataGridViewRow In DataGridView1.Rows
            If DataGridView1.Rows(intcount).Cells(Combo1.SelectedIndex).Value.ToString = StrSearchString Then
                DataGridView1.Rows(intcount).Selected = True
                MessageBox.Show("row " & DataGridView1.CurrentRow.Index)
                Find = True
                Exit Function
            End If
            intcount += 1
        Next Row
        Find = False
    End Function

    Private Sub InitialFind()
        Combo1.Items.Clear()
        For Each column As DataGridViewColumn In DataGridView1.Columns
            Combo1.Items.Add(column.HeaderText)
        Next
    End Sub
#Region "Menu Event"

    Private Sub UcMenuRefresh_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuRefresh.OnClickMnuText
        Show_Data()
        gbSerach.Visible = False
    End Sub

    Private Sub UcMenuAdd_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuAdd.OnClickMnuText
        gbSerach.Visible = False
        frmConfigBaseProduct_sub.Close()
        frmConfigBaseProduct_sub.setFrmWork(1)
        frmConfigBaseProduct_sub.ShowDialog()
    End Sub

    Private Sub UcMenuEdit_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuEdit.OnClickMnuText
        gbSerach.Visible = False
        Dim id As String
        id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        frmConfigBaseProduct_sub.Close()
        frmConfigBaseProduct_sub.setFrmWork(2)
        frmConfigBaseProduct_sub.setPkId(id)
        frmConfigBaseProduct_sub.ShowDialog()
    End Sub

    Private Sub UcMenuDelete_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuDelete.OnClickMnuText
        gbSerach.Visible = False
        Dim result As Integer = MessageBox.Show("ต้องการลบข้อมูลผลิตภัณฑ์ : " + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + " ?", "System TAS", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            Delete()
        End If
    End Sub

    Private Sub UcMenuSacrch_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuSacrch.OnClickMnuText
        'frmFind.frm = Me
        'frmFind.grid = DataGridView1
        'frmFind.Show()
        'gbSerach.Visible = True
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