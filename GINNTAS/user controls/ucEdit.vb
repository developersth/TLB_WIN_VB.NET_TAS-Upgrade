Public Class ucEdit

    Event OnClickEdit(ByVal ucName As String, ByRef ucScreeenID As Long)
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
        If P_CHECK_SCREEN_AUTHORIZE(mUserName, Me._MenuScreenID, Me._MenuAuthorizeID) Then
            RaiseEvent OnClickEdit(Me.Name, Me._MenuScreenID)
        End If
    End Sub
#End Region
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.BackColor = Color.Transparent
    End Sub

    Private Sub ucEdit_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

    End Sub

    Private Sub ucEdit_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick
        ucClick()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Button1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseClick
        ucClick()
    End Sub
End Class
