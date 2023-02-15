using BLL;
using Models;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Nome = "Nalberth Soares Oliveira";
            usuario.NomeUsuario = "erisvaldo";
            usuario.Ativo = true;
            usuario.Email = "nalberthsoares20@gmail.com.br";
            usuario.CPF = "456,258,159-48";
            usuario.Senha = "1234567";
            usuarioBLL.Inserir(usuario);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
} 