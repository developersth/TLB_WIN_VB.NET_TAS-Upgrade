<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMMIwbLampTest
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
        Me.cmdTestLamp0 = New System.Windows.Forms.Button()
        Me.cmdTestLamp1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdTestLamp0
        '
        Me.cmdTestLamp0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdTestLamp0.Location = New System.Drawing.Point(36, 35)
        Me.cmdTestLamp0.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdTestLamp0.Name = "cmdTestLamp0"
        Me.cmdTestLamp0.Size = New System.Drawing.Size(212, 86)
        Me.cmdTestLamp0.TabIndex = 0
        Me.cmdTestLamp0.Text = "START LAMP"
        Me.cmdTestLamp0.UseVisualStyleBackColor = True
        '
        'cmdTestLamp1
        '
        Me.cmdTestLamp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdTestLamp1.Location = New System.Drawing.Point(40, 145)
        Me.cmdTestLamp1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdTestLamp1.Name = "cmdTestLamp1"
        Me.cmdTestLamp1.Size = New System.Drawing.Size(212, 86)
        Me.cmdTestLamp1.TabIndex = 1
        Me.cmdTestLamp1.Text = "STOP LAMP"
        Me.cmdTestLamp1.UseVisualStyleBackColor = True
        '
        'frmMMIwbLampTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 278)
        Me.Controls.Add(Me.cmdTestLamp1)
        Me.Controls.Add(Me.cmdTestLamp0)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMMIwbLampTest"
        Me.Text = "Test Lamp"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdTestLamp0 As System.Windows.Forms.Button
    Friend WithEvents cmdTestLamp1 As System.Windows.Forms.Button
End Class
