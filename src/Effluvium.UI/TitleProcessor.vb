Public Module TitleProcessor
    Public Sub Run(ui As IUI)
        ui.Clear()
        ui.WriteLine("Welcome to Effluvium!")
        ui.Prompt("", OkChoice)
        MainMenuProcessor.Run(ui)
    End Sub
End Module
