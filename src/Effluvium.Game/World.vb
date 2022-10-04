Imports Effluvium.Data
Public Class World
    Implements IWorld
    Private ReadOnly WorldData As IWorldData
    Sub New(worldData As IWorldData)
        Me.WorldData = worldData
    End Sub
    Public Sub Scaffold() Implements IWorld.Scaffold
        WorldData.Scaffold()
    End Sub
End Class
