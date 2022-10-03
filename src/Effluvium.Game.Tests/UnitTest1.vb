Namespace Effluvium.Game.Tests
    Public Class WorldShould
        <Fact>
        Sub StartANewGame()
            Dim subject As IWorld = New World()
            subject.Start()
        End Sub
    End Class
End Namespace

