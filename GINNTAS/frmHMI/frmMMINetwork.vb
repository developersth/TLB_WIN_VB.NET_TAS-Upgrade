
Imports System.Data

Public Class frmMMINetwork

    Public FormScreenID As Long
    Dim frm_work As Integer = 0
    Dim arrayListStatusMachine As New Collection
    Public xPicBG = 100
    Public yPicBG = 111

    Private Sub frmMMINetwork_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        resolution(Me, 1)

        Show_Data()
        UcNetworkStatus1.init()
        UcNetworkStatus1.Show_Data()
    End Sub

    Private Sub frmMMINetwork_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub
    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub
    Dim toggleVeiwDataGrid = False
    Dim messBtnDataGrid = "View  DataGrid"
    Private Sub btnViewTable_Click(sender As System.Object, e As System.EventArgs)

        toggleVeiwDataGrid = Not toggleVeiwDataGrid
        If toggleVeiwDataGrid Then
            btnViewTable.Text = "Hide  DataGrid"
        Else
            btnViewTable.Text = "View  DataGrid"
        End If
        DataGridView1.Visible = toggleVeiwDataGrid
    End Sub
    Public Sub Show_Data()

        'pic1.Parent = picBG
        'pic1.Location = New Point(pic1.Location.X - xPicBG, pic1.Location.Y - yPicBG)


        'pic2.Parent = picBG
        'pic2.Location = New Point(pic2.Location.X - xPicBG, pic2.Location.Y - yPicBG)

        'pic3.Parent = picBG
        'pic3.Location = New Point(pic3.Location.X - xPicBG, pic3.Location.Y - yPicBG)

        'pic4.Parent = picBG
        'pic4.Location = New Point(pic4.Location.X - xPicBG, pic4.Location.Y - yPicBG)

        'pic5.Parent = picBG
        'pic5.Location = New Point(pic5.Location.X - xPicBG, pic5.Location.Y - yPicBG)


        'pic6.Parent = picBG
        'pic6.Location = New Point(pic6.Location.X - xPicBG, pic6.Location.Y - yPicBG)

        'pic7.Parent = picBG
        'pic7.Location = New Point(pic7.Location.X - xPicBG, pic7.Location.Y - yPicBG)

        'pic10.Parent = picBG
        'pic10.Location = New Point(pic10.Location.X - xPicBG, pic10.Location.Y - yPicBG)

        'pic11.Parent = picBG
        'pic11.Location = New Point(pic11.Location.X - xPicBG, pic11.Location.Y - yPicBG)

        'pic12.Parent = picBG
        'pic12.Location = New Point(pic12.Location.X - xPicBG, pic12.Location.Y - yPicBG)

        'pic13.Parent = picBG
        'pic13.Location = New Point(pic13.Location.X - xPicBG, pic13.Location.Y - yPicBG)

        'pic14.Parent = picBG
        'pic14.Location = New Point(pic14.Location.X - xPicBG, pic14.Location.Y - yPicBG)


        'pic15.Parent = picBG
        'pic15.Location = New Point(pic15.Location.X - xPicBG, pic15.Location.Y - yPicBG)

        'pic16.Parent = picBG
        'pic16.Location = New Point(pic16.Location.X - xPicBG, pic16.Location.Y - yPicBG)

        'pic17.Parent = picBG
        'pic17.Location = New Point(pic17.Location.X - xPicBG, pic17.Location.Y - yPicBG)

        'pic18.Parent = picBG
        'pic18.Location = New Point(pic18.Location.X - xPicBG, pic18.Location.Y - yPicBG)

        'pic19.Parent = picBG
        'pic19.Location = New Point(pic19.Location.X - xPicBG, pic19.Location.Y - yPicBG)

        'pic20.Parent = picBG
        'pic20.Location = New Point(pic20.Location.X - xPicBG, pic20.Location.Y - yPicBG)

        'pic21.Parent = picBG
        'pic21.Location = New Point(pic21.Location.X - xPicBG, pic21.Location.Y - yPicBG)

        'pic22.Parent = picBG
        'pic22.Location = New Point(pic22.Location.X - xPicBG, pic22.Location.Y - yPicBG)

        'pic23.Parent = picBG
        'pic23.Location = New Point(pic23.Location.X - xPicBG, pic23.Location.Y - yPicBG)

        'pic24.Parent = picBG
        'pic24.Location = New Point(pic24.Location.X - xPicBG, pic24.Location.Y - yPicBG)

        'pic25.Parent = picBG
        'pic25.Location = New Point(pic25.Location.X - xPicBG, pic25.Location.Y - yPicBG)

        'pic26.Parent = picBG
        'pic26.Location = New Point(pic26.Location.X - xPicBG, pic26.Location.Y - yPicBG)

        'pic27.Parent = picBG
        'pic27.Location = New Point(pic27.Location.X - xPicBG, pic27.Location.Y - yPicBG)

        'pic28.Parent = picBG
        'pic28.Location = New Point(pic28.Location.X - xPicBG, pic28.Location.Y - yPicBG)

        'pic29.Parent = picBG
        'pic29.Location = New Point(pic29.Location.X - xPicBG, pic29.Location.Y - yPicBG)

        'pic31.Parent = picBG
        'pic31.Location = New Point(pic31.Location.X - xPicBG, pic31.Location.Y - yPicBG)

        'pic32.Parent = picBG
        'pic32.Location = New Point(pic32.Location.X - xPicBG, pic32.Location.Y - yPicBG)

        'pic33.Parent = picBG
        'pic33.Location = New Point(pic33.Location.X - xPicBG, pic33.Location.Y - yPicBG)

        'pic34.Parent = picBG
        'pic34.Location = New Point(pic34.Location.X - xPicBG, pic34.Location.Y - yPicBG)

        'pic35.Parent = picBG
        'pic35.Location = New Point(pic35.Location.X - xPicBG, pic35.Location.Y - yPicBG)

        'pic36.Parent = picBG
        'pic36.Location = New Point(pic36.Location.X - xPicBG, pic36.Location.Y - yPicBG)

        'pic37.Parent = picBG
        'pic37.Location = New Point(pic37.Location.X - xPicBG, pic37.Location.Y - yPicBG)



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
            Do While dt.Rows.Count > i
                DataGridView1.RowCount = DataGridView1.RowCount + 1
                DataGridView1.Rows.Item(i).Height = Grid_Height

                Dim network_id = IIf(IsDBNull(dt.Rows(i).Item("NETWORKIP_ID")), "", dt.Rows(i).Item("NETWORKIP_ID").ToString)
                Dim conect_status = IIf(IsDBNull(dt.Rows(i).Item("Conect_Status")), "", dt.Rows(i).Item("Conect_Status"))
                Dim strConnectStatus = ""
                If IIf(IsDBNull(dt.Rows(i).Item("Conect_Status")), "", dt.Rows(i).Item("Conect_Status")) Or i = 17 Or i = 18 Then
                    'arrayListStatusMachine.Item(i + 1).Image = My.Resources.ResourceManager.GetObject("GG")
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
        Else
        End If
        mDataSet = Nothing

    End Sub
    Private Sub UcHeader1_CloseButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.CloseButtonClick
        Me.Close()
    End Sub

    Private Sub UcHeader1_MinimizeButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.MinimizeButtonClick
        Me.WindowState = FormWindowState.Minimized
    End Sub

 

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

 
    Private Sub btnViewTable_Click_1(sender As Object, e As EventArgs) Handles btnViewTable.Click
        toggleVeiwDataGrid = Not toggleVeiwDataGrid
        If toggleVeiwDataGrid Then
            btnViewTable.Text = "Hide  DataGrid"
        Else
            btnViewTable.Text = "View  DataGrid"
        End If
        DataGridView1.Visible = toggleVeiwDataGrid
    End Sub
End Class