Public Class LocationData
    Implements ILocationData

    Private store As IStore

    Public Sub New(store As IStore)
        Me.store = store
    End Sub

    Public Sub Scaffold() Implements ILocationData.Scaffold
    End Sub
End Class
