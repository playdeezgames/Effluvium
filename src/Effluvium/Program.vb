Module Program
    Sub Main(args As String())
        Console.Title = "Effluvium"
        Dim ui As IUI = New SpectreUI
        TitleProcessor.Run(ui)
    End Sub
End Module
