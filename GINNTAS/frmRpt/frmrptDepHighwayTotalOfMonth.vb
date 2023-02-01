Public Class frmrptDepHighwayTotalOfMonth
    Dim sProduct() As String, sCode As String
    Dim rType As Long
    Private Sub InitialCombo()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "select t.sale_product_id,t.sale_product_id||' '||t.sale_product_code as sale_product from sale_product t order by t.sale_product_id"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            cbProductID.Text = ""
            Do While dt.Rows.Count > i
                cbProductID.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("sale_product")), "", dt.Rows(i).Item("sale_product").ToString))
                i = i + 1
            Loop
            cbProductID.SelectedIndex = 0
        Else
        End If
        mDataSet = Nothing

    End Sub
    Private Sub frmrptDepHighwayTotalOfMonth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MVDate.Value = String.Format("{0:dd/MM/yyyy}", Date.Now)
        InitialCombo()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        'frmrptShowReport.ValueParameter = 2
        'frmrptShowReport.mstrQuery = strQuery
        ''frmrptShowReport.mParameter = Format(MVDate.Value, "MM/yyyy")
        'frmrptShowReport.mRptFileName = "Government Loading Report Monthly.rpt"
        'frmrptShowReport.Show()
        With frmrptMainShow
            .report_id = "52010050"
            .sql_query = GetSqlQuery()
            .param1 = Format(MVDate.Value, "MM/yyyy")
            .Show()
        End With

    End Sub
    Private Function GetSqlQuery() As String
        Dim vSql As String
        If cbProductID.Text <> "" Then
            sProduct = Split(cbProductID.Text, " ")
            sCode = sProduct(0)
            If rType1.Checked = True Then
                rType = 1
            Else
                rType = 0
            End If
        Else
            MsgBox("คุณยังไม่ได้เลือก Product !", vbCritical)
        End If
        vSql = " SELECT EOD_DATE, SALE_PRODUCT_ID, SALE_PRODUCT_NAME, COMPARTMENT_NO, METER_NO, DESITY15C, BASE_PRODUCT_ID, BASE_PRODUCT_NAME, SALE_PRODUCT_CODE, SALE_DESCRIPTION, LOAD_HEADER_NO, CUSTOMER_CODE, DO_NO, CUSTOMER_NAME, SHIPTO_NAME, SHIPTO_CONTRACT, SHIPTO_TOPROJECT, GOV_PROJECT, DRIVER_ID, DRIVER_NAME, VEHICLE, SEAL_NUMBER, T_BAY, T_COMPLETE, T_WEIGHTIN, T_WEIGHTOUT, WEIGHT_OUT, WEIGHT_IN, WEIGHT_NET, WEIGHT_NET_TON, TANK_ID, TANK_NAME, ADVICE, LOADED_GROSS, LOADED_NET, LOADED_VOLOBS, LOADED_VOL30C, LOADED_MASS, TEMP " &
                " FROM RPT.VIEW_LOAD_MASS_REPORT_DAILY " &
                " where sale_product_id='" & sCode & "' " &
                " and gov_project=" & rType & " " &
                " And to_char(EOD_DATE,'MM/YYYY') = '" & Format(MVDate.Value, "MM/yyyy") & "' " &
                " order by load_header_no"
        Return vSql
    End Function
End Class