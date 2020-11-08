<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication1.archivos.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="CSS/estilos-Index.css"/>
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

        <div class="colorTable">
          <p class="img0">MENU </p>
          <p class="img1">  </p> 
          <p class="img2"> <a  href="agregarBus.aspx"> Registro de autobuses </a></p>
          <p class="img3"> </p>
          <p class="img4"> <a  href="listado.aspx">  Listado de autobuses </a> </p>
          <p class="img5"> </p>
          <p class="img6"> <a  href="agregaRuta.aspx">  Registro de rutas </a> </p>
   
        </div>
    </form>
</body>
</html>
