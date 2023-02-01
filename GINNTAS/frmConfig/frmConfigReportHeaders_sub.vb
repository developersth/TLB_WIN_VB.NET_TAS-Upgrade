Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmConfigReportHeaders_sub
    Dim frm_work As Integer = 0
    Dim pk_id As String = ""

    Private Sub frmConfigReportHeaders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        If frm_work = 1 Then
            Me.Text = "ReportHeaders # Add"
            GetNextID()
        ElseIf frm_work = 2 Then
            Me.Text = "ReportHeaders # Edit"
            AssignValue()
        End If
        txtLock(True)
    End Sub

    Private Sub Clear_frm()
        txtReportID.Text = ""
        txtReportName.Text = ""
        cbReportType.Items.Clear()
        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""
        OptEnabled.Checked = True
    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        txtReportID.Enabled = Not iBoo
        txtLastUpdateDate.Enabled = Not iBoo
        txtLastUpdateBy.Enabled = Not iBoo

        If iBoo Then
            txtReportID.BackColor = Color.LightGray
            txtLastUpdateDate.BackColor = Color.LightGray
            txtLastUpdateBy.BackColor = Color.LightGray

        Else
            txtReportID.BackColor = Color.White
            txtLastUpdateDate.BackColor = Color.White
            txtLastUpdateBy.BackColor = Color.White
        End If
    End Sub

#Region "Menu Event"
    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave
        If frm_work = 1 Then 'Add
            If txtReportID.Text.Trim = "" Or txtReportName.Text.Trim = "" Or cbReportType.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If txtReportID.Text.Trim = "" Or txtReportName.Text.Trim = "" Or cbReportType.Text.Trim = "" Then
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
        cbReportTypeStatus.SelectedIndex = cbReportType.FindString(cbReportType.Text)
        Dim strSQL As String

        strSQL = _
        "insert into REPORT_HEADERS(" & _
        "HEADER_ID,HEADER_NAME," & _
        "REPORT_TYPE," & _
        "IS_ENABLED,CREATION_DATE," & _
        "CREATED_BY,UPDATE_DATE," & _
        "UPDATED_BY) " & _
        "values(" & _
        Val(txtReportID.Text) & ",'" & Trim(txtReportName.Text) & "'," & _
        "'" & cbReportTypeStatus.Text & "'," & _
        IIf(OptEnabled.Checked = True, 1, 0) & ",sysdate," & _
        "'" & mUserName & "',sysdate," & _
        "'" & mUserName & "')"

        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigReportHeaders_main.Show_Data()
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
        cbReportTypeStatus.SelectedIndex = cbReportType.FindString(cbReportType.Text)
        Dim strSQL As String = _
        "update REPORT_HEADERS R set " & _
        "R.HEADER_NAME='" & Trim(txtReportName.Text) & "'," & _
        "R.REPORT_TYPE='" & cbReportTypeStatus.Text & "'," & _
        "R.IS_ENABLED=" & IIf(OptEnabled.Checked = True, 1, 0) & "," & _
        "R.UPDATE_DATE=sysdate," & _
        "R.UPDATED_BY='" & mUserName & "'" & _
        "where R.HEADER_ID=" & Val(txtReportID.Text)
        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigReportHeaders_main.Show_Data()
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
        "select R.HEADER_ID,R.HEADER_NAME,R.REPORT_TYPE,R.IS_ENABLED," & _
        "R.UPDATE_DATE,R.UPDATED_BY,R.J_COMPUTER " & _
        "from REPORT_HEADERS R " & _
        "where R.HEADER_ID=" & pk_id

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            txtReportID.Text = IIf(IsDBNull(dt.Rows(i).Item("HEADER_ID")), "", dt.Rows(i).Item("HEADER_ID").ToString)
            txtReportName.Text = IIf(IsDBNull(dt.Rows(i).Item("HEADER_NAME")), "", dt.Rows(i).Item("HEADER_NAME").ToString)
            Dim strCbReportType As String = IIf(IsDBNull(dt.Rows(i).Item("REPORT_TYPE")), "", dt.Rows(i).Item("REPORT_TYPE").ToString)
            cbReportType.SelectedIndex = cbReportTypeStatus.FindString(strCbReportType)
            If IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", dt.Rows(i).Item("IS_ENABLED").ToString) = 0 Then
                OptUnEnbled.Checked = True
            ElseIf IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", dt.Rows(i).Item("IS_ENABLED").ToString) = 1 Then
                OptEnabled.Checked = True
            Else
                OptUnEnbled.Checked = True
            End If
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
        "select S.STATUS_VARCHAR,S.DESCRIPTION " & _
        "from STATUS_DESC S " & _
        "where S.T_NAME='REPORT_HEADERS' " & _
        "and S.COLUMNS_NAME='REPORT_TYPE' " & _
        "order by S.STATUS_VARCHAR"
        assignDropDown(sql_str, "DESCRIPTION", cbReportType)
        assignDropDown(sql_str, "STATUS_VARCHAR", cbReportTypeStatus)

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
        " select MAX((HEADER_ID)+1) as MaxID from REPORT_HEADERS"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            txtReportID.Text = IIf(IsDBNull(dt.Rows(0).Item("MaxID")), "", dt.Rows(0).Item("MaxID").ToString)
        End If
        mDataSet = Nothing
        dt = Nothing
        Return 1
    End Function
End Class

