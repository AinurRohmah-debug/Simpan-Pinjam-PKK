Imports System.Data.Odbc

Public Class TambahAnggota
    Sub AutoID()
        Try
            bukaKoneksi()

            Dim cmd As New OdbcCommand("SELECT MAX(id_anggota) FROM anggota", conn)
            Dim hasil = cmd.ExecuteScalar()

            If hasil Is DBNull.Value Or hasil Is Nothing Then
                ' ID pertama mulai dari 100
                CbIdAnggota.Text = "100"
            Else
                Dim nextID As Integer = CInt(hasil) + 1
                CbIdAnggota.Text = nextID.ToString()
            End If

        Catch ex As Exception
            MsgBox("Error AutoID: " & ex.Message)
        Finally
            tutupKoneksi()
        End Try
    End Sub
    Sub ClearInput()
        ' Hanya clear input yang diisi user
        TbxNamaAnggota.Clear()
        TbxAlamat.Clear()
        TbxEmail.Clear()
        TbxNoTelp.Clear()

        ' Kalau punya TextBox lain, tambahkan di sini
        ' TextBoxLain.Clear()
    End Sub
    Sub TampilkanData()
        Try
            bukaKoneksi()

            Dim da As New OdbcDataAdapter("SELECT * FROM anggota ORDER BY id_anggota ASC", conn)
            Dim dt As New DataTable
            da.Fill(dt)

            DgAnggota.DataSource = dt
            DgAnggota.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox("Error TampilData: " & ex.Message)
        Finally
            tutupKoneksi()
        End Try
    End Sub
    Sub LoadIDAnggota()
        Try
            bukaKoneksi()

            Dim cmd As New Odbc.OdbcCommand("SELECT id_anggota FROM anggota ORDER BY id_anggota ASC", conn)
            Dim dr As Odbc.OdbcDataReader = cmd.ExecuteReader()

            CbIdAnggota.Items.Clear()
            While dr.Read()
                CbIdAnggota.Items.Add(dr("id_anggota").ToString())
            End While

            dr.Close()

        Catch ex As Exception
            MsgBox("Error load ID anggota: " & ex.Message)
        Finally
            tutupKoneksi()
        End Try
    End Sub


    Private Sub TambahAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadIDAnggota()
        AutoID()
        TampilkanData()
        ClearInput()
    End Sub

    Private Sub BtnSimpanAgt_Click(sender As Object, e As EventArgs) Handles BtnSimpanAgt.Click
        Try
            bukaKoneksi()

            Dim sql As String =
            "INSERT INTO anggota (id_anggota, nama_anggota,alamat, no_hp, email) VALUES (?,?,?,?,?)"

            Dim cmd As New OdbcCommand(sql, conn)
            cmd.Parameters.AddWithValue("?", CbIdAnggota.Text)
            cmd.Parameters.AddWithValue("?", TbxNamaAnggota.Text)
            cmd.Parameters.AddWithValue("?", TbxAlamat.Text)
            cmd.Parameters.AddWithValue("?", TbxNoTelp.Text)
            cmd.Parameters.AddWithValue("?", TbxEmail.Text)


            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan!")

            TampilkanData()
            AutoID()
            LoadIDAnggota()
            ClearInput()

        Catch ex As Exception
            MsgBox("Error Simpan: " & ex.Message)
        Finally
            tutupKoneksi()
        End Try

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            bukaKoneksi()

            Dim sql As String =
            "UPDATE anggota SET nama_anggota=?,alamat=?, no_hp=?, email=? WHERE id_anggota=?"

            Dim cmd As New OdbcCommand(sql, conn)
            cmd.Parameters.AddWithValue("?", TbxNamaAnggota.Text)
            cmd.Parameters.AddWithValue("?", TbxAlamat.Text)
            cmd.Parameters.AddWithValue("?", TbxNoTelp.Text)
            cmd.Parameters.AddWithValue("?", TbxEmail.Text)
            cmd.Parameters.AddWithValue("?", CbIdAnggota.Text)

            cmd.ExecuteNonQuery()

            MsgBox("Data berhasil diperbarui!")
            TampilkanData()
            AutoID()
            ClearInput()

        Catch ex As Exception
            MsgBox("Error Edit: " & ex.Message)
        Finally
            tutupKoneksi()
        End Try

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Try
            bukaKoneksi()

            Dim sql As String = "DELETE FROM anggota WHERE id_anggota=?"
            Dim cmd As New OdbcCommand(sql, conn)

            cmd.Parameters.AddWithValue("?", CbIdAnggota.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Data berhasil dihapus!")
            TampilkanData()
            AutoID()
            ClearInput()

        Catch ex As Exception
            MsgBox("Error Hapus: " & ex.Message)
        Finally
            tutupKoneksi()
        End Try

    End Sub

    Private Sub DgAnggota_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgAnggota.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DgAnggota.Rows(e.RowIndex)

            CbIdAnggota.Text = row.Cells("id_anggota").Value.ToString()
            TbxNamaAnggota.Text = row.Cells("nama_anggota").Value.ToString()
            TbxAlamat.Text = row.Cells("alamat").Value.ToString()
            TbxNoTelp.Text = row.Cells("no_hp").Value.ToString()
            TbxEmail.Text = row.Cells("email").Value.ToString()
        End If

    End Sub

    Private Sub CbIdAnggota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbIdAnggota.SelectedIndexChanged
        Try
            bukaKoneksi()

            Dim cmd As New Odbc.OdbcCommand("SELECT * FROM anggota WHERE id_anggota=?", conn)
            cmd.Parameters.AddWithValue("?", CbIdAnggota.Text)

            Dim dr As Odbc.OdbcDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                TbxNamaAnggota.Text = dr("nama_anggota").ToString()
                TbxAlamat.Text = dr("alamat").ToString()
                TbxNoTelp.Text = dr("no_hp").ToString()
                TbxEmail.Text = dr("email").ToString()
            End If

            dr.Close()

        Catch ex As Exception
            MsgBox("Error tampil detail anggota: " & ex.Message)
        Finally
            tutupKoneksi()
        End Try
    End Sub

    Private Sub BtnKembaliAgt_Click(sender As Object, e As EventArgs) Handles BtnKembaliAgt.Click
        Me.Hide()
        MenuSimpanan.Show()
    End Sub
End Class