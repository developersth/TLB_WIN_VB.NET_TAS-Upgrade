Imports Oracle.DataAccess.Client
Imports System.Data
Imports System.IO
Public Class frmMainDriver_sub
    Dim frm_work As Integer = 0 'frmMainDriver1=add ,2=Edit
    Dim pk_id As String = ""

    Private Sub frmMainDriver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clear_frm()
        assignDropDown()
        If frm_work = 1 Then
            dtpStopDate.Value = DateAdd("M", 1, DateTime.Today)
            Me.Text = "Driver # Add"
            GetNextID()
        ElseIf frm_work = 2 Then
            Me.Text = "Driver # Edit"
            AssignValue()
        End If
        txtLock(True)
        ShowBlackList(pk_id)
    End Sub

    Private Sub Clear_frm()
        txtDriverID.Text = ""
        txtDriverCode.Text = ""
        cbCarrier.Items.Clear()
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtDriverAddr.Text = ""
        txtPersonal.Text = ""
        txtLicense.Text = ""
        txtLastUpdateDate.Text = ""
        txtLastUpdateBy.Text = ""
        OptEnabled.Checked = True
        OptIsUnEnBlackList.Checked = True
        txtDesc.Text = ""
    End Sub

    Private Sub txtLock(ByRef iBoo As Boolean)
        If frm_work = 2 Then
            txtDriverID.Enabled = Not iBoo
            txtLastUpdateDate.Enabled = Not iBoo
            txtLastUpdateBy.Enabled = Not iBoo

            If iBoo Then
                txtDriverID.BackColor = Color.LightGray
                txtLastUpdateDate.BackColor = Color.LightGray
                txtLastUpdateBy.BackColor = Color.LightGray

            Else
                txtDriverID.BackColor = Color.White
                txtLastUpdateDate.BackColor = Color.White
                txtLastUpdateBy.BackColor = Color.White
            End If
        End If
    End Sub

#Region "Menu Event"
    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave

        If frm_work = 1 Then 'Add
            If CheckDataExist(txtDriverID.Text) Then
                GetNextID()
                Exit Sub
            End If
            If txtDriverID.Text.Trim = "" Or txtDriverCode.Text.Trim = "" Or cbCarrier.Text.Trim = "" Or txtFirstName.Text.Trim = "" Or txtLastName.Text.Trim = "" Or txtDriverAddr.Text.Trim = "" Or txtPersonal.Text.Trim = "" Or txtLicense.Text.Trim = "" Or dtpExpireDate.Text.Trim = "" Or OptEnabled.Text.Trim = "" Then
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " ท่านใส่ข้อมูลไม่ครบ กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
                Exit Sub
            End If

            Dim result As Integer = MessageBox.Show("ท่านต้องการบันทึกข้อมูลหรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save()
            End If
        ElseIf frm_work = 2 Then 'Edit
            If txtDriverID.Text.Trim = "" Or txtDriverCode.Text.Trim = "" Or cbCarrier.Text.Trim = "" Or txtFirstName.Text.Trim = "" Or txtLastName.Text.Trim = "" Or txtDriverAddr.Text.Trim = "" Or txtPersonal.Text.Trim = "" Or txtLicense.Text.Trim = "" Or dtpExpireDate.Text.Trim = "" Or OptEnabled.Text.Trim = "" Then
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
            "select count(C.DRIVER_ID) as vCount " & _
               "from DRIVER C " & _
               "where C.DRIVER_ID = " & ip
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            If dt.Rows.Count > 0 Then
                If dt.Rows(i).Item("vCount") > 0 Then
                    MsgBox("มีรหัสพนักงานขับรถอยู่ในฐานข้อมูลแล้ว", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
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
        'UploadPicture()
        Dim strSQL As String
        Dim s = Split(cbCarrier.Text, " - ")
        strSQL = _
        "insert into DRIVER(" & _
        "DRIVER_ID,FIRST_NAME," & _
        "LAST_NAME," & _
        "DRIVER_CODE," & _
        "ADDRESS," & _
        "PERSONAL_ID,LICENSE,EXPIRE_DATE," & _
        "IS_ENABLED,CREATION_DATE," & _
        "CREATED_BY,UPDATE_DATE," & _
        "UPDATED_BY,CARRIER_ID) " & _
        "values(" & _
        Val(txtDriverID.Text) & ",'" & Trim(txtFirstName.Text) & "'," & _
        "'" & Trim(txtLastName.Text) & "','" & Trim(txtDriverCode.Text) & "','" & Trim(txtDriverAddr.Text) & "'," & _
        "'" & Trim(txtPersonal.Text) & "','" & Trim(txtLicense.Text) & "',to_date('" & Format(dtpExpireDate.Value, "dd/MM/yyyy") & "','dd/mm/yyyy')," & _
        IIf(OptEnabled.Checked, 1, 0) & ",sysdate," & _
        "'" & mUserName & "',sysdate," & _
        "'" & mUserName & "','" & s(0) & "')"

        If Oradb.ExeSQL(strSQL) Then
            UploadPicture()
            AddDataBlackList()
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmMainDriver_main.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If

    End Sub
    Private Sub UploadPicture()
        Dim vDriverPicByte As Byte()
        Dim ms As New IO.MemoryStream
        If (Not picDriver.Image Is Nothing) Then
            vDriverPicByte = ReadAllBytes(txtPathPicDriver.Text)
            If frm_work = 1 Then 'Add
                Oradb.UploadImagePicture(1, txtDriverID.Text, 1, vDriverPicByte, mComputerName, mUserName)
            Else
                Oradb.UploadImagePicture(2, txtDriverID.Text, 1, vDriverPicByte, mComputerName, mUserName)
            End If

        End If
    End Sub

    Public Function ReadAllBytes(fileName As String) As Byte()
        Dim ImageData As Byte()
        'Dim fs As FileStream(fileName, FileMode.Open, FileAccess.Read))
        Dim Fs As FileStream = New FileStream(fileName,
                                           FileMode.Open, FileAccess.Read)
        ReDim ImageData(Fs.Length)
        Fs.Read(ImageData, 0, System.Convert.ToInt32(Fs.Length))
        Fs.Close()
        Return ImageData
    End Function
    Public Sub setFrmWork(ByVal n As Integer)
        Me.frm_work = n
    End Sub

    Public Sub setPkId(ByVal id As String)
        Me.pk_id = id
    End Sub

    Private Sub Edit()
        Dim strSQL As String
        Dim s = Split(cbCarrier.Text, " - ")
        strSQL = _
        "update DRIVER D set " & _
        "D.FIRST_NAME='" & Trim(txtFirstName.Text) & "'," & _
        "D.LAST_NAME='" & Trim(txtLastName.Text) & "'," & _
        "D.Driver_Code='" & Trim(txtDriverCode.Text) & "'," & _
        "D.ADDRESS='" & Trim(txtDriverAddr.Text) & "'," & _
        "D.PERSONAL_ID='" & Trim(txtPersonal.Text) & "'," & _
        "D.LICENSE='" & Trim(txtLicense.Text) & "'," & _
        "D.EXPIRE_DATE=to_date('" & Format(dtpExpireDate.Value, "dd/MM/yyyy") & "','dd/mm/yyyy')," & _
        "D.IS_ENABLED=" & IIf(OptEnabled.Checked, 1, 0) & "," & _
        "D.UPDATE_DATE=sysdate," & _
        "D.UPDATED_BY='" & mUserName & "'," & _
        "D.Carrier_id='" & s(0) & "' " & _
        "where D.DRIVER_ID=" & Val(txtDriverID.Text.Trim)

        If Oradb.ExeSQL(strSQL) Then
            UploadPicture()
            AddDataBlackList()
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmMainDriver_main.Show_Data()
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
        "select D.DRIVER_ID,Driver_code,D.Carrier_id,D.FIRST_NAME,D.LAST_NAME,D.ADDRESS," & _
        "D.PERSONAL_ID, D.LICENSE , D.EXPIRE_DATE, D.IS_ENABLED, D.UPDATE_DATE, D.UPDATED_BY," & _
        "C.Carrier_Name,P.PICTURE_DATA " & _
        "from DRIVER D,PICTURE_TAS P,Carrier C " & _
        "where D.DRIVER_ID=P.PICTURE_ID(+) " & _
        " and D.carrier_id=C.carrier_id(+) " & _
        "and (P.PICTURE_TYPE=1 or P.PICTURE_ID is null) " & _
        "and D.DRIVER_ID=" & pk_id

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0

            'picDriver.Image = IIf(IsDBNull(dt.Rows(i).Item("PICTURE_DATA")), "", dt.Rows(i).Item("PICTURE_DATA"))
            If (Not IsDBNull(dt.Rows(0)("PICTURE_DATA"))) Then
                Dim bytes = CType(dt.Rows(0)("PICTURE_DATA"), Byte())
                picDriver.Image = Image.FromStream(New MemoryStream(bytes))
            End If
            txtDriverID.Text = IIf(IsDBNull(dt.Rows(i).Item("DRIVER_ID")), "", dt.Rows(i).Item("DRIVER_ID").ToString)
                txtDriverCode.Text = IIf(IsDBNull(dt.Rows(i).Item("Driver_code")), "", dt.Rows(i).Item("Driver_code").ToString)
                txtFirstName.Text = IIf(IsDBNull(dt.Rows(i).Item("FIRST_NAME")), "", dt.Rows(i).Item("FIRST_NAME").ToString)
                txtLastName.Text = IIf(IsDBNull(dt.Rows(i).Item("LAST_NAME")), "", dt.Rows(i).Item("LAST_NAME").ToString)
                txtDriverAddr.Text = IIf(IsDBNull(dt.Rows(i).Item("ADDRESS")), "", dt.Rows(i).Item("ADDRESS").ToString)
                txtPersonal.Text = IIf(IsDBNull(dt.Rows(i).Item("PERSONAL_ID")), "", dt.Rows(i).Item("PERSONAL_ID").ToString)
                txtLicense.Text = IIf(IsDBNull(dt.Rows(i).Item("LICENSE")), "", dt.Rows(i).Item("LICENSE").ToString)
                dtpExpireDate.Value = IIf(IsDBNull(dt.Rows(i).Item("EXPIRE_DATE")), "", dt.Rows(i).Item("EXPIRE_DATE").ToString)

                If IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", dt.Rows(i).Item("IS_ENABLED").ToString) = 1 Then
                    OptEnabled.Checked = True
                Else
                    OptUnEnbled.Checked = True
                End If
                cbCarrier.Text = IIf(IsDBNull(dt.Rows(i).Item("carrier_id")), "", dt.Rows(i).Item("carrier_id").ToString)

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
        "select C.CARRIER_ID,C.CARRIER_NAME " & _
        "from CARRIER C " & _
        "order by C.CARRIER_NAME"
        assignDropDown(sql_str, "CARRIER_ID", "CARRIER_NAME", cbCarrier)

        Return 0
    End Function

    Function assignDropDown(ByVal sql_str As String, ByVal colName1 As String, ByVal colName2 As String, ByVal cb As System.Object) As Boolean
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Dim temCb As String
            Do While dt.Rows.Count > i
                temCb = IIf(IsDBNull(dt.Rows(i).Item(colName1)), "", dt.Rows(i).Item(colName1).ToString) & " - " & IIf(IsDBNull(dt.Rows(i).Item(colName2)), "", dt.Rows(i).Item(colName2).ToString)
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
        " select MAX((DRIVER_ID)+1) as MaxID from DRIVER"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            txtDriverID.Text = IIf(IsDBNull(dt.Rows(0).Item("MaxID")), "", dt.Rows(0).Item("MaxID").ToString)
        End If
        Return 1
    End Function

    Private Sub ShowBlackList(ByVal MeterNo As String)

        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        sql_str = _
        " select   t.blacklist_no , t.decription, t.begin_date, t.end_date, t.is_enabled " & _
        " ,t.creation_date,t.created_by  , t.update_date  , t.updated_by ,t.j_computer " & _
        " from  tas.driver_blacklist  t " & _
        " Where t.driver_id = '" & pk_id & "' " & _
        " order by t.blacklist_no "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView2.RowCount = 0
            Do While dt.Rows.Count > i
                DataGridView2.RowCount = DataGridView2.RowCount + 1
                DataGridView2.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("blacklist_no")), "", dt.Rows(i).Item("blacklist_no").ToString)
                DataGridView2.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("decription")), "", dt.Rows(i).Item("decription").ToString)
                DataGridView2.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("begin_date")), "", dt.Rows(i).Item("begin_date").ToString)
                DataGridView2.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("end_date")), "", dt.Rows(i).Item("end_date").ToString)

                If IIf(IsDBNull(dt.Rows(i).Item("is_enabled")), "", dt.Rows(i).Item("is_enabled").ToString) = 1 Then
                    DataGridView2.Item(4, i).Value = "ใช้งาน"
                Else
                    DataGridView2.Item(4, i).Value = "หยุดใข้งาน"
                End If

                DataGridView2.Item(5, i).Value = IIf(IsDBNull(dt.Rows(i).Item("creation_date")), "", dt.Rows(i).Item("creation_date").ToString)
                DataGridView2.Item(6, i).Value = IIf(IsDBNull(dt.Rows(i).Item("created_by")), "", dt.Rows(i).Item("created_by").ToString)
                DataGridView2.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("update_date")), "", dt.Rows(i).Item("update_date").ToString)
                DataGridView2.Item(8, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)

                i = i + 1
            Loop
            txtBackListNo.Text = i + 1
        Else
        End If
        mDataSet = Nothing

    End Sub


    Private Function AddDataBlackList()
        Dim strSQL As String

        strSQL = "delete driver_blacklist where driver_id ='" & Trim(pk_id) & "'"
        Oradb.ExeSQL(strSQL)
        Dim i As Integer = 0
        strSQL = ""
        Dim temEnable
        Do While DataGridView2.RowCount > i

            If DataGridView2.Item(4, i).Value = "ใช้งาน" Then
                temEnable = 1
            Else
                temEnable = 0
            End If
            strSQL = _
            "insert into driver_blacklist(" & _
            "blacklist_no," & _
            "decription," & _
            "begin_date," & _
            "end_date," & _
            "is_enabled," & _
            "creation_date, " & _
            "created_by," & _
            "update_date," & _
            "updated_by," & _
            "driver_id " & _
            " )values(" & _
            "'" & DataGridView2.Item(0, i).Value & "'," & _
            "'" & DataGridView2.Item(1, i).Value & "'," & _
            " TO_DATE('" & DataGridView2.Item(2, i).Value & "', 'dd/mm/yyyy hh24:mi:ss')  ," & _
            " TO_DATE('" & DataGridView2.Item(3, i).Value & "', 'dd/mm/yyyy hh24:mi:ss')  ," & _
            "'" & temEnable & "'," & _
            " sysdate " & "," & _
            "'" & DataGridView2.Item(6, i).Value & "'," & _
            " sysdate " & "," & _
             "''," & _
            "'" & Trim(pk_id) & "' )"
            If Oradb.ExeSQL(strSQL) Then
            Else
                MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
            End If
            i = i + 1
        Loop

        Return 0
    End Function

    Private Sub addDataGridBlackList()
        Dim strDateStart = DTPickerStart.Value.ToString.Split(" ")
        Dim dateStart = strDateStart(0)
        Dim strTimeStart = DtpTimeStart.Value.ToString.Split(" ")
        Dim timeStart = strTimeStart(1)
        Dim strDateEnd = dtpStopDate.Value.ToString.Split(" ")
        Dim dateEnd = strDateEnd(0)
        Dim strTimeEnd = dtpTimeStop.Value.ToString.Split(" ")
        Dim timeEnd = strTimeEnd(1)
        Dim i As Integer

        i = DataGridView2.RowCount
        DataGridView2.RowCount = DataGridView2.RowCount + 1
        DataGridView2.Item(0, i).Value = txtBackListNo.Text
        DataGridView2.Item(1, i).Value = txtDesc.Text
        DataGridView2.Item(2, i).Value = dateStart & " " & timeStart
        DataGridView2.Item(3, i).Value = dateEnd & " " & timeEnd
        If OptIsEnBlackList.Checked Then
            DataGridView2.Item(4, i).Value = "ใช้งาน"
        Else
            DataGridView2.Item(4, i).Value = "หยุดใข้งาน"
        End If
        DataGridView2.Item(5, i).Value = Date.Now
        DataGridView2.Item(6, i).Value = mUserName
        DataGridView2.Item(7, i).Value = Date.Now
        DataGridView2.Item(8, i).Value = ""


    End Sub

    Private Sub DataGridView2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim index As Integer = DataGridView2.CurrentRow.Index
        txtBackListNo.Text = DataGridView2.Rows(index).Cells(0).Value.ToString
        txtDesc.Text = DataGridView2.Rows(index).Cells(1).Value.ToString
        DTPickerStart.Text = DataGridView2.Rows(index).Cells(2).Value.ToString
        dtpStopDate.Text = DataGridView2.Rows(index).Cells(3).Value.ToString
        DtpTimeStart.Text = DataGridView2.Rows(index).Cells(2).Value.ToString
        dtpTimeStop.Text = DataGridView2.Rows(index).Cells(3).Value.ToString

        If DataGridView2.Rows(index).Cells(4).Value = "ใช้งาน" Then
            OptIsEnBlackList.Checked = True
        Else
            OptIsUnEnBlackList.Checked = True
        End If
    End Sub

    Private Sub cmdAddBlackL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddBlackL.Click
        addDataGridBlackList()
        txtBackListNo.Text = txtBackListNo.Text + 1
    End Sub

    Private Sub cmdOpenPicture_Click(sender As System.Object, e As System.EventArgs) Handles cmdOpenPicture.Click
        Dim ImageFilename As String
        Try
            OpenFilePicture.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            OpenFilePicture.ShowDialog()
            txtPathPicDriver.Text = OpenFilePicture.FileName
            ImageFilename = OpenFilePicture.FileName
            Using fs As New System.IO.FileStream(txtPathPicDriver.Text, IO.FileMode.Open)
                picDriver.Image = New Bitmap(Image.FromStream(fs))
            End Using
            'UploadPicture()

            '  cmdTemp.Parameters.Add("@photo", SqlDbType.Image, b.Length).Value = b
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub txtLicense_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub txtPersonal_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub txtDriverID_TextChanged(sender As Object, e As EventArgs) Handles txtDriverID.TextChanged
        txtDriverCode.Text = txtDriverID.Text
    End Sub

    Private Sub cmdDeletePicture_Click(sender As Object, e As EventArgs) Handles cmdDeletePicture.Click
        Dim result As DialogResult = MessageBox.Show("คุณต้องการลบรูปนี้จริงหรือไม่?", "การแจ้งเตือน", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            picDriver.Image = Nothing
            DeletePictureTAS(txtDriverID.Text)
        End If

    End Sub


End Class

