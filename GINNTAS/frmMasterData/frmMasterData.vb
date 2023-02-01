Imports System.Data

Public Class frmMasterData
    Public FormScreenID As Long

    Private Sub frmMasterData_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UcStatus1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmMasterData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Visible = False
        SetScreenResulotion()
        CheckFormResize(Me)
        InitialForm(Me, lblTitleName.Text)
        UcStatus1.StartThread()
        Me.Visible = True
    End Sub

    Private Sub frmMasterData_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin() Handles UcMinimize1.OnCilckMin
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose() Handles UcClose1.OnClickClose
        Me.Close()
    End Sub
#Region "menu event"
    Private Sub UcMnu1_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMnu1.OnClickMnu
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            'Me.ShowInTaskbar = False
            Me.Hide()
        End If
    End Sub

    Private Sub UcMnu2_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMnu2.OnClickMnu
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            'Me.ShowInTaskbar = False
            Me.Hide()
        End If
    End Sub

    Private Sub UcMnu3_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMnu3.OnClickMnu
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            'Me.ShowInTaskbar = False
            Me.Hide()
        End If
    End Sub

    Private Sub UcMnu4_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMnu4.OnClickMnu
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            'Me.ShowInTaskbar = False
            Me.Hide()
        End If
    End Sub

    Private Sub UcMnu5_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMnu5.OnClickMnu
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            'Me.ShowInTaskbar = False
            Me.Hide()
        End If
    End Sub

    Private Sub UcMnu6_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64)

    End Sub

    Private Sub UcMnu7_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64)

    End Sub

    Private Sub UcMnu8_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64)

    End Sub
#End Region
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class
