using Prova2Talp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Prova2Talp.DAL
{
    internal class DespesaDAL
    {
        /// <summary>
        /// Insere um Despesa no sistema
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        internal Boolean insertDespesa(DespesaDTO dto)
        {

            var _strDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"];
            using (SqlConnection conn = new SqlConnection(_strDeConexao.ToString()))
                try
                {
                    //abre o banco de dados
                    conn.Open();
                    //prepara comando para enviar ao BD
                    var _insert = "INSERT INTO [dbo].[Despesas] ([NomeDespesa],[ValorDespesa],[DescDespesa],[IdTipoDespesa], [DataDespesa]) VALUES (@nomeDespesa,@valorDespesa,@descDespesa,@idTipo,@dataDespesa";
                    //Utiliza o sqlCommand para enviar os dados ao banco
                    SqlCommand _command = new SqlCommand(_insert, conn);
                    _command.Parameters.AddWithValue("@nomeDespesa", dto.nomeDespesa);
                    _command.Parameters.AddWithValue("@valorDespesa", dto.valorDespesa);
                    _command.Parameters.AddWithValue("@descDespesa", dto.descDespesa);
                    _command.Parameters.AddWithValue("@idTipo", dto.idTipoDespesa);
                    _command.Parameters.AddWithValue("@DataDespesa", dto.dataDespesa);
                    _command.ExecuteNonQuery();

                    return true;
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
        /// <summary>
        /// Deleta uma despesa no sistema
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        internal Boolean deleteDespesa(DespesaDTO dto)
        {

            var _strDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"];
            using (SqlConnection conn = new SqlConnection(_strDeConexao.ToString()))
                try
                {
                    //abre o banco de dados
                    conn.Open();
                    //prepara comando para enviar ao BD
                    var _delete = "DELETE FROM Despesas where IdDespesa = @idDespesa";
                    //Utiliza o sqlCommand para enviar os dados ao banco
                    SqlCommand _command = new SqlCommand(_delete, conn);
                    _command.Parameters.AddWithValue("@idDespesa", dto.idDespesa);
                    _command.ExecuteNonQuery();

                    return true;
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
        /// <summary>
        /// Busca todas as Despesas do bd
        /// </summary>
        /// <returns>Data table com as Despesas encontrados</returns>
        internal DataTable buscarTodosDespesa()
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    conn.Open();
                    var _sql = "SELECT A.NomeDespesa, A.ValorDespesa,A.DescDespesa,e.NomeTipoDespesa , A.DataDespesa FROM Despesas AS A INNER JOIN TipoDespesa AS E ON A.IdTipoDespesa = E.IdTipoDespesa WHERE A.IdTipoDespesa = E.IdTipoDespesa ORDER BY A.IdDespesa";
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
        /// <summary>
        /// buscar Despesa a partir de um ID
        /// </summary>
        /// <param name="despesaDTO"></param>
        /// <returns>data table com os resultados do select</returns>
        internal DataTable buscarDespesaId(DespesaDTO despesaDTO)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    conn.Open();
                    var _sql = "SELECT A.NomeDespesa, A.ValorDespesa,A.DescDespesa,e.NomeTipoDespesa , A.DataDespesa FROM Despesas AS A INNER JOIN TipoDespesa AS E ON A.IdTipoDespesa = E.IdTipoDespesa WHERE A.IdTipoDespesa = E.IdTipoDespesa AND A.IdDespesa = @idDespesa ORDER BY A.IdDespesa";
                    SqlCommand _command = new SqlCommand(_sql, conn);
                    _command.CommandType = CommandType.Text;

                    IDataParameter nomeParam = new SqlParameter();
                    nomeParam.ParameterName = "@idDespesa";
                    nomeParam.Value = "%" + despesaDTO.idDespesa + "%";
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
        /// buscar Despesa a partir de um ID de Tipo de Despesa
        /// </summary>
        /// <param name="despesaDTO"></param>
        /// <returns>data table com os resultados do select</returns>
        internal DataTable buscarDespesaIdTipo(DespesaDTO despesaDTO)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    conn.Open();
                    var _sql = "SELECT A.NomeDespesa, A.ValorDespesa,A.DescDespesa,e.NomeTipoDespesa , A.DataDespesa FROM Despesas AS A INNER JOIN TipoDespesa AS E ON A.IdTipoDespesa = E.IdTipoDespesa WHERE A.IdTipoDespesa = E.IdTipoDespesa AND A.IdTipoDespesa = @idTipo ORDER BY A.IdDespesa";
                    SqlCommand _command = new SqlCommand(_sql, conn);
                    _command.CommandType = CommandType.Text;

                    IDataParameter nomeParam = new SqlParameter();
                    nomeParam.ParameterName = "@idTipo";
                    nomeParam.Value = "%" + despesaDTO.idTipoDespesa + "%";
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
        /// buscar Despesa a partir de um ID de Tipo de Despesa
        /// </summary>
        /// <param name="despesaDTO"></param>
        /// <returns>data table com os resultados do select</returns>
        internal DataTable buscarDespesaIdTipo(int id)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    conn.Open();
                    var _sql = "SELECT A.NomeDespesa, A.ValorDespesa,A.DescDespesa,e.NomeTipoDespesa , A.DataDespesa FROM Despesas AS A INNER JOIN TipoDespesa AS E ON A.IdTipoDespesa = E.IdTipoDespesa WHERE A.IdTipoDespesa = E.IdTipoDespesa AND A.IdTipoDespesa = @idTipo ORDER BY A.IdDespesa";
                    SqlCommand _command = new SqlCommand(_sql, conn);
                    _command.CommandType = CommandType.Text;

                    IDataParameter nomeParam = new SqlParameter();
                    nomeParam.ParameterName = "@idTipo";
                    nomeParam.Value = "%" + id + "%";
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
        /// buscar Despesa a partir de uma string
        /// </summary>
        /// <param name="despesaDTO"></param>
        /// <returns>data table com os resultados do select</returns>
        internal DataTable buscarDespesaNome(DespesaDTO despesaDTO)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    conn.Open();
                    var _sql = "SELECT A.NomeDespesa, A.ValorDespesa,A.DescDespesa,e.NomeTipoDespesa , A.DataDespesa FROM Despesas AS A INNER JOIN TipoDespesa AS E ON A.IdTipoDespesa = E.IdTipoDespesa WHERE A.IdTipoDespesa = E.IdTipoDespesa AND A.IdTipoDespesa = @nomeDespesa ORDER BY A.IdDespesa";
                    SqlCommand _command = new SqlCommand(_sql, conn);
                    _command.CommandType = CommandType.Text;

                    IDataParameter nomeParam = new SqlParameter();
                    nomeParam.ParameterName = "@nomeTipo";
                    nomeParam.Value = "%" + despesaDTO.nomeDespesa + "%";
                    nomeParam.DbType = System.Data.DbType.String;
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
    }
}