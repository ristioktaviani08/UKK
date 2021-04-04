Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class FrmMobil
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    'Varible Untuk Gambar
    Dim photo_array() As Byte
    Dim ms As New MemoryStream
    Dim i As Integer


    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM mobil"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        'Menampilkan Gambar Seperti Aslinya 
        For i As Integer = 0 To DataGridView1.Columns.Count - 1
            If TypeOf DataGridView1.Columns(i) Is DataGridViewImageColumn Then
                DirectCast(DataGridView1.Columns(i), 
                    DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
            End If
        Next

        DataGridView1.Columns(0).HeaderText = "Kode Mobil"
        DataGridView1.Columns(1).HeaderText = "Merk Mobil"
        DataGridView1.Columns(2).HeaderText = "Type Mobil"
        DataGridView1.Columns(3).HeaderText = "Warna Mobil"
        DataGridView1.Columns(4).HeaderText = "Harga Mobil"
        DataGridView1.Columns(5).HeaderText = "Gambar Mobil"

        DataGridView1.Columns(0).Width = 140
        DataGridView1.Columns(1).Width = 170
        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(3).Width = 170
        DataGridView1.Columns(4).Width = 205
        DataGridView1.Columns(5).Width = 200

    End Sub

    Sub bersih()
        txtkdmobil.Text = ""
        txtmerk.Text = ""
        cbtipe.Text = ""
        cbwarna.Text = ""
        txtharga.Text = ""
        txttampilharga.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) AS kode_mobil FROM mobil"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("kode_mobil").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtkdmobil.Text = "KMP-M-0" + Trim(Str(kodeauto))
            Case 2 : txtkdmobil.Text = "KMP-M-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub

    Private Sub FrmMobil_Click(sender As Object, e As EventArgs) Handles Me.Click
        lbcari.Visible = True
    End Sub

    Private Sub FrmMobil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=VICKY-PREDATOR\SQLEXPRESS;Initial Catalog=db_ukk_mobil;Integrated Security=True"
        tampildata()
        txtkdmobil.Enabled = False
        txttampilharga.Enabled = False
        paging()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        kodeotomatis()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtkdmobil.Text = DataGridView1.SelectedCells(0).Value
        txtmerk.Text = DataGridView1.SelectedCells(1).Value
        cbtipe.Text = DataGridView1.SelectedCells(2).Value
        cbwarna.Text = DataGridView1.SelectedCells(3).Value
        txtharga.Text = DataGridView1.SelectedCells(4).Value

        'menampilkan gambar ke picturebox
        Dim c As New IO.MemoryStream(CType(DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value, Byte()))
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Image = Image.FromStream(c)
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim baris As Integer
        Dim id As String

        baris = DataGridView1.CurrentCell.RowIndex
        id = DataGridView1(0, baris).Value.ToString

        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "DELETE FROM mobil WHERE kode_mobil = '" + id + "'"
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Data Mobil Berhasil Terhapus", MsgBoxStyle.Information)
        tampildata()
    End Sub

    'create function convertimage to byte
    Private Sub ConvertImage()
        If PictureBox1.Image IsNot Nothing Then
            ms = New MemoryStream
            PictureBox1.Image.Save(ms, ImageFormat.Jpeg)
            Dim photo_array(ms.Length - 1) As Byte
            ms.Position = 0
            ms.Read(photo_array, 0, photo_array.Length)
            cmd.Parameters.AddWithValue("@pic", photo_array)
        End If
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtkdmobil.Text = "" Then
            MessageBox.Show("Kode Mobil harus diisi")
        ElseIf txtmerk.Text = "" Then
            MessageBox.Show("Merk Mobil harus diisi")
        ElseIf txtkdmobil.Text <> "" And txtmerk.Text <> "" Then

            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO mobil VALUES ('" & txtkdmobil.Text & "','" & txtmerk.Text & "','" & cbtipe.Text & "','" & cbwarna.Text & "','" & txtharga.Text & "', @pic )"
            ConvertImage()
            i = cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Mobil Berhasil Tersimpan", MsgBoxStyle.Information)
            tampildata()
        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If txtkdmobil.Text = "" Then
            MessageBox.Show("Kode Mobil harus diisi")
        ElseIf txtmerk.Text = "" Then
            MessageBox.Show("Merk Mobil harus diisi")
        ElseIf txtkdmobil.Text <> "" And txtmerk.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "UPDATE mobil SET merk = '" & txtmerk.Text & "', tipe = '" & cbtipe.Text & "', warna = '" & cbwarna.Text & "', harga_mobil = '" & txtharga.Text & "', gambar = @pic WHERE kode_mobil = '" & txtkdmobil.Text & "'"
            ConvertImage()
            i = cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Mobil Berhasil Terubah", MsgBoxStyle.Information)
            tampildata()
        End If
    End Sub

    Private Sub btntambahgambar_Click(sender As Object, e As EventArgs) Handles btntambahgambar.Click
        Dim pc As String
        OpenFileDialog1.Filter = Nothing
        pc = OpenFileDialog1.FileName
        OpenFileDialog1.ShowDialog()
        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub txttampilharga_TextChanged(sender As Object, e As EventArgs) Handles txttampilharga.TextChanged
        Try
            txttampilharga.Text = "Rp " + FormatNumber(txttampilharga.Text, 2, , TriState.True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtcari_Click(sender As Object, e As EventArgs) Handles txtcari.Click
        lbcari.Visible = False
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM mobil WHERE kode_mobil LIKE  '%" & txtcari.Text & "%' OR merk LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub txtharga_TextChanged(sender As Object, e As EventArgs) Handles txtharga.TextChanged
        Try
            Dim a As Integer
            a = txtharga.Text
            txttampilharga.Text = "Rp " + FormatNumber(a, 2, , , TriState.True)
        Catch ex As Exception

        End Try
    End Sub

    'PAGING

    Sub paging()
        cn.Open()
        intRecPerPage = NumericUpDown1.Value
        intStartRec = 0
        GetData(intStartRec, intRecPerPage)
        intTotalRec = GetTotalRecord()
        SetRecordLabel()
        cn.Close()
    End Sub

    Private intStartRec, intRecPerPage, intTotalRec As Integer

    Private Function GetTotalRecord() As Integer
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) FROM mobil"

        If cn.State <> ConnectionState.Open Then cn.Open()
        intTotalRec = Convert.ToInt32(cmd.ExecuteScalar)
        Return intTotalRec
        cn.Close()
    End Function

    Private Sub GetData(ByVal startRecord As Integer, ByVal maxRecord As Integer)
        Using sqlDa As New SqlDataAdapter("SELECT kode_mobil, merk, tipe, warna, harga_mobil, gambar FROM mobil", cn)

            Dim ds As New DataSet

            sqlDa.Fill(ds, startRecord, maxRecord, "mobil")
            DataGridView1.DataSource = ds.Tables("mobil")
            cn.Close()
        End Using
    End Sub
 Private Sub SetRecordLabel()
        lbrecord.Text = "Jumlah data mulai : " + intStartRec.ToString + " Dari jumlah record : " + intTotalRec.ToString
    End Sub

    Private Sub btnfirst_Click(sender As Object, e As EventArgs) Handles btnfirst.Click
        intRecPerPage = NumericUpDown1.Value
        intStartRec = 0
        GetData(intStartRec, intRecPerPage)
        SetRecordLabel()
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        intRecPerPage = NumericUpDown1.Value
        intStartRec -= intRecPerPage

        If intStartRec >= 0 Then
            GetData(intStartRec, intRecPerPage)
            SetRecordLabel()
        Else
            intStartRec += intRecPerPage
        End If
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        intRecPerPage = NumericUpDown1.Value
        intStartRec += intRecPerPage

        If intStartRec < GetTotalRecord() Then
            GetData(intStartRec, intRecPerPage)
            SetRecordLabel()
        Else
            intStartRec -= intRecPerPage
        End If
    End Sub

    Private Sub btnlast_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        intRecPerPage = NumericUpDown1.Value
        intTotalRec = GetTotalRecord()
        intStartRec = intTotalRec - intRecPerPage
        GetData(intStartRec, intRecPerPage)
        SetRecordLabel()
    End Sub
End Class