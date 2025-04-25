Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Printing

Public Class RecordsPage
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Private selectedClientID As Integer
    Private currentPage As Integer = 0 'Add this variable

    ' Constructor to accept the ClientID
    Public Sub New(clientID As Integer)
        InitializeComponent() ' Load form elements
        Me.selectedClientID = clientID
        currentPage = 0 ' Initialize the current page
    End Sub

    Private Sub Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection("Server=localhost;Database=petmalu_record_system;User ID=root;Password=;")
        LoadRecord()
    End Sub

    Private Sub LoadRecord()
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()
        Try
            Using cn As New MySqlConnection(connection.ConnectionString)
                cn.Open()
                Dim cm As New MySqlCommand("SELECT pi.PetID, pi.Name, pi.Sex, pi.Birthday, pi.Type, pi.Breed, pi.Color, 
                                           ps.SurgeryType, ps.SurgeryDate, d.DewormingName, pd.DewormingDate, 
                                           v.VaccineName, pv.VaccinationDate
                                    FROM pets_info pi 
                                    LEFT JOIN petsurgeries ps ON pi.PetID = ps.PetID 
                                    LEFT JOIN petdewormings pd ON pi.PetID = pd.PetID 
                                    LEFT JOIN dewormings d ON pd.DewormingID = d.DewormingID
                                    LEFT JOIN petvaccinations pv ON pi.PetID = pv.PetID 
                                    LEFT JOIN vaccines v ON pv.VaccineID = v.VaccineID 
                                    INNER JOIN clients c ON pi.ClientID = c.ClientID 
                                    WHERE c.ClientID = @ClientID;", cn)
                cm.Parameters.AddWithValue("@ClientID", selectedClientID)
                Dim dr As MySqlDataReader = cm.ExecuteReader()
                While dr.Read()
                    i += 1
                    DataGridView1.Rows.Add(i, dr.Item("PetID").ToString, dr.Item("Name").ToString, dr.Item("Sex").ToString, dr.Item("Birthday").ToString, dr.Item("Type").ToString, dr.Item("Breed").ToString, dr.Item("Color").ToString, dr.Item("SurgeryType").ToString, dr.Item("SurgeryDate").ToString, dr.Item("DewormingName").ToString, dr.Item("DewormingDate").ToString, dr.Item("VaccineName").ToString, dr.Item("VaccinationDate").ToString)
                End While
                dr.Close()
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim petID As Integer = selectedRow.Cells("Column2").Value
            Dim updateForm As New UpdateOwnerDetails(petID)
            updateForm.ShowDialog()
            Records_Load(sender, e)
        Else
            MessageBox.Show("Please select a record to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            ' Ensure the column name matches the DataGridView column name
            Dim petID As Integer = selectedRow.Cells("Column2").Value

            Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmResult = DialogResult.Yes Then
                Try
                    connection.Open()
                    Dim query As String = "DELETE FROM pets_info WHERE PetID = @PetID"
                    Dim cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@PetID", petID)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Records_Load(sender, e)
                Catch ex As MySqlException
                    MessageBox.Show("SQL Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Catch ex As Exception
                    MessageBox.Show("Unexpected Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If connection.State = ConnectionState.Open Then
                        connection.Close()
                    End If
                End Try
            End If
        Else
            MessageBox.Show("Please select a record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Print Records
    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        ' Allow the user to choose paper size
        Dim paperSizeDialog As New PrintDialog()
        paperSizeDialog.Document = PrintDocument1
        If paperSizeDialog.ShowDialog() = DialogResult.OK Then
            ' Set the selected printer settings
            PrintDocument1.PrinterSettings = paperSizeDialog.PrinterSettings
        End If

        ' Optionally set the paper size manually
        For Each paperSize As PaperSize In PrintDocument1.PrinterSettings.PaperSizes
            If paperSize.PaperName = "Legal" Then
                PrintDocument1.DefaultPageSettings.PaperSize = paperSize
            End If
        Next

        ' Show print preview
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontTitle As New Font("Arial", 20, FontStyle.Bold)
        Dim fontSubTitle As New Font("Arial", 14, FontStyle.Bold)
        Dim fontBody As New Font("Arial", 12, FontStyle.Regular)
        Dim brush As New SolidBrush(Color.Black)
        Dim startX As Integer = 50
        Dim startY As Integer = 50
        Dim lineSpacing As Integer = 25

        ' Define positions
        Dim logoX As Integer = 50
        Dim logoY As Integer = 50
        Dim logoWidth As Integer = 150
        Dim logoHeight As Integer = 150
        Dim textX As Integer = logoX + logoWidth + 20 ' Position text beside logo
        Dim textY As Integer = logoY + 20 ' Align text slightly lower than logo

        Try
            Dim logoPath As String = "C:\Users\joanna\source\repos\PETMALU\PetMalu_Records_System\Image\petmalu logo.png" ' Change this to the correct path
            If System.IO.File.Exists(logoPath) Then
                Dim logo As Image = Image.FromFile(logoPath)
                e.Graphics.DrawImage(logo, logoX, logoY, logoWidth, logoHeight) ' Adjust size and position
                startY += 150 ' Move text below logo
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading logo: " & ex.Message, "Logo Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        e.Graphics.DrawString("PetMalu Animal Clinic", fontTitle, brush, textX, textY + 30)
        e.Graphics.DrawString("J.P. Rizal St., cor E. Aguinaldo St., Sta. Lucia, Novaliches, ", fontBody, brush, textX, textY + 70)
        e.Graphics.DrawString("Quezon City, Philippines", fontBody, brush, textX, textY + 90)

        ' Fetch pet and owner details from the database
        Dim petName, petID, petSex, petBirthday, petType, petBreed, petColor, ownerName, ownerSex, ownerPhone, ownerAddress, ownerEmail As String
        Dim vaccines, dewormings, surgeries As String

        Try
            connection.Open()
            Dim query As String = "SELECT pi.PetID, pi.Name, pi.Sex, pi.Birthday, pi.Type, pi.Breed, pi.Color, 
                                         GROUP_CONCAT(DISTINCT CONCAT(v.VaccineName, ' (', pv.VaccinationDate, ')') SEPARATOR ', ') AS Vaccines, 
                                         GROUP_CONCAT(DISTINCT CONCAT(d.DewormingName, ' (', pd.DewormingDate, ')') SEPARATOR ', ') AS Dewormings, 
                                         GROUP_CONCAT(DISTINCT CONCAT(ps.SurgeryType, ' (', ps.SurgeryDate, ')') SEPARATOR ', ') AS Surgeries,
                                         c.FullName, c.Sex AS OwnerSex, c.Phone, c.Address, c.Email 
                                  FROM pets_info pi 
                                  LEFT JOIN petvaccinations pv ON pi.PetID = pv.PetID 
                                  LEFT JOIN vaccines v ON pv.VaccineID = v.VaccineID 
                                  LEFT JOIN petdewormings pd ON pi.PetID = pd.PetID 
                                  LEFT JOIN dewormings d ON pd.DewormingID = d.DewormingID 
                                  LEFT JOIN petsurgeries ps ON pi.PetID = ps.PetID
                                  INNER JOIN clients c ON pi.ClientID = c.ClientID 
                                  WHERE c.ClientID = @ClientID
                                  GROUP BY pi.PetID
                                  LIMIT @Page, 1;" ' Fetch one pet per page
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@ClientID", selectedClientID)
            cmd.Parameters.AddWithValue("@Page", currentPage)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                petID = reader("PetID").ToString()
                petName = reader("Name").ToString()
                petSex = reader("Sex").ToString()
                petBirthday = reader("Birthday").ToString()
                petType = reader("Type").ToString()
                petBreed = reader("Breed").ToString()
                petColor = reader("Color").ToString()
                vaccines = If(IsDBNull(reader("Vaccines")), "None", reader("Vaccines").ToString())
                dewormings = If(IsDBNull(reader("Dewormings")), "None", reader("Dewormings").ToString())
                surgeries = If(IsDBNull(reader("Surgeries")), "None", reader("Surgeries").ToString())
                ownerName = reader("FullName").ToString()
                ownerSex = reader("OwnerSex").ToString()
                ownerPhone = reader("Phone").ToString()
                ownerAddress = reader("Address").ToString()
                ownerEmail = reader("Email").ToString()
            End If
            reader.Close()
        Catch ex As MySqlException
            MessageBox.Show("SQL Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try

        ' Print Pet Information
        startY += lineSpacing * 3
        e.Graphics.DrawString("PET INFORMATION", fontSubTitle, brush, startX, startY)
        startY += lineSpacing
        e.Graphics.DrawString("Name: " & petName, fontBody, brush, startX, startY)
        startY += lineSpacing
        e.Graphics.DrawString("Pet ID: " & petID, fontBody, brush, startX, startY)
        startY += lineSpacing
        e.Graphics.DrawString("Sex: " & petSex, fontBody, brush, startX, startY)
        startY += lineSpacing
        e.Graphics.DrawString("Birthday: " & petBirthday, fontBody, brush, startX, startY)
        startY += lineSpacing
        e.Graphics.DrawString("Type of Pet: " & petType, fontBody, brush, startX, startY)
        startY += lineSpacing
        e.Graphics.DrawString("Breed: " & petBreed, fontBody, brush, startX, startY)
        startY += lineSpacing
        e.Graphics.DrawString("Color: " & petColor, fontBody, brush, startX, startY)
        startY += lineSpacing
        e.Graphics.DrawString("Vaccines: " & vaccines, fontBody, brush, startX, startY)
        startY += lineSpacing
        e.Graphics.DrawString("Dewormings: " & dewormings, fontBody, brush, startX, startY)
        startY += lineSpacing
        e.Graphics.DrawString("Surgery: " & surgeries, fontBody, brush, startX, startY)

        ' Print Owner Information
        startY += lineSpacing * 4
        e.Graphics.DrawString("OWNER INFORMATION", fontSubTitle, brush, startX, startY)
        startY += lineSpacing
        e.Graphics.DrawString("Name: " & ownerName, fontBody, brush, startX, startY)
        startY += lineSpacing
        e.Graphics.DrawString("Sex: " & ownerSex, fontBody, brush, startX, startY)
        startY += lineSpacing
        e.Graphics.DrawString("Phone No.: " & ownerPhone, fontBody, brush, startX, startY)
        startY += lineSpacing
        e.Graphics.DrawString("Address: " & ownerAddress, fontBody, brush, startX, startY)
        startY += lineSpacing
        e.Graphics.DrawString("Email: " & ownerEmail, fontBody, brush, startX, startY)

        ' Check if there are more pages to print
        connection.Open()
        Dim cmdCount As New MySqlCommand("SELECT COUNT(*) FROM pets_info WHERE ClientID = @ClientID", connection)
        cmdCount.Parameters.AddWithValue("@ClientID", selectedClientID)
        Dim petCount As Integer = Convert.ToInt32(cmdCount.ExecuteScalar())
        connection.Close()

        currentPage += 1
        If currentPage < petCount Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentPage = 0 ' Reset for the next print job
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim ClientPage As New ClientPage()
        ClientPage.Show()
        Me.Hide()
    End Sub

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        Dim petRegistrationForm As New PetRegistrationPage(selectedClientID)
        petRegistrationForm.ShowDialog()
        Records_Load(sender, e)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class