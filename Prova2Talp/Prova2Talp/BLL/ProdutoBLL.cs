using Prova2Talp.DAL;
using Prova2Talp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prova2Talp.BLL
{
    public class ProdutoBLL
    {
        private ProdutoDAL _produtoDAL;

        /// <summary>
        /// Construtor da classe
        /// Se a instancia for null, gera uma nova instancia
        /// </summary>
        public ProdutoBLL()
        {
            if (_produtoDAL == null)
                _produtoDAL = new ProdutoDAL();
        }
        /// <summary>
        /// Método responsavel pela regra de negocio da despesa
        /// No momento de inserir os valores
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        public Boolean insertProduto(ProdutoDTO dto)
        {

            try
            {
               if (dto.valorProduto <= 0 || dto.qtdeProduto < 0)
                {
                    throw new Exception("Valor do Produto e quantidade devem ser positivos");
                }
                else if (dto.valorProduto > dto.custoProducao)
                {
                    throw new Exception("Valor do produto deve ser maior que o custo de producao");
                }
                else
                {
                    return _produtoDAL.insertProduto(dto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio do Produto
        /// no momento de deleta o Produto desejado
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        public Boolean deleteProduto(ProdutoDTO dto)
        {
            try
            {
                //verifica se o produto existe entre as listas
                ListaBLL listaBLL = new ListaBLL();
                ListaDTO listaDTO = new ListaDTO();
                listaDTO.idProduto = dto.idProduto;
                DataTable dataTable = listaBLL.buscarListaIdProduto(listaDTO);
                if (dataTable.Rows.Count == 0)
                {
                    throw new Exception("Produto nao pode ser deletado pois ainda esta presente em listas");
                }
                else
                {
                    return _produtoDAL.deleteProduto(dto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio do Produto
        /// no momento de retornar todos os Produtos do bd
        /// </summary>
        /// <returns>dataTable com os Produtos</returns>
        public DataTable buscarTodasProduto()
        {
            try
            {
                return _produtoDAL.buscarTodosProdutos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio do Produto
        /// no momento de retornar o resultado da busca
        /// de um Produto no sistema a partir de um pedaço ou do nome completo
        /// </summary>
        /// <param name="produtoDTO"></param>
        /// <returns></returns>
        public DataTable buscarProdutoNome(ProdutoDTO produtoDTO)
        {
            try
            {
                return _produtoDAL.buscarProdutoNome(produtoDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio do Produto
        /// no momento de retornar o resultado da busca
        /// de um Produto no sistema a partir de um ID de tipo de Produto
        /// </summary>
        /// <param name="produtoDTO"></param>
        /// <returns></returns>
        public DataTable buscarProdutoIdTipo(ProdutoDTO produtoDTO)
        {
            try
            {
                return _produtoDAL.buscarProdutoIdTipo(produtoDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio do Produto
        /// no momento de retornar o resultado da busca
        /// de um Produto no sistema a partir de um ID de tipo de Produto
        /// </summary>
        /// <param name="produtoDTO"></param>
        /// <returns></returns>
        public DataTable buscarProdutoIdTipo(int id)
        {
            try
            {
                return _produtoDAL.buscarProdutoIdTipo(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio do Produto
        /// no momento de retornar o resultado da busca
        /// de um Produto no sistema a partir de um ID
        /// </summary>
        /// <param name="produtoDTO"></param>
        /// <returns></returns>
        public DataTable buscarProdutoId(ProdutoDTO produtoDTO)
        {
            try
            {
                return _produtoDAL.buscarProdutoId(produtoDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio do Produto
        /// no momento de retornar o resultado da busca
        /// de um Produto no sistema a partir de um ID
        /// </summary>
        /// <param name="produtoDTO"></param>
        /// <returns></returns>
        public DataTable buscarProdutoId(int id)
        {
            try
            {
                return _produtoDAL.buscarProdutoId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}