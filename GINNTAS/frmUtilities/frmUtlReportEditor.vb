Public Class frmUtlReportEditor
    Public FormScreenID As Long
    Private Sub frmUtlReportEditor_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        CloseForm(FormScreenID, "")
    End Sub
End Class