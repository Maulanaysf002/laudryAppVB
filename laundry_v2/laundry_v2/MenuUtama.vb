
Public Class MenuUtama
    'button penyerahan cucian
    Private Sub btn_penyerahanCucian_Click(sender As Object, e As EventArgs) Handles btn_penyerahanCucian.Click
        Me.Hide()
        PenyerahanCucian.ShowDialog()
    End Sub

    'button data laundry
    Private Sub btn_dataLaundry_Click(sender As Object, e As EventArgs) Handles btn_dataLaundry.Click
        Me.Hide()
        DataLaundry.ShowDialog()
    End Sub

    'button pengembalian pakaian
    Private Sub btn_pengembalianCucian_Click(sender As Object, e As EventArgs) Handles btn_pengembalianCucian.Click
        Me.Hide()
        PengembalianCucian.ShowDialog()
    End Sub

    'button close
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class