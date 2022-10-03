Public Module MainMenuProcessor
    Sub Run(ui As IUI, world As IWorld)
        Dim done = False
        While Not done
            Select Case ui.Prompt("Main Menu:", StartGameChoice, QuitChoice)
                Case StartGameChoice
                    StartGameProcessor.Run(ui, world)
                Case QuitChoice
                    done = ConfirmProcessor.Confirm(ui, "Are you sure you want to quit?")
            End Select
        End While
    End Sub
End Module
