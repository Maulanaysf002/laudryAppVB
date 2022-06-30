

Imports MySql.Data.MySqlClient
Public Class Login

    'form login load
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label_tanggal.Text = Now.Date
    End Sub

    'sub keadaan awal
    Sub keadaanAwal()
        Textusername.Text = ""
        Textpassword.Text = ""
        btn_login.Text = "Login"
        btn_exit.Text = "Exit"
    End Sub

    'button login ditekan
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Call koneksi()
        Dim login As String = "SELECT * FROM users WHERE username ='" & Textusername.Text & "' AND password ='" & Textpassword.Text & "' "
        cmd = New MySqlCommand(login, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Textusername.Text = "" Or Textpassword.Text = "" Then
            MsgBox("Isi Data Login Terlebih Dahulu")
        Else
            If dr.HasRows = 0 Then
                MsgBox("USERNAME dan PASSWORD salah!!!")
            Else
                Me.Hide()
                MenuUtama.Show()
            End If
        End If
        Call keadaanAwal()
    End Sub

    'btn exit
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
End Class
