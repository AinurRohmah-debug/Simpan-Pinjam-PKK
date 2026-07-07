Imports System.Data.Odbc
Public Class LaporanAnggota
    Public idAnggotaValue As String

    Private Sub LaporanAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadIdAnggota()

    End Sub
    Sub LoadIdAnggota()
        Try
            bukaKoneksi()
            Dim cmd As New OdbcCommand("SELECT id_anggota FROM anggota", conn)
            Dim rd As OdbcDataReader = cmd.ExecuteReader()

            CbIdAnggotaLaporan.Items.Clear()

            While rd.Read()
                CbIdAnggotaLaporan.Items.Add(rd("id_anggota").ToString)
            End While

            rd.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CbIdAnggotaLaporan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbIdAnggotaLaporan.SelectedIndexChanged
        If CbIdAnggotaLaporan.SelectedIndex = -1 Then Exit Sub

        Try
            bukaKoneksi()
            Dim cmd As New OdbcCommand("SELECT nama_anggota FROM anggota WHERE id_anggota='" & CbIdAnggotaLaporan.Text & "'", conn)
            Dim rd As OdbcDataReader = cmd.ExecuteReader()

            If rd.Read() Then
                TbxNmAgtLaporan.Text = rd("nama_anggota").ToString()
            End If

            rd.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCetakLaporanAgt_Click(sender As Object, e As EventArgs) Handles BtnCetakLaporanAgt.Click
        If CbIdAnggotaLaporan.Text = "" Then
            MsgBox("Pilih ID anggota dulu!")
            Exit Sub
        End If

        GlobalVar.UserIdAnggota = CInt(CbIdAnggotaLaporan.Text)
        MsgBox("ID yg dikirim = " & GlobalVar.UserIdAnggota)
        CbIdAnggotaLaporan.SelectedIndex = -1
        TbxNmAgtLaporan.Clear()
        FormLaporanAnggota.Show()



    End Sub

    Private Sub BtnKembaliLaporanAgt_Click(sender As Object, e As EventArgs) Handles BtnLogoutLaporanAgt.Click
        CbIdAnggotaLaporan.SelectedIndex = -1
        TbxNmAgtLaporan.Clear()
        Me.Hide()
        MenuLogin.Show()
    End Sub


End Class