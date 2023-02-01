<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMMIBayLoadingTopUP
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCompartment = New System.Windows.Forms.TextBox()
        Me.txtTopUP1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTopUP2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmdOK = New System.Windows.Forms.Button()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ช่องเติมที่"
        '
        'txtCompartment
        '
        Me.txtCompartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCompartment.Location = New System.Drawing.Point(133, 6)
        Me.txtCompartment.Name = "txtCompartment"
        Me.txtCompartment.Size = New System.Drawing.Size(137, 26)
        Me.txtCompartment.TabIndex = 1
        '
        'txtTopUP1
        '
        Me.txtTopUP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTopUP1.Location = New System.Drawing.Point(133, 34)
        Me.txtTopUP1.Name = "txtTopUP1"
        Me.txtTopUP1.Size = New System.Drawing.Size(137, 26)
        Me.txtTopUP1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ค่า TOPUP เดิม"
        '
        'txtTopUP2
        '
        Me.txtTopUP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTopUP2.Location = New System.Drawing.Point(133, 64)
        Me.txtTopUP2.Name = "txtTopUP2"
        Me.txtTopUP2.Size = New System.Drawing.Size(137, 26)
        Me.txtTopUP2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ค่า TOPUP ใหม่"
        '
        'CmdOK
        '
        Me.CmdOK.BackColor = System.Drawing.Color.White
        Me.CmdOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdOK.Location = New System.Drawing.Point(110, 104)
        Me.CmdOK.Name = "CmdOK"
        Me.CmdOK.Size = New System.Drawing.Size(75, 30)
        Me.CmdOK.TabIndex = 6
        Me.CmdOK.Text = "OK"
        Me.CmdOK.UseVisualStyleBackColor = False
        '
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.White
        Me.CmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdClose.Location = New System.Drawing.Point(191, 104)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(75, 30)
        Me.CmdClose.TabIndex = 7
        Me.CmdClose.Text = "Cancle"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'frmMMIBayLoadingTopUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 146)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.CmdOK)
        Me.Controls.Add(Me.txtTopUP2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTopUP1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCompartment)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMMIBayLoadingTopUP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMMIBayLoadingTopUP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCompartment As System.Windows.Forms.TextBox
    Friend WithEvents txtTopUP1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTopUP2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmdOK As System.Windows.Forms.Button
    Friend WithEvents CmdClose As System.Windows.Forms.Button
End Class
