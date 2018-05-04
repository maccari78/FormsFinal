Public Class FPrincipal

    Public Marca, Procesador, RAM, Disco As String

#Region "Declaración de estructuras"
    Structure TipoDatos
        Dim Marca As String
        Dim Procesador As String
        Dim RAM As String
        Dim Disco As String
    End Structure
#End Region

#Region "Declaración de variables"
    Const Tope As Integer = 15
    Dim Dispositivos(Tope) As TipoDatos
    Dim Ultimo As Integer = -1
#End Region

    Private Sub FPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LCantidad.Text = "Cantidad de dispositivos: " + Convert.ToString(LBLista.Items.Count)
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        Dim FAgregar As FSecundario = New FSecundario
        FAgregar.NombreSec = True 'Cuando es verdadero el título del formulario secundario es "Agregar"
        FAgregar.ShowDialog()
        Dim i As Integer
        Dim Contador As TipoDatos
        If FAgregar.DialogResult = DialogResult.OK Then
            i = 0
            While ((FAgregar.Marca <> Dispositivos(i).Marca) Or (FAgregar.Procesador <> Dispositivos(i).Procesador) Or (FAgregar.RAM <> Dispositivos(i).RAM) Or (FAgregar.Disco <> Dispositivos(i).Disco)) And (i <= Ultimo)
                i = i + 1 'Recorro el arreglo buscando uno igual al que quiero agregar
            End While
            If i <= Ultimo Then 'Si coinciden los 4, el dispositivo ya está ingresado
                MsgBox("El dispositivo ya se ha ingresado", MsgBoxStyle.Exclamation, "ERROR")
            Else
                Contador.Marca = FAgregar.Marca
                Contador.Procesador = FAgregar.Procesador
                Contador.RAM = FAgregar.RAM
                Contador.Disco = FAgregar.Disco
                Ultimo = Ultimo + 1
                Dispositivos(Ultimo) = Contador
                LBLista.Items.Add(FAgregar.Marca + " - " + FAgregar.Procesador + " - " + FAgregar.RAM + " GB RAM - " + FAgregar.Disco)
            End If
        Else
            MsgBox("Cancelo la operación", MsgBoxStyle.OkOnly, "Cancelar")
        End If
        LCantidad.Text = "Cantidad de dispositivos: " + Convert.ToString(LBLista.Items.Count)
    End Sub

    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click
        Dim FModif As FSecundario = New FSecundario
        Dim Lugar As Integer
        If LBLista.SelectedIndex = -1 Then
            MsgBox("Seleccione un disposito a modificar", MsgBoxStyle.Critical, "ERROR")
            LBLista.Focus()
        Else
            FModif.NombreSec = False 'Cuando es falso, cambia el título del formulario secundario a "Modificar"
            Lugar = LBLista.SelectedIndex
            FModif.RAM = Dispositivos(Lugar).RAM
            FModif.Disco = Dispositivos(Lugar).Disco
            FModif.Procesador = Dispositivos(Lugar).Procesador
            FModif.Marca = Dispositivos(Lugar).Marca
            FModif.ShowDialog()
            If FModif.DialogResult = Windows.Forms.DialogResult.OK Then
                LBLista.Items.Remove(LBLista.SelectedItem)
                Dispositivos(Lugar).RAM = FModif.RAM
                Dispositivos(Lugar).Disco = FModif.Disco
                Dispositivos(Lugar).Procesador = FModif.Procesador
                Dispositivos(Lugar).Marca = FModif.Marca
                LBLista.Items.Insert(Lugar, FModif.Marca + " - " + FModif.Procesador + " - " + FModif.RAM + " GB RAM - " + FModif.Disco)
            Else
                DialogResult = Windows.Forms.DialogResult.Cancel
            End If
        End If
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim Lugar As Integer = LBLista.SelectedIndex
        If Lugar < 0 Then
            MsgBox("Seleccione un dispositivo de la lista", MsgBoxStyle.Critical, "Dispositivos")
        Else
            LBLista.Items.RemoveAt(Lugar) 'Elimina el lugar seleccionado
            For j As Integer = Lugar To Ultimo
                Dispositivos(j) = Dispositivos(j + 1)
            Next j
            Ultimo -= 1
        End If
        LCantidad.Text = "Cantidad de dispositivos: " + Convert.ToString(LBLista.Items.Count)
    End Sub

    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Close()
    End Sub

    Private Sub RBTodos_CheckedChanged(sender As Object, e As EventArgs) Handles RBTodos.CheckedChanged
        Dim i As Integer
        If RBTodos.Checked Then 'Muestra todos los elementos del ListBox
            LBLista.Items.Clear()
            For i = 0 To Ultimo
                LBLista.Items.Add(Dispositivos(i).Marca + " - " + Dispositivos(i).Procesador + " - " + Dispositivos(i).RAM + " GB RAM - " + Dispositivos(i).Disco)
            Next
            LCantidad.Text = "Cantidad de dispositivos: " + Convert.ToString(LBLista.Items.Count)
        End If
    End Sub

    Private Sub RBINtel_CheckedChanged(sender As Object, e As EventArgs) Handles RBIntel.CheckedChanged
        If RBIntel.Checked Then 'Muestra los elementos "x86-64 Intel" del ListBox
            LBLista.Items.Clear()
            For i = 0 To Ultimo
                If Dispositivos(i).Procesador = "x86-64 Intel" Then
                    LBLista.Items.Add(Dispositivos(i).Marca + " - " + Dispositivos(i).Procesador + " - " + Dispositivos(i).RAM + " GB RAM - " + Dispositivos(i).Disco)
                End If
            Next
            LCantidad.Text = "Cantidad de dispositivos: " + Convert.ToString(LBLista.Items.Count)
        End If
    End Sub

    Private Sub RBAMD_CheckedChanged(sender As Object, e As EventArgs) Handles RBAMD.CheckedChanged
        If RBAMD.Checked Then 'Muestra los elementos "x86-64 AMD" del ListBox
            LBLista.Items.Clear()
            For i = 0 To Ultimo
                If Dispositivos(i).Procesador = "x86-64 AMD" Then
                    LBLista.Items.Add(Dispositivos(i).Marca + " - " + Dispositivos(i).Procesador + " - " + Dispositivos(i).RAM + " GB RAM - " + Dispositivos(i).Disco)
                End If
            Next
            LCantidad.Text = "Cantidad de dispositivos: " + Convert.ToString(LBLista.Items.Count)
        End If
    End Sub

    Private Sub RBARM_CheckedChanged(sender As Object, e As EventArgs) Handles RBARM.CheckedChanged
        If RBARM.Checked Then 'Muestra los elementos "ARM" del ListBox
            LBLista.Items.Clear()
            For i = 0 To Ultimo
                If Dispositivos(i).Procesador = "ARM" Then
                    LBLista.Items.Add(Dispositivos(i).Marca + " - " + Dispositivos(i).Procesador + " - " + Dispositivos(i).RAM + " GB RAM - " + Dispositivos(i).Disco)
                End If
            Next
            LCantidad.Text = "Cantidad de dispositivos: " + Convert.ToString(LBLista.Items.Count)
        End If
    End Sub
End Class
