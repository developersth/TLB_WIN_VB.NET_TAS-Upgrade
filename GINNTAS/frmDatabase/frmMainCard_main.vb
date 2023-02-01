Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmMainCard_main
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=add ,2=Edit

    Private Sub frmMainCard_main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'UcStatus1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmMainCard_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub frmMainCard_main_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
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
        DataGridView1.Top = 210
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

        sql_str = "SELECT C.CARD_CODE as ""รหัสบัตร"",T.TU_ID as ""ทะเบียนรถ"",v.TYPE_NAME as ""ประเภทบัตรรถ"" " & _
                ",case C.IS_ENABLED when 0 then 'หยุดการใช้งาน' else 'สามารถใช้งานได้' end as ""สถานะใช้งาน"",C.EXPIRE_DATE as ""EXPIRE DATE"",case C.IS_EXPIRE when 0 then ' ' else 'Used' end as ""STATUS USED"",C.UPDATE_DATE as ""วันที่แก้ไขล่าสุด"",C.UPDATED_BY as ""แก้ไขโดย"" "
        sql_str = sql_str & " FROM CARD C,TRANSPORT_UNIT T , TAS.V_CARD_TYPE  V  "
        sql_str = sql_str & " WHERE C.TU_NUMBER =T.TU_NUMBER(+)  "
        sql_str = sql_str & " AND C.CARD_TYPE = V.TYPE_ID"
        sql_str = sql_str & " ORDER BY C.CARD_NO"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            'DataGridView1.RowCount = 0
            'Do While dt.Rows.Count > i
            '    DataGridView1.RowCount = DataGridView1.RowCount + 1
            '    DataGridView1.Rows.Item(i).Height = Grid_Height
            '    DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CARD_NO")), "", dt.Rows(i).Item("CARD_NO").ToString)
            '    DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CARD_CODE")), "", dt.Rows(i).Item("CARD_CODE").ToString)
            '    DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TU_NUMBER")), "", dt.Rows(i).Item("TU_NUMBER").ToString)
            '    DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TYPE_NAME")), "", dt.Rows(i).Item("TYPE_NAME").ToString)
            '    DataGridView1.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", IIf(dt.Rows(i).Item("IS_ENABLED").ToString = 1, "สามารถใช้งานได้", "หยุดการใช้งาน"))
            '    DataGridView1.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("EXPIRE_DATE")), "", Format(dt.Rows(i).Item("EXPIRE_DATE"), "dd/MM/yyyy HH:mm:ss"))
            '    DataGridView1.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("IS_EXPIRE")), "", IIf(dt.Rows(i).Item("IS_EXPIRE").ToString = 1, "Used", ""))
            '    DataGridView1.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", Format(dt.Rows(i).Item("UPDATE_DATE"), "dd/MM/yyyy HH:mm:ss"))
            '    DataGridView1.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
            '    i = i + 1
            'Loop
            DataGridView1.DataSource = dt
            txtTotalRecord.Text = dt.Rows.Count
            For i = 0 To DataGridView1.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = DataGridView1.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
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

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Delete()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        sql_str = " DELETE FROM CARD C   "
        sql_str = sql_str & " WHERE  C.CARD_NO = '" + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + "' "
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
        frmMainCard_sub.Close()
        frmMainCard_sub.setFrmWork(1)
        frmMainCard_sub.ShowDialog()
    End Sub

    Private Sub UcMenuEdit_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuEdit.OnClickMnuText
        Dim id As String
        id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        frmMainCard_sub.Close()
        frmMainCard_sub.setFrmWork(2)
        frmMainCard_sub.setPkId(id)
        frmMainCard_sub.ShowDialog()
    End Sub

    Private Sub UcMenuDelete_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuDelete.OnClickMnuText
        Dim result As Integer = MessageBox.Show("ต้องการลบข้อมูลของปั๊ม : " + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + " หรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            Delete()
        End If
    End Sub

    Private Sub UcMenuSacrch_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuSacrch.OnClickMnuText
        frmFind.Close()
        frmFind.InitialFormFind(DataGridView1, 1)
        frmFind.ShowDialog()
    End Sub
#End Region
   

    Private Sub UcHeader1_MinimizeButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.MinimizeButtonClick
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcHeader1_CloseButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.CloseButtonClick
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

   
    Private Sub UcBack1_MouseClick(sender As Object, e As MouseEventArgs)
        Try
            Me.Close()
        Catch ex As Exception

        End Try
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

    Private Sub cbCard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCard.SelectedIndexChanged
        If cbCard.Text <> "" Then
            If Show_Data_Search() Then
                Dim id As String
                id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                frmMainCard_sub.Close()
                frmMainCard_sub.setFrmWork(2)
                frmMainCard_sub.setPkId(id)
                frmMainCard_sub.ShowDialog()
            End If
        End If
    End Sub
    Function Show_Data_Search() As Boolean
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Show_Data_Search = False

        sql_str = "SELECT C.CARD_CODE as ""รหัสบัตร"",T.TU_ID as ""ทะเบียนรถ"",v.TYPE_NAME as ""ประเภทบัตรรถ"" " & _
          ",case C.IS_ENABLED when 0 then 'หยุดการใช้งาน' else 'สามารถใช้งานได้' end as ""สถานะใช้งาน"",C.EXPIRE_DATE as ""EXPIRE DATE"",case C.IS_EXPIRE when 0 then ' ' else 'Used' end as ""STATUS USED"",C.UPDATE_DATE as ""วันที่แก้ไขล่าสุด"",C.UPDATED_BY as ""แก้ไขโดย"" "
        sql_str = sql_str & " FROM CARD C,TRANSPORT_UNIT T , TAS.V_CARD_TYPE  V  "
        sql_str = sql_str & " WHERE C.TU_NUMBER =T.TU_NUMBER(+)  "
        sql_str = sql_str & " AND C.CARD_TYPE = V.TYPE_ID"
        sql_str = sql_str & " and C.CARD_CODE like  ('%" & cbCard.Text & "%')"
        sql_str = sql_str & " ORDER BY C.CARD_NO"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView1.DataSource = dt
            txtTotalRecord.Text = dt.Rows.Count
            If dt.Rows.Count > 0 Then
                For i = 0 To DataGridView1.ColumnCount - 1
                    Dim col As New DataGridViewColumn
                    col = DataGridView1.Columns(i)
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                Next
                Show_Data_Search = True
            End If
        Else
            Show_Data_Search = False
        End If
        mDataSet = Nothing
    End Function

    Private Sub cbCard_KeyDown(sender As Object, e As KeyEventArgs) Handles cbCard.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbCard.Text <> "" Then
                If Show_Data_Search() Then
                    Dim id As String
                    id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                    frmMainCard_sub.Close()
                    frmMainCard_sub.setFrmWork(2)
                    frmMainCard_sub.setPkId(id)
                    frmMainCard_sub.ShowDialog()
                End If
            Else
                Show_Data()
            End If
        End If
    End Sub
End Class

