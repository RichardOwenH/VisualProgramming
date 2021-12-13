Public Class Form1
    Dim Counter As Integer = 0
    Private Sub btncounter_Click(sender As Object, e As EventArgs) Handles btncounter.Click
        Counter = Counter + 1
        lblcounter.Text = Counter.ToString
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        lblcounter.Text = 0
        Counter = 0
    End Sub

End Class