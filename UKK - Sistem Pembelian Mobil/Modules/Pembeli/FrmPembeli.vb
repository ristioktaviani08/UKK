Imports System.Data.SqlClient
Public Class FrmPembeli

    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM pembeli"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "No. KTP Pembeli"
        DataGridView1.Columns(1).HeaderText = "Nama Lengkap Pembeli"
        DataGridView1.Columns(2).HeaderText = "Alamat Pembeli"
        DataGridView1.Columns(3).HeaderText = "No. Handphone Pembeli"

        DataGridView1.Columns(0).Width = 205
        DataGridView1.Columns(1).Width = 320
        DataGridView1.Columns(2).Width = 350
        DataGridView1.Columns(3).Width = 210
    End Sub

    Sub bersih()
        txtktp.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""
        txttelp.Text = ""
    End Sub

    Private Sub FrmPembeli_Click(sender As Object, e As EventArgs) Handles Me.Click
        lbcari.Visible = True
    End Sub

    Private Sub FrmPembeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=VICKY-PREDATOR\SQLEXPRESS;Initial Catalog=db_ukk_mobil;Integrated Security=True"
        tampildata()
        txtktp.Enabled = False
        paging()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        txtktp.Enabled = True
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtktp.Text = "" Then
            MessageBox.Show("No. KTP Pembeli wajib diisi, tidak boleh dikosongkan")
        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Nama Pembeli wajib diisi, tidak boleh dikosongkan")
        ElseIf txtktp.Text <> "" And txtnama.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO pembeli VALUES ('" & txtktp.Text & "','" & txtnama.Text & "','" & txtalamat.Text & "','" & txttelp.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Pembeli Berhasil Tersimpan", MsgBoxStyle.Information)
            tampildata()
            txtktp.Enabled = False
        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If txtktp.Text = "" Then
            MessageBox.Show("No. KTP Pembeli wajib diisi, tidak boleh dikosongkan")
        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Nama Pembeli wajib diisi, tidak boleh dikosongkan")
        ElseIf txtktp.Text <> "" And txtnama.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "UPDATE pembeli SET nama_pembeli ='" & txtnama.Text & "', alamat_pembeli ='" & txtalamat.Text & "', telp_pembeli = '" & txttelp.Text & "' WHERE ktp ='" & txtktp.Text & "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Pembeli Berhasil Terubah", MsgBoxStyle.Information)
            tampildata()
            txtktp.Enabled = False
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim baris As Integer
        Dim id As String

        baris = DataGridView1.CurrentCell.RowIndex
        id = DataGridView1(0, baris).Value.ToString

        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "DELETE FROM pembeli WHERE ktp = '" + id + "'"
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Data Pembeli Berhasil Terhapus", MsgBoxStyle.Information)
        tampildata()


    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtktp.Text = DataGridView1.SelectedCells(0).Value
        txtnama.Text = DataGridView1.SelectedCells(1).Value
        txtalamat.Text = DataGridView1.SelectedCells(2).Value
        txttelp.Text = DataGridView1.SelectedCells(3).Value
    End Sub

    Private Sub txtcari_Click(sender As Object, e As EventArgs) Handles txtcari.Click
        lbcari.Visible = False
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM pembeli WHERE ktp LIKE '%" & txtcari.Text & "%' OR nama_pembeli LIKE '%" & txtcari.Text & "%' OR alamat_pembeli LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
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
        cmd.CommandText = "SELECT COUNT(*) FROM pembeli"

        If cn.State <> ConnectionState.Open Then cn.Open()
        intTotalRec = Convert.ToInt32(cmd.ExecuteScalar)
        Return intTotalRec
        cn.Close()
    End Function

    Private Sub GetData(ByVal startRecord As Integer, ByVal maxRecord As Integer)
        Using sqlDa As New SqlDataAdapter("SELECT ktp, nama_pembeli, alamat_pembeli, telp_pembeli FROM pembeli", cn)

            Dim ds As New DataSet

            sqlDa.Fill(ds, startRecord, maxRecord, "pembeli")
            DataGridView1.DataSource = ds.Tables("pembeli")
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