
Imports MySql.Data.MySqlClient
Public Class DataLaundry

    'form load data laundry
    Private Sub DataLaundry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilData()
        Call autoGrid()
    End Sub

    'radio button nama pelanggan
    Private Sub RadioButton_nama_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_nama.CheckedChanged
        Text_nama.Enabled = True
        Text_nama.Focus()
        Text_faktur.Enabled = False
    End Sub

    'radio button faktur
    Private Sub RadioButton_faktur_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_faktur.CheckedChanged
        Text_nama.Enabled = False
        Text_faktur.Focus()
        Text_faktur.Enabled = True
    End Sub

    'pencarian data berdasarkan textbox nama konsumen
    Private Sub Text_nama_TextChanged(sender As Object, e As EventArgs) Handles Text_nama.TextChanged
        Call koneksi()
        cmd = New MySqlCommand("SELECT * FROM data_laundry WHERE nama_pelanggan LIKE '%" & Text_nama.Text & "%'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Call koneksi()
            da = New MySqlDataAdapter("SELECT * FROM data_laundry WHERE nama_pelanggan LIKE '%" & Text_nama.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("data tidak ditemukan")
        End If
    End Sub

    'pencarian data berdasarkan faktur
    Private Sub Text_faktur_TextChanged(sender As Object, e As EventArgs) Handles Text_faktur.TextChanged
        Call koneksi()
        cmd = New MySqlCommand("SELECT * FROM data_laundry WHERE faktur LIKE '%" & Text_faktur.Text & "%'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Call koneksi()
            da = New MySqlDataAdapter("SELECT * FROM data_laundry WHERE faktur LIKE '%" & Text_faktur.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("data tidak ditemukan")
        End If
    End Sub

    'tampil data
    Sub tampilData()
        Call koneksi()
        da = New MySqlDataAdapter("SELECT * FROM data_laundry", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "data_laundry")
        DataGridView1.DataSource = ds.Tables("data_laundry")
    End Sub

    'sub keadaan awal
    Sub keadaanAwal()
        Text_nama.Text = ""
        Text_faktur.Text = ""
    End Sub

    'btn refresh
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        tampilData()
        keadaanAwal()
    End Sub

    'btn close
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
        MenuUtama.Show()
    End Sub

    'lebar columns datagridview
    Sub autoGrid()
        DataGridView1.Columns(0).Width = 160
        DataGridView1.Columns(1).Width = 180
        DataGridView1.Columns(2).Width = 160
        DataGridView1.Columns(3).Width = 160
        DataGridView1.Columns(4).Width = 160
        DataGridView1.Columns(5).Width = 160
        DataGridView1.Columns(6).Width = 160
        DataGridView1.Columns(7).Width = 160
    End Sub

    'btn penyerahan cucian
    Private Sub btn_penyerahanCucian_Click(sender As Object, e As EventArgs) Handles btn_penyerahanCucian.Click
        Me.Close()
        PenyerahanCucian.Show()
    End Sub

    'btn pengembalian cucian
    Private Sub btn_pengembalianCucian_Click(sender As Object, e As EventArgs) Handles btn_pengembalianCucian.Click
        Me.Close()
        PengembalianCucian.Show()
    End Sub

    'hubungkan ke crystal report
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        laporanDataLaundry.Show()
    End Sub
End Class