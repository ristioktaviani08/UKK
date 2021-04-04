Imports System.Data.SqlClient
Public Class FrmBayarCicilan
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM bayar_cicilan"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "Kode Bayar Cicilan"
        DataGridView1.Columns(1).HeaderText = "Kode Kredit"
        DataGridView1.Columns(2).HeaderText = "Tanggal Bayar Cicilan"
        DataGridView1.Columns(3).HeaderText = "Jumlah Cicilan"
        DataGridView1.Columns(4).HeaderText = "Cicilan Ke"
        DataGridView1.Columns(5).HeaderText = "Cicilan Sisa Ke"
        DataGridView1.Columns(6).HeaderText = "Cicilan Sisa Harga"

        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 230
        DataGridView1.Columns(2).Width = 160
        DataGridView1.Columns(3).Width = 120
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 125
        DataGridView1.Columns(6).Width = 150
    End Sub

    Sub bersih()
        txtkdcicilan.Text = ""
        txtkdkredit.Text = ""
        txtktp.Text = ""
        txtnama.Text = ""
        tglcicilan.Text = ""
        txtjumlah.Text = ""
        txtnama.Text = ""
        txtcicilanke.Text = ""
        txtcicilan_sisa_ke.Text = ""
        txtsisaharga.Text = ""
        txttampilharga.Text = ""
    End Sub

    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) AS kode_cicilan FROM bayar_cicilan"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("kode_cicilan").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtkdcicilan.Text = "KBC-M-0" + Trim(Str(kodeauto))
            Case 2 : txtkdcicilan.Text = "KBC-M-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtkdcicilan.Text = "" Then
            MessageBox.Show("Kode Cicilan wajib diisi, tidak boleh dikosongkan")
        ElseIf txtkdkredit.Text = "" Then
            MessageBox.Show("Kode Kredit wajib diisi, tidak boleh dikosongkan")
        ElseIf txtkdcicilan.Text <> "" And txtkdkredit.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO bayar_cicilan VALUES ('" & txtkdcicilan.Text & "','" & txtkdkredit.Text & "','" & tglcicilan.Value & "','" & txtjumlah.Text & "','" & txtcicilanke.Text & "','" & txtcicilan_sisa_ke.Text & "','" & txtsisaharga.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Bayar Cicilan Berhasil Tersimpan", MsgBoxStyle.Information)
            tampildata()

        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If txtkdcicilan.Text = "" Then
            MessageBox.Show("Kode Cicilan wajib diisi, tidak boleh dikosongkan")
        ElseIf txtkdkredit.Text = "" Then
            MessageBox.Show("Kode Kredit wajib diisi, tidak boleh dikosongkan")
        ElseIf txtkdcicilan.Text <> "" And txtkdkredit.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "UPDATE bayar_cicilan SET kode_kredit ='" & txtkdkredit.Text & "', tgl_cicilan ='" & tglcicilan.Value & "', jumlah_cicilan = '" & txtjumlah.Text & "', cicilan_ke = '" & txtcicilanke.Text & "', cicilan_sisa_ke = '" & txtcicilan_sisa_ke.Text & "', cicilan_sisa_harga = '" & txtsisaharga.Text & "' WHERE kode_cicilan ='" & txtkdcicilan.Text & "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Bayar Cicilan Berhasil Terubah", MsgBoxStyle.Information)
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
        cmd.CommandText = "DELETE FROM bayar_cicilan WHERE kode_cicilan = '" + id + "'"
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Data Bayar Cicilan Berhasil Terubah", MsgBoxStyle.Information)
        tampildata()

    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        kodeotomatis()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
    End Sub

    Private Sub FrmBayarCicilan_Click(sender As Object, e As EventArgs) Handles Me.Click
        lbcari.Visible = True
    End Sub

    Private Sub FrmBayarCicilan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=VICKY-PREDATOR\SQLEXPRESS;Initial Catalog=db_ukk_mobil;Integrated Security=True"
        tampildata()
        txtkdcicilan.Enabled = False
        txtktp.Enabled = False
        txtnama.Enabled = False
        txttampilharga.Enabled = False
        txtcicilanke.Enabled = False
        txtcicilan_sisa_ke.Enabled = False
        txtsisaharga.Enabled = False
        txtsisaharga.Visible = False
        autokredit()
        paging()
    End Sub

    Private Sub txtcari_Click(sender As Object, e As EventArgs) Handles txtcari.Click
        lbcari.Visible = False
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM bayar_cicilan WHERE kode_cicilan LIKE '%" & txtcari.Text & "%' OR kode_kredit LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtkdcicilan.Text = DataGridView1.SelectedCells(0).Value
        txtkdkredit.Text = DataGridView1.SelectedCells(1).Value
        tglcicilan.Value = DataGridView1.SelectedCells(2).Value
        txtjumlah.Text = DataGridView1.SelectedCells(3).Value
        txtcicilanke.Text = DataGridView1.SelectedCells(4).Value
        txtcicilan_sisa_ke.Text = DataGridView1.SelectedCells(5).Value
        txtsisaharga.Text = DataGridView1.SelectedCells(6).Value
    End Sub

    Private Sub txtsisaharga_TextChanged(sender As Object, e As EventArgs) Handles txtsisaharga.TextChanged
        Try
            Dim a As Integer
            a = txtsisaharga.Text
            txttampilharga.Text = "Rp " + FormatNumber(a, 2, , , TriState.True)
        Catch ex As Exception

        End Try
    End Sub


    Sub autokredit()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New SqlDataAdapter("SELECT * FROM kredit", cn)
            da.Fill(dt)
            Dim r As DataRow
            txtkdkredit.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtkdkredit.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            cn.Close()
        End Try
    End Sub


    Private Sub txtkdkredit_TextChanged(sender As Object, e As EventArgs) Handles txtkdkredit.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM kredit WHERE kode_kredit ='" & txtkdkredit.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtktp.Text = (rd("ktp"))
            txtnama.Text = (rd("nama_pembeli"))
        End If
        rd.Close()
        cn.Close()
    End Sub

    'KALKULASI
    Function ambil_total_jumlah_cicilan()

        Dim cmd2 As New SqlCommand
        Dim total_jumlah_cicilan_ke As Integer

        cn.Open()
        cmd2.Connection = cn
        cmd2.CommandText = "SELECT SUM(jumlah_cicilan) AS jumlah_cicilan_ke FROM bayar_cicilan WHERE kode_kredit = '" & txtkdkredit.Text & "'"
        cmd2.ExecuteNonQuery()

        Dim rd As SqlDataReader = cmd2.ExecuteReader

        rd.Read()

        If rd.HasRows Then
            Try
                total_jumlah_cicilan_ke = Val(rd("jumlah_cicilan_ke"))
            Catch ex As Exception
                total_jumlah_cicilan_ke = 0
            End Try

        Else
            total_jumlah_cicilan_ke = -1
        End If

        rd.Close()
        cn.Close()

        Return total_jumlah_cicilan_ke
    End Function

    Function ambil_paket_jumlah_cicilan()
        Dim cmd2 As New SqlCommand
        Dim paket_jumlah_cicilan As Integer


        cn.Open()
        cmd2.Connection = cn

        cmd2.CommandText = "SELECT pk.paket_jumlah_cicilan AS pjc FROM kredit AS K JOIN paket_kredit AS pk ON (k.kode_paket = pk.kode_paket) WHERE k.kode_kredit = '" & txtkdkredit.Text & "'"
        cmd2.ExecuteNonQuery()

        Dim rd As SqlDataReader = cmd2.ExecuteReader

        rd.Read()

        If rd.HasRows Then
            paket_jumlah_cicilan = Val(rd("pjc"))
        Else
            paket_jumlah_cicilan = -1
        End If

        rd.Close()
        cn.Close()

        Return paket_jumlah_cicilan
    End Function

    Sub cicilan_sisa_ke()

        Dim paket_jumlah_cicilan, total_jumlah_cicilan_ke As Integer

        total_jumlah_cicilan_ke = ambil_total_jumlah_cicilan()
        If total_jumlah_cicilan_ke = -1 Then
            MsgBox("Tidak dapat mengambil nilai total_jumlah_cicilan_ke")
            Exit Sub
        End If

        paket_jumlah_cicilan = ambil_paket_jumlah_cicilan()
        If paket_jumlah_cicilan = -1 Then
            MsgBox("Tidak dapat mengambil nilai paket_jumlah_cicilan")
            Exit Sub
        End If

        txtcicilan_sisa_ke.Text = paket_jumlah_cicilan - total_jumlah_cicilan_ke - Val(txtjumlah.Text)
        cn.Close()
    End Sub

    Function ambil_total_cicilan()
        Dim cmd2 As New SqlCommand
        Dim total_cicilan As Integer


        cn.Open()
        cmd2.Connection = cn

        cmd2.CommandText = "SELECT (pk.paket_jumlah_cicilan * pk.nilai_cicilan) AS total_cicilan FROM kredit AS k JOIN paket_kredit AS pk ON (k.kode_paket = pk.kode_paket) WHERE k.kode_kredit = '" & txtkdkredit.Text & "'"
        cmd2.ExecuteNonQuery()

        Dim rd As SqlDataReader = cmd2.ExecuteReader

        rd.Read()

        If rd.HasRows Then
            total_cicilan = Val(rd("total_cicilan"))
        Else
            total_cicilan = -1
        End If

        rd.Close()
        cn.Close()

        Return total_cicilan
    End Function

    Function ambil_nilai_cicilan()
        Dim cmd2 As New SqlCommand
        Dim nilai_cicilan As Integer


        cn.Open()
        cmd2.Connection = cn

        cmd2.CommandText = "SELECT pk.nilai_cicilan FROM kredit AS k JOIN paket_kredit AS pk ON (k.kode_paket = pk.kode_paket) WHERE k.kode_kredit = '" & txtkdkredit.Text & "'"
        cmd2.ExecuteNonQuery()

        Dim rd As SqlDataReader = cmd2.ExecuteReader

        rd.Read()

        If rd.HasRows Then
            nilai_cicilan = Val(rd("nilai_cicilan"))
        Else
            nilai_cicilan = -1
        End If

        rd.Close()
        cn.Close()

        Return nilai_cicilan
    End Function

    Sub hitung_cicilan_sisa_harga()
        Dim total_cicilan, nilai_cicilan, total_jumlah_cicilan_ke, jumlah_cicilan_terbayar, cicilan_sisa_harga, harga_sementara As Integer

        total_cicilan = ambil_total_cicilan()
        If total_cicilan = -1 Then
            MsgBox("Tidak dapat mengambil nilai total_cicilan")
            Exit Sub
        End If

        nilai_cicilan = ambil_nilai_cicilan()
        If nilai_cicilan = -1 Then
            MsgBox("Tidak dapat mengambil nilai nilai_cicilan")
            Exit Sub
        End If

        total_jumlah_cicilan_ke = ambil_total_jumlah_cicilan()
        If total_jumlah_cicilan_ke = -1 Then
            MsgBox("Tidak dapat mengambil nilai nilai_cicilan")
            Exit Sub
        End If

        harga_sementara = nilai_cicilan * Val(txtjumlah.Text)

        jumlah_cicilan_terbayar = nilai_cicilan * total_jumlah_cicilan_ke
        cicilan_sisa_harga = total_cicilan - jumlah_cicilan_terbayar - harga_sementara

        txtsisaharga.Text = cicilan_sisa_harga
    End Sub

    Sub cari_cicilan_ke()
        cn.Open()
        cmd.CommandText = "SELECT COUNT(*) AS cicilan_ke FROM bayar_cicilan WHERE kode_kredit = '" & txtkdkredit.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader

        rd.Read()

        If rd.HasRows Then
            Dim cicilan As Integer = Val(rd("cicilan_ke")) + 1
            txtcicilanke.Text = cicilan
        Else
            txtcicilanke.Text = "-1"
        End If

        rd.Close()
        cn.Close()
    End Sub

    Private Sub txtjumlah_TextChanged(sender As Object, e As EventArgs) Handles txtjumlah.TextChanged
        If txtjumlah.Text.Length = 0 Then
            Exit Sub
        Else
            cari_cicilan_ke()
            cicilan_sisa_ke()
            hitung_cicilan_sisa_harga()
        End If
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
        cmd.CommandText = "SELECT COUNT(*) FROM bayar_cicilan"

        If cn.State <> ConnectionState.Open Then cn.Open()
        intTotalRec = Convert.ToInt32(cmd.ExecuteScalar)
        Return intTotalRec
        cn.Close()
    End Function

    Private Sub GetData(ByVal startRecord As Integer, ByVal maxRecord As Integer)
        Using sqlDa As New SqlDataAdapter("SELECT kode_cicilan, kode_kredit, tgl_cicilan, jumlah_cicilan, cicilan_ke, cicilan_sisa_ke, cicilan_sisa_harga FROM bayar_cicilan", cn)

            Dim ds As New DataSet

            sqlDa.Fill(ds, startRecord, maxRecord, "bayar_cicilan")
            DataGridView1.DataSource = ds.Tables("bayar_cicilan")
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