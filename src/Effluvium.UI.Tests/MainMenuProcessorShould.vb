Public Class MainMenuProcessorShould
    <Fact>
    Sub AllowQuitting()
        Dim ui As New Mock(Of IUI)
        Dim promptResults As New Queue(Of String)(New List(Of String) From {QuitChoice, YesChoice})
        ui.Setup(
            Function(x) x.Prompt(It.IsAny(Of String), It.IsAny(Of String()))).
            Returns(Function(a, b) promptResults.Dequeue())
        MainMenuProcessor.Run(ui.Object)
        ui.Verify(Function(x) x.Prompt(It.IsAny(Of String), It.IsAny(Of String())))
        ui.VerifyNoOtherCalls()
    End Sub
End Class
