Public Class UcLoadStatus
    Public Sub InitialUser(ByVal iDateStart As String, ByVal iDateEnd As String)
        Call ShowCountAll(iDateStart, iDateEnd)
    End Sub
    Private Sub ShowCountAll(ByVal iDateStart, ByVal iDateEnd)
        Dim strSQL As String
        Dim i As Integer
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        mDataSet = Nothing
        strSQL = _
            "select t.cancel_status,t.load_status,count(t.load_status) as TotCount " & _
            " from tas.oil_load_headers t " & _
            "where eod_date Between to_date('" & iDateStart & "','dd/mm/yyyy hh24:mi:ss') " & _
            "and to_date('" & iDateEnd & "','dd/mm/yyyy hh24:mi:ss') " & _
            " group by t.cancel_status,t.load_status "


        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            txtShipment.Text = 0
            txtCancelShipment.Text = 0
            txtBilling.Text = 0
            txtCheckIn.Text = 0
            txtWinIn.Text = 0
            txtBay.Text = 0
            txtLIncomple.Text = 0
            txtLComple.Text = 0
            txtWinOut.Text = 0
            txtExit.Text = 0
            If dt.Rows.Count > 0 Then
                Do While dt.Rows.Count > i
                    If dt.Rows(i).Item("cancel_status") = 1 Then
                        txtCancelShipment.Text = Val(txtCancelShipment.Text) + dt.Rows(i).Item("TotCount")
                    Else
                        Select Case dt.Rows(i).Item("load_status")
                            Case 11, 12, 13
                                txtBilling.Text = Val(txtBilling.Text) + dt.Rows(i).Item("TotCount")
                            Case 21
                                txtCheckIn.Text = Val(txtCheckIn.Text) + dt.Rows(i).Item("TotCount")
                            Case 31
                                txtWinIn.Text = Val(txtWinIn.Text) + dt.Rows(i).Item("TotCount")
                            Case 51, 52, 53
                                txtBay.Text = Val(txtBay.Text) + dt.Rows(i).Item("TotCount")
                            Case 54
                                txtLIncomple.Text = Val(txtLIncomple.Text) + dt.Rows(i).Item("TotCount")
                            Case 55
                                txtLComple.Text = Val(txtLComple.Text) + dt.Rows(i).Item("TotCount")
                            Case 71
                                txtWinOut.Text = Val(txtWinOut.Text) + dt.Rows(i).Item("TotCount")
                            Case 81
                                txtExit.Text = Val(txtExit.Text) + dt.Rows(i).Item("TotCount")
                        End Select
                    End If
                    i = i + 1
                Loop
            End If
            txtShipment.Text = Val(txtCancelShipment.Text) + Val(txtBilling.Text) + Val(txtCheckIn.Text) + Val(txtWinIn.Text)
            txtShipment.Text = Val(txtShipment.Text) + Val(txtBay.Text) + Val(txtLIncomple.Text) + Val(txtLComple.Text)
            txtShipment.Text = Val(txtShipment.Text) + Val(txtWinOut.Text) + Val(txtExit.Text)
        Else
        End If
        mDataSet = Nothing

    End Sub
End Class
