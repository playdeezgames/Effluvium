Namespace Effluvium.Game.Tests
    Public Class WorldShould
        <Fact>
        Sub ScaffoldTheWorld()
            Dim worldData As New Mock(Of IWorldData)
            Dim subject As IWorld = New World(worldData.Object)
            subject.Scaffold()
            worldData.Verify(Sub(x) x.Scaffold())
            worldData.VerifyNoOtherCalls()
        End Sub
    End Class
End Namespace

