Public Class frmProofLoadIncomplete
    Public FormScreenID As Long

    Private Sub frmProofLoadIncomplete_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmProofLoadIncomplete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        resolution(Me, 1)
    End Sub

    Private Sub frmProofLoadIncomplete_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
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
        lbl_rec_line.Text = 0
    End Sub

    Public Sub Showdata_GridMain()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

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

        sql_str = "SELECT H.LOAD_HEADER_NO,H.SHIPMENT_NO,S.DESCRIPTION,H.TRIP_NO,H.TU_CARD_NO,H.TU_NUMBER,H.TU_ID,"
        sql_str = sql_str & " H.DRIVER_NAME,H.SEAL_NUMBER,H.T_BILLING,H.LOCKED,H.T_START,H.T_STOP,H.CANCEL_STATUS"
        sql_str = sql_str & " FROM OIL_LOAD_HEADERS H,STATUS_DESC S "
        sql_str = sql_str & " WHERE H.EOD_DATE BETWEEN  to_date('" & dateTimeStart & "','dd/mm/yyyy hh24:mi:ss') and to_date('" & dateTimeEnd & "','dd/mm/yyyy hh24:mi:ss') "
        sql_str = sql_str & " AND H.LOAD_STATUS in(52,53,54) "
        sql_str = sql_str & " AND H.LOAD_STATUS=S.STATUS_NUMBER(+) "
        sql_str = sql_str & " AND ((S.T_NAME='OIL_LOAD_HEADERS' AND S.COLUMNS_NAME='LOAD_STATUS') or S.T_NAME is null) "
        sql_str = sql_str & " AND H.CANCEL_STATUS=0  ORDER BY H.LOAD_HEADER_NO DESC"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView_Headers.RowCount = 0
            lbl_rec.Text = dt.Rows.Count
            Do While dt.Rows.Count > i

                DataGridView_Headers.RowCount = DataGridView_Headers.RowCount + 1
                DataGridView_Headers.Rows.Item(i).Height = Grid_Height
                DataGridView_Headers.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOAD_HEADER_NO")), "", dt.Rows(i).Item("LOAD_HEADER_NO").ToString)
                DataGridView_Headers.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SHIPMENT_NO")), "", dt.Rows(i).Item("SHIPMENT_NO").ToString)
                DataGridView_Headers.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION").ToString)

                DataGridView_Headers.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TRIP_NO")), "", dt.Rows(i).Item("TRIP_NO").ToString)
                DataGridView_Headers.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TU_CARD_NO")), "", dt.Rows(i).Item("TU_CARD_NO").ToString)
                DataGridView_Headers.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TU_NUMBER")), "", dt.Rows(i).Item("TU_NUMBER").ToString)

                DataGridView_Headers.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TU_ID")), "", dt.Rows(i).Item("TU_ID").ToString)
                DataGridView_Headers.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_NAME")), "", dt.Rows(i).Item("DRIVER_NAME").ToString)
                DataGridView_Headers.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SEAL_NUMBER")), "", dt.Rows(i).Item("SEAL_NUMBER").ToString)

                DataGridView_Headers.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("T_BILLING")), "", dt.Rows(i).Item("T_BILLING").ToString)
                DataGridView_Headers.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOCKED")), "", IIf(dt.Rows(i).Item("LOCKED").ToString = "0", " ไม่ใช่", " ใช่"))
                DataGridView_Headers.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("T_START")), "", dt.Rows(i).Item("T_START").ToString)

                DataGridView_Headers.Item(12, i).Value = IIf(IsDBNull(dt.Rows(i).Item("T_STOP")), "", dt.Rows(i).Item("T_STOP").ToString)
                DataGridView_Headers.Item(13, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CANCEL_STATUS")), "", IIf(dt.Rows(i).Item("CANCEL_STATUS").ToString = "0", " ", " ยกเลิก"))

                Dim z As Integer
                If IIf(IsDBNull(dt.Rows(i).Item("CANCEL_STATUS")), "0", dt.Rows(i).Item("CANCEL_STATUS").ToString) = "0" Then
                    For z = 0 To DataGridView_Headers.Columns.Count - 1
                        DataGridView_Headers.Rows(i).Cells(z).Style.ForeColor = Color.Black
                    Next
                Else
                    For z = 0 To DataGridView_Headers.Columns.Count - 1
                        DataGridView_Headers.Rows(i).Cells(z).Style.ForeColor = Color.Red
                    Next
                End If

                i = i + 1

            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub b_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub b_End_Batch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView_Headers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Headers.CellClick
        Dim strColume As String
        If DataGridView_Headers.Rows.Count <= 0 Or DataGridView_Headers.CurrentRow.Index < 0 Then Exit Sub
        With DataGridView_Headers
            strColume = .Item(0, .CurrentRow.Index).Value
            Call ShowtoMSGridLines(strColume)
        End With
    End Sub

    Private Sub ShowtoMSGridLines(ByRef pLoad_No As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "SELECT L.SHIPMENT_NO,L.TU_ID,L.COMPARTMENT_NO,"
        sql_str = sql_str & "L.SALE_PRODUCT_ID||' - '||L.SALE_PRODUCT_NAME as PRODUCT,L.ADVICE,L.BATCH_STATUS||' - '||S.DESCRIPTION as STATUS,"
        sql_str = sql_str & "L.METER_NO,L.TEMP,L.API60F,L.LOADED_GROSS,"
        sql_str = sql_str & "L.LOADED_NET_CAL,L.LOADED_NET,L.BAY_NAME,"
        sql_str = sql_str & "L.TOT_GROSS_START,L.TOT_GROSS_STOP,L.TANK_NAME,L.T_START,L.T_STOP, "
        sql_str = sql_str & "L.BATCH_NO,L.UNIT,L.VCF30C,L.DESCRIPTION,L.DESITY15C,L.LOADED_VOLOBS,L.LOADED_VOL15C,L.LOADED_VOL30C,L.LOADED_MASS "
        sql_str = sql_str & "FROM OIL_LOAD_LINES L,STATUS_DESC S "
        sql_str = sql_str & "WHERE L.BATCH_STATUS = S.STATUS_NUMBER "
        sql_str = sql_str & "AND ((S.T_NAME='OIL_LOAD_LINES' and S.COLUMNS_NAME='BATCH_STATUS') or S.T_NAME is null) "
        sql_str = sql_str & "AND L.LOAD_HEADER_NO=" & pLoad_No & " "
        sql_str = sql_str & "ORDER BY L.BATCH_NO"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView_Line.RowCount = 0
            lbl_rec_line.Text = dt.Rows.Count
            Do While dt.Rows.Count > i

                DataGridView_Line.RowCount = DataGridView_Line.RowCount + 1
                DataGridView_Line.Rows.Item(i).Height = Grid_Height

                DataGridView_Line.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("BATCH_NO")), "", dt.Rows(i).Item("BATCH_NO").ToString)

                DataGridView_Line.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TU_ID")), "", dt.Rows(i).Item("TU_ID").ToString)
                DataGridView_Line.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("COMPARTMENT_NO")), "", dt.Rows(i).Item("COMPARTMENT_NO").ToString)
                DataGridView_Line.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PRODUCT")), "", dt.Rows(i).Item("PRODUCT").ToString)
                DataGridView_Line.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ADVICE")), "", dt.Rows(i).Item("ADVICE").ToString)
                DataGridView_Line.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UNIT")), "", dt.Rows(i).Item("UNIT").ToString)

                DataGridView_Line.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("STATUS")), "", dt.Rows(i).Item("STATUS").ToString)
                DataGridView_Line.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("BAY_NAME")), "", dt.Rows(i).Item("BAY_NAME").ToString)
                DataGridView_Line.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("METER_NO")), "", dt.Rows(i).Item("METER_NO").ToString)
                DataGridView_Line.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TEMP")), "", dt.Rows(i).Item("TEMP").ToString)
                DataGridView_Line.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DESITY15C")), "", dt.Rows(i).Item("DESITY15C").ToString)

                DataGridView_Line.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOADED_GROSS")), "", dt.Rows(i).Item("LOADED_GROSS").ToString)
                DataGridView_Line.Item(12, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOADED_VOLOBS")), "", dt.Rows(i).Item("LOADED_VOLOBS").ToString)
                DataGridView_Line.Item(13, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOADED_VOL15C")), "", dt.Rows(i).Item("LOADED_VOL15C").ToString)
                DataGridView_Line.Item(14, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOADED_VOL30C")), "", dt.Rows(i).Item("LOADED_VOL30C").ToString)
                DataGridView_Line.Item(15, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOADED_MASS")), "", dt.Rows(i).Item("LOADED_MASS").ToString)

                DataGridView_Line.Item(16, i).Value = IIf(IsDBNull(dt.Rows(i).Item("VCF30C")), "", dt.Rows(i).Item("VCF30C").ToString)
                DataGridView_Line.Item(17, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TANK_NAME")), "", dt.Rows(i).Item("TANK_NAME").ToString)
                DataGridView_Line.Item(18, i).Value = IIf(IsDBNull(dt.Rows(i).Item("T_START")), "", dt.Rows(i).Item("T_START").ToString)
                DataGridView_Line.Item(19, i).Value = IIf(IsDBNull(dt.Rows(i).Item("T_STOP")), "", dt.Rows(i).Item("T_STOP").ToString)
                DataGridView_Line.Item(20, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION").ToString)

                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub


    Private Sub UcMenuRefresh_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuRefresh.OnClickMnuText
        Showdata_GridMain()
    End Sub

    Private Sub UcMenuEnd_Batch_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuEnd_Batch.OnClickMnuText
        If DataGridView_Line.Rows.Count <= 0 Then
            MessageBox.Show("ไม่สามารถทำรายการ End Batch ได้ " & vbCrLf & vbCrLf & " คุณยังไม่ได้เลือก Line No กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            Exit Sub
        End If
        frmProofEditLine.Close()
        frmProofEditLine.GetDataLineBatch(DataGridView_Headers.Item(0, DataGridView_Headers.CurrentRow.Index).Value, DataGridView_Line.Item(2, DataGridView_Line.CurrentRow.Index).Value, DataGridView_Line.Item(0, DataGridView_Line.CurrentRow.Index).Value, DataGridView_Line.Item(6, DataGridView_Line.CurrentRow.Index).Value)
        frmProofEditLine.Show()
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

    Private Sub b_Search_Click(sender As Object, e As EventArgs) Handles b_Search.Click
        Showdata_GridMain()
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

    Private Sub UcBack1_Load(sender As System.Object, e As System.EventArgs) Handles UcBack1.Load

    End Sub
End Class