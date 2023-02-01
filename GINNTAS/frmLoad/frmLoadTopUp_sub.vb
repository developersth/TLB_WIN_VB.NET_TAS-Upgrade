Public Class frmLoadTopUp_sub
    Dim frm_work As Integer = 0 'DO=add ,2=Edit
    Dim pk_id As String = ""
    Dim pLoad As String
    Dim Produc_ID As String
    Dim Bay_no As String
    Private Sub frmLoadTopUp_sub_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        PickerDate_Start.Value = Date.Today
        assignDropDown()
        If frm_work = 1 Then
            Me.Text = "Topup # Add"
            'GetNextID()
        ElseIf frm_work = 2 Then
            Me.Text = "Topup # Edit"
            AssignValue()
        End If
        'txtLock(True)
    End Sub
    Public Sub setFrmWork(ByVal n As Integer)
        Me.frm_work = n
    End Sub
    Public Sub setPkId(ByVal id As String)
        Me.pk_id = id
    End Sub
    Private Sub Clear_frm()
        CbLoadNo.Items.Clear()
        CbShipmentNo.Items.Clear()
        CbDono.Items.Clear()
        CbCompartment.Items.Clear()
        CbSProductName.Items.Clear()
        CbMeterName.Items.Clear()
        txtPreset.Text = ""
        txtDesc.Text = ""
        txtCardTu.Text = ""
        txtTuid.Text = ""
        txtTuid1.Text = ""
        txtDriverID.Text = ""
        txtDriverName.Text = ""
        txtDriverName.Text = ""
        txtvehicletype.Text = ""
        txtvehicle.Text = ""
        txtCarrierID.Text = ""
        txtCarrierName.Text = ""
        txtCustomerID.Text = ""
        txtCustomerName.Text = ""
        txtShipToID.Text = ""
        txtShipToName.Text = ""
    End Sub
    Private Sub AssignValue()

        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        sql_str = _
                    " select   t.topup_no,t.load_header_no,t.shipment_no,t.do_no,t.compartment_no, " & _
                    " t.sale_product_id ||' - '|| t.sale_product_name as sale_product, " & _
                    " t.bay_no ||' - '|| t.bay_name as  bay ,t.meter_no,t.preset,t.tu_id,t.tu_number,t.driver_id ,t.driver_name," & _
                    " t.vehicle_type,t.vehicle_number,t.vehicle_id,t.carrier_id,t.carrier_name," & _
                    " t.Customer_code , t.Customer_name, t.ship_to_code, t.ShipTo_name ,oh.tu_card_no , oh.tu_number1,tu_id1 " & _
                    " from tas.oil_topup_lines t   , tas.oil_load_headers  oh" & _
                     " where  t.load_header_no = oh.load_header_no " & _
                    " and  t.topup_no ='" & Trim(pk_id) & "'"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            If dt.Rows.Count > 0 Then
                CbLoadNo.Text = IIf(IsDBNull(dt.Rows(i).Item("load_header_no")), "", dt.Rows(i).Item("load_header_no"))
                txtCardTu.Text = IIf(IsDBNull(dt.Rows(i).Item("tu_card_no")), "", dt.Rows(i).Item("tu_card_no"))
                CbShipmentNo.Text = IIf(IsDBNull(dt.Rows(i).Item("shipment_no")), "", dt.Rows(i).Item("shipment_no"))
                CbDono.Text = IIf(IsDBNull(dt.Rows(i).Item("do_no")), "", dt.Rows(i).Item("do_no"))
                CbSProductName.Text = IIf(IsDBNull(dt.Rows(i).Item("sale_product")), "", dt.Rows(i).Item("sale_product"))
                CbBayName.Text = IIf(IsDBNull(dt.Rows(i).Item("bay")), "", dt.Rows(i).Item("bay"))
                CbMeterName.Text = IIf(IsDBNull(dt.Rows(i).Item("meter_no")), "", dt.Rows(i).Item("meter_no"))
                txtPreset.Text = IIf(IsDBNull(dt.Rows(i).Item("preset")), "", dt.Rows(i).Item("preset"))
                txtTuid.Text = IIf(IsDBNull(dt.Rows(i).Item("tu_id")), "", dt.Rows(i).Item("tu_id"))
                txtTuid1.Text = IIf(IsDBNull(dt.Rows(i).Item("tu_id1")), "", dt.Rows(i).Item("tu_id1"))
                txtDriverID.Text = IIf(IsDBNull(dt.Rows(i).Item("Driver_Id")), "", dt.Rows(i).Item("Driver_Id"))
                txtDriverName.Text = IIf(IsDBNull(dt.Rows(i).Item("driver_name")), "", dt.Rows(i).Item("driver_name"))
                txtvehicletype.Text = IIf(IsDBNull(dt.Rows(i).Item("vehicle_type")), "", dt.Rows(i).Item("vehicle_type"))
                txtvehicle.Text = IIf(IsDBNull(dt.Rows(i).Item("vehicle_number")), "", dt.Rows(i).Item("vehicle_number"))
                txtCarrierID.Text = IIf(IsDBNull(dt.Rows(i).Item("carrier_id")), "", dt.Rows(i).Item("carrier_id"))
                txtCarrierName.Text = IIf(IsDBNull(dt.Rows(i).Item("carrier_name")), "", dt.Rows(i).Item("carrier_name"))
                txtCustomerID.Text = IIf(IsDBNull(dt.Rows(i).Item("customer_code")), "", dt.Rows(i).Item("customer_code"))
                txtCustomerName.Text = IIf(IsDBNull(dt.Rows(i).Item("customer_name")), "", dt.Rows(i).Item("customer_name"))
                txtShipToID.Text = IIf(IsDBNull(dt.Rows(i).Item("ship_to_code")), "", dt.Rows(i).Item("ship_to_code"))
                txtShipToName.Text = IIf(IsDBNull(dt.Rows(i).Item("shipto_name")), "", dt.Rows(i).Item("shipto_name"))
            End If
        Else

        End If
        mDataSet = Nothing

    End Sub
    Private Sub Edit()
        Dim strSQL As String
        Dim tmp() As String
        Dim bayNo As String = String.Empty
        Dim BayName As String = String.Empty
        Dim SaleProduct_id As String = String.Empty
        Dim SaleProduct_Name As String = String.Empty
        If CbBayName.Text <> "" Then
            If InStr(1, CbBayName.Text, "-") > 0 Then
                tmp = Split(CbBayName.Text, "-")
                bayNo = tmp(0)
                BayName = tmp(1)
            Else
                bayNo = CbBayName.Text
                BayName = CbBayName.Text
            End If
        End If
        If CbSProductName.Text <> "" Then
            If InStr(1, CbSProductName.Text, "-") > 0 Then
                tmp = Split(CbSProductName.Text, "-")
                SaleProduct_id = tmp(0)
                SaleProduct_Name = tmp(1)
            End If
        End If
        If CbMeterName.Text = "" Or txtPreset.Text = "" Then
            MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบใหม่อีกครั้ง", vbInformation)
            Exit Sub
        End If
        If MsgBox("ท่านต้องการข้อมูลหรือไม่", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If

        strSQL =
            "UPDATE OIL_TOPUP_LINES T SET " &
                "T.TOPUP_NO=" & Trim(pk_id) & "," &
                "T.LOAD_HEADER_NO=" & Trim(CbLoadNo.Text) & "," &
                "T.SHIPMENT_NO=" & Trim(CbShipmentNo.Text) & "," &
                "T.DO_NO=" & Trim(CbDono.Text) & "," &
                "T.COMPARTMENT_NO=" & Trim(CbCompartment.Text) & "," &
                "T.BAY_NO='" & Trim(bayNo) & "'," &
                "T.BAY_NAME='" & Trim(BayName) & "'," &
                "T.METER_NAME='" & Trim(CbMeterName.Text) & "'," &
                "T.SALE_PRODUCT_ID='" & Trim(SaleProduct_id) & "'," &
                "T.SALE_PRODUCT_NAME='" & Trim(SaleProduct_Name) & "'," &
                "T.PRESET='" & Trim(txtPreset.Text) & "'," &
                "T.SHIP_TO_CODE='" & Trim(txtShipToID.Text) & "'," &
                "T.SHIPTO_NAME='" & Trim(txtShipToName.Text) & "'," &
                "T.DRIVER_ID='" & Trim(txtDriverID.Text) & "'," &
                "T.DRIVER_NAME='" & Trim(txtDriverName.Text) & "'," &
                "T.DESCRIPTION='" & Trim(txtDesc.Text) & "'," &
                "T.UPDATE_DATE=sysdate," &
                "T.UPDATED_BY='" & mUserName & "'," &
                "T.J_COMPUTER='" & mComputerName & "' " &
                " WHERE T.TOPUP_NO=" & Trim(pk_id)


        If Oradb.ExeSQL(strSQL) Then
            Call AddJournal(JournalType.Jevent, 505, 100, mUserName, 505202, txtLoadTopUpNo.Text, CbLoadNo.Text, txtTuid.Text)
            MsgBox("แก้ไขข้อมูลเรียบร้อยแล้ว", vbInformation, "ระบบแจ้งว่า")
            Me.Close()
            setFrmWork(0)
            frmLoadTopUp.Showdata_GridMain()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
        
    End Sub

    Private Sub SelectListCombo(DoQurey As String, SmQurey As String, LnQurey As String)
        Dim strSQL As String = ""
        Dim Condition As String
        Dim SelectCombo As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Long = 0

        If DoQurey <> "" Then
            Condition = DoQurey
            Call InitialFrom("", "", DoQurey)
            strSQL = "select t.load_header_no,t.shipment_no,t.do_no,t.bay_name,t.meter_name,t.meter_no,t.sale_product_id,t.sale_product_name,t.compartment_no,t.preset,t.batch_no" & _
                                " from oil_load_lines t" & _
                                " where t.do_no='" & Condition & "' " & _
                                " Order by t.sale_product_id"
        ElseIf SmQurey <> "" Then
            Condition = SmQurey
            Call InitialFrom(SmQurey, "", "")
            strSQL = "select t.load_header_no,t.shipment_no,t.do_no,t.bay_name,t.meter_name,t.meter_no,t.sale_product_id,t.sale_product_name,t.compartment_no,t.preset,t.batch_no" & _
                                " from oil_load_lines t" & _
                                " where t.shipment_no='" & Condition & "' " & _
                                " Order by t.sale_product_id"
        ElseIf LnQurey <> "" Then
            Condition = LnQurey
            Call InitialFrom("", LnQurey, "")
            strSQL = "select t.load_header_no,t.shipment_no,t.do_no,t.bay_name,t.meter_name,t.meter_no,t.sale_product_id,t.sale_product_name,t.compartment_no,t.preset,t.batch_no" & _
                                " from oil_load_lines t" & _
                                " where t.load_header_no='" & Condition & "' " & _
                                " Order by t.sale_product_id"
        End If
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            '********************************************************************************************************************************************
            SelectCombo = IIf(IsDBNull(dt.Rows(0).Item("sale_product_id")), "", dt.Rows(0).Item("sale_product_id").ToString)
            SelectCombo = SelectCombo & " - "
            SelectCombo = SelectCombo & IIf(IsDBNull(dt.Rows(i).Item("sale_product_name")), "", dt.Rows(i).Item("sale_product_name").ToString)
            Produc_ID = IIf(IsDBNull(dt.Rows(0).Item("sale_product_id")), "", dt.Rows(0).Item("sale_product_id").ToString)
            For i = 0 To CbSProductName.Items.Count - 1
                If SelectCombo = CbSProductName.Items(i) Then
                    CbSProductName.SelectedIndex = i
                    Exit For
                End If
            Next i
            SelectCombo = IIf(IsDBNull(dt.Rows(0).Item("load_header_no")), "", dt.Rows(0).Item("load_header_no").ToString)
            For i = 0 To CbLoadNo.Items.Count - 1
                If SelectCombo = CbLoadNo.Items(i) Then
                    ' UseComBo. = True
                    CbLoadNo.SelectedIndex = i
                    'UseComBo = False
                    Exit For
                End If
            Next i
            SelectCombo = IIf(IsDBNull(dt.Rows(0).Item("do_no")), "", dt.Rows(0).Item("do_no").ToString)
            For i = 0 To CbDono.Items.Count - 1
                If SelectCombo = CbDono.Items(i) Then
                    CbDono.SelectedIndex = i
                    Exit For
                End If
            Next i

            CbCompartment.SelectedIndex = 0

            'SelectCombo = IIf(IsDBNull(dt.Rows(0).Item("do_no")), "", dt.Rows(0).Item("do_no").ToString)
            'For i = 0 To CbMeterName.Items.Count - 1
            '    If SelectCombo = CbMeterName.Items(i - 1) Then
            '        CbMeterName.SelectedIndex = i
            '        Exit For
            '    End If
            'Next i
            SelectCombo = IIf(IsDBNull(dt.Rows(0).Item("meter_no")), "", dt.Rows(0).Item("meter_no").ToString)
            For i = 0 To CbMeterName.Items.Count - 1
                If SelectCombo = CbMeterName.Items(i) Then
                    CbMeterName.SelectedIndex = i
                    Exit For
                End If
            Next i
            SelectCombo = IIf(IsDBNull(dt.Rows(0).Item("batch_no")), "", dt.Rows(0).Item("batch_no").ToString)
            For i = 0 To CbBayName.Items.Count - 1
                If SelectCombo = CbBayName.Items(i) Then
                    CbBayName.SelectedIndex = i
                    Exit For
                End If
            Next i
         
        End If
        mDataSet = Nothing
    End Sub
    Private Sub InitialBay()
        Dim strSQL As String = ""
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Long = 0
        Dim Select_Bay As String
        strSQL = _
             "select distinct  B.BAY_NO,B.BAY_NO||' - '||B.BAY_NAME as bay" & _
             " From tas.meter_product P" & _
             ",tas.meter M,tas.bay B" & _
             " Where P.METER_NO = M.METER_NO" & _
             " and M.Island_No=B.ISLAND_NO" & _
             " and P.SALE_PRODUCT_ID=" & Produc_ID
        assignDropDown(strSQL, "bay", CbBayName)
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Select_Bay = dt.Rows(0).Item("bay").ToString
            Bay_no = IIf(IsDBNull(dt.Rows(i).Item("BAY_NO")), "", dt.Rows(i).Item("BAY_NO").ToString)
            For i = 0 To CbBayName.Items.Count - 1
                If Select_Bay = CbBayName.Items(i) Then
                    CbBayName.SelectedIndex = i
                    Exit For
                End If
            Next i
        End If
    End Sub
    Private Sub InitialMeter()
        Dim strSQL As String = ""
        Dim i As Long = 0
        strSQL = "select M.METER_NO" & _
                    " From tas.meter_product P" & _
                    ",tas.meter M,tas.bay B" & _
                    " Where P.METER_NO = M.METER_NO" & _
                    " and M.Island_No=B.ISLAND_NO" & _
                    " and P.SALE_PRODUCT_ID=" & Produc_ID & " " & _
                    " and B.BAY_NAME=" & "'" & Trim(Bay_no) & "'"
        assignDropDown(strSQL, "METER_NO", CbMeterName)
    End Sub

    Private Sub InitialFrom(ByVal ShipmentNo As String, LoadNo As String, Dono As String)
        Dim ValuStr, ValuStr1 As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        Dim strSQL As String

        If ShipmentNo <> "" Then
            ValuStr = ShipmentNo
            strSQL = "select  t.shipment_no,t.tu_card_no,t.tu_card_no1,t.tu_id,t.tu_id1,t.Driver_Id," & _
                              "t.driver_name,t.vehicle_type,t.vehicle_number,t.carrier_id,t.carrier_name," & _
                              "c.customer_code,c.customer_name,c.shipment_no,c.ship_to_code,c.shipto_name" & _
                              " from oil_load_headers t,oil_customer c" & _
                              " Where t.cancel_status=0 and t.shipment_no =" & ValuStr & " " & _
                              "and t.shipment_no=c.shipment_no"

            If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                If dt.Rows.Count > 0 Then
                    CbLoadNo.Text = LoadNo
                    txtCardTu.Text = IIf(IsDBNull(dt.Rows(i).Item("tu_card_no")), "", dt.Rows(i).Item("tu_card_no").ToString)
                    txtTuid.Text = IIf(IsDBNull(dt.Rows(i).Item("tu_id")), "", dt.Rows(i).Item("tu_id").ToString)
                    txtTuid1.Text = IIf(IsDBNull(dt.Rows(i).Item("tu_id1")), "", dt.Rows(i).Item("tu_id1").ToString)
                    txtDriverID.Text = IIf(IsDBNull(dt.Rows(i).Item("Driver_Id")), "", dt.Rows(i).Item("Driver_Id").ToString)
                    txtDriverName.Text = IIf(IsDBNull(dt.Rows(i).Item("driver_name")), "", dt.Rows(i).Item("driver_name").ToString)
                    txtvehicletype.Text = IIf(IsDBNull(dt.Rows(i).Item("vehicle_type")), "", dt.Rows(i).Item("vehicle_type").ToString)
                    txtvehicle.Text = IIf(IsDBNull(dt.Rows(i).Item("vehicle_number")), "", dt.Rows(i).Item("vehicle_number").ToString)
                    txtCarrierID.Text = IIf(IsDBNull(dt.Rows(i).Item("carrier_id")), "", dt.Rows(i).Item("carrier_id").ToString)
                    txtCarrierName.Text = IIf(IsDBNull(dt.Rows(i).Item("carrier_name")), "", dt.Rows(i).Item("carrier_name").ToString)
                    txtCustomerID.Text = IIf(IsDBNull(dt.Rows(i).Item("customer_code")), "", dt.Rows(i).Item("customer_code").ToString)
                    txtCustomerName.Text = IIf(IsDBNull(dt.Rows(i).Item("customer_name")), "", dt.Rows(i).Item("customer_name").ToString)
                    txtShipToID.Text = IIf(IsDBNull(dt.Rows(i).Item("ship_to_code")), "", dt.Rows(i).Item("ship_to_code").ToString)
                    txtShipToName.Text = IIf(IsDBNull(dt.Rows(i).Item("shipto_name")), "", dt.Rows(i).Item("shipto_name").ToString)
                End If
            End If
        End If
        If LoadNo <> "" Then
            ValuStr1 = LoadNo
            strSQL = "select  t.load_header_no,t.tu_card_no,t.tu_card_no1,t.tu_id,t.tu_id1,t.Driver_Id," & _
                              "t.driver_name,t.vehicle_type,t.vehicle_number,t.carrier_id,t.carrier_name," & _
                              "c.customer_code,c.customer_name,c.shipment_no,c.ship_to_code,c.shipto_name" & _
                              " from oil_load_headers t,oil_customer c" & _
                              " Where t.load_header_no =" & ValuStr1 & " " & _
                              " and t.load_header_no=c.load_header_no"

            If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                If dt.Rows.Count > 0 Then
                    txtCardTu.Text = IIf(IsDBNull(dt.Rows(i).Item("tu_card_no")), "", dt.Rows(i).Item("tu_card_no").ToString)
                    txtTuid.Text = IIf(IsDBNull(dt.Rows(i).Item("tu_id")), "", dt.Rows(i).Item("tu_id").ToString)
                    txtTuid1.Text = IIf(IsDBNull(dt.Rows(i).Item("tu_id1")), "", dt.Rows(i).Item("tu_id1").ToString)
                    txtDriverID.Text = IIf(IsDBNull(dt.Rows(i).Item("Driver_Id")), "", dt.Rows(i).Item("Driver_Id").ToString)
                    txtDriverName.Text = IIf(IsDBNull(dt.Rows(i).Item("driver_name")), "", dt.Rows(i).Item("driver_name").ToString)
                    txtvehicletype.Text = IIf(IsDBNull(dt.Rows(i).Item("vehicle_type")), "", dt.Rows(i).Item("vehicle_type").ToString)
                    txtvehicle.Text = IIf(IsDBNull(dt.Rows(i).Item("vehicle_number")), "", dt.Rows(i).Item("vehicle_number").ToString)
                    txtCarrierID.Text = IIf(IsDBNull(dt.Rows(i).Item("carrier_id")), "", dt.Rows(i).Item("carrier_id").ToString)
                    txtCarrierName.Text = IIf(IsDBNull(dt.Rows(i).Item("carrier_name")), "", dt.Rows(i).Item("carrier_name").ToString)
                    txtCustomerID.Text = IIf(IsDBNull(dt.Rows(i).Item("customer_code")), "", dt.Rows(i).Item("customer_code").ToString)
                    txtCustomerName.Text = IIf(IsDBNull(dt.Rows(i).Item("customer_name")), "", dt.Rows(i).Item("customer_name").ToString)
                    txtShipToID.Text = IIf(IsDBNull(dt.Rows(i).Item("ship_to_code")), "", dt.Rows(i).Item("ship_to_code").ToString)
                    txtShipToName.Text = IIf(IsDBNull(dt.Rows(i).Item("shipto_name")), "", dt.Rows(i).Item("shipto_name").ToString)
                End If
            End If
     
        End If
        If Dono <> "" Then
            ValuStr1 = Dono
            strSQL = "select  t.load_header_no,t.tu_card_no,t.tu_card_no1,t.tu_id,t.tu_id1,t.Driver_Id,t.driver_name,t.vehicle_type,t.vehicle_number,t.carrier_id,t.carrier_name,c.customer_code,c.customer_name,c.shipment_no,c.ship_to_code,c.shipto_name" & _
            " from oil_load_headers t,oil_customer c,tas.oil_load_lines ol" & _
            " Where ol.do_no ='" & ValuStr1 & "'" & _
            " and t.load_header_no=ol.load_header_no" & _
            " and t.load_header_no=c.load_header_no"


            If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                If dt.Rows.Count > 0 Then
                    txtCardTu.Text = IIf(IsDBNull(dt.Rows(i).Item("tu_card_no")), "", dt.Rows(i).Item("tu_card_no").ToString)
                    txtTuid.Text = IIf(IsDBNull(dt.Rows(i).Item("tu_id")), "", dt.Rows(i).Item("tu_id").ToString)
                    txtTuid1.Text = IIf(IsDBNull(dt.Rows(i).Item("tu_id1")), "", dt.Rows(i).Item("tu_id1").ToString)
                    txtDriverID.Text = IIf(IsDBNull(dt.Rows(i).Item("Driver_Id")), "", dt.Rows(i).Item("Driver_Id").ToString)
                    txtDriverName.Text = IIf(IsDBNull(dt.Rows(i).Item("shipto_name")), "", dt.Rows(i).Item("shipto_name").ToString)
                    txtvehicletype.Text = IIf(IsDBNull(dt.Rows(i).Item("vehicle_type")), "", dt.Rows(i).Item("vehicle_type").ToString)
                    txtvehicle.Text = IIf(IsDBNull(dt.Rows(i).Item("vehicle_number")), "", dt.Rows(i).Item("vehicle_number").ToString)
                    txtCarrierID.Text = IIf(IsDBNull(dt.Rows(i).Item("carrier_id")), "", dt.Rows(i).Item("carrier_id").ToString)
                    txtCarrierName.Text = IIf(IsDBNull(dt.Rows(i).Item("carrier_name")), "", dt.Rows(i).Item("carrier_name").ToString)
                    txtCustomerID.Text = IIf(IsDBNull(dt.Rows(i).Item("customer_code")), "", dt.Rows(i).Item("customer_code").ToString)
                    txtCustomerName.Text = IIf(IsDBNull(dt.Rows(i).Item("customer_name")), "", dt.Rows(i).Item("customer_name").ToString)
                    txtShipToID.Text = IIf(IsDBNull(dt.Rows(i).Item("ship_to_code")), "", dt.Rows(i).Item("ship_to_code").ToString)
                    txtShipToName.Text = IIf(IsDBNull(dt.Rows(i).Item("shipto_name")), "", dt.Rows(i).Item("shipto_name").ToString)

                End If
            End If
       
        End If
        mDataSet = Nothing
    End Sub
    Function assignDropDown() As Boolean
        Dim sql_str As String
        Dim vDate = Format(PickerDate_Start.Value, "dd/MM/yyyy")
        sql_str = _
                     "select  distinct t.shipment_no,t.load_header_no,ol.do_no,t.creation_date" & _
                     " from oil_load_headers t,oil_load_lines ol" & _
                     " where to_char(t.creation_date,'DD/MM/YYYY') ='" & vDate & "'" & _
                     " and t.load_header_no=ol.load_header_no" & _
                     "  Order by t.load_header_no,t.shipment_no,ol.do_no"
        assignDropDown(sql_str, "load_header_no", CbLoadNo)
        assignDropDown(sql_str, "shipment_no", CbShipmentNo)
        assignDropDown(sql_str, "Do_no", CbDono)

        sql_str = "select t.sale_product_id||' - '||t.sale_product_name as sale_product_id " & _
                  " from meter_product t " & _
                  " group by  t.sale_product_id,t.sale_product_name" & _
                  " order by t.sale_product_id"
        assignDropDown(sql_str, "sale_product_id", CbSProductName)
        CbCompartment.Items.Clear()
        With CbCompartment
            For i = 1 To 10
                .Items.Add(i)
            Next
        End With
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

    Private Sub CbLoadNo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbLoadNo.SelectedIndexChanged
        If CbLoadNo.Text <> "" Then
            pLoad = CbLoadNo.Text
            Call SelectListCombo("", "", pLoad)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub CbBayName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbBayName.SelectedIndexChanged
        InitialMeter()
    End Sub

    Private Sub CbSProductName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CbSProductName.SelectedIndexChanged
        InitialBay()
    End Sub

    Private Sub PickerDate_Start_ValueChanged(sender As System.Object, e As System.EventArgs) Handles PickerDate_Start.ValueChanged
        CbLoadNo.Items.Clear()
        CbShipmentNo.Items.Clear()
        CbDono.Items.Clear()
        assignDropDown()
    End Sub

    Private Sub b_clear_Click(sender As System.Object, e As System.EventArgs) Handles b_clear.Click
        Clear_frm()
    End Sub

    Private Sub btSave_Click(sender As System.Object, e As System.EventArgs) Handles btSave.Click
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        Dim strSQL As String


        If frm_work = 1 Then 'Add

        If CbMeterName.Text = "" Or txtPreset.Text = "" Or CbSProductName.Text = "" Then
            MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", vbInformation)
            Exit Sub
        End If

        strSQL = "select  t.sale_product_name from sale_product t Where t.sale_product_id=" & "'" & Produc_ID & "'"
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count <= 0 Then
                MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "ไม่พบผลิตภัณฑ์ชนิดนี้ในฐานข้อมุล", vbInformation)
                Exit Sub
            End If
        End If
        strSQL = "select t.meter_no from meter t where t.meter_no=" & "'" & CbMeterName.Text & "'"
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count <= 0 Then
                MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "ไม่พบชื่อ Meter นี้ในฐานข้อมูล กรุณาตรวจสอบข้อมูลอีกครั้ง", vbInformation)
                Exit Sub
            End If
        End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If

        ElseIf frm_work = 2 Then 'Edit
            If CbMeterName.Text = "" Or txtPreset.Text = "" Or CbSProductName.Text = "" Then
                MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", vbInformation)
                Exit Sub
            End If
            Edit()
        End If

    End Sub
 
    Private Sub Save()
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        Dim strSQL As String
        Dim Vehicle_Type, vehicle_id As String, Tu_type, TU_NUMBER As String
        Dim Do_no As String
        Dim tmp() As String
        Dim SaleProduct_id, SaleProduct_Name, bayNo, TopUpNo As String
        Dim BayName As String


        If CbBayName.Text <> "" Then
            If InStr(1, CbBayName.Text, "-") > 0 Then
                tmp = Split(CbBayName.Text, "-")
                bayNo = tmp(0)
                BayName = tmp(1)
            Else
                bayNo = CbBayName.Text
                BayName = CbBayName.Text
            End If
        End If
        If CbSProductName.Text <> "" Then
            If InStr(1, CbSProductName.Text, "-") > 0 Then
                tmp = Split(CbSProductName.Text, "-")
                SaleProduct_id = tmp(0)
                SaleProduct_Name = tmp(1)
            End If
        End If
        strSQL = _
             "select TOPUP_SEQ.NEXTVAL As d " & _
             "from DUAL"
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                TopUpNo = IIf(IsDBNull(dt.Rows(0).Item("d")), "", dt.Rows(0).Item("d").ToString)
            End If
        End If

        strSQL = _
                 "select t.tu_id,t.tu_type,t.tu_number,v.vehicle_number,v.vehicle_type,v.vehicle_id" & _
                 " from transport_unit t,vehicle v" & _
                 " where t.tu_id='" & txtTuid.Text & "'" & _
                 " and t.tu_id=v.vehicle_id"
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count <= 0 Then
                Tu_type = "0"
                TU_NUMBER = "0"
                Vehicle_Type = Trim(txtvehicletype.Text)
                vehicle_id = Trim(txtvehicle.Text)
            Else
                Tu_type = IIf(IsDBNull(dt.Rows(0).Item("tu_type")), "", dt.Rows(0).Item("tu_type"))
                TU_NUMBER = IIf(IsDBNull(dt.Rows(0).Item("tu_number")), "", dt.Rows(0).Item("tu_number"))
                Vehicle_Type = IIf(IsDBNull(dt.Rows(0).Item("vehicle_type")), "", dt.Rows(0).Item("vehicle_type"))
                vehicle_id = IIf(IsDBNull(dt.Rows(0).Item("vehicle_id")), "", dt.Rows(0).Item("vehicle_id"))
            End If
        End If
        strSQL = _
                   "select t.load_header_no,t.do_no,t.sale_product_id,t.sale_product_name " & _
                   " from oil_load_lines t" & _
                   " where t.load_header_no=" & CbLoadNo.Text
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                Do_no = IIf(IsDBNull(dt.Rows(0).Item("do_no")), "", dt.Rows(0).Item("do_no"))
                If Do_no = "" Then
                    Do_no = CbDono.Text
                End If
            End If
            mDataSet = Nothing
        End If

        strSQL = _
                "INSERT INTO TAS.Oil_TOPUP_LINES(" & _
                "TOPUP_NO," & _
                "DO_NO,SALE_PRODUCT_ID," & _
                "LOAD_HEADER_NO,BAY_NO,BAY_NAME," & _
               "METER_NO,SALE_PRODUCT_NAME," & _
               "COMPARTMENT_NO,PRESET," & _
               "TU_ID,TU_TYPE," & _
               "TU_NUMBER,VEHICLE_ID," & _
               "VEHICLE_TYPE,VEHICLE_NUMBER," & _
               "DRIVER_ID,DRIVER_NAME," & _
               "CARRIER_ID,CARRIER_NAME," & _
               "CUSTOMER_CODE,CUSTOMER_NAME," & _
               "SHIP_TO_CODE,SHIPTO_NAME," & _
               "DESCRIPTION," & _
               "CREATION_DATE,UPDATE_DATE,CREATED_BY," & _
               "J_COMPUTER)" & _
              " values(" & _
              Trim(TopUpNo) & ",'" & Trim(Do_no) & "'," & _
              "'" & Trim(SaleProduct_id) & "','" & Trim(CbLoadNo.Text) & "','" & Trim(bayNo) & "'," & _
              "'" & Trim(BayName) & "','" & Trim(CbMeterName.Text) & "','" & Trim(SaleProduct_Name) & "'," & _
             "'" & Trim(CbCompartment.Text) & "','" & Trim(txtPreset.Text) & "','" & Trim(txtTuid.Text) & "'," & _
             "'" & Trim(Tu_type) & "','" & Trim(TU_NUMBER) & "','" & Trim(vehicle_id) & "'," & _
             "'" & Trim(txtvehicletype.Text) & "','" & Trim(txtvehicle.Text) & "','" & Trim(txtDriverID.Text) & "'," & _
             "'" & Trim(txtDriverName.Text) & "','" & Trim(txtCarrierID.Text) & "','" & Trim(txtCarrierName.Text) & "'," & _
              "'" & Trim(txtCustomerID.Text) & "','" & Trim(txtCustomerName.Text) & "'," & _
             "'" & Trim(txtShipToID.Text) & "','" & Trim(txtShipToName.Text) & "','" & Trim(txtDesc.Text) & "'," & _
             "sysdate,sysdate,'" & mUserName & "'," & _
             "'" & mComputerName & "')"


        If Oradb.ExeSQL(strSQL) Then
            Call AddJournal(JournalType.Jevent, 505, 100, mUserName, 505201, TopUpNo, CbLoadNo.Text, txtTuid.Text)
            MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", vbInformation, "ระบบแจ้งว่า")
            Me.Close()
            setFrmWork(0)
            frmLoadTopUp.Showdata_GridMain()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If

    End Sub
 
    Private Sub btCancle_Click(sender As Object, e As EventArgs) Handles btCancle.Click
        Me.Close()
    End Sub
End Class