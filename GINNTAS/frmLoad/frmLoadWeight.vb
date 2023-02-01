Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmLoadWeight
    Public FormScreenID As Long
    Dim frm_work As Integer = 0  '1=add ,2=Edit

    Private Sub frmLoadWeight_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmLoadWeight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub frmLoadWeight_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub

    Private Sub Initial_frm()
        'PickerDate_Start.Value = Date.Today
        'PickerTime_Start.Value = Convert.ToDateTime(PickerTime_Start.Value.Date.ToLongDateString & " " & "00:00:00")
        'PickerDate_Stop.Value = Date.Today
        'PickerTime_Stop.Value = Now
    End Sub

    Private Sub Clear_frm()
        lbl_rec.Text = 0
        DataGridView_Headers.RowCount = 0
        DataGridView_Line.RowCount = 0
    End Sub

    Public Sub Show_frm()
        Clear_frm()
        Initial_frm()
        Showdata_GridMain()
    End Sub

    Private Sub Showdata_GridMain()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "SELECT O.LOAD_HEADER_NO ,O.SHIPMENT_NO,O.TU_NUMBER ,O.DRIVER_NAME "
        sql_str = sql_str & " ,O.TU_ID ,O.TU_NUMBER1 ,O.WEIGHT_IN, O.WEIGHT_OUT, O.TU_ID1 "
        sql_str = sql_str & " ,O.UPDATE_DATE ,O.UPDATED_BY ,O.LOAD_STATUS "
        sql_str = sql_str & " FROM TAS.OIL_LOAD_HEADERS O "
        sql_str = sql_str & " WHERE O.LOAD_STATUS IN (21,54,55) AND O.CANCEL_STATUS=0  "
        sql_str = sql_str & " AND O.IS_WEIGHT_PROCESS =1 "
        sql_str = sql_str & " ORDER BY O.LOAD_HEADER_NO "


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
                DataGridView_Headers.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_NAME")), "", dt.Rows(i).Item("DRIVER_NAME").ToString)

                DataGridView_Headers.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TU_ID")), "", dt.Rows(i).Item("TU_ID").ToString)
                DataGridView_Headers.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TU_ID1")), "", dt.Rows(i).Item("TU_ID1").ToString)
                DataGridView_Headers.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("WEIGHT_IN")), "", dt.Rows(i).Item("WEIGHT_IN").ToString)

                DataGridView_Headers.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("WEIGHT_OUT")), "", dt.Rows(i).Item("WEIGHT_OUT").ToString)
                DataGridView_Headers.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
                DataGridView_Headers.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)

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

    Private Sub ShowtoMSGridLines(ByVal iRow As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "SELECT  DISTINCT H.LOAD_HEADER_NO"
        sql_str = sql_str & " ,H.CARRIER_ID,H.CARRIER_NAME"
        sql_str = sql_str & " ,H.DRIVER_NAME,H.TU_ID"
        sql_str = sql_str & " ,H.TU_ID1,H.CANCEL_STATUS"
        sql_str = sql_str & " ,H.LOAD_STATUS,H.CREATION_DATE"
        sql_str = sql_str & " ,H.SEAL_NUMBER,H.SEAL_USE"
        sql_str = sql_str & " ,L.DO_NO,L.SHIPMENT_NO"
        sql_str = sql_str & " ,DO.CUSTOMER_CODE,C.CUSTOMER_NAME"
        sql_str = sql_str & " ,DO.SHIPTO,DO.PLAN_DATE"
        sql_str = sql_str & " FROM TAS.OIL_LOAD_HEADERS H,TAS.OIL_LOAD_LINES L,TAS.DO_HEADER DO,TAS.CUSTOMER C"
        sql_str = sql_str & " WHERE H.LOAD_HEADER_NO = l.LOAD_HEADER_NO"
        sql_str = sql_str & " AND L.DO_NO=DO.DO_NO"
        sql_str = sql_str & " AND DO.CUSTOMER_CODE=C.CUSTOMER_CODE(+) AND L.LOAD_HEADER_NO='" & iRow & "' "
        sql_str = sql_str & " Order by L.DO_NO"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView_Line.RowCount = 0
            Do While dt.Rows.Count > i

                DataGridView_Line.RowCount = DataGridView_Line.RowCount + 1
                DataGridView_Line.Rows.Item(i).Height = Grid_Height
                DataGridView_Line.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CUSTOMER_CODE")), "", dt.Rows(i).Item("CUSTOMER_CODE").ToString)
                DataGridView_Line.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CUSTOMER_NAME")), "", dt.Rows(i).Item("CUSTOMER_NAME").ToString)
                DataGridView_Line.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SHIPTO")), "", dt.Rows(i).Item("SHIPTO").ToString)
                DataGridView_Line.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PLAN_DATE")), "", dt.Rows(i).Item("PLAN_DATE").ToString)
                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub b_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub b_Add_Weigt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UcMenuRefresh_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuRefresh.OnClickMnuText
        Showdata_GridMain()
    End Sub

    Private Sub UcMenu_Add_Weigt_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenu_Add_Weigt.OnClickMnuText
        If DataGridView_Headers.Rows.Count <= 0 Then Exit Sub
        If DataGridView_Headers.CurrentRow.Index < 0 Then Exit Sub
        frmLoadEditWeight.Show()
    End Sub

    
    Private Sub UcMenu_Search_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenu_Search.OnClickMnuText
        frmFind.InitialFormFind(DataGridView_Headers)
        frmFind.ShowDialog()
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