Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmMainShipTo_main
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=add ,2=Edit

    Private Sub frmMainShipTo_main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmMainShipTo_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        'Initial_frm()
        cmbListCus.Text = "All"
        assignDropDown()
        Show_Data(cmbListCus.Text)
        'cmbListCus.Left = DataGridView1.Left
        'cmbListCus.Top = DataGridView1.Top - 30

    End Sub

    Private Sub frmMainShipTo_main_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Initial_frm()
        frm_work = 0
        DataGridView1.Left = (Me.Width * 8) / 100
        DataGridView1.Width = Me.Width - (DataGridView1.Left * 3)
        DataGridView1.Top = 210
        DataGridView1.Height = (Me.Height / 2) + (DataGridView1.Height / 2)

        'UcInsert1.Left = (DataGridView1.Left * 1.5) + DataGridView1.Width
        'UcInsert1.Top = DataGridView1.Top
        'UcEdit1.Left = UcInsert1.Left
        'UcEdit1.Top = UcInsert1.Top + 100
        'UcDelete1.Left = UcInsert1.Left
        'UcDelete1.Top = UcInsert1.Top + 200
        'UcSearch1.Left = UcInsert1.Left
        'UcSearch1.Top = UcInsert1.Top + 300
        'UcReflesh1.Left = UcInsert1.Left
        'UcReflesh1.Top = UcInsert1.Top + 400
    End Sub

    Public Sub Show_Data(ByVal iString As String)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim tmpStr() As String
        Dim tmp As String
        If Trim(iString) <> "All" Then
            tmpStr = Split(iString, "-")
            tmp = " and  t.Customer_code = '" & Trim(tmpStr(0)) & "' Order by  b.document_date  desc"
        Else
            tmp = "Order by  t.Customer_code  , t.shipto_code "
        End If





        ' '---------------------o


        ' sql_str = _
        '" select D.DRIVER_ID as ""รหัสพนักงานขับรถ"",D.Driver_code as ""รหัสอ้างอิง"",D.FIRST_NAME || '  ' || D.LAST_NAME as ""ชื่อ - นามสกุล"", " & _
        '" D.PERSONAL_ID as ""เลขบัตรประชาชน"",D.CARRIER_ID as ""ผูู้ขนส่ง"",D.ADDRESS as ""ทีอยู่""," & _
        '" d.LICENSE as ""เลขใบขับขี่"" , d.EXPIRE_DATE as ""วันหมดอายุใบขับขี่"", d.IS_ENABLED as ""สถานะใช้งาน"", d.UPDATE_DATE as ""วันที่แก้ไขล่าสุด"", d.UPDATED_BY as ""แก้ไขโดย""" & _
        '" from DRIVER D,Carrier C " & _
        '"where d.carrier_id=c.carrier_id(+) order by d.FIRST_NAME"
        ' '--------------new--------------

        ' sql_str = _
        '  " select   t.shipto_code , b.document_date , c.customer_name as ""รหัสลูกค้า"",t.* " & _
        ' " from ship_to t ,  tas.customer  c , (  " & _
        ' " select  oc.customer_code ,oc.ship_to_code , max(oc.customer_name) as customer_name ,  " & _
        ' " max(oc.document_date) As document_date " & _
        ' " from  tas.oil_customer  oc " & _
        ' " group by oc.customer_code ,oc.ship_to_code " & _
        ' " order by max(oc.document_date)   ) b  " & _
        ' " where t.shipto_code = b.ship_to_code(+) " & _
        ' " and t.customer_code = b.customer_code(+)     and t.customer_code = c.customer_code  " & _
        ' " " & Trim(tmp) & " "





        '----------------------0
        sql_str = _
        " select   t.customer_code as ""รหัสลูกค้า"", c.customer_name as ""ชื่อลูกค้า"",t.shipto_code , to_date(b.document_date,'dd/mm/yyyy')  as ""วันที่ใช้ล่าสุด"" " & _
        " ,t.ShipTo_name as ""ส่งมาถึง"" " & _
        " ,t.SHIPTO_CONTRACT as ""ตามสัญญา/ใบสั่งซื้อ"" " & _
        " ,t.SHIPTO_INDDEP as ""สังกัด"" " & _
        " ,t.SHiPTO_TOPROJECT as ""ส่งของให้ที่โครงการ"" " & _
        " ,t.POSTAL_CODE as ""รหัสไปรษณี"" " & _
        " ,t.TEL as ""เบอร์โทร"" " & _
        " ,t.UPDATE_DATE as ""วันที่แก้ไขล่าสุด"" " & _
        " ,case t.GOV_PROJECT when 0 then 'หน่วยงานอื่น' else 'กรมทาง' end as ""เป็นโครงการของหน่วยงาน"" " & _
        " ,case t.DISTRIBUTION_CHANEL when 1 then 'EXPORT' else '' end as ""Export"" " & _
        " ,t.UPDATED_BY as ""แก้ไขโดย"" " & _
        " from ship_to t ,  tas.customer  c , (  " & _
        " select  oc.customer_code  ,oc.ship_to_code , max(oc.customer_name) ,  " & _
        " max(oc.document_date) as document_date " & _
        " from  tas.oil_customer  oc " & _
        " group by oc.customer_code ,oc.ship_to_code " & _
        " order by max(oc.document_date)   ) b  " & _
        " where t.shipto_code = b.ship_to_code(+) " & _
        " and t.customer_code = b.customer_code(+)     and t.customer_code = c.customer_code  " & _
        " " & Trim(tmp) & " "
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            'DataGridView1.RowCount = 0
            'Do While dt.Rows.Count > i

            '    DataGridView1.RowCount = DataGridView1.RowCount + 1
            '    DataGridView1.Rows.Item(i).Height = Grid_Height
            '    DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("customer_code")), "", dt.Rows(i).Item("customer_code").ToString)
            '    DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("customer_name")), "", dt.Rows(i).Item("customer_name").ToString)
            '    DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("shipto_code")), "", dt.Rows(i).Item("shipto_code").ToString)
            '    DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("document_date")), "", dt.Rows(i).Item("document_date"))
            '    DataGridView1.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ShipTo_name")), "", dt.Rows(i).Item("ShipTo_name").ToString)
            '    DataGridView1.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SHIPTO_CONTRACT")), "", dt.Rows(i).Item("SHIPTO_CONTRACT").ToString)
            '    DataGridView1.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SHIPTO_INDDEP")), "", dt.Rows(i).Item("SHIPTO_INDDEP").ToString)
            '    DataGridView1.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SHiPTO_TOPROJECT")), "", dt.Rows(i).Item("SHiPTO_TOPROJECT").ToString)
            '    DataGridView1.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("POSTAL_CODE")), "", dt.Rows(i).Item("POSTAL_CODE").ToString)
            '    DataGridView1.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("TEL")), "", dt.Rows(i).Item("TEL").ToString)
            '    DataGridView1.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", Format(dt.Rows(i).Item("UPDATE_DATE"), "dd/MM/yyyy HH:mm:ss"))
            '    DataGridView1.Item(11, i).Value = IIf(IsDBNull(dt.Rows(i).Item("GOV_PROJECT")), "", IIf(dt.Rows(i).Item("GOV_PROJECT").ToString = 1, "หน่วยงานอื่น", "กรมทาง"))
            '    DataGridView1.Item(12, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DISTRIBUTION_CHANEL")), "", IIf(dt.Rows(i).Item("DISTRIBUTION_CHANEL").ToString = 1, "EXPORT", ""))
            '    DataGridView1.Item(13, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
            '    i = i + 1
            'Loop
            DataGridView1.DataSource = dt
            txtTotalRecord.Text = dt.Rows.Count
            For i = 0 To DataGridView1.ColumnCount - 1
                Dim col As New DataGridViewColumn
                col = DataGridView1.Columns(i)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Next
        Else
        End If
        mDataSet = Nothing
    End Sub

    Function assignDropDown() As Boolean
        Dim sql_str As String
        sql_str = _
        " select c.customer_code ,c.customer_name , " & _
        " c.customer_code ||'--'||c.customer_name as cutomer " & _
        "  from tas.customer  c   order by c.customer_code"
        assignDropDown(sql_str, "cutomer", cmbListCus)
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

    Private Function appendZero(ByVal codeColour As String) As String
        Dim i As Integer = 6 - codeColour.Length
        While (i <> 0)
            codeColour = "0" + codeColour
            i = i - 1
        End While
        Return codeColour
    End Function

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Delete()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        sql_str = " DELETE FROM SHIP_TO     "
        sql_str = sql_str & " WHERE  SHIPTO_CODE = '" + DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString + "' "
        sql_str = sql_str & " AND CUSTOMER_CODE = '" + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + "' "
        If Oradb.ExeSQL(sql_str) Then
            MessageBox.Show("ได้ทำการลบข้อมูลเรียบร้อย", "System TAS")
            Show_Data(cmbListCus.Text)
        Else
            MessageBox.Show("ไม่สามารถลบข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
    End Sub

    Private Sub cmbListCus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbListCus.SelectedIndexChanged
        Show_Data(cmbListCus.Text)
    End Sub
#Region "Menu Event"

    Private Sub UcMenuRefresh_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuRefresh.OnClickMnuText
        Show_Data(cmbListCus.Text)
    End Sub

    Private Sub UcMenuAdd_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuAdd.OnClickMnuText
        frmMainShipTo_sub.Close()
        frmMainShipTo_sub.setFrmWork(1)
        frmMainShipTo_sub.ShowDialog()
    End Sub

    Private Sub UcMenuEdit_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuEdit.OnClickMnuText
        Dim id As String
        Dim ChipToCode As Integer
        id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        ChipToCode = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        frmMainShipTo_sub.Close()
        frmMainShipTo_sub.setFrmWork(2)
        frmMainShipTo_sub.setPkId(id)
        frmMainShipTo_sub.setChipToCode(ChipToCode)
        frmMainShipTo_sub.ShowDialog()
    End Sub

    Private Sub UcMenuDelete_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuDelete.OnClickMnuText
        Dim result As Integer = MessageBox.Show("ต้องการลบข้อมูล : " + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + " หรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            Delete()
        End If
    End Sub

    Private Sub UcMenuSacrch_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuSacrch.OnClickMnuText
        frmFind.Close()
        frmFind.InitialFormFind(DataGridView1)
        frmFind.ShowDialog()
    End Sub
#End Region
    Private Sub UcHeader1_CloseButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.CloseButtonClick
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UcHeader1_MinimizeButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.MinimizeButtonClick
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub UcBack1_Click(sender As Object, e As EventArgs) Handles UcBack1.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub UcBack1_MouseHover(sender As Object, e As EventArgs) Handles UcBack1.MouseHover
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("Back1")
    End Sub

    Private Sub UcBack1_MouseLeave(sender As Object, e As EventArgs) Handles UcBack1.MouseLeave
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("back")
    End Sub

    Private Sub UcBack1_Load(sender As System.Object, e As System.EventArgs) Handles UcBack1.Load

    End Sub
End Class

