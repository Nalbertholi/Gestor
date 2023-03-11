using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GrupoUsuarioDAL 
    { 
        public void Inserir(GrupoUsuario _grupousuario)
        {

            SqlConnection cn = new SqlConnection();

            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO GrupoUsuario(NomeGrupo) 
                                            VALUES(@NomeGrupo)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupousuario.NomeGrupo);

                cn.Open();
                cmd.ExecuteScalar();
            }

            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma permissão no banco: " + ex.Message);
            }

            finally
            {
                cn.Close();
            }
            
        }

        public List<GrupoUsuario> BuscarPorIdUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}