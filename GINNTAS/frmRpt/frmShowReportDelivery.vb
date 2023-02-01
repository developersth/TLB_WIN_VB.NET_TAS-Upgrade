Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Drawing.Printing

Public Class frmShowReportDelivery
    Public strSQL As String
    Public rpFileName As String
    Public mRptFileName As String
    Public Load_NO As String
    Private Sub frmShowReportDelivery_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Show_report(strSQL)
    End Sub
    Private Sub Show_report(strSQL As String)
        Dim SApp_Path As String = App_Path()
        Dim mDataSet As New DataSet
        Dim i As Integer = 0
        Dim dt As DataTable
        If Oradb.OpenDys(strSQL, "VIEW_DELIV_HEADER", mDataSet) Then
            dt = mDataSet.Tables("VIEW_DELIV_HEADER")
            If dt.Rows.Count > 0 Then
                Dim rpt As New ReportDocument
                rpFileName = SApp_Path & "\Report Files\" & mRptFileName
                rpt.Load(rpFileName)
                rpt.SetDatabaseLogon("tas", "tam")
                rpt.Database.Tables("VIEW_DELIV_HEADER").SetDataSource(dt)
                rpt.SetParameterValue(0, Load_NO)
                CrystalReportViewer1.ReportSource = dt
                CrystalReportViewer1.Refresh()
            End If
        End If
        mDataSet = Nothing
    End Sub
    Public Function App_Path() As String
        App_Path = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
    End Function
End Class