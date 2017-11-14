<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EstoqueMenu.aspx.cs" Inherits="Prova2WebForms.EstoqueMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>lApices - Traçando seu rumo ao ápice</h1>
        <p class="lead">Estoque</p>
        <p><a href="Default.aspx" class="btn btn-primary btn-lg">Voltar &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Adcionar Produto</h2>
            <p>
               Adcione um produto ao sistema
            </p>
            <p>
                <asp:Button ID="BtnAddProd" runat="server" Text="Adcionar" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Restocar Produto</h2>
            <p>
               Restoque um determinado produto
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="Adcionar" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Gerenciar Dados de Produtos</h2>
            <p>
                Vizualize, altere ou exclua Produtos
            </p>
            <p>
                <asp:Button ID="BtnAltProd" runat="server" Text="Gerenciar" />
            </p>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <h2>Adcionar Tipo</h2>
            <p>
                Adcione tipos de produto ao sistema
            </p>
            <p>
                <asp:Button ID="BtnAddTipoProd" runat="server" Text="Adcionar" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Gerenciar Tipos</h2>
            <p>
                Vizualize, altere ou exclua tipos de produtos
            </p>
            <p>
                <asp:Button ID="BtnAltTipoProd" runat="server" Text="Gerenciar" />
            </p>
        </div>
    </div>
</asp:Content>
