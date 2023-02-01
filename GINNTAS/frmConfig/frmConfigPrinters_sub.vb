Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmConfigPrinters_sub
    Dim frm_work As Integer = 0 'Printers1=add ,2=Edit
    Dim pk_id As String = ""
    Dim RadioEnabled As String
    Dim RadioLocked As String
    Dim vFixType As String

    Private Sub frmConfigPrinters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        If frm_work = 1 Then
            Me.Text = "Printers # Add"
            GetNextID()
        ElseIf frm_work = 2 Then
            Me.Text = "Printers # Edit"
            AssignValue()
        End If
        txtLock(True)
    End Sub

    Private Sub Clear_frm()
        txtPrinterID.Text = ""
        cbPrinterName.Text = ""
        txtLocation.Text = ""
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
            If txtPrinterID.Text.Trim = "" Or cbPrinterName.Text.Trim = "" or txtLocation.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If txtPrinterID.Text.Trim = "" Or cbPrinterName.Text.Trim = "" Or txtLocation.Text.Trim = "" Then
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
        Dim sql_str As String
        sql_str = " INSERT INTO PRINTER_TAS  ( "
        sql_str = sql_str & "  PRINTER_ID "
        sql_str = sql_str & " ,PRINTER_NAME  "
        sql_str = sql_str & " ,LOCATION  "
        sql_str = sql_str & " ,UPDATED_BY  "
        sql_str = sql_str & " ,IS_ENABLED  "
        sql_str = sql_str & " )  "
        sql_str = sql_str & " VALUES ( "
        sql_str = sql_str & "'" + Trim(txtPrinterID.Text) + "'"
        sql_str = sql_str & ",'" + Trim(cbPrinterName.Text) + "'"
        sql_str = sql_str & ",'" + Trim(txtLocation.Text) + "'"
        sql_str = sql_str & ",'" + mUserName + "'"
        sql_str = sql_str & "," + If(OptUnEnbled.Checked = True, "0", "1") + ""
        sql_str = sql_str & " )  "
        If Oradb.ExeSQL(sql_str) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigPrinters_main.Show_Data()
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
        "UPDATE  PRINTER_TAS  SET  " & _
        "PRINTER_NAME='" & Trim(cbPrinterName.Text) & "'," & _
        "LOCATION='" & Trim(txtLocation.Text) & "'," & _
        "UPDATE_DATE = SYSDATE," & _
        "UPDATED_BY='" & mUserName & "'," & _
        "IS_ENABLED=" & If(OptUnEnbled.Checked = True, "0", "1") & " " & _
        "WHERE PRINTER_ID = '" & Trim(txtPrinterID.Text) & "' "
        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigPrinters_main.Show_Data()
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
        "select P.PRINTER_ID,P.PRINTER_NAME,P.IS_ENABLED,P.UPDATE_DATE,P.UPDATED_BY,P.LOCATION " & _
        "from PRINTER_TAS P " & _
        "where P.PRINTER_ID = " & pk_id

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            txtPrinterID.Text = IIf(IsDBNull(dt.Rows(i).Item("PRINTER_ID")), "", dt.Rows(i).Item("PRINTER_ID").ToString)
            cbPrinterName.Text = IIf(IsDBNull(dt.Rows(i).Item("PRINTER_NAME")), "", dt.Rows(i).Item("PRINTER_NAME").ToString)
            txtLocation.Text = IIf(IsDBNull(dt.Rows(i).Item("LOCATION")), "", dt.Rows(i).Item("LOCATION").ToString)

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

    Function CheckDataExists(ByRef pID As String) As Boolean
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        sql_str = " select CardReader_NO from CardReader  "
        sql_str = sql_str & " where   CardReader_NO = '" + pID + "' "
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

    Function assignDropDown() As Boolean
        InitialCombo()
        Return True
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
   
    Private Function GetNextID() As Integer
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        sql_str = _
        " select MAX((PRINTER_ID)+1) as MaxID from PRINTER_TAS"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            txtPrinterID.Text = IIf(IsDBNull(dt.Rows(0).Item("MaxID")), "", dt.Rows(0).Item("MaxID").ToString)
        End If
        mDataSet = Nothing
        dt = Nothing
        Return 1
    End Function

    Private Sub setListboxWithName(ByVal name As String, ByVal cb As System.Object)
        Dim index As Integer = cb.FindString(name)
        If index = -1 Then
        Else
            cb.SelectedIndex = index
        End If
    End Sub

    Private Sub InitialCombo()
        cbPrinterName.Items.Clear()
        For Each sPrinters In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            cbPrinterName.Items.Add(sPrinters)
        Next
    End Sub
End Class
