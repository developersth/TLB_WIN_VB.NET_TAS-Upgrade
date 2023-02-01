Public Class FrmUtlChangPsw
    Public FormScreenID As Long
    Private Sub FrmUtlChangPsw_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtUsername.Text = mUserName
    End Sub

    Private Sub Cancle_Click(sender As System.Object, e As System.EventArgs) Handles Cancle.Click
        Me.Close()
    End Sub

    Private Sub SAVE_Click(sender As System.Object, e As System.EventArgs) Handles SAVE.Click
        Dim strSQL As String, strPswDb As String, strKeyString As String, strPswEnCode As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        strSQL = " SELECT MAX((CARD_READER_ID)+1) as MaxCRID FROM TAS.CARD_READER"

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            'txtUserID.Text = IIf(IsDBNull(dt.Rows(0).Item("MaxCRID")), "", dt.Rows(0).Item("MaxCRID").ToString)
        End If
        '    If Not GetAutherizeStatus(ScreenID, 0) Then Exit Sub
        '    If Not CheckAuthorize(P_Authorize, BitEdit) Then Exit Sub
        Select Case ""
            Case Trim(txtUsername.Text)
                MsgBox("ท่านไม่ได้กรอกชื่อผู้ใช้", vbExclamation, "TAS")
                Exit Sub
            Case Trim(txtPassOld.Text)
                MsgBox("ท่านไม่ได้กรอกรหัสผ่านเดิม", vbExclamation, "TAS")
                Exit Sub
            Case Trim(Gropbox3.Text)
                MsgBox("ท่านไม่ได้กรอกรหัสผ่านใหม่", vbExclamation, "TAS")
                Exit Sub
            Case Trim(txtPassNew2.Text)
                MsgBox("ท่านไม่ได้กรอกยืนยันรหัสผ่าน", vbExclamation, "TAS")
                Exit Sub
            Case Else
                'without
        End Select
        If Trim(txtPassNew1.Text) <> Trim(txtPassNew2.Text) Then
            MsgBox("รหัสผ่านใหม่ไม่ตรงกัน", vbInformation)
            Exit Sub
        End If

        If Len(Trim(Gropbox3.Text)) < 4 Then
            MsgBox("รหัสผ่านใหม่ต้อง 4 ตัวขึ้นไป", vbInformation)
            Exit Sub
        End If

        strSQL = _
                    "select U.USER_PASSWORD,U.KEYCRYPT " & _
                    "from USER_TAM U " & _
                    "where U.USER_ID='" & Trim(txtUsername.Text) & "'"
        '  Oratemp = GetDynaset(strSQL)
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            strPswDb = dt.Rows(0).Item("USER_PASSWORD")
            strKeyString = dt.Rows(0).Item("KEYCRYPT")
            If Trim(txtPassOld.Text) = cEncrypt.DecryptData(strPswDb, strKeyString) Then
                If MsgBox("ท่านต้องการเปลี่ยนรหัสผ่านหรือไม่", vbInformation + vbYesNo) = vbYes Then
                    'strKeyString = Format(Date, "dddd")
                    ' McsCPsw.KeyString = strKeyString
                    strPswEnCode = cEncrypt.EncryptData(Trim(txtPassNew1.Text), strKeyString)
                    strSQL = _
                        "update USER_TAM U set " & _
                            "U.USER_PASSWORD='" & strPswEnCode & "'," & _
                            "U.KEYCRYPT='" & strKeyString & "' " & _
                        "where U.USER_ID='" & Trim(txtUsername.Text) & "'"

                    If Oradb.ExeSQL(strSQL) Then
                        'Call AddJournal(Jevent, P_CurScreenID, 100, P_ModifyUser, 806201, Trim(txtUsername))
                        MsgBox("บันทึกข้อมูลของผู้ใช้ " & Trim(txtUsername.Text) & " เรียบร้อยแล้ว", vbInformation, "TAS")
                    End If
                End If
            Else
                MsgBox("ท่านใส่รหัสผ่านเดิมไม่ถูกต้อง", vbInformation)
            End If
        Else


        End If

    End Sub

    Private Sub FrmUtlChangPsw_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(FormScreenID, "")
    End Sub
End Class