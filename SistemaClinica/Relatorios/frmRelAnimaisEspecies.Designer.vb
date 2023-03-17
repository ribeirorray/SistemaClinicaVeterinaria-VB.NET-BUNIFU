<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelAnimaisEspecies
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.AnimaisFiltroDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sistema_clinicaDataSet = New SistemaClinica.sistema_clinicaDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtInicio = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AnimaisFiltroDataTableAdapter = New SistemaClinica.sistema_clinicaDataSetTableAdapters.AnimaisFiltroDataTableAdapter()
        CType(Me.AnimaisFiltroDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sistema_clinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnimaisFiltroDataBindingSource
        '
        Me.AnimaisFiltroDataBindingSource.DataMember = "AnimaisFiltroData"
        Me.AnimaisFiltroDataBindingSource.DataSource = Me.sistema_clinicaDataSet
        '
        'sistema_clinicaDataSet
        '
        Me.sistema_clinicaDataSet.DataSetName = "sistema_clinicaDataSet"
        Me.sistema_clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(566, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(385, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Início"
        '
        'dtFinal
        '
        Me.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFinal.Location = New System.Drawing.Point(601, 17)
        Me.dtFinal.Name = "dtFinal"
        Me.dtFinal.Size = New System.Drawing.Size(90, 20)
        Me.dtFinal.TabIndex = 6
        '
        'dtInicio
        '
        Me.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicio.Location = New System.Drawing.Point(425, 17)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.Size = New System.Drawing.Size(90, 20)
        Me.dtInicio.TabIndex = 5
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DSAnimaisEspecie"
        ReportDataSource1.Value = Me.AnimaisFiltroDataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaClinica.RelAnimaisEspecies.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 59)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(682, 519)
        Me.ReportViewer1.TabIndex = 9
        '
        'AnimaisFiltroDataTableAdapter
        '
        Me.AnimaisFiltroDataTableAdapter.ClearBeforeFill = True
        '
        'frmRelAnimaisEspecies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(706, 590)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtFinal)
        Me.Controls.Add(Me.dtInicio)
        Me.Name = "frmRelAnimaisEspecies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Animais por Espécies"
        CType(Me.AnimaisFiltroDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sistema_clinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtFinal As DateTimePicker
    Friend WithEvents dtInicio As DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AnimaisFiltroDataBindingSource As BindingSource
    Friend WithEvents sistema_clinicaDataSet As sistema_clinicaDataSet
    Friend WithEvents AnimaisFiltroDataTableAdapter As sistema_clinicaDataSetTableAdapters.AnimaisFiltroDataTableAdapter
End Class
