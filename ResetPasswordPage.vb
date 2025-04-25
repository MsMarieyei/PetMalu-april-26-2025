Imports MySql.Data.MySqlClient

Public Class ResetPasswordPage
    Dim connectionString As String = "Server=localhost;Database=petmalu_record_system;User ID=root;Password=;"
    Private token As String

    Private Sub ResetPasswordPage_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSubmit.PerformClick()
        End If
    End Sub

    Public Sub New(ByVal resetToken As String)
        InitializeComponent()
        token = resetToken
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim newPassword As String = TxtNewPassword.Text
        Dim reEnterPassword As String = TxtReEnterPassword.Text

        If String.IsNullOrEmpty(newPassword) Or String.IsNullOrEmpty(reEnterPassword) Then
            MessageBox.Show("All fields are required.")
        ElseIf newPassword <> reEnterPassword Then
            MessageBox.Show("Passwords do not match.")
        Else
            Dim query As String = "SELECT * FROM Users WHERE ResetToken = @Token AND TokenExpiry > @Now"
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Token", token)
                    cmd.Parameters.AddWithValue("@Now", DateTime.Now)
                    conn.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        reader.Close()
                        Dim updateQuery As String = "UPDATE Users SET Password = @Password, ResetToken = NULL, TokenExpiry = NULL WHERE ResetToken = @Token"
                        Using updateCmd As New MySqlCommand(updateQuery, conn)
                            updateCmd.Parameters.AddWithValue("@Password", newPassword)
                            updateCmd.Parameters.AddWithValue("@Token", token)
                            updateCmd.ExecuteNonQuery()
                        End Using
                        MessageBox.Show("Password has been reset successfully.")
                        Me.Close()
                        ' Optionally, redirect back to the login form or main application form
                    Else
                        MessageBox.Show("Invalid or expired token.")
                    End If
                    conn.Close()
                End Using
            End Using
        End If
    End Sub

    Private Sub TxtReEnterPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtReEnterPassword.TextChanged

    End Sub
End Class