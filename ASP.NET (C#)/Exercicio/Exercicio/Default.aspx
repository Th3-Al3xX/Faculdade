<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exercicio._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 311px">
    
        <table style="width:100%;">
            <tr>
                <td colspan="2">
                    Item:<br />
                    <asp:TextBox ID="txtItem" runat="server" Width="300px"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    Valor:<br />
                    <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnADD" runat="server" onclick="btnADD_Click" 
                        Text="Adicionar" />
                </td>
                <td align="right">
                    <asp:Button ID="btnNext" runat="server" onclick="btnNext_Click" 
                        Text="Próximo &gt;&gt;&gt;" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
