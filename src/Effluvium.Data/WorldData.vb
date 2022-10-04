Public Class WorldData
    Implements IWorldData
    Private ReadOnly Store As IStore
    Sub New(store As IStore)
        Me.Store = store
        Character = New CharacterData(store)
        Location = New LocationData(store)
        Player = New PlayerData(store)
    End Sub
    Public ReadOnly Property Character As ICharacterData Implements IWorldData.Character
    Public ReadOnly Property Location As ILocationData Implements IWorldData.Location
    Public ReadOnly Property Player As IPlayerData Implements IWorldData.Player
    Public Sub Scaffold() Implements IWorldData.Scaffold
        Location.Scaffold()
        Character.Scaffold()
        Player.Scaffold()
    End Sub
End Class
