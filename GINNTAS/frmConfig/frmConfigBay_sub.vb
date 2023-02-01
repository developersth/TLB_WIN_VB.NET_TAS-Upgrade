Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmConfigBay_sub
    Dim frm_work As Integer = 0 '1=add ,2=Edit
    Dim pk_id As String = ""
    Dim RadioEnabled As String
    Dim RadioActive As String

    Private Sub frmConfigBay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDownIsland()
        If frm_work = 1 Then
            Me.Text = "BAY # Add"
        ElseIf frm_work = 2 Then
            Me.Text = "BAY # Edit"
            AssignValue()
        End If
        txtLock(True)
        checkQuota()
    End Sub

    Private Sub Clear_frm()
        txtBayNo.Text = ""
        txtBayName.Text = ""
        cbContrec.Text = ""
        cbBayPosition.Text = ""
        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""
        cbBayPosition.Items.Add("ด้านซ้าย")
        cbBayPosition.Items.Add("ด้านขวา")
        cbBayPosition.Items.Add("ด้าน C")
        OptEnabled.Checked = True
        OptUnActive.Checked = True
    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
       
    End Sub

#Region "Menu Event"
    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave
        If frm_work = 1 Then 'Add
            If txtBayNo.Text.Trim = "" Or txtBayName.Text.Trim = "" Or cbContrec.Text.Trim = "" Or cbBayPosition.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            If CheckDataExists(txtBayNo.Text.Trim) = False Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้ " & vbCrLf & vbCrLf & "เพราะมีช่องจ่าย " & txtBayNo.Text.Trim & "  อยู่ในระบบข้อมูลแล้ว", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If txtBayName.Text.Trim = "" Or cbContrec.Text.Trim = "" Or cbBayPosition.Text.Trim = "" Then
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

        AssignCheckBox()
        Dim sql_str As String
        sql_str = " INSERT INTO BAY  ( "
        sql_str = sql_str & "  BAY_NO  "
        sql_str = sql_str & " ,BAY_NAME  "
        sql_str = sql_str & " ,ISLAND_NO  "
        sql_str = sql_str & " ,BAY_POSITION  "
        sql_str = sql_str & " ,BAY_ACTIVE  "
        sql_str = sql_str & " ,LAST_LOAD_NO  "
        sql_str = sql_str & " ,IS_ENABLED  "
        sql_str = sql_str & " ,UPDATED_BY  "
        sql_str = sql_str & " )  "
        sql_str = sql_str & " VALUES ( "
        sql_str = sql_str & "'" + txtBayNo.Text + "'"
        sql_str = sql_str & ",'" + txtBayName.Text + "'"
        sql_str = sql_str & ",'" + cbContrec.Text + "'"
        If cbContrec.Text = "ด้านซ้าย" Then
            sql_str = sql_str & ",'0'"
        ElseIf cbContrec.Text = "ด้านขวา" Then
            sql_str = sql_str & ",'1'"
        Else
            sql_str = sql_str & ",'2'"
        End If
        sql_str = sql_str & "," + RadioActive.ToString + ""
        sql_str = sql_str & ",'" + txtLastLoadNo.Text + "'"
        sql_str = sql_str & "," + RadioEnabled.ToString + ""
        sql_str = sql_str & ",'" + mUserName + "'"
        sql_str = sql_str & " )  "
        If Oradb.ExeSQL(sql_str) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmUnloading_main.Show_Data()
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
        AssignCheckBox()
        Dim sql_str As String
        'Dim mDataSet As New DataSet
        sql_str = " UPDATE BAY SET "
        sql_str = sql_str & " BAY_NAME = '" + txtBayName.Text + "' "
        sql_str = sql_str & ", ISLAND_NO = '" + cbContrec.Text + "' "
        If cbContrec.Text = "ด้านซ้าย" Then
            sql_str = sql_str & ", BAY_POSITION = '0' "
        ElseIf cbContrec.Text = "ด้านขวา" Then
            sql_str = sql_str & ", BAY_POSITION = '1' "
        Else
            sql_str = sql_str & ", BAY_POSITION = '2' "
        End If
        sql_str = sql_str & ", BAY_ACTIVE = '" + RadioActive.ToString + "' "
        sql_str = sql_str & ", LAST_LOAD_NO = '" + txtLastLoadNo.Text + "' "
        sql_str = sql_str & ", IS_ENABLED = '" + RadioEnabled.ToString + "' "
        sql_str = sql_str & ", UPDATE_DATE = SYSDATE "
        sql_str = sql_str & ", UPDATED_BY = '" + mUserName + "' "
        sql_str = sql_str & " WHERE BAY_NO = '" + txtBayNo.Text + "' "
        If Oradb.ExeSQL(sql_str) Then
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmUnloading_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If

    End Sub

    Private Sub AssignValue()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = " SELECT B.BAY_NO,B.BAY_NAME,B.ISLAND_NO,B.BAY_POSITION,B.BAY_ACTIVE,B.LAST_LOAD_NO,B.IS_ENABLED,"
        sql_str = sql_str & " B.UPDATE_DATE,B.UPDATED_BY"
        sql_str = sql_str & " FROM BAY B  "
        sql_str = sql_str & " WHERE  B.BAY_NO = '" + pk_id.ToString + "' "
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            txtBayNo.Text = IIf(IsDBNull(dt.Rows(i).Item("BAY_NO")), "", dt.Rows(i).Item("BAY_NO").ToString)
            txtBayName.Text = IIf(IsDBNull(dt.Rows(i).Item("BAY_NAME")), "", dt.Rows(i).Item("BAY_NAME").ToString)
            cbContrec.Text = IIf(IsDBNull(dt.Rows(i).Item("ISLAND_NO")), "", dt.Rows(i).Item("ISLAND_NO").ToString)
            If IIf(IsDBNull(dt.Rows(i).Item("BAY_POSITION")), "", dt.Rows(i).Item("BAY_POSITION").ToString) = "0" Then
                cbBayPosition.Text = "ด้านซ้าย"
            ElseIf IIf(IsDBNull(dt.Rows(i).Item("BAY_POSITION")), "", dt.Rows(i).Item("BAY_POSITION").ToString) = "1" Then
                cbBayPosition.Text = "ด้านขวา"
            Else
                cbBayPosition.Text = "ด้าน C"
            End If
            If IIf(IsDBNull(dt.Rows(i).Item("BAY_ACTIVE")), "", dt.Rows(i).Item("BAY_ACTIVE").ToString) = "0" Then
                OptUnActive.Checked = True
            Else
                OptActive.Checked = True
            End If
            txtLastLoadNo.Text = IIf(IsDBNull(dt.Rows(i).Item("LAST_LOAD_NO")), "", dt.Rows(i).Item("LAST_LOAD_NO").ToString)
            If IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", dt.Rows(i).Item("IS_ENABLED").ToString) = "0" Then
                OptUnEnbled.Checked = True
            Else
                OptEnabled.Checked = True
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

    Private Sub Search()
    End Sub

    Function CheckDataExists(ByRef pID As String) As Boolean
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        sql_str = " SELECT BAY_NO FROM BAY  "
        sql_str = sql_str & " WHERE   BAY_NO = '" + pID + "' "
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

    Function assignDropDownIsland() As Boolean
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        sql_str = " SELECT ISLAND_NO FROM BAY  "
        sql_str = sql_str & " WHERE  1=1 "
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Dim islandNo As String

            Do While dt.Rows.Count > i
                islandNo = IIf(IsDBNull(dt.Rows(i).Item("ISLAND_NO")), "", dt.Rows(i).Item("ISLAND_NO").ToString)
                If Not cbContrec.Items.Contains(islandNo) Then
                    cbContrec.Items.Add(islandNo)
                End If
                i = i + 1
            Loop
            'Return True
        End If
        mDataSet = Nothing
        Return True
    End Function

    Private Sub chkQuota_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        checkQuota()
    End Sub

    Private Sub checkQuota()
    End Sub

    Private Sub cmdSetColor_Click(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Private Sub txtQuota_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    End Sub

    Private Sub AssignCheckBox()
        If OptEnabled.Checked = True Then
            RadioEnabled = 1
        Else
            RadioEnabled = 0
        End If
        '--------------------------
        If OptActive.Checked = True Then
            RadioActive = 1
        Else
            RadioActive = 0
        End If
        '---------------------------
        If cbBayPosition.Text = "ด้านซ้าย" Then
            
        End If
    End Sub

    Private Sub OptUnActive_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles OptUnActive.CheckedChanged

    End Sub
End Class
