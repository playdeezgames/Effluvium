Public Class CharacterData
    Inherits BaseData
    Implements ICharacterData
    Public Sub New(store As IStore)
        MyBase.New(store)
    End Sub
    Public Overrides Sub Scaffold()
        Store.ExecuteNonQuery(
            $"CREATE TABLE [{Tables.Characters}]
            (
                [{Columns.CharacterIdColumn}] INTEGER PRIMARY KEY AUTOINCREMENT,
                [{Columns.LocationIdColumn}] INT NOT NULL,
                FOREIGN KEY ([{Columns.LocationIdColumn}]) REFERENCES [{Tables.Locations}]([{Columns.LocationIdColumn}])
            );")
    End Sub
End Class
