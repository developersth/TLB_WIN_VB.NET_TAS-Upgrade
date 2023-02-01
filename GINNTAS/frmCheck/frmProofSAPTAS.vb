Public Class frmProofSAPTAS
    Public FormScreenID As Long
    Dim StrTableName As String
    Dim sqlCode As String
    Dim SaleOrder As String

    Private Sub frmProofSAPTAS_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
        Timer1.Stop()
    End Sub

    Private Sub frmProofSAPTAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Timer1.Start()
    End Sub

    Private Sub frmProofSAPTAS_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub

    Private Sub Initial_frm()
        DTdate.Value = Date.Today
        Call imgHead_Click()
    End Sub

    Private Sub Clear_frm()
        dgvSaptas.DataSource = Nothing
    End Sub

    Private Sub b_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case StrTableName
            Case "DO_INTERFACE_HEAD"
                Call imgHead_Click()
            Case "DO_INTERFACE_DETAIL"
                Call imgDetail_Click()
            Case "TAS_LORRY_LOAD"
                Call imgLoad_Click()
            Case "OILSYS_LORRY_LOAD"
                Call imgOilsys_Click()
            Case Else
        End Select
    End Sub



    
    Private Sub btReupload_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles btReupload.OnClickMnuText
        Dim strSQL As String
        Dim mDataSet As New DataSet

        Select Case StrTableName

            Case "DO_INTERFACE_HEAD", "DO_INTERFACE_DETAIL"
                strSQL = "BEGIN OILSYS.REUPLOAD_DELIVERY_ORDER('" & SaleOrder & "'); END;"
                If SaleOrder <> "" Then
                    If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                        MessageBox.Show("Download Sale Order = " & SaleOrder & " เรียบร้อย")
                    End If
                    mDataSet = Nothing
                Else
                    MessageBox.Show("กรุณาเลือกหมายเลข Order")
                End If
            Case Else

        End Select
    End Sub

    Private Sub lblHead_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click, lblHead.Click
        imgHead_Click()
    End Sub
    Private Sub imgHead_Click()
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i, z As Integer
        Dim dtime = DTdate.Value.ToString.Split(" ")
        Dim dateStart = dtime(0)
        StrTableName = "DO_INTERFACE_HEAD"

        sqlCode = "select * from netsys.view_do_interface_header " & _
                        "where to_char(DO_DATE,'DD/MM/YYYY')= '" & dateStart & "' "


        If Oradb.OpenDys(sqlCode, "view_do_interface_header", mDataSet) Then
            dt = mDataSet.Tables("view_do_interface_header")
            i = 0

            dgvSaptas.DataSource = dt
            txtTotLine.Text = dt.Rows.Count
            For i = 0 To dgvSaptas.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = dgvSaptas.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                For z = 0 To dgvSaptas.Rows.Count - 1
                    If (dgvSaptas.Rows(z).Cells(2).Value = "C") Then
                        dgvSaptas.Rows(z).Cells(i).Style.ForeColor = Color.Blue
                    ElseIf (dgvSaptas.Rows(z).Cells(2).Value = "D") Then
                        dgvSaptas.Rows(z).Cells(i).Style.ForeColor = Color.Red
                    Else
                        dgvSaptas.Rows(z).Cells(i).Style.ForeColor = Color.DimGray
                    End If
                Next
            Next

        Else
        End If
        mDataSet = Nothing
    End Sub
    Private Sub imgDetail_Click()
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim dtime = DTdate.Value.ToString.Split(" ")
        Dim dateStart = dtime(0)
        StrTableName = "DO_INTERFACE_DETAIL"
        sqlCode = "select D.*  " & _
                        " from NETSYS.DO_INTERFACE_HEAD H" & _
                        " ,NETSYS.DO_INTERFACE_DETAIL D " & _
                        "where to_char(H.DELIVERY_DATE,'DD/MM/YYYY')= '" & dateStart & "' " & _
                        " AND H.DELIVERY_ORDER=D.DELIVERY_ORDER " & _
                        "order by H.DELIVERY_ORDER  desc "

        If Oradb.OpenDys(sqlCode, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0

            dgvSaptas.DataSource = dt
            For i = 0 To dgvSaptas.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = dgvSaptas.Columns(i)
                ' col.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
            Next
        Else
        End If
        mDataSet = Nothing
    End Sub
    Private Sub imgLoad_Click()
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim dtime = DTdate.Value.ToString.Split(" ")
        Dim dateStart = dtime(0)
        StrTableName = "TAS_LORRY_LOAD"

        sqlCode = "select * from oilsys.view_lorry_load " & _
                  "where to_char(UPLOAD_DATE,'DD/MM/YYYY')= '" & dateStart & "' " & _
                  "order by load_number,delivery_order,compartment_number "

        If Oradb.OpenDys(sqlCode, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0

            dgvSaptas.DataSource = dt
            For i = 0 To dgvSaptas.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = dgvSaptas.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
        Else
        End If
        mDataSet = Nothing
    End Sub
    Private Sub imgOilsys_Click()
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim dtime = DTdate.Value.ToString.Split(" ")
        Dim dateStart = dtime(0)
        StrTableName = "TAS_LORRY_LOAD"

        sqlCode = "select * from oilsys.view_oilsys_lorry_load_monitor " & _
                "where to_char(UPLOAD_DATE,'DD/MM/YYYY')= '" & StrTableName & "' " & _
                "order by load_number,delivery_order,compartment_number "

        If Oradb.OpenDys(sqlCode, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0

            dgvSaptas.DataSource = dt
            For i = 0 To dgvSaptas.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = dgvSaptas.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
        Else
        End If
        mDataSet = Nothing
    End Sub
    Private Sub b_Search_Click(sender As System.Object, e As System.EventArgs) Handles b_Search.Click
        Select Case StrTableName
            Case "DO_INTERFACE_HEAD"
                Call imgHead_Click()
            Case "DO_INTERFACE_DETAIL"
                Call imgDetail_Click()
            Case "TAS_LORRY_LOAD"
                Call imgLoad_Click()
            Case "OILSYS_LORRY_LOAD"
                Call imgOilsys_Click()
            Case Else
        End Select
    End Sub

    Private Sub DTdate_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DTdate.ValueChanged
        Select Case StrTableName
            Case "DO_INTERFACE_HEAD"
                Call imgHead_Click()
            Case "DO_INTERFACE_DETAIL"
                Call imgDetail_Click()
            Case "TAS_LORRY_LOAD"
                Call imgLoad_Click()
            Case "OILSYS_LORRY_LOAD"
                Call imgOilsys_Click()
            Case Else
        End Select
    End Sub

 
    Private Sub lblDetail_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click, lblDetail.Click
        imgDetail_Click()
    End Sub

    Private Sub lblLoad_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click, lblLoad.Click
        imgLoad_Click()
    End Sub

    Private Sub lblOilsys_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click, lblOilsys.Click
        imgOilsys_Click()
    End Sub

    Private Sub dgvSaptas_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSaptas.CellClick
        If e.RowIndex > 0 Then
            Dim vIndex As Integer = dgvSaptas.CurrentRow.Index()
            SaleOrder = dgvSaptas.Rows(vIndex).Cells(0).Value
            ' Timer1.Enabled = False
        End If
    End Sub

    Private Sub UcbtRefresh_OnClickMnuText(ucName As String, ucScreenID As Long) Handles UcbtRefresh.OnClickMnuText
        Timer1.Start()
        'Select Case StrTableName
        '    Case "DO_INTERFACE_HEAD"
        '        Call imgHead_Click()
        '    Case "DO_INTERFACE_DETAIL"
        '        Call imgDetail_Click()
        '    Case "TAS_LORRY_LOAD"
        '        Call imgLoad_Click()
        '    Case "OILSYS_LORRY_LOAD"
        '        Call imgOilsys_Click()
        '    Case Else
        'End Select
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case StrTableName
            Case "DO_INTERFACE_HEAD"
                Call imgHead_Click()
            Case "DO_INTERFACE_DETAIL"
                Call imgDetail_Click()
            Case "TAS_LORRY_LOAD"
                Call imgLoad_Click()
            Case "OILSYS_LORRY_LOAD"
                Call imgOilsys_Click()
            Case Else
        End Select
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Timer1.Stop()
    End Sub
    Private Sub chkAutoRefresh_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAutoRefresh.CheckedChanged
        If chkAutoRefresh.Checked = True Then
            Timer1.Start()
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub dgvSaptas_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles dgvSaptas.Scroll
        'Timer1.Stop()
    End Sub
End Class