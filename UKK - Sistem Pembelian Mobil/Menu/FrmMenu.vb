Public Class FrmMenu
  
    Sub btnnormal()
        'dashboard
        btndashboard.BackColor = Color.FromArgb(50, 50, 58)
        pnldash.Visible = False
        lbldash.ForeColor = Color.FromArgb(133, 141, 147)
        lbldash.BackColor = Color.FromArgb(50, 50, 58)
        icondash.ForeColor = Color.FromArgb(133, 141, 147)
        icondash.BackColor = Color.FromArgb(50, 50, 58)
        'mobil
        btnmobil.BackColor = Color.FromArgb(50, 50, 58)
        pnlmobil.Visible = False
        lblmobil.ForeColor = Color.FromArgb(133, 141, 147)
        lblmobil.BackColor = Color.FromArgb(50, 50, 58)
        iconmobil.ForeColor = Color.FromArgb(133, 141, 147)
        iconmobil.BackColor = Color.FromArgb(50, 50, 58)
        'pembeli
        btnpembeli.BackColor = Color.FromArgb(50, 50, 58)
        pnlpembeli.Visible = False
        lblpembeli.ForeColor = Color.FromArgb(133, 141, 147)
        lblpembeli.BackColor = Color.FromArgb(50, 50, 58)
        iconpembeli.ForeColor = Color.FromArgb(133, 141, 147)
        iconpembeli.BackColor = Color.FromArgb(50, 50, 58)
        'kredit
        btnkredit.BackColor = Color.FromArgb(50, 50, 58)
        pnlkredit.Visible = False
        lblkredit.ForeColor = Color.FromArgb(133, 141, 147)
        lblkredit.BackColor = Color.FromArgb(50, 50, 58)
        iconkredit.ForeColor = Color.FromArgb(133, 141, 147)
        iconkredit.BackColor = Color.FromArgb(50, 50, 58)
        'paket
        btnpaket.BackColor = Color.FromArgb(50, 50, 58)
        pnlpaket.Visible = False
        lblpaket.ForeColor = Color.FromArgb(133, 141, 147)
        lblpaket.BackColor = Color.FromArgb(50, 50, 58)
        iconpaket.ForeColor = Color.FromArgb(133, 141, 147)
        iconpaket.BackColor = Color.FromArgb(50, 50, 58)
        'belicash
        btncash.BackColor = Color.FromArgb(50, 50, 58)
        pnlbelicash.Visible = False
        lblcash.ForeColor = Color.FromArgb(133, 141, 147)
        lblcash.BackColor = Color.FromArgb(50, 50, 58)
        iconcah.ForeColor = Color.FromArgb(133, 141, 147)
        iconcah.BackColor = Color.FromArgb(50, 50, 58)
        'cicilan
        btncicilan.BackColor = Color.FromArgb(50, 50, 58)
        pnlcicilan.Visible = False
        lblcicilan.ForeColor = Color.FromArgb(133, 141, 147)
        lblcicilan.BackColor = Color.FromArgb(50, 50, 58)
        iconcicilan.ForeColor = Color.FromArgb(133, 141, 147)
        iconcicilan.BackColor = Color.FromArgb(50, 50, 58)
        'skema
        btnskema.BackColor = Color.FromArgb(50, 50, 58)
        pnlskema.Visible = False
        lblskema.ForeColor = Color.FromArgb(133, 141, 147)
        lblskema.BackColor = Color.FromArgb(50, 50, 58)
        iconskema.ForeColor = Color.FromArgb(133, 141, 147)
        iconskema.BackColor = Color.FromArgb(50, 50, 58)
        'akun
        btnakun.BackColor = Color.FromArgb(50, 50, 58)
        pnlpengguna.Visible = False
        lblakun.ForeColor = Color.FromArgb(133, 141, 147)
        lblakun.BackColor = Color.FromArgb(50, 50, 58)
        iconpengguna.ForeColor = Color.FromArgb(133, 141, 147)
        iconpengguna.BackColor = Color.FromArgb(50, 50, 58)
        'laporan
        btnlap.BackColor = Color.FromArgb(50, 50, 58)
        pnllap.Visible = False
        lbllap.ForeColor = Color.FromArgb(133, 141, 147)
        lbllap.BackColor = Color.FromArgb(50, 50, 58)
        iconlap.ForeColor = Color.FromArgb(133, 141, 147)
        iconlap.BackColor = Color.FromArgb(50, 50, 58)
        'petugas
        btnpetugas.BackColor = Color.FromArgb(50, 50, 58)
        pnlpetugas.Visible = False
        lbpetugas.ForeColor = Color.FromArgb(133, 141, 147)
        lblpembeli.BackColor = Color.FromArgb(50, 50, 58)
        iconpetugas.ForeColor = Color.FromArgb(133, 141, 147)
        iconpetugas.BackColor = Color.FromArgb(50, 50, 58)
    End Sub
    Private Sub btnmobil_Click(sender As Object, e As EventArgs) Handles btnmobil.Click
        lbltempat.Text = "Data Mobil"
        btnnormal()
        Dim m As New FrmMobil
        m.TopLevel = False
        panel_menu.Controls.Add(m)
        m.Show()
        If pnlmobil.Visible = True Then
            btnmobil.BackColor = Color.FromArgb(53, 54, 65)
            pnlmobil.BackColor = Color.FromArgb(53, 54, 65)
            iconmobil.ForeColor = Color.FromArgb(44, 192, 216)
            iconmobil.BackColor = Color.FromArgb(53, 54, 65)
            lblmobil.ForeColor = Color.White
            lblmobil.BackColor = Color.FromArgb(53, 54, 65)
            pnlmobil.Visible = True

        Else : btnmobil.Visible = True
            btnmobil.BackColor = Color.FromArgb(53, 54, 65)
            pnlmobil.BackColor = Color.FromArgb(53, 54, 65)
            iconmobil.ForeColor = Color.FromArgb(44, 192, 216)
            iconmobil.BackColor = Color.FromArgb(53, 54, 65)
            lblmobil.ForeColor = Color.White
            lblmobil.BackColor = Color.FromArgb(53, 54, 65)
            pnlmobil.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblwaktu.Text = Format(Now, "hh:ss")
        lbltanggal.Text = Format(Now, "dddd, dd MMMM yyyy")
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnldash.Visible = False
        pnlmobil.Visible = False
        pnlpembeli.Visible = False
        pnlkredit.Visible = False
        pnlpaket.Visible = False
        pnlbelicash.Visible = False
        pnlcicilan.Visible = False
        pnlskema.Visible = False
        pnlpengguna.Visible = False
        pnlpetugas.Visible = False
        pnllap.Visible = False

        Dim mm As New FrmMenuUtama
        mm.TopLevel = False
        panel_menu.Controls.Add(mm)
        mm.Show()

        Timer1.Start()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        End
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        FrmKunciLayar.Show()
    End Sub

    Private Sub btnpembeli_Click(sender As Object, e As EventArgs) Handles btnpembeli.Click
        lbltempat.Text = "Data Pembeli"
        btnnormal()
        Dim pem As New FrmPembeli
        pem.TopLevel = False
        panel_menu.Controls.Add(pem)
        pem.Show()
        If pnlpembeli.Visible = True Then
            btnpembeli.BackColor = Color.FromArgb(53, 54, 65)
            pnlpembeli.BackColor = Color.FromArgb(53, 54, 65)
            iconpembeli.ForeColor = Color.FromArgb(44, 192, 216)
            iconpembeli.BackColor = Color.FromArgb(53, 54, 65)
            lblpembeli.ForeColor = Color.White
            lblpembeli.BackColor = Color.FromArgb(53, 54, 65)
            pnlpembeli.Visible = True

        Else : btnpembeli.Visible = True
            btnpembeli.BackColor = Color.FromArgb(53, 54, 65)
            pnlpembeli.BackColor = Color.FromArgb(53, 54, 65)
            iconpembeli.ForeColor = Color.FromArgb(44, 192, 216)
            iconpembeli.BackColor = Color.FromArgb(53, 54, 65)
            lblpembeli.ForeColor = Color.White
            lblpembeli.BackColor = Color.FromArgb(53, 54, 65)
            pnlpembeli.Visible = True
        End If
    End Sub

    Private Sub btnkredit_Click(sender As Object, e As EventArgs) Handles btnkredit.Click
        lbltempat.Text = "Data Beli Kredit"
        btnnormal()
        Dim kre As New FrmKredit
        kre.TopLevel = False
        panel_menu.Controls.Add(kre)
        kre.Show()
        If pnlkredit.Visible = True Then
            btnkredit.BackColor = Color.FromArgb(53, 54, 65)
            pnlkredit.BackColor = Color.FromArgb(53, 54, 65)
            iconkredit.ForeColor = Color.FromArgb(44, 192, 216)
            iconkredit.BackColor = Color.FromArgb(53, 54, 65)
            pnlkredit.ForeColor = Color.White
            lblkredit.BackColor = Color.FromArgb(53, 54, 65)
            pnlkredit.Visible = True

        Else : btnkredit.Visible = True
            btnkredit.BackColor = Color.FromArgb(53, 54, 65)
            pnlkredit.BackColor = Color.FromArgb(53, 54, 65)
            iconkredit.ForeColor = Color.FromArgb(44, 192, 216)
            iconkredit.BackColor = Color.FromArgb(53, 54, 65)
            pnlkredit.ForeColor = Color.White
            lblkredit.BackColor = Color.FromArgb(53, 54, 65)
            pnlkredit.Visible = True
        End If
    End Sub

    Private Sub btnpetugas_Click(sender As Object, e As EventArgs) Handles btnpetugas.Click
        lbltempat.Text = "Data Petugas Sistem"
        btnnormal()
        Dim pet As New FrmPetugas
        pet.TopLevel = False
        panel_menu.Controls.Add(pet)
        pet.Show()
        If pnlpetugas.Visible = True Then
            btnpetugas.BackColor = Color.FromArgb(53, 54, 65)
            pnlpetugas.BackColor = Color.FromArgb(53, 54, 65)
            iconpetugas.ForeColor = Color.FromArgb(44, 192, 216)
            iconpetugas.BackColor = Color.FromArgb(53, 54, 65)
            lbpetugas.ForeColor = Color.White
            lbpetugas.BackColor = Color.FromArgb(53, 54, 65)
            pnlpetugas.Visible = True

        Else : btnpetugas.Visible = True
            btnpetugas.BackColor = Color.FromArgb(53, 54, 65)
            pnlpetugas.BackColor = Color.FromArgb(53, 54, 65)
            iconpetugas.ForeColor = Color.FromArgb(44, 192, 216)
            iconpetugas.BackColor = Color.FromArgb(53, 54, 65)
            lbpetugas.ForeColor = Color.White
            lbpetugas.BackColor = Color.FromArgb(53, 54, 65)
            pnlpetugas.Visible = True
        End If
    End Sub

    Private Sub btnakun_Click(sender As Object, e As EventArgs) Handles btnakun.Click
        lbltempat.Text = "Data Pengguna Akun"
        btnnormal()
        Dim akn As New FrmPengguna
        akn.TopLevel = False
        panel_menu.Controls.Add(akn)
        akn.Show()
        If pnlpengguna.Visible = True Then
            btnakun.BackColor = Color.FromArgb(53, 54, 65)
            pnlpengguna.BackColor = Color.FromArgb(53, 54, 65)
            iconpengguna.ForeColor = Color.FromArgb(44, 192, 216)
            iconpengguna.BackColor = Color.FromArgb(53, 54, 65)
            lblakun.ForeColor = Color.White
            lblakun.BackColor = Color.FromArgb(53, 54, 65)
            pnlpengguna.Visible = True

        Else : btnakun.Visible = True
            btnakun.BackColor = Color.FromArgb(53, 54, 65)
            pnlpengguna.BackColor = Color.FromArgb(53, 54, 65)
            iconpengguna.ForeColor = Color.FromArgb(44, 192, 216)
            iconpengguna.BackColor = Color.FromArgb(53, 54, 65)
            lblakun.ForeColor = Color.White
            lblakun.BackColor = Color.FromArgb(53, 54, 65)
            pnlpengguna.Visible = True
        End If
    End Sub

    Private Sub btnskema_Click(sender As Object, e As EventArgs) Handles btnskema.Click
        lbltempat.Text = "Data Skema Pembelian"
        btnnormal()
        Dim skm As New FrmSkemaPembelian
        skm.TopLevel = False
        panel_menu.Controls.Add(skm)
        skm.Show()
        If pnlskema.Visible = True Then
            btnskema.BackColor = Color.FromArgb(53, 54, 65)
            pnlskema.BackColor = Color.FromArgb(53, 54, 65)
            iconskema.ForeColor = Color.FromArgb(44, 192, 216)
            iconskema.BackColor = Color.FromArgb(53, 54, 65)
            lblskema.ForeColor = Color.White
            lblskema.BackColor = Color.FromArgb(53, 54, 65)
            pnlskema.Visible = True

        Else : btnskema.Visible = True
            btnskema.BackColor = Color.FromArgb(53, 54, 65)
            pnlskema.BackColor = Color.FromArgb(53, 54, 65)
            iconskema.ForeColor = Color.FromArgb(44, 192, 216)
            iconskema.BackColor = Color.FromArgb(53, 54, 65)
            lblskema.ForeColor = Color.White
            lblskema.BackColor = Color.FromArgb(53, 54, 65)
            pnlskema.Visible = True
        End If
    End Sub

    Private Sub btncicilan_Click(sender As Object, e As EventArgs) Handles btncicilan.Click
        lbltempat.Text = "Data Bayar Cicilan"
        btnnormal()
        Dim bc As New FrmBayarCicilan
        bc.TopLevel = False
        panel_menu.Controls.Add(bc)
        bc.Show()
        If pnlcicilan.Visible = True Then
            btncicilan.BackColor = Color.FromArgb(53, 54, 65)
            pnlcicilan.BackColor = Color.FromArgb(53, 54, 65)
            iconcicilan.ForeColor = Color.FromArgb(44, 192, 216)
            iconcicilan.BackColor = Color.FromArgb(53, 54, 65)
            lblcicilan.ForeColor = Color.White
            lblcicilan.BackColor = Color.FromArgb(53, 54, 65)
            pnlcicilan.Visible = True

        Else : btncicilan.Visible = True
            btncicilan.BackColor = Color.FromArgb(53, 54, 65)
            pnlcicilan.BackColor = Color.FromArgb(53, 54, 65)
            iconcicilan.ForeColor = Color.FromArgb(44, 192, 216)
            iconcicilan.BackColor = Color.FromArgb(53, 54, 65)
            lblcicilan.ForeColor = Color.White
            lblcicilan.BackColor = Color.FromArgb(53, 54, 65)
            pnlcicilan.Visible = True
        End If
    End Sub

    Private Sub btncash_Click(sender As Object, e As EventArgs) Handles btncash.Click
        lbltempat.Text = "Data Beli Cash"
        btnnormal()
        Dim bsh As New FrmBeliCash
        bsh.TopLevel = False
        panel_menu.Controls.Add(bsh)
        bsh.Show()
        If pnlbelicash.Visible = True Then
            btncash.BackColor = Color.FromArgb(53, 54, 65)
            pnlbelicash.BackColor = Color.FromArgb(53, 54, 65)
            iconcah.ForeColor = Color.FromArgb(44, 192, 216)
            iconcah.BackColor = Color.FromArgb(53, 54, 65)
            pnlbelicash.ForeColor = Color.White
            lblcash.BackColor = Color.FromArgb(53, 54, 65)
            pnlbelicash.Visible = True

        Else : btncash.Visible = True
            btncash.BackColor = Color.FromArgb(53, 54, 65)
            pnlbelicash.BackColor = Color.FromArgb(53, 54, 65)
            iconcah.ForeColor = Color.FromArgb(44, 192, 216)
            iconcah.BackColor = Color.FromArgb(53, 54, 65)
            pnlbelicash.ForeColor = Color.White
            lblcash.BackColor = Color.FromArgb(53, 54, 65)
            pnlbelicash.Visible = True
        End If
    End Sub

    Private Sub btnpaket_Click(sender As Object, e As EventArgs) Handles btnpaket.Click
        lbltempat.Text = "Data Paket Kredit"
        btnnormal()
        Dim pk As New FrmPaketKredit
        pk.TopLevel = False
        panel_menu.Controls.Add(pk)
        pk.Show()
        If pnlpaket.Visible = True Then
            btnpaket.BackColor = Color.FromArgb(53, 54, 65)
            pnlpaket.BackColor = Color.FromArgb(53, 54, 65)
            iconpaket.ForeColor = Color.FromArgb(44, 192, 216)
            iconpaket.BackColor = Color.FromArgb(53, 54, 65)
            lblpaket.ForeColor = Color.White
            lblpaket.BackColor = Color.FromArgb(53, 54, 65)
            pnlpaket.Visible = True

        Else : btnpaket.Visible = True
            btnpaket.BackColor = Color.FromArgb(53, 54, 65)
            pnlpaket.BackColor = Color.FromArgb(53, 54, 65)
            iconpaket.ForeColor = Color.FromArgb(44, 192, 216)
            iconpaket.BackColor = Color.FromArgb(53, 54, 65)
            lblpaket.ForeColor = Color.White
            lblpaket.BackColor = Color.FromArgb(53, 54, 65)
            pnlpaket.Visible = True
        End If
    End Sub

    Private Sub btnlap_Click(sender As Object, e As EventArgs) Handles btnlap.Click
        lbltempat.Text = "Data Laporan Sistem Pembelian Mobil"
        btnnormal()
        Dim lap As New FrmMenuLaporan
        lap.TopLevel = False
        panel_menu.Controls.Add(lap)
        lap.Show()
        If pnllap.Visible = True Then
            btnlap.BackColor = Color.FromArgb(53, 54, 65)
            pnllap.BackColor = Color.FromArgb(53, 54, 65)
            iconlap.ForeColor = Color.FromArgb(44, 192, 216)
            iconlap.BackColor = Color.FromArgb(53, 54, 65)
            lbllap.ForeColor = Color.White
            lbllap.BackColor = Color.FromArgb(53, 54, 65)
            pnllap.Visible = True

        Else : btnlap.Visible = True
            btnlap.BackColor = Color.FromArgb(53, 54, 65)
            pnllap.BackColor = Color.FromArgb(53, 54, 65)
            iconlap.ForeColor = Color.FromArgb(44, 192, 216)
            iconlap.BackColor = Color.FromArgb(53, 54, 65)
            lbllap.ForeColor = Color.White
            lbllap.BackColor = Color.FromArgb(53, 54, 65)
            pnllap.Visible = True
        End If
    End Sub

    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        lbltempat.Text = "Dashboard"
        btnnormal()
        Dim dash As New FrmDashboard
        dash.TopLevel = False
        panel_menu.Controls.Add(dash)
        dash.Show()
        If pnldash.Visible = True Then
            btndashboard.BackColor = Color.FromArgb(53, 54, 65)
            pnldash.BackColor = Color.FromArgb(53, 54, 65)
            icondash.ForeColor = Color.FromArgb(44, 192, 216)
            icondash.BackColor = Color.FromArgb(53, 54, 65)
            lbldash.ForeColor = Color.White
            lbldash.BackColor = Color.FromArgb(53, 54, 65)
            pnldash.Visible = True

        Else : btndashboard.Visible = True
            btndashboard.BackColor = Color.FromArgb(53, 54, 65)
            pnldash.BackColor = Color.FromArgb(53, 54, 65)
            icondash.ForeColor = Color.FromArgb(44, 192, 216)
            icondash.BackColor = Color.FromArgb(53, 54, 65)
            lbldash.ForeColor = Color.White
            lbldash.BackColor = Color.FromArgb(53, 54, 65)
            pnldash.Visible = True
        End If
    End Sub

    Private Sub btnregistrasi_Click(sender As Object, e As EventArgs) Handles btnregistrasi.Click
        FrmDaftarAkun.Show()
    End Sub

    Private Sub btnbantuan_Click(sender As Object, e As EventArgs) Handles btnbantuan.Click
        Dim bs As New FrmBantuanAkun
        bs.TopLevel = False
        panel_menu.Controls.Add(bs)
        bs.Show()
    End Sub
End Class
