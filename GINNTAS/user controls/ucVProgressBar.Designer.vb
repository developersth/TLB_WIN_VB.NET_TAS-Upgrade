<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucVProgressBar
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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.shpLSLL = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shpLSL = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shpLSH = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shpLSHH = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shpProgressBar = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shpAdviceLimit = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shpCapacityLimit = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.lblAdvice = New System.Windows.Forms.Label()
        Me.lblProgressBar = New System.Windows.Forms.Label()
        Me.lblLSH = New System.Windows.Forms.Label()
        Me.lblLSHH = New System.Windows.Forms.Label()
        Me.lblLSL = New System.Windows.Forms.Label()
        Me.lblLSLL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.shpLSLL, Me.shpLSL, Me.shpLSH, Me.shpLSHH, Me.shpProgressBar, Me.shpAdviceLimit, Me.shpCapacityLimit})
        Me.ShapeContainer1.Size = New System.Drawing.Size(187, 441)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'shpLSLL
        '
        Me.shpLSLL.BackColor = System.Drawing.SystemColors.Control
        Me.shpLSLL.BorderColor = System.Drawing.Color.Red
        Me.shpLSLL.FillColor = System.Drawing.Color.White
        Me.shpLSLL.Location = New System.Drawing.Point(184, 100)
        Me.shpLSLL.Name = "shpLSLL"
        Me.shpLSLL.Size = New System.Drawing.Size(49, 126)
        Me.shpLSLL.Visible = False
        '
        'shpLSL
        '
        Me.shpLSL.BackColor = System.Drawing.SystemColors.Control
        Me.shpLSL.BorderColor = System.Drawing.Color.Red
        Me.shpLSL.FillColor = System.Drawing.Color.White
        Me.shpLSL.Location = New System.Drawing.Point(170, 84)
        Me.shpLSL.Name = "shpLSL"
        Me.shpLSL.Size = New System.Drawing.Size(48, 126)
        Me.shpLSL.Visible = False
        '
        'shpLSH
        '
        Me.shpLSH.BackColor = System.Drawing.SystemColors.Control
        Me.shpLSH.BorderColor = System.Drawing.Color.Red
        Me.shpLSH.FillColor = System.Drawing.Color.White
        Me.shpLSH.Location = New System.Drawing.Point(176, 29)
        Me.shpLSH.Name = "shpLSH"
        Me.shpLSH.Size = New System.Drawing.Size(48, 126)
        Me.shpLSH.Visible = False
        '
        'shpLSHH
        '
        Me.shpLSHH.BackColor = System.Drawing.SystemColors.Control
        Me.shpLSHH.BorderColor = System.Drawing.Color.Red
        Me.shpLSHH.FillColor = System.Drawing.Color.White
        Me.shpLSHH.Location = New System.Drawing.Point(154, 86)
        Me.shpLSHH.Name = "shpLSHH"
        Me.shpLSHH.Size = New System.Drawing.Size(48, 126)
        Me.shpLSHH.Visible = False
        '
        'shpProgressBar
        '
        Me.shpProgressBar.BackColor = System.Drawing.SystemColors.Control
        Me.shpProgressBar.BorderColor = System.Drawing.Color.Yellow
        Me.shpProgressBar.FillColor = System.Drawing.Color.Yellow
        Me.shpProgressBar.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shpProgressBar.Location = New System.Drawing.Point(5, 93)
        Me.shpProgressBar.Name = "shpProgressBar"
        Me.shpProgressBar.Size = New System.Drawing.Size(80, 45)
        '
        'shpAdviceLimit
        '
        Me.shpAdviceLimit.BackColor = System.Drawing.SystemColors.Control
        Me.shpAdviceLimit.BorderColor = System.Drawing.Color.Lime
        Me.shpAdviceLimit.FillColor = System.Drawing.Color.White
        Me.shpAdviceLimit.Location = New System.Drawing.Point(5, 153)
        Me.shpAdviceLimit.Name = "shpAdviceLimit"
        Me.shpAdviceLimit.Size = New System.Drawing.Size(86, 117)
        '
        'shpCapacityLimit
        '
        Me.shpCapacityLimit.BackColor = System.Drawing.SystemColors.Control
        Me.shpCapacityLimit.FillColor = System.Drawing.Color.White
        Me.shpCapacityLimit.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.shpCapacityLimit.Location = New System.Drawing.Point(3, 22)
        Me.shpCapacityLimit.Name = "shpCapacityLimit"
        Me.shpCapacityLimit.Size = New System.Drawing.Size(85, 335)
        '
        'lblPercent
        '
        Me.lblPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPercent.ForeColor = System.Drawing.Color.Red
        Me.lblPercent.Location = New System.Drawing.Point(4, 0)
        Me.lblPercent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(241, 26)
        Me.lblPercent.TabIndex = 1
        Me.lblPercent.Text = "lblPercent"
        Me.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCapacity.ForeColor = System.Drawing.Color.White
        Me.lblCapacity.Location = New System.Drawing.Point(127, 36)
        Me.lblCapacity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(42, 15)
        Me.lblCapacity.TabIndex = 2
        Me.lblCapacity.Text = "99999"
        '
        'lblAdvice
        '
        Me.lblAdvice.AutoSize = True
        Me.lblAdvice.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblAdvice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblAdvice.ForeColor = System.Drawing.Color.White
        Me.lblAdvice.Location = New System.Drawing.Point(127, 138)
        Me.lblAdvice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdvice.Name = "lblAdvice"
        Me.lblAdvice.Size = New System.Drawing.Size(42, 15)
        Me.lblAdvice.TabIndex = 3
        Me.lblAdvice.Text = "99999"
        '
        'lblProgressBar
        '
        Me.lblProgressBar.AutoSize = True
        Me.lblProgressBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblProgressBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblProgressBar.ForeColor = System.Drawing.Color.White
        Me.lblProgressBar.Location = New System.Drawing.Point(127, 84)
        Me.lblProgressBar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProgressBar.Name = "lblProgressBar"
        Me.lblProgressBar.Size = New System.Drawing.Size(42, 15)
        Me.lblProgressBar.TabIndex = 4
        Me.lblProgressBar.Text = "99999"
        '
        'lblLSH
        '
        Me.lblLSH.AutoSize = True
        Me.lblLSH.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLSH.ForeColor = System.Drawing.Color.Red
        Me.lblLSH.Location = New System.Drawing.Point(247, 64)
        Me.lblLSH.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLSH.Name = "lblLSH"
        Me.lblLSH.Size = New System.Drawing.Size(43, 16)
        Me.lblLSH.TabIndex = 5
        Me.lblLSH.Text = "99999"
        Me.lblLSH.Visible = False
        '
        'lblLSHH
        '
        Me.lblLSHH.AutoSize = True
        Me.lblLSHH.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLSHH.ForeColor = System.Drawing.Color.Red
        Me.lblLSHH.Location = New System.Drawing.Point(261, 80)
        Me.lblLSHH.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLSHH.Name = "lblLSHH"
        Me.lblLSHH.Size = New System.Drawing.Size(43, 16)
        Me.lblLSHH.TabIndex = 6
        Me.lblLSHH.Text = "99999"
        Me.lblLSHH.Visible = False
        '
        'lblLSL
        '
        Me.lblLSL.AutoSize = True
        Me.lblLSL.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLSL.ForeColor = System.Drawing.Color.Red
        Me.lblLSL.Location = New System.Drawing.Point(272, 90)
        Me.lblLSL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLSL.Name = "lblLSL"
        Me.lblLSL.Size = New System.Drawing.Size(43, 16)
        Me.lblLSL.TabIndex = 7
        Me.lblLSL.Text = "99999"
        Me.lblLSL.Visible = False
        '
        'lblLSLL
        '
        Me.lblLSLL.AutoSize = True
        Me.lblLSLL.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLSLL.ForeColor = System.Drawing.Color.Red
        Me.lblLSLL.Location = New System.Drawing.Point(283, 100)
        Me.lblLSLL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLSLL.Name = "lblLSLL"
        Me.lblLSLL.Size = New System.Drawing.Size(43, 16)
        Me.lblLSLL.TabIndex = 8
        Me.lblLSLL.Text = "99999"
        Me.lblLSLL.Visible = False
        '
        'ucVProgressBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Controls.Add(Me.lblLSLL)
        Me.Controls.Add(Me.lblLSL)
        Me.Controls.Add(Me.lblLSHH)
        Me.Controls.Add(Me.lblLSH)
        Me.Controls.Add(Me.lblProgressBar)
        Me.Controls.Add(Me.lblAdvice)
        Me.Controls.Add(Me.lblCapacity)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucVProgressBar"
        Me.Size = New System.Drawing.Size(187, 441)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents shpCapacityLimit As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents shpAdviceLimit As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shpLSLL As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shpLSL As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shpLSH As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shpLSHH As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents shpProgressBar As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblCapacity As System.Windows.Forms.Label
    Friend WithEvents lblAdvice As System.Windows.Forms.Label
    Friend WithEvents lblProgressBar As System.Windows.Forms.Label
    Friend WithEvents lblLSH As System.Windows.Forms.Label
    Friend WithEvents lblLSHH As System.Windows.Forms.Label
    Friend WithEvents lblLSL As System.Windows.Forms.Label
    Friend WithEvents lblLSLL As System.Windows.Forms.Label

End Class
