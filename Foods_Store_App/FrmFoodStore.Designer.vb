<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFoodStore
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvDaftarProduct = New System.Windows.Forms.DataGridView()
        Me.Product_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSearch = New FontAwesome.Sharp.IconButton()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvTrolly = New System.Windows.Forms.DataGridView()
        Me.NamaProduk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityCek = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaCek = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtBayar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvDaftarProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvTrolly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(918, 20)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(918, 20)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Yellow
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(918, 20)
        Me.Panel3.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(918, 412)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvDaftarProduct)
        Me.GroupBox4.Controls.Add(Me.Panel4)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(452, 393)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Daftar Produk"
        '
        'dgvDaftarProduct
        '
        Me.dgvDaftarProduct.AllowUserToAddRows = False
        Me.dgvDaftarProduct.AllowUserToDeleteRows = False
        Me.dgvDaftarProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDaftarProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product_Name, Me.Harga})
        Me.dgvDaftarProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDaftarProduct.Location = New System.Drawing.Point(3, 50)
        Me.dgvDaftarProduct.Name = "dgvDaftarProduct"
        Me.dgvDaftarProduct.Size = New System.Drawing.Size(446, 340)
        Me.dgvDaftarProduct.TabIndex = 1
        '
        'Product_Name
        '
        Me.Product_Name.FillWeight = 150.0!
        Me.Product_Name.HeaderText = "Nama Produk"
        Me.Product_Name.Name = "Product_Name"
        Me.Product_Name.Width = 200
        '
        'Harga
        '
        Me.Harga.HeaderText = "Harga"
        Me.Harga.Name = "Harga"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSearch)
        Me.Panel4.Controls.Add(Me.txtSearch)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 16)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(0, 4, 4, 4)
        Me.Panel4.Size = New System.Drawing.Size(446, 34)
        Me.Panel4.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Searchengin
        Me.btnSearch.IconColor = System.Drawing.Color.Gray
        Me.btnSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSearch.IconSize = 27
        Me.btnSearch.Location = New System.Drawing.Point(172, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(32, 23)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtSearch.Location = New System.Drawing.Point(0, 4)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(205, 26)
        Me.txtSearch.TabIndex = 5
        Me.txtSearch.Text = "Search"
        '
        'GroupBox1
        '
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Location = New System.Drawing.Point(455, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(10, 393)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvTrolly)
        Me.GroupBox3.Controls.Add(Me.Panel6)
        Me.GroupBox3.Controls.Add(Me.Panel5)
        Me.GroupBox3.Controls.Add(Me.Panel7)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox3.Location = New System.Drawing.Point(465, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 393)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Keranjang"
        '
        'dgvTrolly
        '
        Me.dgvTrolly.AllowUserToAddRows = False
        Me.dgvTrolly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrolly.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamaProduk, Me.QuantityCek, Me.HargaCek, Me.Total})
        Me.dgvTrolly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTrolly.Location = New System.Drawing.Point(3, 50)
        Me.dgvTrolly.Name = "dgvTrolly"
        Me.dgvTrolly.Size = New System.Drawing.Size(444, 252)
        Me.dgvTrolly.TabIndex = 4
        '
        'NamaProduk
        '
        Me.NamaProduk.HeaderText = "Nama Produk"
        Me.NamaProduk.Name = "NamaProduk"
        '
        'QuantityCek
        '
        Me.QuantityCek.HeaderText = "Quantity"
        Me.QuantityCek.Name = "QuantityCek"
        '
        'HargaCek
        '
        Me.HargaCek.HeaderText = "Harga"
        Me.HargaCek.Name = "HargaCek"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lblTotal)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(3, 302)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(444, 26)
        Me.Panel6.TabIndex = 3
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Green
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(0, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(444, 26)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "TOTAL : Rp0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblBonus)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(3, 16)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(444, 34)
        Me.Panel5.TabIndex = 2
        '
        'lblBonus
        '
        Me.lblBonus.BackColor = System.Drawing.Color.Orange
        Me.lblBonus.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblBonus.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBonus.ForeColor = System.Drawing.Color.White
        Me.lblBonus.Location = New System.Drawing.Point(0, 0)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(438, 34)
        Me.lblBonus.TabIndex = 3
        Me.lblBonus.Text = "BONUS"
        Me.lblBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnRefresh)
        Me.Panel7.Controls.Add(Me.IconButton1)
        Me.Panel7.Controls.Add(Me.btnClose)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(3, 328)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(444, 62)
        Me.Panel7.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRefresh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Recycle
        Me.btnRefresh.IconColor = System.Drawing.Color.White
        Me.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRefresh.IconSize = 27
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnRefresh.Location = New System.Drawing.Point(173, 28)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(101, 34)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.IconButton1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.Control
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Database
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 27
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.IconButton1.Location = New System.Drawing.Point(274, 28)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(85, 34)
        Me.IconButton1.TabIndex = 3
        Me.IconButton1.Text = "Save"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.Control
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.Backspace
        Me.btnClose.IconColor = System.Drawing.Color.White
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.IconSize = 30
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnClose.Location = New System.Drawing.Point(359, 28)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 34)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.txtBayar)
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(444, 28)
        Me.Panel8.TabIndex = 0
        '
        'txtBayar
        '
        Me.txtBayar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtBayar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBayar.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBayar.ForeColor = System.Drawing.Color.White
        Me.txtBayar.Location = New System.Drawing.Point(87, 0)
        Me.txtBayar.Multiline = True
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(357, 28)
        Me.txtBayar.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "BAYAR :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmFoodStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 472)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmFoodStore"
        Me.Text = "Foods Store"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvDaftarProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvTrolly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvDaftarProduct As DataGridView
    Friend WithEvents Product_Name As DataGridViewTextBoxColumn
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnSearch As FontAwesome.Sharp.IconButton
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvTrolly As DataGridView
    Friend WithEvents NamaProduk As DataGridViewTextBoxColumn
    Friend WithEvents QuantityCek As DataGridViewTextBoxColumn
    Friend WithEvents HargaCek As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblBonus As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents Label2 As Label
End Class
