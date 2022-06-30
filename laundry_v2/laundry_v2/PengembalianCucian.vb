
Imports MySql.Data.MySqlClient
Public Class PengembalianCucian

    'form load data pengembalian cucian
    Private Sub PengembalianCucian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        keadaanAwal()
        autoGrid()
    End Sub

    'keadaan awal 
    Sub keadaanAwal()
        Text_nama.Text = ""
        Text_berat.Text = ""
        Text_harga.Text = ""
        Text_panjar.Text = ""
        Combo_keterangan.Text = ""
        Text_sisa.Text = ""
        Combo_status.Text = ""
        Call koneksi()
        da = New MySqlDataAdapter("SELECT * FROM data_laundry_selesai", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "data_laundry_selesai")
        DataGridView1.DataSource = ds.Tables("data_laundry_selesai")
    End Sub

    'sub cek faktur
    Sub cekFaktur()
        Call koneksi()
        cmd = New MySqlCommand("SELECT * FROM data_laundry WHERE faktur LIKE '%" & Text_faktur.Text & "%'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Text_nama.Text = dr.Item("nama_pelanggan")
            Text_berat.Text = dr.Item("berat_cucian")
            Text_harga.Text = dr.Item("harga")
            Text_panjar.Text = dr.Item("panjar")
            Combo_keterangan.Text = dr.Item("keterangan")
            Text_sisa.Text = dr.Item("sisa_tagihan")
        Else
            MsgBox("data faktur tidak tersedia!", MsgBoxStyle.Critical)
        End If
    End Sub

    'sub cek nama
    Sub cekNama()
        Call koneksi()
        cmd = New MySqlCommand("SELECT * FROM data_laundry WHERE nama_pelanggan LIKE '%" & Text_nama.Text & "%'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Text_faktur.Text = dr.Item("faktur")
            Text_berat.Text = dr.Item("berat_cucian(Kg)")
            Text_harga.Text = dr.Item("harga")
            Text_panjar.Text = dr.Item("panjar")
            Combo_keterangan.Text = dr.Item("keterangan")
            Text_sisa.Text = dr.Item("sisa_tagihan")
        Else
            MsgBox("data faktur tidak tersedia!", MsgBoxStyle.Critical)
        End If
    End Sub

    'jika user menekan enter maka cek faktur jalan
    Private Sub Text_faktur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_faktur.KeyPress
        If e.KeyChar = Chr(13) Then
            cekFaktur()
        End If
    End Sub

    'jika user menekan enter maka cek nama jalan
    Private Sub Text_nama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_nama.KeyPress
        If e.KeyChar = Chr(13) Then
            cekNama()
        End If
    End Sub

    'jika user menekan enter maka cek combo box keterangan jalan
    Private Sub combo_keterangan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_nama.KeyPress
        If e.KeyChar = Chr(13) Then
            If Text_faktur.Text = "" Or Text_nama.Text = "" Or Text_berat.Text = "" Then
                MsgBox("isi faktur terlebih dahulu")
            Else
                If Combo_keterangan.Text = "Lunas" Then
                    Text_sisa.Text = "0"
                    btn_simpan.Enabled = True
                    Combo_status.Text = "selesai"
                ElseIf Combo_keterangan.Text = "Belum Lunas" Then
                    Text_sisa.Text = Val(Text_harga.Text) - Val(Text_panjar.Text)
                    btn_simpan.Enabled = False
                    Combo_status.Text = "belum selesai"
                End If
            End If
        End If
    End Sub

    'combo keterangan leave
    Private Sub Combo_keterangan_Leave(sender As Object, e As EventArgs) Handles Combo_keterangan.Leave
        If Text_faktur.Text = "" Or Text_nama.Text = "" Or Text_berat.Text = "" Then
            MsgBox("isi faktur terlebih dahulu")
        Else
            If Combo_keterangan.Text = "Lunas" Then
                Text_sisa.Text = "0"
                btn_simpan.Enabled = True
                Combo_status.Text = "selesai"
            ElseIf Combo_keterangan.Text = "Belum Lunas" Then
                Text_sisa.Text = Val(Text_harga.Text) - Val(Text_panjar.Text)
                btn_simpan.Enabled = False
                Combo_status.Text = "belum selesai"
            End If
        End If
    End Sub

    'input data
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If Text_faktur.Text = "" Or Text_nama.Text = "" Or Text_berat.Text = "" Or Text_harga.Text = "" Or Text_panjar.Text = "" Or Combo_keterangan.Text = "" Or Text_sisa.Text = "" Then
            MsgBox("isi data dengan lengkap")
        Else
            Call koneksi()
            cmd = New MySqlCommand("INSERT INTO data_laundry_selesai VALUES ('" & Text_faktur.Text & "','" & Text_nama.Text & "','" & Text_berat.Text & "', '" & Text_harga.Text & "','" & Combo_keterangan.Text & "', '" & DateTimePicker_tanggalSelesai.Text & "','" & Combo_status.Text & "')", conn)
            cmd.ExecuteNonQuery()
            cmd = New MySqlCommand("DELETE FROM data_laundry WHERE faktur = ('" & Text_faktur.Text & "')", conn)
            cmd.ExecuteNonQuery()
            Call keadaanAwal()
            MsgBox("data berhasil diperbarui")
        End If
    End Sub

    'btn reset
    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        keadaanAwal()
    End Sub

    'btn close
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
        MenuUtama.Show()
    End Sub

    'btn data laundry
    Private Sub btn_dataLaundry_Click(sender As Object, e As EventArgs) Handles btn_dataLaundry.Click
        Me.Close()
        DataLaundry.Show()
    End Sub

    'lebar columns datagridview
    Sub autoGrid()
        DataGridView1.Columns(0).Width = 160
        DataGridView1.Columns(1).Width = 160
        DataGridView1.Columns(2).Width = 160
        DataGridView1.Columns(3).Width = 160
        DataGridView1.Columns(4).Width = 160
        DataGridView1.Columns(5).Width = 160
        DataGridView1.Columns(6).Width = 160
    End Sub

End Class