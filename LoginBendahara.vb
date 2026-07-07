Imports System.Data.Odbc
Public Class LoginBendahara


    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            bukaKoneksi()

            ' ODBC TIDAK MENGGUNAKAN @param → harus menggunakan tanda tanya (?)
            Dim query As String = "SELECT username, role FROM user WHERE username=? AND password=?"
            Dim cmd As New OdbcCommand(query, conn)

            cmd.Parameters.AddWithValue("username", TbxUsnBendahara.Text)
            cmd.Parameters.AddWithValue("password", TbxPassBendahara.Text)

            Dim dr As OdbcDataReader = cmd.ExecuteReader()

            If dr.HasRows Then
                dr.Read()
                Dim role As String = dr("role").ToString()
                If role = "Bendahara" Then
                    MessageBox.Show("Login Bendahara berhasil!", "Koneksi Sukses",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)

                    dr.Close()
                    tutupKoneksi()

                    Me.Hide()
                    MenuSimpanan.Show()

                Else
                    MessageBox.Show("Akses ditolak! Akun ini bukan Bendahara.",
                                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Else
                MessageBox.Show("Username atau Password salah!",
                                "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If Not dr.IsClosed Then dr.Close()
            If conn.State = ConnectionState.Open Then conn.Close()

            TbxUsnBendahara.Clear()
            TbxPassBendahara.Clear()


        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        TbxUsnBendahara.Clear()
        TbxPassBendahara.Clear()
        Me.Hide()
        MenuLogin.Show()
    End Sub

    Private Sub LoginBendahara_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class