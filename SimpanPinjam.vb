Imports System.Data.Odbc
Imports System.Data.SqlClient

Public Class SimpanPinjam


    Private Sub SimpanPinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoKodePinjaman()
        TampilData()
        LoadNamaAnggota()
        ClearInput()

    End Sub
    Sub ClearInput()
        ' Hanya clear input yang diisi user
        TbxNominalPinjam.Clear()
        CbNmAgtPinjam.SelectedIndex = -1
        TbxIdAgtPinjam.Clear()
        TbxJmlCicilan.Clear()
        TbxTotalPinjam.Clear()

        ' Kalau punya TextBox lain, tambahkan di sini
        ' TextBoxLain.Clear()
    End Sub
    Sub AutoKodePinjaman()
        bukaKoneksi()

        Dim kode As String
        Dim urut As String
        Dim hitung As Integer

        cmd = New OdbcCommand("SELECT id_simpanpinjam FROM simpanpinjam ORDER BY id_simpanpinjam DESC LIMIT 1", conn)
        dr = cmd.ExecuteReader()
        dr.Read()

        If Not dr.HasRows Then
            kode = "PJM001"
        Else
            hitung = Val(Mid(dr.Item("id_simpanpinjam").ToString, 4)) + 1
            urut = Format(hitung, "000")
            kode = "PJM" & urut
        End If

        TbxKdPinjam.Text = kode

        dr.Close()
        tutupKoneksi()
    End Sub
    Sub LoadNamaAnggota()
        Try
            bukaKoneksi()
            Dim query As String = "SELECT DISTINCT a.nama_anggota FROM anggota a 
                                    JOIN simpananwajib sw ON sw.Anggota_id_anggota = a.id_anggota
                                    WHERE sw.nominal_wajib > 0"
            cmd = New OdbcCommand(query, conn)
            dr = cmd.ExecuteReader()

            CbNmAgtPinjam.Items.Clear()
            While dr.Read()
                CbNmAgtPinjam.Items.Add(dr("nama_anggota").ToString())
            End While

        Catch ex As Exception
            MsgBox("Error saat ambil nama anggota: " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            If conn.State = ConnectionState.Open Then tutupKoneksi()
        End Try
    End Sub

    Private Sub CbNmAgtPinjam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNmAgtPinjam.SelectedIndexChanged
        Try
            bukaKoneksi()
            Dim query As String = "SELECT id_anggota FROM anggota WHERE nama_anggota=?"

            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("?", CbNmAgtPinjam.Text)

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                TbxIdAgtPinjam.Text = dr("id_anggota").ToString()
            Else
                TbxIdAgtPinjam.Clear()
            End If

        Catch ex As Exception
            MsgBox("Error saat memilih anggota: " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            If conn.State = ConnectionState.Open Then tutupKoneksi()
        End Try
    End Sub
    '3. Tampilkan Data di DataGrid'
    ' ===========================
    Sub TampilData()
        Try
            bukaKoneksi()
            Dim query As String = "SELECT * FROM simpanpinjam"
            Dim da As New OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            DgSimpanPinjam.DataSource = dt

        Catch ex As Exception
            MsgBox("Error saat tampil data: " & ex.Message)

        Finally
            If conn.State = ConnectionState.Open Then tutupKoneksi()
        End Try
    End Sub

    Private Sub BtnSimpanPinjam_Click(sender As Object, e As EventArgs) Handles BtnSimpanPinjam.Click

        If TbxKdPinjam.Text = "" Or TbxJmlCicilan.Text = "" Or TbxNominalPinjam.Text = "" Then
            MsgBox("Semua data harus diisi!", vbExclamation)
            Exit Sub
        End If

        Try
            bukaKoneksi()

            Dim sql As String = "INSERT INTO simpanpinjam 
        (id_simpanpinjam, id_anggota, tanggal_pinjam, nominal_pinjam, cicilan_per_bulan, sisa_pinjam) 
        VALUES (?, ?, ?, ?, ?, ?)"

            cmd = New OdbcCommand(sql, conn)
            cmd.Parameters.AddWithValue("@p1", TbxKdPinjam.Text)
            cmd.Parameters.AddWithValue("@p2", TbxIdAgtPinjam.Text)
            cmd.Parameters.AddWithValue("@p3", Format(TanggalPinjam.Value))
            cmd.Parameters.AddWithValue("@p4", Decimal.Parse(TbxNominalPinjam.Text, Globalization.NumberStyles.Any))
            cmd.Parameters.AddWithValue("@p5", CDec(TbxJmlCicilan.Text.Replace(".", "").Replace(",", "")))

            cmd.Parameters.AddWithValue("@p6", Val(TbxNominalPinjam.Text)) 'sisa awal = nominal pinjam

            cmd.ExecuteNonQuery()

            MsgBox("Data pinjaman berhasil disimpan!", vbInformation)

            tutupKoneksi()
            'Tampilkan ulang tabel + total
            TampilData()
            HitungTotalPinjaman()




        Catch ex As Exception
            MsgBox("Error simpan: " & ex.Message)
        End Try

    End Sub

    Sub HitungTotalPinjaman()
        bukaKoneksi()

        Dim sql As String = "SELECT SUM(sisa_pinjam) AS sisa_pinjam
                         FROM simpanpinjam 
                         WHERE id_anggota = '" & TbxIdAgtPinjam.Text & "'"

        cmd = New OdbcCommand(sql, conn)
        dr = cmd.ExecuteReader()
        dr.Read()

        If dr.HasRows AndAlso Not IsDBNull(dr("sisa_pinjam")) Then
            TbxTotalPinjam.Text = dr("sisa_pinjam").ToString()
        Else
            TbxTotalPinjam.Text = "0"
        End If

        dr.Close()
        tutupKoneksi()
    End Sub

    Private Sub HitungCicilan()
        If TbxNominalPinjam.Text = "" Then
            TbxJmlCicilan.Text = ""
            Exit Sub
        End If

        Dim nominal As Decimal

        ' Hapus tanda titik/koma formatting
        If Decimal.TryParse(TbxNominalPinjam.Text.Replace(".", "").Replace(",", ""), nominal) Then
            Dim cicilan As Decimal = nominal / 4
            TbxJmlCicilan.Text = cicilan.ToString("N0")  ' tampil 250000 jadi 250.000
        End If
    End Sub





    Private Sub BtnKembaliPinjam_Click(sender As Object, e As EventArgs) Handles BtnKembaliPinjam.Click
        TbxNominalPinjam.Clear()
        ClearInput()
        Me.Hide()
        MenuSimpanan.Show()
    End Sub

    Private Sub DgSimpanPinjam_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgSimpanPinjam.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DgSimpanPinjam.Rows(e.RowIndex)

            TbxKdPinjam.Text = row.Cells("id_simpanpinjam").Value.ToString()
            TbxIdAgtPinjam.Text = row.Cells("id_anggota").Value.ToString()
            TbxNominalPinjam.Text = row.Cells("nominal_pinjam").Value.ToString()
            TbxJmlCicilan.Text = row.Cells("cicilan_per_bulan").Value.ToString()

        End If
    End Sub

    Private Sub BtnCetakPinjam_Click(sender As Object, e As EventArgs) Handles BtnCetakPinjam.Click
        Try
            Dim ds As New DataSet
            Dim da As OdbcDataAdapter

            bukaKoneksi()

            ' --- AMBIL 1 TRANSAKSI PINJAMAN BERDASARKAN ID ---
            Dim sql As String =
        "SELECT id_simpanpinjam, id_anggota, nominal_pinjam, cicilan_per_bulan, tanggal_pinjam " &
        "FROM simpanpinjam WHERE id_simpanpinjam = ?"

            da = New OdbcDataAdapter(sql, conn)
            da.SelectCommand.Parameters.AddWithValue("?", TbxKdPinjam.Text)

            ' --- NAMA TABEL HARUS SAMA DENGAN DATASET XSD ---
            da.Fill(ds, "nota_pinjaman")

            ' --- LOAD CRYSTAL REPORT ---
            Dim rpt As New CR_pinjaman
            rpt.SetDataSource(ds.Tables("nota_pinjaman"))

            ' --- VIEWER POPUP ---
            Dim crv As New CrystalDecisions.Windows.Forms.CrystalReportViewer
            crv.ReportSource = rpt
            crv.Dock = DockStyle.Fill

            Dim frm As New Form
            frm.Text = "Struk Pinjaman"
            frm.WindowState = FormWindowState.Normal
            frm.Size = New Size(500, 700)
            frm.Controls.Add(crv)
            frm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan nota: " & ex.Message)
        Finally
            tutupKoneksi()
        End Try

    End Sub

    Private Sub TbxNominalPinjam_TextChanged(sender As Object, e As EventArgs) Handles TbxNominalPinjam.TextChanged
        HitungCicilan()
    End Sub

    Private Sub BtnHapusPinjaman_Click(sender As Object, e As EventArgs)
        Try
            bukaKoneksi()

            Dim sql As String = "DELETE FROM simpanpinjam WHERE id_simpanpinjam =?"
            Dim cmd As New OdbcCommand(sql, conn)

            cmd.Parameters.AddWithValue("?", TbxKdPinjam.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Data berhasil dihapus!")
            TampilData()
            AutoKodePinjaman()
            ClearInput()

        Catch ex As Exception
            MsgBox("Error Hapus: " & ex.Message)
        Finally
            tutupKoneksi()
        End Try
    End Sub

    Private Sub BtnSelesaiPinjaman_Click(sender As Object, e As EventArgs) Handles BtnSelesaiPinjaman.Click
        AutoKodePinjaman()
        TbxNominalPinjam.Clear()
        ClearInput()
    End Sub
End Class