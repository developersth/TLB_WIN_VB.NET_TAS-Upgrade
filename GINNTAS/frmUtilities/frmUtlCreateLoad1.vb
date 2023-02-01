Imports Oracle.DataAccess.Client
Imports System.Data

Public Class frmUtlCreateLoad1
    Public FormScreenID As Long
    Dim frm_work As Integer = 0 '1=add ,2=Edit

    Private Sub frmUtlCreateLoad1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        UcStatus1.StopThread()
        CloseForm(FormScreenID, "")
    End Sub

    Private Sub frmUtlCreateLoad1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetScreenResulotion()
        CheckFormResize(Me)
        InitialForm(Me, lblTitleName.Text)
        UcStatus1.StartThread()
        MenuStatusBar.tScanTime.Start()
        assignDropDown()
    End Sub

    Private Sub frmUtlCreateLoad1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        CheckFormResize(Me)
    End Sub

    Private Sub UcMinimize1_OnCilckMin() Handles UcMinimize1.OnCilckMin
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UcClose1_OnClickClose() Handles UcClose1.OnClickClose
        Me.Close()
    End Sub

    Function assignDropDown() As Boolean
        Dim sql_str As String

        sql_str = _
               " select c.card_no from tas.card c,tas.transport_unit t  where c.card_type=0  and c.is_enabled=1and c.tu_number=t.tu_number(+)  " & _
               " and not exists(select  h.tu_card_no " & _
                " from  oil_load_entrycard  h where c.card_no=h.tu_card_no  ) order by c.card_no "
        assignDropDown(sql_str, "card_no", cbCardBil)
        sql_str = _
                   "select T.TU_ID,T.TU_NUMBER,T.TU_ID||' - '||T.TU_NUMBER AS TuNAME " & _
                " from TRANSPORT_UNIT T order by T.Tu_Id,T.TU_NUMBER "
        assignDropDown(sql_str, "TuNAME", cbTUHead)
        sql_str = _
                   "select T.TU_ID,T.TU_NUMBER,T.TU_ID||' - '||T.TU_NUMBER AS TuNAME " & _
                " from TRANSPORT_UNIT T order by T.Tu_Id,T.TU_NUMBER "
        assignDropDown(sql_str, "TuNAME", cbTail)
        sql_str = _
        "select d.driver_id, d.first_name ||' '|| d.last_name  as DriverName,d.first_name ||' '|| d.last_name||' _'||d.driver_id as driver  from driver d order by d.first_name,d.last_name,d.driver_id"
        assignDropDown(sql_str, "driver", cbDriverBil)
        Return True
    End Function
    Function assignDropDown(ByVal sql_str As String, ByVal colName As String, ByVal cb As System.Object) As Boolean
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer = 0
        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            Dim temCb As String
            Do While dt.Rows.Count > i
                temCb = IIf(IsDBNull(dt.Rows(i).Item(colName)), "", dt.Rows(i).Item(colName).ToString)
                If Not cb.Items.Contains(temCb) Then
                    cb.Items.Add(temCb)
                End If
                i = i + 1
            Loop
            Return True
        End If
        mDataSet = Nothing
        Return True
    End Function


    Private Sub CmdAddCard_Click(sender As System.Object, e As System.EventArgs) Handles CmdAddCard.Click
        If OpenForm(406, "Card") Then
            PushForm(Me)
            Me.Hide()
        End If
    End Sub
End Class
