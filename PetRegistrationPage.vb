Imports MySql.Data.MySqlClient

Imports System.IO

Public Class PetRegistrationPage
    Dim connectionString As String = "Server=127.0.0.1;Port=3306;Database=petmalu_record_system;User ID=root;Password=;"
    Private clientID As Integer

    Public Sub New(clientID As Integer)
        InitializeComponent()
        Me.clientID = clientID
    End Sub

    Private Sub PetRegistrationPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Hide the CheckedListBox controls and DateTimePicker controls initially
        CheckedSurgery.Visible = False
        CheckedVaccine.Visible = False
        CheckedDeworming.Visible = False
        DtpSurgeryDate.Visible = False
        DtpVaccineDate.Visible = False
        DtpDewormingDate.Visible = False


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
               "Copper", "Steel", "Tuxedo", "ColorPoint", "BiColor", "White-Gray", "Black-Tan",
               "Black and Tan", "Black and White", "Brown and White", "Red and White",
               "Blue and White", "Liver and White", "Tan and White",
               "Black, White, and Tan", "Liver, White, and Tan", "Blue, Tan, and White",
               "Piebald", "Harlequin", "Ticked", "Roan",
               "Gray and White", "Orange and White", "Cream and White", "Chocolate and White"})



        Me.TxtColor.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Me.TxtColor.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TxtColor.AutoCompleteCustomSource = Color


        CheckedSurgery.Visible = False
        CheckedVaccine.Visible = False
        CheckedDeworming.Visible = False
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

    Private Sub TxtPetID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPetIDNo.KeyPress
        ' Check if the entered key is a number or control key (e.g., backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Ignore the keypress
        End If

        ' Prevent further input if the length is already 10
        If Char.IsDigit(e.KeyChar) AndAlso TxtPetIDNo.Text.Length >= 10 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        If TxtPetIDNo.Text.Length <> 10 Then
            MessageBox.Show("Pet ID must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtPetIDNo.Focus()
            Return
        End If

        If TxtName Is Nothing Then
            MessageBox.Show("The text box for the pet's name is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim PetID As String = TxtPetIDNo.Text
        Dim Name As String = TxtName.Text
        Dim Birthday As String = DpBirthday.Value.ToString("yyyy-MM-dd")
        Dim Color As String = TxtColor.Text
        Dim Breed As String = TxtBreed.Text
        Dim HasSurgery As Boolean = RbtnYes.Checked
        Dim Sex As String = If(RbtnMale.Checked, "Male", "Female")
        Dim Type As String = If(RbtnDog.Checked, "Dog", "Cat")

        If String.IsNullOrEmpty(PetID) OrElse String.IsNullOrEmpty(Name) OrElse String.IsNullOrEmpty(Color) OrElse String.IsNullOrEmpty(Breed) Then
            MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not IsNumeric(PetID) Then
            MessageBox.Show("Please enter a numeric ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Insert Pet Info
                Dim query As String = "INSERT INTO pets_info (PetID, ClientID, Name, Sex, Birthday, Type, Breed, Color, HasSurgery, Photo) VALUES (@PetID, @ClientID, @Name, @Sex, @Birthday, @Type, @Breed, @Color, @HasSurgery, @Photo)"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@PetID", PetID)
                    cmd.Parameters.AddWithValue("@ClientID", clientID)
                    cmd.Parameters.AddWithValue("@Name", Name)
                    cmd.Parameters.AddWithValue("@Sex", Sex)
                    cmd.Parameters.AddWithValue("@Birthday", Birthday)
                    cmd.Parameters.AddWithValue("@Type", Type)
                    cmd.Parameters.AddWithValue("@Breed", Breed)
                    cmd.Parameters.AddWithValue("@Color", Color)
                    cmd.Parameters.AddWithValue("@HasSurgery", HasSurgery)

                    ' Convert image to byte array for database storage
                    Dim photo As Byte() = Nothing
                    If PicBoxPet.Image IsNot Nothing Then
                        photo = ConvertImageToByteArray(PicBoxPet.Image)
                    End If

                    cmd.Parameters.AddWithValue("@Photo", photo)
                    cmd.ExecuteNonQuery()
                End Using

                ' Insert Vaccines, Dewormings, and Surgeries if necessary
                InsertVaccines(PetID, connection)
                InsertDewormings(PetID, connection)
                InsertSurgeries(PetID, connection)

                MessageBox.Show("Pet registered successfully with records!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InsertVaccines(petID As String, connection As MySqlConnection)
        If RbtnYesVac.Checked Then
            For Each item As String In CheckedVaccine.CheckedItems
                Dim vaccineID As Object
                Dim getVaccineIDQuery As String = "SELECT VaccineID FROM Vaccines WHERE VaccineName = @Vaccine"
                Using getVaccineIDCmd As New MySqlCommand(getVaccineIDQuery, connection)
                    getVaccineIDCmd.Parameters.AddWithValue("@Vaccine", item)
                    vaccineID = getVaccineIDCmd.ExecuteScalar()
                End Using

                If vaccineID IsNot Nothing Then
                    Dim vaccineQuery As String = "INSERT INTO PetVaccinations (PetID, VaccineID, VaccinationDate) VALUES (@PetID, @VaccineID, @VaccinationDate)"
                    Using vaccineCmd As New MySqlCommand(vaccineQuery, connection)
                        vaccineCmd.Parameters.AddWithValue("@PetID", petID)
                        vaccineCmd.Parameters.AddWithValue("@VaccineID", vaccineID)
                        vaccineCmd.Parameters.AddWithValue("@VaccinationDate", DtpVaccineDate.Value)
                        vaccineCmd.ExecuteNonQuery()
                    End Using
                Else
                    MessageBox.Show("Error: Vaccine '" & item & "' not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Next
        End If
    End Sub

    Private Sub InsertDewormings(petID As String, connection As MySqlConnection)
        If RbtnYesDeworm.Checked Then
            For Each item As String In CheckedDeworming.CheckedItems
                Dim dewormingQuery As String = "INSERT INTO PetDewormings (PetID, DewormingID, DewormingDate) VALUES (@PetID, (SELECT DewormingID FROM Dewormings WHERE DewormingName = @Deworming), @DewormingDate)"
                Using dewormingCmd As New MySqlCommand(dewormingQuery, connection)
                    dewormingCmd.Parameters.AddWithValue("@PetID", petID)
                    dewormingCmd.Parameters.AddWithValue("@Deworming", item)
                    dewormingCmd.Parameters.AddWithValue("@DewormingDate", DtpDewormingDate.Value)
                    dewormingCmd.ExecuteNonQuery()
                End Using
            Next
        End If
    End Sub

    Private Sub InsertSurgeries(petID As String, connection As MySqlConnection)
        If RbtnYes.Checked Then
            For Each item As String In CheckedSurgery.CheckedItems
                Dim surgeryQuery As String = "INSERT INTO PetSurgeries (PetID, SurgeryType, SurgeryDate) VALUES (@PetID, @SurgeryType, @SurgeryDate)"
                Using surgeryCmd As New MySqlCommand(surgeryQuery, connection)
                    surgeryCmd.Parameters.AddWithValue("@PetID", petID)
                    surgeryCmd.Parameters.AddWithValue("@SurgeryType", item)
                    surgeryCmd.Parameters.AddWithValue("@SurgeryDate", DtpSurgeryDate.Value)
                    surgeryCmd.ExecuteNonQuery()
                End Using
            Next
        End If
    End Sub

    Private Function ConvertImageToByteArray(image As Image) As Byte()
        Dim photo As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, image.RawFormat)
            photo = ms.ToArray()
        End Using
        Return photo
    End Function

    Private Sub BtnUploadPet_Click(sender As Object, e As EventArgs) Handles BtnUploadPet.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                PicBoxPet.Image = Image.FromFile(openFileDialog.FileName)
                PicBoxPet.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Using
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles Btnback.Click
        Dim dashboard As New DashboardPage()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub ClearFields()
        TxtPetIDNo.Text = ""
        TxtName.Text = ""
        TxtColor.Text = ""
        TxtBreed.Text = ""
        DpBirthday.Value = DateTime.Now
        RbtnMale.Checked = False
        RbtnFemale.Checked = False
        RbtnDog.Checked = False
        RbtnCat.Checked = False
        RbtnYes.Checked = False
        RbtnNo.Checked = False
        RbtnYesVac.Checked = False
        RbtnNoVac.Checked = False
        RbtnYesDeworm.Checked = False
        RbtnNoDeworm.Checked = False
        CheckedSurgery.Items.Clear()
        CheckedSurgery.Visible = False
        CheckedVaccine.Items.Clear()
        CheckedVaccine.Visible = False
        CheckedDeworming.Items.Clear()
        CheckedDeworming.Visible = False
        PicBoxPet.Image = Nothing
        TxtPetIDNo.ReadOnly = False
    End Sub

    Private Sub GroupDeworm_Enter(sender As Object, e As EventArgs) Handles GroupDeworm.Enter

    End Sub
End Class