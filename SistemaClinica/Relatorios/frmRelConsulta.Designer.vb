<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRelConsulta
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.consultaDataSet = New SistemaClinica.consultaDataSet()
        Me.ConsultaPorIdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultaPorIdTableAdapter = New SistemaClinica.consultaDataSetTableAdapters.ConsultaPorIdTableAdapter()
        CType(Me.consultaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaPorIdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(585, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Receita"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "dsConsulta"
        ReportDataSource2.Value = Me.ConsultaPorIdBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaClinica.RelConsulta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 50)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(670, 655)
        Me.ReportViewer1.TabIndex = 1
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
        'frmRelConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(694, 717)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmRelConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório da Consulta"
        CType(Me.consultaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaPorIdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ConsultaPorIdBindingSource As BindingSource
    Friend WithEvents consultaDataSet As consultaDataSet
    Friend WithEvents ConsultaPorIdTableAdapter As consultaDataSetTableAdapters.ConsultaPorIdTableAdapter
End Class
