Imports MySql.Data.MySqlClient
Imports System.IO

Public Class UpdateRecordPage
    Private petID As Integer
    Private connectionString As String = "Server=localhost;Database=petmalu_record_system;User ID=root;Password=;"

    Public Sub New(petID As Integer)
        InitializeComponent()
        Me.petID = petID
    End Sub

    Private Sub UpdateRecordPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPetDetails()

        Dim suggestions1 As New AutoCompleteStringCollection()
        suggestions1.AddRange(New String() {"Aspin", "Shih Tzu", "Labrador Retriever", "Pomeranian", "Chihuahua",
            "Golden Retriever", "Siberian Husky", "Pug", "Beagle", "Dachshund",
            "American Bully", "French Bulldog", "Yorkshire Terrier", "German Shepherd", "Jack Russell Terrier",
            "Maltese", "Poodle", "Rottweiler", "Belgian Malinois", "Boxer",
            "Border Collie", "Alaskan Malamute", "Corgi", "Doberman Pinscher", "Japanese Spitz",
            "Great Dane", "Bullmastiff", "Chow Chow", "Bichon Frise", "Shar Pei",
            "Miniature Pinscher", "Boston Terrier", "Cane Corso", "Cocker Spaniel", "Weimaraner",
            "Afghan Hound", "Akita Inu", "Keeshond", "Basenji", "Lhasa Apso",
            "Samoyed", "English Bulldog", "Saint Bernard", "Irish Setter", "Scottish Terrier",
            "Airedale Terrier", "Whippet", "Saluki", "Shiba Inu", "Tibetan Mastiff",
            "Borzoi", "Puspin", "Persian", "Siamese", "Maine Coon", "Ragdoll",
            "Bengal", "Himalayan", "British Shorthair", "American Shorthair", "Sphynx",
            "Scottish Fold", "Russian Blue", "Norwegian Forest Cat", "Turkish Angora", "Exotic Shorthair",
            "Abyssinian", "Burmese", "Cornish Rex", "Devon Rex", "Japanese Bobtail",
            "Egyptian Mau", "Balinese", "Oriental Shorthair", "Turkish Van", "Tonkinese",
            "Selkirk Rex", "Manx", "Chartreux", "Ocicat", "Singapura",
            "Somali", "Snowshoe", "LaPerm", "Burmilla", "Chausie",
            "Kurilian Bobtail", "Munchkin", "Savannah", "Peterbald", "Serengeti",
            "Ragamuffin", "Caracal", "American Curl", "Javanese", "Khao Manee",
            "Lykoi", "Nebelung", "Toyger", "Mekong Bobtail", "Thai Cat",
            "Donskoy"})

        Me.TxtBreed.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Me.TxtBreed.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TxtBreed.AutoCompleteCustomSource = suggestions1

        Dim Color As New AutoCompleteStringCollection()
        Color.AddRange(New String() {"Tricolor", "White", "Black", "Brown", "Gray",
            "Tan", "Cream", "Fawn", "Red", "Blue",
            "Chocolate", "Gold", "Silver", "Brindle", "Merle",
            "Sable", "Apricot", "Lilac", "Cinnamon", "Seal",
            "Smoke", "Tortoiseshell", "Calico", "Tabby", "Orange",
            "Champagne", "Mahogany", "Buff", "Rust", "Slate",
            "Charcoal", "Pearl", "Chestnut", "Ivory", "Platinum",
            "Amber", "Lavender", "Beige", "Mustard", "Mocha",
            "Coffee", "Sand", "Ebony", "Onyx", "Marble",
            "Agouti", "Hazel", "Pewter", "Rose", "Lemon",
            "Copper", "Steel"})

        Me.TxtColor.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Me.TxtColor.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TxtColor.AutoCompleteCustomSource = Color

        CheckedSurgery.Visible = False
        CheckedVaccine.Visible = False
        CheckedDeworming.Visible = False
        DtpSurgeryDate.Visible = False
        DtpVaccineDate.Visible = False
        DtpDewormingDate.Visible = False
    End Sub

    Private Sub RbtnYes_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnYes.CheckedChanged
        If RbtnYes.Checked Then
            CheckedSurgery.Items.Clear()
            CheckedSurgery.Items.Add("Caesarean Section/Hysterectomy")
            CheckedSurgery.Items.Add("Ligation/Ovariectomy")
            CheckedSurgery.Items.Add("Aural Hematoma")
            CheckedSurgery.Items.Add("Urethrostomy")
            CheckedSurgery.Items.Add("Declawing")
            CheckedSurgery.Items.Add("Cherry Eye Removal")
            CheckedSurgery.Items.Add("Tumor Removal")
            CheckedSurgery.Items.Add("Neutering/Spaying")
            CheckedSurgery.Items.Add("Wound Repair")
            CheckedSurgery.Items.Add("Cystotomy")
            CheckedSurgery.Items.Add("Tail Docking")
            CheckedSurgery.Items.Add("Teeth Extraction")
            CheckedSurgery.Visible = True
            DtpSurgeryDate.Visible = True
        End If
    End Sub

    Private Sub RbtnNo_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnNo.CheckedChanged
        If RbtnNo.Checked Then
            CheckedSurgery.Visible = False
            CheckedSurgery.Items.Clear()
            DtpSurgeryDate.Visible = False
        End If
    End Sub

    Private Sub RbtnYesVac_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnYesVac.CheckedChanged
        If RbtnYesVac.Checked Then
            CheckedVaccine.Items.Clear()
            CheckedVaccine.Items.Add("Rabies")
            CheckedVaccine.Items.Add("DHPP (Distemper, Hepatitis, Parvovirus, Parainfluenza)")
            CheckedVaccine.Items.Add("DHP (Distemper, Hepatitis, Parvovirus)")
            CheckedVaccine.Items.Add("Parvovirus")
            CheckedVaccine.Items.Add("Distemper")
            CheckedVaccine.Items.Add("Hepatitis (Adenovirus)")
            CheckedVaccine.Items.Add("Parainfluenza")
            CheckedVaccine.Items.Add("Leptospirosis")
            CheckedVaccine.Items.Add("Bordetella (Kennel Cough)")
            CheckedVaccine.Items.Add("Canine Influenza H3N2")
            CheckedVaccine.Items.Add("Canine Influenza H3N8")
            CheckedVaccine.Items.Add("Lyme Disease")
            CheckedVaccine.Items.Add("Coronavirus (CCV)")
            CheckedVaccine.Items.Add("Rattlesnake Vaccine")
            CheckedVaccine.Items.Add("5-in-1 Vaccine (DHPP)")
            CheckedVaccine.Items.Add("6-in-1 Vaccine (DHPP + Leptospirosis)")
            CheckedVaccine.Items.Add("8-in-1 Vaccine (DHPP + Leptospirosis + Coronavirus)")
            CheckedVaccine.Items.Add("Canine Herpesvirus")
            CheckedVaccine.Items.Add("Giardia")
            CheckedVaccine.Items.Add("Tetanus")
            CheckedVaccine.Items.Add("Brucellosis")
            CheckedVaccine.Items.Add("Ehrlichiosis")
            CheckedVaccine.Items.Add("Babesiosis")
            CheckedVaccine.Items.Add("Heartworm Prevention")
            CheckedVaccine.Items.Add("Canine Rotavirus")
            CheckedVaccine.Items.Add("Canine Adenovirus Type 1")
            CheckedVaccine.Items.Add("Canine Adenovirus Type 2")
            CheckedVaccine.Items.Add("Canine Parvovirus Type 2c")
            CheckedVaccine.Items.Add("Canine Distemper-Measles Combo")
            CheckedVaccine.Items.Add("Canine Leptospira Grippotyphosa")
            CheckedVaccine.Items.Add("Canine Leptospira Pomona")
            CheckedVaccine.Items.Add("Canine Leptospira Canicola")
            CheckedVaccine.Items.Add("Canine Leptospira Icterohaemorrhagiae")
            CheckedVaccine.Items.Add("FVRCP (Feline Viral Rhinotracheitis, Calicivirus, Panleukopenia)")
            CheckedVaccine.Items.Add("Feline Distemper")
            CheckedVaccine.Items.Add("Feline Calicivirus")
            CheckedVaccine.Items.Add("Feline Herpesvirus")
            CheckedVaccine.Items.Add("Feline Panleukopenia")
            CheckedVaccine.Items.Add("Feline Leukemia Virus (FeLV)")
            CheckedVaccine.Items.Add("Feline Immunodeficiency Virus (FIV)")
            CheckedVaccine.Items.Add("Feline Bordetella")
            CheckedVaccine.Items.Add("Feline Chlamydia")
            CheckedVaccine.Items.Add("Feline Infectious Peritonitis (FIP)")
            CheckedVaccine.Items.Add("Feline Heartworm Prevention")
            CheckedVaccine.Items.Add("Feline Giardia")
            CheckedVaccine.Items.Add("Feline Rotavirus")
            CheckedVaccine.Items.Add("Feline Coronavirus")
            CheckedVaccine.Items.Add("Feline Toxoplasmosis")
            CheckedVaccine.Items.Add("Feline Mycoplasma")
            CheckedVaccine.Items.Add("Feline Pneumonitis")
            CheckedVaccine.Items.Add("Feline Rhinotracheitis")
            CheckedVaccine.Items.Add("Feline Hemotropic Mycoplasmosis")
            CheckedVaccine.Visible = True
            DtpVaccineDate.Visible = True
        End If
    End Sub

    Private Sub RbtnNoVac_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnNoVac.CheckedChanged
        If RbtnNoVac.Checked Then
            CheckedVaccine.Visible = False
            CheckedVaccine.Items.Clear()
            DtpVaccineDate.Visible = False
        End If
    End Sub

    Private Sub RbtnYesDeworm_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnYesDeworm.CheckedChanged
        If RbtnYesDeworm.Checked Then
            CheckedDeworming.Items.Clear()
            CheckedDeworming.Items.Add("Pyrantel Pamoate")
            CheckedDeworming.Items.Add("Fenbendazole")
            CheckedDeworming.Items.Add("Praziquantel")
            CheckedDeworming.Items.Add("Ivermectin")
            CheckedDeworming.Items.Add("Milbemycin Oxime")
            CheckedDeworming.Items.Add("Moxidectin")
            CheckedDeworming.Items.Add("Selamectin")
            CheckedDeworming.Items.Add("Albendazole")
            CheckedDeworming.Items.Add("Febantel")
            CheckedDeworming.Items.Add("Piperazine")
            CheckedDeworming.Visible = True
            DtpDewormingDate.Visible = True
        End If
    End Sub

    Private Sub RbtnNoDeworm_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnNoDeworm.CheckedChanged
        If RbtnNoDeworm.Checked Then
            CheckedDeworming.Visible = False
            CheckedDeworming.Items.Clear()
            DtpDewormingDate.Visible = False
        End If
    End Sub

    Private Sub LoadPetDetails()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM pets_info WHERE PetID = @PetID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@PetID", petID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            TxtPetIDNo.Text = reader("PetID").ToString()
                            TxtName.Text = reader("Name").ToString()
                            DpBirthday.Value = Convert.ToDateTime(reader("Birthday"))
                            TxtColor.Text = reader("Color").ToString()
                            TxtBreed.Text = reader("Breed").ToString()
                            If reader("Sex").ToString() = "Male" Then
                                RbtnMale.Checked = True
                            Else
                                RbtnFemale.Checked = True
                            End If
                            If reader("Type").ToString() = "Dog" Then
                                RbtnDog.Checked = True
                            Else
                                RbtnCat.Checked = True
                            End If
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
                    End Using
                End Using

                ' Load surgeries
                query = "SELECT SurgeryType, SurgeryDate FROM petsurgeries WHERE PetID = @PetID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@PetID", petID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        CheckedSurgery.Items.Clear()
                        While reader.Read()
                            CheckedSurgery.Items.Add(reader("SurgeryType").ToString(), True)
                            DtpSurgeryDate.Value = Convert.ToDateTime(reader("SurgeryDate"))
                        End While
                    End Using
                End Using

                ' Load vaccinations
                query = "SELECT VaccineName, VaccinationDate FROM petvaccinations pv INNER JOIN vaccines v ON pv.VaccineID = v.VaccineID WHERE PetID = @PetID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@PetID", petID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        CheckedVaccine.Items.Clear()
                        While reader.Read()
                            CheckedVaccine.Items.Add(reader("VaccineName").ToString(), True)
                            DtpVaccineDate.Value = Convert.ToDateTime(reader("VaccinationDate"))
                        End While
                    End Using
                End Using

                ' Load dewormings
                query = "SELECT DewormingName, DewormingDate FROM petdewormings pd INNER JOIN dewormings d ON pd.DewormingID = d.DewormingID WHERE PetID = @PetID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@PetID", petID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        CheckedDeworming.Items.Clear()
                        While reader.Read()
                            CheckedDeworming.Items.Add(reader("DewormingName").ToString(), True)
                            DtpDewormingDate.Value = Convert.ToDateTime(reader("DewormingDate"))
                        End While
                    End Using
                End Using

            End Using
        Catch ex As MySqlException
            MessageBox.Show("SQL Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim Name As String = TxtName.Text
        Dim birthday As String = DpBirthday.Value.ToString("yyyy-MM-dd")
        Dim color As String = TxtColor.Text
        Dim breed As String = TxtBreed.Text
        Dim sex As String = If(RbtnMale.Checked, "Male", "Female")
        Dim type As String = If(RbtnDog.Checked, "Dog", "Cat")

        If String.IsNullOrEmpty(Name) OrElse String.IsNullOrEmpty(color) OrElse String.IsNullOrEmpty(breed) Then
            MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "UPDATE pets_info SET Name = @Name, Birthday = @Birthday, Color = @Color, Breed = @Breed, Sex = @Sex, Type = @Type WHERE PetID = @PetID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Name", Name)
                    cmd.Parameters.AddWithValue("@Birthday", birthday)
                    cmd.Parameters.AddWithValue("@Color", color)
                    cmd.Parameters.AddWithValue("@Breed", breed)
                    cmd.Parameters.AddWithValue("@Sex", sex)
                    cmd.Parameters.AddWithValue("@Type", type)
                    cmd.Parameters.AddWithValue("@PetID", petID)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("SQL Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class