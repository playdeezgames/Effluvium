Public Class ConfirmProcessorShould
    Private Sub SetupPrompt(UI As Mock(Of IUI), ParamArray choices As String())
        Dim promptResults As New Queue(Of String)(choices)
        UI.Setup(
            Function(x) x.Prompt(It.IsAny(Of String), It.IsAny(Of String()))).
            Returns(Function(a, b) promptResults.Dequeue())
    End Sub
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
