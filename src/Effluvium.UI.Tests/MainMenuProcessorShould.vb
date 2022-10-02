Public Class MainMenuProcessorShould
    Inherits BaseProcessorTest
    <Fact>
    Sub AllowQuitting()
        WithUI(
            Sub(ui)
                SetupPrompt(ui, QuitChoice, YesChoice)
                MainMenuProcessor.Run(ui.Object)
                VerifyPrompt(ui)
            End Sub)
    End Sub
End Class
