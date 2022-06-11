Option Strict On
Public Class Form1
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Try
            Dim Sales As Decimal = Decimal.Parse(StoreTotalSaleTextBox.Text)
            Dim Hours As Decimal = Decimal.Parse(TotalHoursWorkedTextBox.Text)
            Dim Salary As Decimal = CDec((Sales / 100.0) * 2.0)
            Dim Bonus As Decimal = CDec((Hours / 100.0) * 160)
            Dim Total As Decimal = Salary + Bonus
            BonusEarnedTextBox.Text = Total.ToString()
        Catch ex As FormatException
            MessageBox.Show("Invalid Input!", "Input Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As InvalidCastException
            MessageBox.Show("Conversion Error!", "Invalid Conversion ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As ArithmeticException
            MessageBox.Show("Error in calculation process!", "Calculation Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As System.IO.EndOfStreamException
            MessageBox.Show("Failure of an Input/Output operation!", "I/O Stream Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As OutOfMemoryException
            MessageBox.Show("Not enough memory!", "Memory Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Some Other error was encountered!", "General Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Try
            EmployeeNameTextBox.Clear()
            TotalHoursWorkedTextBox.Clear()
            BonusEarnedTextBox.Clear()
	    EmployeeNameTextBox.Focus()
        Catch ex As FormatException
            MessageBox.Show("Invalid Input!", "Input Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As InvalidCastException
            MessageBox.Show("Conversion Error!", "Invalid Conversion ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As ArithmeticException
            MessageBox.Show("Error in calculation process!", "Calculation Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As System.IO.EndOfStreamException
            MessageBox.Show("Failure of an Input/Output operation!", "I/O Stream Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As OutOfMemoryException
            MessageBox.Show("Not enough memory!", "Memory Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Some Other error was encountered!", "General Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Try
            PrintPreviewDialog1.ShowDialog()
        Catch ex As FormatException
            MessageBox.Show("Invalid Input!", "Input Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As InvalidCastException
            MessageBox.Show("Conversion Error!", "Invalid Conversion ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As ArithmeticException
            MessageBox.Show("Error in calculation process!", "Calculation Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As System.IO.EndOfStreamException
            MessageBox.Show("Failure of an Input/Output operation!", "I/O Stream Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As OutOfMemoryException
            MessageBox.Show("Not enough memory!", "Memory Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Some Other error was encountered!", "General Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Try
            Me.Close()
        Catch ex As FormatException
            MessageBox.Show("Invalid Input!", "Input Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As InvalidCastException
            MessageBox.Show("Conversion Error!", "Invalid Conversion ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As ArithmeticException
            MessageBox.Show("Error in calculation process!", "Calculation Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As System.IO.EndOfStreamException
            MessageBox.Show("Failure of an Input/Output operation!", "I/O Stream Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As OutOfMemoryException
            MessageBox.Show("Not enough memory!", "Memory Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Some Other error was encountered!", "General Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim WhatToOutput As String = "Employee Name: " & EmployeeNameTextBox.Text & Environment.NewLine & "Total Hours Worked: " & TotalHoursWorkedTextBox.Text & Environment.NewLine & "Total Store Sales: " & StoreTotalSaleTextBox.Text & Environment.NewLine & "Bonus Earned: " & BonusEarnedTextBox.Text
            Dim font1 As New Font("arial", 16, FontStyle.Regular)
            e.Graphics.DrawString(WhatToOutput, font1, Brushes.Black, 100, 100)
        Catch ex As FormatException
            MessageBox.Show("Invalid Input!", "Input Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As InvalidCastException
            MessageBox.Show("Conversion Error!", "Invalid Conversion ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As ArithmeticException
            MessageBox.Show("Error in calculation process!", "Calculation Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As System.IO.EndOfStreamException
            MessageBox.Show("Failure of an Input/Output operation!", "I/O Stream Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As OutOfMemoryException
            MessageBox.Show("Not enough memory!", "Memory Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show("Some Other error was encountered!", "General Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class
