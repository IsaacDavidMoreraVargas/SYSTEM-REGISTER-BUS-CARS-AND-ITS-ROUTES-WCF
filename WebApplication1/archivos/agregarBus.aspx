<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agregarBus.aspx.cs" Inherits="WebApplication1.archivos.agregarBus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="CSS/estilos-registroBus.css"/>
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
          
        <asp:Label class="label2" ID="TextBox1" runat="server">Ruta de pertenencia</asp:Label>
        <asp:Label class="label3" ID="TextBox2" runat="server">¿Esta inscrito?</asp:Label>
        <asp:Label class="label4" ID="TextBox3" runat="server">¿Esta autorizado?</asp:Label>
        <asp:Label class="label5" ID="TextBox4" runat="server">Cantidad pasajeros pie</asp:Label>
        <asp:Label class="label6" ID="TextBox5" runat="server">Cantidad pasajeros sentados</asp:Label>
          
        <asp:DropDownList class="drop2" ID="DropInscrito" runat="server">
            <asp:ListItem>---</asp:ListItem>
            <asp:ListItem>Si</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:DropDownList>

        <asp:DropDownList class="drop3" ID="DropAutorizado" runat="server">
            <asp:ListItem>---</asp:ListItem>
            <asp:ListItem>Si</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:DropDownList> 
          
        <asp:TextBox class="text3" ID="TextRuta" runat="server"></asp:TextBox>
          
        <asp:TextBox class="text1" ID="TextPaPie" runat="server"></asp:TextBox>
        <asp:TextBox class="text2" ID="TextPaSentados" runat="server"></asp:TextBox>

        <asp:Button class="img1" ID="ButtonRegistra" runat="server" Text="Registrar" OnClick="ButtonRegistra_Click" />

        <asp:TextBox class="text4" ID="TextMostrar" runat="server" ReadOnly="True" TextMode="MultiLine" Wrap="False">Aqui se mostraran el autobus que generes</asp:TextBox>

        <asp:ImageButton class="img2" ID="ImageButton1" runat="server" href="index.aspx" ImageUrl="~/archivos/imagen/home.png" PostBackUrl="index.aspx"/>
        
    </form> 
</body>
</html>
