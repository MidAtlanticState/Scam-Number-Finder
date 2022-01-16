Public Class SettingsPage
    Private Sub SaveSettings_Click(sender As Object, e As EventArgs) Handles SaveSettings.Click
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub PageWaitValue_ValueChanged(sender As Object, e As EventArgs) Handles PageWaitValue.ValueChanged
        My.Settings.WaitTime = PageWaitValue.Value
    End Sub

    Private Sub PagesToCheck_ValueChanged(sender As Object, e As EventArgs) Handles PagesToCheck.ValueChanged
        My.Settings.MaxPageNumber = PagesToCheck.Value
    End Sub

    Private Sub ExePath_Click(sender As Object, e As EventArgs) Handles ExePath.Click
        FindExepath.ShowDialog()
        My.Settings.EXE = FindExepath.FileName
        MsgBox(My.Settings.EXE)
    End Sub

    Private Sub SettingsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PagesToCheck.Value = My.Settings.MaxPageNumber
        PageWaitValue.Value = My.Settings.WaitTime
    End Sub
End Class