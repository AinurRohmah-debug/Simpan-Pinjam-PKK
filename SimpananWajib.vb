Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports CrystalDecisions
Public Class SimpananWajib

    Dim cmd As OdbcCommand
    Dim dr As OdbcDataReader


    Private Sub SimpananWajib_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Nama_anggota()
        TampilData()
        Tampilkan_IdSimpananWajib()
        HitungTotalSaldo()
        ClearInput()
    End Sub
    Sub ClearInput()
        ' Hanya clear input yang diisi user
        TbxNominalWjb.Clear()
        CbNamaAnggota.SelectedIndex = -1
        TbxIdAnggota.Clear()
        TbxSaldoWjb.Clear()

        ' Kalau punya TextBox lain, tambahkan di sini
        ' TextBoxLain.Clear()
    End Sub

    ' 1. Isi ComboBox Nama Anggota
    ' ===========================
    Sub Nama_anggota()
        Try
            bukaKoneksi()
            Dim query As String = "SELECT nama_anggota FROM anggota"
            cmd = New OdbcCommand(query, conn)
            dr = cmd.ExecuteReader()

            CbNamaAnggota.Items.Clear()
            While dr.Read()
                CbNamaAnggota.Items.Add(dr("nama_anggota").ToString())
            End While

        Catch ex As Exception
            MsgBox("Error saat ambil nama anggota: " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            If conn.State = ConnectionState.Open Then tutupKoneksi()
        End Try
    End Sub

    Private Sub CbNamaAnggota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNamaAnggota.SelectedIndexChanged
        Try
            bukaKoneksi()
            Dim query As String = "SELECT id_anggota FROM anggota WHERE nama_anggota=?"

            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("?", CbNamaAnggota.Text)

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                TbxIdAnggota.Text = dr("id_anggota").ToString()
            Else
                TbxIdAnggota.Clear()
            End If

        Catch ex As Exception
            MsgBox("Error saat memilih anggota: " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            If conn.State = ConnectionState.Open Then tutupKoneksi()
        End Try
    End Sub
    ' 3. Tampilkan Data di DataGrid
    ' ===========================
    Sub TampilData()
        Try
            bukaKoneksi()
            Dim query As String = "SELECT * FROM simpananwajib"
            Dim da As New OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            DgSimpanWjb.DataSource = dt

        Catch ex As Exception
            MsgBox("Error saat tampil data: " & ex.Message)

        Finally
            If conn.State = ConnectionState.Open Then tutupKoneksi()
        End Try
    End Sub
    ' 4. Generate ID Otomatis
    ' ===========================
    Sub Tampilkan_IdSimpananWajib()
        Try
            bukaKoneksi()
            Dim query As String = "SELECT MAX(id_simpananwajib) FROM simpananwajib"
            cmd = New OdbcCommand(query, conn)
            Dim result = cmd.ExecuteScalar()

            Dim nextID As Integer = If(IsDBNull(result) OrElse result Is Nothing, 1, CInt(result) + 1)
            TbxKdSimpanWjb.Text = nextID.ToString()

        Catch ex As Exception
            MsgBox("Error saat membuat ID: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then tutupKoneksi()
        End Try
    End Sub

    Private Sub BtnSimpanWjb_Click(sender As Object, e As EventArgs) Handles BtnSimpanWjb.Click
        Try
            If CbNamaAnggota.Text = "" Or TbxNominalWjb.Text = "" Then
                MsgBox("Isi nama dan nominal dulu!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            bukaKoneksi()

            ' ==== Ambil ID Anggota ====
            Dim queryGetId As String =
        "SELECT id_anggota FROM anggota WHERE nama_anggota=?"

            cmd = New OdbcCommand(queryGetId, conn)
            cmd.Parameters.AddWithValue("?", CbNamaAnggota.Text)

            Dim idAnggota = Convert.ToInt32(cmd.ExecuteScalar())


            ' ==== Ambil Saldo Terakhir ====
            Dim saldoLama As Decimal = 0
            Dim querySaldo As String =
        "SELECT saldo_wajib FROM simpananwajib 
         WHERE Anggota_id_anggota=? ORDER BY id_simpananwajib DESC LIMIT 1"

            cmd = New OdbcCommand(querySaldo, conn)
            cmd.Parameters.AddWithValue("?", idAnggota)

            Dim resultSaldo = cmd.ExecuteScalar()
            If resultSaldo IsNot Nothing AndAlso Not IsDBNull(resultSaldo) Then
                saldoLama = Convert.ToDecimal(resultSaldo)
            End If
            ' ============================================
            ' === VALIDASI NOMINAL WAJIB TEPAT 10.000 ====
            ' ============================================
            Dim nominalBaru As Decimal
            If Not Decimal.TryParse(TbxNominalWjb.Text, nominalBaru) Then
                MsgBox("Nominal harus berupa angka!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If nominalBaru <> 10000D Then
                MsgBox("Nominal harus tepat 10.000!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            ' ============================================


            ' ==== Hitung Saldo Baru ====

            Dim saldoBaru As Decimal = saldoLama + nominalBaru


            ' ==== INSERT TRANSAKSI BARU ====
            Dim queryInsert As String =
        "INSERT INTO simpananwajib 
        (id_simpananwajib, Anggota_id_anggota, nama_anggota, nominal_wajib, saldo_wajib, tanggal)
        VALUES (?,?,?,?,?,?)"

            cmd = New OdbcCommand(queryInsert, conn)
            cmd.Parameters.AddWithValue("?", TbxKdSimpanWjb.Text)
            cmd.Parameters.AddWithValue("?", idAnggota)
            cmd.Parameters.AddWithValue("?", CbNamaAnggota.Text)
            cmd.Parameters.AddWithValue("?", nominalBaru)
            cmd.Parameters.AddWithValue("?", saldoBaru)
            cmd.Parameters.AddWithValue("?", TanggalSimpanWjb.Value)
            cmd.ExecuteNonQuery()

            MsgBox("Pembayaran berhasil dicatat!", MsgBoxStyle.Information)


            ' ==== Refresh ====
            TampilData()

            HitungTotalSaldo()



        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical)

        Finally
            tutupKoneksi()

        End Try



    End Sub
    Sub HitungTotalSaldo()
        Try
            bukaKoneksi()

            Dim query As String = "SELECT SUM(nominal_wajib) FROM simpananwajib"

            cmd = New OdbcCommand(query, conn)
            Dim result = cmd.ExecuteScalar()

            Dim total As Decimal = If(IsDBNull(result), 0, CDec(result))
            TbxSaldoWjb.Text = String.Format("{0:N0}", total).Replace(",", ".")

        Catch ex As Exception
            MsgBox("Gagal menghitung total saldo: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then tutupKoneksi()
        End Try
    End Sub





    Private Sub BtnKembaliwjb_Click(sender As Object, e As EventArgs) Handles BtnKembaliwjb.Click
        TbxNominalWjb.Clear()
        ClearInput()
        Me.Hide()
        MenuSimpanan.Show()
    End Sub

    Private Sub BtnHapusWajib_Click(sender As Object, e As EventArgs) Handles BtnHapusWajib.Click
        Try
            bukaKoneksi()

            Dim sql As String = "DELETE FROM simpananwajib WHERE id_simpananwajib=?"
            Dim cmd As New OdbcCommand(sql, conn)

            cmd.Parameters.AddWithValue("?", TbxKdSimpanWjb.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Data berhasil dihapus!")
            TampilData()
            Tampilkan_IdSimpananWajib()
            ClearInput()

        Catch ex As Exception
            MsgBox("Error Hapus: " & ex.Message)
        Finally
            tutupKoneksi()
        End Try
    End Sub

    Private Sub DgSimpanWjb_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgSimpanWjb.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DgSimpanWjb.Rows(e.RowIndex)

            TbxKdSimpanWjb.Text = row.Cells("id_simpananwajib").Value.ToString()
            CbNamaAnggota.Text = row.Cells("nama_anggota").Value.ToString()
            TbxIdAnggota.Text = row.Cells("Anggota_id_anggota").Value.ToString()
            TbxNominalWjb.Text = row.Cells("nominal_wajib").Value.ToString()
            TbxSaldoWjb.Text = row.Cells("saldo_wajib").Value.ToString()
        End If
    End Sub

    Private Sub BtnCetakWajb_Click(sender As Object, e As EventArgs) Handles BtnCetakWajb.Click
        Try
            Dim ds As New DataSet
            Dim da As OdbcDataAdapter

            bukaKoneksi()

            ' AMBIL SATU DATA TRANSAKSI TERBARU BERDASARKAN ID
            Dim sql As String =
            "SELECT id_simpananwajib, Anggota_id_anggota, nama_anggota, nominal_wajib, saldo_wajib, tanggal " &
            "FROM simpananwajib WHERE id_simpananwajib = ?"

            da = New OdbcDataAdapter(sql, conn)
            da.SelectCommand.Parameters.AddWithValue("?", TbxKdSimpanWjb.Text)

            da.Fill(ds, "nota_simpanan")   ' 🟢 NAMA TABEL HARUS SAMA DENGAN DI CRYSTAL REPORT

            ' LOAD REPORT CrystalReport2.rpt
            Dim rpt As New CR_NotaWajib
            rpt.SetDataSource(ds.Tables("nota_simpanan"))

            ' TAMPILKAN DI POPUP VIEWER
            Dim crv As New CrystalDecisions.Windows.Forms.CrystalReportViewer
            crv.ReportSource = rpt
            crv.Dock = DockStyle.Fill

            Dim frm As New Form
            frm.Text = "Nota Simpanan Wajib"
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

    Private Sub BtnSelesaiWajib_Click(sender As Object, e As EventArgs) Handles BtnSelesaiWajib.Click
        Tampilkan_IdSimpananWajib()
        TbxNominalWjb.Clear()
        ClearInput()
    End Sub
End Class