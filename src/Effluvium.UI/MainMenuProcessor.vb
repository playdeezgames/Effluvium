Public Module MainMenuProcessor
    Sub Run(ui As IUI)
        Dim done = False
        While Not done
            Select Case ui.Prompt("Main Menu:", QuitChoice)
                Case QuitChoice
                    done = ConfirmProcessor.Confirm(ui, "Are you sure you want to quit?")
            End Select
        End While
    End Sub
End Module
