<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FinancasMenu.aspx.cs" Inherits="Prova2WebForms.FinancasMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>lApices - Traçando seu rumo ao ápice</h1>
        <p class="lead">FINANÇAS</p>
        <p><a href="Default.aspx" class="btn btn-primary btn-lg">Voltar &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Saldo</h2>
            <p>
               Saldo Bancario da fabrica
            </p>
            <p>
               <a href="Saldo.aspx" class="btn btn-primary btn-lg">Saber Mais &raquo;</a>
            </p>
        </div>
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

</asp:Content>
