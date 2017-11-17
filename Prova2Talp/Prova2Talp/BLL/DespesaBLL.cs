using Prova2Talp.DAL;
using Prova2Talp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prova2Talp.BLL
{
    public class DespesaBLL
    {
        private new DespesaDAL _despesaDAL;

        /// <summary>
        /// Construtor da classe
        /// Se a instancia for null, gera uma nova instancia
        /// </summary>
        public DespesaBLL()
        {
            if (_despesaDAL == null)
                _despesaDAL = new DAL.DespesaDAL();
        }
        /// <summary>
        /// Método responsavel pela regra de negocio da despesa
        /// No momento de inserir os valores
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        public Boolean insertDespesa(DespesaDTO dto)
        {

            try
            {
                if (dto.valorDespesa <= 0)
                {
                    throw new Exception("Valor da despesa deve ser positivo");
                }
                else
                {
                    return _despesaDAL.insertDespesa(dto);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio da despesa
        /// no momento de deleta a despesa desejado
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        public Boolean deleteDespesa(DespesaDTO dto)
        {
            try
            {
                return _despesaDAL.deleteDespesa(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio da despesa
        /// no momento de retornar todos as despesas do bd
        /// </summary>
        /// <returns>dataTable com as despesas</returns>
        public DataTable buscarTodasDespesas()
        {
            
            try
            {
               
                return _despesaDAL.buscarTodosDespesa();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio da despesa
        /// no momento de retornar o resultado da busca
        /// de uma despesa no sistema a partir de um pedaço ou do nome completo
        /// </summary>
        /// <param name="despesaDTO"></param>
        /// <returns></returns>
        public DataTable buscarDespesaNome(DespesaDTO despesaDTO)
        {
            try
            {
                return _despesaDAL.buscarDespesaNome(despesaDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio da despesa
        /// no momento de retornar o resultado da busca
        /// de uma despesa no sistema a partir de um ID de tipo de despesa
        /// </summary>
        /// <param name="despesaDTO"></param>
        /// <returns></returns>
        public DataTable buscarDespesaIdTipo(DespesaDTO despesaDTO)
        {
            try
            {
                return _despesaDAL.buscarDespesaIdTipo(despesaDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio da despesa
        /// no momento de retornar o resultado da busca
        /// de uma despesa no sistema a partir de um ID de tipo de despesa
        /// </summary>
        /// <param name="despesaDTO"></param>
        /// <returns></returns>
        public DataTable buscarDespesaIdTipo(int id)
        {
            try
            {
                return _despesaDAL.buscarDespesaIdTipo(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio da despesa
        /// no momento de retornar o resultado da busca
        /// de uma despesa no sistema a partir de um ID
        /// </summary>
        /// <param name="despesaDTO"></param>
        /// <returns></returns>
        public DataTable buscarDespesaId(DespesaDTO despesaDTO)
        {
            try
            {
                return _despesaDAL.buscarDespesaId(despesaDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}