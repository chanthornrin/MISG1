<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Category
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
        Me.Topproduct = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewCategory = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtcatbrand = New System.Windows.Forms.TextBox()
        Me.txtcatname = New System.Windows.Forms.TextBox()
        Me.txtcatId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Topproduct.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Topproduct
        '
        Me.Topproduct.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Topproduct.Controls.Add(Me.Label1)
        Me.Topproduct.Dock = System.Windows.Forms.DockStyle.Top
        Me.Topproduct.Location = New System.Drawing.Point(0, 0)
        Me.Topproduct.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Topproduct.Name = "Topproduct"
        Me.Topproduct.Size = New System.Drawing.Size(1077, 46)
        Me.Topproduct.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Category"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.DataGridViewCategory)
        Me.Panel1.Controls.Add(Me.txtcatbrand)
        Me.Panel1.Controls.Add(Me.txtcatname)
        Me.Panel1.Controls.Add(Me.txtcatId)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 46)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1077, 511)
        Me.Panel1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(985, 23)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(900, 23)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridViewCategory
        '
        Me.DataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCategory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.Column3, Me.Column6, Me.Column8, Me.Column9})
        Me.DataGridViewCategory.Location = New System.Drawing.Point(9, 67)
        Me.DataGridViewCategory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridViewCategory.Name = "DataGridViewCategory"
        Me.DataGridViewCategory.RowHeadersWidth = 51
        Me.DataGridViewCategory.RowTemplate.Height = 24
        Me.DataGridViewCategory.Size = New System.Drawing.Size(1059, 423)
        Me.DataGridViewCategory.TabIndex = 58
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "ID"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 39
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Name"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Brand"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "Edit"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 50
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "Delete"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 63
        '
        'txtcatbrand
        '
        Me.txtcatbrand.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtcatbrand.Location = New System.Drawing.Point(683, 23)
        Me.txtcatbrand.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcatbrand.Name = "txtcatbrand"
        Me.txtcatbrand.Size = New System.Drawing.Size(200, 32)
        Me.txtcatbrand.TabIndex = 55
        '
        'txtcatname
        '
        Me.txtcatname.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtcatname.Location = New System.Drawing.Point(370, 24)
        Me.txtcatname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcatname.Name = "txtcatname"
        Me.txtcatname.Size = New System.Drawing.Size(200, 32)
        Me.txtcatname.TabIndex = 54
        '
        'txtcatId
        '
        Me.txtcatId.Enabled = False
        Me.txtcatId.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtcatId.Location = New System.Drawing.Point(58, 23)
        Me.txtcatId.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcatId.Name = "txtcatId"
        Me.txtcatId.Size = New System.Drawing.Size(200, 32)
        Me.txtcatId.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(604, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 26)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Brand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(295, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 26)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(11, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 26)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = " ID"
        '
        'Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 557)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Topproduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Category"
        Me.Text = "Category"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Topproduct.ResumeLayout(False)
        Me.Topproduct.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Topproduct As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtcatbrand As TextBox
    Friend WithEvents txtcatname As TextBox
    Friend WithEvents txtcatId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewCategory As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
