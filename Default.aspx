<%@ Page Title="TRETSA - Articulado" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <link rel="shortcut icon" type="image/x-icon" href="images/icon.ico"/>
    <style type="text/css">
        .txt {
    resize: none;
        }
</style>

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Articular Unidades
    </h2>
    <div>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Articular"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem Value="1">Full</asp:ListItem>
            <asp:ListItem Value="2">Sencillo</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Folio de Articulado "></asp:Label>
        <br />
        <asp:Label ID="Label8" runat="server" Text="" Font-Bold="True" Font-Size="Large"></asp:Label>
    <br />
        <br />
        <asp:Table runat="server">
            <asp:TableHeaderRow>
                <asp:TableCell>
                    <asp:Label ID="Label10" runat="server" Text="Tipo de Articulado" Width="120px"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                            <asp:Label ID="Label1" runat="server" Text="Economico" Width="120px"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                            <asp:Label ID="Label2" runat="server" Text=" Remolque 1" Width="120px"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                            <asp:Label ID="Label3" runat="server" Text=" Dolly" Width="120px"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                            <asp:Label ID="Label4" runat="server" Text=" Remolque 2" Width="120px"></asp:Label>
                </asp:TableCell>
            </asp:TableHeaderRow>
            <asp:TableHeaderRow>
                <asp:TableCell>
                    <asp:DropDownList ID="DropDownList6" runat="server" Width="100px"></asp:DropDownList>
                </asp:TableCell>
                <asp:TableCell>
                            <asp:DropDownList ID="DropDownList1" runat="server" Width="100px"></asp:DropDownList>
                </asp:TableCell>
                <asp:TableCell>
                            <asp:DropDownList ID="DropDownList2" runat="server" Width="100px"></asp:DropDownList>
                </asp:TableCell>
                <asp:TableCell>
                            <asp:DropDownList ID="DropDownList3" runat="server" Width="100px"></asp:DropDownList>
                </asp:TableCell>
                <asp:TableCell>
                            <asp:DropDownList ID="DropDownList4" runat="server" Width="100px"></asp:DropDownList>
                </asp:TableCell>
            </asp:TableHeaderRow>
        </asp:Table>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Operador"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList5" runat="server" Width="475px"></asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Descripción de Articulado"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="470px" CssClass="txt" AutoCompleteType="Disabled"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Articular" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click" />
        <br />
        <br />
    </div>
</asp:Content>
