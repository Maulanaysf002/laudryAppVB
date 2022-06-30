
Imports MySql.Data.MySqlClient
Public Class PenyerahanCucian

    ' form load penyerahan cucian
    Private Sub PenyerahanCucian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call faktur()
    End Sub

    'keadaan awal 
    Sub keadaanAwal()
        Text_nama.Text = ""
        Text_berat.Text = ""
        Text_harga.Text = ""
        Text_panjar.Text = ""
        Combo_keterangan.Text = ""
        Text_sisa.Text = ""
    End Sub

    'faktur
    Public Sub faktur()
        Call koneksi()
        Dim faktur As String = "SELECT * FROM data_laundry WHERE faktur in(select max(faktur) from data_laundry) order by faktur desc"
        cmd = New MySqlCommand(faktur, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            Text_faktur.Text = Format(Today, "ddMMyy") + "0001"
        Else
            If Microsoft.VisualBasic.Left(dr.GetString(0), 6) <> Format(Today, "ddMMyy") Then
                Text_faktur.Text = Format(Today, "ddMMyy") + "0001"
            Else
                Text_faktur.Text = dr.Item("faktur") + 1
            End If
        End If
    End Sub

    'berat cucian key press
    Private Sub Text_berat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_berat.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'berat cucian leave(isi text) (jika text berat cucian diisi maka berat dikali harga jasa laundry)
    Private Sub TextBrtcucian_Leave(sender As Object, e As EventArgs) Handles Text_berat.Leave
        Text_harga.Text = Val(Text_berat.Text) * 8000
    End Sub

    'key press text panjer
    Private Sub Text_panjar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_panjar.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'leave text panjer (jika textbox panjer terisi maka sisa akan terisi dengan rumus)
    Private Sub Text_panjar_Leave(sender As Object, e As EventArgs) Handles Text_panjar.Leave
        Text_sisa.Text = Val(Text_harga.Text) - Val(Text_panjar.Text)
        If Val(Text_sisa.Text) <= 0 Then
            Combo_keterangan.Text = "Lunas"
            Text_sisa.Text = "0"
        ElseIf Text_sisa.Text = "0" Then
            Combo_keterangan.Text = "Lunas"
        Else
            Combo_keterangan.Text = "Belum Lunas"
        End If
        btn_simpan.Focus()
    End Sub

    ' tombol simpan ditekan
    Private Sub Btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        If Text_faktur.Text = "" Or Text_nama.Text = "" Or Text_berat.Text = "" Or Text_harga.Text = "" Or Text_panjar.Text = "" Or Combo_keterangan.Text = "" Or Text_sisa.Text = "" Then
            MsgBox("isi data dengan lengkap")
        Else
            Call koneksi()
            Dim inputData As String = "INSERT INTO data_laundry VALUES ('" & Text_faktur.Text & "','" & Text_nama.Text & "','" & Text_berat.Text & "','" & Text_harga.Text & "', '" & Text_panjar.Text & "','" & Combo_keterangan.Text & "', '" & Text_sisa.Text & "','" & DateTimePicker_estimasi.Text & "')"
            cmd = New MySqlCommand(inputData, conn)
            cmd.ExecuteNonQuery()
            MsgBox("input data berhasil")
            Call keadaanAwal()
            Call faktur()
        End If
    End Sub

    'button data laundry ditekan
    Private Sub btn_data_Click(sender As Object, e As EventArgs) Handles btn_data.Click
        Me.Hide()
        DataLaundry.ShowDialog()
    End Sub

    'button close
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
        MenuUtama.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class