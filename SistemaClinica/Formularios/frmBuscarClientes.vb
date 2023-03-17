Imports MySql.Data.MySqlClient

Public Class frmBuscarClientes



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

    Private Sub frmBuscarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub

    Private Sub dg_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellDoubleClick

        Dim codigo As Integer
        Dim nome As String



        codigo = dg.CurrentRow.Cells(0).Value
        nome = dg.CurrentRow.Cells(1).Value



        If codigo <> 0 And nome <> "" Then
            Dim form = New frmAnimais()
            codCliente = codigo
            nomeCliente = nome

            Me.Hide()



        Else
            MsgBox("Você precisa passar os dados!!")
        End If





    End Sub



End Class