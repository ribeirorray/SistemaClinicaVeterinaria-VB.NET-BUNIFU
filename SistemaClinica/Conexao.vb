Imports MySql.Data.MySqlClient

Module Conexao

    'CONEXÃO LOCAL
    Public con As New MySqlConnection("server=localhost;userid=root;password=;database=sistema_clinica;")

    'CONEXÃO HOSPEDADA
  '  Public con As New MySqlConnection("server=mysql642.umbler.com;userid=hugo_sistema;password=sistema_hugo;database=sistema_clinica;port=41890")



    Sub abrir()
        If con.State = 0 Then
            con.Open()

        End If

    End Sub

    Sub fechar()
        If con.State = 1 Then
            con.Close()

        End If

    End Sub




    'VARIAVEIS PASSADAS COMO PARAMETROS

    Public usuario As String
    Public cargoUsuario As String
    Public nomeUsuario As String

    Public nomeCliente As String
    Public codCliente As String

    Public HorarioLivre As String
    Public Veterinario As String

End Module
