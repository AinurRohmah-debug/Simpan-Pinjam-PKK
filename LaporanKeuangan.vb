Imports System.Data.Odbc

Public Class LaporanKeuangan
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub LaporanKeuangan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLaporan()
    End Sub
    Private Sub LoadLaporan()
        bukaKoneksi()

        Dim query As String = "SELECT * FROM view_laporan_bendahara"
        Dim da As New OdbcDataAdapter(query, conn)
        Dim ds As New DataSet

        ds.Clear()
        da.Fill(ds, "view_laporan_bendahara")

        tutupKoneksi()

        Dim rpt As New CrystalReport1  'nama file .rpt kamu
        rpt.SetDataSource(ds)

        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.ReuseParameterValuesOnRefresh = False
        CrystalReportViewer1.RefreshReport()

    End Sub
End Class