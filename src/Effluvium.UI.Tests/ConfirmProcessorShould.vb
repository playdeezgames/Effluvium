Public Class ConfirmProcessorShould
    Inherits BaseProcessorTest
    <Theory>
    <InlineData(Choices.YesChoice, True)>
    <InlineData(Choices.NoChoice, False)>
    Sub ReturnAppropriatelyBasedOnTheChoiceOfYesOrNo(choice As String, expected As Boolean)
        Dim ui As New Mock(Of IUI)
        SetupPrompt(ui, choice)
        ConfirmProcessor.Confirm(ui.Object, "").ShouldBe(expected)
        ui.Verify(Function(x) x.Prompt(It.IsAny(Of String), It.IsAny(Of String())))
        ui.VerifyNoOtherCalls()
    End Sub
End Class
