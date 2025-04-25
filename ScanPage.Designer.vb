<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScanPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScanPage))
        TxtScanNo = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        BtnBack = New Button()
        TextBox = New TextBox()
        SuspendLayout()
        ' 
        ' TxtScanNo
        ' 
        TxtScanNo.BackColor = Color.YellowGreen
        TxtScanNo.BorderStyle = BorderStyle.FixedSingle
        TxtScanNo.Font = New Font("Segoe UI Variable Display", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtScanNo.Location = New Point(726, 499)
        TxtScanNo.Name = "TxtScanNo"
        TxtScanNo.Size = New Size(460, 47)
        TxtScanNo.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label1.Location = New Point(523, 155)
        Label1.Name = "Label1"
        Label1.Size = New Size(1206, 149)
        Label1.TabIndex = 1
        Label1.Text = "Hello! Kindly Tap"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Showcard Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label2.Location = New Point(881, 287)
        Label2.Name = "Label2"
        Label2.Size = New Size(451, 149)
        Label2.TabIndex = 2
        Label2.Text = "the ID"
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.DarkSlateGray
        BtnBack.FlatStyle = FlatStyle.Popup
        BtnBack.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnBack.ForeColor = Color.White
        BtnBack.Location = New Point(1642, 891)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(181, 71)
        BtnBack.TabIndex = 3
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' TextBox
        ' 
        TextBox.BackColor = Color.White
        TextBox.BorderStyle = BorderStyle.None
        TextBox.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox.Location = New Point(726, 478)
        TextBox.Name = "TextBox"
        TextBox.Size = New Size(478, 80)
        TextBox.TabIndex = 4
        ' 
        ' ScanPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.YellowGreen
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(TextBox)
        Controls.Add(BtnBack)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TxtScanNo)
        Name = "ScanPage"
        Text = "ScanPage"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtScanNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents TextBox As TextBox
End Class
