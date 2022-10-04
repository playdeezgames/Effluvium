Public Class PlayerData
    Inherits BaseData
    Implements IPlayerData
    Public Sub New(store As IStore)
        MyBase.New(store)
    End Sub
    Public Overrides Sub Scaffold()
        Store.ExecuteNonQuery(
            $"CREATE TABLE [{Tables.Players}]
            (
                [{Columns.LocationIdColumn}] INTEGER PRIMARY KEY AUTOINCREMENT
            );")
    End Sub
End Class
