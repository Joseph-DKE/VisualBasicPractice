<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VBAutoCenterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VBAutoCenterForm))
        Me.AutoSalesButton = New System.Windows.Forms.Button()
        Me.DetailShopButton = New System.Windows.Forms.Button()
        Me.ServiceCenterButton = New System.Windows.Forms.Button()
        Me.EmploymentOpportunitiesButton = New System.Windows.Forms.Button()
        Me.InformationLabel = New System.Windows.Forms.Label()
        Me.InformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.InformationGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'AutoSalesButton
        '
        Me.AutoSalesButton.BackColor = System.Drawing.Color.Ivory
        Me.AutoSalesButton.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AutoSalesButton.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.AutoSalesButton.Location = New System.Drawing.Point(570, 71)
        Me.AutoSalesButton.Name = "AutoSalesButton"
        Me.AutoSalesButton.Size = New System.Drawing.Size(218, 69)
        Me.AutoSalesButton.TabIndex = 0
        Me.AutoSalesButton.Text = "Auto Sales"
        Me.AutoSalesButton.UseVisualStyleBackColor = False
        '
        'DetailShopButton
        '
        Me.DetailShopButton.BackColor = System.Drawing.Color.Ivory
        Me.DetailShopButton.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DetailShopButton.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.DetailShopButton.Location = New System.Drawing.Point(12, 304)
        Me.DetailShopButton.Name = "DetailShopButton"
        Me.DetailShopButton.Size = New System.Drawing.Size(218, 69)
        Me.DetailShopButton.TabIndex = 1
        Me.DetailShopButton.Text = "Detail Shop"
        Me.DetailShopButton.UseVisualStyleBackColor = False
        '
        'ServiceCenterButton
        '
        Me.ServiceCenterButton.BackColor = System.Drawing.Color.Ivory
        Me.ServiceCenterButton.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ServiceCenterButton.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.ServiceCenterButton.Location = New System.Drawing.Point(570, 304)
        Me.ServiceCenterButton.Name = "ServiceCenterButton"
        Me.ServiceCenterButton.Size = New System.Drawing.Size(218, 69)
        Me.ServiceCenterButton.TabIndex = 2
        Me.ServiceCenterButton.Text = "Service Center"
        Me.ServiceCenterButton.UseVisualStyleBackColor = False
        '
        'EmploymentOpportunitiesButton
        '
        Me.EmploymentOpportunitiesButton.BackColor = System.Drawing.Color.Ivory
        Me.EmploymentOpportunitiesButton.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EmploymentOpportunitiesButton.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.EmploymentOpportunitiesButton.Location = New System.Drawing.Point(12, 71)
        Me.EmploymentOpportunitiesButton.Name = "EmploymentOpportunitiesButton"
        Me.EmploymentOpportunitiesButton.Size = New System.Drawing.Size(218, 69)
        Me.EmploymentOpportunitiesButton.TabIndex = 3
        Me.EmploymentOpportunitiesButton.Text = "Employment Opportunities"
        Me.EmploymentOpportunitiesButton.UseVisualStyleBackColor = False
        '
        'InformationLabel
        '
        Me.InformationLabel.AutoSize = True
        Me.InformationLabel.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.InformationLabel.Location = New System.Drawing.Point(22, 38)
        Me.InformationLabel.Name = "InformationLabel"
        Me.InformationLabel.Size = New System.Drawing.Size(0, 38)
        Me.InformationLabel.TabIndex = 4
        '
        'InformationGroupBox
        '
        Me.InformationGroupBox.BackColor = System.Drawing.Color.LightCyan
        Me.InformationGroupBox.Controls.Add(Me.InformationLabel)
        Me.InformationGroupBox.Location = New System.Drawing.Point(249, 71)
        Me.InformationGroupBox.Name = "InformationGroupBox"
        Me.InformationGroupBox.Size = New System.Drawing.Size(301, 302)
        Me.InformationGroupBox.TabIndex = 5
        Me.InformationGroupBox.TabStop = False
        Me.InformationGroupBox.Text = "Information"
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Azure
        Me.ExitButton.Location = New System.Drawing.Point(50, 170)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(140, 100)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.Color.Azure
        Me.PrintButton.Location = New System.Drawing.Point(610, 170)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(140, 100)
        Me.PrintButton.TabIndex = 7
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = False
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
        'PrintDocument1
        '
        '
        'VBAutoCenterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.InformationGroupBox)
        Me.Controls.Add(Me.EmploymentOpportunitiesButton)
        Me.Controls.Add(Me.ServiceCenterButton)
        Me.Controls.Add(Me.DetailShopButton)
        Me.Controls.Add(Me.AutoSalesButton)
        Me.Name = "VBAutoCenterForm"
        Me.Text = "Form1"
        Me.InformationGroupBox.ResumeLayout(False)
        Me.InformationGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AutoSalesButton As Button
    Friend WithEvents DetailShopButton As Button
    Friend WithEvents ServiceCenterButton As Button
    Friend WithEvents EmploymentOpportunitiesButton As Button
    Friend WithEvents InformationLabel As Label
    Friend WithEvents InformationGroupBox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
