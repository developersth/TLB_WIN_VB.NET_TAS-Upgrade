Imports System.Threading

Public Class ucStatus
    Dim thr As Thread
    Dim bExit As Boolean = False
    Dim DB_status As Boolean

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
                    SetControlText(lblUser, "User Name : " & mUserName & " User Group : " & mUserGroupName)
                End If

                'If lblServer.Text.IndexOf(Oradb.ConnectServiceName) Then
                '    SetControlText(lblServer, Oradb.ConnectServiceName)
                'End If
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

    Private Sub ucStatus_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        bExit = True
        'thr.Abort()
    End Sub

    Private Sub ucStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Me.BackColor = Color.Transparent
        'Me.Width = 366
        'Me.Height = 58

        picDB.Left = Me.Width - picDB.Width - 2
        picDB.Top = Me.Height - picDB.Height - 2

        lblDateTime.Left = picDB.Left - lblDateTime.Width - 2
        lblDateTime.Top = Me.Height - lblDateTime.Height

        lblUser.Left = Me.Width - lblUser.Width - 4
        lblUser.Top = lblDateTime.Top - lblUser.Height - 2
    End Sub

    Private Sub ucStatus_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        InitializeObj()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
