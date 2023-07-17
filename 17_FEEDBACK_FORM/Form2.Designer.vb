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
        Me.Database1DataSet = New _17_FeedbackForm.Database1DataSet()
        Me.FEEDBACKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FEEDBACKTableAdapter = New _17_FeedbackForm.Database1DataSetTableAdapters.FEEDBACKTableAdapter()
        Me.DataGridFEEDBACK = New System.Windows.Forms.DataGridView()
        Me.RegnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeedbackDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FEEDBACKBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet1 = New _17_FeedbackForm.Database1DataSet1()
        Me.FEEDBACKTableAdapter1 = New _17_FeedbackForm.Database1DataSet1TableAdapters.FEEDBACKTableAdapter()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnViewDate = New System.Windows.Forms.Button()
        Me.lblViewBy = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FEEDBACKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridFEEDBACK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FEEDBACKBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FEEDBACKBindingSource
        '
        Me.FEEDBACKBindingSource.DataMember = "FEEDBACK"
        Me.FEEDBACKBindingSource.DataSource = Me.Database1DataSet
        '
        'FEEDBACKTableAdapter
        '
        Me.FEEDBACKTableAdapter.ClearBeforeFill = True
        '
        'DataGridFEEDBACK
        '
        Me.DataGridFEEDBACK.AutoGenerateColumns = False
        Me.DataGridFEEDBACK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridFEEDBACK.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RegnoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.FeedbackDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.DataGridFEEDBACK.DataSource = Me.FEEDBACKBindingSource1
        Me.DataGridFEEDBACK.Location = New System.Drawing.Point(71, 253)
        Me.DataGridFEEDBACK.Name = "DataGridFEEDBACK"
        Me.DataGridFEEDBACK.RowHeadersWidth = 51
        Me.DataGridFEEDBACK.RowTemplate.Height = 24
        Me.DataGridFEEDBACK.Size = New System.Drawing.Size(657, 236)
        Me.DataGridFEEDBACK.TabIndex = 0
        '
        'RegnoDataGridViewTextBoxColumn
        '
        Me.RegnoDataGridViewTextBoxColumn.DataPropertyName = "regno"
        Me.RegnoDataGridViewTextBoxColumn.HeaderText = "regno"
        Me.RegnoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RegnoDataGridViewTextBoxColumn.Name = "RegnoDataGridViewTextBoxColumn"
        Me.RegnoDataGridViewTextBoxColumn.Width = 125
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "year"
        Me.YearDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        Me.YearDataGridViewTextBoxColumn.Width = 125
        '
        'FeedbackDataGridViewTextBoxColumn
        '
        Me.FeedbackDataGridViewTextBoxColumn.DataPropertyName = "feedback"
        Me.FeedbackDataGridViewTextBoxColumn.HeaderText = "feedback"
        Me.FeedbackDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FeedbackDataGridViewTextBoxColumn.Name = "FeedbackDataGridViewTextBoxColumn"
        Me.FeedbackDataGridViewTextBoxColumn.Width = 125
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "date"
        Me.DateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.Width = 125
        '
        'FEEDBACKBindingSource1
        '
        Me.FEEDBACKBindingSource1.DataMember = "FEEDBACK"
        Me.FEEDBACKBindingSource1.DataSource = Me.Database1DataSet1
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FEEDBACKTableAdapter1
        '
        Me.FEEDBACKTableAdapter1.ClearBeforeFill = True
        '
        'btnViewAll
        '
        Me.btnViewAll.Location = New System.Drawing.Point(286, 26)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(207, 41)
        Me.btnViewAll.TabIndex = 1
        Me.btnViewAll.Text = "VIEW ALL"
        Me.btnViewAll.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(360, 130)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(117, 22)
        Me.txtDate.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(299, 135)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(44, 16)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "DATE"
        '
        'btnViewDate
        '
        Me.btnViewDate.Location = New System.Drawing.Point(286, 172)
        Me.btnViewDate.Name = "btnViewDate"
        Me.btnViewDate.Size = New System.Drawing.Size(207, 41)
        Me.btnViewDate.TabIndex = 4
        Me.btnViewDate.Text = "VIEW "
        Me.btnViewDate.UseVisualStyleBackColor = True
        '
        'lblViewBy
        '
        Me.lblViewBy.AutoSize = True
        Me.lblViewBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewBy.Location = New System.Drawing.Point(309, 86)
        Me.lblViewBy.Name = "lblViewBy"
        Me.lblViewBy.Size = New System.Drawing.Size(166, 25)
        Me.lblViewBy.TabIndex = 5
        Me.lblViewBy.Text = "VIEW BY DATE"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 530)
        Me.Controls.Add(Me.lblViewBy)
        Me.Controls.Add(Me.btnViewDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.DataGridFEEDBACK)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FEEDBACKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridFEEDBACK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FEEDBACKBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents FEEDBACKBindingSource As BindingSource
    Friend WithEvents FEEDBACKTableAdapter As Database1DataSetTableAdapters.FEEDBACKTableAdapter
    Friend WithEvents DataGridFEEDBACK As DataGridView
    Friend WithEvents Database1DataSet1 As Database1DataSet1
    Friend WithEvents FEEDBACKBindingSource1 As BindingSource
    Friend WithEvents FEEDBACKTableAdapter1 As Database1DataSet1TableAdapters.FEEDBACKTableAdapter
    Friend WithEvents RegnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FeedbackDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnViewAll As Button
    Friend WithEvents txtDate As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents btnViewDate As Button
    Friend WithEvents lblViewBy As Label
End Class
