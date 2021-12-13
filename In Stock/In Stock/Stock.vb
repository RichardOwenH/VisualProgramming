Public Class Stock
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click

        Try
            If txtInput.Text <= 0 Then
                lblOutput.Text = "Product is Sold Out"
            Else
                lblOutput.Text = "Product is in Stock"
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter number!")
        End Try
    End Sub
End Class
