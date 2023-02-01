Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmUtlTasConfig_sub
    Dim frm_work As Integer = 0 'Printers1=add ,2=Edit
    Dim pk_id As String = ""
    Dim pk_value As String = ""
    Dim RadioEnabled As String
    Dim RadioLocked As String
    Dim vFixType As String
    Dim Config_data As String

    Private Sub frmUtlTasConfig_sub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        AssignValue()
        If pk_value = "False" Or pk_value = "True" Then
            GroupBox1.Visible = True
            txtValue.Visible = False
        Else
            txtValue.Visible = True
        End If
        If frm_work = 1 Then
            Me.Text = "TasConfig # Add"
            GetNextID()
        ElseIf frm_work = 2 Then
            Me.Text = "TasConfig # Edit"

        End If
        txtLock(True)
    End Sub

    Private Sub Clear_frm()
        txtCfgID.Text = ""
        txtType.Text = ""
        txtDescription.Text = ""
        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""
        OptEnabled.Checked = True
    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        txtLastUpdateDate.Enabled = Not iBoo
        txtLastUpdateBy.Enabled = Not iBoo

        If iBoo Then
            txtLastUpdateDate.BackColor = Color.LightGray
            txtLastUpdateBy.BackColor = Color.LightGray
        Else
            txtLastUpdateDate.BackColor = Color.White
            txtLastUpdateBy.BackColor = Color.White
        End If
    End Sub

#Region "Menu Event"
    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave
        If frm_work = 1 Then 'Add
            If txtCfgID.Text.Trim = "" Or txtType.Text.Trim = "" Or txtDescription.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If txtCfgID.Text.Trim = "" Or txtType.Text.Trim = "" Or txtDescription.Text.Trim = "" Then
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
        Dim sql_str As String = _
              " update TAS.TAS_CONFIG set " & _
                " CONFIG_DATA='" & Trim(Config_data) & "'," & _
                " UNIT_DESC ='" & Trim(txtUnit.Text) & "'," & _
                " DESCRIPTION ='" & Trim(txtDescription.Text) & "'," & _
                " VARIABLE_TYPE ='" & Trim(txtType.Text) & "'," & _
                " UPDATE_DATE=sysdate," & _
                " UPDATED_BY='" & mUserName & "' " & _
                " where CONFIG_ID='" & Trim(pk_id) & "'"
        If Oradb.ExeSQL(sql_str) Then
            'Call AddJournal(0, frmUtlTasConfig_main.FormScreenID, 100, mUserName, 111201, Trim(txtPrinterID.Text), Trim(cbPrinterName.Text))
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmUtlTasConfig_main.Show_Data()
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
    Public Sub setPkValue(ByVal Value As String)
        Me.pk_value = Value
    End Sub

    Private Sub Edit()
        If pk_value = "False" Or pk_value = "True" Then
            GroupBox1.Visible = True
            txtValue.Visible = False
            If OptEnabled.Checked = True Then
                Config_data = "1"
            Else
                Config_data = "0"
            End If
        Else
            Config_data = txtValue.Text
            txtValue.Visible = True
        End If
        Dim strSQL As String = _
         " update TAS.TAS_CONFIG set " & _
                " CONFIG_DATA='" & Trim(Config_data) & "'," & _
                " UNIT_DESC ='" & Trim(txtUnit.Text) & "'," & _
                " DESCRIPTION ='" & Trim(txtDescription.Text) & "'," & _
                " VARIABLE_TYPE ='" & Trim(txtType.Text) & "'," & _
                " UPDATE_DATE=sysdate," & _
                " UPDATED_BY='" & mUserName & "' " & _
                " where CONFIG_ID='" & Trim(pk_id) & "'"
        If Oradb.ExeSQL(strSQL) Then
            'Call AddJournal(0, frmUtlTasConfig_main.FormScreenID, 100, mUserName, 111202, Trim(txtPrinterID.Text), Trim(txtType.Text))


            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmUtlTasConfig_main.Show_Data()
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
                " select  t.CONFIG_ID,t.DESCRIPTION,t.CONFIG_DATA," & _
                " t.VARIABLE_TYPE,t. UNIT_DESC,t.UPDATE_DATE,t.UPDATED_BY " & _
                " From TAS.TAS_CONFIG  t  " & _
                " where t.CONFIG_ID = " & pk_id & " "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            txtCfgID.Text = IIf(IsDBNull(dt.Rows(i).Item("CONFIG_ID")), "", dt.Rows(i).Item("CONFIG_ID").ToString)
            txtType.Text = IIf(IsDBNull(dt.Rows(i).Item("VARIABLE_TYPE")), "", dt.Rows(i).Item("VARIABLE_TYPE").ToString)
            txtDescription.Text = IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION").ToString)
            txtUnit.Text = IIf(IsDBNull(dt.Rows(i).Item("UNIT_DESC")), "", dt.Rows(i).Item("UNIT_DESC").ToString)
            txtValue.Text = IIf(IsDBNull(dt.Rows(i).Item("CONFIG_DATA")), "", dt.Rows(i).Item("CONFIG_DATA").ToString)
            If dt.Rows(i).Item("VARIABLE_TYPE").ToString = "BOOLEAN" Then
                If IIf(IsDBNull(dt.Rows(i).Item("CONFIG_DATA")), "", dt.Rows(i).Item("CONFIG_DATA").ToString) = "True" Then
                    OptEnabled.Checked = True
                Else
                    OptUnEnbled.Checked = False
                End If
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

    Function CheckDataExists(ByRef pID As String) As Boolean
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        sql_str = " select CONFIG_ID from TAS.TAS_CONFIG  "
        sql_str = sql_str & " where   CONFIG_ID = '" + pID + "' "
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Do While dt.Rows.Count > i
                Return False
            Loop
            Return True
        End If
        mDataSet = Nothing
        Return True
    End Function
    Private Function GetNextID() As Integer
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        sql_str = _
        " select MAX((PRINTER_ID)+1) as MaxID from PRINTER_TAS"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            txtCfgID.Text = IIf(IsDBNull(dt.Rows(0).Item("MaxID")), "", dt.Rows(0).Item("MaxID").ToString)
        End If
        Return 1
    End Function

    Private Sub setListboxWithName(ByVal name As String, ByVal cb As System.Object)
        Dim index As Integer = cb.FindString(name)
        If index = -1 Then
        Else
            cb.SelectedIndex = index
        End If
    End Sub


End Class
