Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmConfigTank_sub
    Dim frm_work As Integer = 0 '1=add ,2=Edit
    Dim pk_id As String = ""

    Private Sub frmConfigTank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        If frm_work = 1 Then
            Me.Text = "Tank # Add"
            GetNextID()
        ElseIf frm_work = 2 Then
            Me.Text = "Tank # Edit"
            AssignValue()
        End If
        txtLock(True)
    End Sub

    Private Sub Clear_frm()
        txtCoqNo.Text = ""
        txtTankCapacity.Text = "0"
        cbTankType.Text = ""
        txtTankID.Text = ""
        txtTankName.Text = ""
        cbProduct.Text = ""
        cbTankMapping.Text = ""
        txtTankHigh.Text = "0"
        txtTemp.Text = "0"
        txtDen15c.Text = "0"
        txtLevel.Text = "0"
        txtGross.Text = "0"
        txtNet.Text = "0"
        txtAvariable.Text = "0"
        txtRoom.Text = "0"
        txtwia.Text = "0"
        txtfwl.Text = "0"
        txtOtankHigh.Text = "0"
        txtOTemp.Text = "0"
        txtOADEN15C.Text = "0"
        txtOLevel.Text = "0"
        txtOGross.Text = "0"
        txtOnet.Text = "0"
        txtOAvariable.Text = "0"
        txtORoom.Text = "0"
        txtOwia.Text = "0"
        txtOfwl.Text = "0"
        txtOAPI60F.Text = "0"
        txtAPI60F.Text = "0"
        txtHighHigh.Text = "0"
        txtHigh.Text = "0"
        txtLow.Text = "0"
        txtLowLow.Text = "0"
        cbOTankHigh.Items.Clear()
        cbOAPI60F.Items.Clear()
        cbfwl.Items.Clear()
        cbwia.Items.Clear()
        cbORoom.Items.Clear()
        cbOAvariable.Items.Clear()
        cbONet.Items.Clear()
        cbOGross.Items.Clear()
        cbOLevel.Items.Clear()
        cbOTemp.Items.Clear()
        CmbODen15c.Items.Clear()
        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""
        OptEnabled.Checked = True
    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)

    End Sub


#Region "Menu Event"
    Private Sub UcSave2_OnClickSave(ByVal ucName As System.String) Handles UcSave2.OnClickSave
        If frm_work = 1 Then 'Add
            If txtTankID.Text.Trim = "" Or cbTankMapping.Text.Trim = "" Or cbProduct.Text.Trim = "" Or cmbTankCal.Text.Trim = "" Or cbTankType.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If txtTankID.Text.Trim = "" Or cbTankMapping.Text.Trim = "" Or cbProduct.Text.Trim = "" Or cmbTankCal.Text.Trim = "" Or cbTankType.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Edit()
            End If
        End If
    End Sub

    Private Sub UcCancel2_OnClickCancel(ByVal ucName As System.String) Handles UcCancel2.OnClickCancel
        Me.Close()
        'Initial_frm()
    End Sub

#End Region

    Private Sub Save()
        cbMapTankType.SelectedIndex = cbTankType.FindString(cbTankType.Text)
        Dim strSQL As String = ""
        strSQL = strSQL & _
        "insert into TANK(" & _
        "TANK_ID,TANK_NAME,COQ_NO," & _
        "MAPPING_ID,BASE_PRODUCT," & _
        "TANK_TYPE," & _
        "TANK_HIGH,TANK_CAPACITY," & _
        "LEVEL_LL,LEVEL_L," & _
        "LEVEL_H,LEVEL_HH," & _
        "READ_TEMP,TEMP_OVERRIDE," & _
        "READ_API60F,API60F_OVERRIDE," & _
        "READ_LEVELS,LEVELS_OVERRIDE," & _
        "READ_GROSS,GROSS_OVERRIDE," & _
        "READ_DEN15C,DEN15C_OVERRIDE," & _
        "READ_NET,NET_OVERRIDE," & _
        "READ_AVARIABLE,AVARIABLE_OVERRIDE," & _
        "READ_ROOM,ROOM_OVERIDE," & _
        "READ_WIA,WIA_OVERRIDE," & _
        "READ_FWL,FWL_OVERRIDE," & _
        "READ_TANK_HIGH," & _
        "IS_ENABLED," & _
        "CREATION_DATE,CREATED_BY," & _
        "UPDATE_DATE,UPDATED_BY," & _
        "TABLE_CAL, COQ_DATE ) "
        strSQL = strSQL & "values("
        strSQL = strSQL & txtTankID.Text & ",'" & Trim(txtTankName.Text) & "','" & Trim(txtCoqNo.Text) & "',"
        strSQL = strSQL & "" & cbTankMapping.Text & ",'" & Trim(cbProduct.Text) & "',"
        strSQL = strSQL & "'" & cbMapTankType.Text & "',"
        strSQL = strSQL & txtOtankHigh.Text & "," & txtTankCapacity.Text & ","
        strSQL = strSQL & txtLowLow.Text & "," & txtLow.Text & ","
        strSQL = strSQL & txtHigh.Text & "," & txtHighHigh.Text & ","
        strSQL = strSQL & cbOTemp.FindString(cbOTemp.Text) & "," & txtOTemp.Text & ","
        strSQL = strSQL & cbOTemp.FindString(cbOAPI60F.Text) & "," & txtOAPI60F.Text & ","
        strSQL = strSQL & cbOLevel.FindString(cbOLevel.Text) & "," & txtOLevel.Text & ","
        strSQL = strSQL & cbOGross.FindString(cbOGross.Text) & "," & txtOGross.Text & ","
        strSQL = strSQL & CmbODen15c.FindString(CmbODen15c.Text) & "," & Trim((txtOADEN15C.Text) * 1000) & ","
        strSQL = strSQL & cbONet.FindString(cbONet.Text) & "," & txtOnet.Text & ","
        strSQL = strSQL & cbOAvariable.FindString(cbOAvariable.Text) & "," & Val(txtOAvariable.Text) & ","
        strSQL = strSQL & cbORoom.FindString(cbORoom.Text) & "," & txtORoom.Text & ","
        strSQL = strSQL & cbwia.FindString(cbwia.Text) & "," & Val(txtOwia.Text) & ","
        strSQL = strSQL & cbfwl.FindString(cbfwl.Text) & "," & txtOfwl.Text & ","
        strSQL = strSQL & cbOTankHigh.FindString(cbOTankHigh.Text) & ","
        strSQL = strSQL & IIf(OptUnEnbled.Checked = True, 1, 0) & ","
        strSQL = strSQL & "sysdate,'" & mUserName & "',"
        strSQL = strSQL & "sysdate,'" & mUserName & "',"
        strSQL = strSQL & "'" & Trim(cmbTankCal.Text) & "',"
        strSQL = strSQL & "to_date('" & COQ_DATE.Value.ToString("dd/MM/yyyy") & "','dd/mm/yyyy') )"
        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigTank_main.Show_Data()
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
        cbMapTankType.SelectedIndex = cbTankType.FindString(cbTankType.Text)
        Dim strSQL As String = ""
        strSQL = strSQL & "update TANK T set "
        strSQL = strSQL & "T.TANK_NAME='" & Trim(txtTankName.Text) & "',"
        strSQL = strSQL & "T.COQ_NO='" & Trim(txtCoqNo.Text) & "',"
        strSQL = strSQL & "T.MAPPING_ID=" & Val(cbTankMapping.Text) & ","
        strSQL = strSQL & "T.BASE_PRODUCT='" & Trim(cbProduct.Text) & "',"
        strSQL = strSQL & "T.TANK_TYPE='" & cbMapTankType.Text & "',"
        strSQL = strSQL & "T.READ_TANK_HIGH = " & cbOTankHigh.FindString(cbOTankHigh.Text) & ","
        strSQL = strSQL & "T.TANK_HIGH=" & txtOtankHigh.Text & ","
        strSQL = strSQL & "T.TANK_CAPACITY=" & txtTankCapacity.Text & ","
        strSQL = strSQL & "T.LEVEL_LL=" & txtLowLow.Text & ","
        strSQL = strSQL & "T.LEVEL_L=" & txtLow.Text & ","
        strSQL = strSQL & "T.LEVEL_H =" & txtHigh.Text & ","
        strSQL = strSQL & "T.LEVEL_HH=" & txtHighHigh.Text & ","
        strSQL = strSQL & "T.READ_WIA=" & cbwia.FindString(cbwia.Text) & ","
        strSQL = strSQL & "T.WIA_OVERRIDE=" & txtOwia.Text & ","
        strSQL = strSQL & "T.READ_FWL=" & cbfwl.FindString(cbfwl.Text) & ","
        strSQL = strSQL & "T.FWL_OVERRIDE=" & txtOfwl.Text & ","
        strSQL = strSQL & "T.READ_TEMP=" & cbOTemp.FindString(cbOTemp.Text) & ","
        strSQL = strSQL & "T.TEMP_OVERRIDE=" & txtOTemp.Text & ","
        strSQL = strSQL & "T.READ_API60F=" & cbOAPI60F.FindString(cbOAPI60F.Text) & ","
        strSQL = strSQL & "T.API60F_OVERRIDE=" & txtOAPI60F.Text & ","
        strSQL = strSQL & "T.READ_LEVELS=" & cbOLevel.FindString(cbOLevel.Text) & ","
        strSQL = strSQL & "T.LEVELS_OVERRIDE=" & txtOLevel.Text & ","
        strSQL = strSQL & "T.READ_GROSS=" & cbOGross.FindString(cbOGross.Text) & ","
        strSQL = strSQL & "T.GROSS_OVERRIDE=" & txtOGross.Text & ","
        strSQL = strSQL & "T.READ_DEN15C=" & CmbODen15c.FindString(CmbODen15c.Text) & ","
        strSQL = strSQL & "T.DEN15C_OVERRIDE=" & Trim(txtOADEN15C.Text * 1000) & ","
        strSQL = strSQL & "T.READ_NET=" & cbONet.FindString(cbONet.Text) & ","
        strSQL = strSQL & "T.NET_OVERRIDE=" & txtOnet.Text & ","
        strSQL = strSQL & "T.READ_AVARIABLE=" & cbOAvariable.FindString(cbOAvariable.Text) & ","
        strSQL = strSQL & "T.AVARIABLE_OVERRIDE=" & txtOAvariable.Text & ","
        strSQL = strSQL & "T.READ_ROOM=" & cbORoom.FindString(cbORoom.Text) & ","
        strSQL = strSQL & "T.ROOM_OVERIDE=" & txtORoom.Text & ","
        strSQL = strSQL & "T.IS_ENABLED=" & IIf(OptEnabled.Checked = True, 1, 0) & ","
        strSQL = strSQL & "T.UPDATE_DATE=sysdate,"
        strSQL = strSQL & "T.UPDATED_BY='" & mUserName & "',"
        strSQL = strSQL & "T.J_COMPUTER='" & mUserName & "',"
        strSQL = strSQL & "T.TABLE_CAL ='" & Trim(cmbTankCal.Text) & "', "
        strSQL = strSQL & "T.COQ_DATE =to_date('" & COQ_DATE.Value.ToString("dd/MM/yyyy") & "','dd/mm/yyyy') "
        strSQL = strSQL & "where T.TANK_ID= '" & Val(txtTankID.Text) & "'"

        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigTank_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
    End Sub

    Private Sub AssignValue()
        Dim dt As DataTable
        Dim sql_str As String
        Dim mDataSet As New DataSet
        sql_str = _
        "select T.TANK_ID,T.TANK_NAME,T.COQ_NO,T.BASE_PRODUCT,T.TANK_TYPE,T.MAPPING_ID,T.TABLE_CAL ," & _
        "T.TANK_HIGH_OVERRIDE,T.TANK_CAPACITY_OVERRIDE,T.LEVEL_LL,T.LEVEL_L,T.LEVEL_H,T.LEVEL_HH," & _
        "T.READ_LEVELS,T.LEVELS_OVERRIDE,T.LEVELS,T.READ_GROSS,T.GROSS_OVERRIDE,T.GROSS," & _
        "T.READ_NET,T.NET_OVERRIDE,T.NET,T.READ_AVARIABLE,T.AVARIABLE_OVERRIDE,T.AVARIABLE," & _
        "T.READ_ROOM,T.ROOM_OVERIDE,T.ROOM,T.READ_DEN15C , T.DEN15C_OVERRIDE , T.DEN15C ," & _
        "T.READ_TEMP,T.TEMP_OVERRIDE,T.TEMP,T.READ_API60F,T.API60F_OVERRIDE,T.API_60F," & _
        "T.READ_TANK_HIGH,T.TANK_HIGH_OVERRIDE,T.TANK_HIGH," & _
        "T.READ_WIA,T.WIA_OVERRIDE,T.WIA,T.READ_FWL,T.FWL_OVERRIDE,T.FWL," & _
        "T.IS_ENABLED,T.SOC_EVENT,T.UPDATE_DATE, T.UPDATED_BY, T.COQ_DATE " & _
        "from VIEW_MAP_TANK_ALL T " & _
        "where T.TANK_ID=" & pk_id & " " & _
        "order by T.TANK_ID "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Dim i As Integer = 0

            txtTankID.Text = IIf(IsDBNull(dt.Rows(i).Item("TANK_ID")), "", dt.Rows(i).Item("TANK_ID").ToString)
            txtTankName.Text = IIf(IsDBNull(dt.Rows(i).Item("TANK_NAME")), "", dt.Rows(i).Item("TANK_NAME").ToString)
            cbProduct.Text = IIf(IsDBNull(dt.Rows(i).Item("BASE_PRODUCT")), "", dt.Rows(i).Item("BASE_PRODUCT").ToString)
            setListboxWithName(IIf(IsDBNull(dt.Rows(i).Item("TANK_TYPE")), "", dt.Rows(i).Item("TANK_TYPE").ToString), cbTankType)
            txtCoqNo.Text = IIf(IsDBNull(dt.Rows(i).Item("COQ_NO")), "", dt.Rows(i).Item("COQ_NO").ToString)
            Console.WriteLine(dt.Rows(i).Item("COQ_DATE").ToString)
            If dt.Rows(i).Item("COQ_DATE").ToString.Equals("") Then
                COQ_DATE.Value = Date.Now
            Else
                COQ_DATE.Value = Date.ParseExact(dt.Rows(i).Item("COQ_DATE").ToString, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo, Globalization.DateTimeStyles.None)
            End If
            

            Dim strTankType As String = IIf(IsDBNull(dt.Rows(i).Item("TANK_TYPE")), "", dt.Rows(i).Item("TANK_TYPE").ToString)
            cbTankType.SelectedIndex = cbMapTankType.FindString(strTankType)
            setListboxWithName(IIf(IsDBNull(dt.Rows(i).Item("MAPPING_ID")), "", dt.Rows(i).Item("MAPPING_ID").ToString), cbTankMapping)
            cbOTankHigh.Text = IIf(IsDBNull(dt.Rows(i).Item("READ_TANK_HIGH")), "", IIf(dt.Rows(i).Item("READ_TANK_HIGH").ToString = 0, "ATG", "Override"))
            txtOtankHigh.Text = IIf(IsDBNull(dt.Rows(i).Item("TANK_HIGH_OVERRIDE")), "", dt.Rows(i).Item("TANK_HIGH_OVERRIDE").ToString)
            txtTankHigh.Text = IIf(IsDBNull(dt.Rows(i).Item("TANK_HIGH")), "", dt.Rows(i).Item("TANK_HIGH").ToString)
            txtTankCapacity.Text = IIf(IsDBNull(dt.Rows(i).Item("TANK_CAPACITY_OVERRIDE")), "", dt.Rows(i).Item("TANK_CAPACITY_OVERRIDE").ToString)
            txtLowLow.Text = IIf(IsDBNull(dt.Rows(i).Item("LEVEL_LL")), "", dt.Rows(i).Item("LEVEL_LL").ToString)
            txtLow.Text = IIf(IsDBNull(dt.Rows(i).Item("LEVEL_L")), "", dt.Rows(i).Item("LEVEL_L").ToString)
            txtHigh.Text = IIf(IsDBNull(dt.Rows(i).Item("LEVEL_H")), "", dt.Rows(i).Item("LEVEL_H").ToString)
            txtHighHigh.Text = IIf(IsDBNull(dt.Rows(i).Item("LEVEL_HH")), "", dt.Rows(i).Item("LEVEL_HH").ToString)
            CmbODen15c.Text = IIf(IsDBNull(dt.Rows(i).Item("READ_DEN15C")), "", IIf(dt.Rows(i).Item("READ_DEN15C").ToString = 0, "ATG", "Override"))
            txtOADEN15C.Text = (IIf(IsDBNull(dt.Rows(i).Item("DEN15C_OVERRIDE")), "", dt.Rows(i).Item("DEN15C_OVERRIDE").ToString) / 1000)
            txtDen15c.Text = IIf(IsDBNull(dt.Rows(i).Item("DEN15C")), "", dt.Rows(i).Item("DEN15C").ToString)
            cmbTankCal.Text = IIf(IsDBNull(dt.Rows(i).Item("TABLE_CAL")), "", dt.Rows(i).Item("TABLE_CAL").ToString)
            cbOTemp.Text = IIf(IsDBNull(dt.Rows(i).Item("READ_TEMP")), "", IIf(dt.Rows(i).Item("READ_TEMP").ToString = 0, "ATG", "Override"))
            txtOTemp.Text = IIf(IsDBNull(dt.Rows(i).Item("TEMP_OVERRIDE")), "", dt.Rows(i).Item("TEMP_OVERRIDE").ToString)
            txtTemp.Text = IIf(IsDBNull(dt.Rows(i).Item("TEMP")), "", dt.Rows(i).Item("TEMP").ToString)
            cbOAPI60F.Text = IIf(IsDBNull(dt.Rows(i).Item("READ_API60F")), "", IIf(dt.Rows(i).Item("READ_API60F").ToString = 0, "ATG", "Override"))
            txtOAPI60F.Text = IIf(IsDBNull(dt.Rows(i).Item("API60F_OVERRIDE")), "", dt.Rows(i).Item("API60F_OVERRIDE").ToString)
            txtAPI60F.Text = IIf(IsDBNull(dt.Rows(i).Item("API_60F")), "", dt.Rows(i).Item("API_60F").ToString)
            cbOLevel.Text = IIf(IsDBNull(dt.Rows(i).Item("READ_LEVELS")), "", IIf(dt.Rows(i).Item("READ_LEVELS").ToString = 0, "ATG", "Override"))
            txtOLevel.Text = IIf(IsDBNull(dt.Rows(i).Item("LEVELS_OVERRIDE")), "", dt.Rows(i).Item("LEVELS_OVERRIDE").ToString)
            txtLevel.Text = IIf(IsDBNull(dt.Rows(i).Item("LEVELS")), "", dt.Rows(i).Item("LEVELS").ToString)
            cbOGross.Text = IIf(IsDBNull(dt.Rows(i).Item("READ_GROSS")), "", IIf(dt.Rows(i).Item("READ_GROSS").ToString = 0, "ATG", "Override"))
            txtOGross.Text = IIf(IsDBNull(dt.Rows(i).Item("GROSS_OVERRIDE")), "", dt.Rows(i).Item("GROSS_OVERRIDE").ToString)
            txtGross.Text = IIf(IsDBNull(dt.Rows(i).Item("GROSS")), "", dt.Rows(i).Item("GROSS").ToString)
            cbONet.Text = IIf(IsDBNull(dt.Rows(i).Item("READ_NET")), "", IIf(dt.Rows(i).Item("READ_NET").ToString = 0, "ATG", "Override"))
            txtOnet.Text = IIf(IsDBNull(dt.Rows(i).Item("NET_OVERRIDE")), "", dt.Rows(i).Item("NET_OVERRIDE").ToString)
            txtNet.Text = IIf(IsDBNull(dt.Rows(i).Item("NET")), "", dt.Rows(i).Item("NET").ToString)
            cbOAvariable.Text = IIf(IsDBNull(dt.Rows(i).Item("READ_AVARIABLE")), "", IIf(dt.Rows(i).Item("READ_AVARIABLE").ToString = 0, "ATG", "Override"))
            txtOAvariable.Text = IIf(IsDBNull(dt.Rows(i).Item("AVARIABLE_OVERRIDE")), "", dt.Rows(i).Item("AVARIABLE_OVERRIDE").ToString)
            txtAvariable.Text = IIf(IsDBNull(dt.Rows(i).Item("AVARIABLE")), "", dt.Rows(i).Item("AVARIABLE").ToString)
            cbORoom.Text = IIf(IsDBNull(dt.Rows(i).Item("READ_ROOM")), "", IIf(dt.Rows(i).Item("READ_ROOM").ToString = 0, "ATG", "Override"))
            txtORoom.Text = IIf(IsDBNull(dt.Rows(i).Item("ROOM_OVERIDE")), "", dt.Rows(i).Item("ROOM_OVERIDE").ToString)
            txtRoom.Text = IIf(IsDBNull(dt.Rows(i).Item("ROOM")), "", dt.Rows(i).Item("ROOM").ToString)
            cbwia.Text = IIf(IsDBNull(dt.Rows(i).Item("READ_WIA")), "", IIf(dt.Rows(i).Item("READ_WIA").ToString = 0, "ATG", "Override"))
            txtOwia.Text = IIf(IsDBNull(dt.Rows(i).Item("WIA_OVERRIDE")), "", dt.Rows(i).Item("WIA_OVERRIDE").ToString)
            txtwia.Text = IIf(IsDBNull(dt.Rows(i).Item("WIA")), "", dt.Rows(i).Item("WIA").ToString)
            cbfwl.Text = IIf(IsDBNull(dt.Rows(i).Item("READ_FWL")), "", IIf(dt.Rows(i).Item("READ_FWL").ToString = 0, "ATG", "Override"))
            txtOfwl.Text = IIf(IsDBNull(dt.Rows(i).Item("FWL_OVERRIDE")), "", dt.Rows(i).Item("FWL_OVERRIDE").ToString)
            txtfwl.Text = IIf(IsDBNull(dt.Rows(i).Item("FWL")), "", dt.Rows(i).Item("FWL").ToString)
            If IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", dt.Rows(i).Item("IS_ENABLED").ToString) = 0 Then
                OptUnEnbled.Checked = True
            ElseIf IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", dt.Rows(i).Item("IS_ENABLED").ToString) = 1 Then
                OptEnabled.Checked = True
            Else
                OptUnEnbled.Checked = True
            End If
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

    Function assignATGOverride(ByVal cb As System.Object) As Boolean
        cb.Items.Add("ATG")
        cb.Items.Add("Override")
        Return True
    End Function

    Function assignDropDown() As Boolean
        assignATGOverride(cbOAPI60F)
        assignATGOverride(cbOTankHigh)
        assignATGOverride(cbfwl)
        assignATGOverride(cbwia)
        assignATGOverride(cbORoom)
        assignATGOverride(cbOAvariable)
        assignATGOverride(cbONet)
        assignATGOverride(cbOGross)
        assignATGOverride(cbOLevel)
        assignATGOverride(cbOTemp)
        assignATGOverride(CmbODen15c)
        cbOTankHigh.SelectedIndex = 0
        cbOAPI60F.SelectedIndex = 0
        cbfwl.SelectedIndex = 0
        cbwia.SelectedIndex = 0
        cbORoom.SelectedIndex = 0
        cbOAvariable.SelectedIndex = 0
        cbONet.SelectedIndex = 0
        cbOGross.SelectedIndex = 0
        cbOLevel.SelectedIndex = 0
        cbOTemp.SelectedIndex = 0
        CmbODen15c.SelectedIndex = 0

        Dim sql_str As String
        sql_str = _
        "select S.STATUS_VARCHAR,S.DESCRIPTION " & _
        "from STATUS_DESC S " & _
        "where S.T_NAME='TANK' and S.COLUMNS_NAME='TANK_TYPE' " & _
        "order by S.DESCRIPTION"
        assignDropDown(sql_str, "DESCRIPTION", cbTankType)
        assignDropDown(sql_str, "STATUS_VARCHAR", cbMapTankType)

        sql_str = _
        "select P.BASE_PRODUCT_ID " & _
        "from BASE_PRODUCT P " & _
        "order by P.BASE_PRODUCT_ID"
        assignDropDown(sql_str, "BASE_PRODUCT_ID", cbProduct)

        sql_str = _
        "select M.TANK_ID " & _
        "from TANK_MAPPING M " & _
        "order by M.TANK_ID"
        assignDropDown(sql_str, "TANK_ID", cbTankMapping)

        sql_str = _
        " select  t.TYPE_ID , t.TYPE_NAME  from tas.v_tank_table_cal t  order by t.TYPE_ID "
        assignDropDown(sql_str, "TYPE_NAME", cmbTankCal)

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
        " select MAX((TANK_ID)+1) as MaxID from TANK"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            txtTankID.Text = IIf(IsDBNull(dt.Rows(0).Item("MaxID")), "", dt.Rows(0).Item("MaxID").ToString)
        End If
        mDataSet = Nothing
        dt = Nothing
        Return 1
    End Function

    Private Sub txtOTankHigh_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOtankHigh.KeyPress
        e.Handled = CurrencyOnly(txtOTankHigh, e.KeyChar)
    End Sub
    Private Sub txtOTemp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOTemp.KeyPress
        e.Handled = CurrencyOnly(txtOTemp, e.KeyChar)
    End Sub
    Private Sub txtOADen15c_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOADEN15C.KeyPress
        e.Handled = CurrencyOnly(txtOADEN15C, e.KeyChar)
    End Sub
    Private Sub txtOLevel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOLevel.KeyPress
        e.Handled = CurrencyOnly(txtOLevel, e.KeyChar)
    End Sub
    Private Sub txtOGross_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOGross.KeyPress
        e.Handled = CurrencyOnly(txtOGross, e.KeyChar)
    End Sub
    Private Sub txtONet_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOnet.KeyPress
        e.Handled = CurrencyOnly(txtONet, e.KeyChar)
    End Sub
    Private Sub txtOAvariable_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOAvariable.KeyPress
        e.Handled = CurrencyOnly(txtOAvariable, e.KeyChar)
    End Sub
    Private Sub txtORoom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtORoom.KeyPress
        e.Handled = CurrencyOnly(txtORoom, e.KeyChar)
    End Sub
    Private Sub txtOwia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOwia.KeyPress
        e.Handled = CurrencyOnly(txtOwia, e.KeyChar)
    End Sub
    Private Sub txtHighHigh_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHighHigh.KeyPress
        e.Handled = CurrencyOnly(txtHighHigh, e.KeyChar)
    End Sub
    Private Sub txtHigh_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHigh.KeyPress
        e.Handled = CurrencyOnly(txtHigh, e.KeyChar)
    End Sub
    Private Sub txtLow_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLow.KeyPress
        e.Handled = CurrencyOnly(txtLow, e.KeyChar)
    End Sub
    Private Sub txtLowLow_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLowLow.KeyPress
        e.Handled = CurrencyOnly(txtLowLow, e.KeyChar)
    End Sub
    Private Sub txtAPI60F_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAPI60F.KeyPress
        e.Handled = CurrencyOnly(txtAPI60F, e.KeyChar)
    End Sub
    Private Sub txtOAPI60F_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOAPI60F.KeyPress
        e.Handled = CurrencyOnly(txtOAPI60F, e.KeyChar)
    End Sub
    Private Sub txtTankCapacity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTankCapacity.KeyPress
        e.Handled = CurrencyOnly(txtTankCapacity, e.KeyChar)
    End Sub
    Private Sub txtOfwl_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOfwl.KeyPress
        e.Handled = CurrencyOnly(txtOfwl, e.KeyChar)
    End Sub

    Private Sub cbOTankHigh_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbOTankHigh.SelectedIndexChanged
        If cbOTankHigh.Text = "ATG" Then
            txtOtankHigh.Enabled = False
        Else
            txtOtankHigh.Enabled = True
        End If
    End Sub

    Private Sub cbOTemp_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbOTemp.SelectedIndexChanged
        If cbOTemp.Text = "ATG" Then
            txtOTemp.Enabled = False
        Else
            txtOTemp.Enabled = True
        End If
    End Sub

    Private Sub CmbODen15c_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbODen15c.SelectedIndexChanged
        If CmbODen15c.Text = "ATG" Then
            txtOADEN15C.Enabled = False
        Else
            txtOADEN15C.Enabled = True
        End If
    End Sub

    Private Sub cbOLevel_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbOLevel.SelectedIndexChanged
        If cbOLevel.Text = "ATG" Then
            txtOLevel.Enabled = False
        Else
            txtOLevel.Enabled = True
        End If
    End Sub

    Private Sub cbOGross_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbOGross.SelectedIndexChanged
        If cbOGross.Text = "ATG" Then
            txtOGross.Enabled = False
        Else
            txtOGross.Enabled = True
        End If
    End Sub

    Private Sub cbONet_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbONet.SelectedIndexChanged
        If cbONet.Text = "ATG" Then
            txtOnet.Enabled = False
        Else
            txtOnet.Enabled = True
        End If
    End Sub

    Private Sub cbOAvariable_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbOAvariable.SelectedIndexChanged
        If cbOAvariable.Text = "ATG" Then
            txtOAvariable.Enabled = False
        Else
            txtOAvariable.Enabled = True
        End If
    End Sub

    Private Sub cbORoom_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbORoom.SelectedIndexChanged
        If cbORoom.Text = "ATG" Then
            txtORoom.Enabled = False
        Else
            txtORoom.Enabled = True
        End If
    End Sub

    Private Sub cbwia_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbwia.SelectedIndexChanged
        If cbwia.Text = "ATG" Then
            txtOwia.Enabled = False
        Else
            txtOwia.Enabled = True
        End If
    End Sub

    Private Sub cbfwl_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbfwl.SelectedIndexChanged
        If cbfwl.Text = "ATG" Then
            txtOfwl.Enabled = False
        Else
            txtOfwl.Enabled = True
        End If
    End Sub
End Class


