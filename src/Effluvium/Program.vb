Module Program
    Sub Main(args As String())
        Console.Title = "Effluvium"
        Dim ui As IUI = New SpectreUI
        Dim world As IWorld = New World
        TitleProcessor.Run(ui, world)
    End Sub
End Module
