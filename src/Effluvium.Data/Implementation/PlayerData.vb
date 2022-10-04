Public Class PlayerData
    Implements IPlayerData

    Private store As IStore

    Public Sub New(store As IStore)
        Me.store = store
    End Sub

    Public Sub Scaffold() Implements IPlayerData.Scaffold
    End Sub
End Class
