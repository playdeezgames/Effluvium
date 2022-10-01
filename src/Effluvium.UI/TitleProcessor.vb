Public Module TitleProcessor
    Public Sub Run(ui As IUI)
        ui.Clear()
        ui.WriteLine("Welcome to Effluvium!")
        ui.Prompt("", "Ok")
    End Sub
End Module
