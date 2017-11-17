using Prova2Talp.DAL;
using Prova2Talp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prova2Talp.BLL
{
    public class TipoProdutoBLL
    {
        private TipoProdutoDAL _tipoProdutoDAL;

        /// <summary>
        /// Construtor da classe
        /// Se a instancia for null, gera uma nova instancia
        /// </summary>
        public TipoProdutoBLL()
        {
            if (_tipoProdutoDAL == null)
                _tipoProdutoDAL = new DAL.TipoProdutoDAL();
        }
        /// <summary>
        /// Método responsavel pela regra de negocio do tipo Produto
        /// No momento de inserir os valores
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        public Boolean insertTipoProduto(TipoProdutoDTO dto)
        {

            try
            {
                return _tipoProdutoDAL.insertTipoProduto(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio do Tipo Produto
        /// no momento de deleta o tipo Produto desejado
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        public Boolean deleteTipoProduto(TipoProdutoDTO dto)
        {
            try
            {
                ProdutoBLL ProdutoBLL = new ProdutoBLL();
                DataTable dataTable = ProdutoBLL.buscarProdutoIdTipo(dto.idTipoProduto);
                if (dataTable.Rows.Count == 0)
                {
                    return _tipoProdutoDAL.deleteTipoProduto(dto);
                }
                else
                {
                    throw new Exception("Erro ao deletar tipo. Ainda existem produtos com este tipo");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio do Tipo Produto
        /// no momento de retornar todos os tipos Produtos do bd
        /// </summary>
        /// <returns>dataTable com os Tipos Produtos</returns>
        public DataTable buscarTodasTiposProdutos()
        {
            try
            {
                return _tipoProdutoDAL.buscarTodosTipoProdutos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio do Tipo Produto
        /// no momento de retornar o resultado da busca
        /// de um tipo Produto no sistema a partir de um pedaço ou do nome completo
        /// </summary>
        /// <param name="tipoProdutoDTO"></param>
        /// <returns></returns>
        public DataTable buscarTipoProdutoNome(TipoProdutoDTO tipoProdutoDTO)
        {
            try
            {
                return _tipoProdutoDAL.buscarTipoProdutoNome(tipoProdutoDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio do Tipo Produto
        /// no momento de retornar o resultado da busca
        /// de um Tipo Produto no sistema a partir de um ID
        /// </summary>
        /// <param name="tipoProdutoDTO"></param>
        /// <returns></returns>
        public DataTable buscarTipoProdutoId(TipoProdutoDTO tipoProdutoDTO)
        {
            try
            {
                return _tipoProdutoDAL.buscarTipoProdutoId(tipoProdutoDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}