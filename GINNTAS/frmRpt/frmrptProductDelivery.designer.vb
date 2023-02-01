<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmrptProductDelivery
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.CmdRefresh = New System.Windows.Forms.Button()
        Me.cmdPready = New System.Windows.Forms.Button()
        Me.dtpChoosDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpChoosDate = New System.Windows.Forms.DateTimePicker()
        Me.msGridLoad = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdPrintAttach = New System.Windows.Forms.Button()
        Me.cmdPreadyAttach = New System.Windows.Forms.Button()
        Me.DTPTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.DTPTimeStart = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.msGridLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCount
        '
        Me.txtCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCount.BackColor = System.Drawing.SystemColors.Control
        Me.txtCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Blue
        Me.txtCount.Location = New System.Drawing.Point(1339, 633)
        Me.txtCount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(73, 30)
        Me.txtCount.TabIndex = 25
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(1423, 639)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 25)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "คัน"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(1199, 636)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "จำนวน Load"
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(1291, 759)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(149, 43)
        Me.cmdClose.TabIndex = 22
        Me.cmdClose.Text = "ปิด"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'CmdRefresh
        '
        Me.CmdRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdRefresh.Location = New System.Drawing.Point(1291, 694)
        Me.CmdRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdRefresh.Name = "CmdRefresh"
        Me.CmdRefresh.Size = New System.Drawing.Size(149, 49)
        Me.CmdRefresh.TabIndex = 21
        Me.CmdRefresh.Text = "Refersh"
        Me.CmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdPready
        '
        Me.cmdPready.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPready.Location = New System.Drawing.Point(8, 21)
        Me.cmdPready.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPready.Name = "cmdPready"
        Me.cmdPready.Size = New System.Drawing.Size(149, 44)
        Me.cmdPready.TabIndex = 19
        Me.cmdPready.Text = "Print"
        Me.cmdPready.UseVisualStyleBackColor = True
        '
        'dtpChoosDateEnd
        '
        Me.dtpChoosDateEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpChoosDateEnd.Location = New System.Drawing.Point(467, 79)
        Me.dtpChoosDateEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpChoosDateEnd.Name = "dtpChoosDateEnd"
        Me.dtpChoosDateEnd.Size = New System.Drawing.Size(249, 30)
        Me.dtpChoosDateEnd.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(423, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ถึง"
        '
        'dtpChoosDate
        '
        Me.dtpChoosDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpChoosDate.Location = New System.Drawing.Point(20, 80)
        Me.dtpChoosDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpChoosDate.Name = "dtpChoosDate"
        Me.dtpChoosDate.Size = New System.Drawing.Size(248, 30)
        Me.dtpChoosDate.TabIndex = 14
        '
        'msGridLoad
        '
        Me.msGridLoad.AllowUserToAddRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.msGridLoad.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.msGridLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.msGridLoad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.msGridLoad.DefaultCellStyle = DataGridViewCellStyle6
        Me.msGridLoad.Location = New System.Drawing.Point(19, 116)
        Me.msGridLoad.Margin = New System.Windows.Forms.Padding(4)
        Me.msGridLoad.Name = "msGridLoad"
        Me.msGridLoad.RowHeadersVisible = False
        Me.msGridLoad.RowHeadersWidth = 51
        Me.msGridLoad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.msGridLoad.Size = New System.Drawing.Size(1455, 510)
        Me.msGridLoad.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "ลำดับ"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Load No."
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.HeaderText = "Shipment No."
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "ทะเบียนรถ."
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.HeaderText = "พนักงานขับรถ"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "status"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "กรมทางหลวง"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 150
        '
        'Column8
        '
        Me.Column8.HeaderText = "สำเนาที่"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdPrint)
        Me.GroupBox1.Controls.Add(Me.cmdPready)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 636)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(321, 79)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ใบกำกับสินค้า"
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(164, 21)
        Me.cmdPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(149, 44)
        Me.cmdPrint.TabIndex = 20
        Me.cmdPrint.Text = "ดูก่อนพิมพ์"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdPrintAttach)
        Me.GroupBox2.Controls.Add(Me.cmdPreadyAttach)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(20, 722)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(321, 75)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "เอกสารแนบ"
        '
        'cmdPrintAttach
        '
        Me.cmdPrintAttach.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPrintAttach.Location = New System.Drawing.Point(164, 23)
        Me.cmdPrintAttach.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPrintAttach.Name = "cmdPrintAttach"
        Me.cmdPrintAttach.Size = New System.Drawing.Size(149, 44)
        Me.cmdPrintAttach.TabIndex = 21
        Me.cmdPrintAttach.Text = "ดูก่อนพิมพ์"
        Me.cmdPrintAttach.UseVisualStyleBackColor = True
        '
        'cmdPreadyAttach
        '
        Me.cmdPreadyAttach.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPreadyAttach.Location = New System.Drawing.Point(8, 23)
        Me.cmdPreadyAttach.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPreadyAttach.Name = "cmdPreadyAttach"
        Me.cmdPreadyAttach.Size = New System.Drawing.Size(149, 44)
        Me.cmdPreadyAttach.TabIndex = 20
        Me.cmdPreadyAttach.Text = "Print"
        Me.cmdPreadyAttach.UseVisualStyleBackColor = True
        '
        'DTPTimeEnd
        '
        Me.DTPTimeEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPTimeEnd.Location = New System.Drawing.Point(725, 80)
        Me.DTPTimeEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPTimeEnd.Name = "DTPTimeEnd"
        Me.DTPTimeEnd.ShowUpDown = True
        Me.DTPTimeEnd.Size = New System.Drawing.Size(127, 30)
        Me.DTPTimeEnd.TabIndex = 22
        Me.DTPTimeEnd.Value = New Date(2015, 4, 9, 0, 0, 0, 0)
        '
        'DTPTimeStart
        '
        Me.DTPTimeStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPTimeStart.Location = New System.Drawing.Point(277, 80)
        Me.DTPTimeStart.Margin = New System.Windows.Forms.Padding(4)
        Me.DTPTimeStart.Name = "DTPTimeStart"
        Me.DTPTimeStart.ShowUpDown = True
        Me.DTPTimeStart.Size = New System.Drawing.Size(124, 30)
        Me.DTPTimeStart.TabIndex = 28
        Me.DTPTimeStart.Value = New Date(2015, 4, 9, 0, 0, 0, 0)
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Blue
        Me.TextBox1.Location = New System.Drawing.Point(631, 355)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(39, 23)
        Me.TextBox1.TabIndex = 25
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmrptProductDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1488, 833)
        Me.Controls.Add(Me.DTPTimeStart)
        Me.Controls.Add(Me.DTPTimeEnd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.CmdRefresh)
        Me.Controls.Add(Me.dtpChoosDateEnd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpChoosDate)
        Me.Controls.Add(Me.msGridLoad)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmrptProductDelivery"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "รายงานใบกำกับสินค้า-Delivery Receive"
        CType(Me.msGridLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents CmdRefresh As System.Windows.Forms.Button
    Friend WithEvents cmdPready As System.Windows.Forms.Button
    Friend WithEvents dtpChoosDateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpChoosDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents msGridLoad As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPrintAttach As System.Windows.Forms.Button
    Friend WithEvents cmdPreadyAttach As System.Windows.Forms.Button
    Friend WithEvents DTPTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPTimeStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
