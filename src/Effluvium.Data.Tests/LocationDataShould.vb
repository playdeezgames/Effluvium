Public Class LocationDataShould
    <Fact>
    Sub ScaffoldLocation()
        Dim store As New Mock(Of IStore)
        Dim subject As ILocationData = New LocationData(store.Object)
        subject.Scaffold()
        store.Verify(Sub(x) x.ExecuteNonQuery(It.IsAny(Of String)))
        store.VerifyNoOtherCalls()
    End Sub

End Class
