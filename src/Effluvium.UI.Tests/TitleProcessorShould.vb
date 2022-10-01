Namespace Effluvium.UI.Tests
    Public Class TitleProcessorShould
        <Fact>
        Sub GiveAWelcomeMessage()
            Dim ui As New Mock(Of IUI)
            TitleProcessor.Run(ui.Object)
            ui.Verify(Sub(x) x.WriteLine(It.IsAny(Of String)))
            ui.VerifyNoOtherCalls()
        End Sub
    End Class
End Namespace

