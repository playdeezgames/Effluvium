Friend Class SpectreUI
    Implements IUI

    Public Sub WriteLine(line As String) Implements IUI.WriteLine
        AnsiConsole.MarkupLine(line)
    End Sub

    Public Function Prompt(title As String, ParamArray choices() As String) As String Implements IUI.Prompt
        Dim selection As New SelectionPrompt(Of String) With {.Title = $"[olive]{title}[/]"}
        selection.AddChoices(choices)
        Return AnsiConsole.Prompt(selection)
    End Function
End Class
