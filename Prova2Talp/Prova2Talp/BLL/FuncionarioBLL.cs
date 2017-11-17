using Prova2Talp.DAL;
using Prova2Talp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prova2Talp.BLL
{
    public class FuncionarioBLL
    {
        private FuncionarioDAL _funcionarioDAL;

        /// <summary>
        /// Metodo responsavel pela regra de negocio do Funcionario
        /// no momento de retornar todos funcionarios do bd
        /// </summary>
        /// <returns>dataTable com os Funcionarios</returns>
        public DataTable buscarTodosFuncionarios()
        {
            try
            {
                return _funcionarioDAL.buscarTodosFuncionario();
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
        /// <param name="funcionarioDTO"></param>
        /// <returns></returns>
        public DataTable buscarFuncionarioId(FuncionarioDTO funcionarioDTO)
        {
            try
            {
                return _funcionarioDAL.buscarFuncionarioId(funcionarioDTO);
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
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable buscarFuncionarioId(int id)
        {
            try
            {
                return _funcionarioDAL.buscarFuncionarioId(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}