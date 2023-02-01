Imports System.Data
Imports System.Windows
Imports System.Drawing.Drawing2D

Public Class frmMain

    Public Sub ExitProgram()
        'UcStatus1.StopThread()
        'If MsgBox("ท่านต้องการออกจากโปรแกรมใช่หรือไม่", vbInformation + vbYesNo) = vbYes Then
        LogOffTAS()
        Oradb.Dispose()

        mMenuStack.Clear()
        mForm.Clear()
        'Me.Close()
        mLog = Nothing
        'End
        'End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oldMeH = Me.Size.Height
        Dim oleMeW = Me.Size.Width
        SetScreenResulotion()
        'Me.WindowState = FormWindowState.Normal
        'Me.StartPosition = FormStartPosition.CenterScreen
        CheckFormResize(Me)
        'Me.WindowState = FormWindowState.Maximized
        'InitialFormTitle(Me, lblTitleName, "Main Menu")
        mMenuStack.Push("MAIN MENU")
        lblTitleName.Text = "MAIN MENU"
        InitialFormMain(Me, lblTitleName.Text)
        UcStatus1.StartThread()

        'Initial_Menu_Main()

        Initial_PanelMenu_Sub()
        Clear_Menu_Sub()

        resolution(Me, 1)
        'LoginForm1.ShowDialog()
        'Oradb = New COracle
        Timer1.Enabled = True

    End Sub

    Private Sub frmMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        UcStatus1.StopThread()
        ExitProgram()
    End Sub

    Private Sub UcClose1_OnClickClose() Handles UcClose1.OnClickClose
        'ExitProgram()
        If MsgBox("ท่านต้องการออกจากโปรแกรมใช่หรือไม่", vbInformation + vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub UcMinimize1_OnCilckMin() Handles UcMinimize1.OnCilckMin
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmMain_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
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
            Me.Hide()
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
            Me.Hide()
        End If
    End Sub
#End Region

#Region "Menu 3"
    Private Sub ucM_300_S01_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_300_S01.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
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
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_800_S05_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_800_S05.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
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
            Me.Hide()
        End If
    End Sub

    Private Sub ucM_800_S09_OnClickMnu(ByVal ucName As System.String, ByVal ucScreenID As System.Int64) Handles ucM_800_S09.OnClickMnuText
        Clear_Menu_Sub()
        If OpenForm(ucScreenID, ucName) Then
            PushForm(Me)
            Me.Hide()
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
        Timer1.Enabled = False
        LoginForm1.ShowDialog()
    End Sub

    Private Sub Initial_PanelMenu_Sub()
        Dim allCtrl As Object
        allCtrl = New Panel
        Dim allUC As New ucMenutxt_Sub

        allCtrl = From ctrl In Me.Controls.OfType(Of Panel)()
        For Each ctrl As Panel In allCtrl
            If ctrl.Name = "Panel_Sub_Menu_01" Then
                ctrl.Left = b_MenuMain1.Left - ctrl.Width
                ctrl.Top = b_MenuMain1.Top - 30
                ctrl.Width = ucM_100_S01.Width
            End If
            If ctrl.Name = "Panel_Sub_Menu_02" Then
                ctrl.Left = b_MenuMain2.Left + b_MenuMain2.Width
                ctrl.Top = b_MenuMain2.Top - 30
                ctrl.Width = ucM_200_S01.Width
            End If
            If ctrl.Name = "Panel_Sub_Menu_03" Then
                ctrl.Left = b_MenuMain3.Left + b_MenuMain3.Width
                ctrl.Top = b_MenuMain3.Top - 30
                ctrl.Width = ucM_300_S01.Width
            End If
            If ctrl.Name = "Panel_Sub_Menu_04" Then
                ctrl.Left = b_MenuMain4.Left + b_MenuMain4.Width
                ctrl.Top = b_MenuMain4.Top - 30
                ctrl.Width = ucM_400_S01.Width
            End If
            If ctrl.Name = "Panel_Sub_Menu_05" Then
                ctrl.Left = b_MenuMain5.Left + b_MenuMain5.Width
                ctrl.Top = b_MenuMain5.Top - 30
                ctrl.Width = ucM_500_S01.Width
            End If
            If ctrl.Name = "Panel_Sub_Menu_06" Then
                ctrl.Left = b_MenuMain6.Left + b_MenuMain6.Width
                ctrl.Top = b_MenuMain6.Top - 30
                ctrl.Width = ucM_600_S01.Width
            End If
            If ctrl.Name = "Panel_Sub_Menu_07" Then
                ctrl.Left = b_MenuMain7.Left + b_MenuMain7.Width
                ctrl.Top = b_MenuMain6.Top + b_MenuMain6.Height - ctrl.Height + 210
                'ctrl.Top = b_MenuMain8.Top + b_MenuMain8.Height - ctrl.Height + 30
                'If (ctrl.Top + ctrl.Height) > (Me.Size.Height - 150) Then
                '    ctrl.Top = ctrl.Top - ((ctrl.Top + ctrl.Height) - Me.Size.Height) - 300
                'End If
            End If
            If ctrl.Name = "Panel_Sub_Menu_08" Then
                ctrl.Left = b_MenuMain8.Left - ctrl.Width
                ctrl.Top = b_MenuMain8.Top - 30
                ctrl.Width = ucM_800_S01.Width
                'If (ctrl.Top + ctrl.Height) > (Me.Size.Height - 150) Then
                '    ctrl.Top = ctrl.Top - ((ctrl.Top + ctrl.Height) - Me.Size.Height) - 300
                'End If
            End If
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

        strSQL = _
            "select S.STATUS_VARCHAR,S.DESCRIPTION " & _
            "from STATUS_DESC S " & _
            "where S.T_NAME='REPORT_HEADERS' " & _
            " and S.STATUS_VARCHAR in('D','M','Y','Z') " & _
            "order by S.STATUS_VARCHAR"

        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0

            TreeReport.Nodes.Clear()

            Do While dt.Rows.Count > i
                'TreeReport.Nodes.Clear()
                Dim node As New List(Of TreeNode)
                node.Add(TreeReport.Nodes.Add(dt.Rows(i).Item("DESCRIPTION").ToString, dt.Rows(i).Item("DESCRIPTION").ToString))

                strSQL2 = _
                    "select H.HEADER_ID,H.HEADER_NAME,count(R.REPORT_ID) as NUMREPORT " & _
                     "from REPORT_HEADERS H,REPORT_SETTING R " & _
                     "where H.HEADER_ID=R.HEADER_ID(+) " & _
                     "and H.REPORT_TYPE= '" & dt.Rows(i).Item("STATUS_VARCHAR").ToString & "' " & _
                     "group by H.HEADER_ID,H.HEADER_NAME"

                If Oradb.OpenDys(strSQL2, "TableName2", mDataSet2) Then
                    dt2 = mDataSet2.Tables("TableName2")
                    j = 0
                    Do While dt2.Rows.Count > j
                        node(0).Nodes.Add(dt2.Rows(j).Item("HEADER_ID").ToString, dt2.Rows(j).Item("HEADER_NAME").ToString)
                        j = j + 1
                    Loop
                End If
                i = i + 1
            Loop
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
                Dim ciF As New frmrptOilLoading
                ciF.ShowDialog()

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
                Dim ciJ As New frmrptDepHighwayTotalOfMonth
                ciJ.ShowDialog()

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
        allCtrl = From ctrl In Me.Controls.OfType(Of Panel)()
        For Each ctrl As Panel In allCtrl
            If ctrl.Visible Then
                ctrl.Visible = False
            End If
        Next
        allCtrl = Nothing
    End Sub

    Private Sub b_MenuMain1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_MenuMain1.MouseHover
        Clear_Menu_Main()
        b_MenuMain1.BackgroundImage = My.Resources.BGMenu1
        Clear_Menu_Sub()
        Panel_Sub_Menu_01.Visible = True
    End Sub

    Private Sub b_MenuMain2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_MenuMain2.MouseHover
        Clear_Menu_Main()
        b_MenuMain2.BackgroundImage = My.Resources.BGMenu1
        Clear_Menu_Sub()
        Panel_Sub_Menu_02.Visible = True
    End Sub

    Private Sub b_MenuMain3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_MenuMain3.MouseHover
        Clear_Menu_Main()
        b_MenuMain3.BackgroundImage = My.Resources.BGMenu1
        Clear_Menu_Sub()
        Panel_Sub_Menu_03.Visible = True
    End Sub

    Private Sub b_MenuMain4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_MenuMain4.MouseHover
        Clear_Menu_Main()
        b_MenuMain4.BackgroundImage = My.Resources.BGMenu1
        Clear_Menu_Sub()
        Panel_Sub_Menu_04.Visible = True
    End Sub

    Private Sub b_MenuMain5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_MenuMain5.MouseHover
        Clear_Menu_Main()
        b_MenuMain5.BackgroundImage = My.Resources.BGMenu1
        Clear_Menu_Sub()
        Panel_Sub_Menu_05.Visible = True
    End Sub

    Private Sub b_MenuMain6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_MenuMain6.MouseHover
        Clear_Menu_Main()
        b_MenuMain6.BackgroundImage = My.Resources.BGMenu1
        Clear_Menu_Sub()
        Panel_Sub_Menu_06.Visible = True
    End Sub

    Private Sub b_MenuMain7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_MenuMain7.MouseHover
        Clear_Menu_Main()
        b_MenuMain7.BackgroundImage = My.Resources.BGMenu1
        Clear_Menu_Sub()
        InitialTreeReport()
        Panel_Sub_Menu_07.Visible = True
    End Sub

    Private Sub b_MenuMain8_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles b_MenuMain8.MouseHover
        Clear_Menu_Main()
        b_MenuMain8.BackgroundImage = My.Resources.BGMenu1
        Clear_Menu_Sub()
        Panel_Sub_Menu_08.Visible = True
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
End Class
