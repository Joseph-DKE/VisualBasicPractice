<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPFEForm
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
        Me.PartInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.PartDescriptionLabel = New System.Windows.Forms.Label()
        Me.PartIdentifierLabel = New System.Windows.Forms.Label()
        Me.PartDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PartIdentifierTextBox = New System.Windows.Forms.TextBox()
        Me.PCSPGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WholesaleCostLabel = New System.Windows.Forms.Label()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.GrossProfitLabel = New System.Windows.Forms.Label()
        Me.StorageChargesLabel = New System.Windows.Forms.Label()
        Me.NetProfitLabel = New System.Windows.Forms.Label()
        Me.RetailPriceTextBox = New System.Windows.Forms.TextBox()
        Me.WholesaleCostTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.GrossProfitTextBox = New System.Windows.Forms.TextBox()
        Me.StorageChargesTextBox = New System.Windows.Forms.TextBox()
        Me.NetProfitTextBox = New System.Windows.Forms.TextBox()
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.ResetFormButton = New System.Windows.Forms.Button()
        Me.TotalNetProfitButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.RPFEToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PartInformationGroupBox.SuspendLayout()
        Me.PCSPGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PartInformationGroupBox
        '
        Me.PartInformationGroupBox.Controls.Add(Me.PartDescriptionLabel)
        Me.PartInformationGroupBox.Controls.Add(Me.PartIdentifierLabel)
        Me.PartInformationGroupBox.Controls.Add(Me.PartDescriptionTextBox)
        Me.PartInformationGroupBox.Controls.Add(Me.PartIdentifierTextBox)
        Me.PartInformationGroupBox.ForeColor = System.Drawing.SystemColors.Highlight
        Me.PartInformationGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.PartInformationGroupBox.Name = "PartInformationGroupBox"
        Me.PartInformationGroupBox.Size = New System.Drawing.Size(623, 122)
        Me.PartInformationGroupBox.TabIndex = 0
        Me.PartInformationGroupBox.TabStop = False
        Me.PartInformationGroupBox.Text = "Part Information"
        '
        'PartDescriptionLabel
        '
        Me.PartDescriptionLabel.AutoSize = True
        Me.PartDescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PartDescriptionLabel.Location = New System.Drawing.Point(18, 74)
        Me.PartDescriptionLabel.Name = "PartDescriptionLabel"
        Me.PartDescriptionLabel.Size = New System.Drawing.Size(117, 20)
        Me.PartDescriptionLabel.TabIndex = 3
        Me.PartDescriptionLabel.Text = "Part &Description:"
        '
        'PartIdentifierLabel
        '
        Me.PartIdentifierLabel.AutoSize = True
        Me.PartIdentifierLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PartIdentifierLabel.Location = New System.Drawing.Point(18, 26)
        Me.PartIdentifierLabel.Name = "PartIdentifierLabel"
        Me.PartIdentifierLabel.Size = New System.Drawing.Size(101, 20)
        Me.PartIdentifierLabel.TabIndex = 2
        Me.PartIdentifierLabel.Text = "&Part Identifier:"
        '
        'PartDescriptionTextBox
        '
        Me.PartDescriptionTextBox.Location = New System.Drawing.Point(214, 74)
        Me.PartDescriptionTextBox.Name = "PartDescriptionTextBox"
        Me.PartDescriptionTextBox.Size = New System.Drawing.Size(403, 27)
        Me.PartDescriptionTextBox.TabIndex = 1
        '
        'PartIdentifierTextBox
        '
        Me.PartIdentifierTextBox.Location = New System.Drawing.Point(214, 26)
        Me.PartIdentifierTextBox.Name = "PartIdentifierTextBox"
        Me.PartIdentifierTextBox.Size = New System.Drawing.Size(403, 27)
        Me.PartIdentifierTextBox.TabIndex = 0
        '
        'PCSPGroupBox
        '
        Me.PCSPGroupBox.Controls.Add(Me.Label3)
        Me.PCSPGroupBox.Controls.Add(Me.WholesaleCostLabel)
        Me.PCSPGroupBox.Controls.Add(Me.QuantityLabel)
        Me.PCSPGroupBox.Controls.Add(Me.GrossProfitLabel)
        Me.PCSPGroupBox.Controls.Add(Me.StorageChargesLabel)
        Me.PCSPGroupBox.Controls.Add(Me.NetProfitLabel)
        Me.PCSPGroupBox.Controls.Add(Me.RetailPriceTextBox)
        Me.PCSPGroupBox.Controls.Add(Me.WholesaleCostTextBox)
        Me.PCSPGroupBox.Controls.Add(Me.QuantityTextBox)
        Me.PCSPGroupBox.Controls.Add(Me.GrossProfitTextBox)
        Me.PCSPGroupBox.Controls.Add(Me.StorageChargesTextBox)
        Me.PCSPGroupBox.Controls.Add(Me.NetProfitTextBox)
        Me.PCSPGroupBox.ForeColor = System.Drawing.SystemColors.Highlight
        Me.PCSPGroupBox.Location = New System.Drawing.Point(12, 141)
        Me.PCSPGroupBox.Name = "PCSPGroupBox"
        Me.PCSPGroupBox.Size = New System.Drawing.Size(415, 297)
        Me.PCSPGroupBox.TabIndex = 1
        Me.PCSPGroupBox.TabStop = False
        Me.PCSPGroupBox.Text = "Price, Cost, Storage, Profit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(18, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "R&etail Price:"
        '
        'WholesaleCostLabel
        '
        Me.WholesaleCostLabel.AutoSize = True
        Me.WholesaleCostLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.WholesaleCostLabel.Location = New System.Drawing.Point(18, 68)
        Me.WholesaleCostLabel.Name = "WholesaleCostLabel"
        Me.WholesaleCostLabel.Size = New System.Drawing.Size(114, 20)
        Me.WholesaleCostLabel.TabIndex = 5
        Me.WholesaleCostLabel.Text = "&Wholesale Cost:"
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.QuantityLabel.Location = New System.Drawing.Point(18, 112)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(68, 20)
        Me.QuantityLabel.TabIndex = 6
        Me.QuantityLabel.Text = "&Quantity:"
        '
        'GrossProfitLabel
        '
        Me.GrossProfitLabel.AutoSize = True
        Me.GrossProfitLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GrossProfitLabel.Location = New System.Drawing.Point(18, 155)
        Me.GrossProfitLabel.Name = "GrossProfitLabel"
        Me.GrossProfitLabel.Size = New System.Drawing.Size(88, 20)
        Me.GrossProfitLabel.TabIndex = 7
        Me.GrossProfitLabel.Text = "Gross Profit:"
        '
        'StorageChargesLabel
        '
        Me.StorageChargesLabel.AutoSize = True
        Me.StorageChargesLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.StorageChargesLabel.Location = New System.Drawing.Point(18, 201)
        Me.StorageChargesLabel.Name = "StorageChargesLabel"
        Me.StorageChargesLabel.Size = New System.Drawing.Size(121, 20)
        Me.StorageChargesLabel.TabIndex = 8
        Me.StorageChargesLabel.Text = "Storage Charges:"
        '
        'NetProfitLabel
        '
        Me.NetProfitLabel.AutoSize = True
        Me.NetProfitLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NetProfitLabel.Location = New System.Drawing.Point(18, 246)
        Me.NetProfitLabel.Name = "NetProfitLabel"
        Me.NetProfitLabel.Size = New System.Drawing.Size(76, 20)
        Me.NetProfitLabel.TabIndex = 9
        Me.NetProfitLabel.Text = "Net Profit:"
        '
        'RetailPriceTextBox
        '
        Me.RetailPriceTextBox.Location = New System.Drawing.Point(214, 26)
        Me.RetailPriceTextBox.Name = "RetailPriceTextBox"
        Me.RetailPriceTextBox.Size = New System.Drawing.Size(195, 27)
        Me.RetailPriceTextBox.TabIndex = 2
        Me.RetailPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RPFEToolTip.SetToolTip(Me.RetailPriceTextBox, "Retail Cost of Part")
        '
        'WholesaleCostTextBox
        '
        Me.WholesaleCostTextBox.Location = New System.Drawing.Point(214, 68)
        Me.WholesaleCostTextBox.Name = "WholesaleCostTextBox"
        Me.WholesaleCostTextBox.Size = New System.Drawing.Size(195, 27)
        Me.WholesaleCostTextBox.TabIndex = 3
        Me.WholesaleCostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RPFEToolTip.SetToolTip(Me.WholesaleCostTextBox, "Wholesale Cost of Part")
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(302, 112)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(107, 27)
        Me.QuantityTextBox.TabIndex = 4
        Me.QuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.RPFEToolTip.SetToolTip(Me.QuantityTextBox, "Quantity of Part")
        '
        'GrossProfitTextBox
        '
        Me.GrossProfitTextBox.Location = New System.Drawing.Point(214, 155)
        Me.GrossProfitTextBox.Name = "GrossProfitTextBox"
        Me.GrossProfitTextBox.ReadOnly = True
        Me.GrossProfitTextBox.Size = New System.Drawing.Size(195, 27)
        Me.GrossProfitTextBox.TabIndex = 5
        Me.GrossProfitTextBox.TabStop = False
        Me.GrossProfitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'StorageChargesTextBox
        '
        Me.StorageChargesTextBox.Location = New System.Drawing.Point(214, 201)
        Me.StorageChargesTextBox.Name = "StorageChargesTextBox"
        Me.StorageChargesTextBox.ReadOnly = True
        Me.StorageChargesTextBox.Size = New System.Drawing.Size(195, 27)
        Me.StorageChargesTextBox.TabIndex = 6
        Me.StorageChargesTextBox.TabStop = False
        Me.StorageChargesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NetProfitTextBox
        '
        Me.NetProfitTextBox.Location = New System.Drawing.Point(214, 246)
        Me.NetProfitTextBox.Name = "NetProfitTextBox"
        Me.NetProfitTextBox.ReadOnly = True
        Me.NetProfitTextBox.Size = New System.Drawing.Size(195, 27)
        Me.NetProfitTextBox.TabIndex = 7
        Me.NetProfitTextBox.TabStop = False
        Me.NetProfitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ComputeButton
        '
        Me.ComputeButton.Location = New System.Drawing.Point(485, 152)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(106, 57)
        Me.ComputeButton.TabIndex = 2
        Me.ComputeButton.Text = "&Compute"
        Me.ComputeButton.UseVisualStyleBackColor = True
        '
        'ResetFormButton
        '
        Me.ResetFormButton.Enabled = False
        Me.ResetFormButton.Location = New System.Drawing.Point(485, 215)
        Me.ResetFormButton.Name = "ResetFormButton"
        Me.ResetFormButton.Size = New System.Drawing.Size(106, 65)
        Me.ResetFormButton.TabIndex = 3
        Me.ResetFormButton.Text = "&Reset Form"
        Me.ResetFormButton.UseVisualStyleBackColor = True
        '
        'TotalNetProfitButton
        '
        Me.TotalNetProfitButton.Location = New System.Drawing.Point(485, 286)
        Me.TotalNetProfitButton.Name = "TotalNetProfitButton"
        Me.TotalNetProfitButton.Size = New System.Drawing.Size(106, 72)
        Me.TotalNetProfitButton.TabIndex = 4
        Me.TotalNetProfitButton.Text = "&Total Net Profit"
        Me.TotalNetProfitButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(485, 364)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(106, 63)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'RPFEForm
        '
        Me.AcceptButton = Me.ComputeButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ResetFormButton
        Me.ClientSize = New System.Drawing.Size(650, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.TotalNetProfitButton)
        Me.Controls.Add(Me.ResetFormButton)
        Me.Controls.Add(Me.ComputeButton)
        Me.Controls.Add(Me.PCSPGroupBox)
        Me.Controls.Add(Me.PartInformationGroupBox)
        Me.Name = "RPFEForm"
        Me.Text = "Repair Part Form Estimator"
        Me.PartInformationGroupBox.ResumeLayout(False)
        Me.PartInformationGroupBox.PerformLayout()
        Me.PCSPGroupBox.ResumeLayout(False)
        Me.PCSPGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PartInformationGroupBox As GroupBox
    Friend WithEvents PCSPGroupBox As GroupBox
    Friend WithEvents PartIdentifierLabel As Label
    Friend WithEvents PartDescriptionTextBox As TextBox
    Friend WithEvents PartIdentifierTextBox As TextBox
    Friend WithEvents RetailPriceTextBox As TextBox
    Friend WithEvents WholesaleCostTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents GrossProfitTextBox As TextBox
    Friend WithEvents StorageChargesTextBox As TextBox
    Friend WithEvents NetProfitTextBox As TextBox
    Friend WithEvents ComputeButton As Button
    Friend WithEvents ResetFormButton As Button
    Friend WithEvents TotalNetProfitButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents PartDescriptionLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents WholesaleCostLabel As Label
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents GrossProfitLabel As Label
    Friend WithEvents StorageChargesLabel As Label
    Friend WithEvents NetProfitLabel As Label
    Friend WithEvents RPFEToolTip As ToolTip
End Class
