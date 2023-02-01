Public Class ucReflesh

    Event OnClickReflesh(ByVal ucName As String)

#Region "uc Event"
    Private Sub ucClick()
        RaiseEvent OnClickReflesh(Me.Name)
    End Sub
#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.BackColor = Color.Transparent
    End Sub

    Private Sub ucReflesh_Resize(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ucClick()
    End Sub

    Private Sub Button1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseClick
        ucClick()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
