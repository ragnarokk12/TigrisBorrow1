Imports MySql.Data.MySqlClient

Public Class Common
    ' Shared MySQL connection object
    Public Shared MyDBConnection As MySqlConnection

    ' Function to get the database connection
    Public Shared Function getDBConnection() As MySqlConnection
        If MyDBConnection Is Nothing Then
            MyDBConnection = New MySqlConnection(
                "Server=192.168.1.51;" &  ' Change to your server (e.g., "10.1.139.203" for remote)
                "Database=tigris;" &  ' Your database name
                "User ID=eksi;" &  ' Your MySQL username
                "Password=;" &  ' Your MySQL password
                "Port=3306;" &  ' MySQL port
                "Command Timeout=600;")
        End If
        Return MyDBConnection
    End Function
End Class