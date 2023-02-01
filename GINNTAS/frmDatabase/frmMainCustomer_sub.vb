Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmMainCustomer_sub
    Dim frm_work As Integer = 0 'Customer1=add ,2=Edit
    Dim pk_id As String = ""

    Private Sub frmMainCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        checkOptPOByCustomer()
        If frm_work = 1 Then
            Me.Text = "Customer # Add"
            GetNextID()
        ElseIf frm_work = 2 Then
            Me.Text = "Customer # Edit"
            AssignValue()
        End If
        txtLock(True)
    End Sub

    Private Sub Clear_frm()
        txtCustomerID.Text = ""
        txtCustomerName.Text = ""
        txtCustomerAddr.Text = ""
        cbCustomerType.Items.Clear()
        txtProvince.Text = ""
        txtPostCode.Text = ""
        txtTel.Text = ""
        txtPoNo.Text = ""
        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""
    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        If frm_work = 2 Then
            txtCustomerID.Enabled = Not iBoo
            txtLastUpdateDate.Enabled = Not iBoo
            txtLastUpdateBy.Enabled = Not iBoo

            If iBoo Then
                txtCustomerID.BackColor = Color.LightGray
                txtLastUpdateDate.BackColor = Color.LightGray
                txtLastUpdateBy.BackColor = Color.LightGray

            Else
                txtCustomerID.BackColor = Color.White
                txtLastUpdateDate.BackColor = Color.White
                txtLastUpdateBy.BackColor = Color.White
            End If
         End If
    End Sub

#Region "Menu Event"
    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave
        If frm_work = 1 Then 'Add
            If txtCustomerID.Text.Trim = "" Or txtCustomerName.Text.Trim = "" Or txtCustomerAddr.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If txtCustomerID.Text.Trim = "" Or txtCustomerName.Text.Trim = "" Or txtCustomerAddr.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Edit()
            End If
        End If
    End Sub

    Private Sub UcCancel1_OnClickCancel(ByVal ucName As System.String) Handles UcCancel1.OnClickCancel
        Me.Close()
        'Initial_frm()
    End Sub

#End Region

    Private Sub Save()
        Dim strSQL As String
        strSQL = _
        "insert into CUSTOMER(" & _
        "CUSTOMER_CODE,CUSTOMER_NAME," & _
        "CUSTOMER_TYPE,CUSTOMER_ADDRESS," & _
        "CITY,POSTAL_CODE,CHECK_TARE_WEIGHT," & _
        "TEL,CREATION_DATE," & _
        "PO_NO,IS_USE_PO," & _
        "CREATED_BY,UPDATE_DATE," & _
        "UPDATED_BY) " & _
        "values(" & _
        "'" & Trim(txtCustomerID.Text) & "','" & Trim(txtCustomerName.Text) & "'," & _
        "'" & cbCustomerType.Text & "','" & Trim(txtCustomerAddr.Text) & "'," & _
        "'" & txtProvince.Text & "','" & txtPostCode.Text & "','" & IIf(chkTareWeight.Checked, 1, 0) & "'," & _
        "'" & txtTel.Text & "',sysdate," & _
        "'" & txtPoNo.Text & "'," & IIf(OptPOByCustomer.Checked, 1, 0) & "," & _
        "'" & mUserName & "',sysdate," & _
        "'" & mUserName & "')"
        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmMainCustomer_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
    End Sub

    Public Sub setFrmWork(ByVal n As Integer)
        Me.frm_work = n
    End Sub

    Public Sub setPkId(ByVal id As String)
        Me.pk_id = id
    End Sub

    Private Sub Edit()
        Dim strSQL As String = _
        "update CUSTOMER C set " & _
        "C.CUSTOMER_NAME='" & Trim(txtCustomerName.Text) & "'," & _
        "C.CUSTOMER_TYPE='" & cbCustomerType.Text & "'," & _
        "C.CUSTOMER_ADDRESS='" & Trim(txtCustomerAddr.Text) & "'," & _
        "C.CITY='" & txtProvince.Text & "',POSTAL_CODE='" & txtPostCode.Text & "'," & _
        "C.TEL='" & Trim(txtTel.Text) & "'," & _
        "C.CHECK_TARE_WEIGHT='" & IIf(chkTareWeight.Checked, 1, 0) & "'," & _
        "C.PO_NO='" & Trim(txtPoNo.Text) & "'," & _
        "C.IS_Use_PO=" & IIf(OptPOByCustomer.Checked, 1, 0) & "," & _
        "C.UPDATE_DATE=sysdate," & _
        "C.UPDATED_BY='" & mUserName & "'" & _
        "where C.CUSTOMER_CODE='" & Trim(pk_id) & "'"
        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmMainCustomer_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
    End Sub

    Private Sub AssignValue()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        sql_str = _
        "select C.CUSTOMER_CODE,C.CUSTOMER_NAME,C.CUSTOMER_TYPE,C.IS_USE_PO,C.PO_NO," & _
        "c.CHECK_TARE_WEIGHT,C.CUSTOMER_ADDRESS,C.TEL,C.CITY,C.POSTAL_CODE,C.UPDATE_DATE,C.UPDATED_BY " & _
        "from CUSTOMER C " & _
        "where C.CUSTOMER_CODE='" & pk_id & "'"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            txtCustomerID.Text = IIf(IsDBNull(dt.Rows(i).Item("CUSTOMER_CODE")), "", dt.Rows(i).Item("CUSTOMER_CODE").ToString)
            txtCustomerName.Text = IIf(IsDBNull(dt.Rows(i).Item("CUSTOMER_NAME")), "", dt.Rows(i).Item("CUSTOMER_NAME").ToString)
            setListboxWithName(IIf(IsDBNull(dt.Rows(i).Item("CUSTOMER_TYPE")), "", dt.Rows(i).Item("CUSTOMER_TYPE").ToString), cbCustomerType)
            txtPostCode.Text = IIf(IsDBNull(dt.Rows(i).Item("postal_code")), "", dt.Rows(i).Item("postal_code").ToString)
            txtProvince.Text = IIf(IsDBNull(dt.Rows(i).Item("city")), "", dt.Rows(i).Item("city").ToString)
            txtCustomerAddr.Text = IIf(IsDBNull(dt.Rows(i).Item("CUSTOMER_ADDRESS")), "", dt.Rows(i).Item("CUSTOMER_ADDRESS").ToString)
            txtTel.Text = IIf(IsDBNull(dt.Rows(i).Item("TEL")), "", dt.Rows(i).Item("TEL").ToString)
            If IIf(IsDBNull(dt.Rows(i).Item("CHECK_TARE_WEIGHT")), "", dt.Rows(i).Item("CHECK_TARE_WEIGHT").ToString) = 1 Then
                chkTareWeight.Checked = True
            Else
                chkTareWeight.Checked = False
            End If
            If IIf(IsDBNull(dt.Rows(i).Item("IS_Use_PO")), "", dt.Rows(i).Item("IS_Use_PO").ToString) = 1 Then
                OptPOByCustomer.Checked = True
            Else
                OptPOByCustomer.Checked = False
            End If
            txtPoNo.Text = IIf(IsDBNull(dt.Rows(i).Item("PO_NO")), "", dt.Rows(i).Item("PO_NO").ToString)
            txtLastUpdateDate.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
            txtLastUpdateBy.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY"))
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

    Function assignDropDown() As Boolean
        Dim sql_str As String
        sql_str = _
        " select c.customer_type from customer c group by c.customer_type "
        assignDropDown(sql_str, "Customer_type", cbCustomerType)
        Return 0
    End Function

    Function assignDropDown(ByVal sql_str As String, ByVal colName As String, ByVal cb As System.Object) As Boolean
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Dim temCb As String
            Do While dt.Rows.Count > i
                temCb = IIf(IsDBNull(dt.Rows(i).Item(colName)), "", dt.Rows(i).Item(colName).ToString)
                If Not cb.Items.Contains(temCb) Then
                    cb.Items.Add(temCb)
                End If
                i = i + 1
            Loop
            Return True
        End If
        mDataSet = Nothing
        Return True
    End Function

    Private Sub setListboxWithName(ByVal name As String, ByVal cb As System.Object)
        Dim index As Integer = cb.FindString(name)
        If index = -1 Then
        Else
            cb.SelectedIndex = index
        End If
    End Sub

    Private Function GetNextID() As Integer
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        sql_str = _
        " select MAX((PUMP_ID)+1) as MaxID from PUMP"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
        End If
        Return 1
    End Function

    Private Sub OptPOByCustomer_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptPOByCustomer.CheckStateChanged
       checkOptPOByCustomer()
    End Sub

    Private Function checkOptPOByCustomer() As Integer
        If OptPOByCustomer.Checked = 0 Then
            txtPoNo.BackColor = Color.LightGray
            txtPoNo.Enabled = False
            txtPoNo.Text = ""
        Else
            txtPoNo.BackColor = Color.White
            txtPoNo.Enabled = True
        End If
        Return 1
    End Function

    Private Sub txtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("กรุณากรอกค่าเป็นตัวเลข", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Select
    End Sub
End Class

