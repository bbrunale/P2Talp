<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Prova2WebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>lApices - Traçando seu rumo ao ápice</h1>
        <p class="lead">Serviços de gerenciamento</p>
        <p><a href="about.aspx" class="btn btn-primary btn-lg">Saber Mais &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Vendas</h2>
            <p>
               Gerencie aqui suas Vendas
            </p>
            <p>
               <a href="Venda.aspx" class="btn btn-primary btn-lg">Saber Mais &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Despesas</h2>
            <p>
                Gerencie aqui suas Despesas
            </p>
            <p>
                <a href="DespesasMenu.aspx" class="btn btn-primary btn-lg">Saber Mais &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Estoque</h2>
            <p>
                Gerencie aqui seus produtos
            </p>
            <p>
                <a href="EstoqueMenu.aspx" class="btn btn-primary btn-lg">Saber Mais &raquo;</a>
            </p>
        </div>
    </div>
    <div class="col-md-4">
            <h2>Financeiro</h2>
            <p>
                Vizualize aqui seu Saldo, Extrato e Lançamentos futuros
            </p>
            <p>
                <a href="FinancasMenu.aspx" class="btn btn-primary btn-lg">Saber Mais &raquo;</a>
            </p>
        </div>

</asp:Content>
