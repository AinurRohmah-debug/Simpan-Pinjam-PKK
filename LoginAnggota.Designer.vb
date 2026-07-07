<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginAnggota
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbxUsnAnggota = New System.Windows.Forms.TextBox()
        Me.TbxPassAnggota = New System.Windows.Forms.TextBox()
        Me.BtnLoginiAnggota = New System.Windows.Forms.Button()
        Me.BtnKembaliAnggota = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ANGGOTA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FPPKK.My.Resources.Resources.LOGO_PKK_PNG
        Me.PictureBox1.Location = New System.Drawing.Point(204, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password :"
        '
        'TbxUsnAnggota
        '
        Me.TbxUsnAnggota.Location = New System.Drawing.Point(242, 233)
        Me.TbxUsnAnggota.Name = "TbxUsnAnggota"
        Me.TbxUsnAnggota.Size = New System.Drawing.Size(138, 20)
        Me.TbxUsnAnggota.TabIndex = 4
        '
        'TbxPassAnggota
        '
        Me.TbxPassAnggota.Location = New System.Drawing.Point(242, 269)
        Me.TbxPassAnggota.Name = "TbxPassAnggota"
        Me.TbxPassAnggota.Size = New System.Drawing.Size(138, 20)
        Me.TbxPassAnggota.TabIndex = 5
        '
        'BtnLoginiAnggota
        '
        Me.BtnLoginiAnggota.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoginiAnggota.Location = New System.Drawing.Point(195, 328)
        Me.BtnLoginiAnggota.Name = "BtnLoginiAnggota"
        Me.BtnLoginiAnggota.Size = New System.Drawing.Size(94, 31)
        Me.BtnLoginiAnggota.TabIndex = 6
        Me.BtnLoginiAnggota.Text = "Login"
        Me.BtnLoginiAnggota.UseVisualStyleBackColor = True
        '
        'BtnKembaliAnggota
        '
        Me.BtnKembaliAnggota.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembaliAnggota.Location = New System.Drawing.Point(12, 400)
        Me.BtnKembaliAnggota.Name = "BtnKembaliAnggota"
        Me.BtnKembaliAnggota.Size = New System.Drawing.Size(75, 23)
        Me.BtnKembaliAnggota.TabIndex = 7
        Me.BtnKembaliAnggota.Text = "Kembali"
        Me.BtnKembaliAnggota.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(163, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Sistem Informasi PKK"
        '
        'LoginAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(516, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnKembaliAnggota)
        Me.Controls.Add(Me.BtnLoginiAnggota)
        Me.Controls.Add(Me.TbxPassAnggota)
        Me.Controls.Add(Me.TbxUsnAnggota)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LoginAnggota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginAnggota"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbxUsnAnggota As TextBox
    Friend WithEvents TbxPassAnggota As TextBox
    Friend WithEvents BtnLoginiAnggota As Button
    Friend WithEvents BtnKembaliAnggota As Button
    Friend WithEvents Label4 As Label
End Class
