Imports System.IO
Imports System.Reflection

Public Class ucTruck

#Region "Property"
    Dim mTotalComp As Integer
    Dim mCompartment() As ucVProgressBar
    Dim mCompNo() As Label

    Public Property ucTruckTotalCompartment As Integer
        Get
            Return mTotalComp
        End Get
        Set(ByVal value As Integer)
            mTotalComp = value
            RemoveCompartment()
            If mTotalComp > 0 Then
                InitialCompartment()
            End If
        End Set
    End Property

    Public Property ucTruckCompartmentLocation As Point
        Get
            Return Panel1.Location
        End Get
        Set(ByVal value As Point)
            Panel1.Location = value
        End Set
    End Property

    Public Property ucTruckCompartmentSize As Size
        Get
            Return Panel1.Size
        End Get
        Set(ByVal value As Size)
            Panel1.Size = value
        End Set
    End Property
#End Region

#Region "Method"
    Private Sub InitialCompartment()
        Dim vPanel As Object
        vPanel = Me.Panel1
        vPanel.visible = False
        ReDim mCompartment(mTotalComp)
        ReDim mCompNo(mTotalComp)
        For i As Integer = 0 To mTotalComp - 1
            mCompartment(i) = New ucVProgressBar
            vPanel.Controls.Add(mCompartment(i))
            mCompartment(i).Height = vPanel.Height - 1
            mCompartment(i).Left = -1
            mCompartment(i).Top = -1

            mCompNo(i) = New Label
            Me.Controls.Add(mCompNo(i))

            With mCompNo(i)
                .BackColor = Color.Black
                .ForeColor = Color.White
                .Text = i + 1
                .AutoSize = True
            End With
            'If i = 0 Then
            '    mucCompartment(i).Left = 0
            '    mucCompartment(i).Top = 0
            'Else
            '    mucCompartment(i).Left = mucCompartment(i - 1).Left + mucCompartment(i - 1).Width
            '    mucCompartment(i).Top = mucCompartment(i - 1).Top
            'End If
            SetPositionCompartment()
        Next
        vPanel.visible = True
        vPanel = Nothing
    End Sub

    Private Sub SetPositionCompartment()
        Dim vPanel As Panel
        vPanel = Me.Panel1

        'p.Width = Me.Width * 0.19
        vPanel.Left = Me.Width * 0.1884
        vPanel.Height = Me.Height * 0.7005
        vPanel.Width = Me.Width * 0.7591
        vPanel.Visible = False

        Try
            For i As Integer = 0 To mCompartment.Length
                mCompartment(i).Width = ((vPanel.Width - 2) / mTotalComp)
                If mCompartment.Length = 1 Then
                    mCompartment(i).Width = mCompartment(i).Width - 1
                End If
                mCompartment(i).Height = vPanel.Height - 2
                If i = 0 Then
                    mCompartment(i).Left = 0
                    mCompartment(i).Top = 0
                Else
                    mCompartment(i).Left = mCompartment(i - 1).Left + mCompartment(i - 1).Width
                    mCompartment(i).Top = mCompartment(i - 1).Top
                    mCompartment(i).BringToFront()
                End If

                mCompNo(i).Left = (vPanel.Left + mCompartment(i).Left + (mCompartment(i).Width / 2)) - mCompNo(i).Width
                mCompNo(i).Top = vPanel.Height + 1
            Next
        Catch ex As Exception

        End Try
        vPanel.Visible = True
        vPanel = Nothing
    End Sub

    Private Sub RemoveCompartment()
        'Dim allCtrl As Object
        'allCtrl = From ctrl As ucVProgressBar In Me.Controls.OfType(Of ucVProgressBar)()

        'For Each ctrl As ucVProgressBar In allCtrl
        '    Me.Controls.Remove(ctrl)
        'Next
        Dim vPanel As Object
        vPanel = Me.Panel1
        vPanel.visible = False
        Try
            For i As Integer = 0 To mCompartment.Length
                vPanel.Controls.Remove(mCompartment(i))
                Me.Controls.Remove(mCompNo(i))
            Next
        Catch ex As Exception

        End Try
        vPanel.visible = True
        vPanel = Nothing
    End Sub

    Public Sub SetCompartmentCapacity(ByVal pComNo As Integer, ByVal pCapacity As Integer)
        mCompartment(pComNo - 1).ucCapacityValue = pCapacity
        mCompNo(pComNo - 1).Text = pComNo
    End Sub

    Public Sub SetCompartmentAdvice(ByVal pComNo As Integer, ByVal pAdvice As Integer)
        mCompartment(pComNo - 1).ucAdviceValue = pAdvice
        mCompNo(pComNo - 1).Text = pComNo
    End Sub

    Public Sub SetCompartmentValue(ByVal pComNo As Integer, ByVal pAdvice As Integer)
        mCompartment(pComNo - 1).ucProgressBarValue = pAdvice
        mCompNo(pComNo - 1).Text = pComNo
    End Sub

    Private Function appendZero(ByVal codeColour As String) As String
        Dim i As Integer = 6 - codeColour.Length
        While (i <> 0)
            codeColour = "0" + codeColour
            i = i - 1
        End While
        Return codeColour
    End Function
    Public Sub SetCompartmentColor(ByVal pCompNo As Integer, ByVal pColorCode As Double)
        Dim vColorCode As String
        vColorCode = pColorCode.ToString
        'mCompartment(pCompNo - 1).ucProgressBarBackColor = appendZero(Hex(vColorCode))
        mCompartment(pCompNo - 1).ucProgressBarBackColor = ColorTranslator.FromHtml("#" + appendZero(Hex(pColorCode).ToString()))
    End Sub
#End Region

    Private Sub ucTruck_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.BackgroundImage = Image.FromFile(GetCurrDirectory() & "\pictures\Menu\HMI\TRUCK-01.png")
            Me.BackgroundImageLayout = ImageLayout.Stretch
        Catch ex As Exception
            Me.BackgroundImage = Nothing
        End Try

    End Sub

    Private Sub ucTruck_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        SetPositionCompartment()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If DesignMode = False Then
            Panel1.BorderStyle = Windows.Forms.BorderStyle.None
        End If

        mTotalComp = 1
        InitialCompartment()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        Me.BackgroundImage = Nothing
    End Sub
End Class
