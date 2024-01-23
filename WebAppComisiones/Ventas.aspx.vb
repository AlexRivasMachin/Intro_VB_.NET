Public Class Ventas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Buttom1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c As New Comisiones__Labo_1___Alex_Rivas.Ventas
        TextBox3.Text = c.comision(CSng(TextBox2.Text), CInt(TextBox1.Text))
    End Sub

End Class
