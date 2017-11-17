<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DespesasMenu.aspx.cs" Inherits="Prova2WebForms.DespesasMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="PanelMenu" runat="server" Visible="true">
    <div class="jumbotron">
        <h1>lApices - Traçando seu rumo ao ápice</h1>
        <p class="lead">DESPESAS</p>
        <p><a href="Default.aspx" class="btn btn-primary btn-lg">Voltar &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Gerenciar Dados de Despesas</h2>
            <p>
                Vizualize, adcione, altere ou exclua Despesas
            </p>
            <p>
                <asp:Button ID="BtnAltDesp" runat="server" Text="Gerenciar" OnClick="BtnAltDesp_Click" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Gerenciar Tipos</h2>
            <p>
                Vizualize, adcione, altere ou exclua tipos de despesas
            </p>
            <p>
                <asp:Button ID="BtnAltTipoDesp" runat="server" Text="Gerenciar" OnClick="BtnAltTipoDesp_Click" />
            </p>
        </div>
    </div>
    </asp:Panel>

    <asp:Panel ID="PanelDespesa" runat="server" Visible="false">    
        <h2>DESPESAS</h2>
        <p />
        <p>
            <asp:Label ID="LblOpDesp" runat="server" Text="Operação:"></asp:Label>
            <asp:DropDownList ID="DdlOperacaoDesp" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DdlOperacaoDesp_SelectedIndexChanged">
                <asp:ListItem Text="Adcionar" Value="add" Selected="True"></asp:ListItem>
                <asp:ListItem Text="Pesquisar" Value="pes"></asp:ListItem>
                <asp:ListItem Text="Deletar" Value="del"></asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LblTipoPesDesp" runat="server" Text="Pesquisar por:" Visible="false"></asp:Label>
            <asp:DropDownList ID="DdlTipoPesDesp" runat="server" Visible="false" AutoPostBack="true"  OnSelectedIndexChanged="DdlTipoPesDesp_SelectedIndexChanged">
                <asp:ListItem Text="Todos" Value="all" Selected="True"></asp:ListItem>
                <asp:ListItem Text="ID" Value="id"></asp:ListItem>
                <asp:ListItem Text="Nome" Value="nome"></asp:ListItem>
                <asp:ListItem Text="Tipo" Value="tipo"></asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnEnviarDesp" runat="server" Text="Enviar" OnClick="BtnEnviarDesp_Click" />
        </p>
        <p />
        <asp:Panel ID="PnlPesDesp" runat="server" Visible ="true">
        
            <asp:Label ID="LblIdDesp" runat="server" Text="Id:" Visible="false"></asp:Label>
            <asp:TextBox ID="TxtIdDesp" runat="server" Visible ="false"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Label ID="LblNomeDesp" runat="server" Text="Nome:"></asp:Label>
            <asp:TextBox ID="TxtNomeDesp" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LblDdlTipoDesp" runat="server" Text="Tipo:"></asp:Label>
            <asp:DropDownList ID="DdlTipoDesp" runat="server" Height="22px">
            </asp:DropDownList>
        
        </asp:Panel>
        <br />
        <asp:Panel ID="PnlAddDesp" runat="server" Visible="true">
            <asp:Label ID="LblVlrDesp" runat="server" Text="Valor:"></asp:Label>
            <asp:TextBox ID="TxtVlrDesp" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblDescDesp" runat="server" Text="Descricao:"></asp:Label>
            <asp:TextBox ID="TxtDescDesp" runat="server"></asp:TextBox>
        </asp:Panel>
        <p />
        <asp:Label ID="LblDataDesp" runat="server" Text="Data:"></asp:Label>
        <asp:Calendar ID="CalDesp" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="101px" NextPrevFormat="FullMonth" Width="382px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        <p />
        <asp:GridView ID="GridDesp" runat="server" AutoGenerateColumns="false" Width="100%"
            CellPadding="5" CellSpacing="8" GridLines="Vertical" AllowPaging="true" PageSize="5" OnPageIndexChanging="GridDesp_PageIndexChanging" OnSelectedIndexChanged="GridDesp_SelectedIndexChanged">
            
            <AlternatingRowStyle BackColor="#f1f1f1" />
            <HeaderStyle BackColor="#d1d1d1" />

            <Columns>
                <asp:BoundField DataField="IdDespesa" HeaderText="Id" />
                <asp:BoundField DataField="NomeDespesa" HeaderText="Nome" />
                <asp:BoundField DataField="ValorDespesa" HeaderText="Valor" />
                <asp:BoundField DataField="NomeTipoDespesa" HeaderText="Tipo" />
                <asp:BoundField DataField="DataDespesa" HeaderText="Data" />
                <asp:BoundField DataField="DescDespesa" HeaderText="Descricao" />
            </Columns>

        </asp:GridView>
    </asp:Panel>
    
    <asp:Panel ID="PanelTipo" runat="server" Visible="false">
        <h2>Tipos de Despesa</h2>
        <p />
        <p />
        
        <asp:Label ID="LblOpTipoDesp" runat="server" Text="Operação:"></asp:Label>
        <asp:DropDownList ID="DdlTipoOpTipoDesp" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DdlTipoOpTipoDesp_SelectedIndexChanged">
            <asp:ListItem Text="Adcionar" Value="add" Selected="True"></asp:ListItem>
            <asp:ListItem Text="Pesquisar" Value="pes"></asp:ListItem>
            <asp:ListItem Text="Deletar" Value="del"></asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:Label ID="LblTipoPesTipoDesp" runat="server" Text="Pesquisar por:" Visible="false"></asp:Label>
        <asp:DropDownList ID="DdlTipoPesTipoDesp" runat="server" Visible ="false" AutoPostBack="True" OnSelectedIndexChanged="DdlTipoPesTipoDesp_SelectedIndexChanged">
            <asp:ListItem Text="Todos" Value="all" Selected="True"></asp:ListItem>
            <asp:ListItem Text="ID" Value="Id"></asp:ListItem>
            <asp:ListItem Text="Nome" Value="Nome"></asp:ListItem>
        </asp:DropDownList>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnEnviaTipoDesp" runat="server" Text="Enviar" OnClick="BtnEnviaTipoDesp_Click" />
        <p />
        <asp:Label ID="LblIdTipoDesp" runat="server" Text="ID:" Visible ="false"></asp:Label>
        <asp:TextBox ID="TxtIdTipoDesp" runat="server" Visible="false"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LblNomeTipoDesp" runat="server" Text="Nome:"></asp:Label>
        <asp:TextBox ID="TxtNomeTipoDesp" runat="server"></asp:TextBox>
        <p />
        <asp:GridView ID="GridTipoDesp" runat="server" AutoGenerateColumns="false" Width="100%"
            CellPadding="5" CellSpacing="8" GridLines="Vertical" AllowPaging="true" PageSize="5" OnPageIndexChanging="GridTipoDesp_PageIndexChanging" OnSelectedIndexChanged="GridTipoDesp_SelectedIndexChanged">
            
            <AlternatingRowStyle BackColor="#f1f1f1" />
            <HeaderStyle BackColor="#d1d1d1" />

            <Columns>
                <asp:BoundField DataField="IdTipoDespesa" HeaderText="Id" />
                <asp:BoundField DataField="NomeTipoDespesa" HeaderText="Nome" />
            </Columns>

        </asp:GridView>
    
    </asp:Panel>
    <p />
    <asp:Button ID="btnVoltar" runat="server" Text="Voltar" Visible ="false" OnClick="btnVoltar_Click"/>
</asp:Content>
