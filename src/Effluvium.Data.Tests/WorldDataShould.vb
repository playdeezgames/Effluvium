Namespace Effluvium.Data.Tests
    Public Class WorldDataShould
        <Fact>
        Sub ScaffoldTables()
            Dim store As New Mock(Of IStore)
            Dim subject As IWorldData = New WorldData(store.Object)
            subject.Scaffold()
            store.VerifyNoOtherCalls()
        End Sub
    End Class
End Namespace

