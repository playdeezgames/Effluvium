Public Module MainMenuProcessor
    Sub Run(ui As IUI)
        Dim done = False
        While Not done
            done = ui.Prompt("Main Menu:", QuitChoice) = QuitChoice
        End While
    End Sub
End Module
