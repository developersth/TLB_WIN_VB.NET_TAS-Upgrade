Public Class LoginForm1
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text.Trim = "" Or PasswordTextBox.Text.Trim = "" Then
            MsgBox("ท่านไม่ได้กรอก User หรือ Password กรุณาตรวจสอบ", MsgBoxStyle.Information, "TAS System")
            Exit Sub
        End If

        If LogonTAS(UsernameTextBox.Text.Trim, PasswordTextBox.Text.Trim) Then
            mLogInSuccess = True
            frmMain1.UseWaitCursor = False
            frmMain1.Show()
            Me.Close()
        Else
            mLogInSuccess = False
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        frmMain1.Close()
        'frmMain1.Close()
        'frmMain1.UseWaitCursor = False
    End Sub

    Private Sub LoginForm1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Not mLogInSuccess Then
            frmMain1.Close()
            'frmMain1.UseWaitCursor = False
        End If
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        txtComputer.Text = GetComputerName()
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

    Private Function LogonTAS(ByVal pUser As String, ByVal pPass As String) As Boolean

        Dim bRet As Boolean = False
        Dim StrSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim vPsw As String = ""
        Dim vkeyString As String

        StrSQL = "select T.USER_ID,T.PRIORITY,T.USER_PASSWORD,T.IS_ENABLED,t.keycrypt,U.priority_name from USER_TAM T,USER_GROUP U"
        StrSQL = StrSQL + " where T.USER_ID='" & Trim(UCase(pUser)) & "' and T.PRIORITY=U.PRIORITY_ID"
        Try
            If Oradb.OpenDys(StrSQL, "TableName", mDataSet) Then
                dt = mDataSet.Tables("TableName")

                If dt.Rows.Count > 0 Then

                    'StrSQL = "select T.USER_ID,T.PRIORITY,T.USER_PASSWORD,T.IS_ENABLED from USER_TAS T"
                    'StrSQL = StrSQL + " where upper(T.USER_ID)='" & Trim(UCase(pUser)) & "' and T.USER_PASSWORD='" & Trim(pPass) & "' "
                    vkeyString = IIf(IsDBNull(dt.Rows(0).Item("keycrypt")), "", dt.Rows(0).Item("keycrypt").ToString)
                    vPsw = dt.Rows(0).Item("USER_PASSWORD").ToString()
                    'MessageBox.Show(cEncrypt.DecryptData(vPsw, vkeyString))
                    If pPass = cEncrypt.DecryptData(vPsw, vkeyString) Then
                        If True Then
                            bRet = True

                            Dim isEnable As String = IIf(IsDBNull(dt.Rows(0).Item("IS_ENABLED")), "", dt.Rows(0).Item("IS_ENABLED").ToString)
                            If isEnable = 1 Then
                                mUserName = IIf(IsDBNull(dt.Rows(0).Item("USER_ID")), "", dt.Rows(0).Item("USER_ID").ToString)
                                mUserGroupName = IIf(IsDBNull(dt.Rows(0).Item("priority_name")), "", dt.Rows(0).Item("priority_name").ToString)
                                mComputerName = GetComputerName()
                                AddJournal(JournalType.Jevent, 0, 100, mUserName, 102200, mUserName)
                            Else
                                MsgBox("User นี้ไม่อนุญาติเข้าใช้งานระบบ TAS กรุณาตรวจสอบใหม่อีกครั้ง", MsgBoxStyle.Information, "TAS System")
                                Return False
                            End If
                        Else
                            'bRet = False
                            'MsgBox("Password ไม่ถูกต้อง กรุณาตรวจสอบใหม่อีกครั้ง", MsgBoxStyle.Information, "TAS System")
                            AddJournal(JournalType.Jevent, 0, 100, mUserName, 102200, mUserName)
                            bRet = True
                        End If
                    Else
                        MsgBox("ท่านใส่รหัสผ่านไม่ถูกต้อง กรุณาตรวจสอบใหม่อีกครั้ง", MsgBoxStyle.Information, "TAS System")
                        Return False
                    End If
                Else
                    MsgBox("ไม่พบ User นี้ในระบบ กรุณาตรวจสอบใหม่อีกครั้ง", MsgBoxStyle.Information, "TAS System")
                    Return False
                End If
                Else
                    bRet = False
                    MsgBox("Database is disconnected!", vbCritical)
                End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        mDataSet = Nothing
        Return bRet
    End Function



End Class
