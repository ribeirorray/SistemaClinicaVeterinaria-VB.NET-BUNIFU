Imports MySql.Data.MySqlClient

Public Class frmClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        rbNome.Checked = True

        InativarBotoes()
    End Sub

    Private Sub InativarBotoes()
        btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
        btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo

        btnEditar.Enabled = False
        btnSalvar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Sub Limpar()
        txtBuscar.Text = ""
        txtCodigo.Text = ""
        txtCPF.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtTelefone.Text = ""

        txtEmail.Text = ""
    End Sub

    Sub HabilitarCampos()
        txtCPF.Enabled = True
        txtNome.Enabled = True
        txtTelefone.Enabled = True

        txtEndereco.Enabled = True

        txtEmail.Enabled = True
    End Sub

    Sub DesabilitarCampos()
        txtCPF.Enabled = False
        txtNome.Enabled = False
        txtTelefone.Enabled = False

        txtEndereco.Enabled = False

        txtEmail.Enabled = False
    End Sub



    Private Sub Listar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from clientes order by nome asc"

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


        dg.Columns(0).HeaderText = "Id do Cliente"
        dg.Columns(1).HeaderText = "Nome"

        dg.Columns(2).HeaderText = "Telefone"
        dg.Columns(3).HeaderText = "CPF"
        dg.Columns(4).HeaderText = "Endereço"

        dg.Columns(5).HeaderText = "Email"



    End Sub


    Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblRegistros.Text = total
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Limpar()
        HabilitarCampos()
        btnSalvar.Enabled = True
        btnSalvar.BackgroundImage = My.Resources.bt_salvar


    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtNome.Text <> "" Or txtCPF.Text <> "" Then

            Try


                'VERIFICAR SE O CLIENTE JÁ EXISTE
                abrir()
                Dim cmdUser As MySqlCommand
                Dim reader As MySqlDataReader
                Dim sql2 As String
                sql2 = "select * from clientes where cpf = '" & txtCPF.Text & "' "
                cmdUser = New MySqlCommand(sql2, con)
                reader = cmdUser.ExecuteReader


                If reader.Read = True Then
                    MsgBox("Este cliente já está cadastrado!")
                    fechar()
                Else
                    reader.Close()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "INSERT INTO clientes ( nome, telefone, cpf, endereco, email) VALUES ('" & txtNome.Text & "',  '" & txtTelefone.Text & "',  '" & txtCPF.Text & "', '" & txtEndereco.Text & "', '" & txtEmail.Text & "') "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Dados Salvos com Sucesso!!")

                    InativarBotoes()
                    Limpar()
                    Listar()
                End If


            Catch ex As Exception
                MsgBox("Erro ao Salvar!! " + ex.Message)
            End Try




        Else
            MsgBox("Preencha os campos!")
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtNome.Text <> "" Then

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE clientes SET nome = '" & txtNome.Text & "',  telefone = '" & txtTelefone.Text & "', cpf = '" & txtCPF.Text & "', endereco = '" & txtEndereco.Text & "', email = '" & txtEmail.Text & "' where id_cliente = '" & txtCodigo.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Dados Editado com Sucesso!!")
            Catch ex As Exception
                MsgBox("Erro ao Editar!! " + ex.Message)
            End Try


            InativarBotoes()
            DesabilitarCampos()
            Limpar()
            Listar()

        Else
            MsgBox("Preencha os campos")
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
                    sql = "DELETE FROM clientes where id_cliente = '" & txtCodigo.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Dado Excluido com Sucesso!!")
                Catch ex As Exception
                    MsgBox("Erro ao Excluir!! " + ex.Message)
                End Try

                InativarBotoes()
                DesabilitarCampos()
                Limpar()
                Listar()


            End If


        Else
            MsgBox("Selecione um registro para excluir")
        End If
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        btnEditar.Enabled = True
        btnExcluir.Enabled = True

        btnEditar.BackgroundImage = My.Resources.bt_editar_menor
        btnExcluir.BackgroundImage = My.Resources.bt_excluir_menor

        HabilitarCampos()

        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtNome.Text = dg.CurrentRow.Cells(1).Value
        txtTelefone.Text = dg.CurrentRow.Cells(2).Value
        txtCPF.Text = dg.CurrentRow.Cells(3).Value
        txtEndereco.Text = dg.CurrentRow.Cells(4).Value
        txtEmail.Text = dg.CurrentRow.Cells(5).Value
    End Sub

    Private Sub Buscar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from clientes where nome LIKE '" & txtBuscar.Text & "%' order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()
            ContarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub

    Private Sub BuscarCPF()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from clientes where cpf = '" & txtBuscarCPF.Text & "' order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dg.DataSource = dt

            
            FormatarDG()
            ContarLinhas()

        Catch ex As Exception
            'MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub rbNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbNome.CheckedChanged
        txtBuscar.Text = ""
        txtBuscarCPF.Text = ""
        txtBuscar.Visible = True
        txtBuscarCPF.Visible = False

        Buscar()
    End Sub

    Private Sub rbCPF_CheckedChanged(sender As Object, e As EventArgs) Handles rbCPF.CheckedChanged
        txtBuscar.Text = ""
        txtBuscarCPF.Text = ""
        txtBuscar.Visible = False
        txtBuscarCPF.Visible = True

        Buscar()
    End Sub

    Private Sub txtBuscarCPF_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCPF.TextChanged
        BuscarCPF()
    End Sub


End Class