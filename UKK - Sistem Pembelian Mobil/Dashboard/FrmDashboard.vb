Public Class FrmDashboard

    Private Sub btnmobil_Click(sender As Object, e As EventArgs) Handles btnmobil.Click
        FrmMenu.lbltempat.Text = "Data Mobil"
        FrmMenu.btnnormal()
        Dim m As New FrmMobil
        m.TopLevel = False
        FrmMenu.panel_menu.Controls.Add(m)
        m.Show()
        If FrmMenu.pnlmobil.Visible = True Then
            FrmMenu.btnmobil.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlmobil.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.iconmobil.ForeColor = Color.FromArgb(44, 192, 216)
            FrmMenu.iconmobil.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.lblmobil.ForeColor = Color.White
            FrmMenu.lblmobil.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlmobil.Visible = True

        Else : FrmMenu.btnmobil.Visible = True
            FrmMenu.btnmobil.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlmobil.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.iconmobil.ForeColor = Color.FromArgb(44, 192, 216)
            FrmMenu.iconmobil.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.lblmobil.ForeColor = Color.White
            FrmMenu.lblmobil.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlmobil.Visible = True
        End If
    End Sub

    Private Sub btnpembeli_Click(sender As Object, e As EventArgs) Handles btnpembeli.Click
        FrmMenu.lbltempat.Text = "Data Pembeli"
        FrmMenu.btnnormal()
        Dim pem As New FrmPembeli
        pem.TopLevel = False
        FrmMenu.panel_menu.Controls.Add(pem)
        pem.Show()
        If FrmMenu.pnlpembeli.Visible = True Then
            FrmMenu.btnpembeli.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlpembeli.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.iconpembeli.ForeColor = Color.FromArgb(44, 192, 216)
            FrmMenu.iconpembeli.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.lblpembeli.ForeColor = Color.White
            FrmMenu.lblpembeli.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlpembeli.Visible = True

        Else : FrmMenu.btnpembeli.Visible = True
            FrmMenu.btnpembeli.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlpembeli.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.iconpembeli.ForeColor = Color.FromArgb(44, 192, 216)
            FrmMenu.iconpembeli.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.lblpembeli.ForeColor = Color.White
            FrmMenu.lblpembeli.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlpembeli.Visible = True
        End If
    End Sub

    Private Sub btnkredit_Click(sender As Object, e As EventArgs) Handles btnkredit.Click
        FrmMenu.lbltempat.Text = "Data Beli Kredit"
        FrmMenu.btnnormal()
        Dim kre As New FrmKredit
        kre.TopLevel = False
        FrmMenu.panel_menu.Controls.Add(kre)
        kre.Show()
        If FrmMenu.pnlkredit.Visible = True Then
            FrmMenu.btnkredit.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlkredit.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.iconkredit.ForeColor = Color.FromArgb(44, 192, 216)
            FrmMenu.iconkredit.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlkredit.ForeColor = Color.White
            FrmMenu.lblkredit.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlkredit.Visible = True

        Else : FrmMenu.btnkredit.Visible = True
            FrmMenu.btnkredit.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlkredit.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.iconkredit.ForeColor = Color.FromArgb(44, 192, 216)
            FrmMenu.iconkredit.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlkredit.ForeColor = Color.White
            FrmMenu.lblkredit.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlkredit.Visible = True
        End If
    End Sub

    Private Sub btnpaket_Click(sender As Object, e As EventArgs) Handles btnpaket.Click
        FrmMenu.lbltempat.Text = "Data Paket Kredit"
        FrmMenu.btnnormal()
        Dim pk As New FrmPaketKredit
        pk.TopLevel = False
        FrmMenu.panel_menu.Controls.Add(pk)
        pk.Show()
        If FrmMenu.pnlpaket.Visible = True Then
            FrmMenu.btnpaket.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlpaket.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.iconpaket.ForeColor = Color.FromArgb(44, 192, 216)
            FrmMenu.iconpaket.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.lblpaket.ForeColor = Color.White
            FrmMenu.lblpaket.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlpaket.Visible = True

        Else : FrmMenu.btnpaket.Visible = True
            FrmMenu.btnpaket.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlpaket.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.iconpaket.ForeColor = Color.FromArgb(44, 192, 216)
            FrmMenu.iconpaket.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.lblpaket.ForeColor = Color.White
            FrmMenu.lblpaket.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlpaket.Visible = True
        End If
    End Sub

    Private Sub btnbelicash_Click(sender As Object, e As EventArgs) Handles btnbelicash.Click
        FrmMenu.lbltempat.Text = "Data Beli Cash"
        FrmMenu.btnnormal()
        Dim bsh As New FrmBeliCash
        bsh.TopLevel = False
        FrmMenu.panel_menu.Controls.Add(bsh)
        bsh.Show()
        If FrmMenu.pnlbelicash.Visible = True Then
            FrmMenu.btncash.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlbelicash.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.iconcah.ForeColor = Color.FromArgb(44, 192, 216)
            FrmMenu.iconcah.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlbelicash.ForeColor = Color.White
            FrmMenu.lblcash.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlbelicash.Visible = True

        Else : FrmMenu.btncash.Visible = True
            FrmMenu.btncash.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlbelicash.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.iconcah.ForeColor = Color.FromArgb(44, 192, 216)
            FrmMenu.iconcah.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlbelicash.ForeColor = Color.White
            FrmMenu.lblcash.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlbelicash.Visible = True
        End If
    End Sub

    Private Sub btncicilan_Click(sender As Object, e As EventArgs) Handles btncicilan.Click
        FrmMenu.lbltempat.Text = "Data Bayar Cicilan"
        FrmMenu.btnnormal()
        Dim bc As New FrmBayarCicilan
        bc.TopLevel = False
        FrmMenu.panel_menu.Controls.Add(bc)
        bc.Show()
        If FrmMenu.pnlcicilan.Visible = True Then
            FrmMenu.btncicilan.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlcicilan.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.iconcicilan.ForeColor = Color.FromArgb(44, 192, 216)
            FrmMenu.iconcicilan.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.lblcicilan.ForeColor = Color.White
            FrmMenu.lblcicilan.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlcicilan.Visible = True

        Else : FrmMenu.btncicilan.Visible = True
            FrmMenu.btncicilan.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlcicilan.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.iconcicilan.ForeColor = Color.FromArgb(44, 192, 216)
            FrmMenu.iconcicilan.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.lblcicilan.ForeColor = Color.White
            FrmMenu.lblcicilan.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlcicilan.Visible = True
        End If
    End Sub

    Private Sub btnskema_Click(sender As Object, e As EventArgs) Handles btnskema.Click
        FrmMenu.lbltempat.Text = "Data Skema Pembelian"
        FrmMenu.btnnormal()
        Dim skm As New FrmSkemaPembelian
        skm.TopLevel = False
        FrmMenu.panel_menu.Controls.Add(skm)
        skm.Show()
        If FrmMenu.pnlskema.Visible = True Then
            FrmMenu.btnskema.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlskema.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.iconskema.ForeColor = Color.FromArgb(44, 192, 216)
            FrmMenu.iconskema.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.lblskema.ForeColor = Color.White
            FrmMenu.lblskema.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlskema.Visible = True

        Else : FrmMenu.btnskema.Visible = True
            FrmMenu.btnskema.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlskema.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.iconskema.ForeColor = Color.FromArgb(44, 192, 216)
            FrmMenu.iconskema.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.lblskema.ForeColor = Color.White
            FrmMenu.lblskema.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlskema.Visible = True
        End If
    End Sub

    Private Sub btnpengguna_Click(sender As Object, e As EventArgs) Handles btnpengguna.Click
        FrmMenu.lbltempat.Text = "Data Pengguna Akun"
        FrmMenu.btnnormal()
        Dim akn As New FrmPengguna
        akn.TopLevel = False
        FrmMenu.panel_menu.Controls.Add(akn)
        akn.Show()
        If FrmMenu.pnlpengguna.Visible = True Then
            FrmMenu.btnakun.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlpengguna.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.iconpengguna.ForeColor = Color.FromArgb(44, 192, 216)
            FrmMenu.iconpengguna.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.lblakun.ForeColor = Color.White
            FrmMenu.lblakun.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlpengguna.Visible = True

        Else : FrmMenu.btnakun.Visible = True
            FrmMenu.btnakun.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlpengguna.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.iconpengguna.ForeColor = Color.FromArgb(44, 192, 216)
            FrmMenu.iconpengguna.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.lblakun.ForeColor = Color.White
            FrmMenu.lblakun.BackColor = Color.FromArgb(53, 54, 65)
            FrmMenu.pnlpengguna.Visible = True
        End If
    End Sub
End Class