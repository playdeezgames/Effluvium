Public Interface IWorldData
    Inherits IBaseData
    ReadOnly Property Character As ICharacterData
    ReadOnly Property Location As ILocationData
    ReadOnly Property Player As IPlayerData
End Interface
