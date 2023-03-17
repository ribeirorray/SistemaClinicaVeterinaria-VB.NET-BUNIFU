<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuscarClientes
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
        Me.txtBuscarCPF = New System.Windows.Forms.MaskedTextBox()
        Me.rbCPF = New System.Windows.Forms.RadioButton()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscarCPF
        '
        Me.txtBuscarCPF.Location = New System.Drawing.Point(489, 21)
        Me.txtBuscarCPF.Mask = "000.000.000-00"
        Me.txtBuscarCPF.Name = "txtBuscarCPF"
        Me.txtBuscarCPF.Size = New System.Drawing.Size(121, 20)
        Me.txtBuscarCPF.TabIndex = 100
        '
        'rbCPF
        '
        Me.rbCPF.AutoSize = True
        Me.rbCPF.Location = New System.Drawing.Point(438, 22)
        Me.rbCPF.Name = "rbCPF"
        Me.rbCPF.Size = New System.Drawing.Size(45, 17)
        Me.rbCPF.TabIndex = 99
        Me.rbCPF.TabStop = True
        Me.rbCPF.Text = "CPF"
        Me.rbCPF.UseVisualStyleBackColor = True
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.Location = New System.Drawing.Point(376, 22)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(53, 17)
        Me.rbNome.TabIndex = 98
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome"
        Me.rbNome.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(327, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 97
        Me.Label11.Text = "Buscar:"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.Color.White
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(12, 64)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(601, 165)
        Me.dg.TabIndex = 96
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(489, 21)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(120, 20)
        Me.txtBuscar.TabIndex = 101
        '
        'frmBuscarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(634, 251)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.txtBuscarCPF)
        Me.Controls.Add(Me.rbCPF)
        Me.Controls.Add(Me.rbNome)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dg)
        Me.Name = "frmBuscarClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Clientes"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscarCPF As MaskedTextBox
    Friend WithEvents rbCPF As RadioButton
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents dg As DataGridView
    Friend WithEvents txtBuscar As TextBox
End Class
