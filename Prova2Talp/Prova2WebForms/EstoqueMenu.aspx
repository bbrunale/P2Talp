<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EstoqueMenu.aspx.cs" Inherits="Prova2WebForms.EstoqueMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="PanelMenu" runat="server" Visible="true">
    <div class="jumbotron">
        <h1>lApices - Traçando seu rumo ao ápice</h1>
        <p class="lead">Estoque</p>
        <p><a href="Default.aspx" class="btn btn-primary btn-lg">Voltar &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Gerenciar Dados de Produtos</h2>
            <p>
                Vizualize, adicione, altere ou exclua Produtos
            </p>
            <p>
                <asp:Button ID="BtnAltProd" runat="server" Text="Gerenciar" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Gerenciar Tipos</h2>
            <p>
                Vizualize, adcione, altere ou exclua tipos de produtos
            </p>
            <p>
                <asp:Button ID="BtnAltTipoProd" runat="server" Text="Gerenciar" />
            </p>
        </div>
    </div>
    </asp:Panel>

    <asp:Panel ID="PanelProduto" runat="server" Visible="true">

    </asp:Panel>

    <asp:Panel ID="PanelTipo" runat="server" Visible="true">

    </asp:Panel>
    <p />

    <asp:Button ID="btnVoltar" runat="server" Text="Voltar" Visible ="false"/>
</asp:Content>
