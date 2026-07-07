<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPengawas
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
        Me.TbxUsnPengawas = New System.Windows.Forms.TextBox()
        Me.TbxPassPengawas = New System.Windows.Forms.TextBox()
        Me.BtnLoginPengawas = New System.Windows.Forms.Button()
        Me.BtnKembaliPengawas = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pengawas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FPPKK.My.Resources.Resources.LOGO_PKK_PNG
        Me.PictureBox1.Location = New System.Drawing.Point(196, 29)
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
        Me.Label2.Location = New System.Drawing.Point(128, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(128, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password :"
        '
        'TbxUsnPengawas
        '
        Me.TbxUsnPengawas.Location = New System.Drawing.Point(227, 215)
        Me.TbxUsnPengawas.Name = "TbxUsnPengawas"
        Me.TbxUsnPengawas.Size = New System.Drawing.Size(131, 20)
        Me.TbxUsnPengawas.TabIndex = 4
        '
        'TbxPassPengawas
        '
        Me.TbxPassPengawas.Location = New System.Drawing.Point(227, 251)
        Me.TbxPassPengawas.Name = "TbxPassPengawas"
        Me.TbxPassPengawas.Size = New System.Drawing.Size(131, 20)
        Me.TbxPassPengawas.TabIndex = 5
        '
        'BtnLoginPengawas
        '
        Me.BtnLoginPengawas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoginPengawas.Location = New System.Drawing.Point(182, 321)
        Me.BtnLoginPengawas.Name = "BtnLoginPengawas"
        Me.BtnLoginPengawas.Size = New System.Drawing.Size(99, 30)
        Me.BtnLoginPengawas.TabIndex = 6
        Me.BtnLoginPengawas.Text = "Login"
        Me.BtnLoginPengawas.UseVisualStyleBackColor = True
        '
        'BtnKembaliPengawas
        '
        Me.BtnKembaliPengawas.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembaliPengawas.Location = New System.Drawing.Point(12, 398)
        Me.BtnKembaliPengawas.Name = "BtnKembaliPengawas"
        Me.BtnKembaliPengawas.Size = New System.Drawing.Size(83, 28)
        Me.BtnKembaliPengawas.TabIndex = 7
        Me.BtnKembaliPengawas.Text = "Kembali"
        Me.BtnKembaliPengawas.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(172, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Sistem Informasi PKK"
        '
        'LoginPengawas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(516, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnKembaliPengawas)
        Me.Controls.Add(Me.BtnLoginPengawas)
        Me.Controls.Add(Me.TbxPassPengawas)
        Me.Controls.Add(Me.TbxUsnPengawas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LoginPengawas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginPengawas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbxUsnPengawas As TextBox
    Friend WithEvents TbxPassPengawas As TextBox
    Friend WithEvents BtnLoginPengawas As Button
    Friend WithEvents BtnKembaliPengawas As Button
    Friend WithEvents Label4 As Label
End Class
