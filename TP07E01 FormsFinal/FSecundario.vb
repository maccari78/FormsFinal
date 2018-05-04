Public Class FSecundario

    Public Marca, Procesador, RAM, Disco As String
    Public NombreSec As Boolean

    Private Sub FSecundario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBMarca.Text = Marca
        CBProcesador.Text = Procesador
        CBRAM.Text = RAM
        CBDisco.Text = Disco

        If NombreSec Then
            Me.Text = "Agregar"
            BAceptar.Text = "Agregar"
        Else
            Me.Text = "Modificar"
            BAceptar.Text = "Aceptar"
        End If

        If (Disco = "") Then 'Cuando agrego me muestra el lugar 0 del arreglo: "HDD 500 GB"
            CBDisco.SelectedIndex = 0
        Else 'Cuando modifico me muestra el disco de la estructura a modificar
            CBDisco.SelectedItem = Disco
        End If
    End Sub

    Private Sub BCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click
        If CBMarca.Text = "" Then 'Marca y RAM me deja agregar una no listada
            MsgBox("Debe ingresar un dispositivo", MsgBoxStyle.Critical, "ERROR")
            CBMarca.Focus()
        ElseIf CBProcesador.SelectedIndex = -1 Then 'Procesador y disco debo elegir alguno de los listados
            MsgBox("Debe ingresar un procesador", MsgBoxStyle.Critical, "ERROR")
            CBProcesador.Focus()
        ElseIf CBRAM.Text = "" Then
            MsgBox("Debe ingresar una RAM", MsgBoxStyle.Critical, "ERROR")
            CBRAM.Focus()
        ElseIf CBDisco.SelectedIndex = -1 Then
            MsgBox("Debe ingresar un Disco", MsgBoxStyle.Critical, "ERROR")
            CBDisco.Focus()
        ElseIf CBMarca.Text = "Apple" And CBProcesador.Text = "x86-64 AMD" Then
            MsgBox("No existen dispositivos Apple con procesador AMD", MsgBoxStyle.Exclamation, "ERROR")
            CBMarca.Focus()
        Else 'Si no hay ERROR envía los datos para ser agregados a la estructura
            Marca = CBMarca.Text
            Procesador = CBProcesador.Text
            RAM = CBRAM.Text
            Disco = CBDisco.SelectedItem
            DialogResult = DialogResult.OK
        End If
    End Sub
End Class