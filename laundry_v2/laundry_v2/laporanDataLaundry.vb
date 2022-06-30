
Imports MySql.Data.MySqlClient
Public Class laporanDataLaundry

    Dim ds As DataSet
    Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Dim adp As MySqlDataAdapter


    Private Sub laporanDataLaundry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'panggil koneksi
        Call koneksi()
        Dim data As String = "SELECT * FROM data_laundry"
        rptdoc = New CRlaporan_DataLaundry
        adp = New MySqlDataAdapter(data, conn)
        ds = New DataSet
        adp.Fill(ds, "Lap. Data Laundry")
        ds.WriteXmlSchema(Application.StartupPath & "\LapDataLaundry2.xsd")
        rptdoc.SetDataSource(ds)
        CRV_dataLaundry.ReportSource = rptdoc
    End Sub
End Class