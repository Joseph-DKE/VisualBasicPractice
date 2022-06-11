Option Strict On
Public Class BookStoreForm

    'Declare module-level variables and constants
    Private TotalQuantityInteger As Integer
    Private TotalSalesDecimal As Decimal

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        Try
            'Declare constants
            '7.25 percent sales tax rate
            Const SALES_TAX_RATE_SINGLE As Single = 0.0725

            'Declare variables
            Dim SubtotalDecimal, SalesTaxDecimal, TotalDueDecimal As Decimal

            'Declare variables and convert values from 
            'textbox controls to memory
            Dim PriceDecimal As Decimal = Decimal.Parse(PriceMaskedTextBox.Text, Globalization.NumberStyles.Currency)
            Dim QuantityInteger As Integer = Integer.Parse(QuantityTextBox.Text, Globalization.NumberStyles.Number)

            'Process - Compute values
            'Subtotal = price times the quantity of books
            SubtotalDecimal = PriceDecimal * QuantityInteger

            'Sales tax = sales tax rate times the subtotal 
            SalesTaxDecimal = Decimal.Round(Convert.ToDecimal(SubtotalDecimal * SALES_TAX_RATE_SINGLE), 2)

            'Total due = subtotal plus sales tax
            TotalDueDecimal = SubtotalDecimal + SalesTaxDecimal

            'Display output formatted as currency
            SubtotalTextBox.Text = SubtotalDecimal.ToString("C")
            SalesTaxTextBox.Text = SalesTaxDecimal.ToString("N")
            TotalDueTextBox.Text = TotalDueDecimal.ToString("C")

            'Other tasks to code
            'Enable/disable buttons
            ComputeButton.Enabled = False
            ResetButton.Enabled = True

            'Accumulate total sales and total books sold.
            TotalQuantityInteger += QuantityInteger
            TotalSalesDecimal += TotalDueDecimal

        Catch ex As Exception
            MessageBox.Show("Error in either Book Price or Quantity Purchased", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PriceMaskedTextBox.Focus()
        End Try
    End Sub

    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click
        'Clear the text box controls
        BookTitleTextBox.Clear()
        ISBNMaskedTextBox.Clear()
        PriceMaskedTextBox.Clear()
        QuantityTextBox.Clear()
        SubtotalTextBox.Clear()
        SalesTaxTextBox.Clear()
        TotalDueTextBox.Clear()

        'Enable/disable buttons
        ComputeButton.Enabled = True
        ResetButton.Enabled = False

        'Set the focus to the book title text box control
        BookTitleTextBox.Focus()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub TotalsButton_Click(sender As Object, e As EventArgs) Handles TotalsButton.Click
        Try
            'Display the total sales, total books sold, 
            'and average book value in a message box.
            Dim AverageSaleDecimal As Decimal = TotalSalesDecimal / TotalQuantityInteger
            Dim MessageString As String = "Total Sales: " & TotalSalesDecimal.ToString("C") & ControlChars.NewLine & "Total Books Sold: " & TotalQuantityInteger.ToString("N0") & ControlChars.NewLine & "Average Book Value: " & AverageSaleDecimal.ToString("C")

            MessageBox.Show(MessageString, "Totals and Averages", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch exArithmeticException As ArithmeticException
            MessageBox.Show("No books have been sold yet", "Zero Sales Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Unexpected Error-inform the system administrator", "Unknown Error in Totals Button", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
