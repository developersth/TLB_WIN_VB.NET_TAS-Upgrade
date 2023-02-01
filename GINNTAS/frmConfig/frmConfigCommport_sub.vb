Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmConfigCommport_sub
    Dim frm_work As Integer = 0 'Commport1=add ,2=Edit
    Dim pk_id As String = ""
    Dim RadioEnabled As String
    Dim RadioLocked As String
    Dim vFixType As String

    Private Sub frmConfigCommport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        intiailTxtPortSetting()
        If frm_work = 1 Then
            Me.Text = "Commport # Add"
            GetNextID()
        ElseIf frm_work = 2 Then
            Me.Text = "Commport # Edit"
            AssignValue()
        End If
        txtLock(True)
    End Sub

    Private Sub Clear_frm()
        cboCommType.Text = ""
        txtPortSetting.Text = ""
        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""
        OptEnabled.Checked = True

    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        txtCompID.Enabled = Not iBoo
        txtPortSetting.Enabled = Not iBoo
        txtLastUpdateDate.Enabled = Not iBoo
        txtLastUpdateBy.Enabled = Not iBoo

        If iBoo Then
            txtCompID.BackColor = Color.LightGray
            txtPortSetting.BackColor = Color.LightGray
            txtLastUpdateDate.BackColor = Color.LightGray
            txtLastUpdateBy.BackColor = Color.LightGray

        Else
            txtCompID.BackColor = Color.White
            txtPortSetting.BackColor = Color.White
            txtLastUpdateDate.BackColor = Color.White
            txtLastUpdateBy.BackColor = Color.White
        End If
    End Sub

#Region "Menu Event"
    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave
        If frm_work = 1 Then 'Add
            If txtCommNo.Text.Trim = "" Or cboProtocal.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If txtCommNo.Text.Trim = "" Or cboProtocal.Text.Trim = "" Then
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
        sql_str = " INSERT INTO COMPORT  ( "
        sql_str = sql_str & "  COMP_ID "
        sql_str = sql_str & " ,COMPORT_NO  "
        sql_str = sql_str & " ,COMPORT_TYPE  "
        sql_str = sql_str & " ,COMPORT_SETTING  "
        sql_str = sql_str & " ,Comport_Protocal  "
        sql_str = sql_str & " ,DESCRIPTION  "
        sql_str = sql_str & " ,UPDATED_BY  "
        sql_str = sql_str & " ,IS_ENABLED  "
        sql_str = sql_str & " )  "
        sql_str = sql_str & " VALUES ( "
        sql_str = sql_str & "'" + Trim(txtCompID.Text) + "'"
        sql_str = sql_str & ",'COM" + Trim(txtCommNo.Text) + "'"
        sql_str = sql_str & ",'" + Trim(cboCommType.Text) + "'"
        sql_str = sql_str & ",'" + Trim(txtPortSetting.Text) + "'"
        sql_str = sql_str & ",'" + Trim(cboProtocal.Text) + "'"
        sql_str = sql_str & ",'" + Trim(txtDescription.Text) + "'"
        sql_str = sql_str & ",'" + mUserName + "'"
        sql_str = sql_str & "," + If(OptUnEnbled.Checked = True, "0", "1") + ""
        sql_str = sql_str & " )  "
        If Oradb.ExeSQL(sql_str) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigCommport_main.Show_Data()
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
        Dim sql_str As String
        sql_str = "UPDATE  TAS.COMPORT  SET  "
        sql_str = sql_str & "COMPORT_NO = 'COM" & Trim(txtCommNo.Text) & "' ,"
        sql_str = sql_str & "COMPORT_TYPE='" & Trim(cboCommType.Text) & "',"
        sql_str = sql_str & "COMPORT_SETTING='" & Trim(txtPortSetting.Text) & "',"
        sql_str = sql_str & "Comport_Protocal ='" & Trim(cboProtocal.Text) & "',"
        sql_str = sql_str & "DESCRIPTION='" & Trim(txtDescription.Text) & "',"
        sql_str = sql_str & "UPDATE_DATE = SYSDATE,"
        sql_str = sql_str & "UPDATED_BY='" & mUserName & "',"
        sql_str = sql_str & "IS_ENABLED=" & If(OptUnEnbled.Checked = True, "0", "1") & " "
        sql_str = sql_str & "WHERE COMP_ID = '" & Trim(txtCompID.Text) & "' "
    
        If Oradb.ExeSQL(sql_str) Then
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmConfigCommport_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If

    End Sub

    Private Sub AssignValue()

        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        sql_str = ""
        sql_str = sql_str & " SELECT COMP_ID, COMPORT_NO, COMPORT_TYPE, COMPORT_SETTING, "
        sql_str = sql_str & " Comport_Protocal, DESCRIPTION, IS_ENABLED, UPDATE_DATE, UPDATED_BY  "
        sql_str = sql_str & " FROM  COMPORT  WHERE COMP_ID = '" + pk_id + "'"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            txtCompID.Text = IIf(IsDBNull(dt.Rows(i).Item("COMP_ID")), "", dt.Rows(i).Item("COMP_ID").ToString)
            Dim commNo As String = IIf(IsDBNull(dt.Rows(i).Item("COMPORT_NO")), "", dt.Rows(i).Item("COMPORT_NO").ToString)
            txtCommNo.Text = commNo.Substring(3)
            txtDescription.Text = IIf(IsDBNull(dt.Rows(i).Item("DESCRIPTION")), "", dt.Rows(i).Item("DESCRIPTION").ToString)

            Dim strPortSetting = IIf(IsDBNull(dt.Rows(i).Item("COMPORT_SETTING")), "", dt.Rows(i).Item("COMPORT_SETTING").ToString)
            txtPortSetting.Text = strPortSetting
            Dim arrPortSetting = Split(strPortSetting, ",")
            setListboxWithName(arrPortSetting(0), cboPortSpeed)
            setListboxWithName(arrPortSetting(2), cboDataBit)
            setListboxWithName(arrPortSetting(1), cboParity)
            setListboxWithName(arrPortSetting(3), cboStopBit)

            Dim strProtocal As String = IIf(IsDBNull(dt.Rows(i).Item("Comport_Protocal")), "", dt.Rows(i).Item("Comport_Protocal").ToString)
            setListboxWithName(strProtocal, cboProtocal)

            Dim strComportType As String = IIf(IsDBNull(dt.Rows(i).Item("COMPORT_TYPE")), "", dt.Rows(i).Item("COMPORT_TYPE").ToString)
            setListboxWithName(strComportType, cboCommType)

            If IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", dt.Rows(i).Item("IS_ENABLED").ToString) = 0 Then
                OptUnEnbled.Checked = True
            ElseIf IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", dt.Rows(i).Item("IS_ENABLED").ToString) = 1 Then
                OptEnabled.Checked = True
            Else
                OptUnEnbled.Checked = True
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
        sql_str = " SELECT CARDREADER_NO FROM CARDREADER  "
        sql_str = sql_str & " WHERE CARDREADER_NO = '" + pID + "' "
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
        sql_str = " SELECT TYPE_ID, TYPE_NAME "
        sql_str = sql_str & " FROM V_COMMPORT_TYPE "
        sql_str = sql_str & " ORDER BY TYPE_ID "
        assignDropDown(sql_str, "type_name", cboCommType)

        sql_str = " SELECT TYPE_NAME FROM  V_COMMPORT_PROTOCAL "
        sql_str = sql_str & " ORDER BY TYPE_ID "
        assignDropDown(sql_str, "type_name", cboProtocal)

        InitialCombo()
        setListboxWithName("9600", cboPortSpeed)
        setListboxWithName("8", cboDataBit)
        setListboxWithName("None", cboParity)
        setListboxWithName("1", cboStopBit)
        setListboxWithName("RS-232", cboCommType)
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
        dt = Nothing
        Return True
    End Function

    Private Sub setListboxWithName(ByVal name As String, ByVal cb As System.Object)
        Dim index As Integer = cb.FindString(name)
        If index = -1 Then
        Else
            cb.SelectedIndex = index
        End If
    End Sub

    Private Sub InitialCombo()
        cboPortSpeed.Items.Add(110)
        cboPortSpeed.Items.Add(300)
        cboPortSpeed.Items.Add(1200)
        cboPortSpeed.Items.Add(2400)
        cboPortSpeed.Items.Add(4800)
        cboPortSpeed.Items.Add(9600)
        cboPortSpeed.Items.Add(19200)
        cboPortSpeed.Items.Add(38400)
        cboPortSpeed.Items.Add(57600)
        cboPortSpeed.Items.Add(115200)
        cboPortSpeed.Items.Add(230400)
        cboPortSpeed.Items.Add(460800)
        cboPortSpeed.Items.Add(921600)

        cboParity.Items.Add("Even")
        cboParity.Items.Add("Odd")
        cboParity.Items.Add("None")

        cboDataBit.Items.Add(5)
        cboDataBit.Items.Add(6)
        cboDataBit.Items.Add(7)
        cboDataBit.Items.Add(8)

        cboStopBit.Items.Add(1)
        cboStopBit.Items.Add(1.5)
        cboStopBit.Items.Add(2)
    End Sub

    Private Sub intiailTxtPortSetting()
        Dim strcboPrity As String
        strcboPrity = cboParity.Text
        Dim firstIndexofCboParity As Char = strcboPrity.Substring(0)
        txtPortSetting.Text = cboPortSpeed.Text & "," + firstIndexofCboParity.ToString & "," + cboDataBit.Text & "," + cboStopBit.Text
    End Sub

    Private Function GetNextID() As Long
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        sql_str = " SELECT MAX((COMP_Id)+1) as MaxID FROM COMPORT"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            txtCompID.Text = IIf(IsDBNull(dt.Rows(0).Item("MaxID")), "", dt.Rows(0).Item("MaxID").ToString)
        End If
        Return 0.1
    End Function

    Private Sub cboPortSpeedChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPortSpeed.SelectedIndexChanged
        intiailTxtPortSetting()
    End Sub
    Private Sub cboParityChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboParity.SelectedIndexChanged
        intiailTxtPortSetting()
    End Sub
    Private Sub cboDataBitChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDataBit.SelectedIndexChanged
        intiailTxtPortSetting()
    End Sub
    Private Sub cboStopBitChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStopBit.SelectedIndexChanged
        intiailTxtPortSetting()
    End Sub

    Private Sub txtCommNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCommNo.KeyPress
        If txtCommNo.Text.Length > 1 Then
            e.Handled = True
            Return
        End If
        e.Handled = CurrencyOnly(txtCommNo, e.KeyChar)
        
    End Sub
End Class
