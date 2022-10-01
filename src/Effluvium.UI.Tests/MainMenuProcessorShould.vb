Public Class MainMenuProcessorShould
    Inherits BaseProcessorTest
    <Fact>
    Sub AllowQuitting()
        Dim ui As New Mock(Of IUI)
        SetupPrompt(ui, QuitChoice, YesChoice)
        MainMenuProcessor.Run(ui.Object)
        ui.Verify(Function(x) x.Prompt(It.IsAny(Of String), It.IsAny(Of String())))
        ui.VerifyNoOtherCalls()
    End Sub
End Class
