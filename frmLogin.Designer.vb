<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmLogin
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblSenha As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.chkAlterar = New System.Windows.Forms.CheckBox()
        Me.txtConfirmaNovaSenha = New System.Windows.Forms.TextBox()
        Me.lblConfirmaNovaSenha = New System.Windows.Forms.Label()
        Me.txtNovaSenha = New System.Windows.Forms.TextBox()
        Me.lblNovaSenha = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 1)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'lblUsuario
        '
        Me.lblUsuario.Location = New System.Drawing.Point(172, 14)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(220, 23)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "&Usuário"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSenha
        '
        Me.lblSenha.Location = New System.Drawing.Point(172, 54)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(220, 16)
        Me.lblSenha.TabIndex = 2
        Me.lblSenha.Text = "&Senha"
        Me.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(172, 35)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(220, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(172, 71)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(220, 20)
        Me.txtSenha.TabIndex = 1
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(197, 168)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(300, 168)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        '
        'chkAlterar
        '
        Me.chkAlterar.AutoSize = True
        Me.chkAlterar.Location = New System.Drawing.Point(174, 1)
        Me.chkAlterar.Name = "chkAlterar"
        Me.chkAlterar.Size = New System.Drawing.Size(119, 17)
        Me.chkAlterar.TabIndex = 6
        Me.chkAlterar.Text = "Alterar minha senha"
        Me.chkAlterar.UseVisualStyleBackColor = True
        '
        'txtConfirmaNovaSenha
        '
        Me.txtConfirmaNovaSenha.Location = New System.Drawing.Point(171, 143)
        Me.txtConfirmaNovaSenha.Name = "txtConfirmaNovaSenha"
        Me.txtConfirmaNovaSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmaNovaSenha.Size = New System.Drawing.Size(220, 20)
        Me.txtConfirmaNovaSenha.TabIndex = 3
        '
        'lblConfirmaNovaSenha
        '
        Me.lblConfirmaNovaSenha.Location = New System.Drawing.Point(172, 127)
        Me.lblConfirmaNovaSenha.Name = "lblConfirmaNovaSenha"
        Me.lblConfirmaNovaSenha.Size = New System.Drawing.Size(220, 14)
        Me.lblConfirmaNovaSenha.TabIndex = 7
        Me.lblConfirmaNovaSenha.Text = "&Confirma Nova Senha"
        Me.lblConfirmaNovaSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNovaSenha
        '
        Me.txtNovaSenha.Location = New System.Drawing.Point(172, 107)
        Me.txtNovaSenha.Name = "txtNovaSenha"
        Me.txtNovaSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNovaSenha.Size = New System.Drawing.Size(220, 20)
        Me.txtNovaSenha.TabIndex = 2
        '
        'lblNovaSenha
        '
        Me.lblNovaSenha.Location = New System.Drawing.Point(172, 90)
        Me.lblNovaSenha.Name = "lblNovaSenha"
        Me.lblNovaSenha.Size = New System.Drawing.Size(80, 15)
        Me.lblNovaSenha.TabIndex = 9
        Me.lblNovaSenha.Text = "&Nova Senha"
        Me.lblNovaSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmLogin
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(401, 192)
        Me.Controls.Add(Me.txtConfirmaNovaSenha)
        Me.Controls.Add(Me.lblConfirmaNovaSenha)
        Me.Controls.Add(Me.chkAlterar)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.txtNovaSenha)
        Me.Controls.Add(Me.lblNovaSenha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkAlterar As System.Windows.Forms.CheckBox
    Friend WithEvents txtConfirmaNovaSenha As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmaNovaSenha As System.Windows.Forms.Label
    Friend WithEvents txtNovaSenha As System.Windows.Forms.TextBox
    Friend WithEvents lblNovaSenha As System.Windows.Forms.Label

End Class
