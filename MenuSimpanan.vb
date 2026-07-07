Public Class MenuSimpanan


    Private Sub BtnSimpanWjb_Click(sender As Object, e As EventArgs) Handles BtnSimpanWjb.Click
        Me.Hide()
        SimpananWajib.Show()
    End Sub

    Private Sub BtnSimpanSK_Click(sender As Object, e As EventArgs) Handles BtnSimpanSK.Click
        Me.Hide()
        SimpananSukarela.Show()
    End Sub

    Private Sub BtnLaporanBendahara_Click(sender As Object, e As EventArgs) Handles BtnLaporanBendahara.Click
        Me.Hide()
        MenuLaporanBendahara.Show()
    End Sub

    Private Sub BtbTambahAnggota_Click(sender As Object, e As EventArgs) Handles BtbTambahAnggota.Click
        Me.Hide()
        TambahAnggota.Show()
    End Sub

    Private Sub BtnSimpanPinjam_Click(sender As Object, e As EventArgs) Handles BtnSimpanPinjam.Click
        Me.Hide()
        SimpanPinjam.Show()
    End Sub

    Private Sub BtnAngsuran_Click(sender As Object, e As EventArgs) Handles BtnAngsuran.Click
        Me.Hide()
        Angsuran.Show()
    End Sub

    Private Sub BtnLogBendahara_Click(sender As Object, e As EventArgs) Handles BtnLogBendahara.Click
        Me.Hide()
        MenuLogin.Show()
    End Sub

    Private Sub MenuSimpanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class