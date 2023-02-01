Public Class frmUtlShowdetial
    Dim vLoadNo As Long
    Dim StrTmp() As String
    Dim DriverID, DriveName As String
    Dim edit As Boolean = False
    Dim AE_LoadNo As String
    Public Sub GetLoadNo(iLoad As Long)
        vLoadNo = iLoad
    End Sub

    Private Sub InitialMain(ILoadNo As Long)
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        If ILoadNo = 0 Then Exit Sub
        ' edit = True
        strSQL = _
                            "select H.LOAD_HEADER_NO, " & _
                            "h.tu_card_no,  h.tu_id||' - '||h.tu_number as TuHead, " & _
                            "h.tu_id1||' - '||h.tu_number1 as TuTail, " & _
                            "h.driver_name ||'_'|| h.driver_id as DriverName," & _
                            "h.seal_use , h.seal_number " & _
                            ",L.DO_NO,DL.QUANTITY||' '||DL.SALE_UNIT AS  QUANTITY " & _
                            ",case when H.IS_WEIGHT_PROCESS =1 then 'ชั่งน้ำหนัก' " & _
                            "Else 'ไม่ชั่งน้ำหนัก' end STATUS_WEIGHT  ,DO.SHIPTO " & _
                            ",C.CUSTOMER_NAME ,H.CAPACITY||' '||H.UNIT as CAPACITY,H.CARRIER_NAME " & _
                            ",H.CREATION_DATE " & _
                            ",DO.MEASURE_MOTHOD,DO.CALCULATE_MOTHOD " & _
                             "FROM TAS.OIL_LOAD_HEADERS H " & _
                            ",TAS.OIL_LOAD_LINES L " & _
                            ",TAS.DO_HEADER DO " & _
                            ",TAS.DO_LINES DL " & _
                            ",TAS.CUSTOMER C " & _
                            ",TAS.SALE_PRODUCT S " & _
                            "Where h.LOAD_HEADER_NO = l.LOAD_HEADER_NO " & _
                            "and H.LOAD_HEADER_NO='" & Trim(ILoadNo) & "' " & _
                            "and L.DO_NO=DO.DO_NO(+) " & _
                            "and L.DO_NO=DL.DO_NO " & _
                            "and L.SALE_PRODUCT_ID = S.SALE_PRODUCT_ID (+) " & _
                            "and DO.CUSTOMER_CODE= C.CUSTOMER_CODE(+) " & _
                            "Order by L.DO_NO,L.COMPARTMENT_NO "
        Try
            If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                lblLoadNo.Text = IIf(IsDBNull(dt.Rows(0).Item("LOAD_HEADER_NO")), "", dt.Rows(0).Item("LOAD_HEADER_NO").ToString)
                lblCard.Text = IIf(IsDBNull(dt.Rows(0).Item("tu_card_no")), "", dt.Rows(0).Item("tu_card_no").ToString)
                lblTU1.Text = IIf(IsDBNull(dt.Rows(0).Item("TuHead")), "", dt.Rows(0).Item("TuHead").ToString)
                lblTU2.Text = IIf(IsDBNull(dt.Rows(0).Item("TuTail")), "", dt.Rows(0).Item("TuTail").ToString)
                lblDriver.Text = IIf(IsDBNull(dt.Rows(0).Item("DriverName")), "", dt.Rows(0).Item("DriverName").ToString)
                lblSealCount.Text = IIf(IsDBNull(dt.Rows(0).Item("seal_use")), "", dt.Rows(0).Item("seal_use").ToString)
                lblSealNum.Text = IIf(IsDBNull(dt.Rows(0).Item("seal_number")), "", dt.Rows(0).Item("seal_number").ToString)
                lblDate.Text = IIf(IsDBNull(dt.Rows(0).Item("creation_date")), "", dt.Rows(0).Item("creation_date").ToString)
                lblMaxweight.Text = IIf(IsDBNull(dt.Rows(0).Item("Capacity")), "", dt.Rows(0).Item("Capacity").ToString)
                lblCarrier.Text = IIf(IsDBNull(dt.Rows(0).Item("Carrier_name")), "", dt.Rows(0).Item("Carrier_name").ToString)
                lblCustomer.Text = IIf(IsDBNull(dt.Rows(0).Item("Customer_name")), "", dt.Rows(0).Item("Customer_name").ToString)
                lblShipto.Text = IIf(IsDBNull(dt.Rows(0).Item("shipto")), "", dt.Rows(0).Item("shipto").ToString)
                lblPreset.Text = IIf(IsDBNull(dt.Rows(0).Item("quantity")), "", dt.Rows(0).Item("quantity").ToString)
                lblWeight.Text = IIf(IsDBNull(dt.Rows(0).Item("STATUS_WEIGHT")), "", dt.Rows(0).Item("STATUS_WEIGHT").ToString)
                lblDoNo.Text = getDOselect(Trim(ILoadNo))
                'cmbMeasueQTY.SelectedIndex = Val(IIf(IsDBNull(dt.Rows(0).Item("MEASURE_MOTHOD")), "0", dt.Rows(0).Item("MEASURE_MOTHOD").ToString))
                'cmbCalQTY.SelectedIndex = Val(IIf(IsDBNull(dt.Rows(0).Item("CALCULATE_MOTHOD")), "0", dt.Rows(0).Item("CALCULATE_MOTHOD").ToString))
                Call ShowDetailVehicle()
                Call ShowdetailCompartMent(Trim(ILoadNo))
            End If
        Catch ex As Exception

        End Try
        mDataSet = Nothing

    End Sub
    Private Function getDOselect(ILoadNo As String) As String
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        getDOselect = ""
        strSQL = _
                     "select    load.get_do_select('" & Trim(ILoadNo) & "') as doSelect   from  dual "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                getDOselect = IIf(IsDBNull(dt.Rows(i).Item("doSelect")), "", dt.Rows(i).Item("doSelect"))
                If getDOselect <> "" Then
                    If Mid(getDOselect, 1, 1) = "," Then
                        getDOselect = Mid(getDOselect, InStr(1, getDOselect, ",") + 1, Len(getDOselect))
                    End If
                End If
            End If
        End If
        mDataSet = Nothing
    End Function
    Private Sub GetdetailProduct()

        Dim tmpDO() As String
        Dim StrTmp As String
        Dim tmpstrQL As String
        Dim i As Integer
        StrTmp = ""
        tmpDO = Split(Trim(lblDoNo.Text), ",")
        For i = 0 To UBound(tmpDO)
            If i > 0 Then
                StrTmp = StrTmp & ","
            End If
            StrTmp = StrTmp & "'"
            StrTmp = StrTmp & tmpDO(i)
            StrTmp = StrTmp & "'"
        Next i
        Dim index As Integer = MSGridEdit.CurrentRow.Index
        If MSGridEdit.Rows(index).Cells(1).Value = "" Then
            Exit Sub
        End If
        Dim strDono = MSGridEdit.Rows(index).Cells(1).Value.ToString
        If strDono = "" Then
            Exit Sub
        End If
        tmpstrQL = "and  t.do_no = '" & strDono & "'"
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        sql_str = " select  t.do_no ,   t.material_no || ' ' || SALE_PRODUCT_NAME  as product  , t.quantity "
        sql_str = sql_str & " from  tas.do_lines   t , tas.sale_product s "
        sql_str = sql_str & " Where t.material_no = s.sale_product_id "
        sql_str = sql_str & " " & tmpstrQL & "  "
        sql_str = sql_str & " order  by t.material_no "
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0

            'Column5.ReadOnly = True

            If dt.Rows.Count > i Then
                'Column5.Name = "test"
                'MessageBox.Show(Column5.Items.IndexOf(IIf(IsDBNull(dt.Rows(i).Item("product")), "", dt.Rows(i).Item("product").ToString)))
                If Column5.Items.IndexOf(IIf(IsDBNull(dt.Rows(i).Item("product")), "", dt.Rows(i).Item("product").ToString)) = -1 Then
                    Column5.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("product")), "", dt.Rows(i).Item("product").ToString))
                End If
                MSGridEdit.Item(4, index).Value = IIf(IsDBNull(dt.Rows(i).Item("product")), "", dt.Rows(i).Item("product").ToString)
            End If
        End If
        mDataSet = Nothing
    End Sub
    Private Sub GetdetailDO()
        Dim tmpDO() As String
        Dim StrTmp As String
        Dim tmpstrQL As String
        Dim i As Integer
        StrTmp = ""
        tmpDO = Split(Trim(lblDoNo.Text), ",")
        For i = 0 To UBound(tmpDO)
            If i > 0 Then
                StrTmp = StrTmp & ","
            End If
            StrTmp = StrTmp & "'"
            StrTmp = StrTmp & tmpDO(i)
            StrTmp = StrTmp & "'"
        Next i
        tmpstrQL = "and  t.do_no in" & "(" & StrTmp & ")"

        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        sql_str = " select  t.do_no ,   t.material_no || ' ' || SALE_PRODUCT_NAME  as product  , t.quantity "
        sql_str = sql_str & " from  tas.do_lines   t , tas.sale_product s "
        sql_str = sql_str & " Where t.material_no = s.sale_product_id "
        sql_str = sql_str & " " & tmpstrQL & "  "
        sql_str = sql_str & " order  by t.material_no "
        MSGridTotDo.Rows.Clear()
        'Column5.Items.Clear()
        'Column5.Name = "tet"


        Dim n As Integer = 0
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            MSGridTotDo.RowCount = 0
            Do While dt.Rows.Count > i
                MSGridTotDo.RowCount = MSGridTotDo.RowCount + 1
                MSGridTotDo.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Do_no")), "", dt.Rows(i).Item("Do_no").ToString)
                MSGridTotDo.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("product")), "", dt.Rows(i).Item("product").ToString)
                MSGridTotDo.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("quantity")), "", dt.Rows(i).Item("quantity").ToString)
                n = n + CType(IIf(IsDBNull(dt.Rows(i).Item("quantity")), "", dt.Rows(i).Item("quantity").ToString), Integer)
                i = i + 1
            Loop

        End If
        txtToT.Text = n
        mDataSet = Nothing
    End Sub
    Private Sub ShowDetailVehicle()
        Dim strSQL As String
        Dim i As Long
        Dim ValCompTruck As Long
        Dim ValCompTailer As Long
        Dim StringCompTruck As String
        Dim StringCompTailer As String
        Dim vTu1 As String
        Dim vTu2 As String
        Dim vTu_id1() As String
        Dim vTu_id2() As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        MSGridEdit.RowCount = 1
        StrTmp = Split(lblDriver.Text, "_")
        DriverID = Trim(StrTmp(1))
        DriveName = Trim(StrTmp(0))

        vTu_id1 = Split(Trim(lblTU1.Text), " - ")
        vTu1 = vTu_id1(1)

        If Trim(lblTU2.Text) = "-" Then
            vTu2 = "0"
        Else
            vTu_id2 = Split(Trim(lblTU2.Text), " - ")
            vTu2 = vTu_id2(1)
        End If

        If lblCard.Text <> "" And MSGridEdit.RowCount = 1 Then
            strSQL = "select t.compartments,t.comp_1,comp_2,comp_3,comp_4 , " & _
                            " comp_5,comp_6,comp_7,comp_8,comp_9,comp_10,comp_11,comp_12, " & _
                            " comp_13,comp_14,comp_15,comp_16,comp_17,comp_18,comp_19,comp_20 " & _
                            " from transport_unit t " & _
                            " Where t.TU_NUMBER = " & Trim(vTu1) & ""
            If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                If dt.Rows.Count > 0 Then
                    Do While dt.Rows.Count > i
                        ValCompTruck = IIf(IsDBNull(dt.Rows(i).Item("compartments")), 0, dt.Rows(i).Item("compartments"))
                        StringCompTruck = dt.Rows(i).Item("comp_1") & "," & dt.Rows(i).Item("comp_2") & "," & dt.Rows(i).Item("comp_3") & ","
                        StringCompTruck = StringCompTruck & dt.Rows(i).Item("comp_4") & "," & dt.Rows(i).Item("comp_5") & "," & dt.Rows(i).Item("comp_6") & ","
                        StringCompTruck = StringCompTruck & dt.Rows(i).Item("comp_7") & "," & dt.Rows(i).Item("comp_8") & "," & dt.Rows(i).Item("comp_9") & ","
                        StringCompTruck = StringCompTruck & dt.Rows(i).Item("comp_10") & "," & dt.Rows(i).Item("comp_11") & "," & dt.Rows(i).Item("comp_12") & ","
                        StringCompTruck = StringCompTruck & dt.Rows(i).Item("comp_13") & "," & dt.Rows(i).Item("comp_14") & "," & dt.Rows(i).Item("comp_15") & ","
                        StringCompTruck = StringCompTruck & dt.Rows(i).Item("comp_16") & "," & dt.Rows(i).Item("comp_17") & "," & dt.Rows(i).Item("comp_18") & ","
                        StringCompTruck = StringCompTruck & dt.Rows(i).Item("comp_19") & "," & dt.Rows(i).Item("comp_20")
                        i = i + 1
                    Loop
                End If
            End If
        End If

        If Trim(lblTU2.Text) <> "-" Then
            strSQL = "select t.compartments,t.comp_1,comp_2,comp_3,comp_4 , " & _
                       " comp_5,comp_6,comp_7,comp_8,comp_9,comp_10,comp_11,comp_12, " & _
                       " comp_13,comp_14,comp_15,comp_16,comp_17,comp_18,comp_19,comp_20 " & _
                       " from transport_unit t" & _
                       " Where t.TU_NUMBER ='" & Trim(vTu2) & "'"
            If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                i = 0
                Do While dt.Rows.Count > i
                    'If dt.Rows(i).Item("compartments").Equals(0) Or dt.Rows(i).Item("compartments").Equals("") Then Exit Sub
                    ValCompTailer = IIf(IsDBNull(dt.Rows(i).Item("compartments")), 0, dt.Rows(i).Item("compartments"))
                    StringCompTailer = dt.Rows(i).Item("comp_1") & "," & dt.Rows(i).Item("comp_2") & "," & dt.Rows(i).Item("comp_3") & ","
                    StringCompTailer = StringCompTailer & dt.Rows(i).Item("comp_4") & "," & dt.Rows(i).Item("comp_5") & "," & dt.Rows(i).Item("comp_6") & ","
                    StringCompTailer = StringCompTailer & dt.Rows(i).Item("comp_7") & "," & dt.Rows(i).Item("comp_8") & "," & dt.Rows(i).Item("comp_9") & ","
                    StringCompTailer = StringCompTailer & dt.Rows(i).Item("comp_10") & "," & dt.Rows(i).Item("comp_11") & "," & dt.Rows(i).Item("comp_12") & ","
                    StringCompTailer = StringCompTailer & dt.Rows(i).Item("comp_13") & "," & dt.Rows(i).Item("comp_14") & "," & dt.Rows(i).Item("comp_15") & ","
                    StringCompTailer = StringCompTailer & dt.Rows(i).Item("comp_16") & "," & dt.Rows(i).Item("comp_17") & "," & dt.Rows(i).Item("comp_18") & ","
                    StringCompTailer = StringCompTailer & dt.Rows(i).Item("comp_19") & "," & dt.Rows(i).Item("comp_20")
                    i = i + 1
                Loop
            End If
            mDataSet = Nothing
        End If
        Call GenCompartment(ValCompTruck, ValCompTailer, lblTU1.Text, StringCompTruck, lblTU2.Text, StringCompTailer)
        Call GetdetailDO()
    End Sub
    Private Sub GenCompartment(ByVal iCompTruck As Long, ByVal iCompTailer As Long, ByVal truck As String, ByVal StringCompTruck As String, ByVal Tailer As String, ByVal StringCompTailer As String)
        'MessageBox.Show("genCompartment")
        Dim CutStringTruck() As String
        Dim CutStringTailer() As String
        CutStringTruck = Split(StringCompTruck, ",")
        CutStringTailer = Split(StringCompTailer, ",")
        MSGridEdit.Rows.Clear()
        'MessageBox.Show(iCompTruck & "--->" & iCompTailer)
        Dim i = 0
        Try
            MSGridEdit.RowCount = 0
            If iCompTruck > 0 And StringCompTruck <> "" Then
                Do While iCompTruck > i 'And MSGridEdit.RowCount > i

                    If Not edit Then
                        MSGridEdit.RowCount = MSGridEdit.RowCount + 1
                    End If
                    MSGridEdit.Item(0, i).Value = i + 1
                    MSGridEdit.Item(2, i).Value = truck
                    MSGridEdit.Item(3, i).Value = CutStringTruck(i)
                    'MSGridAddEdit.Item(6, i).Value = i + 1
                    i = i + 1
                Loop
            End If
            If iCompTailer > 0 And StringCompTailer <> "" Then
                Dim j = 0
                Do While iCompTailer > j 'And MSGridEdit.RowCount > j
                    If Not edit Then
                        MSGridEdit.RowCount = MSGridEdit.RowCount + 1
                    End If

                    MSGridEdit.Item(0, j + i).Value = j + i + 1
                    MSGridEdit.Item(2, j + i).Value = Tailer
                    MSGridEdit.Item(3, j + i).Value = CutStringTailer(j)
                    'MSGridEdit.Item(6, i).Value = j + 1
                    j = j + 1
                Loop

            End If

        Catch ex As Exception

        End Try


    End Sub
    Private Sub InitialCombo()
        Dim strSQL As String
        Dim RecTot As Long
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        strSQL = _
                    "select   t.TYPE_ID , t.TYPE_NAME   from tas.v_do_measure_mothod  t order by   t.TYPE_ID "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            RecTot = dt.Rows.Count
            If RecTot > 0 Then
                cmbMeasueQTY.Items.Clear()
                Do While dt.Rows.Count > i
                    cmbMeasueQTY.Items.Add(dt.Rows(0).Item("TYPE_NAME"))
                    i = i + 1
                Loop
                'cmbMeasueQTY.SelectedIndex = 0
                cmbMeasueQTY.Enabled = False
            End If

        End If

        strSQL = _
            "select  t.TYPE_ID , t.TYPE_NAME   from tas.v_do_calculate_mothod  t  order by   t.TYPE_ID "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            RecTot = dt.Rows.Count
            If RecTot > 0 Then
                If RecTot > 0 Then
                    cmbCalQTY.Items.Clear()
                    Do While dt.Rows.Count > i
                        cmbCalQTY.Items.Add(dt.Rows(0).Item("TYPE_NAME"))
                        i = i + 1
                    Loop
                    'cmbCalQTY.SelectedIndex = 1
                    cmbCalQTY.Enabled = False
                End If
            End If
        End If
        mDataSet = Nothing
    End Sub


    Private Sub ShowdetailCompartMent(ByVal ILoadNo As String)

        Dim strSQL As String
        Dim i As Integer
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        strSQL = _
        "select  ol.compartment_no , " & _
        " ol.do_no , ol.sale_product_id ||'  '|| ol.sale_product_name as  sale_product " & _
        " ,ol.advice , ol.batch_status " & _
        " from tas.oil_load_lines  ol" & _
        " where ol.load_header_no ='" & Trim(ILoadNo) & "' " & _
        " order by ol.compartment_no "

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            'If edit Then
            '    MSGridEdit.RowCount = 0
            'End If

            i = 0
            Do While dt.Rows.Count > i
                'If edit Then
                '    MSGridEdit.RowCount = MSGridEdit.RowCount + 1
                'End If
                'MSGridEdit.RowCount = MSGridEdit.RowCount + 1
                ' MSGridEdit.Item(0, i).Value = i + 1
                Dim CompNo As Integer = IIf(IsDBNull(dt.Rows(i).Item("compartment_no")), "", dt.Rows(i).Item("compartment_no"))
                If Column5.Items.IndexOf(IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT")), "", dt.Rows(i).Item("SALE_PRODUCT").ToString)) = -1 Then
                    Column5.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT")), "", dt.Rows(i).Item("SALE_PRODUCT").ToString))
                End If
                If Column2.Items.IndexOf(IIf(IsDBNull(dt.Rows(i).Item("Do_no")), "", dt.Rows(i).Item("Do_no").ToString)) = -1 Then
                    Column2.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("Do_no")), "", dt.Rows(i).Item("Do_no").ToString))
                End If
                MSGridEdit.Item(1, CompNo - 1).Value = IIf(IsDBNull(dt.Rows(i).Item("Do_no")), "", dt.Rows(i).Item("Do_no").ToString)
                MSGridEdit.Item(4, CompNo - 1).Value = IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT")), "", dt.Rows(i).Item("SALE_PRODUCT").ToString)
                MSGridEdit.Item(5, CompNo - 1).Value = IIf(IsDBNull(dt.Rows(i).Item("advice")), "", dt.Rows(i).Item("advice").ToString)
                MSGridEdit.Item(6, CompNo - 1).Value = "-"

                i = i + 1
            Loop
        End If
        mDataSet = Nothing

    End Sub
    Private Sub frmUtlShowdetial_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            Call InitialCombo()
            Call InitialMain(vLoadNo)

            'Call InitialMSFlexGrid()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub MSGridEdit_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MSGridEdit.CellClick
        If e.ColumnIndex = 4 Or e.ColumnIndex = 1 Then
            GetdetailProduct()
        End If
    End Sub

    Private Sub MSGridEdit_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MSGridEdit.CellEndEdit
        assTxtOrder()
        If MSGridEdit.Rows(e.RowIndex).Cells(6).Value = "-" Then
            If MSGridEdit.Rows(e.RowIndex).Cells(5).Value = "" Or MSGridEdit.Rows(e.RowIndex).Cells(5).Value = "0" Then
                MSGridEdit.Rows(e.RowIndex).Cells(6).Value = "D"
            Else
                MSGridEdit.Rows(e.RowIndex).Cells(6).Value = "E"
            End If
        ElseIf MSGridEdit.Rows(e.RowIndex).Cells(6).Value = "E" Then
            If (MSGridEdit.Rows(e.RowIndex).Cells(5).Value = "" Or MSGridEdit.Rows(e.RowIndex).Cells(5).Value = "0") Then
                MSGridEdit.Rows(e.RowIndex).Cells(6).Value = "D"
            Else
                MSGridEdit.Rows(e.RowIndex).Cells(6).Value = "E"
            End If
        ElseIf MSGridEdit.Rows(e.RowIndex).Cells(6).Value = "D" Then
            If (MSGridEdit.Rows(e.RowIndex).Cells(5).Value = "" Or MSGridEdit.Rows(e.RowIndex).Cells(5).Value = "0") Then
                MSGridEdit.Rows(e.RowIndex).Cells(6).Value = "D"
            Else
                MSGridEdit.Rows(e.RowIndex).Cells(6).Value = "E"
            End If
        Else
            If MSGridEdit.Rows(e.RowIndex).Cells(5).Value <> "" And MSGridEdit.Rows(e.RowIndex).Cells(5).Value <> "0" Then
                MSGridEdit.Rows(e.RowIndex).Cells(6).Value = "A"
            End If

        End If
        If e.ColumnIndex = 1 Then
            GetdetailProduct()
        End If
    End Sub
    Sub assTxtOrder()
        Dim i As Integer = 0
        txtOrder.Text = 0
        Do While MSGridEdit.RowCount > i
            'MessageBox.Show("test = " & MSGridEdit.Rows(i).Cells(5).Value)

            If MSGridEdit.Rows(i).Cells(5).Value = "" Or MSGridEdit.Rows(i).Cells(5).Value = "0" Then
                MSGridEdit.Rows(i).Cells(5).Value = "0"
            Else

                If CType(MSGridEdit.Rows(i).Cells(3).Value, Integer) < CType(MSGridEdit.Rows(i).Cells(5).Value, Integer) Then

                    MessageBox.Show("ปริมาณสั่งเติมมากกว่าความจุช่องรถ")
                    MSGridEdit.Rows(i).Cells(5).Value = "0"
                End If
                TxtOrder.Text = CType(CType(TxtOrder.Text, Integer) + CType(MSGridEdit.Rows(i).Cells(5).Value, Integer), String)
            End If

            i = i + 1
        Loop
    End Sub

    Private Sub MSGridEdit_CellLeave(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MSGridEdit.CellLeave
        If e.ColumnIndex = 5 Then
            '-----------
            assTxtOrder()
            '-----------
        End If
    End Sub

    'Private Sub StatusPreset()
    '    Dim i As Integer
    '    With MSGridEdit
    '        For i = 1 To .rows - 1
    '            If .TextMatrix(i, 6) <> .TextMatrix(i, 11) Then
    '                If .TextMatrix(i, 6) = "" Then
    '                    .TextMatrix(i, 10) = "D"
    '                ElseIf .TextMatrix(i, 6) < .TextMatrix(i, 11) Then
    '                    .TextMatrix(i, 10) = "E"
    '                ElseIf .TextMatrix(i, 6) > .TextMatrix(i, 11) Then
    '                    If .TextMatrix(i, 11) = "" Then
    '                        .TextMatrix(i, 10) = "A"
    '                    Else
    '                        .TextMatrix(i, 10) = "E"
    '                    End If
    '                End If
    '            Else
    '                .TextMatrix(i, 10) = "-"
    '                .TextMatrix(i, .cols - 1) = "-"
    '                If .TextMatrix(i, 11) = "" Then
    '                    .TextMatrix(i, 10) = ""
    '                End If
    '            End If
    '        Next i
    '    End With
    'End Sub

    'Private Sub SumStatus()
    '    Dim i As Integer
    '    With MSGridEdit
    '        For i = 1 To .RowCount - 1
    '            If .Item(i, 6).Value = "A" Then
    '                .Item(i, 7).Value = "A"
    '            ElseIf .Item(i, 6).Value = "D" Then
    '                If .Item(i, 6) = "" Then
    '                    .Item(i, .cols - 1) = "D"
    '                Else
    '                    .Item(i, .cols - 1) = "E"
    '                End If
    '            ElseIf .Item(i, 10) = "E" Then
    '                .Item(i, .ColumnCount - 1) = "E"
    '            ElseIf .Item(i, 10) = "" Then
    '                .Item(i, .ColumnCount - 1) = "-"
    '            Else
    '                If .Item(i, 9) = "E" Then
    '                    .Item(i, .ColumnCount - 1) = "E"
    '                Else
    '                    If .Item(i, 8) = "E" Then .TextMatrix(i, .ColumnCount - 1) = "E"
    '                End If
    '            End If
    '        Next i
    '    End With
    'End Sub

    Private Function EditData() As Boolean
        'On Error GoTo Err_Func
        Dim strSQL As String
        Dim strTUnumber() As String
        Dim strSaleProduct() As String
        Dim i As Integer


        If Val(txtOrder.Text) > Val(txtToT.Text) Then
            MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "เนื่องจากปริมาณสั่งเติมมีจำนวนรวมากกว่าปริมาณสั่งซื้อ  กรุณาตรวจสอบข้อมูลอีกครั้ง", vbCritical, "พบข้อผิดพลาด")
            Exit Function
        End If

        If MsgBox("ท่านต้องการบันทึกข้อมูลหรือไม่?", vbInformation + vbYesNo) = vbNo Then
            Exit Function
        End If
        'Call StatusPreset()
        'Call SumStatus()

        strSQL = " Delete   gac.tlas_edit_compartment   "
        Oradb.ExeSQL(strSQL)

        i = 0
        Do While i < MSGridEdit.RowCount

            If Not Trim(MSGridEdit.Item(6, i).Value).Equals("") And Not Trim(MSGridEdit.Item(6, i).Value).Equals("-") Then
                strTUnumber = Split(Trim(MSGridEdit.Item(2, i).Value), "-")
                strSaleProduct = Split(Trim(MSGridEdit.Item(4, i).Value), " ")
                strSQL = " "
                strSQL = strSQL & " Begin "
                strSQL = strSQL & " LOAD.TLAS_LOADING_UPDATE_DATA_1( "
                strSQL = strSQL & Val(Trim(MSGridEdit.Item(0, i).Value)) & "," & Val(Trim(MSGridEdit.Item(3, i).Value)) & ","
                strSQL = strSQL & Val(Trim(MSGridEdit.Item(5, i).Value)) & ",'" & Trim(MSGridEdit.Item(1, i).Value) & "',"
                strSQL = strSQL & Val(Trim(strSaleProduct(0))) & "," & Val(MSGridEdit.Item(0, i).Value) & "," & Trim(strTUnumber(2)) & ",'" & Trim(MSGridEdit.Item(6, i).Value) & "' ,''); "
                strSQL = strSQL & " End; "
                If Oradb.ExeSQL(strSQL) Then
                    EditData = True
                Else
                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                    EditData = False
                End If

            End If
            i = i + 1
        Loop
        '-----------" & Trim(MSGridAddEdit.Item(8, i).Value) & "
        AE_LoadNo = Val(lblLoadNo.Text)

        If EditData Then
            strSQL = ""
            strSQL = strSQL & "Begin "
            strSQL = strSQL & " LOAD.TAS_LOADING_EDIT_LOAD("
            strSQL = strSQL & "" & AE_LoadNo & ", ' - ', '" & mUserName & "',"
            strSQL = strSQL & "'" & mComputerName & "',:ret_check,:ret_msg); "
            strSQL = strSQL & " End;"


            Dim Oraparam As New COraParameter
            Dim RET_CHECK As Object
            Dim RET_MSG As Object
            With Oraparam
                .CreateOracleParamOutput("ret_check", COracle._OracleDbType.OraInt32)
                .CreateOracleParamOutput("ret_msg", COracle._OracleDbType.OraVarchar2, 512)
            End With

            Dim bRet As Boolean = False
            If Oradb.ExeSQL(strSQL, Oraparam) Then
                RET_CHECK = Oraparam.GetOraclParamValue("ret_check")
                RET_MSG = Oraparam.GetOraclParamValue("ret_msg")
                If Oraparam.GetOraclParamValue("ret_check") <> 0 Then
                    MsgBox(IIf(IsDBNull(Oraparam.GetOraclParamValue("ret_msg")), "", Oraparam.GetOraclParamValue("ret_msg").ToString), vbCritical, "เกิดข้อผิดพลาด")

                    bRet = False
                Else
                    bRet = True
                End If


            End If

            '-------------------
    
        End If
        If EditData Then
            MsgBox("แก้ไขการจัดช่องเติมของหมายเลข Load No '" & lblLoadNo.Text & "'  เรียบร้อยแล้ว""")
            Me.Close()
        Else
            MsgBox("ไม่มีการแก้ไขการจัดช่องเติมของหมายเลข Load No '" & lblLoadNo.Text & "' ")
            Me.Close()
            Exit Function
        End If

        Exit Function
        'If EditData Then
        '    TrueFrom = True
        '    Call AddJournal(Jevent, P_CurScreenID, 100, P_ModifyUser, 502202, Trim(lblLoadNo), Trim(lblTU1), Trim(lblDriver))
        'Else
        '    TrueFrom = True
        '    If chkCalType.value = 1 Then
        '        Call InitialParametersCalType()
        '        If editRegistor_update_cal_type(AE_LoadNo, cmbMeasueQTY.ListIndex, cmbCalQTY.ListIndex) Then
        '            Call RemoveParameterCalType()
        '        End If
        '    End If
        '    Exit Function
        'End If

Err_Func:
    End Function


    Private Sub Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Close()
    End Sub

    Private Sub chkCalType_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCalType.CheckedChanged
        cmbMeasueQTY.Enabled = True
        cmbCalQTY.Enabled = True
    End Sub

    Private Sub btSave_Click(sender As System.Object, e As System.EventArgs) Handles btSave.Click
        If EditData() Then
        End If
    End Sub

    Private Sub btCancle_Click(sender As System.Object, e As System.EventArgs) Handles btCancle.Click
        Me.Close()
    End Sub
End Class