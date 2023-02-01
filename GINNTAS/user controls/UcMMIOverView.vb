

Imports Oracle.DataAccess.Client
Imports System.Data



Public Class UcMMIOverView
    Dim listMeter As New Collection
    Dim listTruck As New Collection
    Dim listProgress As New Collection
    Dim listTubeR As New Collection
    Dim listTubeL As New Collection

    Dim defH = 338
    Dim defW = 587
    Private Sub UcMMIOverView_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        defH = 338
        defW = 587
        listMeter.Add(Meter0)
        listMeter.Add(Meter1)
        listMeter.Add(Meter2)
        listMeter.Add(Meter3)

        listTruck.Add(TruckRight)
        listTruck.Add(TruckLeft)

        listProgress.add(UcProgressOilLeft)
        listProgress.Add(UcProgressOilRight)

        listTubeR.Add(TubeR0)
        listTubeR.Add(TubeR1)
        listTubeR.Add(TubeR2)
        listTubeR.Add(TubeR3)

        listTubeL.Add(tubeL0)
        listTubeL.Add(tubeL1)
        listTubeL.Add(tubeL2)
        listTubeL.Add(tubeL3)
    End Sub

    Public Sub createUcOverView(ByVal s As Size, ByVal i As Integer)
        Dim h = s.Height
        Dim w = s.Width


        For Each obj In Me.Controls
            'MessageBox.Show(obj.name)
            'obj.Size = New Size(obj.Size.Width * percentW, obj.Size.Height * percentH)
            obj.Location = New Point(obj.Location.X + w / 2 - defW / 2, obj.Location.Y)
            'obj.BackColor = Color.Red
        Next

        BayLeft.Text = i * 2 - 1
        BayRight.Text = i * 2

    End Sub


    Public Sub InitailMeter(ByVal m As Integer)
        'CType(m Mod 10, Integer)
        listMeter(m Mod 10).visible = True
    End Sub

    Public Sub InitailTruck(ByVal m As Integer)
        'CType(m Mod 10, Integer)
        listTruck(m Mod 10).visible = True
    End Sub


    Public Function updateProgrss(ByVal bay As Integer, ByVal sumCapacity As Integer, ByVal sumAdvice As Integer, ByVal gross As Integer) As Integer
        listProgress(bay).updateProgrssOil(sumCapacity, sumAdvice, gross)
        listProgress(bay).visible = True
        InitailTruck(bay)

        Return (1)
    End Function


    Public Sub ShowTube(ByVal meter As Integer, ByVal bay As Integer, ByVal b As Boolean)

        If meter <> 0 Then
            If bay Mod 2 = 0 Then

                listTubeR(meter Mod 10).visible = b
            Else
                listTubeL(meter Mod 10).visible = b

            End If
        End If
    End Sub

  
    Private Sub BayLeft_Click(sender As System.Object, e As System.EventArgs) Handles BayLeft.Click
        frmMMIBayLoading.Show()
        frmMMIBayLoading.selectBay(BayLeft.Text, BayLeft.Text)
    End Sub

    Private Sub BayRight_Click(sender As System.Object, e As System.EventArgs) Handles BayRight.Click
        frmMMIBayLoading.Show()
        frmMMIBayLoading.selectBay(BayRight.Text, BayRight.Text)
    End Sub
End Class
