Imports System.Data.SqlClient
Public Class FrmBeliCash
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM beli_cash"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "Kode Beli Cash"
        DataGridView1.Columns(1).HeaderText = "No. KTP Pembeli"
        DataGridView1.Columns(2).HeaderText = "Kode Mobil"
        DataGridView1.Columns(3).HeaderText = "Tanggal Beli Cash"
        DataGridView1.Columns(4).HeaderText = "Jumlah Bayar Beli Cash"

        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 230
        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(3).Width = 200
        DataGridView1.Columns(4).Width = 255
    End Sub

    Sub bersih()
        txtkdbelicash.Text = ""
        txtktp.Text = ""
        txtnama.Text = ""
        txtkdmobil.Text = ""
        txtmerk.Text = ""
        txttipe.Text = ""
        tgl_cash.Text = ""
        txtjumlahbayar.Text = ""
        txttampilbayar.Text = ""
    End Sub

    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) AS kode_cash FROM beli_cash"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("kode_cash").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtkdbelicash.Text = "KCH-M-0" + Trim(Str(kodeauto))
            Case 2 : txtkdbelicash.Text = "KCH-M-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtkdbelicash.Text = "" Then
            MessageBox.Show("Kode Beli Cash wajib diisi, tidak boleh dikosongkan")
        ElseIf txtktp.Text = "" Then
            MessageBox.Show("No. KTP Pembeli wajib diisi, tidak boleh dikosongkan")
        ElseIf txtkdbelicash.Text <> "" And txtktp.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO beli_cash VALUES ('" & txtkdbelicash.Text & "','" & txtktp.Text & "','" & txtkdmobil.Text & "','" & tgl_cash.Value & "','" & txtjumlahbayar.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Beli Cash Berhasil Tersimpan", MsgBoxStyle.Information)
            tampildata()

        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If txtkdbelicash.Text = "" Then
            MessageBox.Show("Kode Beli Cash wajib diisi, tidak boleh dikosongkan")
        ElseIf txtktp.Text = "" Then
            MessageBox.Show("No. KTP Pembeli wajib diisi, tidak boleh dikosongkan")
        ElseIf txtkdbelicash.Text <> "" And txtktp.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "UPDATE beli_cash SET ktp ='" & txtktp.Text & "', kode_mobil ='" & txtkdmobil.Text & "', cash_tgl = '" & tgl_cash.Value & "', cash_bayar = '" & txtjumlahbayar.Text & "' WHERE kode_cash ='" & txtkdbelicash.Text & "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Beli Cash Berhasil Terubah", MsgBoxStyle.Information)
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
        cmd.CommandText = "DELETE FROM beli_cash WHERE kode_cash = '" + id + "'"
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Data Beli Cash Berhasil Tehapus", MsgBoxStyle.Information)
        tampildata()

    End Sub

    Private Sub txtcari_Click(sender As Object, e As EventArgs) Handles txtcari.Click
        lbcari.Visible = False
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM beli_cash WHERE kode_cash LIKE '%" & txtcari.Text & "%' OR ktp LIKE '%" & txtcari.Text & "%' OR kode_mobil LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub FrmBeliCash_Click(sender As Object, e As EventArgs) Handles Me.Click
        lbcari.Visible = True
    End Sub

    Private Sub FrmBeliCash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=VICKY-PREDATOR\SQLEXPRESS;Initial Catalog=db_ukk_mobil;Integrated Security=True"
        tampildata()
        txtkdbelicash.Enabled = False
        txtnama.Enabled = False
        txtmerk.Enabled = False
        txttipe.Enabled = False
        txttampilbayar.Enabled = False
        txtjumlahbayar.Enabled = False
        txtjumlahbayar.Visible = False
        autoktp()
        automobil()
        paging()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        kodeotomatis()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtkdbelicash.Text = DataGridView1.SelectedCells(0).Value
        txtktp.Text = DataGridView1.SelectedCells(1).Value
        txtkdmobil.Text = DataGridView1.SelectedCells(2).Value
        tgl_cash.Value = DataGridView1.SelectedCells(3).Value
        txtjumlahbayar.Text = DataGridView1.SelectedCells(4).Value
    End Sub

    Sub autoktp()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New SqlDataAdapter("SELECT * FROM pembeli", cn)
            da.Fill(dt)
            Dim r As DataRow
            txtktp.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtktp.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            cn.Close()
        End Try
    End Sub

    Sub automobil()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New SqlDataAdapter("SELECT * FROM mobil", cn)
            da.Fill(dt)
            Dim r As DataRow
            txtkdmobil.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtkdmobil.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            cn.Close()
        End Try
    End Sub

    Private Sub txtktp_TextChanged(sender As Object, e As EventArgs) Handles txtktp.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM pembeli WHERE ktp ='" & txtktp.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtnama.Text = (rd("nama_pembeli"))
        End If
        rd.Close()
        cn.Close()
    End Sub

    Private Sub txtkdmobil_TextChanged(sender As Object, e As EventArgs) Handles txtkdmobil.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM mobil WHERE kode_mobil ='" & txtkdmobil.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtmerk.Text = (rd("merk"))
            txttipe.Text = (rd("tipe"))
            txtjumlahbayar.Text = (rd("harga_mobil"))
        End If
        rd.Close()
        cn.Close()
    End Sub

    Private Sub txtjumlahbayar_TextChanged(sender As Object, e As EventArgs) Handles txtjumlahbayar.TextChanged
        Try
            Dim a As Integer
            a = txtjumlahbayar.Text
            txttampilbayar.Text = "Rp " + FormatNumber(a, 2, , TriState.True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
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
        cmd.CommandText = "SELECT COUNT(*) FROM beli_cash"

        If cn.State <> ConnectionState.Open Then cn.Open()
        intTotalRec = Convert.ToInt32(cmd.ExecuteScalar)
        Return intTotalRec
        cn.Close()
    End Function

    Private Sub GetData(ByVal startRecord As Integer, ByVal maxRecord As Integer)
        Using sqlDa As New SqlDataAdapter("SELECT kode_cash, ktp, kode_mobil, cash_tgl, cash_bayar FROM beli_cash", cn)

            Dim ds As New DataSet

            sqlDa.Fill(ds, startRecord, maxRecord, "beli_cash")
            DataGridView1.DataSource = ds.Tables("beli_cash")
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