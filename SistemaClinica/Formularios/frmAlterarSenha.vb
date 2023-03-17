Imports MySql.Data.MySqlClient

Public Class frmAlterarSenha
    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If txtConfirmar.Text <> "" And txtSenha.Text <> "" Then

            If txtSenha.Text = txtConfirmar.Text Then
                Try
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "UPDATE funcionarios SET senha = '" & txtSenha.Text & "' where usuario = '" & usuario & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()



                    MsgBox("Senha Editada com Sucesso!!")
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Erro ao Editar!! " + ex.Message)
                End Try
            Else
                MsgBox("As senhas não correspondem!!")
            End If
        Else
            MsgBox("Preencha os campos!!")
        End If
    End Sub
End Class