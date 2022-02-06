<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="veiculos._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        
        <asp:Label ID="Label1" runat="server" Text="Modelo Veiculo:"></asp:Label>
        <asp:TextBox ID="txtModelo" runat="server" Height="22px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Valor:"></asp:Label>
        <asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Flex:"></asp:Label>
        <asp:TextBox ID="txtFlex" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Salvar" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="Alterar" OnClick="Button2_Click" />
&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Excluir" OnClick="Button3_Click" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="ModeloVeiculo" HeaderText="ModeloVeiculo" SortExpression="ModeloVeiculo" />
                <asp:BoundField DataField="Valor" HeaderText="Valor" SortExpression="Valor" />
                <asp:BoundField DataField="Flex" HeaderText="Flex" SortExpression="Flex" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT  cod_veiculos AS ID, desc_veiculos AS ModeloVeiculo, val_veiculos AS Valor, flex_veiculos AS Flex FROM carros"></asp:SqlDataSource>
        
    </div>

   

</asp:Content>
