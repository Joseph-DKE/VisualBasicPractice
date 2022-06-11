Imports System.Drawing.Printing
'Class Name: BockRepairPartsForm
'Name: Etse Joseph
'Index Number: 9404119
'date programmed: 18-05-2021 to 20-05-2021

Public Class BockRepairPartsForm
    Private GrayBackgroundColor As Color

    Private Sub BockRepairPartsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Assign background color to module-level variable
        GrayBackgroundColor = Me.BackColor
        CommercialVehiclePictureBox.Visible = False
        TruckPictureBox.Visible = False
        AutoVehiclePictureBox.Visible = True
        CustomerNameTextBox.Focus()
    End Sub

    Private Sub DiaplayButton_Click(sender As Object, e As EventArgs) Handles DiaplayButton.Click
        'Display information to the user
        DisplayTextBox.Text = "Congratulations" + Environment.NewLine + CustomerNameTextBox.Text + Environment.NewLine + VehicleInfoTextBox.Text
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        'Reset the form by clearing the TextBox controls
        CustomerNameTextBox.Clear()
        AddressTextBox.Clear()
        TelephoneMaskedTextBox.Clear()
        CityTownTextBox.Clear()
        RegionTextBox.Clear()
        DisplayTextBox.Clear()
        VisibleCheckBox.Checked = True
        AutoRadioButton.Checked = True
        GrayRadioButton.Checked = True
        CustomerNameTextBox.Focus()
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Exit the application by closing it
        Me.Close()

    End Sub

    Private Sub AutoRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AutoRadioButton.CheckedChanged
        AutoVehiclePictureBox.Visible = True
        CommercialVehiclePictureBox.Visible = False
        TruckPictureBox.Visible = False
        VehicleInfoTextBox.Text = "Vehicle Type: Auto"
    End Sub

    Private Sub TruckRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TruckRadioButton.CheckedChanged
        TruckPictureBox.Visible = True
        CommercialVehiclePictureBox.Visible = False
        AutoVehiclePictureBox.Visible = False
        VehicleInfoTextBox.Text = "Vehicle Type: Truck"
    End Sub

    Private Sub CommercialRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CommercialRadioButton.CheckedChanged
        CommercialVehiclePictureBox.Visible = True
        TruckPictureBox.Visible = False
        AutoVehiclePictureBox.Visible = False
        VehicleInfoTextBox.Text = "Vehicle Type: Commercial"
    End Sub

    Private Sub GrayRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GrayRadioButton.CheckedChanged
        Me.BackColor = Color.Gray
    End Sub

    Private Sub YellowRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles YellowRadioButton.CheckedChanged
        Me.BackColor = Color.Yellow
    End Sub

    Private Sub GreenRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GreenRadioButton.CheckedChanged
        Me.BackColor = Color.Green
    End Sub

    Private Sub BlueRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlueRadioButton.CheckedChanged
        Me.BackColor = Color.Blue
    End Sub

    Private Sub VisibleCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles VisibleCheckBox.CheckedChanged
        If VisibleCheckBox.Checked = True Then
            VehicleInfoLabel.Visible = True
            VehicleInfoTextBox.Visible = True
            DisplayTextBox.Visible = True
        Else
            VehicleInfoLabel.Visible = False
            VehicleInfoTextBox.Visible = False
            DisplayTextBox.Visible = False
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("arial", 16, FontStyle.Regular)
        e.Graphics.DrawString(DisplayTextBox.Text, font1, Brushes.Black, 100, 100)
    End Sub
End Class