Imports MySql.Data.MySqlClient

Public Class frmConsultaMarcacao
    Private Sub frmConsultaMarcacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtBuscar.Value = Now
        CarregarAnimais()
        CarregarVeterinarios()
        DesabilitarCampos()
        Listar()

        If HorarioLivre <> "" Then
            dtHora.Text = HorarioLivre
        Else
            dtHora.Text = Now.ToString("yyyy-MM-dd 13:00")
        End If

        cbVeterinario.Text = Veterinario

    End Sub


    Private Sub CarregarAnimais()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from animais order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                cbAnimais.ValueMember = "id_animal"
                cbAnimais.DisplayMember = "nome"
                cbAnimais.DataSource = dt


            Else
                'MsgBox("É preciso cadastrar antes as categorias!")
            End If
        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub


    Private Sub CarregarVeterinarios()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from veterinarios order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                cbVeterinario.ValueMember = "id_veterinario"
                cbVeterinario.DisplayMember = "nome"
                cbVeterinario.DataSource = dt


            Else
                'MsgBox("É preciso cadastrar antes as categorias!")
            End If
        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub


    Sub Limpar()


        txtCodigo.Text = ""
        dtData.Value = Now

        'dtHora.Value = Now.ToString("yyyy-MM-dd 13:00")

        'dtHora.Text = HorarioLivre

    End Sub

    Sub HabilitarCampos()
        cbAnimais.Enabled = True
        cbVeterinario.Enabled = True
        dtHora.Enabled = True
        dtData.Enabled = True
    End Sub

    Sub DesabilitarCampos()
        cbAnimais.Enabled = False
        cbVeterinario.Enabled = False
        dtHora.Enabled = False
        dtData.Enabled = False
    End Sub



    Private Sub Listar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select c.id_consulta, c.id_animal, c.id_veterinario, c.data, c.hora, c.hora_inicio, c.hora_fim, c.obs, c.status, a.nome, v.nome from consultas as c INNER JOIN animais as a on c.id_animal = a.id_animal INNER JOIN veterinarios as v on c.id_veterinario = v.id_veterinario where data = curDate() and status = 'Marcado' order by c.hora asc"

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
        dg.Columns(5).Visible = False
        dg.Columns(6).Visible = False
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

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Limpar()
        HabilitarCampos()
        btnSalvar.Enabled = True
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim data As String
        data = dtData.Value.ToString("yyyy-MM-dd")

        If cbVeterinario.Text = "" Or cbAnimais.Text = "" Then
            MsgBox("Preencha os campos!")
        Else
            Try


                'VERIFICAR SE O HORÁRIO EXISTE NA TABELA DE HORÁRIOS
                abrir()
                Dim cmdHorario As MySqlCommand
                Dim readerHora As MySqlDataReader
                Dim sql2 As String
                sql2 = "select * from horarios where horario = '" & dtHora.Text & "' "
                cmdHorario = New MySqlCommand(sql2, con)
                readerHora = cmdHorario.ExecuteReader


                If readerHora.Read = True Then
                    'VERIFICAR SE O HORÁRIO DA CONSULTA ESTÁ LIBERADO
                    abrir()
                    readerHora.Close()
                    Dim cmdhora As MySqlCommand
                    Dim reader As MySqlDataReader
                    Dim sqlhora As String
                    sqlhora = "select * from consultas where hora = '" & dtHora.Text & "' and data = '" & data & "' and id_veterinario = '" & cbVeterinario.SelectedValue & "' and status = 'Marcado' "
                    cmdhora = New MySqlCommand(sqlhora, con)
                    reader = cmdhora.ExecuteReader

                    If reader.Read = True Then

                        MsgBox("Este horário não está disponível!")
                        reader.Close()
                        fechar()
                        Exit Sub
                    Else

                        reader.Close()
                        abrir()
                        Dim cmd As MySqlCommand
                        Dim sql As String
                        sql = "INSERT INTO consultas (id_animal, id_veterinario, data, hora, hora_inicio, hora_fim, obs, status) VALUES ('" & cbAnimais.SelectedValue & "', '" & cbVeterinario.SelectedValue & "', '" & data & "', '" & dtHora.Text & "',  '',  '', '', 'Marcado') "
                        cmd = New MySqlCommand(sql, con)

                        cmd.ExecuteNonQuery()
                        MsgBox("Dados Salvos com Sucesso!!")
                    End If
                Else
                    MsgBox("Este Horário não está cadastrado!")
                    fechar()
                End If






            Catch ex As Exception
                MsgBox("Erro ao Salvar!! " + ex.Message)
            End Try


            btnSalvar.Enabled = False
            Limpar()
            Listar()

        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim data As String
        data = dtData.Value.ToString("yyyy-MM-dd")

        If cbVeterinario.Text = "" Or cbAnimais.Text = "" Then
            MsgBox("Preencha os campos!")
        Else
            Try

                'VERIFICAR SE O HORÁRIO DA CONSULTA JÁ EXISTE
                abrir()


                Dim cmdhora As MySqlCommand
                Dim reader As MySqlDataReader
                Dim sqlhora As String
                sqlhora = "select * from consultas where hora = '" & dtHora.Text & "' and data = '" & data & "' and id_veterinario = '" & cbVeterinario.SelectedValue & "' and status = 'Marcado' "
                cmdhora = New MySqlCommand(sqlhora, con)
                reader = cmdhora.ExecuteReader

                If reader.Read = True Then

                    MsgBox("Este horário não está disponível!")
                    reader.Close()
                    fechar()
                    Exit Sub
                Else
                    reader.Close()
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "UPDATE consultas SET id_veterinario = '" & cbVeterinario.SelectedValue & "', data = '" & data & "', hora = '" & dtHora.Text & "' where id_consulta = '" & txtCodigo.Text & "' "
                    cmd = New MySqlCommand(sql, con)

                    cmd.ExecuteNonQuery()
                    MsgBox("Dados Salvos com Sucesso!!")
                End If


            Catch ex As Exception
                MsgBox("Erro ao Salvar!! " + ex.Message)
            End Try


            btnEditar.Enabled = False
            btnExcluir.Enabled = False
            DesabilitarCampos()
            Limpar()
            Listar()

        End If
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        HabilitarCampos()
        cbAnimais.Enabled = False

        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
        cbAnimais.SelectedValue = dg.CurrentRow.Cells(1).Value
        cbVeterinario.SelectedValue = dg.CurrentRow.Cells(2).Value
        dtData.Value = dg.CurrentRow.Cells(3).Value
        dtHora.Text = dg.CurrentRow.Cells(4).Value.ToString
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim data As String
        data = dtData.Value.ToString("yyyy-MM-dd")

        If txtCodigo.Text = "" Then
            MsgBox("Selecione um registro para exclusão!")
        Else
            Try

                Dim result As DialogResult = MessageBox.Show("Confirmar Exclusão?", "Excluir Registro", MessageBoxButtons.YesNo)
                If result = vbYes Then
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "UPDATE consultas SET  status = 'Cancelado' where id_consulta = '" & txtCodigo.Text & "' "
                    cmd = New MySqlCommand(sql, con)

                    cmd.ExecuteNonQuery()
                    MsgBox("Dados Salvos com Sucesso!!")

                End If

            Catch ex As Exception
                MsgBox("Erro ao Salvar!! " + ex.Message)
            End Try


            btnEditar.Enabled = False
            btnExcluir.Enabled = False
            DesabilitarCampos()
            Limpar()
            Listar()

        End If
    End Sub


    Private Sub Buscar()

        Dim data As String
        data = dtBuscar.Value.ToString("yyyy-MM-dd")

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select c.id_consulta, c.id_animal, c.id_veterinario, c.data, c.hora, c.hora_inicio, c.hora_fim, c.obs, c.status, a.nome, v.nome from consultas as c INNER JOIN animais as a on c.id_animal = a.id_animal INNER JOIN veterinarios as v on c.id_veterinario = v.id_veterinario where data = '" & data & "' and status = 'Marcado' order by c.hora asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()
            ContarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub

    Private Sub dtBuscar_ValueChanged(sender As Object, e As EventArgs) Handles dtBuscar.ValueChanged
        Buscar()
    End Sub






End Class