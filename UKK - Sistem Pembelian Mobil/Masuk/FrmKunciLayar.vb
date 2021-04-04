Imports System.Data.SqlClient
Public Class FrmKunciLayar

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

            ElseIf (rd("jabatan")) = "MANAGER" Then
                FrmMenu.btnregistrasi.Enabled = False
                FrmMenu.btnakun.Enabled = False
            ElseIf (rd("jabatan")) = "SEKRETARIS" Then
                FrmMenu.btnregistrasi.Enabled = False
                FrmMenu.btnakun.Enabled = False
                FrmMenu.btndashboard.Enabled = False
            ElseIf (rd("jabatan")) = "SALES" Then
                FrmMenu.btnregistrasi.Enabled = False
                FrmMenu.btnakun.Enabled = False
                FrmMenu.btncash.Enabled = False
                FrmMenu.btncicilan.Enabled = False
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

    Private Sub FrmKunciLayar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Visible = False
        Timer1.Start()
    End Sub

    Private Sub btnbuka_Click(sender As Object, e As EventArgs) Handles btnbuka.Click
        If Panel2.Visible = True Then
            Panel1.Visible = False
        Else : Panel2.Visible = True
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblwaktu.Text = Format(Now, "hh:ss")
        lbltgl.Text = Format(Now, "dddd, dd MMMMM yyyy ")
    End Sub
End Class