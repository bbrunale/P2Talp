<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VendasMenu.aspx.cs" Inherits="Prova2WebForms.VendasMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Panel ID="PanelMenu" runat="server" Visible="true">
    <div class="jumbotron">
        <h1>lApices - Traçando seu rumo ao ápice</h1>
        <p class="lead">VENDAS</p>
        <p><a href="Default.aspx" class="btn btn-primary btn-lg">Voltar &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Adcionar Venda</h2>
            <p>
               Adcione venda ao sistema
            </p>
            <p>
                <asp:Button ID="BtnAddVenda" runat="server" Text="Adcionar" OnClick="BtnAddVenda_Click" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Gerenciar Dados de Venda</h2>
            <p>
                Vizualize, altere ou exclua Venda
            </p>
            <p>
                <asp:Button ID="BtnAltVenda" runat="server" Text="Gerenciar" />
            </p>
        </div>
    </div>
    </asp:panel>
    <asp:Panel ID="PanelVenda" runat="server" Visible="true">

    </asp:Panel>
    <asp:Panel ID="PanelLista" runat="server" Visible="true">

    </asp:Panel>
    <p />

    <asp:Button ID="btnVoltar" runat="server" Text="Voltar" Visible ="false"/>
</asp:Content>
