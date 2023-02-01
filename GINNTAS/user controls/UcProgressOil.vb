Public Class UcProgressOil



    Dim percentAdvice As Double
    Dim percentOil As Double
    Private Sub UcProgressOil_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim bgWidth = Me.Size.Width
        Dim bgHeight = Me.Size.Height

        Dim thick = 2
        percentAdvice = 70
        percentOil = 60
        ''------------- defalt -------------------
        capacityFrame.Location = New Point(0, bgHeight * 0.2)
        capacityFrame.Size = New Size(bgWidth / 2, bgHeight - (bgHeight * 0.2))
        capacityBG.Location = New Point(capacityFrame.Location.X + thick, capacityFrame.Location.Y + thick)
        capacityBG.Size = New Size(capacityFrame.Size.Width - thick * 2, capacityFrame.Size.Height - thick * 2)

        adviceFrame.Location = capacityBG.Location
        adviceFrame.Size = capacityBG.Size
        adviceBG.Location = New Point(adviceFrame.Location.X + thick, adviceFrame.Location.Y + thick)
        adviceBG.Size = New Size(adviceFrame.Size.Width - thick * 2, adviceFrame.Size.Height - thick * 2)

        oil.Location = adviceBG.Location
        oil.Size = adviceBG.Size

        '------------cal ------------------------
        Dim adviceDiffHeight = adviceFrame.Size.Height * (100 - percentAdvice) / 100
        adviceFrame.Location = New Point(adviceFrame.Location.X, adviceFrame.Location.Y + adviceDiffHeight)
        adviceFrame.Size = New Size(adviceFrame.Size.Width, adviceBG.Size.Height - adviceDiffHeight + thick * 2)
        adviceBG.Location = New Point(adviceFrame.Location.X + thick, adviceFrame.Location.Y + thick)
        adviceBG.Size = New Size(adviceFrame.Size.Width - thick * 2, adviceFrame.Size.Height - thick * 2)

        oil.Location = adviceBG.Location
        oil.Size = adviceBG.Size

        Dim oilDiffHeight = oil.Size.Height * (100 - percentOil) / 100
        oil.Location = New Point(oil.Location.X, oil.Location.Y + oilDiffHeight)
        oil.Size = New Size(oil.Size.Width, adviceBG.Size.Height - oilDiffHeight)

        '----------cal position lable
        'Dim spaceLable = 2
        lblCapacity.Location = New Point(capacityFrame.Location.X + capacityFrame.Size.Width + thick, capacityFrame.Location.Y)
        lblAdvice.Location = New Point(adviceFrame.Location.X + adviceFrame.Size.Width + thick * 2, adviceFrame.Location.Y)
        lblOil.Location = New Point(oil.Location.X + oil.Size.Width + thick * 3, oil.Location.Y)

        If lblAdvice.Location.Y - lblCapacity.Location.Y < lblCapacity.Size.Height + thick Then
            lblAdvice.Location = New Point(lblCapacity.Location.X, lblCapacity.Location.Y + lblCapacity.Size.Height + thick)
        End If


        If lblOil.Location.Y - lblAdvice.Location.Y < lblCapacity.Size.Height + thick Then
            lblOil.Location = New Point(lblAdvice.Location.X, lblAdvice.Location.Y + lblAdvice.Size.Height + thick)
        ElseIf lblOil.Location.Y > adviceBG.Size.Height + adviceBG.Location.Y - lblCapacity.Size.Height Then
            lblOil.Location = New Point(lblAdvice.Location.X, adviceBG.Size.Height + adviceBG.Location.Y - lblCapacity.Size.Height + thick * 2)
        End If

        '------------cal position text

        txtPrecentOil.Location = New Point(capacityFrame.Location.X, capacityFrame.Location.Y - txtPrecentOil.Size.Height - thick)
        txtPrecentOil.Size = New Size(capacityFrame.Size.Width, txtPrecentOil.Size.Height)
        txtPrecentOil.Text = Math.Round(percentOil, 1) & "%"

        updateTube()
        Me.Visible = False
    End Sub
    Private Function appendZero(ByVal codeColour As String) As String
        Dim i As Integer = 6 - codeColour.Length
        While (i <> 0)
            codeColour = "0" + codeColour
            i = i - 1
        End While
        Return codeColour
    End Function
    Public Sub SetColor(ByVal pColorCode As Double)
        Dim vColorCode As String
        vColorCode = pColorCode.ToString
        oil.BackColor = ColorTranslator.FromHtml("#" + appendZero(Hex(vColorCode).ToString()))
    End Sub
    Public Sub updateProgrssOil(ByVal capacity As Integer, ByVal advice As Integer, ByVal gross As Integer)
        If Not Double.IsNaN((advice / capacity) * 100) Then
            percentAdvice = (advice / capacity) * 100
        Else
            percentAdvice = 0
        End If
        If Not Double.IsNaN((gross / advice) * 100) Then
            percentOil = (gross / advice) * 100
        Else
            percentOil = 0
        End If

        lblCapacity.Text = capacity
        lblAdvice.Text = advice
        lblOil.Text = gross
        updateTube()

    End Sub
 
    Sub updateTube()
        Me.Visible = True
        Dim bgWidth = Me.Size.Width
        Dim bgHeight = Me.Size.Height

        Dim thick = 2
        oil.Visible = False
        ''------------- defalt -------------------
        capacityFrame.Location = New Point(0, bgHeight * 0.2)
        capacityFrame.Size = New Size(bgWidth / 2, bgHeight - (bgHeight * 0.2))
        capacityBG.Location = New Point(capacityFrame.Location.X + thick, capacityFrame.Location.Y + thick)
        capacityBG.Size = New Size(capacityFrame.Size.Width - thick * 2, capacityFrame.Size.Height - thick * 2)

        adviceFrame.Location = capacityBG.Location
        adviceFrame.Size = capacityBG.Size
        adviceBG.Location = New Point(adviceFrame.Location.X + thick, adviceFrame.Location.Y + thick)
        adviceBG.Size = New Size(adviceFrame.Size.Width - thick * 2, adviceFrame.Size.Height - thick * 2)

        oil.Location = adviceBG.Location
        oil.Size = adviceBG.Size

        '------------cal ------------------------
        Dim adviceDiffHeight = adviceFrame.Size.Height * (100 - percentAdvice) / 100
        adviceFrame.Location = New Point(adviceFrame.Location.X, adviceFrame.Location.Y + adviceDiffHeight)
        adviceFrame.Size = New Size(adviceFrame.Size.Width, adviceBG.Size.Height - adviceDiffHeight + thick * 2)
        adviceBG.Location = New Point(adviceFrame.Location.X + thick, adviceFrame.Location.Y + thick)
        adviceBG.Size = New Size(adviceFrame.Size.Width - thick * 2, adviceFrame.Size.Height - thick * 2)

        oil.Location = adviceBG.Location
        oil.Size = adviceBG.Size

        Dim oilDiffHeight = oil.Size.Height * (100 - percentOil) / 100
        oil.Location = New Point(oil.Location.X, oil.Location.Y + oilDiffHeight)
        oil.Size = New Size(oil.Size.Width, adviceBG.Size.Height - oilDiffHeight)

        ''----------cal position lable
        ''Dim spaceLable = 2
        lblCapacity.Location = New Point(capacityFrame.Location.X + capacityFrame.Size.Width + thick, capacityFrame.Location.Y)
        lblAdvice.Location = New Point(adviceFrame.Location.X + adviceFrame.Size.Width + thick * 2, adviceFrame.Location.Y)
        lblOil.Location = New Point(oil.Location.X + oil.Size.Width + thick * 3, oil.Location.Y)

        If lblAdvice.Location.Y - lblCapacity.Location.Y < lblCapacity.Size.Height + thick Then
            lblAdvice.Location = New Point(lblCapacity.Location.X, lblCapacity.Location.Y + lblCapacity.Size.Height + thick)
        End If


        If lblOil.Location.Y - lblAdvice.Location.Y < lblCapacity.Size.Height + thick Then
            lblOil.Location = New Point(lblAdvice.Location.X, lblAdvice.Location.Y + lblAdvice.Size.Height + thick)
        ElseIf lblOil.Location.Y > adviceBG.Size.Height + adviceBG.Location.Y - lblCapacity.Size.Height Then
            lblOil.Location = New Point(lblAdvice.Location.X, adviceBG.Size.Height + adviceBG.Location.Y - lblCapacity.Size.Height + thick * 2)
        End If

        '------------cal position text

        txtPrecentOil.Location = New Point(capacityFrame.Location.X, capacityFrame.Location.Y - txtPrecentOil.Size.Height - thick)
        txtPrecentOil.Size = New Size(capacityFrame.Size.Width, txtPrecentOil.Size.Height)

        '-------------------------------
        txtPrecentOil.Text = Math.Round(percentOil, 1) & "%"
        oil.Visible = True
    End Sub
  

End Class
