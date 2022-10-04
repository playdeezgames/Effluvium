Module Program
    Sub Main(args As String())
        Console.Title = "Effluvium"
        Dim ui As IUI = New SpectreUI
        Dim store As IStore = New Store("boilerplate.db")
        Dim worldData As IWorldData = New WorldData(store)
        Dim world As IWorld = New World(worldData)
        TitleProcessor.Run(ui, world)
    End Sub
End Module
