﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Cuota.aspx.vb" Inherits="WebCuotaAnual.Cuota" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <p>
        Capital</p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Plazo</p>
    <p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Interes</p>
    <p>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Calcular comisión" />
    </p>
    <p>
        La cuotaAnual es:</p>
    <p>
        <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
    </p>
</form>
</body>
</html>
