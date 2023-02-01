Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmProofSumOrder
    Public FormScreenID As Long
    Dim frm_work As Integer = 0  '1=add ,2=Edit

    Private Sub frmProofSumOrder_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmProofSumOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oldMeH = Me.Size.Height
        Dim oleMeW = Me.Size.Width
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start


        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        Initial_frm()
        InitialCombo()
        InitialCustomerCombo()
        InitailProductToGrid()
        InitailGridGroup()

        If cbType.Text = "ประจำวัน" Then
            dtpDay.Visible = True
            dtpMonth.Visible = False
        Else
            dtpDay.Visible = False
            dtpMonth.Visible = True
        End If
  
        CmdRefresh()
        resolution(Me, 1)
        ' cbType.SelectedIndex = 0
    End Sub

    Private Sub frmProofSumOrder_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub

    Private Sub Initial_frm()
        dtpDay.Value = Date.Today
        dtpMonth.Value = String.Format("{0:dd/MM/yyyy}", Date.Now)
    End Sub


    Private Sub DataGridView_Headers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView_Headers.CellClick
        Dim strColume As String
        If DataGridView_Headers.Rows.Count <= 0 Or DataGridView_Headers.CurrentRow.Index < 0 Then Exit Sub
        With DataGridView_Headers
            strColume = .Item(0, .CurrentRow.Index).Value

        End With
    End Sub


    Private Sub b_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        msGridSumGroup.Rows.Clear()
        InitailProductToGrid()
        InitailGridGroup()
    End Sub
    Private Sub InitialCustomerCombo()
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        Dim strDateStart = dtpDay.Value.ToString.Split(" ")
        Dim dateStart = strDateStart(0)
        CmbCusTomer.Items.Clear()
        CmbCusTomer.Text = ""

        CmbCusTomer.Text = "ALL"
        CmbCusTomer.Items.Add("ALL")


        If optAll.Checked = True Then
            strSQL = _
                 "select  t.customer_code ||'-'|| t.customer_name as custormer " & _
                 " from tas.customer t " & _
                 " order by t.customer_code "
        Else
            If cbType.Text = "ประจำวัน" Then
                strSQL = _
                       "select  t.customer_code ||'-'|| t.customer_name as custormer " & _
                       " from tas.customer t " & _
                       " where t.customer_code in (select h.customer_code " & _
                                                   " from tas.do_header h " & _
                                                     " where trunc(h.plan_date)= to_date('" & dateStart & "','dd/mm/yyyy hh24:mi:ss'))" & _
                       " order by t.customer_code "
            Else
                strSQL = _
                 "select  t.customer_code ||'-'|| t.customer_name as custormer " & _
                 " from tas.customer t " & _
                 " where t.customer_code in (select h.customer_code " & _
                                             " from tas.do_header h " & _
                                             " where to_char(h.plan_date)= to_char('" & Format(dtpMonth.Value, "MM/yyyy") & "'))" & _
                 " order by t.customer_code "
            End If
           
        End If
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            For Each dr As DataRow In dt.Rows
                CmbCusTomer.Items.Add(dr.Item("custormer"))
            Next
        End If

    End Sub
    Private Sub InitialCombo()
        cmbType.Text = "ปริมาณ"
        cmbType.Items.Add("ปริมาณ")
        cmbType.Items.Add("จำนวนคัน")

        cbType.Text = "ประจำวัน"
        cbType.Items.Add("ประจำวัน")
        cbType.Items.Add("ประจำเดือน")
      
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub InitailProductToGrid()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i, j, k As Integer


        sql_str = _
             "select  sp.sale_product_code  , sp.unit   ,b.color_code,b.quota_qty,b.is_quota,sp.group_name  " & _
             " from tas.sale_product  sp  ,  tas.view_sale_base_product  vs , tas.base_product  b  " & _
             "  where sp.sale_product_id = vs.SALE_PRODUCT_ID (+)   and vs.BASE_PRODUCT_ID =b.base_product_id(+)  order by sp.group_name,sp.sale_product_code "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            j = 0
            k = 0
            DataGridView_Headers.RowCount = 0
            Do While dt.Rows.Count > i

                DataGridView_Headers.RowCount = DataGridView_Headers.RowCount + 1
                DataGridView_Headers.Rows.Item(i).Height = Grid_Height
                DataGridView_Headers.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("sale_product_code")), "", dt.Rows(i).Item("sale_product_code").ToString)
                If IsDBNull(dt.Rows(i).Item("COLOR_CODE")) Then
                    DataGridView_Headers.Item(1, i).Value = 0
                    DataGridView_Headers.Item(1, i).Style.BackColor = Color.Black
                Else
                    Dim colour As String
                    colour = dt.Rows(i).Item("COLOR_CODE").ToString()
                    DataGridView_Headers.Item(1, i).Value = appendZero(Hex(colour).ToString())
                    DataGridView_Headers.Item(1, i).Style.BackColor = ColorTranslator.FromHtml("#" + appendZero(Hex(colour).ToString()))
                End If
                DataGridView_Headers.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("quota_qty")), "", IIf(dt.Rows(i).Item("quota_qty").ToString = "1", dt.Rows(i).Item("quota_qty"), "Uncheck"))
                DataGridView_Headers.Item(3, i).Value = 0
                DataGridView_Headers.Item(4, i).Value = 0
                DataGridView_Headers.Item(5, i).Value = 0
                DataGridView_Headers.Item(6, i).Value = 0
                DataGridView_Headers.Item(7, i).Value = 0
                DataGridView_Headers.Item(8, i).Value = 0

             
                DataGridView_Headers.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("unit")), "", dt.Rows(i).Item("unit").ToString)



                i = i + 1

            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub
    Public Sub InitailGridGroup()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim k As Integer


        sql_str = _
               " select  max(t.sale_product_id)  as sale_product_id  ,t.group_name , max(t.unit) as unit " & _
                   " from  tas.sale_product  t " & _
                   " group by t.group_name " & _
                   " order by max(t.group_name)"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            k = 0
            msGridSumGroup.RowCount = 0
            Do While dt.Rows.Count > k
                msGridSumGroup.RowCount = msGridSumGroup.RowCount + 1
                msGridSumGroup.Rows.Item(k).Height = Grid_Height
                msGridSumGroup.Item(0, k).Value = IIf(IsDBNull(dt.Rows(k).Item("group_name")), "", dt.Rows(k).Item("group_name").ToString)
                msGridSumGroup.Item(1, k).Value = "Uncheck"
                msGridSumGroup.Item(2, k).Value = 0
                msGridSumGroup.Item(3, k).Value = 0
                msGridSumGroup.Item(4, k).Value = 0
                msGridSumGroup.Item(5, k).Value = 0
                msGridSumGroup.Item(6, k).Value = 0
                msGridSumGroup.Item(7, k).Value = 0
                msGridSumGroup.Item(8, k).Value = IIf(IsDBNull(dt.Rows(k).Item("unit")), "", dt.Rows(k).Item("unit").ToString)

                k = k + 1

            Loop
        Else
        End If
        mDataSet = Nothing

    End Sub

    Private Sub CmbCusTomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCusTomer.SelectedIndexChanged
        Dim StrTmp() As String
        If Trim(CmbCusTomer.Text) <> "ALL" Then
            StrTmp = Split(CmbCusTomer.Text, "-")
            txtCusCode.Text = StrTmp(0)
            txtCusName.Text = StrTmp(1)
        Else
            txtCusCode.Text = "-"
            txtCusName.Text = "-"
        End If
        InitailProductToGrid()
        InitailGridGroup()
        CmdRefresh()
    End Sub

    Private Sub optAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll.CheckedChanged
        CmbCusTomer.Text = ""
        InitialCustomerCombo()
    End Sub

    Private Sub optAll2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll2.CheckedChanged
        CmbCusTomer.Text = ""
        InitialCustomerCombo()
    End Sub
    Private Function updateColorCode(ByVal codeColour As String) As String
        If codeColour = "" Then
            codeColour = "FFFFFF"
        End If
        Dim i As Integer = 6 - codeColour.Length
        While (i <> 0)
            codeColour = "0" + codeColour
            i = i - 1
        End While

        Dim newCode = codeColour(4) + codeColour(5) + codeColour(2) + codeColour(3) + codeColour(0) + codeColour(1)

        Return newCode
    End Function
    Private Function appendZero(ByVal codeColour As String) As String
        Dim i As Integer = 6 - codeColour.Length
        While (i <> 0)
            codeColour = "0" + codeColour
            i = i - 1
        End While
        Return codeColour
    End Function
    Private Sub GetstrQueueryTUGroup(iRow As Integer, iCol As Integer)
        Dim strSQL As String
        Select Case iCol
            Case 2
                strSQL = _
                         " select " & _
                         " t.DO_NO  " & _
                         " ,t.group_name  " & _
                         " from rpt.sum_do t " & _
                         " Where t.CANCEL_STATUS=0 "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                 " and t.customer_code ='" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                                 " group by t.DO_NO,t.group_name "

                strSQL = _
                            " select " & _
                            " a.group_name  " & _
                            " ,count(a.DO_NO) as  DO_COUNT " & _
                            " from (" & strSQL & ") a" & _
                            " group by a.group_name "

                Call FillTUGroupCount(strSQL, iCol)
            Case 3
                strSQL = _
                     " select " & _
                     " t.DO_NO  " & _
                     " ,t.group_name  " & _
                     " from rpt.sum_do t " & _
                     " Where t.CANCEL_STATUS=0 " & _
                     " and t.Do_Status =0 "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                 " and t.customer_code ='" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                                 " group by t.DO_NO,t.group_name "

                strSQL = _
                            " select " & _
                            " a.group_name  " & _
                            " ,count(a.DO_NO) as  DO_COUNT " & _
                            " from (" & strSQL & ") a" & _
                            " group by a.group_name "

                Call FillTUGroupCount(strSQL, iCol)

            Case 4
                strSQL = _
                            " select " & _
                            " t.LOAD_HEADER_NO " & _
                            " ,t.group_name " & _
                            " from rpt.sum_load t " & _
                            " Where t.CANCEL_STATUS=0 " & _
                            " and t.LOAD_STATUS <51 "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                     " and t.customer_code = '" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                     " group by t.LOAD_HEADER_NO,t.group_name "

                strSQL = _
                        " select " & _
                        " a.group_name  " & _
                        " ,count(a.LOAD_HEADER_NO) as  DO_COUNT " & _
                        " from (" & strSQL & ") a" & _
                        " group by a.group_name "

                Call FillTUGroupCount(strSQL, iCol)

            Case 5
                strSQL = _
                            " select " & _
                            " t.LOAD_HEADER_NO " & _
                            " ,t.group_name " & _
                            " from rpt.sum_load t " & _
                            " Where t.CANCEL_STATUS=0 " & _
                            " and t.LOAD_STATUS in (51,52,53,54)  "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                     " and t.customer_code = '" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                     " group by t.LOAD_HEADER_NO,t.group_name "

                strSQL = _
                        " select " & _
                        " a.group_name  " & _
                        " ,count(a.LOAD_HEADER_NO) as  DO_COUNT " & _
                        " from (" & strSQL & ") a" & _
                        " group by a.group_name "

                Call FillTUGroupCount(strSQL, iCol)

            Case 6
                strSQL = _
                            " select " & _
                            " t.LOAD_HEADER_NO " & _
                            " ,t.group_name " & _
                            " from rpt.sum_load t " & _
                            " Where t.CANCEL_STATUS=0 " & _
                            " and t.LOAD_STATUS > 54 "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                     " and t.customer_code = '" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                     " group by t.LOAD_HEADER_NO,t.group_name "

                strSQL = _
                        " select " & _
                        " a.group_name  " & _
                        " ,count(a.LOAD_HEADER_NO) as  DO_COUNT " & _
                        " from (" & strSQL & ") a" & _
                        " group by a.group_name "

                Call FillTUGroupCount(strSQL, iCol)

            Case 7
                strSQL = _
                            " select " & _
                            " t.LOAD_HEADER_NO " & _
                            " ,t.group_name " & _
                            " from rpt.sum_load t " & _
                            " Where t.CANCEL_STATUS=0 " & _
                            " and t.LOAD_STATUS > 54 "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                     " and t.customer_code = '" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                     " group by t.LOAD_HEADER_NO,t.group_name "

                strSQL = _
                        " select " & _
                        " a.group_name  " & _
                        " ,count(a.LOAD_HEADER_NO) as  DO_COUNT " & _
                        " from (" & strSQL & ") a" & _
                        " group by a.group_name "

                Call FillTUGroupCount(strSQL, iCol)
        End Select

    End Sub
    Private Function FillTUGroupCount(ByVal strSQL As String, ByVal iCol As Integer)
        Dim i As Integer
        Dim r As Integer
        'Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        Try
            'With msGridSumGroup
            '    For i = 1 To .Rows.Count - 1
            '        .Item(iCol + 1, i).Value = "0 คัน"
            '    Next i
            'End With
            If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                i = 0

                With msGridSumGroup
                    If dt.Rows.Count > 0 Then
                        For i = 0 To dt.Rows.Count - 1
                            r = GetSumGroupOrderRowIndex(dt.Rows(i).Item("group_name"))
                            If r >= 0 Then
                                .Item(iCol, r).Value = IIf(IsDBNull(dt.Rows(i).Item("DO_COUNT")), "0", dt.Rows(i).Item("DO_COUNT").ToString) & " คัน"
                            End If
                        Next i
                    End If
                End With
            End If
        Catch ex As Exception

        End Try
        mDataSet = Nothing
        Return True
    End Function
    Private Sub CmdRefresh()
        Dim i As Integer = 1
        Dim j As Integer

        Dim strDateStart = dtpDay.Value.ToString.Split(" ")
        Dim dateStart = strDateStart(0)
        If cbType.Text = "ประจำวัน" Then
            Call proc_sum_order(dateStart, 1)
        Else
            Call proc_sum_orderMonth(Format(dtpMonth.Value, "MM/yyyy"), 1)
        End If
     
        With(DataGridView_Headers)
            For j = 3 To DataGridView_Headers.ColumnCount - 2
                If Trim(cmbType.Text) = "ปริมาณ" Then
                    'MessageBox.Show(DataGridView_Headers.Rows(i).Cells(0).Value)
                    Call GetstrQueuery(CInt(i), CInt(j))
                Else
                    Call GetstrQueueryTU(CInt(i), CInt(j))
                End If
            Next j
            'Next i
        End With
        With msGridSumGroup
            'For i = 1 To .rows - 1
            i = 0
            For j = 0 To msGridSumGroup.ColumnCount - 1
                If Trim(cmbType.Text) = "ปริมาณ" Then
                    Call GetstrQueuerySumGroup(CInt(i), CInt(j))
                Else
                    Call GetstrQueueryTUGroup(CInt(i), CInt(j))
                End If
            Next j
            'Next i
        End With


    End Sub
    Private Sub GetstrQueuerySumGroup(iRow As Integer, iCol As Integer)
        Dim strSQL As String
        'Dim Oratemp As OraDynaset
        Select Case iCol
            Case 2
                strSQL = _
                                 " select " & _
                                 " t.group_name " & _
                                 " ,sum(t.QUANTITY) as QTY " & _
                                 " from rpt.sum_do t " & _
                                " Where t.CANCEL_STATUS=0 "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                 " and t.customer_code ='" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                                  " group by t.group_name "

                Call FillSumGroupOrder(strSQL, iCol)
            Case 3

                strSQL = _
                                  " select " & _
                                  " t.group_name " & _
                                  " ,sum(t.QUANTITY) as QTY " & _
                                  " from rpt.sum_do t " & _
                                 " Where t.CANCEL_STATUS=0 " & _
                                 " and t.Do_Status =0"
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                    " and t.customer_code ='" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                                  " group by t.group_name "

                Call FillSumGroupOrder(strSQL, iCol)
            Case 4
                strSQL = _
                               " select " & _
                               " t.group_name " & _
                               " ,sum(t.quantity) as QTY " & _
                               " from rpt.sum_load t " & _
                               " Where t.CANCEL_STATUS=0 " & _
                               " and t.LOAD_STATUS <51 "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                     " and t.customer_code = '" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                                   " group by t.group_name "

                Call FillSumGroupOrder(strSQL, iCol)

            Case 5

                strSQL = _
                                    " select " & _
                                    " t.group_name " & _
                                    " ,sum(t.quantity) as QTY " & _
                                    " from rpt.sum_load t " & _
                                    " Where t.CANCEL_STATUS=0 " & _
                                    " and t.LOAD_STATUS in (51,52,53,54) "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                     " and t.customer_code = '" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                                      " group by t.group_name "

                Call FillSumGroupOrder(strSQL, iCol)
            Case 6
                strSQL = _
                                   " select " & _
                                   " t.group_name " & _
                                   " ,sum(t.quantity) as QTY " & _
                                   " from rpt.sum_load t " & _
                                   " Where t.CANCEL_STATUS=0 " & _
                                   " and t.LOAD_STATUS > 55 "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                     " and t.customer_code = '" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                                       " group by t.group_name "

                Call FillSumGroupOrder(strSQL, iCol)
            Case 7

                strSQL = _
                                " select " & _
                                " t.group_name " & _
                                " ,sum(t.loaded_vol30c) as QTY" & _
                                " ,sum(t.weight_net) As weight_net" & _
                                " from rpt.sum_load t " & _
                                " Where t.CANCEL_STATUS=0 " & _
                                " and t.LOAD_STATUS > 55 "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                     " and t.customer_code = '" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                                          " group by t.group_name "

                Call FillSumGroupOrder(strSQL, iCol)

        End Select

    End Sub

    Private Function FillSumGroupOrder(ByVal strSQL As String, ByVal iCol As Integer)
        Dim i As Integer
        Dim r As Integer
        'Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        'With msGridSumGroup
        '    For i = 1 To .Rows.Count - 1
        '        .Item(iCol + 1, i).Value = 0
        '    Next i
        'End With
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            If dt.Rows.Count > 0 Then
                For i = 0 To dt.Rows.Count - 1
                    r = GetSumGroupOrderRowIndex(dt.Rows(i).Item("group_name"))
                    If r >= 0 Then
                        If iCol = 7 Then
                            If msGridSumGroup.Item(8, r).Value = "KG" Then
                                msGridSumGroup.Item(iCol, r).Value = IIf(IsDBNull(dt.Rows(i).Item("weight_net")), "0", dt.Rows(i).Item("weight_net").ToString)
                            Else
                                msGridSumGroup.Item(iCol, r).Value = IIf(IsDBNull(dt.Rows(i).Item("QTY")), "0", dt.Rows(i).Item("QTY").ToString)
                            End If
                        Else
                            msGridSumGroup.Item(iCol, r).Value = IIf(IsDBNull(dt.Rows(i).Item("QTY")), "0", dt.Rows(i).Item("QTY").ToString)
                        End If
                    End If
                Next i
            End If
        End If

        mDataSet = Nothing
        Return True
    End Function
    Private Sub proc_sum_order(ByVal iDateSum As Date, ByVal iTypeSum As Integer)
        Dim strSQL As String

        strSQL = _
                       " begin rpt.proc_sum_order1(to_date('" & iDateSum & "','dd/mm/yyyy')," & iTypeSum & "); end; "
        If Oradb.ExeSQL(strSQL) Then

        End If
    End Sub
    Private Sub proc_sum_orderMonth(ByVal iDateSum As Date, ByVal iTypeSum As Integer)
        Dim strSQL As String

        strSQL = _
                       " begin rpt.proc_sum_order('M',to_date('" & iDateSum & "','dd/MM/yyyy')," & iTypeSum & "); end; "
        If Oradb.ExeSQL(strSQL) Then

        End If
    End Sub
    Private Sub GetstrQueuery(iRow As Integer, iCol As Integer)
        Dim strSQL As String
        'Dim Oratemp As OraDynaset
        Select Case iCol
            Case 3
                strSQL = _
                                 " select " & _
                                 " t.sale_product_code  " & _
                                 " ,sum(t.QUANTITY) as QTY " & _
                                 " from rpt.sum_do t " & _
                                 " Where t.CANCEL_STATUS=0 "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                 " and t.customer_code ='" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                                 " group by t.sale_product_code "

                Call FillSumOrder(strSQL, iCol)

            Case 4
                strSQL = _
                        " select " & _
                        " t.sale_product_code  " & _
                        " ,sum(t.QUANTITY) as QTY " & _
                        " from rpt.sum_do t " & _
                        " Where t.CANCEL_STATUS=0 " & _
                        " and t.Do_Status =0"
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                 " and t.customer_code ='" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                                 " group by t.sale_product_code "

                Call FillSumOrder(strSQL, iCol)
            Case 5
                strSQL = _
                            " select " & _
                            " t.sale_product_code " & _
                            " ,sum(t.quantity) as QTY " & _
                            " from rpt.sum_load t " & _
                            " Where t.CANCEL_STATUS=0 " & _
                            " and t.LOAD_STATUS <51 "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                     " and t.customer_code = '" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                                    " group by t.sale_product_code "

                Call FillSumOrder(strSQL, iCol)
            Case 6
                strSQL = _
                            " select " & _
                            " t.sale_product_code " & _
                            " ,sum(t.quantity) as QTY " & _
                            " from rpt.sum_load t " & _
                            " Where t.CANCEL_STATUS=0 " & _
                            " and t.LOAD_STATUS in (51,52,53,54) "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                     " and t.customer_code = '" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                                    " group by t.sale_product_code "

                Call FillSumOrder(strSQL, iCol)
            Case 7
                strSQL = _
                            " select " & _
                            " t.sale_product_code " & _
                            " ,sum(t.quantity) as QTY " & _
                            " from rpt.sum_load t " & _
                            " Where t.CANCEL_STATUS=0 " & _
                            " and t.LOAD_STATUS > 55 "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                     " and t.customer_code = '" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                                    " group by t.sale_product_code "

                Call FillSumOrder(strSQL, iCol)
            Case 8
                strSQL = _
                            " select " & _
                            " t.sale_product_code " & _
                            " ,sum(t.loaded_vol30c) as QTY" & _
                            " ,sum(t.weight_net) As weight_net" & _
                            " from rpt.sum_load t " & _
                            " Where t.CANCEL_STATUS=0 " & _
                            " and t.LOAD_STATUS > 55 "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                     " and t.customer_code = '" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                                    " group by t.sale_product_code "

                Call FillSumOrder(strSQL, iCol)
        End Select

    End Sub

    Private Function GetSumOrderRowIndex(ByVal ProductCode As String)
        Dim i As Integer
        Dim r As Integer

        r = -1

        With DataGridView_Headers
            For i = 0 To .RowCount - 1
                If DataGridView_Headers.Item(0, i).Value.Equals(ProductCode) Then
                    r = i
                    Exit For
                End If
            Next i
        End With

        GetSumOrderRowIndex = r
    End Function

    Private Function GetSumGroupOrderRowIndex(ByVal ProductCode As String)
        Dim i As Integer
        Dim r As Integer

        r = -1

        With msGridSumGroup
            For i = 0 To .RowCount - 1
                If msGridSumGroup.Item(0, i).Value.Equals(ProductCode) Then
                    r = i
                    Exit For
                End If
            Next i
        End With

        GetSumGroupOrderRowIndex = r
    End Function
    Public Function FillSumOrder(ByVal strSQL As String, ByVal iCol As Integer)
        Dim i As Integer
        Dim r As Integer
        'Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

    
        With DataGridView_Headers
            'For i = 0 To .RowCount
            '    DataGridView_Headers.Item(iCol, i).Value = "0"
            'Next i
            i = 0
            If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                If dt.Rows.Count > 0 Then
                    For i = 0 To dt.Rows.Count - 1
                        r = GetSumOrderRowIndex(dt.Rows(i).Item("sale_product_code"))
                        If r >= 0 Then

                            If iCol = 8 Then
                                If .Item(9, r).Value = "KG" Then
                                    .Item(iCol, r).Value = IIf(IsDBNull(dt.Rows(i).Item("weight_net")), "0", dt.Rows(i).Item("weight_net").ToString)
                                Else
                                    .Item(iCol, r).Value = IIf(IsDBNull(dt.Rows(i).Item("QTY")), "0", dt.Rows(i).Item("QTY").ToString)
                                End If
                            Else
                                .Item(iCol, r).Value = IIf(IsDBNull(dt.Rows(i).Item("QTY")), "0", dt.Rows(i).Item("QTY").ToString)
                            End If

                        End If
                    Next i
                    'r = r + 1
                    'DataGridView_Headers.Item(r, i).Value = "0"
                    'Loop
                End If
                'Catch ex As Exception
            End If
        End With

        mDataSet = Nothing
        Return True
    End Function
    Private Sub GetstrQueueryTU(iRow As Integer, iCol As Integer)
        Dim strSQL As String
        'Dim Oratemp As OraDynaset
        Select Case iCol
            Case 3
                strSQL = _
                        " select " & _
                        " t.DO_NO  " & _
                        " ,t.sale_product_code  " & _
                        " from rpt.sum_do t " & _
                        " Where t.CANCEL_STATUS=0 "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                 " and t.customer_code ='" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                                 " group by t.DO_NO,t.sale_product_code "

                strSQL = _
                            " select " & _
                            " a.sale_product_code  " & _
                            " ,count(a.DO_NO) as  DO_COUNT " & _
                            " from (" & strSQL & ") a" & _
                            " group by a.sale_product_code "

                Call FillCountTU(strSQL, iCol)

            Case 4

                strSQL = _
                        " select " & _
                        " t.DO_NO  " & _
                        " ,t.sale_product_code  " & _
                        " from rpt.sum_do t " & _
                        " Where t.CANCEL_STATUS=0 " & _
                        " and t.Do_Status =0"
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                 " and t.customer_code ='" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                                 " group by t.DO_NO,t.sale_product_code "

                strSQL = _
                            " select " & _
                            " a.sale_product_code  " & _
                            " ,count(a.DO_NO) as  DO_COUNT " & _
                            " from (" & strSQL & ") a" & _
                            " group by a.sale_product_code "

                Call FillCountTU(strSQL, iCol)
            Case 5

                strSQL = _
                        " select " & _
                        " t.LOAD_HEADER_NO " & _
                        " ,t.sale_product_code " & _
                        " from rpt.sum_load t " & _
                        " Where t.CANCEL_STATUS=0 " & _
                        " and t.LOAD_STATUS <51 "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                     " and t.customer_code = '" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                     " group by t.LOAD_HEADER_NO,t.sale_product_code "

                strSQL = _
                        " select " & _
                        " a.sale_product_code  " & _
                        " ,count(a.LOAD_HEADER_NO) as  DO_COUNT " & _
                        " from (" & strSQL & ") a" & _
                        " group by a.sale_product_code "

                Call FillCountTU(strSQL, iCol)
            Case 6

                strSQL = _
                            " select " & _
                            " t.LOAD_HEADER_NO " & _
                            " ,t.sale_product_code " & _
                            " from rpt.sum_load t " & _
                            " Where t.CANCEL_STATUS=0 " & _
                            " and t.LOAD_STATUS in (51,52,53,54) "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                     " and t.customer_code = '" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                     " group by t.LOAD_HEADER_NO,t.sale_product_code "

                strSQL = _
                        " select " & _
                        " a.sale_product_code  " & _
                        " ,count(a.LOAD_HEADER_NO) as  DO_COUNT " & _
                        " from (" & strSQL & ") a" & _
                        " group by a.sale_product_code "

                Call FillCountTU(strSQL, iCol)
            Case 7

                strSQL = _
                            " select " & _
                            " t.LOAD_HEADER_NO " & _
                            " ,t.sale_product_code " & _
                            " from rpt.sum_load t " & _
                            " Where t.CANCEL_STATUS=0 " & _
                            " and t.LOAD_STATUS > 54 "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                     " and t.customer_code = '" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                     " group by t.LOAD_HEADER_NO,t.sale_product_code "

                strSQL = _
                        " select " & _
                        " a.sale_product_code  " & _
                        " ,count(a.LOAD_HEADER_NO) as  DO_COUNT " & _
                        " from (" & strSQL & ") a" & _
                        " group by a.sale_product_code "

                Call FillCountTU(strSQL, iCol)
            Case 8

                strSQL = _
                            " select " & _
                            " t.LOAD_HEADER_NO " & _
                            " ,t.sale_product_code " & _
                            " from rpt.sum_load t " & _
                            " Where t.CANCEL_STATUS=0 " & _
                            " and t.LOAD_STATUS > 54 "
                If Trim(CmbCusTomer.Text) <> "ALL" Then
                    strSQL = strSQL & _
                                     " and t.customer_code = '" & Trim(txtCusCode.Text) & "'"
                End If
                strSQL = strSQL & _
                     " group by t.LOAD_HEADER_NO,t.sale_product_code "

                strSQL = _
                        " select " & _
                        " a.sale_product_code  " & _
                        " ,count(a.LOAD_HEADER_NO) as  DO_COUNT " & _
                        " from (" & strSQL & ") a" & _
                        " group by a.sale_product_code "

                Call FillCountTU(strSQL, iCol)
        End Select

    End Sub
    Private Function FillCountTU(ByVal strSQL As String, ByVal iCol As Integer)

        Dim i As Integer
        Dim r As Integer
        'Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        Try
            If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                i = 0

                With DataGridView_Headers
                    For i = 0 To dt.Rows.Count - 1
                        r = GetSumOrderRowIndex(dt.Rows(i).Item("sale_product_code"))
                        If r >= 0 Then
                                DataGridView_Headers.Item(iCol, r).Value = IIf(IsDBNull(dt.Rows(i).Item("DO_COUNT")), "0", dt.Rows(i).Item("DO_COUNT").ToString) & " คัน"
                            End If
                    Next i
                End With
            End If
        Catch ex As Exception

        End Try
     

        mDataSet = Nothing
        Return True
    End Function


    Private Sub UcMenuCheck_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuCheck.OnClickMnuText
        frmProofMonitorLoadProduct.Show()
    End Sub

    Private Sub UcMenutxtSub1_OnClickMnuText(ucName As String, ucScreenID As Long) Handles UcMenutxtSub1.OnClickMnuText
        'msGridSumGroup.Rows.Clear()
        InitailProductToGrid()
        InitailGridGroup()
        CmdRefresh()
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

    Private Sub cmbType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        'msGridSumGroup.RowCount = 0
        InitailProductToGrid()
        InitailGridGroup()
        CmdRefresh()
    End Sub

    Private Sub dtpDay_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpDay.ValueChanged
        'InitailProductToGrid()
        'InitailGridGroup()
        'CmdRefresh()
    End Sub



    Private Sub cbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbType.SelectedIndexChanged
        If cbType.Text = "ประจำวัน" Then
            dtpDay.Visible = True
            dtpMonth.Visible = False
        Else
            dtpDay.Visible = False
            dtpMonth.Visible = True
        End If
        InitailProductToGrid()
        InitailGridGroup()
        CmdRefresh()
    End Sub

    Private Sub UcMenutxtSub2_OnClickMnuText(ucName As String, ucScreenID As Long) Handles UcMenutxtSub2.OnClickMnuText
        frmProofCheckBitument.ShowDialog()
    End Sub
End Class