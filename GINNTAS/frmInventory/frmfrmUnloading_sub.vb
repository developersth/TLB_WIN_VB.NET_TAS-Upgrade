Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmfrmUnloading_sub
    Dim frm_work As Integer = 0 'CardReader1=add ,2=Edit
    Dim pk_id As String = ""
    Dim RadioEnabled As String
    Dim RadioLocked As String
    Dim vFixType As String


    Private Sub frmfrmUnloading_sub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        If frm_work = 1 Then
            Me.Text = "Unloading # Add"
            'GetNextUnloadID()
        ElseIf frm_work = 2 Then
            Me.Text = "Unloading # Edit"
            AssignValue()
        End If
        txtLock(True)
    End Sub

    Private Sub Clear_frm()
        txtReceiptNo.Text = ""
        txtTransportUnit.Text = ""
        txtFromPlant.Text = ""
        txtTempSch.Text = ""
        txtAPISch.Text = ""
        txtTempToPlant.Text = ""
        txtAPIToPlant.Text = ""
        txtSchGrsQty.Text = ""
        txtSchNetQty.Text = ""
        txtToPlantGrsQty.Text = ""
        txtToPlantNetQty.Text = ""
        txtUnloadGrsQty.Text = ""
        txtUnloadNetQty.Text = ""
        txtReferance.Text = ""

    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        If iBoo Then
            'txtReceiptNo.BackColor = Color.LightGray
            txtLastUpdateDate.BackColor = Color.LightGray
            txtLastUpdateBy.BackColor = Color.LightGray
        Else
            'txtReceiptNo.BackColor = Color.White
            txtLastUpdateDate.BackColor = Color.White
            txtLastUpdateBy.BackColor = Color.White
        End If
    End Sub

#Region "Menu Event"
  

    Private Sub UcCancel1_OnClickCancel(ByVal ucName As System.String) Handles UcCancel1.OnClickCancel
        Me.Close()
        'Initial_frm()
    End Sub

#End Region

    Private Sub Save()
        Dim strSQL As String
        Dim strcbUnloadType() = Split(cbUnloadType.Text, "-")
        If CheckDataExists(Trim(txtReceiptNo.Text)) Then
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "เนื่องจากตั๋วรับ " & txtReceiptNo.Text & " อยู่ในฐานข้อมูลแล้ว", "System TAS")
            Exit Sub
        End If

        strSQL = _
            "insert into OIL_UNLOAD(" & _
                "RECEIPT_NO,UNLOAD_TYPE," & _
                "TRANSPORT_UNIT,PRODUCT_ID," & _
                "NET_TOPLANT_QTY,NET_UNLOAD_QTY," & _
                "FROM_PLANT,TEMP_SCHEDULE," & _
                "API_SCHEDULE,GROSS_SCHEDULE_QTY," & _
                "NET_SCHEDULE_QTY,TEMP_TOPLANT," & _
                "API_TOPLANT,GROSS_TOPLANT_QTY," & _
                "GROSS_UNLOAD_QTY,TANK_UNLOAD," & _
                "TIME_START_UNLOAD,TIME_STOP_UNLOAD," & _
                "REFERENCE,CREATION_DATE," & _
                "CREATED_BY,UPDATE_DATE," & _
                "UPDATED_BY,J_COMPUTER) " & _
                "values(" & _
              "'" & Trim(txtReceiptNo.Text) & "'," & strcbUnloadType(0) & "," & _
            "'" & txtTransportUnit.Text & "','" & cbProduct.Text & "'," & _
            Val(txtToPlantNetQty.Text) & "," & Val(txtUnloadNetQty.Text) & "," & _
            Val(txtFromPlant.Text) & "," & Val(txtTempSch.Text) & "," & _
            Val(txtAPISch.Text) & "," & Val(txtSchGrsQty.Text) & "," & _
            Val(txtSchNetQty.Text) & "," & Val(txtTempToPlant.Text) & "," & _
            Val(txtAPIToPlant.Text) & "," & Val(txtToPlantGrsQty.Text) & "," & _
            Val(txtUnloadGrsQty.Text) & ",'" & cbTankReceive.Text & "'," & _
            "to_date('" & Format(dtpStartUnload.Value, "dd/MM/yyyy HH:mm:ss") & "','dd/mm/yyyy hh24:mi:ss'),to_date('" & Format(dtpStopUnload.Value, "dd/MM/yyyy HH:mm:ss") & "','dd/mm/yyyy hh24:mi:ss')," & _
            "'" & Trim(txtReferance.Text) & "',sysdate," & _
            "'" & mUserName & "',sysdate," & _
            "'" & mUserName & "','" & mComputerName & "')"

        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmUnloading_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
        'If Save() Then
        '    'AE_ReceiptNo = Trim(txtReceiptNo)
        '    'Call AddJournal(Jevent, P_CurScreenID, 100, P_ModifyUser, 601201, txtReceiptNo, txtTransportUnit, cbProduct)

        'End If

    End Sub

    Public Sub setFrmWork(ByVal n As Integer)
        Me.frm_work = n
    End Sub

    Public Sub setPkId(ByVal id As String)
        Me.pk_id = id
    End Sub

    Private Sub Edit()
        Dim strSQL As String
        Dim strcbUnloadType() = Split(cbUnloadType.Text, "-")
        strSQL = _
            "update OIL_UNLOAD U set " & _
                "U.UNLOAD_TYPE=" & strcbUnloadType(0) & "," & _
                "U.TRANSPORT_UNIT='" & Trim(txtTransportUnit.Text) & "'," & _
                "U.PRODUCT_ID='" & cbProduct.Text & "'," & _
                "U.NET_TOPLANT_QTY='" & txtToPlantNetQty.Text & "'," & _
                "U.NET_UNLOAD_QTY='" & txtUnloadNetQty.Text & "'," & _
                "U.FROM_PLANT=" & Val(txtFromPlant.Text) & "," & _
                "U.TEMP_SCHEDULE=" & Val(txtTempSch.Text) & "," & _
                "U.API_SCHEDULE=" & Val(txtAPISch.Text) & "," & _
                "U.GROSS_SCHEDULE_QTY=" & Val(txtSchGrsQty.Text) & "," & _
                "U.NET_SCHEDULE_QTY=" & Val(txtSchNetQty.Text) & "," & _
                "U.TEMP_TOPLANT=" & Val(txtTempToPlant.Text) & "," & _
                "U.API_TOPLANT=" & Val(txtAPIToPlant.Text) & ","
        strSQL = strSQL & _
                "U.GROSS_TOPLANT_QTY=" & Val(txtToPlantGrsQty.Text) & "," & _
                "U.GROSS_UNLOAD_QTY=" & Val(txtUnloadGrsQty.Text) & "," & _
                "U.TANK_UNLOAD='" & cbTankReceive.Text & "'," & _
                "U.TIME_START_UNLOAD=to_date('" & Format(dtpStartUnload.Value, "dd/MM/yyyy HH:mm:ss") & "','dd/mm/yyyy hh24:mi:ss')," & _
                "U.TIME_STOP_UNLOAD=to_date('" & Format(dtpStopUnload.Value, "dd/MM/yyyy HH:mm:ss") & "','dd/mm/yyyy hh24:mi:ss')," & _
                "U.REFERENCE='" & Trim(txtReferance.Text) & "'," & _
                "U.UPDATE_DATE=sysdate," & _
                "U.UPDATED_BY='" & mUserName & "'," & _
                "U.J_COMPUTER='" & mComputerName & "' " & _
            "where  U.RECEIPT_NO='" & Trim(txtReceiptNo.Text) & "'"

        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmUnloading_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
        'Call AddJournal(Jevent, P_CurScreenID, 100, P_ModifyUser, 601202, txtReceiptNo, txtTransportUnit, cbProduct)

    End Sub

    Private Sub AssignValue()
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        txtReceiptNo.Enabled = False
        strSQL = _
      "select U.RECEIPT_NO,U.UNLOAD_TYPE,U.TRANSPORT_UNIT,U.PRODUCT_ID,U.FROM_PLANT," & _
            "U.TEMP_SCHEDULE,U.API_SCHEDULE,U.GROSS_SCHEDULE_QTY,U.NET_SCHEDULE_QTY," & _
            "U.TEMP_TOPLANT,U.API_TOPLANT,U.GROSS_TOPLANT_QTY,U.NET_TOPLANT_QTY," & _
            "U.GROSS_UNLOAD_QTY,U.NET_UNLOAD_QTY,U.TANK_UNLOAD," & _
            "U.TIME_START_UNLOAD,U.TIME_STOP_UNLOAD,U.REFERENCE," & _
            "U.IS_EOD,U.EOD_DATE, U.UPDATE_DATE, U.UPDATED_BY " & _
        "from OIL_UNLOAD U " & _
        "where U.RECEIPT_NO='" & pk_id & "'"

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            txtReceiptNo.Text = IIf(IsDBNull(dt.Rows(i).Item("RECEIPT_NO")), "", dt.Rows(i).Item("RECEIPT_NO").ToString)
            'AE_ReceiptNo = Oratemp("RECEIPT_NO")
            If dt.Rows(i).Item("UNLOAD_TYPE") Then
                cbUnloadType.SelectedIndex = -1
            Else
                If IsDBNull(dt.Rows(i).Item("UNLOAD_TYPE")) = "0" Then
                    cbUnloadType.Text = IsDBNull(dt.Rows(i).Item("UNLOAD_TYPE")) & "ทางรถบรรทุก"
                ElseIf IsDBNull(dt.Rows(i).Item("UNLOAD_TYPE")) = "1" Then
                    cbUnloadType.Text = IsDBNull(dt.Rows(i).Item("UNLOAD_TYPE")) & "โรงกลั่น"
                Else
                    cbUnloadType.Text = IsDBNull(dt.Rows(i).Item("UNLOAD_TYPE")) & "ทางเรือ"
                End If
                'cbUnloadType.Text = dt.Rows(i).Item("UNLOAD_TYPE")
                'MessageBox.Show(dt.Rows(i).Item("UNLOAD_TYPE"))

            End If
            txtTransportUnit.Text = IIf(IsDBNull(dt.Rows(i).Item("TRANSPORT_UNIT")), "", dt.Rows(i).Item("TRANSPORT_UNIT"))
            If IsDBNull(dt.Rows(i).Item("PRODUCT_ID")) Then
                cbProduct.SelectedIndex = -1
            Else
                cbProduct.Text = IIf(IsDBNull(dt.Rows(i).Item("PRODUCT_ID")), "", dt.Rows(i).Item("PRODUCT_ID"))
            End If
            txtFromPlant.Text = IIf(IsDBNull(dt.Rows(i).Item("FROM_PLANT")), "", dt.Rows(i).Item("FROM_PLANT"))
            txtTempSch.Text = IIf(IsDBNull(dt.Rows(i).Item("TEMP_SCHEDULE")), "", dt.Rows(i).Item("TEMP_SCHEDULE"))
            txtAPISch.Text = IIf(IsDBNull(dt.Rows(i).Item("API_SCHEDULE")), "", dt.Rows(i).Item("API_SCHEDULE"))
            txtSchGrsQty.Text = IIf(IsDBNull(dt.Rows(i).Item("GROSS_SCHEDULE_QTY")), "", dt.Rows(i).Item("GROSS_SCHEDULE_QTY"))
            txtSchNetQty.Text = IIf(IsDBNull(dt.Rows(i).Item("NET_SCHEDULE_QTY")), "", dt.Rows(i).Item("NET_SCHEDULE_QTY"))
            If IsDBNull(dt.Rows(i).Item("TANK_UNLOAD")) Then
                cbTankReceive.SelectedIndex = -1
            Else
                cbTankReceive.Text = IIf(IsDBNull(dt.Rows(i).Item("TANK_UNLOAD")), "", dt.Rows(i).Item("TANK_UNLOAD"))
            End If
            txtTempToPlant.Text = IIf(IsDBNull(dt.Rows(i).Item("TEMP_TOPLANT")), "", dt.Rows(i).Item("TEMP_TOPLANT"))
            txtAPIToPlant.Text = IIf(IsDBNull(dt.Rows(i).Item("API_TOPLANT")), "", dt.Rows(i).Item("API_TOPLANT"))
            txtToPlantGrsQty.Text = IIf(IsDBNull(dt.Rows(i).Item("GROSS_TOPLANT_QTY")), "", dt.Rows(i).Item("GROSS_TOPLANT_QTY"))
            txtToPlantNetQty.Text = IIf(IsDBNull(dt.Rows(i).Item("NET_TOPLANT_QTY")), "", dt.Rows(i).Item("NET_TOPLANT_QTY"))
            txtUnloadGrsQty.Text = IIf(IsDBNull(dt.Rows(i).Item("GROSS_UNLOAD_QTY")), "", dt.Rows(i).Item("GROSS_UNLOAD_QTY"))
            txtUnloadNetQty.Text = IIf(IsDBNull(dt.Rows(i).Item("NET_UNLOAD_QTY")), "", dt.Rows(i).Item("NET_UNLOAD_QTY"))
            dtpStartUnload.Value = IIf(IsDBNull(dt.Rows(i).Item("TIME_START_UNLOAD")), dtpStartUnload.MinDate, Format(dt.Rows(i).Item("TIME_START_UNLOAD"), "dd/MM/yyyy HH:mm:ss"))
            dtpStopUnload.Value = IIf(IsDBNull(dt.Rows(i).Item("TIME_STOP_UNLOAD")), dtpStopUnload.MinDate, Format(dt.Rows(i).Item("TIME_STOP_UNLOAD"), "dd/MM/yyyy HH:mm:ss"))
            txtReferance.Text = IIf(IsDBNull(dt.Rows(i).Item("REFERENCE")), "", dt.Rows(i).Item("REFERENCE"))
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

    Function CheckDataExists(ByRef pID As String) As Boolean
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        sql_str = "SELECT C.RECEIPT_NO FROM TAS.OIL_UNLOAD C"
        sql_str = sql_str & " WHERE  C.RECEIPT_NO = '" + pID + "' "
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Do While dt.Rows.Count > i
                Return True
            Loop
            Return False
        End If
        mDataSet = Nothing
        Return False
    End Function


    Function assignDropDown() As Boolean
        Dim sql_str As String

        sql_str = _
                "select S.STATUS_NUMBER||'-'||S.DESCRIPTION AS UnloadType " & _
                "from STATUS_DESC S " & _
                "where S.T_NAME='OIL_UNLOAD' " & _
                "and S.COLUMNS_NAME='UNLOAD_TYPE' " & _
                "order by S.STATUS_NUMBER"
        assignDropDown(sql_str, "UnloadType", cbUnloadType)


        sql_str = _
                "select b.base_product_id,b.base_product_name" & _
                " from tas.base_product b" & _
                " order by b.base_product_id"
        assignDropDown(sql_str, "base_product_id", cbProduct)

        Return True
    End Function
    Private Sub SelectProductSetTank(ProductID As String)
        Dim sql_str As String
        sql_str = _
                  "select T.TANK_NAME " & _
                  "from VIEW_MAP_TANK T " & _
                  "where T.BASE_PRODUCT='" & ProductID & "' " & _
            "order by T.TANK_NAME"
        assignDropDown(sql_str, "TANK_NAME", cbTankReceive)
    End Sub
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


    Private Sub txtQuota_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    End Sub

    Private Sub AssignCheckBox()

    End Sub

    Private Sub setListboxWithName(ByVal name As String, ByVal cb As System.Object)
        Dim index As Integer = cb.FindString(name)
        If index = -1 Then
        Else
            cb.SelectedIndex = index
        End If
    End Sub

    Private Function GetNextUnloadID() As Long
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        sql_str = " SELECT MAX((RECEIPT_NO)+1) as MaxCRID FROM TAS.OIL_UNLOAD"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            txtReceiptNo.Text = IIf(IsDBNull(dt.Rows(0).Item("MaxCRID")), "", dt.Rows(0).Item("MaxCRID").ToString)
        End If
        Return 0.1
    End Function



    Private Sub cbProduct_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbProduct.SelectedIndexChanged
        cbTankReceive.Items.Clear()
        If cbProduct.SelectedIndex >= 0 Then
            Call SelectProductSetTank(cbProduct.Text)
        Else
            cbTankReceive.Text = ""
        End If
    End Sub

    Private Sub UcSave1_OnClickSave(ucName As System.String) Handles UcSave1.OnClickSave
        If frm_work = 1 Then 'Add
            If Trim(txtReceiptNo.Text) = "" Or cbUnloadType.Text = "" Or Trim(txtTransportUnit.Text) = "" Or cbProduct.Text = "" _
               Or Trim(txtFromPlant.Text) = "" Or Trim(txtTempSch.Text) = "" Or Trim(txtAPISch.Text) = "" Or Trim(txtSchGrsQty.Text) = "" Or Trim(txtSchNetQty.Text) = "" _
               Or cbTankReceive.Text = "" Or Trim(txtTempToPlant.Text) = "" Or Trim(txtAPIToPlant.Text) = "" _
               Or Trim(txtToPlantGrsQty.Text) = "" Or Trim(txtUnloadGrsQty.Text) = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If Trim(txtReceiptNo.Text) = "" Or cbUnloadType.Text = "" Or Trim(txtTransportUnit.Text) = "" Or cbProduct.Text = "" _
               Or Trim(txtFromPlant.Text) = "" Or Trim(txtTempSch.Text) = "" Or Trim(txtAPISch.Text) = "" Or Trim(txtSchGrsQty.Text) = "" Or Trim(txtSchNetQty.Text) = "" _
               Or cbTankReceive.Text = "" Or Trim(txtTempToPlant.Text) = "" Or Trim(txtAPIToPlant.Text) = "" _
               Or Trim(txtToPlantGrsQty.Text) = "" Or Trim(txtUnloadGrsQty.Text) = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Edit()
            End If
        End If
    End Sub

    Private Sub txtTempSch_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTempSch.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("สามารถใส่ได้แค่ตัวเลข")
        End Select
    End Sub

    Private Sub txtAPISch_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAPISch.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("สามารถใส่ได้แค่ตัวเลข")
        End Select
    End Sub

    Private Sub txtTempToPlant_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTempToPlant.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("สามารถใส่ได้แค่ตัวเลข")
        End Select
    End Sub

    Private Sub txtAPIToPlant_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtAPIToPlant.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("สามารถใส่ได้แค่ตัวเลข")
        End Select
    End Sub

    Private Sub txtSchGrsQty_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSchGrsQty.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("สามารถใส่ได้แค่ตัวเลข")
        End Select
    End Sub

    Private Sub txtSchNetQty_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSchNetQty.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("สามารถใส่ได้แค่ตัวเลข")
        End Select
    End Sub

    Private Sub txtToPlantGrsQty_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtToPlantGrsQty.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("สามารถใส่ได้แค่ตัวเลข")
        End Select
    End Sub

    Private Sub txtToPlantNetQty_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtToPlantNetQty.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("สามารถใส่ได้แค่ตัวเลข")
        End Select
    End Sub

    Private Sub txtUnloadGrsQty_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnloadGrsQty.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("สามารถใส่ได้แค่ตัวเลข")
        End Select
    End Sub

    Private Sub txtUnloadNetQty_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnloadNetQty.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("สามารถใส่ได้แค่ตัวเลข")
        End Select
    End Sub

    Private Sub txtReceiptNo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtReceiptNo.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("สามารถใส่ได้แค่ตัวเลข")
        End Select
    End Sub
End Class
