Option Strict On
Public Class RPFEForm
    Public Shared AccumulatedNet As Double = 0
    Public Shared TotalQuantity As Double = 0
    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        Try
            Dim Quantity As Double = Decimal.Parse(QuantityTextBox.Text)
            Dim Retail As Double = Decimal.Parse(RetailPriceTextBox.Text)
            Dim Wholesale As Double = Decimal.Parse(WholesaleCostTextBox.Text)
            Dim Gross As Double = Math.Round((Retail - Wholesale) * Quantity, 2)
            GrossProfitTextBox.Text = Math.Round(Gross, 2).ToString()
            Const Storage As Single = 5.0
            Dim StoragePrice As Double = (Gross * Storage) / 100.0
            StorageChargesTextBox.Text = Math.Round(Storage, 2).ToString()
            Dim Net As Double = Gross - StoragePrice
            NetProfitTextBox.Text = "$" & Math.Round(Net, 2).ToString()
            ResetFormButton.Enabled = True
            ComputeButton.Enabled = False
            AccumulatedNet += Net
            TotalQuantity += Quantity
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

    Private Sub ResetFormButton_Click(sender As Object, e As EventArgs) Handles ResetFormButton.Click
        Try
            PartIdentifierTextBox.Clear()
            PartIdentifierTextBox.Focus()
            PartDescriptionTextBox.Clear()
            RetailPriceTextBox.Clear()
            WholesaleCostTextBox.Clear()
            QuantityTextBox.Clear()
            GrossProfitTextBox.Clear()
            StorageChargesTextBox.Clear()
            NetProfitTextBox.Clear()
            ResetFormButton.Enabled = False
            ComputeButton.Enabled = True
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

    Private Sub TotalNetProfitButton_Click(sender As Object, e As EventArgs) Handles TotalNetProfitButton.Click
        Try
            If (TotalQuantity = 0) Then
                MessageBox.Show("No Quantity Specified!", "Math Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf (AccumulatedNet = 0) Then
                MessageBox.Show("No Net Calculated!", "Math Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim AverageProfit As Double = Math.Round(AccumulatedNet / TotalQuantity, 2)
                Dim FinalMessage As String = "Total Net Profit: " & Math.Round(AccumulatedNet, 2).ToString() & Environment.NewLine &
                "Total Quantity: " & Math.Round(TotalQuantity, 2).ToString & Environment.NewLine &
                "Average Net Profit: " & Math.Round(AverageProfit, 2)
                MessageBox.Show(FinalMessage, "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.None)
            End If
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
End Class
