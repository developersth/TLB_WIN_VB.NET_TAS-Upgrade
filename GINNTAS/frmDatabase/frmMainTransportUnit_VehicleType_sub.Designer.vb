<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainTransportUnit_VehicleType_sub
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
        Me.txtID = New MetroFramework.Controls.MetroTextBox()
        Me.txtDescription = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.BtSave = New MetroFramework.Controls.MetroButton()
        Me.btCancel = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtID.Lines = New String(-1) {}
        Me.txtID.Location = New System.Drawing.Point(147, 80)
        Me.txtID.MaxLength = 32767
        Me.txtID.Name = "txtID"
        Me.txtID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtID.SelectedText = ""
        Me.txtID.Size = New System.Drawing.Size(189, 30)
        Me.txtID.TabIndex = 0
        Me.txtID.UseSelectable = True
        '
        'txtDescription
        '
        Me.txtDescription.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtDescription.Lines = New String(-1) {}
        Me.txtDescription.Location = New System.Drawing.Point(146, 123)
        Me.txtDescription.MaxLength = 32767
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.Size = New System.Drawing.Size(189, 30)
        Me.txtDescription.TabIndex = 1
        Me.txtDescription.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 80)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(118, 25)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "รหัสประเถทรถ :"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(29, 123)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(111, 25)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "ชื่อประเภทรถ :"
        '
        'BtSave
        '
        Me.BtSave.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.BtSave.Location = New System.Drawing.Point(97, 177)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(121, 37)
        Me.BtSave.TabIndex = 4
        Me.BtSave.Text = "ตกลง"
        Me.BtSave.UseSelectable = True
        '
        'btCancel
        '
        Me.btCancel.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btCancel.Location = New System.Drawing.Point(224, 178)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(121, 37)
        Me.btCancel.TabIndex = 5
        Me.btCancel.Text = "ยกเลิก"
        Me.btCancel.UseSelectable = True
        '
        'frmMainTransportUnit_VehicleType_sub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 226)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.BtSave)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtID)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMainTransportUnit_VehicleType_sub"
        Me.Text = "ประเภทรถ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDescription As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents BtSave As MetroFramework.Controls.MetroButton
    Friend WithEvents btCancel As MetroFramework.Controls.MetroButton
End Class
