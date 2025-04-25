<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientSelectionPage
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
        ListBoxClients = New ListBox()
        BtnSelect = New Button()
        BtnBack = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ListBoxClients
        ' 
        ListBoxClients.BackColor = Color.DarkSeaGreen
        ListBoxClients.Font = New Font("Showcard Gothic", 24F)
        ListBoxClients.FormattingEnabled = True
        ListBoxClients.ItemHeight = 50
        ListBoxClients.Location = New Point(180, 330)
        ListBoxClients.Name = "ListBoxClients"
        ListBoxClients.Size = New Size(1546, 554)
        ListBoxClients.TabIndex = 0
        ' 
        ' BtnSelect
        ' 
        BtnSelect.BackColor = Color.Green
        BtnSelect.FlatStyle = FlatStyle.Popup
        BtnSelect.Font = New Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnSelect.ForeColor = Color.White
        BtnSelect.Location = New Point(1479, 931)
        BtnSelect.Name = "BtnSelect"
        BtnSelect.Size = New Size(149, 64)
        BtnSelect.TabIndex = 32
        BtnSelect.Text = "SELECT"
        BtnSelect.UseVisualStyleBackColor = False
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.DarkSlateGray
        BtnBack.FlatStyle = FlatStyle.Popup
        BtnBack.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnBack.ForeColor = Color.White
        BtnBack.Location = New Point(1644, 931)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(150, 64)
        BtnBack.TabIndex = 33
        BtnBack.Text = "BACK"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 100F)
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(745, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(725, 207)
        Label1.TabIndex = 34
        Label1.Text = "CLIENTS"
        ' 
        ' ClientSelectionPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.PETMALU_SYSTEM_DESIGN__35_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(Label1)
        Controls.Add(BtnBack)
        Controls.Add(BtnSelect)
        Controls.Add(ListBoxClients)
        Name = "ClientSelectionPage"
        Text = "ClientSelectionPage"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBoxClients As ListBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnSelect As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label1 As Label
End Class
