Public Class frmMixEditWeight
    Public Load_No As Long
    Dim ChkEditWeightOut As Integer
    Private Sub bt_Cancel_Click(sender As Object, e As EventArgs) Handles bt_Cancel.Click
        Me.Close()
    End Sub

    Private Sub frmMixEditWeight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ChkStatusWeghtEdit(Load_No) Then
            txtNewWeightIn.Text = "-"
            txtNewWeightOut.Text = "-"
            InitailTextEditWeight(Load_No)
        Else
            MsgBox("ไม่อยู่ในสถานะแก้ไขน้ำหนักได้", vbCritical)
            Me.Close()
        End If
    End Sub
    Public Function ChkStatusWeghtEdit(ILoadNo As String) As Boolean
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        ChkStatusWeghtEdit = False
        strSQL = _
                        " select t.load_status , t.is_weight_process " & _
                        " from oil_load_headers t " & _
                        " where t.load_header_no ='" & Trim(ILoadNo) & "' "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                If CDbl(IIf(IsDBNull(dt.Rows(0).Item("load_status")), "", dt.Rows(0).Item("load_status"))) > 21 Then
                    If CDbl(IIf(IsDBNull(dt.Rows(0).Item("is_weight_process")), "0", dt.Rows(0).Item("is_weight_process"))) = 1 Then
                        ChkStatusWeghtEdit = True
                    End If
                End If
            End If
        End If
        mDataSet = Nothing
    End Function
    Private Sub InitailTextEditWeight(ILoadNo As String)
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        strSQL = _
                        " select  t.load_header_no , t.tu_card_no" & _
                        " ,decode( t.tu_id1,NULL,t.tu_id, t.tu_id||'/'||t.tu_id1)  as Carno " & _
                        " ,t.driver_name  ,t.weight_in , t.weight_out , t.load_status " & _
                        " from oil_load_headers t " & _
                        " where t.load_header_no ='" & Trim(ILoadNo) & "'"
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then

                txtLoadNo.Text = IIf(IsDBNull(dt.Rows(0).Item("load_header_no")), "", dt.Rows(0).Item("load_header_no"))
                txtOldWeightIn.Text = IIf(IsDBNull(dt.Rows(0).Item("weight_in")), "", dt.Rows(0).Item("weight_in"))
                txtOldWeightOut.Text = IIf(IsDBNull(dt.Rows(0).Item("weight_out")), "", dt.Rows(0).Item("weight_out"))
                If Val(dt.Rows(0).Item("load_status")) > 55 Then
                    'txtNewWeightOut.Enabled = False
                    ChkEditWeightOut = 1
                Else
                    'txtNewWeightOut.Enabled = True
                    ChkEditWeightOut = 0
                End If
            End If
        End If
        mDataSet = Nothing
    End Sub

    Private Sub bt_Save_Click(sender As Object, e As EventArgs) Handles bt_Save.Click
        EditWeight(txtLoadNo.Text)
    End Sub
    Private Function EditWeight(ILoadNo As String) As Boolean
        Dim strSQL As String
        EditWeight = False
        If txtLoadNo.Text = "" Or txtLoadNo.Text = "-" Then
            MsgBox("ไม่พบ LoadNo ที่ต้องการแก้ไข", vbInformation)
            Exit Function
        End If
        If txtNewWeightIn.Text = "" Or txtNewWeightIn.Text = "-" Then
            MsgBox("ไม่พบปริมาณน้ำหนักชั่งเข้า ที่ต้องการแก้ไข")
            Exit Function
        End If
        If ChkEditWeightOut = 1 Then
            If txtNewWeightOut.Text = "" Or txtNewWeightOut.Text = "-" Then
                MsgBox("ไม่พบปริมาณน้ำหนักชั่งออก ที่ต้องการแก้ไข")
            End If
        End If
        If MsgBox("ท่านต้องการบันทึกข้อมูล?", vbInformation + vbYesNo) = vbNo Then
            Exit Function
        End If

        strSQL = "begin  tas.PROC_CHANGE_LOAD_WEIGHT( '" & ILoadNo & "',0,'" & Trim(txtNewWeightIn.Text) & "'); end;"
        EditWeight = Oradb.ExeSQL(strSQL)
        If EditWeight Then
            Call AddJournal(JournalType.Jevent, 502, 100, IIf(mUserName = "", mUserName, mUserName), 502214, Trim(ILoadNo), Trim(txtOldWeightIn.Text), Trim(txtNewWeightIn.Text))
            If ChkEditWeightOut = 1 Then
                If txtNewWeightOut.Text = "" Or txtNewWeightOut.Text = "-" Then
                Else
                    strSQL = "begin  tas.PROC_CHANGE_LOAD_WEIGHT( '" & ILoadNo & "',1,'" & Trim(txtNewWeightOut.Text) & "'); end;"
                    EditWeight = Oradb.ExeSQL(strSQL)
                    Call AddJournal(JournalType.Jevent, 502, 100, IIf(mUserName = "", mUserName, mUserName), 502215, Trim(ILoadNo), Trim(txtOldWeightOut.Text), Trim(txtNewWeightOut.Text))
                End If
            End If
            If EditWeight Then
                MsgBox("complete ", vbInformation)
            End If
        End If

    End Function

    Private Sub txtNewWeightIn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewWeightIn.KeyPress
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

    Private Sub txtNewWeightOut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewWeightOut.KeyPress
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