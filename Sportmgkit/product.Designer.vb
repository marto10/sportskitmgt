<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class product
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.prodcatcb = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.quantitylbl = New System.Windows.Forms.Label()
        Me.Prodqtytxt = New System.Windows.Forms.TextBox()
        Me.Prodpricetxt = New System.Windows.Forms.TextBox()
        Me.Prodnametxt = New System.Windows.Forms.TextBox()
        Me.Prodidtxt = New System.Windows.Forms.TextBox()
        Me.ProductDGV = New System.Windows.Forms.DataGridView()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.Deletebtn = New System.Windows.Forms.Button()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CategoryDataSet = New Sportmgkit.CategoryDataSet()
        Me.ProductTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Product_TableTableAdapter = New Sportmgkit.CategoryDataSetTableAdapters.Product_TableTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout
        CType(Me.ProductDGV,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CategoryDataSet,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ProductTableBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.prodcatcb)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.clearbtn)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.quantitylbl)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Prodqtytxt)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Prodpricetxt)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Prodnametxt)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Prodidtxt)
        Me.Panel1.Controls.Add(Me.ProductDGV)
        Me.Panel1.Controls.Add(Me.Searchbtn)
        Me.Panel1.Controls.Add(Me.Editbtn)
        Me.Panel1.Controls.Add(Me.Deletebtn)
        Me.Panel1.Controls.Add(Me.Addbtn)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1479, 895)
        Me.Panel1.TabIndex = 0
        '
        'prodcatcb
        '
        Me.prodcatcb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.prodcatcb.ForeColor = System.Drawing.Color.Purple
        Me.prodcatcb.FormattingEnabled = true
        Me.prodcatcb.Items.AddRange(New Object() {"Soccer", "Rugby", "Tennis", "BasketBall", "Cycling"})
        Me.prodcatcb.Location = New System.Drawing.Point(516, 243)
        Me.prodcatcb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.prodcatcb.Name = "prodcatcb"
        Me.prodcatcb.Size = New System.Drawing.Size(266, 41)
        Me.prodcatcb.TabIndex = 54
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Purple
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(562, 780)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 55)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = false
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Purple
        Me.Label7.Location = New System.Drawing.Point(592, 423)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 31)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Products List"
        '
        'clearbtn
        '
        Me.clearbtn.BackColor = System.Drawing.Color.Purple
        Me.clearbtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold)
        Me.clearbtn.Location = New System.Drawing.Point(579, 315)
        Me.clearbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(160, 55)
        Me.clearbtn.TabIndex = 49
        Me.clearbtn.Text = "CLEAR"
        Me.clearbtn.UseVisualStyleBackColor = false
        '
        'quantitylbl
        '
        Me.quantitylbl.AutoSize = true
        Me.quantitylbl.BackColor = System.Drawing.Color.White
        Me.quantitylbl.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.quantitylbl.ForeColor = System.Drawing.Color.Purple
        Me.quantitylbl.Location = New System.Drawing.Point(832, 243)
        Me.quantitylbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.quantitylbl.Name = "quantitylbl"
        Me.quantitylbl.Size = New System.Drawing.Size(170, 31)
        Me.quantitylbl.TabIndex = 48
        Me.quantitylbl.Text = "QUANTITY"
        '
        'Prodqtytxt
        '
        Me.Prodqtytxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Prodqtytxt.ForeColor = System.Drawing.Color.DarkViolet
        Me.Prodqtytxt.Location = New System.Drawing.Point(1014, 243)
        Me.Prodqtytxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Prodqtytxt.Name = "Prodqtytxt"
        Me.Prodqtytxt.Size = New System.Drawing.Size(127, 35)
        Me.Prodqtytxt.TabIndex = 47
        '
        'Prodpricetxt
        '
        Me.Prodpricetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Prodpricetxt.ForeColor = System.Drawing.Color.DarkViolet
        Me.Prodpricetxt.Location = New System.Drawing.Point(1014, 157)
        Me.Prodpricetxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Prodpricetxt.Name = "Prodpricetxt"
        Me.Prodpricetxt.Size = New System.Drawing.Size(127, 35)
        Me.Prodpricetxt.TabIndex = 46
        '
        'Prodnametxt
        '
        Me.Prodnametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Prodnametxt.ForeColor = System.Drawing.Color.DarkViolet
        Me.Prodnametxt.Location = New System.Drawing.Point(465, 166)
        Me.Prodnametxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Prodnametxt.Name = "Prodnametxt"
        Me.Prodnametxt.Size = New System.Drawing.Size(322, 35)
        Me.Prodnametxt.TabIndex = 45
        '
        'Prodidtxt
        '
        Me.Prodidtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Prodidtxt.ForeColor = System.Drawing.Color.DarkViolet
        Me.Prodidtxt.Location = New System.Drawing.Point(168, 160)
        Me.Prodidtxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Prodidtxt.Name = "Prodidtxt"
        Me.Prodidtxt.Size = New System.Drawing.Size(127, 35)
        Me.Prodidtxt.TabIndex = 44
        '
        'ProductDGV
        '
        Me.ProductDGV.BackgroundColor = System.Drawing.Color.White
        Me.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDGV.GridColor = System.Drawing.Color.Purple
        Me.ProductDGV.Location = New System.Drawing.Point(114, 460)
        Me.ProductDGV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProductDGV.Name = "ProductDGV"
        Me.ProductDGV.Size = New System.Drawing.Size(1089, 311)
        Me.ProductDGV.TabIndex = 42
        '
        'Searchbtn
        '
        Me.Searchbtn.BackColor = System.Drawing.Color.Purple
        Me.Searchbtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Searchbtn.Location = New System.Drawing.Point(982, 315)
        Me.Searchbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(160, 55)
        Me.Searchbtn.TabIndex = 41
        Me.Searchbtn.Text = "SEARCH"
        Me.Searchbtn.UseVisualStyleBackColor = false
        '
        'Editbtn
        '
        Me.Editbtn.BackColor = System.Drawing.Color.Purple
        Me.Editbtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Editbtn.Location = New System.Drawing.Point(786, 315)
        Me.Editbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(160, 55)
        Me.Editbtn.TabIndex = 40
        Me.Editbtn.Text = "UPDATE"
        Me.Editbtn.UseVisualStyleBackColor = false
        '
        'Deletebtn
        '
        Me.Deletebtn.BackColor = System.Drawing.Color.Purple
        Me.Deletebtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Deletebtn.Location = New System.Drawing.Point(358, 315)
        Me.Deletebtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(177, 55)
        Me.Deletebtn.TabIndex = 39
        Me.Deletebtn.Text = "DELETE"
        Me.Deletebtn.UseVisualStyleBackColor = false
        '
        'Addbtn
        '
        Me.Addbtn.BackColor = System.Drawing.Color.Purple
        Me.Addbtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Addbtn.Location = New System.Drawing.Point(186, 315)
        Me.Addbtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(132, 55)
        Me.Addbtn.TabIndex = 38
        Me.Addbtn.Text = "ADD"
        Me.Addbtn.UseVisualStyleBackColor = false
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Purple
        Me.Label6.Location = New System.Drawing.Point(898, 160)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 31)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "PRICE"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Purple
        Me.Label4.Location = New System.Drawing.Point(330, 246)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 31)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "CATEGORY"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Purple
        Me.Label3.Location = New System.Drawing.Point(352, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 31)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Purple
        Me.Label2.Location = New System.Drawing.Point(108, 166)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 31)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Purple
        Me.Label5.Location = New System.Drawing.Point(460, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(426, 42)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "MANAGE PRODUCTS"
        '
        'CategoryDataSet
        '
        Me.CategoryDataSet.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductTableBindingSource
        '
        Me.ProductTableBindingSource.DataMember = "Product_Table"
        Me.ProductTableBindingSource.DataSource = Me.CategoryDataSet
        '
        'Product_TableTableAdapter
        '
        Me.Product_TableTableAdapter.ClearBeforeFill = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(108, 166)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 31)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Purple
        Me.Label8.Location = New System.Drawing.Point(352, 166)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 31)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "NAME"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Purple
        Me.Label9.Location = New System.Drawing.Point(898, 160)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 31)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "PRICE"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DarkViolet
        Me.TextBox1.Location = New System.Drawing.Point(168, 160)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 35)
        Me.TextBox1.TabIndex = 44
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.DarkViolet
        Me.TextBox2.Location = New System.Drawing.Point(465, 166)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(322, 35)
        Me.TextBox2.TabIndex = 45
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.DarkViolet
        Me.TextBox3.Location = New System.Drawing.Point(1014, 157)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(127, 35)
        Me.TextBox3.TabIndex = 46
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.DarkViolet
        Me.TextBox4.Location = New System.Drawing.Point(1014, 243)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(127, 35)
        Me.TextBox4.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Purple
        Me.Label10.Location = New System.Drawing.Point(832, 243)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(170, 31)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "QUANTITY"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Purple
        Me.ComboBox1.FormattingEnabled = true
        Me.ComboBox1.Items.AddRange(New Object() {"Soccer", "Rugby", "Tennis", "BasketBall", "Cycling"})
        Me.ComboBox1.Location = New System.Drawing.Point(516, 243)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(266, 41)
        Me.ComboBox1.TabIndex = 54
        '
        'product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9!, 20!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkMagenta
        Me.ClientSize = New System.Drawing.Size(1479, 895)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "product"
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.ProductDGV,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CategoryDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ProductTableBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Searchbtn As System.Windows.Forms.Button
    Friend WithEvents Editbtn As System.Windows.Forms.Button
    Friend WithEvents Deletebtn As System.Windows.Forms.Button
    Friend WithEvents Addbtn As System.Windows.Forms.Button
    Friend WithEvents ProductDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Prodpricetxt As System.Windows.Forms.TextBox
    Friend WithEvents Prodnametxt As System.Windows.Forms.TextBox
    Friend WithEvents Prodidtxt As System.Windows.Forms.TextBox
    Friend WithEvents quantitylbl As System.Windows.Forms.Label
    Friend WithEvents Prodqtytxt As System.Windows.Forms.TextBox
    Friend WithEvents clearbtn As System.Windows.Forms.Button
    Friend WithEvents CategoryDataSet As Sportmgkit.CategoryDataSet
    Friend WithEvents ProductTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Product_TableTableAdapter As Sportmgkit.CategoryDataSetTableAdapters.Product_TableTableAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents prodcatcb As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
