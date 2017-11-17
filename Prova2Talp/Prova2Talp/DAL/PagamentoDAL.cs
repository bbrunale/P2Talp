using Prova2Talp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Prova2Talp.DAL
{
    internal class PagamentoDAL
    {
        /// <summary>
        /// buscar Pagamento a partir de um ID
        /// </summary>
        /// <param name="pagamentoDTO"></param>
        /// <returns>data table com os resultados do select</returns>
        internal DataTable buscarPagamentoId(PagamentoDTO pagamentoDTO)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    conn.Open();
                    var _sql = "SELECT (IdForma,NomeForma,DiasCompensacao, TarifaServico) FROM Pagamento WHERE IdForma = @idForma ORDER BY idPagamento";
                    SqlCommand _command = new SqlCommand(_sql, conn);
                    _command.CommandType = CommandType.Text;

                    IDataParameter nomeParam = new SqlParameter();
                    nomeParam.ParameterName = "@idForma";
                    nomeParam.Value = "%" + pagamentoDTO.idForma + "%";
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
        /// buscar Pagamento a partir de um ID
        /// </summary>
        /// <param name="pagamentoDTO"></param>
        /// <returns>data table com os resultados do select</returns>
        internal DataTable buscarPagamentoId(int pagamentoDTO)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    conn.Open();
                    var _sql = "SELECT (IdForma,NomeForma,DiasCompensacao, TarifaServico) FROM Pagamento WHERE IdForma = @idForma ORDER BY idPagamento";
                    SqlCommand _command = new SqlCommand(_sql, conn);
                    _command.CommandType = CommandType.Text;

                    IDataParameter nomeParam = new SqlParameter();
                    nomeParam.ParameterName = "@idForma";
                    nomeParam.Value = "%" + pagamentoDTO + "%";
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
        /// Busca todas as formas de pagamento do bd
        /// </summary>
        /// <returns>Data table com as formas de pagamento encontradas</returns>
        internal DataTable buscarTodosPagamentos()
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    conn.Open();
                    var _sql = "SELECT (IdForma,NomeForma,DiasCompensacao, TarifaServico) FROM Pagamento ORDER BY idPagamento";
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