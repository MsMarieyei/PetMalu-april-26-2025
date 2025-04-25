<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateRecordPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateRecordPage))
        GroupDeworm = New GroupBox()
        RbtnNoDeworm = New RadioButton()
        RbtnYesDeworm = New RadioButton()
        GroupVaccines = New GroupBox()
        RbtnNoVac = New RadioButton()
        RbtnYesVac = New RadioButton()
        GroupSurgery = New GroupBox()
        RbtnNo = New RadioButton()
        RbtnYes = New RadioButton()
        GroupType = New GroupBox()
        RbtnCat = New RadioButton()
        RbtnDog = New RadioButton()
        GroupSex = New GroupBox()
        RbtnMale = New RadioButton()
        RbtnFemale = New RadioButton()
        TxtColor = New TextBox()
        TxtBreed = New TextBox()
        CheckedSurgery = New CheckedListBox()
        CheckedDeworming = New CheckedListBox()
        CheckedVaccine = New CheckedListBox()
        Label11 = New Label()
        Label10 = New Label()
        TxtPetIDNo = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        DpBirthday = New DateTimePicker()
        TxtName = New TextBox()
        BtnCancel = New Button()
        BtnSubmit = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PicBoxPet = New PictureBox()
        Label1 = New Label()
        BtnAddSurgery = New Button()
        DtpSurgeryDate = New DateTimePicker()
        DtpVaccineDate = New DateTimePicker()
        BtnAddVaccine = New Button()
        DtpDewormingDate = New DateTimePicker()
        BtnAddDeworming = New Button()
        GroupDeworm.SuspendLayout()
        GroupVaccines.SuspendLayout()
        GroupSurgery.SuspendLayout()
        GroupType.SuspendLayout()
        GroupSex.SuspendLayout()
        CType(PicBoxPet, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupDeworm
        ' 
        GroupDeworm.BackColor = Color.Transparent
        GroupDeworm.Controls.Add(RbtnNoDeworm)
        GroupDeworm.Controls.Add(RbtnYesDeworm)
        GroupDeworm.Location = New Point(1138, 743)
        GroupDeworm.Name = "GroupDeworm"
        GroupDeworm.Size = New Size(250, 65)
        GroupDeworm.TabIndex = 67
        GroupDeworm.TabStop = False
        ' 
        ' RbtnNoDeworm
        ' 
        RbtnNoDeworm.AutoSize = True
        RbtnNoDeworm.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnNoDeworm.Location = New Point(146, 12)
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
        RbtnYesDeworm.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnYesDeworm.Location = New Point(14, 12)
        RbtnYesDeworm.Name = "RbtnYesDeworm"
        RbtnYesDeworm.Size = New Size(99, 48)
        RbtnYesDeworm.TabIndex = 0
        RbtnYesDeworm.TabStop = True
        RbtnYesDeworm.Text = "Yes"
        RbtnYesDeworm.UseVisualStyleBackColor = True
        ' 
        ' GroupVaccines
        ' 
        GroupVaccines.BackColor = Color.Transparent
        GroupVaccines.Controls.Add(RbtnNoVac)
        GroupVaccines.Controls.Add(RbtnYesVac)
        GroupVaccines.Location = New Point(1138, 533)
        GroupVaccines.Name = "GroupVaccines"
        GroupVaccines.Size = New Size(250, 68)
        GroupVaccines.TabIndex = 66
        GroupVaccines.TabStop = False
        ' 
        ' RbtnNoVac
        ' 
        RbtnNoVac.AutoSize = True
        RbtnNoVac.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnNoVac.Location = New Point(146, 13)
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
        RbtnYesVac.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnYesVac.Location = New Point(20, 13)
        RbtnYesVac.Name = "RbtnYesVac"
        RbtnYesVac.Size = New Size(99, 48)
        RbtnYesVac.TabIndex = 0
        RbtnYesVac.TabStop = True
        RbtnYesVac.Text = "Yes"
        RbtnYesVac.UseVisualStyleBackColor = True
        ' 
        ' GroupSurgery
        ' 
        GroupSurgery.BackColor = Color.Transparent
        GroupSurgery.BackgroundImageLayout = ImageLayout.None
        GroupSurgery.Controls.Add(RbtnNo)
        GroupSurgery.Controls.Add(RbtnYes)
        GroupSurgery.FlatStyle = FlatStyle.Popup
        GroupSurgery.Location = New Point(1138, 330)
        GroupSurgery.Name = "GroupSurgery"
        GroupSurgery.Size = New Size(250, 63)
        GroupSurgery.TabIndex = 65
        GroupSurgery.TabStop = False
        ' 
        ' RbtnNo
        ' 
        RbtnNo.AutoSize = True
        RbtnNo.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnNo.Location = New Point(146, 11)
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
        RbtnYes.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnYes.Location = New Point(20, 11)
        RbtnYes.Name = "RbtnYes"
        RbtnYes.Size = New Size(99, 48)
        RbtnYes.TabIndex = 0
        RbtnYes.TabStop = True
        RbtnYes.Text = "Yes"
        RbtnYes.UseVisualStyleBackColor = True
        ' 
        ' GroupType
        ' 
        GroupType.BackColor = Color.Transparent
        GroupType.Controls.Add(RbtnCat)
        GroupType.Controls.Add(RbtnDog)
        GroupType.Location = New Point(353, 589)
        GroupType.Name = "GroupType"
        GroupType.Size = New Size(383, 68)
        GroupType.TabIndex = 42
        GroupType.TabStop = False
        ' 
        ' RbtnCat
        ' 
        RbtnCat.AutoSize = True
        RbtnCat.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnCat.Location = New Point(226, 14)
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
        RbtnDog.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnDog.Location = New Point(34, 14)
        RbtnDog.Name = "RbtnDog"
        RbtnDog.Size = New Size(109, 48)
        RbtnDog.TabIndex = 0
        RbtnDog.TabStop = True
        RbtnDog.Text = "Dog"
        RbtnDog.UseVisualStyleBackColor = True
        ' 
        ' GroupSex
        ' 
        GroupSex.BackColor = Color.Transparent
        GroupSex.Controls.Add(RbtnMale)
        GroupSex.Controls.Add(RbtnFemale)
        GroupSex.FlatStyle = FlatStyle.Popup
        GroupSex.Location = New Point(353, 426)
        GroupSex.Name = "GroupSex"
        GroupSex.Size = New Size(383, 75)
        GroupSex.TabIndex = 64
        GroupSex.TabStop = False
        ' 
        ' RbtnMale
        ' 
        RbtnMale.AutoSize = True
        RbtnMale.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnMale.Location = New Point(240, 16)
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
        RbtnFemale.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnFemale.Location = New Point(17, 16)
        RbtnFemale.Name = "RbtnFemale"
        RbtnFemale.Size = New Size(165, 48)
        RbtnFemale.TabIndex = 0
        RbtnFemale.TabStop = True
        RbtnFemale.Text = "Female"
        RbtnFemale.UseVisualStyleBackColor = True
        ' 
        ' TxtColor
        ' 
        TxtColor.BackColor = Color.White
        TxtColor.BorderStyle = BorderStyle.FixedSingle
        TxtColor.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtColor.Location = New Point(351, 776)
        TxtColor.Name = "TxtColor"
        TxtColor.Size = New Size(383, 54)
        TxtColor.TabIndex = 63
        ' 
        ' TxtBreed
        ' 
        TxtBreed.BackColor = Color.White
        TxtBreed.BorderStyle = BorderStyle.FixedSingle
        TxtBreed.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBreed.Location = New Point(351, 684)
        TxtBreed.Name = "TxtBreed"
        TxtBreed.Size = New Size(383, 54)
        TxtBreed.TabIndex = 62
        ' 
        ' CheckedSurgery
        ' 
        CheckedSurgery.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckedSurgery.FormattingEnabled = True
        CheckedSurgery.Location = New Point(1138, 395)
        CheckedSurgery.Name = "CheckedSurgery"
        CheckedSurgery.Size = New Size(250, 106)
        CheckedSurgery.TabIndex = 61
        ' 
        ' CheckedDeworming
        ' 
        CheckedDeworming.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckedDeworming.FormattingEnabled = True
        CheckedDeworming.Location = New Point(1138, 811)
        CheckedDeworming.Name = "CheckedDeworming"
        CheckedDeworming.Size = New Size(250, 106)
        CheckedDeworming.TabIndex = 60
        ' 
        ' CheckedVaccine
        ' 
        CheckedVaccine.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckedVaccine.FormattingEnabled = True
        CheckedVaccine.Location = New Point(1138, 603)
        CheckedVaccine.Name = "CheckedVaccine"
        CheckedVaccine.Size = New Size(250, 106)
        CheckedVaccine.TabIndex = 59
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label11.Location = New Point(879, 755)
        Label11.Name = "Label11"
        Label11.Size = New Size(253, 48)
        Label11.TabIndex = 58
        Label11.Text = "Deworming:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label10.Location = New Point(931, 545)
        Label10.Name = "Label10"
        Label10.Size = New Size(201, 48)
        Label10.TabIndex = 57
        Label10.Text = "Vaccines:"
        ' 
        ' TxtPetIDNo
        ' 
        TxtPetIDNo.BorderStyle = BorderStyle.FixedSingle
        TxtPetIDNo.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtPetIDNo.Location = New Point(351, 863)
        TxtPetIDNo.Name = "TxtPetIDNo"
        TxtPetIDNo.Size = New Size(383, 54)
        TxtPetIDNo.TabIndex = 56
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label9.Location = New Point(787, 340)
        Label9.Name = "Label9"
        Label9.Size = New Size(345, 48)
        Label9.TabIndex = 55
        Label9.Text = "Medical Surgery:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label8.Location = New Point(133, 864)
        Label8.Name = "Label8"
        Label8.Size = New Size(214, 48)
        Label8.TabIndex = 54
        Label8.Text = "Pet ID No:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label7.Location = New Point(99, 602)
        Label7.Name = "Label7"
        Label7.Size = New Size(248, 48)
        Label7.TabIndex = 53
        Label7.Text = "Type of Pet:"
        ' 
        ' DpBirthday
        ' 
        DpBirthday.CalendarFont = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DpBirthday.CalendarMonthBackground = Color.White
        DpBirthday.CalendarTitleBackColor = Color.White
        DpBirthday.Font = New Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DpBirthday.Location = New Point(351, 528)
        DpBirthday.Name = "DpBirthday"
        DpBirthday.Size = New Size(385, 38)
        DpBirthday.TabIndex = 52
        ' 
        ' TxtName
        ' 
        TxtName.BackColor = Color.White
        TxtName.BorderStyle = BorderStyle.FixedSingle
        TxtName.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtName.Location = New Point(353, 361)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(383, 54)
        TxtName.TabIndex = 51
        ' 
        ' BtnCancel
        ' 
        BtnCancel.BackColor = Color.DarkSlateGray
        BtnCancel.FlatStyle = FlatStyle.Popup
        BtnCancel.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnCancel.ForeColor = Color.White
        BtnCancel.Location = New Point(1661, 897)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(154, 54)
        BtnCancel.TabIndex = 50
        BtnCancel.Text = "CANCEL"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.BackColor = Color.Green
        BtnSubmit.FlatStyle = FlatStyle.Popup
        BtnSubmit.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnSubmit.ForeColor = Color.White
        BtnSubmit.Location = New Point(1661, 816)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(154, 60)
        BtnSubmit.TabIndex = 49
        BtnSubmit.Text = "Submit"
        BtnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label6.Location = New Point(209, 781)
        Label6.Name = "Label6"
        Label6.Size = New Size(138, 48)
        Label6.TabIndex = 48
        Label6.Text = "Color:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label5.Location = New Point(199, 685)
        Label5.Name = "Label5"
        Label5.Size = New Size(148, 48)
        Label5.TabIndex = 47
        Label5.Text = "Breed:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label4.Location = New Point(149, 518)
        Label4.Name = "Label4"
        Label4.Size = New Size(198, 48)
        Label4.TabIndex = 46
        Label4.Text = "Birthday:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label3.Location = New Point(247, 442)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 48)
        Label3.TabIndex = 45
        Label3.Text = "Sex:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label2.Location = New Point(207, 362)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 48)
        Label2.TabIndex = 44
        Label2.Text = "Name:"
        ' 
        ' PicBoxPet
        ' 
        PicBoxPet.BackColor = Color.YellowGreen
        PicBoxPet.BorderStyle = BorderStyle.FixedSingle
        PicBoxPet.Location = New Point(1456, 326)
        PicBoxPet.Name = "PicBoxPet"
        PicBoxPet.Size = New Size(355, 357)
        PicBoxPet.SizeMode = PictureBoxSizeMode.StretchImage
        PicBoxPet.TabIndex = 41
        PicBoxPet.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(489, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(1238, 149)
        Label1.TabIndex = 68
        Label1.Text = "PET IDENTIFICATION"
        ' 
        ' BtnAddSurgery
        ' 
        BtnAddSurgery.Location = New Point(975, 472)
        BtnAddSurgery.Name = "BtnAddSurgery"
        BtnAddSurgery.Size = New Size(94, 29)
        BtnAddSurgery.TabIndex = 69
        BtnAddSurgery.Text = "ADD"
        BtnAddSurgery.UseVisualStyleBackColor = True
        ' 
        ' DtpSurgeryDate
        ' 
        DtpSurgeryDate.Location = New Point(864, 410)
        DtpSurgeryDate.Name = "DtpSurgeryDate"
        DtpSurgeryDate.Size = New Size(250, 23)
        DtpSurgeryDate.TabIndex = 70
        ' 
        ' DtpVaccineDate
        ' 
        DtpVaccineDate.Location = New Point(864, 603)
        DtpVaccineDate.Name = "DtpVaccineDate"
        DtpVaccineDate.Size = New Size(250, 23)
        DtpVaccineDate.TabIndex = 72
        ' 
        ' BtnAddVaccine
        ' 
        BtnAddVaccine.Location = New Point(975, 665)
        BtnAddVaccine.Name = "BtnAddVaccine"
        BtnAddVaccine.Size = New Size(94, 29)
        BtnAddVaccine.TabIndex = 71
        BtnAddVaccine.Text = "ADD"
        BtnAddVaccine.UseVisualStyleBackColor = True
        ' 
        ' DtpDewormingDate
        ' 
        DtpDewormingDate.Location = New Point(864, 821)
        DtpDewormingDate.Name = "DtpDewormingDate"
        DtpDewormingDate.Size = New Size(250, 23)
        DtpDewormingDate.TabIndex = 74
        ' 
        ' BtnAddDeworming
        ' 
        BtnAddDeworming.Location = New Point(975, 883)
        BtnAddDeworming.Name = "BtnAddDeworming"
        BtnAddDeworming.Size = New Size(94, 29)
        BtnAddDeworming.TabIndex = 73
        BtnAddDeworming.Text = "ADD"
        BtnAddDeworming.UseVisualStyleBackColor = True
        ' 
        ' UpdateRecordPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(DtpDewormingDate)
        Controls.Add(BtnAddDeworming)
        Controls.Add(DtpVaccineDate)
        Controls.Add(BtnAddVaccine)
        Controls.Add(DtpSurgeryDate)
        Controls.Add(BtnAddSurgery)
        Controls.Add(Label1)
        Controls.Add(GroupDeworm)
        Controls.Add(CheckedDeworming)
        Controls.Add(CheckedSurgery)
        Controls.Add(CheckedVaccine)
        Controls.Add(GroupVaccines)
        Controls.Add(GroupSurgery)
        Controls.Add(GroupType)
        Controls.Add(GroupSex)
        Controls.Add(TxtColor)
        Controls.Add(TxtBreed)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(TxtPetIDNo)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(DpBirthday)
        Controls.Add(TxtName)
        Controls.Add(BtnCancel)
        Controls.Add(BtnSubmit)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PicBoxPet)
        Font = New Font("Microsoft Sans Serif", 8.25F)
        Name = "UpdateRecordPage"
        Text = "Update Record Page"
        WindowState = FormWindowState.Maximized
        GroupDeworm.ResumeLayout(False)
        GroupDeworm.PerformLayout()
        GroupVaccines.ResumeLayout(False)
        GroupVaccines.PerformLayout()
        GroupSurgery.ResumeLayout(False)
        GroupSurgery.PerformLayout()
        GroupType.ResumeLayout(False)
        GroupType.PerformLayout()
        GroupSex.ResumeLayout(False)
        GroupSex.PerformLayout()
        CType(PicBoxPet, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupDeworm As GroupBox
    Friend WithEvents RbtnNoDeworm As RadioButton
    Friend WithEvents RbtnYesDeworm As RadioButton
    Friend WithEvents GroupVaccines As GroupBox
    Friend WithEvents RbtnNoVac As RadioButton
    Friend WithEvents RbtnYesVac As RadioButton
    Friend WithEvents GroupSurgery As GroupBox
    Friend WithEvents RbtnNo As RadioButton
    Friend WithEvents RbtnYes As RadioButton
    Friend WithEvents GroupType As GroupBox
    Friend WithEvents RbtnCat As RadioButton
    Friend WithEvents RbtnDog As RadioButton
    Friend WithEvents GroupSex As GroupBox
    Friend WithEvents RbtnMale As RadioButton
    Friend WithEvents RbtnFemale As RadioButton
    Friend WithEvents TxtColor As TextBox
    Friend WithEvents TxtBreed As TextBox
    Friend WithEvents CheckedSurgery As CheckedListBox
    Friend WithEvents CheckedDeworming As CheckedListBox
    Friend WithEvents CheckedVaccine As CheckedListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtPetIDNo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DpBirthday As DateTimePicker
    Friend WithEvents TxtName As TextBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PicBoxPet As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAddSurgery As Button
    Friend WithEvents DtpSurgeryDate As DateTimePicker
    Friend WithEvents DtpVaccineDate As DateTimePicker
    Friend WithEvents BtnAddVaccine As Button
    Friend WithEvents DtpDewormingDate As DateTimePicker
    Friend WithEvents BtnAddDeworming As Button
End Class
