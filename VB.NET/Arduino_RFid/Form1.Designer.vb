<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.txtTag = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLer = New System.Windows.Forms.Button()
        Me.txtEmail1 = New System.Windows.Forms.TextBox()
        Me.txtNome1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnDesconectar = New System.Windows.Forms.Button()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.cboTaxa = New System.Windows.Forms.ComboBox()
        Me.cboPorta = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tmrGravarPessoa = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBuscarPessoa = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSalvar)
        Me.GroupBox1.Controls.Add(Me.txtTag)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 255)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cadastrar Tag"
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(68, 197)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(82, 39)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'txtTag
        '
        Me.txtTag.Enabled = False
        Me.txtTag.Location = New System.Drawing.Point(18, 156)
        Me.txtTag.MaxLength = 6
        Me.txtTag.Name = "txtTag"
        Me.txtTag.Size = New System.Drawing.Size(109, 20)
        Me.txtTag.TabIndex = 6
        Me.txtTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(18, 103)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(204, 20)
        Me.txtEmail.TabIndex = 5
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(18, 45)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(204, 20)
        Me.txtNome.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tag:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLer)
        Me.GroupBox2.Controls.Add(Me.txtEmail1)
        Me.GroupBox2.Controls.Add(Me.txtNome1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(259, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 255)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ler Tag"
        '
        'btnLer
        '
        Me.btnLer.Location = New System.Drawing.Point(83, 197)
        Me.btnLer.Name = "btnLer"
        Me.btnLer.Size = New System.Drawing.Size(82, 39)
        Me.btnLer.TabIndex = 12
        Me.btnLer.Text = "Ler"
        Me.btnLer.UseVisualStyleBackColor = True
        '
        'txtEmail1
        '
        Me.txtEmail1.Enabled = False
        Me.txtEmail1.Location = New System.Drawing.Point(21, 103)
        Me.txtEmail1.Name = "txtEmail1"
        Me.txtEmail1.Size = New System.Drawing.Size(204, 20)
        Me.txtEmail1.TabIndex = 11
        '
        'txtNome1
        '
        Me.txtNome1.Enabled = False
        Me.txtNome1.Location = New System.Drawing.Point(21, 45)
        Me.txtNome1.Name = "txtNome1"
        Me.txtNome1.Size = New System.Drawing.Size(204, 20)
        Me.txtNome1.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nome:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblStatus)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 396)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(486, 81)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Status:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblStatus.Location = New System.Drawing.Point(15, 39)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(55, 13)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "aguarde..."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SerialPort1
        '
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnDesconectar)
        Me.GroupBox4.Controls.Add(Me.btnConectar)
        Me.GroupBox4.Controls.Add(Me.cboTaxa)
        Me.GroupBox4.Controls.Add(Me.cboPorta)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(495, 100)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Configuração da Serial"
        '
        'btnDesconectar
        '
        Me.btnDesconectar.Location = New System.Drawing.Point(357, 64)
        Me.btnDesconectar.Name = "btnDesconectar"
        Me.btnDesconectar.Size = New System.Drawing.Size(82, 30)
        Me.btnDesconectar.TabIndex = 28
        Me.btnDesconectar.Text = "Desconectar"
        Me.btnDesconectar.UseVisualStyleBackColor = True
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(357, 21)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(82, 30)
        Me.btnConectar.TabIndex = 13
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'cboTaxa
        '
        Me.cboTaxa.FormattingEnabled = True
        Me.cboTaxa.Location = New System.Drawing.Point(164, 46)
        Me.cboTaxa.Name = "cboTaxa"
        Me.cboTaxa.Size = New System.Drawing.Size(121, 21)
        Me.cboTaxa.TabIndex = 27
        '
        'cboPorta
        '
        Me.cboPorta.FormattingEnabled = True
        Me.cboPorta.Location = New System.Drawing.Point(18, 46)
        Me.cboPorta.Name = "cboPorta"
        Me.cboPorta.Size = New System.Drawing.Size(121, 21)
        Me.cboPorta.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Porta:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(161, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Taxa:"
        '
        'tmrGravarPessoa
        '
        '
        'tmrBuscarPessoa
        '
        Me.tmrBuscarPessoa.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 485)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Arduino + RFId + SQL Server"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents txtTag As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLer As System.Windows.Forms.Button
    Friend WithEvents txtEmail1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNome1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDesconectar As System.Windows.Forms.Button
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents cboTaxa As System.Windows.Forms.ComboBox
    Friend WithEvents cboPorta As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tmrGravarPessoa As System.Windows.Forms.Timer
    Friend WithEvents tmrBuscarPessoa As System.Windows.Forms.Timer

End Class
