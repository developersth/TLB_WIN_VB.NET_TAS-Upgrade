<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadEditVolumeDo
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btCancle = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtVolumeOld = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVolumeNew = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 20)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "หมายเลข DO"
        '
        'txtDo
        '
        Me.txtDo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDo.Enabled = False
        Me.txtDo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDo.Location = New System.Drawing.Point(136, 7)
        Me.txtDo.Name = "txtDo"
        Me.txtDo.Size = New System.Drawing.Size(308, 26)
        Me.txtDo.TabIndex = 136
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(11, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 20)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "ปริมาณผลิตภัณฑ์ใหม่"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(10, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 20)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "ชื่อผลิตภัณฑ์"
        '
        'btCancle
        '
        Me.btCancle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btCancle.BackColor = System.Drawing.Color.Yellow
        Me.btCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btCancle.Location = New System.Drawing.Point(224, 147)
        Me.btCancle.Name = "btCancle"
        Me.btCancle.Size = New System.Drawing.Size(135, 48)
        Me.btCancle.TabIndex = 150
        Me.btCancle.Text = "cancel"
        Me.btCancle.UseVisualStyleBackColor = False
        '
        'btSave
        '
        Me.btSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btSave.BackColor = System.Drawing.Color.Lime
        Me.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btSave.Location = New System.Drawing.Point(72, 147)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(134, 49)
        Me.btSave.TabIndex = 149
        Me.btSave.Text = "save"
        Me.btSave.UseVisualStyleBackColor = False
        '
        'txtProduct
        '
        Me.txtProduct.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtProduct.Enabled = False
        Me.txtProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProduct.Location = New System.Drawing.Point(136, 41)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(308, 26)
        Me.txtProduct.TabIndex = 151
        '
        'txtVolumeOld
        '
        Me.txtVolumeOld.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtVolumeOld.Enabled = False
        Me.txtVolumeOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVolumeOld.Location = New System.Drawing.Point(185, 74)
        Me.txtVolumeOld.Name = "txtVolumeOld"
        Me.txtVolumeOld.Size = New System.Drawing.Size(259, 26)
        Me.txtVolumeOld.TabIndex = 153
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(9, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "ปริมาณผลิตภัณฑ์เดิม"
        '
        'txtVolumeNew
        '
        Me.txtVolumeNew.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtVolumeNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVolumeNew.Location = New System.Drawing.Point(185, 110)
        Me.txtVolumeNew.Name = "txtVolumeNew"
        Me.txtVolumeNew.Size = New System.Drawing.Size(259, 26)
        Me.txtVolumeNew.TabIndex = 154
        '
        'frmLoadEditVolumeDo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 210)
        Me.Controls.Add(Me.txtVolumeNew)
        Me.Controls.Add(Me.txtVolumeOld)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.btCancle)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoadEditVolumeDo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "แก้ไขปริมาณผลิตภัณฑ์"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btCancle As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtProduct As System.Windows.Forms.TextBox
    Friend WithEvents txtVolumeOld As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtVolumeNew As System.Windows.Forms.TextBox
End Class
