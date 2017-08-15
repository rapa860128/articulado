<%@ Page Title="TRETSA - Historico" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Historico.aspx.cs" Inherits="Historico" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
        <link rel="shortcut icon" type="image/x-icon" href="images/icon.ico"/>

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Historico de Articulados
    </h2>
    <br />
    <br />

    <div>


    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AllowPaging="true" ShowHeaderWhenEmpty="True" EmptyDataText = "No se han creado articulados!" AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

        <Columns>
     <asp:HyperLinkField DataNavigateUrlFields="contador_folio" 
     DataNavigateUrlFormatString="~/Detalle.aspx?id={0}" 
		Text="Detalle" />
        <asp:BoundField DataField="contador_folio" HeaderText="Folio" HtmlEncode="false" ItemStyle-HorizontalAlign="Center">
        <ItemStyle HorizontalAlign="Center"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="feregistro" HeaderText="Fecha de Registro" HtmlEncode="false"/>
        <asp:BoundField DataField="nombre" HeaderText="Operador" HtmlEncode="false" />
        <asp:BoundField DataField="no_econ" HeaderText="# Económico" HtmlEncode="false" ItemStyle-HorizontalAlign="Center">
        <ItemStyle HorizontalAlign="Center"></ItemStyle>
        </asp:BoundField>
        <asp:BoundField DataField="desc_articu" HeaderText="Descripción" HtmlEncode="false"/>
        
        </Columns>

    </asp:GridView>

        </div>
    <br />
    <br />

</asp:Content>
