﻿<%@ Master Language="C#" AutoEventWireup="true" CodeBehind="Site.master.cs" Inherits="AulaWeb1.SiteMaster" %>

<!DOCTYPE html>

<html lang="pt">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %>- Meu aplicativo ASP.NET</title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

</head>
<body>
    <form runat="server">
        <asp:ScriptManager runat="server">
            <Scripts>
                <%--To learn more about bundling scripts in ScriptManager see https://go.microsoft.com/fwlink/?LinkID=301884 --%>
                <%--Framework Scripts--%>
                <asp:ScriptReference Name="MsAjaxBundle" />
                <asp:ScriptReference Name="jquery" />
                <asp:ScriptReference Name="bootstrap" />
                <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                <asp:ScriptReference Name="WebFormsBundle" />
                <%--Site Scripts--%>
            </Scripts>
        </asp:ScriptManager>

        <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" runat="server" href="~/">Cadastro de Produtos</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a runat="server" href="~/">Página inicial</a></li>
                        <li><a runat="server" href="~/About">Sobre</a></li>
                        <li><a runat="server" href="~/Contact">Contato</a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div>
            <asp:ContentPlaceHolder ID="MainContent" runat="server">
            </asp:ContentPlaceHolder>
            Codigo do produto<asp:TextBox ID="txtCodigoProduto" runat="server" Width="196px" Height="23px"></asp:TextBox>
            <br />
            Nome do Produto&nbsp; <asp:TextBox ID="txtNomeProduto" runat="server" Width="194px" Height="19px"></asp:TextBox>
            <br />
            Valor do produto&nbsp;<asp:TextBox ID="txtValorProduto" runat="server" Width="196px" Height="17px"></asp:TextBox>
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" />
            <asp:Button ID="btnExcluir" runat="server" Text="Excluir" />
            <asp:Button ID="btnAtualiza" runat="server" Text="Atualiza" />
            <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" />
            <br />
            <br />
            <asp:GridView ID="gdvProdutos" runat="server" Height="127px" Width="345px">
            </asp:GridView>
            <footer>
                <p>&copy; <%--To learn more about bundling scripts in ScriptManager see https://go.microsoft.com/fwlink/?LinkID=301884 --%>- Meu aplicativo ASP.NET</p>
            </footer>
        </div>

    </form>
</body>
</html>
