Public Class frmrptProductOfYear

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        Dim iReport_ID As String
        If (rType1.Checked = True) Then
            iReport_ID = "52010053"
        Else
            iReport_ID = "52010054"
        End If
        'frmrptShowReport.mParameter = MVYear.Value()
        'frmrptShowReport.Show()
        With frmrptMainShow
            .report_id = iReport_ID
            .param1 = Format(MVYear.Value, "yyyy")
            .Show()
        End With

    End Sub

End Class