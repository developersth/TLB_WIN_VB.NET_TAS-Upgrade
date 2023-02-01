Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmConfigCardReader_main
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=add ,2=Edit

    Private Sub frmConfigCardReader_main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        'UcStatus1.StopThread()
        UcFooter1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmConfigCardReader_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        'InitialForm(Me, lblTitleName.Text)
        'UcStatus1.StartThread()
        'MenuStatusBar.tScanTime.Start()
        UcFooter1.StartThread()
        UcFooter1.tScanTime.Start()
        'Initial_frm()
        Show_Data()
    End Sub

    Private Sub frmConfigCardReader_main_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
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

    Public Sub Show_Data()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer
        Dim fixType As String
        sql_str = "SELECT "
        sql_str = sql_str & "C.CARD_READER_ID,C.CARD_READER_NAME,C.CARD_READER_TYPE,"
        sql_str = sql_str & "C.CARD_READER_ADDRESS,C.LOCALITY_POSITION,C.LOCALITY_DESC,C.CARD_READER_TYPE||'-'||V.TYPE_NAME as STATUS,"
        sql_str = sql_str & "C.COMP_ID,C.COMPORT_NO,C.FIX_TYPE,C.ISLAND_NO,C.BAY_NO,C.BAY_NAME,"
        sql_str = sql_str & " CASE WHEN LENGTH(COMP_ID1) <> 0  THEN  C.COMP_ID ||'-'|| C.COMPORT_NO ||'/'|| C.COMP_ID1||'-'||C.COMPORT_NO1 "
        sql_str = sql_str & " ELSE C.COMP_ID ||'-'||C.COMPORT_NO  END AS COMPORTS_NO, "
        sql_str = sql_str & "C.IS_ENABLED,C.IS_PROCESS,C.IS_LOCKED,C.IS_FINGER,C.FINGER_SERIAL,"
        sql_str = sql_str & "C.FINGER_KEY,C.FINGER_DESC,C.IS_PRINTER,C.PRINTER_ID,C.PRINTER_NAME,"
        sql_str = sql_str & "C.CONNECT_STATUS,C.DESCRIPTION,C.CREATION_DATE,C.CREATED_BY,"
        sql_str = sql_str & "C.UPDATE_DATE , C.UPDATED_BY, C.J_COMPUTER "
        sql_str = sql_str & "FROM TAS.CARD_READER C,TAS.V_CARD_READER_TYPE V "
        sql_str = sql_str & "WHERE C.CARD_READER_TYPE=V.TYPE_ID "
        sql_str = sql_str & "ORDER BY C.CARD_READER_ID "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            DataGridView1.RowCount = 0
            txtTotalRecord.Text = dt.Rows.Count
            Do While dt.Rows.Count > i
                DataGridView1.RowCount = DataGridView1.RowCount + 1
                DataGridView1.Rows.Item(i).Height = Grid_Height
                DataGridView1.Item(0, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CARD_READER_ID")), "", dt.Rows(i).Item("CARD_READER_ID").ToString)
                DataGridView1.Item(1, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CARD_READER_NAME")), "", dt.Rows(i).Item("CARD_READER_NAME").ToString)
                DataGridView1.Item(2, i).Value = IIf(IsDBNull(dt.Rows(i).Item("STATUS")), "", dt.Rows(i).Item("STATUS").ToString)
                DataGridView1.Item(3, i).Value = IIf(IsDBNull(dt.Rows(i).Item("CARD_READER_ADDRESS")), "", dt.Rows(i).Item("CARD_READER_ADDRESS").ToString)
                DataGridView1.Item(4, i).Value = IIf(IsDBNull(dt.Rows(i).Item("Comports_no")), "", dt.Rows(i).Item("Comports_no").ToString)
                If IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", dt.Rows(i).Item("IS_ENABLED").ToString) = 0 Then
                    DataGridView1.Item(5, i).Value = "Not Connect"
                ElseIf IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", dt.Rows(i).Item("IS_ENABLED").ToString) = 1 Then
                    DataGridView1.Item(5, i).Value = "Connect"
                Else
                    DataGridView1.Item(5, i).Value = "Not Connect"
                End If

                fixType = IIf(IsDBNull(dt.Rows(i).Item("FIX_TYPE")), "", dt.Rows(i).Item("FIX_TYPE"))
                If fixType = "0" Then
                    DataGridView1.Item(6, i).Value = "Bay"
                ElseIf fixType = "1" Then
                    DataGridView1.Item(6, i).Value = "Island"
                Else
                    DataGridView1.Item(6, i).Value = ""
                End If

                DataGridView1.Item(7, i).Value = IIf(IsDBNull(dt.Rows(i).Item("IS_ENABLED")), "", dt.Rows(i).Item("IS_ENABLED").ToString)

                If IIf(IsDBNull(dt.Rows(i).Item("IS_LOCKED")), "", dt.Rows(i).Item("IS_LOCKED").ToString) = 0 Then
                    DataGridView1.Item(8, i).Value = "Locked"
                ElseIf IIf(IsDBNull(dt.Rows(i).Item("IS_LOCKED")), "", dt.Rows(i).Item("IS_LOCKED").ToString) = 1 Then
                    DataGridView1.Item(8, i).Value = "Unlocked"
                Else
                    DataGridView1.Item(8, i).Value = ""
                End If

                DataGridView1.Item(9, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATE_DATE")), "", dt.Rows(i).Item("UPDATE_DATE").ToString)
                DataGridView1.Item(10, i).Value = IIf(IsDBNull(dt.Rows(i).Item("UPDATED_BY")), "", dt.Rows(i).Item("UPDATED_BY").ToString)

                i = i + 1
            Loop
        Else
        End If
        mDataSet = Nothing
        dt = Nothing
    End Sub

    Private Function appendZero(ByVal codeColour As String) As String
        Dim i As Integer = 6 - codeColour.Length
        While (i <> 0)
            codeColour = "0" + codeColour
            i = i - 1
        End While
        Return codeColour
    End Function

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub

    Private Sub Delete()
        Dim sql_str As String
        'Dim mDataSet As New DataSet
        sql_str = " DELETE FROM CARD_READER "
        sql_str = sql_str & " WHERE CARD_READER_ID = '" + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + "' "
        If Oradb.ExeSQL(sql_str) Then
            MessageBox.Show("ได้ทำการลบข้อมูลเรียบร้อย", "System TAS")
            Show_Data()
        Else
            MessageBox.Show("ไม่สามารถลบข้อมูลได้" & vbCrLf & vbCrLf & " กรุณาตรวจสอบข้อมูลอีกครั้ง", "System TAS")
        End If
    End Sub
#Region "Menu Event"

    Private Sub UcMenuRefresh_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuRefresh.OnClickMnuText
        Show_Data()
    End Sub

    Private Sub UcMenuAdd_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuAdd.OnClickMnuText
        frmConfigCardReader_sub.Close()
        frmConfigCardReader_sub.setFrmWork(1)
        frmConfigCardReader_sub.ShowDialog()
    End Sub

    Private Sub UcMenuEdit_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuEdit.OnClickMnuText
        Dim id As String
        id = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        frmConfigCardReader_sub.Close()
        frmConfigCardReader_sub.setFrmWork(2)
        frmConfigCardReader_sub.setPkId(id)
        frmConfigCardReader_sub.ShowDialog()
    End Sub

    Private Sub UcMenuDelete_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuDelete.OnClickMnuText
        Dim result As Integer = MessageBox.Show("ต้องการลบข้อมูลเครื่องอ่านบัตร : " + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString + " หรือไม่ ?", "System TAS", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
        ElseIf result = DialogResult.Yes Then
            Delete()
        End If
    End Sub

    Private Sub UcMenuSacrch_OnClickMnuText(ucName As System.String, ucScreenID As System.Int64) Handles UcMenuSacrch.OnClickMnuText
        frmFind.InitialFormFind(DataGridView1)
        frmFind.ShowDialog()
    End Sub
#End Region
    Private Sub UcHeader1_CloseButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.CloseButtonClick
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UcHeader1_MinimizeButtonClick(sender As Object, e As EventArgs) Handles UcHeader1.MinimizeButtonClick
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub UcBack1_Click(sender As Object, e As EventArgs) Handles UcBack1.Click, MyBase.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UcBack1_MouseHover(sender As Object, e As EventArgs) Handles UcBack1.MouseHover, MyBase.MouseHover
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("Back1")
    End Sub

    Private Sub UcBack1_MouseLeave(sender As Object, e As EventArgs) Handles UcBack1.MouseLeave, MyBase.MouseLeave
        UcBack1.BackgroundImage = My.Resources.ResourceManager.GetObject("back")
    End Sub
End Class
