Public Class MenuAnggota



    Private Sub BtnLaporanAnggota_Click(sender As Object, e As EventArgs) Handles BtnLaporanAnggota.Click
        ' Pastikan user memang login dan ada id anggota
        If GlobalVar.UserIdAnggota <= 0 Then
            MessageBox.Show("ID anggota tidak ditemukan. Silakan login ulang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If GlobalVar.UserIdAnggota <= 0 Then
            MsgBox("ID anggota tidak ditemukan, silakan login ulang!")
            Exit Sub
        End If

        Dim f As New FormLaporanAnggota
        f.ShowDialog()


    End Sub

    Private Sub BtnKembaliMenuAnggota_Click(sender As Object, e As EventArgs) Handles BtnKembaliMenuAnggota.Click
        Me.Hide()
        LoginAnggota.Show()
    End Sub

    Private Sub BtnLogoutAnggota_Click(sender As Object, e As EventArgs) Handles BtnLogoutAnggota.Click
        Me.Hide()
        MenuLogin.Show()
    End Sub

    Private Sub MenuAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class