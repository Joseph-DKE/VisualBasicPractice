Public Class VBMailOrderForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub CustomerRelationsButton_Click(sender As Object, e As EventArgs) Handles CustomerRelationsButton.Click
        NameLabel.Text = "Trici Mills"
        NumberLabel.Text = "500-1111"
    End Sub

    Private Sub MarketingButton_Click(sender As Object, e As EventArgs) Handles MarketingButton.Click
        NameLabel.Text = "Michelle Rigner"
        NumberLabel.Text = "500-2222"
    End Sub

    Private Sub OrderProcessingButton_Click(sender As Object, e As EventArgs) Handles OrderProcessingButton.Click
        NameLabel.Text = "Kenna DeVoss"
        NumberLabel.Text = "500-3333"
    End Sub

    Private Sub ShippingDepartmentsButton_Click(sender As Object, e As EventArgs) Handles ShippingDepartmentsButton.Click
        NameLabel.Text = "Eric Andrews"
        NumberLabel.Text = "500-4444"
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("arial", 16, FontStyle.Regular)
        Dim WhatToPrint As String = DepartmentContactLabel.Text + ":" + Environment.NewLine + NameLabel.Text + Environment.NewLine + TelephoneNunberLabel.Text + ":" + Environment.NewLine + NumberLabel.Text
        e.Graphics.DrawString(WhatToPrint, font1, Brushes.Black, 100, 100)
    End Sub
End Class
