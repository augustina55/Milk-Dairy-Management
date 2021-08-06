<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homepage))
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.buttonStaff = New System.Windows.Forms.Button()
        Me.ButtonStock = New System.Windows.Forms.Button()
        Me.buttonSearch = New System.Windows.Forms.Button()
        Me.buttonTransaction = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.buttonPurchase = New System.Windows.Forms.Button()
        Me.buttonSales = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel3
        '
        Me.panel3.AutoScroll = True
        Me.panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(168, 0)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(991, 692)
        Me.panel3.TabIndex = 4
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.panel4)
        Me.panel1.Controls.Add(Me.ButtonClose)
        Me.panel1.Controls.Add(Me.buttonStaff)
        Me.panel1.Controls.Add(Me.ButtonStock)
        Me.panel1.Controls.Add(Me.buttonSearch)
        Me.panel1.Controls.Add(Me.buttonTransaction)
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Controls.Add(Me.buttonPurchase)
        Me.panel1.Controls.Add(Me.buttonSales)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(168, 692)
        Me.panel1.TabIndex = 3
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.Color.Gold
        Me.panel4.Location = New System.Drawing.Point(159, 98)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(6, 60)
        Me.panel4.TabIndex = 0
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Image = CType(resources.GetObject("ButtonClose.Image"), System.Drawing.Image)
        Me.ButtonClose.Location = New System.Drawing.Point(0, 502)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(164, 64)
        Me.ButtonClose.TabIndex = 10
        Me.ButtonClose.Text = "CLOSE"
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'buttonStaff
        '
        Me.buttonStaff.BackColor = System.Drawing.Color.DodgerBlue
        Me.buttonStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.buttonStaff.FlatAppearance.BorderSize = 0
        Me.buttonStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonStaff.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold)
        Me.buttonStaff.ForeColor = System.Drawing.Color.White
        Me.buttonStaff.Image = CType(resources.GetObject("buttonStaff.Image"), System.Drawing.Image)
        Me.buttonStaff.Location = New System.Drawing.Point(3, 228)
        Me.buttonStaff.Name = "buttonStaff"
        Me.buttonStaff.Size = New System.Drawing.Size(164, 64)
        Me.buttonStaff.TabIndex = 3
        Me.buttonStaff.Text = "STAFF"
        Me.buttonStaff.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.buttonStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.buttonStaff.UseVisualStyleBackColor = False
        '
        'ButtonStock
        '
        Me.ButtonStock.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonStock.FlatAppearance.BorderSize = 0
        Me.ButtonStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStock.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonStock.ForeColor = System.Drawing.Color.White
        Me.ButtonStock.Image = CType(resources.GetObject("ButtonStock.Image"), System.Drawing.Image)
        Me.ButtonStock.Location = New System.Drawing.Point(0, 298)
        Me.ButtonStock.Name = "ButtonStock"
        Me.ButtonStock.Size = New System.Drawing.Size(164, 58)
        Me.ButtonStock.TabIndex = 8
        Me.ButtonStock.Text = "STOCK"
        Me.ButtonStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonStock.UseVisualStyleBackColor = False
        '
        'buttonSearch
        '
        Me.buttonSearch.BackColor = System.Drawing.Color.DodgerBlue
        Me.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.buttonSearch.FlatAppearance.BorderSize = 0
        Me.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonSearch.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold)
        Me.buttonSearch.ForeColor = System.Drawing.Color.White
        Me.buttonSearch.Image = CType(resources.GetObject("buttonSearch.Image"), System.Drawing.Image)
        Me.buttonSearch.Location = New System.Drawing.Point(1, 432)
        Me.buttonSearch.Name = "buttonSearch"
        Me.buttonSearch.Size = New System.Drawing.Size(164, 64)
        Me.buttonSearch.TabIndex = 7
        Me.buttonSearch.Text = "SEARCH ACCOUNT"
        Me.buttonSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.buttonSearch.UseVisualStyleBackColor = False
        '
        'buttonTransaction
        '
        Me.buttonTransaction.BackColor = System.Drawing.Color.DodgerBlue
        Me.buttonTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.buttonTransaction.FlatAppearance.BorderSize = 0
        Me.buttonTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonTransaction.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold)
        Me.buttonTransaction.ForeColor = System.Drawing.Color.White
        Me.buttonTransaction.Image = CType(resources.GetObject("buttonTransaction.Image"), System.Drawing.Image)
        Me.buttonTransaction.Location = New System.Drawing.Point(0, 362)
        Me.buttonTransaction.Name = "buttonTransaction"
        Me.buttonTransaction.Size = New System.Drawing.Size(164, 64)
        Me.buttonTransaction.TabIndex = 5
        Me.buttonTransaction.Text = "TRANSACTION"
        Me.buttonTransaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.buttonTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.buttonTransaction.UseVisualStyleBackColor = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.pictureBox1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(166, 88)
        Me.panel2.TabIndex = 1
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(161, 80)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'buttonPurchase
        '
        Me.buttonPurchase.BackColor = System.Drawing.Color.DodgerBlue
        Me.buttonPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.buttonPurchase.FlatAppearance.BorderSize = 0
        Me.buttonPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonPurchase.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonPurchase.ForeColor = System.Drawing.Color.White
        Me.buttonPurchase.Image = CType(resources.GetObject("buttonPurchase.Image"), System.Drawing.Image)
        Me.buttonPurchase.Location = New System.Drawing.Point(0, 94)
        Me.buttonPurchase.Name = "buttonPurchase"
        Me.buttonPurchase.Size = New System.Drawing.Size(164, 64)
        Me.buttonPurchase.TabIndex = 2
        Me.buttonPurchase.Text = "PURCHASE"
        Me.buttonPurchase.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.buttonPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.buttonPurchase.UseVisualStyleBackColor = False
        '
        'buttonSales
        '
        Me.buttonSales.BackColor = System.Drawing.Color.DodgerBlue
        Me.buttonSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.buttonSales.FlatAppearance.BorderSize = 0
        Me.buttonSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonSales.Font = New System.Drawing.Font("Sitka Heading", 12.0!, System.Drawing.FontStyle.Bold)
        Me.buttonSales.ForeColor = System.Drawing.Color.White
        Me.buttonSales.Image = CType(resources.GetObject("buttonSales.Image"), System.Drawing.Image)
        Me.buttonSales.Location = New System.Drawing.Point(1, 164)
        Me.buttonSales.Name = "buttonSales"
        Me.buttonSales.Size = New System.Drawing.Size(164, 64)
        Me.buttonSales.TabIndex = 9
        Me.buttonSales.Text = "SALES"
        Me.buttonSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.buttonSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.buttonSales.UseVisualStyleBackColor = False
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 692)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "Homepage"
        Me.Text = "Homepage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel3 As Panel
    Private WithEvents panel1 As Panel
    Private WithEvents buttonStaff As Button
    Private WithEvents ButtonStock As Button
    Private WithEvents panel4 As Panel
    Private WithEvents buttonSearch As Button
    Private WithEvents buttonTransaction As Button
    Private WithEvents buttonPurchase As Button
    Private WithEvents panel2 As Panel
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents ButtonClose As Button
    Private WithEvents buttonSales As Button
End Class
