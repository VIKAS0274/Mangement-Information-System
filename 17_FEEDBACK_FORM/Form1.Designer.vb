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
        Me.chkBad = New System.Windows.Forms.CheckBox()
        Me.chkAvg = New System.Windows.Forms.CheckBox()
        Me.chkGood = New System.Windows.Forms.CheckBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblRegNo = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtRegNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstBoxYear = New System.Windows.Forms.ListBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Database1DataSet = New _17_FeedbackForm.Database1DataSet()
        Me.FEEDBACKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FEEDBACKTableAdapter = New _17_FeedbackForm.Database1DataSetTableAdapters.FEEDBACKTableAdapter()
        Me.btnView = New System.Windows.Forms.Button()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FEEDBACKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkBad
        '
        Me.chkBad.AutoSize = True
        Me.chkBad.Location = New System.Drawing.Point(236, 268)
        Me.chkBad.Name = "chkBad"
        Me.chkBad.Size = New System.Drawing.Size(54, 20)
        Me.chkBad.TabIndex = 0
        Me.chkBad.Text = "Bad"
        Me.chkBad.UseVisualStyleBackColor = True
        '
        'chkAvg
        '
        Me.chkAvg.AutoSize = True
        Me.chkAvg.Location = New System.Drawing.Point(380, 268)
        Me.chkAvg.Name = "chkAvg"
        Me.chkAvg.Size = New System.Drawing.Size(81, 20)
        Me.chkAvg.TabIndex = 1
        Me.chkAvg.Text = "Average"
        Me.chkAvg.UseVisualStyleBackColor = True
        '
        'chkGood
        '
        Me.chkGood.AutoSize = True
        Me.chkGood.Location = New System.Drawing.Point(539, 268)
        Me.chkGood.Name = "chkGood"
        Me.chkGood.Size = New System.Drawing.Size(63, 20)
        Me.chkGood.TabIndex = 2
        Me.chkGood.Text = "Good"
        Me.chkGood.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(240, 91)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        '
        'lblRegNo
        '
        Me.lblRegNo.AutoSize = True
        Me.lblRegNo.Location = New System.Drawing.Point(225, 136)
        Me.lblRegNo.Name = "lblRegNo"
        Me.lblRegNo.Size = New System.Drawing.Size(79, 16)
        Me.lblRegNo.TabIndex = 4
        Me.lblRegNo.Text = "Register No"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(331, 85)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(180, 22)
        Me.txtName.TabIndex = 5
        '
        'txtRegNo
        '
        Me.txtRegNo.Location = New System.Drawing.Point(331, 136)
        Me.txtRegNo.Name = "txtRegNo"
        Me.txtRegNo.Size = New System.Drawing.Size(180, 22)
        Me.txtRegNo.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ENTER YOUR COURSE FEEDBACK"
        '
        'lstBoxYear
        '
        Me.lstBoxYear.FormattingEnabled = True
        Me.lstBoxYear.ItemHeight = 16
        Me.lstBoxYear.Items.AddRange(New Object() {"FreshMan Year", "Second Year", "Pre Final Year", "Final Year"})
        Me.lstBoxYear.Location = New System.Drawing.Point(537, 91)
        Me.lstBoxYear.Name = "lstBoxYear"
        Me.lstBoxYear.Size = New System.Drawing.Size(120, 84)
        Me.lstBoxYear.TabIndex = 8
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(534, 71)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(89, 16)
        Me.lblYear.TabIndex = 9
        Me.lblYear.Text = "Year Of Study"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(317, 310)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(206, 56)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "SUBMIT FEEDBACK"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(142, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(585, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "EXPERIMENT 17 : STUDENT FEEDBACK FORM"
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
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(318, 382)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(206, 56)
        Me.btnView.TabIndex = 12
        Me.btnView.Text = "VIEW RECORDS"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(331, 185)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(180, 22)
        Me.txtDate.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(243, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 439)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 32)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ACHYUTANANDA SAHOO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "192011002" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 480)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lstBoxYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRegNo)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblRegNo)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.chkGood)
        Me.Controls.Add(Me.chkAvg)
        Me.Controls.Add(Me.chkBad)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FEEDBACKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkBad As CheckBox
    Friend WithEvents chkAvg As CheckBox
    Friend WithEvents chkGood As CheckBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblRegNo As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtRegNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstBoxYear As ListBox
    Friend WithEvents lblYear As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents FEEDBACKBindingSource As BindingSource
    Friend WithEvents FEEDBACKTableAdapter As Database1DataSetTableAdapters.FEEDBACKTableAdapter
    Friend WithEvents btnView As Button
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
