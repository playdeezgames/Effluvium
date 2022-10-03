Namespace Effluvium.UI.Tests
    Public Class TitleProcessorShould
        Inherits BaseProcessorTest
        <Fact>
        Sub GiveAWelcomeMessageAndProceedToTheMainMenu()
            WithUI(
                Sub(ui, world)
                    SetupPrompt(ui, OkChoice, QuitChoice, YesChoice)
                    TitleProcessor.Run(ui.Object, world.Object)
                    ui.Verify(Sub(x) x.Clear())
                    ui.Verify(Sub(x) x.WriteLine(It.IsAny(Of String)))
                    VerifyPrompt(ui)
                End Sub)
        End Sub
    End Class
End Namespace

