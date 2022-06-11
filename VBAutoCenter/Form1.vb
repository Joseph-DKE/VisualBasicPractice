Public Class VBAutoCenterForm
    Private Sub AutoSalesButton_Click(sender As Object, e As EventArgs) Handles AutoSalesButton.Click
        InformationLabel.Text = "Family Wagon" + Environment.NewLine + "Immaculate Condition" + Environment.NewLine + "$12.995"
    End Sub

    Private Sub ServiceCenterButton_Click(sender As Object, e As EventArgs) Handles ServiceCenterButton.Click
        InformationLabel.Text = "Lube" + Environment.NewLine + "Oil" + Environment.NewLine + "Filter" + Environment.NewLine + "$25.99"
    End Sub

    Private Sub DetailShopButton_Click(sender As Object, e As EventArgs) Handles DetailShopButton.Click
        InformationLabel.Text = "Complete Detail" + Environment.NewLine + "$79.95 for most cars"
    End Sub

    Private Sub EmploymentOpportunitiesButton_Click(sender As Object, e As EventArgs) Handles EmploymentOpportunitiesButton.Click
        InformationLabel.Text = "Sales Position" + Environment.NewLine + "Contact Mr, Mann" + Environment.NewLine + "551-2134 x475"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font1 As New Font("arial", 16, FontStyle.Regular)
        e.Graphics.DrawString(InformationLabel.Text, font1, Brushes.Black, 100, 100)
    End Sub
End Class
