Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmConfigCardReader_sub
    Dim frm_work As Integer = 0 'CardReader1=add ,2=Edit
    Dim pk_id As String = ""
    Dim RadioEnabled As String
    Dim RadioLocked As String
    Dim vFixType As String


    Private Sub frmConfigCardReader_sub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        If frm_work = 1 Then
            Me.Text = "CardReader # Add"
            GetNextCRID()
        ElseIf frm_work = 2 Then
            Me.Text = "CardReader # Edit"
            AssignValue()
        End If
        txtLock(True)
    End Sub

    Private Sub Clear_frm()
        txtCRID.Text = ""
        txtNameCR.Text = ""
        txtAddr.Text = ""
        cbType.Text = ""
        cbChkIB.Text = ""
        cbComport1.Items.Clear()
        cbComport2.Items.Clear()
        cbIsland.Text = ""
        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""
        OptEnabled.Checked = True
        OptUnLocked.Checked = True

    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        If iBoo Then
            txtCRID.BackColor = Color.LightGray
            txtLastUpdateDate.BackColor = Color.LightGray
            txtLastUpdateBy.BackColor = Color.LightGray
        Else
            txtCRID.BackColor = Color.White
            txtLastUpdateDate.BackColor = Color.White
            txtLastUpdateBy.BackColor = Color.White
        End If
    End Sub

#Region "Menu Event"
    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave
        If frm_work = 1 Then 'Add
            If txtCRID.Text.Trim = "" Or txtNameCR.Text.Trim = "" Or txtAddr.Text.Trim = "" Or cbType.Text.Trim = "" Or cbComport1.Text.Trim = "" Or cbComport2.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If txtCRID.Text.Trim = "" Or txtNameCR.Text.Trim = "" Or txtAddr.Text.Trim = "" Or cbType.Text.Trim = "" Or cbComport1.Text.Trim = "" Or cbComport2.Text.Trim = "" Then
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
        AssignCheckBox()
        Dim sql_str As String
        sql_str = " INSERT INTO CARD_READER  ( "
        sql_str = sql_str & "  CARD_READER_ID  "
        sql_str = sql_str & " ,CARD_READER_NAME  "
        sql_str = sql_str & " ,CARD_READER_TYPE  "
        sql_str = sql_str & " ,CARD_READER_ADDRESS  "
        sql_str = sql_str & " ,COMP_ID  "
        sql_str = sql_str & " ,COMPORT_NO  "
        sql_str = sql_str & " ,COMP_ID1  "
        sql_str = sql_str & " ,COMPORT_NO1  "
        sql_str = sql_str & " ,FIX_TYPE  "
        sql_str = sql_str & " ,ISLAND_NO  "
        sql_str = sql_str & " ,IS_ENABLED  "
        sql_str = sql_str & " ,IS_LOCKED  "
        sql_str = sql_str & " ,UPDATED_BY  "
        sql_str = sql_str & " )  "
        sql_str = sql_str & " VALUES ( "
        sql_str = sql_str & "'" + Trim(txtCRID.Text) + "'"
        sql_str = sql_str & ",'" + Trim(txtNameCR.Text) + "'"
        Dim strCbType = Split(cbType.Text, "-")
        sql_str = sql_str & ",'" + strCbType(0) + "'"
        sql_str = sql_str & ",'" + Trim(txtAddr.Text) + "'"
        Dim comport1 = Split(cbComport1.Text, " ")
        sql_str = sql_str & ",'" + comport1(0) + "'"
        sql_str = sql_str & ",'" + comport1(1) + "'"
        Dim comport2 = Split(cbComport2.Text, " ")
        sql_str = sql_str & ",'" + comport2(0) + "'"
        sql_str = sql_str & ",'" + comport2(1) + "'"
        sql_str = sql_str & ",'" + vFixType + "'"
        sql_str = sql_str & ",'" + cbIsland.Text + "'"
        sql_str = sql_str & "," + RadioEnabled.ToString + ""
        sql_str = sql_str & "," + RadioLocked.ToString + ""
        sql_str = sql_str & ",'" + mUserName + "'"
        sql_str = sql_str & " )  "
        If Oradb.ExeSQL(sql_str) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigCardReader_main.Show_Data()
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
        AssignCheckBox()
        Dim sql_str As String
        sql_str = " UPDATE CARD_READER  SET  "
        sql_str = sql_str & " CARD_READER_NAME  = '" + Trim(txtNameCR.Text) + "'"
        Dim strCbType = Split(cbType.Text, "-")
        sql_str = sql_str & " ,CARD_READER_TYPE = '" + strCbType(0) + "'"
        sql_str = sql_str & " ,CARD_READER_ADDRESS  = '" + Trim(txtAddr.Text) + "'"
        Dim comport1 = Split(cbComport1.Text, " ")
        sql_str = sql_str & " ,COMP_ID = '" + comport1(0) + "'"
        sql_str = sql_str & " ,COMPORT_NO  = '" + comport1(1) + "'"
        Dim comport2 = Split(cbComport2.Text, " ")
        sql_str = sql_str & " ,COMP_ID1  = '" + comport2(0) + "'"
        sql_str = sql_str & " ,COMPORT_NO1  = '" + comport2(1) + "'"
        sql_str = sql_str & " ,FIX_TYPE  = '" + vFixType + "'"
        sql_str = sql_str & " ,ISLAND_NO  = '" + cbIsland.Text + "'"
        sql_str = sql_str & " ,IS_ENABLED = '" + RadioEnabled.ToString + "'"
        sql_str = sql_str & " ,IS_LOCKED  = '" + RadioLocked.ToString + "'"
        sql_str = sql_str & " ,UPDATED_BY = '" + mUserName + "'"
        sql_str = sql_str & " WHERE  CARD_READER_ID = '" + pk_id + "'"

        If Oradb.ExeSQL(sql_str) Then
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigCardReader_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If

    End Sub

    Private Sub AssignValue()

        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim fixType As String
        sql_str = "SELECT "
        sql_str = sql_str & "C.CARD_READER_ID,C.CARD_READER_NAME,C.CARD_READER_TYPE,"
        sql_str = sql_str & "C.COMP_ID1 ||' '|| C.COMPORT_NO1 AS COMPORT2,"
        sql_str = sql_str & "C.COMP_ID||' '||C.COMPORT_NO as COMPORT,"
        sql_str = sql_str & "C.CARD_READER_ADDRESS,C.LOCALITY_POSITION,C.LOCALITY_DESC,C.CARD_READER_TYPE||'-'||V.TYPE_NAME AS STATUS,"
        sql_str = sql_str & "C.COMP_ID,C.COMPORT_NO,C.FIX_TYPE,C.ISLAND_NO,C.BAY_NO,C.BAY_NAME,"
        sql_str = sql_str & " CASE WHEN LENGTH(COMP_ID1) <> 0  THEN C.COMP_ID ||'-'|| C.COMPORT_NO ||'/'||C.COMP_ID1||'-'||C.COMPORT_NO1 "
        sql_str = sql_str & " ELSE C.COMP_ID ||'-'|| C.COMPORT_NO  END AS COMPORT_NO, "
        sql_str = sql_str & "C.IS_ENABLED,C.IS_PROCESS,C.IS_LOCKED,C.IS_FINGER,C.FINGER_SERIAL,"
        sql_str = sql_str & "C.FINGER_KEY,C.FINGER_DESC,C.IS_PRINTER,C.PRINTER_ID,C.PRINTER_NAME,"
        sql_str = sql_str & "C.CONNECT_STATUS,C.DESCRIPTION,C.CREATION_DATE,C.CREATED_BY,"
        sql_str = sql_str & "C.UPDATE_DATE , C.UPDATED_BY, C.J_COMPUTER "
        sql_str = sql_str & "FROM TAS.CARD_READER C,TAS.V_CARD_READER_TYPE V "
        sql_str = sql_str & "WHERE C.CARD_READER_TYPE=V.TYPE_ID AND C.CARD_READER_ID = '" + pk_id + "' "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            txtCRID.Text = IIf(IsDBNull(dt.Rows(i).Item("CARD_READER_ID")), "", dt.Rows(i).Item("CARD_READER_ID").ToString)
            txtNameCR.Text = IIf(IsDBNull(dt.Rows(i).Item("CARD_READER_NAME")), "", dt.Rows(i).Item("CARD_READER_NAME").ToString)
            cbType.Text = IIf(IsDBNull(dt.Rows(i).Item("STATUS")), "", dt.Rows(i).Item("STATUS").ToString)
            txtAddr.Text = IIf(IsDBNull(dt.Rows(i).Item("CARD_READER_ADDRESS")), "", dt.Rows(i).Item("CARD_READER_ADDRESS").ToString)
            Dim strComport1 As String = IIf(IsDBNull(dt.Rows(i).Item("comport")), "", dt.Rows(i).Item("comport").ToString)
            setListboxWithName(strComport1, cbComport1)
            Dim strComport2 As String = IIf(IsDBNull(dt.Rows(i).Item("comport2")), "", dt.Rows(i).Item("comport2").ToString)
            setListboxWithName(strComport2, cbComport2)
            If IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", dt.Rows(i).Item("IS_ENABLED").ToString) = 0 Then
                OptUnEnbled.Checked = True
            ElseIf IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", dt.Rows(i).Item("IS_ENABLED").ToString) = 1 Then
                OptEnabled.Checked = True
            Else
                OptUnEnbled.Checked = True
            End If
            fixType = IIf(IsDBNull(dt.Rows(i).Item("FIX_TYPE")), "", dt.Rows(i).Item("FIX_TYPE"))
            If fixType = "0" Then
                cbChkIB.Text = "Bay"
            ElseIf fixType = "1" Then
                cbChkIB.Text = "Island"
            Else
                cbChkIB.Text = ""
            End If
            cbIsland.Text = IIf(IsDBNull(dt.Rows(i).Item("ISLAND_NO")), "", dt.Rows(i).Item("ISLAND_NO"))
            If IIf(IsDBNull(dt.Rows(i).Item("IS_LOCKED")), "", dt.Rows(i).Item("IS_LOCKED").ToString) = 0 Then
                OptLocked.Checked = True
            ElseIf IIf(IsDBNull(dt.Rows(i).Item("IS_LOCKED")), "", dt.Rows(i).Item("IS_LOCKED").ToString) = 1 Then
                OptUnLocked.Checked = True
            Else
                OptUnLocked.Checked = True
            End If
            txtLastUpdateDate.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
            txtLastUpdateBy.Text = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)
        Else
        End If
        mDataSet = Nothing
        dt = Nothing
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
        sql_str = "SELECT C.CARDREADER_NO FROM CARDREADER C"
        sql_str = sql_str & " WHERE  C.CARDREADER_NO = '" + pID + "' "
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


    Function assignDropDown() As Boolean
        Dim sql_str As String

        sql_str = "SELECT T.TYPE_ID||'-'||T.TYPE_NAME as status "
        sql_str = sql_str & "FROM V_CARD_READER_TYPE T "
        sql_str = sql_str & "ORDER BY T.TYPE_ID"
        assignDropDown(sql_str, "status", cbType)


        sql_str = "SELECT C.COMP_ID||' '||C.COMPORT_NO AS COMPORT "
        sql_str = sql_str & "FROM TAS.COMPORT C "
        sql_str = sql_str & "ORDER BY C.COMP_ID"
        assignDropDown(sql_str, "COMPORT", cbComport1)
        assignDropDown(sql_str, "COMPORT", cbComport2)

        cbChkIB.Items.Add("BAY")
        cbChkIB.Items.Add("ISLAND")

        sql_str = "SELECT I.ISLAND_NO "
        sql_str = sql_str & "FROM TAS.ISLAND I "
        sql_str = sql_str & "ORDER BY I.ISLAND_NO"
        assignDropDown(sql_str, "ISLAND_NO", cbIsland)

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
            'Return True
        End If
        mDataSet = Nothing
        Return True
    End Function

    Private Sub txtQuota_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    End Sub

    Private Sub AssignCheckBox()
        If OptEnabled.Checked = True Then
            RadioEnabled = 1
        Else
            RadioEnabled = 0
        End If
        ''--------------------------
        If OptLocked.Checked = True Then
            RadioLocked = 1
        Else
            RadioLocked = 0
        End If
        ''---------------------------
        If cbChkIB.Text = "Bay" Then
            vFixType = "0"
        ElseIf cbChkIB.Text = "Island" Then
            vFixType = "1"
        Else
            vFixType = "0"
        End If
    End Sub

    Private Sub setListboxWithName(ByVal name As String, ByVal cb As System.Object)
        Dim index As Integer = cb.FindString(name)
        If index = -1 Then
        Else
            cb.SelectedIndex = index
        End If
    End Sub

    Private Sub cbComport1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbComport1.SelectedIndexChanged
        Dim Str = Split(cbComport1.Text, " ")
        Dim str1 = Split(cbComport2.Text, " ")
        Dim sql_str As String
        If Str(0) = str1(0) Then
            MsgBox("Comport ที่ท่านเลือกถูกใช้แล้ว ", vbInformation)
            cbComport1.Items.Clear()
            sql_str = "SELECT C.COMP_ID||' '||C.COMPORT_NO as COMPORT "
            sql_str = sql_str & "FROM TAS.COMPORT C "
            sql_str = sql_str & "ORDER by C.COMP_ID"
            assignDropDown(sql_str, "COMPORT", cbComport1)

        End If
    End Sub

    Private Sub cbComport2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbComport2.SelectedIndexChanged
        Dim Str = Split(cbComport1.Text, " ")
        Dim str1 = Split(cbComport2.Text, " ")
        Dim sql_str As String
        If Str(0) = str1(0) Then
            MsgBox("Comport ที่ท่านเลือกถูกใช้แล้ว ", vbInformation)
            cbComport2.Items.Clear()
            sql_str = " SELECT C.COMP_ID||' '||C.COMPORT_NO as COMPORT "
            sql_str = sql_str & " FROM TAS.COMPORT C "
            sql_str = sql_str & " ORDER BY C.COMP_ID"
            assignDropDown(sql_str, "COMPORT", cbComport2)

        End If
    End Sub

    Private Function GetNextCRID() As Long
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        sql_str = " SELECT MAX((CARD_READER_ID)+1) as MaxCRID FROM TAS.CARD_READER"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            txtCRID.Text = IIf(IsDBNull(dt.Rows(0).Item("MaxCRID")), "", dt.Rows(0).Item("MaxCRID").ToString)
        End If
        mDataSet = Nothing
        dt = Nothing

        Return 0.1
    End Function

    Private Sub txtAddr_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAddr.KeyPress
        e.Handled = CurrencyOnly(txtAddr, e.KeyChar)
    End Sub

    Private Sub OptLocked_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles OptLocked.CheckedChanged

    End Sub
End Class
