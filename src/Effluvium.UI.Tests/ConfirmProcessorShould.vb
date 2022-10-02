Public Class ConfirmProcessorShould
    Inherits BaseProcessorTest
    <Theory>
    <InlineData(Choices.YesChoice, True)>
    <InlineData(Choices.NoChoice, False)>
    Sub ReturnAppropriatelyBasedOnTheChoiceOfYesOrNo(choice As String, expected As Boolean)
        Dim ui As New Mock(Of IUI)
        SetupPrompt(ui, choice)
        ConfirmProcessor.Confirm(ui.Object, "").ShouldBe(expected)
        VerifyPrompt(ui)
        ui.VerifyNoOtherCalls()
    End Sub
End Class
