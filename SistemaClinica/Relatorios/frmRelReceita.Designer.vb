<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelReceita
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.consultaDataSet = New SistemaClinica.consultaDataSet()
        Me.ConsultaPorIdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultaPorIdTableAdapter = New SistemaClinica.consultaDataSetTableAdapters.ConsultaPorIdTableAdapter()
        CType(Me.consultaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaPorIdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DsConsultas"
        ReportDataSource1.Value = Me.ConsultaPorIdBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaClinica.RelReceita.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(614, 595)
        Me.ReportViewer1.TabIndex = 0
        '
        'consultaDataSet
        '
        Me.consultaDataSet.DataSetName = "consultaDataSet"
        Me.consultaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConsultaPorIdBindingSource
        '
        Me.ConsultaPorIdBindingSource.DataMember = "ConsultaPorId"
        Me.ConsultaPorIdBindingSource.DataSource = Me.consultaDataSet
        '
        'ConsultaPorIdTableAdapter
        '
        Me.ConsultaPorIdTableAdapter.ClearBeforeFill = True
        '
        'frmRelReceita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(614, 595)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRelReceita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receituário Médico"
        CType(Me.consultaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaPorIdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ConsultaPorIdBindingSource As BindingSource
    Friend WithEvents consultaDataSet As consultaDataSet
    Friend WithEvents ConsultaPorIdTableAdapter As consultaDataSetTableAdapters.ConsultaPorIdTableAdapter
End Class
