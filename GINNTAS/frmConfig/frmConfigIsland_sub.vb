Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmConfigIsland_sub
    Dim frm_work As Integer = 0 'Island1=add ,2=Edit
    Dim pk_id As String = ""
    Dim RadioEnabled As String
    Dim RadioLocked As String
    Dim vFixType As String

    Private Sub frmConfigIsland_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        If frm_work = 1 Then
            Me.Text = "Island # Add"
            GetNextID()
        ElseIf frm_work = 2 Then
            Me.Text = "Island # Edit"
            AssignValue()
        End If
        txtLock(True)
    End Sub

    Private Sub Clear_frm()
        txtIslandNo.Text = ""
        txtIslandName.Text = ""
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
            If txtIslandNo.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If txtIslandNo.Text.Trim = "" Then
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
        sql_str = " INSERT INTO ISLAND  ( "
        sql_str = sql_str & "  ISLAND_NO "
        sql_str = sql_str & " ,ISLAND_NAME  "
        sql_str = sql_str & " ,UPDATED_BY  "
        sql_str = sql_str & " ,IS_ENABLED  "
        sql_str = sql_str & " )  "
        sql_str = sql_str & " VALUES ( "
        sql_str = sql_str & "'" + Trim(txtIslandNo.Text) + "'"
        sql_str = sql_str & ",'" + Trim(txtIslandName.Text) + "'"
        sql_str = sql_str & ",'" + mUserName + "'"
        sql_str = sql_str & "," + If(OptUnEnbled.Checked = True, "0", "1") + ""
        sql_str = sql_str & " )  "
        If Oradb.ExeSQL(sql_str) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigIsland_main.Show_Data()
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
        If checkIslandNo() Then
            Dim strSQL As String = _
            "UPDATE  ISLAND  SET  " & _
            "ISLAND_NAME='" & Trim(txtIslandName.Text) & "'," & _
            "UPDATE_DATE = SYSDATE," & _
            "UPDATED_BY='" & mUserName & "'," & _
            "IS_ENABLED=" & If(OptUnEnbled.Checked = True, "0", "1") & " " & _
            "WHERE ISLAND_NO = '" & Trim(txtIslandNo.Text) & "' "

            If Oradb.ExeSQL(strSQL) Then
                MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
                Me.Close()
                setFrmWork(0)
                frmConfigIsland_main.Show_Data()
            Else
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            End If
        End If
    End Sub

    Private Sub AssignValue()

        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        sql_str = ""
        sql_str = sql_str & " select I.ISLAND_NO,I.ISLAND_NAME,I.IS_ENABLED,I.UPDATE_DATE,I.UPDATED_BY "
        sql_str = sql_str & " from ISLAND I "
        sql_str = sql_str & " where I.ISLAND_NO = '" + pk_id + "'"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            txtIslandNo.Text = IIf(IsDBNull(dt.Rows(i).Item("ISLAND_NO")), "", dt.Rows(i).Item("ISLAND_NO").ToString)
            txtIslandName.Text = IIf(IsDBNull(dt.Rows(i).Item("ISLAND_NAME")), "", dt.Rows(i).Item("ISLAND_NAME").ToString)
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
                mDataSet = Nothing
                Return False
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
        " select MAX((ISLAND_NO)+1) as MaxID from ISLAND"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            txtIslandNo.Text = IIf(IsDBNull(dt.Rows(0).Item("MaxID")), "", dt.Rows(0).Item("MaxID").ToString)
        End If
        mDataSet = Nothing
        Return 1
    End Function

    Private Function checkIslandNo() As Boolean
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = _
        "select I.ISLAND_NO " & _
        "from ISLAND I " & _
        "order by I.ISLAND_NO"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            Do While dt.Rows.Count > i
                If txtIslandNo.Text = IIf(IsDBNull(dt.Rows(i).Item("ISLAND_NO")), "", dt.Rows(i).Item("ISLAND_NO").ToString) Then
                    mDataSet = Nothing
                    Return True
                End If
                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
        MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "เนื่องจากไม่พบ Island No. " & txtIslandNo.Text & " อยู่ในฐานข้อมูล", "System TAS")
        Return False
    End Function

    Private Sub txtIslandNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIslandNo.KeyPress
        If txtIslandNo.Text.Length > 1 Then
            e.Handled = True
            Return
        End If
        e.Handled = CurrencyOnly(txtIslandNo, e.KeyChar)
    End Sub

End Class
