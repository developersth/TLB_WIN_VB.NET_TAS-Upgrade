Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmConfigMeter_sub
    'Dim frm_work As Integer = 0 'Meter1=add ,2=Edit
    Dim frm_work As WorkFlow
    Dim pk_id As String = ""
    Dim RadioEnabled As String
    Dim RadioLocked As String
    Dim vFixType As String

    Private Sub frmConfigMeter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        If frm_work = 1 Then
            Me.Text = "Meter # Add"
        ElseIf frm_work = 2 Then
            Me.Text = "Meter # Edit"
            AssignValue()

            Dim sql_str = "select T.TANK_ID,T.TANK_NAME" & _
            " from  TANK T" & _
            " where T.BASE_PRODUCT='" & cbBaseProduct.Text & "' " & _
            " order by T.TANK_ID  "
            assignDropDown(sql_str, "TANK_ID", cbTankID)
            ShowGridProduct(pk_id)
            ShowGridAdditive(pk_id)
            ShowGridTank(pk_id)
            ShowMeterBlending(pk_id)

            If DataGridView1.Rows.Count > 0 Then
                DataGridView1.Rows(0).Selected = True
                DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(0)
                DataGridView1_Click(Nothing, Nothing)
            End If
            If DataGridView2.Rows.Count > 0 Then
                DataGridView2.Rows(0).Selected = True
                DataGridView2.CurrentCell = DataGridView2.Rows(0).Cells(0)
                DataGridView2_Click(Nothing, Nothing)
            End If
            If DataGridView3.Rows.Count > 0 Then
                DataGridView3.Rows(0).Selected = True
                DataGridView3.CurrentCell = DataGridView3.Rows(0).Cells(0)
                DataGridView3_Click(Nothing, Nothing)
            End If
            If DataGridView4.Rows.Count > 0 Then
                DataGridView4.Rows(0).Selected = True
                DataGridView4.CurrentCell = DataGridView4.Rows(0).Cells(0)
                DataGridView4_Click(Nothing, Nothing)
            End If
            If DataGridView5.Rows.Count > 0 Then
                DataGridView5.Rows(0).Selected = True
                DataGridView5.CurrentCell = DataGridView5.Rows(0).Cells(0)
                DataGridView5_Click(Nothing, Nothing)
            End If
        End If
        txtLock(True)
    End Sub

    Private Sub Clear_frm()
        txtMeterNo.Text = ""
        txtMeterAddr.Text = ""
        cbMeterType.Text = ""
        txtMblendPercent.Text = ""
        cbBaseProduct.Text = ""
        cbComport.Text = ""
        cbComport2.Text = ""
        cbIslandNo.Text = ""
        txtMeterPos.Text = ""
        cmbPulsInput.Text = ""
        OptEnabled.Checked = True
        OptLock.Checked = True
        cbMapID.Text = ""
        txtPressureDiff.Text = ""
        txtPressureH.Text = ""
        txtPressureHH.Text = ""
        '-----------------------------------
        txtMetertank.Text = ""
        cbTankID.Text = ""
        txtTankName.Text = ""
        textDes.Text = ""
        OptTankEnabled.Checked = True
        txtMeterA.Text = ""
        cbAdditive.Text = ""
        txtKFac.Text = ""
        txtlatre.Text = ""
        '--------------------------------------
        txtMeterNo.Text = ""
        txtMeterAddr.Text = ""
        txtPressureDiff.Text = ""
        cbMeterType.Items.Clear()
        cbBaseProduct.Items.Clear()
        chkArmPos.Checked = False
        '-----------------------------------------
        textMeterSaleProduct.Text = ""
        cbSaleProduct.Text = ""
        textSaleName.Text = ""
        cbFormula.Text = ""
        OptProductEnabled.Checked = False
        txt1stPercent.Text = 0
        txt2ndPercent.Text = 0

        txtMeter.Text = ""
        txtDesc.Text = ""
        cbMeterBlend.Text = ""
        cbMeterBlend.SelectedIndex = -1
        cbBaseProductID.SelectedIndex = -1
        DataGridView4.Rows.Clear()
        OptBlendDisable.Checked = False
        OptBlendEnable.Checked = False

        txtpDes.Text = ""
        txtpMeterNo.Text = ""
        txtInputName.Text = ""
        cbIputNo.Text = ""
        cbIputNo.SelectedIndex = -1
        cbActiveStatus.Text = ""
        cbActiveStatus.SelectedIndex = -1


        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""

    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
       
    End Sub

    Sub SetUsing()
        Select Case frm_work
            Case WorkFlow.Add
                txtMeterNo.ReadOnly = False
                txtMeter.ReadOnly = False
            Case WorkFlow.Edit
                txtMeterNo.ReadOnly = True
                txtMeter.ReadOnly = True
                txtMeterBlend.ReadOnly = True
        End Select
    End Sub

#Region "Menu Event"
    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave
        If frm_work = 1 Then 'Add
            If txtMeterNo.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                If CheckDataExists(txtMeterNo.Text) Then
                    Save()
                Else
                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "เนื่องจากมีมิเตอร์" & txtMeterNo.Text & " อยู่ในฐานข้อมูลแล้ว")
                End If
            End If
        ElseIf frm_work = 2 Then 'Edit
            If txtMeterNo.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Edit()
            End If
        End If
    End Sub

    Private Sub UcCancel1_OnClickCancel(ByVal ucName As System.String) Handles UcCancel1.OnClickCancel
        Me.Close()
        'Initial_frm()
    End Sub

#End Region

    Private Sub Save()
        Dim arrCbComport = Split(cbComport.Text, " ")
        Dim CompId = arrCbComport(0)
        Dim CompNo = arrCbComport(1)
        Dim arrCbComport2 = Split(cbComport2.Text, " ")
        Dim sCompId2 = arrCbComport2(0)
        Dim sCompNo2 = arrCbComport2(1)

        Dim sql_str As String =
        "insert into METER(" &
        " METER_NO,METER_ADDRESS,PRES_LIMIT_HIGH, " &
        " METER_TYPE,BASE_PRODUCT_ID,ARM_LEFT_ACTIVE,ARM_RIGHT_ACTIVE,ARM_SIDE_C_ACTIVE,ISLAND_NO,MAP_ID, " &
        " COMP_ID,COMPORT_NO ,COMP_ID1,COMPORT_NO1,IS_ENABLED,IS_LOCKED,BATCH_ID,CREATION_DATE,CREATED_BY, " &
        " UPDATE_DATE,UPDATED_BY, PULSE_INPUT,PRES_ALARM_HH,PRES_ALARM_H) " &
        " values('" &
        Trim(txtMeterNo.Text) & "','" & Trim(txtMeterAddr.Text) & "','" & Trim(txtPressureDiff.Text) & "','" &
        Trim(cbMeterType.Text) & "','" & Trim(cbBaseProduct.Text) & "','" & IIf(chkArmPos.Checked = True, 1, 0) & "','" &
        IIf((ChkArmPos2.Checked = True), 1, 0) & "','" & IIf((ChkArmSideC.Checked = True), 1, 0) & "','" & Trim(cbIslandNo.Text) & "','" & Trim(cbMapID.Text) & "','" &
        Trim(CompId) & "','" & Trim(CompNo) & "','" &
        Trim(sCompId2) & "','" & Trim(sCompNo2) & "'," &
        IIf(OptEnabled.Checked, 1, 0) & "," &
        IIf(OptLock.Checked, 1, 0) & ",'1'," &
        "sysdate,'" & mUserName & "',sysdate,'" & mUserName & "','" & cmbPulsInput.FindString(cmbPulsInput.Text) & "','" & Trim(txtPressureHH.Text) & "','" & Trim(txtPressureH.Text) & "' )"

        If Oradb.ExeSQL(sql_str) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            AddDataSaleProduct()
            AddDataAdditive()
            AddDataTank()
            AddDataMeterBlending()

            Me.Close()
            setFrmWork(0)
            frmConfigMeter_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If

    End Sub

    Private Sub ShowGridTank(ByVal MeterNo As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = _
        "select M.METER_NO,M.TANK_ID," & _
        " M.IS_ENABLED,M.DESCRIPTION,M.UPDATE_DATE,M.UPDATED_BY, " & _
        "M.J_COMPUTER,T.TANK_NAME " & _
        " from METER_TANK M,TANK T  " & _
        " where METER_NO = '" & MeterNo & "'" & _
        " and M.TANK_ID=T.TANK_ID" & _
        " order by METER_NO"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView3.RowCount = 0
            Do While dt.Rows.Count > i
                DataGridView3.RowCount = DataGridView3.RowCount + 1
                DataGridView3.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("METER_NO")), "", dt.Rows(i).Item("METER_NO").ToString)
                DataGridView3.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TANK_ID")), "", dt.Rows(i).Item("TANK_ID").ToString)
                DataGridView3.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TANK_NAME")), "", dt.Rows(i).Item("TANK_NAME").ToString)
                DataGridView3.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION").ToString)
                DataGridView3.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", IIf((dt.Rows(i).Item("IS_ENABLED").ToString = 1), "สามารถใช้งานได้", "หยุดการใช้งาน"))
                DataGridView3.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
                DataGridView3.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("J_COMPUTER").ToString)

                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
        If i > 0 Then
            Dim index As Integer = 0
            txtMetertank.Text = txtMeterNo.Text
            cbTankID.Text = DataGridView3.Rows(index).Cells(1).Value.ToString
            txtTankName.Text = DataGridView3.Rows(index).Cells(2).Value.ToString
            textDes.Text = DataGridView3.Rows(index).Cells(3).Value.ToString
            If DataGridView3.Rows(index).Cells(4).Value = "สามารถใช้งานได้" Then
                OptProductEnabled.Checked = True
            Else
                OptProductUnEnabled.Checked = True
            End If
        End If
    End Sub

    Private Sub ShowGridAdditive(ByVal MeterNo As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = _
        "select M.METER_NO,M.ADDITIVE_NAME,M.ADDITIVE_NO,M.TYPE_CAL_ADDITIVE,M.K_CAL_ADDITIVE," & _
        " M.IS_MEASURE,M.K_MEASURE_ADDITIVE,M.IS_ENABLED,M.UPDATE_DATE,M.UPDATED_BY ,J_COMPUTER " & _
        "from METER_ADDITIVE M " & _
        "where M.METER_NO = '" & MeterNo & "' "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView2.RowCount = 0
            Do While dt.Rows.Count > i
                DataGridView2.RowCount = DataGridView2.RowCount + 1
                DataGridView2.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("METER_NO")), "", dt.Rows(i).Item("METER_NO").ToString)
                DataGridView2.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ADDITIVE_NAME")), "", dt.Rows(i).Item("ADDITIVE_NAME").ToString)
                DataGridView2.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("K_MEASURE_ADDITIVE")), "", dt.Rows(i).Item("K_MEASURE_ADDITIVE").ToString)
                DataGridView2.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("K_CAL_ADDITIVE")), "", dt.Rows(i).Item("K_CAL_ADDITIVE").ToString)
                DataGridView2.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
                DataGridView2.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
                DataGridView2.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("J_COMPUTER")), "", dt.Rows(i).Item("J_COMPUTER").ToString)

                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
        If i > 0 Then
            Dim index As Integer = 0
            txtMeterA.Text = txtMeterNo.Text
            cbAdditive.Text = DataGridView2.Rows(index).Cells(1).Value.ToString
            txtKFac.Text = DataGridView2.Rows(index).Cells(2).Value.ToString
            txtlatre.Text = DataGridView2.Rows(index).Cells(3).Value.ToString
        End If

    End Sub

    Private Sub ShowGridProduct(ByVal MeterNo As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = _
        "select M.METER_NO,M.SALE_PRODUCT_ID,M.SALE_PRODUCT_ID||'-'||M.SALE_PRODUCT_NAME as SALE_PRODUCT ,M.SALE_PRODUCT_NAME,M.IS_ENABLED, " & _
        " M.UPDATE_DATE,M.UPDATED_BY,M.FORMULA_NO,J_COMPUTER  " & _
        ",0 as PERCENTAGE_1,0 as PERCENTAGE_2" & _
        " from METER_PRODUCT  M " & _
        " WHERE M.METER_NO='" & MeterNo & "'" & _
        "  order by M.METER_NO,M.FORMULA_NO"
        DataGridView1.Columns(4).Width = 0
        DataGridView1.Columns(5).Width = 0
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView1.RowCount = 0
            Do While dt.Rows.Count > i
                DataGridView1.RowCount = DataGridView1.RowCount + 1
                DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("METER_NO")), "", dt.Rows(i).Item("METER_NO").ToString)
                DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT_ID")), "", dt.Rows(i).Item("SALE_PRODUCT_ID").ToString)
                DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT_NAME")), "", dt.Rows(i).Item("SALE_PRODUCT_NAME").ToString)
                DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("FORMULA_NO")), "", dt.Rows(i).Item("FORMULA_NO").ToString)
                DataGridView1.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PERCENTAGE_1")), "", dt.Rows(i).Item("PERCENTAGE_1").ToString)
                DataGridView1.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PERCENTAGE_2")), "", dt.Rows(i).Item("PERCENTAGE_2").ToString)
                DataGridView1.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", IIf((dt.Rows(i).Item("IS_ENABLED").ToString = 1), "สามารถใช้งานได้", "หยุดการใช้งาน"))
                DataGridView1.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
                DataGridView1.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
                DataGridView1.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("J_COMPUTER")), "", dt.Rows(i).Item("J_COMPUTER").ToString)
                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
        If i > 0 Then
            Dim index As Integer = 0
            textMeterSaleProduct.Text = txtMeterNo.Text
            textSaleName.Text = DataGridView1.Rows(index).Cells(2).Value.ToString
            cbFormula.Text = DataGridView1.Rows(index).Cells(3).Value.ToString

            If DataGridView1.Rows(index).Cells(4).Value = "สามารถใช้งานได้" Then
                OptProductEnabled.Checked = True
            Else
                OptProductUnEnabled.Checked = True
            End If
            setListboxWithName(DataGridView1.Rows(index).Cells(1).Value.ToString, cbSaleProduct)
        End If
    End Sub

    Private Sub ShowMeterBlending(ByVal pMeterNo As String)
        Dim strSQL As String, vIndex As Integer = 0
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        txtMeterBlend.Text = pMeterNo
        strSQL = _
                    "select * from METER_BLEND" & _
                    " where METER_NO = '" & pMeterNo & "'"

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            DataGridView4.RowCount = 0
            DataGridView4.Columns(3).Visible = False
            DataGridView4.Columns(4).Visible = False
            Do While dt.Rows.Count > vIndex
                DataGridView4.RowCount = DataGridView4.RowCount + 1
                DataGridView4.Item(0, vIndex).Value = IIf(IsDBNull(dt.Rows(vIndex).Item("METER_NO")), "", dt.Rows(vIndex).Item("METER_NO").ToString)
                DataGridView4.Item(1, vIndex).Value = IIf(IsDBNull(dt.Rows(vIndex).Item("METER")), "", dt.Rows(vIndex).Item("METER").ToString)
                DataGridView4.Item(2, vIndex).Value = IIf(IsDBNull(dt.Rows(vIndex).Item("BLEND_METER_NO")), "", dt.Rows(vIndex).Item("BLEND_METER_NO").ToString)
                DataGridView4.Item(4, vIndex).Value = IIf(IsDBNull(dt.Rows(vIndex).Item("BASE_PRODUCT_ID")), "", dt.Rows(vIndex).Item("BASE_PRODUCT_ID").ToString)
                DataGridView4.Item(5, vIndex).Value = IIf(IsDBNull(dt.Rows(vIndex).Item("BATCH_ID")), "", dt.Rows(vIndex).Item("BATCH_ID").ToString)
                DataGridView4.Item(6, vIndex).Value = IIf(dt.Rows(vIndex).Item("IS_ENABLED") = 1, "สามารถใช้งานได้", "หยุดใช้งาน")
                DataGridView4.Item(7, vIndex).Value = IIf(IsDBNull(dt.Rows(vIndex).Item("CREATION_DATE")), "", dt.Rows(vIndex).Item("CREATION_DATE").ToString)
                DataGridView4.Item(8, vIndex).Value = IIf(IsDBNull(dt.Rows(vIndex).Item("UPDATED_BY")), "", dt.Rows(vIndex).Item("UPDATED_BY").ToString)
                DataGridView4.Item(9, vIndex).Value = IIf(IsDBNull(dt.Rows(vIndex).Item("J_COMPUTER")), "", dt.Rows(vIndex).Item("J_COMPUTER").ToString)
                DataGridView4.Item(10, vIndex).Value = IIf(IsDBNull(dt.Rows(vIndex).Item("DESCRIPTION")), "", dt.Rows(vIndex).Item("DESCRIPTION").ToString)
                txtMeter.Text = IIf(IsDBNull(dt.Rows(vIndex).Item("BLEND_METER_NO")), "", dt.Rows(vIndex).Item("BLEND_METER_NO").ToString)
                txtDesc.Text = IIf(IsDBNull(dt.Rows(vIndex).Item("DESCRIPTION")), "", dt.Rows(vIndex).Item("DESCRIPTION").ToString)
                vIndex = vIndex + 1
            Loop
        End If
        mDataSet = Nothing
    End Sub

    Public Sub setFrmWork(ByVal n As Integer)
        Me.frm_work = n
    End Sub

    Public Sub setPkId(ByVal id As String)
        Me.pk_id = id
    End Sub

    Private Sub addDataGridProduct()
        Dim v As Single = 100
        Dim i As Integer
        Dim arrCbSaleProduct = Split(cbSaleProduct.Text, "-")
        Dim j As Integer = 0

        'Do While DataGridView1.RowCount > j
        '    If DataGridView1.Item(1, j).Value = arrCbSaleProduct(0) Then
        '        Exit Sub
        '    End If

        '    j = j + 1
        'Loop
        i = CheckDuplicateSaleProduct()
        If i = -1 Then
            i = DataGridView1.RowCount
            DataGridView1.RowCount = DataGridView1.RowCount + 1
        End If
        'p1 = Convert.ToSingle(txt1stPercent.Text)
        'p2 = Convert.ToSingle(txt2ndPercent.Text)
        If CheckRecipePercent() Then
            'DataGridView1.RowCount = DataGridView1.RowCount + 1
            DataGridView1.Item(0, i).Value = txtMeterNo.Text
            DataGridView1.Item(1, i).Value = arrCbSaleProduct(0)
            DataGridView1.Item(2, i).Value = textSaleName.Text
            DataGridView1.Item(3, i).Value = cbFormula.Text
            DataGridView1.Item(4, i).Value = txt1stPercent.Text
            DataGridView1.Item(5, i).Value = txt2ndPercent.Text
            DataGridView1.Item(6, i).Value = IIf(OptProductEnabled.Checked = True, "สามารถใช้งานได้", "หยุดใช้งาน")
            DataGridView1.Item(7, i).Value = Date.Now
            DataGridView1.Item(8, i).Value = mUserName
        Else
            'MessageBox.Show("ผลรวมมีค่าไม่เท่ากับ 100 %")
            txtRecipePercent.Focus()
        End If
    End Sub

    Private Sub ShowRecipePercent()
        Dim v1, v2 As Single
        Dim vRecipePercent As Single

        v1 = Convert.ToSingle(txt1stPercent.Text)
        v2 = Convert.ToSingle(txt2ndPercent.Text)
        'If v2 = 0 Then
        '    vRecipePercent = v1
        'Else
        '    vRecipePercent = v2
        'End If

        txtRecipePercent.Text = v2
    End Sub

    Private Function CheckRecipePercent() As Boolean
        Dim v1, v2 As Single
        Return True
        Try
            Dim vRecipePercent As Single = Math.Round(Convert.ToSingle(txtRecipePercent.Text), 2)
            If Math.Round(vRecipePercent, 2) < 0.0 Then
                MessageBox.Show("Recipe Percentage มีค่าน้อยกว่า 0 %")
                Return False
            End If
            If Math.Round(vRecipePercent, 2) > 100.0 Then
                MessageBox.Show("Recipe Percentage มีค่ามากกว่า 100 %")
                Return False
            End If

            If vRecipePercent = 100 Then
                v1 = 0
                v2 = 100
            Else
                If vRecipePercent = 0 Then
                    v1 = 100
                    v2 = 0
                Else
                    v2 = Math.Round(vRecipePercent, 2)
                    v1 = Math.Round(100 - v2, 2)
                End If
            End If
            txt1stPercent.Text = v1
            txt2ndPercent.Text = v2
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Private Sub addDataGridTank()
        Dim i As Integer
        Dim j As Integer = 0

        Do While DataGridView3.RowCount > j
            If DataGridView3.Item(1, j).Value = cbTankID.Text Then
                Exit Sub
            End If

            j = j + 1
        Loop

        i = DataGridView3.RowCount
        DataGridView3.RowCount = DataGridView3.RowCount + 1
        DataGridView3.Item(0, i).Value = txtMeterNo.Text
        DataGridView3.Item(1, i).Value = cbTankID.Text
        DataGridView3.Item(2, i).Value = txtTankName.Text
        DataGridView3.Item(3, i).Value = textDes.Text
        DataGridView3.Item(4, i).Value = IIf(OptTankEnabled.Checked = True, "0", "1")
        DataGridView3.Item(5, i).Value = Date.Now
        DataGridView3.Item(6, i).Value = mUserName
    End Sub

    Private Sub addDataGridMeterBlend()
        Dim i As Integer

        i = CheckDuplicateMeterBlend()
        If i = -1 Then
            i = DataGridView4.RowCount
        End If

        DataGridView4.RowCount = DataGridView4.RowCount + 1
        DataGridView4.Item(0, i).Value = txtMeterNo.Text
        DataGridView4.Item(1, i).Value = cbMeterBlend.Text
        DataGridView4.Item(2, i).Value = txtMeter.Text
        DataGridView4.Item(4, i).Value = cbBaseProductID.Text
        DataGridView4.Item(6, i).Value = IIf(OptBlendEnable.Checked = True, "สามารถใช้งานได้", "หยุดใช้งาน")
        DataGridView4.Item(7, i).Value = Date.Now
        DataGridView4.Item(8, i).Value = mUserName
    End Sub

    Private Function CheckDuplicateMeterBlend() As Integer
        Dim vIndex As Integer
        With DataGridView4
            For vIndex = 0 To .Rows.Count - 1
                If (.Item(1, vIndex).Value = cbMeterBlend.Text) Then
                    Return vIndex
                End If
            Next
        End With
        Return -1
    End Function

    Private Function CheckDuplicateSaleProduct() As Integer
        Dim vIndex As Integer
        With DataGridView1
            For vIndex = 0 To .Rows.Count - 1
                If (.Item(1, vIndex).Value + "-" + .Item(2, vIndex).Value = cbSaleProduct.Text) Then
                    Return vIndex
                End If
            Next
        End With
        Return -1
    End Function

    Private Sub Edit()
        Dim arrCbComport = Split(cbComport.Text, " ")
        Dim CompId = arrCbComport(0)
        Dim CompNo = arrCbComport(1)
        Dim arrCbComport2 = Split(cbComport2.Text, " ")
        Dim sCompId2 = arrCbComport2(0)
        Dim sCompNo2 = arrCbComport2(1)
        Dim indexCmbPulsInput = cmbPulsInput.FindString(cmbPulsInput.Text)

        Dim strSQL As String =
        "update METER set " &
        " METER_NO='" & Trim(txtMeterNo.Text) & "', " &
        " METER_ADDRESS=" & Trim(txtMeterAddr.Text) & ", " &
        " METER_TYPE='" & Trim(cbMeterType.Text) & "', " &
        " BASE_PRODUCT_ID='" & Trim(cbBaseProduct.Text) & "', " &
        " ARM_LEFT_ACTIVE=" & IIf((chkArmPos.Checked), 1, 0) & ", " &
        " ARM_RIGHT_ACTIVE=" & IIf((ChkArmPos2.Checked), 1, 0) & ", " &
        " ARM_SIDE_C_ACTIVE=" & IIf((ChkArmSideC.Checked), 1, 0) & ", " &
        " ISLAND_NO='" & Trim(cbIslandNo.Text) & "', " &
        " COMP_ID='" & Trim(CompId) & "'," &
        " COMPORT_NO='" & Trim(CompNo) & "'," &
        " COMP_ID1='" & Trim(sCompId2) & "'," &
        " COMPORT_NO1='" & Trim(sCompNo2) & "'," &
        " IS_ENABLED=" & IIf(OptEnabled.Checked, 1, 0) & ", " &
        " IS_LOCKED=" & IIf(OptLock.Checked, 1, 0) & ", " &
        "UPDATE_DATE=sysdate," &
        "UPDATED_BY='" & mUserName & "', " &
        "BLEND_PERCENT='" & Trim(txtMblendPercent.Text) & "' ," &
        "PRES_LIMIT_HIGH='" & Trim(txtPressureDiff.Text) & "' ," &
        "PRES_ALARM_HH='" & Trim(txtPressureHH.Text) & "' ," &
        "PRES_ALARM_H='" & Trim(txtPressureH.Text) & "' ," &
        " PULSE_INPUT = '" & indexCmbPulsInput & "'" &
        "where METER_NO='" & Trim(txtMeterNo.Text) & "'"

        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            AddDataSaleProduct()
            AddDataAdditive()
            AddDataTank()
            AddDataMeterBlending()
            Me.Close()
            setFrmWork(0)
            frmConfigMeter_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If

    End Sub

    Private Sub AssignValue()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str =
        " select METER_NO,MAP_ID,METER_ADDRESS,METER_TYPE,METER_POSITION,ARM_TYPE,ARM_LEFT_ACTIVE,ARM_RIGHT_ACTIVE,ARM_SIDE_C_ACTIVE,COMP_ID||' ' ||COMPORT_NO as COMPORT_NO, " &
        "  PRES_ALARM_H,PRES_ALARM_HH,PULSE_INPUT ,PRES_LIMIT_HIGH ,PRES_ALARM_H,COMP_ID1||' ' ||COMPORT_NO1 as COMPORT_NO1,BASE_PRODUCT_ID,MAP_ID,ISLAND_NO,IS_ENABLED,IS_LOCKED,UPDATE_DATE,UPDATED_BY ,BLEND_PERCENT" &
        " from METER " &
        " where METER_NO='" & pk_id & "' "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            txtMeterNo.Text = IIf(IsDBNull(dt.Rows(i).Item("METER_NO")), "", dt.Rows(i).Item("METER_NO").ToString)
            txtMeterAddr.Text = IIf(IsDBNull(dt.Rows(i).Item("METER_ADDRESS")), "", dt.Rows(i).Item("METER_ADDRESS").ToString)
            txtPressureDiff.Text = IIf(IsDBNull(dt.Rows(i).Item("PRES_LIMIT_HIGH")), "", dt.Rows(i).Item("PRES_LIMIT_HIGH").ToString)
            txtPressureHH.Text = IIf(IsDBNull(dt.Rows(i).Item("PRES_ALARM_HH")), "", dt.Rows(i).Item("PRES_ALARM_HH").ToString)
            txtPressureH.Text = IIf(IsDBNull(dt.Rows(i).Item("PRES_ALARM_H")), "", dt.Rows(i).Item("PRES_ALARM_H").ToString)
            cbMeterType.Text = IIf(IsDBNull(dt.Rows(i).Item("METER_TYPE")), "", dt.Rows(i).Item("METER_TYPE").ToString)
            cbIslandNo.Text = IIf(IsDBNull(dt.Rows(i).Item("ISLAND_NO")), "", dt.Rows(i).Item("ISLAND_NO").ToString)
            cbBaseProduct.Text = IIf(IsDBNull(dt.Rows(i).Item("BASE_PRODUCT_ID")), "", dt.Rows(i).Item("BASE_PRODUCT_ID").ToString)
            cbBaseProductID.Text = IIf(IsDBNull(dt.Rows(i).Item("BASE_PRODUCT_ID")), "", dt.Rows(i).Item("BASE_PRODUCT_ID").ToString)
            cbComport.Text = IIf(IsDBNull(dt.Rows(i).Item("COMPORT_NO")), "", dt.Rows(i).Item("COMPORT_NO").ToString)
            cbComport2.Text = IIf(IsDBNull(dt.Rows(i).Item("COMPORT_NO1")), "", dt.Rows(i).Item("COMPORT_NO1").ToString)
            txtMblendPercent.Text = IIf(IsDBNull(dt.Rows(i).Item("BLEND_PERCENT")), "", Format(dt.Rows(i).Item("BLEND_PERCENT").ToString, "0.00"))

            Dim strMeterPos As String = IIf(IsDBNull(dt.Rows(i).Item("METER_POSITION")), "", dt.Rows(i).Item("METER_POSITION").ToString)
            If strMeterPos = "0" Then
                txtMeterPos.Text = "Left Position"
            ElseIf strMeterPos = "1" Then
                txtMeterPos.Text = "Right Position"
            Else
                txtMeterPos.Text = "- -"
            End If

            chkArmPos.Checked = IIf(IsDBNull(dt.Rows(i).Item("ARM_LEFT_ACTIVE")), "", IIf((dt.Rows(i).Item("ARM_LEFT_ACTIVE").ToString = 1), True, False))
            ChkArmPos2.Checked = IIf(IsDBNull(dt.Rows(i).Item("ARM_RIGHT_ACTIVE")), "", IIf((dt.Rows(i).Item("ARM_RIGHT_ACTIVE").ToString = 1), True, False))
            ChkArmSideC.Checked = IIf(IsDBNull(dt.Rows(i).Item("ARM_SIDE_C_ACTIVE")), "", IIf((dt.Rows(i).Item("ARM_SIDE_C_ACTIVE").ToString = 1), True, False))
            Dim booEnabled As Boolean = IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", IIf((dt.Rows(i).Item("IS_ENABLED").ToString = 1), True, False))
            Dim booLocked As Boolean = IIf(IsDBNull(dt.Rows(i).Item("IS_LOCKED")), "", IIf((dt.Rows(i).Item("IS_LOCKED").ToString = 1), True, False))
            If booEnabled Then
                OptEnabled.Checked = True
            Else
                OptUnEnbled.Checked = True
            End If
            If booLocked Then
                OptLock.Checked = True
            Else
                OptUnlock.Checked = True
            End If

            txtLastUpdateDate.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
            txtLastUpdateBy.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
            cmbPulsInput.SelectedIndex = IIf(IsDBNull(dt.Rows(i).Item("PULSE_INPUT")), "", dt.Rows(i).Item("PULSE_INPUT").ToString)
        Else
        End If
        mDataSet = Nothing

    End Sub

    Private Function appendZero(ByVal codeColour As String) As String
        Dim i As Integer = 6 - codeColour.Length
        While (i <> 0)
            codeColour = "0" + codeColour
            i = i - 1
        End While
        Return codeColour
    End Function

    Function CheckDataExists(ByRef pID As String) As Boolean
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        sql_str = " select METER_NO from METER  "
        sql_str = sql_str & " where   METER_NO = '" + pID + "' "
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Do While dt.Rows.Count > i
                mDataSet = Nothing
                Return False
            Loop
            'Return True
        End If
        mDataSet = Nothing
        Return True
    End Function

    Function assignDropDown() As Boolean
        Dim sql_str As String
        sql_str = _
        "select C.COMP_ID||' '||C.COMPORT_NO as COMPORT " & _
        "from TAS.COMPORT C " & _
        "order by C.COMP_ID"
        assignDropDown(sql_str, "COMPORT", cbComport)
        assignDropDown(sql_str, "COMPORT", cbComport2)

        sql_str = ""
        sql_str = _
        "select  t.island_no  " & _
        " from tas.island t   " & _
        " order by t.island_no  "
        assignDropDown(sql_str, "island_no", cbIslandNo)

        sql_str = " select TYPE_ID from v_meter_type "
        assignDropDown(sql_str, "TYPE_ID", cbMeterType)

        sql_str = ""
        sql_str = _
        "select  t.TYPE_ID  , t.TYPE_NAME" & _
        " from tas.v_pulse_input t " & _
        " order  by  t.TYPE_ID"
        assignDropDown(sql_str, "TYPE_NAME", cmbPulsInput)

        sql_str = ""
        sql_str = _
        "select BASE_PRODUCT_ID " & _
        "from BASE_PRODUCT  " & _
        "order by BASE_PRODUCT_ID "
        assignDropDown(sql_str, "BASE_PRODUCT_ID", cbBaseProduct)
        assignDropDown(sql_str, "BASE_PRODUCT_ID", cbBaseProductID)

        For i = 1 To 50
            cbFormula.Items.Add(i)
        Next

        For i = 2 To 4
            cbMeterBlend.Items.Add(i)
        Next

        sql_str = ""
        sql_str = _
        "select  S.SALE_PRODUCT_ID ||'-'|| S.SALE_PRODUCT_NAME AS SALE_PRODUCT  " & _
        " from SALE_PRODUCT S" & _
        " Group by S.SALE_PRODUCT_ID  , S.SALE_PRODUCT_NAME  order by S.SALE_PRODUCT_ID  "
        assignDropDown(sql_str, "SALE_PRODUCT", cbSaleProduct)

        sql_str = ""
        sql_str = _
         "select ADDITIVE_NAME " & _
        " from METER_ADDITIVE " & _
        " Group By ADDITIVE_NAME order by ADDITIVE_NAME  "
        assignDropDown(sql_str, "ADDITIVE_NAME", cbAdditive)

        Return True
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
            mDataSet = Nothing
            Return True
        End If
        mDataSet = Nothing
        Return True
    End Function

    Private Sub setListboxWithName(ByVal name As String, ByVal cb As System.Object)
        Dim index As Integer = cb.FindString(name)
        If index = -1 Then
        Else
            cb.SelectedIndex = index
        End If
    End Sub

    Private Function AddDataSaleProduct()
        Dim strSQL As String
        strSQL = _
        "delete METER_PRODUCT where METER_NO ='" & Trim(textMeterSaleProduct.Text) & "'"
        If Oradb.ExeSQL(strSQL) Then
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If

        Dim i As Integer = 0
        Do While DataGridView1.RowCount > i
            'strSQL = " "
            'strSQL = strSQL & "insert into METER_PRODUCT("
            'strSQL = strSQL & "BATCH_ID,METER_NO,SALE_PRODUCT_ID,SALE_PRODUCT_NAME,"
            'strSQL = strSQL & " FORMULA_NO,IS_ENABLED,CREATION_DATE,"
            'strSQL = strSQL & " CREATED_BY,UPDATE_DATE,PERCENTAGE_1,PERCENTAGE_2"
            'strSQL = strSQL & ")values('" & ""
            'strSQL = strSQL & "1" & "' ,'" & Trim(DataGridView1.Item(0, i).Value) & "','" & Trim(DataGridView1.Item(1, i).Value) & "','" & Trim(DataGridView1.Item(2, i).Value) & "','"
            'strSQL = strSQL & Trim(DataGridView1.Item(3, i).Value) & "','" & IIf(Trim(DataGridView1.Item(6, i).Value) = "สามารถใช้งานได้", 1, 0) & "',sysdate,"
            'strSQL = strSQL & "'" & mUserName & "',sysdate," & DataGridView1.Item(4, i).Value & "," & DataGridView1.Item(5, i).Value & ")"
            strSQL = " "
            strSQL = strSQL & "insert into METER_PRODUCT("
            strSQL = strSQL & "BATCH_ID,METER_NO,SALE_PRODUCT_ID,SALE_PRODUCT_NAME,"
            strSQL = strSQL & " FORMULA_NO,IS_ENABLED,CREATION_DATE,"
            strSQL = strSQL & " CREATED_BY,UPDATE_DATE"
            strSQL = strSQL & ")values('" & ""
            strSQL = strSQL & "1" & "' ,'" & Trim(DataGridView1.Item(0, i).Value) & "','" & Trim(DataGridView1.Item(1, i).Value) & "','" & Trim(DataGridView1.Item(2, i).Value) & "','"
            strSQL = strSQL & Trim(DataGridView1.Item(3, i).Value) & "','" & IIf(Trim(DataGridView1.Item(6, i).Value) = "สามารถใช้งานได้", 1, 0) & "',sysdate,"
            strSQL = strSQL & "'" & mUserName & "',sysdate)"
            If Oradb.ExeSQL(strSQL) Then
            Else
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            End If
            i = i + 1
        Loop
        Return 0
    End Function

    Private Function AddDataAdditive()
        Dim strSQL As String
        strSQL = _
        "delete METER_ADDITIVE where METER_NO ='" & Trim(txtMeterA.Text) & "'"
        Oradb.ExeSQL(strSQL)

        Dim i As Integer = 0
        Do While DataGridView2.RowCount > i

            strSQL = "insert into METER_ADDITIVE(" & _
            "  BATCH_ID,METER_NO,ADDITIVE_NAME," & _
            " K_CAL_ADDITIVE,K_MEASURE_ADDITIVE, " & _
            " CREATION_DATE,CREATED_BY, " & _
            " UPDATE_DATE,UPDATED_BY) " & _
            " values('" & "" & _
            1 & "' ,'" & Trim(DataGridView2.Item(0, i).Value) & "','" & Trim(DataGridView2.Item(1, i).Value) & "','" & _
            Trim(DataGridView2.Item(3, i).Value) & "','" & Trim(DataGridView2.Item(2, i).Value) & "',sysdate," & _
            "'" & mUserName & "',sysdate," & _
            "'" & mUserName & "')"

            If Oradb.ExeSQL(strSQL) Then
            Else
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            End If
            i = i + 1
        Loop
        Return 0
    End Function

    Private Function AddDataTank()
        Dim strSQL As String
        strSQL = _
        "delete METER_TANK where METER_NO ='" & Trim(txtMetertank.Text) & "'"
        Oradb.ExeSQL(strSQL)


        Dim i As Integer = 0
        Do While DataGridView3.RowCount > i
            strSQL = _
            "insert into METER_TANK(" & _
            "BATCH_ID,METER_NO,TANK_ID,DESCRIPTION," & _
            " IS_ENABLED,CREATION_DATE," & _
            " CREATED_BY,UPDATE_DATE," & _
            " UPDATED_BY) " & _
            " values('" & "" _
            & 1 & "' ,'" & Trim(DataGridView3.Item(0, i).Value) & "','" & Trim(DataGridView3.Item(1, i).Value) & "','" & _
            Trim(Trim(DataGridView3.Item(1, i).Value)) & "','" & IIf(Trim(Trim(DataGridView3.Item(4, i).Value)) = "สามารถใช้งานได้", 1, 0) & "',sysdate," & _
            "'" & mUserName & "',sysdate," & _
            "'" & mUserName & "')"

            If Oradb.ExeSQL(strSQL) Then
            Else
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            End If
            i = i + 1
        Loop

        Return 0
    End Function

    Private Function AddDataMeterBlending()
        Dim strSQL As String
        strSQL = _
        "delete METER_BLEND where METER_NO ='" & Trim(txtMeterNo.Text) & "'"
        Oradb.ExeSQL(strSQL)
        Dim i As Integer = 0
        Do While DataGridView4.RowCount > i
            strSQL = _
            "insert into METER_BLEND(" & _
            "METER_NO,METER,BLEND_METER_NO," & _
            "BASE_PRODUCT_ID," & _
            "IS_ENABLED,DESCRIPTION,CREATION_DATE," & _
            "UPDATED_BY,J_COMPUTER)" & _
            "values(" & _
            "'" & DataGridView4.Item(0, i).Value & "'," & DataGridView4.Item(1, i).Value & ",'" & DataGridView4.Item(2, i).Value & "'" & _
            ",'" & DataGridView4.Item(4, i).Value & "'" & _
            "," & IIf(Trim(DataGridView4.Item(6, i).Value) = "สามารถใช้งานได้", 1, 0) & ",'" & Trim(DataGridView4.Item(9, i).Value) & "',sysdate" & _
            ",'" & Trim(DataGridView4.Item(8, i).Value) & "','" & mComputerName & "')"

            Oradb.ExeSQL(strSQL)

            i = i + 1
        Loop
        Return True
    End Function

    Private Sub DataGridView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        Dim index As Integer = DataGridView1.CurrentRow.Index
        cbSaleProduct.Text = DataGridView1.Rows(index).Cells(1).Value.ToString + "-" + DataGridView1.Rows(index).Cells(2).Value.ToString
        textSaleName.Text = DataGridView1.Rows(index).Cells(2).Value.ToString
        cbFormula.Text = DataGridView1.Rows(index).Cells(3).Value.ToString
        txt1stPercent.Text = DataGridView1.Rows(index).Cells(4).Value.ToString
        txt2ndPercent.Text = DataGridView1.Rows(index).Cells(5).Value.ToString

        ShowRecipePercent()

        If DataGridView1.Rows(index).Cells(6).Value = "สามารถใช้งานได้" Then
            OptProductEnabled.Checked = True
        Else
            OptProductUnEnabled.Checked = True
        End If
    End Sub

    Private Sub DataGridView2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView2.Click
        Dim index As Integer = DataGridView2.CurrentRow.Index
        txtMeterA.Text = txtMeterNo.Text
        cbAdditive.Text = DataGridView2.Rows(index).Cells(1).Value.ToString
        txtKFac.Text = DataGridView2.Rows(index).Cells(2).Value.ToString
        txtlatre.Text = DataGridView2.Rows(index).Cells(3).Value.ToString
    End Sub

    Private Sub DataGridView3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView3.Click
        Dim index As Integer = DataGridView3.CurrentRow.Index
        txtMetertank.Text = txtMeterNo.Text
        cbTankID.Text = DataGridView3.Rows(index).Cells(1).Value.ToString
        txtTankName.Text = DataGridView3.Rows(index).Cells(2).Value.ToString
        textDes.Text = DataGridView3.Rows(index).Cells(3).Value.ToString
        If DataGridView3.Rows(index).Cells(4).Value = "สามารถใช้งานได้" Then
            OptTankEnabled.Checked = True
        Else
            OptTankUnEnabled.Checked = True
        End If
    End Sub

    Private Sub DataGridView4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView4.Click
        Dim vRow As Integer = DataGridView4.CurrentRow.Index
        txtMeter.Text = DataGridView4.Rows(vRow).Cells(2).Value.ToString
        cbMeterBlend.Text = DataGridView4.Rows(vRow).Cells(1).Value.ToString
        cbBaseProductID.Text = DataGridView4.Rows(vRow).Cells(4).Value.ToString
        cbMeterBlend.Text = DataGridView4.Rows(vRow).Cells(1).Value.ToString
        txtDesc.Text = DataGridView4.Rows(vRow).Cells(10).Value.ToString
        If DataGridView4.Rows(vRow).Cells(6).Value = "สามารถใช้งานได้" Then
            OptBlendEnable.Checked = True
        Else
            OptBlendDisable.Checked = True
        End If
    End Sub

    Private Sub DataGridView5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView5.Click

    End Sub

    Private Sub cmdAddSaleProduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddSaleProduct.Click
        addDataGridProduct()
    End Sub

    Private Sub cbSaleProduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSaleProduct.SelectedIndexChanged
        Dim arrCbSaleProduct = Split(cbSaleProduct.Text, "-")
        If arrCbSaleProduct.Length > 1 Then

            textSaleName.Text = arrCbSaleProduct(1)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddDataTank()
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemoveSaleProduct.Click
        Dim index As Integer = DataGridView1.CurrentRow.Index
        DataGridView1.Rows.RemoveAt(index)

    End Sub

    Private Sub cmdAdd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddAddi.Click
        addDataGridAdditive()
    End Sub

    Private Sub addDataGridAdditive()
        Dim i As Integer
        Dim j As Integer = 0

        Do While DataGridView2.RowCount > j
            If DataGridView2.Item(1, j).Value = cbAdditive.Text Then
                Exit Sub
            End If

            j = j + 1
        Loop

        i = DataGridView2.RowCount
        DataGridView2.RowCount = DataGridView2.RowCount + 1
        DataGridView2.Item(0, i).Value = txtMeterA.Text
        DataGridView2.Item(1, i).Value = cbAdditive.Text
        DataGridView2.Item(2, i).Value = txtKFac.Text
        DataGridView2.Item(3, i).Value = txtlatre.Text
        DataGridView2.Item(4, i).Value = Date.Now
        DataGridView2.Item(5, i).Value = mUserName
    End Sub

    Private Sub cmdARemove2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdARemoveAddi.Click
        Dim index As Integer = DataGridView2.CurrentRow.Index
        DataGridView2.Rows.RemoveAt(index)
    End Sub

    Private Sub cmdAdd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddTank.Click
        addDataGridTank()
    End Sub

    Private Sub cmdRemove3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemoveTank.Click
        Dim index As Integer = DataGridView3.CurrentRow.Index
        DataGridView3.Rows.RemoveAt(index)
    End Sub

    Private Sub cmdAddBlend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddBlend.Click
        addDataGridMeterBlend()
    End Sub

    Private Sub cbMeterType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMeterType.SelectedIndexChanged
        Dim tabPage As TabPage
        If cbMeterType.Text.ToLower().Contains("blending") Then
            TabPage2.Show()
        Else
            TabPage2.Hide()
        End If
    End Sub

    Private Sub txtMeterNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMeterNo.TextChanged
        txtMeterBlend.Text = txtMeterNo.Text
        textMeterSaleProduct.Text = txtMeterNo.Text
        txtMeterA.Text = txtMeterNo.Text
        txtMetertank.Text = txtMeterNo.Text
        txtpMeterNo.Text = txtMeterNo.Text
    End Sub

   

End Class

