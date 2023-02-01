Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmMainDriver_main
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=add ,2=Edit

    Private Sub frmMainDriver_main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmMainDriver_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        'Initial_frm()
        Show_Data()
        InitialDriver()
    End Sub

    Private Sub frmMainDriver_main_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Try
            Me.Close()
        Catch ex As Exception
        End Try
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

        'sql_str = _
        '" select D.DRIVER_ID ,D.Driver_code,D.FIRST_NAME || '  ' || D.LAST_NAME as DRIVER_NAME, " & _
        '" D.PERSONAL_ID,D.CARRIER_ID,D.ADDRESS," & _
        '" d.LICENSE , d.EXPIRE_DATE, d.IS_ENABLED, d.UPDATE_DATE, d.UPDATED_BY, C.Carrier_Name" & _
        '" from DRIVER D,Carrier C " & _
        '"where d.carrier_id=c.carrier_id(+) order by d.FIRST_NAME"

        sql_str = _
        " select D.DRIVER_ID as ""รหัสพนักงานขับรถ"",D.Driver_code as ""รหัสอ้างอิง"",D.FIRST_NAME || '  ' || D.LAST_NAME as ""ชื่อ - นามสกุล"", " & _
        " D.PERSONAL_ID as ""เลขบัตรประชาชน"",D.CARRIER_ID as ""ผูู้ขนส่ง"",D.ADDRESS as ""ทีอยู่""," & _
        " d.LICENSE as ""เลขใบขับขี่"" , d.EXPIRE_DATE as ""วันหมดอายุใบขับขี่"", d.IS_ENABLED as ""สถานะใช้งาน"", d.UPDATE_DATE as ""วันที่แก้ไขล่าสุด"", d.UPDATED_BY as ""แก้ไขโดย""" & _
        " from DRIVER D,Carrier C " & _
        "where d.carrier_id=c.carrier_id(+) order by d.FIRST_NAME"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            'DataGridView1.RowCount = 0
            'Do While dt.Rows.Count > i
            '    DataGridView1.RowCount = DataGridView1.RowCount + 1
            '    DataGridView1.Rows.Item(i).Height = Grid_Height
            '    DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_ID")), "", dt.Rows(i).Item("DRIVER_ID").ToString)
            '    DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_Code")), "", dt.Rows(i).Item("DRIVER_Code").ToString)
            '    DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_NAME")), "", dt.Rows(i).Item("DRIVER_NAME").ToString)
            '    DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("carrier_id")), "", dt.Rows(i).Item("carrier_id").ToString)
            '    DataGridView1.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Address")), "", dt.Rows(i).Item("Address").ToString)
            '    DataGridView1.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PERSONAL_ID")), "", dt.Rows(i).Item("PERSONAL_ID").ToString)
            '    DataGridView1.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LICENSE")), "", dt.Rows(i).Item("LICENSE").ToString)
            '    DataGridView1.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("EXPIRE_DATE")), "", Format(dt.Rows(i).Item("EXPIRE_DATE"), "dd/MM/yyyy HH:mm:ss"))
            '    DataGridView1.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", IIf(dt.Rows(i).Item("IS_ENABLED").ToString = 1, "สามารถใช้งานได้", "หยุดการใช้งาน"))
            '    DataGridView1.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", Format(dt.Rows(i).Item("UPDATE_DATE"), "dd/MM/yyyy HH:mm:ss"))
            '    DataGridView1.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)

            '    i = i + 1
            'Loop
            DataGridView1.DataSource = dt
            txtTotalRecord.Text = dt.Rows.Count
            For i = 0 To DataGridView1.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = DataGridView1.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            Next
            'DataGridView1.RowCount = dt.Rows.Count
            'With DataGridView1
            '    For i = 0 To .RowCount - 1
            '        .Rows(i).Height = Grid_Height
            '        .Rows(i).Cells(0).Value = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_ID")), "", dt.Rows(i).Item("DRIVER_ID").ToString)
            '        .Rows(i).Cells(1).Value = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_Code")), "", dt.Rows(i).Item("DRIVER_Code").ToString)
            '        .Rows(i).Cells(2).Value = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_NAME")), "", dt.Rows(i).Item("DRIVER_NAME").ToString)
            '        .Rows(i).Cells(3).Value = IIf(IsDBNull(dt.Rows(i).Item("carrier_id")), "", dt.Rows(i).Item("carrier_id").ToString)
            '        .Rows(i).Cells(4).Value = IIf(IsDBNull(dt.Rows(i).Item("Address")), "", dt.Rows(i).Item("Address").ToString)
            '        .Rows(i).Cells(5).Value = IIf(IsDBNull(dt.Rows(i).Item("PERSONAL_ID")), "", dt.Rows(i).Item("PERSONAL_ID").ToString)
            '        .Rows(i).Cells(6).Value = IIf(IsDBNull(dt.Rows(i).Item("LICENSE")), "", dt.Rows(i).Item("LICENSE").ToString)
            '        .Rows(i).Cells(7).Value = IIf(IsDBNull(dt.Rows(i).Item("EXPIRE_DATE")), "", Format(dt.Rows(i).Item("EXPIRE_DATE"), "dd/MM/yyyy HH:mm:ss"))
            '        .Rows(i).Cells(8).Value = IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", IIf(dt.Rows(i).Item("IS_ENABLED").ToString = 1, "สามารถใช้งานได้", "หยุดการใช้งาน"))
            '        .Rows(i).Cells(9).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", Format(dt.Rows(i).Item("UPDATE_DATE"), "dd/MM/yyyy HH:mm:ss"))
            '        .Rows(i).Cells(10).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
            '    Next
            'End With
        Else
        End If
        dt = Nothing
        mDataSet.Dispose()
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
        sql_str = " DELETE FROM DRIVER    "
        sql_str = sql_str & " WHERE  DRIVER_ID = '" + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + "' "
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
        frmMainDriver_sub.Close()
        frmMainDriver_sub.setFrmWork(1)
        frmMainDriver_sub.ShowDialog()
    End Sub

    Private Sub UcMenuEdit_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuEdit.OnClickMnuText
        Dim id As String
        id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        frmMainDriver_sub.Close()
        frmMainDriver_sub.setFrmWork(2)
        frmMainDriver_sub.setPkId(id)
        frmMainDriver_sub.ShowDialog()
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

    Private Sub cbDriver_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDriver.SelectedIndexChanged
        If cbDriver.Text <> "" Then
            If Show_Data_Search() Then
                Dim id As String
                id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                frmMainDriver_sub.Close()
                frmMainDriver_sub.setFrmWork(2)
                frmMainDriver_sub.setPkId(id)
                frmMainDriver_sub.ShowDialog()
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
         " select D.DRIVER_ID as ""รหัสพนักงานขับรถ"",D.Driver_code as ""รหัสอ้างอิง"",D.FIRST_NAME || '  ' || D.LAST_NAME as ""ชื่อ - นามสกุล"", " & _
         " D.PERSONAL_ID as ""เลขบัตรประชาชน"",D.CARRIER_ID as ""ผูู้ขนส่ง"",D.ADDRESS as ""ทีอยู่""," & _
         " d.LICENSE as ""เลขใบขับขี่"" , d.EXPIRE_DATE as ""วันหมดอายุใบขับขี่"", d.IS_ENABLED as ""สถานะใช้งาน"", d.UPDATE_DATE as ""วันที่แก้ไขล่าสุด"", d.UPDATED_BY as ""แก้ไขโดย""" & _
         " from DRIVER D,Carrier C " & _
         " where d.carrier_id=c.carrier_id(+) " & _
         " and D.FIRST_NAME || '  ' || D.LAST_NAME  like  ('%" & cbDriver.Text & "%')" & _
         " order by d.FIRST_NAME"

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

    Private Sub cbDriver_KeyDown(sender As Object, e As KeyEventArgs) Handles cbDriver.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbDriver.Text <> "" Then
                If Show_Data_Search() Then
                    Dim id As String
                    id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                    frmMainDriver_sub.Close()
                    frmMainDriver_sub.setFrmWork(2)
                    frmMainDriver_sub.setPkId(id)
                    frmMainDriver_sub.ShowDialog()
                End If
            Else
                Show_Data()
            End If
        End If
    End Sub
    Private Sub InitialDriver()
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim tmpDriver As String
        Dim dt As DataTable

        tmpDriver = cbDriver.Text
        strSQL = _
             "select D.FIRST_NAME || '  ' || D.LAST_NAME as ""ชื่อ - นามสกุล"" " & _
             " from DRIVER D order by ""ชื่อ - นามสกุล"" "
        cbDriver.Items.Clear()
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            For Each dr As DataRow In dt.Rows
                cbDriver.Items.Add(IIf(IsDBNull(dr.Item("ชื่อ - นามสกุล")), "", Trim(dr.Item("ชื่อ - นามสกุล"))))
            Next
        End If
        cbDriver.Text = tmpDriver
        mDataSet = Nothing
    End Sub
End Class

