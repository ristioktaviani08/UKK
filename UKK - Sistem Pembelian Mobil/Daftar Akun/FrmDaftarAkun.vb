Imports System.Data.SqlClient
Public Class FrmDaftarAkun
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampil()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM pengguna"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        FrmPengguna.DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Sub bersih()
        txtid.Text = ""
        txttampilnama.Text = ""
        txtnama.Text = ""
        txtpass.Text = ""
    End Sub

    Sub autoktp()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New SqlDataAdapter("SELECT * FROM petugas", cn)
            da.Fill(dt)
            Dim r As DataRow
            txtid.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtid.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            cn.Close()
        End Try
    End Sub
    
    Private Sub btnaktifkan_Click(sender As Object, e As EventArgs) Handles btnaktifkan.Click
        If txtid.Text = "" Then
            MessageBox.Show("ID Petugas wajid diisi, tidak boleh dikosongkan!")
        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Nama Pengguna wajib diisi, tidak boleh dikosongkan!")
        ElseIf txtid.Text <> "" And txtnama.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO pengguna VALUES ('" & txtid.Text & "','" & txtnama.Text & "','" & txtpass.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Akun Pengguna telah berhasil dibuat, aplikasi akan tertutup. silahkan masuk kembali untuk menggunakan akun", MsgBoxStyle.Information)
            End
        End If
    End Sub

    Private Sub FrmDaftarAkun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=VICKY-PREDATOR\SQLEXPRESS;Initial Catalog=db_ukk_mobil;Integrated Security=True"
        txtid.Focus()
        autoktp()
    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM petugas WHERE id_petugas ='" & txtid.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txttampilnama.Text = (rd("nama"))
        End If
        rd.Close()
        cn.Close()
    End Sub
End Class