Namespace Effluvium.UI.Tests
    Public Class TitleProcessorShould
        <Fact>
        Sub GiveAWelcomeMessageAndProceedToTheMainMenu()
            Dim ui As New Mock(Of IUI)
            Dim promptResults As New Queue(Of String)(New List(Of String) From {OkChoice, QuitChoice, YesChoice})
            ui.Setup(
            Function(x) x.Prompt(It.IsAny(Of String), It.IsAny(Of String()))).
                Returns(Function(a, b) promptResults.Dequeue())
            TitleProcessor.Run(ui.Object)
            ui.Verify(Sub(x) x.Clear())
            ui.Verify(Sub(x) x.WriteLine(It.IsAny(Of String)))
            ui.Verify(Function(x) x.Prompt(It.IsAny(Of String), It.IsAny(Of String())))
            ui.VerifyNoOtherCalls()
        End Sub
    End Class
End Namespace

