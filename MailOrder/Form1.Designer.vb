<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VBMailOrderForm
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
        Me.CustomerRelationsButton = New System.Windows.Forms.Button()
        Me.MarketingButton = New System.Windows.Forms.Button()
        Me.OrderProcessingButton = New System.Windows.Forms.Button()
        Me.ShippingDepartmentsButton = New System.Windows.Forms.Button()
        Me.SelectDepartmentGroupBox = New System.Windows.Forms.GroupBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NumberLabel = New System.Windows.Forms.Label()
        Me.ContactPersonInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.DepartmentContactLabel = New System.Windows.Forms.Label()
        Me.TelephoneNunberLabel = New System.Windows.Forms.Label()
        Me.SelectDepartmentGroupBox.SuspendLayout()
        Me.ContactPersonInformationGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerRelationsButton
        '
        Me.CustomerRelationsButton.Location = New System.Drawing.Point(18, 26)
        Me.CustomerRelationsButton.Name = "CustomerRelationsButton"
        Me.CustomerRelationsButton.Size = New System.Drawing.Size(226, 60)
        Me.CustomerRelationsButton.TabIndex = 0
        Me.CustomerRelationsButton.Text = "Customer Relations"
        Me.CustomerRelationsButton.UseVisualStyleBackColor = True
        '
        'MarketingButton
        '
        Me.MarketingButton.Location = New System.Drawing.Point(18, 92)
        Me.MarketingButton.Name = "MarketingButton"
        Me.MarketingButton.Size = New System.Drawing.Size(226, 66)
        Me.MarketingButton.TabIndex = 1
        Me.MarketingButton.Text = "Marketing"
        Me.MarketingButton.UseVisualStyleBackColor = True
        '
        'OrderProcessingButton
        '
        Me.OrderProcessingButton.Location = New System.Drawing.Point(18, 164)
        Me.OrderProcessingButton.Name = "OrderProcessingButton"
        Me.OrderProcessingButton.Size = New System.Drawing.Size(226, 74)
        Me.OrderProcessingButton.TabIndex = 2
        Me.OrderProcessingButton.Text = "Order Processing"
        Me.OrderProcessingButton.UseVisualStyleBackColor = True
        '
        'ShippingDepartmentsButton
        '
        Me.ShippingDepartmentsButton.Location = New System.Drawing.Point(18, 244)
        Me.ShippingDepartmentsButton.Name = "ShippingDepartmentsButton"
        Me.ShippingDepartmentsButton.Size = New System.Drawing.Size(226, 73)
        Me.ShippingDepartmentsButton.TabIndex = 3
        Me.ShippingDepartmentsButton.Text = "Shipping Departments"
        Me.ShippingDepartmentsButton.UseVisualStyleBackColor = True
        '
        'SelectDepartmentGroupBox
        '
        Me.SelectDepartmentGroupBox.Controls.Add(Me.CustomerRelationsButton)
        Me.SelectDepartmentGroupBox.Controls.Add(Me.ShippingDepartmentsButton)
        Me.SelectDepartmentGroupBox.Controls.Add(Me.MarketingButton)
        Me.SelectDepartmentGroupBox.Controls.Add(Me.OrderProcessingButton)
        Me.SelectDepartmentGroupBox.Location = New System.Drawing.Point(538, 25)
        Me.SelectDepartmentGroupBox.Name = "SelectDepartmentGroupBox"
        Me.SelectDepartmentGroupBox.Size = New System.Drawing.Size(250, 341)
        Me.SelectDepartmentGroupBox.TabIndex = 4
        Me.SelectDepartmentGroupBox.TabStop = False
        Me.SelectDepartmentGroupBox.Text = "Select Department"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(160, 66)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(0, 20)
        Me.NameLabel.TabIndex = 5
        '
        'NumberLabel
        '
        Me.NumberLabel.AutoSize = True
        Me.NumberLabel.Location = New System.Drawing.Point(160, 149)
        Me.NumberLabel.Name = "NumberLabel"
        Me.NumberLabel.Size = New System.Drawing.Size(0, 20)
        Me.NumberLabel.TabIndex = 6
        '
        'ContactPersonInformationGroupBox
        '
        Me.ContactPersonInformationGroupBox.Controls.Add(Me.TelephoneNunberLabel)
        Me.ContactPersonInformationGroupBox.Controls.Add(Me.DepartmentContactLabel)
        Me.ContactPersonInformationGroupBox.Controls.Add(Me.NameLabel)
        Me.ContactPersonInformationGroupBox.Controls.Add(Me.NumberLabel)
        Me.ContactPersonInformationGroupBox.Location = New System.Drawing.Point(247, 25)
        Me.ContactPersonInformationGroupBox.Name = "ContactPersonInformationGroupBox"
        Me.ContactPersonInformationGroupBox.Size = New System.Drawing.Size(285, 203)
        Me.ContactPersonInformationGroupBox.TabIndex = 7
        Me.ContactPersonInformationGroupBox.TabStop = False
        Me.ContactPersonInformationGroupBox.Text = "Contact Person Information"
        '
        'DepartmentContactLabel
        '
        Me.DepartmentContactLabel.AutoSize = True
        Me.DepartmentContactLabel.Location = New System.Drawing.Point(13, 46)
        Me.DepartmentContactLabel.Name = "DepartmentContactLabel"
        Me.DepartmentContactLabel.Size = New System.Drawing.Size(147, 20)
        Me.DepartmentContactLabel.TabIndex = 7
        Me.DepartmentContactLabel.Text = "Department Contact:"
        '
        'TelephoneNunberLabel
        '
        Me.TelephoneNunberLabel.AutoSize = True
        Me.TelephoneNunberLabel.Location = New System.Drawing.Point(13, 115)
        Me.TelephoneNunberLabel.Name = "TelephoneNunberLabel"
        Me.TelephoneNunberLabel.Size = New System.Drawing.Size(134, 20)
        Me.TelephoneNunberLabel.TabIndex = 8
        Me.TelephoneNunberLabel.Text = "Telephone Nunber:"
        '
        'VBMailOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ContactPersonInformationGroupBox)
        Me.Controls.Add(Me.SelectDepartmentGroupBox)
        Me.Name = "VBMailOrderForm"
        Me.Text = "VB Mail Order"
        Me.SelectDepartmentGroupBox.ResumeLayout(False)
        Me.ContactPersonInformationGroupBox.ResumeLayout(False)
        Me.ContactPersonInformationGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustomerRelationsButton As Button
    Friend WithEvents MarketingButton As Button
    Friend WithEvents OrderProcessingButton As Button
    Friend WithEvents ShippingDepartmentsButton As Button
    Friend WithEvents SelectDepartmentGroupBox As GroupBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents NumberLabel As Label
    Friend WithEvents ContactPersonInformationGroupBox As GroupBox
    Friend WithEvents TelephoneNunberLabel As Label
    Friend WithEvents DepartmentContactLabel As Label
End Class
