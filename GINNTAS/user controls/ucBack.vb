Imports System.Windows.Forms
Imports System.Data
Public Class ucBack
    Public Event CloseButtonClick As EventHandler
    Private Sub ucBack_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        RaiseEvent CloseButtonClick(Me, New EventArgs)
    End Sub


End Class
