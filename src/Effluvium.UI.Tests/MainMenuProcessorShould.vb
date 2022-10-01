Public Class MainMenuProcessorShould
    <Fact>
    Sub AllowQuitting()
        Dim ui As New Mock(Of IUI)
        ui.Setup(Function(x) x.Prompt(It.IsAny(Of String), It.IsAny(Of String()))).Returns(QuitChoice)
        MainMenuProcessor.Run(ui.Object)
        ui.Verify(Function(x) x.Prompt(It.IsAny(Of String), It.IsAny(Of String())))
        ui.VerifyNoOtherCalls()
    End Sub
End Class
