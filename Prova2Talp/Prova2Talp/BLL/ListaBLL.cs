using Prova2Talp.DAL;
using Prova2Talp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prova2Talp.BLL
{
    public class ListaBLL
    {
        private ListaDAL _listaDAL;

        /// <summary>
        /// Construtor da classe
        /// Se a instancia for null, gera uma nova instancia
        /// </summary>
        public ListaBLL()
        {
            if (_listaDAL == null)
                _listaDAL = new ListaDAL();
        }
        /// <summary>
        /// Método responsavel pela regra de negocio da Lista
        /// No momento de inserir os valores
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        public Boolean insertLista(ListaDTO dto)
        {
            
            try
            {
                //verifica se a venda existe
                VendaBLL vendaBLL = new VendaBLL();
                DataTable dataTableVenda = vendaBLL.buscarVendaId(dto.idVenda);
                ProdutoBLL produtoBLL = new ProdutoBLL();
                DataTable dataTable = produtoBLL.buscarProdutoId(dto.idProduto);
                if (dataTable.Rows.Count == 0 || dataTableVenda.Rows.Count == 0)
                {
                    throw new Exception("Venda ou Produto nao encontrados");
                }
                else if (dto.vlrHistorico <= 0 || Convert.ToInt32(dataTable.Rows[0]["QtdeProduto"]) >= dto.qtdeLista)
                {
                    throw new Exception("Valor do Produto deve ser positivo e a quantidade de");
                }
                else
                {
                    return _listaDAL.insertLista(dto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio da lista
        /// no momento de deleta a lista desejada
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        public Boolean deleteLista(ListaDTO dto)
        {
            try
            {
                return _listaDAL.deleteLista(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio da Lista
        /// no momento de retornar todos as Listas do bd
        /// </summary>
        /// <returns>dataTable com as Listas</returns>
        public DataTable buscarTodasListas()
        {
            try
            {
                return _listaDAL.buscarTodasListas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo responsavel pela regra de negocio da Lista
        /// no momento de retornar o resultado da busca
        /// de uma Lista no sistema a partir de um ID de Venda
        /// </summary>
        /// <param name="listaDTO"></param>
        /// <returns></returns>
        public DataTable buscarListaIdVenda(ListaDTO listaDTO)
        {
            try
            {
                return _listaDAL.buscarListaIdVenda(listaDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio da Lista
        /// no momento de retornar o resultado da busca
        /// de uma Lista no sistema a partir de um ID
        /// </summary>
        /// <param name="listaDTO"></param>
        /// <returns></returns>
        public DataTable buscarListaIdProduto(ListaDTO listaDTO)
        {
            try
            {
                return _listaDAL.buscarListaIdProduto(listaDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}