<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_mercaderia = New System.Windows.Forms.Button()
        Me.btn_facturas = New System.Windows.Forms.Button()
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.btn_pedidos = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-55, -81)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 224)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(228, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 54)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Lubricentro Fabian"
        '
        'btn_mercaderia
        '
        Me.btn_mercaderia.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_mercaderia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mercaderia.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_mercaderia.Location = New System.Drawing.Point(207, 302)
        Me.btn_mercaderia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_mercaderia.Name = "btn_mercaderia"
        Me.btn_mercaderia.Size = New System.Drawing.Size(164, 42)
        Me.btn_mercaderia.TabIndex = 17
        Me.btn_mercaderia.Text = "Mercaderia"
        Me.btn_mercaderia.UseVisualStyleBackColor = False
        '
        'btn_facturas
        '
        Me.btn_facturas.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_facturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_facturas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_facturas.Location = New System.Drawing.Point(464, 207)
        Me.btn_facturas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_facturas.Name = "btn_facturas"
        Me.btn_facturas.Size = New System.Drawing.Size(164, 42)
        Me.btn_facturas.TabIndex = 16
        Me.btn_facturas.Text = "Facturas"
        Me.btn_facturas.UseVisualStyleBackColor = False
        '
        'btn_clientes
        '
        Me.btn_clientes.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clientes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_clientes.Location = New System.Drawing.Point(207, 207)
        Me.btn_clientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(164, 42)
        Me.btn_clientes.TabIndex = 15
        Me.btn_clientes.Text = "Clientes"
        Me.btn_clientes.UseVisualStyleBackColor = False
        '
        'btn_pedidos
        '
        Me.btn_pedidos.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_pedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pedidos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_pedidos.Location = New System.Drawing.Point(464, 302)
        Me.btn_pedidos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_pedidos.Name = "btn_pedidos"
        Me.btn_pedidos.Size = New System.Drawing.Size(164, 42)
        Me.btn_pedidos.TabIndex = 18
        Me.btn_pedidos.Text = "Pedidos"
        Me.btn_pedidos.UseVisualStyleBackColor = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Location = New System.Drawing.Point(729, 401)
        Me.btn_cerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(100, 28)
        Me.btn_cerrar.TabIndex = 19
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(845, 444)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_pedidos)
        Me.Controls.Add(Me.btn_mercaderia)
        Me.Controls.Add(Me.btn_facturas)
        Me.Controls.Add(Me.btn_clientes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Main"
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_mercaderia As Button
    Friend WithEvents btn_facturas As Button
    Friend WithEvents btn_clientes As Button
    Friend WithEvents btn_pedidos As Button
    Friend WithEvents btn_cerrar As Button
End Class
