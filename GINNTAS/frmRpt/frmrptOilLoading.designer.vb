<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptOilLoading
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbProduct = New System.Windows.Forms.ComboBox()
        Me.dtpChoosDate = New System.Windows.Forms.DateTimePicker()
        Me.DTPTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.DTPTimeStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpChoosDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.msGridLoad = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmdRefresh = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdPready = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.cmdPrintAll = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.msGridLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbProduct)
        Me.Panel2.Controls.Add(Me.dtpChoosDate)
        Me.Panel2.Controls.Add(Me.DTPTimeEnd)
        Me.Panel2.Controls.Add(Me.DTPTimeStart)
        Me.Panel2.Controls.Add(Me.dtpChoosDateEnd)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(20, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(937, 45)
        Me.Panel2.TabIndex = 17
        '
        'cbProduct
        '
        Me.cbProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbProduct.FormattingEnabled = True
        Me.cbProduct.Items.AddRange(New Object() {"ALL", "Base Oil", "Bitument"})
        Me.cbProduct.Location = New System.Drawing.Point(711, 9)
        Me.cbProduct.Name = "cbProduct"
        Me.cbProduct.Size = New System.Drawing.Size(152, 28)
        Me.cbProduct.TabIndex = 41
        '
        'dtpChoosDate
        '
        Me.dtpChoosDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpChoosDate.Location = New System.Drawing.Point(12, 12)
        Me.dtpChoosDate.Name = "dtpChoosDate"
        Me.dtpChoosDate.Size = New System.Drawing.Size(206, 26)
        Me.dtpChoosDate.TabIndex = 40
        '
        'DTPTimeEnd
        '
        Me.DTPTimeEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPTimeEnd.Location = New System.Drawing.Point(583, 12)
        Me.DTPTimeEnd.Name = "DTPTimeEnd"
        Me.DTPTimeEnd.ShowUpDown = True
        Me.DTPTimeEnd.Size = New System.Drawing.Size(107, 26)
        Me.DTPTimeEnd.TabIndex = 39
        Me.DTPTimeEnd.Value = New Date(2015, 4, 10, 22, 0, 0, 0)
        '
        'DTPTimeStart
        '
        Me.DTPTimeStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DTPTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DTPTimeStart.Location = New System.Drawing.Point(224, 12)
        Me.DTPTimeStart.Name = "DTPTimeStart"
        Me.DTPTimeStart.ShowUpDown = True
        Me.DTPTimeStart.Size = New System.Drawing.Size(97, 26)
        Me.DTPTimeStart.TabIndex = 38
        Me.DTPTimeStart.Value = New Date(2014, 11, 16, 1, 0, 0, 0)
        '
        'dtpChoosDateEnd
        '
        Me.dtpChoosDateEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpChoosDateEnd.Location = New System.Drawing.Point(355, 12)
        Me.dtpChoosDateEnd.Name = "dtpChoosDateEnd"
        Me.dtpChoosDateEnd.Size = New System.Drawing.Size(212, 26)
        Me.dtpChoosDateEnd.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(327, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 20)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "ถึง"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.msGridLoad)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(20, 105)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(937, 528)
        Me.Panel3.TabIndex = 18
        '
        'msGridLoad
        '
        Me.msGridLoad.AllowUserToAddRows = False
        Me.msGridLoad.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.msGridLoad.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.msGridLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.msGridLoad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column12, Me.Column9, Me.Column10, Me.Column11})
        Me.msGridLoad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.msGridLoad.Location = New System.Drawing.Point(0, 0)
        Me.msGridLoad.Name = "msGridLoad"
        Me.msGridLoad.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.msGridLoad.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.msGridLoad.RowHeadersVisible = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.msGridLoad.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.msGridLoad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.msGridLoad.Size = New System.Drawing.Size(937, 528)
        Me.msGridLoad.TabIndex = 0
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "ลำดับ"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "Load No."
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column12.HeaderText = "Shipment No."
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "ทะเบียนรถ"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column10.HeaderText = "พนักงานขับรถ"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column11.HeaderText = "Status"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'CmdRefresh
        '
        Me.CmdRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CmdRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdRefresh.Location = New System.Drawing.Point(18, 5)
        Me.CmdRefresh.Name = "CmdRefresh"
        Me.CmdRefresh.Size = New System.Drawing.Size(122, 45)
        Me.CmdRefresh.TabIndex = 10
        Me.CmdRefresh.Text = "Refresh"
        Me.CmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(18, 459)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(122, 45)
        Me.cmdPrint.TabIndex = 11
        Me.cmdPrint.Text = "Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdPready
        '
        Me.cmdPready.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPready.Location = New System.Drawing.Point(18, 510)
        Me.cmdPready.Name = "cmdPready"
        Me.cmdPready.Size = New System.Drawing.Size(122, 45)
        Me.cmdPready.TabIndex = 12
        Me.cmdPready.Text = "พิมพ์รายงาน"
        Me.cmdPready.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(18, 561)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(122, 45)
        Me.cmdClose.TabIndex = 13
        Me.cmdClose.Text = "ปิด"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdPrintAll)
        Me.Panel1.Controls.Add(Me.cmdClose)
        Me.Panel1.Controls.Add(Me.cmdPready)
        Me.Panel1.Controls.Add(Me.cmdPrint)
        Me.Panel1.Controls.Add(Me.CmdRefresh)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(957, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(152, 625)
        Me.Panel1.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.HeaderText = "ลำดับ"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Load No."
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Shipment No."
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "ทะเบียนรถ."
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "พนักงานขับรถ"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "status"
        Me.Column6.Name = "Column6"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtCount)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(342, 633)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(615, 52)
        Me.Panel4.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(396, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "จำนวน Load"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(569, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "คัน"
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.SystemColors.Control
        Me.txtCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCount.ForeColor = System.Drawing.Color.Blue
        Me.txtCount.Location = New System.Drawing.Point(500, 14)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(62, 24)
        Me.txtCount.TabIndex = 25
        Me.txtCount.Text = "0"
        Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdPrintAll
        '
        Me.cmdPrintAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmdPrintAll.Location = New System.Drawing.Point(18, 58)
        Me.cmdPrintAll.Name = "cmdPrintAll"
        Me.cmdPrintAll.Size = New System.Drawing.Size(122, 45)
        Me.cmdPrintAll.TabIndex = 14
        Me.cmdPrintAll.Text = "PrintAll"
        Me.cmdPrintAll.UseVisualStyleBackColor = True
        '
        'frmrptOilLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 705)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmrptOilLoading"
        Me.Text = "รายงานการจ่ายทางรถบรรทุก"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.msGridLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DTPTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPTimeStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpChoosDateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CmdRefresh As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdPready As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents msGridLoad As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents dtpChoosDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdPrintAll As System.Windows.Forms.Button
End Class
