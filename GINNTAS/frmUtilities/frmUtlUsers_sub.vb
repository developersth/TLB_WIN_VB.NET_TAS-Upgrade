Imports Oracle.DataAccess.Client
Imports System.Data
Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text
Public Class frmUtlUsers_sub
    Dim frm_work As Integer = 0 'CardReader1=add ,2=Edit
    Dim pk_id As String = ""
    Dim RadioEnabled As String
    Dim RadioLocked As String
    Dim vFixType As String

    Private Sub frmUtlUsers_sub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        If frm_work = 1 Then
            Me.Text = "User # Add"
        ElseIf frm_work = 2 Then
            Me.Text = "User # Edit"
            AssignValue()
        End If
        txtLock(True)
    End Sub

    Private Sub Clear_frm()

        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""
        OptEnabled.Checked = True


    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        If iBoo Then
            'txtUserID.BackColor = Color.LightGray
            txtLastUpdateDate.BackColor = Color.LightGray
            txtLastUpdateBy.BackColor = Color.LightGray
        Else
            'txtUserID.BackColor = Color.White
            txtLastUpdateDate.BackColor = Color.White
            txtLastUpdateBy.BackColor = Color.White
        End If
    End Sub

#Region "Menu Event"
    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave
        If frm_work = 1 Then 'Add
            If Trim(txtUserID.Text) = "" Or Trim(txtFirstName.Text) < "" Or Trim(txtPsw.Text) = "" Or Trim(txtConfirmPsw.Text) = "" Or cbPriority.Text = "" Then
                MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", vbInformation)
                ' MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            If txtPsw.Text <> txtConfirmPsw.Text Then
                MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "ท่านใส่ข้อมูลรหัสผ่านไม่เหมือนกัน กรุณาตรวจสอบข้อมูลอีกครั้ง", vbInformation)
                Exit Sub
            End If

            If Len(Trim(txtPsw.Text)) < 4 Then
                MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "รหัสผ่านต้องมีจำนวนตัวอักษรตั้งแต่ 4 ตัวขึ้นไป กรุณาตรวจสอบข้อมูลอีกครั้ง", vbInformation)
                Exit Sub
            End If

            If CheckDataExists(Trim(txtUserID.Text)) Then
                MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "เนื่องจากมีรหัสผู้ใช้ " & Trim(txtUserID.Text) & " อยู่ในฐานข้อมูลแล้ว", vbInformation)
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If Trim(txtUserID.Text) = "" Or Trim(txtFirstName.Text) = "" Or cbPriority.Text = "" Then
                'MsgBox("äÁèÊÒÁÒÃ¶ºÑ¹·Ö¡¢éÍÁÙÅä´é" & vbCrLf & vbCrLf & "·èÒ¹ãÊè¢éÍÁÙÅäÁè¤Ãº ¡ÃØ³ÒµÃÇ¨ÊÍº¢éÍÁÙÅÍÕ¡¤ÃÑé§", vbInformation)
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            If Not CheckDataExists(Trim(txtUserID.Text)) Then
                MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "เนื่องจากไม่พบรหัสผู้ใช้ " & Trim(txtUserID.Text) & " อยู่ในฐานข้อมูล", vbInformation)
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
        Dim strPswEndCode As String
        Dim strKeyCrypt As String

        Dim d As New System.DateTime
        strKeyCrypt = Format(d, "dddd")
        'EnCodePsw.KeyString = strKeyCrypt
        strPswEndCode = cEncrypt.EncryptData(Trim(txtPsw.Text), strKeyCrypt)
        Dim Priority() = Split(Trim(cbPriority.Text), "-")
        'strPswEndCode = EncryptData(Trim(txtPsw.Text))

        strSQL = _
            "insert into USER_TAM(" & _
                "USER_ID,FIRST_NAME," & _
                "LAST_NAME,PRIORITY," & _
                "DESCRIPTION,USER_PASSWORD," & _
                "KEYCRYPT,EXPIRE_DATE," & _
                "IS_ENABLED,CREATION_DATE," & _
                "CREATED_BY,UPDATE_DATE," & _
                "UPDATED_BY,J_COMPUTER) " & _
            "values(" & _
                "'" & Trim(txtUserID.Text) & "','" & Trim(txtFirstName.Text) & "'," & _
                "'" & Trim(txtLastName.Text) & "'," & Priority(0) & "," & _
                "'" & Trim(txtComment.Text) & "','" & strPswEndCode & "'," & _
                "'" & strKeyCrypt & "',to_date('" & Format(dtpExpireDate.Value, "dd/MM/yyyy") & "','dd/MM/yyyy')," & _
                IIf(OptEnabled.Enabled = True, 1, 0) & ",sysdate," & _
                "'" & mUserName & "',sysdate," & _
                "'" & mUserName & "','" & mComputerName & "')"
        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmUtlUsers_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
        'If AddData Then
        '    AE_UserID = Trim(txtUserID)
        '    Call AddJournal(Jevent, P_CurScreenID, 100, P_ModifyUser, 801201, Trim(txtUserID), Trim(txtFirstName), cbPriority)
        'End If
    End Sub
 
 

    Public Sub setFrmWork(ByVal n As Integer)
        Me.frm_work = n
    End Sub

    Public Sub setPkId(ByVal id As String)
        Me.pk_id = id
    End Sub

    Private Sub Edit()
        Dim strSQL As String
   
        Dim Priority() = Split(Trim(cbPriority.Text), "-")
        strSQL = _
            "update USER_TAM U set " & _
                "U.FIRST_NAME='" & Trim(txtFirstName.Text) & "'," & _
                "U.LAST_NAME='" & Trim(txtLastName.Text) & "'," & _
                "U.PRIORITY=" & Priority(0) & "," & _
                "U.DESCRIPTION='" & Trim(txtComment.Text) & "'," & _
                "U.EXPIRE_DATE=to_date('" & Format(dtpExpireDate.Value, "dd/MM/yyyy") & "','dd/MM/yyyy')," & _
                "U.IS_ENABLED=" & IIf(OptEnabled.Checked, 1, 0) & "," & _
                "U.UPDATE_DATE=sysdate," & _
                "U.UPDATED_BY='" & mUserName & "'," & _
                "U.J_COMPUTER='" & mComputerName & "' " & _
            "where U.USER_ID='" & Trim(txtUserID.Text) & "'"
        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmUtlUsers_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
        'If EditData Then
        '    AE_UserID = Trim(txtUserID)
        '    'If AE_UserID = P_ModifyUser Then
        '    '    P_Priority = cbPriority.ItemData(cbPriority.ListIndex)
        '    '    Call AddJournal(Jevent, P_CurScreenID, 100, P_ModifyUser, 801202, Trim(txtUserID), Trim(txtFirstName), cbPriority)
        '    'End If
        'End If

    End Sub

    Private Sub AssignValue()
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        txtUserID.Enabled = False
        txtPsw.Enabled = False
        txtConfirmPsw.Enabled = False
        strSQL = _
         "select U.USER_ID,U.FIRST_NAME,U.LAST_NAME," & _
            "U.PRIORITY,U.DESCRIPTION,U.EXPIRE_DATE," & _
            "U.IS_ENABLED,U.IS_LOGON,U.LOGON_TIME,U.LOGOFF_TIME," & _
            "U.COMPUTER_LOGON,U.UPDATE_DATE,U.UPDATED_BY " & _
        "from USER_TAM U " & _
        "where U.USER_ID='" & pk_id & "'"

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            txtUserID.Text = dt.Rows(i).Item("USER_ID")
            'AE_UserID = dt.Rows(i).Item("USER_ID")
            txtFirstName.Text = IIf(IsDBNull(dt.Rows(i).Item("FIRST_NAME")), "", dt.Rows(i).Item("FIRST_NAME"))
            txtLastName.Text = IIf(IsDBNull(dt.Rows(i).Item("LAST_NAME")), "", dt.Rows(i).Item("LAST_NAME"))
            'If dt.Rows(i).Item("PRIORITY") Then
            '    cbPriority.SelectedIndex = -1
            'Else
            '    cbPriority.Text = dt.Rows(i).Item("PRIORITY")
            'End If
            'cbPriority.Text = ""
            Dim strProtocal As String = IIf(IsDBNull(dt.Rows(i).Item("PRIORITY")), "", dt.Rows(i).Item("PRIORITY").ToString)
            setListboxWithName(strProtocal, cbPriority)

            txtComment.Text = IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION"))
            If dt.Rows(i).Item("IS_ENABLED") = 1 Then
                OptEnabled.Checked = True
                OptUnEnbled.Checked = False
            Else
                OptEnabled.Checked = False
                OptUnEnbled.Checked = True
            End If
            dtpExpireDate.Text = IIf(IsDBNull(dt.Rows(i).Item("EXPIRE_DATE")), "", Format(dt.Rows(i).Item("EXPIRE_DATE"), "dd/MM/yyyy HH:mm:ss"))
            txtLogOnStatus.Text = IIf(IsDBNull(dt.Rows(i).Item("IS_LOGON")), "", IIf((dt.Rows(i).Item("IS_LOGON") = 1), "อยู่ในระบบ", "ไม่ได้อยู่ในระบบ"))
            txtLogOnTime.Text = IIf(IsDBNull(dt.Rows(i).Item("LOGON_TIME")), "", Format(dt.Rows(i).Item("LOGON_TIME"), "วันที่ dd MMMM yyyy เวลา HH:mm:ss"))
            txtLogOutTime.Text = IIf(IsDBNull(dt.Rows(i).Item("LOGOFF_TIME")), "", Format(dt.Rows(i).Item("LOGOFF_TIME"), "วันที่ dd MMMM yyyy เวลา HH:mm:ss"))
            txtComputerLogOn.Text = IIf(IsDBNull(dt.Rows(i).Item("COMPUTER_LOGON")), "", dt.Rows(i).Item("COMPUTER_LOGON"))
            txtLastUpdateDate.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", Format(dt.Rows(i).Item("UPDATE_DATE"), "วันที่ dd MMMM yyyy เวลา HH:mm:ss"))
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

    Function CheckDataExists(ByRef pID As String) As Boolean
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        sql_str = "SELECT C.USER_ID from tas.USER_TAM C "
        sql_str = sql_str & " WHERE  C.USER_ID = '" + pID + "' "
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Do While dt.Rows.Count > i
                Return True
            Loop
            Return False
        End If
        mDataSet = Nothing
        Return False
    End Function


    Function assignDropDown() As Boolean
        Dim sql_str As String
        sql_str = _
               "select S.STATUS_NUMBER|| '-' ||S.DESCRIPTION AS Priority " & _
                "from STATUS_DESC S " & _
                "where S.T_NAME='USER_TAS' " & _
                "and S.COLUMNS_NAME='PRIORITY' " & _
                "and S.STATUS_NUMBER in(2,4,5,6) " & _
                "order by S.STATUS_NUMBER"
        assignDropDown(sql_str, "Priority", cbPriority)

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

    Private Sub cbComport1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbComport2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Function GetNextCRID() As Long
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        sql_str = " SELECT MAX((CARD_READER_ID)+1) as MaxCRID FROM TAS.CARD_READER"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            txtUserID.Text = IIf(IsDBNull(dt.Rows(0).Item("MaxCRID")), "", dt.Rows(0).Item("MaxCRID").ToString)
        End If
        Return 0.1
        mDataSet = Nothing
    End Function

End Class
