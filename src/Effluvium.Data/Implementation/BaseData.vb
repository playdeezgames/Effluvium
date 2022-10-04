Public MustInherit Class BaseData
    Implements IBaseData
    Protected ReadOnly Store As IStore
    Sub New(store As IStore)
        Me.Store = store
    End Sub
    Public MustOverride Sub Scaffold() Implements IBaseData.Scaffold
End Class
