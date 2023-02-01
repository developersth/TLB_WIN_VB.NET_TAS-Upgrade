Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmMainVehicle_sub
    Dim frm_work As Integer = 0 'Vehicle1=add ,2=Edit
    Dim pk_id As String = ""
    Dim Tu

    Private Sub frmMainVehicle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        If frm_work = 1 Then
            DTPdateExprie.Value = DateAdd("YYYY", 1, DateTime.Today)
            Me.Text = "Vehicle # Add"
            GetNextID()
        ElseIf frm_work = 2 Then
            Me.Text = "Vehicle # Edit"
            AssignValue()
        End If
        txtLock(True)
        Show_Data()
        ShowDriver()
    End Sub

    Private Sub Clear_frm()
        txtTruckID.Text = ""
        txtTruckName.Text = ""
        cbTruckType.Items.Clear()
        cbTruck.Items.Clear()
        cbVehicle.Items.Clear()
        cbKind.Items.Clear()
        cbCarrier.Items.Clear()
        txtSeal.Text = "0"
        txtTareWeight.Text = "0"
        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""
        OptEnabled.Checked = True
        OptFind3.Checked = True

    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        If frm_work = 2 Then
            txtTruckID.Enabled = Not iBoo
            txtLastUpdateDate.Enabled = Not iBoo
            txtLastUpdateBy.Enabled = Not iBoo
            If iBoo Then
                txtTruckID.BackColor = Color.LightGray
                txtLastUpdateDate.BackColor = Color.LightGray
                txtLastUpdateBy.BackColor = Color.LightGray
            Else
                txtTruckID.BackColor = Color.White
                txtLastUpdateDate.BackColor = Color.White
                txtLastUpdateBy.BackColor = Color.White
            End If
        End If
    End Sub

#Region "Menu Event"
    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave
        If frm_work = 1 Then 'Add
            If txtTruckID.Text.Trim = "" Or cbTruckType.Text.Trim = "" Or cbTruck.Text.Trim = "" Or cbKind.Text.Trim = "" Or cbCarrier.Text.Trim = "" Or txtSeal.Text.Trim = "" Or txtTareWeight.Text.Trim = "" Then

                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If

        ElseIf frm_work = 2 Then 'Edit
            If txtTruckID.Text.Trim = "" Or cbTruckType.Text.Trim = "" Or cbTruck.Text.Trim = "" Or cbKind.Text.Trim = "" Or cbCarrier.Text.Trim = "" Or txtSeal.Text.Trim = "" Or txtTareWeight.Text.Trim = "" Then
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
        Dim arrCbTruckType = Split(cbTruckType.Text, "-")
        Dim arrCbCarrier = Split(cbCarrier.Text, "-")
        Dim arrCbTruck = Split(cbTruck.Text, "-")
        Dim arrCbVehicle = Split(cbVehicle.Text, "-")
        Dim strCbTruckType = arrCbTruckType(0)
        Dim strCbCarrier = arrCbCarrier(0)
        Dim strCbTruck = arrCbTruck(0)
        Dim strCbVehicle = arrCbVehicle(0)
        Dim strDate = DTPdateExprie.Value.ToString.Split(" ")
        Dim dateExp = strDate(0)
        Dim strSQL As String

        strSQL = "Insert into Tas.Vehicle (vehicle_number, " & _
        " vehicle_id,vehicle_type, tu_number ," & _
        " tu_number1,map_type,carrier_id ," & _
        " tare_weight , tot_seal,Is_enabled,expire_date,UPDATED_BY  ) " & _
        " values('" & Trim(txtTruckID.Text) & "','" & Trim(txtTruckName.Text) & "', " & _
        "'" & strCbTruckType & "','" & strCbTruck & "'," & _
        " '" & strCbVehicle & "','" & cbKind.Text & "', " & _
        " '" & strCbCarrier & "'," & Val(txtTareWeight.Text) & " ,'" & txtSeal.Text & "' ," & _
            IIf(OptEnabled.Checked = True, 1, 0) & ",TO_DATE('" & dateExp & "', 'dd/mm/yyyy'),'" & mUserName & "')"

        'MessageBox.Show(strSQL)
        If Oradb.ExeSQL(strSQL) Then
            Oradb.ExeSQL("Delete from tas.driver_mapping  where vehicle_number='" & txtTruckID.Text & "'")
            Dim i As Integer = 0
                Do While DataGridView2.RowCount > i
                strSQL = "insert into tas.driver_mapping (vehicle_number,driver_id,update_date) " & _
                        " values('" & txtTruckID.Text & "', " & Trim(DataGridView2.Item(0, i).Value.ToString()) & " ,sysdate)"
                    Oradb.ExeSQL(strSQL)
                    i = i + 1
                Loop

            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmMainVehicle_main.Show_Data()
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
        Dim arrCbTruckType = Split(cbTruckType.Text, "-")
        Dim arrCbCarrier = Split(cbCarrier.Text, "-")
        Dim arrCbTruck = Split(cbTruck.Text, "-")
        Dim arrCbVehicle = Split(cbVehicle.Text, "-")
        Dim strCbTruckType = arrCbTruckType(0)
        Dim strCbCarrier = arrCbCarrier(0)
        Dim strCbTruck = arrCbTruck(0)
        Dim strCbVehicle = arrCbVehicle(0)
        Dim strDate = DTPdateExprie.Value.ToString.Split(" ")
        Dim dateExp = strDate(0)
        Dim strSQL As String = _
        "Update Tas.Vehicle SET  " & _
        "vehicle_id= '" & Trim(txtTruckName.Text.Trim) & "',vehicle_type='" & strCbTruckType & "', " & _
        "tu_number='" & strCbTruck & "',tu_number1='" & strCbVehicle & "', tot_seal='" & txtSeal.Text.Trim & "' , " & _
        " map_type='" & cbKind.Text.Trim & "',carrier_id='" & strCbCarrier & "',tare_weight=" & Val(txtTareWeight.Text.Trim) & " ," & _
        " EXPIRE_DATE= TO_DATE('" & dateExp & "', 'dd/mm/yyyy')" & " ," & _
        "IS_ENABLED=" & IIf(OptEnabled.Checked = True, 1, 0) & " ," & _
        "UPDATED_BY='" & mUserName & "' " & _
        " Where vehicle_number='" & Trim(txtTruckID.Text.Trim) & "'"
   
        If Oradb.ExeSQL(strSQL) Then
            Oradb.ExeSQL("Delete from tas.driver_mapping  where vehicle_number='" & txtTruckID.Text & "'")
            Dim i As Integer = 0
            Do While DataGridView2.RowCount > i
                strSQL = "insert into tas.driver_mapping (vehicle_number,driver_id,update_date) " & _
                    " values('" & txtTruckID.Text & "', " & Trim(DataGridView2.Item(0, i).Value.ToString()) & " ,sysdate)"
                Oradb.ExeSQL(strSQL)
                i = i + 1
            Loop
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmMainVehicle_main.Show_Data()
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
        "select v.vehicle_number,v.vehicle_type||'-'||tu.description as vehicle_type,v.vehicle_id,v.driver_id,v.map_type,v.tot_seal,v.expire_date,v.is_enabled," & _
        " v.carrier_id,v.tu_number,v.tu_number1,v.update_date,v.updated_by,c.carrier_name,v.tare_weight,  " & _
        " u.tu_id as tu_name,u1.tu_id as tu_name1" & _
        " from vehicle v,tas.transport_unit u,tas.transport_unit u1,carrier c,tas.view_tu_type tu " & _
        " where v.tu_number=u.tu_number(+)" & _
        " and v.tu_number1=u1.tu_number(+)" & _
        " and v.carrier_id=c.carrier_id(+)  " & _
        " and v.vehicle_type=tu.status_varchar(+)" & _
        " and v.vehicle_number='" & pk_id & "'"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            txtTruckID.Text = IIf(IsDBNull(dt.Rows(i).Item("vehicle_number")), "", dt.Rows(i).Item("vehicle_number").ToString)
            txtTruckName.Text = IIf(IsDBNull(dt.Rows(i).Item("vehicle_id")), "", dt.Rows(i).Item("vehicle_id").ToString)
            txtTareWeight.Text = IIf(IsDBNull(dt.Rows(i).Item("tare_weight")), "", dt.Rows(i).Item("tare_weight").ToString)
            txtSeal.Text = IIf(IsDBNull(dt.Rows(i).Item("tot_seal")), "", dt.Rows(i).Item("tot_seal").ToString)
            cbTruckType.Text = IIf(IsDBNull(dt.Rows(i).Item("Vehicle_Type")), "", dt.Rows(i).Item("Vehicle_Type").ToString)
            cbKind.Text = IIf(IsDBNull(dt.Rows(i).Item("map_type")), "", dt.Rows(i).Item("map_type").ToString)
            setListboxWithName(IIf(IsDBNull(dt.Rows(i).Item("carrier_id")), "", dt.Rows(i).Item("carrier_id").ToString), cbCarrier)
            setListboxWithName(IIf(IsDBNull(dt.Rows(i).Item("tu_number")), "", dt.Rows(i).Item("tu_number").ToString), cbTruck)
            setListboxWithName(IIf(IsDBNull(dt.Rows(i).Item("tu_number1")), "", dt.Rows(i).Item("tu_number1").ToString), cbVehicle)
            DTPdateExprie.Value = IIf(IsDBNull(dt.Rows(i).Item("EXPIRE_DATE")), "", dt.Rows(i).Item("EXPIRE_DATE").ToString)
            If IIf(IsDBNull(dt.Rows(i).Item("is_enabled")), "", dt.Rows(i).Item("is_enabled").ToString) = 1 Then
                OptEnabled.Checked = True
            Else
                OptUnEnbled.Checked = True
            End If

            txtLastUpdateDate.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
            txtLastUpdateBy.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
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

    Function assignDropDown() As Boolean
        Dim sql_str As String
        sql_str = " "
        sql_str = _
        "select C.CARRIER_ID,C.CARRIER_NAME " & _
        "from CARRIER C " & _
        "order by C.CARRIER_NAME"
        assignDropDown(sql_str, "CARRIER_ID", "CARRIER_NAME", cbCarrier)

        sql_str = "select t.tu_number, t.tu_id  from transport_unit t where t.tu_id is not null  order by t.tu_number"
        assignDropDown(sql_str, "TU_NUMBER", "Tu_id", cbTruck)

        sql_str = "select t.tu_number, t.tu_id  from transport_unit t where t.tu_id is not null  order by t.tu_number"
        assignDropDown(sql_str, "tu_number", "Tu_id", cbVehicle)

        sql_str = "select *  from v_vehicle_map_type t"
        assignDropDown(sql_str, "type_id", cbKind)

        sql_str = "select t.status_varchar||'-'||t.description As vehicle_type  from tas.view_tu_type t" & _
               " order by t.status_varchar"
        assignDropDown(sql_str, "vehicle_type", cbTruckType)

        Return 0
    End Function

    Function assignDropDown(ByVal sql_str As String, ByVal colName1 As String, ByVal colName2 As String, ByVal cb As System.Object) As Boolean
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Dim temCb As String
            Do While dt.Rows.Count > i
                temCb = IIf(IsDBNull(dt.Rows(i).Item(colName1)), "", dt.Rows(i).Item(colName1).ToString) & "-" & IIf(IsDBNull(dt.Rows(i).Item(colName2)), "", dt.Rows(i).Item(colName2).ToString)
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


    Private Sub setListboxWithName(ByVal name As String, ByVal cb As System.Object)
        Dim index As Integer = cb.FindString(name)
        If name <> "" Then
            If index = -1 Then
            Else
                cb.SelectedIndex = index
            End If
        End If
       
    End Sub

    Private Function GetNextID() As Integer
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        sql_str = _
        " select MAX((PUMP_ID)+1) as MaxID from PUMP"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
        End If
        Return 1
    End Function

    Public Sub Show_Data()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = _
        "select D.DRIVER_ID,d.driver_code,trim(D.FIRST_NAME || '  ' || D.LAST_NAME) as DRIVER_NAME,DM.STATUS_USED " & _
        "from DRIVER D,DRIVER_MAPPING DM " & _
        "where D.DRIVER_ID = DM.DRIVER_ID " & _
        "and DM.vehicle_number='" & pk_id & "' " & _
        "order by D.FIRST_NAME"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView2.RowCount = 0
            Do While dt.Rows.Count > i
                DataGridView2.RowCount = DataGridView2.RowCount + 1
                DataGridView2.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Driver_id")), "", dt.Rows(i).Item("Driver_id").ToString)
                DataGridView2.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("driver_code")), "", dt.Rows(i).Item("driver_code").ToString)
                DataGridView2.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("driver_name")), "", dt.Rows(i).Item("driver_name").ToString)
                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Public Sub ShowDriver()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "select D.DRIVER_ID,D.Driver_code,trim(D.FIRST_NAME || '  ' || D.LAST_NAME) as DRIVER_NAME "
        sql_str = sql_str & "from DRIVER D "
        If OptFind1.Checked = True Then
            sql_str = sql_str & " where  FIRST_NAME like '%" & txtSearch.Text & "%'  or LAST_NAME like '%" & txtSearch.Text & "%'"
        End If
        If OptFind2.Checked = True Then
            sql_str = sql_str & " where  DRIVER_ID like '%" & txtSearch.Text & "%' "
        End If
        sql_str = sql_str & " order by D.FIRST_NAME"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView1.RowCount = 0
            Do While dt.Rows.Count > i
                DataGridView1.RowCount = DataGridView1.RowCount + 1
                DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Driver_id")), "", dt.Rows(i).Item("Driver_id").ToString)
                DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("driver_code")), "", dt.Rows(i).Item("driver_code").ToString)
                DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("driver_name")), "", dt.Rows(i).Item("driver_name").ToString)
                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.RowCount <= 0 Or DataGridView1.RowCount < 0 Then Exit Sub
       addDriver()
    End Sub

    Sub addDriver()
        Dim i As Integer = 0
        Dim index As Integer = DataGridView1.CurrentRow.Index
        Do While DataGridView2.RowCount > i

            If DataGridView1.Rows(index).Cells(0).Value.ToString = DataGridView2.Item(0, i).Value.ToString() Then
                MessageBox.Show("มีพนักงานขับรถ เลขที่ " & DataGridView1.Rows(index).Cells(0).Value.ToString & " อยู่ในรายการ")
                Exit Sub
            End If
            i = i + 1

        Loop
        i = DataGridView2.RowCount

        DataGridView2.RowCount = DataGridView2.RowCount + 1
        DataGridView2.Item(0, i).Value = DataGridView1.Rows(index).Cells(0).Value.ToString
        DataGridView2.Item(1, i).Value = DataGridView1.Rows(index).Cells(1).Value.ToString
        DataGridView2.Item(2, i).Value = DataGridView1.Rows(index).Cells(2).Value.ToString

    End Sub
    
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        ShowDriver()
    End Sub

    Private Sub OptFind3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptFind3.CheckedChanged
        ShowDriver()
        txtSearch.Enabled = False
        txtSearch.Text = ""
    End Sub

    Private Sub OptFind2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptFind2.CheckedChanged
        txtSearch.Enabled = True
        txtSearch.Text = ""
    End Sub

    Private Sub OptFind1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptFind1.CheckedChanged
        txtSearch.Enabled = True
        txtSearch.Text = ""
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        addDriver()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim index As Integer = DataGridView2.CurrentRow.Index
        DataGridView2.Rows.RemoveAt(index)
    End Sub

    Private Sub cbKind_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbKind.SelectedIndexChanged
        If Trim(cbKind.Text) = "TRAILER" Then
            cbTruck.Enabled = True
            cbVehicle.Enabled = True
            cmdSearchTail.Enabled = True
        ElseIf Trim(cbKind.Text) = "SEMITRAILER" Then
            'cbTruck.Items.Clear()
            cbTruck.Enabled = True
            cbVehicle.Enabled = True
            cmdSearchTail.Enabled = True
        Else
            cbTruck.Enabled = True
            cbVehicle.SelectedIndex = -1
            cbVehicle.Enabled = False
            cmdSearchTail.Enabled = False
        End If
    End Sub

    Private Sub cbTruck_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbTruck.SelectedIndexChanged
        'Dim vTruck = cbTruck.Text.Split("-")
        'SelectTruckID(vTruck(0))
    End Sub
    Private Sub SelectTruckID(ByVal vTruck As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "select t.tu_number, t.tu_id,t.tare_weight,t.fix_seal  from transport_unit t  " & _
                  "where t.tu_number = '" & vTruck & "' " & _
                  "order by t.tu_number "
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView1.RowCount = 0
            Do While dt.Rows.Count > i
                ' txtTruckID.Text = IIf(IsDBNull(dt.Rows(i).Item("tu_id")), "", dt.Rows(i).Item("tu_id").ToString)
                ' txtTruckName.Text = IIf(IsDBNull(dt.Rows(i).Item("tu_id")), "", dt.Rows(i).Item("tu_id").ToString)
                txtSeal.Text = IIf(IsDBNull(dt.Rows(i).Item("fix_seal")), "", dt.Rows(i).Item("fix_seal").ToString)
                txtTareWeight.Text = IIf(IsDBNull(dt.Rows(i).Item("tare_weight")), "", dt.Rows(i).Item("tare_weight").ToString)
                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub cbVehicle_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbVehicle.SelectedIndexChanged
        'Dim vTruck = cbVehicle.Text.Split("-")
        'SelectTruckID(vTruck(0))
    End Sub

    Private Sub cmdSearchTruck_Click(sender As System.Object, e As System.EventArgs) Handles cmdSearchTruck.Click
        dfindIncombo.Show()
        dfindIncombo.FindData(5, cbTruck)
    End Sub

    Private Sub cmdSearchTail_Click(sender As System.Object, e As System.EventArgs) Handles cmdSearchTail.Click
        dfindIncombo.Show()
        dfindIncombo.FindData(6, cbVehicle)
    End Sub

    Private Sub cmbSearchCarrier_Click(sender As System.Object, e As System.EventArgs) Handles cmbSearchCarrier.Click
        dfindIncombo.Show()
        dfindIncombo.FindData(7, cbCarrier)
    End Sub

    Private Sub btTruckType_Click(sender As Object, e As EventArgs) Handles btTruckType.Click
        frmMainTransportUnit_VehicleType.Close()
        frmMainTransportUnit_VehicleType.ShowDialog()
    End Sub

    Private Sub cbTruckType_Click(sender As Object, e As EventArgs) Handles cbTruckType.Click
        cbTruckType.Items.Clear()
        assignDropDown()
    End Sub

    Private Sub btCountWeight_Click(sender As System.Object, e As System.EventArgs) Handles btCountWeight.Click
        Dim vTruck() As String
        If Trim(cbKind.Text) = "TRAILER" Or Trim(cbKind.Text) = "SEMITRAILER" Then
            If Trim(cbTruck.Text) = "" And Trim(cbVehicle.Text) = "" Then
                MsgBox("ท่านไม่ได้กรอกทะเบียนตัวลาก หรือหางพ่วง", MsgBoxStyle.Information, "TAS System")
                Exit Sub
            End If
            vTruck = cbVehicle.Text.Split("-")
            SelectTruckID(vTruck(0))
        Else
            If Trim(cbTruck.Text.ToString = "") Then
                MsgBox("ท่านไม่ได้กรอกทะเบียน", MsgBoxStyle.Information, "TAS System")
                Exit Sub
            End If
            vTruck = cbTruck.Text.Split("-")
            SelectTruckID(vTruck(0))
        End If
    End Sub
End Class


