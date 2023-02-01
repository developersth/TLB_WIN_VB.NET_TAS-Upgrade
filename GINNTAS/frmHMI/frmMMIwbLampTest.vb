Public Class frmMMIwbLampTest
    Dim WeightId As String


    Public Sub GetWeightID(ByVal iWeightId As String)
        WeightId = iWeightId
    End Sub

    Private Sub cmdTestLamp_Click(ByVal Index As Integer)
        If MsgBox("ท่านต้องการ Test Lamp หรือไม่?", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If
        Call ProcTestLamp(WeightId, Index)
    End Sub
    Private Sub ProcTestLamp(ByVal iWeightId As String, ByVal iValue As Integer)
        Dim strSQL As String
        If iValue = 0 Then
            iValue = 1
        Else
            iValue = 0
        End If
        strSQL = "begin  steqi.PROC_WEIGHT_LAMP_TEST( '" & iWeightId & "'," & iValue & "); end;"
        If Oradb.ExeSQL(strSQL) Then
            MsgBox("complete ", vbInformation)
        End If
    End Sub

    Private Sub cmdTestLamp0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTestLamp0.Click
        cmdTestLamp_Click(0)
    End Sub

    Private Sub cmdTestLamp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTestLamp1.Click
        cmdTestLamp_Click(1)
    End Sub


    Private Sub frmMMIwbLampTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(frmMMIWeighBridge.Size.Width / 2, frmMMIWeighBridge.Size.Height / 2 - Me.Size.Height / 2)
    End Sub
End Class