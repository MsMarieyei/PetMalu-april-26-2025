Imports MySql.Data.MySqlClient
Imports System.IO

Public Class ClientInfoPage
    Dim connectionString As String = "Server=localhost;Database=petmalu_record_system;User ID=root;Password=;"
    Dim clientID As Integer

    Public Sub New(clientID As Integer)
        InitializeComponent()
        Me.clientID = clientID
    End Sub

    Private Sub ClientInfoPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClientInfo(clientID)
        LoadPetInfo()
        LoadDewormingInfo()
        LoadVaccinationInfo()
        LoadSurgeryInfo()
    End Sub


    ' Fetch Pet Details
    Private Sub LoadPetInfo()
        If String.IsNullOrWhiteSpace(TxtPetIDNo.Text) Then Return
        Dim query As String = "SELECT PetID, Name, Birthday, Color, Breed, Sex, Type, Photo FROM pets_info WHERE PetID = @PetID"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@PetID", TxtPetIDNo.Text)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    TxtPetIDNo.Text = reader("PetID").ToString()
                    TxtName.Text = reader("Name").ToString()
                    DtpBirthday.Value = DateTime.Parse(reader("Birthday").ToString())
                    TxtColor.Text = reader("Color").ToString()
                    TxtBreed.Text = reader("Breed").ToString()
                    TxtType.Text = reader("Type").ToString()
                    TxtSex.Text = reader("Sex").ToString()

                    ' Display pet photo
                    If Not IsDBNull(reader("Photo")) Then
                        Dim imgBytes As Byte() = CType(reader("Photo"), Byte())
                        If imgBytes IsNot Nothing AndAlso imgBytes.Length > 0 Then
                            Using ms As New MemoryStream(imgBytes)
                                PicBoxPet.Image = Image.FromStream(ms)
                            End Using
                        Else
                            PicBoxPet.Image = Nothing
                        End If
                    End If
                End If
                reader.Close()
            End Using
        End Using
    End Sub

    ' Fetch Deworming Details
    Private Sub LoadDewormingInfo()
        If String.IsNullOrWhiteSpace(TxtPetIDNo.Text) Then Return
        Dim query As String = "SELECT d.DewormingName FROM petdewormings pd JOIN dewormings d ON pd.DewormingID = d.DewormingID WHERE pd.PetID = @PetID"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@PetID", TxtPetIDNo.Text)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                Dim dewormingList As New List(Of String)
                While reader.Read()
                    dewormingList.Add(reader("DewormingName").ToString())
                End While
                TxtDeworming.Text = String.Join(", ", dewormingList)
                reader.Close()
            End Using
        End Using
    End Sub

    ' Fetch Vaccination Details
    Private Sub LoadVaccinationInfo()
        If String.IsNullOrWhiteSpace(TxtPetIDNo.Text) Then Return
        Dim query As String = "SELECT v.VaccineName FROM petvaccinations pv JOIN vaccines v ON pv.VaccineID = v.VaccineID WHERE pv.PetID = @PetID"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@PetID", TxtPetIDNo.Text)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                Dim vaccinationList As New List(Of String)
                While reader.Read()
                    vaccinationList.Add(reader("VaccineName").ToString())
                End While
                TxtVaccines.Text = String.Join(", ", vaccinationList)
                reader.Close()
            End Using
        End Using
    End Sub

    ' Fetch Surgery Details
    Private Sub LoadSurgeryInfo()
        If String.IsNullOrWhiteSpace(TxtPetIDNo.Text) Then Return
        Dim query As String = "SELECT SurgeryType FROM petsurgeries WHERE PetID = @PetID"
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@PetID", TxtPetIDNo.Text)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                Dim surgeryList As New List(Of String)
                While reader.Read()
                    surgeryList.Add(reader("SurgeryType").ToString())
                End While
                TxtSurgery.Text = If(surgeryList.Count > 0, String.Join(", ", surgeryList), "No surgery records found")
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub LoadClientInfo(ClientID As Integer)
        Try
            Dim query As String = "SELECT FullName, Address, Phone, Email, Sex, Photo FROM clients WHERE ClientID = @ClientID"

            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ClientID", ClientID)
                    conn.Open()

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        TxtOwnerName.Text = reader("FullName").ToString()
                        TxtOwnerAddress.Text = reader("Address").ToString()
                        TxtPhone.Text = reader("Phone").ToString()
                        TxtOwnerEmail.Text = reader("Email").ToString()
                        TxtOwnerSex.Text = reader("Sex").ToString()

                        ' Display pet photo
                        If Not IsDBNull(reader("Photo")) Then
                            Dim imgBytes As Byte() = CType(reader("Photo"), Byte())
                            If imgBytes IsNot Nothing AndAlso imgBytes.Length > 0 Then
                                Using ms As New MemoryStream(imgBytes)
                                    PicBoxOwner.Image = Image.FromStream(ms)
                                End Using
                            Else
                                PicBoxOwner.Image = Nothing
                            End If
                        Else
                            PicBoxOwner.Image = Nothing
                        End If

                    Else
                        MessageBox.Show("Client not found in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim ScanPage As New ScanPage()
        ScanPage.Show()
        Me.Hide()
    End Sub

    Private Sub LblColor_Click(sender As Object, e As EventArgs) Handles LblColor.Click

    End Sub

    Private Sub PicBoxPet_Click(sender As Object, e As EventArgs) Handles PicBoxPet.Click

    End Sub
End Class