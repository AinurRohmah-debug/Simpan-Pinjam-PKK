Imports System.Data.Odbc

Public Class LoginAnggota


    Private Sub BtnLoginiAnggota_Click(sender As Object, e As EventArgs) Handles BtnLoginiAnggota.Click
        Try
            bukaKoneksi()

            Dim query As String = "SELECT id_user, username, role, id_anggota FROM user WHERE username=? AND password=?"
            Dim cmd As New Odbc.OdbcCommand(query, conn)

            cmd.Parameters.AddWithValue("?", TbxUsnAnggota.Text.Trim())
            cmd.Parameters.AddWithValue("?", TbxPassAnggota.Text.Trim())

            Dim dr As Odbc.OdbcDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                GlobalVar.UserRole = dr("role").ToString()
                If Not IsDBNull(dr("id_anggota")) Then
                    GlobalVar.UserIdAnggota = Convert.ToInt32(dr("id_anggota"))
                Else
                    GlobalVar.UserIdAnggota = 0
                End If

                ' Hanya contoh role check
                If GlobalVar.UserRole.ToLower() = "anggota" Then
                    MessageBox.Show("Login berhasil (Anggota).", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dr.Close()
                    tutupKoneksi()
                    Me.Hide()
                    MenuAnggota.Show()        ' buka form menu anggota
                Else
                    MessageBox.Show("Akun bukan anggota.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Username / password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If Not dr.IsClosed Then dr.Close()
            tutupKoneksi()

            TbxUsnAnggota.Clear()
            TbxPassAnggota.Clear()
        Catch ex As Exception
            MessageBox.Show("Error pada login: " & ex.Message)
            If conn.State = ConnectionState.Open Then tutupKoneksi()
        End Try
    End Sub



    Private Sub BtnKembaliAnggota_Click(sender As Object, e As EventArgs) Handles BtnKembaliAnggota.Click
        TbxUsnAnggota.Clear()
        TbxPassAnggota.Clear()
        Me.Hide()
        MenuLogin.Show()
    End Sub

    Private Sub LoginAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class