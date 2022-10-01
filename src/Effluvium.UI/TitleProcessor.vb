Public Module TitleProcessor
    Public Sub Run(ui As IUI)
        ui.Clear()
        ui.WriteLine("Welcome to Effluvium!")
        ui.Prompt("", "Ok")
        MainMenuProcessor.Run(ui)
    End Sub
End Module
