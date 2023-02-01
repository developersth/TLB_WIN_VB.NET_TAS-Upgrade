Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmMainCustomer_main
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=add ,2=Edit

    Private Sub frmMainCustomer_main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmMainCustomer_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        ''Initial_frm()
        Show_Data()
        InitialCustomer()
    End Sub

    Private Sub frmMainCustomer_main_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
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

    End Sub

    Public Sub Show_Data()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = _
        "select C.CUSTOMER_CODE as ""รหัสลูกค้า"",C.CUSTOMER_NAME as ""ชื่อลูกค้า"",C.PO_NO as ""Purchase Order No."",C.CUSTOMER_TYPE as ""ประเภทลูกค้า""," & _
        " C.CITY as ""จังหวัด"",C.POSTAL_CODE as ""รหัสไปรษณี"",C.CUSTOMER_ADDRESS as ""ที่อยู่"",C.TEL as ""โทร""," & _
        " case C.CHECK_TARE_WEIGHT when 1 then 'Check' else 'Uncheck' end as ""ตรวจสอบรถค้าง"",C.UPDATE_DATE as ""วันที่แก้ไข"",C.UPDATED_BY as ""แก้ไขโดย"",C.IS_USE_PO" & _
        " from CUSTOMER C " & _
        " order by C.CUSTOMER_CODE"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            'DataGridView1.RowCount = 0
            'Do While dt.Rows.Count > i
            '    DataGridView1.RowCount = DataGridView1.RowCount + 1
            '    DataGridView1.Rows.Item(i).Height = Grid_Height
            '    DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CUSTOMER_CODE")), "", dt.Rows(i).Item("CUSTOMER_CODE").ToString)
            '    DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CUSTOMER_NAME")), "", dt.Rows(i).Item("CUSTOMER_NAME").ToString)
            '    DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PO_NO")), "", dt.Rows(i).Item("PO_NO").ToString)
            '    DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CUSTOMER_TYPE")), "", dt.Rows(i).Item("CUSTOMER_TYPE").ToString)
            '    DataGridView1.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CUSTOMER_ADDRESS")), "", dt.Rows(i).Item("CUSTOMER_ADDRESS").ToString)
            '    DataGridView1.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CITY")), "", dt.Rows(i).Item("CITY").ToString)
            '    DataGridView1.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("POSTAL_CODE")), "", dt.Rows(i).Item("POSTAL_CODE").ToString)
            '    DataGridView1.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TEL")), "", dt.Rows(i).Item("TEL").ToString)
            '    DataGridView1.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", Format(dt.Rows(i).Item("UPDATE_DATE"), "dd/MM/yyyy HH:mm:ss"))
            '    DataGridView1.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
            '    DataGridView1.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CHECK_TARE_WEIGHT")), "", IIf(dt.Rows(i).Item("CHECK_TARE_WEIGHT").ToString = 1, "Check", "Uncheck"))
            '    i = i + 1
            'Loop
            DataGridView1.DataSource = dt
            txtTotalRecord.Text = dt.Rows.Count
            For i = 0 To DataGridView1.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = DataGridView1.Columns(i)              
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                DataGridView1.Columns(DataGridView1.ColumnCount - 1).Visible = False
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
        sql_str = " DELETE FROM CUSTOMER    "
        sql_str = sql_str & " WHERE  CUSTOMER_CODE = '" + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + "' "
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
        frmMainCustomer_sub.Close()
        frmMainCustomer_sub.setFrmWork(1)
        frmMainCustomer_sub.ShowDialog()
    End Sub

    Private Sub UcMenuEdit_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuEdit.OnClickMnuText
        Dim id As String
        id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        frmMainCustomer_sub.Close()
        frmMainCustomer_sub.setFrmWork(2)
        frmMainCustomer_sub.setPkId(id)
        frmMainCustomer_sub.ShowDialog()
    End Sub

    Private Sub UcMenuDelete_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuDelete.OnClickMnuText
        Dim result As Integer = MessageBox.Show("ต้องการลบข้อมูล : " + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + " หรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
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

    Private Sub UcHeader1_CloseButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.MinimizeButtonClick, UcHeader1.CloseButtonClick
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UcHeader1_MinimizeButtonClick(sender As Object, e As EventArgs)
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

    Private Sub cbCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCustomer.SelectedIndexChanged
        If cbCustomer.Text <> "" Then
            If Show_Data_Search() Then
                Dim id As String
                id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                frmMainCustomer_sub.Close()
                frmMainCustomer_sub.setFrmWork(2)
                frmMainCustomer_sub.setPkId(id)
                frmMainCustomer_sub.ShowDialog()
            End If

        End If
    End Sub
    Function Show_Data_Search() As Boolean
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Show_Data_Search = False
        sql_str = _
      "select C.CUSTOMER_CODE as ""รหัสลูกค้า"",C.CUSTOMER_NAME as ""ชื่อลูกค้า"",C.PO_NO as ""Purchase Order No."",C.CUSTOMER_TYPE as ""ประเภทลูกค้า""," & _
      " C.CITY as ""จังหวัด"",C.POSTAL_CODE as ""รหัสไปรษณี"",C.CUSTOMER_ADDRESS as ""ที่อยู่"",C.TEL as ""โทร""," & _
      " case C.CHECK_TARE_WEIGHT when 1 then 'Check' else 'Uncheck' end as ""ตรวจสอบรถค้าง"",C.UPDATE_DATE as ""วันที่แก้ไข"",C.UPDATED_BY as ""แก้ไขโดย"",C.IS_USE_PO" & _
      " from CUSTOMER C " & _
      " where C.CUSTOMER_NAME like  ('%" & cbCustomer.Text & "%')" & _
      " order by C.CUSTOMER_CODE"
    
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

    Private Sub cbCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles cbCustomer.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbCustomer.Text <> "" Then
                If Show_Data_Search() Then
                    Dim id As String
                    id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                    frmMainCustomer_sub.Close()
                    frmMainCustomer_sub.setFrmWork(2)
                    frmMainCustomer_sub.setPkId(id)
                    frmMainCustomer_sub.ShowDialog()
                End If
            Else
                Show_Data()
            End If
        End If
    End Sub
    Private Sub InitialCustomer()
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim tmpTUheader As String
        Dim dt As DataTable

        tmpTUheader = cbCustomer.Text
        strSQL = _
             "select C.CUSTOMER_NAME " & _
             " from CUSTOMER C order by C.CUSTOMER_NAME "
        cbCustomer.Items.Clear()
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            For Each dr As DataRow In dt.Rows
                cbCustomer.Items.Add(IIf(IsDBNull(dr.Item("CUSTOMER_NAME")), "", Trim(dr.Item("CUSTOMER_NAME"))))
            Next
        End If
        cbCustomer.Text = tmpTUheader
        mDataSet = Nothing
    End Sub
End Class

