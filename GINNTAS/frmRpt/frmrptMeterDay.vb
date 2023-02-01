Public Class frmrptMeterDay

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        'frmrptShowReport.mParameter = MVDate.SelectionStart()
        'frmrptShowReport.mRptFileName = "Meter Totalizer.rpt"
        'frmrptShowReport.Show()
        With frmrptMainShow
            .report_id = "52010008"
            .param1 = MVDate.SelectionStart()
            .Show()
        End With
    End Sub
End Class