<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtMtr = New System.Windows.Forms.TextBox()
        Me.lblMeter = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.RichTextBox()
        Me.DataGridBill = New System.Windows.Forms.DataGridView()
        Me.Database1DataSet = New _18_ELECTRICITY_BILL.Database1DataSet()
        Me.BILLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BILLTableAdapter = New _18_ELECTRICITY_BILL.Database1DataSetTableAdapters.BILLTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeterValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BILLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(421, 119)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(201, 34)
        Me.btnAdd.TabIndex = 33
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(467, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "EXPERIMENT 18 : ELECTRICITY BILL CALCULATION"
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(731, 119)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(203, 34)
        Me.btnView.TabIndex = 30
        Me.btnView.Text = "View Records"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(178, 361)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(126, 34)
        Me.btnCalc.TabIndex = 29
        Me.btnCalc.Text = "Calculate Rate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtMtr
        '
        Me.txtMtr.Location = New System.Drawing.Point(219, 314)
        Me.txtMtr.Name = "txtMtr"
        Me.txtMtr.Size = New System.Drawing.Size(134, 22)
        Me.txtMtr.TabIndex = 24
        '
        'lblMeter
        '
        Me.lblMeter.AutoSize = True
        Me.lblMeter.Location = New System.Drawing.Point(111, 314)
        Me.lblMeter.Name = "lblMeter"
        Me.lblMeter.Size = New System.Drawing.Size(79, 16)
        Me.lblMeter.TabIndex = 23
        Me.lblMeter.Text = "Meter Value"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(111, 205)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(58, 16)
        Me.lblAddress.TabIndex = 21
        Me.lblAddress.Text = "Address"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(219, 160)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(134, 22)
        Me.txtName.TabIndex = 20
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(111, 160)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 19
        Me.lblName.Text = "Name"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(219, 119)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(134, 22)
        Me.txtId.TabIndex = 18
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(111, 119)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(80, 16)
        Me.lblId.TabIndex = 17
        Me.lblId.Text = "Customer ID"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(219, 205)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(134, 96)
        Me.txtAddress.TabIndex = 34
        Me.txtAddress.Text = ""
        '
        'DataGridBill
        '
        Me.DataGridBill.AutoGenerateColumns = False
        Me.DataGridBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridBill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.MeterValueDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn})
        Me.DataGridBill.DataSource = Me.BILLBindingSource
        Me.DataGridBill.Location = New System.Drawing.Point(421, 183)
        Me.DataGridBill.Name = "DataGridBill"
        Me.DataGridBill.RowHeadersWidth = 51
        Me.DataGridBill.RowTemplate.Height = 24
        Me.DataGridBill.Size = New System.Drawing.Size(517, 212)
        Me.DataGridBill.TabIndex = 35
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BILLBindingSource
        '
        Me.BILLBindingSource.DataMember = "BILL"
        Me.BILLBindingSource.DataSource = Me.Database1DataSet
        '
        'BILLTableAdapter
        '
        Me.BILLTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 125
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'MeterValueDataGridViewTextBoxColumn
        '
        Me.MeterValueDataGridViewTextBoxColumn.DataPropertyName = "meterValue"
        Me.MeterValueDataGridViewTextBoxColumn.HeaderText = "meterValue"
        Me.MeterValueDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MeterValueDataGridViewTextBoxColumn.Name = "MeterValueDataGridViewTextBoxColumn"
        Me.MeterValueDataGridViewTextBoxColumn.Width = 125
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "amount"
        Me.AmountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 420)
        Me.Controls.Add(Me.DataGridBill)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtMtr)
        Me.Controls.Add(Me.lblMeter)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BILLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnView As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents txtMtr As TextBox
    Friend WithEvents lblMeter As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents txtAddress As RichTextBox
    Friend WithEvents DataGridBill As DataGridView
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents BILLBindingSource As BindingSource
    Friend WithEvents BILLTableAdapter As Database1DataSetTableAdapters.BILLTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MeterValueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
