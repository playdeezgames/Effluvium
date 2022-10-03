Public Class MainMenuProcessorShould
    Inherits BaseProcessorTest
    <Fact>
    Sub AllowQuitting()
        WithUI(
            Sub(ui, world)
                SetupPrompt(ui, QuitChoice, YesChoice)
                MainMenuProcessor.Run(ui.Object, world.Object)
                VerifyPrompt(ui)
            End Sub)
    End Sub
    <Fact>
    Sub AllowStartingAGame()
        WithUI(
            Sub(ui, world)
                SetupPrompt(ui, StartGameChoice, QuitChoice, YesChoice)
                MainMenuProcessor.Run(ui.Object, world.Object)
                VerifyPrompt(ui)
                world.Verify(Sub(x) x.Start())
            End Sub)
    End Sub
End Class
