Public Class frmLoadEditExcise
    Private Load_Header_No As String = ""
    Private Sub frmLoadEditExcise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitailExciseName()
    End Sub
    Public Sub InitialLoadNo(ByVal LoadNo As String)
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim sql_str As String
        Dim Unit As String = ""
        Load_Header_No = LoadNo
        sql_str = "select t.excise_name from tas.oil_load_headers t" & _
                  " where t.load_header_no = '" & LoadNo & "'"

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            If dt.Rows.Count > 0 Then
                txExciseNameOld.Text = IIf(IsDBNull(dt.Rows(0).Item("excise_name")), "", dt.Rows(0).Item("excise_name").ToString)
            End If
        End If
        mDataSet = Nothing
    End Sub
    Private Sub InitailExciseName()
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        strSQL = _
             "select t.description from tas.status_desc t" & _
             " where t.t_name = 'EXCISE' "

        cbExciseName.Items.Clear()
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            For Each dr As DataRow In dt.Rows
                cbExciseName.Items.Add(IIf(IsDBNull(dr.Item("description")), "", Trim(dr.Item("description"))))
            Next
            cbExciseName.SelectedIndex = 0
        End If

        mDataSet = Nothing
    End Sub
    Private Function Edit_Excise_Name() As Boolean
        Dim strSQL As String

        Edit_Excise_Name = False
        If MsgBox("ท่านต้องการแก้ไขชื่อเจ้าหน้าที่สรรพสามิต จาก " & txExciseNameOld.Text & " เป็น " & cbExciseName.Text & " หรือไม่?", vbInformation + vbYesNo) = vbNo Then
            Exit Function
        End If

        strSQL = "update tas.oil_load_headers t set t.excise_name = '" & cbExciseName.Text & "'" & _
                 " where t.load_header_no = '" & Load_Header_No & "'"

        Dim bRet As Boolean = False
        If Oradb.ExeSQL(strSQL) Then
            MsgBox("ท่านได้ทำการแก้ไข DO จาก '" & txExciseNameOld.Text & "' เป็น '" & cbExciseName.Text & "' เรียบร้อยแล้ว?", vbInformation)
            bRet = True
            Me.Close()
        Else
            bRet = False
        End If

        Return bRet
    End Function

    Private Sub bt_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Save.Click
        Edit_Excise_Name()
    End Sub

    Private Sub bt_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_Cancel.Click
        Me.Close()
    End Sub
End Class