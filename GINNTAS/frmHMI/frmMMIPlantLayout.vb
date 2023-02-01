
Imports Oracle.DataAccess.Client
Imports System.Data





Public Class frmMMIPlantLayout
    Public FormScreenID As Long
    Dim frm_work As Integer = 0

    Dim txtLoadNo As New Collection
    Dim txtVechicleCardNo As New Collection
    Dim txtVechicle As New Collection
    Dim txtDriver As New Collection
    Dim UcProgressOverView As New Collection
    Dim UcMMIview As New Collection
    Dim UcMMIOverView As New Collection

    Dim sumAdvice = 0
    Dim sumCapacity = 0
    Const MAX_BAY = 4
    Const MAX_ISLAND = 2
    Dim checkIniPrgress(MAX_BAY - 1) As Boolean

    Private Sub frmMMIPlantLayout_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    'Private Sub UcMinimize1_OnCilckMin() Handles UcMinimize1.OnCilckMin
    '    Me.WindowState = FormWindowState.Minimized
    'End Sub

    'Private Sub UcClose1_OnClickClose() Handles UcClose1.OnClickClose
    '    Me.Close()
    'End Sub

    Private Sub frmMMIPlantLayout_main_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub frmMMIPlantLayout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        resolution(Me, 1)
        'picPlantLayout.BackgroundImage = ""
        'picPlantLayout.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
    Private Sub UcHeader1_CloseButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.CloseButtonClick
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UcHeader1_MinimizeButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.MinimizeButtonClick
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub UcBack1_Click(sender As Object, e As EventArgs) Handles UcBack1.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub UcBack1_MouseHover(sender As Object, e As EventArgs) Handles UcBack1.MouseHover
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("Back1")
    End Sub

    Private Sub UcBack1_MouseLeave(sender As Object, e As EventArgs) Handles UcBack1.MouseLeave
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("back")
    End Sub

    Private Sub UcBack1_Load(sender As System.Object, e As System.EventArgs) Handles UcBack1.Load

    End Sub
End Class
