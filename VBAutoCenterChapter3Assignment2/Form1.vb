Option Strict On
Public Class AutoCenterForm
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Try
            Dim CommissionRate As Decimal = CDec(20.0 / 100.0)
            Dim SellingPrice As Decimal = Decimal.Parse(SellingPriceTextBox.Text)
            Dim CostPrice As Decimal = Decimal.Parse(CostPriceTextBox.Text)
            Dim Commission As Decimal = CDec(CommissionRate * (SellingPrice - CostPrice))
            CommissionTextBox.Text = Commission.ToString()
        Catch ex As FormatException
            MessageBox.Show("Invalid Input!", "Input Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As InvalidCastException
            MessageBox.Show("Conversion Error!", "Invalid Conversion ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ArithmeticException
            MessageBox.Show("Error in calculation process!", "Calculation Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As System.IO.EndOfStreamException
            MessageBox.Show("Failure of an Input/Output operation!", "I/O Stream Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As OutOfMemoryException
            MessageBox.Show("Not enough memory!", "Memory Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Some Other error was encountered!", "General Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Try
            PrintPreviewDialog1.ShowDialog()
        Catch ex As FormatException
            MessageBox.Show("Invalid Input!", "Input Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As InvalidCastException
            MessageBox.Show("Conversion Error!", "Invalid Conversion ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ArithmeticException
            MessageBox.Show("Error in calculation process!", "Calculation Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As System.IO.EndOfStreamException
            MessageBox.Show("Failure of an Input/Output operation!", "I/O Stream Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As OutOfMemoryException
            MessageBox.Show("Not enough memory!", "Memory Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Some Other error was encountered!", "General Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Try
            SalesPersonNameTextBox.Clear()
            SellingPriceTextBox.Clear()
            CostPriceTextBox.Clear()
            CommissionTextBox.Clear()
            SalesPersonNameTextBox.Focus()
        Catch ex As FormatException
            MessageBox.Show("Invalid Input!", "Input Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As InvalidCastException
            MessageBox.Show("Conversion Error!", "Invalid Conversion ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ArithmeticException
            MessageBox.Show("Error in calculation process!", "Calculation Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As System.IO.EndOfStreamException
            MessageBox.Show("Failure of an Input/Output operation!", "I/O Stream Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As OutOfMemoryException
            MessageBox.Show("Not enough memory!", "Memory Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Some Other error was encountered!", "General Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Try
            Me.Close()
        Catch ex As FormatException
            MessageBox.Show("Invalid Input!", "Input Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As InvalidCastException
            MessageBox.Show("Conversion Error!", "Invalid Conversion ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ArithmeticException
            MessageBox.Show("Error in calculation process!", "Calculation Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As System.IO.EndOfStreamException
            MessageBox.Show("Failure of an Input/Output operation!", "I/O Stream Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As OutOfMemoryException
            MessageBox.Show("Not enough memory!", "Memory Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Some Other error was encountered!", "General Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim WhatToOutput As String = "Sales Person Name: " & SalesPersonNameTextBox.Text & Environment.NewLine & "Cost Price: " & CostPriceTextBox.Text & Environment.NewLine & "Selling Price: " & SellingPriceTextBox.Text & Environment.NewLine & "Commission: " & CommissionTextBox.Text
            Dim font1 As New Font("arial", 16, FontStyle.Regular)
            e.Graphics.DrawString(WhatToOutput, font1, Brushes.Black, 100, 100)
        Catch ex As FormatException
            MessageBox.Show("Invalid Input!", "Input Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As InvalidCastException
            MessageBox.Show("Conversion Error!", "Invalid Conversion ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ArithmeticException
            MessageBox.Show("Error in calculation process!", "Calculation Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As System.IO.EndOfStreamException
            MessageBox.Show("Failure of an Input/Output operation!", "I/O Stream Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As OutOfMemoryException
            MessageBox.Show("Not enough memory!", "Memory Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Some Other error was encountered!", "General Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
