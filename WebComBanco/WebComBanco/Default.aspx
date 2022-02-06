<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebComBanco._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div class="jumbotron">
        RGM:
        <asp:TextBox ID="txtRGM" runat="server"></asp:TextBox>
        <br />
        <br />
        NOME:
        <asp:TextBox ID="txtNome" runat="server" Width="327px"></asp:TextBox>
        <br />
        <br />
        NOTA1:
        <asp:TextBox ID="txtNota1" runat="server"></asp:TextBox>
        <br />
        <br />
        NOTA2:
        <asp:TextBox ID="txtNota2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnIncluir" runat="server" Text="Incluir" OnClick="btnIncluir_Click1"  />
 
        <asp:Button ID="btnAlterar" runat="server" Text="Alterar"  />
 
        <asp:Button ID="btnExcluir" runat="server" Text="Excluir"  />
        <br />
        <br />
        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="rgm" DataSourceID="DataSourceAluno" Width="274px">
                <Columns>
                    <asp:BoundField DataField="rgm" HeaderText="rgm" ReadOnly="True" SortExpression="rgm" />
                    <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" />
                    <asp:BoundField DataField="nota1" HeaderText="nota1" SortExpression="nota1" />
                    <asp:BoundField DataField="nota2" HeaderText="nota2" SortExpression="nota2" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="DataSourceAluno" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringAlunos %>" SelectCommand="SELECT [rgm], [nome], [nota1], [nota2] FROM [dados] ORDER BY [rgm]"></asp:SqlDataSource>
        <br />
    </div>
        
</asp:Content>
