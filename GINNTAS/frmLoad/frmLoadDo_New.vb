Public Class frmLoadDo_new

    Private Sub frmLoadDo_new_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtNew_DO.Text = ""
    End Sub
    Public Sub InitialOldDo(ByVal vDo As String)
        txtOld_DO.Text = vDo
    End Sub
    Private Function Edit_DO_Used() As Boolean
        Dim strSQL As String

        Edit_DO_Used = False
        If MsgBox("ท่านต้องการแก้ไข DO จาก " & txtOld_DO.Text & " เป็น " & txtNew_DO.Text & " หรือไม่?", vbInformation + vbYesNo) = vbNo Then
            Exit Function
        End If

        strSQL = "begin  TAS.EDIT_DO( '" & Trim(txtOld_DO.Text) & "','" & txtNew_DO.Text & "' ,'" & mComputerName & "','" & mUserName & "',:RET_CHECK,:RET_MSG); END;"

        Dim Oraparam As New COraParameter
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_CHECK", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With
        Dim bRet As Boolean = False
        If Oradb.ExeSQL(strSQL, Oraparam) Then
            RET_CHECK = Oraparam.GetOraclParamValue("RET_CHECK")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            If Not RET_CHECK = 0 Then
                MsgBox(RET_MSG.ToString, vbCritical, "เกิดข้อผิดพลาด")
                bRet = False
            Else
                MsgBox("ท่านได้ทำการแก้ไข DO จาก '" & txtOld_DO.Text & "' เป็น '" & txtNew_DO.Text & "' เรียบร้อยแล้ว?", vbInformation)
                bRet = True
            End If
        End If
        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function

    Private Sub bt_Save_Click(sender As System.Object, e As System.EventArgs) Handles bt_Save.Click
        Edit_DO_Used()
    End Sub

    Private Sub bt_Cancel_Click(sender As System.Object, e As System.EventArgs) Handles bt_Cancel.Click
        Me.Close()
    End Sub
End Class