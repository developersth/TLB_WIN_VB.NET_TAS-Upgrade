<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadDo_new
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
        Me.txtOld_DO = New System.Windows.Forms.TextBox()
        Me.txtNew_DO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bt_Cancel = New System.Windows.Forms.Button()
        Me.bt_Save = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOld_DO
        '
        Me.txtOld_DO.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtOld_DO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtOld_DO.Location = New System.Drawing.Point(83, 74)
        Me.txtOld_DO.Name = "txtOld_DO"
        Me.txtOld_DO.ReadOnly = True
        Me.txtOld_DO.Size = New System.Drawing.Size(263, 26)
        Me.txtOld_DO.TabIndex = 0
        '
        'txtNew_DO
        '
        Me.txtNew_DO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtNew_DO.Location = New System.Drawing.Point(83, 108)
        Me.txtNew_DO.Name = "txtNew_DO"
        Me.txtNew_DO.Size = New System.Drawing.Size(263, 26)
        Me.txtNew_DO.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(10, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DO เก่า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(10, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DO ใหม่"
        '
        'bt_Cancel
        '
        Me.bt_Cancel.BackColor = System.Drawing.Color.Yellow
        Me.bt_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.bt_Cancel.Location = New System.Drawing.Point(212, 153)
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
        Me.bt_Save.Location = New System.Drawing.Point(91, 153)
        Me.bt_Save.Name = "bt_Save"
        Me.bt_Save.Size = New System.Drawing.Size(104, 41)
        Me.bt_Save.TabIndex = 41
        Me.bt_Save.Text = "Save"
        Me.bt_Save.UseVisualStyleBackColor = False
        '
        'frmLoadDo_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 222)
        Me.Controls.Add(Me.bt_Cancel)
        Me.Controls.Add(Me.bt_Save)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNew_DO)
        Me.Controls.Add(Me.txtOld_DO)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoadDo_new"
        Me.Text = "frmDo_new"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOld_DO As System.Windows.Forms.TextBox
    Friend WithEvents txtNew_DO As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_Cancel As System.Windows.Forms.Button
    Friend WithEvents bt_Save As System.Windows.Forms.Button
End Class
