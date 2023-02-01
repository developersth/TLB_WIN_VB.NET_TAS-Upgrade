Public Class frmLoadEditVolumeDo
    Public Do_NO As String
    Private Sub frmLoadEditVolumeDo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_Data(Do_NO)
    End Sub
    Private Sub Show_Data(iDo As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        txtDo.Text = Do_NO
        sql_str = " SELECT L.DO_NO,SPECIAL_TEXT1,L. ITEM_NO,L.MATERIAL_NO,L.QUANTITY, D.SALE_ORDER ,D.DISTRIBUTION_CHANEL,"
        sql_str = sql_str & " L.SALE_UNIT,D.WEIGHT_UNIT,L.PLANT,L.STORAGE_LOCATION ,L.SHIPTO_NAME,"
        sql_str = sql_str & " L.TRQNT  ,L.STATUS , L.CREATION_DATE, L.CREATED_BY, L.UPDATE_DATE, D.SHIPTO_PONO,D.SHIPTO_INDDEP,D.SHIPTO_TOPROJECT,D.SHIPTO_CONTRACT,"
        sql_str = sql_str & " L.UPDATED_BY, L.J_COMPUTER, S.SALE_PRODUCT_NAME,"
        sql_str = sql_str & " D.GOV_PROJECT,D.CUSTOMER_CODE,D.SHIPTO,D.DOCUMENT_DATE,D.J_COMPUTER,SPECIAL_TEXT1,"
        sql_str = sql_str & " D.PLAN_DATE,D.DO_STATUS,D.CREATION_DATE,D.CREATED_BY,C.CUSTOMER_NAME,"
        sql_str = sql_str & " C.CUSTOMER_CODE ||'--'||C.CUSTOMER_NAME AS CUSTOMER , D.SHIP_TO_CODE ||'--'||D.SHIPTO AS SHIPTOMiX , D.MEASURE_MOTHOD , D.CALCULATE_MOTHOD "
        sql_str = sql_str & " FROM DO_LINES L,SALE_PRODUCT S,DO_HEADER D,CUSTOMER C"
        sql_str = sql_str & " WHERE  L.MATERIAL_NO=S.SALE_PRODUCT_ID AND L.DO_NO='" & iDo & "'   "
        sql_str = sql_str & " AND D.DO_NO=L.DO_NO AND D.CUSTOMER_CODE=C.CUSTOMER_CODE ORDER BY L.ITEM_NO"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                txtProduct.Text = IIf(IsDBNull(dt.Rows(0).Item("MATERIAL_NO")), "", dt.Rows(0).Item("MATERIAL_NO").ToString & "-" & dt.Rows(0).Item("SALE_PRODUCT_NAME").ToString)
                txtVolumeOld.Text = IIf(IsDBNull(dt.Rows(0).Item("QUANTITY")), "", dt.Rows(0).Item("QUANTITY").ToString)
            End If

        End If
    End Sub
    Private Sub Edit()
        Dim sql_str As String

        sql_str = _
            " update do_lines t " & _
            " set t.quantity = '" & Trim(txtVolumeNew.Text) & "' " & _
            " where t.do_no = '" & Trim(Do_NO) & "' " & _
            " and t.item_no = '1' "
        If Oradb.ExeSQL(sql_str) Then
            MessageBox.Show("แก้ไขปริมาณผลิตภัณฑ์เรียบร้อยแล้ว")
            Me.Close()
        End If
    End Sub

    Private Sub btCancle_Click(sender As Object, e As EventArgs) Handles btCancle.Click
        Me.Close()
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        If txtVolumeNew.Text = "" Then
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านยังไม่ได้ใส่ข้อมูล ปริมาณผลิตภัณฑ์ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            Exit Sub
        End If
        Edit()
    End Sub

    
    Private Sub txtVolumeNew_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVolumeNew.KeyPress
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
End Class