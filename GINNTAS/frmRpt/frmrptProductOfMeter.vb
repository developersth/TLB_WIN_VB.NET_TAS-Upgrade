﻿Public Class frmrptProductOfMeter

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPready_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPready.Click
        Dim vReport_ID As String
        If rType1.Checked = True Then
            vReport_ID = "52010055"
        Else
            vReport_ID = "52010056"
        End If
        With frmrptMainShow
            .report_id = vReport_ID
            .param1 = MVDate.SelectionStart()
            .Show()
        End With
    End Sub

    Private Sub frmrptProductOfMeter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class