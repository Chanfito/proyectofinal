Public Class frmLogin

#Region "Botones"

    ' Boton para ingresar al formulario principal
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ' Crear el form del menu principal como una variable para hacer distintas acciones con el
        Dim form As New frmMenuPrincipal

        Hide()
        form.Show()

        ' me cago en la puta
    End Sub

    ' Boton para limpiar los campos del formulario
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

    End Sub

    ' Boton para salir del sistema
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

#End Region

#Region "Funciones del form"

    ' Limpiar los campos del form
    Public Sub Limpiar()

    End Sub

    ' Verificar que el usuario quiera salir del sistema
    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim ans As String
        ans = MsgBox("¿Seguro que desea salir?", vbYesNo, "Salida")
        If ans = vbNo Then
            e.Cancel = True
        End If
    End Sub

#End Region


End Class
