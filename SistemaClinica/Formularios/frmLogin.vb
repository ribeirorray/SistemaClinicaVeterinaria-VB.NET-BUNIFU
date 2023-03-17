Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnentrar.Click

        Try
            'VERIFICAR SE O USUARIO JÁ EXISTE
            abrir()
            Dim cmdUser As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql2 As String
            sql2 = "select * from funcionarios where (usuario = '" & txtusuario.Text & "' or email = '" & txtusuario.Text & "') and senha = '" & txtsenha.Text & "'"
            cmdUser = New MySqlCommand(sql2, con)
            reader = cmdUser.ExecuteReader



            If reader.Read = True Then

                'RECUPERAÇÃO DO CARGO E NOME DO FUNCIONÁRIO
                Dim cargo As String
                cargo = reader(2)

                Dim nome As String
                nome = reader(1)

                Dim form = New frmPrincipal

                usuario = txtusuario.Text
                cargoUsuario = cargo
                nomeUsuario = nome
                MsgBox("Bem Vindo " + nomeUsuario)
                reader.Close()
                Me.Hide()
                form.ShowDialog()


            Else
                MsgBox("Usuário ou senha incorretos! ")
                fechar()
            End If



        Catch ex As Exception
            MsgBox("Erro ao Logar" + ex.Message)
        End Try


    End Sub


    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()

    End Sub
End Class