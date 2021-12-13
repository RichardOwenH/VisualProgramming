Public Class Grade
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click

        If txtInput.Text < 60 Then
            lblOutput.Text = "F"
        ElseIf txtInput.Text < 70 Then
            lblOutput.Text = "D"
        ElseIf txtInput.Text < 80 Then
            lblOutput.Text = "C"
        ElseIf txtInput.Text < 90 Then
            lblOutput.Text = "B"
        ElseIf txtInput.Text < 100 Then
            lblOutput.Text = "A"
        End If
    End Sub

    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class