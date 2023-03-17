Public Class frmRelEspecies
    Private Sub frmRelEspecies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'EspeciesDataSet.categorias'. Você pode movê-la ou removê-la conforme necessário.
        Me.categoriasTableAdapter.Fill(Me.EspeciesDataSet.categorias)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class