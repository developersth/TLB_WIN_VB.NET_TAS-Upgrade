Public Class frmMainTransportUnit_VehicleType_sub
    Dim frm_work As Integer = 0 'TransportUnit1=add ,2=Edit
    Dim pk_id As String = ""
    Private Sub frmMainTransportUnit_VehicleType_sub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frm_work = 1 Then
            Me.Text = "ประเภทรถ # Add"
        ElseIf frm_work = 2 Then
            Me.Text = "ประเภทรถ # Edit"
            txtID.Enabled = False
            AssignValue()
        End If
    End Sub
    Private Sub AssignValue()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        sql_str = _
                "select t.status_varchar,t.description " & _
           " from status_desc t" & _
           " where t.columns_name='TU_TYPE' " & _
           " and t.status_varchar='" & pk_id & "'" & _
           " order by t.status_varchar"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            txtID.Text = IIf(IsDBNull(dt.Rows(i).Item("status_varchar")), "", dt.Rows(i).Item("status_varchar").ToString)
            txtDescription.Text = IIf(IsDBNull(dt.Rows(i).Item("description")), "", dt.Rows(i).Item("description").ToString)
        Else
        End If
        mDataSet = Nothing

    End Sub
    Public Sub setFrmWork(ByVal n As Integer)
        Me.frm_work = n
    End Sub

    Public Sub setPkId(ByVal id As String)
        Me.pk_id = id
    End Sub
    Private Sub Save()

        Dim strSQL As String
        strSQL = _
        "insert into STATUS_DESC (" & _
        "T_NAME,COLUMNS_NAME,STATUS_VARCHAR,DESCRIPTION," & _
        "UPDATE_DATE," & _
        "UPDATED_BY, " & _
         "J_COMPUTER) " & _
        "values(" & _
        "'TU'" & ",'TU_TYPE'," & _
        "'" & Trim(txtID.Text) & "','" & txtDescription.Text & "'," & _
        "sysdate,'" & mUserName & "'," & _
        "'" & mComputerName & "')"

        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmMainTransportUnit_VehicleType.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If

    End Sub
    Private Sub Edit()

        Dim strSQL As String
        strSQL = _
        "UPDATE STATUS_DESC  SET " & _
        "DESCRIPTION= '" & txtDescription.Text & "'" & _
        ",UPDATE_DATE=sysdate" & _
        ",UPDATED_BY= '" & mUserName & "'" & _
         ",J_COMPUTER= '" & mComputerName & "'" & _
        " WHERE STATUS_VARCHAR ='" & txtID.Text & "'"

        If Oradb.ExeSQL(strSQL) Then
            MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
            Me.Close()
            setFrmWork(0)
            frmMainTransportUnit_VehicleType.Show_Data()
        Else
            MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If

    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        If txtID.Text = "" Or txtDescription.Text = "" Then
            MessageBox.Show("ท่านกรอกข้อมูลไม่ครบ")
            Exit Sub
        End If
       
        If frm_work = 1 Then
            If CheckDataExist(txtID.Text) Then
                Exit Sub
            End If
            Save()
        ElseIf frm_work = 2 Then
            Edit()
        End If

    End Sub
    Function CheckDataExist(ByVal id As String) As Boolean
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim vCheck As Boolean = False
        strSQL = _
            "select count(C.STATUS_VARCHAR) as vCount " & _
               "from STATUS_DESC C " & _
               "where C.STATUS_VARCHAR = '" & id & "'"
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            If dt.Rows.Count > 0 Then
                If dt.Rows(i).Item("vCount") > 0 Then
                    MsgBox("มีรหัสประเภทรถอยู่ในฐานข้อมูลแล้ว", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                    vCheck = True
                Else
                    vCheck = False
                End If
            End If
        End If
        Return vCheck
    End Function
    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub
End Class