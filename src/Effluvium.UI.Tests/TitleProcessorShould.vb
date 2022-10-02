Namespace Effluvium.UI.Tests
    Public Class TitleProcessorShould
        Inherits BaseProcessorTest
        <Fact>
        Sub GiveAWelcomeMessageAndProceedToTheMainMenu()
            WithUI(
                Sub(ui)
                    SetupPrompt(ui, OkChoice, QuitChoice, YesChoice)
                    TitleProcessor.Run(ui.Object)
                    ui.Verify(Sub(x) x.Clear())
                    ui.Verify(Sub(x) x.WriteLine(It.IsAny(Of String)))
                    VerifyPrompt(ui)
                End Sub)
        End Sub
    End Class
End Namespace

