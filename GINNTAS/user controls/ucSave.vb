Public Class ucSave

    Event OnClickSave(ByVal ucName As String)
#Region "uc Property"
    Private _MenuScreenID As Long
    Property MenuScreenID As Long
        Get
            Return _MenuScreenID
        End Get
        Set(ByVal value As Long)
            _MenuScreenID = value
        End Set
    End Property

    Private _MenuAuthorizeID As String
    Public Property MenuAuthorizeID() As String
        Get
            Return _MenuAuthorizeID
        End Get
        Set(ByVal value As String)
            _MenuAuthorizeID = value
        End Set
    End Property

#End Region

#Region "uc Event"
    Private Sub ucClick()
            RaiseEvent OnClickSave(Me.Name)
    End Sub
#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.BackColor = Color.Transparent
    End Sub

    Private Sub ucSave_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

    End Sub

    Private Sub ucSave_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick
        ucClick()
    End Sub

    Private Sub Button1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseClick
        ucClick()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
