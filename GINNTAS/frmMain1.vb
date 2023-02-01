Imports System.Data
Imports System.Windows
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class frmMain1
    Dim mOffsetPosition As Integer
    Dim mDisplayMenu As Integer

    Public Sub ExitProgram()
        'UcStatus1.StopThread()
        'If MsgBox("ท่านต้องการออกจากโปรแกรมใช่หรือไม่", vbInformation + vbYesNo) = vbYes Then
        LogOffTAS()
        'Oradb.Dispose()
        Oradb = Nothing
        mMenuStack.Clear()
        mForm.Clear()
        'Me.Close()
        mLog = Nothing
        'End
        'End If
    End Sub

    Private Sub frmMain1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim oldMeH = Me.Size.Height
        'Dim oleMeW = Me.Size.Width
        lbVersion.Text = GetVersion()
        SetScreenResulotion()
        mOffsetPosition = Panel1.Top
        'Me.WindowState = FormWindowState.Normal
        'Me.StartPosition = FormStartPosition.CenterScreen
        CheckFormResize(Me)
        'Me.WindowState = FormWindowState.Maximized
        'InitialFormTitle(Me, lblTitleName, "Main Menu")
        mMenuStack.Push("MAIN MENU")
        'lblTitleName.Text = "MAIN MENU"
        'InitialFormMain(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        'Initial_Menu_Main()

        Initial_PanelMenu_Sub()
        Clear_Menu_Sub()
        'resolution(Me, 1)
        'LoginForm1.ShowDialog()
        'Oradb = New COracle
        Timer1.Enabled = True

    End Sub

    Private Sub frmMain1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        ExitProgram()
        End
    End Sub

    Private Sub UcClose1_OnClickClose()
        'ExitProgram()
        If MsgBox("ท่านต้องการออกจากโปรแกรมใช่หรือไม่", vbInformation + vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmMain1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        'CheckFormResize(Me)
    End Sub

#Region " menu sub event OnClick "
#Region "Menu 1"
    Private Sub ucM_100_S01_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_100_S01.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_100_S02_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_100_S02.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_100_S03_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_100_S03.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_100_S04_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_100_S04.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_100_S05_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_100_S05.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_100_S06_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_100_S06.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_100_S07_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_100_S07.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_100_S08_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_100_S08.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_100_S09_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_100_S09.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_100_S10_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_100_S10.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_100_S11_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_100_S11.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_100_S12_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_100_S12.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub
#End Region

#Region "Menu 2"
    Private Sub ucM_200_S01_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_200_S01.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_200_S02_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_200_S02.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_200_S03_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_200_S03.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_200_S04_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_200_S04.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_200_S05_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_200_S05.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_200_S06_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_200_S06.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            'Me.Hide()
        End If
    End Sub

    Private Sub ucM_200_S07_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_200_S07.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_200_S08_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_200_S08.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_200_S09_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_200_S09.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_200_S10_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_200_S10.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            'Me.Hide()
        End If
    End Sub
#End Region

#Region "Menu 3"
    Private Sub ucM_300_S01_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_300_S01.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            'Me.Hide()
        End If
    End Sub

    Private Sub ucM_300_S02_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_300_S02.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_300_S03_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_300_S03.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_300_S04_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_300_S04.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_300_S05_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_300_S05.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_300_S06_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_300_S06.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_300_S07_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_300_S07.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_300_S08_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_300_S08.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_300_S09_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_300_S09.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_300_S10_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_300_S10.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_300_S11_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_300_S11.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub
#End Region

#Region "Menu 4"
    Private Sub ucM_400_S01_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_400_S01.OnClickMnuText
        'Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            'PushForm(Me)
            Me.Hide()
            PushForm(Me)
        End If
    End Sub

    Private Sub ucM_400_S02_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_400_S02.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_400_S03_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_400_S03.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_400_S04_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_400_S04.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_400_S05_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_400_S05.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_400_S06_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_400_S06.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_400_S07_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_400_S07.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub
#End Region

#Region "Menu 5"
    Private Sub ucM_500_S01_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_500_S01.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub


    Private Sub ucM_500_S02_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_500_S02.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_500_S03_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_500_S03.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_500_S04_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_500_S04.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_500_S05_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_500_S05.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_500_S06_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_500_S06.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub
#End Region

#Region "Menu 6"
    Private Sub ucM_600_S01_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_600_S01.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_600_S02_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_600_S02.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_600_S03_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_600_S03.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

#End Region

#Region "Menu 8"
    Private Sub ucM_800_S01_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_800_S01.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_800_S02_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_800_S02.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_800_S03_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_800_S03.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_800_S04_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_800_S04.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            'Me.Hide()
        End If
    End Sub

    Private Sub ucM_800_S05_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_800_S05.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            'Me.Hide()
        End If
    End Sub

    Private Sub ucM_800_S06_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_800_S06.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_800_S07_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_800_S07.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_800_S08_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_800_S08.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            'Me.Hide()
        End If
    End Sub

    Private Sub ucM_800_S09_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_800_S09.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            'Me.Hide()
        End If
    End Sub
#End Region
#End Region

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Dim vSource As String = "", vNewFileName As String = "abc"
    '    OpenPictureDriver(vSource)
    '    If vSource <> "" Then
    '        CopyPictureDriver(vSource, vNewFileName)
    '        'DeletePictureDriver(vSource)
    '    End If

    '    frmType2.Show()
    'End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        Timer1.Enabled = False
        LoginForm1.ShowDialog()
        If mLogInSuccess Then
            InitialTreeReport2()
        End If
    End Sub

    Private Sub Initial_PanelMenu_Sub()
        Dim allCtrl As Object
        allCtrl = New Panel
        Dim allUC As New ucMenutxt_Sub

        allCtrl = From ctrl In Me.Controls.OfType(Of Panel)() Where ctrl.Name.ToLower.IndexOf("menu") > 0
        For Each ctrl As Panel In allCtrl
            If ctrl.Name = "Panel_Sub_Menu_01" Then
                ctrl.Width = ucM_100_S01.Width
                ctrl.Left = UcMenutxtMain1.Left - ctrl.Width
                ctrl.Top = UcMenutxtMain1.Top + mOffsetPosition
            End If
            If ctrl.Name = "Panel_Sub_Menu_02" Then
                ctrl.Width = ucM_200_S01.Width
                ctrl.Left = UcMenutxtMain2.Left + UcMenutxtMain2.Width
                ctrl.Top = UcMenutxtMain2.Top + mOffsetPosition
            End If
            If ctrl.Name = "Panel_Sub_Menu_03" Then
                ctrl.Width = ucM_300_S01.Width
                ctrl.Left = UcMenutxtMain3.Left + UcMenutxtMain3.Width
                ctrl.Top = UcMenutxtMain3.Top - 30 + mOffsetPosition
            End If
            If ctrl.Name = "Panel_Sub_Menu_04" Then
                ctrl.Width = ucM_400_S01.Width
                ctrl.Left = UcMenutxtMain4.Left + UcMenutxtMain4.Width
                ctrl.Top = UcMenutxtMain4.Top - 30 + mOffsetPosition
            End If
            If ctrl.Name = "Panel_Sub_Menu_05" Then
                ctrl.Width = ucM_500_S01.Width
                ctrl.Left = UcMenutxtMain5.Left + UcMenutxtMain5.Width
                ctrl.Top = UcMenutxtMain5.Top - 30 + mOffsetPosition
            End If
            If ctrl.Name = "Panel_Sub_Menu_06" Then
                ctrl.Width = ucM_600_S01.Width
                ctrl.Left = UcMenutxtMain6.Left + UcMenutxtMain6.Width
                ctrl.Top = UcMenutxtMain6.Top - 30 + mOffsetPosition
            End If
            If ctrl.Name = "Panel_Sub_Menu_07" Then
                ctrl.Left = UcMenutxtMain7.Left + UcMenutxtMain7.Width
                ctrl.Top = UcMenutxtMain1.Top + mOffsetPosition
                'If ctrl.Top + ctrl.Height >= UcStatus1.Top Then
                '    ctrl.Top = UcStatus1.Top - ctrl.Height
                'End If
                'ctrl.Top = b_MenuMain8.Top + b_MenuMain8.Height - ctrl.Height + 30
                'If (ctrl.Top + ctrl.Height) > (Me.Size.Height - 150) Then
                '    ctrl.Top = ctrl.Top - ((ctrl.Top + ctrl.Height) - Me.Size.Height) - 300
                'End If
            End If
            If ctrl.Name = "Panel_Sub_Menu_08" Then
                ctrl.Width = ucM_800_S01.Width
                ctrl.Left = UcMenutxtMain8.Left - ctrl.Width
                ctrl.Top = UcMenutxtMain8.Top - 30 + mOffsetPosition
                'If (ctrl.Top + ctrl.Height) > (Me.Size.Height - 150) Then
                '    ctrl.Top = ctrl.Top - ((ctrl.Top + ctrl.Height) - Me.Size.Height) - 300
                'End If
            End If
            ctrl.BackgroundImage = Nothing
            ctrl.BringToFront()
        Next
        allCtrl = Nothing
    End Sub

    'Private Sub frmMain_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseClick

    '    Dim allCtrl As Object
    '    allCtrl = New Panel
    '    allCtrl = From ctrl In Me.Controls.OfType(Of Panel)()
    '    For Each ctrl As Panel In allCtrl
    '        If ctrl.Visible Then
    '            ctrl.Visible = False
    '        End If
    '    Next
    '    allCtrl = Nothing


    '    'Dim allCtrl As Object
    '    allCtrl = New ucMenutxt_Main
    '    allCtrl = From ctrl In Me.Controls.OfType(Of ucMenutxt_Main)()
    '    For Each ctrl As ucMenutxt_Main In allCtrl
    '        ctrl.BackgroundImage = My.Resources.BGMenu_N
    '    Next
    '    allCtrl = Nothing

    'End Sub

    Public Sub InitialTreeReport()
        Dim strSQL As String
        Dim strSQL2 As String
        Dim mDataSet As New DataSet
        Dim mDataSet2 As New DataSet
        Dim dt As DataTable
        Dim dt2 As DataTable
        Dim i As Integer = 0
        Dim j As Integer = 0

        Dim myImagelist As New ImageList()
        myImagelist.Images.Add(Image.FromFile(GetCurrDirectory() + "\\pictures\\folder.png"))
        myImagelist.Images.Add(Image.FromFile(GetCurrDirectory() + "\\pictures\\pdf_24.png"))

        strSQL =
            "select S.STATUS_VARCHAR,S.DESCRIPTION " &
            "from STATUS_DESC S " &
            "where S.T_NAME='REPORT_HEADERS' " &
            " and S.STATUS_VARCHAR in('D','M','Y','Z') " &
            "order by S.STATUS_VARCHAR"

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0

            TreeReport.Nodes.Clear()
            TreeReport.ImageList = myImagelist
            Do While dt.Rows.Count > i
                'TreeReport.Nodes.Clear()
                Dim node As New List(Of TreeNode)
                node.Add(TreeReport.Nodes.Add(dt.Rows(i).Item("DESCRIPTION").ToString, dt.Rows(i).Item("DESCRIPTION").ToString))

                strSQL2 =
                    "select H.HEADER_ID,H.HEADER_NAME,count(R.REPORT_ID) as NUMREPORT " &
                     "from REPORT_HEADERS H,REPORT_SETTING R " &
                     "where H.HEADER_ID=R.HEADER_ID(+) " &
                     "and H.REPORT_TYPE= '" & dt.Rows(i).Item("STATUS_VARCHAR").ToString & "' " &
                     "group by H.HEADER_ID,H.HEADER_NAME"

                If Oradb.OpenDys(strSQL2, "TableName2", mDataSet2) Then
                    dt2 = mDataSet2.Tables("TableName2")
                    j = 0
                    Do While dt2.Rows.Count > j
                        Dim child As New TreeNode()
                        node(0).Nodes.Add(dt2.Rows(j).Item("HEADER_ID").ToString, dt2.Rows(j).Item("HEADER_NAME").ToString)


                        child.Text = (dt2.Rows(j).Item("HEADER_NAME").ToString)
                        child.ImageIndex = 1
                        child.Collapse()



                        j = j + 1
                    Loop
                End If
                i = i + 1
            Loop
            TreeReport.ExpandAll()

        End If
    End Sub

    Public Sub InitialTreeReport2()
        Dim strSQL As String
        Dim strSQL2 As String
        Dim mDataSet As New DataSet
        Dim mDataSet2 As New DataSet
        Dim dt As DataTable
        Dim dt2 As DataTable
        Dim i As Integer = 0
        Dim j As Integer = 0

        Dim myImagelist As New ImageList()
        myImagelist.Images.Add(Image.FromFile(GetCurrDirectory() + "\\pictures\\folder.png"))
        myImagelist.Images.Add(Image.FromFile(GetCurrDirectory() + "\\pictures\\pdf_24.png"))

        strSQL =
            "select S.STATUS_VARCHAR,S.DESCRIPTION " &
            "from STATUS_DESC S " &
            "where S.T_NAME='REPORT_HEADERS' " &
            " and S.STATUS_VARCHAR in('D','M','Y','Z') " &
            "order by S.STATUS_VARCHAR"

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0

            TreeReport.Nodes.Clear()
            Do While dt.Rows.Count > i
                'TreeReport.Nodes.Clear()
                Dim node As New List(Of TreeNode)
                node.Add(TreeReport.Nodes.Add(dt.Rows(i).Item("DESCRIPTION").ToString, dt.Rows(i).Item("DESCRIPTION").ToString))

                strSQL2 =
                    "select H.HEADER_ID,H.HEADER_NAME,count(R.REPORT_ID) as NUMREPORT " &
                     "from REPORT_HEADERS H,REPORT_SETTING R " &
                     "where H.HEADER_ID=R.HEADER_ID(+) " &
                     "and H.REPORT_TYPE= '" & dt.Rows(i).Item("STATUS_VARCHAR").ToString & "' " &
                     "group by H.HEADER_ID,H.HEADER_NAME"

                If Oradb.OpenDys(strSQL2, "TableName2", mDataSet2) Then
                    dt2 = mDataSet2.Tables("TableName2")
                    j = 0
                    TreeReport.ImageIndex = 1
                    TreeReport.ImageList = myImagelist

                    Do While dt2.Rows.Count > j
                        'Dim child As New TreeNode()
                        node(0).Nodes.Add(dt2.Rows(j).Item("HEADER_ID").ToString, dt2.Rows(j).Item("HEADER_NAME").ToString)
                        j = j + 1
                    Loop
                End If
                i = i + 1
            Loop
            TreeReport.ExpandAll()

        End If
    End Sub

    Private Sub TreeReport_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeReport.DoubleClick
        Select Case TreeReport.SelectedNode.Name
            Case Is = "52010031"
                Dim csA As New frmrptDepHighway
                csA.ShowDialog()

            Case Is = "52010005"
                Dim csB As New frmrptMeterDay
                csB.ShowDialog()

            Case Is = "52010035"
                Dim csC As New frmrptProductOfMeter
                csC.ShowDialog()

            Case Is = "52010036"
                Dim csD As New frmrptDepHighwayTotal
                csD.ShowDialog()

            Case Is = "52010001"
                Dim csF As New frmrptOilLoading
                csF.ShowDialog()

            Case Is = "52010007"
                Dim csG As New frmrptStatusOftank
                csG.ShowDialog()

            Case Is = "52010030"
                Dim csH As New frmrptEndOfDay
                csH.ShowDialog()

            Case Is = "52010006"
                Dim csI As New frmrptMeterThruoghput
                csI.ShowDialog()

            Case Is = "52010023"
                Dim ciJ As New frmrptWeight
                ciJ.ShowDialog()

            Case Is = "52010037"
                Dim csK As New frmrptTopup
                csK.ShowDialog()

            Case Is = "52010029"
                Dim csL As New frmrptProductDelivery
                csL.ShowDialog()

                '***********************รายงานประจำเดือน*************************
            Case Is = "52010032"
                Dim csJ As New frmrptDepHighwayTotalOfMonth
                csJ.ShowDialog()

            Case Is = "52010033"
                Dim csK As New frmrptProductOfMonth
                csK.ShowDialog()

            Case Is = "52010010"
                Dim csL As New frmrptOilTankOfMonth
                csL.ShowDialog()

                '***********************รายงานประจำปี*************************
            Case Is = "52010034"
                Dim csK As New frmrptProductOfYear
                csK.ShowDialog()

            Case Is = "52010013"
                Dim csL As New frmrptOilTankOfYear
                csL.ShowDialog()

        End Select
    End Sub

#Region "Display menu items"
    Private Sub Clear_Menu_Main()
        Dim allCtrl As Object
        allCtrl = New Button
        allCtrl = From ctrl In Me.Controls.OfType(Of Button)()
        For Each ctrl As Button In allCtrl
            ctrl.BackgroundImage = My.Resources.BGMenu_N
        Next
        allCtrl = Nothing
    End Sub

    Private Sub Clear_Menu_Sub()
        Dim allCtrl As Object
        allCtrl = New Panel
        allCtrl = From ctrl In Me.Controls.OfType(Of Panel)() Where ctrl.Name.ToLower.IndexOf("menu") > 0
        For Each ctrl As Panel In allCtrl
            If ctrl.Visible Then
                ctrl.Visible = False
            End If
        Next
        allCtrl = Nothing
    End Sub

    'Private Sub Initial_Menu_Main()
    '    If fSize.Height > 768 And fSize.Width > 1024 Then
    '        Dim allCtrl As Object
    '        allCtrl = New Button
    '        allCtrl = From ctrl In Me.Controls.OfType(Of Button)()
    '        For Each ctrl As Button In allCtrl
    '            If ctrl.Name = "b_MenuMain1" Then
    '                ctrl.Image = My.Resources._64_icon_01_setup
    '            End If
    '            If ctrl.Name = "b_MenuMain2" Then
    '                ctrl.Image = My.Resources._64_icon_02_monitor
    '            End If
    '            If ctrl.Name = "b_MenuMain3" Then
    '                ctrl.Image = My.Resources._64_icon_03_mmi
    '            End If
    '            If ctrl.Name = "b_MenuMain4" Then
    '                ctrl.Image = My.Resources._64_icon_04_masterdata
    '            End If
    '            If ctrl.Name = "b_MenuMain5" Then
    '                ctrl.Image = My.Resources._64_icon_05_deliverysetup
    '            End If
    '            If ctrl.Name = "b_MenuMain6" Then
    '                ctrl.Image = My.Resources._64_icon_06_receiversetup
    '            End If
    '            If ctrl.Name = "b_MenuMain7" Then
    '                ctrl.Image = My.Resources._64_icon_07_print
    '            End If
    '            If ctrl.Name = "b_MenuMain8" Then
    '                ctrl.Image = My.Resources._64_icon_08_utilities
    '            End If
    '        Next
    '        allCtrl = Nothing
    '    End If

    'End Sub

    Private Sub SetDisplayMainMenu()
        UcMenutxtMain1.ShowMouseLeave()
        UcMenutxtMain2.ShowMouseLeave()
        UcMenutxtMain3.ShowMouseLeave()
        UcMenutxtMain4.ShowMouseLeave()
        UcMenutxtMain5.ShowMouseLeave()
        UcMenutxtMain6.ShowMouseLeave()
        UcMenutxtMain7.ShowMouseLeave()
        UcMenutxtMain8.ShowMouseLeave()


        Select Case mDisplayMenu
            Case 1
                UcMenutxtMain1.ShowMouseHover()
            Case 2
                UcMenutxtMain2.ShowMouseHover()
            Case 3
                UcMenutxtMain3.ShowMouseHover()
            Case 4
                UcMenutxtMain4.ShowMouseHover()
            Case 5
                UcMenutxtMain5.ShowMouseHover()
            Case 6
                UcMenutxtMain6.ShowMouseHover()
            Case 7
                UcMenutxtMain7.ShowMouseHover()
            Case 8
                UcMenutxtMain8.ShowMouseHover()
            Case Else

        End Select

    End Sub
#End Region
#Region "mousehover and mouseleave"
    Private Sub UcMenutxtMain1_OnMouseHoverMnuText() Handles UcMenutxtMain1.OnMouseHoverMnuText
        mDisplayMenu = 1
        SetDisplayMainMenu()
        Clear_Menu_Sub()
        Panel_Sub_Menu_01.Visible = True
    End Sub

    Private Sub UcMenutxtMain1_OnMouseLeaveMnuText() Handles UcMenutxtMain2.OnMouseLeaveMnuText, UcMenutxtMain8.OnMouseLeaveMnuText, UcMenutxtMain1.OnMouseLeaveMnuText

    End Sub

    Private Sub UcMenutxtMain2_OnMouseHoverMnuText() Handles UcMenutxtMain2.OnMouseHoverMnuText
        mDisplayMenu = 2
        SetDisplayMainMenu()
        Clear_Menu_Sub()
        Panel_Sub_Menu_02.Visible = True
    End Sub

    Private Sub UcMenutxtMain2_OnMouseLeaveMnuText()

    End Sub

    Private Sub UcMenutxtMain3_OnMouseHoverMnuText() Handles UcMenutxtMain3.OnMouseHoverMnuText
        mDisplayMenu = 3
        SetDisplayMainMenu()
        Clear_Menu_Sub()
        Panel_Sub_Menu_03.Visible = True
    End Sub

    Private Sub UcMenutxtMain3_OnMouseLeaveMnuText() Handles UcMenutxtMain3.OnMouseLeaveMnuText

    End Sub

    Private Sub UcMenutxtMain4_OnMouseHoverMnuText() Handles UcMenutxtMain4.OnMouseHoverMnuText
        mDisplayMenu = 4
        SetDisplayMainMenu()
        Clear_Menu_Sub()
        Panel_Sub_Menu_04.Visible = True
    End Sub

    Private Sub UcMenutxtMain4_OnMouseLeaveMnuText() Handles UcMenutxtMain4.OnMouseLeaveMnuText

    End Sub

    Private Sub UcMenutxtMain5_OnMouseHoverMnuText() Handles UcMenutxtMain5.OnMouseHoverMnuText
        mDisplayMenu = 5
        SetDisplayMainMenu()
        Clear_Menu_Sub()
        Panel_Sub_Menu_05.Visible = True
    End Sub

    Private Sub UcMenutxtMain5_OnMouseLeaveMnuText() Handles UcMenutxtMain5.OnMouseLeaveMnuText

    End Sub

    Private Sub UcMenutxtMain6_OnMouseHoverMnuText() Handles UcMenutxtMain6.OnMouseHoverMnuText
        mDisplayMenu = 6
        SetDisplayMainMenu()
        Clear_Menu_Sub()
        Panel_Sub_Menu_06.Visible = True
    End Sub

    Private Sub UcMenutxtMain6_OnMouseLeaveMnuText() Handles UcMenutxtMain6.OnMouseLeaveMnuText

    End Sub

    Private Sub UcMenutxtMain7_OnMouseHoverMnuText() Handles UcMenutxtMain7.OnMouseHoverMnuText
        'Initial_PanelMenu_Sub()
        mDisplayMenu = 7
        SetDisplayMainMenu()
        Clear_Menu_Sub()
        Panel_Sub_Menu_07.Visible = True
    End Sub

    Private Sub UcMenutxtMain7_OnMouseLeaveMnuText() Handles UcMenutxtMain7.OnMouseLeaveMnuText

    End Sub

    Private Sub UcMenutxtMain8_OnMouseHoverMnuText() Handles UcMenutxtMain8.OnMouseHoverMnuText
        mDisplayMenu = 8
        SetDisplayMainMenu()
        Clear_Menu_Sub()
        Panel_Sub_Menu_08.Visible = True
    End Sub

    Private Sub UcMenutxtMain8_OnMouseLeaveMnuText()

    End Sub

    Private Sub frmMain1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        mDisplayMenu = 0
        Clear_Menu_Sub()
        SetDisplayMainMenu()
    End Sub

    Private Sub Panel1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        mDisplayMenu = 0
        Clear_Menu_Sub()
        SetDisplayMainMenu()
    End Sub
#End Region

    Private Sub UcHeader1_MinimizeButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.MinimizeButtonClick
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub UcHeader1_CloseButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.CloseButtonClick
        If MsgBox("ท่านต้องการออกจากโปรแกรมใช่หรือไม่", vbInformation + vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PicLogOFF.MouseHover
        PicLogOFF.Image = My.Resources.ResourceManager.GetObject("LOGOUT")
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PicLogOFF.MouseLeave
        PicLogOFF.Image = My.Resources.ResourceManager.GetObject("LOGOUT1")
    End Sub



    Private Sub picMONITORING_MouseHover(sender As Object, e As EventArgs) Handles picMONITORING.MouseHover
        mDisplayMenu = 2
        SetDisplayMainMenu()
        Clear_Menu_Sub()
        Panel_Sub_Menu_02.Visible = True
    End Sub

    Private Sub picDisplay_MouseHover(sender As Object, e As EventArgs) Handles picDisplay.MouseHover
        mDisplayMenu = 3
        SetDisplayMainMenu()
        Clear_Menu_Sub()
        Panel_Sub_Menu_03.Visible = True
    End Sub

    Private Sub picDatabase_MouseHover(sender As Object, e As EventArgs) Handles picDatabase.MouseHover
        mDisplayMenu = 4
        SetDisplayMainMenu()
        Clear_Menu_Sub()
        Panel_Sub_Menu_04.Visible = True
    End Sub

    Private Sub picDo_Setup_MouseHover(sender As Object, e As EventArgs) Handles picDo_Setup.MouseHover
        mDisplayMenu = 5
        SetDisplayMainMenu()
        Clear_Menu_Sub()
        Panel_Sub_Menu_05.Visible = True
    End Sub

    Private Sub picInventory_MouseHover(sender As Object, e As EventArgs) Handles picInventory.MouseHover
        mDisplayMenu = 6
        SetDisplayMainMenu()
        Clear_Menu_Sub()
        Panel_Sub_Menu_06.Visible = True
    End Sub

    Private Sub picPrintReport_MouseHover(sender As Object, e As EventArgs) Handles picPrintReport.MouseHover
        mDisplayMenu = 7
        SetDisplayMainMenu()
        Clear_Menu_Sub()
        Panel_Sub_Menu_07.Visible = True
    End Sub

    Private Sub picSystemSetup_MouseHover(sender As Object, e As EventArgs) Handles picSystemSetup.MouseHover
        mDisplayMenu = 1
        SetDisplayMainMenu()
        Clear_Menu_Sub()
        Panel_Sub_Menu_01.Visible = True
    End Sub

    Private Sub PicUtilites_MouseHover(sender As Object, e As EventArgs) Handles PicUtilites.MouseHover
        mDisplayMenu = 8
        SetDisplayMainMenu()
        Clear_Menu_Sub()
        Panel_Sub_Menu_08.Visible = True
    End Sub

    Private Sub PicLogOFF_Click(sender As Object, e As EventArgs) Handles PicLogOFF.Click
        If MsgBox("ท่านต้องการ LogOFF ใช่หรือไม่", vbInformation + vbYesNo) = vbYes Then
            LogOffTAS()
            mUserName = "???????"
            LoginForm1.Close()
            LoginForm1.ShowDialog()
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


    End Sub

    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        Clear_Menu_Sub()
    End Sub
End Class
