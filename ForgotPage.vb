Imports MySql.Data.MySqlClient

Imports System.Net.Mail

Public Class ForgotPage
    Dim connectionString As String = "Server=localhost;Database=petmalu_record_system;User ID=root;Password=;"

    Private Sub ForgotPage_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnResetPassword.PerformClick()
        End If
    End Sub

    Private Sub BtnResetPassword_Click(sender As Object, e As EventArgs) Handles BtnResetPassword.Click
        Dim email As String = txtemail.Text

        If String.IsNullOrEmpty(email) Then
            MessageBox.Show("Please enter your email address.")
        Else
            Dim query As String = "SELECT * FROM Users WHERE Email = @Email"
            Try
                Using conn As New MySqlConnection(connectionString)
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@Email", email)
                        conn.Open()
                        Dim reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Close()
                            Dim token As String = GenerateToken()
                            StoreToken(email, token)
                            SendResetEmail(email, token)
                            MessageBox.Show("A password reset link has been sent to your email.")
                            ' Redirect to ResetPassword form with the token
                            Dim resetPasswordForm As New ResetPasswordPage(token)
                            resetPasswordForm.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Email address not found.")
                        End If
                        conn.Close()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
    End Sub

    Private Function GenerateToken() As String
        Dim chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim random As New Random()
        Return New String(Enumerable.Repeat(chars, 32).Select(Function(s) s(random.Next(s.Length))).ToArray())
    End Function

    Private Sub StoreToken(email As String, token As String)
        Dim query As String = "UPDATE Users SET ResetToken = @Token, TokenExpiry = @Expiry WHERE Email = @Email"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Token", token)
                cmd.Parameters.AddWithValue("@Expiry", DateTime.Now.AddHours(1)) ' Token valid for 1 hour
                cmd.Parameters.AddWithValue("@Email", email)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using
    End Sub

    Private Sub SendResetEmail(email As String, token As String)
        Try
            Dim smtpClient As New SmtpClient("smtp.gmail.com") With {
                .Port = 587,
                .Credentials = New Net.NetworkCredential("resetpass.2025@gmail.com", "qqvm bdjg ggrz jogf"),
                .EnableSsl = True
            }

            Dim mail As New MailMessage() With {
                .From = New MailAddress("resetpass.2025@gmail.com"),
                .Subject = "Password Reset",
                .Body = $"Your password reset process has started. Please open the application to reset your password."
            }
            mail.To.Add(email)

            smtpClient.Send(mail)
        Catch ex As Exception
            MessageBox.Show("Failed to send email: " & ex.Message)
        End Try
    End Sub

    Private Sub ForgotPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class