<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFind
    Inherits MetroFramework.Forms.MetroForm

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
        Me.TxtKeyword = New System.Windows.Forms.TextBox()
        Me.ckFind = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bSerach = New System.Windows.Forms.Button()
        Me.Combo1 = New MetroFramework.Controls.MetroComboBox()
        Me.SuspendLayout()
        '
        'TxtKeyword
        '
        Me.TxtKeyword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKeyword.Location = New System.Drawing.Point(112, 104)
        Me.TxtKeyword.Name = "TxtKeyword"
        Me.TxtKeyword.Size = New System.Drawing.Size(313, 26)
        Me.TxtKeyword.TabIndex = 2
        '
        'ckFind
        '
        Me.ckFind.AutoSize = True
        Me.ckFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ckFind.Location = New System.Drawing.Point(195, 219)
        Me.ckFind.Name = "ckFind"
        Me.ckFind.Size = New System.Drawing.Size(121, 24)
        Me.ckFind.TabIndex = 1
        Me.ckFind.Text = "ค้นหาจากบนสุด"
        Me.ckFind.UseVisualStyleBackColor = True
        Me.ckFind.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ข้อความ"
        '
        'bCancel
        '
        Me.bCancel.BackColor = System.Drawing.Color.Red
        Me.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCancel.Location = New System.Drawing.Point(264, 162)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(123, 42)
        Me.bCancel.TabIndex = 4
        Me.bCancel.Text = "ยกเลิก"
        Me.bCancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ค้นหาจาก"
        '
        'bSerach
        '
        Me.bSerach.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bSerach.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSerach.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.bSerach.Location = New System.Drawing.Point(128, 162)
        Me.bSerach.Name = "bSerach"
        Me.bSerach.Size = New System.Drawing.Size(115, 42)
        Me.bSerach.TabIndex = 3
        Me.bSerach.Text = "ค้นหา"
        Me.bSerach.UseVisualStyleBackColor = False
        '
        'Combo1
        '
        Me.Combo1.FormattingEnabled = True
        Me.Combo1.ItemHeight = 23
        Me.Combo1.Location = New System.Drawing.Point(112, 60)
        Me.Combo1.Name = "Combo1"
        Me.Combo1.Size = New System.Drawing.Size(313, 29)
        Me.Combo1.TabIndex = 1
        Me.Combo1.UseSelectable = True
        '
        'frmFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 258)
        Me.Controls.Add(Me.Combo1)
        Me.Controls.Add(Me.bSerach)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ckFind)
        Me.Controls.Add(Me.TxtKeyword)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFind"
        Me.Text = "Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtKeyword As System.Windows.Forms.TextBox
    Friend WithEvents ckFind As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bCancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bSerach As System.Windows.Forms.Button
    Friend WithEvents Combo1 As MetroFramework.Controls.MetroComboBox
End Class
