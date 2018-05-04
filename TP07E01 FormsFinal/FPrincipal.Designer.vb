<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPrincipal
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
        Me.GPDiscos = New System.Windows.Forms.GroupBox()
        Me.RBARM = New System.Windows.Forms.RadioButton()
        Me.RBTodos = New System.Windows.Forms.RadioButton()
        Me.RBAMD = New System.Windows.Forms.RadioButton()
        Me.RBIntel = New System.Windows.Forms.RadioButton()
        Me.LCantidad = New System.Windows.Forms.Label()
        Me.BCerrar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.LBLista = New System.Windows.Forms.ListBox()
        Me.GPDiscos.SuspendLayout()
        Me.SuspendLayout()
        '
        'GPDiscos
        '
        Me.GPDiscos.Controls.Add(Me.RBARM)
        Me.GPDiscos.Controls.Add(Me.RBTodos)
        Me.GPDiscos.Controls.Add(Me.RBAMD)
        Me.GPDiscos.Controls.Add(Me.RBIntel)
        Me.GPDiscos.Location = New System.Drawing.Point(12, 165)
        Me.GPDiscos.Name = "GPDiscos"
        Me.GPDiscos.Size = New System.Drawing.Size(296, 51)
        Me.GPDiscos.TabIndex = 30
        Me.GPDiscos.TabStop = False
        Me.GPDiscos.Text = "Procesadores"
        '
        'RBARM
        '
        Me.RBARM.AutoSize = True
        Me.RBARM.Location = New System.Drawing.Point(243, 19)
        Me.RBARM.Name = "RBARM"
        Me.RBARM.Size = New System.Drawing.Size(49, 17)
        Me.RBARM.TabIndex = 33
        Me.RBARM.TabStop = True
        Me.RBARM.Text = "ARM"
        Me.RBARM.UseVisualStyleBackColor = True
        '
        'RBTodos
        '
        Me.RBTodos.AutoSize = True
        Me.RBTodos.Location = New System.Drawing.Point(6, 19)
        Me.RBTodos.Name = "RBTodos"
        Me.RBTodos.Size = New System.Drawing.Size(55, 17)
        Me.RBTodos.TabIndex = 0
        Me.RBTodos.Text = "Todos"
        Me.RBTodos.UseVisualStyleBackColor = True
        '
        'RBAMD
        '
        Me.RBAMD.AutoSize = True
        Me.RBAMD.Location = New System.Drawing.Point(153, 19)
        Me.RBAMD.Name = "RBAMD"
        Me.RBAMD.Size = New System.Drawing.Size(84, 17)
        Me.RBAMD.TabIndex = 32
        Me.RBAMD.TabStop = True
        Me.RBAMD.Text = "x86-64 AMD"
        Me.RBAMD.UseVisualStyleBackColor = True
        '
        'RBIntel
        '
        Me.RBIntel.AutoSize = True
        Me.RBIntel.Location = New System.Drawing.Point(67, 19)
        Me.RBIntel.Name = "RBIntel"
        Me.RBIntel.Size = New System.Drawing.Size(80, 17)
        Me.RBIntel.TabIndex = 31
        Me.RBIntel.TabStop = True
        Me.RBIntel.Text = "x86-64 Intel"
        Me.RBIntel.UseVisualStyleBackColor = True
        '
        'LCantidad
        '
        Me.LCantidad.AutoSize = True
        Me.LCantidad.Location = New System.Drawing.Point(9, 224)
        Me.LCantidad.Name = "LCantidad"
        Me.LCantidad.Size = New System.Drawing.Size(127, 13)
        Me.LCantidad.TabIndex = 29
        Me.LCantidad.Text = "Cantidad de dispositivos: "
        '
        'BCerrar
        '
        Me.BCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BCerrar.Location = New System.Drawing.Point(314, 219)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BCerrar.TabIndex = 28
        Me.BCerrar.Text = "&Cerrar"
        Me.BCerrar.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.Location = New System.Drawing.Point(314, 70)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BEliminar.TabIndex = 27
        Me.BEliminar.Text = "&Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'BModificar
        '
        Me.BModificar.Location = New System.Drawing.Point(314, 41)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(75, 23)
        Me.BModificar.TabIndex = 26
        Me.BModificar.Text = "&Modificar"
        Me.BModificar.UseVisualStyleBackColor = True
        '
        'BAgregar
        '
        Me.BAgregar.Location = New System.Drawing.Point(314, 12)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BAgregar.TabIndex = 25
        Me.BAgregar.Text = "&Agregar"
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'LBLista
        '
        Me.LBLista.FormattingEnabled = True
        Me.LBLista.Location = New System.Drawing.Point(12, 12)
        Me.LBLista.Name = "LBLista"
        Me.LBLista.Size = New System.Drawing.Size(296, 147)
        Me.LBLista.TabIndex = 24
        '
        'FPrincipal
        '
        Me.AcceptButton = Me.BAgregar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BCerrar
        Me.ClientSize = New System.Drawing.Size(400, 252)
        Me.Controls.Add(Me.GPDiscos)
        Me.Controls.Add(Me.LCantidad)
        Me.Controls.Add(Me.BCerrar)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BModificar)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.LBLista)
        Me.Name = "FPrincipal"
        Me.Text = "Configurar dispositivo"
        Me.GPDiscos.ResumeLayout(False)
        Me.GPDiscos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GPDiscos As GroupBox
    Friend WithEvents RBTodos As RadioButton
    Friend WithEvents LCantidad As Label
    Friend WithEvents BCerrar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents BModificar As Button
    Friend WithEvents BAgregar As Button
    Friend WithEvents LBLista As ListBox
    Friend WithEvents RBIntel As RadioButton
    Friend WithEvents RBAMD As RadioButton
    Friend WithEvents RBARM As RadioButton
End Class
