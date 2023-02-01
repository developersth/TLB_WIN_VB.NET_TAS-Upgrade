Public Class frmMMIBayLoadingTopUP
    Public LoadHeader As String
    Public Compartment As String
    Public OldTopup As String

    Private Sub CmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOK.Click

        Dim strSQL As String
        If txtTopUP2.Text = "" Then Exit Sub
        strSQL = " Update OIL_LOAD_LINES O SET  O.VALUE_TOPUP = " & txtTopUP2.Text & ",O.UPDATE_DATE=sysdate, "
        strSQL = strSQL & " O.UPDATED_BY='" & mUserName & "', O.J_COMPUTER='" & mComputerName & "' "
        strSQL = strSQL & " Where O.LOAD_HEADER_NO ='" & LoadHeader & "' and O.COMPARTMENT_NO ='" & Compartment & "' "
        Oradb.ExeSQL(strSQL)
        'Unload(Me)
        Me.Close()
    End Sub

    Private Sub frmMMIBayLoadingTopUP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtTopUP1.Text = OldTopup
        txtTopUP1.Enabled = True
        txtTopUP1.BackColor = ColorTranslator.FromHtml("#C0FFC0") 'C0FFC0 <===RGB(192, 255, 192) 
        txtCompartment.Text = Compartment
        txtCompartment.Enabled = True
        txtCompartment.BackColor = ColorTranslator.FromHtml("#C0FFC0")

    End Sub

    Private Sub txtTopUP2_KeyPress(ByVal KeyAscii As Integer)
        Select Case KeyAscii
            Case System.Windows.Forms.Keys.D0 To System.Windows.Forms.Keys.D9, System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.Delete, System.Windows.Forms.Keys.Tab, 45
            Case System.Windows.Forms.Keys.Return
                txtTopUP2.Focus()
            Case Else
                KeyAscii = 0
        End Select
    End Sub

    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        'Unload(Me)
        Me.Close()
    End Sub
End Class