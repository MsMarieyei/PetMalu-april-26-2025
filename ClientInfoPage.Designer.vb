<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientInfoPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientInfoPage))
        PicBoxPet = New PictureBox()
        Label1 = New Label()
        LblName = New Label()
        LblSex = New Label()
        LblBirthday = New Label()
        LblType = New Label()
        LblColor = New Label()
        LblBreed = New Label()
        LblPetIDNo = New Label()
        LblSurgery = New Label()
        LblVaccines = New Label()
        LblDeworming = New Label()
        TxtName = New TextBox()
        TxtSex = New TextBox()
        TxtType = New TextBox()
        TxtColor = New TextBox()
        TxtBreed = New TextBox()
        TxtPetIDNo = New TextBox()
        TxtSurgery = New TextBox()
        TxtVaccines = New TextBox()
        TxtDeworming = New TextBox()
        Label12 = New Label()
        LblOwnerName = New Label()
        TxtOwnerName = New TextBox()
        TxtOwnerSex = New TextBox()
        TxtPhone = New TextBox()
        LblOwnerSex = New Label()
        LblOwnerPhone = New Label()
        TxtOwnerEmail = New TextBox()
        TxtOwnerAddress = New TextBox()
        LblOwnerEmail = New Label()
        LblOwnerAddress = New Label()
        BtnBack = New Button()
        DtpBirthday = New DateTimePicker()
        PicBoxOwner = New PictureBox()
        CType(PicBoxPet, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBoxOwner, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PicBoxPet
        ' 
        PicBoxPet.BackColor = Color.YellowGreen
        PicBoxPet.Location = New Point(133, 298)
        PicBoxPet.Name = "PicBoxPet"
        PicBoxPet.Size = New Size(355, 337)
        PicBoxPet.SizeMode = PictureBoxSizeMode.StretchImage
        PicBoxPet.TabIndex = 0
        PicBoxPet.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 79.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(448, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(1372, 165)
        Label1.TabIndex = 1
        Label1.Text = "Pet Identification" & vbCrLf
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.BackColor = Color.Transparent
        LblName.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblName.ForeColor = Color.Green
        LblName.Location = New Point(612, 298)
        LblName.Name = "LblName"
        LblName.Size = New Size(128, 44)
        LblName.TabIndex = 2
        LblName.Text = "Name:"
        ' 
        ' LblSex
        ' 
        LblSex.AutoSize = True
        LblSex.BackColor = Color.Transparent
        LblSex.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSex.ForeColor = Color.Green
        LblSex.Location = New Point(649, 372)
        LblSex.Name = "LblSex"
        LblSex.Size = New Size(91, 44)
        LblSex.TabIndex = 3
        LblSex.Text = "Sex:"
        ' 
        ' LblBirthday
        ' 
        LblBirthday.AutoSize = True
        LblBirthday.BackColor = Color.Transparent
        LblBirthday.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblBirthday.ForeColor = Color.Green
        LblBirthday.Location = New Point(560, 452)
        LblBirthday.Name = "LblBirthday"
        LblBirthday.Size = New Size(180, 44)
        LblBirthday.TabIndex = 4
        LblBirthday.Text = "Birthday:"
        ' 
        ' LblType
        ' 
        LblType.AutoSize = True
        LblType.BackColor = Color.Transparent
        LblType.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblType.ForeColor = Color.Green
        LblType.Location = New Point(513, 534)
        LblType.Name = "LblType"
        LblType.Size = New Size(227, 44)
        LblType.TabIndex = 5
        LblType.Text = "Type of Pet:"
        ' 
        ' LblColor
        ' 
        LblColor.AutoSize = True
        LblColor.BackColor = Color.Transparent
        LblColor.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblColor.ForeColor = Color.Green
        LblColor.Location = New Point(614, 602)
        LblColor.Name = "LblColor"
        LblColor.Size = New Size(126, 44)
        LblColor.TabIndex = 6
        LblColor.Text = "Color:"
        ' 
        ' LblBreed
        ' 
        LblBreed.AutoSize = True
        LblBreed.BackColor = Color.Transparent
        LblBreed.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblBreed.ForeColor = Color.Green
        LblBreed.Location = New Point(1364, 298)
        LblBreed.Name = "LblBreed"
        LblBreed.Size = New Size(134, 44)
        LblBreed.TabIndex = 7
        LblBreed.Text = "Breed:"
        ' 
        ' LblPetIDNo
        ' 
        LblPetIDNo.AutoSize = True
        LblPetIDNo.BackColor = Color.Transparent
        LblPetIDNo.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblPetIDNo.ForeColor = Color.Green
        LblPetIDNo.Location = New Point(1303, 375)
        LblPetIDNo.Name = "LblPetIDNo"
        LblPetIDNo.Size = New Size(195, 44)
        LblPetIDNo.TabIndex = 8
        LblPetIDNo.Text = "Pet ID No:"
        ' 
        ' LblSurgery
        ' 
        LblSurgery.AutoSize = True
        LblSurgery.BackColor = Color.Transparent
        LblSurgery.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSurgery.ForeColor = Color.Green
        LblSurgery.Location = New Point(1152, 455)
        LblSurgery.Name = "LblSurgery"
        LblSurgery.Size = New Size(346, 44)
        LblSurgery.TabIndex = 9
        LblSurgery.Text = "Medical Surgeries:"
        ' 
        ' LblVaccines
        ' 
        LblVaccines.AutoSize = True
        LblVaccines.BackColor = Color.Transparent
        LblVaccines.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblVaccines.ForeColor = Color.Green
        LblVaccines.Location = New Point(1313, 531)
        LblVaccines.Name = "LblVaccines"
        LblVaccines.Size = New Size(185, 44)
        LblVaccines.TabIndex = 10
        LblVaccines.Text = "Vaccines:"
        ' 
        ' LblDeworming
        ' 
        LblDeworming.AutoSize = True
        LblDeworming.BackColor = Color.Transparent
        LblDeworming.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblDeworming.ForeColor = Color.Green
        LblDeworming.Location = New Point(1269, 606)
        LblDeworming.Name = "LblDeworming"
        LblDeworming.Size = New Size(229, 44)
        LblDeworming.TabIndex = 11
        LblDeworming.Text = "Deworming:"
        ' 
        ' TxtName
        ' 
        TxtName.BorderStyle = BorderStyle.FixedSingle
        TxtName.Font = New Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtName.Location = New Point(744, 295)
        TxtName.Name = "TxtName"
        TxtName.ReadOnly = True
        TxtName.Size = New Size(285, 50)
        TxtName.TabIndex = 12
        ' 
        ' TxtSex
        ' 
        TxtSex.BorderStyle = BorderStyle.FixedSingle
        TxtSex.Font = New Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtSex.Location = New Point(744, 369)
        TxtSex.Name = "TxtSex"
        TxtSex.ReadOnly = True
        TxtSex.Size = New Size(285, 50)
        TxtSex.TabIndex = 13
        ' 
        ' TxtType
        ' 
        TxtType.BorderStyle = BorderStyle.FixedSingle
        TxtType.Font = New Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtType.Location = New Point(744, 531)
        TxtType.Name = "TxtType"
        TxtType.ReadOnly = True
        TxtType.Size = New Size(285, 50)
        TxtType.TabIndex = 15
        ' 
        ' TxtColor
        ' 
        TxtColor.BorderStyle = BorderStyle.FixedSingle
        TxtColor.Font = New Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtColor.Location = New Point(744, 600)
        TxtColor.Name = "TxtColor"
        TxtColor.ReadOnly = True
        TxtColor.Size = New Size(285, 50)
        TxtColor.TabIndex = 16
        ' 
        ' TxtBreed
        ' 
        TxtBreed.BorderStyle = BorderStyle.FixedSingle
        TxtBreed.Font = New Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBreed.Location = New Point(1502, 295)
        TxtBreed.Name = "TxtBreed"
        TxtBreed.ReadOnly = True
        TxtBreed.Size = New Size(285, 50)
        TxtBreed.TabIndex = 17
        ' 
        ' TxtPetIDNo
        ' 
        TxtPetIDNo.BorderStyle = BorderStyle.FixedSingle
        TxtPetIDNo.Font = New Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtPetIDNo.Location = New Point(1502, 372)
        TxtPetIDNo.Name = "TxtPetIDNo"
        TxtPetIDNo.ReadOnly = True
        TxtPetIDNo.Size = New Size(285, 50)
        TxtPetIDNo.TabIndex = 18
        ' 
        ' TxtSurgery
        ' 
        TxtSurgery.BorderStyle = BorderStyle.FixedSingle
        TxtSurgery.Font = New Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtSurgery.Location = New Point(1502, 452)
        TxtSurgery.Name = "TxtSurgery"
        TxtSurgery.ReadOnly = True
        TxtSurgery.Size = New Size(285, 50)
        TxtSurgery.TabIndex = 19
        ' 
        ' TxtVaccines
        ' 
        TxtVaccines.BorderStyle = BorderStyle.FixedSingle
        TxtVaccines.Font = New Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtVaccines.Location = New Point(1502, 528)
        TxtVaccines.Name = "TxtVaccines"
        TxtVaccines.ReadOnly = True
        TxtVaccines.Size = New Size(285, 50)
        TxtVaccines.TabIndex = 20
        ' 
        ' TxtDeworming
        ' 
        TxtDeworming.BorderStyle = BorderStyle.FixedSingle
        TxtDeworming.Font = New Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtDeworming.Location = New Point(1502, 602)
        TxtDeworming.Name = "TxtDeworming"
        TxtDeworming.ReadOnly = True
        TxtDeworming.Size = New Size(285, 50)
        TxtDeworming.TabIndex = 21
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label12.Location = New Point(42, 715)
        Label12.Name = "Label12"
        Label12.Size = New Size(559, 54)
        Label12.TabIndex = 22
        Label12.Text = "Owner's Identification"
        ' 
        ' LblOwnerName
        ' 
        LblOwnerName.AutoSize = True
        LblOwnerName.BackColor = Color.Transparent
        LblOwnerName.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblOwnerName.ForeColor = Color.Green
        LblOwnerName.Location = New Point(174, 791)
        LblOwnerName.Name = "LblOwnerName"
        LblOwnerName.Size = New Size(119, 41)
        LblOwnerName.TabIndex = 23
        LblOwnerName.Text = "Name:"
        ' 
        ' TxtOwnerName
        ' 
        TxtOwnerName.BorderStyle = BorderStyle.FixedSingle
        TxtOwnerName.Font = New Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtOwnerName.Location = New Point(299, 787)
        TxtOwnerName.Name = "TxtOwnerName"
        TxtOwnerName.ReadOnly = True
        TxtOwnerName.Size = New Size(285, 45)
        TxtOwnerName.TabIndex = 24
        ' 
        ' TxtOwnerSex
        ' 
        TxtOwnerSex.BorderStyle = BorderStyle.FixedSingle
        TxtOwnerSex.Font = New Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtOwnerSex.Location = New Point(299, 854)
        TxtOwnerSex.Name = "TxtOwnerSex"
        TxtOwnerSex.ReadOnly = True
        TxtOwnerSex.Size = New Size(285, 45)
        TxtOwnerSex.TabIndex = 25
        ' 
        ' TxtPhone
        ' 
        TxtPhone.BorderStyle = BorderStyle.FixedSingle
        TxtPhone.Font = New Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtPhone.Location = New Point(299, 918)
        TxtPhone.Name = "TxtPhone"
        TxtPhone.ReadOnly = True
        TxtPhone.Size = New Size(285, 45)
        TxtPhone.TabIndex = 26
        ' 
        ' LblOwnerSex
        ' 
        LblOwnerSex.AutoSize = True
        LblOwnerSex.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblOwnerSex.ForeColor = Color.Green
        LblOwnerSex.Location = New Point(209, 858)
        LblOwnerSex.Name = "LblOwnerSex"
        LblOwnerSex.Size = New Size(84, 41)
        LblOwnerSex.TabIndex = 27
        LblOwnerSex.Text = "Sex:"
        ' 
        ' LblOwnerPhone
        ' 
        LblOwnerPhone.AutoSize = True
        LblOwnerPhone.BackColor = Color.Transparent
        LblOwnerPhone.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblOwnerPhone.ForeColor = Color.Green
        LblOwnerPhone.Location = New Point(162, 922)
        LblOwnerPhone.Name = "LblOwnerPhone"
        LblOwnerPhone.Size = New Size(131, 41)
        LblOwnerPhone.TabIndex = 28
        LblOwnerPhone.Text = "Phone:"
        ' 
        ' TxtOwnerEmail
        ' 
        TxtOwnerEmail.BorderStyle = BorderStyle.FixedSingle
        TxtOwnerEmail.Font = New Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtOwnerEmail.Location = New Point(844, 811)
        TxtOwnerEmail.Name = "TxtOwnerEmail"
        TxtOwnerEmail.ReadOnly = True
        TxtOwnerEmail.Size = New Size(553, 45)
        TxtOwnerEmail.TabIndex = 29
        ' 
        ' TxtOwnerAddress
        ' 
        TxtOwnerAddress.BorderStyle = BorderStyle.FixedSingle
        TxtOwnerAddress.Font = New Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtOwnerAddress.Location = New Point(844, 880)
        TxtOwnerAddress.Name = "TxtOwnerAddress"
        TxtOwnerAddress.ReadOnly = True
        TxtOwnerAddress.Size = New Size(553, 45)
        TxtOwnerAddress.TabIndex = 30
        ' 
        ' LblOwnerEmail
        ' 
        LblOwnerEmail.AutoSize = True
        LblOwnerEmail.BackColor = Color.Transparent
        LblOwnerEmail.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblOwnerEmail.ForeColor = Color.Green
        LblOwnerEmail.Location = New Point(719, 811)
        LblOwnerEmail.Name = "LblOwnerEmail"
        LblOwnerEmail.Size = New Size(119, 41)
        LblOwnerEmail.TabIndex = 31
        LblOwnerEmail.Text = "Email:"
        ' 
        ' LblOwnerAddress
        ' 
        LblOwnerAddress.AutoSize = True
        LblOwnerAddress.BackColor = Color.Transparent
        LblOwnerAddress.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblOwnerAddress.ForeColor = Color.Green
        LblOwnerAddress.Location = New Point(679, 884)
        LblOwnerAddress.Name = "LblOwnerAddress"
        LblOwnerAddress.Size = New Size(159, 41)
        LblOwnerAddress.TabIndex = 32
        LblOwnerAddress.Text = "Address:"
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.DarkSlateGray
        BtnBack.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnBack.ForeColor = Color.White
        BtnBack.Location = New Point(1730, 943)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(135, 63)
        BtnBack.TabIndex = 35
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' DtpBirthday
        ' 
        DtpBirthday.Enabled = False
        DtpBirthday.Location = New Point(744, 452)
        DtpBirthday.Name = "DtpBirthday"
        DtpBirthday.Size = New Size(279, 27)
        DtpBirthday.TabIndex = 36
        ' 
        ' PicBoxOwner
        ' 
        PicBoxOwner.BackColor = Color.YellowGreen
        PicBoxOwner.Location = New Point(1462, 695)
        PicBoxOwner.Name = "PicBoxOwner"
        PicBoxOwner.Size = New Size(280, 230)
        PicBoxOwner.SizeMode = PictureBoxSizeMode.StretchImage
        PicBoxOwner.TabIndex = 37
        PicBoxOwner.TabStop = False
        ' 
        ' ClientInfoPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(PicBoxOwner)
        Controls.Add(DtpBirthday)
        Controls.Add(BtnBack)
        Controls.Add(LblOwnerAddress)
        Controls.Add(LblOwnerEmail)
        Controls.Add(TxtOwnerAddress)
        Controls.Add(TxtOwnerEmail)
        Controls.Add(LblOwnerPhone)
        Controls.Add(LblOwnerSex)
        Controls.Add(TxtPhone)
        Controls.Add(TxtOwnerSex)
        Controls.Add(TxtOwnerName)
        Controls.Add(LblOwnerName)
        Controls.Add(Label12)
        Controls.Add(TxtDeworming)
        Controls.Add(TxtVaccines)
        Controls.Add(TxtSurgery)
        Controls.Add(TxtPetIDNo)
        Controls.Add(TxtBreed)
        Controls.Add(TxtColor)
        Controls.Add(TxtType)
        Controls.Add(TxtSex)
        Controls.Add(TxtName)
        Controls.Add(LblDeworming)
        Controls.Add(LblVaccines)
        Controls.Add(LblSurgery)
        Controls.Add(LblPetIDNo)
        Controls.Add(LblBreed)
        Controls.Add(LblColor)
        Controls.Add(LblType)
        Controls.Add(LblBirthday)
        Controls.Add(LblSex)
        Controls.Add(LblName)
        Controls.Add(Label1)
        Controls.Add(PicBoxPet)
        Name = "ClientInfoPage"
        Text = "Information Page"
        WindowState = FormWindowState.Maximized
        CType(PicBoxPet, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBoxOwner, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PicBoxPet As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblSex As Label
    Friend WithEvents LblBirthday As Label
    Friend WithEvents LblType As Label
    Friend WithEvents LblColor As Label
    Friend WithEvents LblBreed As Label
    Friend WithEvents LblPetIDNo As Label
    Friend WithEvents LblSurgery As Label
    Friend WithEvents LblVaccines As Label
    Friend WithEvents LblDeworming As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtSex As TextBox
    Friend WithEvents TxtType As TextBox
    Friend WithEvents TxtColor As TextBox
    Friend WithEvents TxtBreed As TextBox
    Friend WithEvents TxtPetIDNo As TextBox
    Friend WithEvents TxtSurgery As TextBox
    Friend WithEvents TxtVaccines As TextBox
    Friend WithEvents TxtDeworming As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LblOwnerName As Label
    Friend WithEvents TxtOwnerName As TextBox
    Friend WithEvents TxtOwnerSex As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents LblOwnerSex As Label
    Friend WithEvents LblOwnerPhone As Label
    Friend WithEvents TxtOwnerEmail As TextBox
    Friend WithEvents TxtOwnerAddress As TextBox
    Friend WithEvents LblOwnerEmail As Label
    Friend WithEvents LblOwnerAddress As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents DtpBirthday As DateTimePicker
    Friend WithEvents PicBoxOwner As PictureBox
End Class
