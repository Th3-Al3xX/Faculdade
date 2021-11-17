<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>HTML de TESTE</title>
    <link href="Stylesheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            <h2>Primeira Página</h2>            
        </center>
        <table>
            <tr>
                <td>Nome:</td>
                <td><asp:TextBox ID="txtNome" runat="server" Width="355px" /> </td>
            </tr>
            <tr>
                <td>Data de Nascimento:</td>
                <td><asp:TextBox ID="txtNascimento" runat="server" Width="158px" /> </td>
            </tr>      
            <tr>
                <td></td>
                <td align="right">
                    <asp:Button runat="server" ID="btnAvancar" Text="Avançar >>" 
                        onclick="btnAvancar_Click" />
                </td>
            </tr>                  
        </table>
    </div>
    </form>
</body>
</html>
