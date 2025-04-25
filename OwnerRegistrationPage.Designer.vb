<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OwnerRegistrationPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OwnerRegistrationPage))
        Label1 = New Label()
        PicBoxClient = New PictureBox()
        BtnUploadPhoto = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TxtName = New TextBox()
        TxtAddress = New TextBox()
        RbtnFemale = New RadioButton()
        RbtnMale = New RadioButton()
        TxtPhone = New TextBox()
        TxtEmail = New TextBox()
        BtnNext = New Button()
        BtnBack = New Button()
        Label7 = New Label()
        CType(PicBoxClient, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 60F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(506, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(1343, 124)
        Label1.TabIndex = 0
        Label1.Text = "Client/Pet Registration" & vbCrLf
        ' 
        ' PicBoxClient
        ' 
        PicBoxClient.BackColor = Color.YellowGreen
        PicBoxClient.Location = New Point(1282, 350)
        PicBoxClient.Name = "PicBoxClient"
        PicBoxClient.Size = New Size(359, 309)
        PicBoxClient.SizeMode = PictureBoxSizeMode.AutoSize
        PicBoxClient.TabIndex = 1
        PicBoxClient.TabStop = False
        ' 
        ' BtnUploadPhoto
        ' 
        BtnUploadPhoto.BackColor = Color.Teal
        BtnUploadPhoto.FlatStyle = FlatStyle.Popup
        BtnUploadPhoto.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnUploadPhoto.ForeColor = Color.White
        BtnUploadPhoto.Location = New Point(1351, 690)
        BtnUploadPhoto.Name = "BtnUploadPhoto"
        BtnUploadPhoto.Size = New Size(238, 49)
        BtnUploadPhoto.TabIndex = 2
        BtnUploadPhoto.Text = "Upload Owner's Photo"
        BtnUploadPhoto.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label2.Location = New Point(247, 401)
        Label2.Name = "Label2"
        Label2.Size = New Size(224, 48)
        Label2.TabIndex = 3
        Label2.Text = "Full Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label3.Location = New Point(283, 499)
        Label3.Name = "Label3"
        Label3.Size = New Size(188, 48)
        Label3.TabIndex = 4
        Label3.Text = "Address:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label4.Location = New Point(371, 575)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 48)
        Label4.TabIndex = 5
        Label4.Text = "Sex:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label5.Location = New Point(329, 695)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 44)
        Label5.TabIndex = 6
        Label5.Text = "Phone:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label6.Location = New Point(344, 796)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 44)
        Label6.TabIndex = 7
        Label6.Text = "Email:"
        ' 
        ' TxtName
        ' 
        TxtName.BackColor = Color.White
        TxtName.BorderStyle = BorderStyle.FixedSingle
        TxtName.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtName.Location = New Point(477, 400)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(543, 54)
        TxtName.TabIndex = 8
        ' 
        ' TxtAddress
        ' 
        TxtAddress.BackColor = Color.White
        TxtAddress.BorderStyle = BorderStyle.FixedSingle
        TxtAddress.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtAddress.Location = New Point(477, 498)
        TxtAddress.Name = "TxtAddress"
        TxtAddress.Size = New Size(543, 54)
        TxtAddress.TabIndex = 9
        ' 
        ' RbtnFemale
        ' 
        RbtnFemale.AutoSize = True
        RbtnFemale.BackColor = Color.Transparent
        RbtnFemale.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnFemale.Location = New Point(477, 575)
        RbtnFemale.Name = "RbtnFemale"
        RbtnFemale.Size = New Size(153, 45)
        RbtnFemale.TabIndex = 10
        RbtnFemale.TabStop = True
        RbtnFemale.Text = "Female"
        RbtnFemale.UseVisualStyleBackColor = False
        ' 
        ' RbtnMale
        ' 
        RbtnMale.AutoSize = True
        RbtnMale.BackColor = Color.Transparent
        RbtnMale.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnMale.Location = New Point(477, 626)
        RbtnMale.Name = "RbtnMale"
        RbtnMale.Size = New Size(114, 45)
        RbtnMale.TabIndex = 11
        RbtnMale.TabStop = True
        RbtnMale.Text = "Male"
        RbtnMale.UseVisualStyleBackColor = False
        ' 
        ' TxtPhone
        ' 
        TxtPhone.BackColor = Color.White
        TxtPhone.BorderStyle = BorderStyle.FixedSingle
        TxtPhone.Font = New Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtPhone.Location = New Point(477, 694)
        TxtPhone.Name = "TxtPhone"
        TxtPhone.Size = New Size(543, 50)
        TxtPhone.TabIndex = 12
        ' 
        ' TxtEmail
        ' 
        TxtEmail.BackColor = Color.White
        TxtEmail.BorderStyle = BorderStyle.FixedSingle
        TxtEmail.Font = New Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtEmail.ForeColor = Color.Black
        TxtEmail.Location = New Point(477, 795)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(543, 50)
        TxtEmail.TabIndex = 13
        ' 
        ' BtnNext
        ' 
        BtnNext.BackColor = Color.Green
        BtnNext.FlatStyle = FlatStyle.Popup
        BtnNext.Font = New Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnNext.ForeColor = Color.White
        BtnNext.Location = New Point(1513, 880)
        BtnNext.Name = "BtnNext"
        BtnNext.Size = New Size(140, 60)
        BtnNext.TabIndex = 14
        BtnNext.Text = "NEXT"
        BtnNext.UseVisualStyleBackColor = False
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.DarkSlateGray
        BtnBack.FlatStyle = FlatStyle.Popup
        BtnBack.Font = New Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnBack.ForeColor = Color.White
        BtnBack.Location = New Point(1673, 880)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(140, 60)
        BtnBack.TabIndex = 15
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Imprint MT Shadow", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label7.Location = New Point(873, 214)
        Label7.Name = "Label7"
        Label7.Size = New Size(617, 56)
        Label7.TabIndex = 16
        Label7.Text = "OWNER INFORMATION" & vbCrLf
        ' 
        ' OwnerRegistrationPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(Label7)
        Controls.Add(BtnBack)
        Controls.Add(BtnNext)
        Controls.Add(TxtEmail)
        Controls.Add(TxtPhone)
        Controls.Add(RbtnMale)
        Controls.Add(RbtnFemale)
        Controls.Add(TxtAddress)
        Controls.Add(TxtName)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(BtnUploadPhoto)
        Controls.Add(PicBoxClient)
        Controls.Add(Label1)
        Name = "OwnerRegistrationPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Owner Registration Page"
        WindowState = FormWindowState.Maximized
        CType(PicBoxClient, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PicBoxClient As PictureBox
    Friend WithEvents BtnUploadPhoto As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents RbtnFemale As RadioButton
    Friend WithEvents RbtnMale As RadioButton
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label7 As Label
End Class
