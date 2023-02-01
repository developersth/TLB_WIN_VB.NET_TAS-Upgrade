Imports CrystalDecisions.CrystalReports.Engine

Public Class frmrptMainShow
    Public load_no As String
    Public report_id As String
    Public param1 As String
    Public param2 As String
    Public param3 As String
    Public sql_query As String

    Private Sub frmrptMainShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitailReport(report_id)
    End Sub
    Private Sub InitailReport(ByVal iReport_ID As String)
        Dim rpt As New ReportDocument
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim rptFileName As String
        Dim path As String = GetAppPath()
        path = path & "\Report Files\"
        rptFileName = path & GetReportFileName(iReport_ID)
        Try
            Select Case iReport_ID
                'ใบแนะนำการเติม
                Case Is = "52010062"
                    dt = CRService.VIEW_LOADING_INTRODUCTION_TM(load_no)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, CType(load_no, Integer))

                'ใบกำกับการขนส่ง
                Case Is = "52010040"
                    dt = CRService.VIEW_DELIV_HEADER(load_no)
                    Dim dtLine As DataTable = CRService.VIEW_DELIV_LINE(load_no)
                    Dim dtSumLine As DataTable = CRService.VIEW_DELIV_SUM_LINE(load_no)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.Subreports(0).SetDataSource(dtLine)
                    rpt.Subreports(1).SetDataSource(dtSumLine)
                    rpt.SetParameterValue(0, CType(load_no, Integer))
                    dtLine.Dispose()
                    dtSumLine.Dispose()

               'เอกสารแนบ
                Case Is = "52010057"
                    dt = CRService.VIEW_GOV_PROJECT_ATTACHAS(load_no)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, CType(load_no, Integer))

                'รายงานการจ่ายทางรถบรรทุก
                Case Is = "52010007"
                    dt = CRService.DAILY_LOADING_DETAIL(load_no)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, CType(load_no, Integer))

                'การจ่ายกับกรมทางหลวงเรียงตามบริษัทประจำวัน
                Case Is = "52010049"
                    dt = CRService.Query_TBL(sql_query)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, param1)

                'การจ่ายกับกรมทางหลวงทั้งหมดประจำวัน
                Case Is = "52010059"
                    dt = CRService.Query_TBL(sql_query)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, param1)

                'การจ่ายกับกรมทางหลวงทั้งหมดประจำเดือน
                Case Is = "52010050"
                    dt = CRService.Query_TBL(sql_query)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    Dim expenddt As Date = Date.ParseExact(param1, "MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
                    rpt.SetParameterValue(0, expenddt)

               '******************* End OF Day***********************************
               'Volume Load Report By Product
                Case Is = "52010042"
                    dt = CRService.VIEW_LOAD_VOLUME_REPORT_DAILY(param1)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, param1)

                'Mass Load Report By Product
                Case Is = "52010043"
                    dt = CRService.VIEW_LOAD_MASS_REPORT_DAILY_END_OFF_DAY(param1)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, param1)

              'Volume Load Report By Company
                Case Is = "52010044"
                    dt = CRService.VIEW_LOAD_VOLUME_REPORT_DAILY(param1)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, param1)

               'Mass Load Report By Company
                Case Is = "52010045"
                    dt = CRService.VIEW_LOAD_MASS_REPORT_DAILY_END_OFF_DAY(param1)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, param1)

                'Summary Load Report By Company
                Case Is = "52010046"
                    dt = CRService.VIEW_LOAD_VOLUME_REPORT_DAILY(param1)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, param1)

                'Summary Mass LoadReport By Company
                Case Is = "52010047"
                    dt = CRService.VIEW_LOAD_MASS_REPORT_DAILY_END_OFF_DAY(param1)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, param1)
                    '*************************************************************

                'รายงานค่ามิเตอร์ประจำวัน
                Case Is = "52010008"
                    dt = CRService.VIEW_DATA_METER(param1)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, param1)

                'รายงาน Meter Throughput
                Case Is = "52010009"
                    dt = CRService.Query_TBL(sql_query)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, param1)

                'รายงาน ใบชั่งน้ำหนัก
                Case Is = "52010031"
                    dt = CRService.VIEW_DATA_WEIGHT(load_no)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, CType(load_no, Integer))

                'รายงานสรุปการจ่ายแยกตามผลิตภัณฑ์ประจำเดือน
                Case Is = "52010013"
                    dt = CRService.VIEW_DATA_LOADING_MONTHLY(param1, param2)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue("BaseProductID", param2)

               'รายงานสรุปการจ่ายแยกตามผลิตภัณฑ์ประจำปี
                Case Is = "52010016"
                    dt = CRService.VIEW_DATA_LOADING_YEARLY(param1, param2)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue("BaseProductID", param2)

                'รายงานการจ่ายผลิตภัณฑ์ตามมิเตอร์,ถัง
                Case Is = "52010055"
                    dt = CRService.VIEW_LOAD_REPORT_TANK_METER(param1)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, param1)

                'รายงานการจ่ายผลิตภัณฑ์ตามมิเตอร์,ถัง
                Case Is = "52010056"
                    dt = CRService.VIEW_LOAD_REPORT_TANK_METER(param1)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, param1)

                'รายงานสรุปการจ่ายผลิตภัณฑ์ประจำเดือน(Mass)
                Case Is = "52010051"
                    dt = CRService.VIEW_LOAD_MASS_REPORT_DAILY_MONTHLY(param1)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, param1)

               'รายงานสรุปการจ่ายผลิตภัณฑ์ประจำเดือน(Volume)
                Case Is = "52010052"
                    dt = CRService.VIEW_LOAD_VOLUME_REPORT_DAILY_MONTHLY(param1)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, param1)

                'รายงานสรุปการจ่ายผลิตภัณฑ์ประจำปี(Mass)
                Case Is = "52010053"
                    dt = CRService.VIEW_LOAD_MASS_REPORT_DAILY_YEARLY(param1)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    Dim expenddt As Date = Date.ParseExact(param1, "yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
                    rpt.SetParameterValue(0, expenddt)

               'รายงานสรุปการจ่ายผลิตภัณฑ์ประจำปี(Volume)
                Case Is = "52010054"
                    dt = CRService.VIEW_LOAD_VOLUME_REPORT_DAILY_YEARLY(param1)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    Dim expenddt As Date = Date.ParseExact(param1, "yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
                    rpt.SetParameterValue(0, expenddt)


                'รายงานสถานะเปิดของถังประจำวัน
                Case Is = "52010010"
                    dt = CRService.VIEW_DATA_TANK(param1)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, param1)

                'รายงานสถานะปิดของถังประจำวัน
                Case Is = "52010019"
                    dt = CRService.VIEW_DATA_TANK(param1)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)
                    rpt.SetParameterValue(0, param1)

                'UserSecurityPermit
                Case Is = "52010061"
                    dt = CRService.VIEW_USER_SECURITY_PERMISSION(param1)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)

              'MonitorMeter
                Case Is = "52010030"
                    dt = CRService.VIEW_MONITOR_METER(sql_query)
                    rpt.Load(rptFileName)
                    rpt.SetDataSource(dt)


            End Select
            'Show Report CrystalReportViewer
            CrysRPTViewer.ReportSource = rpt
            CrysRPTViewer.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            CrysRPTViewer = Nothing
            rpt = Nothing
            dt = Nothing
        End Try
    End Sub
End Class