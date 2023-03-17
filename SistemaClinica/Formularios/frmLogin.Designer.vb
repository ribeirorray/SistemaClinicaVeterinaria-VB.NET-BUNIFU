<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties9 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties10 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusuario = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.txtsenha = New Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox()
        Me.btnentrar = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemaClinica.My.Resources.Resources.undraw_medicine_b1ol
        Me.PictureBox1.Location = New System.Drawing.Point(-44, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(492, 428)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(446, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 48)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bem- Vindo(a)!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(450, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Efetue seu login para entrar no sistema."
        '
        'txtusuario
        '
        Me.txtusuario.AcceptsReturn = False
        Me.txtusuario.AcceptsTab = False
        Me.txtusuario.AnimationSpeed = 200
        Me.txtusuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtusuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtusuario.BackColor = System.Drawing.Color.White
        Me.txtusuario.BackgroundImage = CType(resources.GetObject("txtusuario.BackgroundImage"), System.Drawing.Image)
        Me.txtusuario.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.txtusuario.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.txtusuario.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtusuario.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtusuario.BorderRadius = 1
        Me.txtusuario.BorderThickness = 1
        Me.txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtusuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusuario.DefaultFont = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusuario.DefaultText = ""
        Me.txtusuario.FillColor = System.Drawing.Color.White
        Me.txtusuario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtusuario.HideSelection = True
        Me.txtusuario.IconLeft = Nothing
        Me.txtusuario.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusuario.IconPadding = 10
        Me.txtusuario.IconRight = Nothing
        Me.txtusuario.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusuario.Lines = New String(-1) {}
        Me.txtusuario.Location = New System.Drawing.Point(454, 152)
        Me.txtusuario.MaxLength = 32767
        Me.txtusuario.MinimumSize = New System.Drawing.Size(100, 35)
        Me.txtusuario.Modified = False
        Me.txtusuario.Multiline = False
        Me.txtusuario.Name = "txtusuario"
        StateProperties1.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties1.FillColor = System.Drawing.Color.Empty
        StateProperties1.ForeColor = System.Drawing.Color.Empty
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtusuario.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.Empty
        StateProperties2.FillColor = System.Drawing.Color.White
        StateProperties2.ForeColor = System.Drawing.Color.Empty
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtusuario.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtusuario.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.White
        StateProperties4.ForeColor = System.Drawing.SystemColors.ControlText
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtusuario.OnIdleState = StateProperties4
        Me.txtusuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusuario.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtusuario.PlaceholderText = "Usuário"
        Me.txtusuario.ReadOnly = False
        Me.txtusuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtusuario.SelectedText = ""
        Me.txtusuario.SelectionLength = 0
        Me.txtusuario.SelectionStart = 0
        Me.txtusuario.ShortcutsEnabled = True
        Me.txtusuario.Size = New System.Drawing.Size(200, 35)
        Me.txtusuario.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material
        Me.txtusuario.TabIndex = 4
        Me.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtusuario.TextMarginBottom = 0
        Me.txtusuario.TextMarginLeft = 5
        Me.txtusuario.TextMarginTop = 0
        Me.txtusuario.TextPlaceholder = "Usuário"
        Me.txtusuario.UseSystemPasswordChar = False
        Me.txtusuario.WordWrap = True
        '
        'txtsenha
        '
        Me.txtsenha.AcceptsReturn = False
        Me.txtsenha.AcceptsTab = False
        Me.txtsenha.AnimationSpeed = 200
        Me.txtsenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtsenha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtsenha.BackColor = System.Drawing.Color.White
        Me.txtsenha.BackgroundImage = CType(resources.GetObject("txtsenha.BackgroundImage"), System.Drawing.Image)
        Me.txtsenha.BorderColorActive = System.Drawing.Color.DodgerBlue
        Me.txtsenha.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.txtsenha.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsenha.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtsenha.BorderRadius = 1
        Me.txtsenha.BorderThickness = 1
        Me.txtsenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtsenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsenha.DefaultFont = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.txtsenha.DefaultText = ""
        Me.txtsenha.FillColor = System.Drawing.Color.White
        Me.txtsenha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtsenha.HideSelection = True
        Me.txtsenha.IconLeft = Nothing
        Me.txtsenha.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsenha.IconPadding = 10
        Me.txtsenha.IconRight = Nothing
        Me.txtsenha.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsenha.Lines = New String(-1) {}
        Me.txtsenha.Location = New System.Drawing.Point(454, 212)
        Me.txtsenha.MaxLength = 32767
        Me.txtsenha.MinimumSize = New System.Drawing.Size(100, 35)
        Me.txtsenha.Modified = False
        Me.txtsenha.Multiline = False
        Me.txtsenha.Name = "txtsenha"
        StateProperties5.BorderColor = System.Drawing.Color.DodgerBlue
        StateProperties5.FillColor = System.Drawing.Color.Empty
        StateProperties5.ForeColor = System.Drawing.Color.Empty
        StateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtsenha.OnActiveState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.Empty
        StateProperties6.FillColor = System.Drawing.Color.White
        StateProperties6.ForeColor = System.Drawing.Color.Empty
        StateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtsenha.OnDisabledState = StateProperties6
        StateProperties7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties7.FillColor = System.Drawing.Color.Empty
        StateProperties7.ForeColor = System.Drawing.Color.Empty
        StateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtsenha.OnHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.Silver
        StateProperties8.FillColor = System.Drawing.Color.White
        StateProperties8.ForeColor = System.Drawing.SystemColors.ControlText
        StateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtsenha.OnIdleState = StateProperties8
        Me.txtsenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtsenha.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtsenha.PlaceholderText = "Usuario"
        Me.txtsenha.ReadOnly = False
        Me.txtsenha.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtsenha.SelectedText = ""
        Me.txtsenha.SelectionLength = 0
        Me.txtsenha.SelectionStart = 0
        Me.txtsenha.ShortcutsEnabled = True
        Me.txtsenha.Size = New System.Drawing.Size(200, 35)
        Me.txtsenha.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material
        Me.txtsenha.TabIndex = 5
        Me.txtsenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtsenha.TextMarginBottom = 0
        Me.txtsenha.TextMarginLeft = 5
        Me.txtsenha.TextMarginTop = 0
        Me.txtsenha.TextPlaceholder = "Usuario"
        Me.txtsenha.UseSystemPasswordChar = True
        Me.txtsenha.WordWrap = True
        '
        'btnentrar
        '
        Me.btnentrar.AllowToggling = False
        Me.btnentrar.AnimationSpeed = 200
        Me.btnentrar.AutoGenerateColors = False
        Me.btnentrar.BackColor = System.Drawing.Color.Transparent
        Me.btnentrar.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnentrar.BackgroundImage = CType(resources.GetObject("btnentrar.BackgroundImage"), System.Drawing.Image)
        Me.btnentrar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnentrar.ButtonText = "Entrar"
        Me.btnentrar.ButtonTextMarginLeft = 0
        Me.btnentrar.ColorContrastOnClick = 45
        Me.btnentrar.ColorContrastOnHover = 45
        Me.btnentrar.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btnentrar.CustomizableEdges = BorderEdges1
        Me.btnentrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnentrar.DisabledBorderColor = System.Drawing.Color.Empty
        Me.btnentrar.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnentrar.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnentrar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnentrar.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnentrar.ForeColor = System.Drawing.Color.White
        Me.btnentrar.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnentrar.IconMarginLeft = 11
        Me.btnentrar.IconPadding = 10
        Me.btnentrar.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnentrar.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnentrar.IdleBorderRadius = 3
        Me.btnentrar.IdleBorderThickness = 1
        Me.btnentrar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnentrar.IdleIconLeftImage = Nothing
        Me.btnentrar.IdleIconRightImage = Nothing
        Me.btnentrar.IndicateFocus = False
        Me.btnentrar.Location = New System.Drawing.Point(454, 280)
        Me.btnentrar.Name = "btnentrar"
        StateProperties9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties9.BorderRadius = 3
        StateProperties9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties9.BorderThickness = 1
        StateProperties9.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties9.ForeColor = System.Drawing.Color.White
        StateProperties9.IconLeftImage = Nothing
        StateProperties9.IconRightImage = Nothing
        Me.btnentrar.onHoverState = StateProperties9
        StateProperties10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties10.BorderRadius = 3
        StateProperties10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties10.BorderThickness = 1
        StateProperties10.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties10.ForeColor = System.Drawing.Color.White
        StateProperties10.IconLeftImage = Nothing
        StateProperties10.IconRightImage = Nothing
        Me.btnentrar.OnPressedState = StateProperties10
        Me.btnentrar.Size = New System.Drawing.Size(210, 45)
        Me.btnentrar.TabIndex = 6
        Me.btnentrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnentrar.TextMarginLeft = 0
        Me.btnentrar.UseDefaultRadiusAndThickness = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(718, 0)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(32, 24)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 7
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(748, 489)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.btnentrar)
        Me.Controls.Add(Me.txtsenha)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(748, 489)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(748, 489)
        Me.Name = "frmLogin"
        Me.Text = "frmLogin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusuario As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents txtsenha As Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox
    Friend WithEvents btnentrar As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
End Class
