Public Class ucProgressOverView
    Dim constBarProgressSizeHeight
    Dim constBarProgressLocationY
    Dim h
    Dim progress = 100
    Dim spacePro = 35
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        'lblProgress.Location = New Point(lblProgress.Location.X, BarProgress.Location.Y)
      
        progress += 10
        showProgress()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        progress -= 10
        showProgress()

    End Sub
    Sub showProgress()

        h = constBarProgressSizeHeight - constBarProgressSizeHeight * (progress / 100)
        BarProgress.Size = New Size(BarProgress.Size.Width, constBarProgressSizeHeight - h)
        BarProgress.Location = New Point(BarProgress.Location.X, constBarProgressLocationY + h)
        'lblProgress.Location = New Point(Me.Size.Width - (spacePro) + 2, BarProgress.Location.Y)
        If spacePro + 30 > BarProgress.Location.Y Then

            lblProgress.Location = New Point(Me.Size.Width - (spacePro) + 2, spacePro + 28)
        ElseIf spacePro + constBarProgressSizeHeight - 14 < BarProgress.Location.Y Then
            lblProgress.Location = New Point(Me.Size.Width - (spacePro) + 2, BarProgress.Location.Y - 10)
        Else

            lblProgress.Location = New Point(Me.Size.Width - (spacePro) + 2, BarProgress.Location.Y)
        End If
        txtPercent.Text = Math.Round(progress, 1) & "%"
        'lblPercent.BackColor = Color.Transparent
        'lblPercent.BringToFront()
        'txtPercent.Text = Math.Round(progress, 1) & "%"
        If lblsumCapacity.Text = "lblsumCapacity" Then
            Me.Visible = False
        Else
            Me.Visible = True
        End If

    End Sub

    Private Sub ucProgressOverView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Visible = False
        Button2.Visible = False

        Dim sG = 2
        Dim sP = 1



        Green.Size = New Size(Me.Size.Width - (spacePro * 2) + sG * 2, Me.Size.Height - (spacePro * 2) + sG * 2)
        Green.Location = New Point(spacePro - sG, spacePro - sG)

        '--------
        'lblPercent.Size = New Size(Green.Size.Width, Me.Size.Height)
        'lblPercent.Location = New Point(spacePro - sG, spacePro - 16)
        txtPercent.Location = New Point(Green.Location.X, Green.Location.Y - 24)
        txtPercent.Size = New Size(Green.Size.Width, Me.Size.Height)
        '-------

        perProgress.Size = New Size(Me.Size.Width - (spacePro * 2) + sP * 2, Me.Size.Height - (spacePro * 2) + sP * 2)
        perProgress.Location = New Point(spacePro - sP, spacePro - sP)


        BarProgress.Size = New Size(Me.Size.Width - spacePro * 2, Me.Size.Height - spacePro * 2)
        BarProgress.Location = New Point(spacePro, spacePro)

        lblsumAdvice.Location = New Point(Me.Size.Width - (spacePro) + 2, spacePro + 14)
        lblsumCapacity.Location = New Point(Me.Size.Width - (spacePro) + 2, spacePro)

        'lblProgress.Location = New Point(Me.Size.Width - (spacePro) + 2, BarProgress.Location.Y)

        constBarProgressSizeHeight = BarProgress.Size.Height
        constBarProgressLocationY = BarProgress.Location.Y

        showProgress()
    End Sub


    Public Function updateProgrss(ByVal sumCapacity As Integer, ByVal sumAdvice As Integer, ByVal gross As Integer) As Integer
        progress = 100 * (gross / sumCapacity)

        lblsumCapacity.Text = sumCapacity
        lblsumAdvice.Text = sumAdvice

        lblProgress.Text = gross

        'Dim strNum = progress.ToString.Split(".")
        'strNum(1) = strNum(1).ToString.Substring(0, 1)
        'per.Text = strNum(0) & "." & strNum(1) & "%"


        If sumAdvice <= sumCapacity Then
        Else
            sumAdvice = sumCapacity
        End If

        showProgress()
        Return 1
    End Function

    Public Function hideProgress(ByVal b As Boolean) As Integer
        Me.Visible = b
        Return True
    End Function

    Public Function setSpacePro(ByVal s As Boolean) As Integer
        spacePro = s
        Return 1
    End Function

    
End Class
