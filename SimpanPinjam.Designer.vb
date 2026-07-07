<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpanPinjam
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbxKdPinjam = New System.Windows.Forms.TextBox()
        Me.TbxIdAgtPinjam = New System.Windows.Forms.TextBox()
        Me.TbxNominalPinjam = New System.Windows.Forms.TextBox()
        Me.CbNmAgtPinjam = New System.Windows.Forms.ComboBox()
        Me.TanggalPinjam = New System.Windows.Forms.DateTimePicker()
        Me.DgSimpanPinjam = New System.Windows.Forms.DataGridView()
        Me.TbxTotalPinjam = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnSimpanPinjam = New System.Windows.Forms.Button()
        Me.BtnKembaliPinjam = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbxJmlCicilan = New System.Windows.Forms.TextBox()
        Me.BtnCetakPinjam = New System.Windows.Forms.Button()
        Me.BtnSelesaiPinjaman = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DgSimpanPinjam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(253, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Anggota Pinjaman"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode  Pinjaman"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Id Anggota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Anggota"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(420, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nominal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(420, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tanggal"
        '
        'TbxKdPinjam
        '
        Me.TbxKdPinjam.Location = New System.Drawing.Point(147, 70)
        Me.TbxKdPinjam.Name = "TbxKdPinjam"
        Me.TbxKdPinjam.Size = New System.Drawing.Size(193, 20)
        Me.TbxKdPinjam.TabIndex = 6
        '
        'TbxIdAgtPinjam
        '
        Me.TbxIdAgtPinjam.Location = New System.Drawing.Point(147, 107)
        Me.TbxIdAgtPinjam.Name = "TbxIdAgtPinjam"
        Me.TbxIdAgtPinjam.Size = New System.Drawing.Size(193, 20)
        Me.TbxIdAgtPinjam.TabIndex = 7
        '
        'TbxNominalPinjam
        '
        Me.TbxNominalPinjam.Location = New System.Drawing.Point(525, 100)
        Me.TbxNominalPinjam.Name = "TbxNominalPinjam"
        Me.TbxNominalPinjam.Size = New System.Drawing.Size(200, 20)
        Me.TbxNominalPinjam.TabIndex = 8
        '
        'CbNmAgtPinjam
        '
        Me.CbNmAgtPinjam.FormattingEnabled = True
        Me.CbNmAgtPinjam.Location = New System.Drawing.Point(147, 139)
        Me.CbNmAgtPinjam.Name = "CbNmAgtPinjam"
        Me.CbNmAgtPinjam.Size = New System.Drawing.Size(193, 21)
        Me.CbNmAgtPinjam.TabIndex = 9
        '
        'TanggalPinjam
        '
        Me.TanggalPinjam.Location = New System.Drawing.Point(525, 70)
        Me.TanggalPinjam.Name = "TanggalPinjam"
        Me.TanggalPinjam.Size = New System.Drawing.Size(200, 20)
        Me.TanggalPinjam.TabIndex = 10
        '
        'DgSimpanPinjam
        '
        Me.DgSimpanPinjam.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DgSimpanPinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgSimpanPinjam.Location = New System.Drawing.Point(41, 212)
        Me.DgSimpanPinjam.Name = "DgSimpanPinjam"
        Me.DgSimpanPinjam.Size = New System.Drawing.Size(697, 200)
        Me.DgSimpanPinjam.TabIndex = 11
        '
        'TbxTotalPinjam
        '
        Me.TbxTotalPinjam.Location = New System.Drawing.Point(616, 418)
        Me.TbxTotalPinjam.Name = "TbxTotalPinjam"
        Me.TbxTotalPinjam.Size = New System.Drawing.Size(122, 20)
        Me.TbxTotalPinjam.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(513, 425)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Total Pinjam"
        '
        'BtnSimpanPinjam
        '
        Me.BtnSimpanPinjam.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpanPinjam.Location = New System.Drawing.Point(420, 173)
        Me.BtnSimpanPinjam.Name = "BtnSimpanPinjam"
        Me.BtnSimpanPinjam.Size = New System.Drawing.Size(81, 23)
        Me.BtnSimpanPinjam.TabIndex = 14
        Me.BtnSimpanPinjam.Text = "Simpan"
        Me.BtnSimpanPinjam.UseVisualStyleBackColor = True
        '
        'BtnKembaliPinjam
        '
        Me.BtnKembaliPinjam.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembaliPinjam.Location = New System.Drawing.Point(41, 425)
        Me.BtnKembaliPinjam.Name = "BtnKembaliPinjam"
        Me.BtnKembaliPinjam.Size = New System.Drawing.Size(111, 23)
        Me.BtnKembaliPinjam.TabIndex = 15
        Me.BtnKembaliPinjam.Text = "Kembali"
        Me.BtnKembaliPinjam.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(420, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Jumlah Angsuran"
        '
        'TbxJmlCicilan
        '
        Me.TbxJmlCicilan.Location = New System.Drawing.Point(525, 137)
        Me.TbxJmlCicilan.Name = "TbxJmlCicilan"
        Me.TbxJmlCicilan.Size = New System.Drawing.Size(200, 20)
        Me.TbxJmlCicilan.TabIndex = 17
        '
        'BtnCetakPinjam
        '
        Me.BtnCetakPinjam.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCetakPinjam.Location = New System.Drawing.Point(516, 173)
        Me.BtnCetakPinjam.Name = "BtnCetakPinjam"
        Me.BtnCetakPinjam.Size = New System.Drawing.Size(90, 23)
        Me.BtnCetakPinjam.TabIndex = 18
        Me.BtnCetakPinjam.Text = "Cetak"
        Me.BtnCetakPinjam.UseVisualStyleBackColor = True
        '
        'BtnSelesaiPinjaman
        '
        Me.BtnSelesaiPinjaman.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelesaiPinjaman.Location = New System.Drawing.Point(626, 163)
        Me.BtnSelesaiPinjaman.Name = "BtnSelesaiPinjaman"
        Me.BtnSelesaiPinjaman.Size = New System.Drawing.Size(99, 43)
        Me.BtnSelesaiPinjaman.TabIndex = 20
        Me.BtnSelesaiPinjaman.Text = "Selesai"
        Me.BtnSelesaiPinjaman.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FPPKK.My.Resources.Resources.LOGO_PKK_PNG
        Me.PictureBox1.Location = New System.Drawing.Point(720, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'SimpanPinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnSelesaiPinjaman)
        Me.Controls.Add(Me.BtnCetakPinjam)
        Me.Controls.Add(Me.TbxJmlCicilan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnKembaliPinjam)
        Me.Controls.Add(Me.BtnSimpanPinjam)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TbxTotalPinjam)
        Me.Controls.Add(Me.DgSimpanPinjam)
        Me.Controls.Add(Me.TanggalPinjam)
        Me.Controls.Add(Me.CbNmAgtPinjam)
        Me.Controls.Add(Me.TbxNominalPinjam)
        Me.Controls.Add(Me.TbxIdAgtPinjam)
        Me.Controls.Add(Me.TbxKdPinjam)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SimpanPinjam"
        Me.Text = "SimpanPinjam"
        CType(Me.DgSimpanPinjam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TbxKdPinjam As TextBox
    Friend WithEvents TbxIdAgtPinjam As TextBox
    Friend WithEvents TbxNominalPinjam As TextBox
    Friend WithEvents CbNmAgtPinjam As ComboBox
    Friend WithEvents TanggalPinjam As DateTimePicker
    Friend WithEvents DgSimpanPinjam As DataGridView
    Friend WithEvents TbxTotalPinjam As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnSimpanPinjam As Button
    Friend WithEvents BtnKembaliPinjam As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TbxJmlCicilan As TextBox
    Friend WithEvents BtnCetakPinjam As Button
    Friend WithEvents BtnSelesaiPinjaman As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
