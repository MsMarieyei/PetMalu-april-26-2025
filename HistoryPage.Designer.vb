<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistoryPage))
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        DateTimePicker1 = New DateTimePicker()
        BtnBack = New Button()
        BtnSearch = New Button()
        BtnPrint = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6})
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
        DataGridView1.Location = New Point(127, 355)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1623, 535)
        DataGridView1.TabIndex = 0
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
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "ID"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "ScanDate"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "PetID"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column5.HeaderText = "Name"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column6.HeaderText = "FullName"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.CalendarForeColor = Color.Black
        DateTimePicker1.Font = New Font("Tahoma", 33F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(569, 257)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(962, 74)
        DateTimePicker1.TabIndex = 1
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.DarkSlateGray
        BtnBack.FlatStyle = FlatStyle.Popup
        BtnBack.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnBack.ForeColor = Color.White
        BtnBack.Location = New Point(1706, 903)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(158, 67)
        BtnBack.TabIndex = 2
        BtnBack.Text = "BACK"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' BtnSearch
        ' 
        BtnSearch.BackColor = Color.OliveDrab
        BtnSearch.FlatStyle = FlatStyle.Popup
        BtnSearch.Font = New Font("Britannic Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnSearch.ForeColor = SystemColors.Control
        BtnSearch.Location = New Point(1559, 257)
        BtnSearch.Name = "BtnSearch"
        BtnSearch.Size = New Size(191, 77)
        BtnSearch.TabIndex = 3
        BtnSearch.Text = "Search"
        BtnSearch.UseVisualStyleBackColor = False
        ' 
        ' BtnPrint
        ' 
        BtnPrint.BackColor = Color.Green
        BtnPrint.FlatStyle = FlatStyle.Popup
        BtnPrint.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnPrint.ForeColor = Color.White
        BtnPrint.Location = New Point(1523, 903)
        BtnPrint.Name = "BtnPrint"
        BtnPrint.Size = New Size(159, 67)
        BtnPrint.TabIndex = 4
        BtnPrint.Text = "PRINT"
        BtnPrint.UseVisualStyleBackColor = False
        ' 
        ' PrintDocument1
        ' 
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(729, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(592, 149)
        Label1.TabIndex = 5
        Label1.Text = "HISTORY"
        ' 
        ' HistoryPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(Label1)
        Controls.Add(BtnPrint)
        Controls.Add(BtnSearch)
        Controls.Add(BtnBack)
        Controls.Add(DateTimePicker1)
        Controls.Add(DataGridView1)
        Name = "HistoryPage"
        Text = "History"
        WindowState = FormWindowState.Maximized
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
