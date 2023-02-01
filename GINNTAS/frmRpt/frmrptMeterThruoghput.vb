Public Class frmrptMeterThruoghput
    Private Sub InitialCombo()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "select t.TYPE_ID||' - '||t.TYPE_NAME as TYPE_NAME from tas.v_pulse_input t"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            cbType.Text = ""
            Do While dt.Rows.Count > i
                cbType.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("TYPE_NAME")), "", dt.Rows(i).Item("TYPE_NAME").ToString))
                i = i + 1
            Loop
            cbType.SelectedIndex = 0
        Else
        End If
        mDataSet = Nothing

    End Sub

    Private Sub frmrptMeterThruoghput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitialCombo()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        Dim strQuery As String
        strQuery = "select * " & _
                                  "from rpt.view_data_meter " & _
                                  "where trunc(eod_date)=to_date('" & Format(MVDate.SelectionRange.Start()) & "','DD/MM/YYYY') " & _
                                  "and pulse_input=" & Mid(cbType.Text, 1, 1) & ""
        'frmrptShowReport.ValueParameter = 2
        'frmrptShowReport.mstrQuery = strQuery
        'frmrptShowReport.mRptFileName = "MeterThroughput.rpt"
        'frmrptShowReport.mParameter = MVDate.SelectionStart()
        'frmrptShowReport.Show()
        With frmrptMainShow
            .report_id = "52010009"
            .sql_query = strQuery
            .param1 = MVDate.SelectionStart()
            .Show()
        End With

    End Sub
End Class