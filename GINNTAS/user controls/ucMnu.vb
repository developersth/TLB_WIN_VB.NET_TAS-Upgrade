Public Class ucMnu
    Private _picMouseHover As New PictureBox
    Private _picMouseLeave As New PictureBox
    Private _picIco As New PictureBox
    Private _menuFont As Font

    Const _OffsetLeftRight = 4
    Const _OffsetTop = 8

    Event OnClickMnu(ByVal ucName As String, ByVal ucScreenID As Long)

    Enum _TextAlign
        None = 0
        Left = 1
        Center = 2
        Right = 3
    End Enum

    Dim TextAlign As _TextAlign
    Dim TextLocation As New Point
#Region "ucMnu Property"
    'Property MenuPicMouseHover As Bitmap
    '    Get
    '        Return _picMouseHover.Image
    '    End Get
    '    Set(ByVal value As Bitmap)
    '        _picMouseHover.Size = picMnuBorder.Size
    '        _picMouseHover.Image = value
    '    End Set

    'End Property

    'Property MenuPicMouseLeave As Bitmap
    '    Get
    '        Return _picMouseLeave.Image
    '    End Get
    '    Set(ByVal value As Bitmap)
    '        _picMouseLeave.Size = picMnuBorder.Size
    '        _picMouseLeave.Image = value
    '        'PictureBox1.Image = _picMouseLeave.Image
    '        'picMnu.BackgroundImage = Nothing
    '    End Set

    'End Property

    Property MenuIcon As Bitmap
        Get
            Return picMnuBorder.Image
        End Get
        Set(ByVal value As Bitmap)
            picMnuBorder.Image = value
        End Set
    End Property

    Property MenuText As String
        Get
            Return lblMenuText.Text
        End Get
        Set(ByVal value As String)
            lblMenuText.Text = value
            SetMenuTextAlign()
            DrawTextMnu(False)
        End Set
    End Property

    Property MenuTextAlign As _TextAlign
        Get
            Return TextAlign
        End Get
        Set(ByVal value As _TextAlign)
            TextAlign = value
            SetMenuTextAlign()
            DrawTextMnu(False)
        End Set
    End Property

    Property MenuTextLocation As Point
        Get
            Return TextLocation
        End Get
        Set(ByVal value As Point)
            TextLocation = value
            SetMenuTextAlign()
            DrawTextMnu(False)
        End Set
    End Property

    Property MenuFont As Font
        Get
            Return lblMenuText.Font
        End Get
        Set(ByVal value As Font)
            lblMenuText.Font = value
            SetMenuTextAlign()
            DrawTextMnu(False)
        End Set
    End Property

    Property MenuForeColor As Color
        Get
            Return lblMenuText.ForeColor
        End Get
        Set(ByVal value As Color)
            lblMenuText.ForeColor = value
            DrawTextMnu(False)
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
        _picIco.Dispose()
        _menuFont.Dispose()
    End Sub

    Private Sub ucClick()
        If P_CHECK_SCREEN_AUTHORIZE(mUserName, Me._MenuScreenID, Me._MenuAuthorizeID) Then
            RaiseEvent OnClickMnu(lblMenuText.Text, Me._MenuScreenID)
        End If
    End Sub
#End Region

#Region "ucMnu Method"
    Public Sub DrawBackgroundImage(ByVal bm As Bitmap)

        _picMouseLeave.BackgroundImage = bm

        Me.BackgroundImage = _picMouseLeave.BackgroundImage
        picMnuBorder.BackgroundImage = _picMouseLeave.BackgroundImage
    End Sub

#End Region
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Width = 136
        Me.Height = 136

        InitializeObj()

        TextAlign = _TextAlign.Center
        SetMenuTextAlign()
        'DrawTextMnu(False)
        _MenuAuthorizeID = 0
        _MenuScreenID = 0
    End Sub

    Private Sub InitializeObj()
        Me.Visible = False

        With _picMouseHover
            .Size = picMnuBorder.Size
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.mnu
        End With

        With _picMouseLeave
            .Size = picMnuBorder.Size
            .BackgroundImageLayout = ImageLayout.Stretch
            '.BackgroundImage = My.Resources.mnu_h
        End With
        SetMenuTextAlign()

        Me.Visible = True
    End Sub

    Private Sub DrawImageBG()
        Dim bm As New Bitmap(_picIco.Width, _picIco.Height)

        ' Associate a Graphics object with the Bitmap
        Using gr As Graphics = Graphics.FromImage(bm)
            ' Define source and destination rectangles.
            Dim src_rect As New Rectangle(_picIco.Left, _picIco.Top, _picIco.Width, _
                _picIco.Height)
            Dim dst_rect As New Rectangle(0, 0, _picIco.Width, _picIco.Height)

            ' Copy that part of the image.

            gr.DrawImage(_picMouseHover.Image, dst_rect, src_rect, _
                GraphicsUnit.Pixel)
        End Using

        ' Display the result.
        _picIco.BackgroundImage = bm

        bm = Nothing

    End Sub

    Private Sub ucMnu_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'DispostObj()
    End Sub

    Private Sub ucMnu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'InitializeObj()
    End Sub

    Private Sub ucMnu_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        SetMenuTextAlign()
    End Sub

    Private Sub picMnuBorder_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles picMnuBorder.MouseHover
        'Me.BackgroundImage = _picMouseHover.Image
        picMnuBorder.BackgroundImage = My.Resources.mnu '_picMouseHover.BackgroundImage
    End Sub

    Private Sub picMnuBorder_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picMnuBorder.MouseLeave
        'Me.BackgroundImage = _picMouseLeave.Image
        picMnuBorder.BackgroundImage = _picMouseLeave.BackgroundImage
    End Sub

    Private Sub picIcon_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        'Me.BackgroundImage = _picMouseHover.Image
        picMnuBorder.BackgroundImage = My.Resources.mnu ' _picMouseHover.BackgroundImage
    End Sub

    Private Sub picIcon_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblMenuText_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMenuText.MouseHover
        'Me.BackgroundImage = _picMouseHover.Image
        picMnuBorder.BackgroundImage = My.Resources.mnu ' _picMouseHover.BackgroundImage
    End Sub

    Private Sub ucMnu_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseLeave
        'Me.BackgroundImage = _picMouseLeave.Image
        picMnuBorder.BackgroundImage = _picMouseLeave.BackgroundImage
    End Sub

    Private Sub SetMenuTextAlign()
        With lblMenuText
            Select Case TextAlign
                Case _TextAlign.None
                    lblMenuText.Location = TextLocation
                Case _TextAlign.Left
                    .Left = picMnuBorder.Left + _OffsetLeftRight
                    .Top = picMnuBorder.Height - .Height - _OffsetTop
                Case _TextAlign.Center
                    .Left = ((picMnuBorder.Width / 2) - (.Width / 2)) + picMnuBorder.Left '- _OffsetLeftRight
                    .Top = picMnuBorder.Height - .Height - _OffsetTop
                Case _TextAlign.Right
                    .Left = picMnuBorder.Width - .Width - _OffsetLeftRight
                    .Top = picMnuBorder.Height - .Height - _OffsetTop
            End Select
        End With
    End Sub

    Private Sub lblMenuText_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblMenuText.MouseClick
        ucClick()
    End Sub

    Private Sub picIcon_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ucClick()
    End Sub

    Private Sub picMnuBorder_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picMnuBorder.MouseClick
        ucClick()
    End Sub

    Private Sub DrawTextMnu(ByVal bDraw As Boolean)

        If bDraw Then
            Dim drawFont As New System.Drawing.Font(lblMenuText.Font, lblMenuText.Font.Size)
            Dim drawFormat As New System.Drawing.StringFormat

            Dim TextBitmap As New Bitmap(picMnuBorder.Width, picMnuBorder.Height)
            Dim drawBrush As New  _
               System.Drawing.SolidBrush(lblMenuText.ForeColor)

            Try
                Using Graphic = Graphics.FromImage(TextBitmap)

                    Graphic.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                    Graphic.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
                    Graphic.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                    Graphic.DrawString(lblMenuText.Text, drawFont, drawBrush, 10, 10)
                End Using
            Catch ex As Exception

            End Try

            drawFont.Dispose()
            drawBrush.Dispose()
        End If
        lblMenuText.Visible = Not bDraw
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
