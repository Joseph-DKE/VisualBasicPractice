<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookStoreForm
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
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.TotalsButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.TextbookSaleInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.TotalDueTextBox = New System.Windows.Forms.TextBox()
        Me.SalesTaxTextBox = New System.Windows.Forms.TextBox()
        Me.SubtotalTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.PriceMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ISBNMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BookTitleTextBox = New System.Windows.Forms.TextBox()
        Me.TotalDueLabel = New System.Windows.Forms.Label()
        Me.SalesTaxLabel = New System.Windows.Forms.Label()
        Me.SubtotalLabel = New System.Windows.Forms.Label()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.ISBNLabel = New System.Windows.Forms.Label()
        Me.BookTitleLabel = New System.Windows.Forms.Label()
        Me.TextbookSaleInformationGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComputeButton
        '
        Me.ComputeButton.BackColor = System.Drawing.Color.LightSalmon
        Me.ComputeButton.Location = New System.Drawing.Point(56, 339)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(146, 70)
        Me.ComputeButton.TabIndex = 8
        Me.ComputeButton.Text = "Compute"
        Me.ComputeButton.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.LightSalmon
        Me.ResetButton.Location = New System.Drawing.Point(238, 339)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(141, 70)
        Me.ResetButton.TabIndex = 9
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'TotalsButton
        '
        Me.TotalsButton.BackColor = System.Drawing.Color.LightSalmon
        Me.TotalsButton.Location = New System.Drawing.Point(413, 339)
        Me.TotalsButton.Name = "TotalsButton"
        Me.TotalsButton.Size = New System.Drawing.Size(142, 70)
        Me.TotalsButton.TabIndex = 10
        Me.TotalsButton.Text = "Totals"
        Me.TotalsButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.LightSalmon
        Me.ExitButton.Location = New System.Drawing.Point(587, 339)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(138, 70)
        Me.ExitButton.TabIndex = 11
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'TextbookSaleInformationGroupBox
        '
        Me.TextbookSaleInformationGroupBox.BackColor = System.Drawing.Color.Bisque
        Me.TextbookSaleInformationGroupBox.Controls.Add(Me.TotalDueTextBox)
        Me.TextbookSaleInformationGroupBox.Controls.Add(Me.SalesTaxTextBox)
        Me.TextbookSaleInformationGroupBox.Controls.Add(Me.SubtotalTextBox)
        Me.TextbookSaleInformationGroupBox.Controls.Add(Me.QuantityTextBox)
        Me.TextbookSaleInformationGroupBox.Controls.Add(Me.PriceMaskedTextBox)
        Me.TextbookSaleInformationGroupBox.Controls.Add(Me.ISBNMaskedTextBox)
        Me.TextbookSaleInformationGroupBox.Controls.Add(Me.BookTitleTextBox)
        Me.TextbookSaleInformationGroupBox.Controls.Add(Me.TotalDueLabel)
        Me.TextbookSaleInformationGroupBox.Controls.Add(Me.SalesTaxLabel)
        Me.TextbookSaleInformationGroupBox.Controls.Add(Me.SubtotalLabel)
        Me.TextbookSaleInformationGroupBox.Controls.Add(Me.QuantityLabel)
        Me.TextbookSaleInformationGroupBox.Controls.Add(Me.PriceLabel)
        Me.TextbookSaleInformationGroupBox.Controls.Add(Me.ISBNLabel)
        Me.TextbookSaleInformationGroupBox.Controls.Add(Me.BookTitleLabel)
        Me.TextbookSaleInformationGroupBox.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TextbookSaleInformationGroupBox.Location = New System.Drawing.Point(21, 27)
        Me.TextbookSaleInformationGroupBox.Name = "TextbookSaleInformationGroupBox"
        Me.TextbookSaleInformationGroupBox.Size = New System.Drawing.Size(750, 296)
        Me.TextbookSaleInformationGroupBox.TabIndex = 0
        Me.TextbookSaleInformationGroupBox.TabStop = False
        Me.TextbookSaleInformationGroupBox.Text = "Textbook Sale Information"
        '
        'TotalDueTextBox
        '
        Me.TotalDueTextBox.Location = New System.Drawing.Point(217, 252)
        Me.TotalDueTextBox.Name = "TotalDueTextBox"
        Me.TotalDueTextBox.ReadOnly = True
        Me.TotalDueTextBox.Size = New System.Drawing.Size(125, 27)
        Me.TotalDueTextBox.TabIndex = 7
        '
        'SalesTaxTextBox
        '
        Me.SalesTaxTextBox.Location = New System.Drawing.Point(217, 212)
        Me.SalesTaxTextBox.Name = "SalesTaxTextBox"
        Me.SalesTaxTextBox.ReadOnly = True
        Me.SalesTaxTextBox.Size = New System.Drawing.Size(125, 27)
        Me.SalesTaxTextBox.TabIndex = 6
        '
        'SubtotalTextBox
        '
        Me.SubtotalTextBox.Location = New System.Drawing.Point(217, 172)
        Me.SubtotalTextBox.Name = "SubtotalTextBox"
        Me.SubtotalTextBox.ReadOnly = True
        Me.SubtotalTextBox.Size = New System.Drawing.Size(125, 27)
        Me.SubtotalTextBox.TabIndex = 5
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(217, 134)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(125, 27)
        Me.QuantityTextBox.TabIndex = 4
        '
        'PriceMaskedTextBox
        '
        Me.PriceMaskedTextBox.Location = New System.Drawing.Point(217, 96)
        Me.PriceMaskedTextBox.Name = "PriceMaskedTextBox"
        Me.PriceMaskedTextBox.Size = New System.Drawing.Size(125, 27)
        Me.PriceMaskedTextBox.TabIndex = 3
        '
        'ISBNMaskedTextBox
        '
        Me.ISBNMaskedTextBox.Location = New System.Drawing.Point(217, 59)
        Me.ISBNMaskedTextBox.Name = "ISBNMaskedTextBox"
        Me.ISBNMaskedTextBox.Size = New System.Drawing.Size(304, 27)
        Me.ISBNMaskedTextBox.TabIndex = 2
        '
        'BookTitleTextBox
        '
        Me.BookTitleTextBox.Location = New System.Drawing.Point(217, 20)
        Me.BookTitleTextBox.Name = "BookTitleTextBox"
        Me.BookTitleTextBox.Size = New System.Drawing.Size(512, 27)
        Me.BookTitleTextBox.TabIndex = 1
        '
        'TotalDueLabel
        '
        Me.TotalDueLabel.AutoSize = True
        Me.TotalDueLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TotalDueLabel.Location = New System.Drawing.Point(17, 255)
        Me.TotalDueLabel.Name = "TotalDueLabel"
        Me.TotalDueLabel.Size = New System.Drawing.Size(76, 20)
        Me.TotalDueLabel.TabIndex = 6
        Me.TotalDueLabel.Text = "Total Due:"
        '
        'SalesTaxLabel
        '
        Me.SalesTaxLabel.AutoSize = True
        Me.SalesTaxLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SalesTaxLabel.Location = New System.Drawing.Point(17, 215)
        Me.SalesTaxLabel.Name = "SalesTaxLabel"
        Me.SalesTaxLabel.Size = New System.Drawing.Size(71, 20)
        Me.SalesTaxLabel.TabIndex = 5
        Me.SalesTaxLabel.Text = "Sales Tax:"
        '
        'SubtotalLabel
        '
        Me.SubtotalLabel.AutoSize = True
        Me.SubtotalLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SubtotalLabel.Location = New System.Drawing.Point(17, 175)
        Me.SubtotalLabel.Name = "SubtotalLabel"
        Me.SubtotalLabel.Size = New System.Drawing.Size(68, 20)
        Me.SubtotalLabel.TabIndex = 4
        Me.SubtotalLabel.Text = "Subtotal:"
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.QuantityLabel.Location = New System.Drawing.Point(17, 137)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(68, 20)
        Me.QuantityLabel.TabIndex = 3
        Me.QuantityLabel.Text = "Quantity:"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PriceLabel.Location = New System.Drawing.Point(17, 99)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(44, 20)
        Me.PriceLabel.TabIndex = 2
        Me.PriceLabel.Text = "Price:"
        '
        'ISBNLabel
        '
        Me.ISBNLabel.AutoSize = True
        Me.ISBNLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ISBNLabel.Location = New System.Drawing.Point(17, 62)
        Me.ISBNLabel.Name = "ISBNLabel"
        Me.ISBNLabel.Size = New System.Drawing.Size(118, 20)
        Me.ISBNLabel.TabIndex = 1
        Me.ISBNLabel.Text = "ISBN (Identifier):"
        '
        'BookTitleLabel
        '
        Me.BookTitleLabel.AutoSize = True
        Me.BookTitleLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BookTitleLabel.Location = New System.Drawing.Point(17, 23)
        Me.BookTitleLabel.Name = "BookTitleLabel"
        Me.BookTitleLabel.Size = New System.Drawing.Size(79, 20)
        Me.BookTitleLabel.TabIndex = 0
        Me.BookTitleLabel.Text = "Book Title:"
        '
        'BookStoreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextbookSaleInformationGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.TotalsButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.ComputeButton)
        Me.Name = "BookStoreForm"
        Me.Text = "VB University - Book Store"
        Me.TextbookSaleInformationGroupBox.ResumeLayout(False)
        Me.TextbookSaleInformationGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComputeButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents TotalsButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents TextbookSaleInformationGroupBox As GroupBox
    Friend WithEvents PriceMaskedTextBox As MaskedTextBox
    Friend WithEvents ISBNMaskedTextBox As MaskedTextBox
    Friend WithEvents BookTitleTextBox As TextBox
    Friend WithEvents TotalDueLabel As Label
    Friend WithEvents SalesTaxLabel As Label
    Friend WithEvents SubtotalLabel As Label
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents PriceLabel As Label
    Friend WithEvents ISBNLabel As Label
    Friend WithEvents BookTitleLabel As Label
    Friend WithEvents TotalDueTextBox As TextBox
    Friend WithEvents SalesTaxTextBox As TextBox
    Friend WithEvents SubtotalTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
End Class
