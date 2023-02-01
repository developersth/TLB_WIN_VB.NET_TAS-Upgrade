Public Class ucMnuText
    Private _picMouseHover As New PictureBox
    Private _picMouseLeave As New PictureBox

    Const _OffsetLeftRight = 14
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
        End Set
    End Property
    Property MenuImage As Image
        Get
            Return picMnuBorder.Image
        End Get
        Set(ByVal value As Image)
            picMnuBorder.Image = value
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
    Property MenuBackColor As Color
        Get
            Return lblMenuText.BackColor
        End Get
        Set(ByVal value As Color)
            lblMenuText.BackColor = value
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
        If P_CHECK_SCREEN_AUTHORIZE(mUserName, Me._MenuScreenID, Me._MenuAuthorizeID) Then
            RaiseEvent OnClickMnuText(Me.Name, Me._MenuScreenID)
        End If
    End Sub
#End Region

#Region "ucMnu Method"
    Public Sub DrawBackgroundImage(ByVal bm As Bitmap)

        '_picMouseLeave.BackgroundImage = bm

        Me.BackgroundImage = bm
        picMnuBorder.BackgroundImage = bm
        'picMnuBorder.BackgroundImage = _picMouseLeave.BackgroundImage
    End Sub

    Private Sub DrawBackgroungLabel()
        'Dim bm As New Bitmap(picMnuBorder.Width, picMnuBorder.Height)

        ' Associate a Graphics object with the Bitmap
        'Using gr As Graphics = Graphics.FromImage(bm)
        '    ' Define source and destination rectangles.
        '    Dim src_rect As New Rectangle(0, 0, lblMenuText.Width, lblMenuText.Height + 6)
        '    Dim dst_rect As New Rectangle(0, 0, lblMenuText.Width, lblMenuText.Height)
        '    ' Copy that part of the image.
        '    gr.DrawImage(picMnuBorder.Image, dst_rect, src_rect, GraphicsUnit.Point)

        'End Using
        
        Dim g As Graphics = Me.picMnuBorder.CreateGraphics

        Dim bm As New Bitmap(picMnuBorder.Width, picMnuBorder.Height)

        g = Graphics.FromImage(bm)

        Dim src_rect As New Rectangle(lblMenuText.Left, lblMenuText.Top, picMnuBorder.Width, picMnuBorder.Height)
        Dim dst_rect As New Rectangle(0, 0, picMnuBorder.Width, picMnuBorder.Height)

        'g.DrawImage(picMnuBorder.Image, dst_rect, src_rect, GraphicsUnit.Pixel)

        ' Display the result.
        lblMenuText.Image = Nothing
        lblMenuText.Image = bm

        bm = Nothing
        g.Dispose()
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

        DrawBackgroungLabel()
    End Sub

    Private Sub DrawTextMnu(ByVal bDraw As Boolean)

        If bDraw Then
            Try
                Dim formGraphics As System.Drawing.Graphics = Me.CreateGraphics()
                Dim drawFont As New System.Drawing.Font(lblMenuText.Font, lblMenuText.Font.Size)
                'Dim drawFont As New System.Drawing.Font
                Dim drawBrush As New  _
                   System.Drawing.SolidBrush(lblMenuText.ForeColor)
                Dim x As Single = 10
                Dim y As Single = 10
                Dim drawFormat As New System.Drawing.StringFormat

                Dim img As New Bitmap(picMnuBorder.Width, picMnuBorder.Height)
                formGraphics = Graphics.FromImage(img)


                formGraphics.DrawString(lblMenuText.Text, drawFont, drawBrush, _
                                        x, y, drawFormat)

                picMnuBorder.Image = img

                img = Nothing
                drawFont.Dispose()
                drawBrush.Dispose()
                formGraphics.Dispose()
            Catch ex As Exception

            End Try
        End If
        lblMenuText.Visible = Not bDraw
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'Me.Width = 136
        'Me.Height = 136
        TextAlign = _TextAlign.Left
        InitializeObj()

        'TextAlign = _TextAlign.Left
        SetMenuTextAlign()
        _MenuAuthorizeID = 0
        _MenuScreenID = 0
    End Sub

    Private Sub InitializeObj()
        Me.Visible = False

        picMnuBorder.Size = Me.Size
        picMnuBorder.Left = 0
        picMnuBorder.Top = 0
        With _picMouseHover
            .Size = picMnuBorder.Size
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.mnubg_h
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Image = My.Resources.mnubg_h
        End With

        With _picMouseLeave
            .Size = picMnuBorder.Size
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.mnubg_n
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Image = My.Resources.mnubg_n
        End With

        Me.Visible = True
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
        'DrawBackgroungLabel()
    End Sub

    Private Sub picMnuBorder_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMnuBorder.MouseHover
        picMnuBorder.Image = _picMouseHover.Image
    End Sub

    Private Sub picMnuBorder_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMnuBorder.MouseLeave
        picMnuBorder.Image = _picMouseLeave.Image
    End Sub

    Private Sub lblMenuText_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMenuText.MouseHover
        picMnuBorder.Image = _picMouseHover.Image
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub lblMenuText_Click(sender As System.Object, e As System.EventArgs) Handles lblMenuText.Click
        ucClick()
    End Sub
End Class
