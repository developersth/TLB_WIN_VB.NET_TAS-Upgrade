Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmMainVehicle_main
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=add ,2=Edit

    Private Sub frmMainVehicle_main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmMainVehicle_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        'Initial_frm()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        Show_Data()
        InitialTransport()
    End Sub

    Private Sub frmMainVehicle_main_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
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

        sql_str = _
        "select t.vehicle_number as ""รหัสรถ""" & _
        " ,t.vehicle_id" & _
        " ,t.tu_number ||'-'||t.vehicle_id as ""ทะเบียนรถ(หัวลาก)""" & _
        " ,u1.tu_id as ""ทะเบียนรถพ่วง""" & _
        " ,t.map_type as ""ประเภทรถ""" & _
        ",case t.Is_enabled when 1 then 'สามารถใช้งานได้' else 'หยุดการใช้งาน' end as ""สถานะการใช้งาน""" & _
        ",t.expire_date as ""วันวัดน้ำหนักหมดอายุ""  " & _
        " ,t.carrier_id " & _
        " ||'-'||c.carrier_name as ""ผู้ขนส่ง""" & _
        ",t.UPDATE_DATE as ""วันที่แก้ไขล่าสุด""" & _
        ",t.UPDATED_BY as ""แก้ไขโดย""" & _
        " from vehicle t," & _
        " tas.transport_unit u,tas.transport_unit u1,tas.carrier c " & _
        " where t.tu_number=u.tu_number(+)" & _
        " and t.tu_number1=u1.tu_number(+)" & _
        " and t.carrier_id=c.carrier_id(+)  " & _
        " Order by t.vehicle_number "
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            'DataGridView1.RowCount = 0
            'Do While dt.Rows.Count > i
            '    DataGridView1.RowCount = DataGridView1.RowCount + 1
            '    DataGridView1.Rows.Item(i).Height = Grid_Height
            '    DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("vehicle_number")), "", dt.Rows(i).Item("vehicle_number").ToString)
            '    DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("vehicle_id")), "", dt.Rows(i).Item("vehicle_id").ToString)
            '    DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("tu_number")), "", dt.Rows(i).Item("tu_number").ToString)
            '    DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("tu_number1")), "", dt.Rows(i).Item("tu_number1").ToString)
            '    DataGridView1.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("map_type")), "", dt.Rows(i).Item("map_type").ToString)
            '    DataGridView1.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Is_enabled")), "", IIf(dt.Rows(i).Item("Is_enabled").ToString = 1, "สามารถใช้งานได้", "หยุดการใช้งาน"))
            '    DataGridView1.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("expire_date")), "", Format(dt.Rows(i).Item("expire_date"), "dd/MM/yyyy HH:mm:ss"))
            '    DataGridView1.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("carrier_id")), "", dt.Rows(i).Item("carrier_id").ToString & "-" & dt.Rows(i).Item("carrier_name").ToString)
            '    DataGridView1.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", Format(dt.Rows(i).Item("UPDATE_DATE"), "dd/MM/yyyy HH:mm:ss"))
            '    DataGridView1.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
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
        sql_str = " DELETE FROM Vehicle    "
        sql_str = sql_str & " WHERE  vehicle_number = '" + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + "' "
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
        frmMainVehicle_sub.Close()
        frmMainVehicle_sub.setFrmWork(1)
        frmMainVehicle_sub.ShowDialog()
    End Sub

    Private Sub UcMenuEdit_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuEdit.OnClickMnuText
        Dim id As String
        id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        frmMainVehicle_sub.Close()
        frmMainVehicle_sub.setFrmWork(2)
        frmMainVehicle_sub.setPkId(id)
        frmMainVehicle_sub.ShowDialog()
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

    Private Sub cbTUHead_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTUHead.SelectedIndexChanged
        If cbTUHead.Text <> "" Then
            If Show_Data_Search() Then
                Dim id As String
                id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                frmMainVehicle_sub.Close()
                frmMainVehicle_sub.setFrmWork(2)
                frmMainVehicle_sub.setPkId(id)
                frmMainVehicle_sub.ShowDialog()
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
                "select t.vehicle_number as ""รหัสรถ""" & _
                " ,t.vehicle_id" & _
                " ,t.tu_number ||'-'||t.vehicle_id as ""ทะเบียนรถ(หัวลาก)""" & _
                " ,u1.tu_id as ""ทะเบียนรถพ่วง""" & _
                " ,t.map_type as ""ประเภทรถ""" & _
                ",case t.Is_enabled when 1 then 'สามารถใช้งานได้' else 'หยุดการใช้งาน' end as ""สถานะการใช้งาน""" & _
                ",t.expire_date as ""วันวัดน้ำหนักหมดอายุ""  " & _
                " ,t.carrier_id " & _
                " ||'-'||c.carrier_name as ""ผู้ขนส่ง""" & _
                ",t.UPDATE_DATE as ""วันที่แก้ไขล่าสุด""" & _
                ",t.UPDATED_BY as ""แก้ไขโดย""" & _
                " from vehicle t," & _
                " tas.transport_unit u,tas.transport_unit u1,tas.carrier c " & _
                " where t.tu_number=u.tu_number(+)" & _
                " and t.tu_number1=u1.tu_number(+)" & _
                " and t.carrier_id=c.carrier_id(+)  " & _
                " and t.vehicle_number like ('%" & cbTUHead.Text & "%')" & _
                " Order by t.vehicle_number "

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

    Private Sub cbTUHead_KeyDown(sender As Object, e As KeyEventArgs) Handles cbTUHead.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cbTUHead.Text <> "" Then
                If Show_Data_Search() Then
                    Dim id As String
                    id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                    frmMainVehicle_sub.Close()
                    frmMainVehicle_sub.setFrmWork(2)
                    frmMainVehicle_sub.setPkId(id)
                    frmMainVehicle_sub.ShowDialog()
                End If
            Else
                Show_Data()
            End If
        End If
    End Sub
    Private Sub InitialTransport()
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim tmpTUheader As String
        Dim dt As DataTable

        tmpTUheader = cbTUHead.Text
        strSQL = _
         "select t.vehicle_number as ""รหัสรถ""" & _
                " ,t.vehicle_id" & _
                " ,t.tu_number ||'-'||t.vehicle_id as ""ทะเบียนรถ(หัวลาก)""" & _
                " ,u1.tu_id as ""ทะเบียนรถพ่วง""" & _
                " ,t.map_type as ""ประเภทรถ""" & _
                ",case t.Is_enabled when 1 then 'สามารถใช้งานได้' else 'หยุดการใช้งาน' end as ""สถานะการใช้งาน""" & _
                ",t.expire_date as ""วันวัดน้ำหนักหมดอายุ""  " & _
                " ,t.carrier_id " & _
                " ||'-'||c.carrier_name as ""ผู้ขนส่ง""" & _
                ",t.UPDATE_DATE as ""วันที่แก้ไขล่าสุด""" & _
                ",t.UPDATED_BY as ""แก้ไขโดย""" & _
                " from vehicle t," & _
                " tas.transport_unit u,tas.transport_unit u1,tas.carrier c " & _
                " where t.tu_number=u.tu_number(+)" & _
                " and t.tu_number1=u1.tu_number(+)" & _
                " and t.carrier_id=c.carrier_id(+)  " & _
                " Order by t.vehicle_number"
        cbTUHead.Items.Clear()
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            For Each dr As DataRow In dt.Rows
                cbTUHead.Items.Add(IIf(IsDBNull(dr.Item("รหัสรถ")), "", Trim(dr.Item("รหัสรถ"))))
            Next
        End If
        cbTUHead.Text = tmpTUheader
        mDataSet = Nothing
    End Sub
End Class

