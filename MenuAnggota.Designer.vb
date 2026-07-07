<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAnggota
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
        Me.BtnLaporanAnggota = New System.Windows.Forms.Button()
        Me.BtnKembaliMenuAnggota = New System.Windows.Forms.Button()
        Me.BtnLogoutAnggota = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu Laporan Anggota"
        '
        'BtnLaporanAnggota
        '
        Me.BtnLaporanAnggota.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaporanAnggota.Location = New System.Drawing.Point(167, 148)
        Me.BtnLaporanAnggota.Name = "BtnLaporanAnggota"
        Me.BtnLaporanAnggota.Size = New System.Drawing.Size(170, 41)
        Me.BtnLaporanAnggota.TabIndex = 1
        Me.BtnLaporanAnggota.Text = "Lihat Laporan"
        Me.BtnLaporanAnggota.UseVisualStyleBackColor = True
        '
        'BtnKembaliMenuAnggota
        '
        Me.BtnKembaliMenuAnggota.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembaliMenuAnggota.Location = New System.Drawing.Point(12, 393)
        Me.BtnKembaliMenuAnggota.Name = "BtnKembaliMenuAnggota"
        Me.BtnKembaliMenuAnggota.Size = New System.Drawing.Size(107, 25)
        Me.BtnKembaliMenuAnggota.TabIndex = 2
        Me.BtnKembaliMenuAnggota.Text = "Kembali"
        Me.BtnKembaliMenuAnggota.UseVisualStyleBackColor = True
        '
        'BtnLogoutAnggota
        '
        Me.BtnLogoutAnggota.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogoutAnggota.Location = New System.Drawing.Point(167, 215)
        Me.BtnLogoutAnggota.Name = "BtnLogoutAnggota"
        Me.BtnLogoutAnggota.Size = New System.Drawing.Size(170, 42)
        Me.BtnLogoutAnggota.TabIndex = 3
        Me.BtnLogoutAnggota.Text = "Log Out"
        Me.BtnLogoutAnggota.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FPPKK.My.Resources.Resources.LOGO_PKK_PNG
        Me.PictureBox1.Location = New System.Drawing.Point(423, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'MenuAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(516, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnLogoutAnggota)
        Me.Controls.Add(Me.BtnKembaliMenuAnggota)
        Me.Controls.Add(Me.BtnLaporanAnggota)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuAnggota"
        Me.Text = "Menu Anggota"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLaporanAnggota As Button
    Friend WithEvents BtnKembaliMenuAnggota As Button
    Friend WithEvents BtnLogoutAnggota As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
