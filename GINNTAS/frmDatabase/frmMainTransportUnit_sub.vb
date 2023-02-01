Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmMainTransportUnit_sub
    Dim frm_work As Integer = 0 'TransportUnit1=add ,2=Edit
    Dim pk_id As String = ""

    Private Sub frmMainTransportUnit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        If frm_work = 1 Then
            DTPnextCalDate.Value = DateAdd("YYYY", 1, DateTime.Today)
            Me.Text = "TransportUnit # Add"
            GetNextID()
            cbUnit.SelectedIndex = 0
            cbTotComp.SelectedIndex = 0
        ElseIf frm_work = 2 Then
            Me.Text = "TransportUnit # Edit"
            AssignValue()
        End If
        txtLock(True)
        ShowTransportComps(pk_id)
        ShowBlackList(pk_id)
    End Sub

    Private Sub Clear_frm()

        txtCompCap1.Text = 0
        txtCompCap2.Text = 0
        txtCompCap3.Text = 0
        txtCompCap4.Text = 0
        txtCompCap5.Text = 0
        txtCompCap6.Text = 0
        txtCompCap7.Text = 0
        txtCompCap8.Text = 0
        txtCompCap9.Text = 0
        txtCompCap10.Text = 0
        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""
        OptEnabled.Checked = True
        OptIsUnEnBlackList.Checked = True
        txtDesc.Text = ""
        txtTruckName.Text = ""
        txtTareW.Text = ""
        txtTuNumber.Text = ""
        txtSeal.Text = ""
        txtTruckCapacity.Text = ""

    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        txtLastUpdateDate.Enabled = Not iBoo
        txtLastUpdateBy.Enabled = Not iBoo
        If iBoo Then
            txtLastUpdateDate.BackColor = Color.LightGray
            txtLastUpdateBy.BackColor = Color.LightGray
        Else
            txtLastUpdateDate.BackColor = Color.White
            txtLastUpdateBy.BackColor = Color.White
        End If
    End Sub

#Region "Menu Event"
    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave
     
        If frm_work = 1 Then 'Add
            If CheckDataExist(txtTuNumber.Text) Then
                GetNextID()
                Exit Sub
            End If
            If txtTuNumber.Text.Trim = "" Or txtSeal.Text.Trim = "" Or txtTruckName.Text.Trim = "" Or cbTruckType.Text.Trim = "" Or cbCarrier.Text.Trim = "" Then

                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If txtTuNumber.Text.Trim = "" Or txtSeal.Text.Trim = "" Or txtTruckName.Text.Trim = "" Or cbTruckType.Text.Trim = "" Or cbCarrier.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Edit()
            End If
        End If
    End Sub
    Function CheckDataExist(ByVal ip As Integer) As Boolean
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim vCheck As Boolean = False
        strSQL = _
            "select count(C.TU_NUMBER) as vCount " & _
               "from TRANSPORT_UNIT C " & _
               "where C.TU_NUMBER = " & ip
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            If dt.Rows.Count > 0 Then
                If dt.Rows(i).Item("vCount") > 0 Then
                    MsgBox("มีรหัสรถ " & ip & " อยู่ในฐานข้อมูลแล้ว", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                    vCheck = True
                Else
                    vCheck = False
                End If
            End If
        End If
        Return vCheck
    End Function
    Private Sub UcCancel1_OnClickCancel(ByVal ucName As System.String) Handles UcCancel1.OnClickCancel
        Me.Close()
        'Initial_frm()
    End Sub

#End Region

    Private Sub Save()
        Dim tmpCarrier
        Dim tmpCarr1 As String
        If InStr(1, cbCarrier.Text, "-") = 0 Then
            tmpCarr1 = ""
        Else
            tmpCarrier = Split(cbCarrier.Text, "-")
            tmpCarr1 = tmpCarrier(0)
        End If

        Dim tmpTU_TYPE1

        If InStr(1, cbTruckType.Text, "-") = 0 Then
            tmpTU_TYPE1 = cbTruckType.Text
        Else
            Dim arrTmpTU_TYPE = Split(cbTruckType.Text, "-")
            tmpTU_TYPE1 = arrTmpTU_TYPE(0)
            If tmpTU_TYPE1 = "" Then
                Exit Sub
            End If
        End If
     

        Dim strSQL As String
        strSQL = _
        "insert into TRANSPORT_UNIT(" & _
        "TU_NUMBER,TU_ID,TU_TYPE,FIX_SEAL,TARE_WEIGHT,MAX_LOAD_WEIGHT,UNIT," & _
        "NEXT_CAL_DATE," & _
        "IS_ENABLED,COMPARTMENTS,CARRIER_ID," & _
        " CAPACITYS, COMP_1," & _
        "COMP_2,COMP_3," & _
        "COMP_4,COMP_5," & _
        "COMP_6,COMP_7," & _
        "COMP_8,COMP_9," & _
        "COMP_10,CREATION_DATE," & _
        "CREATED_BY,UPDATE_DATE," & _
        "UPDATED_BY) " & _
        "values(" & _
        Val(txtTuNumber.Text) & ",'" & Trim(txtTruckName.Text) & "','" & Trim(tmpTU_TYPE1) & "','" & Trim(txtSeal.Text) & "','" & Trim(txtTareW.Text) & "','" & Trim(TxtMaxLoad.Text) & "','" & Trim(cbUnit.Text) & "', " & _
        "to_date('" & Format(DTPnextCalDate.Value, "dd/MM/yyyy") & "','dd/mm/yyyy')," & _
        IIf(OptEnabled.Checked, 1, 0) & "," & Val(cbTotComp.Text) & "," & Trim(tmpCarr1) & "," & _
        Val(txtTruckCapacity.Text) & "," & Val(txtCompCap1.Text) & "," & _
        Val(txtCompCap2.Text) & "," & Val(txtCompCap3.Text) & "," & _
        Val(txtCompCap4.Text) & "," & Val(txtCompCap5.Text) & "," & _
        Val(txtCompCap6.Text) & "," & Val(txtCompCap7.Text) & "," & _
        Val(txtCompCap8.Text) & "," & Val(txtCompCap9.Text) & "," & _
        Val(txtCompCap10.Text) & ",sysdate," & _
        "'" & mUserName & "',sysdate," & _
        "'" & mUserName & "')"

        If Oradb.ExeSQL(strSQL) Then
            AddDataTransportComps()
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmMainTransportUnit_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If

    End Sub

    Private Sub ShowTransportComps(ByVal MeterNo As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = _
        "SELECT T.TU_NUMBER,T.CAPACITY,T.COMPARTMENT " & _
        "  FROM TRANSPORT_COMPS T" & _
        " WHERE T.TU_NUMBER = '" & (Trim(txtTuNumber.Text)) & "' " & _
        "  ORDER BY T.COMPARTMENT"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView1.RowCount = 0
            Do While dt.Rows.Count > i
                DataGridView1.RowCount = DataGridView1.RowCount + 1
                DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("COMPARTMENT")), "", dt.Rows(i).Item("COMPARTMENT").ToString)
                DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CAPACITY")), "", dt.Rows(i).Item("CAPACITY").ToString)
                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
       
    End Sub


    Private Function AddDataTransportComps()
        Dim strSQL As String
        strSQL = "delete TRANSPORT_COMPS where TU_NUMBER ='" & Trim(pk_id) & "'"
        Oradb.ExeSQL(strSQL)
        Dim i As Integer = 0
        Do While DataGridView1.RowCount > i
            If frm_work = 2 Then
                strSQL = _
                "delete from tas.TRANSPORT_COMPS " & _
                " where TU_NUMBER = " & Trim(pk_id) &
                " and COMPARTMENT = " & Trim(DataGridView1.Item(0, i).Value)
                Oradb.ExeSQL(strSQL)
            End If
            strSQL = _
            "insert into tas.TRANSPORT_COMPS(" & _
            "TU_NUMBER," & _
            "CAPACITY," & _
            "COMPARTMENT," & _
            "CREATION_DATE," & _
            "CREATED_BY,UPDATE_DATE," & _
            "UPDATED_BY) " & _
            "values(" & _
            Val(txtTuNumber.Text) & "," & _
            Trim(DataGridView1.Item(1, i).Value) & "," & _
            Trim(DataGridView1.Item(0, i).Value) & ", " & _
            "sysdate," & _
            "'" & mUserName & "',sysdate," & _
            "'" & mUserName & "')"

            If Oradb.ExeSQL(strSQL) Then
            Else
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลแป้นเสริมได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            End If
            i = i + 1
        Loop

        Return 0
    End Function

    Public Sub setFrmWork(ByVal n As Integer)
        Me.frm_work = n
    End Sub

    Public Sub setPkId(ByVal id As String)
        Me.pk_id = id
    End Sub

    Private Sub Edit()
        Dim tmpCarrier
        Dim tmpCarr1 As String
        If InStr(1, cbCarrier.Text, "-") = 0 Then
            tmpCarr1 = ""
        Else
            tmpCarrier = Split(cbCarrier.Text, "-")
            tmpCarr1 = tmpCarrier(0)
        End If

        Dim tmpTU_TYPE1

        If InStr(1, cbTruckType.Text, "-") = 0 Then
            tmpTU_TYPE1 = cbTruckType.Text
        Else
            Dim arrTmpTU_TYPE = Split(cbTruckType.Text, "-")
            tmpTU_TYPE1 = arrTmpTU_TYPE(0)
            If tmpTU_TYPE1 = "" Then
                Exit Sub
            End If
        End If


        If InStr(1, cbTruckType.Text, "-") = 0 Then
            tmpTU_TYPE1 = ""
        Else
            If tmpTU_TYPE1 <> "" Then
                Dim arrTmpTU_TYPE = Split(cbTruckType.Text, "-")
                tmpTU_TYPE1 = arrTmpTU_TYPE(0)
            Else
                tmpTU_TYPE1 = 0
            End If
        End If

        Dim strSQL As String = _
        "update TRANSPORT_UNIT T set " & _
        "T.TU_ID='" & Trim(txtTruckName.Text) & "'," & _
        "T.FIX_SEAL='" & Trim(txtSeal.Text) & "',T.UNIT='" & Trim(cbUnit.Text) & "',T.TARE_WEIGHT='" & Trim(txtTareW.Text) & "',T.MAX_LOAD_WEIGHT='" & Trim(TxtMaxLoad.Text) & "'," & _
        "T.NEXT_CAL_DATE=to_date('" & Format(DTPnextCalDate.Value, "dd/MM/yyyy") & "','dd/mm/yyyy')," & _
        "T.IS_ENABLED=" & IIf(OptEnabled.Checked, 1, 0) & "," & _
        "T.COMPARTMENTS=" & Val(cbTotComp.Text) & "," & _
        "T.CARRIER_ID=" & Trim(tmpCarr1) & "," & _
        "T.TU_TYPE=" & Trim(tmpTU_TYPE1) & "," & _
        "T.CAPACITYS=" & Val(txtTruckCapacity.Text) & "," & _
        "T.COMP_1=" & Val(txtCompCap1.Text) & "," & _
        "T.COMP_2=" & Val(txtCompCap2.Text) & "," & _
        "T.COMP_3=" & Val(txtCompCap3.Text) & "," & _
        "T.COMP_4=" & Val(txtCompCap4.Text) & "," & _
        "T.COMP_5=" & Val(txtCompCap5.Text) & "," & _
        "T.COMP_6=" & Val(txtCompCap6.Text) & "," & _
        "T.COMP_7=" & Val(txtCompCap7.Text) & "," & _
        "T.COMP_8=" & Val(txtCompCap8.Text) & "," & _
        "T.COMP_9=" & Val(txtCompCap9.Text) & "," & _
        "T.COMP_10=" & Val(txtCompCap10.Text) & "," & _
        "T.UPDATE_DATE=sysdate," & _
        "T.UPDATED_BY='" & mUserName & "' " & _
        "where T.TU_NUMBER=" & Val(pk_id)

        If Oradb.ExeSQL(strSQL) Then

            AddDataTransportComps()
            AddDataBlackList()
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            'Me.Close()
            'setFrmWork(0)
            'frmMainTransportUnit_main.Show_Data()
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
        "select T.TU_NUMBER,T.TU_ID,T.LAST_CAL_DATE,T.NEXT_CAL_DATE,TARE_WEIGHT,MAX_LOAD_WEIGHT,UNIT,T.IS_ENABLED,T.COMPARTMENTS,T.CAPACITYS," & _
        "T.TU_TYPE ||'-'||tu.description as TU_TYPE," & _
        "T.UPDATE_DATE,T.UPDATED_BY,T.FIX_SEAL, T.CARRIER_ID ||'-'||C.CARRIER_NAME  AS CARRIER, T.COMP_1,T.COMP_2,T.COMP_3,T.COMP_4,T.COMP_5,T.COMP_6,T.COMP_7,T.COMP_8 , T.COMP_9, T.COMP_10" & _
        " from TRANSPORT_UNIT T ,TAS.CARRIER  C, tas.view_tu_type tu" & _
        " where T.CARRIER_ID = C.CARRIER_ID(+)" & _
        " and t.tu_type=tu.status_varchar(+)" & _
        " and  T.TU_NUMBER =" & pk_id

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            txtTuNumber.Text = IIf(IsDBNull(dt.Rows(i).Item("TU_NUMBER")), "", dt.Rows(i).Item("TU_NUMBER").ToString)
            txtTruckName.Text = IIf(IsDBNull(dt.Rows(i).Item("TU_ID")), "", dt.Rows(i).Item("TU_ID").ToString)
            cbCarrier.Text = IIf(IsDBNull(dt.Rows(i).Item("CARRIER")), "", dt.Rows(i).Item("CARRIER").ToString)
            cbTruckType.Text = IIf(IsDBNull(dt.Rows(i).Item("TU_TYPE")), "", dt.Rows(i).Item("TU_TYPE").ToString)
            DTPnextCalDate.Text = IIf(IsDBNull(dt.Rows(i).Item("NEXT_CAL_DATE")), "", dt.Rows(i).Item("NEXT_CAL_DATE").ToString)
            txtSeal.Text = IIf(IsDBNull(dt.Rows(i).Item("FIX_SEAL")), "", dt.Rows(i).Item("FIX_SEAL").ToString)
            txtTareW.Text = IIf(IsDBNull(dt.Rows(i).Item("TARE_WEIGHT")), "", dt.Rows(i).Item("TARE_WEIGHT").ToString)
            TxtMaxLoad.Text = IIf(IsDBNull(dt.Rows(i).Item("MAX_LOAD_WEIGHT")), "", dt.Rows(i).Item("MAX_LOAD_WEIGHT").ToString)
            cbUnit.Text = IIf(IsDBNull(dt.Rows(i).Item("UNIT")), "", dt.Rows(i).Item("UNIT").ToString)
            txtCompCap1.Text = IIf(IsDBNull(dt.Rows(i).Item("COMP_1")), "", dt.Rows(i).Item("COMP_1").ToString)
            txtCompCap2.Text = IIf(IsDBNull(dt.Rows(i).Item("COMP_2")), "", dt.Rows(i).Item("COMP_2").ToString)
            txtCompCap3.Text = IIf(IsDBNull(dt.Rows(i).Item("COMP_3")), "", dt.Rows(i).Item("COMP_3").ToString)
            txtCompCap4.Text = IIf(IsDBNull(dt.Rows(i).Item("COMP_4")), "", dt.Rows(i).Item("COMP_4").ToString)
            txtCompCap5.Text = IIf(IsDBNull(dt.Rows(i).Item("COMP_5")), "", dt.Rows(i).Item("COMP_5").ToString)
            txtCompCap6.Text = IIf(IsDBNull(dt.Rows(i).Item("COMP_6")), "", dt.Rows(i).Item("COMP_6").ToString)
            txtCompCap7.Text = IIf(IsDBNull(dt.Rows(i).Item("COMP_7")), "", dt.Rows(i).Item("COMP_7").ToString)
            txtCompCap8.Text = IIf(IsDBNull(dt.Rows(i).Item("COMP_8")), "", dt.Rows(i).Item("COMP_8").ToString)
            txtCompCap9.Text = IIf(IsDBNull(dt.Rows(i).Item("COMP_9")), "", dt.Rows(i).Item("COMP_9").ToString)
            txtCompCap10.Text = IIf(IsDBNull(dt.Rows(i).Item("COMP_10")), "", dt.Rows(i).Item("COMP_10").ToString)
            cbTotComp.Text = IIf(IsDBNull(dt.Rows(i).Item("COMPARTMENTS")), "", dt.Rows(i).Item("COMPARTMENTS").ToString)
            For i = 1 To IIf(IsDBNull(dt.Rows(i).Item("COMPARTMENTS")), "", dt.Rows(i).Item("COMPARTMENTS").ToString)
                cmbCompartment.Items.Add(i)
            Next i
            i = 0           

            If IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", dt.Rows(i).Item("IS_ENABLED").ToString) = 1 Then
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
        cbTotComp.Items.Clear()
        For i = 0 To 10
            cbTotComp.Items.Add(i)
        Next

        cbUnit.Items.Add("LITRE")
        cbUnit.Items.Add("KG")

        Dim sql_str As String
        sql_str = _
        "select C.CARRIER_ID||'-'||C.CARRIER_NAME   as Carrier  " & _
        "from CARRIER C " & _
        "order by C.CARRIER_NAME"
        assignDropDown(sql_str, "Carrier", cbCarrier)

        sql_str = _
         "select t.status_varchar,t.description,t.status_varchar||'-'||t.description as TU_TYPE1 " & _
         " from status_desc t" & _
         " where t.columns_name='TU_TYPE' " & _
         " order by t.status_varchar"
        '" and t.status_varchar='1' or t.status_varchar='2' or t.status_varchar='3' or t.status_varchar='8' or t.status_varchar='9'" & _

        assignDropDown(sql_str, "TU_TYPE1", cbTruckType)
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
        " select MAX((tu_number)+1) as MaxID from transport_unit"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            txtTuNumber.Text = IIf(IsDBNull(dt.Rows(0).Item("MaxID")), "", dt.Rows(0).Item("MaxID").ToString)
        End If
        Return 1
    End Function

    Private Sub cbTotComp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTotComp.SelectedIndexChanged
        'intitalCbTotComp()
    End Sub

    Sub intitalCbTotComp()
        Dim sumCompCap As Integer = 0
        If cbTotComp.SelectedIndex >= 0 Then
            If cbTotComp.Text >= 1 Then
                txtCompCap1.Text = 3000
                sumCompCap = sumCompCap + txtCompCap1.Text
                txtCompCap1.Enabled = True
            Else
                txtCompCap1.Text = 0
                txtCompCap1.Enabled = False
            End If

            If cbTotComp.Text >= 2 Then
                txtCompCap2.Text = 3000
                sumCompCap = sumCompCap + txtCompCap2.Text
                txtCompCap2.Enabled = True
            Else
                txtCompCap2.Text = 0
                txtCompCap2.Enabled = False
            End If

            If cbTotComp.Text >= 3 Then
                txtCompCap3.Enabled = True
                txtCompCap3.Text = 3000
                sumCompCap = sumCompCap + txtCompCap3.Text
            Else
                txtCompCap3.Text = 0
                txtCompCap3.Enabled = False
            End If

            If cbTotComp.Text >= 4 Then
                txtCompCap4.Enabled = True
                txtCompCap4.Text = 3000
                sumCompCap = sumCompCap + txtCompCap4.Text
            Else
                txtCompCap4.Text = 0
                txtCompCap4.Enabled = False
            End If

            If cbTotComp.Text >= 5 Then
                txtCompCap5.Enabled = True
                txtCompCap5.Text = 3000
                sumCompCap = sumCompCap + txtCompCap5.Text
            Else
                txtCompCap5.Text = 0
                txtCompCap5.Enabled = False
            End If

            If cbTotComp.Text >= 6 Then
                txtCompCap6.Enabled = True
                txtCompCap6.Text = 3000
                sumCompCap = sumCompCap + txtCompCap6.Text
            Else
                txtCompCap6.Text = 0
                txtCompCap6.Enabled = False
            End If

            If cbTotComp.Text >= 7 Then
                txtCompCap7.Enabled = True
                txtCompCap7.Text = 3000
                sumCompCap = sumCompCap + txtCompCap7.Text
            Else
                txtCompCap7.Text = 0
                txtCompCap7.Enabled = False
            End If

            If cbTotComp.Text >= 8 Then
                txtCompCap8.Enabled = True
                txtCompCap8.Text = 3000
                sumCompCap = sumCompCap + txtCompCap8.Text
            Else
                txtCompCap8.Text = 0
                txtCompCap8.Enabled = False
            End If

            If cbTotComp.Text >= 9 Then
                txtCompCap9.Enabled = True
                txtCompCap9.Text = 3000
                sumCompCap = sumCompCap + txtCompCap9.Text
            Else
                txtCompCap9.Text = 0
                txtCompCap9.Enabled = False
            End If

            If cbTotComp.Text >= 10 Then
                txtCompCap10.Enabled = True
                txtCompCap10.Text = 3000
                sumCompCap = sumCompCap + txtCompCap10.Text
            Else
                txtCompCap10.Text = 0
                txtCompCap10.Enabled = False
            End If
            txtTruckCapacity.Text = sumCompCap
            cmbCompartment.Items.Clear()
            If Val(cbTotComp.Text) <> 0 Then
                For i As Integer = 1 To (Val(cbTotComp.Text))
                    cmbCompartment.Items.Add(i)
                Next
            End If
        End If
    End Sub

    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        Dim i
        i = DataGridView1.RowCount
        If txtAddCapacity.Text <> "" And cmbCompartment.Text <> "" Then
            DataGridView1.RowCount = DataGridView1.RowCount + 1
            DataGridView1.Item(0, i).Value = cmbCompartment.Text
            DataGridView1.Item(1, i).Value = txtAddCapacity.Text
        End If
        
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If DataGridView1.RowCount > 0 Then
            Dim index As Integer = DataGridView1.CurrentRow.Index
            DataGridView1.Rows.RemoveAt(index)
        End If
    End Sub

    Private Sub ShowBlackList(ByVal MeterNo As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = _
        " select   t.blacklist_no , t.decription, t.begin_date, t.end_date, t.is_enabled " & _
        " ,t.creation_date,t.created_by  , t.update_date  , t.updated_by ,t.j_computer " & _
        " from  tas.truck_blacklist  t " & _
        " Where t.Tu_id = '" & pk_id & "' " & _
        " order by t.blacklist_no "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView2.RowCount = 0
            Do While dt.Rows.Count > i
                DataGridView2.RowCount = DataGridView2.RowCount + 1
                DataGridView2.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("blacklist_no")), "", dt.Rows(i).Item("blacklist_no").ToString)
                DataGridView2.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("decription")), "", dt.Rows(i).Item("decription").ToString)
                DataGridView2.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("begin_date")), "", dt.Rows(i).Item("begin_date").ToString)
                DataGridView2.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("end_date")), "", dt.Rows(i).Item("end_date").ToString)
                If IIf(IsDBNull(dt.Rows(i).Item("is_enabled")), "", dt.Rows(i).Item("is_enabled").ToString) = 1 Then
                    DataGridView2.Item(4, i).Value = "ใช้งาน"
                Else
                    DataGridView2.Item(4, i).Value = "หยุดใข้งาน"
                End If

                DataGridView2.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("creation_date")), "", dt.Rows(i).Item("creation_date").ToString)
                DataGridView2.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("created_by")), "", dt.Rows(i).Item("created_by").ToString)
                DataGridView2.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("update_date")), "", dt.Rows(i).Item("update_date").ToString)
                DataGridView2.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)

                i = i + 1
            Loop
            txtBackListNo.Text = i + 1
        Else
        End If
        mDataSet = Nothing

    End Sub


    Private Function AddDataBlackList()
        Dim strSQL As String
        strSQL = "delete truck_blacklist where Tu_id ='" & Trim(pk_id) & "'"
        Oradb.ExeSQL(strSQL)

        Dim i As Integer = 0
        strSQL = ""
        Dim temEnable
        Do While DataGridView2.RowCount > i

            If DataGridView2.Item(4, i).Value = "ใช้งาน" Then
                temEnable = 1
            Else
                temEnable = 0
            End If
            strSQL = _
            "insert into truck_blacklist(" & _
            "blacklist_no," & _
            "decription," & _
            "begin_date," & _
            "end_date," & _
            "is_enabled," & _
            "creation_date, " & _
            "created_by," & _
            "update_date," & _
            "updated_by," & _
            "Tu_id " & _
            " )values(" & _
            "'" & DataGridView2.Item(0, i).Value & "'," & _
            "'" & DataGridView2.Item(1, i).Value & "'," & _
            " TO_DATE('" & DataGridView2.Item(2, i).Value & "', 'dd/mm/yyyy hh24:mi:ss')  ," & _
            " TO_DATE('" & DataGridView2.Item(3, i).Value & "', 'dd/mm/yyyy hh24:mi:ss')  ," & _
            "'" & temEnable & "'," & _
            " sysdate " & "," & _
            "'" & DataGridView2.Item(6, i).Value & "'," & _
            " sysdate " & "," & _
             "''," & _
            "'" & Trim(pk_id) & "' )"
            ' MessageBox.Show(strSQL)
            If Oradb.ExeSQL(strSQL) Then
            Else
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            End If
            i = i + 1
        Loop

        Return 0
    End Function

    Private Sub addDataGridBlackList()
        Dim strDateStart = DTPickerStart.Value.ToString.Split(" ")
        Dim dateStart = strDateStart(0)
        Dim strTimeStart = DtpTimeStart.Value.ToString.Split(" ")
        Dim timeStart = strTimeStart(1)
        Dim strDateEnd = dtpStopDate.Value.ToString.Split(" ")
        Dim dateEnd = strDateEnd(0)
        Dim strTimeEnd = dtpTimeStop.Value.ToString.Split(" ")
        Dim timeEnd = strTimeEnd(1)
        Dim i As Integer
    
        i = DataGridView2.RowCount
        DataGridView2.RowCount = DataGridView2.RowCount + 1
        DataGridView2.Item(0, i).Value = txtBackListNo.Text
        DataGridView2.Item(1, i).Value = txtDesc.Text
        DataGridView2.Item(2, i).Value = dateStart & " " & timeStart
        DataGridView2.Item(3, i).Value = dateEnd & " " & timeEnd
        If OptIsEnBlackList.Checked Then
            DataGridView2.Item(4, i).Value = "ใช้งาน"
        Else
            DataGridView2.Item(4, i).Value = "หยุดใข้งาน"
        End If
        DataGridView2.Item(5, i).Value = Date.Now
        DataGridView2.Item(6, i).Value = mUserName
        DataGridView2.Item(7, i).Value = Date.Now
        DataGridView2.Item(8, i).Value = ""
    End Sub

    Private Sub cmdAddBlackL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddBlackL.Click
        addDataGridBlackList()
        txtBackListNo.Text = txtBackListNo.Text + 1
    End Sub

    Private Sub DataGridView2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView2.Click
        Dim index As Integer = DataGridView2.CurrentRow.Index
        txtBackListNo.Text = DataGridView2.Rows(index).Cells(0).Value.ToString
        txtDesc.Text = DataGridView2.Rows(index).Cells(1).Value.ToString
        DTPickerStart.Text = DataGridView2.Rows(index).Cells(2).Value.ToString
        dtpStopDate.Text = DataGridView2.Rows(index).Cells(3).Value.ToString
        DtpTimeStart.Text = DataGridView2.Rows(index).Cells(2).Value.ToString
        dtpTimeStop.Text = DataGridView2.Rows(index).Cells(3).Value.ToString

        If DataGridView2.Rows(index).Cells(4).Value = "ใช้งาน" Then
            OptIsEnBlackList.Checked = True
        Else
            OptIsUnEnBlackList.Checked = True
        End If
    End Sub

    Private Sub txtTareW_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTareW.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("กรุณากรอกค่าเป็นตัวเลข", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Select
    End Sub

    Private Sub btTruckType_Click(sender As Object, e As EventArgs) Handles btTruckType.Click
        frmMainTransportUnit_VehicleType.Close()
        frmMainTransportUnit_VehicleType.ShowDialog()
    End Sub

    Private Sub txtCompCap1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompCap1.KeyPress
        CheckNumeric(e)
    End Sub
    Private Sub CheckNumeric(ByRef e)
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("กรุณากรอกค่าเป็นตัวเลข", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Select
    End Sub

    Private Sub txtCompCap2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompCap2.KeyPress
        CheckNumeric(e)
    End Sub

    Private Sub txtCompCap3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompCap3.KeyPress
        CheckNumeric(e)
    End Sub

    Private Sub txtCompCap4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompCap4.KeyPress
        CheckNumeric(e)
    End Sub

    Private Sub txtCompCap5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompCap5.KeyPress
        CheckNumeric(e)
    End Sub

    Private Sub txtSeal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSeal.KeyPress
        CheckNumeric(e)
    End Sub

    Private Sub txtCompCap6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompCap6.KeyPress
        CheckNumeric(e)
    End Sub

    Private Sub txtCompCap7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompCap7.KeyPress
        CheckNumeric(e)
    End Sub
    Private Sub txtCompCap8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompCap8.KeyPress
        CheckNumeric(e)
    End Sub
    Private Sub txtCompCap9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompCap9.KeyPress
        CheckNumeric(e)
    End Sub
    Private Sub txtCompCap10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompCap10.KeyPress
        CheckNumeric(e)
    End Sub
    Private Sub CalTruckCapacity()

        txtTruckCapacity.Text = ""
        txtTruckCapacity.Text = Val(txtCompCap1.Text) + Val(txtCompCap2.Text) + Val(txtCompCap3.Text) + Val(txtCompCap4.Text) + Val(txtCompCap5.Text)
        txtTruckCapacity.Text = Val(txtTruckCapacity.Text) + (Val(txtCompCap6.Text) + Val(txtCompCap7.Text) + Val(txtCompCap8.Text) + Val(txtCompCap9.Text) + Val(txtCompCap10.Text))
    End Sub

  
    Private Sub cbTotComp_Click(sender As Object, e As EventArgs) Handles cbTotComp.Click
        'intitalCbTotComp()
    End Sub

    Private Sub cbTotComp_TextChanged(sender As Object, e As EventArgs) Handles cbTotComp.TextChanged
        intitalCbTotComp()
    End Sub

    Private Sub txtCompCap1_TextChanged(sender As Object, e As EventArgs) Handles txtCompCap1.TextChanged
        CalTruckCapacity()
    End Sub
    Private Sub txtCompCap2_TextChanged(sender As Object, e As EventArgs) Handles txtCompCap1.TextChanged, txtCompCap2.TextChanged
        CalTruckCapacity()
    End Sub
    Private Sub txtCompCap3_TextChanged(sender As Object, e As EventArgs) Handles txtCompCap1.TextChanged, txtCompCap3.TextChanged
        CalTruckCapacity()
    End Sub
    Private Sub txtCompCap4_TextChanged(sender As Object, e As EventArgs) Handles txtCompCap1.TextChanged, txtCompCap4.TextChanged
        CalTruckCapacity()
    End Sub
    Private Sub txtCompCap5_TextChanged(sender As Object, e As EventArgs) Handles txtCompCap1.TextChanged, txtCompCap5.TextChanged
        CalTruckCapacity()
    End Sub
    Private Sub txtCompCap6_TextChanged(sender As Object, e As EventArgs) Handles txtCompCap1.TextChanged, txtCompCap6.TextChanged
        CalTruckCapacity()
    End Sub
    Private Sub txtCompCap7_TextChanged(sender As Object, e As EventArgs) Handles txtCompCap1.TextChanged, txtCompCap7.TextChanged
        CalTruckCapacity()
    End Sub
    Private Sub txtCompCap8_TextChanged(sender As Object, e As EventArgs) Handles txtCompCap1.TextChanged, txtCompCap8.TextChanged
        CalTruckCapacity()
    End Sub
    Private Sub txtCompCap9_TextChanged(sender As Object, e As EventArgs) Handles txtCompCap1.TextChanged, txtCompCap9.TextChanged
        CalTruckCapacity()
    End Sub
    Private Sub txtCompCap10_TextChanged(sender As Object, e As EventArgs) Handles txtCompCap1.TextChanged, txtCompCap10.TextChanged
        CalTruckCapacity()
    End Sub

    Private Sub cbTruckType_Click(sender As Object, e As EventArgs) Handles cbTruckType.Click
        cbTruckType.Items.Clear()
        assignDropDown()
    End Sub

    Private Sub cbTotComp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbTotComp.KeyPress
        CheckNumeric(e)
    End Sub

    Private Sub cmbCompartment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCompartment.KeyPress
        CheckNumeric(e)
    End Sub

    Private Sub txtAddCapacity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddCapacity.KeyPress
        CheckNumeric(e)
    End Sub
End Class




