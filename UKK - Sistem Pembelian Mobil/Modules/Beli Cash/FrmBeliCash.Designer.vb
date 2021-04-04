<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBeliCash
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.txtkdbelicash = New System.Windows.Forms.TextBox()
        Me.txtktp = New System.Windows.Forms.TextBox()
        Me.txtkdmobil = New System.Windows.Forms.TextBox()
        Me.tgl_cash = New System.Windows.Forms.DateTimePicker()
        Me.txtjumlahbayar = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtmerk = New System.Windows.Forms.TextBox()
        Me.txttipe = New System.Windows.Forms.TextBox()
        Me.txttampilbayar = New System.Windows.Forms.TextBox()
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(42, 380)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1087, 283)
        Me.DataGridView1.TabIndex = 205
        '
        'lbrecord
        '
        Me.lbrecord.AutoSize = True
        Me.lbrecord.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbrecord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbrecord.Location = New System.Drawing.Point(374, 677)
        Me.lbrecord.Name = "lbrecord"
        Me.lbrecord.Size = New System.Drawing.Size(57, 20)
        Me.lbrecord.TabIndex = 204
        Me.lbrecord.Text = "Record"
        '
        'btnprevious
        '
        Me.btnprevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnprevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprevious.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprevious.ForeColor = System.Drawing.Color.White
        Me.btnprevious.Location = New System.Drawing.Point(140, 669)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(92, 37)
        Me.btnprevious.TabIndex = 203
        Me.btnprevious.Text = "<"
        Me.btnprevious.UseVisualStyleBackColor = False
        '
        'btnfirst
        '
        Me.btnfirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnfirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfirst.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfirst.ForeColor = System.Drawing.Color.White
        Me.btnfirst.Location = New System.Drawing.Point(42, 669)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(92, 37)
        Me.btnfirst.TabIndex = 202
        Me.btnfirst.Text = "<<"
        Me.btnfirst.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnext.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.Color.White
        Me.btnnext.Location = New System.Drawing.Point(939, 669)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(92, 37)
        Me.btnnext.TabIndex = 201
        Me.btnnext.Text = ">"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnlast
        '
        Me.btnlast.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnlast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlast.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlast.ForeColor = System.Drawing.Color.White
        Me.btnlast.Location = New System.Drawing.Point(1037, 669)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(92, 37)
        Me.btnlast.TabIndex = 200
        Me.btnlast.Text = ">>"
        Me.btnlast.UseVisualStyleBackColor = False
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbatal.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.ForeColor = System.Drawing.Color.White
        Me.btnbatal.Location = New System.Drawing.Point(1037, 337)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(92, 37)
        Me.btnbatal.TabIndex = 199
        Me.btnbatal.Text = "&Batal"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.ForeColor = System.Drawing.Color.White
        Me.btnhapus.Location = New System.Drawing.Point(939, 337)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(92, 37)
        Me.btnhapus.TabIndex = 198
        Me.btnhapus.Text = "&Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnubah.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnubah.ForeColor = System.Drawing.Color.White
        Me.btnubah.Location = New System.Drawing.Point(841, 337)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(92, 37)
        Me.btnubah.TabIndex = 197
        Me.btnubah.Text = "&Ubah"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsimpan.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.ForeColor = System.Drawing.Color.White
        Me.btnsimpan.Location = New System.Drawing.Point(743, 337)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(92, 37)
        Me.btnsimpan.TabIndex = 196
        Me.btnsimpan.Text = "&Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambah.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.ForeColor = System.Drawing.Color.White
        Me.btntambah.Location = New System.Drawing.Point(645, 337)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(92, 37)
        Me.btntambah.TabIndex = 195
        Me.btntambah.Text = "&Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(38, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 20)
        Me.Label4.TabIndex = 194
        Me.Label4.Text = "Kode Beli Cash"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 5.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(1081, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 9)
        Me.Label2.TabIndex = 193
        Me.Label2.Text = "*Tampilkan Jumlah Data"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(1046, 13)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 28)
        Me.NumericUpDown1.TabIndex = 192
        '
        'lbcari
        '
        Me.lbcari.AutoSize = True
        Me.lbcari.Font = New System.Drawing.Font("Open Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcari.ForeColor = System.Drawing.Color.Gray
        Me.lbcari.Location = New System.Drawing.Point(77, 8)
        Me.lbcari.Name = "lbcari"
        Me.lbcari.Size = New System.Drawing.Size(116, 33)
        Me.lbcari.TabIndex = 191
        Me.lbcari.Text = "Cari Data"
        '
        'btncari
        '
        Me.btncari.FlatAppearance.BorderSize = 0
        Me.btncari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncari.Font = New System.Drawing.Font("FontAwesome", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncari.ForeColor = System.Drawing.Color.Gray
        Me.btncari.Location = New System.Drawing.Point(-4, 6)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(76, 42)
        Me.btncari.TabIndex = 190
        Me.btncari.Text = ""
        Me.btncari.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.BackColor = System.Drawing.SystemColors.Window
        Me.txtcari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcari.Font = New System.Drawing.Font("Open Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.ForeColor = System.Drawing.Color.Gray
        Me.txtcari.Location = New System.Drawing.Point(74, 8)
        Me.txtcari.Multiline = True
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(978, 43)
        Me.txtcari.TabIndex = 189
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-3, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1182, 27)
        Me.Label1.TabIndex = 188
        Me.Label1.Text = "_________________________________________________________________________________" & _
    "_________________________________________________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(38, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 20)
        Me.Label3.TabIndex = 206
        Me.Label3.Text = "No. KTP Pembeli"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(38, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 207
        Me.Label5.Text = "Kode Mobil"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(38, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 20)
        Me.Label6.TabIndex = 208
        Me.Label6.Text = "Tanggal Beli Cash"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(38, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 20)
        Me.Label7.TabIndex = 209
        Me.Label7.Text = "Jumlah Bayar Beli Cash"
        '
        'txtkdbelicash
        '
        Me.txtkdbelicash.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkdbelicash.Location = New System.Drawing.Point(225, 83)
        Me.txtkdbelicash.Name = "txtkdbelicash"
        Me.txtkdbelicash.Size = New System.Drawing.Size(160, 28)
        Me.txtkdbelicash.TabIndex = 210
        '
        'txtktp
        '
        Me.txtktp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtktp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtktp.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtktp.Location = New System.Drawing.Point(225, 117)
        Me.txtktp.Name = "txtktp"
        Me.txtktp.Size = New System.Drawing.Size(160, 28)
        Me.txtktp.TabIndex = 211
        '
        'txtkdmobil
        '
        Me.txtkdmobil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtkdmobil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtkdmobil.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkdmobil.Location = New System.Drawing.Point(225, 151)
        Me.txtkdmobil.Name = "txtkdmobil"
        Me.txtkdmobil.Size = New System.Drawing.Size(160, 28)
        Me.txtkdmobil.TabIndex = 212
        '
        'tgl_cash
        '
        Me.tgl_cash.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl_cash.Location = New System.Drawing.Point(225, 185)
        Me.tgl_cash.Name = "tgl_cash"
        Me.tgl_cash.Size = New System.Drawing.Size(268, 28)
        Me.tgl_cash.TabIndex = 213
        '
        'txtjumlahbayar
        '
        Me.txtjumlahbayar.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjumlahbayar.Location = New System.Drawing.Point(225, 253)
        Me.txtjumlahbayar.Name = "txtjumlahbayar"
        Me.txtjumlahbayar.Size = New System.Drawing.Size(160, 28)
        Me.txtjumlahbayar.TabIndex = 214
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(391, 118)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(198, 28)
        Me.txtnama.TabIndex = 215
        '
        'txtmerk
        '
        Me.txtmerk.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmerk.Location = New System.Drawing.Point(391, 150)
        Me.txtmerk.Name = "txtmerk"
        Me.txtmerk.Size = New System.Drawing.Size(198, 28)
        Me.txtmerk.TabIndex = 216
        '
        'txttipe
        '
        Me.txttipe.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttipe.Location = New System.Drawing.Point(595, 151)
        Me.txttipe.Name = "txttipe"
        Me.txttipe.Size = New System.Drawing.Size(207, 28)
        Me.txttipe.TabIndex = 217
        '
        'txttampilbayar
        '
        Me.txttampilbayar.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttampilbayar.Location = New System.Drawing.Point(225, 219)
        Me.txttampilbayar.Name = "txttampilbayar"
        Me.txttampilbayar.Size = New System.Drawing.Size(198, 28)
        Me.txttampilbayar.TabIndex = 218
        '
        'FrmBeliCash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1175, 712)
        Me.Controls.Add(Me.txttampilbayar)
        Me.Controls.Add(Me.txttipe)
        Me.Controls.Add(Me.txtmerk)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtjumlahbayar)
        Me.Controls.Add(Me.tgl_cash)
        Me.Controls.Add(Me.txtkdmobil)
        Me.Controls.Add(Me.txtktp)
        Me.Controls.Add(Me.txtkdbelicash)
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
        Me.Name = "FrmBeliCash"
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
    Friend WithEvents txtkdbelicash As System.Windows.Forms.TextBox
    Friend WithEvents txtktp As System.Windows.Forms.TextBox
    Friend WithEvents txtkdmobil As System.Windows.Forms.TextBox
    Friend WithEvents tgl_cash As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtjumlahbayar As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtmerk As System.Windows.Forms.TextBox
    Friend WithEvents txttipe As System.Windows.Forms.TextBox
    Friend WithEvents txttampilbayar As System.Windows.Forms.TextBox
End Class
