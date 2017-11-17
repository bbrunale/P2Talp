using Prova2Talp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Prova2Talp.DAL
{
    internal class ListaDAL
    {
        /// <summary>
        /// Insere uma lista no sistema
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        internal Boolean insertLista(ListaDTO dto)
        {

            var _strDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"];
            using (SqlConnection conn = new SqlConnection(_strDeConexao.ToString()))
                try
                {
                    //abre o banco de dados
                    conn.Open();
                    //prepara comando para enviar ao BD
                    var _insert = "INSERT INTO Lista (IdVenda,IdProduto,VlrHistorico,QtdeLista) VALUES (@idVenda,@idProduto,@vlrHistorico,@qtdeLista";
                    //Utiliza o sqlCommand para enviar os dados ao banco
                    SqlCommand _command = new SqlCommand(_insert, conn);
                    _command.Parameters.AddWithValue("@idVenda", dto.idVenda);
                    _command.Parameters.AddWithValue("@idProduto", dto.idProduto);
                    _command.Parameters.AddWithValue("@vlrHistorico", dto.vlrHistorico);
                    _command.Parameters.AddWithValue("@qtdeLista", dto.qtdeLista);
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
        /// Deleta listas no sistema dado uma determinada venda
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        internal Boolean deleteListaPorVenda(ListaDTO dto)
        {

            var _strDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"];
            using (SqlConnection conn = new SqlConnection(_strDeConexao.ToString()))
                try
                {
                    //abre o banco de dados
                    conn.Open();
                    //prepara comando para enviar ao BD
                    var _delete = "DELETE FROM Lista where IdVenda = @idVenda";
                    //Utiliza o sqlCommand para enviar os dados ao banco
                    SqlCommand _command = new SqlCommand(_delete, conn);
                    _command.Parameters.AddWithValue("@idVenda", dto.idVenda);
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
        /// Deleta uma lista no sistema 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        internal Boolean deleteLista(ListaDTO dto)
        {

            var _strDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"];
            using (SqlConnection conn = new SqlConnection(_strDeConexao.ToString()))
                try
                {
                    //abre o banco de dados
                    conn.Open();
                    //prepara comando para enviar ao BD
                    var _delete = "DELETE FROM Lista where IdVenda = @idVenda AND IdProduto = @idProduto";
                    //Utiliza o sqlCommand para enviar os dados ao banco
                    SqlCommand _command = new SqlCommand(_delete, conn);
                    _command.Parameters.AddWithValue("@idVenda", dto.idVenda);
                    _command.Parameters.AddWithValue("@idProduto", dto.idProduto);
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
        /// Busca todas as Listas do bd
        /// </summary>
        /// <returns>Data table com as Despesas encontrados</returns>
        internal DataTable buscarTodasListas()
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    conn.Open();
                    var _sql = "SELECT (A.IdVenda,E.NomeProduto,A.VlrHistorico,A.QtdeLista) FROM Lista A, Produto E WHERE A.IdProduto = E.IdProduto  ORDER BY E.NomeProduto";
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
        /// buscar Listas a partir de um ID de venda
        /// </summary>
        /// <param name="listaDTO"></param>
        /// <returns>data table com os resultados do select</returns>
        internal DataTable buscarListaIdVenda(ListaDTO listaDTO)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    conn.Open();
                    var _sql = "SELECT (A.IdVenda,E.NomeProduto,A.VlrHistorico,A.QtdeLista) FROM Lista A, Produto E WHERE A.IdProduto = E.IdProduto AND A.idVenda = @idVenda  ORDER BY E.NomeProduto";
                    SqlCommand _command = new SqlCommand(_sql, conn);
                    _command.CommandType = CommandType.Text;

                    IDataParameter nomeParam = new SqlParameter();
                    nomeParam.ParameterName = "@idVenda";
                    nomeParam.Value = "%" + listaDTO.idVenda + "%";
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
        /// buscar Lista a partir de um ID de Produto
        /// </summary>
        /// <param name="listaDTO"></param>
        /// <returns>data table com os resultados do select</returns>
        internal DataTable buscarListaIdProduto(ListaDTO listaDTO)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    conn.Open();
                    var _sql = "SELECT (A.IdVenda,E.NomeProduto,A.VlrHistorico,A.QtdeLista) FROM Lista A, Produto E WHERE A.IdProduto = E.IdProduto AND A.idProduto = @idProduto  ORDER BY E.NomeProduto";
                    SqlCommand _command = new SqlCommand(_sql, conn);
                    _command.CommandType = CommandType.Text;

                    IDataParameter nomeParam = new SqlParameter();
                    nomeParam.ParameterName = "@idProduto";
                    nomeParam.Value = "%" + listaDTO.idProduto + "%";
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
    }
}