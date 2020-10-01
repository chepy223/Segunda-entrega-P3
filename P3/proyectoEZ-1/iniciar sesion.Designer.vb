<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Forminiciosesion
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
        Me.Buttonatras = New System.Windows.Forms.Button()
        Me.Buttoningresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Buttonatras
        '
        Me.Buttonatras.Image = Global.proyectoEZ_1.My.Resources.Resources._1231
        Me.Buttonatras.Location = New System.Drawing.Point(12, 12)
        Me.Buttonatras.Name = "Buttonatras"
        Me.Buttonatras.Size = New System.Drawing.Size(86, 67)
        Me.Buttonatras.TabIndex = 0
        Me.Buttonatras.UseVisualStyleBackColor = True
        '
        'Buttoningresar
        '
        Me.Buttoningresar.Location = New System.Drawing.Point(107, 294)
        Me.Buttoningresar.Name = "Buttoningresar"
        Me.Buttoningresar.Size = New System.Drawing.Size(148, 51)
        Me.Buttoningresar.TabIndex = 1
        Me.Buttoningresar.Text = "ingresar"
        Me.Buttoningresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(148, 187)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(148, 20)
        Me.txtemail.TabIndex = 4
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(148, 236)
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.Size = New System.Drawing.Size(148, 20)
        Me.txtcontraseña.TabIndex = 5
        '
        'Forminiciosesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 357)
        Me.Controls.Add(Me.txtcontraseña)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Buttoningresar)
        Me.Controls.Add(Me.Buttonatras)
        Me.Name = "Forminiciosesion"
        Me.Text = "iniciar sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Buttonatras As Button
    Friend WithEvents Buttoningresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtcontraseña As TextBox
End Class
