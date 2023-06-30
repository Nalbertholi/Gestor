using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FornecedorDAL
    {
        public void Inserir(Fornecedor _fornecedor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Fornecedor(Nome, Email, Fone, Website)
                                    VALUES (@Nome, @Email, @Fone, @Website)";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _fornecedor.Nome);
                cmd.Parameters.AddWithValue("@Email", _fornecedor.Email);
                cmd.Parameters.AddWithValue("@Fone", _fornecedor.Fone);
                cmd.Parameters.AddWithValue("@Website", _fornecedor.Website);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um Fornecedor no banco de dados.", ex) { Data = { { "Id", 22 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Fornecedor> BuscarTodos()
        {
            List<Fornecedor> fornecedorList = new List<Fornecedor>();
            Fornecedor fornecedor = new Fornecedor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Email, Fone, Website FROM Fornecedor";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Fone = rd["Fone"].ToString();
                        fornecedor.Website = rd["Website"].ToString();

                        fornecedorList.Add(fornecedor);
                    }
                }
                return fornecedorList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um cliente no banco de dados.", ex) { Data = { { "Id", 23 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Fornecedor> BuscarPorNome(string _nome)
        {
            List<Fornecedor> fornecedorList = new List<Fornecedor>();
            Fornecedor fornecedor = new Fornecedor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Email, Fone, Website FROM Fornecedor WHERE Nome LIKE @Nome ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Fone = rd["Fone"].ToString();
                        fornecedor.Website = rd["Website"].ToString();

                        fornecedorList.Add(fornecedor);
                    }
                }
                return fornecedorList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar cliente por nome no banco de dados.", ex) { Data = { { "Id", 24 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Fornecedor BuscarPorId(int _id)
        {
            Fornecedor fornecedor = new Fornecedor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Email, Fone,Website FROM Fornecedor WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Fone = rd["Fone"].ToString();
                        fornecedor.Website = rd["Website"].ToString();

                    }
                }
                return fornecedor;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar cliente no banco de dados.", ex) { Data = { { "Id", 25 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Fornecedor> BuscarPorWebsite(string _website)
        {
            List<Fornecedor> fornecedorList = new List<Fornecedor>();
            Fornecedor fornecedor = new Fornecedor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Email, Fone, Website FROM Fornecedor WHERE Website LIKE @Website ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Website", "%" + _website + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Fone = rd["Fone"].ToString();
                        fornecedor.Website = rd["Website"].ToString();

                        fornecedorList.Add(fornecedor);
                    }
                }
                return fornecedorList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar cliente por nome no banco de dados.", ex) { Data = { { "Id", 24 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Fornecedor _fornecedor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Fornecedor SET 
                                    Nome = @Nome, 
                                    Email = @Email, 
                                    Fone = @Fone,
                                    Website = @Website
                                   
                                WHERE Id = @Id;";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _fornecedor.Id);
                cmd.Parameters.AddWithValue("@Nome", _fornecedor.Nome);
                cmd.Parameters.AddWithValue("Email", _fornecedor.Email);
                cmd.Parameters.AddWithValue("@Fone", _fornecedor.Fone);
                cmd.Parameters.AddWithValue("@Website", _fornecedor.Website);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar cliente no banco de dados.", ex) { Data = { { "Id", 27 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Fornecedor WHERE Id = @Id;";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um Erro ao tentar excluir cliente no banco de dados.", ex) { Data = { { "Id", 28 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}