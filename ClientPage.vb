Imports MySql.Data.MySqlClient

Public Class ClientPage
    ' Updated connection string
    Dim connectionString As String = "Server=127.0.0.1;Port=3306;Database=petmalu_record_system;User ID=root;Password=;"
    Dim selectedClientID As Integer ' To store ClientID

    Private Sub ClientPage_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnEnter.PerformClick()
        End If
    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        Try
            Dim clientName As String = TxtSearch.Text.Trim()

            ' Check if input is empty
            If clientName = "" Then
                MessageBox.Show("Please enter a client name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Open MySQL connection
            Using conn As New MySqlConnection(connectionString)
                Try
                    conn.Open()
                Catch ex As MySqlException
                    MessageBox.Show("Connection Failed: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try

                ' Query to fetch all clients with the given name
                Dim query As String = "SELECT ClientID, FullName FROM clients WHERE FullName = @FullName"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@FullName", clientName)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim clients As New List(Of Tuple(Of Integer, String))()

                        While reader.Read()
                            clients.Add(New Tuple(Of Integer, String)(Convert.ToInt32(reader("ClientID")), reader("FullName").ToString()))
                        End While

                        If clients.Count = 0 Then
                            MessageBox.Show("Client not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        ElseIf clients.Count = 1 Then
                            ' If only one client is found, proceed directly
                            selectedClientID = clients(0).Item1
                            OpenRecordsPage()
                        Else
                            ' If multiple clients are found, show selection dialog
                            Dim selectionForm As New ClientSelectionPage(clients)
                            If selectionForm.ShowDialog() = DialogResult.OK Then
                                selectedClientID = selectionForm.SelectedClientID
                                OpenRecordsPage()
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

    Private Sub OpenRecordsPage()
        Dim recordsPage As New RecordsPage(selectedClientID)
        recordsPage.Show()
        Me.Hide()
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim dashboard As New DashboardPage()
        dashboard.Show()
        Me.Hide()
    End Sub
End Class