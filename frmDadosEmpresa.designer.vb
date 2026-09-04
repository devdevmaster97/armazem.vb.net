<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmDadosEmpresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDadosEmpresa))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdSalvar = New System.Windows.Forms.Button()
        Me.cmdSair = New System.Windows.Forms.Button()
        Me.cmdAlterar = New System.Windows.Forms.Button()
        Me.cboUf = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.txtRazao = New System.Windows.Forms.TextBox()
        Me.mskCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.lblcpfcnpj = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mskTel = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFantasia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mskCep = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIe = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdSalvar
        '
        Me.cmdSalvar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSalvar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSalvar.Enabled = False
        Me.cmdSalvar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSalvar.Image = CType(resources.GetObject("cmdSalvar.Image"), System.Drawing.Image)
        Me.cmdSalvar.Location = New System.Drawing.Point(77, 46)
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSalvar.Size = New System.Drawing.Size(57, 40)
        Me.cmdSalvar.TabIndex = 12
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
        Me.cmdSair.Location = New System.Drawing.Point(140, 46)
        Me.cmdSair.Name = "cmdSair"
        Me.cmdSair.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSair.Size = New System.Drawing.Size(57, 40)
        Me.cmdSair.TabIndex = 13
        Me.cmdSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdSair, "Fechar")
        Me.cmdSair.UseVisualStyleBackColor = False
        '
        'cmdAlterar
        '
        Me.cmdAlterar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAlterar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAlterar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAlterar.Image = CType(resources.GetObject("cmdAlterar.Image"), System.Drawing.Image)
        Me.cmdAlterar.Location = New System.Drawing.Point(12, 46)
        Me.cmdAlterar.Name = "cmdAlterar"
        Me.cmdAlterar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAlterar.Size = New System.Drawing.Size(57, 40)
        Me.cmdAlterar.TabIndex = 11
        Me.cmdAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdAlterar, "Alterar")
        Me.cmdAlterar.UseVisualStyleBackColor = False
        '
        'cboUf
        '
        Me.cboUf.BackColor = System.Drawing.SystemColors.Window
        Me.cboUf.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUf.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUf.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboUf.Location = New System.Drawing.Point(390, 232)
        Me.cboUf.Name = "cboUf"
        Me.cboUf.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboUf.Size = New System.Drawing.Size(57, 24)
        Me.cboUf.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.AcceptsReturn = True
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEmail.Location = New System.Drawing.Point(236, 273)
        Me.txtEmail.MaxLength = 30
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEmail.Size = New System.Drawing.Size(208, 22)
        Me.txtEmail.TabIndex = 9
        '
        'txtCidade
        '
        Me.txtCidade.AcceptsReturn = True
        Me.txtCidade.BackColor = System.Drawing.SystemColors.Window
        Me.txtCidade.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCidade.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCidade.Location = New System.Drawing.Point(83, 232)
        Me.txtCidade.MaxLength = 50
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCidade.Size = New System.Drawing.Size(301, 22)
        Me.txtCidade.TabIndex = 5
        '
        'txtEnd
        '
        Me.txtEnd.AcceptsReturn = True
        Me.txtEnd.BackColor = System.Drawing.SystemColors.Window
        Me.txtEnd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEnd.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEnd.Location = New System.Drawing.Point(12, 189)
        Me.txtEnd.MaxLength = 50
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEnd.Size = New System.Drawing.Size(405, 22)
        Me.txtEnd.TabIndex = 2
        '
        'txtRazao
        '
        Me.txtRazao.AcceptsReturn = True
        Me.txtRazao.BackColor = System.Drawing.SystemColors.Window
        Me.txtRazao.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRazao.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazao.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRazao.Location = New System.Drawing.Point(12, 106)
        Me.txtRazao.MaxLength = 50
        Me.txtRazao.Name = "txtRazao"
        Me.txtRazao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtRazao.Size = New System.Drawing.Size(595, 22)
        Me.txtRazao.TabIndex = 0
        '
        'mskCNPJ
        '
        Me.mskCNPJ.AllowPromptAsInput = False
        Me.mskCNPJ.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCNPJ.Location = New System.Drawing.Point(453, 232)
        Me.mskCNPJ.Mask = "00,000,000/0000-00"
        Me.mskCNPJ.Name = "mskCNPJ"
        Me.mskCNPJ.Size = New System.Drawing.Size(155, 22)
        Me.mskCNPJ.TabIndex = 7
        Me.mskCNPJ.Tag = ""
        Me.mskCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblcpfcnpj
        '
        Me.lblcpfcnpj.AutoSize = True
        Me.lblcpfcnpj.BackColor = System.Drawing.SystemColors.Control
        Me.lblcpfcnpj.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblcpfcnpj.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblcpfcnpj.Location = New System.Drawing.Point(450, 216)
        Me.lblcpfcnpj.Name = "lblcpfcnpj"
        Me.lblcpfcnpj.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblcpfcnpj.Size = New System.Drawing.Size(34, 13)
        Me.lblcpfcnpj.TabIndex = 39
        Me.lblcpfcnpj.Text = "&CNPJ"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(390, 217)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(18, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "&Uf"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(233, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "&E-mail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(83, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "&Cidade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "&Endereço"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "&Razão Social"
        '
        'mskTel
        '
        Me.mskTel.Location = New System.Drawing.Point(453, 273)
        Me.mskTel.Mask = "(99) 0000-0000"
        Me.mskTel.Name = "mskTel"
        Me.mskTel.Size = New System.Drawing.Size(85, 20)
        Me.mskTel.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(450, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "&Telefone"
        '
        'txtFantasia
        '
        Me.txtFantasia.AcceptsReturn = True
        Me.txtFantasia.BackColor = System.Drawing.SystemColors.Window
        Me.txtFantasia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFantasia.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFantasia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFantasia.Location = New System.Drawing.Point(12, 148)
        Me.txtFantasia.MaxLength = 50
        Me.txtFantasia.Name = "txtFantasia"
        Me.txtFantasia.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFantasia.Size = New System.Drawing.Size(595, 22)
        Me.txtFantasia.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(12, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "&Nome Fantasia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(12, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "&CEP"
        '
        'mskCep
        '
        Me.mskCep.Location = New System.Drawing.Point(15, 233)
        Me.mskCep.Mask = "00,000-000"
        Me.mskCep.Name = "mskCep"
        Me.mskCep.Size = New System.Drawing.Size(62, 20)
        Me.mskCep.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(8, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(604, 33)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "&INFORME OS DADOS DA SUA EMPRESA"
        '
        'txtBairro
        '
        Me.txtBairro.AcceptsReturn = True
        Me.txtBairro.BackColor = System.Drawing.SystemColors.Window
        Me.txtBairro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBairro.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBairro.Location = New System.Drawing.Point(423, 189)
        Me.txtBairro.MaxLength = 20
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBairro.Size = New System.Drawing.Size(184, 22)
        Me.txtBairro.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(420, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "&Bairro"
        '
        'txtIe
        '
        Me.txtIe.AcceptsReturn = True
        Me.txtIe.BackColor = System.Drawing.SystemColors.Window
        Me.txtIe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIe.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIe.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIe.Location = New System.Drawing.Point(15, 273)
        Me.txtIe.MaxLength = 30
        Me.txtIe.Name = "txtIe"
        Me.txtIe.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIe.Size = New System.Drawing.Size(208, 22)
        Me.txtIe.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(12, 257)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "&Insc. Estadual"
        '
        'frmDadosEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(621, 307)
        Me.Controls.Add(Me.txtIe)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.mskCep)
        Me.Controls.Add(Me.txtFantasia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mskTel)
        Me.Controls.Add(Me.cmdSalvar)
        Me.Controls.Add(Me.cmdSair)
        Me.Controls.Add(Me.cmdAlterar)
        Me.Controls.Add(Me.cboUf)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.txtEnd)
        Me.Controls.Add(Me.txtRazao)
        Me.Controls.Add(Me.mskCNPJ)
        Me.Controls.Add(Me.lblcpfcnpj)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.Location = New System.Drawing.Point(4, 30)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDadosEmpresa"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dados da empresa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents cboUf As System.Windows.Forms.ComboBox
    Public WithEvents txtEmail As System.Windows.Forms.TextBox
    Public WithEvents txtCidade As System.Windows.Forms.TextBox
    Public WithEvents txtEnd As System.Windows.Forms.TextBox
    Public WithEvents txtRazao As System.Windows.Forms.TextBox
    Public WithEvents mskCNPJ As System.Windows.Forms.MaskedTextBox
    Public WithEvents lblcpfcnpj As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents cmdSalvar As System.Windows.Forms.Button
    Public WithEvents cmdSair As System.Windows.Forms.Button
    Public WithEvents cmdAlterar As System.Windows.Forms.Button
    Friend WithEvents mskTel As System.Windows.Forms.MaskedTextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtFantasia As System.Windows.Forms.TextBox
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents mskCep As System.Windows.Forms.MaskedTextBox
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents txtBairro As System.Windows.Forms.TextBox
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents txtIe As System.Windows.Forms.TextBox
    Public WithEvents Label11 As System.Windows.Forms.Label
#End Region
End Class