<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LaporanAnggota
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
        Me.CbIdAnggotaLaporan = New System.Windows.Forms.ComboBox()
        Me.BtnCetakLaporanAgt = New System.Windows.Forms.Button()
        Me.BtnLogoutLaporanAgt = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbxNmAgtLaporan = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Laporan Keuangan Anggota"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Id Anggota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Silahkan Pilih Id Anggota"
        '
        'CbIdAnggotaLaporan
        '
        Me.CbIdAnggotaLaporan.FormattingEnabled = True
        Me.CbIdAnggotaLaporan.Location = New System.Drawing.Point(170, 146)
        Me.CbIdAnggotaLaporan.Name = "CbIdAnggotaLaporan"
        Me.CbIdAnggotaLaporan.Size = New System.Drawing.Size(156, 21)
        Me.CbIdAnggotaLaporan.TabIndex = 3
        '
        'BtnCetakLaporanAgt
        '
        Me.BtnCetakLaporanAgt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCetakLaporanAgt.Location = New System.Drawing.Point(310, 235)
        Me.BtnCetakLaporanAgt.Name = "BtnCetakLaporanAgt"
        Me.BtnCetakLaporanAgt.Size = New System.Drawing.Size(93, 31)
        Me.BtnCetakLaporanAgt.TabIndex = 4
        Me.BtnCetakLaporanAgt.Text = "Cetak"
        Me.BtnCetakLaporanAgt.UseVisualStyleBackColor = True
        '
        'BtnLogoutLaporanAgt
        '
        Me.BtnLogoutLaporanAgt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogoutLaporanAgt.Location = New System.Drawing.Point(22, 398)
        Me.BtnLogoutLaporanAgt.Name = "BtnLogoutLaporanAgt"
        Me.BtnLogoutLaporanAgt.Size = New System.Drawing.Size(93, 26)
        Me.BtnLogoutLaporanAgt.TabIndex = 5
        Me.BtnLogoutLaporanAgt.Text = "Log Out"
        Me.BtnLogoutLaporanAgt.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nama Anggota"
        '
        'TbxNmAgtLaporan
        '
        Me.TbxNmAgtLaporan.Location = New System.Drawing.Point(170, 197)
        Me.TbxNmAgtLaporan.Name = "TbxNmAgtLaporan"
        Me.TbxNmAgtLaporan.Size = New System.Drawing.Size(156, 20)
        Me.TbxNmAgtLaporan.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FPPKK.My.Resources.Resources.LOGO_PKK_PNG
        Me.PictureBox1.Location = New System.Drawing.Point(427, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'LaporanAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(516, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TbxNmAgtLaporan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnLogoutLaporanAgt)
        Me.Controls.Add(Me.BtnCetakLaporanAgt)
        Me.Controls.Add(Me.CbIdAnggotaLaporan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LaporanAnggota"
        Me.Text = "LaporanAnggota"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CbIdAnggotaLaporan As ComboBox
    Friend WithEvents BtnCetakLaporanAgt As Button
    Friend WithEvents BtnLogoutLaporanAgt As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TbxNmAgtLaporan As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
