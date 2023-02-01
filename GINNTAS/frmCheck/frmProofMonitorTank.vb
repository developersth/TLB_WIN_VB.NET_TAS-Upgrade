Imports Oracle.DataAccess.Client
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.ReportingServices.Rendering.ExcelRenderer.Excel

Public Class frmProofMonitorTank
    Public FormScreenID As Long
    Dim Row_New As Integer
    Dim Row_Old As Integer
    Dim GetLevelValues As String
    Private Sub frmProofMonitorTank_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmProofMonitorTank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oldMeH = Me.Size.Height
        Dim oleMeW = Me.Size.Width
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        Clear_frm()
        Initial_frm()
        resolution(Me, 1)
        Me.MSGridTank.ClearSelection()

    End Sub

    Private Sub frmProofMonitorTank_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub

    Private Sub Initial_frm()
        InitialCombo()
        Timer1.Start()
        Timer2.Start()
        ShowFlexGrid(cbProduct.Text, cbType.Text)
    End Sub

    Private Sub b_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub


    Private Sub DataGridView_Headers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim strColume As String
        If MSGridTank.Rows.Count <= 0 Or MSGridTank.CurrentRow.Index < 0 Then Exit Sub
        With MSGridTank
            strColume = .Item(0, .CurrentRow.Index).Value
            'Call ShowtoMSGridLines(strColume)
        End With
    End Sub

    Private Sub InitialCombo()
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim sql_str As String
        Dim i As Long
        sql_str = " select BASE_PRODUCT_ID " & _
                    " from BASE_PRODUCT " & _
                    " group by BASE_PRODUCT_ID"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            cbProduct.Items.Add("ALL")
            Do While dt.Rows.Count > i
                cbProduct.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("BASE_PRODUCT_ID")), "", dt.Rows(i).Item("BASE_PRODUCT_ID").ToString))

                i = i + 1
            Loop
            i = i + 1
            'Usecb = True
            cbProduct.SelectedIndex = 0
            cbType.Items.Add("ALL")
            cbType.Items.Add("ถังรับ")
            cbType.Items.Add("ถังจ่าย")
            'Usecb = True
            cbType.SelectedIndex = 2
            'Usecb = False
        End If
    End Sub
    Private Sub ShowFlexGrid(product As String, tanktype As String)
        Dim sql_str As String
        sql_str = _
                  "select  *  from view_monitor_tank  t  "

        If product = "ALL" And tanktype = "ALL" Then
            sql_str = sql_str & " Order by  T.TANK_NAME"
        Else
            If product <> "ALL" And tanktype <> "ALL" Then
                sql_str = sql_str & "where T.base_product= '" & product & "'" & _
                                               "and t.DESCRIPTION= '" & tanktype & "'" & _
                                               " Order by T.TANK_NAME"
            End If

            If product <> "ALL" And tanktype = "ALL" Then
                sql_str = sql_str & "where T.base_product= '" & product & "'" & _
                                         " Order by T.TANK_NAME"
            End If

            If product = "ALL" And tanktype <> "ALL" Then
                sql_str = sql_str & "where t.DESCRIPTION= '" & tanktype & "'" & _
                                         " Order by T.TANK_NAME"
            End If

        End If

        Call Show_Data(sql_str)
    End Sub
    Public Sub Show_Data(sql_str As String)
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i, j, k As Integer
        Dim tanktype As String
        Dim Status As Long

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            j = 0
            k = 0
            MSGridTank.RowCount = 0
            Me.MSGridTank.Columns("Column10").Visible = False
            Me.MSGridTank.Columns("Column14").Visible = False
            Me.MSGridTank.Columns("Column16").Visible = False
            Me.MSGridTank.Columns("Column17").Visible = False
            Me.MSGridTank.Columns("Column20").Visible = False

            lbl_rec.Text = dt.Rows.Count
            Do While dt.Rows.Count > i

                MSGridTank.RowCount = MSGridTank.RowCount + 1
                MSGridTank.Rows.Item(i).Height = Grid_Height
                Status = IIf(IsDBNull(dt.Rows(i).Item("CONNECT_STATUS")), "", dt.Rows(i).Item("CONNECT_STATUS"))
                MSGridTank.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TANK_NAME")), "", dt.Rows(i).Item("TANK_NAME").ToString)
                MSGridTank.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("BASE_PRODUCT")), "", dt.Rows(i).Item("BASE_PRODUCT").ToString)
                If IsDBNull(dt.Rows(i).Item("COLOR_CODE")) Then
                    MSGridTank.Item(2, i).Value = 0
                    MSGridTank.Item(2, i).Style.BackColor = Color.Black
                Else
                    Dim colour As String
                    colour = dt.Rows(i).Item("COLOR_CODE").ToString()
                    MSGridTank.Item(2, i).Value = appendZero(Hex(colour).ToString())
                    MSGridTank.Item(2, i).Style.BackColor = ColorTranslator.FromHtml("#" + appendZero(Hex(colour).ToString()))
                End If
                tanktype = IIf(IsDBNull(dt.Rows(i).Item("TANK_TYPE")), "", dt.Rows(i).Item("TANK_TYPE"))
                MSGridTank.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION").ToString)
                If Trim(tanktype) = "L" Then 'ถังจ่ายสีแดง
                    j = j + 1
                    For z = 0 To MSGridTank.Columns.Count - 1
                        MSGridTank.Rows(i).Cells(z).Style.ForeColor = Color.Red
                    Next
                    GetLevel()
                    If Math.Abs((Val(dt.Rows(i).Item("LEVELS")) - Val(GetLevelValues))) <= 1 Then
                        If vCheckAlarmTank = False And dt.Rows(i).Item("TANK_NAME").ToString <> vTankName Then
                            SetAlarmLevels("เกิด Alarm ระดับน้ำมันของ Tank " & dt.Rows(i).Item("TANK_NAME").ToString & " มีปริมาณ=" & dt.Rows(i).Item("LEVELS") & " ไกล้เคียงหรือเท่ากับที่ตั้งไว้=" & GetLevelValues)
                            vCheckAlarmTank = True
                            vTankName = dt.Rows(i).Item("TANK_NAME").ToString
                            INSERT_ALARM_TANK(vTankName)
                        End If
                    End If
                Else
                    k = k + 1
                    For z = 0 To MSGridTank.Columns.Count - 1
                        MSGridTank.Rows(i).Cells(z).Style.ForeColor = Color.Black
                    Next
                End If
                If Status <> 0 Then
                    MSGridTank.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LEVELS")), "", dt.Rows(i).Item("LEVELS").ToString)
                    MSGridTank.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DEN15C")), "", Format(Val(dt.Rows(i).Item("DEN15C")), "####.#"))
                    MSGridTank.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TEMP")), "", Format(Val(dt.Rows(i).Item("TEMP")), "####.#"))
                    MSGridTank.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("VCF30C")), "", dt.Rows(i).Item("VCF30C").ToString)
                    MSGridTank.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("COQ_NO")), "", dt.Rows(i).Item("COQ_NO").ToString)
                    MSGridTank.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LEVEL_HH")), "", dt.Rows(i).Item("LEVEL_HH").ToString)
                    MSGridTank.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LEVEL_LL")), "", dt.Rows(i).Item("LEVEL_LL").ToString)
                    MSGridTank.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LEVEL_H")), "", dt.Rows(i).Item("LEVEL_H").ToString)
                    MSGridTank.Item(12, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LEVEL_L")), "", dt.Rows(i).Item("LEVEL_L").ToString)
                    MSGridTank.Item(13, i).Value = IIf(IsDBNull(dt.Rows(i).Item("WIA")), "", dt.Rows(i).Item("WIA").ToString)
                    MSGridTank.Item(14, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TANK_CAPACITY")), "", dt.Rows(i).Item("TANK_CAPACITY").ToString)
                    MSGridTank.Item(15, i).Value = IIf(IsDBNull(dt.Rows(i).Item("FWL")), "", dt.Rows(i).Item("FWL").ToString)
                    MSGridTank.Item(16, i).Value = IIf(IsDBNull(dt.Rows(i).Item("GROSS")), "", dt.Rows(i).Item("GROSS").ToString)
                    MSGridTank.Item(17, i).Value = IIf(IsDBNull(dt.Rows(i).Item("NET")), "", dt.Rows(i).Item("NET"))
                    MSGridTank.Item(18, i).Value = IIf(IsDBNull(dt.Rows(i).Item("AVARIABLE")), "", dt.Rows(i).Item("AVARIABLE").ToString)
                    MSGridTank.Item(19, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ROOM")), "", dt.Rows(i).Item("ROOM").ToString)
                    If dt.Rows(i).Item("IS_ENABLED") = 1 Then
                        Dim Alarm As String
                        If dt.Rows(i).Item("TANK_HIGH") <> 0 Then
                            Select Case 1
                                Case Val(dt.Rows(i).Item("ALARM_LEVEL_HH"))
                                    Alarm = "ระดับน้ำมันสูงมาก"
                                Case Val(dt.Rows(i).Item("ALARM_LEVEL_LL"))
                                    Alarm = "ระดับน้ำมันต่ำมาก"
                                Case Val(dt.Rows(i).Item("ALARM_LEVEL_H"))
                                    Alarm = "ระดับน้ำมันสูง"
                                Case Val(dt.Rows(i).Item("ALARM_LEVEL_L"))
                                    Alarm = "ระดับน้ำมันต่ำ"
                                Case Else
                                    Alarm = "ไม่มีสัญญาณเตือน"
                            End Select
                        Else
                            Alarm = ""
                        End If
                        MSGridTank.Item(20, i).Value = Alarm
                    End If
                Else
                    MSGridTank.Item(4, i).Value = "??????"
                    MSGridTank.Item(5, i).Value = "??????"
                    MSGridTank.Item(6, i).Value = "??????"
                    MSGridTank.Item(7, i).Value = "??????"
                    MSGridTank.Item(8, i).Value = "??????"
                    MSGridTank.Item(9, i).Value = "??????"
                    MSGridTank.Item(10, i).Value = "??????"
                    MSGridTank.Item(11, i).Value = "??????"
                    MSGridTank.Item(13, i).Value = "??????"
                    MSGridTank.Item(14, i).Value = "??????"
                    MSGridTank.Item(15, i).Value = "??????"
                    MSGridTank.Item(16, i).Value = "??????"
                    MSGridTank.Item(17, i).Value = "??????"
                    MSGridTank.Item(18, i).Value = "??????"
                    MSGridTank.Item(19, i).Value = "??????"
                    MSGridTank.Item(20, i).Value = "??????"
                End If


                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub
    Function INSERT_ALARM_TANK(ByVal iTankName) As Boolean
        Dim sql_str As String
        INSERT_ALARM_TANK = False
        sql_str = _
            "insert into tas.tank_level_alarm values('" & iTankName & "','1')"
        If Oradb.ExeSQL(sql_str) Then
            INSERT_ALARM_TANK = True
        End If
    End Function
    Public Function App_Path() As String
        App_Path = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
    End Function

    Function GetLevel()
        Dim strSQL As String
        strSQL = "begin TAS.P_GET_TAS_CONFIG(38,:RET_VALUES);end;"

        Dim Oraparam As New COraParameter
        With Oraparam
            .CreateOracleParamOutput("RET_VALUES", COracle._OracleDbType.OraInt32)
        End With

        Dim bRet As Boolean = False
        If Oradb.ExeSQL(strSQL, Oraparam) Then
            GetLevelValues = Oraparam.GetOraclParamValue("RET_VALUES").ToString
           
        End If
    End Function
    
    Function SetAlarmLevels(jMSG As String)
        Dim sql_str As String
        sql_str = _
               "begin TAS.ADD_JOURNAL(1" & _
               ",7101,700" & _
               ",tas.system_user,tas.server_name" & _
               " ,7007101" & _
               ",substr('" & jMSG & "',1,40)" & _
               ",substr('" & jMSG & "',41,80)" & _
              " ,substr('" & jMSG & "',121,40));end;"
        If Oradb.ExeSQL(sql_str) Then

        End If
    End Function
    Private Function appendZero(ByVal codeColour As String) As String
        Dim i As Integer = 6 - codeColour.Length
        While (i <> 0)
            codeColour = "0" + codeColour
            i = i - 1
        End While
        Return codeColour
    End Function
    Private Sub Clear_frm()
        lbl_rec.Text = 0
    End Sub

    Private Sub UcMenuRefresh_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuRefresh.OnClickMnuText
        ShowFlexGrid(cbProduct.Text, cbType.Text)
        MSGridTank.ClearSelection()
    End Sub

    Private Sub cbProduct_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbProduct.SelectedIndexChanged
        ShowFlexGrid(cbProduct.Text, cbType.Text)
        MSGridTank.ClearSelection()
    End Sub

    Private Sub cbType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbType.SelectedIndexChanged
        ShowFlexGrid(cbProduct.Text, cbType.Text)
        MSGridTank.ClearSelection()
    End Sub
    Private Sub UcHeader1_CloseButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.CloseButtonClick
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UcHeader1_MinimizeButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.MinimizeButtonClick
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub UcBack1_Click(sender As Object, e As EventArgs) Handles UcBack1.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UcBack1_MouseHover(sender As Object, e As EventArgs) Handles UcBack1.MouseHover
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("Back1")
    End Sub

    Private Sub UcBack1_MouseLeave(sender As Object, e As EventArgs) Handles UcBack1.MouseLeave
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("back")
    End Sub

    Private Sub Export_Excel()
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim vFileTime As String
        Dim vFileDate As String
        Dim i As Integer
        Dim j As Integer
        vFileTime = Format(Now, "Hmmss")
        vFileDate = Format(Date.Now, "ddMMyyyy")
        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        For i = 0 To MSGridTank.RowCount - 1
            For j = 0 To MSGridTank.ColumnCount - 1
                For k As Integer = 1 To MSGridTank.Columns.Count
                    xlWorkSheet.Cells(1, k) = MSGridTank.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = MSGridTank(j, i).Value.ToString()
                Next
            Next
        Next
        Try
            xlWorkSheet.SaveAs(Path.GetTempPath() & vFileDate & "_" & vFileTime & ".xlsx")
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
            'MsgBox("You can find the file D:\excel\vbexcel.xlsx")

            Process.Start(Path.GetTempPath() & vFileDate & "_" & vFileTime & ".xlsx")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub DATAGRIDVIEW_TO_EXCEL(ByVal DGV As DataGridView)
        Try
            Dim DTB = New DataTable, RWS As Integer, CLS As Integer

            For CLS = 0 To 13 - 1 ' COLUMNS OF DTB
                DTB.Columns.Add(DGV.Columns(CLS).HeaderText.ToString)
            Next

            Dim DRW As DataRow

            For RWS = 0 To 13 - 1 ' FILL DTB WITH DATAGRIDVIEW
                DRW = DTB.NewRow

                For CLS = 0 To 13 - 1
                    Try
                        DRW(DTB.Columns(CLS).ColumnName.ToString) = DGV.Rows(RWS).Cells(CLS).Value.ToString
                    Catch ex As Exception

                    End Try
                Next

                DTB.Rows.Add(DRW)
            Next

            DTB.AcceptChanges()

            Dim DST As New DataSet
            DST.Tables.Add(DTB)
            Dim FLE As String = "D:\excel\XML.xml" ' PATH AND FILE NAME WHERE THE XML WIL BE CREATED (EXEMPLE: C:\REPS\XML.xml)
            DTB.WriteXml(FLE)
            Dim EXL As String = "D:\excel\EXCEL.EXE" ' PATH OF/ EXCEL.EXE IN YOUR MICROSOFT OFFICE
            Shell(Chr(34) & EXL & Chr(34) & " " & Chr(34) & FLE & Chr(34), vbNormalFocus) ' OPEN XML WITH EXCEL

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UcMenutxtPrint_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenutxtPrint.OnClickMnuText
        'DATAGRIDVIEW_TO_EXCEL((MSGridTank)) ' THIS PARAMETER IS YOUR DATAGRIDVIEW
        Export_Excel()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Me.ShowFlexGrid(cbProduct.Text, cbType.Text)
        MSGridTank.ClearSelection()
    End Sub

    Private Sub MSGridTank_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MSGridTank.CellClick
        If e.RowIndex >= 0 Then
            Row_New = MSGridTank.CurrentRow.Index
            Call PainSelGrid(Row_New, MSGridTank)
        End If
    End Sub
    Private Sub PainSelGrid(ByVal iRow_new As Integer, ByVal iMsgrid As DataGridView)
        Dim i As Integer
        If iRow_new = 0 Then Exit Sub
        With iMsgrid
            If Row_Old <> 0 Then
                For i = 0 To iMsgrid.ColumnCount - 1
                    'iMsgrid.Item(i, Row_Old).Style.BackColor = Color.White

                Next i
            End If
            For i = 0 To iMsgrid.ColumnCount - 1
                'iMsgrid.Item(i, Row_Old).Style.BackColor = Color.Yellow
            Next i
            Row_Old = iRow_new
        End With
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim sql_str As String
        sql_str = _
        "select t.* from tank_level_alarm t"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                UcFooter1.PlaySound()
            Else
                UcFooter1.StopSound()
            End If
        Else
            UcFooter1.StopSound()
        End If
        mDataSet = Nothing
    End Sub
End Class