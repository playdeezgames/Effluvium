Imports Microsoft.Data.Sqlite

Public Class CharacterDataShould
    <Fact>
    Sub ScaffoldCharacter()
        Dim store As New Mock(Of IStore)
        Dim subject As ICharacterData = New CharacterData(store.Object)
        subject.Scaffold()
        store.Verify(Sub(x) x.ExecuteNonQuery(It.IsAny(Of String)))
        store.VerifyNoOtherCalls()
    End Sub
End Class
