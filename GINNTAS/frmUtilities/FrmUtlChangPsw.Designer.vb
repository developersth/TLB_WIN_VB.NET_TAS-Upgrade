<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUtlChangPsw
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPassOld = New System.Windows.Forms.TextBox()
        Me.Gropbox3 = New System.Windows.Forms.GroupBox()
        Me.txtPassNew1 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtPassNew2 = New System.Windows.Forms.TextBox()
        Me.SAVE = New System.Windows.Forms.Button()
        Me.Cancle = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Gropbox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 57)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ชื่อผู้ใช้"
        '
        'txtUsername
        '
        Me.txtUsername.Enabled = False
        Me.txtUsername.Location = New System.Drawing.Point(20, 20)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(222, 26)
        Me.txtUsername.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPassOld)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(13, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 57)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "รหัสผ่านเดิม"
        '
        'txtPassOld
        '
        Me.txtPassOld.Location = New System.Drawing.Point(20, 20)
        Me.txtPassOld.Name = "txtPassOld"
        Me.txtPassOld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassOld.Size = New System.Drawing.Size(222, 26)
        Me.txtPassOld.TabIndex = 0
        '
        'Gropbox3
        '
        Me.Gropbox3.Controls.Add(Me.txtPassNew1)
        Me.Gropbox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Gropbox3.Location = New System.Drawing.Point(13, 139)
        Me.Gropbox3.Name = "Gropbox3"
        Me.Gropbox3.Size = New System.Drawing.Size(248, 57)
        Me.Gropbox3.TabIndex = 2
        Me.Gropbox3.TabStop = False
        Me.Gropbox3.Text = "รหัสผ่านใหม่"
        '
        'txtPassNew1
        '
        Me.txtPassNew1.Location = New System.Drawing.Point(20, 20)
        Me.txtPassNew1.Name = "txtPassNew1"
        Me.txtPassNew1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassNew1.Size = New System.Drawing.Size(222, 26)
        Me.txtPassNew1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtPassNew2)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(13, 202)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(248, 57)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ยืนยันรหัสผ่านใหม่"
        '
        'txtPassNew2
        '
        Me.txtPassNew2.Location = New System.Drawing.Point(20, 20)
        Me.txtPassNew2.Name = "txtPassNew2"
        Me.txtPassNew2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassNew2.Size = New System.Drawing.Size(222, 26)
        Me.txtPassNew2.TabIndex = 0
        '
        'SAVE
        '
        Me.SAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SAVE.Location = New System.Drawing.Point(45, 265)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(75, 36)
        Me.SAVE.TabIndex = 3
        Me.SAVE.Text = "ตกลง"
        Me.SAVE.UseVisualStyleBackColor = True
        '
        'Cancle
        '
        Me.Cancle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Cancle.Location = New System.Drawing.Point(142, 265)
        Me.Cancle.Name = "Cancle"
        Me.Cancle.Size = New System.Drawing.Size(75, 36)
        Me.Cancle.TabIndex = 4
        Me.Cancle.Text = "ยกเลิก"
        Me.Cancle.UseVisualStyleBackColor = True
        '
        'FrmUtlChangPsw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 324)
        Me.Controls.Add(Me.Cancle)
        Me.Controls.Add(Me.SAVE)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Gropbox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUtlChangPsw"
        Me.Text = "เปลี่ยนรหัสผ่าน"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Gropbox3.ResumeLayout(False)
        Me.Gropbox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPassOld As System.Windows.Forms.TextBox
    Friend WithEvents Gropbox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPassNew1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPassNew2 As System.Windows.Forms.TextBox
    Friend WithEvents SAVE As System.Windows.Forms.Button
    Friend WithEvents Cancle As System.Windows.Forms.Button
End Class
