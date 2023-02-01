<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtlAddSeal
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
        Me.lblOk = New System.Windows.Forms.Button()
        Me.lblClose = New System.Windows.Forms.Button()
        Me.txtSealAmount = New System.Windows.Forms.TextBox()
        Me.txtSealStart = New System.Windows.Forms.TextBox()
        Me.txtLastSeal = New System.Windows.Forms.TextBox()
        Me.จำนวน = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCalSeal = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblOk
        '
        Me.lblOk.BackColor = System.Drawing.Color.Lime
        Me.lblOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblOk.Location = New System.Drawing.Point(199, 172)
        Me.lblOk.Name = "lblOk"
        Me.lblOk.Size = New System.Drawing.Size(75, 28)
        Me.lblOk.TabIndex = 0
        Me.lblOk.Text = "ตกลง"
        Me.lblOk.UseVisualStyleBackColor = False
        '
        'lblClose
        '
        Me.lblClose.BackColor = System.Drawing.Color.Red
        Me.lblClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblClose.Location = New System.Drawing.Point(286, 172)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(75, 28)
        Me.lblClose.TabIndex = 1
        Me.lblClose.Text = "ปิด"
        Me.lblClose.UseVisualStyleBackColor = False
        '
        'txtSealAmount
        '
        Me.txtSealAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSealAmount.Location = New System.Drawing.Point(89, 67)
        Me.txtSealAmount.Name = "txtSealAmount"
        Me.txtSealAmount.Size = New System.Drawing.Size(100, 26)
        Me.txtSealAmount.TabIndex = 2
        '
        'txtSealStart
        '
        Me.txtSealStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSealStart.Location = New System.Drawing.Point(89, 105)
        Me.txtSealStart.Name = "txtSealStart"
        Me.txtSealStart.Size = New System.Drawing.Size(100, 26)
        Me.txtSealStart.TabIndex = 3
        '
        'txtLastSeal
        '
        Me.txtLastSeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLastSeal.Location = New System.Drawing.Point(263, 108)
        Me.txtLastSeal.Name = "txtLastSeal"
        Me.txtLastSeal.Size = New System.Drawing.Size(100, 26)
        Me.txtLastSeal.TabIndex = 4
        '
        'จำนวน
        '
        Me.จำนวน.AutoSize = True
        Me.จำนวน.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.จำนวน.Location = New System.Drawing.Point(34, 70)
        Me.จำนวน.Name = "จำนวน"
        Me.จำนวน.Size = New System.Drawing.Size(49, 20)
        Me.จำนวน.TabIndex = 5
        Me.จำนวน.Text = "จำนวน"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ซีลเริ่มต้น"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(192, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ซีลสุดท้าย"
        '
        'lblCalSeal
        '
        Me.lblCalSeal.BackColor = System.Drawing.Color.Yellow
        Me.lblCalSeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCalSeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCalSeal.Location = New System.Drawing.Point(261, 66)
        Me.lblCalSeal.Name = "lblCalSeal"
        Me.lblCalSeal.Size = New System.Drawing.Size(100, 29)
        Me.lblCalSeal.TabIndex = 8
        Me.lblCalSeal.Text = "คำนวณ"
        Me.lblCalSeal.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(195, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ตัว"
        '
        'frmUtlAddSeal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 207)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCalSeal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.จำนวน)
        Me.Controls.Add(Me.txtLastSeal)
        Me.Controls.Add(Me.txtSealStart)
        Me.Controls.Add(Me.txtSealAmount)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblOk)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUtlAddSeal"
        Me.Text = "คำนวณซีล"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOk As System.Windows.Forms.Button
    Friend WithEvents lblClose As System.Windows.Forms.Button
    Friend WithEvents txtSealAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtSealStart As System.Windows.Forms.TextBox
    Friend WithEvents txtLastSeal As System.Windows.Forms.TextBox
    Friend WithEvents จำนวน As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCalSeal As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
