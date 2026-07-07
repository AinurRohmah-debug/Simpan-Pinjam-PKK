<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuLaporanBendahara
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
        Me.BtnLaporanPKKBen = New System.Windows.Forms.Button()
        Me.BtnLaporanAnggotaBen = New System.Windows.Forms.Button()
        Me.BtnKembaliLaporanBen = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnLogotLprnBdhr = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Laporan Bendahara"
        '
        'BtnLaporanPKKBen
        '
        Me.BtnLaporanPKKBen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaporanPKKBen.Location = New System.Drawing.Point(165, 160)
        Me.BtnLaporanPKKBen.Name = "BtnLaporanPKKBen"
        Me.BtnLaporanPKKBen.Size = New System.Drawing.Size(181, 47)
        Me.BtnLaporanPKKBen.TabIndex = 1
        Me.BtnLaporanPKKBen.Text = "Laporan Keuangan PKK"
        Me.BtnLaporanPKKBen.UseVisualStyleBackColor = True
        '
        'BtnLaporanAnggotaBen
        '
        Me.BtnLaporanAnggotaBen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaporanAnggotaBen.Location = New System.Drawing.Point(165, 234)
        Me.BtnLaporanAnggotaBen.Name = "BtnLaporanAnggotaBen"
        Me.BtnLaporanAnggotaBen.Size = New System.Drawing.Size(181, 48)
        Me.BtnLaporanAnggotaBen.TabIndex = 2
        Me.BtnLaporanAnggotaBen.Text = "Laporan Keuangan " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Anggota"
        Me.BtnLaporanAnggotaBen.UseVisualStyleBackColor = True
        '
        'BtnKembaliLaporanBen
        '
        Me.BtnKembaliLaporanBen.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembaliLaporanBen.Location = New System.Drawing.Point(12, 399)
        Me.BtnKembaliLaporanBen.Name = "BtnKembaliLaporanBen"
        Me.BtnKembaliLaporanBen.Size = New System.Drawing.Size(98, 24)
        Me.BtnKembaliLaporanBen.TabIndex = 3
        Me.BtnKembaliLaporanBen.Text = "Kembali"
        Me.BtnKembaliLaporanBen.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FPPKK.My.Resources.Resources.LOGO_PKK_PNG
        Me.PictureBox1.Location = New System.Drawing.Point(431, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'BtnLogotLprnBdhr
        '
        Me.BtnLogotLprnBdhr.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogotLprnBdhr.Location = New System.Drawing.Point(165, 305)
        Me.BtnLogotLprnBdhr.Name = "BtnLogotLprnBdhr"
        Me.BtnLogotLprnBdhr.Size = New System.Drawing.Size(181, 41)
        Me.BtnLogotLprnBdhr.TabIndex = 5
        Me.BtnLogotLprnBdhr.Text = "Log Out"
        Me.BtnLogotLprnBdhr.UseVisualStyleBackColor = True
        '
        'MenuLaporanBendahara
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(516, 450)
        Me.Controls.Add(Me.BtnLogotLprnBdhr)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnKembaliLaporanBen)
        Me.Controls.Add(Me.BtnLaporanAnggotaBen)
        Me.Controls.Add(Me.BtnLaporanPKKBen)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuLaporanBendahara"
        Me.Text = "MenuLaporanBendahara"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLaporanPKKBen As Button
    Friend WithEvents BtnLaporanAnggotaBen As Button
    Friend WithEvents BtnKembaliLaporanBen As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnLogotLprnBdhr As Button
End Class
