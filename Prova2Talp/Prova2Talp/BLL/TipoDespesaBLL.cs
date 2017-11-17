using Prova2Talp.DAL;
using Prova2Talp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prova2Talp.BLL
{
    public class TipoDespesaBLL
    {
        private TipoDespesaDAL _tipoDespesaDAL;

        /// <summary>
        /// Construtor da classe
        /// Se a instancia for null, gera uma nova instancia
        /// </summary>
        public TipoDespesaBLL()
        {
            if (_tipoDespesaDAL == null)
                _tipoDespesaDAL = new DAL.TipoDespesaDAL();
        }
        /// <summary>
        /// Método responsavel pela regra de negocio do tipo despesa
        /// No momento de inserir os valores
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        public Boolean insertTipoDespesa(TipoDespesaDTO dto)
        {

            try
            {
                    return _tipoDespesaDAL.insertTipoDespesa(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio do Tipo despesa
        /// no momento de deleta o tipo despesa desejado
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        public Boolean deleteTipoDespesa(TipoDespesaDTO dto)
        {
            try
            {
                DespesaBLL despesaBLL = new DespesaBLL();
                DataTable dataTable = despesaBLL.buscarDespesaIdTipo(dto.idTipoDespesa);
                if (dataTable.Rows.Count == 0)
                {
                    return _tipoDespesaDAL.deleteTipoDespesa(dto);
                }
                else
                {
                    throw new Exception("Erro ao deletar tipo. Ainda existem despesas com este tipo");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio do Tipo despesa
        /// no momento de retornar todos os tipos despesas do bd
        /// </summary>
        /// <returns>dataTable com os Tipos despesas</returns>
        public DataTable buscarTodosTiposDespesas()
        {
            try
            {
                return _tipoDespesaDAL.buscarTodosTipoDespesa();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio do Tipo despesa
        /// no momento de retornar o resultado da busca
        /// de um tipo despesa no sistema a partir de um pedaço ou do nome completo
        /// </summary>
        /// <param name="tipoDespesaDTO"></param>
        /// <returns></returns>
        public DataTable buscarTipoDespesaNome(TipoDespesaDTO tipoDespesaDTO)
        {
            try
            {
                return _tipoDespesaDAL.buscarTipoDespesaNome(tipoDespesaDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Metodo responsavel pela regra de negocio do Tipo despesa
        /// no momento de retornar o resultado da busca
        /// de um Tipo despesa no sistema a partir de um ID de tipo de despesa
        /// </summary>
        /// <param name="tipoDespesaDTO"></param>
        /// <returns></returns>
        public DataTable buscarTipoDespesaId(TipoDespesaDTO tipoDespesaDTO)
        {
            try
            {
                return _tipoDespesaDAL.buscarTipoDespesaId(tipoDespesaDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}