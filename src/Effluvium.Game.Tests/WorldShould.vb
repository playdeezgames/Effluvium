Namespace Effluvium.Game.Tests
    Public Class WorldShould
        <Fact>
        Sub StartANewGame()
            Dim worldData As New Mock(Of IWorldData)
            Dim subject As IWorld = New World(worldData.Object)
            subject.Start()
            worldData.VerifyNoOtherCalls()
        End Sub
    End Class
End Namespace

