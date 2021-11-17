<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Exercicio_15_10_11.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 305px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 57%">
    
        <table style="width: 57%;">
            <tr>
                <td class="style1">
                    Item:<br />
                    <asp:TextBox ID="txtItem" runat="server" ontextchanged="TextBox1_TextChanged" 
                        Width="300px"></asp:TextBox>
                </td>
                <td>
                    Valor:<br />
                    <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td align="right">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" onclick="btnAdd_Click" />
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td align="right">
                    <asp:Button ID="btnNext" runat="server" Text="Next &gt;&gt;&gt;" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
