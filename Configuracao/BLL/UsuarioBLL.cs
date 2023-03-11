using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario)
        {
            if (_usuario.NomeUsuario.Length <= 3 || _usuario.NomeUsuario.Length >= 50)
            {
                throw new Exception("O nome de usuario deve ter mais de três caracteres.");
            }

            if (_usuario.NomeUsuario.Contains(" "))
            {
                throw new Exception("O nome de usuario não pode conter espaço.");
            }

            if (_usuario.NomeUsuario.Contains("1234567"))
                throw new Exception("Não é permitido um número sequencial.");

            if (_usuario.NomeUsuario.Length <= 3)
                throw new Exception("O nome de usuario deve ter mais de três caracteres.");

            if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
            {
                throw new Exception("A senha deve ter entre 7 e 11 caracteres.");
            }

            //TODO: Validar se já existe um usuario com este nome.

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }

        public List<Usuario> BuscarTodos()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarTodos();
        }
        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            if (String.IsNullOrEmpty(_nomeUsuario))
                throw new Exception("Informe o nome do usuario. ");

            UsuarioDAL usuarioDAL = new UsuarioDAL();

            return usuarioDAL.BuscarPorNomeUsuario(_nomeUsuario);
        }

        public void Alterar(Usuario _usuario)
        {

        }

        public void Excluir(int _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL
            usuarioDAL
        }


    }
}