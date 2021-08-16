<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtsuppier = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProductId = New System.Windows.Forms.TextBox()
        Me.txtshipping = New System.Windows.Forms.TextBox()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbemployee = New System.Windows.Forms.TextBox()
        Me.txtto = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.txtpur = New System.Windows.Forms.TextBox()
        Me.txtpurchase = New System.Windows.Forms.Label()
        Me.Topproduct.SuspendLayout()
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
        Me.Topproduct.Size = New System.Drawing.Size(1358, 57)
        Me.Topproduct.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(481, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(449, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purchase and Purchase Details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1231, 131)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 37)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1119, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 37)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtsuppier
        '
        Me.txtsuppier.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtsuppier.Location = New System.Drawing.Point(154, 131)
        Me.txtsuppier.Name = "txtsuppier"
        Me.txtsuppier.Size = New System.Drawing.Size(168, 32)
        Me.txtsuppier.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(59, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 26)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "subTotal"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(28, 189)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1308, 441)
        Me.DataGridView1.TabIndex = 25
        '
        'Column1
        '
        Me.Column1.HeaderText = "No"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.HeaderText = "purchaseId"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 70
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "productId"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Qty"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 70
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Price"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 55
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Total"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 55
        '
        'Column7
        '
        Me.Column7.HeaderText = "supplier"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Shipping"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 250
        '
        'Column9
        '
        Me.Column9.HeaderText = "Employee"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Edit"
        Me.Column10.Image = Global.Inventory_Mangement_Systems.My.Resources.Resources.pencil_drawing_20px
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column10.Width = 70
        '
        'Column11
        '
        Me.Column11.HeaderText = "Delete"
        Me.Column11.Image = Global.Inventory_Mangement_Systems.My.Resources.Resources.trash_20_red_px
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column11.Width = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(339, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 26)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "productId"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(659, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 26)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(328, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 26)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "discount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(854, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 26)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Employee"
        '
        'txtProductId
        '
        Me.txtProductId.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtProductId.Location = New System.Drawing.Point(450, 76)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.Size = New System.Drawing.Size(169, 32)
        Me.txtProductId.TabIndex = 31
        '
        'txtshipping
        '
        Me.txtshipping.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtshipping.Location = New System.Drawing.Point(421, 131)
        Me.txtshipping.Name = "txtshipping"
        Me.txtshipping.Size = New System.Drawing.Size(169, 32)
        Me.txtshipping.TabIndex = 32
        '
        'txtqty
        '
        Me.txtqty.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtqty.Location = New System.Drawing.Point(761, 76)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(169, 32)
        Me.txtqty.TabIndex = 33
        '
        'txtprice
        '
        Me.txtprice.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtprice.Location = New System.Drawing.Point(1027, 79)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(169, 32)
        Me.txtprice.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(952, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 26)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "price"
        '
        'cbemployee
        '
        Me.cbemployee.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold)
        Me.cbemployee.Location = New System.Drawing.Point(689, 131)
        Me.cbemployee.Name = "cbemployee"
        Me.cbemployee.Size = New System.Drawing.Size(155, 32)
        Me.cbemployee.TabIndex = 36
        '
        'txtto
        '
        Me.txtto.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtto.Location = New System.Drawing.Point(957, 134)
        Me.txtto.Name = "txtto"
        Me.txtto.Size = New System.Drawing.Size(133, 32)
        Me.txtto.TabIndex = 40
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(596, 134)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(87, 26)
        Me.txtTotal.TabIndex = 39
        Me.txtTotal.Text = "Payment"
        '
        'txtpur
        '
        Me.txtpur.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold)
        Me.txtpur.Location = New System.Drawing.Point(155, 76)
        Me.txtpur.Name = "txtpur"
        Me.txtpur.Size = New System.Drawing.Size(169, 32)
        Me.txtpur.TabIndex = 38
        '
        'txtpurchase
        '
        Me.txtpurchase.AutoSize = True
        Me.txtpurchase.Font = New System.Drawing.Font("Arial Narrow", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpurchase.ForeColor = System.Drawing.Color.Black
        Me.txtpurchase.Location = New System.Drawing.Point(32, 79)
        Me.txtpurchase.Name = "txtpurchase"
        Me.txtpurchase.Size = New System.Drawing.Size(109, 26)
        Me.txtpurchase.TabIndex = 37
        Me.txtpurchase.Text = "customerId"
        '
        'Purchase
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1358, 685)
        Me.Controls.Add(Me.txtto)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtpur)
        Me.Controls.Add(Me.txtpurchase)
        Me.Controls.Add(Me.cbemployee)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.txtshipping)
        Me.Controls.Add(Me.txtProductId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtsuppier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Topproduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Purchase"
        Me.Text = "Purchase"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Topproduct.ResumeLayout(False)
        Me.Topproduct.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Topproduct As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtsuppier As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtProductId As TextBox
    Friend WithEvents txtshipping As TextBox
    Friend WithEvents txtqty As TextBox
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbemployee As TextBox
    Friend WithEvents txtto As TextBox
    Friend WithEvents txtTotal As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewImageColumn
    Friend WithEvents Column11 As DataGridViewImageColumn
    Friend WithEvents txtpur As TextBox
    Friend WithEvents txtpurchase As Label
End Class
