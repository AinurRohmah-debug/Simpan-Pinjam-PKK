Imports System.Data.Odbc

Public Class MenuLogin
    Dim conn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim dr As OdbcDataReader

    Private Sub BtnBendahara_Click(sender As Object, e As EventArgs) Handles BtnBendahara.Click
        Me.Hide()
        LoginBendahara.Show()
    End Sub

    Private Sub BtnPengawas_Click(sender As Object, e As EventArgs) Handles BtnPengawas.Click
        Me.Hide()
        LoginPengawas.Show()
    End Sub

    Private Sub BtnAnggota_Click(sender As Object, e As EventArgs) Handles BtnAnggota.Click
        Me.Hide()
        LoginAnggota.Show()
    End Sub

    Private Sub MenuLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
