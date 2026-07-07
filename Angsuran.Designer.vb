<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Angsuran
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CbNmAgtAngsuran = New System.Windows.Forms.ComboBox()
        Me.TbxKdAngsuran = New System.Windows.Forms.TextBox()
        Me.TbxIdAgtAngsuran = New System.Windows.Forms.TextBox()
        Me.TbxNmlPinjam = New System.Windows.Forms.TextBox()
        Me.TbxNmlCicilanPinjam = New System.Windows.Forms.TextBox()
        Me.TbxCicilan = New System.Windows.Forms.TextBox()
        Me.TbxSisaPinjam = New System.Windows.Forms.TextBox()
        Me.TbxNominalAngsuran = New System.Windows.Forms.TextBox()
        Me.TanggalAngsuran = New System.Windows.Forms.DateTimePicker()
        Me.DgAngsuran = New System.Windows.Forms.DataGridView()
        Me.BtnSimpanAngsuran = New System.Windows.Forms.Button()
        Me.BtnKembaliAngsuran = New System.Windows.Forms.Button()
        Me.CbIdPinjaman = New System.Windows.Forms.ComboBox()
        Me.TbxSisaBayar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnCetakAngsuran = New System.Windows.Forms.Button()
        Me.BtnHapusAngsuran = New System.Windows.Forms.Button()
        Me.BtnSelesaiAngsuran = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DgAngsuran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pembayaran Angsuran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Angsuran"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Id Anggota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Anggota"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kode Pinjaman"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nominal Pinjam"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(381, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Nominal Cicilan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(381, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Cicilan Ke"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(381, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Sisa Pinjaman"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(381, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Nominal Angsuran"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(381, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Tanggal"
        '
        'CbNmAgtAngsuran
        '
        Me.CbNmAgtAngsuran.FormattingEnabled = True
        Me.CbNmAgtAngsuran.Location = New System.Drawing.Point(170, 123)
        Me.CbNmAgtAngsuran.Name = "CbNmAgtAngsuran"
        Me.CbNmAgtAngsuran.Size = New System.Drawing.Size(175, 21)
        Me.CbNmAgtAngsuran.TabIndex = 11
        '
        'TbxKdAngsuran
        '
        Me.TbxKdAngsuran.Location = New System.Drawing.Point(170, 62)
        Me.TbxKdAngsuran.Name = "TbxKdAngsuran"
        Me.TbxKdAngsuran.Size = New System.Drawing.Size(174, 20)
        Me.TbxKdAngsuran.TabIndex = 12
        '
        'TbxIdAgtAngsuran
        '
        Me.TbxIdAgtAngsuran.Location = New System.Drawing.Point(170, 93)
        Me.TbxIdAgtAngsuran.Name = "TbxIdAgtAngsuran"
        Me.TbxIdAgtAngsuran.Size = New System.Drawing.Size(174, 20)
        Me.TbxIdAgtAngsuran.TabIndex = 13
        '
        'TbxNmlPinjam
        '
        Me.TbxNmlPinjam.Location = New System.Drawing.Point(170, 180)
        Me.TbxNmlPinjam.Name = "TbxNmlPinjam"
        Me.TbxNmlPinjam.Size = New System.Drawing.Size(174, 20)
        Me.TbxNmlPinjam.TabIndex = 15
        '
        'TbxNmlCicilanPinjam
        '
        Me.TbxNmlCicilanPinjam.Location = New System.Drawing.Point(492, 96)
        Me.TbxNmlCicilanPinjam.Name = "TbxNmlCicilanPinjam"
        Me.TbxNmlCicilanPinjam.Size = New System.Drawing.Size(200, 20)
        Me.TbxNmlCicilanPinjam.TabIndex = 16
        '
        'TbxCicilan
        '
        Me.TbxCicilan.Location = New System.Drawing.Point(492, 124)
        Me.TbxCicilan.Name = "TbxCicilan"
        Me.TbxCicilan.Size = New System.Drawing.Size(200, 20)
        Me.TbxCicilan.TabIndex = 17
        '
        'TbxSisaPinjam
        '
        Me.TbxSisaPinjam.Location = New System.Drawing.Point(492, 151)
        Me.TbxSisaPinjam.Name = "TbxSisaPinjam"
        Me.TbxSisaPinjam.Size = New System.Drawing.Size(200, 20)
        Me.TbxSisaPinjam.TabIndex = 18
        '
        'TbxNominalAngsuran
        '
        Me.TbxNominalAngsuran.Location = New System.Drawing.Point(493, 180)
        Me.TbxNominalAngsuran.Name = "TbxNominalAngsuran"
        Me.TbxNominalAngsuran.Size = New System.Drawing.Size(200, 20)
        Me.TbxNominalAngsuran.TabIndex = 19
        '
        'TanggalAngsuran
        '
        Me.TanggalAngsuran.Location = New System.Drawing.Point(492, 62)
        Me.TanggalAngsuran.Name = "TanggalAngsuran"
        Me.TanggalAngsuran.Size = New System.Drawing.Size(200, 20)
        Me.TanggalAngsuran.TabIndex = 20
        '
        'DgAngsuran
        '
        Me.DgAngsuran.AllowUserToAddRows = False
        Me.DgAngsuran.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DgAngsuran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgAngsuran.Location = New System.Drawing.Point(26, 244)
        Me.DgAngsuran.Name = "DgAngsuran"
        Me.DgAngsuran.Size = New System.Drawing.Size(707, 142)
        Me.DgAngsuran.TabIndex = 21
        '
        'BtnSimpanAngsuran
        '
        Me.BtnSimpanAngsuran.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpanAngsuran.Location = New System.Drawing.Point(352, 211)
        Me.BtnSimpanAngsuran.Name = "BtnSimpanAngsuran"
        Me.BtnSimpanAngsuran.Size = New System.Drawing.Size(86, 23)
        Me.BtnSimpanAngsuran.TabIndex = 22
        Me.BtnSimpanAngsuran.Text = "Simpan"
        Me.BtnSimpanAngsuran.UseVisualStyleBackColor = True
        '
        'BtnKembaliAngsuran
        '
        Me.BtnKembaliAngsuran.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembaliAngsuran.Location = New System.Drawing.Point(31, 407)
        Me.BtnKembaliAngsuran.Name = "BtnKembaliAngsuran"
        Me.BtnKembaliAngsuran.Size = New System.Drawing.Size(119, 23)
        Me.BtnKembaliAngsuran.TabIndex = 23
        Me.BtnKembaliAngsuran.Text = "Kembali"
        Me.BtnKembaliAngsuran.UseVisualStyleBackColor = True
        '
        'CbIdPinjaman
        '
        Me.CbIdPinjaman.FormattingEnabled = True
        Me.CbIdPinjaman.Location = New System.Drawing.Point(170, 150)
        Me.CbIdPinjaman.Name = "CbIdPinjaman"
        Me.CbIdPinjaman.Size = New System.Drawing.Size(175, 21)
        Me.CbIdPinjaman.TabIndex = 24
        '
        'TbxSisaBayar
        '
        Me.TbxSisaBayar.Location = New System.Drawing.Point(595, 405)
        Me.TbxSisaBayar.Name = "TbxSisaBayar"
        Me.TbxSisaBayar.Size = New System.Drawing.Size(138, 20)
        Me.TbxSisaBayar.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(471, 412)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Sisa Setelah Bayar"
        '
        'BtnCetakAngsuran
        '
        Me.BtnCetakAngsuran.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCetakAngsuran.Location = New System.Drawing.Point(542, 211)
        Me.BtnCetakAngsuran.Name = "BtnCetakAngsuran"
        Me.BtnCetakAngsuran.Size = New System.Drawing.Size(86, 23)
        Me.BtnCetakAngsuran.TabIndex = 27
        Me.BtnCetakAngsuran.Text = "Cetak"
        Me.BtnCetakAngsuran.UseVisualStyleBackColor = True
        '
        'BtnHapusAngsuran
        '
        Me.BtnHapusAngsuran.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusAngsuran.Location = New System.Drawing.Point(455, 211)
        Me.BtnHapusAngsuran.Name = "BtnHapusAngsuran"
        Me.BtnHapusAngsuran.Size = New System.Drawing.Size(81, 23)
        Me.BtnHapusAngsuran.TabIndex = 28
        Me.BtnHapusAngsuran.Text = "Hapus"
        Me.BtnHapusAngsuran.UseVisualStyleBackColor = True
        '
        'BtnSelesaiAngsuran
        '
        Me.BtnSelesaiAngsuran.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelesaiAngsuran.Location = New System.Drawing.Point(634, 206)
        Me.BtnSelesaiAngsuran.Name = "BtnSelesaiAngsuran"
        Me.BtnSelesaiAngsuran.Size = New System.Drawing.Size(99, 32)
        Me.BtnSelesaiAngsuran.TabIndex = 29
        Me.BtnSelesaiAngsuran.Text = "Selesai"
        Me.BtnSelesaiAngsuran.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FPPKK.My.Resources.Resources.LOGO_PKK_PNG
        Me.PictureBox1.Location = New System.Drawing.Point(720, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Angsuran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnSelesaiAngsuran)
        Me.Controls.Add(Me.BtnHapusAngsuran)
        Me.Controls.Add(Me.BtnCetakAngsuran)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TbxSisaBayar)
        Me.Controls.Add(Me.CbIdPinjaman)
        Me.Controls.Add(Me.BtnKembaliAngsuran)
        Me.Controls.Add(Me.BtnSimpanAngsuran)
        Me.Controls.Add(Me.DgAngsuran)
        Me.Controls.Add(Me.TanggalAngsuran)
        Me.Controls.Add(Me.TbxNominalAngsuran)
        Me.Controls.Add(Me.TbxSisaPinjam)
        Me.Controls.Add(Me.TbxCicilan)
        Me.Controls.Add(Me.TbxNmlCicilanPinjam)
        Me.Controls.Add(Me.TbxNmlPinjam)
        Me.Controls.Add(Me.TbxIdAgtAngsuran)
        Me.Controls.Add(Me.TbxKdAngsuran)
        Me.Controls.Add(Me.CbNmAgtAngsuran)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Angsuran"
        Me.Text = "Angsuran"
        CType(Me.DgAngsuran, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CbNmAgtAngsuran As ComboBox
    Friend WithEvents TbxKdAngsuran As TextBox
    Friend WithEvents TbxIdAgtAngsuran As TextBox
    Friend WithEvents TbxNmlPinjam As TextBox
    Friend WithEvents TbxNmlCicilanPinjam As TextBox
    Friend WithEvents TbxCicilan As TextBox
    Friend WithEvents TbxSisaPinjam As TextBox
    Friend WithEvents TbxNominalAngsuran As TextBox
    Friend WithEvents TanggalAngsuran As DateTimePicker
    Friend WithEvents DgAngsuran As DataGridView
    Friend WithEvents BtnSimpanAngsuran As Button
    Friend WithEvents BtnKembaliAngsuran As Button
    Friend WithEvents CbIdPinjaman As ComboBox
    Friend WithEvents TbxSisaBayar As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnCetakAngsuran As Button
    Friend WithEvents BtnHapusAngsuran As Button
    Friend WithEvents BtnSelesaiAngsuran As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
