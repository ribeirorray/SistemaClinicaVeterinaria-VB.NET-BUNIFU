<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuadroHorario
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbVeterinario = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtData = New System.Windows.Forms.DateTimePicker()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.lbl18 = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.lbl17 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.lbl16 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.lbl15 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.lbl14 = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Veterinário:"
        '
        'cbVeterinario
        '
        Me.cbVeterinario.FormattingEnabled = True
        Me.cbVeterinario.Location = New System.Drawing.Point(132, 13)
        Me.cbVeterinario.Name = "cbVeterinario"
        Me.cbVeterinario.Size = New System.Drawing.Size(153, 21)
        Me.cbVeterinario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Data:"
        '
        'dtData
        '
        Me.dtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtData.Location = New System.Drawing.Point(361, 14)
        Me.dtData.Name = "dtData"
        Me.dtData.Size = New System.Drawing.Size(81, 20)
        Me.dtData.TabIndex = 67
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.Color.White
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(30, 175)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(460, 221)
        Me.dg.TabIndex = 68
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.Enabled = False
        Me.lbl9.Location = New System.Drawing.Point(3, 8)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(49, 13)
        Me.lbl9.TabIndex = 69
        Me.lbl9.Text = "09:00:00"
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.Enabled = False
        Me.lbl11.Location = New System.Drawing.Point(3, 9)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(49, 13)
        Me.lbl11.TabIndex = 70
        Me.lbl11.Text = "11:00:00"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.LightGreen
        Me.Panel9.Controls.Add(Me.lbl9)
        Me.Panel9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel9.Location = New System.Drawing.Point(172, 78)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(55, 30)
        Me.Panel9.TabIndex = 71
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.LightGreen
        Me.Panel10.Controls.Add(Me.lbl10)
        Me.Panel10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel10.Location = New System.Drawing.Point(233, 78)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(55, 30)
        Me.Panel10.TabIndex = 72
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Enabled = False
        Me.lbl10.Location = New System.Drawing.Point(3, 8)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(49, 13)
        Me.lbl10.TabIndex = 69
        Me.lbl10.Text = "10:00:00"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.LightGreen
        Me.Panel11.Controls.Add(Me.lbl11)
        Me.Panel11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel11.Location = New System.Drawing.Point(294, 78)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(55, 30)
        Me.Panel11.TabIndex = 73
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.LightGreen
        Me.Panel13.Controls.Add(Me.lbl13)
        Me.Panel13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel13.Location = New System.Drawing.Point(355, 78)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(55, 30)
        Me.Panel13.TabIndex = 74
        '
        'lbl13
        '
        Me.lbl13.AutoSize = True
        Me.lbl13.Enabled = False
        Me.lbl13.Location = New System.Drawing.Point(3, 9)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(49, 13)
        Me.lbl13.TabIndex = 70
        Me.lbl13.Text = "13:00:00"
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.LightGreen
        Me.Panel18.Controls.Add(Me.lbl18)
        Me.Panel18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel18.Location = New System.Drawing.Point(355, 114)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(55, 30)
        Me.Panel18.TabIndex = 78
        '
        'lbl18
        '
        Me.lbl18.AutoSize = True
        Me.lbl18.Enabled = False
        Me.lbl18.Location = New System.Drawing.Point(3, 9)
        Me.lbl18.Name = "lbl18"
        Me.lbl18.Size = New System.Drawing.Size(49, 13)
        Me.lbl18.TabIndex = 70
        Me.lbl18.Text = "18:00:00"
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.LightGreen
        Me.Panel17.Controls.Add(Me.lbl17)
        Me.Panel17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel17.Location = New System.Drawing.Point(294, 114)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(55, 30)
        Me.Panel17.TabIndex = 77
        '
        'lbl17
        '
        Me.lbl17.AutoSize = True
        Me.lbl17.Enabled = False
        Me.lbl17.Location = New System.Drawing.Point(3, 9)
        Me.lbl17.Name = "lbl17"
        Me.lbl17.Size = New System.Drawing.Size(49, 13)
        Me.lbl17.TabIndex = 70
        Me.lbl17.Text = "17:00:00"
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.LightGreen
        Me.Panel16.Controls.Add(Me.lbl16)
        Me.Panel16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel16.Location = New System.Drawing.Point(233, 114)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(55, 30)
        Me.Panel16.TabIndex = 76
        '
        'lbl16
        '
        Me.lbl16.AutoSize = True
        Me.lbl16.Enabled = False
        Me.lbl16.Location = New System.Drawing.Point(3, 8)
        Me.lbl16.Name = "lbl16"
        Me.lbl16.Size = New System.Drawing.Size(49, 13)
        Me.lbl16.TabIndex = 69
        Me.lbl16.Text = "16:00:00"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.LightGreen
        Me.Panel15.Controls.Add(Me.lbl15)
        Me.Panel15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel15.Location = New System.Drawing.Point(172, 114)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(55, 30)
        Me.Panel15.TabIndex = 75
        '
        'lbl15
        '
        Me.lbl15.AutoSize = True
        Me.lbl15.Enabled = False
        Me.lbl15.Location = New System.Drawing.Point(3, 8)
        Me.lbl15.Name = "lbl15"
        Me.lbl15.Size = New System.Drawing.Size(49, 13)
        Me.lbl15.TabIndex = 69
        Me.lbl15.Text = "15:00:00"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.LightGreen
        Me.Panel8.Controls.Add(Me.lbl8)
        Me.Panel8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel8.Location = New System.Drawing.Point(111, 78)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(55, 30)
        Me.Panel8.TabIndex = 72
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.Enabled = False
        Me.lbl8.Location = New System.Drawing.Point(3, 8)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(49, 13)
        Me.lbl8.TabIndex = 69
        Me.lbl8.Text = "08:00:00"
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.LightGreen
        Me.Panel14.Controls.Add(Me.lbl14)
        Me.Panel14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel14.Location = New System.Drawing.Point(111, 114)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(55, 30)
        Me.Panel14.TabIndex = 73
        '
        'lbl14
        '
        Me.lbl14.AutoSize = True
        Me.lbl14.Enabled = False
        Me.lbl14.Location = New System.Drawing.Point(3, 8)
        Me.lbl14.Name = "lbl14"
        Me.lbl14.Size = New System.Drawing.Size(49, 13)
        Me.lbl14.TabIndex = 69
        Me.lbl14.Text = "14:00:00"
        '
        'frmQuadroHorario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(521, 408)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel18)
        Me.Controls.Add(Me.Panel17)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel16)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbVeterinario)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmQuadroHorario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quadro de Horários"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbVeterinario As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtData As DateTimePicker
    Friend WithEvents dg As DataGridView
    Friend WithEvents lbl9 As Label
    Friend WithEvents lbl11 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lbl10 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents lbl13 As Label
    Friend WithEvents Panel18 As Panel
    Friend WithEvents lbl18 As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents lbl17 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents lbl16 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents lbl15 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lbl8 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents lbl14 As Label
End Class
