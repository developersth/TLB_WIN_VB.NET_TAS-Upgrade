<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadEditExcise
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
        Me.txExciseNameOld = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_Cancel = New System.Windows.Forms.Button()
        Me.bt_Save = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbExciseName = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txExciseNameOld
        '
        Me.txExciseNameOld.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txExciseNameOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txExciseNameOld.Location = New System.Drawing.Point(221, 66)
        Me.txExciseNameOld.Name = "txExciseNameOld"
        Me.txExciseNameOld.ReadOnly = True
        Me.txExciseNameOld.Size = New System.Drawing.Size(263, 35)
        Me.txExciseNameOld.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(10, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ชื่อเจ้าหน้าที่สรรพสามิตเดิม :"
        '
        'bt_Cancel
        '
        Me.bt_Cancel.BackColor = System.Drawing.Color.Yellow
        Me.bt_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.bt_Cancel.Location = New System.Drawing.Point(346, 173)
        Me.bt_Cancel.Name = "bt_Cancel"
        Me.bt_Cancel.Size = New System.Drawing.Size(103, 41)
        Me.bt_Cancel.TabIndex = 42
        Me.bt_Cancel.Text = "Cancel"
        Me.bt_Cancel.UseVisualStyleBackColor = False
        '
        'bt_Save
        '
        Me.bt_Save.BackColor = System.Drawing.Color.Lime
        Me.bt_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.bt_Save.Location = New System.Drawing.Point(236, 173)
        Me.bt_Save.Name = "bt_Save"
        Me.bt_Save.Size = New System.Drawing.Size(104, 41)
        Me.bt_Save.TabIndex = 41
        Me.bt_Save.Text = "Save"
        Me.bt_Save.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(9, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 20)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "ชื่อเจ้าหน้าที่สรรพสามิตใหม่ :"
        '
        'cbExciseName
        '
        Me.cbExciseName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbExciseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbExciseName.FormattingEnabled = True
        Me.cbExciseName.Location = New System.Drawing.Point(219, 117)
        Me.cbExciseName.Name = "cbExciseName"
        Me.cbExciseName.Size = New System.Drawing.Size(265, 32)
        Me.cbExciseName.TabIndex = 154
        '
        'frmLoadEditExcise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 237)
        Me.Controls.Add(Me.cbExciseName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bt_Cancel)
        Me.Controls.Add(Me.bt_Save)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txExciseNameOld)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoadEditExcise"
        Me.Text = "เปลี่ยนชื่อเจ้าที่สรรพสามิต"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txExciseNameOld As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_Cancel As System.Windows.Forms.Button
    Friend WithEvents bt_Save As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbExciseName As System.Windows.Forms.ComboBox
End Class
