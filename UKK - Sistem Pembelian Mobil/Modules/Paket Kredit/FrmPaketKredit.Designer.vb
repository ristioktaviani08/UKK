<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPaketKredit
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lbrecord = New System.Windows.Forms.Label()
        Me.btnprevious = New System.Windows.Forms.Button()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lbcari = New System.Windows.Forms.Label()
        Me.btncari = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtkdpaketkredit = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtuangmuka = New System.Windows.Forms.TextBox()
        Me.txtpaketjumlahcicilan = New System.Windows.Forms.TextBox()
        Me.txtbunga = New System.Windows.Forms.TextBox()
        Me.txtnilaicicilan = New System.Windows.Forms.TextBox()
        Me.txttampilharga = New System.Windows.Forms.TextBox()
        Me.txttampiluangmuka = New System.Windows.Forms.TextBox()
        Me.txttampilcicilan = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(56, 468)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1449, 348)
        Me.DataGridView1.TabIndex = 205
        '
        'lbrecord
        '
        Me.lbrecord.AutoSize = True
        Me.lbrecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbrecord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbrecord.Location = New System.Drawing.Point(499, 833)
        Me.lbrecord.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbrecord.Name = "lbrecord"
        Me.lbrecord.Size = New System.Drawing.Size(72, 24)
        Me.lbrecord.TabIndex = 204
        Me.lbrecord.Text = "Record"
        '
        'btnprevious
        '
        Me.btnprevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnprevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprevious.ForeColor = System.Drawing.Color.White
        Me.btnprevious.Location = New System.Drawing.Point(187, 823)
        Me.btnprevious.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(123, 46)
        Me.btnprevious.TabIndex = 203
        Me.btnprevious.Text = "<"
        Me.btnprevious.UseVisualStyleBackColor = False
        '
        'btnfirst
        '
        Me.btnfirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnfirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfirst.ForeColor = System.Drawing.Color.White
        Me.btnfirst.Location = New System.Drawing.Point(56, 823)
        Me.btnfirst.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(123, 46)
        Me.btnfirst.TabIndex = 202
        Me.btnfirst.Text = "<<"
        Me.btnfirst.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.Color.White
        Me.btnnext.Location = New System.Drawing.Point(1252, 823)
        Me.btnnext.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(123, 46)
        Me.btnnext.TabIndex = 201
        Me.btnnext.Text = ">"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnlast
        '
        Me.btnlast.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnlast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlast.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlast.ForeColor = System.Drawing.Color.White
        Me.btnlast.Location = New System.Drawing.Point(1383, 823)
        Me.btnlast.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(123, 46)
        Me.btnlast.TabIndex = 200
        Me.btnlast.Text = ">>"
        Me.btnlast.UseVisualStyleBackColor = False
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.ForeColor = System.Drawing.Color.White
        Me.btnbatal.Location = New System.Drawing.Point(1383, 415)
        Me.btnbatal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(123, 46)
        Me.btnbatal.TabIndex = 199
        Me.btnbatal.Text = "&Batal"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.ForeColor = System.Drawing.Color.White
        Me.btnhapus.Location = New System.Drawing.Point(1252, 415)
        Me.btnhapus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(123, 46)
        Me.btnhapus.TabIndex = 198
        Me.btnhapus.Text = "&Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnubah.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnubah.ForeColor = System.Drawing.Color.White
        Me.btnubah.Location = New System.Drawing.Point(1121, 415)
        Me.btnubah.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(123, 46)
        Me.btnubah.TabIndex = 197
        Me.btnubah.Text = "&Ubah"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.ForeColor = System.Drawing.Color.White
        Me.btnsimpan.Location = New System.Drawing.Point(991, 415)
        Me.btnsimpan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(123, 46)
        Me.btnsimpan.TabIndex = 196
        Me.btnsimpan.Text = "&Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.ForeColor = System.Drawing.Color.White
        Me.btntambah.Location = New System.Drawing.Point(860, 415)
        Me.btntambah.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(123, 46)
        Me.btntambah.TabIndex = 195
        Me.btntambah.Text = "&Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(51, 106)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 24)
        Me.Label4.TabIndex = 194
        Me.Label4.Text = "Kode Paket Kredit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(1441, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 12)
        Me.Label2.TabIndex = 193
        Me.Label2.Text = "*Tampilkan Jumlah Data"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(1395, 16)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(160, 29)
        Me.NumericUpDown1.TabIndex = 192
        '
        'lbcari
        '
        Me.lbcari.AutoSize = True
        Me.lbcari.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcari.ForeColor = System.Drawing.Color.Gray
        Me.lbcari.Location = New System.Drawing.Point(103, 10)
        Me.lbcari.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbcari.Name = "lbcari"
        Me.lbcari.Size = New System.Drawing.Size(138, 36)
        Me.lbcari.TabIndex = 191
        Me.lbcari.Text = "Cari Data"
        '
        'btncari
        '
        Me.btncari.FlatAppearance.BorderSize = 0
        Me.btncari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncari.Font = New System.Drawing.Font("FontAwesome", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncari.ForeColor = System.Drawing.Color.Gray
        Me.btncari.Location = New System.Drawing.Point(-5, 7)
        Me.btncari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(101, 52)
        Me.btncari.TabIndex = 190
        Me.btncari.Text = ""
        Me.btncari.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.BackColor = System.Drawing.SystemColors.Window
        Me.txtcari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcari.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.ForeColor = System.Drawing.Color.Gray
        Me.txtcari.Location = New System.Drawing.Point(99, 10)
        Me.txtcari.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcari.Multiline = True
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(1304, 53)
        Me.txtcari.TabIndex = 189
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-4, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1833, 29)
        Me.Label1.TabIndex = 188
        Me.Label1.Text = "_________________________________________________________________________________" & _
    "_________________________________________________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(51, 148)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 24)
        Me.Label3.TabIndex = 206
        Me.Label3.Text = "Harga Paket Kredit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(51, 190)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 24)
        Me.Label5.TabIndex = 207
        Me.Label5.Text = "Uang Muka Kredit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(51, 231)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 24)
        Me.Label6.TabIndex = 208
        Me.Label6.Text = "Paket Jumlah Cicilan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(51, 273)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 24)
        Me.Label7.TabIndex = 209
        Me.Label7.Text = "Bunga(%)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(51, 315)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 24)
        Me.Label8.TabIndex = 210
        Me.Label8.Text = "Nilai Cicilan"
        '
        'txtkdpaketkredit
        '
        Me.txtkdpaketkredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkdpaketkredit.Location = New System.Drawing.Point(300, 102)
        Me.txtkdpaketkredit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtkdpaketkredit.Name = "txtkdpaketkredit"
        Me.txtkdpaketkredit.Size = New System.Drawing.Size(212, 29)
        Me.txtkdpaketkredit.TabIndex = 211
        '
        'txtharga
        '
        Me.txtharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtharga.Location = New System.Drawing.Point(300, 144)
        Me.txtharga.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(273, 29)
        Me.txtharga.TabIndex = 212
        '
        'txtuangmuka
        '
        Me.txtuangmuka.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuangmuka.Location = New System.Drawing.Point(300, 186)
        Me.txtuangmuka.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtuangmuka.Name = "txtuangmuka"
        Me.txtuangmuka.Size = New System.Drawing.Size(273, 29)
        Me.txtuangmuka.TabIndex = 213
        '
        'txtpaketjumlahcicilan
        '
        Me.txtpaketjumlahcicilan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaketjumlahcicilan.Location = New System.Drawing.Point(300, 228)
        Me.txtpaketjumlahcicilan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtpaketjumlahcicilan.Name = "txtpaketjumlahcicilan"
        Me.txtpaketjumlahcicilan.Size = New System.Drawing.Size(132, 29)
        Me.txtpaketjumlahcicilan.TabIndex = 214
        '
        'txtbunga
        '
        Me.txtbunga.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbunga.Location = New System.Drawing.Point(300, 270)
        Me.txtbunga.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbunga.Name = "txtbunga"
        Me.txtbunga.Size = New System.Drawing.Size(132, 29)
        Me.txtbunga.TabIndex = 215
        '
        'txtnilaicicilan
        '
        Me.txtnilaicicilan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnilaicicilan.Location = New System.Drawing.Point(300, 353)
        Me.txtnilaicicilan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnilaicicilan.Name = "txtnilaicicilan"
        Me.txtnilaicicilan.Size = New System.Drawing.Size(273, 29)
        Me.txtnilaicicilan.TabIndex = 216
        '
        'txttampilharga
        '
        Me.txttampilharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttampilharga.Location = New System.Drawing.Point(583, 144)
        Me.txttampilharga.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttampilharga.Name = "txttampilharga"
        Me.txttampilharga.Size = New System.Drawing.Size(273, 29)
        Me.txttampilharga.TabIndex = 217
        '
        'txttampiluangmuka
        '
        Me.txttampiluangmuka.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttampiluangmuka.Location = New System.Drawing.Point(583, 186)
        Me.txttampiluangmuka.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttampiluangmuka.Name = "txttampiluangmuka"
        Me.txttampiluangmuka.Size = New System.Drawing.Size(273, 29)
        Me.txttampiluangmuka.TabIndex = 218
        '
        'txttampilcicilan
        '
        Me.txttampilcicilan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttampilcicilan.Location = New System.Drawing.Point(300, 311)
        Me.txttampilcicilan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttampilcicilan.Name = "txttampilcicilan"
        Me.txttampilcicilan.Size = New System.Drawing.Size(273, 29)
        Me.txttampilcicilan.TabIndex = 219
        '
        'FrmPaketKredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1567, 876)
        Me.ControlBox = False
        Me.Controls.Add(Me.txttampilcicilan)
        Me.Controls.Add(Me.txttampiluangmuka)
        Me.Controls.Add(Me.txttampilharga)
        Me.Controls.Add(Me.txtnilaicicilan)
        Me.Controls.Add(Me.txtbunga)
        Me.Controls.Add(Me.txtpaketjumlahcicilan)
        Me.Controls.Add(Me.txtuangmuka)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtkdpaketkredit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbrecord)
        Me.Controls.Add(Me.btnprevious)
        Me.Controls.Add(Me.btnfirst)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnlast)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.lbcari)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmPaketKredit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lbrecord As System.Windows.Forms.Label
    Friend WithEvents btnprevious As System.Windows.Forms.Button
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbcari As System.Windows.Forms.Label
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtkdpaketkredit As System.Windows.Forms.TextBox
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents txtuangmuka As System.Windows.Forms.TextBox
    Friend WithEvents txtpaketjumlahcicilan As System.Windows.Forms.TextBox
    Friend WithEvents txtbunga As System.Windows.Forms.TextBox
    Friend WithEvents txtnilaicicilan As System.Windows.Forms.TextBox
    Friend WithEvents txttampilharga As System.Windows.Forms.TextBox
    Friend WithEvents txttampiluangmuka As System.Windows.Forms.TextBox
    Friend WithEvents txttampilcicilan As System.Windows.Forms.TextBox
End Class
