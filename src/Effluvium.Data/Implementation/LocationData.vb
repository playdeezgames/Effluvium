Public Class LocationData
    Inherits BaseData
    Implements ILocationData
    Public Sub New(store As IStore)
        MyBase.New(store)
    End Sub
    Public Overrides Sub Scaffold()
        Store.ExecuteNonQuery(
            $"CREATE TABLE [{Tables.Locations}]
            (
                [{Columns.LocationIdColumn}] INTEGER PRIMARY KEY AUTOINCREMENT
            );")
    End Sub
End Class
