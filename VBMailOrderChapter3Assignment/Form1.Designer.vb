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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.TotalHoursWorkedTextBox = New System.Windows.Forms.TextBox()
        Me.BonusEarnedTextBox = New System.Windows.Forms.TextBox()
        Me.StoreTotalSaleTextBox = New System.Windows.Forms.TextBox()
        Me.InformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.BonusEarnedLabel = New System.Windows.Forms.Label()
        Me.StoreTotalSaleLabel = New System.Windows.Forms.Label()
        Me.TotalHoursWorkedLabel = New System.Windows.Forms.Label()
        Me.EmployeeNameLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.InformationGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(198, 42)
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(350, 27)
        Me.EmployeeNameTextBox.TabIndex = 0
        '
        'TotalHoursWorkedTextBox
        '
        Me.TotalHoursWorkedTextBox.Location = New System.Drawing.Point(198, 116)
        Me.TotalHoursWorkedTextBox.Name = "TotalHoursWorkedTextBox"
        Me.TotalHoursWorkedTextBox.Size = New System.Drawing.Size(143, 27)
        Me.TotalHoursWorkedTextBox.TabIndex = 1
        '
        'BonusEarnedTextBox
        '
        Me.BonusEarnedTextBox.Location = New System.Drawing.Point(198, 257)
        Me.BonusEarnedTextBox.Name = "BonusEarnedTextBox"
        Me.BonusEarnedTextBox.ReadOnly = True
        Me.BonusEarnedTextBox.Size = New System.Drawing.Size(143, 27)
        Me.BonusEarnedTextBox.TabIndex = 3
        '
        'StoreTotalSaleTextBox
        '
        Me.StoreTotalSaleTextBox.Location = New System.Drawing.Point(198, 189)
        Me.StoreTotalSaleTextBox.Name = "StoreTotalSaleTextBox"
        Me.StoreTotalSaleTextBox.Size = New System.Drawing.Size(143, 27)
        Me.StoreTotalSaleTextBox.TabIndex = 2
        '
        'InformationGroupBox
        '
        Me.InformationGroupBox.BackColor = System.Drawing.SystemColors.Info
        Me.InformationGroupBox.Controls.Add(Me.BonusEarnedLabel)
        Me.InformationGroupBox.Controls.Add(Me.StoreTotalSaleLabel)
        Me.InformationGroupBox.Controls.Add(Me.TotalHoursWorkedLabel)
        Me.InformationGroupBox.Controls.Add(Me.EmployeeNameLabel)
        Me.InformationGroupBox.Controls.Add(Me.EmployeeNameTextBox)
        Me.InformationGroupBox.Controls.Add(Me.BonusEarnedTextBox)
        Me.InformationGroupBox.Controls.Add(Me.StoreTotalSaleTextBox)
        Me.InformationGroupBox.Controls.Add(Me.TotalHoursWorkedTextBox)
        Me.InformationGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.InformationGroupBox.Name = "InformationGroupBox"
        Me.InformationGroupBox.Size = New System.Drawing.Size(776, 326)
        Me.InformationGroupBox.TabIndex = 4
        Me.InformationGroupBox.TabStop = False
        Me.InformationGroupBox.Text = "Information"
        '
        'BonusEarnedLabel
        '
        Me.BonusEarnedLabel.AutoSize = True
        Me.BonusEarnedLabel.Location = New System.Drawing.Point(26, 257)
        Me.BonusEarnedLabel.Name = "BonusEarnedLabel"
        Me.BonusEarnedLabel.Size = New System.Drawing.Size(102, 20)
        Me.BonusEarnedLabel.TabIndex = 8
        Me.BonusEarnedLabel.Text = "Bonus Earned:"
        '
        'StoreTotalSaleLabel
        '
        Me.StoreTotalSaleLabel.AutoSize = True
        Me.StoreTotalSaleLabel.Location = New System.Drawing.Point(26, 189)
        Me.StoreTotalSaleLabel.Name = "StoreTotalSaleLabel"
        Me.StoreTotalSaleLabel.Size = New System.Drawing.Size(116, 20)
        Me.StoreTotalSaleLabel.TabIndex = 7
        Me.StoreTotalSaleLabel.Text = "Store Total Sale:"
        '
        'TotalHoursWorkedLabel
        '
        Me.TotalHoursWorkedLabel.AutoSize = True
        Me.TotalHoursWorkedLabel.Location = New System.Drawing.Point(26, 116)
        Me.TotalHoursWorkedLabel.Name = "TotalHoursWorkedLabel"
        Me.TotalHoursWorkedLabel.Size = New System.Drawing.Size(143, 20)
        Me.TotalHoursWorkedLabel.TabIndex = 6
        Me.TotalHoursWorkedLabel.Text = "Total Hours Worked:"
        '
        'EmployeeNameLabel
        '
        Me.EmployeeNameLabel.AutoSize = True
        Me.EmployeeNameLabel.Location = New System.Drawing.Point(26, 45)
        Me.EmployeeNameLabel.Name = "EmployeeNameLabel"
        Me.EmployeeNameLabel.Size = New System.Drawing.Size(122, 20)
        Me.EmployeeNameLabel.TabIndex = 5
        Me.EmployeeNameLabel.Text = "Employee Name:"
        '
        'CalculateButton
        '
        Me.CalculateButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.CalculateButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CalculateButton.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.CalculateButton.Location = New System.Drawing.Point(38, 356)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(131, 65)
        Me.CalculateButton.TabIndex = 9
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ClearButton.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ClearButton.Location = New System.Drawing.Point(232, 356)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(131, 65)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "C&lear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.PrintButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PrintButton.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.PrintButton.Location = New System.Drawing.Point(429, 356)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(131, 65)
        Me.PrintButton.TabIndex = 11
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ControlText
        Me.ExitButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ExitButton.Location = New System.Drawing.Point(622, 356)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(131, 65)
        Me.ExitButton.TabIndex = 12
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = False
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.InformationGroupBox)
        Me.Name = "Form1"
        Me.Text = "VBMailOrder"
        Me.InformationGroupBox.ResumeLayout(False)
        Me.InformationGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EmployeeNameTextBox As TextBox
    Friend WithEvents TotalHoursWorkedTextBox As TextBox
    Friend WithEvents BonusEarnedTextBox As TextBox
    Friend WithEvents StoreTotalSaleTextBox As TextBox
    Friend WithEvents InformationGroupBox As GroupBox
    Friend WithEvents BonusEarnedLabel As Label
    Friend WithEvents StoreTotalSaleLabel As Label
    Friend WithEvents TotalHoursWorkedLabel As Label
    Friend WithEvents EmployeeNameLabel As Label
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
