<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemark
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
        Me.cbRemark = New System.Windows.Forms.ComboBox()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbRemark
        '
        Me.cbRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbRemark.FormattingEnabled = True
        Me.cbRemark.Location = New System.Drawing.Point(37, 57)
        Me.cbRemark.Name = "cbRemark"
        Me.cbRemark.Size = New System.Drawing.Size(674, 28)
        Me.cbRemark.TabIndex = 1
        '
        'CmdOK
        '
        Me.CmdOK.BackColor = System.Drawing.Color.White
        Me.CmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdOK.Location = New System.Drawing.Point(37, 103)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(75, 32)
        Me.CmdOK.TabIndex = 2
        Me.CmdOK.Text = "ตกลง"
        Me.CmdOK.UseVisualStyleBackColor = False
        '
        'CmdCancel
        '
        Me.CmdCancel.BackColor = System.Drawing.Color.White
        Me.CmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdCancel.Location = New System.Drawing.Point(129, 103)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(75, 32)
        Me.CmdCancel.TabIndex = 3
        Me.CmdCancel.Text = "ยกเลิก"
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'frmRemark
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 158)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.cbRemark)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRemark"
        Me.Text = "# หมายเหตุ #"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbRemark As System.Windows.Forms.ComboBox
    Friend WithEvents CmdOK As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
End Class
