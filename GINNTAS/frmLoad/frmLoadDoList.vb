Public Class frmLoadDoList
    Public frm_Request_txtdo As Integer ' 0= frmLoadLoading_sub,1=frmUtlOverrideCR
    Dim strDo = ""

    Private Sub frmLoadDoList_sub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Show_Data()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPpicker.ValueChanged
        Show_Data()
    End Sub

    Public Sub Show_Data()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim strDTPpicker = DTPpicker.Value.ToString.Split(" ")
        Dim sDTPpicker = strDTPpicker(0)

        sql_str = " select t.do_no ,t.Do_customer"
        sql_str = sql_str & " from tas.do_header t "
        sql_str = sql_str & " Where t.cancel_status = 0 "
        sql_str = sql_str & " and t.do_status =0 "
        sql_str = sql_str & " and trunc(t.plan_date) = to_date('" & sDTPpicker & "','dd/mm/yyyy')"
        If txtDoFind.Text <> "" Then
            sql_str = sql_str & " and t.do_no = '" & txtDoFind.Text & "'"
        End If

        sql_str = sql_str & " order by t.do_no desc "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            MSGridDo.RowCount = 0
            Do While dt.Rows.Count > i

                MSGridDo.RowCount = MSGridDo.RowCount + 1
                MSGridDo.Item(0, i).Value = i + 1
                MSGridDo.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Do_no")), "", dt.Rows(i).Item("Do_no").ToString)
                MSGridDo.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Do_customer")), "", dt.Rows(i).Item("Do_customer").ToString)

                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub CmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRefresh.Click
        txtDoFind.Text = ""
        Show_Data()

    End Sub

    Private Sub DataGridView2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSGridDOSelect.Click
        If MSGridDOSelect.RowCount > 0 Then
            Dim index As Integer = MSGridDOSelect.CurrentRow.Index
            MSGridDOSelect.Rows.RemoveAt(index)
        End If
    End Sub

    Public Sub ShowDataGridDoLine(ByVal strData As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        Dim strDTPpicker = DTPpicker.Value.ToString.Split(" ")
        Dim sDTPpicker = strDTPpicker(0)

        sql_str = ""
        sql_str = _
        "select d.do_no,d.material_no,d.quantity,d.sale_unit" & _
        " from do_lines d " & _
        " where d.do_no= '" & strData & "' "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            MSGridDOLine.RowCount = 0
            Do While dt.Rows.Count > i

                MSGridDOLine.RowCount = MSGridDOLine.RowCount + 1
                MSGridDOLine.Item(0, i).Value = i + 1
                MSGridDOLine.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("material_no")), "", dt.Rows(i).Item("material_no").ToString)
                MSGridDOLine.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("quantity")), "", dt.Rows(i).Item("quantity").ToString)
                MSGridDOLine.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("sale_unit")), "", dt.Rows(i).Item("sale_unit").ToString)

                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Sub addDataGridDo()
        If MSGridDo.RowCount > 0 Then

            Dim index As Integer = MSGridDo.CurrentRow.Index
            ShowDataGridDoLine(MSGridDo.Rows(index).Cells(1).Value.ToString)
            Dim i, J

            J = 0
            Do While MSGridDOSelect.RowCount > J
                If MSGridDOSelect.Item(1, J).Value = MSGridDo.Rows(index).Cells(1).Value.ToString Then
                    MessageBox.Show("มี DO เลขที่ " & MSGridDo.Rows(index).Cells(1).Value.ToString & "อยู่ในรายการแล้ว")
                    Exit Sub
                End If

                J = J + 1
            Loop
            i = MSGridDOSelect.RowCount
            MSGridDOSelect.RowCount = MSGridDOSelect.RowCount + 1
            MSGridDOSelect.Item(0, i).Value = MSGridDo.Rows(index).Cells(0).Value.ToString
            MSGridDOSelect.Item(1, i).Value = MSGridDo.Rows(index).Cells(1).Value.ToString
        End If

    End Sub

    Private Sub CmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSelect.Click
        addDataGridDo()
    End Sub

    Private Sub DataGridView1_DoubleClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSGridDo.DoubleClick
        addDataGridDo()
    End Sub

    Private Sub CmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOK.Click
        Dim j = 0
        Do While MSGridDOSelect.RowCount > j
            If j = 0 Then
                strDo = strDo & MSGridDOSelect.Rows(j).Cells(1).Value.ToString
            Else
                strDo = strDo & "," & MSGridDOSelect.Rows(j).Cells(1).Value.ToString
            End If
            j = j + 1
        Loop
        If frm_Request_txtdo = 0 Then
            frmLoadLoading_sub.txtDo.Text = strDo
            frmLoadCreateLoad.txtDo.Text = strDo
        ElseIf frm_Request_txtdo = 1 Then
            frmUtlOverrideCR.txtDo.Text = strDo
        End If
        'frmLoadLoading_sub.txtDo.Text = strDo
        Me.Close()

    End Sub

    Private Sub txtDoFind_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtDoFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Show_Data()
        End If
    End Sub

    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub


End Class