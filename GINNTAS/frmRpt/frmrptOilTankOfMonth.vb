Public Class frmrptOilTankOfMonth
    Private Sub InitialCombo()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "select BASE_PRODUCT_ID " & _
                  "from BASE_PRODUCT " & _
                  "order by BASE_PRODUCT_ID"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            cbProductID.Text = ""
            Do While dt.Rows.Count > i
                cbProductID.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("BASE_PRODUCT_ID")), "", dt.Rows(i).Item("BASE_PRODUCT_ID").ToString))
                i = i + 1
            Loop
            cbProductID.SelectedIndex = 0
        Else
        End If
        mDataSet = Nothing

    End Sub

    Private Sub frmrptOilTankOfMonth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MVdate.Value = String.Format("{0:dd/MM/yyyy}", Date.Now)
        InitialCombo()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        Dim sProduct() As String, sCode As String
        If cbProductID.Text <> "" Then
            sProduct = Split(cbProductID.Text, " ")
            sCode = sProduct(0)
        End If
        'frmrptShowReport.mRptFileName = "Detail Oil Bulk Loading Monthly.rpt"
        'frmrptShowReport.mParameter = MVdate.Value()
        'frmrptShowReport.ValueParameter = 1
        'frmrptShowReport.Show()
        With frmrptMainShow
            .report_id = "52010013"
            .param1 = MVdate.Value()
            .param2 = cbProductID.Text
            .Show()
        End With
    End Sub
End Class