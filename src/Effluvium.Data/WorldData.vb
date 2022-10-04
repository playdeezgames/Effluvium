Public Class WorldData
    Implements IWorldData
    Private ReadOnly Store As IStore
    Sub New(store As IStore)
        Me.Store = store
    End Sub
End Class
