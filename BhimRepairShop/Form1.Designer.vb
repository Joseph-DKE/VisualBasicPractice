<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BockRepairPartsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BockRepairPartsForm))
        Me.CustomerNameLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.TelephoneLabel = New System.Windows.Forms.Label()
        Me.CityTownLabel = New System.Windows.Forms.Label()
        Me.RegionLabel = New System.Windows.Forms.Label()
        Me.VehicleInfoLabel = New System.Windows.Forms.Label()
        Me.CustomerInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.TelephoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.RegionTextBox = New System.Windows.Forms.TextBox()
        Me.CityTownTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.VehicelTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.CommercialRadioButton = New System.Windows.Forms.RadioButton()
        Me.TruckRadioButton = New System.Windows.Forms.RadioButton()
        Me.AutoRadioButton = New System.Windows.Forms.RadioButton()
        Me.SelectColorGroupBox = New System.Windows.Forms.GroupBox()
        Me.BlueRadioButton = New System.Windows.Forms.RadioButton()
        Me.GreenRadioButton = New System.Windows.Forms.RadioButton()
        Me.YellowRadioButton = New System.Windows.Forms.RadioButton()
        Me.GrayRadioButton = New System.Windows.Forms.RadioButton()
        Me.VehicleInfoTextBox = New System.Windows.Forms.TextBox()
        Me.DiaplayButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.VisibleCheckBox = New System.Windows.Forms.CheckBox()
        Me.DisplayTextBox = New System.Windows.Forms.TextBox()
        Me.AutoVehiclePictureBox = New System.Windows.Forms.PictureBox()
        Me.CommercialVehiclePictureBox = New System.Windows.Forms.PictureBox()
        Me.TruckPictureBox = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.FormToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.CustomerInformationGroupBox.SuspendLayout()
        Me.VehicelTypeGroupBox.SuspendLayout()
        Me.SelectColorGroupBox.SuspendLayout()
        CType(Me.AutoVehiclePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommercialVehiclePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TruckPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerNameLabel
        '
        Me.CustomerNameLabel.AutoSize = True
        Me.CustomerNameLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CustomerNameLabel.Location = New System.Drawing.Point(24, 35)
        Me.CustomerNameLabel.Name = "CustomerNameLabel"
        Me.CustomerNameLabel.Size = New System.Drawing.Size(139, 19)
        Me.CustomerNameLabel.TabIndex = 0
        Me.CustomerNameLabel.Text = "Customer Name:"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AddressLabel.Location = New System.Drawing.Point(24, 66)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(75, 19)
        Me.AddressLabel.TabIndex = 1
        Me.AddressLabel.Text = "Address:"
        '
        'TelephoneLabel
        '
        Me.TelephoneLabel.AutoSize = True
        Me.TelephoneLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TelephoneLabel.Location = New System.Drawing.Point(24, 98)
        Me.TelephoneLabel.Name = "TelephoneLabel"
        Me.TelephoneLabel.Size = New System.Drawing.Size(92, 19)
        Me.TelephoneLabel.TabIndex = 2
        Me.TelephoneLabel.Text = "Telephone:"
        '
        'CityTownLabel
        '
        Me.CityTownLabel.AutoSize = True
        Me.CityTownLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CityTownLabel.Location = New System.Drawing.Point(24, 130)
        Me.CityTownLabel.Name = "CityTownLabel"
        Me.CityTownLabel.Size = New System.Drawing.Size(93, 19)
        Me.CityTownLabel.TabIndex = 4
        Me.CityTownLabel.Text = "City/Town:"
        '
        'RegionLabel
        '
        Me.RegionLabel.AutoSize = True
        Me.RegionLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RegionLabel.Location = New System.Drawing.Point(24, 163)
        Me.RegionLabel.Name = "RegionLabel"
        Me.RegionLabel.Size = New System.Drawing.Size(59, 19)
        Me.RegionLabel.TabIndex = 7
        Me.RegionLabel.Text = "Region"
        '
        'VehicleInfoLabel
        '
        Me.VehicleInfoLabel.AutoSize = True
        Me.VehicleInfoLabel.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.VehicleInfoLabel.Location = New System.Drawing.Point(237, 250)
        Me.VehicleInfoLabel.Name = "VehicleInfoLabel"
        Me.VehicleInfoLabel.Size = New System.Drawing.Size(101, 19)
        Me.VehicleInfoLabel.TabIndex = 10
        Me.VehicleInfoLabel.Text = "Vehicle Info:"
        '
        'CustomerInformationGroupBox
        '
        Me.CustomerInformationGroupBox.Controls.Add(Me.TelephoneMaskedTextBox)
        Me.CustomerInformationGroupBox.Controls.Add(Me.RegionTextBox)
        Me.CustomerInformationGroupBox.Controls.Add(Me.CityTownTextBox)
        Me.CustomerInformationGroupBox.Controls.Add(Me.AddressTextBox)
        Me.CustomerInformationGroupBox.Controls.Add(Me.CustomerNameTextBox)
        Me.CustomerInformationGroupBox.Controls.Add(Me.CustomerNameLabel)
        Me.CustomerInformationGroupBox.Controls.Add(Me.AddressLabel)
        Me.CustomerInformationGroupBox.Controls.Add(Me.TelephoneLabel)
        Me.CustomerInformationGroupBox.Controls.Add(Me.CityTownLabel)
        Me.CustomerInformationGroupBox.Controls.Add(Me.RegionLabel)
        Me.CustomerInformationGroupBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CustomerInformationGroupBox.ForeColor = System.Drawing.SystemColors.Highlight
        Me.CustomerInformationGroupBox.Location = New System.Drawing.Point(7, 16)
        Me.CustomerInformationGroupBox.Name = "CustomerInformationGroupBox"
        Me.CustomerInformationGroupBox.Size = New System.Drawing.Size(546, 213)
        Me.CustomerInformationGroupBox.TabIndex = 0
        Me.CustomerInformationGroupBox.TabStop = False
        Me.CustomerInformationGroupBox.Text = "Customer Information"
        '
        'TelephoneMaskedTextBox
        '
        Me.TelephoneMaskedTextBox.Location = New System.Drawing.Point(194, 98)
        Me.TelephoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.TelephoneMaskedTextBox.Name = "TelephoneMaskedTextBox"
        Me.TelephoneMaskedTextBox.Size = New System.Drawing.Size(330, 26)
        Me.TelephoneMaskedTextBox.TabIndex = 3
        '
        'RegionTextBox
        '
        Me.RegionTextBox.Location = New System.Drawing.Point(194, 163)
        Me.RegionTextBox.Name = "RegionTextBox"
        Me.RegionTextBox.Size = New System.Drawing.Size(330, 26)
        Me.RegionTextBox.TabIndex = 5
        '
        'CityTownTextBox
        '
        Me.CityTownTextBox.Location = New System.Drawing.Point(194, 130)
        Me.CityTownTextBox.Name = "CityTownTextBox"
        Me.CityTownTextBox.Size = New System.Drawing.Size(330, 26)
        Me.CityTownTextBox.TabIndex = 4
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(194, 66)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(330, 26)
        Me.AddressTextBox.TabIndex = 2
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.CustomerNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(194, 35)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(330, 26)
        Me.CustomerNameTextBox.TabIndex = 1
        '
        'VehicelTypeGroupBox
        '
        Me.VehicelTypeGroupBox.Controls.Add(Me.CommercialRadioButton)
        Me.VehicelTypeGroupBox.Controls.Add(Me.TruckRadioButton)
        Me.VehicelTypeGroupBox.Controls.Add(Me.AutoRadioButton)
        Me.VehicelTypeGroupBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.VehicelTypeGroupBox.ForeColor = System.Drawing.SystemColors.Highlight
        Me.VehicelTypeGroupBox.Location = New System.Drawing.Point(559, 16)
        Me.VehicelTypeGroupBox.Name = "VehicelTypeGroupBox"
        Me.VehicelTypeGroupBox.Size = New System.Drawing.Size(168, 213)
        Me.VehicelTypeGroupBox.TabIndex = 6
        Me.VehicelTypeGroupBox.TabStop = False
        Me.VehicelTypeGroupBox.Text = "Vehicle Type"
        '
        'CommercialRadioButton
        '
        Me.CommercialRadioButton.AutoSize = True
        Me.CommercialRadioButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CommercialRadioButton.Location = New System.Drawing.Point(28, 150)
        Me.CommercialRadioButton.Name = "CommercialRadioButton"
        Me.CommercialRadioButton.Size = New System.Drawing.Size(119, 23)
        Me.CommercialRadioButton.TabIndex = 8
        Me.CommercialRadioButton.Text = "Commercial"
        Me.CommercialRadioButton.UseVisualStyleBackColor = True
        '
        'TruckRadioButton
        '
        Me.TruckRadioButton.AutoSize = True
        Me.TruckRadioButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TruckRadioButton.Location = New System.Drawing.Point(28, 101)
        Me.TruckRadioButton.Name = "TruckRadioButton"
        Me.TruckRadioButton.Size = New System.Drawing.Size(71, 23)
        Me.TruckRadioButton.TabIndex = 7
        Me.TruckRadioButton.Text = "Truck"
        Me.TruckRadioButton.UseVisualStyleBackColor = True
        '
        'AutoRadioButton
        '
        Me.AutoRadioButton.AutoSize = True
        Me.AutoRadioButton.Checked = True
        Me.AutoRadioButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AutoRadioButton.Location = New System.Drawing.Point(28, 51)
        Me.AutoRadioButton.Name = "AutoRadioButton"
        Me.AutoRadioButton.Size = New System.Drawing.Size(65, 23)
        Me.AutoRadioButton.TabIndex = 6
        Me.AutoRadioButton.TabStop = True
        Me.AutoRadioButton.Text = "Auto"
        Me.AutoRadioButton.UseVisualStyleBackColor = True
        '
        'SelectColorGroupBox
        '
        Me.SelectColorGroupBox.Controls.Add(Me.BlueRadioButton)
        Me.SelectColorGroupBox.Controls.Add(Me.GreenRadioButton)
        Me.SelectColorGroupBox.Controls.Add(Me.YellowRadioButton)
        Me.SelectColorGroupBox.Controls.Add(Me.GrayRadioButton)
        Me.SelectColorGroupBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SelectColorGroupBox.ForeColor = System.Drawing.SystemColors.Highlight
        Me.SelectColorGroupBox.Location = New System.Drawing.Point(734, 16)
        Me.SelectColorGroupBox.Name = "SelectColorGroupBox"
        Me.SelectColorGroupBox.Size = New System.Drawing.Size(161, 213)
        Me.SelectColorGroupBox.TabIndex = 7
        Me.SelectColorGroupBox.TabStop = False
        Me.SelectColorGroupBox.Text = "Select Color"
        '
        'BlueRadioButton
        '
        Me.BlueRadioButton.AutoSize = True
        Me.BlueRadioButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BlueRadioButton.Location = New System.Drawing.Point(45, 166)
        Me.BlueRadioButton.Name = "BlueRadioButton"
        Me.BlueRadioButton.Size = New System.Drawing.Size(61, 23)
        Me.BlueRadioButton.TabIndex = 12
        Me.BlueRadioButton.Text = "Blue"
        Me.BlueRadioButton.UseVisualStyleBackColor = True
        '
        'GreenRadioButton
        '
        Me.GreenRadioButton.AutoSize = True
        Me.GreenRadioButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GreenRadioButton.Location = New System.Drawing.Point(45, 126)
        Me.GreenRadioButton.Name = "GreenRadioButton"
        Me.GreenRadioButton.Size = New System.Drawing.Size(75, 23)
        Me.GreenRadioButton.TabIndex = 11
        Me.GreenRadioButton.Text = "Green"
        Me.GreenRadioButton.UseVisualStyleBackColor = True
        '
        'YellowRadioButton
        '
        Me.YellowRadioButton.AutoSize = True
        Me.YellowRadioButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.YellowRadioButton.Location = New System.Drawing.Point(45, 84)
        Me.YellowRadioButton.Name = "YellowRadioButton"
        Me.YellowRadioButton.Size = New System.Drawing.Size(77, 23)
        Me.YellowRadioButton.TabIndex = 10
        Me.YellowRadioButton.Text = "Yellow"
        Me.YellowRadioButton.UseVisualStyleBackColor = True
        '
        'GrayRadioButton
        '
        Me.GrayRadioButton.AutoSize = True
        Me.GrayRadioButton.Checked = True
        Me.GrayRadioButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GrayRadioButton.Location = New System.Drawing.Point(45, 38)
        Me.GrayRadioButton.Name = "GrayRadioButton"
        Me.GrayRadioButton.Size = New System.Drawing.Size(66, 23)
        Me.GrayRadioButton.TabIndex = 9
        Me.GrayRadioButton.TabStop = True
        Me.GrayRadioButton.Text = "Gray"
        Me.GrayRadioButton.UseVisualStyleBackColor = True
        '
        'VehicleInfoTextBox
        '
        Me.VehicleInfoTextBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.VehicleInfoTextBox.Location = New System.Drawing.Point(354, 247)
        Me.VehicleInfoTextBox.Name = "VehicleInfoTextBox"
        Me.VehicleInfoTextBox.ReadOnly = True
        Me.VehicleInfoTextBox.Size = New System.Drawing.Size(314, 26)
        Me.VehicleInfoTextBox.TabIndex = 17
        Me.VehicleInfoTextBox.TabStop = False
        '
        'DiaplayButton
        '
        Me.DiaplayButton.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DiaplayButton.Location = New System.Drawing.Point(677, 309)
        Me.DiaplayButton.Name = "DiaplayButton"
        Me.DiaplayButton.Size = New System.Drawing.Size(106, 28)
        Me.DiaplayButton.TabIndex = 9
        Me.DiaplayButton.Text = "Display"
        Me.FormToolTip.SetToolTip(Me.DiaplayButton, "Display Congratulations Message")
        Me.DiaplayButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResetButton.Location = New System.Drawing.Point(789, 309)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(106, 28)
        Me.ResetButton.TabIndex = 10
        Me.ResetButton.Text = "Reset"
        Me.FormToolTip.SetToolTip(Me.ResetButton, "Reset the form")
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PrintButton.Location = New System.Drawing.Point(676, 365)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(106, 28)
        Me.PrintButton.TabIndex = 11
        Me.PrintButton.Text = "&Print"
        Me.FormToolTip.SetToolTip(Me.PrintButton, "Print the form")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.Location = New System.Drawing.Point(789, 365)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(106, 28)
        Me.ExitButton.TabIndex = 12
        Me.ExitButton.Text = "&Exit"
        Me.FormToolTip.SetToolTip(Me.ExitButton, "Exit the application")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'VisibleCheckBox
        '
        Me.VisibleCheckBox.AutoSize = True
        Me.VisibleCheckBox.Checked = True
        Me.VisibleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.VisibleCheckBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.VisibleCheckBox.Location = New System.Drawing.Point(772, 247)
        Me.VisibleCheckBox.Name = "VisibleCheckBox"
        Me.VisibleCheckBox.Size = New System.Drawing.Size(76, 23)
        Me.VisibleCheckBox.TabIndex = 8
        Me.VisibleCheckBox.Text = "Visible"
        Me.VisibleCheckBox.UseVisualStyleBackColor = True
        '
        'DisplayTextBox
        '
        Me.DisplayTextBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DisplayTextBox.Location = New System.Drawing.Point(237, 289)
        Me.DisplayTextBox.Multiline = True
        Me.DisplayTextBox.Name = "DisplayTextBox"
        Me.DisplayTextBox.ReadOnly = True
        Me.DisplayTextBox.Size = New System.Drawing.Size(432, 112)
        Me.DisplayTextBox.TabIndex = 23
        Me.DisplayTextBox.TabStop = False
        '
        'AutoVehiclePictureBox
        '
        Me.AutoVehiclePictureBox.Image = Global.BhimRepairShop.My.Resources.Resources._auto
        Me.AutoVehiclePictureBox.Location = New System.Drawing.Point(7, 256)
        Me.AutoVehiclePictureBox.Name = "AutoVehiclePictureBox"
        Me.AutoVehiclePictureBox.Size = New System.Drawing.Size(217, 145)
        Me.AutoVehiclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AutoVehiclePictureBox.TabIndex = 24
        Me.AutoVehiclePictureBox.TabStop = False
        '
        'CommercialVehiclePictureBox
        '
        Me.CommercialVehiclePictureBox.Image = Global.BhimRepairShop.My.Resources.Resources.commercial
        Me.CommercialVehiclePictureBox.Location = New System.Drawing.Point(7, 256)
        Me.CommercialVehiclePictureBox.Name = "CommercialVehiclePictureBox"
        Me.CommercialVehiclePictureBox.Size = New System.Drawing.Size(217, 145)
        Me.CommercialVehiclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CommercialVehiclePictureBox.TabIndex = 25
        Me.CommercialVehiclePictureBox.TabStop = False
        '
        'TruckPictureBox
        '
        Me.TruckPictureBox.Image = Global.BhimRepairShop.My.Resources.Resources.truck
        Me.TruckPictureBox.Location = New System.Drawing.Point(7, 256)
        Me.TruckPictureBox.Name = "TruckPictureBox"
        Me.TruckPictureBox.Size = New System.Drawing.Size(217, 145)
        Me.TruckPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TruckPictureBox.TabIndex = 26
        Me.TruckPictureBox.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
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
        'BockRepairPartsForm
        '
        Me.AcceptButton = Me.DiaplayButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ResetButton
        Me.ClientSize = New System.Drawing.Size(900, 428)
        Me.Controls.Add(Me.TruckPictureBox)
        Me.Controls.Add(Me.CommercialVehiclePictureBox)
        Me.Controls.Add(Me.AutoVehiclePictureBox)
        Me.Controls.Add(Me.DisplayTextBox)
        Me.Controls.Add(Me.VisibleCheckBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.DiaplayButton)
        Me.Controls.Add(Me.VehicleInfoTextBox)
        Me.Controls.Add(Me.SelectColorGroupBox)
        Me.Controls.Add(Me.VehicelTypeGroupBox)
        Me.Controls.Add(Me.CustomerInformationGroupBox)
        Me.Controls.Add(Me.VehicleInfoLabel)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "BockRepairPartsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bock Repair Parts - by Etse Joseph"
        Me.CustomerInformationGroupBox.ResumeLayout(False)
        Me.CustomerInformationGroupBox.PerformLayout()
        Me.VehicelTypeGroupBox.ResumeLayout(False)
        Me.VehicelTypeGroupBox.PerformLayout()
        Me.SelectColorGroupBox.ResumeLayout(False)
        Me.SelectColorGroupBox.PerformLayout()
        CType(Me.AutoVehiclePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommercialVehiclePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TruckPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerNameLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents TelephoneLabel As Label
    Friend WithEvents CityTownLabel As Label
    Friend WithEvents RegionLabel As Label
    Friend WithEvents VehicleInfoLabel As Label
    Friend WithEvents CustomerInformationGroupBox As GroupBox
    Friend WithEvents VehicelTypeGroupBox As GroupBox
    Friend WithEvents SelectColorGroupBox As GroupBox
    Friend WithEvents RegionTextBox As TextBox
    Friend WithEvents CityTownTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents CommercialRadioButton As RadioButton
    Friend WithEvents TruckRadioButton As RadioButton
    Friend WithEvents AutoRadioButton As RadioButton
    Friend WithEvents BlueRadioButton As RadioButton
    Friend WithEvents GreenRadioButton As RadioButton
    Friend WithEvents YellowRadioButton As RadioButton
    Friend WithEvents GrayRadioButton As RadioButton
    Friend WithEvents VehicleInfoTextBox As TextBox
    Friend WithEvents DiaplayButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents TelephoneMaskedTextBox As MaskedTextBox
    Friend WithEvents VisibleCheckBox As CheckBox
    Friend WithEvents DisplayTextBox As TextBox
    Friend WithEvents VehiclePictureBox1 As PictureBox
    Friend WithEvents CommercialVehiclePictureBox As PictureBox
    Friend WithEvents TruckVehiclePictureBox As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents FormToolTip As ToolTip
    Friend WithEvents AutoVehiclePictureBox As PictureBox
    Friend WithEvents TruckPictureBox As PictureBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
