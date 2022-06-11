<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoCenterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AutoCenterForm))
        Me.SalesPersonNameTextBox = New System.Windows.Forms.TextBox()
        Me.CostPriceTextBox = New System.Windows.Forms.TextBox()
        Me.SellingPriceTextBox = New System.Windows.Forms.TextBox()
        Me.CommissionTextBox = New System.Windows.Forms.TextBox()
        Me.InformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.CommissionLabel = New System.Windows.Forms.Label()
        Me.SalesPersonNameLabel = New System.Windows.Forms.Label()
        Me.SellingPriceLabel = New System.Windows.Forms.Label()
        Me.CostPriceLabel = New System.Windows.Forms.Label()
        Me.ButtoneGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.InformationGroupBox.SuspendLayout()
        Me.ButtoneGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SalesPersonNameTextBox
        '
        Me.SalesPersonNameTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.SalesPersonNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SalesPersonNameTextBox.Location = New System.Drawing.Point(217, 43)
        Me.SalesPersonNameTextBox.Name = "SalesPersonNameTextBox"
        Me.SalesPersonNameTextBox.Size = New System.Drawing.Size(227, 27)
        Me.SalesPersonNameTextBox.TabIndex = 0
        '
        'CostPriceTextBox
        '
        Me.CostPriceTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.CostPriceTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CostPriceTextBox.Location = New System.Drawing.Point(217, 96)
        Me.CostPriceTextBox.Name = "CostPriceTextBox"
        Me.CostPriceTextBox.Size = New System.Drawing.Size(227, 27)
        Me.CostPriceTextBox.TabIndex = 1
        '
        'SellingPriceTextBox
        '
        Me.SellingPriceTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.SellingPriceTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SellingPriceTextBox.Location = New System.Drawing.Point(217, 149)
        Me.SellingPriceTextBox.Name = "SellingPriceTextBox"
        Me.SellingPriceTextBox.Size = New System.Drawing.Size(227, 27)
        Me.SellingPriceTextBox.TabIndex = 2
        '
        'CommissionTextBox
        '
        Me.CommissionTextBox.BackColor = System.Drawing.SystemColors.Info
        Me.CommissionTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CommissionTextBox.Location = New System.Drawing.Point(217, 210)
        Me.CommissionTextBox.Name = "CommissionTextBox"
        Me.CommissionTextBox.ReadOnly = True
        Me.CommissionTextBox.Size = New System.Drawing.Size(227, 27)
        Me.CommissionTextBox.TabIndex = 3
        '
        'InformationGroupBox
        '
        Me.InformationGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.InformationGroupBox.Controls.Add(Me.CommissionLabel)
        Me.InformationGroupBox.Controls.Add(Me.SalesPersonNameLabel)
        Me.InformationGroupBox.Controls.Add(Me.SellingPriceLabel)
        Me.InformationGroupBox.Controls.Add(Me.SalesPersonNameTextBox)
        Me.InformationGroupBox.Controls.Add(Me.CostPriceLabel)
        Me.InformationGroupBox.Controls.Add(Me.CostPriceTextBox)
        Me.InformationGroupBox.Controls.Add(Me.SellingPriceTextBox)
        Me.InformationGroupBox.Controls.Add(Me.CommissionTextBox)
        Me.InformationGroupBox.Location = New System.Drawing.Point(150, 21)
        Me.InformationGroupBox.Name = "InformationGroupBox"
        Me.InformationGroupBox.Size = New System.Drawing.Size(486, 271)
        Me.InformationGroupBox.TabIndex = 4
        Me.InformationGroupBox.TabStop = False
        Me.InformationGroupBox.Text = "Information"
        '
        'CommissionLabel
        '
        Me.CommissionLabel.AutoSize = True
        Me.CommissionLabel.Location = New System.Drawing.Point(30, 210)
        Me.CommissionLabel.Name = "CommissionLabel"
        Me.CommissionLabel.Size = New System.Drawing.Size(93, 20)
        Me.CommissionLabel.TabIndex = 13
        Me.CommissionLabel.Text = "Commission:"
        '
        'SalesPersonNameLabel
        '
        Me.SalesPersonNameLabel.AutoSize = True
        Me.SalesPersonNameLabel.Location = New System.Drawing.Point(30, 43)
        Me.SalesPersonNameLabel.Name = "SalesPersonNameLabel"
        Me.SalesPersonNameLabel.Size = New System.Drawing.Size(137, 20)
        Me.SalesPersonNameLabel.TabIndex = 10
        Me.SalesPersonNameLabel.Text = "Sales Person Name:"
        '
        'SellingPriceLabel
        '
        Me.SellingPriceLabel.AutoSize = True
        Me.SellingPriceLabel.Location = New System.Drawing.Point(30, 149)
        Me.SellingPriceLabel.Name = "SellingPriceLabel"
        Me.SellingPriceLabel.Size = New System.Drawing.Size(93, 20)
        Me.SellingPriceLabel.TabIndex = 12
        Me.SellingPriceLabel.Text = "Selling Price:"
        '
        'CostPriceLabel
        '
        Me.CostPriceLabel.AutoSize = True
        Me.CostPriceLabel.Location = New System.Drawing.Point(30, 96)
        Me.CostPriceLabel.Name = "CostPriceLabel"
        Me.CostPriceLabel.Size = New System.Drawing.Size(77, 20)
        Me.CostPriceLabel.TabIndex = 11
        Me.CostPriceLabel.Text = "Cost Price:"
        '
        'ButtoneGroupBox
        '
        Me.ButtoneGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ButtoneGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtoneGroupBox.Controls.Add(Me.CalculateButton)
        Me.ButtoneGroupBox.Controls.Add(Me.PrintButton)
        Me.ButtoneGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtoneGroupBox.Location = New System.Drawing.Point(18, 313)
        Me.ButtoneGroupBox.Name = "ButtoneGroupBox"
        Me.ButtoneGroupBox.Size = New System.Drawing.Size(756, 125)
        Me.ButtoneGroupBox.TabIndex = 5
        Me.ButtoneGroupBox.TabStop = False
        Me.ButtoneGroupBox.Text = "Buttons"
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.LightSalmon
        Me.ExitButton.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.Location = New System.Drawing.Point(606, 26)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(129, 93)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'CalculateButton
        '
        Me.CalculateButton.BackColor = System.Drawing.Color.LightSalmon
        Me.CalculateButton.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CalculateButton.Location = New System.Drawing.Point(21, 26)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(129, 93)
        Me.CalculateButton.TabIndex = 6
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = False
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.Color.LightSalmon
        Me.PrintButton.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PrintButton.Location = New System.Drawing.Point(217, 26)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(129, 93)
        Me.PrintButton.TabIndex = 7
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.LightSalmon
        Me.ClearButton.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ClearButton.Location = New System.Drawing.Point(412, 26)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(129, 93)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
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
        'AutoCenterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.InformationGroupBox)
        Me.Controls.Add(Me.ButtoneGroupBox)
        Me.Name = "AutoCenterForm"
        Me.Text = "Auto Center"
        Me.InformationGroupBox.ResumeLayout(False)
        Me.InformationGroupBox.PerformLayout()
        Me.ButtoneGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SalesPersonNameTextBox As TextBox
    Friend WithEvents CostPriceTextBox As TextBox
    Friend WithEvents SellingPriceTextBox As TextBox
    Friend WithEvents CommissionTextBox As TextBox
    Friend WithEvents InformationGroupBox As GroupBox
    Friend WithEvents CommissionLabel As Label
    Friend WithEvents SalesPersonNameLabel As Label
    Friend WithEvents SellingPriceLabel As Label
    Friend WithEvents CostPriceLabel As Label
    Friend WithEvents ButtoneGroupBox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents CalculateButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
