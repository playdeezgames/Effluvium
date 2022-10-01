Public MustInherit Class BaseProcessorTest
    Protected Sub SetupPrompt(UI As Mock(Of IUI), ParamArray choices As String())
        Dim promptResults As New Queue(Of String)(choices)
        UI.Setup(
            Function(x) x.Prompt(It.IsAny(Of String), It.IsAny(Of String()))).
            Returns(Function(a, b) promptResults.Dequeue())
    End Sub
End Class
