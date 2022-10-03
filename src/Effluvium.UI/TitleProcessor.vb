Public Module TitleProcessor
    Public Sub Run(ui As IUI, world As IWorld)
        ui.Clear()
        ui.WriteLine("Welcome to Effluvium!")
        ui.Prompt("", OkChoice)
        MainMenuProcessor.Run(ui, world)
    End Sub
End Module
