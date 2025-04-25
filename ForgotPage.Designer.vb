<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPage))
        Label1 = New Label()
        Label2 = New Label()
        txtemail = New TextBox()
        Label3 = New Label()
        BtnResetPassword = New Button()
        BtnBack = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 79.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(394, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(1337, 165)
        Label1.TabIndex = 0
        Label1.Text = "Forgot Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label2.Location = New Point(610, 485)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 52)
        Label2.TabIndex = 1
        Label2.Text = "Email:"
        ' 
        ' txtemail
        ' 
        txtemail.BackColor = Color.YellowGreen
        txtemail.BorderStyle = BorderStyle.FixedSingle
        txtemail.Font = New Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtemail.Location = New Point(631, 540)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(627, 53)
        txtemail.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Georgia", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(631, 596)
        Label3.Name = "Label3"
        Label3.Size = New Size(509, 27)
        Label3.TabIndex = 3
        Label3.Text = "Please enter your email to reset your password."
        ' 
        ' BtnResetPassword
        ' 
        BtnResetPassword.BackColor = Color.Green
        BtnResetPassword.FlatStyle = FlatStyle.Popup
        BtnResetPassword.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnResetPassword.ForeColor = Color.White
        BtnResetPassword.Location = New Point(875, 706)
        BtnResetPassword.Name = "BtnResetPassword"
        BtnResetPassword.Size = New Size(135, 50)
        BtnResetPassword.TabIndex = 4
        BtnResetPassword.Text = "Submit"
        BtnResetPassword.UseVisualStyleBackColor = False
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.DarkSlateGray
        BtnBack.FlatStyle = FlatStyle.Popup
        BtnBack.Font = New Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnBack.ForeColor = Color.White
        BtnBack.Location = New Point(1701, 880)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(169, 77)
        BtnBack.TabIndex = 5
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' ForgotPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(BtnBack)
        Controls.Add(BtnResetPassword)
        Controls.Add(Label3)
        Controls.Add(txtemail)
        Controls.Add(Label2)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "ForgotPage"
        Text = "Forgot Password"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnResetPassword As Button
    Friend WithEvents BtnBack As Button
End Class
