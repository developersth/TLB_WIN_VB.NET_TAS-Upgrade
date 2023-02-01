Public Class frmLoadEditSeal
    Public iCase As Long
    Dim SealCount As String
    Dim SealNumber As String
    Dim SealLast As String
    Dim P_ComputerName As String = System.Net.Dns.GetHostName
  
    Function GenAddSeal(ByVal StringSeal As String, ByVal intSealMax As Long, ByVal Add As Long) As String
        Dim arStringSeal() As String
        Dim SealUse As String
        Dim iCount As Long
        Dim IntCount As Long
        Dim i As Long
        Dim j As Long
        Dim intZero As Long
        Dim arZero() As String
        Dim LenBefor As Long
        Dim LenAfter As Long
        Dim LenDiff As Long
        Dim IfAllNumber As Boolean
        If StringSeal = "" Then Exit Function

        If ChkString(Asc(Trim(Microsoft.VisualBasic.Right(IIf(StringSeal = "", "1", StringSeal), 1)))) Then
            GenAddSeal = StringSeal
            Exit Function
        End If

        For i = 1 To intSealMax
            ReDim Preserve arStringSeal(iCount)
            arStringSeal(iCount) = Mid(StringSeal, i, 1)
            iCount = iCount + 1
        Next i
        For i = UBound(arStringSeal) To LBound(arStringSeal) Step -1
            Select Case Asc(arStringSeal(i))
                Case 65 To 90, 97 To 122
                    IfAllNumber = True
                    LenBefor = Len(SealUse)
                    For j = 0 To Len(SealUse) - 1
                        ReDim Preserve arZero(j)
                        arZero(j) = Mid(Trim(SealUse), j + 1, 1)
                        If arZero(j) = 0 Then intZero = intZero + 1
                    Next j
                    SealUse = SealUse + Add
                    LenAfter = Len(SealUse)
                    LenDiff = intZero + LenAfter
                    LenDiff = LenDiff - LenBefor
                    LenDiff = intZero - LenDiff
                    For IntCount = 1 To LenDiff
                        SealUse = "0" & SealUse
                    Next IntCount
                    iCount = 0
                    For iCount = 0 To i
                        SealUse = arStringSeal(i) & SealUse
                        i = i - 1
                    Next iCount
                    Exit For
            End Select
            If IfAllNumber = True Then
                SealUse = arStringSeal(i) & SealUse
            Else
                SealUse = (arStringSeal(i)) & SealUse
            End If
        Next i
        If IfAllNumber = False Then
            SealUse = (Val(SealUse) + Add) - 1
        End If
        GenAddSeal = SealUse
    End Function

    Public Sub SentFormLoad(ByVal Index As Long)
        Dim row As Integer = frmLoadLoading.MSGridHeader.CurrentRow.Index
        Dim mDataSet As New DataSet
        Dim strSQL As String
        Dim intSealMax As Long
        Dim StringSeal As String = ""
        Dim arEditSeal() As String
        Call ClearTextbox()
        Call LockTextBox()
        Select Case Index
            Case 0
                Dim dt As DataTable
                Dim i As Integer
                strSQL =  "select t.seal_no from seal_control t where id=1"
                If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
                    dt = mDataSet.Tables("TableName1")
                    i = 0
                    If dt.Rows.Count > 0 Then
                        intSealMax = Len(IIf(IsDBNull(dt.Rows(i).Item("seal_no")), "", dt.Rows(i).Item("seal_no").ToString))
                        StringSeal = IIf(IsDBNull(dt.Rows(i).Item("seal_no")), "", dt.Rows(i).Item("seal_no").ToString)                     
                    End If
                Else
                End If
                mDataSet = Nothing

                If StringSeal = "" Then Exit Sub
                Me.Text = "เพิ่มหมายเลขซีล"
                txtloadNo.Text = frmLoadLoading.MSGridHeader.Item(0, row).Value()
                txtShipmentNo.Text = frmLoadLoading.MSGridHeader.Item(1, row).Value()
                txtTruckNo.Text = frmLoadLoading.MSGridHeader.Item(2, row).Value()
                txtTuNo.Text = frmLoadLoading.MSGridHeader.Item(3, row).Value()
                txtTotSeal.Text = frmLoadLoading.MSGridHeader.Item(4, row).Value()
            Case 1
                Me.Text = "แก้ไขหมายเลขซีล"

                txtloadNo.Text = frmLoadLoading.MSGridHeader.Item(1, row).Value()
                txtShipmentNo.Text = frmLoadLoading.MSGridHeader.Item(2, row).Value()
                txtTruckNo.Text = frmLoadLoading.MSGridHeader.Item(8, row).Value()
                txtTuNo.Text = IIf(IsDBNull(frmLoadLoading.MSGridHeader.Item(10, row).Value), "", IsDBNull(frmLoadLoading.MSGridHeader.Item(10, row).Value))
                txtTotSeal.Text = GetSealCount(Trim(txtloadNo.Text))

                If frmLoadLoading.MSGridHeader.Item(17, row).Value = "" Then
                    Exit Sub
                Else
                    arEditSeal = Split(frmLoadLoading.MSGridHeader.Item(17, row).Value(), "-")
                End If
        End Select

    End Sub

    Private Function SaveSeal(ByVal iLoad_no As String, ByVal iauto_seal As Long, ByVal iseal_number As String, ByVal ioverride_card As Long, ByVal idatetime_active As String, ByVal ij_user As String, ByVal ij_computer As String) As Boolean
        Dim strSQL As String
        strSQL = "begin "
        strSQL = strSQL & " load.Registor_Update_Seal ('"
        strSQL = strSQL & iLoad_no & "'," & iauto_seal & ",'"
        strSQL = strSQL & iseal_number & "', "
        strSQL = strSQL & ioverride_card & ",to_date('" & idatetime_active & "','DD/MM/YYYY HH24:MI:SS') ," & _
        strSQL = strSQL & "'" & ij_user & "','" & ij_computer & "',"
        strSQL = strSQL & ":ret_check,:ret_msg); "
        strSQL = strSQL & "end;"

        Dim bRet As Boolean = False
        Dim Oraparam As New COraParameter
        Dim RET_CHECK As Object
        Dim RET_MSG As Object
        With Oraparam
            .CreateOracleParamOutput("RET_CHECK", COracle._OracleDbType.OraInt32)
            .CreateOracleParamOutput("RET_MSG", COracle._OracleDbType.OraVarchar2, 512)
        End With
        If Oradb.ExeSQL(strSQL, Oraparam) Then
            RET_CHECK = Oraparam.GetOraclParamValue("RET_CHECK")
            RET_MSG = Oraparam.GetOraclParamValue("RET_MSG")
            If RET_CHECK = 0 Then
                MsgBox(Oraparam.GetOraclParamValue("RET_MSG").ToString, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                bRet = False
            Else
                MsgBox(Oraparam.GetOraclParamValue("RET_MSG").ToString, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                bRet = True
            End If
           

            'SaveSeal = IIf((Oraparam.GetOraclParamValue("RET_CHECK") >= 0), True, False)
            'If Oraparam.GetOraclParamValue("RET_CHECK").value <> 0 Then
            '    MsgBox(IIf(Oraparam.GetOraclParamValue("RET_MSG").ToString, "", Oraparam.GetOraclParamValue("RET_MSG").ToString), vbCritical, "??????????????")
            '    Exit Function
            'End If
            'MsgBox(IIf(Oraparam.GetOraclParamValue("RET_MSG").ToString, "", Oraparam.GetOraclParamValue("RET_MSG").ToString), vbCritical, "??????????????")
        End If

        Oraparam.RemoveOracleParam()
        Oraparam = Nothing
        Return bRet
    End Function

    Private Sub LockTextBox()
        txtShipmentNo.Enabled = True
        txtTruckNo.Enabled = True
        txtTuNo.Enabled = True
        txtloadNo.Enabled = True
    End Sub
    Private Sub ClearTextbox()
        txtShipmentNo.Text = ""
        txtTruckNo.Text = ""
        txtTuNo.Text = ""
        txtloadNo.Text = ""
    End Sub


    Private Sub txtSealTo_KeyPress(ByVal KeyAscii As Integer)
        If KeyAscii = 13 Then
            'cmdOK.SetFocus()
        End If
    End Sub
    'Private Sub txtTotSeal_KeyPress(ByVal KeyAscii As Integer)
    '    Select Case KeyAscii
    '        Case 48, vbKey1 To vbKey9, vbKeyBack, vbKeyDelete, vbKeyTab
    '            '                If KeyAscii = 48 Then
    ''txtSealNumber.text = "-"
    '            '                End If
    '        Case Else
    '            KeyAscii = 0
    '    End Select

    'End Sub

    Private Function ChkString(ByVal iStringAsc As Long) As Boolean
        Select Case iStringAsc
            Case 48 To 57
                ChkString = False
            Case Else
                ChkString = True
        End Select
    End Function

    Private Function GetSealCount(ByVal ILoadNo As String) As String
        
        Dim strSQL As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        strSQL = " Select t.seal_use,t.seal_number   from tas.Oil_load_headers  t  where  t.load_header_no = '" & ILoadNo & "'"
        If Oradb.OpenDys(strSQL, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            If dt.Rows.Count > 0 Then
                GetSealCount = IIf(IsDBNull(dt.Rows(i).Item("seal_use")), "0", dt.Rows(i).Item("seal_use").ToString)
                txtSealNumber.Text = IIf(IsDBNull(dt.Rows(i).Item("seal_number")), "-", dt.Rows(i).Item("seal_number").ToString)
            End If
        Else
            GetSealCount = " 0"
        End If
        mDataSet = Nothing
    End Function



    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Dim d As String
        Dim strSQL As String
        If MsgBox("ท่านต้องการบันทึกข้อมูล ใช่หรือไม่?", vbInformation + vbYesNo) = vbNo Then
            Exit Sub
        End If
        If iCase = 0 Then
            d = Date.Now

            Call SaveSeal(txtloadNo.Text, 0, Trim(txtSealNumber.Text), 1, d, mUserName, P_ComputerName)
            If SealLast <> "" Then
                strSQL = "Update seal_control t SET t.load_last_no='" & txtloadNo.Text & "' ,"
                strSQL = strSQL & " t.seal_no='" & Trim(SealLast) & "'  "
                strSQL = strSQL & " Where t.id=1"
                Oradb.ExeSQL(strSQL)
            End If
            If SealCount = "" Then
                SealCount = txtTotSeal.Text
            End If
            strSQL = " Update oil_load_headers t SET  t.Seal_use= " & Val(SealCount) & " "
            strSQL = strSQL & " Where t.load_header_no=" & txtloadNo.Text & " "
            Oradb.ExeSQL(strSQL)

            'frmLoadSeal.ShowFlexGridHeader()
        Else

            SealNumber = Trim(txtSealNumber.Text)
            SealCount = txtTotSeal.Text
            strSQL = " begin  Update oil_load_headers t SET    t.Seal_Number= '" & SealNumber & "'  ,t.Seal_use= " & Val(SealCount) & " "
            strSQL = strSQL & " Where t.load_header_no='" & txtloadNo.Text & "' ; end  ;  "
            Oradb.ExeSQL(strSQL)

        End If



        Me.Close()
        'Unload(Me)
    End Sub

    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub

    Private Sub frmLoadEditSeal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SentFormLoad(iCase)
    End Sub
 
End Class