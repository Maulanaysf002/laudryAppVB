<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PenyerahanCucian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_data = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Text_sisa = New System.Windows.Forms.TextBox()
        Me.Text_panjar = New System.Windows.Forms.TextBox()
        Me.Text_harga = New System.Windows.Forms.TextBox()
        Me.Text_nama = New System.Windows.Forms.TextBox()
        Me.Text_berat = New System.Windows.Forms.TextBox()
        Me.Text_faktur = New System.Windows.Forms.TextBox()
        Me.DateTimePicker_estimasi = New System.Windows.Forms.DateTimePicker()
        Me.Combo_keterangan = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SandyBrown
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-4, -6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(707, 89)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Masukan Data Cucian "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_close)
        Me.Panel1.Controls.Add(Me.btn_data)
        Me.Panel1.Controls.Add(Me.btn_simpan)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Text_sisa)
        Me.Panel1.Controls.Add(Me.Text_panjar)
        Me.Panel1.Controls.Add(Me.Text_harga)
        Me.Panel1.Controls.Add(Me.Text_nama)
        Me.Panel1.Controls.Add(Me.Text_berat)
        Me.Panel1.Controls.Add(Me.Text_faktur)
        Me.Panel1.Controls.Add(Me.DateTimePicker_estimasi)
        Me.Panel1.Controls.Add(Me.Combo_keterangan)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(3, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(697, 330)
        Me.Panel1.TabIndex = 4
        '
        'btn_close
        '
        Me.btn_close.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(501, 253)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(173, 47)
        Me.btn_close.TabIndex = 0
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_data
        '
        Me.btn_data.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_data.Location = New System.Drawing.Point(501, 189)
        Me.btn_data.Name = "btn_data"
        Me.btn_data.Size = New System.Drawing.Size(173, 49)
        Me.btn_data.TabIndex = 0
        Me.btn_data.Text = "Data Laundry"
        Me.btn_data.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.Location = New System.Drawing.Point(349, 189)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(121, 47)
        Me.btn_simpan.TabIndex = 0
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(220, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Kg"
        '
        'Text_sisa
        '
        Me.Text_sisa.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_sisa.Location = New System.Drawing.Point(505, 66)
        Me.Text_sisa.Name = "Text_sisa"
        Me.Text_sisa.Size = New System.Drawing.Size(169, 27)
        Me.Text_sisa.TabIndex = 7
        '
        'Text_panjar
        '
        Me.Text_panjar.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_panjar.Location = New System.Drawing.Point(137, 211)
        Me.Text_panjar.Name = "Text_panjar"
        Me.Text_panjar.Size = New System.Drawing.Size(169, 27)
        Me.Text_panjar.TabIndex = 5
        '
        'Text_harga
        '
        Me.Text_harga.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_harga.Location = New System.Drawing.Point(137, 158)
        Me.Text_harga.Name = "Text_harga"
        Me.Text_harga.Size = New System.Drawing.Size(169, 27)
        Me.Text_harga.TabIndex = 4
        '
        'Text_nama
        '
        Me.Text_nama.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_nama.Location = New System.Drawing.Point(137, 67)
        Me.Text_nama.Name = "Text_nama"
        Me.Text_nama.Size = New System.Drawing.Size(169, 27)
        Me.Text_nama.TabIndex = 2
        '
        'Text_berat
        '
        Me.Text_berat.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_berat.Location = New System.Drawing.Point(137, 111)
        Me.Text_berat.Name = "Text_berat"
        Me.Text_berat.Size = New System.Drawing.Size(77, 27)
        Me.Text_berat.TabIndex = 3
        '
        'Text_faktur
        '
        Me.Text_faktur.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_faktur.Location = New System.Drawing.Point(137, 24)
        Me.Text_faktur.Name = "Text_faktur"
        Me.Text_faktur.Size = New System.Drawing.Size(169, 27)
        Me.Text_faktur.TabIndex = 1
        '
        'DateTimePicker_estimasi
        '
        Me.DateTimePicker_estimasi.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_estimasi.Location = New System.Drawing.Point(505, 115)
        Me.DateTimePicker_estimasi.Name = "DateTimePicker_estimasi"
        Me.DateTimePicker_estimasi.Size = New System.Drawing.Size(169, 27)
        Me.DateTimePicker_estimasi.TabIndex = 8
        '
        'Combo_keterangan
        '
        Me.Combo_keterangan.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_keterangan.FormattingEnabled = True
        Me.Combo_keterangan.Items.AddRange(New Object() {"Lunas", "Belum Lunas"})
        Me.Combo_keterangan.Location = New System.Drawing.Point(505, 21)
        Me.Combo_keterangan.Name = "Combo_keterangan"
        Me.Combo_keterangan.Size = New System.Drawing.Size(169, 28)
        Me.Combo_keterangan.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(345, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 20)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Estimasi Selesai"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(345, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Sisa Tagihan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(345, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Keterangan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Panjar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Berat Cucian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Faktur"
        '
        'PenyerahanCucian
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(700, 416)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "PenyerahanCucian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penyerahan Cucian"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Text_sisa As System.Windows.Forms.TextBox
    Friend WithEvents Text_panjar As System.Windows.Forms.TextBox
    Friend WithEvents Text_harga As System.Windows.Forms.TextBox
    Friend WithEvents Text_nama As System.Windows.Forms.TextBox
    Friend WithEvents Text_berat As System.Windows.Forms.TextBox
    Friend WithEvents Text_faktur As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker_estimasi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Combo_keterangan As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_data As System.Windows.Forms.Button
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
End Class
