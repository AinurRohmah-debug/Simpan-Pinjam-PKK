<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuLogin
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
        Me.BtnBendahara = New System.Windows.Forms.Button()
        Me.BtnPengawas = New System.Windows.Forms.Button()
        Me.BtnAnggota = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(296, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(161, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 48)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SISTEM INFORMASI PKK " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       DESA SIDOTOPO"
        '
        'BtnBendahara
        '
        Me.BtnBendahara.BackColor = System.Drawing.Color.White
        Me.BtnBendahara.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBendahara.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnBendahara.Location = New System.Drawing.Point(185, 185)
        Me.BtnBendahara.Name = "BtnBendahara"
        Me.BtnBendahara.Size = New System.Drawing.Size(127, 28)
        Me.BtnBendahara.TabIndex = 2
        Me.BtnBendahara.Text = "BENDAHARA"
        Me.BtnBendahara.UseVisualStyleBackColor = False
        '
        'BtnPengawas
        '
        Me.BtnPengawas.BackColor = System.Drawing.Color.White
        Me.BtnPengawas.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPengawas.Location = New System.Drawing.Point(185, 279)
        Me.BtnPengawas.Name = "BtnPengawas"
        Me.BtnPengawas.Size = New System.Drawing.Size(127, 28)
        Me.BtnPengawas.TabIndex = 3
        Me.BtnPengawas.Text = "PENGAWAS"
        Me.BtnPengawas.UseVisualStyleBackColor = False
        '
        'BtnAnggota
        '
        Me.BtnAnggota.BackColor = System.Drawing.Color.White
        Me.BtnAnggota.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnggota.Location = New System.Drawing.Point(185, 234)
        Me.BtnAnggota.Name = "BtnAnggota"
        Me.BtnAnggota.Size = New System.Drawing.Size(127, 26)
        Me.BtnAnggota.TabIndex = 4
        Me.BtnAnggota.Text = "ANGGOTA"
        Me.BtnAnggota.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(170, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Pilih Jenis Akses Login!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FPPKK.My.Resources.Resources.LOGO_PKK_PNG
        Me.PictureBox1.Location = New System.Drawing.Point(77, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'MenuLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(516, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnAnggota)
        Me.Controls.Add(Me.BtnPengawas)
        Me.Controls.Add(Me.BtnBendahara)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuLogin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnBendahara As Button
    Friend WithEvents BtnPengawas As Button
    Friend WithEvents BtnAnggota As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
