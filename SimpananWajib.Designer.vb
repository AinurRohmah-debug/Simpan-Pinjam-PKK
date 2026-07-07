<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpananWajib
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
        Me.TbxKdSimpanWjb = New System.Windows.Forms.TextBox()
        Me.TbxIdAnggota = New System.Windows.Forms.TextBox()
        Me.TbxNominalWjb = New System.Windows.Forms.TextBox()
        Me.CbNamaAnggota = New System.Windows.Forms.ComboBox()
        Me.TanggalSimpanWjb = New System.Windows.Forms.DateTimePicker()
        Me.DgSimpanWjb = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbxSaldoWjb = New System.Windows.Forms.TextBox()
        Me.BtnSimpanWjb = New System.Windows.Forms.Button()
        Me.BtnKembaliwjb = New System.Windows.Forms.Button()
        Me.BtnHapusWajib = New System.Windows.Forms.Button()
        Me.BtnCetakWajb = New System.Windows.Forms.Button()
        Me.BtnSelesaiWajib = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DgSimpanWjb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Data Anggota Simpanan Wajib"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Simpanan Wajib"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Id Anggota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Anggota"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(423, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(423, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nominal"
        '
        'TbxKdSimpanWjb
        '
        Me.TbxKdSimpanWjb.Location = New System.Drawing.Point(196, 76)
        Me.TbxKdSimpanWjb.Name = "TbxKdSimpanWjb"
        Me.TbxKdSimpanWjb.Size = New System.Drawing.Size(158, 20)
        Me.TbxKdSimpanWjb.TabIndex = 6
        '
        'TbxIdAnggota
        '
        Me.TbxIdAnggota.Location = New System.Drawing.Point(196, 111)
        Me.TbxIdAnggota.Name = "TbxIdAnggota"
        Me.TbxIdAnggota.Size = New System.Drawing.Size(158, 20)
        Me.TbxIdAnggota.TabIndex = 7
        '
        'TbxNominalWjb
        '
        Me.TbxNominalWjb.Location = New System.Drawing.Point(493, 115)
        Me.TbxNominalWjb.Name = "TbxNominalWjb"
        Me.TbxNominalWjb.Size = New System.Drawing.Size(200, 20)
        Me.TbxNominalWjb.TabIndex = 8
        '
        'CbNamaAnggota
        '
        Me.CbNamaAnggota.FormattingEnabled = True
        Me.CbNamaAnggota.Location = New System.Drawing.Point(196, 148)
        Me.CbNamaAnggota.Name = "CbNamaAnggota"
        Me.CbNamaAnggota.Size = New System.Drawing.Size(158, 21)
        Me.CbNamaAnggota.TabIndex = 9
        '
        'TanggalSimpanWjb
        '
        Me.TanggalSimpanWjb.Location = New System.Drawing.Point(493, 72)
        Me.TanggalSimpanWjb.Name = "TanggalSimpanWjb"
        Me.TanggalSimpanWjb.Size = New System.Drawing.Size(200, 20)
        Me.TanggalSimpanWjb.TabIndex = 10
        '
        'DgSimpanWjb
        '
        Me.DgSimpanWjb.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DgSimpanWjb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgSimpanWjb.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DgSimpanWjb.Location = New System.Drawing.Point(54, 198)
        Me.DgSimpanWjb.Name = "DgSimpanWjb"
        Me.DgSimpanWjb.Size = New System.Drawing.Size(685, 198)
        Me.DgSimpanWjb.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(536, 416)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Total Saldo"
        '
        'TbxSaldoWjb
        '
        Me.TbxSaldoWjb.Location = New System.Drawing.Point(614, 413)
        Me.TbxSaldoWjb.Name = "TbxSaldoWjb"
        Me.TbxSaldoWjb.Size = New System.Drawing.Size(125, 20)
        Me.TbxSaldoWjb.TabIndex = 13
        '
        'BtnSimpanWjb
        '
        Me.BtnSimpanWjb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpanWjb.Location = New System.Drawing.Point(426, 151)
        Me.BtnSimpanWjb.Name = "BtnSimpanWjb"
        Me.BtnSimpanWjb.Size = New System.Drawing.Size(84, 23)
        Me.BtnSimpanWjb.TabIndex = 14
        Me.BtnSimpanWjb.Text = "Simpan"
        Me.BtnSimpanWjb.UseVisualStyleBackColor = True
        '
        'BtnKembaliwjb
        '
        Me.BtnKembaliwjb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembaliwjb.Location = New System.Drawing.Point(54, 410)
        Me.BtnKembaliwjb.Name = "BtnKembaliwjb"
        Me.BtnKembaliwjb.Size = New System.Drawing.Size(102, 23)
        Me.BtnKembaliwjb.TabIndex = 15
        Me.BtnKembaliwjb.Text = "Kembali"
        Me.BtnKembaliwjb.UseVisualStyleBackColor = True
        '
        'BtnHapusWajib
        '
        Me.BtnHapusWajib.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusWajib.Location = New System.Drawing.Point(518, 151)
        Me.BtnHapusWajib.Name = "BtnHapusWajib"
        Me.BtnHapusWajib.Size = New System.Drawing.Size(82, 23)
        Me.BtnHapusWajib.TabIndex = 16
        Me.BtnHapusWajib.Text = "Hapus"
        Me.BtnHapusWajib.UseVisualStyleBackColor = True
        '
        'BtnCetakWajb
        '
        Me.BtnCetakWajb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCetakWajb.Location = New System.Drawing.Point(606, 151)
        Me.BtnCetakWajb.Name = "BtnCetakWajb"
        Me.BtnCetakWajb.Size = New System.Drawing.Size(78, 23)
        Me.BtnCetakWajb.TabIndex = 17
        Me.BtnCetakWajb.Text = "Cetak"
        Me.BtnCetakWajb.UseVisualStyleBackColor = True
        '
        'BtnSelesaiWajib
        '
        Me.BtnSelesaiWajib.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelesaiWajib.Location = New System.Drawing.Point(690, 143)
        Me.BtnSelesaiWajib.Name = "BtnSelesaiWajib"
        Me.BtnSelesaiWajib.Size = New System.Drawing.Size(82, 39)
        Me.BtnSelesaiWajib.TabIndex = 18
        Me.BtnSelesaiWajib.Text = "Selesai"
        Me.BtnSelesaiWajib.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FPPKK.My.Resources.Resources.LOGO_PKK_PNG
        Me.PictureBox1.Location = New System.Drawing.Point(713, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'SimpananWajib
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnSelesaiWajib)
        Me.Controls.Add(Me.BtnCetakWajb)
        Me.Controls.Add(Me.BtnHapusWajib)
        Me.Controls.Add(Me.BtnKembaliwjb)
        Me.Controls.Add(Me.BtnSimpanWjb)
        Me.Controls.Add(Me.TbxSaldoWjb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DgSimpanWjb)
        Me.Controls.Add(Me.TanggalSimpanWjb)
        Me.Controls.Add(Me.CbNamaAnggota)
        Me.Controls.Add(Me.TbxNominalWjb)
        Me.Controls.Add(Me.TbxIdAnggota)
        Me.Controls.Add(Me.TbxKdSimpanWjb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SimpananWajib"
        Me.Text = "SimpananWajib"
        CType(Me.DgSimpanWjb, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TbxKdSimpanWjb As TextBox
    Friend WithEvents TbxIdAnggota As TextBox
    Friend WithEvents TbxNominalWjb As TextBox
    Friend WithEvents CbNamaAnggota As ComboBox
    Friend WithEvents TanggalSimpanWjb As DateTimePicker
    Friend WithEvents DgSimpanWjb As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents TbxSaldoWjb As TextBox
    Friend WithEvents BtnSimpanWjb As Button
    Friend WithEvents BtnKembaliwjb As Button
    Friend WithEvents BtnHapusWajib As Button
    Friend WithEvents BtnCetakWajb As Button
    Friend WithEvents BtnSelesaiWajib As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
