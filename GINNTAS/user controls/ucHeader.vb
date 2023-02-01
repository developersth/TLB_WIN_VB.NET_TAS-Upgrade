Imports System.Windows.Forms
Imports System.Data
Public Class ucHeader

    Dim WindowState As FormWindowState
    Public Event CloseButtonClick As EventHandler
    Public Event MinimizeButtonClick As EventHandler
    Property MenuText As String
        Get
            Return lblTitleName.Text
        End Get
        Set(ByVal value As String)
            lblTitleName.Text = value
        End Set
    End Property

    Private Sub UcClose1_OnClickClose() Handles UcClose1.OnClickClose
        RaiseEvent CloseButtonClick(Me, New EventArgs)
    End Sub

    Private Sub UcMinimize1_OnCilckMin() Handles UcMinimize1.OnCilckMin
        RaiseEvent MinimizeButtonClick(Me, New EventArgs)
    End Sub





   

End Class
