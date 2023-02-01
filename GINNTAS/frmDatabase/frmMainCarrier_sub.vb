Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmMainCarrier_sub
    Dim frm_work As Integer = 0 'Carrier1=add ,2=Edit
    Dim pk_id As String = ""

    Private Sub frmMainCarrier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        If frm_work = 1 Then
            Me.Text = "Carrier # Add"
            GetNextID()
        ElseIf frm_work = 2 Then
            Me.Text = "Carrier # Edit"
            AssignValue()
        End If
        txtLock(True)
    End Sub

    Private Sub Clear_frm()
        txtCarrierID.Text = ""
        txtCarrierName.Text = ""
        cbCarrierType.Items.Clear()
        txtCarrierAddr.Text = "-"
        txtTel.Text = "-"
        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""
    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        If frm_work = 2 Then
            txtCarrierID.Enabled = Not iBoo
            txtLastUpdateDate.Enabled = Not iBoo
            txtLastUpdateBy.Enabled = Not iBoo

            If iBoo Then
                txtLastUpdateDate.BackColor = Color.LightGray
                txtLastUpdateBy.BackColor = Color.LightGray
            Else
                txtLastUpdateDate.BackColor = Color.White
                txtLastUpdateBy.BackColor = Color.White
            End If
        End If
    End Sub

#Region "Menu Event"
    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave
        If frm_work = 1 Then 'Add
            If CheckDataExist(txtCarrierID.Text) Then
                GetNextID()
                Exit Sub
            End If
            If txtCarrierID.Text.Trim = "" Or txtCarrierName.Text.Trim = "" Or cbCarrierType.Text.Trim = "" Or txtCarrierAddr.Text.Trim = "" Or txtTel.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If txtCarrierID.Text.Trim = "" Or txtCarrierName.Text.Trim = "" Or cbCarrierType.Text.Trim = "" Or txtCarrierAddr.Text.Trim = "" Or txtTel.Text.Trim = "" Then
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

    Private Sub txtCarrierID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCarrierID.KeyPress
        e.Handled = CurrencyOnly(txtCarrierID, e.KeyChar)
    End Sub
#End Region
    Function CheckDataExist(ByVal ip As Integer) As Boolean
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim vCheck As Boolean = False
        strSQL = _
            "select count(C.CARRIER_ID) as vCount " & _
               "from CARRIER C " & _
               "where C.CARRIER_ID = " & ip
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            If dt.Rows.Count > 0 Then
                If dt.Rows(i).Item("vCount") > 0 Then
                    MsgBox("มีรหัสผู้ขนส่งอยู่ในฐานข้อมูลแล้ว", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                    vCheck = True
                Else
                    vCheck = False
                End If
            End If
        End If
        Return vCheck
    End Function
    Private Sub Save()
        cbStatusNum.SelectedIndex = cbCarrierType.FindString(cbCarrierType.Text)
        Dim strSQL As String
       

        strSQL = _
        "insert into CARRIER(" & _
        "CARRIER_ID,CARRIER_NAME," & _
        "CARRIER_TYPE,ADDRESS," & _
        "TEL,CREATION_DATE," & _
        "CREATED_BY,UPDATE_DATE," & _
        "UPDATED_BY) " & _
        "values(" & _
        txtCarrierID.Text & ",'" & txtCarrierName.Text & "'," & _
        "'" & cbStatusNum.Text & "','" & Trim(txtCarrierAddr.Text) & "'," & _
        "'" & txtTel.Text & "',sysdate," & _
        "'" & mUserName & "',sysdate," & _
        "'" & mUserName & "')"


        If Oradb.ExeSQL(strSQL) Then
            Call AddJournal(JournalType.Jevent, 402, 100, mUserName, 402201, Trim(txtCarrierID.Text), Trim(txtCarrierName.Text), cbCarrierType.Text)
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmMainCarrier_main.Show_Data()
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
        cbStatusNum.SelectedIndex = cbCarrierType.FindString(cbCarrierType.Text)
        Dim strSQL As String = _
        "update CARRIER C set " & _
        "C.CARRIER_NAME='" & Trim(txtCarrierName.Text) & "'," & _
        "C.CARRIER_TYPE=" & cbStatusNum.Text & "," & _
        "C.ADDRESS='" & Trim(txtCarrierAddr.Text) & "'," & _
        "C.TEL='" & Trim(txtTel.Text) & "'," & _
        "C.UPDATE_DATE=sysdate," & _
        "C.UPDATED_BY='" & mUserName & "'" & _
        "where C.CARRIER_ID=" & txtCarrierID.Text

        If Oradb.ExeSQL(strSQL) Then
            Call AddJournal(JournalType.Jevent, 402, 100, mUserName, 402202, Trim(txtCarrierID.Text), Trim(txtCarrierName.Text), cbCarrierType.Text)
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmMainCarrier_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
    End Sub

    Private Sub AssignValue()

        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        sql_str = _
        "select C.CARRIER_ID,C.CARRIER_NAME,C.CARRIER_TYPE," & _
        "C.ADDRESS,C.TEL,C.UPDATE_DATE,C.UPDATED_BY " & _
        "from CARRIER C " & _
        "where C.CARRIER_ID = " & pk_id
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0

            txtCarrierID.Text = IIf(IsDBNull(dt.Rows(i).Item("CARRIER_ID")), "", dt.Rows(i).Item("CARRIER_ID").ToString)
            txtCarrierName.Text = IIf(IsDBNull(dt.Rows(i).Item("CARRIER_NAME")), "", dt.Rows(i).Item("CARRIER_NAME").ToString)
            Dim strCbCarrierType As String = IIf(IsDBNull(dt.Rows(i).Item("CARRIER_TYPE")), "", dt.Rows(i).Item("CARRIER_TYPE").ToString)
            cbCarrierType.SelectedIndex = cbStatusNum.FindString(strCbCarrierType)
            txtCarrierAddr.Text = IIf(IsDBNull(dt.Rows(i).Item("ADDRESS")), "", dt.Rows(i).Item("ADDRESS").ToString)
            txtTel.Text = IIf(IsDBNull(dt.Rows(i).Item("TEL")), "", dt.Rows(i).Item("TEL").ToString)
            txtLastUpdateDate.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
            txtLastUpdateBy.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY"))

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

    Function assignDropDown() As Boolean
        Dim sql_str As String
        sql_str = _
        "select S.DESCRIPTION,S.STATUS_NUMBER " & _
        "from STATUS_DESC S " & _
        "where S.T_NAME='CARRIER' " & _
        "and S.COLUMNS_NAME='CARRIER_TYPE' " & _
        "order by S.STATUS_NUMBER"
        assignDropDown(sql_str, "DESCRIPTION", cbCarrierType)
        assignDropDown(sql_str, "STATUS_NUMBER", cbStatusNum)
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
        " select MAX((CARRIER_ID)+1) as MaxID from CARRIER  "
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            txtCarrierID.Text = IIf(IsDBNull(dt.Rows(0).Item("MaxID")), "", dt.Rows(0).Item("MaxID").ToString)
        End If
        Return 1
    End Function

End Class

