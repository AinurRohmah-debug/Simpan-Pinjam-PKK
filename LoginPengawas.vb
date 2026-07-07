Imports System.Data.Odbc

Public Class LoginPengawas
    Private Sub BtnLoginPengawas_Click(sender As Object, e As EventArgs) Handles BtnLoginPengawas.Click
        Try
            bukaKoneksi()

            ' ODBC TIDAK MENGGUNAKAN @param → harus menggunakan tanda tanya (?)
            Dim query As String = "SELECT username, role FROM user WHERE username=? AND password=?"
            Dim cmd As New OdbcCommand(query, conn)

            cmd.Parameters.AddWithValue("username", TbxUsnPengawas.Text)
            cmd.Parameters.AddWithValue("password", TbxPassPengawas.Text)

            Dim dr As OdbcDataReader = cmd.ExecuteReader()

            If dr.HasRows Then
                dr.Read()
                Dim role As String = dr("role").ToString()
                If role = "Pengawas" Then
                    MessageBox.Show("Login Pengawas berhasil!", "Koneksi Sukses",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)

                    dr.Close()
                    tutupKoneksi()

                    Me.Hide()
                    MenuPengawas.Show()

                Else
                    MessageBox.Show("Akses ditolak! Akun ini bukan Pengawas.",
                                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Else
                MessageBox.Show("Username atau Password salah!",
                                "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If Not dr.IsClosed Then dr.Close()
            If conn.State = ConnectionState.Open Then conn.Close()


            TbxUsnPengawas.Clear()
            TbxPassPengawas.Clear()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub BtnKembaliPengawas_Click(sender As Object, e As EventArgs) Handles BtnKembaliPengawas.Click
        TbxUsnPengawas.Clear()
        TbxPassPengawas.Clear()
        Me.Hide()
        MenuLogin.Show()
    End Sub

    Private Sub TbxPassPengawas_TextChanged(sender As Object, e As EventArgs) Handles TbxPassPengawas.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub LoginPengawas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class