Public Class frmDeviceEven

    Private Sub UcMenuRefresh_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuRefresh.OnClickMnuText
        Call RefreshData()
    End Sub
    Private Sub InitialCombo()
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim sql_str As String
        Dim i As Long
        sql_str = "select DEVICE_NAME,DESCRIPTION,DESCRIPTION||' - '||DEVICE_NAME as D_NAME  " & _
                " from steqi.view_device_name_event " & _
                " order by DEVICE_NAME"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            Do While dt.Rows.Count > i
                cbDevice.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("D_NAME")), "", dt.Rows(i).Item("D_NAME").ToString))
                i = i + 1
            Loop
            i = i + 1
        End If
    End Sub
    Private Sub ShowData(ByVal pDeviceName As String)
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim sql_str As String
        Dim i As Long
        sql_str = "select EVENT_MSG  " & _
                " from td.DEVICE_MSG " & _
                " where DEVICE_NAME='" & pDeviceName & "'" & _
                " order by CREATE_DATE,MSG_ID"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            Do While dt.Rows.Count > i
                lstDevice.Items.Add(IIf(IsDBNull(dt.Rows(i).Item("EVENT_MSG")), "", dt.Rows(i).Item("EVENT_MSG").ToString))
                i = i + 1
            Loop
            i = i + 1
        End If
    End Sub
    Private Sub frmDeviceEven_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitialCombo()
    End Sub
    Private Sub RefreshData()
        Dim s() As String
        If Len(cbDevice.Text) > 0 Then
            txtSel.Text = ""
            s = Split(cbDevice.Text, " - ")
            Call ShowData(s(1))
        End If
    End Sub
End Class