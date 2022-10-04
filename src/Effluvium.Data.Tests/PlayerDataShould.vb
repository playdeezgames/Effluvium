Public Class PlayerDataShould
    <Fact>
    Sub ScaffoldPlayer()
        Dim store As New Mock(Of IStore)
        Dim subject As IPlayerData = New PlayerData(store.Object)
        subject.Scaffold()
        store.Verify(Sub(x) x.ExecuteNonQuery(It.IsAny(Of String)))
        store.VerifyNoOtherCalls()
    End Sub
End Class
