Public Class ucTank


    Dim temLL As Double
    Dim temL As Double
    Dim temHH As Double
    Dim temH As Double
    Dim percentAdvice As Double
    Dim percentOil As Double
    Dim TankHigh As Double
    Private Sub UcProgressOil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bgWidth = Me.Size.Width
        Dim bgHeight = Me.Size.Height

        Dim thick = 2
        percentAdvice = 70
        percentOil = 60
        ''------------- defalt -------------------
        capacityFrame.Location = New Point(0, 0)
        capacityFrame.Size = New Size(bgWidth, 0)
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

        updateTube()
        Me.Visible = False
    End Sub

    Public Function updateLine(ByVal LL As Integer, ByVal L As Integer, ByVal HH As Integer, ByVal H As Integer) As Integer
        temLL = (LL / TankHigh) * 100
        temL = (L / TankHigh) * 100
        temHH = (HH / TankHigh) * 100
        temH = (H / TankHigh) * 100

        If Not Double.IsNaN((LL / TankHigh) * 100) Then
            temLL = 0
        Else
            temLL = (LL / TankHigh) * 100
        End If
        If Not Double.IsNaN((L / TankHigh) * 100) Then
            temL = 0
        Else
            temL = (L / TankHigh) * 100
        End If
        If Not Double.IsNaN((HH / TankHigh) * 100) Then
            temHH = 0
        Else
            temHH = (HH / TankHigh) * 100
        End If
        If Not Double.IsNaN((H / TankHigh) * 100) Then
            temH = 0
        Else
            temH = (H / TankHigh) * 100
        End If
        updateTube()

    End Function

    Public Function updateProgrssOil(ByVal capacity As Integer, ByVal advice As Integer, ByVal gross As Integer) As Integer
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
        TankHigh = advice
   
    End Function

    Sub updateTube()
        Me.Visible = True
        Dim bgWidth = Me.Size.Width
        Dim bgHeight = Me.Size.Height

        Dim thick = 2
        oil.Visible = False
        ''------------- defalt -------------------
        capacityFrame.Location = New Point(0, 0)
        capacityFrame.Size = New Size(bgWidth, bgHeight)
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

        Dim LineHHDiffHeight As Double = oil.Size.Height * (100 - temHH) / 100
        If Double.IsNaN(LineHHDiffHeight) Then
            LineHHDiffHeight = 0
        End If
        LineHH.Location = New Point(oil.Location.X, oil.Location.Y + LineHHDiffHeight)
        LineHH.Size = New Size(oil.Size.Width - 10, 1)

        Dim LineHDiffHeight As Double = oil.Size.Height * (100 - temH) / 100
        If Double.IsNaN(LineHDiffHeight) Then
            LineHDiffHeight = 0
        End If
        LineH.Location = New Point(oil.Location.X, oil.Location.Y + LineHDiffHeight)
        LineH.Size = New Size(oil.Size.Width / 2 - 10, 1)

        Dim LineLLDiffHeight As Double = oil.Size.Height * (100 - temLL) / 100
        If Double.IsNaN(LineLLDiffHeight) Then
            LineLLDiffHeight = 0
        End If
        LineLL.Location = New Point(oil.Location.X, oil.Location.Y + LineLLDiffHeight)
        LineLL.Size = New Size(oil.Size.Width - 10, 1)

        Dim LineLDiffHeight As Double = oil.Size.Height * (100 - temL) / 100
        If Double.IsNaN(LineLDiffHeight) Then
            LineLDiffHeight = 0
        End If
        LineL.Location = New Point(oil.Location.X, oil.Location.Y + LineLDiffHeight)
        LineL.Size = New Size(oil.Size.Width / 2 - 10, 1)

        Dim oilDiffHeight As Double = oil.Size.Height * (100 - percentOil) / 100
        If Double.IsNaN(oilDiffHeight) Then
            oilDiffHeight = 0
        End If
        oil.Location = New Point(oil.Location.X, oil.Location.Y + oilDiffHeight)
        oil.Size = New Size(oil.Size.Width, adviceBG.Size.Height - oilDiffHeight)

        oil.Visible = True


    End Sub

    Public Sub setColorOil(ByVal c As String)
        If c = "" Then
            oil.BackColor = Color.Black
        Else
            oil.BackColor = ColorTranslator.FromHtml("#" + updateColorCode(c).ToString())
            'oil.BackColor = Color.FromArgb(CInt("&H" & c))
        End If
        'oil.BackColor = c
    End Sub


    Private Function updateColorCode(ByVal codeColour As String) As String
        If codeColour = "" Then
            codeColour = "FF0000"
        End If
        Dim i As Integer = 6 - codeColour.Length
        While (i <> 0)
            codeColour = "0" + codeColour
            i = i - 1
        End While

        Dim newCode = codeColour(4) + codeColour(5) + codeColour(2) + codeColour(3) + codeColour(0) + codeColour(1)

        Return newCode
    End Function
End Class
