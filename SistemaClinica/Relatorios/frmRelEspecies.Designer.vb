<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelEspecies
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
        Me.categoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EspeciesDataSet = New SistemaClinica.EspeciesDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.categoriasTableAdapter = New SistemaClinica.EspeciesDataSetTableAdapters.categoriasTableAdapter()
        CType(Me.categoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EspeciesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'categoriasBindingSource
        '
        Me.categoriasBindingSource.DataMember = "categorias"
        Me.categoriasBindingSource.DataSource = Me.EspeciesDataSet
        '
        'EspeciesDataSet
        '
        Me.EspeciesDataSet.DataSetName = "EspeciesDataSet"
        Me.EspeciesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsEspecies"
        ReportDataSource1.Value = Me.categoriasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaClinica.RelEspecies.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(644, 493)
        Me.ReportViewer1.TabIndex = 0
        '
        'categoriasTableAdapter
        '
        Me.categoriasTableAdapter.ClearBeforeFill = True
        '
        'frmRelEspecies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 493)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRelEspecies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório das Espécies"
        CType(Me.categoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EspeciesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents categoriasBindingSource As BindingSource
    Friend WithEvents EspeciesDataSet As EspeciesDataSet
    Friend WithEvents categoriasTableAdapter As EspeciesDataSetTableAdapters.categoriasTableAdapter
End Class
