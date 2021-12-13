Public Class Bank_Loan
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        If NumericValue(txtSalary.Text) And NumericValue(txtYears.Text) Then
            If txtSalary.Text > 30000 Then
                If txtYears.Text > 2 Then
                    lblOutput.Text = "Applicant qualifies"
                Else
                    lblOutput.Text = "Applicant does not qualifies"
                End If
            Else
                If txtYears.Text > 5 Then
                    lblOutput.Text = "Applicant qualifies"
                Else
                    lblOutput.Text = "Applicant does not qualifies"
                End If
            End If
        Else
            MsgBox("Please Input Number!")
        End If
    End Sub
    Private Function NumericValue(input As String) As Boolean
        If String.IsNullOrWhiteSpace(input) Then Return False
        If IsNumeric(input) Then Return True
        Dim parts() As String = input.Split("/"c)
        If parts.Length <> 2 Then Return False
        Return IsNumeric(parts(0)) AndAlso IsNumeric(parts(0))
    End Function
End Class