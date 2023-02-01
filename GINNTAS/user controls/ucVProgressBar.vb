Public Class ucVProgressBar
    Dim mCapacity As Single = 100
    Dim mAdvice As Single = 50
    Dim mProgress As Single = 25

    Dim mLSL As Single
    Dim mLSLL As Single
    Dim mLSH As Single
    Dim mLSHH As Single

    Dim mPercentAdvice As Single
    Dim mPercentProgress As Single

    Const m_def_UseLSBar = False
    Dim mUseLSBar As Boolean

#Region "Property"

    Public Property ucAdviseBorderColor As System.Drawing.Color
        Get
            Return shpAdviceLimit.BorderColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            shpAdviceLimit.BorderColor = value
        End Set
    End Property

    Public Property ucProgressBarBackColor As System.Drawing.Color
        Get
            Return shpProgressBar.FillColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            shpProgressBar.FillColor = value
            shpProgressBar.BorderColor = value
        End Set
    End Property

    Public Property ucCapacityBarBackColor As System.Drawing.Color
        Get
            Return shpCapacityLimit.FillColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            shpCapacityLimit.FillColor = value
        End Set
    End Property

    Public Property ucCapacityValue As Integer
        Get
            Return mCapacity
        End Get
        Set(ByVal value As Integer)
            If value > 0 Then
                mCapacity = CSng(value)
            Else
                mCapacity = 100
            End If
            lblCapacity.Text = mCapacity
            CalObject()
        End Set
    End Property

    Public Property ucAdviceValue As Integer
        Get
            Return mAdvice
        End Get
        Set(ByVal value As Integer)
            If value > 0 Then
                If value <= mCapacity Then
                    mAdvice = CSng(value)
                Else
                    mAdvice = mCapacity
                End If
            Else
                mAdvice = 50
            End If
            lblAdvice.Text = mAdvice
            CalObject()
            'CalAdviceBar(mCapacity, mAdvice)
            'CalProgressBar(mAdvice, mProgress)
        End Set
    End Property

    Public Property ucProgressBarValue As Single
        Get
            Return mProgress
        End Get
        Set(ByVal value As Single)
            If value >= 0 And value <= mAdvice Then
                mProgress = value
            Else
                'mProgress = mAdvice
                mProgress = value
            End If
            lblProgressBar.Text = mProgress
            CalObject()
        End Set
    End Property

    Public Property ucFontCapacity As Font
        Get
            Return lblCapacity.Font
        End Get
        Set(ByVal value As Font)
            lblCapacity.Font = value
        End Set
    End Property

    Public Property ucFontAdvice As Font
        Get
            Return lblAdvice.Font
        End Get
        Set(ByVal value As Font)
            lblAdvice.Font = value
        End Set
    End Property

    Public Property ucFontProgress As Font
        Get
            Return lblProgressBar.Font
        End Get
        Set(ByVal value As Font)
            lblProgressBar.Font = value
        End Set
    End Property

    Public Property ucFontPercentProgress As Font
        Get
            Return lblPercent.Font
        End Get
        Set(ByVal value As Font)
            lblPercent.Font = value
        End Set
    End Property

    Public Property ucForeColorCapacity As Color
        Get
            Return lblCapacity.ForeColor
        End Get
        Set(ByVal value As Color)
            lblCapacity.ForeColor = value
        End Set
    End Property

#End Region

#Region "Method"
    Public Sub SetLSBar(ByVal pLSLL As Double, ByVal pLSL As Double, ByVal pLSHH As Double, ByVal pLSH As Double)
        Dim vTemp As Double

        mLSH = pLSH
        mLSHH = pLSHH
        mLSL = pLSL
        mLSLL = pLSLL

        lblLSH.Text = mLSH
        lblLSHH.Text = mLSHH
        lblLSL.Text = mLSL
        lblLSLL.Text = mLSLL

        If mLSLL > 0 Then
            vTemp = shpCapacityLimit.Height * mLSLL
            With shpLSLL
                .Top = (shpCapacityLimit.Top + shpCapacityLimit.Height) - (vTemp / mCapacity)
                .Height = (shpCapacityLimit.Height + shpCapacityLimit.Top) - shpLSLL.Top
            End With
        Else
            With shpLSLL
                .Top = (shpCapacityLimit.Top + shpCapacityLimit.Height)
                .Height = 0
            End With
        End If

        If mLSL > 0 Then
            vTemp = shpCapacityLimit.Height * mLSL
            With shpLSL
                .Top = (shpCapacityLimit.Top + shpCapacityLimit.Height) - (vTemp / mCapacity)
                .Height = (shpCapacityLimit.Height + shpCapacityLimit.Top) - shpLSL.Top
            End With
        Else
            With shpLSL
                .Top = (shpCapacityLimit.Top + shpCapacityLimit.Height)
                .Height = 0
            End With
        End If

        If mLSH > 0 Then
            vTemp = shpCapacityLimit.Height * mLSH
            With shpLSH
                .Top = (shpCapacityLimit.Top + shpCapacityLimit.Height) - (vTemp / mCapacity)
                .Height = (shpCapacityLimit.Height + shpCapacityLimit.Top) - shpLSH.Top
            End With
        Else
            With shpLSH
                .Top = (shpCapacityLimit.Top + shpCapacityLimit.Height)
                .Height = 0
            End With
        End If

        If mLSHH > 0 Then
            vTemp = shpCapacityLimit.Height * mLSHH
            With shpLSHH
                .Top = (shpCapacityLimit.Top + shpCapacityLimit.Height) - (vTemp / mCapacity)
                .Height = (shpCapacityLimit.Height + shpCapacityLimit.Top) - shpLSHH.Top
            End With
        Else
            With shpLSHH
                .Top = (shpCapacityLimit.Top + shpCapacityLimit.Height)
                .Height = 0
            End With
        End If

        lblLSL.Left = 0 : lblLSL.Top = shpLSL.Top
        lblLSLL.Left = 0 : lblLSLL.Top = shpLSLL.Top
        lblLSH.Left = 0 : lblLSH.Top = shpLSH.Top
        lblLSHH.Left = 0 : lblLSHH.Top = shpLSHH.Top
    End Sub

    Public Sub SetLimitBar(ByVal pCapacityValue As Double, ByVal pAdviceValue As Double)
        mCapacity = pCapacityValue
        lblCapacity.Text = mCapacity
        If pAdviceValue <= mCapacity Then
            mAdvice = pAdviceValue
        Else
            mAdvice = mCapacity
        End If

        lblAdvice.Text = mAdvice
        mProgress = 0
        lblProgressBar.Text = mProgress

        'Call CaculAdviceBar(mCapacity, mAdvice)
        'Call CaculProgressBar(mAdvice, mProgress)
    End Sub

    'Public Sub GetValueCapacity(ByRef pCapacity As Double)
    '    pCapacity = mCapacity
    'End Sub

    'Public Sub GetValueAdvice(ByRef pAdvice As Double, ByRef pPercent As Double)
    '    pAdvice = mAdvice
    '    pPercent = mPercentAdvice
    'End Sub

    Private Sub CalAdviceBar(ByVal pCapacity As Single, ByVal pAdvice As Single)
        Dim vValue As Single
        '    ___    pCapacity,Heigh
        '   |   |
        '   |   |        ___    pAdvice,Heigh
        '   |   |       |   |
        '   |___|       |___|
        '   capacity     advice
        '   

        vValue = (pAdvice / (pCapacity - 0)) * (shpCapacityLimit.Height - shpCapacityLimit.Top + lblPercent.Height)
        With shpAdviceLimit
            .Height = vValue
            .Top = shpCapacityLimit.Height + shpCapacityLimit.Top - .Height
            .Left = shpCapacityLimit.Left + 1
            .Width = shpCapacityLimit.Width - 2
        End With
        'SetObject()
    End Sub

    Private Sub CalProgressBar(ByVal pAdvice As Single, ByVal pProgress As Single)
        Dim vValue, vValueP As Single

        vValue = (pProgress / (pAdvice - 0)) * shpAdviceLimit.Height '- shpAdviceLimit.Top
        vValueP = (pProgress / pAdvice) * 100  'show %

        With shpProgressBar
            .Height = vValue - 4
            .Top = shpAdviceLimit.Top + shpAdviceLimit.Height - .Height - 2
            .Left = shpAdviceLimit.Left + 1
            .Width = shpAdviceLimit.Width - 2
        End With
        lblPercent.Text = Format(vValueP, "#0.##") & " %"
        'SetObject()
    End Sub

    Private Sub CalObject()
        SetCapacityLimit()
        CalAdviceBar(mCapacity, mAdvice)
        CalProgressBar(mAdvice, mProgress)
        SetPositionLabel()
    End Sub

    Private Sub SetCapacityLimit()
        With shpCapacityLimit
            .Height = Me.Height - lblPercent.Height - 2
            .Width = Me.Width - lblCapacity.Width - 2
            .Left = 3
            .Top = lblPercent.Height
        End With
    End Sub

    Private Sub SetPositionLabel()
        'shpAdviceLimit.Top = shpCapacityLimit.Top + (shpCapacityLimit.Height - shpAdviceLimit.Height) - 1
        'shpProgressBar.Top = shpCapacityLimit.Top + (shpCapacityLimit.Height - shpProgressBar.Height) - 2

        lblCapacity.Left = shpCapacityLimit.Left + shpCapacityLimit.Width + 2
        lblCapacity.Top = shpCapacityLimit.Top ' + lblCapacity.Height


        lblAdvice.Left = lblCapacity.Left
        If shpAdviceLimit.Top > lblCapacity.Top + lblCapacity.Height Then
            lblAdvice.Top = shpAdviceLimit.Top
        Else
            lblAdvice.Top = lblCapacity.Top + lblCapacity.Height + 2
        End If

        If shpCapacityLimit.Width > 30 Then
            lblPercent.Width = shpCapacityLimit.Width
        Else
            lblPercent.Width = 30
        End If

        lblProgressBar.Left = lblCapacity.Left
        If shpProgressBar.Height > lblProgressBar.Height Then
            If shpProgressBar.Top > lblAdvice.Top + lblAdvice.Height Then
                lblProgressBar.Top = shpProgressBar.Top
            Else
                lblProgressBar.Top = lblAdvice.Top + lblAdvice.Height + 2
            End If
        Else
            lblProgressBar.Top = shpProgressBar.Top - lblProgressBar.Height
        End If
        'VCapacityValue = mCapacity
    End Sub

    Private Sub SetObject1()
        'shpAdviceLimit.Top = shpCapacityLimit.Top + (shpCapacityLimit.Height - shpAdviceLimit.Height) - 1
        'shpProgressBar.Top = shpCapacityLimit.Top + (shpCapacityLimit.Height - shpProgressBar.Height) - 2

        lblCapacity.Left = shpCapacityLimit.Left + shpCapacityLimit.Width + 6
        lblCapacity.Top = shpCapacityLimit.Top ' + lblCapacity.Height


        lblAdvice.Left = lblCapacity.Left
        If shpAdviceLimit.Top > lblCapacity.Top + lblCapacity.Height Then
            lblAdvice.Top = shpAdviceLimit.Top
        Else
            lblAdvice.Top = lblCapacity.Top + lblCapacity.Height + 2
        End If

        lblPercent.Width = shpCapacityLimit.Width

        lblProgressBar.Left = lblCapacity.Left
        If shpProgressBar.Height > lblProgressBar.Height Then
            If shpProgressBar.Top > lblAdvice.Top + lblAdvice.Height Then
                lblProgressBar.Top = shpProgressBar.Top
            Else
                lblProgressBar.Top = lblAdvice.Top + lblAdvice.Height + 2
            End If
        Else
            lblProgressBar.Top = shpProgressBar.Top - lblProgressBar.Height
        End If
        'VCapacityValue = mCapacity
    End Sub

#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.Width = 100
        Me.Height = 150

        lblPercent.Left = 3 : lblPercent.Top = 0

        lblCapacity.Left = shpCapacityLimit.Left + shpCapacityLimit.Width + 2
        lblCapacity.Top = 0

        shpAdviceLimit.Top = shpCapacityLimit.Top + (shpCapacityLimit.Height - shpAdviceLimit.Height)
        shpProgressBar.Top = shpCapacityLimit.Top + (shpCapacityLimit.Height - shpProgressBar.Height)

        ucCapacityValue = mCapacity
        ucAdviceValue = mAdvice
        ucProgressBarValue = mProgress
        SetCapacityLimit()
        SetPositionLabel()
    End Sub

    Private Sub ucProgressBar_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'If Me.Width > 100 Then
        '    shpCapacityLimit.Width = Me.Width * 0.6
        'Else
        '    Me.Width = 100
        '    shpCapacityLimit.Width = 60
        'End If

        'If Me.Height > 150 Then
        '    shpCapacityLimit.Height = Me.Height - shpCapacityLimit.Top - 1
        'Else
        '    Me.Height = 100
        '    shpCapacityLimit.Height = Me.Height - shpCapacityLimit.Top - 1
        'End If

        'shpAdviceLimit.Width = shpCapacityLimit.Width - 4
        'shpAdviceLimit.Left = shpCapacityLimit.Left + 2

        'shpLSH.Size = shpAdviceLimit.Size
        'shpLSH.Location = shpAdviceLimit.Location
        'shpLSHH.Size = shpAdviceLimit.Size
        'shpLSHH.Location = shpAdviceLimit.Location
        'shpLSL.Size = shpAdviceLimit.Size
        'shpLSL.Location = shpAdviceLimit.Location
        'shpLSLL.Size = shpAdviceLimit.Size
        'shpLSLL.Location = shpAdviceLimit.Location

        ''Call CaculAdviceBar(mCapacity, mAdvice)
        'shpProgressBar.Width = shpAdviceLimit.Width - 4
        'shpProgressBar.Left = shpAdviceLimit.Left + 2
        ''Call CaculProgressBar(mAdvice, mProgress)

        'lblPercent.Left = shpCapacityLimit.Left
        'lblPercent.Width = shpCapacityLimit.Width
        'lblCapacity.Left = shpCapacityLimit.Left + shpCapacityLimit.Width + 6
        'lblAdvice.Left = lblCapacity.Left
        'lblProgressBar.Left = lblCapacity.Left
        'shpAdviceLimit.Top = shpCapacityLimit.Top + (shpCapacityLimit.Height - shpAdviceLimit.Height)
        'shpProgressBar.Top = shpCapacityLimit.Top + (shpCapacityLimit.Height - shpProgressBar.Height)
        'VCapacityValue = mCapacity
        'SetObject()

        'shpCapacityLimit.Width = Me.Width - lblCapacity.Width + 9
        'shpCapacityLimit.Height = Me.Height - lblPercent.Height - 1

        CalObject()
    End Sub
End Class
