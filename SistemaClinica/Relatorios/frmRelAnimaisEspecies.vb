Imports Microsoft.Reporting.WinForms

Public Class frmRelAnimaisEspecies
    Private Sub frmRelAnimaisEspecies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtInicio.Value = Now.ToShortDateString
        dtFinal.Value = Now.ToShortDateString

        'TODO: esta linha de código carrega dados na tabela 'sistema_clinicaDataSet.AnimaisConsulta'. Você pode movê-la ou removê-la conforme necessário.
        ChamarRel()
    End Sub

    Sub ChamarRel()
        Me.AnimaisFiltroDataTableAdapter.Fill(Me.sistema_clinicaDataSet.AnimaisFiltroData, dtInicio.Text, dtFinal.Text)
        'chamar os parametros
        Dim parametro(1) As ReportParameter


        parametro(0) = New ReportParameter("dataInicial", dtInicio.Text)
        parametro(1) = New ReportParameter("dataFinal", dtFinal.Text)

        Me.ReportViewer1.LocalReport.SetParameters(parametro)


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub dtInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtInicio.ValueChanged
        ChamarRel()
    End Sub

    Private Sub dtFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtFinal.ValueChanged
        ChamarRel()
    End Sub

End Class