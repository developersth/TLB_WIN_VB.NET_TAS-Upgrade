Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmConfigSaleProduct_sub
    Dim frm_work As Integer = 0 '1=add ,2=Edit
    Dim pk_id As String = ""

    Private Sub frmConfigSaleProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        If frm_work = 1 Then
            Me.Text = "SaleProduct # Add"
            GetNextID()
        ElseIf frm_work = 2 Then
            Me.Text = "SaleProduct # Edit"
            AssignValue()
        End If
        txtLock(True)
    End Sub

    Private Sub Clear_frm()
        txtProductCode.Text = ""
        txtProductID.Text = ""
        txtProductName.Text = ""
        cbSaleUnit.Text = ""
        txtMapOilsys.Text = ""
        cbBaseProduct.Text = ""
        txtProductDescription.Text = ""
        txtGroupPro.Text = ""
        txtAutoSort.Text = ""
        OptEnabled.Checked = True
        OptWeight.Checked = True
        OptLoaded.Checked = True
        OptLoadMeter.Checked = True
        OptCheckWeight.Checked = True
        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""
        OptEnabled.Checked = True

    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
    End Sub

#Region "Menu Event"
    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave
        If frm_work = 1 Then 'Add
            If txtProductID.Text.Trim = "" Or txtProductName.Text.Trim = "" Or cbSaleUnit.Text.Trim = "" Or txtMapOilsys.Text.Trim = "" Or cbBaseProduct.Text.Trim = "" Or txtProductDescription.Text.Trim = "" Or txtGroupPro.Text.Trim = "" Then

                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If txtProductID.Text.Trim = "" Or txtProductName.Text.Trim = "" Or cbSaleUnit.Text.Trim = "" Or txtMapOilsys.Text.Trim = "" Or cbBaseProduct.Text.Trim = "" Or txtProductDescription.Text.Trim = "" Or txtGroupPro.Text.Trim = "" Then

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
        Dim strSQL As String = _
        "insert into SALE_PRODUCT(" & _
        "SALE_PRODUCT_ID,SALE_PRODUCT_NAME," & _
        "SALE_PRODUCT_CODE,SALE_PRODUCT_TYPE,UNIT,base_product_id,DESCRIPTION,PRODUCT_MAP_OILSYS," & _
        "IS_WEIGHT_PROCESS,is_meter_load,IS_CHECK_TARE_WIEGHT,IS_LOAD_PROCESS," & _
        "CREATION_DATE,CREATED_BY," & _
        "UPDATE_DATE,UPDATED_BY," & _
        "AUTO_SORT,IS_ENABLE,GROUP_NAME,GOV_COQ_NO,GOV_COQ_DATE) " & _
        "values(" & _
        "'" & Trim(txtProductID.Text) & "','" & Trim(txtProductName.Text) & "'," & _
        "'" & Trim(txtProductCode.Text) & "','" & cbProductType.Text & "','" & Trim(txtMapOilsys.Text) & "', " & _
        " '" & cbSaleUnit.Text & "'," & _
        " '" & cbBaseProduct.Text & "'," & _
        "'" & Trim(txtProductDescription.Text) & "'," & _
        IIf(OptWeight.Checked = True, 1, 0) & "," & _
        IIf(OptLoadMeter.Checked = True, 1, 0) & "," & _
        IIf(OptCheckWeight.Checked = True, 1, 0) & "," & _
        IIf(OptLoaded.Checked = True, 1, 0) & "," & _
        "sysdate,'" & mUserName & "'," & _
        "sysdate,'" & mUserName & "'," & _
        "'" & Trim(txtAutoSort.Text) & "'," & _
        IIf(OptEnabled.Checked = True, 1, 0) & ",'" & Trim(txtGroupPro.Text) & "','" & Trim(Txt_GOV_COQ_NO.Text) & "'," & _
        "to_date('" & txtGOV_COQ_DATE.Value.ToString("dd/MM/yyyy") & "','dd/mm/yyyy') )"

        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigSaleProduct_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If

    End Sub

    Public Sub setFrmWork(ByVal n As Integer)
        Me.frm_work = n
    End Sub

    Public Sub setPkId(ByVal id As String)
        Me.pk_id = id
    End Sub

    Private Sub Edit()
        Dim strSQL As String = _
        "update SALE_PRODUCT S set " & _
        "S.SALE_PRODUCT_NAME='" & Trim(txtProductName.Text) & "'," & _
        "S.SALE_PRODUCT_CODE='" & Trim(txtProductCode.Text) & "'," & _
        "S.PRODUCT_MAP_OILSYS='" & Trim(txtMapOilsys.Text) & "'," & _
        "S.SALE_PRODUCT_TYPE='" & Trim(cbProductType.Text) & "'," & _
        "S.UNIT='" & Trim(cbSaleUnit.Text) & "'," & _
        "S.base_product_id='" & Trim(cbBaseProduct.Text) & "'," & _
        "S.DESCRIPTION='" & Trim(txtProductDescription.Text) & "'," & _
        "S.UPDATE_DATE=sysdate," & _
        "S.UPDATED_BY='" & mUserName & "'," & _
        "S.AUTO_SORT= '" & Trim(txtAutoSort.Text) & "' ," & _
        "S.IS_WEIGHT_PROCESS=" & IIf(OptWeight.Checked = True, 1, 0) & "," & _
        "S.is_meter_load=" & IIf(OptLoadMeter.Checked = True, 1, 0) & "," & _
        "S.IS_CHECK_TARE_WIEGHT=" & IIf(OptCheckWeight.Checked = True, 1, 0) & "," & _
        "S.IS_LOAD_PROCESS=" & IIf(OptLoaded.Checked = True, 1, 0) & "," & _
        "S.IS_ENABLE=" & IIf(OptEnabled.Checked = True, 1, 0) & "," & _
        "S.GROUP_NAME='" & Trim(txtGroupPro.Text) & "'," & _
        "S.GOV_COQ_NO='" & Trim(Txt_GOV_COQ_NO.Text) & "'," & _
        "S.GOV_COQ_DATE=to_date('" & txtGOV_COQ_DATE.Value.ToString("dd/MM/yyyy") & "','dd/mm/yyyy') " & _
        " where S.SALE_PRODUCT_ID='" & Trim(txtProductID.Text) & "'"
        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigSaleProduct_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If

    End Sub

    Private Sub AssignValue()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        sql_str = _
        "select S.SALE_PRODUCT_ID,S.SALE_PRODUCT_NAME,S.SALE_PRODUCT_TYPE,S.PRODUCT_MAP_OILSYS,S.UNIT,S.GROUP_NAME," & _
        " S.SALE_PRODUCT_CODE," & _
        "S.DESCRIPTION , S.UPDATE_DATE, S.UPDATED_BY, " & _
        "S.IS_WEIGHT_PROCESS,S.IS_LOAD_PROCESS," & _
        "S.AUTO_SORT,S.IS_ENABLE,s.base_product_id,s.is_meter_load,s.IS_CHECK_TARE_WIEGHT, S.GOV_COQ_NO,to_char(S.GOV_COQ_DATE,'dd/mm/yyyy') as GOV_COQ_DATE " & _
        " from SALE_PRODUCT S " & _
        " where S.SALE_PRODUCT_ID='" & pk_id & "'"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            txtProductID.Text = IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT_ID")), "", dt.Rows(i).Item("SALE_PRODUCT_ID").ToString)
            txtProductName.Text = IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT_NAME")), "", dt.Rows(i).Item("SALE_PRODUCT_NAME").ToString)
            txtProductCode.Text = IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT_CODE")), "", dt.Rows(i).Item("SALE_PRODUCT_CODE").ToString)
            txtMapOilsys.Text = IIf(IsDBNull(dt.Rows(i).Item("PRODUCT_MAP_OILSYS")), "", dt.Rows(i).Item("PRODUCT_MAP_OILSYS").ToString)
            txtGroupPro.Text = IIf(IsDBNull(dt.Rows(i).Item("GROUP_NAME")), "", dt.Rows(i).Item("GROUP_NAME").ToString)
            cbBaseProduct.Text = IIf(IsDBNull(dt.Rows(i).Item("base_product_id")), "", dt.Rows(i).Item("base_product_id").ToString)
            cbSaleUnit.Text = IIf(IsDBNull(dt.Rows(i).Item("unit")), "", dt.Rows(i).Item("unit").ToString)
            txtProductDescription.Text = IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION").ToString)
            Txt_GOV_COQ_NO.Text = IIf(IsDBNull(dt.Rows(i).Item("GOV_COQ_NO")), "", dt.Rows(i).Item("GOV_COQ_NO").ToString)
            If dt.Rows(i).Item("GOV_COQ_DATE").ToString.Equals("") Then
                txtGOV_COQ_DATE.Value = Date.Now
            Else
                txtGOV_COQ_DATE.Value = Date.ParseExact(dt.Rows(i).Item("GOV_COQ_DATE").ToString, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo, Globalization.DateTimeStyles.None)
            End If

            If IIf(IsDBNull(dt.Rows(i).Item("IS_WEIGHT_PROCESS")), "", dt.Rows(i).Item("IS_WEIGHT_PROCESS").ToString) = 1 Then
                OptWeight.Checked = True
            Else
                OptUnWeight.Checked = True
            End If

            If IIf(IsDBNull(dt.Rows(i).Item("IS_LOAD_PROCESS")), "", dt.Rows(i).Item("IS_LOAD_PROCESS").ToString) = 1 Then
                OptLoaded.Checked = True
            Else
                OptUnLoad.Checked = True
            End If

            If IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLE")), "", dt.Rows(i).Item("IS_ENABLE").ToString) = 1 Then
                OptEnabled.Checked = True
            Else
                OptUnEnbled.Checked = True
            End If

            If IIf(IsDBNull(dt.Rows(i).Item("is_meter_load")), "", dt.Rows(i).Item("is_meter_load").ToString) = 1 Then
                OptLoadMeter.Checked = True
            Else
                OptDoNotLoadMeter.Checked = True
            End If

            If IIf(IsDBNull(dt.Rows(i).Item("IS_CHECK_TARE_WIEGHT")), "", dt.Rows(i).Item("IS_CHECK_TARE_WIEGHT").ToString) = 1 Then
                OptCheckWeight.Checked = True
            Else
                OptUnCheckWeight.Checked = True
            End If

            txtAutoSort.Text = IIf(IsDBNull(dt.Rows(i).Item("AUTO_SORT")), "", dt.Rows(i).Item("AUTO_SORT").ToString)
            txtLastUpdateDate.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
            txtLastUpdateBy.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)

        Else
        End If
        mDataSet = Nothing
        dt = Nothing
    End Sub

    Private Function appendZero(ByVal codeColour As String) As String
        Dim i As Integer = 6 - codeColour.Length
        While (i <> 0)
            codeColour = "0" + codeColour
            i = i - 1
        End While
        Return codeColour
    End Function

    Function assignDropDown() As Boolean
        Dim sql_str As String
        sql_str = "select t.status_varchar from view_unit t"
        assignDropDown(sql_str, "status_varchar", cbSaleUnit)

        sql_str = "select t.base_product_ID from tas.base_product t" & _
        " order by t.base_product_id"
        assignDropDown(sql_str, "base_product_ID", cbBaseProduct)
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
            'Return True
        End If
        mDataSet = Nothing
        dt = Nothing
        Return True
    End Function

    Private Sub setListboxWithName(ByVal name As String, ByVal cb As System.Object)
        Dim index As Integer = cb.FindString(name)
        If index = -1 Then
        Else
            cb.SelectedIndex = index
        End If
    End Sub

    Private Function GetNextID() As Integer
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        sql_str = _
        " select MAX((SALE_PRODUCT_ID)+1) as MaxID from SALE_PRODUCT "
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            txtProductID.Text = IIf(IsDBNull(dt.Rows(0).Item("MaxID")), "", dt.Rows(0).Item("MaxID").ToString)
        End If
        mDataSet = Nothing
        dt = Nothing
        Return 1
    End Function

End Class

