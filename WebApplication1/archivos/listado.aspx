<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listado.aspx.cs" Inherits="WebApplication1.archivos.listado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="CSS/estilos-listado.css"/>
    <title>Sistema registro y visualización autobuses</title>
    <style type="text/css">
        #form1 {
            height: 788px;
        }
    </style>
</head>
<body style="height: 759px">
    <form id="form1" runat="server">

        <asp:Image ID="Image1" runat="server" Height="283px" ImageAlign="Middle" ImageUrl="~/archivos/imagen/sn.png" Width="1063px" />

        <div style="height: 565px" >

            <asp:DropDownList class="drop1" ID="DropProvinicia" runat="server">
                <asp:ListItem>---</asp:ListItem>
                <asp:ListItem>San Jose</asp:ListItem>
                <asp:ListItem>Alajuela</asp:ListItem>
                <asp:ListItem>Cartago</asp:ListItem>
                <asp:ListItem>Limon</asp:ListItem>
                <asp:ListItem>Guanacaste</asp:ListItem>
                <asp:ListItem>Puntarenas</asp:ListItem>
                <asp:ListItem>Heredia</asp:ListItem>
            </asp:DropDownList>

            <asp:Button class="drop2" ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />

            <asp:TextBox class="drop3" ID="TextMostrar" runat="server" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>

            <asp:ImageButton class="img1" ID="ImageButton1" runat="server" ImageUrl="~/archivos/imagen/home.png " PostBackUrl="index.aspx"/>
        </div>
    </form>
</body>
</html>
