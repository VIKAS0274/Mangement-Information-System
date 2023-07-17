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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.chk3 = New System.Windows.Forms.CheckBox()
        Me.chk4 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridBill = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FooditemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FOODBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New _25_FOOD_BILLING.Database1DataSet()
        Me.FOODTableAdapter = New _25_FOOD_BILLING.Database1DataSetTableAdapters.FOODTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridTotal = New System.Windows.Forms.DataGridView()
        Me.TotalAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FOODBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CHOOSE FOOD ITEM"
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.Location = New System.Drawing.Point(71, 107)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(91, 20)
        Me.chk1.TabIndex = 1
        Me.chk1.Text = "Fried Rice"
        Me.chk1.UseVisualStyleBackColor = True
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.Location = New System.Drawing.Point(193, 107)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(52, 20)
        Me.chk2.TabIndex = 2
        Me.chk2.Text = "Grill"
        Me.chk2.UseVisualStyleBackColor = True
        '
        'chk3
        '
        Me.chk3.AutoSize = True
        Me.chk3.Location = New System.Drawing.Point(288, 107)
        Me.chk3.Name = "chk3"
        Me.chk3.Size = New System.Drawing.Size(75, 20)
        Me.chk3.TabIndex = 3
        Me.chk3.Text = "Chapati"
        Me.chk3.UseVisualStyleBackColor = True
        '
        'chk4
        '
        Me.chk4.AutoSize = True
        Me.chk4.Location = New System.Drawing.Point(401, 107)
        Me.chk4.Name = "chk4"
        Me.chk4.Size = New System.Drawing.Size(66, 20)
        Me.chk4.TabIndex = 4
        Me.chk4.Text = "Meals"
        Me.chk4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(71, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.SystemColors.Control
        Me.txtQuantity.Location = New System.Drawing.Point(145, 147)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(322, 22)
        Me.txtQuantity.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(71, 194)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 43)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "ADD ITEM"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(280, 194)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 43)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "GENERATE BILL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "TOTAL ITEMS"
        '
        'DataGridBill
        '
        Me.DataGridBill.AutoGenerateColumns = False
        Me.DataGridBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridBill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FooditemDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridBill.DataSource = Me.FOODBindingSource
        Me.DataGridBill.Location = New System.Drawing.Point(36, 295)
        Me.DataGridBill.Name = "DataGridBill"
        Me.DataGridBill.RowHeadersWidth = 51
        Me.DataGridBill.RowTemplate.Height = 24
        Me.DataGridBill.Size = New System.Drawing.Size(550, 173)
        Me.DataGridBill.TabIndex = 10
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 125
        '
        'FooditemDataGridViewTextBoxColumn
        '
        Me.FooditemDataGridViewTextBoxColumn.DataPropertyName = "fooditem"
        Me.FooditemDataGridViewTextBoxColumn.HeaderText = "fooditem"
        Me.FooditemDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FooditemDataGridViewTextBoxColumn.Name = "FooditemDataGridViewTextBoxColumn"
        Me.FooditemDataGridViewTextBoxColumn.Width = 125
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.Width = 125
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.Width = 125
        '
        'FOODBindingSource
        '
        Me.FOODBindingSource.DataMember = "FOOD"
        Me.FOODBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FOODTableAdapter
        '
        Me.FOODTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(580, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "DELETE ITEM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(568, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Id"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(595, 108)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(126, 22)
        Me.txtId.TabIndex = 13
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(555, 150)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 43)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(555, 199)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(192, 43)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "CLEAR ALL"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(633, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "TOTAL BILL"
        '
        'DataGridTotal
        '
        Me.DataGridTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TotalAmt})
        Me.DataGridTotal.Location = New System.Drawing.Point(614, 361)
        Me.DataGridTotal.Name = "DataGridTotal"
        Me.DataGridTotal.RowHeadersWidth = 51
        Me.DataGridTotal.RowTemplate.Height = 24
        Me.DataGridTotal.Size = New System.Drawing.Size(163, 97)
        Me.DataGridTotal.TabIndex = 17
        '
        'TotalAmt
        '
        Me.TotalAmt.HeaderText = "Total"
        Me.TotalAmt.MinimumWidth = 6
        Me.TotalAmt.Name = "TotalAmt"
        Me.TotalAmt.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 562)
        Me.Controls.Add(Me.DataGridTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridBill)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chk4)
        Me.Controls.Add(Me.chk3)
        Me.Controls.Add(Me.chk2)
        Me.Controls.Add(Me.chk1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FOODBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridBill As DataGridView
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents FOODBindingSource As BindingSource
    Friend WithEvents FOODTableAdapter As Database1DataSetTableAdapters.FOODTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FooditemDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridTotal As DataGridView
    Friend WithEvents TotalAmt As DataGridViewTextBoxColumn
End Class
