Imports System.Drawing

Public Class ucMenutxtMain
    Private _picMouseHover As New PictureBox
    Private _picMouseLeave As New PictureBox

    Const _OffsetLeftRight = 130
    Const _OffsetTop = 2.4

#Region "Enum"
    Enum _TextAlign
        None = 0
        Left = 1
        Center = 2
        Right = 3
    End Enum
    Public Enum _MenuShape As Integer
        Ellipse = 0
        Rectangle = 1
        TriangleUp = 2
        TriangleDown = 3
        TriangleLeft = 4
        TriangleRight = 5
    End Enum
#End Region
    Dim TextAlign As _TextAlign
    Dim TextLocation As New Point

    Event OnClickMnuText(ByVal ucName As String, ByVal ucScreenID As Long)
    Event OnMouseHoverMnuText()
    Event OnMouseLeaveMnuText()

#Region "uc Property"
    Dim mMenuShape As _MenuShape
    Property MenuShape As CButtonLib.CButton.eShape
        Get
            mMenuShape = CType(CButton1.Shape, _MenuShape)
            Return CButton1.Shape
        End Get
        Set(ByVal value As CButtonLib.CButton.eShape)
            mMenuShape = value
            CButton1.Shape = CType(value, CButtonLib.CButton.eShape)
        End Set
    End Property

    Property MenuCursor As Cursor
        Get
            'CButton1.Cursor = Me.Cursor
            Return Me.Cursor
        End Get
        Set(ByVal value As Cursor)
            Me.Cursor = value
            'CButton1.Cursor = Me.Cursor
        End Set
    End Property

    'Dim _MenuIcon As New Bitmap(5, 5)
    Property MenuIcon As Bitmap
        Get
            picIconMenu.Image = CButton1.SideImage
            Return picIconMenu.Image
        End Get
        Set(ByVal value As Bitmap)
            picIconMenu.Image = value
            CButton1.SideImage = picIconMenu.Image
            InitializeObj()
            'InheritObject()
        End Set
    End Property

    Property MenuIconSize As Size
        Get
            picIconMenu.Size = CButton1.SideImageSize
            Return picIconMenu.Size
        End Get
        Set(ByVal value As Size)
            picIconMenu.Size = value
            CButton1.SideImageSize = picIconMenu.Size
        End Set
    End Property

    Property MenuText As String
        Get
            'lblMenuText.Text = CButton1.Text
            Return lblMenuText.Text
        End Get
        Set(ByVal value As String)
            lblMenuText.Text = value
            CButton1.Text = lblMenuText.Text
        End Set
    End Property

    Property MenuTextMargin As System.Windows.Forms.Padding
        Get
            'lblMenuText.Padding = CButton1.TextMargin
            Return lblMenuText.Padding
        End Get
        Set(ByVal value As System.Windows.Forms.Padding)
            lblMenuText.Padding = value
            CButton1.TextMargin = lblMenuText.Padding
        End Set
    End Property

    Property MenuTextAlign As ContentAlignment '_TextAlign
        Get
            'lblMenuText.TextAlign = CButton1.TextAlign
            Return lblMenuText.TextAlign
        End Get
        Set(ByVal value As ContentAlignment)
            lblMenuText.TextAlign = value
            CButton1.TextAlign = lblMenuText.TextAlign
        End Set
    End Property

    'Property MenuTextLocation As Point
    '    Get
    '        Return lblMenuText.Location
    '    End Get
    '    Set(ByVal value As Point)
    '        TextLocation = value
    '        SetMenuTextAlign()
    '    End Set
    'End Property

    Property MenuFont As Font
        Get
            'lblMenuText.Font = CButton1.Font
            Return lblMenuText.Font
        End Get
        Set(ByVal value As Font)
            lblMenuText.Font = value
            CButton1.Font = lblMenuText.Font
        End Set
    End Property

    Property MenuForeColor As Color
        Get
            'lblMenuText.ForeColor = CButton1.ForeColor
            Return lblMenuText.ForeColor
        End Get
        Set(ByVal value As Color)
            lblMenuText.ForeColor = value
            CButton1.ForeColor = lblMenuText.ForeColor
        End Set
    End Property

    Dim mMenuTextShadowColor As Color
    Property MenuTextShadowColor As Color
        Get
            'mMenuTextShadowColor = CButton1.TextShadow
            Return mMenuTextShadowColor
        End Get
        Set(ByVal value As Color)
            mMenuTextShadowColor = value
            CButton1.TextShadow = mMenuTextShadowColor
        End Set
    End Property

    Dim mMenuTextShadowShow As Boolean
    Property MenuTextShadowShow As Boolean
        Get
            'mMenuTextShadowShow = CButton1.TextShadowShow
            Return mMenuTextShadowShow
        End Get
        Set(ByVal value As Boolean)
            mMenuTextShadowShow = value
            CButton1.TextShadowShow = mMenuTextShadowShow
        End Set
    End Property

    Private _MenuScreenID As Long = 0
    Property MenuScreenID As Long
        Get
            Return _MenuScreenID
        End Get
        Set(ByVal value As Long)
            _MenuScreenID = value
        End Set
    End Property

    Private _MenuAuthorizeID As Long = 0
    Public Property MenuAuthorizeID() As Long
        Get
            Return _MenuAuthorizeID
        End Get
        Set(ByVal value As Long)
            _MenuAuthorizeID = value
        End Set
    End Property

    Dim mMenuCorners As Integer
    Public Property MenuCorners As Integer
        Get
            'mMenuCorners = CButton1.Corners.All
            Return mMenuCorners
        End Get
        Set(ByVal value As Integer)
            mMenuCorners = value
            CButton1.Corners.All = mMenuCorners
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
            RaiseEvent OnClickMnuText(Me.CButton1.Text, Me._MenuScreenID)
        End If
    End Sub
#End Region

#Region "ucMnu Method"
    Public Sub DrawBackgroundImage(ByVal bm As Bitmap)
        Me.BackgroundImage = bm
        picMnuBorder.BackgroundImage = bm
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

        g.DrawImage(picMnuBorder.Image, dst_rect, src_rect, GraphicsUnit.Pixel)

        ' Display the result.
        lblMenuText.Image = Nothing
        lblMenuText.Image = bm

        bm = Nothing
        g.Dispose()
    End Sub

    Public Sub ShowMouseHover()
        CButton1.TextShadowShow = True
        CButton1.FillType = CButtonLib.CButton.eFillType.Solid
        CButton1.BorderShow = True

        'Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
    End Sub

    Public Sub ShowMouseLeave()
        CButton1.TextShadowShow = False
        CButton1.FillType = CButtonLib.CButton.eFillType.GradientLinear

        'CButton1.BorderShow = False
        'Me.BorderStyle = Windows.Forms.BorderStyle.None
    End Sub
#End Region

    Private Sub SetMenuTextAlign(ByVal pContentAlignment As ContentAlignment)
        lblMenuText.TextAlign = pContentAlignment

        'DrawBackgroungLabel()
        InheritObject()
    End Sub

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

        'DrawBackgroungLabel()
        InheritObject()
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

                formGraphics.DrawString(lblMenuText.Text, drawFont, drawBrush, x, y, drawFormat)

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
        InitializeComponent()
        'Me.Width = 136
        'Me.Height = 136
        Dim vFont As New Font(Me.Font.FontFamily, 18, FontStyle.Bold)
        TextAlign = _TextAlign.Left
        'CButton1.Text = "Default MenuTxt"

        'CButton1.Font = vFont
        Me.BackColor = Color.Transparent
        InitializeObj()
        'SetMenuTextAlign()
    End Sub

    Private Sub InitializeObj()
        Me.Visible = False

        'picMnuBorder.Size = Me.Size
        'picMnuBorder.BackgroundImageLayout = ImageLayout.Stretch
        'picMnuBorder.Left = 0
        'picMnuBorder.Top = 0
        'With _picMouseHover
        '    .Size = picMnuBorder.Size
        '    .BackgroundImage = My.Resources.BGMenu1
        '    .BackgroundImageLayout = ImageLayout.Stretch
        '    .SizeMode = PictureBoxSizeMode.StretchImage
        '    .Image = My.Resources.BGMenu1
        'End With

        'With _picMouseLeave
        '    .Size = picMnuBorder.Size
        '    '.BackgroundImage = Color.Transparent
        '    .BackgroundImageLayout = ImageLayout.Stretch
        '    .SizeMode = PictureBoxSizeMode.StretchImage
        '    '.Image = My.Resources._01_NA
        'End With

        Dim vSize As Size
        Dim vPad As Padding
        vSize.Width = Me.Width * 0.10465
        vSize.Height = Me.Height * 0.50704
        CButton1.SideImageSize = vSize
        MenuTextShadowColor = CButton1.TextShadow
        vPad = CButton1.TextMargin
        vPad.Left = vSize.Width + 12
        CButton1.TextMargin = vPad

        ShowMouseLeave()
        Me.Visible = True
    End Sub

    Private Sub ucMnuTextMain_Disposed(ByVal sender As Object, ByVal e As System.EventArgs)
        'DispostObj()
    End Sub

    Private Sub ucMnuTextMain_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        'SetMenuTextAlign()
    End Sub

    Private Sub ucMnuTextMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs)
        InitializeObj()
        'SetMenuTextAlign()
    End Sub

    Private Sub picMnuBorder_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMnuBorder.MouseHover

    End Sub

    Private Sub picMnuBorder_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMnuBorder.MouseLeave

    End Sub

    Private Sub lblMenuText_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'picMnuBorder.Image = _picMouseHover.Image
    End Sub

    Private Sub picIconMenu_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        'picMnuBorder.Image = _picMouseHover.Image
    End Sub

    Private Sub InheritObject()
        'CButton1.Text = lblMenuText.Text
        'CButton1.TextAlign = lblMenuText.TextAlign
        'CButton1.Font = lblMenuText.Font
        'CButton1.SideImage = picIconMenu.Image
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub CButton1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CButton1.MouseClick
        ucClick()
    End Sub

    Private Sub CButton1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CButton1.MouseHover
        RaiseEvent OnMouseHoverMnuText()
        ShowMouseHover()
    End Sub

    Private Sub CButton1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CButton1.MouseLeave
        RaiseEvent OnMouseLeaveMnuText()
        'ShowMouseLeave()
    End Sub

End Class
