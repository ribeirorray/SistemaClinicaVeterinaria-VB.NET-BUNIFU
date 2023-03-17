Imports MySql.Data.MySqlClient

Public Class frmConsultaVet
    Private Sub frmConsultaVet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
        btnNovo.BackgroundImage = My.Resources.bt_novo_inativo
    End Sub

    Private Sub Listar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select c.id_consulta, c.id_animal, c.id_veterinario, c.data, c.hora, c.hora_inicio, c.hora_fim, c.obs, c.status, a.nome, v.nome from consultas as c INNER JOIN animais as a on c.id_animal = a.id_animal INNER JOIN veterinarios as v on c.id_veterinario = v.id_veterinario where data = curDate() and (status = 'Marcado' or status = 'Consultando') and v.nome = '" & nomeUsuario & "' order by c.hora asc"

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
        dg.Columns(6).Visible = False
        dg.Columns(7).Visible = False
        dg.Columns(10).Visible = False
        dg.Columns(3).Visible = False

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

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        btnNovo.Enabled = True
        btnNovo.BackgroundImage = My.Resources.btn_novo

        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtStatus.Text = dg.CurrentRow.Cells(8).Value

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        txtObs.Text = ""
        txtObs.Focus()
        btnSalvar.Enabled = True
        btnSalvar.BackgroundImage = My.Resources.bt_salvar

        btnNovo.Enabled = False
        btnNovo.BackgroundImage = My.Resources.bt_novo_inativo

        txtObs.Enabled = True

        Try

            abrir()
            Dim cmd As MySqlCommand
            Dim sql As String

            If txtStatus.Text <> "Consultando" Then
                sql = "UPDATE consultas SET hora_inicio = curTime() where id_consulta = '" & txtCodigo.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
            End If

            sql = "UPDATE consultas SET status = 'Consultando' where id_consulta = '" & txtCodigo.Text & "' "

            cmd = New MySqlCommand(sql, con)

            cmd.ExecuteNonQuery()
            'MsgBox("Dados Salvos com Sucesso!!")
        Catch ex As Exception
            MsgBox("Erro ao Salvar!! " + ex.Message)
        End Try

        Listar()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtObs.Text <> "" Then
            Try

                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "UPDATE consultas SET obs = '" & txtObs.Text & "', status = 'Finalizado', hora_fim = curTime() where id_consulta = '" & txtCodigo.Text & "' "

                cmd = New MySqlCommand(sql, con)

                cmd.ExecuteNonQuery()
                MsgBox("Consulta Finalizada!!")

                btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
                btnSalvar.Enabled = False
                txtObs.Text = ""

                Dim codigo As Integer
                codigo = txtCodigo.Text
                Dim form = New frmRelConsulta(codigo)
                form.ShowDialog()


            Catch ex As Exception
                MsgBox("Erro ao Salvar!! " + ex.Message)
            End Try

            Listar()
        Else
            MsgBox("Insira as observações")
            txtObs.Focus()
        End If

    End Sub
End Class