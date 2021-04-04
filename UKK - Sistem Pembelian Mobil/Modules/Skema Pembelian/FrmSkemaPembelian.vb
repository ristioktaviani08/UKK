Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Public Class FrmSkemaPembelian
    Sub cht1()
        With Chart1
            .Series.Clear()
            .Series.Add("Skema Pembelian Mobil berdasarkan merk")

            .ChartAreas(0).AxisX.Interval = 1

            .ChartAreas(0).AxisX.IsStartedFromZero = True
            .Series(0).ChartType = SeriesChartType.Pie
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
            .Series.Add("Skema Pembelian Mobil")

            .ChartAreas(0).AxisX.Interval = 1

            .ChartAreas(0).AxisX.IsStartedFromZero = True
            .Series(0).ChartType = SeriesChartType.Pie
            .Series(0).XValueType = ChartValueType.String
            .Series(0).YValueType = ChartValueType.Double
            .Series(0).Points.AddXY("Beli Kredit", 75)
            .Series(0).Points.AddXY("Beli Cash", 50)
            .Series(0).Points.AddXY("Bayar Cicilan", 50)
        End With
    End Sub

    Private Sub FrmSkemaPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cht1()
        cht2()
    End Sub


End Class