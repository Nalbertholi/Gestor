using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PermissaoBLL
    {
        public void Inserir(Permissao _permissao)
        {
            if (_permissao.Descricao.Length <= 10 || _permissao.Descricao.Length >= 50)
                throw new Exception("A descrição da permissao de usuário deve ter ais de 10 caracteres.");

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Inserir(_permissao);
        }
    }
}
