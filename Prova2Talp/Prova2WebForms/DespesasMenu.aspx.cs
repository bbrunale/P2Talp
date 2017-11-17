using Prova2Talp.BLL;
using Prova2Talp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prova2WebForms
{
    public partial class DespesasMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TipoDespesaBLL tipoDespesa = new TipoDespesaBLL();
            DdlTipoDesp.DataSource = tipoDespesa.buscarTodosTiposDespesas();
            DdlTipoDesp.DataTextField = "NomeTipoDespesa";
            DdlTipoDesp.DataValueField = "IdTipoDespesa";
            DdlTipoDesp.DataBind();
        }
        /*--------------------------------------FUNÇOES------------------------------------*/
        //-------------------------------------GRID-FILL------------------------------------
        private void preecherAllGridDespesas()
        {
            Prova2Talp.BLL.DespesaBLL despesaBLL = new Prova2Talp.BLL.DespesaBLL();
            DataTable tb = despesaBLL.buscarTodasDespesas();
            GridDesp.DataBind();
        }
        private void preecherAllGridTipoDespesas()
        {
            Prova2Talp.BLL.TipoDespesaBLL despesaBLL = new Prova2Talp.BLL.TipoDespesaBLL();
            DataTable tb = despesaBLL.buscarTodosTiposDespesas();
            GridTipoDesp.DataBind();
        }
        private void preecherIdGridDespesas(DespesaDTO dto)
        {
            Prova2Talp.BLL.DespesaBLL despesaBLL = new Prova2Talp.BLL.DespesaBLL();
            DataTable tb = despesaBLL.buscarDespesaId(dto);
            GridDesp.DataBind();
        }
        private void preecherIdGridTipoDespesas(TipoDespesaDTO dto)
        {
            Prova2Talp.BLL.TipoDespesaBLL despesaBLL = new Prova2Talp.BLL.TipoDespesaBLL();
            DataTable tb = despesaBLL.buscarTipoDespesaId(dto);
            GridTipoDesp.DataBind();
        }
        private void preecherNomeGridDespesas(DespesaDTO dto)
        {
            Prova2Talp.BLL.DespesaBLL despesaBLL = new Prova2Talp.BLL.DespesaBLL();
            DataTable tb = despesaBLL.buscarDespesaNome(dto);
            GridDesp.DataBind();
        }
        private void preecherNomeGridTipoDespesas(TipoDespesaDTO dto)
        {
            Prova2Talp.BLL.TipoDespesaBLL despesaBLL = new Prova2Talp.BLL.TipoDespesaBLL();
            DataTable tb = despesaBLL.buscarTipoDespesaNome(dto);
            GridTipoDesp.DataBind();
        }
        private void preecherTipoGridDespesas(DespesaDTO dto)
        {
            Prova2Talp.BLL.DespesaBLL despesaBLL = new Prova2Talp.BLL.DespesaBLL();
            DataTable tb = despesaBLL.buscarDespesaIdTipo(dto);
            GridDesp.DataBind();
        }
        //-------------------------------VISIBILIDADE MENUS-------------------------------------------------
        private void VisibMenu()
        {
            PanelMenu.Visible = true;
            PanelDespesa.Visible = false;
            PanelTipo.Visible = false;

            btnVoltar.Visible = false;
        }
        private void VisibDesp()
        {
            PanelMenu.Visible = false;
            PanelDespesa.Visible = true;
            PanelTipo.Visible = false;

            btnVoltar.Visible = true;
        }
        private void VisibTipo()
        {
            PanelMenu.Visible = false;
            PanelDespesa.Visible = false;
            PanelTipo.Visible = true;

            btnVoltar.Visible = true;
        }
        //-------------------------------VISIBILIDADE DESPESA OP---------------------------------------------
        private void VisibDespesaAdd()
        {
            PnlAddDesp.Visible = true;
            PnlPesDesp.Visible = true;
            CalDesp.Visible = true;
            LblDataDesp.Visible = true;

            LblIdDesp.Visible = false;
            TxtIdDesp.Visible = false;
        }
        private void VisibDespesaId()
        {
            PnlAddDesp.Visible = false;
            PnlPesDesp.Visible = true;
            CalDesp.Visible = false;
            LblDataDesp.Visible = false;

            DdlTipoDesp.Visible = false;
            LblDdlTipoDesp.Visible = false;

            LblIdDesp.Visible = true;
            TxtIdDesp.Visible = true;

            LblNomeDesp.Visible = false;
            TxtNomeDesp.Visible = false;
        }
        private void VisibDespesaTipo()
        {
            PnlAddDesp.Visible = false;
            PnlPesDesp.Visible = true;
            CalDesp.Visible = false;
            LblDataDesp.Visible = false;

            DdlTipoDesp.Visible = true;
            LblDdlTipoDesp.Visible = true;

            LblIdDesp.Visible = false;
            TxtIdDesp.Visible = false;

            LblNomeDesp.Visible = false;
            TxtNomeDesp.Visible = false;
        }
        private void VisibDespesaNome()
        {
            PnlAddDesp.Visible = false;
            PnlPesDesp.Visible = true;
            CalDesp.Visible = false;
            LblDataDesp.Visible = false;

            DdlTipoDesp.Visible = false;
            LblDdlTipoDesp.Visible = false;

            LblIdDesp.Visible = false;
            TxtIdDesp.Visible = false;

            LblNomeDesp.Visible = true;
            TxtNomeDesp.Visible = true;
        }

        //-------------------------------VISIBILIDADE TIPO OP------------------------------------------------
        private void VisibTipoId()
        {
            TxtNomeTipoDesp.Visible = false;
            LblNomeTipoDesp.Visible = false;

            TxtIdTipoDesp.Visible = true;
            LblIdTipoDesp.Visible = true;

        }
        private void VisibTipoNome()
        {
            TxtNomeTipoDesp.Visible = true;
            LblNomeTipoDesp.Visible = true;

            TxtIdTipoDesp.Visible = false;
            LblIdTipoDesp.Visible = false;

        }
        /*--------------------------------------DESPESA------------------------------------*/
        protected void GridDesp_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DespesaDTO despesa = new DespesaDTO();
            despesa.idDespesa = int.Parse(TxtIdDesp.Text);
            despesa.nomeDespesa = TxtNomeDesp.Text;
            despesa.idTipoDespesa = int.Parse(DdlTipoDesp.SelectedItem.Text);

            GridDesp.PageIndex = e.NewPageIndex;
            if (DdlOperacaoDesp.SelectedValue.Equals("pes"))
            {
                if (DdlTipoPesDesp.SelectedValue.Equals("all"))
                {
                    preecherAllGridDespesas();
                }
                else if (DdlTipoPesDesp.SelectedValue.Equals("id"))
                {
                    preecherIdGridDespesas(despesa);
                }
                else if(DdlTipoPesDesp.SelectedValue.Equals("nome"))
                {
                    preecherNomeGridDespesas(despesa);
                }
                else
                {
                    preecherTipoGridDespesas(despesa);
                }
            }
            else
            {
                preecherAllGridDespesas();
            }
        }

        protected void DdlOperacaoDesp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DdlOperacaoDesp.SelectedValue.Equals("pes"))
            {
                LblTipoPesDesp.Visible = true;
                DdlTipoPesDesp.Visible = true;
            }
            else
            {
                LblTipoPesDesp.Visible = false;
                DdlTipoPesDesp.Visible = false;

                if (DdlOperacaoDesp.SelectedValue.Equals("add"))
                {
                    VisibDespesaAdd();
                }
                else
                {
                    VisibDespesaId();
                }
            }
        }

        protected void DdlTipoPesDesp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DdlTipoPesDesp.SelectedValue.Equals("all"))
            {
                preecherAllGridDespesas();
            }else if (DdlTipoPesDesp.SelectedValue.Equals("id"))
            {
                VisibDespesaId();
            }
            else if(DdlTipoPesDesp.SelectedValue.Equals("nome"))
            {
                VisibDespesaNome();
            }
            else
            {
                VisibDespesaTipo();
            }
        }

        protected void BtnEnviarDesp_Click(object sender, EventArgs e)
        {
            DespesaBLL despesaBLL = new DespesaBLL();
            DespesaDTO despesaDTO = new DespesaDTO();
            despesaDTO.idDespesa = int.Parse(TxtIdDesp.Text);
            despesaDTO.nomeDespesa = TxtNomeDesp.Text;
            despesaDTO.descDespesa = TxtDescDesp.Text;
            despesaDTO.valorDespesa = double.Parse(TxtVlrDesp.Text);
            despesaDTO.idTipoDespesa = int.Parse(DdlTipoDesp.SelectedValue);
            despesaDTO.dataDespesa = CalDesp.SelectedDate;

            if (DdlOperacaoDesp.SelectedValue.Equals("add"))
            {
                despesaBLL.insertDespesa(despesaDTO);
            }
            else if(DdlOperacaoDesp.SelectedValue.Equals("del"))
            {
                despesaBLL.deleteDespesa(despesaDTO);
            }
            else if (DdlTipoPesDesp.SelectedValue.Equals("tipo"))
            {
                preecherTipoGridDespesas(despesaDTO);
            }
            else if (DdlTipoPesDesp.SelectedValue.Equals("nome"))
            {
                preecherNomeGridDespesas(despesaDTO);
            }
            else if (DdlTipoPesDesp.SelectedValue.Equals("id"))
            {
                preecherIdGridDespesas(despesaDTO);
            }
            else
            {
                preecherAllGridDespesas();
            }
        }

        protected void GridDesp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*------------------------------------TIPO-DESPESA------------------------------------*/
        protected void DdlTipoOpTipoDesp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DdlTipoOpTipoDesp.SelectedValue.Equals("pes"))
            {
                LblTipoPesTipoDesp.Visible = true;
                DdlTipoPesTipoDesp.Visible = true;
            }
            else
            {
                LblTipoPesTipoDesp.Visible = false;
                DdlTipoPesTipoDesp.Visible = false;
                if (DdlTipoOpTipoDesp.SelectedValue.Equals("add"))
                {
                    VisibTipoNome();
                }
                else
                {
                    VisibTipoId();
                }
            }
        }

        protected void DdlTipoPesTipoDesp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DdlTipoPesTipoDesp.SelectedValue.Equals("all"))
            {
                preecherAllGridTipoDespesas();
            }
            else if (DdlTipoPesTipoDesp.SelectedValue.Equals("id"))
            {
                VisibTipoId();
            }
            else
            {
                VisibTipoNome();
            }
        }

        protected void BtnEnviaTipoDesp_Click(object sender, EventArgs e)
        {
            Prova2Talp.BLL.TipoDespesaBLL despesaBLL = new Prova2Talp.BLL.TipoDespesaBLL();
            TipoDespesaDTO tipoDespesaDTO = new TipoDespesaDTO();
            tipoDespesaDTO.idTipoDespesa = int.Parse(TxtIdTipoDesp.Text);
            tipoDespesaDTO.nomeTipoDespesa = TxtNomeTipoDesp.Text;

            if (DdlTipoOpTipoDesp.SelectedValue.Equals("add"))
            {
                despesaBLL.insertTipoDespesa(tipoDespesaDTO);
            }
            else if (DdlTipoOpTipoDesp.SelectedValue.Equals("del"))
            {
                despesaBLL.deleteTipoDespesa(tipoDespesaDTO);
            }
            else if(DdlTipoPesTipoDesp.SelectedValue.Equals("id"))
            {
                preecherIdGridTipoDespesas(tipoDespesaDTO);
            }
            else if (DdlTipoPesTipoDesp.SelectedValue.Equals("nome"))
            {
                preecherNomeGridTipoDespesas(tipoDespesaDTO);
            }
            else
            {
                preecherAllGridTipoDespesas();
            }
        }

        protected void GridTipoDesp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridTipoDesp_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            TipoDespesaDTO despesa = new TipoDespesaDTO();
            despesa.idTipoDespesa = int.Parse(TxtIdDesp.Text);
            despesa.nomeTipoDespesa = TxtNomeDesp.Text;

            GridDesp.PageIndex = e.NewPageIndex;
            if (DdlTipoOpTipoDesp.SelectedValue.Equals("pes"))
            {
                if (DdlTipoPesTipoDesp.SelectedValue.Equals("all"))
                {
                    preecherAllGridTipoDespesas();
                }
                else if (DdlTipoPesTipoDesp.SelectedValue.Equals("id"))
                {
                    preecherIdGridTipoDespesas(despesa);
                }
                else
                {
                    preecherNomeGridTipoDespesas(despesa);
                }
            }
            else
            {
                preecherAllGridTipoDespesas();
            }
        }
        /*------------------------------------VOLTAR------------------------------------*/
        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            VisibMenu();
        }
        /*--------------------------------------MENU------------------------------------*/
        protected void BtnAltDesp_Click(object sender, EventArgs e)
        {
            VisibDesp();
            preecherAllGridDespesas();
        }

        protected void BtnAltTipoDesp_Click(object sender, EventArgs e)
        {
            VisibTipo();
            preecherAllGridTipoDespesas();
        }
    }
}