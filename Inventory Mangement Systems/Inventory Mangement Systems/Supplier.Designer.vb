﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Supplier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Topproduct = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtcountry = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtsAddress = New System.Windows.Forms.TextBox()
        Me.txtSubID = New System.Windows.Forms.TextBox()
        Me.txtsphone = New System.Windows.Forms.TextBox()
        Me.txtSubname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Topproduct.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Topproduct
        '
        Me.Topproduct.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Topproduct.Controls.Add(Me.Label1)
        Me.Topproduct.Dock = System.Windows.Forms.DockStyle.Top
        Me.Topproduct.Location = New System.Drawing.Point(0, 0)
        Me.Topproduct.Name = "Topproduct"
        Me.Topproduct.Size = New System.Drawing.Size(1436, 57)
        Me.Topproduct.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supplier"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtcountry)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtsAddress)
        Me.Panel1.Controls.Add(Me.txtSubID)
        Me.Panel1.Controls.Add(Me.txtsphone)
        Me.Panel1.Controls.Add(Me.txtSubname)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1436, 628)
        Me.Panel1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1152, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 40)
        Me.Button2.TabIndex = 62
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1030, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 40)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column10, Me.Column4, Me.Column5, Me.Column6, Me.Column8, Me.Column9})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1412, 478)
        Me.DataGridView1.TabIndex = 57
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtEmail.Location = New System.Drawing.Point(118, 70)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(184, 38)
        Me.txtEmail.TabIndex = 55
        '
        'txtcountry
        '
        Me.txtcountry.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtcountry.Location = New System.Drawing.Point(804, 73)
        Me.txtcountry.Name = "txtcountry"
        Me.txtcountry.Size = New System.Drawing.Size(184, 38)
        Me.txtcountry.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(672, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 33)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Country"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(18, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 33)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "E-mail"
        '
        'txtsAddress
        '
        Me.txtsAddress.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtsAddress.Location = New System.Drawing.Point(469, 73)
        Me.txtsAddress.Name = "txtsAddress"
        Me.txtsAddress.Size = New System.Drawing.Size(184, 38)
        Me.txtsAddress.TabIndex = 48
        '
        'txtSubID
        '
        Me.txtSubID.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtSubID.Location = New System.Drawing.Point(118, 16)
        Me.txtSubID.Name = "txtSubID"
        Me.txtSubID.Size = New System.Drawing.Size(184, 38)
        Me.txtSubID.TabIndex = 47
        '
        'txtsphone
        '
        Me.txtsphone.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtsphone.Location = New System.Drawing.Point(804, 16)
        Me.txtsphone.Name = "txtsphone"
        Me.txtsphone.Size = New System.Drawing.Size(184, 38)
        Me.txtsphone.TabIndex = 46
        '
        'txtSubname
        '
        Me.txtSubname.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtSubname.Location = New System.Drawing.Point(469, 16)
        Me.txtSubname.Name = "txtSubname"
        Me.txtSubname.Size = New System.Drawing.Size(184, 38)
        Me.txtSubname.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(335, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 33)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(672, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 33)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Phone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(335, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 33)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 33)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = " ID"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "No"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 55
        '
        'Column2
        '
        Me.Column2.HeaderText = "ID"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 50
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Name"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Phone"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 125
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Email"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Address"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Country"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 86
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "Edit"
        Me.Column8.Image = Global.Inventory_Mangement_Systems.My.Resources.Resources.pencil_drawing_20px
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column8.Width = 61
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "Delete"
        Me.Column9.Image = Global.Inventory_Mangement_Systems.My.Resources.Resources.trash_20_red_px
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column9.Width = 78
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1436, 685)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Topproduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Supplier"
        Me.Text = "Supplier"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Topproduct.ResumeLayout(False)
        Me.Topproduct.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Topproduct As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtcountry As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtsAddress As TextBox
    Friend WithEvents txtSubID As TextBox
    Friend WithEvents txtsphone As TextBox
    Friend WithEvents txtSubname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewImageColumn
    Friend WithEvents Column9 As DataGridViewImageColumn
End Class
