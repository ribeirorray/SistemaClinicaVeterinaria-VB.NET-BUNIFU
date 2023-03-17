Imports MySql.Data.MySqlClient

Public Class frmFuncionarios

    Public id_fun As Integer

    Private Sub frmFuncionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub

    Sub Limpar()
        txtBuscar.Text = ""
        txtCodigo.Text = ""
        txtCPF.Text = ""
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtTelefone.Text = ""
        txtSenha.Text = ""
        txtUsuario.Text = ""
        txtEmail.Text = ""
        cbCargo.Text = ""
        txtCRMV.Visible = False
        lblCRMV.Visible = False
    End Sub

    Sub HabilitarCampos()
        txtCPF.Enabled = True
        txtNome.Enabled = True
        txtTelefone.Enabled = True
        cbCargo.Enabled = True
        txtEndereco.Enabled = True
        txtSenha.Enabled = True
        txtUsuario.Enabled = True
        txtEmail.Enabled = True
    End Sub

    Sub DesabilitarCampos()
        txtCPF.Enabled = False
        txtNome.Enabled = False
        txtTelefone.Enabled = False
        cbCargo.Enabled = False
        txtEndereco.Enabled = False
        txtSenha.Enabled = False
        txtUsuario.Enabled = False
        txtEmail.Enabled = False
    End Sub



    Private Sub Listar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from funcionarios order by nome asc"

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
        dg.Columns(6).Visible = False

        dg.Columns(0).HeaderText = "Id do Animal"
        dg.Columns(1).HeaderText = "Nome"
        dg.Columns(2).HeaderText = "Cargo"
        dg.Columns(3).HeaderText = "Endereço"
        dg.Columns(4).HeaderText = "Telefone"
        dg.Columns(5).HeaderText = "CPF"
        dg.Columns(7).HeaderText = "Usuário"
        dg.Columns(8).HeaderText = "Email"

        dg.Columns(4).Width = 80
        dg.Columns(2).Width = 80

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
        If txtNome.Text <> "" Or txtCPF.Text <> "" Then

            Try


                'VERIFICAR SE O USUARIO JÁ EXISTE
                abrir()
                Dim cmdUser As MySqlCommand
                Dim reader As MySqlDataReader
                Dim sql2 As String
                sql2 = "select * from funcionarios where usuario = '" & txtUsuario.Text & "' "
                cmdUser = New MySqlCommand(sql2, con)
                reader = cmdUser.ExecuteReader


                If reader.Read = True Then
                    MsgBox("Este nome de usuário já existe no Banco!")
                    fechar()
                Else
                    reader.Close()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "INSERT INTO funcionarios ( nome, cargo, endereco, telefone, cpf, senha, usuario, email) VALUES ('" & txtNome.Text & "', '" & cbCargo.Text & "', '" & txtEndereco.Text & "', '" & txtTelefone.Text & "',  '" & txtCPF.Text & "',  '" & txtSenha.Text & "',  '" & txtUsuario.Text & "',  '" & txtEmail.Text & "') "
                    cmd = New MySqlCommand(sql, con)

                    If cbCargo.Text = "Veterinario" And txtCRMV.Text = "  -" Then
                        MsgBox("Preencher o Campo CRMV")
                        txtCRMV.Focus()
                        Exit Sub
                    Else
                        cmd.ExecuteNonQuery()
                    End If


                    'RECUPERAR O ID DO FUNCIONÁRIO

                    abrir()
                    Dim cmdFunc As MySqlCommand
                    Dim readerFunc As MySqlDataReader
                    Dim sqlFunc As String
                    sqlFunc = "SELECT MAX(id_funcionario) FROM funcionarios"
                    cmdFunc = New MySqlCommand(sqlFunc, con)
                    readerFunc = cmdFunc.ExecuteReader

                    If readerFunc.Read = True Then

                        id_fun = readerFunc(0)
                        'MsgBox(id_fun)
                        readerFunc.Close()
                    End If


                    'INSERINDO DADOS NA TABELA VETERINARIO
                    If cbCargo.Text = "Veterinario" Then

                        sql = "INSERT INTO veterinarios ( id_funcionario, nome, crmv ) VALUES ('" & id_fun & "',   '" & txtNome.Text & "',  '" & txtCRMV.Text & "') "
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()
                    End If

                    MsgBox("Dados Salvos com Sucesso!!")


                    btnSalvar.Enabled = False
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

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        HabilitarCampos()
        cbCargo.Enabled = False

        txtCodigo.Text = dg.CurrentRow.Cells(0).Value

        txtNome.Text = dg.CurrentRow.Cells(1).Value
        cbCargo.Text = dg.CurrentRow.Cells(2).Value
        txtEndereco.Text = dg.CurrentRow.Cells(3).Value
        txtTelefone.Text = dg.CurrentRow.Cells(4).Value
        txtCPF.Text = dg.CurrentRow.Cells(5).Value
        txtSenha.Text = dg.CurrentRow.Cells(6).Value
        txtUsuario.Text = dg.CurrentRow.Cells(7).Value
        txtEmail.Text = dg.CurrentRow.Cells(8).Value

        lblCRMV.Visible = False
        txtCRMV.Visible = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtNome.Text <> "" Then

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE funcionarios SET nome = '" & txtNome.Text & "', cargo = '" & cbCargo.Text & "', endereco = '" & txtEndereco.Text & "', telefone = '" & txtTelefone.Text & "', cpf = '" & txtCPF.Text & "', senha = '" & txtSenha.Text & "', usuario = '" & txtUsuario.Text & "', email = '" & txtEmail.Text & "' where id_funcionario = '" & txtCodigo.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                If cbCargo.Text = "Veterinario" Then

                    sql = "UPDATE veterinarios SET nome = '" & txtNome.Text & "' where id_funcionario = '" & txtCodigo.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                End If

                MsgBox("Dados Editado com Sucesso!!")
            Catch ex As Exception
                MsgBox("Erro ao Editar!! " + ex.Message)
            End Try


            btnEditar.Enabled = False
            btnExcluir.Enabled = False
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
                    sql = "DELETE FROM funcionarios where id_funcionario = '" & txtCodigo.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    If cbCargo.Text = "Veterinario" Then

                        sql = "DELETE FROM veterinarios where id_funcionario = '" & txtCodigo.Text & "' "
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()
                    End If

                    MsgBox("Dado Excluido com Sucesso!!")
                Catch ex As Exception
                    MsgBox("Erro ao Excluir!! " + ex.Message)
                End Try

                btnEditar.Enabled = False
                btnExcluir.Enabled = False
                DesabilitarCampos()
                Limpar()
                Listar()


            End If


        Else
            MsgBox("Selecione um registro para excluir")
        End If
    End Sub



    Private Sub Buscar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from funcionarios where nome LIKE '" & txtBuscar.Text & "%' and cargo = '" & cbCargoBuscar.Text & "' order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()
            ContarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub cbCargoBuscar_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbCargoBuscar.SelectedValueChanged
        Buscar()
    End Sub

    Private Sub cbCargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCargo.SelectedIndexChanged
        If cbCargo.Text = "Veterinario" Then
            txtCRMV.Visible = True
            lblCRMV.Visible = True
        Else
            txtCRMV.Visible = False
            lblCRMV.Visible = False
        End If
    End Sub
End Class