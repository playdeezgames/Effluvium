Public Class MainMenuProcessorShould
    <Fact>
    Sub AllowQuitting()
        Dim ui As New Mock(Of IUI)
        MainMenuProcessor.Run(ui.Object)
        ui.VerifyNoOtherCalls()
    End Sub
End Class
