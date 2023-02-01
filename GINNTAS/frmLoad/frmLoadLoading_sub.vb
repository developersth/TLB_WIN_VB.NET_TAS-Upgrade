Imports System.Threading
Public Class frmLoadLoading_sub
    Dim edit As Boolean = False
    Dim StrTmp() As String
    Dim DriverID As String
    Dim DriveName As String
    Dim iVehicleNo As String
    Dim ErrChk As Boolean
    Dim P_ComputerName As String = System.Net.Dns.GetHostName
    Dim Row_Old As Integer
    Dim Row_New As Integer
    Dim COL_OLD As Integer
    Dim ChkFrmCreateLoad As Integer
    Const INTRO_RPT_ID = 52010029
    Dim WorkFlow As Long
    Dim AE_LoadNo As String
    Dim Waiting As Boolean = False
    Public TimeOut As Long
    Dim BeforAddRows As Long
    Dim StatusAddrow As Boolean
    Public RemarkCancelOK As Boolean
    Public Load_no As String
    Dim arCard() As String
    Public DoList As String
    Dim SealCount As String
    Dim SealNumber As String
    Public SealLast As String
    Private TuTail As String
    Public AELoadNo As String

    Public Sub PrintReport(ByVal pLoadNo As Long)

        Dim rptFileName As String

        Try
            rptFileName = GetReportFileName(52010029)
            'frmrptShowReport.Close()
            With frmrptShowReport
                .mRptFileName = rptFileName
                .mParameter = pLoadNo
                '.ShowReport(strSQL)
                Thread.Sleep(1000)
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ClearDataAddEdit()
        cbCard.Text = ""
        cbTruck.Text = ""
        cbTu_Tail.Text = ""
        cbDriver.Text = ""
        txtDo.Text = ""
        txtSealNumber.Text = ""
        txtAmoutSeal.Text = ""
        MSGridAddEdit.Rows.Clear()
        MSGridTotDo.Rows.Clear()
        txtToT.Text = ""
        txtOrder.Text = ""
        txtLoadNo.Text = ""
        txtLoadNo.Text = GetNextID()
    End Sub

    Function assignDropDown() As Boolean
        Dim sql_str As String
        sql_str = " select c.card_no,c.tu_number,c.card_no,t.tu_id  from tas.card c,tas.transport_unit t  where c.card_type=0  and c.is_enabled=1and c.tu_number=t.tu_number(+)  "
        sql_str = sql_str & " and not exists(select  h.tu_card_no "
        sql_str = sql_str & " from  oil_load_entrycard  h where c.card_no=h.tu_card_no  ) order by c.card_no "
        assignDropDown(sql_str, "card_no", cbCard)

        sql_str = "select T.TU_ID,T.TU_NUMBER,T.TU_ID||'_'|| T.TU_NUMBER  as  TuName "
        sql_str = sql_str & " from TRANSPORT_UNIT T order by  T.TU_ID,T.TU_NUMBER"
        assignDropDown(sql_str, "tUname", cbTruck)
        assignDropDown(sql_str, "tUname", cbTu_Tail)

        sql_str = "select t.first_name||'  '||t.last_name ||'_'||  t.driver_id    as  driver  from driver t order by t.driver_id"
        assignDropDown(sql_str, "driver", cbDriver)
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

    Private Function GetNextID() As Integer
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        sql_str = "select U.LAST_NUMBER "
        sql_str = sql_str & "from USER_SEQUENCES U "
        sql_str = sql_str & "where U.SEQUENCE_NAME='LOAD_SEQ'"
        ' "select max(t.load_header_no+1) as LAST_NUMBER  from tas.oil_load_headers t"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Return IIf(IsDBNull(dt.Rows(0).Item("LAST_NUMBER")), "", dt.Rows(0).Item("LAST_NUMBER").ToString)

        End If
        Return 1
    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddDo.Click
        frmLoadDoList.Close()
        frmLoadDoList.ShowDialog()
    End Sub

    Private Sub cmdAssignComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAssignComp.Click
        MSGridAddEdit.Rows.Clear()
        MSGridTotDo.Rows.Clear()
        cmdAssignComp_Click()
        initComDo()
        'initComProduct()
        GetdetailProduct()
        assTxtOrder()
    End Sub

    Sub initComDo()
        Column2.Items.Clear()
        Column5.Items.Clear()
        Dim arrDo = Split(txtDo.Text, ",")
        Dim i As Integer = 0
        While arrDo.Length > i
            Column2.Items.Add(arrDo(i))
            i = i + 1
        End While
        For index As Integer = 0 To MSGridAddEdit.Rows.Count - 1
            MSGridAddEdit.Rows(index).Cells("Column2").Value = arrDo(0)
        Next
    End Sub


    Private Sub GenCompartment(ByVal iCompTruck As Long, ByVal iCompTailer As Long, ByVal truck As String, ByVal StringCompTruck As String, ByVal Tailer As String, ByVal StringCompTailer As String)
        'MessageBox.Show("genCompartment")
        Dim CutStringTruck() As String
        Dim CutStringTailer() As String
        Dim StrVolumeTotal As Integer
        Dim strTruckVolumeTotal As Integer
        CutStringTruck = Split(StringCompTruck, ",")
        CutStringTailer = Split(StringCompTailer, ",")
        StrVolumeTotal = Val(txtToT.Text)
        'MessageBox.Show(iCompTruck & "--->" & iCompTailer)

        Dim i = 0
        If iCompTruck > 0 And StringCompTruck <> "" Then
            Do While iCompTruck > i 'And MSGridAddEdit.RowCount > i
                If Not edit Then
                    MSGridAddEdit.RowCount = MSGridAddEdit.RowCount + 1
                End If
                '' check total volume Truck <= Do volume
                'strTruckVolumeTotal = CutStringTruck(i)

                If iCompTruck = 1 Then
                    MSGridAddEdit.Item(0, i).Value = i + 1
                    MSGridAddEdit.Item(2, i).Value = truck
                    MSGridAddEdit.Item(3, i).Value = CutStringTruck(i)
                    If Not edit Then
                        MSGridAddEdit.Item(5, i).Value = Val(txtToT.Text)
                    End If
                    MSGridAddEdit.Item(6, i).Value = i + 1
                Else
                    MSGridAddEdit.Item(0, i).Value = i + 1
                    MSGridAddEdit.Item(2, i).Value = truck
                    MSGridAddEdit.Item(3, i).Value = CutStringTruck(i)
                    If Not edit Then
                        MSGridAddEdit.Item(5, i).Value = CutStringTruck(i)
                        'If CutStringTruck(i) > StrVolumeTotal Then
                        '    MSGridAddEdit.Item(5, i).Value = CutStringTruck(i)
                        'Else
                        'End If
                    End If
                    MSGridAddEdit.Item(6, i).Value = i + 1

                    End If
                    i = i + 1

            Loop
        End If
        If iCompTailer > 0 And StringCompTailer <> "" Then
            Dim j = 0
            i = 0
            Do While iCompTailer > j 'And MSGridAddEdit.RowCount > j
                If Not edit Then
                    MSGridAddEdit.RowCount = MSGridAddEdit.RowCount + 1
                End If
                If iCompTailer = 1 Then
                    MSGridAddEdit.Item(0, j + i).Value = j + i + 1
                    MSGridAddEdit.Item(2, j + i).Value = Tailer
                    MSGridAddEdit.Item(3, j + i).Value = CutStringTailer(j)
                    If Not edit Then
                        MSGridAddEdit.Item(5, j + i).Value = Val(txtToT.Text)
                    End If
                    MSGridAddEdit.Item(6, j).Value = j + 1
                    j = j + 1
                Else
                    MSGridAddEdit.Item(0, j + i).Value = j + i + 1
                    MSGridAddEdit.Item(2, j + i).Value = Tailer
                    MSGridAddEdit.Item(3, j + i).Value = CutStringTailer(j)
                    If Not edit Then
                        MSGridAddEdit.Item(5, j + i).Value = CutStringTailer(j)
                    End If
                    MSGridAddEdit.Item(6, j).Value = j + 1

                End If
                j = j + 1
            Loop
        End If

    End Sub

    Private Sub cmdAssignComp_Click()
        'MessageBox.Show("cmdAssignComp")
        Dim i As Long
        Dim ValCompTruck As Long
        Dim ValCompTailer As Long
        Dim StringCompTruck As String = ""
        Dim StringCompTailer As String = ""
        Dim vTu1 As String
        Dim vTu2 As String
        Dim vTu_id1() As String
        Dim vTu_id2() As String
        If cbDriver.Text = "" Then
            MsgBox("คุณยังไม่ได้เลือกพนักงานขับรถ กรุณาเลือกพนักงานขับรถก่อน ", vbCritical, "ระบบแจ้งว่า")
            Exit Sub
        Else
            StrTmp = Split(cbDriver.Text, "_")
            DriverID = Trim(StrTmp(1))
            DriveName = Trim(StrTmp(0))
        End If

        If cbTruck.Text = "" Then
            vTu1 = "0"
        Else
            vTu_id1 = Split(Trim(cbTruck.Text), "_")
            vTu1 = vTu_id1(1)
        End If

        If cbTu_Tail.Text = "" Then
            vTu2 = "0"
        Else
            vTu_id2 = Split(Trim(cbTu_Tail.Text), "_")
            vTu2 = vTu_id2(1)
        End If

        If Not edit Then

            If Not runProcVehicle(Trim(vTu1), Trim(vTu2), Trim(DriverID)) Then
                Exit Sub
            End If
            If CheckParameterProcedure() = False Then Exit Sub

        End If

        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable


        sql_str = "select t.compartments,t.comp_1,comp_2,comp_3,comp_4 , "
        sql_str = sql_str & " comp_5,comp_6,comp_7,comp_8,comp_9,comp_10,comp_11,comp_12, "
        sql_str = sql_str & " comp_13,comp_14,comp_15,comp_16,comp_17,comp_18,comp_19,comp_20 "
        sql_str = sql_str & " from transport_unit t "
        sql_str = sql_str & " Where t.TU_NUMBER = " & Trim(vTu1) & ""
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            ValCompTruck = IIf(IsDBNull(dt.Rows(i).Item("compartments")), "", dt.Rows(i).Item("compartments").ToString)
            StringCompTruck = IIf(IsDBNull(dt.Rows(0).Item("comp_1")), "", dt.Rows(0).Item("comp_1").ToString)
            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_2")), "", dt.Rows(0).Item("comp_2").ToString)
            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_3")), "", dt.Rows(0).Item("comp_3").ToString)
            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_4")), "", dt.Rows(0).Item("comp_4").ToString)
            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_5")), "", dt.Rows(0).Item("comp_5").ToString)
            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_6")), "", dt.Rows(0).Item("comp_6").ToString)

            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_7")), "", dt.Rows(0).Item("comp_7").ToString)
            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_8")), "", dt.Rows(0).Item("comp_8").ToString)
            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_9")), "", dt.Rows(0).Item("comp_9").ToString)
            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_10")), "", dt.Rows(0).Item("comp_10").ToString)
            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_11")), "", dt.Rows(0).Item("comp_11").ToString)

            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_12")), "", dt.Rows(0).Item("comp_12").ToString)
            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_13")), "", dt.Rows(0).Item("comp_13").ToString)
            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_14")), "", dt.Rows(0).Item("comp_14").ToString)
            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_15")), "", dt.Rows(0).Item("comp_15").ToString)
            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_16")), "", dt.Rows(0).Item("comp_16").ToString)

            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_17")), "", dt.Rows(0).Item("comp_17").ToString)
            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_18")), "", dt.Rows(0).Item("comp_18").ToString)
            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_19")), "", dt.Rows(0).Item("comp_19").ToString)
            StringCompTruck = StringCompTruck & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_20")), "", dt.Rows(0).Item("comp_20").ToString)
            i = i + 1
        End If
        mDataSet = Nothing


        Dim temCondition = ""
        If edit Then

            temCondition = "_"
        Else

            temCondition = ""
        End If


        If Trim(cbTu_Tail.Text) <> temCondition Then

            sql_str = "select t.compartments,t.comp_1,comp_2,comp_3,comp_4 , "
            sql_str = sql_str & " comp_5,comp_6,comp_7,comp_8,comp_9,comp_10,comp_11,comp_12, "
            sql_str = sql_str & " comp_13,comp_14,comp_15,comp_16,comp_17,comp_18,comp_19,comp_20 "
            sql_str = sql_str & " from transport_unit t"
            sql_str = sql_str & " Where t.TU_NUMBER =" & Trim(vTu2) & ""
            If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                i = 0
                ValCompTailer = IIf(IsDBNull(dt.Rows(i).Item("compartments")), "", dt.Rows(i).Item("compartments").ToString)
                StringCompTailer = IIf(IsDBNull(dt.Rows(0).Item("comp_1")), "", dt.Rows(0).Item("comp_1").ToString)
                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_2")), "", dt.Rows(0).Item("comp_2").ToString)
                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_3")), "", dt.Rows(0).Item("comp_3").ToString)
                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_4")), "", dt.Rows(0).Item("comp_4").ToString)
                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_5")), "", dt.Rows(0).Item("comp_5").ToString)
                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_6")), "", dt.Rows(0).Item("comp_6").ToString)

                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_7")), "", dt.Rows(0).Item("comp_7").ToString)
                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_8")), "", dt.Rows(0).Item("comp_8").ToString)
                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_9")), "", dt.Rows(0).Item("comp_9").ToString)
                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_10")), "", dt.Rows(0).Item("comp_10").ToString)
                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_11")), "", dt.Rows(0).Item("comp_11").ToString)

                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_12")), "", dt.Rows(0).Item("comp_12").ToString)
                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_13")), "", dt.Rows(0).Item("comp_13").ToString)
                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_14")), "", dt.Rows(0).Item("comp_14").ToString)
                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_15")), "", dt.Rows(0).Item("comp_15").ToString)
                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_16")), "", dt.Rows(0).Item("comp_16").ToString)

                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_17")), "", dt.Rows(0).Item("comp_17").ToString)
                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_18")), "", dt.Rows(0).Item("comp_18").ToString)
                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_19")), "", dt.Rows(0).Item("comp_19").ToString)
                StringCompTailer = StringCompTailer & "," & IIf(IsDBNull(dt.Rows(0).Item("comp_20")), "", dt.Rows(0).Item("comp_20").ToString)
            Else
            End If
            mDataSet = Nothing
        End If
        GetdetailDO()
        Call GenCompartment(ValCompTruck, ValCompTailer, cbTruck.Text, StringCompTruck, cbTu_Tail.Text, StringCompTailer)

        'assTxtOrder()
    End Sub

    Private Sub GetdetailDO()
        Dim tmpDO() As String
        Dim StrTmp As String
        Dim tmpstrQL As String
        Dim i As Integer
        StrTmp = ""
        tmpDO = Split(Trim(txtDo.Text), ",")
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
                'Column2.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("Do_no")), "", dt.Rows(i).Item("Do_no").ToString
                'Column5.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("product")), "", dt.Rows(i).Item("product").ToString

                MSGridTotDo.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("product")), "", dt.Rows(i).Item("product").ToString)
                MSGridTotDo.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("quantity")), "", dt.Rows(i).Item("quantity").ToString)
                n = n + CType(IIf(IsDBNull(dt.Rows(i).Item("quantity")), "", dt.Rows(i).Item("quantity").ToString), Integer)
                i = i + 1
            Loop

        End If
        txtToT.Text = n
        mDataSet = Nothing
    End Sub

    Private Sub GetdetailProduct()
        'Column5 = Nothing
        'Column5 = New ComboBox
        'Column5.DataSource = "null"
        'Column5.Items.Clear()

        Dim tmpDO() As String
        Dim StrTmp As String
        Dim tmpstrQL As String
        Dim i As Integer

        StrTmp = ""
        tmpDO = Split(Trim(txtDo.Text), ",")
        For i = 0 To UBound(tmpDO)
            If i > 0 Then
                StrTmp = StrTmp & ","
            End If
            StrTmp = StrTmp & "'"
            StrTmp = StrTmp & tmpDO(i)
            StrTmp = StrTmp & "'"
        Next i
        If MSGridAddEdit.RowCount <= 0 Then Exit Sub
        Dim index As Integer = MSGridAddEdit.CurrentRow.Index
        If MSGridAddEdit.Rows(index).Cells(1).Value = "" Then
            Exit Sub
        End If
        Dim strDono = MSGridAddEdit.Rows(index).Cells(1).Value.ToString
        If strDono = "" Then
            Column5.Items.Clear()
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
                While dt.Rows.Count > i
                    If Column5.Items.IndexOf(IIf(IsDBNull(dt.Rows(i).Item("product")), "", dt.Rows(i).Item("product").ToString)) = -1 Then
                        Column5.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("product")), "", dt.Rows(i).Item("product").ToString))

                    End If
                    'MSGridAddEdit.Item(4, index).Value = IIf(IsDBNull(dt.Rows(i).Item("product")), "", dt.Rows(i).Item("product").ToString)
                    i = i + 1
                End While
                For j As Integer = 0 To MSGridAddEdit.Rows.Count - 1
                    MSGridAddEdit.Rows(j).Cells("Column5").Value = IIf(IsDBNull(dt.Rows(0).Item("product")), "", dt.Rows(0).Item("product").ToString)
                Next

            End If
        End If
        mDataSet = Nothing
    End Sub

    Private Sub cmdCalSeal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalSeal.Click

        frmUtlAddSeal.Close()
        GetCountSeal()
        frmUtlAddSeal.ShowDialog()
    End Sub

    Private Sub ShowdetailCompartMent(ByVal ILoadNo As String)

        Dim strSQL As String
        Dim i As Integer
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim vTotalComp As Integer
        strSQL = _
        "select  ol.compartment_no , " & _
        " ol.do_no , ol.sale_product_id ||'  '|| ol.sale_product_name as  sale_product " & _
        " ,ol.advice , ol.batch_status,ol.tu_number,t.compartments  " & _
        " from tas.oil_load_lines  ol,tas.transport_unit t " & _
        " where ol.load_header_no ='" & Trim(ILoadNo) & "' " & _
        " and ol.tu_number = t.tu_number  " & _
        " order by ol.compartment_no "

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            If edit Then
                MSGridAddEdit.RowCount = 0
            End If
            'Column2.Items.Clear()
            'If dt.Rows.Count > 0 Then
            '    Column2.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("Do_no")), "", dt.Rows(i).Item("Do_no").ToString))
            '    Column5.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("sale_product")), "", dt.Rows(i).Item("sale_product").ToString))
            '    i += 1
            'End If
            i = 0
            'Do While dt.Rows.Count > i & dt.Rows.Count < MSGridAddEdit.RowCount
            vTotalComp = IIf(IsDBNull(dt.Rows(0).Item("compartments")), "", dt.Rows(0).Item("compartments"))
            Do While dt.Rows.Count > i
                If edit Then
                    MSGridAddEdit.RowCount = vTotalComp
                End If
                'Column2.HeaderText = IIf(IsDBNull(dt.Rows(i).Item("Do_no")), "", dt.Rows(i).Item("Do_no").ToString)

                MSGridAddEdit.Item(0, i).Value = i + 1
                Dim Comp_no As Integer = dt.Rows(i).Item("compartment_no")
                If MSGridAddEdit.Item(0, i).Value = Comp_no Then
                    Column5.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT")), "", dt.Rows(i).Item("SALE_PRODUCT").ToString))
                    Column2.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("Do_no")), "", dt.Rows(i).Item("Do_no").ToString))

                    MSGridAddEdit.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Do_no")), "", dt.Rows(i).Item("Do_no").ToString)
                    MSGridAddEdit.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT")), "", dt.Rows(i).Item("SALE_PRODUCT").ToString)

                    MSGridAddEdit.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("advice")), "", dt.Rows(i).Item("advice").ToString)  'is use
                    MSGridAddEdit.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("batch_status")), "", dt.Rows(i).Item("batch_status").ToString)
                Else
                    MSGridAddEdit.Item(1, i).Value = ""
                    MSGridAddEdit.Item(1, Comp_no - 1).Value = IIf(IsDBNull(dt.Rows(i).Item("Do_no")), "", dt.Rows(i).Item("Do_no").ToString)
                    MSGridAddEdit.Item(4, Comp_no - 1).Value = IIf(IsDBNull(dt.Rows(i).Item("SALE_PRODUCT")), "", dt.Rows(i).Item("SALE_PRODUCT").ToString)

                    MSGridAddEdit.Item(5, Comp_no - 1).Value = IIf(IsDBNull(dt.Rows(i).Item("advice")), "", dt.Rows(i).Item("advice").ToString)  'is use
                    MSGridAddEdit.Item(6, Comp_no - 1).Value = IIf(IsDBNull(dt.Rows(i).Item("batch_status")), "", dt.Rows(i).Item("batch_status").ToString)
                End If
                i = i + 1
            Loop
        End If
        mDataSet = Nothing

    End Sub

    Sub unEnableData()
        txtLoadNo.Enabled = False
        cbCard.Enabled = False
        cbTruck.Enabled = False
        cbTu_Tail.Enabled = False
        cbDriver.Enabled = False
        txtDo.Enabled = False
        txtAmoutSeal.Enabled = False
        txtSealNumber.Enabled = False
        cmdFindDriver.Enabled = False
        AddDo.Enabled = False
        cmdCalSeal.Enabled = False
        cmdAssignComp.Enabled = False
        cmdFinTail.Enabled = False
        cmdFindHead.Enabled = False
        CmbFindCard.Enabled = False
    End Sub
    Private Sub showLineDataGride()
        For i = 0 To CInt(4) - 1
            MSGridAddEdit.RowCount = MSGridAddEdit.RowCount + 1
            MSGridAddEdit.Item(0, i).Value = i + 1
        Next
    End Sub
    Private Sub ShowdetailLoad(ByVal iLoad_no As String)

        unEnableData()
        edit = True
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        strSQL = _
        "select oh.load_header_no, " & _
        " oh.tu_card_no, " & _
        " oh.tu_id||'_'||oh.tu_number as TuHead, " & _
        " oh.tu_id1||'_'||oh.tu_number1 as TuTail, " & _
        " oh.driver_name ||'_'|| oh.driver_id as DriverName, " & _
        " ol.Do_no ,oh.seal_use , oh.seal_number " & _
        " from tas.oil_load_headers oh , tas.oil_load_lines  ol " & _
        " Where oh.LOAD_HEADER_NO = ol.LOAD_HEADER_NO " & _
        " and oh.load_header_no='" & Trim(iLoad_no) & "' "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            txtLoadNo.Text = IIf(IsDBNull(dt.Rows(i).Item("LOAD_HEADER_NO")), "", dt.Rows(i).Item("LOAD_HEADER_NO").ToString)
            cbCard.Text = IIf(IsDBNull(dt.Rows(i).Item("tu_card_no")), "", dt.Rows(i).Item("tu_card_no").ToString)
            cbTruck.Text = IIf(IsDBNull(dt.Rows(i).Item("TuHead")), "", dt.Rows(i).Item("TuHead").ToString)
            cbTu_Tail.Text = IIf(IsDBNull(dt.Rows(i).Item("TuTail")), "", dt.Rows(i).Item("TuTail").ToString)
            cbDriver.Text = IIf(IsDBNull(dt.Rows(i).Item("DriverName")), "", dt.Rows(i).Item("DriverName").ToString)
            txtAmoutSeal.Text = IIf(IsDBNull(dt.Rows(i).Item("seal_use")), "", dt.Rows(i).Item("seal_use").ToString)
            txtSealNumber.Text = IIf(IsDBNull(dt.Rows(i).Item("seal_number")), "", dt.Rows(i).Item("seal_number").ToString)

            txtDo.Text = getDOselect(Trim(iLoad_no))
            ShowdetailCompartMent(Trim(iLoad_no))
            cmdAssignComp_Click()


        End If
        mDataSet = Nothing

        assTxtOrder()
    End Sub

    Private Function AddData() As Boolean
        Dim strSQL As String
        'Dim Oratemp As OraDynaset
        Dim TotSale As Long
        Dim arTuNo() As String
        Dim vLoadNo As String
        Dim vTu1 As String
        Dim vTu2 As String
        Dim vTu_id1() As String
        Dim vTu_id2() As String
        Dim chkNull As Boolean
        If cbTruck.Text = "" Then
            vTu1 = "0"
        Else
            vTu_id1 = Split(Trim(cbTruck.Text), "_")
            vTu1 = vTu_id1(1)
        End If

        If cbTu_Tail.Text = "" Then
            vTu2 = "0"
        Else
            vTu_id2 = Split(Trim(cbTu_Tail.Text), "_")
            vTu2 = vTu_id2(1)
        End If

        If cbDriver.Text = "" Then
            Return False 'Exit Function
        End If
        StrTmp = Split(cbDriver.Text, "_")
        DriverID = Trim(StrTmp(1))
        DriveName = Trim(StrTmp(0))

        'DataGridView1.Rows = 1
        If cbCard.Text = "" Or cbDriver.Text = "" Or txtDo.Text = "" Or cbTruck.Text = "" Then
            MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", vbInformation)
            Return False 'Exit Function
        End If
        '=================

        If CheckCompDuplicate() Then
            MsgBox("ไม่สามารถบันทึกข้อมูลได้เนื่องจากป้อนช่องเติมซ้ำกัน โปรดแก้ไขช่องเติมให้ถูกต้อง", vbCritical, "พบข้อผิดพลาด")
            Return False 'Exit Function
        End If
        If Val(txtOrder.Text) > Val(txtToT.Text) Then
            MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "เนื่องจากปริมาณสั่งเติมมีจำนวนรวมมากกว่าปริมาณสั่งซื้อ  กรุณาตรวจสอบอีกครั้ง", vbCritical, "พบข้อผิดพลาด")
            Return False 'Exit Function
        End If
        'If Val(txtOrder.Text) < Val(txtToT.Text) Then
        '    MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "เนื่องจากปริมาณสั่งเติมมีจำนวนรวมน้อยกว่าปริมาณสั่งซื้อ  กรุณาตรวจสอบอีกครั้ง", vbCritical, "พบข้อผิดพลาด")
        '    Return False 'Exit Function
        'End If

        If MsgBox("ท่านต้องการบันทึกข้อมูลหรือไม่", vbInformation + vbYesNo) = vbNo Then
            Return False 'Exit Function
        End If

        strSQL = "Delete from  gac.tlas_save_compartment"
        If Oradb.ExeSQL(strSQL) Then
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            Return False
        End If

        Dim i As Integer = 0

        i = 0
        Do While MSGridAddEdit.RowCount > i
            If Trim(MSGridAddEdit.Item(1, i).Value) <> "" And Trim(MSGridAddEdit.Item(5, i).Value) <> "" And Val(Trim(MSGridAddEdit.Item(5, i).Value)) <> 0 Then
                arTuNo = Split(Trim(MSGridAddEdit.Item(2, i).Value), "_")
                strSQL = " "
                strSQL = strSQL & " Begin "
                strSQL = strSQL & " LOAD.TLAS_LOADING_INSERT_DATA( "
                strSQL = strSQL & Val(Trim(MSGridAddEdit.Item(0, i).Value)) & "," & Val(Trim(MSGridAddEdit.Item(3, i).Value)) & ","
                strSQL = strSQL & Val(Trim(MSGridAddEdit.Item(5, i).Value)) & ",'" & Trim(MSGridAddEdit.Item(1, i).Value) & "',"
                strSQL = strSQL & Val(Trim(Mid(Trim(MSGridAddEdit.Item(4, i).Value), 1, InStr(1, Trim(MSGridAddEdit.Item(4, i).Value), " ")))) & "," & Val(Trim(MSGridAddEdit.Item(6, i).Value)) & "," & arTuNo(1) & " ); "
                strSQL = strSQL & " End; "
                If Oradb.ExeSQL(strSQL) Then
                Else
                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                End If
            End If
            i = i + 1
        Loop

        strSQL = ""
        strSQL = strSQL & "Begin "
        strSQL = strSQL & " LOAD.tas_loading_create_load("
        strSQL = strSQL & Val(Trim(cbCard.Text)) & "," & vTu1 & "," & vTu2 & ","
        strSQL = strSQL & Val(DriverID) & ",'" & iVehicleNo & "', '" & Trim(txtDo.Text) & "' ,'" & Trim(txtAmoutSeal.Text) & "' ,'" & mUserName & "',"
        strSQL = strSQL & " '" & P_ComputerName & "',:ret_loadheader,:ret_check,:ret_msg); "
        strSQL = strSQL & " End;"


        Dim Oraparam As New COraParameter
        Dim RET_LOADHEADER As Object
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_LOADHEADER", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_CHECK", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With

        Dim bRet As Boolean = False
        If Oradb.ExeSQL(strSQL, Oraparam) Then
            RET_LOADHEADER = Oraparam.GetOraclParamValue("RET_LOADHEADER")
            RET_CHECK = Oraparam.GetOraclParamValue("RET_CHECK")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            If Oraparam.GetOraclParamValue("RET_CHECK") = 0 Then
                MsgBox(Oraparam.GetOraclParamValue("RET_MSG").ToString, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                bRet = True
            Else
                MsgBox(Oraparam.GetOraclParamValue("RET_MSG").ToString, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                bRet = False
            End If

        End If

        vLoadNo = Oraparam.GetOraclParamValue("RET_LOADHEADER").ToString
        txtLoadNo.Text = vLoadNo
        If SaveSeal(Trim(vLoadNo), 1, Trim(txtSealNumber.Text), 1) Then
            Call UpdateSealLoadHeader(vLoadNo)
            Call UpdateSealControl(vLoadNo)
        End If


        Oraparam.RemoveOracleParam()
        Oraparam = Nothing


        If MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly) Then
            'PrintReport(Trim(vLoadNo))
            'PrintReport(vLoadNo)
            Me.Close()
            frmLoadLoading.Show_Data()
            'Else
            '    ClearDataAddEdit()
            '    WorkFlow = 1
        End If

        Return bRet
    End Function

    Private Function SaveCreateLoad(ByVal itu_card_no As Long, ByVal itu_Id1 As Long, ByVal itu_Id2 As Long, ByVal icard_reader_id As Long, ByVal ioverride_card As Long, ByVal idatetime_active As String, ByVal ij_user As String, ByVal ij_computer As String) As Boolean
        Dim bRet As Boolean = False
        Dim strSQL As String
        If cbDriver.Text = "" Then Return False
        StrTmp = Split(cbDriver.Text, "_")
        DriverID = Trim(StrTmp(1))
        DriveName = Trim(StrTmp(0))

        strSQL = "begin "
        strSQL = strSQL & " load.Registor_check_tu("
        strSQL = strSQL & itu_card_no & "," & itu_Id1 & "," & itu_Id2 & ","
        strSQL = strSQL & icard_reader_id & ", "
        strSQL = strSQL & ioverride_card & "," & idatetime_active & " ,"
        strSQL = strSQL & "'" & ij_user & "','" & ij_computer & "',"
        strSQL = strSQL & ":ret_vehicle_number,:ret_tu_id,:ret_tu_id1,:ret_check,:ret_msg); "
        strSQL = strSQL & " end;"


        Dim Oraparam As New COraParameter
        Dim RET_VEHICLE_NUMBER As Object
        Dim RET_TU_ID As Object
        Dim RET_TU_ID1 As Object
        Dim RET_CHECKED As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_VEHICLE_NUMBER", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_TU_ID", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_TU_ID1", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_CHECKED", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With

        If Oradb.ExeSQL(strSQL, Oraparam) Then
            RET_VEHICLE_NUMBER = Oraparam.GetOraclParamValue("RET_VEHICLE_NUMBER")
            RET_TU_ID = Oraparam.GetOraclParamValue("RET_TU_ID")
            RET_TU_ID1 = Oraparam.GetOraclParamValue("RET_TU_ID1")
            RET_CHECKED = Oraparam.GetOraclParamValue("RET_CHECKED")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            If RET_CHECKED = -1 Then
                MsgBox(RET_MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                bRet = False
            Else
                bRet = True
            End If

            '-----------------------------
            SaveCreateLoad = IIf((Oraparam.GetOraclParamValue("RET_CHECKED") >= 0), True, False)
            If RET_CHECKED <> 0 Then
                'MsgBox(RET_MSG, vbCritical, "??????????????")
                ErrChk = False
                Exit Function
            End If
            iVehicleNo = Oraparam.GetOraclParamValue("RET_VEHICLE_NUMBER").ToString
            If SaveCheckDriver(Oraparam.GetOraclParamValue("RET_VEHICLE_NUMBER").ToString, CLng(DriverID), 1, idatetime_active, ij_user, ij_computer, itu_card_no, icard_reader_id) Then
                bRet = True
            Else
                bRet = False
                SaveCreateLoad = False
            End If
        End If
        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet

    End Function

    Private Function SaveCheckDriver(ByVal ivehicle_number As String, ByVal idriver_id As String, ByVal ioverride_card As Long, ByVal idatetime_active As String, ByVal ij_user As String, ByVal ij_computer As String, ByVal itu_card_no As Long, ByVal icard_reader_id As Long) As Boolean
        Dim strSQL As String


        strSQL = "begin "
        strSQL = strSQL & " load.Registor_check_Driver('"
        strSQL = strSQL & ivehicle_number & "'," & idriver_id & ","
        strSQL = strSQL & ioverride_card & ", "
        strSQL = strSQL & idatetime_active
        strSQL = strSQL & ",'" & ij_user & "','" & ij_computer & "',"
        strSQL = strSQL & ":ret_driver,:ret_check,:ret_msg); "
        strSQL = strSQL & "end;"


        '----------------------------'RET_DRIVER
        Dim bRet As Boolean = False
        Dim Oraparam As New COraParameter
        Dim RET_VEHICLE As Object
        Dim RET_CHECKED As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_DRIVER", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_CHECKED", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With

        If Oradb.ExeSQL(strSQL, Oraparam) Then
            RET_VEHICLE = Oraparam.GetOraclParamValue("RET_DRIVER")
            RET_CHECKED = Oraparam.GetOraclParamValue("RET_CHECKED")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            If RET_CHECKED = -1 Then
                MsgBox(Oraparam.GetOraclParamValue("RET_MSG").ToString, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                bRet = False
            Else
                bRet = True
            End If
            '---------------
            SaveCheckDriver = IIf((Oraparam.GetOraclParamValue("RET_CHECKED") >= 0), True, False)

            'If Oraparam.GetOraclParamValue("RET_CHECKED") <> 0 Then
            '    MsgBox(Oraparam.GetOraclParamValue("RET_MSG").ToString, vbCritical)
            '    ErrChk = False
            '    'Exit Function
            'End If

        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If AELoadNo = "" Then
            If MSGridAddEdit.Rows.Count > 0 Then
                AddData()
            Else
                MsgBox("ไม่พบข้อมูลช่องเติม", vbOKOnly + vbInformation)
            End If
        Else
            EditData()
            ' save.Visible = False
        End If
    End Sub

    Private Function SaveData(ByVal JUser As String, ByVal jComputer As String) As Boolean
        Dim d As String
        Dim vTu1, vTu2 As String
        Dim vTu_id1() As String
        Dim vTu_id2() As String
        If cbTruck.Text = "" Then
            vTu1 = "0"
        Else
            vTu_id1 = Split(Trim(cbTruck.Text), "_")
            vTu1 = vTu_id1(1)
        End If

        If cbTu_Tail.Text = "" Then
            vTu2 = "0"
        Else
            vTu_id2 = Split(Trim(cbTu_Tail.Text), "_")
            vTu2 = vTu_id2(1)
        End If

        Dim time As DateTime = DateTime.Now
        d = "TO_DATE('" & time & "', 'dd/mm/yyyy hh24:mi:ss')"
        SaveData = SaveCreateLoad(CLng(IIf((cbCard.Text = ""), "0", Trim(cbCard.Text))), CLng(Trim(vTu1)), CLng(Trim(vTu2)), CLng(1100101), 0, d, JUser, jComputer)
    End Function

    Function CheckParameterProcedure() As Boolean
        If SaveData(mUserName, P_ComputerName) Then
            CheckParameterProcedure = True
        Else
            CheckParameterProcedure = False
        End If
    End Function

    Private Function runProcVehicle(ByVal iNumber1 As String, ByVal iNumber2 As String, ByVal IDriverID As String) As Boolean
        Dim strSQL As String
        strSQL = "begin "
        strSQL = strSQL & " load.registor_check_vehicle("
        strSQL = strSQL & iNumber1 & "," & iNumber2 & "," & IDriverID & ","
        strSQL = strSQL & ":RET_VEHICLE,:RET_CHECK,:RET_MSG); "
        strSQL = strSQL & "end;"

        Dim bRet As Boolean = False
        Dim Oraparam As New COraParameter
        Dim RET_VEHICLE As Object
        Dim RET_CHECKED As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_VEHICLE", COracle._OracleDbType.OraVarchar2, 512)
            .CreateOracleParamOutput("RET_CHECK", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With
        If Oradb.ExeSQL(strSQL, Oraparam) Then
            RET_VEHICLE = Oraparam.GetOraclParamValue("RET_VEHICLE")
            RET_CHECKED = Oraparam.GetOraclParamValue("RET_CHECK")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            If RET_CHECKED = -1 Then
                MsgBox(RET_MSG, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                bRet = False
            Else
                bRet = True
            End If
            '---------------

            'runProcVehicle = IIf((Oraparam.GetOraclParamValue("RET_CHECK") >= 0), True, False)
            'If Not runProcVehicle Then
            '    'MsgBox(IIf(Oraparam.GetOraclParamValue("retu_msg").ToString, "", Oraparam.GetOraclParamValue("retu_msg").ToString), vbCritical, "??????????????")
            'End If

        End If
        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function

    Private Function CheckHeadTail() As Boolean
        If Trim(cbTruck.Text) = Trim(cbTu_Tail.Text) Then
            CheckHeadTail = True
            Return True
        End If
        Return False
    End Function

    Private Sub cbTruck_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTruck.SelectedIndexChanged
        'cbTu_Tail.Text = ""
        cbDriver.Text = ""
        Dim strSQL As String
        'Dim Oratemp As OraDynaset
        Dim tmpTransUnit() As String
        Dim tmp1, tmp2 As String

        If cbTruck.Text = "" Then Exit Sub
        If CheckHeadTail() Then
            MsgBox(" ทะเบียนหัวลาก กับ ทะเบียนตัวพ่วงเป็นชื่อเดียวกัน ", vbInformation)
            cbTu_Tail.Text = ""
            Exit Sub
        End If
        tmpTransUnit = Split(cbTruck.Text, "_")
        tmp1 = Trim(tmpTransUnit(1))


        'strSQL = " select v.vehicle_number,dm.driver_id ,d.first_name,d.last_name , d.first_name ||' '|| d.last_name||' _'||d.driver_id as driver "
        'strSQL = strSQL & " from tas.vehicle v , tas.driver_mapping  dm , tas.driver d    ,tas.oil_load_headers  oh  "
        'strSQL = strSQL & " Where v.Vehicle_Number = dm.Vehicle_Number "
        'strSQL = strSQL & " and d.driver_id = dm.driver_id   and v.vehicle_number = oh.vehicle_number (+)   and d.driver_id = oh.driver_id  and oh.cancel_status =0 "
        'strSQL = strSQL & " and v.tu_number='" & tmp1 & "'   order by oh.creation_date  desc "
        strSQL = _
         " select v.vehicle_number,dm.driver_id ,d.first_name,d.last_name , d.first_name ||' '|| d.last_name||' _'||d.driver_id as driver  " & _
         " from tas.vehicle v , tas.driver_mapping  dm , tas.driver d " & _
         " Where v.Vehicle_Number = dm.Vehicle_Number  " & _
        " and d.driver_id = dm.driver_id " & _
        " and v.tu_number='" & tmp1 & "' "

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        Dim TxtDriverName = ""
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                cbDriver.Text = ""
                cbDriver.Text = IIf(IsDBNull(dt.Rows(i).Item("driver")), "", dt.Rows(i).Item("driver").ToString)
                TxtDriverName = Trim(Mid(cbDriver.Text, 1, (InStr(1, cbDriver.Text, "_")) - 1))
            End If

            'Return True
        End If
        mDataSet = Nothing
        GetTuTail()
        '--------------------------------
    End Sub

    Private Sub GetTuTail()
        Dim strSQL As String
        'Dim Oratemp As OraDynaset
        Dim tmpTransUnit() As String
        Dim tmp1 As String
        Dim tmp2 As String
        'cbTu_Tail.Text = ""
        If cbTruck.Text = "" Then Exit Sub
        tmpTransUnit = Split(cbTruck.Text, "_")
        tmp1 = Trim(tmpTransUnit(1))

        strSQL = " select  t.tu_number1   from vehicle t"
        strSQL = strSQL & "   where t.tu_number ='" & tmp1 & "' order by t.creation_date desc"

        '------------------------------
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim TxtDriverName = ""
        Dim i As Integer = 0
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                tmp2 = IIf(IsDBNull(dt.Rows(i).Item("tu_number1")), "", dt.Rows(i).Item("tu_number1").ToString)
                If tmp2 = "" Then Exit Sub
            End If

            'Return True
        End If
        mDataSet = Nothing
        '------------------------------

        strSQL = " select T.TU_ID,T.TU_NUMBER,T.TU_ID||'_'||T.TU_NUMBER AS TuNAME "
        strSQL = strSQL & " from tas.transport_unit t "
        strSQL = strSQL & "  Where t.tu_number = '" & tmp2 & "' "
        '----------------------------------------------------
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            'cbTu_Tail.Text = ""
            If dt.Rows.Count > 0 Then
                cbTu_Tail.Text = IIf(IsDBNull(dt.Rows(i).Item("tUname")), "", dt.Rows(i).Item("tUname").ToString)
            End If

            'Return True
        End If
        mDataSet = Nothing
        '------------------------------

    End Sub

    Private Function SaveSeal(ByVal iLoad_no As String, ByVal iauto_seal As Long, ByVal iseal_number As String, ByVal ioverride_card As Long) As Boolean
        Dim strSQL As String

        strSQL = "begin "
        strSQL = strSQL & " load.Registor_Update_Seal ('"
        strSQL = strSQL & iLoad_no & "'," & iauto_seal & ",'"
        strSQL = strSQL & iseal_number & "', "
        strSQL = strSQL & ioverride_card & ",sysdate ,"
        strSQL = strSQL & "'" & mUserName & "','" & P_ComputerName & "',"
        strSQL = strSQL & ":ret_check,:ret_msg); "
        strSQL = strSQL & "end;"

        '------------------------
        Dim bRet As Boolean = False
        Dim Oraparam As New COraParameter
        Dim RET_CHECKED As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_CHECKED", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With
        If Oradb.ExeSQL(strSQL, Oraparam) Then
            RET_CHECKED = Oraparam.GetOraclParamValue("RET_CHECKED")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            'If RET_CHECKED = 0 Then
            '    MsgBox(Oraparam.GetOraclParamValue("RET_MSG").ToString, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            '    bRet = False
            'Else
            '    bRet = True
            'End If

            bRet = IIf((Oraparam.GetOraclParamValue("RET_CHECKED") >= 0), True, False)
            If Oraparam.GetOraclParamValue("RET_CHECKED") <> 0 Then
                MsgBox(Oraparam.GetOraclParamValue("RET_MSG").ToString, vbCritical)
                'Exit Function
            End If
            'MsgBox(Oraparam.GetOraclParamValue("RET_MSG").ToString, vbInformation, "??????????")
        End If
        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function

    '-----------------
    Private Function CheckProductPromptSave() As Boolean
        Dim i As Integer = 0
        CheckProductPromptSave = True
        Do While MSGridAddEdit.RowCount > i
            If Trim(MSGridAddEdit.Item(3, i).Value) = "" Then

                CheckProductPromptSave = False
                Exit Do
            End If
            i += 1
        Loop
        Return CheckProductPromptSave
    End Function
    '======================

    Private Function CheckDataExists(ByVal LoadNo As Long) As Boolean
        CheckDataExists = True
        Dim strSQL As String
        strSQL = _
            "select H.load_header_no " & _
            "from OIL_LOAD_HEADERS H " & _
            "where H.load_header_no = '" & LoadNo & "'"
        If Oradb.ExeSQL(strSQL) > 0 Then
            CheckDataExists = False
        End If
        Return CheckDataExists
    End Function

    Private Function EditData() As Boolean
        'On Error GoTo Err_Func
        Dim strSQL As String
        Dim strTUnumber() As String
        Dim strSaleProduct() As String
        Dim i As Integer
        If cbCard.Text = "" Or cbDriver.Text = "" Or txtDo.Text = "" Or MSGridAddEdit.RowCount = 0 Then
            MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", vbInformation)
            Exit Function
        End If

        If Not CheckProductPromptSave() Then
            MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "ข้อมูลของผลิตภัณฑ์ไม่ถูกต้อง กรุณาตรวจสอบข้อมูลอีกครั้ง", vbInformation)
            Exit Function
        End If


        If Not CheckDataExists(Val(txtLoadNo.Text)) Then
            MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "เนื่องจากไม่พบหมายเลข Shipment " & Trim(txtLoadNo.Text) & " อยู่ในฐานข้อมูล", vbInformation)
            Exit Function
        End If

        'If CheckCompDuplicate() Then
        '    MsgBox("ไม่สามารถบันทึกข้อมูลได้เนื่องจากป้อนช่องเติมซ้ำกัน โปรดแก้ไขช่องเติมให้ถูกต้อง", vbCritical, "พบข้อผิดพลาด")
        '    Return False 'Exit Function
        'End If
        If Val(txtOrder.Text) > Val(txtToT.Text) Then
            MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "เนื่องจากปริมาณสั่งเติมมีจำนวนรวมมากกว่าปริมาณสั่งซื้อ  กรุณาตรวจสอบอีกครั้ง", vbCritical, "พบข้อผิดพลาด")
            Return False 'Exit Function
        End If
        'If Val(txtOrder.Text) < Val(txtToT.Text) Then
        '    MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "เนื่องจากปริมาณสั่งเติมมีจำนวนรวมน้อยกว่าปริมาณสั่งซื้อ  กรุณาตรวจสอบอีกครั้ง", vbCritical, "พบข้อผิดพลาด")
        '    Return False 'Exit Function
        'End If

        If MsgBox("ท่านต้องการบันทึกข้อมูลหรือไม่?", vbInformation + vbYesNo) = vbNo Then
            Exit Function
        End If


        strSQL = " Delete   gac.tlas_edit_compartment   "
        Oradb.ExeSQL(strSQL)

        i = 0
        Do While MSGridAddEdit.RowCount > i

            If Trim(MSGridAddEdit.Item(8, i).Value) <> "-" Then
                If Trim(MSGridAddEdit.Item(1, i).Value) <> "" And Trim(MSGridAddEdit.Item(5, i).Value) <> "" Then
                    strTUnumber = Split(Trim(MSGridAddEdit.Item(2, i).Value), "_")

                    strSaleProduct = Split(Trim(MSGridAddEdit.Item(4, i).Value), " ")
                    strSQL = " "
                    strSQL = strSQL & " Begin "
                    strSQL = strSQL & " LOAD.TLAS_LOADING_UPDATE_DATA( "
                    strSQL = strSQL & Val(Trim(MSGridAddEdit.Item(0, i).Value)) & "," & Val(Trim(MSGridAddEdit.Item(3, i).Value)) & ","
                    strSQL = strSQL & Val(Trim(MSGridAddEdit.Item(5, i).Value)) & ",'" & Trim(MSGridAddEdit.Item(1, i).Value) & "',"
                    strSQL = strSQL & Val(Trim(strSaleProduct(0))) & "," & Val(MSGridAddEdit.Item(6, i).Value) & "," & Trim(strTUnumber(1)) & ",'E' ); "
                    strSQL = strSQL & " End; "
                    If Oradb.ExeSQL(strSQL) Then
                    Else
                        MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                    End If
                End If
            End If
            i = i + 1
        Loop
        '-----------" & Trim(MSGridAddEdit.Item(8, i).Value) & "
        AE_LoadNo = Val(txtLoadNo.Text)

        EditData = True
        If EditData Then

            strSQL = ""
            strSQL = strSQL & "Begin "
            strSQL = strSQL & " LOAD.TAS_LOADING_EDIT_LOAD("
            strSQL = strSQL & "" & AE_LoadNo & ", ' - ', '" & mUserName & "',"
            strSQL = strSQL & "'" & P_ComputerName & "',:ret_check,:ret_msg); "
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
            MsgBox("แก้ไขการจัดช่องเติมของหมายเลข Load No '" & AE_LoadNo & "'  เรียบร้อยแล้ว""")
            Me.Close()
            frmLoadLoading.Show_Data()
        Else
            MsgBox("ไม่มีการแก้ไขการจัดช่องเติมของหมายเลข Load No '" & AE_LoadNo & "' ")
            Me.Close()
            frmLoadLoading.Show_Data()
            Exit Function
        End If
        Exit Function
Err_Func:

    End Function

    Private Sub UpdateSealLoadHeader(ByVal ILoadNo As String)
        Dim strSQL As String
        If SealCount = "" Then
            SealCount = Trim(txtAmoutSeal.Text)
        End If
        Dim Oraparam As New COraParameter
        strSQL = " Update tas.oil_load_headers t set  t.Seal_use= " & SealCount & ","
        strSQL = strSQL & " t.seal_number='" & Trim(txtSealNumber.Text) & "'"
        strSQL = strSQL & "  Where t.load_header_no='" & ILoadNo & "'"
        Oradb.ExeSQL(strSQL, Oraparam)
    End Sub

    Private Sub UpdateSealControl(ByVal ILoadNo As String)
        Dim strSQL As String
        Dim Oraparam As New COraParameter
        If SealLast = "" Then Exit Sub
        strSQL = "Update tas.seal_control t SET t.load_last_no='" & Trim(ILoadNo) & "' ,"
        strSQL = strSQL & " t.seal_no='" & Trim(SealLast) & "'"
        strSQL = strSQL & " Where t.id=1 "
        Oradb.ExeSQL(strSQL, Oraparam)
    End Sub

    Private Function GetCountSeal() As Integer
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim Oraparam As New COraParameter
        Dim tmpSeal As Integer
        Dim tmpTu1() As String
        Dim tmpTu2() As String
        tmpSeal = 0
        Dim i As Integer = 0
        Dim dt As DataTable
        If cbTruck.Text <> "" Then
            If InStr(1, cbTruck.Text, "_") > 0 Then
                tmpTu1 = Split(cbTruck.Text, "_")
                strSQL = " select t.fix_seal "
                strSQL = strSQL & " from tas.transport_unit t"
                strSQL = strSQL & " where t.tu_number ='" & Trim(tmpTu1(1)) & "' "


                If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                    dt = mDataSet.Tables("TableName1")
                    If dt.Rows.Count > 0 Then
                        tmpSeal = CInt(IIf(IsDBNull(dt.Rows(i).Item("fix_seal")), "", dt.Rows(i).Item("fix_seal").ToString))
                    End If
                End If
            End If
        End If
        If cbTu_Tail.Text <> "" Then
            If InStr(1, cbTu_Tail.Text, "_") > 0 Then
                tmpTu1 = Split(cbTu_Tail.Text, "_")
                strSQL = " select t.fix_seal "
                strSQL = strSQL & " from tas.transport_unit t"
                strSQL = strSQL & " where t.tu_number ='" & Trim(tmpTu1(1)) & "' "
                If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                    dt = mDataSet.Tables("TableName1")
                    If dt.Rows.Count > 0 Then
                        tmpSeal = tmpSeal + CInt(IIf(IsDBNull(dt.Rows(i).Item("fix_seal")), "", dt.Rows(i).Item("fix_seal").ToString))
                    End If
                End If
            End If
        End If


        If tmpSeal <> 0 Then
            GetCountSeal = tmpSeal
        Else
            GetCountSeal = 1
        End If
        frmUtlAddSeal.txtSealAmount.Text = GetCountSeal
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub MSGridAddEdit_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MSGridAddEdit.CellClick
        'If e.ColumnIndex = 4 Or e.ColumnIndex = 1 Then
        '    GetdetailProduct()
        'End If
    End Sub

    Function CheckCompDuplicate() As Boolean
        Dim index As Integer = MSGridAddEdit.CurrentRow.Index
        Try
            Dim strDono = MSGridAddEdit.Rows(index).Cells(1).Value.ToString
        Catch ex As Exception

        End Try


        Dim i As Long
        Dim j As Long
        Dim inString As Long
        Dim k() As Long
        With MSGridAddEdit
            For i = 1 To MSGridAddEdit.RowCount - 1
                ReDim Preserve k(i - 1)
                k(i - 1) = MSGridAddEdit.Rows(i).Cells(0).Value.ToString '.TextMatrix(i, 0)
            Next i

            For i = 1 To MSGridAddEdit.RowCount - 1
                inString = k(i - 1)
                For j = 0 To UBound(k)
                    If k(j) = inString And j <> i - 1 Then
                        CheckCompDuplicate = True
                        Exit For
                    End If
                Next j
            Next i
        End With
    End Function

    Private Sub MSGridAddEdit_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MSGridAddEdit.CellLeave
        If e.ColumnIndex = 5 Then
            '-----------
            assTxtOrder()
            '-----------
        End If

    End Sub

    Private Function getDOselect(ByVal ILoadNo As String) As String
        Dim strSQL As String
        'Dim Oratemp As OraDynaset
        getDOselect = ""
        strSQL = _
                     "select    load.get_do_select('" & Trim(ILoadNo) & "') as doSelect   from  dual "

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                getDOselect = IIf(IsDBNull(dt.Rows(0).Item("doSelect")), "", dt.Rows(0).Item("doSelect").ToString)


                If getDOselect <> "" Then
                    If Mid(getDOselect, 1, 1) = "," Then
                        getDOselect = Mid(getDOselect, InStr(1, getDOselect, ",") + 1, Len(getDOselect))
                    End If
                End If
            End If
        End If
    End Function

    Private Sub MSGridAddEdit_CellContentClick(ByVal sender As System.Object, ByVal e As DataGridViewCellEventArgs) Handles MSGridAddEdit.CellContentClick

        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex = 5 Then
            'TODO - Button Clicked - Execute Code Here
            MessageBox.Show("YEssss")
        End If

    End Sub

    Private Sub MSGridAddEdit_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MSGridAddEdit.CellEndEdit
        assTxtOrder()
        If e.ColumnIndex = 1 Then
            GetdetailProduct()
        End If
    End Sub

    Sub assTxtOrder()
        Dim i As Integer = 0
        txtOrder.Text = 0
        Try
            Do While MSGridAddEdit.RowCount > i
                'MessageBox.Show("test = " & MSGridAddEdit.Rows(i).Cells(5).Value)
                If (MSGridAddEdit.Rows(i).Cells(5).Value).ToString = "" Then

                Else
                    If Not edit Then
                        If CType(MSGridAddEdit.Rows(i).Cells(3).Value, Integer) < CType(MSGridAddEdit.Rows(i).Cells(5).Value, Integer) Then
                            MessageBox.Show("ปริมาณสั่งเติมมากกว่าความจุช่องรถ")
                            MSGridAddEdit.Rows(i).Cells(5).Value = "0"
                        End If
                    Else
                        If CType(MSGridAddEdit.Rows(i).Cells(3).Value, Integer) < CType(MSGridAddEdit.Rows(i).Cells(5).Value, Integer) Then
                            MessageBox.Show("ปริมาณสั่งเติมมากกว่าความจุช่องรถ")
                            MSGridAddEdit.Rows(i).Cells(5).Value = "0"
                        End If
                    End If
                    txtOrder.Text = CType(CType(txtOrder.Text, Integer) + CType(MSGridAddEdit.Rows(i).Cells(5).Value, Integer), String)
                End If


                i = i + 1
            Loop
        Catch ex As Exception

        End Try
   
    End Sub

    Private Sub frmLoadLoading_sub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtLoadNo.Text = GetNextID()
        assignDropDown()
        If AELoadNo <> "" Then
            txtLoadNo.Text = AELoadNo
            ShowdetailLoad(AELoadNo)
            'showLineDataGride()
        End If
        'Column5.ReadOnly = True
    End Sub

    Private Sub cmdFindDriver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindDriver.Click
        dfindIncombo.Show()
        dfindIncombo.FindData(1, cbDriver)
    End Sub

    Private Sub cmdFinTail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFinTail.Click
        dfindIncombo.Show()
        dfindIncombo.FindData(2, cbTu_Tail)
    End Sub

    Private Sub cmdFindHead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFindHead.Click
        dfindIncombo.Show()
        dfindIncombo.FindData(3, cbTruck)
    End Sub

    Private Sub CmbFindCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbFindCard.Click
        dfindIncombo.Show()
        dfindIncombo.FindData(4, cbCard)
    End Sub


    Private Sub MSGridAddEdit_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles MSGridAddEdit.DataError
        If e.Context = DataGridViewDataErrorContexts.Formatting Or e.Context = DataGridViewDataErrorContexts.PreferredSize Then
            e.ThrowException = False
        End If
    End Sub

    Private Sub cbCard_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbCard.SelectedIndexChanged
        'SelectTruckOil()
        'SelectTuTail()
    End Sub
    Private Sub SelectTruckOil()
        Dim strSQL As String

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        strSQL = _
                     " select c.card_no,t.tu_number,t.tu_id,v.vehicle_id,v.tu_number1 " & _
                     " from card c,tas.transport_unit t,tas.vehicle v " & _
                     " where t.tu_number = c.tu_number " & _
                     " and t.tu_id = v.vehicle_id " & _
                     " and c.card_no = '" & Trim(cbCard.Text) & "'"

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                cbTruck.Text = ""
                cbTruck.Text = dt.Rows(0).Item("tu_id").ToString & "_" & dt.Rows(0).Item("tu_number").ToString
                TuTail = dt.Rows(0).Item("tu_number1").ToString
            Else
                cbTruck.Text = ""
                TuTail = ""
                cbDriver.Text = ""
            End If
        End If
    End Sub
    Private Sub SelectTuTail()
        Dim strSQL As String

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        strSQL = _
                     " select t.tu_number,t.tu_id from tas.transport_unit t " & _
                     " where t.tu_number = '" & Trim(TuTail) & "'"

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                cbTu_Tail.Text = ""
                cbTu_Tail.Text = dt.Rows(0).Item("tu_id").ToString & "_" & dt.Rows(0).Item("tu_number").ToString
            Else
                cbTu_Tail.Text = ""
            End If
        End If
    End Sub

    Private Sub txtDo_TextChanged(sender As Object, e As EventArgs) Handles txtDo.TextChanged
        'ClearDataAddEdit()
        If Not edit Then
            CheckDoDetail()
        
        End If

    End Sub
    Function CheckDoDetail() As Boolean
        Dim vCheck As Boolean = False
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim arrDo = Split(txtDo.Text, ",")
        Try

            strSQL = _
                " select t.tu_number,t.tu_id,v.vehicle_id,v.tu_number1,dr.first_name||'  '||dr.last_name ||'_'||  dr.driver_id    as  driver_Name " & _
                " from do_header d,tas.transport_unit t,tas.vehicle v,tas.driver dr " & _
                " where t.tu_number = d.truck_id1 " & _
                " and t.tu_id = v.vehicle_id " & _
                " and d.driver_id = dr.driver_id " & _
                " and d.do_NO = '" & Trim(arrDo(0)) & "'"

            If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                vCheck = True
                dt = mDataSet.Tables("TableName1")
                If dt.Rows.Count > 0 Then
                    cbTruck.Text = ""
                    cbTruck.Text = dt.Rows(0).Item("tu_id").ToString & "_" & dt.Rows(0).Item("tu_number").ToString
                    TuTail = dt.Rows(0).Item("tu_number1").ToString
                    cbDriver.Text = dt.Rows(0).Item("driver_Name").ToString
                    CheckCardNO(Trim(dt.Rows(0).Item("tu_number").ToString))
                Else
                    cbCard.Text = ""
                    cbTruck.Text = ""
                    cbTu_Tail.Text = ""
                    cbDriver.Text = ""
                End If
            End If
        Catch ex As Exception

        End Try
        Return vCheck
    End Function
    Private Sub CheckCardNO(ByVal tu_number As String)
        Dim vCheck As Boolean = False
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Try
            sql_str = " select c.card_no,c.tu_number,c.card_no,t.tu_id  from tas.card c,tas.transport_unit t  where c.card_type=0  and c.is_enabled=1and c.tu_number=t.tu_number(+)  "
            sql_str = sql_str & " and not exists(select  h.tu_card_no "
            sql_str = sql_str & " from  oil_load_entrycard  h where c.card_no=h.tu_card_no  ) "
            sql_str = sql_str & " and  c.tu_number = '" & tu_number & "' "
            sql_str = sql_str & " order by c.card_no "
            If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
                dt = mDataSet.Tables("TableName1")
                If dt.Rows.Count > 0 Then
                    cbCard.Text = ""
                    cbCard.Text = Trim(dt.Rows(0).Item("card_no"))
                    SelectTruckOil()
                    SelectTuTail()
                Else
                    'MessageBox.Show("ไม่พบหมายเลขบัตร หรือบัตรหมายเลขนี้อยู่ในกระบวนการจ่าย")
                    cbCard.Text = ""
                    cbTruck.Text = ""
                    cbTu_Tail.Text = ""
                    cbDriver.Text = ""
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    
    Private Sub cbDriver_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbDriver.SelectedIndexChanged

    End Sub

    Private Sub cbDriver_TextChanged(sender As System.Object, e As System.EventArgs) Handles cbDriver.TextChanged
        'MSGridAddEdit.Rows.Clear()
        'MSGridTotDo.Rows.Clear()
        'cmdAssignComp_Click()
        'initComDo()
        'GetdetailProduct()
        'assTxtOrder()
    End Sub
End Class