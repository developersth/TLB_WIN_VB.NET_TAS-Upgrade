Public Class frmLoadEditGOVCOQ
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        loadData()

    End Sub

    Private Sub loadData()
        Dim mDataSet As New DataSet
        Dim strSQL As String
        Dim dt As DataTable
        Dim row As Integer = frmLoadLoading.MSGridHeader.CurrentRow.Index
        txtloadNo.Text = frmLoadLoading.MSGridHeader.Item(1, row).Value()
        txtloadNo.Enabled = False
        Text_productName.Enabled = False
        Text_COQ_NO.Enabled = False

        strSQL = "select t.sale_product_name,t.coq_no,to_char(t.coq_date,'dd/mm/yyyy') as coq_date ,t.gov_coq_no,to_char(t.gov_coq_date,'dd/mm/yyyy') as gov_coq_date"
        strSQL = strSQL & " from rpt.DELIVERY_REPORT_BITUMEN t where t.load_header_no =" & txtloadNo.Text
        If Oradb.OpenDys(strSQL, "COQ_DATA", mDataSet) Then
            dt = mDataSet.Tables("COQ_DATA")
            If dt.Rows.Count > 0 Then
                Text_productName.Text = IIf(IsDBNull(dt.Rows(0).Item("sale_product_name")), "", dt.Rows(0).Item("sale_product_name").ToString)
                Text_COQ_NO.Text = IIf(IsDBNull(dt.Rows(0).Item("coq_no")), "", dt.Rows(0).Item("coq_no").ToString)
                Text_GOVCOQ_NO.Text = IIf(IsDBNull(dt.Rows(0).Item("gov_coq_no")), "", dt.Rows(0).Item("gov_coq_no").ToString)
                'Console.WriteLine(dt.Rows(0).Item("coq_date").ToString)
                If dt.Rows(0).Item("coq_date").ToString.Equals("") Then
                    COQ_DATE.Value = Date.Now
                Else
                    COQ_DATE.Value = Date.ParseExact(dt.Rows(0).Item("coq_date").ToString, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo, Globalization.DateTimeStyles.None)
                End If
                If dt.Rows(0).Item("gov_coq_date").ToString.Equals("") Then
                    GOV_COQ_DATE.Value = Date.Now
                Else
                    GOV_COQ_DATE.Value = Date.ParseExact(dt.Rows(0).Item("gov_coq_date").ToString, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo, Globalization.DateTimeStyles.None)
                End If

            End If
        Else
        End If
    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub CmdOk_Click(sender As Object, e As EventArgs) Handles CmdOk.Click
        Dim d As String
        Dim strSQL As String
        If MsgBox("ท่านต้องการบันทึกข้อมูล ใช่หรือไม่?", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If
        strSQL = "Update rpt.DELIVERY_REPORT_BITUMEN t SET t.gov_coq_no='" & Trim(Text_GOVCOQ_NO.Text) & "' ,"
        strSQL = strSQL & "t.coq_date =to_date('" & COQ_DATE.Value.ToString("dd/MM/yyyy") & "','dd/mm/yyyy'), "
        strSQL = strSQL & "t.gov_coq_date =to_date('" & GOV_COQ_DATE.Value.ToString("dd/MM/yyyy") & "','dd/mm/yyyy') "
        strSQL = strSQL & " Where t.load_header_no=" & txtloadNo.Text
        Oradb.ExeSQL(strSQL)
        Me.Close()
    End Sub
End Class