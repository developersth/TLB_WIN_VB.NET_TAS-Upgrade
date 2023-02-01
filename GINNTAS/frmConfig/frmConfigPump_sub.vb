Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmConfigPump_sub
    Dim frm_work As Integer = 0
    Dim pk_id As String = ""

    Private Sub frmConfigPump_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        If frm_work = 1 Then
            Me.Text = "Pump # Add"
            GetNextID()
        ElseIf frm_work = 2 Then
            Me.Text = "Pump # Edit"
            AssignValue()
        End If
        txtLock(True)
    End Sub

    Private Sub Clear_frm()
        textPumpID.Text = ""
        textPumpName.Text = ""
        cbProduct.Items.Clear()
        cbPumpMapping.Items.Clear()
        txtPumpWoring.Text = ""
        txtPumpAlram.Text = ""
        OptPumType1.Checked = True
        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""
        OptEnabled.Checked = True
    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        textPumpID.Enabled = Not iBoo
        txtLastUpdateDate.Enabled = Not iBoo
        txtLastUpdateBy.Enabled = Not iBoo
        If iBoo Then
            textPumpID.BackColor = Color.LightGray
            txtLastUpdateDate.BackColor = Color.LightGray
            txtLastUpdateBy.BackColor = Color.LightGray

        Else
            textPumpID.BackColor = Color.White
            txtLastUpdateDate.BackColor = Color.White
            txtLastUpdateBy.BackColor = Color.White
        End If
    End Sub

#Region "Menu Event"
    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave
        If frm_work = 1 Then 'Add
            If textPumpID.Text.Trim = "" Or textPumpName.Text.Trim = "" Or cbProduct.Text.Trim = "" Or cbPumpMapping.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If textPumpID.Text.Trim = "" Or textPumpName.Text.Trim = "" Or cbProduct.Text.Trim = "" Or cbPumpMapping.Text.Trim = "" Then
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
        Dim strPumpMapping = Split(cbPumpMapping.Text, "-")
        Dim sType As String = ""
        If OptPumType1.Checked = True Then
            sType = "U"
        ElseIf OptPumType2.Checked = True Then
            sType = "L"
        ElseIf OptPumType3.Checked = True Then
            sType = "A"
        End If

        Dim strSQL As String
        strSQL = _
        "insert into PUMP(" & _
        "PUMP_ID,PUMP_NAME," & _
        "MAPPING_ID,PRODUCT_ID," & _
        "PUMP_TYPE,IS_ENABLED," & _
        "CREATION_DATE,CREATED_BY," & _
        "UPDATE_DATE,UPDATED_BY) " & _
        "values(" & _
        textPumpID.Text & ",'" & Trim(textPumpName.Text) & "'," & _
        strPumpMapping(0) & ",'" & Trim(cbProduct.Text) & "'," & _
        "'" & sType & "'," & IIf(OptUnEnbled.Checked = True, 1, 0) & "," & _
        "sysdate,'" & mUserName & "'," & _
        "sysdate,'" & mUserName & "')"

        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigPump_main.Show_Data()
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
        Dim strPumpMapping = Split(cbPumpMapping.Text, "-")
        Dim sType As String = ""
        If OptPumType1.Checked = True Then
            sType = "U"
        ElseIf OptPumType2.Checked = True Then
            sType = "L"
        ElseIf OptPumType3.Checked = True Then
            sType = "A"
        End If
        Dim strSQL As String = _
        "update PUMP P set " & _
        "P.PUMP_NAME='" & Trim(textPumpName.Text) & "'," & _
        "P.MAPPING_ID=" & strPumpMapping(0) & "," & _
        "P.PRODUCT_ID='" & Trim(cbProduct.Text) & "'," & _
        "P.PUMP_TYPE='" & sType & "'," & _
        "P.IS_ENABLED=" & IIf(OptUnEnbled.Checked = True, 1, 0) & "," & _
        "P.UPDATE_DATE=sysdate," & _
        "P.UPDATED_BY='" & mUserName & "'" & _
        "where P.PUMP_ID=" & Val(textPumpID.Text)
        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigPump_main.Show_Data()
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
        "select M.PUMP_ID,M.PUMP_NAME,M.MAPPING_ID,M.PRODUCT_ID,M.MAP_NAME," & _
        "M.PUMP_TYPE,M.IS_ENABLED,M.STATUS_RUN,M.STATUS_ALARM," & _
        "M.CONTROL_START,M.CONTROL_STOP," & _
        "M.UPDATE_DATE,M.UPDATED_BY " & _
        "from VIEW_MAP_PUMP M " & _
        "where M.PUMP_ID = " & pk_id

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            textPumpID.Text = IIf(IsDBNull(dt.Rows(i).Item("PUMP_ID")), "", dt.Rows(i).Item("PUMP_ID").ToString)
            textPumpName.Text = IIf(IsDBNull(dt.Rows(i).Item("PUMP_NAME")), "", dt.Rows(i).Item("PUMP_NAME").ToString)
            Dim strCbProduct As String = IIf(IsDBNull(dt.Rows(i).Item("PRODUCT_ID")), "", dt.Rows(i).Item("PRODUCT_ID").ToString)
            setListboxWithName(strCbProduct, cbProduct)
            Dim strCbPumpMapping As String = IIf(IsDBNull(dt.Rows(i).Item("MAP_NAME")), "", dt.Rows(i).Item("MAP_NAME").ToString)
            setListboxWithName(strCbPumpMapping, cbPumpMapping)

            Select Case IIf(IsDBNull(dt.Rows(i).Item("PUMP_TYPE")), "", dt.Rows(i).Item("PUMP_TYPE").ToString)
                Case "U"
                    OptPumType1.Checked = True
                Case "L"
                    OptPumType2.Checked = True
                Case "A"
                    OptPumType3.Checked = True
                Case Else
            End Select

            If IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", dt.Rows(i).Item("IS_ENABLED").ToString) = 0 Then
                OptUnEnbled.Checked = True
            ElseIf IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", dt.Rows(i).Item("IS_ENABLED").ToString) = 1 Then
                OptEnabled.Checked = True
            Else
                OptUnEnbled.Checked = True
            End If

            txtPumpWoring.Text = IIf(IsDBNull(dt.Rows(i).Item("STATUS_RUN")), "", IIf(dt.Rows(i).Item("STATUS_RUN").ToString = 1, "กำลังทำงาน", "หยุดทำงาน"))
            txtPumpAlram.Text = IIf(IsDBNull(dt.Rows(i).Item("STATUS_ALARM")), "", IIf(dt.Rows(i).Item("STATUS_ALARM").ToString = 1, "มีสัญญาณขัดข้อง", "ไม่มีสัญญาณขัดข้อง"))
            txtLastUpdateDate.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
            txtLastUpdateBy.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
        Else
        End If
        mDataSet = Nothing
        dt = Nothing
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
        "select P.BASE_PRODUCT_ID " & _
        "from BASE_PRODUCT P " & _
        "order by P.BASE_PRODUCT_ID"
        assignDropDown(sql_str, "BASE_PRODUCT_ID", cbProduct)

        sql_str = _
        "select P.PUMP_ID||' - '||P.MAP_NAME as MAP_NAME " & _
        "from PUMP_MAPPING P " & _
        "order by P.PUMP_ID"
        assignDropDown(sql_str, "MAP_NAME", cbPumpMapping)
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
            'Return True
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
            textPumpID.Text = IIf(IsDBNull(dt.Rows(0).Item("MaxID")), "", dt.Rows(0).Item("MaxID").ToString)
        End If
        Return 1
    End Function

End Class

