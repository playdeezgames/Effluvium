Public Class ConfirmProcessorShould
    Inherits BaseProcessorTest
    <Theory>
    <InlineData(Choices.YesChoice, True)>
    <InlineData(Choices.NoChoice, False)>
    Sub ReturnAppropriatelyBasedOnTheChoiceOfYesOrNo(choice As String, expected As Boolean)
        WithUI(
            Sub(ui, world)
                SetupPrompt(ui, choice)
                ConfirmProcessor.Confirm(ui.Object, "").ShouldBe(expected)
                VerifyPrompt(ui)
            End Sub)
    End Sub
End Class
