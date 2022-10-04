Public Class CharacterDataShould
    <Fact>
    Sub ScaffoldCharacter()
        Dim store As New Mock(Of IStore)
        Dim subject As ICharacterData = New CharacterData(store.Object)
        subject.Scaffold()
        store.VerifyNoOtherCalls()
    End Sub
End Class
