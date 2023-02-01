Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmConfigBaseProduct_sub
    Dim frm_work As Integer = 0 '1=add ,2=Edit
    Dim pk_id As String = ""

    Private Sub frmConfigBaseProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        If frm_work = 1 Then
            Me.Text = "BaseProduct # Add"
        ElseIf frm_work = 2 Then
            Me.Text = "BaseProduct # Edit"
            AssignValue()
        End If
        txtLock(True)
        checkQuota()
    End Sub

    Private Sub Clear_frm()
        txtProductID.Text = ""
        txtProductName.Text = ""
        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""
    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        If frm_work <> 1 Then
            txtProductID.Enabled = Not iBoo
        End If
        txtLastUpdateDate.Enabled = Not iBoo
        txtLastUpdateBy.Enabled = Not iBoo

        If iBoo Then
            If frm_work <> 1 Then
                txtProductID.BackColor = Color.LightGray
            End If
            txtLastUpdateDate.BackColor = Color.LightGray
            txtLastUpdateBy.BackColor = Color.LightGray
        Else
            txtProductID.BackColor = Color.White
            txtLastUpdateDate.BackColor = Color.White
            txtLastUpdateBy.BackColor = Color.White
        End If
    End Sub

#Region "Menu Event"
    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave
        If frm_work = 1 Then 'Add
            If txtProductID.Text.Trim = "" Or txtProductName.Text.Trim = "" Or txtColor.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            If CheckDataExists(txtProductID.Text.Trim) = False Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้ " & vbCrLf & vbCrLf & "เพราะมีผลิตภัณฑ์  " & txtProductID.Text.Trim & "  อยู่ในระบบข้อมูลแล้ว", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If txtProductName.Text.Trim = "" Or txtColor.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Edit()
            End If
        End If
    End Sub

    Private Sub UcCancel1_OnClickCancel(ByVal ucName As System.String) Handles UcCancel1.OnClickCancel
        Me.Close()
        'Initial_frm()
    End Sub

#End Region

    Private Sub Save()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim n As Integer

        sql_str = " INSERT INTO BASE_PRODUCT  ( "
        sql_str = sql_str & "  BASE_PRODUCT_ID  "
        sql_str = sql_str & " ,BASE_PRODUCT_NAME  "
        sql_str = sql_str & " ,IS_QUOTA  "
        sql_str = sql_str & " ,QUOTA_QTY  "
        If txtColor.Text <> "" Then
            sql_str = sql_str & " ,COLOR_CODE  "
        End If
        sql_str = sql_str & " ,UPDATED_BY  "
        sql_str = sql_str & " )  "
        sql_str = sql_str & " VALUES ( "
        sql_str = sql_str & "'" + txtProductID.Text + "'"
        sql_str = sql_str & ",'" + txtProductName.Text + "'"
        sql_str = sql_str & ",'" + CType(chkQuota.CheckState, String) + "'"
        sql_str = sql_str & ",'" + txtQuota.Text + "'"
        If txtColor.Text <> "" Then
            n = CType(Convert.ToInt32(txtColor.Text, 16), Integer)
            sql_str = sql_str & ",'" + n.ToString + "'"
        End If
        sql_str = sql_str & ",'" + mUserName + "'"
        sql_str = sql_str & " )  "
        If Oradb.ExeSQL(sql_str) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigBaseProduct_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
        mDataSet = Nothing
    End Sub

    Public Sub setFrmWork(ByVal n As Integer)
        Me.frm_work = n
    End Sub

    Public Sub setPkId(ByVal id As String)
        Me.pk_id = id
    End Sub

    Private Sub Edit()
        Dim sql_str As String
        'Dim mDataSet As New DataSet
        Dim n As Integer
        sql_str = " UPDATE BASE_PRODUCT SET "
        sql_str = sql_str & " BASE_PRODUCT_NAME = '" + txtProductName.Text + "' "
        If txtColor.Text <> "" Then
            n = CType(Convert.ToInt32(txtColor.Text, 16), Integer)
            sql_str = sql_str & ", COLOR_CODE = '" + n.ToString + "' "
        End If
        sql_str = sql_str & ", UPDATE_DATE = SYSDATE "
        sql_str = sql_str & ", IS_QUOTA = '" + CType(chkQuota.CheckState, String) + "' "
        sql_str = sql_str & ", QUOTA_QTY = '" + txtQuota.Text + "' "
        sql_str = sql_str & ", UPDATED_BY = '" + mUserName + "' "
        sql_str = sql_str & " WHERE BASE_PRODUCT_ID = '" + txtProductID.Text + "' "
        If Oradb.ExeSQL(sql_str) Then
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigBaseProduct_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
    End Sub

    Private Sub AssignValue()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        sql_str = "SELECT B.BASE_PRODUCT_ID,B.BASE_PRODUCT_NAME,B.BASE_PRODUCT_CODE,"
        sql_str = sql_str & "B.COLOR_CODE ,B.QUOTA_QTY,B.IS_QUOTA, B.UPDATE_DATE, B.UPDATED_BY "
        sql_str = sql_str & "FROM BASE_PRODUCT B WHERE "
        sql_str = sql_str & "  B.BASE_PRODUCT_ID = '" + pk_id + "' "
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            txtProductID.Text = IIf(IsDBNull(dt.Rows(i).Item("BASE_PRODUCT_ID")), "", dt.Rows(i).Item("BASE_PRODUCT_ID").ToString)
            txtProductName.Text = IIf(IsDBNull(dt.Rows(i).Item("BASE_PRODUCT_NAME")), "", dt.Rows(i).Item("BASE_PRODUCT_NAME").ToString)
            If IsDBNull(dt.Rows(i).Item("COLOR_CODE")) Then
                txtColor.Text = 0
                txtColor.BackColor = Color.Black
            Else
                Dim colour As String
                colour = dt.Rows(i).Item("COLOR_CODE").ToString()
                txtColor.Text = appendZero(Hex(colour.ToString))
                txtColor.BackColor = ColorTranslator.FromHtml("#" + appendZero(Hex(colour).ToString()))
            End If

            txtQuota.Text = IIf(IsDBNull(dt.Rows(i).Item("QUOTA_QTY")), "", dt.Rows(i).Item("QUOTA_QTY").ToString)
            If IIf(IsDBNull(dt.Rows(i).Item("IS_QUOTA")), "", dt.Rows(i).Item("IS_QUOTA").ToString) Then
                chkQuota.Checked = True
            End If
            txtLastUpdateDate.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
            txtLastUpdateBy.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
            i = i + 1
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

    Private Sub Search()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        sql_str = " SELECT * FROM BASE_PRODUCT WHERE 1=1 "
        If txtProductID.Text <> "" Then
            sql_str = sql_str & " AND UPPER(BASE_PRODUCT_ID) like UPPER('%" + txtProductID.Text + "%') "
        End If
        If txtProductName.Text <> "" Then
            sql_str = sql_str & " AND UPPER(BASE_PRODUCT_NAME) like UPPER('%" + txtProductName.Text + "%') "
        End If
        sql_str = sql_str & " ORDER by BASE_PRODUCT_ID"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            frmConfigBaseProduct_main.DataGridView1.RowCount = 0
            Do While dt.Rows.Count > i
                frmConfigBaseProduct_main.DataGridView1.RowCount = frmConfigBaseProduct_main.DataGridView1.RowCount + 1
                frmConfigBaseProduct_main.DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("BASE_PRODUCT_ID")), "", dt.Rows(i).Item("BASE_PRODUCT_ID").ToString)
                frmConfigBaseProduct_main.DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("BASE_PRODUCT_NAME")), "", dt.Rows(i).Item("BASE_PRODUCT_NAME").ToString)
                If IsDBNull(dt.Rows(i).Item("COLOR_CODE")) Then
                Else
                    Dim colour As String
                    colour = dt.Rows(i).Item("COLOR_CODE").ToString()
                    frmConfigBaseProduct_main.DataGridView1.Item(2, i).Value = appendZero(Hex(colour).ToString())
                    frmConfigBaseProduct_main.DataGridView1.Item(2, i).Style.BackColor = ColorTranslator.FromHtml("#" + appendZero(Hex(colour).ToString()))
                End If
                frmConfigBaseProduct_main.DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("QUOTA_QTY")), "", dt.Rows(i).Item("QUOTA_QTY").ToString)
                frmConfigBaseProduct_main.DataGridView1.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("IS_QUOTA")), "", dt.Rows(i).Item("IS_QUOTA").ToString)
                frmConfigBaseProduct_main.DataGridView1.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
                frmConfigBaseProduct_main.DataGridView1.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Function CheckDataExists(ByRef pID As String) As Boolean
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        sql_str = "SELECT BASE_PRODUCT_ID FROM BASE_PRODUCT "
        sql_str = sql_str & " Where  BASE_PRODUCT_ID = ('%" + pID + "%') "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Do While dt.Rows.Count > i
                mDataSet = Nothing
                Return False
            Loop
            'Return True
        End If
        mDataSet = Nothing
        Return True
    End Function

    Private Sub chkQuota_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        checkQuota()
    End Sub

    Private Sub checkQuota()
        txtQuota.Enabled = chkQuota.CheckState
        If chkQuota.CheckState Then
            txtQuota.BackColor = Color.White
        Else
            txtQuota.BackColor = Color.LightGray
            txtQuota.Text = ""
        End If
    End Sub

    Private Sub cmdSetColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdSetColor.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = cmdSetColor.BackColor ' initial SELECTion is current color.
        If (cDialog.ShowDialog() = DialogResult.OK) Then
            Dim colorConv As New ColorConverter
            txtColor.Text = cDialog.Color.ToArgb().ToString("x").Substring(2).ToUpper
            txtColor.BackColor = ColorTranslator.FromHtml("#" + txtColor.Text)
        End If
    End Sub

    Private Sub txtQuota_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuota.KeyPress
        e.Handled = CurrencyOnly(txtQuota, e.KeyChar)
    End Sub
End Class