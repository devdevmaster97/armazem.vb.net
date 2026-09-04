<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSenhas
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSenhas))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdSalvar = New System.Windows.Forms.Button()
        Me.cmdSair = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.CmdExcluir = New System.Windows.Forms.Button()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.cmdAlterar = New System.Windows.Forms.Button()
        Me.cmdCadastrar = New System.Windows.Forms.Button()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdSalvar
        '
        Me.cmdSalvar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSalvar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSalvar.Enabled = False
        Me.cmdSalvar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSalvar.Image = CType(resources.GetObject("cmdSalvar.Image"), System.Drawing.Image)
        Me.cmdSalvar.Location = New System.Drawing.Point(124, 12)
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSalvar.Size = New System.Drawing.Size(57, 41)
        Me.cmdSalvar.TabIndex = 2
        Me.cmdSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdSalvar, "Salvar")
        Me.cmdSalvar.UseVisualStyleBackColor = False
        '
        'cmdSair
        '
        Me.cmdSair.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSair.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdSair.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSair.Image = CType(resources.GetObject("cmdSair.Image"), System.Drawing.Image)
        Me.cmdSair.Location = New System.Drawing.Point(352, 12)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSair.Size = New System.Drawing.Size(57, 41)
        Me.cmdSair.TabIndex = 6
        Me.cmdSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdSair, "Fechar")
        Me.cmdSair.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(295, 12)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(57, 41)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdCancelar, "Cancelar")
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'CmdExcluir
        '
        Me.CmdExcluir.BackColor = System.Drawing.SystemColors.Control
        Me.CmdExcluir.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdExcluir.Enabled = False
        Me.CmdExcluir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdExcluir.Image = CType(resources.GetObject("CmdExcluir.Image"), System.Drawing.Image)
        Me.CmdExcluir.Location = New System.Drawing.Point(238, 12)
        Me.CmdExcluir.Name = "CmdExcluir"
        Me.CmdExcluir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdExcluir.Size = New System.Drawing.Size(57, 41)
        Me.CmdExcluir.TabIndex = 4
        Me.CmdExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.CmdExcluir, "Excluir")
        Me.CmdExcluir.UseVisualStyleBackColor = False
        '
        'cmdConsultar
        '
        Me.cmdConsultar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConsultar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConsultar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.Location = New System.Drawing.Point(181, 12)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConsultar.Size = New System.Drawing.Size(57, 41)
        Me.cmdConsultar.TabIndex = 3
        Me.cmdConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdConsultar, "Consultar")
        Me.cmdConsultar.UseVisualStyleBackColor = False
        '
        'cmdAlterar
        '
        Me.cmdAlterar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAlterar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAlterar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAlterar.Image = CType(resources.GetObject("cmdAlterar.Image"), System.Drawing.Image)
        Me.cmdAlterar.Location = New System.Drawing.Point(67, 12)
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAlterar.Size = New System.Drawing.Size(57, 41)
        Me.cmdAlterar.TabIndex = 1
        Me.cmdAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdAlterar, "Alterar")
        Me.cmdAlterar.UseVisualStyleBackColor = False
        '
        'cmdCadastrar
        '
        Me.cmdCadastrar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCadastrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCadastrar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCadastrar.Image = CType(resources.GetObject("cmdCadastrar.Image"), System.Drawing.Image)
        Me.cmdCadastrar.Location = New System.Drawing.Point(10, 12)
        Me.cmdCadastrar.Name = "cmdCadastrar"
        Me.cmdCadastrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCadastrar.Size = New System.Drawing.Size(57, 41)
        Me.cmdCadastrar.TabIndex = 0
        Me.cmdCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdCadastrar, "Incluir")
        Me.cmdCadastrar.UseVisualStyleBackColor = False
        '
        'txtSenha
        '
        Me.txtSenha.AcceptsReturn = True
        Me.txtSenha.BackColor = System.Drawing.SystemColors.Window
        Me.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSenha.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSenha.Location = New System.Drawing.Point(12, 132)
        Me.txtSenha.MaxLength = 50
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSenha.Size = New System.Drawing.Size(112, 22)
        Me.txtSenha.TabIndex = 8
        '
        'txtNome
        '
        Me.txtNome.AcceptsReturn = True
        Me.txtNome.BackColor = System.Drawing.SystemColors.Window
        Me.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNome.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNome.Location = New System.Drawing.Point(15, 81)
        Me.txtNome.MaxLength = 50
        Me.txtNome.Name = "txtNome"
        Me.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNome.Size = New System.Drawing.Size(109, 22)
        Me.txtNome.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "&Senha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(15, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "&Nome"
        '
        'frmSenhas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(418, 167)
        Me.Controls.Add(Me.cmdSalvar)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.CmdExcluir)
        Me.Controls.Add(Me.cmdConsultar)
        Me.Controls.Add(Me.cmdAlterar)
        Me.Controls.Add(Me.cmdCadastrar)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "frmSenhas"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuários"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtSenha As System.Windows.Forms.TextBox
    Public WithEvents txtNome As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents cmdSalvar As System.Windows.Forms.Button
    Public WithEvents cmdSair As System.Windows.Forms.Button
    Public WithEvents cmdCancelar As System.Windows.Forms.Button
    Public WithEvents CmdExcluir As System.Windows.Forms.Button
    Public WithEvents cmdConsultar As System.Windows.Forms.Button
    Public WithEvents cmdAlterar As System.Windows.Forms.Button
    Public WithEvents cmdCadastrar As System.Windows.Forms.Button
#End Region
End Class