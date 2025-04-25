<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetPasswordPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResetPasswordPage))
        Label1 = New Label()
        Label2 = New Label()
        BtnSubmit = New Button()
        TxtNewPassword = New TextBox()
        TxtReEnterPassword = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(617, 434)
        Label1.Name = "Label1"
        Label1.Size = New Size(423, 48)
        Label1.TabIndex = 0
        Label1.Text = "Enter new password:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Britannic Bold", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label2.Location = New Point(617, 568)
        Label2.Name = "Label2"
        Label2.Size = New Size(584, 48)
        Label2.TabIndex = 1
        Label2.Text = "Re-enter your new password:"
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.BackColor = Color.Green
        BtnSubmit.FlatStyle = FlatStyle.Popup
        BtnSubmit.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnSubmit.ForeColor = Color.White
        BtnSubmit.Location = New Point(878, 731)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(127, 48)
        BtnSubmit.TabIndex = 2
        BtnSubmit.Text = "Submit"
        BtnSubmit.UseVisualStyleBackColor = False
        ' 
        ' TxtNewPassword
        ' 
        TxtNewPassword.BorderStyle = BorderStyle.FixedSingle
        TxtNewPassword.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtNewPassword.Location = New Point(640, 485)
        TxtNewPassword.Name = "TxtNewPassword"
        TxtNewPassword.Size = New Size(630, 54)
        TxtNewPassword.TabIndex = 3
        ' 
        ' TxtReEnterPassword
        ' 
        TxtReEnterPassword.BorderStyle = BorderStyle.FixedSingle
        TxtReEnterPassword.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtReEnterPassword.Location = New Point(640, 619)
        TxtReEnterPassword.Name = "TxtReEnterPassword"
        TxtReEnterPassword.Size = New Size(630, 54)
        TxtReEnterPassword.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Showcard Gothic", 97.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label3.Location = New Point(389, -1)
        Label3.Name = "Label3"
        Label3.Size = New Size(1474, 202)
        Label3.TabIndex = 5
        Label3.Text = "Reset Password"
        ' 
        ' ResetPasswordPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(Label3)
        Controls.Add(TxtReEnterPassword)
        Controls.Add(TxtNewPassword)
        Controls.Add(BtnSubmit)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ResetPasswordPage"
        Text = "ResetPasswordPage"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents TxtNewPassword As TextBox
    Friend WithEvents TxtReEnterPassword As TextBox
    Friend WithEvents Label3 As Label
End Class
