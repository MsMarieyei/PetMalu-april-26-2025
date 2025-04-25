Imports MySql.Data.MySqlClient

Public Class RegisterPage

    Dim connectionString As String = "Server=localhost;Database=petmalu_record_system;User ID=root;Password=;"

    Private Sub RegisterPage_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnRegister.PerformClick()
        End If
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim name As String = txtname.Text
        Dim email As String = txtemail.Text
        Dim phone As String = txtphone.Text
        Dim password As String = txtpassword.Text


        If String.IsNullOrWhiteSpace(name) Or String.IsNullOrWhiteSpace(email) Or
           String.IsNullOrWhiteSpace(phone) Or String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        If Not email.Contains("@"c) Or Not email.Contains("."c) Then
            MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim query As String = "INSERT INTO Users (Name, Email, Phone, Password) VALUES (@Name, @Email, @Phone, @Password)"

        Try
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@Name", name)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@Phone", phone)
                    cmd.Parameters.AddWithValue("@Password", password)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()

                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    Dim LoginPage As New LoginPage()
                    LoginPage.Show()
                    Me.Close()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim LoginPage As New LoginPage()
        LoginPage.Show()
        Me.Hide()
    End Sub

    Private Sub RegisterPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtemail_TextChanged(sender As Object, e As EventArgs) Handles txtemail.TextChanged

    End Sub
End Class
