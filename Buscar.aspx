<%@ Page Title="TRETSA - Buscar" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Buscar.aspx.cs" Inherits="Buscar" %>


<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <link rel="shortcut icon" type="image/x-icon" href="images/icon.ico"/>
    <style type="text/css">
        .txt {
    resize: none;
        }
</style>
<script type = "text/javascript">
    function Confirm() {
        var confirm_value = document.createElement("INPUT");
        confirm_value.type = "hidden";
        confirm_value.name = "confirm_value";
        if (confirm("Estas seguro que deseas desarticular?")) {
            confirm_value.value = "Si";
        } else {
            confirm_value.value = "No";
        }
        document.forms[0].appendChild(confirm_value);
    }
    </script>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Detalle de Articulado
    </h2>
    <div>
        <br />
        <asp:Table runat="server">
            <asp:TableHeaderRow>
                <asp:TableCell>
                            <asp:Label ID="Label9" runat="server" Text="Folio de Articulado" Width="200px"></asp:Label>
                </asp:TableCell>
                 <asp:TableCell>
                             <asp:Label ID="Label17" runat="server" Text="Fecha y Hora de Articulado" Width="200px"></asp:Label>
                </asp:TableCell>
            </asp:TableHeaderRow>
            <asp:TableHeaderRow>
                <asp:TableCell>
                            <asp:Label ID="Label8" runat="server" Text="" Font-Bold="True" Font-Size="Large"></asp:Label>
                </asp:TableCell>
                 <asp:TableCell>
                             <asp:Label ID="Label18" runat="server" Text="Label" Font-Bold="True" Font-Size="Small"></asp:Label>
                 </asp:TableCell>
            </asp:TableHeaderRow>
        </asp:Table>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Tipo de Articulado"></asp:Label>
        <br />
        <asp:Table runat="server">
            <asp:TableHeaderRow>
                <asp:TableCell>
                 <asp:Label ID="Label16" runat="server" Text="Label" Font-Bold="True" Font-Size="Medium" Width="80px"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Label ID="Label19" runat="server" Text="Label" Font-Bold="True" Font-Size="Medium" Width="180px"></asp:Label>
                </asp:TableCell>
            </asp:TableHeaderRow>
        </asp:Table>
        <br />
        <br />
        <asp:Table runat="server">
            <asp:TableHeaderRow>
                <asp:TableCell>
                            <asp:Label ID="Label1" runat="server" Text="Economico" Width="120px"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                            <asp:Label ID="Label2" runat="server" Text="Remolque 1" Width="120px"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                            <asp:Label ID="Label3" runat="server" Text="Dolly" Width="120px"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                            <asp:Label ID="Label4" runat="server" Text="Remolque 2" Width="120px"></asp:Label>
                </asp:TableCell>
            </asp:TableHeaderRow>
             <asp:TableHeaderRow>
                <asp:TableCell>
                            <asp:Label ID="Label10" runat="server" Text="Label" Font-Bold="True" Font-Size="Medium"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                            <asp:Label ID="Label11" runat="server" Text="Label" Font-Bold="True" Font-Size="Medium"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                            <asp:Label ID="Label12" runat="server" Text="Label" Font-Bold="True" Font-Size="Medium"></asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                            <asp:Label ID="Label13" runat="server" Text="Label" Font-Bold="True" Font-Size="Medium"></asp:Label>
                </asp:TableCell>
            </asp:TableHeaderRow>
        </asp:Table>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Operador "></asp:Label>
        <br />
        <asp:Label ID="Label14" runat="server" Text="Label" Font-Bold="True" Font-Size="Small"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Descripción de Articulado"></asp:Label>
        <br />
        <asp:Label ID="Label15" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Desarticular" OnClientClick = "Confirm()" OnClick="Button1_Click"/>
        <asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click" />
        <br />
        <br />
    </div>
</asp:Content>

