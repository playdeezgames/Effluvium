Imports Shouldly

Namespace Effluvium.Data.Tests
    Public Class WorldDataShould
        <Fact>
        Sub ScaffoldTables()
            Dim store As New Mock(Of IStore)
            Dim subject As IWorldData = New WorldData(store.Object)
            subject.Scaffold()
            store.VerifyNoOtherCalls()
        End Sub
        <Fact>
        Sub HaveAllSubobjects()
            Dim store As New Mock(Of IStore)
            Dim subject As IWorldData = New WorldData(store.Object)
            subject.Character.ShouldNotBeNull
            subject.Location.ShouldNotBeNull
            subject.Player.ShouldNotBeNull
            store.VerifyNoOtherCalls()
        End Sub
    End Class
End Namespace

