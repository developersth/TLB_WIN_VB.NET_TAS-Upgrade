Imports System.Data

Public Class frmType1
    Public FormScreenID As Long

    Private Sub frmType1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        UcStatus1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmType1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Oradb.Connect()
        SetScreenResulotion()
        'Me.WindowState = FormWindowState.Normal
        'Me.StartPosition = FormStartPosition.CenterScreen
        CheckFormResize(Me)
        InitialForm(Me, lblTitleName.Text)
        UcStatus1.StartThread()
    End Sub

    Private Sub frmType1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
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

    Private Sub UcSave1_OnClickSave(ByVal ucName As System.String) Handles UcSave1.OnClickSave

    End Sub

    Private Sub UcCancel1_OnClickCancel(ByVal ucName As System.String) Handles UcCancel1.OnClickCancel

    End Sub

    Private Sub UcReflesh1_OnClickReflesh(ByVal ucName As System.String) Handles UcReflesh1.OnClickReflesh

    End Sub
#End Region

    Private Sub DisableMenu(ByVal pName As String, ByVal bDisable As Boolean)
        gpMnuType2.Visible = Not bDisable
        For Each ctrl As Control In gpMnuType1.Controls
            If ctrl.Name = pName Then
                'ctrl.Enabled = Not bDisable
            Else
                ctrl.Enabled = bDisable
            End If
        Next
    End Sub

End Class
