<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateOwnerDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateOwnerDetails))
        BtnBack = New Button()
        BtnNext = New Button()
        TxtEmail = New TextBox()
        TxtPhone = New TextBox()
        RbtnMale = New RadioButton()
        RbtnFemale = New RadioButton()
        TxtAddress = New TextBox()
        TxtName = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PicBoxOwner = New PictureBox()
        Label1 = New Label()
        CType(PicBoxOwner, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.DarkSlateGray
        BtnBack.FlatStyle = FlatStyle.Popup
        BtnBack.Font = New Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnBack.ForeColor = Color.White
        BtnBack.Location = New Point(1576, 904)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(140, 60)
        BtnBack.TabIndex = 32
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' BtnNext
        ' 
        BtnNext.BackColor = Color.Green
        BtnNext.FlatStyle = FlatStyle.Popup
        BtnNext.Font = New Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnNext.ForeColor = Color.White
        BtnNext.Location = New Point(1416, 904)
        BtnNext.Name = "BtnNext"
        BtnNext.Size = New Size(140, 60)
        BtnNext.TabIndex = 31
        BtnNext.Text = "NEXT"
        BtnNext.UseVisualStyleBackColor = False
        ' 
        ' TxtEmail
        ' 
        TxtEmail.BackColor = Color.White
        TxtEmail.BorderStyle = BorderStyle.FixedSingle
        TxtEmail.Font = New Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtEmail.ForeColor = Color.Black
        TxtEmail.Location = New Point(380, 819)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(543, 50)
        TxtEmail.TabIndex = 30
        ' 
        ' TxtPhone
        ' 
        TxtPhone.BackColor = Color.White
        TxtPhone.BorderStyle = BorderStyle.FixedSingle
        TxtPhone.Font = New Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtPhone.Location = New Point(380, 718)
        TxtPhone.Name = "TxtPhone"
        TxtPhone.Size = New Size(543, 50)
        TxtPhone.TabIndex = 29
        ' 
        ' RbtnMale
        ' 
        RbtnMale.AutoSize = True
        RbtnMale.BackColor = Color.Transparent
        RbtnMale.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnMale.Location = New Point(380, 650)
        RbtnMale.Name = "RbtnMale"
        RbtnMale.Size = New Size(114, 45)
        RbtnMale.TabIndex = 28
        RbtnMale.TabStop = True
        RbtnMale.Text = "Male"
        RbtnMale.UseVisualStyleBackColor = False
        ' 
        ' RbtnFemale
        ' 
        RbtnFemale.AutoSize = True
        RbtnFemale.BackColor = Color.Transparent
        RbtnFemale.Font = New Font("Britannic Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RbtnFemale.Location = New Point(380, 599)
        RbtnFemale.Name = "RbtnFemale"
        RbtnFemale.Size = New Size(153, 45)
        RbtnFemale.TabIndex = 27
        RbtnFemale.TabStop = True
        RbtnFemale.Text = "Female"
        RbtnFemale.UseVisualStyleBackColor = False
        ' 
        ' TxtAddress
        ' 
        TxtAddress.BackColor = Color.White
        TxtAddress.BorderStyle = BorderStyle.FixedSingle
        TxtAddress.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtAddress.Location = New Point(380, 522)
        TxtAddress.Name = "TxtAddress"
        TxtAddress.Size = New Size(543, 54)
        TxtAddress.TabIndex = 26
        ' 
        ' TxtName
        ' 
        TxtName.BackColor = Color.White
        TxtName.BorderStyle = BorderStyle.FixedSingle
        TxtName.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtName.Location = New Point(380, 424)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(543, 54)
        TxtName.TabIndex = 25
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label6.Location = New Point(247, 820)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 44)
        Label6.TabIndex = 24
        Label6.Text = "Email:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label5.Location = New Point(232, 719)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 44)
        Label5.TabIndex = 23
        Label5.Text = "Phone:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label4.Location = New Point(274, 599)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 48)
        Label4.TabIndex = 22
        Label4.Text = "Sex:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label3.Location = New Point(186, 523)
        Label3.Name = "Label3"
        Label3.Size = New Size(188, 48)
        Label3.TabIndex = 21
        Label3.Text = "Address:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label2.Location = New Point(150, 425)
        Label2.Name = "Label2"
        Label2.Size = New Size(224, 48)
        Label2.TabIndex = 20
        Label2.Text = "Full Name:"
        ' 
        ' PicBoxOwner
        ' 
        PicBoxOwner.BackColor = Color.YellowGreen
        PicBoxOwner.Location = New Point(1185, 374)
        PicBoxOwner.Name = "PicBoxOwner"
        PicBoxOwner.Size = New Size(359, 309)
        PicBoxOwner.SizeMode = PictureBoxSizeMode.StretchImage
        PicBoxOwner.TabIndex = 18
        PicBoxOwner.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 60F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(448, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(1108, 124)
        Label1.TabIndex = 17
        Label1.Text = "OWNER INFORMATION"
        ' 
        ' UpdateOwnerDetails
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
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
        Controls.Add(PicBoxOwner)
        Controls.Add(Label1)
        Name = "UpdateOwnerDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UpdateOwnerDetails"
        WindowState = FormWindowState.Maximized
        CType(PicBoxOwner, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents RbtnMale As RadioButton
    Friend WithEvents RbtnFemale As RadioButton
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PicBoxClient As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PicBoxOwner As PictureBox
End Class
