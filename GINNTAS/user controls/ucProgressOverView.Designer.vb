<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProgressOverView
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
        Me.lblsumCapacity = New System.Windows.Forms.Label()
        Me.lblsumAdvice = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BarProgress = New System.Windows.Forms.Label()
        Me.perProgress = New System.Windows.Forms.Label()
        Me.Green = New System.Windows.Forms.Label()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.txtPercent = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblsumCapacity
        '
        Me.lblsumCapacity.AutoSize = True
        Me.lblsumCapacity.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblsumCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblsumCapacity.ForeColor = System.Drawing.Color.White
        Me.lblsumCapacity.Location = New System.Drawing.Point(54, 40)
        Me.lblsumCapacity.Name = "lblsumCapacity"
        Me.lblsumCapacity.Size = New System.Drawing.Size(69, 12)
        Me.lblsumCapacity.TabIndex = 30
        Me.lblsumCapacity.Text = "lblsumCapacity"
        '
        'lblsumAdvice
        '
        Me.lblsumAdvice.AutoSize = True
        Me.lblsumAdvice.BackColor = System.Drawing.Color.Black
        Me.lblsumAdvice.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblsumAdvice.ForeColor = System.Drawing.Color.DeepPink
        Me.lblsumAdvice.Location = New System.Drawing.Point(54, 61)
        Me.lblsumAdvice.Name = "lblsumAdvice"
        Me.lblsumAdvice.Size = New System.Drawing.Size(62, 12)
        Me.lblsumAdvice.TabIndex = 29
        Me.lblsumAdvice.Text = "lblsumAdvice"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(4, 146)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(21, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(4, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(21, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BarProgress
        '
        Me.BarProgress.BackColor = System.Drawing.Color.MediumBlue
        Me.BarProgress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BarProgress.ForeColor = System.Drawing.Color.Red
        Me.BarProgress.Location = New System.Drawing.Point(16, 41)
        Me.BarProgress.Name = "BarProgress"
        Me.BarProgress.Size = New System.Drawing.Size(33, 200)
        Me.BarProgress.TabIndex = 26
        '
        'perProgress
        '
        Me.perProgress.BackColor = System.Drawing.Color.White
        Me.perProgress.ForeColor = System.Drawing.Color.Red
        Me.perProgress.Location = New System.Drawing.Point(15, 41)
        Me.perProgress.Name = "perProgress"
        Me.perProgress.Size = New System.Drawing.Size(33, 200)
        Me.perProgress.TabIndex = 25
        '
        'Green
        '
        Me.Green.BackColor = System.Drawing.Color.Lime
        Me.Green.ForeColor = System.Drawing.Color.Lime
        Me.Green.Location = New System.Drawing.Point(14, 40)
        Me.Green.Name = "Green"
        Me.Green.Size = New System.Drawing.Size(36, 202)
        Me.Green.TabIndex = 24
        Me.Green.Text = "56.7"
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.BackColor = System.Drawing.Color.Black
        Me.lblProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblProgress.ForeColor = System.Drawing.Color.Yellow
        Me.lblProgress.Location = New System.Drawing.Point(55, 82)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(51, 12)
        Me.lblProgress.TabIndex = 31
        Me.lblProgress.Text = "lblProgress"
        '
        'txtPercent
        '
        Me.txtPercent.Location = New System.Drawing.Point(75, 111)
        Me.txtPercent.Name = "txtPercent"
        Me.txtPercent.Size = New System.Drawing.Size(30, 20)
        Me.txtPercent.TabIndex = 33
        Me.txtPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ucProgressOverView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtPercent)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.lblsumCapacity)
        Me.Controls.Add(Me.lblsumAdvice)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BarProgress)
        Me.Controls.Add(Me.perProgress)
        Me.Controls.Add(Me.Green)
        Me.MinimumSize = New System.Drawing.Size(50, 100)
        Me.Name = "ucProgressOverView"
        Me.Size = New System.Drawing.Size(147, 250)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblsumCapacity As System.Windows.Forms.Label
    Friend WithEvents lblsumAdvice As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BarProgress As System.Windows.Forms.Label
    Friend WithEvents perProgress As System.Windows.Forms.Label
    Friend WithEvents Green As System.Windows.Forms.Label
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents txtPercent As System.Windows.Forms.TextBox

End Class
