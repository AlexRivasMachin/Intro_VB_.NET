Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ventas As New Comisiones__Labo_1___Alex_Rivas.Ventas

        TextBox3.Text = ventas.comision(CSng(TextBox2.Text), CInt(TextBox1.Text))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
