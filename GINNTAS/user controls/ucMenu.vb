Public Class ucMenu
    Private _picMouseHover As New PictureBox
    Private _picMouseLeave As New PictureBox
    Private _picIcon As New PictureBox
    Private _menuFont As Font

    Property MenuPicMouseHover As Bitmap
        Get
            Return _picMouseHover.Image
        End Get
        Set(ByVal value As Bitmap)
            _picMouseHover.Size = PictureBox1.Size
            _picMouseHover.Image = value
        End Set

    End Property

    Property MenuPicMouseLeave As Bitmap
        Get
            Return _picMouseLeave.Image
        End Get
        Set(ByVal value As Bitmap)
            _picMouseLeave.Image = value
            PictureBox1.Image = _picMouseLeave.Image
        End Set

    End Property

    Property MenuIcon As Bitmap
        Get
            Return _picIcon.Image
        End Get
        Set(ByVal value As Bitmap)
            '_picIcon.Size = PictureBox2.Size
            _picIcon.Image = value
            PictureBox2.Image = _picIcon.Image
        End Set
    End Property

    Property MenuText As String
        Get
            Return Label1.Text
        End Get
        Set(ByVal value As String)
            Label1.Text = value
        End Set
    End Property

    Property MenuFont As Font
        Get
            Return Label1.Font
        End Get
        Set(ByVal value As Font)
            Label1.Font = value
        End Set
    End Property

    Property MenuForeColor As Color
        Get
            Return Label1.ForeColor
        End Get
        Set(ByVal value As Color)
            Label1.ForeColor = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'Dim p As Point
        'p.X = 0
        'p.Y = 0
        'PictureBox1.Location = p

        'PictureBox1.Width = Me.Width
        'PictureBox1.Height = Me.Height
        InitializeObj()
        Me.BackColor = Color.Transparent
    End Sub

    Private Sub InitializeObj()
        Dim p As Point
        p.X = 0
        p.Y = 0
        PictureBox1.Location = p

        PictureBox1.Width = Me.Width
        PictureBox1.Height = Me.Height - Label1.Height

        PictureBox2.Width = PictureBox1.Width / 2.8
        PictureBox2.Height = PictureBox1.Height / 1.95
        PictureBox1.Image = _picMouseLeave.Image
        p.Y = (PictureBox1.Height / 2) - (PictureBox2.Height / 2)
        p.X = ((PictureBox1.Width / 2) - (PictureBox2.Width / 2)) - 12.5
        PictureBox2.Location = p

        With Label1
            .Left = PictureBox1.Left + 4
            .Top = PictureBox1.Top + Me.Height - .Height - 4
        End With
    End Sub

    Private Sub ucMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        InitializeObj()
    End Sub

    Private Sub ucMenu_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'PictureBox1.Width = Me.Width
        'PictureBox1.Height = Me.Height
        InitializeObj()
        'With Label1
        '    .Left = PictureBox1.Left + 10
        '    .Top = PictureBox1.Top + Me.Height - .Height - 4
        'End With
    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Image = _picMouseHover.Image
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = _picMouseLeave.Image
    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        PictureBox1.Image = _picMouseHover.Image
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox1.Image = _picMouseLeave.Image
    End Sub


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
