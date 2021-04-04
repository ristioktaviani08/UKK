Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FrmMenuUtama
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampil()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM Vw_menu"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "Merk Mobil"
        DataGridView1.Columns(1).HeaderText = "Tipe Mobil"
        DataGridView1.Columns(2).HeaderText = "Warna Mobil"
        DataGridView1.Columns(3).HeaderText = "Gambar Mobil"
        DataGridView1.Columns(4).HeaderText = "Harga Mobil"
        DataGridView1.Columns(5).HeaderText = "Harga Paket"
        DataGridView1.Columns(6).HeaderText = "Uang Muka"
        DataGridView1.Columns(7).HeaderText = "Paket Jumlah Cicilan"
        DataGridView1.Columns(8).HeaderText = "Bunga(%)"

        DataGridView1.Columns(0).Width = 125
        DataGridView1.Columns(1).Width = 110
        DataGridView1.Columns(2).Width = 110
        DataGridView1.Columns(3).Width = 155
        DataGridView1.Columns(4).Width = 110
        DataGridView1.Columns(5).Width = 120
        DataGridView1.Columns(6).Width = 120
        DataGridView1.Columns(7).Width = 155
        DataGridView1.Columns(8).Width = 120
    End Sub

    Sub cht1()
        With Chart1
            .Series.Clear()
            .Series.Add("Skema Pembelian Mobil berdasarkan merk")

            .ChartAreas(0).AxisX.Interval = 1

            .ChartAreas(0).AxisX.IsStartedFromZero = True
            .Series(0).ChartType = SeriesChartType.Doughnut
            .Series(0).XValueType = ChartValueType.String
            .Series(0).YValueType = ChartValueType.Double

            .Series(0).Points.AddXY("Suzuki", 10)
            .Series(0).Points.AddXY("Honda", 7)
            .Series(0).Points.AddXY("Yamaha", 15)
            .Series(0).Points.AddXY("Toyota", 5)
        End With
    End Sub

    Sub cht2()
        With Chart2
            .Series.Clear()
            .Series.Add("Skema Pembelian Mobil berdasarkan Pembelian")

            .ChartAreas(0).AxisX.Interval = 1

            .ChartAreas(0).AxisX.IsStartedFromZero = True
            .Series(0).ChartType = SeriesChartType.Pie
            .Series(0).XValueType = ChartValueType.String
            .Series(0).YValueType = ChartValueType.Double

            .Series(0).Points.AddXY("Beli Kredit", 60)
            .Series(0).Points.AddXY("Beli Cash", 35)
            .Series(0).Points.AddXY("Bayar Cicilan", 40)
        End With
    End Sub

    Sub cht3()
        With Chart3
            .Series.Clear()
            .Series.Add("Skema Petugas dan Pengguna Sistem")

            .ChartAreas(0).AxisX.Interval = 1

            .ChartAreas(0).AxisX.IsStartedFromZero = True
            .Series(0).ChartType = SeriesChartType.Funnel
            .Series(0).XValueType = ChartValueType.String
            .Series(0).YValueType = ChartValueType.Double
            .Series(0).Points.AddXY("Petugas", 65)
            .Series(0).Points.AddXY("Pengguna", 45)

        End With
    End Sub

    Private Sub FrmMenuUtama_Click(sender As Object, e As EventArgs) Handles Me.Click
        lbcari.Visible = True
    End Sub

    Private Sub FrmMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=VICKY-PREDATOR\SQLEXPRESS;Initial Catalog=db_ukk_mobil;Integrated Security=True"
        tampil()
        cht1()
        cht2()
        cht3()
        paging()
    End Sub

    Private Sub txtcari_Click(sender As Object, e As EventArgs) Handles txtcari.Click
        lbcari.Visible = False
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM Vw_menu WHERE merk LIKE '%" & txtcari.Text & "%' OR tipe LIKE '%" & txtcari.Text & "%'OR warna LIKE '%" & txtcari.Text & "%' OR harga_mobil LIKE '%" & txtcari.Text & "%'"
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
        cmd.CommandText = "SELECT COUNT(*) FROM Vw_menu"

        If cn.State <> ConnectionState.Open Then cn.Open()
        intTotalRec = Convert.ToInt32(cmd.ExecuteScalar)
        Return intTotalRec
        cn.Close()
    End Function

    Private Sub GetData(ByVal startRecord As Integer, ByVal maxRecord As Integer)
        Using sqlDa As New SqlDataAdapter("SELECT merk, tipe, warna, gambar, harga_mobil, harga_paket, uang_muka, paket_jumlah_cicilan, bunga FROM Vw_menu", cn)

            Dim ds As New DataSet

            sqlDa.Fill(ds, startRecord, maxRecord, "Vw_menu")
            DataGridView1.DataSource = ds.Tables("Vw_menu")
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