Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmDriver
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=add ,2=Edit

    Private Sub frmDriver_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

    End Sub

    Private Sub frmDriver_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UcStatus1.StopThread()
        CloseForm(FormScreenID, "")
        'mManuStack.Pop()
        'frmMasterData.Show()
    End Sub

    Private Sub frmDriver_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Visible = False
        SetScreenResulotion()
        CheckFormResize(Me)
        InitialForm(Me, lblTitleName.Text)
        UcStatus1.StartThread()
        Me.Visible = True

        gpFillForm.Text = "Driver"
        Initial_frm()
        Show_Data()
    End Sub

    Private Sub frmDriver_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
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
        txt_Created_Date.Enabled = False
        txt_Created_Date.BackColor = Color.LightGray
        txt_Created_By.Enabled = False
        txt_Created_By.BackColor = Color.LightGray
        txt_Update_Date.Enabled = False
        txt_Update_Date.BackColor = Color.LightGray
        txt_Update_By.Enabled = False
        txt_Update_By.BackColor = Color.LightGray
    End Sub

    Private Sub Show_Data()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "select * from  DRIVERS   "
        sql_str = sql_str & " Order by DRIVER_ID"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            Do While dt.Rows.Count > i
                DataGridView1.RowCount = DataGridView1.RowCount + 1
                DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_ID")), "", dt.Rows(i).Item("DRIVER_ID").ToString)
                DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PERSONAL_ID")), "", dt.Rows(i).Item("PERSONAL_ID").ToString)
                DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("NAMES")), "", dt.Rows(i).Item("NAMES").ToString)
                DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ADDRESS")), "", dt.Rows(i).Item("ADDRESS").ToString)
                DataGridView1.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DRIVING_LICENSE")), "", dt.Rows(i).Item("DRIVING_LICENSE").ToString)
                DataGridView1.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ENABLED")), "ไม่ใช้งาน", IIf(dt.Rows(i).Item("ENABLED").ToString = "1", "ใช้งาน", "ไม่ใช้งาน"))
                DataGridView1.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CARD_CODE")), "", dt.Rows(i).Item("CARD_CODE").ToString)
                DataGridView1.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PATH_PICTURE")), "", dt.Rows(i).Item("PATH_PICTURE").ToString)
                DataGridView1.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CREATED_DATE")), "", dt.Rows(i).Item("CREATED_DATE").ToString)
                DataGridView1.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CREATED_BY")), "", dt.Rows(i).Item("CREATED_BY").ToString)
                DataGridView1.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_DATE")), "", dt.Rows(i).Item("UPDATED_DATE").ToString)
                DataGridView1.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txt_Driver_ID.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        txt_Personal_ID.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        txt_Driver_Name.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        txt_Address.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        txt_Driver_License.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        If DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value = "ใช้งาน" Then
            rb_Ena_True.Checked = True
        Else
            rb_Ena_True.Checked = False
        End If
        txt_Card_Code.Text = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
        txt_Path_Picture.Text = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
        txt_Created_Date.Text = DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value
        txt_Created_By.Text = DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value
        txt_Update_Date.Text = DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value
        txt_Update_By.Text = DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub Clear_frm()
        txt_Driver_ID.Text = ""
        txt_Personal_ID.Text = ""
        txt_Driver_Name.Text = ""
        txt_Address.Text = ""
        txt_Driver_License.Text = ""
        rb_Ena_True.Checked = True
        txt_Card_Code.Text = ""
        txt_Path_Picture.Text = ""
        txt_Created_Date.Text = ""
        txt_Created_By.Text = ""
        txt_Update_Date.Text = ""
        txt_Update_by.Text = ""
    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        DataGridView1.Enabled = iBoo

        txt_Driver_ID.Enabled = Not iBoo
        txt_Personal_ID.Enabled = Not iBoo
        txt_Driver_Name.Enabled = Not iBoo
        txt_Address.Enabled = Not iBoo
        txt_Driver_License.Enabled = Not iBoo
        rb_Ena_True.Enabled = Not iBoo
        rb_Ena_False.Enabled = Not iBoo
        txt_Card_Code.Enabled = Not iBoo
        txt_Path_Picture.Enabled = Not iBoo

        If iBoo Then
            txt_Driver_ID.BackColor = Color.LightGray
            txt_Personal_ID.BackColor = Color.LightGray
            txt_Driver_Name.BackColor = Color.LightGray
            txt_Address.BackColor = Color.LightGray
            txt_Driver_License.BackColor = Color.LightGray
            txt_Card_Code.BackColor = Color.LightGray
            txt_Path_Picture.BackColor = Color.LightGray
        Else
            txt_Driver_ID.BackColor = Color.White
            txt_Personal_ID.BackColor = Color.White
            txt_Driver_Name.BackColor = Color.White
            txt_Address.BackColor = Color.White
            txt_Driver_License.BackColor = Color.White
            txt_Card_Code.BackColor = Color.White
            txt_Path_Picture.BackColor = Color.White
        End If
    End Sub

    Private Sub Insert_Data()
        Clear_frm()
        txtLock(False)
        frm_work = 1

        txt_Created_Date.Text = FDateTime(Now())
        txt_Created_By.Text = mUserName
        txt_Update_Date.Text = FDateTime(Now())
        txt_Update_By.Text = mUserName
    End Sub

    Private Sub Edit_Data()
        If Trim(txt_Driver_ID.Text) = "" Then
            MsgBox("กรุณาเลือก รายการที่จะแก้ไข ", MsgBoxStyle.Critical, vbOKOnly)
            Exit Sub
        End If

        txtLock(False)
        frm_work = 2
        txt_Driver_ID.Enabled = True
        txt_Driver_ID.BackColor = Color.Gray
        txt_Update_Date.Text = FDateTime(Now())
        txt_Update_By.Text = mUserName
    End Sub

    Private Sub Save()
        On Error GoTo Err_msg
        Dim sql As String = ""




Err_msg:
        MsgBox(Err.Number & " : " & Err.Description)
    End Sub

    Private Sub txt_Driver_ID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Driver_ID.KeyPress
        e.Handled = CurrencyOnly(txt_Driver_ID, e.KeyChar)
    End Sub

End Class
