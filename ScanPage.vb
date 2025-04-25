Imports MySql.Data.MySqlClient

Public Class ScanPage
    ' MySQL Connection String
    Private connectionString As String = "Server=localhost;Database=petmalu_record_system;User ID=root;Password=;"

    ' Variable to track the currently opened ClientInfoPage
    Private currentPage As ClientInfoPage = Nothing

    ' Event handler for scanning RFID and pressing Enter
    Private Sub TxtScanNo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtScanNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim scannedID As String = TxtScanNo.Text.Trim()

            If Not String.IsNullOrEmpty(scannedID) AndAlso IsNumeric(scannedID) Then
                Dim petID As Integer = Convert.ToInt32(scannedID)

                If IsPetIDExists(petID) Then
                    SaveToDatabase(petID, "Scanned Data Here") ' Save scan history
                    OpenClientInfoPage(petID) ' Pass petID instead of clientID
                    TxtScanNo.Clear()
                Else
                    MessageBox.Show("Error: Pet ID does not exist in the database.", "Foreign Key Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Please enter a valid numeric ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    ' Function to check if Pet ID exists in the database
    Private Function IsPetIDExists(petID As Integer) As Boolean
        Try
            Using con As New MySqlConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT COUNT(*) FROM pets_info WHERE PetID = @PetID;"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@PetID", petID)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Function to fetch the correct ClientID using PetID
    Private Function GetClientIDByPetID(petID As Integer) As Integer
        Dim clientID As Integer = -1 ' Default to an invalid ID

        Dim query As String = "SELECT ClientID FROM pets_info WHERE PetID = @PetID"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@PetID", petID)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    clientID = Convert.ToInt32(reader("ClientID"))
                End If
                reader.Close()
            End Using
        End Using
        Return clientID
    End Function

    ' Function to open ClientInfoPage with the correct ClientID
    Private Sub OpenClientInfoPage(petID As Integer)
        ' Close the previously opened page if it exists
        If currentPage IsNot Nothing Then
            currentPage.Close()
            currentPage = Nothing
        End If

        ' Get the correct ClientID
        Dim clientID As Integer = GetClientIDByPetID(petID)

        If clientID = -1 Then
            MessageBox.Show("Error: No client found for this pet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Open ClientInfoPage with the correct ClientID
        currentPage = New ClientInfoPage(clientID)

        ' Ensure TxtPetIDNo is set before showing the page
        If currentPage.TxtPetIDNo IsNot Nothing Then
            currentPage.TxtPetIDNo.Text = petID.ToString()
        End If

        currentPage.Show()
    End Sub

    ' Function to save scan history in the database
    Private Sub SaveToDatabase(scannedID As Integer, scanData As String)
        Try
            Using con As New MySqlConnection(connectionString)
                con.Open()
                Dim query As String = "INSERT INTO Scanner (PetID, ScanData, ScanDate) VALUES (@PetID, @ScanData, NOW());"

                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@PetID", scannedID)
                    cmd.Parameters.AddWithValue("@ScanData", scanData)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Event handler for Back Button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim DashboardPage As New DashboardPage()
        DashboardPage.Show()
        Me.Hide()
    End Sub
End Class