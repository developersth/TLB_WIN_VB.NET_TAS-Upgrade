Public Class frmrptEndOfDay

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        Dim vReport_ID As String = String.Empty
        If (optStatus1.Checked = True) Then 'Volume Load Report By Product
            vReport_ID = "52010042"
        ElseIf (optStatus2.Checked = True) Then 'Mass Load Report By Product
            vReport_ID = "52010043"
        ElseIf (optStatus3.Checked = True) Then 'Volume Load Report By Company
            vReport_ID = "52010044"
        ElseIf (optStatus4.Checked = True) Then 'Mass Load Report By Company
            vReport_ID = "52010045"
        ElseIf (optStatus5.Checked = True) Then 'Summary Load Report By Company
            vReport_ID = "52010046"
        Else 'SummaryMassLoadReportByCompany.rpt
            vReport_ID = "52010047"
        End If

        With frmrptMainShow
            .report_id = vReport_ID
            .param1 = MVDate.SelectionStart()
            .Show()
        End With
    End Sub
End Class