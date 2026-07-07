<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpananSukarela
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbxKdSimpananSK = New System.Windows.Forms.TextBox()
        Me.TbxIdAnggotaSK = New System.Windows.Forms.TextBox()
        Me.TbxNominalSK = New System.Windows.Forms.TextBox()
        Me.TbxSaldoSK = New System.Windows.Forms.TextBox()
        Me.TanggalSimpananSK = New System.Windows.Forms.DateTimePicker()
        Me.CbNamaAnggotaSK = New System.Windows.Forms.ComboBox()
        Me.DgSimpananSK = New System.Windows.Forms.DataGridView()
        Me.BtnSimpanSK = New System.Windows.Forms.Button()
        Me.BtnKembaliSK = New System.Windows.Forms.Button()
        Me.BtnHapusSK = New System.Windows.Forms.Button()
        Me.BtnCetakSK = New System.Windows.Forms.Button()
        Me.BtnSelesaiSK = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DgSimpananSK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Anggota Simpanan Sukarela"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode Simpanan Sukarela"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Id Anggota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Anggota"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(424, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(424, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nominal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(485, 416)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Saldo"
        '
        'TbxKdSimpananSK
        '
        Me.TbxKdSimpananSK.Location = New System.Drawing.Point(206, 77)
        Me.TbxKdSimpananSK.Name = "TbxKdSimpananSK"
        Me.TbxKdSimpananSK.Size = New System.Drawing.Size(158, 20)
        Me.TbxKdSimpananSK.TabIndex = 7
        '
        'TbxIdAnggotaSK
        '
        Me.TbxIdAnggotaSK.Location = New System.Drawing.Point(206, 109)
        Me.TbxIdAnggotaSK.Name = "TbxIdAnggotaSK"
        Me.TbxIdAnggotaSK.Size = New System.Drawing.Size(158, 20)
        Me.TbxIdAnggotaSK.TabIndex = 8
        '
        'TbxNominalSK
        '
        Me.TbxNominalSK.Location = New System.Drawing.Point(504, 109)
        Me.TbxNominalSK.Name = "TbxNominalSK"
        Me.TbxNominalSK.Size = New System.Drawing.Size(200, 20)
        Me.TbxNominalSK.TabIndex = 9
        '
        'TbxSaldoSK
        '
        Me.TbxSaldoSK.Location = New System.Drawing.Point(555, 413)
        Me.TbxSaldoSK.Name = "TbxSaldoSK"
        Me.TbxSaldoSK.Size = New System.Drawing.Size(158, 20)
        Me.TbxSaldoSK.TabIndex = 10
        '
        'TanggalSimpananSK
        '
        Me.TanggalSimpananSK.Location = New System.Drawing.Point(504, 70)
        Me.TanggalSimpananSK.Name = "TanggalSimpananSK"
        Me.TanggalSimpananSK.Size = New System.Drawing.Size(200, 20)
        Me.TanggalSimpananSK.TabIndex = 11
        '
        'CbNamaAnggotaSK
        '
        Me.CbNamaAnggotaSK.FormattingEnabled = True
        Me.CbNamaAnggotaSK.Location = New System.Drawing.Point(206, 142)
        Me.CbNamaAnggotaSK.Name = "CbNamaAnggotaSK"
        Me.CbNamaAnggotaSK.Size = New System.Drawing.Size(158, 21)
        Me.CbNamaAnggotaSK.TabIndex = 12
        '
        'DgSimpananSK
        '
        Me.DgSimpananSK.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DgSimpananSK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgSimpananSK.Location = New System.Drawing.Point(53, 187)
        Me.DgSimpananSK.Name = "DgSimpananSK"
        Me.DgSimpananSK.Size = New System.Drawing.Size(702, 208)
        Me.DgSimpananSK.TabIndex = 13
        '
        'BtnSimpanSK
        '
        Me.BtnSimpanSK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpanSK.Location = New System.Drawing.Point(427, 142)
        Me.BtnSimpanSK.Name = "BtnSimpanSK"
        Me.BtnSimpanSK.Size = New System.Drawing.Size(83, 23)
        Me.BtnSimpanSK.TabIndex = 14
        Me.BtnSimpanSK.Text = "Simpan"
        Me.BtnSimpanSK.UseVisualStyleBackColor = True
        '
        'BtnKembaliSK
        '
        Me.BtnKembaliSK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembaliSK.Location = New System.Drawing.Point(67, 410)
        Me.BtnKembaliSK.Name = "BtnKembaliSK"
        Me.BtnKembaliSK.Size = New System.Drawing.Size(98, 23)
        Me.BtnKembaliSK.TabIndex = 15
        Me.BtnKembaliSK.Text = "Kembali"
        Me.BtnKembaliSK.UseVisualStyleBackColor = True
        '
        'BtnHapusSK
        '
        Me.BtnHapusSK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapusSK.Location = New System.Drawing.Point(516, 142)
        Me.BtnHapusSK.Name = "BtnHapusSK"
        Me.BtnHapusSK.Size = New System.Drawing.Size(79, 23)
        Me.BtnHapusSK.TabIndex = 16
        Me.BtnHapusSK.Text = "Hapus"
        Me.BtnHapusSK.UseVisualStyleBackColor = True
        '
        'BtnCetakSK
        '
        Me.BtnCetakSK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCetakSK.Location = New System.Drawing.Point(601, 142)
        Me.BtnCetakSK.Name = "BtnCetakSK"
        Me.BtnCetakSK.Size = New System.Drawing.Size(79, 23)
        Me.BtnCetakSK.TabIndex = 17
        Me.BtnCetakSK.Text = "Cetak"
        Me.BtnCetakSK.UseVisualStyleBackColor = True
        '
        'BtnSelesaiSK
        '
        Me.BtnSelesaiSK.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelesaiSK.Location = New System.Drawing.Point(686, 132)
        Me.BtnSelesaiSK.Name = "BtnSelesaiSK"
        Me.BtnSelesaiSK.Size = New System.Drawing.Size(83, 38)
        Me.BtnSelesaiSK.TabIndex = 18
        Me.BtnSelesaiSK.Text = "Selesai"
        Me.BtnSelesaiSK.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FPPKK.My.Resources.Resources.LOGO_PKK_PNG
        Me.PictureBox1.Location = New System.Drawing.Point(725, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'SimpananSukarela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnSelesaiSK)
        Me.Controls.Add(Me.BtnCetakSK)
        Me.Controls.Add(Me.BtnHapusSK)
        Me.Controls.Add(Me.BtnKembaliSK)
        Me.Controls.Add(Me.BtnSimpanSK)
        Me.Controls.Add(Me.DgSimpananSK)
        Me.Controls.Add(Me.CbNamaAnggotaSK)
        Me.Controls.Add(Me.TanggalSimpananSK)
        Me.Controls.Add(Me.TbxSaldoSK)
        Me.Controls.Add(Me.TbxNominalSK)
        Me.Controls.Add(Me.TbxIdAnggotaSK)
        Me.Controls.Add(Me.TbxKdSimpananSK)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SimpananSukarela"
        Me.Text = "SimpananSukarela"
        CType(Me.DgSimpananSK, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TbxKdSimpananSK As TextBox
    Friend WithEvents TbxIdAnggotaSK As TextBox
    Friend WithEvents TbxNominalSK As TextBox
    Friend WithEvents TbxSaldoSK As TextBox
    Friend WithEvents TanggalSimpananSK As DateTimePicker
    Friend WithEvents CbNamaAnggotaSK As ComboBox
    Friend WithEvents DgSimpananSK As DataGridView
    Friend WithEvents BtnSimpanSK As Button
    Friend WithEvents BtnKembaliSK As Button
    Friend WithEvents BtnHapusSK As Button
    Friend WithEvents BtnCetakSK As Button
    Friend WithEvents BtnSelesaiSK As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
