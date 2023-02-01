Imports System.Data

Public Class frmMnuType1
    Public FormScreenID As Long

    Private Sub frmMnuType1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        InitialForm(Me, lblTitleName.Text)
        UcStatus1.StartThread()
    End Sub

    Private Sub frmMnuType1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        UcStatus1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub UcClose1_OnClickClose() Handles UcClose1.OnClickClose
        Me.Close()
    End Sub

    Private Sub UcMinimize1_OnCilckMin() Handles UcMinimize1.OnCilckMin
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmMnuType1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub DrawImageBG()
        Dim bm As New Bitmap(UcMnu1.Width, UcMnu1.Height)

        ' Associate a Graphics object with the Bitmap
        Using gr As Graphics = Graphics.FromImage(bm)
            ' Define source and destination rectangles.
            Dim src_rect As New Rectangle(UcMnu1.Left, UcMnu1.Top, UcMnu1.Width, _
                UcMnu1.Height)
            Dim dst_rect As New Rectangle(0, 0, UcMnu1.Width, UcMnu1.Height)

            ' Copy that part of the image.

            gr.DrawImage(Me.BackgroundImage, dst_rect, src_rect, _
                GraphicsUnit.Pixel)
        End Using

        ' Display the result.
        UcMnu1.DrawBackgroundImage(bm)

        bm = Nothing

    End Sub
#Region "menu event"
    Private Sub UcMnu1_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMnu1.OnClickMnu
        If OpenForm(ucScreenID, "") Then
            PushForm(Me)
            'Me.ShowInTaskbar = False
            Me.Hide()
        End If
    End Sub

    Private Sub UcMnu2_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMnu2.OnClickMnu

    End Sub

    Private Sub UcMnu3_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMnu3.OnClickMnu

    End Sub

    Private Sub UcMnu4_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMnu4.OnClickMnu

    End Sub

    Private Sub UcMnu5_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMnu5.OnClickMnu

    End Sub

    Private Sub UcMnu6_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles UcMnu6.OnClickMnu

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
