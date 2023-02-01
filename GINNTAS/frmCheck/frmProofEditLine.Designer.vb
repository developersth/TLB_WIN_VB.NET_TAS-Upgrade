<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProofEditLine
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtLoadNo = New System.Windows.Forms.TextBox()
        Me.txtComp = New System.Windows.Forms.TextBox()
        Me.txtBatchNo = New System.Windows.Forms.TextBox()
        Me.txtDriver = New System.Windows.Forms.TextBox()
        Me.txtTailerName = New System.Windows.Forms.TextBox()
        Me.txtTruckName = New System.Windows.Forms.TextBox()
        Me.cbBay = New System.Windows.Forms.ComboBox()
        Me.cbMeterNo = New System.Windows.Forms.ComboBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView_LineBatch = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView_SumBatch = New System.Windows.Forms.DataGridView()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_AddLMeter = New System.Windows.Forms.Button()
        Me.b_RefreshGrid = New System.Windows.Forms.Button()
        Me.b_Sum = New System.Windows.Forms.Button()
        Me.b_DeleteLoadMeter = New System.Windows.Forms.Button()
        Me.b_Close = New System.Windows.Forms.Button()
        Me.b_Save = New System.Windows.Forms.Button()
        Me.lbl_rec = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView_LineBatch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView_SumBatch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(141, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Load No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(133, 151)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Batch No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(97, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Compartment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(153, 188)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bay No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(133, 228)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Meter No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(663, 78)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ทะเบียนรถหัวลาก"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(661, 114)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ทะเบียนรถตัวพ่วง"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Location = New System.Drawing.Point(691, 156)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "พนักงานขับรถ"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Location = New System.Drawing.Point(112, 267)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 25)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "สถานะการจ่าย"
        '
        'txtLoadNo
        '
        Me.txtLoadNo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLoadNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLoadNo.Location = New System.Drawing.Point(252, 73)
        Me.txtLoadNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLoadNo.Name = "txtLoadNo"
        Me.txtLoadNo.ReadOnly = True
        Me.txtLoadNo.Size = New System.Drawing.Size(281, 30)
        Me.txtLoadNo.TabIndex = 10
        '
        'txtComp
        '
        Me.txtComp.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtComp.Location = New System.Drawing.Point(252, 110)
        Me.txtComp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtComp.Name = "txtComp"
        Me.txtComp.ReadOnly = True
        Me.txtComp.Size = New System.Drawing.Size(132, 30)
        Me.txtComp.TabIndex = 11
        '
        'txtBatchNo
        '
        Me.txtBatchNo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtBatchNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBatchNo.Location = New System.Drawing.Point(252, 146)
        Me.txtBatchNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBatchNo.Name = "txtBatchNo"
        Me.txtBatchNo.ReadOnly = True
        Me.txtBatchNo.Size = New System.Drawing.Size(281, 30)
        Me.txtBatchNo.TabIndex = 12
        '
        'txtDriver
        '
        Me.txtDriver.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDriver.Location = New System.Drawing.Point(829, 146)
        Me.txtDriver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDriver.Name = "txtDriver"
        Me.txtDriver.ReadOnly = True
        Me.txtDriver.Size = New System.Drawing.Size(281, 30)
        Me.txtDriver.TabIndex = 15
        '
        'txtTailerName
        '
        Me.txtTailerName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTailerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTailerName.Location = New System.Drawing.Point(829, 110)
        Me.txtTailerName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTailerName.Name = "txtTailerName"
        Me.txtTailerName.ReadOnly = True
        Me.txtTailerName.Size = New System.Drawing.Size(281, 30)
        Me.txtTailerName.TabIndex = 14
        '
        'txtTruckName
        '
        Me.txtTruckName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTruckName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTruckName.Location = New System.Drawing.Point(829, 73)
        Me.txtTruckName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTruckName.Name = "txtTruckName"
        Me.txtTruckName.ReadOnly = True
        Me.txtTruckName.Size = New System.Drawing.Size(281, 30)
        Me.txtTruckName.TabIndex = 13
        '
        'cbBay
        '
        Me.cbBay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbBay.FormattingEnabled = True
        Me.cbBay.Location = New System.Drawing.Point(252, 183)
        Me.cbBay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbBay.Name = "cbBay"
        Me.cbBay.Size = New System.Drawing.Size(160, 33)
        Me.cbBay.TabIndex = 16
        '
        'cbMeterNo
        '
        Me.cbMeterNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbMeterNo.FormattingEnabled = True
        Me.cbMeterNo.Location = New System.Drawing.Point(252, 223)
        Me.cbMeterNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbMeterNo.Name = "cbMeterNo"
        Me.cbMeterNo.Size = New System.Drawing.Size(281, 33)
        Me.cbMeterNo.TabIndex = 17
        '
        'cbStatus
        '
        Me.cbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(252, 262)
        Me.cbStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(439, 33)
        Me.cbStatus.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView_LineBatch)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 334)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1420, 223)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Line Batch"
        '
        'DataGridView_LineBatch
        '
        Me.DataGridView_LineBatch.AllowUserToAddRows = False
        Me.DataGridView_LineBatch.AllowUserToDeleteRows = False
        Me.DataGridView_LineBatch.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView_LineBatch.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_LineBatch.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_LineBatch.ColumnHeadersHeight = 35
        Me.DataGridView_LineBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView_LineBatch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.Column32, Me.Column33, Me.Column34, Me.Column35, Me.Column36, Me.Column37, Me.Column38, Me.Column39, Me.Column40, Me.DataGridViewTextBoxColumn12, Me.Column6, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView_LineBatch.Location = New System.Drawing.Point(0, 26)
        Me.DataGridView_LineBatch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView_LineBatch.Name = "DataGridView_LineBatch"
        Me.DataGridView_LineBatch.RowHeadersVisible = False
        Me.DataGridView_LineBatch.RowHeadersWidth = 51
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.DataGridView_LineBatch.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView_LineBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView_LineBatch.Size = New System.Drawing.Size(1420, 197)
        Me.DataGridView_LineBatch.TabIndex = 35
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView_SumBatch)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(20, 620)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1420, 183)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sum Batch"
        '
        'DataGridView_SumBatch
        '
        Me.DataGridView_SumBatch.AllowUserToAddRows = False
        Me.DataGridView_SumBatch.AllowUserToDeleteRows = False
        Me.DataGridView_SumBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_SumBatch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column18, Me.Column19, Me.Column20, Me.Column21, Me.Column22, Me.Column23, Me.Column24, Me.Column25, Me.Column26, Me.Column27, Me.Column28, Me.Column29, Me.Column30, Me.Column31})
        Me.DataGridView_SumBatch.Location = New System.Drawing.Point(8, 26)
        Me.DataGridView_SumBatch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView_SumBatch.Name = "DataGridView_SumBatch"
        Me.DataGridView_SumBatch.ReadOnly = True
        Me.DataGridView_SumBatch.RowHeadersVisible = False
        Me.DataGridView_SumBatch.RowHeadersWidth = 51
        Me.DataGridView_SumBatch.Size = New System.Drawing.Size(1420, 150)
        Me.DataGridView_SumBatch.TabIndex = 0
        '
        'Column18
        '
        Me.Column18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column18.HeaderText = "Base Product"
        Me.Column18.MinimumWidth = 6
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.Width = 158
        '
        'Column19
        '
        Me.Column19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column19.HeaderText = "Present"
        Me.Column19.MinimumWidth = 6
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.Width = 108
        '
        'Column20
        '
        Me.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column20.HeaderText = "Load Gross"
        Me.Column20.MinimumWidth = 6
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        Me.Column20.Width = 142
        '
        'Column21
        '
        Me.Column21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column21.HeaderText = "Load Net"
        Me.Column21.MinimumWidth = 6
        Me.Column21.Name = "Column21"
        Me.Column21.ReadOnly = True
        Me.Column21.Width = 120
        '
        'Column22
        '
        Me.Column22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column22.HeaderText = "Bay No"
        Me.Column22.MinimumWidth = 6
        Me.Column22.Name = "Column22"
        Me.Column22.ReadOnly = True
        Me.Column22.Width = 105
        '
        'Column23
        '
        Me.Column23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column23.HeaderText = "Meter"
        Me.Column23.MinimumWidth = 6
        Me.Column23.Name = "Column23"
        Me.Column23.ReadOnly = True
        Me.Column23.Width = 91
        '
        'Column24
        '
        Me.Column24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column24.HeaderText = "Temp"
        Me.Column24.MinimumWidth = 6
        Me.Column24.Name = "Column24"
        Me.Column24.ReadOnly = True
        Me.Column24.Width = 92
        '
        'Column25
        '
        Me.Column25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column25.HeaderText = "Den 15ํC"
        Me.Column25.MinimumWidth = 6
        Me.Column25.Name = "Column25"
        Me.Column25.ReadOnly = True
        Me.Column25.Width = 131
        '
        'Column26
        '
        Me.Column26.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column26.HeaderText = "Tank Name"
        Me.Column26.MinimumWidth = 6
        Me.Column26.Name = "Column26"
        Me.Column26.ReadOnly = True
        Me.Column26.Width = 143
        '
        'Column27
        '
        Me.Column27.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column27.HeaderText = "BatchStatus"
        Me.Column27.MinimumWidth = 6
        Me.Column27.Name = "Column27"
        Me.Column27.ReadOnly = True
        Me.Column27.Width = 147
        '
        'Column28
        '
        Me.Column28.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column28.HeaderText = "Tot Gross Start"
        Me.Column28.MinimumWidth = 6
        Me.Column28.Name = "Column28"
        Me.Column28.ReadOnly = True
        Me.Column28.Width = 173
        '
        'Column29
        '
        Me.Column29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column29.HeaderText = "Tot Gross Stop"
        Me.Column29.MinimumWidth = 6
        Me.Column29.Name = "Column29"
        Me.Column29.ReadOnly = True
        Me.Column29.Width = 173
        '
        'Column30
        '
        Me.Column30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column30.HeaderText = "Override Status"
        Me.Column30.MinimumWidth = 6
        Me.Column30.Name = "Column30"
        Me.Column30.ReadOnly = True
        Me.Column30.Width = 177
        '
        'Column31
        '
        Me.Column31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column31.HeaderText = "Description"
        Me.Column31.MinimumWidth = 6
        Me.Column31.Name = "Column31"
        Me.Column31.ReadOnly = True
        Me.Column31.Width = 138
        '
        'b_AddLMeter
        '
        Me.b_AddLMeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.b_AddLMeter.Location = New System.Drawing.Point(1049, 287)
        Me.b_AddLMeter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.b_AddLMeter.Name = "b_AddLMeter"
        Me.b_AddLMeter.Size = New System.Drawing.Size(183, 39)
        Me.b_AddLMeter.TabIndex = 21
        Me.b_AddLMeter.Text = "Add Load Meter"
        Me.b_AddLMeter.UseVisualStyleBackColor = True
        '
        'b_RefreshGrid
        '
        Me.b_RefreshGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.b_RefreshGrid.Location = New System.Drawing.Point(1257, 287)
        Me.b_RefreshGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.b_RefreshGrid.Name = "b_RefreshGrid"
        Me.b_RefreshGrid.Size = New System.Drawing.Size(183, 39)
        Me.b_RefreshGrid.TabIndex = 22
        Me.b_RefreshGrid.Text = "Refresh"
        Me.b_RefreshGrid.UseVisualStyleBackColor = True
        '
        'b_Sum
        '
        Me.b_Sum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.b_Sum.Location = New System.Drawing.Point(1256, 574)
        Me.b_Sum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.b_Sum.Name = "b_Sum"
        Me.b_Sum.Size = New System.Drawing.Size(183, 39)
        Me.b_Sum.TabIndex = 23
        Me.b_Sum.Text = "Sum Batch"
        Me.b_Sum.UseVisualStyleBackColor = True
        '
        'b_DeleteLoadMeter
        '
        Me.b_DeleteLoadMeter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.b_DeleteLoadMeter.Location = New System.Drawing.Point(1049, 574)
        Me.b_DeleteLoadMeter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.b_DeleteLoadMeter.Name = "b_DeleteLoadMeter"
        Me.b_DeleteLoadMeter.Size = New System.Drawing.Size(183, 39)
        Me.b_DeleteLoadMeter.TabIndex = 24
        Me.b_DeleteLoadMeter.Text = "Delete Load Meter"
        Me.b_DeleteLoadMeter.UseVisualStyleBackColor = True
        '
        'b_Close
        '
        Me.b_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.b_Close.Location = New System.Drawing.Point(1256, 811)
        Me.b_Close.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.b_Close.Name = "b_Close"
        Me.b_Close.Size = New System.Drawing.Size(183, 39)
        Me.b_Close.TabIndex = 25
        Me.b_Close.Text = "Close"
        Me.b_Close.UseVisualStyleBackColor = True
        '
        'b_Save
        '
        Me.b_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.b_Save.Location = New System.Drawing.Point(1049, 811)
        Me.b_Save.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.b_Save.Name = "b_Save"
        Me.b_Save.Size = New System.Drawing.Size(183, 39)
        Me.b_Save.TabIndex = 26
        Me.b_Save.Text = "Save"
        Me.b_Save.UseVisualStyleBackColor = True
        '
        'lbl_rec
        '
        Me.lbl_rec.BackColor = System.Drawing.Color.White
        Me.lbl_rec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_rec.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lbl_rec.Location = New System.Drawing.Point(20, 560)
        Me.lbl_rec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_rec.Name = "lbl_rec"
        Me.lbl_rec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_rec.Size = New System.Drawing.Size(58, 24)
        Me.lbl_rec.TabIndex = 58
        Me.lbl_rec.Text = "0"
        Me.lbl_rec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "LineCount"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'Column32
        '
        Me.Column32.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column32.HeaderText = "Meter Count"
        Me.Column32.MinimumWidth = 6
        Me.Column32.Name = "Column32"
        Me.Column32.ReadOnly = True
        Me.Column32.Width = 149
        '
        'Column33
        '
        Me.Column33.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column33.HeaderText = "Base Product"
        Me.Column33.MinimumWidth = 6
        Me.Column33.Name = "Column33"
        Me.Column33.ReadOnly = True
        Me.Column33.Width = 158
        '
        'Column34
        '
        Me.Column34.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column34.HeaderText = "Present"
        Me.Column34.MinimumWidth = 6
        Me.Column34.Name = "Column34"
        Me.Column34.Width = 108
        '
        'Column35
        '
        Me.Column35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column35.HeaderText = "Load Gross"
        Me.Column35.MinimumWidth = 6
        Me.Column35.Name = "Column35"
        Me.Column35.Width = 142
        '
        'Column36
        '
        Me.Column36.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column36.HeaderText = "Load Net"
        Me.Column36.MinimumWidth = 6
        Me.Column36.Name = "Column36"
        Me.Column36.Width = 120
        '
        'Column37
        '
        Me.Column37.HeaderText = "Bay No"
        Me.Column37.MinimumWidth = 6
        Me.Column37.Name = "Column37"
        Me.Column37.Width = 125
        '
        'Column38
        '
        Me.Column38.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column38.HeaderText = "Meter"
        Me.Column38.MinimumWidth = 6
        Me.Column38.Name = "Column38"
        Me.Column38.Width = 91
        '
        'Column39
        '
        Me.Column39.HeaderText = "Temp"
        Me.Column39.MinimumWidth = 6
        Me.Column39.Name = "Column39"
        Me.Column39.Width = 125
        '
        'Column40
        '
        Me.Column40.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column40.HeaderText = "Den 15°C"
        Me.Column40.MinimumWidth = 6
        Me.Column40.Name = "Column40"
        Me.Column40.Width = 127
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.HeaderText = "Tank Name"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn12.Width = 143
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Batch Status"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 129
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.FillWeight = 170.0!
        Me.Column1.HeaderText = "TOt Gross Start"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 178
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.FillWeight = 170.0!
        Me.Column2.HeaderText = "Tot Gross Stop"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 173
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.FillWeight = 170.0!
        Me.Column3.HeaderText = "Override Status"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column3.Width = 177
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.FillWeight = 150.0!
        Me.Column4.HeaderText = "Description"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 138
        '
        'Column5
        '
        Me.Column5.FillWeight = 120.0!
        Me.Column5.HeaderText = "การแก้ไข"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column5.Width = 120
        '
        'frmProofEditLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1456, 858)
        Me.Controls.Add(Me.lbl_rec)
        Me.Controls.Add(Me.b_Save)
        Me.Controls.Add(Me.b_Close)
        Me.Controls.Add(Me.b_DeleteLoadMeter)
        Me.Controls.Add(Me.b_Sum)
        Me.Controls.Add(Me.b_RefreshGrid)
        Me.Controls.Add(Me.b_AddLMeter)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.cbMeterNo)
        Me.Controls.Add(Me.cbBay)
        Me.Controls.Add(Me.txtDriver)
        Me.Controls.Add(Me.txtTailerName)
        Me.Controls.Add(Me.txtTruckName)
        Me.Controls.Add(Me.txtBatchNo)
        Me.Controls.Add(Me.txtComp)
        Me.Controls.Add(Me.txtLoadNo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProofEditLine"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "frmProofEditLine"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView_LineBatch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView_SumBatch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtLoadNo As System.Windows.Forms.TextBox
    Friend WithEvents txtComp As System.Windows.Forms.TextBox
    Friend WithEvents txtBatchNo As System.Windows.Forms.TextBox
    Friend WithEvents txtDriver As System.Windows.Forms.TextBox
    Friend WithEvents txtTailerName As System.Windows.Forms.TextBox
    Friend WithEvents txtTruckName As System.Windows.Forms.TextBox
    Friend WithEvents cbBay As System.Windows.Forms.ComboBox
    Friend WithEvents cbMeterNo As System.Windows.Forms.ComboBox
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView_SumBatch As System.Windows.Forms.DataGridView
    Friend WithEvents b_AddLMeter As System.Windows.Forms.Button
    Friend WithEvents b_RefreshGrid As System.Windows.Forms.Button
    Friend WithEvents b_Sum As System.Windows.Forms.Button
    Friend WithEvents b_DeleteLoadMeter As System.Windows.Forms.Button
    Friend WithEvents b_Close As System.Windows.Forms.Button
    Friend WithEvents b_Save As System.Windows.Forms.Button
    Friend WithEvents DataGridView_LineBatch As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_rec As System.Windows.Forms.Label
    Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents Column32 As DataGridViewTextBoxColumn
    Friend WithEvents Column33 As DataGridViewTextBoxColumn
    Friend WithEvents Column34 As DataGridViewTextBoxColumn
    Friend WithEvents Column35 As DataGridViewTextBoxColumn
    Friend WithEvents Column36 As DataGridViewTextBoxColumn
    Friend WithEvents Column37 As DataGridViewTextBoxColumn
    Friend WithEvents Column38 As DataGridViewTextBoxColumn
    Friend WithEvents Column39 As DataGridViewTextBoxColumn
    Friend WithEvents Column40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewComboBoxColumn
    Friend WithEvents Column6 As DataGridViewComboBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewComboBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewComboBoxColumn
End Class
