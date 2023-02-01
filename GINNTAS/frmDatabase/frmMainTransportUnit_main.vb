Imports Oracle.DataAccess.Client
Imports System.Data
Imports System.Threading

Public Class frmMainTransportUnit_main
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=add ,2=Edit

    Private Sub frmMainTransportUnit_main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmMainTransportUnit_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        'Initial_frm()
        Show_Data()
        InitialTransport()
    End Sub

    Private Sub frmMainTransportUnit_main_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
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
    Private Sub InitialTransport()
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim tmpTUheader As String
        Dim dt As DataTable

        tmpTUheader = cbTUHead.Text
        strSQL =
             "select T.TU_ID,T.TU_NUMBER,T.TU_ID AS TuNAME " &
             " from TRANSPORT_UNIT T order by T.Tu_Id,T.TU_NUMBER "
        cbTUHead.Items.Clear()
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            For Each dr As DataRow In dt.Rows
                cbTUHead.Items.Add(IIf(IsDBNull(dr.Item("TuNAME")), "", Trim(dr.Item("TuNAME"))))
            Next
        End If
        cbTUHead.Text = tmpTUheader
        mDataSet = Nothing
    End Sub
    Function Show_Data_Search() As Boolean
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Show_Data_Search = False
        sql_str =
        "select T.TU_NUMBER as ""รหัสรถ"",T.TU_ID as ""หมายเลขทะเบียนรถ"",T.LAST_CAL_DATE as ""วันวัดน้ำหมดอายุครั้งก่อน""," &
        " T.NEXT_CAL_DATE as ""วันวัดน้ำหมดอายุ"",TARE_WEIGHT as ""น้ำหนักรถเปล่า"",case T.IS_ENABLED when 1 then 'สามารถใช้งานได้' else 'หยุดการใช้งาน' end as ""สถานะการใช้งาน"", T.COMPARTMENTS as ""จำนวนช่องเติม""," &
        "T.TU_TYPE||'-'||TU.description AS ""ชนิดรถ"" ," &
        "t.CAPACITYS as""ความจุ"", t.UPDATE_DATE as""วันที่แก้ไขล่าสุด"", t.UPDATED_BY as""แก้ไขโดย""" &
        " from TRANSPORT_UNIT T,tas.view_tu_type TU" &
        " where t.tu_type=tu.status_varchar(+)" &
        " and T.TU_ID like  ('%" & cbTUHead.Text & "%')" &
        " order by T.TU_NUMBER"
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
    Public Sub Show_Data()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str =
        "select T.TU_NUMBER as ""รหัสรถ"",T.TU_ID as ""หมายเลขทะเบียนรถ"",T.LAST_CAL_DATE as ""วันวัดน้ำหมดอายุครั้งก่อน""," &
        " T.NEXT_CAL_DATE as ""วันวัดน้ำหมดอายุ"",TARE_WEIGHT as ""น้ำหนักรถเปล่า"",case T.IS_ENABLED when 1 then 'สามารถใช้งานได้' else 'หยุดการใช้งาน' end as ""สถานะการใช้งาน"", T.COMPARTMENTS as ""จำนวนช่องเติม""," &
        "T.TU_TYPE||'-'||TU.description AS ""ชนิดรถ"" ," &
        "t.CAPACITYS as""ความจุ"", t.UPDATE_DATE as""วันที่แก้ไขล่าสุด"", t.UPDATED_BY as""แก้ไขโดย""" &
        " from TRANSPORT_UNIT T,tas.view_tu_type TU" &
        " where t.tu_type=tu.status_varchar(+)" &
        " order by T.TU_NUMBER"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            'DataGridView1.RowCount = 0
            'Do While dt.Rows.Count > i


            '    DataGridView1.RowCount = DataGridView1.RowCount + 1
            '    DataGridView1.Rows.Item(i).Height = Grid_Height
            '    DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TU_NUMBER")), "", dt.Rows(i).Item("TU_NUMBER").ToString)
            '    DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TU_ID")), "", dt.Rows(i).Item("TU_ID").ToString)
            '    DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LAST_CAL_DATE")), "", Format(dt.Rows(i).Item("LAST_CAL_DATE"), "dd/MM/yyyy HH:mm:ss"))
            '    DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("COMPARTMENTS")), "", dt.Rows(i).Item("COMPARTMENTS").ToString)
            '    DataGridView1.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CAPACITYS")), "", dt.Rows(i).Item("CAPACITYS").ToString)
            '    DataGridView1.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TARE_WEIGHT")), "", dt.Rows(i).Item("TARE_WEIGHT").ToString)
            '    DataGridView1.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TU_TYPE")), "", dt.Rows(i).Item("TU_TYPE").ToString)
            '    DataGridView1.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", IIf(dt.Rows(i).Item("IS_ENABLED").ToString = 1, "สามารถใช้งานได้", "ไม่สามารถใช้งานได้"))
            '    DataGridView1.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", Format(dt.Rows(i).Item("UPDATE_DATE"), "dd/MM/yyyy HH:mm:ss"))
            '    DataGridView1.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)

            '    i = i + 1
            'Loop
            DataGridView1.DataSource = dt
            txtTotalRecord.Text = dt.Rows.Count
            Dim t1 As Thread = New Thread(New ThreadStart(AddressOf DataGridViewAutoSize))
            t1.IsBackground = True
            t1.Start()

        Else
        End If
        mDataSet = Nothing
    End Sub
    Private Sub DataGridViewAutoSize()
        Thread.Sleep(1000)
        Me.Invoke(CType(Sub()
                            For i = 0 To DataGridView1.ColumnCount - 1
                                Dim col As New DataGridViewColumn
                                col = DataGridView1.Columns(i)
                                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                            Next
                        End Sub, MethodInvoker))
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
        Dim index = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString

        sql_str = " DELETE FROM TRANSPORT_COMPS    "
        sql_str = sql_str & " WHERE  TU_NUMBER = '" + index + "' "
        Oradb.ExeSQL(sql_str)

        sql_str = " DELETE FROM truck_blacklist    "
        sql_str = sql_str & " WHERE  Tu_id = '" + index + "' "
        Oradb.ExeSQL(sql_str)

        sql_str = " DELETE FROM TRANSPORT_UNIT    "
        sql_str = sql_str & " WHERE  TU_NUMBER = '" + index + "' "
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
        cbTUHead.Text = ""
    End Sub

    Private Sub UcMenuAdd_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuAdd.OnClickMnuText
        frmMainTransportUnit_sub.Close()
        frmMainTransportUnit_sub.setFrmWork(1)
        frmMainTransportUnit_sub.ShowDialog()
    End Sub

    Private Sub UcMenuEdit_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuEdit.OnClickMnuText
        Dim id As String
        id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        frmMainTransportUnit_sub.Close()
        frmMainTransportUnit_sub.setFrmWork(2)
        frmMainTransportUnit_sub.setPkId(id)
        frmMainTransportUnit_sub.ShowDialog()
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

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub cbTUHead_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTUHead.SelectedIndexChanged
        If cbTUHead.Text <> "" Then
            If Show_Data_Search() Then
                Dim id As String
                id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                frmMainTransportUnit_sub.Close()
                frmMainTransportUnit_sub.setFrmWork(2)
                frmMainTransportUnit_sub.setPkId(id)
                frmMainTransportUnit_sub.ShowDialog()
            End If

        End If

    End Sub

    Private Sub cbTUHead_KeyDown(sender As Object, e As KeyEventArgs) Handles cbTUHead.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbTUHead.Text <> "" Then
                If Show_Data_Search() Then
                    Dim id As String
                    id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                    frmMainTransportUnit_sub.Close()
                    frmMainTransportUnit_sub.setFrmWork(2)
                    frmMainTransportUnit_sub.setPkId(id)
                    frmMainTransportUnit_sub.ShowDialog()
                End If

            End If
        End If
    End Sub
End Class

