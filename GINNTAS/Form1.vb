Imports System.Data

Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Oradb.Connect()
        SetScreenResulotion()
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.CenterScreen
        CheckFormResize(Me)
        'Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub UcMinimize_OnCilckMin() Handles UcMinimize.OnCilckMin
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ExitProgram()
        Oradb.Dispose()
        Me.Close()
        'End
    End Sub

    Private Sub UcClose_OnClickClose() Handles UcClose.OnClickClose
        ExitProgram()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strSQL As String = "select * from mst.STATE_DESC"

        Dim mDataset As New DataSet

        Oradb.OpenDys(strSQL, "TableName", mDataset)

        DataGridView1.DataSource = mDataset.Tables("TableName")

    End Sub

    Private Sub Form1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        'Call CheckFormResize(Me)
        CheckFormResize(Me)
    End Sub
End Class
