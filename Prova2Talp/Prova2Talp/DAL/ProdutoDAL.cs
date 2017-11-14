using Prova2Talp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Prova2Talp.DAL
{
    public class ProdutoDAL
    {
        /// <summary>
        /// Insere um Produto no sistema
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        internal Boolean insertVenda(ProdutoDTO dto)
        {

            var _strDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"];
            using (SqlConnection conn = new SqlConnection(_strDeConexao.ToString()))
                try
                {
                    //abre o banco de dados
                    conn.Open();
                    //prepara comando para enviar ao BD
                    var _insert = "INSERT INTO [dbo].[Produto] ([NomeProduto],[ValorProduto],[QtdeProduto],[DescProduto],[CustoProducao],[IdTipoProduto]) VALUES (@nomeProduto,@valorProduto,@qtdeProduto,@descProduto, @custoProducao,@idTipo";
                    //Utiliza o sqlCommand para enviar os dados ao banco
                    SqlCommand _command = new SqlCommand(_insert, conn);
                    _command.Parameters.AddWithValue("@nomeProduto", dto.nomeProduto);
                    _command.Parameters.AddWithValue("@valorProduto", dto.valorProduto);
                    _command.Parameters.AddWithValue("@qtdeProduto", dto.qtdeProduto);
                    _command.Parameters.AddWithValue("@descProduto", dto.descProduto);
                    _command.Parameters.AddWithValue("@custoProducao", dto.custoProducao);
                    _command.Parameters.AddWithValue("@idTipo", dto.idTipoProduto);
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
        /// Deleta um produto no sistema
        /// </summary>
        /// <param name="dto"></param>
        /// <returns>true se obtiver exito, false se não</returns>
        internal Boolean deleteProduto(ProdutoDTO dto)
        {

            var _strDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"];
            using (SqlConnection conn = new SqlConnection(_strDeConexao.ToString()))
                try
                {
                    //abre o banco de dados
                    conn.Open();
                    //prepara comando para enviar ao BD
                    var _delete = "DELETE FROM Produto where IdProduto = @idProduto";
                    //Utiliza o sqlCommand para enviar os dados ao banco
                    SqlCommand _command = new SqlCommand(_delete, conn);
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
        /// Busca todos os Produtos do bd
        /// </summary>
        /// <returns>Data table com os Produtos encontrados</returns>
        internal DataTable buscarTodosProdutos()
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    conn.Open();
                    var _sql = "A.NomeProduto,A.ValorProduto,A.QtdeProduto,A.DescProduto,A.CustoProducao,E.NomeTipoProduto) FROM Produto A, TipoProduto E WHERE A.IdTipoProduto = E.IdTipoProduto ORDER BY A.IdProduto";
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
        /// buscar Produto a partir de um ID
        /// </summary>
        /// <param name="ProdutoDTO"></param>
        /// <returns>data table com os resultados do select</returns>
        internal DataTable buscarProdutoId(ProdutoDTO ProdutoDTO)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    conn.Open();
                    var _sql = "SELECT (A.NomeProduto,A.ValorProduto,A.QtdeProduto,A.DescProduto,A.CustoProducao,E.NomeTipoProduto) FROM Produto A, TipoProduto E WHERE A.IdTipoProduto = E.IdTipoProduto AND A.IdProduto = @idProduto ORDER BY A.IdProduto";
                    SqlCommand _command = new SqlCommand(_sql, conn);
                    _command.CommandType = CommandType.Text;

                    IDataParameter nomeParam = new SqlParameter();
                    nomeParam.ParameterName = "@idProduto";
                    nomeParam.Value = "%" + ProdutoDTO.idProduto + "%";
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
        /// buscar Produto a partir de um ID de Tipo de Produto
        /// </summary>
        /// <param name="ProdutoDTO"></param>
        /// <returns>data table com os resultados do select</returns>
        internal DataTable buscarProdutoIdTipo(ProdutoDTO ProdutoDTO)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    conn.Open();
                    var _sql = "SELECT (A.NomeProduto,A.ValorProduto,A.QtdeProduto,A.DescProduto, A.CustoProducao, E.NomeTipoProduto FROM Produto A, TipoProduto E WHERE A.IdTipoProduto = E.IdTipoProduto AND A.IdTipoProduto = @idTipo ORDER BY A.IdProduto";
                    SqlCommand _command = new SqlCommand(_sql, conn);
                    _command.CommandType = CommandType.Text;

                    IDataParameter nomeParam = new SqlParameter();
                    nomeParam.ParameterName = "@idTipo";
                    nomeParam.Value = "%" + ProdutoDTO.idTipoProduto + "%";
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
        /// buscar Produtos a partir de uma string
        /// </summary>
        /// <param name="ProdutoDTO"></param>
        /// <returns>data table com os resultados do select</returns>
        internal DataTable buscarProdutoNome(ProdutoDTO ProdutoDTO)
        {
            var _stringDeConexao = System.Configuration.ConfigurationManager.ConnectionStrings["MinhaConexao"].ToString();
            using (SqlConnection conn = new SqlConnection(_stringDeConexao))
            {
                try
                {
                    conn.Open();
                    var _sql = "SELECT (A.NomeProduto,A.ValorProduto,A.QtdeProduto,A.DescProduto,A.CustoProducao,E.NomeTipoProduto) FROM Produto A, TipoProduto E WHERE A.IdTipoProduto = E.IdTipoProduto AND A.NomeProduto like @nomeProduto ORDER BY A.IdProduto";
                    SqlCommand _command = new SqlCommand(_sql, conn);
                    _command.CommandType = CommandType.Text;

                    IDataParameter nomeParam = new SqlParameter();
                    nomeParam.ParameterName = "@nomeProduto";
                    nomeParam.Value = "%" + ProdutoDTO.nomeProduto + "%";
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