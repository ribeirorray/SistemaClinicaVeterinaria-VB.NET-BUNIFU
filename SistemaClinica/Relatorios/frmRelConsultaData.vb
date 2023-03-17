Imports Microsoft.Reporting.WinForms

Public Class frmRelConsultaData
    Private Sub frmRelConsultaData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'consultaDataSet.ConsultasPorData'. Você pode movê-la ou removê-la conforme necessário.
        dtInicio.Value = Now.ToShortDateString
        dtFinal.Value = Now.ToShortDateString
        ChamarRel()

    End Sub


    Sub ChamarRel()
        Me.ConsultasPorDataTableAdapter.Fill(Me.consultaDataSet.ConsultasPorData, dtInicio.Text, dtFinal.Text)

        'chamar os parametros
        Dim parametro(1) As ReportParameter


        parametro(0) = New ReportParameter("data_inicial", dtInicio.Text)
        parametro(1) = New ReportParameter("data_final", dtFinal.Text)

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