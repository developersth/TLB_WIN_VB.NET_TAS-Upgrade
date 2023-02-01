Public Class dfindIncombo
    Dim cbo As New ComboBox
    Dim Index As Integer
    Dim typeButton As Integer
    Dim gridRow As Integer = 0
    Dim gridColumn As Integer = 0
    Dim rowOldYellow As Integer = 0

    Private Sub dfindIncombo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "ค้นหา"
        ' MessageBox.Show(typeButton)
        Combo1.Items.Add("ลำดับ")
        Combo1.Items.Add("ชื่อ")
        Combo1.Text = "ชื่อ"
        gridRow = 0
        gridColumn = 0

    End Sub

    Public Function FindData(ByVal n As Integer, ByVal combo As ComboBox) As Boolean
        Dim i As Integer = 0
        typeButton = n
        Do While combo.Items.Count > i
            DataGridView1.RowCount = DataGridView1.RowCount + 1
            DataGridView1.Item(0, i).Value = i + 1
            DataGridView1.Item(1, i).Value = combo.Items(i).ToString

            i += 1
        Loop
        txtRec.Text = DataGridView1.RowCount
        Return True
    End Function
    '        Do While dt.Rows.Count > i
    '            DataGridView1.RowCount = DataGridView1.RowCount + 1
    '            DataGridView1.Item(0, i).Value = ""

    '        Loop

    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        Dim someText As String = textKeyword.Text

        For Each Row As DataGridViewRow In DataGridView1.Rows
            'For Each column As DataGridViewColumn In DataGridView1.Columns

            ' Dim someText As String = textKeyword.Text
            If CType(DataGridView1.RowCount, Integer) <= CType(gridRow, Integer) Then
                MsgBox("ไม่พบข้อมลที่ท่านต้องการค้นหา")
                gridRow = 0
                gridColumn = 0
                Exit For
            End If
            Dim cell As DataGridViewCell = (DataGridView1.Rows(gridRow).Cells(Combo1.Text))
            If cell.Value.ToString.ToLower.Contains(someText.ToLower) Then


                DataGridView1.Rows(rowOldYellow).Cells(Combo1.Text).Style.BackColor = Color.White
                rowOldYellow = gridRow
                cell.Style.BackColor = Color.Yellow

                DataGridView1.CurrentCell = DataGridView1.Rows(gridRow).Cells(0)
                gridRow += 1
                Exit For
            End If

            gridColumn += 1
            'Next column
            gridColumn = 0
            gridRow += 1
        Next Row
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        '******** frm frmLoadLoading
        'If typeButton = 1 Then
        '    frmLoadLoading_sub.cbDriver.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value()
        'End If
        'If typeButton = 2 Then
        '    frmLoadLoading_sub.cbTu_Tail.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value()
        'End If
        'If typeButton = 3 Then
        '    frmLoadLoading_sub.cbTruck.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value()
        'End If
        'If typeButton = 4 Then
        '    frmLoadLoading_sub.cbCard.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value()
        'End If
        If typeButton = 1 Then
            frmLoadCreateLoad.cbDriverBil.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value()
        End If
        If typeButton = 2 Then
            frmLoadCreateLoad.cbTail.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value()
        End If
        If typeButton = 3 Then
            frmLoadCreateLoad.cbTUHead.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value()
        End If
        If typeButton = 4 Then
            frmLoadCreateLoad.cbCardBil.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value()
        End If
        '******** frm Vehicle
        If typeButton = 5 Then
            frmMainVehicle_sub.cbTruck.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value()
        End If
        If typeButton = 6 Then
            frmMainVehicle_sub.cbVehicle.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value()
        End If
        If typeButton = 7 Then
            frmMainVehicle_sub.cbCarrier.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value()
        End If
        '******** frm Card
        If typeButton = 8 Then
            frmMainCard_sub.cbTruck.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value()
        End If
        '******** frm Shipto
        If typeButton = 9 Then
            frmMainShipTo_sub.cmbCusShipTo.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value()
        End If
        Me.Close()
    End Sub

    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Public Sub AddComboToGrid(ByVal combo As ComboBox, ByVal frm As Form, ByVal indexOld As Integer)
        Dim i As Integer, j As Long
        Dim str1 As String
        Dim str2 As String
        j = 0
        cbo = combo
        Index = indexOld
        If combo.Items.Count <= 0 Then
            Me.Close()
            Exit Sub
        Else
            txtRec.Text = combo.Items.Count
        End If
        'DataGridView1.Item(1, 0).Value = 0
        With DataGridView1
            .Rows.Add(combo.Items.Count)
            For i = 0 To combo.Items.Count - 1
                'combo.listIndex = j
                '                str1 = Trim(Mid(combo.Text, 1, InStr(1, combo.Text, " ")))
                '                str2 = Trim(Mid(combo.Text, InStr(1, combo.Text, " "), Len(combo.Text)))
                '                SplitString combo.Text, str1, str2
                '                .TextMatrix(i, 2) = str2
                .Item(0, i).Value = i + 1
                .Item(1, i).Value = combo.Items(j)
                j = j + 1
            Next i
        End With
    End Sub


    Private Sub CmdClose_Click_1(sender As Object, e As EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub textKeyword_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles textKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim someText As String = textKeyword.Text

            For Each Row As DataGridViewRow In DataGridView1.Rows
                'For Each column As DataGridViewColumn In DataGridView1.Columns

                ' Dim someText As String = textKeyword.Text
                If CType(DataGridView1.RowCount, Integer) <= CType(gridRow, Integer) Then
                    MsgBox("ไม่พบข้อมลที่ท่านต้องการค้นหา")
                    gridRow = 0
                    gridColumn = 0
                    Exit For
                End If
                Dim cell As DataGridViewCell = (DataGridView1.Rows(gridRow).Cells(Combo1.Text))
                If cell.Value.ToString.ToLower.Contains(someText.ToLower) Then


                    DataGridView1.Rows(rowOldYellow).Cells(Combo1.Text).Style.BackColor = Color.White
                    rowOldYellow = gridRow
                    cell.Style.BackColor = Color.Yellow

                    DataGridView1.CurrentCell = DataGridView1.Rows(gridRow).Cells(0)
                    gridRow += 1
                    Exit For
                End If

                gridColumn += 1
                'Next column
                gridColumn = 0
                gridRow += 1
            Next Row
        End If
    End Sub
End Class