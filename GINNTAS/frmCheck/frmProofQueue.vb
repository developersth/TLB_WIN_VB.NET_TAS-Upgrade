Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmProofQueue
    Public FormScreenID As Long
    Dim frm_work As Integer = 0  '1=add ,2=Edit
    Dim dateTimeStart As String
    Dim dateTimeEnd As String

    Private Sub frmProofQueue_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmProofQueue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub frmProofQueue_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Initial_frm()
        dtpChoosDate.Value = Date.Today
        DTPTimeStart.Value = Convert.ToDateTime(DTPTimeStart.Value.Date.ToLongDateString & " " & "00:00:00")
        DTPTimeEnd.Value = Date.Today
        PickerTime_Stop.Value = Now
    End Sub

    Private Sub Clear_frm()
        txtTotHeader.Text = 0
        txtCountcancel.Text = 0
    End Sub

    Public Sub Showdata_GridMain()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i, j, k As Integer

        Dim strDateStart = dtpChoosDate.Value.ToString.Split(" ")
        Dim dateStart = strDateStart(0)
        Dim strTime = DTPTimeStart.Value.ToString.Split(" ")
        Dim timeStart = strTime(1)
        dateTimeStart = dateStart & " " & timeStart

        Dim strDateEnd = DTPTimeEnd.Value.ToString.Split(" ")
        Dim dateEnd = strDateEnd(0)
        Dim strTimeEnd = PickerTime_Stop.Value.ToString.Split(" ")
        Dim timeEnd = strTimeEnd(1)
        dateTimeEnd = dateEnd & " " & timeEnd
      

        sql_str = _
     "SELECT H.LOAD_HEADER_NO,H.SHIPMENT_NO,S.STATUS_NUMBER||' - '||S.DESCRIPTION as STATUS," & _
     "H.TRIP_NO,H.TU_CARD_NO,H.TU_ID,S.STATUS_NUMBER,H.VEHICLE_NUMBER,H.VEHICLE_TYPE,H.VEHICLE_ID,H.CANCEL_STATUS," & _
     "H.VEHICLE_MAP_TYPE,H.DRIVER_ID,H.DRIVER_NAME,H.SEAL_USE,H.SEAL_NUMBER,H.T_BILLING,H.LOCKED " & _
     "FROM OIL_LOAD_HEADERS H,STATUS_DESC S " & _
     "WHERE H.EOD_DATE Between  to_date('" & dateTimeStart.ToString() & "','dd/mm/yyyy hh24:mi:ss') " & _
     "AND to_date('" & dateTimeEnd & "','dd/mm/yyyy hh24:mi:ss') " & _
     "AND H.LOAD_STATUS in ('11','12','13','21','31','51') AND H.LOAD_STATUS=S.STATUS_NUMBER " & _
     "AND ((S.T_NAME='OIL_LOAD_HEADERS' AND S.COLUMNS_NAME='LOAD_STATUS') OR S.T_NAME is null) " & _
     "ORDER BY S.STATUS_NUMBER,H.LOAD_HEADER_NO DESC"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            j = 0
            k = 0
            DataGridView_Headers.RowCount = 0

            txtCountcancel.Text = 0
            txtTotHeader.Text = dt.Rows.Count
            Do While dt.Rows.Count > i

                DataGridView_Headers.RowCount = DataGridView_Headers.RowCount + 1
                DataGridView_Headers.Rows.Item(i).Height = Grid_Height
                DataGridView_Headers.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOAD_HEADER_NO")), "", dt.Rows(i).Item("LOAD_HEADER_NO").ToString)
                DataGridView_Headers.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SHIPMENT_NO")), "", dt.Rows(i).Item("SHIPMENT_NO").ToString)
                DataGridView_Headers.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("STATUS")), "", dt.Rows(i).Item("STATUS").ToString)

                DataGridView_Headers.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TRIP_NO")), "", dt.Rows(i).Item("TRIP_NO").ToString)
                DataGridView_Headers.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TU_CARD_NO")), "", dt.Rows(i).Item("TU_CARD_NO").ToString)
                DataGridView_Headers.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TU_ID")), "", dt.Rows(i).Item("TU_ID").ToString)

                DataGridView_Headers.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("VEHICLE_NUMBER")), "", dt.Rows(i).Item("VEHICLE_NUMBER").ToString)
                DataGridView_Headers.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_NAME")), "", dt.Rows(i).Item("DRIVER_NAME").ToString)
                DataGridView_Headers.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOCKED")), "", IIf(dt.Rows(i).Item("LOCKED").ToString = "1", "Locked", "-"))

                DataGridView_Headers.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SEAL_NUMBER")), "", dt.Rows(i).Item("SEAL_NUMBER").ToString)
                DataGridView_Headers.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("T_BILLING")), "", dt.Rows(i).Item("T_BILLING").ToString)
                DataGridView_Headers.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CANCEL_STATUS")), "", IIf(dt.Rows(i).Item("CANCEL_STATUS").ToString = "1", "ยกเลิก", ""))

                Dim z As Integer
                If IIf(IsDBNull(dt.Rows(i).Item("CANCEL_STATUS")), "0", dt.Rows(i).Item("CANCEL_STATUS").ToString) = "0" Then
                    j = j + 1

                    For z = 0 To DataGridView_Headers.Columns.Count - 1
                        DataGridView_Headers.Rows(i).Cells(z).Style.ForeColor = Color.Black
                    Next
                Else
                    k = k + 1
                    txtCountcancel.Text = k

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

    Private Sub DataGridView_Headers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Headers.CellClick
        Dim strColume As String
        If DataGridView_Headers.Rows.Count <= 0 Or DataGridView_Headers.CurrentRow.Index < 0 Then Exit Sub
        With DataGridView_Headers
            strColume = .Item(0, .CurrentRow.Index).Value
            Call ShowtoMSGridLines(strColume)
        End With
    End Sub


    Private Sub ShowtoMSGridLines(ByRef LoadNo As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = _
              "SELECT L.BATCH_NO,L.SHIPMENT_NO,L.TU_ID,L.COMPARTMENT_NO,L.COMPAMENT_CAPACITY,L.UNIT," & _
        "L.SALE_PRODUCT_ID||' - '||L.SALE_PRODUCT_NAME as PRODUCT,L.ADVICE,L.BATCH_STATUS||' - '||S.DESCRIPTION as LStatus " & _
        "FROM TAS.OIL_LOAD_LINES L,STATUS_DESC S " & _
        "WHERE L.BATCH_STATUS = S.STATUS_NUMBER " & _
        "AND ((S.T_NAME='OIL_LOAD_LINES' and S.COLUMNS_NAME='BATCH_STATUS') or S.T_NAME is null) " & _
        "AND L.LOAD_HEADER_NO='" & LoadNo & "' " & _
        "ORDER BY L.BATCH_NO"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView_Line.RowCount = 0
            Do While dt.Rows.Count > i

                DataGridView_Line.RowCount = DataGridView_Line.RowCount + 1
                DataGridView_Line.Rows.Item(i).Height = Grid_Height

                DataGridView_Line.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("BATCH_NO")), "", dt.Rows(i).Item("BATCH_NO").ToString)
                DataGridView_Line.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SHIPMENT_NO")), "", dt.Rows(i).Item("SHIPMENT_NO").ToString)
                DataGridView_Line.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TU_ID")), "", dt.Rows(i).Item("TU_ID").ToString)
                DataGridView_Line.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("COMPARTMENT_NO")), "", dt.Rows(i).Item("COMPARTMENT_NO").ToString)
                DataGridView_Line.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("COMPAMENT_CAPACITY")), "", dt.Rows(i).Item("COMPAMENT_CAPACITY").ToString)
                DataGridView_Line.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PRODUCT")), "", dt.Rows(i).Item("PRODUCT").ToString)
                DataGridView_Line.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ADVICE")), "", dt.Rows(i).Item("ADVICE").ToString)
                DataGridView_Line.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UNIT")), "", dt.Rows(i).Item("UNIT").ToString)
                DataGridView_Line.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LStatus")), "", dt.Rows(i).Item("LStatus").ToString)

                txtTotLine.Text = IIf(IsDBNull(dt.Rows(i).Item("COMPARTMENT_NO")), "", dt.Rows(i).Item("COMPARTMENT_NO").ToString)
                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub b_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Search.Click
        Call Showdata_GridMain()
        Call UserLoad.InitialUser(dateTimeStart, dateTimeEnd)
    End Sub

    Private Sub b_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UcMenuRefresh_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenutxtSub1.OnClickMnuText
        DataGridView_Line.Rows.Clear()
        Call Showdata_GridMain()
        Call UserLoad.InitialUser(dateTimeStart, dateTimeEnd)
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

    Private Sub UcBack1_Load(sender As System.Object, e As System.EventArgs) Handles UcBack1.Load

    End Sub
End Class