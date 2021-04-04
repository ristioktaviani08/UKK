Imports System.Data.SqlClient
Public Class FrmMasuk
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub btnmasuk_Click(sender As Object, e As EventArgs) Handles btnmasuk.Click
        cn.ConnectionString = "Data Source=VICKY-PREDATOR\SQLEXPRESS;Initial Catalog=db_ukk_mobil;Integrated Security=True"
        cmd.Connection = cn
        cn.Open()
        cmd.CommandText = "SELECT id_petugas, nama, jabatan FROM vw_pengguna WHERE username='" & txtnama.Text & "' and password='" & txtpass.Text & "'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            If (rd("jabatan") = "ADMIN") Then
            ElseIf (rd("jabatan")) = "Kasir" Then
                FrmMenu.btnregistrasi.Enabled = False
                FrmMenu.btnakun.Enabled = False
                FrmMenu.btndashboard.Enabled = False
                FrmMenu.btnpetugas.Enabled = False
                FrmMenu.btnlap.Enabled = False
            ElseIf (rd("jabatan")) = "Manager" Then
                FrmMenu.btnregistrasi.Enabled = False
                FrmMenu.btndashboard.Enabled = False
                FrmMenu.btnpetugas.Enabled = False
                FrmMenu.btnlap.Enabled = False
                FrmMenu.btnakun.Enabled = False
            ElseIf (rd("jabatan")) = "Sekretaris" Then
                FrmMenu.btnregistrasi.Enabled = False
                FrmMenu.btnakun.Enabled = False
                FrmMenu.btnpetugas.Enabled = False
                FrmMenu.btnlap.Enabled = False
                FrmMenu.btndashboard.Enabled = False
            ElseIf (rd("jabatan")) = "Pemasaran" Then
                FrmMenu.btnregistrasi.Enabled = False
                FrmMenu.btnakun.Enabled = False
                FrmMenu.btncash.Enabled = False
                FrmMenu.btncicilan.Enabled = False
                FrmMenu.btnpetugas.Enabled = False
                FrmMenu.btnkredit.Enabled = False
                FrmMenu.btnlap.Enabled = False
                FrmMenu.btndashboard.Enabled = False
            End If

            FrmMenu.lbuser.Text = (rd("nama"))
            FrmMenu.lbljabatan.Text = (rd("jabatan"))

            FrmMenu.Show()
            Me.Hide()
        Else
            MessageBox.Show("Pengguna tidak ditemukan! Silahkan Lapor ke Admin.")
            txtnama.Text = ""
            txtpass.Text = ""
        End If
        cn.Close()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        End
    End Sub

    Private Sub FrmMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnama.Focus()
    End Sub
End Class