Imports MySql.Data.MySqlClient

Public Class LoginPage

    Dim connectionString As String = "Server=localhost;Database=petmalu_record_system;User ID=root;Password=;"

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim email As String = loginemail.Text
        Dim password As String = loginpassword.Text

        If String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please fill in all fields.")
        Else
            Dim query As String = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password"
            
            Try
                Using conn As New MySqlConnection(connectionString)
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@Email", email)
                        cmd.Parameters.AddWithValue("@Password", password)

                        conn.Open()
                        Dim reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then

                            reader.Close()
                            conn.Close()


                            ShowLoginNotification(New NotifyIcon()
)


                            Dim DashboardPage As New DashboardPage()
                            DashboardPage.Show()
                            Me.Hide()
                        Else

                            MessageBox.Show("Invalid email or password.")
                        End If

                        reader.Close()
                        conn.Close()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End If
    End Sub


    Private Sub ShowLoginNotification(notify As NotifyIcon)
        notify.Icon = SystemIcons.Information
        notify.BalloonTipTitle = "Login Successful!"
        notify.BalloonTipText = "You have successfully logged in."
        notify.Visible = True
        notify.ShowBalloonTip(3000)
    End Sub


    Private Sub LinkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRegister.LinkClicked
        Dim RegisterPage As New RegisterPage
        RegisterPage.Show()
        Hide()
    End Sub


    Private Sub LinkForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkForgotPassword.LinkClicked
        Dim ForgotPage As New ForgotPage()
        ForgotPage.Show()
    End Sub


    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loginpassword.PasswordChar = "*"c
    End Sub

    Private Sub LoginPage_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnLogin.PerformClick()
        End If
    End Sub

End Class

