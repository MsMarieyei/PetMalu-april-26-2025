Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class HistoryPage

    Private connectionString As String = "Server=localhost;Database=petmalu_record_system;User ID=root;Password=;"

    Private Sub HistoryPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Date.Today
        LoadRecord()
    End Sub

    Private Sub LoadRecord(Optional ByVal selectedDate As String = "")
        Dim i As Integer = 0
        DataGridView1.Rows.Clear()
        Try
            Using cn As New MySqlConnection(connectionString)
                cn.Open()
                Dim query As String = "SELECT scanner.ID, scanner.ScanDate, pets_info.PetID, pets_info.Name, clients.FullName " &
                                      "FROM scanner " &
                                      "JOIN pets_info ON scanner.PetID = pets_info.PetID " &
                                      "JOIN clients ON pets_info.ClientID = clients.ClientID"

                If Not String.IsNullOrEmpty(selectedDate) Then
                    query &= " WHERE DATE(scanner.ScanDate) = @selectedDate"
                End If

                Dim cm As New MySqlCommand(query, cn)
                If Not String.IsNullOrEmpty(selectedDate) Then
                    cm.Parameters.AddWithValue("@selectedDate", selectedDate)
                End If

                Dim dr As MySqlDataReader = cm.ExecuteReader()
                While dr.Read()
                    i += 1
                    DataGridView1.Rows.Add(i, dr.Item("ID").ToString, dr.Item("ScanDate").ToString, dr.Item("PetID").ToString, dr.Item("Name").ToString, dr.Item("FullName").ToString)
                End While
                dr.Close()
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim selectedDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        LoadRecord(selectedDate)
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim DashboardPage As New DashboardPage()
        DashboardPage.Show()
        Me.Hide()
    End Sub

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
        Dim eGraphics As Graphics = e.Graphics
        Dim fontTitle As New Font("Arial", 16, FontStyle.Bold)
        Dim fontSubTitle As New Font("Arial", 12, FontStyle.Regular)
        Dim fontHeader As New Font("Arial", 10, FontStyle.Bold)
        Dim fontContent As New Font("Arial", 10, FontStyle.Regular)
        Dim brush As New SolidBrush(Color.Black)
        Dim yPos As Integer = 50
        Dim xPos As Integer = 50
        Dim logoPath As String = "C:\Users\joanna\source\repos\PETMALU\PetMalu_Records_System\Image\petmalu logo.png"
        Static rowIndex As Integer = 0

        Try
            ' Draw Logo
            If System.IO.File.Exists(logoPath) Then
                Dim logo As Image = Image.FromFile(logoPath)
                eGraphics.DrawImage(logo, xPos, yPos, 150, 150) ' Adjust size as needed
            End If

            ' Clinic Name & Address
            eGraphics.DrawString("PetMalu Animal Clinic", fontTitle, brush, xPos + 180, yPos + 50)
            eGraphics.DrawString("J.P. Rizal St., cor E. Aguinaldo St., Sta. Lucia, Novaliches,", fontSubTitle, brush, xPos + 180, yPos + 90)
            eGraphics.DrawString("Quezon City, Philippines", fontSubTitle, brush, xPos + 180, yPos + 110)

            ' Draw Section Title
            yPos += 180
            eGraphics.DrawString("Scan Record", fontTitle, brush, xPos, yPos)
            yPos += 40

            ' Draw Table Headers
            Dim headers() As String = {"No.", "ScanID", "Scanned Date", "PetID", "Full Name"}
            Dim columnWidths() As Integer = {80, 200, 150, 150, 200} ' Adjust column sizes
            Dim xOffset As Integer = xPos

            For i As Integer = 0 To headers.Length - 1
                eGraphics.DrawString(headers(i), fontHeader, brush, xOffset, yPos)
                xOffset += columnWidths(i)
            Next

            yPos += 30 ' Move to the next row

            ' Fetch Data from DataGridView
            While rowIndex < DataGridView1.Rows.Count - 1
                xOffset = xPos
                For i As Integer = 0 To headers.Length - 1
                    Dim value As String = DataGridView1.Rows(rowIndex).Cells(i).Value.ToString()
                    eGraphics.DrawString(value, fontContent, brush, xOffset, yPos)
                    xOffset += columnWidths(i)
                Next
                yPos += 25 ' Move to the next row

                ' Check if the next row will fit on the page
                If yPos + 25 > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    rowIndex += 1 ' Continue from next row on the next page
                    Exit Sub
                End If

                rowIndex += 1
            End While

            ' If all rows are printed, indicate that there are no more pages
            e.HasMorePages = False
            rowIndex = 0 ' Reset rowIndex for next print job

        Catch ex As Exception
            MessageBox.Show("Error in printing: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class