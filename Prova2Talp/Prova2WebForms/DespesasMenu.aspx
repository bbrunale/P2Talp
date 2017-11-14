<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DespesasMenu.aspx.cs" Inherits="Prova2WebForms.DespesasMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>lApices - Traçando seu rumo ao ápice</h1>
        <p class="lead">DESPESAS</p>
        <p><a href="Default.aspx" class="btn btn-primary btn-lg">Voltar &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Adcionar Despesa</h2>
            <p>
               Adcione despesas ao sistema
            </p>
            <p>
                <asp:Button ID="BtnAddDesp" runat="server" Text="Adcionar" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Gerenciar Dados de Despesas</h2>
            <p>
                Vizualize, altere ou exclua Despesas
            </p>
            <p>
                <asp:Button ID="BtnAltDesp" runat="server" Text="Gerenciar" />
            </p>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <h2>Adcionar Tipo</h2>
            <p>
                Adcione tipos de despesas ao sistema
            </p>
            <p>
                <asp:Button ID="BtnAddTipoDesp" runat="server" Text="Adcionar" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Gerenciar Tipos</h2>
            <p>
                Vizualize, altere ou exclua tipos de despesas
            </p>
            <p>
                <asp:Button ID="BtnAltTipoDesp" runat="server" Text="Gerenciar" />
            </p>
        </div>
    </div>
</asp:Content>
