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
                throw new Exception("Ocorreu um erro ao tentar inserir um cliente no banco de dados.", ex) { Data = { { "Id", 16 } } };
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
                cmd.CommandText = @"SELECT Id, Nome, CPF, RG, Email, Fone FROM Cliente WHERE Nome LIKE @Nome ";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        cliente.Id = (int)rd["Id"];
                        cliente.Nome = rd["Nome"].ToString();
                        cliente.CPF = rd["CPF"].ToString();
                        cliente.RG = rd["RG"].ToString();
                        cliente.Email = rd["Email"].ToString();
                        cliente.Fone = rd["Fone"].ToString();

                        clienteList.Add(cliente);
                    }
                }
                return clienteList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar cliente por nome no banco de dados.", ex) { Data = { { "Id", 17 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Fornecedor BuscarPorId(int _id)
        {
            throw new NotImplementedException();
        }
        public Fornecedor BuscarPorWebsite(string _website)
        {
            throw new NotImplementedException();
        }
        public void Alterar(Fornecedor _fornecedor)
        {
            throw new NotImplementedException();
        }
        public void Excluir(int _id)
        {
            throw new NotImplementedException();
        }
    }
}
