Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lWSEDV As New WSEDV.Servicios
        lWSEDV.Registrar(TextBox1.Text)
        TextBox1.Text = 1
        'Prueba
    End Sub
End Class
