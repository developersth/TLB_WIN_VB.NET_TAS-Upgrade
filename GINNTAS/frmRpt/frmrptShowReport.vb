Imports System.Runtime.InteropServices
Imports System.IO
Imports System.IO.Ports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Drawing.Printing
Imports System.Data
Imports Oracle.ManagedDataAccess.Client ' ODP.NET Oracle managed provider
Imports System.Threading
Public Class frmrptShowReport
    'Public LoadNo As String

    Public mParameter As String
    Public mRptFileName As String
    Public mstrQuery As String
    Public mparaProductID As String
    'ตรวจสอบค่า parameter มากว่า 1 parameter  0=parameter 1 ตัว, 1=parameter 2 ตัว, 3=parameter 2 ตัว และ strquery
    Public ValueParameter As Long = 0
    'Dim Oradb As New COracle
    'Dim conn As New OracleConnection
    Dim cryRpt As New ReportDocument
    Dim crtableLogoninfos As New TableLogOnInfos
    Dim crtableLogoninfo As New TableLogOnInfo
    Dim crConnectionInfo As New ConnectionInfo
    Dim CrTables As Tables
    Dim CrTable As Table
    Dim mRptUserID As String = "tas"
    Dim mRptPsw As String = "tam"
    Dim mRptServerName As String = "LLAS"
    Dim mRptServerNameDt As String = oraServer

    Private Sub frmrptShowReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "# Show Report #"
        If (ValueParameter = 2) Then 'ตรวจสอบค่า parameter 2 คือพารามิเตอร์และสตริงคิวรี่ข้อมูล
            ShowReportParaQuery()
        Else
            ShowReportParameter()
        End If
    End Sub

    Private Sub ShowReport()
        Dim rpFileName As String
        Dim SApp_Path As String = App_Path()
        Dim Str As String = ""
        'Dim getStr() As String = Split(SApp_Path, "\")
        'For i = 0 To getStr.Length - 3
        '    Str = Str & getStr(i) & "\"
        'Next
        'rpFileName = Str & "\Report Files\" & NameReport
        Try
            With crConnectionInfo
                .ServerName = mRptServerName
                '.DatabaseName = ""
                .UserID = mRptUserID
                .Password = mRptPsw
            End With
            rpFileName = SApp_Path & "\Report Files\" & mRptFileName
            cryRpt.Load(rpFileName)
            CrTables = cryRpt.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next

            CrystalReportViewer1.ReportSource = cryRpt
            'ตรวจสอบค่าพารามิเตอร์ที่ส่งเข้ามา
            If (ValueParameter <> 0) Then
                cryRpt.SetParameterValue(0, mParameter)
                cryRpt.SetParameterValue(1, mparaProductID)
            Else
                cryRpt.SetParameterValue(0, mParameter)
            End If
            ' CrystalReportViewer1.Zoom(2)
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            CrystalReportViewer1 = Nothing
        End Try
        'CrystalReportViewer1.Dispose()
    End Sub

    Private Sub ShowReportParaQuery()
        Dim objConn As New OracleConnection
        Dim objCmd As New OracleCommand
        Dim dtAdapter As New OracleDataAdapter
        Dim ds As New DataSet
        Dim strConnString As String
        Dim rpFileName As String
        Dim SApp_Path As String = App_Path()
        Dim Str As String = ""
    
        'Dim getStr() As String = Split(SApp_Path, "\")
        'For i = 0 To getStr.Length - 3
        '    Str = Str & getStr(i) & "\"
        'Next
        rpFileName = SApp_Path & "\Report Files\" & mRptFileName

        'strConnString = "data source=LLAS;user id=TAS;password=GTAS;"
        strConnString = "data source=" & mRptServerNameDt & ";user id=" & mRptUserID & ";password=" & mRptPsw
        objConn.ConnectionString = strConnString

        Try
            'With objCmd
            '    .Connection = objConn
            '    .CommandText = mstrQuery
            '    .CommandType = CommandType.Text
            'End With

            'dtAdapter.SelectCommand = objCmd
            'dtAdapter.Fill(ds, "TableName1")
            'dt = ds.Tables(0)

            'rpt.Load(rpFileName)
            '' rpt.SetDatabaseLogon("tas", "tam")
            'rpt.SetDataSource(dt)

            'Thread.Sleep(800)
            'If mParameter <> "" Then
            '    rpt.SetParameterValue(0, mParameter)
            'End If
            'rpt.Refresh()
            Dim rpt As New ReportDocument
            Dim mDataSet As New DataSet
            Dim dt As DataTable
            If Oradb.OpenDys(mstrQuery, "tableName", mDataSet) Then
                dt = mDataSet.Tables("tableName")
                rpt.Load(rpFileName)
                rpt.SetDataSource(dt)
                If mParameter <> "" Then
                    rpt.SetParameterValue(0, mParameter)
                End If
                CrystalReportViewer1.ReportSource = rpt
                CrystalReportViewer1.Zoom(2)
                CrystalReportViewer1.Refresh()

            End If
            'CrystalReportViewer1.ReportSource = rpt
            'Me.CrystalReportViewer1.Refresh()


            dtAdapter = Nothing
            objConn.Close()
            objConn = Nothing
            CrystalReportViewer1 = Nothing
        Catch ex As Exception
            dtAdapter = Nothing
            objConn.Close()
            objConn = Nothing
            CrystalReportViewer1 = Nothing
        End Try
      
    End Sub
    Public Function App_Path() As String
        App_Path = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
        'Return GetCurrDirectory()
    End Function
    Private Sub ShowReportParameter()
        Dim rpt As New ReportDocument
        Dim mDataSet As New DataSet
        Dim rpFileName As String
        Dim SApp_Path As String = App_Path()


        rpFileName = SApp_Path & "\Report Files\" & mRptFileName
        rpt.Load(rpFileName)
        rpt.SetDatabaseLogon(mRptUserID, mRptPsw)
        If (ValueParameter <> 0) Then
            rpt.SetParameterValue(0, mParameter)
            rpt.SetParameterValue(1, mparaProductID)
        Else
            rpt.SetParameterValue(0, mParameter)
        End If
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1 = Nothing
    End Sub

End Class