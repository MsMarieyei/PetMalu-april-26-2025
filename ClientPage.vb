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

                ' Query to fetch client ID
                Dim query As String = "SELECT ClientID FROM clients WHERE FullName = @FullName  LIMIT 1"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@FullName", clientName)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            selectedClientID = Convert.ToInt32(reader("ClientID"))
                            reader.Close()
                            ' Open RecordsPage and pass ClientID
                            Dim recordsPage As New RecordsPage(selectedClientID)
                            recordsPage.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Client not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim dashboard As New DashboardPage()
        dashboard.Show()
        Me.Hide()
    End Sub
End Class
