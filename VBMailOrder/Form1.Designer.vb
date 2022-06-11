<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VBMailOrderForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VBMailOrderForm))
        Me.CustomerRelationsButton = New System.Windows.Forms.Button()
        Me.MarketingButton = New System.Windows.Forms.Button()
        Me.OrderProcessingButton = New System.Windows.Forms.Button()
        Me.ShippingDepartmentsButton = New System.Windows.Forms.Button()
        Me.SelectDepartmentGroupBox = New System.Windows.Forms.GroupBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NumberLabel = New System.Windows.Forms.Label()
        Me.ContactPersonInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.TelephoneNunberLabel = New System.Windows.Forms.Label()
        Me.DepartmentContactLabel = New System.Windows.Forms.Label()
        Me.FormControlGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ColorGroupBox = New System.Windows.Forms.GroupBox()
        Me.Color2GroupBox = New System.Windows.Forms.GroupBox()
        Me.CreatorLabel = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.SelectDepartmentGroupBox.SuspendLayout()
        Me.ContactPersonInformationGroupBox.SuspendLayout()
        Me.FormControlGroupBox.SuspendLayout()
        Me.Color2GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerRelationsButton
        '
        Me.CustomerRelationsButton.BackColor = System.Drawing.Color.Cornsilk
        Me.CustomerRelationsButton.Location = New System.Drawing.Point(18, 26)
        Me.CustomerRelationsButton.Name = "CustomerRelationsButton"
        Me.CustomerRelationsButton.Size = New System.Drawing.Size(226, 60)
        Me.CustomerRelationsButton.TabIndex = 0
        Me.CustomerRelationsButton.Text = "Customer Relations"
        Me.CustomerRelationsButton.UseVisualStyleBackColor = False
        '
        'MarketingButton
        '
        Me.MarketingButton.BackColor = System.Drawing.Color.Cornsilk
        Me.MarketingButton.Location = New System.Drawing.Point(18, 92)
        Me.MarketingButton.Name = "MarketingButton"
        Me.MarketingButton.Size = New System.Drawing.Size(226, 66)
        Me.MarketingButton.TabIndex = 1
        Me.MarketingButton.Text = "Marketing"
        Me.MarketingButton.UseVisualStyleBackColor = False
        '
        'OrderProcessingButton
        '
        Me.OrderProcessingButton.BackColor = System.Drawing.Color.Cornsilk
        Me.OrderProcessingButton.Location = New System.Drawing.Point(18, 164)
        Me.OrderProcessingButton.Name = "OrderProcessingButton"
        Me.OrderProcessingButton.Size = New System.Drawing.Size(226, 74)
        Me.OrderProcessingButton.TabIndex = 2
        Me.OrderProcessingButton.Text = "Order Processing"
        Me.OrderProcessingButton.UseVisualStyleBackColor = False
        '
        'ShippingDepartmentsButton
        '
        Me.ShippingDepartmentsButton.BackColor = System.Drawing.Color.Cornsilk
        Me.ShippingDepartmentsButton.Location = New System.Drawing.Point(18, 244)
        Me.ShippingDepartmentsButton.Name = "ShippingDepartmentsButton"
        Me.ShippingDepartmentsButton.Size = New System.Drawing.Size(226, 73)
        Me.ShippingDepartmentsButton.TabIndex = 3
        Me.ShippingDepartmentsButton.Text = "Shipping Departments"
        Me.ShippingDepartmentsButton.UseVisualStyleBackColor = False
        '
        'SelectDepartmentGroupBox
        '
        Me.SelectDepartmentGroupBox.BackColor = System.Drawing.Color.Khaki
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
        Me.NameLabel.Location = New System.Drawing.Point(52, 76)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(0, 20)
        Me.NameLabel.TabIndex = 5
        '
        'NumberLabel
        '
        Me.NumberLabel.AutoSize = True
        Me.NumberLabel.Location = New System.Drawing.Point(52, 150)
        Me.NumberLabel.Name = "NumberLabel"
        Me.NumberLabel.Size = New System.Drawing.Size(0, 20)
        Me.NumberLabel.TabIndex = 6
        '
        'ContactPersonInformationGroupBox
        '
        Me.ContactPersonInformationGroupBox.BackColor = System.Drawing.Color.Khaki
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
        'TelephoneNunberLabel
        '
        Me.TelephoneNunberLabel.AutoSize = True
        Me.TelephoneNunberLabel.Location = New System.Drawing.Point(13, 115)
        Me.TelephoneNunberLabel.Name = "TelephoneNunberLabel"
        Me.TelephoneNunberLabel.Size = New System.Drawing.Size(134, 20)
        Me.TelephoneNunberLabel.TabIndex = 8
        Me.TelephoneNunberLabel.Text = "Telephone Nunber:"
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
        'FormControlGroupBox
        '
        Me.FormControlGroupBox.BackColor = System.Drawing.Color.Khaki
        Me.FormControlGroupBox.Controls.Add(Me.ExitButton)
        Me.FormControlGroupBox.Controls.Add(Me.PrintButton)
        Me.FormControlGroupBox.Location = New System.Drawing.Point(247, 235)
        Me.FormControlGroupBox.Name = "FormControlGroupBox"
        Me.FormControlGroupBox.Size = New System.Drawing.Size(285, 203)
        Me.FormControlGroupBox.TabIndex = 8
        Me.FormControlGroupBox.TabStop = False
        Me.FormControlGroupBox.Text = "Form Control"
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Cornsilk
        Me.ExitButton.Location = New System.Drawing.Point(13, 113)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(266, 73)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.Color.Cornsilk
        Me.PrintButton.Location = New System.Drawing.Point(13, 26)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(266, 73)
        Me.PrintButton.TabIndex = 0
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'ColorGroupBox
        '
        Me.ColorGroupBox.BackColor = System.Drawing.Color.Cornsilk
        Me.ColorGroupBox.Location = New System.Drawing.Point(12, 25)
        Me.ColorGroupBox.Name = "ColorGroupBox"
        Me.ColorGroupBox.Size = New System.Drawing.Size(229, 413)
        Me.ColorGroupBox.TabIndex = 9
        Me.ColorGroupBox.TabStop = False
        '
        'Color2GroupBox
        '
        Me.Color2GroupBox.BackColor = System.Drawing.Color.Khaki
        Me.Color2GroupBox.Controls.Add(Me.CreatorLabel)
        Me.Color2GroupBox.Location = New System.Drawing.Point(539, 372)
        Me.Color2GroupBox.Name = "Color2GroupBox"
        Me.Color2GroupBox.Size = New System.Drawing.Size(249, 66)
        Me.Color2GroupBox.TabIndex = 10
        Me.Color2GroupBox.TabStop = False
        '
        'CreatorLabel
        '
        Me.CreatorLabel.AutoSize = True
        Me.CreatorLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CreatorLabel.Location = New System.Drawing.Point(17, 20)
        Me.CreatorLabel.Name = "CreatorLabel"
        Me.CreatorLabel.Size = New System.Drawing.Size(194, 28)
        Me.CreatorLabel.TabIndex = 0
        Me.CreatorLabel.Text = "Joseph Etse 9404119"
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "VBMailOrderForm"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'VBMailOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Color2GroupBox)
        Me.Controls.Add(Me.ColorGroupBox)
        Me.Controls.Add(Me.FormControlGroupBox)
        Me.Controls.Add(Me.ContactPersonInformationGroupBox)
        Me.Controls.Add(Me.SelectDepartmentGroupBox)
        Me.Name = "VBMailOrderForm"
        Me.Text = "VB Mail Order"
        Me.SelectDepartmentGroupBox.ResumeLayout(False)
        Me.ContactPersonInformationGroupBox.ResumeLayout(False)
        Me.ContactPersonInformationGroupBox.PerformLayout()
        Me.FormControlGroupBox.ResumeLayout(False)
        Me.Color2GroupBox.ResumeLayout(False)
        Me.Color2GroupBox.PerformLayout()
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
    Friend WithEvents FormControlGroupBox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents ColorGroupBox As GroupBox
    Friend WithEvents Color2GroupBox As GroupBox
    Friend WithEvents CreatorLabel As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
