<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VendasMenu.aspx.cs" Inherits="Prova2WebForms.VendasMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
                <asp:Button ID="BtnAddVenda" runat="server" Text="Adcionar" />
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
</asp:Content>
