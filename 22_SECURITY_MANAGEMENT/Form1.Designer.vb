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
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtLeaves = New System.Windows.Forms.TextBox()
        Me.lblLeaves = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtId2 = New System.Windows.Forms.TextBox()
        Me.lblId2 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(81, 132)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(92, 20)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Security ID"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(205, 128)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(195, 27)
        Me.txtId.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(204, 182)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(195, 27)
        Me.txtName.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(101, 185)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(53, 20)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'txtLeaves
        '
        Me.txtLeaves.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeaves.Location = New System.Drawing.Point(592, 187)
        Me.txtLeaves.Name = "txtLeaves"
        Me.txtLeaves.Size = New System.Drawing.Size(195, 27)
        Me.txtLeaves.TabIndex = 5
        '
        'lblLeaves
        '
        Me.lblLeaves.AutoSize = True
        Me.lblLeaves.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaves.Location = New System.Drawing.Point(486, 190)
        Me.lblLeaves.Name = "lblLeaves"
        Me.lblLeaves.Size = New System.Drawing.Size(63, 20)
        Me.lblLeaves.TabIndex = 4
        Me.lblLeaves.Text = "Leaves"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(177, 239)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(166, 41)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "ADD RECORD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtId2
        '
        Me.txtId2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId2.Location = New System.Drawing.Point(592, 128)
        Me.txtId2.Name = "txtId2"
        Me.txtId2.Size = New System.Drawing.Size(195, 27)
        Me.txtId2.TabIndex = 8
        '
        'lblId2
        '
        Me.lblId2.AutoSize = True
        Me.lblId2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId2.Location = New System.Drawing.Point(471, 132)
        Me.lblId2.Name = "lblId2"
        Me.lblId2.Size = New System.Drawing.Size(92, 20)
        Me.lblId2.TabIndex = 7
        Me.lblId2.Text = "Security ID"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(564, 239)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(166, 41)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "UPDATE RECORD"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(350, 330)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(166, 41)
        Me.btnView.TabIndex = 10
        Me.btnView.Text = "VIEW RECORD"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(476, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "EXPERIMENR 22 : SECURITY MANAGEMENT SYSTEM"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtId2)
        Me.Controls.Add(Me.lblId2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtLeaves)
        Me.Controls.Add(Me.lblLeaves)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblId As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtLeaves As TextBox
    Friend WithEvents lblLeaves As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtId2 As TextBox
    Friend WithEvents lblId2 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnView As Button
    Friend WithEvents Label2 As Label
End Class
