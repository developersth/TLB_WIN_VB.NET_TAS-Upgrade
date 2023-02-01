<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMixEditWeight
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtOldWeightIn = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtNewWeightOut = New System.Windows.Forms.TextBox()
        Me.txtNewWeightIn = New System.Windows.Forms.TextBox()
        Me.txtOldWeightOut = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bt_Cancel = New System.Windows.Forms.Button()
        Me.bt_Save = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLoadNo = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOldWeightIn
        '
        Me.txtOldWeightIn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtOldWeightIn.Enabled = False
        Me.txtOldWeightIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtOldWeightIn.Location = New System.Drawing.Point(3, 3)
        Me.txtOldWeightIn.Name = "txtOldWeightIn"
        Me.txtOldWeightIn.Size = New System.Drawing.Size(121, 26)
        Me.txtOldWeightIn.TabIndex = 155
        Me.txtOldWeightIn.Text = "-"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(10, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 20)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "น้ำหนักเก่า =>"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(8, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 20)
        Me.Label11.TabIndex = 152
        Me.Label11.Text = "น้ำหนักใหม่ =>"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtNewWeightOut, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNewWeightIn, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtOldWeightOut, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtOldWeightIn, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(121, 83)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(254, 67)
        Me.TableLayoutPanel1.TabIndex = 156
        '
        'txtNewWeightOut
        '
        Me.txtNewWeightOut.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNewWeightOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNewWeightOut.Location = New System.Drawing.Point(130, 36)
        Me.txtNewWeightOut.Name = "txtNewWeightOut"
        Me.txtNewWeightOut.Size = New System.Drawing.Size(121, 26)
        Me.txtNewWeightOut.TabIndex = 158
        Me.txtNewWeightOut.Text = "-"
        '
        'txtNewWeightIn
        '
        Me.txtNewWeightIn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNewWeightIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNewWeightIn.Location = New System.Drawing.Point(3, 36)
        Me.txtNewWeightIn.Name = "txtNewWeightIn"
        Me.txtNewWeightIn.Size = New System.Drawing.Size(121, 26)
        Me.txtNewWeightIn.TabIndex = 157
        Me.txtNewWeightIn.Text = "-"
        '
        'txtOldWeightOut
        '
        Me.txtOldWeightOut.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtOldWeightOut.Enabled = False
        Me.txtOldWeightOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtOldWeightOut.Location = New System.Drawing.Point(130, 3)
        Me.txtOldWeightOut.Name = "txtOldWeightOut"
        Me.txtOldWeightOut.Size = New System.Drawing.Size(121, 26)
        Me.txtOldWeightOut.TabIndex = 156
        Me.txtOldWeightOut.Text = "-"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(148, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 157
        Me.Label1.Text = "ชั่งเข้า"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(283, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "ชั่งออก"
        '
        'bt_Cancel
        '
        Me.bt_Cancel.BackColor = System.Drawing.Color.Yellow
        Me.bt_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.bt_Cancel.Location = New System.Drawing.Point(254, 176)
        Me.bt_Cancel.Name = "bt_Cancel"
        Me.bt_Cancel.Size = New System.Drawing.Size(103, 40)
        Me.bt_Cancel.TabIndex = 160
        Me.bt_Cancel.Text = "Cancel"
        Me.bt_Cancel.UseVisualStyleBackColor = False
        '
        'bt_Save
        '
        Me.bt_Save.BackColor = System.Drawing.Color.Lime
        Me.bt_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.bt_Save.Location = New System.Drawing.Point(137, 175)
        Me.bt_Save.Name = "bt_Save"
        Me.bt_Save.Size = New System.Drawing.Size(104, 41)
        Me.bt_Save.TabIndex = 159
        Me.bt_Save.Text = "Save"
        Me.bt_Save.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(14, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "Load No =>"
        '
        'txtLoadNo
        '
        Me.txtLoadNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtLoadNo.Enabled = False
        Me.txtLoadNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLoadNo.Location = New System.Drawing.Point(3, 3)
        Me.txtLoadNo.Name = "txtLoadNo"
        Me.txtLoadNo.Size = New System.Drawing.Size(246, 26)
        Me.txtLoadNo.TabIndex = 162
        Me.txtLoadNo.Text = "-"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtLoadNo, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(123, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(252, 32)
        Me.TableLayoutPanel2.TabIndex = 163
        '
        'frmMixEditWeight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 225)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bt_Cancel)
        Me.Controls.Add(Me.bt_Save)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.MaximizeBox = False
        Me.Name = "frmMixEditWeight"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMixEditWeight"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOldWeightIn As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtNewWeightOut As System.Windows.Forms.TextBox
    Friend WithEvents txtNewWeightIn As System.Windows.Forms.TextBox
    Friend WithEvents txtOldWeightOut As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_Cancel As System.Windows.Forms.Button
    Friend WithEvents bt_Save As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLoadNo As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
End Class
