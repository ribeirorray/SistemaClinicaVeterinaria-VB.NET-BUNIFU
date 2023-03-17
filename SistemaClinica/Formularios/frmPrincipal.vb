Imports MySql.Data.MySqlClient

Public Class frmPrincipal
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim form = New frmCategoria
        form.ShowDialog()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim form = New frmFuncionarios
        form.ShowDialog()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsuario.Text = nomeUsuario
        lblCargo.Text = cargoUsuario

        If cargoUsuario = "Veterinario" Then
            ToolStripMenuItem1.Enabled = False
            ToolStripMenuItem4.Enabled = False
            ToolStripMenuItem7.Enabled = False
            MarcaçãoDeConsultaToolStripMenuItem.Enabled = False
            DsToolStripMenuItem.Enabled = False
            DToolStripMenuItem.Enabled = False
            SToolStripMenuItem.Enabled = False
            SToolStripMenuItem1.Enabled = False

        End If

    End Sub

    Private Sub frmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Dim form = New frmCategoria
        form.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Dim form = New frmAnimais()
        form.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim form = New frmClientes
        form.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim form = New frmFuncionarios
        form.ShowDialog()
    End Sub

    Private Sub DsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DsToolStripMenuItem.Click
        Dim form = New frmAnimais()
        form.ShowDialog()
    End Sub

    Private Sub DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DToolStripMenuItem.Click
        Dim form = New frmClientes
        form.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        Dim form = New frmRelAnimais
        form.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        Dim form = New frmRelEspecies
        form.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        Dim form = New frmRelAnimaisEspecies
        form.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        Dim form = New Login
        form.ShowDialog()
    End Sub

    Private Sub MarcaçãoDeConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcaçãoDeConsultaToolStripMenuItem.Click
        Dim form = New frmConsultaMarcacao
        form.ShowDialog()
    End Sub

    Private Sub ConsultasAgendadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasAgendadasToolStripMenuItem.Click
        Dim form = New frmConsultaVet
        form.ShowDialog()
    End Sub

    Private Sub ListaDeConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeConsultasToolStripMenuItem.Click
        Dim form = New frmListaConsultas
        form.ShowDialog()
    End Sub

    Private Sub SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SToolStripMenuItem.Click
        Dim form = New frmConsultaMarcacao
        form.ShowDialog()
    End Sub

    Private Sub HoráriosAtendimentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoráriosAtendimentoToolStripMenuItem.Click
        Dim form = New frmCadHorarios
        form.ShowDialog()
    End Sub

    Private Sub QuadroDeHoráriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuadroDeHoráriosToolStripMenuItem.Click
        Dim form = New frmQuadroHorario
        form.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        Dim form = New frmQuadroHorario
        form.ShowDialog()
    End Sub




    Private Sub ListarConsultasAndamento()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select c.id_consulta, c.id_animal, c.id_veterinario, c.data, c.hora, c.hora_inicio, c.hora_fim, c.obs, c.status, a.nome, v.nome from consultas as c INNER JOIN animais as a on c.id_animal = a.id_animal INNER JOIN veterinarios as v on c.id_veterinario = v.id_veterinario where data = curDate() and status = 'Consultando' order by c.hora desc"

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
        dg.Columns(1).Visible = False
        dg.Columns(2).Visible = False
        'dg.Columns(5).Visible = False
        'dg.Columns(6).Visible = False
        dg.Columns(7).Visible = False
        dg.Columns(3).Visible = False
        dg.Columns(6).Visible = False

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



    Private Sub ListarProxConsultas()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select c.id_consulta, c.id_animal, c.id_veterinario, c.data, c.hora, c.hora_inicio, c.hora_fim, c.obs, c.status, a.nome, v.nome from consultas as c INNER JOIN animais as a on c.id_animal = a.id_animal INNER JOIN veterinarios as v on c.id_veterinario = v.id_veterinario where data = curDate() and status = 'Marcado' order by c.hora asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dg2.DataSource = dt

            FormatarDGProxConsulta()


        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub

    Private Sub FormatarDGProxConsulta()

        dg2.Columns(0).Visible = False
        dg2.Columns(1).Visible = False
        dg2.Columns(2).Visible = False
        dg2.Columns(3).Visible = False
        dg2.Columns(5).Visible = False
        dg2.Columns(6).Visible = False
        dg2.Columns(7).Visible = False
        dg2.Columns(8).Visible = False


        dg2.Columns(0).HeaderText = "Id da Consulta"
        dg2.Columns(1).HeaderText = "Id do Animal"
        dg2.Columns(2).HeaderText = "Id do Veterinário"
        dg2.Columns(3).HeaderText = "Data da Consulta"
        dg2.Columns(4).HeaderText = "Hora Marcada"
        dg2.Columns(5).HeaderText = "Hora Início"
        dg2.Columns(6).HeaderText = "Hora Fim"
        dg2.Columns(7).HeaderText = "Observações"
        dg2.Columns(8).HeaderText = "Status"
        dg2.Columns(9).HeaderText = "Animal"
        dg2.Columns(10).HeaderText = "Veterinário"

        'dg.Columns(0).Width = 140
        'dg.Columns(1).Width = 140

    End Sub



    Private Sub ListarProxConsultasVet()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select c.id_consulta, c.id_animal, c.id_veterinario, c.data, c.hora, c.hora_inicio, c.hora_fim, c.obs, c.status, a.nome, v.nome from consultas as c INNER JOIN animais as a on c.id_animal = a.id_animal INNER JOIN veterinarios as v on c.id_veterinario = v.id_veterinario where data = curDate() and status = 'Marcado' and v.nome = '" & nomeUsuario & "' order by c.hora asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dg3.DataSource = dt

            FormatarDGProxConsultaVet()


        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub

    Private Sub FormatarDGProxConsultaVet()

        dg3.Columns(0).Visible = False
        dg3.Columns(1).Visible = False
        dg3.Columns(2).Visible = False
        dg3.Columns(3).Visible = False
        dg3.Columns(5).Visible = False
        dg3.Columns(6).Visible = False
        dg3.Columns(7).Visible = False
        dg3.Columns(8).Visible = False
        dg3.Columns(10).Visible = False

        dg3.Columns(0).HeaderText = "Id da Consulta"
        dg3.Columns(1).HeaderText = "Id do Animal"
        dg3.Columns(2).HeaderText = "Id do Veterinário"
        dg3.Columns(3).HeaderText = "Data da Consulta"
        dg3.Columns(4).HeaderText = "Hora Marcada"
        dg3.Columns(5).HeaderText = "Hora Início"
        dg3.Columns(6).HeaderText = "Hora Fim"
        dg3.Columns(7).HeaderText = "Observações"
        dg3.Columns(8).HeaderText = "Status"
        dg3.Columns(9).HeaderText = "Animal"
        dg3.Columns(10).HeaderText = "Veterinário"

        'dg.Columns(0).Width = 140
        'dg.Columns(1).Width = 140

    End Sub



    Private Sub ListarProxConsAtend()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select c.id_consulta, c.id_animal, c.id_veterinario, c.data, c.hora, c.hora_inicio, c.hora_fim, c.obs, c.status, a.nome, v.nome from consultas as c INNER JOIN animais as a on c.id_animal = a.id_animal INNER JOIN veterinarios as v on c.id_veterinario = v.id_veterinario where data = curDate() and (status = 'Consultando' or status = 'Marcado') order by c.hora asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dg4.DataSource = dt

            FormatarDGConsAt()


        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub

    Private Sub FormatarDGConsAt()

        dg4.Columns(0).Visible = False
        dg4.Columns(1).Visible = False
        dg4.Columns(2).Visible = False
        dg4.Columns(3).Visible = False
        dg4.Columns(6).Visible = False
        dg4.Columns(7).Visible = False

        dg4.Columns(0).HeaderText = "Id da Consulta"
        dg4.Columns(1).HeaderText = "Id do Animal"
        dg4.Columns(2).HeaderText = "Id do Veterinário"
        dg4.Columns(3).HeaderText = "Data da Consulta"
        dg4.Columns(4).HeaderText = "Hora Marcada"
        dg4.Columns(5).HeaderText = "Hora Início"
        dg4.Columns(6).HeaderText = "Hora Fim"
        dg4.Columns(7).HeaderText = "Observações"
        dg4.Columns(8).HeaderText = "Status"
        dg4.Columns(9).HeaderText = "Animal"
        dg4.Columns(10).HeaderText = "Veterinário"

        'dg.Columns(0).Width = 140
        'dg.Columns(1).Width = 140

    End Sub



    Private Sub ListarConsFim()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select c.id_consulta, c.id_animal, c.id_veterinario, c.data, c.hora, c.hora_inicio, c.hora_fim, c.obs, c.status, a.nome, v.nome from consultas as c INNER JOIN animais as a on c.id_animal = a.id_animal INNER JOIN veterinarios as v on c.id_veterinario = v.id_veterinario where data = curDate() and status = 'Finalizado' order by c.hora desc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dg5.DataSource = dt

            FormatarDGConsFim()


        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub

    Private Sub FormatarDGConsFim()

        dg5.Columns(0).Visible = False
        dg5.Columns(1).Visible = False
        dg5.Columns(2).Visible = False
        dg5.Columns(3).Visible = False
        dg5.Columns(4).Visible = False
        dg5.Columns(7).Visible = False
        dg5.Columns(8).Visible = False

        dg5.Columns(0).HeaderText = "Id da Consulta"
        dg5.Columns(1).HeaderText = "Id do Animal"
        dg5.Columns(2).HeaderText = "Id do Veterinário"
        dg5.Columns(3).HeaderText = "Data da Consulta"
        dg5.Columns(4).HeaderText = "Hora Marcada"
        dg5.Columns(5).HeaderText = "Hora Início"
        dg5.Columns(6).HeaderText = "Hora Fim"
        dg5.Columns(7).HeaderText = "Observações"
        dg5.Columns(8).HeaderText = "Status"
        dg5.Columns(9).HeaderText = "Animal"
        dg5.Columns(10).HeaderText = "Veterinário"

        'dg.Columns(0).Width = 140
        'dg.Columns(1).Width = 140

    End Sub


    Private Sub frmPrincipal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated





        If cargoUsuario = "Admin" Or cargoUsuario = "Gerente" Then

            TotaisAdm()

            ListarConsultasAndamento()
            ListarProxConsultas()
            dg.Visible = True
            dg2.Visible = True
            lblConsAndamento.Visible = True
            lblProxConsultas.Visible = True

            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True

            lblTotAndamento.Visible = True
            lblTotCanceladas.Visible = True
            lblTotMarcadas.Visible = True
            lbltotFim.Visible = True

        End If


        If cargoUsuario = "Veterinario" Then


            ListarProxConsultasVet()

            Me.Width = 500

            lblUsuario.Location = New Point(220, 130)
            Label1.Location = New Point(320, 130)
            lblCargo.Location = New Point(360, 130)

            lblProxConsVet.Visible = True
            dg3.Visible = True
        End If


        If cargoUsuario = "Atendente" Then

            ToolStripMenuItem3.Enabled = False
            HoráriosAtendimentoToolStripMenuItem.Enabled = False
            ConsultasAgendadasToolStripMenuItem.Enabled = False


            lblConsultasFin.Visible = True
            dg5.Visible = True

            lblProxConAtend.Visible = True
            dg4.Visible = True

            ListarProxConsAtend()
            ListarConsFim()

        End If


    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem.Click
        Dim form = New frmRelConsultaData
        form.ShowDialog()
    End Sub

    Sub TotaisAdm()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from consultas where status = 'Marcado' and data = curDate() "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lblTotMarcadas.Text = dt.Rows.Count
            dt.Clear()

            sql = "select * from consultas where status = 'Consultando' and data = curDate() "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lblTotAndamento.Text = dt.Rows.Count
            dt.Clear()

            sql = "select * from consultas where status = 'Cancelado' and data = curDate() "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lblTotCanceladas.Text = dt.Rows.Count
            dt.Clear()

            sql = "select * from consultas where status = 'Finalizado' and data = curDate() "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lbltotFim.Text = dt.Rows.Count
            dt.Clear()



        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub

    Private Sub lblUsuario_Click(sender As Object, e As EventArgs) Handles lblUsuario.Click
        Dim form = New frmAlterarSenha
        form.ShowDialog()
    End Sub

    Private Sub SToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SToolStripMenuItem1.Click
        Dim form = New frmRelConsultaData
        form.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub
End Class