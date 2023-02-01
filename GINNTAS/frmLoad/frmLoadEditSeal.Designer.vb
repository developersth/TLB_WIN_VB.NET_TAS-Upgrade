<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadEditSeal
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
        Me.CmdOk = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtloadNo = New System.Windows.Forms.TextBox()
        Me.txtShipmentNo = New System.Windows.Forms.TextBox()
        Me.txtTruckNo = New System.Windows.Forms.TextBox()
        Me.txtTuNo = New System.Windows.Forms.TextBox()
        Me.txtSealNumber = New System.Windows.Forms.TextBox()
        Me.txtTotSeal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CmdOk
        '
        Me.CmdOk.BackColor = System.Drawing.Color.Yellow
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdOk.Location = New System.Drawing.Point(193, 283)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(89, 36)
        Me.CmdOk.TabIndex = 1
        Me.CmdOk.Text = "ตกลง"
        Me.CmdOk.UseVisualStyleBackColor = False
        '
        'CmdCancel
        '
        Me.CmdCancel.BackColor = System.Drawing.Color.Pink
        Me.CmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdCancel.Location = New System.Drawing.Point(299, 283)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(89, 36)
        Me.CmdCancel.TabIndex = 2
        Me.CmdCancel.Text = "ยกเลิก"
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Load No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Shipment No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ทะเบียนรถ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ทะเบียนรถตัวพ่วง"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "จำนวนซีล"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(48, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 24)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "หมายเลขซีล"
        '
        'txtloadNo
        '
        Me.txtloadNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtloadNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtloadNo.Location = New System.Drawing.Point(174, 55)
        Me.txtloadNo.Name = "txtloadNo"
        Me.txtloadNo.Size = New System.Drawing.Size(214, 26)
        Me.txtloadNo.TabIndex = 10
        '
        'txtShipmentNo
        '
        Me.txtShipmentNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtShipmentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtShipmentNo.Location = New System.Drawing.Point(174, 91)
        Me.txtShipmentNo.Name = "txtShipmentNo"
        Me.txtShipmentNo.Size = New System.Drawing.Size(214, 26)
        Me.txtShipmentNo.TabIndex = 11
        '
        'txtTruckNo
        '
        Me.txtTruckNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTruckNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTruckNo.Location = New System.Drawing.Point(174, 127)
        Me.txtTruckNo.Name = "txtTruckNo"
        Me.txtTruckNo.Size = New System.Drawing.Size(214, 26)
        Me.txtTruckNo.TabIndex = 12
        '
        'txtTuNo
        '
        Me.txtTuNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTuNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTuNo.Location = New System.Drawing.Point(174, 163)
        Me.txtTuNo.Name = "txtTuNo"
        Me.txtTuNo.Size = New System.Drawing.Size(214, 26)
        Me.txtTuNo.TabIndex = 13
        '
        'txtSealNumber
        '
        Me.txtSealNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSealNumber.Location = New System.Drawing.Point(175, 240)
        Me.txtSealNumber.Name = "txtSealNumber"
        Me.txtSealNumber.Size = New System.Drawing.Size(214, 26)
        Me.txtSealNumber.TabIndex = 14
        '
        'txtTotSeal
        '
        Me.txtTotSeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotSeal.Location = New System.Drawing.Point(175, 206)
        Me.txtTotSeal.Name = "txtTotSeal"
        Me.txtTotSeal.Size = New System.Drawing.Size(68, 26)
        Me.txtTotSeal.TabIndex = 15
        '
        'frmLoadEditSeal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 347)
        Me.Controls.Add(Me.txtTotSeal)
        Me.Controls.Add(Me.txtSealNumber)
        Me.Controls.Add(Me.txtTuNo)
        Me.Controls.Add(Me.txtTruckNo)
        Me.Controls.Add(Me.txtShipmentNo)
        Me.Controls.Add(Me.txtloadNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdOk)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoadEditSeal"
        Me.Text = "# แก้ไข ซีล #"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdOk As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtloadNo As System.Windows.Forms.TextBox
    Friend WithEvents txtShipmentNo As System.Windows.Forms.TextBox
    Friend WithEvents txtTruckNo As System.Windows.Forms.TextBox
    Friend WithEvents txtTuNo As System.Windows.Forms.TextBox
    Friend WithEvents txtSealNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtTotSeal As System.Windows.Forms.TextBox
End Class
