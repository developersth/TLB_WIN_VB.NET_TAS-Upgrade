Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmCustomer
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=add ,2=Edit

    Private Sub frmCustomer_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UcStatus1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub
    Private Sub frmCustomer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Oradb.Connect()
        SetScreenResulotion()
        'Me.WindowState = FormWindowState.Normal
        'Me.StartPosition = FormStartPosition.CenterScreen
        CheckFormResize(Me)
        InitialForm(Me, lblTitleName.Text)
        UcStatus1.StartThread()

        gpFillForm.Text = "Customer"
        Initial_frm()
        Show_Data()
    End Sub

    Private Sub frmCustomer_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
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

        sql_str = "select * from  CUSTOMERS   "
        sql_str = sql_str & " Order by CUSTOMER_ID"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            Do While dt.Rows.Count > i
                DataGridView1.RowCount = DataGridView1.RowCount + 1
                DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CUSTOMER_ID")), "", dt.Rows(i).Item("CUSTOMER_ID").ToString)
                DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("NAMES")), "", dt.Rows(i).Item("NAMES").ToString)
                DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ADDRESS")), "", dt.Rows(i).Item("ADDRESS").ToString)
                DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ENABLED")), "ไม่ใช้งาน", IIf(dt.Rows(i).Item("ENABLED").ToString = "1", "ใช้งาน", "ไม่ใช้งาน"))
                DataGridView1.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CREATED_DATE")), "", dt.Rows(i).Item("CREATED_DATE").ToString)
                DataGridView1.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CREATED_BY")), "", dt.Rows(i).Item("CREATED_BY").ToString)
                DataGridView1.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_DATE")), "", dt.Rows(i).Item("UPDATED_DATE").ToString)
                DataGridView1.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txt_Customer_ID.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        txt_Driver_Name.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        txt_Address.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        If DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value = "ใช้งาน" Then
            rb_Ena_True.Checked = True
        Else
            rb_Ena_True.Checked = False
        End If
        txt_Created_Date.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value
        txt_Created_By.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
        txt_Update_Date.Text = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value
        txt_Update_By.Text = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub Clear_frm()
        txt_Customer_ID.Text = ""
        txt_Driver_Name.Text = ""
        txt_Address.Text = ""
        rb_Ena_True.Checked = True
        txt_Created_Date.Text = ""
        txt_Created_By.Text = ""
        txt_Update_Date.Text = ""
        txt_Update_By.Text = ""
    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        DataGridView1.Enabled = iBoo

        txt_Customer_ID.Enabled = Not iBoo
        txt_Driver_Name.Enabled = Not iBoo
        txt_Address.Enabled = Not iBoo
        rb_Ena_True.Enabled = Not iBoo
        rb_Ena_False.Enabled = Not iBoo

        If iBoo Then
            txt_Customer_ID.BackColor = Color.LightGray
            txt_Driver_Name.BackColor = Color.LightGray
            txt_Address.BackColor = Color.LightGray
        Else
            txt_Customer_ID.BackColor = Color.White
            txt_Driver_Name.BackColor = Color.White
            txt_Address.BackColor = Color.White
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
        If Trim(txt_Customer_ID.Text) = "" Then
            MsgBox("กรุณาเลือก รายการที่จะแก้ไข ", MsgBoxStyle.Critical, vbOKOnly)
            Exit Sub
        End If

        txtLock(False)
        frm_work = 2
        txt_Customer_ID.Enabled = True
        txt_Customer_ID.BackColor = Color.Gray
        txt_Update_Date.Text = FDateTime(Now())
        txt_Update_By.Text = mUserName
    End Sub

    Private Sub Save()
        On Error GoTo Err_msg
        Dim sql As String = ""




Err_msg:
        MsgBox(Err.Number & " : " & Err.Description)
    End Sub

    Private Sub txt_Driver_ID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Customer_ID.KeyPress
        e.Handled = CurrencyOnly(txt_Customer_ID, e.KeyChar)
    End Sub
End Class
