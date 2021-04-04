﻿Imports System.Data.SqlClient
Public Class FrmKredit
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM kredit"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "Kode Kredit"
        DataGridView1.Columns(1).HeaderText = "No. KTP Pembeli"
        DataGridView1.Columns(2).HeaderText = "Nama Pembeli"
        DataGridView1.Columns(3).HeaderText = "Kode Paket"
        DataGridView1.Columns(4).HeaderText = "Kode Mobil"
        DataGridView1.Columns(5).HeaderText = "Tanggal Kredit"
        DataGridView1.Columns(6).HeaderText = "Fotokopi KTP"
        DataGridView1.Columns(7).HeaderText = "Fotokopi KK"
        DataGridView1.Columns(8).HeaderText = "Fotokopi Slip Gaji"

        DataGridView1.Columns(0).Width = 115
        DataGridView1.Columns(1).Width = 170
        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(7).Width = 100
        DataGridView1.Columns(8).Width = 100
    End Sub

    Sub bersih()
        txtkdkredit.Text = ""
        txtktp.Text = ""
        txtnama.Text = ""
        txtkdpaket.Text = ""
        txtharga.Text = ""
        txtkdmobil.Text = ""
        txtmerk.Text = ""
        txttipe.Text = ""
        tgl_kredit.Text = ""
        cbktp.Text = ""
        cbkk.Text = ""
        cbslip_gaji.Text = ""
    End Sub

    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) AS kode_kredit FROM kredit"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("kode_kredit").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtkdkredit.Text = "KKM-M-0" + Trim(Str(kodeauto))
            Case 2 : txtkdkredit.Text = "KKM-M-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtkdkredit.Text = "" Then
            MessageBox.Show("Kode Kredit wajib diisi, tidak boleh dikosongkan")
        ElseIf txtktp.Text = "" Then
            MessageBox.Show("No. KTP Pembeli wajib diisi, tidak boleh dikosongkan")
        ElseIf txtkdkredit.Text <> "" And txtktp.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO kredit VALUES ('" & txtkdkredit.Text & "','" & txtktp.Text & "','" & txtnama.Text & "','" & txtkdpaket.Text & "','" & txtkdmobil.Text & "','" & tgl_kredit.Value & "','" & cbktp.Text & "','" & cbkk.Text & "','" & cbslip_gaji.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Kredit Berhasil Tersimpan", MsgBoxStyle.Information)
            tampildata()

        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If txtkdkredit.Text = "" Then
            MessageBox.Show("Kode Kredit wajib diisi, tidak boleh dikosongkan")
        ElseIf txtktp.Text = "" Then
            MessageBox.Show("No. KTP Pembeli wajib diisi, tidak boleh dikosongkan")
        ElseIf txtkdkredit.Text <> "" And txtktp.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "UPDATE kredit SET ktp ='" & txtktp.Text & "', nama_pembeli ='" & txtnama.Text & "', kode_paket = '" & txtkdpaket.Text & "', kode_mobil= '" & txtkdmobil.Text & "', tgl_kredit = '" & tgl_kredit.Value & "', fotokopi_ktp = '" & cbktp.Text & "', fotokopi_kk = '" & cbkk.Text & "', fotokopi_slip_gaji = '" & cbslip_gaji.Text & "' WHERE kode_kredit ='" & txtkdkredit.Text & "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Kredit Berhasil Terubah", MsgBoxStyle.Information)
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
        cmd.CommandText = "DELETE FROM kredit WHERE kode_kredit = '" + id + "'"
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Data Kredit Berhasil Terhapus", MsgBoxStyle.Information)
        tampildata()

    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        kodeotomatis()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
    End Sub

    Private Sub FrmKredit_Click(sender As Object, e As EventArgs) Handles Me.Click
        lbcari.Visible = True
    End Sub

    Private Sub FrmKredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=VICKY-PREDATOR\SQLEXPRESS;Initial Catalog=db_ukk_mobil;Integrated Security=True"
        tampildata()
        txtkdkredit.Enabled = False
        txtnama.Enabled = False
        txtmerk.Enabled = False
        txttipe.Enabled = False
        txtharga.Enabled = False
        autoktp()
        autopaket()
        automobil()
        paging()
    End Sub

    Private Sub txtcari_Click(sender As Object, e As EventArgs) Handles txtcari.Click
        lbcari.Visible = False
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM kredit WHERE kode_kredit LIKE '%" & txtcari.Text & "%' OR ktp LIKE '%" & txtcari.Text & "%' OR kode_paket LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtkdkredit.Text = DataGridView1.SelectedCells(0).Value
        txtktp.Text = DataGridView1.SelectedCells(1).Value
        txtnama.Text = DataGridView1.SelectedCells(2).Value
        txtkdpaket.Text = DataGridView1.SelectedCells(3).Value
        txtkdmobil.Text = DataGridView1.SelectedCells(4).Value
        tgl_kredit.Value = DataGridView1.SelectedCells(5).Value
        cbktp.Text = DataGridView1.SelectedCells(6).Value
        cbkk.Text = DataGridView1.SelectedCells(7).Value
        cbslip_gaji.Text = DataGridView1.SelectedCells(8).Value
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

    Sub autopaket()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New SqlDataAdapter("SELECT * FROM paket_kredit", cn)
            da.Fill(dt)
            Dim r As DataRow
            txtkdpaket.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtkdpaket.AutoCompleteCustomSource.Add(r.Item(0).ToString)
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

    Private Sub txtkdpaket_TextChanged(sender As Object, e As EventArgs) Handles txtkdpaket.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM paket_kredit WHERE kode_paket ='" & txtkdpaket.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtharga.Text = (rd("harga_paket"))
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
        End If
        rd.Close()
        cn.Close()
    End Sub

    Private Sub txtharga_TextChanged(sender As Object, e As EventArgs) Handles txtharga.TextChanged
        Try
            txtharga.Text = "Rp " + FormatNumber(txtharga.Text, 2, , , TriState.True)
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
        cmd.CommandText = "SELECT COUNT(*) FROM kredit"

        If cn.State <> ConnectionState.Open Then cn.Open()
        intTotalRec = Convert.ToInt32(cmd.ExecuteScalar)
        Return intTotalRec
        cn.Close()
    End Function

    Private Sub GetData(ByVal startRecord As Integer, ByVal maxRecord As Integer)
        Using sqlDa As New SqlDataAdapter("SELECT kode_kredit, ktp, nama_pembeli, kode_paket, kode_mobil, tgl_kredit, fotokopi_ktp, fotokopi_kk, fotokopi_slip_gaji FROM kredit", cn)

            Dim ds As New DataSet

            sqlDa.Fill(ds, startRecord, maxRecord, "kredit")
            DataGridView1.DataSource = ds.Tables("kredit")
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