Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmUtlSecurity
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=add ,2=Edit
    Dim gGroup As Long

    Private Sub frmUtlSecurity_main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmUtlSecurity_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        'Initial_frm()
        initialVisible_menu()
        Show_Data(0)
    End Sub

    Private Sub frmUtlSecurity_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose()
        Me.Close()
    End Sub

    Private Sub Initial_frm()
        frm_work = 0
        DataGridView1.Left = (Me.Width * 8) / 100
        DataGridView1.Width = Me.Width - (DataGridView1.Left * 3)
        DataGridView1.Top = 150
        DataGridView1.Height = (Me.Height / 2) + (DataGridView1.Height / 2)

        'UcInsert1.Left = (DataGridView1.Left * 1.5) + DataGridView1.Width
        'UcInsert1.Top = DataGridView1.Top
        'UcEdit1.Left = UcInsert1.Left
        'UcEdit1.Top = UcInsert1.Top + 100
        'UcDelete1.Left = UcInsert1.Left
        'UcDelete1.Top = UcInsert1.Top + 200
        'UcSearch1.Left = UcInsert1.Left
        'UcSearch1.Top = UcInsert1.Top + 300
        'UcReflesh1.Left = UcInsert1.Left
        'UcReflesh1.Top = UcInsert1.Top + 400
    End Sub

    Public Sub Show_Data(ByVal PriorityID As Long)
        Dim sql_str, sql_str2, str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim checkPermiss As Boolean, checkConfirmPw As Boolean
        sql_str =
                "select S.SCREEN_ID,S.SUB_ID,S.MAIN_MENU,S.SUB_MENU, 0 as PERMISSION, 0 as CONFIRM_PASSWORD " &
                "from TAS.SCREEN S " &
                "order by S.SCREEN_ID,S.SUB_ID"
        sql_str2 =
             "select S.SCREEN_ID,S.SUB_ID,S.MAIN_MENU,S.SUB_MENU,C.PERMISSION,C.CONFIRM_PASSWORD " &
             "from SCREEN S,SECURITY C " &
             "where S.SCREEN_ID = C.SCREEN_ID " &
             "and S.SUB_ID=C.SUB_ID " &
             "and S.IS_ENABLED=1 " &
             "and C.PRIORITY=" & PriorityID & " " &
             "order by S.SCREEN_ID,S.SUB_ID"
        If PriorityID > 0 Then
            str = sql_str2
        Else
            str = sql_str
        End If
        If Oradb.OpenDys(str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            'i = 0
            'DataGridView1.RowCount = 0
            'txtTotalRecord.Text = dt.Rows.Count
            'Do While dt.Rows.Count > i
            '    DataGridView1.RowCount = DataGridView1.RowCount + 1
            '    DataGridView1.Rows.Item(i).Height = Grid_Height
            '    DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SCREEN_ID")), "", dt.Rows(i).Item("SCREEN_ID").ToString)
            '    DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SUB_ID")), "", dt.Rows(i).Item("SUB_ID").ToString)
            '    DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("MAIN_MENU")), "", dt.Rows(i).Item("MAIN_MENU").ToString)
            '    DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("SUB_MENU")), "", dt.Rows(i).Item("SUB_MENU").ToString)
            '    If PriorityID > 0 Then 'เมือกดเลือก Group User
            '        checkPermiss = dt.Rows(i).Item("PERMISSION")
            '        checkConfirmPw = dt.Rows(i).Item("CONFIRM_PASSWORD")
            '        DataGridView1.Item(4, i).Value = checkPermiss
            '        DataGridView1.Item(5, i).Value = checkConfirmPw
            '    End If
            '    i = i + 1
            'Loop

            DataGridView1.AutoGenerateColumns = False
            'DataGridView1.DataSource = dt
            'DataGridView1.DataMember = "TableName1"
            DataGridView1.Rows.Clear()
            For Each dr As DataRow In dt.Rows
                checkPermiss = dr("PERMISSION")
                checkConfirmPw = dr("CONFIRM_PASSWORD")
                Dim row As String() = New String() {dr("SCREEN_ID"), dr("SUB_ID"), dr("MAIN_MENU"), dr("SUB_MENU"), checkPermiss, checkConfirmPw}
                DataGridView1.Rows.Add(row)
            Next

            txtTotalRecord.Text = dt.Rows.Count
        Else
        End If
        mDataSet = Nothing
    End Sub
    Public Sub Select_Show_Data(ByVal PriorityID As Long)
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim checkPermiss As Boolean, checkConfirmPw As Boolean
        sql_str = _
              "select C.PERMISSION,C.CONFIRM_PASSWORD " & _
            "from SCREEN S,SECURITY C " & _
            "where S.SCREEN_ID = C.SCREEN_ID " & _
            "and S.SUB_ID=C.SUB_ID " & _
            "and S.IS_ENABLED=1 " & _
            "and C.PRIORITY=" & PriorityID & " " & _
            "order by S.SCREEN_ID,S.SUB_ID"
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView1.RowCount = 0
            Do While dt.Rows.Count > i
                checkPermiss = dt.Rows(i).Item("PERMISSION")
                checkConfirmPw = dt.Rows(i).Item("CONFIRM_PASSWORD")
                DataGridView1.RowCount = DataGridView1.RowCount + 1
                DataGridView1.Rows.Item(i).Height = Grid_Height
                DataGridView1.Item(4, i).Value = checkPermiss
                DataGridView1.Item(5, i).Value = checkConfirmPw

                    i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
    End Sub

    Private Function appendZero(ByVal codeColour As String) As String
        Dim i As Integer = 6 - codeColour.Length
        While (i <> 0)
            codeColour = "0" + codeColour
            i = i - 1
        End While
        Return codeColour
    End Function

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Function EditData(ByVal PriorityID As Long) As Boolean
        Dim strSQL As String
        Dim i As Integer = 0
        Dim result As Integer = MessageBox.Show("ท่านต้องบันทึกข้อมูลของ " & lblPriorityName.Text & " หรือไม่", "System TAS", MessageBoxButtons.YesNo)
        If result Then
            Do While DataGridView1.RowCount > i
                strSQL = _
                    "update SECURITY S set " & _
                        "S.PERMISSION=" & IIf((DataGridView1.Item(4, i).Value = True), "1", "0") & "," & _
                        "S.CONFIRM_PASSWORD=" & IIf((DataGridView1.Item(5, i).Value = True), "1", "0") & "," & _
                        "S.UPDATE_DATE=sysdate," & _
                        "S.UPDATED_BY='" & mUserName & "'," & _
                        "S.J_COMPUTER='" & mComputerName & "' " & _
                    " where S.SCREEN_ID=" & DataGridView1.Item(0, i).Value & _
                        " and S.SUB_ID=" & DataGridView1.Item(1, i).Value & _
                        " and S.PRIORITY=" & PriorityID
                If Oradb.ExeSQL(strSQL) Then
                    'MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "System TAS")
                Else
                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")

                End If

                i = i + 1
            Loop
            MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "System TAS")
            'If i > 3 Then
            '    EditData = True
            '    Call AddJournal(Jevent, P_CurScreenID, 100, P_ModifyUser, 803202, AE_PriorityName)
            '    MsgBox("·èÒ¹ä´é·Ó¡ÒÃºÑ¹·Ö¡¢éÍÁÙÅ¢Í§ " & AE_PriorityName & " àÃÕÂºÃéÍÂáÅéÇ", vbInformation)
            'End If

        End If
    End Function
#Region "Menu Event"

    Private Sub UcMenuRefresh_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64)
        Show_Data(0)
    End Sub

    Private Sub UcMenuAdd_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64)
        frmUtlUsers_sub.setFrmWork(1)
        frmUtlUsers_sub.Show()
    End Sub

    Private Sub UcMenuEdit_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64)

    End Sub

    Private Sub UcMenuDelete_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64)
 
    End Sub

    Private Sub UcMenuSacrch_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64)
        frmUtlUsers_sub.setFrmWork(4)
        frmUtlUsers_sub.Show()
    End Sub
#End Region
    Private Sub initialDisible_menu()
        UcMenuProgrammer.Enabled = False
        UcMenuDepotOperator.Enabled = False
        UcMenuEngineer.Enabled = False
        'UcMenuLG.Enabled = False
        UcMenuSSLTO.Enabled = False
        lblPriorityName.Text = ""
        cmdReport.Visible = True
        SAVE.Visible = True
        Cancle.Visible = True
    End Sub
    Private Sub initialVisible_menu()
        UcMenuProgrammer.Enabled = True
        UcMenuDepotOperator.Enabled = True
        UcMenuEngineer.Enabled = True
        'UcMenuLG.Enabled = True
        UcMenuSSLTO.Enabled = True
        lblPriorityName.Text = ""
        UcMenuProgrammer.BackColor = Color.Transparent
        UcMenuDepotOperator.BackColor = Color.Transparent
        UcMenuEngineer.BackColor = Color.Transparent
        'UcMenuLG.BackColor = Color.Transparent
        UcMenuSSLTO.BackColor = Color.Transparent
        cmdReport.Visible = False
        SAVE.Visible = False
        Cancle.Visible = False

    End Sub
    Private Sub UcMenuProgrammer_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuProgrammer.OnClickMnuText
        Show_Data(6)
        initialDisible_menu()
        UcMenuProgrammer.Enabled = True
        lblPriorityName.Text = "Programmer"
        lblPriority.Text = "6"
        UcMenuDepotOperator.BackColor = Color.LightGray
    End Sub

    Private Sub Cancle_Click(sender As System.Object, e As System.EventArgs) Handles Cancle.Click
        Show_Data(0)
        initialVisible_menu()
    End Sub

    Private Sub UcMenuVisitor_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64)
        Show_Data(1)
        initialDisible_menu()
        lblPriorityName.Text = "Visitor"
        lblPriority.Text = "1"
    End Sub

    Private Sub UcMenuDepotOperator_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuDepotOperator.OnClickMnuText
        Show_Data(2)
        initialDisible_menu()
        UcMenuDepotOperator.Enabled = False
        lblPriorityName.Text = "Depot Operator"
        lblPriority.Text = "2"
        UcMenuDepotOperator.BackColor = Color.LightGray
    End Sub

    Private Sub UcMenuLG_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64)
        'Show_Data(3)
        'initialDisible_menu()
        'UcMenuLG.Enabled = False
        'lblPriorityName.Text = "LG"
        'lblPriority.Text = "3"
        'UcMenuLG.BackColor = Color.LightGray
    End Sub

    Private Sub UcMenuSSLTO_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuSSLTO.OnClickMnuText
        Show_Data(4)
        initialDisible_menu()
        UcMenuSSLTO.Enabled = False
        lblPriorityName.Text = "SS/LTO"
        lblPriority.Text = "4"
        UcMenuSSLTO.BackColor = Color.LightGray
    End Sub

    Private Sub UcMenuEngineer_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuEngineer.OnClickMnuText
        Show_Data(5)
        initialDisible_menu()
        UcMenuEngineer.Enabled = False
        lblPriorityName.Text = "Engineer"
        lblPriority.Text = "5"
        UcMenuEngineer.BackColor = Color.LightGray
    End Sub

    Private Sub UcMenuIT_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64)
        Show_Data(7)
        initialDisible_menu()
        lblPriorityName.Text = "IT"
        lblPriority.Text = "7"
    End Sub

    Private Sub SAVE_Click(sender As System.Object, e As System.EventArgs) Handles SAVE.Click
        If Convert.ToInt32(lblPriority.Text) > 0 Then
            If P_CHECK_SCREEN_AUTHORIZE(mUserName, 802, 1) Then
                EditData(Convert.ToInt32(lblPriority.Text))
            End If

        End If

        'Show_Data(0)
    End Sub

    Private Sub lblPriority_Click(Index As Integer)
        Select Case Index
            Case 0 : gGroup = 1
            Case 1 : gGroup = 2
            Case 2 : gGroup = 3
            Case 3 : gGroup = 4
            Case 4 : gGroup = 5
            Case 5 : gGroup = 6
            Case Else
        End Select
        cmdReport.Visible = True
    End Sub
    Private Sub PrintReport(ByVal pGroup As Long)
        'Dim strSql As String
        'strSql = "select * " &
        '                  "from tas.view_user_security_permission " &
        '                  "where status_number='" & pGroup & "' "
        Try
            'rptFileName = GetReportFileName(52010061)

            'With frmrptShowReport
            '    .mRptFileName = rptFileName
            '    .mstrQuery = strSql
            '    .ValueParameter = 2
            '    .Show()
            'End With
            With frmrptMainShow
                .report_id = "52010061"
                .param1 = pGroup
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdReport_Click(sender As System.Object, e As System.EventArgs) Handles cmdReport.Click
        Call PrintReport(Convert.ToInt16(lblPriority.Text))
    End Sub
    Private Sub UcHeader1_CloseButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.CloseButtonClick
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub UcHeader1_MinimizeButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.MinimizeButtonClick
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub UcBack1_Click(sender As Object, e As EventArgs) Handles UcBack1.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UcBack1_MouseHover(sender As Object, e As EventArgs) Handles UcBack1.MouseHover
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("Back1")
    End Sub

    Private Sub UcBack1_MouseLeave(sender As Object, e As EventArgs) Handles UcBack1.MouseLeave
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("back")
    End Sub

    Private Sub UcBack1_Load(sender As System.Object, e As System.EventArgs) Handles UcBack1.Load

    End Sub
End Class

