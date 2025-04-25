Imports MySql.Data.MySqlClient
Imports System.IO

Public Class OwnerRegistrationPage
    Dim connectionString As String = "Server=127.0.0.1;Port=3306;Database=petmalu_record_system;User ID=root;Password=;"

    ' Allow only numeric input in TxtPhone and limit to 11 digits
    Private Sub TxtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone.KeyPress
        ' Check if the entered key is a number or control key (e.g., backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

        ' Prevent further input if the length is already 11
        If Char.IsDigit(e.KeyChar) AndAlso TxtPhone.Text.Length >= 11 Then
            e.Handled = True
        End If
    End Sub


    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click

        If TxtPhone.Text.Length <> 11 Then
            MessageBox.Show("Phone number must be exactly 11 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtPhone.Focus()
            Return
        End If

        Dim FullName As String = TxtName.Text
        Dim address As String = TxtAddress.Text
        Dim phone As String = TxtPhone.Text
        Dim email As String = TxtEmail.Text

        Dim sex As String = ""
        If RbtnMale.Checked Then
            sex = "Male"
        ElseIf RbtnFemale.Checked Then
            sex = "Female"
        Else
            MessageBox.Show("Please select a sex.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrEmpty(FullName) OrElse String.IsNullOrEmpty(address) OrElse
            String.IsNullOrEmpty(phone) OrElse String.IsNullOrEmpty(email) Then
            MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not email.Contains("@") Or Not email.Contains(".") Then
            MessageBox.Show("Please enter a valid email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim photo As Byte() = Nothing
        If PicBoxClient.Image IsNot Nothing Then
            photo = ConvertImageToByteArray(PicBoxClient.Image)
        Else
            MessageBox.Show("Please upload a profile picture.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "INSERT INTO Clients (FullName, Address, Phone, Email, Photo, Sex) VALUES (@FullName, @Address, @Phone, @Email, @Photo, @Sex); SELECT LAST_INSERT_ID();"

        Try
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@FullName", FullName)
                    cmd.Parameters.AddWithValue("@Address", address)
                    cmd.Parameters.AddWithValue("@Phone", phone)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@Photo", photo)
                    cmd.Parameters.AddWithValue("@Sex", sex)

                    conn.Open()
                    Dim ownerId As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    conn.Close()

                    MessageBox.Show("Client information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim PetInfo2 As New PetRegistrationPage(ownerId) ' Pass the clientID here
                    PetInfo2.Show()
                    Me.Hide()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ConvertImageToByteArray(image As Image) As Byte()
        Dim photo As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, image.RawFormat)
            photo = ms.ToArray()
        End Using
        Return photo
    End Function

    Private Sub BtnUploadPhoto_Click(sender As Object, e As EventArgs) Handles BtnUploadPhoto.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                PicBoxClient.Image = Image.FromFile(openFileDialog.FileName)
                PicBoxClient.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Using
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim dashboard As New DashboardPage()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub ClearFields()
        TxtName.Clear()
        TxtAddress.Clear()
        TxtPhone.Clear()
        TxtEmail.Clear()
        PicBoxClient.Image = Nothing
    End Sub

    Private Sub PetInfoPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class