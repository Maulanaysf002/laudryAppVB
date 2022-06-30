<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataLaundry
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Text_faktur = New System.Windows.Forms.TextBox()
        Me.Text_nama = New System.Windows.Forms.TextBox()
        Me.RadioButton_faktur = New System.Windows.Forms.RadioButton()
        Me.RadioButton_nama = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_penyerahanCucian = New System.Windows.Forms.Button()
        Me.btn_pengembalianCucian = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Text_faktur)
        Me.GroupBox1.Controls.Add(Me.Text_nama)
        Me.GroupBox1.Controls.Add(Me.RadioButton_faktur)
        Me.GroupBox1.Controls.Add(Me.RadioButton_nama)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(759, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Data"
        '
        'Text_faktur
        '
        Me.Text_faktur.Location = New System.Drawing.Point(548, 41)
        Me.Text_faktur.Name = "Text_faktur"
        Me.Text_faktur.Size = New System.Drawing.Size(183, 30)
        Me.Text_faktur.TabIndex = 4
        '
        'Text_nama
        '
        Me.Text_nama.Location = New System.Drawing.Point(209, 42)
        Me.Text_nama.Name = "Text_nama"
        Me.Text_nama.Size = New System.Drawing.Size(182, 30)
        Me.Text_nama.TabIndex = 2
        '
        'RadioButton_faktur
        '
        Me.RadioButton_faktur.AutoSize = True
        Me.RadioButton_faktur.Location = New System.Drawing.Point(452, 42)
        Me.RadioButton_faktur.Name = "RadioButton_faktur"
        Me.RadioButton_faktur.Size = New System.Drawing.Size(90, 27)
        Me.RadioButton_faktur.TabIndex = 3
        Me.RadioButton_faktur.TabStop = True
        Me.RadioButton_faktur.Text = "Faktur"
        Me.RadioButton_faktur.UseVisualStyleBackColor = True
        '
        'RadioButton_nama
        '
        Me.RadioButton_nama.AutoSize = True
        Me.RadioButton_nama.Location = New System.Drawing.Point(21, 41)
        Me.RadioButton_nama.Name = "RadioButton_nama"
        Me.RadioButton_nama.Size = New System.Drawing.Size(182, 27)
        Me.RadioButton_nama.TabIndex = 1
        Me.RadioButton_nama.TabStop = True
        Me.RadioButton_nama.Text = "Nama Pelanggan"
        Me.RadioButton_nama.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Location = New System.Drawing.Point(13, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 100
        Me.DataGridView1.RowTemplate.Height = 35
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(759, 304)
        Me.DataGridView1.TabIndex = 1
        '
        'btn_refresh
        '
        Me.btn_refresh.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.Location = New System.Drawing.Point(516, 481)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(125, 33)
        Me.btn_refresh.TabIndex = 2
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(647, 481)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(125, 33)
        Me.btn_close.TabIndex = 2
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_penyerahanCucian
        '
        Me.btn_penyerahanCucian.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_penyerahanCucian.Location = New System.Drawing.Point(13, 436)
        Me.btn_penyerahanCucian.Name = "btn_penyerahanCucian"
        Me.btn_penyerahanCucian.Size = New System.Drawing.Size(281, 33)
        Me.btn_penyerahanCucian.TabIndex = 3
        Me.btn_penyerahanCucian.Text = "Penyerahan Cucian"
        Me.btn_penyerahanCucian.UseVisualStyleBackColor = True
        '
        'btn_pengembalianCucian
        '
        Me.btn_pengembalianCucian.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pengembalianCucian.Location = New System.Drawing.Point(13, 481)
        Me.btn_pengembalianCucian.Name = "btn_pengembalianCucian"
        Me.btn_pengembalianCucian.Size = New System.Drawing.Size(281, 33)
        Me.btn_pengembalianCucian.TabIndex = 4
        Me.btn_pengembalianCucian.Text = "Pengembalian Cucian"
        Me.btn_pengembalianCucian.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(516, 436)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(256, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Cetak Laporan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataLaundry
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(784, 526)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_pengembalianCucian)
        Me.Controls.Add(Me.btn_penyerahanCucian)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DataLaundry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Laundry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_faktur As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_nama As System.Windows.Forms.RadioButton
    Friend WithEvents Text_faktur As System.Windows.Forms.TextBox
    Friend WithEvents Text_nama As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_penyerahanCucian As System.Windows.Forms.Button
    Friend WithEvents btn_pengembalianCucian As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
