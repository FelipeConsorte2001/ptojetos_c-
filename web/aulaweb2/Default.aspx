<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="aulaweb2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <br />
        <br />
        <table style="width:100%;">
            <tr>
                <td style="width: 96px">Nome:</td>
                <td>
                    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 96px">Sexo</td>
                <td>
                    <asp:RadioButtonList ID="rblSexo" runat="server">
                        <asp:ListItem>Maculino</asp:ListItem>
                        <asp:ListItem>Femenino</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="height: 20px; width: 96px;">Estado</td>
                <td style="height: 20px">
                    <asp:DropDownList ID="ddlEstados" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>São Paulo</asp:ListItem>
                        <asp:ListItem>Rio de janeiro</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="height: 20px"></td>
            </tr>
            <tr>
                <td style="height: 20px; width: 96px;">Concordo</td>
                <td style="height: 20px">
                    <asp:RadioButtonList ID="ckbConfirma" runat="server">
                        <asp:ListItem>Sim</asp:ListItem>
                        <asp:ListItem>Não</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td style="height: 20px"></td>
            </tr>
        </table>
        <asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Enviar" />
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>

</asp:Content>
