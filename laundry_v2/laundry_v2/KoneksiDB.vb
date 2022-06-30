
'import koneksi database
Imports MySql.Data.MySqlClient
Module KoneksiDB
    'buat variable umum untuk koneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public ds As DataSet

    'buat sub umum koneksi database
    Sub koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=db_laundryv2;")
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("Koneksi Database Gagal")
        End Try
    End Sub
End Module
