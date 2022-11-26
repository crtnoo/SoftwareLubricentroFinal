<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.labelusuario = New System.Windows.Forms.Label()
        Me.labelContraseña = New System.Windows.Forms.Label()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.txt_Contraseña = New System.Windows.Forms.TextBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB Demi", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(176, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 43)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Lubricentro Fabian"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-36, -57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 182)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'labelusuario
        '
        Me.labelusuario.AutoSize = True
        Me.labelusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelusuario.ForeColor = System.Drawing.SystemColors.Control
        Me.labelusuario.Location = New System.Drawing.Point(207, 158)
        Me.labelusuario.Name = "labelusuario"
        Me.labelusuario.Size = New System.Drawing.Size(71, 20)
        Me.labelusuario.TabIndex = 9
        Me.labelusuario.Text = "Usuario"
        '
        'labelContraseña
        '
        Me.labelContraseña.AutoSize = True
        Me.labelContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelContraseña.ForeColor = System.Drawing.SystemColors.Control
        Me.labelContraseña.Location = New System.Drawing.Point(207, 231)
        Me.labelContraseña.Name = "labelContraseña"
        Me.labelContraseña.Size = New System.Drawing.Size(102, 20)
        Me.labelContraseña.TabIndex = 10
        Me.labelContraseña.Text = "Contraseña"
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Location = New System.Drawing.Point(211, 196)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(100, 20)
        Me.txt_Usuario.TabIndex = 11
        '
        'txt_Contraseña
        '
        Me.txt_Contraseña.Location = New System.Drawing.Point(211, 265)
        Me.txt_Contraseña.Name = "txt_Contraseña"
        Me.txt_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Contraseña.Size = New System.Drawing.Size(100, 20)
        Me.txt_Contraseña.TabIndex = 12
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(547, 326)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 13
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(634, 361)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_Contraseña)
        Me.Controls.Add(Me.txt_Usuario)
        Me.Controls.Add(Me.labelContraseña)
        Me.Controls.Add(Me.labelusuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents labelusuario As Label
    Friend WithEvents labelContraseña As Label
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents txt_Contraseña As TextBox
    Friend WithEvents btn_aceptar As Button
End Class
