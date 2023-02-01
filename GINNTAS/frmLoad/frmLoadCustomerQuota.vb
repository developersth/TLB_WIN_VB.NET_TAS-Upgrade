Public Class frmLoadCustomerQuota
    Public FormScreenID As Long

    Private Sub frmLoadCustomerQuota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub frmLoadCustomerQuota_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmLoadCustomerQuota_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
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

        sql_str = "SELECT C.CUSTOMER_CODE,C.CUSTOMER_NAME,C.CUSTOMER_TYPE "
        sql_str = sql_str & " ,C.CITY,C.POSTAL_CODE,C.CUSTOMER_ADDRESS,C.TEL "
        sql_str = sql_str & " ,C.UPDATE_DATE,C.UPDATED_BY "
        sql_str = sql_str & " FROM TAS.CUSTOMER C "
        sql_str = sql_str & " ORDER BY C.CUSTOMER_CODE "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView_Headers.RowCount = 0
            lbl_rec.Text = dt.Rows.Count
            Do While dt.Rows.Count > i

                DataGridView_Headers.RowCount = DataGridView_Headers.RowCount + 1
                DataGridView_Headers.Rows.Item(i).Height = Grid_Height
                DataGridView_Headers.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CUSTOMER_CODE")), "", dt.Rows(i).Item("CUSTOMER_CODE").ToString)
                DataGridView_Headers.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CUSTOMER_NAME")), "", dt.Rows(i).Item("CUSTOMER_NAME").ToString)
                DataGridView_Headers.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CUSTOMER_TYPE")), "", dt.Rows(i).Item("CUSTOMER_TYPE").ToString)

                DataGridView_Headers.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CUSTOMER_ADDRESS")), "", dt.Rows(i).Item("CUSTOMER_ADDRESS").ToString)
                DataGridView_Headers.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CITY")), "", dt.Rows(i).Item("CITY").ToString)
                DataGridView_Headers.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("POSTAL_CODE")), "", dt.Rows(i).Item("POSTAL_CODE").ToString)

                DataGridView_Headers.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TEL")), "", dt.Rows(i).Item("TEL").ToString)
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

        sql_str = "SELECT  T.CUSTOMER_CODE"
        sql_str = sql_str & " ,T.SALE_PRODUCT_ID,T.QUOTA_QTY"
        sql_str = sql_str & " ,T.IS_QUOTA,T.UPDATED_DATE"
        sql_str = sql_str & " ,T.UPDATED_BY,S.SALE_PRODUCT_CODE,S.UNIT"
        sql_str = sql_str & " FROM TAS.CUSTOMER_QUOTA T,TAS.SALE_PRODUCT S"
        sql_str = sql_str & " WHERE T.CUSTOMER_CODE ='" & iRow & "' "
        sql_str = sql_str & " AND T.SALE_PRODUCT_ID=S.SALE_PRODUCT_ID"
        sql_str = sql_str & " Order by S.SALE_PRODUCT_CODE"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView_Line.RowCount = 0
            Do While dt.Rows.Count > i

                DataGridView_Line.RowCount = DataGridView_Line.RowCount + 1
                DataGridView_Line.Rows.Item(i).Height = Grid_Height
                DataGridView_Line.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CUSTOMER_CODE")), "", dt.Rows(i).Item("CUSTOMER_CODE").ToString)
                DataGridView_Line.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT_CODE")), "", dt.Rows(i).Item("SALE_PRODUCT_CODE").ToString)
                DataGridView_Line.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("QUOTA_QTY")), "", dt.Rows(i).Item("QUOTA_QTY").ToString)
                DataGridView_Line.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("IS_QUOTA")), False, IIf(dt.Rows(i).Item("IS_QUOTA") = 1, True, False))
                DataGridView_Line.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UNIT")), "", dt.Rows(i).Item("UNIT").ToString)
                DataGridView_Line.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_DATE")), "", dt.Rows(i).Item("UPDATED_DATE").ToString)
                DataGridView_Line.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
                DataGridView_Line.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT_ID")), "", dt.Rows(i).Item("SALE_PRODUCT_ID").ToString)

                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub DataGridView_Line_EditingControlShowing(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView_Line.EditingControlShowing
        Select Case DataGridView_Line.CurrentCell.ColumnIndex
            Case 2
                Dim txtQuota As TextBox = e.Control
                RemoveHandler txtQuota.KeyPress, AddressOf txtQuota_Keypress
                AddHandler txtQuota.KeyPress, AddressOf txtQuota_Keypress
        End Select
    End Sub

    Private Sub txtQuota_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Console.WriteLine("KeyPress " & e.KeyChar.ToString())

        If DataGridView_Line.CurrentCell.ColumnIndex = 2 Then
            If IsNumeric(e.KeyChar.ToString()) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = "." Then
                Console.WriteLine("KeyPress number")
                e.Handled = False 'if numeric display 
            Else
                Console.WriteLine("Enter Numbers Only")
                e.Handled = True  'if non numeric don't display
            End If
        End If
    End Sub

    Private Sub b_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Cancel.Click
        Clear_frm()
        Initial_frm()
        Showdata_GridMain()
    End Sub

    Private Sub b_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Save.Click
        Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim sql_str As String
            Dim i As Integer = 0
            Dim sQuota As Integer

            Do While DataGridView_Line.RowCount > i
                If DataGridView_Line.Item(3, i).Value = True Then
                    sQuota = 1
                Else
                    sQuota = 0
                End If

                sql_str = "UPDATE TAS.CUSTOMER_QUOTA  SET "
                sql_str = sql_str & " QUOTA_QTY =" & DataGridView_Line.Item(2, i).Value & ","
                sql_str = sql_str & " IS_QUOTA= '" & sQuota & "',"
                sql_str = sql_str & " UPDATED_DATE= sysdate,"
                sql_str = sql_str & " J_COMPUTER =  '" & mUserName & "' ,"
                sql_str = sql_str & " UPDATED_BY= '" & mUserName & "' "
                sql_str = sql_str & " WHERE CUSTOMER_CODE = '" & DataGridView_Line.Item(0, i).Value & "' "
                sql_str = sql_str & " AND SALE_PRODUCT_ID =" & DataGridView_Line.Item(7, i).Value & " "

                If Oradb.ExeSQL(sql_str) Then
                    'MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
                Else
                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                End If

                i = i + 1
            Loop

        End If
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

    Private Sub UcBack1_Load(sender As System.Object, e As System.EventArgs) Handles UcBack1.Load

    End Sub
End Class