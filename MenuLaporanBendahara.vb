Public Class MenuLaporanBendahara
    Private Sub BtnLaporanPKKBen_Click(sender As Object, e As EventArgs) Handles BtnLaporanPKKBen.Click
        Me.Hide()
        LaporanKeuangan.Show()
    End Sub

    Private Sub BtnKembaliLaporanBen_Click(sender As Object, e As EventArgs) Handles BtnKembaliLaporanBen.Click
        Me.Hide()
        MenuSimpanan.Show()

    End Sub

    Private Sub BtnLaporanAnggotaBen_Click(sender As Object, e As EventArgs) Handles BtnLaporanAnggotaBen.Click
        Me.Hide()
        LaporanAnggota.Show()
    End Sub

    Private Sub BtnLogotLprnBdhr_Click(sender As Object, e As EventArgs) Handles BtnLogotLprnBdhr.Click
        Me.Hide()
        MenuLogin.Show()
    End Sub
End Class