<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FinancasMenu.aspx.cs" Inherits="Prova2WebForms.FinancasMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="PanelMenu" runat="server" Visible="true">
    <div class="jumbotron">
        <h1>lApices - Traçando seu rumo ao ápice</h1>
        <p class="lead">FINANÇAS</p>
        <p><a href="Default.aspx" class="btn btn-primary btn-lg">Voltar &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Extrato</h2>
            <p>
                Histórico de transações efetuada e saldo
            </p>
            <p>
                <a href="Extrato.aspx" class="btn btn-primary btn-lg">Saber Mais &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Lançamentos futuros</h2>
            <p>
                Vizualize aqui os lançamentos que estao previstos para o futuro
            </p>
            <p>
                <a href="Lancamentos.aspx" class="btn btn-primary btn-lg">Saber Mais &raquo;</a>
            </p>
        </div>
    </div>
    </asp:Panel>

    <asp:Panel ID="PanelExtrato" runat="server" Visible="true">

    </asp:Panel>
    
    <asp:Panel ID="PanelLancamentos" runat="server" Visible="true">

    </asp:Panel>
    <p />

    <asp:Button ID="btnVoltar" runat="server" Text="Voltar" Visible ="false"/>
</asp:Content>
