Public Interface IWorldData
    ReadOnly Property Character As ICharacterData
    ReadOnly Property Location As ILocationData
    ReadOnly Property Player As IPlayerData
    Sub Scaffold()
End Interface
