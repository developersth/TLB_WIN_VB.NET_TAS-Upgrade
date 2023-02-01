Public Class frmMMIPermissive

    Dim vMeter As String
    Private Sub frmMMIPermissive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowPermissiveMeter()
    End Sub


    Private Sub ShowPermissiveMeter()

        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        strSQL = _
                        " select  t.METER_NO , t.ESD_ID , t.ESD_NAME " & _
                        " from steqi.view_config_interlock_esd t " & _
                       "  where t.METER_NO='" & Trim(vMeter) & "'"
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            MsGrid.RowCount = 0
            Do While dt.Rows.Count > i
                MsGrid.RowCount = MsGrid.RowCount + 1
                MsGrid.Rows.Item(i).Height = Grid_Height
                MsGrid.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Esd_id")), "", dt.Rows(i).Item("Esd_id").ToString)
                MsGrid.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ESD_NAME")), "", dt.Rows(i).Item("ESD_NAME").ToString)
               'MSGridConfig.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PERMISSIVE_NAME")), "", dt.Rows(i).Item("PERMISSIVE_NAME").ToString)
                'MSGridConfig.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("PERMISSIVE_NAME")), "", dt.Rows(i).Item("PERMISSIVE_NAME").ToString)
                i = i + 1
            Loop
        Else
            MsGrid.RowCount = 1

        End If
        mDataSet = Nothing
    End Sub



    Public Sub GetPermissiveMeter(ByVal iMeter As String)
        vMeter = iMeter
        'Me.Caption = ""
        'frmMMIPermissive.Caption = "PERMISSIVE  METER  " & iMeter
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class