<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoráriosAtendimentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcaçãoDeConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasAgendadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuadroDeHoráriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblConsAndamento = New System.Windows.Forms.Label()
        Me.dg2 = New System.Windows.Forms.DataGridView()
        Me.lblProxConsultas = New System.Windows.Forms.Label()
        Me.dg3 = New System.Windows.Forms.DataGridView()
        Me.lblProxConsVet = New System.Windows.Forms.Label()
        Me.lblProxConAtend = New System.Windows.Forms.Label()
        Me.dg4 = New System.Windows.Forms.DataGridView()
        Me.dg5 = New System.Windows.Forms.DataGridView()
        Me.lblConsultasFin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbltotFim = New System.Windows.Forms.Label()
        Me.lblTotCanceladas = New System.Windows.Forms.Label()
        Me.lblTotMarcadas = New System.Windows.Forms.Label()
        Me.lblTotAndamento = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUsuario.Location = New System.Drawing.Point(819, 13)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 6
        Me.lblUsuario.Text = "Usuário"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(861, 35)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(35, 13)
        Me.lblCargo.TabIndex = 7
        Me.lblCargo.Text = "Cargo"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FloralWhite
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DsToolStripMenuItem, Me.DToolStripMenuItem, Me.SToolStripMenuItem, Me.ToolStripMenuItem14, Me.SToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(961, 72)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DsToolStripMenuItem
        '
        Me.DsToolStripMenuItem.Image = CType(resources.GetObject("DsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DsToolStripMenuItem.Name = "DsToolStripMenuItem"
        Me.DsToolStripMenuItem.Size = New System.Drawing.Size(76, 68)
        '
        'DToolStripMenuItem
        '
        Me.DToolStripMenuItem.Image = CType(resources.GetObject("DToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DToolStripMenuItem.Name = "DToolStripMenuItem"
        Me.DToolStripMenuItem.Size = New System.Drawing.Size(76, 68)
        '
        'SToolStripMenuItem
        '
        Me.SToolStripMenuItem.Image = CType(resources.GetObject("SToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SToolStripMenuItem.Name = "SToolStripMenuItem"
        Me.SToolStripMenuItem.Size = New System.Drawing.Size(76, 68)
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Image = CType(resources.GetObject("ToolStripMenuItem14.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(76, 68)
        '
        'SToolStripMenuItem1
        '
        Me.SToolStripMenuItem1.Image = CType(resources.GetObject("SToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SToolStripMenuItem1.Name = "SToolStripMenuItem1"
        Me.SToolStripMenuItem1.Size = New System.Drawing.Size(76, 68)
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.FloralWhite
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem4, Me.ToolStripMenuItem7, Me.ToolStripMenuItem11, Me.ToolStripMenuItem12})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(961, 24)
        Me.MenuStrip2.TabIndex = 9
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.HoráriosAtendimentoToolStripMenuItem})
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(87, 20)
        Me.ToolStripMenuItem1.Text = "Cadastros"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(192, 22)
        Me.ToolStripMenuItem2.Text = "Clientes"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(192, 22)
        Me.ToolStripMenuItem3.Text = "Funcionários"
        '
        'HoráriosAtendimentoToolStripMenuItem
        '
        Me.HoráriosAtendimentoToolStripMenuItem.Name = "HoráriosAtendimentoToolStripMenuItem"
        Me.HoráriosAtendimentoToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.HoráriosAtendimentoToolStripMenuItem.Text = "Horários Atendimento"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(78, 20)
        Me.ToolStripMenuItem4.Text = "Animais"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripMenuItem5.Text = "Cadastro de Animais"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripMenuItem6.Text = "Espécies"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10, Me.ConsultasToolStripMenuItem})
        Me.ToolStripMenuItem7.Image = CType(resources.GetObject("ToolStripMenuItem7.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(87, 20)
        Me.ToolStripMenuItem7.Text = "Relatórios"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem8.Text = "Animais"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem9.Text = "Espécies"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(172, 22)
        Me.ToolStripMenuItem10.Text = "Animais / Espécies"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarcaçãoDeConsultaToolStripMenuItem, Me.ConsultasAgendadasToolStripMenuItem, Me.ListaDeConsultasToolStripMenuItem, Me.QuadroDeHoráriosToolStripMenuItem})
        Me.ToolStripMenuItem11.Image = CType(resources.GetObject("ToolStripMenuItem11.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(105, 20)
        Me.ToolStripMenuItem11.Text = "Atendimento"
        '
        'MarcaçãoDeConsultaToolStripMenuItem
        '
        Me.MarcaçãoDeConsultaToolStripMenuItem.Name = "MarcaçãoDeConsultaToolStripMenuItem"
        Me.MarcaçãoDeConsultaToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.MarcaçãoDeConsultaToolStripMenuItem.Text = "Marcação de Consulta"
        '
        'ConsultasAgendadasToolStripMenuItem
        '
        Me.ConsultasAgendadasToolStripMenuItem.Name = "ConsultasAgendadasToolStripMenuItem"
        Me.ConsultasAgendadasToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ConsultasAgendadasToolStripMenuItem.Text = "Consultas Agendadas"
        '
        'ListaDeConsultasToolStripMenuItem
        '
        Me.ListaDeConsultasToolStripMenuItem.Name = "ListaDeConsultasToolStripMenuItem"
        Me.ListaDeConsultasToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ListaDeConsultasToolStripMenuItem.Text = "Lista de Consultas"
        '
        'QuadroDeHoráriosToolStripMenuItem
        '
        Me.QuadroDeHoráriosToolStripMenuItem.Name = "QuadroDeHoráriosToolStripMenuItem"
        Me.QuadroDeHoráriosToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.QuadroDeHoráriosToolStripMenuItem.Text = "Quadro de Horários"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem13})
        Me.ToolStripMenuItem12.Image = CType(resources.GetObject("ToolStripMenuItem12.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripMenuItem12.Text = "Sair"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem13.Text = "Logout"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(12, 148)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(541, 258)
        Me.dg.TabIndex = 72
        Me.dg.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(821, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Cargo:"
        '
        'lblConsAndamento
        '
        Me.lblConsAndamento.AutoSize = True
        Me.lblConsAndamento.BackColor = System.Drawing.Color.Transparent
        Me.lblConsAndamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsAndamento.Location = New System.Drawing.Point(347, 126)
        Me.lblConsAndamento.Name = "lblConsAndamento"
        Me.lblConsAndamento.Size = New System.Drawing.Size(164, 16)
        Me.lblConsAndamento.TabIndex = 74
        Me.lblConsAndamento.Text = "Consultas em Andamento:"
        Me.lblConsAndamento.Visible = False
        '
        'dg2
        '
        Me.dg2.AllowUserToAddRows = False
        Me.dg2.AllowUserToDeleteRows = False
        Me.dg2.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg2.Location = New System.Drawing.Point(577, 148)
        Me.dg2.Name = "dg2"
        Me.dg2.ReadOnly = True
        Me.dg2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg2.Size = New System.Drawing.Size(372, 258)
        Me.dg2.TabIndex = 75
        Me.dg2.Visible = False
        '
        'lblProxConsultas
        '
        Me.lblProxConsultas.AutoSize = True
        Me.lblProxConsultas.BackColor = System.Drawing.Color.Transparent
        Me.lblProxConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProxConsultas.Location = New System.Drawing.Point(574, 126)
        Me.lblProxConsultas.Name = "lblProxConsultas"
        Me.lblProxConsultas.Size = New System.Drawing.Size(126, 16)
        Me.lblProxConsultas.TabIndex = 76
        Me.lblProxConsultas.Text = "Próximas Consultas"
        Me.lblProxConsultas.Visible = False
        '
        'dg3
        '
        Me.dg3.AllowUserToAddRows = False
        Me.dg3.AllowUserToDeleteRows = False
        Me.dg3.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.dg3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg3.Location = New System.Drawing.Point(12, 148)
        Me.dg3.Name = "dg3"
        Me.dg3.ReadOnly = True
        Me.dg3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg3.Size = New System.Drawing.Size(416, 258)
        Me.dg3.TabIndex = 77
        Me.dg3.Visible = False
        '
        'lblProxConsVet
        '
        Me.lblProxConsVet.AutoSize = True
        Me.lblProxConsVet.BackColor = System.Drawing.Color.Transparent
        Me.lblProxConsVet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProxConsVet.Location = New System.Drawing.Point(12, 126)
        Me.lblProxConsVet.Name = "lblProxConsVet"
        Me.lblProxConsVet.Size = New System.Drawing.Size(126, 16)
        Me.lblProxConsVet.TabIndex = 78
        Me.lblProxConsVet.Text = "Próximas Consultas"
        Me.lblProxConsVet.Visible = False
        '
        'lblProxConAtend
        '
        Me.lblProxConAtend.AutoSize = True
        Me.lblProxConAtend.BackColor = System.Drawing.Color.Transparent
        Me.lblProxConAtend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProxConAtend.Location = New System.Drawing.Point(162, 126)
        Me.lblProxConAtend.Name = "lblProxConAtend"
        Me.lblProxConAtend.Size = New System.Drawing.Size(126, 16)
        Me.lblProxConAtend.TabIndex = 79
        Me.lblProxConAtend.Text = "Próximas Consultas"
        Me.lblProxConAtend.Visible = False
        '
        'dg4
        '
        Me.dg4.AllowUserToAddRows = False
        Me.dg4.AllowUserToDeleteRows = False
        Me.dg4.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.dg4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg4.Location = New System.Drawing.Point(12, 148)
        Me.dg4.Name = "dg4"
        Me.dg4.ReadOnly = True
        Me.dg4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg4.Size = New System.Drawing.Size(541, 258)
        Me.dg4.TabIndex = 80
        Me.dg4.Visible = False
        '
        'dg5
        '
        Me.dg5.AllowUserToAddRows = False
        Me.dg5.AllowUserToDeleteRows = False
        Me.dg5.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.dg5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg5.Location = New System.Drawing.Point(577, 148)
        Me.dg5.Name = "dg5"
        Me.dg5.ReadOnly = True
        Me.dg5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg5.Size = New System.Drawing.Size(372, 258)
        Me.dg5.TabIndex = 81
        Me.dg5.Visible = False
        '
        'lblConsultasFin
        '
        Me.lblConsultasFin.AutoSize = True
        Me.lblConsultasFin.BackColor = System.Drawing.Color.Transparent
        Me.lblConsultasFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultasFin.Location = New System.Drawing.Point(574, 126)
        Me.lblConsultasFin.Name = "lblConsultasFin"
        Me.lblConsultasFin.Size = New System.Drawing.Size(139, 16)
        Me.lblConsultasFin.TabIndex = 82
        Me.lblConsultasFin.Text = "Consultas Finalizadas"
        Me.lblConsultasFin.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 426)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Total de Consultas Finalizadas:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 426)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 13)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Total de Consultas Canceladas:"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(489, 426)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 13)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Total de Consultas Marcadas:"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(724, 426)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Total de Consultas em Andamento:"
        Me.Label5.Visible = False
        '
        'lbltotFim
        '
        Me.lbltotFim.AutoSize = True
        Me.lbltotFim.Location = New System.Drawing.Point(162, 426)
        Me.lbltotFim.Name = "lbltotFim"
        Me.lbltotFim.Size = New System.Drawing.Size(13, 13)
        Me.lbltotFim.TabIndex = 87
        Me.lbltotFim.Text = "0"
        Me.lbltotFim.Visible = False
        '
        'lblTotCanceladas
        '
        Me.lblTotCanceladas.AutoSize = True
        Me.lblTotCanceladas.Location = New System.Drawing.Point(404, 426)
        Me.lblTotCanceladas.Name = "lblTotCanceladas"
        Me.lblTotCanceladas.Size = New System.Drawing.Size(13, 13)
        Me.lblTotCanceladas.TabIndex = 88
        Me.lblTotCanceladas.Text = "0"
        Me.lblTotCanceladas.Visible = False
        '
        'lblTotMarcadas
        '
        Me.lblTotMarcadas.AutoSize = True
        Me.lblTotMarcadas.Location = New System.Drawing.Point(633, 426)
        Me.lblTotMarcadas.Name = "lblTotMarcadas"
        Me.lblTotMarcadas.Size = New System.Drawing.Size(13, 13)
        Me.lblTotMarcadas.TabIndex = 89
        Me.lblTotMarcadas.Text = "0"
        Me.lblTotMarcadas.Visible = False
        '
        'lblTotAndamento
        '
        Me.lblTotAndamento.AutoSize = True
        Me.lblTotAndamento.Location = New System.Drawing.Point(892, 426)
        Me.lblTotAndamento.Name = "lblTotAndamento"
        Me.lblTotAndamento.Size = New System.Drawing.Size(13, 13)
        Me.lblTotAndamento.TabIndex = 90
        Me.lblTotAndamento.Text = "0"
        Me.lblTotAndamento.Visible = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(961, 446)
        Me.Controls.Add(Me.lblTotAndamento)
        Me.Controls.Add(Me.lblTotMarcadas)
        Me.Controls.Add(Me.lblTotCanceladas)
        Me.Controls.Add(Me.lbltotFim)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblConsultasFin)
        Me.Controls.Add(Me.dg5)
        Me.Controls.Add(Me.dg4)
        Me.Controls.Add(Me.lblProxConAtend)
        Me.Controls.Add(Me.lblProxConsVet)
        Me.Controls.Add(Me.dg3)
        Me.Controls.Add(Me.lblProxConsultas)
        Me.Controls.Add(Me.dg2)
        Me.Controls.Add(Me.lblConsAndamento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.lblCargo)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vet Clinica"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblCargo As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As ToolStripMenuItem
    Friend WithEvents MarcaçãoDeConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasAgendadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HoráriosAtendimentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuadroDeHoráriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As ToolStripMenuItem
    Friend WithEvents dg As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblConsAndamento As Label
    Friend WithEvents dg2 As DataGridView
    Friend WithEvents lblProxConsultas As Label
    Friend WithEvents dg3 As DataGridView
    Friend WithEvents lblProxConsVet As Label
    Friend WithEvents lblProxConAtend As Label
    Friend WithEvents dg4 As DataGridView
    Friend WithEvents dg5 As DataGridView
    Friend WithEvents lblConsultasFin As Label
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbltotFim As Label
    Friend WithEvents lblTotCanceladas As Label
    Friend WithEvents lblTotMarcadas As Label
    Friend WithEvents lblTotAndamento As Label
End Class
