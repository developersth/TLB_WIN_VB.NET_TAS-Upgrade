Public Class popupNetworkStatus

    Private Sub popupNetworkStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Left = 100
        'Me.Top = 248
        'Me.Location = New Point(frmMMINetwork.pic1.Location.X + frmMMINetwork.xPicBG + frmMMINetwork.pic1.Size.Width, frmMMINetwork.pic1.Location.Y + frmMMINetwork.yPicBG + frmMMINetwork.pic1.Size.Height)
        If Me.Size.Width < lblName.Size.Width Then
            Size = New Size(lblName.Size.Width, Size.Height)
        End If
        lblName.Location = New Point(Size.Width / 2 - lblName.Size.Width / 2, lblName.Location.Y)

    End Sub
    Public Sub SetLocationPoint(pLocationY As Integer, pLocationX As Integer)

    End Sub


End Class