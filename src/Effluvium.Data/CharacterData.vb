Public Class CharacterData
    Implements ICharacterData

    Private store As IStore

    Public Sub New(store As IStore)
        Me.store = store
    End Sub

    Public Sub Scaffold() Implements ICharacterData.Scaffold
    End Sub
End Class
