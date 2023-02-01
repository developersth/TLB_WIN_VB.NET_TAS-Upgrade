Public Class ucMMIview
    Dim h
    Dim w
    Dim w20
    Dim b
    Dim UcProgressOverView As New Collection
    Private Sub ucMMIview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    'Dim leftBay
    'Dim rightBay
    Public Function createUcProgressOverView(ByVal MaxBay As Integer, ByVal s As Size, ByVal n As Integer) As Integer
        b = n
        w = s.Width
        h = s.Height
        w20 = w * (20 / 100)
        Dim i = 1
        Do While MaxBay >= i
            UcProgressOverView.Add(New UcProgressOil())
            If (i Mod 2) = 0 Then
                UcProgressOverView(i).Location = New Point(w20 * 4, 0)
            Else
                UcProgressOverView(i).Location = New Point(0, 0)
            End If
            UcProgressOverView(i).Size = New Size(w20, h)
            Me.Controls.Add(UcProgressOverView(i))
            i += 1
        Loop

        Dim lableRack = New TextBox()
        'lableRack.BackColor = Color.Transparent
        lableRack.Location = New Point(w20 * 2.5 - 25, h - 25)
        lableRack.Text = "Rack " & n
        'lableRack.Size = New Size(7, 30)
        Me.Controls.Add(lableRack)
        lableRack.Size = New Size(50, 10)
        lableRack.Enabled = False


        Dim rack = New PictureBox()
        rack.BackColor = Color.Gold
        rack.Location = New Point(w20 * 2, 0)
        rack.Size = New Size(w20, h)
        Me.Controls.Add(rack)
        'rack.BringToFront()

        'leftBay = New TextBox()
        leftBay.Location = New Point(w20 * 1.5 - leftBay.Size.Width / 2, 0)
        leftBay.Text = n * 2 - 1
        'Me.Controls.Add(leftBay)
        'leftBay.Size = New Size(15, 10)
        'leftBay.Enabled = False

        'rightBay = New TextBox()
        rightBay.Location = New Point(w20 * 3.5 - rightBay.Size.Width / 2, 0)
        rightBay.Text = n * 2
        'rightBay.Size = New Size(15, 10)
        'Me.Controls.Add(rightBay)
        'rightBay.Enabled = False

        Return (1)
    End Function


    Public Sub InitailMeter(ByVal meter As String)
        If meter <> "- -" Then
            Dim pmeter = New PictureBox()
            pmeter.BackColor = Color.Red
            pmeter.Size = New Size(w20 / 3, h / 9)
            pmeter.Location = New Point(w20 * 2.5 - pmeter.Size.Width / 2, (h / 9) * (9 - (CType(meter Mod 10, Integer) * 2)))
            Me.Controls.Add(pmeter)
            pmeter.BringToFront()
        End If
    End Sub


    Public Function updateProgrss(ByVal bay As Integer, ByVal sumCapacity As Integer, ByVal sumAdvice As Integer, ByVal gross As Integer) As Integer
        UcProgressOverView(bay).updateProgrssOil(sumCapacity, sumAdvice, gross)
        Return (1)
    End Function

    Public Function hideProgress(ByVal bay As Integer, ByVal b As Boolean) As Integer
        UcProgressOverView(bay).hideProgress(b)
        Return (1)
    End Function

   
  
    Private Sub leftBay_Click(sender As System.Object, e As System.EventArgs) Handles leftBay.Click
        ''MessageBox.Show(leftBay.Text)
        frmMMIBayLoading.Show()
        frmMMIBayLoading.selectBay(leftBay.Text, leftBay.Text)
    End Sub

    Private Sub rightBay_Click(sender As System.Object, e As System.EventArgs) Handles rightBay.Click
        ''MessageBox.Show(rightBay.Text)
        frmMMIBayLoading.Show()
        frmMMIBayLoading.selectBay(rightBay.Text, rightBay.Text)
    End Sub
End Class
