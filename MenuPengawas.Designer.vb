<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPengawas
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
        Me.BtnLaporanPKKP = New System.Windows.Forms.Button()
        Me.BtnLaporanAnggotaP = New System.Windows.Forms.Button()
        Me.BtnLogoutPengawas = New System.Windows.Forms.Button()
        Me.BtnKembaliP = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu Pengawas"
        '
        'BtnLaporanPKKP
        '
        Me.BtnLaporanPKKP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaporanPKKP.Location = New System.Drawing.Point(158, 115)
        Me.BtnLaporanPKKP.Name = "BtnLaporanPKKP"
        Me.BtnLaporanPKKP.Size = New System.Drawing.Size(163, 45)
        Me.BtnLaporanPKKP.TabIndex = 1
        Me.BtnLaporanPKKP.Text = "Laporan Keuangan PKK"
        Me.BtnLaporanPKKP.UseVisualStyleBackColor = True
        '
        'BtnLaporanAnggotaP
        '
        Me.BtnLaporanAnggotaP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaporanAnggotaP.Location = New System.Drawing.Point(158, 189)
        Me.BtnLaporanAnggotaP.Name = "BtnLaporanAnggotaP"
        Me.BtnLaporanAnggotaP.Size = New System.Drawing.Size(163, 45)
        Me.BtnLaporanAnggotaP.TabIndex = 2
        Me.BtnLaporanAnggotaP.Text = "Laporan Keuangan " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Anggota"
        Me.BtnLaporanAnggotaP.UseVisualStyleBackColor = True
        '
        'BtnLogoutPengawas
        '
        Me.BtnLogoutPengawas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogoutPengawas.Location = New System.Drawing.Point(158, 265)
        Me.BtnLogoutPengawas.Name = "BtnLogoutPengawas"
        Me.BtnLogoutPengawas.Size = New System.Drawing.Size(163, 45)
        Me.BtnLogoutPengawas.TabIndex = 3
        Me.BtnLogoutPengawas.Text = "Log Out"
        Me.BtnLogoutPengawas.UseVisualStyleBackColor = True
        '
        'BtnKembaliP
        '
        Me.BtnKembaliP.BackColor = System.Drawing.Color.White
        Me.BtnKembaliP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembaliP.Location = New System.Drawing.Point(12, 398)
        Me.BtnKembaliP.Name = "BtnKembaliP"
        Me.BtnKembaliP.Size = New System.Drawing.Size(103, 25)
        Me.BtnKembaliP.TabIndex = 4
        Me.BtnKembaliP.Text = "Kembali"
        Me.BtnKembaliP.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FPPKK.My.Resources.Resources.LOGO_PKK_PNG
        Me.PictureBox1.Location = New System.Drawing.Point(427, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'MenuPengawas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(516, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnKembaliP)
        Me.Controls.Add(Me.BtnLogoutPengawas)
        Me.Controls.Add(Me.BtnLaporanAnggotaP)
        Me.Controls.Add(Me.BtnLaporanPKKP)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuPengawas"
        Me.Text = "MenuPengawas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLaporanPKKP As Button
    Friend WithEvents BtnLaporanAnggotaP As Button
    Friend WithEvents BtnLogoutPengawas As Button
    Friend WithEvents BtnKembaliP As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
