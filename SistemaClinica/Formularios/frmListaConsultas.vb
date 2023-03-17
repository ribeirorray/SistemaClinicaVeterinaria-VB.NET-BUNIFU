Imports MySql.Data.MySqlClient

Public Class frmListaConsultas
    Private Sub frmListaConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        cbStatus.Text = "Finalizado"
    End Sub

    Private Sub Listar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select c.id_consulta, c.id_animal, c.id_veterinario, c.data, c.hora, c.hora_inicio, c.hora_fim, c.obs, c.status, a.nome, v.nome from consultas as c INNER JOIN animais as a on c.id_animal = a.id_animal INNER JOIN veterinarios as v on c.id_veterinario = v.id_veterinario order by c.data desc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()
            ContarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub

    Private Sub FormatarDG()

        dg.Columns(0).Visible = False
        dg.Columns(1).Visible = False
        dg.Columns(2).Visible = False
        'dg.Columns(5).Visible = False
        'dg.Columns(6).Visible = False
        dg.Columns(7).Visible = False

        dg.Columns(0).HeaderText = "Id da Consulta"
        dg.Columns(1).HeaderText = "Id do Animal"
        dg.Columns(2).HeaderText = "Id do Veterinário"
        dg.Columns(3).HeaderText = "Data da Consulta"
        dg.Columns(4).HeaderText = "Hora Marcada"
        dg.Columns(5).HeaderText = "Hora Início"
        dg.Columns(6).HeaderText = "Hora Fim"
        dg.Columns(7).HeaderText = "Observações"
        dg.Columns(8).HeaderText = "Status"
        dg.Columns(9).HeaderText = "Animal"
        dg.Columns(10).HeaderText = "Veterinário"

        'dg.Columns(0).Width = 140
        'dg.Columns(1).Width = 140

    End Sub


    Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblRegistros.Text = total
    End Sub


    Private Sub Buscar()

        Dim data As String
        data = dtBuscar.Value.ToString("yyyy-MM-dd")

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select c.id_consulta, c.id_animal, c.id_veterinario, c.data, c.hora, c.hora_inicio, c.hora_fim, c.obs, c.status, a.nome, v.nome from consultas as c INNER JOIN animais as a on c.id_animal = a.id_animal INNER JOIN veterinarios as v on c.id_veterinario = v.id_veterinario where data = '" & data & "' and status = '" & cbStatus.Text & "' order by c.data asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()
            ContarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub

    Private Sub cbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged
        Buscar()
    End Sub

    Private Sub dtBuscar_ValueChanged(sender As Object, e As EventArgs) Handles dtBuscar.ValueChanged
        Buscar()
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        btnRelConsulta.Enabled = True
        btnRelReceita.Enabled = True

        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
    End Sub

    Private Sub btnRelConsulta_Click(sender As Object, e As EventArgs) Handles btnRelConsulta.Click
        Dim codigo As Integer
        codigo = txtCodigo.Text
        Dim form = New frmRelConsulta(codigo)
        form.ShowDialog()
    End Sub

    Private Sub btnRelReceita_Click(sender As Object, e As EventArgs) Handles btnRelReceita.Click
        Dim codigo As Integer
        codigo = txtCodigo.Text
        Dim form = New frmRelReceita(codigo)
        form.ShowDialog()
    End Sub
End Class