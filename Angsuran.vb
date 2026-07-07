Imports System.Data.Odbc

Public Class Angsuran


    Private Sub Angsuran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoIDAngsuran()
        Nama_anggota()
        ClearInput()
        CbIdPinjaman.Items.Clear()
        CbIdPinjaman.SelectedIndex = -1

    End Sub
    Sub ClearInput()


        TbxNmlCicilanPinjam.Clear()
        TbxNmlPinjam.Clear()
        CbNmAgtAngsuran.SelectedIndex = -1
        CbIdPinjaman.SelectedIndex = -1
        CbIdPinjaman.Items.Clear()
        TbxIdAgtAngsuran.Clear()
        TbxCicilan.Clear()
        TbxSisaPinjam.Clear()
        TbxNominalAngsuran.Clear()
        TbxSisaBayar.Clear()


    End Sub

    Private Sub AutoIDAngsuran()

        Try
            bukaKoneksi()
            Dim query As String = "SELECT MAX(id_angsuran) FROM angsuran"
            cmd = New OdbcCommand(query, conn)
            Dim result = cmd.ExecuteScalar()

            Dim nextID As Integer = If(IsDBNull(result) OrElse result Is Nothing, 1, CInt(result) + 1)
            TbxKdAngsuran.Text = nextID.ToString()

        Catch ex As Exception
            MsgBox("Error saat membuat ID: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then tutupKoneksi()
        End Try

    End Sub
    ' 1. Isi ComboBox Nama Anggota
    ' ===========================
    Sub Nama_anggota()
        Try
            bukaKoneksi()
            Dim query As String = "SELECT nama_anggota FROM anggota"
            cmd = New OdbcCommand(query, conn)
            dr = cmd.ExecuteReader()

            CbNmAgtAngsuran.Items.Clear()
            While dr.Read()
                CbNmAgtAngsuran.Items.Add(dr("nama_anggota").ToString())
            End While

        Catch ex As Exception
            MsgBox("Error saat ambil nama anggota: " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            If conn.State = ConnectionState.Open Then tutupKoneksi()
        End Try
    End Sub

    Private Sub CbNmAgtAngsuran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNmAgtAngsuran.SelectedIndexChanged


        Try
            bukaKoneksi()

            Dim sql As String = "SELECT id_anggota FROM anggota WHERE nama_anggota=?"
            Dim cmd As New OdbcCommand(sql, conn)
            cmd.Parameters.AddWithValue("@nama", CbNmAgtAngsuran.Text)

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                TbxIdAgtAngsuran.Text = dr("id_anggota").ToString()
            End If
            'ISI LIST KODE PINJAMAN
            LoadPinjaman()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            tutupKoneksi()
        End Try
    End Sub
    Private Sub LoadPinjaman()

        ' Jika ID Anggota kosong, hapus saja isi combo dan keluar
        If String.IsNullOrWhiteSpace(TbxIdAgtAngsuran.Text) Then
            CbIdPinjaman.Items.Clear()
            Exit Sub
        End If

        Try
            bukaKoneksi()

            Dim sql As String = "SELECT id_simpanpinjam FROM simpanpinjam WHERE id_anggota=? AND sisa_pinjam > 0"
            Dim cmd As New OdbcCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", TbxIdAgtAngsuran.Text)

            dr = cmd.ExecuteReader()

            CbIdPinjaman.Items.Clear()

            While dr.Read()
                CbIdPinjaman.Items.Add(dr("id_simpanpinjam").ToString())
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            tutupKoneksi()
        End Try

    End Sub


    Private Sub CbIdPinjaman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbIdPinjaman.SelectedIndexChanged
        Try
            bukaKoneksi()

            Dim sql As String = "SELECT nominal_pinjam, cicilan_per_bulan, sisa_pinjam 
                             FROM simpanpinjam WHERE id_simpanpinjam=?"

            Dim cmd As New OdbcCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", CbIdPinjaman.Text)

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                Dim nominal As Long = CLng(dr("nominal_pinjam"))
                Dim cicilan As Long = CLng(dr("cicilan_per_bulan"))
                Dim sisa As Long = CLng(dr("sisa_pinjam"))

                TbxNmlPinjam.Text = nominal.ToString("N0")
                TbxNmlCicilanPinjam.Text = cicilan.ToString("N0")   ' <<< FORMAT 250.000
                TbxSisaPinjam.Text = sisa.ToString("N0")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            tutupKoneksi()
        End Try

        HitungCicilanKe()
        TampilDataAngsuran()
    End Sub
    Private Sub HitungCicilanKe()
        Try
            bukaKoneksi()

            Dim sql As String = "SELECT COUNT(*)+1 AS cicilan_ke FROM angsuran WHERE id_simpanpinjam=?"
            Dim cmd As New OdbcCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", CbIdPinjaman.Text)

            dr = cmd.ExecuteReader()

            If dr.Read() Then
                TbxCicilan.Text = dr("cicilan_ke").ToString()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            tutupKoneksi()
        End Try
    End Sub

    Private Sub BtnSimpanAngsuran_Click(sender As Object, e As EventArgs) Handles BtnSimpanAngsuran.Click
        ' Validasi sederhana
        If CbIdPinjaman.Text = "" Or TbxIdAgtAngsuran.Text = "" Then
            MessageBox.Show("Pilih kode pinjaman dan anggota dulu.")
            Exit Sub
        End If

        ' Ambil angka tanpa format ribuan
        Dim sisaPinjam As Long = 0
        Dim nominalAngsuran As Long = 0
        Try
            ' bersihkan teks ribuan jika ada (mis "1,000" -> "1000")
            Dim sisaText = TbxSisaPinjam.Text.Replace(",", "").Trim()
            Dim nomAngsText = TbxNominalAngsuran.Text.Replace(",", "").Trim()

            sisaPinjam = CLng(If(sisaText = "", "0", sisaText))
            nominalAngsuran = CLng(If(nomAngsText = "", "0", nomAngsText))
        Catch ex As Exception
            MessageBox.Show("Format angka tidak valid: " & ex.Message)
            Exit Sub
        End Try

        ' Hitung sisa baru
        Dim sisaBaru As Long = sisaPinjam - nominalAngsuran
        If sisaBaru < 0 Then sisaBaru = 0 ' tidak boleh negatif

        ' Tampilkan di textbox supaya user melihat
        TbxSisaBayar.Text = sisaBaru.ToString()

        Try
            bukaKoneksi()

            ' === INSERT ke tabel angsuran (id_angsuran auto increment) ===
            Dim sqlInsert As String =
            "INSERT INTO angsuran (id_simpanpinjam, tanggal_angsuran, nominal_angsuran, cicilan_ke, sisa_setelah_bayar) " &
            "VALUES (?, ?, ?, ?, ?)"

            Dim cmdIns As New Odbc.OdbcCommand(sqlInsert, conn)

            ' PENTING: tambahkan parameter sesuai urutan '?' di SQL
            cmdIns.Parameters.AddWithValue("@p1", CbIdPinjaman.Text)                       ' id_simpanpinjam
            cmdIns.Parameters.AddWithValue("@p2", TanggalAngsuran.Value.ToString) ' tanggal_angsuran
            cmdIns.Parameters.AddWithValue("@p3", nominalAngsuran)                           ' nominal_angsuran
            cmdIns.Parameters.AddWithValue("@p4", CLng(TbxCicilan.Text))                   ' cicilan_ke
            cmdIns.Parameters.AddWithValue("@p5", sisaBaru)                                  ' sisa_setelah_bayar

            cmdIns.ExecuteNonQuery()

            ' === UPDATE sisa_pinjam di tabel simpanpinjam ===
            Dim statusPinjam As String = If(sisaBaru = 0, "LUNAS", "BELUM LUNAS")

            Dim sqlUpd As String = "UPDATE simpanpinjam SET sisa_pinjam = ?, status = ? WHERE id_simpanpinjam = ?"
            Dim cmdUpd As New Odbc.OdbcCommand(sqlUpd, conn)
            cmdUpd.Parameters.AddWithValue("@p1", sisaBaru)
            cmdUpd.Parameters.AddWithValue("@p2", statusPinjam)
            cmdUpd.Parameters.AddWithValue("@p3", CbIdPinjaman.Text)
            cmdUpd.ExecuteNonQuery()

            MessageBox.Show("Angsuran tersimpan. Sisa sekarang: " & sisaBaru.ToString("N0"))

            ' Refresh DataGridView (panggil fungsi yang sudah ada)
            TampilDataAngsuran()




        Catch ex As Exception
            MessageBox.Show("Error saat simpan angsuran: " & ex.Message)
        Finally
            tutupKoneksi()
        End Try
    End Sub
    Sub TampilDataAngsuran()
        Try
            bukaKoneksi()

            Dim sql As String =
            "SELECT id_angsuran, id_simpanpinjam, tanggal_angsuran, 
                    nominal_angsuran, cicilan_ke, sisa_setelah_bayar
             FROM angsuran 
             WHERE id_simpanpinjam = ? 
             ORDER BY cicilan_ke ASC"

            Dim da As New OdbcDataAdapter(sql, conn)
            da.SelectCommand.Parameters.AddWithValue("@id_simpanpinjam", CbIdPinjaman.Text)

            Dim dt As New DataTable
            da.Fill(dt)

            DgAngsuran.DataSource = dt

        Catch ex As Exception
            MsgBox("Gagal menampilkan data: " & ex.Message)
        Finally
            tutupKoneksi()
        End Try
    End Sub

    Private Sub BtnKembaliAngsuran_Click(sender As Object, e As EventArgs) Handles BtnKembaliAngsuran.Click
        ' Bersihkan ComboBox Pinjaman
        CbIdPinjaman.Items.Clear()
        CbIdPinjaman.Text = ""
        CbIdPinjaman.SelectedIndex = -1

        ' Hapus isi DataGridView
        DgAngsuran.DataSource = Nothing
        DgAngsuran.Rows.Clear()

        ClearInput()

        Me.Hide()
        MenuSimpanan.Show()
    End Sub

    Private Sub DgAngsuran_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgAngsuran.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DgAngsuran.Rows(e.RowIndex)

            TbxKdAngsuran.Text = row.Cells("id_angsuran").Value.ToString()
            CbIdPinjaman.Text = row.Cells("id_simpanpinjam").Value.ToString()
            TbxNominalAngsuran.Text = row.Cells("nominal_angsuran").Value.ToString()
            TbxCicilan.Text = row.Cells("cicilan_ke").Value.ToString()



        End If
    End Sub

    Private Sub BtnCetakAngsuran_Click(sender As Object, e As EventArgs) Handles BtnCetakAngsuran.Click
        Try
            Dim ds As New DataSet
            Dim da As OdbcDataAdapter

            bukaKoneksi()

            ' --- AMBIL 1 DATA ANGSURAN BERDASARKAN ID ---
            Dim sql As String =
        "SELECT id_angsuran, id_simpanpinjam,nominal_angsuran,cicilan_ke, tanggal_angsuran " &
        "FROM angsuran WHERE id_angsuran = ?"

            da = New OdbcDataAdapter(sql, conn)
            da.SelectCommand.Parameters.AddWithValue("?", TbxKdAngsuran.Text)

            ' --- NAMA TABEL HARUS SAMA DENGAN YANG ADA DI XSD & CR ---
            da.Fill(ds, "nota_angsuran")

            ' --- LOAD CRYSTAL REPORT ---
            Dim rpt As New CR_angsuran
            rpt.SetDataSource(ds.Tables("nota_angsuran"))

            ' --- VIEWER POPUP ---
            Dim crv As New CrystalDecisions.Windows.Forms.CrystalReportViewer
            crv.ReportSource = rpt
            crv.Dock = DockStyle.Fill

            Dim frm As New Form
            frm.Text = "Struk Angsuran Pinjaman"
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
    Private Sub FormatRibuan(sender As Object, e As EventArgs) _
    Handles TbxNominalAngsuran.LostFocus, TbxNmlPinjam.LostFocus,
            TbxNmlCicilanPinjam.LostFocus, TbxSisaPinjam.LostFocus

        Dim tb As TextBox = CType(sender, TextBox)
        Dim angka As Decimal

        If Decimal.TryParse(tb.Text.Replace(",", "").Replace(".", ""), angka) Then
            tb.Text = angka.ToString("N0")
        End If
    End Sub

    Private Sub BtnHapusAngsuran_Click(sender As Object, e As EventArgs) Handles BtnHapusAngsuran.Click
        Try
            bukaKoneksi()

            Dim sql As String = "DELETE FROM angsuran WHERE id_angsuran =?"
            Dim cmd As New OdbcCommand(sql, conn)

            cmd.Parameters.AddWithValue("?", TbxKdAngsuran.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Data berhasil dihapus!")
            TampilDataAngsuran()
            AutoIDAngsuran()
            ClearInput()
            CbIdPinjaman.Items.Clear()
            CbIdPinjaman.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("Error Hapus: " & ex.Message)
        Finally
            tutupKoneksi()
        End Try
    End Sub

    Private Sub BtnSelesaiAngsuran_Click(sender As Object, e As EventArgs) Handles BtnSelesaiAngsuran.Click
        AutoIDAngsuran()
        ' Bersihkan ComboBox Pinjaman
        CbIdPinjaman.Items.Clear()
        CbIdPinjaman.Text = ""
        CbIdPinjaman.SelectedIndex = -1

        ' Hapus isi DataGridView
        DgAngsuran.DataSource = Nothing
        DgAngsuran.Rows.Clear()

        ClearInput()
    End Sub
End Class