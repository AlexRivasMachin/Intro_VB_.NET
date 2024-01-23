Public Class Cuota
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Buttom1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cuota As New CuotaAnual.Cuota
        TextBox4.Text = cuota.cuotaAnual(CSng(TextBox1.Text), CInt(TextBox2.Text), CInt(TextBox3.Text))
    End Sub

End Class