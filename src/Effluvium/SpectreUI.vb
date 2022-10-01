Friend Class SpectreUI
    Implements IUI

    Public Sub WriteLine(line As String) Implements IUI.WriteLine
        AnsiConsole.MarkupLine(line)
    End Sub
End Class
