Public Class frmRelConsulta

    Dim codigo As Integer

    Sub New(codigoP As Integer)

        InitializeComponent()
        codigo = codigoP

    End Sub

    Private Sub frmRelConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'consultaDataSet.ConsultaPorId'. Você pode movê-la ou removê-la conforme necessário.
        Me.ConsultaPorIdTableAdapter.Fill(Me.consultaDataSet.ConsultaPorId, codigo)


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim form = New frmRelReceita(codigo)
        form.ShowDialog()
    End Sub
End Class