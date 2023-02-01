Public Class frmrptStatusOftank

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        Dim vReport_ID As String
        If (optStatus1.Checked = True) Then
            vReport_ID = "52010010"
        Else
            vReport_ID = "52010019"
        End If
        'frmrptShowReport.mParameter = MVDate.SelectionStart()
        'frmrptShowReport.Show()
        With frmrptMainShow
            .report_id = vReport_ID
            .param1 = MVDate.SelectionStart()
            .Show()
        End With
    End Sub
End Class