Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmTruck
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=add ,2=Edit

    Private Sub frmTruck_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

    End Sub

    Private Sub frmTruck_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UcStatus1.StopThread()
        CloseForm(FormScreenID, "")
        'mManuStack.Pop()
        'frmMasterData.Show()
    End Sub

    Private Sub frmTruck_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Visible = False
        SetScreenResulotion()
        CheckFormResize(Me)
        InitialForm(Me, lblTitleName.Text)
        UcStatus1.StartThread()
        Me.Visible = True

        gpFillForm.Text = "Truck"
        Initial_frm()
        Show_Data()
    End Sub

    Private Sub frmTruck_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin() Handles UcMinimize1.OnCilckMin
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose() Handles UcClose1.OnClickClose
        Me.Close()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
#Region "Menu Event"
    Private Sub UcInsert1_OnClickInsert(ByVal ucName As System.String, ByRef ucScreeenID As System.Int64) Handles UcInsert1.OnClickInsert
        DisableMenu(ucName, False)
        Insert_Data()
    End Sub

    Private Sub UcEdit1_OnClickEdit(ByVal ucName As System.String, ByRef ucScreeenID As System.Int64) Handles UcEdit1.OnClickEdit
        DisableMenu(ucName, False)
        Edit_Data()
    End Sub

    Private Sub UcDelete1_OnClickDelete(ByVal ucName As System.String, ByRef ucScreeenID As System.Int64) Handles UcDelete1.OnClickDelete
        DisableMenu(ucName, False)
    End Sub

    Private Sub UcSearch1_OnClickSearch(ByVal ucName As System.String) Handles UcSearch1.OnClickSearch

    End Sub

    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave
        DisableMenu(ucName, True)
        Save()
    End Sub

    Private Sub UcCancel1_OnClickCancel(ByVal ucName As System.String) Handles UcCancel1.OnClickCancel
        DisableMenu(ucName, True)
        Initial_frm()
    End Sub

    Private Sub UcReflesh1_OnClickReflesh(ByVal ucName As System.String) Handles UcReflesh1.OnClickReflesh

    End Sub
#End Region

    Private Sub DisableMenu(ByVal pName As String, ByVal bDisable As Boolean)
        gpMnuType2.Visible = Not bDisable
        For Each ctrl As Control In gpMnuType1.Controls
            If ctrl.Name = pName Then
                'ctrl.Enabled = Not bDisable
            Else
                ctrl.Enabled = bDisable
            End If
        Next
    End Sub

    Private Sub Initial_frm()
        frm_work = 0
        Clear_frm()
        txtLock(True)
    End Sub

    Private Sub Show_Data()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "select * from  TRUCK   "
        sql_str = sql_str & " Order by TRUCK_ID"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            Do While dt.Rows.Count > i
                DataGridView1.RowCount = DataGridView1.RowCount + 1
                DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TRUCK_ID")), "", dt.Rows(i).Item("TRUCK_ID").ToString)
                DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TYPE")), "", dt.Rows(i).Item("TYPE").ToString)
                DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("NAME1")), "", dt.Rows(i).Item("NAME1").ToString)
                DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("NAME2")), "", dt.Rows(i).Item("NAME2").ToString)
                DataGridView1.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CARD_CODE")), "", dt.Rows(i).Item("CARD_CODE").ToString)
                DataGridView1.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ENABLED")), "ไม่ใช้งาน", IIf(dt.Rows(i).Item("ENABLED").ToString = "1", "ใช้งาน", "ไม่ใช้งาน"))
                DataGridView1.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("COMPARTMENT_TOTAL")), "", dt.Rows(i).Item("COMPARTMENT_TOTAL").ToString)
                DataGridView1.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("COMPARTMENT_TYPE")), "", dt.Rows(i).Item("COMPARTMENT_TYPE").ToString)
                DataGridView1.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TARE_WEIGHT")), "", dt.Rows(i).Item("TARE_WEIGHT").ToString)
                DataGridView1.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("GROSS_WEIGHT")), "", dt.Rows(i).Item("GROSS_WEIGHT").ToString)
                DataGridView1.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UNIT")), "", dt.Rows(i).Item("UNIT").ToString)
                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txt_Truck_ID.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        txt_Truck_Type.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        txt_Name1.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        txt_Name2.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        txt_Card_Code.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        If DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value = "ใช้งาน" Then
            rb_Ena_True.Checked = True
        Else
            rb_Ena_True.Checked = False
        End If
        txt_Comp_Total.Text = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
        txt_Comp_Type.Text = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
        txt_Tare_Weight.Text = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
        txt_Gross_Weight.Text = DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value
        txt_Unit.Text = DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub Clear_frm()
        txt_Truck_ID.Text = ""
        txt_Truck_Type.Text = ""
        txt_Name1.Text = ""
        txt_Name2.Text = ""
        txt_Card_Code.Text = ""
        rb_Ena_True.Checked = True
        txt_Comp_Total.Text = ""
        txt_Comp_Type.Text = ""
        txt_Tare_Weight.Text = ""
        txt_Gross_Weight.Text = ""
        txt_Unit.Text = ""
    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        DataGridView1.Enabled = iBoo

        txt_Truck_ID.Enabled = Not iBoo
        txt_Truck_Type.Enabled = Not iBoo
        txt_Name1.Enabled = Not iBoo
        txt_Name2.Enabled = Not iBoo
        txt_Card_Code.Enabled = Not iBoo
        rb_Ena_True.Enabled = Not iBoo
        rb_Ena_False.Enabled = Not iBoo
        txt_Comp_Total.Enabled = Not iBoo
        txt_Comp_Type.Enabled = Not iBoo
        txt_Tare_Weight.Enabled = Not iBoo
        txt_Gross_Weight.Enabled = Not iBoo
        txt_Unit.Enabled = Not iBoo

        If iBoo Then
            txt_Truck_ID.BackColor = Color.LightGray
            txt_Truck_Type.BackColor = Color.LightGray
            txt_Name1.BackColor = Color.LightGray
            txt_Name2.BackColor = Color.LightGray
            txt_Card_Code.BackColor = Color.LightGray
            txt_Comp_Total.BackColor = Color.LightGray
            txt_Comp_Type.BackColor = Color.LightGray
            txt_Tare_Weight.BackColor = Color.LightGray
            txt_Gross_Weight.BackColor = Color.LightGray
            txt_Unit.BackColor = Color.LightGray
        Else
            txt_Truck_ID.BackColor = Color.White
            txt_Truck_Type.BackColor = Color.White
            txt_Name1.BackColor = Color.White
            txt_Name2.BackColor = Color.White
            txt_Card_Code.BackColor = Color.White
            txt_Comp_Total.BackColor = Color.White
            txt_Comp_Type.BackColor = Color.White
            txt_Tare_Weight.BackColor = Color.White
            txt_Gross_Weight.BackColor = Color.White
            txt_Unit.BackColor = Color.White
        End If
    End Sub

    Private Sub Insert_Data()
        Clear_frm()
        txtLock(False)
        frm_work = 1
    End Sub

    Private Sub Edit_Data()
        If Trim(txt_Truck_ID.Text) = "" Then
            MsgBox("กรุณาเลือก รายการที่จะแก้ไข ", MsgBoxStyle.Critical, vbOKOnly)
            Exit Sub
        End If

        txtLock(False)
        frm_work = 2
        txt_Truck_ID.Enabled = True
        txt_Truck_ID.BackColor = Color.Gray
    End Sub

    Private Sub Save()
        On Error GoTo Err_msg
        Dim sql As String = ""




Err_msg:
        MsgBox(Err.Number & " : " & Err.Description)
    End Sub

    Private Sub txt_Driver_ID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Truck_ID.KeyPress
        e.Handled = CurrencyOnly(txt_Truck_ID, e.KeyChar)
    End Sub

End Class
