Public Class frmLoadOldDataVechicle
    Private Chk As Boolean
    Private Tu_id As String
    Private Tu_name As String
    Private Tu_First As String
    Private vLoadNo As String
    Private Sub frmLoadOldDataVechicle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtTuName1.Text = Tu_name
        'txtTuName2.text = "- -"
        'TxtDriverName.text = "- -"
    End Sub
    Public Sub GetTuID(iTuID_Name As String)
        Dim strTemp() As String
        Chk = False
        If iTuID_Name = "" Then Exit Sub
        strTemp = Split(iTuID_Name, "_")
        Tu_id = Trim(strTemp(1))
        Tu_name = Trim(strTemp(1))
        Tu_First = Trim(strTemp(0))
        ShowData("")
    End Sub
    Private Sub ShowData(iDate As String)
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim strSQL As String
        Dim tmpString As String
        If iDate = "" Then
            tmpString = "where  olh.tu_number ='" & Tu_id & "'  "
        Else
            tmpString = "where  olh.tu_number ='" & Tu_id & "'   and to_date( olh.eod_date) =to_date('" & iDate & "','dd/mm/yy')"
        End If

        strSQL = _
                        " select " & _
                        " trunc(olh.eod_date) as  eod_date , " & _
                        " olh.load_header_no , " & _
                        " olh.vehicle_id ||'/'|| olh.vehicle_number as  vehicle, " & _
                        " olh.tu_number , " & _
                        " olh.tu_id  as Tu_name1 , " & _
                        " olh.tu_id1 as Tu_name2, " & _
                        " olh.driver_name " & _
                        " from tas.oil_load_headers  olh ,  ( select max(t.load_header_no) as MaxLoadNo  from tas.oil_load_headers t   where   t.tu_number ='" & Trim(Tu_id) & "')  s  " & _
                        "" & tmpString & "     and s.MaxLoadNo = olh.load_header_no " & _
                        " order by olh.eod_date desc  "

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")

            If dt.Rows.Count > 0 Then
                i = 0
              
                ' ShowDataFlexLine(IIf(IIf(IsDBNull(dt.Rows(i).Item("LOAD_HEADER_NO")), "", dt.Rows(i).Item("LOAD_HEADER_NO").ToString)))
                With msFlexLoad
                    For i = 0 To dt.Rows.Count - 1
                        .RowCount = .RowCount + 1
                        .Rows.Item(i).Height = Grid_Height
                        .Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("eod_date")), "", dt.Rows(i).Item("eod_date").ToString)
                        .Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOAD_HEADER_NO")), "", dt.Rows(i).Item("LOAD_HEADER_NO").ToString)
                        vLoadNo = IIf(IsDBNull(dt.Rows(i).Item("LOAD_HEADER_NO")), "", dt.Rows(i).Item("LOAD_HEADER_NO").ToString)
                        .Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("vehicle")), "", dt.Rows(i).Item("vehicle").ToString)
                        .Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Tu_name1")), "", dt.Rows(i).Item("Tu_name1").ToString)
                        .Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Tu_name2")), "", dt.Rows(i).Item("Tu_name2").ToString)
                        .Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("driver_name")), "", dt.Rows(i).Item("driver_name").ToString)

                        txtVechicle.Text = IIf(IsDBNull(dt.Rows(i).Item("vehicle")), "", dt.Rows(i).Item("vehicle").ToString)
                        txtTuName1.Text = IIf(IsDBNull(dt.Rows(i).Item("Tu_name1")), "", dt.Rows(i).Item("Tu_name1").ToString)
                        txtTuName2.Text = IIf(IsDBNull(dt.Rows(i).Item("Tu_name2")), "", dt.Rows(i).Item("Tu_name2").ToString)
                        txtDriverName.Text = IIf(IsDBNull(dt.Rows(i).Item("driver_name")), "", dt.Rows(i).Item("driver_name").ToString)
                    Next i
                End With
                ShowDataLine(vLoadNo)
            Else
                MsgBox("ไม่พบข้อมูลเก่าของทะเบียน " & Tu_First & "-" & Tu_name & "")
                Me.Close()
                Exit Sub
            End If
        End If
        mDataSet = Nothing
    End Sub
    Private Sub ShowDataLine(iLoadHeder As String)
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim strSQL As String
        Dim tmpString As String
        If iLoadHeder = "" Then Exit Sub
        strSQL = _
                        " select " & _
                        " oll.compartment_no , " & _
                        " oll.compament_capacity , " & _
                        " oll.sale_product_id ||'/'|| oll.sale_product_name as product , " & _
                        " oll.preset , oll.loaded_gross, oll.bay_no, oll.meter_no " & _
                        " from   tas.oil_load_lines  oll " & _
                        " where  oll.load_header_no ='" & iLoadHeder & "' " & _
                        " order by oll.compartment_no "


        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")

            If dt.Rows.Count > 0 Then
                With msFlexLine
                    For i = 0 To dt.Rows.Count - 1
                        .RowCount = .RowCount + 1
                        .Rows.Item(i).Height = Grid_Height
                        .Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("COMPARTMENT_NO")), "", dt.Rows(i).Item("COMPARTMENT_NO").ToString)
                        .Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("compament_capacity")), "", dt.Rows(i).Item("compament_capacity").ToString)
                        .Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("product")), "", dt.Rows(i).Item("product").ToString)
                        .Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("preset")), "", dt.Rows(i).Item("preset").ToString)
                        .Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("loaded_gross")), "", dt.Rows(i).Item("loaded_gross").ToString)
                        .Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("bay_no")), "", dt.Rows(i).Item("bay_no").ToString)
                    Next i
                End With

            End If
        End If
        mDataSet = Nothing

    End Sub
End Class