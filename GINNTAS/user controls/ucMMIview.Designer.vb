<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMMIview
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.leftBay = New System.Windows.Forms.Button()
        Me.rightBay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'leftBay
        '
        Me.leftBay.Location = New System.Drawing.Point(47, 40)
        Me.leftBay.Name = "leftBay"
        Me.leftBay.Size = New System.Drawing.Size(75, 23)
        Me.leftBay.TabIndex = 0
        Me.leftBay.Text = "Button1"
        Me.leftBay.UseVisualStyleBackColor = True
        '
        'rightBay
        '
        Me.rightBay.Location = New System.Drawing.Point(345, 40)
        Me.rightBay.Name = "rightBay"
        Me.rightBay.Size = New System.Drawing.Size(75, 23)
        Me.rightBay.TabIndex = 1
        Me.rightBay.Text = "Button2"
        Me.rightBay.UseVisualStyleBackColor = True
        '
        'ucMMIview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.rightBay)
        Me.Controls.Add(Me.leftBay)
        Me.Name = "ucMMIview"
        Me.Size = New System.Drawing.Size(500, 250)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcProgressOverView1 As GINNTAS.ucProgressOverView
    Friend WithEvents UcProgressOverView2 As GINNTAS.ucProgressOverView
    Friend WithEvents leftBay As System.Windows.Forms.Button
    Friend WithEvents rightBay As System.Windows.Forms.Button

End Class
