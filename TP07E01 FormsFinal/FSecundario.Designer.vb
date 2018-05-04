<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSecundario
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
        Me.LProcesador = New System.Windows.Forms.Label()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.LDisco = New System.Windows.Forms.Label()
        Me.LRAM = New System.Windows.Forms.Label()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.CBDisco = New System.Windows.Forms.ComboBox()
        Me.CBRAM = New System.Windows.Forms.ComboBox()
        Me.CBProcesador = New System.Windows.Forms.ComboBox()
        Me.CBMarca = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LProcesador
        '
        Me.LProcesador.AutoSize = True
        Me.LProcesador.Location = New System.Drawing.Point(9, 37)
        Me.LProcesador.Name = "LProcesador"
        Me.LProcesador.Size = New System.Drawing.Size(67, 13)
        Me.LProcesador.TabIndex = 34
        Me.LProcesador.Text = "Procesador: "
        '
        'BCancelar
        '
        Me.BCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BCancelar.Location = New System.Drawing.Point(108, 119)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BCancelar.TabIndex = 38
        Me.BCancelar.Text = "&Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'BAceptar
        '
        Me.BAceptar.Location = New System.Drawing.Point(26, 119)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BAceptar.TabIndex = 37
        Me.BAceptar.Text = "&Agregar"
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'LDisco
        '
        Me.LDisco.AutoSize = True
        Me.LDisco.Location = New System.Drawing.Point(36, 95)
        Me.LDisco.Name = "LDisco"
        Me.LDisco.Size = New System.Drawing.Size(40, 13)
        Me.LDisco.TabIndex = 31
        Me.LDisco.Text = "Disco: "
        '
        'LRAM
        '
        Me.LRAM.AutoSize = True
        Me.LRAM.Location = New System.Drawing.Point(41, 66)
        Me.LRAM.Name = "LRAM"
        Me.LRAM.Size = New System.Drawing.Size(37, 13)
        Me.LRAM.TabIndex = 30
        Me.LRAM.Text = "RAM: "
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Location = New System.Drawing.Point(33, 9)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(43, 13)
        Me.LMarca.TabIndex = 29
        Me.LMarca.Text = "Marca: "
        '
        'CBDisco
        '
        Me.CBDisco.DisplayMember = "0"
        Me.CBDisco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBDisco.FormattingEnabled = True
        Me.CBDisco.Items.AddRange(New Object() {"HDD 500 GB", "HDD 1 TB", "SSD 16 GB", "SSD 32 GB", "SSD 64 GB", "SSD 120 GB", "SSD 240 GB", "SSD 480 GB"})
        Me.CBDisco.Location = New System.Drawing.Point(82, 92)
        Me.CBDisco.Name = "CBDisco"
        Me.CBDisco.Size = New System.Drawing.Size(121, 21)
        Me.CBDisco.TabIndex = 36
        '
        'CBRAM
        '
        Me.CBRAM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBRAM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBRAM.FormattingEnabled = True
        Me.CBRAM.ItemHeight = 13
        Me.CBRAM.Items.AddRange(New Object() {"1", "2", "4", "8", "16"})
        Me.CBRAM.Location = New System.Drawing.Point(82, 63)
        Me.CBRAM.Name = "CBRAM"
        Me.CBRAM.Size = New System.Drawing.Size(121, 21)
        Me.CBRAM.TabIndex = 35
        '
        'CBProcesador
        '
        Me.CBProcesador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBProcesador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBProcesador.FormattingEnabled = True
        Me.CBProcesador.Items.AddRange(New Object() {"x86-64 Intel", "x86-64 AMD", "ARM"})
        Me.CBProcesador.Location = New System.Drawing.Point(82, 34)
        Me.CBProcesador.Name = "CBProcesador"
        Me.CBProcesador.Size = New System.Drawing.Size(121, 21)
        Me.CBProcesador.TabIndex = 34
        '
        'CBMarca
        '
        Me.CBMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBMarca.FormattingEnabled = True
        Me.CBMarca.Items.AddRange(New Object() {"Apple", "Dell", "Huawei", "Lenovo", "LG", "SAMSUNG", "TOSHIBA"})
        Me.CBMarca.Location = New System.Drawing.Point(82, 6)
        Me.CBMarca.Name = "CBMarca"
        Me.CBMarca.Size = New System.Drawing.Size(121, 21)
        Me.CBMarca.Sorted = True
        Me.CBMarca.TabIndex = 33
        '
        'FSecundario
        '
        Me.AcceptButton = Me.BAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BCancelar
        Me.ClientSize = New System.Drawing.Size(213, 151)
        Me.Controls.Add(Me.CBMarca)
        Me.Controls.Add(Me.CBProcesador)
        Me.Controls.Add(Me.LProcesador)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.LDisco)
        Me.Controls.Add(Me.LRAM)
        Me.Controls.Add(Me.LMarca)
        Me.Controls.Add(Me.CBDisco)
        Me.Controls.Add(Me.CBRAM)
        Me.Name = "FSecundario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FSecundario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LProcesador As Label
    Friend WithEvents BCancelar As Button
    Friend WithEvents BAceptar As Button
    Friend WithEvents LDisco As Label
    Friend WithEvents LRAM As Label
    Friend WithEvents LMarca As Label
    Private WithEvents CBDisco As ComboBox
    Private WithEvents CBRAM As ComboBox
    Private WithEvents CBProcesador As ComboBox
    Private WithEvents CBMarca As ComboBox
End Class
