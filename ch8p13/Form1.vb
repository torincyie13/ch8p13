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
        Dim intPercentFedex As Integer
        Dim intPrecentUPS As Integer
        Dim intPercentUSPS As Integer

        intTotalShipped = 0
        For Each n In strShipped
            intTotalShipped += n
        Next

        intTotalFedexShipped = 0
        For intColumn As Integer = 0 To strShipped.GetUpperBound(1)
            intTotalFedexShipped += strShipped

            lblFedexTotal.Text = intTotalFedexShipped
        lblTotalShipped.Text = intTotalShipped


    End Sub
End Class
