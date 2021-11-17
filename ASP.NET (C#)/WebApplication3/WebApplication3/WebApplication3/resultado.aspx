<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="resultado.aspx.cs" Inherits="WebApplication3.resultado" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <link href="Stylesheet1.css" rel="stylesheet" type="text/css" />
    <title>Segunda Página</title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Segunda Página - Resultado</h1>
    <div>
        Olá, <asp:Label ID="lblNome" runat="server" Text="" /><br />
        Você tem <asp:Label ID="lblIdade" runat="server" Text="" /> anos.<br />
        Você é o usuário nº <asp:Label ID="lblQteTotal" runat="server" Text="" /> do Sistema<br />
        Atualmente existem <asp:Label ID="lblUsarioOnLine" runat="server" Text="" /> OnLine no Sistema <br />
        O sistema está no Ar desde <asp:Label ID="lblStartApp" runat="server" Text="" /><br />
       <asp:Button runat="server" ID="btnVoltar" Text="<< Voltar" PostBackUrl="~/Default.aspx" />
                
        
    </div>
    </form>
</body>
</html>
