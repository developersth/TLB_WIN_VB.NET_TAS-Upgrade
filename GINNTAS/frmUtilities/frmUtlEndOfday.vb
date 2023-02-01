Public Class frmUtlEndOfday
    Public FormScreenID As Long
    Private Sub cmdForceEOD_Click(sender As System.Object, e As System.EventArgs)
        If MsgBox("Do you want End of Day now?", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        Else
            If forceEOD() Then
                MsgBox("ท่านได้ทำการ End of Day เรียบร้อยแล้ว ", vbInformation, "System")
                'Unload(Me)
            End If
        End If
    End Sub
    Private Function forceEOD() As Boolean
        Dim bRet As Boolean = False
        Dim sql_str As String
        sql_str = "BEGIN wjob.prod_manual_eod; END;"
        If Oradb.ExeSQL(sql_str) Then
                bRet = True
        End If

        Return bRet
    End Function

    Private Sub frmUtlEndOfday_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Date.Now
        DateTimePicker2.Value = Date.Now
    End Sub

    Private Sub UcMenucmdForceEOD_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenucmdForceEOD.OnClickMnuText
        If MsgBox("Do you want End of Day now?", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        Else
            If forceEOD() Then
                MsgBox("ท่านได้ทำการ End of Day เรียบร้อยแล้ว ", vbInformation, "System")
                'Unload(Me)
            End If
        End If
    End Sub

    Private Sub frmUtlEndOfday_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        CloseForm(FormScreenID, "")
    End Sub


End Class