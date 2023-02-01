Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmMainShipTo_sub
    Dim frm_work As Integer = 0 'frmMainShipTo=add ,2=Edit
    Dim pk_id As String = ""
    Dim chipToCode As String = ""

    Private Sub frmMainShipTo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        If frm_work = 1 Then
            Me.Text = "ShipTo # Add"
        ElseIf frm_work = 2 Then
            Me.Text = "ShipTo # Edit"
            AssignValue()
        End If
        txtLock(True)
    End Sub

    Private Sub Clear_frm()
        CmbDistribution.Items.Clear()
        txtShiptoID.Text = ""
        txtShiptoName.Text = ""
        txtPoNo.Text = ""
        txtContract.Text = ""
        txtIndDep.Text = ""
        txtToProject.Text = ""
        txtProvince.Text = ""
        txtPostCode.Text = ""
        txtTel.Text = ""
        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""
        OptIsEnabled.Checked = True
    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        If frm_work = 2 Then
            txtShiptoID.Enabled = Not iBoo
            txtLastUpdateDate.Enabled = Not iBoo
            txtLastUpdateBy.Enabled = Not iBoo
            If iBoo Then
                txtShiptoID.BackColor = Color.LightGray
                txtLastUpdateDate.BackColor = Color.LightGray
                txtLastUpdateBy.BackColor = Color.LightGray
            Else
                txtShiptoID.BackColor = Color.White
                txtLastUpdateDate.BackColor = Color.White
                txtLastUpdateBy.BackColor = Color.White
            End If
        End If
    End Sub

#Region "Menu Event"
    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave
        If frm_work = 1 Then 'Add
            If cmbCusShipTo.Text.Trim = "" Or txtShiptoID.Text.Trim = "" Or txtShiptoName.Text.Trim = "" Or txtPoNo.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If cmbCusShipTo.Text.Trim = "" Or txtShiptoID.Text.Trim = "" Or txtShiptoName.Text.Trim = "" Or txtPoNo.Text.Trim = "" Then
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
    End Sub

#End Region

    Private Sub Save()
        Dim arrCbCusShipTo = Split(cmbCusShipTo.Text, "-")
        Dim strCbCusShipTo = arrCbCusShipTo(0)
        Dim strSQL As String

        strSQL = _
        "insert into SHIP_TO(" & _
        "CUSTOMER_CODE,SHIPTO_CODE,SHIPTO_NAME," & _
        "SHIPTO_PONO,SHIPTO_CONTRACT,SHIPTO_INDDEP,SHIPTO_TOPROJECT," & _
        "CITY,POSTAL_CODE,GOV_PROJECT," & _
        "TEL,CREATION_DATE,DISTRIBUTION_CHANEL," & _
        "CREATED_BY,UPDATE_DATE," & _
        "UPDATED_BY) " & _
        "values(" & _
        "'" & Trim(strCbCusShipTo) & "','" & Trim(txtShiptoID.Text) & "','" & Trim(txtShiptoName.Text) & "'," & _
        "'" & Trim(txtPoNo.Text) & "','" & Trim(txtContract.Text) & "','" & Trim(txtIndDep.Text) & "','" & Trim(txtToProject.Text) & "'," & _
        "'" & Trim(txtProvince.Text) & "','" & txtPostCode.Text & "'," & IIf(OptIsEnabled.Checked = True, 1, 0) & " ," & _
        "'" & txtTel.Text & "',sysdate," & IIf(CmbDistribution.Text = "LOCAL", 0, 1) & " ," & _
        "'" & mUserName & "',sysdate," & _
        "'" & mUserName & "')"

        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmMainShipTo_main.Show_Data(frmMainShipTo_main.cmbListCus.Text)
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

    Public Sub setChipToCode(ByVal newchipToCode As String)
        Me.chipToCode = newchipToCode
    End Sub
    Private Sub Edit()
        Dim arrCbCusShipTo = Split(cmbCusShipTo.Text, "-")
        Dim strCbCusShipTo = arrCbCusShipTo(0)

        Dim strSQL As String = _
        "update SHIP_TO C set " & _
        "C.SHIPTO_NAME='" & Trim(txtShiptoName.Text) & "'," & _
        "C.SHIPTO_PONO='" & Trim(txtPoNo.Text) & "'," & _
        "C.SHIPTO_CONTRACT='" & Trim(txtContract.Text) & "'," & _
        "C.SHIPTO_INDDEP='" & Trim(txtIndDep.Text) & "'," & _
        "C.SHIPTO_TOPROJECT='" & Trim(txtToProject.Text) & "'," & _
        "C.CITY='" & txtProvince.Text & "',POSTAL_CODE='" & txtPostCode.Text & "'," & _
        "C.TEL='" & Trim(txtTel.Text) & "'," & _
        "C.GOV_PROJECT=" & IIf(OptIsEnabled.Checked = True, 1, 0) & "," & _
        "C.DISTRIBUTION_CHANEL=" & IIf(CmbDistribution.Text = "LOCAL", 0, 1) & "," & _
        "C.UPDATE_DATE=sysdate," & _
        "C.UPDATED_BY='" & mUserName & "'" & _
        "where C.CUSTOMER_CODE='" & Trim(strCbCusShipTo) & "'" & _
        " and SHIPTO_CODE ='" & Trim(txtShiptoID.Text) & "' "

        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmMainShipTo_main.Show_Data(frmMainShipTo_main.cmbListCus.Text)
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
        "select t.CUSTOMER_CODE ||'--'|| t.CUSTOMER_NAME  AS CUSTOMER,C.CUSTOMER_CODE,SHIPTO_CODE,C.SHIPTO_NAME,C.SHIPTO_PONO," & _
        "C.SHIPTO_CONTRACT,C.SHIPTO_INDDEP,SHIPTO_TOPROJECT,C.TEL,C.CITY,C.POSTAL_CODE,C.UPDATE_DATE,C.UPDATED_BY,C.GOV_PROJECT " & _
        " ,C.DISTRIBUTION_CHANEL  from tas.SHIP_TO C , tas.customer t " & _
        " where c.customer_code = t.customer_code  " & _
        " and C.CUSTOMER_CODE='" & pk_id & "'" & _
        "and  C.SHIPTO_CODE = '" & chipToCode & "'"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            setListboxWithName(IIf(IsDBNull(dt.Rows(i).Item("CUSTOMER")), "", dt.Rows(i).Item("CUSTOMER").ToString), cmbCusShipTo)
            txtShiptoID.Text = IIf(IsDBNull(dt.Rows(i).Item("SHIPTO_CODE")), "", dt.Rows(i).Item("SHIPTO_CODE").ToString)
            txtShiptoName.Text = IIf(IsDBNull(dt.Rows(i).Item("SHIPTO_NAME")), "", dt.Rows(i).Item("SHIPTO_NAME").ToString)
            txtPoNo.Text = IIf(IsDBNull(dt.Rows(i).Item("SHIPTO_PONO")), "", dt.Rows(i).Item("SHIPTO_PONO").ToString)
            txtIndDep.Text = IIf(IsDBNull(dt.Rows(i).Item("SHIPTO_INDDEP")), "", dt.Rows(i).Item("SHIPTO_INDDEP").ToString)
            txtToProject.Text = IIf(IsDBNull(dt.Rows(i).Item("SHIPTO_TOPROJECT")), "", dt.Rows(i).Item("SHIPTO_TOPROJECT").ToString)
            txtContract.Text = IIf(IsDBNull(dt.Rows(i).Item("SHIPTO_CONTRACT")), "", dt.Rows(i).Item("SHIPTO_CONTRACT").ToString)
            txtPostCode.Text = IIf(IsDBNull(dt.Rows(i).Item("postal_code")), "", dt.Rows(i).Item("postal_code").ToString)
            txtProvince.Text = IIf(IsDBNull(dt.Rows(i).Item("city")), "", dt.Rows(i).Item("city").ToString)
            txtTel.Text = IIf(IsDBNull(dt.Rows(i).Item("TEL")), "", dt.Rows(i).Item("TEL").ToString)
            setListboxWithName(IIf(IsDBNull(dt.Rows(i).Item("DISTRIBUTION_CHANEL")), "", IIf(dt.Rows(i).Item("DISTRIBUTION_CHANEL") = 1, "EXPORT", "LOCAL")), CmbDistribution)
            If IIf(IsDBNull(dt.Rows(i).Item("GOV_PROJECT")), "", dt.Rows(i).Item("GOV_PROJECT").ToString) = 1 Then
                OptUnEnabled.Checked = True
            Else
                OptIsEnabled.Checked = True
            End If
            txtLastUpdateDate.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
            txtLastUpdateBy.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
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
        CmbDistribution.Items.Add("LOCAL")
        CmbDistribution.Items.Add("EXPORT")
        CmbDistribution.SelectedIndex = 0

        Dim sql_str As String
        sql_str = _
        " select c.customer_code ,c.customer_name , " & _
        " c.customer_code ||'--'||c.customer_name as cutomer " & _
        "  from tas.customer  c   order by c.customer_code"

        assignDropDown(sql_str, "cutomer", cmbCusShipTo)
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


    Private Sub cmdSearch_Click(sender As System.Object, e As System.EventArgs) Handles cmdSearch.Click
        dfindIncombo.Show()
        dfindIncombo.FindData(9, cmbCusShipTo)
    End Sub

    Private Sub txtPostCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPostCode.KeyPress
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



