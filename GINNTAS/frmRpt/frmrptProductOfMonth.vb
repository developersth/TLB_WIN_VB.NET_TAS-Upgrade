Public Class frmrptProductOfMonth

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub


    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        Dim strSQL As String
        Dim vReport_ID As String = String.Empty
        If rType1.Checked = True = True Then
            strSQL = "select * " &
                  "from rpt.view_load_mass_report_daily " &
                  "where  to_date(eod_date) =  to_date('" & Format(MVDate.Value, "MM/yyyy") & "','MM/yyyy') " &
                  "order by eod_date"
            vReport_ID = "52010051"
        Else
            strSQL = "select * " &
                      "from rpt.view_load_volume_report_daily " &
                      "where  to_date(eod_date) =  to_date('" & Format(MVDate.Value, "MM/yyyy") & "' ,'MM/yyyy')" &
                      "order by eod_date"
            vReport_ID = "52010052"
        End If
        'frmrptShowReport.ValueParameter = 2
        'frmrptShowReport.mstrQuery = strSQL
        ''frmrptShowReport.mParameter = Format(MVDate.Value, "MM/yyyy")
        'frmrptShowReport.Show()
        With frmrptMainShow
            .report_id = vReport_ID
            .sql_query = strSQL
            .param1 = Format(MVDate.Value, "MM/yyyy")
            .Show()
        End With
    End Sub

    Private Sub frmrptProductOfMonth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MVDate.Value = String.Format("{0:dd/MM/yyyy}", Date.Now)
    End Sub
End Class