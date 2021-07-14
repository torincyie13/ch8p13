Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim strShipped(,) As String = {{"225", "216", "150"},
                                        {"199", "225", "215"},
                                        {"230", "200", "225"},
                                        {"150", "175", "200"}}
        Dim intTotalShipped As Integer
        Dim intTotalFedexShipped As Integer
        Dim intTotalUPSShipped As Integer
        Dim intTotalUSPSShipped As Integer
        Dim intPercentFedex As Decimal
        Dim intPrecentUPS As Decimal
        Dim intPercentUSPS As Decimal
        Dim intRow As Integer

        For Each n In strShipped
            intTotalShipped += n
        Next

        lblTotalShipped.Text = intTotalShipped

        For intRow = 0 To strShipped.GetLength(0) - 1
            intTotalFedexShipped += strShipped(intRow, 0)
        Next

        intPercentFedex = intTotalFedexShipped / intTotalShipped
        lblFedexPercent.Text = intPercentFedex.ToString("P0")
        lblFedexTotal.Text = intTotalFedexShipped

        For intRow = 0 To strShipped.GetLength(0) - 1
            intTotalUPSShipped += strShipped(intRow, 1)
        Next

        intPrecentUPS = intTotalUPSShipped / intTotalShipped
        lblUPSPercent.Text = intPrecentUPS.ToString("P0")
        lblUPSTotal.Text = intTotalUPSShipped

        For intRow = 0 To strShipped.GetLength(0) - 1
            intTotalUSPSShipped += strShipped(intRow, 2)
        Next

        intPercentUSPS = intTotalUSPSShipped / intTotalShipped
        lblUSPSPercent.Text = intPercentUSPS.ToString("P0")
        lblUSPSTotal.Text = intTotalUSPSShipped



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
