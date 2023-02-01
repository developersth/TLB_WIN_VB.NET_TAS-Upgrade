Imports System.Data

Public Class frmType2
    Public FormScreenID As Long

    Private Sub frmType2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UcStatus1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmType2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Oradb.Connect()
        SetScreenResulotion()
        'Me.WindowState = FormWindowState.Normal
        'Me.StartPosition = FormStartPosition.CenterScreen
        CheckFormResize(Me)
        InitialForm(Me, lblTitleName.Text)
        UcStatus1.StartThread()
    End Sub

    Private Sub frmType2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Label1.Text = Windows.Forms.Cursor.Position.ToString
    End Sub

    Private Sub frmType2_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        'CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin() Handles UcMinimize1.OnCilckMin
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose() Handles UcClose1.OnClickClose
        Me.Close()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
#Region "Menu Event"
    Private Sub UcInsert1_OnClickInsert(ByVal ucName As System.String, ByRef ucScreeenID As System.Int64)

    End Sub

    Private Sub UcEdit1_OnClickEdit(ByVal ucName As System.String, ByRef ucScreeenID As System.Int64)

    End Sub

    Private Sub UcDelete1_OnClickDelete(ByVal ucName As System.String, ByRef ucScreeenID As System.Int64)

    End Sub

    Private Sub UcSearch1_OnClickSearch(ByVal ucName As System.String)

    End Sub

    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String)

    End Sub

    Private Sub UcCancel1_OnClickCancel(ByVal ucName As System.String)

    End Sub

    Private Sub UcReflesh1_OnClickReflesh(ByVal ucName As System.String)

    End Sub
#End Region


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = SplitContainer1.Location.ToString & " | " & SplitContainer1.Size.ToString & _
            " | " & (SplitContainer1.Width - SplitContainer1.SplitterDistance - SplitContainer1.SplitterWidth)
    End Sub
End Class
