using Prova2Talp.DAL;
using Prova2Talp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prova2Talp.BLL
{
    public class PagamentoBLL
    {
        private PagamentoDAL _pagamentoDAL;

        /// <summary>
        /// Metodo responsavel pela regra de negocio do Pagamento
        /// no momento de retornar todos Pagamentos do bd
        /// </summary>
        /// <returns>dataTable com os Pagamentos</returns>
        public DataTable buscarTodosPagamentos()
        {
            try
            {
                return _pagamentoDAL.buscarTodosPagamentos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo responsavel pela regra de negocio do Funcionario
        /// no momento de retornar o resultado da busca
        /// de um Funcionario no sistema a partir de um ID
        /// </summary>
        /// <param name="pagamentoDTO"></param>
        /// <returns></returns>
        public DataTable buscarPagamentoId(PagamentoDTO pagamentoDTO)
        {
            try
            {
                return _pagamentoDAL.buscarPagamentoId(pagamentoDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio do pagamento
        /// no momento de retornar o resultado da busca
        /// de um pagamento no sistema a partir de um ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable buscarPagamentoId(int id)
        {
            try
            {
                return _pagamentoDAL.buscarPagamentoId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}