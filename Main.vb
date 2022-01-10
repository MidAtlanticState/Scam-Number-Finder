Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports System.Text.RegularExpressions
Public Class Main
    Shared driver As IWebDriver
    Public Sub StartChrome() Handles Start.Click
        Dim val As New ChromeOptions With {.BinaryLocation = My.Settings.EXE}
        val.PageLoadStrategy = PageLoadStrategy.Eager
        val.AddExcludedArgument("enable-automation")
        driver = New ChromeDriver(val)
        driver.Manage.Timeouts().ImplicitWait = TimeSpan.FromSeconds(My.Settings.WaitTime)
        driver.Url() = $"https://google.com/search?q={dorks.Text}"
        Dim MaxPage As Integer = 1
        Try
NextPage:   If driver.FindElement(By.XPath("//*[@id=""pnnext""]/span[2]")).Displayed And MaxPage <= My.Settings.PageNumber Then
                For Each WebElement In driver.FindElements(By.PartialLinkText("://"))
                    Try
                        WebElement.SendKeys(Keys.Control & Keys.Enter)
                    Catch : End Try
                Next
                MaxPage = +1
                If driver.FindElement(By.XPath("//*[@id=""pnnext""]/span[2]")).Displayed And MaxPage <= My.Settings.PageNumber Then driver.FindElement(By.XPath("//*[@id=""pnnext""]/span[2]")).Click()
                GoTo NextPage
            End If
        Catch : End Try
        GetNumbers()
    End Sub
    Public Sub GetNumbers()
        Dim FindNumbers As New Regex("(?'first'\+?\d{1,3})?[- .(]?\d{3}[- .)]{0,2}\d{3}[\(\-\ \.]?\d{4}[- .)]?")
        For Each openedtab In driver.WindowHandles
            driver.SwitchTo().Window(openedtab)
            Dim Matches As MatchCollection = Nothing
            Try
                Matches = FindNumbers.Matches(driver.FindElement(By.XPath("/html/body")).Text)
            Catch : End Try
            For Each Number In Matches
                If driver.Url.Contains("https://www.google.com/search?q=") = False Then
                    NumbersandLinks.Text &= $"{Number} {driver.Url}{vbNewLine}"
                    My.Computer.Audio.Play($"{Application.StartupPath}\Bingo.wav")
                End If
            Next : Next : NumbersandLinks.Text &= $"Done{vbNewLine}"  driver.Quit()
    End Sub
    Private Sub WhatIsAdork_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles WhatIsAdork.Opening
        Process.Start("https://en.wikipedia.org/wiki/Google_hacking")
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        SettingsPage.Show()
    End Sub
End Class