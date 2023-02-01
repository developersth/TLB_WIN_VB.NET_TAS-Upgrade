Imports System.Data
Imports System.Threading
Public Class frmMMINetworkStatus
    Public FormScreenID As Long
    Dim arrayListStatusMachine As New Collection
    Public tThrLock As New Object

    Public Sub Show_Data()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = _
        "select T.NETWORKIP_ID,T.ADDRESSIP,T.DEVICENAME,T.LOCATION ,tas.GET_DEVICE_CONNECT_STATUS(t.group_type,t.device_id)  as Conect_Status" & _
        " ,tas.GET_DEVICE_CONNECT_STATUS(t.group_type,t.device_id)  as Conect_Status " & _
        "from NETWORK_IP T ,  dual d"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView1.RowCount = 0
            Try
                Do While dt.Rows.Count > i
                    DataGridView1.RowCount = DataGridView1.RowCount + 1
                    DataGridView1.Rows.Item(i).Height = Grid_Height

                    Dim network_id = IIf(IsDBNull(dt.Rows(i).Item("NETWORKIP_ID")), "", dt.Rows(i).Item("NETWORKIP_ID").ToString)
                    Dim conect_status = IIf(IsDBNull(dt.Rows(i).Item("Conect_Status")), "", dt.Rows(i).Item("Conect_Status"))
                    Dim strConnectStatus = ""
                    If IIf(IsDBNull(dt.Rows(i).Item("Conect_Status")), "", dt.Rows(i).Item("Conect_Status")) Or i = 17 Or i = 18 Then
                        arrayListStatusMachine.Item(i + 1).BackgroundImage = My.Resources.ResourceManager.GetObject("green")
                        strConnectStatus = "Online"
                    Else
                        strConnectStatus = "Offline"
                    End If
                    DataGridView1.Item(0, i).Value = network_id
                    DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("DEVICENAME")), "", dt.Rows(i).Item("DEVICENAME").ToString)
                    DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("ADDRESSIP")), "", dt.Rows(i).Item("ADDRESSIP").ToString)
                    DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("LOCATION")), "", dt.Rows(i).Item("LOCATION").ToString)
                    DataGridView1.Item(4, i).Value = strConnectStatus
                    i = i + 1
                Loop
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


        Else
        End If
        mDataSet = Nothing

    End Sub
    Dim toggleVeiwDataGrid = False
    Dim messBtnDataGrid = "View  DataGrid"
    Private Sub btnViewTable_Click(sender As Object, e As EventArgs) Handles btnViewTable.Click
        toggleVeiwDataGrid = Not toggleVeiwDataGrid
        If toggleVeiwDataGrid Then
            btnViewTable.Text = "Hide  Data"
        Else
            btnViewTable.Text = "View  Data"
        End If
        DataGridView1.Visible = toggleVeiwDataGrid
    End Sub
    Private Sub frmMMINetworkStatus_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.UseWaitCursor = True
        tThread.Abort()
        CloseForm(FormScreenID, "")

    End Sub

    Private Sub frmMMINetworkStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
        Show_Data()
        'Timer1.Start()
        StartThread()
    End Sub
    Public Sub init()
        arrayListStatusMachine.Add(picLight1)
        arrayListStatusMachine.Add(picLight2)
        arrayListStatusMachine.Add(picLight3)
        arrayListStatusMachine.Add(picLight4)
        arrayListStatusMachine.Add(picLight5)
        arrayListStatusMachine.Add(picLight6)
        arrayListStatusMachine.Add(picLight7)
        arrayListStatusMachine.Add(picLight8)
        arrayListStatusMachine.Add(picLight9)
        arrayListStatusMachine.Add(picLight10)

        arrayListStatusMachine.Add(picLight11)
        arrayListStatusMachine.Add(picLight12)
        arrayListStatusMachine.Add(picLight13)
        arrayListStatusMachine.Add(picLight14)
        arrayListStatusMachine.Add(picLight15)
        arrayListStatusMachine.Add(picLight16)
        arrayListStatusMachine.Add(picLight17)
        arrayListStatusMachine.Add(picLight18)
        arrayListStatusMachine.Add(picLight19)
        arrayListStatusMachine.Add(picLight20)

        arrayListStatusMachine.Add(picLight21)
        arrayListStatusMachine.Add(picLight22)
        arrayListStatusMachine.Add(picLight23)
        arrayListStatusMachine.Add(picLight24)
        arrayListStatusMachine.Add(picLight25)
        arrayListStatusMachine.Add(picLight26)
        arrayListStatusMachine.Add(picLight27)
        arrayListStatusMachine.Add(picLight28)
        arrayListStatusMachine.Add(picLight29)
        arrayListStatusMachine.Add(picLight30)

        arrayListStatusMachine.Add(picLight31)
        arrayListStatusMachine.Add(picLight32)
        arrayListStatusMachine.Add(picLight33)
        arrayListStatusMachine.Add(picLight34)
        arrayListStatusMachine.Add(picLight35)
        arrayListStatusMachine.Add(picLight36)
        arrayListStatusMachine.Add(picLight37)
        arrayListStatusMachine.Add(picLight38)
    End Sub
    Private Sub setPopupStatus(ByVal Val As Integer)
        Dim i = Val

        popupNetworkStatus.lblName.Text = DataGridView1.Item(1, i).Value.ToString()
        If DataGridView1.Item(2, i).Value.ToString().Length <> 0 Then
            popupNetworkStatus.lblIP.Text = DataGridView1.Item(2, i).Value.ToString()
        Else
            popupNetworkStatus.lblIP.Text = "-"
        End If

        If DataGridView1.Item(3, i).Value.ToString().Length <> 0 Then
            popupNetworkStatus.lblLocation.Text = DataGridView1.Item(3, i).Value.ToString()
        Else
            popupNetworkStatus.lblLocation.Text = "-"
        End If

        If DataGridView1.Item(4, i).Value.ToString().Length <> 0 Then
            popupNetworkStatus.lblStatus.Text = DataGridView1.Item(4, i).Value.ToString()
        Else
            popupNetworkStatus.lblStatus.Text = "-"
        End If
        popupNetworkStatus.Show()
        Dim j As Integer = 20
        'popupNetworkStatus.Location = New Point(sender.Location.X + xPicBG + sender.Size.Width, sender.Location.Y + yPicBG + sender.Size.Height)
        'popupNetworkStatus.Location = New Point("picLight" & j & ".Location.X, picLight" & j & ".Location.Y + 2")
    End Sub

    Private Sub picLight1_MouseHover(sender As Object, e As EventArgs) Handles picLight1.MouseHover
        setPopupStatus(0)
    End Sub

    Private Sub picLight1_MouseLeave(sender As Object, e As EventArgs) Handles picLight1.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight2_MouseHover(sender As Object, e As EventArgs) Handles picLight2.MouseHover
        setPopupStatus(1)
    End Sub

    Private Sub picLight2_MouseLeave(sender As Object, e As EventArgs) Handles picLight2.MouseLeave
        popupNetworkStatus.Close()
    End Sub




    Function PingIP(ByVal IP As String) As Boolean
        Dim vCheck As Boolean
        If My.Computer.Network.Ping(IP.ToString) Then
            vCheck = True
        Else
            vCheck = False
        End If
        Return vCheck
    End Function

    Private Sub btPing_Click(sender As Object, e As EventArgs)
        'InitialIP()
        'StartThread()
    End Sub
    Private Sub InitialIP()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim strConnectStatus As String
        sql_str = _
        "select T.NETWORKIP_ID,T.ADDRESSIP,T.DEVICENAME,T.LOCATION ,tas.GET_DEVICE_CONNECT_STATUS(t.group_type,t.device_id)  as Conect_Status" & _
        " ,tas.GET_DEVICE_CONNECT_STATUS(t.group_type,t.device_id)  as Conect_Status " & _
        "from NETWORK_IP T ,  dual d"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            Do While dt.Rows.Count > i
                If IIf(IsDBNull(dt.Rows(i).Item("ADDRESSIP")), "", dt.Rows(i).Item("ADDRESSIP").ToString) <> "" Then
                    If PingIP(Trim(dt.Rows(i).Item("ADDRESSIP"))) Then
                        arrayListStatusMachine.Item(i + 1).BackgroundImage = My.Resources.ResourceManager.GetObject("green")
                        strConnectStatus = "Online"
                    Else
                        arrayListStatusMachine.Item(i + 1).BackgroundImage = My.Resources.ResourceManager.GetObject("red")
                        strConnectStatus = "Offline"
                    End If
                    DataGridView1.Item(4, i).Value = strConnectStatus
                    'CheckNetworkIsAvailable(Trim(dt.Rows(i).Item("ADDRESSIP")), i)
                End If
                i = i + 1
            Loop
        End If
    End Sub

#Region "thread"
    Dim tExit As Boolean
    Dim tExit2 As Boolean
    Dim tThread As Thread

    Private Sub StartThread()
        tThread = New Thread(AddressOf RunProcess)
        tThread.Name = "Network"
        tThread.Start()

        'tThread = New Thread(AddressOf RunProcess2)
        'tThread.Name = "Network2"
        'tThread.Start()
    End Sub


    Private Sub RunProcess()
        While (1)
            Try
                SyncLock (tThrLock)
                    If tExit Then Exit While
                    InitialIP()
                    Application.DoEvents()
                End SyncLock
                Thread.Sleep(5000)
                If Me.InvokeRequired Then
                    Exit While
                End If
            Catch ex As Exception
                'MessageBox.Show(ex.Message)
            End Try
        End While
    End Sub

    Private Sub RunProcess2()
        While (1)
            Try
                SyncLock (tThrLock)
                    If tExit2 Then Exit While
                    'Show_Data()
                    Application.DoEvents()
                End SyncLock
                Thread.Sleep(1000)
            Catch ex As Exception
                'MessageBox.Show(ex.Message)
            End Try
        End While
    End Sub
#End Region

    Private Sub picLight3_MouseLeave(sender As Object, e As EventArgs) Handles picLight3.MouseLeave, picLight3.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight3_MouseHover(sender As Object, e As EventArgs) Handles picLight3.MouseHover
        setPopupStatus(2)
    End Sub

    Private Sub picLight4_MouseHover(sender As Object, e As EventArgs) Handles picLight4.MouseHover
        setPopupStatus(3)
    End Sub

    Private Sub picLight4_MouseLeave(sender As Object, e As EventArgs) Handles picLight4.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight5_MouseHover(sender As Object, e As EventArgs) Handles picLight5.MouseHover
        setPopupStatus(4)
    End Sub

    Private Sub picLight5_MouseLeave(sender As Object, e As EventArgs) Handles picLight5.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight6_MouseHover(sender As Object, e As EventArgs) Handles picLight6.MouseHover
        setPopupStatus(5)
    End Sub

    Private Sub picLight6_MouseLeave(sender As Object, e As EventArgs) Handles picLight6.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight9_MouseHover(sender As Object, e As EventArgs) Handles picLight9.MouseHover
        setPopupStatus(8)
    End Sub

    Private Sub picLight9_MouseLeave(sender As Object, e As EventArgs) Handles picLight9.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight10_MouseHover(sender As Object, e As EventArgs) Handles picLight10.MouseHover
        setPopupStatus(9)
    End Sub

    Private Sub picLight10_MouseLeave(sender As Object, e As EventArgs) Handles picLight10.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight11_MouseHover(sender As Object, e As EventArgs) Handles picLight11.MouseHover
        setPopupStatus(10)
    End Sub

    Private Sub picLight11_MouseLeave(sender As Object, e As EventArgs) Handles picLight11.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight12_MouseHover(sender As Object, e As EventArgs) Handles picLight12.MouseHover
        setPopupStatus(11)
    End Sub

    Private Sub picLight12_MouseLeave(sender As Object, e As EventArgs) Handles picLight12.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight13_MouseHover(sender As Object, e As EventArgs) Handles picLight13.MouseHover
        setPopupStatus(12)
    End Sub

    Private Sub picLight13_MouseLeave(sender As Object, e As EventArgs) Handles picLight13.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight14_MouseHover(sender As Object, e As EventArgs) Handles picLight14.MouseHover
        setPopupStatus(13)
    End Sub

    Private Sub picLight14_MouseLeave(sender As Object, e As EventArgs) Handles picLight14.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight15_MouseHover(sender As Object, e As EventArgs) Handles picLight15.MouseHover
        setPopupStatus(14)
    End Sub

    Private Sub picLight15_MouseLeave(sender As Object, e As EventArgs) Handles picLight15.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight16_MouseHover(sender As Object, e As EventArgs) Handles picLight16.MouseHover
        setPopupStatus(15)
    End Sub

    Private Sub picLight16_MouseLeave(sender As Object, e As EventArgs) Handles picLight16.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight17_MouseHover(sender As Object, e As EventArgs) Handles picLight17.MouseHover
        setPopupStatus(16)
    End Sub

    Private Sub picLight17_MouseLeave(sender As Object, e As EventArgs) Handles picLight17.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight18_MouseHover(sender As Object, e As EventArgs) Handles picLight18.MouseHover
        setPopupStatus(17)
    End Sub

    Private Sub picLight18_MouseLeave(sender As Object, e As EventArgs) Handles picLight18.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight19_MouseHover(sender As Object, e As EventArgs) Handles picLight19.MouseHover
        setPopupStatus(18)
    End Sub

    Private Sub picLight19_MouseLeave(sender As Object, e As EventArgs) Handles picLight19.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight20_MouseHover(sender As Object, e As EventArgs) Handles picLight20.MouseHover
        setPopupStatus(19)
    End Sub

    Private Sub picLight20_MouseLeave(sender As Object, e As EventArgs) Handles picLight20.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight21_MouseHover(sender As Object, e As EventArgs) Handles picLight21.MouseHover
        setPopupStatus(20)
    End Sub

    Private Sub picLight21_MouseLeave(sender As Object, e As EventArgs) Handles picLight21.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight22_MouseHover(sender As Object, e As EventArgs) Handles picLight22.MouseHover
        setPopupStatus(21)
    End Sub

    Private Sub picLight22_MouseLeave(sender As Object, e As EventArgs) Handles picLight22.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight23_MouseHover(sender As Object, e As EventArgs) Handles picLight23.MouseHover
        setPopupStatus(22)
    End Sub

    Private Sub picLight23_MouseLeave(sender As Object, e As EventArgs) Handles picLight23.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight24_MouseHover(sender As Object, e As EventArgs) Handles picLight24.MouseHover
        setPopupStatus(23)
    End Sub

    Private Sub picLight24_MouseLeave(sender As Object, e As EventArgs) Handles picLight24.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight25_MouseHover(sender As Object, e As EventArgs) Handles picLight25.MouseHover
        setPopupStatus(24)
    End Sub

    Private Sub picLight25_MouseLeave(sender As Object, e As EventArgs) Handles picLight25.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight26_MouseHover(sender As Object, e As EventArgs) Handles picLight26.MouseHover
        setPopupStatus(25)
    End Sub

    Private Sub picLight26_MouseLeave(sender As Object, e As EventArgs) Handles picLight26.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight27_MouseHover(sender As Object, e As EventArgs) Handles picLight27.MouseHover
        setPopupStatus(26)
    End Sub

    Private Sub picLight27_MouseLeave(sender As Object, e As EventArgs) Handles picLight27.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight28_MouseHover(sender As Object, e As EventArgs) Handles picLight28.MouseHover
        setPopupStatus(27)
    End Sub

    Private Sub picLight28_MouseLeave(sender As Object, e As EventArgs) Handles picLight28.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight29_MouseHover(sender As Object, e As EventArgs) Handles picLight29.MouseHover
        setPopupStatus(28)
    End Sub

    Private Sub picLight29_MouseLeave(sender As Object, e As EventArgs) Handles picLight29.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight30_MouseHover(sender As Object, e As EventArgs) Handles picLight30.MouseHover
        setPopupStatus(29)
    End Sub

    Private Sub picLight30_MouseLeave(sender As Object, e As EventArgs) Handles picLight30.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight31_MouseHover(sender As Object, e As EventArgs) Handles picLight31.MouseHover
        setPopupStatus(30)
    End Sub

    Private Sub picLight31_MouseLeave(sender As Object, e As EventArgs) Handles picLight31.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight32_MouseHover(sender As Object, e As EventArgs) Handles picLight32.MouseHover
        setPopupStatus(31)
    End Sub

    Private Sub picLight32_MouseLeave(sender As Object, e As EventArgs) Handles picLight32.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight33_MouseHover(sender As Object, e As EventArgs) Handles picLight33.MouseHover
        setPopupStatus(32)
    End Sub

    Private Sub picLight33_MouseLeave(sender As Object, e As EventArgs) Handles picLight33.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight34_MouseHover(sender As Object, e As EventArgs) Handles picLight34.MouseHover
        setPopupStatus(33)
    End Sub

    Private Sub picLight34_MouseLeave(sender As Object, e As EventArgs) Handles picLight34.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight35_MouseHover(sender As Object, e As EventArgs) Handles picLight35.MouseHover
        setPopupStatus(34)
    End Sub

    Private Sub picLight35_MouseLeave(sender As Object, e As EventArgs) Handles picLight35.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub picLight36_MouseHover(sender As Object, e As EventArgs) Handles picLight36.MouseHover
        setPopupStatus(35)
    End Sub

    Private Sub picLight36_MouseLeave(sender As Object, e As EventArgs) Handles picLight36.MouseLeave
        popupNetworkStatus.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        InitialIP()
        'Show_Data()
    End Sub
End Class