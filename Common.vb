Imports MySql.Data.MySqlClient

Public Class Common
    ' Shared MySQL connection object
    Public Shared MyDBConnection As MySqlConnection

    ' Shared properties to store current user information.
    Public Shared Property CurrentUserId As String
    Public Shared Property CurrentUserRole As String

    ' Function to get the database connection
    Public Shared Function getDBConnection() As MySqlConnection
        ' Always create a new connection instance.
        Return New MySqlConnection("Server=192.168.1.51;" &
                               "Database=tigris;" &
                               "User ID=eksi;" &
                               "Password=;" &
                               "Port=3306;" &
                               "Command Timeout=600;")
    End Function

    ' Log an admin action with structured parameters.
    ' Parameters:
    '  actionType - A short code or description of the action.
    '  targetId - The ID of the affected entity (user/item/transaction).
    '  targetType - The type of the affected entity.
    '  details - Additional details about the change, ideally in JSON format.
    Public Shared Sub LogAction(actionType As String, targetId As String, targetType As String, details As String)
        Dim conn As MySqlConnection = Nothing
        Try
            conn = getDBConnection()
            If conn Is Nothing Then Exit Sub

            ' Ensure the connection is open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            Dim query As String = "INSERT INTO admin_logs (admin_id, action_type, target_id, target_type, details, action_time) " &
                                  "VALUES (@adminId, @actionType, @targetId, @targetType, @details, NOW())"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@adminId", CurrentUserId)
                cmd.Parameters.AddWithValue("@actionType", actionType)
                cmd.Parameters.AddWithValue("@targetId", targetId)
                cmd.Parameters.AddWithValue("@targetType", targetType)
                cmd.Parameters.AddWithValue("@details", details)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error logging admin action: " & ex.Message)
        Finally
            ' Now conn is in scope; close it if it's open.
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


End Class
