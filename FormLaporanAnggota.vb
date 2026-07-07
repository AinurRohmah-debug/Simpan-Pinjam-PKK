Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class FormLaporanAnggota

    Private Sub FormLaporanAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim rpt As New LaporanGabungan()

            'Jika Crystal minta login, set koneksi (opsional)
            Dim connInfo As New ConnectionInfo()
            connInfo.ServerName = "PKKkoneksi"
            connInfo.UserID = "sisilia"
            connInfo.Password = "sisilia140106#"

            For Each t As Table In rpt.Database.Tables
                Dim logon = t.LogOnInfo
                logon.ConnectionInfo = connInfo
                t.ApplyLogOnInfo(logon)
            Next

            ' 🔥 FILTER LANGSUNG DI SINI, tanpa parameter Crystal
            CrystalReportViewer1.SelectionFormula =
                "{view_laporan_anggota1.id_anggota} = " & GlobalVar.UserIdAnggota

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show("Gagal tampilkan laporan: " & ex.Message)
        End Try
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class