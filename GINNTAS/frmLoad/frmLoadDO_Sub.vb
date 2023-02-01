Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmLoadDO_Sub
    Dim frm_work As Integer = 0 'DO=add ,2=Edit
    Dim pk_id As String = ""

    Public Sub setFrmWork(ByVal n As Integer)
        Me.frm_work = n
    End Sub

    Public Sub setPkId(ByVal id As String)
        Me.pk_id = id
    End Sub

    Private Sub frmLoadDO_Sub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        InitialCombo()

        cbMeasueQTY.SelectedIndex = 0
        cbCalQTY.SelectedIndex = 1
        txtCountSaleProduct.Text = 1
        If frm_work = 1 Then
            Me.Text = "D/O # Add"
        ElseIf frm_work = 2 Then
            Me.Text = "D/O # Edit"
            ShowData_Edit()
        End If
    End Sub

    Private Sub Clear_frm()
        txtDoNo.Text = ""
        txtSaleOrder.Text = ""
        cbCustomer.Text = ""
        cbShipTo.Text = ""
        cbMeasueQTY.Text = ""
        cbCalQTY.Text = ""
        Picker_Require_Date.Value = Now
        Picker_Require_Time.Value = Convert.ToDateTime(Picker_Require_Time.Value.Date.ToLongDateString & " " & "00:00:00")
        txtDodate.Text = ""
        txtPoNo.Text = ""
        txtIndDep.text = ""
        txtConTract.Text = ""
        txtToProject.Text = ""
        OptActive.Checked = True
        OptDistribution_Local.Checked = True
        txtUpdate_date.Text = ""
        txtUpdate_by.Text = ""
        txtCountSaleProduct.Text = ""
    End Sub

    Private Sub InitialCombo()
        Call initial_cbCustomer()
        Call initial_cbMeasueQTY()
        Call initial_cbCalQTY()
    End Sub

    Private Sub ShowData_Edit()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        sql_str = " SELECT L.DO_NO,SPECIAL_TEXT1,L. ITEM_NO,L.MATERIAL_NO,L.QUANTITY, D.SALE_ORDER ,D.DISTRIBUTION_CHANEL,"
        sql_str = sql_str & " L.SALE_UNIT,D.WEIGHT_UNIT,L.PLANT,L.STORAGE_LOCATION ,L.SHIPTO_NAME,"
        sql_str = sql_str & " L.TRQNT  ,L.STATUS , L.CREATION_DATE, L.CREATED_BY, L.UPDATE_DATE, D.SHIPTO_PONO,D.SHIPTO_INDDEP,D.SHIPTO_TOPROJECT,D.SHIPTO_CONTRACT,"
        sql_str = sql_str & " L.UPDATED_BY, L.J_COMPUTER, S.SALE_PRODUCT_NAME,"
        sql_str = sql_str & " D.GOV_PROJECT,D.CUSTOMER_CODE,D.SHIPTO,D.DOCUMENT_DATE,D.J_COMPUTER,SPECIAL_TEXT1,"
        sql_str = sql_str & " D.PLAN_DATE,D.DO_STATUS,D.CREATION_DATE,D.CREATED_BY,C.CUSTOMER_NAME,"
        sql_str = sql_str & " C.CUSTOMER_CODE ||'--'||C.CUSTOMER_NAME AS CUSTOMER , D.SHIP_TO_CODE ||'--'||D.SHIPTO AS SHIPTOMiX , D.MEASURE_MOTHOD , D.CALCULATE_MOTHOD "
        sql_str = sql_str & " FROM DO_LINES L,SALE_PRODUCT S,DO_HEADER D,CUSTOMER C"
        sql_str = sql_str & " WHERE  L.MATERIAL_NO=S.SALE_PRODUCT_ID AND L.DO_NO='" & pk_id & "'   "
        sql_str = sql_str & " AND D.DO_NO=L.DO_NO AND D.CUSTOMER_CODE=C.CUSTOMER_CODE ORDER BY L.ITEM_NO"
        Try
            If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                txtCountSaleProduct.Text = dt.Rows.Count
                If dt.Rows.Count > 0 Then
                    cbCustomer.Text = IIf(IsDBNull(dt.Rows(i).Item("CUSTOMER")), "", dt.Rows(i).Item("CUSTOMER").ToString)
                    cbShipTo.Text = IIf(IsDBNull(dt.Rows(i).Item("SHIPTOMiX")), "", dt.Rows(i).Item("SHIPTOMiX").ToString)
                    txtDodate.Text = IIf(IsDBNull(dt.Rows(i).Item("DOCUMENT_DATE")), "", dt.Rows(i).Item("DOCUMENT_DATE").ToString)
                    txtPoNo.Text = IIf(IsDBNull(dt.Rows(i).Item("SHIPTO_PONO")), "", dt.Rows(i).Item("SHIPTO_PONO").ToString)
                    txtIndDep.Text = IIf(IsDBNull(dt.Rows(i).Item("SHIPTO_INDDEP")), "", dt.Rows(i).Item("SHIPTO_INDDEP").ToString)
                    txtConTract.Text = IIf(IsDBNull(dt.Rows(i).Item("SHIPTO_CONTRACT")), "", dt.Rows(i).Item("SHIPTO_CONTRACT").ToString)
                    txtToProject.Text = IIf(IsDBNull(dt.Rows(i).Item("SHIPTO_TOPROJECT")), "", dt.Rows(i).Item("SHIPTO_TOPROJECT").ToString)
                    txtUpdate_date.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
                    txtUpdate_by.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
                    txtDoNo.Text = IIf(IsDBNull(dt.Rows(i).Item("DO_NO")), "", dt.Rows(i).Item("DO_NO").ToString)
                    txtSaleOrder.Text = IIf(IsDBNull(dt.Rows(i).Item("SALE_ORDER")), "", dt.Rows(i).Item("SALE_ORDER").ToString)
                    cbMeasueQTY.SelectedIndex = IIf(IsDBNull(dt.Rows(i).Item("MEASURE_MOTHOD")), "", dt.Rows(i).Item("MEASURE_MOTHOD"))
                    cbCalQTY.SelectedIndex = IIf(IsDBNull(dt.Rows(i).Item("CALCULATE_MOTHOD")), "", dt.Rows(i).Item("CALCULATE_MOTHOD"))

                    If dt.Rows(i).Item("GOV_PROJECT") = "1" Then
                        OptActive.Checked = True
                    Else
                        OptUnActive.Checked = True
                    End If

                    If dt.Rows(i).Item("Distribution_Chanel").ToString = "LOCAL" Then
                        OptDistribution_Local.Checked = True
                    Else
                        OptDistribution_Export.Checked = True
                    End If

                    If dt.Rows(i).Item("PLAN_DATE").ToString <> "" Then
                        If InStr(1, dt.Rows(i).Item("PLAN_DATE"), " ") <> 0 Then
                            Dim TmpDate = Split(dt.Rows(i).Item("PLAN_DATE"), " ")
                            Dim tmpD1 = Trim(TmpDate(0))
                            Dim tmpD2 = Trim(TmpDate(1))
                            Picker_Require_Date.Text = Format(tmpD1)
                            Picker_Require_Time.Text = Format(tmpD2)
                        Else
                            Picker_Require_Date.Value = dt.Rows(i).Item("PLAN_DATE")
                            Picker_Require_Time.Value = Convert.ToDateTime(Picker_Require_Time.Value.Date.ToLongDateString & " " & "00:00:00")
                        End If
                    Else
                        Picker_Require_Date.Value = Now
                        Picker_Require_Time.Value = Convert.ToDateTime(Picker_Require_Time.Value.Date.ToLongDateString & " " & "00:00:00")
                    End If

                    i = 0
                    DataGridView.RowCount = 0
                    Do While dt.Rows.Count > i

                        DataGridView.RowCount = DataGridView.RowCount + 1
                        'DataGridView.Rows.Item(i).Height = Grid_Height

                        DataGridView.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ITEM_NO")), "", dt.Rows(i).Item("ITEM_NO").ToString)
                        DataGridView.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("MATERIAL_NO")), "", dt.Rows(i).Item("MATERIAL_NO").ToString & "-" & dt.Rows(i).Item("SALE_PRODUCT_NAME").ToString)
                        DataGridView.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("QUANTITY")), "", dt.Rows(i).Item("QUANTITY").ToString)
                        DataGridView.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SALE_UNIT")), "", dt.Rows(i).Item("SALE_UNIT").ToString)

                        i = i + 1
                    Loop
                    'txtCountSaleProduct.Text = i
                End If
            Else

            End If
        Catch ex As Exception

        End Try
        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub

    Private Sub cbCustomer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbCustomer.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbShipTo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbShipTo.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbMeasueQTY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbMeasueQTY.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbCalQTY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbCalQTY.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbCustomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCustomer.SelectedIndexChanged
        If cbCustomer.Text = "" Then Exit Sub
        'Clear_frm()
        GetShipTo(Mid(cbCustomer.Text, 1, InStr(1, cbCustomer.Text, "-") - 1))
    End Sub

    Private Sub txtCountSaleProduct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCountSaleProduct.KeyPress
        e.Handled = CurrencyOnly(txtCountSaleProduct, e.KeyChar)
    End Sub

    Function initial_cbCustomer() As Boolean
        Dim sql_str As String
        sql_str = " SELECT  T.CUSTOMER_CODE ||'--'|| T.CUSTOMER_NAME as CUSTOMER "
        sql_str = sql_str & " FROM TAS.CUSTOMER T "
        sql_str = sql_str & " ORDER BY T.CUSTOMER_CODE "
        assignDropDown(sql_str, "CUSTOMER", cbCustomer)

        Return 0
    End Function

    Private Sub GetShipTo(ByVal iCustomer As String)
        cbShipTo.Items.Clear()
        Dim sql_str As String
        sql_str = " SELECT  T.SHIPTO_CODE ||'--'|| T.SHIPTO_NAME as SHIPTO "
        sql_str = sql_str & " FROM TAS.SHIP_TO T "
        sql_str = sql_str & " WHERE T.CUSTOMER_CODE ='" & Trim(iCustomer) & "' ORDER BY  T.SHIPTO_CODE "
        assignDropDown(sql_str, "SHIPTO", cbShipTo)

    End Sub

    Function initial_cbMeasueQTY() As Boolean
        Dim sql_str As String
        sql_str = " SELECT   T.TYPE_ID , T.TYPE_NAME   FROM TAS.V_DO_MEASURE_MOTHOD T  ORDER BY T.TYPE_ID "
        assignDropDown(sql_str, "TYPE_NAME", cbMeasueQTY)

        Return 0
    End Function

    Function initial_cbCalQTY() As Boolean
        Dim sql_str As String
        sql_str = " SELECT   T.TYPE_ID , T.TYPE_NAME   FROM TAS.V_DO_CALCULATE_MOTHOD T  ORDER BY T.TYPE_ID "
        assignDropDown(sql_str, "TYPE_NAME", cbCalQTY)

        Return 0
    End Function

    Function assignDropDown(ByVal sql_str As String, ByVal colName As String, ByVal cb As System.Object) As Boolean
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Dim temCb As String
            Do While dt.Rows.Count > i
                temCb = IIf(IsDBNull(dt.Rows(i).Item(colName)), "", dt.Rows(i).Item(colName).ToString)
                If Not cb.Items.Contains(temCb) Then
                    cb.Items.Add(temCb)
                End If
                i = i + 1
            Loop
            Return True
        End If
        mDataSet = Nothing
        Return True
    End Function

    Private Sub txtCountSaleProduct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCountSaleProduct.TextChanged
        Dim i As Integer
        If txtCountSaleProduct.Text = "" Then
            DataGridView.RowCount = 0
            Exit Sub
        End If

        If txtCountSaleProduct.TextLength > 0 And CInt(txtCountSaleProduct.Text) > 0 Then
            DataGridView.RowCount = 0
            bt_DelProduct.Visible = False
            For i = 0 To CInt(txtCountSaleProduct.Text) - 1
                DataGridView.RowCount = DataGridView.RowCount + 1
                DataGridView.Item(0, i).Value = i + 1
            Next
            'initial_Combo_Gridview()
            initial_SaleProduct_Gridview()
            bt_DelProduct.Visible = True
        Else
            bt_DelProduct.Visible = False
        End If
    End Sub

    Private Sub bt_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancel.Click
        Me.Close()
    End Sub

    Private Sub bt_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Save.Click
        Dim i As Integer
        If frm_work = 1 Then 'Add  
            If txtDoNo.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ใส่ข้อมูล D/O No กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            If txtSaleOrder.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ใส่ข้อมูล Sale Order กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            If cbCustomer.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ใส่ข้อมูล ลูกค้า กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            If cbShipTo.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ใส่ข้อมูล ปลายทาง กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            If txtPoNo.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ใส่ข้อมูล Po No กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            If CStr(txtCountSaleProduct.Text.Trim) = "" Or CStr(txtCountSaleProduct.Text) = "0" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ยังไม่ได้เลือกจำนวน Product กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            If DataGridView.Rows.Count <= i Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ยังไม่ได้เลือก Product กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Do While DataGridView.Rows.Count > i
                If DataGridView.Item(2, DataGridView.CurrentCell.RowIndex).Value = "" Then
                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ใส่จำนวน Product กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                    Exit Sub
                End If

                If DataGridView.Item(3, DataGridView.CurrentCell.RowIndex).Value = "" Then
                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                    Exit Sub
                End If

                'vSale = Split(DataGridView.Item(1, DataGridView.CurrentCell.RowIndex).Value, "-")
                'If ChkDOQuota(tmpCus1, vSale(0), DataGridView.Item(2, DataGridView.CurrentCell.RowIndex).Value) Then
                '    i = i + 1
                'End If


                i = i + 1
            Loop

            If CheckDataExists(txtDoNo.Text.Trim) = False Then
                MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "เนื่องจากมีหลายเลข D/O  " & Trim(txtDoNo.Text.Trim) & " อยู่ในฐานข้อมูลแล้ว", vbInformation)
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            'If txtCard.Text.Trim = "" Or txtCardID.Text.Trim = "" Or cbTruck.Text.Trim = "" Then
            '    MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            '    Exit Sub
            'End If
            If txtDoNo.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ใส่ข้อมูล D/O No กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            If txtSaleOrder.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ใส่ข้อมูล Sale Order กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            If cbCustomer.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ใส่ข้อมูล ลูกค้า กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            If cbShipTo.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ใส่ข้อมูล ปลายทาง กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            If txtPoNo.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ใส่ข้อมูล Po No กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            If CStr(txtCountSaleProduct.Text.Trim) = "" Or CStr(txtCountSaleProduct.Text) = "0" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ยังไม่ได้เลือกจำนวน Product กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            If DataGridView.Rows.Count <= i Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ยังไม่ได้เลือก Product กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Do While DataGridView.Rows.Count > i
                If DataGridView.Item(2, DataGridView.CurrentCell.RowIndex).Value = "" Then
                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ใส่จำนวน Product กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                    Exit Sub
                End If

                If DataGridView.Item(3, DataGridView.CurrentCell.RowIndex).Value = "" Then
                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                    Exit Sub
                End If

                'vSale = Split(DataGridView.Item(1, DataGridView.CurrentCell.RowIndex).Value, "-")
                'If ChkDOQuota(tmpCus1, vSale(0), DataGridView.Item(2, DataGridView.CurrentCell.RowIndex).Value) Then
                '    i = i + 1
                'End If


                i = i + 1
            Loop

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Edit()
            End If
        End If
    End Sub

    Private Sub Save()
        Dim sql_str As String
        Dim i As Integer = 0
        Dim tmpStr() As String
        Dim tmpStr2() As String
        Dim tmpShip1 As String
        Dim tmpShip2 As String
        Dim tmpCus1 As String = ""
        Dim tmpCus2 As String = ""

        If cbCustomer.Text <> "" Then
            If InStr(1, cbCustomer.Text, "--") > 0 Then
                tmpStr = Split(cbCustomer.Text, "--")
                tmpCus1 = Trim(tmpStr(0))
                tmpCus2 = Trim(tmpStr(1))
            End If
        End If

        If InStr(1, cbShipTo.Text, "--") > 0 Then
            tmpStr2 = Split(cbShipTo.Text, "--")
            tmpShip1 = Trim(tmpStr2(0))
            tmpShip2 = Trim(tmpStr2(1))
        Else
            tmpShip1 = "1"
            tmpShip2 = cbShipTo.Text
        End If

        Dim strDate = Picker_Require_Date.Value.ToString.Split(" ")
        Dim dateRequire = strDate(0)
        Dim strTime = Picker_Require_Time.Value.ToString.Split(" ")
        Dim timeRequire = strTime(1)
        Dim dateTimeRequire As String = dateRequire & " " & timeRequire

        sql_str = "INSERT INTO DO_HEADER("
        sql_str = sql_str & " DO_NO,SALE_ORDER,CUSTOMER_CODE,CUSTOMER_NAME,SHIP_TO_CODE,SHIPTO,PLAN_DATE,DOCUMENT_DATE,"
        sql_str = sql_str & " DO_STATUS,WEIGHT_UNIT,CREATION_DATE,CREATED_BY,"
        sql_str = sql_str & " J_COMPUTER,SHIPTO_PONO,SHIPTO_CONTRACT,SHIPTO_INDDEP,SHIPTO_TOPROJECT , MEASURE_MOTHOD , CALCULATE_MOTHOD ,GOV_PROJECT,DISTRIBUTION_CHANEL,SALE_ORGANIZATION) "
        sql_str = sql_str & " Values('" & txtDoNo.Text & "','" & txtSaleOrder.Text & "','" & tmpCus1 & "','" & tmpCus2 & "','" & tmpShip1 & "' ,'" & tmpShip2 & "' ,"
        sql_str = sql_str & " TO_DATE('" & dateTimeRequire & "', 'DD/MM/YYYY HH24:MI:SS') , "
        sql_str = sql_str & " sysdate,0,'KG',sysdate,'" & mUserName & "', '" & mUserName & "', '" & txtPoNo.Text & "', '" & txtConTract.Text & "', '" & txtIndDep.Text & "', '" & txtToProject.Text & "','" & cbMeasueQTY.SelectedIndex & "','" & cbCalQTY.SelectedIndex & "'," & IIf(OptActive.Checked = True, 1, 0) & " ,'" & IIf(OptDistribution_Export.Checked = True, "EXPORT", "LOCAL") & "','TLB' )"

        If Oradb.ExeSQL(sql_str) Then
            With DataGridView
                For i = 1 To .Rows.Count
                    Dim arProduct = .Item(1, i - 1).Value.ToString.Split("-")
                    sql_str = "INSERT INTO DO_LINES( "
                    sql_str = sql_str & " DO_NO,ITEM_NO,MATERIAL_NO,QUANTITY,SALE_UNIT,PLANT,STATUS,"
                    sql_str = sql_str & " CREATION_DATE,CREATED_BY,J_COMPUTER)"
                    sql_str = sql_str & " values('" & txtDoNo.Text & "'," & i & ",'" & arProduct(0) & "','" & .Item(2, i - 1).Value & "',"
                    sql_str = sql_str & " '" & .Item(3, i - 1).Value & "','TLB',1,sysdate,'" & mUserName & "','" & mUserName & "')"
                    Oradb.ExeSQL(sql_str)
                Next i
            End With

            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmLoadDO.Showdata_GridMain()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If

    End Sub

    Private Sub Edit()
        Dim sql_str As String
        Dim i As Integer = 0
        Dim tmpStr() As String
        Dim tmpStr2() As String
        Dim tmpShip1 As String
        Dim tmpShip2 As String
        Dim tmpCus1 As String = ""
        Dim tmpCus2 As String = ""

        If cbCustomer.Text <> "" Then
            If InStr(1, cbCustomer.Text, "--") > 0 Then
                tmpStr = Split(cbCustomer.Text, "--")
                tmpCus1 = Trim(tmpStr(0))
                tmpCus2 = Trim(tmpStr(1))
            End If
        End If

        If InStr(1, cbShipTo.Text, "--") > 0 Then
            tmpStr2 = Split(cbShipTo.Text, "--")
            tmpShip1 = Trim(tmpStr2(0))
            tmpShip2 = Trim(tmpStr2(1))
        Else
            tmpShip1 = "1"
            tmpShip2 = cbShipTo.Text
        End If

        Dim strDate = Picker_Require_Date.Value.ToString.Split(" ")
        Dim dateRequire = strDate(0)
        Dim strTime = Picker_Require_Time.Value.ToString.Split(" ")
        Dim timeRequire = strTime(1)
        Dim dateTimeRequire As String = dateRequire & " " & timeRequire

        sql_str = "UPDATE DO_HEADER  SET "
        sql_str = sql_str & " SALE_ORDER ='" & txtSaleOrder.Text & "',"
        sql_str = sql_str & " CUSTOMER_CODE='" & tmpCus1 & "',"
        sql_str = sql_str & " CUSTOMER_NAME='" & tmpCus2 & "',"
        sql_str = sql_str & " SHIP_TO_CODE='" & tmpShip1 & "',"
        sql_str = sql_str & " SHIPTO='" & tmpShip2 & "',"
        sql_str = sql_str & " SHIPTO_PONO='" & txtPoNo.Text & "',"
        sql_str = sql_str & " SHIPTO_CONTRACT='" & txtConTract.Text & "',"
        sql_str = sql_str & " SHIPTO_INDDEP='" & txtIndDep.Text & "',"
        sql_str = sql_str & " SHIPTO_TOPROJECT='" & txtToProject.Text & "',"
        sql_str = sql_str & " PLAN_DATE= TO_DATE('" & dateTimeRequire & "', 'dd/mm/yyyy hh24:mi:ss')" & " ,"
        sql_str = sql_str & " GOV_PROJECT= " & IIf(OptActive.Checked = True, 1, 0) & ","
        sql_str = sql_str & " DISTRIBUTION_CHANEL= '" & IIf(OptDistribution_Export.Checked = True, "EXPORT", "LOCAL") & "',"
        sql_str = sql_str & " update_date= sysdate,"
        sql_str = sql_str & " Updated_by= '" & mUserName & "',"
        sql_str = sql_str & " MEASURE_MOTHOD =  " & cbMeasueQTY.SelectedIndex & " ,"
        sql_str = sql_str & " CALCULATE_MOTHOD= " & cbCalQTY.SelectedIndex & " "
        sql_str = sql_str & " WHERE DO_NO='" & txtDoNo.Text & "'"

        If Oradb.ExeSQL(sql_str) Then
            sql_str = "delete from do_lines  where do_no='" & txtDoNo.Text & "'  "
            Oradb.ExeSQL(sql_str)
            With DataGridView
                For i = 1 To .Rows.Count
                    Dim arProduct = .Item(1, i - 1).Value.ToString.Split("-")
                    sql_str = "INSERT INTO DO_LINES( "
                    sql_str = sql_str & " DO_NO,ITEM_NO,MATERIAL_NO,QUANTITY,SALE_UNIT,PLANT,STATUS,"
                    sql_str = sql_str & " CREATION_DATE,CREATED_BY,J_COMPUTER)"
                    sql_str = sql_str & " values('" & txtDoNo.Text & "'," & i & ",'" & arProduct(0) & "','" & .Item(2, i - 1).Value & "',"
                    sql_str = sql_str & " '" & .Item(3, i - 1).Value & "','TLB',1,sysdate,'" & mUserName & "','" & mUserName & "')"
                    Oradb.ExeSQL(sql_str)
                Next i
            End With
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmLoadDO.Showdata_GridMain()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
    End Sub

    Private Sub dataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView.EditingControlShowing
        Select Case DataGridView.CurrentCell.ColumnIndex
            Case 1
                Dim comboboxProduct As ComboBox = e.Control
                RemoveHandler comboboxProduct.SelectedIndexChanged, AddressOf comboboxProduct_SelectedIndexChanged
                AddHandler comboboxProduct.SelectedIndexChanged, AddressOf comboboxProduct_SelectedIndexChanged
            Case 2
                Dim txtPreset As TextBox = e.Control
                RemoveHandler txtPreset.KeyPress, AddressOf txtPreset_Keypress
                AddHandler txtPreset.KeyPress, AddressOf txtPreset_Keypress
        End Select
    End Sub

    Private Sub txtPreset_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Console.WriteLine("KeyPress " & e.KeyChar.ToString())

        If DataGridView.CurrentCell.ColumnIndex = 2 Then
            If IsNumeric(e.KeyChar.ToString()) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = "." Then
                Console.WriteLine("KeyPress number")
                e.Handled = False 'if numeric display 
            Else
                Console.WriteLine("Enter Numbers Only")
                e.Handled = True  'if non numeric don't display
            End If
        End If
    End Sub

    Private Sub comboboxProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If sender.text <> "" Then
            DataGridView.Item(3, DataGridView.CurrentCell.RowIndex).Value = ShowUnitProduct(sender.text)
        End If
    End Sub

    Private Function ShowUnitProduct(ByVal saleProductId As String) As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim sql_str As String
        Dim Unit As String = ""

        If InStr(1, saleProductId, "-") = 0 Then Return ""

        sql_str = "SELECT  P.UNIT, P.SALE_PRODUCT_NAME  FROM SALE_PRODUCT P "
        sql_str = sql_str & "WHERE P.SALE_PRODUCT_ID = '" & Trim(Mid(saleProductId, 1, InStr(1, saleProductId, "-") - 1)) & "' "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                Unit = IIf(IsDBNull(dt.Rows(0).Item("UNIT")), "", dt.Rows(0).Item("UNIT").ToString)
            End If
        End If
        Return Unit
        mDataSet = Nothing
    End Function

    Private Sub initial_SaleProduct_Gridview()
        Dim cboCol1 As DataGridViewComboBoxColumn
        cboCol1 = DataGridView.Columns.Item(1)

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        Dim sql_str As String

        sql_str = "SELECT S.SALE_PRODUCT_ID,S.SALE_PRODUCT_NAME "
        sql_str = sql_str & " FROM SALE_PRODUCT S "
        sql_str = sql_str & " WHERE S.IS_ENABLE=1 "
        sql_str = sql_str & " ORDER BY S.SALE_PRODUCT_ID "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            Do While dt.Rows.Count > i
                'cboCol1.DataGridView.Rows.Item(i).Height = Grid_Height
                'cboCol2.DataGridView.Rows.Item(i).Height = Grid_Height
                'cboCol1.DefaultCellStyle.Font = New Font("Tahoma", 14, FontStyle.Bold)
                'cboCol1.DefaultCellStyle.ForeColor = Color.BlueViolet
                cboCol1.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT_ID")), "", dt.Rows(i).Item("SALE_PRODUCT_ID").ToString & "-" & dt.Rows(i).Item("SALE_PRODUCT_NAME").ToString))
                i = i + 1
            Loop

        End If
        mDataSet = Nothing
    End Sub

    Function CheckDataExists(ByRef iDo_no As String) As Boolean
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0

        sql_str = "SELECT H.DO_NO "
        sql_str = sql_str & "FROM DO_HEADER H "
        sql_str = sql_str & "WHERE H.DO_NO='" & Trim(iDo_no) & "' "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Do While dt.Rows.Count > i
                Return False
            Loop
            Return True
        End If
        mDataSet = Nothing
        Return True
    End Function


    Function ChkDOQuota(ByVal iCUSTOMER_CODE As String, ByVal iSALE_PRODUCT As String, ByVal iVAR_ORDER As Long) As Boolean
        'Return True
        Dim bRet As Boolean = False
        Dim iDate As String = Picker_Require_Date.Value.ToString("d-MMM-yyyy")
        Dim sql_str As String
        sql_str = "BEGIN "
        sql_str = sql_str & " LOAD.LOAD_CHECK_QUOTA_DO("
        sql_str = sql_str & "'" & iCUSTOMER_CODE & "','" & iSALE_PRODUCT & "',to_date('" & iDate & "','DD/MM/YYYY') ," & iVAR_ORDER & ","
        sql_str = sql_str & ":ret_check,:ret_msg); "
        sql_str = sql_str & "END;"

        Dim Oraparam As New COraParameter
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_CHECK", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With

        If Oradb.ExeSQL(sql_str, Oraparam) Then
            RET_CHECK = Oraparam.GetOraclParamValue("RET_CHECK")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            If RET_CHECK = 0 Then
                bRet = False
                MsgBox(RET_MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Else
                bRet = True
            End If
        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing

        Return bRet
    End Function

    Private Sub cbShipTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbShipTo.SelectedIndexChanged
        FindPO()
    End Sub
    Private Sub FindPO()
        Dim tmpStr() As String
        Dim tmpStr2() As String
        Dim tmpShip1 As String
        Dim tmpShip2 As String
        Dim tmpCus1 As String
        Dim tmpCus2 As String
        If cbCustomer.Text = "" Then Exit Sub
        If InStr(1, cbCustomer.Text, "--") > 0 Then
            tmpStr = Split(cbCustomer.Text, "--")
            tmpCus1 = Trim(tmpStr(0))
            tmpCus2 = Trim(tmpStr(1))
        End If
        If InStr(1, cbShipTo.Text, "--") > 0 Then
            tmpStr2 = Split(cbShipTo.Text, "--")
            tmpShip1 = Trim(tmpStr2(0))
            tmpShip2 = Trim(tmpStr2(1))
            If (frm_work = 2 Or frm_work = 1) Then
                Call GetDetailShipTo(tmpCus1, tmpShip1)
                Call ChkMethodLoadFrmSaleP()
            End If
        Else
            Clear_frm()
        End If

    End Sub
    Private Sub GetDetailShipTo(CustomerID As String, iShipTo As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        sql_str = _
                     "select * " & _
                    " from tas.view_ship_to t " & _
                    " where  t.CUSTOMER_CODE='" & Trim(CustomerID) & "'" & _
                    "and  t.SHIPTO_CODE = '" & Trim(iShipTo) & "'"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > i Then

                txtPoNo.Text = IIf(IsDBNull(dt.Rows(0).Item("SHIPTO_PONO")), "", dt.Rows(0).Item("SHIPTO_PONO").ToString)
                txtIndDep.Text = IIf(IsDBNull(dt.Rows(0).Item("SHIPTO_INDDEP")), "", dt.Rows(0).Item("SHIPTO_INDDEP").ToString)
                txtToProject.Text = IIf(IsDBNull(dt.Rows(0).Item("SHIPTO_TOPROJECT")), "", dt.Rows(0).Item("SHIPTO_TOPROJECT").ToString)
                txtConTract.Text = IIf(IsDBNull(dt.Rows(0).Item("SHIPTO_CONTRACT")), "", dt.Rows(0).Item("SHIPTO_CONTRACT").ToString)
                If CInt(dt.Rows(0).Item("GOV_PROJECT")) = 1 Then
                    OptActive.Checked = True
                Else
                    OptUnActive.Checked = True
                End If

                If CInt(dt.Rows(0).Item("Distribution_Chanel")) = 1 Then
                    OptDistribution_Local.Checked = True
                Else
                    OptDistribution_Export.Checked = True
                End If
            End If
        End If
        mDataSet = Nothing
    End Sub
    Private Sub ChkMethodLoadFrmSaleP()
        On Error Resume Next
        Dim sql_str As String
        Dim tmpSale() As String
        Dim vSaleCode As String
        Dim vCus() As String
        Dim vCusCode As String
        Dim vShipto() As String
        Dim vShipCode As String
        Dim vShipName As String

        If cbCustomer.Text = "" Then
            vCusCode = " "
        Else
            vCus = Split(cbCustomer.Text, "-")
            vCusCode = Trim(vCus(0))
        End If
        If cbShipTo.Text = "" Then
            vShipCode = " "
            vShipName = " "
        Else
            vShipto = Split(cbShipTo.Text, "--")
            vShipCode = Trim(vShipto(0))
            vShipName = Trim(vShipto(1))
        End If

        'With MSGridList
        '    If .rows > 1 And .TextMatrix(1, 1) <> "" Then
        '        tmpSale = Split(.TextMatrix(1, 1), "-")
        '        vSaleCode = Trim(tmpSale(0))
        '    Else
        '        vSaleCode = " "
        '    End If
        'End With
        Dim Oraparam As New COraParameter
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("ret_chk_measure", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("ret_chk_cal", COracle._OracleDbType.OraInt32)

        End With

        sql_str = _
                        "Begin tas.CHECK_MEAS_CAL_PRODUCT ('" & _
                        Trim(vCusCode) & "' , '" & Trim(vShipCode) & "' , '" & Trim(vShipName) & "', '" & Trim(vSaleCode) & "'" & _
                        ",:ret_chk_measure,:ret_chk_cal" & _
                        "); end ; "

        If Oradb.ExeSQL(sql_str, Oraparam) Then
            cbMeasueQTY.SelectedIndex = Oraparam.GetOraclParamValue("ret_chk_measure")
            cbCalQTY.SelectedIndex = Oraparam.GetOraclParamValue("ret_chk_cal")
        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
 
    End Sub

    Private Sub bt_DelProduct_Click(sender As Object, e As EventArgs) Handles bt_DelProduct.Click
        If txtCountSaleProduct.Text <> 0 Or txtCountSaleProduct.Text <> "" Then
            txtCountSaleProduct.Text = Val(txtCountSaleProduct.Text) - 1
        End If
    End Sub


End Class