Imports System.Reflection
Imports Discord.WebSocket
Imports System.Threading
Imports Discord.Commands
Imports System.IO.File
Imports Discord

Module Main
    Private _client As DiscordSocketClient
    Private _commands As CommandService

    Sub Main()
        Start().GetAwaiter().GetResult()
    End Sub

    Async Function Start() As Task
        _client = New DiscordSocketClient()
        _commands = New CommandService()
        AddEventHandlers()
        Await _commands.AddModulesAsync(Assembly.GetEntryAssembly(), Nothing)
        Await _client.LoginAsync(TokenType.Bot, ReadAllText($"{Environment.CurrentDirectory}\Token.txt"))
        Await _client.StartAsync()
        Await Task.Delay(Timeout.Infinite)
    End Function

    Private Sub AddEventHandlers()
        AddHandler _client.Log, AddressOf Logger
        AddHandler _commands.Log, AddressOf Logger
        AddHandler _client.MessageReceived, AddressOf CommandHandler
    End Sub

    Private Async Function CommandHandler(ByVal message As SocketMessage) As Task
        Dim userMessage As SocketUserMessage = TryCast(message, SocketUserMessage)
        If userMessage Is Nothing OrElse userMessage.Author.IsBot Then Return
        Dim context As New SocketCommandContext(_client, userMessage)
        If userMessage.HasStringPrefix(">", 1) OrElse userMessage.HasMentionPrefix(_client.CurrentUser, 1) Then
            Dim result As IResult = Await _commands.ExecuteAsync(context, 1, Nothing)
            If Not result.IsSuccess AndAlso Not result.Error = CommandError.UnknownCommand Then
                Await userMessage.Channel.SendMessageAsync(result.ErrorReason)
            End If
        End If
    End Function

    Private Function Logger(ByVal message As LogMessage, Optional task As Task = Nothing) As Task
        Console.WriteLine($"{DateTime.Now,-19} [{message.Severity,8}] {message.Source}: {message.Message} {message.Exception}")
        Return Task.CompletedTask
    End Function
End Module