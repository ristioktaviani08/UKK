Imports System.Data.SqlClient
Public Class FrmPaketKredit
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM paket_kredit"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "Kode Paket Kredit"
        DataGridView1.Columns(1).HeaderText = "Harga Paket Kredit"
        DataGridView1.Columns(2).HeaderText = "Uang Muka"
        DataGridView1.Columns(3).HeaderText = "Paket Jumlah Cicilan"
        DataGridView1.Columns(4).HeaderText = "Bunga(%)"
        DataGridView1.Columns(5).HeaderText = "Nilai Cicilan"

        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(3).Width = 200
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 185
    End Sub

    Sub bersih()
        txtkdpaketkredit.Text = ""
        txtharga.Text = ""
        txttampilharga.Text = ""
        txtuangmuka.Text = ""
        txttampiluangmuka.Text = ""
        txtpaketjumlahcicilan.Text = ""
        txtbunga.Text = ""
        txtnilaicicilan.Text = ""
        txttampilcicilan.Text = ""
    End Sub

    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) AS kode_paket FROM paket_kredit"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("kode_paket").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtkdpaketkredit.Text = "PKM-M-0" + Trim(Str(kodeauto))
            Case 2 : txtkdpaketkredit.Text = "PKM-M-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub

    Sub hitung()
        If txtharga.Text.Length = 0 Then
            txtnilaicicilan.Text = ""
            Exit Sub
        End If
        If txtuangmuka.Text.Length = 0 Then
            txtnilaicicilan.Text = ""
            Exit Sub
        End If
        If txtpaketjumlahcicilan.Text.Length = 0 Then
            txtnilaicicilan.Text = ""
            Exit Sub
        End If
        If txtbunga.Text.Length = 0 Then
            txtnilaicicilan.Text = ""
            Exit Sub
        End If

        Try
            Dim uangmuka, harga, jmlpaket, bunga, jml1, jml2, jmlbunga As Integer
            uangmuka = Val(txtuangmuka.Text)
            harga = Val(txtharga.Text)
            jmlpaket = Val(txtpaketjumlahcicilan.Text)
            bunga = Val(txtbunga.Text)

            jml1 = harga - uangmuka
            jmlbunga = jml1 * bunga / 100
            jml2 = (jml1 / jmlpaket) + jmlbunga

            txtnilaicicilan.Text = jml2
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try

    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtkdpaketkredit.Text = "" Then
            MessageBox.Show("Kode Paket Kredit wajib diisi, tidak boleh dikosongkan")
        ElseIf txtharga.Text = "" Then
            MessageBox.Show("Harga Paket Kredit wajib diisi, tidak boleh dikosongkan")
        ElseIf txtkdpaketkredit.Text <> "" And txtharga.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO paket_kredit VALUES ('" & txtkdpaketkredit.Text & "','" & txtharga.Text & "','" & txtuangmuka.Text & "','" & txtpaketjumlahcicilan.Text & "','" & txtbunga.Text & "','" & txtnilaicicilan.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Paket Kredit Berhasil Tersimpan", MsgBoxStyle.Information)
            tampildata()

        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If txtkdpaketkredit.Text = "" Then
            MessageBox.Show("Kode Paket Kredit wajib diisi, tidak boleh dikosongkan")
        ElseIf txtharga.Text = "" Then
            MessageBox.Show("Harga Paket Kredit wajib diisi, tidak boleh dikosongkan")
        ElseIf txtkdpaketkredit.Text <> "" And txtharga.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "UPDATE paket_kredit SET harga_paket ='" & txtharga.Text & "', uang_muka ='" & txtuangmuka.Text & "', paket_jumlah_cicilan = '" & txtpaketjumlahcicilan.Text & "', bunga = '" & txtbunga.Text & "', nilai_cicilan = '" & txtnilaicicilan.Text & "' WHERE kode_paket ='" & txtkdpaketkredit.Text & "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Paket Kredit Berhasil Terubah", MsgBoxStyle.Information)
            tampildata()

        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim baris As Integer
        Dim id As String

        baris = DataGridView1.CurrentCell.RowIndex
        id = DataGridView1(0, baris).Value.ToString

        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "DELETE FROM paket_kredit WHERE kode_paket = '" + id + "'"
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Data Paket Kredit Berhasil Terhapus", MsgBoxStyle.Information)
        tampildata()

    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        kodeotomatis()
    End Sub

    Private Sub txtcari_Click(sender As Object, e As EventArgs) Handles txtcari.Click
        lbcari.Visible = False
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM paket_kredit WHERE kode_paket LIKE '%" & txtcari.Text & "%' OR harga_paket LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub FrmPaketKredit_Click(sender As Object, e As EventArgs) Handles Me.Click
        lbcari.Visible = True
    End Sub

    Private Sub FrmPaketKredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=VICKY-PREDATOR\SQLEXPRESS;Initial Catalog=db_ukk_mobil;Integrated Security=True"
        tampildata()
        txtkdpaketkredit.Enabled = False
        txttampilharga.Enabled = False
        txttampiluangmuka.Enabled = False
        txttampilcicilan.Enabled = False
        txtnilaicicilan.Enabled = False
        txtnilaicicilan.Visible = False
        paging()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtkdpaketkredit.Text = DataGridView1.SelectedCells(0).Value
        txtharga.Text = DataGridView1.SelectedCells(1).Value
        txtuangmuka.Text = DataGridView1.SelectedCells(2).Value
        txtpaketjumlahcicilan.Text = DataGridView1.SelectedCells(3).Value
        txtbunga.Text = DataGridView1.SelectedCells(4).Value
        txtnilaicicilan.Text = DataGridView1.SelectedCells(5).Value
    End Sub

    Private Sub txttampilharga_TextChanged(sender As Object, e As EventArgs) Handles txttampilharga.TextChanged
        Try
            txttampilharga.Text = "Rp " + FormatNumber(txttampilharga.Text, 2, , TriState.True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtharga_TextChanged(sender As Object, e As EventArgs) Handles txtharga.TextChanged
        hitung()
        Try
            Dim a As Integer
            a = txtharga.Text
            txttampilharga.Text = "Rp " + FormatNumber(a, 2, , , TriState.True)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtuangmuka_TextChanged(sender As Object, e As EventArgs) Handles txtuangmuka.TextChanged
        hitung()
        Try
            Dim a As Integer
            a = txtuangmuka.Text
            txttampiluangmuka.Text = "Rp " + FormatNumber(a, 2, , , TriState.True)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtnilaicicilan_TextChanged(sender As Object, e As EventArgs) Handles txtnilaicicilan.TextChanged
        hitung()
        Try
            Dim a As Integer
            a = txtnilaicicilan.Text
            txttampilcicilan.Text = "Rp " + FormatNumber(a, 2, , , TriState.True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtpaketjumlahcicilan_TextChanged(sender As Object, e As EventArgs) Handles txtpaketjumlahcicilan.TextChanged
        hitung()
    End Sub

    Private Sub txtbunga_TextChanged(sender As Object, e As EventArgs) Handles txtbunga.TextChanged
        hitung()
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
        cmd.CommandText = "SELECT COUNT(*) FROM paket_kredit"

        If cn.State <> ConnectionState.Open Then cn.Open()
        intTotalRec = Convert.ToInt32(cmd.ExecuteScalar)
        Return intTotalRec
        cn.Close()
    End Function

    Private Sub GetData(ByVal startRecord As Integer, ByVal maxRecord As Integer)
        Using sqlDa As New SqlDataAdapter("SELECT kode_paket, harga_paket, uang_muka, paket_jumlah_cicilan, bunga, nilai_cicilan FROM paket_kredit", cn)

            Dim ds As New DataSet

            sqlDa.Fill(ds, startRecord, maxRecord, "paket_kredit")
            DataGridView1.DataSource = ds.Tables("paket_kredit")
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

    Private Sub txttampilcicilan_TextChanged(sender As Object, e As EventArgs) Handles txttampilcicilan.TextChanged

    End Sub
End Class