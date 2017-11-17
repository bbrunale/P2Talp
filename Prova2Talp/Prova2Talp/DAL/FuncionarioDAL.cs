using Prova2Talp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Prova2Talp.DAL
{
    internal class FuncionarioDAL
    {
        /// <summary>
        /// buscar Funcionario a partir de um ID
        /// </summary>
        /// <param name="funcionarioDTO"></param>
        /// <returns>data table com os resultados do select</returns>
        internal DataTable buscarFuncionarioId(FuncionarioDTO funcionarioDTO)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    conn.Open();
                    var _sql = "SELECT (IdFuncionario,Nome, Email, Cpf, Senha) FROM Funcionario WHERE IdFuncionario = @idFunc ORDER BY Nome";
                    SqlCommand _command = new SqlCommand(_sql, conn);
                    _command.CommandType = CommandType.Text;

                    IDataParameter nomeParam = new SqlParameter();
                    nomeParam.ParameterName = "@idFunc";
                    nomeParam.Value = "%" + funcionarioDTO.idFuncionario + "%";
                    nomeParam.DbType = System.Data.DbType.Int32;
                    _command.Parameters.Add(nomeParam);

                    DataSet dtSet = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(_command);
                    dtAdapter.Fill(dtSet);
                    return dtSet.Tables[0];
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        /// <summary>
        /// buscar Funcionario a partir de um ID
        /// </summary>
        /// <param name="funcionarioDTO"></param>
        /// <returns>data table com os resultados do select</returns>
        internal DataTable buscarFuncionarioId(int funcionarioDTO)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    conn.Open();
                    var _sql = "SELECT (IdFuncionario,Nome, Email, Cpf, Senha) FROM Funcionario WHERE IdFuncionario = @idFunc ORDER BY Nome";
                    SqlCommand _command = new SqlCommand(_sql, conn);
                    _command.CommandType = CommandType.Text;

                    IDataParameter nomeParam = new SqlParameter();
                    nomeParam.ParameterName = "@idFunc";
                    nomeParam.Value = "%" + funcionarioDTO + "%";
                    nomeParam.DbType = System.Data.DbType.Int32;
                    _command.Parameters.Add(nomeParam);

                    DataSet dtSet = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(_command);
                    dtAdapter.Fill(dtSet);
                    return dtSet.Tables[0];
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        /// <summary>
        /// Busca todos os Funcionarios do bd
        /// </summary>
        /// <returns>Data table com os funcionarios encontradas</returns>
        internal DataTable buscarTodosFuncionario()
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    conn.Open();
                    var _sql = "SELECT (IdFuncionario,Nome, Email, Cpf, Senha) FROM Funcionario ORDER BY Nome";
                    SqlCommand command = new SqlCommand(_sql, conn);
                    command.CommandType = CommandType.Text;

                    DataSet dtSet = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(command);
                    dtAdapter.Fill(dtSet);
                    return dtSet.Tables[0];
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}