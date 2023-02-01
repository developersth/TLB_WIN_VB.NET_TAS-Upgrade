Public Class frmCheckUserPw
    Public LogInSuccess As Boolean
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If UsernameTextBox.Text.Trim = "" Or PasswordTextBox.Text.Trim = "" Then
            MsgBox("ท่านไม่ได้กรอก User หรือ Password กรุณาตรวจสอบ", MsgBoxStyle.Information, "TAS System")
            Exit Sub
        End If

        If LogonTAS(UsernameTextBox.Text.Trim, PasswordTextBox.Text.Trim) Then
            LogInSuccess = True
            Me.Close()
        Else
            LogInSuccess = False
        End If
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
                    vkeyString = IIf(IsDBNull(dt.Rows(0).Item("keycrypt")), "", dt.Rows(0).Item("keycrypt").ToString)
                    vPsw = dt.Rows(0).Item("USER_PASSWORD").ToString()
                    If pPass = cEncrypt.DecryptData(vPsw, vkeyString) Then
                        If True Then
                            bRet = True

                            Dim isEnable As String = IIf(IsDBNull(dt.Rows(0).Item("IS_ENABLED")), "", dt.Rows(0).Item("IS_ENABLED").ToString)
                            If isEnable = 1 Then

                            Else
                                MsgBox("User นี้ไม่อนุญาติเข้าใช้งานระบบ TAS กรุณาตรวจสอบใหม่อีกครั้ง", MsgBoxStyle.Information, "TAS System")
                                Return False
                            End If
                        Else
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

    Private Sub PasswordTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            If UsernameTextBox.Text.Trim = "" Or PasswordTextBox.Text.Trim = "" Then
                MsgBox("ท่านไม่ได้กรอก User หรือ Password กรุณาตรวจสอบ", MsgBoxStyle.Information, "TAS System")
                Exit Sub
            End If

            If LogonTAS(UsernameTextBox.Text.Trim, PasswordTextBox.Text.Trim) Then
                LogInSuccess = True
                Me.Close()
            Else
                LogInSuccess = False
            End If
        End If
    End Sub
End Class