Public Class formMain
    Private Sub TSExit_Click(sender As Object, e As EventArgs) Handles TSExit.Click
        Application.Exit()
    End Sub

    Private Sub TSbtnNew_Click(sender As Object, e As EventArgs) Handles TSbtnNew.Click
        txtInput.Clear()
        txtInput.Text = "Input Your Text"
        MessageBox.Show("New File Has Been Created")
    End Sub
    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatToday.Text = Today
    End Sub
    Private Sub timerNow_Tick(sender As Object, e As EventArgs) Handles timerNow.Tick
        statTimes.Text = TimeOfDay
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Text = ""
    End Sub
    Private Sub TSbtnSave_Click(sender As Object, e As EventArgs) Handles TSbtnSave.Click
        MessageBox.Show("Congratulation!" & vbCrLf & "Your File Has Been Save")
    End Sub
    Private Sub menuSave_Click(sender As Object, e As EventArgs) Handles menuSave.Click
        MessageBox.Show("Congratulation!" & vbCrLf & "Your File Has Been Save")
    End Sub
    Private Sub menuOpen_Click(sender As Object, e As EventArgs) Handles menuOpen.Click
        MessageBox.Show("Sorry!" & vbCrLf & "Your Don't Have Any of File")
    End Sub
    Private Sub menuNew_Click(sender As Object, e As EventArgs) Handles menuNew.Click
        txtInput.Clear()
        txtInput.Text = "Input Your Text"
        MessageBox.Show("New File Has Been Created")
    End Sub
    Private Sub TSbtnOpen_Click(sender As Object, e As EventArgs) Handles TSbtnOpen.Click
        MessageBox.Show("Sorry!" & vbCrLf & "Your Don't Have Any of File")
    End Sub
    Private Sub TSbtnInfo_Click(sender As Object, e As EventArgs) Handles TSbtnInfo.Click
        MessageBox.Show("This Program is design by Richard Owen Hendarto")
    End Sub
    Private Sub TSbtnCut_Click(sender As Object, e As EventArgs) Handles TSbtnCut.Click
        txtInput.Cut()
    End Sub
    Private Sub TSbtnCopy_Click(sender As Object, e As EventArgs) Handles TSbtnCopy.Click
        txtInput.Copy()
    End Sub
    Private Sub TSbtnPaste_Click(sender As Object, e As EventArgs) Handles TSbtnPaste.Click
        txtInput.Paste()
    End Sub
    Private Sub menuCut_Click(sender As Object, e As EventArgs) Handles menuCut.Click
        txtInput.Cut()
    End Sub
    Private Sub menuCopy_Click(sender As Object, e As EventArgs) Handles menuCopy.Click
        txtInput.Copy()
    End Sub
    Private Sub menuPaste_Click(sender As Object, e As EventArgs) Handles menuPaste.Click
        txtInput.Paste()
    End Sub
    Private Sub menuAll_Click(sender As Object, e As EventArgs) Handles menuAll.Click
        txtInput.SelectAll()
    End Sub
    Private Sub menuUndo_Click(sender As Object, e As EventArgs) Handles menuUndo.Click
        txtInput.Undo()
    End Sub
    Private Sub TSDelete_Click(sender As Object, e As EventArgs) Handles TSDelete.Click
        txtInput.Clear()
    End Sub
End Class
