Public Class ucMenutxt_Sub
    Private _picMouseHover As New PictureBox
    Private _picMouseLeave As New PictureBox

    Const _OffsetLeftRight = 18
    Const _OffsetTop = 2.4

    Enum _TextAlign
        None = 0
        Left = 1
        Center = 2
        Right = 3
    End Enum

    Dim TextAlign As _TextAlign
    Dim TextLocation As New Point

    Event OnClickMnuText(ByVal ucName As String, ByVal ucScreenID As Long)

#Region "uc Property"

    Property MenuText As String
        Get
            Return lblMenuText.Text
        End Get
        Set(ByVal value As String)
            lblMenuText.Text = value
            SetMenuTextAlign()
        End Set
    End Property

    Property MenuTextAlign As _TextAlign
        Get
            Return TextAlign
        End Get
        Set(ByVal value As _TextAlign)
            TextAlign = value
            SetMenuTextAlign()
        End Set
    End Property

    Property MenuTextLocation As Point
        Get
            Return lblMenuText.Location
        End Get
        Set(ByVal value As Point)
            TextLocation = value
            SetMenuTextAlign()
        End Set
    End Property

    Property MenuFont As Font
        Get
            Return lblMenuText.Font
        End Get
        Set(ByVal value As Font)
            lblMenuText.Font = value
            SetMenuTextAlign()
        End Set
    End Property

    Property MenuForeColor As Color
        Get
            Return lblMenuText.ForeColor
        End Get
        Set(ByVal value As Color)
            lblMenuText.ForeColor = value
        End Set
    End Property

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

#Region "ucMnu Events"
    Private Sub DispostObj()
        _picMouseHover.Dispose()
        _picMouseLeave.Dispose()
    End Sub

    Private Sub ucClick()
        'If CHECK_AUTHORIZE_SCREEN(mUserName, Me._MenuScreenID, Me._MenuAuthorizeID) Then
        RaiseEvent OnClickMnuText(lblMenuText.Text, Me._MenuScreenID)
        'End If
    End Sub
#End Region

#Region "ucMnu Method"
    Public Sub DrawBackgroundImage(ByVal bm As Bitmap)
        Me.BackgroundImage = bm
        'picMnuBorder.BackgroundImage = bm
    End Sub

#End Region

    Private Sub SetMenuTextAlign()
        With lblMenuText
            Select Case TextAlign
                Case _TextAlign.None
                    lblMenuText.Location = TextLocation
                Case _TextAlign.Left
                    .Left = _OffsetLeftRight
                    .Top = (Me.Height / 2) - (.Height / 2)
                Case _TextAlign.Center
                    .Left = (Me.Width / 2) - (.Width / 2)  '- _OffsetLeftRight
                    .Top = (Me.Height / 2) - (.Height / 2)
                Case _TextAlign.Right
                    .Left = (Me.Width - .Width) - _OffsetLeftRight
                    .Top = (Me.Height / 2) - (.Height / 2)
            End Select
        End With
        InheritObject()
    End Sub

    Public Sub New()
        InitializeComponent()
        'Me.Width = 136
        'Me.Height = 136
        TextAlign = _TextAlign.Left
        InitializeObj()
        SetMenuTextAlign()
    End Sub

    Private Sub InitializeObj()
        'Me.Visible = False

        With _picMouseHover
            .Size = Me.Size
            .BackgroundImage = My.Resources.bg_menu_sub_a
            .BackgroundImageLayout = ImageLayout.Stretch
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Image = My.Resources.bg_menu_sub_a
        End With

        With _picMouseLeave
            .Size = Me.Size
            .BackgroundImage = My.Resources.BGMenu_N
            .BackgroundImageLayout = ImageLayout.Stretch
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Image = My.Resources.BGMenu_N
        End With

        'Me.Visible = True
        InheritObject()
    End Sub

    Private Sub ucMnuText_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'DispostObj()
    End Sub

    Private Sub ucMnuText_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetMenuTextAlign()
    End Sub

    Private Sub ucMnuText_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        InitializeObj()
        SetMenuTextAlign()
    End Sub

    Private Sub ucMenutxt_Main_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Me.BackgroundImage = _picMouseHover.Image
        'Me.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
    End Sub

    Private Sub ucMenutxt_Main_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.BackgroundImage = _picMouseLeave.Image
        'Me.BorderStyle = Windows.Forms.BorderStyle.None
        'Button1.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub lblMenuText_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMenuText.MouseHover
        Me.BackgroundImage = _picMouseHover.Image
        'Me.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
    End Sub

    Private Sub lblMenuText_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblMenuText.MouseClick
        ucClick()
    End Sub

    Private Sub ucMenutxt_Sub_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        ucClick()
    End Sub

    Private Sub InheritObject()
        Button1.Text = lblMenuText.Text
        Button1.TextAlign = lblMenuText.TextAlign
        Button1.Font = lblMenuText.Font
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        ucClick()
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        'Button1.FlatStyle = FlatStyle.Standard
        Button1.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        'Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
    End Sub
End Class
