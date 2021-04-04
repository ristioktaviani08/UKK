<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPengguna
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lbcari = New System.Windows.Forms.Label()
        Me.btncari = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtsandi = New System.Windows.Forms.TextBox()
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(42, 380)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(216, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(38, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 194
        Me.Label4.Text = "ID Petugas"
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
        Me.Label3.Location = New System.Drawing.Point(38, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 20)
        Me.Label3.TabIndex = 206
        Me.Label3.Text = "Nama Pengguna"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(38, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 207
        Me.Label5.Text = "Kata Sandi"
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(225, 83)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(160, 28)
        Me.txtid.TabIndex = 208
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(225, 117)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(315, 28)
        Me.txtnama.TabIndex = 209
        '
        'txtsandi
        '
        Me.txtsandi.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsandi.Location = New System.Drawing.Point(225, 151)
        Me.txtsandi.Name = "txtsandi"
        Me.txtsandi.Size = New System.Drawing.Size(315, 28)
        Me.txtsandi.TabIndex = 210
        '
        'FrmPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1175, 712)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtsandi)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.txtid)
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
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.lbcari)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPengguna"
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbcari As System.Windows.Forms.Label
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txtsandi As System.Windows.Forms.TextBox
End Class
