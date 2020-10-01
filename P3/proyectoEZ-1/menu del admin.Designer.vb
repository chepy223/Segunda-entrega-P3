<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formmenuadmin
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
        Me.Buttonatras = New System.Windows.Forms.Button()
        Me.Buttonlistacliente = New System.Windows.Forms.Button()
        Me.Buttonalmacen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Buttonatras
        '
        Me.Buttonatras.Image = Global.proyectoEZ_1.My.Resources.Resources._1231
        Me.Buttonatras.Location = New System.Drawing.Point(12, 12)
        Me.Buttonatras.Name = "Buttonatras"
        Me.Buttonatras.Size = New System.Drawing.Size(78, 65)
        Me.Buttonatras.TabIndex = 0
        Me.Buttonatras.UseVisualStyleBackColor = True
        '
        'Buttonlistacliente
        '
        Me.Buttonlistacliente.Location = New System.Drawing.Point(70, 254)
        Me.Buttonlistacliente.Name = "Buttonlistacliente"
        Me.Buttonlistacliente.Size = New System.Drawing.Size(130, 44)
        Me.Buttonlistacliente.TabIndex = 1
        Me.Buttonlistacliente.Text = "ingresar"
        Me.Buttonlistacliente.UseVisualStyleBackColor = True
        '
        'Buttonalmacen
        '
        Me.Buttonalmacen.Location = New System.Drawing.Point(320, 254)
        Me.Buttonalmacen.Name = "Buttonalmacen"
        Me.Buttonalmacen.Size = New System.Drawing.Size(131, 44)
        Me.Buttonalmacen.TabIndex = 2
        Me.Buttonalmacen.Text = "ingresar"
        Me.Buttonalmacen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(363, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "almacén"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "lista de clientes"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(96, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 169)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Formmenuadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 348)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Buttonalmacen)
        Me.Controls.Add(Me.Buttonlistacliente)
        Me.Controls.Add(Me.Buttonatras)
        Me.Name = "Formmenuadmin"
        Me.Text = "menu del admin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Buttonatras As Button
    Friend WithEvents Buttonlistacliente As Button
    Friend WithEvents Buttonalmacen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
