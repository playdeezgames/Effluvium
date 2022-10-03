Public Class StartGameProcessorShould
    Inherits BaseProcessorTest
    <Fact>
    Sub CreateAWorld()
        WithUI(
            Sub(ui, world)
                StartGameProcessor.Run(ui.Object, world.Object)
                world.Verify(Sub(x) x.Start())
            End Sub)
    End Sub
End Class
