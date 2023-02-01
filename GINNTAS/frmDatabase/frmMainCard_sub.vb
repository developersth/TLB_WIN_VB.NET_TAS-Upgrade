Imports Oracle.DataAccess.Client
Imports System.Data



Public Class frmMainCard_sub
    Dim frm_work As Integer = 0 'Card=add ,2=Edit
    Dim pk_id As String = ""

    Private Sub frmMainCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        If frm_work = 1 Then
            DTPDateEXP.Value = DateAdd("YYYY", 1, DateTime.Today)
            Me.Text = "Card # Add"
            GetNextID()
        ElseIf frm_work = 2 Then
            Me.Text = "Card # Edit"
            AssignValue()
        End If
        txtLock(True)
    End Sub

    Private Sub Clear_frm()
        txtCardID.Text = ""
        cbTruck.Items.Clear()
        OptIsUsed.Checked = True
        OptTructType1.Checked = True
        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""
        OptEnabled.Checked = True

    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        If frm_work = 2 Then
            txtCard.Enabled = Not iBoo
            txtCardID.Enabled = Not iBoo
            txtLastUpdateDate.Enabled = Not iBoo
            txtLastUpdateBy.Enabled = Not iBoo

            If iBoo Then
                txtCard.BackColor = Color.LightGray
                txtCardID.BackColor = Color.LightGray
                txtLastUpdateDate.BackColor = Color.LightGray
                txtLastUpdateBy.BackColor = Color.LightGray

            Else
                txtCard.BackColor = Color.White
                txtCardID.BackColor = Color.White
                txtLastUpdateDate.BackColor = Color.White
                txtLastUpdateBy.BackColor = Color.White
            End If
        End If

    End Sub

#Region "Menu Event"
    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave
      
        If frm_work = 1 Then 'Add  
            If CheckDataExist(txtCardID.Text) Then
                GetNextID()
                Exit Sub
            End If
            If txtCardID.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If txtCardID.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Edit()
            End If
        End If
    End Sub
    Function CheckDataExist(ByVal ip As Integer) As Boolean
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim vCheck As Boolean = False
        strSQL = _
            "select count(C.CARD_NO) as vCount " & _
               "from CARD C " & _
               "where C.CARD_NO = " & ip
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            If dt.Rows.Count > 0 Then
                If dt.Rows(i).Item("vCount") > 0 Then
                    MsgBox("มีรหัสบัตร " & ip & " อยู่ในฐานข้อมูลแล้ว", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                    vCheck = True
                Else
                    vCheck = False
                End If
            End If
        End If
        Return vCheck
    End Function
    Private Sub UcCancel1_OnClickCancel(ByVal ucName As System.String) Handles UcCancel1.OnClickCancel
        Me.Close()
        'Initial_frm()
    End Sub

#End Region

    Private Sub Save()
        Dim vCardType As Integer
        If OptTructType1.Checked = True Then
            vCardType = 0
        ElseIf OptTructType2.Checked = True Then
            vCardType = 1
        Else
            vCardType = 2
        End If


        Dim strSQL As String

        Dim strDate = DTPDateEXP.Value.ToString.Split(" ")
        Dim dateExp = strDate(0)

        Dim strTime = DTPTimeEXP.Value.ToString.Split(" ")
        Dim timeExp = strTime(1)
        Dim arrTuNum() As String
        Dim strTuNum As String
        Dim strTuId As String
        If Not cbTruck.Text.Equals("") Then
            arrTuNum = cbTruck.Text.ToString.Split("-")
            strTuNum = arrTuNum(0)
            strTuId = arrTuNum(1)
        Else
            strTuNum = 0
            strTuId = 0
        End If
       
        Dim dateTimeExp = dateExp & " " & timeExp
        strSQL = _
        "insert into CARD (" & _
        "CARD_NO,TU_NUMBER,CARD_CODE,CARD_TYPE," & _
        "IS_ENABLED,CREATION_DATE," & _
        " IS_EXPIRE  ," & _
        "CREATED_BY,UPDATE_DATE," & _
        "UPDATED_BY ,EXPIRE_DATE) " & _
        "values(" & _
        Val(Trim(txtCardID.Text)) & ",'" & Trim(strTuNum) & "'," & Val(Trim(txtCardID.Text)) & "," & vCardType & "," & _
        IIf(OptEnabled.Checked = True, 1, 0) & ",sysdate," & _
        IIf(OptIsUsed.Checked = True, 1, 0) & "," & _
        "'" & mUserName & "',sysdate," & _
        "'" & mUserName & "'," & _
        "TO_DATE('" & dateTimeExp & "', 'dd/mm/yyyy hh24:mi:ss')  )"
        'MessageBox.Show(strSQL)
        If Oradb.ExeSQL(strSQL) Then
            Call AddJournal(JournalType.Jevent, 406, 100, mUserName, 406201, Trim(txtCard.Text))
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmMainCard_main.Show_Data()
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

        Dim vCardType As Integer
        If OptTructType1.Checked = True Then
            vCardType = 0
        ElseIf OptTructType2.Checked = True Then
            vCardType = 1
        Else
            vCardType = 2
        End If
        Dim strDate = DTPDateEXP.Value.ToString.Split(" ")
        Dim dateExp = strDate(0)
        Dim strTime = DTPTimeEXP.Value.ToString.Split(" ")
        Dim timeExp = strTime(1)
        Dim dateTimeExp = dateExp & " " & timeExp
        Dim arrTuNum = cbTruck.Text.ToString.Split("-")
        Dim strTuNum = arrTuNum(0)
        Dim strTuID = arrTuNum(1)
        Dim strSQL As String = _
        "update CARD  set " & _
        "TU_NUMBER ='" & Trim(strTuNum) & "'," & _
        "CARD_CODE=" & txtCardID.Text & "," & _
        "CARD_TYPE= " & vCardType & "," & _
        "IS_ENABLED=" & IIf(OptEnabled.Checked = True, 1, 0) & "," & _
        "IS_EXPIRE=" & IIf(OptIsUsed.Checked = True, 1, 0) & "," & _
        "UPDATE_DATE = sysdate," & _
        "UPDATED_BY='" & mUserName & "'," & _
        "EXPIRE_DATE= TO_DATE('" & dateTimeExp & "', 'dd/mm/yyyy hh24:mi:ss')" & "" & _
        "where CARD_NO=" & txtCard.Text
        If Oradb.ExeSQL(strSQL) Then
            Call AddJournal(JournalType.Jevent, 406, 100, mUserName, 406202, Trim(txtCard.Text))
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmMainCard_main.Show_Data()
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
        "select C.CARD_NO,C.CARD_CODE, c.EXPIRE_DATE,c.IS_EXPIRE,T.TU_ID,C.TU_NUMBER,C.CARD_TYPE,C.IS_ENABLED,C.UPDATE_DATE,C.UPDATED_BY  " & _
        "from CARD  C,TRANSPORT_UNIT  T  " & _
        "where C.CARD_NO='" & pk_id & "' And C.TU_NUMBER = T.TU_NUMBER(+) "
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            txtCard.Text = IIf(IsDBNull(dt.Rows(i).Item("CARD_NO")), "", dt.Rows(i).Item("CARD_NO").ToString)
            txtCardID.Text = IIf(IsDBNull(dt.Rows(i).Item("CARD_CODE")), "", dt.Rows(i).Item("CARD_CODE").ToString)
            setListboxWithName(IIf(IsDBNull(dt.Rows(i).Item("TU_NUMBER")), "", dt.Rows(i).Item("TU_NUMBER")), cbTruck)
            If IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", dt.Rows(i).Item("IS_ENABLED").ToString) = 0 Then
                OptUnEnbled.Checked = True
            Else
                OptEnabled.Checked = True
            End If
  
            If IIf(IsDBNull(dt.Rows(i).Item("IS_EXPIRE")), "", dt.Rows(i).Item("IS_EXPIRE").ToString) = 1 Then
                OptIsUsed.Checked = True
            Else
                OptUnUsed.Checked = True
            End If

            If IIf(IsDBNull(dt.Rows(i).Item("CARD_TYPE")), "", dt.Rows(i).Item("CARD_TYPE").ToString) = 0 Then
                OptTructType1.Checked = True
            ElseIf IIf(IsDBNull(dt.Rows(i).Item("CARD_TYPE")), "", dt.Rows(i).Item("CARD_TYPE").ToString) = 1 Then
                OptTructType2.Checked = True
            Else
                OptTructType3.Checked = True
            End If

            DTPDateEXP.Text = IIf(IsDBNull(dt.Rows(i).Item("EXPIRE_DATE")), "", dt.Rows(i).Item("EXPIRE_DATE").ToString)
            DTPTimeEXP.Text = IIf(IsDBNull(dt.Rows(i).Item("EXPIRE_DATE")), "", dt.Rows(i).Item("EXPIRE_DATE").ToString)
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


    Function assignDropDown() As Boolean
        Dim sql_str As String
        sql_str = _
        "select T.TU_ID,T.TU_NUMBER,T.TU_NUMBER ||' - '||T.TU_ID AS TuNAME " & _
        " from TRANSPORT_UNIT T order by T.TU_NUMBER"
        assignDropDown(sql_str, "TuNAME", cbTruck)

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
        " select MAX((card_code)+1) as MaxID from card "
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            txtCardID.Text = IIf(IsDBNull(dt.Rows(0).Item("MaxID")), "", dt.Rows(0).Item("MaxID").ToString)
        End If
        Return 1
    End Function

    Private Sub txtCard_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCard.KeyPress
        e.Handled = CurrencyOnly(txtCard, e.KeyChar)
    End Sub

    Private Sub cmdFindVehicle_Click(sender As System.Object, e As System.EventArgs) Handles cmdFindVehicle.Click
        dfindIncombo.Show()
        dfindIncombo.FindData(8, cbTruck)
    End Sub

    Private Sub txtCardID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCardID.KeyPress
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

