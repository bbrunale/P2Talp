using Prova2Talp.DAL;
using Prova2Talp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prova2Talp.BLL
{
    public class VendaBLL
    {
        private VendaDAL _vendaDAL;

        /// <summary>
        /// Construtor da classe
        /// Se a instancia for null, gera uma nova instancia
        /// </summary>
        public VendaBLL()
        {
            if (_vendaDAL == null)
                _vendaDAL = new DAL.VendaDAL();
        }
        /// <summary>
        /// Método responsavel pela regra de negocio da venda
        /// No momento de inserir os valores
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        public Boolean insertVenda(VendaDTO dto)
        {

            try
            {
                //pagamento foreign key
                return _vendaDAL.insertVenda(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio da Venda
        /// no momento de deleta a Venda desejada
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        public Boolean deleteVenda(VendaDTO dto)
        {
            try
            {
                ListaBLL listaBLL = new ListaBLL();
                ListaDTO listaDTO = new ListaDTO();
                listaDTO.idProduto = dto.idVenda;
                DataTable dataTable = listaBLL.buscarListaIdVenda(listaDTO);
                if (dataTable.Rows.Count == 0)
                {
                    throw new Exception("Venda nao pode ser deletado pois ainda esta presente em listas");
                }
                else
                {
                    return _vendaDAL.deleteVenda(dto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio da Venda
        /// no momento de retornar todas vendas do bd
        /// </summary>
        /// <returns>dataTable com as Venda</returns>
        public DataTable buscarTodasVendas()
        {
            try
            {
                return _vendaDAL.buscarTodasVendas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Metodo responsavel pela regra de negocio da Venda
        /// no momento de retornar o resultado da busca
        /// de uma Venda no sistema a partir de um ID
        /// </summary>
        /// <param name="vendaDTO"></param>
        /// <returns></returns>
        public DataTable buscarVendaId(VendaDTO vendaDTO)
        {
            try
            {
                return _vendaDAL.buscarVendaId(vendaDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio da Venda
        /// no momento de retornar o resultado da busca
        /// de uma Venda no sistema a partir de um ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable buscarVendaId(int id)
        {
            try
            {
                return _vendaDAL.buscarVendaId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}