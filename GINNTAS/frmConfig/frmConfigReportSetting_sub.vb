Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmConfigReportSetting_sub
    Dim frm_work As Integer = 0 '1=add ,2=Edit
    Dim pk_id As String = ""

    Private Sub frmConfigReportSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        If frm_work = 1 Then
            Me.Text = "ReportSetting # Add"
            GetNextID()
        ElseIf frm_work = 2 Then
            Me.Text = "ReportSetting # Edit"
            AssignValue()
        End If
        txtLock(True)
    End Sub

    Private Sub Clear_frm()
        dtpTimePrint.Value = Date.Now
        cbPrinter.Text = ""
        cbPrinter.Items.Clear()
        txtReportID.Text = ""
        txtReportName.Text = ""
        txtRepotPath.Text = ""
        cbReportType.Text = ""
        cbReportType.Items.Clear()
        cbPrinter.Items.Clear()
        OptDoNotPrint.Checked = True
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
            If txtReportID.Text.Trim = "" Or txtReportName.Text.Trim = "" Or cbHeadderId.Text.Trim = "" Or txtRepotPath.Text.Trim = "" Or cbPrinterId.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If txtReportID.Text.Trim = "" Or txtReportName.Text.Trim = "" Or cbHeadderId.Text.Trim = "" Or txtRepotPath.Text.Trim = "" Or cbPrinterId.Text.Trim = "" Then
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
        cbPrinterId.SelectedIndex = cbPrinter.FindString(cbPrinter.Text)
        cbHeadderId.SelectedIndex = cbReportType.FindString(cbReportType.Text)
        Dim strsql As String
        strsql = _
        "insert into REPORT_SETTING(" & _
        "REPORT_ID,REPORT_NAME," & _
        "HEADER_ID,REPORT_PATH," & _
        "PRINTER_ID," & _
        "PRINT_TIME,STATUS_PRINT," & _
        "IS_ENABLED,CREATION_DATE," & _
        "CREATED_BY,UPDATE_DATE," & _
        "UPDATED_BY) " & _
        "values(" & _
        Val(txtReportID.Text) & ",'" & Trim(txtReportName.Text) & "'," & _
        cbHeadderId.Text & ",'" & Trim(txtRepotPath.Text) & "'," & _
        cbPrinterId.Text & "," & _
        "to_date('" & Format(Date.Today.ToString(" d/MM/yyyy HH:mm:ss")) & "','dd/mm/yyyy hh24:mi:ss')," & IIf(OptPrint.Checked = True, 1, 0) & "," & _
        IIf(OptEnabled.Checked = True, 1, 0) & ",sysdate," & _
        "'" & mUserName & "',sysdate," & _
        "'" & mUserName & "')"
        MessageBox.Show(strsql)
        If Oradb.ExeSQL(strsql) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigReportSetting_main.Show_Data()
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
        cbPrinterId.SelectedIndex = cbPrinter.FindString(cbPrinter.Text)
        cbHeadderId.SelectedIndex = cbReportType.FindString(cbReportType.Text)
        Dim strSQL As String = _
        "update REPORT_SETTING R set " & _
        "R.REPORT_NAME='" & Trim(txtReportName.Text) & "'," & _
        "R.HEADER_ID=" & cbHeadderId.Text & "," & _
        "R.REPORT_PATH='" & Trim(txtRepotPath.Text) & "'," & _
        "R.PRINTER_ID=" & cbPrinterId.Text & "," & _
        "R.PRINT_TIME=to_date('" & Format(dtpTimePrint.Value, "dd/MM/yyyy HH:mm:ss") & "','dd/mm/yyyy hh24:mi:ss')," & _
        "R.STATUS_PRINT=" & IIf(OptPrint.Checked = True, 1, 0) & "," & _
        "R.IS_ENABLED=" & IIf(OptEnabled.Checked = True, 1, 0) & "," & _
        "R.UPDATE_DATE=sysdate," & _
        "R.UPDATED_BY='" & mUserName & "'" & _
        "where R.REPORT_ID=" & Val(txtReportID.Text)
        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigReportSetting_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
    End Sub

    Private Sub AssignValue()

        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Try
            sql_str =
                "select R.REPORT_ID,R.REPORT_NAME,R.HEADER_ID,R.REPORT_PATH,R.PRINTER_ID,H.HEADER_NAME,P.PRINTER_NAME," &
                "R.PRINT_TIME,R.STATUS_PRINT,R.IS_ENABLED,R.UPDATE_DATE,R.UPDATED_BY,R.J_COMPUTER " &
                "from REPORT_SETTING R, REPORT_HEADERS H,PRINTER_TAS P " &
                "where R.HEADER_ID=H.HEADER_ID  and R.PRINTER_ID = P.PRINTER_ID   and R.REPORT_ID=" & pk_id

            If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                i = 0
                txtReportID.Text = pk_id

                txtReportName.Text = dt.Rows(i).Item("REPORT_NAME").ToString()
                Dim strcbReportType As String = IIf(IsDBNull(dt.Rows(i).Item("HEADER_NAME")), "", dt.Rows(i).Item("HEADER_NAME").ToString())
                setListboxWithName(strcbReportType, cbReportType)
                Dim strCbPrinter As String = IIf(IsDBNull(dt.Rows(i).Item("PRINTER_NAME")), "", dt.Rows(i).Item("PRINTER_NAME").ToString())
                setListboxWithName(strCbPrinter, cbPrinter)
                    txtRepotPath.Text = IIf(IsDBNull(dt.Rows(i).Item("REPORT_PATH")), "", dt.Rows(i).Item("REPORT_PATH").ToString)
                    If IIf(IsDBNull(dt.Rows(i).Item("STATUS_PRINT")), "", dt.Rows(i).Item("STATUS_PRINT").ToString) = 0 Then
                        OptDoNotPrint.Checked = True
                    Else
                        OptPrint.Checked = True
                    End If

                    If IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", dt.Rows(i).Item("IS_ENABLED").ToString) = 0 Then
                        OptUnEnbled.Checked = True
                    Else
                        OptEnabled.Checked = True
                    End If

                    txtLastUpdateDate.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
                    txtLastUpdateBy.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
                Else
                End If

            cbPrinterId.SelectedIndex = cbPrinter.FindString(cbPrinter.Text)
            cbHeadderId.SelectedIndex = cbReportType.FindString(cbReportType.Text)
            mDataSet = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

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
        "select H.HEADER_ID,H.HEADER_NAME " & _
        "from REPORT_HEADERS H " & _
        "order by H.HEADER_ID"
        assignDropDown(sql_str, "HEADER_NAME", cbReportType)
        assignDropDown(sql_str, "HEADER_ID", cbHeadderId)
        sql_str = _
        "select P.PRINTER_ID,P.PRINTER_NAME " & _
        "from PRINTER_TAS P " & _
        "order by P.PRINTER_ID"
        assignDropDown(sql_str, "PRINTER_NAME", cbPrinter)
        assignDropDown(sql_str, "PRINTER_ID", cbPrinterId)
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
        dt = Nothing
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
        sql_str = " select MAX((REPORT_ID)+1) as MaxID from REPORT_SETTING"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            txtReportID.Text = IIf(IsDBNull(dt.Rows(0).Item("MaxID")), "", dt.Rows(0).Item("MaxID").ToString)
        End If
        mDataSet = Nothing
        dt = Nothing
        Return 1
    End Function

    Private Sub cmdOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpenFile.Click
        Dim OpenFileDialog1 As New Microsoft.Win32.OpenFileDialog
        OpenFileDialog1.Title = "Open File..."
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Filter = "Report File|*.rpt"
        OpenFileDialog1.ShowDialog()
        txtRepotPath.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)

    End Sub
End Class

