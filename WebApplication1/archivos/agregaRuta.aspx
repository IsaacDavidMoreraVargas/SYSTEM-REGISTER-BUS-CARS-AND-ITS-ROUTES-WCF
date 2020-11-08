<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agregaRuta.aspx.cs" Inherits="WebApplication1.archivos.agregaRuta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="CSS/estilos-registroRuta.css"/>
    <title>Sistema registro y visualización autobuses</title>
    <style type="text/css">
        #form1 {
            height: 773px;
        }
    </style>
</head>
<body style="height: 759px">

    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" Height="283px" ImageAlign="Middle" ImageUrl="~/archivos/imagen/sn.png" Width="1063px" />
         
        
        <asp:Label class="label" ID="Label1" runat="server" BorderStyle="None" Height="30px" Text="Seleccione la provincia" Width="264px" style="margin-top: 22px; top: 325px; left: 15px;" ></asp:Label>
          
        <asp:DropDownList class="drop1"  ID="DropProvincia" runat="server">
            <asp:ListItem>---</asp:ListItem>
            <asp:ListItem>San Jose</asp:ListItem>
            <asp:ListItem>Alajuela</asp:ListItem>
            <asp:ListItem>Heredia</asp:ListItem>
            <asp:ListItem>Cartago</asp:ListItem>
            <asp:ListItem>Limon</asp:ListItem>
            <asp:ListItem>Guanacaste</asp:ListItem>
            <asp:ListItem>Puntarenas</asp:ListItem>
        </asp:DropDownList>
          
        <asp:Label class="label2" ID="TextBox1" runat="server">Inicio de Ruta</asp:Label>
        <asp:Label class="label3" ID="TextBox2" runat="server">Fin de ruta </asp:Label>
        <asp:Label class="label4" ID="TextBox3" runat="server">¿Esta rural?</asp:Label>
        <asp:Label class="label6" ID="TextBox5" runat="server">Cantidad de kilometros de la ruta</asp:Label>
          
        <asp:DropDownList class="drop3" ID="DropRural" runat="server">
            <asp:ListItem>---</asp:ListItem>
            <asp:ListItem>Si</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:DropDownList> 
          
        <asp:TextBox class="text3" ID="TextInicio" runat="server"></asp:TextBox>
          
        <asp:TextBox class="text1" ID="TextFin" runat="server"></asp:TextBox>
        <asp:TextBox class="text2" ID="TextKilometros" runat="server"></asp:TextBox>

        <asp:Button class="img1" ID="ButtonRegistra" runat="server" Text="Registrar" OnClick="ButtonRegistra_Click" />

        <asp:TextBox class="text4" ID="TextMostrar" runat="server" ReadOnly="True" TextMode="MultiLine" Wrap="False">Aqui se mostraran la ruta que generes</asp:TextBox>

        <asp:ImageButton class="img2" ID="ImageButton1" runat="server" ImageUrl="~/archivos/imagen/home.png " PostBackUrl="index.aspx"/>
    </form>
</body>
</html>
