<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuSimpanan
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
        Me.BtnSimpanWjb = New System.Windows.Forms.Button()
        Me.BtnSimpanSK = New System.Windows.Forms.Button()
        Me.BtnSimpanPinjam = New System.Windows.Forms.Button()
        Me.BtnAngsuran = New System.Windows.Forms.Button()
        Me.BtnLaporanBendahara = New System.Windows.Forms.Button()
        Me.BtbTambahAnggota = New System.Windows.Forms.Button()
        Me.BtnLogBendahara = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSimpanWjb
        '
        Me.BtnSimpanWjb.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpanWjb.Location = New System.Drawing.Point(90, 203)
        Me.BtnSimpanWjb.Name = "BtnSimpanWjb"
        Me.BtnSimpanWjb.Size = New System.Drawing.Size(133, 36)
        Me.BtnSimpanWjb.TabIndex = 1
        Me.BtnSimpanWjb.Text = "Simpanan Wajib"
        Me.BtnSimpanWjb.UseVisualStyleBackColor = True
        '
        'BtnSimpanSK
        '
        Me.BtnSimpanSK.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpanSK.Location = New System.Drawing.Point(90, 260)
        Me.BtnSimpanSK.Name = "BtnSimpanSK"
        Me.BtnSimpanSK.Size = New System.Drawing.Size(133, 36)
        Me.BtnSimpanSK.TabIndex = 2
        Me.BtnSimpanSK.Text = "Simpanan Sukarela"
        Me.BtnSimpanSK.UseVisualStyleBackColor = True
        '
        'BtnSimpanPinjam
        '
        Me.BtnSimpanPinjam.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpanPinjam.Location = New System.Drawing.Point(271, 148)
        Me.BtnSimpanPinjam.Name = "BtnSimpanPinjam"
        Me.BtnSimpanPinjam.Size = New System.Drawing.Size(133, 38)
        Me.BtnSimpanPinjam.TabIndex = 3
        Me.BtnSimpanPinjam.Text = "Pinjaman"
        Me.BtnSimpanPinjam.UseVisualStyleBackColor = True
        '
        'BtnAngsuran
        '
        Me.BtnAngsuran.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAngsuran.Location = New System.Drawing.Point(271, 203)
        Me.BtnAngsuran.Name = "BtnAngsuran"
        Me.BtnAngsuran.Size = New System.Drawing.Size(133, 36)
        Me.BtnAngsuran.TabIndex = 4
        Me.BtnAngsuran.Text = "Angsuran"
        Me.BtnAngsuran.UseVisualStyleBackColor = True
        '
        'BtnLaporanBendahara
        '
        Me.BtnLaporanBendahara.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaporanBendahara.Location = New System.Drawing.Point(271, 260)
        Me.BtnLaporanBendahara.Name = "BtnLaporanBendahara"
        Me.BtnLaporanBendahara.Size = New System.Drawing.Size(133, 36)
        Me.BtnLaporanBendahara.TabIndex = 5
        Me.BtnLaporanBendahara.Text = "Laporan"
        Me.BtnLaporanBendahara.UseVisualStyleBackColor = True
        '
        'BtbTambahAnggota
        '
        Me.BtbTambahAnggota.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtbTambahAnggota.Location = New System.Drawing.Point(90, 148)
        Me.BtbTambahAnggota.Name = "BtbTambahAnggota"
        Me.BtbTambahAnggota.Size = New System.Drawing.Size(133, 38)
        Me.BtbTambahAnggota.TabIndex = 6
        Me.BtbTambahAnggota.Text = "Tambah Anggota"
        Me.BtbTambahAnggota.UseVisualStyleBackColor = True
        '
        'BtnLogBendahara
        '
        Me.BtnLogBendahara.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogBendahara.Location = New System.Drawing.Point(169, 330)
        Me.BtnLogBendahara.Name = "BtnLogBendahara"
        Me.BtnLogBendahara.Size = New System.Drawing.Size(149, 33)
        Me.BtnLogBendahara.TabIndex = 7
        Me.BtnLogBendahara.Text = "Log Out"
        Me.BtnLogBendahara.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FPPKK.My.Resources.Resources.LOGO_PKK_PNG
        Me.PictureBox1.Location = New System.Drawing.Point(80, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Sistem Informasi PKK"
        '
        'MenuSimpanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(516, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnLogBendahara)
        Me.Controls.Add(Me.BtbTambahAnggota)
        Me.Controls.Add(Me.BtnLaporanBendahara)
        Me.Controls.Add(Me.BtnAngsuran)
        Me.Controls.Add(Me.BtnSimpanPinjam)
        Me.Controls.Add(Me.BtnSimpanSK)
        Me.Controls.Add(Me.BtnSimpanWjb)
        Me.Name = "MenuSimpanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuSimpanan"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSimpanWjb As Button
    Friend WithEvents BtnSimpanSK As Button
    Friend WithEvents BtnSimpanPinjam As Button
    Friend WithEvents BtnAngsuran As Button
    Friend WithEvents BtnLaporanBendahara As Button
    Friend WithEvents BtbTambahAnggota As Button
    Friend WithEvents BtnLogBendahara As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
