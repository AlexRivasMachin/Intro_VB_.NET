Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Buttom1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cuota As New CuotaAnual.Cuota
        TextBox4.Text = cuota.cuotaAnual(CSng(TextBox1.Text), CInt(TextBox2.Text), CInt(TextBox3.Text))
    End Sub
End Class
