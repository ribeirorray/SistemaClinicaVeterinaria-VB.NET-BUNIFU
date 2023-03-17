Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmAnimais

    Public imgNome As String
    Dim abriu As Boolean

    Private Sub frmAnimais_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Limpar()
        CarregarCategorias()
        CarregarCategoriasBuscar()
        Listar()
    End Sub

    Private Sub CarregarCategorias()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from categorias order by id_categoria desc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                cbCategoria.ValueMember = "id_categoria"
                cbCategoria.DisplayMember = "descricao"
                cbCategoria.DataSource = dt


            Else
                'MsgBox("É preciso cadastrar antes as categorias!")
            End If





        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub


    Private Sub CarregarCategoriasBuscar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from categorias order by id_categoria desc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then

                cbCategoriaBuscar.ValueMember = "id_categoria"
                cbCategoriaBuscar.DisplayMember = "descricao"
                cbCategoriaBuscar.DataSource = dt
            Else
                'MsgBox("É preciso cadastrar antes as categorias!")
            End If





        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub


    Sub Limpar()
        imagem.Image = My.Resources.sem_foto
        imgNome = "sem-foto.jpg"


        txtBuscar.Text = ""
        txtCodigo.Text = ""
        txtIdade.Text = ""
        txtNome.Text = ""
        txtRaça.Text = ""
        txtCodCliente.Text = ""
        txtCliente.Text = ""

    End Sub

    Sub HabilitarCampos()
        txtIdade.Enabled = True
        txtNome.Enabled = True
        txtRaça.Enabled = True
        cbCategoria.Enabled = True
    End Sub

    Sub DesabilitarCampos()
        txtIdade.Enabled = False
        txtNome.Enabled = False
        txtRaça.Enabled = False
        cbCategoria.Enabled = False
    End Sub



    Private Sub Listar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select a.id_animal, c.descricao, a.nome, a.raca, a.idade, a.data_cadastro, a.id_categoria, a.id_cliente, cl.nome, a.imagem from animais as a INNER JOIN categorias as c on a.id_categoria = c.id_categoria INNER JOIN clientes as cl on a.id_cliente = cl.id_cliente order by a.nome asc"

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
        dg.Columns(7).Visible = False
        dg.Columns(9).Visible = False

        dg.Columns(0).HeaderText = "Id do Animal"
        dg.Columns(1).HeaderText = "Categoria"
        dg.Columns(2).HeaderText = "Nome"
        dg.Columns(3).HeaderText = "Raça"
        dg.Columns(4).HeaderText = "Idade"
        dg.Columns(5).HeaderText = "Data_Cadastro"
        dg.Columns(8).HeaderText = "Dono"

        'dg.Columns(0).Width = 140
        'dg.Columns(1).Width = 140

    End Sub


    Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblRegistros.Text = total
    End Sub



    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        If cbCategoria.Text <> "" Then
            Limpar()
            HabilitarCampos()
            btnSalvar.Enabled = True
        Else
            MsgBox("É preciso cadastrar antes a categoria!")
        End If


    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        'FORMATAÇÃO DA DATA PARA PADRÃO DO MYSQL
        Dim data As String
        data = Now.ToString("yyyy-MM-dd")



        If txtNome.Text = "" Or txtRaça.Text = "" Or txtCliente.Text = "" Then
            MsgBox("Preencha os campos!")
        Else

            'TRATANDO IMAGEM PARA O BANCO
            Dim fs As FileStream

            fs = New FileStream(imgNome, FileMode.Open, FileAccess.Read)
            Dim picByte As Byte() = New Byte(fs.Length - 1) {}
            fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
            fs.Close()

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "INSERT INTO animais (id_categoria, nome, raca, idade, data_cadastro, id_cliente, imagem) VALUES ('" & cbCategoria.SelectedValue & "', '" & txtNome.Text & "', '" & txtRaça.Text & "', '" & txtIdade.Text & "',  '" & data & "',  '" & txtCodCliente.Text & "', " & " @img) "

                'DECLARAÇÃO DO PARAMETRO
                Dim param As New MySqlParameter
                param.MySqlDbType = MySqlDbType.Binary
                param.ParameterName = "img"
                param.Value = picByte

                cmd = New MySqlCommand(sql, con)
                cmd.Parameters.Add(param)
                cmd.ExecuteNonQuery()
                MsgBox("Dados Salvos com Sucesso!!")
            Catch ex As Exception
                MsgBox("Erro ao Salvar!! " + ex.Message)
            End Try


            btnSalvar.Enabled = False
            Limpar()
            Listar()


        End If
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick

        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        HabilitarCampos()
        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
        cbCategoria.Text = dg.CurrentRow.Cells(1).Value
        txtNome.Text = dg.CurrentRow.Cells(2).Value
        txtRaça.Text = dg.CurrentRow.Cells(3).Value
        txtIdade.Text = dg.CurrentRow.Cells(4).Value
        txtCodCliente.Text = dg.CurrentRow.Cells(7).Value
        txtCliente.Text = dg.CurrentRow.Cells(8).Value

        'CONVERTENDO BYTE EM PICKTURE BOX

        Dim img As Byte() = dg.CurrentRow.Cells(9).Value
        Dim ms As MemoryStream = New MemoryStream(img)
        imagem.Image = System.Drawing.Image.FromStream(ms)

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtNome.Text <> "" Then

            Try

                If abriu Then
                    'TRATANDO IMAGEM PARA O BANCO
                    Dim fs As FileStream

                    fs = New FileStream(imgNome, FileMode.Open, FileAccess.Read)
                    Dim picByte As Byte() = New Byte(fs.Length - 1) {}
                    fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
                    fs.Close()

                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "UPDATE animais SET id_categoria = '" & cbCategoria.SelectedValue & "', nome = '" & txtNome.Text & "', raca = '" & txtRaça.Text & "', idade = '" & txtIdade.Text & "', id_cliente = '" & txtCodCliente.Text & "', imagem = " & " @img where id_animal = '" & txtCodigo.Text & "' "

                    'DECLARAÇÃO DO PARAMETRO
                    Dim param As New MySqlParameter
                    param.MySqlDbType = MySqlDbType.Binary
                    param.ParameterName = "img"
                    param.Value = picByte

                    cmd = New MySqlCommand(sql, con)
                    cmd.Parameters.Add(param)
                    cmd.ExecuteNonQuery()
                    MsgBox("Dados Editado com Sucesso!!")
                Else
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "UPDATE animais SET id_categoria = '" & cbCategoria.SelectedValue & "', nome = '" & txtNome.Text & "', raca = '" & txtRaça.Text & "', idade = '" & txtIdade.Text & "', id_cliente = '" & txtCodCliente.Text & "' where id_animal = '" & txtCodigo.Text & "' "

                    cmd = New MySqlCommand(sql, con)

                    cmd.ExecuteNonQuery()
                    MsgBox("Dados Editado com Sucesso!!")
                End If



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
                    sql = "DELETE FROM animais where id_animal = '" & txtCodigo.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
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
            sql = "select a.id_animal, c.descricao, a.nome, a.raca, a.idade, a.data_cadastro, a.id_categoria, a.id_cliente, cl.nome, a.imagem from animais as a INNER JOIN categorias as c on a.id_categoria = c.id_categoria INNER JOIN clientes as cl on a.id_cliente = cl.id_cliente where a.nome LIKE '" & txtBuscar.Text & "%' and a.id_categoria = '" & cbCategoriaBuscar.SelectedValue & "'  order by a.nome asc"

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

    Private Sub cbCategoriaBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoriaBuscar.SelectedIndexChanged
        Buscar()
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim form = New frmBuscarClientes()
        'Me.Hide()
        form.ShowDialog()
    End Sub

    Private Sub frmAnimais_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtCliente.Text = nomeCliente
        txtCodCliente.Text = codCliente
    End Sub

    Private Sub btnImg_Click(sender As Object, e As EventArgs) Handles btnImg.Click
        Try
            Dim dlgImage As FileDialog = New OpenFileDialog
            dlgImage.Filter = "Image File(*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png"
            If (dlgImage.ShowDialog) = DialogResult.OK Then
                imgNome = dlgImage.FileName
                abriu = True

                Dim novaImg As New Bitmap(imgNome)
                imagem.SizeMode = PictureBoxSizeMode.StretchImage
                imagem.Image = DirectCast(novaImg, Image)

                'MsgBox(imgNome)
            Else
                dlgImage = Nothing
            End If
        Catch ex As Exception
            imgNome = ""
            MsgBox(ex.Message.ToString)
        End Try


    End Sub

    Private Sub frmAnimais_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        nomeCliente = txtCliente.Text
        codCliente = txtCodCliente.Text
    End Sub
End Class