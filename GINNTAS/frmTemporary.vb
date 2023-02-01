Imports System.Data

Public Class frmTemporary
    Public FormScreenID As Long

    Private Sub frmTemporary_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UcStatus1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmTemporary_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        InitialForm(Me, lblTitleName.Text)
        UcStatus1.StartThread()
    End Sub

    Private Sub frmTemporary_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin() Handles UcMinimize1.OnCilckMin
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose() Handles UcClose1.OnClickClose
        Me.Close()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
