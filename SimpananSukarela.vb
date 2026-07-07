Imports System.Data.Odbc

Public Class SimpananSukarela

    Dim cmd As OdbcCommand
    Dim dr As OdbcDataReader

    Private Sub SimpananSukarela_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Nama_anggota()
        Tampilkan_IdSimpananSukarela()
        HitungTotalSaldo()
        TampilData()
        ClearInput()
    End Sub

    ' 1. Isi ComboBox Nama Anggota
    ' ===========================
    Sub Nama_anggota()
        Try
            bukaKoneksi()
            Dim query As String = "SELECT nama_anggota FROM anggota"
            cmd = New OdbcCommand(query, conn)
            dr = cmd.ExecuteReader()

            CbNamaAnggotaSK.Items.Clear()
            While dr.Read()
                CbNamaAnggotaSK.Items.Add(dr("nama_anggota").ToString())
            End While

        Catch ex As Exception
            MsgBox("Error saat ambil nama anggota: " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then dr.Close()
            tutupKoneksi()
        End Try
    End Sub
    Sub ClearInput()
        ' Hanya clear input yang diisi user
        TbxNominalSK.Clear()
        CbNamaAnggotaSK.SelectedIndex = -1
        TbxIdAnggotaSK.Clear()
        TbxSaldoSK.Clear()

        ' Kalau punya TextBox lain, tambahkan di sini
        ' TextBoxLain.Clear()
    End Sub

    Private Sub CbNamaAnggotaSK_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbNamaAnggotaSK.SelectedIndexChanged
        Try
            bukaKoneksi()
            Dim query As String = "SELECT id_anggota FROM anggota WHERE nama_anggota=?"
            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("?", CbNamaAnggotaSK.Text)

            dr = cmd.ExecuteReader()
            If dr.Read() Then
                TbxIdAnggotaSK.Text = dr("id_anggota").ToString()
            Else
                TbxIdAnggotaSK.Clear()
            End If

        Catch ex As Exception
            MsgBox("Error saat memilih anggota: " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso dr.IsClosed = False Then dr.Close()
            tutupKoneksi()
        End Try
    End Sub
    ' 3. Generate ID Simpanan Sukarela
    ' ===========================
    Private Sub Tampilkan_IdSimpananSukarela()
        Try
            bukaKoneksi()
            Dim query As String = "SELECT MAX(id_sukarela) FROM simpanansukarela"
            cmd = New OdbcCommand(query, conn)
            Dim result = cmd.ExecuteScalar()

            Dim nextID As Integer = If(IsDBNull(result) OrElse result Is Nothing, 1, CInt(result) + 1)
            TbxKdSimpananSK.Text = nextID.ToString()

        Catch ex As Exception
            MsgBox("Error saat membuat ID: " & ex.Message)
        Finally
            tutupKoneksi()
        End Try
    End Sub
    ' 4. Tampilkan data di DataGrid
    ' ===========================
    Sub TampilData()
        Try
            bukaKoneksi()
            Dim query As String = "SELECT * FROM simpanansukarela"
            Dim da As New OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            DgSimpananSK.DataSource = dt

        Catch ex As Exception
            MsgBox("Error saat tampil data: " & ex.Message)
        Finally
            tutupKoneksi()
        End Try
    End Sub

    Private Sub BtnSimpanSK_Click(sender As Object, e As EventArgs) Handles BtnSimpanSK.Click

        Try
            If CbNamaAnggotaSK.Text = "" Or TbxNominalSK.Text = "" Then
                MsgBox("Isi nama dan nominal dulu!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            bukaKoneksi()

            ' ==== Ambil ID Anggota ====
            Dim queryGetId As String =
        "SELECT id_anggota FROM anggota WHERE nama_anggota=?"

            cmd = New OdbcCommand(queryGetId, conn)
            cmd.Parameters.AddWithValue("?", CbNamaAnggotaSK.Text)

            Dim idAnggota = Convert.ToInt32(cmd.ExecuteScalar())


            ' ==== Ambil Saldo Terakhir ====
            Dim saldoLama As Decimal = 0
            Dim querySaldo As String =
        "SELECT saldo_sukarela FROM simpanansukarela 
         WHERE Anggota_id_anggota=? ORDER BY id_sukarela DESC LIMIT 1"

            cmd = New OdbcCommand(querySaldo, conn)
            cmd.Parameters.AddWithValue("?", idAnggota)

            Dim resultSaldo = cmd.ExecuteScalar()
            If resultSaldo IsNot Nothing AndAlso Not IsDBNull(resultSaldo) Then
                saldoLama = Convert.ToDecimal(resultSaldo)
            End If


            ' ==== Hitung Saldo Baru ====
            Dim nominalBaru As Decimal = Convert.ToDecimal(TbxNominalSK.Text)
            Dim saldoBaru As Decimal = saldoLama + nominalBaru


            ' ==== INSERT TRANSAKSI BARU ====
            Dim queryInsert As String =
        "INSERT INTO simpanansukarela 
        (id_sukarela, Anggota_id_anggota, nama_anggota, nominal_sukarela, saldo_sukarela, tanggal)
        VALUES (?,?,?,?,?,?)"

            cmd = New OdbcCommand(queryInsert, conn)
            cmd.Parameters.AddWithValue("?", TbxKdSimpananSK.Text)
            cmd.Parameters.AddWithValue("?", idAnggota)
            cmd.Parameters.AddWithValue("?", CbNamaAnggotaSK.Text)
            cmd.Parameters.AddWithValue("?", nominalBaru)
            cmd.Parameters.AddWithValue("?", saldoBaru)
            cmd.Parameters.AddWithValue("?", TanggalSimpananSK.Value)
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

    ' 6. Hitung total saldo
    ' ===========================
    Sub HitungTotalSaldo()
        Try
            bukaKoneksi()

            Dim query As String = "SELECT SUM(nominal_sukarela) FROM simpanansukarela"

            cmd = New OdbcCommand(query, conn)
            Dim result = cmd.ExecuteScalar()

            Dim total As Decimal = If(IsDBNull(result), 0, CDec(result))
            TbxSaldoSK.Text = String.Format("{0:N0}", total).Replace(",", ".")

        Catch ex As Exception
            MsgBox("Gagal menghitung total saldo: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then tutupKoneksi()
        End Try
    End Sub


    Private Sub BtnKembaliSK_Click(sender As Object, e As EventArgs) Handles BtnKembaliSK.Click
        TbxNominalSK.Clear()
        ClearInput()
        Me.Hide()
        MenuSimpanan.Show()
    End Sub


    Private Sub DgSimpananSK_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgSimpananSK.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DgSimpananSK.Rows(e.RowIndex)

            TbxKdSimpananSK.Text = row.Cells("id_sukarela").Value.ToString()
            CbNamaAnggotaSK.Text = row.Cells("nama_anggota").Value.ToString()
            TbxIdAnggotaSK.Text = row.Cells("Anggota_id_anggota").Value.ToString()
            TbxNominalSK.Text = row.Cells("nominal_sukarela").Value.ToString()
            TbxSaldoSK.Text = row.Cells("saldo_sukarela").Value.ToString()
        End If
    End Sub

    Private Sub BtnHapusSK_Click(sender As Object, e As EventArgs) Handles BtnHapusSK.Click
        Try
            bukaKoneksi()

            Dim sql As String = "DELETE FROM simpanansukarela WHERE id_sukarela=?"
            Dim cmd As New OdbcCommand(sql, conn)

            cmd.Parameters.AddWithValue("?", TbxKdSimpananSK.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Data berhasil dihapus!")
            TampilData()
            Tampilkan_IdSimpananSukarela()
            ClearInput()

        Catch ex As Exception
            MsgBox("Error Hapus: " & ex.Message)
        Finally
            tutupKoneksi()
        End Try
    End Sub

    Private Sub BtnCetakSK_Click(sender As Object, e As EventArgs) Handles BtnCetakSK.Click
        Try
            Dim ds As New DataSet
            Dim da As OdbcDataAdapter

            bukaKoneksi()

            ' --- AMBIL 1 TRANSAKSI SUKARELA BERDASARKAN ID ---
            Dim sql As String =
                "SELECT id_sukarela, Anggota_id_anggota, nama_anggota, nominal_sukarela, saldo_sukarela, tanggal " &
                "FROM simpanansukarela WHERE id_sukarela = ?"

            da = New OdbcDataAdapter(sql, conn)
            da.SelectCommand.Parameters.AddWithValue("?", TbxKdSimpananSK.Text)

            ' --- NAMA TABEL HARUS SESUAI DENGAN YANG ADA DI XSD & CR ---
            da.Fill(ds, "nota_sukarela")

            ' --- LOAD CRYSTAL REPORT ---
            Dim rpt As New CR_notasukarela
            rpt.SetDataSource(ds.Tables("nota_sukarela"))

            ' --- VIEWER POPUP ---
            Dim crv As New CrystalDecisions.Windows.Forms.CrystalReportViewer
            crv.ReportSource = rpt
            crv.Dock = DockStyle.Fill

            Dim frm As New Form
            frm.Text = "Struk Simpanan Sukarela"
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

    Private Sub BtnSelesaiSK_Click(sender As Object, e As EventArgs) Handles BtnSelesaiSK.Click
        Tampilkan_IdSimpananSukarela()
        TbxNominalSK.Clear()
        ClearInput()
    End Sub
End Class