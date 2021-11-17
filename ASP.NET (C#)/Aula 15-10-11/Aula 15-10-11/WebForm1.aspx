<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Aula_15_10_11.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 197px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 39%">
    
        <table style="width: 39%;">
            <tr>
                <td colspan="2">
                    Nome<br />
        <asp:TextBox ID="txtNome" runat="server" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    Endereço<br />
        <asp:TextBox ID="txtEndereco" runat="server" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Idade<br />
        <asp:TextBox ID="txtIdade" runat="server" Width="100px"></asp:TextBox>
                    anos</td>
                <td>
                    Sexo<br />
        <asp:DropDownList ID="ddlSexo" runat="server">
            <asp:ListItem Value="1">1: Masculino</asp:ListItem>
            <asp:ListItem Value="2">2: Feminino</asp:ListItem>
        </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="right" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="right" colspan="2">
        <asp:Button ID="btnEnviar" runat="server" onclick="Button1_Click" Text="Enviar" />
    
                </td>
            </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
