<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Database1DataSet = New _22_SECURITY_MANAGEMENT.Database1DataSet()
        Me.Database1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridSecurity = New System.Windows.Forms.DataGridView()
        Me.Database1DataSet1 = New _22_SECURITY_MANAGEMENT.Database1DataSet1()
        Me.SECURITYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SECURITYTableAdapter = New _22_SECURITY_MANAGEMENT.Database1DataSet1TableAdapters.SECURITYTableAdapter()
        Me.SecurityIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeavesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.lblLeave2 = New System.Windows.Forms.Label()
        Me.txtLeaves = New System.Windows.Forms.TextBox()
        Me.btnLeaves = New System.Windows.Forms.Button()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridSecurity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SECURITYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Database1DataSetBindingSource
        '
        Me.Database1DataSetBindingSource.DataSource = Me.Database1DataSet
        Me.Database1DataSetBindingSource.Position = 0
        '
        'Database1DataSetBindingSource1
        '
        Me.Database1DataSetBindingSource1.DataSource = Me.Database1DataSet
        Me.Database1DataSetBindingSource1.Position = 0
        '
        'DataGridSecurity
        '
        Me.DataGridSecurity.AutoGenerateColumns = False
        Me.DataGridSecurity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSecurity.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SecurityIdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.LeavesDataGridViewTextBoxColumn})
        Me.DataGridSecurity.DataSource = Me.SECURITYBindingSource
        Me.DataGridSecurity.Location = New System.Drawing.Point(54, 42)
        Me.DataGridSecurity.Name = "DataGridSecurity"
        Me.DataGridSecurity.RowHeadersWidth = 51
        Me.DataGridSecurity.RowTemplate.Height = 24
        Me.DataGridSecurity.Size = New System.Drawing.Size(429, 354)
        Me.DataGridSecurity.TabIndex = 0
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SECURITYBindingSource
        '
        Me.SECURITYBindingSource.DataMember = "SECURITY"
        Me.SECURITYBindingSource.DataSource = Me.Database1DataSet1
        '
        'SECURITYTableAdapter
        '
        Me.SECURITYTableAdapter.ClearBeforeFill = True
        '
        'SecurityIdDataGridViewTextBoxColumn
        '
        Me.SecurityIdDataGridViewTextBoxColumn.DataPropertyName = "securityId"
        Me.SecurityIdDataGridViewTextBoxColumn.HeaderText = "securityId"
        Me.SecurityIdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SecurityIdDataGridViewTextBoxColumn.Name = "SecurityIdDataGridViewTextBoxColumn"
        Me.SecurityIdDataGridViewTextBoxColumn.Width = 125
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'LeavesDataGridViewTextBoxColumn
        '
        Me.LeavesDataGridViewTextBoxColumn.DataPropertyName = "leaves"
        Me.LeavesDataGridViewTextBoxColumn.HeaderText = "leaves"
        Me.LeavesDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LeavesDataGridViewTextBoxColumn.Name = "LeavesDataGridViewTextBoxColumn"
        Me.LeavesDataGridViewTextBoxColumn.Width = 125
        '
        'btnViewAll
        '
        Me.btnViewAll.Location = New System.Drawing.Point(592, 89)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(197, 57)
        Me.btnViewAll.TabIndex = 1
        Me.btnViewAll.Text = "VIEW ALL"
        Me.btnViewAll.UseVisualStyleBackColor = True
        '
        'lblLeave2
        '
        Me.lblLeave2.AutoSize = True
        Me.lblLeave2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeave2.Location = New System.Drawing.Point(626, 198)
        Me.lblLeave2.Name = "lblLeave2"
        Me.lblLeave2.Size = New System.Drawing.Size(143, 20)
        Me.lblLeave2.TabIndex = 2
        Me.lblLeave2.Text = "View By Leaves"
        '
        'txtLeaves
        '
        Me.txtLeaves.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeaves.Location = New System.Drawing.Point(592, 235)
        Me.txtLeaves.Name = "txtLeaves"
        Me.txtLeaves.Size = New System.Drawing.Size(197, 27)
        Me.txtLeaves.TabIndex = 3
        '
        'btnLeaves
        '
        Me.btnLeaves.Location = New System.Drawing.Point(592, 289)
        Me.btnLeaves.Name = "btnLeaves"
        Me.btnLeaves.Size = New System.Drawing.Size(197, 57)
        Me.btnLeaves.TabIndex = 4
        Me.btnLeaves.Text = "VIEW"
        Me.btnLeaves.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 450)
        Me.Controls.Add(Me.btnLeaves)
        Me.Controls.Add(Me.txtLeaves)
        Me.Controls.Add(Me.lblLeave2)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.DataGridSecurity)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridSecurity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SECURITYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSetBindingSource As BindingSource
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents Database1DataSetBindingSource1 As BindingSource
    Friend WithEvents DataGridSecurity As DataGridView
    Friend WithEvents Database1DataSet1 As Database1DataSet1
    Friend WithEvents SECURITYBindingSource As BindingSource
    Friend WithEvents SECURITYTableAdapter As Database1DataSet1TableAdapters.SECURITYTableAdapter
    Friend WithEvents SecurityIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LeavesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnViewAll As Button
    Friend WithEvents lblLeave2 As Label
    Friend WithEvents txtLeaves As TextBox
    Friend WithEvents btnLeaves As Button
End Class
