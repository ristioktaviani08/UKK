Public Class FrmMenuLaporan

    Private Sub btnmobil_Click(sender As Object, e As EventArgs) Handles btnmobil.Click
        Dim lm As New FrmLapMobil
        lm.TopLevel = False
        FrmMenu.panel_menu.Controls.Add(lm)
        lm.Show()
    End Sub

    Private Sub btnpembeli_Click(sender As Object, e As EventArgs) Handles btnpembeli.Click
        Dim pem As New FrmLapPembeli
        pem.TopLevel = False
        FrmMenu.panel_menu.Controls.Add(pem)
        pem.Show()
    End Sub

    Private Sub btnpaket_Click(sender As Object, e As EventArgs) Handles btnpaket.Click
        Dim pk As New FrmLapPaketKredit
        pk.TopLevel = False
        FrmMenu.panel_menu.Controls.Add(pk)
        pk.Show()
    End Sub

    Private Sub btnkredit_Click(sender As Object, e As EventArgs) Handles btnkredit.Click
        Dim k As New LapKredit
        k.TopLevel = False
        FrmMenu.panel_menu.Controls.Add(k)
        k.Show()
    End Sub

    Private Sub btncash_Click(sender As Object, e As EventArgs) Handles btncash.Click
        Dim bc As New FrmLapBeliCash
        bc.TopLevel = False
        FrmMenu.panel_menu.Controls.Add(bc)
        bc.Show()
    End Sub

    Private Sub btnbayar_Click(sender As Object, e As EventArgs) Handles btnbayar.Click
        Dim bcln As New FrmLapBayarCicilan
        bcln.TopLevel = False
        FrmMenu.panel_menu.Controls.Add(bcln)
        bcln.Show()
    End Sub

    Private Sub btnpetugas_Click(sender As Object, e As EventArgs) Handles btnpetugas.Click
        Dim pet As New FrmLapPetugas
        pet.TopLevel = False
        FrmMenu.panel_menu.Controls.Add(pet)
        pet.Show()
    End Sub

    Private Sub btnpengguna_Click(sender As Object, e As EventArgs) Handles btnpengguna.Click
        Dim pgn As New FrmLapPengguna
        pgn.TopLevel = False
        FrmMenu.panel_menu.Controls.Add(pgn)
        pgn.Show()
    End Sub

    Private Sub FrmMenuLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class