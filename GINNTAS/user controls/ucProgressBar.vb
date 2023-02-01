Public Class ucProgressBar
    Dim mCapacity As Double
    Dim mAdvice As Double
    Dim mProgress As Double

    Dim mLSL As Double
    Dim mLSLL As Double
    Dim mLSH As Double
    Dim mLSHH As Double

    Dim mPercentAdvice As Double
    Dim mPercentProgress As Double

    Const m_def_UseLSBar = False
    Dim mUseLSBar As Boolean

#Region "Property"
    Public Property CapacityBarBackColor As System.Drawing.Color
        Get
            Return shpCapacityLimit.BackColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            shpCapacityLimit.BackColor = value
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

    Public Sub SetProgress(ByVal pValue As Double)

        'If Value > 0 And Value <= m_Advice Then
        mProgress = pValue
        lblProgressBar.Text = mProgress
        'Call CaculProgressBar(mAdvice, mProgress)
        'Else
        '    MsgBox "Value Progress ÁÒ¡¡ÇèÒ Advice"
        'End If

    End Sub

    'Public Sub GetValueCapacity(ByRef pCapacity As Double)
    '    pCapacity = mCapacity
    'End Sub

    'Public Sub GetValueAdvice(ByRef pAdvice As Double, ByRef pPercent As Double)
    '    pAdvice = mAdvice
    '    pPercent = mPercentAdvice
    'End Sub

    Private Sub CalAdviceBar(ByVal pCapacity As Double, ByVal pAdvice As Double)
        Dim vTemp As Double
        '    ___    pCapacity,Heigh
        '   |   |
        '   |   |        ___    pAdvice,Heigh
        '   |   |       |   |
        '   |___|       |___|
        '   capacity     advice
        '   


    End Sub
#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Width = 100
        Me.Height = 150

        lblPercent.Left = 3 : lblPercent.Top = 0

        'shpCapacityLimit.Left = 3
        'shpCapacityLimit.Top = lblPercent.Top + lblPercent.Height + 8
        'shpCapacityLimit.Height = Me.Height - shpCapacityLimit.Top - 1

        lblCapacity.Left = shpCapacityLimit.Left + shpCapacityLimit.Width + 9
        lblCapacity.Top = 0

        shpAdviceLimit.Location = shpCapacityLimit.Location

        shpProgressBar.Location = shpCapacityLimit.Location
        shpProgressBar.Width = shpCapacityLimit.Width

        mCapacity = 5000
        mAdvice = 3000
        mProgress = 10

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

        shpAdviceLimit.Width = shpCapacityLimit.Width - 4
        shpAdviceLimit.Left = shpCapacityLimit.Left + 2

        shpLSH.Size = shpAdviceLimit.Size
        shpLSH.Location = shpAdviceLimit.Location
        shpLSHH.Size = shpAdviceLimit.Size
        shpLSHH.Location = shpAdviceLimit.Location
        shpLSL.Size = shpAdviceLimit.Size
        shpLSL.Location = shpAdviceLimit.Location
        shpLSLL.Size = shpAdviceLimit.Size
        shpLSLL.Location = shpAdviceLimit.Location

        'Call CaculAdviceBar(mCapacity, mAdvice)
        shpProgressBar.Width = shpAdviceLimit.Width - 4
        shpProgressBar.Left = shpAdviceLimit.Left + 2
        'Call CaculProgressBar(mAdvice, mProgress)

        'lblPercent.Left = shpCapacityLimit.Left
        lblPercent.Width = shpCapacityLimit.Width
        lblCapacity.Left = shpCapacityLimit.Left + shpCapacityLimit.Width + 6
        lblAdvice.Left = lblCapacity.Left
        lblProgressBar.Left = lblCapacity.Left
    End Sub
End Class
