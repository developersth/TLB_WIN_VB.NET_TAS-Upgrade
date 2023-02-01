Public Class frmFind
    Private mDataGridFind As DataGridView
    Private frm As Form
    Dim mRowIndex As Integer

    Private Sub frmFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call InitialFind()
    End Sub

    Private Sub bCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCancel.Click
        mDataGridFind = Nothing
        Me.Close()
    End Sub

    Private Sub frmFind_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        TxtKeyword.Focus()
    End Sub

    Private Function FindKey() As Boolean
        If Combo1.Text = "" Then
            MessageBox.Show("ท่านยังไม่ได้เลือกชนิดข้อมูลที่ต้องการค้นหา")
            Combo1.Focus()
            Return False
        End If
        If TxtKeyword.Text = "" Then
            MessageBox.Show("ท่านยังไม่ได้กรอกข้อมูลที่ต้องการค้นหา")
            TxtKeyword.Focus()
            Return False
        End If

        With mDataGridFind
            If mRowIndex >= .Rows.Count - 1 Then
                mRowIndex = -1
            End If
            For i As Integer = mRowIndex + 1 To .RowCount - 1
                If .Item(Combo1.SelectedIndex, i).Value.ToString.ToUpper.Contains((TxtKeyword.Text).ToUpper) Then
                    mRowIndex = i
                    Return True
                End If
            Next
        End With

        Return False
    End Function

    'Public Sub InitialFind(ByVal frmFrom As Form, ByVal Fx As DataGridView)
    '    Dim i As Long = 0
    '    frm = frmFrom
    '    grid = Fx
    '    Combo1.Items.Clear()
    '    For Each column As DataGridViewColumn In grid.Columns
    '        Combo1.Items.Add(column.HeaderText)
    '    Next
    'End Sub

    Private Sub TxtKeyword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKeyword.KeyPress
        'If Asc(e.KeyChar) = 13 Then Combo1.Focus()
    End Sub

    Private Sub InitialFind()
        Combo1.Items.Clear()
        For Each column As DataGridViewColumn In mDataGridFind.Columns
            Combo1.Items.Add(column.HeaderText)
        Next
        Combo1.SelectedIndex = 1
    End Sub

    Public Sub InitialFormFind(ByRef pDataGrid As DataGridView)
        mDataGridFind = pDataGrid
        InitialFind()
        mRowIndex = -1
        TxtKeyword.Text = ""
    End Sub
    Public Sub InitialFormFind(ByRef pDataGrid As DataGridView, ByVal pIndex As Integer)
        mDataGridFind = pDataGrid
        InitialFind()
        mRowIndex = -1
        TxtKeyword.Text = ""
        Combo1.SelectedIndex = pIndex
    End Sub

    Private Sub bSerach_Click(sender As System.Object, e As System.EventArgs) Handles bSerach.Click
        If FindKey() Then
            mDataGridFind.ClearSelection()
            'mDataGridFind.Rows(mRowIndex).Selected = True
            mDataGridFind.CurrentCell = mDataGridFind.Item(0, mRowIndex)
            If mRowIndex > 0 Then
                mDataGridFind.FirstDisplayedScrollingRowIndex = mRowIndex - 1
            Else
                mDataGridFind.FirstDisplayedScrollingRowIndex = mRowIndex
            End If
        Else
            MessageBox.Show("ไม่พบข้อมูลที่ต้องการค้นหา")
            TxtKeyword.Focus()
            mRowIndex = -1
        End If
    End Sub

    Private Sub TxtKeyword_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TxtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If FindKey() Then
                mDataGridFind.ClearSelection()
                'mDataGridFind.Rows(mRowIndex).Selected = True
                mDataGridFind.CurrentCell = mDataGridFind.Item(0, mRowIndex)
                If mRowIndex > 0 Then
                    mDataGridFind.FirstDisplayedScrollingRowIndex = mRowIndex - 1
                Else
                    mDataGridFind.FirstDisplayedScrollingRowIndex = mRowIndex
                End If
            Else
                MessageBox.Show("ไม่พบข้อมูลที่ต้องการค้นหา")
                TxtKeyword.Focus()
                mRowIndex = -1
            End If
        End If
    End Sub
End Class