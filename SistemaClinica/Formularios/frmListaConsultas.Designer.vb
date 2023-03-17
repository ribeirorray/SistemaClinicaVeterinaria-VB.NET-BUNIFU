<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaConsultas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaConsultas))
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.dtBuscar = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRegistros = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.btnRelReceita = New System.Windows.Forms.Button()
        Me.btnRelConsulta = New System.Windows.Forms.Button()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(23, 19)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(44, 20)
        Me.txtCodigo.TabIndex = 80
        Me.txtCodigo.Visible = False
        '
        'dtBuscar
        '
        Me.dtBuscar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBuscar.Location = New System.Drawing.Point(639, 17)
        Me.dtBuscar.Name = "dtBuscar"
        Me.dtBuscar.Size = New System.Drawing.Size(136, 20)
        Me.dtBuscar.TabIndex = 79
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(327, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Buscar:"
        '
        'lblRegistros
        '
        Me.lblRegistros.AutoSize = True
        Me.lblRegistros.Location = New System.Drawing.Point(762, 353)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(10, 13)
        Me.lblRegistros.TabIndex = 77
        Me.lblRegistros.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(702, 353)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Registros:"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.Color.White
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(23, 60)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(753, 290)
        Me.dg.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(597, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Data:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(383, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Status:"
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Marcado", "Cancelado", "Consultando", "Finalizado"})
        Me.cbStatus.Location = New System.Drawing.Point(429, 16)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(121, 21)
        Me.cbStatus.TabIndex = 83
        '
        'btnRelReceita
        '
        Me.btnRelReceita.BackColor = System.Drawing.Color.Transparent
        Me.btnRelReceita.BackgroundImage = CType(resources.GetObject("btnRelReceita.BackgroundImage"), System.Drawing.Image)
        Me.btnRelReceita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRelReceita.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRelReceita.Enabled = False
        Me.btnRelReceita.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnRelReceita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRelReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelReceita.Location = New System.Drawing.Point(415, 369)
        Me.btnRelReceita.Name = "btnRelReceita"
        Me.btnRelReceita.Size = New System.Drawing.Size(70, 69)
        Me.btnRelReceita.TabIndex = 73
        Me.btnRelReceita.UseVisualStyleBackColor = False
        '
        'btnRelConsulta
        '
        Me.btnRelConsulta.BackColor = System.Drawing.Color.Transparent
        Me.btnRelConsulta.BackgroundImage = CType(resources.GetObject("btnRelConsulta.BackgroundImage"), System.Drawing.Image)
        Me.btnRelConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRelConsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRelConsulta.Enabled = False
        Me.btnRelConsulta.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnRelConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRelConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelConsulta.Location = New System.Drawing.Point(330, 369)
        Me.btnRelConsulta.Name = "btnRelConsulta"
        Me.btnRelConsulta.Size = New System.Drawing.Size(67, 69)
        Me.btnRelConsulta.TabIndex = 72
        Me.btnRelConsulta.UseVisualStyleBackColor = False
        '
        'frmListaConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.dtBuscar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRelReceita)
        Me.Controls.Add(Me.btnRelConsulta)
        Me.Controls.Add(Me.dg)
        Me.Name = "frmListaConsultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Consultas"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents dtBuscar As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents lblRegistros As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRelReceita As Button
    Friend WithEvents btnRelConsulta As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbStatus As ComboBox
End Class
