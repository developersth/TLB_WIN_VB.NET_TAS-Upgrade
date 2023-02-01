Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strSQL =
            "select B.BAY_NO,B.BAY_NAME from view_bay_mmi_loading B " &
            "order by B.BAY_NO"

        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim j = 0
        'UcButtonBay1.Width = 60
        'UcButtonBay1.Height = 30
        Dim xlocation As Integer = 2

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Do While dt.Rows.Count > j
                Dim btnButtonbay As New Button()
                btnButtonbay.Name = IIf(IsDBNull(dt.Rows(j).Item("BAY_NAME")), "- -", dt.Rows(j).Item("BAY_NAME").ToString)
                btnButtonbay.Text = IIf(IsDBNull(dt.Rows(j).Item("BAY_NO")), "- -", dt.Rows(j).Item("BAY_NO").ToString)
                btnButtonbay.Location = New Point(xlocation, 10)
                btnButtonbay.Size = New Size(75, 35)
                btnButtonbay.Left = 2
                btnButtonbay.Top = 2
                btnButtonbay.BackColor = Color.Green
                btnButtonbay.Visible = True
                Panel1.Controls.Add(btnButtonbay)
                xlocation = xlocation + 85
                j = j + 1
            Loop
        End If


        dt = Nothing
        mDataSet.Dispose()
        mDataSet = Nothing
    End Sub
End Class