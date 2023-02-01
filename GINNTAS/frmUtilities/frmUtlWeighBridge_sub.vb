Imports Oracle.DataAccess.Client
Imports System.Data
Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text
Public Class frmUtlWeighBridge_sub
    Dim frm_work As Integer = 0 'CardReader1=add ,2=Edit
    Dim pk_id As String = ""
    Dim RadioEnabled As String
    Dim RadioLocked As String
    Dim vFixType As String
    Private TripleDes As New TripleDESCryptoServiceProvider
    Dim sha1 As New SHA1CryptoServiceProvider


    Private Sub frmUtlWeighBridge_sub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        If frm_work = 1 Then
            Me.Text = "WeighBridge # Add"
        ElseIf frm_work = 2 Then
            Me.Text = "WeighBridge # Edit"
            AssignValue()
        End If
        txtLock(True)
    End Sub

    Private Sub Clear_frm()

        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""
        OptEnabled.Checked = True


    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        If iBoo Then
            ' txtWBId.BackColor = Color.LightGray
            txtLastUpdateDate.BackColor = Color.LightGray
            txtLastUpdateBy.BackColor = Color.LightGray
        Else
            txtWBId.BackColor = Color.White
            txtLastUpdateDate.BackColor = Color.White
            txtLastUpdateBy.BackColor = Color.White
        End If
    End Sub

#Region "Menu Event"
    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave
        If frm_work = 1 Then 'Add
            If Trim(txtWBId.Text) = "" Or Trim(txtWBName.Text) = "" Or Trim(txtWBAddress.Text) = "" _
    Or cbCommPort.Text = "" Or cbCardReader.Text = "" _
    Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If
            If cbCommPort.Text = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            End If
            If cbCommPort2.Text = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If
            If CheckDataExists(Val(txtWBId.Text)) Then
                'MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "เนื่องจากมีหลายเลขเครื่องชั่ง " & Val(txtWBId.Text) & " อยู่ในฐานข้อมูลแล้ว", vbInformation)
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "เนื่องจากมีหลายเลขเครื่องชั่ง " & Val(txtWBId.Text) & " อยู่ในฐานข้อมูลแล้ว", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If Trim(txtWBId.Text) = "" Or Trim(txtWBName.Text) = "" Or Trim(txtWBAddress.Text) = "" _
                Or cbCommPort.Text = "" Or cbCardReader.Text = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If
            If cbCommPort.Text = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            End If
            If cbCommPort2.Text = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            If Not CheckDataExists(Trim(txtWBId.Text)) Then
                MsgBox("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & "เนื่องจากไม่พบรหัสผู้ใช้ " & Trim(txtWBId.Text) & " อยู่ในฐานข้อมูล", vbInformation)
                Exit Sub
            End If
            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Edit()
            End If
            '    Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            '    If result = DialogResult.Yes Then
            '        Edit()
            '    End If
            'End If
        Else
        End If
    End Sub

    Private Sub UcCancel1_OnClickCancel(ByVal ucName As System.String) Handles UcCancel1.OnClickCancel
        Me.Close()
        'Initial_frm()
    End Sub

#End Region

    Private Sub Save()
        Dim strSQL As String, cardID() As String
        Dim TypeID() As String
        Dim Comport() As String, Port As String, id As String
        Dim strCom2() As String, CompId2 As String, CompNo2 As String

        TypeID = Split(cbProtocal.Text, " - ")
        Comport = Split(cbCommPort.Text, " ")
        id = Comport(0)
        Port = Comport(1)
        cardID = Split(cbCardReader.Text, " ")

        If cbCommPort2.Text <> "" Then
            strCom2 = Split(cbCommPort2.Text, " ")
            CompId2 = Trim(strCom2(0))
            CompNo2 = Trim(strCom2(1))
        End If
        strSQL = _
            "insert into WEIGHT_BRIDGE(" & _
                "WEIGHT_BRIDGE_ID,WEIGHT_BRIDGE_NAME,WEIGHT_BRIDGE_ADDRESS," & _
                "COMPORT_NO,CARD_READER_ID,COMP_ID," & _
                "IS_ENABLED,CREATION_DATE,CREATED_BY,DESCRIPTION,J_COMPUTER,PROTOCAL_TYPE)" & _
            "values(" & _
                "'" & Trim(txtWBId.Text) & "','" & Trim(txtWBName.Text) & "','" & Trim(txtWBAddress.Text) & "'," & _
                "'" & Port & "','" & cardID(0) & "','" & id & "'," & _
                IIf(OptEnabled.Checked = True, 1, 0) & "," & _
                "sysdate,'" & mUserName & "'," & _
                "'" & Trim(txthistory.Text) & "'," & _
                "'" & mComputerName & "'," & Val(TypeID(0)) & ")"
        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmUtlWeighBridge_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
        ' Call AddJournal(Jevent, P_CurScreenID, 100, P_ModifyUser, 807201, Val(txtWBId), Trim(txtWBName), Trim(cbCardReader))
    End Sub



    Public Sub setFrmWork(ByVal n As Integer)
        Me.frm_work = n
    End Sub

    Public Sub setPkId(ByVal id As String)
        Me.pk_id = id
    End Sub

    Private Sub Edit()
        Dim strSQL As String, cardID() As String
        Dim TypeID() As String
        Dim Comport() As String, Port As String, id As String
        Dim strCom2() As String, CompId2 As String, CompNo2 As String

        Comport = Split(cbCommPort.Text, " ")
        id = Comport(0)
        Port = Comport(1)
        strCom2 = Split(cbCommPort2.Text, " ")
        CompId2 = Trim(strCom2(0))
        CompNo2 = Trim(strCom2(1))
        TypeID = Split(cbProtocal.Text, " - ")
        cardID = Split(cbCardReader.Text, " ")
        strSQL = _
                     "update WEIGHT_BRIDGE W set " & _
                     "W.WEIGHT_BRIDGE_ADDRESS ='" & Trim(txtWBAddress.Text) & "'," & _
                     "W.WEIGHT_BRIDGE_NAME='" & Trim(txtWBName.Text) & "'," & _
                     " W.COMPORT_NO='" & Port & "'," & _
                     "W.COMP_ID='" & id & "'," & _
                     "W.CARD_READER_ID='" & cardID(0) & "'," & _
                     " W.COMPORT_NO1='" & CompNo2 & "'," & _
                     "W.COMP_ID1='" & CompId2 & "'," & _
                     "W.IS_ENABLED=" & IIf(OptEnabled.Checked = True, 1, 0) & "," & _
                     "W.UPDATE_DATE=sysdate," & _
                     "W.UPDATED_BY='" & mUserName & "'," & _
                     "J_COMPUTER='" & mComputerName & "' ," & _
                     "PROTOCAL_TYPE= '" & TypeID(0) & "'" & _
                     " where W.WEIGHT_BRIDGE_ID=" & Val(txtWBId.Text)

        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmUtlWeighBridge_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
        'AE_WBid = Val(txtWBId)
        ' Call AddJournal(JournalType.Jevent, Me.FormScreenID, 100, mUserName, 809201, Val(txtWBId), Trim(txtWBName.Text), Trim(cbCardReader.Text))
    End Sub

    Private Sub AssignValue()
    
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        txtWBId.Enabled = False
        txtWBId.BackColor = Color.LightGray
        strSQL = _
      " select W.WEIGHT_BRIDGE_ID,W.WEIGHT_BRIDGE_NAME,W.WEIGHT_BRIDGE_ADDRESS," & _
                " W.COMP_ID,W.COMP_ID||' '||W.COMPORT_NO as COMPORT_NO,W.LOCALITY_POSITION,W.CARD_READER_ID," & _
                "   w.comp_id1 ||' '||w.comport_no1  as COMPORT_NO2, W.IS_ENABLED,W.UPDATE_DATE,W.UPDATED_BY,W.DESCRIPTION,W.PROTOCAL_TYPE," & _
                " C.CARD_READER_ID ||' '|| C.CARD_READER_NAME as CARD_READER" & _
                " from WEIGHT_BRIDGE W, CARD_READER C" & _
                " where W.WEIGHT_BRIDGE_ID = " & pk_id & " " & _
                " and W.CARD_READER_ID=C.CARD_READER_ID"

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            txtWBId.Text = dt.Rows(i).Item("WEIGHT_BRIDGE_ID")
            txtWBName.Text = IIf(IsDBNull(dt.Rows(i).Item("WEIGHT_BRIDGE_NAME")), "", dt.Rows(i).Item("WEIGHT_BRIDGE_NAME"))
            txtWBAddress.Text = IIf(IsDBNull(dt.Rows(i).Item("WEIGHT_BRIDGE_ADDRESS")), "", dt.Rows(i).Item("WEIGHT_BRIDGE_ADDRESS"))
            cbCommPort.Text = dt.Rows(i).Item("COMPORT_NO")
            cbCommPort2.Text = dt.Rows(i).Item("COMPORT_NO2")
            cbCardReader.Text = dt.Rows(i).Item("CARD_READER")
            If dt.Rows(i).Item("PROTOCAL_TYPE") = 1 Then
                cbProtocal.SelectedIndex = 0
            Else
                cbProtocal.SelectedIndex = 1
            End If
            If dt.Rows(i).Item("IS_ENABLED") = 1 Then
                OptEnabled.Checked = True
                OptUnEnbled.Checked = False
            Else
                OptEnabled.Checked = False
                OptUnEnbled.Checked = True
            End If
            txthistory.Text = IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION"))
            txtLastUpdateDate.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", Format(dt.Rows(i).Item("UPDATE_DATE"), "วันที่ dd MMMM yyyy เวลา HH:mm:ss"))
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

    Function CheckDataExists(ByRef pID As String) As Boolean
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        sql_str = _
       "select W.WEIGHT_BRIDGE_ID " & _
        "from WEIGHT_BRIDGE W " & _
        "where W.WEIGHT_BRIDGE_ID=" & pID
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Do While dt.Rows.Count > i
                Return True
            Loop
            Return False
        End If
        mDataSet = Nothing
        Return False
    End Function


    Function assignDropDown() As Boolean
        Dim sql_str As String
        cbCommPort.Items.Clear()
        cbCommPort2.Items.Clear()
        sql_str = _
                "select C.CARD_READER_ID ||' '|| C.CARD_READER_NAME as CARD_READER,C.CARD_READER_NAME" & _
                " from CARD_READER C" & _
                " where C.CARD_READER_TYPE= 3" & _
                " order by C.CARD_READER_NAME"
        assignDropDown(sql_str, "CARD_READER", cbCardReader)
        sql_str = _
               "select COMP_ID,COMP_ID||' '||COMPORT_NO as COMPORT_NO" & _
               " from WEIGHT_BRIDGE " & _
               " order by COMP_ID  "
        assignDropDown(sql_str, "COMPORT_NO", cbCommPort)
        assignDropDown(sql_str, "COMPORT_NO", cbCommPort2)
        sql_str = _
              " select  TYPE_ID ||' - '|| TYPE_NAME as PROTOCAL" & _
              " from v_wb_protocal_type"
        assignDropDown(sql_str, "PROTOCAL", cbProtocal)
        sql_str = _
              "select C.COMP_ID||' '||C.COMPORT_NO as COMPORT " & _
              "from TAS.COMPORT C " & _
              "order by C.COMP_ID"
        assignDropDown(sql_str, "COMPORT", cbCommPort)
        assignDropDown(sql_str, "COMPORT", cbCommPort2)
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

    Private Sub setListboxWithName(ByVal name As String, ByVal cb As System.Object)
        Dim index As Integer = cb.FindString(name)
        If index = -1 Then
        Else
            cb.SelectedIndex = index
        End If
    End Sub

    Private Sub cbComport1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbComport2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



 

End Class
