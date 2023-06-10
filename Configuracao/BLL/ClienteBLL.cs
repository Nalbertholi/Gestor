using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteBLL
    {
        public void Inserir(Cliente _cliente)
        {
            new ClienteDAl().Inserir(_cliente); 
        }
        public List<Cliente> BuscarTodos()
        {
            return new ClienteDAl().BuscarTodos();
        }
        public List<Cliente> BuscarPorNome(string _nome)
        {
            return new ClienteDAl().BuscarPorNome( _nome);
        }
        public Cliente BuscarPorId(int _id)
        {
            return new ClienteDAl().BuscarPorId(_id);
        }
        public Cliente BuscarPorCPF(string _CPF)
        {
            return new ClienteDAl().BuscarPorCPF(_CPF);
        }
        public void Alterar(Cliente _cliente)
        {
            new ClienteDAl().Alterar(_cliente);
        }
        public void Excluir(int _id)
        {
            new ClienteDAl().Excluir(_id);
        }
    }
}
