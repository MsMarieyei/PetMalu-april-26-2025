<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PetRegistrationPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PetRegistrationPage))
        TxtName = New TextBox()
        Label1 = New Label()
        PicBoxPet = New PictureBox()
        BtnUploadPet = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label6 = New Label()
        BtnSubmit = New Button()
        Btnback = New Button()
        DpBirthday = New DateTimePicker()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        TxtPetIDNo = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        CheckedVaccine = New CheckedListBox()
        CheckedDeworming = New CheckedListBox()
        CheckedSurgery = New CheckedListBox()
        Label12 = New Label()
        TxtBreed = New TextBox()
        TxtColor = New TextBox()
        GroupSex = New GroupBox()
        RbtnMale = New RadioButton()
        RbtnFemale = New RadioButton()
        GroupType = New GroupBox()
        RbtnCat = New RadioButton()
        RbtnDog = New RadioButton()
        GroupSurgery = New GroupBox()
        RbtnNo = New RadioButton()
        RbtnYes = New RadioButton()
        GroupVaccines = New GroupBox()
        RbtnNoVac = New RadioButton()
        RbtnYesVac = New RadioButton()
        GroupDeworm = New GroupBox()
        RbtnNoDeworm = New RadioButton()
        RbtnYesDeworm = New RadioButton()
        DtpSurgeryDate = New DateTimePicker()
        DtpVaccineDate = New DateTimePicker()
        DtpDewormingDate = New DateTimePicker()
        CType(PicBoxPet, ComponentModel.ISupportInitialize).BeginInit()
        GroupSex.SuspendLayout()
        GroupType.SuspendLayout()
        GroupSurgery.SuspendLayout()
        GroupVaccines.SuspendLayout()
        GroupDeworm.SuspendLayout()
        SuspendLayout()
        ' 
        ' TxtName
        ' 
        TxtName.BackColor = Color.YellowGreen
        TxtName.BorderStyle = BorderStyle.FixedSingle
        TxtName.Font = New Font("Arial Rounded MT Bold", 24.0F)
        TxtName.Location = New Point(330, 414)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(367, 54)
        TxtName.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 64.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(453, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(1457, 135)
        Label1.TabIndex = 0
        Label1.Text = "Client/Pet Registration"
        ' 
        ' PicBoxPet
        ' 
        PicBoxPet.BackColor = Color.Teal
        PicBoxPet.BorderStyle = BorderStyle.FixedSingle
        PicBoxPet.Location = New Point(1425, 355)
        PicBoxPet.Name = "PicBoxPet"
        PicBoxPet.Size = New Size(350, 350)
        PicBoxPet.SizeMode = PictureBoxSizeMode.AutoSize
        PicBoxPet.TabIndex = 1
        PicBoxPet.TabStop = False
        ' 
        ' BtnUploadPet
        ' 
        BtnUploadPet.BackColor = Color.CadetBlue
        BtnUploadPet.FlatStyle = FlatStyle.Popup
        BtnUploadPet.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnUploadPet.ForeColor = Color.White
        BtnUploadPet.Location = New Point(1475, 740)
        BtnUploadPet.Name = "BtnUploadPet"
        BtnUploadPet.Size = New Size(254, 41)
        BtnUploadPet.TabIndex = 2
        BtnUploadPet.Text = "Upload Pet's Photo"
        BtnUploadPet.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label2.Location = New Point(184, 421)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 48)
        Label2.TabIndex = 3
        Label2.Text = "Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label3.Location = New Point(224, 497)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 48)
        Label3.TabIndex = 4
        Label3.Text = "Sex:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label4.Location = New Point(126, 568)
        Label4.Name = "Label4"
        Label4.Size = New Size(198, 48)
        Label4.TabIndex = 5
        Label4.Text = "Birthday:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label5.Location = New Point(176, 733)
        Label5.Name = "Label5"
        Label5.Size = New Size(148, 48)
        Label5.TabIndex = 6
        Label5.Text = "Breed:"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label6.Location = New Point(186, 818)
        Label6.Name = "Label6"
        Label6.Size = New Size(138, 48)
        Label6.TabIndex = 8
        Label6.Text = "Color:"
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.BackColor = Color.Green
        BtnSubmit.FlatStyle = FlatStyle.Popup
        BtnSubmit.Font = New Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnSubmit.ForeColor = Color.White
        BtnSubmit.Location = New Point(1399, 876)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(198, 85)
        BtnSubmit.TabIndex = 9
        BtnSubmit.Text = "Submit"
        BtnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Btnback
        ' 
        Btnback.BackColor = Color.DarkSlateGray
        Btnback.FlatStyle = FlatStyle.Popup
        Btnback.Font = New Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btnback.ForeColor = Color.White
        Btnback.Location = New Point(1617, 876)
        Btnback.Name = "Btnback"
        Btnback.Size = New Size(198, 85)
        Btnback.TabIndex = 10
        Btnback.Text = "Back"
        Btnback.UseVisualStyleBackColor = False
        ' 
        ' DpBirthday
        ' 
        DpBirthday.CalendarFont = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DpBirthday.CalendarMonthBackground = Color.White
        DpBirthday.CalendarTitleBackColor = Color.White
        DpBirthday.Font = New Font("Arial Narrow", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DpBirthday.Location = New Point(330, 574)
        DpBirthday.Name = "DpBirthday"
        DpBirthday.Size = New Size(367, 42)
        DpBirthday.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label7.Location = New Point(76, 647)
        Label7.Name = "Label7"
        Label7.Size = New Size(248, 48)
        Label7.TabIndex = 15
        Label7.Text = "Type of Pet:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label8.Location = New Point(110, 901)
        Label8.Name = "Label8"
        Label8.Size = New Size(214, 48)
        Label8.TabIndex = 19
        Label8.Text = "Pet ID No:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label9.Location = New Point(730, 420)
        Label9.Name = "Label9"
        Label9.Size = New Size(345, 48)
        Label9.TabIndex = 20
        Label9.Text = "Medical Surgery:"
        ' 
        ' TxtPetIDNo
        ' 
        TxtPetIDNo.BackColor = Color.YellowGreen
        TxtPetIDNo.BorderStyle = BorderStyle.FixedSingle
        TxtPetIDNo.Font = New Font("Arial Rounded MT Bold", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtPetIDNo.Location = New Point(330, 895)
        TxtPetIDNo.Name = "TxtPetIDNo"
        TxtPetIDNo.Size = New Size(367, 54)
        TxtPetIDNo.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label10.Location = New Point(874, 604)
        Label10.Name = "Label10"
        Label10.Size = New Size(201, 48)
        Label10.TabIndex = 24
        Label10.Text = "Vaccines:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label11.Location = New Point(822, 787)
        Label11.Name = "Label11"
        Label11.Size = New Size(253, 48)
        Label11.TabIndex = 25
        Label11.Text = "Deworming:"
        ' 
        ' CheckedVaccine
        ' 
        CheckedVaccine.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CheckedVaccine.BorderStyle = BorderStyle.FixedSingle
        CheckedVaccine.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckedVaccine.FormattingEnabled = True
        CheckedVaccine.Location = New Point(1081, 663)
        CheckedVaccine.Name = "CheckedVaccine"
        CheckedVaccine.Size = New Size(231, 102)
        CheckedVaccine.TabIndex = 27
        ' 
        ' CheckedDeworming
        ' 
        CheckedDeworming.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CheckedDeworming.BorderStyle = BorderStyle.FixedSingle
        CheckedDeworming.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckedDeworming.FormattingEnabled = True
        CheckedDeworming.Location = New Point(1081, 847)
        CheckedDeworming.Name = "CheckedDeworming"
        CheckedDeworming.Size = New Size(231, 102)
        CheckedDeworming.TabIndex = 28
        ' 
        ' CheckedSurgery
        ' 
        CheckedSurgery.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CheckedSurgery.BorderStyle = BorderStyle.FixedSingle
        CheckedSurgery.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckedSurgery.FormattingEnabled = True
        CheckedSurgery.Location = New Point(1081, 474)
        CheckedSurgery.Name = "CheckedSurgery"
        CheckedSurgery.Size = New Size(231, 102)
        CheckedSurgery.TabIndex = 29
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Imprint MT Shadow", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label12.Location = New Point(841, 208)
        Label12.Name = "Label12"
        Label12.Size = New Size(520, 56)
        Label12.TabIndex = 30
        Label12.Text = "PET INFORMATION"
        ' 
        ' TxtBreed
        ' 
        TxtBreed.BackColor = Color.YellowGreen
        TxtBreed.BorderStyle = BorderStyle.FixedSingle
        TxtBreed.Font = New Font("Arial Rounded MT Bold", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBreed.Location = New Point(330, 727)
        TxtBreed.Name = "TxtBreed"
        TxtBreed.Size = New Size(367, 54)
        TxtBreed.TabIndex = 31
        ' 
        ' TxtColor
        ' 
        TxtColor.BackColor = Color.YellowGreen
        TxtColor.BorderStyle = BorderStyle.FixedSingle
        TxtColor.Font = New Font("Arial Rounded MT Bold", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtColor.Location = New Point(330, 812)
        TxtColor.Name = "TxtColor"
        TxtColor.Size = New Size(367, 54)
        TxtColor.TabIndex = 32
        ' 
        ' GroupSex
        ' 
        GroupSex.BackColor = Color.Transparent
        GroupSex.Controls.Add(RbtnMale)
        GroupSex.Controls.Add(RbtnFemale)
        GroupSex.FlatStyle = FlatStyle.Flat
        GroupSex.Location = New Point(330, 482)
        GroupSex.Name = "GroupSex"
        GroupSex.Size = New Size(367, 71)
        GroupSex.TabIndex = 37
        GroupSex.TabStop = False
        ' 
        ' RbtnMale
        ' 
        RbtnMale.AutoSize = True
        RbtnMale.Font = New Font("Britannic Bold", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnMale.Location = New Point(204, 14)
        RbtnMale.Name = "RbtnMale"
        RbtnMale.Size = New Size(121, 48)
        RbtnMale.TabIndex = 1
        RbtnMale.TabStop = True
        RbtnMale.Text = "Male"
        RbtnMale.UseVisualStyleBackColor = True
        ' 
        ' RbtnFemale
        ' 
        RbtnFemale.AutoSize = True
        RbtnFemale.Font = New Font("Britannic Bold", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnFemale.Location = New Point(17, 15)
        RbtnFemale.Name = "RbtnFemale"
        RbtnFemale.Size = New Size(165, 48)
        RbtnFemale.TabIndex = 0
        RbtnFemale.TabStop = True
        RbtnFemale.Text = "Female"
        RbtnFemale.UseVisualStyleBackColor = True
        ' 
        ' GroupType
        ' 
        GroupType.BackColor = Color.Transparent
        GroupType.Controls.Add(RbtnCat)
        GroupType.Controls.Add(RbtnDog)
        GroupType.Location = New Point(330, 631)
        GroupType.Name = "GroupType"
        GroupType.Size = New Size(367, 74)
        GroupType.TabIndex = 2
        GroupType.TabStop = False
        ' 
        ' RbtnCat
        ' 
        RbtnCat.AutoSize = True
        RbtnCat.Font = New Font("Britannic Bold", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnCat.Location = New Point(204, 16)
        RbtnCat.Name = "RbtnCat"
        RbtnCat.Size = New Size(98, 48)
        RbtnCat.TabIndex = 1
        RbtnCat.TabStop = True
        RbtnCat.Text = "Cat"
        RbtnCat.UseVisualStyleBackColor = True
        ' 
        ' RbtnDog
        ' 
        RbtnDog.AutoSize = True
        RbtnDog.Font = New Font("Britannic Bold", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnDog.Location = New Point(17, 16)
        RbtnDog.Name = "RbtnDog"
        RbtnDog.Size = New Size(109, 48)
        RbtnDog.TabIndex = 0
        RbtnDog.TabStop = True
        RbtnDog.Text = "Dog"
        RbtnDog.UseVisualStyleBackColor = True
        ' 
        ' GroupSurgery
        ' 
        GroupSurgery.BackColor = Color.Transparent
        GroupSurgery.Controls.Add(RbtnNo)
        GroupSurgery.Controls.Add(RbtnYes)
        GroupSurgery.Location = New Point(1081, 403)
        GroupSurgery.Name = "GroupSurgery"
        GroupSurgery.Size = New Size(231, 71)
        GroupSurgery.TabIndex = 38
        GroupSurgery.TabStop = False
        ' 
        ' RbtnNo
        ' 
        RbtnNo.AutoSize = True
        RbtnNo.Font = New Font("Britannic Bold", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnNo.Location = New Point(139, 17)
        RbtnNo.Name = "RbtnNo"
        RbtnNo.Size = New Size(86, 48)
        RbtnNo.TabIndex = 1
        RbtnNo.TabStop = True
        RbtnNo.Text = "No"
        RbtnNo.UseVisualStyleBackColor = True
        ' 
        ' RbtnYes
        ' 
        RbtnYes.AutoSize = True
        RbtnYes.Font = New Font("Britannic Bold", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnYes.Location = New Point(7, 17)
        RbtnYes.Name = "RbtnYes"
        RbtnYes.Size = New Size(99, 48)
        RbtnYes.TabIndex = 0
        RbtnYes.TabStop = True
        RbtnYes.Text = "Yes"
        RbtnYes.UseVisualStyleBackColor = True
        ' 
        ' GroupVaccines
        ' 
        GroupVaccines.BackColor = Color.Transparent
        GroupVaccines.Controls.Add(RbtnNoVac)
        GroupVaccines.Controls.Add(RbtnYesVac)
        GroupVaccines.FlatStyle = FlatStyle.Popup
        GroupVaccines.Location = New Point(1081, 582)
        GroupVaccines.Name = "GroupVaccines"
        GroupVaccines.Size = New Size(231, 80)
        GroupVaccines.TabIndex = 39
        GroupVaccines.TabStop = False
        ' 
        ' RbtnNoVac
        ' 
        RbtnNoVac.AutoSize = True
        RbtnNoVac.Font = New Font("Britannic Bold", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnNoVac.Location = New Point(139, 18)
        RbtnNoVac.Name = "RbtnNoVac"
        RbtnNoVac.Size = New Size(86, 48)
        RbtnNoVac.TabIndex = 1
        RbtnNoVac.TabStop = True
        RbtnNoVac.Text = "No"
        RbtnNoVac.UseVisualStyleBackColor = True
        ' 
        ' RbtnYesVac
        ' 
        RbtnYesVac.AutoSize = True
        RbtnYesVac.Font = New Font("Britannic Bold", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnYesVac.Location = New Point(7, 18)
        RbtnYesVac.Name = "RbtnYesVac"
        RbtnYesVac.Size = New Size(99, 48)
        RbtnYesVac.TabIndex = 0
        RbtnYesVac.TabStop = True
        RbtnYesVac.Text = "Yes"
        RbtnYesVac.UseVisualStyleBackColor = True
        ' 
        ' GroupDeworm
        ' 
        GroupDeworm.BackColor = Color.Transparent
        GroupDeworm.Controls.Add(RbtnNoDeworm)
        GroupDeworm.Controls.Add(RbtnYesDeworm)
        GroupDeworm.FlatStyle = FlatStyle.Popup
        GroupDeworm.Location = New Point(1081, 771)
        GroupDeworm.Name = "GroupDeworm"
        GroupDeworm.Size = New Size(231, 73)
        GroupDeworm.TabIndex = 40
        GroupDeworm.TabStop = False
        ' 
        ' RbtnNoDeworm
        ' 
        RbtnNoDeworm.AutoSize = True
        RbtnNoDeworm.Font = New Font("Britannic Bold", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnNoDeworm.Location = New Point(139, 16)
        RbtnNoDeworm.Name = "RbtnNoDeworm"
        RbtnNoDeworm.Size = New Size(86, 48)
        RbtnNoDeworm.TabIndex = 41
        RbtnNoDeworm.TabStop = True
        RbtnNoDeworm.Text = "No"
        RbtnNoDeworm.UseVisualStyleBackColor = True
        ' 
        ' RbtnYesDeworm
        ' 
        RbtnYesDeworm.AutoSize = True
        RbtnYesDeworm.Font = New Font("Britannic Bold", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnYesDeworm.Location = New Point(7, 16)
        RbtnYesDeworm.Name = "RbtnYesDeworm"
        RbtnYesDeworm.Size = New Size(99, 48)
        RbtnYesDeworm.TabIndex = 0
        RbtnYesDeworm.TabStop = True
        RbtnYesDeworm.Text = "Yes"
        RbtnYesDeworm.UseVisualStyleBackColor = True
        ' 
        ' DtpSurgeryDate
        ' 
        DtpSurgeryDate.Location = New Point(808, 474)
        DtpSurgeryDate.Name = "DtpSurgeryDate"
        DtpSurgeryDate.Size = New Size(250, 27)
        DtpSurgeryDate.TabIndex = 44
        ' 
        ' DtpVaccineDate
        ' 
        DtpVaccineDate.Location = New Point(808, 655)
        DtpVaccineDate.Name = "DtpVaccineDate"
        DtpVaccineDate.Size = New Size(250, 27)
        DtpVaccineDate.TabIndex = 45
        ' 
        ' DtpDewormingDate
        ' 
        DtpDewormingDate.Location = New Point(808, 847)
        DtpDewormingDate.Name = "DtpDewormingDate"
        DtpDewormingDate.Size = New Size(250, 27)
        DtpDewormingDate.TabIndex = 46
        ' 
        ' PetRegistrationPage
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(TxtName)
        Controls.Add(DtpDewormingDate)
        Controls.Add(DtpVaccineDate)
        Controls.Add(DtpSurgeryDate)
        Controls.Add(GroupDeworm)
        Controls.Add(CheckedSurgery)
        Controls.Add(GroupVaccines)
        Controls.Add(GroupSurgery)
        Controls.Add(GroupType)
        Controls.Add(GroupSex)
        Controls.Add(TxtColor)
        Controls.Add(TxtBreed)
        Controls.Add(Label12)
        Controls.Add(CheckedDeworming)
        Controls.Add(CheckedVaccine)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(TxtPetIDNo)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(DpBirthday)
        Controls.Add(Btnback)
        Controls.Add(BtnSubmit)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(BtnUploadPet)
        Controls.Add(PicBoxPet)
        Controls.Add(Label1)
        Name = "PetRegistrationPage"
        Text = "Pet Registration Page"
        CType(PicBoxPet, ComponentModel.ISupportInitialize).EndInit()
        GroupSex.ResumeLayout(False)
        GroupSex.PerformLayout()
        GroupType.ResumeLayout(False)
        GroupType.PerformLayout()
        GroupSurgery.ResumeLayout(False)
        GroupSurgery.PerformLayout()
        GroupVaccines.ResumeLayout(False)
        GroupVaccines.PerformLayout()
        GroupDeworm.ResumeLayout(False)
        GroupDeworm.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PicBoxPet As PictureBox
    Friend WithEvents BtnUploadPet As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents Btnback As Button
    Friend WithEvents DpBirthday As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPetIDNo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CheckedVaccine As CheckedListBox
    Friend WithEvents CheckedDeworming As CheckedListBox
    Friend WithEvents CheckedSurgery As CheckedListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtBreed As TextBox
    Friend WithEvents TxtColor As TextBox
    Friend WithEvents GroupSex As GroupBox
    Friend WithEvents RbtnMale As RadioButton
    Friend WithEvents RbtnFemale As RadioButton
    Friend WithEvents GroupType As GroupBox
    Friend WithEvents RbtnDog As RadioButton
    Friend WithEvents RbtnCat As RadioButton
    Friend WithEvents GroupSurgery As GroupBox
    Friend WithEvents RbtnNo As RadioButton
    Friend WithEvents RbtnYes As RadioButton
    Friend WithEvents GroupVaccines As GroupBox
    Friend WithEvents GroupDeworm As GroupBox
    Friend WithEvents RbtnNoVac As RadioButton
    Friend WithEvents RbtnYesVac As RadioButton
    Friend WithEvents RbtnNoDeworm As RadioButton
    Friend WithEvents RbtnYesDeworm As RadioButton
    Friend WithEvents DtpSurgeryDate As DateTimePicker
    Friend WithEvents DtpVaccineDate As DateTimePicker
    Friend WithEvents DtpDewormingDate As DateTimePicker
    Friend WithEvents TxtName As TextBox
End Class