Public Class frmRemark

    Dim L_H_N As String


    Private Sub frmRemark_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        assignDropDown()
    End Sub

    Public Sub SetLoadNo(ByVal ILoadNo As String)
        L_H_N = ILoadNo
    End Sub


    Function assignDropDown() As Boolean
        Dim sql_str As String
        sql_str = "select   t.description  from oil_load_headers t "
        sql_str = sql_str & " Where t.description Is Not Null "
        sql_str = sql_str & " group by t.description"
        assignDropDown(sql_str, "DESCRIPTION", cbRemark)
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



    Private Sub CmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOK.Click
        Dim strSQL As String
        If L_H_N = "" Then
            MsgBox(" ไม่พบหมายเลข Load No  ที่ต้องการแก้ไข", vbInformation)
            Exit Sub
        End If
        If cbRemark.Text = "" Then
            MsgBox(" คุณจำเป็นต้องใส่เหตุผลที่ต้องการยกเลิก ถ้าคุณไม่ใส่คุณจะไม่สามารถทำการยกเลิกได้ ", vbCritical, "คำเตือน")
            Exit Sub
        End If
        strSQL = " update  tas.oil_load_headers t set  t.description='" & Trim(cbRemark.Text) & "' "
        strSQL = strSQL & " where t.load_header_no= " & Trim(L_H_N) & " "

        frmLoadLoading.RemarkCancelOK = False
        Oradb.ExeSQL(strSQL)
        Me.Close()
    End Sub

    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        frmLoadLoading.RemarkCancelOK = True
        'Unload(Me)
        Me.Close()
    End Sub
End Class