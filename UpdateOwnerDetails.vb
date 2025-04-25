Imports MySql.Data.MySqlClient
Imports System.IO ' Required for image handling

Public Class UpdateOwnerDetails
    Private petID As Integer
    Private connectionString As String = "Server=localhost;Database=petmalu_record_system;User ID=root;Password=;"

    Public Sub New(petID As Integer)
        InitializeComponent()
        Me.petID = petID
    End Sub

    Private Sub UpdateOwnerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOwnerDetails()
    End Sub

    Private Sub LoadOwnerDetails()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT c.FullName, c.Sex, c.Phone, c.Address, c.Email, c.Photo 
                                       FROM pets_info pi 
                                       INNER JOIN clients c ON pi.ClientID = c.ClientID 
                                       WHERE pi.PetID = @PetID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@PetID", petID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            TxtName.Text = reader("FullName").ToString()
                            If reader("Sex").ToString() = "Male" Then
                                RbtnMale.Checked = True
                            ElseIf reader("Sex").ToString() = "Female" Then
                                RbtnFemale.Checked = True
                            End If
                            TxtPhone.Text = reader("Phone").ToString()
                            TxtAddress.Text = reader("Address").ToString()
                            TxtEmail.Text = reader("Email").ToString()

                            ' Load and display the owner's photo
                            If Not IsDBNull(reader("Photo")) AndAlso reader("Photo") IsNot Nothing Then
                                Dim imgBytes As Byte() = CType(reader("Photo"), Byte())
                                Using ms As New MemoryStream(imgBytes)
                                    PicBoxOwner.Image = Image.FromStream(ms)
                                End Using
                            Else
                                PicBoxOwner.Image = Nothing ' Clear the PictureBox if no photo exists
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("SQL Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim gender As String = If(RbtnMale.Checked, "Male", If(RbtnFemale.Checked, "Female", String.Empty))
                Dim query As String = "UPDATE clients SET FullName = @FullName, Sex = @Sex, Phone = @Phone, Address = @Address, Email = @Email 
                                       WHERE ClientID = (SELECT ClientID FROM pets_info WHERE PetID = @PetID)"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@FullName", TxtName.Text)
                    cmd.Parameters.AddWithValue("@Sex", gender)
                    cmd.Parameters.AddWithValue("@Phone", TxtPhone.Text)
                    cmd.Parameters.AddWithValue("@Address", TxtAddress.Text)
                    cmd.Parameters.AddWithValue("@Email", TxtEmail.Text)
                    cmd.Parameters.AddWithValue("@PetID", petID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Dim updateRecordForm As New UpdateRecordPage(petID) ' Navigate to UpdateRecordPage
            updateRecordForm.ShowDialog()
            Me.Close()
        Catch ex As MySqlException
            MessageBox.Show("SQL Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub
End Class