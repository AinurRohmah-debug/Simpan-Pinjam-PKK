<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahAnggota
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
        Me.CbIdAnggota = New System.Windows.Forms.ComboBox()
        Me.TbxNamaAnggota = New System.Windows.Forms.TextBox()
        Me.TbxNoTelp = New System.Windows.Forms.TextBox()
        Me.TbxEmail = New System.Windows.Forms.TextBox()
        Me.DgAnggota = New System.Windows.Forms.DataGridView()
        Me.BtnSimpanAgt = New System.Windows.Forms.Button()
        Me.BtnKembaliAgt = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbxAlamat = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DgAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Anggota"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Id Anggota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Anggota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(383, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No. Telepon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(389, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email"
        '
        'CbIdAnggota
        '
        Me.CbIdAnggota.FormattingEnabled = True
        Me.CbIdAnggota.Location = New System.Drawing.Point(153, 72)
        Me.CbIdAnggota.Name = "CbIdAnggota"
        Me.CbIdAnggota.Size = New System.Drawing.Size(167, 21)
        Me.CbIdAnggota.TabIndex = 5
        '
        'TbxNamaAnggota
        '
        Me.TbxNamaAnggota.Location = New System.Drawing.Point(153, 108)
        Me.TbxNamaAnggota.Name = "TbxNamaAnggota"
        Me.TbxNamaAnggota.Size = New System.Drawing.Size(167, 20)
        Me.TbxNamaAnggota.TabIndex = 6
        '
        'TbxNoTelp
        '
        Me.TbxNoTelp.Location = New System.Drawing.Point(471, 73)
        Me.TbxNoTelp.Name = "TbxNoTelp"
        Me.TbxNoTelp.Size = New System.Drawing.Size(167, 20)
        Me.TbxNoTelp.TabIndex = 7
        '
        'TbxEmail
        '
        Me.TbxEmail.Location = New System.Drawing.Point(471, 122)
        Me.TbxEmail.Name = "TbxEmail"
        Me.TbxEmail.Size = New System.Drawing.Size(167, 20)
        Me.TbxEmail.TabIndex = 8
        '
        'DgAnggota
        '
        Me.DgAnggota.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DgAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgAnggota.Location = New System.Drawing.Point(60, 205)
        Me.DgAnggota.Name = "DgAnggota"
        Me.DgAnggota.Size = New System.Drawing.Size(578, 206)
        Me.DgAnggota.TabIndex = 9
        '
        'BtnSimpanAgt
        '
        Me.BtnSimpanAgt.BackColor = System.Drawing.Color.White
        Me.BtnSimpanAgt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpanAgt.Location = New System.Drawing.Point(386, 161)
        Me.BtnSimpanAgt.Name = "BtnSimpanAgt"
        Me.BtnSimpanAgt.Size = New System.Drawing.Size(79, 23)
        Me.BtnSimpanAgt.TabIndex = 10
        Me.BtnSimpanAgt.Text = "Simpan"
        Me.BtnSimpanAgt.UseVisualStyleBackColor = False
        '
        'BtnKembaliAgt
        '
        Me.BtnKembaliAgt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembaliAgt.Location = New System.Drawing.Point(60, 433)
        Me.BtnKembaliAgt.Name = "BtnKembaliAgt"
        Me.BtnKembaliAgt.Size = New System.Drawing.Size(75, 23)
        Me.BtnKembaliAgt.TabIndex = 11
        Me.BtnKembaliAgt.Text = "Kembali"
        Me.BtnKembaliAgt.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Location = New System.Drawing.Point(471, 161)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(79, 23)
        Me.BtnEdit.TabIndex = 12
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(559, 161)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(79, 23)
        Me.BtnHapus.TabIndex = 13
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(57, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Alamat"
        '
        'TbxAlamat
        '
        Me.TbxAlamat.Location = New System.Drawing.Point(153, 154)
        Me.TbxAlamat.Name = "TbxAlamat"
        Me.TbxAlamat.Size = New System.Drawing.Size(167, 20)
        Me.TbxAlamat.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FPPKK.My.Resources.Resources.LOGO_PKK_PNG
        Me.PictureBox1.Location = New System.Drawing.Point(29, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'TambahAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(714, 468)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TbxAlamat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnKembaliAgt)
        Me.Controls.Add(Me.BtnSimpanAgt)
        Me.Controls.Add(Me.DgAnggota)
        Me.Controls.Add(Me.TbxEmail)
        Me.Controls.Add(Me.TbxNoTelp)
        Me.Controls.Add(Me.TbxNamaAnggota)
        Me.Controls.Add(Me.CbIdAnggota)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahAnggota"
        Me.Text = "TambahAnggota"
        CType(Me.DgAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CbIdAnggota As ComboBox
    Friend WithEvents TbxNamaAnggota As TextBox
    Friend WithEvents TbxNoTelp As TextBox
    Friend WithEvents TbxEmail As TextBox
    Friend WithEvents DgAnggota As DataGridView
    Friend WithEvents BtnSimpanAgt As Button
    Friend WithEvents BtnKembaliAgt As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TbxAlamat As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
