Public Class frmUtlAddSeal
    Public frm_Request As Integer ' 0= frmLoadLoading_sub,1=frmUtlOverrideCR
    Dim txtSeal As String
    Dim strSealCount As String
    Dim strSealLast As String
    Dim L_H_N As String
    Dim SealLast As String
    Dim ChkGenseal As Boolean

    Private Sub ClearText()
        txtSealAmount.Text = "0"
        txtSealStart.Text = ""
        txtLastSeal.Text = ""
    End Sub

    Private Sub frmLoadDoList_sub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetLastSeal()

        ChkGenseal = False
        txtLastSeal.Text = GenAddSeal(Trim(txtSealStart.Text), CLng(Len(Trim(txtSealStart.Text))), CLng(Trim(txtSealAmount.Text)))
    End Sub

    Public Sub GetLoadNo(ByVal iLoad_no As String)
        L_H_N = iLoad_no
    End Sub

    Private Sub GetLastSeal()
        Dim sql_str As String
        Dim mDataSet As New DataSet
        Dim dt As DataTable
        Dim i As Integer

        sql_str = "SELECT T.SEAL_NO  FROM TAS.SEAL_CONTROL T "

        If Oradb.OpenDys(sql_str, "TableName1", mDataSet) Then
            dt = mDataSet.Tables("TableName1")
            i = 0
            If dt.Rows.Count > 0 Then

                ChkGenseal = True
                txtSealStart.Text = IIf(IsDBNull(dt.Rows(i).Item("SEAL_NO")), "", dt.Rows(i).Item("SEAL_NO").ToString)
                txtSealStart.Text = Replace(txtSealStart.Text, Chr(32), "")
                txtSealStart.Text = GenAddSeal(Trim(txtSealStart.Text), Len(txtSealStart.Text), 2)
            End If
        Else
            txtSealStart.Text = ""
        End If
        mDataSet = Nothing
    End Sub

    Private Sub lblCalSeal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCalSeal.Click
        txtLastSeal.Text = GenAddSeal(Trim(txtSealStart.Text), CLng(Len(Trim(txtSealStart.Text))), CLng(Trim(txtSealAmount.Text)))
    End Sub

    Private Sub lblOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblOk.Click
        Dim StrSeal As String
        If frm_Request = 0 Then
            frmLoadLoading_sub.txtSealNumber.Text = ""
            frmLoadLoading_sub.txtAmoutSeal.Text = ""
            If txtLastSeal.Text <> "" Then
                frmLoadLoading_sub.txtSealNumber.Text = txtSealStart.Text & " - " & txtLastSeal.Text
                frmLoadCreateLoad.txtSealNumber.Text = txtSealStart.Text & " - " & txtLastSeal.Text
                frmLoadCreateLoad.SealLast = txtLastSeal.Text
                frmLoadCreateLoad.txtSealCount.Text = txtSealAmount.Text
            Else
                frmLoadLoading_sub.txtSealNumber.Text = txtSealStart.Text
                frmLoadCreateLoad.txtSealNumber.Text = txtSealStart.Text
                frmLoadCreateLoad.txtSealCount.Text = txtSealAmount.Text
                If txtSealStart.Text = "" Then
                    SealLast = ""
                ElseIf (txtSealStart.Text = "" And CInt(txtSealAmount.Text) = 1) Then
                    StrSeal = Trim(txtLastSeal.Text)
                    SealLast = StrSeal
                End If
                frmLoadCreateLoad.SealLast = ""
            End If
            frmLoadLoading_sub.txtAmoutSeal.Text = txtSealAmount.Text
        ElseIf frm_Request = 1 Then
            If txtLastSeal.Text <> "" Then
                frmUtlOverrideCR.txtSealNumber.Text = txtSealStart.Text & " - " & txtLastSeal.Text
            Else
                frmUtlOverrideCR.txtSealNumber.Text = txtSealStart.Text
            End If
        End If

        frmLoadLoading_sub.SealLast = txtLastSeal.Text
        Me.Close()
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

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

        'If Add = 1 And txtSealStart = "" Then
        '    GetLastSeal
        'End If
        If StringSeal = "" Then
            GenAddSeal = Trim(StringSeal)
            Exit Function
        End If
        'If Add = 1 And StringSeal <> "" Then
        '    GenAddSeal = ""
        '    Exit Function
        'End If
        If Add = 0 And intSealMax > 0 Then
            GenAddSeal = ""
            txtSealStart.Text = ""
            Exit Function
        Else
            For i = 1 To Len(StringSeal)
                If ChkString(Asc(Trim(Mid(StringSeal, i, 1)))) Then
                    If Not ChkGenseal Then
                        Add = Add - 1
                    End If
                    Exit For
                End If
            Next i
        End If

        Dim strTem = IIf(StringSeal = "", "1", StringSeal)
        strTem = strTem.Substring(strTem.Length - 1)
        'str.Substring(str.Length - 5)


        If ChkString(Asc(Trim(strTem))) Then
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

    Private Function ChkString(ByVal iStringAsc As Long) As Boolean
        Select Case iStringAsc
            Case 48 To 57
                ChkString = False
            Case Else
                ChkString = True
        End Select
    End Function

    Public Function GetSealCount()
        GetSealCount = strSealCount
    End Function

    Public Function GetSealLast()
        GetSealLast = SealLast
    End Function

    Public Function GetSealNumber()
        GetSealNumber = txtSealStart.Text & " - " & txtLastSeal.Text
    End Function

    Private Sub txtLastSeal_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtLastSeal.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtLastSeal.Text = GenAddSeal(Trim(txtSealStart.Text), CLng(Len(Trim(txtSealStart.Text))), CLng(Trim(txtSealAmount.Text)))
        End If
    End Sub

    Private Sub txtSealAmount_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSealAmount.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtLastSeal.Text = GenAddSeal(Trim(txtSealStart.Text), CLng(Len(Trim(txtSealStart.Text))), CLng(Trim(txtSealAmount.Text)))
        End If
    End Sub

    Private Sub txtSealStart_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSealStart.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtLastSeal.Text = GenAddSeal(Trim(txtSealStart.Text), CLng(Len(Trim(txtSealStart.Text))), CLng(Trim(txtSealAmount.Text)))
        End If
    End Sub
End Class