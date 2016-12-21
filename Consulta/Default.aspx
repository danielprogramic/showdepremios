<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Consulta_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consulta Pontos</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" DefaultFocus="edtCPF">
    <div>
    
        <h2>Show de Prêmios</h2>
        
        <h3>Consulta de Pontos</h3>
        
        <div aria-orientation="horizontal">
            
            <strong>CPF:&nbsp; </strong>
            <asp:TextBox ID="edtCPF" runat="server"></asp:TextBox>
            &nbsp;
            <asp:ImageButton ID="btnConsultar" runat="server" OnClick="OnClick" ImageUrl="~/Images/pesquisar.png" Height="32px" Width="32px" />
            
        </div>
        
        <div>
            <br />
            <asp:Label ID="lblResultado" runat="server" Text="Resultado da Pesquisa"></asp:Label>
        </div>

    </div>
    </form>
</body>
</html>
