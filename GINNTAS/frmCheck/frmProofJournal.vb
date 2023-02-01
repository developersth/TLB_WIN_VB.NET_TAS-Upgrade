Imports Oracle.DataAccess.Client
Imports System.Data
Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Text


Public Class frmProofJournal
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=add ,2=Edit
    Dim rowSelect As Integer = -1
    Dim FlNm As String
    Private Sub frmProofJournal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmProofJournal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        Initial_frm()
        InitialCombobox()
        Show_Data()
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()

    End Sub

    Private Sub frmProofJournal_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub Initial_frm()
        'frm_work = 0
        'MSGridMain.Left = (Me.Width * 8) / 100
        'MSGridMain.Width = Me.Width - (MSGridMain.Left * 3)
        'MSGridMain.Top = 150
        'MSGridMain.Height = (Me.Height / 2) + (MSGridMain.Height / 2)
        'GroupBox1.Height = DataGridView.Height
    End Sub

    Public Sub Show_Data()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str =
              "select * from " &
              "(select t.J_NUMBER as ""Journal No."",t.J_DATE as ""วัน/เวลา"",t.MESSAGE as ""ข้อความ"",t.TYPE1 as ""ประเภท"",t.CATEGORY_NAME " &
              ",t.SOURCE_NAME,t.J_USER as ""ผู้ใช้งาน"",t.J_COMPUTER as ""คอมพิวเตอร์"" " &
               " from view_journal t where t.J_DATE>=to_date('" & Format(dtpFromDate.Value, "dd/MM/yyyy") &
               " " & Format(dtpFromTime.Value, "HH:mm:ss") & "','dd/mm/yyyy hh24:mi:ss') " &
                " and t.J_DATE<=to_date('" & Format(dtpTodate.Value, "dd/MM/yyyy") &
                    " " & Format(dtpToTime.Value, "HH:mm:ss") & "','dd/mm/yyyy hh24:mi:ss') order by t.J_DATE desc) journal " &
                "where rownum <= 1000 "
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView.DataSource = dt
            txtTotalRecord.Text = dt.Rows.Count
            For i = 0 To DataGridView.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = DataGridView.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            SetDataGridViewRowForeColor()
            SetDataGridViewCurrentRowSelection()
        Else
        End If
        mDataSet.Dispose()
        mDataSet = Nothing
        dt = Nothing
    End Sub

    Private Sub DataGridView_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

#Region "Menu Event"
    Private Sub UcClose1_OnClickClose()
        PopForm()
        Me.Close()
    End Sub
#End Region

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            GroupBox1.Visible = True
            chAutoRefresh.CheckState = False
        Else
            GroupBox1.Visible = False
            chAutoRefresh.CheckState = False

        End If
    End Sub

    Private Sub btRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckBox1.Checked = True Then
            ShowDataSearch()
        Else
            Show_Data()
        End If

    End Sub

    Private Sub InitialCombobox()
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim vStrSQL As String

        cbType.Items.Add("")
        cbType.Items.Add("Event")
        cbType.Items.Add("Alarm")

        vStrSQL = "select t.user_id " &
            " from tas.user_tas t order by t.user_id"
        If Oradb.OpenDys(vStrSQL, "TableName", mDataSet) Then
            dt = mDataSet.Tables(0)
            For Each dr As DataRow In dt.Rows
                cbUser.Items.Add(dr.Item("user_id"))
            Next
        End If
        cbUser.Items.Insert(0, "")

        vStrSQL = "select t.COMPUTER_NAME " &
            " from tas.COMPUTER_TAS t order by t.COMPUTER_NAME"
        If Oradb.OpenDys(vStrSQL, "TableName", mDataSet) Then
            dt = mDataSet.Tables(0)
            For Each dr As DataRow In dt.Rows
                cbComputer.Items.Add(dr.Item("COMPUTER_NAME"))
            Next
        End If
        cbComputer.Items.Insert(0, "")

        vStrSQL = "select J.J_CATEGORY,J.CATEGORY_NAME " &
            "from JOURNAL_CATEGORY J " &
            "order by J.J_CATEGORY"
        If Oradb.OpenDys(vStrSQL, "TableName", mDataSet) Then
            dt = mDataSet.Tables(0)
            For Each dr As DataRow In dt.Rows
                cbCategory.Items.Add(dr.Item("CATEGORY_NAME"))
                cbCategoryID.Items.Add(dr.Item("J_CATEGORY"))
            Next
        End If
        cbCategory.Items.Insert(0, "")
        cbCategoryID.Items.Insert(0, "")

        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub

    Private Sub InitialComboSource(ByVal pCategoryID As Long)
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim vStrSQL As String

        Try
            If pCategoryID = 0 Then
                vStrSQL = "select J.J_SOURCE,J.SOURCE_NAME " &
                "from JOURNAL_SOURCE J " &
                "order by J.J_SOURCE"
            Else
                vStrSQL = "select J.J_SOURCE,J.SOURCE_NAME " &
                "from JOURNAL_SOURCE J " &
                "where J.J_CATEGORY= " & pCategoryID & " " &
                "order by J.J_SOURCE"
            End If

            If Oradb.OpenDys(vStrSQL, "TableName", mDataSet) Then
                cbSource.Items.Clear()
                cbSourceID.Items.Clear()
                dt = mDataSet.Tables(0)
                For Each dr As DataRow In dt.Rows
                    cbSource.Items.Add(dr.Item("SOURCE_NAME"))
                    cbSourceID.Items.Add(dr.Item("J_SOURCE"))
                Next

            End If
            cbSource.Items.Insert(0, "")
            cbSourceID.Items.Insert(0, "")

        Catch ex As Exception

        End Try
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub

    Private Sub cbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCategory.SelectedIndexChanged
        If cbCategory.SelectedIndex > -1 Then
            cbCategoryID.SelectedIndex = CType(cbCategory.SelectedIndex, Integer)
            If cbCategoryID.Text = "" Then
                InitialComboSource(0)
            Else
                InitialComboSource(cbCategoryID.Text)
            End If

        End If
    End Sub

    Private Sub ShowDataSearch()
        Dim strQuery As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        strQuery = " select t.J_NUMBER as ""Journal No."",t.J_DATE as ""วัน/เวลา"",t.MESSAGE as ""ข้อความ"",t.TYPE1 as ""ประเภท"",t.CATEGORY_NAME " &
                ",t.SOURCE_NAME,t.J_USER as ""ผู้ใช้งาน"",t.J_COMPUTER as ""คอมพิวเตอร์"" from tas.view_journal t" &
                      " WHERE t.J_DATE>=to_date('" & Format(dtpFromDate.Value, "dd/MM/yyyy") &
                      " " & Format(dtpFromTime.Value, "HH:mm:ss") & "','dd/mm/yyyy hh24:mi:ss') " &
                      " and t.J_DATE<=to_date('" & Format(dtpTodate.Value, "dd/MM/yyyy") &
                      " " & Format(dtpToTime.Value, "HH:mm:ss") & "','dd/mm/yyyy hh24:mi:ss') "
        If cbType.Text <> "" Then
            If cbType.SelectedIndex > -1 Then
                strQuery = strQuery & " and t.TYPE1='" & UCase(cbType.Text) & "' "
            End If
        End If
        If cbUser.Text <> "" Then
            strQuery = strQuery & " and t.J_USER='" & cbUser.Text & "' "
        End If
        If cbComputer.Text <> "" Then
            strQuery = strQuery & " and t.J_COMPUTER='" & cbComputer.Text & "' "
        End If
        If cbCategory.Text <> "" Then
            'strQuery = strQuery & " and t.CATEGORY_NAME='" & cbCategory.Text & "' "
            strQuery = strQuery & " and t.J_CATEGORY=" & cbCategoryID.Text & " "
        End If
        If cbSource.Text <> "" Then
            'strQuery = strQuery & " and t.SOURCE_NAME='" & cbSource.Text & "' "
            strQuery = strQuery & " and t.J_SOURCE=" & cbSourceID.Text & " "
        End If

        If txtMsg.Text <> "" Then
            strQuery = strQuery & " and Upper(t.MESSAGE) like '%" & UCase(Trim(txtMsg.Text)) & "%' "
        End If

        strQuery = strQuery & " ORDER BY t.J_NUMBER desc"

        If Oradb.OpenDys(strQuery, "TableName", mDataSet) Then
            dt = mDataSet.Tables(0)
            DataGridView.DataSource = dt
            txtTotalRecord.Text = dt.Rows.Count
            For i As Integer = 0 To DataGridView.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = DataGridView.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
            SetDataGridViewRowForeColor()
            SetDataGridViewCurrentRowSelection()
        End If
        DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub

    Sub SetDataGridViewRowForeColor()
        For Each r As DataGridViewRow In DataGridView.Rows
            If r.Cells(3).Value = "ALARM" Then
                r.DefaultCellStyle.ForeColor = Color.Red
            Else
                r.DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
        'For i As Integer = 0 To DataGridView.Rows.Count - 1
        '    If DataGridView.Rows(i).Cells(3).Value = "ALARM" Then
        '        For j As Integer = 0 To DataGridView.Columns.Count - 1
        '            DataGridView.Rows(i).Cells(j).Style.ForeColor = Color.Red
        '        Next
        '    Else
        '        For j As Integer = 0 To DataGridView.Columns.Count - 1
        '            DataGridView.Rows(i).Cells(j).Style.ForeColor = Color.Black
        '        Next
        '    End If
        'Next
    End Sub

    Sub SetDataGridViewCurrentRowSelection()
        If rowSelect >= 0 And rowSelect <= DataGridView.Rows.Count - 1 Then
            DataGridView.ClearSelection()
            DataGridView.Rows(rowSelect).Selected = True
        End If
    End Sub

    Private Sub btClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub b_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UcMenuRefresh_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuRefresh.OnClickMnuText
        If CheckBox1.Checked = True Then
            ShowDataSearch()
        Else
            Show_Data()
        End If
    End Sub

    Private Sub UcMenu_Clear_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenu_Clear.OnClickMnuText
        txtMsg.Text = ""
        cbType.Text = ""
        cbCategory.Text = ""
        cbCategoryID.Text = ""
        cbComputer.Text = ""
        cbSource.Text = ""
        cbUser.Text = ""
    End Sub
    Private Sub UcHeader1_CloseButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.CloseButtonClick
        Me.Close()
    End Sub
    Private Sub UcHeader1_MinimizeButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.MinimizeButtonClick
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcBack1_Click(sender As Object, e As EventArgs) Handles UcBack1.Click
        Me.Close()
    End Sub

    Private Sub UcBack1_MouseHover(sender As Object, e As EventArgs) Handles UcBack1.MouseHover
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("Back1")
    End Sub

    Private Sub UcBack1_MouseLeave(sender As Object, e As EventArgs) Handles UcBack1.MouseLeave
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("back")
    End Sub

    Private Sub cbSource_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSource.SelectedIndexChanged
        If cbSource.SelectedIndex > -1 Then
            cbSourceID.SelectedIndex = CType(cbSource.SelectedIndex, Integer)
            'InitialComboSource(cbCategoryID.Text)
        End If
    End Sub

    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        If e.RowIndex > -1 Then
            rowSelect = e.RowIndex
        Else
            SetDataGridViewCurrentRowSelection()
        End If

        If e.RowIndex = -1 And rowSelect < DataGridView.Rows.Count Then
            SetDataGridViewCurrentRowSelection()
            SetDataGridViewRowForeColor()
        End If
    End Sub

    Private Sub UcMenuExport_OnClickMnuText(ucName As String, ucScreenID As Long) Handles UcMenuExport.OnClickMnuText
        'Export_Excel()
        ExportDataToExcel()
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


        For i = 0 To DataGridView.RowCount - 1
            For j = 0 To DataGridView.ColumnCount - 1
                For k As Integer = 1 To DataGridView.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView(j, i).Value.ToString()
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
    Public Sub ExportDataToExcel()
        Dim vFileTime As String
        Dim vFileDate As String
        Dim default_location As String = Application.StartupPath & "\Excel\ddfd.xls"
        Dim ds As New DataSet
        vFileTime = Format(Now, "Hmmss")
        vFileDate = Format(Date.Now, "ddMMyyyy")
        ds.Tables.Add()
        'add column to that table
        For i As Integer = 0 To DataGridView.ColumnCount - 1
            ds.Tables(0).Columns.Add(DataGridView.Columns(i).HeaderText)
        Next
        'add rows to the table
        Dim dr1 As DataRow
        For i As Integer = 0 To DataGridView.RowCount - 1
            dr1 = ds.Tables(0).NewRow
            For j As Integer = 0 To DataGridView.Columns.Count - 1
                dr1(j) = DataGridView.Rows(i).Cells(j).Value
            Next
            ds.Tables(0).Rows.Add(dr1)
        Next

        Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        excel.Visible = True
        excel.UserControl = True

        wBook = excel.Workbooks.Add(System.Reflection.Missing.Value)
        wSheet = wBook.Sheets("sheet1")
        excel.Range("A50:I50").EntireColumn.AutoFit()
        With wBook
            .Sheets("Sheet1").Select()
            .Sheets(1).Name = "NameYourSheet"
        End With

        Dim dt As System.Data.DataTable = ds.Tables(0)
        wSheet.Cells(1).value = vFileDate & vFileTime

        For i = 0 To DataGridView.RowCount - 1
            For j = 0 To DataGridView.ColumnCount - 1
                wSheet.Cells(i + 1, j + 1).value = DataGridView.Rows(i).Cells(j).Value.ToString()
            Next j
        Next i

        wSheet.Columns.AutoFit()
        Dim blnFileOpen As Boolean = False
        Try
            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(default_location)
            fileTemp.Close()
        Catch ex As Exception
            blnFileOpen = False
        End Try

        'If System.IO.File.Exists(default_location) Then
        '    System.IO.File.Delete(default_location)
        'End If

        'wBook.SaveAs(default_location)
        'excel.Workbooks.Open(default_location)
        excel.Visible = True
    End Sub

    Private Sub chAutoRefresh_CheckedChanged(sender As Object, e As EventArgs) Handles chAutoRefresh.CheckedChanged
        If chAutoRefresh.Checked = True Then
            Timer1.Start()
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If CheckBox1.Checked = True Then
            ShowDataSearch()
        Else
            Show_Data()
        End If
    End Sub
End Class
