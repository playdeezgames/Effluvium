Public MustInherit Class BaseProcessorTest
    Protected Sub SetupPrompt(ui As Mock(Of IUI), ParamArray choices As String())
        Dim promptResults As New Queue(Of String)(choices)
        ui.Setup(
            Function(x) x.Prompt(It.IsAny(Of String), It.IsAny(Of String()))).
            Returns(Function(a, b) promptResults.Dequeue())
    End Sub
    Protected Sub VerifyPrompt(ui As Mock(Of IUI))
        ui.Verify(Function(x) x.Prompt(It.IsAny(Of String), It.IsAny(Of String())))
    End Sub
    Protected Sub WithUI(stuffToDo As Action(Of Mock(Of IUI)))
        Dim ui As New Mock(Of IUI)
        stuffToDo(ui)
        ui.VerifyNoOtherCalls()
    End Sub
End Class
