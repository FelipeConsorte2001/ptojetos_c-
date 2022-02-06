<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cookie._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <div class="jumbotron">
 <table style="background-color:Aqua">
 <tr>
 <td>
 Login
 </td>
 <td>
 <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
 </td>
 </tr>
 <tr>
 <td>
 Senha</td>
 <td>
 <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
 </td>
 </tr>
 </table>
 <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
 <br />
 <table style="background-color:Teal">
 <tr>
 <td>
 <asp:Button ID="Button1" runat="server" Text="Incluir" />
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSourceUsuario">
         <Columns>
             <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
             <asp:BoundField DataField="login" HeaderText="login" SortExpression="login" />
             <asp:BoundField DataField="senha" HeaderText="senha" SortExpression="senha" />
         </Columns>
     </asp:GridView>
     <asp:SqlDataSource ID="SqlDataSourceUsuario" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [login] WHERE [Id] = @Id" InsertCommand="INSERT INTO [login] ([login], [senha]) VALUES (@login, @senha)" SelectCommand="SELECT * FROM [login]" UpdateCommand="UPDATE [login] SET [login] = @login, [senha] = @senha WHERE [Id] = @Id">
         <DeleteParameters>
             <asp:Parameter Name="Id" Type="Int32" />
         </DeleteParameters>
         <InsertParameters>
             <asp:Parameter Name="login" Type="String" />
             <asp:Parameter Name="senha" Type="String" />
         </InsertParameters>
         <UpdateParameters>
             <asp:Parameter Name="login" Type="String" />
             <asp:Parameter Name="senha" Type="String" />
             <asp:Parameter Name="Id" Type="Int32" />
         </UpdateParameters>
     </asp:SqlDataSource>
 </td>
 </tr>
 </table>
 </div>

</asp:Content>
