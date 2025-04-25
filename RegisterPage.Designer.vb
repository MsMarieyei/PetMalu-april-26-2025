<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterPage))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        BtnRegister = New Button()
        txtname = New TextBox()
        txtemail = New TextBox()
        txtpassword = New TextBox()
        txtphone = New TextBox()
        BtnBack = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 82.2000046F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(392, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(1508, 172)
        Label1.TabIndex = 0
        Label1.Text = "Admin Registration"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label2.Location = New Point(529, 375)
        Label2.Name = "Label2"
        Label2.Size = New Size(224, 48)
        Label2.TabIndex = 1
        Label2.Text = "Full Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label3.Location = New Point(610, 477)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 48)
        Label3.TabIndex = 2
        Label3.Text = "Email:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label4.Location = New Point(529, 580)
        Label4.Name = "Label4"
        Label4.Size = New Size(220, 48)
        Label4.TabIndex = 3
        Label4.Text = "Password:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label5.Location = New Point(594, 683)
        Label5.Name = "Label5"
        Label5.Size = New Size(155, 48)
        Label5.TabIndex = 4
        Label5.Text = "Phone:"
        ' 
        ' BtnRegister
        ' 
        BtnRegister.BackColor = Color.Green
        BtnRegister.FlatStyle = FlatStyle.Popup
        BtnRegister.Font = New Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnRegister.ForeColor = Color.White
        BtnRegister.Location = New Point(851, 809)
        BtnRegister.Name = "BtnRegister"
        BtnRegister.Size = New Size(178, 54)
        BtnRegister.TabIndex = 5
        BtnRegister.Text = "Register"
        BtnRegister.UseVisualStyleBackColor = False
        ' 
        ' txtname
        ' 
        txtname.BackColor = Color.YellowGreen
        txtname.BorderStyle = BorderStyle.FixedSingle
        txtname.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtname.Location = New Point(755, 374)
        txtname.Name = "txtname"
        txtname.Size = New Size(580, 54)
        txtname.TabIndex = 6
        ' 
        ' txtemail
        ' 
        txtemail.BackColor = Color.YellowGreen
        txtemail.BorderStyle = BorderStyle.FixedSingle
        txtemail.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtemail.Location = New Point(755, 476)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(580, 54)
        txtemail.TabIndex = 7
        ' 
        ' txtpassword
        ' 
        txtpassword.BackColor = Color.YellowGreen
        txtpassword.BorderStyle = BorderStyle.FixedSingle
        txtpassword.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtpassword.ForeColor = SystemColors.WindowText
        txtpassword.Location = New Point(755, 579)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(580, 54)
        txtpassword.TabIndex = 8
        ' 
        ' txtphone
        ' 
        txtphone.BackColor = Color.YellowGreen
        txtphone.BorderStyle = BorderStyle.FixedSingle
        txtphone.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtphone.Location = New Point(755, 682)
        txtphone.Name = "txtphone"
        txtphone.Size = New Size(580, 54)
        txtphone.TabIndex = 9
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.DarkSlateGray
        BtnBack.FlatStyle = FlatStyle.Popup
        BtnBack.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnBack.ForeColor = Color.White
        BtnBack.Location = New Point(1694, 885)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(176, 78)
        BtnBack.TabIndex = 10
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' RegisterPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(BtnBack)
        Controls.Add(txtphone)
        Controls.Add(txtpassword)
        Controls.Add(txtemail)
        Controls.Add(txtname)
        Controls.Add(BtnRegister)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "RegisterPage"
        Text = "Registration"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnRegister As Button
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents BtnBack As Button
End Class
