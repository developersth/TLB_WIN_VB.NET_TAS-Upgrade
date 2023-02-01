Public Class frmMMIMeterSetup
    Dim txt As New Collection
    Dim vBaseProduct As String
    Dim vSaleProduct As String
    'Dim load As Integer = 0

    Private Sub frmMMIMeterSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       assignTxt()
    End Sub

    Private Sub assignTxt()
        txt.Clear()
        txt.Add(TextBox1)
        txt.Add(TextBox2)
        txt.Add(TextBox3)
        txt.Add(TextBox4)
        txt.Add(TextBox5)

    End Sub


    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Dim t As TextBox = txt(5)
        If t.Text = "" Then
            'Unload(Me)
            Me.Close()
            Exit Sub
        End If
        frmMMIBayLoading.GetMeterChange(t.Text)
        Me.Close()
        'Unload(Me)
    End Sub


    Private Sub InitailGrid()
     
    End Sub

    Public Sub GetBaseProductName(ByVal iBaseProduct As String, ByVal iComp As String, ByVal ILoadNo As String, ByVal iMeterOld As String)
        assignTxt()
        If iBaseProduct = "" Then
            MsgBox(" ข้อมูล BaseProduct  มีค่า NuLL ", vbCritical)
            vBaseProduct = ""
            Exit Sub
        Else
            txt(1).text = ILoadNo : txt(1).enabled = True
            txt(2).text = iComp : txt(2).enabled = True
            txt(3).text = iMeterOld : txt(3).enabled = True
            txt(4).text = iBaseProduct : txt(4).enabled = True
            txt(5).text = "" : txt(5).enabled = True
            vBaseProduct = Trim(iBaseProduct)
        End If
        InitailGrid()
        GetSaleProductID()
        GetDataMeterToGrid()
    End Sub

    Private Sub GetSaleProductID()
        Dim strSQL As String
        strSQL = "Select  t.sale_product_id  from tas.view_sale_base_product   t   where   t.base_product_id = '" & vBaseProduct & "'"
        Dim mDataSet As New DataSet
        Dim i As Integer = 0
        Dim dt As DataTable
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                vSaleProduct = IIf(IsDBNull(dt.Rows(i).Item("sale_product_id")), "", dt.Rows(i).Item("sale_product_id").ToString)
            End If
        End If
        mDataSet = Nothing
    End Sub

    Private Sub GetDataMeterToGrid()
        Dim strSQL As String
        ' Dim Oratemp As OraDynaset

        Dim i As Integer
        strSQL = "select  * from  tas.meter_product t where t.sale_product_id ='" & Trim(vSaleProduct) & "' order by t.meter_no"

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridMeter.RowCount = 0
            Do While dt.Rows.Count > i
                DataGridMeter.RowCount = DataGridMeter.RowCount + 1
                DataGridMeter.Rows.Item(i).Height = Grid_Height
                DataGridMeter.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Meter_no")), "", dt.Rows(i).Item("Meter_no").ToString)
                DataGridMeter.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("sale_product_name")), "", dt.Rows(i).Item("sale_product_name").ToString)

                i = i + 1

            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Sub MSFlexGridMeter_Click()

        If DataGridMeter.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim i As Integer = 0
        Do While DataGridMeter.Rows.Count > i
            txt(4).text = DataGridMeter.Item(0, i).Value
            'DataGridMeter.RowCount = DataGridMeter.RowCount + 1

            i = i + 1
        Loop
    End Sub

    Private Sub MSFlexGridMeter_DblClick()
        If DataGridMeter.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim i As Integer = 0
        Do While DataGridMeter.Rows.Count > i
            frmMMIBayLoading.GetMeterChange(Trim(DataGridMeter.Item(0, i).Value))
            i = i + 1
        Loop
    End Sub
    Private Sub Clear()
        txt(0).text = ""
        txt(1).text = ""
        txt(2).text = ""
        txt(3).text = ""
        txt(4).text = ""
        DataGridMeter.RowCount = 1
    End Sub
    Private Sub Check()
        If vSaleProduct = "" Then
            MsgBox("ท่านยังไม่ได้เลือกชช่องเตมที่ต้องการเปลี่ยนมิเตอร์  กรุณาเลือกช่องเติมก่อน", vbInformation)
            'Unload(Me)
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub DataGridMeter_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridMeter.CellClick
        'MSFlexGridMeter_Click()
        If e.RowIndex >= 0 Then
            txt(5).text = DataGridMeter.Item(0, e.RowIndex).Value
        End If
    End Sub
End Class