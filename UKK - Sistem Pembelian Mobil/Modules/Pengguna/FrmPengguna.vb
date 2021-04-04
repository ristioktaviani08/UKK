Imports System.Data.SqlClient
Public Class FrmPengguna
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM pengguna"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "ID Petugas"
        DataGridView1.Columns(1).HeaderText = "Nama Pengguna"
        DataGridView1.Columns(2).HeaderText = "Kata Sandi"

        DataGridView1.Columns(0).Width = 300
        DataGridView1.Columns(1).Width = 300
        DataGridView1.Columns(2).Width = 300
    End Sub

    Sub bersih()
        txtid.Text = ""
        txtnama.Text = ""
        txtsandi.Text = ""
    End Sub

    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) AS id_petugas FROM pengguna"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("id_petugas").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtid.Text = "PTS-M-0" + Trim(Str(kodeauto))
            Case 2 : txtid.Text = "PTS-M-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub

    'Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
    '    If txtid.Text = "" Then
    '        MessageBox.Show("ID Petugas wajib diisi, tidak boleh dikosongkan")
    '    ElseIf txtnama.Text = "" Then
    '        MessageBox.Show("Nama Pengguna wajib diisi, tidak boleh dikosongkan")
    '    ElseIf txtid.Text <> "" And txtnama.Text <> "" Then
    '        cn.Open()
    '        cmd.Connection = cn
    '        cmd.CommandText = "INSERT INTO pengguna VALUES ('" & txtid.Text & "','" & txtnama.Text & "','" & txtsandi.Text & " ')"
    '        cmd.ExecuteNonQuery()
    '        cn.Close()
    '        bersih()
    '        MsgBox("Data Pengguna Berhasil Tersimpan", MsgBoxStyle.Information)
    '        tampildata()

    '    End If
    'End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If txtid.Text = "" Then
            MessageBox.Show("ID Petugas wajib diisi, tidak boleh dikosongkan")
        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Nama Pengguna wajib diisi, tidak boleh dikosongkan")
        ElseIf txtid.Text <> "" And txtnama.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "UPDATE pengguna SET username ='" & txtnama.Text & "', password ='" & txtsandi.Text & "' WHERE id_petugas ='" & txtid.Text & "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Pengguna Berhasil Terubah", MsgBoxStyle.Information)
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
        cmd.CommandText = "DELETE FROM pengguna WHERE id_petugas = '" + id + "'"
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Data Pengguna Berhasil Terhapus", MsgBoxStyle.Information)
        tampildata()

    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
    End Sub

    'Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
    '    kodeotomatis()
    'End Sub

    Private Sub FrmPengguna_Click(sender As Object, e As EventArgs) Handles Me.Click
        lbcari.Visible = True
    End Sub

    Private Sub FrmPengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=VICKY-PREDATOR\SQLEXPRESS;Initial Catalog=db_ukk_mobil;Integrated Security=True"
        tampildata()
        txtid.Enabled = False
        SetRecordLabel()
        paging()
    End Sub

    Private Sub txtcari_Click(sender As Object, e As EventArgs) Handles txtcari.Click
        lbcari.Visible = False
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM pengguna WHERE id_petugas LIKE '%" & txtcari.Text & "%' OR username LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtid.Text = DataGridView1.SelectedCells(0).Value
        txtnama.Text = DataGridView1.SelectedCells(1).Value
        txtsandi.Text = DataGridView1.SelectedCells(2).Value
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
        cmd.CommandText = "SELECT COUNT(*) FROM pengguna"

        If cn.State <> ConnectionState.Open Then cn.Open()
        intTotalRec = Convert.ToInt32(cmd.ExecuteScalar)
        Return intTotalRec
        cn.Close()
    End Function

    Private Sub GetData(ByVal startRecord As Integer, ByVal maxRecord As Integer)
        Using sqlDa As New SqlDataAdapter("SELECT id_petugas, username, password FROM pengguna", cn)

            Dim ds As New DataSet

            sqlDa.Fill(ds, startRecord, maxRecord, "pengguna")
            DataGridView1.DataSource = ds.Tables("pengguna")
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