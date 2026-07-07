Imports System.Data.Odbc

Public Class MenuPengawas
    Private Sub BtnLaporanPKKP_Click(sender As Object, e As EventArgs) Handles BtnLaporanPKKP.Click
        Me.Hide()
        LaporanKeuangan.Show()

    End Sub

    Private Sub BtnLogoutPengawas_Click(sender As Object, e As EventArgs) Handles BtnLogoutPengawas.Click
        Me.Hide()
        MenuLogin.Show()
    End Sub

    Private Sub BtnKembaliP_Click(sender As Object, e As EventArgs) Handles BtnKembaliP.Click
        Me.Hide()
        LoginPengawas.Show()
    End Sub

    Private Sub BtnLaporanAnggotaP_Click(sender As Object, e As EventArgs) Handles BtnLaporanAnggotaP.Click
        Me.Hide()
        LaporanAnggota.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class