<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordsPage
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecordsPage))
        BtnBack = New Button()
        BtnPrint = New Button()
        BtnUpdate = New Button()
        BtnDelete = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        Column14 = New DataGridViewTextBoxColumn()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDialog1 = New PrintDialog()
        BtnInsert = New Button()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.DarkSlateGray
        BtnBack.FlatStyle = FlatStyle.Popup
        BtnBack.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnBack.ForeColor = Color.White
        BtnBack.Location = New Point(1705, 856)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(150, 64)
        BtnBack.TabIndex = 1
        BtnBack.Text = "BACK"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' BtnPrint
        ' 
        BtnPrint.BackColor = Color.Green
        BtnPrint.FlatStyle = FlatStyle.Popup
        BtnPrint.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnPrint.ForeColor = Color.White
        BtnPrint.Location = New Point(1534, 856)
        BtnPrint.Name = "BtnPrint"
        BtnPrint.Size = New Size(154, 64)
        BtnPrint.TabIndex = 2
        BtnPrint.Text = "PRINT"
        BtnPrint.UseVisualStyleBackColor = False
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.BackColor = Color.Teal
        BtnUpdate.FlatStyle = FlatStyle.Popup
        BtnUpdate.Font = New Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnUpdate.ForeColor = Color.White
        BtnUpdate.Location = New Point(1344, 858)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(175, 64)
        BtnUpdate.TabIndex = 3
        BtnUpdate.Text = "UPDATE"
        BtnUpdate.UseVisualStyleBackColor = False
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackColor = Color.YellowGreen
        BtnDelete.FlatStyle = FlatStyle.Popup
        BtnDelete.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnDelete.ForeColor = Color.White
        BtnDelete.Location = New Point(1153, 860)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(175, 62)
        BtnDelete.TabIndex = 4
        BtnDelete.Text = "DELETE"
        BtnDelete.UseVisualStyleBackColor = False
        ' 
        ' PrintDocument1
        ' 
        PrintDocument1.DocumentName = "Record Print"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.BackgroundColor = Color.DarkSeaGreen
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.YellowGreen
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Color.DarkGreen
        DataGridViewCellStyle1.SelectionForeColor = Color.Honeydew
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeight = 30
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Honeydew
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.DarkSeaGreen
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = SystemColors.WindowText
        DataGridView1.Location = New Point(54, 369)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1801, 439)
        DataGridView1.TabIndex = 5
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "#"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "PetID"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Name"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Sex"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Birthday"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Type"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 125
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Breed"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Width = 125
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Color"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.Width = 125
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "SurgeryType"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.Width = 125
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "SurgeryDate"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.Width = 125
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "DewormingName"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.Width = 125
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "DewormingDate"
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        Column12.Width = 125
        ' 
        ' Column13
        ' 
        Column13.HeaderText = "VaccineName"
        Column13.MinimumWidth = 6
        Column13.Name = "Column13"
        Column13.Width = 125
        ' 
        ' Column14
        ' 
        Column14.HeaderText = "VaccinationDate"
        Column14.MinimumWidth = 6
        Column14.Name = "Column14"
        Column14.Width = 125
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' BtnInsert
        ' 
        BtnInsert.BackColor = Color.OliveDrab
        BtnInsert.FlatStyle = FlatStyle.Popup
        BtnInsert.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnInsert.ForeColor = Color.White
        BtnInsert.Location = New Point(973, 860)
        BtnInsert.Name = "BtnInsert"
        BtnInsert.Size = New Size(163, 62)
        BtnInsert.TabIndex = 6
        BtnInsert.Text = "ADD"
        BtnInsert.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 120F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(770, -19)
        Label1.Name = "Label1"
        Label1.Size = New Size(888, 249)
        Label1.TabIndex = 7
        Label1.Text = "Record"
        ' 
        ' RecordsPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1902, 1033)
        Controls.Add(Label1)
        Controls.Add(BtnInsert)
        Controls.Add(DataGridView1)
        Controls.Add(BtnDelete)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnPrint)
        Controls.Add(BtnBack)
        Name = "RecordsPage"
        Text = "RecordsPage"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents BtnInsert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
End Class
