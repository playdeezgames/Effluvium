Namespace Effluvium.UI.Tests
    Public Class TitleProcessorShould
        Inherits BaseProcessorTest
        <Fact>
        Sub GiveAWelcomeMessageAndProceedToTheMainMenu()
            Dim ui As New Mock(Of IUI)
            SetupPrompt(ui, OkChoice, QuitChoice, YesChoice)
            TitleProcessor.Run(ui.Object)
            ui.Verify(Sub(x) x.Clear())
            ui.Verify(Sub(x) x.WriteLine(It.IsAny(Of String)))
            VerifyPrompt(ui)
            ui.VerifyNoOtherCalls()
        End Sub
    End Class
End Namespace

