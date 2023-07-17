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
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtDept = New System.Windows.Forms.TextBox()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.txtBP = New System.Windows.Forms.TextBox()
        Me.lblBP = New System.Windows.Forms.Label()
        Me.txtHRA = New System.Windows.Forms.TextBox()
        Me.lblHRA = New System.Windows.Forms.Label()
        Me.txtDA = New System.Windows.Forms.TextBox()
        Me.lblDA = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridPayroll = New System.Windows.Forms.DataGridView()
        Me.TeacherIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BasicPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HRADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetPayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAYROLLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New _21_PAYROLL.Database1DataSet()
        Me.PAYROLLTableAdapter = New _21_PAYROLL.Database1DataSetTableAdapters.PAYROLLTableAdapter()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.DataGridPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PAYROLLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(108, 96)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(74, 16)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Teacher ID"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(216, 96)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(134, 22)
        Me.txtId.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(216, 137)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(134, 22)
        Me.txtName.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(108, 137)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'txtDept
        '
        Me.txtDept.Location = New System.Drawing.Point(216, 182)
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Size = New System.Drawing.Size(134, 22)
        Me.txtDept.TabIndex = 5
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.Location = New System.Drawing.Point(108, 182)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(77, 16)
        Me.lblDept.TabIndex = 4
        Me.lblDept.Text = "Department"
        '
        'txtBP
        '
        Me.txtBP.Location = New System.Drawing.Point(216, 227)
        Me.txtBP.Name = "txtBP"
        Me.txtBP.Size = New System.Drawing.Size(134, 22)
        Me.txtBP.TabIndex = 7
        '
        'lblBP
        '
        Me.lblBP.AutoSize = True
        Me.lblBP.Location = New System.Drawing.Point(108, 227)
        Me.lblBP.Name = "lblBP"
        Me.lblBP.Size = New System.Drawing.Size(68, 16)
        Me.lblBP.TabIndex = 6
        Me.lblBP.Text = "Basic Pay"
        '
        'txtHRA
        '
        Me.txtHRA.Location = New System.Drawing.Point(216, 270)
        Me.txtHRA.Name = "txtHRA"
        Me.txtHRA.Size = New System.Drawing.Size(134, 22)
        Me.txtHRA.TabIndex = 9
        '
        'lblHRA
        '
        Me.lblHRA.AutoSize = True
        Me.lblHRA.Location = New System.Drawing.Point(108, 270)
        Me.lblHRA.Name = "lblHRA"
        Me.lblHRA.Size = New System.Drawing.Size(36, 16)
        Me.lblHRA.TabIndex = 8
        Me.lblHRA.Text = "HRA"
        '
        'txtDA
        '
        Me.txtDA.Location = New System.Drawing.Point(216, 313)
        Me.txtDA.Name = "txtDA"
        Me.txtDA.Size = New System.Drawing.Size(134, 22)
        Me.txtDA.TabIndex = 11
        '
        'lblDA
        '
        Me.lblDA.AutoSize = True
        Me.lblDA.Location = New System.Drawing.Point(108, 313)
        Me.lblDA.Name = "lblDA"
        Me.lblDA.Size = New System.Drawing.Size(26, 16)
        Me.lblDA.TabIndex = 10
        Me.lblDA.Text = "DA"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(432, 96)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(126, 34)
        Me.btnCalc.TabIndex = 12
        Me.btnCalc.Text = "Calculate Salary"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(735, 96)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(124, 34)
        Me.btnView.TabIndex = 13
        Me.btnView.Text = "View Records"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(459, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "EXPERIMENT 21 : PAYROLL PROCESSING SYSTEM"
        '
        'DataGridPayroll
        '
        Me.DataGridPayroll.AutoGenerateColumns = False
        Me.DataGridPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPayroll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TeacherIdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.BasicPayDataGridViewTextBoxColumn, Me.HRADataGridViewTextBoxColumn, Me.DADataGridViewTextBoxColumn, Me.GPDataGridViewTextBoxColumn, Me.NetPayDataGridViewTextBoxColumn})
        Me.DataGridPayroll.DataSource = Me.PAYROLLBindingSource
        Me.DataGridPayroll.Location = New System.Drawing.Point(432, 162)
        Me.DataGridPayroll.Name = "DataGridPayroll"
        Me.DataGridPayroll.RowHeadersWidth = 51
        Me.DataGridPayroll.RowTemplate.Height = 24
        Me.DataGridPayroll.Size = New System.Drawing.Size(427, 173)
        Me.DataGridPayroll.TabIndex = 15
        '
        'TeacherIdDataGridViewTextBoxColumn
        '
        Me.TeacherIdDataGridViewTextBoxColumn.DataPropertyName = "TeacherId"
        Me.TeacherIdDataGridViewTextBoxColumn.HeaderText = "TeacherId"
        Me.TeacherIdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TeacherIdDataGridViewTextBoxColumn.Name = "TeacherIdDataGridViewTextBoxColumn"
        Me.TeacherIdDataGridViewTextBoxColumn.Width = 125
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'BasicPayDataGridViewTextBoxColumn
        '
        Me.BasicPayDataGridViewTextBoxColumn.DataPropertyName = "basicPay"
        Me.BasicPayDataGridViewTextBoxColumn.HeaderText = "basicPay"
        Me.BasicPayDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BasicPayDataGridViewTextBoxColumn.Name = "BasicPayDataGridViewTextBoxColumn"
        Me.BasicPayDataGridViewTextBoxColumn.Width = 125
        '
        'HRADataGridViewTextBoxColumn
        '
        Me.HRADataGridViewTextBoxColumn.DataPropertyName = "HRA"
        Me.HRADataGridViewTextBoxColumn.HeaderText = "HRA"
        Me.HRADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HRADataGridViewTextBoxColumn.Name = "HRADataGridViewTextBoxColumn"
        Me.HRADataGridViewTextBoxColumn.Width = 125
        '
        'DADataGridViewTextBoxColumn
        '
        Me.DADataGridViewTextBoxColumn.DataPropertyName = "DA"
        Me.DADataGridViewTextBoxColumn.HeaderText = "DA"
        Me.DADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DADataGridViewTextBoxColumn.Name = "DADataGridViewTextBoxColumn"
        Me.DADataGridViewTextBoxColumn.Width = 125
        '
        'GPDataGridViewTextBoxColumn
        '
        Me.GPDataGridViewTextBoxColumn.DataPropertyName = "GP"
        Me.GPDataGridViewTextBoxColumn.HeaderText = "GP"
        Me.GPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GPDataGridViewTextBoxColumn.Name = "GPDataGridViewTextBoxColumn"
        Me.GPDataGridViewTextBoxColumn.Width = 125
        '
        'NetPayDataGridViewTextBoxColumn
        '
        Me.NetPayDataGridViewTextBoxColumn.DataPropertyName = "NetPay"
        Me.NetPayDataGridViewTextBoxColumn.HeaderText = "NetPay"
        Me.NetPayDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NetPayDataGridViewTextBoxColumn.Name = "NetPayDataGridViewTextBoxColumn"
        Me.NetPayDataGridViewTextBoxColumn.Width = 125
        '
        'PAYROLLBindingSource
        '
        Me.PAYROLLBindingSource.DataMember = "PAYROLL"
        Me.PAYROLLBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PAYROLLTableAdapter
        '
        Me.PAYROLLTableAdapter.ClearBeforeFill = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(585, 96)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(119, 34)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 417)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridPayroll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtDA)
        Me.Controls.Add(Me.lblDA)
        Me.Controls.Add(Me.txtHRA)
        Me.Controls.Add(Me.lblHRA)
        Me.Controls.Add(Me.txtBP)
        Me.Controls.Add(Me.lblBP)
        Me.Controls.Add(Me.txtDept)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PAYROLLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblId As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtDept As TextBox
    Friend WithEvents lblDept As Label
    Friend WithEvents txtBP As TextBox
    Friend WithEvents lblBP As Label
    Friend WithEvents txtHRA As TextBox
    Friend WithEvents lblHRA As Label
    Friend WithEvents txtDA As TextBox
    Friend WithEvents lblDA As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnView As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridPayroll As DataGridView
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents PAYROLLBindingSource As BindingSource
    Friend WithEvents PAYROLLTableAdapter As Database1DataSetTableAdapters.PAYROLLTableAdapter
    Friend WithEvents TeacherIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BasicPayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HRADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NetPayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As Button
End Class
