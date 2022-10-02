Public Class MainMenuProcessorShould
    Inherits BaseProcessorTest
    <Fact>
    Sub AllowQuitting()
        Dim ui As New Mock(Of IUI)
        SetupPrompt(ui, QuitChoice, YesChoice)
        MainMenuProcessor.Run(ui.Object)
        VerifyPrompt(ui)
        ui.VerifyNoOtherCalls()
    End Sub
End Class
