Public Class Form1
    Inherits System.Windows.Forms.Form
    Const sngPayRate As Single = 9.5

    Private Sub bbtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decTotalPay As Decimal
        Dim decWeeklyPay As Decimal

        decWeeklyPay = Val(txthours1.Text) * sngPayRate
        lblWeeklyPay1.Text = decWeeklyPay.ToString
        decTotalPay = decWeeklyPay

        decWeeklyPay = Val(txthours2.Text) * sngPayRate
        lblWeeklyPay2.Text = decWeeklyPay.ToString
        decTotalPay += decWeeklyPay

        decWeeklyPay = Val(txthours3.Text) * sngPayRate
        lblWeeklyPay3.Text = decWeeklyPay.ToString
        decTotalPay += decWeeklyPay

        decWeeklyPay = Val(txthours4.Text) * sngPayRate
        lblWeeklyPay4.Text = decWeeklyPay.ToString
        decTotalPay += decWeeklyPay

        lblTotalPay.Text = decTotalPay.ToString

    End Sub

End Class
