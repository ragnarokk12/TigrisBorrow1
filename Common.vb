Imports MySql.Data.MySqlClient

Public Class Common
    ' Shared MySQL connection object
    Public Shared MyDBConnection As MySqlConnection

    ' Function to get the database connection
    Public Shared Function getDBConnection() As MySqlConnection
        If MyDBConnection Is Nothing Then
            MyDBConnection = New MySqlConnection(
                "Server=172.20.10.2;" &  ' Change to your server (e.g., "10.1.139.203" for remote)
                "Database=tigris_db;" &  ' Your database name
                "User ID=tigrisborrow_admin;" &  ' Your MySQL username
                "Password=GGyypp15922@;" &  ' Your MySQL password
                "Port=3306;" &  ' MySQL port
                "Command Timeout=600;")
        End If
        Return MyDBConnection
    End Function
End Class
