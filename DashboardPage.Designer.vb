<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardPage))
        BtnHistory = New Button()
        LinkLogout = New LinkLabel()
        LinkClients = New LinkLabel()
        LinkScan = New LinkLabel()
        LinkPetInfo = New LinkLabel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' BtnHistory
        ' 
        BtnHistory.BackColor = Color.DarkOliveGreen
        BtnHistory.FlatStyle = FlatStyle.Popup
        BtnHistory.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnHistory.ForeColor = Color.White
        BtnHistory.Location = New Point(67, 897)
        BtnHistory.Name = "BtnHistory"
        BtnHistory.Size = New Size(176, 70)
        BtnHistory.TabIndex = 3
        BtnHistory.Text = "History"
        BtnHistory.UseVisualStyleBackColor = False
        ' 
        ' LinkLogout
        ' 
        LinkLogout.ActiveLinkColor = Color.Green
        LinkLogout.AutoSize = True
        LinkLogout.BackColor = Color.Transparent
        LinkLogout.Font = New Font("Showcard Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLogout.LinkColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        LinkLogout.Location = New Point(1613, 905)
        LinkLogout.Name = "LinkLogout"
        LinkLogout.Size = New Size(224, 62)
        LinkLogout.TabIndex = 4
        LinkLogout.TabStop = True
        LinkLogout.Text = "Logout"
        LinkLogout.VisitedLinkColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        ' 
        ' LinkClients
        ' 
        LinkClients.ActiveLinkColor = Color.Green
        LinkClients.AutoSize = True
        LinkClients.BackColor = Color.Transparent
        LinkClients.Font = New Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkClients.LinkColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        LinkClients.Location = New Point(1048, 14)
        LinkClients.Name = "LinkClients"
        LinkClients.Size = New Size(522, 149)
        LinkClients.TabIndex = 5
        LinkClients.TabStop = True
        LinkClients.Text = "Clients"
        LinkClients.VisitedLinkColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        ' 
        ' LinkScan
        ' 
        LinkScan.ActiveLinkColor = Color.Green
        LinkScan.AutoSize = True
        LinkScan.BackColor = Color.Transparent
        LinkScan.Font = New Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkScan.LinkColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        LinkScan.Location = New Point(1556, 14)
        LinkScan.Name = "LinkScan"
        LinkScan.Size = New Size(345, 149)
        LinkScan.TabIndex = 6
        LinkScan.TabStop = True
        LinkScan.Text = "Scan"
        LinkScan.VisitedLinkColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        ' 
        ' LinkPetInfo
        ' 
        LinkPetInfo.ActiveLinkColor = Color.Green
        LinkPetInfo.AutoSize = True
        LinkPetInfo.BackColor = Color.Transparent
        LinkPetInfo.Font = New Font("Showcard Gothic", 45F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkPetInfo.LinkColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        LinkPetInfo.Location = New Point(485, -1)
        LinkPetInfo.Name = "LinkPetInfo"
        LinkPetInfo.Size = New Size(567, 186)
        LinkPetInfo.TabIndex = 7
        LinkPetInfo.TabStop = True
        LinkPetInfo.Text = "Client/Pet" & vbCrLf & "Registration" & vbCrLf
        LinkPetInfo.TextAlign = ContentAlignment.MiddleCenter
        LinkPetInfo.VisitedLinkColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label1.Location = New Point(58, 349)
        Label1.Name = "Label1"
        Label1.Size = New Size(581, 59)
        Label1.TabIndex = 9
        Label1.Text = "Republic Act No. 8485:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label2.Location = New Point(704, 308)
        Label2.Name = "Label2"
        Label2.Size = New Size(556, 59)
        Label2.TabIndex = 10
        Label2.Text = "Republic Act No. 10631"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label3.Location = New Point(1305, 256)
        Label3.Name = "Label3"
        Label3.Size = New Size(541, 59)
        Label3.TabIndex = 11
        Label3.Text = "Republic Act No. 9482"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Teal
        Label4.Location = New Point(91, 403)
        Label4.Name = "Label4"
        Label4.Size = New Size(524, 100)
        Label4.TabIndex = 12
        Label4.Text = "The Animal Welfare Act" & vbCrLf & "of 1998:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Teal
        Label5.Location = New Point(701, 367)
        Label5.Name = "Label5"
        Label5.Size = New Size(561, 50)
        Label5.TabIndex = 13
        Label5.Text = "Amendment to the animal" & vbCrLf
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Teal
        Label6.Location = New Point(755, 417)
        Label6.Name = "Label6"
        Label6.Size = New Size(449, 50)
        Label6.TabIndex = 14
        Label6.Text = "welfare act of 1998:" & vbCrLf
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Teal
        Label7.Location = New Point(1365, 308)
        Label7.Name = "Label7"
        Label7.Size = New Size(435, 100)
        Label7.TabIndex = 15
        Label7.Text = "The Anti-Rabies Act" & vbCrLf & "of 2007:" & vbCrLf
        Label7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' DashboardPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LinkPetInfo)
        Controls.Add(LinkScan)
        Controls.Add(LinkClients)
        Controls.Add(LinkLogout)
        Controls.Add(BtnHistory)
        Name = "DashboardPage"
        Text = "Dashboard"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnHistory As Button
    Friend WithEvents LinkLogout As LinkLabel
    Friend WithEvents LinkClients As LinkLabel
    Friend WithEvents LinkScan As LinkLabel
    Friend WithEvents LinkPetInfo As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
