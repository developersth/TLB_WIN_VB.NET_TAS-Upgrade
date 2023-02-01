Imports System.Threading
Imports System.Windows.Media
Public Class ucFooter
    Dim thr As Thread
    Dim bExit As Boolean = False
    Dim DB_status As Boolean
    Dim AlarmMsg As String
    Dim MedPlayer As New MediaPlayer
    Dim chkSoundStatus As Boolean = False


#Region "Thread"
    Public Sub StartThread()
        thr = New Thread(New ThreadStart(AddressOf ProcessThread))
        thr.Name = Me.Tag.ToString
        thr.Start()
        'Thread.Sleep(1000)
    End Sub

    Private Sub ProcessThread()
        Try
            While Not bExit
                If lblUser.Text.IndexOf(mUserName) = -1 Then
                    'SetControlText(lblUser, "User Name : " & mUserName & " User Group : " & mUserGroupName)
                    SetControlText(lblUser, mUserName)
                End If

                If lblServer.Text.IndexOf(Oradb.ConnectServiceName) Then
                    SetControlText(lblServer, Oradb.ConnectServiceName)
                End If

                SetControlText(lblDateTime, Now.ToString)

                If GetStatusDatabase() <> DB_status Then
                    DB_status = GetStatusDatabase()
                    If DB_status Then
                        picDB.BackgroundImage = My.Resources.DBcon
                    Else
                        picDB.BackgroundImage = My.Resources.DBdis
                    End If
                End If

                Thread.Sleep(1000)
            End While
        Catch ex As Exception

        End Try
    End Sub

    Public Sub StopThread()
        bExit = True
    End Sub

    Private Delegate Sub SetControlTextInvoke(ByVal e As Control, ByVal s As String)

    Private Sub SetControlText(ByVal e As Control, ByVal s As String)
        Try
            If e.InvokeRequired Then
                e.Invoke(New SetControlTextInvoke(AddressOf SetControlText), e, s)
            Else
                e.Text = s
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region

    Private Sub ucFooter_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        bExit = True
        'thr.Abort()
    End Sub

    Private Sub ucFooter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitializeObj()
        'StartThread()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        InitializeObj()
        Me.Anchor = AnchorStyles.Top Or AnchorStyles.Right
    End Sub

    Private Sub InitializeObj()
        Me.BackColor = System.Drawing.Color.Transparent
        'Me.Width = 366
        'Me.Height = 58

        picDB.Left = Me.Width - picDB.Width - 2
        picDB.Top = Me.Height - picDB.Height - 2

        lblDateTime.Left = picDB.Left - lblDateTime.Width - 2
        lblDateTime.Top = Me.Height - lblDateTime.Height

        lblUser.Left = Me.Width - lblUser.Width - 4
        lblUser.Top = lblDateTime.Top - lblUser.Height - 2
    End Sub

    Private Sub ucFooter_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        InitializeObj()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Public Sub InitialObject(iAlarm As Long, AlarmMssg As String, Comm As Long, Meter As Long)
        AlarmAlarm(iAlarm, AlarmMssg)
    End Sub
    Private Sub AlarmAlarm(iAlarm As Long, AlarmMssg As String)
        If iAlarm = 1 Then
            ' UcBtnAlarm.MenuImage = My.Resources.ResourceManager.GetObject("mnubg_n1")
            'btnAlarm.Image = Image.FromFile(GetCurrDirectory() & "\pictures\mnubg_n1.gif")
            btnAlarm.BackColor = System.Drawing.Color.Red
            SetControlText(txtAlarmMsg, AlarmMssg)
            PlaySound()
        Else
            'btnAlarm.Image = My.Resources.ResourceManager.GetObject("mnubg_n")
            btnAlarm.BackColor = System.Drawing.Color.Blue
            SetControlText(txtAlarmMsg, AlarmMssg)
            StopSound()
        End If
    End Sub
    Public Function App_Path() As String
        App_Path = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
    End Function
    Sub PlaySound()
        Dim SApp_Path As String = App_Path()
        MedPlayer.Open(New Uri(SApp_Path & "\Sound\Alarm.WAV", UriKind.RelativeOrAbsolute))
        MedPlayer.Play()
    End Sub
    Sub StopSound()
        MedPlayer.Stop()
    End Sub
    Public Function ShowAlarm() As Long
        Dim strSQL As String, i As Long, j As Long
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        strSQL =
        " select T.* " &
        " from TAS.VIEW_PANEL T"
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            If dt.Rows.Count > i Then
                j = IIf(IsDBNull(dt.Rows(i).Item("ALARM_STATUS")), "", dt.Rows(i).Item("ALARM_STATUS").ToString)
                If j = 1 Then
                    ShowAlarm = 1
                    AlarmMssg = dt.Rows(i).Item("ALARM_CURRENT").ToString
                Else
                    ShowAlarm = 0
                    AlarmMssg = "- -"
                End If
            End If
        End If

        mDataSet = Nothing
    End Function
    'Public ShowComm     As Long
    'Public ShowAlarmMeter     As Long
    Public Function ShowAlarmMeter() As Long
        Dim i As Long
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        strSQL =
        " select steqi.GET_MONITOR_ALARM_METER as Load " &
        " from dual "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            If dt.Rows.Count > i Then
                If (dt.Rows(i).Item("Load")) = "1" Then
                    ShowAlarmMeter = 1
                Else
                    ShowAlarmMeter = 0
                End If
            End If
        End If
        mDataSet = Nothing
    End Function

    Public Function ShowComm() As Long
        Dim i As Long
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable

        strSQL =
        " select steqi.GET_MONITOR_COMM as Comm " &
        " from dual "
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            If dt.Rows.Count > i Then
                If (dt.Rows(i).Item("Comm")) >= "1" Then
                    ShowComm = 1
                Else
                    ShowComm = 0
                End If
            End If
        End If
        mDataSet = Nothing
    End Function




    Private Sub tScanTime_Tick_1(sender As Object, e As EventArgs) Handles tScanTime.Tick
        Call InitialObject(ShowAlarm, AlarmMssg, ShowComm, ShowAlarmMeter)
    End Sub



    Private Sub btnAlarm_Click(sender As Object, e As EventArgs) Handles btnAlarm.Click
        frmScanAlarm.Close()
        frmScanAlarm.AlarmMsgCurrent = Me.txtAlarmMsg.Text
        frmScanAlarm.Show()
    End Sub
End Class
