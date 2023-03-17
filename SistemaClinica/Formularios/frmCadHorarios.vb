Imports MySql.Data.MySqlClient

Public Class frmCadHorarios
    Private Sub frmCadHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        InativarBotoes()
    End Sub

    Private Sub Listar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from horarios order by horario asc"

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




        dg.Columns(0).HeaderText = "Id do Horário"

        dg.Columns(1).HeaderText = "Horário"




    End Sub


    Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblRegistros.Text = total
    End Sub


    Private Sub InativarBotoes()
        btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
        btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo

        btnEditar.Enabled = False
        btnSalvar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        dtHora.Enabled = True
        btnSalvar.Enabled = True
        btnSalvar.BackgroundImage = My.Resources.bt_salvar
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try


            'VERIFICAR SE O HORÁRIO JÁ EXISTE
            abrir()
            Dim cmdHora As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql2 As String
            sql2 = "select * from horarios where horario = '" & dtHora.Text & "' "
            cmdHora = New MySqlCommand(sql2, con)
            reader = cmdHora.ExecuteReader


            If reader.Read = True Then
                MsgBox("Este Horário já está cadastrado!")
                fechar()
            Else
                reader.Close()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "INSERT INTO horarios (horario) VALUES ('" & dtHora.Text & "') "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Dados Salvos com Sucesso!!")

                InativarBotoes()

                Listar()
            End If


        Catch ex As Exception
            MsgBox("Erro ao Salvar!! " + ex.Message)
        End Try


    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        btnEditar.Enabled = True
        btnExcluir.Enabled = True

        btnEditar.BackgroundImage = My.Resources.bt_editar_menor
        btnExcluir.BackgroundImage = My.Resources.bt_excluir_menor

        dtHora.Enabled = True

        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
        dtHora.Text = dg.CurrentRow.Cells(1).Value.ToString

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            abrir()
            Dim cmd As MySqlCommand
            Dim sql As String
            sql = "UPDATE horarios SET horario = '" & dtHora.Text & "' where id_horario = '" & txtCodigo.Text & "' "
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Dados Editado com Sucesso!!")
        Catch ex As Exception
            MsgBox("Erro ao Editar!! " + ex.Message)
        End Try


        InativarBotoes()

        Listar()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If txtCodigo.Text <> "" Then

            Dim result As DialogResult = MessageBox.Show("Confirmar Exclusão?", "Excluir Registro", MessageBoxButtons.YesNo)
            If result = vbYes Then
                Try
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "DELETE FROM horarios where id_horario = '" & txtCodigo.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Dado Excluido com Sucesso!!")
                Catch ex As Exception
                    MsgBox("Erro ao Excluir!! " + ex.Message)
                End Try

                InativarBotoes()

                Listar()


            End If


        Else
            MsgBox("Selecione um registro para excluir")
        End If
    End Sub



End Class