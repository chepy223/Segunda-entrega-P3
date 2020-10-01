<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formlistacliente
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
        Me.Database = New System.Windows.Forms.DataGridView()
        CType(Me.Database, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Buttonatras
        '
        Me.Buttonatras.Image = Global.proyectoEZ_1.My.Resources.Resources._1231
        Me.Buttonatras.Location = New System.Drawing.Point(12, 12)
        Me.Buttonatras.Name = "Buttonatras"
        Me.Buttonatras.Size = New System.Drawing.Size(94, 64)
        Me.Buttonatras.TabIndex = 0
        Me.Buttonatras.UseVisualStyleBackColor = True
        '
        'Database
        '
        Me.Database.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Database.Location = New System.Drawing.Point(112, 12)
        Me.Database.Name = "Database"
        Me.Database.Size = New System.Drawing.Size(529, 338)
        Me.Database.TabIndex = 1
        '
        'Formlistacliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 362)
        Me.Controls.Add(Me.Database)
        Me.Controls.Add(Me.Buttonatras)
        Me.Name = "Formlistacliente"
        Me.Text = "lista de clientes"
        CType(Me.Database, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Buttonatras As Button
    Friend WithEvents Database As DataGridView
End Class
