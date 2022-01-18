Imports System.Text.RegularExpressions
Imports System.Collections.Specialized
Imports OpenQA.Selenium.Chrome
Imports Discord.Commands
Imports OpenQA.Selenium

Module Commands
    Public Class Main
        Inherits ModuleBase(Of SocketCommandContext)
        Shared driver As IWebDriver
        Shared NumbersandLinks As New NameValueCollection()

        <Command("Link")>
        Public Function Link(<Remainder> Query As String) As Task
            Try
                Return ReplyAsync(NumbersandLinks.Item(Query))
            Catch ex As Exception
                Return ReplyAsync(ex.Message)
            End Try
        End Function

        <Command("Find")>
        Public Function StartChrome(MaxPageNumber As Integer, <Remainder> Dork As String) As Task
            Dim PagesToCheck As Integer = 1
            Dim val As New ChromeOptions With {.BinaryLocation = "C:\Program Files\Google\Chrome\Application\chrome.exe"}
            val.PageLoadStrategy = PageLoadStrategy.Eager
            driver = New ChromeDriver(val)
            driver.Manage.Timeouts().ImplicitWait = TimeSpan.FromSeconds(10)
            driver.Url() = $"https://google.com/search?q={Dork}"
            Try
Restart:        For Each WebElement In driver.FindElements(By.PartialLinkText("://"))
                    Try
                        WebElement.SendKeys(Keys.Control & Keys.Enter)
                    Catch : End Try : Next
                PagesToCheck += 1
                If PagesToCheck > MaxPageNumber Then GoTo GetNumbers
                If driver.FindElement(By.XPath("//*[@id=""pnnext""]/span[2]")).Displayed Then driver.FindElement(By.XPath("//*[@id=""pnnext""]/span[2]")).Click() : GoTo Restart
            Catch : End Try
GetNumbers: GetNumbers()
            Return Nothing
        End Function

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
                        NumbersandLinks.Set($"{Number}", $"{driver.Url}")
                    End If
                Next : Next : driver.Quit()
            Dim Msg As String = String.Empty
            For Each Item In NumbersandLinks
                Msg &= $"{Item}{vbNewLine}"
            Next
            ReplyAsync(Msg)
        End Sub : End Class : End Module