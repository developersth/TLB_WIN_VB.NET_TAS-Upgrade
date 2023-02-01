Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Drawing.Printing
Public Class frmrptDepHighwayTotal
    Private Sub InitialCombo()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "select t.sale_product_id,t.sale_product_id||' '||t.sale_product_code as sale_product from sale_product t order by t.sale_product_code"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            cbProduct.Text = ""
            Do While dt.Rows.Count > i
                cbProduct.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("sale_product")), "", dt.Rows(i).Item("sale_product").ToString))
                i = i + 1
            Loop
            cbProduct.SelectedIndex = 5
        Else
        End If
        mDataSet = Nothing

    End Sub

    Private Sub frmrptDepHighwayTotal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitialCombo()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        With frmrptMainShow
            .report_id = "52010059"
            .sql_query = Get_Sql_Query()
            .param1 = MVDate.SelectionStart()
            .Show()
        End With

        'frmrptShowReport.ValueParameter = 2
        'frmrptShowReport.mstrQuery = strQuery
        'frmrptShowReport.mParameter = MVDate.SelectionStart()
        'frmrptShowReport.mRptFileName = "Government Loading Report.rpt"
        'frmrptShowReport.Show()
    End Sub

    Private Function Get_Sql_Query() As String
        Dim sProduct() As String, sCode As String
        Dim rType As Long
        Dim vSql As String
        If cbProduct.Text <> "" Then
            sProduct = Split(cbProduct.Text, " ")
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
                  " and to_date(eod_date) =to_date('" & MVDate.SelectionRange.Start() & "','dd/mm/yyyy') " &
                  " order by customer_code,load_header_no"
        Return vSql
    End Function
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If MsgBox("ท่านต้องการพิมพ์รายงานทางหลวงทั้งหมด หรือไม่", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If
        DirectPrinter("52010059", Get_Sql_Query, MVDate.SelectionRange.Start())
    End Sub
    Private Sub DirectPrint(iRptFileName As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim rpt As New ReportDocument
        Dim rpFileName As String
        Dim SApp_Path As String = App_Path()
        Dim Str As String = ""
        Dim PrinterName As String
        rpFileName = SApp_Path & "\Report Files\" & iRptFileName
        PrinterName = GetPrinterName()

        Dim sProduct() As String, sCode As String
        Dim rType As Long
        If cbProduct.Text <> "" Then
            sProduct = Split(cbProduct.Text, " ")
            sCode = sProduct(0)
            If rType1.Checked = True Then
                rType = 1
            Else
                rType = 0
            End If
        Else
            MsgBox("คุณยังไม่ได้เลือก Product !", vbCritical)
        End If

        sql_str = "select * " &
                        "from rpt.view_load_mass_report_daily " &
                        "where sale_product_id='" & sCode & "' " &
                        "and gov_project=" & rType & " " &
                        "and to_date(eod_date) =to_date('" & MVDate.SelectionRange.Start() & "','dd/mm/yyyy') " &
                        "order by customer_code,load_header_no"
        Try
            If Oradb.OpenDys(sql_str, "view_load_mass_report_daily", mDataSet) Then
                dt = mDataSet.Tables("view_load_mass_report_daily")
                If dt.Rows.Count > 0 Then
                    rpt.Load(rpFileName)
                    rpt.SetDataSource(dt)
                    'rpt.SetDatabaseLogon("tas", "tam")
                    rpt.SetParameterValue(0, MVDate.SelectionStart())
                    rpt.PrintOptions.PrinterName = PrinterName
                    rpt.PrintToPrinter(1, False, 0, 0)
                    rpt.Dispose()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด " & ex.Message)
        End Try

        mDataSet = Nothing
    End Sub
    Function GetPrinterName() As String
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        GetPrinterName = ""
        sql_str = "select t.*, rt.*" +
                                    " from tas.VIEW_REPORT_PARA_CONFIG t, tas.PRINTER_TAS rt " +
                                    " where t.PRINTER_ID= rt.PRINTER_ID" +
                                    " and t.Report_ID= 52010059"
        If Oradb.OpenDys(sql_str, "tbName", mDataSet) Then
            dt = mDataSet.Tables("tbName")
            If dt.Rows.Count > 0 Then
                GetPrinterName = dt.Rows(0)("PRINTER_NAME").ToString()
            End If
        End If
    End Function
    Public Function App_Path() As String
        App_Path = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
    End Function
End Class