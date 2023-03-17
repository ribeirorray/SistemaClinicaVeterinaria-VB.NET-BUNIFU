Imports MySql.Data.MySqlClient

Public Class frmCategoria
    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        btnSalvar.Enabled = True
        txtDescricao.Enabled = True
        txtDescricao.Text = ""

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtDescricao.Text <> "" Then

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "INSERT INTO categorias (descricao) VALUES ('" & txtDescricao.Text & "') "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Dados Salvos com Sucesso!!")
            Catch ex As Exception
                MsgBox("Erro ao Salvar!! " + ex.Message)
            End Try


            btnSalvar.Enabled = False
            Listar()

        Else
            MsgBox("Preencha o campo Descrição")
        End If
    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub

    Private Sub Listar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from categorias order by id_categoria desc"

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

        'dg.Columns(0).Visible = False

        dg.Columns(0).HeaderText = "Id da Categoria"
        dg.Columns(1).HeaderText = "Descrição"

        dg.Columns(0).Width = 140
        dg.Columns(1).Width = 140

    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick

        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        txtDescricao.Enabled = True

        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtDescricao.Text = dg.CurrentRow.Cells(1).Value
    End Sub

    Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblRegistros.Text = total
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtDescricao.Text <> "" Then

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE categorias SET descricao = '" & txtDescricao.Text & "' where id_categoria = '" & txtCodigo.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Dados Editado com Sucesso!!")
            Catch ex As Exception
                MsgBox("Erro ao Editar!! " + ex.Message)
            End Try


            btnEditar.Enabled = False
            btnExcluir.Enabled = False
            txtDescricao.Text = ""
            Listar()

        Else
            MsgBox("Preencha o campo Descrição")
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click



        If txtCodigo.Text <> "" Then

            Dim result As DialogResult = MessageBox.Show("Confirmar Exclusão?", "Excluir Registro", MessageBoxButtons.YesNo)
            If result = vbYes Then
                Try
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "DELETE FROM categorias where id_categoria = '" & txtCodigo.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Dado Excluido com Sucesso!!")
                Catch ex As Exception
                    MsgBox("Erro ao Excluir!! " + ex.Message)
                End Try

                btnEditar.Enabled = False
                btnExcluir.Enabled = False
                txtDescricao.Text = ""
                Listar()


            End If






        Else
            MsgBox("Selecione um registro para excluir")
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub Buscar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from categorias where descricao LIKE '" & txtBuscar.Text & "%' order by id_categoria desc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()
            ContarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub
End Class