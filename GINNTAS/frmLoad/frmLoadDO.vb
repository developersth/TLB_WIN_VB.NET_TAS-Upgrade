Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmLoadDO
    Public FormScreenID As Long
    Dim frm_work As Integer = 0  '1=add ,2=Edit

    Private Sub frmLoadDO_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmLoadDO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Showdata_GridMain()
        'resolution(Me, 1)
    End Sub

    Private Sub frmLoadDO_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub

    Private Sub Initial_frm()
        PickerDate_Start.Value = Date.Today
        PickerTime_Start.Value = Convert.ToDateTime(PickerTime_Start.Value.Date.ToLongDateString & " " & "00:00:00")
        PickerDate_Stop.Value = Date.Today
        PickerTime_Stop.Value = Now
    End Sub

    Private Sub Clear_frm()
        lbl_rec.Text = 0
        lbl_DO_No_Use.Text = 0
        lbl_DO_Use.Text = 0
    End Sub

    Public Sub Showdata_GridMain()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i, j, k As Integer

        Dim strDate = PickerDate_Start.Value.ToString.Split(" ")
        Dim dateStart = strDate(0)
        Dim strTime = PickerTime_Start.Value.ToString.Split(" ")
        Dim timeStart = strTime(1)
        Dim dateTimeStart As String = dateStart & " " & timeStart

        Dim strDateEnd = PickerDate_Stop.Value.ToString.Split(" ")
        Dim dateEnd = strDateEnd(0)
        Dim strTimeEnd = PickerTime_Stop.Value.ToString.Split(" ")
        Dim timeEnd = strTimeEnd(1)
        Dim dateTimeEnd As String = dateEnd & " " & timeEnd

        sql_str = "SELECT * "
        sql_str = sql_str & " FROM  TAS.VIEW_SHOW_DO  D "
        sql_str = sql_str & " WHERE  D.""วันที่ลูกค้าต้องการ"" BETWEEN to_date('" & dateTimeStart & "', 'dd/mm/yyyy hh24:mi:ss') AND to_date('" & dateTimeEnd & "', 'dd/mm/yyyy hh24:mi:ss') "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            j = 0
            k = 0
            'DataGridView_Headers.RowCount = 0
            lbl_DO_No_Use.Text = 0
            lbl_DO_Use.Text = 0
            lbl_rec.Text = dt.Rows.Count
            DataGridView_Headers.DataSource = dt
            txtTotalRecord.Text = dt.Rows.Count
            For i = 0 To DataGridView_Headers.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = DataGridView_Headers.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                For z = 0 To DataGridView_Headers.Rows.Count - 1
                    If (DataGridView_Headers.Rows(z).Cells(12).Value = "ยังไม่ถูกใช้งาน") Then
                        DataGridView_Headers.Rows(z).Cells(i).Style.ForeColor = Color.Blue
                    Else
                        DataGridView_Headers.Rows(z).Cells(i).Style.ForeColor = Color.DimGray
                    End If
                Next
            Next
            For i = 0 To DataGridView_Headers.Rows.Count - 1
                If (DataGridView_Headers.Rows(i).Cells(12).Value = "ยังไม่ถูกใช้งาน") Then
                    k = k + 1
                    lbl_DO_No_Use.Text = k
                Else
                    j = j + 1
                    lbl_DO_Use.Text = j
                End If
            Next
        Else
        End If
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub

    Private Sub DataGridView_Headers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Headers.CellClick
        Dim strColume As String
        If DataGridView_Headers.Rows.Count <= 0 Or DataGridView_Headers.CurrentRow.Index < 0 Then Exit Sub
        With DataGridView_Headers
            strColume = .Item(1, .CurrentRow.Index).Value
            'If Trim(.TextMatrix(.Row, 12)) <> "¶Ù¡ãªé§Ò¹" Then
            '    Call SaveReturnData(strColume)
            'End If
            Call ShowtoMSGridLines(strColume)
        End With

        If DataGridView_Headers.Rows.Count <= 0 Then
            MessageBox.Show("ไม่สามารถแก้ไขข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ยังไม่ได้เลือก DO กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            Exit Sub
        End If


    End Sub

    Private Sub b_DO_Use_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_DO_Use.Click
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i, j, k As Integer

        Dim strDate = PickerDate_Start.Value.ToString.Split(" ")
        Dim dateStart = strDate(0)
        Dim strTime = PickerTime_Start.Value.ToString.Split(" ")
        Dim timeStart = strTime(1)
        Dim dateTimeStart As String = dateStart & " " & timeStart

        Dim strDateEnd = PickerDate_Stop.Value.ToString.Split(" ")
        Dim dateEnd = strDateEnd(0)
        Dim strTimeEnd = PickerTime_Stop.Value.ToString.Split(" ")
        Dim timeEnd = strTimeEnd(1)
        Dim dateTimeEnd As String = dateEnd & " " & timeEnd

        b_DO_Use.BackColor = Color.Green
        b_DO_No_Use.BackColor = Color.White
        sql_str = "SELECT * "
        sql_str = sql_str & " FROM  TAS.VIEW_SHOW_DO  D "
        sql_str = sql_str & " WHERE  D.""วันที่ลูกค้าต้องการ"" BETWEEN to_date('" & dateTimeStart & "', 'dd/mm/yyyy hh24:mi:ss') AND to_date('" & dateTimeEnd & "', 'dd/mm/yyyy hh24:mi:ss') "
        sql_str = sql_str & " AND  D.""สถานะ DO""='ถูกใช้งาน' "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            j = 0
            k = 0
            'DataGridView_Headers.RowCount = 0
            DataGridView_Line.RowCount = 0
            txtTotalRecord.Text = dt.Rows.Count
            lbl_DO_Use.Text = dt.Rows.Count
            DataGridView_Headers.DataSource = dt
            For i = 0 To DataGridView_Headers.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = DataGridView_Headers.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                For z = 0 To DataGridView_Headers.Rows.Count - 1
                    If (DataGridView_Headers.Rows(z).Cells(12).Value = "ถูกใช้งาน") Then
                        DataGridView_Headers.Rows(z).Cells(i).Style.ForeColor = Color.DimGray
                    Else
                        DataGridView_Headers.Rows(z).Cells(i).Style.ForeColor = Color.Blue
                    End If
                Next
            Next
        Else
        End If
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub

    Private Sub b_DO_No_Use_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_DO_No_Use.Click
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i, j, k As Integer

        Dim strDate = PickerDate_Start.Value.ToString.Split(" ")
        Dim dateStart = strDate(0)
        Dim strTime = PickerTime_Start.Value.ToString.Split(" ")
        Dim timeStart = strTime(1)
        Dim dateTimeStart As String = dateStart & " " & timeStart

        Dim strDateEnd = PickerDate_Stop.Value.ToString.Split(" ")
        Dim dateEnd = strDateEnd(0)
        Dim strTimeEnd = PickerTime_Stop.Value.ToString.Split(" ")
        Dim timeEnd = strTimeEnd(1)
        Dim dateTimeEnd As String = dateEnd & " " & timeEnd

        b_DO_Use.BackColor = Color.White
        b_DO_No_Use.BackColor = Color.Green

        sql_str = "SELECT * "
        sql_str = sql_str & " FROM  TAS.VIEW_SHOW_DO  D "
        sql_str = sql_str & " WHERE   D.""วันที่ลูกค้าต้องการ"" BETWEEN to_date('" & dateTimeStart & "', 'dd/mm/yyyy hh24:mi:ss') AND to_date('" & dateTimeEnd & "', 'dd/mm/yyyy hh24:mi:ss') "
        sql_str = sql_str & " AND  D.""สถานะ DO""='ยังไม่ถูกใช้งาน' "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            j = 0
            k = 0
            DataGridView_Line.RowCount = 0
            lbl_DO_No_Use.Text = dt.Rows.Count
            DataGridView_Headers.DataSource = dt
            For i = 0 To DataGridView_Headers.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = DataGridView_Headers.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                For z = 0 To DataGridView_Headers.Rows.Count - 1
                    If (DataGridView_Headers.Rows(z).Cells(12).Value = "ยังไม่ถูกใช้งาน") Then
                        DataGridView_Headers.Rows(z).Cells(i).Style.ForeColor = Color.Blue
                    Else
                        DataGridView_Headers.Rows(z).Cells(i).Style.ForeColor = Color.DimGray
                    End If
                Next
            Next
        Else
        End If
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub

    Private Sub ShowtoMSGridLines(ByRef pDO As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "SELECT L.DO_NO ,L. ITEM_NO ,L.MATERIAL_NO ,L.QUANTITY   ,"
        sql_str = sql_str & " L.SALE_UNIT,L.PLANT,L.STORAGE_LOCATION ,L.SHIPTO_NAME  ,L.TRQNT  ,"
        sql_str = sql_str & " L.STATUS , L.CREATION_DATE, L.CREATED_BY, L.UPDATE_DATE, L.UPDATED_BY, "
        sql_str = sql_str & " L.J_COMPUTER, S.SALE_PRODUCT_NAME"
        sql_str = sql_str & " FROM DO_LINES L,SALE_PRODUCT S"
        sql_str = sql_str & " WHERE  L.MATERIAL_NO=S.SALE_PRODUCT_ID(+) AND L.DO_NO='" & pDO & "'  ORDER BY L.ITEM_NO "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView_Line.RowCount = 0
            Do While dt.Rows.Count > i

                DataGridView_Line.RowCount = DataGridView_Line.RowCount + 1
                DataGridView_Line.Rows.Item(i).Height = Grid_Height

                DataGridView_Line.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ITEM_NO")), "", dt.Rows(i).Item("ITEM_NO").ToString)
                DataGridView_Line.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("MATERIAL_NO")), "", dt.Rows(i).Item("MATERIAL_NO").ToString)
                DataGridView_Line.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT_NAME")), "", dt.Rows(i).Item("SALE_PRODUCT_NAME").ToString)
                DataGridView_Line.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("QUANTITY")), "", dt.Rows(i).Item("QUANTITY").ToString)
                DataGridView_Line.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SALE_UNIT")), "", dt.Rows(i).Item("SALE_UNIT").ToString)

                i = i + 1
            Loop
        Else
        End If
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub

    Private Sub b_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Search.Click
        'Call Showdata_GridMain()
        Dim strColume As String
        If DataGridView_Headers.Rows.Count <= 0 Then Exit Sub
        With DataGridView_Headers
            strColume = .Item(1, .CurrentRow.Index).Value
        End With

        frmFind.Close()
        frmFind.InitialFormFind(DataGridView_Headers, 1)
        frmFind.ShowDialog()
       
    End Sub

    Private Sub b_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Showdata_GridMain()
        DataGridView_Line.Rows.Clear()
    End Sub

    Private Sub b_Add_DO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub b_Edit_DO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub b_Del_DO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Delete()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        sql_str = " DELETE FROM DO_Header    "
        sql_str = sql_str & " WHERE  DO_NO = '" + DataGridView_Headers.Item(1, DataGridView_Headers.CurrentRow.Index).Value.ToString + "' "
        If Oradb.ExeSQL(sql_str) Then

            sql_str = " DELETE FROM DO_LINES    "
            sql_str = sql_str & " WHERE  DO_NO = '" + DataGridView_Headers.Item(1, DataGridView_Headers.CurrentRow.Index).Value.ToString + "' "
            Oradb.ExeSQL(sql_str)

            MessageBox.Show("ได้ทำการลบข้อมูลเรียบร้อย", "System TAS")
            Showdata_GridMain()
        Else
            MessageBox.Show("ไม่สามารถลบข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
    End Sub

   

    Private Sub UcMenuAdd_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuAdd.OnClickMnuText
        frmLoadDO_Sub.Close()
        frmLoadDO_Sub.setFrmWork(1)
        frmLoadDO_Sub.ShowDialog()
    End Sub

    Private Sub UcMenuEdit_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuEdit.OnClickMnuText
        If DataGridView_Headers.Rows.Count <= 0 Then
            MessageBox.Show("ไม่สามารถแก้ไขข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ยังไม่ได้เลือก DO กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            Exit Sub
        End If

        If DataGridView_Headers.Item(12, DataGridView_Headers.CurrentRow.Index).Value.ToString.Trim = "ถูกใช้งาน" Then
            MessageBox.Show("ไม่สามารถแก้ไขข้อมูลได้" & vbCrLf & vbCrLf & " DO ถูกใช้งานแล้ว กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            Exit Sub
        End If

        Dim DO_No As String
        DO_No = DataGridView_Headers.Item(1, DataGridView_Headers.CurrentRow.Index).Value
        frmLoadDO_Sub.Close()
        frmLoadDO_Sub.setFrmWork(2)
        frmLoadDO_Sub.setPkId(DO_No)
        frmLoadDO_Sub.ShowDialog()
    End Sub

    Private Sub UcMenuDelete_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuDelete.OnClickMnuText
        If DataGridView_Headers.Rows.Count <= 0 Then
            MessageBox.Show("ไม่สามารถลบข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ยังไม่ได้เลือก DO กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            Exit Sub
        End If

        If DataGridView_Headers.Item(12, DataGridView_Headers.CurrentRow.Index).Value.ToString.Trim = "ถูกใช้งาน" Then
            MessageBox.Show("ไม่สามารถลบข้อมูลได้" & vbCrLf & vbCrLf & " DO ถูกใช้งานแล้ว กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            Exit Sub
        End If

        Dim result As Integer = MessageBox.Show("ต้องการลบ D/O : " + DataGridView_Headers.Item(1, DataGridView_Headers.CurrentRow.Index).Value.ToString + " หรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            Delete()
        End If
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

    Private Sub DataGridView_Headers_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Headers.CellDoubleClick
        Dim strColume As String
        If DataGridView_Headers.Rows.Count <= 0 Then Exit Sub
        With DataGridView_Headers
            strColume = .Item(1, .CurrentRow.Index).Value
        End With
        frmLoadDO_Edit.Close()
        frmLoadDO_Edit.setFrmWork(1)
        frmLoadDO_Edit.setPkId(strColume)
        frmLoadDO_Edit.ShowDialog()
    End Sub

    Private Sub DataGridView_Headers_KeyDown(sender As Object, e As KeyEventArgs)
        Dim strColume As String
        If DataGridView_Headers.Rows.Count <= 0 Or DataGridView_Headers.CurrentRow.Index < 0 Then Exit Sub
        With DataGridView_Headers
            strColume = .Item(1, .CurrentRow.Index).Value
            Call ShowtoMSGridLines(strColume)
        End With
    End Sub

    Private Sub DataGridView_Headers_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView_Headers.KeyUp, DataGridView_Headers.KeyDown
        Dim strColume As String
        If DataGridView_Headers.Rows.Count <= 0 Or DataGridView_Headers.CurrentRow.Index < 0 Then Exit Sub
        With DataGridView_Headers
            strColume = .Item(1, .CurrentRow.Index).Value
            Call ShowtoMSGridLines(strColume)
        End With
    End Sub

    Private Sub UcMenutxtSub1_OnClickMnuText(ucName As String, ucScreenID As Long) Handles UcMenutxtSub1.OnClickMnuText
        Dim strColume As String
        If DataGridView_Headers.Rows.Count <= 0 Then Exit Sub
        With DataGridView_Headers
            strColume = .Item(1, .CurrentRow.Index).Value
        End With

        If DataGridView_Headers.Rows.Count <= 0 Then
            MessageBox.Show("ไม่สามารถแก้ไขข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ยังไม่ได้เลือก DO กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            Exit Sub
        End If
        If ChkSecurity(strColume) Then
            frmLoadDO_Edit.Close()
            frmLoadDO_Edit.setFrmWork(2)
            frmLoadDO_Edit.setPkId(strColume)
            frmLoadDO_Edit.ShowDialog()
        End If

    End Sub
    Private Function ChkSecurity(ByVal iValue As String) As Boolean
        On Error Resume Next
        Dim strSQL As String
        Dim vOrderQuota As Long
        Dim vQota As Long
        Dim iDate As String

        ChkSecurity = False

        strSQL = "begin " &
                            " tas.P_CHECK_SECURITY_EDIT_DATA(" &
                            "'" & Trim(iValue) & "',1,'" & Trim(mUserName) & "', " &
                            ":RET_CHK,:RET_MSG_CHK); " &
                            "end;"

        Dim Oraparam As New COraParameter
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_CHECK", COracle._OracleDbType.OraInt16)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With
        If Oradb.ExeSQL(strSQL, Oraparam) Then
            RET_CHECK = Oraparam.GetOraclParamValue("RET_CHECK")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            If RET_CHECK = 0 Then
                ChkSecurity = True
            Else
                ChkSecurity = False
                MsgBox(RET_MSG)
            End If
        End If
        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
    End Function
    Private Sub UcMenutxtSub2_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenutxtSub2.OnClickMnuText
        Dim strDO As String
        Dim strDoUse As String
        If DataGridView_Headers.Rows.Count <= 0 Then Exit Sub
        With DataGridView_Headers
            strDO = .Item(1, .CurrentRow.Index).Value
            strDoUse = .Item(12, .CurrentRow.Index).Value
        End With

        If Trim(strDoUse) = "" Then
            MsgBox("กรุณาเลือก DO ที่ใช้งานแล้ว ", vbInformation)
        ElseIf Trim(strDoUse) = "ยังไม่ถูกใช้งาน" Then
            MsgBox("กรุณาเลือก DO ที่ใช้งานแล้ว", vbInformation)
        Else
            If ChkSecurity(strDO) Then
                frmLoadDo_new.Close()
                frmLoadDo_new.InitialOldDo(strDO)
                frmLoadDo_new.ShowDialog()
            End If
        End If
    End Sub

    Private Sub UcMenuCreateLoad_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuCreateLoad.OnClickMnuText
        frmLoadCreateLoad.Close()
        frmLoadCreateLoad.Show()
    End Sub

    Private Sub UcMenuRefresh_OnClickMnuText(ucName As String, ucScreenID As Long) Handles UcMenuRefresh.OnClickMnuText
        Showdata_GridMain()
        b_DO_Use.BackColor = Color.White
        b_DO_No_Use.BackColor = Color.White
    End Sub
End Class