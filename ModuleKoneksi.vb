Imports System.Data.Odbc
Module ModuleKoneksi
    Public conn As OdbcConnection
    Public cmd As OdbcCommand
    Public dr As OdbcDataReader



    Public Sub bukaKoneksi()
        Try
            If conn Is Nothing Then
                conn = New OdbcConnection("DSN=PKKkoneksi;UID=root;PWD=ainur123;")
            End If

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Public Sub tutupKoneksi()
        Try
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat menutup koneksi: " & ex.Message)
        End Try
    End Sub

End Module
