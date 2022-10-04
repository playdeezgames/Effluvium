Namespace Effluvium.Data.Tests
    Public Class WorldDataShould
        <Fact>
        Sub TestSub()
            Dim store As New Mock(Of IStore)
            Dim subject As IWorldData = New WorldData(store.Object)
            store.VerifyNoOtherCalls()
        End Sub
    End Class
End Namespace

