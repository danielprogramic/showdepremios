<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Admin_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="../Content/css/normalize.css" />
    <link rel="stylesheet" type="text/css" href="../Content/css/demo.css" />
    <link rel="stylesheet" type="text/css" href="../Content/css/component.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/3.5.2/animate.min.css">
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1/jquery.min.js"></script>
    <script src="http://cdnjs.cloudflare.com/ajax/libs/jquery-throttle-debounce/1.1/jquery.ba-throttle-debounce.min.js"></script>

</head>
<body>
    <form  id="form1" runat="server">
    <div align="center">
        <asp:ScriptManager ID="scr1" runat="server"></asp:ScriptManager>
        <script language="javascript" type="text/javascript">
            window.load = function () {
                $get('<%=LoginAc.FindControl("UserName").ClientID %>').focus();
            }
        </script>
        <asp:UpdatePanel ID="updLogin" runat="server">
        <ContentTemplate>
        <asp:Login ID="LoginAc" runat="server" OnAuthenticate="Login_Authenticate" DestinationPageUrl="~/Admin/Default.aspx">
            <LayoutTemplate >
                        <center>
                        <table class="tabela-listagem" style="width:300px;">
                           
                                <td style="padding:0px;" style="width:300px;">
                                    <table class="form-borda" style="width:300px;">
                                     <center> 
                                        <tr style="/* Permalink - use to edit and share this gradient: http://colorzilla.com/gradient-editor/#cb60b3+0,ad1283+50,de47ac+100;Pink+3D */
                                    background: #cb60b3; /* Old browsers */
                                    background: -moz-linear-gradient(top,  #cb60b3 0%, #ad1283 50%, #de47ac 100%); /* FF3.6-15 */
                                    background: -webkit-linear-gradient(top,  #cb60b3 0%,#ad1283 50%,#de47ac 100%); /* Chrome10-25,Safari5.1-6 */
                                    background: linear-gradient(to bottom,  #cb60b3 0%,#ad1283 50%,#de47ac 100%); /* W3C, IE10+, FF16+, Chrome26+, Opera12+, Safari7+ */
                                    filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#cb60b3', endColorstr='#de47ac',GradientType=0 ); /* IE6-9 */
                                    " >
                                    <td class="tabela-header" style="height:40px;font-weight: bold;margin-left:20px;color:#fff;" colspan="2">ACESSO RESTRITO</td>
                                        </tr>
                                     </center>
                                        <tr>
                                            <td class="form-header">Usuário:</td>
                                            <td class="form-item"><asp:TextBox ID="UserName" runat="server" Columns="20" MaxLength="60"></asp:TextBox><br />
                                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ValidationGroup="LoginAc" Display="Dynamic" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="form-header">Senha:</td>
                                            <td class="form-item">
                                                <asp:TextBox ID="Password" runat="server" TextMode="Password" Columns="10" MaxLength="12"></asp:TextBox><br />
                                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ValidationGroup="LoginAc" Display="Dynamic" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                            </td>
                                        </tr>
                                        <tr class="form-item">
                                            <td align="center" colspan="2" class="controle-validator" style="font-size:13px;">
                                                <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                            </td>
                                        </tr>
                                        <tr class="form-item-rodape">
                                            <td style="text-align:left;" colspan="2">
                                                <table width="100%" cellspacing="0" cellpadding="0">
                                                    <tr>
                                                        <td class="texto-simples">
                                                            <asp:UpdateProgress ID="updProgresso" runat="server">
                                                                <ProgressTemplate>
                                                                    <img src="<%=ResolveClientUrl("~/Images/ajax-loader-white.gif") %>" alt="load" /> Carregando...
                                                                </ProgressTemplate>
                                                            </asp:UpdateProgress>
                                                        </td>
                                                        <td style="text-align:right;">
                                                            <asp:Button   ID="LoginButton" runat="server" CommandName="Login" Text="Confirmar" ValidationGroup="LoginAc" />                                                        
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                           
                        </table>
                     </center>
                    </LayoutTemplate>            
        </asp:Login>
        </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
